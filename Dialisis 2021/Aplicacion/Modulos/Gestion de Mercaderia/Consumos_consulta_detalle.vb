﻿Public Class Consumos_consulta_detalle
    Dim DAgestion_mercaderia As New Datos.Gestion_Mercaderia




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Consumos_consulta.Show()
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
End Class