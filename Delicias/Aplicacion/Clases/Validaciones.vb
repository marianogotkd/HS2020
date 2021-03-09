Public Class Validaciones
    Public Sub Restricciones_textbox(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal tipo As String, ByVal txtbox As TextBox)
        e.Handled = True 'bloqueo todo ingreso en primera instancia
        If tipo = "Entero" Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False 'aqui habilito si es numero
            End If
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False 'aqui habilito si es una operacion de control como "borrar"
            End If
        End If
        If tipo = "Decimal" Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False 'aqui habilito si es numero
            End If
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False 'aqui habilito si es una operacion de control como "borrar"
            End If
            If e.KeyChar.ToString() = "." Then
                e.KeyChar = ","
            End If
            'aqui valido que si el caracter ingresado es una ', que no se permita ingresar mas de una
            If e.KeyChar = "," And txtbox.TextLength <> 0 Then
                If e.KeyChar = "," And Not txtbox.Text.IndexOf(",") Then
                    If e.KeyChar = "," Then
                        e.Handled = True
                    End If
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    End If
                End If
            End If
        End If
        If tipo = "Celular" Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False 'aqui habilito si es numero
            End If
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False 'aqui habilito si es una operacion de control como "borrar"
            End If
            'aqui valido que si el caracter ingresado es una '(' que no se permita ingresar mas de una
            'If e.KeyChar = "(" And txtbox.TextLength <> 0 Then
            If e.KeyChar = "(" And Not txtbox.Text.IndexOf("(") Then
                If e.KeyChar = "(" Then
                    e.Handled = True
                End If
            Else
                If e.KeyChar = "(" Then
                    e.Handled = False
                End If
            End If
            If e.KeyChar = ")" And Not txtbox.Text.IndexOf(")") Then
                If e.KeyChar = ")" Then
                    e.Handled = True
                End If
            Else
                If e.KeyChar = ")" Then
                    e.Handled = False
                End If
            End If
        End If

        If tipo = "DNI" Then
            'aqui pongo el codigo para remplazar el punto por una coma
            If e.KeyChar.ToString() = "." Then
                e.KeyChar = ","
            End If
            'a continuacion el codigo para impedir el ingreso de dos comas o letras
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False

                If txtbox.Text <> "" Then
                    If txtbox.Text > 99999999 Then
                        e.Handled = True
                    End If
                End If
            Else
                If Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                        e.Handled = True
                    End If
                End If
                If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                    e.Handled = True
                End If
            End If
        End If


        If tipo = "DNI/CUIT" Then
            'aqui pongo el codigo para remplazar el punto por una coma
            If e.KeyChar.ToString() = "." Then
                e.KeyChar = ","
            End If
            'a continuacion el codigo para impedir el ingreso de dos comas o letras
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False

                If txtbox.Text <> "" Then
                    If txtbox.Text > 9999999999 Then
                        e.Handled = True
                    End If
                End If
            Else
                If Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                        e.Handled = True
                    End If
                End If
                If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                    e.Handled = True
                End If
            End If
        End If


    End Sub

    Public Sub Formatos_backcolor_textbox_y_combobox(ByVal tipo_evento As String, ByVal control As Control)
        Select Case tipo_evento
            Case "GotFocus"
                control.BackColor = Color.FromArgb(255, 255, 192)
            Case "LostFocus"
                control.BackColor = Color.White
        End Select

    End Sub

End Class
