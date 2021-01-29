Public Class Informe_seleccionar
    'Public cliente_id As Integer
    Public paciente_id As Integer
    Dim DAHistoria As New Datos.Historia_Clinica

    Dim ds_historiaC As DataSet
    Private Sub Informe_seleccionar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ds_historiaC = DAHistoria.Consulta_Obtener_Todos_Estudios_x_PAC(paciente_id)

        If ds_historiaC.Tables("HistoriaC").Rows.Count <> 0 Then
            'tengo antecedentes entonces
            CheckBox_evaluacionmedica.Checked = True
        Else
            CheckBox_evaluacionmedica.Checked = False
            CheckBox_evaluacionmedica.Text = "Historia Clínica (no disponible)"
            CheckBox_evaluacionmedica.Enabled = False
        End If

        If ds_historiaC.Tables("HistoriaC2").Rows.Count <> 0 Then
            'tengo consulta psicologica
            CheckBox_consultapsicologica.Checked = True
        Else
            CheckBox_consultapsicologica.Checked = False
            CheckBox_consultapsicologica.Enabled = False
            CheckBox_consultapsicologica.Text = "Consulta Psicológica (no disponible)"

        End If

        If ds_historiaC.Tables("HistoriaC1").Rows.Count <> 0 Then
            'tengo consulta medica
            CheckBox_consultaclinica.Checked = True
        Else
            CheckBox_consultaclinica.Checked = False
            CheckBox_consultaclinica.Enabled = False
            CheckBox_consultaclinica.Text = "Evolución (no disponible)"
        End If

        If ds_historiaC.Tables("HistoriaC3").Rows.Count <> 0 Then
            'tengo asistencia social
            CheckBox_asistenciasocial.Checked = True
        Else
            CheckBox_asistenciasocial.Checked = False
            CheckBox_asistenciasocial.Enabled = False
            CheckBox_asistenciasocial.Text = "Asistencia Social (no disponible)"
        End If

        If ds_historiaC.Tables("HistoriaC4").Rows.Count <> 0 Then
            'tengo consulta nutricional
            CheckBox_consultanutricional.Checked = True
        Else
            CheckBox_consultanutricional.Checked = False
            CheckBox_consultanutricional.Enabled = False
            CheckBox_consultanutricional.Text = "Consulta Nutricional (no disponible)"
        End If

        If ds_historiaC.Tables("HistoriaC5").Rows.Count <> 0 Then
            'tengo consulta nutricional
            CheckBox_accesovascular.Checked = True
        Else
            CheckBox_accesovascular.Checked = False
            CheckBox_accesovascular.Enabled = False
            CheckBox_accesovascular.Text = "Acceso Vascular (no disponible)"
        End If

        If ds_historiaC.Tables("HistoriaC6").Rows.Count <> 0 Then
            'tengo consulta nutricional
            CheckBox_trasplante .Checked = True
        Else
            CheckBox_trasplante.Checked = False
            CheckBox_trasplante.Enabled = False
            CheckBox_trasplante.Text = "Trasplante (no disponible)"
        End If

    End Sub

    Private Sub CheckBox_todo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_todo.Click
        If CheckBox_todo.Checked = True Then
            'solo tildo si tiene enable en true 
            If CheckBox_evaluacionmedica.Enabled = True Then
                CheckBox_evaluacionmedica.Checked = True
            End If

            If CheckBox_accesovascular.Enabled = True Then
                CheckBox_accesovascular.Checked = True
            End If

            If CheckBox_consultaclinica.Enabled = True Then
                CheckBox_consultaclinica.Checked = True
            End If
            If CheckBox_consultapsicologica.Enabled = True Then
                CheckBox_consultapsicologica.Checked = True
            End If
            If CheckBox_asistenciasocial.Enabled = True Then
                CheckBox_consultapsicologica.Checked = True
            End If
            If CheckBox_consultanutricional.Enabled = True Then
                CheckBox_consultanutricional.Checked = True
            End If
            If CheckBox_trasplante.Enabled = True Then
                CheckBox_trasplante.Checked = True
            End If
        Else
            CheckBox_evaluacionmedica.Checked = False
            CheckBox_accesovascular.Checked = False
            CheckBox_consultaclinica.Checked = False
            CheckBox_consultapsicologica.Checked = False
            CheckBox_asistenciasocial.Checked = False
            CheckBox_consultanutricional.Checked = False
            CheckBox_trasplante.Checked = False

        End If
    End Sub

    Private Sub CheckBox_evaluacionmedica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_evaluacionmedica.Click
        If CheckBox_evaluacionmedica.Checked = False Then
            CheckBox_todo.Checked = False
        End If
    End Sub

    Private Sub CheckBox_consultaclinica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_consultaclinica.Click
        If CheckBox_consultaclinica.Checked = False Then
            CheckBox_todo.Checked = False
        End If
    End Sub

    Private Sub CheckBox_consultapsicologica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_consultapsicologica.Click
        If CheckBox_consultapsicologica.Checked = False Then
            CheckBox_todo.Checked = False
        End If
    End Sub

    Private Sub CheckBox_asistenciasocial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_asistenciasocial.Click
        If CheckBox_asistenciasocial.Checked = False Then
            CheckBox_todo.Checked = False
        End If
    End Sub

    Private Sub CheckBox_consultanutricional_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_consultanutricional.Click
        If CheckBox_consultanutricional.Checked = False Then
            CheckBox_todo.Checked = False
        End If
    End Sub

    Dim DAmedico As New Datos.Medico
    'Dim ds As DataSet = DAmedico.Medicos_Obtener
    Dim DAcliente As New Datos.Cliente
    Dim DAventa As New Datos.Venta
    Dim ds_reporte_historial As New Ds_reporte_historial
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If rb_todo.Checked = True Then


            msj_esperar_b.cliente_id = paciente_id 'el parametro es PAC_id pero en la base de datos esta guardado en cada tabla de historia clinica como si fuera CLI_id...no se este mariano jeje.
            msj_esperar_b.Show()

        Else
            'aqui mando parametros para que sea por rango de fechas
            msj_esperar_b.procedencia = "reporte historia clinica rango fecha"
            msj_esperar_b.cliente_id = paciente_id 'el parametro es PAC_id pero en la base de datos esta guardado en cada tabla de historia clinica como si fuera CLI_id...no se este mariano jeje.
            msj_esperar_b.Show()

        End If


        
        


        'ds_reporte_historial.Tables("Cliente").Rows.Clear()
        ''primero recupero toda la info del cliente/paciente
        'Dim ds_clie As DataSet = DAcliente.Cliente_obtener_info(cliente_id)
        'If ds_clie.Tables(1).Rows.Count <> 0 Then
        '    'existe cargo en dataset para informe crystal
        '    Dim fila As DataRow = ds_reporte_historial.Tables("Cliente").NewRow
        '    fila("CLI_id") = ds_clie.Tables(1).Rows(0).Item("CLI_id")
        '    fila("CLI_ape") = ds_clie.Tables(1).Rows(0).Item("CLI_ape")
        '    fila("CLI_nom") = ds_clie.Tables(1).Rows(0).Item("CLI_nom")
        '    fila("CLI_dni") = ds_clie.Tables(1).Rows(0).Item("CLI_dni")
        '    fila("CLI_fnac") = ds_clie.Tables(1).Rows(0).Item("CLI_fnac")
        '    fila("CLI_sexo") = ds_clie.Tables(1).Rows(0).Item("CLI_sexo")
        '    fila("CLI_obrasoc") = ds_clie.Tables(1).Rows(0).Item("CLI_obsoc")
        '    fila("CLI_tel") = ds_clie.Tables(1).Rows(0).Item("CLI_tel")
        '    fila("CLI_dir") = ds_clie.Tables(1).Rows(0).Item("CLI_dir")
        '    fila("CLI_CP") = ds_clie.Tables(1).Rows(0).Item("CLI_CP")
        '    fila("provincia") = ds_clie.Tables(1).Rows(0).Item("provincia")
        '    fila("localidad") = ds_clie.Tables(1).Rows(0).Item("Localidad")
        '    fila("CLI_numafi") = ds_clie.Tables(1).Rows(0).Item("CLI_numafi")
        '    fila("CLI_mail") = ds_clie.Tables(1).Rows(0).Item("CLI_mail")

        '    ds_reporte_historial.Tables("Cliente").Rows.Add(fila)
        'End If

        'ds_reporte_historial.Tables("Evaluacion_Medica").Rows.Clear()
        ''carga tabla empresa
        'Dim usuario_id As String
        'usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        'Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        'If ds_usuario.Tables(1).Rows.Count <> 0 Then
        '    ds_reporte_historial.Tables("Empresa").Rows.Clear()
        '    ds_reporte_historial.Tables("Empresa").Merge(ds_usuario.Tables(1))
        'End If
        'ds_historiaC = DAHistoria.Consulta_Obtener_Todos_Estudios_x_PAC(cliente_id)
        'If ds_historiaC.Tables("HistoriaC").Rows.Count <> 0 Then
        '    'Historia_Clinica.Tables("Consulta_antecedentes").Rows.Clear() 'borro el contenido del dataset.datatable clientes
        '    'Historia_Clinica.Tables("Consulta_antecedentes").Merge(ds_historiaC.Tables("HistoriaC"))
        '    Dim evaluacion As DataRow = ds_reporte_historial.Tables("Evaluacion_Medica").NewRow
        '    evaluacion("ConAnt_enferAct") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_enferAct"))
        '    evaluacion("ConAnt_patologico") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_patologico"))
        '    evaluacion("ConAnt_familiares") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_familiares"))
        '    evaluacion("ConAnt_fisico") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_fisico"))
        '    evaluacion("ConAnt_Diag") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_Diag"))
        '    evaluacion("ConAnt_estudios") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_estudios"))
        '    evaluacion("CLI_id") = cliente_id

        '    ds_reporte_historial.Tables("Evaluacion_Medica").Rows.Add(evaluacion)
        'End If

        ''//////////////////////////////////////////////////////////////////////////////////////////////
        ''//////////////////////////////////////////////////////////////////////////////////////////////
        ''CONSULTA CLINICA, SON VARIAS
        'ds_reporte_historial.Tables("Consulta_Clinica").Rows.Clear()
        'If ds_historiaC.Tables(1).Rows.Count <> 0 Then
        '    'ahora lo recorro y cargo el ds
        '    Dim i As Integer = 0
        '    While i < ds_historiaC.Tables(1).Rows.Count
        '        Dim consultamedica As DataRow = ds_reporte_historial.Tables("Consulta_Clinica").NewRow
        '        consultamedica("conmed_id") = ds_historiaC.Tables(1).Rows(i).Item("conmed_id")
        '        consultamedica("conmed_fecha") = ds_historiaC.Tables(1).Rows(i).Item("conmed_fecha")
        '        consultamedica("conmed_titulo") = ds_historiaC.Tables(1).Rows(i).Item("conmed_titulo")
        '        consultamedica("conmed_evaluacion") = ds_historiaC.Tables(1).Rows(i).Item("conmed_evaluacion")
        '        consultamedica("conmed_motivo") = ds_historiaC.Tables(1).Rows(i).Item("conmed_motivo")
        '        consultamedica("conmed_medicacion") = ds_historiaC.Tables(1).Rows(i).Item("conmed_medicacion")
        '        consultamedica("conmed_estudios") = ds_historiaC.Tables(1).Rows(i).Item("conmed_estudios")
        '        consultamedica("medico_id") = ds_historiaC.Tables(1).Rows(i).Item("medico_id")
        '        'tengo que recuperar el medico
        '        Dim medico_id As Integer = ds_historiaC.Tables(1).Rows(i).Item("medico_id")
        '        Dim j As Integer = 0
        '        While j < ds.Tables(0).Rows.Count
        '            If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
        '                consultamedica("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
        '                consultamedica("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
        '                Exit While
        '            End If
        '            j = j + 1
        '        End While
        '        consultamedica("conmed_acceso") = ds_historiaC.Tables(1).Rows(i).Item("conmed_acceso")
        '        consultamedica("CLI_id") = cliente_id
        '        ds_reporte_historial.Tables("Consulta_Clinica").Rows.Add(consultamedica)

        '        i = i + 1
        '    End While
        'End If

        ''///////////////////////////////////////////////////////////////////////////////////////
        ''CONSULTA PSICOLOGICA
        'ds_reporte_historial.Tables("Consulta_Psicologica").Rows.Clear()
        'If ds_historiaC.Tables(2).Rows.Count <> 0 Then
        '    'ahora lo recorro y cargo el ds
        '    Dim i As Integer = 0
        '    While i < ds_historiaC.Tables(2).Rows.Count
        '        Dim consultapsicologica As DataRow = ds_reporte_historial.Tables("Consulta_Psicologica").NewRow
        '        consultapsicologica("psico_id") = ds_historiaC.Tables(2).Rows(i).Item("psico_id")
        '        consultapsicologica("psico_titulo") = ds_historiaC.Tables(2).Rows(i).Item("psico_titulo")
        '        consultapsicologica("psico_fecha") = ds_historiaC.Tables(2).Rows(i).Item("psico_fecha")
        '        consultapsicologica("psico_motivo") = ds_historiaC.Tables(2).Rows(i).Item("psico_motivo")
        '        consultapsicologica("psico_evaluacion") = ds_historiaC.Tables(2).Rows(i).Item("psico_evaluacion")
        '        consultapsicologica("psico_estudios") = ds_historiaC.Tables(2).Rows(i).Item("psico_estudios")
        '        consultapsicologica("psico_medicacion") = ds_historiaC.Tables(2).Rows(i).Item("psico_medicacion")
        '        consultapsicologica("CLI_id") = ds_historiaC.Tables(2).Rows(i).Item("CLI_id")
        '        consultapsicologica("medico_id") = ds_historiaC.Tables(2).Rows(i).Item("medico_id")
        '        'tengo que recuperar el medico
        '        Dim medico_id As Integer = ds_historiaC.Tables(2).Rows(i).Item("medico_id")
        '        Dim j As Integer = 0
        '        While j < ds.Tables(0).Rows.Count
        '            If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
        '                consultapsicologica("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
        '                consultapsicologica("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
        '                Exit While
        '            End If
        '            j = j + 1
        '        End While
        '        ds_reporte_historial.Tables("Consulta_Psicologica").Rows.Add(consultapsicologica)
        '        i = i + 1
        '    End While
        'End If

        ''//////////////////////////////////////////////////////////////////////////////////////////////////
        ''ASISTENCIA SOCIAL
        'ds_reporte_historial.Tables("Asistencia_Social").Rows.Clear()
        'If ds_historiaC.Tables(3).Rows.Count <> 0 Then
        '    'ahora lo recorro y cargo el ds
        '    Dim i As Integer = 0
        '    While i < ds_historiaC.Tables(3).Rows.Count
        '        Dim asistenciasocial As DataRow = ds_reporte_historial.Tables("Asistencia_Social").NewRow
        '        asistenciasocial("social_id") = ds_historiaC.Tables(3).Rows(i).Item("social_id")
        '        asistenciasocial("social_titulo") = ds_historiaC.Tables(3).Rows(i).Item("social_titulo")
        '        asistenciasocial("social_fecha") = ds_historiaC.Tables(3).Rows(i).Item("social_fecha")
        '        asistenciasocial("social_motivo") = ds_historiaC.Tables(3).Rows(i).Item("social_motivo")
        '        asistenciasocial("social_evaluacion") = ds_historiaC.Tables(3).Rows(i).Item("social_evaluacion")
        '        asistenciasocial("CLI_id") = ds_historiaC.Tables(3).Rows(i).Item("CLI_id")
        '        asistenciasocial("medico_id") = ds_historiaC.Tables(3).Rows(i).Item("medico_id")

        '        'tengo que recuperar el medico
        '        Dim medico_id As Integer = ds_historiaC.Tables(3).Rows(i).Item("medico_id")
        '        Dim j As Integer = 0
        '        While j < ds.Tables(0).Rows.Count
        '            If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
        '                asistenciasocial("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
        '                asistenciasocial("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
        '                Exit While
        '            End If
        '            j = j + 1
        '        End While
        '        ds_reporte_historial.Tables("Asistencia_Social").Rows.Add(asistenciasocial)
        '        i = i + 1
        '    End While
        'End If

        ''/////////////////////////////////////////////////////////////////////
        ''CONSULTA NUTRICIONAL
        'ds_reporte_historial.Tables("Consulta_Nutricional").Rows.Clear()
        'If ds_historiaC.Tables(4).Rows.Count <> 0 Then
        '    'ahora lo recorro y cargo el ds
        '    Dim i As Integer = 0
        '    While i < ds_historiaC.Tables(4).Rows.Count
        '        Dim nutricional As DataRow = ds_reporte_historial.Tables("Consulta_Nutricional").NewRow
        '        nutricional("nutri_id") = ds_historiaC.Tables(4).Rows(i).Item("nutri_id")
        '        nutricional("nutri_titulo") = ds_historiaC.Tables(4).Rows(i).Item("nutri_titulo")
        '        nutricional("nutri_fecha") = ds_historiaC.Tables(4).Rows(i).Item("nutri_fecha")
        '        nutricional("nutri_motivo") = ds_historiaC.Tables(4).Rows(i).Item("nutri_motivo")
        '        nutricional("nutri_evaluacion") = ds_historiaC.Tables(4).Rows(i).Item("nutri_evaluacion")
        '        nutricional("nutri_estudios") = ds_historiaC.Tables(4).Rows(i).Item("nutri_estudios")
        '        nutricional("CLI_id") = ds_historiaC.Tables(4).Rows(i).Item("CLI_id")
        '        nutricional("medico_id") = ds_historiaC.Tables(4).Rows(i).Item("medico_id")

        '        'tengo que recuperar el medico
        '        Dim medico_id As Integer = ds_historiaC.Tables(4).Rows(i).Item("medico_id")
        '        Dim j As Integer = 0
        '        While j < ds.Tables(0).Rows.Count
        '            If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
        '                nutricional("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
        '                nutricional("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
        '                Exit While
        '            End If
        '            j = j + 1
        '        End While
        '        ds_reporte_historial.Tables("Consulta_Nutricional").Rows.Add(nutricional)
        '        i = i + 1
        '    End While
        'End If

        ''/////////////////////////configuracion para mostrar los resultados/////////////////////

        'ds_reporte_historial.Tables("configuracion").Rows.Clear() 'siempre borro para q no me de error.

        'Dim config_fila As DataRow = ds_reporte_historial.Tables("configuracion").NewRow


        'If ds_historiaC.Tables(1).Rows.Count <> 0 Then
        '    If CheckBox_consultaclinica.Checked = True Then
        '        config_fila("cons_cli") = "tengo info"
        '    Else
        '        config_fila("cons_cli") = ""
        '    End If

        'Else
        '    config_fila("cons_cli") = ""
        'End If

        'If ds_historiaC.Tables(2).Rows.Count <> 0 Then
        '    If CheckBox_consultapsicologica.Checked = True Then
        '        config_fila("cons_psico") = "tengo info"
        '    Else
        '        config_fila("cons_psico") = ""
        '    End If

        'Else
        '    config_fila("cons_psico") = ""
        'End If

        'If ds_historiaC.Tables(3).Rows.Count <> 0 Then
        '    If CheckBox_asistenciasocial.Checked = True Then
        '        config_fila("asis_soc") = "tengo info"
        '    Else
        '        config_fila("asis_soc") = ""
        '    End If
        'Else
        '    config_fila("asis_soc") = ""
        'End If

        'If ds_historiaC.Tables(4).Rows.Count <> 0 Then
        '    If CheckBox_consultanutricional.Checked = True Then
        '        config_fila("cons_nutr") = "tengo info"
        '    Else
        '        config_fila("cons_nutr") = ""
        '    End If
        'Else
        '    config_fila("cons_nutr") = ""
        'End If

        'If ds_historiaC.Tables(0).Rows.Count <> 0 Then
        '    If CheckBox_evaluacionmedica.Checked = True Then
        '        config_fila("eva_medica") = "tengo info"
        '    Else
        '        config_fila("eva_medica") = ""
        '    End If
        'Else
        '    config_fila("eva_medica") = ""
        'End If

        'ds_reporte_historial.Tables("configuracion").Rows.Add(config_fila)

        ''ahora creo el reporte
        'Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\EvaluacionMedica_CR.rpt")
        ''CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
        'CrReport.Database.Tables("Empresa").SetDataSource(ds_reporte_historial.Tables("Empresa"))
        'CrReport.Database.Tables("Cliente").SetDataSource(ds_reporte_historial.Tables("Cliente"))
        ''la tabla "evaluacion medica" esta en el subinforme
        'CrReport.Database.Tables("Evaluacion_Medica").SetDataSource(ds_reporte_historial.Tables("Evaluacion_Medica"))
        'CrReport.Database.Tables("Consulta_Clinica").SetDataSource(ds_reporte_historial.Tables("Consulta_Clinica"))
        'CrReport.Database.Tables("Consulta_Psicologica").SetDataSource(ds_reporte_historial.Tables("Consulta_Psicologica"))
        'CrReport.Database.Tables("Asistencia_Social").SetDataSource(ds_reporte_historial.Tables("Asistencia_Social"))
        'CrReport.Database.Tables("Consulta_Nutricional").SetDataSource(ds_reporte_historial.Tables("Consulta_Nutricional"))
        'CrReport.Database.Tables("configuracion").SetDataSource(ds_reporte_historial.Tables("configuracion"))
        ''usando la variable visor puedo abrir varios reportes, sin temor a q se junte los datos del dataset
        'Dim visor As New EvaluacionMedica_show
        'visor.CrystalReportViewer1.ReportSource = CrReport

        'visor.Text = "Evaluacion Médica. Paciente: " + TextBox1.Text + " - Imprimir."
        'visor.Show()
        ''reporte_cargando.intervalos_tiempo("si")
        'Me.Close()

    End Sub
End Class