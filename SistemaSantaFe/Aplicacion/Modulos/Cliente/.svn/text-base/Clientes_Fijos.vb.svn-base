Imports System.IO
Imports System.Data.OleDb
Public Class Clientes_Fijos

    Dim DAcliente As New Datos.Cliente

    Dim busqueda As String = ""
    Dim busqueda_parametro As String = ""
    Dim ds_CLI As DataSet

    Private Sub TX_doc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub
    Private Sub TX_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub BO_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TX_ape_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub
    Private Sub BO_ape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub BO_Jugador_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BO_ape_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ape.Click

        ds_CLI = DAcliente.Cliente_ObtenerApe_Fijo(TX_ape.Text)
        With ds_CLI.Tables(0).Rows
            If .Count > 0 Then
                DG_cliente.Enabled = True
                DG_cliente.DataSource = ds_CLI.Tables(0)
                IM_ERROR_cliente.Visible = False
                LB_ERROR_cliente.Visible = False
            Else
                DG_cliente.Enabled = False
                DG_cliente.DataSource = Nothing
                IM_ERROR_cliente.Visible = True
                LB_ERROR_cliente.Visible = True
            End If
        End With
        TX_doc.Text = Nothing
    End Sub





    Private Sub BO_doc_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_doc.Click
        If TX_doc.Text <> "" Then

            ds_CLI = DAcliente.Cliente_ObtenerDni_Fijo(TX_doc.Text)
            With ds_CLI.Tables(0).Rows
                If .Count > 0 Then
                    DG_cliente.Enabled = True
                    DG_cliente.DataSource = ds_CLI.Tables(0)
                    IM_ERROR_cliente.Visible = False
                    LB_ERROR_cliente.Visible = False
                Else
                    DG_cliente.Enabled = False
                    DG_cliente.DataSource = Nothing
                    IM_ERROR_cliente.Visible = True
                    LB_ERROR_cliente.Visible = True
                End If
            End With
            TX_ape.Text = Nothing
        Else
            MessageBox.Show("Ingrese el numero de Dni", "La Santa Fe")
        End If

    End Sub
    Dim CLI_id As Integer
    Private Sub BO_Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cargar.Click

        CLI_id = DG_cliente.CurrentRow.Cells(0).Value

        ds_CLI = DAcliente.Clientes_Fijos_Consulta(CLI_id)
        With ds_CLI.Tables(0).Rows
            If .Count > 0 Then
                DG_Pagos.Enabled = True
                DG_Pagos.DataSource = ds_CLI.Tables(0)
                IM_ERROR_cliente.Visible = False
                LB_ERROR_cliente.Visible = False
            Else
                DG_Pagos.Enabled = False
                DG_Pagos.DataSource = Nothing
                IM_ERROR_cliente.Visible = True
                LB_ERROR_cliente.Visible = True
            End If
        End With




        TabControl1.SelectedTab = TabPage2



    End Sub

    Private Sub BO_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Guardar.Click
        If Tx_Monto.Text <> "" Then
            DAcliente.Clientes_Fijos_Pagos_Alta(CLI_id, DT_fecha.Value, Tx_Monto.Text, Tx_observacion.Text)
            MessageBox.Show("Se Guardo con Exito", "La Santa Fe")
            Tx_Monto.Text = ""
            Tx_observacion.Text = ""

            CLI_id = DG_cliente.CurrentRow.Cells(0).Value

            ds_CLI = DAcliente.Clientes_Fijos_Consulta(CLI_id)
            With ds_CLI.Tables(0).Rows
                If .Count > 0 Then
                    DG_Pagos.Enabled = True
                    DG_Pagos.DataSource = ds_CLI.Tables(0)
                    IM_ERROR_cliente.Visible = False
                    LB_ERROR_cliente.Visible = False
                Else
                    DG_Pagos.Enabled = False
                    DG_Pagos.DataSource = Nothing
                    IM_ERROR_cliente.Visible = True
                    LB_ERROR_cliente.Visible = True
                End If
            End With

        Else
            MessageBox.Show("Ingrese un monto", "La Santa Fe")
            Tx_Monto.Focus()
        End If
    End Sub

    Private Sub Tx_Monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_Monto.KeyPress
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
                If e.KeyChar = "," And Not Me.Tx_Monto.Text.IndexOf(",") Then
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
    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Tx_Monto.Text = ""
        Tx_observacion.Text = ""
        DG_Pagos.DataSource = ""
        TabControl1.SelectedTab = TabPage1

    End Sub
End Class