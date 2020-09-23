Imports System.IO
Imports System.Data.OleDb
Public Class Cliente_modificar
    Dim DAcliente As New Datos.Cliente

    Dim busqueda As String = ""
    Dim busqueda_parametro As String = ""

    Private Sub Cliente_modificar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Obtener_Clientes()

        'Me.Show()
        'TX_ape.Focus()

        'TX_ape.TextAlign = HorizontalAlignment.Center
        'TX_doc.TextAlign = HorizontalAlignment.Center
        'TX_doc.MaxLength = 8

        'BO_doc.Enabled = False
        'BO_Cargar.Enabled = False

        'GP_Cliente.Enabled = False
        ''tx_ape_clie.Enabled = False
        ''tx_nom_clie.Enabled = False
        ''tx_dni_clie.Enabled = False

        'BO_Guardar.Enabled = False
        'BO_Eliminar.Enabled = False
        'BO_Cancelar.Enabled = True
    End Sub

    '--------choco 19-10-2018---------
    Dim ds_clie As DataSet
    'recupero todos los clientes

    Public Sub Obtener_Clientes()
        ds_clie = DAcliente.Cliente_obtenertodo()
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            Cliente_ds.Tables("Cliente1").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Cliente_ds.Tables("Cliente1").Merge(ds_clie.Tables(0)) '' al combinarla con el dataset "cliente" ya puedo filtrar
            'DG_clientes.DataSource = ds_clie.Tables(0)
            'DG_clientes_old.DataSource = ds_clie.Tables(0)
        End If
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.SelectAll()
        TextBox1.BackColor = Color.FromArgb(255, 255, 192)
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "CLI_Fan", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        Cliente1BindingSource.Filter = Filtro
    End Sub
    Private Sub BO_cliente_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_modificar.Click
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
    

    
    
    Private Sub BO_cliente_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_nuevo.Click
        Me.Close()
        Cliente_alta_New.Close() 'lo cierro antes, porque uso el mismo form para editar
        Cliente_alta_New.apertura = "formulario modificar"
        Cliente_alta_New.Show()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    '--------------------------------------











    ''CLIENTE BUSCAR ///////////////////////////////////////////////////////////////////////////////////////

    'Dim ds_CLI As DataSet

    'Private Sub TX_doc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    '    If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
    '        buscar_cliedni()
    '    End If
    'End Sub

    'Private Sub TX_ape_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    '    If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
    '        buscar_clieape()
    '    End If
    'End Sub

    'Private Sub TX_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TX_doc.Text = Nothing Then
    '        BO_doc.Enabled = False
    '    Else
    '        BO_doc.Enabled = True
    '    End If
    'End Sub

    'Private Sub BO_ape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    buscar_clieape()
    'End Sub
    'Public Sub buscar_clieape()
    '    ds_CLI = DAcliente.Cliente_ObtenerApe(TX_ape.Text)
    '    With ds_CLI.Tables(0).Rows
    '        If .Count > 0 Then
    '            DG_cliente.Enabled = True
    '            DG_cliente.DataSource = ds_CLI.Tables(0)
    '            IM_ERROR_cliente.Visible = False
    '            LB_ERROR_cliente.Visible = False
    '        Else
    '            DG_cliente.Enabled = False
    '            DG_cliente.DataSource = Nothing
    '            IM_ERROR_cliente.Visible = True
    '            LB_ERROR_cliente.Visible = True
    '        End If
    '    End With
    '    TX_doc.Text = Nothing
    'End Sub
    'Private Sub BO_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    buscar_cliedni()
    'End Sub
    'Public Sub buscar_cliedni()
    '    ds_CLI = DAcliente.Cliente_ObtenerDni(TX_doc.Text)
    '    With ds_CLI.Tables(0).Rows
    '        If .Count > 0 Then
    '            DG_cliente.Enabled = True
    '            DG_cliente.DataSource = ds_CLI.Tables(0)
    '            IM_ERROR_cliente.Visible = False
    '            LB_ERROR_cliente.Visible = False
    '        Else
    '            DG_cliente.Enabled = False
    '            DG_cliente.DataSource = Nothing
    '            IM_ERROR_cliente.Visible = True
    '            LB_ERROR_cliente.Visible = True
    '        End If
    '    End With
    '    TX_ape.Text = Nothing
    'End Sub

    'Private Sub DG_Cliente_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    If ((DG_cliente.CurrentRow Is Nothing) OrElse (DG_cliente.SelectedRows.Count <> 0)) And DG_cliente.Rows.Count > 0 Then
    '        BO_Cargar.Enabled = True
    '    Else
    '        BO_Cargar.Enabled = False
    '    End If
    'End Sub


    'Dim CLI_id As Integer
    'Private Sub BO_Jugador_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cargar.Click

    '    CLI_id = DG_cliente.SelectedRows(0).Cells("CLIidDataGridViewTextBoxColumn").Value.ToString

    '    Dim ds_CLI_Tabla As DataTable = ds_CLI.Tables(0)
    '    For Each row As DataRow In ds_CLI_Tabla.Rows
    '        If Convert.ToString(row("CLI_id")) = CLI_id Then
    '            tx_ape_clie.Text = Convert.ToString(row("CLI_ape"))
    '            tx_nom_clie.Text = Convert.ToString(row("CLI_nom"))
    '            tx_dni_clie.Text = Convert.ToString(row("CLI_dni"))
    '            DT_fecha.Value = Convert.ToString(row("CLI_fnac"))
    '            tx_tel_clie.Text = Convert.ToString(row("CLI_tel"))
    '            tx_mail_clie.Text = Convert.ToString(row("CLI_mail"))
    '            tx_obser.Text = Convert.ToString(row("CLI_observaciones"))

    '            GroupBox1.Enabled = False
    '            TabControl1.SelectedTab = TabPage2
    '            GP_Cliente.Enabled = True
    '            BO_Guardar.Enabled = True
    '            BO_Eliminar.Enabled = True
    '        End If
    '    Next
    'End Sub


    'Public Sub Verificar()
    '    Dim ds_CLI_dni As DataSet = DAcliente.Cliente_VerificarDni(tx_dni_clie.Text)
    '    With ds_CLI_dni.Tables(0).Rows
    '        If .Count = 0 Then
    '            tx_dni_clie.ForeColor = Color.Black
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


    'Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Guardar.Click
    '    Dim result As DialogResult
    '    result = MessageBox.Show("¿Desea Actualizar al Cliente?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
    '    If result = DialogResult.OK Then
    '        DAcliente.Cliente_Modificar(CLI_id, tx_ape_clie.Text, tx_nom_clie.Text, tx_dni_clie.Text, DT_fecha.Value, tx_tel_clie.Text, tx_mail_clie.Text, tx_obser.Text, ComboBox1.Text)
    '        limpiar_deshabilitar()
    '        Me.TabControl1.SelectedTab = TabPage1
    '        MessageBox.Show("El Cliente fue actualizado correctamente.", "Sistema de Gestion.")
    '        GroupBox1.Enabled = True
    '    End If
    'End Sub

    'Private Sub BO_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Eliminar.Click
    '    Dim result As DialogResult
    '    result = MessageBox.Show("¿Desea Eliminar al Cliente?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
    '    If result = DialogResult.OK Then
    '        DAcliente.Cliente_eliminar(CLI_id)
    '        limpiar_deshabilitar()
    '        Me.TabControl1.SelectedTab = TabPage1
    '        MessageBox.Show("El Cliente fue Eliminado correctamente.", "Sistema de Gestion.")
    '        GroupBox1.Enabled = True
    '    End If
    'End Sub

    'Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cancelar.Click
    '    limpiar_deshabilitar()
    '    Me.TabControl1.SelectedTab = TabPage1
    '    GroupBox1.Enabled = True
    'End Sub

    'Public Sub limpiar_deshabilitar()
    '    'datos personales///////////////////////////////////////////////////////////////////////////////////////////////////
    '    'botones de error

    '    BO_Guardar.Enabled = False
    '    BO_Eliminar.Enabled = False
    '    'datos personales
    '    tx_ape_clie.Text = Nothing
    '    tx_nom_clie.Text = Nothing
    '    tx_dni_clie.Text = Nothing
    '    tx_tel_clie.Text = Nothing
    '    tx_mail_clie.Text = Nothing
    '    TX_ape.Text = Nothing
    '    TX_doc.Text = Nothing
    '    DT_fecha.Value = Now
    '    tx_obser.Text = Nothing
    '    DG_cliente.DataSource = Nothing
    '    GP_Cliente.Enabled = False

    '    Me.Show()
    '    TX_ape.Focus()
    'End Sub

    'Private Sub tx_dni_clie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    'aqui pongo el codigo para remplazar el punto por una coma
    '    If e.KeyChar.ToString() = "." Then
    '        e.KeyChar = ","
    '    End If
    '    'a continuacion el codigo para impedir el ingreso de dos comas o letras
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False

    '        If Me.tx_dni_clie.Text <> "" Then
    '            If Me.tx_dni_clie.Text > 99999999 Then
    '                e.Handled = True
    '            End If
    '        End If

    '    Else
    '        If Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
    '                e.Handled = True
    '            End If


    '        End If
    '        If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub
End Class