Public Class Forma_de_pago_seleccion
    Dim DAventa As New Datos.Venta
    Dim DAcuentacorriente As New Datos.CuentaCorriente
    Dim DAproducto As New Datos.Producto
    Private Sub Forma_de_pago_seleccion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Venta_Caja_gestion.procedencia = "Remito modificar" Then
            Dim cliente_id As String = Venta_Caja_gestion.remito_cliente_id
            Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(cliente_id)
            If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                RadioButton_ctacte.Enabled = True
            Else
                RadioButton_ctacte.Enabled = False
            End If
        Else
            RadioButton_ctacte.Enabled = True
            Dim cliente_id As String
            If Venta_Caja_gestion.RB_Consumidor.Checked = True Then
                cliente_id = 0
                RadioButton_ctacte.Enabled = False
            Else
                cliente_id = Venta_Caja_gestion.DG_clientes.CurrentRow.Cells(0).Value
                Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(cliente_id)
                If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                    RadioButton_ctacte.Enabled = True
                Else
                    RadioButton_ctacte.Enabled = False
                End If
            End If
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Venta_Caja_gestion.procedencia = "Remito modificar" Then
            opciones_remito_modificar()
        Else
            If RadioButton_efectivo.Checked = True Then
                Venta_Caja_gestion.formas_de_pago("efectivo")
                Me.Close()
            Else
                If RadioButton_tarjeta.Checked = True Then
                    Venta_Caja_gestion.formas_de_pago("tarjeta")
                    Me.Close()
                Else
                    'aqui hago alta en las tablas movimientos_ctacte y venta_ctacte. actualizo total en tabla cuenta corriente.
                    Dim usuario_id As String
                    usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
                    Dim tipo_vta As String = "Cliente"
                    Dim vendedor_id As Integer = CInt(Venta_Caja_gestion.ComboBox_vendedor.SelectedValue)
                    Dim cliente_id As String = Venta_Caja_gestion.DG_clientes.CurrentRow.Cells(0).Value
                    Dim venta_tipo_descripcion As String = ""
                    If Venta_Caja_gestion.tipo_vta = "Minorista" Then
                        venta_tipo_descripcion = "Venta Minorista-Cta. Cte."
                    Else
                        venta_tipo_descripcion = "Venta Mayorista-Cta. Cte."
                    End If
                    Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(cliente_id)
                    If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                        'valido que el monto total no exceda el limite de deuda
                        Dim limite_deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_limitedeuda"))
                        Dim deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) + CDec(Venta_Caja_gestion.txt_total.Text)
                        If deuda <= limite_deuda Or limite_deuda = 0 Then
                            Dim ds_Venta As DataSet = DAventa.VentaProducto_alta(CDec(Venta_Caja_gestion.txt_total.Text),
                                         Now,
                                         usuario_id,
                                         tipo_vta,
                                         cliente_id, CDec(Venta_Caja_gestion.txt_subtotal.Text),
                                         CDec(Venta_Caja_gestion.txt_descuento.Text),
                                         CDec(Venta_Caja_gestion.txt_desc_porc.Text),
                                         CDec(Venta_Caja_gestion.ComboBox_iva.SelectedItem),
                                          CDec(Venta_Caja_gestion.txt_impuesto_aplicado.Text), venta_tipo_descripcion, 0, vendedor_id, "Pendiente")
                            Dim ventaprod_id As Integer = CInt(ds_Venta.Tables(0).Rows(0).Item("ventaprod_id"))

                            Dim ds_factura As DataSet = DAventa.Factura_alta(ventaprod_id, Now)
                            Dim factura_id As Integer = CInt(ds_factura.Tables(0).Rows(0).Item("factura_id"))
                            '////////////////aqui cargamos en cuenta corriente, si corresponde - CHOCO: 03-12-2019//////////////////
                            'tiene cuenta y genera deuda.
                            Dim CtaCte_id As Integer = ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_id")
                            DAcuentacorriente.CtaCte_registrar_egreso(CtaCte_id, deuda)
                            DAcuentacorriente.Venta_CtaCte_alta(factura_id, CtaCte_id)
                            Dim concepto As String = "Factura Nº: " + CStr(factura_id)
                            DAcuentacorriente.CtaCte_movimiento_alta(CtaCte_id, "Ingreso", concepto, CDec(Venta_Caja_gestion.txt_total.Text), Now)
                            '//////////////////////////////////////////////////////////////////////////////////
                            'GUARDAR EN TABLA "Venta_Producto_detalle"
                            For Each row As DataGridViewRow In Venta_Caja_gestion.DataGridView1.Rows
                                If row.Cells("columna_prod_id").Value <> 0 Then
                                    DAventa.VentaProductoDetalle_alta(ventaprod_id, row.Cells(1).Value, row.Cells(5).Value, CDec(row.Cells(7).Value), CDec(row.Cells(8).Value), row.Cells(3).Value, row.Cells(2).Value, 0, CDec(row.Cells(6).Value))
                                End If
                            Next
                            'aqui hago el descuento de stock...
                            'primero de los productos ....luego de los combos...(ya q estan formados por varios productos)
                            Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
                            Dim sucursal_id As Integer = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
                            Dim i As Integer = 0
                            Dim ds_stock As New DataSet
                            While i < Venta_Caja_gestion.DataGridView1.Rows.Count
                                Dim prod_codigo As Integer = 0
                                If Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_codinterno").Value <> "0" Then
                                    prod_codigo = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_codinterno").Value)
                                End If
                                ds_stock = DAproducto.Producto_x_sucursal_buscarcod(prod_codigo, sucursal_id)
                                If ds_stock.Tables(0).Rows.Count <> 0 Then
                                    Dim diferencia As Decimal = CDec(ds_stock.Tables(0).Rows(0).Item("ProdxSuc_stock")) - CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                                    If diferencia < 0 Then
                                        diferencia = 0
                                    End If
                                    Dim diferencia_gondola As Integer = 0
                                    Dim cantidad As Integer = 0
                                    'If ds_stock.Tables(1).Rows.Count <> 0 Then
                                    '    If IsDBNull(ds_stock.Tables(1).Rows(0).Item("prod_gondola")) Then
                                    '    Else
                                    '        cantidad = ds_stock.Tables(1).Rows(0).Item("prod_gondola")
                                    '    End If
                                    '    diferencia_gondola = CInt(cantidad) - CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                                    'End If
                                    DAventa.Venta_actualizar_stock_Caja(prod_codigo, diferencia, diferencia_gondola, sucursal_id)
                                    'MsgBox("actualizo stock de", prod_codigo)

                                Else 'si no lo encuentra significa q es un combo o bien una promocion...asi que tengo q actualizar el stock de varios
                                    If Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value <> "0" Then
                                        'primero lo busco como combo.

                                        'aqui veo si ponerle el indice _tabla en 2 o 3...dependiendo del procedimiento q tome los recursos el DS_PROD...
                                        'son 2 las rutinas....Venta_obtenerProducto_listaregular y [Venta_obtenerProducto_Combos]
                                        Dim indice_tabla As Integer = 0
                                        If Venta_Caja_gestion.RB_Si.Checked = False Then
                                            indice_tabla = 3
                                        Else
                                            indice_tabla = 2
                                        End If
                                        'id del combo
                                        Dim ProdCombo_id As Integer = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_codinterno").Value)
                                        Dim cantidad_combos As Integer = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                                        Dim j As Integer = 0
                                        While j < Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows.Count
                                            If ProdCombo_id = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdCombo_id") Then
                                                Dim prod_id As Integer = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("prod_id")
                                                Dim cantidad_item As Integer = CInt(Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(indice_tabla).Rows(j).Item("ProdComboDet_cantidad"))
                                                ds_stock = DAproducto.Producto_buscar_id(prod_id)
                                                Dim cantidad_total As Integer = CInt(cantidad_combos * cantidad_item)
                                                Dim diferencia As Integer = CInt(ds_stock.Tables(0).Rows(0).Item("prod_stock")) - cantidad_total
                                                Dim diferencia_gondola As Integer = 0
                                                Dim cantidad As Integer = 0
                                                If ds_stock.Tables(1).Rows.Count <> 0 Then
                                                    If IsDBNull(ds_stock.Tables(1).Rows(0).Item("prod_gondola")) Then
                                                    Else
                                                        cantidad = ds_stock.Tables(1).Rows(0).Item("prod_gondola")
                                                    End If
                                                    diferencia_gondola = CInt(cantidad) - cantidad_total
                                                End If
                                                DAventa.Venta_actualizar_stock_Caja_2(prod_id, diferencia, diferencia_gondola)
                                                'MsgBox("actualizo stock de combo", prod_codigo)
                                            End If
                                            j = j + 1
                                        End While
                                    Else
                                        'aqui llamo a la rutina ACTUALIZAR STOCK DE PROMOCION
                                        Dim LISTA_codinterno As String = (Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_prod_id").Value)
                                        Dim cantidad_PROMOS As Integer = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                                        Dim LISTA_ID As Integer = 0

                                        'Busco el id de la promocion en el ds_promo
                                        Dim ii As Integer = 0
                                        While ii < Venta_Caja_gestion.VentaGestion_ds_PROMO.Tables(0).Rows.Count
                                            If LISTA_codinterno = Venta_Caja_gestion.VentaGestion_ds_PROMO.Tables(0).Rows(ii).Item("LISTA_codinterno") Then
                                                LISTA_ID = Venta_Caja_gestion.VentaGestion_ds_PROMO.Tables(0).Rows(ii).Item("LISTA_id")
                                            End If
                                            ii = ii + 1
                                        End While
                                        Venta_Caja_gestion.Actualizar_Stock_Promocion(LISTA_ID, cantidad_PROMOS)

                                    End If
                                End If
                                i = i + 1
                            End While
                            'aqui llamo a la rutina que me muestra el reporte.
                            crear_reporte(ds_usuario, factura_id)
                            MessageBox.Show("La venta se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'aqui van las rutinas q borran grilla de venta_caja_gestion y dejan todo listo para prox venta.
                            Venta_Caja_gestion.Limpiar()
                            Me.Close()
                        Else
                            MessageBox.Show("La venta excede el limite de deuda para la cuenta corriente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Dim DAcliente As New Datos.Cliente
    Dim facturacion_ds_report As New Facturacion_ds_report
    Private Sub crear_reporte(ByVal ds_usuario As DataSet, ByVal nrofactura As Integer)
        'pregunto si quiero ver el reporte 
        'Dim result As DialogResult
        'result = MessageBox.Show("¿Desea ver la factura?", "Sistema de Gestión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'If result = DialogResult.OK Then
        'primero lleno el dataset y sus respectivas table

        '///////////////TABLA CLIENTE//////////////////////////////////'
        facturacion_ds_report.Tables("Cliente").Rows.Clear()
        If Venta_Caja_gestion.lb_dni_clie.Text <> "- - - -" Then

            Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni((Venta_Caja_gestion.lb_dni_clie.Text))
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
            row_cliente("fantasia") = Venta_Caja_gestion.lb_fantasia.Text
            row_cliente("dni") = Venta_Caja_gestion.lb_dni_clie.Text
            row_cliente("telefono") = Venta_Caja_gestion.lb_telef_clie.Text
            row_cliente("mail") = Venta_Caja_gestion.lb_mail_clie.Text
            row_cliente("direccion") = ds_cliente.Tables(1).Rows(0).Item("CLI_dir")
            row_cliente("localidad") = ds_cliente.Tables(1).Rows(0).Item("provincia") + ", " + ds_cliente.Tables(1).Rows(0).Item("Localidad")
            row_cliente("iva_condicion") = ds_cliente.Tables(1).Rows(0).Item("IVA_descripcion").ToString
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        Else
            'Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni(CInt(Venta_Caja_gestion.lb_dni_clie.Text))
            Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
            row_cliente("fantasia") = "" 'Venta_Caja_gestion.lb_fantasia.Text
            row_cliente("dni") = "" 'Venta_Caja_gestion.lb_dni_clie.Text
            row_cliente("telefono") = "" 'Venta_Caja_gestion.lb_telef_clie.Text
            row_cliente("mail") = Venta_Caja_gestion.lb_mail_clie.Text
            row_cliente("direccion") = ""
            row_cliente("localidad") = ""
            row_cliente("iva_condicion") = "Consumidor Final"
            facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)
        End If

        'Dim ds_cliente As DataSet = DAcliente.Cliente_ObtenerDni(CInt(Venta_Caja_gestion.lb_dni_clie.Text))
        'Dim row_cliente As DataRow = facturacion_ds_report.Tables("Cliente").NewRow()
        'row_cliente("fantasia") = Venta_Caja_gestion.lb_fantasia.Text
        'row_cliente("dni") = Venta_Caja_gestion.lb_dni_clie.Text
        'row_cliente("telefono") = Venta_Caja_gestion.lb_telef_clie.Text
        'row_cliente("mail") = Venta_Caja_gestion.lb_mail_clie.Text
        'row_cliente("direccion") = ds_cliente.Tables(1).Rows(0).Item("CLI_dir")
        'row_cliente("localidad") = ds_cliente.Tables(1).Rows(0).Item("provincia") + ", " + ds_cliente.Tables(1).Rows(0).Item("Localidad")
        'facturacion_ds_report.Tables("Cliente").Rows.Add(row_cliente)

        '///////////////TABLA SUCURSAL//////////////////////////////////'
        facturacion_ds_report.Tables("Sucursal").Rows.Clear()
        Dim row_sucursal As DataRow = facturacion_ds_report.Tables("Sucursal").NewRow()
        row_sucursal("sucursal") = Venta_Caja_gestion.lb_nombre_sucursal.Text
        row_sucursal("direccion") = Venta_Caja_gestion.lb_direccion_sucursal.Text
        row_sucursal("telefono") = Venta_Caja_gestion.lb_telefono_sucursal.Text
        row_sucursal("mail") = Venta_Caja_gestion.lb_mail_sucursal.Text
        row_sucursal("cuit") = "20 - 00000000 - 4"
        facturacion_ds_report.Tables("Sucursal").Rows.Add(row_sucursal)

        '///////////////TABLA EMPRESA//////////////////////////////////'
        If ds_usuario.Tables(1).Rows.Count <> 0 Then
            facturacion_ds_report.Tables("Empresa").Rows.Clear()
            facturacion_ds_report.Tables("Empresa").Merge(ds_usuario.Tables(1))
        End If

        '///////////////TABLA VENTA//////////////////////////////////'
        facturacion_ds_report.Tables("venta").Rows.Clear()
        Dim row_venta As DataRow = facturacion_ds_report.Tables("venta").NewRow()
        'row_venta("nro_factura") = Venta_Caja_gestion.lb_factura_vta.Text
        row_venta("nro_factura") = nrofactura
        row_venta("fecha") = Today 'CDate(Venta_Caja_gestion.lb_fecha_vta.Text)
        row_venta("vendedor") = Venta_Caja_gestion.lb_vendedor_vta.Text
        Dim tipo_vta As String = ""
        If Venta_Caja_gestion.RB_Consumidor.Checked = True Then
            tipo_vta = "Consumidor Final"
        Else
            tipo_vta = "Cliente"
        End If
        row_venta("tipo_venta") = tipo_vta
        facturacion_ds_report.Tables("venta").Rows.Add(row_venta)
        '///////////////TABLA TOTALES APLICADOS//////////////////////////////////'
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Clear()
        Dim row_totales As DataRow = facturacion_ds_report.Tables("Totales_aplicados").NewRow()
        row_totales("subtotal") = Venta_Caja_gestion.txt_subtotal.Text
        row_totales("total") = Venta_Caja_gestion.txt_total.Text
        row_totales("iva") = CDec(Venta_Caja_gestion.ComboBox_iva.SelectedItem)
        row_totales("descuento_porcentaje") = CDec(Venta_Caja_gestion.txt_desc_porc.Text)
        row_totales("descuento_pesos") = CDec(Venta_Caja_gestion.txt_desc_pesos.Text)
        row_totales("iva_pesos") = CDec(Venta_Caja_gestion.txt_impuesto_aplicado.Text)
        facturacion_ds_report.Tables("Totales_aplicados").Rows.Add(row_totales)

        '///////////////TABLA PRODUCTO AGREGADO//////////////////////////////////'
        'aqui ciclo en la grilla para ir agrendo los row a la tabla producto agregado
        facturacion_ds_report.Tables("Producto_agregado").Rows.Clear()
        Dim i As Integer = 0
        While i < Venta_Caja_gestion.DataGridView1.Rows.Count
            If Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_descripcion").Value <> "" Then
                Dim row_prodADD As DataRow = facturacion_ds_report.Tables("Producto_agregado").NewRow()
                row_prodADD("PROD_id") = Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_prod_id").Value
                row_prodADD("codinterno") = CInt(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_codinterno").Value)
                row_prodADD("descripcion") = Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_descripcion").Value
                row_prodADD("detalle") = Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_detalle").Value
                row_prodADD("cantidad") = CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_cantidad").Value)
                row_prodADD("precio_unitario") = CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_precio_unitario").Value)
                row_prodADD("precio_subtotal") = CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("columna_precio_subtotal").Value)
                row_prodADD("codbarra") = ""
                row_prodADD("TURNO_id") = ""
                '/choco modificacion 01-12-2019: agrego columna descuento
                row_prodADD("descuento") = CDec(Venta_Caja_gestion.DataGridView1.Rows(i).Cells("descuento").Value)
                row_prodADD("grupo_id") = CInt(1)
                facturacion_ds_report.Tables("Producto_agregado").Rows.Add(row_prodADD)
            End If
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
        Facturacion_report_show.CrystalReportViewer1.ReportSource = CrReport
        Facturacion_report_show.Text = "Comprobante Nº: " + CStr(nrofactura) + " - Imprimir."
        Facturacion_report_show.Show()
        'End If
    End Sub



    Private Sub opciones_remito_modificar()
        If RadioButton_efectivo.Checked = True Then
            Venta_Caja_gestion.formas_de_pago("efectivo")
            Me.Close()
        Else
            If RadioButton_tarjeta.Checked = True Then
                Venta_Caja_gestion.formas_de_pago("tarjeta")
                Me.Close()
            Else
                Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(Venta_Caja_gestion.remito_cliente_id)
                If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                    'valido que el monto total no exceda el limite de deuda
                    Dim limite_deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_limitedeuda"))
                    Dim deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) + CDec(Venta_Caja_gestion.txt_total.Text)
                    If deuda <= limite_deuda Or limite_deuda = 0 Then
                        Dim venta_tipo_descripcion As String
                        If Venta_Caja_gestion.tipo_vta = "Minorista" Then
                            venta_tipo_descripcion = "Venta Minorista-Efectivo"
                        Else
                            venta_tipo_descripcion = "Venta Mayorista-Efectivo"
                        End If
                        DAventa.remito_modificar_estado(Venta_Caja_gestion.remito_id, "Facturado")

                        DAventa.Remito_productos_modificar(Venta_Caja_gestion.remito_ventaprod_id, CDec(Venta_Caja_gestion.txt_total.Text),
                                                         Venta_Caja_gestion.USU_id_gen_remito,
                                                         "Cliente",
                                                         Venta_Caja_gestion.remito_cliente_id, CDec(Venta_Caja_gestion.txt_subtotal.Text),
                                                         CDec(Venta_Caja_gestion.txt_descuento.Text),
                                                         CDec(Venta_Caja_gestion.txt_desc_porc.Text),
                                                         CDec(Venta_Caja_gestion.ComboBox_iva.SelectedItem),
                                                          CDec(Venta_Caja_gestion.txt_impuesto_aplicado.Text), venta_tipo_descripcion, 0, Venta_Caja_gestion.ComboBox_vendedor.SelectedValue, "Facturado")



                        Dim ds_factura As DataSet = DAventa.Factura_alta(Venta_Caja_gestion.remito_ventaprod_id, Now)
                        Dim factura_id As Integer = CInt(ds_factura.Tables(0).Rows(0).Item("factura_id"))
                        '////////////////aqui cargamos en cuenta corriente, si corresponde - CHOCO: 07-12-2019//////////////////
                        'tiene cuenta y genera deuda.
                        Dim CtaCte_id As Integer = ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_id")
                        DAcuentacorriente.CtaCte_registrar_egreso(CtaCte_id, deuda)
                        DAcuentacorriente.Venta_CtaCte_alta(factura_id, CtaCte_id)
                        Dim concepto As String = "Factura Nº: " + CStr(factura_id)
                        DAcuentacorriente.CtaCte_movimiento_alta(CtaCte_id, "Ingreso", concepto, CDec(Venta_Caja_gestion.txt_total.Text), Now)
                        '//////////////////////////////////////////////////////////////////////////////////
                        
                        'aqui hago el descuento de stock...
                        'primero de los productos ....luego de los combos...(ya q estan formados por varios productos)
                        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(Venta_Caja_gestion.USU_id_gen_remito)

                        'aqui llamo a la rutina que me muestra el reporte.
                        crear_reporte(ds_usuario, factura_id)
                        MessageBox.Show("La venta se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'aqui van las rutinas q borran grilla de venta_caja_gestion y dejan todo listo para prox venta.
                        Venta_Caja_gestion.Close()
                        Me.Close()
                    Else
                        MessageBox.Show("La venta excede el limite de deuda para la cuenta corriente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                End If


            End If
        End If
    End Sub
End Class