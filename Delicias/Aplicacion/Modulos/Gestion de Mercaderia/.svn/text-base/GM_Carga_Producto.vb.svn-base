Public Class GM_Carga_Producto
    Dim DAsuc As New Datos.Sucursal
    Dim DAprod As New Datos.Producto
    Dim ds_PROD As DataSet
    Dim validaciones As New Validaciones

    Private Sub GM_Carga_Producto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then 'F1
            Busqueda_Productos.Close() 'lo cierro primero, ya que se usa en diferentes modulos
            Busqueda_Productos.form_procedencia = "GM_Carga_Producto"
            Busqueda_Productos.Text = "Sucursal: " + tb_origen.Text + " - Busqueda de productos"
            Busqueda_Productos.Show()
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
    End Sub
    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        If tb_desc.Text <> "" Then

            If tb_Cant_Movi.Text <> "" Then
                'If CInt(tb_Cant_Movi.Text) <= CInt(tb_cant_Or.Text) And CInt(tb_Cant_Movi.Text) <> 0 Then

                Dim item As Integer
                If Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Count = 0 Then
                    item = 1
                Else
                    item = Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Count + 1
                End If

                Dim newCustomersRow As DataRow = Gestion_Mercaderia.Mov_DS.Tables("Mov").NewRow()
                newCustomersRow("N°") = item
                newCustomersRow("Cod_prod") = tb_codint.Text
                newCustomersRow("Descripcion") = tb_desc.Text
                newCustomersRow("Desde") = tb_origen.Text
                newCustomersRow("Hacia") = tb_destino.Text
                newCustomersRow("Cantidad") = tb_Cant_Movi.Text
                Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Add(newCustomersRow)
                Gestion_Mercaderia.DataGridView1.DataSource = Gestion_Mercaderia.Mov_DS.Tables("Mov")

                Dim result As Integer = MessageBox.Show("¿Desea agregar más productos a el listado?.", "Sistema de Gestión.", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    limpiar()
                ElseIf result = DialogResult.No Then
                    Me.Close()
                End If
                'Else
                '    MessageBox.Show("La cantidad debe ser menor a el stock disponible en la sucursal de origen", "Sistema de Gestion.")
                '    tb_Cant_Movi.Focus()
                'End If
            Else
                MessageBox.Show("Debe ingresar la cantidad.", "Sistema de Gestión.")
                tb_Cant_Movi.Focus()
            End If
        Else
            MessageBox.Show("Debe seleccionar un producto", "Sistema de Gestión.")
            tb_codint.Focus()
        End If


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
        RectangleShape_transferir.Visible = True
    End Sub
    Private Sub tb_Cant_Movi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Cant_Movi.KeyPress
        Dim tipo As String = "Decimal"
        validaciones.Restricciones_textbox(e, tipo, tb_Cant_Movi)
    End Sub
    Private Sub tb_Cant_Movi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Cant_Movi.LostFocus
        tb_Cant_Movi.BackColor = Color.White
        RectangleShape_transferir.Visible = False
    End Sub
End Class