Public Class Lista_alta

    Private Sub Lista_alta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar()

        TX_LISTA_nom.TextAlign = HorizontalAlignment.Center
        TX_codigo.TextAlign = HorizontalAlignment.Center
        TX_codbarra.TextAlign = HorizontalAlignment.Center
        TX_descripcion.TextAlign = HorizontalAlignment.Center

    End Sub

    'Fecha de Vigencia
    Private Sub RB_LISTA_VIG_si_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_LISTA_VIG_si.CheckedChanged
        GP_Fecha.Enabled = True
    End Sub

    Private Sub RB_LISTA_VIG_no_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_LISTA_VIG_no.CheckedChanged
        GP_Fecha.Enabled = False
    End Sub

    'Dias
    Private Sub RB_LISTA_DIA_si_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_LISTA_DIA_si.CheckedChanged
        GP_dias.Enabled = True
    End Sub

    Private Sub RB_LISTA_DIA_no_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_LISTA_DIA_no.CheckedChanged
        GP_dias.Enabled = True
    End Sub

    'Producto
    Private Sub TX_codigo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_codigo.TextChanged
        If TX_codbarra.Text <> Nothing Then
            BO_codigo.Enabled = True
        Else
            BO_codigo.Enabled = False
        End If
    End Sub

    Private Sub TX_codbarra_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_codbarra.TextChanged
        If TX_descripcion.Text <> Nothing Then
            BO_codbarra.Enabled = True
        Else
            BO_codbarra.Enabled = False
        End If
    End Sub

    Private Sub TX_descripcion_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_descripcion.TextChanged
        If TX_descripcion.Text <> Nothing Then
            BO_descripcion.Enabled = True
        Else
            BO_descripcion.Enabled = False
        End If
    End Sub

    Private Sub BO_codigo_Click(sender As System.Object, e As System.EventArgs) Handles BO_codigo.Click

    End Sub

    Private Sub BO_codbarra_Click(sender As System.Object, e As System.EventArgs) Handles BO_codbarra.Click

    End Sub

    Private Sub BO_descripcion_Click(sender As System.Object, e As System.EventArgs) Handles BO_descripcion.Click

    End Sub

    Public Sub Limpiar()
        RB_LISTA_VIG_no.Checked = True
        RB_LISTA_DIA_no.Checked = True
    End Sub
End Class