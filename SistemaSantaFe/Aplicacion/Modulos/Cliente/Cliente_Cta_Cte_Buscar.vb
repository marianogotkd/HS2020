Imports System.IO
Imports System.Data.OleDb
Public Class Cliente_Cta_Cte_Buscar
    Dim DActacte As New Datos.CuentaCorriente
    Dim DAcliente As New Datos.Cliente

    Dim busqueda As String = ""
    Dim busqueda_parametro As String = ""
    Dim ds_clie As DataSet
    Dim ds_CtaCte_Mov As DataSet

    Private Sub Cliente_Cta_Cte_Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_total_deuda.ReadOnly = True
        Obtener_Clientes()
        Obtener_provincias()
        Obtener_Iva()
        TabPage2.Parent = Nothing 'oculto pestaña 1
    End Sub

    Public Sub Obtener_Clientes()
        ds_clie = DActacte.CtaCte_obtenertodo_Clientes()
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            Cliente_ds.Tables("Cliente_CtaCte").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Cliente_ds.Tables("Cliente_CtaCte").Merge(ds_clie.Tables(0)) '' al combinarla con el dataset "cliente" ya puedo filtrar
            'DG_clientes.DataSource = ds_clie.Tables(0)
            'DG_clientes_old.DataSource = ds_clie.Tables(0)
        End If
    End Sub

    Private Sub BO_cliente_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DG_clientes.Rows.Count <> 0 Then
            Dim productoselec As String = DG_clientes.SelectedCells(0).Value
            If productoselec <> "" Then
                Cliente_alta_New.Close() 'lo cierro porque uso el mismo form para dar de alta

                Cliente_alta_New.Text = "Modificar cliente"
                'Proveedor_alta.Text = "Modificar proveedor"
                Cliente_alta_New.cliente_id = CInt(productoselec)
                'Proveedor_alta.proveedor_id = CInt(productoselec)
                Cliente_alta_New.form_procedencia = "modificar"
                Cliente_alta_New.tx_Fan.Text = DG_clientes.SelectedCells(1).Value
                'Proveedor_alta.tx_nombre.Text = DataGrid_proveedor.SelectedCells(2).Value
                Me.Close()
                Cliente_alta_New.apertura = "formulario modificar" 'para q valide el boton cancelar del form alta
                Cliente_alta_New.Show()
            Else
                MsgBox("Seleccione un cliente", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un cliente", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBox1_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.SelectAll()
        TextBox1.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "CLI_Fan", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        ClienteCtaCteBindingSource.Filter = Filtro
        If DG_clientes.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(CtaCte_id, System.String) LIKE '%{0}%'", TextBox1.Text)
            ClienteCtaCteBindingSource.Filter = Filtro
            If DG_clientes.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(CLI_dni, System.String) LIKE '%{0}%'", TextBox1.Text)
                ClienteCtaCteBindingSource.Filter = Filtro
            End If
        End If
    End Sub


    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    Public Sub Obtener_Movimientos()
        Cliente_ds.Tables("Detalle_CtaCte").Rows.Clear() 'siempre lo voy a borrar, x que se juntan los valores de varias ctacte
        Dim i = 0
        Dim debe As Decimal = (Math.Round(CDec(0), 2).ToString("N2"))
        Dim haber As Decimal = (Math.Round(CDec(0), 2).ToString("N2"))
        Dim Saldo As Decimal = (Math.Round(CDec(0), 2).ToString("N2"))

        ds_CtaCte_Mov = DActacte.CtaCte_Obtener_Movimientos(DG_clientes.SelectedCells(0).Value)

        If ds_CtaCte_Mov.Tables(0).Rows.Count <> 0 Then
            txt_total_deuda.Text = ds_CtaCte_Mov.Tables(0).Rows(0).Item("CtaCte_total").ToString
            'lbl_total.Text = ds_CtaCte_Mov.Tables(0).Rows(0).Item("CtaCte_total").ToString
            'limite.Text = ds_CtaCte_Mov.Tables(0).Rows(0).Item("CtaCte_limitedeuda").ToString
            While i < ds_CtaCte_Mov.Tables(0).Rows.Count
                debe = CDec(0)
                haber = CDec(0)
                Dim newCustomersRow As DataRow = Cliente_ds.Tables("Detalle_CtaCte").NewRow()
                newCustomersRow("MovimientosCtaCte_fecha") = ds_CtaCte_Mov.Tables(0).Rows(i).Item("MovimientosCtaCte_fecha")
                newCustomersRow("MovimientosCtaCte_concepto") = ds_CtaCte_Mov.Tables(0).Rows(i).Item("MovimientosCtaCte_concepto")
                If ds_CtaCte_Mov.Tables(0).Rows(i).Item("MovimientosCtaCte_tipo").ToString = "Ingreso" Then
                    newCustomersRow("debe") = ds_CtaCte_Mov.Tables(0).Rows(i).Item("MovimientosCtaCte_monto")
                    newCustomersRow("haber") = (Math.Round(CDec(0), 2).ToString("N2"))
                    debe = ds_CtaCte_Mov.Tables(0).Rows(i).Item("MovimientosCtaCte_monto")
                Else
                    newCustomersRow("haber") = ds_CtaCte_Mov.Tables(0).Rows(i).Item("MovimientosCtaCte_monto")
                    newCustomersRow("debe") = (Math.Round(CDec(0), 2).ToString("N2"))
                    haber = ds_CtaCte_Mov.Tables(0).Rows(i).Item("MovimientosCtaCte_monto")
                End If
                i = i + 1
                Saldo = Saldo + debe - haber
                newCustomersRow("saldo") = Saldo
                Cliente_ds.Tables("Detalle_CtaCte").Rows.Add(newCustomersRow)
            End While
            DG_Detalle.DataSource = Cliente_ds.Tables("Detalle_CtaCte")
        Else
            txt_total_deuda.Text = CDec(0) 'no posee deuda.
            'lbl_total.Text = CDec(0) 'no posee deuda.
        End If
    End Sub
    Private Sub BO_cliente_modificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_modificar.Click
        If DG_clientes.Rows.Count <> 0 Then
            '///////esto para mostrar datos del cliente/////////
            Dim clie_id As Integer = DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value
            recuperar_datos_cliente(CInt(DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value))
            tx_Fan.Focus()
            tb_Dni_Cuit.ReadOnly = True
            txt_ctacte.ReadOnly = True
            '/////////////////////////FIN///////////////////////////////
            Obtener_Movimientos()
            TabPage1.Parent = Nothing 'oculto pestaña 1
            TabPage2.Parent = TabControl1 'pongo visible pestaña 2
            TabControl1.SelectedTab = TabPage2
        Else
            MessageBox.Show("Error, debe seleccionar una cuenta corriente.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

#Region "Pestaña resumen de cuenta corriente"
    Dim ds_iva As DataSet
    Public Sub Obtener_Iva()
        ds_iva = DAcliente.Obterner_Iva()
        Combo_Iva.DataSource = ds_iva.Tables(0)
        Combo_Iva.DisplayMember = "IVA_Descripcion"
        Combo_Iva.ValueMember = "IVA_id"

    End Sub
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
    Private Sub combo_Prov_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Prov.SelectedIndexChanged
        If idprov <> 0 Then
            idprov = combo_Prov.SelectedValue
            Obtener_localidades_x_provincias()
        End If
    End Sub
    Dim validaciones As New Validaciones
    Private Sub txt_limitedeuda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_limitedeuda.KeyPress
        Validaciones.Restricciones_textbox(e, "Decimal", txt_limitedeuda)
    End Sub
    Private Sub tx_tel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_tel.KeyPress
        validaciones.Restricciones_textbox(e, "Celular", tx_tel)
    End Sub
    Private Sub tx_Cp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Cp.KeyPress
        validaciones.Restricciones_textbox(e, "Entero", tx_Cp)
    End Sub
    Private Sub CheckBox_estado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_estado.CheckedChanged
        If CheckBox_estado.Checked = True Then
            CheckBox_estado.ForeColor = Color.Green
            CheckBox_estado.Text = "Activo"
        Else
            CheckBox_estado.ForeColor = Color.Red
            CheckBox_estado.Text = "Inactivo"
        End If
    End Sub
    Private Sub recuperar_datos_cliente(ByVal cliente_id As Integer)
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

            'si tiene cuenta corriente cargamos los datos, solo se podra modificar el limite de deuda. choco: 02-12-2019.
            If ds_clie_recu.Tables(2).Rows.Count <> 0 Then
                'CheckBox_habilitar_ctacte.Checked = True
                'CheckBox_habilitar_ctacte.Enabled = False
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

    Private Sub limpiar_cliente()
        txt_ctacte.Text = Nothing
        tx_Fan.Text = Nothing
        tb_Dni_Cuit.Text = Nothing
        tx_tel.Text = Nothing
        tx_dir.Text = Nothing
        tx_Cp.Text = Nothing
        tx_mail.Text = Nothing
        tx_Fan.Focus()
        txt_limitedeuda.Text = 0
        CheckBox_estado.Checked = False
        error_razonsocial.Visible = False
        error_dni.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_volver.Click
        'limpio los datos del cliente, del groupbox3
        limpiar_cliente()
        Obtener_Clientes() 'vuelvo a ejecturar la rutina, puede q se modificara la info de la grilla.
        TabControl1.SelectedTab = TabPage1
        TabPage2.Parent = Nothing 'oculto pa segunda pestaña
        TabPage1.Parent = TabControl1 'pongo visible la pestaña 1
    End Sub
    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar los datos del cliente?", "Sistema de Gestión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim cliente_id As Integer = CInt(DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value)
            DAcliente.Cliente_Modificar(cliente_id, tx_Fan.Text, tb_Dni_Cuit.Text, Combo_Iva.SelectedValue, tx_tel.Text, tx_dir.Text, tx_Cp.Text, combo_Prov.SelectedValue, Combo_Loc.SelectedValue, tx_mail.Text)

            'ahora veo si doy de alta una cta cte o bien modifico una existente ligada a un cliente.
            'If CheckBox_habilitar_ctacte.Checked = True Then
            Dim ds_ctacte As DataSet = DActacte.CtaCte_buscar_id(CInt(txt_ctacte.Text))
            If ds_ctacte.Tables(0).Rows.Count = 0 Then
                'no existe, doy de alta
                'If txt_limitedeuda.Text = "" Then
                '    txt_limitedeuda.Text = "0"
                'End If
                'DActacte.CteCte_alta(cliente_id, Now, CDec(0), CDec(txt_limitedeuda.Text))
            Else
                'existe, entonces modifico.
                If txt_limitedeuda.Text = "" Then
                    txt_limitedeuda.Text = "0"
                End If
                DActacte.CtaCte_modificar(CInt(txt_ctacte.Text), CheckBox_estado.Text, CDec(txt_limitedeuda.Text))
            End If
            'End If
            MessageBox.Show("El Cliente se modificó correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Dim APcaja As New Aplicacion.Caja 'la uso para validar la apertura de caja entre otras cosas
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'validar que la caja actual este abierta, para registrar el pago.
        APcaja.Caja_Validar()
        If APcaja.SESION_CAJA = 1 And US_administrador.no_caja <> "deshabilitar" Then '1 = caja nueva, lista para iniciar
            MessageBox.Show("Error, primero debe abrir la caja diaria para registrar un pago.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If APcaja.SESION_CAJA = 2 And US_administrador.no_caja <> "deshabilitar" Then
                'por aqui continuo con el registro del pago
                CtaCte_pago.Close()
                CtaCte_pago.tx_total.Text = CDec(0)
                CtaCte_pago.Show()
                CtaCte_pago.tx_total.SelectAll()
                CtaCte_pago.tx_total.Focus()
            Else
                MessageBox.Show("Error, No puede registrar el pago, la caja actual esta siendo utilizada por el usuario: " + US_administrador.apellidoynombre, "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
#End Region

    Private Sub Button_ajustarsaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ajustarsaldo.Click
        CtaCte_ajustesaldo.Close()
        CtaCte_ajustesaldo.txt_cliente.Text = tx_Fan.Text
        CtaCte_ajustesaldo.txt_saldoactual.Text = (Math.Round(CDec(txt_total_deuda.Text), 2).ToString("N2"))
        'CtaCte_ajustesaldo.txt_saldoactual.Text = (Math.Round(CDec(lbl_total.Text), 2).ToString("N2"))
        CtaCte_ajustesaldo.txt_saldonuevo.Text = CDec(0)
        CtaCte_ajustesaldo.Show()
        CtaCte_ajustesaldo.txt_saldonuevo.SelectAll()
        CtaCte_ajustesaldo.txt_saldonuevo.Focus()

    End Sub

    Private Sub Button_comprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_comprobante.Click
        CtaCte_buscar_comprobantes.Close()
        CtaCte_buscar_comprobantes.ctacte_id = CInt(txt_ctacte.Text)
        CtaCte_buscar_comprobantes.lb_ctacte_nro.Text = "Cuenta Corriente Nº: " + CStr(txt_ctacte.Text)
        CtaCte_buscar_comprobantes.Show()
    End Sub
End Class