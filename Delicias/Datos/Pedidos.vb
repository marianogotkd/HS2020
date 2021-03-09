Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Pedidos


    Inherits Datos.Conexion

    'Pedidos_Obtener_Prod_Prove
    Public Function Pedidos_Obtener_Prod_Prove(ByVal Prov As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Prod_Prove", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@cod", Prov))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Pedidos_Alta(ByVal Pedidos_Cod As Integer, ByVal Pedidos_Fecha As Date, ByVal Pedidos_Cod_Prov As Integer, ByVal Pedidos_Total As Decimal, ByVal Pedidos_Estado As String, ByVal sucursal_id As Integer, ByVal USU_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Cod", Pedidos_Cod))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Fecha", Pedidos_Fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Cod_Prov", Pedidos_Cod_Prov))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Total", Pedidos_Total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Estado", Pedidos_Estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Pedidos_validar() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Pedidos_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Pedidos_Detalle_Alta(ByVal PedidosDet_Pedidos_ID As Integer, ByVal PedidosDet_Prov_Prod_Com_id As Integer, ByVal PedidosDet_Cantida As Decimal, ByVal PedidosDet_Total As Decimal, ByVal precio_u As Decimal) As DataSet

        '""PedidosDet_Pedidos_ID"" es el id de la tabla pedidos
        '""PedidosDet_Prov_Prod_Com_id""" es directamente el codigo tomado de la tabla de productos 
        'MGO 11-10-18
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand(" Pedidos_Detalle_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Pedidos_ID", PedidosDet_Pedidos_ID))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Prov_Prod_Com_id", PedidosDet_Prov_Prod_Com_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Cantida", PedidosDet_Cantida))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_precioU", precio_u))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Total", PedidosDet_Total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, " Pedidos_Detalle_Alta")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Obtener_todos() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_todos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Obtener_Pendiente() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Pendiente", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Obtener_Listo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Listo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Detalle_Consulta(ByVal Prov As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Detalle_Consulta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_ID", Prov))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'PedidoEstado_obtener
    Public Function PedidoEstado_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("PedidoEstado_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "PedidoEstado")
        dbconn.Close()
        Return ds_JE
    End Function

    'Pedidos_ActualizarCantidad
    Public Sub Pedidos_ActualizarCantidad(ByVal PedidosDet_id As Integer, ByVal PedidosDet_cantidad As Decimal, ByVal PedidosDet_Total As Decimal, ByVal PedidoDet_CantRecibida As Decimal, ByVal PedidosDet_precioU As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_ActualizarCantidad", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_id", PedidosDet_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_cantidad", PedidosDet_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Total", PedidosDet_Total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidoDet_CantRecibida", PedidoDet_CantRecibida))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_precioU", PedidosDet_precioU))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "PedidosDetalle")
        dbconn.Close()
    End Sub

    'Pedidos_ActualizarPrecio
    Public Sub Pedidos_ActualizarPrecio(ByVal Prov_Prod_Com_id As Integer, ByVal Prov_Prod_Com_precio As Decimal,
                                        ByVal PedidosDet_id As Integer, ByVal PedidosDet_Total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_ActualizarPrecio", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_Prod_Com_id", Prov_Prod_Com_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_Prod_Com_precio", Prov_Prod_Com_precio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_id", PedidosDet_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PedidosDet_Total", PedidosDet_Total))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProveedorProductoCompra")
        dbconn.Close()
    End Sub

    'Pedidos_ActualizarTotal
    Public Sub Pedidos_ActualizarTotal(ByVal Pedidos_id As Integer, ByVal Pedidos_Total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_ActualizarTotal", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_id", Pedidos_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Total", Pedidos_Total))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
    End Sub

    'Pedidos_ActualizarEstado , sucursal donde se recepciona y el id de usuario responsable, fecha de recepcion
    Public Sub Pedidos_ActualizarEstado(ByVal Pedidos_id As Integer, ByVal Pedidos_Estado As String, ByVal USU_id As Integer, ByVal sucursal_id As Integer, ByVal Fecha_recepcion As DateTime, ByVal Pedidos_Total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Pedidos_ActualizarEstado", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_id", Pedidos_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Estado", Pedidos_Estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha_recepcion", Fecha_recepcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Total", Pedidos_Total))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
    End Sub

    'Pedidos_Eliminar
    Public Sub Pedidos_Eliminar(ByVal Pedidos_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_id", Pedidos_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
    End Sub


    Public Function Pedidos_Obtener_Listo_Fecha(ByVal FECHA_desde As Date, ByVal FECHA_hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Listo_Fecha", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA_desde", FECHA_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA_hasta", FECHA_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Pedidos_Obtener_Pendiente_Fecha(ByVal FECHA_desde As Date, ByVal FECHA_hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_Pendiente_Fecha", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA_desde", FECHA_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA_hasta", FECHA_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Productos_x_Proveedor_Obtener(ByVal Prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Productos_x_Proveedor_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    'MGO 11-10-18
    Public Function Pedidos_Obtener_x_Prove(ByVal Pedidos_Cod_Prov As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Obtener_x_Prove", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Cod_Prov", Pedidos_Cod_Prov))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function

    'MGO 11-10-18
    Public Function Pedidos_ObtenerDetalle_X_idPedido(ByVal Pedidos_ID As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_ObtenerDetalle_X_idPedido", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_ID", Pedidos_ID))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_Actualizar(ByVal Pedidos_Fecha As Date, ByVal Pedidos_id As Integer, ByVal Pedidos_Estado As Integer, ByVal Pedidos_Total As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_Actualizar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_id", Pedidos_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Fecha", Pedidos_Fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Estado", Pedidos_Estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Total", Pedidos_Total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Pedidos_buscar_rango_fecha(ByVal fecha_desde As Date, ByVal fecha_hasta As Date, ByVal Pedidos_Cod_Prov As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Pedidos_buscar_rango_fecha", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_hasta", fecha_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_hasta", fecha_hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Pedidos_Cod_Prov", Pedidos_Cod_Prov))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Productos_x_Proveedor_Obtener_marca(ByVal Prov_id As Integer, ByVal marca_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Productos_x_Proveedor_Obtener_marca", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Productos_x_Proveedor_Obtener_categoria(ByVal Prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Productos_x_Proveedor_Obtener_categoria", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Pedidos")
        dbconn.Close()
        Return ds_JE
    End Function

End Class
