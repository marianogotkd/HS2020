Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class estadocivil
    Inherits Datos.Conexion

    Public Function Estadocivil_Obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Estadocivil_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "estadocivil")
        dbconn.Close()
        Return ds_JE
    End Function
End Class
