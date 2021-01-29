Public Class Lista_producto_gestion
    Dim DAVentas As New Datos.Venta
    Dim DAlista As New Datos.Lista
    Private Sub Lista_producto_gestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CBox_tipocalculo_2.SelectedIndex = 1 ' selecciono por defecto el calculo de Descuento
        CBox_aplicar_2.SelectedIndex = 0 'selecciono por defecto el item= "prod seleccionado"
    End Sub
#Region "Busqueda de combos"
    Dim ds_COMBO As DataSet
    Private Sub combo_mostrar()
        DataGrid_busqueda.DataSource = ""
        Lista_ds.Tables("Busqueda").Rows.Clear()
        If ds_COMBO Is Nothing Then 'pregunto esto para no consultar cada vez en la bd, directamente uso el dataset con los datos obtenidos la primera vez
            ds_COMBO = DAVentas.Venta_obtenerProducto_Combos(Inicio.USU_id)
        End If
        If ds_COMBO.Tables(2).Rows.Count <> 0 Then
            If tx_busc_combos.Text <> "" Then
                'solo muestro si lo encuentra
                If RB_nomb.Checked = True Then
                    Dim i As String = 0
                    While i < ds_COMBO.Tables(2).Rows.Count
                        Dim parametro As String = tx_busc_combos.Text.ToLower
                        Dim combo_en_tabla As String = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion")
                        combo_en_tabla = combo_en_tabla.ToLower()
                        Dim encontrado As Integer = combo_en_tabla.IndexOf(parametro)
                        If encontrado <> -1 Then
                            Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                            newCustomersRow("cod_interno") = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                            newCustomersRow("descripcion") = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion")
                            newCustomersRow("fecha alta") = ""
                            newCustomersRow("Tipo") = "Combo"
                            Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                            DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                        End If

                        'If tx_busc_combos.Text = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion") Then
                        '    Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                        '    newCustomersRow("cod_interno") = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                        '    newCustomersRow("descripcion") = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion")
                        '    newCustomersRow("fecha alta") = ""
                        '    Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                        '    DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                        'End If
                        i = i + 1
                    End While
                End If
                If RB_codigo.Checked = True Then
                    Dim i As String = 0
                    While i < ds_COMBO.Tables(2).Rows.Count
                        If tx_busc_combos.Text = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno") Then
                            Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                            newCustomersRow("cod_interno") = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                            newCustomersRow("descripcion") = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion")
                            newCustomersRow("fecha alta") = ""
                            newCustomersRow("Tipo") = "Combo"
                            Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                            DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                        End If
                        i = i + 1
                    End While
                End If
            Else
                'mostrar todos los combos existentes
                Dim i As Integer = 0
                While i < ds_COMBO.Tables(2).Rows.Count
                    Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                    newCustomersRow("cod_interno") = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                    newCustomersRow("descripcion") = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion")
                    newCustomersRow("fecha alta") = ""
                    newCustomersRow("Tipo") = "Combo"
                    Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                    i = i + 1
                End While
                DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
            End If
        End If
        tx_busc_combos.Focus()
        tx_busc_combos.SelectAll()

    End Sub
    Private Sub actualizar_listado_combos()
        DataGrid_busqueda.DataSource = ""
        tx_busc_combos.Text = ""
        Lista_ds.Tables("Busqueda").Rows.Clear()

        ds_COMBO = DAVentas.Venta_obtenerProducto_Combos(Inicio.USU_id)

        If ds_COMBO.Tables(2).Rows.Count <> 0 Then
            
                'mostrar todos los combos existentes
                Dim i As Integer = 0
                While i < ds_COMBO.Tables(2).Rows.Count
                    Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                    newCustomersRow("cod_interno") = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                    newCustomersRow("descripcion") = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion")
                    newCustomersRow("fecha alta") = ""
                    newCustomersRow("Tipo") = "Combo"
                    Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                    i = i + 1
                End While
                DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")

        End If
        tx_busc_combos.Focus()
        tx_busc_combos.SelectAll()
    End Sub
    Private Sub tx_busc_combos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_busc_combos.KeyPress
        If RB_codigo.Checked = True Then
            'aqui pongo el codigo para remplazar el punto por una coma
            If e.KeyChar.ToString() = "." Then
                e.KeyChar = ","
            End If
            'a continuacion el codigo para impedir el ingreso de dos comas o letras
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            Else
                If Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                        e.Handled = True
                    End If
                End If
                If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                    e.Handled = True
                End If
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Call combo_mostrar()
        End If
    End Sub
    Private Sub BO_Buscar_combos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Buscar_combos.Click
        Call combo_mostrar()
    End Sub
#End Region

#Region "Busqueda de listas regulares"
    Dim ds_LISTAREGULAR As DataSet
    Private Sub ListaRegular_mostrar()

        DataGrid_busqueda.DataSource = ""
        Lista_ds.Tables("Busqueda").Rows.Clear()
        If ds_LISTAREGULAR Is Nothing Then 'pregunto esto para no consultar cada vez en la bd, directamente uso el dataset con los datos obtenidos la primera vez
            ds_LISTAREGULAR = DAlista.Lista_Regular_obtener()
        End If

        If ds_LISTAREGULAR.Tables(0).Rows.Count <> 0 Then
            If tx_busc_regulares.Text <> "" Then
                'solo muestro si lo encuentra
                If RB_nomb.Checked = True Then
                    Dim i As String = 0
                    While i < ds_LISTAREGULAR.Tables(0).Rows.Count
                        Dim parametro As String = tx_busc_regulares.Text.ToLower
                        Dim combo_en_tabla As String = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_nom")
                        combo_en_tabla = combo_en_tabla.ToLower()
                        Dim encontrado As Integer = combo_en_tabla.IndexOf(parametro)
                        If encontrado <> -1 Then
                            Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                            newCustomersRow("cod_interno") = 0 'ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                            newCustomersRow("descripcion") = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_nom")
                            Dim fecha_alta As Date = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_fecha")
                            newCustomersRow("fecha alta") = fecha_alta.ToString("dd/MM/yyyy")
                            newCustomersRow("Tipo") = "Lista Regular"
                            Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                            DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                        End If

                        'If tx_busc_combos.Text = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion") Then
                        '    Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                        '    newCustomersRow("cod_interno") = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                        '    newCustomersRow("descripcion") = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion")
                        '    newCustomersRow("fecha alta") = ""
                        '    Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                        '    DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                        'End If
                        i = i + 1
                    End While
                End If
                If RB_codigo.Checked = True Then
                    'Dim i As String = 0
                    'While i < ds_LISTAREGULAR.Tables(0).Rows.Count
                    '    If tx_busc_regulares.Text = ds_LISTAREGULAR.Tables(0).Rows(i).Item("prod_codinterno") Then
                    '        Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                    '        newCustomersRow("cod_interno") = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                    '        newCustomersRow("descripcion") = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion")
                    '        newCustomersRow("fecha alta") = ""
                    '        newCustomersRow("Tipo") = "Combo"
                    '        Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                    '        DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                    '    End If
                    '    i = i + 1
                    'End While
                End If
            Else
                'mostrar todos las listas regulares existentes
                Dim i As Integer = 0
                While i < ds_LISTAREGULAR.Tables(0).Rows.Count
                    Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                    newCustomersRow("cod_interno") = 0 'ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                    newCustomersRow("descripcion") = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_nom")
                    Dim fecha_alta As Date = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_fecha")
                    newCustomersRow("fecha alta") = fecha_alta.ToString("dd/MM/yyyy")
                    newCustomersRow("Tipo") = "Lista Regular"
                    Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                    i = i + 1
                End While
                DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
            End If
        End If
        tx_busc_regulares.Focus()
        tx_busc_regulares.SelectAll()
    End Sub
    Private Sub Actualizar_ListasRegulares()
        DataGrid_busqueda.DataSource = ""
        tx_busc_regulares.Text = ""
        Lista_ds.Tables("Busqueda").Rows.Clear()
        ds_LISTAREGULAR = DAlista.Lista_Regular_obtener()
        If ds_LISTAREGULAR.Tables(0).Rows.Count <> 0 Then
            'mostrar todos las listas regulares existentes
            Dim i As Integer = 0
            While i < ds_LISTAREGULAR.Tables(0).Rows.Count
                Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                newCustomersRow("cod_interno") = 0 'ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                newCustomersRow("descripcion") = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_nom")
                Dim fecha_alta As Date = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_fecha")
                newCustomersRow("fecha alta") = fecha_alta.ToString("dd/MM/yyyy")
                newCustomersRow("Tipo") = "Lista Regular"
                Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                i = i + 1
            End While
            DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
        End If
        tx_busc_regulares.Focus()
        tx_busc_regulares.SelectAll()
    End Sub
    Private Sub BO_Buscar_regulares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Buscar_regulares.Click
        ListaRegular_mostrar()
    End Sub
    Private Sub tx_busc_regulares_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_busc_regulares.KeyPress
        If RB_codigo.Checked = True Then
            'aqui pongo el codigo para remplazar el punto por una coma
            If e.KeyChar.ToString() = "." Then
                e.KeyChar = ","
            End If
            'a continuacion el codigo para impedir el ingreso de dos comas o letras
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            Else
                If Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                        e.Handled = True
                    End If
                End If
                If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                    e.Handled = True
                End If
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Call ListaRegular_mostrar()
        End If
    End Sub
#End Region

#Region "Busqueda de listas promocionales"
    Dim ds_promo As DataSet
    Private Sub ListaPromocion_mostrar()
        DataGrid_busqueda.DataSource = ""
        Lista_ds.Tables("Busqueda").Rows.Clear()
        If ds_promo Is Nothing Then 'pregunto esto para no consultar cada vez en la bd, directamente uso el dataset con los datos obtenidos la primera vez
            ds_promo = DAlista.Lista_Promocion_obtener()
        End If
        If ds_promo.Tables(0).Rows.Count <> 0 Then
            If tx_busc_promociones.Text <> "" Then
                'solo muestro si lo encuentra
                If RB_nomb.Checked = True Then
                    Dim i As String = 0
                    While i < ds_promo.Tables(0).Rows.Count
                        Dim parametro As String = tx_busc_promociones.Text.ToLower
                        Dim combo_en_tabla As String = ds_promo.Tables(0).Rows(i).Item("LISTA_nom")
                        combo_en_tabla = combo_en_tabla.ToLower()
                        Dim encontrado As Integer = combo_en_tabla.IndexOf(parametro)
                        If encontrado <> -1 Then
                            Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                            newCustomersRow("cod_interno") = ds_promo.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                            newCustomersRow("descripcion") = ds_promo.Tables(0).Rows(i).Item("LISTA_nom")
                            Dim fecha_alta As Date = ds_promo.Tables(0).Rows(i).Item("LISTA_fecha")
                            newCustomersRow("fecha alta") = fecha_alta.ToString("dd/MM/yyyy")
                            newCustomersRow("Tipo") = "Lista Promoción"
                            Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                            DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                        End If

                        'If tx_busc_combos.Text = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion") Then
                        '    Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                        '    newCustomersRow("cod_interno") = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno").ToString
                        '    newCustomersRow("descripcion") = ds_COMBO.Tables(2).Rows(i).Item("prod_descripcion")
                        '    newCustomersRow("fecha alta") = ""
                        '    Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                        '    DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                        'End If
                        i = i + 1
                    End While
                End If
                If RB_codigo.Checked = True Then
                    Dim i As String = 0
                    While i < ds_promo.Tables(0).Rows.Count
                        Dim busc_promociones As String = tx_busc_promociones.Text
                        busc_promociones = busc_promociones.ToLower
                        Dim promo_tabla As String = ds_promo.Tables(0).Rows(i).Item("LISTA_codinterno")
                        promo_tabla = promo_tabla.ToLower
                        If busc_promociones = promo_tabla Then
                            Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                            newCustomersRow("cod_interno") = ds_promo.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                            newCustomersRow("descripcion") = ds_promo.Tables(0).Rows(i).Item("LISTA_nom")
                            Dim fecha_alta As Date = ds_promo.Tables(0).Rows(i).Item("LISTA_fecha")
                            newCustomersRow("fecha alta") = fecha_alta.ToString("dd/MM/yyyy")
                            newCustomersRow("Tipo") = "Lista Promoción"
                            Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                            DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                        End If
                        i = i + 1
                    End While
                End If
            Else
                'mostrar todos las listas promocion existentes
                Dim i As Integer = 0
                While i < ds_promo.Tables(0).Rows.Count
                    Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                    newCustomersRow("cod_interno") = ds_promo.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                    newCustomersRow("descripcion") = ds_promo.Tables(0).Rows(i).Item("LISTA_nom")
                    Dim fecha_alta As Date = ds_promo.Tables(0).Rows(i).Item("LISTA_fecha")
                    newCustomersRow("fecha alta") = fecha_alta.ToString("dd/MM/yyyy")
                    newCustomersRow("Tipo") = "Lista Promoción"
                    Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                    DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                    i = i + 1
                End While
                DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
            End If
        End If
        tx_busc_promociones.Focus()
        tx_busc_promociones.SelectAll()
    End Sub
    Private Sub Actualizar_ListasPromocionales()
        DataGrid_busqueda.DataSource = ""
        tx_busc_promociones.Text = ""
        Lista_ds.Tables("Busqueda").Rows.Clear()
        ds_promo = DAlista.Lista_Promocion_obtener()
        If ds_promo.Tables(0).Rows.Count <> 0 Then
            'mostrar todos las listas promocion existentes
            Dim i As Integer = 0
            While i < ds_promo.Tables(0).Rows.Count
                Dim newCustomersRow As DataRow = Lista_ds.Tables("Busqueda").NewRow()
                newCustomersRow("cod_interno") = ds_promo.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
                newCustomersRow("descripcion") = ds_promo.Tables(0).Rows(i).Item("LISTA_nom")
                Dim fecha_alta As Date = ds_promo.Tables(0).Rows(i).Item("LISTA_fecha")
                newCustomersRow("fecha alta") = fecha_alta.ToString("dd/MM/yyyy")
                newCustomersRow("Tipo") = "Lista Promoción"
                Lista_ds.Tables("Busqueda").Rows.Add(newCustomersRow)
                DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
                i = i + 1
            End While
            DataGrid_busqueda.DataSource = Lista_ds.Tables("Busqueda")
        End If
        tx_busc_promociones.Focus()
        tx_busc_promociones.SelectAll()


    End Sub

    Private Sub tx_busc_promociones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_busc_promociones.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Call ListaPromocion_mostrar()
        End If
    End Sub
    Private Sub BO_Buscar_promociones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BO_Buscar_promociones.Click
        ListaPromocion_mostrar()
    End Sub
#End Region

#Region "Vigencia"
    Private Sub RB_LISTA_VIG_si_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_LISTA_VIG_si.CheckedChanged
        GP_Fecha.Enabled = True
    End Sub
    Private Sub RB_LISTA_VIG_no_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_LISTA_VIG_no.CheckedChanged
        GP_Fecha.Enabled = False
    End Sub
#End Region

#Region "Dias especiales"
    Private Sub RB_LISTA_DIA_si_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_LISTA_DIA_si.CheckedChanged
        GP_dias.Enabled = True
    End Sub
    Private Sub RB_LISTA_DIA_no_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_LISTA_DIA_no.CheckedChanged
        GP_dias.Enabled = False
    End Sub
#End Region
    Dim LISTA_id As Integer
    Private Sub BO_empleado_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_empleado_modificar.Click

        If DataGrid_busqueda.CurrentRow IsNot Nothing Then
            'Dim cod_interno As Integer = DataGrid_busqueda.SelectedCells(0).Value

            Dim tipo As String = DataGrid_busqueda.SelectedCells(3).Value
            Select Case tipo
                Case "Combo"

                    Call Limpiar()
                    GroupBox5.Enabled = False
                    GroupBox4.Enabled = True 'datos de la lista
                    GroupBox12.Enabled = True 'productos agregados


                    TX_LISTA_nom.Text = DataGrid_busqueda.SelectedCells(1).Value
                    Labe_genero_cod.Text = DataGrid_busqueda.SelectedCells(0).Value
                    RB_combo_prod.Checked = True
                    Tab1.SelectedTab = TabPage0 'paso a la pestaña Lista:datos
                    GroupBox4.Enabled = True 'datos de la lista , pestaña Lista:datos
                    Button3.Enabled = True 'cancelar
                    Button2.Enabled = True 'guardar


                    'obtengo el id del combo q en sql es el campo prod_id de la tabla 2
                    Dim i As Integer = 0
                    Dim combo_id As Integer
                    While i < ds_COMBO.Tables(2).Rows.Count
                        If Labe_genero_cod.Text = ds_COMBO.Tables(2).Rows(i).Item("prod_codinterno") Then
                            combo_id = ds_COMBO.Tables(2).Rows(i).Item("prod_id")
                            'pongo el total en la tabla DataG_listaTotal
                            DataG_listaTotal.Rows.Clear()
                            DataG_listaTotal.Rows.Add()
                            DataG_listaTotal.Rows(0).Cells(0).Value = "TOTAL"
                            DataG_listaTotal.Rows(0).Cells(1).Value = ds_COMBO.Tables(2).Rows(i).Item("prod_precio_vta")
                        End If
                        i = i + 1
                    End While
                    i = 0
                    While i < ds_COMBO.Tables(3).Rows.Count
                        If combo_id = ds_COMBO.Tables(3).Rows(i).Item("ProdCombo_id") Then
                            Dim newCustomersRow As DataRow = Lista_ds.Tables("ListProdModif").NewRow()
                            newCustomersRow("PROD_id") = ds_COMBO.Tables(3).Rows(i).Item("prod_id").ToString  'OK
                            newCustomersRow("prod_descripcion") = ds_COMBO.Tables(3).Rows(i).Item("prod_descripcion").ToString 'OK
                            newCustomersRow("Lista_Prod_cantidad") = ds_COMBO.Tables(3).Rows(i).Item("ProdComboDet_cantidad") 'OK
                            newCustomersRow("Lista_Prod_precio") = CDec(ds_COMBO.Tables(3).Rows(i).Item("ProdComboDet_precio")).ToString("N2") 'OK
                            newCustomersRow("Lista_Prod_subtotal") = CDec(ds_COMBO.Tables(3).Rows(i).Item("ProdComboDet_subtotal")).ToString("N2") 'SOK
                            newCustomersRow("tipo_producto") = "producto" 'SOK
                            Dim prod_id As Integer = ds_COMBO.Tables(3).Rows(i).Item("prod_id") 'este es el id del producto, no combo para buscarlo en tabla 1
                            Dim j As Integer = 0
                            While j < ds_COMBO.Tables(1).Rows.Count
                                If prod_id = ds_COMBO.Tables(1).Rows(j).Item("prod_id") Then
                                    newCustomersRow("prod_codinterno") = ds_COMBO.Tables(1).Rows(j).Item("prod_codinterno").ToString  'RECORRER TABLA 1 PARA OBTENER CODINTERNO
                                    j = ds_COMBO.Tables(1).Rows.Count + 1
                                End If
                                j = j + 1
                            End While
                            Lista_ds.Tables("ListProdModif").Rows.Add(newCustomersRow)
                            DataG_lista.DataSource = Lista_ds.Tables("ListProdModif")
                            DataG_lista.Columns(0).Visible = False
                        End If
                        i = i + 1
                    End While
                Case "Lista Regular"
                    Call Limpiar()
                    GroupBox5.Enabled = False
                    GroupBox4.Enabled = True 'datos de la lista
                    GroupBox12.Enabled = True 'productos agregados

                    TX_LISTA_nom.Text = DataGrid_busqueda.SelectedCells(1).Value
                    'Labe_genero_cod.Text = DataGrid_busqueda.SelectedCells(0).Value
                    RB_list_regular.Checked = True
                    Tab1.SelectedTab = TabPage0 'paso a la pestaña Lista:datos
                    GroupBox4.Enabled = True 'datos de la lista , pestaña Lista:datos
                    Button3.Enabled = True 'cancelar
                    Button2.Enabled = True 'guardar

                    'obtengo el id de la lista regular

                    Dim i As Integer = 0
                    While i < ds_LISTAREGULAR.Tables(0).Rows.Count
                        If TX_LISTA_nom.Text = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_nom") Then
                            LISTA_id = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_id")
                            'pongo el total en la tabla DataG_listaTotal
                            DataG_listaTotal.Rows.Clear()
                            DataG_listaTotal.Rows.Add()
                            DataG_listaTotal.Rows(0).Cells(0).Value = "TOTAL"
                            DataG_listaTotal.Rows(0).Cells(1).Value = ds_LISTAREGULAR.Tables(0).Rows(i).Item("LISTA_total")

                            i = ds_LISTAREGULAR.Tables(0).Rows.Count + 1
                        End If
                        i = i + 1
                    End While

                    Dim DS_PROD As DataSet = DAVentas.Venta_obtenerProducto_listaregular(LISTA_id)

                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With DS_PROD.Tables(1).Rows
                        If .Count > 0 Then
                            DS_PROD.Tables(0).Merge(DS_PROD.Tables(1))
                            'DataGridView1.DataSource = DS_PROD.Tables(0)

                        Else

                            If DS_PROD.Tables(0).Rows.Count <> 0 Then
                                'DataGridView1.DataSource = DS_PROD.Tables(0)
                            Else
                                'DataGridView1.Enabled = False
                                'DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With

                    i = 0
                    While i < DS_PROD.Tables(0).Rows.Count

                        Dim newCustomersRow As DataRow = Lista_ds.Tables("ListProdModif").NewRow()
                        newCustomersRow("PROD_id") = DS_PROD.Tables(0).Rows(i).Item("prod_id").ToString  'OK
                        newCustomersRow("prod_codinterno") = DS_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString 'ok
                        newCustomersRow("prod_descripcion") = DS_PROD.Tables(0).Rows(i).Item("prod_descripcion").ToString 'ok
                        newCustomersRow("Lista_Prod_cantidad") = DS_PROD.Tables(0).Rows(i).Item("Lista_Prod_cantidad").ToString 'ok
                        newCustomersRow("Lista_Prod_precio") = CDec(DS_PROD.Tables(0).Rows(i).Item("Lista_Prod_precio")).ToString("N2")
                        newCustomersRow("Lista_Prod_subtotal") = CDec(DS_PROD.Tables(0).Rows(i).Item("prod_precio_vta")).ToString("N2")

                        'aqui indicamos si el producto es combo o no
                        If DS_PROD.Tables(0).Rows(i).Item("prod_descrilarga").ToString() = "Combo" Then
                            newCustomersRow("tipo_producto") = "combo"
                        Else
                            newCustomersRow("tipo_producto") = "producto"
                        End If

                        Lista_ds.Tables("ListProdModif").Rows.Add(newCustomersRow)
                        DataG_lista.DataSource = Lista_ds.Tables("ListProdModif")
                        DataG_lista.Columns(0).Visible = False
                        i = i + 1
                    End While

                Case "Lista Promoción"
                    Call Limpiar()
                    GroupBox5.Enabled = False 'busqueda "1ra pestaña"
                    GroupBox4.Enabled = True 'datos de la lista
                    GroupBox12.Enabled = True 'productos agregados

                    TX_LISTA_nom.Text = DataGrid_busqueda.SelectedCells(1).Value
                    Labe_genero_cod.Text = DataGrid_busqueda.SelectedCells(0).Value
                    RB_list_prom.Checked = True
                    Tab1.SelectedTab = TabPage0 'paso a la pestaña Lista:datos
                    GroupBox4.Enabled = True 'datos de la lista , pestaña Lista:datos
                    Button3.Enabled = True 'cancelar
                    Button2.Enabled = True 'guardar

                    'obtengo el id de la lista promocion

                    Dim i As Integer = 0
                    While i < ds_promo.Tables(0).Rows.Count
                        If TX_LISTA_nom.Text = ds_promo.Tables(0).Rows(i).Item("LISTA_nom") Then
                            LISTA_id = ds_promo.Tables(0).Rows(i).Item("LISTA_id")
                            'pongo el total en la tabla DataG_listaTotal
                            DataG_listaTotal.Rows.Clear()
                            DataG_listaTotal.Rows.Add()
                            DataG_listaTotal.Rows(0).Cells(0).Value = "TOTAL"
                            DataG_listaTotal.Rows(0).Cells(1).Value = ds_promo.Tables(0).Rows(i).Item("LISTA_total")

                            i = ds_promo.Tables(0).Rows.Count + 1
                        End If
                        i = i + 1
                    End While

                    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    'ahora que tengo el LISTA_id puedo ver si tiene configurado VIGENCIA Y DIAS ESPECIALES

                    GroupBox1.Enabled = True 'fecha vigencia
                    RB_LISTA_VIG_no.Checked = True
                    i = 0

                    While i < ds_promo.Tables(2).Rows.Count
                        If LISTA_id = ds_promo.Tables(2).Rows(i).Item("LISTA_id") Then
                            RB_LISTA_VIG_si.Checked = True
                            'coloco fecha desde - hasta
                            DT_LISTA_fecha_desde.Text = ds_promo.Tables(2).Rows(i).Item("LISTA_VIG_desde")
                            DT_LISTA_fecha_hasta.Text = ds_promo.Tables(2).Rows(i).Item("LISTA_VIG_hasta")
                            i = ds_promo.Tables(2).Rows.Count + 1
                        End If
                        i = i + 1
                    End While


                    GroupBox2.Enabled = True 'dias especiales
                    RB_LISTA_DIA_no.Checked = True
                    i = 0

                    While i < ds_promo.Tables(1).Rows.Count
                        If LISTA_id = ds_promo.Tables(1).Rows(i).Item("LISTA_id") Then
                            RB_LISTA_DIA_si.Checked = True

                            If ds_promo.Tables(1).Rows(i).Item("DIA_id") = "2" Then
                                CK_lunes.Checked = True
                            End If
                            If ds_promo.Tables(1).Rows(i).Item("DIA_id") = "3" Then
                                CK_martes.Checked = True
                            End If
                            If ds_promo.Tables(1).Rows(i).Item("DIA_id") = "4" Then
                                CK_miecoles.Checked = True
                            End If
                            If ds_promo.Tables(1).Rows(i).Item("DIA_id") = "5" Then
                                CK_jueves.Checked = True
                            End If
                            If ds_promo.Tables(1).Rows(i).Item("DIA_id") = "6" Then
                                CK_viernes.Checked = True
                            End If
                            If ds_promo.Tables(1).Rows(i).Item("DIA_id") = "7" Then
                                CK_sabado.Checked = True
                            End If
                            If ds_promo.Tables(1).Rows(i).Item("DIA_id") = "1" Then
                                CK_domingo.Checked = True
                            End If
                        End If
                        i = i + 1
                    End While
                    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    Dim DS_PROD As DataSet = DAlista.Lista_Promocion_recuperar_items(LISTA_id)
                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With DS_PROD.Tables(1).Rows
                        If .Count > 0 Then
                            DS_PROD.Tables(0).Merge(DS_PROD.Tables(1))
                            'DataGridView1.DataSource = DS_PROD.Tables(0)
                        Else
                            If DS_PROD.Tables(0).Rows.Count <> 0 Then
                                'DataGridView1.DataSource = DS_PROD.Tables(0)
                            Else
                                'DataGridView1.Enabled = False
                                'DataGridView1.DataSource = Nothing
                            End If
                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                    i = 0
                    While i < DS_PROD.Tables(0).Rows.Count
                        Dim newCustomersRow As DataRow = Lista_ds.Tables("ListProdModif").NewRow()
                        newCustomersRow("PROD_id") = DS_PROD.Tables(0).Rows(i).Item("prod_id").ToString  'OK
                        newCustomersRow("prod_codinterno") = DS_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString 'ok
                        newCustomersRow("prod_descripcion") = DS_PROD.Tables(0).Rows(i).Item("prod_descripcion").ToString 'ok
                        newCustomersRow("Lista_Prod_cantidad") = DS_PROD.Tables(0).Rows(i).Item("Lista_Prod_cantidad").ToString 'ok
                        newCustomersRow("Lista_Prod_precio") = CDec(DS_PROD.Tables(0).Rows(i).Item("Lista_Prod_precio")).ToString("N2")
                        newCustomersRow("Lista_Prod_subtotal") = CDec(DS_PROD.Tables(0).Rows(i).Item("prod_precio_vta")).ToString("N2")
                        'aqui indicamos si el producto es combo o no
                        If DS_PROD.Tables(0).Rows(i).Item("prod_descrilarga").ToString() = "Combo" Then
                            newCustomersRow("tipo_producto") = "combo"
                        Else
                            newCustomersRow("tipo_producto") = "producto"
                        End If
                        Lista_ds.Tables("ListProdModif").Rows.Add(newCustomersRow)
                        DataG_lista.DataSource = Lista_ds.Tables("ListProdModif")
                        DataG_lista.Columns(0).Visible = False
                        i = i + 1
                    End While
            End Select
        Else
            MsgBox("Error, seleccione un item de la grilla", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub calcular_totales_tabla()

        'aqui calculo el total de la lista/promocion/combo...lo q sea
        DataG_listaTotal.Rows.Clear()

        DataG_listaTotal.Rows.Add()

        'sumamos los subtotales con un ciclo
        Dim sumar As Decimal = "0,00"

        Dim ii As Integer = 0
        While ii < DataG_lista.Rows.Count
            sumar = sumar + DataG_lista.Rows(ii).Cells(5).Value
            ii = ii + 1
        End While
        sumar = Math.Round(sumar, 2)

        DataG_listaTotal.Rows(0).Cells(0).Value = "TOTAL"
        DataG_listaTotal.Rows(0).Cells(1).Value = Math.Round(sumar, 2).ToString("N2")

    End Sub
    Public Sub Limpiar()
        GroupBox1.Enabled = False 'fecha vigencia
        GroupBox2.Enabled = False 'dias especiales
        GroupBox5.Enabled = True 'busqueda
        GroupBox4.Enabled = False  'datos de la lista
        GroupBox12.Enabled = False  'productos agregados
        Button2.Enabled = False
        Button3.Enabled = False
        '///////////////////////////////////pestana 0
        TX_LISTA_nom.Text = Nothing
        RB_LISTA_VIG_si.Checked = False
        RB_LISTA_VIG_no.Checked = True
        DT_LISTA_fecha_desde.Value = Now
        DT_LISTA_fecha_hasta.Value = Now
        RB_LISTA_DIA_si.Checked = False
        RB_LISTA_DIA_no.Checked = True
        CK_lunes.Checked = False
        CK_martes.Checked = False
        CK_miecoles.Checked = False
        CK_jueves.Checked = False
        CK_viernes.Checked = False
        CK_sabado.Checked = False
        CK_domingo.Checked = False
        RB_list_regular.Checked = True
        Labe_genero_cod.Text = ".........."

        '///////////////////////////////////pestana 1
        'TX_codbarra.Text = Nothing
        'TX_codigo.Text = Nothing
        'TX_descripcion.Text = Nothing
        'TX_LISTA_PROD_cant.Text = "1"
        'TX_LISTA_PROD_precio.Text = "00,00"
        'TX_LISTA_PROD_total.Text = "00,00"
        'TX_LISTA_PROD_calculo.Text = "00,00"
        'Label_result.Text = "00,00"
        'Label_preciolista.Text = "00,00"
        'DG_Producto.DataSource = Nothing
        Lista_ds.Tables("Producto").Clear()
        'DG_ListaProducto.DataSource = Nothing
        Lista_ds.Tables("ListProdModif").Clear()
        'DG_TOTALES.DataSource = Nothing
        PicBox_error_nomlista.Visible = False

        '///////////////////////////////////pestana 2
        DataG_listaTotal.Rows.Clear()
        DataG_lista.DataSource = Nothing
        Lista_ds.Tables("ListProdModif").Clear()
        DataG_listaTotal.DataSource = Nothing
        Label_codinterno2.Text = "  "
        Label_preciolista2.Text = "00,00"
        TX_LISTA_PROD_precio2.Text = "00,00"
        TX_LISTA_PROD_cant2.Text = "1"
        TX_LISTA_PROD_total2.Text = "00,00"
        TX_LISTA_PROD_calculo2.Text = "00,00"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Limpiar()
        Tab1.SelectedTab = TabPage1
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Lista_prod_ADD.form_procedencia = "Lista_producto_gestion"
        Lista_prod_ADD.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'aqui elemino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"

        If DataG_lista.Rows.Count <> 0 Then
            If DataG_lista.CurrentRow.Cells(0).Value <> "" Then
                If MsgBox("Esta seguro que quiere borrar la informacion del item seleccionado?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                    'primero guardo el nro de item q contiene
                    Dim item As Decimal = DataG_lista.CurrentRow.Index
                    DataG_lista.Rows.RemoveAt(item)

                    calcular_totales_tabla()
                    'este codigo si va
                    'Call Cargar_Totales(añosdelproyecto)
                    'modificado = 1
                End If
            End If
        End If
        DataG_lista.Refresh()
    End Sub

#Region "Producto seleccionado" 'esta en la pestaña de carga de productos
    Private Sub calcular_total_prod_seleccionado()
        ''cuando modifico la cantidad del producto seleccionado, realizo el calculo para obtener total
        'If TX_LISTA_PROD_cant.Text <> "" And TX_LISTA_PROD_precio.Text <> "" Then
        '    Dim total As Decimal = 0
        '    total = TX_LISTA_PROD_cant.Text * TX_LISTA_PROD_precio.Text
        '    TX_LISTA_PROD_total.Text = CDec(Math.Round(total, 2)).ToString("N2")
        '    'TX_LISTA_PROD_total.Text = Format(TX_LISTA_PROD_total.Text, "##,##0,00")
        'Else
        '    If TX_LISTA_PROD_cant.Text = "" Then
        '        TX_LISTA_PROD_cant.Text = "0"
        '    End If
        '    If TX_LISTA_PROD_precio.Text = "" Then
        '        TX_LISTA_PROD_precio.Text = "00,00"
        '    End If
        'End If

        '////////////////////lo mismo para la seccion de la pestana 2//////////////////////////
        'cuando modifico la cantidad del producto seleccionado, realizo el calculo para obtener total
        If TX_LISTA_PROD_cant2.Text <> "" And TX_LISTA_PROD_precio2.Text <> "" Then
            Dim total As Decimal = 0
            total = TX_LISTA_PROD_cant2.Text * TX_LISTA_PROD_precio2.Text
            TX_LISTA_PROD_total2.Text = CDec(Math.Round(total, 2)).ToString("N2")
            'TX_LISTA_PROD_total.Text = Format(TX_LISTA_PROD_total.Text, "##,##0,00")
        Else
            If TX_LISTA_PROD_cant2.Text = "" Then
                TX_LISTA_PROD_cant2.Text = "0"
            End If
            If TX_LISTA_PROD_precio2.Text = "" Then
                TX_LISTA_PROD_precio2.Text = "00,00"
            End If
        End If

    End Sub
    Private Sub DataG_lista_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataG_lista.CellClick
        'si la celda tiene datos, los pasamos a los textbox de la derecha para editar
        If DataG_lista.CurrentRow IsNot Nothing Then

            Label_codinterno2.Text = DataG_lista.CurrentRow.Cells(1).Value.ToString
            Label_preciolista2.Text = (CDec(DataG_lista.CurrentRow.Cells(4).Value)).ToString("N2") ' lo paso a decima para obtener el formato 00,00
            TX_LISTA_PROD_precio2.Text = (CDec(DataG_lista.CurrentRow.Cells(4).Value)).ToString("N2") ' lo paso a decima para obtener el formato 00,00
            TX_LISTA_PROD_cant2.Text = "1"
            TX_LISTA_PROD_total2.Text = CDec(DataG_lista.CurrentRow.Cells(4).Value).ToString("N2")
            calcular_total_prod_seleccionado()
        End If
    End Sub
    Private Sub DataG_lista_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataG_lista.SelectionChanged
        'si la celda tiene datos, los pasamos a los textbox de la derecha para editar
        If DataG_lista.CurrentRow IsNot Nothing Then
            Label_codinterno2.Text = DataG_lista.CurrentRow.Cells(1).Value.ToString
            Label_preciolista2.Text = (CDec(DataG_lista.CurrentRow.Cells(4).Value)).ToString("N2") ' lo paso a decima para obtener el formato 00,00
            TX_LISTA_PROD_precio2.Text = (CDec(DataG_lista.CurrentRow.Cells(4).Value)).ToString("N2") ' lo paso a decima para obtener el formato 00,00
            TX_LISTA_PROD_cant2.Text = "1"
            TX_LISTA_PROD_total2.Text = CDec(DataG_lista.CurrentRow.Cells(4).Value).ToString("N2")
            calcular_total_prod_seleccionado()
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DataG_lista.CurrentRow IsNot Nothing Then
            'primero verifico que el producto q ingreso no este ya en la grilla
            Dim item = 0
            Dim presente = "no"
            Dim fila_editar = 0
            While item < DataG_lista.Rows.Count
                If DataG_lista.Rows(item).Cells(1).Value = Label_codinterno2.Text Then
                    presente = "si"
                    fila_editar = item
                End If
                item = item + 1
            End While
            'ahora veo de agregar o editar
            If presente = "no" Then

            Else
                'edito una fila existente, solo si el usuario lo desea, pregunta!!!
                Dim result As DialogResult
                result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant2.Text
                    DataG_lista.Rows(fila_editar).Cells(4).Value = TX_LISTA_PROD_precio2.Text
                    DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(TX_LISTA_PROD_total2.Text)
                End If
            End If
        Else
            MsgBox("Seleccione producto", MsgBoxStyle.Information)
        End If
        calcular_totales_tabla()
    End Sub
    Private Sub TX_LISTA_PROD_precio2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TX_LISTA_PROD_precio2.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                calcular_total_prod_seleccionado()
        End Select
    End Sub
    Private Sub TX_LISTA_PROD_precio2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_LISTA_PROD_precio2.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.TX_LISTA_PROD_precio2.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub TX_LISTA_PROD_precio2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_LISTA_PROD_precio2.LostFocus
        calcular_total_prod_seleccionado()
    End Sub
    Private Sub TX_LISTA_PROD_cant2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TX_LISTA_PROD_cant2.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                calcular_total_prod_seleccionado()
        End Select
    End Sub
    Private Sub TX_LISTA_PROD_cant2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_LISTA_PROD_cant2.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                    e.Handled = True
                End If
            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TX_LISTA_PROD_cant2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_LISTA_PROD_cant2.LostFocus
        calcular_total_prod_seleccionado()
    End Sub
    Private Sub TX_LISTA_PROD_total2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_LISTA_PROD_total2.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.TX_LISTA_PROD_total2.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region "Calculo auxiliar para precio"
    Private Sub CBox_tipocalculo_2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBox_tipocalculo_2.SelectedIndexChanged
        'PRIMERO VEMOS SI ES CALCULO PARA PRECIO DE PRODUCTO SELECCIONADO O SOBRE EL TOTAL
        If CBox_aplicar_2.SelectedIndex = 0 Then
            If (Label_preciolista2.Text <> "00,00") And (TX_LISTA_PROD_calculo2.Text <> "") Then
                Calculo_aumento_descuento()
            End If
        Else
            If DataG_listaTotal.Rows.Count <> 0 Then
                Calculo_aumento_descuento()
            End If
        End If
    End Sub
    Private Sub Calculo_aumento_descuento()
        If CBox_aplicar_2.SelectedIndex = 0 Then
            If CBox_tipocalculo_2.SelectedIndex = 0 Then
                'calculo aumento
                If Label_preciolista2.Text <> "00,00" Then
                    Dim precio_lista As Decimal = CDec(Label_preciolista2.Text)
                    If RB_pesos_2.Checked = True Then
                        'calculo $
                        Dim porcentaje_asig As Decimal = CDec(TX_LISTA_PROD_calculo2.Text)
                        Dim pesos_calculados As Decimal = CDec((porcentaje_asig * precio_lista) / 100)
                        Label_result2.Text = "$ " + CStr(Math.Round(pesos_calculados, 2))
                        TX_LISTA_PROD_precio2.Text = CDec(Math.Round(precio_lista + pesos_calculados, 2)).ToString("N2")
                    Else
                        'calculo %
                        Dim pesos_asig As Decimal = CDec(TX_LISTA_PROD_calculo2.Text)
                        Dim porcentaje_calculados As Decimal = CDec((pesos_asig * 100) / precio_lista)
                        Label_result2.Text = "% " + CStr(Math.Round(porcentaje_calculados, 2))
                        TX_LISTA_PROD_precio2.Text = CDec(Math.Round(precio_lista + pesos_asig, 2)).ToString("N2")
                    End If
                End If
            Else
                'calculo descuento
                If Label_preciolista2.Text <> "00,00" Then
                    Dim precio_lista As Decimal = CDec(Label_preciolista2.Text)

                    If RB_pesos_2.Checked = True Then
                        'calculo $
                        Dim porcentaje_asig As Decimal = CDec(TX_LISTA_PROD_calculo2.Text)
                        Dim pesos_calculados As Decimal = CDec((porcentaje_asig * precio_lista) / 100)
                        Label_result2.Text = "$ " + CStr(Math.Round(pesos_calculados, 2))
                        TX_LISTA_PROD_precio2.Text = CDec(Math.Round(precio_lista - pesos_calculados, 2)).ToString("N2")
                    Else
                        'calculo %
                        Dim pesos_asig As Decimal = CDec(TX_LISTA_PROD_calculo2.Text)
                        Dim porcentaje_calculados As Decimal = CDec((pesos_asig * 100) / precio_lista)
                        Label_result2.Text = "% " + CStr(Math.Round(porcentaje_calculados, 2))
                        TX_LISTA_PROD_precio2.Text = CDec(Math.Round(precio_lista - pesos_asig, 2)).ToString("N2")
                    End If
                End If
            End If
        Else
            'AQUI HAGO LOS CALCULOS PERO PARA AUMENTOS O DESCUENTOS SOBRE EL TOTAL DIRECTAMENTE

            calcular_totales_tabla()  'AQUI RECUPERO EL TOTAL, REAL, PARA APLICAR EL AUMENTO

            If CBox_tipocalculo_2.SelectedIndex = 0 Then
                'calculo aumento
                If DataG_listaTotal.Rows.Count <> 0 Then
                    Dim TOTAL_GRILLA As Decimal = CDec(DataG_listaTotal.Rows(0).Cells(1).Value).ToString("N2")

                    If RB_pesos_2.Checked = True Then
                        'calculo $
                        Dim porcentaje_asig As Decimal = CDec(TX_LISTA_PROD_calculo2.Text)
                        Dim pesos_calculados As Decimal = CDec((porcentaje_asig * TOTAL_GRILLA) / 100)
                        Label_result2.Text = "$ " + CStr(Math.Round(pesos_calculados, 2))
                        DataG_listaTotal.Rows(0).Cells(1).Value = CDec(Math.Round(TOTAL_GRILLA + pesos_calculados, 2)).ToString("N2")
                    Else
                        'calculo %
                        Dim pesos_asig As Decimal = CDec(TX_LISTA_PROD_calculo2.Text)
                        Dim porcentaje_calculados As Decimal = CDec((pesos_asig * 100) / TOTAL_GRILLA)
                        Label_result2.Text = "% " + CStr(Math.Round(porcentaje_calculados, 2))
                        DataG_listaTotal.Rows(0).Cells(1).Value = CDec(Math.Round(TOTAL_GRILLA + pesos_asig, 2)).ToString("N2")
                    End If
                End If

            Else
                'calculo descuento
                If DataG_listaTotal.Rows.Count <> 0 Then
                    Dim TOTAL_GRILLA As Decimal = CDec(DataG_listaTotal.Rows(0).Cells(1).Value).ToString("N2")

                    If RB_pesos_2.Checked = True Then
                        'calculo $
                        Dim porcentaje_asig As Decimal = CDec(TX_LISTA_PROD_calculo2.Text)
                        Dim pesos_calculados As Decimal = CDec((porcentaje_asig * TOTAL_GRILLA) / 100)
                        Label_result2.Text = "$ " + CStr(Math.Round(pesos_calculados, 2))
                        DataG_listaTotal.Rows(0).Cells(1).Value = CDec(Math.Round(TOTAL_GRILLA - pesos_calculados, 2)).ToString("N2")

                    Else
                        'calculo %
                        Dim pesos_asig As Decimal = CDec(TX_LISTA_PROD_calculo2.Text)
                        Dim porcentaje_calculados As Decimal = CDec((pesos_asig * 100) / TOTAL_GRILLA)
                        Label_result2.Text = "% " + CStr(Math.Round(porcentaje_calculados, 2))
                        DataG_listaTotal.Rows(0).Cells(1).Value = CDec(Math.Round(TOTAL_GRILLA - pesos_asig, 2)).ToString("N2")
                    End If
                End If
            End If
        End If
        calcular_total_prod_seleccionado()
    End Sub
    Private Sub RB_porcent_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_porcent_2.Click
        If (Label_preciolista2.Text <> "00,00") And (TX_LISTA_PROD_calculo2.Text <> "") Then
            Calculo_aumento_descuento()
        End If
    End Sub
    Private Sub RB_pesos_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_pesos_2.Click
        If (Label_preciolista2.Text <> "00,00") And (TX_LISTA_PROD_calculo2.Text <> "") Then
            Calculo_aumento_descuento()
        End If
    End Sub
    Private Sub TX_LISTA_PROD_calculo2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TX_LISTA_PROD_calculo2.KeyDown
        'este evento se dispara con el ENTER y calculo los descuentos y aumentos segun corresponda
        Select Case e.KeyData
            Case Keys.Enter

                If TX_LISTA_PROD_calculo2.Text <> "" Then
                    'PRIMERO VEMOS SI ES CALCULO PARA PRECIO DE PRODUCTO SELECCIONADO O SOBRE EL TOTAL
                    If CBox_aplicar_2.SelectedIndex = 0 Then
                        If (Label_preciolista2.Text <> "00,00") And (TX_LISTA_PROD_calculo2.Text <> "") Then
                            Calculo_aumento_descuento()
                        End If
                    Else
                        If DataG_listaTotal.Rows.Count <> 0 Then
                            Calculo_aumento_descuento()
                        End If
                    End If
                End If
        End Select
    End Sub
    Private Sub TX_LISTA_PROD_calculo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_LISTA_PROD_calculo2.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.TX_LISTA_PROD_calculo2.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub TX_LISTA_PROD_calculo2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_LISTA_PROD_calculo2.LostFocus
        'PRIMERO VEMOS SI ES CALCULO PARA PRECIO DE PRODUCTO SELECCIONADO O SOBRE EL TOTAL
        If CBox_aplicar_2.SelectedIndex = 0 Then
            If (Label_preciolista2.Text <> "00,00") And (TX_LISTA_PROD_calculo2.Text <> "") Then
                Calculo_aumento_descuento()
            End If
        Else
            If DataG_listaTotal.Rows.Count <> 0 Then
                Calculo_aumento_descuento()
            End If
        End If
    End Sub
#End Region
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RB_list_regular.Checked = True Then
            MODIFICAR_LISTAREGULAR()
        End If
        If RB_list_prom.Checked = True Then
            MODIFICAR_LISTAPROMOCION()
        End If
        If RB_combo_prod.Checked = True Then
            MODIFICAR_COMBO()
        End If
    End Sub
    Private Sub MODIFICAR_COMBO()

        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar el combo de productos?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'VALIDACION: que tenga algun item en la tabla "DataG_lista"
            If DataG_lista.Rows.Count <> 0 Then
                'VALIDACION: que tenga titulo la promocion
                If TX_LISTA_nom.Text <> "" Then
                    'VALIDACION: ver q el combo q agrego 
                    Dim ya_existe As String = "no"
                    Dim ds_buscar_combo As DataSet = DAlista.ProductoCombo_buscar(TX_LISTA_nom.Text)
                    If ds_buscar_combo.Tables(0).Rows.Count = 1 Then
                        'veo q el nombre coincida con el cod interno
                        If ds_buscar_combo.Tables(0).Rows(0).Item("ProdCombo_codinterno") = Labe_genero_cod.Text Then
                            'entonces no modifique el nombre y procedo a modificar el detalle del combo
                        Else
                            'si no coinciden hay otro combo con ese nombre, no debo actualizar...avisar con msj de error
                            ya_existe = "si"
                        End If

                    End If

                    If ya_existe = "no" Then 'ds_buscar_combo.Tables(0).Rows.Count = 0 Then
                        'Producto COMBO MODIFICAR

                        Dim ds_id As DataSet = DAlista.ProductoCombo_buscar_ID(CInt(Labe_genero_cod.Text))
                        Dim ProdCombo_id As Integer = ds_id.Tables(0).Rows(0).Item("ProdCombo_id")
                        'Producto Combo modifDatos
                        DAlista.ProductoCombo_modifDatos(ProdCombo_id, TX_LISTA_nom.Text, CDec(DataG_listaTotal.Rows(0).Cells(1).Value))
                        'Borro los item del combo
                        DAlista.ProductoComboDetalle_borrar(ProdCombo_id)
                        'Producto Combo Detalle alta
                        For Each row As DataGridViewRow In DataG_lista.Rows
                            DAlista.ProductoComboDetalle_alta(ProdCombo_id, row.Cells(0).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value)
                        Next

                        MessageBox.Show("El combo de productos fue modificado correctamente.", "Sistema de Gestion.")


                        actualizar_listado_combos() 'llamo a esta rutina, para que la primera grilla me muestre el nuevo combo, y ademas q se actualicen los estados de los items.
                        Limpiar()
                        Tab1.SelectedTab = TabPage1


                    Else
                        MessageBox.Show("El combo de productos ya existe, cambiar nombre", "Sistema de Gestión")
                        Tab1.SelectedTab = TabPage0
                        PicBox_error_nomlista.Visible = True
                        TX_LISTA_nom.Focus()
                    End If
                Else
                    MessageBox.Show("Agregar nombre al combo de productos", "Sistema de Gestión")
                    Tab1.SelectedTab = TabPage0
                    PicBox_error_nomlista.Visible = True
                    TX_LISTA_nom.Focus()
                End If
            Else
                MessageBox.Show("No hay productos agregados al combo", "Sistema de Gestión")
            End If
        End If

    End Sub
    Private Sub MODIFICAR_LISTAREGULAR()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar la lista regular?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'VALIDACION: que tenga algun item en la tabla "DG_ListaProducto"
            If DataG_lista.Rows.Count <> 0 Then
                'VALIDACION: que tenga titulo la promocion
                If TX_LISTA_nom.Text <> "" Then
                    'VALIDACION: que la lista q estoy agregando no exista en la tabla SQL
                    'la lista debe ser del tipo 1, "LISTA Regular"
                    Dim ya_existe As String = "no"
                    Dim ds_validar_lista As DataSet = DAlista.Lista_Regular_validar(TX_LISTA_nom.Text)

                    If ds_validar_lista.Tables(0).Rows.Count = 1 Then
                        'veo q el nombre coincida con el cod interno
                        If ds_validar_lista.Tables(0).Rows(0).Item("LISTA_id") = LISTA_id Then
                            'entonces no modifique el nombre y procedo a modificar el detalle dela lista
                        Else
                            'si no coinciden hay otra lista con ese nombre, no debo actualizar...avisar con msj de error
                            ya_existe = "si"
                        End If

                    End If

                    If ya_existe = "no" Then 'ds_validar_lista.Tables(0).Rows.Count = 0 Then
                        'Lista Regular modificar
                        DAlista.Lista_Regular_modifDatos(LISTA_id, TX_LISTA_nom.Text, CDec(DataG_listaTotal.Rows(0).Cells(1).Value))

                        'Borro los item de la lista regular
                        DAlista.Lista_Regular_detalle_borrar(LISTA_id)

                        Dim cant_rows As Integer = DataG_lista.Rows.Count

                        'ListaProducto modificar
                        For Each row As DataGridViewRow In DataG_lista.Rows
                            Dim producto As String = row.Cells(2).Value.ToString
                            Dim tipo_producto As String = ""
                            If row.Cells(6).Value = "combo" Then
                                tipo_producto = "combo"
                            Else
                                tipo_producto = "producto"
                            End If
                            'uso la misma rutina q uso en las promociones.
                            Dim PROD_ID As Integer = row.Cells(0).Value
                            Dim descripcion As String = row.Cells(2).Value
                            Dim cantidad As Integer = row.Cells(3).Value
                            Dim precio_U As Decimal = row.Cells(4).Value
                            Dim Subtotal As Decimal = row.Cells(5).Value
                            DAlista.Lista_Promocion_Producto_Alta(LISTA_id, row.Cells(0).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, tipo_producto)
                        Next
                        MessageBox.Show("La Lista Regular fue modificada correctamente.", "Sistema de Gestion.")
                        Actualizar_ListasRegulares() 'llamo a esta rutina, para que la primera grilla me muestre las listas regulares, y ademas q se actualicen los estados de los items.
                        Limpiar()
                        Tab1.SelectedTab = TabPage1
                    Else
                        MessageBox.Show("La lista ya existe, cambiar nombre", "Sistema de Gestión")
                        Tab1.SelectedTab = TabPage0
                        PicBox_error_nomlista.Visible = True
                        TX_LISTA_nom.Focus()
                    End If
                Else
                    MessageBox.Show("Agregar nombre a la lista", "Sistema de Gestión")
                    Tab1.SelectedTab = TabPage0
                    PicBox_error_nomlista.Visible = True
                    TX_LISTA_nom.Focus()
                End If
            Else
                MessageBox.Show("No hay productos agregados a la lista", "Sistema de Gestión")
            End If
        End If
    End Sub
    Private Sub MODIFICAR_LISTAPROMOCION()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar la promoción?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'VALIDACION: que tenga algun item en la tabla "DG_ListaProducto"
            If DataG_lista.Rows.Count <> 0 Then
                'VALIDACION: que tenga titulo la promocion
                If TX_LISTA_nom.Text <> "" Then
                    'VALIDACION: que la lista q estoy agregando no exista en la tabla SQL
                    'la lista debe ser del tipo 2, "LISTA PROMOCION"
                    Dim ya_existe As String = "no"
                    Dim ds_validar_lista As DataSet = DAlista.Lista_Promocion_validar(TX_LISTA_nom.Text)
                    If ds_validar_lista.Tables(0).Rows.Count = 1 Then
                        'veo q el nombre coincida con el cod interno
                        If ds_validar_lista.Tables(0).Rows(0).Item("LISTA_id") = LISTA_id Then
                            'entonces no modifique el nombre y procedo a modificar el detalle de la promocion
                        Else
                            'si no coinciden hay otra lista con ese nombre, no debo actualizar...avisar con msj de error
                            ya_existe = "si"
                        End If

                    End If



                    If ya_existe = "no" Then
                        'Lista Promocion modificar


                        DAlista.Lista_Promocion_modifDatos(LISTA_id, TX_LISTA_nom.Text, CDec(DataG_listaTotal.Rows(0).Cells(1).Value))
                        'borramos los dias , vigencias Y PRODUCTOS si los hay
                        DAlista.Lista_Promocion_detalle_borrar(LISTA_id)
                        'Lista Dia
                        If RB_LISTA_DIA_si.Checked = True Then
                            If CK_lunes.Checked = True Then
                                DAlista.Lista_Promocion_Dia_Alta(LISTA_id, "2")
                            End If
                            If CK_martes.Checked = True Then
                                DAlista.Lista_Promocion_Dia_Alta(LISTA_id, "3")
                            End If
                            If CK_miecoles.Checked = True Then
                                DAlista.Lista_Promocion_Dia_Alta(LISTA_id, "4")
                            End If
                            If CK_jueves.Checked = True Then
                                DAlista.Lista_Promocion_Dia_Alta(LISTA_id, "5")
                            End If
                            If CK_viernes.Checked = True Then
                                DAlista.Lista_Promocion_Dia_Alta(LISTA_id, "6")
                            End If
                            If CK_sabado.Checked = True Then
                                DAlista.Lista_Promocion_Dia_Alta(LISTA_id, "7")
                            End If
                            If CK_domingo.Checked = True Then
                                DAlista.Lista_Promocion_Dia_Alta(LISTA_id, "1")
                            End If
                        End If

                        'Lista Vigencia
                        If RB_LISTA_VIG_si.Checked = True Then
                            DAlista.Lista_Promocion_Vigencia_Alta(LISTA_id, DT_LISTA_fecha_desde.Value, DT_LISTA_fecha_hasta.Value)
                        End If

                        'ListaProducto alta
                        For Each row As DataGridViewRow In DataG_lista.Rows
                            Dim producto As String = row.Cells(2).Value.ToString
                            Dim tipo_producto As String = ""
                            If row.Cells(6).Value = "combo" Then
                                tipo_producto = "combo"
                            Else
                                tipo_producto = "producto"
                            End If
                            DAlista.Lista_Promocion_Producto_Alta(LISTA_id, row.Cells(0).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, tipo_producto)
                        Next
                        MessageBox.Show("La Lista Promoción fue modificada correctamente.", "Sistema de Gestion.")
                        Actualizar_ListasPromocionales() 'llamo a esta rutina, para que la primera grilla me muestre las listas promocionales, y ademas q se actualicen los estados de los items.
                        Limpiar()
                        Tab1.SelectedTab = TabPage1
                    Else
                        MessageBox.Show("La lista ya existe, cambiar nombre", "Sistema de Gestión")
                        Tab1.SelectedTab = TabPage0
                        PicBox_error_nomlista.Visible = True
                        TX_LISTA_nom.Focus()
                    End If
                Else
                    MessageBox.Show("Agregar nombre a la lista", "Sistema de Gestión")
                    Tab1.SelectedTab = TabPage0
                    PicBox_error_nomlista.Visible = True
                    TX_LISTA_nom.Focus()
                End If
            Else
                MessageBox.Show("No hay productos agregados a la lista", "Sistema de Gestión")
            End If
        End If

    End Sub

    Private Sub RB_codigo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_codigo.Click
        tx_busc_combos.Text = ""
        tx_busc_regulares.Text = ""
        tx_busc_promociones.Text = ""
    End Sub

End Class