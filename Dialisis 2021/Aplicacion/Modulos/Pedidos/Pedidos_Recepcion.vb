Public Class Pedidos_Recepcion
    Dim ds_proveedor As DataSet
    Dim DAproveedores As New Datos.Proveedor
    Dim DAsucursal As New Datos.Sucursal
    Dim DAproducto As New Datos.Producto
    Dim DAventa As New Datos.Venta 'la uso para actualizar el stock en sucursal
    Dim DApedidos As New Datos.Pedidos
    Dim Ds_pedidos As DataSet
    Public DS_PROD As DataSet 'lo uso en la rutina "Obtener_Productos"
    Public Pedidos_ID
    Public Prove_ID
    Dim ds_Prod_x_Prove As New dsPedidos 'Instancio el datases al conjunto de datos creado en el diseñador'
    Public pedido_finalizar 'esta la uso solamente para validar si pongo la columnas en color en caso de editar valores en grilla
    Private Sub Pedidos_Recepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sucursales_Obtener()
        cargar_grilla()

        'si entro a recepcion y no el modulo de "ver", hago q la columas editables queden en blanco
        If pedido_finalizar = "si" Then
            DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
            DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
            DataGridView1.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
            DataGridView1.Columns(4).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
            DataGridView1.Columns(7).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
            pedido_finalizar = ""
        End If
        


        Obtener_Productos()
    End Sub

    Private Sub cargar_grilla()
        Ds_pedidos = DApedidos.Pedidos_ObtenerDetalle_X_idPedido(Pedidos_ID)
        Dim i As Integer = 0
        Dim index As Integer = 1
        While i < Ds_pedidos.Tables(0).Rows.Count
            Dim ProductoRow As DataRow = ds_Prod_x_Prove.Tables("Productos_x_Proveedor").NewRow()
            ProductoRow("item_num") = index
            ProductoRow("prod_codinterno") = Ds_pedidos.Tables(0).Rows(i).Item("prod_codinterno").ToString
            ProductoRow("prod_descripcion") = Ds_pedidos.Tables(0).Rows(i).Item("prod_descripcion").ToString
            ProductoRow("Cantidad") = Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_Cantida").ToString
            ProductoRow("Cant_recibida") = Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_Cantida")
            ProductoRow("Precio_U") = Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_precioU")
            ProductoRow("Subtotal") = Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_Total")

            ds_Prod_x_Prove.Tables("Productos_x_Proveedor").Rows.Add(ProductoRow)
            i = i + 1
            index = index + 1
        End While
        DataGridView1.DataSource = ds_Prod_x_Prove.Tables("Productos_x_Proveedor")
        If Ds_pedidos.Tables(1).Rows(0).Item("PEDIDO_EST_nom") = "FINALIZADO" Then
            Label_estado.ForeColor = Color.Green

            'Dim indice_estado As Integer = aqui va el id de sucursal
            ComboBox_suc.SelectedValue = Ds_pedidos.Tables(1).Rows(0).Item("sucursal_id")
            ComboBox_suc.Enabled = False
            ComboBox_suc.BackColor = Color.White
            DataGridView1.ReadOnly = True

            GroupBox_recepcion.Visible = True
            tx_sucursal.Text = ComboBox_suc.Text
            tx_usuario.Text = Ds_pedidos.Tables(1).Rows(0).Item("Usuario")
            fecha_recepcion.Text = Ds_pedidos.Tables(1).Rows(0).Item("Fecha_recepcion")
        End If
        calcular_total()

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

    Private Sub Sucursales_Obtener()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        ComboBox_suc.DataSource = ds.Tables(0)
        ComboBox_suc.DisplayMember = "sucursal_nombre"
        ComboBox_suc.ValueMember = "sucursal_id"
    End Sub


    Private Sub actualizar_stock_en_sucursal(ByVal i As Integer)
        Dim prod_codigo As Integer = CInt(DataGridView1.Rows(i).Cells("prod_codinterno").Value)
        Dim sucursal_id As Integer = ComboBox_suc.SelectedValue
        Dim ds_stock As DataSet = DAproducto.Producto_x_sucursal_buscarcod(prod_codigo, sucursal_id)
        If ds_stock.Tables(0).Rows.Count <> 0 Then
            Dim stock_actual As Decimal = CDec(ds_stock.Tables(0).Rows(0).Item("ProdxSuc_stock"))
            Dim stock_nuevo As Decimal = CDec(ds_stock.Tables(0).Rows(0).Item("ProdxSuc_stock")) + CDec(DataGridView1.Rows(i).Cells("Cant_recibida").Value)
            DAventa.Venta_actualizar_stock_Caja(prod_codigo, stock_nuevo, 0, sucursal_id)
        End If
    End Sub

    Private Sub Button_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_guardar.Click
        Dim result2 As Integer = MessageBox.Show("El Pedido Actualizará el stock en la Sucursal " + ComboBox_suc.Text + " ¿Desea Continuar?", "Sistema de Gestion", MessageBoxButtons.YesNo)
        If result2 = DialogResult.Yes Then
            Dim Incompleto = "no"
            Dim i As Integer = 0
            ''Guardo Las Cantidades Actualizadas
            While i < Ds_pedidos.Tables(0).Rows.Count
                Dim CantRecibida As Decimal = DataGridView1.Rows(i).Cells("Cant_recibida").Value
                DApedidos.Pedidos_ActualizarCantidad(Ds_pedidos.Tables(0).Rows(i).Item("PedidosDet_ID").ToString,
                                                       ds_Prod_x_Prove.Tables("Productos_x_Proveedor").Rows(i).Item("Cant_recibida"),
                                                        ds_Prod_x_Prove.Tables("Productos_x_Proveedor").Rows(i).Item("Subtotal"), CantRecibida, ds_Prod_x_Prove.Tables("Productos_x_Proveedor").Rows(i).Item("Precio_U")) 'OJO PERO NO EL STOCK

                'AHORA SI ACTUALIZO STOCK EN SUCURSAL SELECCIONADA
                actualizar_stock_en_sucursal(i)
                i = i + 1
            End While

            'necesito usuario y sucursal
            Dim usuario_id As String
            usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
            Dim sucursal_id As Integer = ComboBox_suc.SelectedValue

            DApedidos.Pedidos_ActualizarEstado(Ds_pedidos.Tables(0).Rows(0).Item("Pedidos_ID").ToString, 3, usuario_id, sucursal_id, Now, txt_total.Text) 'estado=3 finalizado
            MessageBox.Show("El Pedido Fue Cerrado")

            'CIERRO Y ABRO NUEVAMENTE LA RECEPCION, PARA Q SE VEAN REFLEJADOS LOS CAMBIOS
            '-------------------------------------------------------------------------
            Pedidos_Consulta_NEW.Close()
            Pedidos_Consulta_NEW.Text = "Recepción de pedidos (F1 busqueda avanzada)"
            Pedidos_Consulta_NEW.Button_ver.Visible = False
            Pedidos_Consulta_NEW.Button_editar.Visible = False
            Pedidos_Consulta_NEW.Show()
            '-------------------------------------------------------------------------

            'me fijo si las cantides son diferentes
            'For Each row As DataGridViewRow In DataGridView1.Rows
            '    If row.Cells("Cant_recibida").Value < row.Cells("Cantidad").Value Then 'Si la cant recibida es menor a la pedida, pregunto si quiero cerrar el pedido
            '        Incompleto = "si"
            '    End If
            'Next

            'Actualizo los estados
            'If Incompleto = "si" Then
            '    Dim result As Integer = MessageBox.Show("Desea Cerrar el Pedido", "Sistema de Gestion", MessageBoxButtons.YesNo)
            '    If result = DialogResult.Yes Then
            '        DApedidos.Pedidos_ActualizarEstado(Ds_pedidos.Tables(0).Rows(0).Item("Pedidos_ID").ToString, 3) 'estado=3 finalizado
            '        MessageBox.Show("El Pedido Fue Cerrado")
            '    ElseIf result = DialogResult.No Then
            '        DApedidos.Pedidos_ActualizarEstado(Ds_pedidos.Tables(0).Rows(0).Item("Pedidos_ID").ToString, 1) 'estado=1 Pendiente
            '        MessageBox.Show("El Pedido Se Guardó de Manera Pendiente")
            '    End If
            'Else
            '    DApedidos.Pedidos_ActualizarEstado(Ds_pedidos.Tables(0).Rows(0).Item("Pedidos_ID").ToString, 3)
            '    MessageBox.Show("El Pedido Fue Cerrado")
            'End If

            Me.Close()
        ElseIf result2 = DialogResult.No Then
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ComboBox_suc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_suc.GotFocus
        ComboBox_suc.SelectAll()
        ComboBox_suc.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub ComboBox_suc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_suc.LostFocus
        ComboBox_suc.BackColor = Color.White
    End Sub


#Region "Validacion de grilla - solo nros enteros en productos no fraccionables, y decimales en productos fraccionables"
    Private Sub calcular_subtotales()
        Dim precio As Decimal = 0
        'Dim cantidad As Integer = CInt(DataGridView1.CurrentRow.Cells("columna_cantidad").Value)
        Dim cantidad As Decimal = CDec(DataGridView1.CurrentRow.Cells("Cant_recibida").Value)
        precio = cantidad * DataGridView1.CurrentRow.Cells("Precio_U").Value
        DataGridView1.CurrentRow.Cells("Precio_U").Value = CDec(DataGridView1.CurrentRow.Cells("Precio_U").Value)
        DataGridView1.CurrentRow.Cells("Subtotal").Value = CDec(precio) 'CDec(Math.Round(precio, 2)).ToString("N2")
    End Sub


    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit

        If DataGridView1.CurrentCell.ColumnIndex = 5 Or DataGridView1.CurrentCell.ColumnIndex = 6 Then 'la columna 5 es Cantidad recibida y 6 es el precio unitario
            'Dim precio As Decimal = 0
            'Dim cantidad As Integer = CInt(DataGridView1.CurrentRow.Cells("columna_cantidad").Value)
            'precio = cantidad * CDec(DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value)
            'DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(precio) 'CDec(Math.Round(precio, 2)).ToString("N2")
            calcular_subtotales()
            calcular_total()

            'fila_mover = DataGridView1.CurrentRow.Index
            'calcular_totales()
            'aplicar_iva()
            'listo = "si, mover a precio"

        End If


    End Sub

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

    Private Sub Obtener_Productos()
        DS_PROD = DApedidos.Productos_x_Proveedor_Obtener(Prove_ID)
    End Sub
    Public tipo_prod
    Private Sub valido_fraccionable(ByVal cod_ingresado As String)
        'Encontrado = "no"
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

        If tipo_prod = "Fraccionable" Then


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
    End Sub

#End Region




    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        'este se evento se dispara cuando presiono enter, pero no en modo edicion para eso esta el cell end edit
        If DataGridView1.CurrentCell.ColumnIndex = 5 Then
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                SendKeys.Send("{TAB}")
            End If
        End If
        If DataGridView1.CurrentRow.Index <> DataGridView1.RowCount - 1 Then
            If DataGridView1.CurrentCell.ColumnIndex = 6 Then
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    SendKeys.Send("{TAB}")
                    SendKeys.Send("{TAB}")
                    SendKeys.Send("{TAB}")
                    SendKeys.Send("{TAB}")
                    SendKeys.Send("{TAB}")
                    SendKeys.Send("{TAB}")
                End If
            End If
        End If
        
    End Sub
End Class