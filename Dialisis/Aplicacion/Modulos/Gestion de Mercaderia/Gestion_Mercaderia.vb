Public Class Gestion_Mercaderia
    Dim DAsucursal As New Datos.Sucursal
    Dim DAlote As New Datos.Lote
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Dim ds_PROD As DataSet
    Dim DAprod As New Datos.Producto
    Public procedencia As String
    

    Private Sub Gestion_Mercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sucursales_Obtener_Destino()
        Sucursales_Obtener_Origen()
        DateTimePicker1.Value = Today
        If procedencia = "baja" Then
            cb_Movimiento.SelectedIndex = 1
            Lbl_Titulo.Text = "BAJA DE INSUMOS"
        End If

        If procedencia = "movimiento" Then
            cb_Movimiento.SelectedIndex = 2
            Lbl_Titulo.Text = "MOVIMIENTO DE INSUMOS"
        End If


    End Sub
    Private Sub Sucursales_Obtener_Origen()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        cb_origen.DataSource = ds.Tables(0)
        cb_origen.DisplayMember = "sucursal_nombre"
        cb_origen.ValueMember = "sucursal_id"


    End Sub
    Private Sub Sucursales_Obtener_Destino()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        cb_destino.DataSource = ds.Tables(0)
        cb_destino.DisplayMember = "sucursal_nombre"
        cb_destino.ValueMember = "sucursal_id"
    End Sub
    Private Sub cb_Movimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Movimiento.SelectedIndexChanged
        If cb_Movimiento.SelectedItem = "Alta de Mercaderia" Then
            cb_origen.SelectedIndex = 0
            cb_origen.Enabled = False
            cb_destino.Enabled = False
        Else
            If cb_Movimiento.SelectedItem = "Movimiento Entre Sucursales" Then
                cb_destino.Enabled = True
            Else
                cb_destino.Enabled = False
                Igular_Combos()

            End If
        End If



        cb_Movimiento.Enabled = False
    End Sub
    Private Sub Igular_Combos()
        If cb_Movimiento.SelectedItem <> "Movimiento Entre Sucursales" Then
            cb_destino.SelectedIndex = cb_origen.SelectedIndex
        End If
    End Sub
    Private Sub cb_origen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_origen.SelectedIndexChanged
        Igular_Combos()
    End Sub

    Private Sub btn_Agregar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Prod.Click



        If cb_Movimiento.SelectedItem <> "" Then
            If cb_Movimiento.SelectedItem = "Movimiento Entre Sucursales" Then
                If cb_destino.SelectedIndex <> cb_origen.SelectedIndex Then



                    'es movimiento de mercaderia
                    GM_Baja_Producto.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
                    GM_Baja_Producto.sucursal_nombre = cb_origen.Text
                    GM_Baja_Producto.sucursal_id = CInt(cb_origen.SelectedValue)
                    GM_Baja_Producto.form_procedencia = "Gestion_Mercaderia"
                    GM_Baja_Producto.Text = "Sucursal: " + cb_origen.Text + " - Gestión movimiento de productos"
                    'GM_Baja_Producto.Text = "Gestión movimientos de productos."
                    GM_Baja_Producto.tipo_movimiento = "movimiento producto"
                    GM_Baja_Producto.Show()

                    'GM_Carga_Producto.Show()
                Else
                    MessageBox.Show("Debe ingresar Sucursales diferentes para realizar el movimiento de mercadería.", "Sistema de Gestión.")
                End If
            Else
                If cb_Movimiento.SelectedItem = "Alta de Mercaderia" Then
                    GM_Carga_Producto.Show()
                Else
                    If cb_Movimiento.SelectedItem = "Baja de Mercaderia" Then
                        'es baja de mercaderia
                        GM_Baja_Producto.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
                        GM_Baja_Producto.sucursal_nombre = cb_origen.Text
                        GM_Baja_Producto.sucursal_id = CInt(cb_origen.SelectedValue)
                        GM_Baja_Producto.form_procedencia = "Gestion_Mercaderia"
                        GM_Baja_Producto.Text = "Sucursal: " + cb_origen.Text + " - Gestión baja de productos"
                        GM_Baja_Producto.tipo_movimiento = "baja producto"
                        GM_Baja_Producto.Show()

                    End If


                End If

            End If
        Else
            MessageBox.Show("Debe seleccionar algún movimiento.", "Sistema de Gestión.")

        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Mov_DS.Tables("Mov").Rows.Clear()
        DataGridView1.DataSource = Mov_DS.Tables("Mov")
        cb_Movimiento.Enabled = True
        'desbloqueo origen y destino combos en form gestion_mercaderia
        cb_origen.Enabled = True
        cb_destino.Enabled = True
    End Sub

    Public Sub GUARDAR_CLICK()
        Dim concepto As String
        Dim tipo_mov As Integer
        If cb_Movimiento.SelectedItem = "Baja de Mercaderia" Then
            tipo_mov = 3
        End If
        If cb_Movimiento.SelectedItem = "Movimiento Entre Sucursales" Then
            tipo_mov = 2
        End If
        concepto = tb_concepto.Text
        ''''Alta en tabla Movimiento_Mercaderia''''''''''
        If Mov_DS.Tables("Mov").Rows.Count <> 0 Then
            Dim cantidad_items = DataGridView1.Rows.Count
            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea realizar: " + cb_Movimiento.Text + "?." + Chr(13) + "La Cantidad de productos en el listado es: " + cantidad_items.ToString, "Sistema de Gestión", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Dim lote_id As Integer
                Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, Today, Inicio.USU_id, cb_origen.SelectedValue, cb_destino.SelectedValue, "", Today, "", Today, tipo_mov, 0, 0, 0)
                ''''''''''''''''''''''''''''''''''''''''''''''''

                Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
                Dim i As Integer = 0
                While i < Mov_DS.Tables("Mov").Rows.Count
                    '''''Actualizacion de Stock''''''''''''''''''''''''
                    Dim Ds_Suc As DataSet
                    Dim Origen As Integer
                    Dim Destino As Integer
                    Dim Mov As Decimal
                    'Dim j As Integer = 0
                    'While i < Mov_DS.Tables("Mov").Rows.Count
                    ds_PROD = DAprod.Producto_buscarcod(Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"))
                    Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                    Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, cb_origen.SelectedValue, cb_destino.SelectedValue)
                    If cb_Movimiento.SelectedItem = "Movimiento Entre Sucursales" Then
                        'Calculo Stock''''''''
                        Origen = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov").Rows(i).Item("Cantidad")
                        ''''''''''
                        Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                        'ahora resto al stock real q ya existe en suc origne.
                        Dim stock_real_nuevo As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("ProdxSuc_stock_real")) - stock_real_ingreso


                        'Actualizo stock en origen'''''
                        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_origen.SelectedValue, Origen, stock_real_nuevo)
                        '''''''''''
                        'Calculo Stock''''''''
                        Destino = Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino") + Mov_DS.Tables("Mov").Rows(i).Item("Cantidad")
                        ''''''''''
                        stock_real_ingreso = CDec(Ds_Suc.Tables(1).Rows(0).Item("prod_contenido")) * CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                        'ahora sumo al stock real q ya existe en suc destino.
                        stock_real_nuevo = CDec(Ds_Suc.Tables(1).Rows(0).Item("ProdxSuc_stock_real")) + stock_real_ingreso

                        'Actualizo stock en destino'''''
                        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_destino.SelectedValue, Destino, stock_real_nuevo)
                        '''''''''''

                        'Choco 10-07-2020 ---aqui pongo todo lo referente a la creacion y movimiento de cantidades entre lotes.
                        '/////////////////////////////////
                        Dim lote_nro As String = Mov_DS.Tables("Mov").Rows(i).Item("Lote") 'necesario para la busqueda
                        '1) primero modifico el lote del producto que esta en sucursal de origen.
                        '1a) necesito recuperar lote_cantidad, ya que esta disminuira.
                        Dim prov_id As Integer = Mov_DS.Tables("Mov").Rows(i).Item("Prov_id") 'esto es necesario, ya q el lote depende del proveedor
                        Dim ds_lote_info As DataSet = DAlote.Lote_recuperar_info_lote(prod_id, lote_nro, cb_origen.SelectedValue, prov_id)
                        Dim cant_lote_existente As Decimal = CDec(ds_lote_info.Tables(0).Rows(0).Item("lote_cantidad"))
                        Dim cant_a_mover As Decimal = CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                        'ahora hago la diferencia
                        'Dim diferencia_para_origen As Decimal = cant_lote_existente - cant_a_mover
                        'ahora actualizo cant en lote origen.
                        Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, cb_origen.SelectedValue, cant_a_mover, Mov_DS.Tables("Mov").Rows(i).Item("Prov_id"), stock_real_ingreso, CDec(0))

                        '2) ahora actualizo en sucursal destino, 
                        '2a) tengo dos situaciones: que exista el lote en cuyo caso actualizo, o bien que no exista y lo doy de alta.
                        Dim ds_lote_info2 As DataSet = DAlote.Lote_recuperar_info_lote(prod_id, lote_nro, cb_destino.SelectedValue, prov_id)
                        If ds_lote_info2.Tables(0).Rows.Count = 0 Then
                            'si no existe lo doy de alta.
                            Dim fechafabricacion As Date
                            Dim fechavencimiento As Date
                            If Mov_DS.Tables("Mov").Rows(i).Item("Vence") = "si" Then
                                fechafabricacion = Mov_DS.Tables("Mov").Rows(i).Item("FechaFabricacion")
                                fechavencimiento = Mov_DS.Tables("Mov").Rows(i).Item("FechaVencimiento")
                            Else
                                fechafabricacion = Today
                                fechavencimiento = Today
                            End If
                            Dim ds_lote As DataSet = DAlote.Producto_x_sucursal_lote_alta(Mov_DS.Tables("Mov").Rows(i).Item("Lote"),
                                                                                          Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"),
                                                                                          fechafabricacion,
                                                                                          fechavencimiento,
                                                                                          prod_id,
                                                                                          cb_destino.SelectedValue,
                                                                                          Mov_DS.Tables("Mov").Rows(i).Item("Vence"), Mov_DS.Tables("Mov").Rows(i).Item("Prov_id"), stock_real_ingreso, CDec(0))
                            lote_id = ds_lote.Tables(0).Rows(0).Item("lote_id")
                        Else
                            'si existe, lo modificamos.

                            'Dim lote_nro As String = Mov_DS.Tables("Mov").Rows(i).Item("Lote")
                            Dim cant_a_sumar As Decimal = CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                            Dim dslote2 As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_suma(lote_nro, prod_id, cb_destino.SelectedValue, cant_a_sumar, Mov_DS.Tables("Mov").Rows(i).Item("Prov_id"), stock_real_ingreso)

                            lote_id = dslote2.Tables(0).Rows(0).Item("lote_id")

                        End If


                    End If
                    'If cb_Movimiento.SelectedItem = "Alta de Mercaderia" Then
                    '    'Calculo Stock''''''''
                    '    Mov = CDec(Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino")) + CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                    '    ''''''
                    '    ''''''''''
                    '    'Actualizo stock'''''
                    '    DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_origen.SelectedValue, Mov)
                    '    '''''''''''

                    '    'creo un registro en producto_x_sucursal_lote
                    '    'CHOCO 14-07-2020 aqui veo si existe el lote, actualizo la cantidad, pero si no existe registro como nuevo
                    '    Dim ds_lote_buscar As DataSet = DAlote.Lote_buscar_validar(cb_origen.SelectedValue, Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"), Mov_DS.Tables("Mov").Rows(i).Item("Lote"))
                    '    If ds_lote_buscar.Tables(0).Rows.Count <> 0 Then
                    '        'si existe actualizo
                    '        Dim fechafabricacion As Date
                    '        Dim fechavencimiento As Date
                    '        If Mov_DS.Tables("Mov").Rows(i).Item("Vence") = "si" Then
                    '            fechafabricacion = Mov_DS.Tables("Mov").Rows(i).Item("FechaFabricacion")
                    '            fechavencimiento = Mov_DS.Tables("Mov").Rows(i).Item("FechaVencimiento")
                    '        Else
                    '            fechafabricacion = Today
                    '            fechavencimiento = Today
                    '        End If
                    '        Dim ds_lote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_suma(Mov_DS.Tables("Mov").Rows(i).Item("Lote"), prod_id, cb_origen.SelectedValue,
                    '                                                                      Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                    '        lote_id = ds_lote.Tables(0).Rows(0).Item("lote_id")

                    '    Else
                    '        'si no existe doy de alta
                    '        Dim fechafabricacion As Date
                    '        Dim fechavencimiento As Date
                    '        If Mov_DS.Tables("Mov").Rows(i).Item("Vence") = "si" Then
                    '            fechafabricacion = Mov_DS.Tables("Mov").Rows(i).Item("FechaFabricacion")
                    '            fechavencimiento = Mov_DS.Tables("Mov").Rows(i).Item("FechaVencimiento")
                    '        Else
                    '            fechafabricacion = Today
                    '            fechavencimiento = Today
                    '        End If
                    '        Dim ds_lote As DataSet = DAlote.Producto_x_sucursal_lote_alta(Mov_DS.Tables("Mov").Rows(i).Item("Lote"),
                    '                                                                      Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"),
                    '                                                                      fechafabricacion,
                    '                                                                      fechavencimiento,
                    '                                                                      prod_id,
                    '                                                                      cb_origen.SelectedValue,
                    '                                                                      Mov_DS.Tables("Mov").Rows(i).Item("Vence"))
                    '        lote_id = ds_lote.Tables(0).Rows(0).Item("lote_id")
                    '    End If

                    'End If
                    If cb_Movimiento.SelectedItem = "Baja de Mercaderia" Then
                        'Calculo Stock''''''''
                        Mov = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov").Rows(i).Item("Cantidad")
                        '''''''
                        Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                        'ahora resto al stock real q ya existe en suc origne.
                        Dim stock_real_nuevo As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("ProdxSuc_stock_real")) - stock_real_ingreso

                        ''''''''''
                        'Actualizo stock''''' no quito el registro del producto en la sucursal, en realidad lo que hago es actualizar su cantidad a 0. OJO No tiene que hacerse negativo.
                        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_origen.SelectedValue, Mov, stock_real_nuevo) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
                        '''''''''''

                        '////////////////choco: 08-07-2020///////////////////////////////////
                        'actualizo la cant en el lote asociado a un producto de una sucursal.
                        Dim lote_nro As String = Mov_DS.Tables("Mov").Rows(i).Item("Lote")
                        Dim cant_a_quitar As Decimal = CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                        Dim Prov_id As Integer = Mov_DS.Tables("Mov").Rows(i).Item("Prov_id")
                        Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, cb_origen.SelectedValue, cant_a_quitar, Mov_DS.Tables("Mov").Rows(i).Item("Prov_id"), stock_real_ingreso, CDec(0))

                        lote_id = dslote.Tables(0).Rows(0).Item("lote_id")
                    End If

                    ''''''''''''''''''''''''''''''''''''''

                    '''''' Alta Tabla Detalle'''''' de movimiento claro está
                    'alta en tabla mercaderia_detalle_alta
                    DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"), MovMer_id, Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"), lote_id, CDec(0), CDec(0))
                    i = i + 1

                End While
                '''''''''''''''''''''''''''''''''''''''''''

                Limpiar()
                MessageBox.Show("Operación Registrada Con Éxito.", "Sistema de Gestión.")
            End If
        Else
            MessageBox.Show("Debe agregar al menos un producto.", "Sistema de Gestión.")
        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        msj_esperar_sesiones.procedencia = "Gestion_Mercaderia_GUARDAR"
        msj_esperar_sesiones.Show()
    End Sub

    Public Sub Limpiar()
        tb_concepto.Text = Nothing
        cb_Movimiento.Enabled = True
        'desbloqueo origen y destino combos en form gestion_mercaderia
        cb_origen.Enabled = True
        cb_destino.Enabled = True

        Mov_DS.Tables("Mov").Rows.Clear()
        DataGridView1.DataSource = Mov_DS.Tables("Mov")
    End Sub

    Private Sub tb_concepto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_concepto.GotFocus
        tb_concepto.SelectAll()
        tb_concepto.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_concepto.Visible = True
    End Sub

    Private Sub tb_concepto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_concepto.LostFocus
        tb_concepto.BackColor = Color.White
        'RectangleShape_concepto.Visible = False
    End Sub
    Private Sub cb_Movimiento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Movimiento.GotFocus
        cb_Movimiento.SelectAll()
        cb_Movimiento.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_movimiento.Visible = True
    End Sub
    Private Sub cb_Movimiento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Movimiento.LostFocus
        cb_Movimiento.BackColor = Color.White
        'RectangleShape_movimiento.Visible = False
    End Sub
    Private Sub cb_origen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_origen.GotFocus
        cb_origen.SelectAll()
        cb_origen.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_origen.Visible = True
    End Sub
    Private Sub cb_origen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_origen.LostFocus
        cb_origen.BackColor = Color.White
        'RectangleShape_origen.Visible = False
    End Sub


    Private Sub cb_destino_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_destino.GotFocus
        cb_destino.SelectAll()
        cb_destino.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_destino.Visible = True
    End Sub

    Private Sub cb_destino_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_destino.LostFocus
        cb_destino.BackColor = Color.White
        'RectangleShape_destino.Visible = False
    End Sub

    Private Sub Bo_codbarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_codbarra.Click
        GM_Consultar_Stock.Close()
        GM_Consultar_Stock.form_procedencia = "Gestion_Mercaderia"
        GM_Consultar_Stock.Show()


        'Busqueda_Productos.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
        'Busqueda_Productos.sucursal_nombre = cb_origen.Text
        'Busqueda_Productos.sucursal_id = CInt(cb_origen.SelectedValue)
        'Busqueda_Productos.form_procedencia = "Gestion_Mercaderia"
        'Busqueda_Productos.Show()
    End Sub

    Private Sub btn_eliminar_seleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_seleccion.Click
        ''aqui elemino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        Dim valido_seleccion As String = "no"
        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                        If MsgBox("¿Esta seguro que quiere quitar los items seleccionados?.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                            pregunta = "si"
                        Else
                            'aqui corto el ciclo, ya que se cancelo la eliminacion
                            i = DataGridView1.Rows.Count
                        End If
                    End If
                    If pregunta = "si" Then
                        'primero guardo el nro de item q contiene
                        Dim item As Decimal = DataGridView1.CurrentRow.Index
                        DataGridView1.Rows.RemoveAt(i)
                        i = 0 'lo reinicio, x q al quitar un ite, se reordenan los indices
                        'If item <= Venta_Caja_ds.Tables("Producto_agregado").Rows.Count Then 'esta validacion es x q el ds tiene menos celdas 
                        '    Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Delete()
                        'End If
                        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                        'cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
                        Dim a As Integer = 0
                        While a < DataGridView1.Rows.Count
                            If DataGridView1.Rows(a).Cells(1).Value <> 0 Then
                                DataGridView1.Rows(a).Cells(0).Value = a + 1
                            End If
                            a = a + 1
                        End While
                        'calcular_totales()
                        'aplicar_iva()
                    End If
                Else
                    i = i + 1
                End If
            End While

            If valido_seleccion = "no" Then
                MessageBox.Show("Seleccione un producto para eliminar.", "Sistema de Gestión.")
            End If
        Else
            MessageBox.Show("No hay productos en el listado.", "Sistema de Gestión")
        End If
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        If DataGridView1.Rows.Count <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea quitar todos los productos del listado?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Mov_DS.Tables("Mov").Rows.Clear() 'no uso el datagridview rows clear...x q me tira error x el dataset q esta asociado
                'DataGridView1.Rows.clear 
                'DataGridView1.Rows.Add()
                'DataGridView1.Focus()
                'DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True
            End If
        Else
            MessageBox.Show("No hay productos en el listado.", "Sistema de Gestión.")
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Movimientos_consulta.Close()
        If procedencia = "baja" Then
            Movimientos_consulta.tipo_consulta = "solo bajas" 'esto hago para q la grilla solo me muestre bajas
            Movimientos_consulta.Text = "Consulta de bajas - registros historicos"
        Else
            Movimientos_consulta.Text = "Consulta de movimientos - registros historicos"
        End If
        Movimientos_consulta.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Insumos_gestion.Close()
        Insumos_gestion.Show()
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub MovBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovBindingSource.CurrentChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub tb_concepto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_concepto.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Lbl_Titulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Titulo.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub cb_destino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_destino.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

   
End Class