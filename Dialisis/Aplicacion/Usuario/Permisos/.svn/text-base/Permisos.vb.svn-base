Public Class Permisos

    Dim dausuario As New Datos.Usuario
    Dim ds_usuariotipo As DataSet
    Dim DAsucursal As New Datos.Sucursal
    Public paso = "no"
    Dim DS_Modulos As DataSet

    Private Sub Permisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usuario_inicio()
        Cargar_Perfil()
    End Sub
    Private Sub Blanquear_Check()
        '___Cliente______
        CheckBox_Cli_todos.Checked = False
        CheckBox_cli_Actualizar.Checked = False
        CheckBox_cli_informe.Checked = False
        CheckBox_cli_nuevo.Checked = False
        '___________________

        '___Confuguracion______
        CheckBox_conf_todos.Checked = False
        CheckBox_conf_empresa.Checked = False
        CheckBox_conf_sucursal.Checked = False
        TreeView_conf.Nodes(0).Checked = False
        TreeView_conf.Nodes(0).Nodes(0).Checked = False
        TreeView_conf.Nodes(0).Nodes(1).Checked = False
        TreeView_conf.Nodes(0).Nodes(2).Checked = False
        '_________________

        '___Pedidos______
        CheckBox_pedidos_todos.Checked = False
        CheckBox_Pedidos_cons.Checked = False
        CheckBox_pedidos_nuevo.Checked = False
        CheckBox_pedidos_recepcion.Checked = False
        '____________

        '___servcios______
        CheckBox_Servicio_todos.Checked = False
        CheckBox_servicio_consulta.Checked = False
        CheckBox_servicio_nuevo.Checked = False
        '_______________

        '___stock______
        CheckBox_stock_todos.Checked = False
        CheckBox_stock_Cat.Checked = False
        CheckBox_stock_GM.Checked = False
        CheckBox_Stock_Cons_Mov.Checked = False
        TreeView_prod.Nodes(0).Checked = False
        TreeView_prod.Nodes(0).Nodes(0).Checked = False
        TreeView_prod.Nodes(0).Nodes(1).Checked = False
        TreeView_Prov.Nodes(0).Checked = False
        TreeView_Prov.Nodes(0).Nodes(0).Checked = False
        TreeView_Prov.Nodes(0).Nodes(1).Checked = False
        '_________________

        '___venta______
        CheckBox_venta_todos.Checked = False
        CheckBox_venta_consulta.Checked = False
        CheckBox_venta_ventCaja.Checked = False
        '________________

        '___Caja______
        CheckBox_caja_Todos.Checked = False
        CheckBox_caja_cierrecaja.Checked = False
        CheckBox_Caja_EgreIngr.Checked = False
        CheckBox_Caja_Consulta.Checked = False
        '____________

    End Sub


    Private Sub Cargar_Perfil()
        If paso = "si" Then
            DS_Modulos = dausuario.UsuarioModulos_obtener(cb_tipous.SelectedValue)
            Dim i As Integer = 0

            Blanquear_Check()


            While i < DS_Modulos.Tables(0).Rows.Count
                '_____CLiente______
                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Cliente_Nuevo" Then
                    CheckBox_cli_nuevo.Checked = True
                Else


                End If
                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Cliente_Informe" Then
                    CheckBox_cli_informe.Checked = True
                Else


                End If
                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Cliente_Actulizar" Then
                    CheckBox_cli_Actualizar.Checked = True
                Else


                End If

                '___Fin CLiente____


                '____STOCK______________________

                '_Proveedores_____

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Proveedor_Nuevo" Then
                    TreeView_Prov.Nodes(0).Nodes(0).Checked = True
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Proveedor_Actualizar" Then
                    TreeView_Prov.Nodes(0).Nodes(1).Checked = True
             
                End If

                '_______________

                '_Producto_____

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Producto_Nuevo" Then
                    TreeView_prod.Nodes(0).Nodes(0).Checked = True
              
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Producto_Actualizar" Then
                    TreeView_prod.Nodes(0).Nodes(1).Checked = True
               
                End If
                '_______________

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Categoria" Then
                    CheckBox_stock_Cat.Checked = True
               
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Gestion_Mercaderia" Then
                    CheckBox_stock_GM.Checked = True

                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Stock_Consulta_Movimiento" Then
                    CheckBox_Stock_Cons_Mov.Checked = True

                End If

                '____________FIN SOTCK__________________

                '___VENTAS______

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Venta_Caja" Then
                    CheckBox_venta_ventCaja.Checked = True
              
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Venta_Consulta" Then
                    CheckBox_venta_consulta.Checked = True
                
                End If
                '________FIN VENTAS________

                '_______PEDIDOS_________

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Pedidos_Nuevo" Then
                    CheckBox_pedidos_nuevo.Checked = True
                
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Pedidos_Consulta" Then
                    CheckBox_Pedidos_cons.Checked = True
               
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Pedidos_Recepcion" Then
                    CheckBox_pedidos_recepcion.Checked = True
               
                End If
                '_________FIN PEDIDOS___________

                '___SERVICIOS________
                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Servicio_Nuevo" Then
                    CheckBox_servicio_nuevo.Checked = True
              
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Servicio_Consulta" Then
                    CheckBox_servicio_consulta.Checked = True
              
                End If
                '____________

                '___CONFIGURACION_______
                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Usuario_Nuevo" Then
                    TreeView_conf.Nodes(0).Nodes(0).Checked = True
               
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Usuario_Actualizar" Then
                    TreeView_conf.Nodes(0).Nodes(1).Checked = True
             
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Usuario_Permisos" Then
                    TreeView_conf.Nodes(0).Nodes(2).Checked = True
                
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Sucursal" Then
                    CheckBox_conf_sucursal.Checked = True
              
                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Configuracion_Empresa" Then
                    CheckBox_conf_empresa.Checked = True
               
                End If

                '___Caja________
                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Caja_CiereCaja" Then
                    CheckBox_caja_cierrecaja.Checked = True

                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Caja_EgreIngr" Then
                    CheckBox_Caja_EgreIngr.Checked = True

                End If

                If DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion") = "Caja_Consulta" Then
                    CheckBox_Caja_Consulta.Checked = True

                End If

                i = i + 1
            End While

            '___HabilitosChekTodos___
            If CheckBox_cli_nuevo.Checked = True And CheckBox_cli_informe.Checked = True And CheckBox_cli_Actualizar.Checked = True Then
                CheckBox_Cli_todos.Checked = True
            End If

            If TreeView_Prov.Nodes(0).Nodes(0).Checked = True And TreeView_Prov.Nodes(0).Nodes(1).Checked = True Then
                TreeView_Prov.Nodes(0).Checked = True
            End If

            If TreeView_prod.Nodes(0).Nodes(0).Checked = True And TreeView_prod.Nodes(0).Nodes(1).Checked = True Then
                TreeView_prod.Nodes(0).Checked = True
            End If

            If CheckBox_stock_Cat.Checked = True And CheckBox_stock_GM.Checked = True And TreeView_prod.Nodes(0).Checked = True And TreeView_Prov.Nodes(0).Checked = True And CheckBox_Stock_Cons_Mov.Checked = True Then
                CheckBox_stock_todos.Checked = True
            End If

            If CheckBox_venta_ventCaja.Checked = True And CheckBox_venta_consulta.Checked = True Then
                CheckBox_venta_todos.Checked = True
            End If

            If CheckBox_pedidos_recepcion.Checked = True And CheckBox_Pedidos_cons.Checked = True And CheckBox_pedidos_nuevo.Checked = True Then
                CheckBox_pedidos_todos.Checked = True
            End If

            If CheckBox_servicio_nuevo.Checked = True And CheckBox_servicio_consulta.Checked = True Then
                CheckBox_Servicio_todos.Checked = True
            End If

            If CheckBox_conf_sucursal.Checked = True And CheckBox_conf_empresa.Checked = True Then
                CheckBox_conf_todos.Checked = True
            End If

            If TreeView_conf.Nodes(0).Nodes(0).Checked = True And TreeView_conf.Nodes(0).Nodes(1).Checked = True And TreeView_conf.Nodes(0).Nodes(2).Checked = True Then
                TreeView_conf.Nodes(0).Checked = True
            End If

            If CheckBox_caja_cierrecaja.Checked = True And CheckBox_Caja_EgreIngr.Checked = True And CheckBox_Caja_Consulta.Checked = True Then
                CheckBox_caja_Todos.Checked = True
            End If
        End If
    End Sub
    Public Sub usuario_inicio()
        ds_usuariotipo = dausuario.UsuarioTipo_obtener
        cb_tipous.DataSource = ds_usuariotipo.Tables(0)
        cb_tipous.DisplayMember = "UT_desc"
        cb_tipous.ValueMember = "UT_id"
        paso = "si"
    End Sub
    


#Region "Checkboxes"

    Private Sub CheckBox_Cli_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Cli_todos.CheckedChanged

        If CheckBox_Cli_todos.Checked = True Then
            CheckBox_cli_informe.Checked = True
            CheckBox_cli_nuevo.Checked = True
            CheckBox_cli_Actualizar.Checked = True



        Else
            CheckBox_cli_informe.Checked = False
            CheckBox_cli_nuevo.Checked = False
            CheckBox_cli_Actualizar.Checked = False
        End If
    End Sub




    Private Sub CheckBox_stock_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_stock_todos.CheckedChanged
        Dim nodes_prod As TreeNodeCollection = TreeView_prod.Nodes
        Dim nodes_prov As TreeNodeCollection = TreeView_Prov.Nodes

        If CheckBox_stock_todos.Checked = True Then
            CheckBox_stock_GM.Checked = True
            CheckBox_stock_Cat.Checked = True
            CheckBox_Stock_Cons_Mov.Checked = True


            For Each n As TreeNode In nodes_prod
                'RecorrerNodos(n)
                n.Checked = True
            Next

            For Each n As TreeNode In nodes_prov
                'RecorrerNodos(n)
                n.Checked = True
            Next


        Else
            CheckBox_stock_GM.Checked = False
            CheckBox_stock_Cat.Checked = False
            CheckBox_Stock_Cons_Mov.Checked = False

            For Each n As TreeNode In nodes_prod
                'RecorrerNodos(n)
                n.Checked = False
            Next

            For Each n As TreeNode In nodes_prov
                'RecorrerNodos(n)
                n.Checked = False
            Next

        End If
    End Sub

    Private Sub TreeView_Prov_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Prov.AfterCheck

        If e.Node.Nodes.Count <> 0 Then

            For Each Nodo As TreeNode In e.Node.Nodes
                Nodo.Checked = e.Node.Checked
            Next

        End If


    End Sub

    Private Sub TreeView_prod_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_prod.AfterCheck
        If e.Node.Nodes.Count <> 0 Then

            For Each Nodo As TreeNode In e.Node.Nodes
                Nodo.Checked = e.Node.Checked
            Next

        End If
    End Sub



    Private Sub TreeView1_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_conf.AfterCheck
        If e.Node.Nodes.Count <> 0 Then

            For Each Nodo As TreeNode In e.Node.Nodes
                Nodo.Checked = e.Node.Checked
            Next

        End If
    End Sub



    Private Sub CheckBox_conf_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_conf_todos.CheckedChanged
        Dim nodes As TreeNodeCollection = TreeView_conf.Nodes

        If CheckBox_conf_todos.Checked = True Then
            CheckBox_conf_sucursal.Checked = True
            CheckBox_conf_empresa.Checked = True




            For Each n As TreeNode In nodes
                'RecorrerNodos(n)
                n.Checked = True
            Next

        Else
            CheckBox_conf_sucursal.Checked = False
            CheckBox_conf_empresa.Checked = False


            For Each n As TreeNode In nodes
                'RecorrerNodos(n)
                n.Checked = False
            Next
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_venta_todos.CheckedChanged
        If CheckBox_venta_todos.Checked = True Then
            CheckBox_venta_ventCaja.Checked = True
            CheckBox_venta_consulta.Checked = True



        Else
            CheckBox_venta_ventCaja.Checked = False
            CheckBox_venta_consulta.Checked = False

        End If
    End Sub


    Private Sub CheckBox_pedidos_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_pedidos_todos.CheckedChanged
        If CheckBox_pedidos_todos.Checked = True Then
            CheckBox_pedidos_nuevo.Checked = True
            CheckBox_Pedidos_cons.Checked = True
            CheckBox_pedidos_recepcion.Checked = True


        Else
            CheckBox_pedidos_nuevo.Checked = False
            CheckBox_Pedidos_cons.Checked = False
            CheckBox_pedidos_recepcion.Checked = False


        End If


    End Sub

    Private Sub CheckBox_Servicio_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Servicio_todos.CheckedChanged
        If CheckBox_Servicio_todos.Checked = True Then
            CheckBox_servicio_nuevo.Checked = True
            CheckBox_servicio_consulta.Checked = True


        Else
            CheckBox_servicio_nuevo.Checked = False
            CheckBox_servicio_consulta.Checked = False

        End If
    End Sub

    Private Sub CheckBox_caja_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_caja_Todos.CheckedChanged
        If CheckBox_caja_Todos.Checked = True Then
            CheckBox_Caja_EgreIngr.Checked = True
            CheckBox_caja_cierrecaja.Checked = True
            CheckBox_Caja_Consulta.Checked = True

        Else
            CheckBox_caja_cierrecaja.Checked = False
            CheckBox_Caja_EgreIngr.Checked = False
            CheckBox_Caja_Consulta.Checked = False

        End If
    End Sub

#End Region

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If cb_tipous.SelectedValue = 1 Or cb_tipous.SelectedValue = 2 Then 'EN LA BD 1 ES ADMINISTRADOR Y 2 ES OPERADOR
            'If cb_tipous.SelectedValue = 30 Then
            MessageBox.Show("Lo Sentimos no puede eliminar este tipo de usuario", "Sistema de Gestión")
        Else
            Dim result As Integer = MessageBox.Show("¿Esta Seguro que desae Guardar los Datos?", "Sistema de Gestión", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Dim guardado = 0
                'Elimino todo de la BD
                dausuario.UsuarioModulos_eliminar(cb_tipous.SelectedValue)

                '________Cliente________''''''
                If CheckBox_Cli_todos.Checked = True Then
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Cliente_Nuevo")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Cliente_Informe")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Cliente_Actulizar")
                    guardado = 1
                Else
                    If CheckBox_cli_nuevo.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Cliente_Nuevo")
                        guardado = 1
                    End If
                    If CheckBox_cli_informe.Checked = True Then
                        guardado = 1
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Cliente_Informe")
                    End If
                    If CheckBox_cli_Actualizar.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Cliente_Actulizar")
                        guardado = 1
                    End If
                End If
                '______________FIN CLIENTE_____________

                '__________Stock_______________
                If CheckBox_stock_todos.Checked = True Then
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Proveedor_Nuevo")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Proveedor_Actualizar")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Categoria")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Producto_Nuevo")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Producto_Actualizar")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Gestion_Mercaderia")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Consulta_Movimiento")
                    guardado = 1
                Else

                    'Proveedores___________
                    If TreeView_Prov.Nodes(0).Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Proveedor_Nuevo")
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Proveedor_Actualizar")
                        guardado = 1
                    Else
                        If TreeView_Prov.Nodes(0).Nodes(0).Checked = True Then
                            dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Proveedor_Nuevo")
                            guardado = 1
                        End If
                        If TreeView_Prov.Nodes(0).Nodes(1).Checked = True Then
                            dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Proveedor_Actualizar")
                            guardado = 1
                        End If
                    End If
                    'Productos_________
                    If TreeView_prod.Nodes(0).Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Producto_Nuevo")
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Producto_Actualizar")
                        guardado = 1
                    Else
                        If TreeView_prod.Nodes(0).Nodes(0).Checked = True Then
                            dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Producto_Nuevo")
                            guardado = 1
                        End If
                        If TreeView_Prov.Nodes(0).Nodes(1).Checked = True Then
                            dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Producto_Actualizar")
                            guardado = 1
                        End If
                    End If

                    'Categoria__________
                    If CheckBox_stock_Cat.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Categoria")
                        guardado = 1
                    End If

                    'Gestion Mercaderia___________
                    If CheckBox_stock_GM.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Gestion_Mercaderia")
                        guardado = 1
                    End If

                    'Consulta de Movimiento________________
                    If CheckBox_Stock_Cons_Mov.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Stock_Consulta_Movimiento")
                        guardado = 1
                    End If

                End If
                '___________FIN STOCK__________________


                '__________Ventas________________
                If CheckBox_venta_todos.Checked = True Then
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Venta_Caja")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Venta_Consulta")
                    guardado = 1
                Else
                    If CheckBox_venta_ventCaja.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Venta_Caja")
                        guardado = 1
                    End If
                    If CheckBox_venta_consulta.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Venta_Consulta")
                        guardado = 1
                    End If
                End If
                '________FIN Ventas__________

                '______Pedidos_________
                If CheckBox_pedidos_todos.Checked = True Then
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Pedidos_Nuevo")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Pedidos_Consulta")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Pedidos_Recepcion")
                    guardado = 1
                Else
                    If CheckBox_pedidos_nuevo.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Pedidos_Nuevo")
                        guardado = 1
                    End If
                    If CheckBox_Pedidos_cons.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Pedidos_Consulta")
                        guardado = 1
                    End If
                    If CheckBox_pedidos_recepcion.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Pedidos_Recepcion")
                        guardado = 1
                    End If
                End If
                '__________FIN Pedidos_____

                '______Servicios_______
                If CheckBox_Servicio_todos.Checked = True Then
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Servicio_Nuevo")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Servicio_Consulta")
                    guardado = 1
                Else
                    If CheckBox_servicio_nuevo.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Servicio_Nuevo")
                        guardado = 1
                    End If
                    If CheckBox_servicio_consulta.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Servicio_Consulta")
                        guardado = 1
                    End If
                End If
                '___FIN SERVICIOS__________

                '___Configuraciones_______
                If CheckBox_conf_todos.Checked = True Then
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Usuario_Nuevo")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Usuario_Actualizar")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Usuario_Permisos")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Sucursal")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Empresa")
                    guardado = 1
                Else
                    'Usuarios_________
                    If TreeView_conf.Nodes(0).Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Usuario_Nuevo")
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Usuario_Actualizar")
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Usuario_Permisos")
                        guardado = 1
                    Else
                        If TreeView_conf.Nodes(0).Nodes(0).Checked = True Then
                            dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Usuario_Nuevo")
                            guardado = 1
                        End If
                        If TreeView_conf.Nodes(0).Nodes(1).Checked = True Then
                            dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Usuario_Actualizar")
                            guardado = 1
                        End If
                        If TreeView_conf.Nodes(0).Nodes(2).Checked = True Then
                            dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Usuario_Permisos")
                            guardado = 1
                        End If

                    End If
                    'fin Usuarios__________

                    If CheckBox_conf_sucursal.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Sucursal")
                        guardado = 1
                    End If

                    If CheckBox_conf_sucursal.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Configuracion_Empresa")
                        guardado = 1
                    End If

                End If
                '___________FIN CONFIG___________

                '______Caja_______
                If CheckBox_caja_Todos.Checked = True Then
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Caja_CiereCaja")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Caja_EgreIngr")
                    dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Caja_Consulta")
                    guardado = 1
                Else
                    If CheckBox_caja_cierrecaja.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Caja_CiereCaja")
                        guardado = 1
                    End If
                    If CheckBox_Caja_EgreIngr.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Caja_EgreIngr")
                        guardado = 1
                    End If
                    If CheckBox_Caja_Consulta.Checked = True Then
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, "Caja_Consulta")
                        guardado = 1
                    End If


                End If
                '___FIN CAJA__________

                If guardado = 1 Then
                    MessageBox.Show("Los datos fueron guardados correctamente", "Sistema de Gestión.")
                Else
                    Dim i = 0
                    While i < DS_Modulos.Tables(0).Rows.Count
                        dausuario.UsuarioModulos_alta(cb_tipous.SelectedValue, DS_Modulos.Tables(0).Rows(i).Item("USUModulos_descripcion"))
                        i = i + 1
                    End While
                    Cargar_Perfil()
                    MessageBox.Show("Debe Seleccionar al Menos una opcion", "Sistema de Gestión.")
                End If
            End If

        End If

    End Sub

    
    Private Sub cb_tipous_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_tipous.SelectedIndexChanged
        'Permisos()
        Cargar_Perfil()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Blanquear_Check()
    End Sub

    Private Sub btn_Agregar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Prod.Click
        TiposUsuarios_Gestion.Close()
        TiposUsuarios_Gestion.Show()
    End Sub

    
End Class