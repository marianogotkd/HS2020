Imports System.Data.OleDb
Imports System.Data.DataRow



Public Class Cuadrilla
    Inherits Datos.Conexion


    Public Function Cuadrilla_validar(ByVal descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cuadrilla_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cuadrilla_descripcion", descripcion))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cuadrilla")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Cuadrilla_alta(ByVal descripcion As String, ByVal salario As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cuadrilla_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@descripcion", descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@salario", salario))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cuadrilla")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Empleado_x_Cuadrilla_alta(ByVal empleado_id As Integer, ByVal Cuadrilla_id As Integer,
                                              ByVal salario As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Empleado_x_Cuadrilla_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_id", empleado_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Cuadrilla_id", Cuadrilla_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@salario", salario))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cuadrilla")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Cuadrilla_obtener_todo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cuadrilla_obtener_todo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@empleado_id", empleado_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cuadrilla")
        dbconn.Close()
        Return ds_JE
    End Function


End Class
