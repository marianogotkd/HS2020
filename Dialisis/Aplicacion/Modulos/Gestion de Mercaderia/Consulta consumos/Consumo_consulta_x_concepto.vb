Public Class Consumo_consulta_x_concepto
    Dim DAmovimientos As New Datos.Gestion_Mercaderia
    Private Sub Consumo_consulta_x_concepto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'primero recupero todo?
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
            Ds_consulta_consumos.Tables("Consumos").Rows.Clear()
            Ds_consulta_consumos.Tables("Consumos").Merge(ds_mov.Tables(0))
        End If
    End Sub

    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        Dim Filtro
        Filtro = String.Format("CONVERT(Consumo_mercaderia_id, System.String) LIKE '%{0}%'", tx_Buscar.Text)
        ConsumosBindingSource.Filter = Filtro

        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(Usuario, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
            ConsumosBindingSource.Filter = Filtro
            If DataGridView1.Rows.Count = 0 Then
                Filtro = String.Format("{0} LIKE '%{1}%'", "Consumo_mercaderia_concepto", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                ConsumosBindingSource.Filter = Filtro
                If DataGridView1.Rows.Count = 0 Then
                    Filtro = String.Format("CONVERT(Consumo_mercaderia_FechaHora, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                    ConsumosBindingSource.Filter = Filtro
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
            recuperar_todos_consumos()
        End If
    End Sub


    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        Dim ds_consulta As DataSet = DAmovimientos.Consumos_mercaderia_obtener_rango_fechas(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
        If ds_consulta.Tables(1).Rows.Count <> 0 Then
            Ds_consulta_consumos.Tables("Consumos").Rows.Clear()
            Ds_consulta_consumos.Tables("Consumos").Merge(ds_consulta.Tables(1))
        Else
            MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BO_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ver.Click
        If DataGridView1.Rows.Count <> 0 Then

            Consumos_consulta_detalle.Close()
            Consumos_consulta_detalle.TextBox_ID.Text = DataGridView1.CurrentRow.Cells("ConsumomercaderiaidDataGridViewTextBoxColumn").Value
            Consumos_consulta_detalle.TextBox_concepto.Text = DataGridView1.CurrentRow.Cells("ConsumomercaderiaconceptoDataGridViewTextBoxColumn").Value
            Consumos_consulta_detalle.TextBox_fecha.Text = DataGridView1.CurrentRow.Cells("ConsumomercaderiaFechaHoraDataGridViewTextBoxColumn").Value
            Consumos_consulta_detalle.TextBox_usuario.Text = DataGridView1.CurrentRow.Cells("UsuarioDataGridViewTextBoxColumn").Value
            Consumos_consulta_detalle.TextBox_origen.Text = DataGridView1.CurrentRow.Cells("OrigenDataGridViewTextBoxColumn").Value
            Consumos_consulta_detalle.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error, debe seleccionar un elemento para ver su detalle.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class