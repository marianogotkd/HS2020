Public Class Mesa_nueva
    Dim DAventa As New Datos.Venta
    Dim DAproducto As New Datos.Producto
    Dim DAcaja As New Datos.Caja

    Public mesa_id As Integer = 0
    Public sector_id As Integer = 0
    Public Label_mesa As String = ""
    Public form_procedencia As String

    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click
        If CDec(tx_parcial.Text) <> CDec(0) Then
            If tx_parcial.Text = "" Then
                tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
            TextBox1.Text = CDec(tx_parcial.Text) - CDec(tx_total.Text)
            TextBox1.Text = (Math.Round(CDec(TextBox1.Text), 2).ToString("N2"))
            If TextBox1.Text < 0 Then
                TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If

            If CDec(tx_total.Text) = 0 Then
                'MessageBox.Show("El monto total es incorrecto", "Sistema de Gestion.")
                'poner la mesa en estado cobrado y llamar las rutinas para cambiar color a las cajas
                Dim ventaprod_id As Integer = Mesa_cargar.Ventaprod_id
                DAventa.VentaProducto_modificar_mesa(ventaprod_id, CDec(Mesa_cargar.DataG_listaTotal.Rows(0).Cells(1).Value), CDec(Mesa_cargar.DataG_listaTotal.Rows(0).Cells(1).Value), "Cobrado")
                DAventa.MESAS_modificar(Mesa_cargar.mesa_id, Mesa_cargar.Label_mesa.Text, "Cobrado", "Si", ventaprod_id)


                'DAcaja.Caja_Actualizar(CDec(Mesa_cargar.DataG_listaTotal.Rows(0).Cells(1).Value), Inicio.USU_id)

                Dim i As Integer = 0
                Dim ds_stock As New DataSet
                While i < Mesa_cargar.DataG_lista.Rows.Count
                    Dim prod_codigo As Integer = 0
                    If Mesa_cargar.DataG_lista.Rows(i).Cells("PRODidDataGridViewTextBoxColumn").Value <> "0" Then
                        prod_codigo = CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CodinternoDataGridViewTextBoxColumn").Value)
                    End If
                    ds_stock = DAproducto.Producto_buscarcod(prod_codigo)
                    If ds_stock.Tables(0).Rows.Count <> 0 Then
                        Dim diferencia As Integer = CInt(ds_stock.Tables(0).Rows(0).Item("prod_stock")) - CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)

                        Dim diferencia_gondola As Integer = 0
                        Dim cantidad As Integer = 0
                        If ds_stock.Tables(1).Rows.Count <> 0 Then
                            If IsDBNull(ds_stock.Tables(1).Rows(0).Item("prod_gondola")) Then

                            Else
                                cantidad = ds_stock.Tables(1).Rows(0).Item("prod_gondola")
                            End If

                            diferencia_gondola = CInt(cantidad) - CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                        End If





                        DAventa.Venta_actualizar_stock_Caja(prod_codigo, diferencia, diferencia_gondola, 0)
                        'MsgBox("actualizo stock de", prod_codigo)

                    Else 'si no lo encuentra significa q es un combo o bien una promocion...asi que tengo q actualizar el stock de varios
                        If Mesa_cargar.DataG_lista.Rows(i).Cells("PRODidDataGridViewTextBoxColumn").Value <> "0" Then
                            'primero lo busco como combo.

                            'aqui veo si ponerle el indice _tabla en 2 o 3...dependiendo del procedimiento q tome los recursos el DS_PROD...
                            'son 2 las rutinas....Venta_obtenerProducto_listaregular y [Venta_obtenerProducto_Combos]
                            Dim indice_tabla As Integer = 0
                            If Mesa_cargar.RB_Si = False Then
                                indice_tabla = 3
                            Else
                                indice_tabla = 2
                            End If
                            'id del combo
                            Dim ProdCombo_id As Integer = CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("PRODidDataGridViewTextBoxColumn").Value)
                            Dim cantidad_combos As Integer = CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                            Dim j As Integer = 0
                            While j < Mesa_cargar.DS_PROD.Tables(indice_tabla).Rows.Count
                                If ProdCombo_id = Mesa_cargar.DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdCombo_id") Then
                                    Dim prod_id As Integer = Mesa_cargar.DS_PROD.Tables(indice_tabla).Rows(j).Item("prod_id")
                                    Dim cantidad_item As Integer = CInt(Mesa_cargar.DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdComboDet_cantidad"))
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
                            Dim LISTA_codinterno As String = (Mesa_cargar.DataG_lista.Rows(i).Cells("CodinternoDataGridViewTextBoxColumn").Value)
                            Dim cantidad_PROMOS As Integer = CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                            Dim LISTA_ID As Integer = 0

                            'Busco el id de la promocion en el ds_promo
                            Dim ii As Integer = 0
                            While ii < Mesa_cargar.ds_PROMO.Tables(0).Rows.Count
                                If LISTA_codinterno = Mesa_cargar.ds_PROMO.Tables(0).Rows(ii).Item("LISTA_codinterno") Then
                                    LISTA_ID = Mesa_cargar.ds_PROMO.Tables(0).Rows(ii).Item("LISTA_id")
                                End If
                                ii = ii + 1
                            End While


                            Call Mesas_gestion.Actualizar_Stock_Promocion(LISTA_ID, cantidad_PROMOS)



                        End If
                    End If
                    i = i + 1
                End While
                MessageBox.Show("La venta fue registrada correctamente.", "Sistema de Gestion.")
                Mesas_gestion_2_new.recuperar_mesas()


                If form_procedencia = "Mesas_gestion_2_new" Then

                    'aqui va una rutina para habilitar la mesa cobrada...es una rutina de este form ya q se entra a traves del form mesas_consulta_gestion
                    Habilitar_mesas_cobradas(sector_id, Label_mesa)
                Else
                    Mesas_gestion_2_new.Habilitar_mesa_cobrada() 'este habilita si entro desde el menu contextual de las mesas, ya q no se pierde el valor de asign_pendiente
                End If

                Mesa_cargar.Close()
                Ver_promocion.Close()
                Busqueda_Productos.Close()

                Me.Close()


            Else
                'VALICACIONES
                If Mesa_cargar.DataG_lista.Rows.Count <> 0 Then
                    'If RB_Cliente.Checked = True Then
                    '    If DG_clientes.CurrentRow.Cells(1).Value = True Then
                    'GUARDAR EN TABLA "Venta_Producto"///////////////////////////////////////////////////////////////////////////////////
                    Dim usuario_id As String
                    usuario_id = US_administrador.USU_id 'obtengo del formulario principal el id del usuario actual
                    Dim tipo_vta As String = Mesa_cargar.tipo_vta
                    Dim cliente_id As Integer = Mesa_cargar.cliente_id

                    If tx_parcial.Text = "" Then
                        tx_parcial.Text = CDec(0)
                    End If
                    Dim pago_parcial As Decimal = CDec(tx_parcial.Text) + CDec(Mesa_cargar.pago_parcial)
                    Dim estado As String = ""


                    If CDec(tx_parcial.Text) >= CDec(tx_total.Text) Then
                        estado = "Cobrado"
                        If CDec(pago_parcial) > CDec(tx_total.Text) Then
                            pago_parcial = CDec(Mesa_cargar.DataG_listaTotal.Rows(0).Cells(1).Value)
                        End If
                    Else
                        estado = "Ocupado"
                    End If





                    If pago_parcial >= CDec(tx_total.Text) Then
                        estado = "Cobrado"
                        If CDec(pago_parcial) > CDec(tx_total.Text) Then
                            pago_parcial = CDec(Mesa_cargar.DataG_listaTotal.Rows(0).Cells(1).Value)
                        End If
                    Else
                        estado = "Ocupado"
                    End If
                    Dim ventaprod_id As Integer = Mesa_cargar.Ventaprod_id

                    Dim total As Decimal = CDec(Mesa_cargar.DataG_listaTotal.Rows(0).Cells(1).Value)


                    If estado = "Cobrado" Then
                        If MsgBox("¿Quiere cerrar la mesa?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                            DAventa.VentaProducto_modificar_mesa(ventaprod_id, total, pago_parcial, estado)
                            DAventa.MESAS_modificar(Mesa_cargar.mesa_id, Mesa_cargar.Label_mesa.Text, estado, "Si", ventaprod_id)
                        Else
                            'si no deseo lo dejo como ocupado
                            estado = "Ocupado"
                            DAventa.VentaProducto_modificar_mesa(ventaprod_id, total, pago_parcial, "Ocupado")
                            DAventa.MESAS_modificar(Mesa_cargar.mesa_id, Mesa_cargar.Label_mesa.Text, "Ocupado", "Si", ventaprod_id)
                        End If
                    Else
                        DAventa.VentaProducto_modificar_mesa(ventaprod_id, total, pago_parcial, estado)
                        DAventa.MESAS_modificar(Mesa_cargar.mesa_id, Mesa_cargar.Label_mesa.Text, estado, "Si", ventaprod_id)
                    End If



                    'Dim ventaprod_id As Integer = CInt(Mesas_gestion.DataGridView1.CurrentRow.Cells("VentaprodidDataGridViewTextBoxColumn").Value)

                    'primero borro los item de la tabla detalle venta
                    DAventa.VentaProductoDetalle_borrar(ventaprod_id)
                    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    'GUARDAR EN TABLA "Venta_Producto_detalle"
                    For Each row As DataGridViewRow In Mesa_cargar.DataG_lista.Rows
                        DAventa.VentaProductoDetalle_alta(ventaprod_id, row.Cells(1).Value, row.Cells(5).Value, CDec(row.Cells(6).Value), CDec(row.Cells(7).Value), row.Cells(3).Value, row.Cells(2).Value, row.Cells(9).Value, CDec(0))
                    Next

                    'actualizo estado de mesa, y relaciono con venta


                    'DAventa.MESAS_modificar(Mesas_gestion.DataGridView1.CurrentRow.Cells("MESAidDataGridViewTextBoxColumn").Value, ventaprod_id, estado)

                    'aqui hago el descuento de stock...
                    'primero de los productos ....luego de los combos...(ya q estan formados por varios productos)

                    If CDec(tx_parcial.Text) > CDec(tx_total.Text) Then
                        DAcaja.Caja_Actualizar(CDec(tx_total.Text), Inicio.USU_id)
                    Else
                        If CDec(tx_parcial.Text) <= CDec(tx_total.Text) And CDec(tx_parcial.Text) <> CDec(0) Then
                            DAcaja.Caja_Actualizar(CDec(tx_parcial.Text), Inicio.USU_id)
                        End If
                    End If



                    If estado = "Cobrado" Then


                        Dim i As Integer = 0
                        Dim ds_stock As New DataSet
                        While i < Mesa_cargar.DataG_lista.Rows.Count
                            Dim prod_codigo As Integer = 0
                            If Mesa_cargar.DataG_lista.Rows(i).Cells("PRODidDataGridViewTextBoxColumn").Value <> "0" Then
                                prod_codigo = CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CodinternoDataGridViewTextBoxColumn").Value)
                            End If
                            ds_stock = DAproducto.Producto_buscarcod(prod_codigo)
                            If ds_stock.Tables(0).Rows.Count <> 0 Then
                                Dim diferencia As Integer = CInt(ds_stock.Tables(0).Rows(0).Item("prod_stock")) - CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)

                                Dim cantidad As Integer = 0
                                Dim diferencia_gondola As Integer = 0
                                If ds_stock.Tables(1).Rows.Count <> 0 Then
                                    If IsDBNull(ds_stock.Tables(1).Rows(0).Item("prod_gondola")) Then

                                    Else
                                        cantidad = ds_stock.Tables(1).Rows(0).Item("prod_gondola")
                                    End If

                                    diferencia_gondola = CInt(cantidad) - CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                                End If


                                DAventa.Venta_actualizar_stock_Caja(prod_codigo, diferencia, diferencia_gondola, 0)
                                'MsgBox("actualizo stock de", prod_codigo)

                            Else 'si no lo encuentra significa q es un combo o bien una promocion...asi que tengo q actualizar el stock de varios
                                If Mesa_cargar.DataG_lista.Rows(i).Cells("PRODidDataGridViewTextBoxColumn").Value <> "0" Then
                                    'primero lo busco como combo.

                                    'aqui veo si ponerle el indice _tabla en 2 o 3...dependiendo del procedimiento q tome los recursos el DS_PROD...
                                    'son 2 las rutinas....Venta_obtenerProducto_listaregular y [Venta_obtenerProducto_Combos]
                                    Dim indice_tabla As Integer = 0
                                    If Mesa_cargar.RB_Si = False Then
                                        indice_tabla = 3
                                    Else
                                        indice_tabla = 2
                                    End If
                                    'id del combo
                                    Dim ProdCombo_id As Integer = CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("PRODidDataGridViewTextBoxColumn").Value)
                                    Dim cantidad_combos As Integer = CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                                    Dim j As Integer = 0
                                    While j < Mesa_cargar.DS_PROD.Tables(indice_tabla).Rows.Count
                                        If ProdCombo_id = Mesa_cargar.DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdCombo_id") Then
                                            Dim prod_id As Integer = Mesa_cargar.DS_PROD.Tables(indice_tabla).Rows(j).Item("prod_id")
                                            Dim cantidad_item As Integer = CInt(Mesa_cargar.DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdComboDet_cantidad"))
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
                                    Dim LISTA_codinterno As String = (Mesa_cargar.DataG_lista.Rows(i).Cells("CodinternoDataGridViewTextBoxColumn").Value)
                                    Dim cantidad_PROMOS As Integer = CInt(Mesa_cargar.DataG_lista.Rows(i).Cells("CantidadDataGridViewTextBoxColumn").Value)
                                    Dim LISTA_ID As Integer = 0

                                    'Busco el id de la promocion en el ds_promo
                                    Dim ii As Integer = 0
                                    While ii < Mesa_cargar.ds_PROMO.Tables(0).Rows.Count
                                        If LISTA_codinterno = Mesa_cargar.ds_PROMO.Tables(0).Rows(ii).Item("LISTA_codinterno") Then
                                            LISTA_ID = Mesa_cargar.ds_PROMO.Tables(0).Rows(ii).Item("LISTA_id")
                                        End If
                                        ii = ii + 1
                                    End While


                                    Call Mesas_gestion.Actualizar_Stock_Promocion(LISTA_ID, cantidad_PROMOS)



                                End If
                            End If
                            i = i + 1
                        End While
                    End If
                    'MessageBox.Show("Debe Cargar un Pago para poder Continuar.", "Sistema de Gestion.")
                    'Mesas_agregar.Limpiar()

                    'Mesas_gestion.TabPage1.Enabled = True 'pasar a pestaña 1
                    'Mesas_gestion.TabPage2.Enabled = False 'pasar a pestaña 1
                    'Mesas_gestion.TabControl1.SelectedTab = Mesas_gestion.TabPage1


                    'aqui llamo a las rutinas de Mesas_gestion_2_new
                    'ParallelEnumerable actualizar los estados de las mesas

                    'Mesas_gestion_2_new.Deshabilitar_mesas()
                    Mesas_gestion_2_new.recuperar_mesas()

                    'Mesas_gestion_2_new.habilitar_mesas()

                    If form_procedencia = "Mesas_gestion_2_new" Then
                        If estado = "Cobrado" Then
                            'aqui va una rutina para habilitar la mesa cobrada...es una rutina de este form ya q se entra a traves del form mesas_consulta_gestion
                            Habilitar_mesas_cobradas(sector_id, Label_mesa)

                        End If
                    Else
                        If estado = "Cobrado" Then
                            Mesas_gestion_2_new.Habilitar_mesa_cobrada() 'este habilita si entro desde el menu contextual de las mesas, ya q no se pierde el valor de asign_pendiente
                        End If

                    End If

                    Mesa_cargar.Close()
                    Ver_promocion.Close()
                    Busqueda_Productos.Close()
                    Me.Close()



                    'Else
                    '    MessageBox.Show("Error, seleccione cliente", "Sistema de Gestion.")
                    'End If
                    '    End If
                Else
                    MessageBox.Show("Error, No hay productos agregados", "Sistema de Gestión")
                End If

            End If
        Else

            MessageBox.Show("Debe Cargar un Pago para poder Continuar.", "Sistema de Gestion.")
        End If


    End Sub

    Private Sub Habilitar_mesas_cobradas(ByVal sector_id As Integer, ByVal mesa_nombre As Integer) 'esta rutina se ejecuta cuando el form de procedencia es: mesas_consulta_getion
        Dim esta = "no"
        If sector_id = "1" Then
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_1.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_1.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_1, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_2.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_2.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_2, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_3.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_3.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_3, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_4.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_4.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_4, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_5.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_5.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_5, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_6.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_6.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_6, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_7.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_7.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_7, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_8.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_8.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_8, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_9.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_9.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_9, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_10.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_10.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_10, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_11.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_11.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_11, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_12.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_12.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_12, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_13.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_13.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_13, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_14.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_14.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_14, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_15.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_15.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_15, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_16.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_16.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_16, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If


        End If

        If sector_id = "2" Then
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_1.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_1.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_1, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_2.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_2.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_2, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_3.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_3.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_3, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_4.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_4.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_4, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_5.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_5.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_5, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_6.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_6.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_6, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_7.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_7.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_7, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_8.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_8.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_8, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_9.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_9.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_9, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_10.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_10.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_10, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_11.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_11.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_11, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_12.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_12.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_12, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_13.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_13.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_13, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_14.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_14.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_14, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_15.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_15.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_15, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_16.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_16.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_16, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If



        End If


        If sector_id = "3" Then
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_1.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_1.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_1, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_2.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_2.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_2, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_3.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_3.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_3, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_4.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_4.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_4, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_5.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_5.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_5, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_6.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_6.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_6, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_7.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_7.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_7, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_8.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_8.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_8, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_9.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_9.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_9, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_10.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_10.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_10, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_11.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_11.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_11, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_12.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_12.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_12, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_13.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_13.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_13, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_14.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_14.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_14, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_15.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_15.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_15, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_16.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_16.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_16, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If

        End If


        If sector_id = "4" Then
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_1.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_1.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_1, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_2.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_2.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_2, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_3.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_3.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_3, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_4.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_4.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_4, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_5.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_5.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_5, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_6.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_6.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_6, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_7.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_7.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_7, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_8.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_8.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_8, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_9.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_9.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_9, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_10.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_10.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_10, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_11.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_11.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_11, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_12.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_12.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_12, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_13.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_13.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_13, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_14.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_14.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_14, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_15.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_15.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_15, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_16.BackColor = Color.IndianRed Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_16.BackColor = Color.CadetBlue
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_16, "Mesa cobrada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If

        End If
    End Sub

    Private Sub Mesa_nueva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub





    Private Sub Mesa_nueva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tx_parcial.MaxLength = 6


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
            BO_guardar.Focus()
        End If



    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Me.Close()
    End Sub

   
  
End Class