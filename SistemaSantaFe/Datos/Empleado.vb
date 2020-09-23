Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Empleado
    Inherits Datos.Conexion
    Public Sub Empleado_Alta(ByVal empleado_dni As String, ByVal empleado_nom As String, ByVal empleado_ape As String, ByVal empleado_fechanac As Date, ByVal empleado_dir As String, ByVal empleado_tel As String, ByVal empleado_cel As String, ByVal empleado_mail As String, ByVal empleado_foto() As Byte, ByVal empleado_Funcion As String, ByVal empleado_Tipo_Mto As String, ByVal empleado_Remune As Decimal)
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
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_cel", empleado_cel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_mail", empleado_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_foto", empleado_foto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_func", empleado_Funcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_TpoMto", empleado_Tipo_Mto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_remu", empleado_Remune))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empleado")
        dbconn.Close()
    End Sub


    Public Sub Empleado_Modificar(ByVal empleado_id As String, ByVal empleado_dni As String, ByVal empleado_nom As String, ByVal empleado_ape As String, ByVal empleado_fechanac As Date, ByVal empleado_dir As String, ByVal empleado_tel As String, ByVal empleado_cel As String, ByVal empleado_mail As String, ByVal empleado_foto() As Byte, ByVal empleado_remune As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Empleado_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_dni", empleado_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_nom", empleado_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_ape", empleado_ape))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_fechanac", empleado_fechanac))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_dir", empleado_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_tel", empleado_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_cel", empleado_cel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_mail", empleado_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_foto", empleado_foto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_remune", empleado_remune))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empleado")
        dbconn.Close()
    End Sub

    'Empleado_buscardni
    Public Function Empleado_buscardni(ByVal dni As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Empleado_buscardni", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@dni", dni))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empleado")
        dbconn.Close()
        Return ds_JE
    End Function


    'Empleado_buscarape
    Public Function Empleado_buscarape(ByVal apellido As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("empleado_buscarape", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@apellido", apellido))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empleado")
        dbconn.Close()
        Return ds_JE
    End Function

    'Empleado_obtenerDatos
    Public Function Empleado_obtenerDatos(ByVal dni As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("empleado_obtenerDatos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@dni", dni))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empleado")
        dbconn.Close()
        Return ds_JE
    End Function

    'Informe_Empleado
    Public Function Informe_Empleado() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Informe_Empleado", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empleado")
        dbconn.Close()
        Return ds_JE
    End Function
End Class
