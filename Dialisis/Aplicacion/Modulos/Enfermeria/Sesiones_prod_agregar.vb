Public Class Sesiones_prod_agregar
    Dim DAlista As New Datos.Lista
    Dim DAVentas As New Datos.Venta
    Dim DAGestion_Mercaderia As New Datos.Gestion_Mercaderia
    Dim DApedidos As New Datos.Pedidos
    Dim DAmarca As New Datos.Marca
    Dim ds_PROD As DataSet
    Dim rb_no_combo As String = "no"
    Dim rb_si_combo As String = "no"
    Public form_procedencia As String = ""
    Public sucursal_id As Integer = 0
    Public sucursal_nombre As String
    Dim DAcategoria As New Datos.Categoria
    Dim ds_categoria As DataSet = DAcategoria.Categoria_obtener
    Dim cat1_id As Integer = 0
    Dim cat2_id As Integer = 0
    Dim ds_rubro As DataSet
    Dim ds_subrubro As DataSet
    Dim evento_load_completo As String = "no"
    Dim tipo_producto As String 'este parametro me dice si es fraccionable o no
    Public tipo_movimiento As String = "baja producto"

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

    Public Sub Cargarcombo_marca()
        'Cargar la Marca
        Dim ds_marca As DataSet = DAmarca.Marca_obtener
        cb_marca.DataSource = ds_marca.Tables(0)
        cb_marca.DisplayMember = "Marca_nom"
        cb_marca.ValueMember = "Marca_id"
        cb_marca.SelectedValue = ds_marca.Tables(0).Rows(0).Item("Marca_id")
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

    Public Sub Obtener_Productos_Combos()
        'esta rutina la uso para traer todos los producos...solo la usi en el caso de que en el form: VENTA_CAHA_GESTION...se seleccione
        'configurar lista = NO
        Select Case form_procedencia
            Case "Venta_Caja_gestion" 'LISTO, ANDA CON LOS COMBOS PARA FILTRAR
                If Venta_Caja_gestion.RB_Si.Checked = False Then
                    ds_PROD = DAVentas.Venta_obtenerProducto_Combos(Inicio.USU_id)
                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With ds_PROD.Tables(2).Rows
                        If .Count > 0 Then
                            rb_no_combo = "si"
                            ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                            'DataGridView1.DataSource = ds_PROD.Tables(1) choco: 13-11-2018 la uso antes de los filtros x marca, categorias
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
                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                                Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                                'DataGridView1.DataSource = ds_PROD.Tables(1) choco: 13-11-2018 la uso antes de los filtros x marca, categorias
                            Else
                                DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                Else
                    If Venta_Caja_gestion.RB_No.Checked = False Then
                        ds_PROD = DAVentas.Venta_obtenerProducto_listaregular(Venta_Caja_gestion.CB_lista.SelectedValue)

                        'junto los prod y los combos..para mostrarlos en el mismo grid
                        With ds_PROD.Tables(1).Rows
                            If .Count > 0 Then
                                rb_si_combo = "si"
                                ds_PROD.Tables(0).Merge(ds_PROD.Tables(1))
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                                'Call Formato_combos()
                                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_cant.Text = "1"
                                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                            Else

                                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                                    DataGridView1.DataSource = ds_PROD.Tables(0)
                                Else
                                    DataGridView1.Enabled = False
                                    DataGridView1.DataSource = Nothing
                                End If

                                'IM_ERROR.Visible = True
                                'LB_ERROR.Visible = True
                            End If
                        End With
                    End If
                End If
            Case "Mesas_gestion"

                If Mesas_gestion.RB_Si.Checked = False Then


                    ds_PROD = DAVentas.Venta_obtenerProducto_Combos(Inicio.USU_id)

                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With ds_PROD.Tables(2).Rows
                        If .Count > 0 Then
                            rb_no_combo = "si"
                            ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                            DataGridView1.DataSource = ds_PROD.Tables(1)
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
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                Else
                    If Mesas_gestion.RB_No.Checked = False Then
                        ds_PROD = DAVentas.Venta_obtenerProducto_listaregular(Mesas_gestion.CB_lista.SelectedValue)

                        'junto los prod y los combos..para mostrarlos en el mismo grid
                        With ds_PROD.Tables(1).Rows
                            If .Count > 0 Then
                                rb_si_combo = "si"
                                ds_PROD.Tables(0).Merge(ds_PROD.Tables(1))
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                                'Call Formato_combos()
                                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_cant.Text = "1"
                                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                            Else

                                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                                    DataGridView1.DataSource = ds_PROD.Tables(0)
                                Else
                                    DataGridView1.Enabled = False
                                    DataGridView1.DataSource = Nothing
                                End If

                                'IM_ERROR.Visible = True
                                'LB_ERROR.Visible = True
                            End If
                        End With
                    End If
                End If

            Case "Pedido_Productos" 'listo, funciona con combos para filtrar, marca, cat, rubro y subrubro
                DataGridView1.Columns("ProdstockDataGridViewTextBoxColumn").Visible = False 'oculto la columna de stock para no confundir, ya que estra me trae el stock en 0

                ds_PROD = DApedidos.Productos_x_Proveedor_Obtener(Pedido_Productos.Prove_ID) 'choco: 11-12-2018 agregado cbarra
                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                    Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                    Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(0))
                    'DataGridView1.DataSource = ds_PROD.Tables(0)
                Else
                    DataGridView1.DataSource = Nothing
                End If

            Case "Mesa_cargar"
                If Mesa_cargar.RB_Si = False Then
                    ds_PROD = DAVentas.Venta_obtenerProducto_Combos(Inicio.USU_id)
                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With ds_PROD.Tables(2).Rows
                        If .Count > 0 Then
                            rb_no_combo = "si"
                            ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                            DataGridView1.DataSource = ds_PROD.Tables(1)
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
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                Else
                    If Mesa_cargar.RB_No = False Then
                        ds_PROD = DAVentas.Venta_obtenerProducto_listaregular(Mesa_cargar.CB_lista)

                        'junto los prod y los combos..para mostrarlos en el mismo grid
                        With ds_PROD.Tables(1).Rows
                            If .Count > 0 Then
                                rb_si_combo = "si"
                                ds_PROD.Tables(0).Merge(ds_PROD.Tables(1))
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                                'Call Formato_combos()
                                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_cant.Text = "1"
                                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                            Else

                                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                                    DataGridView1.DataSource = ds_PROD.Tables(0)
                                Else
                                    DataGridView1.Enabled = False
                                    DataGridView1.DataSource = Nothing
                                End If
                                'IM_ERROR.Visible = True
                                'LB_ERROR.Visible = True
                            End If
                        End With
                    End If
                End If
            Case "GM_Carga_Producto"

                '/////////////////////choco 04-07-2020 comente esto, no se porque no me trae el stock real, siempre trae en 0
                ''DataGridView1.Columns("ProdstockDataGridViewTextBoxColumn").Visible = False 'oculto la columna de stock para no confundir, ya que estra me trae el stock en 0
                ''DataGridView1.Columns("prod_precio_vta_May").Visible = False 'oculto tambien la columna de precio mayorista
                'ds_PROD = DAGestion_Mercaderia.Movimiento_Mercaderia_obtenerProducto_Combos()
                'With ds_PROD.Tables(2).Rows
                '    If .Count > 0 Then
                '        rb_no_combo = "si"
                '        ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                '        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                '        Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))

                '    Else
                '        If ds_PROD.Tables(1).Rows.Count <> 0 Then
                '            'DataGridView1.DataSource = ds_PROD.Tables(1)
                '            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                '            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                '        Else
                '            DataGridView1.DataSource = Nothing
                '        End If
                '    End If
                'End With
                '/////////////////////////fin choco 04-07-2020

            Case "Gestion_Mercaderia"
                'aqui solamente muestro los productos en stock en una determinada sucursal, para ello necesito el id de sucursal.

                'Me.Text = "Stock en Sucursal: " + sucursal_nombre

                'BO_agregar.Visible = False 'choco-04-07-2020
                ds_PROD = DAVentas.Venta_obtenerProducto_Combos_sucursal(sucursal_id)
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

            Case "Servicio_nuevo"
                DataGridView1.Columns("ProdstockDataGridViewTextBoxColumn").Visible = False 'oculto la columna de stock para no confundir, ya que estra me trae el stock en 0
                ds_PROD = DAGestion_Mercaderia.Movimiento_Mercaderia_obtenerProducto_Combos()
                With ds_PROD.Tables(2).Rows
                    If .Count > 0 Then
                        rb_no_combo = "si"
                        ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                        'DataGridView1.DataSource = ds_PROD.Tables(1)
                        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                        Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                    Else
                        If ds_PROD.Tables(1).Rows.Count <> 0 Then
                            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                        Else
                            DataGridView1.DataSource = Nothing
                        End If
                    End If
                End With
        End Select



    End Sub

    Private Sub Sesiones_prod_agregar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Public Sub LOAD_CARGA()
        Obtener_Productos_Combos()
        Cargarcombo_marca()
        cargar_combos_categoria()
        agregar_cant_vencida()
        'formato_control_stock_vto()
        evento_load_completo = "si"
        'TextBox111.SetWaterMark("Descripcion o Codigo")

        TabPage2.Parent = Nothing 'oculto pestaña de lotes
        TabPage4.Parent = Nothing 'oculto pestaña de lotes
        'TabPage2.Parent = TabControl1 'pongo visible pestaña 2
    End Sub

    '
    Private Sub agregar_cant_vencida()
        Dim j As Integer = 0
        While j < Venta_Caja_ds.Tables("Prod_consulta").Rows.Count
            'recupero los lotes del producto 
            'Dim sucursal_id As Integer = cb_sucursal.SelectedValue
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

    Private Sub Buscar_y_cargar_en_grilla(ByVal cod_ingresado As Integer)
        Dim existe_en_grilla As String = "no"
        Dim Encontrado = "no" 'siempre por defecto, "IMPÒRTANTISIMO"
        Dim i As Integer = 0

        Select Case Venta_Caja_gestion.tipo_vta
            Case "Minorista"
                'AQUI SOLO BUSCO EN TABLA PRODUCTOS, NO EN PROMOCIONES
                While i < Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count 'la tabla 1 es para los prod comunes, no para los de la lista regular
                    Dim cod_interno As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    Dim cod_barra As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                    If cod_ingresado = cod_interno Or CStr(cod_ingresado) = cod_barra Then
                        Venta_Caja_gestion.buscar_en_grilla_y_sumar_mas_uno(cod_interno, existe_en_grilla)
                        If existe_en_grilla = "no" Then
                            Dim index As Integer = Venta_Caja_gestion.DataGridView1.Rows.Count - 1
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_item").Value = CInt(Venta_Caja_gestion.DataGridView1.Rows.Count)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_prod_id").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codinterno").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_descripcion").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_detalle").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_cantidad").Value = CInt(1)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_unitario").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta")
                            Dim total As Decimal = 0
                            total = CDec(Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta"))
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_subtotal").Value = CDec(total)   'CDec(Math.Round(total, 2)).ToString("N2")
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codbarra").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("descuento").Value = CInt(0)
                            Venta_Caja_gestion.DataGridView1.Rows.Add() 'AGREGO UNO EXTRA PARA EL PROXIMO ITEM
                        End If
                        Encontrado = "si"
                        i = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count
                    End If
                    i = i + 1
                End While
            Case "Mayorista"
                'AQUI SOLO BUSCO EN TABLA PRODUCTOS, NO EN PROMOCIONES
                While i < Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count 'la tabla 1 es para los prod comunes, no para los de la lista regular
                    Dim cod_interno As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    Dim cod_barra As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                    If cod_ingresado = cod_interno Or CStr(cod_ingresado) = cod_barra Then
                        Venta_Caja_gestion.buscar_en_grilla_y_sumar_mas_uno(cod_interno, existe_en_grilla) 'aqui lo busco en gridview1 y sumo + 1 si ya existe en la grilla
                        If existe_en_grilla = "no" Then
                            Dim index As Integer = Venta_Caja_gestion.DataGridView1.Rows.Count - 1
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_item").Value = CInt(Venta_Caja_gestion.DataGridView1.Rows.Count)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_prod_id").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codinterno").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_descripcion").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_detalle").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_cantidad").Value = CInt(1)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_unitario").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta_May")
                            Dim total As Decimal = 0
                            total = CDec(Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta_May"))
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_subtotal").Value = CDec(total)   'CDec(Math.Round(total, 2)).ToString("N2")
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codbarra").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("descuento").Value = CInt(0)
                            Venta_Caja_gestion.DataGridView1.Rows.Add() 'AGREGO UNO EXTRA PARA EL PROXIMO ITEM
                        End If
                        Encontrado = "si"
                        i = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count
                    End If
                    i = i + 1
                End While
        End Select
        'If Encontrado = "no" Then
        '    i = 0
        '    'Lo busco como promocion
        '    While i < VentaGestion_ds_PROMO.Tables(0).Rows.Count
        '        Dim cod_interno As String = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '        If cod_ingresado.ToString.ToUpper = cod_interno Then
        '            DataGridView1.CurrentRow.Cells("columna_item").Value = CInt(DataGridView1.CurrentRow.Index + 1)
        '            DataGridView1.CurrentRow.Cells("columna_prod_id").Value = " "
        '            DataGridView1.CurrentRow.Cells("columna_codinterno").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '            DataGridView1.CurrentRow.Cells("columna_descripcion").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
        '            DataGridView1.CurrentRow.Cells("columna_detalle").Value = " "
        '            DataGridView1.CurrentRow.Cells("columna_cantidad").Value = CInt(1)
        '            DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
        '            Dim total As Decimal = 0
        '            total = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
        '            DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(total) 'CDec(Math.Round(total, 2)).ToString("N2")
        '            DataGridView1.CurrentRow.Cells("columna_codbarra").Value = " "

        '            Encontrado = "si"
        '            i = VentaGestion_ds_PROMO.Tables(0).Rows.Count
        '        End If
        '        i = i + 1
        '    End While
        'End If
        'If Encontrado = "no" Then
        '    'buscar por codigo de barras
        '    MsgBox("No Existe el Producto")
        'Else
        '    calcular_totales()
        'End If
        Venta_Caja_gestion.calcular_totales()
        Venta_Caja_gestion.aplicar_iva()
    End Sub

    Public Sub Pedido_Buscar_y_cargar_en_grilla(ByVal cod_ingresado As Integer)
        Dim Encontrado As String = "no"
        Dim i As Integer = 0
        While i < ds_PROD.Tables(0).Rows.Count
            Dim cod_interno As String = ds_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
            If cod_ingresado = cod_interno Then
                Dim index As Integer = Pedido_Productos.DataGridView1.CurrentRow.Index
                Pedido_Productos.DataGridView1.CurrentRow.Cells("item_num").Value = CInt(Pedido_Productos.DataGridView1.CurrentRow.Index + 1)
                Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_id").Value = ds_PROD.Tables(0).Rows(i).Item("prod_id").ToString
                Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_codinterno").Value = ds_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
                Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_descripcion").Value = ds_PROD.Tables(0).Rows(i).Item("prod_descripcion").ToString
                Pedido_Productos.DataGridView1.CurrentRow.Cells("Cantidad").Value = CInt(1)
                Encontrado = "si"
            End If
            i = i + 1
        End While
        If Encontrado = "no" Then
            'buscar por codigo de barras
            Pedido_Productos.DataGridView1.CurrentRow.Cells("item_num").Value = ""
            Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_id").Value = ""
            Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_codinterno").Value = ""
            Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_descripcion").Value = ""
            Pedido_Productos.DataGridView1.CurrentRow.Cells("Cantidad").Value = ""
            MsgBox("No Existe el Producto")
        End If
        'If Pedido_Productos.DataGridView1.Rows(Pedido_Productos.DataGridView1.Rows.Count - 1).Cells(2).Value <> "" Then
        '    Pedido_Productos.DataGridView1.Rows.Add()
        'End If


    End Sub



    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "Pedido_Productos" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Gestion_Mercaderia" Or form_procedencia = "Servicio_nuevo" Then
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
            'Filtro = String.Format("{0} LIKE '%{1}%'", "prod_descripcion", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
            'ProdconsultaBindingSource.Filter = Filtro
            'If DataGridView1.Rows.Count = 0 Then
            '    Filtro = String.Format("CONVERT(prod_codinterno, System.String) LIKE '%{0}%'", tx_Buscar.Text)
            '    ProdconsultaBindingSource.Filter = Filtro
            '    If DataGridView1.Rows.Count = 0 Then
            '        Filtro = String.Format("CONVERT(prod_codbarra, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
            '        ProdconsultaBindingSource.Filter = Filtro
            '    End If
            'End If
        Else
            If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER calcula
                DataGridView1.DataSource = Nothing
                If tx_Buscar.Text <> "" Then
                    Filtrar_datatable(tx_Buscar.Text)
                Else
                    Select Case form_procedencia
                        Case "Venta_Caja_gestion"
                            If Venta_Caja_gestion.RB_No.Checked = True Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                            End If
                        Case "Mesas_gestion"
                            If Mesas_gestion.RB_No.Checked = True Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                            End If
                        Case "Mesa_cargar"
                            If Mesa_cargar.RB_No = True Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                            End If
                        Case "GM_Carga_Producto"
                            DataGridView1.DataSource = ds_PROD.Tables(1)
                        Case "Pedido_Productos"
                            DataGridView1.DataSource = ds_PROD.Tables(0)
                    End Select
                End If
                tx_Buscar.SelectAll()
            End If
        End If
    End Sub

    Private Sub Filtrar_datatable(ByVal parametro As String)
        Dim T As Integer = 0
        Select Case form_procedencia
            Case "Venta_Caja_gestion"
                If Venta_Caja_gestion.RB_No.Checked = True Then
                    T = 1
                Else
                    T = 0
                End If
            Case "Mesas_gestion"
                'Dim T As Integer = 0
                If Mesas_gestion.RB_No.Checked = True Then
                    T = 1
                Else
                    T = 0
                End If
            Case "Mesa_cargar"
                'Dim T As Integer = 0
                If Mesa_cargar.RB_No = True Then
                    T = 1
                Else
                    T = 0
                End If
            Case "GM_Carga_Producto"
                T = 1
        End Select

        If ds_PROD.Tables(T).Rows.Count <> 0 Then
            'uso ds_PROD que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("prod_id")
            table_filtrada.Columns.Add("prod_codinterno")
            table_filtrada.Columns.Add("prod_descripcion")
            table_filtrada.Columns.Add("prod_descrilarga")
            table_filtrada.Columns.Add("prod_precio_vta")
            table_filtrada.Columns.Add("prod_stock")
            table_filtrada.Columns.Add("prod_ptorepo")
            table_filtrada.Columns.Add("prod_precio_vta_May")
            DataGridView1.DataSource = Nothing
            Dim table As DataTable = ds_PROD.Tables(T)
            Dim nombre As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("prod_descripcion")
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If

                a = a + 1
            End While
            If table_filtrada.Rows.Count <> 0 Then
                DataGridView1.DataSource = table_filtrada
            Else
                DataGridView1.DataSource = ds_PROD.Tables(T)
            End If
        End If
    End Sub


    Private Sub cb_categoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_categoria.SelectedIndexChanged
        categoriarubro_obtener()
        rubrosubrubro_obtener()
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
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
                        Obtener_Productos_Combos()
                    End If
                End If
            End If
        End If
        If form_procedencia = "Pedido_Productos" Then
            If evento_load_completo = "si" Then
                If check_categoria.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_categoria_pedidos("")
                    Else
                        filtrar_por_categoria_pedidos("sin marca")
                    End If

                    If cb_rubro.Items.Count <> 0 Then
                        check_rubro.Enabled = True
                    Else
                        check_rubro.Enabled = False
                    End If
                Else
                    If check_marca.Checked = True Then
                        filtrar_solo_por_marca_pedidos()
                    Else
                        Obtener_Productos_Combos()
                    End If
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
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
        End If
    End Sub




    Private Sub cb_rubro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_rubro.SelectedIndexChanged

        If cb_rubro.Enabled = True Then
            rubrosubrubro_obtener()
            If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
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
                            Obtener_Productos_Combos()
                        End If
                    End If
                End If
            End If
            If form_procedencia = "Pedido_Productos" Then
                If evento_load_completo = "si" Then
                    If check_rubro.Checked = True Then

                        If check_marca.Checked = True Then
                            filtrar_por_rubro_pedidos("")
                        Else
                            filtrar_por_rubro_pedidos("sin marca")
                        End If

                        If cb_subrubro.Items.Count <> 0 Then
                            check_subrubro.Enabled = True
                        Else
                            check_subrubro.Enabled = False
                        End If
                    Else
                        If check_categoria.Checked = True Then
                            If check_marca.Checked = True Then
                                filtrar_por_categoria_pedidos("")
                            Else
                                filtrar_por_categoria_pedidos("sin marca")
                            End If
                        Else
                            Obtener_Productos_Combos()
                        End If
                    End If
                End If
            End If
            If form_procedencia = "Gestion_Mercaderia" Then
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
                            agregar_cant_vencida()
                        End If
                    End If
                End If
            End If
        End If

    End Sub



    Private Sub cb_subrubro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_subrubro.SelectedIndexChanged
        If cb_subrubro.Enabled = True Then
            If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
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
            End If
            If form_procedencia = "Pedido_Productos" Then
                If evento_load_completo = "si" Then
                    If check_subrubro.Checked = True Then
                        If check_marca.Checked = True Then
                            filtrar_por_subrubro_pedidos("")
                        Else
                            filtrar_por_subrubro_pedidos("sin marca")
                        End If
                    Else
                        If check_marca.Checked = True Then
                            filtrar_por_rubro_pedidos("")
                        Else
                            filtrar_por_rubro_pedidos("sin marca")
                        End If
                    End If
                End If
            End If
            If form_procedencia = "Gestion_Mercaderia" Then
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
        End If
    End Sub



    Private Sub cb_marca_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_marca.SelectedIndexChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
            If check_marca.Checked = True Then
                If check_categoria.Checked = True Then
                    'tengo q llamar a la rutina q filtre marcas y categorias
                Else
                    'aqui llamo a la rutina q trae filtrado por marca
                    filtrar_solo_por_marca()
                End If
            End If
            check_categoria.Checked = False
        End If
        If form_procedencia = "Pedido_Productos" Then
            If check_marca.Checked = True Then
                If check_categoria.Checked = True Then
                    'tengo q llamar a la rutina q filtre marcas y categorias
                Else
                    'aqui llamo a la rutina q trae filtrado por marca
                    filtrar_solo_por_marca_pedidos()
                End If
            End If
            check_categoria.Checked = False
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
            If check_marca.Checked = True Then
                If check_categoria.Checked = True Then
                    'tengo q llamar a la rutina q filtre marcas y categorias
                Else
                    'aqui llamo a la rutina q trae filtrado por marca
                    filtrar_solo_por_marca_GM()
                End If
            End If
            check_categoria.Checked = False
        End If
    End Sub


    Private Sub check_marca_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_marca.CheckedChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then '  "Pedido_Productos"
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
                Obtener_Productos_Combos()
            End If
        End If

        If form_procedencia = "Pedido_Productos" Then
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
                        filtrar_solo_por_marca_pedidos()
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
            End If
        End If

        If form_procedencia = "Gestion_Mercaderia" Then
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
        End If
    End Sub



    Private Sub check_categoria_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_categoria.CheckedChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
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
                    Obtener_Productos_Combos()
                End If
            End If
        End If
        If form_procedencia = "Pedido_Productos" Then
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
                        filtrar_por_categoria_pedidos("")
                    Else
                        filtrar_por_categoria_pedidos("sin marca")
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
                    filtrar_solo_por_marca_pedidos()
                Else
                    'voy a traer todos los productos
                    Obtener_Productos_Combos()
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then 'lo uso en si llamo al formulario desde gestion_mercaderia ya sea alta baja o movimiento,y tambien desde el modulo de consumo.
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
        End If
    End Sub



    Private Sub check_rubro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_rubro.CheckedChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
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
        End If
        If form_procedencia = "Pedido_Productos" Then
            If check_rubro.Checked = True Then
                If cb_rubro.Items.Count <> 0 Then
                    If cb_subrubro.Items.Count <> 0 Then
                        check_subrubro.Enabled = True
                    Else
                        check_subrubro.Enabled = False
                    End If


                    cb_rubro.Enabled = True

                    If check_marca.Checked = True Then
                        filtrar_por_rubro_pedidos("")
                    Else
                        filtrar_por_rubro_pedidos("sin marca")
                    End If
                End If
            Else
                check_subrubro.Checked = False
                check_subrubro.Enabled = False
                cb_rubro.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_por_categoria_pedidos("")
                Else
                    filtrar_por_categoria_pedidos("sin marca")
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
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
        End If
    End Sub

    Private Sub check_subrubro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_subrubro.CheckedChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
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
        End If
        If form_procedencia = "Pedido_Productos" Then
            If check_subrubro.Checked = True Then
                If cb_subrubro.Items.Count <> 0 Then
                    cb_subrubro.Enabled = True

                    If check_marca.Checked = True Then
                        filtrar_por_subrubro_pedidos("")
                    Else
                        filtrar_por_subrubro_pedidos("sin marca")
                    End If
                End If
            Else
                cb_subrubro.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_por_rubro_pedidos("")
                Else
                    filtrar_por_rubro_pedidos("sin marca")
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
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
        End If
    End Sub

#Region "filtros venta gestion"
    Private Sub filtrar_por_categoria(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria(Inicio.USU_id)
        Else
            ds_productos = ds_prod_marca
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)

            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'busco en categoria
                    If id_categorias = idcat Then
                        'lo agrego
                        Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                        row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                        row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                        row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                        row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                        row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                        row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                        row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                        row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                        row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                        Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                    End If
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_categorias = ds_productos.Tables(2).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
    End Sub
    Private Sub filtrar_por_rubro(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria(Inicio.USU_id)
        Else
            ds_productos = ds_prod_marca
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
    End Sub
    Private Sub filtrar_por_subrubro(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria(Inicio.USU_id)
        Else
            ds_productos = ds_prod_marca
        End If
        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
    End Sub
    Dim ds_prod_marca As DataSet
    Private Sub filtrar_solo_por_marca()
        ds_prod_marca = DAVentas.Venta_obtenerProducto_Combos_marca(Inicio.USU_id, cb_marca.SelectedValue)
        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
        If ds_prod_marca.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_prod_marca.Tables(0))
        End If
        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
    End Sub

#End Region

#Region "filtros pedido_productos"
    Dim ds_prod_marca_pedido
    Private Sub filtrar_solo_por_marca_pedidos()
        ds_prod_marca_pedido = DApedidos.Productos_x_Proveedor_Obtener_marca(Pedido_Productos.Prove_ID, cb_marca.SelectedValue)
        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
        If ds_prod_marca_pedido.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_prod_marca_pedido.Tables(0))
        End If
        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
    End Sub
    Private Sub filtrar_por_categoria_pedidos(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DApedidos.Productos_x_Proveedor_Obtener_categoria(Pedido_Productos.Prove_ID)
        Else
            ds_productos = ds_prod_marca_pedido
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)

            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'busco en categoria
                    If id_categorias = idcat Then
                        'lo agrego
                        Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                        row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                        row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                        row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                        row("prod_descrilarga") = ""
                        row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                        row("prod_stock") = 0
                        row("prod_ptorepo") = 0
                        row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                        row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                        Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                    End If
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_categorias = ds_productos.Tables(2).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
    End Sub
    Private Sub filtrar_por_rubro_pedidos(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DApedidos.Productos_x_Proveedor_Obtener_categoria(Pedido_Productos.Prove_ID)
        Else
            ds_productos = ds_prod_marca_pedido
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
    End Sub
    Private Sub filtrar_por_subrubro_pedidos(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DApedidos.Productos_x_Proveedor_Obtener_categoria(Pedido_Productos.Prove_ID)
        Else
            ds_productos = ds_prod_marca_pedido
        End If
        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
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
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
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
    End Sub
#End Region

#Region "filtrar Gestion Mercaderia" 'este tambien uso en dialisis para agregar insumos para consumir
    Dim ds_prod_gestmerc
    Private Sub filtrar_solo_por_marca_GM()
        ds_prod_gestmerc = DAVentas.Venta_obtenerProducto_Combos_marca_GM(sucursal_id, cb_marca.SelectedValue)
        Venta_Caja_ds.Tables("Prod_consulta").Rows.Clear()
        If ds_prod_gestmerc.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Prod_consulta").Merge(ds_prod_gestmerc.Tables(0))

        End If
        agregar_cant_vencida()
    End Sub
    Private Sub filtrar_por_categoria_GM(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria_GM(sucursal_id) 'aqui tengo q pasar la sucursal_id
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
                        row("Contenido") = ds_productos.Tables(0).Rows(i).Item("Contenido")
                        row("Contenido_total") = ds_productos.Tables(0).Rows(i).Item("Contenido_total")

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
                                row("Contenido") = ds_productos.Tables(0).Rows(i).Item("Contenido")
                                row("Contenido_total") = ds_productos.Tables(0).Rows(i).Item("Contenido_total")

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
                                row("Contenido") = ds_productos.Tables(0).Rows(i).Item("Contenido")
                                row("Contenido_total") = ds_productos.Tables(0).Rows(i).Item("Contenido_total")
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
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria_GM(sucursal_id)
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
                                row("Contenido") = ds_productos.Tables(0).Rows(i).Item("Contenido")
                                row("Contenido_total") = ds_productos.Tables(0).Rows(i).Item("Contenido_total")

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
                                row("Contenido") = ds_productos.Tables(0).Rows(i).Item("Contenido")
                                row("Contenido_total") = ds_productos.Tables(0).Rows(i).Item("Contenido_total")
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
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria_GM(sucursal_id)
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
                                row("Contenido") = ds_productos.Tables(0).Rows(i).Item("Contenido")
                                row("Contenido_total") = ds_productos.Tables(0).Rows(i).Item("Contenido_total")
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

    Dim dalote As New Datos.Lote
    Dim DAsucursal As New Datos.Sucursal

    Private Sub ir_movimiento()
        If DataGridView1.Rows.Count <> 0 Then
            If DataGridView1.CurrentRow.Selected = True Then

                TabPage1.Parent = Nothing 'oculto pestaña 1
                TabPage4.Parent = TabControl1 'pongo visible pestaña 2
                'pasamos a la otra pestaña
                TabControl1.SelectedTab = TabPage4



                'colocamos la info en los label del tabpage2
                '////////////////////////////////////////////////
                txt_codigo_mov.Text = DataGridView1.CurrentRow.Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
                txt_descripcion_mov.Text = DataGridView1.CurrentRow.Cells("ProddescripcionDataGridViewTextBoxColumn").Value
                txt_totalunidades_mov.Text = DataGridView1.CurrentRow.Cells("ProdstockDataGridViewTextBoxColumn").Value
                GroupBox3.Text = "Ingrese la cantidad a mover:"


                DataGridView3.DataSource = Nothing
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
                    DataGridView3.DataSource = Mov_DS.Tables("lote_baja")

                    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    'ahora ponemos con colores los productos en verde, amarillo y rojo.
                    Dim a As Integer = 0
                    While a < DataGridView3.Rows.Count
                        If DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn10").Value = "si" Then
                            Dim fecha_vencimiento As Date = CDate(DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn9").Value)
                            Dim fechadeldia As Date = Today


                            'If Format(fechadeldia, "yyyy/mm/dd") >= Format(fecha_vencimiento, "yyyy/mm/dd") Then
                            '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            'Else
                            '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            'End If


                            Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                            If cantdias <= 0 Then
                                DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            Else
                                If cantdias > 15 Then
                                    DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                                Else
                                    'menor o igual a 15 
                                    DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Orange
                                End If

                            End If


                            'If fechadeldia.Year >= fecha_vencimiento.Year Then
                            '    If fechadeldia.Year > fecha_vencimiento.Year Then
                            '        'vencido
                            '        DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            '    Else
                            '        'es el mismo año, vemos el mes
                            '        If fechadeldia.Month >= fecha_vencimiento.Month Then
                            '            If fechadeldia.Month > fecha_vencimiento.Month Then
                            '                'si se paso del mes esta vencida
                            '                DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            '            Else
                            '                'vemos si el mismo mes.
                            '                If fechadeldia.Month = fecha_vencimiento.Month Then
                            '                    'aqui pregunto x la fecha del dia
                            '                    If fechadeldia.Day >= fecha_vencimiento.Day Then
                            '                        'vence este mismo dia
                            '                        DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            '                    Else
                            '                        'supongamos que aun no se vence
                            '                        DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            '                    End If
                            '                Else
                            '                    'no esta vencido
                            '                    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            '                End If
                            '            End If
                            '        Else
                            '            'no es el mismo mes ni superior asi que no vence
                            '            DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            '        End If
                            '    End If
                            'Else
                            '    'no es el mismo año ni superior asi q no vence
                            '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            'End If
                        End If
                        a = a + 1
                    End While
                    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                End If
            Else
                MessageBox.Show("Error, seleccione un producto.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Error, Debe seleccionar un producto.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub ir_consumir()
        If DataGridView1.Rows.Count <> 0 Then
            If DataGridView1.CurrentRow.Selected = True Then

                TabPage1.Parent = Nothing 'oculto pestaña 1
                TabPage4.Parent = TabControl1 'pongo visible pestaña 2
                'pasamos a la otra pestaña
                TabControl1.SelectedTab = TabPage4



                'colocamos la info en los label del tabpage2
                '////////////////////////////////////////////////
                txt_codigo_mov.Text = DataGridView1.CurrentRow.Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
                txt_descripcion_mov.Text = DataGridView1.CurrentRow.Cells("ProddescripcionDataGridViewTextBoxColumn").Value
                txt_totalunidades_mov.Text = DataGridView1.CurrentRow.Cells("ProdstockDataGridViewTextBoxColumn").Value

                Dim Ds_Suc As DataSet = DAsucursal.Sucursal_obtener_producto(CInt(DataGridView1.CurrentRow.Cells("ProdidDataGridViewTextBoxColumn").Value), sucursal_id, sucursal_id)

                txt_totalreal.Text = CStr(Ds_Suc.Tables(0).Rows(0).Item("ProdxSuc_stock_real").ToString) + " " + CStr(Ds_Suc.Tables(0).Rows(0).Item("prod_unidadmedida"))
                txt_unidmedida.Text = CStr(Ds_Suc.Tables(0).Rows(0).Item("prod_unidadmedida"))
                GroupBox3.Text = "Ingrese la cantidad a consumir:"
                tipo_producto = Ds_Suc.Tables(1).Rows(0).Item("prod_tipo")


                DataGridView3.DataSource = Nothing
                Dim prodcodinterno As Integer = DataGridView1.CurrentRow.Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
                Dim ds_lotes As DataSet = dalote.Producto_x_sucursal_lote_recuperartodos(prodcodinterno, sucursal_id)

                If ds_lotes.Tables(0).Rows.Count <> 0 Then
                    Mov_DS.Tables("lote_baja").Rows.Clear()

                    Dim i As Integer = 0
                    While i < ds_lotes.Tables(0).Rows.Count

                        If ds_lotes.Tables(0).Rows(i).Item("lote_vence") = "no" Then
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
                            nuevoRow("lote_stock_real") = ds_lotes.Tables(0).Rows(i).Item("lote_stock_real")
                            nuevoRow("lote_aux") = ds_lotes.Tables(0).Rows(i).Item("lote_aux")


                            Mov_DS.Tables("lote_baja").Rows.Add(nuevoRow)
                        Else
                            Dim fecha_vencimiento As Date = CDate(ds_lotes.Tables(0).Rows(i).Item("lote_fechavto"))
                            Dim fechadeldia As Date = Today
                            Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                            If cantdias <= 0 Then
                                'no agrego el lote x que esta vencido
                            Else
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
                                nuevoRow("lote_stock_real") = ds_lotes.Tables(0).Rows(i).Item("lote_stock_real")
                                nuevoRow("lote_aux") = ds_lotes.Tables(0).Rows(i).Item("lote_aux")
                                Mov_DS.Tables("lote_baja").Rows.Add(nuevoRow)
                            End If
                        End If
                        i = i + 1
                    End While
                    'Mov_DS.Tables("lote_baja").Merge(ds_lotes.Tables(0))
                    DataGridView3.DataSource = Mov_DS.Tables("lote_baja")

                    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    'ahora ponemos con colores los productos en verde, amarillo y rojo.
                    Dim a As Integer = 0
                    While a < DataGridView3.Rows.Count
                        If DataGridView3.Rows(a).Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                            Dim fecha_vencimiento As Date = CDate(DataGridView3.Rows(a).Cells("LotefechavtoDataGridViewTextBoxColumn").Value)
                            Dim fechadeldia As Date = Today


                            'If Format(fechadeldia, "yyyy/mm/dd") >= Format(fecha_vencimiento, "yyyy/mm/dd") Then
                            '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            'Else
                            '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            'End If
                            Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                            If cantdias <= 0 Then
                                DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            Else
                                If cantdias > 15 Then
                                    DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                                Else
                                    'menor o igual a 15 
                                    DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Orange
                                End If

                            End If
                        End If
                        a = a + 1
                    End While
                    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                End If
                txt_cant_mov.Focus()
            Else
                MessageBox.Show("Error, seleccione un producto.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Error, Debe seleccionar un producto.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub ir_baja()

        If DataGridView1.Rows.Count <> 0 Then
            If DataGridView1.CurrentRow.Selected = True Then

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


                            'If fechadeldia.Year >= fecha_vencimiento.Year Then
                            '    If fechadeldia.Year > fecha_vencimiento.Year Then
                            '        'vencido
                            '        DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            '    Else
                            '        'es el mismo año, vemos el mes
                            '        If fechadeldia.Month >= fecha_vencimiento.Month Then
                            '            If fechadeldia.Month > fecha_vencimiento.Month Then
                            '                'si se paso del mes esta vencida
                            '                DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            '            Else
                            '                'vemos si el mismo mes.
                            '                If fechadeldia.Month = fecha_vencimiento.Month Then
                            '                    'aqui pregunto x la fecha del dia
                            '                    If fechadeldia.Day >= fecha_vencimiento.Day Then
                            '                        'vence este mismo dia
                            '                        DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                            '                    Else
                            '                        'supongamos que aun no se vence
                            '                        DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            '                    End If
                            '                Else
                            '                    'no esta vencido
                            '                    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            '                End If
                            '            End If
                            '        Else
                            '            'no es el mismo mes ni superior asi que no vence
                            '            DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            '        End If
                            '    End If
                            'Else
                            '    'no es el mismo año ni superior asi q no vence
                            '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                            'End If
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
            txt_lote.Text = DataGridView2.CurrentRow.Cells("LotenroDataGridViewTextBoxColumn").Value
            If DataGridView2.CurrentRow.Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                txt_fechafab.Text = DataGridView2.CurrentRow.Cells("LotefechafabDataGridViewTextBoxColumn").Value
                txt_fechvto.Text = DataGridView2.CurrentRow.Cells("LotefechavtoDataGridViewTextBoxColumn").Value
            Else
                txt_fechafab.Text = ""
                txt_fechvto.Text = ""
            End If
            txt_cantlote.Text = DataGridView2.CurrentRow.Cells("LotecantidadDataGridViewTextBoxColumn").Value


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

                'If fechadeldia.Year >= fecha_vencimiento.Year Then
                '    If fechadeldia.Year > fecha_vencimiento.Year Then
                '        'vencido
                '        DataGridView2.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
                '        DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Red
                '    Else
                '        'es el mismo año, vemos el mes
                '        If fechadeldia.Month >= fecha_vencimiento.Month Then
                '            If fechadeldia.Month > fecha_vencimiento.Month Then
                '                'si se paso del mes esta vencida
                '                DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Red
                '            Else
                '                'vemos si el mismo mes.
                '                If fechadeldia.Month = fecha_vencimiento.Month Then
                '                    'aqui pregunto x la fecha del dia
                '                    If fechadeldia.Day >= fecha_vencimiento.Day Then
                '                        'vence este mismo dia
                '                        DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Red
                '                    Else
                '                        'supongamos que aun no se vence
                '                        DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                '                    End If
                '                Else
                '                    'no esta vencido
                '                    DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                '                End If
                '            End If
                '        Else
                '            'no es el mismo mes ni superior asi que no vence
                '            DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                '        End If
                '    End If
                'Else
                '    'no es el mismo año ni superior asi q no vence
                '    DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                'End If
            Else
                DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
            End If
        End If
    End Sub

    Dim daValidaciones As New Validaciones


    Private Sub txt_cantlote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantlote.KeyPress




        daValidaciones.Restricciones_textbox(e, "Entero", txt_cantlote)
    End Sub


    Private Sub txt_cant_mov_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cant_mov.KeyPress

        If tipo_producto = "Fraccionable" Then
            daValidaciones.Restricciones_textbox(e, "Decimal", txt_cant_mov)
        Else
            If tipo_producto = "No Fraccionable" Then
                daValidaciones.Restricciones_textbox(e, "Entero", txt_cant_mov)
            End If
        End If



        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            'primero destildo todos los check de las filas
            Dim a As Integer = 0
            While a < DataGridView3.Rows.Count
                DataGridView3.Rows(a).Cells("DataGridViewCheckBoxColumn2").Value = False
                a = a + 1
            End While


            'primero hago el calculo adecuado para determinar cuantos lotes voy a transferir al gridview de consumos
            calculo_real_validacion()


            ''aqui seleccione en el grid todos aquellos lotes que completen la cantidad que deseo transferir
            'Dim valido As String = "no"
            'If txt_cant_mov.Text <> "" Then
            '    Dim cant As Decimal = CDec(txt_cant_mov.Text)
            '    Dim i As Integer = 0
            '    Dim suma As Integer = 0

            '    While i < DataGridView3.Rows.Count
            '        If cant > 0 Then
            '            If (CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value) <= cant) And (CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value) <> CDec(0)) Then
            '                'resto cantidad y tildo
            '                DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True
            '                cant = cant - CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value)
            '                If cant = 0 Then
            '                    valido = "si"
            '                    Exit While
            '                End If
            '            Else
            '                If (CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value) > 0) And (CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value) <> CDec(0)) Then
            '                    DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True
            '                    cant = 0
            '                    valido = "si"
            '                    Exit While 'si es mayor, lo tildo y corto
            '                End If
            '            End If
            '        Else
            '            If cant = 0 And CDec(txt_cant_mov.Text) <> CDec(0) Then
            '                valido = "si"
            '            End If
            '            Exit While
            '        End If
            '        i = i + 1
            '    End While
            'End If
            'If valido = "si" Then
            '    'txt_cant_mov.BackColor = Color.Green
            '    Panel_cant_mover.BackColor = Color.Green
            'Else
            '    'txt_cant_mov.BackColor = Color.Red
            '    Panel_cant_mover.BackColor = Color.Red
            'End If
        End If
    End Sub


    'calculo real de lo que voy a pasar, me fijo en la columan del grid que se llama "lote_stock_real"
    Private Sub calculo_real_validacion()
        'aqui seleccione en el grid todos aquellos lotes que completen la cantidad que deseo transferir
        Dim valido As String = "no"
        If txt_cant_mov.Text <> "" Then
            Dim cant As Decimal = CDec(txt_cant_mov.Text)
            Dim i As Integer = 0
            Dim suma As Decimal = CDec(0)

            While i < DataGridView3.Rows.Count
                If cant > 0 Then
                    If (CDec(DataGridView3.Rows(i).Cells("lote_stock_real").Value) <= cant) And (CDec(DataGridView3.Rows(i).Cells("lote_stock_real").Value) <> CDec(0)) Then
                        'resto cantidad y tildo
                        DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True
                        cant = cant - CDec(DataGridView3.Rows(i).Cells("lote_stock_real").Value)
                        If cant = 0 Then
                            valido = "si"
                            Exit While
                        End If
                    Else
                        If (CDec(DataGridView3.Rows(i).Cells("lote_stock_real").Value) > 0) And (CDec(DataGridView3.Rows(i).Cells("lote_stock_real").Value) <> CDec(0)) Then
                            DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True
                            cant = 0
                            valido = "si"
                            Exit While 'si es mayor, lo tildo y corto
                        End If
                    End If
                Else
                    If cant = 0 And CDec(txt_cant_mov.Text) <> CDec(0) Then
                        valido = "si"
                    End If
                    Exit While
                End If
                i = i + 1
            End While
        End If
        If valido = "si" Then
            'txt_cant_mov.BackColor = Color.Green
            Panel_cant_mover.BackColor = Color.Green
        Else
            'txt_cant_mov.BackColor = Color.Red
            Panel_cant_mover.BackColor = Color.Red
        End If
    End Sub

#Region "eventos para usar el chek en las grillas"

    Private Sub DataGridView3_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.ColumnHeaderMouseClick
        Dim a As Integer = 0
        While a < DataGridView3.Rows.Count
            If DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn10").Value = "si" Then
                Dim fecha_vencimiento As Date = CDate(DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn9").Value)
                Dim fechadeldia As Date = Today

                Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                If cantdias <= 0 Then
                    DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                Else
                    If cantdias > 15 Then
                        DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                    Else
                        'menor o igual a 15 
                        DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Orange
                    End If

                End If
            Else
                DataGridView3.Rows(a).DefaultCellStyle.ForeColor = Color.Green
            End If
            a = a + 1
        End While
    End Sub

    'Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
    '    'aqui seleccione en el grid todos aquellos lotes que completen la cantidad que deseo transferir
    '    Dim valido As String = "no"
    '    If txt_cant_mov.Text = "" Then
    '        txt_cant_mov.Text = CDec(0)
    '        txt_cant_mov.BackColor = Color.Red
    '    Else
    '        'si tiene un numero vamos a ver si con lo que tildo es suficiente.

    '        'creo una variable que sume la cant que voy tildando
    '        Dim suma As Decimal = 0
    '        Dim i As Integer = 0
    '        While i < DataGridView3.Rows.Count
    '            If DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True And DataGridView3.CurrentRow.Index <> i Then
    '                suma = suma + CDec(DataGridView3.Rows(i).Cells("DataGridViewTextBoxColumn7").Value)
    '            End If
    '            i = i + 1
    '        End While

    '        If suma = CDec(txt_cant_mov.Text) Then
    '            'valido

    '            If DataGridView3.CurrentRow.Cells("DataGridViewCheckBoxColumn2").Value = True Then
    '                'txt_cant_mov.BackColor = Color.Red
    '                Panel_cant_mover.BackColor = Color.Red
    '            Else
    '                'txt_cant_mov.BackColor = Color.Green
    '                Panel_cant_mover.BackColor = Color.Green
    '            End If
    '        Else
    '            'vemos si la celda actual esta chekeada sumamos y pones en verde o rojo
    '            'Dim row As DataGridViewRow = DataGridView3.Rows(e.RowIndex)
    '            'Dim seleccion As DataGridViewCheckBoxCell = TryCast(row.Cells("DataGridViewCheckBoxColumn2"), DataGridViewCheckBoxCell)
    '            'If seleccion.Value = True Then
    '            '    'holaaaaaaaaaaaaa
    '            '    MsgBox("tildado")
    '            'Else
    '            '    MsgBox("no tildado")
    '            'End If

    '            If DataGridView3.CurrentRow.Cells("DataGridViewCheckBoxColumn2").Value And CDec(DataGridView3.CurrentRow.Cells("DataGridViewTextBoxColumn7").Value) <> CDec(0) Then
    '                suma = suma + CDec(DataGridView3.CurrentRow.Cells("DataGridViewTextBoxColumn7").Value)
    '                'ahora que lo sume verifico nuevamente si me alcanza
    '                If suma >= CDec(txt_cant_mov.Text) Then
    '                    'txt_cant_mov.BackColor = Color.Green
    '                    Panel_cant_mover.BackColor = Color.Green
    '                Else
    '                    Panel_cant_mover.BackColor = Color.Red
    '                    'txt_cant_mov.BackColor = Color.Red
    '                End If
    '            Else
    '                'txt_cant_mov.BackColor = Color.Red
    '                Panel_cant_mover.BackColor = Color.Red
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub DataGridView3_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.CurrentCellDirtyStateChanged
        If DataGridView3.IsCurrentCellDirty Then
            DataGridView3.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub DataGridView3_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        'aqui seleccione en el grid todos aquellos lotes que completen la cantidad que deseo transferir
        Dim valido As String = "no"
        If txt_cant_mov.Text = "" Then
            txt_cant_mov.Text = CDec(0)
            Panel_cant_mover.BackColor = Color.Red
        Else
            'si tiene un numero vamos a ver si con lo que tildo es suficiente.

            'creo una variable que sume la cant que voy tildando
            Dim suma As Decimal = 0
            Dim i As Integer = 0
            While i < DataGridView3.Rows.Count
                If DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True And DataGridView3.CurrentRow.Index <> i Then
                    suma = suma + CDec(DataGridView3.Rows(i).Cells("DataGridViewTextBoxColumn7").Value)
                End If
                i = i + 1
            End While

            If suma >= CDec(txt_cant_mov.Text) Then
                'valido

                If DataGridView3.CurrentRow.Cells("DataGridViewCheckBoxColumn2").Value = True Then
                    'txt_cant_mov.BackColor = Color.Red
                    Panel_cant_mover.BackColor = Color.Red
                Else
                    'txt_cant_mov.BackColor = Color.Green
                    Panel_cant_mover.BackColor = Color.Green
                End If
            Else
                'vemos si la celda actual esta chekeada sumamos y pones en verde o rojo
                'Dim row As DataGridViewRow = DataGridView3.Rows(e.RowIndex)
                'Dim seleccion As DataGridViewCheckBoxCell = TryCast(row.Cells("DataGridViewCheckBoxColumn2"), DataGridViewCheckBoxCell)
                'If seleccion.Value = True Then
                '    'holaaaaaaaaaaaaa
                '    MsgBox("tildado")
                'Else
                '    MsgBox("no tildado")
                'End If

                If DataGridView3.CurrentRow.Cells("DataGridViewCheckBoxColumn2").Value And CDec(DataGridView3.CurrentRow.Cells("DataGridViewTextBoxColumn7").Value) <> CDec(0) Then
                    suma = suma + CDec(DataGridView3.CurrentRow.Cells("DataGridViewTextBoxColumn7").Value)
                    'ahora que lo sume verifico nuevamente si me alcanza
                    If suma >= CDec(txt_cant_mov.Text) Then
                        'txt_cant_mov.BackColor = Color.Green
                        Panel_cant_mover.BackColor = Color.Green
                    Else
                        Panel_cant_mover.BackColor = Color.Red
                        'txt_cant_mov.BackColor = Color.Red
                    End If
                Else
                    'txt_cant_mov.BackColor = Color.Red
                    Panel_cant_mover.BackColor = Color.Red
                End If
            End If
        End If

        'If txt_cant_mov.Text <> "" Then
        '    Dim cant As Decimal = CDec(txt_cant_mov.Text)
        '    Dim i As Integer = 0
        '    Dim suma As Integer = 0

        '    While i < DataGridView3.Rows.Count
        '        If cant > 0 Then
        '            If CDec(DataGridView3.Rows(i).Cells("DataGridViewTextBoxColumn7").Value) <= cant Then
        '                'resto cantidad y tildo
        '                DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True
        '                cant = cant - CDec(DataGridView3.Rows(i).Cells("DataGridViewTextBoxColumn7").Value)
        '            Else
        '                If CDec(DataGridView3.Rows(i).Cells("DataGridViewTextBoxColumn7").Value) > 0 Then
        '                    DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True
        '                    cant = 0
        '                    valido = "si"
        '                    Exit While 'si es mayor, lo tildo y corto
        '                End If
        '            End If
        '        Else
        '            If cant = 0 And CDec(txt_cant_mov.Text) <> CDec(0) Then
        '                valido = "si"
        '            End If
        '            Exit While
        '        End If
        '        i = i + 1
        '    End While
        'End If
        'If valido = "si" Then
        '    txt_cant_mov.BackColor = Color.Green
        'Else
        '    txt_cant_mov.BackColor = Color.Red
        'End If
    End Sub
    Private Sub DataGridView3_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.SelectionChanged
        If DataGridView3.Rows.Count <> 0 Then
            If DataGridView3.CurrentRow.Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then 'indica si el lote tiene vencimiento
                Dim fecha_vencimiento As Date = CDate(DataGridView3.CurrentRow.Cells("LotefechavtoDataGridViewTextBoxColumn").Value)
                Dim fechadeldia As Date = Today

                Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                If cantdias <= 0 Then
                    DataGridView3.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Red
                Else
                    If cantdias > 15 Then
                        DataGridView3.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                    Else
                        'menor o igual a 15 
                        DataGridView3.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Orange
                    End If

                End If

                'If fechadeldia.Year >= fecha_vencimiento.Year Then
                '    If fechadeldia.Year > fecha_vencimiento.Year Then
                '        'vencido
                '        DataGridView2.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
                '        DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Red
                '    Else
                '        'es el mismo año, vemos el mes
                '        If fechadeldia.Month >= fecha_vencimiento.Month Then
                '            If fechadeldia.Month > fecha_vencimiento.Month Then
                '                'si se paso del mes esta vencida
                '                DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Red
                '            Else
                '                'vemos si el mismo mes.
                '                If fechadeldia.Month = fecha_vencimiento.Month Then
                '                    'aqui pregunto x la fecha del dia
                '                    If fechadeldia.Day >= fecha_vencimiento.Day Then
                '                        'vence este mismo dia
                '                        DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Red
                '                    Else
                '                        'supongamos que aun no se vence
                '                        DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                '                    End If
                '                Else
                '                    'no esta vencido
                '                    DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                '                End If
                '            End If
                '        Else
                '            'no es el mismo mes ni superior asi que no vence
                '            DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                '        End If
                '    End If
                'Else
                '    'no es el mismo año ni superior asi q no vence
                '    DataGridView2.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green
                'End If
            Else
                DataGridView3.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Green

            End If
        End If
    End Sub

#End Region


    Private Function validar_carga(ByRef validacion As String) 'aqui estoy validando si esta todo correcto para agregar a la lista
        'creo una variable que sume la cant que voy tildando
        Dim sumas As Decimal = 0
        Dim ii As Integer = 0
        Dim bandera1 As String = "me falta"
        While ii < DataGridView3.Rows.Count
            If DataGridView3.Rows(ii).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                sumas = sumas + CDec(DataGridView3.Rows(ii).Cells("lote_stock_real").Value)
                If sumas >= CDec(txt_cant_mov.Text) Then
                    If bandera1 = "me falta" Then
                        bandera1 = "completo con este lote"
                    Else
                        bandera1 = "tengo lote de mas"
                        Exit While
                    End If
                End If
            End If
            ii = ii + 1
        End While

        If sumas = CDec(0) Then
            Panel_cant_mover.BackColor = Color.Red
            'MessageBox.Show("Debe seleccionar al menos un lote.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If txt_cant_mov.Text <> "" Then
            If bandera1 = "tengo lote de mas" Then
                Panel_cant_mover.BackColor = Color.Red
            Else
                If CDec(txt_cant_mov.Text) <= sumas And CDec(txt_cant_mov.Text) <> CDec(0) Then
                    Panel_cant_mover.BackColor = Color.Green
                    validacion = "si"
                Else
                    Panel_cant_mover.BackColor = Color.Red
                    'MessageBox.Show("Seleccione correctamente los lote a mover o modifique la cantidad.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Else
            Panel_cant_mover.BackColor = Color.Red
            'MessageBox.Show("Debe ingresar una cantidad válida.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return validacion
    End Function



    'boton de agregar baja
    Private Sub btn_agregar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar1.Click
        If txt_lote.Text <> "" And txt_cantlote.Text <> "" Then
            'valido que la cant q este en el textbox no supere a la cant max del lote (cuya info esta en al celda del gridview)
            If (CDec(txt_cantlote.Text) <= CDec(DataGridView2.CurrentRow.Cells("LotecantidadDataGridViewTextBoxColumn").Value)) And (CDec(txt_cantlote.Text) > 0) Then
                'por ultimo valido que el lote que quiero eliminar ya no se encuentre en la grilla de Gestion_Mercaderia.vb

                'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                Dim i As Integer = 0
                Dim cod_prod As String = txt_codigo.Text
                Dim encontrado As String = "no"
                While i < Gestion_Mercaderia.DataGridView1.Rows.Count

                    If Gestion_Mercaderia.DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod Then

                        If Gestion_Mercaderia.DataGridView1.Rows(i).Cells("Lote").Value = txt_lote.Text Then
                            encontrado = "si"
                            Exit While
                        End If
                    End If
                    i = i + 1
                End While

                If encontrado = "no" Then
                    Dim item As Integer
                    If Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Count = 0 Then
                        item = 1
                    Else
                        item = Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Count + 1
                    End If
                    Dim newCustomersRow As DataRow = Gestion_Mercaderia.Mov_DS.Tables("Mov").NewRow()
                    newCustomersRow("N°") = item
                    newCustomersRow("Cod_prod") = DataGridView2.CurrentRow.Cells("ProdcodinternoDataGridViewTextBoxColumn1").Value
                    newCustomersRow("Descripcion") = txt_descripcion.Text + " (Lote Nº: " + txt_lote.Text + ")"
                    newCustomersRow("Desde") = Gestion_Mercaderia.cb_origen.Text
                    newCustomersRow("Hacia") = Gestion_Mercaderia.cb_destino.Text
                    newCustomersRow("Cantidad") = (Math.Round(CDec(txt_cantlote.Text), 2).ToString("N2"))
                    newCustomersRow("Lote") = txt_lote.Text
                    If DataGridView2.CurrentRow.Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                        newCustomersRow("Vence") = "si"
                        newCustomersRow("FechaFabricacion") = DataGridView2.CurrentRow.Cells("LotefechafabDataGridViewTextBoxColumn").Value
                        newCustomersRow("FechaVencimiento") = DataGridView2.CurrentRow.Cells("LotefechavtoDataGridViewTextBoxColumn").Value
                    Else
                        newCustomersRow("Vence") = "no"
                    End If
                    Dim prov_id As Integer = DataGridView2.CurrentRow.Cells("DataGridViewTextBoxColumn13").Value
                    newCustomersRow("Prov_id") = DataGridView2.CurrentRow.Cells("DataGridViewTextBoxColumn13").Value 'mando el id del proveedor q voy a necesitar cuando reste el stock consumido

                    Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Add(newCustomersRow)
                    Gestion_Mercaderia.DataGridView1.DataSource = Gestion_Mercaderia.Mov_DS.Tables("Mov")

                    'bloque origen y destino combos en form gestion_mercaderia
                    Gestion_Mercaderia.cb_origen.Enabled = False
                    Gestion_Mercaderia.cb_destino.Enabled = False


                    Dim result As Integer = MessageBox.Show("¿Desea agregar más lotes a el listado?.", "Sistema de Gestión.", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then

                    ElseIf result = DialogResult.No Then
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("El lote ya se encuentra agregado a la lista.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Modifique la cantidad, no debe superar el máximo del lote.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Debe seleccionar un lote.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    'boton de agregar movimiento


    Private Sub movimiento_agregar()
        Dim validacion As String = "no"
        If Panel_cant_mover.BackColor = Color.Green Then
            validar_carga(validacion)
        End If
        If validacion = "si" Then
            If Panel_cant_mover.BackColor = Color.Green And CDec(txt_cant_mov.Text) <> CDec(0) Then
                'valido que la cant q este en el textbox no supere a la cant max de productos en sucursal
                If CDec(txt_cant_mov.Text) <= CDec(txt_totalunidades_mov.Text) Then
                    'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                    Dim cod_prod As String = txt_codigo_mov.Text
                    Dim nombre_lote As String = ""
                    Dim encontrado As String = "no" 'se pone en "si" cuando encuentra un lote ya en la lista de productos agregados
                    Dim aa As Integer = 0
                    While aa < DataGridView3.Rows.Count
                        If DataGridView3.Rows(aa).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                            Dim lote_nro As String = DataGridView3.Rows(aa).Cells("DataGridViewTextBoxColumn6").Value
                            Dim i As Integer = 0
                            While i < Gestion_Mercaderia.DataGridView1.Rows.Count
                                'quiero que me agregue siempre lotes distintos.
                                If (Gestion_Mercaderia.DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod) And (Gestion_Mercaderia.DataGridView1.Rows(i).Cells("Lote").Value = lote_nro) Then
                                    encontrado = "si"
                                    nombre_lote = lote_nro
                                    Exit While
                                End If
                                i = i + 1
                            End While
                        End If
                        If encontrado = "si" Then
                            Exit While
                        End If
                        aa = aa + 1
                    End While
                    Dim agregar_valido As String = "no"
                    If encontrado = "no" Then
                        'como ningun lote esta agregado, ahora sumo con los que existen en la grilla de gestion_mercaderia
                        Dim suma_lote As Decimal = 0 'esto suma los lotes que quiero agregar mas los existentes en la lista del modulo Gestion_Mercaderia
                        Dim j As Integer = 0
                        While j < Gestion_Mercaderia.DataGridView1.Rows.Count
                            If (Gestion_Mercaderia.DataGridView1.Rows(j).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod) Then
                                suma_lote = suma_lote + CDec(Gestion_Mercaderia.DataGridView1.Rows(j).Cells("CantidadDataGridViewTextBoxColumn").Value)
                            End If
                            j = j + 1
                        End While
                        suma_lote = suma_lote + CDec(txt_cant_mov.Text) 'este total no debe ser mayor a la cantidad en stock de la sucursal.
                        If suma_lote <= CDec(txt_totalunidades_mov.Text) Then
                            agregar_valido = "si"
                        End If
                    End If
                    If encontrado = "no" And agregar_valido = "si" Then 'quiere decir que ningun lote se encuentra en la lista de gestin_mercaderia y que ademas sumados no superan el stock total de la sucursal.
                        'agrego todos los lotes tildados, con excepcion de los que tienen cantidad en 0
                        Dim a As Integer = 0
                        Dim cantidad_a_mover As Decimal = CDec(txt_cant_mov.Text)
                        While a < DataGridView3.Rows.Count
                            If DataGridView3.Rows(a).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                                Dim item As Integer
                                If Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Count = 0 Then
                                    item = 1
                                Else
                                    item = Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Count + 1
                                End If
                                Dim newCustomersRow As DataRow = Gestion_Mercaderia.Mov_DS.Tables("Mov").NewRow()
                                newCustomersRow("N°") = item
                                newCustomersRow("Cod_prod") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn2").Value
                                newCustomersRow("Descripcion") = txt_descripcion_mov.Text + " (Lote Nº: " + DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn6").Value + ")"
                                newCustomersRow("Desde") = Gestion_Mercaderia.cb_origen.Text
                                newCustomersRow("Hacia") = Gestion_Mercaderia.cb_destino.Text
                                newCustomersRow("Prov_id") = DataGridView3.Rows(a).Cells("Prov_id").Value
                                'aqui veo cuanto voy a mover. si todo, o menos.
                                Dim cant_del_lote As Decimal = CDec(DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn7").Value)
                                If cant_del_lote <= cantidad_a_mover Then
                                    'paso todo
                                    newCustomersRow("Cantidad") = (Math.Round(CDec(cant_del_lote), 2).ToString("N2"))
                                    cantidad_a_mover = cantidad_a_mover - cant_del_lote
                                Else
                                    If cant_del_lote > cantidad_a_mover Then
                                        'pongo en el dataset lo que queda en la variable cantida_a_mover
                                        newCustomersRow("Cantidad") = (Math.Round(CDec(cantidad_a_mover), 2).ToString("N2"))
                                        'cantidad_a_mover = cantidad_a_mover - cant_del_lote
                                    End If
                                End If
                                'newCustomersRow("Cantidad") = CDec(txt_cantlote.Text)
                                newCustomersRow("Lote") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn6").Value
                                If DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn10").Value = "si" Then
                                    newCustomersRow("Vence") = "si"
                                    newCustomersRow("FechaFabricacion") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn8").Value
                                    newCustomersRow("FechaVencimiento") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn9").Value
                                Else
                                    newCustomersRow("Vence") = "no"
                                End If
                                Gestion_Mercaderia.Mov_DS.Tables("Mov").Rows.Add(newCustomersRow)

                            End If
                            a = a + 1
                        End While
                        Gestion_Mercaderia.DataGridView1.DataSource = Gestion_Mercaderia.Mov_DS.Tables("Mov")
                        'bloque origen y destino combos en form gestion_mercaderia
                        Gestion_Mercaderia.cb_origen.Enabled = False
                        Gestion_Mercaderia.cb_destino.Enabled = False

                        Dim result As Integer = MessageBox.Show("¿Desea agregar más lotes a el listado?.", "Sistema de Gestión.", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then
                        ElseIf result = DialogResult.No Then
                            Me.Close()
                        End If
                    Else
                        If encontrado = "si" Then
                            MessageBox.Show("El lote: " + nombre_lote + " ya se encuentra agregado a la lista.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            If agregar_valido = "no" Then
                                MessageBox.Show("Modifique cantidad, ésta superó el stock existente en la sucursal. ", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    End If
                Else
                    MessageBox.Show("Modifique la cantidad, no debe superar el máximo de unidades en stock.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                'MessageBox.Show("Debe ingresar una cantidad válida.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Seleccione correctamente los lote a mover o modifique la cantidad.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub consumir_agregar()
        Dim validacion As String = "no"
        If Panel_cant_mover.BackColor = Color.Green Then
            validar_carga(validacion)
        End If
        If validacion = "si" Then
            If Panel_cant_mover.BackColor = Color.Green And CDec(txt_cant_mov.Text) <> CDec(0) Then
                'valido que la cant q este en el textbox no supere a la cant max de productos en sucursal
                If CDec(txt_cant_mov.Text) <= CDec(txt_totalunidades_mov.Text) Then
                    'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                    Dim cod_prod As String = txt_codigo_mov.Text
                    Dim nombre_lote As String = ""
                    Dim encontrado As String = "no" 'se pone en "si" cuando encuentra un lote ya en la lista de productos agregados
                    Dim aa As Integer = 0
                    While aa < DataGridView3.Rows.Count
                        If DataGridView3.Rows(aa).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                            Dim lote_nro As String = DataGridView3.Rows(aa).Cells("DataGridViewTextBoxColumn6").Value
                            Dim i As Integer = 0
                            While i < Insumos_gestion.DataGridView1.Rows.Count
                                'quiero que me agregue siempre lotes distintos.
                                If (Insumos_gestion.DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod) And (Insumos_gestion.DataGridView1.Rows(i).Cells("Lote").Value = lote_nro) Then
                                    encontrado = "si"
                                    nombre_lote = lote_nro
                                    Exit While
                                End If
                                i = i + 1
                            End While
                        End If
                        If encontrado = "si" Then
                            Exit While
                        End If
                        aa = aa + 1
                    End While
                    Dim agregar_valido As String = "no"
                    If encontrado = "no" Then
                        'como ningun lote esta agregado, ahora sumo con los que existen en la grilla de gestion_mercaderia
                        Dim suma_lote As Decimal = 0 'esto suma los lotes que quiero agregar mas los existentes en la lista del modulo Gestion_Mercaderia
                        Dim j As Integer = 0
                        While j < Insumos_gestion.DataGridView1.Rows.Count
                            If (Insumos_gestion.DataGridView1.Rows(j).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod) Then
                                suma_lote = suma_lote + CDec(Insumos_gestion.DataGridView1.Rows(j).Cells("CantidadDataGridViewTextBoxColumn").Value)
                            End If
                            j = j + 1
                        End While
                        suma_lote = suma_lote + CDec(txt_cant_mov.Text) 'este total no debe ser mayor a la cantidad en stock de la sucursal.
                        If suma_lote <= CDec(txt_totalunidades_mov.Text) Then
                            agregar_valido = "si"
                        End If
                    End If
                    If encontrado = "no" And agregar_valido = "si" Then 'quiere decir que ningun lote se encuentra en la lista de gestin_mercaderia y que ademas sumados no superan el stock total de la sucursal.
                        'agrego todos los lotes tildados, con excepcion de los que tienen cantidad en 0
                        Dim a As Integer = 0
                        Dim cantidad_a_mover As Decimal = CDec(txt_cant_mov.Text)
                        While a < DataGridView3.Rows.Count
                            If DataGridView3.Rows(a).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                                Dim item As Integer
                                If Insumos_gestion.Mov_DS.Tables("Mov").Rows.Count = 0 Then
                                    item = 1
                                Else
                                    item = Insumos_gestion.Mov_DS.Tables("Mov").Rows.Count + 1
                                End If
                                Dim newCustomersRow As DataRow = Insumos_gestion.Mov_DS.Tables("Mov").NewRow()
                                newCustomersRow("N°") = item
                                newCustomersRow("Cod_prod") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn2").Value
                                newCustomersRow("Descripcion") = txt_descripcion_mov.Text + " (Lote Nº: " + DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn6").Value + ")"
                                newCustomersRow("Desde") = Insumos_gestion.cb_origen.Text
                                newCustomersRow("Hacia") = Insumos_gestion.cb_origen.Text

                                newCustomersRow("Prov_id") = DataGridView3.Rows(a).Cells("Prov_id").Value

                                'aqui veo cuanto voy a mover. si todo, o menos.
                                Dim cant_del_lote As Decimal = CDec(DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn7").Value)
                                If cant_del_lote <= cantidad_a_mover Then
                                    'paso todo
                                    newCustomersRow("Cantidad") = (Math.Round(CDec(cant_del_lote), 2).ToString("N2"))
                                    cantidad_a_mover = cantidad_a_mover - cant_del_lote
                                Else
                                    If cant_del_lote > cantidad_a_mover Then
                                        'pongo en el dataset lo que queda en la variable cantida_a_mover
                                        newCustomersRow("Cantidad") = (Math.Round(CDec(cantidad_a_mover), 2).ToString("N2"))
                                        'cantidad_a_mover = cantidad_a_mover - cant_del_lote
                                    End If
                                End If
                                'newCustomersRow("Cantidad") = CDec(txt_cantlote.Text)
                                newCustomersRow("Lote") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn6").Value
                                If DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn10").Value = "si" Then
                                    newCustomersRow("Vence") = "si"
                                    newCustomersRow("FechaFabricacion") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn8").Value
                                    newCustomersRow("FechaVencimiento") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn9").Value
                                Else
                                    newCustomersRow("Vence") = "no"
                                End If
                                Insumos_gestion.Mov_DS.Tables("Mov").Rows.Add(newCustomersRow)

                            End If
                            a = a + 1
                        End While
                        Insumos_gestion.DataGridView1.DataSource = Insumos_gestion.Mov_DS.Tables("Mov")
                        'bloque origen y destino combos en form gestion_mercaderia
                        Insumos_gestion.cb_origen.Enabled = False
                        'Insumos_gestion.cb_destino.Enabled = False

                        Dim result As Integer = MessageBox.Show("¿Desea agregar más lotes a el listado?.", "Sistema de Gestión.", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then
                        ElseIf result = DialogResult.No Then
                            Me.Close()
                        End If
                    Else
                        If encontrado = "si" Then
                            MessageBox.Show("El lote: " + nombre_lote + " ya se encuentra agregado a la lista.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            If agregar_valido = "no" Then
                                MessageBox.Show("Modifique cantidad, ésta superó el stock existente en la sucursal. ", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    End If
                Else
                    MessageBox.Show("Modifique la cantidad, no debe superar el máximo de unidades en stock.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                'MessageBox.Show("Debe ingresar una cantidad válida.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Seleccione correctamente los lote a consumir o modifique la cantidad.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If tipo_movimiento = "movimiento producto" Then
            movimiento_agregar()
        Else
            If tipo_movimiento = "consumir producto" Then 'este lo uso en el modulo de insumos gestion

                consumir_agregar()
            End If
        End If

        If tipo_movimiento = "consumir producto en enfermeria" Then
            consumir_agregar_Enfermeria()
        End If

        If tipo_movimiento = "consumir Ausente" Then
            consumir_Ausente()
        End If


    End Sub

    Private Sub consumir_Ausente()
        Dim validacion As String = "no"
        If Panel_cant_mover.BackColor = Color.Green Then
            validar_carga(validacion)
        End If
        If validacion = "si" Then
            If Panel_cant_mover.BackColor = Color.Green And CDec(txt_cant_mov.Text) <> CDec(0) Then
                'valido que la cant q este en el textbox no supere a la cant max de productos en sucursal
                'If CDec(txt_cant_mov.Text) <= CDec(txt_totalunidades_mov.Text) Then
                'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                Dim cod_prod As String = txt_codigo_mov.Text
                Dim nombre_lote As String = ""
                Dim encontrado As String = "no" 'se pone en "si" cuando encuentra un lote ya en la lista de productos agregados
                Dim aa As Integer = 0
                While aa < DataGridView3.Rows.Count
                    If DataGridView3.Rows(aa).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                        'Dim lote_nro As String = DataGridView3.Rows(aa).Cells("LotenroDataGridViewTextBoxColumn").Value
                        Dim i As Integer = 0
                        While i < Enfermeria_insumos_Ausente.DataGridView1.Rows.Count
                            'NO QUIERO AGREGAR EL MISMO PRODUCTO
                            If (Enfermeria_insumos_Ausente.DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod) Then
                                encontrado = "si"
                                'nombre_lote = lote_nro
                                Exit While
                            End If
                            i = i + 1
                        End While
                    End If
                    If encontrado = "si" Then
                        Exit While
                    End If
                    aa = aa + 1
                End While
                Dim agregar_valido As String = "no"
                If encontrado = "no" Then
                    Dim item As Integer
                    If Enfermeria_insumos_Ausente.Mov_DS.Tables("Mov_Enf").Rows.Count = 0 Then
                        item = 1
                    Else
                        item = Enfermeria_insumos_Ausente.Mov_DS.Tables("Mov_Enf").Rows.Count + 1
                    End If
                    Dim newCustomersRow1 As DataRow = Enfermeria_insumos_Ausente.Mov_DS.Tables("Mov_Enf").NewRow()
                    newCustomersRow1("N°") = item
                    newCustomersRow1("Cod_prod") = DataGridView3.Rows(0).Cells("ProdcodinternoDataGridViewTextBoxColumn1").Value
                    newCustomersRow1("Descripcion") = txt_descripcion_mov.Text
                    newCustomersRow1("Cantidad") = (Math.Round(CDec(txt_cant_mov.Text), 2).ToString("N2"))
                    newCustomersRow1("Prov_id") = DataGridView3.Rows(0).Cells("Prov_id").Value
                    newCustomersRow1("Cantidad_a_consumir") = CStr((Math.Round(CDec(txt_cant_mov.Text), 2).ToString("N2"))) + " " + txt_unidmedida.Text
                    newCustomersRow1("EnBD") = "no"

                    Enfermeria_insumos_Ausente.Mov_DS.Tables("Mov_Enf").Rows.Add(newCustomersRow1)

                    'agrego todos los lotes tildados, con excepcion de los que tienen cantidad en 0
                    Dim a As Integer = 0
                    Dim cantidad_a_mover As Decimal = CDec(txt_cant_mov.Text)
                    While a < DataGridView3.Rows.Count
                        If DataGridView3.Rows(a).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                            'Dim item As Integer
                            'If Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count = 0 Then
                            '    item = 1
                            'Else
                            '    item = Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count + 1
                            'End If
                            Dim newCustomersRow As DataRow = Enfermeria_insumos_Ausente.Ds_enfermeria.Tables("Consumo_real").NewRow()
                            'newCustomersRow("N°") = item
                            newCustomersRow("Cod_prod") = DataGridView3.Rows(a).Cells("ProdcodinternoDataGridViewTextBoxColumn1").Value
                            newCustomersRow("Descripcion") = txt_descripcion_mov.Text + " (Lote Nº: " + DataGridView3.Rows(a).Cells("LotenroDataGridViewTextBoxColumn").Value + ")"
                            'newCustomersRow("Desde") = Nueva_Dialisis.cb_origen.Text
                            'newCustomersRow("Hacia") = Insumos_gestion.cb_origen.Text
                            'aqui veo cuanto voy a mover. si todo, o menos.
                            Dim cant_del_lote As Decimal = CDec(DataGridView3.Rows(a).Cells("lote_stock_real").Value)
                            If cant_del_lote <= cantidad_a_mover Then
                                'paso todo
                                newCustomersRow("Cantidad_real") = (Math.Round(CDec(cant_del_lote), 2).ToString("N2"))
                                cantidad_a_mover = cantidad_a_mover - cant_del_lote
                            Else
                                If cant_del_lote > cantidad_a_mover Then
                                    'pongo en el dataset lo que queda en la variable cantida_a_mover
                                    newCustomersRow("Cantidad_real") = (Math.Round(CDec(cantidad_a_mover), 2).ToString("N2"))
                                    'cantidad_a_mover = cantidad_a_mover - cant_del_lote
                                End If
                            End If

                            newCustomersRow("lote_id") = DataGridView3.Rows(a).Cells("LoteidDataGridViewTextBoxColumn").Value

                            newCustomersRow("Prov_id") = DataGridView3.Rows(a).Cells("Prov_id").Value

                            Enfermeria_insumos_Ausente.Ds_enfermeria.Tables("Consumo_real").Rows.Add(newCustomersRow)
                        End If
                        a = a + 1
                    End While


                    Dim result As Integer = MessageBox.Show("¿Desea agregar más insumos?.", "Sistema de Gestión.", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                    ElseIf result = DialogResult.No Then
                        Me.Close()
                    End If

                Else
                    'AQUI VIENE EL CARTEL QUE DIGA, EL PRODUCTO YA SE ENCUENTRA AGREGADO, ELIJA OTRO PRODUCTO.
                    MessageBox.Show("El insumo ya se encuentra agregado a la lista.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                'MessageBox.Show("Debe ingresar una cantidad válida.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Error, modifique la cantidad.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        'Dim validacion As String = "no"
        'If Panel_cant_mover.BackColor = Color.Green Then
        '    validar_carga(validacion)
        'End If
        'If validacion = "si" Then
        '    If Panel_cant_mover.BackColor = Color.Green And CDec(txt_cant_mov.Text) <> CDec(0) Then
        '        'valido que la cant q este en el textbox no supere a la cant max de productos en sucursal
        '        If CDec(txt_cant_mov.Text) <= CDec(txt_totalunidades_mov.Text) Then
        '            'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
        '            Dim cod_prod As String = txt_codigo_mov.Text
        '            Dim nombre_lote As String = ""
        '            Dim encontrado As String = "no" 'se pone en "si" cuando encuentra un lote ya en la lista de productos agregados
        '            Dim aa As Integer = 0
        '            While aa < DataGridView3.Rows.Count
        '                If DataGridView3.Rows(aa).Cells("DataGridViewCheckBoxColumn2").Value = True Then
        '                    Dim lote_nro As String = DataGridView3.Rows(aa).Cells("DataGridViewTextBoxColumn6").Value
        '                    Dim i As Integer = 0
        '                    While i < Enfermeria_insumos_Ausente.DataGridView1.Rows.Count
        '                        'quiero que me agregue siempre lotes distintos.
        '                        If (Enfermeria_insumos_Ausente.DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod) And (Enfermeria_insumos_Ausente.DataGridView1.Rows(i).Cells("LoteDataGridViewTextBoxColumn").Value = lote_nro) Then
        '                            encontrado = "si"
        '                            nombre_lote = lote_nro
        '                            Exit While
        '                        End If
        '                        i = i + 1
        '                    End While
        '                End If
        '                If encontrado = "si" Then
        '                    Exit While
        '                End If
        '                aa = aa + 1
        '            End While
        '            Dim agregar_valido As String = "no"
        '            If encontrado = "no" Then
        '                'como ningun lote esta agregado, ahora sumo con los que existen en la grilla de gestion_mercaderia
        '                Dim suma_lote As Decimal = 0 'esto suma los lotes que quiero agregar mas los existentes en la lista del modulo Gestion_Mercaderia
        '                Dim j As Integer = 0
        '                While j < Enfermeria_insumos_Ausente.DataGridView1.Rows.Count
        '                    If (Enfermeria_insumos_Ausente.DataGridView1.Rows(j).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod) Then
        '                        suma_lote = suma_lote + CDec(Enfermeria_insumos_Ausente.DataGridView1.Rows(j).Cells("CantidadDataGridViewTextBoxColumn").Value)
        '                    End If
        '                    j = j + 1
        '                End While
        '                suma_lote = suma_lote + CDec(txt_cant_mov.Text) 'este total no debe ser mayor a la cantidad en stock de la sucursal.
        '                If suma_lote <= CDec(txt_totalunidades_mov.Text) Then
        '                    agregar_valido = "si"
        '                End If
        '            End If
        '            If encontrado = "no" And agregar_valido = "si" Then 'quiere decir que ningun lote se encuentra en la lista de gestin_mercaderia y que ademas sumados no superan el stock total de la sucursal.
        '                'agrego todos los lotes tildados, con excepcion de los que tienen cantidad en 0
        '                Dim a As Integer = 0
        '                Dim cantidad_a_mover As Decimal = CDec(txt_cant_mov.Text)
        '                While a < DataGridView3.Rows.Count
        '                    If DataGridView3.Rows(a).Cells("DataGridViewCheckBoxColumn2").Value = True Then
        '                        Dim item As Integer
        '                        If Enfermeria_insumos_Ausente.Mov_DS.Tables("Mov_Enf").Rows.Count = 0 Then
        '                            item = 1
        '                        Else
        '                            item = Enfermeria_insumos_Ausente.Mov_DS.Tables("Mov_Enf").Rows.Count + 1
        '                        End If
        '                        Dim newCustomersRow As DataRow = Enfermeria_insumos_Ausente.Mov_DS.Tables("Mov_Enf").NewRow()
        '                        newCustomersRow("N°") = item
        '                        newCustomersRow("Cod_prod") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn2").Value
        '                        newCustomersRow("Descripcion") = txt_descripcion_mov.Text + " (Lote Nº: " + DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn6").Value + ")"
        '                        'newCustomersRow("Desde") = Nueva_Dialisis.cb_origen.Text
        '                        'newCustomersRow("Hacia") = Insumos_gestion.cb_origen.Text
        '                        'aqui veo cuanto voy a mover. si todo, o menos.
        '                        Dim cant_del_lote As Decimal = CDec(DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn7").Value)
        '                        If cant_del_lote <= cantidad_a_mover Then
        '                            'paso todo
        '                            newCustomersRow("Cantidad") = (Math.Round(CDec(cant_del_lote), 2).ToString("N2"))
        '                            cantidad_a_mover = cantidad_a_mover - cant_del_lote
        '                        Else
        '                            If cant_del_lote > cantidad_a_mover Then
        '                                'pongo en el dataset lo que queda en la variable cantida_a_mover
        '                                newCustomersRow("Cantidad") = (Math.Round(CDec(cantidad_a_mover), 2).ToString("N2"))
        '                                'cantidad_a_mover = cantidad_a_mover - cant_del_lote
        '                            End If
        '                        End If
        '                        'newCustomersRow("Cantidad") = CDec(txt_cantlote.Text)
        '                        newCustomersRow("Lote") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn6").Value
        '                        If DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn10").Value = "si" Then
        '                            newCustomersRow("Vence") = "si"
        '                            newCustomersRow("FechaFabricacion") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn8").Value
        '                            newCustomersRow("FechaVencimiento") = DataGridView3.Rows(a).Cells("DataGridViewTextBoxColumn9").Value
        '                        Else
        '                            newCustomersRow("Vence") = "no"
        '                        End If

        '                        newCustomersRow("Prov_id") = DataGridView3.Rows(a).Cells("Prov_id").Value

        '                        Enfermeria_insumos_Ausente.Mov_DS.Tables("Mov_Enf").Rows.Add(newCustomersRow)

        '                    End If
        '                    a = a + 1
        '                End While
        '                Enfermeria_insumos_Ausente.DataGridView1.DataSource = Enfermeria_insumos_Ausente.Mov_DS.Tables("Mov_Enf")
        '                'bloque origen y destino combos en form gestion_mercaderia
        '                'Nueva_Dialisis.cb_origen.Enabled = False
        '                'Insumos_gestion.cb_destino.Enabled = False

        '                Dim result As Integer = MessageBox.Show("¿Desea agregar más lotes a el listado?.", "Sistema de Gestión.", MessageBoxButtons.YesNo)
        '                If result = DialogResult.Yes Then
        '                ElseIf result = DialogResult.No Then
        '                    Me.Close()
        '                End If
        '            Else
        '                If encontrado = "si" Then
        '                    MessageBox.Show("El lote: " + nombre_lote + " ya se encuentra agregado a la lista.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '                Else
        '                    If agregar_valido = "no" Then
        '                        MessageBox.Show("Modifique cantidad, ésta superó el stock existente en la sucursal. ", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '                    End If
        '                End If
        '            End If
        '        Else
        '            MessageBox.Show("Modifique la cantidad, no debe superar el máximo de unidades en stock.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End If
        '    Else
        '        'MessageBox.Show("Debe ingresar una cantidad válida.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    End If
        'Else
        '    MessageBox.Show("Seleccione correctamente los lote a consumir o modifique la cantidad.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
    End Sub


    Private Sub consumir_agregar_Enfermeria()
        Dim validacion As String = "no"
        If Panel_cant_mover.BackColor = Color.Green Then
            validar_carga(validacion)
        End If
        If validacion = "si" Then
            If Panel_cant_mover.BackColor = Color.Green And CDec(txt_cant_mov.Text) <> CDec(0) Then
                'valido que la cant q este en el textbox no supere a la cant max de productos en sucursal
                'If CDec(txt_cant_mov.Text) <= CDec(txt_totalunidades_mov.Text) Then
                'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                Dim cod_prod As String = txt_codigo_mov.Text
                Dim nombre_lote As String = ""
                Dim encontrado As String = "no" 'se pone en "si" cuando encuentra un lote ya en la lista de productos agregados
                Dim aa As Integer = 0
                While aa < DataGridView3.Rows.Count
                    If DataGridView3.Rows(aa).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                        'Dim lote_nro As String = DataGridView3.Rows(aa).Cells("LotenroDataGridViewTextBoxColumn").Value
                        Dim i As Integer = 0
                        While i < Nueva_Dialisis.DataGridView1.Rows.Count
                            'NO QUIERO AGREGAR EL MISMO PRODUCTO
                            If (Nueva_Dialisis.DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod) Then
                                encontrado = "si"
                                'nombre_lote = lote_nro
                                Exit While
                            End If
                            i = i + 1
                        End While
                    End If
                    If encontrado = "si" Then
                        Exit While
                    End If
                    aa = aa + 1
                End While
                Dim agregar_valido As String = "no"
                If encontrado = "no" Then
                    Dim item As Integer
                    If Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count = 0 Then
                        item = 1
                    Else
                        item = Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count + 1
                    End If
                    Dim newCustomersRow1 As DataRow = Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").NewRow()
                    newCustomersRow1("N°") = item
                    newCustomersRow1("Cod_prod") = DataGridView3.Rows(0).Cells("ProdcodinternoDataGridViewTextBoxColumn1").Value
                    newCustomersRow1("Descripcion") = txt_descripcion_mov.Text
                    newCustomersRow1("Cantidad") = (Math.Round(CDec(txt_cant_mov.Text), 2).ToString("N2"))
                    newCustomersRow1("Prov_id") = DataGridView3.Rows(0).Cells("Prov_id").Value
                    newCustomersRow1("Cantidad_a_consumir") = CStr((Math.Round(CDec(txt_cant_mov.Text), 2).ToString("N2"))) + " " + txt_unidmedida.Text
                    newCustomersRow1("EnBD") = "no"

                    Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Add(newCustomersRow1)

                    'agrego todos los lotes tildados, con excepcion de los que tienen cantidad en 0
                    Dim a As Integer = 0
                    Dim cantidad_a_mover As Decimal = CDec(txt_cant_mov.Text)
                    While a < DataGridView3.Rows.Count
                        If DataGridView3.Rows(a).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                            'Dim item As Integer
                            'If Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count = 0 Then
                            '    item = 1
                            'Else
                            '    item = Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count + 1
                            'End If
                            Dim newCustomersRow As DataRow = Nueva_Dialisis.Ds_enfermeria.Tables("Consumo_real").NewRow()
                            'newCustomersRow("N°") = item
                            newCustomersRow("Cod_prod") = DataGridView3.Rows(a).Cells("ProdcodinternoDataGridViewTextBoxColumn1").Value
                            newCustomersRow("Descripcion") = txt_descripcion_mov.Text + " (Lote Nº: " + DataGridView3.Rows(a).Cells("LotenroDataGridViewTextBoxColumn").Value + ")"
                            'newCustomersRow("Desde") = Nueva_Dialisis.cb_origen.Text
                            'newCustomersRow("Hacia") = Insumos_gestion.cb_origen.Text
                            'aqui veo cuanto voy a mover. si todo, o menos.
                            Dim cant_del_lote As Decimal = CDec(DataGridView3.Rows(a).Cells("lote_stock_real").Value)
                            If cant_del_lote <= cantidad_a_mover Then
                                'paso todo
                                newCustomersRow("Cantidad_real") = (Math.Round(CDec(cant_del_lote), 2).ToString("N2"))
                                cantidad_a_mover = cantidad_a_mover - cant_del_lote
                            Else
                                If cant_del_lote > cantidad_a_mover Then
                                    'pongo en el dataset lo que queda en la variable cantida_a_mover
                                    newCustomersRow("Cantidad_real") = (Math.Round(CDec(cantidad_a_mover), 2).ToString("N2"))
                                    'cantidad_a_mover = cantidad_a_mover - cant_del_lote
                                End If
                            End If
                            'newCustomersRow("Cantidad") = CDec(txt_cantlote.Text)
                            newCustomersRow("lote_id") = DataGridView3.Rows(a).Cells("LoteidDataGridViewTextBoxColumn").Value
                            'If DataGridView3.Rows(a).Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                            '    newCustomersRow("Vence") = "si"
                            '    newCustomersRow("FechaFabricacion") = DataGridView3.Rows(a).Cells("LotefechafabDataGridViewTextBoxColumn").Value
                            '    newCustomersRow("FechaVencimiento") = DataGridView3.Rows(a).Cells("LotefechavtoDataGridViewTextBoxColumn").Value
                            'Else
                            '    newCustomersRow("Vence") = "no"
                            'End If

                            newCustomersRow("Prov_id") = DataGridView3.Rows(a).Cells("Prov_id").Value

                            Nueva_Dialisis.Ds_enfermeria.Tables("Consumo_real").Rows.Add(newCustomersRow)
                        End If
                        a = a + 1
                    End While

                    'Nueva_Dialisis.DataGridView1.DataSource = Nueva_Dialisis.Mov_DS.Tables("Mov_Enf")
                    'bloque origen y destino combos en form gestion_mercaderia
                    'Nueva_Dialisis.cb_origen.Enabled = False
                    'Insumos_gestion.cb_destino.Enabled = False

                    Dim result As Integer = MessageBox.Show("¿Desea agregar más insumos?.", "Sistema de Gestión.", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                    ElseIf result = DialogResult.No Then
                        Me.Close()
                    End If




                    ''como ningun lote esta agregado, ahora sumo con los que existen en la grilla de gestion_mercaderia
                    'Dim suma_lote As Decimal = 0 'esto suma los lotes que quiero agregar mas los existentes en la lista del modulo Gestion_Mercaderia
                    'Dim j As Integer = 0
                    'While j < Nueva_Dialisis.DataGridView1.Rows.Count
                    '    If (Nueva_Dialisis.DataGridView1.Rows(j).Cells("CodprodDataGridViewTextBoxColumn").Value = cod_prod) Then
                    '        suma_lote = suma_lote + CDec(Nueva_Dialisis.DataGridView1.Rows(j).Cells("CantidadDataGridViewTextBoxColumn").Value)
                    '    End If
                    '    j = j + 1
                    'End While
                    'suma_lote = suma_lote + CDec(txt_cant_mov.Text) 'este total no debe ser mayor a la cantidad en stock de la sucursal.
                    'If suma_lote <= CDec(txt_totalunidades_mov.Text) Then
                    '    agregar_valido = "si"
                    'End If


                Else
                    'AQUI VIENE EL CARTEL QUE DIGA, EL PRODUCTO YA SE ENCUENTRA AGREGADO, ELIJA OTRO PRODUCTO.
                    MessageBox.Show("El insumo ya se encuentra agregado a la lista.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                'If encontrado = "no" And agregar_valido = "si" Then 'quiere decir que ningun lote se encuentra en la lista de gestin_mercaderia y que ademas sumados no superan el stock total de la sucursal.
                '    'agrego todos los lotes tildados, con excepcion de los que tienen cantidad en 0
                '    Dim a As Integer = 0
                '    Dim cantidad_a_mover As Decimal = CDec(txt_cant_mov.Text)
                '    While a < DataGridView3.Rows.Count
                '        If DataGridView3.Rows(a).Cells("DataGridViewCheckBoxColumn2").Value = True Then
                '            Dim item As Integer
                '            If Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count = 0 Then
                '                item = 1
                '            Else
                '                item = Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count + 1
                '            End If
                '            Dim newCustomersRow As DataRow = Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").NewRow()
                '            newCustomersRow("N°") = item
                '            newCustomersRow("Cod_prod") = DataGridView3.Rows(a).Cells("ProdcodinternoDataGridViewTextBoxColumn1").Value
                '            newCustomersRow("Descripcion") = txt_descripcion_mov.Text + " (Lote Nº: " + DataGridView3.Rows(a).Cells("LotenroDataGridViewTextBoxColumn").Value + ")"
                '            'newCustomersRow("Desde") = Nueva_Dialisis.cb_origen.Text
                '            'newCustomersRow("Hacia") = Insumos_gestion.cb_origen.Text
                '            'aqui veo cuanto voy a mover. si todo, o menos.
                '            Dim cant_del_lote As Decimal = CDec(DataGridView3.Rows(a).Cells("LotecantidadDataGridViewTextBoxColumn").Value)
                '            If cant_del_lote <= cantidad_a_mover Then
                '                'paso todo
                '                newCustomersRow("Cantidad") = (Math.Round(CDec(cant_del_lote), 2).ToString("N2"))
                '                cantidad_a_mover = cantidad_a_mover - cant_del_lote
                '            Else
                '                If cant_del_lote > cantidad_a_mover Then
                '                    'pongo en el dataset lo que queda en la variable cantida_a_mover
                '                    newCustomersRow("Cantidad") = (Math.Round(CDec(cantidad_a_mover), 2).ToString("N2"))
                '                    'cantidad_a_mover = cantidad_a_mover - cant_del_lote
                '                End If
                '            End If
                '            'newCustomersRow("Cantidad") = CDec(txt_cantlote.Text)
                '            newCustomersRow("Lote") = DataGridView3.Rows(a).Cells("LotenroDataGridViewTextBoxColumn").Value
                '            If DataGridView3.Rows(a).Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                '                newCustomersRow("Vence") = "si"
                '                newCustomersRow("FechaFabricacion") = DataGridView3.Rows(a).Cells("LotefechafabDataGridViewTextBoxColumn").Value
                '                newCustomersRow("FechaVencimiento") = DataGridView3.Rows(a).Cells("LotefechavtoDataGridViewTextBoxColumn").Value
                '            Else
                '                newCustomersRow("Vence") = "no"
                '            End If

                '            newCustomersRow("Prov_id") = DataGridView3.Rows(a).Cells("Prov_id").Value

                '            Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Add(newCustomersRow)
                '        End If
                '        a = a + 1
                '    End While
                '    Nueva_Dialisis.DataGridView1.DataSource = Nueva_Dialisis.Mov_DS.Tables("Mov_Enf")
                '    'bloque origen y destino combos en form gestion_mercaderia
                '    'Nueva_Dialisis.cb_origen.Enabled = False
                '    'Insumos_gestion.cb_destino.Enabled = False

                '    Dim result As Integer = MessageBox.Show("¿Desea agregar más lotes a el listado?.", "Sistema de Gestión.", MessageBoxButtons.YesNo)
                '    If result = DialogResult.Yes Then
                '    ElseIf result = DialogResult.No Then
                '        Me.Close()
                '    End If
                'Else
                '    If encontrado = "si" Then
                '        MessageBox.Show("El lote: " + nombre_lote + " ya se encuentra agregado a la lista.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Else
                '        If agregar_valido = "no" Then
                '            MessageBox.Show("Modifique cantidad, ésta superó el stock existente en la sucursal. ", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        End If
                '    End If
                'End If

                'Else
                '    MessageBox.Show("Modifique la cantidad, no debe superar el máximo de unidades en stock.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
            Else
                'MessageBox.Show("Debe ingresar una cantidad válida.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Error, modifique la cantidad a consumir.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    'quitar seleccion de la grilla lotes para movimientos
    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        If DataGridView3.Rows.Count <> 0 Then
            'quito toda selección
            Dim i As Integer = 0
            While i < DataGridView3.Rows.Count
                DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = False
                i += 1
            End While
            'pongo en rojo el panel, ya nada es valido
            Panel_cant_mover.BackColor = Color.Red

        End If
    End Sub


    Private Sub btn_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_siguiente.Click
        If DataGridView1.Rows.Count <> 0 Then
            If tipo_movimiento = "baja producto" Then
                ir_baja()
            End If

            If tipo_movimiento = "movimiento producto" Then
                ir_movimiento()

            End If

            If tipo_movimiento = "consumir producto" Or tipo_movimiento = "consumir producto en enfermeria" Or tipo_movimiento = "consumir Ausente" Then
                Dim stock As Decimal = CDec(DataGridView1.CurrentRow.Cells("ProdstockDataGridViewTextBoxColumn").Value)
                Dim vencidos As Decimal = CDec(DataGridView1.CurrentRow.Cells("CantvencimientoDataGridViewTextBoxColumn").Value)
                If stock = 0 Then
                    MessageBox.Show("No puede realizar la operación. No hay stock disponible.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If stock = vencidos Then
                        MessageBox.Show("No puede realizar la operación. Todos los insumos estan vencidos", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        ir_consumir() 'aqui se quitaran aquellos lotes que esten vencidos, esos no se pueden consumir
                    End If

                End If
                
            End If
        End If

    End Sub



    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        
    End Sub

    Private Sub formato_control_stock_v()
        'no lo uso mas, ahora uso el evento cellformating del gridview 1
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

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
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

        'Dim stock As Decimal = CDec(0)
        'If DataGridView1.Columns(e.ColumnIndex).Name = "ProdstockDataGridViewTextBoxColumn" Then
        '    stock = CDec(e.Value)
        'End If
        'If DataGridView1.Columns(e.ColumnIndex).Name = "ProdptorepoDataGridViewTextBoxColumn" Then
        '    Dim pto_repo As Decimal = CDec(e.Value)
        '    If stock <= pto_repo Then
        '        e.CellStyle.ForeColor = Color.Blue
        '        e.CellStyle.SelectionForeColor = Color.Blue
        '    End If
        'End If



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
        'formato_control_stock_vto() 'cuando click en el encabezado de las columnas se vuelve a poner los colores correspondientes
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
        txt_lote.Clear()
        txt_fechafab.Clear()
        txt_fechvto.Clear()
        txt_cantlote.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabPage4.Parent = Nothing 'oculto pestaña 2
        TabPage1.Parent = TabControl1 'pongo visible pestaña 1
        'pasamos a la otra pestaña
        TabControl1.SelectedTab = TabPage1

        'limpio los textbos del tabpage1
        txt_codigo_mov.Clear()
        txt_descripcion_mov.Clear()
        txt_totalunidades_mov.Clear()
        txt_cant_mov.Clear()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TabPage2.Parent = Nothing 'oculto pestaña 2
        TabPage1.Parent = TabControl1 'pongo visible pestaña 1
        'pasamos a la otra pestaña
        TabControl1.SelectedTab = TabPage1

        'limpio los textbos del tabpage1
        txt_codigo.Clear()
        txt_descripcion.Clear()
        txt_totalunidades.Clear()
        txt_lote.Clear()
        txt_fechafab.Clear()
        txt_fechvto.Clear()
        txt_cantlote.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TabPage4.Parent = Nothing 'oculto pestaña 2
        TabPage1.Parent = TabControl1 'pongo visible pestaña 1
        'pasamos a la otra pestaña
        TabControl1.SelectedTab = TabPage1

        'limpio los textbos del tabpage1
        txt_codigo_mov.Clear()
        txt_descripcion_mov.Clear()
        txt_totalunidades_mov.Clear()
        txt_cant_mov.Clear()
    End Sub


    Private Sub txt_cant_mov_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cant_mov.LostFocus
        calculo_real_validacion()

        'Dim valido As String = "no"
        'If txt_cant_mov.Text <> "" Then
        '    Dim cant As Decimal = CDec(txt_cant_mov.Text)
        '    Dim i As Integer = 0
        '    Dim suma As Integer = 0

        '    While i < DataGridView3.Rows.Count
        '        If cant > 0 Then
        '            If (CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value) <= cant) And (CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value) <> CDec(0)) Then
        '                'resto cantidad y tildo
        '                DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True
        '                cant = cant - CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value)
        '                If cant = 0 Then
        '                    valido = "si"
        '                    Exit While
        '                End If
        '            Else
        '                If (CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value) > 0) And (CDec(DataGridView3.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value) <> CDec(0)) Then
        '                    DataGridView3.Rows(i).Cells("DataGridViewCheckBoxColumn2").Value = True
        '                    cant = 0
        '                    valido = "si"
        '                    Exit While 'si es mayor, lo tildo y corto
        '                End If
        '            End If
        '        Else
        '            If cant = 0 And CDec(txt_cant_mov.Text) <> CDec(0) Then
        '                valido = "si"
        '            End If
        '            Exit While
        '        End If
        '        i = i + 1
        '    End While
        'End If
        'If valido = "si" Then
        '    'txt_cant_mov.BackColor = Color.Green
        '    Panel_cant_mover.BackColor = Color.Green
        'Else
        '    'txt_cant_mov.BackColor = Color.Red
        '    Panel_cant_mover.BackColor = Color.Red
        'End If


    End Sub

    Private Sub GM_Baja_Producto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TabPage2.Parent = Nothing 'oculto pestaña de lotes
        TabPage4.Parent = Nothing 'oculto pestaña de lotes
        'msj_esperar_sesiones.procedencia = "GM_Baja_Producto_load"
        'msj_esperar_sesiones.Show()
        LOAD_CARGA()
    End Sub

End Class