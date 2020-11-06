Public Class Servicio_nuevo
    Dim DAprod As New Datos.Producto
    Dim DAcaja As New Datos.Caja
    Dim ds_PROD As DataSet
    Dim validaciones As New Validaciones
    Dim DAservicio As New Datos.Servicio
    Dim DAventa As New Datos.Venta
    Dim usuario_id As String
    Dim sucursal_id As Integer
    Dim DAsucursal As New Datos.Sucursal
    Dim Mensaje As String
    Public Cliente_ID As Integer
    Public serv_id As Integer 'este campo me lo mandan desde "servicio_consulta" o bien desde "orden_revision_nueva"





    Private Sub Servicio_nuevo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then 'F1
            Busqueda_Productos.form_procedencia = "Servicio_nuevo"
            Busqueda_Productos.Show()
        End If
    End Sub

    Private Sub Servicio_nuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Show()
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        sucursal_id = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
        'ComboBox1.SelectedIndex = 1

        txt_equipo.Focus()
        txt_equipo.SelectAll()
        If serv_id = 0 Then 'es una alta
            Button_finalizar.Enabled = False
            Label_Estado.Visible = False
            Generar_cod_interno()
        Else
            Cargar_Datos()
            Button1.Enabled = False 'no quiero que se cambie el cliente
        End If

        GroupBox1.Text = "Orden de Servicio N°" + " " + Label_Cod.Text 'aqui tengo que colocar otro numero, que lo voy a generar automaticamente
    End Sub
    Public anticipo_recuperado As Decimal = 0
    Private Sub Cargar_Datos()
        Dim Ds_servicio As DataSet = DAservicio.Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA(serv_id)
        Dim i As Integer = 0
        Dim index As Integer = 1
        While i < Ds_servicio.Tables(0).Rows.Count
            Label_Cod.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_id").ToString
            Cliente_ID = Ds_servicio.Tables(0).Rows(i).Item("CLI_id").ToString
            TextBox_Nombre.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_Fan").ToString
            TextBox_dni.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_dni").ToString
            TextBox_dir.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_dir").ToString
            TextBox_tel.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_tel").ToString
            txt_equipo.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Equipo").ToString
            txt_sucursal.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Sucursal").ToString
            txt_diag.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Diagnostico").ToString
            DateTimePicker_REP.Value = Ds_servicio.Tables(0).Rows(i).Item("Servicio_FechaRep")
            DateTimePicker_Rev.Value = Ds_servicio.Tables(0).Rows(i).Item("Servicio_FechaRev")
            DateTimePicker1.Value = Ds_servicio.Tables(0).Rows(i).Item("Servicio_FechaRev")
            'txt_Frev.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_imei").ToString
            
            ' txt_Frep.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Color").ToString
            ' ComboBox1.SelectedValue = Ds_servicio.Tables(0).Rows(i).Item("Servicio_bat").ToString

            ' TextBox_ManoO.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_ManoObra").ToString
            TextBox_Anticipo.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Anticipo").ToString
            anticipo_recuperado = CDec(Ds_servicio.Tables(0).Rows(i).Item("Servicio_Anticipo").ToString)
            'TextBox_Nombre.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Nombre").ToString
           
            Label_Estado.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Estado").ToString
            Label_Estado.Visible = True
            i = i + 1
            index = index + 1
        End While

        ''''Cargo Productos del Servicio"""" USO TABLES(1)
        Servicio_DS.Tables("Servicio_Prod_DS").Clear()
        DataGridView1.DataSource = Nothing
        Servicio_DS.Tables("Servicio_Prod_DS").Merge(Ds_servicio.Tables(1))


        DataGridView1.DataSource = Ds_servicio.Tables(1)
        i = 0
        '' 'While i < Ds_servicio.Tables(1).Rows.Count
        '    DataGridView1.Rows.Add()
        '    DataGridView1.Rows(i).Cells("Cod_prod").Value = Ds_servicio.Tables(1).Rows(i).Item("prod_codinterno").ToString
        '    DataGridView1.Rows(i).Cells("Descripcion").Value = Ds_servicio.Tables(1).Rows(i).Item("prod_descripcion").ToString
        '    DataGridView1.Rows(i).Cells("Cantidad").Value = Ds_servicio.Tables(1).Rows(i).Item("Servicio_Producto_Cantidad").ToString
        '    DataGridView1.Rows(i).Cells("Costo").Value = Ds_servicio.Tables(1).Rows(i).Item("Servicio_Producto_Costo").ToString
        '    DataGridView1.Rows(i).Cells("Stock").Value = Ds_servicio.Tables(1).Rows(i).Item("ProdxSuc_stock").ToString
        '    i = i + 1
        'End While

        Calcular_Totales()


        Bloquar_grupBox(Label_Estado.Text)

    End Sub
    Private Sub Bloquar_grupBox(ByVal Estado As String)
        If Estado = "FINALIZADO" Or Estado = "ANULADO" Then
            'GroupBox2.Enabled = False
            'GroupBox3.Enabled = False
            'GroupBox4.Enabled = False
            'GroupBox5.Enabled = False
            'GroupBox6.Enabled = False

            TextBox_Anticipo.ReadOnly = True
            ' txt_Frep.ReadOnly = True
            TextBox_dir.ReadOnly = True
            TextBox_dni.ReadOnly = True
            '  txt_Frev.ReadOnly = True
            ' TextBox_ManoO.ReadOnly = True
            txt_equipo.ReadOnly = True
            txt_sucursal.ReadOnly = True
            TextBox_Nombre.ReadOnly = True
            txt_diag.ReadOnly = True
            TextBox_Repuesto.ReadOnly = True
            TextBox_tel.ReadOnly = True
            TextBox_codprod.ReadOnly = True
            '  ComboBox1.Enabled = False
            DataGridView1.ReadOnly = True
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            TextBox_Anticipo.BackColor = Color.FromArgb(255, 255, 192)
            '  txt_Frep.BackColor = Color.FromArgb(255, 255, 192)
            TextBox_dir.BackColor = Color.FromArgb(255, 255, 192)
            TextBox_dni.BackColor = Color.FromArgb(255, 255, 192)
            ' txt_Frev.BackColor = Color.FromArgb(255, 255, 192)
            '  TextBox_ManoO.BackColor = Color.FromArgb(255, 255, 192)
            txt_equipo.BackColor = Color.FromArgb(255, 255, 192)
            txt_sucursal.BackColor = Color.FromArgb(255, 255, 192)
            TextBox_Nombre.BackColor = Color.FromArgb(255, 255, 192)
            txt_diag.BackColor = Color.FromArgb(255, 255, 192)
            TextBox_Repuesto.BackColor = Color.FromArgb(255, 255, 192)
            TextBox_tel.BackColor = Color.FromArgb(255, 255, 192)
            TextBox_codprod.BackColor = Color.FromArgb(255, 255, 192)
            'ComboBox1.Enabled = False


            btn_guardar.Enabled = False
            Button_finalizar.Enabled = False
            btn_cancelar.Text = "Salir"
            If Estado = "FINALIZADO" Then
                Label_Estado.ForeColor = Color.Green
            End If
        End If
    End Sub
    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAservicio.Servicio_validar
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            Label_Cod.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item(0) + 1
        Else
            Label_Cod.Text = "1"
        End If
    End Sub

    Private Sub Calcular_Totales()
        Dim repuesto As Decimal = 0
        Dim total As Decimal = 0
        Dim anticipo As Decimal = 0
        Dim filas = DataGridView1.RowCount
        If filas <> 0 Then
            If Not IsDBNull(DataGridView1.CurrentRow.Cells("Cod_prod").Value) Then
                For Each row As DataGridViewRow In DataGridView1.Rows

                    row.Cells("subtotal").Value = row.Cells("Cantidad").Value * row.Cells("Costo").Value
                    repuesto = repuesto + (row.Cells("Cantidad").Value * row.Cells("Costo").Value)

                Next
            End If
        End If

        TextBox_Repuesto.Text = (Math.Round(CDec(repuesto), 2).ToString("N2"))

        If TextBox_Repuesto.Text <> "" And TextBox_Anticipo.Text <> "" Then

            total = repuesto - CDec(TextBox_Anticipo.Text)

        End If



        TextBox_TOTAL.Text = (Math.Round(CDec(total), 2).ToString("N2"))



    End Sub

    Private Sub TextBox_codprod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_codprod.KeyPress
        validaciones.Restricciones_textbox(e, "Entero", TextBox_codprod)



        If e.KeyChar = ChrW(Keys.Enter) And e.Handled = False Then



            ds_PROD = DAprod.Producto_x_sucursal_buscarcod(TextBox_codprod.Text, sucursal_id)
            If ds_PROD.Tables(0).Rows.Count <> 0 Then


                Dim item As Integer
                If Servicio_DS.Tables("Servicio_Prod_DS").Rows.Count = 0 Then
                    item = 1
                Else
                    item = Servicio_DS.Tables("Servicio_Prod_DS").Rows.Count + 1
                End If

                Dim newCustomersRow As DataRow = Servicio_DS.Tables("Servicio_Prod_DS").NewRow()
                newCustomersRow("Num") = item
                newCustomersRow("Cod_prod") = TextBox_codprod.Text
                newCustomersRow("Descripcion") = ds_PROD.Tables(0).Rows(0).Item("prod_descripcion")
                newCustomersRow("Cantidad") = "1"
                newCustomersRow("Costo") = ds_PROD.Tables(0).Rows(0).Item("prod_precio_vta")
                newCustomersRow("Stock") = ds_PROD.Tables(0).Rows(0).Item("ProdxSuc_stock")
                newCustomersRow("ProdxSuc_ID") = ds_PROD.Tables(0).Rows(0).Item("ProdxSuc_ID")
                Servicio_DS.Tables("Servicio_Prod_DS").Rows.Add(newCustomersRow)
                DataGridView1.DataSource = Servicio_DS.Tables("Servicio_Prod_DS")


            Else
                MessageBox.Show("El producto no existe", "Sistema de Gestion.")
            End If

            Calcular_Totales()


        End If
    End Sub




    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If DataGridView1.CurrentCell.ColumnIndex = 4 Then 'la columna 4 es Cantidad
            If IsDBNull(DataGridView1.CurrentRow.Cells(4).Value) Then
                DataGridView1.CurrentRow.Cells(4).Value = 1
            Else
                If DataGridView1.CurrentRow.Cells(4).Value = 0 Then
                    DataGridView1.CurrentRow.Cells(4).Value = 1
                End If
            End If
            Calcular_Totales()
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 5 Then 'la columna 5 es Precio
            If IsDBNull(DataGridView1.CurrentRow.Cells(5).Value) Then
                DataGridView1.CurrentRow.Cells(5).Value = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                'Dim precio As Decimal = DataGridView1.CurrentRow.Cells(5).Value
                'DataGridView1.CurrentRow.Cells(5).Value = (Math.Round(precio, 2).ToString("N2"))
            End If
            Calcular_Totales()
        End If

    End Sub

    Private Sub TextBox_ManoO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        '   TextBox_ManoO.SelectAll()
        '  TextBox_ManoO.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_ManoO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'validaciones.Restricciones_textbox(e, "Decimal", TextBox_ManoO)
        'If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER calcula
        '    If TextBox_ManoO.Text = "" Then
        '        TextBox_ManoO.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        '    Else
        '        TextBox_ManoO.Text = (Math.Round(CDec(TextBox_ManoO.Text), 2).ToString("N2"))
        '    End If
        '    Calcular_Totales()
        'End If
    End Sub

    Private Sub TextBox_ManoO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'hago esto x que pueden dejar vacio el textbox y revienta el calculo
        'If TextBox_ManoO.Text = "" Then
        '    TextBox_ManoO.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        'Else
        '    TextBox_ManoO.Text = (Math.Round(CDec(TextBox_ManoO.Text), 2).ToString("N2"))
        'End If
        'Calcular_Totales()
        'TextBox_ManoO.BackColor = Color.White
    End Sub

    Private Sub TextBox_Anticipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Anticipo.KeyPress
        validaciones.Restricciones_textbox(e, "Decimal", TextBox_Anticipo)
        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER calcula
            If TextBox_Anticipo.Text = "" Then
                TextBox_Anticipo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                TextBox_Anticipo.Text = (Math.Round(CDec(TextBox_Anticipo.Text), 2).ToString("N2"))
            End If
            Calcular_Totales()
        End If
    End Sub
    Private Sub TextBox_Anticipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Anticipo.LostFocus
        If TextBox_Anticipo.Text = "" Then
            TextBox_Anticipo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            TextBox_Anticipo.Text = (Math.Round(CDec(TextBox_Anticipo.Text), 2).ToString("N2"))
        End If
        Calcular_Totales()
        TextBox_Anticipo.BackColor = Color.White
    End Sub
    Dim servicio_id_recuperado As Integer = 0
    'Dim procedencia As String = ""
    Public Sub Guardar_BD(ByVal form_de_donde_vengo As String)

        If txt_equipo.Text <> "" And txt_sucursal.Text <> "" And txt_diag.Text <> "" And TextBox_Nombre.Text <> "" Then
            If serv_id = 0 Then 'es alta
                ''Alta'''
                Dim ds_SevicioGuardar As DataSet = DAservicio.Servicio_alta_MDA(Cliente_ID, DateTimePicker1.Value,
                                                                                sucursal_id, usuario_id, txt_diag.Text, txt_sucursal.Text,
                                                                                txt_equipo.Text, DateTimePicker_REP.Value, DateTimePicker_Rev.Value,
                                                                                TextBox_Anticipo.Text, "PENDIENTE")


                ''Detalle''''
                If Servicio_DS.Tables("Servicio_Prod_DS").Rows.Count <> 0 Then


                    Dim Servicio_ID As Integer = ds_SevicioGuardar.Tables(0).Rows(0).Item(0)
                    servicio_id_recuperado = ds_SevicioGuardar.Tables(0).Rows(0).Item(0)
                    Dim i As Integer = 0
                    While i < Servicio_DS.Tables("Servicio_Prod_DS").Rows.Count
                        DAservicio.Servicio_Producto_Alta_DetalleServicio(Servicio_ID,
                                                                          Servicio_DS.Tables("Servicio_Prod_DS").Rows(i).Item("ProdxSuc_ID"),
                                                                          Servicio_DS.Tables("Servicio_Prod_DS").Rows(i).Item("Costo"),
                                                                          Servicio_DS.Tables("Servicio_Prod_DS").Rows(i).Item("Cantidad"),
                                                                          Servicio_DS.Tables("Servicio_Prod_DS").Rows(i).Item("subtotal"))
                        i = i + 1

                    End While
                End If

                DAservicio.Actividad_Servicio_alta(usuario_id, sucursal_id, Label_Cod.Text, Now, "NUEVO SERVICIO")



                '/////////////CAJA/////////////////ME FIJO SI AGREGO O NO EL ANTICIPO
                If form_de_donde_vengo = "boton_guardar_cambios" Then
                    If CDec(TextBox_Anticipo.Text) <> CDec(0) Then ' si me dejaron mas plata hacer la diferencia
                        Dim anticipo_diferencias As Decimal = CDec(TextBox_Anticipo.Text) - anticipo_recuperado
                        If anticipo_diferencias <= 0 Then

                        Else
                            Dim descripcion As String = "Servicio Nº" + CStr(Label_Cod.Text) + ", anticipo"
                            'OK
                            DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(anticipo_diferencias), CDec(0), 1, CDec(0), CDec(anticipo_diferencias), Now, Inicio.terminal_id, US_administrador.TurnoUsuario_id) '1 es efectivo
                        End If
                    End If
                End If

                MessageBox.Show("Servicio Guardado correctamente", "Sistema de Gestion.")

                Me.Close()


            Else
                ''Actualizacion Servicio'''''
                Dim ds_SevicioActualizar As DataSet = DAservicio.Servicio_Modificar_MDA(Cliente_ID, DateTimePicker1.Value,
                                                                                sucursal_id, usuario_id, txt_diag.Text, txt_sucursal.Text,
                                                                               txt_equipo.Text, DateTimePicker_Rev.Value, DateTimePicker_REP.Value,
                                                                               TextBox_Anticipo.Text,
                                                                            serv_id)



                ''Actualizo Detalle''''
                If DataGridView1.Rows.Count <> 0 Then
                    Dim i As Integer = 0
                    While i < DataGridView1.Rows.Count
                        DAservicio.Servicio_Producto_Alta_DetalleServicio(serv_id,
                                                                         DataGridView1.Rows(i).Cells("ProdxSuc_ID").Value,
                                                                           DataGridView1.Rows(i).Cells("Costo").Value,
                                                                          DataGridView1.Rows(i).Cells("Cantidad").Value,
                                                                          DataGridView1.Rows(i).Cells("subtotal").Value)
                        i = i + 1



                        ' DataGridView1.Rows(i).Cells("Cod_prod").Value = Ds_servicio.Tables(1).Rows(i).Item("prod_codinterno").ToString
                        '    DataGridView1.Rows(i).Cells("Descripcion").Value = Ds_servicio.Tables(1).Rows(i).Item("prod_descripcion").ToString
                        '    DataGridView1.Rows(i).Cells("Cantidad").Value = Ds_servicio.Tables(1).Rows(i).Item("Servicio_Producto_Cantidad").ToString
                        '    DataGridView1.Rows(i).Cells("Costo").Value = Ds_servicio.Tables(1).Rows(i).Item("Servicio_Producto_Costo").ToString
                        '    DataGridView1.Rows(i).Cells("Stock").Value = Ds_servicio.Tables(1).Rows(i).Item("ProdxSuc_stock").ToString

                    End While

                End If

                '/////////////CAJA/////////////////ME FIJO SI AGREGO O NO EL ANTICIPO
                If form_de_donde_vengo = "boton_guardar_cambios" Then
                    If CDec(TextBox_Anticipo.Text) <> CDec(0) Then ' si me dejaron mas plata hacer la diferencia
                        Dim anticipo_diferencias As Decimal = CDec(TextBox_Anticipo.Text) - anticipo_recuperado
                        If anticipo_diferencias <= 0 Then

                        Else
                            Dim descripcion As String = "Servicio Nº" + CStr(Label_Cod.Text) + ", anticipo"
                            'OK
                            DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(anticipo_diferencias), CDec(0), 1, CDec(0), CDec(anticipo_diferencias), Now, Inicio.terminal_id, US_administrador.TurnoUsuario_id) '1 es efectivo
                        End If
                    End If
                End If




                If Mensaje = "finalizar" Then


                Else
                    DAservicio.Actividad_Servicio_alta(usuario_id, sucursal_id, Label_Cod.Text, Now, "SERVICIO MODIFICADO")
                    MessageBox.Show("Servicio Actualizado correctamente", "Sistema de Gestión.")
                    Servicio_Consulta.Close()
                    Servicio_Consulta.Show()
                    Me.Close()
                End If

            End If

        Else
            MessageBox.Show("Debe Completar los campos Obligatorios", "Sistema de Gestion.")
            lbl_errNOM.Visible = True
            lb_error_marca.Visible = True
            lb_error_modelo.Visible = True
            lb_error_nombre.Visible = True
            ' lb_error_observacion.Visible = True
        End If
    End Sub
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        'procedencia = "boton_guardar_cambios" 'lo necesito para q no se cierre la rutina GUARDAR_BD
        Guardar_BD("boton_guardar_cambios")
        'If Servicio_Consulta.serv_id = 0 Then
        '    If CDec(TextBox_Anticipo.Text) <> CDec(0) Then
        '        Dim descripcion As String = "Servicio Nº" + CStr(servicio_id_recuperado) + ", anticipo"
        '        DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(TextBox_Anticipo.Text), CDec(0), 2, CDec(0), CDec(TextBox_Anticipo.Text)) '2 es ingreso
        '    End If
        'Else
        '    If CDec(TextBox_Anticipo.Text) <> CDec(0) Then ' si me dejaron mas plata hacer la diferencia
        '        Dim anticipo_diferencias As Decimal = CDec(TextBox_Anticipo.Text) - anticipo_recuperado
        '        If anticipo_diferencias <= 0 Then

        '        Else
        '            Dim descripcion As String = "Servicio Nº" + CStr(Label_Cod.Text) + ", anticipo"
        '            DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(anticipo_diferencias), CDec(0), 2, CDec(0), CDec(anticipo_diferencias)) '2 es ingreso
        '        End If
        '    End If
        'End If

        'Me.Close()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DataGridView1.Rows.Count <> 0 Then

            Dim result As DialogResult
            result = MessageBox.Show("¿Desea quitar todos los productos del listado?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Servicio_DS.Tables("Servicio_Prod_DS").Rows.Clear()
                DataGridView1.DataSource = Nothing
                Calcular_Totales()
            End If
        Else
            MessageBox.Show("No hay productos en el listado", "Sistema de Gestión")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        If Servicio_Consulta.serv_id = 0 Then
            Me.Close()
        Else
            Servicio_Consulta.Close()
            Servicio_Consulta.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Actualizar_Stock()
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        sucursal_id = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")

        Dim Ds_Suc As DataSet
        Dim Calculo As Integer
        Dim j As Integer = 0


        While j < DataGridView1.Rows.Count
            If DataGridView1.Rows(j).Cells("Cod_prod").Value <> 0 Then


                Dim cant As Integer = DataGridView1.Rows(j).Cells("Cantidad").Value

                ds_PROD = DAprod.Producto_buscarcod(DataGridView1.Rows(j).Cells("Cod_prod").Value)
                Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id)

                'Calculo Stock''''''''
                Calculo = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - DataGridView1.Rows(j).Cells("Cantidad").Value
                ''''''''''
                'Actualizo stock'''''
                DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, Calculo)

            End If

            j = j + 1

        End While
    End Sub

    Private Sub Button_finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_finalizar.Click
        If txt_equipo.Text <> "" And txt_sucursal.Text <> "" And txt_diag.Text <> "" Then
            Dim result As Integer = MessageBox.Show("¿Está seguro que desea finalizar el Servicio? No podrá realizar más cambios en el mismo.", "Sistema de Gestión", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim sin_anticipo As Decimal = CDec((Math.Round(CDec(TextBox_TOTAL.Text), 2).ToString("N2"))) + CDec((Math.Round(CDec(TextBox_Anticipo.Text), 2).ToString("N2")))
                If CDec(TextBox_TOTAL.Text) <> CDec(0) Then
                    Mensaje = "finalizar"
                    Pago_caja.form_procedencia = "Servicio_nuevo"
                    Pago_caja.tx_total.Text = TextBox_TOTAL.Text
                    Pago_caja.Ser_id = Label_Cod.Text
                    Pago_caja.Monto_sin_anticipo = CDec((Math.Round(CDec(TextBox_TOTAL.Text), 2).ToString("N2"))) + CDec((Math.Round(CDec(TextBox_Anticipo.Text), 2).ToString("N2")))
                    Pago_caja.Show()
                Else
                    Mensaje = "finalizar"
                    'GUARDAR EN TABLA "Venta_Producto"///////////////////////////////////////////////////////////////////////////////////
                    Dim usuario_id As String
                    usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
                    Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
                    Dim sucursal_id As Integer = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
                    Dim tipo_vta As String = ""
                    Dim cliente_id As Integer
                    Dim venta_tipo_descripcion As String = ""
                    tipo_vta = "Consumidor Final"
                    cliente_id = 0
                    venta_tipo_descripcion = "Servicio"
                    Dim vendedor_id As Integer = 0 'ojo pongo esto, porque no defino vendedores, se puede poner un combo con los vendedores para elegir, si no hay cargar uno por Defecto en la BD. 
                    Dim ds_Venta As DataSet = DAventa.VentaProducto_alta(sin_anticipo, Now, usuario_id, tipo_vta, cliente_id, 0, 0, 0, 0, 0, venta_tipo_descripcion, Label_Cod.Text, vendedor_id, "Cobrado")
                    'NO SE ACTUALIZA EN CAJA
                    'Me.Close()
                    finalizar("boton_guardar_cambios")
                End If
            End If
        Else
            MessageBox.Show("Debe Completar los campos Obligatorios", "Sistema de Gestion.")

            lb_error_marca.Visible = True
            lb_error_modelo.Visible = True
            lb_error_nombre.Visible = True
        End If
    End Sub

    Public Sub finalizar(ByVal procendencia As String)
        Actualizar_Stock()
        DAservicio.Servicio_ActualizarEstado(Servicio_Consulta.serv_id, "FINALIZADO")
        Guardar_BD(procendencia.ToString)
        DAservicio.Actividad_Servicio_alta(usuario_id, sucursal_id, Label_Cod.Text, Now, "SERVICIO FINALIZADO")
        MessageBox.Show("Venta registrada y Servicio finalizado correctamente.", "Sistema de Gestion.")
        Servicio_Consulta.Close()
        Servicio_Consulta.Show()
        Me.Close()


    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        Dim validar As TextBox = CType(e.Control, TextBox)
        AddHandler validar.KeyPress, AddressOf validar_Keypress




    End Sub

    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsDBNull(DataGridView1.CurrentRow.Cells("Cod_prod").Value) Then


            Dim columna As Integer = DataGridView1.CurrentCell.ColumnIndex
            Dim caracter As Char = e.KeyChar
            Dim txt As TextBox = CType(sender, TextBox)

            If columna = 5 Then 'es la columna de precio
                If e.KeyChar.ToString() = "." Then
                    e.KeyChar = ","
                End If


                If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or _
              (caracter = ",") And (txt.Text.Contains(",") = False) Then

                    e.Handled = False
                Else
                    e.Handled = True
                End If

            End If

            If columna = 4 Then 'es la columna de cantidad
                'aqui valido que solo sea numero
                If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
                '-------------------------------------------------------
            End If
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub TextBox_dni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_dni.KeyPress
        validaciones.Restricciones_textbox(e, "Entero", TextBox_dni)

    End Sub
    Private Sub btn_eliminar_seleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_seleccion.Click
        ''aqui elemino el producto seleccionado de la tabla y recalculo el valor de los totales

        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.

        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        If MsgBox("Esta seguro que quiere quitar el item seleccionado?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                            pregunta = "si"
                        Else
                            'aqui corto el ciclo, ya que se cancelo la eliminacion
                            i = DataGridView1.Rows.Count
                        End If
                    End If
                    If pregunta = "si" Then
                        'primero guardo el nro de item q contiene
                        Dim item As Decimal = DataGridView1.CurrentRow.Index
                        DataGridView1.Rows.RemoveAt(i)
                        i = 0 'lo reinicio, x q al quitar un ite, se reordenan los indices

                        'If item <= Venta_Caja_ds.Tables("Producto_agregado").Rows.Count Then 'esta validacion es x q el ds tiene menos celdas 
                        '    Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Delete()
                        'End If

                        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                        'cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
                        'Dim a As Integer = 0
                        'While a < DataGridView1.Rows.Count
                        '    If DataGridView1.Rows(a).Cells(1).Value <> 0 Then
                        '        DataGridView1.Rows(a).Cells(0).Value = a + 1
                        '    End If

                        '    a = a + 1
                        'End While
                        Calcular_Totales()
                        'aplicar_iva()
                    End If
                Else
                    i = i + 1
                End If

            End While
        End If
    End Sub


    Private Sub TextBox_Marca_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_equipo.GotFocus
        txt_equipo.SelectAll()
        txt_equipo.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_Marca_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_equipo.LostFocus
        txt_equipo.BackColor = Color.White
    End Sub

    Private Sub TextBox_Modelo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sucursal.GotFocus
        txt_sucursal.SelectAll()
        txt_sucursal.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_Modelo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sucursal.LostFocus
        txt_sucursal.BackColor = Color.White
    End Sub

    Private Sub TextBox_color_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        '  txt_Frep.SelectAll()
        '   txt_Frep.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_color_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        '    txt_Frep.BackColor = Color.White
    End Sub

    Private Sub TextBox_id_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        '   txt_Frev.SelectAll()
        '   txt_Frev.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_id_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        '  txt_Frev.BackColor = Color.White
    End Sub

    Private Sub ComboBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'ComboBox1.SelectAll()
        'ComboBox1.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'ComboBox1.BackColor = Color.White
    End Sub

    Private Sub TextBox_obs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_diag.GotFocus
        'TextBox_obs.SelectAll()
        txt_diag.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_obs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_diag.LostFocus
        txt_diag.BackColor = Color.White
    End Sub

    Private Sub TextBox_codprod_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_codprod.LostFocus
        TextBox_codprod.BackColor = Color.White
    End Sub

    Private Sub TextBox_codprod_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_codprod.GotFocus
        TextBox_codprod.SelectAll()
        TextBox_codprod.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_Anticipo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Anticipo.GotFocus
        TextBox_Anticipo.SelectAll()
        TextBox_Anticipo.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cliente_modificar.procedencia = "Servicios"
        Cliente_modificar.Show()

    End Sub

    
End Class