Public Class Venta_Caja_gestion
    Dim DAcliente As New Datos.Cliente
    Dim DActacte As New Datos.CuentaCorriente
    Dim DAlista As New Datos.Lista
    Dim DAventa As New Datos.Venta
    Dim DAproducto As New Datos.Producto
    Public VentaGestion_DS_PROD As DataSet
    Public tipo_vta As String 'esta variable me sirve para saber con que precio trabajar, mayorista o minorista
    Public tipo_prod
    Public remito_id As Integer
    Public USU_id_gen_remito As Integer 'usuario q genero el remito
    Public fecha_remito As String 'fecha del remito cuando se hizo el alta en bd.
    Public remito_cliente_id As Integer 'cliente_id, parametro q me lo envia el form Remito
    Public remiro_vendedor_id As Integer 'vendedor_id parametro q me lo envia el form remito
    Public remito_ventaprod_id As Integer 'ventaprod_id parametro q me lo envia el form remito
    Public facturar As String
    Dim DAvendedor As New Datos.Vendedor
    Public procedencia As String 'me sirve para saber si hago factura o bien remito
#Region "METODOS Y EVENTOS DE LA GRILLA DE PRODUCTOS"
    'esta rutina busca en la grilla el producto y si existe solo suma la cantidad + 1 y realiza el calculo de totales.
    Public Sub buscar_en_grilla_y_sumar_mas_uno(ByVal cod_ingresado As Integer, ByRef existe_en_grilla As String)
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count

            If DataGridView1.Rows(i).Cells("columna_codinterno").Value = cod_ingresado And DataGridView1.Rows(i).Cells("columna_prod_id").Value <> "" Then 'pregunto por prod_id, para saber si es un producto cargado, cuando la grilla esta vacia encuentra lo primero q tipeo
                DataGridView1.Rows(i).Cells("columna_cantidad").Value = CDec(DataGridView1.Rows(i).Cells("columna_cantidad").Value) + 1
                Dim cantidad As Decimal = CDec(DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                Dim precio_unitario As Decimal = CDec(DataGridView1.Rows(i).Cells("columna_precio_unitario").Value)
                'choco: 30-11-2019, agregamos la columna descuento
                '//////////////////////////////////////////////////////////////////////////////////////////
                Dim precio As Decimal = precio_unitario * cantidad
                Dim descuento As Decimal = CDec(DataGridView1.Rows(i).Cells("descuento").Value)
                descuento = (descuento * precio) / 100
                precio = CDec(precio) - descuento
                DataGridView1.Rows(i).Cells("columna_precio_subtotal").Value = CDec(precio) 'CDec(Math.Round(precio, 2)).ToString("N2")
                '//////////////////////////////////////////////////////////////////////////////////////////
                existe_en_grilla = "si"
                Exit While
            End If
            i = i + 1
        End While
    End Sub



    Dim Encontrado As String = "no"
    Public Sub Buscar_y_cargar_en_grilla(ByVal cod_ingresado As String)
        Dim existe_en_grilla As String = "no"
        Select Case tipo_vta
            Case "Minorista"
                '-----------------------------------------------------------------
                '-----------------------------------------------------------------
                'LA BUSQUEDA DE PRODUCTO ES EN LA TABLA PRODUCTOS X SUCURSAL, Y SOLO TOMA PRECIOS MINORISTAS
                '-----------------------------------------------------------------
                '-----------------------------------------------------------------
                Encontrado = "no" 'siempre por defecto, "IMPÒRTANTISIMO"
                Dim i As Integer = 0
                'AQUI SOLO BUSCO EN TABLA PRODUCTOS, NO EN PROMOCIONES
                While i < VentaGestion_DS_PROD.Tables(1).Rows.Count 'la tabla 1 es para los prod comunes, no para los de la lista regular
                    Dim cod_interno As String = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    Dim cod_barra As String = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                    If cod_ingresado = cod_interno Or CStr(cod_ingresado) = cod_barra Then

                        If CStr(cod_ingresado) = cod_barra Then
                            celda_codinterno = cod_interno
                        End If

                        '' si es fraccionable o no el producto solamente por este if pasa''
                        tipo_prod = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_tipo").ToString
                        '''''''''''''''''''''''''''''MARIANO 17/6/19'''''''''''''''''''''''

                        '''''''''''''''''''''''''''CHOCO 29-08-2019: agrego la validacion para q sume + 1 si existe en grilla cuando busco''''''''''''''''''''''
                        'buscar_en_grilla_y_sumar_mas_uno(DataGridView1.CurrentRow.Cells("columna_codinterno").Value, existe_en_grilla)
                        buscar_en_grilla_y_sumar_mas_uno(cod_interno, existe_en_grilla)
                        If existe_en_grilla = "no" Then
                            Dim index As Integer = DataGridView1.CurrentRow.Index
                            DataGridView1.CurrentRow.Cells("columna_item").Value = CInt(DataGridView1.CurrentRow.Index + 1)
                            DataGridView1.CurrentRow.Cells("columna_prod_id").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                            DataGridView1.CurrentRow.Cells("columna_codinterno").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                            DataGridView1.CurrentRow.Cells("columna_descripcion").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                            DataGridView1.CurrentRow.Cells("columna_detalle").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                            DataGridView1.CurrentRow.Cells("columna_cantidad").Value = CInt(1)
                            DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta")
                            Dim total As Decimal = 0
                            total = CDec(VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta"))
                            DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(total)   'CDec(Math.Round(total, 2)).ToString("N2")
                            DataGridView1.CurrentRow.Cells("columna_codbarra").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                            DataGridView1.CurrentRow.Cells("descuento").Value = CInt(0) 'descuento % en 0
                        End If


                        Encontrado = "si"
                        i = VentaGestion_DS_PROD.Tables(1).Rows.Count
                    End If
                    i = i + 1
                End While
                If Encontrado = "no" Then
                    i = 0
                    'Lo busco como promocion
                    While i < VentaGestion_ds_PROMO.Tables(0).Rows.Count
                        Dim cod_interno As String = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                        If cod_ingresado.ToString.ToUpper = cod_interno Then
                            DataGridView1.CurrentRow.Cells("columna_item").Value = CInt(DataGridView1.CurrentRow.Index + 1)
                            DataGridView1.CurrentRow.Cells("columna_prod_id").Value = " "
                            DataGridView1.CurrentRow.Cells("columna_codinterno").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                            DataGridView1.CurrentRow.Cells("columna_descripcion").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
                            DataGridView1.CurrentRow.Cells("columna_detalle").Value = " "
                            DataGridView1.CurrentRow.Cells("columna_cantidad").Value = CInt(1)
                            DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
                            Dim total As Decimal = 0
                            total = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
                            DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(total) 'CDec(Math.Round(total, 2)).ToString("N2")
                            DataGridView1.CurrentRow.Cells("columna_codbarra").Value = " "

                            Encontrado = "si"
                            i = VentaGestion_ds_PROMO.Tables(0).Rows.Count
                        End If
                        i = i + 1
                    End While
                End If
                If Encontrado = "no" Then
                    'limpio los valores en la fila actual
                    DataGridView1.CurrentRow.Cells("columna_item").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_prod_id").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_codinterno").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_descripcion").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_detalle").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_cantidad").Value = ""
                    DataGridView1.CurrentRow.Cells("descuento").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_codbarra").Value = ""

                    MessageBox.Show("No Existe el Producto", "Sistema de Gestión")
                Else
                    calcular_totales()
                    aplicar_iva()
                    If existe_en_grilla = "no" Then 'esta variable se pone en "si", cuando se tipea un producto ya en grilla, en cuyo caso no se agrega nada
                        'ademas agrego un row mas para el proximo item, SIEMPRE Y CUANDO NO TENGA YA un row vacio disponible al final
                        Dim a As Integer = 0
                        If DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value <> "" Then
                            DataGridView1.Rows.Add()
                        End If
                    Else
                        DataGridView1.CurrentRow.Cells("columna_codinterno").Value = ""
                        celda_codinterno = "" 'lo blanqueo x que sino cuando cambio el foco de la celda vuelve a colocar el valor de "celda_codinterno" en la columna de codinterno' ojo solo ocurre cuando la secuencia se da ingresar un cod antes.
                    End If
                End If
            Case "Mayorista"
                '-----------------------------------------------------------------
                '-----------------------------------------------------------------
                'LA BUSQUEDA DE PRODUCTO ES EN LA TABLA PRODUCTOS X SUCURSAL, Y SOLO TOMA PRECIOS MAYORISTAS
                '-----------------------------------------------------------------
                '-----------------------------------------------------------------
                Encontrado = "no" 'siempre por defecto, "IMPÒRTANTISIMO"
                Dim i As Integer = 0
                'AQUI SOLO BUSCO EN TABLA PRODUCTOS, NO EN PROMOCIONES
                While i < VentaGestion_DS_PROD.Tables(1).Rows.Count 'la tabla 1 es para los prod comunes, no para los de la lista regular
                    Dim cod_interno As String = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    Dim cod_barra As String = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                    If cod_ingresado = cod_interno Or CStr(cod_ingresado) = cod_barra Then

                        If CStr(cod_ingresado) = cod_barra Then
                            celda_codinterno = cod_interno
                        End If
                        '' si es fraccionable o no el producto solamente por este if pasa''
                        tipo_prod = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_tipo").ToString

                        buscar_en_grilla_y_sumar_mas_uno(cod_interno, existe_en_grilla) 'aqui lo busco en gridview1 y sumo + 1 si ya existe en la grilla

                        If existe_en_grilla = "no" Then
                            Dim index As Integer = DataGridView1.CurrentRow.Index
                            DataGridView1.CurrentRow.Cells("columna_item").Value = CInt(DataGridView1.CurrentRow.Index + 1)
                            DataGridView1.CurrentRow.Cells("columna_prod_id").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                            DataGridView1.CurrentRow.Cells("columna_codinterno").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                            DataGridView1.CurrentRow.Cells("columna_descripcion").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                            DataGridView1.CurrentRow.Cells("columna_detalle").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                            DataGridView1.CurrentRow.Cells("columna_cantidad").Value = CInt(1)
                            DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta_May")
                            Dim total As Decimal = 0
                            total = CDec(VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta_May"))
                            DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(total)   'CDec(Math.Round(total, 2)).ToString("N2")
                            DataGridView1.CurrentRow.Cells("columna_codbarra").Value = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                            DataGridView1.CurrentRow.Cells("descuento").Value = CInt(0) 'descuento % en 0
                        End If
                        Encontrado = "si"
                        i = VentaGestion_DS_PROD.Tables(1).Rows.Count
                    End If
                    i = i + 1
                End While
                If Encontrado = "no" Then
                    i = 0
                    'Lo busco como promocion
                    While i < VentaGestion_ds_PROMO.Tables(0).Rows.Count
                        Dim cod_interno As String = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                        If cod_ingresado.ToString.ToUpper = cod_interno Then
                            DataGridView1.CurrentRow.Cells("columna_item").Value = CInt(DataGridView1.CurrentRow.Index + 1)
                            DataGridView1.CurrentRow.Cells("columna_prod_id").Value = " "
                            DataGridView1.CurrentRow.Cells("columna_codinterno").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                            DataGridView1.CurrentRow.Cells("columna_descripcion").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
                            DataGridView1.CurrentRow.Cells("columna_detalle").Value = " "
                            DataGridView1.CurrentRow.Cells("columna_cantidad").Value = CInt(1)
                            DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
                            Dim total As Decimal = 0
                            total = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
                            DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(total) 'CDec(Math.Round(total, 2)).ToString("N2")
                            DataGridView1.CurrentRow.Cells("columna_codbarra").Value = " "
                            Encontrado = "si"
                            i = VentaGestion_ds_PROMO.Tables(0).Rows.Count
                        End If
                        i = i + 1
                    End While
                End If
                If Encontrado = "no" Then
                    'buscar por codigo de barras
                    DataGridView1.CurrentRow.Cells("columna_item").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_prod_id").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_codinterno").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_descripcion").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_detalle").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_cantidad").Value = ""
                    DataGridView1.CurrentRow.Cells("descuento").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = ""
                    DataGridView1.CurrentRow.Cells("columna_codbarra").Value = ""
                    MessageBox.Show("No Existe el Producto", "Sistema de Gestión")
                Else
                    calcular_totales()
                    aplicar_iva()
                    If existe_en_grilla = "no" Then 'esta variable se pone en "si", cuando se tipea un producto ya en grilla, en cuyo caso no se agrega nada
                        'ademas agrego un row mas para el proximo item, SIEMPRE Y CUANDO NO TENGA YA un row vacio disponible al final
                        Dim a As Integer = 0
                        If DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value <> "" Then
                            DataGridView1.Rows.Add()
                        End If
                    Else
                        DataGridView1.CurrentRow.Cells("columna_codinterno").Value = ""
                        celda_codinterno = "" 'lo blanqueo x que sino cuando cambio el foco de la celda vuelve a colocar el valor de "celda_codinterno" en la columna de codinterno' ojo solo ocurre cuando la secuencia se da ingresar un cod antes.
                    End If
                End If
        End Select
        'If TX_busc_codinterno.Text <> "" Then
        '    Dim i As Integer = 0
        '    Dim encontrado As String = "No"
        '    Dim T As Integer = 0
        '    If RB_No.Checked = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
        '        T = 1
        '    End If
        '    While i < VentaGestion_DS_PROD.Tables(T).Rows.Count
        '        Dim cod_interno As String = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
        '        If TX_busc_codinterno.Text = cod_interno Then
        '            'primero verifico que el producto q ingreso no este ya en la grilla
        '            Dim item = 0
        '            Dim presente = "no"
        '            Dim fila_editar = 0
        '            While item < DataG_lista.Rows.Count
        '                If DataG_lista.Rows(item).Cells(2).Value = TX_busc_codinterno.Text Then
        '                    presente = "si"
        '                    fila_editar = item
        '                End If
        '                item = item + 1
        '            End While
        '            'ahora veo de agregar o editar
        '            If presente = "no" Then
        '                'agrego una nueva fila
        '                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
        '                newCustomersRow("PROD_id") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_id").ToString
        '                newCustomersRow("codinterno") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
        '                If RB_No.Checked = True Then
        '                    newCustomersRow("descripcion") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString
        '                Else
        '                    newCustomersRow("descripcion") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString + " " + "x" + VentaGestion_DS_PROD.Tables(T).Rows(i).Item("Lista_Prod_cantidad").ToString
        '                End If
        '                newCustomersRow("detalle") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descrilarga").ToString

        '                If tx_cantidad.Text = "" Then
        '                    tx_cantidad.Text = CInt(1)
        '                End If
        '                Dim cant As Integer = CInt(tx_cantidad.Text)
        '                newCustomersRow("cantidad") = cant
        '                newCustomersRow("precio_unitario") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta")
        '                Dim total As Decimal = 0
        '                total = cant * CDec(VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta"))
        '                newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
        '                newCustomersRow("codbarra") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
        '                Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
        '                DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        '                Dim a As Integer = DataG_lista.Rows.Count
        '                DataG_lista.Rows(a - 1).Cells(0).Value = a
        '            Else
        '                'edito una fila existente, solo si el usuario lo desea, pregunta!!!
        '                'Dim result As DialogResult
        '                'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '                'If result = DialogResult.OK Then
        '                If tx_cantidad.Text = "" Then
        '                    tx_cantidad.Text = CInt(1)
        '                End If
        '                Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
        '                'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
        '                DataG_lista.Rows(fila_editar).Cells(5).Value = cant
        '                Dim total As Decimal = 0
        '                total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
        '                DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
        '                ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
        '                'Dim result As DialogResult
        '                'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '                'If result = DialogResult.OK Then
        '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
        '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
        '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
        '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
        '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
        '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
        '                'End If
        '            End If
        '            encontrado = "Si"
        '        End If
        '        i = i + 1
        '    End While
        '    If encontrado = "No" Then
        '        i = 0
        '        'lo busco como promocion
        '        While i < VentaGestion_ds_PROMO.Tables(0).Rows.Count
        '            Dim cod_interno As String = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '            If TX_busc_codinterno.Text.ToUpper = cod_interno Then
        '                'primero verifico que el producto q ingreso no este ya en la grilla
        '                Dim item = 0
        '                Dim presente = "no"
        '                Dim fila_editar = 0
        '                While item < DataG_lista.Rows.Count
        '                    If DataG_lista.Rows(item).Cells(2).Value = TX_busc_codinterno.Text.ToUpper Then
        '                        presente = "si"
        '                        fila_editar = item
        '                    End If
        '                    item = item + 1
        '                End While
        '                'ahora veo de agregar o editar
        '                If presente = "no" Then
        '                    'agrego una nueva fila
        '                    Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
        '                    newCustomersRow("PROD_id") = CStr("0")
        '                    newCustomersRow("codinterno") = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '                    newCustomersRow("descripcion") = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
        '                    'newCustomersRow("detalle") = 
        '                    If tx_cantidad.Text = "" Then
        '                        tx_cantidad.Text = CInt(1)
        '                    End If
        '                    Dim cant As Integer = CInt(tx_cantidad.Text)
        '                    newCustomersRow("cantidad") = cant
        '                    newCustomersRow("precio_unitario") = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total")

        '                    Dim total As Decimal = 0
        '                    total = cant * CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
        '                    newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
        '                    newCustomersRow("codbarra") = " "
        '                    Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
        '                    DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        '                    Dim a As Integer = DataG_lista.Rows.Count
        '                    DataG_lista.Rows(a - 1).Cells(0).Value = a

        '                Else
        '                    'edito una fila existente, solo si el usuario lo desea, pregunta!!!
        '                    'Dim result As DialogResult
        '                    'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '                    'If result = DialogResult.OK Then
        '                    If tx_cantidad.Text = "" Then
        '                        tx_cantidad.Text = CInt(1)
        '                    End If
        '                    Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
        '                    'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
        '                    DataG_lista.Rows(fila_editar).Cells(5).Value = cant
        '                    Dim total As Decimal = 0
        '                    total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
        '                    DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
        '                    'End If
        '                End If
        '                encontrado = "Si"
        '            End If
        '            i = i + 1
        '        End While
        '        If encontrado = "No" Then
        '            MsgBox("no existe")
        '            TX_busc_codinterno.SelectAll()
        '        Else

        '            tx_cantidad.Text = "1"
        '            'tx_cantidad.Focus()
        '            'tx_cantidad.SelectAll()
        '            TX_busc_codinterno.Text = ""
        '            TX_busc_codinterno.Focus()
        '            TX_busc_codinterno.SelectAll()
        '        End If
        '    Else
        '        tx_cantidad.Text = "1"
        '        TX_busc_codinterno.Text = ""
        '        TX_busc_codinterno.Focus()
        '        TX_busc_codinterno.SelectAll()
        '        'tx_cantidad.Focus()
        '        'tx_cantidad.SelectAll()
        '    End If
        'End If
    End Sub
    Dim fila_mover As Integer = 0
    Dim listo As String = "no"

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'NOTA: cuando hago click sobre las celdas q no son editables se cambia el foco a las celdas cod_interno y cantidad 
        Dim celda_actual As Integer = DataGridView1.CurrentCell.ColumnIndex
        Select Case celda_actual
            Case 0
                SendKeys.Send("{TAB}")
            Case 3
                SendKeys.Send("{LEFT}")
            Case 7
                SendKeys.Send("{LEFT}")
            Case 8
                SendKeys.Send("{LEFT}")
                SendKeys.Send("{LEFT}")
        End Select
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If Encontrado = "si" Then
            If listo = "si" Then
                'volver a seleccionar anterior
                DataGridView1.CurrentCell = DataGridView1(2, fila_mover)
                DataGridView1.CurrentRow.Cells(2).Value = celda_codinterno 'vuelvo a colocar el codinterno 

                'ahora me muevo a la columna de cantidad
                DataGridView1.CurrentCell = DataGridView1(5, fila_mover)



                listo = "no"
            End If

            If listo = "pasar a descuento" Then
                DataGridView1.CurrentCell = DataGridView1(6, fila_mover)
            End If

            If listo = "si, sig fila" Then
                'valido que no sea la ultima fila de la grilla - choco: 25-06-2019
                'If DataGridView1.CurrentRow.Index <> DataGridView1.Rows.Count - 1 Then 'si no estoy en la ultima fila, salto a la siguiente
                'And CDec(DataGridView1.CurrentRow.Cells("columna_cantidad").Value) <> CDec(0)
                'If DataGridView1.CurrentRow.Cells("columna_codinterno").Value <> "" Then
                'volver a seleccionar anterior
                'generar_fila_grid()
                'solo me muevo si no estoy en la ultima fila
                'If DataGridView1.CurrentRow.Index < DataGridView1.Rows.Count - 1 Then
                DataGridView1.CurrentCell = DataGridView1(2, fila_mover + 1)
                'End If
                listo = "no"
                'End If
                'End If



            End If
        Else
            'si no lo encuentra quedar en la misma celda
            'DataGridView1.CurrentCell = DataGridView1(2, fila_mover)
            listo = "no"
        End If

    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If DataGridView1.CurrentCell.ColumnIndex = 2 And CStr(DataGridView1.CurrentRow.Cells("columna_item").Value) <> "" Then
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                'DataGridView1.CurrentRow.Cells("columna_descripcion").Value = "producto"
                'DataGridView1.CurrentRow.Cells("columna_cantidad").Value = "10"
                SendKeys.Send("{TAB}")
                SendKeys.Send("{TAB}")
            End If
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 5 Then 'columna cantidad, un TAB para pasar a descuento
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                SendKeys.Send("{TAB}")
            End If
        End If


        If DataGridView1.CurrentCell.ColumnIndex = 6 Then 'columna descuento, se hacen varios TAB hasta pasar a la siguiente fila
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                SendKeys.Send("{TAB}")
                SendKeys.Send("{TAB}")
                SendKeys.Send("{TAB}")
                SendKeys.Send("{TAB}")
                SendKeys.Send("{TAB}")
            End If
        End If
        'If DataGridView1.CurrentCell.ColumnIndex = 2 And e.KeyCode = Keys.Right Or Keys.Left Then 'esto anula la nav x teclado
        '    e.SuppressKeyPress = True
        'End If
        'If DataGridView1.CurrentCell.ColumnIndex = 5 And e.KeyCode = Keys.Left Or Keys.Right Then 'esto anula la nav x teclado
        '    e.SuppressKeyPress = True
        'End If
        'If e.KeyCode = Keys.Enter Then
        '    'DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("columna_cantidad").Selected = True
        'End If
    End Sub

    Public agregado_de_busqueda As String = "no"
    Public celda_codinterno 'la uso para no perder el valor cuando presiono ESC o salgo del foco de la celda de la columna 2.
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If DataGridView1.CurrentCell.ColumnIndex = 2 Then 'la columna 2 es Cod interno
            If DataGridView1.CurrentCell.Value Is DBNull.Value Then
                DataGridView1.CurrentCell.Value = 0
            End If
            celda_codinterno = DataGridView1.CurrentCell.Value 'esta la uso para la validacion, cuando no quiero editar la celda cod interno
            If CStr(celda_codinterno) <> "" And CStr(DataGridView1.CurrentRow.Cells(3).Value) = "" Then
                Buscar_y_cargar_en_grilla(CStr(DataGridView1.CurrentCell.Value))
            End If

            'DataGridView1.CurrentRow.Cells("columna_descripcion").Value = "producto"
            'DataGridView1.CurrentRow.Cells("columna_cantidad").Value = "10"
            fila_mover = DataGridView1.CurrentRow.Index
            listo = "si"
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 5 Then 'la columna 5 es Cantidad, la columna 6 es descuento
            If DataGridView1.CurrentCell.Value Is DBNull.Value Then

                    DataGridView1.CurrentCell.Value = 1
            End If
            Dim precio As Decimal = 0
            'Dim cantidad As Integer = CInt(DataGridView1.CurrentRow.Cells("columna_cantidad").Value)
            Dim cantidad As Decimal = CDec(DataGridView1.CurrentRow.Cells("columna_cantidad").Value)
            precio = cantidad * CDec(DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value)
            'choco: 30-11-2019 .ahora tenemos columna descuento, si aplica lo calculamos para modificar el subtotal
            '///////////////////////////////////
            Dim descuento As Decimal = CDec(DataGridView1.CurrentRow.Cells("descuento").Value)
            descuento = (descuento * precio) / 100
            precio = CDec(precio) - descuento
            '///////////////////////////////////
            DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(precio) 'CDec(Math.Round(precio, 2)).ToString("N2")
            fila_mover = DataGridView1.CurrentRow.Index
            calcular_totales()
            aplicar_iva()
            'listo = "si, sig fila"
            listo = "pasar a descuento"
        End If


        If DataGridView1.CurrentCell.ColumnIndex = 6 Then 'la columna 6 es descuento
            If DataGridView1.CurrentCell.Value Is DBNull.Value Then
                DataGridView1.CurrentCell.Value = CDec(0)
            End If
            Dim precio As Decimal = 0
            'Dim cantidad As Integer = CInt(DataGridView1.CurrentRow.Cells("columna_cantidad").Value)
            Dim cantidad As Decimal = CDec(DataGridView1.CurrentRow.Cells("columna_cantidad").Value)
            precio = cantidad * CDec(DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value)
            'choco: 30-11-2019 .ahora tenemos columna descuento, si aplica lo calculamos para modificar el subtotal
            '///////////////////////////////////
            Dim descuento As Decimal = CDec(DataGridView1.CurrentRow.Cells("descuento").Value)
            descuento = (descuento * precio) / 100
            precio = CDec(precio) - descuento
            '///////////////////////////////////
            DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(precio) 'CDec(Math.Round(precio, 2)).ToString("N2")
            fila_mover = DataGridView1.CurrentRow.Index
            calcular_totales()
            aplicar_iva()
            listo = "si, sig fila"
        End If



    End Sub

    Public Sub calcular_totales()
        DataG_listaTotal.Rows.Clear()
        DataG_listaTotal.Rows.Add()
        'sumamos los subtotales con un ciclo
        Dim sumar As Decimal = "0,00"
        Dim ii As Integer = 0
        While ii < DataGridView1.Rows.Count   'DataG_lista.Rows.Count
            Dim precio_subtotal = DataGridView1.Rows(ii).Cells("columna_precio_subtotal").Value
            If CStr(precio_subtotal) <> "" Then 'fila vacia
                sumar = sumar + CDec(DataGridView1.Rows(ii).Cells("columna_precio_subtotal").Value)
            End If


            ii = ii + 1
        End While
        sumar = Math.Round(sumar, 2)
        DataG_listaTotal.Rows(0).Cells(0).Value = "TOTAL"
        DataG_listaTotal.Rows(0).Cells(1).Value = CDec(sumar) 'Math.Round(sumar, 2).ToString("N2")
        txt_subtotal.Text = CDec(sumar)
    End Sub

#End Region

#Region "EVENTOS"
    Private Sub Venta_Caja_gestion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'NOTA: DEBE ESTAR LA PROPIEDAD DEL FORM "KEYPREVIEW = TRUE" para q se ejecute el evento keydown.
        If e.KeyCode = Keys.F1 Then 'F1
            Busqueda_Productos.form_procedencia = "Venta_Caja_gestion"
            Busqueda_Productos.Show()
            'Busqueda_Productos.tx_Buscar.Focus()
        End If
        If e.KeyCode = Keys.F2 Then
            'Ver_promocion.form_procedencia = "Venta_Caja_gestion"
            'Ver_promocion.Show()

            'Ver_promocion.tx_Buscar.Focus()
        End If

        If e.KeyCode = Keys.F5 Then
            Busqueda_CodBarra.Show()
            'Ver_promocion.form_procedencia = "Venta_Caja_gestion"
            'Ver_promocion.Show()
        End If

        'If e.KeyCode = Keys.Right Then
        '    If CELDA = 2 Then
        '        'MOVER A LA 5

        '        Me.Focus()
        '        DataGridView1.Focus()
        '        'DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        '        DataGridView1.Rows(FILA).Cells("columna_cantidad").Selected = True
        '        DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
        '        CELDA = 5
        '    Else
        '        'MOVER ABAJO A AL SIG FILA
        '        FILA = FILA + 1

        '        Me.Focus()
        '        DataGridView1.Focus()
        '        'DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        '        DataGridView1.Rows(FILA).Cells("columna_codinterno").Selected = True
        '        DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
        '        CELDA = 2
        '    End If
        'End If


        'If e.KeyCode = Keys.Enter Then
        'DataGridView1.Rows(0).Cells("columna_cantidad").Selected = True
        'End If


    End Sub

    Private Sub obtener_usuario_y_sucursal()
        'ojo esto funciona con la referencia al menu...
        Dim USU_ID As Integer = CInt(US_administrador.USU_id)
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(USU_ID)
        If ds_usuario.Tables(0).Rows.Count <> 0 Then
            'cargamos datos en los label


            '-------------GRUPBOX VENTA----------------

            If procedencia = "Venta_Caja_Gestion" Then
                'aqui recupero el ultimo nro de factura y le sumo 1
                Dim ds_facturanro As DataSet = DAventa.obtener_ultimo_nrofactura
                If ds_facturanro.Tables(1).Rows.Count <> 0 Then
                    lb_factura_vta.Text = ds_facturanro.Tables(1).Rows(0).Item("factura_id") + 1
                Else
                    lb_factura_vta.Text = 1
                End If
            End If

            If procedencia = "Remito nuevo" Then
                'aqui recupero el ultimo nro de remito y le sumo 1
                Dim ds_remito As DataSet = DAventa.obtener_ultimo_nroremito
                If ds_remito.Tables(0).Rows.Count <> 0 Then
                    lb_factura_vta.Text = ds_remito.Tables(0).Rows(0).Item("remito_id") + 1
                    Label12.Text = "NºRemito:"
                Else
                    lb_factura_vta.Text = 1
                    Label12.Text = "Nº Remito:"
                End If
            End If

            lb_vendedor_vta.Text = ds_usuario.Tables(0).Rows(0).Item("USU_ape") + ", " + ds_usuario.Tables(0).Rows(0).Item("USU_nom")
            lb_fecha_vta.Text = Today

            '-------------GRUPBOX DATOS COMERCIALES---------
            lb_nombre_sucursal.Text = ds_usuario.Tables(0).Rows(0).Item("sucursal_nombre")
            lb_direccion_sucursal.Text = ds_usuario.Tables(0).Rows(0).Item("sucursal_direccion")
            lb_telefono_sucursal.Text = ds_usuario.Tables(0).Rows(0).Item("sucursal_telefono")
            lb_mail_sucursal.Text = ds_usuario.Tables(0).Rows(0).Item("sucursal_mail")

            '-----------GRUPBOX CLIENTE.
            If RB_Cliente.Checked = True And DG_clientes.Rows.Count <> 0 Then
                Dim ds As DataSet = DAcliente.Cliente_obtener_info(CInt(DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value))
                lb_fantasia.Text = ds.Tables(0).Rows(0).Item("CLI_Fan").ToString
                lb_dni_clie.Text = ds.Tables(0).Rows(0).Item("CLI_dni").ToString
                lb_telef_clie.Text = ds.Tables(0).Rows(0).Item("CLI_tel").ToString
                lb_mail_clie.Text = ds.Tables(0).Rows(0).Item("CLI_mail").ToString
                lb_tipoIVA_clie.Text = ds.Tables(0).Rows(0).Item("IVA_Descripcion").ToString

                'choco: 03-12-2019, si tiene cuenta corriente, muestro saldo y un label que diga que es cta cte.
                Dim ds_ctacte As DataSet = DActacte.CtaCte_buscar_Cliente(CInt(DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value))
                If ds_ctacte.Tables(0).Rows.Count <> 0 Then
                    If ds_ctacte.Tables(0).Rows(0).Item("CtaCte_estado") = "Activo" Then
                        'si tiene cta activa, pongo sus datos en el label
                        Label_ctacte.Text = "Cuenta Corriente: " + CStr(ds_ctacte.Tables(0).Rows(0).Item("CtaCte_id"))
                        Label_saldo.Text = "Saldo $: " + CStr(ds_ctacte.Tables(0).Rows(0).Item("CtaCte_total"))
                        label_limite.Text = "Limite $:" + CStr(ds_ctacte.Tables(0).Rows(0).Item("CtaCte_limitedeuda"))
                    Else
                        Label_ctacte.Text = "Cuenta Corriente:"
                        Label_saldo.Text = "Saldo $:"
                    End If
                Else
                    Label_ctacte.Text = "Cuenta Corriente:"
                    Label_saldo.Text = "Saldo $:"
                End If
            Else
                lb_fantasia.Text = "- - - -"
                lb_dni_clie.Text = "- - - -"
                lb_telef_clie.Text = "- - - -"
                lb_mail_clie.Text = "- - - -"
                lb_tipoIVA_clie.Text = "- - - -"
                Label_ctacte.Text = "Cuenta Corriente:"
                Label_saldo.Text = "Saldo:"

            End If
        End If

    End Sub

    Private Sub Venta_Caja_gestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Focus()
        'tx_cantidad.MaxLength = 6
        'recupero todos los clientes de la bd
        Call Obtener_Clientes()
        'Call Obtener_Promociones()
        Obtener_Promociones_2()
        Obtener_Productos_Combos()


        TabPage2.Parent = Nothing

        'agregamos grilla vacia.
        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        'generar_fila_grid()

        'choco: 03-12-2019
        'cargar en en un combo los vendedores disponibles
        vendedores_obtener()

        'choco: 07-12-2019
        If procedencia = "Remito modificar" Then
            'paso directamente a la pestaña 2, recupero productos guardados en la bd, del remito pendiente
            recuperar_remito_etc()
        End If

    End Sub





#Region "Remito modificar"
    Private Sub recuperar_remito_etc()
        If RB_Cliente.Checked = True Then
            'If DG_clientes.CurrentRow.Selected = True Then
            GroupBox12.Enabled = True 'habilito la pestaña 2
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            TabPage1.Parent = Nothing 'oculto pestaña 1
            TabPage2.Parent = TabControl1 'pongo visible pestaña 2
            TabControl1.SelectedTab = TabPage2

            'LIMPIAR LA GRILLA DE PROD AGREGADOS
            'DataG_lista.DataSource = Nothing
            DataGridView1.DataSource = Nothing
            Call habilitar_columnas_edicion()
            Call Obtener_Productos_Combos()
            'End If
        End If
        'esto va en el evento load del nuevo diseño del modulo
        DataGridView1.Rows.Add()
        

        obtener_usuario_sucursal_cliente() 'esto info se carga en los grupbox de la segunda pestaña

        'FILA = 0
        'CELDA = 2
        ' DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
        ComboBox_iva.SelectedIndex = 0
        Label_tipo_vta.Text = "Venta " + tipo_vta

        Remito_recuperar_productos()

        DataGridView1.Focus()
        DataGridView1.Rows(0).Cells("columna_codinterno").Selected = True
    End Sub
    Private Sub obtener_usuario_sucursal_cliente()
        'ojo esto funciona con la referencia al menu...
        Dim USU_ID As Integer = CInt(USU_id_gen_remito)
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(USU_ID)
        If ds_usuario.Tables(0).Rows.Count <> 0 Then
            'cargamos datos en los label

            '-------------GRUPBOX VENTA----------------
            lb_factura_vta.Text = remito_id
            Label12.Text = "NºRemito:"

            lb_vendedor_vta.Text = ds_usuario.Tables(0).Rows(0).Item("USU_ape") + ", " + ds_usuario.Tables(0).Rows(0).Item("USU_nom")
            lb_fecha_vta.Text = fecha_remito  'aqui va fecha recuperada del remito


            '-------------GRUPBOX DATOS COMERCIALES---------
            lb_nombre_sucursal.Text = ds_usuario.Tables(0).Rows(0).Item("sucursal_nombre")
            lb_direccion_sucursal.Text = ds_usuario.Tables(0).Rows(0).Item("sucursal_direccion")
            lb_telefono_sucursal.Text = ds_usuario.Tables(0).Rows(0).Item("sucursal_telefono")
            lb_mail_sucursal.Text = ds_usuario.Tables(0).Rows(0).Item("sucursal_mail")

            '-----------GRUPBOX CLIENTE.
            If RB_Cliente.Checked = True Then
                Dim ds As DataSet = DAcliente.Cliente_obtener_info(CInt(remito_cliente_id))
                lb_fantasia.Text = ds.Tables(0).Rows(0).Item("CLI_Fan").ToString
                lb_dni_clie.Text = ds.Tables(0).Rows(0).Item("CLI_dni").ToString
                lb_telef_clie.Text = ds.Tables(0).Rows(0).Item("CLI_tel").ToString
                lb_mail_clie.Text = ds.Tables(0).Rows(0).Item("CLI_mail").ToString
                lb_tipoIVA_clie.Text = ds.Tables(0).Rows(0).Item("IVA_Descripcion").ToString

                'choco: 03-12-2019, si tiene cuenta corriente, muestro saldo y un label que diga que es cta cte.
                Dim ds_ctacte As DataSet = DActacte.CtaCte_buscar_Cliente(remito_cliente_id)
                If ds_ctacte.Tables(0).Rows.Count <> 0 Then
                    If ds_ctacte.Tables(0).Rows(0).Item("CtaCte_estado") = "Activo" Then
                        'si tiene cta activa, pongo sus datos en el label
                        Label_ctacte.Text = "Cuenta Corriente: " + CStr(ds_ctacte.Tables(0).Rows(0).Item("CtaCte_id"))
                        Label_saldo.Text = "Saldo $: " + CStr(ds_ctacte.Tables(0).Rows(0).Item("CtaCte_total"))
                        label_limite.Text = "Limite $:" + CStr(ds_ctacte.Tables(0).Rows(0).Item("CtaCte_limitedeuda"))
                    Else
                        Label_ctacte.Text = "Cuenta Corriente:"
                        Label_saldo.Text = "Saldo $:"
                        label_limite.Text = "Limite $:"
                    End If
                Else
                    Label_ctacte.Text = "Cuenta Corriente:"
                    Label_saldo.Text = "Saldo $:"
                    label_limite.Text = "Limite $:"
                End If
            End If

            'ahora selecciono el mismo vendedor
            ComboBox_vendedor.SelectedValue = remiro_vendedor_id
            Panel3.Enabled = False
        End If
    End Sub
    Private Sub Remito_recuperar_productos()
        Dim ds_rem_prod As DataSet = DAventa.Remito_recuperar_productos(remito_id)
        Dim h As Integer = 0
        While h < ds_rem_prod.Tables(0).Rows.Count
            DataGridView1.Rows.Add()
            DataGridView1.Rows(h).Cells("columna_item").Value = CInt(h + 1)
            DataGridView1.Rows(h).Cells("columna_prod_id").Value = ds_rem_prod.Tables(0).Rows(h).Item("prod_id").ToString
            DataGridView1.Rows(h).Cells("columna_codinterno").Value = ds_rem_prod.Tables(0).Rows(h).Item("codigointerno").ToString
            'VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString()
            DataGridView1.Rows(h).Cells("columna_descripcion").Value = ds_rem_prod.Tables(0).Rows(h).Item("ventaprod_descripcion").ToString
            'VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
            DataGridView1.Rows(h).Cells("columna_detalle").Value = ds_rem_prod.Tables(0).Rows(h).Item("prod_descrilarga").ToString
            'VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
            DataGridView1.Rows(h).Cells("columna_cantidad").Value = CDec(ds_rem_prod.Tables(0).Rows(h).Item("ventaprod_cant"))
            DataGridView1.Rows(h).Cells("columna_precio_unitario").Value = CDec(ds_rem_prod.Tables(0).Rows(h).Item("ventaprod_precio"))
            'VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta")
            DataGridView1.Rows(h).Cells("columna_precio_subtotal").Value = CDec(ds_rem_prod.Tables(0).Rows(h).Item("producto_subtotal"))
            DataGridView1.Rows(h).Cells("columna_codbarra").Value = ds_rem_prod.Tables(0).Rows(h).Item("prod_codbarra")
            DataGridView1.Rows(h).Cells("descuento").Value = CDec(ds_rem_prod.Tables(0).Rows(h).Item("ventaprod_descuento_porc")) 'descuento % en 0
            calcular_totales()
            Dim IVA As Decimal = CDec(ds_rem_prod.Tables(0).Rows(h).Item("ventaprod_iva_porcentaje"))
            Dim desc_pesos As Decimal = CDec(ds_rem_prod.Tables(0).Rows(h).Item("ventaprod_descuento_pesos"))
            Dim desc_porc As Decimal = CDec(ds_rem_prod.Tables(0).Rows(h).Item("ventaprod_descuento_porcentaje"))
            Remito_aplicar_SU_iva(IVA, desc_pesos, desc_porc)

            h = h + 1
        End While



    End Sub
    Public Sub Remito_aplicar_SU_iva(ByVal IVA As Decimal, ByVal desc_pesos As Decimal, ByVal desc_porc As Decimal)
        txt_total.Text = 0

        If IVA = "0" And CDec(txt_subtotal.Text) <> 0 Then
            '///////////////////IMPUESTO////////////////////////////
            txt_impuesto_aplicado.Text = CDec(0)
            '//////////////////////////////////////////////////////
            'como es el 0, debo volver a poner el total sin iva, y si corresponde aplico el descuento

            txt_desc_pesos.Text = (Math.Round(CDec(desc_pesos), 2).ToString("N2"))
            txt_desc_porc.Text = (Math.Round(CDec(desc_porc), 2).ToString("N2"))
            'If txt_desc_pesos.Text = "" Then
            '    txt_desc_pesos.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            'End If

            Dim calculo_porc As Decimal = (CDec(txt_desc_pesos.Text) * 100) / CDec(txt_subtotal.Text)
            txt_desc_porc.Text = (Math.Round(CDec(calculo_porc), 2).ToString("N2"))

            '///////////////////////TOTAL A PAGAR/////////////////////////
            txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_desc_pesos.Text)
            txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////

            '///////////////////DESCUENTO//////////////////////////////
            txt_descuento.Text = (Math.Round(CDec(txt_desc_pesos.Text), 2).ToString("N2"))
            '/////////////////////////////////////////////////////////
            'If txt_desc_porc.Text = (Math.Round(CDec(0), 2).ToString("N2")) Then
            '    calcular_totales()
            'End If
            GroupBox_pagar.Text = "Monto a pagar (" + (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2")) + "% descuento)"
            ComboBox_iva.SelectedIndex = 0
        End If
        If IVA = "10,5" And CDec(txt_subtotal.Text) <> 0 Then
            txt_desc_pesos.Text = (Math.Round(CDec(desc_pesos), 2).ToString("N2"))
            txt_desc_porc.Text = (Math.Round(CDec(desc_porc), 2).ToString("N2"))

            'If txt_desc_pesos.Text = "" Then
            '    txt_desc_pesos.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            'End If
            Dim calculo_porc As Decimal = (CDec(txt_desc_pesos.Text) * 100) / CDec(txt_subtotal.Text)
            txt_desc_porc.Text = (Math.Round(CDec(calculo_porc), 2).ToString("N2"))
            '///////////////////////DESCUENTO/////////////////////////
            'txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_desc_pesos.Text)
            'txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            txt_descuento.Text = CDec(txt_desc_pesos.Text)
            txt_descuento.Text = (Math.Round(CDec(txt_descuento.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////

            '////////////////////////////IMPUESTO////////////////////////////////////////
            'calculo el 10.5% al subtotla de la venta.
            Dim calculo As Decimal = (CDec(10.5) * CDec(txt_subtotal.Text)) / 100 'esto me da en pesos cuanto se paga
            txt_impuesto_aplicado.Text = (Math.Round(CDec(calculo), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////////////////

            '/////////////////////TOTAL A PAGAR//////////////////////////////////
            txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_descuento.Text) + CDec(txt_impuesto_aplicado.Text)
            txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////
            GroupBox_pagar.Text = "Monto a pagar (" + (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2")) + "% descuento)"
            ComboBox_iva.SelectedIndex = 1
        End If
        If IVA = "21" And CDec(txt_subtotal.Text) <> 0 Then
            txt_desc_pesos.Text = (Math.Round(CDec(desc_pesos), 2).ToString("N2"))
            txt_desc_porc.Text = (Math.Round(CDec(desc_porc), 2).ToString("N2"))

            Dim calculo_porc As Decimal = (CDec(txt_desc_pesos.Text) * 100) / CDec(txt_subtotal.Text)
            txt_desc_porc.Text = (Math.Round(CDec(calculo_porc), 2).ToString("N2"))

            '///////////////////////DESCUENTO/////////////////////////
            'txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_desc_pesos.Text)
            'txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            txt_descuento.Text = CDec(txt_desc_pesos.Text)
            txt_descuento.Text = (Math.Round(CDec(txt_descuento.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////

            '////////////////////////////IMPUESTO////////////////////////////////////////
            'aplico el 21% al total de la venta.
            Dim calculo As Decimal = (CDec(21) * CDec(txt_subtotal.Text)) / 100 'esto me da en pesos cuanto se paga
            txt_impuesto_aplicado.Text = (Math.Round(CDec(calculo), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////////////////

            '/////////////////////TOTAL A PAGAR//////////////////////////////////
            txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_descuento.Text) + CDec(txt_impuesto_aplicado.Text)
            txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////
            GroupBox_pagar.Text = "Monto a pagar (" + (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2")) + "% descuento)"
            ComboBox_iva.SelectedIndex = 2
        End If
    End Sub
#End Region

    Private Sub DG_clientes_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'If e.ColumnIndex <> 1 Then Exit Sub

        ''primero quito la seleccion de los demas
        'Dim i = 0
        'While i < DG_clientes_old.Rows.Count
        '    DG_clientes_old.Rows(i).Cells(1).Value = False
        '    i = i + 1
        'End While

        'If DG_clientes_old.Rows(e.RowIndex).Cells(1).Value = True Then

        '    DG_clientes_old.Rows(e.RowIndex).Cells(1).Value = False
        'Else
        '    DG_clientes_old.Rows(e.RowIndex).Cells(1).Value = True
        'End If
    End Sub

    Private Sub RB_Consumidor_CheckedChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Consumidor.CheckedChanged
        If RB_Consumidor.Checked = True Then
            DG_clientes.Enabled = False
            Dim i = 0
            'While i < DG_clientes_old.Rows.Count
            '    DG_clientes_old.Rows(i).Cells(1).Value = False
            '    i = i + 1
            'End While

        End If
    End Sub

    Private Sub RB_Cliente_CheckedChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Cliente.CheckedChanged
        If RB_Cliente.Checked = True Then
            DG_clientes.Enabled = True
            Busqueda.Focus()
            Busqueda.SelectAll()
        End If
    End Sub

    Private Sub BO_Nuevo_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles BO_Nuevo.Click
        llamar_Form(Cliente_alta, Me)
    End Sub


#End Region


#Region "METODOS"
    Dim ds_clie As DataSet
    'recupero todos los clientes
    Public Sub Obtener_Clientes()
        If procedencia = "Venta_Caja_Gestion" Then
            ds_clie = DAcliente.Cliente_obtenertodo()
            If ds_clie.Tables(0).Rows.Count <> 0 Then
                Venta_Caja_ds.Tables("Cliente").Rows.Clear() 'borro el contenido del dataset.datatable clientes
                Venta_Caja_ds.Tables("Cliente").Merge(ds_clie.Tables(0)) '' al combinarla con el dataset "cliente" ya puedo filtrar
                'DG_clientes.DataSource = ds_clie.Tables(0)
                'DG_clientes_old.DataSource = ds_clie.Tables(0)
            End If
        Else
            If procedencia = "Remito nuevo" Then
                'solo muestro en la grilla los clientes con cta cte.
                ds_clie = DAcliente.Cliente_obtenertodo()
                If ds_clie.Tables(1).Rows.Count <> 0 Then
                    Venta_Caja_ds.Tables("Cliente").Rows.Clear() 'borro el contenido del dataset.datatable clientes
                    Venta_Caja_ds.Tables("Cliente").Merge(ds_clie.Tables(1)) '' al combinarla con el dataset "cliente" ya puedo filtrar
                    'DG_clientes.DataSource = ds_clie.Tables(0)
                    'DG_clientes_old.DataSource = ds_clie.Tables(0)
                End If
            End If

        End If

    End Sub
    Private Sub Filtrar_datatable(ByVal parametro As String)
        If ds_clie.Tables.Count <> 0 Then
            ''uso ds_CLIE que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("CLI_id")
            table_filtrada.Columns.Add("CLI_ape")
            table_filtrada.Columns.Add("CLI_nom")
            table_filtrada.Columns.Add("CLI_dni")
            table_filtrada.Columns.Add("CLI_fnac")
            table_filtrada.Columns.Add("CLI_tel")
            table_filtrada.Columns.Add("CLI_mail")

            DG_clientes.DataSource = Nothing

            Dim table As DataTable = ds_clie.Tables(0)

            Dim apellido As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("CLI_ape")
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If

                Dim fila2 As String = table.Rows(a).Item("CLI_dni")
                fila2 = fila2.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter2 As Integer = fila2.IndexOf(parametro)
                If primercaracter2 <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If


                Dim fila3 As String = table.Rows(a).Item("CLI_nom")
                fila3 = fila3.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter3 As Integer = fila3.IndexOf(parametro)
                If primercaracter3 <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If


                'If apellido = table.Rows(a).Item("CLI_ape") Then
                '    table_filtrada.ImportRow(table.Rows(a))
                'End If
                a = a + 1
            End While

            If table_filtrada.Rows.Count <> 0 Then
                DG_clientes.DataSource = table_filtrada
            Else
                DG_clientes.DataSource = ds_clie.Tables(0)
            End If
        End If
    End Sub
    Private Sub Obtener_combo()
        Dim ds_listas As DataSet = DAlista.Lista_Regular_obtener()
        'Cargar Proveedor
        CB_lista.DataSource = ds_listas.Tables(0)
        CB_lista.DisplayMember = "LISTA_nom"
        CB_lista.ValueMember = "LISTA_id"
    End Sub

    Public Sub Obtener_Productos_Combos() 'CORRECCION (CHOCO):27-09-2018
        If RB_Si.Checked = False Then 'quiere decir q no estoy usando listas definidas
            VentaGestion_DS_PROD = DAventa.Venta_obtenerProducto_Combos(Inicio.USU_id) 'rutina que trae productos x sucursal, precios minoristas y mayorista (corregido el 11-10-2018)
            'junto los prod y los combos..para mostrarlos en el mismo grid
            With VentaGestion_DS_PROD.Tables(2).Rows
                If .Count > 0 Then
                    VentaGestion_DS_PROD.Tables(1).Merge(VentaGestion_DS_PROD.Tables(2))
                    'DataGridView1.DataSource = DS_PROD.Tables(1)
                Else
                    If VentaGestion_DS_PROD.Tables(1).Rows.Count <> 0 Then
                        '    DataGridView1.DataSource = DS_PROD.Tables(1)
                    Else
                        '   DataGridView1.Enabled = False
                        'DataGridView1.DataSource = Nothing
                    End If
                End If
            End With
        Else
            If RB_No.Checked = False Then
                VentaGestion_DS_PROD = DAventa.Venta_obtenerProducto_listaregular(CB_lista.SelectedValue)
                'junto los prod y los combos..para mostrarlos en el mismo grid
                With VentaGestion_DS_PROD.Tables(1).Rows
                    If .Count > 0 Then
                        VentaGestion_DS_PROD.Tables(0).Merge(VentaGestion_DS_PROD.Tables(1))
                        'DataGridView1.DataSource = DS_PROD.Tables(0)
                    Else
                        If VentaGestion_DS_PROD.Tables(0).Rows.Count <> 0 Then
                            'DataGridView1.DataSource = DS_PROD.Tables(0)
                        Else
                            'DataGridView1.Enabled = False
                            'DataGridView1.DataSource = Nothing
                        End If
                        'IM_ERROR.Visible = True
                        'LB_ERROR.Visible = True
                    End If
                End With
            End If
        End If
    End Sub
    Public VentaGestion_ds_PROMO As DataSet
    Public Function Obtener_Promociones_SUB(ByRef i As Integer, ByRef borrado As String)

        If VentaGestion_ds_PROMO.Tables(0).Rows.Count <> 0 Then
            Dim dia_actual As Date = Today
            'Dim dia_actual As Date = "14 / 12 /2013"   esta la uso para probar si funciona bien en determinado dia
            Dim dia As String = dia_actual.ToString("dddd")


            Dim d As Integer = 0
            Dim dia_valido As String = ""
            While d < VentaGestion_ds_PROMO.Tables(1).Rows.Count
                If VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_id") = VentaGestion_ds_PROMO.Tables(1).Rows(d).Item("LISTA_id") Then
                    dia_valido = "no"
                    Dim dia_semana As String = ""
                    If CInt(VentaGestion_ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "1" Then
                        dia_semana = "domingo"
                    End If
                    If CInt(VentaGestion_ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "2" Then
                        dia_semana = "lunes"
                    End If
                    If CInt(VentaGestion_ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "3" Then
                        dia_semana = "martes"
                    End If
                    If CInt(VentaGestion_ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "4" Then
                        dia_semana = "miércoles"
                    End If
                    If CInt(VentaGestion_ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "5" Then
                        dia_semana = "jueves"
                    End If
                    If CInt(VentaGestion_ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "6" Then
                        dia_semana = "viernes"
                    End If
                    If CInt(VentaGestion_ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "7" Then
                        dia_semana = "sábado"
                    End If
                    If dia = dia_semana Then
                        dia_valido = "si"
                        d = VentaGestion_ds_PROMO.Tables(1).Rows.Count
                    End If
                End If
                d = d + 1
            End While

            If dia_valido = "no" Then
                borrado = "si"
                'ds_PROMO.Tables(0).Rows(i).Delete()
            Else
                dia_valido = ""
                '//////esto es para VIGENCIA/////////////////
                Dim j As Integer = 0
                While j < VentaGestion_ds_PROMO.Tables(2).Rows.Count
                    Dim desde As Date = VentaGestion_ds_PROMO.Tables(2).Rows(j).Item("LISTA_VIG_desde")
                    Dim hasta As Date = VentaGestion_ds_PROMO.Tables(2).Rows(j).Item("LISTA_VIG_hasta")
                    If VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_id") = VentaGestion_ds_PROMO.Tables(2).Rows(j).Item("LISTA_id") Then
                        If (Today < desde) Or (Today > hasta) Then
                            'If (Today < CDate(ds_PROD.Tables(2).Rows(j).Item("LISTA_VIG_desde"))) Or (Today > CDate(ds_PROD.Tables(2).Rows(j).Item("LISTA_VIG_hasta"))) Then

                            'ds_PROMO.Tables(0).Rows(i).Delete()
                            borrado = "si"
                            j = VentaGestion_ds_PROMO.Tables(2).Rows.Count
                        End If
                    End If
                    j = j + 1
                End While
            End If
        End If
        Return (borrado)
    End Function
    Public Sub Obtener_Promociones_2()
        VentaGestion_ds_PROMO = DAlista.Lista_Promocion_obtener()
        'junto los prod y los combos..para mostrarlos en el mismo grid

        If VentaGestion_ds_PROMO.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < VentaGestion_ds_PROMO.Tables(0).Rows.Count
                Dim borrado As String = "no"
                'llamada a procedimiento para borrar.

                Obtener_Promociones_SUB(i, borrado)

                If borrado = "si" Then
                    'ds_PROMO.Tables(0).Rows(i).Delete()
                    VentaGestion_ds_PROMO.Tables(0).Rows.RemoveAt(i)
                    i = 0
                Else
                    i = i + 1
                End If
            End While
        End If
    End Sub
    Public Sub habilitar_columnas_edicion()

        'Dim columgri1 As Integer = 0
        'While columgri1 <= 7
        '    Me.DataG_lista.Columns(columgri1).ReadOnly = True
        '    columgri1 = columgri1 + 1
        'End While

        ''2 y 5
        'DataG_lista.Columns(2).ReadOnly = False 'cod interno
        'DataG_lista.Columns(5).ReadOnly = False 'cantidad


        'cambio el color de las columnas editables
        Dim fila As Integer = 0
        While fila < Me.DataGridView1.Rows.Count


            Me.DataGridView1.Rows(fila).Cells(0).Style.BackColor = Color.GhostWhite
            Me.DataGridView1.Rows(fila).Cells(1).Style.BackColor = Color.GhostWhite
            Me.DataGridView1.Rows(fila).Cells(3).Style.BackColor = Color.GhostWhite
            Me.DataGridView1.Rows(fila).Cells(4).Style.BackColor = Color.GhostWhite
            Me.DataGridView1.Rows(fila).Cells(6).Style.BackColor = Color.GhostWhite
            Me.DataGridView1.Rows(fila).Cells(7).Style.BackColor = Color.GhostWhite

            'If fila = 0 Then
            '    Me.DataG_lista.Rows(fila).Cells(2).Style.BackColor = Color.LightGoldenrodYellow
            '    Me.DataG_lista.Rows(fila).Cells(5).Style.BackColor = Color.LightGoldenrodYellow
            '    fila = fila + 1
            'Else
            '    If Me.DataG_lista.Rows(fila - 1).Cells(1).Value <> "" Then
            '        Me.DataG_lista.Rows(fila).Cells(2).Style.BackColor = Color.LightGoldenrodYellow
            '        Me.DataG_lista.Rows(fila).Cells(5).Style.BackColor = Color.LightGoldenrodYellow
            '        fila = fila + 1
            '    Else
            '        fila = Me.DataG_lista.Rows.Count
            '    End If
            '    fila = fila + 1
            'End If

            fila = fila + 1
        End While


    End Sub
    Public Sub Limpiar()
        Encontrado = "no"
        listo = "no"
        'primero lo de la pagina 2
        'TX_busc_codinterno.Clear()
        'tx_cantidad.Clear()
        Venta_Caja_ds.Tables("Producto_agregado").Rows.Clear()
        'DataG_lista.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.DataSource = Nothing
        DataG_listaTotal.DataSource = Nothing
        DataG_listaTotal.Rows.Clear()
        'segundo lo de la pagina 1
        GroupBox12.Enabled = False  'deshabilito la pestaña 2
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        TabControl1.SelectedTab = TabPage1
        TabPage2.Parent = Nothing 'oculto pestaña 2
        TabPage1.Parent = TabControl1 'pongo visible pestaña 1
        'textbox de subtotal, total, descuento, impuesto agregado
        txt_subtotal.Text = CDec(0)
        txt_descuento.Text = CDec(0)
        txt_impuesto_aplicado.Text = CDec(0)
        txt_total.Text = CDec(0)
        'descuentos
        txt_desc_pesos.Text = CDec(0)
        txt_desc_porc.Text = CDec(0)

        
        
    End Sub

    Public Sub vendedores_obtener()
        Dim ds_vendedor As DataSet = DAvendedor.Vendedor_obtenertodo()
        'cargo en combo.
        ComboBox_vendedor.DataSource = ds_vendedor.Tables(0)
        ComboBox_vendedor.DisplayMember = "vendedor_apenom"
        ComboBox_vendedor.ValueMember = "vendedor_id"
        ComboBox_vendedor.SelectedItem = 0
    End Sub
#End Region



    Dim form_anterior
    Public Sub llamar_Form(ByVal var, ByVal form_anterior)
        If (US_administrador.PN_Entrada.Controls.Count > 0) Then
            US_administrador.PN_Entrada.Controls.RemoveAt(0)
            If form_anterior.ToString <> var.ToString Then
                form_anterior.close()
            End If
            var.TopLevel = False
            var.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            var.Dock = DockStyle.Fill
            US_administrador.PN_Entrada.Controls.Add(var)
            US_administrador.PN_Entrada.Tag = var
            form_anterior = var
            var.Show()
        Else
            var.TopLevel = False
            var.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            var.Dock = DockStyle.Fill
            US_administrador.PN_Entrada.Controls.Add(var)
            US_administrador.PN_Entrada.Tag = var
            form_anterior = var
            var.Show()
        End If
    End Sub
    Private Sub BO_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Aceptar.Click
        If RB_Cliente.Checked = True Then
            If DG_clientes.Rows.Count <> 0 Then
                If DG_clientes.CurrentRow.Selected = True Then
                    GroupBox12.Enabled = True 'habilito la pestaña 2
                    GroupBox1.Enabled = False
                    GroupBox2.Enabled = False
                    GroupBox3.Enabled = False
                    TabPage1.Parent = Nothing 'oculto pestaña 1
                    TabPage2.Parent = TabControl1 'pongo visible pestaña 2
                    TabControl1.SelectedTab = TabPage2

                    'LIMPIAR LA GRILLA DE PROD AGREGADOS
                    'DataG_lista.DataSource = Nothing
                    DataGridView1.DataSource = Nothing
                    Call habilitar_columnas_edicion()
                    Call Obtener_Productos_Combos()
                    'tx_cantidad.Text = 1

                    '/////////////////////////////////////////////////////////////////////////
                    'esto va en el evento load del nuevo diseño del modulo
                    DataGridView1.Rows.Add()
                    DataGridView1.Focus()
                    DataGridView1.Rows(0).Cells("columna_codinterno").Selected = True
                    obtener_usuario_y_sucursal() 'esto info se carga en los grupbox de la segunda pestaña
                    'FILA = 0
                    'CELDA = 2
                    ' DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
                    ComboBox_iva.SelectedIndex = 0
                    Label_tipo_vta.Text = "Venta " + tipo_vta

                Else
                    MessageBox.Show("Error, seleccione un cliente", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Error, Debe seleccionar un cliente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            
        Else
            GroupBox12.Enabled = True 'habilito la pestaña 2
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            TabPage1.Parent = Nothing 'oculto pestaña 1
            TabPage2.Parent = TabControl1 'pongo visible pestaña 2
            TabControl1.SelectedTab = TabPage2
            'LIMPIAR LA GRILLA DE PROD AGREGADOS
            'DataG_lista.DataSource = Nothing
            DataGridView1.DataSource = Nothing
            Call habilitar_columnas_edicion()
            Call Obtener_Productos_Combos()
            'tx_cantidad.Text = 1

            '///////////////////////////////////////////////////////////////////////////////////
            'esto va en el evento load del nuevo diseño del modulo
            DataGridView1.Rows.Add()
            DataGridView1.Focus()
            DataGridView1.Rows(0).Cells("columna_codinterno").Selected = True
            obtener_usuario_y_sucursal() 'esto info se carga en los grupbox de la segunda pestaña
            'FILA = 0
            'CELDA = 2
            ' DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
            ComboBox_iva.SelectedIndex = 0
            Label_tipo_vta.Text = "Venta " + tipo_vta
        End If
        
    End Sub
    Private Sub RB_Si_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Si.CheckedChanged
        If RB_Si.Checked = True Then
            Call Obtener_combo()
        End If
    End Sub
    Private Sub BO_Modificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Modificar.Click
        'If DG_clientes.CurrentRow.Selected = True Then
        '    Cliente_modificar.TX_doc.Text = DG_clientes.CurrentRow.Cells("CLIdniDataGridViewTextBoxColumn").Value
        'End If
        'llamar_Form(Cliente_modificar, Me)
    End Sub
    Private Sub RB_No_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_No.CheckedChanged
        If RB_No.Checked = True Then

            CB_lista.DataSource = Nothing
            CB_lista.Items.Add("Defecto")
            CB_lista.SelectedIndex = 0
        End If
    End Sub
    Private Sub Buscar_cod_interno_y_agregar(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras

        '    'cuando presiono enter busco el prod o combo en el dataset...DS_PROD

        '    If TX_busc_codinterno.Text <> "" Then
        '        Dim i As Integer = 0
        '        Dim encontrado As String = "No"
        '        Dim T As Integer = 0
        '        If RB_No.Checked = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
        '            T = 1
        '        End If

        '        While i < VentaGestion_DS_PROD.Tables(T).Rows.Count
        '            Dim cod_interno As String = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
        '            If TX_busc_codinterno.Text = cod_interno Then
        '                'primero verifico que el producto q ingreso no este ya en la grilla
        '                Dim item = 0
        '                Dim presente = "no"
        '                Dim fila_editar = 0
        '                While item < DataG_lista.Rows.Count
        '                    If DataG_lista.Rows(item).Cells(2).Value = TX_busc_codinterno.Text Then
        '                        presente = "si"
        '                        fila_editar = item
        '                    End If
        '                    item = item + 1
        '                End While
        '                'ahora veo de agregar o editar
        '                If presente = "no" Then
        '                    'agrego una nueva fila
        '                    Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
        '                    newCustomersRow("PROD_id") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_id").ToString
        '                    newCustomersRow("codinterno") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
        '                    If RB_No.Checked = True Then
        '                        newCustomersRow("descripcion") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString
        '                    Else
        '                        newCustomersRow("descripcion") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString + " " + "x" + VentaGestion_DS_PROD.Tables(T).Rows(i).Item("Lista_Prod_cantidad").ToString
        '                    End If
        '                    newCustomersRow("detalle") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descrilarga").ToString

        '                    If tx_cantidad.Text = "" Then
        '                        tx_cantidad.Text = CInt(1)
        '                    End If
        '                    Dim cant As Integer = CInt(tx_cantidad.Text)
        '                    newCustomersRow("cantidad") = cant
        '                    newCustomersRow("precio_unitario") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta")
        '                    Dim total As Decimal = 0
        '                    total = cant * CDec(VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta"))
        '                    newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
        '                    newCustomersRow("codbarra") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
        '                    Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
        '                    DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        '                    Dim a As Integer = DataG_lista.Rows.Count
        '                    DataG_lista.Rows(a - 1).Cells(0).Value = a
        '                Else

        '                    'edito una fila existente, solo si el usuario lo desea, pregunta!!!
        '                    'Dim result As DialogResult
        '                    'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '                    'If result = DialogResult.OK Then
        '                    If tx_cantidad.Text = "" Then
        '                        tx_cantidad.Text = CInt(1)
        '                    End If
        '                    Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
        '                    'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
        '                    DataG_lista.Rows(fila_editar).Cells(5).Value = cant
        '                    Dim total As Decimal = 0
        '                    total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
        '                    DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
        '                    ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
        '                    'Dim result As DialogResult
        '                    'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '                    'If result = DialogResult.OK Then
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
        '                    'End If
        '                End If
        '                encontrado = "Si"
        '            End If
        '            i = i + 1
        '        End While
        '        If encontrado = "No" Then
        '            i = 0
        '            'lo busco como promocion
        '            While i < VentaGestion_ds_PROMO.Tables(0).Rows.Count
        '                Dim cod_interno As String = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '                If TX_busc_codinterno.Text.ToUpper = cod_interno Then
        '                    'primero verifico que el producto q ingreso no este ya en la grilla
        '                    Dim item = 0
        '                    Dim presente = "no"
        '                    Dim fila_editar = 0
        '                    While item < DataG_lista.Rows.Count
        '                        If DataG_lista.Rows(item).Cells(2).Value = TX_busc_codinterno.Text.ToUpper Then
        '                            presente = "si"
        '                            fila_editar = item
        '                        End If
        '                        item = item + 1
        '                    End While
        '                    'ahora veo de agregar o editar
        '                    If presente = "no" Then
        '                        'agrego una nueva fila
        '                        Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
        '                        newCustomersRow("PROD_id") = CStr("0")
        '                        newCustomersRow("codinterno") = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '                        newCustomersRow("descripcion") = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
        '                        'newCustomersRow("detalle") = 
        '                        If tx_cantidad.Text = "" Then
        '                            tx_cantidad.Text = CInt(1)
        '                        End If
        '                        Dim cant As Integer = CInt(tx_cantidad.Text)
        '                        newCustomersRow("cantidad") = cant
        '                        newCustomersRow("precio_unitario") = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total")

        '                        Dim total As Decimal = 0
        '                        total = cant * CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
        '                        newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
        '                        newCustomersRow("codbarra") = " "
        '                        Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
        '                        DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        '                        Dim a As Integer = DataG_lista.Rows.Count
        '                        DataG_lista.Rows(a - 1).Cells(0).Value = a

        '                    Else
        '                        'edito una fila existente, solo si el usuario lo desea, pregunta!!!
        '                        'Dim result As DialogResult
        '                        'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '                        'If result = DialogResult.OK Then
        '                        If tx_cantidad.Text = "" Then
        '                            tx_cantidad.Text = CInt(1)
        '                        End If
        '                        Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
        '                        'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
        '                        DataG_lista.Rows(fila_editar).Cells(5).Value = cant
        '                        Dim total As Decimal = 0
        '                        total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
        '                        DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
        '                        'End If
        '                    End If
        '                    encontrado = "Si"
        '                End If
        '                i = i + 1
        '            End While
        '            If encontrado = "No" Then
        '                MsgBox("no existe")
        '                TX_busc_codinterno.SelectAll()
        '            Else

        '                tx_cantidad.Text = "1"
        '                'tx_cantidad.Focus()
        '                'tx_cantidad.SelectAll()
        '                TX_busc_codinterno.Text = ""
        '                TX_busc_codinterno.Focus()
        '                TX_busc_codinterno.SelectAll()
        '            End If
        '        Else
        '            tx_cantidad.Text = "1"
        '            TX_busc_codinterno.Text = ""
        '            TX_busc_codinterno.Focus()
        '            TX_busc_codinterno.SelectAll()
        '            'tx_cantidad.Focus()
        '            'tx_cantidad.SelectAll()
        '        End If
        '    End If
        '    calcular_totales()
        'End If
    End Sub
    Private Sub TX_busc_codinterno_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'TX_busc_codinterno.BackColor = Color.Aquamarine
    End Sub
    Private Sub TX_busc_codinterno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'TX_busc_codinterno.BackColor = Color.White
    End Sub
    Private Sub tx_cantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'tx_cantidad.BackColor = Color.Aquamarine
    End Sub
    Private Sub tx_cantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If RB_CodInterno.Checked = True Then
        '    TX_busc_codinterno.Focus()
        '    TX_busc_codinterno.SelectAll()
        'Else
        '    TX_busc_codibarra.Focus()
        '    TX_busc_codibarra.SelectAll()
        'End If
        'tx_cantidad.BackColor = Color.White
    End Sub


    Private Sub TX_busc_codinterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
        '    tx_cantidad.Focus()
        'End If
    End Sub



    Private Sub tx_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
                If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                    e.Handled = True
                End If
            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            Buscar_cod_interno_y_agregar(e)
        End If
    End Sub

    Private Sub BO_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'guardo los indices de la celda actual
        Busqueda_Productos.form_procedencia = "Venta_Caja_gestion"
        'Busqueda_Productos.BO_agregar.Visible = False
        Busqueda_Productos.Show()
        'Busqueda_Productos.tx_Buscar.Focus()
    End Sub


    Dim APcaja As New Aplicacion.Caja 'la uso para validar la apertura de caja entre otras cosas

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If txt_total.Text <> "" Then
            If DataG_listaTotal.Rows.Count > 0 And CDec(txt_total.Text) <> CDec(0) Then
                If procedencia = "Venta_Caja_Gestion" Then
                    Forma_de_pago_seleccion.Show()
                Else
                    If procedencia = "Remito nuevo" Then
                        Dim result As DialogResult
                        result = MessageBox.Show("¿Desea generar el remito?", "Sistema de Gestión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If result = DialogResult.OK Then
                            'aqui llamo a la rutina que guarda, pero no va a caja, y el estado de la tabla ventaproducto es "pendiente"
                            'de momento voy a hacer que reste stock, despues consultamos eso. puede q se deba sumar stock en caso de devolucion. o edicion del remito.
                            guardar_remito()
                        End If
                    End If
                    If procedencia = "Remito modificar" Then
                        'aqui actualizo, y si el usuario desea se genera la factura, ahi indico las formas de pago.
                        If MessageBox.Show("¿Quiere actualizar el remito?.", "Sistem de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            Dim venta_tipo_descripcion As String
                            If tipo_vta = "Minorista" Then
                                venta_tipo_descripcion = "Venta Minorista-Efectivo"
                            Else
                                venta_tipo_descripcion = "Venta Mayorista-Efectivo"
                            End If
                            Dim vendedor_id As Integer = CInt(ComboBox_vendedor.SelectedValue)

                            Dim ds_cuentacorrente As DataSet = DActacte.CtaCte_buscar_Cliente(remito_cliente_id)
                            If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                                'valido que el monto total no exceda el limite de deuda
                                Dim limite_deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_limitedeuda"))
                                Dim deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) + CDec(txt_total.Text)
                                If (deuda <= limite_deuda) Or limite_deuda = 0 Then
                                    DAventa.Remito_productos_modificar(remito_ventaprod_id, CDec(txt_total.Text),
                                                             USU_id_gen_remito,
                                                             "Cliente",
                                                             remito_cliente_id, CDec(txt_subtotal.Text),
                                                             CDec(txt_descuento.Text),
                                                             CDec(txt_desc_porc.Text),
                                                             CDec(ComboBox_iva.SelectedItem),
                                                              CDec(txt_impuesto_aplicado.Text), venta_tipo_descripcion, 0, vendedor_id, "Pendiente")
                                    'Actualizar Stock
                                    Actualizar_stock_remito() 'suma y resta cantidades

                                    'primero elimino los registros q tenia en la tabla venta_producto_detalle
                                    DAventa.VentaProductoDetalle_eliminar(remito_ventaprod_id)

                                    'ACTUALIZAR EN TABLA "Venta_Producto_detalle"
                                    For Each row As DataGridViewRow In DataGridView1.Rows
                                        If row.Cells("columna_prod_id").Value <> 0 Then
                                            DAventa.VentaProductoDetalle_alta(remito_ventaprod_id, row.Cells(1).Value, row.Cells(5).Value, CDec(row.Cells(7).Value), CDec(row.Cells(8).Value), row.Cells(3).Value, row.Cells(2).Value, 0, CDec(row.Cells(6).Value))
                                        End If
                                    Next

                                    'aqui va la llamada al reporte.


                                    MessageBox.Show("El remito se modificó correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    'If MessageBox.Show("¿Desea registrar ingreso y generar factura?.", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                                    '    APcaja.Caja_Validar()
                                    '    If APcaja.SESION_CAJA = 1 And US_administrador.no_caja <> "deshabilitar" Then '1 = caja nueva, lista para iniciar
                                    '        MessageBox.Show("Error!,primero debe abrir la caja diaria para registrar la venta", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                    '        'Caja_abrir_turno.Close()
                                    '        'Caja_abrir_turno.Show()
                                    '    Else
                                    '        If APcaja.SESION_CAJA = 2 And US_administrador.no_caja <> "deshabilitar" Then
                                    '            'por aqui continuo con el registro de la factura
                                    '            facturar = "si" 'valido esto en el form de caja pago, caja tarjeta y forma de pago seleccion.
                                    '            Forma_de_pago_seleccion.Show()
                                    '        Else
                                    '            MessageBox.Show("Error!, No puede registrar la venta, la caja actual esta siendo utilizada por el usuario: " + US_administrador.apellidoynombre, "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    '        End If
                                    '    End If
                                    'Else
                                    '    facturar = "no"
                                    'End If
                                Else
                                    MessageBox.Show("La venta excede el limite de deuda para la cuenta corriente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                MessageBox.Show("No se registraron productos", "Sistema de Gestión.")
            End If
        Else
            MessageBox.Show("No se registraron productos", "Sistema de Gestión.")
        End If
    End Sub

    Private Sub Actualizar_stock_remito() 'lo uso cuando entro a editar un remito.
        'primero actualizo stock + con los valores anteriores del remito.
        Dim ds_rem_prod As DataSet = DAventa.Remito_recuperar_productos(remito_id)
        Dim sucursal_id As Integer
        Dim h As Integer = 0
        While h < ds_rem_prod.Tables(0).Rows.Count
            Dim prod_codigo As Integer = ds_rem_prod.Tables(0).Rows(h).Item("codigointerno")
            sucursal_id = ds_rem_prod.Tables(0).Rows(h).Item("sucursal_id")
            Dim ds_stock As DataSet = DAproducto.Producto_x_sucursal_buscarcod(prod_codigo, sucursal_id)
            If ds_stock.Tables(0).Rows.Count <> 0 Then
                Dim diferencia As Decimal = CDec(ds_stock.Tables(0).Rows(0).Item("ProdxSuc_stock")) + CDec(ds_rem_prod.Tables(0).Rows(h).Item("ventaprod_cant"))
                If diferencia < 0 Then
                    diferencia = 0
                End If
                Dim diferencia_gondola As Integer = 0
                Dim cantidad As Integer = 0
                        DAventa.Venta_actualizar_stock_Caja(prod_codigo, diferencia, diferencia_gondola, sucursal_id)
            End If
            h = h + 1
        End While



        'luego actualizo con el pedido nuevo.
        h = 0
        sucursal_id = ds_rem_prod.Tables(0).Rows(0).Item("sucursal_id")
        While h < DataGridView1.Rows.Count
            Dim prod_codigo As Integer = 0
            If DataGridView1.Rows(h).Cells("columna_codinterno").Value <> "0" Then
                prod_codigo = CInt(DataGridView1.Rows(h).Cells("columna_codinterno").Value)
            End If
            Dim ds_stock As DataSet = DAproducto.Producto_x_sucursal_buscarcod(prod_codigo, sucursal_id)
            If ds_stock.Tables(0).Rows.Count <> 0 Then
                Dim diferencia As Decimal = CDec(ds_stock.Tables(0).Rows(0).Item("ProdxSuc_stock")) - CDec(DataGridView1.Rows(h).Cells("columna_cantidad").Value)
                If diferencia < 0 Then
                    diferencia = 0
                End If
                Dim diferencia_gondola As Integer = 0
                Dim cantidad As Integer = 0
                DAventa.Venta_actualizar_stock_Caja(prod_codigo, diferencia, diferencia_gondola, sucursal_id)
                'MsgBox("actualizo stock de", prod_codigo)
            End If
            h = h + 1
        End While
    End Sub

    Private Sub guardar_remito()
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        'Dim tipo_vta As String = "Cliente"
        Dim vendedor_id As Integer = CInt(ComboBox_vendedor.SelectedValue)
        Dim cliente_id As String = DG_clientes.CurrentRow.Cells(0).Value
        Dim venta_tipo_descripcion As String = ""
        If tipo_vta = "Minorista" Then
            venta_tipo_descripcion = "Venta Minorista-Cta. Cte."
        Else
            venta_tipo_descripcion = "Venta Mayorista-Cta. Cte."
        End If
        Dim ds_cuentacorrente As DataSet = DActacte.CtaCte_buscar_Cliente(cliente_id)
        If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
            'valido que el monto total no exceda el limite de deuda
            Dim limite_deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_limitedeuda"))
            Dim deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) + CDec(txt_total.Text)
            If (deuda <= limite_deuda) Or (limite_deuda = 0) Then
                Dim ds_Venta As DataSet = DAventa.VentaProducto_alta(CDec(txt_total.Text),
                             Now,
                             usuario_id,
                             "Cliente",
                             cliente_id, CDec(txt_subtotal.Text),
                             CDec(txt_descuento.Text),
                             CDec(txt_desc_porc.Text),
                             CDec(ComboBox_iva.SelectedItem),
                              CDec(txt_impuesto_aplicado.Text), venta_tipo_descripcion, 0, vendedor_id, "Pendiente")
                Dim ventaprod_id As Integer = CInt(ds_Venta.Tables(0).Rows(0).Item("ventaprod_id"))

                Dim ds_factura As DataSet = DAventa.Remito_alta(ventaprod_id, Now, "pendiente entrega")
                Dim remito_id As Integer = CInt(ds_factura.Tables(0).Rows(0).Item("remito_id"))


                '////////////////aqui cargamos en cuenta corriente, si corresponde - CHOCO: 03-12-2019//////////////////
                'tiene cuenta y genera deuda.
                'Dim CtaCte_id As Integer = ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_id")
                'DAcuentacorriente.CtaCte_registrar_egreso(CtaCte_id, deuda)
                'DAcuentacorriente.Venta_CtaCte_alta(factura_id, CtaCte_id)
                'Dim concepto As String = "Comprobante Nº: " + CStr(factura_id)
                'DAcuentacorriente.CtaCte_movimiento_alta(CtaCte_id, "Egreso", concepto, CDec(Venta_Caja_gestion.txt_total.Text), Now)
                '//////////////////////////////////////////////////////////////////////////////////
                'GUARDAR EN TABLA "Venta_Producto_detalle"
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells("columna_prod_id").Value <> 0 Then
                        DAventa.VentaProductoDetalle_alta(ventaprod_id, row.Cells(1).Value, row.Cells(5).Value, CDec(row.Cells(7).Value), CDec(row.Cells(8).Value), row.Cells(3).Value, row.Cells(2).Value, 0, CDec(row.Cells(6).Value))
                    End If
                Next
                'aqui hago el descuento de stock...
                'primero de los productos ....luego de los combos...(ya q estan formados por varios productos)
                Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
                Dim sucursal_id As Integer = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
                Dim i As Integer = 0
                Dim ds_stock As New DataSet
                While i < DataGridView1.Rows.Count
                    Dim prod_codigo As Integer = 0
                    If DataGridView1.Rows(i).Cells("columna_codinterno").Value <> "0" Then
                        prod_codigo = CInt(DataGridView1.Rows(i).Cells("columna_codinterno").Value)
                    End If
                    ds_stock = DAproducto.Producto_x_sucursal_buscarcod(prod_codigo, sucursal_id)
                    If ds_stock.Tables(0).Rows.Count <> 0 Then
                        Dim diferencia As Decimal = CDec(ds_stock.Tables(0).Rows(0).Item("ProdxSuc_stock")) - CDec(DataGridView1.Rows(i).Cells("columna_cantidad").Value)
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
                        If DataGridView1.Rows(i).Cells("columna_cantidad").Value <> "0" Then
                            'primero lo busco como combo.
                            'aqui veo si ponerle el indice _tabla en 2 o 3...dependiendo del procedimiento q tome los recursos el DS_PROD...
                            'son 2 las rutinas....Venta_obtenerProducto_listaregular y [Venta_obtenerProducto_Combos]
                            Dim indice_tabla As Integer = 0
                            If RB_Si.Checked = False Then
                                indice_tabla = 3
                            Else
                                indice_tabla = 2
                            End If
                            'id del combo
                            Dim ProdCombo_id As Integer = CInt(DataGridView1.Rows(i).Cells("columna_codinterno").Value)
                            Dim cantidad_combos As Integer = CInt(DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                            Dim j As Integer = 0
                            While j < VentaGestion_DS_PROD.Tables(indice_tabla).Rows.Count
                                If ProdCombo_id = VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdCombo_id") Then
                                    Dim prod_id As Integer = VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("prod_id")
                                    Dim cantidad_item As Integer = CInt(VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdComboDet_cantidad"))
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
                            Dim LISTA_codinterno As String = (DataGridView1.Rows(i).Cells("columna_prod_id").Value)
                            Dim cantidad_PROMOS As Integer = CInt(DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                            Dim LISTA_ID As Integer = 0
                            'Busco el id de la promocion en el ds_promo
                            Dim ii As Integer = 0
                            While ii < VentaGestion_ds_PROMO.Tables(0).Rows.Count
                                If LISTA_codinterno = VentaGestion_ds_PROMO.Tables(0).Rows(ii).Item("LISTA_codinterno") Then
                                    LISTA_ID = VentaGestion_ds_PROMO.Tables(0).Rows(ii).Item("LISTA_id")
                                End If
                                ii = ii + 1
                            End While
                            'Venta_Caja_gestion.Actualizar_Stock_Promocion(LISTA_ID, cantidad_PROMOS)
                        End If
                    End If
                    i = i + 1
                End While
                'aqui llamo a la rutina que me muestra el reporte.
                crear_reporte(ds_usuario, remito_id)
                MessageBox.Show("El Remito se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'aqui van las rutinas q borran grilla de venta_caja_gestion y dejan todo listo para prox venta.
                Limpiar()
            Else
                MessageBox.Show("La venta excede el limite de deuda para la cuenta corriente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    'Dim DAcliente As New Datos.Cliente
    Dim facturacion_ds_report As New Facturacion_ds_report
    Private Sub crear_reporte(ByVal ds_usuario As DataSet, ByVal numerofactura As Integer)
        'pregunto si quiero ver el reporte 
        'Dim result As DialogResult
        'result = MessageBox.Show("¿Desea ver el remito generado?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        'If result = DialogResult.OK Then
        'primero lleno el dataset y sus respectivas table

        '///////////////TABLA CLIENTE//////////////////////////////////'
        facturacion_ds_report.Tables("Cliente").Rows.Clear()
        If lb_dni_clie.Text <> "- - - -" Then

            Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni((lb_dni_clie.Text))
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
            row_cliente("fantasia") = lb_fantasia.Text
            row_cliente("dni") = lb_dni_clie.Text
            row_cliente("telefono") = lb_telef_clie.Text
            row_cliente("mail") = lb_mail_clie.Text
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
            row_cliente("mail") = lb_mail_clie.Text
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
        row_sucursal("sucursal") = lb_nombre_sucursal.Text
        row_sucursal("direccion") = lb_direccion_sucursal.Text
        row_sucursal("telefono") = lb_telefono_sucursal.Text
        row_sucursal("mail") = lb_mail_sucursal.Text
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
        row_venta("vendedor") = lb_vendedor_vta.Text
        row_venta("tipo_venta") = "Cliente"
        facturacion_ds_report.Tables("venta").Rows.Add(row_venta)

        '///////////////TABLA TOTALES APLICADOS//////////////////////////////////'
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Clear()
        Dim row_totales As DataRow = facturacion_ds_report.Tables("Totales_aplicados").NewRow()
        row_totales("subtotal") = txt_subtotal.Text
        row_totales("total") = txt_total.Text
        row_totales("iva") = CDec(ComboBox_iva.SelectedItem)
        row_totales("descuento_porcentaje") = CDec(txt_desc_porc.Text)
        row_totales("descuento_pesos") = CDec(txt_desc_pesos.Text)
        row_totales("iva_pesos") = CDec(txt_impuesto_aplicado.Text)
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)

        '///////////////TABLA PRODUCTO AGREGADO//////////////////////////////////'
        'aqui ciclo en la grilla para ir agrendo los row a la tabla producto agregado
        facturacion_ds_report.Tables("Producto_agregado").Rows.Clear()
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells("columna_descripcion").Value <> "" Then
                Dim row_prodADD As DataRow = facturacion_ds_report.Tables("Producto_agregado").NewRow()
                row_prodADD("PROD_id") = DataGridView1.Rows(i).Cells("columna_prod_id").Value
                row_prodADD("codinterno") = CInt(DataGridView1.Rows(i).Cells("columna_codinterno").Value)
                row_prodADD("descripcion") = DataGridView1.Rows(i).Cells("columna_descripcion").Value
                row_prodADD("detalle") = DataGridView1.Rows(i).Cells("columna_detalle").Value
                row_prodADD("cantidad") = CDec(DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                row_prodADD("precio_unitario") = CDec(DataGridView1.Rows(i).Cells("columna_precio_unitario").Value)
                row_prodADD("precio_subtotal") = CDec(DataGridView1.Rows(i).Cells("columna_precio_subtotal").Value)
                row_prodADD("codbarra") = ""
                row_prodADD("TURNO_id") = ""
                '/choco modificacion 01-12-2019: agrego columna descuento
                row_prodADD("descuento") = CDec(DataGridView1.Rows(i).Cells("descuento").Value)
                row_prodADD("grupo_id") = CInt(1)
                facturacion_ds_report.Tables("Producto_agregado").Rows.Add(row_prodADD)
            End If
            i = i + 1
        End While


        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Facturacion\Reportes\CR_remito.rpt")
        CrReport.Database.Tables("Cliente").SetDataSource(facturacion_ds_report.Tables("Cliente"))
        CrReport.Database.Tables("Sucursal").SetDataSource(facturacion_ds_report.Tables("Sucursal"))
        CrReport.Database.Tables("Empresa").SetDataSource(facturacion_ds_report.Tables("Empresa"))
        CrReport.Database.Tables("venta").SetDataSource(facturacion_ds_report.Tables("venta"))
        CrReport.Database.Tables("Producto_agregado").SetDataSource(facturacion_ds_report.Tables("Producto_agregado"))
        CrReport.Database.Tables("Totales_aplicados").SetDataSource(facturacion_ds_report.Tables("Totales_aplicados"))
        Dim remito_report As New Facturacion_report_show
        remito_report.CrystalReportViewer1.ReportSource = CrReport
        remito_report.Text = "Remito Nº: " + CStr(numerofactura) + " - Imprimir."
        remito_report.Show()
        'End If
    End Sub




    Public Sub formas_de_pago(ByVal forma As String)
        If forma = "efectivo" Then
            If DataG_listaTotal.Rows.Count > 0 And txt_total.Text <> "" Then
                'Pago_caja.tx_total.Text = CDec(DataG_listaTotal.Rows(0).Cells(1).Value) 'total
                Pago_caja.tx_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
                Pago_caja.tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))
                Pago_caja.Show()
            Else
                MessageBox.Show("No se registraron productos", "Sistema de Gestion.")
            End If
            'Dim ruta As String
            'ruta = Application.StartupPath & "\..\..\Sonido\Gallega actualizada.wav"
            'My.Computer.Audio.Play(ruta, AudioPlayMode.Background)
        End If
        If forma = "tarjeta" Then
            Pago_tarjeta.tx_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            Pago_tarjeta.Show()
        End If

    End Sub


    Public Function distancia(ByVal x1 As Integer, ByVal x2 As Integer, ByVal y1 As Integer, ByVal y2 As Integer)




        Dim result As Integer = 0

        Return result
    End Function


    Public Sub Actualizar_Stock_Promocion(ByVal LISTA_ID As Integer, ByVal cantidad_PROMOS As Integer)
        Dim ds As DataSet = DAlista.Lista_Promocion_obtener_items(LISTA_ID)
        Dim I As Integer = 0
        While I < ds.Tables(0).Rows.Count
            Dim prod_codigo As Integer = CInt(ds.Tables(0).Rows(I).Item("prod_codinterno"))
            Dim ds_stock As DataSet = DAproducto.Producto_buscarcod(prod_codigo)
            If ds_stock.Tables(0).Rows.Count <> 0 Then
                Dim cantidad_item As Integer = CInt(ds.Tables(0).Rows(I).Item("Lista_Prod_cantidad"))
                Dim cantidad_total As Integer = CInt(cantidad_PROMOS * cantidad_item)
                Dim diferencia As Integer = CInt(ds_stock.Tables(0).Rows(0).Item("prod_stock")) - cantidad_total
                Dim diferencia_gondola As Integer = CInt(ds_stock.Tables(1).Rows(0).Item("prod_gondola")) - cantidad_total
                DAventa.Venta_actualizar_stock_Caja(prod_codigo, diferencia, diferencia_gondola, 0)
                'MsgBox("actualizo stock de producto en PROMOCION", prod_codigo)
            End If
            I = I + 1
        End While
        I = 0
        While I < ds.Tables(1).Rows.Count
            Dim ProdCombo_id As Integer = CInt(ds.Tables(1).Rows(I).Item("prod_id"))
            Dim cantidad_combos As Integer = CInt(ds.Tables(1).Rows(I).Item("Lista_Prod_cantidad"))
            Dim j As Integer = 0
            While j < ds.Tables(2).Rows().Count
                If ProdCombo_id = ds.Tables(2).Rows(j).Item("ProdCombo_id") Then
                    Dim prod_id As Integer = ds.Tables(2).Rows(j).Item("prod_id")
                    Dim cantidad_item As Integer = CInt(ds.Tables(2).Rows(j).Item("ProdComboDet_cantidad"))
                    Dim ds_stocks As DataSet = DAproducto.Producto_buscar_id(prod_id)
                    Dim cantidad_total As Integer = CInt(cantidad_PROMOS * cantidad_combos * cantidad_item)
                    Dim diferencia As Integer = CInt(ds_stocks.Tables(0).Rows(0).Item("prod_stock")) - cantidad_total
                    Dim diferencia_gondola As Integer = CInt(ds_stocks.Tables(1).Rows(0).Item("prod_gondola")) - cantidad_total
                    DAventa.Venta_actualizar_stock_Caja_2(prod_id, diferencia, diferencia_gondola)
                    'MsgBox("actualizo stock de combo en PROMOCION")
                End If
                j = j + 1
            End While
            I = I + 1
        End While
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If procedencia = "Remito modificar" Then
            Remito.Show()
            Me.Close()

        Else
            Limpiar()
        End If
    End Sub

    Private Sub Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitar.Click
        ''aqui elimino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"

        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.

        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("Column1").Value = True And DataGridView1.Rows(i).Cells("columna_codinterno").Value <> "" Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        If MsgBox("Esta seguro que quiere borrar la informacion del item seleccionado?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
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
                        calcular_totales()
                        aplicar_iva()
                    End If
                Else

                    i = i + 1
                End If

            End While
            If pregunta = "no" Then
                MsgBox("Debe Seleccionar un producto de la grilla", MsgBoxStyle.OkOnly, "Sistema de Gestion")
            End If

            'ahora si me queda la grilla vacia..agrero un row para q pueda escribir
            If DataGridView1.Rows.Count = 0 Then
                DataGridView1.Rows.Add()
                DataGridView1.Focus()
                DataGridView1.Rows(0).Cells("columna_codinterno").Selected = True
            End If

        End If




        'If DataG_lista.Rows.Count <> 0 Then
        '    'If DataG_lista.CurrentRow.Cells(0).Value <> "" Then
        '    'If MsgBox("Esta seguro que quiere borrar la informacion del item seleccionado?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
        '    'primero guardo el nro de item q contiene
        '    Dim item As Decimal = DataG_lista.CurrentRow.Index


        '    If DataG_lista.CurrentRow.Cells(5).Value = "1" Then

        '        'DataG_lista.Rows.RemoveAt(DataG_lista.CurrentRow.Index)
        '        Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Delete()
        '        DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        '        'cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
        '        Dim a As Integer = 0
        '        While a < DataG_lista.Rows.Count
        '            DataG_lista.Rows(a).Cells(0).Value = a + 1
        '            a = a + 1
        '        End While
        '        calcular_totales()
        '    Else
        '        Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("cantidad") = Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("cantidad") - 1
        '        Dim total As Decimal = 0
        '        total = Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("cantidad") * CDec(Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("precio_unitario"))
        '        Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
        '        DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        '        calcular_totales()
        '    End If


        '    'este codigo si va
        '    'Call Cargar_Totales(añosdelproyecto)
        '    'modificado = 1
        '    'End If
        '    'End If
        'End If
        'DataG_lista.Refresh()

        ' ''aqui elemino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"
        ''If DataG_lista.Rows.Count <> 0 Then
        ''    'If DataG_lista.CurrentRow.Cells(0).Value <> "" Then
        ''    If MsgBox("Esta seguro que quiere borrar la informacion del item seleccionado?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
        ''        'primero guardo el nro de item q contiene
        ''        Dim item As Decimal = DataG_lista.CurrentRow.Index
        ''        DataG_lista.Rows.RemoveAt(item)
        ''        'cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
        ''        Dim a As Integer = 0
        ''        While a < DataG_lista.Rows.Count
        ''            DataG_lista.Rows(a).Cells(0).Value = a + 1
        ''            a = a + 1
        ''        End While
        ''        calcular_totales()
        ''        'este codigo si va
        ''        'Call Cargar_Totales(añosdelproyecto)
        ''        'modificado = 1
        ''    End If
        ''    'End If
        ''End If
        ''DataG_lista.Refresh()

    End Sub


    Private Sub RB_CodInterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If RB_CodInterno.Checked = True Then
        '    TX_busc_codinterno.TabIndex = 0
        '    TX_busc_codibarra.TabIndex = 255
        '    TX_busc_codinterno.Enabled = True
        '    TX_busc_codinterno.Focus()
        '    TX_busc_codinterno.SelectAll()
        '    TX_busc_codibarra.Enabled = False
        'End If
    End Sub

    Private Sub RB_CodBarra_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If RB_CodBarra.Checked = True Then
        '    TX_busc_codibarra.TabIndex = 0
        '    TX_busc_codinterno.TabIndex = 255
        '    TX_busc_codibarra.Enabled = True
        '    TX_busc_codibarra.Focus()
        '    TX_busc_codibarra.SelectAll()
        '    TX_busc_codinterno.Enabled = False
        'End If
    End Sub

    Private Sub TX_busc_codibarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras

        '    'cuando presiono enter busco el prod o combo en el dataset...DS_PROD

        '    If TX_busc_codibarra.Text <> "" Then
        '        Dim i As Integer = 0
        '        Dim encontrado As String = "No"
        '        Dim T As Integer = 0
        '        If RB_No.Checked = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
        '            T = 1
        '        End If

        '        While i < VentaGestion_DS_PROD.Tables(T).Rows.Count
        '            Dim cod_barra As String = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
        '            Dim cod_interno As String = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
        '            If TX_busc_codibarra.Text = cod_barra Then
        '                'primero verifico que el producto q ingreso no este ya en la grilla
        '                Dim item = 0
        '                Dim presente = "no"
        '                Dim fila_editar = 0
        '                While item < DataG_lista.Rows.Count
        '                    If CStr(DataG_lista.Rows(item).Cells("codbarra").Value) = TX_busc_codibarra.Text Then
        '                        presente = "si"
        '                        fila_editar = item
        '                    End If
        '                    item = item + 1
        '                End While
        '                'ahora veo de agregar o editar
        '                If presente = "no" Then
        '                    'agrego una nueva fila
        '                    Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
        '                    newCustomersRow("PROD_id") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_id").ToString
        '                    newCustomersRow("codinterno") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
        '                    If RB_No.Checked = True Then
        '                        newCustomersRow("descripcion") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString
        '                    Else
        '                        newCustomersRow("descripcion") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString + " " + "x" + VentaGestion_DS_PROD.Tables(T).Rows(i).Item("Lista_Prod_cantidad").ToString
        '                    End If
        '                    newCustomersRow("detalle") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descrilarga").ToString
        '                    If tx_cantidad.Text = "" Then
        '                        tx_cantidad.Text = CInt(1)
        '                    End If
        '                    Dim cant As Integer = CInt(tx_cantidad.Text)
        '                    newCustomersRow("cantidad") = cant
        '                    newCustomersRow("precio_unitario") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta")
        '                    Dim total As Decimal = 0
        '                    total = cant * CDec(VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta"))
        '                    newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
        '                    newCustomersRow("codbarra") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString

        '                    Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
        '                    DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        '                    Dim a As Integer = DataG_lista.Rows.Count
        '                    DataG_lista.Rows(a - 1).Cells(0).Value = a
        '                Else


        '                    'edito una fila existente, solo si el usuario lo desea, pregunta!!!
        '                    'Dim result As DialogResult
        '                    'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '                    'If result = DialogResult.OK Then
        '                    If tx_cantidad.Text = "" Then
        '                        tx_cantidad.Text = CInt(1)
        '                    End If
        '                    Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
        '                    'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
        '                    DataG_lista.Rows(fila_editar).Cells(5).Value = cant
        '                    Dim total As Decimal = 0
        '                    total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
        '                    DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
        '                    'End If


        '                    ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
        '                    'Dim result As DialogResult
        '                    'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '                    'If result = DialogResult.OK Then
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
        '                    '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
        '                    'End If
        '                End If
        '                encontrado = "Si"
        '            End If
        '            i = i + 1
        '        End While
        '        If encontrado = "No" Then
        '            i = 0
        '            'lo busco como promocion
        '            'While i < ds_PROMO.Tables(0).Rows.Count
        '            '    Dim cod_interno As String = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '            '    If TX_busc_codinterno.Text.ToUpper = cod_interno Then
        '            '        'primero verifico que el producto q ingreso no este ya en la grilla
        '            '        Dim item = 0
        '            '        Dim presente = "no"
        '            '        Dim fila_editar = 0
        '            '        While item < DataG_lista.Rows.Count
        '            '            If DataG_lista.Rows(item).Cells(2).Value = TX_busc_codinterno.Text.ToUpper Then
        '            '                presente = "si"
        '            '                fila_editar = item
        '            '            End If
        '            '            item = item + 1
        '            '        End While
        '            '        'ahora veo de agregar o editar
        '            '        If presente = "no" Then
        '            '            'agrego una nueva fila
        '            '            Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
        '            '            newCustomersRow("PROD_id") = CStr("0")
        '            '            newCustomersRow("codinterno") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '            '            newCustomersRow("descripcion") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
        '            '            'newCustomersRow("detalle") = 
        '            '            Dim cant As Integer = 1
        '            '            newCustomersRow("cantidad") = cant
        '            '            newCustomersRow("precio_unitario") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_total")

        '            '            Dim total As Decimal = 0
        '            '            total = cant * CDec(ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
        '            '            newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
        '            '            Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
        '            '            DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        '            '            Dim a As Integer = DataG_lista.Rows.Count
        '            '            DataG_lista.Rows(a - 1).Cells(0).Value = a
        '            '        End If
        '            '        encontrado = "Si"
        '            '    End If
        '            '    i = i + 1
        '            'End While
        '            If encontrado = "No" Then
        '                MsgBox("no existe")
        '                TX_busc_codibarra.SelectAll()
        '            Else
        '                tx_cantidad.Text = "1"
        '                'tx_cantidad.Focus()
        '                'tx_cantidad.SelectAll()
        '                'TX_busc_codibarra.Text = ""
        '                TX_busc_codibarra.Focus()
        '                TX_busc_codibarra.SelectAll()

        '            End If
        '        Else
        '            tx_cantidad.Text = "1"
        '            'tx_cantidad.Focus()
        '            'tx_cantidad.SelectAll()

        '            'TX_busc_codibarra.Text = ""
        '            TX_busc_codibarra.Focus()
        '            TX_busc_codibarra.SelectAll()

        '        End If
        '    End If
        '    calcular_totales()
        'End If

    End Sub

    Private Sub TX_busc_codibarra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'tx_cantidad.Focus()
        'tx_cantidad.SelectAll()
    End Sub

    'Private Sub DataGridView2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    'cargo el producto buscado por codigo
    '    'If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras

    '    'cuando presiono enter busco el prod o combo en el dataset...DS_PROD
    '    If DataGridView2.Rows.Count <> 0 Then

    '        If DataGridView2.CurrentRow.Cells("codinterno").Value IsNot Nothing Then
    '            Dim i As Integer = 0
    '            Dim encontrado As String = "No"
    '            Dim T As Integer = 0
    '            If RB_No.Checked = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
    '                T = 1
    '            End If

    '            While i < VentaGestion_DS_PROD.Tables(T).Rows.Count
    '                Dim cod_interno As String = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
    '                If DataGridView2.CurrentRow.Cells("codinterno").Value = cod_interno Then
    '                    'primero verifico que el producto q ingreso no este ya en la grilla
    '                    Dim item = 0
    '                    Dim presente = "no"
    '                    Dim fila_editar = 0

    '                    While item < DataGridView2.Rows.Count
    '                        If DataGridView2.Rows(item).Cells(2).Value = DataGridView2.CurrentRow.Cells("codinterno").Value Then
    '                            presente = "si"
    '                            fila_editar = item
    '                        End If
    '                        item = item + 1
    '                    End While
    '                    'ahora veo de agregar o editar
    '                    If presente = "no" Then
    '                        'agrego una nueva fila
    '                        Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
    '                        newCustomersRow("PROD_id") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_id").ToString
    '                        newCustomersRow("codinterno") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
    '                        If RB_No.Checked = True Then
    '                            newCustomersRow("descripcion") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString
    '                        Else
    '                            newCustomersRow("descripcion") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString + " " + "x" + VentaGestion_DS_PROD.Tables(T).Rows(i).Item("Lista_Prod_cantidad").ToString
    '                        End If
    '                        newCustomersRow("detalle") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_descrilarga").ToString

    '                        If tx_cantidad.Text = "" Then
    '                            tx_cantidad.Text = CInt(1)
    '                        End If
    '                        Dim cant As Integer = CInt(tx_cantidad.Text)
    '                        newCustomersRow("cantidad") = cant
    '                        newCustomersRow("precio_unitario") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta")
    '                        Dim total As Decimal = 0
    '                        total = cant * CDec(VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta"))
    '                        newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
    '                        newCustomersRow("codbarra") = VentaGestion_DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
    '                        Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
    '                        DataGridView2.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
    '                        Dim a As Integer = DataGridView2.Rows.Count
    '                        DataGridView2.Rows(a - 1).Cells(0).Value = a
    '                    Else

    '                        'edito una fila existente, solo si el usuario lo desea, pregunta!!!
    '                        'Dim result As DialogResult
    '                        'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
    '                        'If result = DialogResult.OK Then
    '                        If tx_cantidad.Text = "" Then
    '                            tx_cantidad.Text = CInt(1)
    '                        End If
    '                        Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataGridView2.Rows(fila_editar).Cells(5).Value)
    '                        'DataGridView2.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
    '                        DataGridView2.Rows(fila_editar).Cells(5).Value = cant
    '                        Dim total As Decimal = 0
    '                        total = cant * CDec(DataGridView2.Rows(fila_editar).Cells(6).Value)
    '                        DataGridView2.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
    '                        ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
    '                        'Dim result As DialogResult
    '                        'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
    '                        'If result = DialogResult.OK Then
    '                        '    Lista_alta.DataGridView2.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
    '                        '    Lista_alta.DataGridView2.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
    '                        '    Lista_alta.DataGridView2.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
    '                        '    Lista_alta.DataGridView2.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
    '                        '    Lista_alta.DataGridView2.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
    '                        '    Lista_alta.DataGridView2.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
    '                        'End If
    '                    End If
    '                    encontrado = "Si"
    '                End If
    '                i = i + 1
    '            End While
    '            If encontrado = "No" Then
    '                i = 0
    '                'lo busco como promocion
    '                While i < VentaGestion_ds_PROMO.Tables(0).Rows.Count
    '                    Dim cod_interno As String = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
    '                    If DataGridView2.CurrentRow.Cells("codinterno").Value.ToUpper = cod_interno Then
    '                        'primero verifico que el producto q ingreso no este ya en la grilla
    '                        Dim item = 0
    '                        Dim presente = "no"
    '                        Dim fila_editar = 0
    '                        While item < DataGridView2.Rows.Count
    '                            If DataGridView2.Rows(item).Cells(2).Value = DataGridView2.CurrentRow.Cells("codinterno").Value.ToUpper Then
    '                                presente = "si"
    '                                fila_editar = item
    '                            End If
    '                            item = item + 1
    '                        End While
    '                        'ahora veo de agregar o editar
    '                        If presente = "no" Then
    '                            'agrego una nueva fila
    '                            Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
    '                            newCustomersRow("PROD_id") = CStr("0")
    '                            newCustomersRow("codinterno") = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
    '                            newCustomersRow("descripcion") = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
    '                            'newCustomersRow("detalle") = 
    '                            If tx_cantidad.Text = "" Then
    '                                tx_cantidad.Text = CInt(1)
    '                            End If
    '                            Dim cant As Integer = CInt(tx_cantidad.Text)
    '                            newCustomersRow("cantidad") = cant
    '                            newCustomersRow("precio_unitario") = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total")

    '                            Dim total As Decimal = 0
    '                            total = cant * CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
    '                            newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
    '                            newCustomersRow("codbarra") = " "
    '                            Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
    '                            DataGridView2.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
    '                            Dim a As Integer = DataGridView2.Rows.Count
    '                            DataGridView2.Rows(a - 1).Cells(0).Value = a

    '                        Else
    '                            'edito una fila existente, solo si el usuario lo desea, pregunta!!!
    '                            'Dim result As DialogResult
    '                            'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
    '                            'If result = DialogResult.OK Then
    '                            If tx_cantidad.Text = "" Then
    '                                tx_cantidad.Text = CInt(1)
    '                            End If
    '                            Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataGridView2.Rows(fila_editar).Cells(5).Value)
    '                            'DataGridView2.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
    '                            DataGridView2.Rows(fila_editar).Cells(5).Value = cant
    '                            Dim total As Decimal = 0
    '                            total = cant * CDec(DataGridView2.Rows(fila_editar).Cells(6).Value)
    '                            DataGridView2.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
    '                            'End If
    '                        End If
    '                        encontrado = "Si"
    '                    End If
    '                    i = i + 1
    '                End While
    '                If encontrado = "No" Then
    '                    MsgBox("no existe")
    '                    TX_busc_codinterno.SelectAll()
    '                Else

    '                    tx_cantidad.Text = "1"
    '                    'tx_cantidad.Focus()
    '                    'tx_cantidad.SelectAll()
    '                    TX_busc_codinterno.Text = ""
    '                    TX_busc_codinterno.Focus()
    '                    TX_busc_codinterno.SelectAll()
    '                End If
    '            Else
    '                tx_cantidad.Text = "1"
    '                TX_busc_codinterno.Text = ""
    '                TX_busc_codinterno.Focus()
    '                TX_busc_codinterno.SelectAll()
    '                'tx_cantidad.Focus()
    '                'tx_cantidad.SelectAll()
    '            End If
    '        End If
    '        calcular_totales()
    '        'End If
    '    End If
    'End Sub

    'aqui pruebo escribir en grilla




    'Private Sub generar_fila_grid()
    '    For i As Integer = 1 To 1
    '        Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
    '        newCustomersRow("PROD_id") = i
    '        newCustomersRow("codinterno") = "00000"
    '        newCustomersRow("descripcion") = ""
    '        newCustomersRow("detalle") = ""
    '        newCustomersRow("cantidad") = 1
    '        newCustomersRow("precio_unitario") = CDec(0)
    '        newCustomersRow("precio_subtotal") = CDec(Math.Round(0, 2)).ToString("N2")
    '        newCustomersRow("codbarra") = 0
    '        Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
    '    Next
    'End Sub




    Private Sub DataGridView1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DataGridView1.Validating
        'If Char.IsLetter(e.KeyChar) Then
        '    e.Cancel = True
        'End If
    End Sub

#Region "Validacion de grilla - solo numeros en celda"
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing

        valido_fraccionable(DataGridView1.CurrentRow.Cells("columna_codinterno").Value)

        'referencia a la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregar el controlador de eventos para el keypress
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub
    Private Sub valido_fraccionable(ByVal cod_ingresado As String)
        'Encontrado = "no"
        Dim i As Integer = 0
        While i < VentaGestion_DS_PROD.Tables(1).Rows.Count
            Dim cod_interno As String = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
            If cod_ingresado = cod_interno Then
                '' si es fraccionable o no el producto solamente por este if pasa''
                tipo_prod = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_tipo").ToString
                '''''''''''''''''''''''''''''MARIANO 17/6/19'''''''''''''''''''''''
                'Dim index As Integer = DataGridView1.CurrentRow.Index
                'DataGridView1.CurrentRow.Cells("item_num").Value = CInt(DataGridView1.CurrentRow.Index + 1)
                'DataGridView1.CurrentRow.Cells("prod_id").Value = DS_PROD.Tables(0).Rows(i).Item("prod_id").ToString
                'DataGridView1.CurrentRow.Cells("prod_codinterno").Value = DS_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
                'DataGridView1.CurrentRow.Cells("prod_descripcion").Value = DS_PROD.Tables(0).Rows(i).Item("prod_descripcion").ToString
                'DataGridView1.CurrentRow.Cells("Cantidad").Value = CInt(1)
                'Encontrado = "si"
            End If
            i = i + 1
        End While
        'If Encontrado = "no" Then
        '    'buscar por codigo de barras
        '    DataGridView1.CurrentRow.Cells("item_num").Value = ""
        '    DataGridView1.CurrentRow.Cells("prod_id").Value = ""
        '    DataGridView1.CurrentRow.Cells("prod_codinterno").Value = ""
        '    DataGridView1.CurrentRow.Cells("prod_descripcion").Value = ""
        '    DataGridView1.CurrentRow.Cells("Cantidad").Value = ""
        '    MessageBox.Show("No existe el producto para ese proveedor", "Sistema de Gestión")
        'End If
        'If DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value <> "" Then
        '    DataGridView1.Rows.Add()
        'End If
    End Sub
    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        Dim columna As Integer = DataGridView1.CurrentCell.ColumnIndex

        Dim variasdasd = DataGridView1.CurrentRow.Cells("columna_codinterno").Value

        If CStr(DataGridView1.CurrentRow.Cells("columna_codinterno").Value) = "" And (columna = 5 Or columna = 6) Then 'la columna 5 es Cantidad, la columna 6 es descuento
            'If IsDBNull(DataGridView1.CurrentRow.Cells("columna_codinterno").Value) And columna = 5 Then
            e.Handled = True
        Else
            If DataGridView1.CurrentRow.Cells("columna_prod_id").Value <> "" And columna = 2 Then
                e.Handled = True
                If Char.IsControl(e.KeyChar) Then
                    DataGridView1.CurrentRow.Cells("columna_codinterno").Value = celda_codinterno
                End If


            Else
                e.Handled = True 'bloqueo todo ingreso en primera instancia
                If Char.IsNumber(e.KeyChar) Then
                    e.Handled = False 'aqui habilito si es numero
                End If
                If Char.IsControl(e.KeyChar) Then
                    e.Handled = False 'aqui habilito si es una operacion de control como "borrar"
                End If
                'If e.KeyChar <> "" Then 'si es distinto de vacio valido 
                '    If Me.DataGridView1.CurrentCell.ColumnIndex <> 1 Then 'si no es la columna 1, solo numeros y comas
                '        e.Handled = True 'bloqueo todo ingreso en primera instancia
                '        If Char.IsNumber(e.KeyChar) Then
                '            e.Handled = False 'aqui habilito si es numero
                '        End If
                '        If Char.IsControl(e.KeyChar) Then
                '            e.Handled = False 'aqui habilito si es una operacion de control como "borrar"
                '        End If

                '        'obtener indice de la columna
                '        Dim columna As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
                '        'comprobar si la celda en edicion corresponde a la columnas deseadas
                '        'If columna = 1 Or columna = 2 Then
                '        'obtener caracter
                If columna = 5 Then
                    If tipo_prod = "Fraccionable" Then
                        Dim caracter As Char = e.KeyChar
                        '        'referencia a la celda
                        Dim txt As TextBox = CType(sender, TextBox)
                        'aqui pongo el codigo para remplazar el punto por una coma
                        If txt.ToString() = "." Then
                            txt.Text = ","
                        End If
                        If caracter.ToString() = "." Then
                            caracter = ","
                        End If
                        'comprobar si el caracter es un número o el retroceso, si el caracter es un separador decimal y que no contiene ya el separador
                        If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then
                            e.KeyChar = caracter
                            e.Handled = False
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
                If columna = 6 Then 'la columna 6 es descuento, que acepta decimales
                    Dim caracter As Char = e.KeyChar
                    '        'referencia a la celda
                    Dim txt As TextBox = CType(sender, TextBox)
                    'aqui pongo el codigo para remplazar el punto por una coma
                    If txt.ToString() = "." Then
                        txt.Text = ","
                    End If
                    If caracter.ToString() = "." Then
                        caracter = ","
                    End If
                    'comprobar si el caracter es un número o el retroceso, si el caracter es un separador decimal y que no contiene ya el separador
                    If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then
                        e.KeyChar = caracter
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub Busqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Busqueda.KeyPress
        Dim Filtro

        Filtro = String.Format("{0} LIKE '%{1}%'", "CLI_Fan", Busqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
        ClienteBindingSource.Filter = Filtro
    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
        'label_fecha.Text = Today
        'label_hora.Text = TimeOfDay
    End Sub

    Private Sub txt_desc_porc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_desc_porc.KeyPress
        'si toco asterisco me toma el total
        'If e.KeyChar.ToString = "*" Then
        '    tx_parcial.Text = tx_total.Text
        'End If
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
                If e.KeyChar = "," And Not Me.txt_desc_porc.Text.IndexOf(",") Then
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
            If txt_desc_porc.Text = "" Then
                txt_desc_porc.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
            Dim calculo_pesos As Decimal = (CDec(txt_desc_porc.Text) * CDec(txt_subtotal.Text)) / 100
            txt_desc_pesos.Text = calculo_pesos
            'txt_total.Text = CDec(txt_subtotal.Text) - calculo_pesos
            'txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            txt_descuento.Text = (Math.Round(CDec(calculo_pesos), 2).ToString("N2"))

            'If txt_desc_porc.Text = (Math.Round(CDec(0), 2).ToString("N2")) Then
            '    calcular_totales()
            'End If
            GroupBox_pagar.Text = "Monto a pagar (" + (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2")) + "% descuento)"
            '----------------------------------------------------------------------
            'formateo ambos txt, porcentaje y precio
            txt_desc_pesos.Text = (Math.Round(CDec(txt_desc_pesos.Text), 2).ToString("N2"))
            txt_desc_porc.Text = (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2"))
            '----------------------------------------------------------------------
            aplicar_iva()
            txt_desc_porc.SelectAll()
            txt_desc_porc.Text = (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2"))
            'If TextBox1.Text < 0 Then
            '    TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            'End If

        End If
    End Sub

    Private Sub txt_desc_pesos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_desc_pesos.KeyPress
        'si toco asterisco me toma el total
        'If e.KeyChar.ToString = "*" Then
        '    tx_parcial.Text = tx_total.Text
        'End If

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
                If e.KeyChar = "," And Not Me.txt_desc_pesos.Text.IndexOf(",") Then
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
        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER calcula
            If txt_desc_pesos.Text = "" Then
                txt_desc_pesos.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
            Dim calculo_porc As Decimal = (CDec(txt_desc_pesos.Text) * 100) / CDec(txt_subtotal.Text)
            txt_desc_porc.Text = calculo_porc

            'txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_desc_pesos.Text)
            'txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))

            'If txt_desc_porc.Text = (Math.Round(CDec(0), 2).ToString("N2")) Then
            '    calcular_totales()
            'End If
            GroupBox_pagar.Text = "Monto a pagar (" + (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2")) + "% descuento)"
            '----------------------------------------------------------------------
            'formateo ambos txt, porcentaje y precio
            txt_desc_pesos.Text = (Math.Round(CDec(txt_desc_pesos.Text), 2).ToString("N2"))
            txt_desc_porc.Text = (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2"))
            '----------------------------------------------------------------------
            txt_desc_pesos.SelectAll()
            aplicar_iva()
            txt_desc_porc.Text = (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2"))

            'aqui llamo arutina para aplicar iva, si corresponde

            'If TextBox1.Text < 0 Then
            '    TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            'End If
        End If

    End Sub

    Public Sub aplicar_iva()
        txt_total.Text = 0
        If ComboBox_iva.SelectedItem = "0" And CDec(txt_subtotal.Text) <> 0 Then
            '///////////////////IMPUESTO////////////////////////////
            txt_impuesto_aplicado.Text = CDec(0)
            '//////////////////////////////////////////////////////
            'como es el 0, debo volver a poner el total sin iva, y si corresponde aplico el descuento
            If txt_desc_pesos.Text = "" Then
                txt_desc_pesos.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
            Dim calculo_porc As Decimal = (CDec(txt_desc_pesos.Text) * 100) / CDec(txt_subtotal.Text)
            txt_desc_porc.Text = (Math.Round(CDec(calculo_porc), 2).ToString("N2"))

            '///////////////////////TOTAL A PAGAR/////////////////////////
            txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_desc_pesos.Text)
            txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////

            '///////////////////DESCUENTO//////////////////////////////
            txt_descuento.Text = (Math.Round(CDec(txt_desc_pesos.Text), 2).ToString("N2"))
            '/////////////////////////////////////////////////////////

            'If txt_desc_porc.Text = (Math.Round(CDec(0), 2).ToString("N2")) Then
            '    calcular_totales()
            'End If
            GroupBox_pagar.Text = "Monto a pagar (" + (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2")) + "% descuento)"
        End If
        If ComboBox_iva.SelectedItem = "10,5" And CDec(txt_subtotal.Text) <> 0 Then
            If txt_desc_pesos.Text = "" Then
                txt_desc_pesos.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
            Dim calculo_porc As Decimal = (CDec(txt_desc_pesos.Text) * 100) / CDec(txt_subtotal.Text)
            txt_desc_porc.Text = (Math.Round(CDec(calculo_porc), 2).ToString("N2"))
            '///////////////////////DESCUENTO/////////////////////////
            'txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_desc_pesos.Text)
            'txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            txt_descuento.Text = CDec(txt_desc_pesos.Text)
            txt_descuento.Text = (Math.Round(CDec(txt_descuento.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////

            '////////////////////////////IMPUESTO////////////////////////////////////////
            'calculo el 10.5% al subtotla de la venta.
            Dim calculo As Decimal = (CDec(10.5) * CDec(txt_subtotal.Text)) / 100 'esto me da en pesos cuanto se paga
            txt_impuesto_aplicado.Text = (Math.Round(CDec(calculo), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////////////////

            '/////////////////////TOTAL A PAGAR//////////////////////////////////
            txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_descuento.Text) + CDec(txt_impuesto_aplicado.Text)
            txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////

        End If
        If ComboBox_iva.SelectedItem = "21" And CDec(txt_subtotal.Text) <> 0 Then
            If txt_desc_pesos.Text = "" Then
                txt_desc_pesos.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
            Dim calculo_porc As Decimal = (CDec(txt_desc_pesos.Text) * 100) / CDec(txt_subtotal.Text)
            txt_desc_porc.Text = (Math.Round(CDec(calculo_porc), 2).ToString("N2"))

            '///////////////////////DESCUENTO/////////////////////////
            'txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_desc_pesos.Text)
            'txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            txt_descuento.Text = CDec(txt_desc_pesos.Text)
            txt_descuento.Text = (Math.Round(CDec(txt_descuento.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////

            '////////////////////////////IMPUESTO////////////////////////////////////////
            'aplico el 21% al total de la venta.
            Dim calculo As Decimal = (CDec(21) * CDec(txt_subtotal.Text)) / 100 'esto me da en pesos cuanto se paga
            txt_impuesto_aplicado.Text = (Math.Round(CDec(calculo), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////////////////

            '/////////////////////TOTAL A PAGAR//////////////////////////////////
            txt_total.Text = CDec(txt_subtotal.Text) - CDec(txt_descuento.Text) + CDec(txt_impuesto_aplicado.Text)
            txt_total.Text = (Math.Round(CDec(txt_total.Text), 2).ToString("N2"))
            '////////////////////////////////////////////////////////////////
        End If
    End Sub

    Private Sub ComboBox_iva_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_iva.SelectedValueChanged
        aplicar_iva()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Venta_Caja_seleccion_tipo_vta.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        If e.Exception IsNot Nothing AndAlso e.Context = DataGridViewDataErrorContexts.Commit Then
            MessageBox.Show("Error, ingrese un valor no nulo")
        End If
    End Sub

    Dim validaciones As New Validaciones
    Private Sub txt_vendedor_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_vendedor_codigo.KeyPress
        validaciones.Restricciones_textbox(e, "Entero", txt_vendedor_codigo)
        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER selecciono vendedor del combo box
            If txt_vendedor_codigo.Text <> "" Then
                'aqui busco
                If ComboBox_vendedor.Items.Count <> 0 Then
                    Dim ds_vendedor As DataSet = DAvendedor.Vendedor_obtenertodo()
                    Dim encontrado = "no"
                    Dim i As Integer = 0
                    While i < ds_vendedor.Tables(0).Rows.Count
                        If CInt(txt_vendedor_codigo.Text) = ds_vendedor.Tables(0).Rows(i).Item("vendedor_id") Then
                            ComboBox_vendedor.SelectedValue = ds_vendedor.Tables(0).Rows(i).Item("vendedor_id")
                            encontrado = "si"
                            Exit While
                        End If
                        i = i + 1
                    End While
                    If encontrado = "no" Then
                        MessageBox.Show("No existe vendedor.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("No hay vendedores registrados en el sistema.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub Btn_Vendedor_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Vendedor_buscar.Click
        Vendedor_modificar.Close()
        Vendedor_modificar.Show()

    End Sub

    Private Sub Btn_facturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_facturacion.Click
        If txt_total.Text <> "" Then

            If DataG_listaTotal.Rows.Count > 0 And CDec(txt_total.Text) <> CDec(0) Then
                If procedencia = "Venta_Caja_Gestion" Then
                    Forma_de_pago_seleccion.Show()
                Else
                    If procedencia = "Remito modificar" Then
                        'aqui actualizo, y si el usuario desea se genera la factura, ahi indico las formas de pago.
                        If MessageBox.Show("¿Desea realizar la facturación del remito actual?.", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            Dim venta_tipo_descripcion As String
                            If tipo_vta = "Minorista" Then
                                venta_tipo_descripcion = "Venta Minorista-Efectivo"
                            Else
                                venta_tipo_descripcion = "Venta Mayorista-Efectivo"
                            End If
                            Dim vendedor_id As Integer = CInt(ComboBox_vendedor.SelectedValue)

                            Dim ds_cuentacorrente As DataSet = DActacte.CtaCte_buscar_Cliente(remito_cliente_id)
                            If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                                'valido que el monto total no exceda el limite de deuda
                                Dim limite_deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_limitedeuda"))
                                Dim deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) + CDec(txt_total.Text)
                                If (deuda <= limite_deuda) Or limite_deuda = 0 Then
                                    DAventa.Remito_productos_modificar(remito_ventaprod_id, CDec(txt_total.Text),
                                                             USU_id_gen_remito,
                                                             "Cliente",
                                                             remito_cliente_id, CDec(txt_subtotal.Text),
                                                             CDec(txt_descuento.Text),
                                                             CDec(txt_desc_porc.Text),
                                                             CDec(ComboBox_iva.SelectedItem),
                                                              CDec(txt_impuesto_aplicado.Text), venta_tipo_descripcion, 0, vendedor_id, "Pendiente")
                                    'Actualizar Stock
                                    Actualizar_stock_remito() 'suma y resta cantidades

                                    'primero elimino los registros q tenia en la tabla venta_producto_detalle
                                    DAventa.VentaProductoDetalle_eliminar(remito_ventaprod_id)

                                    'ACTUALIZAR EN TABLA "Venta_Producto_detalle"
                                    For Each row As DataGridViewRow In DataGridView1.Rows
                                        If row.Cells("columna_prod_id").Value <> 0 Then
                                            DAventa.VentaProductoDetalle_alta(remito_ventaprod_id, row.Cells(1).Value, row.Cells(5).Value, CDec(row.Cells(7).Value), CDec(row.Cells(8).Value), row.Cells(3).Value, row.Cells(2).Value, 0, CDec(row.Cells(6).Value))
                                        End If
                                    Next
                                    'MessageBox.Show("El remito se modificó correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    'If MessageBox.Show("¿Desea registrar ingreso y generar factura?.", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then


                                    If Inicio.UT_id = 1 Then
                                        APcaja.Caja_Validar_admin()
                                    Else
                                        APcaja.Caja_Validar()
                                    End If


                                    'APcaja.Caja_Validar()
                                    If APcaja.SESION_CAJA = 1 And US_administrador.no_caja <> "deshabilitar" Then '1 = caja nueva, lista para iniciar
                                        MessageBox.Show("Error!,primero debe abrir la caja diaria para registrar la venta", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                        'Caja_abrir_turno.Close()
                                        'Caja_abrir_turno.Show()
                                    Else
                                        If APcaja.SESION_CAJA = 2 And US_administrador.no_caja <> "deshabilitar" Then
                                            'por aqui continuo con el registro de la factura
                                            facturar = "si" 'valido esto en el form de caja pago, caja tarjeta y forma de pago seleccion.
                                            Forma_de_pago_seleccion.Show()
                                        Else
                                            MessageBox.Show("Error!, No puede registrar la venta, la caja actual esta siendo utilizada por el usuario: " + US_administrador.apellidoynombre, "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        End If
                                    End If
                                    'Else
                                    '   facturar = "no"
                                    'End If
                                Else
                                    MessageBox.Show("La venta excede el limite de deuda para la cuenta corriente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                MessageBox.Show("No se registraron productos", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No se registraron productos", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class