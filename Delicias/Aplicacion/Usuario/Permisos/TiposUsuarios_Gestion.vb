

Public Class TiposUsuarios_Gestion
    Dim dausuario As New Datos.Usuario

    Private Sub TiposUsuarios_Gestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        buscar_usuarios()
    End Sub
    Private Sub buscar_usuarios()
        Dim ds_tiposUsuario As DataSet = dausuario.UsuarioTipo_obtener
        If ds_tiposUsuario.Tables(0).Rows.Count <> 0 Then
            DS_usuario.Tables("Tipos_Usuario").Rows.Clear()
            DS_usuario.Tables("Tipos_Usuario").Merge(ds_tiposUsuario.Tables(0))
        End If
    End Sub
    Private Sub btn_Agregar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Prod.Click
        TipoUsuario_altavb.Close()
        TipoUsuario_altavb.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DG_TipoUs.SelectedCells(0).Value = 1 Or DG_TipoUs.SelectedCells(0).Value = 2 Then
            MessageBox.Show("Lo Sentimos no puede eliminar este tipo de usuario", "Sistema de Gestión")

        Else
            Dim result As Integer = MessageBox.Show("Advertencia: los usuarios que sean de este tipo no podrán acceder al sistema  ¿Está seguro que desea eliminar el tipo de usuario?", "Sistema de Gestión", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim Ds_Usuarios_eliminar As DataSet = dausuario.UsuarioModulos_eliminar(DG_TipoUs.SelectedCells(0).Value)
                Dim i = 0
                If Ds_Usuarios_eliminar.Tables(0).Rows.Count <> 0 Then
                    While i < Ds_Usuarios_eliminar.Tables(0).Rows.Count
                        dausuario.Usuario_Bloquear_cambiarTipo(Ds_Usuarios_eliminar.Tables(0).Rows(i).Item(0))
                        i = i + 1
                    End While
                End If
                dausuario.UsuarioTipo_eliminar(DG_TipoUs.SelectedCells(0).Value)
                MessageBox.Show("Se eliminó correctamente el tipo de usuario. Los usuarios correspondientes al tipo fueron bloqueados.", "Sistema de Gestión")
                buscar_usuarios()
                Permisos.Close()
                Permisos.Show()
                Me.Show()

            End If
        End If
    End Sub
End Class