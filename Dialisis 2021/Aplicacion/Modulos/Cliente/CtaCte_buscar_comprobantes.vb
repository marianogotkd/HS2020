Public Class CtaCte_buscar_comprobantes

    Private Sub CtaCte_buscar_comprobantes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'con ESC cierro el formulario, cancelo operacion.
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Public ctacte_id As Integer
    Private Sub CtaCte_buscar_comprobantes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_facturas()
        recuperar_recibos()
    End Sub
    Dim DAventa As New Datos.Venta
    Dim DAcuentacorriente As New Datos.CuentaCorriente
    Public Sub recuperar_facturas()
        Dim ds_consultafactura As DataSet = DAventa.Factura_recuperar_todos_ctacte(ctacte_id)
        CtaCte_ds.Tables("Comprobantes").rows.clear()
        CtaCte_ds.Tables("Comprobantes").Merge(ds_consultafactura.Tables(0))
    End Sub

    Public Sub recuperar_recibos()
        Dim ds_consultarecibo As DataSet = DAcuentacorriente.Recibo_recuperar_todos_ctacte(ctacte_id)
        CtaCte_ds.Tables("Recibo").Rows.Clear()
        CtaCte_ds.Tables("Recibo").Merge(ds_consultarecibo.Tables(0))
    End Sub

    Private Sub Busqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Busqueda.KeyPress

        Dim unidades As Integer = ComprobantesBindingSource.Count

        Dim Filtro
        Filtro = String.Format("CONVERT(factura_id, System.String) LIKE '%{0}%'", Busqueda.Text)
        ComprobantesBindingSource.Filter = Filtro

        'Filtro = String.Format("{0} LIKE '%{1}%'", "Fantasia", Busqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
        ''Filtro = String.Format("CONVERT(Fantasia o Razón Social, System.String) LIKE '%{0}%'", Busqueda.Text)
        'RemitoBindingSource.Filter = Filtro
        'If DataGridView1.Rows.Count = 0 Then
        '    Filtro = String.Format("CONVERT(ctacte_id, System.String) LIKE '%{0}%'", Busqueda.Text)
        '    RemitoBindingSource.Filter = Filtro
        '    If DataGridView1.Rows.Count = 0 Then
        '        Filtro = String.Format("CONVERT(remito_id, System.String) LIKE '%{0}%'", Busqueda.Text)
        '        RemitoBindingSource.Filter = Filtro
        '    End If
        'End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim celda_actual = e.ColumnIndex

        If celda_actual = 0 Then 'la 0 es la que tiene el check
            Dim fila As Integer = DataGridView1.CurrentRow.Index
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If i <> fila Then
                    DataGridView1.Rows(i).Cells(0).Value = False
                End If
                i = i + 1
            End While
            DataGridView1.Rows(fila).Cells(0).Value = True
        End If
    End Sub

    Private Sub Button_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_imprimir.Click
        Dim encontrado = "no"
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells(0).Value = True Then
                encontrado = "si"
                If MessageBox.Show("Desea ver el reporte del Comprobante Nº: " + CStr(DataGridView1.Rows(i).Cells(1).Value) + "?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'aqui viene llamada a la rutina del reporte
                    Dim cliente_id As Integer = CInt(DataGridView1.Rows(i).Cells("CLIidDataGridViewTextBoxColumn").Value)
                    Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id)
                    Dim factura_id As Integer = CInt(DataGridView1.Rows(i).Cells("FacturaidDataGridViewTextBoxColumn").Value)
                    crear_reporte_comprobante(ds_usuario, factura_id, cliente_id)
                End If
                Exit While
            End If
            i = i + 1
        End While
        If encontrado = "no" Then
            MessageBox.Show("Error, Debe seleccionar un comprobante.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Dim DAcliente As New Datos.Cliente
    Dim facturacion_ds_report As New Facturacion_ds_report
    Private Sub crear_reporte_comprobante(ByVal ds_usuario As DataSet, ByVal numerofactura As Integer, ByVal cliente_id As Integer)
        'pregunto si quiero ver el reporte 
        'Dim result As DialogResult
        'result = MessageBox.Show("¿Desea ver el remito generado?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        'If result = DialogResult.OK Then
        'primero lleno el dataset y sus respectivas table
        '///////////////TABLA CLIENTE//////////////////////////////////'
        facturacion_ds_report.Tables("Cliente").Rows.Clear()
        Dim ds_cliente As DataSet = DAcliente.Cliente_obtener_info(cliente_id)
        Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
        row_cliente("fantasia") = ds_cliente.Tables(1).Rows(0).Item("CLI_Fan")
        row_cliente("dni") = ds_cliente.Tables(1).Rows(0).Item("CLI_dni")
        row_cliente("telefono") = ds_cliente.Tables(1).Rows(0).Item("CLI_tel")
        row_cliente("mail") = ds_cliente.Tables(1).Rows(0).Item("CLI_mail")
        row_cliente("direccion") = ds_cliente.Tables(1).Rows(0).Item("CLI_dir")
        row_cliente("localidad") = ds_cliente.Tables(1).Rows(0).Item("provincia") + ", " + ds_cliente.Tables(1).Rows(0).Item("Localidad")
        row_cliente("iva_condicion") = ds_cliente.Tables(0).Rows(0).Item("IVA_descripcion").ToString
        facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        '///////////////TABLA SUCURSAL//////////////////////////////////'
        Dim USU_ID As Integer = CInt(US_administrador.USU_id)
        Dim ds_suc As DataSet = DAventa.Obtener_usuario_y_sucursal(USU_ID)
        facturacion_ds_report.Tables("Sucursal").Rows.Clear()
        Dim row_sucursal As DataRow = facturacion_ds_report.Tables("Sucursal").NewRow()
        row_sucursal("sucursal") = ds_suc.Tables(0).Rows(0).Item("sucursal_nombre")
        row_sucursal("direccion") = ds_suc.Tables(0).Rows(0).Item("sucursal_direccion")
        row_sucursal("telefono") = ds_suc.Tables(0).Rows(0).Item("sucursal_telefono")
        row_sucursal("mail") = ds_suc.Tables(0).Rows(0).Item("sucursal_mail")
        row_sucursal("cuit") = "20 - 00000000 - 4"
        facturacion_ds_report.Tables("Sucursal").Rows.Add(row_sucursal)

        '///////////////TABLA EMPRESA//////////////////////////////////'
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            facturacion_ds_report.Tables("Empresa").Rows.Clear()
            facturacion_ds_report.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If

        'aqui traigo todo la info del remito y los productos
        Dim ds_factura As DataSet = DAventa.Factura_recuperar_productos(numerofactura)

        '///////////////TABLA VENTA//////////////////////////////////'
        facturacion_ds_report.Tables("venta").Rows.Clear()
        Dim row_venta As DataRow = facturacion_ds_report.Tables("venta").NewRow()
        'row_venta("nro_factura") = Venta_Caja_gestion.lb_factura_vta.Text
        'row_venta("nro_factura") = ventaprod_id
        row_venta("nro_factura") = CInt(numerofactura)
        row_venta("fecha") = ds_factura.Tables(0).Rows(0).Item("factura_fecha")
        row_venta("vendedor") = ""
        row_venta("tipo_venta") = ds_factura.Tables(0).Rows(0).Item("ventaprod_tipovta")
        facturacion_ds_report.Tables("venta").Rows.Add(row_venta)

        '///////////////TABLA TOTALES APLICADOS//////////////////////////////////'
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Clear()
        Dim row_totales As DataRow = facturacion_ds_report.Tables("Totales_aplicados").NewRow()
        row_totales("subtotal") = ds_factura.Tables(0).Rows(0).Item("ventaprod_subtotal")
        row_totales("total") = ds_factura.Tables(0).Rows(0).Item("ventaprod_total")
        row_totales("iva") = ds_factura.Tables(0).Rows(0).Item("ventaprod_iva_porcentaje")
        row_totales("descuento_porcentaje") = ds_factura.Tables(0).Rows(0).Item("ventaprod_descuento_porcentaje")
        row_totales("descuento_pesos") = ds_factura.Tables(0).Rows(0).Item("ventaprod_descuento_pesos")
        row_totales("iva_pesos") = ds_factura.Tables(0).Rows(0).Item("ventaprod_iva_pesos")
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)

        '///////////////TABLA PRODUCTO AGREGADO//////////////////////////////////'
        'aqui ciclo en la grilla para ir agrendo los row a la tabla producto agregado
        facturacion_ds_report.Tables("Producto_agregado").Rows.Clear()
        Dim i As Integer = 0
        While i < ds_factura.Tables(0).Rows.Count
            Dim row_prodADD As DataRow = facturacion_ds_report.Tables("Producto_agregado").NewRow()
            row_prodADD("PROD_id") = ""
            'row_prodADD("codinterno") = 
            row_prodADD("descripcion") = ds_factura.Tables(0).Rows(i).Item("ventaprod_descripcion")
            row_prodADD("detalle") = ds_factura.Tables(0).Rows(i).Item("prod_descrilarga")
            row_prodADD("cantidad") = CDec(ds_factura.Tables(0).Rows(i).Item("ventaprod_cant"))
            row_prodADD("precio_unitario") = CDec(ds_factura.Tables(0).Rows(i).Item("ventaprod_precio"))
            row_prodADD("precio_subtotal") = CDec(ds_factura.Tables(0).Rows(i).Item("producto_subtotal"))
            row_prodADD("codbarra") = ""
            row_prodADD("TURNO_id") = ""
            '/choco modificacion 01-12-2019: agrego columna descuento
            row_prodADD("descuento") = CDec(ds_factura.Tables(0).Rows(i).Item("ventaprod_descuento_porc"))
            row_prodADD("grupo_id") = CInt(1)
            facturacion_ds_report.Tables("Producto_agregado").Rows.Add(row_prodADD)
            i = i + 1
        End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Facturacion\Reportes\CR_comprobante.rpt")
        CrReport.Database.Tables("Cliente").SetDataSource(facturacion_ds_report.Tables("Cliente"))
        CrReport.Database.Tables("Sucursal").SetDataSource(facturacion_ds_report.Tables("Sucursal"))
        CrReport.Database.Tables("Empresa").SetDataSource(facturacion_ds_report.Tables("Empresa"))
        CrReport.Database.Tables("venta").SetDataSource(facturacion_ds_report.Tables("venta"))
        CrReport.Database.Tables("Producto_agregado").SetDataSource(facturacion_ds_report.Tables("Producto_agregado"))
        CrReport.Database.Tables("Totales_aplicados").SetDataSource(facturacion_ds_report.Tables("Totales_aplicados"))
        Dim factura_report As New Facturacion_report_show
        factura_report.CrystalReportViewer1.ReportSource = CrReport
        factura_report.Text = "Comprobante Nº: " + CStr(numerofactura) + " - Imprimir."
        factura_report.Show()
        'End If
    End Sub

    Private Sub busqueda_recibo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles busqueda_recibo.KeyPress
        Dim unidades As Integer = ReciboBindingSource.Count

        Dim Filtro
        Filtro = String.Format("CONVERT(recibo_id, System.String) LIKE '%{0}%'", busqueda_recibo.Text)
        ReciboBindingSource.Filter = Filtro
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim celda_actual = e.ColumnIndex

        If celda_actual = 0 Then 'la 0 es la que tiene el check
            Dim fila As Integer = DataGridView2.CurrentRow.Index
            Dim i As Integer = 0
            While i < DataGridView2.Rows.Count
                If i <> fila Then
                    DataGridView2.Rows(i).Cells(0).Value = False
                End If
                i = i + 1
            End While
            DataGridView2.Rows(fila).Cells(0).Value = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim encontrado = "no"
        Dim i As Integer = 0
        While i < DataGridView2.Rows.Count
            If DataGridView2.Rows(i).Cells(0).Value = True Then
                encontrado = "si"
                If MessageBox.Show("Desea ver el reporte del Recibo Nº: " + CStr(DataGridView2.Rows(i).Cells(1).Value) + "?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'aqui viene llamada a la rutina del reporte
                    Dim cliente_id As Integer = CInt(DataGridView2.Rows(i).Cells("CLI_id").Value)
                    Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id)
                    Dim recibo_id As Integer = CInt(DataGridView2.Rows(i).Cells("ReciboidDataGridViewTextBoxColumn").Value)
                    crear_reporte_recibo(ds_usuario, recibo_id, cliente_id)
                End If
                Exit While
            End If
            i = i + 1
        End While
        If encontrado = "no" Then
            MessageBox.Show("Error, Debe seleccionar un recibo.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub crear_reporte_recibo(ByVal ds_usuario As DataSet, ByVal numerofactura As Integer, ByVal cliente_id As Integer)
        Dim ds_recibo As DataSet = DAcuentacorriente.Recibo_obtener_reporte(numerofactura)
        '/////////TABLA CLIENTE///////////////////
        facturacion_ds_report.Tables("Cliente").Rows.Clear()
        'Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni((lb_dni_clie.Text))
        Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
        row_cliente("fantasia") = ds_recibo.Tables(0).Rows(0).Item("CLI_Fan")
        row_cliente("dni") = ""
        row_cliente("telefono") = ""
        row_cliente("mail") = ""
        row_cliente("direccion") = ""
        row_cliente("localidad") = ""
        row_cliente("iva_condicion") = ""
        row_cliente("cta_cte") = ds_recibo.Tables(0).Rows(0).Item("CtaCte_id")
        facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        '/////////////TABLA SUCURSAL///////////
        Dim USU_ID As Integer = CInt(US_administrador.USU_id)
        Dim ds_suc As DataSet = DAventa.Obtener_usuario_y_sucursal(USU_ID)
        facturacion_ds_report.Tables("Sucursal").Rows.Clear()
        Dim row_sucursal As DataRow = facturacion_ds_report.Tables("Sucursal").NewRow()
        row_sucursal("sucursal") = ds_suc.Tables(0).Rows(0).Item("sucursal_nombre")
        row_sucursal("direccion") = ds_suc.Tables(0).Rows(0).Item("sucursal_direccion")
        row_sucursal("telefono") = ds_suc.Tables(0).Rows(0).Item("sucursal_telefono")
        row_sucursal("mail") = ds_suc.Tables(0).Rows(0).Item("sucursal_mail")
        row_sucursal("cuit") = "20 - 00000000 - 4"
        facturacion_ds_report.Tables("Sucursal").Rows.Add(row_sucursal)
        '////////////////TABLA EMPRESA/////////////
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            facturacion_ds_report.Tables("Empresa").Rows.Clear()
            facturacion_ds_report.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If
        '////////////TABLA RECIBO////////////
        facturacion_ds_report.Tables("Recibo").Rows.Clear()
        Dim row_recibo As DataRow = facturacion_ds_report.Tables("Recibo").NewRow()
        row_recibo("pago") = ds_recibo.Tables(0).Rows(0).Item("MovimientosCtaCte_monto")
        row_recibo("saldo_adeudado") = CDec(0)
        row_recibo("recibo_id") = ds_recibo.Tables(0).Rows(0).Item("recibo_id")
        row_recibo("fecha") = ds_recibo.Tables(0).Rows(0).Item("recibo_fecha")
        facturacion_ds_report.Tables("Recibo").Rows.Add(row_recibo)
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Facturacion\Reportes\CR_recibo.rpt")
        CrReport.Database.Tables("Cliente").SetDataSource(facturacion_ds_report.Tables("Cliente"))
        CrReport.Database.Tables("Sucursal").SetDataSource(facturacion_ds_report.Tables("Sucursal"))
        CrReport.Database.Tables("Empresa").SetDataSource(facturacion_ds_report.Tables("Empresa"))
        CrReport.Database.Tables("Recibo").SetDataSource(facturacion_ds_report.Tables("Recibo"))
        Dim recibo_report As New Facturacion_report_show
        recibo_report.CrystalReportViewer1.ReportSource = CrReport
        recibo_report.Text = "Recibo Nº: " + CStr(numerofactura) + " - Imprimir."
        recibo_report.Show()
    End Sub
End Class