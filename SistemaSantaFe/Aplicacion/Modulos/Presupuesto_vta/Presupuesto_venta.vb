Public Class Presupuesto_venta

    Private Sub Button_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_nuevo.Click
        Venta_Caja_seleccion_tipo_vta.Show()
        Venta_Caja_seleccion_tipo_vta.procedencia = "Presupuesto nuevo"
        Me.Close()
    End Sub
    Dim DAventa As New Datos.Venta
    Private Sub Button_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_imprimir.Click
        Dim encontrado = "no"
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).Cells("Column1").Value = True Then
                encontrado = "si"
                If MessageBox.Show("Desea ver el reporte del Presupuesto Nº: " + CStr(DataGridView1.Rows(i).Cells("PresupuestoidDataGridViewTextBoxColumn").Value) + "?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'aqui viene llamada a la rutina del reporte
                    Dim cliente_id As Integer = CInt(DataGridView1.Rows(i).Cells("CLIidDataGridViewTextBoxColumn").Value)
                    Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id)
                    Dim presupuesto_id As Integer = CInt(DataGridView1.Rows(i).Cells("PresupuestoidDataGridViewTextBoxColumn").Value)
                    crear_reporte(ds_usuario, presupuesto_id, cliente_id)
                End If
                Exit While
            End If
            i = i + 1
        End While
        If encontrado = "no" Then
            MessageBox.Show("Error, Debe seleccionar un presupuesto.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub recuperar_presupuestos()
        Dim ds_consultaremito As DataSet = DAventa.Presupuesto_recuperar_todos
        DS_presupuesto_vta.Tables("Presupuesto").Rows.Clear() 'borro el contenido del dataset.datatable presupuesto
        DS_presupuesto_vta.Tables("Presupuesto").Merge(ds_consultaremito.Tables(0))
        DS_presupuesto_vta.Tables("Presupuesto").Merge(ds_consultaremito.Tables(1))
    End Sub

    Private Sub Presupuesto_venta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_presupuestos()
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

        Dim ds_remito_a As DataSet = DAventa.Presupuesto_recuperar(numerofactura)


        If cliente_id <> 0 Then
            Dim ds_cliente As DataSet = DAcliente.Cliente_obtener_info(cliente_id)
            Dim ds_clie_recu As DataSet = DAcliente.Cliente_obtener_info(cliente_id) 'me trae los datos del cliente y ademas las sucursales q tiene vinculadas



            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()

            row_cliente("dni") = ds_cliente.Tables(1).Rows(0).Item("CLI_dni")
            'busco la sucursal que seleccioné para la factura.
            Dim a As Integer = 0
            While a < ds_clie_recu.Tables(3).Rows.Count
                If ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_id") = ds_remito_a.Tables(0).Rows(0).Item("SucxClie_id") Then
                    row_cliente("fantasia") = ds_cliente.Tables(1).Rows(0).Item("CLI_Fan") + ", " + ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_nombre")
                    row_cliente("telefono") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_tel")
                    row_cliente("mail") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_mail")
                    row_cliente("direccion") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_dir")
                    row_cliente("localidad") = ds_clie_recu.Tables(3).Rows(a).Item("provincia") + ", " + ds_clie_recu.Tables(3).Rows(a).Item("Localidad")
                    Exit While
                End If
                a = a + 1
            End While
            row_cliente("iva_condicion") = ds_cliente.Tables(0).Rows(0).Item("IVA_descripcion").ToString
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        Else
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()

            'row_cliente("dni") = 
            'busco la sucursal que seleccioné para la factura.
            Dim a As Integer = 0


            'row_cliente("fantasia") = ds_cliente.Tables(1).Rows(0).Item("CLI_Fan") + ", " + ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_nombre")
            'row_cliente("telefono") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_tel")
            'row_cliente("mail") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_mail")
            'row_cliente("direccion") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_dir")
            'row_cliente("localidad") = ds_clie_recu.Tables(3).Rows(a).Item("provincia") + ", " + ds_clie_recu.Tables(3).Rows(a).Item("Localidad")


            row_cliente("iva_condicion") = "Consumidor Final"
            'row_cliente("iva_condicion") = ds_cliente.Tables(0).Rows(0).Item("IVA_descripcion").ToString
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        End If



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
        Dim ds_remito As DataSet = DAventa.Presupuesto_recuperar_productos(numerofactura)

        '///////////////TABLA VENTA//////////////////////////////////'
        facturacion_ds_report.Tables("venta").Rows.Clear()
        Dim row_venta As DataRow = facturacion_ds_report.Tables("venta").NewRow()
        'row_venta("nro_factura") = Venta_Caja_gestion.lb_factura_vta.Text
        'row_venta("nro_factura") = ventaprod_id
        row_venta("nro_factura") = CInt(numerofactura)
        row_venta("fecha") = ds_remito.Tables(0).Rows(0).Item("presupuesto_fecha")
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
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Facturacion\Reportes\CR_presupuesto_venta.rpt")
        CrReport.Database.Tables("Cliente").SetDataSource(facturacion_ds_report.Tables("Cliente"))
        CrReport.Database.Tables("Sucursal").SetDataSource(facturacion_ds_report.Tables("Sucursal"))
        CrReport.Database.Tables("Empresa").SetDataSource(facturacion_ds_report.Tables("Empresa"))
        CrReport.Database.Tables("venta").SetDataSource(facturacion_ds_report.Tables("venta"))
        CrReport.Database.Tables("Producto_agregado").SetDataSource(facturacion_ds_report.Tables("Producto_agregado"))
        CrReport.Database.Tables("Totales_aplicados").SetDataSource(facturacion_ds_report.Tables("Totales_aplicados"))
        Dim remito_report As New Facturacion_report_show
        remito_report.CrystalReportViewer1.ReportSource = CrReport
        remito_report.Text = "Presupuesto Nº: " + CStr(numerofactura) + " - Imprimir."
        remito_report.Show()
        'End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim celda_actual = e.ColumnIndex

        'If celda_actual = 0 Then 'la 0 es la que tiene el check
        Dim fila As Integer = DataGridView1.CurrentRow.Index
        Dim i As Integer = 0
        While i < DataGridView1.Rows.Count
            If i <> fila Then
                DataGridView1.Rows(i).Cells(0).Value = False
            End If
            i = i + 1
        End While
        DataGridView1.Rows(fila).Cells(0).Value = True
        'End If
    End Sub

    Private Sub Busqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Busqueda.KeyPress

        Dim unidades As Integer = PresupuestoBindingSource.Count

        Dim Filtro
        Filtro = String.Format("CONVERT(presupuesto_id, System.String) LIKE '%{0}%'", Busqueda.Text)
        'Filtro = String.Format("CONVERT(Fantasia o Razón Social, System.String) LIKE '%{0}%'", Busqueda.Text)
        PresupuestoBindingSource.Filter = Filtro
        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("{0} LIKE '%{1}%'", "Fantasia", Busqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
            PresupuestoBindingSource.Filter = Filtro
            'Filtro = String.Format("CONVERT(ctacte_id, System.String) LIKE '%{0}%'", Busqueda.Text)
            'RemitoBindingSource.Filter = Filtro
            If DataGridView1.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(presupuesto_fecha, System.String) LIKE '%{0}%'", Busqueda.Text)
                'RemitoBindingSource.Filter = Filtro
                PresupuestoBindingSource.Filter = Filtro
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        Dim valido_seleccion As String = "no"

        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                        Dim nro_presupuesto As String = CStr(DataGridView1.Rows(i).Cells("PresupuestoidDataGridViewTextBoxColumn").Value)

                        If MsgBox("¿Esta seguro que quiere eliminar el presupuesto Nro: " + nro_presupuesto + "?", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                            pregunta = "si"
                        Else
                            'aqui corto el ciclo, ya que se cancelo la eliminacion
                            i = DataGridView1.Rows.Count
                        End If
                    End If
                    If pregunta = "si" Then
                        'primero guardo el nro de item q contiene
                        Dim item As Decimal = DataGridView1.CurrentRow.Index
                        Dim presupuesto_id As Integer = DataGridView1.Rows(i).Cells("PresupuestoidDataGridViewTextBoxColumn").Value
                        DAventa.presupuesto_modificar_estado(presupuesto_id, "Eliminado")
                        'DAcliente.Cliente_Sucursales_eliminar(CInt(DataGridView1.Rows(i).Cells("SucxClieidDataGridViewTextBoxColumn").Value), "ELIMINADO")
                        'End If
                        DataGridView1.Rows.RemoveAt(i)
                        'i = 0 'lo reinicio, x q al quitar un ite, se reordenan los indices
                        Exit While 'como voy a borrar de a uno. pongo este exit.
                    End If
                Else
                    i = i + 1
                End If
            End While

            If pregunta = "si" Then
                recuperar_presupuestos()
                MessageBox.Show("Eliminación correcta, los datos fueron actualizados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If valido_seleccion = "no" Then
                MessageBox.Show("Seleccione un presupuesto para eliminar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("No hay presupuestos generados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class