Public Class GM_Consultar_Stock
    Dim DAsucursal As New Datos.Sucursal


    Dim DAlista As New Datos.Lista
    Dim DAVentas As New Datos.Venta
    Dim DAGestion_Mercaderia As New Datos.Gestion_Mercaderia
    Dim DApedidos As New Datos.Pedidos
    Dim DAmarca As New Datos.Marca
    Dim ds_PROD As DataSet
    Dim rb_no_combo As String = "no"
    Dim rb_si_combo As String = "no"
    Public form_procedencia As String = ""
    'Public sucursal_id As Integer = 0
    Public sucursal_nombre As String
    Dim DAcategoria As New Datos.Categoria
    Dim ds_categoria As DataSet = DAcategoria.Categoria_obtener
    Dim cat1_id As Integer = 0
    Dim cat2_id As Integer = 0
    Dim ds_rubro As DataSet
    Dim ds_subrubro As DataSet
    Dim evento_load_completo As String = "no"
    Dim dalote As New Datos.Lote
    Public paso = 0
    

    Private Sub Sucursales_Obtener()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        cb_sucursal.DataSource = ds.Tables(0)
        cb_sucursal.DisplayMember = "sucursal_nombre"
        cb_sucursal.ValueMember = "sucursal_id"
        paso = 1
    End Sub

    Private Sub GM_Consultar_Stock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub


    Public Sub LOAD_CARGA()
        paso = 0

        Sucursales_Obtener()

        Obtener_Productos_Combos()
        Cargarcombo_marca()
        cargar_combos_categoria()
        evento_load_completo = "si"
        'TextBox111.SetWaterMark("Descripcion o Codigo")

        TabPage2.Parent = Nothing 'oculto pestaña de lotes
        'TabPage4.Parent = Nothing 'oculto pestaña de lotes
        'TabPage2.Parent = TabControl1 'pongo visible pestaña 2

        'ahora recorro la grilla y agrego la cant de vencidos
        agregar_cant_vencida()
        formato_control_stock_vto()
    End Sub

    Private Sub agregar_cant_vencida()
        Dim j As Integer = 0
        While j < Venta_Caja_ds.Tables("Prod_consulta").Rows.Count
            'recupero los lotes del producto 
            Dim sucursal_id As Integer = cb_sucursal.SelectedValue
            Dim prodcodinterno As Integer = Venta_Caja_ds.Tables("Prod_consulta").Rows(j).Item("prod_codinterno")
            Dim ds_lotes As DataSet = dalote.Producto_x_sucursal_lote_recuperartodos(prodcodinterno, sucursal_id)
            Dim cant_vencidos As Decimal = CDec(0)
            If ds_lotes.Tables(0).Rows.Count <> 0 Then
                'aqui vemos si el item esta vencido o no, para sumarlo
                Dim i As Integer = 0
                While i < ds_lotes.Tables(0).Rows.Count
                    If (ds_lotes.Tables(0).Rows(i).Item("lote_vence") = "si") And (ds_lotes.Tables(0).Rows(i).Item("lote_cantidad") <> CDec(0)) Then
                        Dim fecha_vencimiento As Date = CDate(ds_lotes.Tables(0).Rows(i).Item("lote_fechavto"))
                        Dim fechadeldia As Date = Today
                        'If Format(fechadeldia, "yyyy/mm/dd") >= Format(fecha_vencimiento, "yyyy/mm/dd") Then
                        '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                        'Else
                        '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                        'End If
                        Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)
                        If cantdias <= 0 Then
                            'DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            cant_vencidos = cant_vencidos + CDec(ds_lotes.Tables(0).Rows(i).Item("lote_cantidad"))
                        Else
                            If cantdias > 15 Then
                                'DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            Else
                                'menor o igual a 15 
                                'DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Orange
                            End If
                        End If
                    End If
                    i = i + 1
                End While
            End If
            Venta_Caja_ds.Tables("Prod_consulta").Rows(j).Item("cant_vencimiento") = CDec(cant_vencidos)
            j = j + 1
        End While
    End Sub

    Private Sub Obtener_Productos_Combos()
        ds_PROD = DAventas.Venta_obtenerProducto_Combos_sucursal(cb_sucursal.SelectedValue)
        'junto los prod y los combos..para mostrarlos en el mismo grid
        With ds_PROD.Tables(2).Rows
            If .Count > 0 Then
                rb_no_combo = "si"
                'ds_PROD.Tables(1).Merge(ds_PROD.Tables(2)) choco: 04-07-2020 no uno las tablas, si ya no manejo combos
                Venta_Caja_ds.Tables("Prod_consulta").Rows.Clear()
                Venta_Caja_ds.Tables("Prod_consulta").Merge(ds_PROD.Tables(1))
                'DataGridView2.DataSource = ds_PROD.Tables(3)
                'Call Formato_combos()
                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                'TX_LISTA_PROD_cant.Text = "1"
                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
            Else
                'DataGridView1.Enabled = False
                If ds_PROD.Tables(1).Rows.Count <> 0 Then
                    Venta_Caja_ds.Tables("Prod_consulta").Rows.Clear()
                    Venta_Caja_ds.Tables("Prod_consulta").Merge(ds_PROD.Tables(1))
                Else
                    DataGridView1.DataSource = Nothing
                End If

                'IM_ERROR.Visible = True
                'LB_ERROR.Visible = True
            End If
        End With
    End Sub

    Public Sub Cargarcombo_marca()
        'Cargar la Marca
        Dim ds_marca As DataSet = DAmarca.Marca_obtener
        cb_marca.DataSource = ds_marca.Tables(0)
        cb_marca.DisplayMember = "Marca_nom"
        cb_marca.ValueMember = "Marca_id"
        cb_marca.SelectedValue = ds_marca.Tables(0).Rows(0).Item("Marca_id")
    End Sub

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


    Public Sub Cargar_grilla()
        If paso = 1 Then
            ds_PROD = DAVentas.Venta_obtenerProducto_Combos_sucursal(cb_sucursal.SelectedValue)
            'junto los prod y los combos..para mostrarlos en el mismo grid
            With ds_PROD.Tables(2).Rows
                If .Count > 0 Then
                    rb_no_combo = "si"
                    'ds_PROD.Tables(1).Merge(ds_PROD.Tables(2)) choco: 04-07-2020 no uno las tablas, si ya no manejo combos
                    Venta_Caja_ds.Tables("Prod_consulta").Rows.Clear()
                    Venta_Caja_ds.Tables("Prod_consulta").Merge(ds_PROD.Tables(1))
                    
                Else

                    If ds_PROD.Tables(1).Rows.Count <> 0 Then
                        Venta_Caja_ds.Tables("Prod_consulta").Rows.Clear()
                        Venta_Caja_ds.Tables("Prod_consulta").Merge(ds_PROD.Tables(1))
                    Else
                        DataGridView1.DataSource = Nothing
                    End If

                End If
            End With
        End If
    End Sub

    Private Sub cb_sucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_sucursal.SelectedIndexChanged
        Cargar_grilla()
        agregar_cant_vencida()
        formato_control_stock_vto()
    End Sub

    Private Sub formato_control_stock_vto()
        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                Dim stock As Decimal = CDec(DataGridView1.Rows(i).Cells("ProdstockDataGridViewTextBoxColumn").Value)
                Dim pto_reposicion As Decimal = CDec(DataGridView1.Rows(i).Cells("ProdptorepoDataGridViewTextBoxColumn").Value)

                If stock <= pto_reposicion Then
                    DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                End If
                i = i + 1

            End While
        End If



    End Sub

#Region "combos"
    Private Sub cb_marca_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_marca.SelectedIndexChanged
        If check_marca.Checked = True Then
            If check_categoria.Checked = True Then
                'tengo q llamar a la rutina q filtre marcas y categorias
            Else
                'aqui llamo a la rutina q trae filtrado por marca
                filtrar_solo_por_marca_GM()
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
                    filtrar_por_categoria_GM("")
                Else
                    filtrar_por_categoria_GM("sin marca")
                End If

                If cb_rubro.Items.Count <> 0 Then
                    check_rubro.Enabled = True
                Else
                    check_rubro.Enabled = False
                End If
            Else
                If check_marca.Checked = True Then
                    filtrar_solo_por_marca_GM()
                Else
                    Obtener_Productos_Combos()
                End If
            End If
        End If
    End Sub
    Private Sub cb_rubro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_rubro.SelectedIndexChanged
        If cb_rubro.Enabled = True Then
            rubrosubrubro_obtener()
            If evento_load_completo = "si" Then
                If check_rubro.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_rubro_GM("")
                    Else
                        filtrar_por_rubro_GM("sin marca")
                    End If
                    If cb_subrubro.Items.Count <> 0 Then
                        check_subrubro.Enabled = True
                    Else
                        check_subrubro.Enabled = False
                    End If
                Else
                    If check_categoria.Checked = True Then
                        If check_marca.Checked = True Then
                            filtrar_por_categoria_GM("")
                        Else
                            filtrar_por_categoria_GM("sin marca")
                        End If
                    Else
                        Obtener_Productos_Combos()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub cb_subrubro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_subrubro.SelectedIndexChanged
        If cb_subrubro.Enabled = True Then
            If evento_load_completo = "si" Then
                If check_subrubro.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_subrubro_GM("")
                    Else
                        filtrar_por_subrubro_GM("sin marca")
                    End If
                Else
                    If check_marca.Checked = True Then
                        filtrar_por_rubro_GM("")
                    Else
                        filtrar_por_rubro_GM("sin marca")
                    End If
                End If
            End If
        End If
        
    End Sub
#End Region

#Region "checks"
    Private Sub check_marca_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_marca.CheckedChanged
        If check_marca.Checked = True Then
            If cb_marca.Items.Count <> 0 Then
                cb_marca.Enabled = True
                check_categoria.Checked = False
                check_rubro.Checked = False
                check_subrubro.Checked = False
                If check_categoria.Checked = True Then
                    'aqui filtro por categoria y marca...para ello mando lo siguiente
                    filtrar_por_categoria_GM("")
                Else
                    'aqui llamo a la rutina q trae filtrado por marca
                    filtrar_solo_por_marca_GM()
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
            Obtener_Productos_Combos()
            agregar_cant_vencida()
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
                    filtrar_por_categoria_GM("")
                Else
                    filtrar_por_categoria_GM("sin marca")

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
                filtrar_solo_por_marca_GM()
            Else
                'voy a traer todos los productos
                Obtener_Productos_Combos()
                agregar_cant_vencida()
            End If
            'choco 25-09-2020 ////voy a deshabilitar rubro y subrubo, check y combobox
            check_rubro.Enabled = False
            check_subrubro.Enabled = False

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
                    filtrar_por_rubro_GM("")
                Else
                    filtrar_por_rubro_GM("sin marca")
                End If
            End If
        Else
            check_subrubro.Checked = False
            check_subrubro.Enabled = False
            cb_rubro.Enabled = False
            If check_marca.Checked = True Then
                filtrar_por_categoria_GM("")
            Else
                filtrar_por_categoria_GM("sin marca")
            End If
        End If
    End Sub
    Private Sub check_subrubro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_subrubro.CheckedChanged
        If check_subrubro.Checked = True Then
            If cb_subrubro.Items.Count <> 0 Then
                cb_subrubro.Enabled = True

                If check_marca.Checked = True Then
                    filtrar_por_subrubro_GM("")
                Else
                    filtrar_por_subrubro_GM("sin marca")
                End If
            End If
        Else
            cb_subrubro.Enabled = False
            If check_marca.Checked = True Then
                filtrar_por_rubro_GM("")
            Else
                filtrar_por_rubro_GM("sin marca")
            End If
        End If
    End Sub
#End Region


    

    

    

    

    

    

    


    

#Region "filtrar Gestion Mercaderia"
    Dim ds_prod_gestmerc
    Private Sub filtrar_solo_por_marca_GM()
        ds_prod_gestmerc = DAVentas.Venta_obtenerProducto_Combos_marca_GM(cb_sucursal.SelectedValue, cb_marca.SelectedValue)
        Venta_Caja_ds.Tables("Prod_consulta").Rows.Clear()
        If ds_prod_gestmerc.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Prod_consulta").Merge(ds_prod_gestmerc.Tables(0))

            agregar_cant_vencida()
        End If

    End Sub
    Private Sub filtrar_por_categoria_GM(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria_GM(cb_sucursal.SelectedValue) 'aqui tengo q pasar la sucursal_id
        Else
            ds_productos = ds_prod_gestmerc
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Prod_consulta").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)

            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'busco en categoria
                    If id_categorias = idcat Then
                        'lo agrego
                        Dim row As DataRow = Venta_Caja_ds.Tables("Prod_consulta").NewRow()
                        row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                        row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                        row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                        row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                        row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                        row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                        row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                        row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                        row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                        Venta_Caja_ds.Tables("Prod_consulta").Rows.Add(row)
                    End If
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_categorias = ds_productos.Tables(2).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Prod_consulta").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Prod_consulta").Rows.Add(row)
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Prod_consulta").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Prod_consulta").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If

        agregar_cant_vencida()
    End Sub
    Private Sub filtrar_por_rubro_GM(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria_GM(cb_sucursal.SelectedValue)
        Else
            ds_productos = ds_prod_gestmerc
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Prod_consulta").Rows.Clear()
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Prod_consulta").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Prod_consulta").Rows.Add(row)
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Prod_consulta").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Prod_consulta").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If

        agregar_cant_vencida()
    End Sub
    Private Sub filtrar_por_subrubro_GM(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria_GM(cb_sucursal.SelectedValue)
        Else
            ds_productos = ds_prod_gestmerc
        End If
        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Prod_consulta").Rows.Clear()
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Prod_consulta").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Prod_consulta").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If

        agregar_cant_vencida()

    End Sub


#End Region

    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        Dim Filtro
        Filtro = String.Format("CONVERT(prod_codinterno, System.String) LIKE '%{0}%'", tx_Buscar.Text)
        ProdconsultaBindingSource.Filter = Filtro
        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(prod_codbarra, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
            ProdconsultaBindingSource.Filter = Filtro
            If DataGridView1.Rows.Count = 0 Then
                Filtro = String.Format("{0} LIKE '%{1}%'", "prod_descripcion", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                ProdconsultaBindingSource.Filter = Filtro
            End If
        End If
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView2_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.ColumnHeaderMouseClick
        Dim a As Integer = 0
        While a < DataGridView2.Rows.Count
            If DataGridView2.Rows(a).Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                Dim fecha_vencimiento As Date = CDate(DataGridView2.Rows(a).Cells("LotefechavtoDataGridViewTextBoxColumn").Value)
                Dim fechadeldia As Date = Today
                'If Format(fechadeldia, "yyyy/mm/dd") >= Format(fecha_vencimiento, "yyyy/mm/dd") Then
                '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                'Else
                '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                'End If
                Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                If cantdias <= 0 Then
                    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                Else
                    If cantdias > 15 Then
                        DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                    Else
                        'menor o igual a 15 
                        DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Orange
                    End If

                End If
            Else
                DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
            End If
            a = a + 1
        End While
    End Sub

    Private Sub DataGridView2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.SelectionChanged
        If DataGridView2.Rows.Count <> 0 Then
            If DataGridView2.CurrentRow.Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                Dim fecha_vencimiento As Date = CDate(DataGridView2.CurrentRow.Cells("LotefechavtoDataGridViewTextBoxColumn").Value)
                Dim fechadeldia As Date = Today

                Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                If cantdias <= 0 Then
                    DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Red
                Else
                    If cantdias > 15 Then
                        DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                    Else
                        'menor o igual a 15 
                        DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Orange
                    End If
                End If
            Else
                DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        'aqui voy a validar que si esta vencido se ponga en rojo la celda.
        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                Dim stock As Decimal = CDec(DataGridView1.Rows(i).Cells("ProdstockDataGridViewTextBoxColumn").Value)
                Dim pto_reposicion As Decimal = CDec(DataGridView1.Rows(i).Cells("ProdptorepoDataGridViewTextBoxColumn").Value)
                If stock <= pto_reposicion Then
                    DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                End If
                i = i + 1
            End While
        End If

        If DataGridView1.Columns(e.ColumnIndex).Name = "CantvencimientoDataGridViewTextBoxColumn" Then 'esto significa que voy a validar esta celda
            Dim vencidos As Decimal
            If IsDBNull(e.Value) Then
                vencidos = CDec(0)
            Else
                vencidos = CDec(e.Value)
            End If
            If vencidos <> CDec(0) Then
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionForeColor = Color.Red
            End If
        End If


    End Sub


    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        formato_control_stock_vto() 'cuando click en el encabezado de las columnas se vuelve a poner los colores correspondientes
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0

            Dim stock As Decimal = CDec(DataGridView1.CurrentRow.Cells("ProdstockDataGridViewTextBoxColumn").Value)
            Dim pto_reposicion As Decimal = CDec(DataGridView1.CurrentRow.Cells("ProdptorepoDataGridViewTextBoxColumn").Value)

            If stock <= pto_reposicion Then
                DataGridView1.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Blue
            Else
                DataGridView1.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black
            End If
        End If

        'DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Red


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabPage2.Parent = Nothing 'oculto pestaña 2
        TabPage1.Parent = TabControl1 'pongo visible pestaña 1
        'pasamos a la otra pestaña
        TabControl1.SelectedTab = TabPage1

        'limpio los textbos del tabpage1
        txt_codigo.Clear()
        txt_descripcion.Clear()
        txt_totalunidades.Clear()
        'txt_lote.Clear()
        'txt_fechafab.Clear()
        'txt_fechvto.Clear()
        'txt_cantlote.Clear()
    End Sub

    Private Sub BO_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ver.Click
        If DataGridView1.Rows.Count <> 0 Then
            If DataGridView1.CurrentRow.Selected = True Then 'valido check
                Dim sucursal_id As Integer = cb_sucursal.SelectedValue
                TabPage1.Parent = Nothing 'oculto pestaña 1
                TabPage2.Parent = TabControl1 'pongo visible pestaña 2
                'pasamos a la otra pestaña
                TabControl1.SelectedTab = TabPage2



                'colocamos la info en los label del tabpage2
                '////////////////////////////////////////////////
                txt_codigo.Text = DataGridView1.CurrentRow.Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
                txt_descripcion.Text = DataGridView1.CurrentRow.Cells("ProddescripcionDataGridViewTextBoxColumn").Value
                txt_totalunidades.Text = DataGridView1.CurrentRow.Cells("ProdstockDataGridViewTextBoxColumn").Value



                DataGridView2.DataSource = Nothing
                Dim prodcodinterno As Integer = DataGridView1.CurrentRow.Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
                Dim ds_lotes As DataSet = dalote.Producto_x_sucursal_lote_recuperartodos(prodcodinterno, sucursal_id)

                If ds_lotes.Tables(0).Rows.Count <> 0 Then
                    Mov_DS.Tables("lote_baja").Rows.Clear()

                    Dim i As Integer = 0
                    While i < ds_lotes.Tables(0).Rows.Count
                        Dim nuevoRow As DataRow = Mov_DS.Tables("lote_baja").NewRow
                        nuevoRow("prod_id") = ds_lotes.Tables(0).Rows(i).Item("prod_id")
                        nuevoRow("prod_codinterno") = ds_lotes.Tables(0).Rows(i).Item("prod_codinterno")
                        nuevoRow("prod_descripcion") = ds_lotes.Tables(0).Rows(i).Item("prod_descripcion")
                        nuevoRow("ProdxSuc_stock") = ds_lotes.Tables(0).Rows(i).Item("ProdxSuc_stock")
                        nuevoRow("lote_id") = ds_lotes.Tables(0).Rows(i).Item("lote_id")
                        nuevoRow("lote_nro") = ds_lotes.Tables(0).Rows(i).Item("lote_nro")
                        nuevoRow("lote_cantidad") = ds_lotes.Tables(0).Rows(i).Item("lote_cantidad")
                        nuevoRow("lote_vence") = ds_lotes.Tables(0).Rows(i).Item("lote_vence")
                        If ds_lotes.Tables(0).Rows(i).Item("lote_vence") = "si" Then
                            nuevoRow("lote_fechafab") = ds_lotes.Tables(0).Rows(i).Item("lote_fechafab")
                            nuevoRow("lote_fechavto") = ds_lotes.Tables(0).Rows(i).Item("lote_fechavto")
                        End If
                        nuevoRow("sucursal_id") = ds_lotes.Tables(0).Rows(i).Item("sucursal_id")
                        nuevoRow("Prov_id") = ds_lotes.Tables(0).Rows(i).Item("Prov_id")
                        nuevoRow("Proveedor") = ds_lotes.Tables(0).Rows(i).Item("Proveedor")


                        Mov_DS.Tables("lote_baja").Rows.Add(nuevoRow)
                        i = i + 1
                    End While
                    'Mov_DS.Tables("lote_baja").Merge(ds_lotes.Tables(0))
                    DataGridView2.DataSource = Mov_DS.Tables("lote_baja")

                    'ahora ponemos con colores los productos en verde, amarillo y rojo.

                    Dim a As Integer = 0
                    While a < DataGridView2.Rows.Count
                        If DataGridView2.Rows(a).Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                            Dim fecha_vencimiento As Date = CDate(DataGridView2.Rows(a).Cells("LotefechavtoDataGridViewTextBoxColumn").Value)
                            Dim fechadeldia As Date = Today


                            'If Format(fechadeldia, "yyyy/mm/dd") >= Format(fecha_vencimiento, "yyyy/mm/dd") Then
                            '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            'Else
                            '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            'End If


                            Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                            If cantdias <= 0 Then
                                DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            Else
                                If cantdias > 15 Then
                                    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                                Else
                                    'menor o igual a 15 
                                    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Orange
                                End If

                            End If

                        End If
                        a = a + 1
                    End While


                End If
            Else
                MessageBox.Show("Error, seleccione un producto.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Error, Debe seleccionar un producto.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Dim Ds_reporte_historial As New Ds_reporte_historial

    Dim DAventa As New Datos.Venta


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("¿Desea generar un reporte con la información de la consulta actual?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            '///////////////TABLA SUCURSAL Y EMPRESA///////////////////////////// 
            Dim ds_suc_y_empresa As DataSet = DAsucursal.Obtener_sucursal_y_empresa(cb_sucursal.SelectedValue)
            Ds_reporte_historial.Tables("Sucursal").Rows.Clear()
            Ds_reporte_historial.Tables("Empresa").Rows.Clear()
            If ds_suc_y_empresa.Tables(1).Rows.Count <> 0 Then

                Ds_reporte_historial.Tables("Empresa").Merge(ds_suc_y_empresa.Tables(1))
            End If

            If ds_suc_y_empresa.Tables(0).Rows.Count <> 0 Then

                Ds_reporte_historial.Tables("Sucursal").Merge(ds_suc_y_empresa.Tables(0))
            End If

            '//////////////////TABLA PRODUCTOS LISTADOS//////////////////////////
            Ds_reporte_historial.Tables("Prod_consulta").Rows.Clear()
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                Dim fila As DataRow = Ds_reporte_historial.Tables("Prod_consulta").NewRow
                fila("prod_id") = DataGridView1.Rows(i).Cells("ProdidDataGridViewTextBoxColumn").Value
                fila("prod_codinterno") = DataGridView1.Rows(i).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
                fila("prod_descripcion") = DataGridView1.Rows(i).Cells("ProddescripcionDataGridViewTextBoxColumn").Value
                fila("prod_descrilarga") = DataGridView1.Rows(i).Cells("ProddescrilargaDataGridViewTextBoxColumn").Value
                fila("prod_precio_vta") = DataGridView1.Rows(i).Cells("ProdpreciovtaDataGridViewTextBoxColumn").Value
                fila("prod_stock") = DataGridView1.Rows(i).Cells("ProdstockDataGridViewTextBoxColumn").Value
                fila("prod_ptorepo") = DataGridView1.Rows(i).Cells("ProdptorepoDataGridViewTextBoxColumn").Value
                fila("prod_precio_vta_May") = DataGridView1.Rows(i).Cells("ProdpreciovtaMayDataGridViewTextBoxColumn").Value
                fila("prod_codbarra") = DataGridView1.Rows(i).Cells("ProdcodbarraDataGridViewTextBoxColumn").Value
                fila("cant_vencimiento") = DataGridView1.Rows(i).Cells("CantvencimientoDataGridViewTextBoxColumn").Value

                Ds_reporte_historial.Tables("Prod_consulta").Rows.Add(fila)
                i = i + 1
            End While

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Stock_a_CR.rpt")
            'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
            CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_historial.Tables("Empresa"))
            CrReport.Database.Tables("Sucursal").SetDataSource(Ds_reporte_historial.Tables("Sucursal"))
            CrReport.Database.Tables("Prod_consulta").SetDataSource(Ds_reporte_historial.Tables("Prod_consulta"))
            Dim visor As New Stock_disponible_show
            visor.CrystalReportViewer1.ReportSource = CrReport
            visor.Text = "Consulta de Stock. Sucursal: " + cb_sucursal.Text + " - Imprimir."
            visor.Show()
        End If
    End Sub

    Private Sub GM_Consultar_Stock_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TabPage2.Parent = Nothing 'oculto pestaña de lotes
        msj_esperar_sesiones.procedencia = "GM_Consultar_Stock_load"
        msj_esperar_sesiones.Show()
    End Sub
End Class