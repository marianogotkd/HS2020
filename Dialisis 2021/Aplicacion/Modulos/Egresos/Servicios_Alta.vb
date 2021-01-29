Public Class Servicios_Alta

    Dim _enabledCerrar As Boolean = False

    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")> _
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property

    Dim DAServicios As New Datos.Egresos
    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim result As DialogResult
        If tx_descrip.Text <> "" Then


            result = MessageBox.Show("¿Desea dar de alta un Servicio Nuevo?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then

                DAServicios.Servicios_alta(tx_descrip.Text, Combo_tpoMonto.Text, tx_Monto.Text)
                MessageBox.Show("El Servicio fue dado de alta correctamente.", "Sistema de Gestion.")
                Me.Close()
                Egresos_Alta.Cargo_servicios()
                Egresos_Alta.Combo_Gasto.Enabled = True
            Else
                MessageBox.Show("Debe Completar todos los campos", "Sistema de Gestion", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("Debe Completar todos los campos", "Sistema de Gestion", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub Combo_tpoMonto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_tpoMonto.SelectedIndexChanged
        If Combo_tpoMonto.Text = "Variable" Then
            tx_Monto.Text = "0"
            tx_Monto.Enabled = False
        Else
            tx_Monto.Text = ""
            tx_Monto.Enabled = True
        End If
    End Sub


    Private Sub Servicios_Alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Combo_tpoMonto.SelectedIndex = 0

    End Sub

    Private Sub tx_Monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Monto.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

            If Me.tx_Monto.Text <> "" Then
                If Me.tx_Monto.Text > 99999999 Then
                    e.Handled = True
                End If
            End If

        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                'If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                '    e.Handled = True
                'End If


            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_cancelar.Click
        Me.Close()
        'Egresos_Alta.Cargo_servicios()
        Egresos_Alta.Combo_Gasto.Enabled = True
    End Sub
End Class