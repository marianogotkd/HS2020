Imports System.IO
Imports System.Data.OleDb
Public Class Producto_modificar
    Dim DAcategoria As New Datos.Categoria
    Dim DAmarca As New Datos.Marca
    Dim DAproveedores As New Datos.Proveedor
    Dim DAsucursal As New Datos.Sucursal
    Dim ds_proveedor As DataSet = DAproveedores.Proveedor_obtener
    Dim DAVentas As New Datos.Venta
    Dim ds_PROD As DataSet
    Public paso = 0
    Dim cat1_id As Integer = 0
    Dim cat2_id As Integer = 0
    Dim ds_rubro As DataSet
    Dim ds_subrubro As DataSet
    Dim evento_load_completo As String = "no"
    Private Sub Sucursales_Obtener()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        cb_origen.DataSource = ds.Tables(0)
        cb_origen.DisplayMember = "sucursal_nombre"
        cb_origen.ValueMember = "sucursal_id"
        paso = 1
    End Sub
    Public Sub Cargarcombo_proveedor()
        'ds_proveedor = DAproveedores.Proveedor_obtener
        ''Cargar Proveedor
        'cb_proveedores.DataSource = ds_proveedor.Tables(0)
        'cb_proveedores.DisplayMember = "Prov_nombre"
        'cb_proveedores.ValueMember = "Prov_id"
    End Sub

    Dim DAproducto As New Datos.Producto

    Private Sub Buscar_codinterno()
        If Tx_Buscqueda.Text <> "" Then
            Me.DG_Producto.Rows.Clear()
            Dim DS As New DataSet
            DS = DAproducto.Producto_buscarcod(Me.Tx_Buscqueda.Text)
            If DS.Tables(0).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DG_Producto.Rows().Add()
                    DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                    DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(6) 'COD interno
                    DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(1) 'producto
                    DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(5) 'marca
                    DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(3) 'Stock
                    DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(4) 'ptoreposicion
                    If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                        DG_Producto.Rows(fila).Cells(4).Style.ForeColor = Color.Red
                        DG_Producto.Rows(fila).Cells(5).Style.ForeColor = Color.Red
                        'DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
                        'DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                    End If
                    fila = fila + 1
                End While
            End If
            Me.Tx_Buscqueda.Select()
        Else
            Prod_obtenertodo()
        End If
    End Sub

    Private Sub BO_Buscar_codinterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Buscar_codinterno()
        'DG_Producto.ClearSelection()
    End Sub

    Public Sub Prod_obtenertodo()
        Me.DG_Producto.Rows.Clear()
        Dim DS As New DataSet
        DS = DAproducto.prod_obtener()
        If DS.Tables(0).Rows.Count <> 0 Then
            Dim fila As Integer = 0
            While fila < DS.Tables(0).Rows.Count
                Me.DG_Producto.Rows().Add()
                DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(6) 'COD interno
                DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(1) 'producto
                DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(5) 'marca
                DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(3) 'Stock
                DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(4) 'ptoreposicion
                If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                    DG_Producto.Rows(fila).Cells(4).Style.ForeColor = Color.Red
                    DG_Producto.Rows(fila).Cells(5).Style.ForeColor = Color.Red
                    'DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                End If
                fila = fila + 1
            End While
            'DG_Producto.ClearSelection()
        End If

    End Sub

    Private Sub BO_producto_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_producto_modificar.Click
        ''''MODULO ANTERIOR''''''''''''

        'habilitar()
        'If Me.DG_Producto.CurrentRow IsNot Nothing Then

        '    Dim productoselec As String = DG_Producto.SelectedCells(1).Value
        '    If productoselec <> "" Then
        '        Tx_Codinterno.Text = DG_Producto.SelectedCells(1).Value
        '        Me.TabControl1.SelectedTab = TabPage2
        '        recuperar_datos_producto()

        '        Me.TabControl1.SelectedTab = TabPage3
        '        recuperar_datos()

        '        Bo_guardar.Enabled = True
        '        Bo_cancelar.Enabled = True
        '        GroupBox1.Enabled = False
        '    Else
        '        MsgBox("Seleccione un Producto", MsgBoxStyle.Information)
        '    End If
        'Else
        '    MsgBox("Seleccione un Producto", MsgBoxStyle.Information)
        'End If



        If Me.DG_Producto.Rows.Count <> 0 Then
            Dim productoselec As String = CStr(DG_Producto.SelectedCells(0).Value)
            If productoselec <> "" Then
                Producto_alta_New.Close()
                Tx_Buscqueda.Text = DG_Producto.SelectedCells(0).Value
                Producto_alta_New.codint = Tx_Buscqueda.Text
                'recuperar_datos_producto(Tx_Codinterno.Text)
                'recuperar_datos()
                Producto_alta_New.form_procedencia = "modificar"
                Producto_alta_New.Text = "Editar Producto"
                Producto_alta_New.Show()
                Me.Close()
            Else
                MsgBox("Seleccione un Producto", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un Producto", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub recuperar_datos()
        ''''MODULO ANTERIORO''''''

        'Dim ds_prod As New DataSet
        'ds_prod = DAproducto.Producto_obtenerDatos(Tx_Codinterno.Text)

        'Tx_cod_modif.Text = ds_prod.Tables(0).Rows(0).Item(11)
        'tx_descripcion.Text = ds_prod.Tables(0).Rows(0).Item(1)
        'tx_descrilarga.Text = ds_prod.Tables(0).Rows(0).Item(13)
        'cb_marca.Text = ds_prod.Tables(0).Rows(0).Item(14)
        'tx_unimedida.Text = ds_prod.Tables(0).Rows(0).Item(15)
        'tx_codbarra.Text = ds_prod.Tables(0).Rows(0).Item(16)

        ''recupero foto
        'Dim arrImg As Byte() = DirectCast(ds_prod.Tables(1).Rows(0).Item("prod_foto"), Byte())
        'Dim ms As New MemoryStream(arrImg)
        'Dim img As Image = Image.FromStream(ms)
        'PictureBox1.Image = img
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''



    End Sub

    Public Sub recuperar_datos_producto(ByVal codigointerno As Integer)

        '''''MODULO ANTERIOR''''''
        'If ds_producto.Tables(0).Rows.Count <> 0 Then
        '    Dim item As Integer = 0
        '    While item < ds_producto.Tables(0).Rows.Count
        '        Dim newCustomersRow As DataRow = Producto_ds.Tables("ProductoModificar").NewRow()
        '        newCustomersRow("Prov_id") = ds_producto.Tables(0).Rows(item).Item(5)
        '        newCustomersRow("Prod_id") = ds_producto.Tables(0).Rows(item).Item(0)
        '        newCustomersRow("Prov_prod_id") = ds_producto.Tables(0).Rows(item).Item(9)
        '        newCustomersRow("Prov_Prod_Com_id") = ds_producto.Tables(0).Rows(item).Item(10)
        '        newCustomersRow("Prod_descripcion") = ds_producto.Tables(0).Rows(item).Item(1)
        '        newCustomersRow("Prov_nombre") = ds_producto.Tables(0).Rows(item).Item(6)
        '        newCustomersRow("Prov_Prod_Com_precio") = ds_producto.Tables(0).Rows(item).Item(8)
        '        newCustomersRow("Prod_precio_vta") = ds_producto.Tables(0).Rows(item).Item(2)
        '        newCustomersRow("Prod_stock") = ds_producto.Tables(0).Rows(item).Item(3)
        '        newCustomersRow("Prod_ptorepo") = ds_producto.Tables(0).Rows(item).Item(4)
        '        newCustomersRow("Prov_Prod_Com_fecha") = ds_producto.Tables(0).Rows(item).Item(7)
        '        Producto_ds.Tables("ProductoModificar").Rows.Add(newCustomersRow)
        '        DG_prod_modif.DataSource = Producto_ds.Tables("ProductoModificar")
        '        item = item + 1
        '    End While
        'End If





    End Sub

    Public Sub Editar_prod()
        'Me.cb_proveedores.Text = DG_prod_modif.CurrentRow.Cells(5).Value
        'Me.Tx_stock_modif.Text = DG_prod_modif.CurrentRow.Cells(8).Value
        'Me.Tx_compra_modif.Text = DG_prod_modif.CurrentRow.Cells(6).Value
        'Me.tx_venta_modif.Text = DG_prod_modif.CurrentRow.Cells(7).Value
        'Me.tx_ptorepo.Text = DG_prod_modif.CurrentRow.Cells(9).Value
        'Me.DT_fecha_compra.Text = Today
    End Sub

    Private Sub DG_prod_modif_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Editar_prod()
        'GroupBox4.Enabled = True

    End Sub

    Private Sub Bo_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim item = 0
        'Dim presente = "no"
        'Dim fila_editar = 0
        'While item < DG_prod_modif.Rows.Count
        '    If DG_prod_modif.Rows(item).Cells(5).Value = cb_proveedores.Text Then
        '        presente = "si"
        '        fila_editar = item
        '    End If
        '    item = item + 1
        'End While
        'If presente = "no" Then
        '    'agrego una nueva fila
        '    Dim newCustomersRow As DataRow = Producto_ds.Tables("ProductoModificar").NewRow()
        '    newCustomersRow("Prov_id") = ds_proveedor.Tables(0).Rows(cb_proveedores.SelectedIndex).Item("Prov_id").ToString
        '    newCustomersRow("Prod_id") = DG_Producto.CurrentRow.Cells(0).Value
        '    newCustomersRow("Prov_Prod_Com_id") = 0
        '    newCustomersRow("Prov_Prod_id") = 0
        '    newCustomersRow("Prov_Prod_Com_precio") = Tx_compra_modif.Text
        '    newCustomersRow("Prod_precio_vta") = tx_venta_modif.Text
        '    newCustomersRow("Prod_stock") = CInt(Tx_stock_modif.Text) + CInt(DG_prod_modif.CurrentRow.Cells(8).Value)
        '    newCustomersRow("Prod_ptorepo") = tx_ptorepo.Text
        '    Dim fechacompra As Date = DT_fecha_compra.Text
        '    newCustomersRow("Prov_prod_com_fecha") = fechacompra.ToString("dd/MM/yyy")
        '    newCustomersRow("Prov_nombre") = cb_proveedores.Text
        '    Producto_ds.Tables("ProductoModificar").Rows.Add(newCustomersRow)
        '    DG_prod_modif.DataSource = Producto_ds.Tables("ProductoModificar")
        '    'Producto_limpiar()

        'Else
        '    Dim result As DialogResult
        '    result = MessageBox.Show("Los atributos fueron modificados", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '    If result = DialogResult.OK Then
        '        Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prov_nombre") = cb_proveedores.Text
        '        Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prod_stock") = CInt(Tx_stock_modif.Text) + CInt(Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prod_stock"))
        '        Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("Prov_Prod_Com_precio") = Tx_compra_modif.Text
        '        Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prod_precio_vta") = tx_venta_modif.Text
        '        Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("prod_ptorepo") = tx_ptorepo.Text
        '        Producto_ds.Tables("ProductoModificar").Rows(fila_editar).Item("Prov_Prod_Com_fecha") = DT_fecha_compra.Text
        '        DG_prod_modif.DataSource = Producto_ds.Tables("ProductoModificar")
        '    End If
        'End If

        ''Actualizar la grilla todos los valores en comun stock precio vta pto repo
        'Dim a As Integer = 0
        'While a < DG_prod_modif.Rows.Count
        '    If cb_proveedores.Text <> Producto_ds.Tables("ProductoModificar").Rows(a).Item("prov_nombre") Then
        '        Dim stock_grilla As Integer = CInt(Producto_ds.Tables("ProductoModificar").Rows(a).Item("prod_stock"))

        '        Producto_ds.Tables("ProductoModificar").Rows(a).Item("prod_stock") = CInt(Tx_stock_modif.Text) + stock_grilla
        '        Producto_ds.Tables("ProductoModificar").Rows(a).Item("prod_precio_vta") = tx_venta_modif.Text
        '        Producto_ds.Tables("ProductoModificar").Rows(a).Item("prod_ptorepo") = tx_ptorepo.Text
        '    End If
        '    a = a + 1
        'End While
        'Producto_limpiar()
        'GroupBox4.Enabled = False

    End Sub

    Private Sub Producto_limpiar()

        ''Tx_prov_modif.Text = Nothing
        'tx_ptorepo.Text = Nothing
        'Tx_stock_modif.Text = Nothing
        'tx_venta_modif.Text = Nothing
        'Tx_compra_modif.Text = Nothing
        'DT_fecha_compra.Text = Today
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Proveedor_alta.Origen_alta("producto_modificar")
        Proveedor_alta.Show()
    End Sub

    Private Sub Producto_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        paso = 0
        'Clipboard.SetDataObject(Me.PictureBox1.Image)
        deshabilitar()
        Tx_Buscqueda.Focus()
        Cargarcombo_proveedor()
        Cargarcombo_marca()
        ' Buscar_codinterno() 'esto me muestra en la grilla todos los productos
        Sucursales_Obtener()
        Cargar_grilla()
        Cargarcombo_marca() 'choco 23-11-2018
        cargar_combos_categoria()
        evento_load_completo = "si"
    End Sub

    Private Sub formato_grilla()
        Dim style As New DataGridViewCellStyle
        style.Font = New Font(DG_Producto.Font, FontStyle.Bold)
        Dim i = 0
        While i < DG_Producto.RowCount
            If DG_Producto.Rows(i).Cells("ProdxSuc_stock").Value <= DG_Producto.Rows(i).Cells("prod_ptorepo").Value Then
                DG_Producto.Rows(i).Cells("ProdxSuc_stock").Style.ForeColor = Color.Red
                DG_Producto.Rows(i).Cells("prod_ptorepo").Style.ForeColor = Color.Red
                DG_Producto.Rows(i).DefaultCellStyle = style
            End If
            i = i + 1
        End While
    End Sub
    Public Sub Cargar_grilla()
        If paso = 1 Then
            ds_PROD = DAVentas.Producto_x_Sucursal_obtener_todo(cb_origen.SelectedValue)
            If ds_PROD.Tables(0).Rows.Count <> 0 Then
                Producto_ds.Tables("ProdxSuc").Rows.Clear()
                Producto_ds.Tables("ProdxSuc").Merge(ds_PROD.Tables(0))
            Else
                Producto_ds.Tables("ProdxSuc").Rows.Clear()
            End If
            formato_grilla()
        End If
    End Sub
    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click

        'If DG_prod_modif.Rows.Count <> 0 Then
        '    Dim item = 0
        '    While item < DG_prod_modif.Rows.Count
        '        Dim variable As Integer = DG_prod_modif.Rows(item).Cells(3).Value

        '        Dim dt_provprodcom As New DataSet
        '        dt_provprodcom = DAproducto.Prov_prod_com_buscar(DG_prod_modif.Rows(item).Cells(3).Value) 'la colum 3 es prov_prod_com_id
        '        'busco en bd para ver si existe, y veo si hago un update o agregar uno nuevo
        '        If dt_provprodcom.Tables(0).Rows.Count <> 0 Then
        '            'modifico
        '            'FOTO  //////////////////////////////////////////////////////////////////////////////////////////////////





        '            Dim producto_foto As Byte()
        '            producto_foto = Nothing
        '            If PictureBox1.ImageLocation <> Nothing Then  'si tengo seleccionado una foto, la mando como parametro
        '                Dim ms = New MemoryStream
        '                Dim fs = New FileStream(PictureBox1.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        '                ms.SetLength(fs.Length)
        '                fs.Read(ms.GetBuffer(), 0, fs.Length)
        '                producto_foto = ms.GetBuffer
        '                ms.Flush()
        '                fs.Close()
        '            Else
        '                'si no tiene foto, le pongo x defecto la q esta en picture.image
        '                Dim ms = New MemoryStream
        '                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        '                producto_foto = ms.GetBuffer
        '                ms.Flush()
        '            End If
        '            Dim ds_provprodcom As DataSet = DAproducto.ProdProvCom_modificar(DG_prod_modif.Rows(item).Cells(3).Value, DG_prod_modif.Rows(item).Cells(6).Value, DG_prod_modif.Rows(item).Cells(10).Value)
        '            'Dim ds_prod As DataSet = DAproducto.Producto_modificar(DG_prod_modif.Rows(item).Cells(1).Value, DG_prod_modif.Rows(item).Cells(7).Value, DG_prod_modif.Rows(item).Cells(8).Value, DG_prod_modif.Rows(item).Cells(9).Value)
        '            Dim idmarca As Integer = cb_marca.SelectedValue
        '            Dim producto_id As Integer = DG_Producto.CurrentRow.Cells(0).Value
        '            Dim ds_proddatos As DataSet = DAproducto.Producto_modifDatos(producto_id, tx_descripcion.Text, tx_descrilarga.Text, tx_codbarra.Text, idmarca, tx_unimedida.Text, producto_foto)

        '        Else
        '            'doy de alta
        '            Dim ds_provprod As DataSet = DAproducto.ProveedorProducto_alta(DG_prod_modif.Rows(item).Cells(0).Value, DG_prod_modif.Rows(item).Cells(1).Value)
        '            Dim provprodid As Integer = ds_provprod.Tables(0).Rows(0).Item(0)
        '            DAproducto.ProveedorProductoCompra_alta(provprodid, DG_prod_modif.Rows(item).Cells(10).Value, DG_prod_modif.Rows(item).Cells(6).Value)

        '        End If
        '        item = item + 1
        '    End While
        '    MessageBox.Show("El producto se modifico correctamente", "Sistema de Gestion")
        '    DG_Producto.Rows.Clear()
        '    Prod_modif_limpiar()
        '    Me.TabControl1.SelectedTab = TabPage1
        '    'DG_prod_modif.Refresh()

        '    deshabilitar()
        'End If

    End Sub

    Public Sub Prod_modif_limpiar()
        'GroupBox1.Enabled = True
        ''DG_Producto.Rows.Clear()
        'DG_prod_modif.DataSource = Nothing
        'Producto_ds.Tables("ProductoModificar").Rows.Clear()
        'Tx_Codinterno.Text = Nothing
        'Tx_nomprod_modif.Text = Nothing
        'tx_codbarra_modif.Text = Nothing
        'Tx_cod_modif.Text = Nothing
        'tx_descripcion.Text = Nothing
        'tx_descrilarga.Text = Nothing
        'tx_unimedida.Text = Nothing
        'tx_codbarra.Text = Nothing
        'tx_codbarra_modif.Focus()
        ''recupero del portapapeles la imagen por defecto
        'Dim data As IDataObject
        'data = Clipboard.GetDataObject
        'Dim bmap As Bitmap
        'If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
        '    bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
        '    Me.PictureBox1.Image = bmap
        'End If
    End Sub

    Public Sub deshabilitar()
        'TabPage2.Enabled = False
        'TabPage3.Enabled = False
    End Sub
    Public Sub habilitar()
        'TabPage2.Enabled = True
        'TabPage3.Enabled = True
    End Sub

    Private Sub Buscar_codbarra()
        'If tx_codbarra_modif.Text <> "" Then
        '    Me.DG_Producto.Rows.Clear()
        '    Dim DS As New DataSet
        '    DS = DAproducto.producto_buscarcodbarra(Me.tx_codbarra_modif.Text)
        '    If DS.Tables(0).Rows.Count <> 0 Then
        '        Dim fila As Integer = 0
        '        While fila < DS.Tables(0).Rows.Count
        '            Me.DG_Producto.Rows().Add()
        '            DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
        '            DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(6) 'COD interno
        '            DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(1) 'producto
        '            DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(5) 'marca
        '            DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(3) 'Stock
        '            DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(4) 'ptoreposicion
        '            If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
        '                DG_Producto.Rows(fila).Cells(4).Style.ForeColor = Color.Red
        '                DG_Producto.Rows(fila).Cells(5).Style.ForeColor = Color.Red
        '                'DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
        '                'DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
        '            End If
        '            fila = fila + 1
        '        End While
        '        'DG_Producto.ClearSelection()
        '    End If
        '    Me.tx_codbarra_modif.Select()
        'Else
        '    Prod_obtenertodo()
        'End If

    End Sub

    Private Sub Bo_codbarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Buscar_codbarra()
    End Sub

    Public Sub Buscar_prodnom()
        'If Tx_nomprod_modif.Text <> "" Then
        '    Me.DG_Producto.Rows.Clear()
        '    Dim DS As New DataSet
        '    DS = DAproducto.producto_buscarnom(Me.Tx_nomprod_modif.Text)
        '    If DS.Tables(0).Rows.Count <> 0 Then
        '        Dim fila As Integer = 0
        '        While fila < DS.Tables(0).Rows.Count
        '            Me.DG_Producto.Rows().Add()
        '            DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
        '            DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(6) 'COD interno
        '            DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(1) 'producto
        '            DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(5) 'marca
        '            DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(3) 'Stock
        '            DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(4) 'ptoreposicion
        '            If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
        '                DG_Producto.Rows(fila).Cells(4).Style.ForeColor = Color.Red
        '                DG_Producto.Rows(fila).Cells(5).Style.ForeColor = Color.Red
        '                'DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
        '                'DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
        '            End If
        '            fila = fila + 1
        '        End While
        '        'DG_Producto.ClearSelection()
        '    End If
        '    Me.Tx_nomprod_modif.Select()
        'Else
        '    Prod_obtenertodo()
        'End If

    End Sub

    Private Sub Bo_buscar_nombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Buscar_prodnom()
    End Sub


    Private Sub Bo_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'OpenFileDialog1.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen

        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
        '    PictureBox1.Load(OpenFileDialog1.FileName)
        'End If
    End Sub

    Private Sub Bo_deshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''recupero del portapapeles la imagen por defecto
        'Dim data As IDataObject
        'data = Clipboard.GetDataObject
        'Dim bmap As Bitmap
        'If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
        '    bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
        '    Me.PictureBox1.Image = bmap
        'End If
    End Sub

    Private Sub Bo_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim saveImage As New SaveFileDialog 'Este es el SaveFileDialog
        'Dim ruta As String = "" 'Para tener la ruta de la imagen
        'saveImage.Title = "Guardar imagen como..." 'Título de la ventana
        'saveImage.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        'If saveImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    'Recuperar la ruta de la imagen si no está vacía
        '    If Not String.IsNullOrEmpty(saveImage.FileName) Then ruta = saveImage.FileName
        '    Dim myImg As Image = PictureBox1.Image 'Objeto Image para guardar la imagen del Picture

        '    Dim extension As String = ruta.Substring(ruta.Length - 3, 3) 'Recuperar los ultimos 3 caracteres de la extensió

        '    'ESTO SOLO FUNCIONA EN VISUAL BASIC 2008
        '    Select Case extension
        '        Case "bmp"
        '            myImg.Save(ruta, System.Drawing.Imaging.ImageFormat.Bmp) 'Guardar en formato BMP
        '        Case "jpg"
        '            PictureBox1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg) 'Guardar en formato JPG
        '        Case "png"
        '            PictureBox1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Png) 'Guardar en formato PNG
        '    End Select
        'End If
    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        'Producto_limpiar()
        'Prod_modif_limpiar()

        'GroupBox4.Enabled = False

        'deshabilitar()

        'Me.TabControl1.SelectedTab = TabPage1
        'GroupBox1.Enabled = True
        'DG_prod_modif.DataSource = Nothing
        'Producto_ds.Tables("ProductoModificar").Rows.Clear()

        ''DG_Producto.Rows.Clear()
        'tx_codbarra_modif.Text = Nothing
        'Tx_Codinterno.Text = Nothing
        'Tx_nomprod_modif.Text = Nothing
        ''recupero del portapapeles la imagen por defecto
        'Dim data As IDataObject
        'data = Clipboard.GetDataObject
        'Dim bmap As Bitmap
        'If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
        '    bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
        '    Me.PictureBox1.Image = bmap
        'End If

    End Sub
    'Validaciones
    Private Sub Tx_Codinterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_Buscqueda.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "prod_descripcion", Tx_Buscqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
        ProdxSucBindingSource.Filter = Filtro
        formato_grilla()
        If DG_Producto.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(prod_codinterno, System.String) LIKE '%{0}%'", Tx_Buscqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
            ProdxSucBindingSource.Filter = Filtro
            formato_grilla()
            If DG_Producto.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(prod_codbarra, System.String) LIKE '%{0}%'", Tx_Buscqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
                ProdxSucBindingSource.Filter = Filtro
                formato_grilla()
            End If
        End If
        'If RadioButton_desc.Checked = True Then 'Descripcion
        '    Dim Filtro
        '    Filtro = String.Format("{0} LIKE '%{1}%'", "prod_descripcion", Tx_Buscqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
        '    ProdxSucBindingSource.Filter = Filtro
        '    formato_grilla()
        'Else
        '    Dim Filtro
        '    'Filtro = String.Format("{0} = {1}", "Servicio_id", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        '    Filtro = String.Format("CONVERT(prod_codinterno, System.String) LIKE '%{0}%'", Tx_Buscqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
        '    ProdxSucBindingSource.Filter = Filtro
        '    formato_grilla()
        'End If
        'If RadioButton_desc.Checked = True Then
        'End If
    End Sub

    Private Sub Tx_nomprod_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Char.IsLetter(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_prodnom()
        End If
    End Sub

    Private Sub tx_codbarra_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_codbarra()
        End If
    End Sub

    Private Sub Tx_stock_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tx_ptorepo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Tx_compra_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ''aqui pongo el codigo para remplazar el punto por una coma
        'If e.KeyChar.ToString() = "." Then
        '    e.KeyChar = ","
        'End If
        ''a continuacion el codigo para impedir el ingreso de dos comas o letras
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    If Char.IsControl(e.KeyChar) Then
        '        e.Handled = False
        '    Else
        '        If e.KeyChar = "," And Not Me.Tx_compra_modif.Text.IndexOf(",") Then
        '            e.Handled = True
        '        Else
        '            If e.KeyChar = "," Then
        '                e.Handled = False
        '            Else
        '                e.Handled = True
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub tx_venta_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ''aqui pongo el codigo para remplazar el punto por una coma
        'If e.KeyChar.ToString() = "." Then
        '    e.KeyChar = ","
        'End If
        ''a continuacion el codigo para impedir el ingreso de dos comas o letras
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    If Char.IsControl(e.KeyChar) Then
        '        e.Handled = False
        '    Else
        '        If e.KeyChar = "," And Not Me.tx_venta_modif.Text.IndexOf(",") Then
        '            e.Handled = True
        '        Else
        '            If e.KeyChar = "," Then
        '                e.Handled = False
        '            Else
        '                e.Handled = True
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub BO_producto_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_producto_nuevo.Click
        Me.Close()
        Producto_alta_New.Close()
        Producto_alta_New.Show()
    End Sub

    Private Sub Tx_Codinterno_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tx_Buscqueda.GotFocus
        Tx_Buscqueda.SelectAll()
        Tx_Buscqueda.BackColor = Color.FromArgb(255, 255, 192)
    End Sub
    Private Sub cb_origen_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_origen.SelectedIndexChanged
        Cargar_grilla()
    End Sub

    Public Sub Cargarcombo_marca()
        'Cargar la Marca
        Dim ds_marca As DataSet = DAmarca.Marca_obtener
        cb_marca.DataSource = ds_marca.Tables(0)
        cb_marca.DisplayMember = "Marca_nom"
        cb_marca.ValueMember = "Marca_id"
        cb_marca.SelectedValue = ds_marca.Tables(0).Rows(0).Item("Marca_id")
    End Sub
    Dim ds_categoria As DataSet = DAcategoria.Categoria_obtener
    Private Sub cargar_combos_categoria()
        ds_categoria = DAcategoria.Categoria_obtener
        If ds_categoria.Tables(0).Rows.Count <> 0 Then
            'Carga la categoria
            cb_categoria.DataSource = ds_categoria.Tables(0)
            cb_categoria.DisplayMember = "cat1_nom"
            cb_categoria.ValueMember = "cat_id"
            cat1_id = cb_categoria.SelectedValue
            categoriarubro_obtener()
            rubrosubrubro_obtener()
            'Cargarcombo_marca()
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
                'check_rubro.Enabled = True
            Else
                cb_rubro.DataSource = Nothing
                cat2_id = 0 'asigno recurso vacio
                check_rubro.Checked = False
                check_rubro.Enabled = False
            End If
        End If
    End Sub
    Public Sub rubrosubrubro_obtener()
        If cat2_id <> 0 Then
            Dim cat2_id As Integer = cb_rubro.SelectedValue 'se vuelve a seleccionar el actual
            ds_subrubro = DAcategoria.rubrosubrubro_obtener(cat2_id)
            If ds_subrubro.Tables(0).Rows.Count <> 0 Then
                cb_subrubro.DataSource = ds_subrubro.Tables(0)
                cb_subrubro.DisplayMember = "cat3_nom"
                cb_subrubro.ValueMember = "cat3_id"
                'check_subrubro.Enabled = True
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

    Private Sub check_marca_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_marca.CheckedChanged
        If check_marca.Checked = True Then
            If cb_marca.Items.Count <> 0 Then
                cb_marca.Enabled = True
                check_categoria.Checked = False
                check_rubro.Checked = False
                check_subrubro.Checked = False
                If check_categoria.Checked = True Then
                    'aqui filtro por categoria y marca...para ello mando lo siguiente
                    filtrar_por_categoria("")
                Else
                    'aqui llamo a la rutina q trae filtrado por marca
                    filtrar_solo_por_marca()
                End If
            Else
                cb_marca.Enabled = False
            End If
        Else
            If check_subrubro.Checked = True Then
                check_subrubro.Checked = False
            End If
            If check_rubro.Checked = True Then
                check_rubro.Checked = False
            End If
            If check_categoria.Checked = True Then
                check_categoria.Checked = False
            End If
            cb_marca.Enabled = False
            Cargar_grilla()
        End If
    End Sub
    Private Sub check_categoria_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_categoria.CheckedChanged
        If check_categoria.Checked = True Then
            If cb_categoria.Items.Count <> 0 Then
                'check_marca.Checked = False

                If cb_rubro.Items.Count <> 0 Then
                    check_rubro.Enabled = True
                Else
                    check_rubro.Enabled = False
                End If


                cb_categoria.Enabled = True
                'una vez seleccionado, hago q filtre x la categoria actualmente seleccionada
                If check_marca.Checked = True Then
                    filtrar_por_categoria("")
                Else
                    filtrar_por_categoria("sin marca")
                End If
            Else
                cb_categoria.Enabled = False
            End If
        Else
            check_subrubro.Checked = False
            check_rubro.Checked = False
            check_subrubro.Enabled = False
            check_rubro.Enabled = False
            cb_categoria.Enabled = False
            If check_marca.Checked = True Then
                filtrar_solo_por_marca()
            Else
                'voy a traer todos los productos
                Cargar_grilla()
            End If
        End If
    End Sub

    Private Sub check_rubro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_rubro.CheckedChanged
        If check_rubro.Checked = True Then
            If cb_rubro.Items.Count <> 0 Then
                If cb_subrubro.Items.Count <> 0 Then
                    check_subrubro.Enabled = True
                Else
                    check_subrubro.Enabled = False
                End If


                cb_rubro.Enabled = True

                If check_marca.Checked = True Then
                    filtrar_por_rubro("")
                Else
                    filtrar_por_rubro("sin marca")
                End If
            End If
        Else
            check_subrubro.Checked = False
            check_subrubro.Enabled = False
            cb_rubro.Enabled = False
            If check_marca.Checked = True Then
                filtrar_por_categoria("")
            Else
                filtrar_por_categoria("sin marca")
            End If

        End If
    End Sub

    Private Sub check_subrubro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_subrubro.CheckedChanged
        If check_subrubro.Checked = True Then
            If cb_subrubro.Items.Count <> 0 Then
                cb_subrubro.Enabled = True

                If check_marca.Checked = True Then
                    filtrar_por_subrubro("")
                Else
                    filtrar_por_subrubro("sin marca")
                End If
            End If
        Else
            cb_subrubro.Enabled = False
            If check_marca.Checked = True Then
                filtrar_por_rubro("")
            Else
                filtrar_por_rubro("sin marca")
            End If
        End If
    End Sub


#Region "filtros venta gestion"
    Private Sub filtrar_por_categoria(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Producto_x_Sucursal_obtener_todo_categoria(cb_origen.SelectedValue)
        Else
            ds_productos = ds_prod_marca
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Producto_ds.Tables("ProdxSuc").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)

            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'busco en categoria
                    If id_categorias = idcat Then
                        'lo agrego
                        Dim row As DataRow = Producto_ds.Tables("ProdxSuc").NewRow()
                        row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                        row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                        row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                        row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                        row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                        row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                        row("ProdxSuc_stock") = ds_productos.Tables(0).Rows(i).Item("ProdxSuc_stock")
                        row("sucursal_id") = ds_productos.Tables(0).Rows(i).Item("sucursal_id")
                        row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                        Producto_ds.Tables("ProdxSuc").Rows.Add(row)
                    End If
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_categorias = ds_productos.Tables(2).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Producto_ds.Tables("ProdxSuc").NewRow()
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("ProdxSuc_stock") = ds_productos.Tables(0).Rows(i).Item("ProdxSuc_stock")
                                row("sucursal_id") = ds_productos.Tables(0).Rows(i).Item("sucursal_id")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                                Producto_ds.Tables("ProdxSuc").Rows.Add(row)
                                j = ds_productos.Tables(2).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_categorias = ds_productos.Tables(3).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Producto_ds.Tables("ProdxSuc").NewRow()
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("ProdxSuc_stock") = ds_productos.Tables(0).Rows(i).Item("ProdxSuc_stock")
                                row("sucursal_id") = ds_productos.Tables(0).Rows(i).Item("sucursal_id")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                                Producto_ds.Tables("ProdxSuc").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
            formato_grilla()
        End If
    End Sub
    Private Sub filtrar_por_rubro(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Producto_x_Sucursal_obtener_todo_categoria(cb_origen.SelectedValue)
        Else
            ds_productos = ds_prod_marca
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Producto_ds.Tables("ProdxSuc").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)
            Dim id_rubro As Integer = CInt(cb_rubro.SelectedValue)
            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'no lo pongo
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_rubro = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                                Dim row As DataRow = Producto_ds.Tables("ProdxSuc").NewRow()
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("ProdxSuc_stock") = ds_productos.Tables(0).Rows(i).Item("ProdxSuc_stock")
                                row("sucursal_id") = ds_productos.Tables(0).Rows(i).Item("sucursal_id")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                                Producto_ds.Tables("ProdxSuc").Rows.Add(row)
                                j = ds_productos.Tables(2).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_rubro = ds_productos.Tables(3).Rows(j).Item("Rubro_cat2_id") Then
                                Dim row As DataRow = Producto_ds.Tables("ProdxSuc").NewRow()
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("ProdxSuc_stock") = ds_productos.Tables(0).Rows(i).Item("ProdxSuc_stock")
                                row("sucursal_id") = ds_productos.Tables(0).Rows(i).Item("sucursal_id")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                                Producto_ds.Tables("ProdxSuc").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
            formato_grilla()
        End If
    End Sub
    Private Sub filtrar_por_subrubro(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Producto_x_Sucursal_obtener_todo_categoria(cb_origen.SelectedValue)
        Else
            ds_productos = ds_prod_marca
        End If
        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Producto_ds.Tables("ProdxSuc").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)
            Dim id_rubro As Integer = CInt(cb_rubro.SelectedValue)
            Dim id_subrubro As Integer = CInt(cb_subrubro.SelectedValue)
            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'no lo pongo
                End If
                If nrocat = 2 Then
                    'busco en rubro
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_subrubro = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                                Dim row As DataRow = Producto_ds.Tables("ProdxSuc").NewRow()
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("ProdxSuc_stock") = ds_productos.Tables(0).Rows(i).Item("ProdxSuc_stock")
                                row("sucursal_id") = ds_productos.Tables(0).Rows(i).Item("sucursal_id")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                                Producto_ds.Tables("ProdxSuc").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            formato_grilla()
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
    Dim ds_prod_marca As DataSet
    Private Sub filtrar_solo_por_marca()
        ds_prod_marca = DAVentas.Producto_x_Sucursal_obtener_todo_marca(cb_origen.SelectedValue, cb_marca.SelectedValue)
        Producto_ds.Tables("ProdxSuc").Rows.Clear()
        If ds_prod_marca.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Producto_ds.Tables("ProdxSuc").Merge(ds_prod_marca.Tables(0))
            formato_grilla()

        End If
        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
    End Sub
#End Region

    Private Sub cb_marca_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_marca.SelectedIndexChanged
        If check_marca.Checked = True Then
            If check_categoria.Checked = True Then
                'tengo q llamar a la rutina q filtre marcas y categorias
            Else
                'aqui llamo a la rutina q trae filtrado por marca
                filtrar_solo_por_marca()
            End If
        End If
        check_categoria.Checked = False
    End Sub
    Private Sub cb_categoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_categoria.SelectedIndexChanged
        categoriarubro_obtener()
        rubrosubrubro_obtener()
        If evento_load_completo = "si" Then
            If check_categoria.Checked = True Then
                If check_marca.Checked = True Then
                    filtrar_por_categoria("")
                Else
                    filtrar_por_categoria("sin marca")
                End If

                If cb_rubro.Items.Count <> 0 Then
                    check_rubro.Enabled = True
                Else
                    check_rubro.Enabled = False
                End If
            Else
                If check_marca.Checked = True Then
                    filtrar_solo_por_marca()
                Else
                    Cargar_grilla()
                End If
            End If
        End If

    End Sub
    Private Sub cb_rubro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_rubro.SelectedIndexChanged
        If evento_load_completo = "si" Then
            If check_rubro.Checked = True Then
                If check_marca.Checked = True Then
                    filtrar_por_rubro("")
                Else
                    filtrar_por_rubro("sin marca")
                End If

                If cb_subrubro.Items.Count <> 0 Then
                    check_subrubro.Enabled = True
                Else
                    check_subrubro.Enabled = False
                End If
            Else
                If check_categoria.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_categoria("")
                    Else
                        filtrar_por_categoria("sin marca")
                    End If
                Else
                    Cargar_grilla()
                End If
            End If
        End If
    End Sub
    Private Sub cb_subrubro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_subrubro.SelectedIndexChanged
        If evento_load_completo = "si" Then
            If check_subrubro.Checked = True Then
                If check_marca.Checked = True Then
                    filtrar_por_subrubro("")
                Else
                    filtrar_por_subrubro("sin marca")
                End If
            Else
                If check_marca.Checked = True Then
                    filtrar_por_rubro("")
                Else
                    filtrar_por_rubro("sin marca")
                End If
            End If
        End If
    End Sub

    Private Sub btn_Anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Anular.Click
        Dim pregunta = "no"
        Dim i As Integer = 0
        While i < DG_Producto.Rows.Count
            If DG_Producto.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                If pregunta = "no" Then
                    If MsgBox("Esta seguro que quiere borrar la informacion del item seleccionado?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                        pregunta = "si"
                    Else
                        'aqui corto el ciclo, ya que se cancelo la eliminacion
                        i = DG_Producto.Rows.Count
                    End If
                End If
                If pregunta = "si" Then
                    'aqui elimino - OJO es logica la eliminacion...solo pongo el estado del producto en "inactivo"
                    Dim prod_id As Integer = DG_Producto.Rows(i).Cells("prod_id").Value
                    DAproducto.Producto_eliminacion_logica(prod_id)
                End If
            End If
            i = i + 1
        End While

        '_____________________disparo el evento check_marca...para q vuelva a cargar los productos sin ningun tipo de filtro
        check_marca.Checked = False
        If check_subrubro.Checked = True Then
            check_subrubro.Checked = False
        End If
        If check_rubro.Checked = True Then
            check_rubro.Checked = False
        End If
        If check_categoria.Checked = True Then
            check_categoria.Checked = False
        End If
        cb_marca.Enabled = False
        Cargar_grilla()

        '_______________________________________________________________________________________________
    End Sub

    Private Sub DG_Producto_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DG_Producto.ColumnHeaderMouseClick
        formato_grilla()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

