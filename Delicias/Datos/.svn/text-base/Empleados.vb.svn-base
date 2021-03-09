Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Empleados
    Inherits Datos.Conexion
    Public Sub Empleado_Alta(ByVal empleado_dni As String, ByVal empleado_nom As String, ByVal empleado_ape As String, ByVal empleado_fechanac As Date, ByVal empleado_dir As String, ByVal empleado_tel As String, ByVal empleado_mail As String, ByVal empleado_foto() As Byte)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Empleado_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_dni", empleado_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_nom", empleado_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_ape", empleado_ape))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_fechanac", empleado_fechanac))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_dir", empleado_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_tel", empleado_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_mail", empleado_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_foto", empleado_foto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empleado")
        dbconn.Close()
    End Sub


    Public Sub Empleado_Modificar(ByVal empleado_id As String, ByVal empleado_dni As String, ByVal empleado_nom As String, ByVal empleado_ape As String, ByVal empleado_fechanac As Date, ByVal empleado_dir As String, ByVal empleado_tel As String, ByVal empleado_mail As String, ByVal empleado_foto() As Byte)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Empleado_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_id", empleado_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_dni", empleado_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_nom", empleado_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_ape", empleado_ape))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_fechanac", empleado_fechanac))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_dir", empleado_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_tel", empleado_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_mail", empleado_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_foto", empleado_foto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empleado")
        dbconn.Close()
    End Sub
End Class
