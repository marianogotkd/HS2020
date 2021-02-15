Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Gestion_Mercaderia
    Inherits Datos.Conexion

#Region "consumo"
    Public Function Consumo_Mercaderia_alta_Enfermeria(ByVal concepto As String, ByVal fechahora As Date, ByVal USU_id As Integer,
                                              ByVal sucursal_id_Origen As Integer, ByVal Sesiones_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consumo_Mercaderia_alta_Enfermeria", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Consumo_mercaderia_concepto", concepto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Consumo_mercaderia_FechaHora", fechahora))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Origen", sucursal_id_Origen))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_id", Sesiones_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consumo_Mercaderia_eliminar_Enfermeria(ByVal Consumo_mercaderia_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consumo_Mercaderia_eliminar_Enfermeria", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Consumo_mercaderia_id", Consumo_mercaderia_id))
        
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consumo_Mercaderia_Detalle_eliminar(ByVal Consumo_mercaderia_id As Integer, ByVal prod_codinterno As Integer, ByVal lote_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consumo_Mercaderia_Detalle_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Consumo_mercaderia_id", Consumo_mercaderia_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_id", lote_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consumo_Mercaderia_alta(ByVal concepto As String, ByVal fechahora As Date, ByVal USU_id As Integer,
                                               ByVal sucursal_id_Origen As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consumo_Mercaderia_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Consumo_mercaderia_concepto", concepto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Consumo_mercaderia_FechaHora", fechahora))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Origen", sucursal_id_Origen))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consumo_mercaderia_Detalle_alta(ByVal cantidad As Decimal, ByVal consumo_id As Integer, ByVal prod_codinterno As Integer, ByVal lote_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consumo_mercaderia_Detalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Consumo_mercaderiadetalle_cantidad", cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Consumo_mercaderia_id", consumo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_id", lote_id))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE


    End Function

    Public Function Consumos_mercaderia_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consumos_mercaderia_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        'comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Destino", sucursal_id_Destino))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Consumos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consumos_mercaderia_obtener_rango_fechas(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consumos_mercaderia_obtener_rango_fechas", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))

        'comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Destino", sucursal_id_Destino))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Consumos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consumos_mercaderia_obtener_detalle(ByVal Consumo_mercaderia_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consumos_mercaderia_obtener_detalle", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        comando.Parameters.Add(New OleDb.OleDbParameter("@Consumo_mercaderia_id", Consumo_mercaderia_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function



#End Region




    Public Function Movimiento_Mercaderia_alta3(ByVal MovMer_Concepto As String, ByVal MovMer_FechaHora As Date, ByVal USU_id As Integer,
                                               ByVal sucursal_id_Origen As Integer, ByVal sucursal_id_Destino As Integer,
                                               ByVal MovMer_facturaNRO As String, ByVal MovMer_facturafecha As Date, ByVal MovMer_remitoNRO As String,
                                               ByVal MovMer_remitofecha As Date, ByVal tipo As Integer, ByVal Prov_id As Integer,
                                               ByVal MovMer_IVA As Decimal, ByVal MovMer_TOTAL As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        'NOTA: EL PARAMETRO PROV_ID TRAIGO 0 SI LA OPERACION ES DE MOVIMIENTO ENTRE SUCURSAL O BIEN BAJA, y el valor si toma relevancia para la ALTA

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_Concepto", MovMer_Concepto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_FechaHora", MovMer_FechaHora))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Origen", sucursal_id_Origen))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Destino", sucursal_id_Destino))
        'choco 26-8-2020 se agrego info sobre factura y remito
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_facturaNRO", MovMer_facturaNRO))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_facturafecha", MovMer_facturafecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_remitoNRO", MovMer_remitoNRO))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_remitofecha", MovMer_remitofecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerTipo_id", tipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_IVA", MovMer_IVA))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_TOTAL", MovMer_TOTAL))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function rollback(ByVal tabla As DataTable, ByVal MovMer_id As Integer) As String
        Dim valido As String = "si"
        Dim transaction As OleDbTransaction = Nothing
        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Detalle_alta", dbconn)
        Try
            dbconn.Open()
            transaction = dbconn.BeginTransaction(IsolationLevel.ReadCommitted)
            comando.Transaction = transaction

            Dim i As Integer = 0

            While i < tabla.Rows.Count

                comando.CommandType = CommandType.StoredProcedure
                Dim MovMerDet_Cantidad As Decimal = CDec(CStr(tabla.Rows(i).Item("Cantidad")) + "choco")
                Dim prod_codinterno As Integer = CDec(tabla.Rows(i).Item("Cod_prod"))
                Dim lote_id As Integer = 0
                Dim MovMerDet_precioU As Decimal = 0
                Dim MovMerDet_subtotal As Decimal = 0

                comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_Cantidad", MovMerDet_Cantidad))
                comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_id", MovMer_id))
                comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
                comando.Parameters.Add(New OleDb.OleDbParameter("@lote_id", lote_id))
                'choco 26-08-2020 se agregan precio U y subtotal
                comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_precioU", MovMerDet_precioU))
                comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_subtotal", MovMerDet_subtotal))
                'comando.ExecuteNonQuery()
                Dim ds_JE As New DataSet()
                Dim da_JE As New OleDbDataAdapter(comando)

                da_JE.Fill(ds_JE, "Producto")

                comando.Parameters.Clear()

                i = i + 1
            End While

            transaction.Commit()
            'Console.WriteLine("se guardo el registro")


        Catch ex As Exception
            valido = "no"
            Try
                transaction.Rollback() 'esto se ejecuta y deshace los cambios en la bd.
                ' valido = "no"

            Catch ex1 As Exception
                'valido = "no" 'como no puede ejecutar el rollback al estar apagado el servidor viene x aqui
            End Try
        End Try

        dbconn.Close()
        'Return ds_JE
        Return valido
    End Function

    Public Function Movimiento_Mercaderia_Detalle_alta(ByVal MovMerDet_Cantidad As Decimal, ByVal MovMer_id As Integer, ByVal prod_codinterno As Integer, ByVal lote_id As Integer,
                                                       ByVal MovMerDet_precioU As Decimal, ByVal MovMerDet_subtotal As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Detalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_Cantidad", MovMerDet_Cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_id", MovMer_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@lote_id", lote_id))
        'choco 26-08-2020 se agregan precio U y subtotal
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_precioU", MovMerDet_precioU))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_subtotal", MovMerDet_subtotal))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE


        'Dim transaction As OleDbTransaction = Nothing
        'Dim comando As New OleDbCommand("Movimiento_Mercaderia_Detalle_alta", dbconn)
        'Try
        '    dbconn.Open()
        '    transaction = dbconn.BeginTransaction(IsolationLevel.ReadCommitted)
        '    comando.Transaction = transaction
        '    comando.CommandType = CommandType.StoredProcedure

        '    comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_Cantidad", MovMerDet_Cantidad))
        '    comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_id", MovMer_id))
        '    comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        '    comando.Parameters.Add(New OleDb.OleDbParameter("@lote_id", lote_id))
        '    'choco 26-08-2020 se agregan precio U y subtotal
        '    comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_precioU", MovMerDet_precioU))
        '    comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_subtotal", MovMerDet_subtotal))
        '    'comando.ExecuteNonQuery()
        '    transaction.Commit()
        '    Console.WriteLine("se guardo el registro")


        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        '    Try
        '        transaction.Rollback()

        '    Catch ex1 As Exception

        '    End Try
        'End Try

        'Dim ds_JE As New DataSet()
        'Dim da_JE As New OleDbDataAdapter(comando)
        'da_JE.Fill(ds_JE, "Producto")
        'dbconn.Close()
        'Return ds_JE



    End Function

    Public Function Movimiento_Mercaderia_obtenerProducto_Combos() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_obtenerProducto_Combos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Movimiento_Mercaderia_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        
        'comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Destino", sucursal_id_Destino))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        'comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Destino", sucursal_id_Destino))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_obtener_rango_fechas(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_obtener_rango_fechas", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes_Rango_Fechas(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes_Rango_Fechas", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Movimiento_Mercaderia_obtener_detalle(ByVal MovMer_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_obtener_detalle", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_id", MovMer_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function



#Region "CONSULTAS MOVIMIENTOS ALTA"

    Public Function Movimiento_Mercaderia_Alta_obtenertodo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtenertodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        'comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_id", MovMer_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_Alta_obtenertodo_proveedor(ByVal Prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtenertodo_proveedor", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_ALta_obtener_rango_fechas_todos(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_ALta_obtener_rango_fechas_todos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_ALta_obtener_rango_fechas_todos_proveedor(ByVal desde As Date, ByVal hasta As Date, ByVal prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_ALta_obtener_rango_fechas_todos_proveedor", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", prov_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_Alta_obtener_detalle(ByVal MovMer_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtener_detalle", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_id", MovMer_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    'este recupera todos los detalles, que uso en el formulario consulta_alta_b
    Public Function Movimiento_Mercaderia_Alta_obtener_detalle_b() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtener_detalle_b", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        'comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_id", MovMer_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_Alta_obtener_detalle_b_rango_fechas_todos(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtener_detalle_b_rango_fechas_todos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function
    Public Function Movimiento_Mercaderia_baja_obtener_detalle_b_rango_fechas_todos(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_baja_obtener_detalle_b_rango_fechas_todos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_mov_obtener_detalle_b_rango_fechas_todos(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_mov_obtener_detalle_b_rango_fechas_todos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function





    'Movimiento_Mercaderia_Alta_obtener_detalle_b_rango_fechas_proveedor

    Public Function Movimiento_Mercaderia_Alta_obtener_detalle_b_rango_fechas_proveedor(ByVal desde As Date, ByVal hasta As Date, ByVal Prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtener_detalle_b_rango_fechas_proveedor", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Movimientos")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region

#Region "Gestion Mercaderia Alta"
    'este procedimiento lo utilizo para obtener todos los productos de una sucursal determinada y ademas de un proveedor determinado
    'lo uso en el formulario: BUSQUEDA_PRODUCTOS.VB
    Public Function Movimiento_Mercaderia_Alta_obtenertodo_carga(ByVal sucursal_id As Integer, ByVal Prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtenertodo_carga", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_Alta_obtenerProducto_Combos_marca(ByVal Sucursal_id As Integer, ByVal marca_id As Integer, ByVal prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtenerProducto_Combos_marca", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sucursal_id", Sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", prov_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "productos")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_Alta_obtenerProducto_Combos_categoria(ByVal sucursal_id As Integer, ByVal prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Alta_obtenerProducto_Combos_categoria", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", prov_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@marca_id", marca_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "productos")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region


End Class
