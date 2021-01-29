Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Medico
    Inherits Datos.Conexion

    Public Function medico_alta(ByVal medico_nombre As String,
                                ByVal medico_dni As Integer,
                                ByVal medico_esp As String,
                                ByVal medico_matricula As Integer, ByVal medico_estado As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("medico_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_nombre", medico_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_dni", medico_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_esp", medico_esp))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_matricula", medico_matricula))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_estado", medico_estado))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "medico")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function medico_eliminar_logico(ByVal medico_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("medico_eliminar_logico", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", medico_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "medico")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Medico_VerificarDni(ByVal medico_dni As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Medico_VerificarDni", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_dni", medico_dni))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Medico")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Medicos_Obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Medicos_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Medicos_Obtener_activos() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Medicos_Obtener_activos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Medicos_Obtener_X_id(ByVal medico_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Medicos_Obtener_X_id", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", medico_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Medico")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function medico_Modificar(ByVal medico_id As String,
                                     ByVal medico_nombre As String,
                                     ByVal medico_esp As String,
                                     ByVal medico_matricula As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("medico_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_nombre", medico_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_esp", medico_esp))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_matricula", medico_matricula))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Medico")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
