Public Class Movimientos_consulta

    Dim DAmovimientos As New Datos.Gestion_Mercaderia
    Public tipo_consulta As String = "solo movimientos"
    Private Sub Movimientos_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DateTimePicker_desde.Enabled = False
        DateTimePicker_hasta.Enabled = False
        DateTimePicker_desde.Value = Today
        DateTimePicker_hasta.Value = Today
        CheckBox1.Checked = False
        recuperar_todos_movimientos()

    End Sub

    Private Sub recuperar_todos_movimientos()
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_obtener_todo
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            Mov_DS.Tables("movimientos_consulta").Rows.Clear()
            Mov_DS.Tables("movimientos_consulta").Merge(ds_mov.Tables(0))
            Dim i As Integer = 0
            While i < ds_mov.Tables(0).Rows.Count
                Dim j As Integer = 0
                While j < ds_mov.Tables(1).Rows.Count
                    If Mov_DS.Tables("movimientos_consulta").Rows(i).Item("sucursal_id_Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_id") Then
                        Mov_DS.Tables("movimientos_consulta").Rows(i).Item("Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_nombre")
                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
            If tipo_consulta = "solo movimientos" Then
                ''quito todos los que sean bajas y altas
                Dim k As Integer = 0
                While k < Mov_DS.Tables("movimientos_consulta").Rows.Count
                    If Mov_DS.Tables("movimientos_consulta").Rows(k).Item("MovMerTipo_id") <> 2 Then
                        Mov_DS.Tables("movimientos_consulta").Rows.Remove(Mov_DS.Tables("movimientos_consulta").Rows(k))
                        k = 0
                    Else
                        k = k + 1
                    End If
                End While
            End If
            If tipo_consulta = "solo bajas" Then
                Dim k As Integer = 0
                While k < Mov_DS.Tables("movimientos_consulta").Rows.Count
                    If Mov_DS.Tables("movimientos_consulta").Rows(k).Item("MovMerTipo_id") <> 3 Then
                        Mov_DS.Tables("movimientos_consulta").Rows.Remove(Mov_DS.Tables("movimientos_consulta").Rows(k))
                        k = 0
                    Else
                        k = k + 1
                    End If
                End While
            End If
            If tipo_consulta = "solo Sala de Dialisis" Then
                ''quito todos los que sean bajas y altas
                Dim k As Integer = 0
                While k < Mov_DS.Tables("movimientos_consulta").Rows.Count
                    If Mov_DS.Tables("movimientos_consulta").Rows(k).Item("MovMerTipo_id") <> 2 Then
                        Mov_DS.Tables("movimientos_consulta").Rows.Remove(Mov_DS.Tables("movimientos_consulta").Rows(k))
                        k = 0
                    Else
                        k = k + 1
                    End If
                End While
                'Quito todos los movimientos de la sucursal calle
                Dim x As Integer = 0
                While x < Mov_DS.Tables("movimientos_consulta").Rows.Count
                    If Mov_DS.Tables("movimientos_consulta").Rows(x).Item("sucursal_id_Destino") = 5 Then
                        Mov_DS.Tables("movimientos_consulta").Rows.Remove(Mov_DS.Tables("movimientos_consulta").Rows(x))
                        x = 0
                    Else
                        x = x + 1
                    End If
                End While
            End If



        End If
    End Sub

    Private Sub BO_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ver.Click
        cargar_detalle_movimiento()
    End Sub

    Private Sub cargar_detalle_movimiento()
        If DataGridView1.Rows.Count <> 0 Then
            Dim movimientoselec As String = CStr(DataGridView1.SelectedCells(0).Value)
            If movimientoselec <> "" Then
                Movimientos_consulta_detalle.TextBox_ID.Text = DataGridView1.CurrentRow.Cells("MovMer_id").Value
                Movimientos_consulta_detalle.TextBox_concepto.Text = DataGridView1.CurrentRow.Cells("MovMer_Concepto").Value
                Movimientos_consulta_detalle.TextBox_fecha.Text = DataGridView1.CurrentRow.Cells("MovMer_FechaHora").Value
                Movimientos_consulta_detalle.TextBox_usuario.Text = DataGridView1.CurrentRow.Cells("Usuario").Value
                Movimientos_consulta_detalle.TextBox_origen.Text = DataGridView1.CurrentRow.Cells("Origen").Value
                Movimientos_consulta_detalle.TextBox_destino.Text = DataGridView1.CurrentRow.Cells("Destino").Value
                If tipo_consulta = "solo bajas" Then
                    Movimientos_consulta_detalle.tipo_consulta = "solo bajas"
                End If
                If tipo_consulta = "solo movimientos" Then
                    Movimientos_consulta_detalle.tipo_consulta = "solo movimientos"
                End If
                Movimientos_consulta_detalle.Show()
                Me.Hide()
                'Me.Close()
            Else
                MsgBox("Seleccione un movimiento", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un movimiento", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DateTimePicker_desde.Enabled = True
            DateTimePicker_hasta.Enabled = True
            Button_buscar.Enabled = True
        Else
            DateTimePicker_desde.Enabled = False
            DateTimePicker_hasta.Enabled = False
            Button_buscar.Enabled = False
            'aqui recupero todo sin filtro
            recuperar_todos_movimientos()
        End If
    End Sub

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_obtener_rango_fechas(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            Mov_DS.Tables("movimientos_consulta").Rows.Clear()
            Mov_DS.Tables("movimientos_consulta").Merge(ds_mov.Tables(0))
            Dim i As Integer = 0
            While i < ds_mov.Tables(0).Rows.Count
                Dim j As Integer = 0
                While j < ds_mov.Tables(1).Rows.Count
                    If Mov_DS.Tables("movimientos_consulta").Rows(i).Item("sucursal_id_Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_id") Then
                        Mov_DS.Tables("movimientos_consulta").Rows(i).Item("Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_nombre")
                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
            If tipo_consulta = "solo movimientos" Then
                ''quito todos los que sean bajas y altas
                Dim k As Integer = 0
                While k < Mov_DS.Tables("movimientos_consulta").Rows.Count
                    If Mov_DS.Tables("movimientos_consulta").Rows(k).Item("MovMerTipo_id") <> 2 Then
                        Mov_DS.Tables("movimientos_consulta").Rows.Remove(Mov_DS.Tables("movimientos_consulta").Rows(k))
                        k = 0
                    Else
                        k = k + 1
                    End If
                End While
            End If
            If tipo_consulta = "solo bajas" Then
                Dim k As Integer = 0
                While k < Mov_DS.Tables("movimientos_consulta").Rows.Count
                    If Mov_DS.Tables("movimientos_consulta").Rows(k).Item("MovMerTipo_id") <> 3 Then
                        Mov_DS.Tables("movimientos_consulta").Rows.Remove(Mov_DS.Tables("movimientos_consulta").Rows(k))
                        k = 0
                    Else
                        k = k + 1
                    End If
                End While
            End If

        Else
            MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "MovMer_Concepto", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO

        MovimientosconsultaBindingSource.Filter = Filtro
        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(MovMer_id, System.String) LIKE '%{0}%'", tx_Buscar.Text)
            MovimientosconsultaBindingSource.Filter = Filtro
            If DataGridView1.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(Usuario, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                MovimientosconsultaBindingSource.Filter = Filtro
                If DataGridView1.Rows.Count = 0 Then
                    Filtro = String.Format("CONVERT(MovMer_FechaHora, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                    MovimientosconsultaBindingSource.Filter = Filtro
                End If
            End If
        End If
    End Sub

    Dim DAventa As New Datos.Venta
    Dim Ds_reporte_movimientos As New Ds_reporte_movimientos
    Dim DAgestion_mercaderia As New Datos.Gestion_Mercaderia
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("¿Desea generar un reporte con la información de la consulta actual?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            msj_esperar_b.procedencia = "movimientos"
            msj_esperar_b.Show()
        End If
        

    End Sub

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
        Ds_reporte_movimientos.Tables("movimientos_detalle").Rows.Clear()
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            Dim fila As DataRow = Ds_reporte_movimientos.Tables("movimientos_consulta").NewRow
            fila("MovMer_id") = DataGridView1.Rows(i).Cells("MovMer_id").Value
            fila("MovMer_Concepto") = DataGridView1.Rows(i).Cells("MovMer_Concepto").Value
            fila("MovMer_FechaHora") = DataGridView1.Rows(i).Cells("MovMer_FechaHora").Value
            fila("sucursal_id_Origen") = DataGridView1.Rows(i).Cells("SucursalidOrigenDataGridViewTextBoxColumn").Value
            fila("Origen") = DataGridView1.Rows(i).Cells("Origen").Value
            fila("sucursal_id_Destino") = DataGridView1.Rows(i).Cells("SucursalidDestinoDataGridViewTextBoxColumn").Value
            fila("Destino") = DataGridView1.Rows(i).Cells("Destino").Value
            fila("Usuario") = DataGridView1.Rows(i).Cells("Usuario").Value
            fila("USU_id") = DataGridView1.Rows(i).Cells("USUidDataGridViewTextBoxColumn").Value
            Ds_reporte_movimientos.Tables("movimientos_consulta").Rows.Add(fila)

            'ahora el detalle
            Dim id As Integer = DataGridView1.Rows(i).Cells("MovMer_id").Value
            Dim ds_detalle As DataSet = DAgestion_mercaderia.Movimiento_Mercaderia_obtener_detalle(id)
            If ds_detalle.Tables(0).Rows.Count <> 0 Then
                Dim j As Integer = 0
                While j < ds_detalle.Tables(0).Rows.Count
                    Dim fila_det As DataRow = Ds_reporte_movimientos.Tables("movimientos_detalle").NewRow
                    fila_det("prod_codinterno") = ds_detalle.Tables(0).Rows(j).Item("prod_codinterno")
                    fila_det("prod_descripcion") = ds_detalle.Tables(0).Rows(j).Item("prod_descripcion")
                    fila_det("MovMerDet_Cantidad") = ds_detalle.Tables(0).Rows(j).Item("MovMerDet_Cantidad")
                    fila_det("MovMer_id") = id

                    Ds_reporte_movimientos.Tables("movimientos_detalle").Rows.Add(fila_det)
                    j = j + 1
                End While
            End If

            i = i + 1
        End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

        If tipo_consulta = "solo bajas" Then
            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\movimiento_b_CR.rpt")
        Else
            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\movimiento_a_CR.rpt")
        End If

        'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
        CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_movimientos.Tables("Empresa"))
        CrReport.Database.Tables("Sucursal").SetDataSource(Ds_reporte_movimientos.Tables("Sucursal"))
        CrReport.Database.Tables("movimientos_consulta").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_consulta"))
        CrReport.Database.Tables("movimientos_detalle").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_detalle"))
        Dim visor As New movimientos_show
        visor.CrystalReportViewer1.ReportSource = CrReport
        visor.Text = "Consulta de movimientos. - Imprimir."
        visor.Show()


    End Sub
End Class