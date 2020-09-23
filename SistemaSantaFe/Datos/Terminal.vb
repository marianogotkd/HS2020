Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Terminal
    Inherits Datos.Conexion
    Public Function Terminal_obtener_todo(ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Terminal_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("sucursal_id", sucursal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Terminal")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Usuario_x_Terminal_Validar(ByVal usu_id As Integer, ByVal terminal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_x_Terminal_Validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@usu_id", usu_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Proveedor")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Usuario_x_Terminal_Registrar(ByVal USU_id As Integer, ByVal Terminales_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_x_Terminal_Registrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Terminales_id", Terminales_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Marca")
        dbconn.Close()
    End Sub

    Public Sub Usuario_x_Terminal_eliminar(ByVal Terminal_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_x_terminal_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Terminal", Terminal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Terminal")
        dbconn.Close()
    End Sub

    'trae todas las terminales sin distinguir sucursal
    Public Function Terminal_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Terminal_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        'comando.Parameters.Add(New OleDb.OleDbParameter("sucursal_id", sucursal_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Terminal")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Terminal_validar_alta(ByVal terminal_desc As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Terminal_validar_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("terminal_desc", terminal_desc))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Terminal")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Terminal_alta(ByVal sucursal_id As Integer, ByVal Terminales_desc As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Terminal_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Terminales_desc", Terminales_desc))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Terminal")
        dbconn.Close()
    End Sub

    Public Sub Terminal_modificar(ByVal terminal_id As Integer, ByVal terminal_desc As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Terminal_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_desc", terminal_desc))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Terminal")
        dbconn.Close()
    End Sub

    Public Sub Terminal_bloquear_desbloquear(ByVal terminal_id As Integer, ByVal estado As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Terminal_bloquear_desbloquear", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@terminal_id", terminal_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@estado", estado))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Terminal")
        dbconn.Close()
    End Sub

End Class
