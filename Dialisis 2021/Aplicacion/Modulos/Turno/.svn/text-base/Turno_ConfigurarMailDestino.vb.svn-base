Public Class Turno_ConfigurarMailDestino

    Dim DAemail As New Datos.Email

    Private Sub Turno_ConfigurarMailDestino_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        EmailDestinoTurno_obtener()
        Habilitar()

    End Sub

    Dim ds_EmailDestino As DataSet
    Public Sub EmailDestinoTurno_obtener()
        ds_EmailDestino = DAemail.Email_DestinoTurno_Obtener()
        DG_EmailDestino.DataSource = ds_EmailDestino.Tables(0)
    End Sub

    Dim EMAIL_DE_id As Integer
    Private Sub DG_EmailDestino_SelectionChanged(sender As Object, e As EventArgs) Handles DG_EmailDestino.SelectionChanged
        Habilitar()

    End Sub


    Private Sub BO_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BO_eliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea eliminar el Email?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            DAemail.Email_DestinoTurno_eliminar(EMAIL_DE_id)
            MessageBox.Show("El Email fue eliminado correctamente.", "Sistema de Gestion.")
            EmailDestinoTurno_obtener()
        End If
    End Sub

    Private Sub BO_modificar_Click(sender As System.Object, e As System.EventArgs) Handles BO_modificar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar el Email?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            DAemail.Email_DestinoTurno_Modificar(EMAIL_DE_id, TX_EMAIL_DE_email_modf.Text, TX_EMAIL_DE_nom_modf.Text)
            MessageBox.Show("El Email fue modificado correctamente.", "Sistema de Gestion.")
            EmailDestinoTurno_obtener()
        End If
    End Sub

    Public Sub Limpiar()
        TX_EMAIL_DE_email.Text = Nothing
        TX_EMAIL_DE_nom.Text = Nothing
    End Sub

    Public Sub Habilitar()
        If TX_EMAIL_DE_email.Text <> Nothing And TX_EMAIL_DE_nom.Text <> Nothing Then
            BO_guardar.Enabled = True
        Else
            BO_guardar.Enabled = False
        End If


        If ((DG_EmailDestino.CurrentRow Is Nothing) OrElse (DG_EmailDestino.SelectedRows.Count <> 0)) And DG_EmailDestino.Rows.Count > 0 Then
            GP_EmailDestino_modf.Enabled = True
            BO_eliminar.Enabled = True
            BO_modificar.Enabled = True
            EMAIL_DE_id = DG_EmailDestino.SelectedRows(0).Cells("DataGridViewTextBoxColumn1").Value.ToString
            TX_EMAIL_DE_email_modf.Text = DG_EmailDestino.SelectedRows(0).Cells("DataGridViewTextBoxColumn2").Value.ToString
            TX_EMAIL_DE_nom_modf.Text = DG_EmailDestino.SelectedRows(0).Cells("DataGridViewTextBoxColumn3").Value.ToString
        Else
            GP_EmailDestino_modf.Enabled = False
            BO_eliminar.Enabled = False
            BO_modificar.Enabled = False
            TX_EMAIL_DE_email_modf.Text = Nothing
            TX_EMAIL_DE_nom_modf.Text = Nothing
        End If
    End Sub


    Private Sub TX_EMAIL_DE_email_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_EMAIL_DE_email.TextChanged
        Habilitar()
    End Sub

    Private Sub TX_EMAIL_DE_nom_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_EMAIL_DE_nom.TextChanged
        Habilitar()
    End Sub

    Private Sub BO_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles BO_limpiar.Click
        Limpiar()
    End Sub

    Private Sub BO_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BO_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea guardar el Email?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            DAemail.Email_DestinoTurno_Alta(TX_EMAIL_DE_email.Text, TX_EMAIL_DE_nom.Text)
            MessageBox.Show("El Email fue guardado correctamente.", "Sistema de Gestion.")
            Limpiar()
            EmailDestinoTurno_obtener()
        End If
    End Sub
End Class