Public Class Fondos

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

   

    Private Sub Fondos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_500.Focus()
    End Sub

    Private Sub tb_500_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_500.Click
        tb_500.SelectAll()
        tb_500.Focus()
    End Sub


    Private Sub tb_500_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_500.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_200.Focus()
            tb_200.SelectAll()
        End If


    End Sub


    Private Sub MaskedTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_500.LostFocus
        Calculo()
      
    End Sub

    Private Sub tb_200_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_200.Click
        tb_200.SelectAll()
    End Sub

    Private Sub tb_200_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_200.KeyPress
    If e.KeyChar = ChrW(Keys.Enter) Then
            tb_100.Focus()
            tb_100.SelectAll()
        End If


    End Sub


    Private Sub tb_200_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_200.LostFocus
       Calculo()

    End Sub

    Private Sub tb_100_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_100.Click
        tb_100.SelectAll()
    End Sub

    Private Sub tb_100_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_100.KeyPress
       If e.KeyChar = ChrW(Keys.Enter) Then
            tb_50.Focus()
            tb_50.SelectAll()
        End If


    End Sub


    Private Sub tb_100_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_100.LostFocus
         Calculo()

    End Sub

    Private Sub tb_50_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_50.Click
        tb_50.SelectAll()
    End Sub

    Private Sub tb_50_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_50.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_20.Focus()
            tb_20.SelectAll()
        End If

    End Sub

    Private Sub tb_50_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_50.LostFocus
         Calculo()

    End Sub

    Private Sub tb_20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_20.Click
        tb_20.SelectAll()
    End Sub

   

    Private Sub tb_20_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_20.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_10.Focus()
            tb_10.SelectAll()
        End If

    End Sub

    Private Sub tb_20_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_20.LostFocus
        Calculo()

    End Sub

    Private Sub tb_10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_10.Click
        tb_10.SelectAll()
    End Sub

    Private Sub tb_10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_10.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_5.Focus()
            tb_5.SelectAll()
        End If

    End Sub

    Private Sub tb_10_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_10.LostFocus
         Calculo()

    End Sub

    Private Sub tb_5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_5.Click
        tb_5.SelectAll()
    End Sub

    Private Sub tb_5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_5.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_2.Focus()
            tb_2.SelectAll()
        End If

    End Sub

    Private Sub tb_5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_5.LostFocus
        Calculo()
    End Sub

    Private Sub tb_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_2.Click
        tb_2.SelectAll()
    End Sub

    Private Sub tb_2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_1.Focus()
            tb_1.SelectAll()
        End If

    End Sub

    Private Sub tb_2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_2.LostFocus
       Calculo()

    End Sub

    Private Sub tb_1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_1.Click
        tb_1.SelectAll()
    End Sub

    Private Sub tb_1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_050.Focus()
            tb_050.SelectAll()
        End If

    End Sub

    Private Sub tb_1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_1.LostFocus
       Calculo()

    End Sub

    Private Sub tb_050_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_050.Click
        tb_050.SelectAll()
    End Sub

    Private Sub tb_050_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_050.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_025.Focus()
            tb_025.SelectAll()
        End If

    End Sub

    Private Sub tb_050_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_050.LostFocus
        Calculo()

    End Sub

    Private Sub tb_025_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_025.Click
        tb_025.SelectAll()
    End Sub

    Private Sub tb_025_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_025.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_010.Focus()
            tb_010.SelectAll()
        End If

    End Sub

    Private Sub tb_025_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_025.LostFocus

        Calculo()

    End Sub

    Private Sub tb_010_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_010.Click
        tb_010.SelectAll()
    End Sub

    Private Sub tb_010_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_010.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_500.Focus()
            tb_500.SelectAll()
        End If

    End Sub

    Private Sub tb_010_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_010.LostFocus


        Calculo()

    End Sub

    Private Sub Calculo()
        If tb_500.Text = "" Then
            tb_500.Text = 0
        End If

        If tb_200.Text = "" Then
            tb_200.Text = 0
        End If

        If tb_100.Text = "" Then
            tb_100.Text = 0
        End If

        If tb_50.Text = "" Then
            tb_50.Text = 0
        End If

        If tb_20.Text = "" Then
            tb_20.Text = 0
        End If
        If tb_10.Text = "" Then
            tb_10.Text = 0
        End If
        If tb_5.Text = "" Then
            tb_5.Text = 0
        End If
        If tb_2.Text = "" Then
            tb_2.Text = 0
        End If
        If tb_1.Text = "" Then
            tb_1.Text = 0
        End If
        If tb_050.Text = "" Then
            tb_050.Text = 0
        End If
        If tb_025.Text = "" Then
            tb_025.Text = 0
        End If
        If tb_010.Text = "" Then
            tb_010.Text = 0
        End If

        tb_Total.Text = 0

        tb_Total.Text = tb_Total.Text + (tb_500.Text * 500) + (tb_200.Text * 200) + (tb_100.Text * 100) + (tb_50.Text * 50) + (tb_20.Text * 20) + (tb_10.Text * 10) + (tb_5.Text * 5) + (tb_2.Text * 2) + (tb_1.Text * 1) + (tb_050.Text * 0.5) + (tb_025.Text * 0.25) + (tb_010.Text * 0.1)

    End Sub




    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()

    End Sub

    
End Class