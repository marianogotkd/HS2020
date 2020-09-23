Public Class Busqueda_CodBarra

    Private Sub Busqueda_CodBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then 'ESC para salir
            Me.Close()
        End If
    End Sub

    Private Sub Busqueda_CodBarra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_codbarra.Focus()
    End Sub




    Private Sub Buscar_y_cargar_en_grilla(ByVal cod_ingresado As String)
        Dim existe_en_grilla As String = "no"
        Dim Encontrado = "no" 'siempre por defecto, "IMPÒRTANTISIMO"
        Dim i As Integer = 0

        Select Case Venta_Caja_gestion.tipo_vta
            Case "Minorista"
                'AQUI SOLO BUSCO EN TABLA PRODUCTOS, NO EN PROMOCIONES
                While i < Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count 'la tabla 1 es para los prod comunes, no para los de la lista regular
                    Dim cod_interno As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    Dim cod_barra As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                    If cod_ingresado = cod_interno Or CStr(cod_ingresado) = cod_barra Then
                        Venta_Caja_gestion.buscar_en_grilla_y_sumar_mas_uno(cod_interno, existe_en_grilla)
                        If existe_en_grilla = "no" Then
                            Dim index As Integer = Venta_Caja_gestion.DataGridView1.Rows.Count - 1
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_item").Value = CInt(Venta_Caja_gestion.DataGridView1.Rows.Count)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_prod_id").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codinterno").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_descripcion").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_detalle").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_cantidad").Value = CInt(1)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_unitario").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta")
                            Dim total As Decimal = 0
                            total = CDec(Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta"))
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_subtotal").Value = CDec(total)   'CDec(Math.Round(total, 2)).ToString("N2")
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codbarra").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                            Venta_Caja_gestion.DataGridView1.Rows.Add() 'AGREGO UNO EXTRA PARA EL PROXIMO ITEM
                        End If
                        Encontrado = "si"
                        i = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count
                    End If
                    i = i + 1
                End While
            Case "Mayorista"
                'AQUI SOLO BUSCO EN TABLA PRODUCTOS, NO EN PROMOCIONES
                While i < Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count 'la tabla 1 es para los prod comunes, no para los de la lista regular
                    Dim cod_interno As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    Dim cod_barra As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                    If cod_ingresado = cod_interno Or CStr(cod_ingresado) = cod_barra Then
                        Venta_Caja_gestion.buscar_en_grilla_y_sumar_mas_uno(cod_interno, existe_en_grilla) 'aqui lo busco en gridview1 y sumo + 1 si ya existe en la grilla
                        If existe_en_grilla = "no" Then
                            Dim index As Integer = Venta_Caja_gestion.DataGridView1.Rows.Count - 1
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_item").Value = CInt(Venta_Caja_gestion.DataGridView1.Rows.Count)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_prod_id").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codinterno").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_descripcion").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_detalle").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_cantidad").Value = CInt(1)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_unitario").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta_May")
                            Dim total As Decimal = 0
                            total = CDec(Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta_May"))
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_subtotal").Value = CDec(total)   'CDec(Math.Round(total, 2)).ToString("N2")
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codbarra").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                            Venta_Caja_gestion.DataGridView1.Rows.Add() 'AGREGO UNO EXTRA PARA EL PROXIMO ITEM
                        End If
                        Encontrado = "si"
                        i = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count
                    End If
                    i = i + 1
                End While
        End Select
        'If Encontrado = "no" Then
        '    i = 0
        '    'Lo busco como promocion
        '    While i < VentaGestion_ds_PROMO.Tables(0).Rows.Count
        '        Dim cod_interno As String = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '        If cod_ingresado.ToString.ToUpper = cod_interno Then
        '            DataGridView1.CurrentRow.Cells("columna_item").Value = CInt(DataGridView1.CurrentRow.Index + 1)
        '            DataGridView1.CurrentRow.Cells("columna_prod_id").Value = " "
        '            DataGridView1.CurrentRow.Cells("columna_codinterno").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '            DataGridView1.CurrentRow.Cells("columna_descripcion").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
        '            DataGridView1.CurrentRow.Cells("columna_detalle").Value = " "
        '            DataGridView1.CurrentRow.Cells("columna_cantidad").Value = CInt(1)
        '            DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
        '            Dim total As Decimal = 0
        '            total = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
        '            DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(total) 'CDec(Math.Round(total, 2)).ToString("N2")
        '            DataGridView1.CurrentRow.Cells("columna_codbarra").Value = " "

        '            Encontrado = "si"
        '            i = VentaGestion_ds_PROMO.Tables(0).Rows.Count
        '        End If
        '        i = i + 1
        '    End While
        'End If
        'If Encontrado = "no" Then
        '    'buscar por codigo de barras
        '    MsgBox("No Existe el Producto")
        'Else
        '    calcular_totales()
        'End If
        Venta_Caja_gestion.calcular_totales()
        Venta_Caja_gestion.aplicar_iva()

        If Encontrado = "no" Then
            MessageBox.Show("No Existe el Producto", "Sistema de Gestión")
        End If
    End Sub

    Private Sub txt_codbarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_codbarra.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER calcula
            If CStr(txt_codbarra.Text) <> "" Then
                Buscar_y_cargar_en_grilla(txt_codbarra.Text)
                txt_codbarra.Clear()
            End If
        End If
    End Sub
End Class