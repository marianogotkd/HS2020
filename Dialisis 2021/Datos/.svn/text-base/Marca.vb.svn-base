Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Marca
    Inherits Datos.Conexion
    'Para el combo de alta de producto
    Public Function Marca_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Marca_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Marca")
        dbconn.Close()
        Return ds_MT
    End Function

    'Alta de marca
    Public Sub Marca_alta(ByVal marca_nom As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Marca_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_nom", marca_nom))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Marca")
        dbconn.Close()
    End Sub


    'Eliminar Marca
    Public Sub Marca_eliminar(ByVal marca_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Marca_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub

    'Marca Modificar
    Public Sub Marca_Modificar(ByVal marca_id As Integer, ByVal Marca_nom As String
        )
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Marca_Actualizar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Marca_nom", Marca_nom))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub


End Class
