Public Class Terminal_modificar

    Private Sub Terminal_modificar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Dim daTerminal As New Datos.Terminal
    Private Sub Terminal_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds_terminal As DataSet = daTerminal.Terminal_obtener
        DataGridView1.DataSource = ds_terminal.Tables(0)
    End Sub

    Private Sub BO_usuario_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_usuario_nuevo.Click
        Terminal_alta.Close()
        Terminal_alta.Procedencia = "alta"
        Terminal_alta.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim celda_actual = e.ColumnIndex
        If celda_actual = 0 Then 'la 0 es la que tiene el check
            Dim fila As Integer = DataGridView1.CurrentRow.Index
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If i <> fila Then
                    DataGridView1.Rows(i).Cells(0).Value = False
                End If
                i = i + 1
            End While
            DataGridView1.Rows(fila).Cells(0).Value = True
        End If
    End Sub

    Private Sub BO_usuario_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_usuario_modificar.Click
        Dim indice_chek As Integer = 0
        Dim encontrado = "no"
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells(0).Value = True Then
                indice_chek = i
                encontrado = "si"
                Exit While
            End If
            i = i + 1
        End While
        If encontrado = "no" Then
            MessageBox.Show("Error, Debe seleccionar una terminal para editar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Terminal_alta.Close()
            Terminal_alta.Procedencia = "modificar"
            Terminal_alta.Text = "Editar terminal"
            Terminal_alta.terminal_id = CInt(DataGridView1.Rows(indice_chek).Cells("TerminalesidDataGridViewTextBoxColumn").Value)
            Terminal_alta.sucursal_id = CInt(DataGridView1.Rows(indice_chek).Cells("SucursalidDataGridViewTextBoxColumn").Value)
            Terminal_alta.txt_terminal.Text = DataGridView1.Rows(indice_chek).Cells("TerminalesdescDataGridViewTextBoxColumn").Value

            Terminal_alta.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BO_usuario_bloquead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_usuario_bloquead.Click
        Dim indice_chek As Integer = 0
        Dim encontrado = "no"
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells(0).Value = True Then
                indice_chek = i
                encontrado = "si"
                Exit While
            End If
            i = i + 1
        End While
        If encontrado = "no" Then
            MessageBox.Show("Error, Debe seleccionar una terminal para bloquear.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("¿Está seguro que quiere bloquear la terminal?. El usuario no podra acceder a ella.", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim terminal_id As Integer = DataGridView1.Rows(indice_chek).Cells("TerminalesidDataGridViewTextBoxColumn").Value
                If terminal_id = 1 Then
                    MessageBox.Show("Error, No se puede bloquear la terminal ID_1, consulte con el administrador del sistema.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else

                    If DataGridView1.Rows(indice_chek).Cells("TerminalesestadoDataGridViewTextBoxColumn").Value = "Libre" Then
                        'aqui va el update en BD

                        daTerminal.Terminal_bloquear_desbloquear(terminal_id, "Bloqueado")
                        'llamo de nuevo al proc del load
                        Dim ds_terminal As DataSet = daTerminal.Terminal_obtener
                        DataGridView1.DataSource = ds_terminal.Tables(0)
                        '////////////////////////////////////////
                        MessageBox.Show("Se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Debe liberar la terminal primero.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

                
            End If
        End If
    End Sub

    Private Sub Bo_desbloq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_desbloq.Click
        Dim indice_chek As Integer = 0
        Dim encontrado = "no"
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells(0).Value = True Then
                indice_chek = i
                encontrado = "si"
                Exit While
            End If
            i = i + 1
        End While
        If encontrado = "no" Then
            MessageBox.Show("Error, Debe seleccionar una terminal para desbloquear.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("¿Está seguro que quiere desbloquear la terminal?. El usuario podra acceder nuevamente.", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DataGridView1.Rows(indice_chek).Cells("TerminalesestadoDataGridViewTextBoxColumn").Value = "Bloqueado" Then
                    'aqui va el update en BD
                    Dim terminal_id As Integer = DataGridView1.Rows(indice_chek).Cells("TerminalesidDataGridViewTextBoxColumn").Value
                    daTerminal.Terminal_bloquear_desbloquear(terminal_id, "Libre")
                    'llamo de nuevo al proc del load
                    Dim ds_terminal As DataSet = daTerminal.Terminal_obtener
                    DataGridView1.DataSource = ds_terminal.Tables(0)
                    '////////////////////////////////////////
                    MessageBox.Show("Se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("La terminal no está bloqueada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub
End Class