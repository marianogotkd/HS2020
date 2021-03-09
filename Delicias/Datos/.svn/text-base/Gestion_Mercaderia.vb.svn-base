Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Gestion_Mercaderia
    Inherits Datos.Conexion


    Public Function Movimiento_Mercaderia_alta3(ByVal MovMer_Concepto As String, ByVal MovMer_FechaHora As Date, ByVal USU_id As Integer,
                                               ByVal sucursal_id_Origen As Integer, ByVal sucursal_id_Destino As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_Concepto", MovMer_Concepto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_FechaHora", MovMer_FechaHora))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Origen", sucursal_id_Origen))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id_Destino", sucursal_id_Destino))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Movimiento_Mercaderia_Detalle_alta(ByVal MovMerDet_Cantidad As Decimal, ByVal MovMer_id As Integer, ByVal prod_codinterno As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Movimiento_Mercaderia_Detalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMerDet_Cantidad", MovMerDet_Cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@MovMer_id", MovMer_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
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



End Class
