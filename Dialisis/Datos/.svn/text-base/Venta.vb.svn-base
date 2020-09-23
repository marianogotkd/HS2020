Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Venta
    Inherits Datos.Conexion

#Region "SECTOR"
    Public Sub Mesas_Sector_modificar(ByVal Sector_nombre_fijo As String, ByVal Sector_nombre_usuario As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Mesas_Sector_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sector_nombre_fijo", Sector_nombre_fijo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sector_nombre_usuario", Sector_nombre_usuario))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mesas")
        dbconn.Close()
    End Sub

    Public Function Mesas_Sector_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mesas_Sector_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mesas")
        dbconn.Close()
        Return ds_JE
    End Function



#End Region

#Region "MESAS"
    'VentaConfig_alta
    Public Sub VentaConfig_alta(ByVal Ventaprod_id As Integer, ByVal LISTA_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaConfig_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Ventaprod_id", Ventaprod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_id", LISTA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
    End Sub
    'VentaConfig_buscar
    Public Function VentaConfig_buscar(ByVal Ventaprod_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaConfig_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Ventaprod_id", Ventaprod_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function
    'MESAS_alta
    Public Sub Mesas_alta(ByVal MESA_numero As Integer, ByVal Estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Mesas_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@MESA_numero", MESA_numero))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Estado", Estado))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
    End Sub

    'MESAS_agregartiempo ----NUEVO DISEÑO
    Public Function VentaProducto_registrar_monto_mastiempo_b(ByVal TURNO_id As Integer, ByVal ventaprod_total As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProducto_registrar_monto_mastiempo_b", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_total", ventaprod_total))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function VentaProducto_registrar_monto_mastiempo_a(ByVal TURNO_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProducto_registrar_monto_mastiempo_a", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function VentaProducto_registrar_monto_mastiempo_c(ByVal ventaprod_id As Integer, ByVal ventaprod_total As Decimal, ByVal ventaprod_estado As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProducto_registrar_monto_mastiempo_c", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_total", ventaprod_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_estado", ventaprod_estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function



    'MESAS_modificar ----NUEVO DISEÑO
    Public Sub MESAS_modificar(ByVal MESA_id As Integer, ByVal MESA_numero As Integer, ByVal Estado As String, ByVal Activo As String, ByVal Ventaprod_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Mesas_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@MESA_id", MESA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MESA_numero", MESA_numero))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Estado", Estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Activo", Activo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Ventaprod_id", Ventaprod_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub

    'Mesas_obtener_todas -----NUEVO DISEÑO
    Public Function Mesas_obtener_todas() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mesas_obtener_todas", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mesas")
        dbconn.Close()
        Return ds_JE
    End Function

    'Mesas_obtener
    Public Function Mesas_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mesas_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Mesas")
        dbconn.Close()
        Return ds_JE
    End Function
    'ventaproducto_alta_mesa
    Public Function VentaProducto_alta_mesa(ByVal ventaprod_total As Decimal, ByVal ventaprod_pagoparcial As Decimal, ByVal ventaprod_estado As String, ByVal ventaprod_fecha As Date, ByVal usuario_id As Integer, ByVal ventaprod_tipovta As String, ByVal cliente_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProducto_alta_mesa", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_total", ventaprod_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_pagoparcial", ventaprod_pagoparcial))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_estado", ventaprod_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_fecha", ventaprod_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_tipovta", ventaprod_tipovta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cliente_id", cliente_id))
        'el tipo de venta es cliente o consumidor final
        'el id del cliente es 0 en caso de ser consumidor final
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'ventaproducto_modificar_mesa
    Public Sub VentaProducto_modificar_mesa(ByVal ventaprod_id As Integer, ByVal ventaprod_total As Decimal, ByVal ventaprod_pagoparcial As Decimal, ByVal ventaprod_estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProducto_modificar_mesa", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_total", ventaprod_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_pagoparcial", ventaprod_pagoparcial))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_estado", ventaprod_estado))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoVenta")
        dbconn.Close()
    End Sub

    'VentaProductoDetalle_borrar
    Public Sub VentaProductoDetalle_borrar(ByVal ventaprod_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProductoDetalle_borrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub

    'Mesas_eliminar
    Public Sub Mesas_eliminar(ByVal MESA_numero As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Mesas_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@MESA_numero", MESA_numero))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub



    Public Function VentaProducto_buscar(ByVal ventaprod As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProducto_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod", ventaprod))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function VentaProductoDetalle_buscar(ByVal ventaprod_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("VentaProductoDetalle_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Sector_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sector_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sector")
        dbconn.Close()
        Return ds_JE
    End Function



#End Region


#Region "CONSULTA DE VENTAS"
    'consulta las ventas realizadas en una sucursal segun 3 parametros, fecha desde y hasta y el id de la sucursal
    Public Function Venta_consultar_recaudacion_sucursal(ByVal fecha_Origen As Date, ByVal fecha_destino As Date, ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_consultar_recaudacion_sucursal", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_Origen", fecha_Origen))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_destino", fecha_destino))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function
    'igual que "Venta_consultar_recaudacion_sucursal" solo q ademas paso el parametro de usuario_id para filtar
    Public Function Venta_consultar_recaudacion_sucursal_x_usuario(ByVal fecha_Origen As Date, ByVal fecha_destino As Date, ByVal sucursal_id As Integer, ByVal usuario_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_consultar_recaudacion_sucursal_x_usuario", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_Origen", fecha_Origen))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_destino", fecha_destino))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function
    Public Function Venta_consultar_detalle_venta(ByVal ventaprod_id As Integer, ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_consultar_detalle_venta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "venta")
        dbconn.Close()
        Return ds_JE
    End Function




#End Region

#Region "VENTA CON TARJETA"
    Public Function Venta_x_tarjeta_alta(ByVal ventaprod_id As Integer, ByVal Venta_x_tarjeta_montototal As Decimal, ByVal Venta_x_tarjeta_nrotarjeta As String, ByVal Venta_x_tarjeta_nrocomprobante As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_x_tarjeta_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_x_tarjeta_montototal", Venta_x_tarjeta_montototal))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_x_tarjeta_nrotarjeta", Venta_x_tarjeta_nrotarjeta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Venta_x_tarjeta_nrocomprobante", Venta_x_tarjeta_nrocomprobante))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "venta_tarjeta")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region

    'venta_alta
    Public Sub Venta_alta(ByVal venta_fecha As Date, ByVal usuario_id As String, ByVal cliente_id As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@venta_fecha", venta_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cliente_id", cliente_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub


    Public Sub Venta_actualizar_stock_Caja(ByVal prod_codinterno As Integer, ByVal prod_stock As Decimal, ByVal prod_gondola As Integer, ByVal sucursal_id As Integer)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_actualizar_stock_Caja", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_stock", prod_stock))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_gondola", prod_gondola))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub

    'actualizar stock de los item del combo
    Public Sub Venta_actualizar_stock_Caja_2(ByVal prod_id As Integer, ByVal prod_stock As Integer, ByVal prod_gondola As Integer)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_actualizar_stock_Caja_2", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_stock", prod_stock))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_gondola", prod_gondola))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()

    End Sub

    'ventaproducto_alta
    Public Function VentaProducto_alta(ByVal ventaprod_total As Decimal, ByVal ventaprod_fecha As Date, ByVal usuario_id As Integer, ByVal ventaprod_tipovta As String, ByVal cliente_id As Integer,
                                       ByVal ventaprod_subtotal As Decimal, ByVal ventaprod_descuento_pesos As Decimal, ByVal ventaprod_descuento_porcentaje As Decimal,
                                       ByVal ventaprod_iva_porcentaje As Decimal, ByVal ventaprod_iva_pesos As Decimal, ByVal ventaprod_observacion As String,
                                       ByVal Servicio_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProducto_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_total", ventaprod_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_fecha", ventaprod_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_tipovta", ventaprod_tipovta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cliente_id", cliente_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_subtotal", ventaprod_subtotal)) 'este parametro trae el total sumado de productos, sin descuento ni iva aplicado
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_descuento_pesos", ventaprod_descuento_pesos))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_descuento_porcentaje", ventaprod_descuento_porcentaje))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_iva_porcentaje", ventaprod_iva_porcentaje))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_iva_pesos", ventaprod_iva_pesos))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_observacion", ventaprod_observacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_id", Servicio_id))

        'el tipo de venta es cliente o consumidor final
        'el id del cliente es 0 en caso de ser consumidor final

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'VentaProductoDetalle_alta
    Public Sub VentaProductoDetalle_alta(ByVal ventaprod_id As Integer,
                                         ByVal prod_id As Integer,
                                         ByVal ventaprod_cant As Decimal,
                                         ByVal ventaprod_precio As Decimal,
                                         ByVal ventaprod_subtotal As Decimal,
                                         ByVal ventaprod_descripcion As String,
                                         ByVal codigointerno As String,
                                         ByVal TURNO_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProductoDetalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_cant", ventaprod_cant))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_precio", ventaprod_precio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_subtotal", ventaprod_subtotal))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_descripcion", ventaprod_descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@codigointerno", codigointerno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))

        'el tipo de venta es cliente o consumidor final
        'el id del cliente es 0 en caso de ser consumidor final

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Producto")
        dbconn.Close()

    End Sub




    'ventaturno_alta
    Public Sub Ventaturno_alta(ByVal venta_id As String, ByVal turno_id As String, ByVal turno_tipo As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaTurno_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@venta_id", venta_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_id", turno_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_tipo", turno_tipo))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Turno")
        dbconn.Close()

    End Sub



    Public Function Producto_x_Sucursal_obtener_todo(ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_x_Sucursal_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function obtener_ultimo_nrofactura() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_obtener_nrofactura", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Producto_x_Sucursal_obtener_todo_marca(ByVal Sucursal_id As Integer, ByVal marca_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_x_Sucursal_obtener_todo_marca", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Sucursal_id", Sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Producto_x_Sucursal_obtener_todo_categoria(ByVal Sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Producto_x_Sucursal_obtener_todo_categoria", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Sucursal_id", Sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function


    'Venta_obtenerProducto_Combos --- trae de la tabla products por sucursal.
    'la consulta la hace a travez del id de usuario, luego en sql recupera el id de la sucursal para listar los productos
    Public Function Venta_obtenerProducto_Combos(ByVal USU_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_obtenerProducto_Combos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Venta_obtenerProducto_Combos_sucursal(ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_obtenerProducto_Combos_sucursal", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function







    'Venta_obtenerProducto_listaregular
    Public Function Venta_obtenerProducto_listaregular(ByVal Lista_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_obtenerProducto_listaregular", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Lista_id", Lista_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Venta_Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Venta_Usuario_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_Usuario_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function VentaProducto_consultausuario() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProducto_consultausuario", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Ventaproducto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function VentaProducto_consulta(ByVal USU_id As Integer, ByVal ventaprod_fecha As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaProducto_consulta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_fecha", ventaprod_fecha))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Ventaproducto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Obtener_usuario_y_sucursal(ByVal USU_ID As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Obtener_usuario_y_sucursal", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_ID", USU_ID))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function



#Region "busquedas complejas por cagorias y marcas"
    Public Function Venta_obtenerProducto_Combos_marca(ByVal USU_ID As Integer, ByVal marca_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Venta_obtenerProducto_Combos_marca", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_ID", USU_ID))
        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "productos")
        dbconn.Close()
        Return ds_JE
    End Function
    'es igual a Venta_obtenerProducto_Combos_marca solo q paso como parametro la sucursal, no lo tomo de la variable del login, sino de un formulario
    Public Function Venta_obtenerProducto_Combos_marca_GM(ByVal Sucursal_id As Integer, ByVal marca_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_obtenerProducto_Combos_marca_GM", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sucursal_id", Sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "productos")
        dbconn.Close()
        Return ds_JE
    End Function
    Public Function Venta_obtenerProducto_Combos_categoria(ByVal USU_ID As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_obtenerProducto_Combos_categoria", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_ID", USU_ID))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "productos")
        dbconn.Close()
        Return ds_JE
    End Function
    Public Function Venta_obtenerProducto_Combos_categoria_GM(ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_obtenerProducto_Combos_categoria_GM", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "productos")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region








End Class
