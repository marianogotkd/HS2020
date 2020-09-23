Public Class Lista_prod_ADD

    Dim DAlista As New Datos.Lista
    Dim DAproveedores As New Datos.Proveedor



    'PRODUCTO BUSCAR /////////////////////////
    Dim ds_PROD As New DataSet 'trae dos tables, la 0 es prod y 1 combos
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbox_busqueda.SelectedIndexChanged

        TX_busqueda.Focus()


        'Código(Interno)
        'Código(Barras)
        'Nombre()
    End Sub
    Private Sub BO_codigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_busqueda.Click
        busqueda()
    End Sub

    Private Sub busqueda()
        LimpiarProducto()
        If Cbox_busqueda.SelectedIndex = "2" Then 'el index 2, es nombre
            Obtener_Producto_Nombre()
            If RB_filtro_SI.Checked = True Then
                Filtrar_datatable()
            End If
        End If
    End Sub

    Private Sub Lista_prod_ADD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cbox_busqueda.SelectedIndex = 2 'selecciono por defecto busqueda "NOMBRE"

        Cargarcombo_proveedor()

    End Sub
    Private Sub RB_filtro_SI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_filtro_SI.CheckedChanged
        If RB_filtro_SI.Checked = True Then
            Cbox_proveedor.Enabled = True
            Filtrar_datatable()
        End If

    End Sub
    Private Sub RB_filtro_NO_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_filtro_NO.CheckedChanged
        If RB_filtro_NO.Checked = True Then
            Cbox_proveedor.Enabled = False

            If ds_PROD.Tables.Count <> 0 Then
                DG_Producto.DataSource = ds_PROD.Tables(1)
                Call Formato_combos()
                DG_Producto.Refresh()
            End If

        End If

    End Sub
    Private Sub Cbox_proveedor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbox_proveedor.TextChanged
        Filtrar_datatable()
    End Sub
    Private Sub TX_LISTA_PROD_cant_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_LISTA_PROD_cant.LostFocus
        calcular_total_prod_seleccionado()
    End Sub
    Private Sub TX_LISTA_PROD_cant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TX_LISTA_PROD_cant.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                calcular_total_prod_seleccionado()
        End Select
    End Sub
    Private Sub TX_LISTA_PROD_cant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_LISTA_PROD_cant.KeyPress
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
    End Sub
    Private Sub DG_Producto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Producto.CellClick
        'si la celda tiene datos, los pasamos a los textbox de la derecha para editar
        If DG_Producto.CurrentRow IsNot Nothing Then

            Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value.ToString
            Label_preciolista.Text = (CDec(DG_Producto.CurrentRow.Cells(4).Value)).ToString("N2") ' lo paso a decima para obtener el formato 00,00
            Label_preciolista.Text = (CDec(DG_Producto.CurrentRow.Cells(4).Value)).ToString("N2") ' lo paso a decima para obtener el formato 00,00
            TX_LISTA_PROD_cant.Text = "1"
            Label_preciototal.Text = CDec(DG_Producto.CurrentRow.Cells(4).Value).ToString("N2")
            calcular_total_prod_seleccionado()
        End If
    End Sub
    Private Sub DG_Producto_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Producto.SelectionChanged
        'si la celda tiene datos, los pasamos a los textbox de la derecha para editar
        If DG_Producto.CurrentRow IsNot Nothing Then
            Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value.ToString
            Label_preciolista.Text = (CDec(DG_Producto.CurrentRow.Cells(4).Value)).ToString("N2") ' lo paso a decima para obtener el formato 00,00
            Label_preciolista.Text = (CDec(DG_Producto.CurrentRow.Cells(4).Value)).ToString("N2") ' lo paso a decima para obtener el formato 00,00
            TX_LISTA_PROD_cant.Text = "1"
            Label_preciototal.Text = CDec(DG_Producto.CurrentRow.Cells(4).Value).ToString("N2")
            calcular_total_prod_seleccionado()
        End If
    End Sub

#Region "METODOS"
    Private Sub calcular_total_prod_seleccionado()
        'cuando modifico la cantidad del producto seleccionado, realizo el calculo para obtener total
        If TX_LISTA_PROD_cant.Text <> "" Then
            If TX_LISTA_PROD_cant.Text = "0" Then
                TX_LISTA_PROD_cant.Text = "1"
            End If
            Dim total As Decimal = 0
            total = TX_LISTA_PROD_cant.Text * Label_preciolista.Text
            Label_preciototal.Text = CDec(Math.Round(total, 2)).ToString("N2")
            'TX_LISTA_PROD_total.Text = Format(TX_LISTA_PROD_total.Text, "##,##0,00")
        Else
            If TX_LISTA_PROD_cant.Text = "" Then
                TX_LISTA_PROD_cant.Text = "1"
            End If
            If Label_preciolista.Text = "" Then
                Label_preciolista.Text = "00,00"
            End If

            Dim total As Decimal = 0
            total = TX_LISTA_PROD_cant.Text * Label_preciolista.Text
            Label_preciototal.Text = CDec(Math.Round(total, 2)).ToString("N2")

        End If
    End Sub

    Private Sub Filtrar_datatable()
        If ds_PROD.Tables.Count <> 0 Then
            ''uso ds_PROD que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("prod_id")
            table_filtrada.Columns.Add("prod_codinterno")
            table_filtrada.Columns.Add("prod_descripcion")
            table_filtrada.Columns.Add("prod_descrilarga")
            table_filtrada.Columns.Add("prod_precio_vta")
            table_filtrada.Columns.Add("prod_nrocat")
            table_filtrada.Columns.Add("prod_idcat")
            table_filtrada.Columns.Add("Categoria")
            table_filtrada.Columns.Add("Marca_nom")
            table_filtrada.Columns.Add("Prov_id")
            table_filtrada.Columns.Add("Prov_nombre")


            DG_Producto.DataSource = Nothing

            Dim table As DataTable = ds_PROD.Tables(1)

            ' Presuming the DataTable has a column named Date.
            Dim expression As String
            Dim prov_id = Cbox_proveedor.SelectedValue.ToString
            Dim columna As String = "Prov_id"
            expression = columna + "=" + prov_id
            Dim foundRows() As DataRow

            ' Use the Select method to find all rows matching the filter.
            foundRows = table.Select(expression)

            Dim i As Integer
            ' Print column 0 of each returned row.

            For i = 0 To foundRows.GetUpperBound(0)
                prov_id = foundRows(i).Item("Prov_id")

                'MsgBox(prov_id)
                'Dim newCustomersRow As DataRow = ds_PROD.Tables(1).NewRow()
                'newCustomersRow("prod_id") = foundRows(i).Item("prod_id").ToString
                'newCustomersRow("prod_codinterno") = foundRows(i).Item("prod_codinterno").ToString
                'newCustomersRow("prod_descripcion") = foundRows(i).Item("prod_descripcion").ToString
                'newCustomersRow("prod_descrilarga") = foundRows(i).Item("prod_descrilarga").ToString
                'newCustomersRow("prod_precio_vta") = foundRows(i).Item("prod_precio_vta").ToString
                'newCustomersRow("prod_nrocat") = foundRows(i).Item("prod_nrocat").ToString
                'newCustomersRow("prod_idcat") = foundRows(i).Item("prod_idcat").ToString
                ''newCustomersRow("Categoria") = foundRows(i).Item("Categoria").ToString
                'newCustomersRow("Marca_nom") = foundRows(i).Item("Marca_nom").ToString
                'newCustomersRow("Prov_id") = foundRows(i).Item("Prov_id").ToString
                'newCustomersRow("Prov_nombre") = foundRows(i).Item("Prov_nombre").ToString

                table_filtrada.ImportRow(foundRows(i))
                'table_filtrada.Rows.Add(foundRows(i))
                'table_filtrada.Rows.Add(newCustomersRow)
            Next i
            DG_Producto.DataSource = table_filtrada
        End If
    End Sub

    Public Sub LimpiarProducto()
        'TX_LISTA_PROD_cant.Text = Nothing
        'TX_LISTA_PROD_precio.Text = Nothing
        'TX_LISTA_PROD_total.Text = 0
        'BO_Cargar.Enabled = False
        TX_LISTA_PROD_cant.Text = "1"
        'TX_LISTA_PROD_precio.Text = "00,00"
        Label_preciototal.Text = "00,00"
        'TX_LISTA_PROD_calculo.Text = "00,00"
        'Label_result.Text = "00,00"
        Label_preciolista.Text = "00,00"
    End Sub

    Public form_procedencia As String = ""
    Public Sub Obtener_Producto_Nombre()
        ds_PROD = DAlista.Lista_obtenerProductoDescripcion(TX_busqueda.Text)
        Dim combo_si As String = "no"
        'VEO si estoy creando combos van solo los prod q estan en la tabla 1 de sql
        If form_procedencia = "Lista_alta" Then
            If Lista_alta.RB_combo_prod.Checked = True Then
                combo_si = "si"
            End If
        End If
        If form_procedencia = "Lista_producto_gestion" Then
            If Lista_producto_gestion.RB_combo_prod.Checked = True Then
                combo_si = "si"
            End If
        End If

        If combo_si = "si" Then 'si estoy creando un combo solo muestro los productos para agregar
            With ds_PROD.Tables(1).Rows
                If .Count > 0 Then
                    GP_Producto.Enabled = True
                    DG_Producto.DataSource = ds_PROD.Tables(1)
                    IM_ERROR.Visible = False
                    LB_ERROR.Visible = False
                    'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                    Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                    Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                    'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                    TX_LISTA_PROD_cant.Text = "1"
                    Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                Else
                    GP_Producto.Enabled = False
                    DG_Producto.DataSource = Nothing
                    IM_ERROR.Visible = True
                    LB_ERROR.Visible = True
                End If
            End With
            If ds_PROD.Tables(1).Rows.Count <> 0 Then
                'aqui hago el case para recuperar la categoria con nivel correspondiente
                '5   , 6
                Dim a As Integer = 0
                While a < ds_PROD.Tables(1).Rows.Count
                    Dim nro_cat As Integer = ds_PROD.Tables(1).Rows(a).Item("prod_nrocat")
                    Dim cat_id As Integer = ds_PROD.Tables(1).Rows(a).Item("prod_idcat")
                    Dim ds_categoria As DataSet = DAlista.Lista_obtenerCategorias(cat_id)
                    Select Case nro_cat
                        Case 1
                            If ds_categoria.Tables(0).Rows.Count <> 0 Then
                                Dim Nombre_cat As String = ds_categoria.Tables(0).Rows(0).Item("cat1_nom")
                                DG_Producto.Rows(a).Cells(7).Value = Nombre_cat
                            End If
                        Case 2
                            If ds_categoria.Tables(1).Rows.Count <> 0 Then
                                Dim Nombre_cat As String = ds_categoria.Tables(1).Rows(0).Item("cat1_nom") + " / " + ds_categoria.Tables(1).Rows(0).Item("cat2_nom")
                                DG_Producto.Rows(a).Cells(7).Value = Nombre_cat
                            End If
                        Case 3
                            If ds_categoria.Tables(2).Rows.Count <> 0 Then
                                Dim Nombre_cat As String = ds_categoria.Tables(2).Rows(0).Item("cat1_nom") + " / " + ds_categoria.Tables(2).Rows(0).Item("cat2_nom") + " / " + ds_categoria.Tables(2).Rows(0).Item("cat3_nom")
                                DG_Producto.Rows(a).Cells(7).Value = Nombre_cat
                            End If
                    End Select
                    a = a + 1
                End While
            End If
        Else
            'junto los prod y los combos..para mostrarlos en el mismo grid
            With ds_PROD.Tables(2).Rows
                If .Count > 0 Then
                    GP_Producto.Enabled = True
                    ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                    DG_Producto.DataSource = ds_PROD.Tables(1)

                    Call Formato_combos()

                    IM_ERROR.Visible = False
                    LB_ERROR.Visible = False
                    'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                    Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                    Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                    'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                    TX_LISTA_PROD_cant.Text = "1"
                    Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                Else

                    If ds_PROD.Tables(1).Rows.Count > 0 Then
                        GP_Producto.Enabled = True
                        'ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                        DG_Producto.DataSource = ds_PROD.Tables(1)

                        'Call Formato_combos()

                        IM_ERROR.Visible = False
                        LB_ERROR.Visible = False
                        'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                        Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                        Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                        'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                        TX_LISTA_PROD_cant.Text = "1"
                        Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value

                    Else
                        GP_Producto.Enabled = False
                        DG_Producto.DataSource = Nothing
                        IM_ERROR.Visible = True
                        LB_ERROR.Visible = True
                    End If

                End If
            End With
        End If
    End Sub

    Public Sub Formato_combos()
        Dim font As New Font(DG_Producto.DefaultCellStyle.Font.FontFamily, 8.25, FontStyle.Bold)
        Dim i = 0
        While i < DG_Producto.Rows.Count
            'pregunto si no tiene detalle, es por que es un combo :P
            If DG_Producto.Rows(i).Cells("ProddescrilargaDataGridViewTextBoxColumn").Value = " " Then
                DG_Producto.Rows(i).DefaultCellStyle.Font = font
            End If
            i = i + 1
        End While
        'dtgResumen.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.Black;
    End Sub

    Public Sub Cargarcombo_proveedor()
        Dim ds_proveedor As DataSet = DAproveedores.Proveedor_obtener
        'Cargar Proveedor
        Cbox_proveedor.DataSource = ds_proveedor.Tables(0)
        Cbox_proveedor.DisplayMember = "Prov_nombre"
        Cbox_proveedor.ValueMember = "Prov_id"
    End Sub

#End Region


    Private Sub BO_Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cargar.Click
        If DG_Producto.CurrentRow IsNot Nothing Then
            Select Case form_procedencia
                Case "Lista_alta"
                    'primero verifico que el producto q ingreso no este ya en la grilla
                    Dim item = 0
                    Dim presente = "no"
                    Dim fila_editar = 0
                    While item < Lista_alta.DataG_lista.Rows.Count
                        If Lista_alta.DataG_lista.Rows(item).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value Then
                            presente = "si"
                            fila_editar = item
                        End If
                        item = item + 1
                    End While
                    'ahora veo de agregar o editar
                    If presente = "no" Then
                        'agrego una nueva fila
                        Dim newCustomersRow As DataRow = Lista_alta.Lista_ds.Tables("ListaProducto").NewRow()
                        newCustomersRow("PROD_id") = DG_Producto.CurrentRow.Cells(0).Value.ToString
                        newCustomersRow("PROD_descripcion") = DG_Producto.CurrentRow.Cells(2).Value.ToString
                        newCustomersRow("Lista_Prod_cantidad") = TX_LISTA_PROD_cant.Text
                        newCustomersRow("Lista_Prod_precio") = Label_preciolista.Text
                        newCustomersRow("Lista_Prod_subtotal") = CDec(Label_preciototal.Text).ToString("N2")
                        newCustomersRow("prod_codinterno") = DG_Producto.CurrentRow.Cells(1).Value.ToString
                        Lista_alta.Lista_ds.Tables("ListaProducto").Rows.Add(newCustomersRow)

                        Lista_alta.DataG_lista.DataSource = Lista_alta.Lista_ds.Tables("ListaProducto")

                        'aqui indicamos si el producto agregado es combo o no
                        If DG_Producto.CurrentRow.Cells(3).Value = " " Then
                            Lista_alta.DataG_lista.Rows(Lista_alta.DataG_lista.Rows.Count - 1).Cells(6).Value = "combo"
                        Else
                            Lista_alta.DataG_lista.Rows(Lista_alta.DataG_lista.Rows.Count - 1).Cells(6).Value = "producto"
                        End If
                        MessageBox.Show("Producto agregado correctamente.", "Sistema de Gestion.")
                    Else
                        'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                        Dim result As DialogResult
                        result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                        If result = DialogResult.OK Then

                            Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                            Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
                            Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
                            Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
                            Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
                            Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
                            MessageBox.Show("Producto agregado correctamente.", "Sistema de Gestion.")
                        End If
                    End If

                    Lista_alta.calcular_totales()

                Case "Lista_producto_gestion"
                    'primero verifico que el producto q ingreso no este ya en la grilla
                    Dim item = 0
                    Dim presente = "no"
                    Dim fila_editar = 0
                    While item < Lista_producto_gestion.DataG_lista.Rows.Count
                        If Lista_producto_gestion.DataG_lista.Rows(item).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value Then
                            presente = "si"
                            fila_editar = item
                        End If
                        item = item + 1
                    End While
                    'ahora veo de agregar o editar
                    If presente = "no" Then
                        'agrego una nueva fila

                        Dim newCustomersRow As DataRow = Lista_producto_gestion.Lista_ds.Tables("ListProdModif").NewRow()
                        newCustomersRow("PROD_id") = DG_Producto.CurrentRow.Cells(0).Value.ToString
                        newCustomersRow("prod_descripcion") = DG_Producto.CurrentRow.Cells(2).Value.ToString
                        newCustomersRow("Lista_Prod_cantidad") = TX_LISTA_PROD_cant.Text
                        newCustomersRow("Lista_Prod_precio") = Label_preciolista.Text
                        newCustomersRow("Lista_Prod_subtotal") = CDec(Label_preciototal.Text).ToString("N2")
                        newCustomersRow("prod_codinterno") = DG_Producto.CurrentRow.Cells(1).Value.ToString
                        'aqui indicamos si el producto agregado es combo o no
                        If DG_Producto.CurrentRow.Cells(3).Value = " " Then
                            newCustomersRow("tipo_producto") = "combo"
                        Else
                            newCustomersRow("tipo_producto") = "producto"
                        End If

                        Lista_producto_gestion.Lista_ds.Tables("ListProdModif").Rows.Add(newCustomersRow)

                        Lista_producto_gestion.DataG_lista.DataSource = Lista_producto_gestion.Lista_ds.Tables("ListProdModif")
                        MessageBox.Show("Producto agregado correctamente.", "Sistema de Gestion.")
                    Else
                        'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                        Dim result As DialogResult
                        result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                        If result = DialogResult.OK Then

                            Lista_producto_gestion.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                            Lista_producto_gestion.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
                            Lista_producto_gestion.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
                            Lista_producto_gestion.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
                            Lista_producto_gestion.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
                            Lista_producto_gestion.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)

                            MessageBox.Show("Producto agregado correctamente.", "Sistema de Gestion.")

                        End If
                    End If
                    Lista_producto_gestion.calcular_totales_tabla()
            End Select
        Else
            MsgBox("Seleccione producto", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TX_busqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_busqueda.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            busqueda()
        End If
    End Sub
End Class