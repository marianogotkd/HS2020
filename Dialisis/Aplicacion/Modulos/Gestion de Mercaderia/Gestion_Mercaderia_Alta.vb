Public Class Gestion_Mercaderia_Alta


    Dim DAproveedor As New Datos.Proveedor
    Dim DAsucursal As New Datos.Sucursal
    Dim DAsuc As New Datos.Sucursal
    Dim DAlote As New Datos.Lote
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia


    Public Sub Cargarcombo_proveedor()
        'Cargar los proveedores
        Dim ds_proveedor As DataSet = DAproveedor.Proveedor_obtener
        cb_proveedor.DataSource = ds_proveedor.Tables(0)
        cb_proveedor.DisplayMember = "Prov_nombre"
        cb_proveedor.ValueMember = "Prov_id"
        cb_proveedor.SelectedValue = ds_proveedor.Tables(0).Rows(0).Item("Prov_id")
    End Sub

    Private Sub Gestion_Mercaderia_Alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargarcombo_proveedor()
        Sucursales_Obtener_Origen()
        Sucursales_Obtener_Destino()
        DateTimePicker1.Value = Today
        ComboBox_iva.SelectedIndex = 0
    End Sub

    Private Sub Sucursales_Obtener_Origen()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        cb_origen.DataSource = ds.Tables(0)
        cb_origen.DisplayMember = "sucursal_nombre"
        cb_origen.ValueMember = "sucursal_id"
        'selecciono deposito y bloqueo ahi, siempre se hacen las altas en deposito.
        cb_origen.SelectedIndex = 0
        cb_origen.Enabled = False
    End Sub
    Private Sub Sucursales_Obtener_Destino()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        cb_destino.DataSource = ds.Tables(0)
        cb_destino.DisplayMember = "sucursal_nombre"
        cb_destino.ValueMember = "sucursal_id"
        'selecciono deposito y bloqueo ahi, siempre se hacen las altas en deposito.
        cb_destino.SelectedIndex = 0
        cb_destino.Visible = False
    End Sub

    Private Sub cb_proveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_proveedor.SelectedValueChanged
        If cb_proveedor.Items.Count <> 0 Then
            'como tiene algo recupero los productos para ese proveedor


        End If


    End Sub
    Dim Validaciones As New Validaciones
    Dim ds_PROD As DataSet
    Dim DAprod As New Datos.Producto
    Public Sub Buscar_Cantidades(ByVal prod_id As Integer, ByVal suc_id_Origen As Integer, ByVal suc_id_destino As Integer)
        Dim Ds_Suc As DataSet
        Ds_Suc = DAsuc.Sucursal_obtener_producto(prod_id, suc_id_Origen, suc_id_destino)
        tb_cant_Or.Text = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen")
        'tb_cant_dest.Text = Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino")
    End Sub
    Private Sub tb_codint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_codint.KeyPress
        Validaciones.Restricciones_textbox(e, "Entero", tb_codint)
        If e.KeyChar = ChrW(Keys.Enter) And e.Handled = False Then
            cb_proveedor.Enabled = False 'aqui lo bloqueo para que no me deje cambiar de proveedor, si deseo hacerlo tengo q hacer clic en el boton CANCELAR
            ds_PROD = DAprod.Producto_buscarcod_en_proveedor(tb_codint.Text, cb_proveedor.SelectedValue)
            If ds_PROD.Tables(0).Rows.Count <> 0 Then
                tb_desc.Text = ds_PROD.Tables(0).Rows(0).Item("prod_descripcion")
                Buscar_Cantidades(ds_PROD.Tables(0).Rows(0).Item("prod_id"), cb_origen.SelectedValue, cb_destino.SelectedValue)



                '//////////////////esto hago si el movimiento es alta de marcaderia///////////////////////////////////////////////

                'If Gestion_Mercaderia.cb_Movimiento.Text = "Alta de Mercaderia" Then
                Grupo_lote.Enabled = True
                If ds_PROD.Tables(2).Rows.Count <> 0 Then 'recupera el producto solo si tiene Lote = "SI"
                    'si es distinto de 0, significa que tiene lotes que se van a colocar incrementales, es decir NO
                    Dim ds_lotes As DataSet = DAlote.Lote_buscar_producto(tb_codint.Text, cb_origen.SelectedValue)
                    If ds_lotes.Tables(1).Rows.Count = 0 Then
                        'como no tengo lotes, creo el primer lote en 1
                        Dim nrolote_de_bd As Integer = 0
                        'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                        Dim i As Integer = 0
                        While i < DataGridView1.Rows.Count
                            If DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = tb_codint.Text Then
                                nrolote_de_bd = CInt(DataGridView1.Rows(i).Cells("Lote").Value)
                            End If
                            i = i + 1
                        End While
                        nrolote_de_bd = nrolote_de_bd + 1
                        txt_nrolote.Text = nrolote_de_bd
                    Else
                        'como tengo varios lotes, busco el ultimo e incremento en 1.
                        Dim nrolote_de_bd As Integer = CInt(ds_lotes.Tables(1).Rows(ds_lotes.Tables(1).Rows.Count - 1).Item("lote_nro"))
                        'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                        Dim i As Integer = 0
                        While i < DataGridView1.Rows.Count
                            If DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = tb_codint.Text Then
                                nrolote_de_bd = CInt(DataGridView1.Rows(i).Cells("Lote").Value)
                            End If
                            i = i + 1
                        End While
                        nrolote_de_bd = nrolote_de_bd + 1
                        txt_nrolote.Text = nrolote_de_bd
                    End If
                    txt_nrolote.Enabled = False
                    'Label8.Text = "Ingreso Nº:"
                Else
                    'txt_nrolote.Enabled = True
                    ' Label8.Text = "Lote Nº:"
                End If
                'If
                '/////////////////////////////////////////////////////////////////////////////////////////////////////
            Else
                MessageBox.Show("El producto no existe para el proveedor seleccionado.", "Sistema de Gestión.")
                limpiar_seccion_agregar()
            End If
        End If
    End Sub

    Private Sub limpiar_seccion_agregar()
        'tb_cant_dest.Text = Nothing
        tb_Cant_Movi.Text = Nothing
        tb_precioU.Text = Nothing
        tb_cant_Or.Text = Nothing
        tb_codint.Text = Nothing
        tb_desc.Text = Nothing
        txt_nrolote.Text = Nothing
        DateTimePicker_ffabricacion.Value = Today
        DateTimePicker_fvencimiento.Value = Today
        CheckBox_vto.Checked = False
        Grupo_lote.Enabled = False

    End Sub

    Private Sub tb_Cant_Movi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Cant_Movi.KeyPress
        Dim tipo As String = "Entero"
        Validaciones.Restricciones_textbox(e, tipo, tb_Cant_Movi)
    End Sub

    Private Sub tb_precioU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_precioU.KeyPress
        Dim tipo As String = "Decimal"
        Validaciones.Restricciones_textbox(e, tipo, tb_precioU)
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

    Private Sub btn_agregarr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregarr.Click
        If tb_codint.Text <> "" Then

            If txt_nrolote.Text <> "" Then
                'primero valido que el nro de lote no exista en la lista o bien en la base de datos
                Dim existe As String = "no"
                Dim ds_lote As DataSet = DAlote.Lote_buscar_validar(cb_origen.SelectedValue, CInt(tb_codint.Text), txt_nrolote.Text, cb_proveedor.SelectedValue)
                If ds_lote.Tables(0).Rows.Count <> 0 Then
                    Dim result As Integer = MessageBox.Show("Ya existen unidades en stock con Nº lote: " + txt_nrolote.Text + ". ¿Desea agregar de todos modos?", "Sistema de Gestión.", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        existe = "no"
                    ElseIf result = DialogResult.No Then
                        existe = "si"
                    End If
                Else
                    'si no existe en bd lo busco en la grilla donde voy agregando los lotes.
                    Dim i As Integer = 0

                    While i < DataGridView1.Rows.Count
                        If DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = tb_codint.Text And DataGridView1.Rows(i).Cells("Lote").Value = txt_nrolote.Text Then
                            existe = "si"
                            Exit While
                        End If
                        i = i + 1
                    End While
                    If existe = "si" Then
                        txt_nrolote.SelectAll()
                        txt_nrolote.Focus()
                        MessageBox.Show("El Nº de lote ya se encuentra en la lista. Por favor modifique.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

                If existe = "no" Then
                    If tb_desc.Text <> "" Then

                        If tb_Cant_Movi.Text <> "" Then
                            If tb_precioU.Text = "" Then
                                tb_precioU.Text = 0
                            End If

                            'If CInt(tb_Cant_Movi.Text) <= CInt(tb_cant_Or.Text) And CInt(tb_Cant_Movi.Text) <> 0 Then

                            Dim item As Integer
                            If Mov_DS.Tables("Mov").Rows.Count = 0 Then
                                item = 1
                            Else
                                item = Mov_DS.Tables("Mov").Rows.Count + 1
                            End If

                            Dim newCustomersRow As DataRow = Mov_DS.Tables("Mov").NewRow()
                            newCustomersRow("N°") = item
                            newCustomersRow("Cod_prod") = tb_codint.Text
                            newCustomersRow("Descripcion") = tb_desc.Text + " (Nº: " + txt_nrolote.Text + ")"
                            newCustomersRow("Desde") = tb_origen.Text
                            newCustomersRow("Hacia") = tb_origen.Text
                            newCustomersRow("Cantidad") = tb_Cant_Movi.Text
                            newCustomersRow("Lote") = txt_nrolote.Text
                            If CheckBox_vto.Checked = True Then
                                newCustomersRow("Vence") = "si"
                                newCustomersRow("FechaFabricacion") = DateTimePicker_ffabricacion.Value
                                newCustomersRow("FechaVencimiento") = DateTimePicker_fvencimiento.Value
                            Else

                                newCustomersRow("Vence") = "no"
                            End If
                            newCustomersRow("PrecioU") = (Math.Round(CDec(tb_precioU.Text), 2).ToString("N2"))
                            Dim subtotal As Decimal = CInt(tb_Cant_Movi.Text) * CDec(tb_precioU.Text)
                            newCustomersRow("Subtotal") = (Math.Round(CDec(subtotal), 2).ToString("N2"))
                            Mov_DS.Tables("Mov").Rows.Add(newCustomersRow)
                            DataGridView1.DataSource = Mov_DS.Tables("Mov")

                            calcular_total()

                            'bloque origen y destino combos en form gestion_mercaderia
                            cb_origen.Enabled = False
                            cb_destino.Enabled = False

                            limpiar_seccion_agregar()

                            'Else
                            '    MessageBox.Show("La cantidad debe ser menor a el stock disponible en la sucursal de origen", "Sistema de Gestion.")
                            '    tb_Cant_Movi.Focus()
                            'End If
                        Else
                            MessageBox.Show("Debe ingresar la cantidad.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            tb_Cant_Movi.Focus()
                        End If
                    Else
                        MessageBox.Show("Debe seleccionar un producto", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        tb_codint.Focus()
                    End If
                End If
            Else
                txt_nrolote.SelectAll()
                txt_nrolote.Focus()
                MessageBox.Show("Ingrese un Nº de lote.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            tb_codint.SelectAll()
            tb_codint.Focus()
            MessageBox.Show("Indique que producto desea agregar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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
                        calcular_total()
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
                calcular_total()
                'DataGridView1.Rows.clear 
                'DataGridView1.Rows.Add()
                'DataGridView1.Focus()
                'DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True
            End If
        Else
            MessageBox.Show("No hay productos en el listado.", "Sistema de Gestión.")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Mov_DS.Tables("Mov").Rows.Clear()
        DataGridView1.DataSource = Mov_DS.Tables("Mov")
        cb_proveedor.Enabled = True
        'cb_Movimiento.Enabled = True
        'desbloqueo origen y destino combos en form gestion_mercaderia
        'cb_origen.Enabled = True
        'cb_destino.Enabled = True
        'limpiar encabezado
        tb_concepto.Clear()
        nro_factura.Clear()
        nro_remito.Clear()
        fecha_factura.Value = Today
        fecha_remito.Value = Today
        calcular_total()

        limpiar_seccion_agregar()
    End Sub

    Private Sub Bo_codbarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_codbarra.Click
        GM_Consultar_Stock.Close()
        GM_Consultar_Stock.form_procedencia = "Gestion_Mercaderia"
        GM_Consultar_Stock.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Consulta_Alta_a.Close()
        Consulta_Alta_a.Show()
        'Movimientos_consulta.Close()
        'Movimientos_consulta.Show()
    End Sub

    Public Sub GUARDAR_CLICK()
        Dim concepto As String
        concepto = tb_concepto.Text
        Dim tipo_mov As Integer = 1
        ''''Alta en tabla Movimiento_Mercaderia''''''''''
        If Mov_DS.Tables("Mov").Rows.Count <> 0 Then
            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea registrar los productos listados?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim lote_id As Integer

                'controlamos factura y remito
                Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, DateTimePicker1.Value.Date, Inicio.USU_id, cb_origen.SelectedValue, cb_destino.SelectedValue, nro_factura.Text, fecha_factura.Value.Date, nro_remito.Text, fecha_remito.Value.Date, tipo_mov, cb_proveedor.SelectedValue, ComboBox_iva.Text, txt_total.Text)
                ''''''''''''''''''''''''''''''''''''''''''''''''
                Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
                Dim i As Integer = 0
                While i < Mov_DS.Tables("Mov").Rows.Count
                    '''''Actualizacion de Stock''''''''''''''''''''''''
                    Dim Ds_Suc As DataSet
                    'Dim Origen As Integer
                    'Dim Destino As Integer
                    Dim Mov As Decimal
                    'Dim j As Integer = 0
                    'While i < Mov_DS.Tables("Mov").Rows.Count
                    ds_PROD = DAprod.Producto_buscarcod(Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"))
                    Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                    Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, cb_origen.SelectedValue, cb_destino.SelectedValue)
                    'If cb_Movimiento.SelectedItem = "Movimiento Entre Sucursales" Then
                    '    'Calculo Stock''''''''
                    '    Origen = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov").Rows(i).Item("Cantidad")
                    '    ''''''''''
                    '    'Actualizo stock'''''
                    '    DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_origen.SelectedValue, Origen)
                    '    '''''''''''
                    '    'Calculo Stock''''''''
                    '    Destino = Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino") + Mov_DS.Tables("Mov").Rows(i).Item("Cantidad")
                    '    ''''''''''
                    '    'Actualizo stock'''''
                    '    DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_destino.SelectedValue, Destino)
                    '    '''''''''''

                    '    'Choco 10-07-2020 ---aqui pongo todo lo referente a la creacion y movimiento de cantidades entre lotes.
                    '    '/////////////////////////////////
                    '    Dim lote_nro As String = Mov_DS.Tables("Mov").Rows(i).Item("Lote") 'necesario para la busqueda
                    '    '1) primero modifico el lote del producto que esta en sucursal de origen.
                    '    '1a) necesito recuperar lote_cantidad, ya que esta disminuira.
                    '    Dim ds_lote_info As DataSet = DAlote.Lote_recuperar_info_lote(prod_id, lote_nro, cb_origen.SelectedValue)
                    '    Dim cant_lote_existente As Decimal = CDec(ds_lote_info.Tables(0).Rows(0).Item("lote_cantidad"))
                    '    Dim cant_a_mover As Decimal = CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                    '    'ahora hago la diferencia
                    '    'Dim diferencia_para_origen As Decimal = cant_lote_existente - cant_a_mover
                    '    'ahora actualizo cant en lote origen.
                    '    Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, cb_origen.SelectedValue, cant_a_mover)

                    '    '2) ahora actualizo en sucursal destino, 
                    '    '2a) tengo dos situaciones: que exista el lote en cuyo caso actualizo, o bien que no exista y lo doy de alta.
                    '    Dim ds_lote_info2 As DataSet = DAlote.Lote_recuperar_info_lote(prod_id, lote_nro, cb_destino.SelectedValue)
                    '    If ds_lote_info2.Tables(0).Rows.Count = 0 Then
                    '        'si no existe lo doy de alta.
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
                    '                                                                      cb_destino.SelectedValue,
                    '                                                                      Mov_DS.Tables("Mov").Rows(i).Item("Vence"))
                    '        lote_id = ds_lote.Tables(0).Rows(0).Item("lote_id")
                    '    Else
                    '        'si existe, lo modificamos.

                    '        'Dim lote_nro As String = Mov_DS.Tables("Mov").Rows(i).Item("Lote")
                    '        Dim cant_a_sumar As Decimal = CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                    '        Dim dslote2 As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_suma(lote_nro, prod_id, cb_destino.SelectedValue, cant_a_sumar)

                    '        lote_id = dslote2.Tables(0).Rows(0).Item("lote_id")

                    '    End If


                    'End If


                    'If cb_Movimiento.SelectedItem = "Alta de Mercaderia" Then
                    'Calculo Stock''''''''

                    Mov = CDec(Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino")) + CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))


                    'CHOCO - 21-01-2021/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    'ahora calculo el stock real, para ello multiplico la cant q ingreso en el gridview por el campo contenido q traigo de la tabla producto
                    Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                    'ahora sumo al stock real q ya existe.
                    Dim stock_real_nuevo As Decimal = CDec(Ds_Suc.Tables(1).Rows(0).Item("ProdxSuc_stock_real")) + stock_real_ingreso
                    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    ''''''
                    ''''''''''
                    'Actualizo stock''''' en sucursal deposito
                    DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_origen.SelectedValue, Mov, stock_real_nuevo)
                    '''''''''''

                    'creo un registro en producto_x_sucursal_lote
                    'CHOCO 14-07-2020 aqui veo si existe el lote, actualizo la cantidad, pero si no existe registro como nuevo
                    Dim ds_lote_buscar As DataSet = DAlote.Lote_buscar_validar(cb_origen.SelectedValue, Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"), Mov_DS.Tables("Mov").Rows(i).Item("Lote"), cb_proveedor.SelectedValue)
                    If ds_lote_buscar.Tables(0).Rows.Count <> 0 Then
                        'si existe actualizo
                        Dim fechafabricacion As Date
                        Dim fechavencimiento As Date
                        If Mov_DS.Tables("Mov").Rows(i).Item("Vence") = "si" Then
                            fechafabricacion = Mov_DS.Tables("Mov").Rows(i).Item("FechaFabricacion")
                            fechavencimiento = Mov_DS.Tables("Mov").Rows(i).Item("FechaVencimiento")
                        Else
                            fechafabricacion = Today
                            fechavencimiento = Today
                        End If
                        Dim ds_lote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_suma(Mov_DS.Tables("Mov").Rows(i).Item("Lote"), prod_id, cb_origen.SelectedValue,
                                                                                      Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"), cb_proveedor.SelectedValue, stock_real_ingreso)
                        lote_id = ds_lote.Tables(0).Rows(0).Item("lote_id")

                    Else
                        'si no existe doy de alta
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
                                                                                      cb_origen.SelectedValue,
                                                                                      Mov_DS.Tables("Mov").Rows(i).Item("Vence"), cb_proveedor.SelectedValue,
                                                                                      stock_real_ingreso, CDec(0))
                        lote_id = ds_lote.Tables(0).Rows(0).Item("lote_id")
                    End If



                    'End If
                    'If cb_Movimiento.SelectedItem = "Baja de Mercaderia" Then
                    '    'Calculo Stock''''''''
                    '    Mov = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov").Rows(i).Item("Cantidad")
                    '    '''''''
                    '    ''''''''''
                    '    'Actualizo stock''''' no quito el registro del producto en la sucursal, en realidad lo que hago es actualizar su cantidad a 0. OJO No tiene que hacerse negativo.
                    '    DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_origen.SelectedValue, Mov) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
                    '    '''''''''''

                    '    '////////////////choco: 08-07-2020///////////////////////////////////
                    '    'actualizo la cant en el lote asociado a un producto de una sucursal.
                    '    Dim lote_nro As String = Mov_DS.Tables("Mov").Rows(i).Item("Lote")
                    '    Dim cant_a_quitar As Decimal = CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                    '    Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, cb_origen.SelectedValue, cant_a_quitar)

                    '    lote_id = dslote.Tables(0).Rows(0).Item("lote_id")
                    'End If

                    ''''''''''''''''''''''''''''''''''''''




                    '''''' Alta Tabla Detalle'''''' de movimiento claro está
                    'alta en tabla mercaderia_detalle_alta
                    DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"), MovMer_id, Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"), lote_id, Mov_DS.Tables("Mov").Rows(i).Item("PrecioU"), Mov_DS.Tables("Mov").Rows(i).Item("Subtotal"))
                    i = i + 1
                End While
                '''''''''''''''''''''''''''''''''''''''''''

                limpiar_seccion_agregar()
                limpiar()
                calcular_total()
                MessageBox.Show("Operación Registrada Con Éxito.", "Sistema de Gestión.")
            End If
        Else
            MessageBox.Show("Debe agregar al menos un producto.", "Sistema de Gestión.")
        End If
    End Sub
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        msj_esperar_sesiones.procedencia = "Gestion_Mercaderia_Alta_btn_guardad_click"
        msj_esperar_sesiones.Show()

        'vamos a probar el rollback si falla la conexion
        ' rollback()

    End Sub


    Private Sub rollback()

        Dim concepto As String
        concepto = tb_concepto.Text
        Dim tipo_mov As Integer = 1
        ''''Alta en tabla Movimiento_Mercaderia''''''''''
        If Mov_DS.Tables("Mov").Rows.Count <> 0 Then
            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea registrar los productos listados?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim lote_id As Integer = 0

                'controlamos factura y remito
                Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, DateTimePicker1.Value.Date, Inicio.USU_id, cb_origen.SelectedValue, cb_destino.SelectedValue, nro_factura.Text, fecha_factura.Value.Date, nro_remito.Text, fecha_remito.Value.Date, tipo_mov, cb_proveedor.SelectedValue, 0, 0)
                ''''''''''''''''''''''''''''''''''''''''''''''''
                Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
                Dim i As Integer = 0


                Dim valido As String = DAMovintoMer.rollback(Mov_DS.Tables("Mov"), MovMer_id)
                
                'DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"), MovMer_id, Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"), lote_id, Mov_DS.Tables("Mov").Rows(i).Item("PrecioU"), Mov_DS.Tables("Mov").Rows(i).Item("Subtotal"))






                'While i < Mov_DS.Tables("Mov").Rows.Count
                '    '''''Actualizacion de Stock''''''''''''''''''''''''
                '    Dim Ds_Suc As DataSet
                '    'Dim Origen As Integer
                '    'Dim Destino As Integer
                '    Dim Mov As Decimal
                '    'Dim j As Integer = 0
                '    'While i < Mov_DS.Tables("Mov").Rows.Count
                '    ds_PROD = DAprod.Producto_buscarcod(Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"))
                '    Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                '    Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, cb_origen.SelectedValue, cb_destino.SelectedValue)

                '    'Calculo Stock''''''''
                '    Mov = CDec(Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino")) + CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                '    ''''''
                '    ''''''''''
                '    'Actualizo stock'''''
                '    DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_origen.SelectedValue, Mov)
                '    '''''''''''

                '    'creo un registro en producto_x_sucursal_lote
                '    'CHOCO 14-07-2020 aqui veo si existe el lote, actualizo la cantidad, pero si no existe registro como nuevo
                '    Dim ds_lote_buscar As DataSet = DAlote.Lote_buscar_validar(cb_origen.SelectedValue, Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"), Mov_DS.Tables("Mov").Rows(i).Item("Lote"), cb_proveedor.SelectedValue)
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
                '                                                                      Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"), cb_proveedor.SelectedValue)
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
                '                                                                      Mov_DS.Tables("Mov").Rows(i).Item("Vence"), cb_proveedor.SelectedValue)
                '        lote_id = ds_lote.Tables(0).Rows(0).Item("lote_id")
                '    End If





                '    '''''' Alta Tabla Detalle'''''' de movimiento claro está
                '    'alta en tabla mercaderia_detalle_alta
                '    DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"), MovMer_id, Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"), lote_id, Mov_DS.Tables("Mov").Rows(i).Item("PrecioU"), Mov_DS.Tables("Mov").Rows(i).Item("Subtotal"))
                '    i = i + 1
                'End While
                '''''''''''''''''''''''''''''''''''''''''''

                If valido = "si" Then
                    limpiar_seccion_agregar()
                    limpiar()
                    calcular_total()
                    MessageBox.Show("Operación Registrada Con Éxito.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error, la transacción fallo, intente nuevamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Debe agregar al menos un producto.", "Sistema de Gestión.")
        End If


    End Sub

    Private Sub limpiar()
        Mov_DS.Tables("Mov").Rows.Clear()
        DataGridView1.DataSource = Mov_DS.Tables("Mov")
        cb_proveedor.Enabled = True
        'cb_Movimiento.Enabled = True
        'desbloqueo origen y destino combos en form gestion_mercaderia
        'cb_origen.Enabled = True
        'cb_destino.Enabled = True
        'limpiar encabezado
        tb_concepto.Clear()
        nro_factura.Clear()
        nro_remito.Clear()
        fecha_factura.Value = Today
        fecha_remito.Value = Today
    End Sub


    Public subtotal_s_iva As Decimal
    Private Sub calcular_total()
        Dim TOTAL As Decimal = 0
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            TOTAL = TOTAL + DataGridView1.Rows(i).Cells("Subtotal").Value

            i = i + 1
        End While
        txt_total.Text = (Math.Round(CDec(TOTAL), 2).ToString("N2"))
        subtotal_s_iva = (Math.Round(CDec(TOTAL), 2).ToString("N2"))

        'aplico el iva seleccionado en el combo
        aplicar_iva()


    End Sub


    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        Busqueda_Productos.Close() 'lo cierro primero, ya que se usa en diferentes modulos
        Busqueda_Productos.form_procedencia = "GM_Carga_Producto"
        Busqueda_Productos.sucursal_id = CInt(cb_origen.SelectedValue)
        'choco: 27-08-2020 ahora tambien debo mandar el id del proveedor para q la grilla del formulario solo me muestre los productos de ese proveedor, nada mas.
        cb_proveedor.Enabled = False
        Busqueda_Productos.Prov_id = CInt(cb_proveedor.SelectedValue)
        Busqueda_Productos.Text = "Sucursal: " + cb_origen.Text + " - Proveedor: " + cb_proveedor.Text + " - Busqueda de productos"
        Busqueda_Productos.Show()
    End Sub

    Private Sub aplicar_iva()

        If ComboBox_iva.SelectedItem = "0" Then
            txt_total.Text = subtotal_s_iva
        End If
        If ComboBox_iva.SelectedItem = "10,5" And txt_total.Text <> 0 Then

            '////////////////////////////IMPUESTO////////////////////////////////////////
            'calculo el 10.5% al subtotla de la venta.
            Dim calculo As Decimal = (CDec(10.5) * CDec(subtotal_s_iva)) / 100
            '////////////////////////////////////////////////////////////////////////////

            '/////////////////////TOTAL A PAGAR//////////////////////////////////
            txt_total.Text = CDec(subtotal_s_iva) + calculo
            txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////

        End If

        If ComboBox_iva.SelectedItem = "21" And txt_total.Text <> 0 Then

            '////////////////////////////IMPUESTO////////////////////////////////////////
            'calculo el 10.5% al subtotla de la venta.
            Dim calculo As Decimal = (CDec(21) * CDec(subtotal_s_iva)) / 100
            '////////////////////////////////////////////////////////////////////////////

            '/////////////////////TOTAL A PAGAR//////////////////////////////////
            txt_total.Text = CDec(subtotal_s_iva) + calculo
            txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////
        End If
    End Sub
    
    Private Sub ComboBox_iva_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_iva.SelectedValueChanged
        aplicar_iva()
    End Sub
End Class