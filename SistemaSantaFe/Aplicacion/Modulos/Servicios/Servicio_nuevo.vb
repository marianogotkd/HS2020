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
    Public SucxClie_id As Integer 'este es el ID de la sucursal del cliente, que es necesaria para la facturación
    Public serv_id As Integer 'este campo me lo mandan desde "servicio_consulta" o bien desde "orden_revision_nueva"
    Dim Dacuadrillas As New Datos.Cuadrilla
    Dim ds_cuadrilla As DataSet
    Dim cuadrilla_id As Integer
    Dim combo_cuadrilla_listo As String = "no"
    Dim estado_de_orden As String
    Dim orden_trabajo_id As Integer
    Public procedencia As String 'este parametro viene del form Ordeb_trabajo_selec_cliente
    Dim guardado As String = "no"
    Private Sub recuperar_cuadrillas()

        ds_cuadrilla = Dacuadrillas.Cuadrilla_obtener_todo()

        If ds_cuadrilla.Tables(0).Rows.Count <> 0 Then
            'aqui voy a vincular la tabla a un combobox

            Combo_cuadrilla.DataSource = ds_cuadrilla.Tables(0)
            Combo_cuadrilla.DisplayMember = "Cuadrilla_descripcion"
            Combo_cuadrilla.ValueMember = "Cuadrilla_id"
            cuadrilla_id = Combo_cuadrilla.SelectedValue
            combo_cuadrilla_listo = "si" 'esto lo uso para validar
            recuperar_empleados(cuadrilla_id)


        End If


    End Sub

    Private Sub recuperar_empleados(ByVal cuad_id As Integer)
        If ds_cuadrilla.Tables(1).Rows.Count <> 0 Then
            'aqui voy cargando en el gridview los empleados
            Servicio_DS.Tables("Empleados_x_cuadrilla").Rows.Clear()
            Dim i As Integer = 0
            While i < ds_cuadrilla.Tables(1).Rows.Count
                If cuad_id = ds_cuadrilla.Tables(1).Rows(i).Item("Cuadrilla_id") Then
                    'si son iguales lo agrego
                    Dim fila As DataRow = Servicio_DS.Tables("Empleados_X_cuadrilla").NewRow
                    fila("Empleado_x_Cuadrilla_id") = ds_cuadrilla.Tables(1).Rows(i).Item("Empleado_x_Cuadrilla_id")
                    fila("empleado_id") = ds_cuadrilla.Tables(1).Rows(i).Item("empleado_id")
                    fila("Cuadrilla_id") = ds_cuadrilla.Tables(1).Rows(i).Item("Cuadrilla_id")
                    fila("apellidoynombre") = ds_cuadrilla.Tables(1).Rows(i).Item("apellidoynombre")
                    Servicio_DS.Tables("Empleados_x_cuadrilla").Rows.Add(fila)
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub Servicio_nuevo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If procedencia = "Orden_trabajo_selec_cliente" Then

            'tengo que eliminar si no se guardo
            If guardado = "si" Then
                'no hago nada
            Else
                'AQUI TENGO QUE PONER UN MENSAJE QUE DIGA, QUIERE SALIR SIN GUARDAR LA ORDEN DE TRABAJO?
                Dim result As Integer = MessageBox.Show("¿Está seguro que desea salir sin guardar los cambios?", "Sistema de Gestión", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    'como no se guardó elimino la orden de revisión que se generó en segundo plano.
                    DAservicio.Servicio_ActualizarEstado(serv_id, "ANULADO")
                    procedencia = ""
                    guardado = "no"
                    Servicio_Consulta.LOAD_FORM()
                Else
                    e.Cancel = True
                End If
            End If
        Else
            procedencia = ""
            guardado = "no"
        End If
        
    End Sub

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

        recuperar_cuadrillas() 'siempre recupero independientemente si se asigno cuadrilla o no

        If serv_id = 0 Then 'es una alta
            Button_finalizar.Enabled = False
            Label_Estado.Visible = False
            Generar_cod_interno()
        Else
            Cargar_Datos() 'tambien recupera cuadrilla asignada.
            Button1.Enabled = False 'no quiero que se cambie el cliente
        End If

        GroupBox1.Text = "Orden de Revisión N°" + " " + Label_Cod.Text 'aqui tengo que colocar otro numero, que lo voy a generar automaticamente

        txt_sucursal.ReadOnly = True 'esto no se puede cambiar x q se recupera

    End Sub
    Public anticipo_recuperado As Decimal = 0
    Private Sub Cargar_Datos()
        Dim Ds_servicio As DataSet = DAservicio.Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA(serv_id)
        Dim i As Integer = 0
        Dim index As Integer = 1
        While i < Ds_servicio.Tables(0).Rows.Count
            Label_Cod.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_id").ToString
            Cliente_ID = Ds_servicio.Tables(0).Rows(i).Item("CLI_id").ToString
            SucxClie_id = Ds_servicio.Tables(0).Rows(i).Item("SucxClie_id").ToString
            TextBox_Nombre.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_Fan").ToString
            TextBox_dni.Text = Ds_servicio.Tables(0).Rows(i).Item("CLI_dni").ToString
            TextBox_dir.Text = Ds_servicio.Tables(0).Rows(i).Item("SucxClie_dir").ToString 'esta direccion que se muestra es la de la sucursal. choco 22-12-2020
            TextBox_tel.Text = Ds_servicio.Tables(0).Rows(i).Item("SucxClie_tel").ToString 'este telefono que se muestra es de la sucursal. choco 22-12-2020
            txt_equipo.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Equipo").ToString
            txt_sucursal.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Sucursal").ToString
            txt_diag.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Diagnostico").ToString
            DateTimePicker_REP.Value = Ds_servicio.Tables(0).Rows(i).Item("Servicio_FechaRep")
            DateTimePicker_Rev.Value = Ds_servicio.Tables(0).Rows(i).Item("Servicio_FechaRev")
            DateTimePicker_Rev.Enabled = False
            DateTimePicker1.Value = Ds_servicio.Tables(0).Rows(i).Item("Servicio_FechaRev")
            'txt_Frev.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_imei").ToString
            ' txt_Frep.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Color").ToString
            ' ComboBox1.SelectedValue = Ds_servicio.Tables(0).Rows(i).Item("Servicio_bat").ToString
            ' TextBox_ManoO.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_ManoObra").ToString
            TextBox_Anticipo.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Anticipo").ToString
            anticipo_recuperado = CDec(Ds_servicio.Tables(0).Rows(i).Item("Servicio_Anticipo").ToString)
            'TextBox_Nombre.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Nombre").ToString

            'SI YA SE GENERO LA ORDEN DE TRABAJO MUESTRO LA CUADRILLA ASIGNADA
            If Ds_servicio.Tables(2).Rows.Count <> 0 Then
                Dim cuadrilla_id As Integer = Ds_servicio.Tables(2).Rows(0).Item("Cuadrilla_id")
                Combo_cuadrilla.SelectedValue = cuadrilla_id
            End If


            Label_Estado.Text = "Estado:" + Ds_servicio.Tables(0).Rows(i).Item("Servicio_Estado").ToString


            Bloquar_grupBox(Ds_servicio.Tables(0).Rows(i).Item("Servicio_Estado").ToString)


            estado_de_orden = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Estado").ToString 'lo uso para validar en los botones de guardar
            If estado_de_orden = "PENDIENTE" Then 'deshabilito los botones REPARADO Y FINALIZAR
                Button2.Enabled = False
                Button_finalizar.Enabled = False
            End If
            If estado_de_orden = "ASIGNADO" Then
                Button_finalizar.Enabled = True
                Button2.Enabled = True
            End If
            If estado_de_orden = "REPARADO" Then
                Button_finalizar.Enabled = True
                Button2.Enabled = False
                btn_guardar.Enabled = False
            End If
            If estado_de_orden = "FINALIZADO" Then
                btn_guardar.Enabled = False
                Button2.Enabled = False
                Button_finalizar.Enabled = False
            End If
            'le voy a sumar al estado el nro de orden de trabajo,
            If Ds_servicio.Tables(1).Rows.Count <> 0 Then
                Dim orden_trabajo As String = Ds_servicio.Tables(2).Rows(0).Item("Orden_trabajo_id")
                orden_trabajo_id = orden_trabajo 'esta variable la voy a usar cuando quiera reimprimir el reporte.
                Button_imprimir.Visible = True
                Label_Estado.Text = "Estado: " + Ds_servicio.Tables(0).Rows(i).Item("Servicio_Estado").ToString + " (Orden de trabajo Nº: " + orden_trabajo + ")"
                Label_Estado.ForeColor = Color.Green
            End If
            Label_Estado.Visible = True
            i = i + 1
            index = index + 1
        End While

        ''''Cargo Productos del Servicio"""" USO TABLES(1)
        Servicio_DS.Tables("Servicio_Prod_DS").Clear()
        'DataGridView1.DataSource = Nothing
        Servicio_DS.Tables("Servicio_Prod_DS").Merge(Ds_servicio.Tables(1))


        'DataGridView1.DataSource = Ds_servicio.Tables(1)
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




    End Sub
    Private Sub Bloquar_grupBox(ByVal Estado As String)
        If Estado = "FINALIZADO" Or Estado = "ANULADO" Or Estado = "REPARADO" Then
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
            TextBox_codprod.ReadOnly = True
            DateTimePicker_REP.Enabled = False
            Button3.Enabled = False
            btn_eliminar_seleccion.Enabled = False
            'btn_guardar.Enabled = False
            'Button_finalizar.Enabled = False
            'btn_cancelar.Text = "Salir"
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
                newCustomersRow("prod_id") = ds_PROD.Tables(0).Rows(0).Item("prod_id") 'choco 11-11-2020
                newCustomersRow("Cod_prod") = TextBox_codprod.Text
                newCustomersRow("Descripcion") = ds_PROD.Tables(0).Rows(0).Item("prod_descripcion")
                newCustomersRow("Cantidad") = "1"
                newCustomersRow("Costo") = ds_PROD.Tables(0).Rows(0).Item("prod_precio_vta")
                newCustomersRow("Stock") = ds_PROD.Tables(0).Rows(0).Item("ProdxSuc_stock")
                newCustomersRow("ProdxSuc_ID") = ds_PROD.Tables(0).Rows(0).Item("ProdxSuc_ID")
                Servicio_DS.Tables("Servicio_Prod_DS").Rows.Add(newCustomersRow)
                'DataGridView1.DataSource = Servicio_DS.Tables("Servicio_Prod_DS")


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

        If txt_equipo.Text <> "" And txt_sucursal.Text <> "" And txt_diag.Text <> "" And TextBox_Nombre.Text <> "" And DataGridView1.Rows.Count <> 0 Then
            If serv_id = 0 Then 'es alta
                ''Alta'''
                Dim ds_SevicioGuardar As DataSet = DAservicio.Servicio_alta_MDA(Cliente_ID, DateTimePicker1.Value,
                                                                                sucursal_id, usuario_id, txt_diag.Text, txt_sucursal.Text,
                                                                                txt_equipo.Text, DateTimePicker_REP.Value, DateTimePicker_Rev.Value,
                                                                                TextBox_Anticipo.Text, "PENDIENTE", SucxClie_id)


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
                                                                            serv_id, "ASIGNADO") 'pongo el estado en ASIGNADO

                'primero elimino el detalle
                DAservicio.Servicio_eliminar_Detalle(serv_id)
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


                'aqui genero la orden de trabajo: tengo que emitir un mensaje avisando que se generara una nueva orden de trabajo
                Dim ds_orden_trabajo As DataSet = DAservicio.Orden_trabajo_alta(serv_id, Combo_cuadrilla.SelectedValue)
                orden_trabajo_id = ds_orden_trabajo.Tables(0).Rows(0).Item("orden_trabajo_id")

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
                    DAservicio.Actividad_Servicio_alta(usuario_id, sucursal_id, Label_Cod.Text, Now, "GENERACION DE ORDEN DE TRABAJO, asignación de cuadrilla.")
                    MessageBox.Show("Orden de trabajo generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Servicio_Consulta.Close()
                    'Servicio_Consulta.Show()

                    'ahora abro el reporte
                    Dim result As Integer = MessageBox.Show("¿Desea ver el reporte de la orden de trabajo?", "Sistema de Gestión", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        reporte(orden_trabajo_id)
                    End If

                    'Tareas_Consulta.Close() NO ABRO EL CALENDARIO
                    'Tareas_Consulta.Show()
                    If procedencia = "Orden_trabajo_selec_cliente" Then
                        guardado = "si"
                    End If

                    Servicio_Consulta.LOAD_FORM() 'esto hago para actualizar el form de servicio_consulta que no se cierra

                    Me.Close()
                End If
                estado_de_orden = "ASIGNADO"


            End If

        Else
            MessageBox.Show("Debe Completar los campos Obligatorios", "Sistema de Gestion.")
            lbl_errNOM.Visible = True
            lb_error_marca.Visible = True
            lb_error_modelo.Visible = True
            lb_error_nombre.Visible = True
            Label_error_grilla.Visible = True
            ' lb_error_observacion.Visible = True
        End If
    End Sub
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If estado_de_orden <> "REPARADO" Then
            Dim result As Integer = MessageBox.Show("¿Está seguro que desea guardar los cambios y generar la ORDEN DE TRABAJO?", "Sistema de Gestión", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Guardar_BD("boton_guardar_cambios")
            End If
        Else
            MessageBox.Show("Error, no se puede realizar la operación.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'procedencia = "boton_guardar_cambios" 'lo necesito para q no se cierre la rutina GUARDAR_BD
        'Guardar_BD("boton_guardar_cambios")
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


    Dim ds_revision_reporte As New ds_revision_reporte
    Private Sub reporte(ByVal orden_trabajo_id As Integer)
        ds_revision_reporte.Tables("Revision").Rows.Clear()
        ds_revision_reporte.Tables("repuestos").Rows.Clear()

        Dim fila As DataRow = ds_revision_reporte.Tables("Revision").NewRow
        fila("id_revision") = orden_trabajo_id

        Dim ds_clie As DataSet = DAservicio.Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA(serv_id)



        fila("cliente") = TextBox_Nombre.Text + ", " + ds_clie.Tables(0).Rows(0).Item("SucxClie_nombre").ToString  'voy a agregarle datos de sucursal
        fila("direccion") = ds_clie.Tables(0).Rows(0).Item("SucxClie_dir").ToString  'esta direccion es la de la sucursal del cliente. choco 22-12-2020
        fila("fecha") = DateTimePicker_REP.Value.Date
        fila("diagnostico_previo") = txt_diag.Text
        fila("Equipo") = txt_equipo.Text
        fila("Sucursal") = txt_sucursal.Text
        ds_revision_reporte.Tables("Revision").Rows.Add(fila)

        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            Dim fila2 As DataRow = ds_revision_reporte.Tables("repuestos").NewRow
            fila2("descripcion") = DataGridView1.Rows(i).Cells("Descripcion").Value 'item
            fila2("cantidad") = DataGridView1.Rows(i).Cells("Cantidad").Value 'cantidad
            ds_revision_reporte.Tables("repuestos").Rows.Add(fila2)
            i = i + 1
        End While


        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Servicios\Reportes\CR_orden_trabajo.rpt")
        CrReport.Database.Tables("Revision").SetDataSource(ds_revision_reporte.Tables("Revision"))
        CrReport.Database.Tables("repuestos").SetDataSource(ds_revision_reporte.Tables("repuestos"))

        Dim visor As New Facturacion_report_show
        visor.CrystalReportViewer1.ReportSource = CrReport

        visor.Text = "Orden de Trabajo. Imprimir."
        visor.Show()

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
        If estado_de_orden = "PENDIENTE" Then
            MessageBox.Show("Error, debe generar la orden de trabajo para poder finalizar y cobrar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If txt_equipo.Text <> "" And txt_sucursal.Text <> "" And txt_diag.Text <> "" Then
                Dim result As Integer = MessageBox.Show("¿Está seguro que desea finalizar? No podrá realizar más cambios en el mismo.", "Sistema de Gestión", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    'AQUI VA LA VALIDACION QUE ESTE ABIERTA LA CAJA.






                    Dim sin_anticipo As Decimal = CDec((Math.Round(CDec(TextBox_TOTAL.Text), 2).ToString("N2"))) + CDec((Math.Round(CDec(TextBox_Anticipo.Text), 2).ToString("N2")))
                    If CDec(TextBox_TOTAL.Text) <> CDec(0) Then
                        Sucursales_Seleccionar.Close()
                        Sucursales_Seleccionar.cliente_id = Cliente_ID
                        Sucursales_Seleccionar.procedencia = "servicio_nuevo"
                        Sucursales_Seleccionar.Show()




                                                Mensaje = "finalizar"
                        'Pago_caja.form_procedencia = "Servicio_nuevo"
                        'Pago_caja.tx_total.Text = TextBox_TOTAL.Text
                        'Pago_caja.Ser_id = Label_Cod.Text

                        'Pago_caja.Monto_sin_anticipo = CDec((Math.Round(CDec(TextBox_TOTAL.Text), 2).ToString("N2"))) + CDec((Math.Round(CDec(TextBox_Anticipo.Text), 2).ToString("N2")))
                        'Pago_caja.Show()
                    Else
                        MessageBox.Show("ERROR, el TOTAL está en O", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        'Mensaje = "finalizar"
                        ''GUARDAR EN TABLA "Venta_Producto"///////////////////////////////////////////////////////////////////////////////////
                        'Dim usuario_id As String
                        'usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
                        'Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
                        'Dim sucursal_id As Integer = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
                        'Dim tipo_vta As String = ""
                        'Dim cliente_id As Integer
                        'Dim venta_tipo_descripcion As String = ""
                        'tipo_vta = "Consumidor Final"
                        'cliente_id = 0
                        'venta_tipo_descripcion = "Servicio"
                        'Dim vendedor_id As Integer = 0 'ojo pongo esto, porque no defino vendedores, se puede poner un combo con los vendedores para elegir, si no hay cargar uno por Defecto en la BD. 
                        'Dim ds_Venta As DataSet = DAventa.VentaProducto_alta(sin_anticipo, Now, usuario_id, tipo_vta, cliente_id, 0, 0, 0, 0, 0, venta_tipo_descripcion, Label_Cod.Text, vendedor_id, "Cobrado")
                        ''NO SE ACTUALIZA EN CAJA
                        ''Me.Close()
                        'finalizar("boton_guardar_cambios")
                    End If
                End If
            Else
                MessageBox.Show("Debe Completar los campos Obligatorios", "Sistema de Gestion.")

                lb_error_marca.Visible = True
                lb_error_modelo.Visible = True
                lb_error_nombre.Visible = True
            End If

        End If

    End Sub

    Public Sub finalizar(ByVal procendencia As String, ByVal ds_usuario As DataSet, ByVal factura_id As Integer)
        Actualizar_Stock()
        DAservicio.Servicio_ActualizarEstado(serv_id, "FINALIZADO")
        'Guardar_BD(procendencia.ToString) ESTO CREO QUE NO VA
        DAservicio.Actividad_Servicio_alta(usuario_id, sucursal_id, Label_Cod.Text, Now, "SERVICIO FINALIZADO")
        MessageBox.Show("Venta registrada y Servicio finalizado correctamente.", "Sistema de Gestion.")
        'Servicio_Consulta.Close()
        'Servicio_Consulta.Show()

        'genero el reporte con el comprobante de pago
        crear_reporte_comprobante_pago(ds_usuario, factura_id)

        'Tareas_Consulta.Close()
        'Tareas_Consulta.Show()
        Servicio_Consulta.LOAD_FORM()
        Me.Close()
    End Sub

    Dim DAcliente As New Datos.Cliente
    Dim facturacion_ds_report As New Facturacion_ds_report
    Private Sub crear_reporte_comprobante_pago(ByVal ds_usuario As DataSet, ByVal numerofactura As Integer)
        'pregunto si quiero ver el reporte 
        'Dim result As DialogResult
        'result = MessageBox.Show("¿Desea ver el comprobante de pago?", "Sistema de Gestión", MessageBoxButtons.OKCancel)
        'If result = DialogResult.OK Then
        'primero lleno el dataset y sus respectivas table

        '///////////////TABLA CLIENTE//////////////////////////////////'
        Facturacion_ds_report.Tables("Cliente").Rows.Clear()

        'Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni(TextBox_dni.Text) 'esto ya no me sirve por que ahora los datos q van en la factura vienen de la taba cliente_sucursales.
        Dim ds_cliente As DataSet = DAservicio.Servicio_Obterner_Con_Detalle_X_Servicio_id_MDA(serv_id) 'esto ya no me sirve por que ahora los datos q van en la factura vienen de la taba cliente_sucursales.
        Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
        row_cliente("fantasia") = ds_cliente.Tables(3).Rows(0).Item("CLI_Fan") + ", " + ds_cliente.Tables(3).Rows(0).Item("SucxClie_nombre")
        row_cliente("dni") = ds_cliente.Tables(3).Rows(0).Item("CLI_dni")
        row_cliente("telefono") = ds_cliente.Tables(3).Rows(0).Item("SucxClie_tel")
        row_cliente("mail") = ds_cliente.Tables(3).Rows(0).Item("SucxClie_mail")
        row_cliente("direccion") = ds_cliente.Tables(3).Rows(0).Item("SucxClie_dir")
        row_cliente("localidad") = ds_cliente.Tables(3).Rows(0).Item("provincia") + ", " + ds_cliente.Tables(3).Rows(0).Item("Localidad")
        row_cliente("iva_condicion") = ds_cliente.Tables(3).Rows(0).Item("IVA_Descripcion").ToString
        facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)

        '///////////////TABLA SUCURSAL//////////////////////////////////'
        Facturacion_ds_report.Tables("Sucursal").Rows.Clear()
        Dim row_sucursal As DataRow = Facturacion_ds_report.Tables("Sucursal").NewRow()
        row_sucursal("sucursal") = Venta_Caja_gestion.lb_nombre_sucursal.Text
        row_sucursal("direccion") = Venta_Caja_gestion.lb_direccion_sucursal.Text
        row_sucursal("telefono") = Venta_Caja_gestion.lb_telefono_sucursal.Text
        row_sucursal("mail") = Venta_Caja_gestion.lb_mail_sucursal.Text
        row_sucursal("cuit") = "20 - 00000000 - 4"
        Facturacion_ds_report.Tables("Sucursal").Rows.Add(row_sucursal)

        '///////////////TABLA EMPRESA//////////////////////////////////'
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            Facturacion_ds_report.Tables("Empresa").Rows.Clear()
            Facturacion_ds_report.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If

        '///////////////TABLA VENTA//////////////////////////////////'
        Facturacion_ds_report.Tables("venta").Rows.Clear()
        Dim row_venta As DataRow = Facturacion_ds_report.Tables("venta").NewRow()
        'row_venta("nro_factura") = Venta_Caja_gestion.lb_factura_vta.Text
        'row_venta("nro_factura") = ventaprod_id
        row_venta("nro_factura") = CInt(numerofactura)
        row_venta("fecha") = Today 'CDate(Venta_Caja_gestion.lb_fecha_vta.Text) 'siempre se factura a la fecha del dia en este caso
        row_venta("vendedor") = ""
        row_venta("tipo_venta") = "Cliente"
        Facturacion_ds_report.Tables("venta").Rows.Add(row_venta)

        '///////////////TABLA TOTALES APLICADOS//////////////////////////////////'
        Facturacion_ds_report.Tables("Totales_aplicados").Rows.Clear()
        Dim row_totales As DataRow = Facturacion_ds_report.Tables("Totales_aplicados").NewRow()
        row_totales("subtotal") = CDec(TextBox_TOTAL.Text)
        row_totales("total") = CDec(TextBox_TOTAL.Text)
        row_totales("iva") = CDec(0)
        row_totales("descuento_porcentaje") = CDec(0)
        row_totales("descuento_pesos") = CDec(0)
        row_totales("iva_pesos") = CDec(0)
        Facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)

        '///////////////TABLA PRODUCTO AGREGADO//////////////////////////////////'
        'aqui ciclo en la grilla para ir agrendo los row a la tabla producto agregado
        Facturacion_ds_report.Tables("Producto_agregado").Rows.Clear()
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells("Descripcion").Value <> "" Then
                Dim row_prodADD As DataRow = facturacion_ds_report.Tables("Producto_agregado").NewRow()
                row_prodADD("PROD_id") = DataGridView1.Rows(i).Cells("prod_id").Value
                row_prodADD("codinterno") = CInt(DataGridView1.Rows(i).Cells("Cod_prod").Value)
                row_prodADD("descripcion") = DataGridView1.Rows(i).Cells("Descripcion").Value
                row_prodADD("detalle") = ""
                row_prodADD("cantidad") = CDec(DataGridView1.Rows(i).Cells("Cantidad").Value)
                row_prodADD("precio_unitario") = CDec(DataGridView1.Rows(i).Cells("Costo").Value)
                row_prodADD("precio_subtotal") = CDec(DataGridView1.Rows(i).Cells("subtotal").Value)
                row_prodADD("codbarra") = ""
                row_prodADD("TURNO_id") = ""
                '/choco modificacion 01-12-2019: agrego columna descuento
                row_prodADD("descuento") = CDec(0)
                row_prodADD("grupo_id") = CInt(1)
                facturacion_ds_report.Tables("Producto_agregado").Rows.Add(row_prodADD)
            End If
            i = i + 1
        End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Facturacion\Reportes\CR_comprobante_servicio.rpt")
        CrReport.Database.Tables("Cliente").SetDataSource(Facturacion_ds_report.Tables("Cliente"))
        CrReport.Database.Tables("Sucursal").SetDataSource(Facturacion_ds_report.Tables("Sucursal"))
        CrReport.Database.Tables("Empresa").SetDataSource(Facturacion_ds_report.Tables("Empresa"))
        CrReport.Database.Tables("venta").SetDataSource(Facturacion_ds_report.Tables("venta"))
        CrReport.Database.Tables("Producto_agregado").SetDataSource(Facturacion_ds_report.Tables("Producto_agregado"))
        CrReport.Database.Tables("Totales_aplicados").SetDataSource(Facturacion_ds_report.Tables("Totales_aplicados"))
        Dim visor As New Facturacion_report_show

        visor.CrystalReportViewer1.ReportSource = CrReport
        visor.Text = "Comprobante Nº: " + CStr(numerofactura) + " - Imprimir."
        visor.Show()
        'End If
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

    
    Private Sub Combo_cuadrilla_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_cuadrilla.SelectedValueChanged
        If ds_cuadrilla.Tables(0).Rows.Count <> 0 And combo_cuadrilla_listo = "si" Then
            recuperar_empleados(Combo_cuadrilla.SelectedValue)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If estado_de_orden = "ASIGNADO" Then
            Dim result As Integer = MessageBox.Show("¿Está seguro que desea cambiar el estado de la orden a REPARADO?", "Sistema de Gestión", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If txt_equipo.Text <> "" And txt_sucursal.Text <> "" And txt_diag.Text <> "" And TextBox_Nombre.Text <> "" Then
                    'solo actualizo el estado a reparado
                    ''Actualizacion Servicio'''''
                    Dim ds_SevicioActualizar As DataSet = DAservicio.Servicio_Modificar_MDA(Cliente_ID, DateTimePicker1.Value,
                                                                                    sucursal_id, usuario_id, txt_diag.Text, txt_sucursal.Text,
                                                                                   txt_equipo.Text, DateTimePicker_Rev.Value, DateTimePicker_REP.Value,
                                                                                   TextBox_Anticipo.Text,
                                                                                serv_id, "REPARADO") 'pongo el estado en REPARADO

                    'primero elimino el detalle
                    DAservicio.Servicio_eliminar_Detalle(serv_id)
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
                        End While

                    End If
                    'DAservicio.Orden_trabajo_alta(serv_id, Combo_cuadrilla.SelectedValue)
                    DAservicio.Actividad_Servicio_alta(usuario_id, sucursal_id, Label_Cod.Text, Now, "ORDEN DE TRABAJO, actualización de estado a REPARADO.")
                    MessageBox.Show("Orden de trabajo actualizada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    estado_de_orden = "REPARADO"


                    Dim result2 As Integer = MessageBox.Show("¿Desea ir al calendario de servicios?", "Sistema de Gestión", MessageBoxButtons.YesNo)
                    If result2 = DialogResult.Yes Then
                        Tareas_Consulta.Close()
                        Tareas_Consulta.Show()
                    End If

                    Servicio_Consulta.LOAD_FORM()
                    Me.Close()

                Else
                    MessageBox.Show("Debe Completar los campos Obligatorios", "Sistema de Gestion.")
                    lbl_errNOM.Visible = True
                    lb_error_marca.Visible = True
                    lb_error_modelo.Visible = True
                    lb_error_nombre.Visible = True
                End If
            End If
        Else
            MessageBox.Show("Error, no se puede realizar la operación.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_imprimir.Click
        reporte(orden_trabajo_id)
    End Sub
End Class