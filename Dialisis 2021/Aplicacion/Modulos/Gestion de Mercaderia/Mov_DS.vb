

Partial Public Class Mov_DS
    Partial Class consumos_consultaDataTable

        Private Sub consumos_consultaDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.sucursal_id_OrigenColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
