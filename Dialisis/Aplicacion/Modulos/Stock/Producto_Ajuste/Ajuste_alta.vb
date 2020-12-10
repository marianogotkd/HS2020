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
                        Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, Today, Inicio.USU_id, sucursal_id, sucursal_id, "", Today, "", Today, tipo_mov, cb_proveedor.SelectedValue)
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
                        ''''''''''
                        'Actualizo stock'''''
                        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, Mov)
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
                                                                                      Vence, cb_proveedor.SelectedValue)
                        lote_id = ds_lotes.Tables(0).Rows(0).Item("lote_id")


                        '''''' Alta Tabla Detalle'''''' de movimiento claro está
                        'alta en tabla mercaderia_detalle_alta
                        DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(tb_Cant_Movi.Text, MovMer_id, codinterno, lote_id, 0, 0)



                        'como se borro algo recupero todos los lotes nuevamente
                        Producto_ajuste.recuperar_lotes()
                        'ademas vuelvo a calcular el total de stock para mostrar en el textbox "TOTAL DE UNIDADES:"
                        Producto_ajuste.calcular_total()
                        MessageBox.Show("Eliminación correcta, los datos fueron actualizados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    End Sub
    Dim Validaciones As New Validaciones
    Private Sub tb_Cant_Movi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Cant_Movi.KeyPress
        Dim tipo As String = "Entero"
        Validaciones.Restricciones_textbox(e, tipo, tb_Cant_Movi)
    End Sub
End Class