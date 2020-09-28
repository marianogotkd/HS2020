Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Paciente
    Inherits Datos.Conexion

    Public Function Paciente_Alta(ByVal PAC_ape As String, ByVal PAC_nombre As String, ByVal PAC_dni As String, ByVal PAC_fnac As Date, ByVal PAC_sexo As String, ByVal Obrasocial_id As Integer,
                                  ByVal PAC_numafi As String, ByVal PAC_tel As String, ByVal PAc_dir As String, ByVal PAC_CP As Integer, ByVal PAC_Id_Prov As Integer, ByVal PAC_Id_Loc As Integer,
ByVal PAC_mail As String, ByVal PAC_estado As String, ByVal Estadocivil_id As Integer, ByVal PAC_fechaingreso As Date, ByVal PAC_tipopaciente As String, ByVal PAC_tipodialisis As String, ByVal Turnodialisis_id As Integer, ByVal PAC_turnoasignado As String, ByVal PAC_chofer As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_ape", PAC_ape))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_nombre", PAC_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_dni", PAC_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_fnac", PAC_fnac))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_sexo", PAC_sexo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Obrasocial_id", Obrasocial_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_numafi", PAC_numafi))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_tel", PAC_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAc_dir", PAc_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_CP", PAC_CP))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_Id_Prov", PAC_Id_Prov))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_Id_Loc", PAC_Id_Loc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_mail", PAC_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_estado", PAC_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Estadocivil_id", Estadocivil_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_fechaingreso", PAC_fechaingreso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_tipopaciente", PAC_tipopaciente))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_tipodialisis", PAC_tipodialisis))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Turnodialisis_id", Turnodialisis_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_turnoasignado", PAC_turnoasignado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_chofer", PAC_chofer))




        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Paciente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Paciente_Modificar(ByVal PAC_id As Integer, ByVal PAC_ape As String, ByVal PAC_nombre As String, ByVal PAC_dni As String, ByVal PAC_fnac As Date, ByVal PAC_sexo As String, ByVal Obrasocial_id As Integer,
                                  ByVal PAC_numafi As String, ByVal PAC_tel As String, ByVal PAc_dir As String, ByVal PAC_CP As Integer, ByVal PAC_Id_Prov As Integer, ByVal PAC_Id_Loc As Integer,
ByVal PAC_mail As String, ByVal PAC_estado As String, ByVal Estadocivil_id As Integer, ByVal PAC_fechaingreso As Date, ByVal PAC_tipopaciente As String, ByVal PAC_tipodialisis As String, ByVal Turnodialisis_id As Integer, ByVal PAC_turnoasignado As String, ByVal PAC_chofer As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_ape", PAC_ape))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_nombre", PAC_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_dni", PAC_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_fnac", PAC_fnac))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_sexo", PAC_sexo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Obrasocial_id", Obrasocial_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_numafi", PAC_numafi))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_tel", PAC_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAc_dir", PAc_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_CP", PAC_CP))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_Id_Prov", PAC_Id_Prov))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_Id_Loc", PAC_Id_Loc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_mail", PAC_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_estado", PAC_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Estadocivil_id", Estadocivil_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_fechaingreso", PAC_fechaingreso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_tipopaciente", PAC_tipopaciente))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_tipodialisis", PAC_tipodialisis))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Turnodialisis_id", Turnodialisis_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_turnoasignado", PAC_turnoasignado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_chofer", PAC_chofer))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Paciente")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Paciente_obtener_activos() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_obtener_activos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Paciente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Paciente_obtener_inactivos() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_obtener_inactivos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Paciente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Paciente_VerificarDni(ByVal PAC_dni As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_VerificarDni", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_dni", PAC_dni))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Paciente")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Paciente_obtener_info(ByVal PAC_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_obtener_info", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function

#Region "reporte"

    Public Function Paciente_x_obra_social(ByVal obrasocial_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_x_obra_social", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@obrasocial_id", obrasocial_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Paciente_x_obra_social_x_rango(ByVal obrasocial_id As Integer, ByVal fecha_desde As Date, ByVal fecha_hasta As Date) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_x_obra_social_x_rango", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@obrasocial_id", obrasocial_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_desde", fecha_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_hasta", fecha_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Paciente_todos_reporte() As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_todos_reporte", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@obrasocial_id", obrasocial_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Paciente")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Paciente_todos_reporte_x_rango(ByVal fecha_desde As Date, ByVal fecha_hasta As Date) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Paciente_todos_reporte_x_rango", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_desde", fecha_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_hasta", fecha_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Paciente")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region


End Class
