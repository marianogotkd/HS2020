Public Class Ver_promocion

    Dim DAlista As New Datos.Lista
    Dim ds_PROMO As DataSet
    Public form_procedencia As String = ""
    Public Function Obtener_Promociones_SUB(ByRef i As Integer, ByRef borrado As String)

        If ds_PROMO.Tables(0).Rows.Count <> 0 Then
            Dim dia_actual As Date = Today
            'Dim dia_actual As Date = "14 / 12 /2013"   esta la uso para probar si funciona bien en determinado dia
            Dim dia As String = dia_actual.ToString("dddd")


            Dim d As Integer = 0
            Dim dia_valido As String = ""
            While d < ds_PROMO.Tables(1).Rows.Count
                If ds_PROMO.Tables(0).Rows(i).Item("LISTA_id") = ds_PROMO.Tables(1).Rows(d).Item("LISTA_id") Then
                    dia_valido = "no"
                    Dim dia_semana As String = ""
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "1" Then
                        dia_semana = "domingo"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "2" Then
                        dia_semana = "lunes"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "3" Then
                        dia_semana = "martes"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "4" Then
                        dia_semana = "miércoles"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "5" Then
                        dia_semana = "jueves"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "6" Then
                        dia_semana = "viernes"
                    End If
                    If CInt(ds_PROMO.Tables(1).Rows(d).Item("DIA_id")) = "7" Then
                        dia_semana = "sábado"
                    End If
                    If dia = dia_semana Then
                        dia_valido = "si"
                        d = ds_PROMO.Tables(1).Rows.Count
                    End If
                End If
                d = d + 1
            End While

            If dia_valido = "no" Then
                borrado = "si"
                'ds_PROMO.Tables(0).Rows(i).Delete()
            Else
                dia_valido = ""
                '//////esto es para VIGENCIA/////////////////
                Dim j As Integer = 0
                While j < ds_PROMO.Tables(2).Rows.Count
                    Dim desde As Date = ds_PROMO.Tables(2).Rows(j).Item("LISTA_VIG_desde")
                    Dim hasta As Date = ds_PROMO.Tables(2).Rows(j).Item("LISTA_VIG_hasta")
                    If ds_PROMO.Tables(0).Rows(i).Item("LISTA_id") = ds_PROMO.Tables(2).Rows(j).Item("LISTA_id") Then
                        If (Today < desde) Or (Today > hasta) Then
                            'If (Today < CDate(ds_PROD.Tables(2).Rows(j).Item("LISTA_VIG_desde"))) Or (Today > CDate(ds_PROD.Tables(2).Rows(j).Item("LISTA_VIG_hasta"))) Then

                            'ds_PROMO.Tables(0).Rows(i).Delete()
                            borrado = "si"
                            j = ds_PROMO.Tables(2).Rows.Count
                        End If
                    End If
                    j = j + 1
                End While
            End If
        End If



        Return (borrado)
    End Function

    Public Sub Obtener_Promociones()
        ds_PROMO = DAlista.Lista_Promocion_obtener()
        'junto los prod y los combos..para mostrarlos en el mismo grid
        If ds_PROMO.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < ds_PROMO.Tables(0).Rows.Count
                Dim borrado As String = "no"
                'llamada a procedimiento para borrar.

                Obtener_Promociones_SUB(i, borrado)

                If borrado = "si" Then
                    'ds_PROMO.Tables(0).Rows(i).Delete()
                    ds_PROMO.Tables(0).Rows.RemoveAt(i)
                    i = 0
                Else
                    i = i + 1
                End If
            End While
            DataGridView1.DataSource = ds_PROMO.Tables(0)
            If ds_PROMO.Tables(4).Rows.Count <> 0 Then
                'si hay algun combo uno las dos tablas
                ds_PROMO.Tables(3).Merge(ds_PROMO.Tables(4))
            End If
        End If
    End Sub

    Private Sub Ver_promocion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Ver_promocion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_Promociones()
        Lb_fecha_actual.Text = Today

    End Sub

    Private Sub BO_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_salir.Click
        Me.Close()
    End Sub

    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        DataGridView1.DataSource = Nothing
        If tx_Buscar.Text <> "" Then
            Filtrar_datatable(tx_Buscar.Text)
        Else
            DataGridView1.DataSource = ds_PROMO.Tables(0)
        End If
    End Sub
    Private Sub Filtrar_datatable(ByVal parametro As String)
        If ds_PROMO.Tables(0).Rows.Count <> 0 Then
            'uso ds_PROD que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("LISTA_id")
            table_filtrada.Columns.Add("LISTA_codinterno")
            table_filtrada.Columns.Add("LISTA_nom")
            table_filtrada.Columns.Add("LISTA_fecha")
            table_filtrada.Columns.Add("LISTA_total")
            DataGridView1.DataSource = Nothing
            Dim table As DataTable = ds_PROMO.Tables(0)
            Dim nombre As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("LISTA_nom")
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If
                a = a + 1
            End While
            If table_filtrada.Rows.Count <> 0 Then
                DataGridView1.DataSource = table_filtrada
            Else
                DataGridView1.DataSource = ds_PROMO.Tables(0)
            End If
        End If
    End Sub


    Private Sub BO_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_agregar.Click
        Select form_procedencia
            Case "Venta_Caja_gestion"
                'cuando presiono enter busco el prod o combo en el dataset...DS_PROD
                If DataGridView1.CurrentRow IsNot Nothing Then
                    'Venta_Caja_gestion.TX_busc_codinterno.Text = DataGridView1.CurrentRow.Cells(1).Value
                    'Venta_Caja_gestion.TX_busc_codinterno.Focus()
                    'Venta_Caja_gestion.TX_busc_codinterno.SelectAll()
                    Venta_Caja_gestion.DataGridView1.CurrentRow.Cells("columna_codinterno").Value = DataGridView1.CurrentRow.Cells(1).Value
                    Venta_Caja_gestion.DataGridView1.BeginEdit(True)
                End If
            Case "Mesas_gestion"
                'cuando presiono enter busco el prod o combo en el dataset...DS_PROD
                If DataGridView1.CurrentRow IsNot Nothing Then
                    Mesas_gestion.TX_busc_codinterno.Text = DataGridView1.CurrentRow.Cells(1).Value
                    Mesas_gestion.TX_busc_codinterno.Focus()
                    Mesas_gestion.TX_busc_codinterno.SelectAll()
                End If

            Case "Mesa_cargar"
                'cuando presiono enter busco el prod o combo en el dataset...DS_PROD
                If DataGridView1.CurrentRow IsNot Nothing Then
                    Mesa_cargar.TX_busc_codinterno.Text = DataGridView1.CurrentRow.Cells(1).Value
                    Mesa_cargar.TX_busc_codinterno.Focus()
                    Mesa_cargar.TX_busc_codinterno.SelectAll()
                End If

        End Select
    End Sub



    Private Sub Mostrar_detalle_promocion()
        Lb_combo.Text = "- - - - - - - - - - - - - - - - - - - - - -"
        DataGridView2.DataSource = Nothing
        Venta_Caja_ds.Tables("Promocion_detalles").Rows.Clear()

        If DataGridView1.RowCount <> 0 Then
            If DataGridView1.CurrentRow IsNot Nothing Then
                Dim LISTA_id As Integer = DataGridView1.CurrentRow.Cells(0).Value
                Dim i As Integer = 0
                Dim encontrado As String = "no"
                While i < ds_PROMO.Tables(3).Rows.Count
                    If ds_PROMO.Tables(3).Rows(i).Item("Lista_id") = LISTA_id Then
                        Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value
                        Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Promocion_detalles").NewRow()
                        newCustomersRow("Descripción") = ds_PROMO.Tables(3).Rows(i).Item("prod_descripcion").ToString
                        newCustomersRow("Cantidad") = ds_PROMO.Tables(3).Rows(i).Item("Lista_Prod_cantidad").ToString
                        newCustomersRow("Precio U.") = ds_PROMO.Tables(3).Rows(i).Item("Lista_Prod_precio").ToString
                        newCustomersRow("Precio Subtotal") = ds_PROMO.Tables(3).Rows(i).Item("Lista_Prod_subtotal").ToString
                        newCustomersRow("Lista_id") = ds_PROMO.Tables(3).Rows(i).Item("Lista_id").ToString
                        Venta_Caja_ds.Tables("Promocion_detalles").Rows.Add(newCustomersRow)
                        DataGridView2.DataSource = Venta_Caja_ds.Tables("Promocion_detalles")
                        encontrado = "si"
                    End If
                    i = i + 1
                End While
                If encontrado = "no" Then
                    DataGridView2.DataSource = Nothing
                    Venta_Caja_ds.Tables("Promocion_detalles").Rows.Clear()
                End If
            Else
            End If
        Else
            'aqui tendria q poner los label como estan al principio x defecto
        End If

    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Mostrar_detalle_promocion()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Mostrar_detalle_promocion()
    End Sub
End Class