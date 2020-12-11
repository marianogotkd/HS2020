Public Class Consultas_Movimientos_b

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        recuperar_rango_todos()
    End Sub

    Dim DAmovimientos As New Datos.Gestion_Mercaderia

    Private Sub recuperar_rango_todos()
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_mov_obtener_detalle_b_rango_fechas_todos(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            Ds_consulta_movimientos.Tables("Movimientos").Rows.Clear()
            'D_consulta_mov_alta.Tables("movimientos_consulta").Merge(ds_consulta.Tables(0))

            'D_consulta_mov_alta.Tables("movimientos_consulta_b").Merge(ds_mov.Tables(0))
            Dim sumacantidad As Decimal = 0
            Dim i As Integer = 0
            Dim j As Integer
            While i < ds_mov.Tables(0).Rows.Count
                'aqui creo la celda en el dataset
                Dim fila As DataRow = Ds_consulta_movimientos.Tables("Movimientos").NewRow
                fila("ID") = ds_mov.Tables(0).Rows(i).Item("prod_codinterno")
                fila("Insumo") = ds_mov.Tables(0).Rows(i).Item("prod_descripcion")

                'busco suc origen.
                Dim origen_id As Integer = ds_mov.Tables(0).Rows(i).Item("sucursal_id_Origen")
                Dim k As Integer = 0
                While k < ds_mov.Tables(1).Rows.Count
                    If ds_mov.Tables(1).Rows(k).Item("sucursal_id") = origen_id Then
                        fila("Suc.Origen") = ds_mov.Tables(1).Rows(k).Item("sucursal_nombre")
                        Exit While
                    Else
                        k = k + 1
                    End If
                End While
                'busco suc destino.
                Dim destino_id As Integer = ds_mov.Tables(0).Rows(i).Item("sucursal_id_Destino")
                k = 0
                While k < ds_mov.Tables(1).Rows.Count
                    If ds_mov.Tables(1).Rows(k).Item("sucursal_id") = destino_id Then
                        fila("Suc.Destino") = ds_mov.Tables(1).Rows(k).Item("sucursal_nombre")
                        Exit While
                    Else
                        k = k + 1
                    End If
                End While
                j = i
                'sumacantidad = sumacantidad + D_consulta_mov_alta.Tables(0).Rows(i).Item("MovMerDet_Cantidad")
                Dim sumado = "si"
                While j < ds_mov.Tables(0).Rows.Count
                    Dim codigo As Integer = ds_mov.Tables(0).Rows(i).Item("prod_codinterno")
                    If (ds_mov.Tables(0).Rows(j).Item("prod_codinterno") = codigo) And (origen_id = ds_mov.Tables(0).Rows(j).Item("sucursal_id_Origen") And (destino_id = ds_mov.Tables(0).Rows(j).Item("sucursal_id_Destino"))) Then
                        sumacantidad = sumacantidad + ds_mov.Tables(0).Rows(j).Item("MovMerDet_Cantidad")
                        j = j + 1
                        'pregunto si es el ultimo
                        'If i = ds_mov.Tables(0).Rows.Count - 1 Then
                        'i = i + 1
                        'End If
                    Else
                        i = j
                        sumado = "no"
                        'If i = ds_mov.Tables(0).Rows.Count - 1 Then
                        'i = i + 1
                        'End If
                        Exit While
                    End If
                End While
                fila("Cantidad") = sumacantidad
                Ds_consulta_movimientos.Tables("Movimientos").Rows.Add(fila)
                sumacantidad = 0

                If sumado = "si" Then
                    i = j + 1
                End If

                'If j = ds_mov.Tables(0).Rows.Count Then
                'i = i + 1
                'End If
                'i = i + 1
            End While
            GroupBox4.Text = "Resultado de la busqueda desde:" + DateTimePicker_desde.Value.Date + " Hasta:" + DateTimePicker_hasta.Value.Date
        Else
            GroupBox4.Text = "Resultado de la busqueda:"
            Ds_consulta_movimientos.Tables("Movimientos").Rows.Clear()
            MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "Insumo", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
        MovimientosBindingSource.Filter = Filtro
        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(ID, System.String) LIKE '%{0}%'", tx_Buscar.Text)
            MovimientosBindingSource.Filter = Filtro
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count <> 0 Then
            Dim result As Integer = MessageBox.Show("¿Desea generar un reporte con la información de la consulta actual?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                msj_esperar_b.procedencia = "Consultas_Movimientos_b"
                msj_esperar_b.Show()
            End If
        Else
            MessageBox.Show("No hay información para generar el reporte. Realice una nueva consulta.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Dim DAventa As New Datos.Venta
    Dim Ds_reporte_movimientos As New Ds_reporte_movimientos

    Public Sub reporte() 'este lo llamo desde msj_esperar_a

        '///////////////TABLA SUCURSAL Y EMPRESA///////////////////////////// 
        Dim ds_suc_y_empresa As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id)

        Ds_reporte_movimientos.Tables("Sucursal").Rows.Clear()
        Ds_reporte_movimientos.Tables("Empresa").Rows.Clear()


        If ds_suc_y_empresa.Tables(1).Rows.Count <> 0 Then

            Ds_reporte_movimientos.Tables("Empresa").Merge(ds_suc_y_empresa.Tables(1))
        End If

        If ds_suc_y_empresa.Tables(0).Rows.Count <> 0 Then
            Dim row_sucursal As DataRow = Ds_reporte_movimientos.Tables("Sucursal").NewRow()
            row_sucursal("sucursal") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_nombre")
            row_sucursal("direccion") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_direccion")
            row_sucursal("telefono") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_telefono")
            row_sucursal("mail") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_mail")
            row_sucursal("cuit") = ""
            Ds_reporte_movimientos.Tables("Sucursal").Rows.Add(row_sucursal)
        End If

        'cargamos movimientos y detalles de movimientos
        Ds_reporte_movimientos.Tables("movimientos_consulta").Rows.Clear()
        Ds_reporte_movimientos.Tables("Movimientos").Rows.Clear()


        'Dim i As Integer = 0
        'While i < DataGridView1.Rows.Count
        Dim fila As DataRow = Ds_reporte_movimientos.Tables("movimientos_consulta").NewRow
        fila("MovMer_id") = 1
        fila("MovMer_Concepto") = ""
        'fila("MovMer_FechaHora") = TextBox_fecha.Text
        'fila("sucursal_id_Origen") = 0
        'fila("Origen") = ""
        'fila("sucursal_id_Destino") = 0
        'fila("Destino") = ""
        'fila("Usuario") = TextBox_usuario.Text
        'fila("USU_id") = 0
        'fila("factura_nro") = factura_nro.Text
        'fila("factura_fecha") = factura_fecha.Text
        'fila("remito_nro") = remito_nro.Text
        'fila("remito_fecha") = remito_fecha.Text
        fila("Proveedor") = ""
        fila("rango_desde") = DateTimePicker_desde.Value
        fila("rango_hasta") = DateTimePicker_hasta.Value
        Ds_reporte_movimientos.Tables("movimientos_consulta").Rows.Add(fila)

        'ahora el detalle
        'Dim id As Integer = DataGridView2.Rows(i).Cells("MovMer_id").Value
        'Dim ds_detalle As DataSet = DAgestion_mercaderia.Movimiento_Mercaderia_obtener_detalle(id)
        'If ds_detalle.Tables(0).Rows.Count <> 0 Then
        Dim j As Integer = 0
        While j < DataGridView1.Rows.Count
            Dim fila_det As DataRow = Ds_reporte_movimientos.Tables("Movimientos").NewRow
            fila_det("ID") = DataGridView1.Rows(j).Cells("IDDataGridViewTextBoxColumn").Value
            fila_det("Insumo") = DataGridView1.Rows(j).Cells("InsumoDataGridViewTextBoxColumn").Value
            fila_det("Cantidad") = DataGridView1.Rows(j).Cells("CantidadDataGridViewTextBoxColumn").Value
            fila_det("Suc.Origen") = DataGridView1.Rows(j).Cells("SucOrigenDataGridViewTextBoxColumn").Value
            fila_det("Suc.Destino") = DataGridView1.Rows(j).Cells("SucDestinoDataGridViewTextBoxColumn").Value
            'fila_det("precioU") = DataGridView2.Rows(j).Cells("MovMerDet_precioU").Value
            'fila_det("preciosubtotal") = DataGridView2.Rows(j).Cells("MovMerDet_subtotal").Value

            Ds_reporte_movimientos.Tables("Movimientos").Rows.Add(fila_det)
            j = j + 1
        End While
        'End If

        ' i = i + 1
        ' End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Consulta_mov_b_CR.rpt")
        'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
        CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_movimientos.Tables("Empresa"))
        CrReport.Database.Tables("Sucursal").SetDataSource(Ds_reporte_movimientos.Tables("Sucursal"))
        CrReport.Database.Tables("movimientos_consulta").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_consulta"))
        CrReport.Database.Tables("Movimientos").SetDataSource(Ds_reporte_movimientos.Tables("Movimientos"))
        Dim visor As New movimientos_show
        visor.CrystalReportViewer1.ReportSource = CrReport
        visor.Text = "Consulta de movimientos. - Imprimir."
        visor.Show()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If DataGridView1.Rows.Count <> 0 Then
            Dim result As Integer = MessageBox.Show("¿Desea generar un reporte detallado con la información de la consulta actual?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                msj_esperar_b.procedencia = "Consultas_Movimientos_bb"
                msj_esperar_b.Show()
                'reporte_2()
            End If
        Else
            MessageBox.Show("No hay información para generar el reporte. Realice una nueva consulta.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub reporte_2()
        '///////////////TABLA SUCURSAL Y EMPRESA///////////////////////////// 
        Dim ds_suc_y_empresa As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id)

        Ds_reporte_movimientos.Tables("Sucursal").Rows.Clear()
        Ds_reporte_movimientos.Tables("Empresa").Rows.Clear()


        If ds_suc_y_empresa.Tables(1).Rows.Count <> 0 Then

            Ds_reporte_movimientos.Tables("Empresa").Merge(ds_suc_y_empresa.Tables(1))
        End If

        If ds_suc_y_empresa.Tables(0).Rows.Count <> 0 Then
            Dim row_sucursal As DataRow = Ds_reporte_movimientos.Tables("Sucursal").NewRow()
            row_sucursal("sucursal") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_nombre")
            row_sucursal("direccion") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_direccion")
            row_sucursal("telefono") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_telefono")
            row_sucursal("mail") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_mail")
            row_sucursal("cuit") = ""
            Ds_reporte_movimientos.Tables("Sucursal").Rows.Add(row_sucursal)
        End If

        'cargamos movimientos y detalles de movimientos
        Ds_reporte_movimientos.Tables("movimientos_consulta").Rows.Clear()
        Ds_reporte_movimientos.Tables("Movimientos").Rows.Clear()
        Ds_reporte_movimientos.Tables("Movimientos_bb").Rows.Clear()


        'Dim i As Integer = 0
        'While i < DataGridView1.Rows.Count
        Dim fila As DataRow = Ds_reporte_movimientos.Tables("movimientos_consulta").NewRow
        fila("MovMer_id") = 1
        fila("MovMer_Concepto") = ""
        'fila("MovMer_FechaHora") = TextBox_fecha.Text
        'fila("sucursal_id_Origen") = 0
        'fila("Origen") = ""
        'fila("sucursal_id_Destino") = 0
        'fila("Destino") = ""
        'fila("Usuario") = TextBox_usuario.Text
        'fila("USU_id") = 0
        'fila("factura_nro") = factura_nro.Text
        'fila("factura_fecha") = factura_fecha.Text
        'fila("remito_nro") = remito_nro.Text
        'fila("remito_fecha") = remito_fecha.Text
        fila("Proveedor") = ""
        fila("rango_desde") = DateTimePicker_desde.Value
        fila("rango_hasta") = DateTimePicker_hasta.Value
        Ds_reporte_movimientos.Tables("movimientos_consulta").Rows.Add(fila)

        'ahora el detalle
        'Dim id As Integer = DataGridView2.Rows(i).Cells("MovMer_id").Value
        'Dim ds_detalle As DataSet = DAgestion_mercaderia.Movimiento_Mercaderia_obtener_detalle(id)
        'If ds_detalle.Tables(0).Rows.Count <> 0 Then
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_mov_obtener_detalle_b_rango_fechas_todos(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                Dim prod_codinterno As Integer = CInt(DataGridView1.Rows(i).Cells("IDDataGridViewTextBoxColumn").Value)
                'obtengo id de la sucursal de origen en el gridvie
                '/////////////////////////////////////////
                Dim suc_origen_id As Integer
                Dim e As Integer = 0
                While e < ds_mov.Tables(1).Rows.Count

                    If ds_mov.Tables(1).Rows(e).Item("sucursal_nombre") = DataGridView1.Rows(i).Cells("SucOrigenDataGridViewTextBoxColumn").Value Then
                        suc_origen_id = ds_mov.Tables(1).Rows(e).Item("sucursal_id")
                        Exit While
                    End If
                    e = e + 1
                End While
                '/////////////////////////////////////////


                Dim k As Integer = 0
                While k < ds_mov.Tables(0).Rows.Count
                    If prod_codinterno = CInt(ds_mov.Tables(0).Rows(k).Item("prod_codinterno")) And suc_origen_id = ds_mov.Tables(0).Rows(k).Item("sucursal_id_Origen") Then
                        'si lo encuentra agrego al datable q voy a mandar a crystal
                        Dim fila1 As DataRow = Ds_reporte_movimientos.Tables("Movimientos_bb").NewRow
                        fila1("ID") = ds_mov.Tables(0).Rows(k).Item("prod_codinterno")
                        fila1("Insumo") = ds_mov.Tables(0).Rows(k).Item("prod_descripcion")
                        fila1("Cantidad") = ds_mov.Tables(0).Rows(k).Item("MovMerDet_Cantidad")
                        fila1("Suc.Origen") = DataGridView1.Rows(i).Cells("SucOrigenDataGridViewTextBoxColumn").Value
                        fila1("Suc.Destino") = DataGridView1.Rows(i).Cells("SucDestinoDataGridViewTextBoxColumn").Value
                        fila1("MovMer_FechaHora") = ds_mov.Tables(0).Rows(k).Item("MovMer_FechaHora")
                        Ds_reporte_movimientos.Tables("Movimientos_bb").Rows.Add(fila1)
                    End If
                    k = k + 1
                End While
                i = i + 1
            End While
        Else

        End If



        'End If

        ' i = i + 1
        ' End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Consulta_mov_bb_CR.rpt")
        'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
        CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_movimientos.Tables("Empresa"))
        CrReport.Database.Tables("Sucursal").SetDataSource(Ds_reporte_movimientos.Tables("Sucursal"))
        CrReport.Database.Tables("movimientos_consulta").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_consulta"))
        CrReport.Database.Tables("Movimientos").SetDataSource(Ds_reporte_movimientos.Tables("Movimientos"))
        CrReport.Database.Tables("Movimientos_bb").SetDataSource(Ds_reporte_movimientos.Tables("Movimientos_bb"))
        Dim visor As New movimientos_show
        visor.CrystalReportViewer1.ReportSource = CrReport
        visor.Text = "Consulta de movimientos detallados. - Imprimir."
        visor.Show()
    End Sub

End Class