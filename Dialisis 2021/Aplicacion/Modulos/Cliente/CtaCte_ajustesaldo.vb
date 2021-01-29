Public Class CtaCte_ajustesaldo

    Private Sub txt_cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cliente.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_saldoactual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_saldoactual.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_saldonuevo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_saldonuevo.KeyPress
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
                If e.KeyChar = "," And Not Me.txt_saldonuevo.Text.IndexOf(",") Then
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
            If txt_saldonuevo.Text = "" Then
                txt_saldonuevo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                txt_saldonuevo.Text = (Math.Round(CDec(txt_saldonuevo.Text), 2).ToString("N2"))
            End If
        End If
    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Me.Close()
    End Sub
    Dim DAcuentacorriente As New Datos.CuentaCorriente
    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click

        If MessageBox.Show("¿Esta seguro de efectuar el ajuste de saldo?", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If txt_saldonuevo.Text = "" Then
                txt_saldonuevo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                txt_saldonuevo.Text = (Math.Round(CDec(txt_saldonuevo.Text), 2).ToString("N2"))
            End If

            If CDec(txt_saldonuevo.Text) = 0 Then
                'se registra el movimiento como un egreso(HABER) . ...va a dejar el total de ctacta = 0 saldado.
                Dim cliente_id As Integer = CInt(Cliente_Cta_Cte_Buscar.DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value)
                Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(cliente_id)
                If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                    Dim saldo_vigente As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) 'esto va en Haber
                    Dim deuda As Decimal = CDec(0)
                    Dim CtaCte_id As Integer = ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_id")
                    DAcuentacorriente.CtaCte_registrar_egreso(CtaCte_id, deuda) 'actualizo total de la deuda.
                    Dim concepto As String = "Ajusto de saldo"
                    DAcuentacorriente.CtaCte_movimiento_alta(CtaCte_id, "Egreso", concepto, saldo_vigente, Now)
                End If
            Else
                If CDec(txt_saldonuevo.Text) > CDec(txt_saldoactual.Text) Then
                    'si es mayor, el movimiento es como un ingreso (DEBE), sumo la diferencia en tota cta cte.
                    Dim cliente_id As Integer = CInt(Cliente_Cta_Cte_Buscar.DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value)
                    Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(cliente_id)
                    If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                        Dim diferencia As Decimal = CDec(txt_saldonuevo.Text) - CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total"))  'esto va en Haber
                        Dim deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) + diferencia
                        Dim CtaCte_id As Integer = ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_id")
                        DAcuentacorriente.CtaCte_registrar_egreso(CtaCte_id, deuda) 'actualizo total de la deuda.
                        Dim concepto As String = "Ajusto de saldo"
                        DAcuentacorriente.CtaCte_movimiento_alta(CtaCte_id, "Ingreso", concepto, diferencia, Now)
                    End If
                Else
                    If CDec(txt_saldonuevo.Text) < CDec(txt_saldoactual.Text) Then
                        'si es menor, el movimiento es como in egreso (haber), la diferencia resto en total
                        Dim cliente_id As Integer = CInt(Cliente_Cta_Cte_Buscar.DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value)
                        Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(cliente_id)
                        If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                            Dim diferencia As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) - CDec(txt_saldonuevo.Text)  'esto va en Haber
                            Dim deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) - diferencia
                            Dim CtaCte_id As Integer = ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_id")
                            DAcuentacorriente.CtaCte_registrar_egreso(CtaCte_id, deuda) 'actualizo total de la deuda.
                            Dim concepto As String = "Ajusto de saldo"
                            DAcuentacorriente.CtaCte_movimiento_alta(CtaCte_id, "Egreso", concepto, diferencia, Now)
                        End If
                    End If
                End If
            End If
            'reflejar cambios en la grilla del formulario Cliente_Cta_Cte_buscar
            Cliente_Cta_Cte_Buscar.Obtener_Movimientos()
            MessageBox.Show("El cambio se registró correctamente.", "Sistema de Gestion.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

        

    End Sub

    Private Sub CtaCte_ajustesaldo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'con ESC cierro el formulario, cancelo operacion.
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class