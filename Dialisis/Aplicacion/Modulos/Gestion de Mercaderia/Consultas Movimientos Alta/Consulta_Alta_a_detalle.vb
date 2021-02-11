Public Class Consulta_Alta_a_detalle

    Dim DAgestion_mercaderia As New Datos.Gestion_Mercaderia



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Consulta_Alta_a.Show()
        Me.Close()

    End Sub

    Private Sub Consulta_Alta_a_detalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As Integer = CInt(TextBox_ID.Text)
        Dim ds_detalle As DataSet = DAgestion_mercaderia.Movimiento_Mercaderia_Alta_obtener_detalle(id)
        If ds_detalle.Tables(0).Rows.Count <> 0 Then
            TextBox_proveedor.Text = ds_detalle.Tables(1).Rows(0).Item("Prov_nombre")
            tb_iva.Text = ds_detalle.Tables(1).Rows(0).Item("MovMer_IVA").ToString
            
            tb_total.Text = ds_detalle.Tables(1).Rows(0).Item("MovMer_TOTAL").ToString

            D_consulta_mov_alta.Tables("movimientos_detalle").Rows.Clear()
            D_consulta_mov_alta.Tables("movimientos_detalle").Merge(ds_detalle.Tables(0))

            'CALCULO TOTAL PARA EL PRECIO
            Dim TOTAL As Decimal = 0
            Dim i As Integer = 0
            While i < DataGridView2.Rows.Count
                TOTAL = TOTAL + DataGridView2.Rows(i).Cells("MovMerDet_subtotal").Value

                i = i + 1
            End While
            tb_subtotal.Text = (Math.Round(CDec(TOTAL), 2).ToString("N2"))
            If tb_iva.Text = "" Then
                tb_iva.Text = CDec(0)
                'calculo total
                tb_total.Text = CDec(tb_subtotal.Text)
            End If
        End If
    End Sub
    Dim DAventa As New Datos.Venta
    Dim Ds_reporte_movimientos As New Ds_reporte_movimientos
    'Dim DAgestion_mercaderia As New Datos.Gestion_Mercaderia
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("¿Desea generar un reporte con la información de la consulta actual?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            msj_esperar_b.procedencia = "Consulta_Alta_a_detalle"
            msj_esperar_b.Show()
        End If
    End Sub

    Public Sub reporte() 'este lo llamo desde msj_esperar_a

        '///////////////TABLA SUCURSAL Y EMPRESA///////////////////////////// 
        Dim ds_suc_y_empresa As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id)

        Ds_reporte_movimientos.Tables("Sucursal").Rows.Clear()
        Ds_reporte_movimientos.Tables("Empresa").Rows.Clear()


        If ds_suc_y_empresa.Tables(1).Rows.Count <> 0 Then

            Ds_reporte_movimientos.Tables("Empresa").Merge(ds_suc_y_empresa.Tables(1))
        End If

        If ds_suc_y_empresa.Tables(0).Rows.Count <> 0 Then
            Dim row_sucursal As DataRow = Ds_reporte_movimientos.Tables("Sucursal").NewRow()
            row_sucursal("sucursal") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_nombre")
            row_sucursal("direccion") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_direccion")
            row_sucursal("telefono") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_telefono")
            row_sucursal("mail") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_mail")
            row_sucursal("cuit") = ""
            Ds_reporte_movimientos.Tables("Sucursal").Rows.Add(row_sucursal)
        End If

        'cargamos movimientos y detalles de movimientos
        Ds_reporte_movimientos.Tables("movimientos_consulta").Rows.Clear()
        Ds_reporte_movimientos.Tables("movimientos_detalle").Rows.Clear()
        'Dim i As Integer = 0
        'While i < DataGridView1.Rows.Count
        Dim fila As DataRow = Ds_reporte_movimientos.Tables("movimientos_consulta").NewRow
        fila("MovMer_id") = TextBox_ID.Text
        fila("MovMer_Concepto") = TextBox_concepto.Text
        fila("MovMer_FechaHora") = TextBox_fecha.Text
        fila("sucursal_id_Origen") = 0
        fila("Origen") = TextBox_origen.Text
        fila("sucursal_id_Destino") = 0
        fila("Destino") = ""
        fila("Usuario") = TextBox_usuario.Text
        fila("USU_id") = 0
        fila("factura_nro") = factura_nro.Text
        fila("factura_fecha") = factura_fecha.Text
        fila("remito_nro") = remito_nro.Text
        fila("remito_fecha") = remito_fecha.Text
        fila("Proveedor") = TextBox_proveedor.Text
        fila("MovMer_IVA") = tb_iva.Text
        fila("MovMer_TOTAL") = tb_total.Text
        Ds_reporte_movimientos.Tables("movimientos_consulta").Rows.Add(fila)

        'ahora el detalle
        'Dim id As Integer = DataGridView2.Rows(i).Cells("MovMer_id").Value
        'Dim ds_detalle As DataSet = DAgestion_mercaderia.Movimiento_Mercaderia_obtener_detalle(id)
        'If ds_detalle.Tables(0).Rows.Count <> 0 Then
        Dim j As Integer = 0
        While j < DataGridView2.Rows.Count 
            Dim fila_det As DataRow = Ds_reporte_movimientos.Tables("movimientos_detalle").NewRow
            fila_det("prod_codinterno") = DataGridView2.Rows(j).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
            fila_det("prod_descripcion") = DataGridView2.Rows(j).Cells("ProddescripcionDataGridViewTextBoxColumn").Value
            fila_det("MovMerDet_Cantidad") = DataGridView2.Rows(j).Cells("MovMerDetCantidadDataGridViewTextBoxColumn").Value
            fila_det("MovMer_id") = TextBox_ID.Text
            fila_det("precioU") = DataGridView2.Rows(j).Cells("MovMerDet_precioU").Value
            fila_det("preciosubtotal") = DataGridView2.Rows(j).Cells("MovMerDet_subtotal").Value

            Ds_reporte_movimientos.Tables("movimientos_detalle").Rows.Add(fila_det)
            j = j + 1
        End While

        'End If

        ' i = i + 1
        ' End While

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Consulta_alta_a_detalle_CR.rpt")
        'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
        CrReport.Database.Tables("Empresa").SetDataSource(Ds_reporte_movimientos.Tables("Empresa"))
        CrReport.Database.Tables("Sucursal").SetDataSource(Ds_reporte_movimientos.Tables("Sucursal"))
        CrReport.Database.Tables("movimientos_consulta").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_consulta"))
        CrReport.Database.Tables("movimientos_detalle").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_detalle"))
        Dim visor As New movimientos_show
        visor.CrystalReportViewer1.ReportSource = CrReport
        visor.Text = "Consulta de ingreso. - Imprimir."
        visor.Show()


    End Sub

    
End Class