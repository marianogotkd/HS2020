Public Class Consumos_consulta_detalle
    Dim DAgestion_mercaderia As New Datos.Gestion_Mercaderia




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Consumo_consulta_x_concepto.Show()
        Me.Close()
    End Sub

    Private Sub Consumos_consulta_detalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As Integer = CInt(TextBox_ID.Text)
        Dim ds_detalle As DataSet = DAgestion_mercaderia.Consumos_mercaderia_obtener_detalle(id)
        If ds_detalle.Tables(0).Rows.Count <> 0 Then
            Mov_DS.Tables("consumos_detalle").Rows.Clear()
            Mov_DS.Tables("consumos_detalle").Merge(ds_detalle.Tables(0))
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        msj_esperar_b.procedencia = "Consumos_consulta_detalle"
        msj_esperar_b.Show()
    End Sub

    Dim DAventa As New Datos.Venta
    Dim DS_reporte_consumo As New Ds_reporte_consumo
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
        While i < DataGridView2.Rows.Count
            Dim fila As DataRow = DS_reporte_consumo.Tables("consumos_detalle_full").NewRow
            fila("prod_codinterno") = DataGridView2.Rows(i).Cells("ProdcodinternoDataGridViewTextBoxColumn").Value
            fila("prod_descripcion") = DataGridView2.Rows(i).Cells("ProddescripcionDataGridViewTextBoxColumn").Value
            fila("Consumo_mercaderiadetalle_cantidad") = DataGridView2.Rows(i).Cells("ConsumomercaderiadetallecantidadDataGridViewTextBoxColumn").Value
            fila("sucursal_id_Origen") = 0
            fila("Origen") = TextBox_origen.Text
            fila("Usuario") = TextBox_usuario.Text
            fila("USU_id") = 0
            fila("Consumo_mercaderia_id") = TextBox_ID.Text
            fila("Consumo_mercaderia_concepto") = TextBox_concepto.Text
            fila("Consumo_mercaderia_FechaHora") = TextBox_fecha.Text
            DS_reporte_consumo.Tables("consumos_detalle_full").Rows.Add(fila)
            i = i + 1
        End While


        
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


    End Sub

End Class