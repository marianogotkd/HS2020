Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Vendedor

    Inherits Datos.Conexion

    Public Function Vendedor_recuperar_datos_personales(ByVal vendedor_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Vendedor_recuperar_datos_personales", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_id", vendedor_id))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Vendedor")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function Vendedor_buscarDNI(ByVal dni As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Vendedor_buscarDNI", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@dni", dni))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Vendedor")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Sub Vendedor_alta(ByVal dni As Integer,
                             ByVal apellido As String,
                             ByVal nombre As String,
                             ByVal domicilio As String,
                            ByVal telefono As String,
                            ByVal mail As String,
                            ByVal observacion As String,
                            ByVal foto() As Byte)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Vendedor_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_dni", dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_ape", apellido))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_nom", nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_domicilio", domicilio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_telefono", telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_mail", mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_observacion", observacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_foto", foto))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Vendedor")
        dbconn.Close()
    End Sub

    Public Sub Vendedor_modificar(ByVal vendedor_id As Integer,
                            ByVal dni As Integer,
                            ByVal apellido As String,
                            ByVal nombre As String,
                            ByVal domicilio As String,
                            ByVal telefono As String,
                            ByVal mail As String,
                            ByVal observacion As String,
                            ByVal foto() As Byte)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Vendedor_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_id", vendedor_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_dni", dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_ape", apellido))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_nom", nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_domicilio", domicilio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_telefono", telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_mail", mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_observacion", observacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@vendedor_foto", foto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Vendedor")
        dbconn.Close()
    End Sub


    'los siguientes procedimientos no tienen proc almacenado. eso falta. Choco: 02-12-2019
    Public Function Vendedor_obtenertodo() As DataSet
        'trar los campos con este nombre: vendedor_id, vendedor_dni, vendedor_apenom(concatenado), vendedor_observacion. order by dni. asc

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Vendedor_obtenertodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Vendedor")
        dbconn.Close()
        Return ds_JE
    End Function

End Class
