Public Class Remito
    Dim DAventa As New Datos.Venta
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_nuevo.Click
        Venta_Caja_seleccion_tipo_vta.Show()
        Venta_Caja_seleccion_tipo_vta.procedencia = "Remito nuevo"
        Me.Close()

    End Sub

    Private Sub Remito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_remitos()
    End Sub

    Public Sub recuperar_remitos()
        Dim ds_consultaremito As DataSet = DAventa.Remito_recuperar_todos
        DS_remito.Tables("Remito").Rows.Clear() 'borro el contenido del dataset.datatable clientes
        DS_remito.Tables("Remito").Merge(ds_consultaremito.Tables(0))
    End Sub

    Private Sub Busqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Busqueda.KeyPress

        Dim unidades As Integer = RemitoBindingSource.Count

        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "Fantasia", Busqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
        'Filtro = String.Format("CONVERT(Fantasia o Razón Social, System.String) LIKE '%{0}%'", Busqueda.Text)
        RemitoBindingSource.Filter = Filtro
        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(ctacte_id, System.String) LIKE '%{0}%'", Busqueda.Text)
            RemitoBindingSource.Filter = Filtro
            If DataGridView1.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(remito_id, System.String) LIKE '%{0}%'", Busqueda.Text)
                RemitoBindingSource.Filter = Filtro
            End If
        End If
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
                If MessageBox.Show("Desea ver el reporte del Remito Nº: " + CStr(DataGridView1.Rows(i).Cells(1).Value) + "?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'aqui viene llamada a la rutina del reporte
                    Dim cliente_id As Integer = CInt(DataGridView1.Rows(i).Cells("CLIidDataGridViewTextBoxColumn").Value)
                    Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id)
                    Dim remito_id As Integer = CInt(DataGridView1.Rows(i).Cells("RemitoidDataGridViewTextBoxColumn").Value)
                    crear_reporte(ds_usuario, remito_id, cliente_id)
                End If
                Exit While
            End If
            i = i + 1
        End While
        If encontrado = "no" Then
            MessageBox.Show("Error, Debe seleccionar un remito.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Dim DAcliente As New Datos.Cliente
    Dim facturacion_ds_report As New Facturacion_ds_report
    Private Sub crear_reporte(ByVal ds_usuario As DataSet, ByVal numerofactura As Integer, ByVal cliente_id As Integer)
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
        Dim ds_remito As DataSet = DAventa.Remito_recuperar_productos(numerofactura)

        '///////////////TABLA VENTA//////////////////////////////////'
        facturacion_ds_report.Tables("venta").Rows.Clear()
        Dim row_venta As DataRow = facturacion_ds_report.Tables("venta").NewRow()
        'row_venta("nro_factura") = Venta_Caja_gestion.lb_factura_vta.Text
        'row_venta("nro_factura") = ventaprod_id
        row_venta("nro_factura") = CInt(numerofactura)
        row_venta("fecha") = ds_remito.Tables(0).Rows(0).Item("remito_fecha")
        row_venta("vendedor") = ""
        row_venta("tipo_venta") = ds_remito.Tables(0).Rows(0).Item("ventaprod_tipovta")
        facturacion_ds_report.Tables("venta").Rows.Add(row_venta)

        '///////////////TABLA TOTALES APLICADOS//////////////////////////////////'
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Clear()
        Dim row_totales As DataRow = facturacion_ds_report.Tables("Totales_aplicados").NewRow()
        row_totales("subtotal") = ds_remito.Tables(0).Rows(0).Item("ventaprod_subtotal")
        row_totales("total") = ds_remito.Tables(0).Rows(0).Item("ventaprod_total")
        row_totales("iva") = ds_remito.Tables(0).Rows(0).Item("ventaprod_iva_porcentaje")
        row_totales("descuento_porcentaje") = ds_remito.Tables(0).Rows(0).Item("ventaprod_descuento_porcentaje")
        row_totales("descuento_pesos") = ds_remito.Tables(0).Rows(0).Item("ventaprod_descuento_pesos")
        row_totales("iva_pesos") = ds_remito.Tables(0).Rows(0).Item("ventaprod_iva_pesos")
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)

        '///////////////TABLA PRODUCTO AGREGADO//////////////////////////////////'
        'aqui ciclo en la grilla para ir agrendo los row a la tabla producto agregado
        facturacion_ds_report.Tables("Producto_agregado").Rows.Clear()
        Dim i As Integer = 0
        While i < ds_remito.Tables(0).Rows.Count
            Dim row_prodADD As DataRow = facturacion_ds_report.Tables("Producto_agregado").NewRow()
            row_prodADD("PROD_id") = ""
            'row_prodADD("codinterno") = 
            row_prodADD("descripcion") = ds_remito.Tables(0).Rows(i).Item("ventaprod_descripcion")
            row_prodADD("detalle") = ds_remito.Tables(0).Rows(i).Item("prod_descrilarga")
            row_prodADD("cantidad") = CDec(ds_remito.Tables(0).Rows(i).Item("ventaprod_cant"))
            row_prodADD("precio_unitario") = CDec(ds_remito.Tables(0).Rows(i).Item("ventaprod_precio"))
            row_prodADD("precio_subtotal") = CDec(ds_remito.Tables(0).Rows(i).Item("producto_subtotal"))
            row_prodADD("codbarra") = ""
            row_prodADD("TURNO_id") = ""
            '/choco modificacion 01-12-2019: agrego columna descuento
            row_prodADD("descuento") = CDec(ds_remito.Tables(0).Rows(i).Item("ventaprod_descuento_porc"))
            row_prodADD("grupo_id") = CInt(1)
            facturacion_ds_report.Tables("Producto_agregado").Rows.Add(row_prodADD)
            i = i + 1
        End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Facturacion\Reportes\CR_remito.rpt")
        CrReport.Database.Tables("Cliente").SetDataSource(facturacion_ds_report.Tables("Cliente"))
        CrReport.Database.Tables("Sucursal").SetDataSource(facturacion_ds_report.Tables("Sucursal"))
        CrReport.Database.Tables("Empresa").SetDataSource(facturacion_ds_report.Tables("Empresa"))
        CrReport.Database.Tables("venta").SetDataSource(facturacion_ds_report.Tables("venta"))
        CrReport.Database.Tables("Producto_agregado").SetDataSource(facturacion_ds_report.Tables("Producto_agregado"))
        CrReport.Database.Tables("Totales_aplicados").SetDataSource(facturacion_ds_report.Tables("Totales_aplicados"))
        Dim remito_report As New Facturacion_report_show
        remito_report.CrystalReportViewer1.ReportSource = CrReport
        remito_report.Text = "Remito Nº: " + CStr(numerofactura) + " - Imprimir."
        remito_report.Show()
        'End If
    End Sub

    Private Sub Button_editar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_editar.Click
        Dim indice_chek As Integer = 0
        Dim encontrado = "no"
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells(0).Value = True Then
                indice_chek = i
                encontrado = "si"
                Exit While
            End If
            i = i + 1
        End While
        If encontrado = "no" Then
            MessageBox.Show("Error, Debe seleccionar un remito.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim estado As String = CStr(DataGridView1.Rows(indice_chek).Cells("RemitoestadoDataGridViewTextBoxColumn").Value)

            If DataGridView1.Rows(indice_chek).Cells("RemitoestadoDataGridViewTextBoxColumn").Value = "pendiente entrega" Then
                'aqui va la llamada al formulario de venta_caja_gestion, pero recuperando un remito existente.
                Venta_Caja_gestion.Close()
                Dim remito_id As Integer = CInt(DataGridView1.Rows(indice_chek).Cells("RemitoidDataGridViewTextBoxColumn").Value)
                Venta_Caja_gestion.Label_remito.Text = "Remito Nº: " + CStr(remito_id)
                Dim ds_remito As DataSet = DAventa.Remito_recuperar(remito_id)
                Dim observacion As String = ds_remito.Tables(0).Rows(0).Item("ventaprod_observacion")
                If observacion = "Venta Minorista-Cta. Cte." Then
                    Venta_Caja_gestion.tipo_vta = "Minorista" 'tipo_vta es para q se recuperen los precios minoristas o mayoristas de los productos.
                Else
                    Venta_Caja_gestion.tipo_vta = "Mayorista"
                End If
                Venta_Caja_gestion.remito_cliente_id = CInt(DataGridView1.Rows(indice_chek).Cells("CLIidDataGridViewTextBoxColumn").Value)
                Venta_Caja_gestion.remito_id = remito_id
                Venta_Caja_gestion.USU_id_gen_remito = CInt(ds_remito.Tables(0).Rows(0).Item("usuario_id"))
                Venta_Caja_gestion.fecha_remito = CStr(ds_remito.Tables(0).Rows(0).Item("remito_fecha"))
                Venta_Caja_gestion.remiro_vendedor_id = CStr(ds_remito.Tables(0).Rows(0).Item("vendedor_id"))
                Venta_Caja_gestion.remito_ventaprod_id = CInt(DataGridView1.Rows(indice_chek).Cells("VentaprodidDataGridViewTextBoxColumn").Value)
                Venta_Caja_gestion.RB_Consumidor.Enabled = False
                Venta_Caja_gestion.RB_Cliente.Checked = True
                Venta_Caja_gestion.TabPage1.Text = "Modificar remito: Cliente con Cuenta Corriente"
                Venta_Caja_gestion.TabPage2.Text = "Modificar remito: Productos"
                Venta_Caja_gestion.procedencia = "Remito modificar"
                Venta_Caja_gestion.Btn_facturacion.Visible = True
                Venta_Caja_gestion.Text = "Modificar Remito"
                Me.Close()
                Venta_Caja_gestion.Show()
                'MessageBox.Show("Imprimo remito Nº: " + CStr(DataGridView1.Rows(i).Cells(1).Value), "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Error, el remito ya fue finalizado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class