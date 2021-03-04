Public Class Enfermeria_insumos_Ausente
    Dim DAsucursal As New Datos.Sucursal
    Public sesiones_id As Integer
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Dim DAprod As New Datos.Producto
    Dim DAlote As New Datos.Lote
    Dim ds_PROD As DataSet
    Dim FiltroDS As DataSet
    Dim DaEnfermeria As New Datos.Enfermeria
    Public PAC_id As Integer
    Public Filtro_var
    Public tipo_operacion As String = "alta"
    Dim DAsesiones As New Datos.Sesiones
    Public fecha_registrar
    Public sucursal_id As Integer 'me lo envia el formulario sesion_pacientes


    Private Sub combo_filtros_recuperar()
        'por ahora mando sucursal 3 q es dialisis
        Dim ds_prod As DataSet = DAprod.Producto_filtro_obtenertodos(sucursal_id) '3 es sala dialisis y 5 es dialisis de calle

        'ahora cargo el combo
        If ds_prod.Tables(0).Rows.Count <> 0 Then
            'Carga la categoria
            cb_filtro.DataSource = ds_prod.Tables(0)
            'cb_categoria.DataSource = ds_categoria.Tables(0)
            cb_filtro.DisplayMember = "prod_descripcion"
            cb_filtro.ValueMember = "ProdxSuc_ID"
        End If



    End Sub
    Private Sub Enfermeria_insumos_Ausente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        combo_filtros_recuperar()

        'recupero info del filtro
        Obtener_Filtro()

        'como es un alta, cargo los insumos que se van a consumir por defecto, siempre y cuando esten disponibles en stock
        recuperar_insumos_predefinidos()

    End Sub

    Private Sub recuperar_insumos_predefinidos()
        Ds_enfermeria.Tables("lote_x_suc").Rows.Clear() 'borror ds auxiliar

        Mov_DS.Tables("Mov_Enf").Rows.Clear() 'borror el contenido de los ds vinculados a los gridview
        Ds_enfermeria.Tables("Consumo_real").Rows.Clear()

        Dim cont_de_no_agregados As Integer = 0 'me lleva la cuenta de los insumos q no se agregaron, aquellos que tienen valores predefinidos pero sin stock disponible
        Dim hay_predefinidos = "no"
        Dim ds_predef As DataSet = DaEnfermeria.Insumos_Predefinidos_Obtener
        If ds_predef.Tables(0).Rows.Count <> 0 Then
            'entonces veo si cargo la grilla
            hay_predefinidos = "si"
            Dim i As Integer = 0
            While i < ds_predef.Tables(0).Rows.Count
                Dim prod_codinterno As Integer = ds_predef.Tables(0).Rows(i).Item("prod_codinterno")
                Dim prod_id As Integer = ds_predef.Tables(0).Rows(i).Item("prod_id")
                Dim prod_descripcion As String = ds_predef.Tables(0).Rows(i).Item("prod_descripcion")
                'ahora recupero los lotes que tengo disponible en stock para la sucursal dialisis. OJO LA DIALISIS TIENE QUE SER SUCURSAL ID = 3. 
                Dim Ds_Suc As DataSet = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id)
                Dim unidad_medida As String = Ds_Suc.Tables(0).Rows(0).Item("prod_unidadmedida")
                Dim contenido As Decimal = Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")
                If Ds_Suc.Tables(0).Rows.Count <> 0 Then
                    'si existe el producto en suc, continuamos
                    'recupero los lotes de dicho insumo
                    Dim ds_lotes As DataSet = DAlote.Producto_x_sucursal_lote_recuperartodos(prod_codinterno, sucursal_id)
                    If ds_lotes.Tables(0).Rows.Count <> 0 Then
                        'existen los lotes para el insumo
                        Ds_enfermeria.Tables("lote_x_suc").Rows.Clear() 'esta en la carpeta enfermeria, dataset "Ds_enfermeria"
                        Dim j As Integer = 0
                        While j < ds_lotes.Tables(0).Rows.Count
                            If ds_lotes.Tables(0).Rows(j).Item("lote_vence") = "no" Then
                                Dim nuevoRow As DataRow = Ds_enfermeria.Tables("lote_x_suc").NewRow
                                nuevoRow("prod_id") = ds_lotes.Tables(0).Rows(j).Item("prod_id")
                                nuevoRow("prod_codinterno") = ds_lotes.Tables(0).Rows(j).Item("prod_codinterno")
                                nuevoRow("prod_descripcion") = ds_lotes.Tables(0).Rows(j).Item("prod_descripcion")
                                nuevoRow("ProdxSuc_stock") = ds_lotes.Tables(0).Rows(j).Item("ProdxSuc_stock")
                                nuevoRow("lote_id") = ds_lotes.Tables(0).Rows(j).Item("lote_id")
                                nuevoRow("lote_nro") = ds_lotes.Tables(0).Rows(j).Item("lote_nro")
                                nuevoRow("lote_cantidad") = ds_lotes.Tables(0).Rows(j).Item("lote_cantidad")
                                nuevoRow("lote_vence") = ds_lotes.Tables(0).Rows(j).Item("lote_vence")
                                If ds_lotes.Tables(0).Rows(j).Item("lote_vence") = "si" Then
                                    nuevoRow("lote_fechafab") = ds_lotes.Tables(0).Rows(j).Item("lote_fechafab")
                                    nuevoRow("lote_fechavto") = ds_lotes.Tables(0).Rows(j).Item("lote_fechavto")
                                End If
                                nuevoRow("sucursal_id") = ds_lotes.Tables(0).Rows(j).Item("sucursal_id")
                                nuevoRow("Prov_id") = ds_lotes.Tables(0).Rows(j).Item("Prov_id")
                                nuevoRow("Proveedor") = ds_lotes.Tables(0).Rows(j).Item("Proveedor")
                                nuevoRow("lote_stock_real") = ds_lotes.Tables(0).Rows(j).Item("lote_stock_real")
                                nuevoRow("lote_aux") = ds_lotes.Tables(0).Rows(j).Item("lote_aux")
                                nuevoRow("valido") = "no" 'estan en no, se ponen en "si" mas adelante cuando verifico q el lote se va a consumir.

                                Ds_enfermeria.Tables("lote_x_suc").Rows.Add(nuevoRow)
                            Else
                                Dim fecha_vencimiento As Date = CDate(ds_lotes.Tables(0).Rows(j).Item("lote_fechavto"))
                                Dim fechadeldia As Date = Today
                                Dim cantdias As Integer = DateDiff("d", Today, fecha_vencimiento)

                                If cantdias <= 0 Then
                                    'no agrego el lote x que esta vencido
                                Else
                                    Dim nuevoRow As DataRow = Ds_enfermeria.Tables("lote_x_suc").NewRow
                                    nuevoRow("prod_id") = ds_lotes.Tables(0).Rows(j).Item("prod_id")
                                    nuevoRow("prod_codinterno") = ds_lotes.Tables(0).Rows(j).Item("prod_codinterno")
                                    nuevoRow("prod_descripcion") = ds_lotes.Tables(0).Rows(j).Item("prod_descripcion")
                                    nuevoRow("ProdxSuc_stock") = ds_lotes.Tables(0).Rows(j).Item("ProdxSuc_stock")
                                    nuevoRow("lote_id") = ds_lotes.Tables(0).Rows(j).Item("lote_id")
                                    nuevoRow("lote_nro") = ds_lotes.Tables(0).Rows(j).Item("lote_nro")
                                    nuevoRow("lote_cantidad") = ds_lotes.Tables(0).Rows(j).Item("lote_cantidad")
                                    nuevoRow("lote_vence") = ds_lotes.Tables(0).Rows(j).Item("lote_vence")
                                    If ds_lotes.Tables(0).Rows(j).Item("lote_vence") = "si" Then
                                        nuevoRow("lote_fechafab") = ds_lotes.Tables(0).Rows(j).Item("lote_fechafab")
                                        nuevoRow("lote_fechavto") = ds_lotes.Tables(0).Rows(j).Item("lote_fechavto")
                                    End If
                                    nuevoRow("sucursal_id") = ds_lotes.Tables(0).Rows(j).Item("sucursal_id")
                                    nuevoRow("Prov_id") = ds_lotes.Tables(0).Rows(j).Item("Prov_id")
                                    nuevoRow("Proveedor") = ds_lotes.Tables(0).Rows(j).Item("Proveedor")
                                    nuevoRow("lote_stock_real") = ds_lotes.Tables(0).Rows(j).Item("lote_stock_real")
                                    nuevoRow("lote_aux") = ds_lotes.Tables(0).Rows(j).Item("lote_aux")
                                    nuevoRow("valido") = "no" 'estan en no, se ponen en "si" mas adelante cuando verifico q el lote se va a consumir.
                                    Ds_enfermeria.Tables("lote_x_suc").Rows.Add(nuevoRow)
                                End If
                            End If
                            j = j + 1
                        End While
                        'ahora que tengo los lotes en datatable ds_enfermeria, voy a cambiar el campo "valido" a "si" en los lotes que sean aptos para agregar en el gridview de consumos.
                        Dim cant_predefinida As Decimal = ds_predef.Tables(0).Rows(i).Item("predef_cant")
                        Dim valido As String = "no"
                        If cant_predefinida <> CDec(0) Then
                            Dim cant As Decimal = CDec(cant_predefinida)
                            Dim ii As Integer = 0
                            Dim suma As Decimal = CDec(0)

                            While ii < Ds_enfermeria.Tables("lote_x_suc").Rows.Count
                                If cant > 0 Then
                                    If (CDec(Ds_enfermeria.Tables("lote_x_suc").Rows(ii).Item("lote_stock_real")) <= cant) And (CDec(Ds_enfermeria.Tables("lote_x_suc").Rows(ii).Item("lote_stock_real")) <> CDec(0)) Then
                                        'resto cantidad y tildo
                                        Ds_enfermeria.Tables("lote_x_suc").Rows(ii).Item("valido") = "si"
                                        cant = cant - CDec(Ds_enfermeria.Tables("lote_x_suc").Rows(ii).Item("lote_stock_real"))
                                        If cant = 0 Then
                                            valido = "si"
                                            Exit While
                                        End If
                                    Else
                                        If (CDec(Ds_enfermeria.Tables("lote_x_suc").Rows(ii).Item("lote_stock_real")) > 0) And (CDec(Ds_enfermeria.Tables("lote_x_suc").Rows(ii).Item("lote_stock_real")) <> CDec(0)) Then
                                            Ds_enfermeria.Tables("lote_x_suc").Rows(ii).Item("valido") = "si"
                                            cant = 0
                                            valido = "si"
                                            Exit While 'si es mayor, lo tildo y corto
                                        End If
                                    End If
                                Else
                                    If cant = 0 And CDec(cant_predefinida) <> CDec(0) Then
                                        valido = "si"
                                    End If
                                    Exit While
                                End If
                                ii = ii + 1
                            End While
                            If valido = "si" Then

                                'aqui viene el codigo para agregar a los 2 gridview, el q ve el usuario y el q esta oculto con los lotes.
                                Dim item As Integer
                                If Mov_DS.Tables("Mov_Enf").Rows.Count = 0 Then
                                    item = 1
                                Else
                                    item = Mov_DS.Tables("Mov_Enf").Rows.Count + 1
                                End If
                                Dim newCustomersRow1 As DataRow = Mov_DS.Tables("Mov_Enf").NewRow()
                                newCustomersRow1("N°") = item
                                newCustomersRow1("Cod_prod") = prod_codinterno
                                newCustomersRow1("Descripcion") = prod_descripcion
                                newCustomersRow1("Cantidad") = (Math.Round(CDec(cant_predefinida), 2).ToString("N2"))
                                newCustomersRow1("Prov_id") = Ds_enfermeria.Tables("lote_x_suc").Rows(0).Item("Prov_id")
                                newCustomersRow1("Cantidad_a_consumir") = CStr((Math.Round(CDec(cant_predefinida), 2).ToString("N2"))) + " " + unidad_medida
                                newCustomersRow1("EnBD") = "no" 'esto quiere decir q debo hacer un alta.
                                Mov_DS.Tables("Mov_Enf").Rows.Add(newCustomersRow1)

                                'agrego todos los lotes tildados, con excepcion de los que tienen cantidad en 0
                                Dim a As Integer = 0
                                Dim cantidad_a_mover As Decimal = CDec(cant_predefinida)
                                While a < Ds_enfermeria.Tables("lote_x_suc").Rows.Count
                                    If Ds_enfermeria.Tables("lote_x_suc").Rows(a).Item("valido") = "si" Then
                                        'Dim item As Integer
                                        'If Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count = 0 Then
                                        '    item = 1
                                        'Else
                                        '    item = Nueva_Dialisis.Mov_DS.Tables("Mov_Enf").Rows.Count + 1
                                        'End If
                                        Dim newCustomersRow As DataRow = Ds_enfermeria.Tables("Consumo_real").NewRow()
                                        'newCustomersRow("N°") = item
                                        newCustomersRow("Cod_prod") = Ds_enfermeria.Tables("lote_x_suc").Rows(a).Item("prod_codinterno").ToString
                                        newCustomersRow("Descripcion") = prod_descripcion + " (Lote Nº: " + Ds_enfermeria.Tables("lote_x_suc").Rows(a).Item("lote_nro") + ")"
                                        'newCustomersRow("Desde") = Nueva_Dialisis.cb_origen.Text
                                        'newCustomersRow("Hacia") = Insumos_gestion.cb_origen.Text
                                        'aqui veo cuanto voy a mover. si todo, o menos.
                                        Dim cant_del_lote As Decimal = CDec(Ds_enfermeria.Tables("lote_x_suc").Rows(a).Item("lote_stock_real"))
                                        If cant_del_lote <= cantidad_a_mover Then
                                            'paso todo
                                            newCustomersRow("Cantidad_real") = (Math.Round(CDec(cant_del_lote), 2).ToString("N2"))
                                            cantidad_a_mover = cantidad_a_mover - cant_del_lote
                                        Else
                                            If cant_del_lote > cantidad_a_mover Then
                                                'pongo en el dataset lo que queda en la variable cantida_a_mover
                                                newCustomersRow("Cantidad_real") = (Math.Round(CDec(cantidad_a_mover), 2).ToString("N2"))
                                                'cantidad_a_mover = cantidad_a_mover - cant_del_lote
                                            End If
                                        End If
                                        'newCustomersRow("Cantidad") = CDec(txt_cantlote.Text)
                                        newCustomersRow("lote_id") = Ds_enfermeria.Tables("lote_x_suc").Rows(a).Item("lote_id")
                                        'If DataGridView3.Rows(a).Cells("LotevenceDataGridViewTextBoxColumn").Value = "si" Then
                                        '    newCustomersRow("Vence") = "si"
                                        '    newCustomersRow("FechaFabricacion") = DataGridView3.Rows(a).Cells("LotefechafabDataGridViewTextBoxColumn").Value
                                        '    newCustomersRow("FechaVencimiento") = DataGridView3.Rows(a).Cells("LotefechavtoDataGridViewTextBoxColumn").Value
                                        'Else
                                        '    newCustomersRow("Vence") = "no"
                                        'End If

                                        newCustomersRow("Prov_id") = Ds_enfermeria.Tables("lote_x_suc").Rows(a).Item("Prov_id")

                                        Ds_enfermeria.Tables("Consumo_real").Rows.Add(newCustomersRow)
                                    End If
                                    a = a + 1
                                End While

                            Else
                                'la cant predefinida no se puede agregar, puede ser porque los lotes no sean suficientes para cubrir la cant necesaria.
                                cont_de_no_agregados = cont_de_no_agregados + 1
                            End If
                        End If

                    Else
                        'no existen lotes para el insumo
                        cont_de_no_agregados = cont_de_no_agregados + 1
                    End If
                Else
                    'no existe el insumo en sucursal 3 , sala de dialisis
                End If

                i = i + 1
            End While
        End If
        If hay_predefinidos = "si" Then
            If cont_de_no_agregados <> 0 Then
                'quiere decir q hay algunos q no se agregaron x falta de stock
                MessageBox.Show("Algunos insumos predefinidos no se agregaron por falta de stock.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub Obtener_Filtro()
        FiltroDS = DaEnfermeria.Filtro_Obtener_X_PAC(PAC_id)
        If FiltroDS.Tables(0).Rows.Count <> 0 Then
            Filtro_var = "Update"

            If tipo_operacion = "modificar presente" Then
                tb_CantRe.Text = FiltroDS.Tables(0).Rows(0).Item("Filtro_cant_reuso")
            Else
                tb_CantRe.Text = FiltroDS.Tables(0).Rows(0).Item("Filtro_cant_reuso") + 1
            End If

            Dim sesionDS As DataSet = DAsesiones.Dialisis_Obtener_Filtro_X_Pac(PAC_id)
            tb_Filtro.Text = sesionDS.Tables(0).Rows(0).Item("Dialisis_Filtro")
            tb_Filtro.Enabled = False


            'choco 20-02-2021
            cb_filtro.Enabled = False
            cb_filtro.SelectedValue = FiltroDS.Tables(0).Rows(0).Item("ProdxSuc_ID")

            'deshabilito el boton de nuevo, no puedo modificar un filtro ya consumido.
            btn_cambio.Enabled = True

        Else
            'tb_CantRe.Text = 0
            'Filtro_var = "Nuevo"

            btn_cambio.Enabled = True
        End If

    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'es lo mismo que baja de mercaderia
        'GM_Baja_Producto.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
        'GM_Baja_Producto.sucursal_id = 3 ' el ID 3 es La Sucursal Sala de Dialisis
        'GM_Baja_Producto.form_procedencia = "Gestion_Mercaderia"
        'GM_Baja_Producto.Text = "Enfermeria"
        'GM_Baja_Producto.tipo_movimiento = "consumir Ausente"
        'GM_Baja_Producto.Show()

        Sesiones_prod_agregar.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
        Sesiones_prod_agregar.sucursal_id = sucursal_id  ' el ID 3 es La Sucursal Sala de Dialisis
        Sesiones_prod_agregar.form_procedencia = "Gestion_Mercaderia"
        Sesiones_prod_agregar.Text = "Enfermeria"
        Sesiones_prod_agregar.tipo_movimiento = "consumir Ausente"
        Sesiones_prod_agregar.Show()


    End Sub



    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        If DataGridView1.Rows.Count <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea quitar todos los productos del listado?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Mov_DS.Tables("Mov_Enf").Rows.Clear() 'no uso el datagridview rows clear...x q me tira error x el dataset q esta asociado
                'DataGridView1.Rows.clear 
                'DataGridView1.Rows.Add()
                'DataGridView1.Focus()
                'DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True
            End If
        Else
            MessageBox.Show("No hay productos en el listado.", "Sistema de Gestión.")
        End If
    End Sub

    Public filtro_guardado As String = "no"
    Dim DAusuario As New Datos.Usuario
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim continuar_consumo As String = "no"
        'aqui pregunto si quiero registrar el uso del filtro
        If filtro_guardado = "no" Then
            Dim result2 As Integer = MessageBox.Show("¿Desea contar un rehuso del filtro?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result2 = DialogResult.Yes Then
                If cb_filtro.Items.Count <> 0 And tb_CantRe.Text <> "" Then
                    ''''' filtros y rehusos''''''''''''''24/9/20 MAriano'''''
                    If Filtro_var = "Nuevo" Then
                        Dim ProdxSuc_ID As Integer = cb_filtro.SelectedValue

                        DaEnfermeria.Filtro_Nuevo(PAC_id, fecha_registrar, tb_CantRe.Text, sesiones_id, cb_filtro.Text, ProdxSuc_ID)
                    End If
                    If Filtro_var = "Update" Then
                        DaEnfermeria.Filtro_modificar_Cant(FiltroDS.Tables(0).Rows(0).Item("Filtro_id"), tb_CantRe.Text)
                    End If
                    '''''''''''''''''''''''''''''''
                    continuar_consumo = "si"
                    filtro_guardado = "si"

                    '''''''''''''''''''''''''''''''
                    'registro actividad usuario
                    Dim usuario_id As String
                    usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
                    DAusuario.UsuarioActividad_registrar_sesiones_dialisis(usuario_id, sucursal_id, sesiones_id, Now, "")

                Else
                    MessageBox.Show("Error, Debe cargar un filtro.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                continuar_consumo = "si"
            End If
        Else
            'como ya esta guardado, seguimos con los insumos
            continuar_consumo = "si"
        End If

        If continuar_consumo = "si" Then
            If DataGridView1.Rows.Count <> 0 Then
                Dim result3 As Integer = MessageBox.Show("¿Desea Consumir los insumos listados?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result3 = DialogResult.Yes Then
                    If DataGridView1.Rows.Count <> 0 Then
                        '''''''''''''''''''''''''''''''
                        'registro actividad usuario
                        Dim usuario_id As String
                        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
                        DAusuario.UsuarioActividad_registrar_sesiones_dialisis(usuario_id, sucursal_id, sesiones_id, Now, "")
                        ''''''''''''''''''''''''''''''''''


                        Dim lote_id As Integer
                        Dim concepto = "Consumo Ausente"
                        Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta_Enfermeria(concepto, fecha_registrar, Inicio.USU_id, sucursal_id, sesiones_id)
                        ''''''''''''''''''''''''''''''''''''''''''''''''

                        Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
                        Dim i As Integer = 0
                        While i < Ds_enfermeria.Tables("Consumo_real").Rows.Count
                            '''''Actualizacion de Stock''''''''''''''''''''''''
                            Dim Ds_Suc As DataSet
                            'Dim Origen As Integer
                            'Dim Destino As Integer
                            'Dim Mov As Decimal
                            'Dim j As Integer = 0
                            'While i < Mov_DS.Tables("Mov").Rows.Count
                            ds_PROD = DAprod.Producto_buscarcod(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cod_prod"))
                            Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                            Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano

                            'choco///////////////27-01-2021
                            'aqui viene el calculo siempre sobre el valor real, y dependiendo si se consumo el total del contenido se resta en stock
                            'recupero info del lote especifico.
                            Dim ds_lote As DataSet = DAlote.Lote_buscar_producto_b(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("lote_id"))


                            Dim TotalReal As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("ProdxSuc_stock_real")) 'de la tabla PRODUCTO_X_SUCURSAL
                            TotalReal = TotalReal - CDec(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cantidad_real"))
                            '//////////////////////
                            Dim TotalReal_lote As Decimal = CDec(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cantidad_real")) 'este es el tock real del lote solamente, creo q lo mando asi nomas ya que en proc alm se lo resta al valor q tengo en el lote
                            Dim VarA As Decimal = CDec(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cantidad_real")) / CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido"))
                            Dim VarB As Decimal = VarA + CDec(ds_lote.Tables(0).Rows(0).Item("lote_aux"))
                            Dim TOTAL As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen")) - Int(VarB)
                            Dim AUX = VarB - Int(VarB)
                            'If cb_Movimiento.SelectedItem = "Baja de Mercaderia" Then
                            'Calculo Stock''''''''
                            'Mov = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad")
                            '''''''
                            ''''''''''
                            'Actualizo stock''''' no quito el registro del producto en la sucursal, en realidad lo que hago es actualizar su cantidad a 0. OJO No tiene que hacerse negativo.
                            DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, TOTAL, TotalReal) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
                            ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano


                            '''''''''''
                            '////////////////choco: 08-07-2020///////////////////////////////////
                            'actualizo la cant en el lote asociado a un producto de una sucursal.
                            'busco lote en grilla
                            Dim lote_nro As String = ds_lote.Tables(0).Rows(0).Item("lote_nro")



                            'Dim cant_a_quitar As Decimal = CDec(Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad"))
                            Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, sucursal_id, Int(VarB), Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Prov_id"), TotalReal_lote, AUX)  ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano
                            lote_id = dslote.Tables(0).Rows(0).Item("lote_id")
                            'End If
                            ''''''''''''''''''''''''''''''''''''''
                            '''''' Alta Tabla Detalle'''''' de movimiento claro está
                            'alta en tabla mercaderia_detalle_alta
                            DAMovintoMer.Consumo_mercaderia_Detalle_alta(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cantidad_real"), MovMer_id, Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cod_prod"), lote_id)
                            i = i + 1
                        End While
                        '''''''''''''''''''''''''''''''''''''''''''
                        MessageBox.Show("Operacion realizada con Exito.", "Sistema de Gestión.")
                        Sesion_pacientes.recuperar_pacientes_fecha_del_dia(fecha_registrar)
                        Me.Close()
                    Else
                        MessageBox.Show("No hay insumos agregados a la lista para consumir.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea Guardar sin Consumo de Insumos?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    MessageBox.Show("La información se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else

                End If
            End If
        End If
    End Sub

    Private Sub btn_cambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cambio.Click

        'por ahora mando sucursal 3 q es dialisis
        Dim ds_prod As DataSet = DAprod.Producto_filtro_obtenertodos(sucursal_id)

        'ahora cargo el combo
        If ds_prod.Tables(0).Rows.Count <> 0 Then
            tb_CantRe.Text = 0
            Filtro_var = "Nuevo"
            tb_Filtro.Enabled = True
            tb_Filtro.Focus()
            tb_Filtro.SelectAll()

            cb_filtro.DataSource = Nothing
            'choco 20-02-2021 filtro en combo
            'voy a recuperar solo los filtros q tengan stock. para la sucursal.
            cb_filtro.DataSource = ds_prod.Tables(0)
            cb_filtro.DisplayMember = "prod_descripcion"
            cb_filtro.ValueMember = "ProdxSuc_ID"

            cb_filtro.Enabled = True
        Else
            MessageBox.Show("No hay filtros en stock, consulte disponibilidad.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_eliminar_seleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_seleccion.Click
        ''aqui elemino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        Dim valido_seleccion As String = "no"
        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("Column2").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                        If MsgBox("¿Esta seguro que quiere quitar los items seleccionados?.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                            pregunta = "si"
                        Else
                            'aqui corto el ciclo, ya que se cancelo la eliminacion
                            i = DataGridView1.Rows.Count
                        End If
                    End If
                    If pregunta = "si" Then
                        'primero guardo el nro de item q contiene
                        Dim item As Decimal = DataGridView1.CurrentRow.Index

                        Dim codinterno As Integer = DataGridView1.Rows(i).Cells("CodprodDataGridViewTextBoxColumn").Value

                        'antes de quitar voy a anotar q se eliminó algo del consumo q ya esta en la bd
                        '/////////////////////////////////////////////////////////////////////////////
                        'If DataGridView1.Rows(i).Cells("EnBD").Value.ToString = "si" Then
                        '    Dim aa As Integer = 0
                        '    While aa < Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Count
                        '        If codinterno = Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cod_prod") Then
                        '            Ds_enfermeria.Tables("COnsumo_real1_aux").Rows(aa).Item("eliminado") = "si" 'esto hago para saber q actualizar stock, es decir sumar.

                        '        End If
                        '        aa = aa + 1
                        '    End While
                        'End If

                        DataGridView1.Rows.RemoveAt(i)

                        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        'tambien lo quito de la grilla auxiliar, es decir la q tiene los lotes de dicho insumo
                        Dim jj As Integer = 0

                        While jj < DataGridView2.Rows.Count
                            If codinterno = DataGridView2.Rows(jj).Cells("CodprodDataGridViewTextBoxColumn1").Value Then
                                DataGridView2.Rows.RemoveAt(jj)
                                jj = 0
                            Else
                                jj = jj + 1
                            End If
                        End While
                        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        i = 0 'lo reinicio, x q al quitar un ite, se reordenan los indices
                        'If item <= Venta_Caja_ds.Tables("Producto_agregado").Rows.Count Then 'esta validacion es x q el ds tiene menos celdas 
                        '    Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Delete()
                        'End If
                        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                        'cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
                        Dim a As Integer = 0
                        While a < DataGridView1.Rows.Count
                            If DataGridView1.Rows(a).Cells(1).Value <> 0 Then
                                DataGridView1.Rows(a).Cells(0).Value = a + 1
                            End If
                            a = a + 1
                        End While
                        'calcular_totales()
                        'aplicar_iva()
                    End If
                Else
                    i = i + 1
                End If
            End While

            If valido_seleccion = "no" Then
                MessageBox.Show("Seleccione un insumo para quitar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Warning
                                )
            End If
        Else
            MessageBox.Show("No hay insumos en el listado.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class