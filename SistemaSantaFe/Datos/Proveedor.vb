Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Proveedor
    Inherits Datos.Conexion

    'proveedor alta
    Public Sub Proveedor_Alta(ByVal Prov_nombre As String, ByVal Prov_responsable As String, ByVal Prov_direccion As String, ByVal Prov_telefono As String, ByVal Prov_celular As String, ByVal Prov_mail As String, ByVal Prov_Observaciones As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Proveedor_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_codigo", Prov_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_nombre", Prov_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_responsable", Prov_responsable))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_direccion", Prov_direccion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_telefono", Prov_telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_celular", Prov_celular))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_mail", Prov_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_Observaciones", Prov_Observaciones))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
    End Sub

    'proveedor modificar
    Public Sub Proveedor_modificar(ByVal Prov_id As Integer, ByVal Prov_nombre As String, ByVal Prov_responsable As String, ByVal Prov_direccion As String, ByVal Prov_telefono As String,
                                   ByVal Prov_celular As String, ByVal Prov_mail As String, ByVal Prov_Observaciones As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("[Proveedor_modificar]", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_nombre", Prov_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_responsable", Prov_responsable))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_direccion", Prov_direccion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_telefono", Prov_telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_celular", Prov_celular))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_mail", Prov_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_Observaciones", Prov_Observaciones))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
    End Sub


    'Proveedor_buscar
    Public Function Proveedor_buscar(ByVal Prov_nombre As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Proveedor_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_codigo", Prov_codigo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_nombre", Prov_nombre))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function

    'Proveedor_buscar_cod
    Public Function Proveedor_buscarcod(ByVal proveedor_cod As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Proveedor_buscarcod", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@proveedor_cod", proveedor_cod))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function


    'Proveedor_buscar_nom
    Public Function Proveedor_buscarnom(ByVal nombre As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Proveedor_buscarnom", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@nombre", nombre))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function


    'Proveedor_obtenerDatos
    Public Function Proveedor_obtenerDatos(ByVal Prov_id As Integer, ByVal Prov_nombre As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Proveedor_obtenerDatos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_nombre", Prov_nombre))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function

    'Para el combo de alta de producto
    Public Function Proveedor_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Proveedor_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Proveedor")
        dbconn.Close()
        Return ds_MT
    End Function

    'Proveedor_obtener_todo
    Public Function Proveedor_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Proveedor_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
