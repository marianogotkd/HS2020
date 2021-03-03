Public Class msj_esperar_b

    Dim DAmedico As New Datos.Medico
    Dim ds As DataSet = DAmedico.Medicos_Obtener
    Dim DAcliente As New Datos.Cliente
    Dim DAventa As New Datos.Venta
    Dim ds_reporte_historial As New Ds_reporte_historial
    Dim ds_historiaC As DataSet
    Dim DAHistoria As New Datos.Historia_Clinica
    Public cliente_id As Integer = 0
    Dim DApaciente As New Datos.Paciente
    Private Sub choco()
        ds_reporte_historial.Tables("Cliente").Rows.Clear()
        'primero recupero toda la info del cliente/paciente

        Dim ds_clie As DataSet = DApaciente.Paciente_obtener_info(cliente_id)
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            'existe cargo en dataset para informe crystal
            Dim fila As DataRow = ds_reporte_historial.Tables("Cliente").NewRow
            fila("CLI_id") = ds_clie.Tables(0).Rows(0).Item("PAC_id")
            fila("CLI_ape") = ds_clie.Tables(0).Rows(0).Item("PAC_ape")
            fila("CLI_nom") = ds_clie.Tables(0).Rows(0).Item("PAC_nom")
            fila("CLI_dni") = ds_clie.Tables(0).Rows(0).Item("PAC_dni")
            fila("CLI_fnac") = ds_clie.Tables(0).Rows(0).Item("PAC_fnac")
            fila("CLI_sexo") = ds_clie.Tables(0).Rows(0).Item("PAC_sexo")
            fila("CLI_obrasoc") = ds_clie.Tables(0).Rows(0).Item("obrasocial_nombre")
            fila("CLI_tel") = ds_clie.Tables(0).Rows(0).Item("PAC_tel")
            fila("CLI_dir") = ds_clie.Tables(0).Rows(0).Item("PAC_dir")
            fila("CLI_CP") = ds_clie.Tables(0).Rows(0).Item("PAC_CP")
            fila("provincia") = ds_clie.Tables(0).Rows(0).Item("provincia")
            fila("localidad") = ds_clie.Tables(0).Rows(0).Item("Localidad")
            fila("CLI_numafi") = ds_clie.Tables(0).Rows(0).Item("PACnumafi")
            fila("CLI_mail") = ds_clie.Tables(0).Rows(0).Item("PAC_mail")
            fila("Estadocivil") = ds_clie.Tables(0).Rows(0).Item("Estadocivil_descripcion")
            fila("PAC_fechaingreso") = ds_clie.Tables(0).Rows(0).Item("PAC_fechaingreso")
            fila("PAC_tipopaciente") = ds_clie.Tables(0).Rows(0).Item("PAC_tipopaciente")
            fila("PAC_tipodialisis") = ds_clie.Tables(0).Rows(0).Item("PAC_tipodialisis")

            ds_reporte_historial.Tables("Cliente").Rows.Add(fila)
        End If


        'carga tabla empresa
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            ds_reporte_historial.Tables("Empresa").Rows.Clear()
            ds_reporte_historial.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If


        ds_historiaC = DAHistoria.Consulta_Obtener_Todos_Estudios_x_PAC(cliente_id)

        'HISTORIA CLINICA -/////////////////////////////////////////////////////////// 
        ds_reporte_historial.Tables("Evaluacion_Medica").Rows.Clear()
        If ds_historiaC.Tables("HistoriaC").Rows.Count <> 0 Then
            'Historia_Clinica.Tables("Consulta_antecedentes").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            'Historia_Clinica.Tables("Consulta_antecedentes").Merge(ds_historiaC.Tables("HistoriaC"))
            Dim evaluacion As DataRow = ds_reporte_historial.Tables("Evaluacion_Medica").NewRow
            evaluacion("ConAnt_enferAct") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_enferAct"))
            evaluacion("ConAnt_patologico") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_patologico"))
            evaluacion("ConAnt_familiares") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_familiares"))
            evaluacion("ConAnt_fisico") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_fisico"))
            evaluacion("ConAnt_Diag") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_Diag"))
            evaluacion("ConAnt_estudios") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_estudios"))
            evaluacion("CLI_id") = cliente_id
            evaluacion("ConAnt_motivo_consulta") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_motivo_consulta").ToString)
            ds_reporte_historial.Tables("Evaluacion_Medica").Rows.Add(evaluacion)
        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////

        'ACCESO VASCULAR -///////////////////////////////////////////////////////////
        ds_reporte_historial.Tables("Accesovascular").Rows.Clear()
        If ds_historiaC.Tables("HistoriaC5").Rows.Count <> 0 Then
            Dim accesovasculas As DataRow = ds_reporte_historial.Tables("Accesovascular").NewRow
            Dim i As Integer = ds_historiaC.Tables("HistoriaC5").Rows.Count - 1
            accesovasculas("AV_id") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_id")
            accesovasculas("AV_titulo") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_titulo")
            accesovasculas("AV_fecha") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_fecha")
            accesovasculas("medico_id") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("medico_id")
            accesovasculas("PAC_id") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("PAC_id")
            accesovasculas("AV_tipo") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_tipo")
            accesovasculas("AV_fechaC") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_fechaC")
            accesovasculas("AV_fechaPu") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_fechaPu")
            accesovasculas("AV_ubicacion") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_ubicacion")
            accesovasculas("AV_obs") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_obs")
            accesovasculas("medico_nombre") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("medico_nombre")
            accesovasculas("medico_matricula") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("medico_matricula")
            ds_reporte_historial.Tables("Accesovascular").Rows.Add(accesovasculas)
        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////
        'EVOLUCION, SON VARIAS
        ds_reporte_historial.Tables("Consulta_Clinica").Rows.Clear()
        If ds_historiaC.Tables(1).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(1).Rows.Count
                Dim consultamedica As DataRow = ds_reporte_historial.Tables("Consulta_Clinica").NewRow
                consultamedica("conmed_id") = ds_historiaC.Tables(1).Rows(i).Item("conmed_id")
                consultamedica("conmed_fecha") = ds_historiaC.Tables(1).Rows(i).Item("conmed_fecha")
                consultamedica("conmed_titulo") = ds_historiaC.Tables(1).Rows(i).Item("conmed_titulo")
                consultamedica("conmed_evaluacion") = ds_historiaC.Tables(1).Rows(i).Item("conmed_evaluacion")
                consultamedica("conmed_motivo") = ds_historiaC.Tables(1).Rows(i).Item("conmed_motivo")
                consultamedica("conmed_medicacion") = ds_historiaC.Tables(1).Rows(i).Item("conmed_medicacion")
                consultamedica("conmed_estudios") = ds_historiaC.Tables(1).Rows(i).Item("conmed_estudios")
                consultamedica("medico_id") = ds_historiaC.Tables(1).Rows(i).Item("medico_id")
                'tengo que recuperar el medico
                Dim medico_id As Integer = ds_historiaC.Tables(1).Rows(i).Item("medico_id")
                Dim j As Integer = 0
                While j < ds.Tables(0).Rows.Count
                    If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
                        consultamedica("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
                        consultamedica("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
                        Exit While
                    End If
                    j = j + 1
                End While
                consultamedica("conmed_acceso") = ds_historiaC.Tables(1).Rows(i).Item("conmed_acceso")
                consultamedica("CLI_id") = cliente_id
                ds_reporte_historial.Tables("Consulta_Clinica").Rows.Add(consultamedica)

                i = i + 1
            End While
        End If

        '///////////////////////////////////////////////////////////////////////////////////////
        'CONSULTA PSICOLOGICA
        ds_reporte_historial.Tables("Consulta_Psicologica").Rows.Clear()
        If ds_historiaC.Tables(2).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(2).Rows.Count
                Dim consultapsicologica As DataRow = ds_reporte_historial.Tables("Consulta_Psicologica").NewRow
                consultapsicologica("psico_id") = ds_historiaC.Tables(2).Rows(i).Item("psico_id")
                consultapsicologica("psico_titulo") = ds_historiaC.Tables(2).Rows(i).Item("psico_titulo")
                consultapsicologica("psico_fecha") = ds_historiaC.Tables(2).Rows(i).Item("psico_fecha")
                consultapsicologica("psico_motivo") = ds_historiaC.Tables(2).Rows(i).Item("psico_motivo")
                consultapsicologica("psico_evaluacion") = ds_historiaC.Tables(2).Rows(i).Item("psico_evaluacion")
                consultapsicologica("psico_estudios") = ds_historiaC.Tables(2).Rows(i).Item("psico_estudios")
                consultapsicologica("psico_medicacion") = ds_historiaC.Tables(2).Rows(i).Item("psico_medicacion")
                consultapsicologica("CLI_id") = ds_historiaC.Tables(2).Rows(i).Item("CLI_id")
                consultapsicologica("medico_id") = ds_historiaC.Tables(2).Rows(i).Item("medico_id")
                'tengo que recuperar el medico
                Dim medico_id As Integer = ds_historiaC.Tables(2).Rows(i).Item("medico_id")
                Dim j As Integer = 0
                While j < ds.Tables(0).Rows.Count
                    If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
                        consultapsicologica("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
                        consultapsicologica("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
                        Exit While
                    End If
                    j = j + 1
                End While
                ds_reporte_historial.Tables("Consulta_Psicologica").Rows.Add(consultapsicologica)
                i = i + 1
            End While
        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////////
        'ASISTENCIA SOCIAL
        ds_reporte_historial.Tables("Asistencia_Social").Rows.Clear()
        If ds_historiaC.Tables(3).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(3).Rows.Count
                Dim asistenciasocial As DataRow = ds_reporte_historial.Tables("Asistencia_Social").NewRow
                asistenciasocial("social_id") = ds_historiaC.Tables(3).Rows(i).Item("social_id")
                asistenciasocial("social_titulo") = ds_historiaC.Tables(3).Rows(i).Item("social_titulo")
                asistenciasocial("social_fecha") = ds_historiaC.Tables(3).Rows(i).Item("social_fecha")
                asistenciasocial("social_motivo") = ds_historiaC.Tables(3).Rows(i).Item("social_motivo")
                asistenciasocial("social_evaluacion") = ds_historiaC.Tables(3).Rows(i).Item("social_evaluacion")
                asistenciasocial("CLI_id") = ds_historiaC.Tables(3).Rows(i).Item("CLI_id")
                asistenciasocial("medico_id") = ds_historiaC.Tables(3).Rows(i).Item("medico_id")

                'tengo que recuperar el medico
                Dim medico_id As Integer = ds_historiaC.Tables(3).Rows(i).Item("medico_id")
                Dim j As Integer = 0
                While j < ds.Tables(0).Rows.Count
                    If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
                        asistenciasocial("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
                        asistenciasocial("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
                        Exit While
                    End If
                    j = j + 1
                End While
                ds_reporte_historial.Tables("Asistencia_Social").Rows.Add(asistenciasocial)
                i = i + 1
            End While
        End If

        '/////////////////////////////////////////////////////////////////////
        'CONSULTA NUTRICIONAL
        ds_reporte_historial.Tables("Consulta_Nutricional").Rows.Clear()
        If ds_historiaC.Tables(4).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(4).Rows.Count
                Dim nutricional As DataRow = ds_reporte_historial.Tables("Consulta_Nutricional").NewRow
                nutricional("nutri_id") = ds_historiaC.Tables(4).Rows(i).Item("nutri_id")
                nutricional("nutri_titulo") = ds_historiaC.Tables(4).Rows(i).Item("nutri_titulo")
                nutricional("nutri_fecha") = ds_historiaC.Tables(4).Rows(i).Item("nutri_fecha")
                nutricional("nutri_motivo") = ds_historiaC.Tables(4).Rows(i).Item("nutri_motivo")
                nutricional("nutri_evaluacion") = ds_historiaC.Tables(4).Rows(i).Item("nutri_evaluacion")
                nutricional("nutri_estudios") = ds_historiaC.Tables(4).Rows(i).Item("nutri_estudios")
                nutricional("CLI_id") = ds_historiaC.Tables(4).Rows(i).Item("CLI_id")
                nutricional("medico_id") = ds_historiaC.Tables(4).Rows(i).Item("medico_id")

                'tengo que recuperar el medico
                Dim medico_id As Integer = ds_historiaC.Tables(4).Rows(i).Item("medico_id")
                Dim j As Integer = 0
                While j < ds.Tables(0).Rows.Count
                    If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
                        nutricional("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
                        nutricional("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
                        Exit While
                    End If
                    j = j + 1
                End While
                ds_reporte_historial.Tables("Consulta_Nutricional").Rows.Add(nutricional)
                i = i + 1
            End While
        End If

        '//////////////////////////////////////////////////////////////////////
        'CONSULTA TRASPLANTE
        ds_reporte_historial.Tables("consulta_trasplante").Rows.Clear()
        If ds_historiaC.Tables(6).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(6).Rows.Count
                Dim trasplante As DataRow = ds_reporte_historial.Tables("consulta_trasplante").NewRow
                trasplante("Tras_id") = ds_historiaC.Tables(6).Rows(i).Item("Tras_id")
                trasplante("Tras_Titulo") = ds_historiaC.Tables(6).Rows(i).Item("Tras_Titulo")
                trasplante("Tras_fecha") = ds_historiaC.Tables(6).Rows(i).Item("Tras_fecha")
                trasplante("medico_id") = ds_historiaC.Tables(6).Rows(i).Item("medico_id")
                trasplante("PAC_id") = ds_historiaC.Tables(6).Rows(i).Item("PAC_id")
                trasplante("Tras_FechaI_LE") = ds_historiaC.Tables(6).Rows(i).Item("Tras_FechaI_LE")
                trasplante("Tras_evo") = ds_historiaC.Tables(6).Rows(i).Item("Tras_evo")
                trasplante("Tras_Estudios") = ds_historiaC.Tables(6).Rows(i).Item("Tras_Estudios")
                trasplante("Tras_Centro") = ds_historiaC.Tables(6).Rows(i).Item("Tras_Centro")
                trasplante("medico_nombre") = ds_historiaC.Tables(6).Rows(i).Item("medico_nombre")
                trasplante("medico_matricula") = ds_historiaC.Tables(6).Rows(i).Item("medico_matricula")
                ds_reporte_historial.Tables("consulta_trasplante").Rows.Add(trasplante)
                i = i + 1
            End While
        End If

        '/////////////////////////configuracion para mostrar los resultados/////////////////////

        ds_reporte_historial.Tables("configuracion").Rows.Clear() 'siempre borro para q no me de error.

        Dim config_fila As DataRow = ds_reporte_historial.Tables("configuracion").NewRow


        If ds_historiaC.Tables(1).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_consultaclinica.Checked = True Then
                config_fila("cons_cli") = "tengo info"
            Else
                config_fila("cons_cli") = ""
            End If

        Else
            config_fila("cons_cli") = ""
        End If

        If ds_historiaC.Tables(2).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_consultapsicologica.Checked = True Then
                config_fila("cons_psico") = "tengo info"
            Else
                config_fila("cons_psico") = ""
            End If

        Else
            config_fila("cons_psico") = ""
        End If

        If ds_historiaC.Tables(3).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_asistenciasocial.Checked = True Then
                config_fila("asis_soc") = "tengo info"
            Else
                config_fila("asis_soc") = ""
            End If
        Else
            config_fila("asis_soc") = ""
        End If

        If ds_historiaC.Tables(4).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_consultanutricional.Checked = True Then
                config_fila("cons_nutr") = "tengo info"
            Else
                config_fila("cons_nutr") = ""
            End If
        Else
            config_fila("cons_nutr") = ""
        End If

        If ds_historiaC.Tables(5).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_accesovascular.Checked = True Then
                config_fila("acceso_vascular") = "tengo info"
            Else
                config_fila("acceso_vascular") = ""
            End If
        Else
            config_fila("acceso_vascular") = ""
        End If


        If ds_historiaC.Tables(6).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_trasplante.Checked = True Then
                config_fila("cons_trasplante") = "tengo info"
            Else
                config_fila("cons_trasplante") = ""
            End If
        Else
            config_fila("cons_trasplante") = ""
        End If

        If ds_historiaC.Tables(0).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_evaluacionmedica.Checked = True Then
                config_fila("eva_medica") = "tengo info"
            Else
                config_fila("eva_medica") = ""
            End If
        Else
            config_fila("eva_medica") = ""
        End If

        ds_reporte_historial.Tables("configuracion").Rows.Add(config_fila)

        'ahora creo el reporte
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\EvaluacionMedica_CR.rpt")
        'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
        CrReport.Database.Tables("Empresa").SetDataSource(ds_reporte_historial.Tables("Empresa"))
        CrReport.Database.Tables("Cliente").SetDataSource(ds_reporte_historial.Tables("Cliente"))
        'la tabla "evaluacion medica" esta en el subinforme
        CrReport.Database.Tables("Evaluacion_Medica").SetDataSource(ds_reporte_historial.Tables("Evaluacion_Medica"))
        CrReport.Database.Tables("Consulta_Clinica").SetDataSource(ds_reporte_historial.Tables("Consulta_Clinica"))
        CrReport.Database.Tables("Consulta_Psicologica").SetDataSource(ds_reporte_historial.Tables("Consulta_Psicologica"))
        CrReport.Database.Tables("Asistencia_Social").SetDataSource(ds_reporte_historial.Tables("Asistencia_Social"))
        CrReport.Database.Tables("Consulta_Nutricional").SetDataSource(ds_reporte_historial.Tables("Consulta_Nutricional"))
        CrReport.Database.Tables("configuracion").SetDataSource(ds_reporte_historial.Tables("configuracion"))
        CrReport.Database.Tables("Accesovascular").SetDataSource(ds_reporte_historial.Tables("Accesovascular"))
        CrReport.Database.Tables("consulta_trasplante").SetDataSource(ds_reporte_historial.Tables("consulta_trasplante"))


        'usando la variable visor puedo abrir varios reportes, sin temor a q se junte los datos del dataset
        Dim visor As New EvaluacionMedica_show
        visor.CrystalReportViewer1.ReportSource = CrReport

        visor.Text = "Historia Clínica. Paciente: " + Informe_seleccionar.TextBox1.Text + " - Imprimir."
        visor.Show()

        Informe_seleccionar.Close()
        Me.Close()
    End Sub
    Public procedencia As String = "historiaclinica"

    Private Sub historia_clinica_rangofecha()
        ds_reporte_historial.Tables("Cliente").Rows.Clear()
        'primero recupero toda la info del cliente/paciente

        Dim ds_clie As DataSet = DApaciente.Paciente_obtener_info(cliente_id)
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            'existe cargo en dataset para informe crystal
            Dim fila As DataRow = ds_reporte_historial.Tables("Cliente").NewRow
            fila("CLI_id") = ds_clie.Tables(0).Rows(0).Item("PAC_id")
            fila("CLI_ape") = ds_clie.Tables(0).Rows(0).Item("PAC_ape")
            fila("CLI_nom") = ds_clie.Tables(0).Rows(0).Item("PAC_nom")
            fila("CLI_dni") = ds_clie.Tables(0).Rows(0).Item("PAC_dni")
            fila("CLI_fnac") = ds_clie.Tables(0).Rows(0).Item("PAC_fnac")
            fila("CLI_sexo") = ds_clie.Tables(0).Rows(0).Item("PAC_sexo")
            fila("CLI_obrasoc") = ds_clie.Tables(0).Rows(0).Item("obrasocial_nombre")
            fila("CLI_tel") = ds_clie.Tables(0).Rows(0).Item("PAC_tel")
            fila("CLI_dir") = ds_clie.Tables(0).Rows(0).Item("PAC_dir")
            fila("CLI_CP") = ds_clie.Tables(0).Rows(0).Item("PAC_CP")
            fila("provincia") = ds_clie.Tables(0).Rows(0).Item("provincia")
            fila("localidad") = ds_clie.Tables(0).Rows(0).Item("Localidad")
            fila("CLI_numafi") = ds_clie.Tables(0).Rows(0).Item("PACnumafi")
            fila("CLI_mail") = ds_clie.Tables(0).Rows(0).Item("PAC_mail")
            fila("Estadocivil") = ds_clie.Tables(0).Rows(0).Item("Estadocivil_descripcion")
            fila("PAC_fechaingreso") = ds_clie.Tables(0).Rows(0).Item("PAC_fechaingreso")
            fila("PAC_tipopaciente") = ds_clie.Tables(0).Rows(0).Item("PAC_tipopaciente")
            fila("PAC_tipodialisis") = ds_clie.Tables(0).Rows(0).Item("PAC_tipodialisis")

            ds_reporte_historial.Tables("Cliente").Rows.Add(fila)
        End If


        'carga tabla empresa
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            ds_reporte_historial.Tables("Empresa").Rows.Clear()
            ds_reporte_historial.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If


        ds_historiaC = DAHistoria.Consulta_Obtener_Todos_Estudios_x_PAC_rangofechas(cliente_id, Informe_seleccionar.DateTimePicker_desde.Value.Date, Informe_seleccionar.DateTimePicker_hasta.Value.Date)

        'HISTORIA CLINICA -/////////////////////////////////////////////////////////// 
        ds_reporte_historial.Tables("Evaluacion_Medica").Rows.Clear()
        If ds_historiaC.Tables("HistoriaC").Rows.Count <> 0 Then
            'Historia_Clinica.Tables("Consulta_antecedentes").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            'Historia_Clinica.Tables("Consulta_antecedentes").Merge(ds_historiaC.Tables("HistoriaC"))
            Dim evaluacion As DataRow = ds_reporte_historial.Tables("Evaluacion_Medica").NewRow
            evaluacion("ConAnt_enferAct") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_enferAct"))
            evaluacion("ConAnt_patologico") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_patologico"))
            evaluacion("ConAnt_familiares") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_familiares"))
            evaluacion("ConAnt_fisico") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_fisico"))
            evaluacion("ConAnt_Diag") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_Diag"))
            evaluacion("ConAnt_estudios") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_estudios"))
            evaluacion("CLI_id") = cliente_id
            evaluacion("ConAnt_motivo_consulta") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_motivo_consulta"))
            ds_reporte_historial.Tables("Evaluacion_Medica").Rows.Add(evaluacion)
        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////

        'ACCESO VASCULAR -///////////////////////////////////////////////////////////
        ds_reporte_historial.Tables("Accesovascular").Rows.Clear()
        If ds_historiaC.Tables("HistoriaC5").Rows.Count <> 0 Then
            Dim accesovasculas As DataRow = ds_reporte_historial.Tables("Accesovascular").NewRow
            Dim i As Integer = ds_historiaC.Tables("HistoriaC5").Rows.Count - 1
            accesovasculas("AV_id") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_id")
            accesovasculas("AV_titulo") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_titulo")
            accesovasculas("AV_fecha") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_fecha")
            accesovasculas("medico_id") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("medico_id")
            accesovasculas("PAC_id") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("PAC_id")
            accesovasculas("AV_tipo") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_tipo")
            accesovasculas("AV_fechaC") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_fechaC")
            accesovasculas("AV_fechaPu") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_fechaPu")
            accesovasculas("AV_ubicacion") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_ubicacion")
            accesovasculas("AV_obs") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("AV_obs")
            accesovasculas("medico_nombre") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("medico_nombre")
            accesovasculas("medico_matricula") = ds_historiaC.Tables("HistoriaC5").Rows(i).Item("medico_matricula")
            ds_reporte_historial.Tables("Accesovascular").Rows.Add(accesovasculas)
        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////
        'EVOLUCION, SON VARIAS
        ds_reporte_historial.Tables("Consulta_Clinica").Rows.Clear()
        If ds_historiaC.Tables(1).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(1).Rows.Count
                Dim consultamedica As DataRow = ds_reporte_historial.Tables("Consulta_Clinica").NewRow
                consultamedica("conmed_id") = ds_historiaC.Tables(1).Rows(i).Item("conmed_id")
                consultamedica("conmed_fecha") = ds_historiaC.Tables(1).Rows(i).Item("conmed_fecha")
                consultamedica("conmed_titulo") = ds_historiaC.Tables(1).Rows(i).Item("conmed_titulo")
                consultamedica("conmed_evaluacion") = ds_historiaC.Tables(1).Rows(i).Item("conmed_evaluacion")
                consultamedica("conmed_motivo") = ds_historiaC.Tables(1).Rows(i).Item("conmed_motivo")
                consultamedica("conmed_medicacion") = ds_historiaC.Tables(1).Rows(i).Item("conmed_medicacion")
                consultamedica("conmed_estudios") = ds_historiaC.Tables(1).Rows(i).Item("conmed_estudios")
                consultamedica("medico_id") = ds_historiaC.Tables(1).Rows(i).Item("medico_id")
                'tengo que recuperar el medico
                Dim medico_id As Integer = ds_historiaC.Tables(1).Rows(i).Item("medico_id")
                Dim j As Integer = 0
                While j < ds.Tables(0).Rows.Count
                    If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
                        consultamedica("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
                        consultamedica("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
                        Exit While
                    End If
                    j = j + 1
                End While
                consultamedica("conmed_acceso") = ds_historiaC.Tables(1).Rows(i).Item("conmed_acceso")
                consultamedica("CLI_id") = cliente_id
                ds_reporte_historial.Tables("Consulta_Clinica").Rows.Add(consultamedica)

                i = i + 1
            End While
        End If

        '///////////////////////////////////////////////////////////////////////////////////////
        'CONSULTA PSICOLOGICA
        ds_reporte_historial.Tables("Consulta_Psicologica").Rows.Clear()
        If ds_historiaC.Tables(2).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(2).Rows.Count
                Dim consultapsicologica As DataRow = ds_reporte_historial.Tables("Consulta_Psicologica").NewRow
                consultapsicologica("psico_id") = ds_historiaC.Tables(2).Rows(i).Item("psico_id")
                consultapsicologica("psico_titulo") = ds_historiaC.Tables(2).Rows(i).Item("psico_titulo")
                consultapsicologica("psico_fecha") = ds_historiaC.Tables(2).Rows(i).Item("psico_fecha")
                consultapsicologica("psico_motivo") = ds_historiaC.Tables(2).Rows(i).Item("psico_motivo")
                consultapsicologica("psico_evaluacion") = ds_historiaC.Tables(2).Rows(i).Item("psico_evaluacion")
                consultapsicologica("psico_estudios") = ds_historiaC.Tables(2).Rows(i).Item("psico_estudios")
                consultapsicologica("psico_medicacion") = ds_historiaC.Tables(2).Rows(i).Item("psico_medicacion")
                consultapsicologica("CLI_id") = ds_historiaC.Tables(2).Rows(i).Item("CLI_id")
                consultapsicologica("medico_id") = ds_historiaC.Tables(2).Rows(i).Item("medico_id")
                'tengo que recuperar el medico
                Dim medico_id As Integer = ds_historiaC.Tables(2).Rows(i).Item("medico_id")
                Dim j As Integer = 0
                While j < ds.Tables(0).Rows.Count
                    If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
                        consultapsicologica("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
                        consultapsicologica("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
                        Exit While
                    End If
                    j = j + 1
                End While
                ds_reporte_historial.Tables("Consulta_Psicologica").Rows.Add(consultapsicologica)
                i = i + 1
            End While
        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////////
        'ASISTENCIA SOCIAL
        ds_reporte_historial.Tables("Asistencia_Social").Rows.Clear()
        If ds_historiaC.Tables(3).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(3).Rows.Count
                Dim asistenciasocial As DataRow = ds_reporte_historial.Tables("Asistencia_Social").NewRow
                asistenciasocial("social_id") = ds_historiaC.Tables(3).Rows(i).Item("social_id")
                asistenciasocial("social_titulo") = ds_historiaC.Tables(3).Rows(i).Item("social_titulo")
                asistenciasocial("social_fecha") = ds_historiaC.Tables(3).Rows(i).Item("social_fecha")
                asistenciasocial("social_motivo") = ds_historiaC.Tables(3).Rows(i).Item("social_motivo")
                asistenciasocial("social_evaluacion") = ds_historiaC.Tables(3).Rows(i).Item("social_evaluacion")
                asistenciasocial("CLI_id") = ds_historiaC.Tables(3).Rows(i).Item("CLI_id")
                asistenciasocial("medico_id") = ds_historiaC.Tables(3).Rows(i).Item("medico_id")

                'tengo que recuperar el medico
                Dim medico_id As Integer = ds_historiaC.Tables(3).Rows(i).Item("medico_id")
                Dim j As Integer = 0
                While j < ds.Tables(0).Rows.Count
                    If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
                        asistenciasocial("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
                        asistenciasocial("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
                        Exit While
                    End If
                    j = j + 1
                End While
                ds_reporte_historial.Tables("Asistencia_Social").Rows.Add(asistenciasocial)
                i = i + 1
            End While
        End If

        '/////////////////////////////////////////////////////////////////////
        'CONSULTA NUTRICIONAL
        ds_reporte_historial.Tables("Consulta_Nutricional").Rows.Clear()
        If ds_historiaC.Tables(4).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(4).Rows.Count
                Dim nutricional As DataRow = ds_reporte_historial.Tables("Consulta_Nutricional").NewRow
                nutricional("nutri_id") = ds_historiaC.Tables(4).Rows(i).Item("nutri_id")
                nutricional("nutri_titulo") = ds_historiaC.Tables(4).Rows(i).Item("nutri_titulo")
                nutricional("nutri_fecha") = ds_historiaC.Tables(4).Rows(i).Item("nutri_fecha")
                nutricional("nutri_motivo") = ds_historiaC.Tables(4).Rows(i).Item("nutri_motivo")
                nutricional("nutri_evaluacion") = ds_historiaC.Tables(4).Rows(i).Item("nutri_evaluacion")
                nutricional("nutri_estudios") = ds_historiaC.Tables(4).Rows(i).Item("nutri_estudios")
                nutricional("CLI_id") = ds_historiaC.Tables(4).Rows(i).Item("CLI_id")
                nutricional("medico_id") = ds_historiaC.Tables(4).Rows(i).Item("medico_id")

                'tengo que recuperar el medico
                Dim medico_id As Integer = ds_historiaC.Tables(4).Rows(i).Item("medico_id")
                Dim j As Integer = 0
                While j < ds.Tables(0).Rows.Count
                    If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
                        nutricional("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
                        nutricional("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
                        Exit While
                    End If
                    j = j + 1
                End While
                ds_reporte_historial.Tables("Consulta_Nutricional").Rows.Add(nutricional)
                i = i + 1
            End While
        End If

        '//////////////////////////////////////////////////////////////////////
        'CONSULTA TRASPLANTE
        ds_reporte_historial.Tables("consulta_trasplante").Rows.Clear()
        If ds_historiaC.Tables(6).Rows.Count <> 0 Then
            'ahora lo recorro y cargo el ds
            Dim i As Integer = 0
            While i < ds_historiaC.Tables(6).Rows.Count
                Dim trasplante As DataRow = ds_reporte_historial.Tables("consulta_trasplante").NewRow
                trasplante("Tras_id") = ds_historiaC.Tables(6).Rows(i).Item("Tras_id")
                trasplante("Tras_Titulo") = ds_historiaC.Tables(6).Rows(i).Item("Tras_Titulo")
                trasplante("Tras_fecha") = ds_historiaC.Tables(6).Rows(i).Item("Tras_fecha")
                trasplante("medico_id") = ds_historiaC.Tables(6).Rows(i).Item("medico_id")
                trasplante("PAC_id") = ds_historiaC.Tables(6).Rows(i).Item("PAC_id")
                trasplante("Tras_FechaI_LE") = ds_historiaC.Tables(6).Rows(i).Item("Tras_FechaI_LE")
                trasplante("Tras_evo") = ds_historiaC.Tables(6).Rows(i).Item("Tras_evo")
                trasplante("Tras_Estudios") = ds_historiaC.Tables(6).Rows(i).Item("Tras_Estudios")
                trasplante("Tras_Centro") = ds_historiaC.Tables(6).Rows(i).Item("Tras_Centro")
                trasplante("medico_nombre") = ds_historiaC.Tables(6).Rows(i).Item("medico_nombre")
                trasplante("medico_matricula") = ds_historiaC.Tables(6).Rows(i).Item("medico_matricula")
                ds_reporte_historial.Tables("consulta_trasplante").Rows.Add(trasplante)
                i = i + 1
            End While
        End If

        '/////////////////////////configuracion para mostrar los resultados/////////////////////

        ds_reporte_historial.Tables("configuracion").Rows.Clear() 'siempre borro para q no me de error.

        Dim config_fila As DataRow = ds_reporte_historial.Tables("configuracion").NewRow


        If ds_historiaC.Tables(1).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_consultaclinica.Checked = True Then
                config_fila("cons_cli") = "tengo info"
            Else
                config_fila("cons_cli") = ""
            End If

        Else
            config_fila("cons_cli") = ""
        End If

        If ds_historiaC.Tables(2).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_consultapsicologica.Checked = True Then
                config_fila("cons_psico") = "tengo info"
            Else
                config_fila("cons_psico") = ""
            End If

        Else
            config_fila("cons_psico") = ""
        End If

        If ds_historiaC.Tables(3).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_asistenciasocial.Checked = True Then
                config_fila("asis_soc") = "tengo info"
            Else
                config_fila("asis_soc") = ""
            End If
        Else
            config_fila("asis_soc") = ""
        End If

        If ds_historiaC.Tables(4).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_consultanutricional.Checked = True Then
                config_fila("cons_nutr") = "tengo info"
            Else
                config_fila("cons_nutr") = ""
            End If
        Else
            config_fila("cons_nutr") = ""
        End If

        If ds_historiaC.Tables(5).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_accesovascular.Checked = True Then
                config_fila("acceso_vascular") = "tengo info"
            Else
                config_fila("acceso_vascular") = ""
            End If
        Else
            config_fila("acceso_vascular") = ""
        End If


        If ds_historiaC.Tables(6).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_trasplante.Checked = True Then
                config_fila("cons_trasplante") = "tengo info"
            Else
                config_fila("cons_trasplante") = ""
            End If
        Else
            config_fila("cons_trasplante") = ""
        End If

        If ds_historiaC.Tables(0).Rows.Count <> 0 Then
            If Informe_seleccionar.CheckBox_evaluacionmedica.Checked = True Then
                config_fila("eva_medica") = "tengo info"
            Else
                config_fila("eva_medica") = ""
            End If
        Else
            config_fila("eva_medica") = ""
        End If

        ds_reporte_historial.Tables("configuracion").Rows.Add(config_fila)

        'ahora creo el reporte
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\EvaluacionMedica_CR.rpt")
        'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
        CrReport.Database.Tables("Empresa").SetDataSource(ds_reporte_historial.Tables("Empresa"))
        CrReport.Database.Tables("Cliente").SetDataSource(ds_reporte_historial.Tables("Cliente"))
        'la tabla "evaluacion medica" esta en el subinforme
        CrReport.Database.Tables("Evaluacion_Medica").SetDataSource(ds_reporte_historial.Tables("Evaluacion_Medica"))
        CrReport.Database.Tables("Consulta_Clinica").SetDataSource(ds_reporte_historial.Tables("Consulta_Clinica"))
        CrReport.Database.Tables("Consulta_Psicologica").SetDataSource(ds_reporte_historial.Tables("Consulta_Psicologica"))
        CrReport.Database.Tables("Asistencia_Social").SetDataSource(ds_reporte_historial.Tables("Asistencia_Social"))
        CrReport.Database.Tables("Consulta_Nutricional").SetDataSource(ds_reporte_historial.Tables("Consulta_Nutricional"))
        CrReport.Database.Tables("configuracion").SetDataSource(ds_reporte_historial.Tables("configuracion"))
        CrReport.Database.Tables("Accesovascular").SetDataSource(ds_reporte_historial.Tables("Accesovascular"))
        CrReport.Database.Tables("consulta_trasplante").SetDataSource(ds_reporte_historial.Tables("consulta_trasplante"))


        'usando la variable visor puedo abrir varios reportes, sin temor a q se junte los datos del dataset
        Dim visor As New EvaluacionMedica_show
        visor.CrystalReportViewer1.ReportSource = CrReport

        visor.Text = "Historia Clínica. Paciente: " + Informe_seleccionar.TextBox1.Text + " - Imprimir."
        visor.Show()

        Informe_seleccionar.Close()
        Me.Close()
    End Sub




    Private Sub msj_esperar_a_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label2.Text = ProgressBar1.Value & (" %")
        If ProgressBar1.Value = 70 Then
            If procedencia = "historiaclinica" Then
                choco()
            End If
            If procedencia = "reporte historia clinica rango fecha" Then
                historia_clinica_rangofecha()
            End If

            If procedencia = "movimientos" Then
                Movimientos_consulta.reporte()
                Me.Close()
            End If
            If procedencia = "consumos" Then
                Consumo_reporte_elegir.reporte()
                Me.Close()
            End If
            If procedencia = "Consulta_Alta_a_detalle" Then
                Consulta_Alta_a_detalle.reporte()
                Me.Close()
            End If
            If procedencia = "Consulta_Alta_b" Then
                Consulta_Alta_b.reporte()
                Me.Close()
            End If
            If procedencia = "Consulta_Alta_bb" Then
                Consulta_Alta_b.reporte_2()
                Me.Close()
            End If
            If procedencia = "Pacientes_x_obra_social" Then
                Paciente_reporte_seleccionar.reporte()
                Me.Close()
            End If
            If procedencia = "Paciente_x_obra_social_rango" Then
                Paciente_reporte_seleccionar.reporte_rango()
                Me.Close()
            End If
            If procedencia = "stock_reporte" Then
                Producto_modificar.reporte()
                Me.Close()

            End If
            If procedencia = "reporte_sesiones_x_fecha" Then
                Enfermeria_reporte_fechas.reporte()
                Me.Close()
            End If
            If procedencia = "reporte_sesiones_y_consumos" Then
                Enfermeria_reporte_fechas.reporte_2()
                Me.Close()
            End If
            If procedencia = "Medico_Actualizar" Then
                Medico_Actualizar.reporte()
                Me.Close()
            End If
            If procedencia = "Consultas_Bajas_b" Then
                Consultas_Bajas_b.reporte()
                Me.Close()
            End If
            If procedencia = "Consultas_Bajas_bb" Then
                Consultas_Bajas_b.reporte_2()
                Me.Close()
            End If
            If procedencia = "Consultas_Movimientos_b" Then
                Consultas_Movimientos_b.reporte()
                Me.Close()
            End If
            If procedencia = "Consultas_Movimientos_bb" Then
                Consultas_Movimientos_b.reporte_2()
                Me.Close()
            End If
            If procedencia = "Consumos_consulta_detalle" Then
                Consumos_consulta_detalle.reporte()
                Me.Close()
            End If
        End If
    End Sub
End Class