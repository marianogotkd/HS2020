Public Class Insumos_Predefinidos

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
End Class