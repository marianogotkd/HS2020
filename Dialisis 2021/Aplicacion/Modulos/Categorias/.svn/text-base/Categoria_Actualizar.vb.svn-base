Public Class Categoria_Actualizar
    Dim Dacategoria As New Datos.Categoria

    Private Sub Categoria_Actualizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar_categorias()
    End Sub

    Private Sub cargar_categorias()
        Dim ds_categorias As New DataSet
        ds_categorias = Dacategoria.Categoria_obtener_niveles
        Categorias_DS.Tables("Cat_rubro_subrubro").Rows.Clear()
        If ds_categorias.Tables(0).Rows.Count <> 0 Then
            Dim num As Integer = 0
            Dim Rubro As String = ""
            Dim Subrubro As String = ""
            While num < ds_categorias.Tables(0).Rows.Count
                Dim fin_subrubro = 0
                Dim newCustomersRow As DataRow = Categorias_DS.Tables("Cat_rubro_subrubro").NewRow()
                newCustomersRow("cat_id") = ds_categorias.Tables(0).Rows(num).Item(0).ToString
                newCustomersRow("cat1_nom") = ds_categorias.Tables(0).Rows(num).Item(1).ToString
                Dim i = 0
                While i < ds_categorias.Tables(1).Rows.Count
                    If ds_categorias.Tables(0).Rows(num).Item("cat_id") = ds_categorias.Tables(1).Rows(i).Item("cat_id") Then
                        Rubro = Rubro + "/ " + ds_categorias.Tables(1).Rows(i).Item("cat2_nom")
                    End If
                    Dim j = 0
                    If fin_subrubro = 0 Then
                        While j < ds_categorias.Tables(2).Rows.Count
                            If ds_categorias.Tables(0).Rows(num).Item("cat_id") = ds_categorias.Tables(2).Rows(j).Item("cat_id") Then
                                Subrubro = Subrubro + "/ " + ds_categorias.Tables(2).Rows(j).Item("cat3_nom")
                            End If
                            j = j + 1
                        End While
                        fin_subrubro = 1
                    End If


                    i = i + 1

                End While
                newCustomersRow("rubro") = Rubro
                newCustomersRow("subrubro") = Subrubro
                Categorias_DS.Tables("Cat_rubro_subrubro").Rows.Add(newCustomersRow)
                Rubro = ""
                Subrubro = ""


                num = num + 1
            End While
            DataGridView1.DataSource = Categorias_DS.Tables("Cat_rubro_subrubro")
        End If
    End Sub

    Private Sub Button_Detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Detalle.Click
        'no puedo editar la categoria defecto, x eso valido.
        If DataGridView1.Rows.Count <> 0 Then
            'Dim categoriaselec As String = CStr(DataGridView1.SelectedCells(0).Value)
            If DataGridView1.CurrentRow.Cells("Column1").Value = True Then
                If DataGridView1.CurrentRow.Cells("cat1_nom").Value = "Defecto" Then
                    MessageBox.Show("Error, no se puede editar la categoría Defecto.", "Sistema de Gestión.")
                Else
                    Categorias.transaccion = "modificar"
                    Categorias.Show()
                    Me.Close()
                End If
            Else
                MsgBox("Seleccione una categoría.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Categorias.transaccion = "nuevo"
        Categorias.Show()
        Me.Close()
    End Sub

    Private Sub btn_Anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Anular.Click
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            Dim valido As String = "si"
            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("cat1_nom").Value = "Defecto" And DataGridView1.Rows(i).Cells("Column1").Value Then
                    valido = "no"
                    MessageBox.Show("Error, no se puede eliminar la categoría Defecto.", "Sistema de Gestión.")
                End If
                i = i + 1
            End While

            If valido = "si" Then
                i = 0 'reinicio
                While i < DataGridView1.Rows.Count
                    If DataGridView1.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                        If pregunta = "no" Then
                            If MsgBox("Esta seguro que quiere borrar la informacion del item seleccionado?. Los productos asociados a dicha categoria se reasignarán a la categoria por DEFECTO.", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                                pregunta = "si"
                            Else
                                'aqui corto el ciclo, ya que se cancelo la eliminacion
                                i = DataGridView1.Rows.Count
                            End If
                        End If
                        If pregunta = "si" Then
                            Dim categoria_id As Integer = DataGridView1.Rows(i).Cells("cat_id").Value
                            Dacategoria.Categoria_actualizar_defecto(categoria_id, 1)
                            Dim ds_rubro As DataSet = Dacategoria.Categoriarubro_obtener(categoria_id)
                            Dim a As Integer = 0
                            While a < ds_rubro.Tables(0).Rows.Count
                                Dim rubro_id As Integer = ds_rubro.Tables(0).Rows(a).Item("cat2_id")
                                Dacategoria.Categoria_actualizar_defecto(rubro_id, 2)
                                Dim ds_subrubros As DataSet = Dacategoria.rubrosubrubro_obtener(rubro_id)
                                Dim b As Integer = 0
                                While b < ds_subrubros.Tables(0).Rows.Count
                                    Dim subrubro_id As Integer = ds_subrubros.Tables(0).Rows(b).Item("cat3_id")
                                    'aqui hago el update, paso los productos a categoria por "DEFECTO"
                                    Dacategoria.Categoria_actualizar_defecto(subrubro_id, 3)
                                    b = b + 1
                                End While
                                'borro el rubro de la bd
                                ds_subrubros = Dacategoria.Rubro_borror_y_recuperar_subrubros(rubro_id)
                                'borro los subrubos de la bd, si los hay
                                If ds_subrubros.Tables(0).Rows.Count <> 0 Then
                                    Dim aa As Integer = 0
                                    While aa < ds_subrubros.Tables(0).Rows.Count
                                        Dacategoria.Categoria_Subrubro_borrar(ds_subrubros.Tables(0).Rows(aa).Item("cat3_id"))
                                        aa = aa + 1
                                    End While
                                End If
                                a = a + 1
                            End While
                            Dacategoria.Categoria_borrar(categoria_id)
                        End If
                    End If
                    i = i + 1
                End While
                cargar_categorias()
            End If
        End If

    End Sub
End Class