Public Class Sesion_registro_x_paciente
    Public PAC_id As Integer
    Dim DApaciente As New Datos.Paciente
    Dim DAturno As New Datos.Turno
    Dim DAsesiones As New Datos.Sesiones
    Private Sub Sesion_registro_x_paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Obetener_Cliente()
        recuperar_todas_sesiones_del_paciente(PAC_id)
        sesiones_recuperar_consumos()

    End Sub

    Private Sub sesiones_recuperar_consumos()
        Dim total As Integer = 0
        Dim ds_consumos As DataSet = DAsesiones.Sesiones_recuperar_todos_consumos(PAC_id)
        If ds_consumos.Tables(0).Rows.Count <> 0 Then
            Ds_enfermeria.Tables("insumos_consumidos").Merge(ds_consumos.Tables(0))
            'ahora cuento los insumos consumidos
            Dim i As Integer = 0
            While i < ds_consumos.Tables(0).Rows.Count
                total = total + CInt(ds_consumos.Tables(0).Rows(i).Item("cantidad"))
                i = i + 1
            End While
        End If
        lb_total_insumos.Text = "Total de insumos consumidos: " + CStr(total)
    End Sub



    Public Function calcularEdad(ByVal nacimiento As Date) As Integer
        Dim edad As Integer
        edad = Today.Year - nacimiento.Year
        If (nacimiento > Today.AddYears(-edad)) Then edad -= 1
        Return edad
    End Function
    Private Sub Obetener_Cliente()
        Dim ds_clie_recu As DataSet = DApaciente.Paciente_obtener_info(PAC_id)
        If ds_clie_recu.Tables(0).Rows.Count <> 0 Then
            tb_Dni_Cuit.Text = ds_clie_recu.Tables(0).Rows(0).Item("PAC_dni")
            tb_fecnac.Text = CDate(ds_clie_recu.Tables(0).Rows(0).Item("PAC_fnac")).Date
            tb_nombre.Text = ds_clie_recu.Tables(0).Rows(0).Item("PAC_ape") + " " + ds_clie_recu.Tables(0).Rows(0).Item("PAC_nom")

            If ds_clie_recu.Tables(0).Rows(0).Item("PAC_sexo") = "Masculino" Then
                tb_sexo.Text = "Masculino"
            Else
                tb_sexo.Text = "Femenino"
            End If
            tb_edad.Text = CStr(calcularEdad(CDate(tb_fecnac.Text)))
            tb_obsoc.Text = ds_clie_recu.Tables(0).Rows(0).Item("Obrasocial_nombre")
            tb_numafi.Text = ds_clie_recu.Tables(0).Rows(0).Item("PACnumafi")
        End If

    End Sub

    Public Sub recuperar_todas_sesiones_del_paciente(ByVal PAC_id As Integer)

        Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").Rows.Clear() 'siempre borrar antes de cargar
        Dim sesion As DataSet = DAturno.TurnoDialisis_consultar_sesion_paciente(PAC_id)

        Dim cant_presente As Integer = 0
        Dim cant_ausente As Integer = 0

        If sesion.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < sesion.Tables(0).Rows.Count

                Dim fila As DataRow = Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").NewRow
                fila("Sesiones_id") = sesion.Tables(0).Rows(i).Item("Sesiones_id")
                fila("PAC_id") = PAC_id
                fila("Sesiones_fecha") = sesion.Tables(0).Rows(i).Item("Sesiones_fecha")
                'fila("Dialisis_id") = 'para agregar esto hay q recorrer el table(1) de sesion
                fila("Paciente") = sesion.Tables(0).Rows(i).Item("Paciente")
                fila("PAc_dni") = sesion.Tables(0).Rows(i).Item("PAC_dni")
                fila("PAc_dir") = sesion.Tables(0).Rows(i).Item("PAc_dir")
                fila("PACnumafi") = sesion.Tables(0).Rows(i).Item("PACnumafi")
                fila("Obrasocial_nombre") = sesion.Tables(0).Rows(i).Item("Obrasocial_nombre")
                fila("Sesiones_asistencia") = sesion.Tables(0).Rows(i).Item("Sesiones_asistencia")
                If sesion.Tables(0).Rows(i).Item("Sesiones_asistencia") = "Presente" Then
                    cant_presente = cant_presente + 1
                Else
                    cant_ausente = cant_ausente + 1
                End If
                Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").Rows.Add(fila)

                i = i + 1
            End While
        End If
        Label1.Text = "Total de sesiones del paciente: " + CStr(sesion.Tables(0).Rows.Count)

        If sesion.Tables(0).Rows.Count <> 0 Then
            Label1.Text = "Total de sesiones del paciente: " + CStr(sesion.Tables(0).Rows.Count) + ".    Presentes: " + CStr(cant_presente) + ".    Ausentes: " + CStr(cant_ausente) + "."
        End If

        'ahora colo el nº de item o sesion si se quiere, las numero.
        Dim j As Integer = 0
        While j < datagridview1.Rows.Count
            datagridview1.Rows(j).Cells("item").Value = j + 1
            j = j + 1
        End While

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If datagridview1.Rows.Count <> 0 Then
            'aqui va pregunta para registrar como PRESENTE.
            'hay q hacer un alta alta en la tabla sesiones

            
            If CStr(datagridview1.CurrentRow.Cells("SesionesasistenciaDataGridViewTextBoxColumn").Value) = "Presente" Then

                'aqui como esta presente, lo que hago es ir a el modulo de dialisis para modificar la info.
                'el id de sesiones_id lo tomo de la grilla
                'MessageBox.Show("Aqui voy a modificar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim sesiones_id As Integer = CInt(datagridview1.CurrentRow.Cells("SesionesidDataGridViewTextBoxColumn").Value)
                Nueva_Dialisis.Close()
                Dim PAC_id As Integer = CInt(datagridview1.CurrentRow.Cells("PACidDataGridViewTextBoxColumn").Value)
                Nueva_Dialisis.PAC_id = PAC_id
                Nueva_Dialisis.fecha_registrar = CDate(datagridview1.CurrentRow.Cells("SesionesfechaDataGridViewTextBoxColumn").Value).Date
                Nueva_Dialisis.tipo_operacion = "modificar presente" 'aviso q ya estaba cargado como ausente, y que se va a modificar dicho estado
                'Dim sesiones_id As Integer = CInt(datagridview1.CurrentRow.Cells("SesionesidDataGridViewTextBoxColumn").Value)
                Nueva_Dialisis.modificar_sesiones_id = sesiones_id
                Nueva_Dialisis.Show()

                Me.Close()
            Else
                'ya esta registrado como Ausente.
                Dim result2 As Integer = MessageBox.Show("El paciente: " + datagridview1.CurrentRow.Cells("PacienteDataGridViewTextBoxColumn").Value + " ya se encuentra registrado como AUSENTE. ¿Desea cargarlo como PRESENTE para la sesion del dia " + CStr(CDate(datagridview1.CurrentRow.Cells("SesionesfechaDataGridViewTextBoxColumn").Value).Date) + "?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then
                    'aqui viene una especie de UPDATE para pasarlo a presente.

                    Nueva_Dialisis.Close()
                    Dim PAC_id As Integer = CInt(datagridview1.CurrentRow.Cells("PACidDataGridViewTextBoxColumn").Value)
                    Nueva_Dialisis.PAC_id = PAC_id
                    Nueva_Dialisis.fecha_registrar = CDate(datagridview1.CurrentRow.Cells("SesionesfechaDataGridViewTextBoxColumn").Value).Date
                    Nueva_Dialisis.tipo_operacion = "ausente" 'aviso q ya estaba cargado como ausente, y que se va a modificar dicho estado
                    Dim sesiones_id As Integer = CInt(datagridview1.CurrentRow.Cells("SesionesidDataGridViewTextBoxColumn").Value)
                    Nueva_Dialisis.ausente_sesiones_id = sesiones_id
                    Nueva_Dialisis.Show()

                    Me.Close()

                End If
            End If


        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If datagridview1.Rows.Count <> 0 Then
            Enfermeria_reporte_fechas.Close()
            Enfermeria_reporte_fechas.PAC_id = PAC_id
            Enfermeria_reporte_fechas.Show()

        Else
            MessageBox.Show("Error, no hay sesiones registradas.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If datagridview1.Rows.Count <> 0 Then
            Enfermeria_reporte_fechas.Close()
            Enfermeria_reporte_fechas.PAC_id = PAC_id
            Enfermeria_reporte_fechas.procedencia = "dialisis y consumos"
            Enfermeria_reporte_fechas.Show()

        Else
            MessageBox.Show("Error, no hay sesiones registradas.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class