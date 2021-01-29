Public Class Consumos_consulta
    Dim DAmovimientos As New Datos.Gestion_Mercaderia



    Private Sub Consumos_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DateTimePicker_desde.Enabled = False
        DateTimePicker_hasta.Enabled = False
        DateTimePicker_desde.Value = Today
        DateTimePicker_hasta.Value = Today
        CheckBox1.Checked = False
        recuperar_todos_consumos()
        
    End Sub

    Private Sub recuperar_todos_consumos()
        Dim ds_mov As DataSet = DAmovimientos.Consumos_mercaderia_obtener_todo
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            Mov_DS.Tables("consumos_detalle_full").Rows.Clear()
            Mov_DS.Tables("consumos_detalle_full").Merge(ds_mov.Tables(2))
            'Dim i As Integer = 0
            'While i < ds_mov.Tables(0).Rows.Count
            '    Dim j As Integer = 0
            '    While j < ds_mov.Tables(1).Rows.Count
            '        If Mov_DS.Tables("movimientos_consulta").Rows(i).Item("sucursal_id_Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_id") Then
            '            Mov_DS.Tables("movimientos_consulta").Rows(i).Item("Destino") = ds_mov.Tables(1).Rows(j).Item("sucursal_nombre")
            '        End If
            '        j = j + 1
            '    End While
            '    i = i + 1
            'End While
        End If
    End Sub

    Private Sub BO_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ver.Click
        cargar_detalle_consumo()
    End Sub

    Private Sub cargar_detalle_consumo()
        If DataGridView1.Rows.Count <> 0 Then
            Dim movimientoselec As String = CStr(DataGridView1.SelectedCells(0).Value)
            If movimientoselec <> "" Then
                Consumos_consulta_detalle.TextBox_ID.Text = DataGridView1.CurrentRow.Cells("ConsumomercaderiaidDataGridViewTextBoxColumn").Value
                Consumos_consulta_detalle.TextBox_concepto.Text = DataGridView1.CurrentRow.Cells("ConsumomercaderiaconceptoDataGridViewTextBoxColumn").Value
                Consumos_consulta_detalle.TextBox_fecha.Text = DataGridView1.CurrentRow.Cells("ConsumomercaderiaFechaHoraDataGridViewTextBoxColumn").Value
                Consumos_consulta_detalle.TextBox_usuario.Text = DataGridView1.CurrentRow.Cells("UsuarioDataGridViewTextBoxColumn").Value
                Consumos_consulta_detalle.TextBox_origen.Text = DataGridView1.CurrentRow.Cells("OrigenDataGridViewTextBoxColumn").Value
                'Movimientos_consulta_detalle.TextBox_destino.Text = DataGridView1.CurrentRow.Cells("Destino").Value
                Consumos_consulta_detalle.Show()
                Me.Close()
            Else
                MsgBox("Seleccione un consumo registrado", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un item para continuar.", MsgBoxStyle.Information)
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
            recuperar_todos_consumos()
        End If
    End Sub

    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "prod_descripcion", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO

        ConsumosdetallefullBindingSource.Filter = Filtro
        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(prod_codinterno, System.String) LIKE '%{0}%'", tx_Buscar.Text)
            ConsumosdetallefullBindingSource.Filter = Filtro
            If DataGridView1.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(Usuario, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                ConsumosdetallefullBindingSource.Filter = Filtro
                If DataGridView1.Rows.Count = 0 Then
                    Filtro = String.Format("CONVERT(Consumo_mercaderia_FechaHora, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                    ConsumosdetallefullBindingSource.Filter = Filtro
                End If
            End If
        End If
    End Sub

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        Dim ds_consulta As DataSet = DAmovimientos.Consumos_mercaderia_obtener_rango_fechas(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
        If ds_consulta.Tables(0).Rows.Count <> 0 Then
            Mov_DS.Tables("consumos_detalle_full").Rows.Clear()
            Mov_DS.Tables("consumos_detalle_full").Merge(ds_consulta.Tables(0))
        Else
            MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count <> 0 Then
            Dim result As Integer = MessageBox.Show("¿Desea generar un reporte con la información de la consulta actual?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Consumo_reporte_elegir.Close()
                Consumo_reporte_elegir.Show()
            End If
        Else
            MessageBox.Show("No se puede generar el reporte, realice una nueva consulta.", "Sistema de gestión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        
    End Sub
End Class