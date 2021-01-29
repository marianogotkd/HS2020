Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Email

    Inherits Datos.Conexion

    'EmailTipo_Obtener
    Public Function EmailTipo_Obtener() As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("EmailTipo_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "EmailTipo")
        dbconn.Close()
        Return ds_JE
    End Function


    'EMAIL TURNO ///////////////////////////////////////////////

    'Email_OrigenTurno_Obtener
    Public Function Email_OrigenTurno_Obtener() As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Email_OrigenTurno_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "EmailOrigen")
        dbconn.Close()
        Return ds_JE
    End Function

    'Email_OrigenTurno_Alta
    Public Sub Email_OrigenTurno_Alta(ByVal EMAIL_T_id As String, ByVal EMAIL_OR_email As String, ByVal EMAIL_OR_nom As String, ByVal EMAIL_OR_contr As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Email_OrigenTurno_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_T_id", EMAIL_T_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_OR_email", EMAIL_OR_email))
        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_OR_nom", EMAIL_OR_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_OR_contr", EMAIL_OR_contr))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Email_Origen")
        dbconn.Close()
    End Sub

    'Email_OrigenTurno_Modificar
    Public Sub Email_OrigenTurno_Modificar(ByVal EMAIL_T_id As String, ByVal EMAIL_OR_email As String, ByVal EMAIL_OR_nom As String, ByVal EMAIL_OR_contr As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Email_OrigenTurno_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_T_id", EMAIL_T_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_OR_email", EMAIL_OR_email))
        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_OR_nom", EMAIL_OR_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_OR_contr", EMAIL_OR_contr))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Email_Origen")
        dbconn.Close()
    End Sub

    'Email_OrigenTurno_eliminar
    Public Sub Email_OrigenTurno_eliminar()
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Email_OrigenTurno_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Email_Origen")
        dbconn.Close()
    End Sub


    'Email_DestinoTurno_Obtener
    Public Function Email_DestinoTurno_Obtener() As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Email_DestinoTurno_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "EmailDestino")
        dbconn.Close()
        Return ds_JE
    End Function

    'Email_DestinoTurno_Alta
    Public Sub Email_DestinoTurno_Alta(ByVal EMAIL_DE_email As String, ByVal EMAIL_DE_nom As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Email_DestinoTurno_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_DE_email", EMAIL_DE_email))
        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_DE_nom", EMAIL_DE_nom))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "EmailDestino")
        dbconn.Close()
    End Sub

    'Email_DestinoTurno_Modificar
    Public Sub Email_DestinoTurno_Modificar(ByVal EMAIL_DE_id As String, ByVal EMAIL_DE_email As String, ByVal EMAIL_DE_nom As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Email_DestinoTurno_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_DE_id", EMAIL_DE_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_DE_email", EMAIL_DE_email))
        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_DE_nom", EMAIL_DE_nom))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "EmailDestino")
        dbconn.Close()
    End Sub

    'Email_DestinoTurno_eliminar
    Public Sub Email_DestinoTurno_eliminar(ByVal EMAIL_DE_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Email_DestinoTurno_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@EMAIL_DE_id", EMAIL_DE_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "EmailDestino")
        dbconn.Close()
    End Sub

End Class
