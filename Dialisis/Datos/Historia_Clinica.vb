Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Historia_Clinica
    Inherits Datos.Conexion
    Public Function Consulta_Trasplante_alta(ByVal Tras_Titulo As String,
                                         ByVal Tras_fecha As Date,
                                         ByVal medico_id As Integer,
                                         ByVal PAC_id As Integer,
                             ByVal Tras_FechaI_LE As Date,
                             ByVal Tras_evo As String,
                             ByVal Tras_Estudios As String,
                             ByVal Tras_Centro As String
                             ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_Trasplante_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_Titulo", Tras_Titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_fecha", Tras_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_FechaI_LE", Tras_FechaI_LE))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_evo", Tras_evo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_Estudios", Tras_Estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_Centro", Tras_Centro))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_Trasplante_Modificar(ByVal Tras_Titulo As String,
                                         ByVal Tras_fecha As Date,
                                         ByVal medico_id As Integer,
                                         ByVal PAC_id As Integer,
                             ByVal Tras_FechaI_LE As Date,
                             ByVal Tras_evo As String,
                             ByVal Tras_Estudios As String,
                             ByVal Tras_Centro As String,
                             ByVal Tras_id As Integer
                             ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_Trasplante_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_Titulo", Tras_Titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_fecha", Tras_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_FechaI_LE", Tras_FechaI_LE))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_evo", Tras_evo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_Estudios", Tras_Estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_Centro", Tras_Centro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Tras_id", Tras_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consulta_AccesoV_modificar(ByVal AV_titulo As String,
                                         ByVal AV_fecha As Date,
                                         ByVal medico_id As Integer,
                                         ByVal PAC_id As Integer,
                             ByVal AV_tipo As String,
                             ByVal AV_fechaC As Date,
                             ByVal AV_fechaPu As Date,
                             ByVal AV_ubicacion As String,
                             ByVal AV_obs As String,
                            ByVal AV_id As Integer
                             ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_AccesoV_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_titulo", AV_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_fecha", AV_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_tipo", AV_tipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_fechaC", AV_fechaC))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_fechaPu", AV_fechaPu))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_ubicacion", AV_ubicacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_obs", AV_obs))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_id", AV_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_AccesoV_alta(ByVal AV_titulo As String,
                                         ByVal AV_fecha As Date,
                                         ByVal medico_id As Integer,
                                         ByVal PAC_id As Integer,
                             ByVal AV_tipo As String,
                             ByVal AV_fechaC As Date,
                             ByVal AV_fechaPu As Date,
                             ByVal AV_ubicacion As String,
                             ByVal AV_obs As String
                             ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_AccesoV_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_titulo", AV_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_fecha", AV_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_tipo", AV_tipo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_fechaC", AV_fechaC))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_fechaPu", AV_fechaPu))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_ubicacion", AV_ubicacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_obs", AV_obs))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_A_Social_alta(ByVal social_fecha As Date,
                              ByVal social_titulo As String,
                              ByVal social_motivo As String,
                              ByVal social_evaluacion As String,
                              ByVal conmed_CLI_id As Integer,
                              ByVal conmed_medico_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_A_Social_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@social_fecha", social_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@social_titulo", social_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@social_motivo", social_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@social_evaluacion", social_evaluacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", conmed_CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", conmed_medico_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consulta_A_Social_Modificar(ByVal social_fecha As Date,
                              ByVal social_titulo As String,
                              ByVal social_motivo As String,
                              ByVal social_evaluacion As String,
                              ByVal CLI_id As Integer,
                              ByVal medico_id As Integer,
                             ByVal social_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_A_Social_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@social_fecha", social_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@social_titulo", social_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@social_motivo", social_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@social_evaluacion", social_evaluacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@social_id", social_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consulta_Medica_alta(ByVal conmed_fecha As Date,
                               ByVal conmed_titulo As String,
                               ByVal conmed_evaluacion As String,
                               ByVal conmed_motivo As String,
                               ByVal conmed_medicacion As String,
                               ByVal conmed_estudios As String,
                               ByVal conmed_acceso As String,
                               ByVal conmed_CLI_id As Integer,
                                ByVal conmed_medico_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_Medica_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_fecha", conmed_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_titulo", conmed_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_evaluacion", conmed_evaluacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_motivo", conmed_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_medicacion", conmed_medicacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_estudios", conmed_estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_acceso", conmed_acceso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", conmed_CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", conmed_medico_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_Medica_Modificar(ByVal conmed_fecha As Date,
                               ByVal conmed_titulo As String,
                               ByVal conmed_evaluacion As String,
                               ByVal conmed_motivo As String,
                               ByVal conmed_medicacion As String,
                               ByVal conmed_estudios As String,
                               ByVal conmed_acceso As String,
                               ByVal conmed_CLI_id As Integer,
                                ByVal conmed_medico_id As Integer,
                                ByVal conmed_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_Medica_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_fecha", conmed_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_titulo", conmed_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_evaluacion", conmed_evaluacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_motivo", conmed_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_medicacion", conmed_medicacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_estudios", conmed_estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_acceso", conmed_acceso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", conmed_CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", conmed_medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@conmed_id", conmed_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consulta_antecedentes_alta(ByVal ConAnt_fecha As Date,
                              ByVal ConAnt_enferAct As String,
                              ByVal ConAnt_patologico As String,
                              ByVal ConAnt_familiares As String,
                              ByVal ConAnt_fisico As String,
                              ByVal ConAnt_Diag As String,
                              ByVal ConAnt_estudios As String,
                              ByVal conmed_CLI_id As Integer,
                               ByVal conmed_medico_id As Integer, ByVal ConAnt_motivo_consulta As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_antecedentes_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_fecha", ConAnt_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_enferAct", ConAnt_enferAct))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_patologico", ConAnt_patologico))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_familiares", ConAnt_familiares))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_fisico", ConAnt_fisico))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_Diag", ConAnt_Diag))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_estudios", ConAnt_estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", conmed_CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", conmed_medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_motivo_consulta", ConAnt_motivo_consulta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_antecedentes_modificar(ByVal ConAnt_id As Integer, ByVal ConAnt_fecha As Date,
                              ByVal ConAnt_enferAct As String,
                              ByVal ConAnt_patologico As String,
                              ByVal ConAnt_familiares As String,
                              ByVal ConAnt_fisico As String,
                              ByVal ConAnt_Diag As String,
                              ByVal ConAnt_estudios As String,
                              ByVal conmed_CLI_id As Integer,
                               ByVal conmed_medico_id As Integer, ByVal ConAnt_motivo_consulta As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_antecedentes_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_id", ConAnt_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_fecha", ConAnt_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_enferAct", ConAnt_enferAct))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_patologico", ConAnt_patologico))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_familiares", ConAnt_familiares))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_fisico", ConAnt_fisico))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_Diag", ConAnt_Diag))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_estudios", ConAnt_estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", conmed_CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", conmed_medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ConAnt_motivo_consulta", ConAnt_motivo_consulta))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_psicológica_alta(ByVal psico_fecha As Date,
                              ByVal psico_titulo As String,
                              ByVal psico_motivo As String,
                              ByVal psico_evaluacion As String,
                              ByVal psico_estudios As String,
                              ByVal psico_medicacion As String,
                              ByVal conmed_CLI_id As Integer,
                               ByVal conmed_medico_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_psicológica_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_fecha", psico_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_titulo", psico_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_motivo", psico_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_evaluacion", psico_evaluacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_estudios", psico_estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_medicacion", psico_medicacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", conmed_CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", conmed_medico_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consulta_psicológica_Modificar(ByVal psico_fecha As Date,
                              ByVal psico_titulo As String,
                              ByVal psico_motivo As String,
                              ByVal psico_evaluacion As String,
                              ByVal psico_estudios As String,
                              ByVal psico_medicacion As String,
                              ByVal conmed_CLI_id As Integer,
                               ByVal conmed_medico_id As Integer,
                               ByVal psico_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_psicológica_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_fecha", psico_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_titulo", psico_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_motivo", psico_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_evaluacion", psico_evaluacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_estudios", psico_estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_medicacion", psico_medicacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", conmed_CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", conmed_medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@psico_id", psico_id))




        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consulta_nutricional_alta(ByVal nutri_fecha As Date,
                              ByVal nutri_titulo As String,
                              ByVal nutri_motivo As String,
                              ByVal nutri_estudios As String,
                              ByVal nutri_evaluacion As String,
                              ByVal conmed_CLI_id As Integer,
                               ByVal conmed_medico_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_nutricional_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_fecha", nutri_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_titulo", nutri_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_motivo", nutri_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_estudios", nutri_estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_evaluacion", nutri_evaluacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", conmed_CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", conmed_medico_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consulta_nutricional_Modificar(ByVal nutri_fecha As Date,
                              ByVal nutri_titulo As String,
                              ByVal nutri_motivo As String,
                              ByVal nutri_estudios As String,
                              ByVal nutri_evaluacion As String,
                              ByVal conmed_CLI_id As Integer,
                               ByVal conmed_medico_id As Integer,
                               ByVal nutri_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_nutricional_Modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_fecha", nutri_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_titulo", nutri_titulo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_motivo", nutri_motivo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_estudios", nutri_estudios))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_evaluacion", nutri_evaluacion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", conmed_CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@medico_id", conmed_medico_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@nutri_id", nutri_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consulta_Obtener_Todos_Estudios() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_Obtener_Todos_Estudios", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Consulta_Obtener_Todos_Estudios_x_PAC(
                              ByVal CLI_id As Integer
                            ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_Obtener_Todos_Estudios_x_PAC", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_Obtener_Todos_Estudios_x_PAC_rangofechas(
                              ByVal CLI_id As Integer, ByVal fecha_desde As Date, ByVal fecha_hasta As Date
                            ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_Obtener_Todos_Estudios_x_PAC_rangofechas", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_desde", fecha_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha_hasta", fecha_hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_antecedentes_validar(
                              ByVal CLI_id As Integer
                            ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_antecedentes_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Consulta_AccesoV_validar(
                              ByVal PAC_id As Integer
                            ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_AccesoV_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "HistoriaC")
        dbconn.Close()
        Return ds_JE
    End Function

    


End Class
