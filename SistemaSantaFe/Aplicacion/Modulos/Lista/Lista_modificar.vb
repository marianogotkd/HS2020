Public Class Lista_modificar

    Dim DAlista As New Datos.Lista
    Dim ds_ListaProducto As New DataSet

    Private Sub Lista_modificar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BO_LISTA_cargar.Enabled = False
        GP_LISTA_datos.Enabled = False
        GP_LISTA_productos.Enabled = False
        GP_LISTA_producto2.Enabled = False

        ds_ListaProducto.Tables.Add("ListaProducto")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("PROD_id")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("PROD_descripcion")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("LISTA_PROD_cant")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("LISTA_PROD_precioU")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("LISTA_PROD_precio")

        Limpiar()

        BO_codigo.Enabled = False
        BO_codbarra.Enabled = False

        TX_LISTA_nom.TextAlign = HorizontalAlignment.Center
        TX_codigo.TextAlign = HorizontalAlignment.Center
        TX_codbarra.TextAlign = HorizontalAlignment.Center
        TX_descripcion.TextAlign = HorizontalAlignment.Center

        TX_LISTA_PROD_cant.TextAlign = HorizontalAlignment.Center
        TX_LISTA_PROD_precio.TextAlign = HorizontalAlignment.Center
        TX_LISTA_PROD_total.TextAlign = HorizontalAlignment.Center

    End Sub

    'Fecha de Vigencia
    Private Sub RB_LISTA_VIG_si_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_LISTA_VIG_si.CheckedChanged
        GP_Fecha.Enabled = True
    End Sub

    Private Sub RB_LISTA_VIG_no_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_LISTA_VIG_no.CheckedChanged
        GP_Fecha.Enabled = False
    End Sub

    'Dias
    Private Sub RB_LISTA_DIA_si_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_LISTA_DIA_si.CheckedChanged
        GP_dias.Enabled = True
    End Sub

    Private Sub RB_LISTA_DIA_no_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_LISTA_DIA_no.CheckedChanged
        GP_dias.Enabled = False
    End Sub

    Dim ds_LISTA As New DataSet
    'LISTA BUSCAR /////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub BO_LISTA_buscar_Click(sender As System.Object, e As System.EventArgs) Handles BO_LISTA_buscar.Click
        ds_LISTA = DAlista.Lista_Obtener(TX_nom.Text)
        limpiar()
        With ds_LISTA.Tables(0).Rows
            If .Count > 0 Then
                DG_LISTA.DataSource = ds_LISTA.Tables(0)
                IM_LISTA_ERROR.Visible = False
                LB_LISTA_ERROR.Visible = False
            Else
                DG_LISTA.DataSource = Nothing
                IM_LISTA_ERROR.Visible = True
                LB_LISTA_ERROR.Visible = True
            End If
        End With
    End Sub

    Private Sub DG_LISTA_SelectionChanged(sender As Object, e As EventArgs) Handles DG_LISTA.SelectionChanged
        If ((DG_LISTA.CurrentRow Is Nothing) OrElse (DG_LISTA.SelectedRows.Count <> 0)) And DG_LISTA.Rows.Count > 0 Then
            BO_LISTA_cargar.Enabled = True
        Else
            BO_LISTA_cargar.Enabled = False
        End If
    End Sub

    Dim LISTA_id As String
    'LISTA CARGAR /////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub BO_LISTA_cargar_Click(sender As System.Object, e As System.EventArgs) Handles BO_LISTA_cargar.Click

        GP_LISTA_datos.Enabled = True
        GP_LISTA_productos.Enabled = True
        GP_LISTA_producto2.Enabled = True
        TabControl2.SelectedTab = TabPage2

        LISTA_id = DG_LISTA.SelectedRows(0).Cells("LISTAidDataGridViewTextBoxColumn").Value.ToString
        TX_LISTA_nom.Text = DG_LISTA.SelectedRows(0).Cells("LISTAnomDataGridViewTextBoxColumn").Value.ToString

        Dim ds_LISTA_DIA As DataSet = DAlista.ListaDia_Obtener(LISTA_id)
        With ds_LISTA_DIA.Tables(0).Rows
            If .Count > 0 Then
                RB_LISTA_DIA_si.Checked = True
                For Each row As DataRow In ds_LISTA_DIA.Tables(0).Rows
                    If Convert.ToString(row("DIA_id")) = 1 Then
                        CK_domingo.Checked = True
                    End If
                    If Convert.ToString(row("DIA_id")) = 2 Then
                        CK_lunes.Checked = True
                    End If
                    If Convert.ToString(row("DIA_id")) = 3 Then
                        CK_martes.Checked = True
                    End If
                    If Convert.ToString(row("DIA_id")) = 4 Then
                        CK_miecoles.Checked = True
                    End If
                    If Convert.ToString(row("DIA_id")) = 5 Then
                        CK_jueves.Checked = True
                    End If
                    If Convert.ToString(row("DIA_id")) = 6 Then
                        CK_viernes.Checked = True
                    End If
                    If Convert.ToString(row("DIA_id")) = 7 Then
                        CK_sabado.Checked = True
                    End If
                Next
            Else
                RB_LISTA_DIA_no.Checked = True
            End If
        End With

        Dim ds_LISTA_VIG As DataSet = DAlista.ListaVigencia_Obtener(LISTA_id)
        With ds_LISTA_VIG.Tables(0).Rows
            If .Count > 0 Then
                RB_LISTA_VIG_si.Checked = True
                For Each vigencia As DataRow In ds_LISTA_VIG.Tables(0).Rows
                    DT_LISTA_fecha_desde.Value = Convert.ToString(vigencia("LISTA_VIG_desde"))
                    DT_LISTA_fecha_hasta.Value = Convert.ToString(vigencia("LISTA_VIG_hasta"))
                Next
            Else
                RB_LISTA_VIG_no.Checked = True
            End If
        End With

        Dim ds_LISTA_PROD As DataSet = DAlista.ListaProducto_Obtener(LISTA_id)
        DG_ListaProducto.DataSource = ds_LISTA_PROD.Tables(0)

    End Sub


    'LIMPIAR //////////////////////////////////////////////////////////////////////////////////////////////////////
    Public Sub limpiar()
        GP_LISTA_datos.Enabled = False
        GP_LISTA_productos.Enabled = False
        GP_LISTA_producto2.Enabled = False

        TX_LISTA_nom.Text = Nothing
        TX_codbarra.Text = Nothing
        TX_codigo.Text = Nothing
        TX_descripcion.Text = Nothing
        RB_LISTA_DIA_si.Checked = False
        RB_LISTA_VIG_si.Checked = False
        RB_LISTA_VIG_no.Checked = True
        RB_LISTA_DIA_no.Checked = True
        DT_LISTA_fecha_desde.Value = Now
        DT_LISTA_fecha_hasta.Value = Now
        CK_lunes.Checked = False
        CK_martes.Checked = False
        CK_miecoles.Checked = False
        CK_jueves.Checked = False
        CK_viernes.Checked = False
        CK_sabado.Checked = False
        CK_domingo.Checked = False
        TX_LISTA_PROD_cant.Text = Nothing
        TX_LISTA_PROD_precio.Text = Nothing
        TX_LISTA_PROD_total.Text = Nothing

        TX_nom.Text = Nothing
        DG_LISTA.DataSource = Nothing

        DG_Producto.DataSource = Nothing
        Lista_ds.Tables("Producto").Clear()
        DG_ListaProducto.DataSource = Nothing
        Lista_ds.Tables("ListaProducto").Clear()
        TabControl2.SelectedTab = TabPage1
    End Sub

    Private Sub BO_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles BO_limpiar.Click
        limpiar()
    End Sub



End Class