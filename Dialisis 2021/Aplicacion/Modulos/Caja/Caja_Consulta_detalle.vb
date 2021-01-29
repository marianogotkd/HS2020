Public Class Caja_Consulta_detalle
    Dim DAcaja As New Datos.Caja
    Dim APcaja As New Aplicacion.Caja
    Public caja_id
    Public fechacierre As String

    Private Sub Caja_Consulta_detalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Caja_consulta.Close()
            Caja_consulta.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Caja_Consulta_detalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sucursal_id As Integer = Inicio.suc_id 'yo se q esta sucursal tiene la caja abierta...x la validacion del form del q vengo
        Dim usuario_id As Integer = Inicio.USU_id
        'voy a cargar en la grilla el detalle de la caja
        Dim ds_caja As DataSet = DAcaja.Caja_obtener_detalle_x_cajaID(caja_id)
        If ds_caja.Tables(0).Rows.Count <> 0 Then
            TextBox_montoinicial.Text = CDec(ds_caja.Tables(0).Rows(0).Item("CAJA_montoinicial"))
            TextBox_ingresos_efectivo.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoingresosefectivo")
            TextBox_ingresos_tarjeta.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoingresostarjeta")
            TextBox_egresos_subtotal.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoegresos")
            TextBox_TOTAL.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoneto")
            LB_fecha.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_apertura")
            If ds_caja.Tables(0).Rows(0).Item("CAJA_estado") = 1 Then
            Else
                Lb_fechacierre.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_cierre")
            End If
        End If
        If ds_caja.Tables(1).Rows.Count <> 0 Then
            DG_caja.DataSource = ds_caja.Tables(1)
            ''sumamos los ingresos
            'Dim i As Integer = 0
            'Dim ingresos As Decimal = 0
            'Dim egresos As Decimal = 0
            'While i < DG_caja.Rows.Count
            '    If DG_caja.Rows(i).Cells("CajaTipoMovdescripcionDataGridViewTextBoxColumn").Value = "Ingreso" Then
            '        ingresos = ingresos + CDec(DG_caja.Rows(i).Cells("CAJAdetalleingreso").Value)
            '    End If
            '    If DG_caja.Rows(i).Cells("CajaTipoMovdescripcionDataGridViewTextBoxColumn").Value = "Egreso" Then
            '        egresos = egresos + CDec(DG_caja.Rows(i).Cells("CAJAdetalleegreso").Value)
            '    End If
            '    i = i + 1
            'End While
            ''ahora saco la diferencia
            'Dim total As Decimal = CDec(TextBox_montoinicial.Text) + ingresos - egresos
            'TextBox_ingresos_subtotal.Text = ingresos
            'TextBox_egresos_subtotal.Text = egresos
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Caja_consulta.Show()
        Me.Close()
    End Sub

    Private Sub DG_caja_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_caja.CellContentClick

    End Sub
End Class