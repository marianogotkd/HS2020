Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Lote
    Inherits Datos.Conexion


    Public Function Lote_buscar_producto(ByVal prod_codinterno As Integer, ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lote_buscar_producto", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Lote_buscar_validar(ByVal sucursal_id As Integer, ByVal prod_codinterno As Integer, ByVal lote_nro As String, ByVal Prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lote_buscar_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_nro", lote_nro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Producto_x_sucursal_lote_alta(ByVal lote_nro As String, ByVal lote_cantidad As Decimal, ByVal lote_fechafab As Date,
                                                  ByVal lote_fechavto As Date, ByVal prod_id As Integer, ByVal sucursal_id As Integer,
                                                    ByVal lote_vence As String, ByVal Prov_id As Integer, ByVal lote_stock_real As Decimal, ByVal lote_aux As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_x_sucursal_lote_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_nro", lote_nro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_cantidad", lote_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_fechafab", lote_fechafab))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_fechavto", lote_fechavto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_vence", lote_vence))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_stock_real", lote_stock_real))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_aux", lote_aux))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Producto_x_sucursal_lote_actualizar_resto(ByVal lote_nro As String, ByVal prod_id As Integer, ByVal sucursal_id As Integer, ByVal lote_cantidad As Decimal, ByVal Prov_id As Integer,
                                                              ByVal lote_stock_real_a As Decimal, ByVal lote_aux As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_x_sucursal_lote_actualizar_resto", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_nro", lote_nro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_cantidad", lote_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_stock_real_a", lote_stock_real_a))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_aux", lote_aux))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Producto_x_sucursal_lote_actualizar_suma(ByVal lote_nro As String, ByVal prod_id As Integer,
                                                             ByVal sucursal_id As Integer, ByVal lote_cantidad As Decimal,
                                                             ByVal Prov_id As Integer, ByVal lote_stock_real_a As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_x_sucursal_lote_actualizar_suma", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_nro", lote_nro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_cantidad", lote_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_stock_real_a", lote_stock_real_a))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Producto_x_sucursal_lote_actualizar_igualar(ByVal lote_nro As String, ByVal prod_id As Integer,
                                                             ByVal sucursal_id As Integer, ByVal lote_cantidad As Decimal,
                                                             ByVal Prov_id As Integer, ByVal lote_stock_real_a As Decimal, ByVal lote_aux As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_x_sucursal_lote_actualizar_igualar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_nro", lote_nro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_cantidad", lote_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_stock_real_a", lote_stock_real_a))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_aux", lote_aux))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Producto_x_sucursal_lote_recuperartodos(ByVal prod_codinterno As Integer, ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_x_sucursal_lote_recuperartodos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Lote_recuperar_info_lote(ByVal prod_id As Integer, ByVal lote_nro As String, ByVal sucursal_id As Integer, ByVal prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lote_recuperar_info_lote", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_nro", lote_nro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prov_id", prov_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Ajuste_lote_vencimiento(ByVal lote_id As Integer, ByVal lote_vence As String, ByVal lote_fechafab As Date, ByVal lote_fechavto As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Ajuste_lote_vencimiento", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_id", lote_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_vence", lote_vence))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_fechafab", lote_fechafab))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_fechavto", lote_fechavto))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Lote_buscar_producto_b(ByVal lote_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lote_buscar_producto_b", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_id", lote_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lote")
        dbconn.Close()
        Return ds_JE
    End Function



End Class
