Public Class Permisios_Dialisis


    Dim dausuario As New Datos.Usuario
    Dim ds_usuariotipo As DataSet
    Dim DAsucursal As New Datos.Sucursal
    Public paso = "no"
    Dim DS_Modulos As DataSet

    Private Sub Permisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Blanquear_Check()
    End Sub
    Private Sub Blanquear_Check()
        tx_desc.Text = ""


        '___PACIENTE______
        CheckBox_PAC_actualizar.Checked = False
        CheckBox_PAC_nuevo.Checked = False
        CheckBox_PAC_HC.Checked = False
        '_______________

        '___ENFERMERIA______

        CheckBox_ENF_NSD.Checked = False
        CheckBox_ENF_InfDia.Checked = False
        CheckBox_ENF_ConsSes.Checked = False
        CheckBox_ENF_RevMov.Checked = False
        CheckBox_ENF_stock.Checked = False

        '_________________


        '___MEDICO______

        CheckBox_MED_cons.Checked = False
        CheckBox_MED_nuevo.Checked = False

        '___________________

      
        '___OBRA SOCIAL______
        CheckBox_OBRA_actualizar.Checked = False
        CheckBox_OBRA_InfPAC.Checked = False
        CheckBox_OBRA_nuevo.Checked = False
        '_________________

        '___OBRA SOCIAL______
        CheckBox_DEP_Baja.Checked = False
        CheckBox_DEP_Consulta.Checked = False
        CheckBox_DEP_ingreso.Checked = False
        CheckBox_DEP_ingreso.Checked = False
        '_________________



        '___STOCK______
        CheckBox_STOCK_Cat.Checked = False
        CheckBox_STOCK_Consultar.Checked = False
        CheckBox_STOCK_Consumir.Checked = False
        CheckBox_STOCK_insumo.Checked = False

        CheckBox_STOCK_marca.Checked = False
        CheckBox_STOCK_Prov.Checked = False

        '_________________



    End Sub









    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim result As Integer = MessageBox.Show("¿Esta Seguro que desea Guardar los Datos?", "Sistema de Gestión", MessageBoxButtons.YesNo)
        Dim guardado = 0
        If result = DialogResult.Yes Then
            If tx_desc.Text <> "" Then




                Dim ds_UtAtla As DataSet = dausuario.UsuarioTipo_Alta(tx_desc.Text)
                Dim UT_id = ds_UtAtla.Tables(0).Rows(0).Item(0)

                'Elimino todo de la BD
                'dausuario.UsuarioModulos_eliminar(cb_tipous.SelectedValue)

                '________PACIENTE________''''''

                If CheckBox_PAC_actualizar.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "PAC_actualizar")
                    guardado = 1
                End If
                If CheckBox_PAC_nuevo.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "PAC_Nuevo")
                End If

                If CheckBox_PAC_HC.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "PAC_HC")
                End If

                '______________FIN PACIENTE_____________



                '________ENFERMERIA________''''''

                If CheckBox_ENF_NSD.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "ENF_NSD")
                    guardado = 1
                End If
                If CheckBox_ENF_InfDia.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "ENF_ID")
                End If

                If CheckBox_ENF_ConsSes.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "ENF_Consulta")
                End If

                If CheckBox_ENF_RevMov.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "ENF_RevMov")
                End If

                If CheckBox_ENF_stock.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "ENF_stock")
                End If
                '________ENFERMERIA________


                '________MEDICO________''''''

                If CheckBox_MED_nuevo.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "MEDICO_Nuevo")
                    guardado = 1
                End If
                If CheckBox_MED_cons.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "MEDIOC_Consulta")
                End If

                '______________FIN MEDICO_____________


                '________OBRA SOCIAL________''''''

                If CheckBox_OBRA_nuevo.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "OBRA_nuevo")
                    guardado = 1
                End If

                If CheckBox_OBRA_actualizar.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "OBRA_Actualizar")
                    guardado = 1
                End If

                If CheckBox_OBRA_InfPAC.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "OBRA_InfPac")
                    guardado = 1
                End If

                '______________FIN _OBRA SOCIAL_____________



                '________DEPOSITO________''''''

                If CheckBox_DEP_ingreso.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "DEP_Ingreso")
                    guardado = 1
                End If

                If CheckBox_DEP_Mov.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "DEP_Mov")
                End If

                If CheckBox_DEP_Baja.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "DEP_Baja")
                    guardado = 1
                End If

                If CheckBox_DEP_Consulta.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "DEP_Consultas")
                End If

                '________FIN DEPOSITO________''''''



                '________STOCK________''''''

                If CheckBox_STOCK_insumo.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "STOCK_Insumos")
                    guardado = 1
                End If

                If CheckBox_STOCK_Prov.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "STOCK_Prove")
                End If

                If CheckBox_STOCK_marca.Checked = True Then
                    dausuario.UsuarioModulos_alta(UT_id, "STOCK_Marca")
                    guardado = 1
                End If

                If CheckBox_STOCK_Cat.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "STOCK_Cat")
                End If

                If CheckBox_STOCK_Consumir.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "STOCK_Consumir")
                End If

                If CheckBox_STOCK_Consultar.Checked = True Then
                    guardado = 1
                    dausuario.UsuarioModulos_alta(UT_id, "STOCK_Consulta")
                End If
                '------------------------------


                '______________FIN STOCK_____________





                If guardado = 1 Then
                    MessageBox.Show("Los datos fueron guardados correctamente", "Sistema de Gestión.")
                    Blanquear_Check()
                Else
                    MessageBox.Show("Debe Seleccionar al Menos una opcion", "Sistema de Gestión.")
                End If



            Else
                MessageBox.Show("Debe Ingresar la Descripción", "Sistema de Gestion")
            End If

        End If




    End Sub


    

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Blanquear_Check()
    End Sub

    Private Sub btn_Agregar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Prod.Click
        TiposUsuarios_Gestion.Close()
        TiposUsuarios_Gestion.Show()
    End Sub








End Class