Public Class Marca_Modificar
    Dim DAMarca As New Datos.Marca
    Dim DS_Marca As New Marca_DS



    Private Sub Marca_Modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DS_Marca.Tables("Marca").Clear()
        Dim DS As DataSet = DAMarca.Marca_obtener

        DS_Marca.Tables("Marca").Merge(DS.Tables(0))


        DG_Marca.DataSource = DS_Marca.Tables("Marca")


    End Sub

    Private Sub btn_eliminar_seleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_seleccion.Click
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        Dim item
        If DG_Marca.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DG_Marca.Rows.Count
                If DG_Marca.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    item = DG_Marca.Rows(i).Cells("Marca_id").Value
                    If item = "41" Then
                        MsgBox("No se puede eliminar la marca por Defecto", MsgBoxStyle.Information, "Sistema de Gestion")
                        i = DG_Marca.Rows.Count
                    Else

                        If pregunta = "no" Then
                            If MsgBox("Esta seguro que quiere eliminar la marca? La misma se borrara de la Base de Datos y si tiene productos asociados los mismos pasaran a marca Defecto.", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                                pregunta = "si"
                            Else
                                'aqui corto el ciclo, ya que se cancelo la eliminacion
                                i = DG_Marca.Rows.Count
                            End If
                        End If
                        If pregunta = "si" Then
                            'primero guardo el nro de item q contiene
                            item = DG_Marca.Rows(i).Cells("Marca_id").Value



                            DAMarca.Marca_eliminar(item)
                            DG_Marca.Rows.RemoveAt(i)
                            i = 0 'lo reinicio, x q al quitar un ite, se reordenan los indices

                            'If item <= Venta_Caja_ds.Tables("Producto_agregado").Rows.Count Then 'esta validacion es x q el ds tiene menos celdas 
                            '    Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Delete()
                            'End If

                            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                            'cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
                            'Dim a As Integer = 0
                            'While a < DG_Marca.Rows.Count
                            '    If DG_Marca.Rows(a).Cells(1).Value <> 0 Then
                            '        DG_Marca.Rows(a).Cells(0).Value = a + 1
                            '    End If

                            '    a = a + 1
                            'End While
                            'calcular_totales()
                            'aplicar_iva()
                        End If
                    End If
                Else
                    i = i + 1
                End If

            End While
        End If

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click

            For Each row As DataGridViewRow In DG_Marca.Rows

            If row.Cells("Marca_id").Value = "41" Then

            Else
                DAMarca.Marca_Modificar(row.Cells("Marca_id").Value, row.Cells("Marca_nom").Value)
            End If

            Next
            MsgBox("Los datos se actualizaron correctamente", MsgBoxStyle.Information, "Sistema de Gestion")
            Me.Close()

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub
End Class