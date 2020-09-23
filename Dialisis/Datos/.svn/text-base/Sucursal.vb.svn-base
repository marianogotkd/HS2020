Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Sucursal
    Inherits Datos.Conexion

    Public Function Sucursal_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sucursal_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_codigo", Prov_codigo))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_nombre", Prov_nombre))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "sucursal")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Sucursal_alta(ByVal sucursal_nombre As String, ByVal sucursal_direccion As String,
                             ByVal sucursal_telefono As String, ByVal sucursal_mail As String, ByVal prov_id As Integer, ByVal localidad_id As Integer,
                             ByVal sucursal_config_minorista As String, ByVal sucursal_config_mayorista As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sucursal_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_nombre", sucursal_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_direccion", sucursal_direccion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_telefono", sucursal_telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_mail", sucursal_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_id", prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@localidad_id", localidad_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_config_minorista", sucursal_config_minorista))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_config_mayorista", sucursal_config_mayorista))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub

    Public Sub Sucursal_modificar(ByVal Sucursal_id As Integer, ByVal sucursal_nombre As String, ByVal sucursal_direccion As String,
                             ByVal sucursal_telefono As String, ByVal sucursal_mail As String, ByVal prov_id As Integer, ByVal localidad_id As Integer,
                             ByVal sucursal_config_minorista As String, ByVal sucursal_config_mayorista As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sucursal_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", Sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_nombre", sucursal_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_direccion", sucursal_direccion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_telefono", sucursal_telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_mail", sucursal_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_id", prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@localidad_id", localidad_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_config_minorista", sucursal_config_minorista))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_config_mayorista", sucursal_config_mayorista))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub

    Public Function Sucursal_obtener_producto(ByVal prod_id As Integer, ByVal suc_id_Origen As Integer, ByVal suc_id_destino As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sucursal_obtener_producto", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@suc_id_Origen", suc_id_Origen))
        comando.Parameters.Add(New OleDb.OleDbParameter("@suc_id_destino", suc_id_destino))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'esta rutina trae todas las sucursales de una determinada empresa. por ello se debe mandar como parametro el id de la empresa.
    Public Function Sucursal_obtener_todas(ByVal empresa_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sucursal_obtener_todas", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_id", empresa_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Sucursal_consultar_configuracion(ByVal sucursal_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sucursal_consultar_configuracion", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function




End Class
