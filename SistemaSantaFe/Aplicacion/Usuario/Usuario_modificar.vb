Public Class Usuario_modificar

    Dim DAusuario As New Datos.Usuario
    Dim ds_usuariotipo As DataSet
    Dim ds_usuario As DataSet
    Private Sub Usuario_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar()
        'USU_baja_Configuracion()
    End Sub
    Public Sub USU_baja_Configuracion()
        'ds_usuariotipo = DAusuario.UsuarioTipo_obtener
        'COM_UT_dep.DataSource = ds_usuariotipo.Tables(0)
        'COM_UT_dep.DisplayMember = "UT_desc"
        'COM_UT_dep.ValueMember = "UT_id"
        'Cargar()

        
    End Sub

    Private Sub Bo_desbloq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_desbloq.Click

        If DG_bloqueados.Rows.Count <> 0 Then

            Dim result As DialogResult
            result = MessageBox.Show("¿Desea Desbloquear el Usuario seleccionado?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Dim USU_id As String = DG_bloqueados.SelectedRows(0).Cells(0).Value.ToString
                DAusuario.Usuario_Desbloquear(USU_id)
                Cargar()
                MessageBox.Show("El Usuario fue Desbloqueado correctamente.", "Sistema de Gestión.")
            End If
        Else
            MessageBox.Show("Seleccione un usuario bloqueado.", "La Santa Fe")
        End If
    End Sub
    Private Sub BO_usuario_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_usuario_modificar.Click
        If Me.DG_usuario.Rows.Count <> 0 Then
            Dim usuarioselec As String = DG_usuario.SelectedCells(0).Value
            If usuarioselec <> "" Then
                Usuario_alta.Close()
                Usuario_alta.usu_id = usuarioselec
                Usuario_alta.form_procedencia = "modificar"
                Usuario_alta.Text = "Actualizar Usuario"
                Usuario_alta.Show()
                Me.Close()
            Else
                MsgBox("Seleccione un Usuario", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un Usuario", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub BO_producto_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_usuario_nuevo.Click
        Me.Close()
        Usuario_alta.Show()
    End Sub
    Private Sub BO_usuario_bloquead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_usuario_bloquead.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Bloquear el Usuario seleccionado?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If Me.DG_usuario.Rows.Count <> 0 Then
                Dim usuarioselec As String = DG_usuario.SelectedCells(0).Value
                If usuarioselec <> "" Then
                    DAusuario.Usuario_bloquear(usuarioselec)
                    Cargar() 'esto recupera de nuevo los usuarios para las dos grillas
                    MessageBox.Show("El usuario fue bloqueado correctamente", "Sistema de Gestión.")
                Else
                    MsgBox("Seleccione un Usuario", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Seleccione un Usuario", MsgBoxStyle.Information)
            End If
        End If


    End Sub

    Private Sub DG_usuario_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DG_usuario.SelectionChanged
        'If ((DG_usuario.CurrentRow Is Nothing) OrElse (DG_usuario.SelectedRows.Count <> 0)) Then
        '    Bo_bloquear.Enabled = True
        '    Bo_cambiar.Enabled = True
        'Else
        '    Bo_bloquear.Enabled = False
        '    Bo_cambiar.Enabled = False
        'End If
    End Sub

    Private Sub DG_bloqueados_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DG_bloqueados.SelectionChanged
        'If ((DG_bloqueados.CurrentRow Is Nothing) OrElse (DG_bloqueados.SelectedRows.Count <> 0)) Then
        '    Bo_desbloq.Enabled = True
        'Else
        '    Bo_desbloq.Enabled = False
        'End If
    End Sub


    Public Sub Cargar()
        ds_usuario = DAusuario.Usuario_obtener
        DG_usuario.DataSource = ds_usuario.Tables(0)
        DG_bloqueados.DataSource = ds_usuario.Tables(1)
        'DG_bloqueados.ClearSelection()
        'DG_usuario.ClearSelection()
    End Sub





End Class