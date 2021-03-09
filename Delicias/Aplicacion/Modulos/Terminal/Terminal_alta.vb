Public Class Terminal_alta
    Dim dasucursa As New Datos.Sucursal
    Dim daTerminal As New Datos.Terminal
    Public Procedencia As String = "alta"
    Private Sub Terminal_alta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Terminal_modificar.Close()
        Terminal_modificar.Show()
        Me.Close()
    End Sub
    Public sucursal_id As Integer
    Private Sub Terminal_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_sucursales()
        If Procedencia = "modificar" Then
            Combo_sucursal.SelectedValue = sucursal_id
            Combo_sucursal.Enabled = False
        Else
            Combo_sucursal.Enabled = True
        End If
    End Sub

    Private Sub recuperar_sucursales()
        Dim ds_suc As DataSet = dasucursa.Sucursal_obtener()
        Combo_sucursal.DataSource = ds_suc.Tables(0)
        Combo_sucursal.DisplayMember = "sucursal_nombre"
        Combo_sucursal.ValueMember = "sucursal_id"
    End Sub
    Public terminal_id As Integer
    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If Procedencia = "alta" Then

            If MessageBox.Show("¿Desea agregar la terminal?.", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If txt_terminal.Text <> "" And Combo_sucursal.Items.Count <> 0 Then
                    'valido que no exista ya.
                    Dim ds_valido As DataSet = daTerminal.Terminal_validar_alta(txt_terminal.Text)
                    If ds_valido.Tables(0).Rows.Count = 0 Then
                        daTerminal.Terminal_alta(Combo_sucursal.SelectedValue, txt_terminal.Text)
                        MessageBox.Show("Se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        Terminal_modificar.Close()
                        Terminal_modificar.Show()
                    Else
                        MessageBox.Show("Error, la terminal existe. Modifique los datos.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Error, debe ingresar los datos de la terminal.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If Procedencia = "modificar" Then
                If MessageBox.Show("¿Desea modificar la terminal?.", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If txt_terminal.Text <> "" And Combo_sucursal.Items.Count <> 0 Then
                        'valido que no exista ya.
                        Dim ds_valido As DataSet = daTerminal.Terminal_validar_alta(txt_terminal.Text)
                        If ds_valido.Tables(0).Rows.Count = 0 Then

                            daTerminal.Terminal_modificar(terminal_id, txt_terminal.Text)

                            'daTerminal.Terminal_alta(Combo_sucursal.SelectedValue, txt_terminal.Text)
                            MessageBox.Show("Se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                            Terminal_modificar.Close()
                            Terminal_modificar.Show()
                        Else
                            'recorro
                            Dim valido As String = "si"
                            Dim i As Integer = 0
                            While i < ds_valido.Tables(0).Rows.Count
                                If ds_valido.Tables(0).Rows(i).Item("Terminales_id") <> terminal_id Then
                                    valido = "no"
                                End If
                                i = i + 1
                            End While
                            If valido = "si" Then
                                daTerminal.Terminal_modificar(terminal_id, txt_terminal.Text)
                                'daTerminal.Terminal_alta(Combo_sucursal.SelectedValue, txt_terminal.Text)
                                MessageBox.Show("Se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                                Terminal_modificar.Close()
                                Terminal_modificar.Show()
                            Else
                                MessageBox.Show("Error, la terminal existe. Modifique los datos.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    Else
                        MessageBox.Show("Error, debe ingresar los datos de la terminal.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If



            End If

        End If

    End Sub
End Class