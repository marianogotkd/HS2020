Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Servicio
    Inherits Datos.Conexion
    Public Function Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA(ByVal Servicio_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_id", Servicio_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Servicio_Obterner_X_Sucursal_MDA(ByVal sucursal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_Obterner_X_Sucursal_MDA", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Servicio_Obterner_X_Sucursal_MDA_rango_fecha(ByVal desde As Date, ByVal hasta As Date, ByVal sucursal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_Obterner_X_Sucursal_MDA_rango_fecha", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function


    'Servicio_Modificar_MDA

    Public Function Servicio_Modificar_MDA(
                              ByVal CLI_id As Integer,
                              ByVal Servicio_fecha As Date,
                              ByVal sucursal_id As Integer,
                              ByVal USU_id As Integer,
                              ByVal Servicio_Diagnostico As String,
                              ByVal Servicio_Sucursal As String,
                              ByVal Servicio_Equipo As String,
                              ByVal Servicio_FechaRev As Date,
                              ByVal Servicio_FechaRep As Date,
                              ByVal Servicio_Anticipo As Decimal,
                              ByVal Servicio_id As Integer,
                              ByVal estado As String,
                              ByVal Servicio_Desc_peso As Decimal,
                              ByVal Servicio_Desc_porc As Decimal,
                              ByVal Servicio_IVA As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_Modificar_MDA", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_fecha", Servicio_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Diagnostico", Servicio_Diagnostico))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Sucursal", Servicio_Sucursal))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Equipo", Servicio_Equipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_FechaRev", Servicio_FechaRev))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_FechaRep", Servicio_FechaRep))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Anticipo", Servicio_Anticipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_id", Servicio_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@estado", estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Desc_peso", Servicio_Desc_peso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Desc_porc", Servicio_Desc_porc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_IVA", Servicio_IVA))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function


    'Servicio alta_MDA
    Public Function Servicio_alta_MDA(ByVal CLI_id As Integer,
                              ByVal Servicio_fecha As Date,
                              ByVal sucursal_id As Integer,
                              ByVal USU_id As Integer,
                              ByVal Servicio_Diagnostico As String,
                              ByVal Servicio_Sucursal As String,
                              ByVal Servicio_Equipo As String,
                              ByVal Servicio_FechaRev As Date,
                              ByVal Servicio_FechaRep As Date,
                              ByVal Servicio_Anticipo As Decimal,
                              ByVal Servicio_Estado As String,
                              ByVal SucxClie_id As Integer,
                              ByVal Servicio_Desc_peso As Decimal,
                              ByVal Servicio_Desc_porc As Decimal,
                              ByVal Servicio_IVA As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_alta_MDA", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_fecha", Servicio_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Diagnostico", Servicio_Diagnostico))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Sucursal", Servicio_Sucursal))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Equipo", Servicio_Equipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_FechaRev", Servicio_FechaRev))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_FechaRep", Servicio_FechaRep))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Anticipo", Servicio_Anticipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Estado", Servicio_Estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@SucxClie_id", SucxClie_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Desc_peso", Servicio_Desc_peso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Desc_porc", Servicio_Desc_porc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_IVA", Servicio_IVA))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function

    'modificar orden de revicion
    Public Function Servicio_modificar_revision_MDA(ByVal servicio_id As Integer,
                              ByVal Servicio_Diagnostico As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_modificar_revision_MDA", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_id", servicio_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Diagnostico", Servicio_Diagnostico))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function


    'Servicio alta
    Public Function Servicio_alta(ByVal Servicio_fecha As Date,
                              ByVal Servicio_imei As String, ByVal Servicio_Marca As String,
                              ByVal Servicio_Modelo As String, ByVal Servicio_Color As String,
                              ByVal Servicio_bat As String, ByVal Servicio_Obs As String, ByVal Servicio_ManoObra As Decimal,
                              ByVal Servicio_Anticipo As Decimal, ByVal Servicio_Nombre As String, ByVal Servicio_dni As String,
                              ByVal Servicio_dir As String, ByVal Servicio_tel As String, ByVal Servicio_Estado As String,
                              ByVal USU_id As Integer, ByVal sucursal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_fecha", Servicio_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_imei", Servicio_imei))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Marca", Servicio_Marca))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Modelo", Servicio_Modelo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Color", Servicio_Color))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_bat", Servicio_bat))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Obs", Servicio_Obs))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_ManoObra", Servicio_ManoObra))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Anticipo", Servicio_Anticipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Nombre", Servicio_Nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_dni", Servicio_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_dir", Servicio_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_tel", Servicio_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Estado", Servicio_Estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))





        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Servicio_Producto_Alta_DetalleServicio(ByVal Servicio_Id As Integer,
                            ByVal prod_id As Integer, ByVal Servicio_Producto_Costo As Decimal,
                            ByVal Servicio_Producto_Cantidad As Integer, ByVal Servicio_Producto_subtotal As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_Producto_Alta_DetalleServicio", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Id", Servicio_Id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Producto_Costo", Servicio_Producto_Costo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Producto_Cantidad", Servicio_Producto_Cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Producto_subtotal", Servicio_Producto_subtotal))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function

    'choco 11-11-2020 proc para eliminar el detalle de un servicio, es decir los repuestos q agrego.
    Public Function Servicio_eliminar_Detalle(ByVal Servicio_Id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_eliminar_Detalle", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Id", Servicio_Id))
        
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Servicio_validar() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Servicio_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Servicio_Obterner() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Servicio_Obterner", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Servicio_Obterner_X_Sucursal(ByVal sucursal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_Obterner_X_Sucursal", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Servicio_Obterner_Con_Detalle_X_Servicio_id(ByVal Servicio_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_Obterner_Con_Detalle_X_Servicio_id", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_id", Servicio_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Servicio_detalle_venta(ByVal ventaprod_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_detalle_venta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@ventaprod_id", ventaprod_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function

    'Servicio Modificar
    Public Function Servicio_Modificar(
                              ByVal Servicio_imei As Integer, ByVal Servicio_Marca As String,
                              ByVal Servicio_Modelo As String, ByVal Servicio_Color As String,
                              ByVal Servicio_bat As String, ByVal Servicio_Obs As String, ByVal Servicio_ManoObra As Decimal,
                              ByVal Servicio_Anticipo As Decimal, ByVal Servicio_Nombre As String, ByVal Servicio_dni As String,
                              ByVal Servicio_dir As String, ByVal Servicio_tel As String, ByVal Servicio_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_imei", Servicio_imei))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Marca", Servicio_Marca))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Modelo", Servicio_Modelo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Color", Servicio_Color))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_bat", Servicio_bat))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Obs", Servicio_Obs))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_ManoObra", Servicio_ManoObra))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Anticipo", Servicio_Anticipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Nombre", Servicio_Nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_dni", Servicio_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_dir", Servicio_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_tel", Servicio_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_id", Servicio_id))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Servicio_ActualizarEstado(ByVal Servicio_id As Integer, ByVal Servicio_Estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_ActualizarEstado", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_id", Servicio_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Estado", Servicio_Estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
    End Sub

    Public Function Actividad_Servicio_alta(ByVal USU_id As Integer, ByVal Sucursal_id As Integer, ByVal Servicio_id As Integer, ByVal ActividadServicio_fecha As DateTime, ByVal ActividadServicio_concepto As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Actividad_Servicio_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sucursal_id", Sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_id", Servicio_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ActividadServicio_fecha", ActividadServicio_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ActividadServicio_concepto", ActividadServicio_concepto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Actividad")
        dbconn.Close()
        Return ds_JE
    End Function

#Region "calendario servicios"

    Public Function Servicio_calendario_consulta(ByVal desde As Date, ByVal hasta As Date, ByVal sucursal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicio_calendario_consulta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicio")
        dbconn.Close()
        Return ds_JE
    End Function


#End Region


#Region "orden de trabajo"
    'alta de orden, se asocia un servicio "revision" con una orden de trabajo.
    Public Function Orden_trabajo_alta(ByVal Servicio_Id As Integer, ByVal cuadrilla_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Orden_trabajo_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Id", Servicio_Id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cuadrilla_id", cuadrilla_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Orden_trabajo")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Orden_trabajo_eliminar(ByVal Servicio_Id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Orden_trabajo_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Servicio_Id", Servicio_Id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Orden_trabajo")
        dbconn.Close()
        Return ds_JE
    End Function



#End Region
End Class
