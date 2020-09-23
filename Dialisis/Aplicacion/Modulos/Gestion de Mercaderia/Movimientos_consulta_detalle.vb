Public Class Movimientos_consulta_detalle
    Dim DAgestion_mercaderia As New Datos.Gestion_Mercaderia
    Public tipo_consulta As String
    Private Sub Movimientos_consulta_detalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim id As Integer = CInt(TextBox_ID.Text)
        Dim ds_detalle As DataSet = DAgestion_mercaderia.Movimiento_Mercaderia_obtener_detalle(id)
        If ds_detalle.Tables(0).Rows.Count <> 0 Then
            Mov_DS.Tables("movimientos_detalle").Rows.Clear()
            Mov_DS.Tables("movimientos_detalle").Merge(ds_detalle.Tables(0))
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If tipo_consulta = "solo bajas" Then
            Movimientos_consulta.tipo_consulta = "solo bajas"
        End If
        If tipo_consulta = "solo movimientos" Then
            Movimientos_consulta.tipo_consulta = "solo movimientos"
        End If
        Movimientos_consulta.Show()
        Me.Close()
    End Sub
End Class