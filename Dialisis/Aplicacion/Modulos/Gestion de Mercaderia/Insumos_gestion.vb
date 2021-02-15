Public Class Insumos_gestion
    Dim DAsucursal As New Datos.Sucursal
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Dim DAprod As New Datos.Producto
    Dim ds_PROD As DataSet
    Dim DAlote As New Datos.Lote
    Public procedencia
    Private Sub Insumos_gestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Sucursales_Obtener_Origen()

        'solo consumo de una sola sucursal, ligada al usuario que se loguea.
        Dim sucursal_id As Integer = Inicio.suc_id
        Dim UT_id As Integer = Inicio.UT_id
        If UT_id <> 1 Then
            cb_origen.SelectedValue = sucursal_id
            cb_origen.Enabled = False
        End If

       
    End Sub


    Private Sub Sucursales_Obtener_Origen()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        cb_origen.DataSource = ds.Tables(0)
        cb_origen.DisplayMember = "sucursal_nombre"
        cb_origen.ValueMember = "sucursal_id"
    End Sub


    Private Sub Bo_codbarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_codbarra.Click
        GM_Consultar_Stock.Close()
        GM_Consultar_Stock.form_procedencia = "Gestion_Mercaderia" 'abro el mismo form q en el modulo de gestion mercaderia
        GM_Consultar_Stock.Show()
    End Sub

    Private Sub btn_Agregar_Prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Prod.Click
        'es lo mismo que baja de mercaderia
        GM_Baja_Producto.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
        GM_Baja_Producto.sucursal_nombre = cb_origen.Text
        GM_Baja_Producto.sucursal_id = CInt(cb_origen.SelectedValue)
        GM_Baja_Producto.form_procedencia = "Gestion_Mercaderia"
        GM_Baja_Producto.Text = "Sucursal: " + cb_origen.Text + " - Gestión de insumos"
        GM_Baja_Producto.tipo_movimiento = "consumir producto"
        GM_Baja_Producto.Show()
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

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Mov_DS.Tables("Mov").Rows.Clear()
        DataGridView1.DataSource = Mov_DS.Tables("Mov")
        'cb_Movimiento.Enabled = True
        'desbloqueo origen y destino combos en form gestion_mercaderia

        'AQUI HABilito el combo de sucursal
        cb_origen.Enabled = True
        Dim sucursal_id As Integer = Inicio.suc_id
        Dim UT_id As Integer = Inicio.UT_id
        If UT_id <> 1 Then 'deshabilito si no soy admin.
            cb_origen.SelectedValue = sucursal_id
            cb_origen.Enabled = False
        End If


        'cb_destino.Enabled = True
    End Sub



    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim concepto As String
        concepto = "Insumo consumido" + ", " + tb_concepto.Text
        ''''Alta en tabla Movimiento_Mercaderia''''''''''
        If Mov_DS.Tables("Mov").Rows.Count <> 0 Then
            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea consumir los insumos listados?", "Sistema de Gestión", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim lote_id As Integer
                Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta(concepto, DateTimePicker1.Value, Inicio.USU_id, cb_origen.SelectedValue)
                ''''''''''''''''''''''''''''''''''''''''''''''''

                Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
                Dim i As Integer = 0
                While i < Mov_DS.Tables("Mov").Rows.Count
                    '''''Actualizacion de Stock''''''''''''''''''''''''
                    Dim Ds_Suc As DataSet
                    'Dim Origen As Integer
                    'Dim Destino As Integer
                    Dim Mov As Decimal
                    'Dim j As Integer = 0
                    'While i < Mov_DS.Tables("Mov").Rows.Count
                    ds_PROD = DAprod.Producto_buscarcod(Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"))
                    Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                    Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, cb_origen.SelectedValue, cb_origen.SelectedValue)


                    'If cb_Movimiento.SelectedItem = "Baja de Mercaderia" Then
                    'Calculo Stock''''''''
                    Mov = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov").Rows(i).Item("Cantidad")
                    '''''''

                    Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))
                    'ahora resto al stock real q ya existe en suc origne.
                    Dim stock_real_nuevo As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("ProdxSuc_stock_real")) - stock_real_ingreso


                    ''''''''''
                    'Actualizo stock''''' no quito el registro del producto en la sucursal, en realidad lo que hago es actualizar su cantidad a 0. OJO No tiene que hacerse negativo.
                    DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, cb_origen.SelectedValue, Mov, stock_real_nuevo) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
                    '''''''''''
                    '////////////////choco: 08-07-2020///////////////////////////////////
                    'actualizo la cant en el lote asociado a un producto de una sucursal.
                    Dim lote_nro As String = Mov_DS.Tables("Mov").Rows(i).Item("Lote")
                    Dim cant_a_quitar As Decimal = CDec(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"))



                    Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, cb_origen.SelectedValue, cant_a_quitar, Mov_DS.Tables("Mov").Rows(i).Item("Prov_id"), stock_real_ingreso, CDec(0))
                    lote_id = dslote.Tables(0).Rows(0).Item("lote_id")
                    'End If
                    ''''''''''''''''''''''''''''''''''''''
                    '''''' Alta Tabla Detalle'''''' de movimiento claro está
                    'alta en tabla mercaderia_detalle_alta
                    DAMovintoMer.Consumo_mercaderia_Detalle_alta(Mov_DS.Tables("Mov").Rows(i).Item("Cantidad"), MovMer_id, Mov_DS.Tables("Mov").Rows(i).Item("Cod_prod"), lote_id)
                    i = i + 1
                End While
                '''''''''''''''''''''''''''''''''''''''''''


                Limpiar()
                MessageBox.Show("Operación Registrada Con Éxito.", "Sistema de Gestión.")

            End If
        Else
            MessageBox.Show("Debe agregar al menos un producto.", "Sistema de Gestión.")
        End If
    End Sub

    Public Sub Limpiar()
        tb_concepto.Text = Nothing
        'cb_Movimiento.Enabled = True
        'desbloqueo origen y destino combos en form gestion_mercaderia

        cb_origen.Enabled = True
        Dim sucursal_id As Integer = Inicio.suc_id
        Dim UT_id As Integer = Inicio.UT_id
        If UT_id <> 1 Then 'deshabilito si no soy admin.
            cb_origen.SelectedValue = sucursal_id
            cb_origen.Enabled = False
        End If

        'cb_destino.Enabled = True





        Mov_DS.Tables("Mov").Rows.Clear()
        DataGridView1.DataSource = Mov_DS.Tables("Mov")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Consumos_consulta.Close()
        Consumos_consulta.Show()

    End Sub
End Class