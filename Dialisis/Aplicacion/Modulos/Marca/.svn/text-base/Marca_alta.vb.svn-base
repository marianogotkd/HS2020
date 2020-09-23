Public Class Marca_alta
    Dim DAmarca As New Datos.Marca
    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta la Marca?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            DAmarca.Marca_alta(tx_nom_marca.Text)
            'Producto_alta.Cargarcombo_marca()
            Producto_alta_New.Cargarcombo_marca()
            MessageBox.Show("La Marca fue dada de alta correctamente.", "Sistema de Gestion.")
            Me.Close()
        End If
    End Sub
End Class