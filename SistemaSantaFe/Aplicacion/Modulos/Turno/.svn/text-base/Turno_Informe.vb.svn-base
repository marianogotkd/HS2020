Public Class Turno_Informe

    Dim DAturno As New Datos.Turno

    Dim TURNO_CONF_desde As DateTime
    Dim TURNO_CONF_hasta As DateTime

    Private Sub BO_Informe_TurnoReservado_Click(sender As System.Object, e As System.EventArgs) Handles BO_Informe_TurnoReservado.Click
        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(DT_FECHA_desde.Value, 1)
        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde")
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta")

        Dim ds_TurnoReservado As DataSet = DAturno.TurnoInforme_ReservadoComun(DT_FECHA_desde.Value, DT_FECHA_hasta.Value, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Informe\CR_InformeTurnoReservadoComun.rpt")
        CrReport.SetDataSource(ds_TurnoReservado.Tables(0))
        Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
        Informe_Mostrar.Show()
    End Sub
End Class