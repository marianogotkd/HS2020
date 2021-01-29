Public Class Form1
    Dim DAempleado As New Datos.Empleados
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DAempleado.Empleado_Alta(1, "victor", "asdf", "12313", "asf", "321", "asdf", "")
    End Sub
End Class
