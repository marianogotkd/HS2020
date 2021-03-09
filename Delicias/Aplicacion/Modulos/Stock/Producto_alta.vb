Imports System.IO
Imports System.Data.OleDb
Public Class Producto_alta

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

    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAlista.ProductoCombo_validar()
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            tx_codinterno.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item(0) + 1
        Else
            tx_codinterno.Text = "100"
        End If
    End Sub

    Private Sub Producto_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'guardo en portapapeles la imagen por defecto para los productos
        Clipboard.SetDataObject(Me.PictureBox1.Image)

        'If ds_prodcod.Tables(0).Rows.Count > 0 Then
        '    tx_codinterno.Text = ds_prodcod.Tables(0).Rows(0).Item(0) + 1
        'Else
        '    tx_codinterno.Text = "100"
        'End If

        Generar_cod_interno()
        cargar_combos()

        Me.tx_codbarra.Focus()
        Me.tx_codbarra.SelectAll()
        Bo_guardar.Enabled = False
    End Sub

    Public Sub Cargar_categorias()
        ds_categoria = DAcategoria.Categoria_obtener
        'Carga la categoria
        cb_categoria.DataSource = ds_categoria.Tables(0)
        cb_categoria.DisplayMember = "cat1_nom"
        cb_categoria.ValueMember = "cat_id"
        cb_categoria.SelectedValue = ds_categoria.Tables(0).Rows(0).Item("cat_id")
        categoriarubro_obtener()
        rubrosubrubro_obtener()


    End Sub
    Public Sub categoriarubro_obtener()


        Dim cat_id As String = ds_categoria.Tables(0).Rows(cb_categoria.SelectedIndex).Item("cat_id").ToString
        ds_rubro = DAcategoria.Categoriarubro_obtener(cat_id)

        If ds_rubro.Tables(0).Rows.Count <> 0 Then
            cb_rubro.DataSource = ds_rubro.Tables(0)
            cb_rubro.DisplayMember = "cat2_nom"
            cb_rubro.ValueMember = "cat2_id"
        End If
    End Sub
    Public Sub cargar_combos()

        'Carga la categoria
        cb_categoria.DataSource = ds_categoria.Tables(0)
        cb_categoria.DisplayMember = "cat1_nom"
        cb_categoria.ValueMember = "cat_id"

        categoriarubro_obtener()
        rubrosubrubro_obtener()
        Cargarcombo_marca()
        Cargarcombo_proveedor()


    End Sub
    Public Sub Cargarcombo_proveedor()
        ds_proveedor = DAproveedores.Proveedor_obtener
        'Cargar Proveedor
        cb_proveedores.DataSource = ds_proveedor.Tables(0)
        cb_proveedores.DisplayMember = "Prov_nombre"
        cb_proveedores.ValueMember = "Prov_id"

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

        If ds_rubro.Tables(0).Rows.Count <> 0 Then
            Dim cat1_id As String = ds_rubro.Tables(0).Rows(cb_rubro.SelectedIndex).Item("cat2_id").ToString
            ds_subrubro = DAcategoria.rubrosubrubro_obtener(cat1_id)

            If ds_subrubro.Tables(0).Rows.Count <> 0 Then
                cb_subrubro.DataSource = ds_subrubro.Tables(0)
                cb_subrubro.DisplayMember = "cat3_nom"
                cb_subrubro.ValueMember = "cat3_id"
            End If
        End If
    End Sub

    Private Sub Validar_producto(ByRef valida As String)
        If tx_codinterno.Text <> "" Then
            ERROR_tx_codinterno.Visible = False
            If tx_descripcion.Text <> "" Then
                ERROR_tx_descripcion.Visible = False
                'If tx_unimedida.Text <> "" Then
                'ERROR_tx_unidadmedida.Visible = False
                If tx_precioventa.Text <> "" Then
                    ERROR_tx_precioventa.Visible = False
                    If tx_stock.Text <> "" Then
                        ERROR_tx_stock.Visible = False
                        If tx_ptorepo.Text <> "" Then
                            ERROR_tx_ptorepo.Visible = False
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
                        Else
                            MessageBox.Show("Complete la información", "Sistema de Gestion.")
                            ERROR_tx_ptorepo.Visible = True
                            tx_ptorepo.Focus()
                            Me.TabControl1.SelectedTab = TabPage2
                        End If
                    Else
                        MessageBox.Show("Complete la información", "Sistema de Gestion.")
                        ERROR_tx_stock.Visible = True
                        tx_stock.Focus()
                        Me.TabControl1.SelectedTab = TabPage2
                    End If
                Else
                    MessageBox.Show("Complete la información", "Sistema de Gestion.")
                    ERROR_tx_precioventa.Visible = True
                    tx_precioventa.Focus()
                    Me.TabControl1.SelectedTab = TabPage2
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
                Me.TabControl1.SelectedTab = TabPage1
            End If
        Else
            MessageBox.Show("Complete la informacion", "Sistema de Gestion.")
            ERROR_tx_codinterno.Visible = True
            tx_codinterno.Focus()
            Me.TabControl1.SelectedTab = TabPage1
        End If

    End Sub

    Private Sub Bo_guardar_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        'validamos q tenga CI, descripcion,unidad,categoria,precio venta,stock,ptorepo,prov,preciocompra
        Dim valida As String = "No"
        Validar_producto(valida)

        If valida = "Si" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea dar de alta Producto?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Dim valido_producto As New DataSet
                valido_producto = DAproducto.Producto_buscarcod(Me.tx_codinterno.Text)
                If valido_producto.Tables(0).Rows.Count = 0 Then

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
                    Dim ds_prodid As DataSet = DAproducto.Producto_Alta(tx_descripcion.Text, tx_descrilarga.Text, tx_precioventa.Text, tx_stock.Text, tx_ptorepo.Text, tx_codinterno.Text, tx_codbarra.Text, idcat, nrocat, idmarca, tx_unimedida.Text, producto_foto)
                    Dim prodid As Integer = ds_prodid.Tables(0).Rows(0).Item(0)

                    'ProveedorProducto Alta
                    For Each row As DataGridViewRow In DG_Prov_Prod.Rows
                        Dim ds_provprod As DataSet = DAproducto.ProveedorProducto_alta(row.Cells("ProvidDataGridViewTextBoxColumn").Value, prodid)
                        Dim provprodid As Integer = ds_provprod.Tables(0).Rows(0).Item(0)
                        DAproducto.ProveedorProductoCompra_alta(provprodid, row.Cells("ProvProdComfechaDataGridViewTextBoxColumn").Value)
                    Next
                    limpiar_deshabilitar()
                    Generar_cod_interno()
                    MessageBox.Show("El producto se guardo correctamente", "Sistema de Gestion.")

                    Else
                        MessageBox.Show("El codigo interno ya existe", "Sistema de Gestion.")
                        ERROR_tx_codinterno.Visible = True
                        tx_codinterno.Focus()
                        Me.TabControl1.SelectedTab = TabPage1
                    End If
                End If
        End If
    End Sub

    
    Public Sub limpiar_deshabilitar()

        'botones de error
        ERROR_tx_codinterno.Visible = False
        ERROR_tx_descripcion.Visible = False
        ERROR_tx_unidadmedida.Visible = False
        ERROR_tx_categoria.Visible = False
        ERROR_tx_stock.Visible = False
        ERROR_tx_precioventa.Visible = False
        ERROR_tx_ptorepo.Visible = False
        ERROR_tx_preciocompra.Visible = False
        ERROR_tx_proveedor.Visible = False
        'datos
        tx_codbarra.Text = ""
        tx_codinterno.Text = ""
        tx_descrilarga.Text = ""
        tx_descripcion.Text = ""
        tx_preciocompra.Text = ""
        tx_precioventa.Text = ""
        tx_ptorepo.Text = ""
        tx_unimedida.Text = ""
        tx_stock.Text = ""
        Producto_ds.Tables("ProveedorProducto").Clear()
        DG_Prov_Prod.DataSource = Nothing

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
        Generar_cod_interno()
        Me.TabControl1.SelectedTab = TabPage1
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

        OpenFileDialog1.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        limpiar_deshabilitar()
        Me.TabControl1.SelectedTab = TabPage1
        Bo_guardar.Enabled = True
        Bo_cancelar.Enabled = True
    End Sub

   
    Private Sub cb_categoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_categoria.SelectedIndexChanged
        categoriarubro_obtener()
    End Sub

    Private Sub cb_rubro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_rubro.SelectedIndexChanged
        rubrosubrubro_obtener()
    End Sub

    Private Sub Bo_nuevamarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_nuevamarca.Click
        Marca_alta.Show()
    End Sub


    Private Sub Bo_nuevoprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_nuevoprov.Click
        Proveedor_alta.Origen_alta("producto_alta")
        Proveedor_alta.Show()
        Proveedor_alta.Focus()
    End Sub

    Public Sub limpiar_proveedor_producto()
        ERROR_tx_proveedor.Visible = False
        tx_preciocompra.Text = ""
        ERROR_tx_preciocompra.Visible = False
    End Sub
    Private Sub Bo_agregarprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_agregarprod.Click
        'validacion 
        Dim valido As String = "si"
        If cb_proveedores.Items.Count = 0 Then
            MessageBox.Show("Error, seleccione un proveedor", "Sistema de Gestion.")
            ERROR_tx_proveedor.Visible = True
            valido = "no"
        End If

        If valido = "si" Then
            Dim ProductoRow As DataRow = Producto_ds.Tables("ProveedorProducto").NewRow()
            ProductoRow("Prov_id") = ds_proveedor.Tables(0).Rows(cb_proveedores.SelectedIndex).Item("Prov_id").ToString
            ProductoRow("Prov_nombre") = ds_proveedor.Tables(0).Rows(cb_proveedores.SelectedIndex).Item("Prov_nombre").ToString
            ProductoRow("Prod_descripcion") = tx_descripcion.Text
            ProductoRow("Prov_Prod_Com_fecha") = DT_fecha_compra.Value
            Dim precio_compra As Decimal = 0
            If tx_preciocompra.Text <> "" Then
                precio_compra = CDec(tx_preciocompra.Text)
            Else
                precio_compra = CDec(0)
            End If
            ProductoRow("Prov_Prod_Com_precio") = precio_compra
            Producto_ds.Tables("ProveedorProducto").Rows.Add(ProductoRow)
            DG_Prov_Prod.DataSource = Producto_ds.Tables("ProveedorProducto")
            Bo_guardar.Enabled = True
            limpiar_proveedor_producto()
        End If
    End Sub



    'Validaciones
    Private Sub tx_precioventa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_precioventa.KeyPress
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
                If e.KeyChar = "," And Not Me.tx_precioventa.Text.IndexOf(",") Then
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
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tx_preciocompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_preciocompra.KeyPress
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
                If e.KeyChar = "," And Not Me.tx_preciocompra.Text.IndexOf(",") Then
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
    End Sub


    Private Sub Bo_agregarcat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_agregarcat.Click
        Categorias.Origen_alta("producto_alta")
        Categorias.Show()

    End Sub

    Private Sub DG_Prov_Prod_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DG_Prov_Prod.RowsRemoved
        If DG_Prov_Prod.RowCount = 0 Then
            Bo_guardar.Enabled = False
        End If
    End Sub

   
End Class