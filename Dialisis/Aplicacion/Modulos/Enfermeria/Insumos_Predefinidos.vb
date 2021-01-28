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


End Class