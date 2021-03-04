Public Class Ajuste_alta
    Dim DAlote As New Datos.Lote
    Public sucursal_id As Integer
    Public codinterno As Integer
    Dim DAproducto As New Datos.Producto
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Dim ds_PROD As DataSet
    Dim DAprod As New Datos.Producto
    Dim DAsucursal As New Datos.Sucursal
    'Public ds_producto_recuperado As New Producto_ds 'esto voy a usar para los ProveedorProducto
    Private Sub recuperar_proveedores_del_producto()
        Dim ds_producto As New DataSet
        ds_producto = DAproducto.Productos_Obtener_Modificar(codinterno)
        If ds_producto.Tables(0).Rows.Count <> 0 Then
            'Proveedores_X_Producto.prod_id = ds_producto.Tables(0).Rows(0).Item("prod_id")
            Dim item As Integer = 0
            'Limpiar Dataset
            'ds_producto_recuperado.Tables("ProveedorProducto").Clear()
            ''Cargo la grilla Proveedores_X_productos
            cb_proveedor.DataSource = ds_producto.Tables(0)
            cb_proveedor.ValueMember = "Prov_id"
            cb_proveedor.DisplayMember = "Prov_nombre"
        End If
    End Sub


    Private Sub btn_agregarr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregarr.Click
        If txt_nrolote.Text <> "" Then
            'primero valido que el nro de lote no exista en la lista o bien en la base de datos
            Dim existe As String = "no"
            Dim ds_lote As DataSet = DAlote.Lote_buscar_validar(sucursal_id, codinterno, txt_nrolote.Text, cb_proveedor.SelectedValue)
            If ds_lote.Tables(0).Rows.Count <> 0 Then
                'ya existe
                MessageBox.Show("Ya existen unidades en stock con Nº lote: " + txt_nrolote.Text + ". Modifique el Nº de lote.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_nrolote.Text = CInt(txt_nrolote.Text) + 1
            Else
                'lo puedo agregar
                If tb_Cant_Movi.Text <> "" Then
                    
                    Dim concepto As String
                    concepto = "Ajuste de Stock, Alta."
                    Dim tipo_mov As Integer = 4

                    Dim result As Integer = MessageBox.Show("¿Esta seguro que desea registrar el lote?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        Dim lote_id As Integer

                        'controlamos factura y remito
                        Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, Today, Inicio.USU_id, sucursal_id, sucursal_id, "", Today, "", Today, tipo_mov, cb_proveedor.SelectedValue, 0, 0)
                        ''''''''''''''''''''''''''''''''''''''''''''''''
                        Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
                        Dim i As Integer = 0


                        Dim Ds_Suc As DataSet
                        'Dim Origen As Integer
                        'Dim Destino As Integer
                        Dim Mov As Decimal
                        'Dim j As Integer = 0
                        'While i < Mov_DS.Tables("Mov").Rows.Count
                        ds_PROD = DAprod.Producto_buscarcod(codinterno)
                        Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                        Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id)


                        'Calculo Stock''''''''
                        Mov = CDec(Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino")) + CDec(tb_Cant_Movi.Text)
                        ''''''
                        Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(1).Rows(0).Item("prod_contenido")) * CDec(tb_Cant_Movi.Text)
                        'ahora sumo al stock real q ya existe.
                        Dim stock_real_nuevo As Decimal = CDec(Ds_Suc.Tables(1).Rows(0).Item("ProdxSuc_stock_real")) + stock_real_ingreso



                        ''''''''''
                        'Actualizo stock'''''
                        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, Mov, stock_real_nuevo)
                        '''''''''''



                        'si no existe doy de alta el lote
                        Dim fechafabricacion As Date
                        Dim fechavencimiento As Date
                        Dim Vence As String = ""
                        If CheckBox_vto.Checked = True Then
                            fechafabricacion = DateTimePicker_ffabricacion.Value.Date
                            fechavencimiento = DateTimePicker_fvencimiento.Value.Date
                            Vence = "si"
                        Else
                            fechafabricacion = Today
                            fechavencimiento = Today
                            Vence = "no"
                        End If
                        Dim ds_lotes As DataSet = DAlote.Producto_x_sucursal_lote_alta(txt_nrolote.Text,
                                                                                      tb_Cant_Movi.Text,
                                                                                      fechafabricacion,
                                                                                      fechavencimiento,
                                                                                      prod_id,
                                                                                      sucursal_id,
                                                                                      Vence, cb_proveedor.SelectedValue, stock_real_ingreso, CDec(0))
                        lote_id = ds_lotes.Tables(0).Rows(0).Item("lote_id")


                        '''''' Alta Tabla Detalle'''''' de movimiento claro está
                        'alta en tabla mercaderia_detalle_alta
                        DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(tb_Cant_Movi.Text, MovMer_id, codinterno, lote_id, 0, 0)



                        'como se borro algo recupero todos los lotes nuevamente
                        Producto_ajuste.recuperar_lotes()
                        'ademas vuelvo a calcular el total de stock para mostrar en el textbox "TOTAL DE UNIDADES:"
                        Producto_ajuste.calcular_total()
                        Producto_ajuste.cargar_modificacion_en_gridview() 'se reflejan los cambios en el gridview de producto_modificar
                        MessageBox.Show("los datos fueron actualizados Correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If


                    
                Else
                    MessageBox.Show("Debe ingresar la cantidad.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    tb_Cant_Movi.Focus()
                End If


            End If



        Else
            txt_nrolote.SelectAll()
            txt_nrolote.Focus()
            MessageBox.Show("Ingrese un Nº de lote.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



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

    Private Sub Ajuste_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_proveedores_del_producto()
        'recupero lotes e incremento en 1
        recuperar_lotes_e_incrementar()



    End Sub
    Private Sub recuperar_lotes_e_incrementar()
        txt_contenido.Text = Producto_ajuste.contenido_x_unidad.ToString + " " + Producto_ajuste.unidad_medida

        ds_PROD = DAprod.Producto_buscarcod_en_proveedor(codinterno, cb_proveedor.SelectedValue)
        If ds_PROD.Tables(0).Rows.Count <> 0 Then
            'tb_desc.Text = ds_PROD.Tables(0).Rows(0).Item("prod_descripcion")
            'Buscar_Cantidades(ds_PROD.Tables(0).Rows(0).Item("prod_id"), cb_origen.SelectedValue, cb_destino.SelectedValue)

            '//////////////////esto hago si el movimiento es alta de marcaderia///////////////////////////////////////////////

            'If Gestion_Mercaderia.cb_Movimiento.Text = "Alta de Mercaderia" Then
            'Grupo_lote.Enabled = True
            If ds_PROD.Tables(2).Rows.Count <> 0 Then 'recupera el producto solo si tiene Lote = "SI"
                'si es distinto de 0, significa que tiene lotes que se van a colocar incrementales, es decir NO
                Dim ds_lotes As DataSet = DAlote.Lote_buscar_producto(codinterno, sucursal_id)
                If ds_lotes.Tables(1).Rows.Count = 0 Then
                    'como no tengo lotes, creo el primer lote en 1
                    Dim nrolote_de_bd As Integer = 0
                    'ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                    'Dim i As Integer = 0
                    'While i < DataGridView1.Rows.Count
                    '    If DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = tb_codint.Text Then
                    '        nrolote_de_bd = CInt(DataGridView1.Rows(i).Cells("Lote").Value)
                    '    End If
                    '    i = i + 1
                    'End While
                    nrolote_de_bd = nrolote_de_bd + 1
                    txt_nrolote.Text = nrolote_de_bd
                Else
                    'como tengo varios lotes, busco el ultimo e incremento en 1.
                    Dim nrolote_de_bd As Integer = CInt(ds_lotes.Tables(1).Rows(ds_lotes.Tables(1).Rows.Count - 1).Item("lote_nro"))
                    ''ahora me fijo, si tengo algo en la grilla de productos agregados, incremento el nrolote.
                    'Dim i As Integer = 0
                    'While i < DataGridView1.Rows.Count
                    '    If DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value = tb_codint.Text Then
                    '        nrolote_de_bd = CInt(DataGridView1.Rows(i).Cells("Lote").Value)
                    '    End If
                    '    i = i + 1
                    'End While
                    nrolote_de_bd = nrolote_de_bd + 1
                    txt_nrolote.Text = nrolote_de_bd
                End If
                'txt_nrolote.ReadOnly=true
                'Label8.Text = "Ingreso Nº:"
            Else
                'txt_nrolote.Enabled = True
                ' Label8.Text = "Lote Nº:"
            End If
            'If
            '/////////////////////////////////////////////////////////////////////////////////////////////////////
        Else
            'MessageBox.Show("El producto no existe para el proveedor seleccionado.", "Sistema de Gestión.")
            'limpiar_seccion_agregar()
        End If
    End Sub


    Dim Validaciones As New Validaciones
    Private Sub tb_Cant_Movi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Cant_Movi.KeyPress
        If Producto_ajuste.tipo_producto = "Fraccionable" Then
            Dim tipo As String = "Decimal"
            Validaciones.Restricciones_textbox(e, tipo, tb_Cant_Movi)
        End If
        If Producto_ajuste.tipo_producto = "No Fraccionable" Then
            Dim tipo As String = "Entero"
            Validaciones.Restricciones_textbox(e, tipo, tb_Cant_Movi)
        End If
    End Sub

    Private Sub txt_nrolote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nrolote.KeyPress
        Validaciones.Restricciones_textbox(e, "Entero", txt_nrolote)
    End Sub
End Class