Public Class CtaCte_pago
    Dim DAcaja As New Datos.Caja
    Dim DAcuentacorriente As New Datos.CuentaCorriente
    Dim DAventa As New Datos.Venta
    Private Sub tx_total_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_total.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.tx_total.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
            If tx_total.Text = "" Then
                tx_total.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                tx_total.Text = (Math.Round(CDec(tx_total.Text), 2).ToString("N2"))
            End If
        End If
    End Sub

    Private Sub RadioButton_efectivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_efectivo.CheckedChanged
        If RadioButton_efectivo.Checked = True Then
            tx_tarjeta.Text = Nothing
            tx_comprobante.Text = Nothing
            tx_tarjeta.Enabled = False
            tx_comprobante.Enabled = False
        Else
            If RadioButton_tarjeta.Checked = True Then
                tx_tarjeta.Text = Nothing
                tx_comprobante.Text = Nothing
                tx_tarjeta.Enabled = True
                tx_comprobante.Enabled = True
            End If
        End If
    End Sub

    Private Sub RadioButton_tarjeta_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_tarjeta.CheckedChanged
        If RadioButton_efectivo.Checked = True Then
            tx_tarjeta.Text = Nothing
            tx_comprobante.Text = Nothing
            tx_tarjeta.Enabled = False
            tx_comprobante.Enabled = False
        Else
            If RadioButton_tarjeta.Checked = True Then
                tx_tarjeta.Text = Nothing
                tx_comprobante.Text = Nothing
                tx_tarjeta.Enabled = True
                tx_comprobante.Enabled = True
            End If
        End If
    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Me.Close()
    End Sub

    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click
        If RadioButton_efectivo.Checked = True Then
            registrar_efectivo()
        Else
            registrar_tarjeta()
        End If
    End Sub




    Private Sub registrar_efectivo()
        If tx_total.Text = "" Then
            tx_total.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tx_total.Text = (Math.Round(CDec(tx_total.Text), 2).ToString("N2"))
        End If

        If CDec(tx_total.Text) = 0 Then
            MessageBox.Show("Error, el monto total es incorrecto.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'aqui viene el altao
            'se debe registrar en caja detalle.
            Dim ctacte_nro As String = CStr(Cliente_Cta_Cte_Buscar.txt_ctacte.Text)
            Dim descripcion As String = "Pago a Cuenta Corriente Nº:" + ctacte_nro
            'OK
            DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(tx_total.Text), CDec(0), 1, CDec(0), CDec(tx_total.Text), Now, Inicio.terminal_id, US_administrador.TurnoUsuario_id) '1 es venta


            'se debe registrar en movimiento ctacte.
            Dim cliente_id As Integer = CInt(Cliente_Cta_Cte_Buscar.DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value)
            Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(cliente_id)
            If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                Dim deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) - CDec(tx_total.Text)
                Dim CtaCte_id As Integer = ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_id")
                DAcuentacorriente.CtaCte_registrar_egreso(CtaCte_id, deuda) 'actualizo total de la deuda.

                Dim ds_recibo As DataSet = DAcuentacorriente.Recibo_obtener_ultimo
                Dim nro_recibo As Integer = 0
                If ds_recibo.Tables(0).Rows.Count <> 0 Then
                    nro_recibo = ds_recibo.Tables(0).Rows(0).Item("recibo_id") + 1
                Else
                    nro_recibo = 1
                End If
                Dim concepto As String = "Pago Efectivo, Recibo Nº:" + CStr(nro_recibo)
                Dim ds_mov As DataSet = DAcuentacorriente.CtaCte_movimiento_alta(CtaCte_id, "Egreso", concepto, CDec(tx_total.Text), Now)
                'ahora falta el alta en la tabla recibo
                Dim movimiento_id As Integer = ds_mov.Tables(0).Rows(0).Item("MovimientosCtaCte_id")
                DAcuentacorriente.Recibo_alta(movimiento_id, Now)

                'reflejar cambios en la grilla del formulario Cliente_Cta_Cte_buscar
                Cliente_Cta_Cte_Buscar.Obtener_Movimientos()

                MessageBox.Show("El pago se registró correctamente.", "Sistema de Gestion.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'mostrar el recibo de pago
                Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id) 'obtengo del formulario inicio el id del usuario logueado
                crear_reporte(ds_usuario, nro_recibo)

            End If

            Me.Close()



        End If

    End Sub
    Dim DAcliente As New Datos.Cliente
    Dim facturacion_ds_report As New Facturacion_ds_report
    Private Sub crear_reporte(ByVal ds_usuario As DataSet, ByVal numerorecibo As Integer)

        Dim ds_recibo As DataSet = DAcuentacorriente.Recibo_obtener_reporte(numerorecibo)

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
        recibo_report.Text = "Recibo imprimir"
        recibo_report.Show()
    End Sub



    Private Sub registrar_tarjeta()
        If tx_total.Text = "" Then
            tx_total.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tx_total.Text = (Math.Round(CDec(tx_total.Text), 2).ToString("N2"))
        End If

        If CDec(tx_total.Text) = 0 Then
            MessageBox.Show("Error, el monto total es incorrecto.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If tx_tarjeta.Text <> "" And tx_comprobante.Text <> "" Then
                'aqui guardo
                Dim ctacte_nro As String = CStr(Cliente_Cta_Cte_Buscar.txt_ctacte.Text)
                Dim descripcion As String = "Pago a Cuenta Corriente Nº:" + ctacte_nro
                DAcaja.Caja_Actualizar2(Inicio.USU_id, descripcion, CDec(0), CDec(0), 4, CDec(tx_total.Text), CDec(tx_total.Text), Now, Inicio.terminal_id, US_administrador.TurnoUsuario_id) '4 es tarjeta

                'se debe registrar en movimiento ctacte.
                Dim cliente_id As Integer = CInt(Cliente_Cta_Cte_Buscar.DG_clientes.CurrentRow.Cells("CLIidDataGridViewTextBoxColumn").Value)
                Dim ds_cuentacorrente As DataSet = DAcuentacorriente.CtaCte_buscar_Cliente(cliente_id)
                If ds_cuentacorrente.Tables(0).Rows.Count <> 0 Then
                    Dim deuda As Decimal = CDec(ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_total")) - CDec(tx_total.Text)
                    Dim CtaCte_id As Integer = ds_cuentacorrente.Tables(0).Rows(0).Item("CtaCte_id")
                    DAcuentacorriente.CtaCte_registrar_egreso(CtaCte_id, deuda) 'actualizo total de la deuda.

                    Dim ds_recibo As DataSet = DAcuentacorriente.Recibo_obtener_ultimo
                    Dim nro_recibo As Integer = 0
                    If ds_recibo.Tables(0).Rows.Count <> 0 Then
                        nro_recibo = ds_recibo.Tables(0).Rows(0).Item("recibo_id") + 1
                    Else
                        nro_recibo = 1
                    End If
                    Dim concepto As String = "Pago Tarjeta, Recibo Nº:" + CStr(nro_recibo) + ", Tarjeta:" + tx_tarjeta.Text + ", Comprobante:" + tx_comprobante.Text
                    Dim ds_mov As DataSet = DAcuentacorriente.CtaCte_movimiento_alta(CtaCte_id, "Egreso", concepto, CDec(tx_total.Text), Now)
                    'ahora falta el alta en la tabla recibo
                    Dim movimiento_id As Integer = ds_mov.Tables(0).Rows(0).Item("MovimientosCtaCte_id")
                    DAcuentacorriente.Recibo_alta(movimiento_id, Now)

                    'reflejar cambios en la grilla del formulario Cliente_Cta_Cte_buscar
                    Cliente_Cta_Cte_Buscar.Obtener_Movimientos()

                    MessageBox.Show("El pago se registró correctamente.", "Sistema de Gestion.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'mostrar el recibo de pago

                    Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id) 'obtengo del formulario inicio el id del usuario logueado
                    crear_reporte(ds_usuario, nro_recibo)

                End If

                Me.Close()
            Else
                MessageBox.Show("Error, debe ingresar Nº Tarjeta y Nº de Comprobante.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub CtaCte_pago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'con ESC cierro el formulario, cancelo operacion.
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class