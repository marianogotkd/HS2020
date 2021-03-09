Public Class Egresos_Ingresos_alta
    Dim DAcaja As New Datos.Caja
    Dim validaciones As New Validaciones
    Private Sub TextBox_monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_monto.KeyPress
        validaciones.Restricciones_textbox(e, "Decimal", TextBox_monto)
    End Sub

    Private Sub Egresos_Ingresos_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label_fecha.Text = "Fecha: " + Today
        TextBox_monto.Text = "0"
    End Sub

    Private Sub TextBox_monto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_monto.LostFocus
        If TextBox_monto.Text = "" Then
            TextBox_monto.Text = 0
        End If
    End Sub
    Private Sub TextBox_monto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_monto.GotFocus
        TextBox_monto.SelectAll()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea registrarlo en caja?", "Sistema de Gestión", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then


            If TextBox1.Text <> "" And CDec(TextBox_monto.Text) <> CDec(0) Then
                Dim descripcion As String = TextBox1.Text
                '2 es ingreso y 3 es egreso
                If RadioButton_ingreso.Checked = True Then
                    'OK
                    DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(TextBox_monto.Text), CDec(0), 2, CDec(0), CDec(TextBox_monto.Text), Now, Inicio.terminal_id, US_administrador.TurnoUsuario_id) '2 es ingreso
                Else
                    'OK
                    DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(0), CDec(TextBox_monto.Text), 3, CDec(0), CDec(0), Now, Inicio.terminal_id, US_administrador.TurnoUsuario_id) '3 es egreso
                End If
                'actualizo en la grilla de el form egresos_ingresos
                Egresos_Ingresos.cargar_detalle()
                MessageBox.Show("Se registro correctamente.", "Sistema de Gestión.")
                Me.Close()
            Else
                MessageBox.Show("Error, ingrese Concepto y Monto", "Sistema de Gestión.")
                TextBox1.SelectAll()
            End If
        End If
    End Sub
End Class