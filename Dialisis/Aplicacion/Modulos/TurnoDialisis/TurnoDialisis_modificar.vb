Public Class TurnoDialisis_modificar
    Dim DAturno As New Datos.Turno
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TurnoDialisis_nuevo.Close()
        TurnoDialisis_nuevo.Show()
        Me.Close()

    End Sub

    Private Sub TurnoDialisis_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        obtener_turnos()

    End Sub

    Private Sub obtener_turnos()
        Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows.Clear()
        Dim ds_turno As DataSet = DAturno.Turnodialisis_obtener_todo()
        If ds_turno.Tables(0).Rows.Count <> 0 Then
            'aqui hago un new row
            Dim i As Integer = 0
            While i < ds_turno.Tables(0).Rows.Count
                Dim newrow As DataRow = Ds_turnodialisis.Tables("TurnoDialisis_consulta").NewRow()
                newrow("Turnodialisis_id") = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_id")
                newrow("Turnodialisis_desc") = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_desc")
                newrow("Horario") = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_desde_hora") + ":" + ds_turno.Tables(0).Rows(i).Item("Turnodialisis_desde_minutos") + " - " + ds_turno.Tables(0).Rows(i).Item("Turnodialisis_hasta_hora") + ":" + ds_turno.Tables(0).Rows(i).Item("Turnodialisis_hasta_minutos")
                'aqui recupero los dias
                Dim dias As String = ""
                Dim j As Integer = 0
                Dim turnodialisis_id As Integer = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_id")
                Dim ds_dias As DataSet = DAturno.Turnodialisis_obtener_dias(turnodialisis_id)
                While j < ds_dias.Tables(0).Rows.Count
                    If dias = "" Then
                        dias = ds_dias.Tables(0).Rows(j).Item("Dias_desc")
                    Else
                        dias = dias + ", " + ds_dias.Tables(0).Rows(j).Item("Dias_desc")
                    End If
                    j = j + 1
                End While
                newrow("Dias") = dias
                Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows.Add(newrow)
                i = i + 1
            End While
        End If
    End Sub

    Private Sub Button_Detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Detalle.Click
        If DataGridView1.Rows.Count <> 0 Then
            If DataGridView1.CurrentRow.Cells("Column1").Value = True Then
                TurnoDialisis_nuevo.Close() 'lo cierro x si esta abierto
                TurnoDialisis_nuevo.turno_procedencia = "modificar"
                TurnoDialisis_nuevo.turnodialisis_id = CInt(DataGridView1.CurrentRow.Cells("TurnodialisisidDataGridViewTextBoxColumn").Value)
                TurnoDialisis_nuevo.Show()
                Me.Close()
            Else
                MessageBox.Show("Seleccione un turno para editar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un turno para editar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_Anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Anular.Click
        If DataGridView1.Rows.Count <> 0 Then
            If DataGridView1.CurrentRow.Cells("Column1").Value = True Then
                
                Dim result As DialogResult
                result = MessageBox.Show("¿Está seguro que desea eliminar el turno: " + DataGridView1.CurrentRow.Cells("TurnodialisisDescDataGridViewTextBoxColumn").Value + "?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    If DataGridView1.CurrentRow.Cells("TurnodialisisDescDataGridViewTextBoxColumn").Value <> "Dialisis de Calle" Then
                        Dim turnodialisis_id As Integer = DataGridView1.CurrentRow.Cells("TurnodialisisidDataGridViewTextBoxColumn").Value
                        DAturno.Turnodialisis_eliminar_turno(turnodialisis_id)
                        DAturno.Turnodialisis_eliminar_dias(turnodialisis_id)
                        obtener_turnos()
                    Else
                        MessageBox.Show("No se puede eliminar el turno DIALISIS DE CALLE. Consulte al administrador.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Seleccione un turno para eliminar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un turno para eliminar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        'NOTA: LO QUE HAGO AQUI ES QUE SOLO SE PERMITA HACER UN CHECK EN UNA SOLA FILA
        If DataGridView1.Rows.Count <> 0 Then
            'DataGridView2.Rows(i).Cells("Item").Value = True
            'If DataGridView2.CurrentRow.Cells("item").Value = True Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("Column1").Value = True Then
                    DataGridView1.Rows(i).Cells("Column1").Value = False
                End If
                i = i + 1
            End While
            'ahora solo tildo el actual
            DataGridView1.CurrentRow.Cells("Column1").Value = True
            'End If
        End If
    End Sub
End Class