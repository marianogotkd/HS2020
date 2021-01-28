Public Class Orden_trabajo_selec_cliente
    Public appID As Integer = 0

    Public Cliente_ID As Integer
    Dim usuario_id As String
    Dim DAventa As New Datos.Venta
    Dim sucursal_id As Integer
    Dim DAservicio As New Datos.Servicio
    Public procedencia As String


    Private Sub Button_trabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_trabajo.Click
        'primero guardo y recien voy al otro form.
        If appID = 0 Then 'es un alta
            If TextBox_Nombre.Text <> "" Then

                'Dim result As DialogResult
                'result = MessageBox.Show("¿Desea continuar.?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                'If result = DialogResult.OK Then

                Dim ds_SevicioGuardar As DataSet = DAservicio.Servicio_alta_MDA(Cliente_ID, DateTimePicker1.Value,
                                                                    sucursal_id, usuario_id, "", combo_sucursal.Text,
                                                                    "", DateTimePicker1.Value, DateTimePicker1.Value,
                                                                    CDec(0), "PENDIENTE", combo_sucursal.SelectedValue, 0, 0, 0)
                'MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'AQUI TENGO QUE ABRIR EL REPORTE CON LA ORDEN DE REVISION.
                'Dim result2 As Integer = MessageBox.Show("¿Desea ver la orden de revisión para imprimir?", "Sistema de Gestión", MessageBoxButtons.YesNo)
                'If result2 = DialogResult.Yes Then
                '    reporte(ds_SevicioGuardar.Tables(0).Rows(0).Item(0))
                'End If
                'limpiar()
                'Me.Close()

                'habilito estos botones q me sirven
                Button1.Enabled = False
                'Button_imprimir.Enabled = True
                Button_trabajo.Enabled = True

                'btn_guardar.Enabled = False
                'End If

                '////////////////////////////////////////////////
                Servicio_nuevo.Close()
                Servicio_nuevo.serv_id = CInt(txt_serv_id.Text)
                Servicio_nuevo.procedencia = "Orden_trabajo_selec_cliente"
                Tareas_Consulta.Close()
                Servicio_nuevo.Show()
                Me.Close()
            Else
                MessageBox.Show("Error, complete los campos obligatorios.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'lb_error_diagnostico.Visible = True
                lb_error_cliente.Visible = True
            End If
        End If



        'debo enviar un parametro para indicar procedencia
        'ademas el id de la orden de revision q se creo en segundo plano.



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cliente_modificar.procedencia = "Orden_trabajo_selec_cliente"
        Cliente_modificar.Show()
    End Sub

    Private Sub limpiar()

        txt_serv_id.Clear()
        TextBox_dni.Clear()
        TextBox_Nombre.Clear()
        'TextBox_tel.Clear()
        'TextBox_dir.Clear()
        'txt_diag.Clear()
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

    Private Sub Orden_trabajo_selec_cliente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Button1.Enabled = True
        Button_trabajo.Enabled = True
    End Sub

    Private Sub Orden_trabajo_selec_cliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If appID = 0 Then 'es un alta
            limpiar()

            usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
            Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
            sucursal_id = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
            Generar_cod_interno()
            'Button_imprimir.Enabled = False
            Button_trabajo.Enabled = True
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
            If procedencia = "desde el menu" Then 'como accedo desde el menu, quiero poder elegir la fecha
                DateTimePicker1.Value = Today
                DateTimePicker1.Enabled = True
            End If

        End If
    End Sub
End Class