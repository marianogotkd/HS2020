Public Class Gestion_Mercaderia
    Dim DAsucursal As New Datos.Sucursal
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Dim ds_PROD As DataSet
    Dim DAprod As New Datos.Producto
    

    Private Sub Gestion_Mercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Sucursales_Obtener_Destino()
        Sucursales_Obtener_Origen()
        DateTimePicker1.Value = Today



    End Sub
    Private Sub Sucursales_Obtener_Origen()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        cb_origen.DataSource = ds.Tables(0)
        cb_origen.DisplayMember = "sucursal_nombre"
        cb_origen.ValueMember = "sucursal_id"


    End Sub
    Private Sub Sucursales_Obtener_Destino()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        cb_destino.DataSource = ds.Tables(0)
        cb_destino.DisplayMember = "sucursal_nombre"
        cb_destino.ValueMember = "sucursal_id"
    End Sub
    Private Sub cb_Movimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Movimiento.SelectedIndexChanged
        If cb_Movimiento.SelectedItem = "Movimiento Entre Sucursales" Then
            cb_destino.Enabled = True
        Else
            cb_destino.Enabled = False
            Igular_Combos()

        End If

        cb_Movimiento.Enabled = False
    End Sub
    Private Sub Igular_Combos()
        If cb_Movimiento.SelectedItem <> "Movimiento Entre Sucursales" Then
            cb_destino.SelectedIndex = cb_origen.SelectedIndex
        End If
    End Sub
    Private Sub cb_origen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_origen.SelectedIndexChanged
        Igular_Combos()
    End Sub

    Private Sub btn_Agregar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Prod.Click
        If cb_Movimiento.SelectedItem <> "" Then
            If cb_Movimiento.SelectedItem = "Movimiento Entre Sucursales" Then
                If cb_destino.SelectedIndex <> cb_origen.SelectedIndex Then
                    GM_Carga_Producto.Show()
                Else
                    MessageBox.Show("Debe ingresar Sucursales diferentes para realizar el movimiento de mercadería.", "Sistema de Gestión.")
                End If
            Else

                GM_Carga_Producto.Show()
            End If
        Else
            MessageBox.Show("Debe seleccionar algún movimiento.", "Sistema de Gestión.")

        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Mov_DS.Tables("Mov").Rows.Clear()
        DataGridView1.DataSource = Mov_DS.Tables("Mov")
        cb_Movimiento.Enabled = True
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim concepto As String
        concepto = cb_Movimiento.SelectedItem + ", " + tb_concepto.Text
            ''''Alta en tabla Movimiento_Mercaderia''''''''''
            If Mov_DS.Tables("Mov").Rows.Count <> 0 Then
            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea realizar: " + cb_Movimiento.Text + "?.", "Sistema de Gestión", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, DateTimePicker1.Value, Inicio.USU_id, cb_origen.SelectedValue, cb_destino.SelectedValue)
                ''''''''''''''''''''''''''''''''''''''''''''''''
                '''''' Alta Tabla Detalle''''''
                Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
                Dim i As Integer = 0
                While i < Mov_DS.Tables("Mov").Rows.Count
                    DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"), MovMer_id, Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"))
                    i = i + 1

                End While
                '''''''''''''''''''''''''''''''''''''''''''
                '''''Actulizacion de Stock''''''''''''''''''''''''
                Dim Ds_Suc As DataSet
                Dim Origen As Integer
                Dim Destino As Integer
                Dim Mov As Decimal
                Dim j As Integer = 0
                While j < Mov_DS.Tables("Mov").Rows.Count
                    ds_PROD = DAprod.Producto_buscarcod(Mov_DS.Tables("Mov").Rows(j).Item("Cod_prod"))
                    Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                    Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, cb_origen.SelectedValue, cb_destino.SelectedValue)
                    If cb_Movimiento.SelectedItem = "Movimiento Entre Sucursales" Then
                        'Calculo Stock''''''''
                        Origen = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov").Rows(j).Item("Cantidad")
                        ''''''''''
                        'Actualizo stock'''''
                        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_origen.SelectedValue, Origen)
                        '''''''''''
                        'Calculo Stock''''''''
                        Destino = Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino") + Mov_DS.Tables("Mov").Rows(j).Item("Cantidad")
                        ''''''''''
                        'Actualizo stock'''''
                        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_destino.SelectedValue, Destino)
                        '''''''''''
                    End If
                    If cb_Movimiento.SelectedItem = "Alta de Mercaderia" Then
                        'Calculo Stock''''''''
                        Mov = CDec(Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino")) + CDec(Mov_DS.Tables("Mov").Rows(j).Item("Cantidad"))
                        ''''''
                        ''''''''''
                        'Actualizo stock'''''
                        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_destino.SelectedValue, Mov)
                        '''''''''''
                    End If
                    If cb_Movimiento.SelectedItem = "Baja de Mercaderia" Then
                        'Calculo Stock''''''''
                        Mov = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov").Rows(j).Item("Cantidad")
                        '''''''
                        ''''''''''
                        'Actualizo stock'''''
                        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_destino.SelectedValue, Mov)
                        '''''''''''
                    End If
                    j = j + 1
                End While
                ''''''''''''''''''''''''''''''''''''''
                Limpiar()
                MessageBox.Show("Operación Registrada Con Éxito.", "Sistema de Gestión.")
            End If
        Else
            MessageBox.Show("Debe agregar al menos un producto.", "Sistema de Gestión.")
        End If
    End Sub

    Public Sub Limpiar()
        tb_concepto.Text = Nothing
        cb_Movimiento.Enabled = True
        Mov_DS.Tables("Mov").Rows.Clear()
        DataGridView1.DataSource = Mov_DS.Tables("Mov")
    End Sub

    Private Sub tb_concepto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_concepto.GotFocus
        tb_concepto.SelectAll()
        tb_concepto.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_concepto.Visible = True
    End Sub

    Private Sub tb_concepto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_concepto.LostFocus
        tb_concepto.BackColor = Color.White
        'RectangleShape_concepto.Visible = False
    End Sub
    Private Sub cb_Movimiento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Movimiento.GotFocus
        cb_Movimiento.SelectAll()
        cb_Movimiento.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_movimiento.Visible = True
    End Sub
    Private Sub cb_Movimiento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Movimiento.LostFocus
        cb_Movimiento.BackColor = Color.White
        'RectangleShape_movimiento.Visible = False
    End Sub
    Private Sub cb_origen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_origen.GotFocus
        cb_origen.SelectAll()
        cb_origen.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_origen.Visible = True
    End Sub
    Private Sub cb_origen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_origen.LostFocus
        cb_origen.BackColor = Color.White
        'RectangleShape_origen.Visible = False
    End Sub


    Private Sub cb_destino_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_destino.GotFocus
        cb_destino.SelectAll()
        cb_destino.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_destino.Visible = True
    End Sub

    Private Sub cb_destino_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_destino.LostFocus
        cb_destino.BackColor = Color.White
        'RectangleShape_destino.Visible = False
    End Sub

    Private Sub Bo_codbarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_codbarra.Click
        Busqueda_Productos.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
        Busqueda_Productos.sucursal_nombre = cb_origen.Text
        Busqueda_Productos.sucursal_id = CInt(cb_origen.SelectedValue)
        Busqueda_Productos.form_procedencia = "Gestion_Mercaderia"
        Busqueda_Productos.Show()
    End Sub

    Private Sub btn_eliminar_seleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_seleccion.Click
        ''aqui elemino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        Dim valido_seleccion As String = "no"
        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                        If MsgBox("¿Esta seguro que quiere quitar los items seleccionados?.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
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
                        Dim a As Integer = 0
                        While a < DataGridView1.Rows.Count
                            If DataGridView1.Rows(a).Cells(1).Value <> 0 Then
                                DataGridView1.Rows(a).Cells(0).Value = a + 1
                            End If
                            a = a + 1
                        End While
                        'calcular_totales()
                        'aplicar_iva()
                    End If
                Else
                    i = i + 1
                End If

            End While






            If valido_seleccion = "no" Then
                MessageBox.Show("Seleccione un producto para eliminar.", "Sistema de Gestión.")
            End If
        Else
            MessageBox.Show("No hay productos en el listado.", "Sistema de Gestión")
        End If
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        If DataGridView1.Rows.Count <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea quitar todos los productos del listado?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Mov_DS.Tables("Mov").Rows.Clear() 'no uso el datagridview rows clear...x q me tira error x el dataset q esta asociado
                'DataGridView1.Rows.clear 
                'DataGridView1.Rows.Add()
                'DataGridView1.Focus()
                'DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True
            End If
        Else
            MessageBox.Show("No hay productos en el listado.", "Sistema de Gestión.")
        End If

        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Movimientos_consulta.Show()
    End Sub
End Class