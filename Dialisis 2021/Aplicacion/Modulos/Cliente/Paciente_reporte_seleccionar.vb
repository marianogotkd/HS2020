Public Class Paciente_reporte_seleccionar
    Dim DAobrasocial As New Datos.ObraSocial

    Private Sub recuperar_obrasocial()
        Dim ds As DataSet = DAobrasocial.ObraSocial_Obtener()
        If ds.Tables(0).Rows.Count <> 0 Then
            combo_obrasocial.DataSource = ds.Tables(0)
            combo_obrasocial.DisplayMember = "Obrasocial_nombre"
            combo_obrasocial.ValueMember = "Obrasocial_id"

            Dim FILA As DataRow = ds.Tables(0).NewRow
            FILA("Obrasocial_id") = 0
            FILA("Obrasocial_nombre") = "TODOS"
            ds.Tables(0).Rows.Add(FILA)
        End If


    End Sub


    Private Sub Paciente_reporte_seleccionar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_obrasocial()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rb_todo.Checked = True Then
            msj_esperar_b.procedencia = "Pacientes_x_obra_social"
            msj_esperar_b.Show()
        Else
            msj_esperar_b.procedencia = "Paciente_x_obra_social_rango"
            msj_esperar_b.Show()
        End If
        

        ' en el formulario msj_esperar se llama a la rutina publica reporte() de este formulario.
        '        reporte()
    End Sub

    Dim DAventa As New Datos.Venta
    Dim Ds_reporte_paciente As New Ds_reporte_paciente
    Dim DApaciente As New Datos.Paciente
    Public Sub reporte()

        'carga tabla empresa
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            Ds_reporte_paciente.Tables("Empresa").Rows.Clear()
            Ds_reporte_paciente.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If

        'ahora lo de los pacientes
        Ds_reporte_paciente.Tables("Paciente").Rows.Clear()

        Dim generar_reporte As String = "si"
        If combo_obrasocial.Items.Count <> 0 Then
            Dim ds As DataSet
            If combo_obrasocial.SelectedValue = 0 Then
                ds = DApaciente.Paciente_todos_reporte
            Else
                ds = DApaciente.Paciente_x_obra_social(combo_obrasocial.SelectedValue)
            End If

            If rb_activo.Checked = True Then
                If ds.Tables(0).Rows.Count <> 0 Then
                    'recupero los activos
                    Dim i As Integer = 0
                    While i < ds.Tables(0).Rows.Count
                        Dim fila As DataRow = Ds_reporte_paciente.Tables("Paciente").NewRow
                        fila("PACnumafi") = ds.Tables(0).Rows(i).Item("PACnumafi")
                        fila("PAC_dni") = ds.Tables(0).Rows(i).Item("PAC_dni")
                        fila("Nombre") = ds.Tables(0).Rows(i).Item("Nombre")
                        fila("PAc_dir") = ds.Tables(0).Rows(i).Item("PAc_dir")
                        If ds.Tables(0).Rows(i).Item("PAC_sexo") = "Masculino" Then
                            fila("PAC_sexo") = "M"
                        Else
                            fila("PAC_sexo") = "F"
                        End If


                        fila("PAC_fnac") = ds.Tables(0).Rows(i).Item("PAC_fnac")
                        fila("PAC_tipodialisis") = ds.Tables(0).Rows(i).Item("PAC_tipodialisis")
                        fila("Obrasocial_id") = ds.Tables(0).Rows(i).Item("Obrasocial_id")
                        fila("Obrasocial_nombre") = ds.Tables(0).Rows(i).Item("Obrasocial_nombre")
                        fila("PAC_fechaingreso") = ds.Tables(0).Rows(i).Item("PAC_fechaingreso")
                        fila("PAC_estado") = ds.Tables(0).Rows(i).Item("PAC_estado")
                        Dim edad As Date = ds.Tables(0).Rows(i).Item("PAC_fnac")
                        fila("edad") = calcularEdad(edad.Date)
                        Ds_reporte_paciente.Tables("Paciente").Rows.Add(fila)
                        i = i + 1
                    End While
                Else
                    generar_reporte = "no"
                    MessageBox.Show("No hay pacientes activos en el sistema. Por favor seleccione otra Obra Social.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                'inactivos
                If ds.Tables(1).Rows.Count <> 0 Then
                    'recupero los activos
                    Dim i As Integer = 0
                    While i < ds.Tables(1).Rows.Count
                        Dim fila As DataRow = Ds_reporte_paciente.Tables("Paciente").NewRow
                        fila("PACnumafi") = ds.Tables(1).Rows(i).Item("PACnumafi")
                        fila("PAC_dni") = ds.Tables(1).Rows(i).Item("PAC_dni")
                        fila("Nombre") = ds.Tables(1).Rows(i).Item("Nombre")
                        fila("PAc_dir") = ds.Tables(1).Rows(i).Item("PAc_dir")
                        If ds.Tables(1).Rows(i).Item("PAC_sexo") = "Masculino" Then
                            fila("PAC_sexo") = "M"
                        Else
                            fila("PAC_sexo") = "F"
                        End If


                        fila("PAC_fnac") = ds.Tables(1).Rows(i).Item("PAC_fnac")
                        fila("PAC_tipodialisis") = ds.Tables(1).Rows(i).Item("PAC_tipodialisis")
                        fila("Obrasocial_id") = ds.Tables(1).Rows(i).Item("Obrasocial_id")
                        fila("Obrasocial_nombre") = ds.Tables(1).Rows(i).Item("Obrasocial_nombre")
                        fila("PAC_fechaingreso") = ds.Tables(1).Rows(i).Item("PAC_fechaingreso")
                        fila("PAC_estado") = ds.Tables(1).Rows(i).Item("PAC_estado")
                        fila("edad") = calcularEdad(CDate(ds.Tables(1).Rows(i).Item("PAC_fnac")))
                        Ds_reporte_paciente.Tables("Paciente").Rows.Add(fila)
                        i = i + 1
                    End While
                Else
                    generar_reporte = "no"
                    MessageBox.Show("No hay pacientes inactivos en el sistema. Por favor seleccione otra Obra Social.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If

        If generar_reporte = "si" Then
            If combo_obrasocial.SelectedValue <> 0 Then
                'ahora creo el reporte
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Paciente_x_obrasocial_CR.rpt")
                'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
                CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_paciente.Tables("Empresa"))
                CrReport.Database.Tables("Paciente").SetDataSource(Ds_reporte_paciente.Tables("Paciente"))
                'la tabla "evaluacion medica" esta en el subinforme
                'CrReport.Database.Tables("Evaluacion_Medica").SetDataSource(Ds_reporte_historial.Tables("Evaluacion_Medica"))
                'CrReport.Database.Tables("Consulta_Clinica").SetDataSource(Ds_reporte_historial.Tables("Consulta_Clinica"))
                'CrReport.Database.Tables("Consulta_Psicologica").SetDataSource(Ds_reporte_historial.Tables("Consulta_Psicologica"))
                'CrReport.Database.Tables("Asistencia_Social").SetDataSource(Ds_reporte_historial.Tables("Asistencia_Social"))
                'CrReport.Database.Tables("Consulta_Nutricional").SetDataSource(Ds_reporte_historial.Tables("Consulta_Nutricional"))
                'CrReport.Database.Tables("configuracion").SetDataSource(Ds_reporte_historial.Tables("configuracion"))
                'CrReport.Database.Tables("Accesovascular").SetDataSource(Ds_reporte_historial.Tables("Accesovascular"))
                'CrReport.Database.Tables("consulta_trasplante").SetDataSource(Ds_reporte_historial.Tables("consulta_trasplante"))

                'usando la variable visor puedo abrir varios reportes, sin temor a q se junte los datos del dataset
                Dim visor As New EvaluacionMedica_show
                visor.CrystalReportViewer1.ReportSource = CrReport
                visor.Text = "Reporte de Pacientes por Obra Social: " + Informe_seleccionar.TextBox1.Text + " - Imprimir."
                visor.Show()

            Else
                'ahora creo el reporte
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Paciente_todos_grupo_obra_CR.rpt")
                'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
                CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_paciente.Tables("Empresa"))
                CrReport.Database.Tables("Paciente").SetDataSource(Ds_reporte_paciente.Tables("Paciente"))

                'usando la variable visor puedo abrir varios reportes, sin temor a q se junte los datos del dataset
                Dim visor As New EvaluacionMedica_show
                visor.CrystalReportViewer1.ReportSource = CrReport
                visor.Text = "Reporte de todos los Pacientes: " + Informe_seleccionar.TextBox1.Text + " - Imprimir."
                visor.Show()
            End If
            
        End If
    End Sub

    Public Sub reporte_rango()
        'carga tabla empresa
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            Ds_reporte_paciente.Tables("Empresa").Rows.Clear()
            Ds_reporte_paciente.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If

        'ahora lo de los pacientes
        Ds_reporte_paciente.Tables("Paciente").Rows.Clear()

        Dim generar_reporte As String = "si"
        If combo_obrasocial.Items.Count <> 0 Then
            Dim ds As DataSet
            If combo_obrasocial.SelectedValue = 0 Then
                ds = DApaciente.Paciente_todos_reporte_x_rango(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
            Else
                ds = DApaciente.Paciente_x_obra_social_x_rango(combo_obrasocial.SelectedValue, DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
            End If

            If rb_activo.Checked = True Then
                If ds.Tables(0).Rows.Count <> 0 Then
                    'recupero los activos
                    Dim i As Integer = 0
                    While i < ds.Tables(0).Rows.Count
                        Dim fila As DataRow = Ds_reporte_paciente.Tables("Paciente").NewRow
                        fila("PACnumafi") = ds.Tables(0).Rows(i).Item("PACnumafi")
                        fila("PAC_dni") = ds.Tables(0).Rows(i).Item("PAC_dni")
                        fila("Nombre") = ds.Tables(0).Rows(i).Item("Nombre")
                        fila("PAc_dir") = ds.Tables(0).Rows(i).Item("PAc_dir")
                        If ds.Tables(0).Rows(i).Item("PAC_sexo") = "Masculino" Then
                            fila("PAC_sexo") = "M"
                        Else
                            fila("PAC_sexo") = "F"
                        End If


                        fila("PAC_fnac") = ds.Tables(0).Rows(i).Item("PAC_fnac")
                        fila("PAC_tipodialisis") = ds.Tables(0).Rows(i).Item("PAC_tipodialisis")
                        fila("Obrasocial_id") = ds.Tables(0).Rows(i).Item("Obrasocial_id")
                        fila("Obrasocial_nombre") = ds.Tables(0).Rows(i).Item("Obrasocial_nombre")
                        fila("PAC_fechaingreso") = ds.Tables(0).Rows(i).Item("PAC_fechaingreso")
                        fila("PAC_estado") = ds.Tables(0).Rows(i).Item("PAC_estado")
                        Dim edad As Date = ds.Tables(0).Rows(i).Item("PAC_fnac")
                        fila("edad") = calcularEdad(edad.Date)
                        Ds_reporte_paciente.Tables("Paciente").Rows.Add(fila)
                        i = i + 1
                    End While
                Else
                    generar_reporte = "no"
                    MessageBox.Show("No hay pacientes activos en el sistema. Por favor seleccione otra Obra Social.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                'inactivos
                If ds.Tables(1).Rows.Count <> 0 Then
                    'recupero los activos
                    Dim i As Integer = 0
                    While i < ds.Tables(1).Rows.Count
                        Dim fila As DataRow = Ds_reporte_paciente.Tables("Paciente").NewRow
                        fila("PACnumafi") = ds.Tables(1).Rows(i).Item("PACnumafi")
                        fila("PAC_dni") = ds.Tables(1).Rows(i).Item("PAC_dni")
                        fila("Nombre") = ds.Tables(1).Rows(i).Item("Nombre")
                        fila("PAc_dir") = ds.Tables(1).Rows(i).Item("PAc_dir")
                        If ds.Tables(1).Rows(i).Item("PAC_sexo") = "Masculino" Then
                            fila("PAC_sexo") = "M"
                        Else
                            fila("PAC_sexo") = "F"
                        End If


                        fila("PAC_fnac") = ds.Tables(1).Rows(i).Item("PAC_fnac")
                        fila("PAC_tipodialisis") = ds.Tables(1).Rows(i).Item("PAC_tipodialisis")
                        fila("Obrasocial_id") = ds.Tables(1).Rows(i).Item("Obrasocial_id")
                        fila("Obrasocial_nombre") = ds.Tables(1).Rows(i).Item("Obrasocial_nombre")
                        fila("PAC_fechaingreso") = ds.Tables(1).Rows(i).Item("PAC_fechaingreso")
                        fila("PAC_estado") = ds.Tables(1).Rows(i).Item("PAC_estado")
                        fila("edad") = calcularEdad(CDate(ds.Tables(1).Rows(i).Item("PAC_fnac")))
                        Ds_reporte_paciente.Tables("Paciente").Rows.Add(fila)
                        i = i + 1
                    End While
                Else
                    generar_reporte = "no"
                    MessageBox.Show("No hay pacientes inactivos en el sistema. Por favor seleccione otra Obra Social.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If

        If generar_reporte = "si" Then
            If combo_obrasocial.SelectedValue <> 0 Then
                'ahora creo el reporte
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Paciente_x_obrasocial_CR.rpt")
                'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
                CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_paciente.Tables("Empresa"))
                CrReport.Database.Tables("Paciente").SetDataSource(Ds_reporte_paciente.Tables("Paciente"))
                'la tabla "evaluacion medica" esta en el subinforme
                'CrReport.Database.Tables("Evaluacion_Medica").SetDataSource(Ds_reporte_historial.Tables("Evaluacion_Medica"))
                'CrReport.Database.Tables("Consulta_Clinica").SetDataSource(Ds_reporte_historial.Tables("Consulta_Clinica"))
                'CrReport.Database.Tables("Consulta_Psicologica").SetDataSource(Ds_reporte_historial.Tables("Consulta_Psicologica"))
                'CrReport.Database.Tables("Asistencia_Social").SetDataSource(Ds_reporte_historial.Tables("Asistencia_Social"))
                'CrReport.Database.Tables("Consulta_Nutricional").SetDataSource(Ds_reporte_historial.Tables("Consulta_Nutricional"))
                'CrReport.Database.Tables("configuracion").SetDataSource(Ds_reporte_historial.Tables("configuracion"))
                'CrReport.Database.Tables("Accesovascular").SetDataSource(Ds_reporte_historial.Tables("Accesovascular"))
                'CrReport.Database.Tables("consulta_trasplante").SetDataSource(Ds_reporte_historial.Tables("consulta_trasplante"))

                'usando la variable visor puedo abrir varios reportes, sin temor a q se junte los datos del dataset
                Dim visor As New EvaluacionMedica_show
                visor.CrystalReportViewer1.ReportSource = CrReport
                visor.Text = "Reporte de Pacientes por Obra Social: " + Informe_seleccionar.TextBox1.Text + " - Imprimir."
                visor.Show()

            Else
                'ahora creo el reporte
                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Paciente_todos_grupo_obra_CR.rpt")
                'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
                CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_paciente.Tables("Empresa"))
                CrReport.Database.Tables("Paciente").SetDataSource(Ds_reporte_paciente.Tables("Paciente"))

                'usando la variable visor puedo abrir varios reportes, sin temor a q se junte los datos del dataset
                Dim visor As New EvaluacionMedica_show
                visor.CrystalReportViewer1.ReportSource = CrReport
                visor.Text = "Reporte de todos los Pacientes: " + Informe_seleccionar.TextBox1.Text + " - Imprimir."
                visor.Show()
            End If

        End If
    End Sub





    Public Function calcularEdad(ByVal nacimiento As Date) As Integer
        Dim edad As Integer
        edad = Today.Year - nacimiento.Year
        If (nacimiento > Today.AddYears(-edad)) Then edad -= 1
        Return edad
    End Function




End Class