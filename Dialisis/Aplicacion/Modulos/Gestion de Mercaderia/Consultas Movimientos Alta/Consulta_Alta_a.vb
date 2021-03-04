Public Class Consulta_Alta_a
    Dim DAproveedor As New Datos.Proveedor
    Dim DAmovimientos As New Datos.Gestion_Mercaderia


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


    Private Sub Consulta_Alta_a_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        obtener_proveedores()
    End Sub

    Private Sub Button_buscar_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar_proveedor.Click
        If combo_proveedor.Items.Count <> 0 Then
            If combo_proveedor.SelectedValue = 0 Then 'si es = traigo todos
                obtener_todos()
            Else
                obtener_todos_x_proveedor()
            End If
        End If
    End Sub

    Private Sub obtener_todos_x_proveedor()
        'me trae todos los movimientos de alta segun el proveedor seleccionado.
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_Alta_obtenertodo_proveedor(combo_proveedor.SelectedValue)
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            D_consulta_mov_alta.Tables("movimientos_consulta").Rows.Clear()
            D_consulta_mov_alta.Tables("movimientos_consulta").Merge(ds_mov.Tables(0))
            Dim i As Integer = 0
            While i < ds_mov.Tables(0).Rows.Count
                Dim j As Integer = 0
                While j < ds_mov.Tables(1).Rows.Count
                    If D_consulta_mov_alta.Tables("movimientos_consulta").Rows(i).Item("sucursal_id_Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_id") Then
                        D_consulta_mov_alta.Tables("movimientos_consulta").Rows(i).Item("Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_nombre")
                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
            GroupBox4.Text = "Resultado de la busqueda para Proveedor: " + combo_proveedor.Text

        Else
            GroupBox4.Text = "Resultado de la busqueda:"
            D_consulta_mov_alta.Tables("movimientos_consulta").Rows.Clear()
            MessageBox.Show("La busqueda no arrojo resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub obtener_todos()
        'me trae todos los movimientos de alta, sin importar proveedor
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_Alta_obtenertodo
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            D_consulta_mov_alta.Tables("movimientos_consulta").Rows.Clear()
            D_consulta_mov_alta.Tables("movimientos_consulta").Merge(ds_mov.Tables(0))
            Dim i As Integer = 0
            While i < ds_mov.Tables(0).Rows.Count
                Dim j As Integer = 0
                While j < ds_mov.Tables(1).Rows.Count
                    If D_consulta_mov_alta.Tables("movimientos_consulta").Rows(i).Item("sucursal_id_Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_id") Then
                        D_consulta_mov_alta.Tables("movimientos_consulta").Rows(i).Item("Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_nombre")
                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
            GroupBox4.Text = "Resultado de la busqueda para Proveedor: " + combo_proveedor.Text
        Else
            GroupBox4.Text = "Resultado de la busqueda:"
            D_consulta_mov_alta.Tables("movimientos_consulta").Rows.Clear()
            MessageBox.Show("La busqueda no arrojo resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                Filtro = String.Format("CONVERT(MovMer_facturaNRO, System.String) LIKE '%{0}%'", tx_Buscar.Text)
                MovimientosconsultaBindingSource.Filter = Filtro
                If DataGridView1.Rows.Count = 0 Then
                    Filtro = String.Format("CONVERT(MovMer_remitoNRO, System.String) LIKE '%{0}%'", tx_Buscar.Text)
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
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DateTimePicker_desde.Enabled = True
            DateTimePicker_hasta.Enabled = True
            Button_buscar.Enabled = True
        Else
            DateTimePicker_desde.Enabled = False
            DateTimePicker_hasta.Enabled = False
            Button_buscar.Enabled = False
            'aqui recupero todo sin filtro
            If combo_proveedor.Items.Count <> 0 Then
                If combo_proveedor.SelectedValue = 0 Then 'si es = traigo todos
                    obtener_todos()
                Else
                    obtener_todos_x_proveedor()
                End If
            End If
        End If
    End Sub

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        If combo_proveedor.Items.Count <> 0 Then
            If combo_proveedor.SelectedValue = 0 Then 'si es = traigo todos
                Dim ds_consulta As DataSet = DAmovimientos.Movimiento_Mercaderia_ALta_obtener_rango_fechas_todos(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
                If ds_consulta.Tables(0).Rows.Count <> 0 Then
                    D_consulta_mov_alta.Tables("movimientos_consulta").Rows.Clear()
                    D_consulta_mov_alta.Tables("movimientos_consulta").Merge(ds_consulta.Tables(0))
                Else
                    MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                'aqui lo hago pero pasando como parametro el id del proveedor
                Dim ds_consulta As DataSet = DAmovimientos.Movimiento_Mercaderia_ALta_obtener_rango_fechas_todos_proveedor(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date, combo_proveedor.SelectedValue)
                If ds_consulta.Tables(0).Rows.Count <> 0 Then
                    D_consulta_mov_alta.Tables("movimientos_consulta").Rows.Clear()
                    D_consulta_mov_alta.Tables("movimientos_consulta").Merge(ds_consulta.Tables(0))
                Else
                    MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
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
                Consulta_Alta_a_detalle.Close()
                Consulta_Alta_a_detalle.TextBox_ID.Text = DataGridView1.CurrentRow.Cells("MovMeridDataGridViewTextBoxColumn").Value
                Consulta_Alta_a_detalle.TextBox_concepto.Text = DataGridView1.CurrentRow.Cells("MovMerConceptoDataGridViewTextBoxColumn").Value
                Consulta_Alta_a_detalle.TextBox_fecha.Text = DataGridView1.CurrentRow.Cells("MovMerFechaHoraDataGridViewTextBoxColumn").Value
                Consulta_Alta_a_detalle.TextBox_usuario.Text = DataGridView1.CurrentRow.Cells("UsuarioDataGridViewTextBoxColumn").Value
                Consulta_Alta_a_detalle.TextBox_origen.Text = DataGridView1.CurrentRow.Cells("OrigenDataGridViewTextBoxColumn").Value
                'Consulta_Alta_a_detalle.TextBox_destino.Text = DataGridView1.CurrentRow.Cells("Destino").Value
                Consulta_Alta_a_detalle.factura_nro.Text = DataGridView1.CurrentRow.Cells("MovMer_facturaNRO").Value
                Consulta_Alta_a_detalle.factura_fecha.Text = DataGridView1.CurrentRow.Cells("MovMer_facturafecha").Value
                Consulta_Alta_a_detalle.remito_nro.Text = DataGridView1.CurrentRow.Cells("MovMer_remitoNRO").Value
                Consulta_Alta_a_detalle.remito_fecha.Text = DataGridView1.CurrentRow.Cells("MovMer_remitofecha").Value
                Consulta_Alta_a_detalle.Show()
                Me.Hide()
                'Me.Close()
            Else
                MsgBox("Seleccione un movimiento", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un movimiento", MsgBoxStyle.Information)
        End If
    End Sub
End Class