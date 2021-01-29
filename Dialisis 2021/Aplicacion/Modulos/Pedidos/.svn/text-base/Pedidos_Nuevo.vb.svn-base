Public Class Pedidos_Nuevo

    Dim DAproveedores As New Datos.Proveedor
    Dim DAPedidos As New Datos.Pedidos

    Dim ds_proveedor As DataSet = DAproveedores.Proveedor_obtener

    Private Sub Pedidos_Nuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Combo_Prove.DataSource = ds_proveedor.Tables(0)
        Combo_Prove.DisplayMember = "Prov_nombre"
        Combo_Prove.ValueMember = "Prov_id"

        Tx_Codinterno.Text = Nothing

        Generar_cod_interno()
        ProveedorProducto_obtener()
        'Tx_nomprod.AutoCompleteCustomSource = Autocompletar()
        'Tx_nomprod.AutoCompleteMode = AutoCompleteMode.Suggest
        'Tx_nomprod.AutoCompleteSource = AutoCompleteSource.CustomSource

        Limpiar()
    End Sub

    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAPedidos.Pedidos_validar
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            tx_codigo.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item(0) + 1
        Else
            tx_codigo.Text = "1"
        End If
    End Sub

    ' PRODUCTO //////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub DG_Producto_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Producto.SelectionChanged
        If ((DG_Producto.CurrentRow Is Nothing) OrElse (DG_Producto.SelectedRows.Count <> 0)) And DG_Producto.Rows.Count > 0 Then
            TX_Cantidad.Enabled = True
            TX_Cantidad.Text = 1
            BO_mas.Enabled = True
        Else
            TX_Cantidad.Enabled = False
            TX_Cantidad.Text = Nothing
            BO_mas.Enabled = False
        End If
    End Sub

    Private Sub TX_Cantidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_Cantidad.TextChanged
        If TX_Cantidad.Text <> Nothing Then
            BO_mas.Enabled = True
        Else
            BO_mas.Enabled = False
        End If
    End Sub

    Private Sub Combo_Prove_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Combo_Prove.SelectedIndexChanged
        ProveedorProducto_obtener()
    End Sub




    Dim ds_Prove As DataSet

    'ProveedorProducto_obtener()
    Public Sub ProveedorProducto_obtener()
        If ds_proveedor.Tables(0).Rows.Count > 0 Then
            ds_Prove = DAPedidos.Pedidos_Obtener_Prod_Prove(ds_proveedor.Tables(0).Rows(Combo_Prove.SelectedIndex).Item("Prov_id").ToString)
        End If
    End Sub

    Public Sub ProveedorProducto_PuntodeReposicion()
        If DG_Producto.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DG_Producto.Rows
                Dim Stock As Integer = row.Cells("ProdstockDataGridViewTextBoxColumn").Value
                Dim PuntoRep As Integer = row.Cells("ProdptorepoDataGridViewTextBoxColumn").Value
                If Stock <= PuntoRep Then
                    row.DefaultCellStyle.BackColor = Color.Firebrick
                    row.DefaultCellStyle.ForeColor = Color.White
                End If
            Next
            DG_Producto.ClearSelection()
        End If
    End Sub

    'Producto Buscar
    Private Sub Bo_buscar_nombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_buscar_nombre.Click
        
        Producto_BuscarNombre()
    End Sub

    Private Sub BO_Buscar_codinterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Buscar_codinterno.Click
        
        Producto_BuscarCodigo()
    End Sub

    Private Sub Tx_nomprod_TextChanged(sender As System.Object, e As System.EventArgs) Handles Tx_nomprod.TextChanged

    End Sub

    Private Sub Tx_Codinterno_TextChanged(sender As System.Object, e As System.EventArgs) Handles Tx_Codinterno.TextChanged
        If Tx_Codinterno.Text = Nothing Then
            BO_Buscar_codinterno.Enabled = False
        Else
            BO_Buscar_codinterno.Enabled = True
        End If
    End Sub

    Private Sub Tx_nomprod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_nomprod.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Producto_BuscarNombre()
        End If
    End Sub

    Private Sub Tx_Codinterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_Codinterno.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Producto_BuscarCodigo()
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub Producto_BuscarNombre()
        IM_ERROR.Visible = False
        LB_ERROR.Visible = False
        If ds_proveedor.Tables(0).Rows.Count <> 0 Then

            DG_Producto.DataSource = Nothing
            If Tx_nomprod.Text <> "" Then
                'Filtrar_datatable(Me.Tx_nomprod.Text)

                If ds_Prove.Tables.Count <> 0 Then
                    ''uso ds_CLIE que trae los productos buscados en sql
                    Dim table_filtrada As New DataTable
                    table_filtrada.Columns.Add("prod_descripcion")
                    table_filtrada.Columns.Add("prod_stock")
                    table_filtrada.Columns.Add("prod_precio_vta")
                    table_filtrada.Columns.Add("prod_descrilarga")
                    table_filtrada.Columns.Add("prod_ptorepo")
                    table_filtrada.Columns.Add("prod_id")
                    table_filtrada.Columns.Add("prod_codinterno")
                    table_filtrada.Columns.Add("Prov_Prod_Com_id")

                    Dim parametro As String = Me.Tx_nomprod.Text
                    DG_Producto.DataSource = Nothing

                    Dim table As DataTable = ds_Prove.Tables(0)

                    Dim apellido As String = parametro
                    Dim a = 0
                    While a < table.Rows.Count
                        Dim fila As String = table.Rows(a).Item("prod_descripcion")
                        fila = fila.ToLower()
                        parametro = parametro.ToLower()
                        Dim primercaracter As Integer = fila.IndexOf(parametro)
                        If primercaracter <> -1 Then
                            table_filtrada.ImportRow(table.Rows(a))
                        End If

                        'Dim fila2 As String = table.Rows(a).Item("CLI_dni")
                        'fila2 = fila2.ToLower()
                        'parametro = parametro.ToLower()
                        'Dim primercaracter2 As Integer = fila2.IndexOf(parametro)
                        'If primercaracter2 <> -1 Then
                        '    table_filtrada.ImportRow(table.Rows(a))
                        'End If



                        'If apellido = table.Rows(a).Item("CLI_ape") Then
                        '    table_filtrada.ImportRow(table.Rows(a))
                        'End If
                        a = a + 1
                    End While

                    If table_filtrada.Rows.Count <> 0 Then
                        DG_Producto.DataSource = table_filtrada
                        ProveedorProducto_PuntodeReposicion()
                    Else
                        DG_Producto.DataSource = ds_Prove.Tables(0)
                        ProveedorProducto_PuntodeReposicion()
                    End If
                End If
            Else
                DG_Producto.DataSource = ds_Prove.Tables(0)
                ProveedorProducto_PuntodeReposicion()
            End If

        Else
            DG_Producto.DataSource = Nothing
            IM_ERROR.Visible = True
            LB_ERROR.Visible = True
            MessageBox.Show("No hay productos registrados para el proveedor", "Sistema de Gestion.", MessageBoxButtons.OK)
        End If


        'GOMEZZZZZZZZZZZZZZZZZZZ--------HAY GOMEZZ.---------------
        'If ds_Prove.Tables.Count <> 0 Then
        '    ''uso ds_PROD que trae los productos buscados en sql
        '    Dim table_filtrada As New DataTable
        '    table_filtrada.Columns.Add("prod_descripcion")
        '    table_filtrada.Columns.Add("prod_stock")
        '    table_filtrada.Columns.Add("prod_precio_vta")
        '    table_filtrada.Columns.Add("prod_descrilarga")
        '    table_filtrada.Columns.Add("prod_ptorepo")
        '    table_filtrada.Columns.Add("prod_id")
        '    table_filtrada.Columns.Add("prod_codinterno")
        '    table_filtrada.Columns.Add("Prov_Prod_Com_id")
        '    DG_Producto.DataSource = Nothing
        '    Dim i = 0
        '    While i < ds_Prove.Tables(0).Rows.Count
        '        If Tx_nomprod.Text = ds_Prove.Tables(0).Rows(i).Item("prod_descripcion") Then
        '            table_filtrada.ImportRow(ds_Prove.Tables(0).Rows(i))
        '        End If
        '        i = i + 1
        '    End While

        '    If table_filtrada.Rows.Count > 0 Then
        '        DG_Producto.DataSource = table_filtrada
        '        ProveedorProducto_PuntodeReposicion()
        '        IM_ERROR.Visible = False
        '        LB_ERROR.Visible = False
        '    Else
        '        DG_Producto.DataSource = Nothing
        '        IM_ERROR.Visible = True
        '        LB_ERROR.Visible = True
        '    End If

        'End If
    End Sub

    Public Sub Producto_BuscarCodigo()
        IM_ERROR.Visible = False
        LB_ERROR.Visible = False
        If Tx_Codinterno.Text <> "" Then
            If ds_proveedor.Tables(0).Rows.Count <> 0 Then


                If ds_Prove.Tables(0).Rows.Count <> 0 Then
                    ''uso ds_PROD que trae los productos buscados en sql
                    Dim table_filtrada As New DataTable
                    table_filtrada.Columns.Add("prod_descripcion")
                    table_filtrada.Columns.Add("prod_stock")
                    table_filtrada.Columns.Add("prod_precio_vta")
                    table_filtrada.Columns.Add("prod_descrilarga")
                    table_filtrada.Columns.Add("prod_ptorepo")
                    table_filtrada.Columns.Add("prod_id")
                    table_filtrada.Columns.Add("prod_codinterno")
                    table_filtrada.Columns.Add("Prov_Prod_Com_id")
                    DG_Producto.DataSource = Nothing
                    Dim i = 0
                    While i < ds_Prove.Tables(0).Rows.Count
                        If Tx_Codinterno.Text = ds_Prove.Tables(0).Rows(i).Item("prod_codinterno") Then
                            table_filtrada.ImportRow(ds_Prove.Tables(0).Rows(i))
                        End If
                        i = i + 1
                    End While

                    If table_filtrada.Rows.Count > 0 Then
                        DG_Producto.DataSource = table_filtrada
                        ProveedorProducto_PuntodeReposicion()
                        IM_ERROR.Visible = False
                        LB_ERROR.Visible = False
                    Else
                        DG_Producto.DataSource = Nothing
                        IM_ERROR.Visible = True
                        LB_ERROR.Visible = True
                    End If

                End If
            Else
                DG_Producto.DataSource = Nothing
                IM_ERROR.Visible = True
                LB_ERROR.Visible = True
                MessageBox.Show("No hay productos registrados para el proveedor", "Sistema de Gestion.", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    'AGREGAR PRODUCTO ////////////////////////////////////////////////////////////////////////////////////////////

    Dim selecporv As String = "no"

    Private Sub BO_Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_mas.Click

        If DG_Producto.CurrentRow IsNot Nothing Then
            'primero verifico que el producto q ingreso no este ya en la grilla
            Dim item = 0
            Dim presente = "no"
            Dim fila_editar = 0
            While item < DG_Pedido.Rows.Count
                If DG_Pedido.Rows(item).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value Then
                    presente = "si"
                    fila_editar = item
                End If
                item = item + 1
            End While
            'ahora veo de agregar o editar
            If presente = "no" Then
                'agrego una nueva fila

                Dim newCustomersRow As DataRow = DsPedidos.Tables("Pedidos").NewRow()
                newCustomersRow("prod_codinterno") = DG_Producto.SelectedRows(0).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value.ToString
                newCustomersRow("prod_descripcion") = DG_Producto.SelectedRows(0).Cells("ProddescripcionDataGridViewTextBoxColumn").Value.ToString
                newCustomersRow("Cantidad") = TX_Cantidad.Text
                newCustomersRow("prod_descrilarga") = DG_Producto.SelectedRows(0).Cells("ProddescrilargaDataGridViewTextBoxColumn").Value.ToString
                newCustomersRow("Prov_Prod_Com_id") = DG_Producto.SelectedRows(0).Cells("ProvProdComidDataGridViewTextBoxColumn").Value.ToString
                newCustomersRow("prod_precio_vta") = DG_Producto.SelectedRows(0).Cells("ProdpreciovtaDataGridViewTextBoxColumn").Value.ToString
                newCustomersRow("Total") = TX_Cantidad.Text * DG_Producto.SelectedRows(0).Cells("ProdpreciovtaDataGridViewTextBoxColumn").Value.ToString

                DsPedidos.Tables("Pedidos").Rows.Add(newCustomersRow)

                DG_Pedido.DataSource = DsPedidos.Tables("Pedidos")
                ' Lista_alta.DataG_lista.DataSource = DsPedidos.Tables("Pedidos")

            Else
                'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                Dim result As DialogResult
                result = MessageBox.Show("Ya esta agregado ¿Desea Quitarlo?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    QuitarFila()
                End If
            End If
        Else
            MsgBox("Seleccione producto", MsgBoxStyle.Information)
        End If

        DG_Pedido.ClearSelection()
        Pedido_CalcularTotal()
        Proveedor_Habilitar()
    End Sub

    Dim ds_PROD As New DataSet

    Public Sub Proveedor_Habilitar()
        If DG_Pedido.Rows.Count > 0 Then
            GP_Proveedor.Enabled = False
        Else
            GP_Proveedor.Enabled = True
        End If
    End Sub

    Public Sub Pedido_CalcularTotal()
        Dim Pedido_Total As Decimal = 0
        Dim B As Integer = 0

        While B < DG_Pedido.Rows.Count
            Pedido_Total = Pedido_Total + DG_Pedido.Rows(B).Cells("Total").Value.ToString
            B = B + 1
        End While
        TX_TOTAL.Text = Pedido_Total
    End Sub

    'PEDIDO /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub DG_Pedido_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Pedido.SelectionChanged
        If ((DG_Pedido.CurrentRow Is Nothing) OrElse (DG_Pedido.SelectedRows.Count <> 0)) And DG_Pedido.Rows.Count > 0 Then
            BO_menos.Enabled = True
            Bo_guardar.Enabled = True
        Else
            BO_menos.Enabled = False
            Bo_guardar.Enabled = False
        End If

        If DG_Pedido.Rows.Count > 0 Then
            Bo_guardar.Enabled = True
        Else
            Bo_guardar.Enabled = False
        End If
    End Sub

    Public Sub QuitarFila()
        If DG_Pedido.Rows.Count <> 0 Then
            If DG_Pedido.CurrentRow.Cells(1).Value <> "" Then
                'primero guardo el nro de item q contiene
                Dim item2 As Decimal = DG_Pedido.CurrentRow.Index
                DG_Pedido.Rows.RemoveAt(item2)


                'este codigo si va
                'Call Cargar_Totales(añosdelproyecto)
                'modificado = 1
            End If
        End If

        DG_Pedido.Refresh()
        DG_Pedido.ClearSelection()
    End Sub

    Private Sub Btn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_menos.Click

        QuitarFila()
        If DG_Pedido.RowCount = 0 Then
            Bo_guardar.Enabled = False

        End If
        Proveedor_Habilitar()
        Pedido_CalcularTotal()
    End Sub

    'Private Sub Tx_nomprod_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_nomprod.KeyPress

    '    Autocompletar()

    'End Sub


    'Public Function Autocompletar() As AutoCompleteStringCollection


    '    ''uso ds_PROD que trae los productos buscados en sql
    '    Dim table_filtrada As New DataTable
    '    Dim coleccion As New AutoCompleteStringCollection()
    '    'Recorrer y cargar los items para el Autocompletado
    '    For Each row As DataRow In table_filtrada.Rows
    '        coleccion.Add(Convert.ToString(row("prod_descripcion")))
    '    Next


    '    Return coleccion
    'End Function

    'GUARDAR //////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        Dim proveid As Integer = Combo_Prove.SelectedValue
        Dim ds_pedidos As DataSet = DAPedidos.Pedidos_Alta(tx_codigo.Text, DateTimePicker1.Value, proveid, TX_TOTAL.Text, 1, Inicio.suc_id, Inicio.USU_id)

        Dim Pedidos_id As String = CType(ds_pedidos.Tables(0).Rows(0).Item("Pedidos_ID"), String)

        'Pedidos_dettal alta
        For Each row As DataGridViewRow In DG_Pedido.Rows
            Dim pedidos As String = row.Cells(2).Value.ToString
            'uso la misma rutina q uso en las promociones.
            'DAPedidos.Pedidos_Detalle_Alta(Pedidos_id, row.Cells("ProvProdComidDataGridViewTextBoxColumn1").Value, row.Cells("CantidadDataGridViewTextBoxColumn").Value, row.Cells("Total").Value)

        Next

        Limpiar()
        Generar_cod_interno()

        MessageBox.Show("El Pedido Fue Guardado Correctamente", "Sistema de Gestion.", MessageBoxButtons.OK)

    End Sub

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        Limpiar()
    End Sub

    Public Sub Limpiar()
        DsPedidos.Tables("Pedidos").Rows.Clear()

        DG_Producto.DataSource = Nothing

        Tx_nomprod.Text = Nothing

        TX_Cantidad.Text = Nothing
        TX_Cantidad.Enabled = False

        BO_mas.Enabled = False

        Tx_Codinterno.Text = Nothing
        BO_Buscar_codinterno.Enabled = False

        DG_Pedido.DataSource = Nothing

        BO_menos.Enabled = False

        TX_TOTAL.Text = Nothing

        Bo_guardar.Enabled = False
        Proveedor_Habilitar()
    End Sub

End Class