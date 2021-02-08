Public Class Ajuste_Consulta
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
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            Ajuste_DS.Tables("Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes").Rows.Clear()
            Ajuste_DS.Tables("Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes").Merge(ds_mov.Tables(0))
          
        End If
    End Sub

    Private Sub BO_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ver.Click
        ' cargar_detalle_movimiento()
    End Sub

    Private Sub cargar_detalle_movimiento()
        'If DataGridView1.Rows.Count <> 0 Then
        '    Dim movimientoselec As String = CStr(DataGridView1.SelectedCells(0).Value)
        '    If movimientoselec <> "" Then
        '        Movimientos_consulta_detalle.TextBox_ID.Text = DataGridView1.CurrentRow.Cells("MovMer_id").Value
        '        Movimientos_consulta_detalle.TextBox_concepto.Text = DataGridView1.CurrentRow.Cells("MovMer_Concepto").Value
        '        Movimientos_consulta_detalle.TextBox_fecha.Text = DataGridView1.CurrentRow.Cells("MovMer_FechaHora").Value
        '        Movimientos_consulta_detalle.TextBox_usuario.Text = DataGridView1.CurrentRow.Cells("Usuario").Value
        '        Movimientos_consulta_detalle.TextBox_origen.Text = DataGridView1.CurrentRow.Cells("Origen").Value
        '        Movimientos_consulta_detalle.TextBox_destino.Text = DataGridView1.CurrentRow.Cells("Destino").Value
        '        If tipo_consulta = "solo bajas" Then
        '            Movimientos_consulta_detalle.tipo_consulta = "solo bajas"
        '        End If
        '        If tipo_consulta = "solo movimientos" Then
        '            Movimientos_consulta_detalle.tipo_consulta = "solo movimientos"
        '        End If
        '        Movimientos_consulta_detalle.Show()
        '        Me.Close()
        '    Else
        '        MsgBox("Seleccione un movimiento", MsgBoxStyle.Information)
        '    End If
        'Else
        '    MsgBox("Seleccione un movimiento", MsgBoxStyle.Information)
        'End If
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
        Dim ds_mov As DataSet = DAmovimientos.Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes_Rango_Fechas(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
        If ds_mov.Tables(0).Rows.Count <> 0 Then
            Ajuste_DS.Tables("Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes").Rows.Clear()
            Ajuste_DS.Tables("Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes").Merge(ds_mov.Tables(0))
        Else
            MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        Dim Filtro
        Filtro = String.Format("CONVERT(prod_codinterno, System.String) LIKE '%{0}%'", tx_Buscar.Text)
        MovimientoMercaderiaAltaobtenerdetalleAjustesBindingSource.Filter = Filtro

        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("{0} LIKE '%{1}%'", "prod_descripcion", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
            MovimientoMercaderiaAltaobtenerdetalleAjustesBindingSource.Filter = Filtro


            If DataGridView1.Rows.Count = 0 Then
                Filtro = String.Format("{0} LIKE '%{1}%'", "MovMer_Concepto", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                MovimientoMercaderiaAltaobtenerdetalleAjustesBindingSource.Filter = Filtro
                'If DataGridView1.Rows.Count = 0 Then
                '    Filtro = String.Format("CONVERT(MovMer_id, System.String) LIKE '%{0}%'", tx_Buscar.Text)
                '    MovimientoMercaderiaAltaobtenerdetalleAjustesBindingSource.Filter = Filtro
                If DataGridView1.Rows.Count = 0 Then
                    Filtro = String.Format("CONVERT(Usuario, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                    MovimientoMercaderiaAltaobtenerdetalleAjustesBindingSource.Filter = Filtro
                    If DataGridView1.Rows.Count = 0 Then
                        Filtro = String.Format("CONVERT(MovMer_FechaHora, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                        MovimientoMercaderiaAltaobtenerdetalleAjustesBindingSource.Filter = Filtro
                    End If
                End If
                'End If
            End If
        End If
    End Sub

   
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class