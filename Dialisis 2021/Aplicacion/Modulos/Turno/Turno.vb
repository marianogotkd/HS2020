Public Class Turno

    'Turno_Unir
    Public Function Turno_Unir(ByVal ds_turno As DataSet) As DataSet
        ds_turno.Tables(0).Merge(ds_turno.Tables(1))
        Return ds_turno
    End Function

    'Turno_ConfHora: Configura la hora de Fin del Turno 
    Public Function Turno_ConfHora(ByVal ds_turno As DataSet, ByVal T As Integer) As DataSet
        For Each row As DataRow In ds_turno.Tables(0).Rows
            Dim TURNO_Hora As DateTime = row.Item("TURNO_hora")
            row.Item("TURNO_hora") = TURNO_Hora.ToString("HH:mm")

            If T = 1 Then
                'Dim Fecha As DateTime = row.Item("TURNO_fecha")
                'Fecha = Fecha.AddHours(TURNO_Hora.Hour)
                'Fecha = Fecha.AddMinutes(TURNO_Hora.Minute)
                'row.Item("TURNO_fecha") = Fecha
                If row.Item("TURNO_T") = "Fijo" Then
                    Dim Fecha As DateTime = row.Item("TURNO_fecha")
                    Fecha = Fecha.AddHours(TURNO_Hora.Hour)
                    Fecha = Fecha.AddMinutes(TURNO_Hora.Minute)
                    row.Item("TURNO_fecha") = Fecha
                End If
            Else
                Select Case row.Item("TURNO_F_dia")
                    Case 2
                        row.Item("TURNO_fecha") = "Lunes"
                    Case 3
                        row.Item("TURNO_fecha") = "Martes"
                    Case 4
                        row.Item("TURNO_fecha") = "Miercoles"
                    Case 5
                        row.Item("TURNO_fecha") = "Jueves"
                    Case 6
                        row.Item("TURNO_fecha") = "Viernes"
                    Case 7
                        row.Item("TURNO_fecha") = "Sabado"
                    Case 1
                        row.Item("TURNO_fecha") = "Domingo"
                End Select
            End If

            Dim Duracion As DateTime = row.Item("TURNO_cant")
            row.Item("TURNO_cant") = Duracion.ToString("HH:mm")

            TURNO_Hora = TURNO_Hora.AddHours(Duracion.Hour)
            TURNO_Hora = TURNO_Hora.AddMinutes(Duracion.Minute)

            row.Item("TURNO_fin") = TURNO_Hora.ToString("HH:mm")


        Next
        Return ds_turno
    End Function

    Dim Turnos As New DataSet

    Public Sub Turno_CrearTabla()
        Turnos.Tables.Add("TurnoDisp")
        Turnos.Tables("TurnoDisp").Columns.Add("TURNO_desde")
        Turnos.Tables("TurnoDisp").Columns.Add("TURNO_hasta")
        Turnos.Tables("TurnoDisp").Columns.Add("TURNO_duracion")
    End Sub
   
    Public Sub Turno_ConfTurnoDisponible(ByVal desde_hora As DateTime, ByVal hasta_Hora As DateTime, ByVal hora As Integer, ByVal minuto As Integer)

        Dim DISP_desde As DateTime = "00:00"
        DISP_desde = DISP_desde.AddHours(desde_hora.Hour)
        DISP_desde = DISP_desde.AddMinutes(desde_hora.Minute)

        Dim DISP_hasta As DateTime = "00:00"
        DISP_hasta = DISP_hasta.AddHours(hasta_Hora.Hour)
        DISP_hasta = DISP_hasta.AddMinutes(hasta_Hora.Minute)

        Dim DISP As Integer

        DISP = DateDiff(DateInterval.Minute, DISP_desde, DISP_hasta)

        If DISP < 0 Then
            DISP = (24 * 60) + DISP
        End If

        If DISP >= hora * 60 + minuto Then
            Dim newCustomers As Data.DataRow
            newCustomers = Turnos.Tables("TurnoDisp").NewRow
            newCustomers("TURNO_desde") = DISP_desde.ToString("HH:mm")
            newCustomers("TURNO_hasta") = DISP_hasta.ToString("HH:mm")

            Dim duracion As DateTime = "00:00"
            Dim AHora As Integer = Int(DISP / 60)
            Dim Aminuto As Integer = DISP - (AHora * 60)
            duracion = duracion.AddHours(AHora)
            duracion = duracion.AddMinutes(Aminuto)

            newCustomers("TURNO_duracion") = duracion.ToString("HH:mm")
            Turnos.Tables("TurnoDisp").Rows.Add(newCustomers)
        End If
    End Sub

    Public Function Turno_ObtenerTabla() As DataSet
        Return Turnos
    End Function

    Public Sub Turno_LimpiarTabla()
        Turnos.Tables("TurnoDisp").Clear()
    End Sub


    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Dim DAemail As New Datos.Email

    Public Sub Turno_EnviarEmail(ByVal Texto As String)
        Dim ds_EmailOrigen As DataSet = DAemail.Email_OrigenTurno_Obtener
        Dim ds_EmailDestino As DataSet = DAemail.Email_DestinoTurno_Obtener

        If ds_EmailOrigen.Tables(0).Rows.Count > 0 And ds_EmailDestino.Tables(0).Rows.Count > 0 Then

            Dim Message As New System.Net.Mail.MailMessage()
            Dim SMTP As New System.Net.Mail.SmtpClient

            'CONFIGURACIÓN DEL STMP
            Dim EMAIL_OR_email As String = ds_EmailOrigen.Tables(0).Rows(0).Item("EMAIL_OR_email").ToString
            Dim EMAIL_OR_nom As String = ds_EmailOrigen.Tables(0).Rows(0).Item("EMAIL_OR_nom").ToString
            Dim EMAIL_OR_host As String = ds_EmailOrigen.Tables(0).Rows(0).Item("EMAIL_T_host").ToString
            Dim EMAIL_OR_contr As String = ds_EmailOrigen.Tables(0).Rows(0).Item("EMAIL_OR_contr").ToString

            SMTP.Credentials = New System.Net.NetworkCredential(EMAIL_OR_email, EMAIL_OR_contr)
            SMTP.Host = EMAIL_OR_host
            SMTP.Port = 587
            SMTP.EnableSsl = True

            ' CONFIGURACION DEL MENSAJE
            Dim B As Integer = 0
            While B < ds_EmailDestino.Tables(0).Rows.Count
                Dim EMAIL_DE_email As String = ds_EmailDestino.Tables(0).Rows(B).Item("EMAIL_DE_email").ToString
                Dim EMAIL_DE_nom As String = ds_EmailDestino.Tables(0).Rows(B).Item("EMAIL_DE_nom").ToString

                Message.[To].Add(EMAIL_DE_email) 'Cuenta de Correo al que se le quiere enviar el e-mail
                Message.From = New System.Net.Mail.MailAddress(EMAIL_OR_email, EMAIL_OR_nom, System.Text.Encoding.UTF8) 'Quien lo envía
                Message.Subject = "Turno" 'Sujeto del e-mail
                Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
                Message.Body = Texto 'contenido del mail
                Message.BodyEncoding = System.Text.Encoding.UTF8
                Message.Priority = System.Net.Mail.MailPriority.Normal
                Message.IsBodyHtml = False

                'ENVIO
                Try
                    SMTP.Send(Message)
                    'MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
                Catch ex As System.Net.Mail.SmtpException
                    'MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
                End Try

                B = B + 1
            End While
        End If
        
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Dim DAturno As New Datos.Turno


    Public Sub TurnoIniciado_control(ByVal UT_id As Integer)
        Dim ds_TurnoIniciado As DataSet = DAturno.Turno_ObtenerIniciado
        Dim Alarma As Integer = 0
        If ds_TurnoIniciado.Tables(0).Rows.Count > 0 Then
            Dim B As Integer = 0
            While B < ds_TurnoIniciado.Tables(0).Rows.Count
                Dim TURNO_fechahasta As Date = ds_TurnoIniciado.Tables(0).Rows(B).Item("TURNO_fechahasta").ToString
                If Now.AddMinutes(5) >= TURNO_fechahasta Then
                    Alarma = 1
                End If
                B = B + 1
            End While

            If Alarma = 1 Then
                Select Case (UT_id)
                    Case (1)
                        US_administrador.Button1.Visible = True
                    Case (2)
                        US_Empleado.Button1.Visible = True
                End Select
                If Inicio.ALARMA = 0 Then
                    Try
                        Dim ruta As String
                        ruta = Application.StartupPath & "\..\..\Sonido\alarma.wav"
                        'ruta = Application.StartupPath & "\..\..\Sonido\descending_craft-Sonidor-991848481.wav"
                        My.Computer.Audio.Play(ruta, AudioPlayMode.Background)
                        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    Catch ex As Exception
                    End Try
                End If

            End If

        End If

        Select Case (UT_id)
            Case (1)
                US_administrador.Iniciar_Tiempo()
            Case (2)
                US_Empleado.Iniciar_Tiempo()
        End Select
    End Sub

End Class
