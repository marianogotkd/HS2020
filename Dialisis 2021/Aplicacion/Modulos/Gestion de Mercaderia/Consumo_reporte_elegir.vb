Public Class Consumo_reporte_elegir

    Dim DS_reporte_consumo As New Ds_reporte_consumo
    Dim DAventa As New Datos.Venta
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        msj_esperar_b.procedencia = "consumos"
        msj_esperar_b.Show()

    End Sub
    Public Sub reporte()


        '///////////////TABLA SUCURSAL Y EMPRESA///////////////////////////// 
        Dim ds_suc_y_empresa As DataSet = DAventa.Obtener_usuario_y_sucursal(Inicio.USU_id)

        DS_reporte_consumo.Tables("Sucursal").Rows.Clear()
        DS_reporte_consumo.Tables("Empresa").Rows.Clear()


        If ds_suc_y_empresa.Tables(1).Rows.Count <> 0 Then

            DS_reporte_consumo.Tables("Empresa").Merge(ds_suc_y_empresa.Tables(1))
        End If

        If ds_suc_y_empresa.Tables(0).Rows.Count <> 0 Then
            Dim row_sucursal As DataRow = DS_reporte_consumo.Tables("Sucursal").NewRow()
            row_sucursal("sucursal") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_nombre")
            row_sucursal("direccion") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_direccion")
            row_sucursal("telefono") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_telefono")
            row_sucursal("mail") = ds_suc_y_empresa.Tables(0).Rows(0).Item("sucursal_mail")
            row_sucursal("cuit") = ""
            DS_reporte_consumo.Tables("Sucursal").Rows.Add(row_sucursal)
        End If
        'cargamos los consumos de la grilla
        DS_reporte_consumo.Tables("consumos_detalle_full").Rows.Clear()
        'Ds_reporte_movimientos.Tables("movimientos_detalle").Rows.Clear()
        Dim i As Integer = 0
        While i < Consumos_consulta.DataGridView1.Rows.Count
            Dim fila As DataRow = DS_reporte_consumo.Tables("consumos_detalle_full").NewRow
            fila("prod_codinterno") = Consumos_consulta.DataGridView1.Rows(i).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
            fila("prod_descripcion") = Consumos_consulta.DataGridView1.Rows(i).Cells("ProddescripcionDataGridViewTextBoxColumn").Value
            fila("Consumo_mercaderiadetalle_cantidad") = Consumos_consulta.DataGridView1.Rows(i).Cells("ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn").Value
            fila("sucursal_id_Origen") = Consumos_consulta.DataGridView1.Rows(i).Cells("SucursalidOrigenDataGridViewTextBoxColumn").Value
            fila("Origen") = Consumos_consulta.DataGridView1.Rows(i).Cells("OrigenDataGridViewTextBoxColumn").Value
            fila("Usuario") = Consumos_consulta.DataGridView1.Rows(i).Cells("UsuarioDataGridViewTextBoxColumn").Value
            fila("USU_id") = Consumos_consulta.DataGridView1.Rows(i).Cells("USUidDataGridViewTextBoxColumn").Value
            fila("Consumo_mercaderia_id") = Consumos_consulta.DataGridView1.Rows(i).Cells("ConsumomercaderiaidDataGridViewTextBoxColumn").Value
            fila("Consumo_mercaderia_concepto") = Consumos_consulta.DataGridView1.Rows(i).Cells("ConsumomercaderiaconceptoDataGridViewTextBoxColumn").Value
            fila("Consumo_mercaderia_FechaHora") = Consumos_consulta.DataGridView1.Rows(i).Cells("ConsumomercaderiaFechaHoraDataGridViewTextBoxColumn").Value
            DS_reporte_consumo.Tables("consumos_detalle_full").Rows.Add(fila)
            i = i + 1
        End While


        If rb_fecha.Checked = True Then
            'form b
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\consumo_b_CR.rpt")
            'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
            CrReport.Database.Tables("Empresa").SetDataSource(DS_reporte_consumo.Tables("Empresa"))
            CrReport.Database.Tables("Sucursal").SetDataSource(DS_reporte_consumo.Tables("Sucursal"))
            CrReport.Database.Tables("consumos_detalle_full").SetDataSource(DS_reporte_consumo.Tables("consumos_detalle_full"))
            Dim visor As New movimientos_show
            visor.CrystalReportViewer1.ReportSource = CrReport
            visor.Text = "Consulta de consumos. - Imprimir."
            visor.Show()
        Else
            'form a
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\consumo_a_CR.rpt")
            'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
            CrReport.Database.Tables("Empresa").SetDataSource(DS_reporte_consumo.Tables("Empresa"))
            CrReport.Database.Tables("Sucursal").SetDataSource(DS_reporte_consumo.Tables("Sucursal"))
            CrReport.Database.Tables("consumos_detalle_full").SetDataSource(DS_reporte_consumo.Tables("consumos_detalle_full"))

            'CrReport.Database.Tables("movimientos_detalle").SetDataSource(Ds_reporte_movimientos.Tables("movimientos_detalle"))
            Dim visor As New movimientos_show
            visor.CrystalReportViewer1.ReportSource = CrReport
            visor.Text = "Consulta de consumos. - Imprimir."
            visor.Show()
        End If
        Me.Close()
    End Sub

End Class