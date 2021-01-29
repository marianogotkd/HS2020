Public Class Pedidos_Nuevo
    Dim DAproveedores As New Datos.Proveedor
    Dim DAPedidos As New Datos.Pedidos

    Dim ds_proveedor As DataSet = DAproveedores.Proveedor_obtener

    Private Sub Pedidos_Nuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Limpiar()

        Call Generar_cod_interno()

        Tx_nomprod.AutoCompleteCustomSource = Autocompletar()
        Tx_nomprod.AutoCompleteMode = AutoCompleteMode.Suggest
        Tx_nomprod.AutoCompleteSource = AutoCompleteSource.CustomSource

        Combo_Prove.DataSource = ds_proveedor.Tables(0)
        Combo_Prove.DisplayMember = "Prov_nombre"
        Combo_Prove.ValueMember = "Prov_id"


        'ProveedorProducto_obtener()
        '
    End Sub

    Private Sub COM_PROVE_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Combo_Prove.SelectedIndexChanged
        ProveedorProducto_obtener()
    End Sub

    Dim ds_Prove As DataSet

    'ProveedorProducto_obtener()
    Public Sub ProveedorProducto_obtener()
        If ds_proveedor.Tables(0).Rows.Count > 0 Then
            ds_Prove = DAPedidos.Pedidos_Obtener_Prod_Prove(ds_proveedor.Tables(0).Rows(Combo_Prove.SelectedIndex).Item("Prov_id").ToString)
            DG_Producto.DataSource = ds_Prove.Tables(0)

            For Each row As DataGridViewRow In DG_Producto.Rows
                If row.Cells("ProdstockDataGridViewTextBoxColumn").Value.ToString <= row.Cells("ProdptorepoDataGridViewTextBoxColumn").Value.ToString Then
                    row.DefaultCellStyle.BackColor = Color.Firebrick
                    row.DefaultCellStyle.ForeColor = Color.White
                End If
            Next

            DG_Producto.ClearSelection()
            Combo_Prove.Enabled = False
            DG_Producto.Refresh()
        End If
    End Sub

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Dim selecporv As String = "no"


    Private Sub BO_Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cargar.Click

            If DG_Producto.CurrentRow IsNot Nothing Then
                'primero verifico que el producto q ingreso no este ya en la grilla
                Dim item = 0
                Dim presente = "no"
                Dim fila_editar = 0
                While item < DataGridView1.Rows.Count
                    If DataGridView1.Rows(item).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value Then
                        presente = "si"
                        fila_editar = item
                    End If
                    item = item + 1
                End While
                'ahora veo de agregar o editar
                If presente = "no" Then
                    'agrego una nueva fila

                    Dim newCustomersRow As DataRow = DsPedidos.Tables("Pedidos").NewRow()
                    newCustomersRow("prod_codinterno") = DG_Producto.CurrentRow.Cells(1).Value.ToString
                    newCustomersRow("prod_descripcion") = DG_Producto.CurrentRow.Cells(2).Value.ToString
                    newCustomersRow("Cantidad") = TX_LISTA_PROD_cant.Text
                newCustomersRow("prod_descrilarga") = DG_Producto.CurrentRow.Cells(3).Value.ToString
                newCustomersRow("Prov_Prod_Com_id") = DG_Producto.CurrentRow.Cells(4).Value.ToString

                DsPedidos.Tables("Pedidos").Rows.Add(newCustomersRow)

                DataGridView1.DataSource = DsPedidos.Tables("Pedidos")
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

        Bo_guardar.Enabled = True

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


    Dim ds_PROD As New DataSet

    Private Sub BO_Buscar_codinterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Buscar_codinterno.Click

        If ds_Prove.Tables.Count <> 0 Then
            ''uso ds_PROD que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("prod_descripcion")
            table_filtrada.Columns.Add("prod_stock")
            table_filtrada.Columns.Add("prod_precio_vta")
            table_filtrada.Columns.Add("prod_descrilarga")
            table_filtrada.Columns.Add("prod_ptorepo")
            table_filtrada.Columns.Add("prod_id")
            table_filtrada.Columns.Add("prod_codinterno")
            DG_Producto.DataSource = Nothing
            Dim i = 0
            While i < ds_Prove.Tables(0).Rows.Count
                If Tx_Codinterno.Text = ds_Prove.Tables(0).Rows(i).Item("prod_codinterno") Then
                    table_filtrada.ImportRow(ds_Prove.Tables(0).Rows(i))
                End If
                i = i + 1
            End While
            DG_Producto.DataSource = table_filtrada

        End If



    End Sub





    Private Sub Bo_buscar_nombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_buscar_nombre.Click

        If ds_Prove.Tables.Count <> 0 Then
            ''uso ds_PROD que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("prod_descripcion")
            table_filtrada.Columns.Add("prod_stock")
            table_filtrada.Columns.Add("prod_precio_vta")
            table_filtrada.Columns.Add("prod_descrilarga")
            table_filtrada.Columns.Add("prod_ptorepo")
            table_filtrada.Columns.Add("prod_id")
            table_filtrada.Columns.Add("prod_codinterno")
            DG_Producto.DataSource = Nothing
            Dim i = 0
            While i < ds_Prove.Tables(0).Rows.Count
                If Tx_Codinterno.Text = ds_Prove.Tables(0).Rows(i).Item("prod_descripcion") Then
                    table_filtrada.ImportRow(ds_Prove.Tables(0).Rows(i))
                End If
                i = i + 1
            End While
            DG_Producto.DataSource = table_filtrada

        End If



    End Sub

    Private Sub Tx_nomprod_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_nomprod.KeyPress

        Autocompletar()

    End Sub


    Public Function Autocompletar() As AutoCompleteStringCollection


        ''uso ds_PROD que trae los productos buscados en sql
        Dim table_filtrada As New DataTable
        Dim coleccion As New AutoCompleteStringCollection()
        'Recorrer y cargar los items para el Autocompletado
        For Each row As DataRow In table_filtrada.Rows
            coleccion.Add(Convert.ToString(row("prod_descripcion")))
        Next


        Return coleccion
    End Function


    Public Sub QuitarFila()
        If DataGridView1.Rows.Count <> 0 Then
            If DataGridView1.CurrentRow.Cells(1).Value <> "" Then
                'primero guardo el nro de item q contiene
                Dim item2 As Decimal = DataGridView1.CurrentRow.Index
                DataGridView1.Rows.RemoveAt(item2)


                'este codigo si va
                'Call Cargar_Totales(añosdelproyecto)
                'modificado = 1
            End If
        End If

        DataGridView1.Refresh()


    End Sub

    Private Sub Btn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Quitar.Click

        QuitarFila()
        If DataGridView1.RowCount = 0 Then
            Bo_guardar.Enabled = False

        End If

    End Sub


    Private Sub btn_CambioProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CambioProv.Click

        Dim result As DialogResult
        result = MessageBox.Show("Esta a Punto de Cambiar de Proveedor ¿Desea Continuar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Combo_Prove.Enabled = True
            DsPedidos.Tables("Pedidos").Rows.Clear()


        End If
        BO_Cargar.Enabled = False
    End Sub


    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        Dim proveid As Integer = Combo_Prove.SelectedValue
        Dim ds_pedidos As DataSet = DAPedidos.Pedidos_Alta(tx_codigo.Text, DateTimePicker1.Value, proveid, 1, 1)





        Dim Pedidos_id As String = CType(ds_pedidos.Tables(0).Rows(0).Item("Pedidos_ID"), String)

        'Pedidos_dettal alta
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim pedidos As String = row.Cells(2).Value.ToString
            'uso la misma rutina q uso en las promociones.
            DAPedidos.Pedidos_Detalle_Alta(Pedidos_id, row.Cells(4).Value, row.Cells(3).Value, 1)

        Next


        Call Generar_cod_interno()

        MessageBox.Show("El Pedido Fue Guardado Correctamente", "Sistema de Gestion.", MessageBoxButtons.OK)

    End Sub

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        Limpiar()
    End Sub

    Public Sub Limpiar()
        DsPedidos.Tables("Pedidos").Rows.Clear()
        DG_Producto.DataSource = Nothing
        DataGridView1.DataSource = Nothing
        Bo_guardar.Enabled = False
    End Sub

End Class