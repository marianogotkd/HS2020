Public Class CostosInd_Consulta
    Dim dacosto As New Datos.Costo_Indirecto
    Dim Ds_Costo As New DataSet
  


    Private Sub CostosInd_Consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_Costos_indirectos()
    End Sub

    Public Sub Obtener_Costos_indirectos()
        Ds_Costo = dacosto.Costo_Indirecto_Obtener
        If Ds_Costo.Tables(0).Rows.Count <> 0 Then
            Costo_Ind.Tables("Costo_Indirecto_Obtener").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Costo_Ind.Tables("Costo_Indirecto_Obtener").Merge(Ds_Costo.Tables(0)) '' al combinarla con el dataset "cliente" ya puedo filtrar
            'DG_clientes.DataSource = ds_clie.Tables(0)
            'DG_clientes_old.DataSource = ds_clie.Tables(0)
        End If
    End Sub


    Private Sub BO_cliente_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_nuevo.Click
        CostoInd_alta.Show()
    End Sub

    Private Sub BO_cliente_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_modificar.Click
        If DG_CostoI.Rows.Count <> 0 Then
            CostoInd_alta.Costo_Id = DG_CostoI.SelectedCells(0).Value
            CostoInd_alta.Show()
        End If
        
    End Sub
End Class