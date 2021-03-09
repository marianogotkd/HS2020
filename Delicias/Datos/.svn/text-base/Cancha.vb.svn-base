Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Cancha
    Inherits Datos.Conexion

    Public Sub Cancha_alta(ByVal canchatipo_id As String, ByVal cancha_nom As String, ByVal cancha_estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cancha_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@canchatipo_id", canchatipo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cancha_nom", cancha_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cancha_estado", cancha_estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cancha")
        dbconn.Close()


    End Sub

    Public Sub Cancha_modificar(ByVal cancha_id As String, ByVal canchatipo_id As String, ByVal cancha_nom As String, ByVal cancha_estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cancha_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cancha_id", cancha_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@canchatipo_id", canchatipo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cancha_nom", cancha_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cancha_estado", cancha_estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cancha")
        dbconn.Close()


    End Sub

    'CanchaTipo_obtener
    Public Function CanchaTipo_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("CanchaTipo_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CanchaTipo")
        dbconn.Close()
        Return ds_JE
    End Function

    'Cancha_obtener
    Public Function Cancha_obtener(ByVal CANCHA_T_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cancha_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("CANCHA_T_id", CANCHA_T_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cancha")
        dbconn.Close()
        Return ds_JE
    End Function





    



End Class
