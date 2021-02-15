Public Class Insumos_Predefinidos
    Dim DaEnfermeria As New Datos.Enfermeria
    Dim dasucursal As New Datos.Sucursal
    Dim tipo_producto


    Private Sub Insumos_Predefinidos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar_datos()
        Contar()

    End Sub
    Private Sub cargar_datos()
        Dim Ds As DataSet = DaEnfermeria.Insumos_Predefinidos_Obtener



        Dim e As Integer = 0
        If Ds.Tables(0).Rows.Count <> 0 Then
            While e < Ds.Tables(0).Rows.Count
                Dim fila As DataRow = Ds_enfermeria.Tables("Predefinidos").NewRow
                fila("Predef_id") = Ds.Tables(0).Rows(e).Item("Predef_id")
                fila("prod_id") = Ds.Tables(0).Rows(e).Item("prod_id")
                fila("prod_codinterno") = Ds.Tables(0).Rows(e).Item("prod_codinterno")
                fila("Predef_Cantidad") = Ds.Tables(0).Rows(e).Item("predef_cant")
                fila("Descripcion") = Ds.Tables(0).Rows(e).Item("Predef_Desc")
                fila("prod_unidadmedida") = Ds.Tables(0).Rows(e).Item("prod_unidadmedida")
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
                                                         datagridview_Predef.Rows(i).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value,
                                                         datagridview_Predef.Rows(i).Cells("prod_unidadmedida").Value)
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

  


    Private Sub valido_fraccionable()
        'Dim prod_id As Integer = datagridview_Predef.CurrentRow.Cells("prod_id").Value
        If datagridview_Predef.CurrentRow.Cells("prod_id").Value Is DBNull.Value Then

        Else

            Dim Ds_Suc As DataSet = dasucursal.Sucursal_obtener_producto(CInt(datagridview_Predef.CurrentRow.Cells("prod_id").Value), 3, 3)

            tipo_producto = Ds_Suc.Tables(1).Rows(0).Item("prod_tipo")

        End If


    End Sub
    
    Private Sub datagridview_Predef_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles datagridview_Predef.EditingControlShowing
        valido_fraccionable()


        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregar el controlador de eventos para el keypress
        AddHandler validar.KeyPress, AddressOf validar_Keypress

    End Sub
    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If tipo_producto = "Fraccionable" Then
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
        Else
            e.Handled = True 'bloqueo todo ingreso en primera instancia
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False 'aqui habilito si es numero
            End If
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False 'aqui habilito si es una operacion de control como "borrar"
            End If
        End If
    End Sub

End Class