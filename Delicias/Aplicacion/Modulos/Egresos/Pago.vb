Public Class Pago
    Dim DAEgresos As New Datos.Egresos
    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click

        If tx_parcial.Text = "" Then
            tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tx_parcial.Text = (Math.Round(CDec(tx_parcial.Text), 2).ToString("N2"))
        End If
        TextBox1.Text = CDec(tx_parcial.Text) - CDec(tx_total.Text)
        TextBox1.Text = (Math.Round(CDec(TextBox1.Text), 2).ToString("N2"))
        If TextBox1.Text < 0 Then
            TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If


        If Egresos_Alta.tx_NumComp.Text = "" Then
            Egresos_Alta.tx_NumComp.Text = 0
        End If
        If tx_parcial.Text = "" Then
            tx_parcial.Text = CDec(0)
        End If



        Dim result As DialogResult
        If Egresos_Alta.Combo_Detalle.Items.Count <> 0 Then
            If CDec(tx_parcial.Text) >= CDec(tx_total.Text) Then
                If Egresos_Alta.tx_Monto.Text <> "" Then
                    Egresos_Alta.ERROR_tx_Monto.Visible = False
                    result = MessageBox.Show("¿Desea Cargar un Nuevo Gasto?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                    If result = DialogResult.OK Then
                        'Guardo en el txbox el id del provedor o empleado
                        Dim Usuario_id As Integer = Inicio.USU_id
                        DAEgresos.Egresos_alta(Egresos_Alta.Combo_Gasto.SelectedValue, Egresos_Alta.tx_DetOtro.Text, Egresos_Alta.tx_Monto.Text, Egresos_Alta.DT_EG_fecha.Text, Egresos_Alta.DT_EG_fechaComp.Text, Egresos_Alta.tx_NumComp.Text, Egresos_Alta.Combo_Detalle.SelectedValue, Usuario_id)
                        MessageBox.Show("El Gasto fue dado de alta correctamente.", "Sistema de Gestion.")
                        Egresos_Alta.Limpiar()
                        Me.Close()
                    Else
                        MessageBox.Show("Debe Completar todos los campos", "Sistema de Gestion", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show("Complete la información", "Sistema de Gestion.")
                    Egresos_Alta.ERROR_tx_Monto.Visible = True
                    Egresos_Alta.tx_Monto.Focus()
                End If
            Else
                MessageBox.Show("Error! El monto ingresado es menor al total, por favor modifique", "Sistema de Gestion", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("Complete la información", "Sistema de Gestion.")
        End If
    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Me.Close()
    End Sub

    Private Sub tx_parcial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_parcial.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.tx_parcial.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras

            If tx_parcial.Text = "" Then
                tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))

            End If
            TextBox1.Text = CDec(tx_parcial.Text) - CDec(tx_total.Text)
            If TextBox1.Text < 0 Then
                TextBox1.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If

        End If



    End Sub

    Private Sub Pago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tx_parcial.MaxLength = 6
    End Sub
End Class