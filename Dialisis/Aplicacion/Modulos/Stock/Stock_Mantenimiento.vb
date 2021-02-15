Public Class Stock_Mantenimiento
    Dim DAproducto As New Datos.Producto
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("ESPERA CHOCO, HAY CORRECCIONES Q HACER: ADEMAS DEL STOCK TENGO Q REINICIAR STOCK REAL. Esta seguro que quiere poner en 0 todo el stock de la sucursal: " + Producto_modificar.cb_origen.Text + "?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            'aqui borro
            'tengo q recorrer el gridview

            'primero borro todo en la tabla Producto_x_sucursal

            DAproducto.Producto_x_sucursal_borrar_cant_stock(Producto_modificar.cb_origen.SelectedValue)

            If Producto_modificar.DG_Producto.Rows.Count <> 0 Then
                Dim i As Integer = 0
                While i < Producto_modificar.DG_Producto.Rows.Count
                    Dim id_producto As Integer = Producto_modificar.DG_Producto.Rows(i).Cells("prod_id").Value
                    Dim sucursal As Integer = Producto_modificar.cb_origen.SelectedValue
                    'aqui mando a la bd a borrar los lotes
                    DAproducto.Producto_x_sucursal_borrar_cant_lote(Producto_modificar.cb_origen.SelectedValue, id_producto)
                    i = i + 1
                End While
                Producto_modificar.Cargar_grilla("") 'ojo con este parametro no tiene q ir vacio
                MessageBox.Show("Los datos se actualizaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No hay productos en la sucursal.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("ESPERA CHOCO, TIENES QUE PONER EN 0 TAMBIEN EL STOCK REAL. Esta seguro que quiere agregar los insumos del deposito a la sucursal DIALISIS DE CALLE? El stock inicial será CERO." + Producto_modificar.cb_origen.Text + "?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            'alta de producto con STOCK en 0.. en todas las sucursales.
            Dim a As Integer = 0
            While a < Producto_modificar.DG_Producto.Rows.Count
                Dim sucursal_id As Integer = 5 'la 5 es la sucursal dialisis_nueva
                Dim prodid As Integer = CInt(Producto_modificar.DG_Producto.Rows(a).Cells("prod_id").Value)
                DAproducto.Producto_x_sucursal_ALTA(prodid, sucursal_id, 0, 0, 0)
                a = a + 1
            End While
        End If
    End Sub

    Dim DAprod As New Datos.Producto
    Dim DAsucursal As New Datos.Sucursal
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'OJO ESTO NO ANDA



        ''primero lo hacemos en la sucursal Deposito
        'If MsgBox("Esta seguro de recalcular los totales de stock en la sucursal:" + Producto_modificar.cb_origen.Text + "?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
        '    Dim i As Integer = 0
        '    While i < Producto_modificar.DG_Producto.Rows.Count
        '        Dim prod_id As Integer = Producto_modificar.DG_Producto.Rows(i).Cells("prod_id").Value
        '        Dim total As Decimal = Producto_modificar.DG_Producto.Rows(i).Cells("ProdxSuc_stock").Value
        '        Dim Ds_Suc As DataSet = DAsucursal.Sucursal_obtener_producto(prod_id, Producto_modificar.cb_origen.SelectedValue, Producto_modificar.cb_origen.SelectedValue)
        '        Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * total
        '        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, Producto_modificar.cb_origen.SelectedValue, total, stock_real_ingreso)
        '        i = i + 1
        '    End While

        '    MessageBox.Show("DATOS ACTUALIZADOS")
        '    Producto_modificar.Cargar_grilla()
        'End If


    End Sub

    Dim DAVentas As New Datos.Venta
    Dim dalote As New Datos.Lote
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'RESUMEN: se pone en 1 el contenido y  la unidad de medida = UND en todos los productos. Ademas se recalcula los totales en los lotes de todas  las sucursales y ademas en la tabla producto_x_sucursal.


        '1) ---------------------------------------------------------------------------------------------------------------------------------------------------------
        'primero pongo en 1 el contenido y ademas en UND la unidad de medida de todos los productos, sin importar sucursal.
        'recupero todos los productos.
        Dim ds_prod As DataSet = DAVentas.Producto_x_Sucursal_obtener_todo(1) '1 es la sucursal del deposito
        Dim aa As Integer = 0
        While aa < ds_prod.Tables(0).Rows.Count 'ciclo y voy poniendo en 1 el contenido y unidad de medida en UND.
            Dim prod_codinterno As Integer = ds_prod.Tables(0).Rows(aa).Item("prod_codinterno")
            DAproducto.Producto_modificar_contenido_y_unidmedida(prod_codinterno, "UND", CDec(1))
            aa = aa + 1
        End While

        '2) ----------------------------------------------------------------------------------------------------------------------------------------------------------
        'realizo el calculo en cada sucursal para obtener lote_stock_real y lote_aux
        'necesito un listado de todas las sucursales.
        Dim ds_suc As DataSet = DAsucursal.Sucursal_obtener
        Dim i As Integer = 0
        While i < ds_suc.Tables(0).Rows.Count 'ciclo en todas las sucursales
            Dim sucursal_id As Integer = ds_suc.Tables(0).Rows(i).Item("sucursal_id")
            'voy actualizando primero los lotes.
            'ciclo por cada producto
            Dim j As Integer = 0
            While j < ds_prod.Tables(0).Rows.Count
                Dim prod_codinterno As Integer = ds_prod.Tables(0).Rows(j).Item("prod_codinterno")
                Dim prod_id As Integer = ds_prod.Tables(0).Rows(j).Item("prod_id")
                'tengo q recuperar los lotes en esa sucursal.
                Dim ds_lotes As DataSet = dalote.Producto_x_sucursal_lote_recuperartodos(prod_codinterno, sucursal_id)
                Dim k As Integer = 0
                While k < ds_lotes.Tables(2).Rows.Count
                    'aqui hago el calculo y actualizo lote_stock_real y lote_aux
                    Dim lote_nro As Integer = ds_lotes.Tables(2).Rows(k).Item("lote_nro")
                    Dim proveedor_id As Integer = ds_lotes.Tables(2).Rows(k).Item("Prov_id")
                    Dim cantidad As Decimal = CDec(ds_lotes.Tables(2).Rows(k).Item("lote_cantidad"))
                    Dim contenido As Decimal = CDec(1)
                    Dim lote_stock_real As Decimal = cantidad * contenido
                    Dim lote_aux As Decimal = CDec(0)
                    dalote.Producto_x_sucursal_lote_actualizar_igualar(lote_nro, prod_id, sucursal_id,
                                                                          cantidad, proveedor_id, lote_stock_real, lote_aux)

                    k = k + 1
                End While
                'ahora que termine con los lotes tengo que actualizar en la tabla Producto_x_sucursal el campo stock_real.
                'para ello debo sumar los lotes.
                recupero_y_recalculo_totales(prod_id, prod_codinterno, sucursal_id)
                j = j + 1
            End While
            i = i + 1
        End While

        MessageBox.Show("Manteminiento realizado correctamente.", "Sistema de Gestion.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub recupero_y_recalculo_totales(ByVal prod_id As Integer, ByVal codinterno As Integer, ByVal sucursal_id As Integer)
        Dim ds_lotes As DataSet = dalote.Producto_x_sucursal_lote_recuperartodos(codinterno, sucursal_id)
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        '1) ----------------------------------------------------------------------------------------------------------------------------------------------------------
        'realizo el calculo en LA SUCURSAL DIALISIS para obtener lote_stock_real y lote_aux
        'Dim ds_suc As DataSet = DAsucursal.Sucursal_obtener
        Dim ds_prod As DataSet = DAVentas.Producto_x_Sucursal_obtener_todo(1) '1 es la sucursal del deposito
        Dim i As Integer = 0
        'While i < ds_suc.Tables(0).Rows.Count 'ciclo en todas las sucursales
        Dim sucursal_id As Integer = 3 'dialisis es id 3 en la BD
        'voy actualizando primero los lotes.
        'ciclo por cada producto
        Dim j As Integer = 0
        While j < ds_prod.Tables(0).Rows.Count
            Dim prod_codinterno As Integer = ds_prod.Tables(0).Rows(j).Item("prod_codinterno")
            Dim prod_id As Integer = ds_prod.Tables(0).Rows(j).Item("prod_id")
            'tengo q recuperar los lotes en esa sucursal.
            Dim ds_lotes As DataSet = dalote.Producto_x_sucursal_lote_recuperartodos(prod_codinterno, sucursal_id)
            Dim k As Integer = 0
            While k < ds_lotes.Tables(0).Rows.Count
                'aqui hago el calculo y actualizo lote_stock_real y lote_aux
                Dim lote_nro As Integer = ds_lotes.Tables(0).Rows(k).Item("lote_nro")
                Dim proveedor_id As Integer = ds_lotes.Tables(0).Rows(k).Item("Prov_id")
                Dim cantidad As Decimal = CDec(0)
                Dim contenido As Decimal = CDec(1)
                Dim lote_stock_real As Decimal = cantidad * contenido
                Dim lote_aux As Decimal = CDec(0)
                dalote.Producto_x_sucursal_lote_actualizar_igualar(lote_nro, prod_id, sucursal_id,
                                                                      cantidad, proveedor_id, lote_stock_real, lote_aux)

                k = k + 1
            End While
            'ahora que termine con los lotes tengo que actualizar en la tabla Producto_x_sucursal el campo stock_real.
            'para ello debo sumar los lotes.
            recupero_y_recalculo_totales(prod_id, prod_codinterno, sucursal_id)
            j = j + 1
        End While
        'i = i + 1
        'End While
        MessageBox.Show("se actualizo el stock en 0 para la sucursal Dialisis, id 3", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class