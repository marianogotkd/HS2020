Public Class TurnoDialisis_seleccionar
    Dim DAturno As New Datos.Turno

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

    Private Sub TurnoDialisis_seleccionar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        obtener_turnos()
    End Sub

    Private Sub BO_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_agregar.Click
        If DataGridView1.Rows.Count <> 0 Then
            Cliente_alta_New.turnodialisis_id = DataGridView1.CurrentRow.Cells("TurnodialisisidDataGridViewTextBoxColumn").Value
            'Cliente_alta_New.txt_turno.Text = DataGridView1.CurrentRow.Cells("TurnodialisisDescDataGridViewTextBoxColumn").Value
            Cliente_alta_New.txt_dias.Text = DataGridView1.CurrentRow.Cells("DiasDataGridViewTextBoxColumn").Value
            Cliente_alta_New.txt_horario.Text = DataGridView1.CurrentRow.Cells("HorarioDataGridViewTextBoxColumn").Value
            Me.Close()

        Else
            MessageBox.Show("No hay turnos disponibles. Consulte el administrador.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class