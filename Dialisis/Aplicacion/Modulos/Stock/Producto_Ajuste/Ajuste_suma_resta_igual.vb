Public Class Ajuste_suma_resta_igual
    Dim DAlote As New Datos.Lote
    Dim Validaciones As New Validaciones 'es una clase en la capa de aplicacion
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Public sucursal_id As Integer 'me la envia el formulario Producto_ajuste
    Public proveedor_id As Integer 'me la envia el formulario Producto_ajuste
    Dim ds_PROD As DataSet
    Dim DAprod As New Datos.Producto
    Dim DAsucursal As New Datos.Sucursal
    Public codinterno As Integer 'me la envia el formulario Producto_ajuste, es el codigo del producto, no lote
    Public Vence As String 'me la envia el formulario Producto_ajuste (es "si" o "no")
    Public fechafabricacion As Date 'me la envia el formulario Producto_ajuste
    Public fechavencimiento As Date 'me la envia el formulario Producto_ajuste

    Private Sub tb_nueva_cant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_nueva_cant.KeyPress
        If Producto_ajuste.tipo_producto = "Fraccionable" Then
            Dim tipo As String = "Decimal"
            Validaciones.Restricciones_textbox(e, tipo, tb_nueva_cant)
        Else
            'es no fraccionable
            Dim tipo As String = "Entero"
            Validaciones.Restricciones_textbox(e, tipo, tb_nueva_cant)

        End If


        
        'ahora con el enter hago el calculo, dependiendo lo que tenga en el combo de operacion

        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER calcula
            If tb_cant_actual.Text = "" Then
                tb_cant_actual.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
            If tb_nueva_cant.Text = "" Then
                tb_nueva_cant.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If
            If tb_resultado.Text = "" Then
                tb_resultado.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            End If

            tb_cant_actual.Text = (Math.Round(CDec(tb_cant_actual.Text), 2).ToString("N2"))
            tb_nueva_cant.Text = (Math.Round(CDec(tb_nueva_cant.Text), 2).ToString("N2"))
            tb_resultado.Text = (Math.Round(CDec(tb_resultado.Text), 2).ToString("N2"))

            'If cb_operacion.SelectedText = "SUMAR" Then
            '    'sumo
            '    Dim suma As Decimal = CDec(tb_cant_actual.Text) + CDec(tb_nueva_cant.Text)
            '    tb_resultado.Text = (Math.Round(CDec(suma), 2).ToString("N2"))
            'End If
            Select Case cb_operacion.Text
                Case "SUMAR"
                    'sumo
                    Dim suma As Decimal = CDec(tb_cant_actual.Text) + CDec(tb_nueva_cant.Text)
                    tb_resultado.Text = (Math.Round(CDec(suma), 2).ToString("N2"))
                Case "RESTAR"
                    'resto
                    Dim Resta As Decimal = CDec(tb_cant_actual.Text) - CDec(tb_nueva_cant.Text)
                    tb_resultado.Text = (Math.Round(CDec(Resta), 2).ToString("N2"))
                Case "IGUALAR"
                    'igualar o dicho de otra forma: modificar el valor de la cantidad
                    tb_resultado.Text = (Math.Round(CDec(tb_nueva_cant.Text), 2).ToString("N2"))
            End Select

        End If

    End Sub

    Private Sub tb_nueva_cant_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_nueva_cant.LostFocus
        If tb_cant_actual.Text = "" Then
            tb_cant_actual.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If
        If tb_nueva_cant.Text = "" Then
            tb_nueva_cant.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If
        If tb_resultado.Text = "" Then
            tb_resultado.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If

        tb_cant_actual.Text = (Math.Round(CDec(tb_cant_actual.Text), 2).ToString("N2"))
        tb_nueva_cant.Text = (Math.Round(CDec(tb_nueva_cant.Text), 2).ToString("N2"))
        tb_resultado.Text = (Math.Round(CDec(tb_resultado.Text), 2).ToString("N2"))

        'If cb_operacion.SelectedText = "SUMAR" Then
        '    'sumo
        '    Dim suma As Decimal = CDec(tb_cant_actual.Text) + CDec(tb_nueva_cant.Text)
        '    tb_resultado.Text = (Math.Round(CDec(suma), 2).ToString("N2"))
        'End If
        Select Case cb_operacion.Text
            Case "SUMAR"
                'sumo
                Dim suma As Decimal = CDec(tb_cant_actual.Text) + CDec(tb_nueva_cant.Text)
                tb_resultado.Text = (Math.Round(CDec(suma), 2).ToString("N2"))
            Case "RESTAR"
                'resto
                Dim Resta As Decimal = CDec(tb_cant_actual.Text) - CDec(tb_nueva_cant.Text)
                tb_resultado.Text = (Math.Round(CDec(Resta), 2).ToString("N2"))
            Case "IGUALAR"
                'igualar o dicho de otra forma: modificar el valor de la cantidad
                tb_resultado.Text = (Math.Round(CDec(tb_nueva_cant.Text), 2).ToString("N2"))
        End Select
    End Sub

    Private Sub cb_operacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_operacion.SelectedIndexChanged
        If tb_cant_actual.Text = "" Then
            tb_cant_actual.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If
        If tb_nueva_cant.Text = "" Then
            tb_nueva_cant.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If
        If tb_resultado.Text = "" Then
            tb_resultado.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If

        tb_cant_actual.Text = (Math.Round(CDec(tb_cant_actual.Text), 2).ToString("N2"))
        tb_nueva_cant.Text = (Math.Round(CDec(tb_nueva_cant.Text), 2).ToString("N2"))
        tb_resultado.Text = (Math.Round(CDec(tb_resultado.Text), 2).ToString("N2"))

        'If cb_operacion.SelectedText = "SUMAR" Then
        '    'sumo
        '    Dim suma As Decimal = CDec(tb_cant_actual.Text) + CDec(tb_nueva_cant.Text)
        '    tb_resultado.Text = (Math.Round(CDec(suma), 2).ToString("N2"))
        'End If
        Dim var As String = cb_operacion.Text
        Select Case cb_operacion.Text
            Case "SUMAR"
                'sumo
                Dim suma As Decimal = CDec(tb_cant_actual.Text) + CDec(tb_nueva_cant.Text)
                tb_resultado.Text = (Math.Round(CDec(suma), 2).ToString("N2"))
            Case "RESTAR"
                'resto
                Dim Resta As Decimal = CDec(tb_cant_actual.Text) - CDec(tb_nueva_cant.Text)
                tb_resultado.Text = (Math.Round(CDec(Resta), 2).ToString("N2"))
            Case "IGUALAR"
                'igualar o dicho de otra forma: modificar el valor de la cantidad
                tb_resultado.Text = (Math.Round(CDec(tb_nueva_cant.Text), 2).ToString("N2"))
        End Select
    End Sub

    Private Sub Ajuste_suma_resta_igual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'hacemos el primer calculo, que vendria a ser una suma
        If tb_cant_actual.Text = "" Then
            tb_cant_actual.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If
        If tb_nueva_cant.Text = "" Then
            tb_nueva_cant.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If
        If tb_resultado.Text = "" Then
            tb_resultado.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        End If

        tb_cant_actual.Text = (Math.Round(CDec(tb_cant_actual.Text), 2).ToString("N2"))
        tb_nueva_cant.Text = (Math.Round(CDec(tb_nueva_cant.Text), 2).ToString("N2"))
        tb_resultado.Text = (Math.Round(CDec(tb_resultado.Text), 2).ToString("N2"))

        'If cb_operacion.SelectedText = "SUMAR" Then
        '    'sumo
        '    Dim suma As Decimal = CDec(tb_cant_actual.Text) + CDec(tb_nueva_cant.Text)
        '    tb_resultado.Text = (Math.Round(CDec(suma), 2).ToString("N2"))
        'End If
        cb_operacion.Text = "SUMAR"
        Select Case cb_operacion.Text
            Case "SUMAR"
                'sumo
                Dim suma As Decimal = CDec(tb_cant_actual.Text) + CDec(tb_nueva_cant.Text)
                tb_resultado.Text = (Math.Round(CDec(suma), 2).ToString("N2"))
            Case "RESTAR"
                'resto
                Dim Resta As Decimal = CDec(tb_cant_actual.Text) - CDec(tb_nueva_cant.Text)
                tb_resultado.Text = (Math.Round(CDec(Resta), 2).ToString("N2"))
            Case "IGUALAR"
                'igualar o dicho de otra forma: modificar el valor de la cantidad
                tb_resultado.Text = (Math.Round(CDec(tb_nueva_cant.Text), 2).ToString("N2"))
        End Select


    End Sub

    Private Sub GUARDAR_SUMAR()
        Dim concepto As String = "Ajuste de Stock, Sumar."
        Dim tipo_mov As Integer = 4 'este tipo abarca todos los ajustes

        Dim lote_id As Integer
        'controlamos factura y remito
        Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, Today, Inicio.USU_id, sucursal_id, sucursal_id, "", Today, "", Today, tipo_mov, proveedor_id, 0, 0)
        ''''''''''''''''''''''''''''''''''''''''''''''''
        Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
        Dim i As Integer = 0

        '''''Actualizacion de Stock''''''''''''''''''''''''
        Dim Ds_Suc As DataSet
        'Dim Origen As Integer
        'Dim Destino As Integer
        Dim Mov As Decimal
        'Dim j As Integer = 0
        'While i < Mov_DS.Tables("Mov").Rows.Count
        ds_PROD = DAprod.Producto_buscarcod(codinterno)
        Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
        Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id)


        'Calculo Stock''''''''
        Mov = CDec(Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino")) + CDec(tb_nueva_cant.Text)
        ''''''
        Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * CDec(tb_nueva_cant.Text)
        'ahora sumo al stock real q ya existe.
        Dim stock_real_nuevo As Decimal = CDec(Ds_Suc.Tables(1).Rows(0).Item("ProdxSuc_stock_real")) + stock_real_ingreso


        ''''''''''

        'creo un registro en producto_x_sucursal_lote
        'CHOCO 14-07-2020 aqui veo si existe el lote, actualizo la cantidad, pero si no existe registro como nuevo
        Dim ds_lote_buscar As DataSet = DAlote.Lote_buscar_validar(sucursal_id, codinterno, txt_nrolote.Text, proveedor_id)
        If ds_lote_buscar.Tables(0).Rows.Count <> 0 Then
            'si existe actualizo
            

            Dim ds_lote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_suma(txt_nrolote.Text, prod_id, sucursal_id,
                                                                          CDec(tb_nueva_cant.Text), proveedor_id, stock_real_ingreso)
            lote_id = ds_lote.Tables(0).Rows(0).Item("lote_id")
        End If

        'Actualizo stock'''''
        recupero_y_recalculo_totales(prod_id)
        'DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, Mov, stock_real_nuevo)



        '''''' Alta Tabla Detalle'''''' de movimiento claro está
        'alta en tabla mercaderia_detalle_alta
        DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(CDec(tb_nueva_cant.Text), MovMer_id, codinterno, lote_id, CDec(0), CDec(0))
    End Sub

    Private Sub GUARDAR_RESTAR()
        Dim concepto As String = "Ajuste de Stock, Restar."
        Dim tipo_mov As Integer = 4 'este tipo abarca todos los ajustes

        Dim lote_id As Integer

        'controlamos factura y remito
        Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, Today, Inicio.USU_id, sucursal_id, sucursal_id, "", Today, "", Today, tipo_mov, proveedor_id, 0, 0)
        ''''''''''''''''''''''''''''''''''''''''''''''''
        Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)

        '''''Actualizacion de Stock''''''''''''''''''''''''
        Dim Ds_Suc As DataSet
        'Dim Origen As Integer
        'Dim Destino As Integer
        Dim Mov As Decimal
        'Dim j As Integer = 0
        'While i < Mov_DS.Tables("Mov").Rows.Count
        ds_PROD = DAprod.Producto_buscarcod(codinterno)
        Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
        Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id)

        'Calculo Stock''''''''
        Mov = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - CDec(tb_nueva_cant.Text)
        '''''''

        Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * CDec(tb_nueva_cant.Text)
        'ahora sumo al stock real q ya existe.
        Dim stock_real_nuevo As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("ProdxSuc_stock_real")) - stock_real_ingreso


        ''''''''''
        'Actualizo stock''''' no quito el registro del producto en la sucursal, en realidad lo que hago es actualizar su cantidad a 0. OJO No tiene que hacerse negativo.
        recupero_y_recalculo_totales(prod_id)

        'DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, Mov, stock_real_nuevo) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
        '''''''''''


        '////////////////choco: 08-07-2020///////////////////////////////////
        'actualizo la cant en el lote asociado a un producto de una sucursal.
        Dim lote_nro As String = txt_nrolote.Text
        Dim cant_a_quitar As Decimal = CDec(tb_nueva_cant.Text)
        'Dim Prov_id As Integer = Mov_DS.Tables("Mov").Rows(i).Item("Prov_id")
        Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, sucursal_id, cant_a_quitar, proveedor_id, stock_real_ingreso, CDec(0))

        lote_id = dslote.Tables(0).Rows(0).Item("lote_id")


        ''''''''''
        'Actualizo stock''''' no quito el registro del producto en la sucursal, en realidad lo que hago es actualizar su cantidad a 0. OJO No tiene que hacerse negativo.
        recupero_y_recalculo_totales(prod_id)

        'DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, Mov, stock_real_nuevo) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
        '''''''''''



        '''''' Alta Tabla Detalle'''''' de movimiento claro está
        'alta en tabla mercaderia_detalle_alta
        DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(CDec(tb_nueva_cant.Text), MovMer_id, codinterno, lote_id, CDec(0), CDec(0))

    End Sub

    Private Sub GUARDAR_IGUALAR()
        Dim concepto As String = "Ajuste de Stock, Igualar."
        Dim tipo_mov As Integer = 4 'este tipo abarca todos los ajustes

        Dim lote_id As Integer
        'controlamos factura y remito
        Dim ds_movid As DataSet = DAMovintoMer.Movimiento_Mercaderia_alta3(concepto, Today, Inicio.USU_id, sucursal_id, sucursal_id, "", Today, "", Today, tipo_mov, proveedor_id, 0, 0)
        ''''''''''''''''''''''''''''''''''''''''''''''''
        Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
        Dim i As Integer = 0

        '''''Actualizacion de Stock''''''''''''''''''''''''
        Dim Ds_Suc As DataSet
        'Dim Origen As Integer
        'Dim Destino As Integer
        Dim Mov As Decimal
        'Dim j As Integer = 0
        'While i < Mov_DS.Tables("Mov").Rows.Count
        ds_PROD = DAprod.Producto_buscarcod(codinterno)
        Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
        Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id)


        'Calculo Stock''''''''
        'primero resto lo que habia en existencia del lote
        Mov = CDec(Ds_Suc.Tables(1).Rows(0).Item("Stock_Destino")) - CDec(tb_cant_actual.Text)
        'segundo, sumo lo que quiero poner ahora
        Mov = CDec(Mov) + CDec(tb_nueva_cant.Text)
        ''''''

        Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * CDec(tb_cant_actual.Text)
        'primero resto lo que habia en existencia del lote
        Dim stock_real_nuevo As Decimal = CDec(Ds_Suc.Tables(1).Rows(0).Item("ProdxSuc_stock_real")) - stock_real_ingreso
        'segundo, sumo lo que quiero poner ahora
        stock_real_ingreso = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * CDec(tb_nueva_cant.Text)
        stock_real_nuevo = stock_real_nuevo + stock_real_ingreso



        'DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, Mov, stock_real_nuevo)

        'creo un registro en producto_x_sucursal_lote
        'CHOCO 14-07-2020 aqui veo si existe el lote, actualizo la cantidad, pero si no existe registro como nuevo
        Dim ds_lote_buscar As DataSet = DAlote.Lote_buscar_validar(sucursal_id, codinterno, txt_nrolote.Text, proveedor_id)
        If ds_lote_buscar.Tables(0).Rows.Count <> 0 Then
            'si existe actualizo


            Dim ds_lote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_igualar(txt_nrolote.Text, prod_id, sucursal_id,
                                                                          CDec(tb_nueva_cant.Text), proveedor_id, stock_real_ingreso, CDec(0))
            lote_id = ds_lote.Tables(0).Rows(0).Item("lote_id")
        End If


        ''''''''''
        'Actualizo stock'''''
        recupero_y_recalculo_totales(prod_id)


        '''''' Alta Tabla Detalle'''''' de movimiento claro está
        'alta en tabla mercaderia_detalle_alta
        DAMovintoMer.Movimiento_Mercaderia_Detalle_alta(CDec(tb_nueva_cant.Text), MovMer_id, codinterno, lote_id, CDec(0), CDec(0))
    End Sub


    Private Sub recupero_y_recalculo_totales(ByVal prod_id As Integer)
        Dim ds_lotes As DataSet = DAlote.Producto_x_sucursal_lote_recuperartodos(codinterno, sucursal_id)
        Dim stock As Decimal = 0
        Dim stock_real As Decimal = 0
        Dim i As Integer = 0
        While i < ds_lotes.Tables(0).Rows.Count
            stock = stock + CInt(ds_lotes.Tables(0).Rows(i).Item("lote_cantidad"))
            stock_real = stock_real + CInt(ds_lotes.Tables(0).Rows(i).Item("lote_stock_real"))

            i = i + 1
        End While
        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, stock, stock_real)

    End Sub

    Private Sub btn_agregarr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregarr.Click

        Dim result As Integer = MessageBox.Show("¿Esta seguro que desea aplicar los cambios?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Select Case cb_operacion.Text
                Case "SUMAR"
                    GUARDAR_SUMAR()
                Case "RESTAR"
                    GUARDAR_RESTAR()
                Case "IGUALAR"
                    GUARDAR_IGUALAR()


            End Select
            'ahora reflejo los cambios en el formulario Producto_ajuste
            Producto_ajuste.recuperar_lotes()
            Producto_ajuste.calcular_total()
            Producto_ajuste.cargar_modificacion_en_gridview() 'se reflejan los cambios en el gridview de producto_modificar
            MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If

    End Sub
End Class