Public Class Pedido_Productos
    Dim DApedidos As New Datos.Pedidos
    Public DS_PROD As DataSet
    Public prov_id
    Dim fila_mover As Integer = 0
    Dim listo As String = "no"
    Public Pedidos_ID = 0
    Public proveedor_id As Integer 'este parametro lo traigo del form: Pedidos_New
    Dim ds_Prod_x_Prove As New dsPedidos
    Public Prove_ID
    Public form_procedencia As String
    Public tipo_prod
    Dim ds_pedidos As New Pedidos_reporte_DS
    Private Sub Pedido_Productos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'NOTA: DEBE ESTAR LA PROPIEDAD DEL FORM "KEYPREVIEW = TRUE" para q se ejecute el evento keydown.
        If e.KeyCode = Keys.F1 Then 'F1
            Busqueda_Productos.Text = "Busqueda de productos - Proveedor: " + Label_prov.Text
            Busqueda_Productos.form_procedencia = "Pedido_Productos"
            Busqueda_Productos.Show()
            'Busqueda_Productos.tx_Buscar.Focus()
        End If
    End Sub
    Private Sub Pedido_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Obtener_Productos()
        habilitar_columnas_edicion()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Add()
        DataGridView1.Focus()
        DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True

        If Pedidos_ID <> 0 Then
            Cargar_Editar()
        End If

        'If Pedidos_Consulta_NEW.DG_Pedido.SelectedCells(6).Value = "FINALIZADO" Then
        '    DataGridView1.Enabled = False
        '    btn_guardar.Enabled = False
        'End If

    End Sub
    Private Sub Cargar_Editar()
        Dim Ds_pedidos = DApedidos.Pedidos_ObtenerDetalle_X_idPedido(Pedidos_ID)
        Dim i As Integer = 0
        Dim index As Integer = 1
        While i < Ds_pedidos.Tables(0).Rows.Count
            DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells("item_num").Value = index
            DataGridView1.Rows(i).Cells("prod_id").Value = Ds_pedidos.Tables(0).Rows(i).Item("prod_id").ToString
            DataGridView1.Rows(i).Cells("prod_codinterno").Value = Ds_pedidos.Tables(0).Rows(i).Item("prod_codinterno").ToString
            DataGridView1.Rows(i).Cells("prod_descripcion").Value = Ds_pedidos.Tables(0).Rows(i).Item("prod_descripcion").ToString
            DataGridView1.Rows(i).Cells("Cantidad").Value = Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_Cantida")
            Dim precioU = Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_precioU")
            DataGridView1.Rows(i).Cells("Precio_U").Value = Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_precioU")
            Dim subtotal = Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_Total")
            DataGridView1.Rows(i).Cells("Subtotal").Value = Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_Total")
            i = i + 1
            index = index + 1
        End While
        DataGridView1.Rows(i).Cells("prod_codinterno").Selected = True
        calcular_total()

    End Sub


    Private Sub Obtener_Productos()
        DS_PROD = DApedidos.Productos_x_Proveedor_Obtener(Prove_ID)
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


            Me.DataGridView1.Rows(fila).Cells(1).Style.BackColor = Color.GhostWhite
            Me.DataGridView1.Rows(fila).Cells(3).Style.BackColor = Color.GhostWhite


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

#Region "Validacion de grilla - solo numeros en celda"

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        If e.Exception IsNot Nothing AndAlso e.Context = DataGridViewDataErrorContexts.Commit Then
            MessageBox.Show("Error, ingrese un valor no nulo")
        End If
    End Sub
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing

        valido_fraccionable(DataGridView1.CurrentRow.Cells("prod_codinterno").Value)

        'referencia a la celda



        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregar el controlador de eventos para el keypress
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub
    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim columna As Integer = DataGridView1.CurrentCell.ColumnIndex

        If DataGridView1.CurrentRow.Cells("prod_codinterno").Value = "" And (columna = 4 Or columna = 5) Then
            e.Handled = True 'bloque el ingreso de numeros si no se ha recuperado la info de un producto

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

            If tipo_prod = "Fraccionable" Or DataGridView1.CurrentCell.ColumnIndex = 5 Then
                'obtener caracter
                Dim caracter As Char = e.KeyChar
                'referencia a la celda
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







            '        Dim KeyAscii As Integer = AscW(e.KeyChar)

            '        If (KeyAscii >= 97 And KeyAscii <= 122) Or (KeyAscii >= 65 And KeyAscii <= 90) Then
            '            e.Handled = True 'deshabilito si es una tela entre la a-z o A-Z
            '        Else
            '            e.Handled = False
            '        End If

            '    End If
            'Else 'si la celda cero de la fila actual es vacio...no dejo escribir nada
            '    e.Handled = True
            'End If
        End If


    End Sub
    Private Sub valido_fraccionable(ByVal cod_ingresado As String)

        Encontrado = "no"
        Dim i As Integer = 0
        While i < DS_PROD.Tables(0).Rows.Count
            Dim cod_interno As String = DS_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
            If cod_ingresado = cod_interno Then

                '' si es fraccionable o no el producto solamente por este if pasa''
                tipo_prod = DS_PROD.Tables(0).Rows(i).Item("prod_tipo").ToString
                '''''''''''''''''''''''''''''MARIANO 17/6/19'''''''''''''''''''''''

                'Dim index As Integer = DataGridView1.CurrentRow.Index
                'DataGridView1.CurrentRow.Cells("item_num").Value = CInt(DataGridView1.CurrentRow.Index + 1)
                'DataGridView1.CurrentRow.Cells("prod_id").Value = DS_PROD.Tables(0).Rows(i).Item("prod_id").ToString
                'DataGridView1.CurrentRow.Cells("prod_codinterno").Value = DS_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
                'DataGridView1.CurrentRow.Cells("prod_descripcion").Value = DS_PROD.Tables(0).Rows(i).Item("prod_descripcion").ToString
                'DataGridView1.CurrentRow.Cells("Cantidad").Value = CInt(1)
                Encontrado = "si"
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

    Private Sub calcular_subtotales()
        Dim precio As Decimal = 0
        'Dim cantidad As Integer = CInt(DataGridView1.CurrentRow.Cells("columna_cantidad").Value)
        Dim cantidad As Decimal = CDec(DataGridView1.CurrentRow.Cells("Cantidad").Value)
        precio = cantidad * DataGridView1.CurrentRow.Cells("Precio_U").Value
        DataGridView1.CurrentRow.Cells("Precio_U").Value = CDec(DataGridView1.CurrentRow.Cells("Precio_U").Value)
        DataGridView1.CurrentRow.Cells("Subtotal").Value = CDec(precio) 'CDec(Math.Round(precio, 2)).ToString("N2")
    End Sub
    Private Sub calcular_total()
        'falta hacer el while q calculo el total estimado del pedido
        'sumamos los subtotales con un ciclo
        Dim sumar As Decimal = CDec(0)
        Dim ii As Integer = 0
        While ii < DataGridView1.Rows.Count   'DataG_lista.Rows.Count
            sumar = sumar + CDec(DataGridView1.Rows(ii).Cells("Subtotal").Value)
            ii = ii + 1
        End While
        sumar = Math.Round(sumar, 2).ToString("N2")
        txt_total.Text = sumar
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If DataGridView1.CurrentCell.ColumnIndex = 2 And DataGridView1.CurrentCell.Value IsNot DBNull.Value Then 'la columna 2 es Cod interno
            Buscar_y_cargar_en_grilla(DataGridView1.CurrentCell.Value)
            calcular_total()
            'DataGridView1.CurrentRow.Cells("columna_descripcion").Value = "producto"
            'DataGridView1.CurrentRow.Cells("columna_cantidad").Value = "10"
            fila_mover = DataGridView1.CurrentRow.Index
            If Encontrado = "si" Then
                listo = "si"
            Else
                listo = "no"
            End If

        End If

        If DataGridView1.CurrentCell.ColumnIndex = 4 Then 'la columna 5 es Cantidad
            'Dim precio As Decimal = 0
            'Dim cantidad As Integer = CInt(DataGridView1.CurrentRow.Cells("columna_cantidad").Value)
            'precio = cantidad * CDec(DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value)
            'DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(precio) 'CDec(Math.Round(precio, 2)).ToString("N2")
            calcular_subtotales()
            calcular_total()

            fila_mover = DataGridView1.CurrentRow.Index
            'calcular_totales()
            'aplicar_iva()
            listo = "si, mover a precio"

        End If

        If DataGridView1.CurrentCell.ColumnIndex = 5 Then 'la columna 5 es precio unitario
            calcular_subtotales()
            calcular_total()
            fila_mover = DataGridView1.CurrentRow.Index
            listo = "si, sig fila"
            'aqui va calculo de subtotales y total del pedido



        End If


    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If DataGridView1.CurrentCell.ColumnIndex = 2 And CStr(DataGridView1.CurrentRow.Cells("item_num").Value) <> "" Then
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                'DataGridView1.CurrentRow.Cells("columna_descripcion").Value = "producto"
                'DataGridView1.CurrentRow.Cells("columna_cantidad").Value = "10"
                SendKeys.Send("{TAB}")
                SendKeys.Send("{TAB}")

            End If
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 4 Then
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                SendKeys.Send("{TAB}")
                'SendKeys.Send("{TAB}")
                'SendKeys.Send("{TAB}") 'esta lo hago, x q agregue la columna check "column1"
            End If
        End If

        If DataGridView1.CurrentCell.ColumnIndex = 5 Then
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                SendKeys.Send("{TAB}")
                SendKeys.Send("{TAB}")
                SendKeys.Send("{TAB}")
                SendKeys.Send("{TAB}") 'esta lo hago, x q agregue la columna check "column1"
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

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'NOTA: cuando hago click sobre las celdas q no son editables se cambia el foco a las celdas cod_interno y cantidad 
        Dim celda_actual As Integer = DataGridView1.CurrentCell.ColumnIndex
        Select Case celda_actual
            Case 0
                SendKeys.Send("{TAB}")
            Case 3
                SendKeys.Send("{LEFT}")
            Case 6
                SendKeys.Send("{LEFT}")
        End Select
    End Sub


#End Region


    Dim Encontrado As String = "no"
    Public Sub Buscar_y_cargar_en_grilla(ByVal cod_ingresado As String)
        Encontrado = "no"
        Dim i As Integer = 0
        While i < DS_PROD.Tables(0).Rows.Count
            Dim cod_interno As String = DS_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
            If cod_ingresado = cod_interno Then

                '' si es fraccionable o no el producto solamente por este if pasa''
                tipo_prod = DS_PROD.Tables(0).Rows(i).Item("prod_tipo").ToString
                '''''''''''''''''''''''''''''MARIANO 17/6/19'''''''''''''''''''''''

                Dim index As Integer = DataGridView1.CurrentRow.Index
                DataGridView1.CurrentRow.Cells("item_num").Value = CInt(DataGridView1.CurrentRow.Index + 1)
                DataGridView1.CurrentRow.Cells("prod_id").Value = DS_PROD.Tables(0).Rows(i).Item("prod_id").ToString
                DataGridView1.CurrentRow.Cells("prod_codinterno").Value = DS_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
                DataGridView1.CurrentRow.Cells("prod_descripcion").Value = DS_PROD.Tables(0).Rows(i).Item("prod_descripcion").ToString
                DataGridView1.CurrentRow.Cells("Cantidad").Value = CInt(1)
                DataGridView1.CurrentRow.Cells("Precio_U").Value = Math.Round(0, 2).ToString("N2")
                DataGridView1.CurrentRow.Cells("Subtotal").Value = Math.Round(0, 2).ToString("N2")
                Encontrado = "si"
            End If
            i = i + 1
        End While
        If Encontrado = "no" Then
            'buscar por codigo de barras
            DataGridView1.CurrentRow.Cells("item_num").Value = ""
            DataGridView1.CurrentRow.Cells("prod_id").Value = ""
            DataGridView1.CurrentRow.Cells("prod_codinterno").Value = ""
            DataGridView1.CurrentRow.Cells("prod_descripcion").Value = ""
            DataGridView1.CurrentRow.Cells("Cantidad").Value = ""
            DataGridView1.CurrentRow.Cells("Precio_U").Value = ""
            DataGridView1.CurrentRow.Cells("Subtotal").Value = Math.Round(0, 2).ToString("N2")
            MessageBox.Show("No existe el producto para ese proveedor", "Sistema de Gestión")
        End If
        If DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value <> "" Then
            DataGridView1.Rows.Add()
        End If


    End Sub


    Private Sub alta()
        Dim DS_Pedidos As DataSet
        Dim Ped_id As String
        DS_Pedidos = DApedidos.Pedidos_Alta(Label_Pedido.Text, Label_fecha.Text, CInt(Prove_ID), CDec(txt_total.Text), 1, Inicio.suc_id, Inicio.USU_id)
        Ped_id = CType(DS_Pedidos.Tables(0).Rows(0).Item("Pedidos_ID"), String)
        'Pedidos_New.Generar_cod_interno()
        'Pedidos_detalle_Alta___Mirar en la Clase La explicacion
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("prod_id").Value <> Nothing And row.Cells("Cantidad").Value <> Nothing Then
                DApedidos.Pedidos_Detalle_Alta(Ped_id, row.Cells("prod_id").Value, row.Cells("Cantidad").Value, CDec(row.Cells("Subtotal").Value), CDec(row.Cells("Precio_U").Value))
            End If
        Next
        MessageBox.Show("El Pedido Fue Guardado Correctamente", "Sistema de Gestion.", MessageBoxButtons.OK)
        Me.Close()

        Pedidos_New.Show() 'este si viene del form: pedidos_new
        'vuelve a pedidos consulta
    End Sub

    Private Sub modificar()
        Dim DS_Pedidos As DataSet
        Dim Ped_id As String
        DS_Pedidos = DApedidos.Pedidos_Actualizar(Now, Pedidos_Consulta_NEW.DG_Pedido.SelectedCells(0).Value, 1, txt_total.Text)
        Ped_id = Pedidos_Consulta_NEW.DG_Pedido.SelectedCells(0).Value
        'Pedidos_detalle_Alta___Mirar en la Clase La explicacion
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("prod_id").Value <> Nothing And row.Cells("Cantidad").Value <> Nothing Then
                DApedidos.Pedidos_Detalle_Alta(Ped_id, row.Cells("prod_id").Value, row.Cells("Cantidad").Value, CDec(row.Cells("Subtotal").Value), CDec(row.Cells("Precio_U").Value))
            End If
        Next
        MessageBox.Show("El Pedido fue modificado correctamente", "Sistema de Gestion.", MessageBoxButtons.OK)
        Me.Close()

    End Sub

    Private Sub validar_alta_modificacion(ByRef valido As String)
        'valido q la grilla tenga items agregados

        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells("prod_codinterno").Value <> "" Then
                valido = "si"
            End If
            i = i + 1
        End While
        If valido = "no" Then
            MessageBox.Show("ingrese productos en la lista de pedido", "Sistema de Gestión.")
        End If
    End Sub



    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Select Case form_procedencia
            Case "Pedidos_new" 'si viene de "Pedidos_new"
                Dim result As DialogResult
                result = MessageBox.Show("¿Desea guardar el nuevo pedido?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    Dim valido = "no"
                    validar_alta_modificacion(valido)
                    If valido = "si" Then
                        alta()
                    End If
                End If
            Case "Pedidos_Consulta_NEW" 'si se selecciono editar en el form Pedidos_Consulta_NEW - este boton esta deshabilitado x ahora
                Dim result As DialogResult
                result = MessageBox.Show("¿Desea modificar el pedido?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    Dim valido = "no"
                    validar_alta_modificacion(valido)
                    If valido = "si" Then
                        modificar()
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Select Case form_procedencia
            Case "Pedidos_new" 'registro de nuevo pedido
                DataGridView1.Rows.Clear()
                Me.Close()
                Pedidos_New.Show()
            Case "Pedidos_Consulta_NEW" 'consulta de pedidos ya generados
                Me.Close()
        End Select
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If Encontrado = "si" Then
            If listo = "si" Then
                'volver a seleccionar anterior
                DataGridView1.CurrentCell = DataGridView1(4, fila_mover)
                listo = "no"
            End If
            If listo = "si, mover a precio" Then
                DataGridView1.CurrentCell = DataGridView1(5, fila_mover)
                listo = "no"
            End If

            If listo = "si, sig fila" Then
                'volver a seleccionar anterior
                'generar_fila_grid()
                DataGridView1.CurrentCell = DataGridView1(2, fila_mover + 1)
                listo = "no"
            End If
        Else
            'si no lo encuentra quedar en la misma celda
            'DataGridView1.CurrentCell = DataGridView1(2, fila_mover)
            listo = "no"
        End If
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        If DataGridView1.Rows.Count <> 0 Then

            Dim result As DialogResult
            result = MessageBox.Show("¿Desea quitar todos los productos del listado?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                DataGridView1.Rows.Clear()
                DataGridView1.Rows.Add()
                DataGridView1.Focus()
                DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True
            End If
        Else
            MessageBox.Show("No hay productos en el listado", "Sistema de Gestión")
        End If
        calcular_total()
    End Sub

    Private Sub btn_eliminar_seleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_seleccion.Click
        ''aqui elemino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
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
                        'calcular_totales()
                        'aplicar_iva()
                    End If
                Else
                    i = i + 1
                End If

            End While

            'ahora si me queda la grilla vacia..agrero un row para q pueda escribir
            If DataGridView1.Rows.Count = 0 Then
                DataGridView1.Rows.Add()
                DataGridView1.Focus()
                DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True
            End If

        End If
        calcular_total()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        crear_reporte()
    End Sub
    Dim DAempresa As New Datos.Empresa
    Private Sub crear_reporte()
        ds_pedidos.Tables("Pedido").Rows.Clear()
        ds_pedidos.Tables("Pedido_detalle").Rows.Clear()
        ds_pedidos.Tables("Empresa").Rows.Clear()

        Dim ds_empresa As DataSet = DAempresa.Empresa_obtener_reporte()
        '////////////////TABLA EMPRESA////////////////////////
        If ds_empresa.Tables(0).Rows.Count <> 0 Then
            ds_pedidos.Tables("Empresa").Merge(ds_empresa.Tables(0))
        End If
        '//////////////////TABLA PEDIDOS////////////////////////////
        Dim row_pedido As DataRow = ds_pedidos.Tables("Pedido").NewRow()
        row_pedido("Fecha") = Label_fecha.Text
        row_pedido("Nro_pedido") = Label_Pedido.Text
        row_pedido("Proveedor") = Label_prov.Text
        row_pedido("Total_estimado") = txt_total.Text
        row_pedido("Estado") = "Pendiente"
        ds_pedidos.Tables("Pedido").Rows.Add(row_pedido)

        '/////////////////TABLA DETALLE PEDIDO///////////////////////
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells(3).Value <> "" Then
                Dim row_prodADD As DataRow = ds_pedidos.Tables("Pedido_detalle").NewRow()
                row_prodADD("Producto") = DataGridView1.Rows(i).Cells("prod_descripcion").Value
                row_prodADD("Cantidad") = DataGridView1.Rows(i).Cells("Cantidad").Value
                row_prodADD("Precio_U") = DataGridView1.Rows(i).Cells("Precio_U").Value
                row_prodADD("Subtotal") = DataGridView1.Rows(i).Cells("Subtotal").Value
                ds_pedidos.Tables("Pedido_detalle").Rows.Add(row_prodADD)
            End If
            
            i = i + 1
        End While


        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Pedidos\Reporte\CR_Pedido.rpt")
        CrReport.Database.Tables("Pedido").SetDataSource(ds_pedidos.Tables("Pedido"))
        CrReport.Database.Tables("Pedido_detalle").SetDataSource(ds_pedidos.Tables("Pedido_detalle"))
        CrReport.Database.Tables("Empresa").SetDataSource(ds_pedidos.Tables("Empresa"))
        Pedido_reporte_show.CrystalReportViewer1.ReportSource = CrReport
        Pedido_reporte_show.Show()

    End Sub
End Class