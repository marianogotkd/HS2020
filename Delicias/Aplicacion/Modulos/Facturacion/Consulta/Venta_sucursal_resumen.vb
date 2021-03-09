Public Class Venta_sucursal_resumen

    Private Sub Venta_sucursal_resumen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub Venta_sucursal_resumen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer = 0
        While i < Venta_consulta_sucursal.DG_ventas.Rows.Count

            'lo agrego en primera instancia.
            
            Dim cantidad As Integer = 0
            Dim total As Decimal = 0

            Dim usuario_id As Integer = CInt(Venta_consulta_sucursal.DG_ventas.Rows(i).Cells("USUidDataGridViewTextBoxColumn").Value)
            Dim j As Integer = 0
            While j < Venta_consulta_sucursal.DG_ventas.Rows.Count
                If usuario_id = CInt(Venta_consulta_sucursal.DG_ventas.Rows(j).Cells("USUidDataGridViewTextBoxColumn").Value) Then
                    cantidad = cantidad + 1
                    total = total + CDec(Venta_consulta_sucursal.DG_ventas.Rows(j).Cells("ventaprod_total").Value)
                End If
                j = j + 1
            End While

            'ahora controlo que no este en datatable resumen_usuarios
            Dim existe = "no"
            j = 0
            While j < Venta_consulta_ds.Tables("Resumen_usuarios").Rows.Count
                If usuario_id = CInt(Venta_consulta_ds.Tables("Resumen_usuarios").Rows(j).item("usuario_id")) Then
                    existe = "si"
                    Exit While
                End If
                j = j + 1
            End While

            If existe = "no" Then
                Dim row As DataRow = Venta_consulta_ds.Tables("Resumen_usuarios").NewRow()
                row("descripcion") = Venta_consulta_sucursal.DG_ventas.Rows(i).Cells("ApellidoyNombreDataGridViewTextBoxColumn").Value
                row("cant_ventas") = cantidad
                row("total_venta") = total
                row("usuario_id") = usuario_id
                Venta_consulta_ds.Tables("Resumen_usuarios").Rows.Add(row)
            End If
            i = i + 1
        End While
        Dim contador As Integer = Venta_consulta_ds.Tables("Resumen_usuarios").Rows.Count
        DG_usuario.DataSource = Venta_consulta_ds.Tables("Resumen_usuarios")



        i = 0
        While i < Venta_consulta_sucursal.DG_ventas.Rows.Count

            'lo agrego en primera instancia.

            Dim cantidad As Integer = 0
            Dim total As Decimal = 0

            Dim vendedor_id As String = CStr(Venta_consulta_sucursal.DG_ventas.Rows(i).Cells("vendedor_apenom").Value)
            Dim j As Integer = 0
            While j < Venta_consulta_sucursal.DG_ventas.Rows.Count
                If vendedor_id = CStr(Venta_consulta_sucursal.DG_ventas.Rows(j).Cells("vendedor_apenom").Value) Then
                    cantidad = cantidad + 1
                    total = total + CDec(Venta_consulta_sucursal.DG_ventas.Rows(j).Cells("ventaprod_total").Value)
                End If
                j = j + 1
            End While

            'ahora controlo que no este en datatable resumen_vendedores
            Dim existe = "no"
            j = 0
            While j < Venta_consulta_ds.Tables("Resumen_vendedores").Rows.Count
                If vendedor_id = CStr(Venta_consulta_ds.Tables("Resumen_vendedores").Rows(j).Item("vendedor_id")) Then
                    existe = "si"
                    Exit While
                End If
                j = j + 1
            End While

            If existe = "no" Then
                Dim row As DataRow = Venta_consulta_ds.Tables("Resumen_vendedores").NewRow()
                row("descripcion") = Venta_consulta_sucursal.DG_ventas.Rows(i).Cells("vendedor_apenom").Value
                row("cant_ventas") = cantidad
                row("total_venta") = total
                row("vendedor_id") = vendedor_id
                Venta_consulta_ds.Tables("Resumen_vendedores").Rows.Add(row)
            End If
            i = i + 1
        End While
        DG_vendedor.DataSource = Venta_consulta_ds.Tables("Resumen_vendedores")

    End Sub
End Class