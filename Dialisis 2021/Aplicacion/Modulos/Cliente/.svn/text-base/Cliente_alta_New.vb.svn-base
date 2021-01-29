Imports System.IO
Imports System.Data.OleDb

Public Class Cliente_alta_New
    Dim DAcliente As New Datos.Cliente
    Public cliente_id As Integer
    Public form_procedencia As String = "alta"
    Public apertura As String = "menu_alta" 'esta variable me sirve para saber desde donde lo abro, si lo abro a la "Alta" desde el menu...el boton cancelar...solo borra lo q se escribe en los textbox.
    Private Sub Cliente_alta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        tx_Fan.Focus()
        tx_Fan.TextAlign = HorizontalAlignment.Center
        tb_Dni_Cuit.TextAlign = HorizontalAlignment.Center
        ' tb_Dni_Cuit.MaxLength = 8
        tx_dir.TextAlign = HorizontalAlignment.Center
        tx_tel.TextAlign = HorizontalAlignment.Center
        'Habilitar()
        Obtener_provincias()
        Obtener_Iva()
        If form_procedencia = "modificar" Then
            recuperar_datos_cliente()
            tb_Dni_Cuit.ReadOnly = True
        End If
    End Sub


    Private Sub recuperar_datos_cliente()
        Dim ds_clie_recu As DataSet = DAcliente.Cliente_obtener_info(cliente_id)
        If ds_clie_recu.Tables(1).Rows.Count <> 0 Then
            tx_Fan.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_Fan")
            tb_Dni_Cuit.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_dni")
            Combo_Iva.SelectedValue = ds_clie_recu.Tables(1).Rows(0).Item("CLI_tipoiva")
            tx_tel.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_tel")
            tx_dir.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_dir")
            tx_Cp.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_CP")
            combo_Prov.SelectedValue = ds_clie_recu.Tables(1).Rows(0).Item("CLI_Id_Prov")
            Combo_Loc.SelectedValue = ds_clie_recu.Tables(1).Rows(0).Item("localidad_id")
            tx_mail.Text = ds_clie_recu.Tables(1).Rows(0).Item("CLI_mail")
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
        tx_Fan.Text = Nothing
        tb_Dni_Cuit.Text = Nothing
        tx_tel.Text = Nothing
        tx_dir.Text = Nothing
        tx_Cp.Text = Nothing
        tx_mail.Text = Nothing
        tx_Fan.Focus()
        form_procedencia = "alta"
        error_razonsocial.Visible = False
        error_dni.Visible = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Public FormProc As String

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If form_procedencia = "alta" Then
            Alta()
        End If
        If form_procedencia = "modificar" Then
            Modificar()
        End If
    End Sub

    Private Sub Modificar()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar el Cliente?", "Sistema de Gestión", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            DAcliente.Cliente_Modificar(cliente_id, tx_Fan.Text, tb_Dni_Cuit.Text, Combo_Iva.SelectedValue, tx_tel.Text, tx_dir.Text, tx_Cp.Text, combo_Prov.SelectedValue, Combo_Loc.SelectedValue, tx_mail.Text)
            Venta_Caja_gestion.Obtener_Clientes()
            MessageBox.Show("El Cliente se modificó correctamente.", "Sistema de Gestión")
            Cliente_modificar.Obtener_Clientes()
            Me.Close()
            Cliente_modificar.Close()
            Cliente_modificar.Show()
        End If
        limpiar_deshabilitar()
    End Sub


    Private Sub alta()
        If tb_Dni_Cuit.Text <> "" And tx_Fan.Text <> "" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea dar de alta al Cliente?", "Sistema de Gestión", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then


                Dim ds_CLI_dni As DataSet = DAcliente.Cliente_VerificarDni(tb_Dni_Cuit.Text)
                With ds_CLI_dni.Tables(0).Rows
                    If .Count = 0 Then
                        DAcliente.Cliente_Alta_new(tx_Fan.Text, tb_Dni_Cuit.Text, Combo_Iva.SelectedValue, tx_tel.Text, tx_dir.Text, tx_Cp.Text, combo_Prov.SelectedValue, Combo_Loc.SelectedValue, tx_mail.Text)
                        Venta_Caja_gestion.Obtener_Clientes()
                        Cliente_modificar.Obtener_Clientes()
                        MessageBox.Show("El Cliente fue dado de alta correctamente.", "Sistema de Gestión")
                        'aqui veo si cierro el form y abro modificar, o blanqueo todo y sigo agregando
                        If apertura = "menu_alta" Then
                            limpiar_deshabilitar()
                        End If
                        If apertura = "formulario modificar" Then
                            Me.Close()
                            Cliente_modificar.Close()
                            Cliente_modificar.Show()
                        End If
                    Else
                        MessageBox.Show("Error, el Cliente ya existe.", "Sistema de Gestión.")
                        tb_Dni_Cuit.Focus()
                        tb_Dni_Cuit.SelectAll()
                    End If
                End With
            End If
        Else
            MessageBox.Show("Error, Ingrese los campos obligatorios", "Sistema de Gestión.")
            error_razonsocial.Visible = True
            error_dni.Visible = True

        End If


        If FormProc = "Mesas_Asignar" Then
            Mesa_asignar.Obtener_Clientes()
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
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

    
    Private Sub tx_tel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_tel.KeyPress
        validaciones.Restricciones_textbox(e, "Celular", tx_tel)
    End Sub


    Private Sub tx_Cp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Cp.KeyPress
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
    Private Sub combo_Prov_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_Prov.SelectedIndexChanged
        If idprov <> 0 Then
            idprov = combo_Prov.SelectedValue
            Obtener_localidades_x_provincias()
        End If
    End Sub

    'Private Sub tb_Dni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Dni.KeyPress
    '    validaciones.Restricciones_textbox(e, "DNI/CUIT", tb_Dni)

    'End Sub



    

    Private Sub tx_Fan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Fan.GotFocus
        tx_Fan.SelectAll()
        tx_Fan.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tx_Fan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Fan.LostFocus
        tx_Fan.BackColor = Color.White
    End Sub

    Private Sub tb_Dni_Cuit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Dni_Cuit.GotFocus
        tb_Dni_Cuit.SelectAll()
        tb_Dni_Cuit.BackColor = Color.FromArgb(255, 255, 192)
    End Sub
    Private Sub tb_Dni_Cuit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Dni_Cuit.LostFocus
        tb_Dni_Cuit.BackColor = Color.White
    End Sub

    Private Sub Combo_Iva_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Iva.GotFocus
        Combo_Iva.SelectAll()
        Combo_Iva.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub Combo_Iva_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Iva.LostFocus
        Combo_Iva.BackColor = Color.White
    End Sub

    Private Sub tx_tel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_tel.GotFocus
        tx_tel.SelectAll()
        tx_tel.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tx_tel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_tel.LostFocus
        tx_tel.BackColor = Color.White
    End Sub

    Private Sub tx_dir_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_dir.GotFocus
        tx_dir.SelectAll()
        tx_dir.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tx_dir_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_dir.LostFocus
        tx_dir.BackColor = Color.White
    End Sub

    Private Sub tx_Cp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Cp.GotFocus
        tx_Cp.SelectAll()
        tx_Cp.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    

    Private Sub tx_Cp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Cp.LostFocus
        tx_Cp.BackColor = Color.White
    End Sub

    Private Sub combo_Prov_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Prov.GotFocus
        combo_Prov.SelectAll()
        combo_Prov.BackColor = Color.FromArgb(255, 255, 192)
    End Sub
    Private Sub combo_Prov_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Prov.LostFocus
        combo_Prov.BackColor = Color.White
    End Sub

    Private Sub Combo_Loc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Loc.GotFocus
        Combo_Loc.SelectAll()
        Combo_Loc.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub Combo_Loc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Loc.LostFocus
        Combo_Loc.BackColor = Color.White
    End Sub

    Private Sub tx_mail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_mail.GotFocus
        tx_mail.SelectAll()
        tx_mail.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tx_mail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_mail.LostFocus
        tx_mail.BackColor = Color.White
    End Sub

End Class