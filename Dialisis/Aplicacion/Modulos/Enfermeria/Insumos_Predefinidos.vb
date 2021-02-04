Public Class Insumos_Predefinidos
    Dim DaEnfermeria As New Datos.Enfermeria


    Private Sub Insumos_Predefinidos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar_datos()
        Contar()

    End Sub
    Private Sub cargar_datos()
        Dim Ds As DataSet = DaEnfermeria.Insumos_Predefinidos_Obtener


        'choco 17-12-2020 ahora cargo en el gridview las sucursales que tiene asignado el cliente
        Dim e As Integer = 0
        If Ds.Tables(0).Rows.Count <> 0 Then
            While e < Ds.Tables(0).Rows.Count
                Dim fila As DataRow = Ds_enfermeria.Tables("Predefinidos").NewRow
                fila("Predef_id") = Ds.Tables(0).Rows(e).Item("Predef_id")
                fila("prod_codinterno") = Ds.Tables(0).Rows(e).Item("prod_codinterno")
                fila("Predef_Cantidad") = Ds.Tables(0).Rows(e).Item("predef_cant")
                fila("Descripcion") = Ds.Tables(0).Rows(e).Item("Predef_Desc")
                Ds_enfermeria.Tables("Predefinidos").Rows.Add(fila)
                e = e + 1
            End While
        End If

    End Sub
    Private Sub Insumos_Predefinidos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then 'F1
            GM_Baja_Producto.form_procedencia = "Predefinido"
            GM_Baja_Producto.Show()
            'Busqueda_Productos.tx_Buscar.Focus()
        End If
    End Sub


    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        GM_Baja_Producto.sucursal_id = 3
        GM_Baja_Producto.form_procedencia = "Predefinido"
        GM_Baja_Producto.Show()
    End Sub

    Private Sub btn_ausente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ausente.Click
        If datagridview_Predef.RowCount <> 0 Then
            datagridview_Predef.Rows.Remove(datagridview_Predef.CurrentRow)
        End If
        Contar()


    End Sub

    Public Sub Contar()
        lbl_cant.Text = datagridview_Predef.RowCount
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim var = ""
        If datagridview_Predef.RowCount <> 0 Then

            Dim a As Integer = 0
            While a < datagridview_Predef.RowCount
                If datagridview_Predef.Rows(a).Cells("PredefCantidadDataGridViewTextBoxColumn").Value <> 0 Then
                    var = "OK"
                Else
                    var = "Vacio"
                End If
                a = a + 1
            End While

            If var = "OK" Then

                DaEnfermeria.Insumos_Predefinidos_Eliminar()

                Dim i As Integer = 0
                While i < datagridview_Predef.RowCount
                    DaEnfermeria.Insumos_Predefinidos_alta(datagridview_Predef.Rows(i).Cells("PredefCantidadDataGridViewTextBoxColumn").Value,
                                                          datagridview_Predef.Rows(i).Cells("DescripcionDataGridViewTextBoxColumn").Value,
                                                         datagridview_Predef.Rows(i).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value)
                    i = i + 1
                End While
                MessageBox.Show("Los Datos se Guardaron Correctamente", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("La cantidad de los productos no puede estar Vacia", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

            MessageBox.Show("Debe Seleccionar al menos un producto", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub


#Region "Validacion de grilla - solo numeros en celda"

    'Private Sub valido_fraccionable(ByVal cod_ingresado As String)
    '    'Encontrado = "no"
    '    Dim i As Integer = 0
    '    While i < VentaGestion_DS_PROD.Tables(1).Rows.Count
    '        Dim cod_interno As String = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
    '        If cod_ingresado = cod_interno Then
    '            '' si es fraccionable o no el producto solamente por este if pasa''
    '            tipo_prod = VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_tipo").ToString
    '            '''''''''''''''''''''''''''''MARIANO 17/6/19'''''''''''''''''''''''
    '            'Dim index As Integer = DataGridView1.CurrentRow.Index
    '            'DataGridView1.CurrentRow.Cells("item_num").Value = CInt(DataGridView1.CurrentRow.Index + 1)
    '            'DataGridView1.CurrentRow.Cells("prod_id").Value = DS_PROD.Tables(0).Rows(i).Item("prod_id").ToString
    '            'DataGridView1.CurrentRow.Cells("prod_codinterno").Value = DS_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
    '            'DataGridView1.CurrentRow.Cells("prod_descripcion").Value = DS_PROD.Tables(0).Rows(i).Item("prod_descripcion").ToString
    '            'DataGridView1.CurrentRow.Cells("Cantidad").Value = CInt(1)
    '            'Encontrado = "si"
    '        End If
    '        i = i + 1
    '    End While
    '    'If Encontrado = "no" Then
    '    '    'buscar por codigo de barras
    '    '    DataGridView1.CurrentRow.Cells("item_num").Value = ""
    '    '    DataGridView1.CurrentRow.Cells("prod_id").Value = ""
    '    '    DataGridView1.CurrentRow.Cells("prod_codinterno").Value = ""
    '    '    DataGridView1.CurrentRow.Cells("prod_descripcion").Value = ""
    '    '    DataGridView1.CurrentRow.Cells("Cantidad").Value = ""
    '    '    MessageBox.Show("No existe el producto para ese proveedor", "Sistema de Gestión")
    '    'End If
    '    'If DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value <> "" Then
    '    '    DataGridView1.Rows.Add()
    '    'End If
    'End Sub
    'Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


    '    Dim columna As Integer = datagridview_Predef.CurrentCell.ColumnIndex

    '    Dim variasdasd = datagridview_Predef.CurrentRow.Cells("columna_codinterno").Value

    '    If CStr(datagridview_Predef.CurrentRow.Cells("columna_codinterno").Value) = "" And (columna = 5 Or columna = 6) Then 'la columna 5 es Cantidad, la columna 6 es descuento
    '        'If IsDBNull(DataGridView1.CurrentRow.Cells("columna_codinterno").Value) And columna = 5 Then
    '        e.Handled = True
    '    Else
    '        If datagridview_Predef.CurrentRow.Cells("columna_prod_id").Value <> "" And columna = 2 Then
    '            e.Handled = True
    '            If Char.IsControl(e.KeyChar) Then
    '                datagridview_Predef.CurrentRow.Cells("columna_codinterno").Value = celda_codinterno
    '            End If


    '        Else
    '            e.Handled = True 'bloqueo todo ingreso en primera instancia
    '            If Char.IsNumber(e.KeyChar) Then
    '                e.Handled = False 'aqui habilito si es numero
    '            End If
    '            If Char.IsControl(e.KeyChar) Then
    '                e.Handled = False 'aqui habilito si es una operacion de control como "borrar"
    '            End If
    '            'If e.KeyChar <> "" Then 'si es distinto de vacio valido 
    '            '    If Me.DataGridView1.CurrentCell.ColumnIndex <> 1 Then 'si no es la columna 1, solo numeros y comas
    '            '        e.Handled = True 'bloqueo todo ingreso en primera instancia
    '            '        If Char.IsNumber(e.KeyChar) Then
    '            '            e.Handled = False 'aqui habilito si es numero
    '            '        End If
    '            '        If Char.IsControl(e.KeyChar) Then
    '            '            e.Handled = False 'aqui habilito si es una operacion de control como "borrar"
    '            '        End If

    '            '        'obtener indice de la columna
    '            '        Dim columna As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
    '            '        'comprobar si la celda en edicion corresponde a la columnas deseadas
    '            '        'If columna = 1 Or columna = 2 Then
    '            '        'obtener caracter
    '            If columna = 5 Then
    '                If tipo_prod = "Fraccionable" Then
    '                    Dim caracter As Char = e.KeyChar
    '                    '        'referencia a la celda
    '                    Dim txt As TextBox = CType(sender, TextBox)
    '                    'aqui pongo el codigo para remplazar el punto por una coma
    '                    If txt.ToString() = "." Then
    '                        txt.Text = ","
    '                    End If
    '                    If caracter.ToString() = "." Then
    '                        caracter = ","
    '                    End If
    '                    'comprobar si el caracter es un número o el retroceso, si el caracter es un separador decimal y que no contiene ya el separador
    '                    If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then
    '                        e.KeyChar = caracter
    '                        e.Handled = False
    '                    Else
    '                        e.Handled = True
    '                    End If
    '                End If
    '            End If
    '            If columna = 6 Then 'la columna 6 es descuento, que acepta decimales
    '                Dim caracter As Char = e.KeyChar
    '                '        'referencia a la celda
    '                Dim txt As TextBox = CType(sender, TextBox)
    '                'aqui pongo el codigo para remplazar el punto por una coma
    '                If txt.ToString() = "." Then
    '                    txt.Text = ","
    '                End If
    '                If caracter.ToString() = "." Then
    '                    caracter = ","
    '                End If
    '                'comprobar si el caracter es un número o el retroceso, si el caracter es un separador decimal y que no contiene ya el separador
    '                If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then
    '                    e.KeyChar = caracter
    '                    e.Handled = False
    '                Else
    '                    e.Handled = True
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

#End Region



    Private Sub datagridview_Predef_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles datagridview_Predef.EditingControlShowing
        Dim validar As TextBox = CType(e.Control, TextBox)
    End Sub
End Class