Public Class Enfermeria_reporte_fechas
    Public PAC_id As Integer
    Dim DAsesiones As New Datos.Sesiones
    Dim DApaciente As New Datos.Paciente
    Dim DAventa As New Datos.Venta
    Public procedencia = "planilla de sesiones"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If procedencia = "planilla de sesiones" Then
            msj_esperar_b.procedencia = "reporte_sesiones_x_fecha"
            msj_esperar_b.Show()
        Else
            msj_esperar_b.procedencia = "reporte_sesiones_y_consumos"
            msj_esperar_b.Show()
        End If
    End Sub


    Dim Ds_reporte_enfermeria As New Ds_reporte_enfermeria


    Public Sub reporte_2()
        'DAsesiones.Sesiones_recuperar_reporte_rangofechas(DateTimePicker_desde.Value, DateTimePicker_hasta.Value, PAC_id)
        Dim paciente_apenom As String = ""
        Ds_reporte_enfermeria.Tables("Cliente").Rows.Clear()



        'primero recupero toda la info del cliente/paciente

        Dim ds_clie As DataSet = DApaciente.Paciente_obtener_info(PAC_id)
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            'existe cargo en dataset para informe crystal
            Dim fila As DataRow = Ds_reporte_enfermeria.Tables("Cliente").NewRow
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
            paciente_apenom = ds_clie.Tables(0).Rows(0).Item("PAC_ape") + ", " + ds_clie.Tables(0).Rows(0).Item("PAC_nom")

            Ds_reporte_enfermeria.Tables("Cliente").Rows.Add(fila)
        End If


        'carga tabla empresa
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            Ds_reporte_enfermeria.Tables("Empresa").Rows.Clear()
            Ds_reporte_enfermeria.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If

        Dim ds_sesiones As DataSet = DAsesiones.Sesiones_recuperar_reporte_rangofechas(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date, PAC_id)

        Ds_reporte_enfermeria.Tables("sesiones").Rows.Clear()

        'version original que pasa los datos a la tabla "sesiones"
        '/////////////////////////////////////////////////////////////////////////
        If ds_sesiones.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < ds_sesiones.Tables(0).Rows.Count
                Dim fila As DataRow = Ds_reporte_enfermeria.Tables("sesiones").NewRow
                fila("Sesiones_id") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_id")
                fila("PAC_id") = ds_sesiones.Tables(0).Rows(i).Item("PAC_id")
                fila("Sesiones_fecha") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_fecha")
                fila("Sesiones_asistencia") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_asistencia")
                fila("Dialisis_id") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_id")
                fila("Dialisis_PesoS") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoS")
                fila("Dialisis_Talla") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Talla")
                fila("Dialisis_HI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_HI")
                fila("Dialisis_HE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_HE")
                fila("Dialisis_TiempoHD") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TiempoHD")
                fila("Dialisis_PesoI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoI")
                fila("Dialisis_PesoE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoE")
                fila("Dialisis_TAI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TAI")
                fila("Dialisis_TAE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TAE")
                fila("Dialisis_Filtro") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Filtro")
                fila("Dialisis_Obs") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Obs")
                fila("accesovascular_tipo") = ds_sesiones.Tables(0).Rows(i).Item("AccesoVascular")
                Ds_reporte_enfermeria.Tables("sesiones").Rows.Add(fila)


                'ahora agrego los consumos de cada sesion
                Dim k As Integer = 0
                Dim encontrado As String = "no"
                While k < ds_sesiones.Tables(4).Rows.Count
                    If ds_sesiones.Tables(4).Rows(k).Item("Sesiones_id") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_id") Then
                        encontrado = "si"
                        'Dim filac As DataRow = Ds_reporte_enfermeria.Tables("insumos_consumidos").NewRow
                        'filac("Consumo_mercaderia_id") = ds_sesiones.Tables(4).Rows(k).Item("Consumo_mercaderia_id")
                        'filac("Fecha") = ds_sesiones.Tables(4).Rows(k).Item("Fecha")
                        'Dim sesiones_id As Integer = ds_sesiones.Tables(4).Rows(k).Item("Sesiones_id")
                        'filac("Sesiones_id") = ds_sesiones.Tables(4).Rows(k).Item("Sesiones_id")
                        'filac("fecha_sesion") = ds_sesiones.Tables(4).Rows(k).Item("fecha_sesion")
                        'filac("cantidad") = ds_sesiones.Tables(4).Rows(k).Item("cantidad")
                        'filac("prod_codinterno") = ds_sesiones.Tables(4).Rows(k).Item("prod_codinterno")
                        'filac("Insumo") = ds_sesiones.Tables(4).Rows(k).Item("Insumo")
                        'Ds_reporte_enfermeria.Tables("insumos_consumidos").Rows.Add(filac)
                        Dim filac As DataRow = Ds_reporte_enfermeria.Tables("sesiones_e_insumos_group").NewRow
                        filac("Sesiones_id") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_id")
                        filac("PAC_id") = ds_sesiones.Tables(0).Rows(i).Item("PAC_id")
                        filac("Sesiones_fecha") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_fecha")
                        filac("Sesiones_asistencia") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_asistencia")
                        filac("Dialisis_id") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_id")
                        filac("Dialisis_PesoS") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoS")
                        filac("Dialisis_Talla") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Talla")
                        filac("Dialisis_HI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_HI")
                        filac("Dialisis_HE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_HE")
                        filac("Dialisis_TiempoHD") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TiempoHD")
                        filac("Dialisis_PesoI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoI")
                        filac("Dialisis_PesoE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoE")
                        filac("Dialisis_TAI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TAI")
                        filac("Dialisis_TAE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TAE")
                        filac("Dialisis_Filtro") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Filtro")
                        filac("Dialisis_Obs") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Obs")
                        filac("accesovascular_tipo") = ds_sesiones.Tables(0).Rows(i).Item("AccesoVascular")
                        filac("Consumo_mercaderia_id") = ds_sesiones.Tables(4).Rows(k).Item("Consumo_mercaderia_id")
                        filac("cantidad") = ds_sesiones.Tables(4).Rows(k).Item("cantidad")
                        filac("unidad_medida") = ds_sesiones.Tables(4).Rows(k).Item("prod_unidadmedida")
                        filac("prod_codinterno") = ds_sesiones.Tables(4).Rows(k).Item("prod_codinterno")
                        filac("Insumo") = ds_sesiones.Tables(4).Rows(k).Item("Insumo")
                        Ds_reporte_enfermeria.Tables("sesiones_e_insumos_group").Rows.Add(filac)
                    End If
                    k = k + 1
                End While
                If encontrado = "no" Then
                    'Dim filac As DataRow = Ds_reporte_enfermeria.Tables("insumos_consumidos").NewRow
                    'filac("Consumo_mercaderia_id") = 0
                    'filac("Fecha") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_fecha")
                    'Dim sesiones_id As Integer = ds_sesiones.Tables(4).Rows(k).Item("Sesiones_id")
                    'filac("Sesiones_id") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_id")
                    'filac("fecha_sesion") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_fecha")
                    'filac("cantidad") = CDec(0)
                    'filac("prod_codinterno") = 0
                    'filac("Insumo") = ""
                    'Ds_reporte_enfermeria.Tables("insumos_consumidos").Rows.Add(filac)

                    Dim filac As DataRow = Ds_reporte_enfermeria.Tables("sesiones_e_insumos_group").NewRow
                    filac("Sesiones_id") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_id")
                    filac("PAC_id") = ds_sesiones.Tables(0).Rows(i).Item("PAC_id")
                    filac("Sesiones_fecha") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_fecha")
                    filac("Sesiones_asistencia") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_asistencia")
                    filac("Dialisis_id") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_id")
                    filac("Dialisis_PesoS") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoS")
                    filac("Dialisis_Talla") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Talla")
                    filac("Dialisis_HI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_HI")
                    filac("Dialisis_HE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_HE")
                    filac("Dialisis_TiempoHD") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TiempoHD")
                    filac("Dialisis_PesoI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoI")
                    filac("Dialisis_PesoE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoE")
                    filac("Dialisis_TAI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TAI")
                    filac("Dialisis_TAE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TAE")
                    filac("Dialisis_Filtro") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Filtro")
                    filac("Dialisis_Obs") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Obs")
                    filac("accesovascular_tipo") = ds_sesiones.Tables(0).Rows(i).Item("AccesoVascular")
                    filac("Consumo_mercaderia_id") = 0
                    'filac("Fecha") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_fecha")
                    'Dim sesiones_id As Integer = ds_sesiones.Tables(4).Rows(k).Item("Sesiones_id")
                    'filac("Sesiones_id") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_id")
                    'filac("fecha_sesion") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_fecha")
                    filac("cantidad") = CDec(0)
                    filac("unidad_medida") = ""
                    filac("prod_codinterno") = 0
                    filac("Insumo") = ""
                    Ds_reporte_enfermeria.Tables("sesiones_e_insumos_group").Rows.Add(filac)
                End If


                i = i + 1
            End While

            '/////////////////////////////////////////////////////////////////////////


            'aqui agrego otra info como el tipo de acceso vascular, el turno y duracion HD
            Dim fila2 As DataRow = Ds_reporte_enfermeria.Tables("otra_info").NewRow
            If ds_sesiones.Tables(3).Rows.Count <> 0 Then
                fila2("acceso_vascular_tipo") = ds_sesiones.Tables(3).Rows(0).Item("AV_tipo")
            End If
            If ds_sesiones.Tables(1).Rows.Count <> 0 Then
                fila2("turno") = ds_sesiones.Tables(1).Rows(0).Item("Turnodialisis_desc")
            End If
            Dim indice_ultimo As Integer = ds_sesiones.Tables(0).Rows.Count - 1
            fila2("peso_seco") = ds_sesiones.Tables(0).Rows(indice_ultimo).Item("Dialisis_PesoS")
            fila2("duracion_hd") = ds_sesiones.Tables(0).Rows(indice_ultimo).Item("Dialisis_TiempoHD")
            Ds_reporte_enfermeria.Tables("otra_info").Rows.Add(fila2)


            'If ds_sesiones.Tables(4).Rows.Count <> 0 Then
            '    Dim k As Integer = 0
            '    While k < ds_sesiones.Tables(4).Rows.Count
            '        Dim fila As DataRow = Ds_reporte_enfermeria.Tables("insumos_consumidos").NewRow
            '        fila("Consumo_mercaderia_id") = ds_sesiones.Tables(4).Rows(k).Item("Consumo_mercaderia_id")
            '        fila("Fecha") = ds_sesiones.Tables(4).Rows(k).Item("Fecha")
            '        fila("Sesiones_id") = ds_sesiones.Tables(4).Rows(k).Item("Sesiones_id")
            '        fila("fecha_sesion") = ds_sesiones.Tables(4).Rows(k).Item("fecha_sesion")
            '        fila("cantidad") = ds_sesiones.Tables(4).Rows(k).Item("cantidad")
            '        fila("prod_codinterno") = ds_sesiones.Tables(4).Rows(k).Item("prod_codinterno")
            '        fila("Insumo") = ds_sesiones.Tables(4).Rows(k).Item("Insumo")
            '        Ds_reporte_enfermeria.Tables("insumos_consumidos").Rows.Add(fila)
            '        k = k + 1
            '    End While
            'End If


            'ahora creo el reporte
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Sesiones_y_consumos_2.rpt")
            'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
            CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_enfermeria.Tables("Empresa"))
            CrReport.Database.Tables("Cliente").SetDataSource(Ds_reporte_enfermeria.Tables("Cliente"))
            'la tabla "evaluacion medica" esta en el subinforme
            CrReport.Database.Tables("sesiones").SetDataSource(Ds_reporte_enfermeria.Tables("sesiones"))
            CrReport.Database.Tables("otra_info").SetDataSource(Ds_reporte_enfermeria.Tables("otra_info"))
            'CrReport.Database.Tables("insumos_consumidos").SetDataSource(Ds_reporte_enfermeria.Tables("insumos_consumidos"))
            CrReport.Database.Tables("sesiones_e_insumos_group").SetDataSource(Ds_reporte_enfermeria.Tables("sesiones_e_insumos_group"))
            'usando la variable visor puedo abrir varios reportes, sin temor a q se junte los datos del dataset
            Dim visor As New EvaluacionMedica_show
            visor.CrystalReportViewer1.ReportSource = CrReport

            visor.Text = "Informe de sesiones. Paciente: " + paciente_apenom + " - Imprimir."
            visor.Show()

            Informe_seleccionar.Close()
            Me.Close()
        Else

            MessageBox.Show("No se pudo generar el reporte. No hay sesiones registradas para el rango de fechas indicadas.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Public Sub reporte()
        'DAsesiones.Sesiones_recuperar_reporte_rangofechas(DateTimePicker_desde.Value, DateTimePicker_hasta.Value, PAC_id)
        Dim paciente_apenom As String = ""
        Ds_reporte_enfermeria.Tables("Cliente").Rows.Clear()



        'primero recupero toda la info del cliente/paciente

        Dim ds_clie As DataSet = DApaciente.Paciente_obtener_info(PAC_id)
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            'existe cargo en dataset para informe crystal
            Dim fila As DataRow = Ds_reporte_enfermeria.Tables("Cliente").NewRow
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
            paciente_apenom = ds_clie.Tables(0).Rows(0).Item("PAC_ape") + ", " + ds_clie.Tables(0).Rows(0).Item("PAC_nom")

            Ds_reporte_enfermeria.Tables("Cliente").Rows.Add(fila)
        End If


        'carga tabla empresa
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            Ds_reporte_enfermeria.Tables("Empresa").Rows.Clear()
            Ds_reporte_enfermeria.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If

        Dim ds_sesiones As DataSet = DAsesiones.Sesiones_recuperar_reporte_rangofechas(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date, PAC_id)

        Ds_reporte_enfermeria.Tables("sesiones").Rows.Clear()
        If ds_sesiones.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < ds_sesiones.Tables(0).Rows.Count
                Dim fila As DataRow = Ds_reporte_enfermeria.Tables("sesiones").NewRow
                fila("Sesiones_id") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_id")
                fila("PAC_id") = ds_sesiones.Tables(0).Rows(i).Item("PAC_id")
                fila("Sesiones_fecha") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_fecha")
                fila("Sesiones_asistencia") = ds_sesiones.Tables(0).Rows(i).Item("Sesiones_asistencia")
                fila("Dialisis_id") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_id")
                fila("Dialisis_PesoS") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoS")
                fila("Dialisis_Talla") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Talla")
                fila("Dialisis_HI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_HI")
                fila("Dialisis_HE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_HE")
                fila("Dialisis_TiempoHD") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TiempoHD")
                fila("Dialisis_PesoI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoI")
                fila("Dialisis_PesoE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_PesoE")
                fila("Dialisis_TAI") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TAI")
                fila("Dialisis_TAE") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_TAE")
                fila("Dialisis_Filtro") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Filtro")
                fila("Dialisis_Obs") = ds_sesiones.Tables(0).Rows(i).Item("Dialisis_Obs")
                fila("accesovascular_tipo") = ds_sesiones.Tables(0).Rows(i).Item("AccesoVascular")
                Ds_reporte_enfermeria.Tables("sesiones").Rows.Add(fila)
                i = i + 1
            End While

            'aqui agrego otra info como el tipo de acceso vascular, el turno y duracion HD
            Dim fila2 As DataRow = Ds_reporte_enfermeria.Tables("otra_info").NewRow
            If ds_sesiones.Tables(3).Rows.Count <> 0 Then
                fila2("acceso_vascular_tipo") = ds_sesiones.Tables(3).Rows(0).Item("AV_tipo")
            End If
            If ds_sesiones.Tables(1).Rows.Count <> 0 Then
                fila2("turno") = ds_sesiones.Tables(1).Rows(0).Item("Turnodialisis_desc")
            End If
            Dim indice_ultimo As Integer = ds_sesiones.Tables(0).Rows.Count - 1
            fila2("peso_seco") = ds_sesiones.Tables(0).Rows(indice_ultimo).Item("Dialisis_PesoS")
            fila2("duracion_hd") = ds_sesiones.Tables(0).Rows(indice_ultimo).Item("Dialisis_TiempoHD")
            Ds_reporte_enfermeria.Tables("otra_info").Rows.Add(fila2)


            'ahora creo el reporte
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Sesiones_x_fecha_CR.rpt")
            'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
            CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_enfermeria.Tables("Empresa"))
            CrReport.Database.Tables("Cliente").SetDataSource(Ds_reporte_enfermeria.Tables("Cliente"))
            'la tabla "evaluacion medica" esta en el subinforme
            CrReport.Database.Tables("sesiones").SetDataSource(Ds_reporte_enfermeria.Tables("sesiones"))
            CrReport.Database.Tables("otra_info").SetDataSource(Ds_reporte_enfermeria.Tables("otra_info"))

            'usando la variable visor puedo abrir varios reportes, sin temor a q se junte los datos del dataset
            Dim visor As New EvaluacionMedica_show
            visor.CrystalReportViewer1.ReportSource = CrReport

            visor.Text = "Informe de sesiones. Paciente: " + paciente_apenom + " - Imprimir."
            visor.Show()

            Informe_seleccionar.Close()
            Me.Close()


        Else

            MessageBox.Show("No se pudo generar el reporte. No hay sesiones registradas para el rango de fechas indicadas.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub
End Class