Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class CuentaCorriente
    Inherits Datos.Conexion

    Public Function CtaCte_obtenertodo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("CtaCte_obtenertodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CtaCte")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function CtaCte_obtenertodo_Clientes() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("CtaCte_obtenertodo_Clientes", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CtaCte")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub CteCte_alta(ByVal CLI_id As Integer,
                                ByVal fechaalta As DateTime,
                                ByVal total As Decimal,
                                ByVal limite_deuda As Decimal
                                )
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CteCte_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fechaalta", fechaalta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@total", total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@limite_deuda", limite_deuda))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub



    Public Function CtaCte_Obtener_Movimientos(ByVal CtaCte_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_Obtener_Movimientos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function CtaCte_buscar_id(ByVal CtaCte_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_buscar_id", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub CtaCte_modificar(ByVal CtaCte_id As Integer,
                            ByVal CtaCte_estado As String,
                            ByVal CtaCte_limitedeuda As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_estado", CtaCte_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_limitedeuda", CtaCte_limitedeuda))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub

    Public Function CtaCte_buscar_Cliente(ByVal cliente_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_buscar_Cliente", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", cliente_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function CtaCte_movimiento_alta(ByVal CtaCte_id As Integer, ByVal MovimientosCtaCte_tipo As String, ByVal MovimientosCtaCte_concepto As String,
                                 ByVal MovimientosCtaCte_monto As Decimal, ByVal MovimientosCtaCte_fecha As DateTime) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_movimiento_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_tipo", MovimientosCtaCte_tipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_concepto", MovimientosCtaCte_concepto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_monto", MovimientosCtaCte_monto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_fecha", MovimientosCtaCte_fecha))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Venta_CtaCte_alta(ByVal factura_id As Integer, ByVal CtaCte_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Venta_CtaCte_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@factura_id", factura_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub

    Public Sub CtaCte_registrar_egreso(ByVal CtaCte_id As Integer, ByVal CtaCte_total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_registrar_egreso", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_total", CtaCte_total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub

    Public Function Recibo_obtener_ultimo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recibo_obtener_ultimo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", cliente_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recibo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Recibo_alta(ByVal mov_id As Integer, ByVal fecha As DateTime)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recibo_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovimientosCtaCte_id", mov_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha", fecha))
        
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recibo")
        dbconn.Close()

    End Sub

    Public Function Recibo_obtener_reporte(ByVal recibo_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recibo_obtener_reporte", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@recibo_id", recibo_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recibo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Recibo_recuperar_todos_ctacte(ByVal CtaCte_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Recibo_recuperar_todos_ctacte", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Recibo")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
