Public Class Lista_alta

    Dim DAlista As New Datos.Lista
    Dim ds_ListaProducto As New DataSet



#Region "EVENTOS"
    Private Sub Lista_alta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CBox_tipocalculo.SelectedIndex = 1 ' selecciono por defecto el calculo de Descuento
        CBox_tipocalculo_2.SelectedIndex = 1 ' selecciono por defecto el calculo de Descuento

        'CBox_aplicar.SelectedIndex = 0 'selecciono por defecto el item= "prod seleccionado"
        CBox_aplicar_2.SelectedIndex = 0 'selecciono por defecto el item= "prod seleccionado"

        Me.TX_LISTA_nom.Focus()

        ds_ListaProducto.Tables.Add("ListaProducto")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("PROD_id")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("PROD_descripcion")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("Lista_Prod_cantidad")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("Lista_Prod_precio")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("Lista_Prod_subtotal")
        ds_ListaProducto.Tables("ListaProducto").Columns.Add("prod_codinterno")

        Limpiar()
        'BO_codigo.Enabled = False
        'BO_codbarra.Enabled = False
        'BO_descripcion.Enabled = False

        TX_LISTA_nom.TextAlign = HorizontalAlignment.Center
        'TX_codigo.TextAlign = HorizontalAlignment.Center
        'TX_codbarra.TextAlign = HorizontalAlignment.Center
        'TX_descripcion.TextAlign = HorizontalAlignment.Center

        TX_LISTA_PROD_cant2.TextAlign = HorizontalAlignment.Center
        TX_LISTA_PROD_precio2.TextAlign = HorizontalAlignment.Center
        TX_LISTA_PROD_total2.TextAlign = HorizontalAlignment.Center
    End Sub

    'Fecha de Vigencia
    Private Sub RB_LISTA_VIG_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_LISTA_VIG_si.CheckedChanged
        GP_Fecha.Enabled = True
    End Sub

    Private Sub RB_LISTA_VIG_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_LISTA_VIG_no.CheckedChanged
        GP_Fecha.Enabled = False
    End Sub

    'Dias
    Private Sub RB_LISTA_DIA_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_LISTA_DIA_si.CheckedChanged
        GP_dias.Enabled = True
    End Sub

    Private Sub RB_LISTA_DIA_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_LISTA_DIA_no.CheckedChanged
        GP_dias.Enabled = False
    End Sub

    'PRODUCTO BUSCAR ////////////////////////////////////////////////////////////////////////////////////
    Dim ds_PROD As New DataSet

    

    'Private Sub TX_LISTA_PROD_precio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TX_LISTA_PROD_cant.Text <> Nothing And TX_LISTA_PROD_precio.Text <> Nothing Then
    '        BO_Cargar.Enabled = True
    '        TX_LISTA_PROD_total.Text = TX_LISTA_PROD_cant.Text * TX_LISTA_PROD_precio.Text
    '    Else
    '        BO_Cargar.Enabled = False
    '        TX_LISTA_PROD_total.Text = 0
    '    End If
    'End Sub

    'Private Sub TX_LISTA_PROD_cant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TX_LISTA_PROD_cant.Text <> Nothing And TX_LISTA_PROD_precio.Text <> Nothing Then
    '        BO_Cargar.Enabled = True
    '        TX_LISTA_PROD_total.Text = TX_LISTA_PROD_cant.Text * TX_LISTA_PROD_precio.Text
    '    Else
    '        BO_Cargar.Enabled = False
    '        TX_LISTA_PROD_total.Text = 0
    '    End If
    'End Sub


    Private Sub RB_list_regular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_list_regular.CheckedChanged
        If RB_list_regular.Checked = True Then

            GroupBox1.Enabled = False 'fecha de vigencia
            GroupBox2.Enabled = False 'dias especiales
            GP_dias.Enabled = False  'dias
            GP_Fecha.Enabled = False  'fechas

            Labe_genero_cod.Text = ".........."

        End If
    End Sub

    Private Sub RB_list_prom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_list_prom.CheckedChanged

        If RB_list_prom.Checked = True Then

            GroupBox1.Enabled = True 'fecha de vigencia
            GroupBox2.Enabled = True  'dias especiales
            GP_dias.Enabled = True 'dias
            GP_Fecha.Enabled = True 'fechas



            Labe_genero_cod.Text = ".........."
            Generar_cod_interno_promocion()

        End If
    End Sub

    Private Sub RB_combo_prod_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_combo_prod.CheckedChanged
        If RB_combo_prod.Checked = True Then

            GroupBox1.Enabled = False 'fecha de vigencia
            GroupBox2.Enabled = False 'dias especiales
            GP_dias.Enabled = False  'dias
            GP_Fecha.Enabled = False  'fechas


            'llamo al metodo para generar el nro de combo!!
            Generar_cod_interno()
        End If
    End Sub


    

#End Region


#Region "METODOS"

    Private Sub ALTA_COMBO()

        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta el combo de productos?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'VALIDACION: que tenga algun item en la tabla "DataG_lista"
            If DataG_lista.Rows.Count <> 0 Then
                'VALIDACION: que tenga titulo la promocion
                If TX_LISTA_nom.Text <> "" Then
                    'VALIDACION: que el combo q estoy agregando no exista en la tabla SQL
                    Dim ds_buscar_combo As DataSet = DAlista.ProductoCombo_buscar(TX_LISTA_nom.Text)
                    If ds_buscar_combo.Tables(0).Rows.Count = 0 Then
                        'Producto COMBO Alta
                        Dim ds_combo As DataSet = DAlista.ProductoCombo_alta(Labe_genero_cod.Text, TX_LISTA_nom.Text, CDec(DataG_listaTotal.Rows(0).Cells(1).Value))
                        Dim ProdCombo_id As String = CType(ds_combo.Tables(0).Rows(0).Item("ProdCombo_id"), String)

                        'Producto Combo Detalle alta
                        For Each row As DataGridViewRow In DataG_lista.Rows
                            DAlista.ProductoComboDetalle_alta(ProdCombo_id, row.Cells(0).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value)
                        Next

                        Limpiar()

                        MessageBox.Show("El combo de productos fue dado de alta correctamente.", "Sistema de Gestion.")

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

    Private Sub ALTA_LISTAREGULAR()

        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta la lista regular?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'VALIDACION: que tenga algun item en la tabla "DG_ListaProducto"
            If DataG_lista.Rows.Count <> 0 Then
                'VALIDACION: que tenga titulo la promocion
                If TX_LISTA_nom.Text <> "" Then
                    'VALIDACION: que la lista q estoy agregando no exista en la tabla SQL
                    'la lista debe ser del tipo 1, "LISTA Regular"
                    Dim ds_validar_lista As DataSet = DAlista.Lista_Regular_validar(TX_LISTA_nom.Text)
                    If ds_validar_lista.Tables(0).Rows.Count = 0 Then
                        'Lista Regular Alta
                        Dim ds_LISTA As DataSet = DAlista.Lista_Regular_Alta(TX_LISTA_nom.Text, CDec(DataG_listaTotal.Rows(0).Cells(1).Value))
                        Dim LISTA_id As String = CType(ds_LISTA.Tables(0).Rows(0).Item("LISTA_id"), String)

                        'ListaProducto alta
                        For Each row As DataGridViewRow In DataG_lista.Rows
                            Dim producto As String = row.Cells(2).Value.ToString
                            Dim tipo_producto As String = ""
                            If row.Cells(6).Value = "combo" Then
                                tipo_producto = "combo"
                            Else
                                tipo_producto = "producto"
                            End If
                            'uso la misma rutina q uso en las promociones.
                            DAlista.Lista_Promocion_Producto_Alta(LISTA_id, row.Cells(0).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, tipo_producto)
                        Next

                        Limpiar()

                        MessageBox.Show("La Lista Regular fue dada de alta correctamente.", "Sistema de Gestion.")

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

    Private Sub ALTA_LISTAPROMOCION()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta la promoción?", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'VALIDACION: que tenga algun item en la tabla "DG_ListaProducto"
            If DataG_lista.Rows.Count <> 0 Then
                'VALIDACION: que tenga titulo la promocion
                If TX_LISTA_nom.Text <> "" Then
                    'VALIDACION: que la lista q estoy agregando no exista en la tabla SQL
                    'la lista debe ser del tipo 2, "LISTA PROMOCION"
                    Dim ds_validar_lista As DataSet = DAlista.Lista_Promocion_validar(TX_LISTA_nom.Text)
                    If ds_validar_lista.Tables(0).Rows.Count = 0 Then
                        'Lista Promocion Alta
                        Dim ds_LISTA As DataSet = DAlista.Lista_Promocion_Alta(TX_LISTA_nom.Text, CDec(DataG_listaTotal.Rows(0).Cells(1).Value), Labe_genero_cod.Text)
                        Dim LISTA_id As String = CType(ds_LISTA.Tables(0).Rows(0).Item("LISTA_id"), String)
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

                        Limpiar()

                        MessageBox.Show("La Lista Promoción fue dada de alta correctamente.", "Sistema de Gestion.")

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

    Public Sub Generar_cod_interno_promocion()
        Dim ds_generar As DataSet = DAlista.Lista_Promocion_validar2()
        If ds_generar.Tables(0).Rows.Count <> 0 Then

            Dim ultimo_cod As String = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item("LISTA_codinterno").ToString
            ultimo_cod = Replace(ultimo_cod, "P", "")
            Labe_genero_cod.Text = CInt(ultimo_cod) + 1
            Labe_genero_cod.Text = "P" + Labe_genero_cod.Text
        Else
            Labe_genero_cod.Text = "P1"
        End If

    End Sub



    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAlista.ProductoCombo_validar()
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            Labe_genero_cod.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item(0) + 1
        End If
    End Sub

    Public Sub LimpiarProducto()
        'TX_LISTA_PROD_cant.Text = Nothing
        'TX_LISTA_PROD_precio.Text = Nothing
        'TX_LISTA_PROD_total.Text = 0
        'BO_Cargar.Enabled = False

        'TX_LISTA_PROD_cant.Text = "1"
        'TX_LISTA_PROD_precio.Text = "00,00"
        'TX_LISTA_PROD_total.Text = "00,00"
        'TX_LISTA_PROD_calculo.Text = "00,00"
        'Label_result.Text = "00,00"
        'Label_preciolista.Text = "00,00"
    End Sub

    Public Sub Limpiar()
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
        Lista_ds.Tables("ListaProducto").Clear()
        'DG_TOTALES.DataSource = Nothing
        PicBox_error_nomlista.Visible = False

        '///////////////////////////////////pestana 2
        DataG_lista.DataSource = Nothing
        Lista_ds.Tables("ListaProducto").Clear()
        DataG_listaTotal.DataSource = Nothing
        DataG_listaTotal.Rows.Clear()

        Label_codinterno2.Text = "  "
        Label_preciolista2.Text = "00,00"
        TX_LISTA_PROD_precio2.Text = "00,00"
        TX_LISTA_PROD_cant2.Text = "1"
        TX_LISTA_PROD_total2.Text = "00,00"
        TX_LISTA_PROD_calculo2.Text = "00,00"
    End Sub

    Private Sub Calculo_aumento_descuento()

        'If CBox_aplicar.SelectedIndex = 0 Then
        '    If CBox_tipocalculo.SelectedIndex = 0 Then
        '        'calculo aumento
        '        If Label_preciolista.Text <> "00,00" Then
        '            Dim precio_lista As Decimal = CDec(Label_preciolista.Text)

        '            If RB_pesos.Checked = True Then
        '                'calculo $
        '                Dim porcentaje_asig As Decimal = CDec(TX_LISTA_PROD_calculo.Text)
        '                Dim pesos_calculados As Decimal = CDec((porcentaje_asig * precio_lista) / 100)
        '                Label_result.Text = "$ " + CStr(Math.Round(pesos_calculados, 2))
        '                TX_LISTA_PROD_precio.Text = CDec(Math.Round(precio_lista + pesos_calculados, 2)).ToString("N2")
        '            Else
        '                'calculo %
        '                Dim pesos_asig As Decimal = CDec(TX_LISTA_PROD_calculo.Text)
        '                Dim porcentaje_calculados As Decimal = CDec((pesos_asig * 100) / precio_lista)
        '                Label_result.Text = "% " + CStr(Math.Round(porcentaje_calculados, 2))
        '                TX_LISTA_PROD_precio.Text = CDec(Math.Round(precio_lista + pesos_asig, 2)).ToString("N2")
        '            End If
        '        End If

        '    Else
        '        'calculo descuento
        '        If Label_preciolista.Text <> "00,00" Then
        '            Dim precio_lista As Decimal = CDec(Label_preciolista.Text)

        '            If RB_pesos.Checked = True Then
        '                'calculo $
        '                Dim porcentaje_asig As Decimal = CDec(TX_LISTA_PROD_calculo.Text)
        '                Dim pesos_calculados As Decimal = CDec((porcentaje_asig * precio_lista) / 100)
        '                Label_result.Text = "$ " + CStr(Math.Round(pesos_calculados, 2))
        '                TX_LISTA_PROD_precio.Text = CDec(Math.Round(precio_lista - pesos_calculados, 2)).ToString("N2")

        '            Else
        '                'calculo %
        '                Dim pesos_asig As Decimal = CDec(TX_LISTA_PROD_calculo.Text)
        '                Dim porcentaje_calculados As Decimal = CDec((pesos_asig * 100) / precio_lista)
        '                Label_result.Text = "% " + CStr(Math.Round(porcentaje_calculados, 2))
        '                TX_LISTA_PROD_precio.Text = CDec(Math.Round(precio_lista - pesos_asig, 2)).ToString("N2")
        '            End If


        '        End If



        '    End If
        'Else
        '    'AQUI HAGO LOS CALCULOS PERO PARA AUMENTOS O DESCUENTOS SOBRE EL TOTAL DIRECTAMENTE

        '    calcular_totales() 'AQUI RECUPERO EL TOTAL, REAL, PARA APLICAR EL AUMENTO

        '    If CBox_tipocalculo.SelectedIndex = 0 Then
        '        'calculo aumento
        '        If DG_TOTALES.Rows.Count <> 0 Then
        '            Dim TOTAL_GRILLA As Decimal = CDec(DG_TOTALES.Rows(0).Cells(1).Value).ToString("N2")

        '            If RB_pesos.Checked = True Then
        '                'calculo $
        '                Dim porcentaje_asig As Decimal = CDec(TX_LISTA_PROD_calculo.Text)
        '                Dim pesos_calculados As Decimal = CDec((porcentaje_asig * TOTAL_GRILLA) / 100)
        '                Label_result.Text = "$ " + CStr(Math.Round(pesos_calculados, 2))
        '                DG_TOTALES.Rows(0).Cells(1).Value = CDec(Math.Round(TOTAL_GRILLA + pesos_calculados, 2)).ToString("N2")
        '            Else
        '                'calculo %
        '                Dim pesos_asig As Decimal = CDec(TX_LISTA_PROD_calculo.Text)
        '                Dim porcentaje_calculados As Decimal = CDec((pesos_asig * 100) / TOTAL_GRILLA)
        '                Label_result.Text = "% " + CStr(Math.Round(porcentaje_calculados, 2))
        '                DG_TOTALES.Rows(0).Cells(1).Value = CDec(Math.Round(TOTAL_GRILLA + pesos_asig, 2)).ToString("N2")
        '            End If
        '        End If

        '    Else
        '        'calculo descuento
        '        If DG_TOTALES.Rows.Count <> 0 Then
        '            Dim TOTAL_GRILLA As Decimal = CDec(DG_TOTALES.Rows(0).Cells(1).Value).ToString("N2")

        '            If RB_pesos.Checked = True Then
        '                'calculo $
        '                Dim porcentaje_asig As Decimal = CDec(TX_LISTA_PROD_calculo.Text)
        '                Dim pesos_calculados As Decimal = CDec((porcentaje_asig * TOTAL_GRILLA) / 100)
        '                Label_result.Text = "$ " + CStr(Math.Round(pesos_calculados, 2))
        '                DG_TOTALES.Rows(0).Cells(1).Value = CDec(Math.Round(TOTAL_GRILLA - pesos_calculados, 2)).ToString("N2")

        '            Else
        '                'calculo %
        '                Dim pesos_asig As Decimal = CDec(TX_LISTA_PROD_calculo.Text)
        '                Dim porcentaje_calculados As Decimal = CDec((pesos_asig * 100) / TOTAL_GRILLA)
        '                Label_result.Text = "% " + CStr(Math.Round(porcentaje_calculados, 2))
        '                DG_TOTALES.Rows(0).Cells(1).Value = CDec(Math.Round(TOTAL_GRILLA - pesos_asig, 2)).ToString("N2")
        '            End If


        '        End If



        '    End If


        'End If


        'calcular_total_prod_seleccionado()



        '////////////////////////////////lo mismo pero para la otra pestana//////////////////////////////////////////////////

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

            calcular_totales() 'AQUI RECUPERO EL TOTAL, REAL, PARA APLICAR EL AUMENTO

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

    Public Sub calcular_totales()

        'aqui calculo el total de la lista/promocion/combo...lo q sea
        'DG_TOTALES.Rows.Clear()

        'DG_TOTALES.Rows.Add()

        ''sumamos los subtotales con un ciclo
        'Dim suma As Decimal = "0,00"

        'Dim i As Integer = 0
        'While i < DG_ListaProducto.Rows.Count
        '    suma = suma + DG_ListaProducto.Rows(i).Cells(5).Value
        '    i = i + 1
        'End While
        'suma = Math.Round(suma, 2)

        'DG_TOTALES.Rows(0).Cells(0).Value = "TOTAL"
        'DG_TOTALES.Rows(0).Cells(1).Value = Math.Round(suma).ToString("N2")

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        'esto lo hago para la otra grilla...de la pestana 2

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

#End Region

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Lista_prod_ADD.form_procedencia = "Lista_alta"
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

                    calcular_totales()
                    'este codigo si va
                    'Call Cargar_Totales(añosdelproyecto)
                    'modificado = 1
                End If
            End If
        End If
        DataG_lista.Refresh()
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
        calcular_totales()
    End Sub

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If RB_list_regular.Checked = True Then
            ALTA_LISTAREGULAR()
        End If
        If RB_list_prom.Checked = True Then
            ALTA_LISTAPROMOCION()
        End If
        If RB_combo_prod.Checked = True Then
            ALTA_COMBO()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Limpiar()
        Tab1.SelectedTab = TabPage0
    End Sub

    
End Class