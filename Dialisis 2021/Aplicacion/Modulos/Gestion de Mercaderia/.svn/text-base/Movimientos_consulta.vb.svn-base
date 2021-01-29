Public Class Movimientos_consulta

    Dim DAmovimientos As New Datos.Gestion_Mercaderia
    Private Sub Movimientos_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
                Movimientos_consulta_detalle.Show()
                Me.Close()
            Else
                MsgBox("Seleccione un movimiento", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un movimiento", MsgBoxStyle.Information)
        End If
    End Sub
End Class