

Public Class TiposUsuarios_Gestion
    Dim dausuario As New Datos.Usuario

    Private Sub TiposUsuarios_Gestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        buscar_usuarios()
        SetReadonlyControls(GroupBox1.Controls)

    End Sub

    Private Sub SetReadonlyControls(ByVal controlCollection As Control.ControlCollection)
        If controlCollection Is Nothing Then
            Return
        End If

        For Each c As TextBoxBase In controlCollection.OfType(Of TextBoxBase)()
            c.[ReadOnly] = True
        Next
    End Sub
    Private Sub Permisos_USU(ByVal Tipo As Integer)
        'Para Dialisis oculto lo que no necesito'
        Dim DS_Modulos As DataSet = dausuario.UsuarioModulos_obtener(Tipo)
        Dim i As Integer = 0
        While i < DS_Modulos.Tables(0).Rows.Count

            ''________PACIENTE________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "PAC_actualizar" Then
                ' GroupBox_pac.Visible = True
                CheckBox_PAC_actualizar.Checked = True

            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "PAC_Nuevo" Then
                '  GroupBox_pac.Visible = True
                CheckBox_PAC_nuevo.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "PAC_HC" Then
                '  GroupBox_pac.Visible = True
                CheckBox_PAC_HC.Checked = True
            End If
            ''______________FIN PACIENTE_____________


            ''________ENFERMERIA________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_NSD" Then
                'GroupBox_Med.Visible = True
                CheckBox_ENF_NSD.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_ID" Then
                'GroupBox_Med.Visible = True
                CheckBox_ENF_InfDia.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_Consulta" Then
                'GroupBox_Med.Visible = True
                CheckBox_ENF_ConsSes.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_stock" Then
                'GroupBox_Med.Visible = True
                CheckBox_ENF_stock.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "ENF_RevMov" Then
                'GroupBox_Med.Visible = True
                CheckBox_ENF_RevMov.Checked = True
            End If

            ''_____________ENFERMERIA____________



            '________MEDICO________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "MEDICO_Nuevo" Then
                'GroupBox_Med.Visible = True
                CheckBox_MED_nuevo.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "MEDIOC_Consulta" Then
                ' GroupBox_Med.Visible = True
                CheckBox_MED_cons.Checked = True
            End If

            '______________FIN MEDICO_____________



            '________OBRA SOCIAL________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "OBRA_nuevo" Then
                'GroupBox_Med.Visible = True
                CheckBox_OBRA_nuevo.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "OBRA_Actualizar" Then
                ' GroupBox_Med.Visible = True
                CheckBox_OBRA_actualizar.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "OBRA_InfPac" Then
                ' GroupBox_Med.Visible = True
                CheckBox_OBRA_InfPAC.Checked = True
            End If

            '______________OBRA SOCIAL_____________


            '________DEPOSITO________''''''

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "DEP_Ingreso" Then
                'GroupBox_Med.Visible = True
                CheckBox_DEP_ingreso.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "DEP_Mov" Then
                ' GroupBox_Med.Visible = True
                CheckBox_DEP_Mov.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "DEP_Baja" Then
                ' GroupBox_Med.Visible = True
                CheckBox_DEP_Baja.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "DEP_Consultas" Then
                ' GroupBox_Med.Visible = True
                CheckBox_DEP_Consulta.Checked = True
            End If

            '______________DEPOSITO_____________



            ''____STOCK______________________

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Insumos" Then
                'GroupBox_Med.Visible = True
                CheckBox_STOCK_insumo.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Prove" Then
                ' GroupBox_Med.Visible = True
                CheckBox_STOCK_Prov.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Marca" Then
                ' GroupBox_Med.Visible = True
                CheckBox_STOCK_marca.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Cat" Then
                ' GroupBox_Med.Visible = True
                CheckBox_STOCK_Cat.Checked = True
            End If

            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Consumir" Then
                ' GroupBox_Med.Visible = True
                CheckBox_STOCK_Consumir.Checked = True
            End If


            If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "STOCK_Consulta" Then
                ' GroupBox_Med.Visible = True
                CheckBox_STOCK_Consultar.Checked = True
            End If

            ''____________FIN SOTCK__________________


            i = i + 1
        End While



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
                Permisios_Dialisis.Close()
                Permisios_Dialisis.Show()
                Me.Show()

            End If
        End If
    End Sub


    Private Sub blanquear_todo()
        ''________PACIENTE________''''''

      
        CheckBox_PAC_actualizar.Checked = False

        CheckBox_PAC_nuevo.Checked = False
      
        CheckBox_PAC_HC.Checked = False

        ''______________FIN PACIENTE_____________


        ''________ENFERMERIA________''''''

       
        CheckBox_ENF_NSD.Checked = False
      
        CheckBox_ENF_InfDia.Checked = False

        CheckBox_ENF_ConsSes.Checked = False

        CheckBox_ENF_RevMov.Checked = False

        CheckBox_ENF_stock.Checked = False
      
        ''_____________ENFERMERIA____________



        '________MEDICO________''''''

      
        CheckBox_MED_nuevo.Checked = False

        CheckBox_MED_cons.Checked = False
        
        '______________FIN MEDICO_____________



        '________OBRA SOCIAL________''''''

       
        CheckBox_OBRA_nuevo.Checked = False
       
        CheckBox_OBRA_actualizar.Checked = False
      
        CheckBox_OBRA_InfPAC.Checked = False


        '______________OBRA SOCIAL_____________


        '________DEPOSITO________''''''


        CheckBox_DEP_ingreso.Checked = False
       
        CheckBox_DEP_Mov.Checked = False
       
        CheckBox_DEP_Baja.Checked = False
       
        CheckBox_DEP_Consulta.Checked = False
       
        '______________DEPOSITO_____________



        ''____STOCK______________________

        CheckBox_STOCK_insumo.Checked = False
     
        CheckBox_STOCK_Prov.Checked = False
       
        CheckBox_STOCK_marca.Checked = False
     
        CheckBox_STOCK_Cat.Checked = False
      
        CheckBox_STOCK_Consumir.Checked = False
      
        CheckBox_STOCK_Consultar.Checked = False
    
        ''____________FIN SOTCK__________________


    End Sub

    Private Sub DG_TipoUs_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_TipoUs.SelectionChanged
        blanquear_todo()
        If DG_TipoUs.Rows.Count <> 0 Then
            Permisos_USU(CInt(DG_TipoUs.CurrentRow.Cells("UT_id").Value))
        End If

    End Sub
End Class