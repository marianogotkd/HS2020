Public Class Producto_ajuste
    Dim dalote As New Datos.Lote
    Dim DAprod As New Datos.Producto
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Public sucursal_id As Integer
    Dim DAsucursal As New Datos.Sucursal
    Public tipo_producto As String 'me indica si es string
    Public contenido_x_unidad As Decimal
    Public unidad_medida As String
    Public Sub recuperar_lotes()
        Mov_DS.Tables("lote_baja").Rows.Clear() 'siempre borro
        Dim prodcodinterno As Integer = CInt(txt_codigo.Text)
        Dim ds_lotes As DataSet = dalote.Producto_x_sucursal_lote_recuperartodos(prodcodinterno, sucursal_id)

        If ds_lotes.Tables(0).Rows.Count <> 0 Then
            Mov_DS.Tables("lote_baja").Rows.Clear()

            Dim i As Integer = 0
            While i < ds_lotes.Tables(0).Rows.Count
                Dim nuevoRow As DataRow = Mov_DS.Tables("lote_baja").NewRow
                nuevoRow("prod_id") = ds_lotes.Tables(0).Rows(i).Item("prod_id")
                nuevoRow("prod_codinterno") = ds_lotes.Tables(0).Rows(i).Item("prod_codinterno")
                nuevoRow("prod_descripcion") = ds_lotes.Tables(0).Rows(i).Item("prod_descripcion")
                nuevoRow("ProdxSuc_stock") = ds_lotes.Tables(0).Rows(i).Item("ProdxSuc_stock")
                nuevoRow("lote_id") = ds_lotes.Tables(0).Rows(i).Item("lote_id")
                nuevoRow("lote_nro") = ds_lotes.Tables(0).Rows(i).Item("lote_nro")
                nuevoRow("lote_cantidad") = ds_lotes.Tables(0).Rows(i).Item("lote_cantidad")
                nuevoRow("lote_vence") = ds_lotes.Tables(0).Rows(i).Item("lote_vence")
                If ds_lotes.Tables(0).Rows(i).Item("lote_vence") = "si" Then
                    nuevoRow("lote_fechafab") = ds_lotes.Tables(0).Rows(i).Item("lote_fechafab")
                    nuevoRow("lote_fechavto") = ds_lotes.Tables(0).Rows(i).Item("lote_fechavto")
                End If
                nuevoRow("sucursal_id") = ds_lotes.Tables(0).Rows(i).Item("sucursal_id")
                nuevoRow("Prov_id") = ds_lotes.Tables(0).Rows(i).Item("Prov_id")
                nuevoRow("Proveedor") = ds_lotes.Tables(0).Rows(i).Item("Proveedor")
                nuevoRow("lote_stock_real") = ds_lotes.Tables(0).Rows(i).Item("lote_stock_real")
                nuevoRow("lote_aux") = ds_lotes.Tables(0).Rows(i).Item("lote_aux")

                contenido_x_unidad = ds_lotes.Tables(0).Rows(i).Item("prod_contenido")
                unidad_medida = ds_lotes.Tables(0).Rows(i).Item("prod_unidadmedida")
                tipo_producto = ds_lotes.Tables(0).Rows(i).Item("prod_tipo")
                txt_totalreal.Text = ds_lotes.Tables(0).Rows(i).Item("ProdxSuc_stock_real").ToString + " " + ds_lotes.Tables(0).Rows(i).Item("prod_unidadmedida")
                Mov_DS.Tables("lote_baja").Rows.Add(nuevoRow)
                i = i + 1
            End While
            'Mov_DS.Tables("lote_baja").Merge(ds_lotes.Tables(0))
            'DataGridView2.DataSource = Mov_DS.Tables("lote_baja")

            'ahora ponemos con colores los productos en verde, amarillo y rojo.

            Dim a As Integer = 0
            While a < DataGridView2.Rows.Count
                If DataGridView2.Rows(a).Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                    Dim fecha_vencimiento As Date = CDate(DataGridView2.Rows(a).Cells("LotefechavtoDataGridViewTextBoxColumn").Value)
                    Dim fechadeldia As Date = Today


                    'If Format(fechadeldia, "yyyy/mm/dd") >= Format(fecha_vencimiento, "yyyy/mm/dd") Then
                    '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                    'Else
                    '    DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                    'End If


                    Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                    If cantdias <= 0 Then
                        DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red

                    Else
                        If cantdias > 15 Then
                            DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                        Else
                            'menor o igual a 15 
                            DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Orange
                        End If

                    End If

                End If
                a = a + 1
            End While
        Else
            If ds_lotes.Tables(1).Rows.Count <> 0 Then
                contenido_x_unidad = ds_lotes.Tables(1).Rows(0).Item("prod_contenido")
                unidad_medida = ds_lotes.Tables(1).Rows(0).Item("prod_unidadmedida")
                tipo_producto = ds_lotes.Tables(1).Rows(0).Item("prod_tipo")
                txt_totalreal.Text = ds_lotes.Tables(1).Rows(0).Item("ProdxSuc_stock_real").ToString + " " + ds_lotes.Tables(1).Rows(0).Item("prod_unidadmedida")
            End If
        End If
    End Sub

    Private Sub Producto_ajuste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_lotes()
    End Sub

    Private Sub btn_eliminar_seleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_seleccion.Click
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        Dim valido_seleccion As String = "no"
        If DataGridView2.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView2.Rows.Count
                If DataGridView2.Rows(i).Cells("Item").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                        If MsgBox("¿Esta seguro que quiere eliminar los lotes seleccionados?.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                            pregunta = "si"
                        Else
                            'aqui corto el ciclo, ya que se cancelo la eliminacion
                            i = DataGridView2.Rows.Count
                        End If
                    End If
                    If pregunta = "si" Then
                        'primero guardo el nro de item q contiene
                        Dim item As Decimal = DataGridView2.CurrentRow.Index


                        'aqui borro de la bd.
                        '///////////////////////////////////////////
                        eliminar_en_bd(CDec(DataGridView2.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value), DataGridView2.Rows(i).Cells("LotenroDataGridViewTextBoxColumn").Value, CInt(DataGridView2.Rows(i).Cells("ProvidDataGridViewTextBoxColumn").Value))
                        '//////////////////////////////////////////





                        DataGridView2.Rows.RemoveAt(i)
                        i = 0 'lo reinicio, x q al quitar un ite, se reordenan los indices




                        
                        ''cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
                        'Dim a As Integer = 0
                        'While a < DataGridView2.Rows.Count
                        '    If DataGridView2.Rows(a).Cells(1).Value <> 0 Then
                        '        DataGridView2.Rows(a).Cells(0).Value = a + 1
                        '    End If
                        '    a = a + 1
                        'End While


                        
                    End If
                Else
                    i = i + 1
                End If

            End While

            If pregunta = "si" Then
                'como se borro algo recupero todos los lotes nuevamente
                recuperar_lotes()
                'ademas vuelvo a calcular el total de stock para mostrar en el textbox "TOTAL DE UNIDADES:"
                calcular_total()
                cargar_modificacion_en_gridview() 'se reflejan los cambios en el gridview de producto_modificar
                MessageBox.Show("Eliminación correcta, los datos fueron actualizados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If valido_seleccion = "no" Then
                MessageBox.Show("Seleccione un lote para eliminar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("No hay lotes en el listado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub calcular_total()
        'recorro el gridview y sumo la cant en cada lote, para mostrar en el textbox "total de unidades"

        Dim i As Integer = 0
        Dim suma As Decimal = CDec(0)
        While i < DataGridView2.Rows.Count
            suma = suma + CDec(DataGridView2.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value)
            i = i + 1
        End While
        txt_totalunidades.Text = CDec(suma)

    End Sub

    Dim ds_PROD As DataSet
    Private Sub eliminar_en_bd(ByVal cant_lote As Decimal, ByVal lote_nro As String, ByVal Prov_id As Integer)
        Dim concepto As String
        Dim tipo_mov As Integer
        tipo_mov = 4 'los ajustes van a ser tipo 4, sin importar si es alta/baja/modif
        concepto = "Ajuste de Stock, Baja."

        Dim lote_id As Integer
        Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, Today, Inicio.USU_id, sucursal_id, sucursal_id, "", Today, "", Today, tipo_mov, 0, 0, 0)

        Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)

        Dim Ds_Suc As DataSet
        'Dim Origen As Integer
        'Dim Destino As Integer
        Dim Mov As Decimal

        ds_PROD = DAprod.Producto_buscarcod(CInt(txt_codigo.Text))
        Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
        Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id)


        'Calculo Stock''''''''
        Mov = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - cant_lote
        '''''''
        Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * cant_lote
        'ahora RESTO al stock real.
        Dim stock_real_nuevo As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("ProdxSuc_stock_real")) - stock_real_ingreso

        ''''''''''
        'Actualizo stock''''' no quito el registro del producto en la sucursal, en realidad lo que hago es actualizar su cantidad a 0. OJO No tiene que hacerse negativo.
        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, Mov, stock_real_nuevo) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
        '''''''''''

        'actualizo la cant en el lote asociado a un producto de una sucursal.
        'Dim lote_nro As String = Mov_DS.Tables("Mov").Rows(i).Item("Lote")
        Dim cant_a_quitar As Decimal = cant_lote
        'Dim Prov_id As Integer = Mov_DS.Tables("Mov").Rows(i).Item("Prov_id")
        Dim dslote As DataSet = dalote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, sucursal_id, cant_a_quitar, Prov_id, stock_real_ingreso, CDec(0))

        lote_id = dslote.Tables(0).Rows(0).Item("lote_id")


        '''''' Alta Tabla Detalle'''''' de movimiento claro está
        'alta en tabla mercaderia_detalle_alta
        DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(cant_lote, MovMer_id, CInt(txt_codigo.Text), lote_id, CDec(0), CDec(0))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'antes de mostrar el formulario actualizo en sus data set los cambios efectuados.





        Dim i As Integer = 0
        Dim prodid As Integer = 0
        Dim ProdxSuc_stock As Decimal = 0
        Dim Contenido_total As Decimal = 0
        While i < DataGridView2.Rows.Count
            prodid = CInt(DataGridView2.Rows(i).Cells("ProdidDataGridViewTextBoxColumn").Value)
            ProdxSuc_stock = ProdxSuc_stock + CDec(DataGridView2.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value)
            Contenido_total = Contenido_total + CDec(DataGridView2.Rows(i).Cells("lote_stock_real").Value)
            i = i + 1
        End While
        i = 0
        While i < Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows.Count
            'busco producto para actualizar
            If CInt(Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("prod_id")) = prodid And sucursal_id = CInt(Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("sucursal_id")) Then
                'aqui modifico los datos
                Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("ProdxSuc_stock") = ProdxSuc_stock
                Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("Contenido_total") = Contenido_total
                Exit While
            End If
            i = i + 1
        End While

        'Producto_ds.Tables("ProdxSuc") 'esta es la tabla donde estan los productos: (deposito)


        'recuperar todos los lotes
        Dim DAVentas As New Datos.Venta
        Dim ds_lotes_deposito As DataSet = DAVentas.Producto_x_Sucursal_obtener_lotes(1) 'id 1 es deposito
        Dim ds_lotes_dialisis As DataSet = DAVentas.Producto_x_Sucursal_obtener_lotes(3) 'id 3 es suc dialisis
        Dim ds_lotes_dialisis_calle As DataSet = DAVentas.Producto_x_Sucursal_obtener_lotes(5) 'id 5 es suc dialisis calle
        Producto_modificar.table_deposito_lotes.Rows.Clear()
        Producto_modificar.table_dialisis_lotes.Rows.Clear()
        Producto_modificar.table_dialisis_calle_lotes.Rows.Clear()

        Producto_modificar.table_deposito_lotes.Merge(ds_lotes_deposito.Tables(0)) 'copy copia la estructura y contenido, clone solo copia estructura.
        Producto_modificar.table_dialisis_lotes.Merge(ds_lotes_dialisis.Tables(0))
        Producto_modificar.table_dialisis_calle_lotes.Merge(ds_lotes_dialisis_calle.Tables(0))

        'luego se aplica el calculo para contar los vencidos
        Producto_modificar.agregar_cant_vencida()


        Producto_modificar.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Button1.Text = "Editar lotes" Then

        '    DataGridView2.Columns("LotecantidadDataGridViewTextBoxColumn").ReadOnly = False
        '    Dim i As Integer
        '    While i < DataGridView2.Rows.Count
        '        DataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect
        '        Me.DataGridView2.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Style.BackColor = Color.Yellow
        '        i = i + 1
        '    End While


        '    btn_eliminar_seleccion.Enabled = False
        '    Button2.Enabled = True 'boton cancelar
        '    Button1.Text = "Guardar cambios"

        'Else
        '    If Button1.Text = "Guardar cambios" Then
        '        If MsgBox("¿Esta seguro que guardar los cambios?.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then

        '            MessageBox.Show("Datos actualizados correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Else

        '        End If


        '    End If
        'End If





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'btn_eliminar_seleccion.Enabled = True
        'Button2.Enabled = False
        'Button1.Text = "Editar lotes"

        'recuperar_lotes() 'vuelvo a cargar lo que tengo en la bd
        'If DataGridView2.Rows.Count <> 0 Then
        '    DataGridView2.Rows(0).Selected = True
        'End If
    End Sub

    Private Sub DataGridView2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        If DataGridView2.CurrentCell.Value Is DBNull.Value Then

            DataGridView2.CurrentCell.Value = 0
        End If
    End Sub

    Private Sub DataGridView2_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        Dim vence As String = "no"
        Dim i As Integer = e.RowIndex
        If DataGridView2.Rows(i).Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then 'esto significa que voy a validar esta celda
            'ahora pongo los colores
            Dim cantdias As Integer
            If DataGridView2.Columns(e.ColumnIndex).Name = "LotefechavtoDataGridViewTextBoxColumn" Then

                cantdias = DateDiff("d", Today, e.Value)

                If cantdias <= 0 Then
                    'e.CellStyle.ForeColor = Color.Red
                    'e.CellStyle.SelectionForeColor = Color.Red
                    DataGridView2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
                    DataGridView2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
                    'DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                Else
                    If cantdias > 15 Then
                        'e.CellStyle.ForeColor = Color.Green 'esto es si quiero solamente en verde la celda y no la fila
                        'e.CellStyle.SelectionForeColor = Color.Green
                        DataGridView2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Green
                        DataGridView2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Green
                        'DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Green
                    Else
                        'menor o igual a 15 
                        'e.CellStyle.ForeColor = Color.Orange
                        'e.CellStyle.SelectionForeColor = Color.Orange
                        DataGridView2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
                        DataGridView2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Orange
                        'DataGridView2.Rows(a).DefaultCellStyle.ForeColor = Color.Orange
                    End If
                End If
            End If
        End If

        
            
        'Dim vencidos As Decimal = CDec(e.Value)
        'If vencidos <> CDec(0) Then
        '    e.CellStyle.ForeColor = Color.Red
        '    e.CellStyle.SelectionForeColor = Color.Red
        'End If




    End Sub

    Private Sub DataGridView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.Click

        'NOTA: LO QUE HAGO AQUI ES QUE SOLO SE PERMITA HACER UN CHECK EN UNA SOLA FILA
        If DataGridView2.Rows.Count <> 0 Then
            'DataGridView2.Rows(i).Cells("Item").Value = True
            'If DataGridView2.CurrentRow.Cells("item").Value = True Then
            Dim i As Integer = 0
            While i < DataGridView2.Rows.Count
                If DataGridView2.Rows(i).Cells("item").Value = True Then
                    DataGridView2.Rows(i).Cells("item").Value = False
                End If
                i = i + 1
            End While
            'ahora solo tildo el actual
            DataGridView2.CurrentRow.Cells("item").Value = True
            'End If
        End If
    End Sub

    Private Sub DataGridView2_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView2.EditingControlShowing

        'referencia a la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregar el controlador de eventos para el keypress
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub

    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True 'bloqueo todo ingreso en primera instancia
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False 'aqui habilito si es numero
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False 'aqui habilito si es una operacion de control como "borrar"
        End If

        Dim caracter As Char = e.KeyChar
        '        'referencia a la celda
        Dim txt As TextBox = CType(sender, TextBox)
        'aqui pongo el codigo para remplazar el punto por una coma
        If txt.ToString() = "." Then
            txt.Text = ","
        End If
        If caracter.ToString() = "." Then
            caracter = ","
        End If
        'comprobar si el caracter es un número o el retroceso, si el caracter es un separador decimal y que no contiene ya el separador
        If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then
            e.KeyChar = caracter
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub BO_producto_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_producto_nuevo.Click
        Ajuste_alta.Close()
        Ajuste_alta.sucursal_id = sucursal_id
        Ajuste_alta.codinterno = CInt(txt_codigo.Text)

        Ajuste_alta.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'VALIDAR QUE ESTE ALGO CHEQUEADO EN EL GRIDVIEW
        Dim valido_seleccion As String = "no"
        If DataGridView2.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView2.Rows.Count
                If DataGridView2.Rows(i).Cells("Item").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    valido_seleccion = "si"

                    Dim item As Decimal = DataGridView2.CurrentRow.Index




                    'aqui abro el formulario donde voy a hacer los ajustes
                    Ajuste_suma_resta_igual.Close()
                    Ajuste_suma_resta_igual.txt_nrolote.Text = DataGridView2.Rows(i).Cells("LotenroDataGridViewTextBoxColumn").Value
                    Ajuste_suma_resta_igual.tb_cant_actual.Text = DataGridView2.Rows(i).Cells("LotecantidadDataGridViewTextBoxColumn").Value

                    'parametros necesarios para guardar en bd
                    Ajuste_suma_resta_igual.sucursal_id = sucursal_id
                    Ajuste_suma_resta_igual.proveedor_id = DataGridView2.Rows(i).Cells("ProvidDataGridViewTextBoxColumn").Value
                    Ajuste_suma_resta_igual.codinterno = CInt(txt_codigo.Text)
                    'Ajuste_suma_resta_igual.Vence = DataGridView2.Rows(i).Cells("LotevenceDataGridViewTextBoxColumn").Value
                    'Ajuste_suma_resta_igual.fechafabricacion = DataGridView2.Rows(i).Cells("LotefechafabDataGridViewTextBoxColumn").Value
                    'Ajuste_suma_resta_igual.fechavencimiento = DataGridView2.Rows(i).Cells("LotefechavtoDataGridViewTextBoxColumn").Value



                    Ajuste_suma_resta_igual.Show()


                    Exit While


                Else
                i = i + 1
                End If

            End While

            If valido_seleccion = "no" Then
                MessageBox.Show("Debe seleccinar un lote para realizar un ajuste.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            
        Else
            MessageBox.Show("No hay lotes en el listado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'VALIDAR QUE ESTE ALGO CHEQUEADO EN EL GRIDVIEW
        Dim valido_seleccion As String = "no"
        If DataGridView2.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView2.Rows.Count
                If DataGridView2.Rows(i).Cells("Item").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    valido_seleccion = "si"

                    Dim item As Decimal = DataGridView2.CurrentRow.Index

                    Ajuste_vencimiento.Close()
                    Ajuste_vencimiento.lote_id = DataGridView2.Rows(i).Cells("LoteidDataGridViewTextBoxColumn").Value
                    Ajuste_vencimiento.txt_nrolote.Text = DataGridView2.Rows(i).Cells("LotenroDataGridViewTextBoxColumn").Value
                    Ajuste_vencimiento.codinterno = CInt(txt_codigo.Text)
                    If DataGridView2.Rows(i).Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                        Ajuste_vencimiento.DateTimePicker_fvencimiento.Value = DataGridView2.Rows(i).Cells("LotefechavtoDataGridViewTextBoxColumn").Value
                        Ajuste_vencimiento.DateTimePicker_ffabricacion.Value = DataGridView2.Rows(i).Cells("LotefechafabDataGridViewTextBoxColumn").Value
                    End If
                    Ajuste_vencimiento.vence = DataGridView2.Rows(i).Cells("LotevenceDataGridViewTextBoxColumn").Value
                    Ajuste_vencimiento.Show()

                    Exit While


                Else
                    i = i + 1
                End If

            End While

            If valido_seleccion = "no" Then
                MessageBox.Show("Debe seleccinar un lote para editar el vencimiento.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Else
            MessageBox.Show("No hay lotes en el listado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Public Sub cargar_modificacion_en_gridview()

        'recupero info del producto
        Dim ds_info As DataSet = DAprod.Producto_x_sucursal_buscarcod(CInt(CInt(txt_codigo.Text)), sucursal_id)

        'If tipo_op = "MODIFICACION" Then
        'como es una modificacion lo que tengo que hacer es buscar en el dataset 
        Dim i As Integer = 0
        While i < Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows.Count
            If Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("prod_codinterno") = CInt(txt_codigo.Text) Then
                'Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("prod_descripcion") = tx_descripcion.Text 'string
                'Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("prod_precio_vta") = CDec(Tb_PrecMin.Text) 'decimal
                'Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("prod_ptorepo") = CInt(tx_ptorepo.Text) 'int
                'Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("prod_precio_vta_May") = CDec(tb_PrecMay.Text) 'decimal
                Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("ProdxSuc_stock") = ds_info.Tables(0).Rows(0).Item("ProdxSuc_stock") 'decimal
                'Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("prod_codbarra") = tx_codbarra.Text 'string
                'Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("Contenido") = txt_contenido.Text + " " + Combo_unidmedida.Text 'string contenido+unid medida
                Producto_modificar.Producto_ds.Tables("ProdxSuc").Rows(i).Item("Contenido_total") = CStr(ds_info.Tables(0).Rows(0).Item("ProdxSuc_stock_real")) + " " + unidad_medida 'string contenido total +unid medida
                Exit While
            End If
            i = i + 1
        End While
        'End If

    End Sub

End Class