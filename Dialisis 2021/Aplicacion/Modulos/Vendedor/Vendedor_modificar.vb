Public Class Vendedor_modificar
    Dim daVendedor As New Datos.Vendedor



    Private Sub Vendedor_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar()
    End Sub

    Dim DS_vendedores As DataSet
    Public Sub Cargar()
        DS_vendedores = daVendedor.Vendedor_obtenertodo 'no tiene proc almacenado
        DG_usuario.DataSource = DS_vendedores.Tables(0)
    End Sub

    Private Sub BO_usuario_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_usuario_nuevo.Click
        Me.Close()
        Vendedor_alta.Show()
    End Sub

    Private Sub BO_usuario_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_usuario_modificar.Click
        If Me.DG_usuario.Rows.Count <> 0 Then
            Dim usuarioselec As String = DG_usuario.SelectedCells(0).Value
            If usuarioselec <> "" Then
                Vendedor_alta.Close()
                Vendedor_alta.vendedor_id = usuarioselec
                Vendedor_alta.form_procedencia = "modificar"
                Vendedor_alta.Text = "Actualizar Vendedor"
                Vendedor_alta.Show()
                Me.Close()
            Else
                MessageBox.Show("Seleccione un vendedor del listado", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Seleccione un vendedor del listado", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class