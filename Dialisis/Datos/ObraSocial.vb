Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class ObraSocial
    Inherits Datos.Conexion

    Public Function ObraSocial_Obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ObraSocial_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Obra")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function ObraSocial_alta(ByVal nombre As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ObraSocial_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Obrasocial_nombre", nombre))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "obra")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function ObraSocial_eliminar(ByVal id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ObraSocial_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Obrasocial_id", id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "obra")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function ObraSocial_actualizar(ByVal id As Integer, ByVal nombre As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ObraSocial_actualizar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Obrasocial_id", id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Obrasocial_nombre", nombre))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "obra")
        dbconn.Close()
        Return ds_JE
    End Function



End Class
