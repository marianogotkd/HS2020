Imports System.IO
Imports System.Data.OleDb
Public Class Producto_alta_New
    Dim DAproducto As New Datos.Producto
    Dim DAcategoria As New Datos.Categoria
    Dim DAmarca As New Datos.Marca
    Dim DAproveedores As New Datos.Proveedor
    Dim DAlista As New Datos.Lista
    Dim ds_categoria As DataSet = DAcategoria.Categoria_obtener
    Dim ds_proveedor As DataSet
    Dim ds_prodcod As DataSet = DAproducto.Codinterno_obtener
    Dim ds_rubro As DataSet
    Dim ds_subrubro As DataSet
    Public codint As Integer
    Public form_procedencia As String = "alta"
    Dim Producto_ds As New Producto_ds
    Private Sub Producto_alta_New_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If form_procedencia = "modificar" Then
            cargar_combos()
            recuperar_datos() 'trae datos del producto  + categoria seleccionada + foto
            recuperar_datos_producto() 'recupera los proveedores asignados, y los carga en la grilla DataGridView_Prod_Prov
            Me.tx_codbarra.Focus()
            Me.tx_codbarra.SelectAll()
            'Bo_guardar.Enabled = False
            Clipboard.SetDataObject(Me.PictureBox1.Image)
        Else
            'guardo en portapapeles la imagen por defecto para los productos
            Clipboard.SetDataObject(Me.PictureBox1.Image)

            'If ds_prodcod.Tables(0).Rows.Count > 0 Then
            '    tx_codinterno.Text = ds_prodcod.Tables(0).Rows(0).Item(0) + 1
            'Else
            '    tx_codinterno.Text = "100"
            'End If

            Generar_cod_interno()
            cargar_combos()

            Bo_guardar.Enabled = False
        End If

        'tx_descripcion.Focus()
        'tx_descripcion.SelectAll()

    End Sub

    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAlista.ProductoCombo_validar()
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            tx_codinterno.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item(0) + 1
        Else
            tx_codinterno.Text = "100"
        End If
    End Sub

    Dim modif_categoriaID_inicial As Integer = 0
    Dim modif_rubroID_inicial As Integer = 0
    Dim modif_subrubro_inicial As Integer = 0
    Public Sub recuperar_datos()
        Dim ds_prod As New DataSet
        ds_prod = DAproducto.Productos_Obtener_Modificar(codint)
        tx_codinterno.Text = ds_prod.Tables(0).Rows(0).Item(6)
        tx_descripcion.Text = ds_prod.Tables(0).Rows(0).Item(1)
        tx_descrilarga.Text = ds_prod.Tables(0).Rows(0).Item(2).ToString
        tx_unimedida.Text = ds_prod.Tables(0).Rows(0).Item(11)
        tx_codbarra.Text = ds_prod.Tables(0).Rows(0).Item(7)
        tx_ptorepo.Text = ds_prod.Tables(0).Rows(0).Item(5)
        tx_stock.Text = ds_prod.Tables(0).Rows(0).Item(4)
        Tb_PrecMin.Text = ds_prod.Tables(0).Rows(0).Item(3)
        tb_PrecMay.Text = ds_prod.Tables(0).Rows(0).Item(14).ToString
        cb_marca.SelectedValue = ds_prod.Tables(0).Rows(0).Item(10)
        Combo_tipo.SelectedItem = ds_prod.Tables(0).Rows(0).Item(16)

        If ds_prod.Tables(0).Rows(0).Item(9) = 3 Then
            'modif_categoriaID_inicial = CInt(ds_prod.Tables(4).Rows(0).Item("Categoria_cat_id"))
            cb_categoria.SelectedValue = ds_prod.Tables(4).Rows(0).Item("Categoria_cat_id")
            'modif_rubroID_inicial = CInt(ds_prod.Tables(4).Rows(0).Item("Rubro_cat2_id"))
            cb_rubro.SelectedValue = ds_prod.Tables(4).Rows(0).Item("Rubro_cat2_id")
            'modif_subrubro_inicial = CInt(ds_prod.Tables(4).Rows(0).Item("Subrubro_cat3_id"))
            cb_subrubro.SelectedValue = ds_prod.Tables(4).Rows(0).Item("Subrubro_cat3_id")
            check_rubro.Checked = True
            check_subrubro.Checked = True
        Else
            If ds_prod.Tables(0).Rows(0).Item(9) = 2 Then
                'modif_categoriaID_inicial = CInt(ds_prod.Tables(3).Rows(0).Item("Categoria_cat_id"))
                cb_categoria.SelectedValue = ds_prod.Tables(3).Rows(0).Item("Categoria_cat_id")
                'modif_rubroID_inicial = CInt(ds_prod.Tables(3).Rows(0).Item("Rubro_cat2_id"))
                cb_rubro.SelectedValue = ds_prod.Tables(3).Rows(0).Item("Rubro_cat2_id")
                check_rubro.Checked = True
            Else
                'modif_categoriaID_inicial = CInt(ds_prod.Tables(2).Rows(0).Item("Categoria_cat_id"))
                cb_categoria.SelectedValue = ds_prod.Tables(2).Rows(0).Item("Categoria_cat_id")
            End If
        End If

        'recupero foto
        Dim arrImg As Byte() = DirectCast(ds_prod.Tables(1).Rows(0).Item("prod_foto"), Byte())
        Dim ms As New MemoryStream(arrImg)
        Dim img As Image = Image.FromStream(ms)
        PictureBox1.Image = img


    End Sub
    Public ds_producto_recuperado As New Producto_ds 'esto voy a usar para los ProveedorProducto
    Public Sub recuperar_datos_producto()

        Dim ds_producto As New DataSet
        ds_producto = DAproducto.Productos_Obtener_Modificar(codint)
        If ds_producto.Tables(0).Rows.Count <> 0 Then
            Proveedores_X_Producto.prod_id = ds_producto.Tables(0).Rows(0).Item("prod_id")

            Dim item As Integer = 0
            'Limpiar Dataset
            ds_producto_recuperado.Tables("ProveedorProducto").Clear()
            ''Cargo la grilla Proveedores_X_productos
            While item < ds_producto.Tables(0).Rows.Count
                Dim newCustomersRow As DataRow = ds_producto_recuperado.Tables("ProveedorProducto").NewRow()
                newCustomersRow("Prov_id") = ds_producto.Tables(0).Rows(item).Item("Prov_id")
                newCustomersRow("Prov_nombre") = ds_producto.Tables(0).Rows(item).Item("Prov_nombre")
                newCustomersRow("Prod_id") = ds_producto.Tables(0).Rows(item).Item("prod_id")
                newCustomersRow("Prod_descripcion") = ds_producto.Tables(0).Rows(item).Item("prod_descripcion")
                newCustomersRow("Prov_Prod_Com_fecha") = ds_producto.Tables(0).Rows(item).Item("Prov_Prod_Com_fecha")
                newCustomersRow("Prov_Prod_Com_precio") = ds_producto.Tables(0).Rows(item).Item("Prov_Prod_Com_precio")
                ds_producto_recuperado.Tables("ProveedorProducto").Rows.Add(newCustomersRow)
                'Proveedores_X_Producto.DG_Prov_Prod.DataSource = Producto_ds.Tables("ProveedorProducto")
                item = item + 1
            End While
            item = 1
            'Limpio la grilla
            DataGridView_Prod_Prov.DataSource = Nothing
            '' cargo la grilla Producto_Alta
            DataGridView_Prod_Prov.DataSource = ds_producto_recuperado.Tables("ProveedorProducto")
        End If

    End Sub

    Public Sub Cargar_categorias()
        ds_categoria = DAcategoria.Categoria_obtener
        'Carga la categoria
        If ds_categoria.Tables(0).Rows.Count <> 0 Then
            cb_categoria.DataSource = ds_categoria.Tables(0)
            cb_categoria.DisplayMember = "cat1_nom"
            cb_categoria.ValueMember = "cat_id"
            Dim cat_id As Integer = cb_categoria.SelectedValue
            'cb_categoria.SelectedValue = ds_categoria.Tables(0).Rows(0).Item("cat_id")
            categoriarubro_obtener()
            rubrosubrubro_obtener()
        End If

    End Sub


    Public Sub categoriarubro_obtener()
        If cat1_id <> 0 Then
            cat1_id = cb_categoria.SelectedValue 'se vuelve a seleccionar el actual
            ds_rubro = DAcategoria.Categoriarubro_obtener(cat1_id)
            If ds_rubro.Tables(0).Rows.Count <> 0 Then
                cb_rubro.DataSource = ds_rubro.Tables(0)
                cb_rubro.DisplayMember = "cat2_nom"
                cb_rubro.ValueMember = "cat2_id"
                cat2_id = cb_rubro.SelectedValue
                check_rubro.Enabled = True
            Else
                cb_rubro.DataSource = Nothing
                cat2_id = 0 'asigno recurso vacio
                check_rubro.Checked = False
                check_rubro.Enabled = False
            End If
        End If
    End Sub
    Dim cat1_id As Integer = 0
    Dim cat2_id As Integer = 0
    Public Sub cargar_combos()
        ds_categoria = DAcategoria.Categoria_obtener
        If ds_categoria.Tables(0).Rows.Count <> 0 Then
            'Carga la categoria
            cb_categoria.DataSource = ds_categoria.Tables(0)
            cb_categoria.DisplayMember = "cat1_nom"
            cb_categoria.ValueMember = "cat_id"
            cat1_id = cb_categoria.SelectedValue
            categoriarubro_obtener()
            rubrosubrubro_obtener()
            Cargarcombo_marca()
        End If
        Combo_tipo.SelectedIndex = 1


    End Sub

    Public Sub Cargarcombo_marca()
        'Cargar la Marca
        Dim ds_marca As DataSet = DAmarca.Marca_obtener
        cb_marca.DataSource = ds_marca.Tables(0)
        cb_marca.DisplayMember = "Marca_nom"
        cb_marca.ValueMember = "Marca_id"
        cb_marca.SelectedValue = ds_marca.Tables(0).Rows(0).Item("Marca_id")
    End Sub

    Public Sub rubrosubrubro_obtener()
        If cat2_id <> 0 Then
            Dim cat2_id As Integer = cb_rubro.SelectedValue 'se vuelve a seleccionar el actual
            ds_subrubro = DAcategoria.rubrosubrubro_obtener(cat2_id)
            If ds_subrubro.Tables(0).Rows.Count <> 0 Then
                cb_subrubro.DataSource = ds_subrubro.Tables(0)
                cb_subrubro.DisplayMember = "cat3_nom"
                cb_subrubro.ValueMember = "cat3_id"
                check_subrubro.Enabled = True
            Else
                cb_subrubro.DataSource = Nothing
                check_subrubro.Checked = False
                check_subrubro.Enabled = False
            End If
        Else
            cb_subrubro.DataSource = Nothing
            check_subrubro.Checked = False
            check_subrubro.Enabled = False

        End If
    End Sub



    Private Sub Validar_producto(ByRef valida As String)
        If tx_codinterno.Text <> "" Then
            ERROR_tx_codinterno.Visible = False
            If tx_descripcion.Text <> "" Then
                ERROR_tx_descripcion.Visible = False
                'If tx_unimedida.Text <> "" Then
                'ERROR_tx_unidadmedida.Visible = False
                If Tb_PrecMin.Text <> "" Then
                    Err_PrecMin.Visible = False
                    If tb_PrecMay.Text <> "" Then
                        Err_PrecMay.Visible = False
                        'If tx_stock.Text <> "" Then
                        'ERROR_tx_stock.Visible = False
                        'If tx_ptorepo.Text <> "" Then
                        'ERROR_tx_ptorepo.Visible = False
                        'If DG_Prov_Prod.RowCount <> 0 Then '   tx_preciocompra.Text <> "" Then
                        'If tx_preciocompra.Text <> "" Then
                        '    ERROR_tx_preciocompra.Visible = False
                        valida = "Si"
                        'Else
                        '    MessageBox.Show("Complete la información", "Sistema de Gestion.")
                        '    ERROR_tx_preciocompra.Visible = True
                        '    tx_preciocompra.Focus()
                        '    Me.TabControl1.SelectedTab = TabPage2
                        'End If
                        'Else
                        'MessageBox.Show("Complete la información", "Sistema de Gestion.")
                        'ERROR_tx_ptorepo.Visible = True
                        'tx_ptorepo.Focus()

                        'End If
                        'Else
                        'MessageBox.Show("Complete la información", "Sistema de Gestion.")
                        'ERROR_tx_stock.Visible = True
                        'tx_stock.Focus()

                        'End If
                    Else
                        MessageBox.Show("Complete la información", "Sistema de Gestion.")
                        Err_PrecMay.Visible = True
                        tb_PrecMay.Focus()

                    End If
                Else
                    MessageBox.Show("Complete la información", "Sistema de Gestion.")
                    Err_PrecMin.Visible = True
                    Tb_PrecMin.Focus()
                End If
                'Else
                '    MessageBox.Show("Complete la información", "Sistema de Gestion.")
                '    ERROR_tx_unidadmedida.Visible = True
                '    tx_unimedida.Focus()
                '    Me.TabControl1.SelectedTab = TabPage1
                'End If
            Else
                MessageBox.Show("Complete la información", "Sistema de Gestion.")
                ERROR_tx_descripcion.Visible = True
                tx_descripcion.Focus()
            End If
        Else
            MessageBox.Show("Complete la informacion", "Sistema de Gestion.")
            ERROR_tx_codinterno.Visible = True
            tx_codinterno.Focus()
        End If

    End Sub

    Public Sub limpiar_deshabilitar()

        'botones de error
        ERROR_tx_codinterno.Visible = False
        ERROR_tx_descripcion.Visible = False
        ERROR_tx_unidadmedida.Visible = False
        ERROR_tx_categoria.Visible = False
        ERROR_tx_stock.Visible = False
        ' ERROR_tx_precioventa.Visible = False
        ERROR_tx_ptorepo.Visible = False
        ' ERROR_tx_preciocompra.Visible = False
        ' ERROR_tx_proveedor.Visible = False
        'datos
        tx_codbarra.Text = ""
        tx_codinterno.Text = ""
        tx_descrilarga.Text = ""
        tx_descripcion.Text = ""
        '  tx_preciocompra.Text = ""
        ' tx_precioventa.Text = ""
        tx_ptorepo.Text = 0
        tx_unimedida.Text = ""
        tx_stock.Text = ""
        tb_PrecMay.Text = ""
        Tb_PrecMin.Text = ""
        DataGridView_Prod_Prov.DataSource = Nothing
        Bo_guardar.Enabled = False
        '  Producto_ds.Tables("ProveedorProducto").Clear()
        'DG_Prov_Prod.DataSource = Nothing

        cb_rubro.Enabled = False
        cb_subrubro.Enabled = False

        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox1.Image = bmap
        End If
        'vuelvo a generar el codigo interno
        If form_procedencia = "alta" Then
            Generar_cod_interno()
        End If
        '  Me.TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub check_rubro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_rubro.CheckedChanged
        If check_rubro.Checked = True Then
            If cb_rubro.Items.Count <> 0 Then
                cb_rubro.Enabled = True
            End If
        Else
            cb_rubro.Enabled = False
        End If
    End Sub

    Private Sub check_subrubro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_subrubro.CheckedChanged
        If check_subrubro.Checked = True Then
            If cb_subrubro.Items.Count <> 0 Then
                cb_subrubro.Enabled = True
            End If
        Else
            cb_subrubro.Enabled = False
        End If
    End Sub

    Private Sub Bo_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cargar.Click

        'OpenFileDialog1.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        OpenFileDialog1.Filter = "Imagen JPG (*.jpg)|*.jpg|Imagen BMP (*.bmp)|*.bmp|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        OpenFileDialog1.FileName = "" 'para q cuando abra el dialogo en el nombre no salga "openfiledialog"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Bo_deshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_deshacer.Click
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox1.Image = bmap
        End If
    End Sub

    Private Sub Bo_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_exportar.Click
        Dim saveImage As New SaveFileDialog 'Este es el SaveFileDialog
        Dim ruta As String = "" 'Para tener la ruta de la imagen
        saveImage.Title = "Guardar imagen como..." 'Título de la ventana
        saveImage.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        If saveImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Recuperar la ruta de la imagen si no está vacía
            If Not String.IsNullOrEmpty(saveImage.FileName) Then ruta = saveImage.FileName
            Dim myImg As Image = PictureBox1.Image 'Objeto Image para guardar la imagen del Picture

            Dim extension As String = ruta.Substring(ruta.Length - 3, 3) 'Recuperar los ultimos 3 caracteres de la extensió

            'ESTO SOLO FUNCIONA EN VISUAL BASIC 2008
            Select Case extension
                Case "bmp"
                    myImg.Save(ruta, System.Drawing.Imaging.ImageFormat.Bmp) 'Guardar en formato BMP
                Case "jpg"
                    PictureBox1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg) 'Guardar en formato JPG
                Case "png"
                    PictureBox1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Png) 'Guardar en formato PNG
            End Select
        End If
    End Sub


    Private Sub Bo_agregarcat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_agregarcat.Click
        Categorias.Origen_alta("producto_alta")
        Categorias.Show()

    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        limpiar_deshabilitar()
        Bo_guardar.Enabled = True
        Bo_cancelar.Enabled = True

        If form_procedencia = "modificar" Then
            Me.Close()
            Producto_modificar.Show()

        End If

    End Sub

    Private Sub cb_categoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_categoria.SelectedIndexChanged
        categoriarubro_obtener()
        rubrosubrubro_obtener()
    End Sub

    Private Sub cb_rubro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_rubro.SelectedIndexChanged
        rubrosubrubro_obtener()
    End Sub

    Private Sub Bo_nuevamarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_nuevamarca.Click
        Marca_alta.Show()
    End Sub

    Private Sub tx_stock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_stock.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tx_ptorepo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_ptorepo.KeyPress

        If Combo_tipo.SelectedIndex = 1 Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Else
            'es fraccionable, por lo tanto admite valores decimales
            'aqui pongo el codigo para remplazar el punto por una coma
            If e.KeyChar.ToString() = "." Then
                e.KeyChar = ","
            End If
            'a continuacion el codigo para impedir el ingreso de dos comas o letras
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            Else
                If Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    If e.KeyChar = "," And Not Me.tx_ptorepo.Text.IndexOf(",") Then
                        e.Handled = True
                    Else
                        If e.KeyChar = "," Then
                            e.Handled = False
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER le doy el formato
            If tx_ptorepo.Text = "" Then
                tx_ptorepo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                tx_ptorepo.Text = (Math.Round(CDec(tx_ptorepo.Text), 2).ToString("N2"))
            End If
        End If
    End Sub

    Private Sub tb_PrecMay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_PrecMay.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.tb_PrecMay.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER le doy el formato
            If tb_PrecMay.Text = "" Then
                tb_PrecMay.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                tb_PrecMay.Text = (Math.Round(CDec(tb_PrecMay.Text), 2).ToString("N2"))
            End If
        End If
    End Sub

    Private Sub Tb_PrecMin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_PrecMin.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.Tb_PrecMin.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER le doy el formato
            If Tb_PrecMin.Text = "" Then
                Tb_PrecMin.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                Tb_PrecMin.Text = (Math.Round(CDec(Tb_PrecMin.Text), 2).ToString("N2"))
            End If

        End If

    End Sub

    Private Sub btn_prove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prove.Click
        If tx_descripcion.Text <> "" Then
            Proveedores_X_Producto.ds_producto_edicion.Tables("ProveedorProducto_aux").Merge(ds_producto_recuperado.Tables("ProveedorProducto"))  'asigno el mismo contenido del ds recuperado al ds q uso en el otro formulario

            Proveedores_X_Producto.Show()
            'If Producto_modificar.Modificar = "si" Then
            '    Producto_modificar.recuperar_datos_producto(tx_codinterno.Text)
            'End If
        Else
            MessageBox.Show("Debe Ingresar el nombre del Producto", "Sistema de Gestion.")
        End If

    End Sub

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        Select Case form_procedencia
            Case "alta"
                producto_alta()
            Case "modificar"
                Rutina_Producto_modificar()
        End Select
    End Sub

    Private Sub tx_unimedida_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_unimedida.GotFocus
        tx_unimedida.SelectAll()
        tx_unimedida.BackColor = Color.FromArgb(255, 255, 192)
        ' RectangleShape_unimedida.Visible = True
    End Sub

    Private Sub tx_unimedida_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_unimedida.LostFocus
        tx_unimedida.BackColor = Color.White
        '  RectangleShape_unimedida.Visible = False
    End Sub
    Private Sub tx_stock_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_stock.GotFocus
        tx_stock.SelectAll()
        tx_stock.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tx_stock_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_stock.LostFocus
        tx_stock.BackColor = Color.White
    End Sub

    Private Sub tx_ptorepo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_ptorepo.GotFocus
        tx_ptorepo.SelectAll()
        tx_ptorepo.BackColor = Color.FromArgb(255, 255, 192)

        'RectangleShape_ptoreposicion.Visible = True
    End Sub

    Private Sub tx_ptorepo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_ptorepo.LostFocus
        tx_ptorepo.BackColor = Color.White

        ' RectangleShape_ptoreposicion.Visible = False
        If tx_ptorepo.Text = "" Then
            tx_ptorepo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tx_ptorepo.Text = (Math.Round(CDec(tx_ptorepo.Text), 2).ToString("N2"))
        End If
    End Sub

#Region "Alta"
    Private Sub producto_alta()
        'validamos q tenga CI, descripcion,unidad,categoria,precio venta,stock,ptorepo,prov,preciocompra
        Dim valida As String = "No"
        Validar_producto(valida)

        If valida = "Si" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea agregar el Producto?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then

                'FOTO  //////////////////////////////////////////////////////////////////////////////////////////////////
                    Dim producto_foto As Byte()
                    producto_foto = Nothing
                    If PictureBox1.ImageLocation <> Nothing Then  'si tengo seleccionado una foto, la mando como parametro
                        Dim ms = New MemoryStream
                        Dim fs = New FileStream(PictureBox1.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                        ms.SetLength(fs.Length)
                        fs.Read(ms.GetBuffer(), 0, fs.Length)
                        producto_foto = ms.GetBuffer
                        ms.Flush()
                        fs.Close()
                    Else
                        'si no tiene foto, le pongo x defecto la q esta en picture.image
                        Dim ms = New MemoryStream
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        producto_foto = ms.GetBuffer
                        ms.Flush()
                    End If
                    'Producto ALTA  //////////////////////////////////////////////////////////////////////////////////////////
                    Dim nrocat As Integer = 1
                    Dim idcat As Integer = cb_categoria.SelectedValue
                    If check_subrubro.Checked = True Then
                        nrocat = 3
                        idcat = cb_subrubro.SelectedValue
                    Else
                        If check_rubro.Checked = True Then
                            nrocat = 2
                            idcat = cb_rubro.SelectedValue
                        End If
                    End If
                    Dim idmarca As Integer = cb_marca.SelectedValue
                Dim ds_prodid As DataSet = DAproducto.Producto_Alta_New(tx_descripcion.Text, tx_descrilarga.Text, Tb_PrecMin.Text, 0, CInt(tx_ptorepo.Text), tx_codinterno.Text, tx_codbarra.Text, idcat, nrocat, idmarca, tx_unimedida.Text, producto_foto, tb_PrecMay.Text, Combo_tipo.SelectedItem)
                    Dim prodid As Integer = ds_prodid.Tables(0).Rows(0).Item(0)

                    'ProveedorProducto Alta
                    Dim var = Proveedores_X_Producto.DG_Prov_Prod.RowCount
                    For Each row As DataGridViewRow In DataGridView_Prod_Prov.Rows
                        Dim ds_provprod As DataSet = DAproducto.ProveedorProducto_alta(row.Cells("ProvidDataGridViewTextBoxColumn").Value, prodid)
                        Dim provprodid As Integer = ds_provprod.Tables(0).Rows(0).Item(0)
                    DAproducto.ProveedorProductoCompra_alta(provprodid, row.Cells("ProvProdComfechaDataGridViewTextBoxColumn").Value)
                    Next

                    'alta de producto con STOCK en 0.. en todas las sucursales.
                    Dim a As Integer = 0
                    While a < ds_prodid.Tables(1).Rows.Count
                        Dim sucursal_id As Integer = ds_prodid.Tables(1).Rows(a).Item("sucursal_id")
                        DAproducto.Producto_x_sucursal_ALTA(prodid, sucursal_id, 0, 0)
                        a = a + 1
                    End While
                    limpiar_deshabilitar()
                If form_procedencia = "modificar" Then
                   
                    MessageBox.Show("El producto se guardo correctamente", "Sistema de Gestion.")
                    Close()
                Else
                    Generar_cod_interno()
                    ds_producto_recuperado.Tables("ProveedorProducto").Rows.Clear()
                    MessageBox.Show("El producto se guardo correctamente", "Sistema de Gestion.")
                    Producto_modificar.paso = 1
                    Producto_modificar.Cargar_grilla()
                End If




              
            End If
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub Rutina_Producto_modificar()
        'validamos q tenga CI, descripcion,unidad,categoria,precio venta,stock,ptorepo,prov,preciocompra
        Dim valida As String = "No"
        Validar_producto(valida)

        If valida = "Si" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea modificar el Producto?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                'Dim valido_producto As New DataSet
                'valido_producto = DAproducto.Producto_buscarcod(Me.tx_codinterno.Text)
                'If valido_producto.Tables(0).Rows.Count = 0 Then

                'FOTO  //////////////////////////////////////////////////////////////////////////////////////////////////
                Dim producto_foto As Byte()
                producto_foto = Nothing
                If PictureBox1.ImageLocation <> Nothing Then  'si tengo seleccionado una foto, la mando como parametro
                    Dim ms = New MemoryStream
                    Dim fs = New FileStream(PictureBox1.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    ms.SetLength(fs.Length)
                    fs.Read(ms.GetBuffer(), 0, fs.Length)
                    producto_foto = ms.GetBuffer
                    ms.Flush()
                    fs.Close()
                Else
                    'si no tiene foto, le pongo x defecto la q esta en picture.image
                    Dim ms = New MemoryStream
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    producto_foto = ms.GetBuffer
                    ms.Flush()
                End If
                'Producto ALTA  //////////////////////////////////////////////////////////////////////////////////////////
                Dim nrocat As Integer = 1
                Dim idcat As Integer = cb_categoria.SelectedValue
                If check_subrubro.Checked = True Then
                    nrocat = 3
                    idcat = cb_subrubro.SelectedValue
                Else
                    If check_rubro.Checked = True Then
                        nrocat = 2
                        idcat = cb_rubro.SelectedValue
                    End If
                End If
                Dim idmarca As Integer = cb_marca.SelectedValue
                Dim ds_prodid As DataSet = DAproducto.Producto_modificar(tx_descripcion.Text, tx_descrilarga.Text, Tb_PrecMin.Text, tx_codinterno.Text, tx_codbarra.Text, idcat, nrocat, idmarca, tx_unimedida.Text, producto_foto, tb_PrecMay.Text, CInt(tx_ptorepo.Text), Combo_tipo.SelectedItem)
                Dim prodid As Integer = ds_prodid.Tables(0).Rows(0).Item(0)

                'primero borro los datos de la tabla proveedorproducto,
                proveedorproducto_borrar(prodid)

                'ProveedorProducto Alta
                Dim var = Proveedores_X_Producto.DG_Prov_Prod.RowCount
                For Each row As DataGridViewRow In DataGridView_Prod_Prov.Rows
                    Dim ds_provprod As DataSet = DAproducto.ProveedorProducto_alta(row.Cells("ProvidDataGridViewTextBoxColumn").Value, prodid)
                    Dim provprodid As Integer = ds_provprod.Tables(0).Rows(0).Item(0)
                    DAproducto.ProveedorProductoCompra_alta(provprodid, row.Cells("ProvProdComfechaDataGridViewTextBoxColumn").Value)
                Next

                limpiar_deshabilitar()
                If form_procedencia = "modificar" Then
                    MessageBox.Show("El producto se guardo correctamente", "Sistema de Gestion.")
                    Close()
                    Producto_modificar.paso = 1 'esto es x q obligo a seleccionar el combo de sucursal primero
                    Producto_modificar.Cargar_grilla()
                    'Producto_modificar.Prod_obtenertodo()
                    Producto_modificar.Show()
                Else
                    Generar_cod_interno()
                    MessageBox.Show("El producto se guardo correctamente", "Sistema de Gestion.")
                End If
                'End If
            End If
        End If
    End Sub

    'esta rutina borrar los producto cargados en la tabla "proveedorproducto"
    Private Sub proveedorproducto_borrar(ByVal prodid As Integer)
        Dim var = DataGridView_Prod_Prov.Rows.Count
        For Each row As DataGridViewRow In DataGridView_Prod_Prov.Rows
            DAproducto.ProveedorProducto_borrar(row.Cells("ProvidDataGridViewTextBoxColumn").Value, prodid)
        Next
    End Sub
#End Region

#Region "diseño_focos_y_colores"
    Private Sub cb_categoria_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_categoria.GotFocus
        '  RectangleShape_categoria.Visible = True
    End Sub
    Private Sub cb_categoria_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_categoria.LostFocus
        ' RectangleShape_categoria.Visible = False
    End Sub
    Private Sub cb_marca_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_marca.GotFocus
        cb_marca.SelectAll()
        cb_marca.BackColor = Color.FromArgb(255, 255, 192)
        ' RectangleShape_marca.Visible = True
    End Sub

    Private Sub cb_marca_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_marca.LostFocus
        cb_marca.BackColor = Color.White
        ' RectangleShape_marca.Visible = False
    End Sub
    Private Sub cb_rubro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_rubro.GotFocus
        ' RectangleShape_rubro.Visible = True
    End Sub

    Private Sub cb_rubro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_rubro.LostFocus
        ' RectangleShape_rubro.Visible = False
    End Sub
    Private Sub cb_subrubro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_subrubro.GotFocus
        ' RectangleShape_subrubro.Visible = True
    End Sub

    Private Sub cb_subrubro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_subrubro.LostFocus
        'RectangleShape_subrubro.Visible = False
    End Sub
    Private Sub tx_descripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_descripcion.GotFocus
        tx_descripcion.SelectAll()
        tx_descripcion.BackColor = Color.FromArgb(255, 255, 192)
        ' RectangleShape_descripcion.Visible = True
    End Sub
    Private Sub tx_descripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_descripcion.LostFocus
        tx_descripcion.BackColor = Color.White
        ' RectangleShape_descripcion.Visible = False
    End Sub
    Private Sub Tb_PrecMin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tb_PrecMin.GotFocus
        Tb_PrecMin.SelectAll()
        Tb_PrecMin.BackColor = Color.FromArgb(255, 255, 192)
        '   RectangleShape_precmin.Visible = True
    End Sub
    Private Sub Tb_PrecMin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tb_PrecMin.LostFocus
        If Tb_PrecMin.Text = "" Then
            Tb_PrecMin.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            Tb_PrecMin.Text = (Math.Round(CDec(Tb_PrecMin.Text), 2).ToString("N2"))
        End If
        Tb_PrecMin.BackColor = Color.White
        '    RectangleShape_precmin.Visible = False
    End Sub
    Private Sub tb_PrecMay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_PrecMay.GotFocus
        tb_PrecMay.SelectAll()
        tb_PrecMay.BackColor = Color.FromArgb(255, 255, 192)
        '   RectangleShape_precmay.Visible = True
    End Sub
    Private Sub tb_PrecMay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_PrecMay.LostFocus
        tb_PrecMay.BackColor = Color.White
        '  RectangleShape_precmay.Visible = False
        If tb_PrecMay.Text = "" Then
            tb_PrecMay.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tb_PrecMay.Text = (Math.Round(CDec(tb_PrecMay.Text), 2).ToString("N2"))
        End If
    End Sub
    Private Sub tx_codbarra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_codbarra.GotFocus
        tx_codbarra.SelectAll()
        tx_codbarra.BackColor = Color.FromArgb(255, 255, 192)
        ' RectangleShape_codbarra.Visible = True
    End Sub
    Private Sub tx_codbarra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_codbarra.LostFocus
        tx_codbarra.BackColor = Color.White
        ' RectangleShape_codbarra.Visible = False
    End Sub
    Private Sub tx_descrilarga_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_descrilarga.GotFocus
        tx_descrilarga.SelectAll()
        tx_descrilarga.BackColor = Color.FromArgb(255, 255, 192)
        '  RectangleShape_descrilarga.Visible = True
    End Sub


    Private Sub tx_descrilarga_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_descrilarga.LostFocus
        tx_descrilarga.BackColor = Color.White
        '  RectangleShape_descrilarga.Visible = False
    End Sub
#End Region



    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    
    Private Sub Combo_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_tipo.SelectedIndexChanged
        If Combo_tipo.SelectedIndex = 0 Then
            tx_unimedida.Text = "KG"
            tx_unimedida.Visible = True
            Combo_tipo.Width = 138

        Else
            tx_unimedida.Text = ""
            tx_unimedida.Visible = False
            Combo_tipo.Width = 269
        End If
    End Sub
End Class