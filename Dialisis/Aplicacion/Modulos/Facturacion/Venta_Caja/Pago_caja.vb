
Public Class Pago_caja
    Dim DAventa As New Datos.Venta
    Dim DAproducto As New Datos.Producto
    Dim DAcaja As New Datos.Caja
    Dim DAcuentacorriente As New Datos.CuentaCorriente
    Public form_procedencia As String = ""
    Public Ser_id
    Public Monto_sin_anticipo 

    Private Sub remito_gen_factura()
        'esto es en venta
        If tx_parcial.Text = "" Then
            tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tx_parcial.Text = (Math.Round(CDec(tx_parcial.Text), 2).ToString("N2"))
        End If
        TextBox1.Text = CDec(tx_parcial.Text) - CDec(tx_total.Text)
        TextBox1.Text = (Math.Round(CDec(TextBox1.Text), 2).ToString("N2"))
        If TextBox1.Text < 0 Then
            TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If
        If CDec(tx_total.Text) = 0 Or CDec(tx_parcial.Text) = 0 Then
            MessageBox.Show("El monto total es incorrecto", "Sistema de Gestion.")

        Else
            'VALICACIONES
            If CDec(tx_parcial.Text) > CDec(tx_total.Text) Or CDec(tx_parcial.Text) = CDec(tx_total.Text) Then
                If Venta_Caja_gestion.DataGridView1.Rows.Count <> 0 Then 'es la grilla de los productos agregados
                    'If Venta_Caja_gestion.DataG_lista.Rows.Count <> 0 Then
                    'If RB_Cliente.Checked = True Then
                    '    If DG_clientes.CurrentRow.Cells(1).Value = True Then
                    'GUARDAR EN TABLA "Venta_Producto"///////////////////////////////////////////////////////////////////////////////////
                    Dim usuario_id As String
                    usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
                    Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
                    Dim sucursal_id As Integer = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
                    Dim tipo_vta As String = ""
                    Dim cliente_id As Integer
                    If Venta_Caja_gestion.RB_Consumidor.Checked = True Then
                        tipo_vta = "Consumidor Final"
                        cliente_id = 0
                    Else
                        tipo_vta = "Cliente"
                        cliente_id = Venta_Caja_gestion.remito_cliente_id
                    End If
                    Dim venta_tipo_descripcion As String = ""
                    If Venta_Caja_gestion.tipo_vta = "Minorista" Then
                        venta_tipo_descripcion = "Venta Minorista-Efectivo"
                    Else
                        venta_tipo_descripcion = "Venta Mayorista-Efectivo"
                    End If
                    '//////CHOCO: 03-12-2019 - se agrega el parametro de "Vendedor", en la tabla ventaproducto_alta////////////
                    'Dim vendedor_id As Integer = CInt(Venta_Caja_gestion.ComboBox_vendedor.SelectedValue)
                    Dim ds_Venta As DataSet = DAventa.Factura_modificar_estado(Venta_Caja_gestion.remito_ventaprod_id, "Cobrado")
                    'Dim ventaprod_id As Integer = CInt(ds_Venta.Tables(0).Rows(0).Item("ventaprod_id"))

                    '/////////////////choco: 04-12-2019 - genero la factura en su correspondiente tabla///////////////////
                    Dim ds_factura As DataSet = DAventa.Factura_alta(Venta_Caja_gestion.remito_ventaprod_id, Now)
                    Dim factura_id As Integer = ds_factura.Tables(0).Rows(0).Item("factura_id")
                    DAventa.remito_modificar_estado(Venta_Caja_gestion.remito_id, "Facturado")


                    'DAcaja.Caja_Actualizar(CDec(tx_total.Text), Inicio.USU_id)
                    Dim descripcion As String = "Factura Nº" + CStr(factura_id)
                    'OK
                    'DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(tx_total.Text), CDec(0), 1, CDec(0), CDec(tx_total.Text), Now, Inicio.terminal_id, US_administrador.TurnoUsuario_id) '1 es venta

                    '////////////choco 17-12-2019///////////////////////
                    DAcaja.Caja_Actualizar3(Inicio.CAJA_id, Inicio.terminal_id, US_administrador.TurnoUsuario_id, descripcion, CDec(tx_total.Text), CDec(0), 1, CDec(0), CDec(tx_total.Text), Now) '1 es venta
                    '/////////fin/////////////


                    'aqui llamo a la rutina que me muestra el reporte.
                    crear_reporte(ds_usuario, factura_id)
                    MessageBox.Show("La venta fue registrada correctamente.", "Sistema de Gestion.")
                    Venta_Caja_gestion.Close()

                    'Dim ruta As String
                    'ruta = Application.StartupPath & "\..\..\Sonido\Gallega actualizada.wav"
                    'My.Computer.Audio.Play(ruta, AudioPlayMode.Background)
                    Me.Close()

                    'Else
                    '    MessageBox.Show("Error, seleccione cliente", "Sistema de Gestion.")
                    'End If
                    '    End If
                Else
                    MessageBox.Show("Error, No hay productos agregados", "Sistema de Gestión")
                End If

            Else
                MessageBox.Show("Error! El monto ingresado es menor al total, por favor modifique", "Sistema de Gestion", MessageBoxButtons.OK)
                tx_parcial.Focus()
                tx_parcial.SelectAll()
            End If


        End If


    End Sub


    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click
        If Venta_Caja_gestion.procedencia = "Remito modificar" Then
            remito_gen_factura()
        Else
            If form_procedencia = "Servicio_nuevo" Then

                If tx_parcial.Text = "" Then
                    tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))
                Else
                    tx_parcial.Text = (Math.Round(CDec(tx_parcial.Text), 2).ToString("N2"))
                End If
                TextBox1.Text = CDec(tx_parcial.Text) - CDec(tx_total.Text)
                TextBox1.Text = (Math.Round(CDec(TextBox1.Text), 2).ToString("N2"))
                If TextBox1.Text < 0 Then
                    TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
                End If



                If CDec(tx_total.Text) = 0 Or CDec(tx_parcial.Text) = 0 Then
                    MessageBox.Show("El monto total es incorrecto", "Sistema de Gestión.")
                Else
                    If CDec(tx_parcial.Text) > CDec(tx_total.Text) Or CDec(tx_parcial.Text) = CDec(tx_total.Text) Then
                        'GUARDAR EN TABLA "Venta_Producto"///////////////////////////////////////////////////////////////////////////////////
                        Dim usuario_id As String
                        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
                        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
                        Dim sucursal_id As Integer = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
                        Dim tipo_vta As String = ""
                        Dim cliente_id As Integer
                        Dim venta_tipo_descripcion As String = ""
                        tipo_vta = "Consumidor Final"
                        cliente_id = 0
                        venta_tipo_descripcion = "Servicio"
                        Dim vendedor_id As Integer = 0 'OJO HAY Q VER QUE VENDEDOR ASIGNO, O SI SE PUEDE CREAR EN LA TABLA VENDEDOR UN REGISTRO QUE DIGA ...DEFECTO, SI NO SE POSEE VENDEDOR
                        Dim ds_Venta As DataSet = DAventa.VentaProducto_alta(Monto_sin_anticipo, Now, usuario_id, tipo_vta, cliente_id, 0, 0, 0, 0, 0, venta_tipo_descripcion, Ser_id, vendedor_id, "Cobrado")
                        Dim descripcion As String = "Servicio Nº" + CStr(Ser_id)
                        'OK
                        DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(tx_total.Text), CDec(0), 1, CDec(0), CDec(tx_total.Text), Now, Inicio.terminal_id, US_administrador.TurnoUsuario_id) '1 es efectivo
                        'DAcaja.Caja_Actualizar(CDec(tx_total.Text), Inicio.USU_id)
                        Servicio_nuevo.finalizar("form_pago_caja")
                        Me.Close()
                    Else
                        MessageBox.Show("Error! El monto ingresado es menor al total, por favor modifique", "Sistema de Gestion", MessageBoxButtons.OK)
                        tx_parcial.Focus()
                        tx_parcial.SelectAll()
                    End If
                End If
            Else
                'esto es en venta
                If tx_parcial.Text = "" Then
                    tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))
                Else
                    tx_parcial.Text = (Math.Round(CDec(tx_parcial.Text), 2).ToString("N2"))
                End If
                TextBox1.Text = CDec(tx_parcial.Text) - CDec(tx_total.Text)
                TextBox1.Text = (Math.Round(CDec(TextBox1.Text), 2).ToString("N2"))
                If TextBox1.Text < 0 Then
                    TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
                End If
                If CDec(tx_total.Text) = 0 Or CDec(tx_parcial.Text) = 0 Then
                    MessageBox.Show("El monto total es incorrecto", "Sistema de Gestion.")
                Else
                    'VALICACIONES
                    If CDec(tx_parcial.Text) > CDec(tx_total.Text) Or CDec(tx_parcial.Text) = CDec(tx_total.Text) Then
                        If Venta_Caja_gestion.DataGridView1.Rows.Count <> 0 Then 'es la grilla de los productos agregados
                            'If Venta_Caja_gestion.DataG_lista.Rows.Count <> 0 Then
                            'If RB_Cliente.Checked = True Then
                            '    If DG_clientes.CurrentRow.Cells(1).Value = True Then
                            'GUARDAR EN TABLA "Venta_Producto"///////////////////////////////////////////////////////////////////////////////////
                            Dim usuario_id As String
                            usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
                            Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
                            Dim sucursal_id As Integer = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
                            Dim tipo_vta As String = ""
                            Dim cliente_id As Integer
                            If Venta_Caja_gestion.RB_Consumidor.Checked = True Then
                                tipo_vta = "Consumidor Final"
                                cliente_id = 0
                            Else
                                tipo_vta = "Cliente"
                                cliente_id = Venta_Caja_gestion.DG_clientes.CurrentRow.Cells(0).Value
                            End If
                            Dim venta_tipo_descripcion As String = ""
                            If Venta_Caja_gestion.tipo_vta = "Minorista" Then
                                venta_tipo_descripcion = "Venta Minorista-Efectivo"
                            Else
                                venta_tipo_descripcion = "Venta Mayorista-Efectivo"
                            End If
                            '//////CHOCO: 03-12-2019 - se agrega el parametro de "Vendedor", en la tabla ventaproducto_alta////////////
                            Dim vendedor_id As Integer = CInt(Venta_Caja_gestion.ComboBox_vendedor.SelectedValue)
                            Dim ds_Venta As DataSet = DAventa.VentaProducto_alta(CDec(tx_total.Text),
                                                             Now,
                                                             usuario_id,
                                                             tipo_vta,
                                                             cliente_id, CDec(Venta_Caja_gestion.txt_subtotal.Text),
                                                             CDec(Venta_Caja_gestion.txt_descuento.Text),
                                                             CDec(Venta_Caja_gestion.txt_desc_porc.Text),
                                                             CDec(Venta_Caja_gestion.ComboBox_iva.SelectedItem),
                                                              CDec(Venta_Caja_gestion.txt_impuesto_aplicado.Text), venta_tipo_descripcion, 0, vendedor_id, "Cobrado")
                            Dim ventaprod_id As Integer = CInt(ds_Venta.Tables(0).Rows(0).Item("ventaprod_id"))
                            '/////////////////choco: 04-12-2019 - genero la factura en su correspondiente tabla///////////////////
                            Dim ds_factura As DataSet = DAventa.Factura_alta(ventaprod_id, Now)
                            Dim factura_id As Integer = ds_factura.Tables(0).Rows(0).Item("factura_id")
                            '////////////////aqui cargamos en cuenta corriente, si corresponde - CHOCO: 03-12-2019//////////////////
                            '///////////lo comento, x q si es pago en efectivo, no se registra en la tabla cuenta corriente//////////
                            'Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(cliente_id)
                            'If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                            '    'tiene cuenta y va a pagar en efectivo.
                            '    Dim CtaCte_id As Integer = ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_id")
                            '    DAcuentacorriente.Venta_CtaCte_alta(ventaprod_id, CtaCte_id)
                            '    Dim concepto As String = "Cobro comprobante Nº: " + CStr(ventaprod_id)
                            '    DAcuentacorriente.CtaCte_movimiento_alta(CtaCte_id, "Ingreso", concepto, CDec(tx_total.Text), Now)
                            'End If
                            '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            'GUARDAR EN TABLA "Venta_Producto_detalle"
                            For Each row As DataGridViewRow In Venta_Caja_gestion.DataGridView1.Rows
                                If row.Cells("columna_prod_id").Value <> 0 Then
                                    DAventa.VentaProductoDetalle_alta(ventaprod_id, row.Cells(1).Value, row.Cells(5).Value, CDec(row.Cells(7).Value), CDec(row.Cells(8).Value), row.Cells(3).Value, row.Cells(2).Value, 0, CDec(row.Cells(6).Value))
                                End If
                            Next

                            'DAcaja.Caja_Actualizar(CDec(tx_total.Text), Inicio.USU_id)
                            Dim descripcion As String = "Factura Nº" + CStr(factura_id)
                            'OK


                            'DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(tx_total.Text), CDec(0), 1, CDec(0), CDec(tx_total.Text), Now, Inicio.terminal_id, US_administrador.TurnoUsuario_id) '1 es venta

                            '////choco 17-12-2019  aqui lo que hacemos es que registre en caja siempre con el responsable, a pesar de que podemos ingresar con otro usuario, del tipo admin////////////////
                            DAcaja.Caja_Actualizar3(Inicio.CAJA_id, Inicio.terminal_id, US_administrador.TurnoUsuario_id, descripcion, CDec(tx_total.Text), CDec(0), 1, CDec(0), CDec(tx_total.Text), Now)
                            '//////////choco fin//////////////////

                            'aqui hago el descuento de stock...
                            'primero de los productos ....luego de los combos...(ya q estan formados por varios productos)

                            Dim i As Integer = 0
                            Dim ds_stock As New DataSet
                            While i < Venta_Caja_gestion.DataGridView1.Rows.Count
                                Dim prod_codigo As Integer = 0
                                If Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_codinterno").Value <> "0" Then
                                    prod_codigo = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_codinterno").Value)
                                End If
                                ds_stock = DAproducto.Producto_x_sucursal_buscarcod(prod_codigo, sucursal_id)
                                If ds_stock.Tables(0).Rows.Count <> 0 Then
                                    Dim diferencia As Decimal = CDec(ds_stock.Tables(0).Rows(0).Item("ProdxSuc_stock")) - CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                                    If diferencia < 0 Then
                                        diferencia = 0
                                    End If

                                    Dim diferencia_gondola As Integer = 0
                                    Dim cantidad As Integer = 0
                                    'If ds_stock.Tables(1).Rows.Count <> 0 Then
                                    '    If IsDBNull(ds_stock.Tables(1).Rows(0).Item("prod_gondola")) Then
                                    '    Else
                                    '        cantidad = ds_stock.Tables(1).Rows(0).Item("prod_gondola")
                                    '    End If
                                    '    diferencia_gondola = CInt(cantidad) - CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                                    'End If
                                    DAventa.Venta_actualizar_stock_Caja(prod_codigo, diferencia, diferencia_gondola, sucursal_id)
                                    'MsgBox("actualizo stock de", prod_codigo)

                                Else 'si no lo encuentra significa q es un combo o bien una promocion...asi que tengo q actualizar el stock de varios
                                    If Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value <> "0" Then
                                        'primero lo busco como combo.

                                        'aqui veo si ponerle el indice _tabla en 2 o 3...dependiendo del procedimiento q tome los recursos el DS_PROD...
                                        'son 2 las rutinas....Venta_obtenerProducto_listaregular y [Venta_obtenerProducto_Combos]
                                        Dim indice_tabla As Integer = 0
                                        If Venta_Caja_gestion.RB_Si.Checked = False Then
                                            indice_tabla = 3
                                        Else
                                            indice_tabla = 2
                                        End If
                                        'id del combo
                                        Dim ProdCombo_id As Integer = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_codinterno").Value)
                                        Dim cantidad_combos As Integer = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                                        Dim j As Integer = 0
                                        While j < Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows.Count
                                            If ProdCombo_id = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdCombo_id") Then
                                                Dim prod_id As Integer = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("prod_id")
                                                Dim cantidad_item As Integer = CInt(Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdComboDet_cantidad"))
                                                ds_stock = DAproducto.Producto_buscar_id(prod_id)

                                                Dim cantidad_total As Integer = CInt(cantidad_combos * cantidad_item)

                                                Dim diferencia As Integer = CInt(ds_stock.Tables(0).Rows(0).Item("prod_stock")) - cantidad_total


                                                Dim diferencia_gondola As Integer = 0
                                                Dim cantidad As Integer = 0
                                                If ds_stock.Tables(1).Rows.Count <> 0 Then
                                                    If IsDBNull(ds_stock.Tables(1).Rows(0).Item("prod_gondola")) Then
                                                    Else
                                                        cantidad = ds_stock.Tables(1).Rows(0).Item("prod_gondola")
                                                    End If
                                                    diferencia_gondola = CInt(cantidad) - cantidad_total
                                                End If

                                                DAventa.Venta_actualizar_stock_Caja_2(prod_id, diferencia, diferencia_gondola)
                                                'MsgBox("actualizo stock de combo", prod_codigo)
                                            End If
                                            j = j + 1
                                        End While
                                    Else
                                        'aqui llamo a la rutina ACTUALIZAR STOCK DE PROMOCION
                                        Dim LISTA_codinterno As String = (Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_prod_id").Value)
                                        Dim cantidad_PROMOS As Integer = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                                        Dim LISTA_ID As Integer = 0

                                        'Busco el id de la promocion en el ds_promo
                                        Dim ii As Integer = 0
                                        While ii < Venta_Caja_gestion.VentaGestion_ds_PROMO.Tables(0).Rows.Count
                                            If LISTA_codinterno = Venta_Caja_gestion.VentaGestion_ds_PROMO.Tables(0).Rows(ii).Item("LISTA_codinterno") Then
                                                LISTA_ID = Venta_Caja_gestion.VentaGestion_ds_PROMO.Tables(0).Rows(ii).Item("LISTA_id")
                                            End If
                                            ii = ii + 1
                                        End While
                                        Venta_Caja_gestion.Actualizar_Stock_Promocion(LISTA_ID, cantidad_PROMOS)

                                    End If
                                End If
                                i = i + 1
                            End While
                            'aqui llamo a la rutina que me muestra el reporte.
                            crear_reporte(ds_usuario, factura_id)
                            MessageBox.Show("La venta fue registrada correctamente.", "Sistema de Gestion.")
                            Venta_Caja_gestion.Limpiar()

                            'Dim ruta As String
                            'ruta = Application.StartupPath & "\..\..\Sonido\Gallega actualizada.wav"
                            'My.Computer.Audio.Play(ruta, AudioPlayMode.Background)
                            Me.Close()

                            'Else
                            '    MessageBox.Show("Error, seleccione cliente", "Sistema de Gestion.")
                            'End If
                            '    End If
                        Else
                            MessageBox.Show("Error, No hay productos agregados", "Sistema de Gestión")
                        End If

                    Else
                        MessageBox.Show("Error! El monto ingresado es menor al total, por favor modifique", "Sistema de Gestion", MessageBoxButtons.OK)
                        tx_parcial.Focus()
                        tx_parcial.SelectAll()
                    End If


                End If
            End If
        End If

    End Sub
    Dim DAcliente As New Datos.Cliente
    Dim facturacion_ds_report As New Facturacion_ds_report
    Private Sub crear_reporte(ByVal ds_usuario As DataSet, ByVal numerofactura As Integer)
        'pregunto si quiero ver el reporte 
        'Dim result As DialogResult
        'result = MessageBox.Show("¿Desea ver el comprobante de pago?", "Sistema de Gestión", MessageBoxButtons.OKCancel)
        'If result = DialogResult.OK Then
        'primero lleno el dataset y sus respectivas table

        '///////////////TABLA CLIENTE//////////////////////////////////'
        facturacion_ds_report.Tables("Cliente").Rows.Clear()
        If Venta_Caja_gestion.lb_dni_clie.Text <> "- - - -" Then

            Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni((Venta_Caja_gestion.lb_dni_clie.Text))
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
            row_cliente("fantasia") = Venta_Caja_gestion.lb_fantasia.Text
            row_cliente("dni") = Venta_Caja_gestion.lb_dni_clie.Text
            row_cliente("telefono") = Venta_Caja_gestion.lb_telef_clie.Text
            row_cliente("mail") = Venta_Caja_gestion.lb_mail_clie.Text
            row_cliente("direccion") = ds_cliente.Tables(1).Rows(0).Item("CLI_dir")
            row_cliente("localidad") = ds_cliente.Tables(1).Rows(0).Item("provincia") + ", " + ds_cliente.Tables(1).Rows(0).Item("Localidad")
            row_cliente("iva_condicion") = ds_cliente.Tables(1).Rows(0).Item("IVA_descripcion").ToString
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        Else
            'Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni(CInt(Venta_Caja_gestion.lb_dni_clie.Text))
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
            row_cliente("fantasia") = "" 'Venta_Caja_gestion.lb_fantasia.Text
            row_cliente("dni") = "" 'Venta_Caja_gestion.lb_dni_clie.Text
            row_cliente("telefono") = "" 'Venta_Caja_gestion.lb_telef_clie.Text
            row_cliente("mail") = Venta_Caja_gestion.lb_mail_clie.Text
            row_cliente("direccion") = ""
            row_cliente("localidad") = ""
            row_cliente("iva_condicion") = "Consumidor Final"
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        End If

        'Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni(CInt(Venta_Caja_gestion.lb_dni_clie.Text))
        'Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
        'row_cliente("fantasia") = Venta_Caja_gestion.lb_fantasia.Text
        'row_cliente("dni") = Venta_Caja_gestion.lb_dni_clie.Text
        'row_cliente("telefono") = Venta_Caja_gestion.lb_telef_clie.Text
        'row_cliente("mail") = Venta_Caja_gestion.lb_mail_clie.Text
        'row_cliente("direccion") = ds_cliente.Tables(1).Rows(0).Item("CLI_dir")
        'row_cliente("localidad") = ds_cliente.Tables(1).Rows(0).Item("provincia") + ", " + ds_cliente.Tables(1).Rows(0).Item("Localidad")
        'facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)

        '///////////////TABLA SUCURSAL//////////////////////////////////'
        facturacion_ds_report.Tables("Sucursal").Rows.Clear()
        Dim row_sucursal As DataRow = facturacion_ds_report.Tables("Sucursal").NewRow()
        row_sucursal("sucursal") = Venta_Caja_gestion.lb_nombre_sucursal.Text
        row_sucursal("direccion") = Venta_Caja_gestion.lb_direccion_sucursal.Text
        row_sucursal("telefono") = Venta_Caja_gestion.lb_telefono_sucursal.Text
        row_sucursal("mail") = Venta_Caja_gestion.lb_mail_sucursal.Text
        row_sucursal("cuit") = "20 - 00000000 - 4"
        facturacion_ds_report.Tables("Sucursal").Rows.Add(row_sucursal)

        '///////////////TABLA EMPRESA//////////////////////////////////'
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            facturacion_ds_report.Tables("Empresa").Rows.Clear()
            facturacion_ds_report.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If

        '///////////////TABLA VENTA//////////////////////////////////'
        facturacion_ds_report.Tables("venta").Rows.Clear()
        Dim row_venta As DataRow = facturacion_ds_report.Tables("venta").NewRow()
        'row_venta("nro_factura") = Venta_Caja_gestion.lb_factura_vta.Text
        'row_venta("nro_factura") = ventaprod_id
        row_venta("nro_factura") = CInt(numerofactura)
        row_venta("fecha") = Today 'CDate(Venta_Caja_gestion.lb_fecha_vta.Text)
        row_venta("vendedor") = Venta_Caja_gestion.lb_vendedor_vta.Text

        Dim tipo_vta As String = ""
        If Venta_Caja_gestion.RB_Consumidor.Checked = True Then
            tipo_vta = "Consumidor Final"
        Else
            tipo_vta = "Cliente"
        End If
        row_venta("tipo_venta") = tipo_vta
        facturacion_ds_report.Tables("venta").Rows.Add(row_venta)

        '///////////////TABLA TOTALES APLICADOS//////////////////////////////////'
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Clear()
        Dim row_totales As DataRow = facturacion_ds_report.Tables("Totales_aplicados").NewRow()
        row_totales("subtotal") = Venta_Caja_gestion.txt_subtotal.Text
        row_totales("total") = Venta_Caja_gestion.txt_total.Text
        row_totales("iva") = CDec(Venta_Caja_gestion.ComboBox_iva.SelectedItem)
        row_totales("descuento_porcentaje") = CDec(Venta_Caja_gestion.txt_desc_porc.Text)
        row_totales("descuento_pesos") = CDec(Venta_Caja_gestion.txt_desc_pesos.Text)
        row_totales("iva_pesos") = CDec(Venta_Caja_gestion.txt_impuesto_aplicado.Text)
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)

        '///////////////TABLA PRODUCTO AGREGADO//////////////////////////////////'
        'aqui ciclo en la grilla para ir agrendo los row a la tabla producto agregado
        facturacion_ds_report.Tables("Producto_agregado").Rows.Clear()
        Dim i As Integer = 0
        While i < Venta_Caja_gestion.DataGridView1.Rows.Count
            If Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_descripcion").Value <> "" Then
                Dim row_prodADD As DataRow = facturacion_ds_report.Tables("Producto_agregado").NewRow()
                row_prodADD("PROD_id") = Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_prod_id").Value
                row_prodADD("codinterno") = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_codinterno").Value)
                row_prodADD("descripcion") = Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_descripcion").Value
                row_prodADD("detalle") = Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_detalle").Value
                row_prodADD("cantidad") = CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                row_prodADD("precio_unitario") = CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_precio_unitario").Value)
                row_prodADD("precio_subtotal") = CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_precio_subtotal").Value)
                row_prodADD("codbarra") = ""
                row_prodADD("TURNO_id") = ""
                '/choco modificacion 01-12-2019: agrego columna descuento
                row_prodADD("descuento") = CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("descuento").Value)
                row_prodADD("grupo_id") = CInt(1)
                facturacion_ds_report.Tables("Producto_agregado").Rows.Add(row_prodADD)
            End If
            i = i + 1
        End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Facturacion\Reportes\CR_comprobante.rpt")
        CrReport.Database.Tables("Cliente").SetDataSource(facturacion_ds_report.Tables("Cliente"))
        CrReport.Database.Tables("Sucursal").SetDataSource(facturacion_ds_report.Tables("Sucursal"))
        CrReport.Database.Tables("Empresa").SetDataSource(facturacion_ds_report.Tables("Empresa"))
        CrReport.Database.Tables("venta").SetDataSource(facturacion_ds_report.Tables("venta"))
        CrReport.Database.Tables("Producto_agregado").SetDataSource(facturacion_ds_report.Tables("Producto_agregado"))
        CrReport.Database.Tables("Totales_aplicados").SetDataSource(facturacion_ds_report.Tables("Totales_aplicados"))
        Facturacion_report_show.CrystalReportViewer1.ReportSource = CrReport
        Facturacion_report_show.Text = "Comprobante Nº: " + CStr(numerofactura) + " - Imprimir."
        Facturacion_report_show.Show()
        'End If
    End Sub

    Private Sub Pago_caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'tx_parcial.MaxLength = 12
    End Sub

    Private Sub tx_parcial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_parcial.KeyPress
        'si toco asterisco me toma el total
        If e.KeyChar.ToString = "*" Then
            tx_parcial.Text = tx_total.Text
        End If

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
                If e.KeyChar = "," And Not Me.tx_parcial.Text.IndexOf(",") Then
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

        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            If tx_parcial.Text = "" Then
                tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))


            End If
            TextBox1.Text = CDec(tx_parcial.Text) - CDec(tx_total.Text)
            TextBox1.Text = (Math.Round(CDec(TextBox1.Text), 2).ToString("N2"))
            If TextBox1.Text < 0 Then
                TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
        End If

    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Me.Close()
    End Sub

    Private Sub tx_parcial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx_parcial.TextChanged

    End Sub
End Class