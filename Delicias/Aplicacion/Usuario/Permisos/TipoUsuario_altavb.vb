Public Class TipoUsuario_altavb
    Dim dausuario As New Datos.Usuario

    Private Sub TipoUsuario_altavb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        If tx_desc.Text <> "" Then
            dausuario.UsuarioTipo_Alta(tx_desc.Text)
            MessageBox.Show("Tipo de Usuario registrado correctamente", "Sistema de Gestion")
            Permisos.Close()
            Permisos.Show()
            TiposUsuarios_Gestion.Close()
            TiposUsuarios_Gestion.Show()
            Me.Close()
        Else
            MessageBox.Show("Debe Ingresar la Descripción", "Sistema de Gestion")
        End If
    End Sub
End Class