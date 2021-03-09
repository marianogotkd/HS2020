Public Class Turno_Alarma

    'Dim AP As New Aplicacion.Turno
    Private Sub Turno_Alarma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Inicio.ALARMA = 1 Then
            RadioButton2.Checked = True
        Else
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Inicio.ALARMA = 0
        Dim Ruta As String = Application.StartupPath & "\..\..\\Resources\SonidoSi.png"
        US_administrador.Button2.Image = Image.FromFile(Ruta)
        US_Empleado.Button2.Image = Image.FromFile(Ruta)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Inicio.ALARMA = 1
        Dim Ruta As String = Application.StartupPath & "\..\..\\Resources\SonidoNo.png"
        US_administrador.Button2.Image = Image.FromFile(Ruta)
        US_Empleado.Button2.Image = Image.FromFile(Ruta)
    End Sub


End Class