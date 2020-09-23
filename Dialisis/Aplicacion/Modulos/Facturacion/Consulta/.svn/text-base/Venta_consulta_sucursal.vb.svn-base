Public Class Venta_consulta_sucursal
    Public sucursal_id As Integer = 0
    Public sucursal_nombre As String
    Dim DAventa As New Datos.Venta
    Dim DAcaja As New Datos.Caja
    Dim DAusuario As New Datos.Usuario
    Dim inicio As String = "no"
    Dim facturacion_ds_report As New Facturacion_ds_report
    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click

        buscar_ventas("busqueda")

    End Sub

    'Private Sub buscar_cajas(ByVal var_inicial As String)
    '    Dim ds_caja As DataSet = DAcaja.Caja_consultar_caja_sucursal(sucursal_id, DateTimePicker_caja_desde.Value, DateTimePicker_caja_hasta.Value)

    '    If ds_caja.Tables(0).Rows.Count <> 0 Then
    '        DG_caja.DataSource = ds_caja.Tables(0)
    '        GroupBox4.Text = "Caja desde : " + DateTimePicker_caja_desde.Text + " hasta el: " + DateTimePicker_caja_hasta.Text
    '    Else
    '        GroupBox4.Text = "Registro de Caja"
    '        DG_caja.DataSource = ""
    '        If var_inicial <> "load" Then
    '            MessageBox.Show("no hay registro de caja para el rango de fecha.", "Sistema de Gestión")
    '        End If
    '    End If
    'End Sub

    Private Sub buscar_ventas(ByVal var_inicial As String)
        Dim ds_ventas As DataSet = DAventa.Venta_consultar_recaudacion_sucursal(DateTimePicker_desde.Value, DateTimePicker_hasta.Value, sucursal_id)

        If ds_ventas.Tables(0).Rows.Count <> 0 Then
            DG_ventas.DataSource = ds_ventas.Tables(0)
            GroupBox1.Text = "Ventas desde : " + DateTimePicker_desde.Text + " hasta el: " + DateTimePicker_hasta.Text
        Else
            GroupBox1.Text = "Ventas registradas"
            DG_ventas.DataSource = ""
            If var_inicial <> "load" Then
                MessageBox.Show("no hay ventas registradas para el rango de fecha.", "Sistema de Gestión")
            End If
        End If
    End Sub

    Private Sub Venta_consulta_sucursal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds_usuario As DataSet = DAusuario.Usuario_obtener_x_sucursal(sucursal_id)
        If ds_usuario.Tables(0).Rows.Count <> 0 Then
            ComboBox_usuarios.DataSource = ds_usuario.Tables(0)
            ComboBox_usuarios.DisplayMember = "apellidoynombre"
            ComboBox_usuarios.ValueMember = "USU_id"
        End If
        inicio = "si" 'esta variable la uso, x q el evento checkedchanged del buton 2 se dispara antes del load
        Label_suc.Text = sucursal_nombre
        ' Label_suc_2.Text = sucursal_nombre

        buscar_ventas("load") 'llamo a esta rutina asi de entrada me muestre las ventas del dia actual
        ' buscar_cajas("load") 'llamo a esta rutina asi de entrada me muestre las cajas del dia actual
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        aplicar_filtro()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True And inicio = "si" Then
            buscar_ventas("busqueda")
        End If

    End Sub

    Private Sub ComboBox_usuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_usuarios.SelectedIndexChanged
        aplicar_filtro()
    End Sub

    Private Sub aplicar_filtro()
        If RadioButton1.Checked = True Then
            'llamo a la rutina para filtar, tomando como parametros los datos de las fechas desde, hasta
            Dim ds_ventas As DataSet = DAventa.Venta_consultar_recaudacion_sucursal_x_usuario(DateTimePicker_desde.Value, DateTimePicker_hasta.Value, sucursal_id, CInt(ComboBox_usuarios.SelectedValue))
            If ds_ventas.Tables(0).Rows.Count <> 0 Then
                DG_ventas.DataSource = ds_ventas.Tables(0)
                GroupBox1.Text = "Ventas desde " + DateTimePicker_desde.Text + " hasta el " + DateTimePicker_hasta.Text
            Else
                GroupBox1.Text = "Ventas registradas"
                DG_ventas.DataSource = ""
                MsgBox("no hay ventas registradas para el rango de fecha")
            End If
        End If
    End Sub

    Private Sub Button_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub crear_reporte(ByVal ventaprod_id As Integer)
        limbiar_datos_del_reporte() 'esto lo hago porque cuando intento abrir varios reportes se juntan todos los datos, los de la nueva consulta con la anterior

        '1) cargo todos los datos en un ds
        Dim ds_venta As DataSet = DAventa.Venta_consultar_detalle_venta(ventaprod_id, sucursal_id)


        '///////////////TABLA CLIENTE//////////////////////////////////'
        If ds_venta.Tables(0).Rows.Count <> 0 Then 'la tabla es la que tiene asociado venta a un cliente, si el cliente es consumidor final, entonces esta tabla esta vacia
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
            row_cliente("fantasia") = ds_venta.Tables(0).Rows(0).Item("fantasia")
            row_cliente("dni") = ds_venta.Tables(0).Rows(0).Item("DNI")
            row_cliente("telefono") = ds_venta.Tables(0).Rows(0).Item("telefono")
            row_cliente("mail") = ds_venta.Tables(0).Rows(0).Item("mail")
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        Else
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
            row_cliente("fantasia") = "- - - -"
            row_cliente("dni") = "- - - -"
            row_cliente("telefono") = "- - - -"
            row_cliente("mail") = "- - - -"
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        End If

        '///////////////TABLA SUCURSAL//////////////////////////////////'
        Dim row_sucursal As DataRow = facturacion_ds_report.Tables("Sucursal").NewRow()
        row_sucursal("sucursal") = ds_venta.Tables(3).Rows(0).Item("sucursal")
        row_sucursal("direccion") = ds_venta.Tables(3).Rows(0).Item("direccion")
        row_sucursal("telefono") = ds_venta.Tables(3).Rows(0).Item("telefono")
        row_sucursal("mail") = ds_venta.Tables(3).Rows(0).Item("mail")
        row_sucursal("cuit") = "20 - 32547904 - 4"
        facturacion_ds_report.Tables("Sucursal").Rows.Add(row_sucursal)

        '///////////////TABLA EMPRESA//////////////////////////////////'
        If ds_venta.Tables(4).Rows.Count <> 0 Then
            facturacion_ds_report.Tables("Empresa").Merge(ds_venta.Tables(4))
        End If



        '///////////////TABLA VENTA//////////////////////////////////'
        'pregunto por el estado de los table 0 y 1, si 0 esta vacio, los datos estan en table 1, q es consumidor final

        If ds_venta.Tables(0).Rows.Count <> 0 Then
            Dim row_venta As DataRow = facturacion_ds_report.Tables("venta").NewRow()
            row_venta("nro_factura") = ds_venta.Tables(0).Rows(0).Item("ventaprod_id")
            row_venta("fecha") = ds_venta.Tables(0).Rows(0).Item("fecha")
            row_venta("vendedor") = ds_venta.Tables(0).Rows(0).Item("vendedor")
            row_venta("tipo_venta") = ds_venta.Tables(0).Rows(0).Item("ventaprod_tipovta")
            facturacion_ds_report.Tables("venta").Rows.Add(row_venta)
        Else
            'esta en tabla 1, es consumidor final
            Dim row_venta As DataRow = facturacion_ds_report.Tables("venta").NewRow()
            row_venta("nro_factura") = ds_venta.Tables(1).Rows(0).Item("ventaprod_id")
            row_venta("fecha") = ds_venta.Tables(1).Rows(0).Item("fecha")
            row_venta("vendedor") = ds_venta.Tables(1).Rows(0).Item("vendedor")
            row_venta("tipo_venta") = ds_venta.Tables(1).Rows(0).Item("ventaprod_tipovta")
            facturacion_ds_report.Tables("venta").Rows.Add(row_venta)
        End If

        

        '///////////////TABLA TOTALES APLICADOS//////////////////////////////////'
        'pregunto por el estado de los table 0 y 1, si 0 esta vacio, los datos estan en table 1, q es consumidor final

        If ds_venta.Tables(0).Rows.Count <> 0 Then
            Dim row_totales As DataRow = facturacion_ds_report.Tables("Totales_aplicados").NewRow()
            row_totales("subtotal") = ds_venta.Tables(0).Rows(0).Item("ventaprod_subtotal")
            row_totales("total") = ds_venta.Tables(0).Rows(0).Item("ventaprod_total")
            row_totales("iva") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_iva_porcentaje"))
            row_totales("descuento_porcentaje") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_descuento_porcentaje"))
            row_totales("descuento_pesos") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_descuento_pesos"))
            row_totales("iva_pesos") = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_iva_pesos"))
            facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)
        Else
            Dim row_totales As DataRow = facturacion_ds_report.Tables("Totales_aplicados").NewRow()
            row_totales("subtotal") = ds_venta.Tables(1).Rows(0).Item("ventaprod_subtotal")
            row_totales("total") = ds_venta.Tables(1).Rows(0).Item("ventaprod_total")
            row_totales("iva") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_iva_porcentaje"))
            row_totales("descuento_porcentaje") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_descuento_porcentaje"))
            row_totales("descuento_pesos") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_descuento_pesos"))
            row_totales("iva_pesos") = CDec(ds_venta.Tables(1).Rows(0).Item("ventaprod_iva_pesos"))
            facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)
        End If
        

        '///////////////TABLA PRODUCTO AGREGADO//////////////////////////////////'
        'aqui ciclo en la grilla para ir agrendo los row a la tabla producto agregado
        Dim i As Integer = 0
        While i < ds_venta.Tables(2).Rows.Count
            Dim row_prodADD As DataRow = facturacion_ds_report.Tables("Producto_agregado").NewRow()
            row_prodADD("PROD_id") = ds_venta.Tables(2).Rows(i).Item("prod_id")
            row_prodADD("codinterno") = CInt(ds_venta.Tables(2).Rows(i).Item("prod_codinterno"))
            row_prodADD("descripcion") = ds_venta.Tables(2).Rows(i).Item("ventaprod_descripcion")
            row_prodADD("detalle") = ds_venta.Tables(2).Rows(i).Item("prod_descrilarga")
            row_prodADD("cantidad") = CInt(ds_venta.Tables(2).Rows(i).Item("ventaprod_cant"))
            row_prodADD("precio_unitario") = CDec(ds_venta.Tables(2).Rows(i).Item("ventaprod_precio"))
            row_prodADD("precio_subtotal") = CDec(ds_venta.Tables(2).Rows(i).Item("ventaprod_subtotal"))
            row_prodADD("codbarra") = ""
            row_prodADD("TURNO_id") = ""
            facturacion_ds_report.Tables("Producto_agregado").Rows.Add(row_prodADD)
            i = i + 1
        End While


        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Facturacion\Reportes\CR_comprobante_x.rpt")
        CrReport.Database.Tables("Cliente").SetDataSource(facturacion_ds_report.Tables("Cliente"))
        CrReport.Database.Tables("Sucursal").SetDataSource(facturacion_ds_report.Tables("Sucursal"))
        CrReport.Database.Tables("Empresa").SetDataSource(facturacion_ds_report.Tables("Empresa"))
        CrReport.Database.Tables("venta").SetDataSource(facturacion_ds_report.Tables("venta"))
        CrReport.Database.Tables("Producto_agregado").SetDataSource(facturacion_ds_report.Tables("Producto_agregado"))
        CrReport.Database.Tables("Totales_aplicados").SetDataSource(facturacion_ds_report.Tables("Totales_aplicados"))
        Facturacion_report_show.CrystalReportViewer1.ReportSource = CrReport
        Facturacion_report_show.Show()

    End Sub
    Private Sub limbiar_datos_del_reporte()
        facturacion_ds_report.Tables("Cliente").Rows.Clear()
        facturacion_ds_report.Tables("Sucursal").Rows.Clear()
        facturacion_ds_report.Tables("Empresa").Rows.Clear()
        facturacion_ds_report.Tables("venta").Rows.Clear()
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Clear()
        facturacion_ds_report.Tables("Producto_agregado").Rows.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Venta_consulta_seleccionar_sucursal.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  buscar_cajas("busqueda")
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DG_ventas.Rows.Count <> 0 Then

            If DG_ventas.CurrentRow.Cells("VentaprodobservacionDataGridViewTextBoxColumn").Value = "Servicio" Then
                Dim ventaprod_id As Integer = CInt(DG_ventas.CurrentRow.Cells("VentaprodidColumn").Value)
                Venta_detalle_servicio.ventaprod_id = ventaprod_id
                Venta_detalle_servicio.Show()
            Else
                'tomo valor de la fila seleccionada y recupero de la BD el detalle para mostrarlo en un reporte
                Dim ventaprod_id As Integer = CInt(DG_ventas.CurrentRow.Cells("VentaprodidColumn").Value)


                Venta_detalle.ventaprod_id = ventaprod_id
                Venta_detalle.sucursal_id = sucursal_id
                Venta_detalle.Show()
            End If

            

            Me.Close()
            'crear_reporte(ventaprod_id)
        End If
    End Sub
End Class