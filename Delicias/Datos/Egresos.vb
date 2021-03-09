Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Egresos
    Inherits Datos.Conexion
    'Alta de Servicios
    Public Sub Servicios_alta(ByVal Serv_Descripcion As String, ByVal Serv_Monto_Tpo As String, ByVal Serv_Monto As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Servicios_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@descripcion", Serv_Descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@TipoMnto", Serv_Monto_Tpo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Monto", Serv_Monto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Servicios")
        dbconn.Close()
    End Sub


    'Alta de Egresos
    Public Sub Egresos_alta(ByVal Egresos_TpoGas As Integer, ByVal Egresos_Det As String, ByVal Egresos_Monto As Decimal, ByVal Egresos_Fecha As Date, ByVal Egresos_Fecomp As Date, ByVal Egresos_numcomp As Integer, ByVal Egresos_Id_Det As Integer, ByVal Usuario_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Egresos_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@tpogasto", Egresos_TpoGas))
        comando.Parameters.Add(New OleDb.OleDbParameter("@det", Egresos_Det))
        comando.Parameters.Add(New OleDb.OleDbParameter("@monto", Egresos_Monto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha", Egresos_Fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fechacomp", Egresos_Fecomp))
        comando.Parameters.Add(New OleDb.OleDbParameter("@numcomp", Egresos_numcomp))
        comando.Parameters.Add(New OleDb.OleDbParameter("@iddet", Egresos_Id_Det))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Usuario_id", Usuario_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Egresos")
        dbconn.Close()
    End Sub

    Public Function Egresos_registrados_consulta() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Egresos_registrados_consulta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "EgresoRegistrado")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Egresos_Usuario_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Egresos_Usuario_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "UsuariosEgresos")
        dbconn.Close()
        Return ds_JE
    End Function




    Public Function Egreso_Obtener_Empleados() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Egreso_Obtener_Empleados", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Egreso")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Egresos_Obtener_Servicios() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Egresos_Obtener_Servicios", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Egreso")
        dbconn.Close()
        Return ds_JE
    End Function

    'EgresoTipo_obtener
    Public Function EgresoTipo_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("EgresoTipo_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "EgresoTipo")
        dbconn.Close()
        Return ds_JE
    End Function

End Class
