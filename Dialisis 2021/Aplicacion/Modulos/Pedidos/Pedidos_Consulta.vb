Public Class Pedidos_Consulta

    Dim DAPedidos As New Datos.Pedidos

    Dim PedidoEstado_ds As DataSet = DAPedidos.PedidoEstado_obtener

    Private Sub Pedidos_Consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pedidos_Limpiar()
        Pedidos_obtener()

        COM_PEDIDO_EST.DataSource = PedidoEstado_ds.Tables(0)
        COM_PEDIDO_EST.DisplayMember = "PEDIDO_EST_nom"
        COM_PEDIDO_EST.ValueMember = "PEDIDO_EST_id"
    End Sub
    Dim ds_Obtener_Pendiente As DataSet
    Public Sub Pedidos_obtener()
        ds_Obtener_Pendiente = DAPedidos.Pedidos_Obtener_Pendiente()
        If ds_Obtener_Pendiente.Tables(0).Rows.Count <> 0 Then
            DG_Pedidos.DataSource = ds_Obtener_Pendiente.Tables(0)
            Label4.Visible = False
        Else
            Label4.Visible = True
            DG_Pedidos.DataSource = Nothing
        End If
    End Sub
    Dim ds_Obtener_Listo As DataSet
    Private Sub Bo_Listos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_Listos.Click
        ds_Obtener_Listo = DAPedidos.Pedidos_Obtener_Listo
        If ds_Obtener_Listo.Tables(0).Rows.Count <> 0 Then
            DG_Pedidos.DataSource = ds_Obtener_Listo.Tables(0)
            Label4.Visible = False
        Else
            Label4.Visible = True
            DG_Pedidos.DataSource = Nothing
        End If
    End Sub


    Private Sub Bo_Pendientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_Pendientes.Click
        ds_Obtener_Pendiente = DAPedidos.Pedidos_Obtener_Pendiente()
        If ds_Obtener_Pendiente.Tables(0).Rows.Count <> 0 Then
            DG_Pedidos.DataSource = ds_Obtener_Pendiente.Tables(0)
            Label4.Visible = False
        Else
            Label4.Visible = True
            DG_Pedidos.DataSource = Nothing
        End If
    End Sub

    Private Sub DG_Pedidos_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Pedidos.SelectionChanged
        If ((DG_Pedidos.CurrentRow Is Nothing) OrElse (DG_Pedidos.SelectedRows.Count <> 0)) And DG_Pedidos.Rows.Count > 0 Then
            Bo_ir.Enabled = True
        Else
            Bo_ir.Enabled = False
        End If
    End Sub

    Private Sub Bo_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_ir.Click
        If Me.DG_Pedidos.CurrentRow IsNot Nothing Then

            Dim Pedido As Integer = DG_Pedidos.SelectedCells(0).Value
            If Pedido <> 0 Then
                lbl_Pedido.Text = DG_Pedidos.CurrentRow.Cells("PedidosCodDataGridViewTextBoxColumn").Value
                lbl_fecha.Text = DG_Pedidos.CurrentRow.Cells("PedidosFechaDataGridViewTextBoxColumn").Value
                lbl_Proveedor.Text = DG_Pedidos.CurrentRow.Cells("ProvnombreDataGridViewTextBoxColumn").Value
                LB_Pedidos_total.Text = DG_Pedidos.CurrentRow.Cells("PedidosTotalDataGridViewTextBoxColumn").Value
                COM_PEDIDO_EST.SelectedValue = DG_Pedidos.SelectedRows(0).Cells("PedidosEstadoDataGridViewTextBoxColumn").Value.ToString
                recuperar_datos()

                GP_Pedido.Enabled = False
                Bo_ir.Enabled = False

                GP_detalle.Enabled = True
                BO_Eliminar.Enabled = True

                Me.TabControl1.SelectedTab = TabPage2

            Else
                MsgBox("Seleccione un empleado", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un empleado", MsgBoxStyle.Information)
        End If
    End Sub
    Dim dspedidos2 As New DataSet

    Public Sub recuperar_datos()

        dspedidos2 = DAPedidos.Pedidos_Detalle_Consulta(DG_Pedidos.CurrentRow.Cells("PedidosidDataGridViewTextBoxColumn").Value)

        DG_Detalle.DataSource = ""
        DG_Detalle.DataSource = dspedidos2.Tables(0)
    End Sub


    'MODIFICAR /////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub TX_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_Cantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Pedidos_ActualizarCantidad()
        End If
    End Sub

    Private Sub TX_Precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_Precio.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not TX_Precio.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Pedidos_ActualizarPrecio()
        End If
    End Sub

    Private Sub DG_Detalle_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Detalle.SelectionChanged
        TX_Precio.Text = DG_Detalle.CurrentRow.Cells("ProvProdComprecioDataGridViewTextBoxColumn").Value
        TX_Cantidad.Text = DG_Detalle.CurrentRow.Cells("PedidosDetCantidaDataGridViewTextBoxColumn").Value
    End Sub

    Private Sub BO_Cantidad_Click(sender As System.Object, e As System.EventArgs) Handles BO_Cantidad.Click
        Pedidos_ActualizarCantidad()
    End Sub

    Private Sub BO_Precio_Click(sender As System.Object, e As System.EventArgs) Handles BO_Precio.Click
        Pedidos_ActualizarPrecio()
    End Sub

    Public Sub Pedidos_ActualizarPrecio()
        Dim PedidoDet_total As Decimal = TX_Precio.Text * DG_Detalle.SelectedRows(0).Cells("PedidosDetCantidaDataGridViewTextBoxColumn").Value
        DAPedidos.Pedidos_ActualizarPrecio(DG_Detalle.SelectedRows(0).Cells("Prov_Prod_Com_id").Value.ToString, TX_Precio.Text, DG_Detalle.SelectedRows(0).Cells("PedidosDetIDDataGridViewTextBoxColumn").Value.ToString, PedidoDet_total)
        recuperar_datos()
        Pedidos_Total()
    End Sub

    Public Sub Pedidos_ActualizarCantidad()
        Dim PedidoDet_total As Decimal = TX_Cantidad.Text * DG_Detalle.SelectedRows(0).Cells("ProvProdComprecioDataGridViewTextBoxColumn").Value
        'DAPedidos.Pedidos_ActualizarCantidad(DG_Detalle.SelectedRows(0).Cells("PedidosDetIDDataGridViewTextBoxColumn").Value.ToString, TX_Cantidad.Text, PedidoDet_total)
        recuperar_datos()
        Pedidos_Total()
    End Sub

    Public Sub Pedidos_Total()
        Dim Pedido_id As Integer = DG_Pedidos.SelectedRows(0).Cells("PedidosidDataGridViewTextBoxColumn").Value.ToString
        Dim Pedido_Total As Decimal = 0
        Dim B As Integer = 0

        While B < DG_Detalle.Rows.Count
            Pedido_Total = Pedido_Total + DG_Detalle.Rows(B).Cells("PedidosDet_Total").Value.ToString
            B = B + 1
        End While
        DAPedidos.Pedidos_ActualizarTotal(Pedido_id, Pedido_Total)
        LB_Pedidos_total.Text = Pedido_Total
    End Sub


    'LIMPIAR /////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub BO_borrar_Click(sender As System.Object, e As System.EventArgs) Handles BO_borrar.Click
        Pedidos_Limpiar()
    End Sub

    Public Sub Pedidos_Limpiar()
        Pedidos_obtener()
        GP_Pedido.Enabled = True
        Me.TabControl1.SelectedTab = Pedidos

        GP_detalle.Enabled = False
        DG_Detalle.DataSource = Nothing
        TX_Cantidad.Text = Nothing
        TX_Precio.Text = Nothing

        lbl_Pedido.Text = Nothing
        lbl_Proveedor.Text = Nothing
        lbl_fecha.Text = Nothing
        LB_Pedidos_total.Text = Nothing

        BO_Eliminar.Enabled = False
        BO_guardar.Enabled = False
    End Sub

    'GUARDAR /////////////////////////////////////////////////////////////////////////////////////////////////

    Dim DAproducto As New Datos.Producto
    Dim DAegreso As New Datos.Egresos

    Private Sub COM_PEDIDO_EST_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_PEDIDO_EST.SelectedIndexChanged
        If PedidoEstado_ds.Tables(0).Rows(COM_PEDIDO_EST.SelectedIndex).Item("PEDIDO_EST_id").ToString = 3 Then
            DT_Egreso_fecha.Enabled = True
        Else
            DT_Egreso_fecha.Enabled = False
        End If

        If DG_Pedidos.Rows.Count > 0 Then
            If PedidoEstado_ds.Tables(0).Rows(COM_PEDIDO_EST.SelectedIndex).Item("PEDIDO_EST_id").ToString <> DG_Pedidos.SelectedRows(0).Cells("PedidosEstadoDataGridViewTextBoxColumn").Value Then
                BO_guardar.Enabled = True
            Else
                BO_guardar.Enabled = False
            End If
        End If

    End Sub

    Private Sub BO_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BO_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Actualizar el Estado del Pedido?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim Pedido_id As Integer = DG_Pedidos.SelectedRows(0).Cells("PedidosidDataGridViewTextBoxColumn").Value.ToString
            Dim Pedido_estado As String = PedidoEstado_ds.Tables(0).Rows(COM_PEDIDO_EST.SelectedIndex).Item("PEDIDO_EST_id").ToString
            'DAPedidos.Pedidos_ActualizarEstado(Pedido_id, Pedido_estado)

            If Pedido_estado = 3 Then
                'Actualizar Stock
                Dim B As Integer = 0
                While B < DG_Detalle.Rows.Count
                    Dim Prod_id As Integer = DG_Detalle.Rows(B).Cells("Prod_id").Value.ToString
                    Dim Prod_stock As Integer = DG_Detalle.Rows(B).Cells("PedidosDetCantidaDataGridViewTextBoxColumn").Value.ToString
                    DAproducto.Producto_ActualizarStock(Prod_id, Prod_stock)
                    B = B + 1
                End While


                'Actualizar Egreso
                DAegreso.Egresos_alta(1, "", LB_Pedidos_total.Text, DT_Egreso_fecha.Value, lbl_fecha.Text, lbl_Pedido.Text, DG_Pedidos.SelectedRows(0).Cells("Prov_id").Value.ToString, Inicio.USU_id)

            End If

            MessageBox.Show("El Pedido fue Actualizado correctamente.", "Sistema de Gestion.")
            Pedidos_Limpiar()
        End If
    End Sub

    Private Sub BO_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Eliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Eliminar el Pedido?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim Pedido_id As Integer = DG_Pedidos.SelectedRows(0).Cells("PedidosidDataGridViewTextBoxColumn").Value.ToString
            DAPedidos.Pedidos_Eliminar(Pedido_id)

            MessageBox.Show("El Pedido fue Eliminado correctamente.", "Sistema de Gestion.")
            Pedidos_Limpiar()
        End If
    End Sub





  
    Private Sub btn_fecha_listo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fecha_listo.Click

        Dim ds_Obtener As DataSet = DAPedidos.Pedidos_Obtener_Listo_Fecha(DT_FECHA_desde.Text, DT_FECHA_hasta.Text)
        If ds_Obtener.Tables(0).Rows.Count <> 0 Then
            DG_Pedidos.DataSource = ds_Obtener.Tables(0)
            Label4.Visible = False
        Else
            Label4.Visible = True
            DG_Pedidos.DataSource = Nothing
        End If

     
    End Sub

    Dim ds_Obtener_fecha As DataSet
    Private Sub btn_fecha_pen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fecha_pen.Click

        ds_Obtener_fecha = DAPedidos.Pedidos_Obtener_Pendiente_Fecha(DT_FECHA_desde.Text, DT_FECHA_hasta.Text)
        If ds_Obtener_fecha.Tables(0).Rows.Count <> 0 Then
            DG_Pedidos.DataSource = ds_Obtener_fecha.Tables(0)
            Label4.Visible = False
        Else
            Label4.Visible = True
            DG_Pedidos.DataSource = Nothing
        End If

    End Sub

    
  
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ' Dim ds_cliente As DataSet = DAcliente.Informe_Cliente

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CrReport.Load(Application.StartupPath & "\..\..\Informe\CR_Informe_Pedidos.rpt")

        DsPedidos.Tables("Pedidos_Obtener").Rows.Clear()
        Dim ProductoRow As DataRow = DsPedidos.Tables("Pedidos_Obtener").NewRow()
        ProductoRow("Pedidos_id") = DG_Pedidos.CurrentRow.Cells(4).Value
        ProductoRow("Pedidos_Cod") = DG_Pedidos.CurrentRow.Cells(5).Value
        ProductoRow("Pedidos_Fecha") = DG_Pedidos.CurrentRow.Cells(6).Value
        ProductoRow("Pedidos_Total") = DG_Pedidos.CurrentRow.Cells(0).Value
        ProductoRow("Prov_nombre") = DG_Pedidos.CurrentRow.Cells(2).Value
        ProductoRow("Pedidos_Estado") = DG_Pedidos.CurrentRow.Cells(3).Value
        ProductoRow("PEDIDO_EST_nom") = DG_Pedidos.CurrentRow.Cells(7).Value
        ProductoRow("Prov_id") = DG_Pedidos.CurrentRow.Cells(1).Value

        DsPedidos.Tables("Pedidos_Obtener").Rows.Add(ProductoRow)


        CrReport.Database.Tables("Pedidos_Obtener").SetDataSource(DsPedidos.Tables("Pedidos_Obtener"))
        CrReport.Database.Tables("Pedido_Detalle").SetDataSource(dspedidos2.Tables(0))
        'CrReport.SetDataSource(ds_Jugador.Tables(0))

        Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
        'ERROR_Socio.Visible = False
        Informe_Mostrar.Show()


    End Sub
End Class