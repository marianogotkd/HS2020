Public Class Mesas_gestion
    Dim DAventa As New Datos.Venta
    Dim DAcliente As New Datos.Cliente
    Dim DAlista As New Datos.Lista
    Dim DAproducto As New Datos.Producto
#Region "METODOS"
    Dim ds_clie As DataSet
    'recupero todos los clientes
    Public Sub Obtener_Clientes()
        ds_clie = DAcliente.Cliente_obtenertodo()
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            DG_clientes.DataSource = ds_clie.Tables(0)
        End If
    End Sub
    Public ds_PROMO As DataSet
    Public Sub Obtener_Promociones_2()
        ds_PROMO = DAlista.Lista_Promocion_obtener()
        'junto los prod y los combos..para mostrarlos en el mismo grid

        If ds_PROMO.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < ds_PROMO.Tables(0).Rows.Count
                Dim borrado As String = "no"
                'llamada a procedimiento para borrar.

                Obtener_Promociones_SUB(i, borrado)

                If borrado = "si" Then
                    'ds_PROMO.Tables(0).Rows(i).Delete()
                    ds_PROMO.Tables(0).Rows.RemoveAt(i)
                    i = 0
                Else
                    i = i + 1
                End If
            End While
        End If
    End Sub
    Public Function Obtener_Promociones_SUB(ByRef i As Integer, ByRef borrado As String)

        If ds_PROMO.Tables(0).Rows.Count <> 0 Then
            Dim dia_actual As Date = Today
            'Dim dia_actual As Date = "14 / 12 /2013"   esta la uso para probar si funciona bien en determinado dia
            Dim dia As String = dia_actual.ToString("dddd")


            Dim d As Integer = 0
            Dim dia_valido As String = ""
            While d < ds_PROMO.Tables(1).Rows.Count
                If ds_PROMO.Tables(0).Rows(i).Item("LISTA_id") = ds_PROMO.Tables(1).Rows(d).Item("LISTA_id") Then
                    dia_valido = "no"
                    Dim dia_semana As String = ""
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "1" Then
                        dia_semana = "domingo"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "2" Then
                        dia_semana = "lunes"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "3" Then
                        dia_semana = "martes"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "4" Then
                        dia_semana = "miércoles"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "5" Then
                        dia_semana = "jueves"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "6" Then
                        dia_semana = "viernes"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "7" Then
                        dia_semana = "sábado"
                    End If
                    If dia = dia_semana Then
                        dia_valido = "si"
                        d = ds_PROMO.Tables(1).Rows.Count
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
                While j < ds_PROMO.Tables(2).Rows.Count
                    Dim desde As Date = ds_PROMO.Tables(2).Rows(j).Item("LISTA_VIG_desde")
                    Dim hasta As Date = ds_PROMO.Tables(2).Rows(j).Item("LISTA_VIG_hasta")
                    If ds_PROMO.Tables(0).Rows(i).Item("LISTA_id") = ds_PROMO.Tables(2).Rows(j).Item("LISTA_id") Then
                        If (Today < desde) Or (Today > hasta) Then
                            'If (Today < CDate(ds_PROD.Tables(2).Rows(j).Item("LISTA_VIG_desde"))) Or (Today > CDate(ds_PROD.Tables(2).Rows(j).Item("LISTA_VIG_hasta"))) Then

                            'ds_PROMO.Tables(0).Rows(i).Delete()
                            borrado = "si"
                            j = ds_PROMO.Tables(2).Rows.Count
                        End If
                    End If
                    j = j + 1
                End While
            End If
        End If
        Return (borrado)
    End Function
    Public DS_PROD As DataSet
    Public Sub Obtener_Productos_Combos()


        If RB_Si.Checked = False Then

            DS_PROD = DAventa.Venta_obtenerProducto_Combos(Inicio.USU_id)

            'junto los prod y los combos..para mostrarlos en el mismo grid
            With DS_PROD.Tables(2).Rows
                If .Count > 0 Then
                    DS_PROD.Tables(1).Merge(DS_PROD.Tables(2))
                    'DataGridView1.DataSource = DS_PROD.Tables(1)

                Else

                    If DS_PROD.Tables(1).Rows.Count <> 0 Then
                        '    DataGridView1.DataSource = DS_PROD.Tables(1)
                    Else
                        '   DataGridView1.Enabled = False
                        'DataGridView1.DataSource = Nothing
                    End If

                End If
            End With

        Else
            If RB_No.Checked = False Then
                DS_PROD = DAventa.Venta_obtenerProducto_listaregular(CB_lista.SelectedValue)

                'junto los prod y los combos..para mostrarlos en el mismo grid
                With DS_PROD.Tables(1).Rows
                    If .Count > 0 Then
                        DS_PROD.Tables(0).Merge(DS_PROD.Tables(1))
                        'DataGridView1.DataSource = DS_PROD.Tables(0)

                    Else

                        If DS_PROD.Tables(0).Rows.Count <> 0 Then
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
    Public Sub recuperar_mesas()
        Mesas_ds.Tables("MesasAsignadas").Rows.Clear()
        DataGridView1.DataSource = Nothing

        Dim ds_mesas As DataSet = DAventa.Mesas_obtener()
        If ds_mesas.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < ds_mesas.Tables(0).Rows.Count

                Dim newCustomersRow As DataRow = Mesas_ds.Tables("MesasAsignadas").NewRow()
                newCustomersRow("MESA_numero") = ds_mesas.Tables(0).Rows(i).Item("MESA_numero").ToString
                newCustomersRow("Importe_Total") = CDec("00,00")
                newCustomersRow("Pago_parcial") = CDec("00,00")
                newCustomersRow("MESA_id") = ds_mesas.Tables(0).Rows(i).Item("MESA_id").ToString
                newCustomersRow("Estado") = ds_mesas.Tables(0).Rows(i).Item("ESTADO").ToString
                newCustomersRow("Ventaprod_id") = 0
                newCustomersRow("Cliente") = ""

                If ds_mesas.Tables(0).Rows(i).Item("ESTADO").ToString <> "Libre" Then 'si no es libre..
                    'recuperar id venta, importe_total, pago parcial, cliente/consumidor final
                    newCustomersRow("Ventaprod_id") = ds_mesas.Tables(0).Rows(i).Item("Ventaprod_id").ToString
                    Dim Ventaprod_id As Integer = ds_mesas.Tables(0).Rows(i).Item("Ventaprod_id").ToString
                    Dim ds_venta_mesa As DataSet = DAventa.VentaProducto_buscar(Ventaprod_id)
                    If ds_venta_mesa.Tables(0).Rows.Count <> 0 Then
                        newCustomersRow("Importe_Total") = CDec(Math.Round(ds_venta_mesa.Tables(0).Rows(0).Item("ventaprod_total"), 2)).ToString("N2")
                        newCustomersRow("Pago_parcial") = CDec(Math.Round(ds_venta_mesa.Tables(0).Rows(0).Item("ventaprod_pagoparcial"), 2)).ToString("N2")
                        If ds_venta_mesa.Tables(1).Rows.Count <> 0 Then
                            newCustomersRow("Cliente") = ds_venta_mesa.Tables(1).Rows(0).Item("CLI_ape").ToString + " " + ds_venta_mesa.Tables(1).Rows(0).Item("CLI_nom").ToString
                        Else
                            newCustomersRow("Cliente") = "Consumidor Final"
                        End If
                    End If
                End If


                'newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                Mesas_ds.Tables("MesasAsignadas").Rows.Add(newCustomersRow)
                i = i + 1
            End While
            DataGridView1.DataSource = Mesas_ds.Tables("MesasAsignadas")
        End If
    End Sub
    Private Sub Obtener_combo()
        Dim ds_listas As DataSet = DAlista.Lista_Regular_obtener()
        'Cargar Proveedor
        CB_lista.DataSource = ds_listas.Tables(0)
        CB_lista.DisplayMember = "LISTA_nom"
        CB_lista.ValueMember = "LISTA_id"
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
        While fila < Me.DataG_lista.Rows.Count


            Me.DataG_lista.Rows(fila).Cells(0).Style.BackColor = Color.GhostWhite
            Me.DataG_lista.Rows(fila).Cells(1).Style.BackColor = Color.GhostWhite
            Me.DataG_lista.Rows(fila).Cells(3).Style.BackColor = Color.GhostWhite
            Me.DataG_lista.Rows(fila).Cells(4).Style.BackColor = Color.GhostWhite
            Me.DataG_lista.Rows(fila).Cells(6).Style.BackColor = Color.GhostWhite
            Me.DataG_lista.Rows(fila).Cells(7).Style.BackColor = Color.GhostWhite

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
        'primero lo de la pagina 2
        TX_busc_codinterno.Clear()
        tx_cantidad.Clear()
        Venta_Caja_ds.Tables("Producto_agregado").Rows.Clear()
        DataG_lista.DataSource = Nothing
        DataG_listaTotal.DataSource = Nothing
        'segundo lo de la pagina 1
        GroupBox12.Enabled = False  'deshabilito la pestaña 2
        TabPage1.Enabled = True 'pasar a pestaña 1
        TabPage3.Enabled = False 'pasar a pestaña 1
        TabControl1.SelectedTab = TabPage1
        'GroupBox1.Enabled = True
        'GroupBox2.Enabled = True
        'GroupBox3.Enabled = True

    End Sub
    Public Sub calcular_totales()
        DataG_listaTotal.Rows.Clear()
        DataG_listaTotal.Rows.Add()
        'sumamos los subtotales con un ciclo
        Dim sumar As Decimal = "0,00"
        Dim ii As Integer = 0
        While ii < DataG_lista.Rows.Count
            sumar = sumar + DataG_lista.Rows(ii).Cells(7).Value
            ii = ii + 1
        End While
        sumar = Math.Round(sumar, 2)
        DataG_listaTotal.Rows(0).Cells(0).Value = "TOTAL"
        DataG_listaTotal.Rows(0).Cells(1).Value = Math.Round(sumar, 2).ToString("N2")
    End Sub
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


    Public Sub obtener_productos_de_venta(ByVal ventaprod_id As Integer)

        Dim items_venta As DataSet = DAventa.VentaProductoDetalle_buscar(ventaprod_id)


        Dim k As Integer = 0
        While k < items_venta.Tables(0).Rows.Count

            Dim busc_codinterno As String = items_venta.Tables(0).Rows(k).Item("codigointerno")
            Dim cant_registrada As Integer = items_venta.Tables(0).Rows(k).Item("ventaprod_cant")



            If busc_codinterno <> "" Then
                Dim i As Integer = 0
                Dim encontrado As String = "No"
                Dim T As Integer = 0
                If RB_No.Checked = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
                    T = 1
                End If

                While i < DS_PROD.Tables(T).Rows.Count
                    Dim cod_interno As String = DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
                    If busc_codinterno = cod_interno Then
                        'primero verifico que el producto q ingreso no este ya en la grilla
                        Dim item = 0
                        Dim presente = "no"
                        Dim fila_editar = 0
                        While item < DataG_lista.Rows.Count
                            If DataG_lista.Rows(item).Cells(2).Value = busc_codinterno Then
                                presente = "si"
                                fila_editar = item
                            End If
                            item = item + 1
                        End While
                        'ahora veo de agregar o editar
                        If presente = "no" Then
                            'agrego una nueva fila
                            Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                            newCustomersRow("PROD_id") = DS_PROD.Tables(T).Rows(i).Item("prod_id").ToString
                            newCustomersRow("codinterno") = DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
                            If RB_No.Checked = True Then
                                newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString
                            Else
                                newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString + " " + "x" + DS_PROD.Tables(T).Rows(i).Item("Lista_Prod_cantidad").ToString
                            End If
                            newCustomersRow("detalle") = DS_PROD.Tables(T).Rows(i).Item("prod_descrilarga").ToString
                            Dim cant As Integer = CInt(cant_registrada)
                            newCustomersRow("cantidad") = cant
                            newCustomersRow("precio_unitario") = DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta")
                            Dim total As Decimal = 0
                            total = cant * CDec(DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta"))
                            newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                            newCustomersRow("codbarra") = DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
                            Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                            DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                            Dim a As Integer = DataG_lista.Rows.Count
                            DataG_lista.Rows(a - 1).Cells(0).Value = a
                        Else

                            'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                            'Dim result As DialogResult
                            'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                            'If result = DialogResult.OK Then
                            Dim cant As Integer = CInt(cant_registrada) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
                            'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                            DataG_lista.Rows(fila_editar).Cells(5).Value = cant
                            Dim total As Decimal = 0
                            total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
                            DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
                            ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
                            'Dim result As DialogResult
                            'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                            'If result = DialogResult.OK Then
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
                            'End If
                        End If
                        encontrado = "Si"
                    End If
                    i = i + 1
                End While
                If encontrado = "No" Then
                    i = 0
                    'lo busco como promocion
                    While i < ds_PROMO.Tables(0).Rows.Count
                        Dim cod_interno As String = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                        If busc_codinterno.ToUpper = cod_interno Then
                            'primero verifico que el producto q ingreso no este ya en la grilla
                            Dim item = 0
                            Dim presente = "no"
                            Dim fila_editar = 0
                            While item < DataG_lista.Rows.Count
                                If DataG_lista.Rows(item).Cells(2).Value = busc_codinterno.ToUpper Then
                                    presente = "si"
                                    fila_editar = item
                                End If
                                item = item + 1
                            End While
                            'ahora veo de agregar o editar
                            If presente = "no" Then
                                'agrego una nueva fila
                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                                newCustomersRow("PROD_id") = CStr("0")
                                newCustomersRow("codinterno") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                                newCustomersRow("descripcion") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
                                'newCustomersRow("detalle") = 
                                Dim cant As Integer = CInt(cant_registrada)
                                newCustomersRow("cantidad") = cant
                                newCustomersRow("precio_unitario") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_total")

                                Dim total As Decimal = 0
                                total = cant * CDec(ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
                                newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                                newCustomersRow("codbarra") = " "
                                Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                                DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                                Dim a As Integer = DataG_lista.Rows.Count
                                DataG_lista.Rows(a - 1).Cells(0).Value = a

                            Else
                                'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                                'Dim result As DialogResult
                                'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                                'If result = DialogResult.OK Then
                                Dim cant As Integer = CInt(cant_registrada) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
                                'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                                DataG_lista.Rows(fila_editar).Cells(5).Value = cant
                                Dim total As Decimal = 0
                                total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
                                DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
                                'End If
                            End If
                            encontrado = "Si"
                        End If
                        i = i + 1
                    End While
                    If encontrado = "No" Then
                        MsgBox("no existe")
                        'busc_codinterno.SelectAll()
                    Else

                        tx_cantidad.Text = "1"
                        'tx_cantidad.Focus()
                        'tx_cantidad.SelectAll()
                        'TX_busc_codinterno.Text = ""
                        'TX_busc_codinterno.Focus()
                        'TX_busc_codinterno.SelectAll()
                    End If
                Else
                    tx_cantidad.Text = "1"
                    'TX_busc_codinterno.Text = ""
                    'TX_busc_codinterno.Focus()
                    'TX_busc_codinterno.SelectAll()
                    'tx_cantidad.Focus()
                    'tx_cantidad.SelectAll()
                End If
            End If
            k = k + 1
        End While
        calcular_totales()
    End Sub


#End Region

    Private Sub Mesas_gestion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If TabPage3.Enabled = True Then

        If e.KeyCode = Keys.F1 Then 'F1
            Busqueda_Productos.form_procedencia = "Mesas_gestion"
            Busqueda_Productos.Show()
            Busqueda_Productos.tx_Buscar.Focus()
        End If
        If e.KeyCode = Keys.F2 Then
            Ver_promocion.form_procedencia = "Mesas_gestion"
            Ver_promocion.Show()
            Ver_promocion.tx_Buscar.Focus()
        End If
        'End If
    End Sub

    Private Sub Mesas_gestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TabPage2.Enabled = False 'pestaña de abrir mesa
        TabPage3.Enabled = False

        tx_cantidad.MaxLength = 6
        'recupero todos los clientes de la bd
        Call Obtener_Clientes()
        'Call Obtener_Promociones()
        Obtener_Promociones_2()
        Obtener_Productos_Combos()
        'recupero las mesas existentes, con el estado y el id de la venta con la que se relaciona
        recuperar_mesas()
        Me.Focus()

    End Sub

    Private Sub BO_Agregar_mesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Agregar_mesa.Click
        If MsgBox("Esta seguro que quiere agregar una mesa nueva?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then

            Dim nro_mesa As Integer = 1
            If DataGridView1.Rows.Count <> 0 Then
                nro_mesa = CInt(DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value + 1)
            End If
            DAventa.Mesas_alta(nro_mesa, "Libre")
            recuperar_mesas()
        End If
    End Sub
    Private Sub RB_Consumidor_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Consumidor.CheckedChanged
        If RB_Consumidor.Checked = True Then
            DG_clientes.Enabled = False
            Dim i = 0
            While i < DG_clientes.Rows.Count
                DG_clientes.Rows(i).Cells(1).Value = False
                i = i + 1
            End While
        End If
    End Sub
    Private Sub RB_Cliente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Cliente.CheckedChanged
        If RB_Cliente.Checked = True Then
            DG_clientes.Enabled = True
            Txt_buscar_clie.Focus()
            Txt_buscar_clie.SelectAll()
        End If
    End Sub

    Private Sub DG_clientes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_clientes.CellClick
        If e.ColumnIndex <> 1 Then Exit Sub
        'primero quito la seleccion de los demas
        Dim i = 0
        While i < DG_clientes.Rows.Count
            DG_clientes.Rows(i).Cells(1).Value = False
            i = i + 1
        End While
        If DG_clientes.Rows(e.RowIndex).Cells(1).Value = True Then
            DG_clientes.Rows(e.RowIndex).Cells(1).Value = False
        Else
            DG_clientes.Rows(e.RowIndex).Cells(1).Value = True
        End If
    End Sub

    Private Sub RB_No_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_No.CheckedChanged
        If RB_No.Checked = True Then
            CB_lista.DataSource = Nothing
            CB_lista.Items.Add("Defecto")
            CB_lista.SelectedIndex = 0
        End If
    End Sub

    Private Sub RB_Si_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Si.CheckedChanged
        If RB_Si.Checked = True Then
            Call Obtener_combo()
        End If
    End Sub

    Private Sub Txt_buscar_clie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_buscar_clie.KeyPress
        DG_clientes.DataSource = Nothing
        If Txt_buscar_clie.Text <> "" Then
            Filtrar_datatable(Me.Txt_buscar_clie.Text)
        Else
            DG_clientes.DataSource = ds_clie.Tables(0)
        End If
    End Sub

    Private Sub BO_abrirmesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_abrirmesa.Click
        If DataGridView1.RowCount <> 0 Then
            If Me.DataGridView1.CurrentRow IsNot Nothing And (DataGridView1.CurrentRow.Cells("EstadoDataGridViewTextBoxColumn").Value = "Libre") Then
                TabPage1.Enabled = False 'deshabilito pestaña 0
                TabPage2.Enabled = True 'pasar a pestaña abrir mesa
                TabControl1.SelectedTab = TabPage2
            Else
                MsgBox("Seleccione una mesa libre", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("No se crearon mesas", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        If MsgBox("Esta seguro que quiere cancelar la apertura de la mesa?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            TabPage1.Enabled = True 'pasar a pestaña 1
            TabPage2.Enabled = False 'pasar a pestaña 1
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub

    Private Sub BO_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Aceptar.Click
        If MsgBox("Esta seguro que quiere abrir la mesa nueva?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            Dim usuario_id As String
            usuario_id = Inicio.USU_id 'obtengo del formulario inicio el id del usuario actual, logueado
            Dim tipo_vta As String = ""
            Dim cliente_id As Integer
            If RB_Consumidor.Checked = True Then
                tipo_vta = "Consumidor Final"
                cliente_id = 0
            Else
                tipo_vta = "Cliente"
                cliente_id = DG_clientes.CurrentRow.Cells(0).Value
            End If
            'alta de venta
            Dim ds_Venta As DataSet = DAventa.VentaProducto_alta_mesa(CDec("00,00"), CDec("00,00"), "Ocupado",
                                                Now,
                                                usuario_id,
                                                tipo_vta,
                                                cliente_id)
            Dim ventaprod_id As Integer = CType(ds_Venta.Tables(0).Rows(0).Item("ventaprod_id"), String)
            'actualizo estado de mesa, y relaciono con venta
            'DAventa.MESAS_modificar(DataGridView1.CurrentRow.Cells("MESAidDataGridViewTextBoxColumn").Value, ventaprod_id, "Ocupado")

            If RB_No.Checked = False Then
                DAventa.VentaConfig_alta(ventaprod_id, CB_lista.SelectedValue)
            End If

            TabPage1.Enabled = True 'pasar a pestaña 1
            TabPage2.Enabled = False 'pasar a pestaña 1
            TabControl1.SelectedTab = TabPage1
            recuperar_mesas()
        End If
    End Sub

    Private Sub BO_cargarmesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cargarmesa.Click
        If DataGridView1.RowCount <> 0 Then


            If Me.DataGridView1.CurrentRow IsNot Nothing And (DataGridView1.CurrentRow.Cells("EstadoDataGridViewTextBoxColumn").Value <> "Libre") Then
                TabPage1.Enabled = False 'deshabilito pestaña 0
                TabPage3.Enabled = True 'pasar a pestaña  3 para cargar productos
                TabControl1.SelectedTab = TabPage3
                'veo si tiene configuracion
                Dim ds_config As DataSet = DAventa.VentaConfig_buscar(Me.DataGridView1.CurrentRow.Cells("VentaprodidDataGridViewTextBoxColumn").Value)
                If ds_config.Tables(0).Rows.Count <> 0 Then
                    'MsgBox("tiene configuracion")
                    RB_Si.Checked = True
                    CB_lista.SelectedValue = ds_config.Tables(0).Rows(0).Item("LISTA_id")
                Else
                    'MsgBox("no tiene configuracion")
                    RB_No.Checked = True
                End If



                GroupBox12.Enabled = True 'habilito la pestaña 2
                'GroupBox1.Enabled = False
                'GroupBox2.Enabled = False
                'GroupBox3.Enabled = False
                'LIMPIAR LA GRILLA DE PROD AGREGADOS
                DataG_lista.DataSource = Nothing
                Call habilitar_columnas_edicion()
                Call Obtener_Productos_Combos()

                tx_cantidad.Text = 1

                Me.Focus()
                tx_cantidad.Focus()
                tx_cantidad.SelectAll()

                Call obtener_productos_de_venta(DataGridView1.CurrentRow.Cells(0).Value)
            Else
                MsgBox("Seleccione una mesa ocupada", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("No se crearon mesas", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Limpiar()
    End Sub

    Private Sub RB_CodInterno_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_CodInterno.CheckedChanged
        If RB_CodInterno.Checked = True Then
            TX_busc_codinterno.TabIndex = 0
            TX_busc_codibarra.TabIndex = 255
            TX_busc_codinterno.Enabled = True
            TX_busc_codinterno.Focus()
            TX_busc_codinterno.SelectAll()
            TX_busc_codibarra.Enabled = False
        End If
    End Sub

    Private Sub RB_CodBarra_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_CodBarra.CheckedChanged
        If RB_CodBarra.Checked = True Then
            TX_busc_codibarra.TabIndex = 0
            TX_busc_codinterno.TabIndex = 255
            TX_busc_codibarra.Enabled = True
            TX_busc_codibarra.Focus()
            TX_busc_codibarra.SelectAll()
            TX_busc_codinterno.Enabled = False
        End If
    End Sub

    Private Sub TX_busc_codinterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_busc_codinterno.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras

            'cuando presiono enter busco el prod o combo en el dataset...DS_PROD

            If TX_busc_codinterno.Text <> "" Then
                Dim i As Integer = 0
                Dim encontrado As String = "No"
                Dim T As Integer = 0
                If RB_No.Checked = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
                    T = 1
                End If

                While i < DS_PROD.Tables(T).Rows.Count
                    Dim cod_interno As String = DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
                    If TX_busc_codinterno.Text = cod_interno Then
                        'primero verifico que el producto q ingreso no este ya en la grilla
                        Dim item = 0
                        Dim presente = "no"
                        Dim fila_editar = 0
                        While item < DataG_lista.Rows.Count
                            If DataG_lista.Rows(item).Cells(2).Value = TX_busc_codinterno.Text Then
                                presente = "si"
                                fila_editar = item
                            End If
                            item = item + 1
                        End While
                        'ahora veo de agregar o editar
                        If presente = "no" Then
                            'agrego una nueva fila
                            Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                            newCustomersRow("PROD_id") = DS_PROD.Tables(T).Rows(i).Item("prod_id").ToString
                            newCustomersRow("codinterno") = DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
                            If RB_No.Checked = True Then
                                newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString
                            Else
                                newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString + " " + "x" + DS_PROD.Tables(T).Rows(i).Item("Lista_Prod_cantidad").ToString
                            End If
                            newCustomersRow("detalle") = DS_PROD.Tables(T).Rows(i).Item("prod_descrilarga").ToString
                            If tx_cantidad.Text = "" Then
                                tx_cantidad.Text = CInt(1)
                            End If
                            Dim cant As Integer = CInt(tx_cantidad.Text)
                            newCustomersRow("cantidad") = cant
                            newCustomersRow("precio_unitario") = DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta")
                            Dim total As Decimal = 0
                            total = cant * CDec(DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta"))
                            newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                            newCustomersRow("codbarra") = DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
                            Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                            DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                            Dim a As Integer = DataG_lista.Rows.Count
                            DataG_lista.Rows(a - 1).Cells(0).Value = a
                        Else

                            'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                            'Dim result As DialogResult
                            'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                            'If result = DialogResult.OK Then
                            If tx_cantidad.Text = "" Then
                                tx_cantidad.Text = CInt(1)
                            End If
                            Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
                            'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                            DataG_lista.Rows(fila_editar).Cells(5).Value = cant
                            Dim total As Decimal = 0
                            total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
                            DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
                            ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
                            'Dim result As DialogResult
                            'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                            'If result = DialogResult.OK Then
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
                            'End If
                        End If
                        encontrado = "Si"
                    End If
                    i = i + 1
                End While
                If encontrado = "No" Then
                    i = 0
                    'lo busco como promocion
                    While i < ds_PROMO.Tables(0).Rows.Count
                        Dim cod_interno As String = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                        If TX_busc_codinterno.Text.ToUpper = cod_interno Then
                            'primero verifico que el producto q ingreso no este ya en la grilla
                            Dim item = 0
                            Dim presente = "no"
                            Dim fila_editar = 0
                            While item < DataG_lista.Rows.Count
                                If DataG_lista.Rows(item).Cells(2).Value = TX_busc_codinterno.Text.ToUpper Then
                                    presente = "si"
                                    fila_editar = item
                                End If
                                item = item + 1
                            End While
                            'ahora veo de agregar o editar
                            If presente = "no" Then
                                'agrego una nueva fila
                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                                newCustomersRow("PROD_id") = CStr("0")
                                newCustomersRow("codinterno") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                                newCustomersRow("descripcion") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
                                'newCustomersRow("detalle") = 
                                If tx_cantidad.Text = "" Then
                                    tx_cantidad.Text = CInt(1)
                                End If
                                Dim cant As Integer = CInt(tx_cantidad.Text)
                                newCustomersRow("cantidad") = cant
                                newCustomersRow("precio_unitario") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_total")

                                Dim total As Decimal = 0
                                total = cant * CDec(ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
                                newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                                newCustomersRow("codbarra") = " "
                                Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                                DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                                Dim a As Integer = DataG_lista.Rows.Count
                                DataG_lista.Rows(a - 1).Cells(0).Value = a

                            Else
                                'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                                'Dim result As DialogResult
                                'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                                'If result = DialogResult.OK Then
                                If tx_cantidad.Text = "" Then
                                    tx_cantidad.Text = CInt(1)
                                End If
                                Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
                                'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                                DataG_lista.Rows(fila_editar).Cells(5).Value = cant
                                Dim total As Decimal = 0
                                total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
                                DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
                                'End If
                            End If
                            encontrado = "Si"
                        End If
                        i = i + 1
                    End While
                    If encontrado = "No" Then
                        MsgBox("no existe")
                        TX_busc_codinterno.SelectAll()
                    Else

                        tx_cantidad.Text = "1"
                        'tx_cantidad.Focus()
                        'tx_cantidad.SelectAll()
                        TX_busc_codinterno.Text = ""
                        TX_busc_codinterno.Focus()
                        TX_busc_codinterno.SelectAll()
                    End If
                Else
                    tx_cantidad.Text = "1"
                    TX_busc_codinterno.Text = ""
                    TX_busc_codinterno.Focus()
                    TX_busc_codinterno.SelectAll()
                    'tx_cantidad.Focus()
                    'tx_cantidad.SelectAll()
                End If
            End If
            calcular_totales()
        End If
    End Sub

    Private Sub TX_busc_codibarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_busc_codibarra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras

            'cuando presiono enter busco el prod o combo en el dataset...DS_PROD

            If TX_busc_codibarra.Text <> "" Then
                Dim i As Integer = 0
                Dim encontrado As String = "No"
                Dim T As Integer = 0
                If RB_No.Checked = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
                    T = 1
                End If

                While i < DS_PROD.Tables(T).Rows.Count
                    Dim cod_barra As String = DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
                    Dim cod_interno As String = DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
                    If TX_busc_codibarra.Text = cod_barra Then
                        'primero verifico que el producto q ingreso no este ya en la grilla
                        Dim item = 0
                        Dim presente = "no"
                        Dim fila_editar = 0
                        While item < DataG_lista.Rows.Count
                            If CStr(DataG_lista.Rows(item).Cells("codbarra").Value) = TX_busc_codibarra.Text Then
                                presente = "si"
                                fila_editar = item
                            End If
                            item = item + 1
                        End While
                        'ahora veo de agregar o editar
                        If presente = "no" Then
                            'agrego una nueva fila
                            Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                            newCustomersRow("PROD_id") = DS_PROD.Tables(T).Rows(i).Item("prod_id").ToString
                            newCustomersRow("codinterno") = DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
                            If RB_No.Checked = True Then
                                newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString
                            Else
                                newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString + " " + "x" + DS_PROD.Tables(T).Rows(i).Item("Lista_Prod_cantidad").ToString
                            End If
                            newCustomersRow("detalle") = DS_PROD.Tables(T).Rows(i).Item("prod_descrilarga").ToString
                            If tx_cantidad.Text = "" Then
                                tx_cantidad.Text = CInt(1)
                            End If
                            Dim cant As Integer = CInt(tx_cantidad.Text)
                            newCustomersRow("cantidad") = cant
                            newCustomersRow("precio_unitario") = DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta")
                            Dim total As Decimal = 0
                            total = cant * CDec(DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta"))
                            newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                            newCustomersRow("codbarra") = DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString

                            Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                            DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                            Dim a As Integer = DataG_lista.Rows.Count
                            DataG_lista.Rows(a - 1).Cells(0).Value = a
                        Else


                            'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                            'Dim result As DialogResult
                            'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                            'If result = DialogResult.OK Then
                            If tx_cantidad.Text = "" Then
                                tx_cantidad.Text = CInt(1)
                            End If
                            Dim cant As Integer = CInt(tx_cantidad.Text) + CInt(DataG_lista.Rows(fila_editar).Cells(5).Value)
                            'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                            DataG_lista.Rows(fila_editar).Cells(5).Value = cant
                            Dim total As Decimal = 0
                            total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
                            DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
                            'End If


                            ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
                            'Dim result As DialogResult
                            'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                            'If result = DialogResult.OK Then
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
                            '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
                            'End If
                        End If
                        encontrado = "Si"
                    End If
                    i = i + 1
                End While
                If encontrado = "No" Then
                    i = 0
                    'lo busco como promocion
                    'While i < ds_PROMO.Tables(0).Rows.Count
                    '    Dim cod_interno As String = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                    '    If TX_busc_codinterno.Text.ToUpper = cod_interno Then
                    '        'primero verifico que el producto q ingreso no este ya en la grilla
                    '        Dim item = 0
                    '        Dim presente = "no"
                    '        Dim fila_editar = 0
                    '        While item < DataG_lista.Rows.Count
                    '            If DataG_lista.Rows(item).Cells(2).Value = TX_busc_codinterno.Text.ToUpper Then
                    '                presente = "si"
                    '                fila_editar = item
                    '            End If
                    '            item = item + 1
                    '        End While
                    '        'ahora veo de agregar o editar
                    '        If presente = "no" Then
                    '            'agrego una nueva fila
                    '            Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                    '            newCustomersRow("PROD_id") = CStr("0")
                    '            newCustomersRow("codinterno") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                    '            newCustomersRow("descripcion") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
                    '            'newCustomersRow("detalle") = 
                    '            Dim cant As Integer = 1
                    '            newCustomersRow("cantidad") = cant
                    '            newCustomersRow("precio_unitario") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_total")

                    '            Dim total As Decimal = 0
                    '            total = cant * CDec(ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
                    '            newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                    '            Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                    '            DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                    '            Dim a As Integer = DataG_lista.Rows.Count
                    '            DataG_lista.Rows(a - 1).Cells(0).Value = a
                    '        End If
                    '        encontrado = "Si"
                    '    End If
                    '    i = i + 1
                    'End While
                    If encontrado = "No" Then
                        MsgBox("no existe")
                        TX_busc_codibarra.SelectAll()
                    Else
                        tx_cantidad.Text = "1"
                        'tx_cantidad.Focus()
                        'tx_cantidad.SelectAll()
                        'TX_busc_codibarra.Text = ""
                        TX_busc_codibarra.Focus()
                        TX_busc_codibarra.SelectAll()

                    End If
                Else
                    tx_cantidad.Text = "1"
                    'tx_cantidad.Focus()
                    'tx_cantidad.SelectAll()
                    'TX_busc_codibarra.Text = ""
                    TX_busc_codibarra.Focus()
                    TX_busc_codibarra.SelectAll()
                End If
            End If
            calcular_totales()
        End If
    End Sub

    Private Sub tx_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_cantidad.KeyPress
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
            ''cuando presiono enter busco el prod o combo en el dataset...DS_PROD
            'If RB_CodInterno.Checked = True Then

            '    If TX_busc_codinterno.Text <> "" And tx_cantidad.Text <> "" Then
            '        Dim i As Integer = 0
            '        Dim encontrado As String = "No"
            '        Dim T As Integer = 0
            '        If RB_No.Checked = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
            '            T = 1
            '        End If
            '        While i < DS_PROD.Tables(T).Rows.Count
            '            Dim cod_interno As String = DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
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
            '                    newCustomersRow("PROD_id") = DS_PROD.Tables(T).Rows(i).Item("prod_id").ToString
            '                    newCustomersRow("codinterno") = DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
            '                    'newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString

            '                    If RB_No.Checked = True Then
            '                        newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString
            '                    Else
            '                        newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString + " " + "x" + DS_PROD.Tables(T).Rows(i).Item("Lista_Prod_cantidad").ToString
            '                    End If

            '                    newCustomersRow("detalle") = DS_PROD.Tables(T).Rows(i).Item("prod_descrilarga").ToString
            '                    Dim cant As Integer = CInt(tx_cantidad.Text)
            '                    newCustomersRow("cantidad") = cant
            '                    newCustomersRow("precio_unitario") = DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta")
            '                    Dim total As Decimal = 0
            '                    total = cant * CDec(DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta"))
            '                    newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
            '                    newCustomersRow("codbarra") = DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
            '                    Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
            '                    DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
            '                    Dim a As Integer = DataG_lista.Rows.Count
            '                    DataG_lista.Rows(a - 1).Cells(0).Value = a
            '                Else
            '                    'edito una fila existente, solo si el usuario lo desea, pregunta!!!
            '                    'Dim result As DialogResult
            '                    'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            '                    'If result = DialogResult.OK Then
            '                    Dim cant As Integer = CInt(tx_cantidad.Text)
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
            '            i = 0
            '            'lo busco como promocion
            '            While i < ds_PROMO.Tables(0).Rows.Count
            '                Dim cod_interno As String = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
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
            '                        newCustomersRow("codinterno") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
            '                        newCustomersRow("descripcion") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
            '                        'newCustomersRow("detalle") = 
            '                        Dim cant As Integer = CInt(tx_cantidad.Text)
            '                        newCustomersRow("cantidad") = cant
            '                        newCustomersRow("precio_unitario") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_total")

            '                        Dim total As Decimal = 0
            '                        total = cant * CDec(ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
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
            '                        Dim cant As Integer = CInt(tx_cantidad.Text)
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
            '            End If
            '        End If
            '    End If

            'Else

            '    'VALIDACION PARA CODIGO BARRA

            '    If TX_busc_codibarra.Text <> "" And tx_cantidad.Text <> "" Then
            '        Dim i As Integer = 0
            '        Dim encontrado As String = "No"
            '        Dim T As Integer = 0
            '        If RB_No.Checked = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
            '            T = 1
            '        End If
            '        While i < DS_PROD.Tables(T).Rows.Count
            '            Dim cod_barra As String = DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
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
            '                    newCustomersRow("PROD_id") = DS_PROD.Tables(T).Rows(i).Item("prod_id").ToString
            '                    newCustomersRow("codinterno") = DS_PROD.Tables(T).Rows(i).Item("prod_codinterno").ToString
            '                    'newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString

            '                    If RB_No.Checked = True Then
            '                        newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString
            '                    Else
            '                        newCustomersRow("descripcion") = DS_PROD.Tables(T).Rows(i).Item("prod_descripcion").ToString + " " + "x" + DS_PROD.Tables(T).Rows(i).Item("Lista_Prod_cantidad").ToString
            '                    End If

            '                    newCustomersRow("detalle") = DS_PROD.Tables(T).Rows(i).Item("prod_descrilarga").ToString
            '                    Dim cant As Integer = CInt(tx_cantidad.Text)
            '                    newCustomersRow("cantidad") = cant
            '                    newCustomersRow("precio_unitario") = DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta")
            '                    Dim total As Decimal = 0
            '                    total = cant * CDec(DS_PROD.Tables(T).Rows(i).Item("prod_precio_vta"))
            '                    newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
            '                    newCustomersRow("codbarra") = DS_PROD.Tables(T).Rows(i).Item("prod_codbarra").ToString
            '                    Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
            '                    DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
            '                    Dim a As Integer = DataG_lista.Rows.Count
            '                    DataG_lista.Rows(a - 1).Cells(0).Value = a
            '                Else
            '                    'edito una fila existente, solo si el usuario lo desea, pregunta!!!
            '                    'Dim result As DialogResult
            '                    'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            '                    'If result = DialogResult.OK Then
            '                    Dim cant As Integer = CInt(tx_cantidad.Text)
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
            '            i = 0
            '            ''lo busco como promocion
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
            '            '            Dim cant As Integer = CInt(tx_cantidad.Text)
            '            '            newCustomersRow("cantidad") = cant
            '            '            newCustomersRow("precio_unitario") = ds_PROMO.Tables(0).Rows(i).Item("LISTA_total")

            '            '            Dim total As Decimal = 0
            '            '            total = cant * CDec(ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
            '            '            newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
            '            '            newCustomersRow("codbarra") = " "
            '            '            Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
            '            '            DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
            '            '            Dim a As Integer = DataG_lista.Rows.Count
            '            '            DataG_lista.Rows(a - 1).Cells(0).Value = a
            '            '        Else
            '            '            'edito una fila existente, solo si el usuario lo desea, pregunta!!!
            '            '            'Dim result As DialogResult
            '            '            'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            '            '            'If result = DialogResult.OK Then
            '            '            Dim cant As Integer = CInt(tx_cantidad.Text)
            '            '            'DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
            '            '            DataG_lista.Rows(fila_editar).Cells(5).Value = cant
            '            '            Dim total As Decimal = 0
            '            '            total = cant * CDec(DataG_lista.Rows(fila_editar).Cells(6).Value)
            '            '            DataG_lista.Rows(fila_editar).Cells(7).Value = CDec(Math.Round(total, 2)).ToString("N2")
            '            '            'End If
            '            '        End If
            '            '        encontrado = "Si"
            '            '    End If
            '            '    i = i + 1
            '            'End While
            '            If encontrado = "No" Then
            '                MsgBox("no existe")
            '            End If
            '        End If
            '    End If





            'End If



            'tx_cantidad.Text = ""

            'If RB_CodBarra.Checked = True Then
            '    TX_busc_codibarra.Text = ""
            '    TX_busc_codibarra.Focus()
            '    TX_busc_codibarra.SelectAll()
            'Else
            '    TX_busc_codinterno.Text = ""
            '    TX_busc_codinterno.Focus()
            '    TX_busc_codinterno.SelectAll()
            'End If

            'calcular_totales()
        End If
    End Sub
    Private Sub tx_cantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_cantidad.LostFocus
        If RB_CodInterno.Checked = True Then
            TX_busc_codinterno.Focus()
            TX_busc_codinterno.SelectAll()
        Else
            TX_busc_codibarra.Focus()
            TX_busc_codibarra.SelectAll()
        End If
    End Sub

    Private Sub DataG_lista_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataG_lista.RowsRemoved
        'esta habilitada la funcion de borrar una fija de la grilla..
        'por eso cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
        Dim a As Integer = 0
        While a < DataG_lista.Rows.Count
            DataG_lista.Rows(a).Cells(0).Value = a + 1
            a = a + 1
        End While
        calcular_totales()
    End Sub

    Private Sub Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitar.Click
        'aqui elemino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"
        If DataG_lista.Rows.Count <> 0 Then
            'If DataG_lista.CurrentRow.Cells(0).Value <> "" Then
            'If MsgBox("Esta seguro que quiere borrar la informacion del item seleccionado?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            'primero guardo el nro de item q contiene
            Dim item As Decimal = DataG_lista.CurrentRow.Index


            If DataG_lista.CurrentRow.Cells(5).Value = "1" Then

                'DataG_lista.Rows.RemoveAt(DataG_lista.CurrentRow.Index)
                Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Delete()
                DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                'cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
                Dim a As Integer = 0
                While a < DataG_lista.Rows.Count
                    DataG_lista.Rows(a).Cells(0).Value = a + 1
                    a = a + 1
                End While
                calcular_totales()
            Else
                Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("cantidad") = Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("cantidad") - 1
                Dim total As Decimal = 0
                total = Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("cantidad") * CDec(Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("precio_unitario"))
                Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Item("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                calcular_totales()
            End If


            'este codigo si va
            'Call Cargar_Totales(añosdelproyecto)
            'modificado = 1
            'End If
            'End If
        End If
        DataG_lista.Refresh()











    End Sub

    
    Private Sub BO_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_buscar.Click
        Busqueda_Productos.form_procedencia = "Mesas_gestion"
        Busqueda_Productos.Show()
        Busqueda_Productos.tx_Buscar.Focus()

    End Sub

    Private Sub BO_promocion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_promocion.Click
        Ver_promocion.form_procedencia = "Mesas_gestion"
        Ver_promocion.Show()
        Ver_promocion.tx_Buscar.Focus()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Mesa_nueva.tx_total.Text = CDec(DataG_listaTotal.Rows(0).Cells(1).Value) - CDec(DataGridView1.CurrentRow.Cells(4).Value) 'total menos pago parcial, para generar lo q realmente se debe
        Mesa_nueva.tx_total.Text = (Math.Round(CDec(Mesa_nueva.tx_total.Text), 2).ToString("N2"))
        Mesa_nueva.tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))

        Mesa_nueva.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.DataGridView1.CurrentRow IsNot Nothing Then
            If (DataGridView1.CurrentRow.Cells("EstadoDataGridViewTextBoxColumn").Value <> "Cobrado") Then
                If MsgBox("Esta seguro que quiere liberar la mesa, ya que no se cobro aún?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                    Dim estado As String = "Libre"
                    Dim ventaprod_id As Integer = DataGridView1.CurrentRow.Cells(0).Value
                    'DAventa.MESAS_modificar(DataGridView1.CurrentRow.Cells("MESAidDataGridViewTextBoxColumn").Value, ventaprod_id, estado)
                    recuperar_mesas()
                End If
            Else
                Dim estado As String = "Libre"
                Dim ventaprod_id As Integer = DataGridView1.CurrentRow.Cells(0).Value
                'DAventa.MESAS_modificar(DataGridView1.CurrentRow.Cells("MESAidDataGridViewTextBoxColumn").Value, ventaprod_id, estado)
                recuperar_mesas()
            End If
        Else
            MsgBox("Seleccione una mesa cobrada", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BO_Eliminar_mesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar_mesa.Click
        If Me.DataGridView1.CurrentRow IsNot Nothing Then
            DAventa.Mesas_eliminar(DataGridView1.CurrentRow.Cells(2).Value)
            recuperar_mesas()
        End If
    End Sub
End Class