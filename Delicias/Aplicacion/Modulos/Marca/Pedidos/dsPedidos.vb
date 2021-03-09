

Partial Public Class dsPedidos
    Partial Class DataTable1DataTable

    End Class

    Partial Class PedidosConsultaDataTable

        Private Sub PedidosConsultaDataTable_PedidosConsultaRowChanging(ByVal sender As System.Object, ByVal e As PedidosConsultaRowChangeEvent) Handles Me.PedidosConsultaRowChanging

        End Sub

    End Class

    Partial Class PedidosDataTable



    End Class

    Partial Class Obtener_PedidosDataTable

        Private Sub Obtener_PedidosDataTable_Obtener_PedidosRowChanging(ByVal sender As System.Object, ByVal e As Obtener_PedidosRowChangeEvent) Handles Me.Obtener_PedidosRowChanging

        End Sub

        Private Sub Obtener_PedidosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.prod_ptorepoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
