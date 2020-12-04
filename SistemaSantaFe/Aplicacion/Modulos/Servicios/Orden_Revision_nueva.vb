Public Class Orden_Revision_nueva
    Public appID As Integer = 0

    Public Cliente_ID As Integer
    Dim usuario_id As String
    Dim DAventa As New Datos.Venta
    Dim sucursal_id As Integer
    Dim DAservicio As New Datos.Servicio
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cliente_modificar.procedencia = "Orden_Revision_nueva"
        Cliente_modificar.Show()
    End Sub


    Private Sub Orden_Revision_nueva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If appID = 0 Then 'es un alta
            limpiar()

            usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
            Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
            sucursal_id = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
            Generar_cod_interno()
            Button_imprimir.Enabled = False
            Button_trabajo.Enabled = False
            'ComboBox1.SelectedIndex = 1
            'txt_equipo.Focus()
            'txt_equipo.SelectAll()
            'If Servicio_Consulta.serv_id = 0 Then
            '    Button_finalizar.Enabled = False
            '    Label_Estado.Visible = False
            '    Generar_cod_interno()
            'Else
            '    Cargar_Datos()
            'End If
            'GroupBox1.Text = "Orden de Servicio N°" + " " + Label_Cod.Text

        Else

            'recupero info del servicio
            Cargar_Datos()
            'bloqueo el boton de seleccionar cliente.
            Button1.Enabled = False
            Button_imprimir.Enabled = True
            Button_trabajo.Enabled = True
        End If


    End Sub

    Private Sub Cargar_Datos()
        Dim Ds_servicio As DataSet = DAservicio.Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA(appID)
        Dim i As Integer = 0
        Dim index As Integer = 1
        If Ds_servicio.Tables(0).Rows.Count <> 0 Then
            txt_serv_id.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_id").ToString
            TextBox_Nombre.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_Fan").ToString
            TextBox_dni.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_dni").ToString
            TextBox_dir.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_dir").ToString
            TextBox_tel.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_tel").ToString
            txt_diag.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Diagnostico").ToString
            DateTimePicker1.Value = Ds_servicio.Tables(0).Rows(i).Item("Servicio_fecha")
            'Label_Estado.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Estado").ToString
            'Label_Estado.Visible = True
            'i = i + 1
            index = index + 1
        End If
    End Sub



    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAservicio.Servicio_validar
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            txt_serv_id.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item(0) + 1
        Else
            txt_serv_id.Text = "1"
        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If appID = 0 Then 'es un alta
            If txt_diag.Text <> "" And TextBox_Nombre.Text <> "" Then

                Dim result As DialogResult
                result = MessageBox.Show("¿Desea guardar la nueva orden de Revisión?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then

                    Dim ds_SevicioGuardar As DataSet = DAservicio.Servicio_alta_MDA(Cliente_ID, DateTimePicker1.Value,
                                                                        sucursal_id, usuario_id, txt_diag.Text, "",
                                                                        "", DateTimePicker1.Value, DateTimePicker1.Value,
                                                                        CDec(0), "PENDIENTE")
                    MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'AQUI TENGO QUE ABRIR EL REPORTE CON LA ORDEN DE REVISION.
                    Dim result2 As Integer = MessageBox.Show("¿Desea ver la orden de revisión para imprimir?", "Sistema de Gestión", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        reporte(ds_SevicioGuardar.Tables(0).Rows(0).Item(0))
                    End If
                    limpiar()
                    Me.Close()

                End If
            Else
                MessageBox.Show("Error, complete los campos obligatorios.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lb_error_diagnostico.Visible = True
                lb_error_cliente.Visible = True
            End If
        Else
            'entonces es una modificacion.
            If txt_diag.Text <> "" And TextBox_Nombre.Text <> "" Then

                Dim result As DialogResult
                result = MessageBox.Show("¿Desea modificar la orden de Revisión Nº" + txt_serv_id.Text + "?", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then

                    Dim ds_SevicioGuardar As DataSet = DAservicio.Servicio_modificar_revision_MDA(CInt(txt_serv_id.Text), txt_diag.Text)

                    MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'AQUI TENGO QUE ABRIR EL REPORTE CON LA ORDEN DE REVISION.
                    reporte(CInt(txt_serv_id.Text))
                    limpiar()
                    Me.Close()
                End If
            Else
                MessageBox.Show("Error, complete los campos obligatorios.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lb_error_diagnostico.Visible = True
                lb_error_cliente.Visible = True
            End If
        End If

        
    End Sub

    Private Sub limpiar()

        txt_serv_id.Clear()
        TextBox_dni.Clear()
        TextBox_Nombre.Clear()
        TextBox_tel.Clear()
        TextBox_dir.Clear()
        txt_diag.Clear()


    End Sub
    Dim ds_revision_reporte As New ds_revision_reporte
    Private Sub reporte(ByVal servicio_id As Integer)
        ds_revision_reporte.Tables("Revision").Rows.Clear()

        Dim fila As DataRow = ds_revision_reporte.Tables("Revision").NewRow
        fila("id_revision") = servicio_id
        fila("cliente") = TextBox_Nombre.Text
        fila("direccion") = TextBox_dir.Text
        fila("fecha") = DateTimePicker1.Value.Date
        fila("diagnostico_previo") = txt_diag.Text
        ds_revision_reporte.Tables("Revision").Rows.Add(fila)

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Servicios\Reportes\CR_orden_revision.rpt")
        CrReport.Database.Tables("Revision").SetDataSource(ds_revision_reporte.Tables("Revision"))

        Dim visor As New Facturacion_report_show
        visor.CrystalReportViewer1.ReportSource = CrReport

        visor.Text = "Orden de revision. Imprimir."
        visor.Show()

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        limpiar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_imprimir.Click
        reporte(txt_serv_id.Text)
    End Sub

    Private Sub Button_trabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_trabajo.Click
        Servicio_nuevo.Close()
        Servicio_nuevo.serv_id = CInt(txt_serv_id.Text)
        Tareas_Consulta.Close()
        Servicio_nuevo.Show()
        Me.Close()

    End Sub
End Class
