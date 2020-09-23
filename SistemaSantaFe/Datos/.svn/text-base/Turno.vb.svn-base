Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Turno
    Inherits Datos.Conexion

    'TURNO CONFIGURACION ////////////////////////////////

    'TurnoConfiguracion_Alta
    Public Function TurnoConfiguracion_alta(ByVal TURNO_CONF_fecha As Date, ByVal TURNO_CONF_desde As String, ByVal TURNO_CONF_hasta As String) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoConfiguracion_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_fecha", TURNO_CONF_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_desde", TURNO_CONF_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_hasta", TURNO_CONF_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoConfiguracion")
        dbconn.Close()
        Return ds_JE
    End Function

    'TurnoConfiguracionCancha_alta
    Public Sub TurnoConfiguracionCancha_alta(ByVal TURNO_CONF_id As String, ByVal CANCHA_T_id As String, ByVal TURNO_CONF_precio As Decimal)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoConfiguracionCancha_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_id", TURNO_CONF_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CANCHA_T_id", CANCHA_T_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_precio", TURNO_CONF_precio))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoConfiguracionCancha")
        dbconn.Close()
    End Sub

    'TurnoConfiguracion_obtener
    Public Function TurnoConfiguracion_obtener(ByVal TURNO_CONF_fecha As DateTime, ByVal CANCHA_T_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoConfiguracion_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_fecha", TURNO_CONF_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CANCHA_T_id", CANCHA_T_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoConfiguracion")
        dbconn.Close()
        Return ds_JE
    End Function

    'TurnoConfiguracion_verificar
    Public Function TurnoConfiguracion_verificar(ByVal TURNO_CONF_fecha As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoConfiguracion_verificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_fecha", TURNO_CONF_fecha))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoConfiguracion")
        dbconn.Close()
        Return ds_JE
    End Function


    'TURNO RESERVADO //////////////////////////////////////////////

    'TurnoReservado_Obtener
    Public Function TurnoReservado_Obtener(ByVal FECHA As Date, ByVal CANCHA_id As String, ByVal TURNO_CONF_desde As String,
                                           ByVal TURNO_CONF_hasta As String, ByVal Fecha_dia_selec As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservado_Obtener_choco", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA", FECHA))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CANCHA_id", CANCHA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_desde", TURNO_CONF_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_hasta", TURNO_CONF_hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Fecha_dia_selec", Fecha_dia_selec))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
        Return ds_JE
    End Function

    'TurnoReservado_ObtenerConsulta
    Public Function TurnoReservado_ObtenerConsulta(ByVal FECHA As Date, ByVal CANCHA_id As String, ByVal TURNO_CONF_desde As String,
                                           ByVal TURNO_CONF_hasta As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservado_ObtenerConsulta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA", FECHA))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CANCHA_id", CANCHA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_desde", TURNO_CONF_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_hasta", TURNO_CONF_hasta))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
        Return ds_JE
    End Function


    'TurnoReservado_ObtenerSinIniciar
    Public Function TurnoReservado_ObtenerSinIniciar(ByVal FECHA As Date, ByVal CANCHA_id As String, ByVal TURNO_CONF_desde As String,
                                           ByVal TURNO_CONF_hasta As String, ByVal TURNO_CONF_precio As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservado_ObtenerSinIniciar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA", FECHA))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CANCHA_id", CANCHA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_desde", TURNO_CONF_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_hasta", TURNO_CONF_hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_precio", TURNO_CONF_precio))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
        Return ds_JE
    End Function

    'TurnoReservado_alta
    Public Function TurnoReservado_alta(ByVal cancha_id As String, ByVal turno_fecha As Date, ByVal turno_cant As String, ByVal turno_hora As String, ByVal TURNO_fechahasta As Date,
                          ByVal CLI_id As String, ByVal usuario_id As String) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservado_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cancha_id", cancha_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_fecha", turno_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_cant", turno_cant))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_hora", turno_hora))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_fechahasta", TURNO_fechahasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
        Return ds_JE
    End Function

    'TurnoReservado_ActualizarEstado
    Public Sub TurnoReservado_ActualizarEstado(ByVal TURNO_id As String, ByVal TURNO_estado As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservado_ActualizarEstado", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_estado", TURNO_estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
    End Sub

   
    'TURNO RESERVADO FIJO ////////////////////////////////////////

    'TurnoReservadoFijo_Obtener
    Public Function TurnoReservadoFijo_Obtener(ByVal DIA As Integer, ByVal CANCHA_id As String, ByVal TURNO_CONF_desde As String,
                                           ByVal TURNO_CONF_hasta As String) As DataSet
        Dim SIG As Integer
        If DIA = 7 Then
            SIG = 1
        Else
            SIG = DIA + 1
        End If

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservadoFijo_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@DIA", DIA))
        comando.Parameters.Add(New OleDb.OleDbParameter("@SIG", SIG))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CANCHA_id", CANCHA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_desde", TURNO_CONF_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_hasta", TURNO_CONF_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoReservadoFijo")
        dbconn.Close()
        Return ds_JE
    End Function

    'TurnoReservadoFijo_alta
    Public Sub TurnoReservadoFijo_alta(ByVal cancha_id As String, ByVal turno_F_dia As String, ByVal turno_F_cant As String, ByVal turno_F_hora As String,
                          ByVal usuario_id As String, ByVal CLI_id As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservadoFijo_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cancha_id", cancha_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_F_fecha", turno_F_dia))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_F_cant", turno_F_cant))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_F_hora", turno_F_hora))
        comando.Parameters.Add(New OleDb.OleDbParameter("@usuario_id", usuario_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoReservadoFijo")
        dbconn.Close()
    End Sub

    'TurnoReservadoFijo_Eliminar
    Public Sub TurnoReservadoFijo_Eliminar(ByVal TURNO_F_id As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservadoFijo_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_F_id", TURNO_F_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoReservadoFijo")
        dbconn.Close()
    End Sub

    'TurnoReservadoFijo_ActualizarEstado
    Public Sub TurnoReservadoFijo_ActualizarEstado(ByVal TURNO_F_id As String, ByVal TURNO_F_estado As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservadoFijo_ActualizarEstado", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_F_id", TURNO_F_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_F_estado", TURNO_F_estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
    End Sub

    'TurnoReservadoFijoDisp_Alta
    Public Sub TurnoReservadoFijoDisp_Alta(ByVal TURNO_T_id As String, ByVal TURNO_T_NO_desde As DateTime, ByVal TURNO_T_NO_hasta As DateTime)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservadoFijoDisp_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_T_id", TURNO_T_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_T_NO_desde", TURNO_T_NO_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_T_NO_hasta", TURNO_T_NO_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoReservadoFijoDisp")
        dbconn.Close()
    End Sub

    'TurnoReservadoFijoDisp_Eliminar
    Public Sub TurnoReservadoFijoDisp_Eliminar(ByVal TURNO_T_id As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservadoFijoDisp_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_T_id", TURNO_T_id))
      
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoReservadoFijoDisp")
        dbconn.Close()
    End Sub

    'TurnoReservadoFijoDisp_Obtener
    Public Function TurnoReservadoFijoDisp_Obtener(ByVal TURNO_F_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservadoFijoDisp_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_F_id", TURNO_F_id))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoReservadoFijoDisp")
        dbconn.Close()
        Return ds_JE
    End Function

    'TurnoReservado_Eliminar
    Public Sub TurnoReservado_Eliminar(ByVal TURNO_id As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoReservado_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "TurnoReservado")
        dbconn.Close()
    End Sub

    'TURNO ///////////////////////////////////////////////////////

    'Turno_alta
    Public Sub Turno_alta(ByVal TURNO_CONF_id As String, ByVal cancha_id As String, ByVal turno_fecha As Date, ByVal TURNO_desde As String,
                          ByVal TURNO_hasta As String, ByVal TURNO_tiempo As String, ByVal CLI_id As String, ByVal TURNO_fechahasta As Date,
                          ByVal USU_id As String, ByVal TURNO_pago As Decimal, ByVal TURNO_saldo As Decimal)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Turno_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_id", TURNO_CONF_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cancha_id", cancha_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@turno_fecha", turno_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_desde", TURNO_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_hasta", TURNO_hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_tiempo", TURNO_tiempo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_fechahasta", TURNO_fechahasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_pago", TURNO_pago))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_saldo", TURNO_saldo))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
    End Sub

    'Turno_modificar
    Public Sub Turno_modificar(ByVal TURNO_id As Integer, ByVal TURNO_desde As String, ByVal TURNO_hasta As String,
                               ByVal TURNO_tiempo As String, ByVal TURNO_fechahasta As Date, ByVal TURNO_estado As Integer)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Turno_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_desde", TURNO_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_hasta", TURNO_hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_tiempo", TURNO_tiempo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_fechahasta", TURNO_fechahasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_estado", TURNO_estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
    End Sub

    'Turno_modificarSaldo
    Public Sub Turno_modificarSaldo(ByVal TURNO_id As String, ByVal TURNO_saldo As Decimal)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Turno_modificarSaldo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_saldo", TURNO_saldo))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
    End Sub

    'Turno_ObtenerIniciado
    Public Function Turno_ObtenerIniciado() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Turno_ObtenerIniciado", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
        Return ds_JE
    End Function

    'Turno_ObtenerFinalizado
    Public Function Turno_ObtenerFinalizado(ByVal FECHA As Date, ByVal CANCHA_id As String, ByVal TURNO_CONF_desde As String,
                                           ByVal TURNO_CONF_hasta As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Turno_ObtenerFinalizado", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@FECHA", FECHA))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CANCHA_id", CANCHA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_desde", TURNO_CONF_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_hasta", TURNO_CONF_hasta))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
        Return ds_JE
    End Function

    'DIA ////////////////////////////////////////////////////

    'Dia_obtener
    Public Function Dia_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Dia_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dia")
        dbconn.Close()
        Return ds_JE
    End Function

    '/////////////////////////////////////////////
    'VentaTurnoReservado_Alta
    Public Sub VentaTurnoReservado_Alta(ByVal TURNO_id As String, ByVal TURNO_T_id As String, ByVal VENTA_TURNO_fecha As Date, ByVal VENTA_TURNO_costo As Decimal,
                          ByVal USU_id As String, ByVal CAJA_id As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaTurnoReservado_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_T_id", TURNO_T_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VENTA_TURNO_fecha", VENTA_TURNO_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VENTA_TURNO_costo", VENTA_TURNO_costo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_id", CAJA_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "VentaTurno")
        dbconn.Close()
    End Sub

    'VentaTurno_Alta
    Public Sub VentaTurno_Alta(ByVal TURNO_id As String, ByVal VENTA_TURNO_fecha As Date, ByVal VENTA_TURNO_costo As Decimal,
                          ByVal USU_id As String, ByVal CAJA_id As String)

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("VentaTurno_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_id", TURNO_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VENTA_TURNO_fecha", VENTA_TURNO_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@VENTA_TURNO_costo", VENTA_TURNO_costo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CAJA_id", CAJA_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "VentaTurno")
        dbconn.Close()
    End Sub

    'TURNO INFORME ///////////////////////////////////////////////////////////////////////////////////

    'TurnoInforme_ReservadoComun
    Public Function TurnoInforme_ReservadoComun(ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal TURNO_CONF_desde As String,
                                           ByVal TURNO_CONF_hasta As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("TurnoInforme_ReservadoComun", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@FechaDesde", FechaDesde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@FechaHasta", FechaHasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_desde", TURNO_CONF_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TURNO_CONF_hasta", TURNO_CONF_hasta))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Turno")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
