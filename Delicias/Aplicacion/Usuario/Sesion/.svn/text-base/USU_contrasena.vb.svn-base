Public Class USU_contrasena

    Dim DA_usuario As New Datos.Usuario

    Dim USU_id As String
    Dim USU_contr As String

    Public Sub Usuario_Datos(ByVal Usuario As String, ByVal contrasena As String)
        USU_id = Usuario
        USU_contr = contrasena
        BOT_ingresar.Enabled = False
        LB_ERROR.Visible = False
        TX_USU_cont.PasswordChar = "*"
        TX_USU_cont.MaxLength = 15
        TX_USU_cont.TextAlign = HorizontalAlignment.Center
        TX_USU_cont_nue.PasswordChar = "*"
        TX_USU_cont_nue.MaxLength = 15
        TX_USU_cont_nue.TextAlign = HorizontalAlignment.Center
        TX_USU_cont_rnue.PasswordChar = "*"
        TX_USU_cont_rnue.MaxLength = 15
        TX_USU_cont_rnue.TextAlign = HorizontalAlignment.Center
    End Sub

    Public Sub Verificar()
        If TX_USU_cont.Text = USU_contr Then
            If TX_USU_cont_nue.Text <> Nothing And TX_USU_cont_nue.Text = TX_USU_cont_rnue.Text Then
                BOT_ingresar.Enabled = True
                IM_OK.Visible = True
                LB_ERROR.Visible = True
                LB_ERROR.Text = "Datos Correctos."
                LB_ERROR.ForeColor = Color.Green
            End If
        End If

    End Sub

    Private Sub BOT_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOT_ingresar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cambiar la Contraseña de Usuario?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            If TX_USU_cont_nue.Text <> "" And TX_USU_cont_rnue.Text <> "" And TX_USU_cont_nue.Text = TX_USU_cont_rnue.Text Then
                DA_usuario.Usuario_Cont(USU_id, TX_USU_cont_nue.Text)
                Me.Close()
                MessageBox.Show("La Contraseña a sido cambiada Correctamente.", "Sistema de Gestión.")
            Else
                MessageBox.Show("Error, modifique la contraseña nueva.", "Sistema de Gestión.")
                TX_USU_cont_nue.Focus()
                TX_USU_cont_nue.SelectAll()
            End If
        End If
    End Sub

    Private Sub TX_USU_cont_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TX_USU_cont.TextChanged
        Verificar()
    End Sub

    Private Sub TX_USU_cont_nue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TX_USU_cont_nue.TextChanged
        Verificar()
    End Sub

    Private Sub TX_USU_cont_rnue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TX_USU_cont_rnue.TextChanged
        Verificar()
    End Sub
End Class