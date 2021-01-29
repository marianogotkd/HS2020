Imports System.IO
Imports System.Data.OleDb

Public Class Cliente_alta_New
    Dim DAturno As New Datos.Turno
    Dim DAcliente As New Datos.Cliente
    Dim DApaciente As New Datos.Paciente
    Dim DActacte As New Datos.CuentaCorriente
    Dim DAobrasocial As New Datos.ObraSocial
    Dim DAestadocivil As New Datos.estadocivil
    Public cliente_id As Integer
    Public PAC_id As Integer
    Public form_procedencia As String = "alta"
    Public apertura As String = "menu_alta" 'esta variable me sirve para saber desde donde lo abro, si lo abro a la "Alta" desde el menu...el boton cancelar...solo borra lo q se escribe en los textbox.
    Public turnodialisis_id As Integer

    Private Sub Cliente_alta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Cliente_alta_New_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        msj_esperar_sesiones.procedencia = "Cliente_alta_new_load"
        msj_esperar_sesiones.Show()
    End Sub

    Public Sub LOAD_CARGA()
        Me.Show()
        tx_ape.Focus()
        'ComboBox_Sexo.SelectedIndex = 0
        tx_ape.TextAlign = HorizontalAlignment.Center
        tb_Dni_Cuit.TextAlign = HorizontalAlignment.Center
        ' tb_Dni_Cuit.MaxLength = 8
        tx_dir.TextAlign = HorizontalAlignment.Center
        tx_tel.TextAlign = HorizontalAlignment.Center
        Tb_nombre.TextAlign = HorizontalAlignment.Center
        tb_edad.TextAlign = HorizontalAlignment.Center
        'tx_ObSoc.TextAlign = HorizontalAlignment.Center
        tx_NumAfi.TextAlign = HorizontalAlignment.Center
        'Habilitar()
        obtener_estadocivil()
        Obtener_provincias()
        Obtener_Iva()
        obtener_obrasocial()
        obtener_turnos()
        DateTimePicker_fechaingreso.Value = Today
        ComboBox_Sexo.SelectedIndex = 0
        If form_procedencia = "modificar" Then
            'recuperar_datos_cliente()
            recuperar_datos_paciente()
            tb_Dni_Cuit.ReadOnly = True
        End If
        'esto de abajo estaba probando redimensionar el form
        UpR.Visible = False
        'DownR.Visible = False
        'LeftR.Visible = False
        'RightR.Visible = False
    End Sub





    Private Sub obtener_estadocivil()
        Dim ds As DataSet = DAestadocivil.Estadocivil_Obtener()
        ComboBox_estadocivil.DataSource = ds.Tables(0)
        ComboBox_estadocivil.DisplayMember = "Estadocivil_descripcion"
        ComboBox_estadocivil.ValueMember = "Estadocivil_id"
    End Sub
    Private Sub obtener_obrasocial()
        Dim ds As DataSet = DAobrasocial.ObraSocial_Obtener()
        ComboBox_obrasocial.DataSource = ds.Tables(0)
        ComboBox_obrasocial.DisplayMember = "Obrasocial_nombre"
        ComboBox_obrasocial.ValueMember = "Obrasocial_id"
    End Sub


    Private Sub recuperar_datos_paciente()
        Dim ds_paciente_recuperado As DataSet = DApaciente.Paciente_obtener_info(PAC_id)
        If ds_paciente_recuperado.Tables(0).Rows.Count <> 0 Then
            '///////////////////////////////////////////////////////////////////////////////////////
            tb_Dni_Cuit.Text = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_dni")
            tx_ape.Text = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_ape")
            Tb_nombre.Text = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_nom")
            FechaNac.Text = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_fnac")
            tb_edad.Text = CStr(calcularEdad(CDate(FechaNac.Text)))
            If ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_sexo") = "Masculino" Then
                ComboBox_Sexo.Text = "Masculino"
                'ComboBox_Sexo.SelectedIndex = 0
            Else
                'ComboBox_Sexo.SelectedIndex = 0
                ComboBox_Sexo.Text = "Femenino"
                'ComboBox_Sexo.SelectedIndex = 1
            End If
            'estado civil////////
            ComboBox_estadocivil.SelectedValue = ds_paciente_recuperado.Tables(0).Rows(0).Item("Estadocivil_id")
            '///////////////////////////////////////////////////////////////////////////////////////

            '///////////////////////////////////////////////////////////////////////////////////////
            tx_tel.Text = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_tel")
            tx_mail.Text = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_mail")
            tx_dir.Text = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAc_dir")
            tx_Cp.Text = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_CP")
            txt_chofer.Text = CStr(ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_chofer"))
            combo_Prov.SelectedValue = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_Id_Prov")
            Combo_Loc.SelectedValue = ds_paciente_recuperado.Tables(0).Rows(0).Item("localidad_id")
            '///////////////////////////////////////////////////////////////////////////////////////

            '///////////////////////////////////////////////////////////////////////////////////////
            ComboBox_obrasocial.SelectedValue = ds_paciente_recuperado.Tables(0).Rows(0).Item("Obrasocial_id")
            tx_NumAfi.Text = ds_paciente_recuperado.Tables(0).Rows(0).Item("PACnumafi")
            '///////////////////////////////////////////////////////////////////////////////////////

            '///////////////////////////////////////////////////////////////////////////////////////
            DateTimePicker_fechaingreso.Value = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_fechaingreso")
            'tipo de paciente
            Dim tipo_paciente As String = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_tipopaciente")
            If tipo_paciente = "Agudo" Then
                tipopaciente_agudo.Checked = True
            Else
                tipopaciente_cronico.Checked = True
            End If
            'tipo de dialisis
            Dim tipo_dialisis As String = ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_tipodialisis")
            If tipo_dialisis = "DPCA" Then
                RadioButton_DPCA.Checked = True
            End If
            If tipo_dialisis = "DPA" Then
                RadioButton_DPA.Checked = True
            End If
            If tipo_dialisis = "HEMODIALISIS" Then
                RadioButton_EMODIALISIS.Checked = True
            End If
            If tipo_dialisis = "HDF" Then
                RadioButton_HDF.Checked = True
            End If


            'asignar turno.
            If ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_turnoasignado") = "si" Then
                CheckBox_turno.Checked = True
                turnodialisis_id = ds_paciente_recuperado.Tables(0).Rows(0).Item("Turnodialisis_id")


                'Dim ds_turno As DataSet = DAturno.Turnodialisis_obtener_info(turnodialisis_id)
                'txt_turno.Text = ds_turno.Tables(0).Rows(0).Item("Turnodialisis_desc")
                'txt_horario.Text = ds_turno.Tables(0).Rows(0).Item("Turnodialisis_desde_hora") + ":" + ds_turno.Tables(0).Rows(0).Item("Turnodialisis_desde_minutos") + " - " + ds_turno.Tables(0).Rows(0).Item("Turnodialisis_hasta_hora") + ":" + ds_turno.Tables(0).Rows(0).Item("Turnodialisis_hasta_minutos")
                cb_turnos.SelectedValue = turnodialisis_id

                'ahora cargo lo de horario y dia
                If cb_turnos.Items.Count <> 0 And turno_listo = "si" Then
                    Dim turnodialisis_id As Integer = cb_turnos.SelectedValue
                    Dim i As Integer = 0
                    While i < Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows.Count
                        If Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows(i).Item("Turnodialisis_id") = turnodialisis_id Then
                            'ahora cargo horario y dias
                            txt_horario.Text = Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows(i).Item("Horario")
                            txt_dias.Text = Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows(i).Item("Dias")
                            Exit While
                        End If
                        i = i + 1
                    End While
                End If

                'Dim dias As String = ""
                'Dim j As Integer = 0
                'Dim ds_dias As DataSet = DAturno.Turnodialisis_obtener_dias(turnodialisis_id)
                'While j < ds_dias.Tables(0).Rows.Count
                '    If dias = "" Then
                '        dias = ds_dias.Tables(0).Rows(j).Item("Dias_desc")
                '    Else
                '        dias = dias + ", " + ds_dias.Tables(0).Rows(j).Item("Dias_desc")
                '    End If
                '    j = j + 1
                'End While
                'txt_dias.Text = dias
            Else
                CheckBox_turno.Checked = False
                turnodialisis_id = 0
            End If

            'estado en el sistema
            If ds_paciente_recuperado.Tables(0).Rows(0).Item("PAC_estado") = "Activo" Then
                estado_activo.Checked = True
            Else
                estado_inactivo.Checked = True
            End If
        End If


    End Sub

    Private Sub recuperar_datos_cliente()
        Dim ds_clie_recu As DataSet = DAcliente.Cliente_obtener_info(cliente_id)
        If ds_clie_recu.Tables(1).Rows.Count <> 0 Then
            tb_Dni_Cuit.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_dni")
            Combo_Iva.SelectedValue = ds_clie_recu.Tables(1).Rows(0).Item("CLI_tipoiva")
            tx_tel.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_tel")
            tx_dir.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_dir")
            tx_Cp.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_CP")
            combo_Prov.SelectedValue = ds_clie_recu.Tables(1).Rows(0).Item("CLI_Id_Prov")
            Combo_Loc.SelectedValue = ds_clie_recu.Tables(1).Rows(0).Item("localidad_id")
            tx_mail.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_mail")
            FechaNac.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_fnac")
            tx_ape.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_ape")
            Tb_nombre.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_nom")
            If ds_clie_recu.Tables(1).Rows(0).Item("CLI_sexo") = "Masculino" Then
                ComboBox_Sexo.Text = "Masculino"
                'ComboBox_Sexo.SelectedIndex = 0
            Else
                'ComboBox_Sexo.SelectedIndex = 0
                ComboBox_Sexo.Text = "Femenino"
                'ComboBox_Sexo.SelectedIndex = 1
            End If
            tb_edad.Text = CStr(calcularEdad(CDate(FechaNac.Text)))


            '/////////////debo recuperar y poner en un combobox/////////////
            'tx_ObSoc.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_obsoc")



            tx_NumAfi.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_numafi")

            'si tiene cuenta corriente cargamos los datos, solo se podra modificar el limite de deuda. choco: 02-12-2019.
            If ds_clie_recu.Tables(2).Rows.Count <> 0 Then
                CheckBox_habilitar_ctacte.Checked = True
                CheckBox_habilitar_ctacte.Enabled = False
                txt_ctacte.Text = ds_clie_recu.Tables(2).Rows(0).Item("CtaCte_id")
                txt_limitedeuda.Text = CDec(ds_clie_recu.Tables(2).Rows(0).Item("CtaCte_limitedeuda"))
                CheckBox_estado.Visible = True
                If CStr(ds_clie_recu.Tables(2).Rows(0).Item("CtaCte_estado")) = "Activo" Then
                    CheckBox_estado.Checked = True
                    CheckBox_estado.ForeColor = Color.Green
                    CheckBox_estado.Text = "Activo"
                Else
                    CheckBox_estado.Checked = False
                    CheckBox_estado.ForeColor = Color.Red
                    CheckBox_estado.Text = "Inactivo"
                End If
                Label_fechaalta.Text = "Fecha de alta: " + CDate(ds_clie_recu.Tables(2).Rows(0).Item("CtaCte_fechaalta"))
                Label_fechaalta.Visible = True
            End If
        End If

    End Sub
    Dim ds_iva As DataSet
    Public Sub Obtener_Iva()
        ds_iva = DAcliente.Obterner_Iva()
        Combo_Iva.DataSource = ds_iva.Tables(0)
        Combo_Iva.DisplayMember = "IVA_Descripcion"
        Combo_Iva.ValueMember = "IVA_id"

    End Sub
    Dim Turno As Integer = 0

    Public Sub Turno_Cliente(ByVal B As Integer)
        Turno = B
    End Sub

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim result As DialogResult
        'result = MessageBox.Show("¿Desea dar de alta al Cliente?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        'If result = DialogResult.OK Then
        '    'DAcliente.Cliente_Alta(tx_ape_clie.Text, tx_nom_clie.Text, tx_dni_clie.Text, DT_fecha.Value, tx_tel_clie.Text, tx_mail_clie.Text, tx_obser.Text, ComboBox1.Text)

        '    Select Case (Turno)
        '        Case (0)
        '            limpiar_deshabilitar()
        '            MessageBox.Show("El Cliente fue dado de alta correctamente.", "Sistema de Gestion.")
        '        Case (1)

        '            'If tb_Dni.Text = Nothing Then
        '            'If tx_ape_clie.Text <> Nothing Then
        '            '    TurnoFijo_alta.TX_ape.Text = tx_ape_clie.Text + " " + tx_nom_clie.Text
        '            'Else
        '            '    TurnoFijo_alta.TX_ape.Text = tx_nom_clie.Text
        '            'End If
        '            TurnoFijo_alta.Cliente_ObtenerNombre()
        '            Else
        '            TurnoFijo_alta.TX_doc.Text = tb_Dni.Text
        '            TurnoFijo_alta.Cliente_ObtenerDNI()
        '            End If
        'Me.Close()

        '        Case (2)

        'If tb_Dni.Text = Nothing Then
        '    'If tx_ape_clie.Text <> Nothing Then
        '    '    Turno_alta.TX_ape.Text = tx_ape_clie.Text + " " + tx_nom_clie.Text
        '    'Else
        '    '    Turno_alta.TX_ape.Text = tx_nom_clie.Text
        '    'End If

        '    Turno_alta.Cliente_ObtenerNombre()
        'Else

        '    Turno_alta.TX_doc.Text = tb_Dni.Text
        '    Turno_alta.Cliente_ObtenerDNI()
        'End If
        'Me.Close()

        '    End Select

        'End If
    End Sub



    'Private Sub tx_dni_clie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx_dni_clie.TextChanged
    '    Verificar()
    'End Sub

    'Private Sub tx_ape_clie_TextChanged(sender As System.Object, e As System.EventArgs) Handles tx_ape_clie.TextChanged
    '    Verificar()
    'End Sub

    'Private Sub tx_nom_clie_TextChanged(sender As System.Object, e As System.EventArgs) Handles tx_nom_clie.TextChanged
    '    Verificar()
    'End Sub

    'Public Sub Verificar()
    '    Dim ds_CLI_dni As DataSet = DAcliente.Cliente_VerificarDni(tb_Dni_Cuit.Text)
    '    With ds_CLI_dni.Tables(0).Rows
    '        If .Count  0 Then
    '            tb_Dni_Cuit.ForeColor = Color.Black
    '            ERROR_dni.Visible = False

    '        Else
    '            ERROR_dni.Visible = True
    '            tx_dni_clie.ForeColor = Color.Red
    '        End If
    '    End With
    '    Habilitar()
    'End Sub

    'Public Sub Habilitar()
    '    If tx_dni_clie.ForeColor = Color.Black And tx_dni_clie.TextLength >= 7 And tx_ape_clie.Text <> Nothing And tx_nom_clie.Text <> Nothing Then
    '        Bo_guardar.Enabled = True
    '    Else
    '        Bo_guardar.Enabled = False
    '    End If
    'End Sub



    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar_deshabilitar()
    End Sub

    Public Sub limpiar_deshabilitar()
        tx_ape.Text = Nothing
        tb_Dni_Cuit.Text = Nothing
        tx_tel.Text = Nothing
        tx_dir.Text = Nothing
        tx_Cp.Text = Nothing
        tx_mail.Text = Nothing
        Tb_nombre.Text = Nothing
        FechaNac.Text = Today
        tb_edad.Text = Nothing
        'tx_ObSoc.Text = Nothing
        tx_NumAfi.Text = Nothing
        tx_ape.Focus()
        form_procedencia = "alta"
        error_razonsocial.Visible = False
        error_dni.Visible = False
        error_afiliado.Visible = False
        CheckBox_habilitar_ctacte.Checked = False
        CheckBox_habilitar_ctacte.Enabled = True
        Label_fechaalta.Visible = False
        CheckBox_estado.Visible = False
        txt_chofer.Text = Nothing
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public FormProc As String




    Private Sub Modificar()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar el Paciente?", "Sistema de Gestión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If tb_Dni_Cuit.Text <> "" And tx_ape.Text <> "" And Tb_nombre.Text <> "" And FechaNac.Text <> "" And tx_NumAfi.Text <> "" Then

                Dim estado As String = ""
                If estado_activo.Checked = True Then
                    estado = "Activo"
                Else
                    If estado_inactivo.Checked = True Then
                        estado = "Inactivo"
                    End If
                End If
                Dim tipopaciente As String = ""
                If tipopaciente_agudo.Checked = True Then
                    tipopaciente = "Agudo"
                Else
                    If tipopaciente_cronico.Checked = True Then
                        tipopaciente = "Crónico"
                    End If
                End If
                Dim tipodialisis As String = ""
                If RadioButton_DPCA.Checked = True Then
                    tipodialisis = "DPCA"
                End If
                If RadioButton_DPA.Checked = True Then
                    tipodialisis = "DPA"
                End If
                If RadioButton_EMODIALISIS.Checked = True Then
                    tipodialisis = "HEMODIALISIS"
                End If
                If RadioButton_HDF.Checked = True Then
                    tipodialisis = "HDF"
                End If
                Dim turnoasignado As String

                If CheckBox_turno.Checked = True Then
                    If cb_turnos.Items.Count <> 0 Then
                        turnoasignado = "si"
                        turnodialisis_id = cb_turnos.SelectedValue
                    Else
                        turnoasignado = "no"
                        turnodialisis_id = 0
                    End If
                Else
                    turnoasignado = "no"
                    turnodialisis_id = 0
                End If
                DApaciente.Paciente_Modificar(PAC_id, tx_ape.Text, Tb_nombre.Text, tb_Dni_Cuit.Text, FechaNac.Value, ComboBox_Sexo.Text, ComboBox_obrasocial.SelectedValue,
                                                                                    tx_NumAfi.Text, tx_tel.Text, tx_dir.Text, CInt(tx_Cp.Text), combo_Prov.SelectedValue, Combo_Loc.SelectedValue,
                                                                                    tx_mail.Text, estado, ComboBox_estadocivil.SelectedValue, DateTimePicker_fechaingreso.Value,
                                                                                   tipopaciente, tipodialisis, turnodialisis_id, turnoasignado, txt_chofer.Text)

                MessageBox.Show("El Paciente se modificó correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cliente_modificar.Obtener_Pacientes()
                Me.Close()
                Cliente_modificar.Close()
                Cliente_modificar.Show()
            Else
                error_afiliado.Visible = True
                error_dni.Visible = True
                error_razonsocial.Visible = True
            End If


        End If
        limpiar_deshabilitar()
    End Sub


    Private Sub alta()
        If tb_Dni_Cuit.Text <> "" And tx_ape.Text <> "" And Tb_nombre.Text <> "" And FechaNac.Text <> "" And tx_NumAfi.Text <> "" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea dar de alta al Paciente?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then


                Dim ds_CLI_dni As DataSet = DApaciente.Paciente_VerificarDni(tb_Dni_Cuit.Text)
                With ds_CLI_dni.Tables(0).Rows
                    If .Count = 0 Then
                        Dim estado As String = ""
                        If estado_activo.Checked = True Then
                            estado = "Activo"
                        Else
                            If estado_inactivo.Checked = True Then
                                estado = "Inactivo"
                            End If
                        End If
                        Dim tipopaciente As String = ""
                        If tipopaciente_agudo.Checked = True Then
                            tipopaciente = "Agudo"
                        Else
                            If tipopaciente_cronico.Checked = True Then
                                tipopaciente = "Crónico"
                            End If
                        End If
                        Dim tipodialisis As String = ""
                        If RadioButton_DPCA.Checked = True Then
                            tipodialisis = "DPCA"
                        End If
                        If RadioButton_DPA.Checked = True Then
                            tipodialisis = "DPA"
                        End If
                        If RadioButton_EMODIALISIS.Checked = True Then
                            tipodialisis = "HEMODIALISIS"
                        End If
                        If RadioButton_HDF.Checked = True Then
                            tipodialisis = "HDF"
                        End If
                        Dim turnoasignado As String

                        If CheckBox_turno.Checked = True Then
                            If cb_turnos.Items.Count <> 0 Then
                                turnoasignado = "si"
                                turnodialisis_id = cb_turnos.SelectedValue
                            Else
                                turnoasignado = "no"
                                turnodialisis_id = 0
                            End If
                        Else
                            turnoasignado = "no"
                            turnodialisis_id = 0
                        End If

                        If tx_Cp.Text = "" Then
                            tx_Cp.Text = 0
                        End If

                        Dim ds_paciente_alta As DataSet = DApaciente.Paciente_Alta(tx_ape.Text, Tb_nombre.Text, tb_Dni_Cuit.Text, FechaNac.Value, ComboBox_Sexo.Text, ComboBox_obrasocial.SelectedValue,
                                                                                tx_NumAfi.Text, tx_tel.Text, tx_dir.Text, CInt(tx_Cp.Text), combo_Prov.SelectedValue, Combo_Loc.SelectedValue,
                                                                                tx_mail.Text, estado, ComboBox_estadocivil.SelectedValue, DateTimePicker_fechaingreso.Value,
                                                                                tipopaciente, tipodialisis, turnodialisis_id, turnoasignado, txt_chofer.Text)
                        'Venta_Caja_gestion.Obtener_Clientes()
                        Cliente_modificar.Obtener_Pacientes()

                        MessageBox.Show("El Paciente fue dado de alta correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        result = MessageBox.Show("¿Desea registrar una historia clínica?", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        If result = DialogResult.Yes Then
                            Historia_Clinica_Detalle.PAC_id = CInt(ds_paciente_alta.Tables(0).Rows(0).Item("PAC_id"))
                            Historia_Clinica_Detalle.Show()

                        Else
                            'aqui veo si cierro el form y abro modificar, o blanqueo todo y sigo agregando
                            If apertura = "menu_alta" Then
                                limpiar_deshabilitar()
                            End If
                            If apertura = "formulario modificar" Then
                                Me.Close()
                                Cliente_modificar.Close()
                                Cliente_modificar.Show()
                            End If
                        End If

                    Else
                        MessageBox.Show("Error, el Paciente ya existe.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_Dni_Cuit.Focus()
                        tb_Dni_Cuit.SelectAll()
                    End If
                End With
            End If
        Else
            MessageBox.Show("Error, Ingrese los campos obligatorios", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            error_razonsocial.Visible = True
            error_dni.Visible = True
            error_afiliado.Visible = True
        End If


        'If FormProc = "Mesas_Asignar" Then
        '    Mesa_asignar.Obtener_Clientes()
        'End If
    End Sub





    Private Sub btn_Cancelar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        If apertura = "menu_alta" Then
            limpiar_deshabilitar()
        End If

        If apertura = "formulario modificar" Then
            Me.Close()
            Cliente_modificar.Close()
            Cliente_modificar.Show()
        End If
    End Sub

#Region "Validaciones"
    Dim validaciones As New Validaciones



    Private Sub tx_tel_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_tel.KeyPress
        validaciones.Restricciones_textbox(e, "Celular", tx_tel)
    End Sub



    Private Sub tx_Cp_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Cp.KeyPress
        validaciones.Restricciones_textbox(e, "Entero", tx_Cp)
    End Sub



    Private Sub tb_Dni_Cuit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Dni_Cuit.KeyPress
        validaciones.Restricciones_textbox(e, "DNI/CUIT", tb_Dni_Cuit)
    End Sub

#End Region
    Dim ds_provincias As DataSet
    Dim idprov As Integer
    Private Sub Obtener_provincias()
        ds_provincias = DAcliente.Provincias_ObtenerTodo()
        'Cargar Provincias en ComboBox_prov
        combo_Prov.DataSource = ds_provincias.Tables(0)
        combo_Prov.DisplayMember = "provincia"
        combo_Prov.ValueMember = "Prov_id"
        idprov = combo_Prov.SelectedValue
        Obtener_localidades_x_provincias()
    End Sub


    Private Sub Obtener_localidades_x_provincias()

        Dim ds_localidades As DataSet = DAcliente.Obtener_localidades_x_provincias(idprov)
        'Cargar Provincias en ComboBox_prov
        Combo_Loc.DataSource = ds_localidades.Tables(0)
        Combo_Loc.DisplayMember = "Localidad"
        Combo_Loc.ValueMember = "id"
    End Sub


    'Private Sub tb_Dni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Dni.KeyPress
    '    validaciones.Restricciones_textbox(e, "DNI/CUIT", tb_Dni)

    'End Sub



    Private Sub txt_ctacte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub






    Public Function calcularEdad(ByVal nacimiento As Date) As Integer
        Dim edad As Integer
        edad = Today.Year - nacimiento.Year
        If (nacimiento > Today.AddYears(-edad)) Then edad -= 1
        Return edad
    End Function







    Private Sub tb_FechaNac_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs)
        'If tb_FechaNac.Text <> "  /  /" Then
        '    tb_edad.Text = CStr(calcularEdad(CDate(tb_FechaNac.Text)))
        'End If
        'validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", tb_FechaNac)
    End Sub


    '#Region "resize form choco"

    '    Private Sub UpR_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles UpR.MouseMove
    '        If e.Button = Windows.Forms.MouseButtons.Left Then
    '            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (Me.Location.Y - MousePosition.Y))
    '            Me.Location = New Point(Me.Location.X, MousePosition.Y)

    '        End If
    '    End Sub

    '    Private Sub DownR_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DownR.MouseMove
    '        If e.Button = Windows.Forms.MouseButtons.Left Then
    '            Me.Size = New Size(Me.Size.Width, MousePosition.Y - Me.Location.Y)
    '        End If
    '    End Sub


    '    Private Sub LeftR_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LeftR.MouseMove
    '        If e.Button = Windows.Forms.MouseButtons.Left Then
    '            Me.Size = New Size(Me.Size.Width + (Me.Location.X - MousePosition.X), Me.Size.Height)
    '            Me.Location = New Point(MousePosition.X, Me.Location.Y)
    '        End If
    '    End Sub

    '    Private Sub RightR_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RightR.MouseMove
    '        If e.Button = Windows.Forms.MouseButtons.Left Then
    '            Me.Size = New Size(MousePosition.X - Me.Location.X, Me.Size.Height)
    '        End If

    '    End Sub

    '    Private Sub Cliente_alta_New_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '        DownR.Location = New Point(0, Me.Size.Height - 2)
    '        RightR.Location = New Point(Me.Size.Width - 2, 0)
    '        UpR.Size = New Size(Me.Size.Width, 2)
    '        DownR.Size = New Size(Me.Size.Width, 2)
    '        LeftR.Size = New Size(2, Me.Size.Height)
    '        RightR.Size = New Size(2, Me.Size.Height)
    '    End Sub

    '#End Region


    Private Sub CheckBox_estado_CheckedChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_estado.CheckedChanged
        If CheckBox_estado.Checked = True Then
            CheckBox_estado.ForeColor = Color.Green
            CheckBox_estado.Text = "Activo"
        Else
            CheckBox_estado.ForeColor = Color.Red
            CheckBox_estado.Text = "Inactivo"
        End If
    End Sub

    Private Sub txt_limitedeuda_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_limitedeuda.KeyPress
        validaciones.Restricciones_textbox(e, "Decimal", txt_limitedeuda)
    End Sub

    Private Sub CheckBox_habilitar_ctacte_CheckedChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_habilitar_ctacte.CheckedChanged
        If CheckBox_habilitar_ctacte.Checked = True Then
            'aqui busco en la bd el ultimo nro de ctacte y cargo el proximo nro.
            'o sea genero de manera incrementa.
            txt_ctacte.Enabled = True

            Dim ds_ctacte As DataSet = DActacte.CtaCte_obtenertodo()
            Dim nro_ctacta As Integer
            If ds_ctacte.Tables(0).Rows.Count <> 0 Then
                nro_ctacta = CInt(ds_ctacte.Tables(0).Rows(0).Item("ID")) + 1
            Else
                nro_ctacta = 1
            End If
            txt_ctacte.Text = nro_ctacta

            'tambien habilito el textbox para colocar el limite de credito permitido.
            txt_limitedeuda.Enabled = True
            txt_limitedeuda.Focus()
        Else
            txt_ctacte.Enabled = False

            'tambien habilito el textbox para colocar el limite de credito permitido.
            txt_limitedeuda.Enabled = False
            txt_limitedeuda.Text = "0"

        End If
    End Sub




    Private Sub combo_Prov_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Prov.SelectedIndexChanged
        If idprov <> 0 Then
            idprov = combo_Prov.SelectedValue
            Obtener_localidades_x_provincias()
        End If
    End Sub



    Private Sub btn_Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        msj_esperar_sesiones.procedencia = "Cliente_Alta_btn_acepta_click"
        msj_esperar_sesiones.Show()
    End Sub

    Public Sub ACEPTAR()
        If form_procedencia = "alta" Then
            alta()
        End If
        If form_procedencia = "modificar" Then
            Modificar()
        End If
    End Sub




#Region "gotfocus formatos"

    Private Sub tx_ape_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_ape.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", tx_ape)
    End Sub

    Private Sub Tb_nombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tb_nombre.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", Tb_nombre)
    End Sub

    Private Sub tb_Dni_Cuit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Dni_Cuit.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", tb_Dni_Cuit)
    End Sub

    Private Sub tb_FechaNac_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", tb_FechaNac)
    End Sub

    Private Sub ComboBox_Sexo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_Sexo.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", ComboBox_Sexo)
    End Sub


    Private Sub tx_NumAfi_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_NumAfi.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", tx_NumAfi)
    End Sub

    Private Sub tx_tel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_tel.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", tx_tel)
    End Sub

    Private Sub tx_dir_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_dir.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", tx_dir)
    End Sub

    Private Sub tx_Cp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Cp.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", tx_Cp)
    End Sub
    Private Sub combo_Prov_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Prov.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", combo_Prov)
    End Sub

    Private Sub Combo_Loc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Loc.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", Combo_Loc)
    End Sub

    Private Sub tx_mail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_mail.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", tx_mail)
    End Sub
#End Region


#Region "lostfocus formatos"

    Private Sub tx_ape_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_ape.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", tx_ape)
    End Sub

    Private Sub Tb_nombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tb_nombre.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", Tb_nombre)
    End Sub

    Private Sub tb_Dni_Cuit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Dni_Cuit.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", tb_Dni_Cuit)
    End Sub

    Private Sub ComboBox_Sexo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_Sexo.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", ComboBox_Sexo)
    End Sub


    Private Sub tx_NumAfi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_NumAfi.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", tx_NumAfi)
    End Sub

    Private Sub tx_tel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_tel.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", tx_tel)
    End Sub

    Private Sub tx_dir_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_dir.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", tx_dir)
    End Sub

    Private Sub tx_Cp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Cp.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", tx_Cp)
    End Sub

    Private Sub combo_Prov_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Prov.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", combo_Prov)
    End Sub

    Private Sub Combo_Loc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Loc.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", Combo_Loc)
    End Sub

    Private Sub tx_mail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_mail.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", tx_mail)
    End Sub
#End Region

    Private Sub FechaNac_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FechaNac.GotFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", FechaNac)
    End Sub

    Private Sub FechaNac_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FechaNac.LostFocus
        'If tb_FechaNac.Text <> "  /  /" Then
        tb_edad.Text = CStr(calcularEdad(CDate(FechaNac.Text)))
        'End If
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", FechaNac)
    End Sub

    Private Sub CheckBox_turno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_turno.CheckedChanged
        If CheckBox_turno.Checked = True Then
            'habilito los demas controles
            cb_turnos.Enabled = True

            'txt_turno.Enabled = True
            txt_dias.Enabled = True
            txt_horario.Enabled = True
            'txt_turno.BackColor = Color.White
            'txt_dias.BackColor = Color.White
            'txt_horario.BackColor = Color.White
            'Button_buscar.Enabled = True
        Else
            'deshabilito los controles
            cb_turnos.Enabled = False
            'txt_turno.Enabled = False
            txt_dias.Enabled = False
            txt_horario.Enabled = False
            'txt_turno.BackColor = Color.Gray
            'txt_dias.BackColor = Color.Gray
            'txt_horario.BackColor = Color.Gray
            'txt_turno.Clear()
            txt_dias.Clear()
            txt_horario.Clear()
            'Button_buscar.Enabled = False
        End If
    End Sub

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TurnoDialisis_seleccionar.Close()
        TurnoDialisis_seleccionar.Show()
    End Sub

    Private Sub cb_turnos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_turnos.SelectedIndexChanged
        If cb_turnos.Items.Count <> 0 And turno_listo = "si" Then
            Dim turnodialisis_id As Integer = cb_turnos.SelectedValue
            Dim i As Integer = 0
            While i < Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows.Count
                If Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows(i).Item("Turnodialisis_id") = turnodialisis_id Then
                    'ahora cargo horario y dias
                    txt_horario.Text = Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows(i).Item("Horario")
                    txt_dias.Text = Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows(i).Item("Dias")
                    Exit While

                End If
                i = i + 1
            End While

        End If
    End Sub


    Dim Ds_turnodialisis As New Ds_turnodialisis
    Dim turno_listo = "no"
    Private Sub obtener_turnos()
        Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows.Clear()
        Dim ds_turno As DataSet = DAturno.Turnodialisis_obtener_todo()
        If ds_turno.Tables(0).Rows.Count <> 0 Then
            'aqui hago un new row
            Dim i As Integer = 0
            While i < ds_turno.Tables(0).Rows.Count
                Dim newrow As DataRow = Ds_turnodialisis.Tables("TurnoDialisis_consulta").NewRow()
                newrow("Turnodialisis_id") = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_id")
                newrow("Turnodialisis_desc") = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_desc")
                newrow("Horario") = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_desde_hora") + ":" + ds_turno.Tables(0).Rows(i).Item("Turnodialisis_desde_minutos") + " - " + ds_turno.Tables(0).Rows(i).Item("Turnodialisis_hasta_hora") + ":" + ds_turno.Tables(0).Rows(i).Item("Turnodialisis_hasta_minutos")
                'aqui recupero los dias
                Dim dias As String = ""
                Dim j As Integer = 0
                Dim turnodialisis_id As Integer = ds_turno.Tables(0).Rows(i).Item("Turnodialisis_id")
                Dim ds_dias As DataSet = DAturno.Turnodialisis_obtener_dias(turnodialisis_id)
                While j < ds_dias.Tables(0).Rows.Count
                    If dias = "" Then
                        dias = ds_dias.Tables(0).Rows(j).Item("Dias_desc")
                    Else
                        dias = dias + ", " + ds_dias.Tables(0).Rows(j).Item("Dias_desc")
                    End If
                    j = j + 1
                End While
                newrow("Dias") = dias
                Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows.Add(newrow)
                i = i + 1
            End While
        End If

        cb_turnos.DataSource = Ds_turnodialisis.Tables("TurnoDialisis_consulta")
        cb_turnos.DisplayMember = "Turnodialisis_desc"
        cb_turnos.ValueMember = "Turnodialisis_id"

        If cb_turnos.Items.Count <> 0 Then
            Dim turnodialisis_id As Integer = cb_turnos.SelectedValue
            Dim i As Integer = 0
            While i < Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows.Count
                If Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows(i).Item("Turnodialisis_id") = turnodialisis_id Then
                    'ahora cargo horario y dias
                    txt_horario.Text = Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows(i).Item("Horario")
                    txt_dias.Text = Ds_turnodialisis.Tables("TurnoDialisis_consulta").Rows(i).Item("Dias")
                    Exit While
                End If
                i = i + 1
            End While
        End If
        turno_listo = "si"
    End Sub


End Class