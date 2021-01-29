Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Unidad_medida
    Inherits Datos.Conexion
    Public Function Unidad_medida_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Unidad_medida_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_codigo", Prov_codigo))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_nombre", Prov_nombre))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "unidad")
        dbconn.Close()
        Return ds_JE
    End Function

End Class
