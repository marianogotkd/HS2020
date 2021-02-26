Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Sesiones
    Inherits Datos.Conexion

    'alta ausente
    Public Function sesiones_alta(ByVal PAC_id As Integer, ByVal Sesiones_fecha As Date, ByVal Sesiones_asistencia As String, ByVal Sesiones_estado As String, ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sesiones_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_fecha", Sesiones_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_asistencia", Sesiones_asistencia))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_estado", Sesiones_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sesiones")
        dbconn.Close()
        Return ds_JE
    End Function

    'actualizo ausente por presente.
    Public Function Sesiones_modificar(ByVal Sesiones_id As Integer, ByVal Sesiones_fecha As Date, ByVal Sesiones_asistencia As String, ByVal Sesiones_estado As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sesiones_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_id", Sesiones_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_fecha", Sesiones_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_asistencia", Sesiones_asistencia))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_estado", Sesiones_estado))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sesiones")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Sesiones_obtener_info_dialisis(ByVal Sesiones_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sesiones_obtener_info_dialisis", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_id", Sesiones_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_fecha", Sesiones_fecha))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_asistencia", Sesiones_asistencia))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sesiones")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Sesiones_obtener_activos_pacientes() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sesiones_obtener_activos_pacientes", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_id", Sesiones_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_fecha", Sesiones_fecha))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_asistencia", Sesiones_asistencia))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sesiones")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Sesiones_recuperar_reporte_rangofechas(ByVal fecha_desde As Date, ByVal fecha_hasta As Date, ByVal PAC_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sesiones_recuperar_reporte_rangofechas", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_desde", fecha_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_hasta", fecha_hasta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sesiones_reporte")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Sesiones_recuperar_todos_consumos(ByVal PAC_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sesiones_recuperar_todos_consumos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sesiones_insumos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Sesiones_recuperar_todos_consumos_rangofecha(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Sesiones_recuperar_todos_consumos_rangofecha", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sesiones_insumos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Dialisis_Obtener_Filtro_X_Pac(ByVal Pac_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Dialisis_Obtener_Filtro_X_Pac", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Pac_id", Pac_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_fecha", Sesiones_fecha))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_asistencia", Sesiones_asistencia))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Sesiones")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
