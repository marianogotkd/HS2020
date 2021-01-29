Imports System.IO
Imports System.Data.OleDb
Public Class Mesa_cliente_nuevo
    Dim DAcliente As New Datos.Cliente

    Private Sub Mesa_cliente_nuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        tx_ape_clie.Focus()

        tx_ape_clie.TextAlign = HorizontalAlignment.Center
        tx_nom_clie.TextAlign = HorizontalAlignment.Center
        tx_dni_clie.TextAlign = HorizontalAlignment.Center
        tx_dni_clie.MaxLength = 8
        tx_tel_clie.TextAlign = HorizontalAlignment.Center
        tx_mail_clie.TextAlign = HorizontalAlignment.Center
        'Habilitar()
    End Sub
    Dim Turno As Integer = 0

    Public Sub Turno_Cliente(ByVal B As Integer)
        Turno = B
    End Sub


    Private Sub Bo_guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta al Cliente?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            DAcliente.Cliente_Alta(tx_ape_clie.Text, tx_nom_clie.Text, tx_dni_clie.Text, DT_fecha.Value, tx_tel_clie.Text, tx_mail_clie.Text, tx_obser.Text, ComboBox1.Text)

            Select Case (Turno)
                Case (0)

                    Mesa_asignar.Txt_buscar_clie.Text = ""
                    Mesa_asignar.Obtener_Clientes()
                    Mesa_asignar.Seleccionar_cliente_nuevo(tx_ape_clie.Text, tx_nom_clie.Text)
                    limpiar_deshabilitar()
                    Me.Close()
                    MessageBox.Show("El Cliente fue dado de alta correctamente.", "Sistema de Gestion.")



                Case (1)

                    If tx_dni_clie.Text = Nothing Then
                        If tx_ape_clie.Text <> Nothing Then
                            TurnoFijo_alta.TX_ape.Text = tx_ape_clie.Text + " " + tx_nom_clie.Text
                        Else
                            TurnoFijo_alta.TX_ape.Text = tx_nom_clie.Text
                        End If
                        TurnoFijo_alta.Cliente_ObtenerNombre()
                    Else
                        TurnoFijo_alta.TX_doc.Text = tx_dni_clie.Text
                        TurnoFijo_alta.Cliente_ObtenerDNI()
                    End If
                    Me.Close()

                Case (2)

                    If tx_dni_clie.Text = Nothing Then
                        If tx_ape_clie.Text <> Nothing Then
                            Turno_alta.TX_ape.Text = tx_ape_clie.Text + " " + tx_nom_clie.Text
                        Else
                            Turno_alta.TX_ape.Text = tx_nom_clie.Text
                        End If

                        Turno_alta.Cliente_ObtenerNombre()
                    Else

                        Turno_alta.TX_doc.Text = tx_dni_clie.Text
                        Turno_alta.Cliente_ObtenerDNI()
                    End If
                    Me.Close()

            End Select

        End If
    End Sub

    Private Sub tx_dni_clie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_dni_clie.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

            If Me.tx_dni_clie.Text <> "" Then
                If Me.tx_dni_clie.Text > 99999999 Then
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
    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        limpiar_deshabilitar()
    End Sub
    Public Sub limpiar_deshabilitar()
        'datos personales///////////////////////////////////////////////////////////////////////////////////////////////////
        'botones de error
        ERROR_tx_ape_clie.Visible = False
        ERROR_dni.Visible = False
        ERROR_tx_dni_clie.Visible = False

        'datos personales
        tx_ape_clie.Text = Nothing
        tx_nom_clie.Text = Nothing
        tx_dni_clie.Text = Nothing
        tx_tel_clie.Text = Nothing
        tx_mail_clie.Text = Nothing
        DT_fecha.Value = Now

        Me.Show()
        tx_ape_clie.Focus()
        'Habilitar()
    End Sub
End Class