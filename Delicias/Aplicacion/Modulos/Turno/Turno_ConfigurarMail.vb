Public Class Turno_ConfigurarMail

    Dim DAemail As New Datos.Email

    Dim ds_email_t As DataSet = DAemail.EmailTipo_Obtener()


    Private Sub Turno_ConfigurarMail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        COM_EMAIL_T.DataSource = ds_email_t.Tables(0)
        COM_EMAIL_T.DisplayMember = "EMAIL_T_nom"
        COM_EMAIL_T.ValueMember = "EMAIL_T_id"

        EmailOrigenTurno()
    End Sub

    Dim C As Integer = 0
    Public Sub EmailOrigenTurno()
        Dim ds_EmailTurno As DataSet = DAemail.Email_OrigenTurno_Obtener()
        With ds_EmailTurno.Tables(0).Rows
            If .Count > 0 Then
                C = 1
                COM_EMAIL_T.SelectedValue = ds_EmailTurno.Tables(0).Rows(0).Item("EMAIL_T_id").ToString
                TX_EMAIL_OR_nom.Text = ds_EmailTurno.Tables(0).Rows(0).Item("EMAIL_OR_nom").ToString
                TX_EMAIL_OR_email.Text = ds_EmailTurno.Tables(0).Rows(0).Item("EMAIL_OR_email").ToString
                TX_EMAIL_OR_contr.Text = ds_EmailTurno.Tables(0).Rows(0).Item("EMAIL_OR_contr").ToString
            Else
                C = 0
                TX_EMAIL_OR_nom.Text = Nothing
                TX_EMAIL_OR_email.Text = Nothing
                TX_EMAIL_OR_contr.Text = Nothing
            End If
        End With
        HABILITAR()
    End Sub

    Private Sub TX_EMAIL_OR_email_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_EMAIL_OR_email.TextChanged
        HABILITAR()
    End Sub

    Private Sub TX_EMAIL_OR_nom_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_EMAIL_OR_nom.TextChanged
        HABILITAR()
    End Sub

    Private Sub TX_EMAIL_OR_contr_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_EMAIL_OR_contr.TextChanged
        HABILITAR()
    End Sub

    Public Sub HABILITAR()
        If TX_EMAIL_OR_contr.Text <> Nothing And TX_EMAIL_OR_email.Text <> Nothing And TX_EMAIL_OR_nom.Text <> Nothing Then
            If C = 1 Then
                BO_guardar.Enabled = False
                BO_modificar.Enabled = True
                BO_eliminar.Enabled = True
            Else
                BO_guardar.Enabled = True
                BO_modificar.Enabled = False
                BO_eliminar.Enabled = False
            End If
        Else
            BO_guardar.Enabled = False
            BO_modificar.Enabled = False
            BO_eliminar.Enabled = False
        End If
    End Sub

    Private Sub BO_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BO_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea guardar el Email?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim EMAIL_T_id As String = ds_email_t.Tables(0).Rows(COM_EMAIL_T.SelectedIndex).Item("EMAIL_T_id").ToString

            DAemail.Email_OrigenTurno_Alta(EMAIL_T_id, TX_EMAIL_OR_email.Text, TX_EMAIL_OR_nom.Text, TX_EMAIL_OR_contr.Text)
            MessageBox.Show("El Email fue guardado correctamente.", "Sistema de Gestion.")
            EmailOrigenTurno()
        End If
    End Sub

    Private Sub BO_modificar_Click(sender As System.Object, e As System.EventArgs) Handles BO_modificar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar el Email?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim EMAIL_T_id As String = ds_email_t.Tables(0).Rows(COM_EMAIL_T.SelectedIndex).Item("EMAIL_T_id").ToString

            DAemail.Email_OrigenTurno_Modificar(EMAIL_T_id, TX_EMAIL_OR_email.Text, TX_EMAIL_OR_nom.Text, TX_EMAIL_OR_contr.Text)
            MessageBox.Show("El Email fue modificado correctamente.", "Sistema de Gestion.")
            EmailOrigenTurno()
        End If
    End Sub

    Private Sub BO_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BO_eliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea eliminar el Email?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            DAemail.Email_OrigenTurno_eliminar()
            MessageBox.Show("El Email fue eliminado correctamente.", "Sistema de Gestion.")
            EmailOrigenTurno()
        End If
    End Sub

    Private Sub BO_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles BO_limpiar.Click
        EmailOrigenTurno()
    End Sub


End Class