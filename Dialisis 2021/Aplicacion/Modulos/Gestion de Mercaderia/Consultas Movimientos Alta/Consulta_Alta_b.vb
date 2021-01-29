Public Class Consulta_Alta_b
    Dim DAproveedor As New Datos.Proveedor
    Dim DAmovimientos As New Datos.Gestion_Mercaderia
    Private Sub Button_buscar_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar_proveedor.Click
        If combo_proveedor.Items.Count <> 0 Then
            If combo_proveedor.SelectedValue = 0 Then 'si es = traigo todos
                obtener_todos()
            Else
                'obtener_todos_x_proveedor()
            End If
        End If
    End Sub


    Private Sub obtener_proveedores()
        Dim ds_prov As DataSet = DAproveedor.Proveedor_obtener()
        If ds_prov.Tables(0).Rows.Count <> 0 Then
            'agrego un proveedor que se llame "todos", cuando este se selecciona trae todos los ingresos sin importar el proveedor
            Dim fila As DataRow = ds_prov.Tables(0).NewRow
            fila("Prov_id") = 0
            fila("Prov_nombre") = "Todos"
            ds_prov.Tables(0).Rows.Add(fila)
            combo_proveedor.DataSource = ds_prov.Tables(0)
            combo_proveedor.ValueMember = "Prov_id"
            combo_proveedor.DisplayMember = "Prov_nombre"
        End If


    End Sub

    Private Sub obtener_todos()
        'me trae todos los movimientos de alta, sin importar proveedor
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_Alta_obtener_detalle_b
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            D_consulta_mov_alta.Tables("movimientos_consulta_b").Rows.Clear()
            'D_consulta_mov_alta.Tables("movimientos_consulta_b").Merge(ds_mov.Tables(0))
            Dim sumacantidad As Decimal = 0
            Dim i As Integer = 0
            Dim j As Integer
            While i < ds_mov.Tables(0).Rows.Count
                'aqui creo la celda en el dataset
                Dim fila As DataRow = D_consulta_mov_alta.Tables("movimientos_consulta_b").NewRow
                fila("prod_codinterno") = ds_mov.Tables(0).Rows(i).Item("prod_codinterno")
                fila("prod_descripcion") = ds_mov.Tables(0).Rows(i).Item("prod_descripcion")
                'fila("MovMerDet_Cantidad") = ""
                fila("MovMerDet_precioU") = ds_mov.Tables(0).Rows(i).Item("MovMerDet_precioU")
                fila("MovMerDet_subtotal") = ds_mov.Tables(0).Rows(i).Item("MovMerDet_subtotal")
                fila("MovMer_FechaHora") = ds_mov.Tables(0).Rows(i).Item("MovMer_FechaHora")
                fila("MovMer_facturaNRO") = ds_mov.Tables(0).Rows(i).Item("MovMer_facturaNRO")
                fila("MovMer_facturafecha") = ds_mov.Tables(0).Rows(i).Item("MovMer_facturafecha")
                fila("MovMer_remitoNRO") = ds_mov.Tables(0).Rows(i).Item("MovMer_remitofecha")
                fila("MovMer_remitofecha") = ds_mov.Tables(0).Rows(i).Item("MovMer_remitofecha")
                fila("MovMer_id") = ds_mov.Tables(0).Rows(i).Item("MovMer_id")
                fila("sucursal_id_Origen") = ds_mov.Tables(0).Rows(i).Item("sucursal_id_Origen")
                fila("Origen") = ds_mov.Tables(0).Rows(i).Item("Origen")
                fila("Usuario") = ds_mov.Tables(0).Rows(i).Item("Usuario")
                fila("USU_id") = ds_mov.Tables(0).Rows(i).Item("USU_id")
                fila("Prov_id") = ds_mov.Tables(0).Rows(i).Item("Prov_id")
                fila("Prov_nombre") = ds_mov.Tables(0).Rows(i).Item("Prov_nombre")

                j = i
                'sumacantidad = sumacantidad + D_consulta_mov_alta.Tables(0).Rows(i).Item("MovMerDet_Cantidad")

                While j < ds_mov.Tables(0).Rows.Count
                    Dim codigo As Integer = ds_mov.Tables(0).Rows(i).Item("prod_codinterno")
                    If ds_mov.Tables(0).Rows(j).Item("prod_codinterno") = codigo Then
                        sumacantidad = sumacantidad + ds_mov.Tables(0).Rows(j).Item("MovMerDet_Cantidad")
                        j = j + 1
                        'pregunto si es el ultimo
                        If i = ds_mov.Tables(0).Rows.Count - 1 Then
                            i = i + 1
                        End If
                    Else
                        i = j
                        'If i = ds_mov.Tables(0).Rows.Count - 1 Then
                        'i = i + 1
                        'End If
                        Exit While
                    End If
                End While
                fila("MovMerDet_Cantidad") = sumacantidad
                D_consulta_mov_alta.Tables("movimientos_consulta_b").Rows.Add(fila)
                sumacantidad = 0
                'If j = ds_mov.Tables(0).Rows.Count Then
                'i = i + 1
                'End If
                'i = i + 1
            End While

            'Dim i As Integer = 0
            'While i < ds_mov.Tables(0).Rows.Count
            '    Dim j As Integer = 0
            '    While j < ds_mov.Tables(1).Rows.Count
            '        If D_consulta_mov_alta.Tables("movimientos_consulta").Rows(i).Item("sucursal_id_Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_id") Then
            '            D_consulta_mov_alta.Tables("movimientos_consulta").Rows(i).Item("Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_nombre")
            '        End If
            '        j = j + 1
            '    End While
            '    i = i + 1
            'End While
            GroupBox4.Text = "Resultado de la busqueda para Proveedor: " + combo_proveedor.Text
        Else
            GroupBox4.Text = "Resultado de la busqueda:"
            D_consulta_mov_alta.Tables("movimientos_consulta_b").Rows.Clear()
            MessageBox.Show("La busqueda no arrojo resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Consulta_Alta_b_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        obtener_proveedores()
    End Sub

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        If combo_proveedor.Items.Count <> 0 Then
            If combo_proveedor.SelectedValue = 0 Then 'si es = traigo todos
                recuperar_rango_todos()
            Else
                recuperar_rango_solo_proveedor()
            End If
        End If
    End Sub


    Private Sub recuperar_rango_todos()
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_Alta_obtener_detalle_b_rango_fechas_todos(DateTimePicker_desde.Value, DateTimePicker_hasta.Value)
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            D_consulta_mov_alta.Tables("movimientos_consulta_b").Rows.Clear()
            'D_consulta_mov_alta.Tables("movimientos_consulta").Merge(ds_consulta.Tables(0))

            'D_consulta_mov_alta.Tables("movimientos_consulta_b").Merge(ds_mov.Tables(0))
            Dim sumacantidad As Decimal = 0
            Dim i As Integer = 0
            Dim j As Integer
            While i < ds_mov.Tables(0).Rows.Count
                'aqui creo la celda en el dataset
                Dim fila As DataRow = D_consulta_mov_alta.Tables("movimientos_consulta_b").NewRow
                fila("prod_codinterno") = ds_mov.Tables(0).Rows(i).Item("prod_codinterno")
                fila("prod_descripcion") = ds_mov.Tables(0).Rows(i).Item("prod_descripcion")
                'fila("MovMerDet_Cantidad") = ""
                fila("MovMerDet_precioU") = ds_mov.Tables(0).Rows(i).Item("MovMerDet_precioU")
                fila("MovMerDet_subtotal") = ds_mov.Tables(0).Rows(i).Item("MovMerDet_subtotal")
                fila("MovMer_FechaHora") = ds_mov.Tables(0).Rows(i).Item("MovMer_FechaHora")
                fila("MovMer_facturaNRO") = ds_mov.Tables(0).Rows(i).Item("MovMer_facturaNRO")
                fila("MovMer_facturafecha") = ds_mov.Tables(0).Rows(i).Item("MovMer_facturafecha")
                fila("MovMer_remitoNRO") = ds_mov.Tables(0).Rows(i).Item("MovMer_remitofecha")
                fila("MovMer_remitofecha") = ds_mov.Tables(0).Rows(i).Item("MovMer_remitofecha")
                fila("MovMer_id") = ds_mov.Tables(0).Rows(i).Item("MovMer_id")
                fila("sucursal_id_Origen") = ds_mov.Tables(0).Rows(i).Item("sucursal_id_Origen")
                fila("Origen") = ds_mov.Tables(0).Rows(i).Item("Origen")
                fila("Usuario") = ds_mov.Tables(0).Rows(i).Item("Usuario")
                fila("USU_id") = ds_mov.Tables(0).Rows(i).Item("USU_id")
                fila("Prov_id") = ds_mov.Tables(0).Rows(i).Item("Prov_id")
                fila("Prov_nombre") = ds_mov.Tables(0).Rows(i).Item("Prov_nombre")

                j = i
                'sumacantidad = sumacantidad + D_consulta_mov_alta.Tables(0).Rows(i).Item("MovMerDet_Cantidad")
                Dim sumado = "si"
                While j < ds_mov.Tables(0).Rows.Count
                    Dim codigo As Integer = ds_mov.Tables(0).Rows(i).Item("prod_codinterno")
                    If ds_mov.Tables(0).Rows(j).Item("prod_codinterno") = codigo Then
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
                fila("MovMerDet_Cantidad") = sumacantidad
                D_consulta_mov_alta.Tables("movimientos_consulta_b").Rows.Add(fila)
                sumacantidad = 0

                If sumado = "si" Then
                    i = j + 1
                End If

                'If j = ds_mov.Tables(0).Rows.Count Then
                'i = i + 1
                'End If
                'i = i + 1
            End While
            GroupBox4.Text = "Resultado de la busqueda para Proveedor: " + combo_proveedor.Text + ". Desde:" + DateTimePicker_desde.Value.Date + " Hasta:" + DateTimePicker_hasta.Value.Date
        Else
            GroupBox4.Text = "Resultado de la busqueda:"
            D_consulta_mov_alta.Tables("movimientos_consulta_b").Rows.Clear()
            MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub recuperar_rango_solo_proveedor()
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_Alta_obtener_detalle_b_rango_fechas_proveedor(DateTimePicker_desde.Value, DateTimePicker_hasta.Value, combo_proveedor.SelectedValue)
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            D_consulta_mov_alta.Tables("movimientos_consulta_b").Rows.Clear()
            'D_consulta_mov_alta.Tables("movimientos_consulta").Merge(ds_consulta.Tables(0))

            'D_consulta_mov_alta.Tables("movimientos_consulta_b").Merge(ds_mov.Tables(0))
            Dim sumacantidad As Decimal = 0
            Dim i As Integer = 0
            Dim j As Integer
            While i < ds_mov.Tables(0).Rows.Count
                'aqui creo la celda en el dataset
                Dim fila As DataRow = D_consulta_mov_alta.Tables("movimientos_consulta_b").NewRow
                fila("prod_codinterno") = ds_mov.Tables(0).Rows(i).Item("prod_codinterno")
                fila("prod_descripcion") = ds_mov.Tables(0).Rows(i).Item("prod_descripcion")
                'fila("MovMerDet_Cantidad") = ""
                fila("MovMerDet_precioU") = ds_mov.Tables(0).Rows(i).Item("MovMerDet_precioU")
                fila("MovMerDet_subtotal") = ds_mov.Tables(0).Rows(i).Item("MovMerDet_subtotal")
                fila("MovMer_FechaHora") = ds_mov.Tables(0).Rows(i).Item("MovMer_FechaHora")
                fila("MovMer_facturaNRO") = ds_mov.Tables(0).Rows(i).Item("MovMer_facturaNRO")
                fila("MovMer_facturafecha") = ds_mov.Tables(0).Rows(i).Item("MovMer_facturafecha")
                fila("MovMer_remitoNRO") = ds_mov.Tables(0).Rows(i).Item("MovMer_remitofecha")
                fila("MovMer_remitofecha") = ds_mov.Tables(0).Rows(i).Item("MovMer_remitofecha")
                fila("MovMer_id") = ds_mov.Tables(0).Rows(i).Item("MovMer_id")
                fila("sucursal_id_Origen") = ds_mov.Tables(0).Rows(i).Item("sucursal_id_Origen")
                fila("Origen") = ds_mov.Tables(0).Rows(i).Item("Origen")
                fila("Usuario") = ds_mov.Tables(0).Rows(i).Item("Usuario")
                fila("USU_id") = ds_mov.Tables(0).Rows(i).Item("USU_id")
                fila("Prov_id") = ds_mov.Tables(0).Rows(i).Item("Prov_id")
                fila("Prov_nombre") = ds_mov.Tables(0).Rows(i).Item("Prov_nombre")

                j = i
                'sumacantidad = sumacantidad + D_consulta_mov_alta.Tables(0).Rows(i).Item("MovMerDet_Cantidad")
                Dim sumado = "si"
                While j < ds_mov.Tables(0).Rows.Count
                    Dim codigo As Integer = ds_mov.Tables(0).Rows(i).Item("prod_codinterno")
                    If ds_mov.Tables(0).Rows(j).Item("prod_codinterno") = codigo Then
                        sumacantidad = sumacantidad + ds_mov.Tables(0).Rows(j).Item("MovMerDet_Cantidad")
                        j = j + 1
                        'pregunto si es el ultimo
                        'If i = ds_mov.Tables(0).Rows.Count Then
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
                fila("MovMerDet_Cantidad") = sumacantidad
                D_consulta_mov_alta.Tables("movimientos_consulta_b").Rows.Add(fila)
                sumacantidad = 0
                If sumado = "si" Then
                    i = j + 1
                End If
                'If j = ds_mov.Tables(0).Rows.Count Then
                'i = i + 1
                'End If
                'i = i + 1
            End While
            GroupBox4.Text = "Resultado de la busqueda para Proveedor: " + combo_proveedor.Text + ". Desde:" + DateTimePicker_desde.Value.Date + " Hasta:" + DateTimePicker_hasta.Value.Date
        Else
            GroupBox4.Text = "Resultado de la busqueda:"
            D_consulta_mov_alta.Tables("movimientos_consulta_b").Rows.Clear()
            MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "prod_descripcion", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
        MovimientosconsultabBindingSource.Filter = Filtro
        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(prod_codinterno, System.String) LIKE '%{0}%'", tx_Buscar.Text)
            MovimientosconsultabBindingSource.Filter = Filtro
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count <> 0 Then
            Dim result As Integer = MessageBox.Show("¿Desea generar un reporte con la información de la consulta actual?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                msj_esperar_b.procedencia = "Consulta_Alta_b"
                msj_esperar_b.Show()
                'se abre el reporte()
            End If
        End If
        
    End Sub

    Dim DAventa As New Datos.Venta
    Dim Ds_reporte_movimientos As New Ds_reporte_movimientos

    Public Sub reporte() 'este lo llamo desde msj_esperar_a, muestra un reporte con cantidades totales, no el detalle

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
        Ds_reporte_movimientos.Tables("movimientos_detalle").Rows.Clear()
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
        fila("Proveedor") = combo_proveedor.Text
        fila("rango_desde") = DateTimePicker_desde.Value
        fila("rango_hasta") = DateTimePicker_hasta.Value
        Ds_reporte_movimientos.Tables("movimientos_consulta").Rows.Add(fila)

        'ahora el detalle
        'Dim id As Integer = DataGridView2.Rows(i).Cells("MovMer_id").Value
        'Dim ds_detalle As DataSet = DAgestion_mercaderia.Movimiento_Mercaderia_obtener_detalle(id)
        'If ds_detalle.Tables(0).Rows.Count <> 0 Then
        Dim j As Integer = 0
        While j < DataGridView1.Rows.Count
            Dim fila_det As DataRow = Ds_reporte_movimientos.Tables("movimientos_detalle").NewRow
            fila_det("prod_codinterno") = DataGridView1.Rows(j).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
            fila_det("prod_descripcion") = DataGridView1.Rows(j).Cells("ProddescripcionDataGridViewTextBoxColumn").Value
            fila_det("MovMerDet_Cantidad") = DataGridView1.Rows(j).Cells("MovMerDetCantidadDataGridViewTextBoxColumn").Value
            fila_det("MovMer_id") = 1
            'fila_det("precioU") = DataGridView2.Rows(j).Cells("MovMerDet_precioU").Value
            'fila_det("preciosubtotal") = DataGridView2.Rows(j).Cells("MovMerDet_subtotal").Value

            Ds_reporte_movimientos.Tables("movimientos_detalle").Rows.Add(fila_det)
            j = j + 1
        End While
        'End If

        ' i = i + 1
        ' End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Consulta_alta_b_detalle_CR.rpt")
        'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
        CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_movimientos.Tables("Empresa"))
        CrReport.Database.Tables("Sucursal").SetDataSource(Ds_reporte_movimientos.Tables("Sucursal"))
        CrReport.Database.Tables("movimientos_consulta").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_consulta"))
        CrReport.Database.Tables("movimientos_detalle").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_detalle"))
        Dim visor As New movimientos_show
        visor.CrystalReportViewer1.ReportSource = CrReport
        visor.Text = "Consulta de ingreso. - Imprimir."
        visor.Show()


    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DataGridView1.Rows.Count <> 0 Then
            Dim result As Integer = MessageBox.Show("¿Desea generar un reporte detallado con la información de la consulta actual?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                msj_esperar_b.procedencia = "Consulta_Alta_bb"
                msj_esperar_b.Show()

                'se abre el reporte_2()

            End If
        End If

        

    End Sub

    Public Sub reporte_2() 'este reporte muestra el detalle de cada producto, cuando se ingreso, nro de factura, remito, fechas etc

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
        Ds_reporte_movimientos.Tables("movimientos_detalle").Rows.Clear()
        Ds_reporte_movimientos.Tables("mov_alta_detallada").Rows.Clear() 'choco: 11-12-2020 esta es la que muestra facturas y remitos de un producto

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
        fila("Proveedor") = combo_proveedor.Text
        fila("rango_desde") = DateTimePicker_desde.Value
        fila("rango_hasta") = DateTimePicker_hasta.Value
        Ds_reporte_movimientos.Tables("movimientos_consulta").Rows.Add(fila)

        'ahora el detalle
        'Dim id As Integer = DataGridView2.Rows(i).Cells("MovMer_id").Value
        'Dim ds_detalle As DataSet = DAgestion_mercaderia.Movimiento_Mercaderia_obtener_detalle(id)
        'If ds_detalle.Tables(0).Rows.Count <> 0 Then


        'primero recupero toda la consulta de la bd, segun proveedor y rango de fechas, para luego consultar con lo que estoy mostrando en el gridview, y poner en el datatable q voy a mandar a crystal report
            Dim ds_mov As DataSet

            If combo_proveedor.Items.Count <> 0 Then
                If combo_proveedor.SelectedValue = 0 Then 'si es = traigo todos
                    ds_mov = DAmovimientos.Movimiento_Mercaderia_Alta_obtener_detalle_b_rango_fechas_todos(DateTimePicker_desde.Value, DateTimePicker_hasta.Value)
                    If ds_mov.Tables(0).Rows.Count <> 0 Then
                    'voy a recorrer el gridview e ir agregando 
                    Dim i As Integer = 0
                    While i < DataGridView1.Rows.Count
                        Dim prod_codinterno As Integer = CInt(DataGridView1.Rows(i).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value)
                        Dim k As Integer = 0
                        While k < ds_mov.Tables(0).Rows.Count
                            If prod_codinterno = CInt(ds_mov.Tables(0).Rows(k).Item("prod_codinterno")) Then
                                'si lo encuentra agrego al datable q voy a mandar a crystal
                                Dim fila1 As DataRow = Ds_reporte_movimientos.Tables("mov_alta_detallada").NewRow
                                fila1("prod_codinterno") = ds_mov.Tables(0).Rows(k).Item("prod_codinterno")
                                fila1("prod_descripcion") = ds_mov.Tables(0).Rows(k).Item("prod_descripcion")
                                fila1("cantidad") = ds_mov.Tables(0).Rows(k).Item("MovMerDet_Cantidad")
                                fila1("precioU") = ds_mov.Tables(0).Rows(k).Item("MovMerDet_precioU")
                                fila1("preciosubtotal") = ds_mov.Tables(0).Rows(k).Item("MovMerDet_subtotal")
                                fila1("factura_nro") = ds_mov.Tables(0).Rows(k).Item("MovMer_facturaNRO")
                                fila1("remito_nro") = ds_mov.Tables(0).Rows(k).Item("MovMer_remitoNRO")
                                fila1("factura_fecha") = ds_mov.Tables(0).Rows(k).Item("MovMer_facturafecha")
                                fila1("remito_fecha") = ds_mov.Tables(0).Rows(k).Item("MovMer_remitofecha")
                                fila1("fecha_hora") = ds_mov.Tables(0).Rows(k).Item("MovMer_FechaHora")
                                fila1("proveedor") = ds_mov.Tables(0).Rows(k).Item("Prov_nombre")
                                Ds_reporte_movimientos.Tables("mov_alta_detallada").Rows.Add(fila1)
                            End If
                            k = k + 1
                        End While
                        i = i + 1
                    End While


                Else
                    'no deberia fallar ya que si o si algo esta mostrando el tiene el gridview
                    End If
                Else
                    ds_mov = DAmovimientos.Movimiento_Mercaderia_Alta_obtener_detalle_b_rango_fechas_proveedor(DateTimePicker_desde.Value, DateTimePicker_hasta.Value, combo_proveedor.SelectedValue)
                    If ds_mov.Tables(0).Rows.Count <> 0 Then
                    'voy a recorrer el gridview e ir agregando 
                    Dim i As Integer = 0
                    While i < DataGridView1.Rows.Count
                        Dim prod_codinterno As Integer = CInt(DataGridView1.Rows(i).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value)
                        Dim k As Integer = 0
                        While k < ds_mov.Tables(0).Rows.Count
                            If prod_codinterno = CInt(ds_mov.Tables(0).Rows(k).Item("prod_codinterno")) Then
                                'si lo encuentra agrego al datable q voy a mandar a crystal
                                Dim fila1 As DataRow = Ds_reporte_movimientos.Tables("mov_alta_detallada").NewRow
                                fila1("prod_codinterno") = ds_mov.Tables(0).Rows(k).Item("prod_codinterno")
                                fila1("prod_descripcion") = ds_mov.Tables(0).Rows(k).Item("prod_descripcion")
                                fila1("cantidad") = ds_mov.Tables(0).Rows(k).Item("MovMerDet_Cantidad")
                                fila1("precioU") = ds_mov.Tables(0).Rows(k).Item("MovMerDet_precioU")
                                fila1("preciosubtotal") = ds_mov.Tables(0).Rows(k).Item("MovMerDet_subtotal")
                                fila1("factura_nro") = ds_mov.Tables(0).Rows(k).Item("MovMer_facturaNRO")
                                fila1("remito_nro") = ds_mov.Tables(0).Rows(k).Item("MovMer_remitoNRO")
                                fila1("factura_fecha") = ds_mov.Tables(0).Rows(k).Item("MovMer_facturafecha")
                                fila1("remito_fecha") = ds_mov.Tables(0).Rows(k).Item("MovMer_remitofecha")
                                fila1("fecha_hora") = ds_mov.Tables(0).Rows(k).Item("MovMer_FechaHora")
                                fila1("proveedor") = ds_mov.Tables(0).Rows(k).Item("Prov_nombre")
                                Ds_reporte_movimientos.Tables("mov_alta_detallada").Rows.Add(fila1)
                            End If
                            k = k + 1
                        End While
                        i = i + 1
                    End While
                Else
                    'no deberia fallar ya que si o si algo esta mostrando el tiene el gridview
                    End If
                End If
            End If
        
            
        'End If

        ' i = i + 1
        ' End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Consulta_alta_bb_detalle_CR.rpt")
        'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
        CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_movimientos.Tables("Empresa"))
        CrReport.Database.Tables("Sucursal").SetDataSource(Ds_reporte_movimientos.Tables("Sucursal"))
        CrReport.Database.Tables("movimientos_consulta").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_consulta"))
        CrReport.Database.Tables("movimientos_detalle").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_detalle"))
        CrReport.Database.Tables("mov_alta_detallada").SetDataSource(Ds_reporte_movimientos.Tables("mov_alta_detallada"))
        Dim visor As New movimientos_show
        visor.CrystalReportViewer1.ReportSource = CrReport
        visor.Text = "Consulta de ingresos detallados. - Imprimir."
        visor.Show()

    End Sub
End Class