Public Class Mesa_cargar
    Dim DAventa As New Datos.Venta
    Dim DAlista As New Datos.Lista
    Dim DAproducto As New Datos.Producto
    Public form_procedencia As String
    Public PAGADO_procedencia_mesa_asignar As Decimal = CDec(0)
    Public SALDO_procedencia_mesa_asignar As Decimal = CDec(0)
    Public TURNO_id_procedencia_mesa_asignar As Integer = 0

    Public tipo_vta As String = ""
    Public Sub Cargar_turno() 'esto lo llamo desde mesa_asignar, para q guarde en la grilla y la bd solo el precio del turno
        'agrego una nueva fila
        Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
        newCustomersRow("PROD_id") = "0" 'porque es un turno :D
        newCustomersRow("codinterno") = "0000" 'no tiene codigo interno
        newCustomersRow("descripcion") = "Turno en cancha"
        newCustomersRow("detalle") = "Turno en cancha"
        newCustomersRow("cantidad") = "1"
        newCustomersRow("precio_unitario") = CDec(PAGADO_procedencia_mesa_asignar + SALDO_procedencia_mesa_asignar)
        newCustomersRow("precio_subtotal") = SALDO_procedencia_mesa_asignar
        newCustomersRow("codbarra") = ""
        newCustomersRow("TURNO_id") = TURNO_id_procedencia_mesa_asignar  'aqui va el turno_id
        Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
        DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        Dim a As Integer = DataG_lista.Rows.Count
        DataG_lista.Rows(a - 1).Cells(0).Value = a
        calcular_totales()



        'GUARDAR EN TABLA "Venta_Producto"///////////////////////////////////////////////////////////////////////////////////
        Dim usuario_id As String
        usuario_id = US_administrador.USU_id 'obtengo del formulario principal el id del usuario actual
        'Dim tipo_vta As String = tipo_vta
        Dim cliente_id As Integer = cliente_id

        If DataG_lista.Rows(0).Cells("PreciosubtotalDataGridViewTextBoxColumn").Value = "" Then
            DataG_lista.Rows(0).Cells("PreciosubtotalDataGridViewTextBoxColumn").Value = CDec(0)
        End If

        Dim pago_parcial As Decimal = CDec(DataG_lista.Rows(0).Cells("PreciosubtotalDataGridViewTextBoxColumn").Value)
        Dim estado As String = ""
        If pago_parcial >= CDec(DataG_lista.Rows(0).Cells("PreciounitarioDataGridViewTextBoxColumn").Value) Then
            'estado = "Cobrado"

            If CDec(pago_parcial) > CDec(DataG_lista.Rows(0).Cells("PreciounitarioDataGridViewTextBoxColumn").Value) Then
                pago_parcial = CDec(DataG_listaTotal.Rows(0).Cells(1).Value)
            End If

        Else
            estado = "Ocupado"
        End If
        Dim ventaprod_id As Integer = ventaprod_id

        Dim total As Decimal = CDec(DataG_listaTotal.Rows(0).Cells(1).Value)

        DAventa.VentaProducto_modificar_mesa(ventaprod_id, total, pago_parcial, estado)


        DAventa.MESAS_modificar(mesa_id, Label_mesa.Text, estado, "Si", ventaprod_id)


        'Dim ventaprod_id As Integer = CInt(Mesas_gestion.DataGridView1.CurrentRow.Cells("VentaprodidDataGridViewTextBoxColumn").Value)

        'primero borro los item de la tabla detalle venta
        DAventa.VentaProductoDetalle_borrar(ventaprod_id)
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        'GUARDAR EN TABLA "Venta_Producto_detalle"
        For Each row As DataGridViewRow In DataG_lista.Rows
            DAventa.VentaProductoDetalle_alta(ventaprod_id, row.Cells(1).Value, row.Cells(5).Value, CDec(row.Cells(6).Value), CDec(row.Cells(7).Value), row.Cells(3).Value, row.Cells(2).Value, row.Cells(9).Value, CDec(0))
        Next

        'actualizo estado de mesa, y relaciono con venta


        'DAventa.MESAS_modificar(Mesas_gestion.DataGridView1.CurrentRow.Cells("MESAidDataGridViewTextBoxColumn").Value, ventaprod_id, estado)

        'aqui hago el descuento de stock...
        'primero de los productos ....luego de los combos...(ya q estan formados por varios productos)

    End Sub



    Private Sub Mesa_cargar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then 'F1
            Busqueda_Productos.form_procedencia = "Mesa_cargar"
            Busqueda_Productos.Show()
            Busqueda_Productos.tx_Buscar.Focus()

        End If
        If e.KeyCode = Keys.F2 Then
            Ver_promocion.form_procedencia = "Mesa_cargar"
            Ver_promocion.Show()
            Ver_promocion.tx_Buscar.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            Salir()
        End If

    End Sub
    Private Sub Mesa_cargar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Focus()
        TX_busc_codinterno.Focus()
        tx_cantidad.MaxLength = 6
        Obtener_Promociones_2()



        'Abrir_mesa()

        'Obtener_Productos_Combos()
    End Sub

#Region "METODOS"
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


        If RB_Si = False Then

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
            If RB_No = False Then
                DS_PROD = DAventa.Venta_obtenerProducto_listaregular(CB_lista)

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

    Public Sub obtener_productos_de_venta(ByVal ventaprod_id As Integer)
        Venta_Caja_ds.Tables("Producto_agregado").Rows.Clear()
        DataG_lista.DataSource = Nothing

        Dim items_venta As DataSet = DAventa.VentaProductoDetalle_buscar(ventaprod_id)


        Dim k As Integer = 0
        While k < items_venta.Tables(0).Rows.Count

            Dim busc_codinterno As String = items_venta.Tables(0).Rows(k).Item("codigointerno")
            Dim cant_registrada As Integer = items_venta.Tables(0).Rows(k).Item("ventaprod_cant")



            If busc_codinterno <> "" And busc_codinterno <> "0000" Then
                Dim i As Integer = 0
                Dim encontrado As String = "No"
                Dim T As Integer = 0
                If RB_No = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
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
                            If RB_No = True Then
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
                            newCustomersRow("TURNO_id") = 0
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
                                newCustomersRow("TURNO_id") = 0
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


        'ahora agregamos los q sean de turnos
        Dim tur As Integer = 0
        While tur < items_venta.Tables(0).Rows.Count

            If items_venta.Tables(0).Rows(tur).Item("codigointerno") = "0000" Then
                'agrego una nueva fila
                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                newCustomersRow("PROD_id") = CStr("0")
                newCustomersRow("codinterno") = "0000"
                newCustomersRow("descripcion") = "Turno en cancha"
                'newCustomersRow("detalle") = 
                Dim cant As Integer = CInt(1)
                newCustomersRow("cantidad") = cant
                newCustomersRow("precio_unitario") = items_venta.Tables(0).Rows(tur).Item("ventaprod_precio")
                newCustomersRow("precio_subtotal") = items_venta.Tables(0).Rows(tur).Item("ventaprod_subtotal")
                newCustomersRow("codbarra") = " "
                newCustomersRow("TURNO_id") = items_venta.Tables(0).Rows(tur).Item("TURNO_id")
                Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                Dim a As Integer = DataG_lista.Rows.Count
                DataG_lista.Rows(a - 1).Cells(0).Value = a
            End If
            tur = tur + 1
        End While


        calcular_totales()
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
#End Region

    Public Ventaprod_id As Integer = 0
    Public RB_No As Boolean = True
    Public RB_Si As Boolean = False
    Public CB_lista As Integer = 0
    Public cliente_id As Integer = 0
    Public pago_parcial As Decimal = CDec(0)
    Public mesa_id As Integer = 0
    Public sector_id As Integer = 0

    Public Sub Abrir_mesa()

        'veo si tiene configuracion
        Dim ds_config As DataSet = DAventa.VentaConfig_buscar(Ventaprod_id)
        If ds_config.Tables(0).Rows.Count <> 0 Then
            'MsgBox("tiene configuracion")
            RB_Si = True
            RB_No = False
            CB_lista = ds_config.Tables(0).Rows(0).Item("LISTA_id")
        Else
            'MsgBox("no tiene configuracion")
            RB_No = True
            RB_Si = False
        End If

        GroupBox12.Enabled = True 'habilito la pestaña 2
        'GroupBox1.Enabled = False
        'GroupBox2.Enabled = False
        'GroupBox3.Enabled = False
        'LIMPIAR LA GRILLA DE PROD AGREGADOS
        DataG_lista.DataSource = Nothing

        'Call habilitar_columnas_edicion()
        Call Obtener_Productos_Combos()
        tx_cantidad.Text = 1
        Me.Focus()
        TX_busc_codinterno.Focus()
        TX_busc_codinterno.SelectAll()
        Call obtener_productos_de_venta(Ventaprod_id)




        Lb_pagoparcial.Text = Math.Round(pago_parcial, 2).ToString("N2")


        'AQUI LLAMO CARGO EN LA GRILLA EL PRECIO DEL TURNO A COBRAR.




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
                If RB_No = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
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
                            If RB_No = True Then
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
                            newCustomersRow("TURNO_id") = 0

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
                                newCustomersRow("TURNO_id") = 0
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
                If RB_No = True Then 'ESTO LO HAGO X Q EN EL MISMO DATA SET para los productos comunes es table 1, y para las lista regular seleccionada es table 0
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
                            'If CStr(DataG_lista.Rows(item).Cells("codbarra").Value) = TX_busc_codibarra.Text Then
                            If CStr(DataG_lista.Rows(item).Cells("CodbarraDataGridViewTextBoxColumn").Value) = TX_busc_codibarra.Text Then

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
                            If RB_No = True Then
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
                            newCustomersRow("TURNO_id") = 0
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
            'TX_busc_codinterno.Focus()
            'TX_busc_codinterno.SelectAll()
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

    Private Sub Quitar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Quitar.Click
        'aqui elemino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"
        If DataG_lista.Rows.Count <> 0 Then
            'If DataG_lista.CurrentRow.Cells(0).Value <> "" Then
            'If MsgBox("Esta seguro que quiere borrar la informacion del item seleccionado?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            'primero guardo el nro de item q contiene
            Dim item As Decimal = DataG_lista.CurrentRow.Index



            'If DataG_lista.CurrentRow.Cells("DescripcionDataGridViewTextBoxColumn").Value <> "Turno en cancha" Then
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

            'End If
            'este codigo si va
            'Call Cargar_Totales(añosdelproyecto)
            'modificado = 1
            'End If
            'End If
        End If
        DataG_lista.Refresh()




    End Sub


    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If DataG_lista.Rows.Count <> 0 Then
            'la mesa nueva en realidad es un modulo para cobrar :P
            Mesa_nueva.tx_total.Text = CDec(DataG_listaTotal.Rows(0).Cells(1).Value) - CDec(pago_parcial) 'total menos pago parcial, para generar lo q realmente se debe
            Mesa_nueva.tx_total.Text = (Math.Round(CDec(Mesa_nueva.tx_total.Text), 2).ToString("N2"))
            Mesa_nueva.tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Mesa_nueva.Show()
            Mesa_nueva.mesa_id = mesa_id
            Mesa_nueva.Label_mesa = Label_mesa.Text
            Mesa_nueva.sector_id = sector_id
            Mesa_nueva.form_procedencia = form_procedencia
        End If
    End Sub

    



    Private Sub BO_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_buscar.Click
        Busqueda_Productos.form_procedencia = "Mesa_cargar"
        Busqueda_Productos.Show()
        Busqueda_Productos.tx_Buscar.Focus()
    End Sub

    Private Sub BO_promocion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_promocion.Click
        Ver_promocion.form_procedencia = "Mesa_cargar"
        Ver_promocion.Show()
        Ver_promocion.tx_Buscar.Focus()
    End Sub

    Public Sub Salir()
        If DataG_lista.Rows.Count <> 0 Then
            Dim usuario_id As String
            usuario_id = US_administrador.USU_id 'obtengo del formulario principal el id del usuario actual
            Dim estado = "Ocupado"
            Dim total As Decimal = CDec(DataG_listaTotal.Rows(0).Cells(1).Value)

            DAventa.VentaProducto_modificar_mesa(Ventaprod_id, total, pago_parcial, estado)
            DAventa.MESAS_modificar(mesa_id, Label_mesa.Text, estado, "Si", Ventaprod_id)

            'primero borro los item de la tabla detalle venta
            DAventa.VentaProductoDetalle_borrar(Ventaprod_id)
            '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            'GUARDAR EN TABLA "Venta_Producto_detalle"
            For Each row As DataGridViewRow In DataG_lista.Rows
                DAventa.VentaProductoDetalle_alta(Ventaprod_id, row.Cells(1).Value, row.Cells(5).Value, CDec(row.Cells(6).Value), CDec(row.Cells(7).Value), row.Cells(3).Value, row.Cells(2).Value, row.Cells(9).Value, CDec(0))
            Next


            Mesas_gestion_2_new.recuperar_mesas()

            Ver_promocion.Close()
            Busqueda_Productos.Close()
            Me.Close()
        Else
            MessageBox.Show("La Mesa Fue Asignada Debe Cargar Al Menos Un Producto", "HAMERSOFT")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Salir()

      
    End Sub

    
End Class


