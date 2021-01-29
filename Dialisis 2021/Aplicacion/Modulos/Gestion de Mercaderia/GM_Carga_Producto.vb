Public Class GM_Carga_Producto
    Dim DAsuc As New Datos.Sucursal
    Dim DAprod As New Datos.Producto
    Dim DAlote As New Datos.Lote
    Dim ds_PROD As DataSet
    Dim validaciones As New Validaciones

    Private Sub GM_Carga_Producto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then 'F1
            'Busqueda_Productos.Close() 'lo cierro primero, ya que se usa en diferentes modulos
            'Busqueda_Productos.form_procedencia = "GM_Carga_Producto"
            'Busqueda_Productos.sucursal_id = CInt(Gestion_Mercaderia.cb_origen.SelectedValue)

            'Busqueda_Productos.Text = "Sucursal: " + tb_origen.Text + " - Busqueda de productos"
            'Busqueda_Productos.Show()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub GM_Carga_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Gestion_Mercaderia.cb_Movimiento.SelectedItem <> "Movimiento Entre Sucursales" Then
            lbl_cant_dest.Visible = False
            lbl_destino.Visible = False
            tb_cant_dest.Visible = False
            tb_destino.Visible = False
            If Gestion_Mercaderia.cb_Movimiento.SelectedItem = "Alta de Mercaderia" Then
                lbl_cant.Text = "Cantidad a Ingresar"
            Else
                lbl_cant.Text = "Cantidad a Quitar"
            End If
        End If
        tb_destino.Text = Gestion_Mercaderia.cb_destino.Text
        tb_origen.Text = Gestion_Mercaderia.cb_origen.Text
        tb_codint.Focus()
    End Sub
    Public Sub Buscar_Cantidades(ByVal prod_id As Integer, ByVal suc_id_Origen As Integer, ByVal suc_id_destino As Integer)
        Dim Ds_Suc As DataSet
        Ds_Suc = DAsuc.Sucursal_obtener_producto(prod_id, suc_id_Origen, suc_id_destino)
        tb_cant_Or.Text = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen")
        tb_cant_dest.Text = Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino")
    End Sub
    Private Sub tb_codint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_codint.KeyPress
        validaciones.Restricciones_textbox(e, "Entero", tb_codint)
        If e.KeyChar = ChrW(Keys.Enter) And e.Handled = False Then
            ds_PROD = DAprod.Producto_buscarcod(tb_codint.Text)
            If ds_PROD.Tables(0).Rows.Count <> 0 Then
                tb_desc.Text = ds_PROD.Tables(0).Rows(0).Item("prod_descripcion")
                Buscar_Cantidades(ds_PROD.Tables(0).Rows(0).Item("prod_id"), Gestion_Mercaderia.cb_origen.SelectedValue, Gestion_Mercaderia.cb_destino.SelectedValue)



                '//////////////////esto hago si el movimiento es alta de marcaderia///////////////////////////////////////////////

                If Gestion_Mercaderia.cb_Movimiento.Text = "Alta de Mercaderia" Then
                    Grupo_lote.Enabled = True
                    If ds_PROD.Tables(2).Rows.Count = 0 Then 'recupera el producto solo si tiene Lote = "SI"
                        'si es distinto de 0, significa que tiene lotes que se van a colocar incrementales, es decir NO
                        Dim ds_lotes As DataSet = DAlote.Lote_buscar_producto(tb_codint.Text, Gestion_Mercaderia.cb_origen.SelectedValue)
                        If ds_lotes.Tables(0).Rows.Count = 0 Then
                            'como no tengo lotes, creo el primer lote en 1
                            Dim nrolote_de_bd As Integer = 0
                            'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                            Dim i As Integer = 0
                            While i < Gestion_Mercaderia.DataGridView1.Rows.Count
                                If Gestion_Mercaderia.DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = tb_codint.Text Then
                                    nrolote_de_bd = CInt(Gestion_Mercaderia.DataGridView1.Rows(i).Cells("Lote").Value)
                                End If
                                i = i + 1
                            End While
                            nrolote_de_bd = nrolote_de_bd + 1
                            txt_nrolote.Text = nrolote_de_bd
                        Else
                            'como tengo varios lotes, busco el ultimo e incremento en 1.
                            Dim nrolote_de_bd As Integer = CInt(ds_lotes.Tables(0).Rows(ds_lotes.Tables(0).Rows.Count - 1).Item("lote_nro"))
                            'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                            Dim i As Integer = 0
                            While i < Gestion_Mercaderia.DataGridView1.Rows.Count
                                If Gestion_Mercaderia.DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = tb_codint.Text Then
                                    nrolote_de_bd = CInt(Gestion_Mercaderia.DataGridView1.Rows(i).Cells("Lote").Value)
                                End If
                                i = i + 1
                            End While
                            nrolote_de_bd = nrolote_de_bd + 1
                            txt_nrolote.Text = nrolote_de_bd
                        End If
                        txt_nrolote.Enabled = False
                        Label8.Text = "Ingreso Nº:"
                    Else
                        txt_nrolote.Enabled = True
                        Label8.Text = "Lote Nº:"
                    End If
                End If
                '/////////////////////////////////////////////////////////////////////////////////////////////////////
            Else
                MessageBox.Show("El producto no existe.", "Sistema de Gestión.")
                limpiar()
            End If
        End If
    End Sub

    Private Sub limpiar()
        tb_cant_dest.Text = Nothing
        tb_Cant_Movi.Text = Nothing
        tb_cant_Or.Text = Nothing
        tb_codint.Text = Nothing
        tb_desc.Text = Nothing
        txt_nrolote.Text = Nothing
        DateTimePicker_ffabricacion.Value = Today
        DateTimePicker_fvencimiento.Value = Today
        CheckBox_vto.Checked = False
        Grupo_lote.Enabled = False

    End Sub
    

    Private Sub tb_codint_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_codint.GotFocus
        tb_codint.SelectAll()
        tb_codint.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_codinterno.Visible = True
    End Sub

    Private Sub tb_codint_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_codint.LostFocus
        tb_codint.BackColor = Color.White
        'RectangleShape_codinterno.Visible = False
    End Sub

    Private Sub tb_desc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_desc.GotFocus
        tb_desc.SelectAll()
        tb_desc.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_descripcion.Visible = True
    End Sub

    Private Sub tb_desc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_desc.LostFocus
        tb_desc.BackColor = Color.White
        'RectangleShape_descripcion.Visible = False
    End Sub
    Private Sub tb_Cant_Movi_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Cant_Movi.GotFocus
        tb_Cant_Movi.SelectAll()
        tb_Cant_Movi.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_transferir.Visible = True
    End Sub
    Private Sub tb_Cant_Movi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Cant_Movi.KeyPress
        Dim tipo As String = "Decimal"
        validaciones.Restricciones_textbox(e, tipo, tb_Cant_Movi)
    End Sub
    Private Sub tb_Cant_Movi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Cant_Movi.LostFocus
        tb_Cant_Movi.BackColor = Color.White
        'RectangleShape_transferir.Visible = False
    End Sub

    Private Sub tb_origen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_origen.TextChanged

    End Sub

    Private Sub CheckBox_vto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_vto.Click
        If CheckBox_vto.Checked = True Then
            DateTimePicker_ffabricacion.Enabled = True
            DateTimePicker_fvencimiento.Enabled = True
        Else
            DateTimePicker_ffabricacion.Enabled = False
            DateTimePicker_fvencimiento.Enabled = False
        End If
    End Sub

    'Private Sub btn_agregarr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregarr.Click

    '    If tb_codint.Text <> "" Then

    '        If txt_nrolote.Text <> "" Then
    '            'primero valido que el nro de lote no exista en la lista o bien en la base de datos
    '            Dim existe As String = "no"
    '            Dim ds_lote As DataSet = DAlote.Lote_buscar_validar(Gestion_Mercaderia.cb_origen.SelectedValue, CInt(tb_codint.Text), txt_nrolote.Text)
    '            If ds_lote.Tables(0).Rows.Count <> 0 Then
    '                Dim result As Integer = MessageBox.Show("Ya existen unidades en stock con Nº lote: " + txt_nrolote.Text + ". ¿Desea agregar de todos modos?", "Sistema de Gestión.", MessageBoxButtons.YesNo)
    '                If result = DialogResult.Yes Then
    '                    existe = "no"
    '                ElseIf result = DialogResult.No Then
    '                    existe = "si"
    '                End If
    '            Else
    '                'si no existe en bd lo busco en la grilla donde voy agregando los lotes.
    '                Dim i As Integer = 0

    '                While i < Gestion_Mercaderia.DataGridView1.Rows.Count
    '                    If Gestion_Mercaderia.DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = tb_codint.Text And Gestion_Mercaderia.DataGridView1.Rows(i).Cells("Lote").Value = txt_nrolote.Text Then
    '                        existe = "si"
    '                        Exit While
    '                    End If
    '                    i = i + 1
    '                End While
    '                If existe = "si" Then
    '                    txt_nrolote.SelectAll()
    '                    txt_nrolote.Focus()
    '                    MessageBox.Show("El Nº de lote ya se encuentra en la lista. Por favor modifique.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                End If
    '            End If

    '            If existe = "no" Then
    '                If tb_desc.Text <> "" Then

    '                    If tb_Cant_Movi.Text <> "" Then
    '                        'If CInt(tb_Cant_Movi.Text) <= CInt(tb_cant_Or.Text) And CInt(tb_Cant_Movi.Text) <> 0 Then

    '                        Dim item As Integer
    '                        If Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Count = 0 Then
    '                            item = 1
    '                        Else
    '                            item = Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Count + 1
    '                        End If

    '                        Dim newCustomersRow As DataRow = Gestion_Mercaderia.Mov_DS.Tables("Mov").NewRow()
    '                        newCustomersRow("N°") = item
    '                        newCustomersRow("Cod_prod") = tb_codint.Text
    '                        newCustomersRow("Descripcion") = tb_desc.Text + " (Nº: " + txt_nrolote.Text + ")"
    '                        newCustomersRow("Desde") = tb_origen.Text
    '                        newCustomersRow("Hacia") = tb_destino.Text
    '                        newCustomersRow("Cantidad") = tb_Cant_Movi.Text
    '                        newCustomersRow("Lote") = txt_nrolote.Text
    '                        If CheckBox_vto.Checked = True Then
    '                            newCustomersRow("Vence") = "si"
    '                            newCustomersRow("FechaFabricacion") = DateTimePicker_ffabricacion.Value
    '                            newCustomersRow("FechaVencimiento") = DateTimePicker_fvencimiento.Value
    '                        Else

    '                            newCustomersRow("Vence") = "no"
    '                        End If
    '                        Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Add(newCustomersRow)
    '                        Gestion_Mercaderia.DataGridView1.DataSource = Gestion_Mercaderia.Mov_DS.Tables("Mov")

    '                        'bloque origen y destino combos en form gestion_mercaderia
    '                        Gestion_Mercaderia.cb_origen.Enabled = False
    '                        Gestion_Mercaderia.cb_destino.Enabled = False

    '                        Dim result As Integer = MessageBox.Show("¿Desea agregar más productos a el listado?.", "Sistema de Gestión.", MessageBoxButtons.YesNo)
    '                        If result = DialogResult.Yes Then
    '                            limpiar()
    '                        ElseIf result = DialogResult.No Then
    '                            Me.Close()
    '                        End If
    '                        'Else
    '                        '    MessageBox.Show("La cantidad debe ser menor a el stock disponible en la sucursal de origen", "Sistema de Gestion.")
    '                        '    tb_Cant_Movi.Focus()
    '                        'End If
    '                    Else
    '                        MessageBox.Show("Debe ingresar la cantidad.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        tb_Cant_Movi.Focus()
    '                    End If
    '                Else
    '                    MessageBox.Show("Debe seleccionar un producto", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    tb_codint.Focus()
    '                End If
    '            End If
    '        Else
    '            txt_nrolote.SelectAll()
    '            txt_nrolote.Focus()
    '            MessageBox.Show("Ingrese un Nº de lote.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End If

    '    Else
    '        tb_codint.SelectAll()
    '        tb_codint.Focus()
    '        MessageBox.Show("Indique que producto desea agregar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If

    'End Sub

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        Busqueda_Productos.Close() 'lo cierro primero, ya que se usa en diferentes modulos
        Busqueda_Productos.form_procedencia = "GM_Carga_Producto"
        Busqueda_Productos.sucursal_id = CInt(Gestion_Mercaderia.cb_origen.SelectedValue)

        Busqueda_Productos.Text = "Sucursal: " + tb_origen.Text + " - Busqueda de productos"
        Busqueda_Productos.Show()
    End Sub
End Class