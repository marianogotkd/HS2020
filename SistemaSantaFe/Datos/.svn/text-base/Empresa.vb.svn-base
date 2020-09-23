Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Empresa
    Inherits Datos.Conexion

    Public Sub Empresa_Alta(ByVal empresa_Nombre As String, ByVal empresa_dir As String,
                            ByVal empresa_telefono As String, ByVal empresa_eslogan As String,
                            ByVal empresa_mail As String, ByVal empresa_cuit As String,
                            ByVal empresa_foto As Byte())
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Empresa_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_Nombre", empresa_Nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_dir", empresa_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_telefono", empresa_telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_eslogan", empresa_eslogan))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_mail", empresa_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_cuit", empresa_cuit))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_foto", empresa_foto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empresa")
        dbconn.Close()


    End Sub

    'esta la uso para recuperar los datos de la empresa cuyo id=1 necesaria para el encabezado de los reportes en pedidos
    Public Function Empresa_obtener_reporte() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Empresa_obtener_reporte", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "empresa")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function empresa_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("empresa_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "empresa")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function empresa_obtener_porID(ByVal empresa_ID As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("empresa_obtener_porID", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_ID", empresa_ID))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Empresa_Actualizar(ByVal empresa_Nombre As String, ByVal empresa_dir As String,
                                  ByVal empresa_telefono As String, ByVal empresa_eslogan As String,
                                  ByVal empresa_mail As String, ByVal empresa_cuit As String,
                                  ByVal empresa_foto As Byte(), ByVal empresa_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Empresa_Actualizar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_Nombre", empresa_Nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_dir", empresa_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_telefono", empresa_telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_eslogan", empresa_eslogan))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_mail", empresa_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_cuit", empresa_cuit))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_foto", empresa_foto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@empresa_id", empresa_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Empresa")
        dbconn.Close()
    End Sub

End Class
