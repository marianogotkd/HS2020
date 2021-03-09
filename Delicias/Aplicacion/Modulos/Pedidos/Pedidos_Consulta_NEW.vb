Public Class Pedidos_Consulta_NEW
    Dim validar As New Validaciones 'es una clase creada en la capa de aplicacion ...carpeta "clases"
    Dim ds_proveedor As DataSet
    Dim DAproveedores As New Datos.Proveedor
    Dim DApedidos As New Datos.Pedidos
    Dim Ds_pedidos As DataSet
    Dim inicio = "no"
    Dim dsPedidoss As New dsPedidos

    Private Sub Pedidos_Consulta_NEW_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'NOTA: DEBE ESTAR LA PROPIEDAD DEL FORM "KEYPREVIEW = TRUE" para q se ejecute el evento keydown.
        If e.KeyCode = Keys.F1 Then 'F1
            If Me.Size.Width = 388 And Me.Size.Height = 436 Then
                Me.Size = New System.Drawing.Size(636, 436) 'tamaño con busqueda expandida
            Else
                Me.Size = New System.Drawing.Size(388, 436) 'tamaño con busqueda oculta
            End If
        End If
        If e.KeyCode = Keys.F2 Then
            'Ver_promocion.tx_Buscar.Focus()
        End If
    End Sub

    Private Sub Pedidos_Consulta_NEW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Size = New System.Drawing.Size(388, 436) 'tamaño con busqueda oculta
        Cargarcombo_proveedor()
        obtener_pedidos()
    End Sub

    Public Sub Cargarcombo_proveedor()
        ds_proveedor = DAproveedores.Proveedor_obtener
        'Cargar Proveedor
        ComboBox_prove.DataSource = ds_proveedor.Tables(0)
        ComboBox_prove.DisplayMember = "Prov_nombre"
        ComboBox_prove.ValueMember = "Prov_id"
        inicio = "si"
    End Sub

    Private Sub obtener_pedidos() 'trae los pedidos segun el proveedor seleccionado en el combo
        dsPedidoss.Tables("PedidosConsulta").Rows.Clear()
        Dim ds_prov As DataSet
        If RadioButton_Todos_prov.Checked = True Then
            ds_prov = DApedidos.Pedidos_Obtener_todos
        Else
            ds_prov = DApedidos.Pedidos_Obtener_x_Prove(ComboBox_prove.SelectedValue)
        End If

        If ds_prov.Tables(0).Rows.Count <> 0 Then
            dsPedidoss.Tables("PedidosConsulta").Merge(ds_prov.Tables(0))
            DG_Pedido.DataSource = dsPedidoss.Tables("PedidosConsulta")
            pedidos_formato_estado()
        End If
    End Sub

    Private Sub obtener_pedidos_Todos()
        dsPedidoss.Tables("PedidosConsulta").Rows.Clear()
        Dim ds_prov As DataSet = DApedidos.Pedidos_Obtener
        If ds_prov.Tables(0).Rows.Count <> 0 Then
            dsPedidoss.Tables("PedidosConsulta").Merge(ds_prov.Tables(0))
            DG_Pedido.DataSource = dsPedidoss.Tables("PedidosConsulta")
            pedidos_formato_estado()
        End If
    End Sub

    'poner colores a los pedidos segun el estado
    Private Sub pedidos_formato_estado()
        If DG_Pedido.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DG_Pedido.Rows.Count
                Dim estado As String = DG_Pedido.Rows(i).Cells("PEDIDOESTnomDataGridViewTextBoxColumn").Value
                If estado = "PENDIENTE" Then
                    DG_Pedido.Rows(i).Cells("PEDIDOESTnomDataGridViewTextBoxColumn").Style.ForeColor = Color.Red
                End If
                If estado = "FINALIZADO" Then
                    DG_Pedido.Rows(i).Cells("PEDIDOESTnomDataGridViewTextBoxColumn").Style.ForeColor = Color.Green
                End If
                i = i + 1
            End While
            Dim style As New DataGridViewCellStyle            style.Font = New Font(DG_Pedido.Font, FontStyle.Bold)            DG_Pedido.Columns("PEDIDOESTnomDataGridViewTextBoxColumn").DefaultCellStyle = style
        End If
    End Sub

    Private Sub ComboBox_prove_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_prove.SelectedIndexChanged
        If inicio = "si" Then
            dsPedidoss.Tables("PedidosConsulta").Rows.Clear()
            Dim ds_prov As DataSet = DApedidos.Pedidos_Obtener_x_Prove(ComboBox_prove.SelectedValue)
            If ds_prov.Tables(0).Rows.Count <> 0 Then
                dsPedidoss.Tables("PedidosConsulta").Merge(ds_prov.Tables(0))
                DG_Pedido.DataSource = dsPedidoss.Tables("PedidosConsulta")
                pedidos_formato_estado()
            End If


        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_recepcion.Click
        If DG_Pedido.Rows.Count <> 0 Then
            If DG_Pedido.CurrentRow.Selected = True And DG_Pedido.CurrentRow.Cells("PEDIDOESTnomDataGridViewTextBoxColumn").Value = "PENDIENTE" Then
                Pedidos_Recepcion.Close()

                Pedidos_Recepcion.Label_estado.Text = DG_Pedido.SelectedCells(6).Value
                Pedidos_Recepcion.Label_fecha.Text = DG_Pedido.SelectedCells(2).Value
                Pedidos_Recepcion.Label_pedido.Text = DG_Pedido.SelectedCells(1).Value
                Pedidos_Recepcion.Label_prove.Text = ComboBox_prove.Text
                Pedidos_Recepcion.Pedidos_ID = DG_Pedido.SelectedCells(0).Value
                Pedidos_Recepcion.Prove_ID = DG_Pedido.SelectedCells(3).Value
                Pedidos_Recepcion.pedido_finalizar = "si"
                Pedidos_Recepcion.Show()
            Else
                MessageBox.Show("Error, seleccione un pedido Pendiente", "Sistema de Gestión")
            End If
        Else
            MessageBox.Show("Error, seleccione un pedido", "Sistema de Gestión")
        End If
    End Sub

    Private Sub Button_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_editar.Click
        If DG_Pedido.Rows.Count <> 0 Then
            If DG_Pedido.CurrentRow.Selected = True And DG_Pedido.CurrentRow.Cells("PEDIDOESTnomDataGridViewTextBoxColumn").Value = "PENDIENTE" Then
                Pedido_Productos.Close() ''lo cierro x q se usa para varios fines el form

                Pedido_Productos.Label_fecha.Text = DG_Pedido.SelectedCells(2).Value
                Pedido_Productos.Label_Pedido.Text = DG_Pedido.SelectedCells(1).Value
                Pedido_Productos.Pedidos_ID = DG_Pedido.SelectedCells(0).Value
                Pedido_Productos.Prove_ID = DG_Pedido.SelectedCells(3).Value
                'Pedido_Productos.Label_prov.Text = dsPedidoss.Tables("PedidosConsulta").Rows(0).Item(0)
                Dim proveedor As String = ComboBox_prove.Text
                Pedido_Productos.Label_prov.Text = ComboBox_prove.Text
                Pedido_Productos.Text = "Editar pedido a proveedor: " + ComboBox_prove.Text
                Pedido_Productos.Show()
                Pedido_Productos.form_procedencia = "Pedidos_Consulta_NEW"
            Else
                MessageBox.Show("Error, seleccione un pedido Pendiente", "Sistema de Gestión")
            End If
        Else
            MessageBox.Show("Error, seleccione un pedido", "Sistema de Gestión")
        End If
    End Sub

    Private Sub DG_Pedido_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DG_Pedido.ColumnHeaderMouseClick
        pedidos_formato_estado()
    End Sub

    Private Sub Txt_busqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_busqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            RadioButton_todos.Checked = True
            If Txt_busqueda.Text <> "" Then 'si no es vacio lo busco
                obtener_pedidos() 'traigo todos los pedidos, en primer lugar
                Dim encontrado As String = "no"
                If dsPedidoss.Tables("PedidosConsulta").Rows.Count <> 0 Then 'si existen pedidos, busco el parametro ingresado y voy quitando los que no coincidan
                    Dim i As Integer = 0
                    While i < dsPedidoss.Tables("PedidosConsulta").Rows.Count
                        If dsPedidoss.Tables("PedidosConsulta").Rows(i).Item("Pedidos_Cod") = Txt_busqueda.Text Then
                            encontrado = "si"
                            i = dsPedidoss.Tables("PedidosConsulta").Rows.Count
                        Else
                            i = i + 1
                        End If
                    End While
                    If encontrado = "si" Then 'si lo encuentro quito los demas
                        i = 0
                        While i < dsPedidoss.Tables("PedidosConsulta").Rows.Count
                            If dsPedidoss.Tables("PedidosConsulta").Rows(i).Item("Pedidos_Cod") <> Txt_busqueda.Text Then
                                dsPedidoss.Tables("PedidosConsulta").Rows.RemoveAt(i)
                            Else
                                i = i + 1
                            End If
                        End While
                    Else
                        MessageBox.Show("Error! No existe el pedido", "Sistema de Gestión")
                    End If
                End If
            Else
                obtener_pedidos()
            End If

        End If
    End Sub

    Private Sub Txt_busqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_busqueda.KeyPress
        validar.Restricciones_textbox(e, "Entero", Txt_busqueda)
    End Sub

    Private Sub RadioButton_finalizados_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_finalizados.Click
        If RadioButton_finalizados.Checked = True Then
            'si lo selecciono muestro solo los finalizados
            obtener_pedidos() 'cargo el dataset desde sql siempre, x si previamente se hizo otro filtro
            Dim i As Integer = 0
            While i < dsPedidoss.Tables("PedidosConsulta").Rows.Count
                If dsPedidoss.Tables("PedidosConsulta").Rows(i).Item("PEDIDO_EST_nom") = "PENDIENTE" Then
                    dsPedidoss.Tables("PedidosConsulta").Rows.RemoveAt(i)
                Else
                    i = i + 1
                End If

            End While
        End If
    End Sub

    Private Sub RadioButton_pendientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_pendientes.Click

        If RadioButton_pendientes.Checked = True Then
            obtener_pedidos() 'cargo el dataset desde sql siempre, x si previamente se hizo otro filtro
            Dim i As Integer = 0
            While i < dsPedidoss.Tables("PedidosConsulta").Rows.Count
                If dsPedidoss.Tables("PedidosConsulta").Rows(i).Item("PEDIDO_EST_nom") = "FINALIZADO" Then
                    dsPedidoss.Tables("PedidosConsulta").Rows.RemoveAt(i)
                Else
                    i = i + 1
                End If

            End While
        End If

    End Sub

    Private Sub RadioButton_todos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_todos.Click
        If RadioButton_todos.Checked = True Then
            obtener_pedidos()
        End If
    End Sub

    Private Sub Bo_busqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_busqueda.Click
        RadioButton_todos.Checked = True
        Dim ds_pedidos_rango As DataSet = DApedidos.Pedidos_buscar_rango_fecha(DT_FECHA_desde.Text, DT_FECHA_hasta.Text, ComboBox_prove.SelectedValue)
        If ds_pedidos_rango.Tables(0).Rows.Count <> 0 Then


            dsPedidoss.Tables("PedidosConsulta").Rows.Clear()
            dsPedidoss.Tables("PedidosConsulta").Merge(ds_pedidos_rango.Tables(0))
            DG_Pedido.DataSource = dsPedidoss.Tables("PedidosConsulta")
            pedidos_formato_estado()
        Else
            MessageBox.Show("La busqueda no arrojó resultados para el rango de fechas.", "Sistema de Gestión.")
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ver.Click
        If DG_Pedido.Rows.Count <> 0 Then
            If DG_Pedido.CurrentRow.Selected = True Then
                Pedidos_Recepcion.Close() 'lo cierro x q se usa para varios fines el form

                Pedidos_Recepcion.Label_estado.Text = DG_Pedido.SelectedCells(6).Value
                Pedidos_Recepcion.Label_fecha.Text = DG_Pedido.SelectedCells(2).Value
                Pedidos_Recepcion.Label_pedido.Text = DG_Pedido.SelectedCells(1).Value
                Pedidos_Recepcion.Label_prove.Text = ComboBox_prove.Text
                Pedidos_Recepcion.Pedidos_ID = DG_Pedido.SelectedCells(0).Value
                Pedidos_Recepcion.Button_guardar.Visible = False
                Pedidos_Recepcion.DataGridView1.ReadOnly = True

                Pedidos_Recepcion.Show()
                'me falta ocultar el boton de guardar y agregar un boton para que se abra un reporte del pedido generado.
            Else
                MessageBox.Show("Error, seleccione un pedido.", "Sistema de Gestión")
            End If
        Else
            MessageBox.Show("Error, seleccione un pedido.", "Sistema de Gestión")
        End If
    End Sub

    


    Private Sub RadioButton_Todos_prov_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Todos_prov.Click

        If RadioButton_Todos_prov.Checked = True Then
            'obtener_pedidos_Todos()
            obtener_pedidos()

            ComboBox_prove.Enabled = False
            RadioButton_todos.Checked = True

        End If
    End Sub

    Private Sub RadioButton_Prov_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Prov.Click
        If RadioButton_Prov.Checked = True Then
            ComboBox_prove.Enabled = True
            obtener_pedidos()
            RadioButton_todos.Checked = True
        End If
    End Sub
End Class