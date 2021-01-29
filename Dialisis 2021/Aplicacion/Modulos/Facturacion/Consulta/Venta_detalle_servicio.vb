Public Class Venta_detalle_servicio
    Dim DAservicio As New Datos.Servicio
    Public ventaprod_id As Integer

    Private Sub Cargar_Datos()
        Dim Ds_servicio As DataSet = DAservicio.Servicio_detalle_venta(ventaprod_id)
        If Ds_servicio.Tables(0).Rows.Count <> 0 Then
            lb_servicionro.Text = "Servicio Nº: " + CStr(Ds_servicio.Tables(0).Rows(0).Item("Servicio_id"))
            Lb_fecha.Text = "Fecha: " + CStr(Ds_servicio.Tables(0).Rows(0).Item("Servicio_fecha"))
            TextBox_id.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_imei").ToString
            TextBox_Marca.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_Marca").ToString
            TextBox_Modelo.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_Modelo").ToString
            TextBox_color.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_Color").ToString
            TextBox_bateria.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_bat").ToString
            'TextBox_obs.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Obs").ToString
            TextBox_manoobra.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_ManoObra").ToString
            'TextBox_Anticipo.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Anticipo").ToString
            'anticipo_recuperado = CDec(Ds_servicio.Tables(0).Rows(i).Item("Servicio_Anticipo").ToString)
            TextBox_nombre.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_Nombre").ToString
            TextBox_dni.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_dni").ToString
            TextBox_direccion.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_dir").ToString
            TextBox_telefono.Text = Ds_servicio.Tables(0).Rows(0).Item("Servicio_tel").ToString
            'Label_Estado.Text = Ds_servicio.Tables(0).Rows(i).Item("Servicio_Estado").ToString
            'Label_Estado.Visible = True
        End If

        ''''Cargo Productos del Servicio"""" USO TABLES(1)
        Servicio_DS.Tables("Servicio_Prod_DS").Clear()
        'DataGridView1.DataSource = Nothing
        Servicio_DS.Tables("Servicio_Prod_DS").Merge(Ds_servicio.Tables(1))
        'DataGridView1.DataSource = Ds_servicio.Tables(1)
        'i = 0
        'While i < Ds_servicio.Tables(1).Rows.Count
        '    DataGridView1.Rows.Add()
        '    DataGridView1.Rows(i).Cells("Cod_prod").Value = Ds_servicio.Tables(1).Rows(i).Item("prod_codinterno").ToString
        '    DataGridView1.Rows(i).Cells("Descripcion").Value = Ds_servicio.Tables(1).Rows(i).Item("prod_descripcion").ToString
        '    DataGridView1.Rows(i).Cells("Cantidad").Value = Ds_servicio.Tables(1).Rows(i).Item("Servicio_Producto_Cantidad").ToString
        '    DataGridView1.Rows(i).Cells("Costo").Value = Ds_servicio.Tables(1).Rows(i).Item("Servicio_Producto_Costo").ToString
        '    DataGridView1.Rows(i).Cells("Stock").Value = Ds_servicio.Tables(1).Rows(i).Item("ProdxSuc_stock").ToString
        '    i = i + 1
        'End While
        Calcular_Totales()
        'Bloquar_grupBox(Label_Estado.Text)
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
        TextBox_totalrepuesto.Text = (Math.Round(CDec(repuesto), 2).ToString("N2"))
        If TextBox_totalrepuesto.Text <> "" And TextBox_manoobra.Text <> "" Then
            total = repuesto + CDec(TextBox_manoobra.Text)
        End If
        TextBox_total.Text = (Math.Round(CDec(total), 2).ToString("N2"))
    End Sub

    Private Sub Venta_detalle_servicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_Datos()
    End Sub
End Class