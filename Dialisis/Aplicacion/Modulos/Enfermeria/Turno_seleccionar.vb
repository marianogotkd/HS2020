Public Class Turno_seleccionar
    Dim DAturno As New Datos.Turno

    'Dim Ds_enfermeria As New Ds_enfermeria
    Private Sub obtener_turnos()
        Ds_enfermeria1.Tables("TurnoDialisis_consulta").Rows.Clear()
        Dim ds_turno As DataSet = DAturno.Turnodialisis_obtener_todo()
        If ds_turno.Tables(0).Rows.Count <> 0 Then
            'aqui hago un new row
            Dim i As Integer = 0
            While i < ds_turno.Tables(0).Rows.Count
                Dim newrow As DataRow = Ds_enfermeria1.Tables("TurnoDialisis_consulta").NewRow()
                newrow("Turnodialisis_id") = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_id")
                newrow("Turnodialisis_desc") = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_desc")
                newrow("Horario") = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_desde_hora") + ":" + ds_turno.Tables(0).Rows(i).Item("Turnodialisis_desde_minutos") + " - " + ds_turno.Tables(0).Rows(i).Item("Turnodialisis_hasta_hora") + ":" + ds_turno.Tables(0).Rows(i).Item("Turnodialisis_hasta_minutos")
                '/////////////////////////////recupero cant de inscriptos por turno/////////////////////////
                Dim turnodialisis_id As Integer = CInt(ds_turno.Tables(0).Rows(i).Item("Turnodialisis_id"))
                'Dim turnodialisis_id As Integer = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_id")
                Dim ds_inscriptos As DataSet = DAturno.TurnoDialisis_consultar_inscriptos(turnodialisis_id)
                newrow("cantidad_inscriptos") = ds_inscriptos.Tables(0).Rows.Count
                'aqui recupero los dias
                Dim dias As String = ""
                Dim j As Integer = 0
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
                Ds_enfermeria1.Tables("TurnoDialisis_consulta").Rows.Add(newrow)
                i = i + 1
            End While
        Else
            'no hay turnos creados, dirigase al modulo de turnos.
        End If
    End Sub

    Private Sub Turno_seleccionar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        obtener_turnos()
    End Sub

    Private Sub BO_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ver.Click
        If datagridview1.Rows.Count <> 0 Then
            If datagridview1.CurrentRow.Cells("CantidadinscriptosDataGridViewTextBoxColumn").Value <> 0 Then
                Sesion_pacientes.Close()
                Sesion_pacientes.turno_id = datagridview1.CurrentRow.Cells("TurnodialisisidDataGridViewTextBoxColumn").Value
                Sesion_pacientes.tb_turno.Text = datagridview1.CurrentRow.Cells("TurnodialisisDescDataGridViewTextBoxColumn").Value
                Sesion_pacientes.tb_horario.Text = datagridview1.CurrentRow.Cells("HorarioDataGridViewTextBoxColumn").Value
                Sesion_pacientes.lb_totalinscriptos.Text = "Total de inscriptos: " + CStr(datagridview1.CurrentRow.Cells("CantidadinscriptosDataGridViewTextBoxColumn").Value)

                '///////////choco 25-02-2021 /////////////////////////////////////
                'como tengo q descontar stock dependiendo la sucursal, voy a pasar el id de la sucursal = 3 si es un turno comun y si es un turno de dialisis de calle paso sucursal = 5
                If datagridview1.CurrentRow.Cells("TurnodialisisDescDataGridViewTextBoxColumn").Value = "Dialisis de Calle" Then
                    Sesion_pacientes.sucursal_id = 5 'es dialisis de calle
                Else
                    Sesion_pacientes.sucursal_id = 3 'es sala de dialisis
                End If
                '/////////////////////////////////////////////////////////////////
                Sesion_pacientes.Text = "Sesiones de diálisis - Turno: " + CStr(datagridview1.CurrentRow.Cells("TurnodialisisDescDataGridViewTextBoxColumn").Value)

                Sesion_pacientes.Show()
                Me.Hide()
            Else
                MessageBox.Show("Error, el turno no posee incriptos.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        Else
            MessageBox.Show("Error, debe seleccionar un turno valido.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Enfermeria_pacientes_seleccionar.Close()
        Enfermeria_pacientes_seleccionar.Show()
    End Sub
End Class