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
                Producto_modificar.Cargar_grilla()
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
        'primero lo hacemos en la sucursal Deposito
        If MsgBox("Esta seguro de recalcular los totales de stock en la sucursal:" + Producto_modificar.cb_origen.Text + "?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            Dim i As Integer = 0
            While i < Producto_modificar.DG_Producto.Rows.Count
                Dim prod_id As Integer = Producto_modificar.DG_Producto.Rows(i).Cells("prod_id").Value
                Dim total As Decimal = Producto_modificar.DG_Producto.Rows(i).Cells("ProdxSuc_stock").Value
                Dim Ds_Suc As DataSet = DAsucursal.Sucursal_obtener_producto(prod_id, Producto_modificar.cb_origen.SelectedValue, Producto_modificar.cb_origen.SelectedValue)
                Dim stock_real_ingreso As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")) * total
                DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, Producto_modificar.cb_origen.SelectedValue, total, stock_real_ingreso)
                i = i + 1
            End While

            MessageBox.Show("DATOS ACTUALIZADOS")
            Producto_modificar.Cargar_grilla()
        End If


    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub
End Class