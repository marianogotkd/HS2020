Public Class CostoInd_alta
    Dim validaciones As New Validaciones


    

    Private Sub tb_sem_costo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        tb_costo.SelectAll()
    End Sub

    

    Private Sub tb_sem_costo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        tb_costo.SelectAll()
    End Sub

    Private Sub tb_sem_costo_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_costo.GotFocus
        tb_costo.SelectAll()
        tb_costo.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tb_sem_costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_costo.KeyPress
        validaciones.Restricciones_textbox(e, "Decimal", tb_costo)
        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER calcula
            If tb_costo.Text = "" Then
                tb_costo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                tb_costo.Text = (Math.Round(CDec(tb_costo.Text), 2).ToString("N2"))
            End If
        End If

    End Sub

    Private Sub tb_sem_costo_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_costo.LostFocus
        If tb_costo.Text = "" Then
            tb_costo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tb_costo.Text = (Math.Round(CDec(tb_costo.Text), 2).ToString("N2"))
        End If
        Calcular_Costo_Hora()
    End Sub

    Private Sub tb_sem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_dia.LostFocus
        If tb_costo.Text = "" Then
            tb_costo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tb_costo.Text = (Math.Round(CDec(tb_costo.Text), 2).ToString("N2"))
        End If

        Calcular_Costo_Hora()

    End Sub

    Private Sub Calcular_Costo_Hora()
        If tb_costo.Text <> "" And tb_costo.Text <> "0,00" Then
            tb_costo_HORA.Text = CDec(tb_costo.Text) / (tb_dia.Value * tb_horas.Value)
        End If


    End Sub
    Private Sub tb_horas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_horas.LostFocus
        If tb_costo.Text = "" Then
            tb_costo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tb_costo.Text = (Math.Round(CDec(tb_costo.Text), 2).ToString("N2"))
        End If

        Calcular_Costo_Hora()
    End Sub

    

    

    



    
    
   
    

    
    Private Sub tb_costo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_costo.TextChanged

    End Sub

End Class