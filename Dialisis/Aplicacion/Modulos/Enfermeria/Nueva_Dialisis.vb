Public Class Nueva_Dialisis
    Dim DAusuario As New Datos.Usuario
    Dim DAsucursal As New Datos.Sucursal
    Dim DaEnfermeria As New Datos.Enfermeria
    Dim DAsesiones As New Datos.Sesiones
    Dim DApaciente As New Datos.Paciente
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Dim DAprod As New Datos.Producto
    Dim DAlote As New Datos.Lote
    Dim ds_PROD As DataSet
    Public PAC_id As Integer
    Public fecha_registrar
    Dim ds_AV As DataSet
    Dim Consumo_Guardado
    Dim sesiones_id As Integer
    Public Filtro_var
    Dim FiltroDS As DataSet
    Dim daturno As New Datos.Turno

    Public sucursal_id As Integer 'me lo envia el formulario sesion_pacientes

    '///////////variables que uso si el estado ya fue registrado como AUSENTE
    Public tipo_operacion As String = "alta" 'esta la uso para saber si es un alta, una modificacion, o bien un registro q era ausente y ahora actualizo a presente y hago un alta convencional
    Public ausente_sesiones_id As Integer
    '/////////////////////////////////////////////////////////////

    '///////////////variable que uso para recuperar la info de la sesion que ya se guardo en la db, traigo todo, incluido consumos realizados
    Public modificar_sesiones_id As Integer


#Region "INICIO DEL FORMULARIO"
    Private Sub Nueva_Dialisis_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'este evento se dispara despues del load.
        If tipo_operacion = "modificar presente" Then
        Else
            'como es un alta, cargo los insumos que se van a consumir por defecto, siempre y cuando esten disponibles en stock
            recuperar_insumos_predefinidos()
        End If
    End Sub

    Private Sub combo_filtros_recuperar()
        'siempre muestro todos los filtros, tengan o no tengan stock

        Dim ds_prod As DataSet = DAprod.Producto_filtro_obtenertodos(sucursal_id) 'aqui mando 3 o 5 dependiendo q surcursal sea

            'ahora cargo el combo
        If ds_prod.Tables(1).Rows.Count <> 0 Then
            'Carga la categoria
            cb_filtro.DataSource = ds_prod.Tables(1)
            'cb_categoria.DataSource = ds_categoria.Tables(0)
            cb_filtro.DisplayMember = "prod_descripcion"
            cb_filtro.ValueMember = "ProdxSuc_ID"
        End If






    End Sub
    Private Sub Nueva_Dialisis_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        combo_filtros_recuperar()
        Obetener_Cliente()
        Obtener_AV()
        Obtener_Filtro()

        If tipo_operacion = "modificar presente" Then
            'recupero todo lo de dialisis
            obtener_info_sesion_dialisis()



            If estado_sesion = "Conectado" Then
                btn_finalizar.Enabled = True 'lo habilito ahora si se puede finalizar.
                btn_guardar.Text = "Guardar"
                btn_guardar.Image = My.Resources.floppy_disk30x30
            Else
                If estado_sesion = "Finalizado" Then
                    btn_finalizar.Enabled = False
                    btn_guardar.Enabled = False
                    GroupBox7.Enabled = False
                    GroupBox_insumos.Enabled = False

                Else
                    btn_finalizar.Enabled = True 'lo habilito ahora si se puede finalizar.
                    btn_guardar.Text = "Guardar"
                    btn_guardar.Image = My.Resources.floppy_disk30x30
                End If
            End If

            'aqui pongo en color azul y negrita las filas
            Dim ff As Integer = 0
            Dim style As New DataGridViewCellStyle
            style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
            style.ForeColor = Color.Blue
            style.SelectionForeColor = Color.Blue
            While ff < DataGridView1.Rows.Count
                'DataGridView1.Rows(ff).DefaultCellStyle.ForeColor = Color.Blue
                DataGridView1.Rows(ff).DefaultCellStyle = style
                ff = ff + 1
            End While


            btn_cambio.Enabled = False 'no puedo modificar un filtro consumido, ya tiene contado reuso y todo.

        Else
            'hago el alta normal o bien si es ausente
            Dim ds_Dialisis As DataSet = DaEnfermeria.Dialisis_Obtener
            If ds_Dialisis.Tables(0).Rows.Count <> 0 Then
                tb_numHemo.Text = ds_Dialisis.Tables(0).Rows.Count + 1
            Else
                tb_numHemo.Text = 1
            End If
            lb_estado.Text = "ESTADO: NUEVO" 'luego cuando guardo pasa a CONECTADO, Y AL ULTIMO: FINALIZADO.
            btn_finalizar.Enabled = False
            If tipo_operacion = "ausente" Then
                btn_guardar.Text = "Guardar"
            End If

        End If

        ''PESO Y TALLA AUTOMATICOS'''

        Dim sesion As DataSet = daturno.TurnoDialisis_consultar_sesion_paciente_presente(PAC_id)
        If sesion.Tables(0).Rows.Count <> 0 Then

            If sesion.Tables(0).Rows.Count = 14 Or sesion.Tables(0).Rows.Count = 28 Or sesion.Tables(0).Rows.Count = 42 Or sesion.Tables(0).Rows.Count = 56 Or sesion.Tables(0).Rows.Count = 70 Then

            Else
                Dim i = sesion.Tables(0).Rows.Count - 1
                Dim info_sesion As DataSet = DAsesiones.Sesiones_obtener_info_dialisis(sesion.Tables(0).Rows(i).Item("Sesiones_id"))
                If info_sesion.Tables(0).Rows.Count <> 0 Then
                    tb_PesoS.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_PesoS")
                    tb_talla.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_Talla")
                End If


            End If





        End If




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
    Private Sub Obetener_Cliente()
        '3
        Dim ds_clie_recu As DataSet = DApaciente.Paciente_obtener_info(PAC_id)
        If ds_clie_recu.Tables(0).Rows.Count <> 0 Then
            tb_Dni_Cuit.Text = ds_clie_recu.Tables(0).Rows(0).Item("PAC_dni")
            tb_fecnac.Text = CDate(ds_clie_recu.Tables(0).Rows(0).Item("PAC_fnac")).Date
            tb_nombre.Text = ds_clie_recu.Tables(0).Rows(0).Item("PAC_ape") + " " + ds_clie_recu.Tables(0).Rows(0).Item("PAC_nom")

            If ds_clie_recu.Tables(0).Rows(0).Item("PAC_sexo") = "Masculino" Then
                tb_sexo.Text = "Masculino"
            Else
                tb_sexo.Text = "Femenino"
            End If
            tb_edad.Text = CStr(calcularEdad(CDate(tb_fecnac.Text)))
            tb_obsoc.Text = ds_clie_recu.Tables(0).Rows(0).Item("Obrasocial_nombre")
            tb_numafi.Text = ds_clie_recu.Tables(0).Rows(0).Item("PACnumafi")
        End If

    End Sub
    Public Sub Obtener_AV()
        ds_AV = DaEnfermeria.Recuperar_Tipo_AccesoV(PAC_id)
        If ds_AV.Tables(0).Rows.Count <> 0 Then
            tb_AV.Text = ds_AV.Tables(0).Rows(0).Item("AV_tipo")
        Else
            tb_AV.Text = "No Tiene Acceso Vascular"
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
            btn_cambio.Enabled = True
        End If
    End Sub
    Public estado_sesion As String
    Public Consumo_mercaderia_id As Integer = 0 'este parametro me lo va a enviar desde el private sub "obtener_info_sesion_dialsis" y sirve para borrar los consumos anteriormente registrados si es necesario.
    Private Sub obtener_info_sesion_dialisis()
        Consumo_mercaderia_id = 0
        Mov_DS.Tables("Mov_Enf").Rows.Clear()
        Dim info_sesion As DataSet = DAsesiones.Sesiones_obtener_info_dialisis(modificar_sesiones_id)

        Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Clear() ' borro el contenido de la tabla auxiliar

        If info_sesion.Tables(0).Rows.Count <> 0 Then
            'aqui cargo la info
            estado_sesion = info_sesion.Tables(0).Rows(0).Item("Sesiones_estado").ToString
            If estado_sesion = "" Then
                estado_sesion = "Conectado"
            End If

            lb_estado.Text = "ESTADO: " + estado_sesion

            tb_numHemo.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_id")
            tb_PesoS.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_PesoS")
            tb_talla.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_Talla")
            tb_HI.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_HI")
            tb_HE.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_HE")
            tb_tiempoHD.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_TiempoHD")
            tb_PesoI.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_PesoI")
            tb_PesoE.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_PesoE")
            tb_TAI.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_TAI")
            tb_TAE.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_TAE")
            tb_Filtro.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_Filtro")
            tb_Obs.Text = info_sesion.Tables(0).Rows(0).Item("Dialisis_Obs")
            Dim accesovascular = info_sesion.Tables(0).Rows(0).Item("AccesoVascular")
            tb_AV.Text = info_sesion.Tables(0).Rows(0).Item("AccesoVascular")
            sucursal_id = CInt(info_sesion.Tables(0).Rows(0).Item("sucursal_id"))

            'ahora si tiene consumos los coloco.
            If info_sesion.Tables(1).Rows.Count <> 0 Then
                Consumo_mercaderia_id = CInt(info_sesion.Tables(1).Rows(0).Item("Consumo_mercaderia_id")) 'esta variable la voy a usar cuando guardo una modificación. en el boton quitar seleccion debo hacer una validacion q sea para indicarme q se cambio el consumo anterior.

                Dim i As Integer = 0
                While i < info_sesion.Tables(1).Rows.Count
                    Dim fila As DataRow = Mov_DS.Tables("Mov_Enf").NewRow
                    fila("N°") = i + 1
                    Dim cod_prod As Integer = CInt(info_sesion.Tables(1).Rows(i).Item("prod_codinterno"))
                    fila("Cod_prod") = info_sesion.Tables(1).Rows(i).Item("prod_codinterno")
                    fila("Descripcion") = info_sesion.Tables(1).Rows(i).Item("prod_descripcion")
                    fila("Prov_id") = 0
                    Dim cantidad As Decimal = 0
                    Dim cont_repetidos As Decimal = 0 'me sirve para saber cuanto le sumo a i, sino me cicla de mas
                    Dim j As Integer = 0
                    While j < info_sesion.Tables(1).Rows.Count
                        If cod_prod = CInt(info_sesion.Tables(1).Rows(j).Item("prod_codinterno")) Then
                            'si son iguales sumo cantidad
                            cantidad = cantidad + CDec(info_sesion.Tables(1).Rows(j).Item("Consumo_mercaderiadetalle_cantidad"))
                            cont_repetidos = cont_repetidos + 1

                            '////////////////////creo fila en tabla auxiliar con eliminado = "no"
                            Dim fila_aux As DataRow = Ds_enfermeria.Tables("Consumo_real1_aux").NewRow
                            fila_aux("Cod_prod") = cod_prod
                            fila_aux("Descripcion") = info_sesion.Tables(1).Rows(i).Item("prod_descripcion")
                            fila_aux("Cantidad_real") = CDec(info_sesion.Tables(1).Rows(j).Item("Consumo_mercaderiadetalle_cantidad"))
                            fila_aux("lote_id") = info_sesion.Tables(1).Rows(j).Item("lote_id")
                            fila_aux("Consumo_mercaderiadetalle_id") = info_sesion.Tables(1).Rows(j).Item("Consumo_mercaderiadetalle_id")
                            fila_aux("Consumo_mercaderia_id") = info_sesion.Tables(1).Rows(j).Item("Consumo_mercaderia_id")
                            fila_aux("eliminado") = "no"
                            fila_aux("lote_nro") = info_sesion.Tables(1).Rows(j).Item("lote_nro")
                            fila_aux("Prov_id") = info_sesion.Tables(1).Rows(j).Item("Prov_id")
                            fila_aux("lote_aux") = info_sesion.Tables(1).Rows(j).Item("lote_aux")
                            Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Add(fila_aux)

                            '////////////////////////////////////////////////////////////////////////////
                        End If
                        j = j + 1
                    End While
                    'fila("Cantidad") = info_sesion.Tables(1).Rows(i).Item("Consumo_mercaderiadetalle_cantidad")
                    fila("Cantidad") = cantidad
                    'fila("Cantidad_a_consumir") = info_sesion.Tables(1).Rows(i).Item("Consumo_mercaderiadetalle_cantidad").ToString + " " + info_sesion.Tables(1).Rows(i).Item("prod_unidadmedida")
                    fila("Cantidad_a_consumir") = cantidad.ToString + " " + info_sesion.Tables(1).Rows(i).Item("prod_unidadmedida")
                    fila("EnBD") = "si"
                    'fila("Lote") = info_sesion.Tables(1).Rows(i).Item("lote_nro")
                    'fila("Vence") = info_sesion.Tables(1).Rows(i).Item("lote_vence")
                    'If info_sesion.Tables(1).Rows(i).Item("lote_vence") = "si" Then
                    '    fila("FechaFabricacion") = info_sesion.Tables(1).Rows(i).Item("lote_fechafab")
                    '    fila("FechaVencimiento") = info_sesion.Tables(1).Rows(i).Item("lote_fechavto")
                    'End If
                    Mov_DS.Tables("Mov_Enf").Rows.Add(fila)
                    i = i + cont_repetidos
                End While

                'y luego bloqueo los consumos.

            End If
            GroupBox_insumos.Enabled = True
        End If



    End Sub
#End Region






    Public Function calcularEdad(ByVal nacimiento As Date) As Integer
        Dim edad As Integer
        edad = Today.Year - nacimiento.Year
        If (nacimiento > Today.AddYears(-edad)) Then edad -= 1
        Return edad
    End Function



    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'es lo mismo que baja de mercaderia
        'GM_Baja_Producto.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
        'GM_Baja_Producto.sucursal_id = 3 ' el ID 3 es La Sucursal Sala de Dialisis
        'GM_Baja_Producto.form_procedencia = "Gestion_Mercaderia"
        'GM_Baja_Producto.Text = "Enfermeria"
        'GM_Baja_Producto.tipo_movimiento = "consumir producto en enfermeria"
        'GM_Baja_Producto.Show()



        Sesiones_prod_agregar.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
        Sesiones_prod_agregar.sucursal_id = sucursal_id  ' el ID 3 es La Sucursal Sala de Dialisis y el 5 es dialisis de calle
        Sesiones_prod_agregar.form_procedencia = "Gestion_Mercaderia"
        Sesiones_prod_agregar.Text = "Enfermeria"
        Sesiones_prod_agregar.tipo_movimiento = "consumir producto en enfermeria"
        Sesiones_prod_agregar.Show()


    End Sub

    Private Sub limpiar()
        Sesion_pacientes.recuperar_pacientes_fecha_del_dia(fecha_registrar)
        Me.Close()
    End Sub

    Private Sub Guardar_Sesion()
        'Alta de la Sesion
        Dim ds_sesiones As DataSet = DAsesiones.sesiones_alta(PAC_id, fecha_registrar, "Presente", "Conectado", sucursal_id) 'mando el parametro fecha_registrar porque es la que tiene el resultado de la busqueda, es decir lo que se esta mostrando en la grilla
        sesiones_id = ds_sesiones.Tables(0).Rows(0).Item(0) 'este recupera el id del q acabo de insertar

        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado

        'registro actividad del usuario
        DAusuario.UsuarioActividad_registrar_sesiones_dialisis(usuario_id, sucursal_id, sesiones_id, Now, "")

    End Sub

    Private Sub Guardar_dialisis()




        '///////////////////////////le doy el formado correcto a los textbox q deben ser si o si decimales con 2 digitos despues de la coma
        Dim PesoS As Decimal = (Math.Round(CDec(tb_PesoS.Text), 2).ToString("N2"))
        Dim talla As Decimal = (Math.Round(CDec(tb_talla.Text), 2).ToString("N2"))
        Dim PesoI As Decimal = (Math.Round(CDec(tb_PesoI.Text), 2).ToString("N2"))
        Dim PesoE As Decimal = (Math.Round(CDec(tb_PesoE.Text), 2).ToString("N2"))
        Dim TAI As Decimal = (Math.Round(CDec(tb_TAI.Text), 2).ToString("N2"))
        Dim TAE As Decimal = (Math.Round(CDec(tb_TAE.Text), 2).ToString("N2"))
        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        'Alta en Tabla Dialisis
        DaEnfermeria.Dialisis_alta(sesiones_id, PesoS, talla, tb_HI.Text, tb_HE.Text, tb_tiempoHD.Text, PesoI, PesoE, TAI, TAE, tb_Filtro.Text, tb_Obs.Text, tb_AV.Text)

        MessageBox.Show("La información se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbl_err.Visible = False
        lbl_err1.Visible = False
        lbl_err2.Visible = False
        lbl_err3.Visible = False
        lbl_err4.Visible = False
        lbl_err5.Visible = False
        lbl_err6.Visible = False

    End Sub
    Private Sub Guardar_Datos_Filtro()

        ''''' filtros y rehusos''''''''''''''24/9/20 MAriano'''''
        If Filtro_var = "Nuevo" Then
            Dim ProdxSuc_id As Integer = cb_filtro.SelectedValue


            DaEnfermeria.Filtro_Nuevo(PAC_id, fecha_registrar, tb_CantRe.Text, sesiones_id, cb_filtro.Text, ProdxSuc_id)
            'siempre que sea un nuevo filtro, tengo q hacer una actualización de stock.


            Dim ds_prodxsuc As DataSet = DAprod.Producto_x_sucursal_obtener_info_ProdxSuc_ID(cb_filtro.SelectedValue)
            Dim prod_id As Integer = ds_prodxsuc.Tables(0).Rows(0).Item("prod_id")

            Dim Ds_Suc As DataSet = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id) 'sucursal 3 es dialisis y 5 es dialisis de calle

            Dim TotalReal As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("ProdxSuc_stock_real")) 'de la tabla PRODUCTO_X_SUCURSAL
            TotalReal = TotalReal - CDec(1)
            Dim TotalReal_lote As Decimal = CDec(1) 'este es el tock real del lote solamente, creo q lo mando asi nomas ya que en proc alm se lo resta al valor q tengo en el lote


            Dim VarA As Decimal = CDec(1) / CDec(Ds_Suc.Tables(1).Rows(0).Item("prod_contenido"))
            Dim VarB As Decimal = VarA + CDec(ds_prodxsuc.Tables(1).Rows(0).Item("lote_aux"))

            Dim TOTAL As Decimal = CDec(Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen")) - Int(VarB)

            Dim AUX = VarB - Int(VarB)



            DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, TOTAL, TotalReal) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.


            'ahora actualizo el lote

            Dim lote_nro As String = ds_prodxsuc.Tables(1).Rows(0).Item("lote_nro")

            Dim Prov_id As Integer = ds_prodxsuc.Tables(1).Rows(0).Item("Prov_id")
            Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, sucursal_id, Int(VarB), Prov_id, TotalReal_lote, AUX)  ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano


            '//////////////////////////////////////////////////////



        End If

        If Filtro_var = "Update" Then
            DaEnfermeria.Filtro_modificar_Cant(FiltroDS.Tables(0).Rows(0).Item("Filtro_id"), tb_CantRe.Text)
        End If
        '''''''''''''''''''''''''''''''
    End Sub

    Private Sub recupero_y_recalculo_totales(ByVal prod_id As Integer, ByVal codinterno As Integer)
        Dim ds_lotes As DataSet = DAlote.Producto_x_sucursal_lote_recuperartodos(codinterno, sucursal_id)
        Dim stock As Decimal = 0
        Dim stock_real As Decimal = 0
        Dim i As Integer = 0
        While i < ds_lotes.Tables(0).Rows.Count
            stock = stock + CInt(ds_lotes.Tables(0).Rows(i).Item("lote_cantidad"))
            stock_real = stock_real + CInt(ds_lotes.Tables(0).Rows(i).Item("lote_stock_real"))

            i = i + 1
        End While
        DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, sucursal_id, stock, stock_real)

    End Sub

    Private Sub modificar_dialisis()
        If cb_filtro.Items.Count <> 0 And tb_AV.Text <> "No Tiene Acceso Vascular" Then

            'Dim concepto As String
            'concepto = "Insumo consumido en Enfermeria"
            ''''Alta en tabla Movimiento_Mercaderia''''''''''

            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea modificar la sesión?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                '///////////////////////////le doy el formado correcto a los textbox q deben ser si o si decimales con 2 digitos despues de la coma
                Dim PesoS As Decimal = (Math.Round(CDec(tb_PesoS.Text), 2).ToString("N2"))
                Dim talla As Decimal = (Math.Round(CDec(tb_talla.Text), 2).ToString("N2"))
                Dim PesoI As Decimal = (Math.Round(CDec(tb_PesoI.Text), 2).ToString("N2"))
                Dim PesoE As Decimal = (Math.Round(CDec(tb_PesoE.Text), 2).ToString("N2"))
                Dim TAI As Decimal = (Math.Round(CDec(tb_TAI.Text), 2).ToString("N2"))
                Dim TAE As Decimal = (Math.Round(CDec(tb_TAE.Text), 2).ToString("N2"))
                '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                DaEnfermeria.Dialisis_modificar(fecha_registrar, modificar_sesiones_id, PesoS, talla, tb_HI.Text, tb_HE.Text, tb_tiempoHD.Text, PesoI, PesoE, TAI, TAE, tb_Filtro.Text, tb_Obs.Text, tb_AV.Text)
                'registro actividad usuario///////////////////////////////////////////////////////
                Dim usuario_id As String
                usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado

                'registro actividad del usuario
                DAusuario.UsuarioActividad_registrar_sesiones_dialisis(usuario_id, sucursal_id, modificar_sesiones_id, Now, "")
                '//////////////////////////////////////////////////////////////////////////////////





                Guardar_Datos_Filtro()

                Dim borrado_todo_item_recuperado As String = "no"
                '1) si se sacaron productos de la grilla de consumos que ya estaban registrados, actualizo el stock.
                If Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Count <> 0 Then
                    'controlo si alguno dice eliminado = "si"
                    Dim aa As Integer = 0
                    Dim valido_eliminados As String = "no"
                    Dim cont_eliminados As Integer = 0
                    While aa < Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Count
                        If Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("eliminado") = "si" Then
                            valido_eliminados = "si"
                            'entonces actualizo el stock en sucursal 3, dialsis.
                            'debo sumar la cantidad en el lote que corresponda.
                            'y recalcular el total del producto en la sucursal, los parametros stock y stock_real.
                            '''''Actualizacion de Stock''''''''''''''''''''''''
                            Dim codinterno As Integer = Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cod_prod")
                            ds_PROD = DAprod.Producto_buscarcod(codinterno)
                            Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                            Dim Ds_Suc As DataSet = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano y el id 5 es dialisis de calle.

                            'choco///////////////27-01-2021
                            'aqui viene el calculo siempre sobre el valor real, y dependiendo si se consumo el total del contenido se resta en stock
                            'recupero info del lote especifico.
                            Dim ds_lote As DataSet = DAlote.Lote_buscar_producto_b(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("lote_id"))

                            'TOTAL REAL = TOTAL REAL + INGRESO
                            Dim lote_stock_real As Decimal = CDec(ds_lote.Tables(0).Rows(0).Item("lote_stock_real")) + CDec(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cantidad_real"))

                            'TOTAL = (TOTAL REAL / CONTENIDO) ..ESTO REDONDEO ARRIBA
                            Dim lote_cantidad As Decimal = lote_stock_real / CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido"))
                            'ahora lo redondeo 
                            '/////////////////
                            If (lote_cantidad - Int(lote_cantidad)) <> CDec(0) Then
                                lote_cantidad = Int(lote_cantidad) + 1
                            Else
                                lote_cantidad = Int(lote_cantidad)
                            End If
                            '//////////////////////////////////////////////

                            Dim AUX As Decimal = CDec(ds_lote.Tables(0).Rows(0).Item("lote_aux"))
                            Dim VarA As Decimal = (CDec(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cantidad_real")) / CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")))
                            VarA = VarA - Int(VarA)
                            'AUX = AUX + 1 - (CDec(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cantidad_real")) / CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")))


                            AUX = AUX - VarA

                            'ahora debo guardar en bd aux, lote_stocl_real, lote_cantidad
                            Dim nrolote As Integer = Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("lote_nro")
                            Dim proveedor_id As Integer = Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Prov_id")
                            DAlote.Producto_x_sucursal_lote_actualizar_igualar(nrolote, prod_id, sucursal_id,
                                                                          CDec(lote_cantidad), proveedor_id, lote_stock_real, AUX)
                            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            'ahora me falta actualizar en producto x sucursal, tanto ProdxSuc_stock, ProdxSuc_stock_real
                            recupero_y_recalculo_totales(prod_id, codinterno)

                            'ahora lo elimino de la tabla Consumo_mercaderia_detalle
                            DAMovintoMer.Consumo_Mercaderia_Detalle_eliminar(Consumo_mercaderia_id, codinterno, CInt(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("lote_id")))
                            cont_eliminados = cont_eliminados + 1
                        End If
                        aa = aa + 1
                    End While
                    If valido_eliminados = "si" Then
                        'tenog que borrar la tabla Consumo_Mercaderia
                        If cont_eliminados = Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Count Then
                            'con esta variable Consumo_mercaderia_id voy a eliminar la fila en la tabla consumo_mercaderia
                            DAMovintoMer.Consumo_Mercaderia_eliminar_Enfermeria(Consumo_mercaderia_id)
                            borrado_todo_item_recuperado = "si"
                        End If
                    End If
                End If

                'aqui voy a guardar si es necesario lo que agregué nuevo en la grilla de insumos.
                '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                If Ds_enfermeria.Tables("Consumo_real").Rows.Count <> 0 Then 'significa que hay altas nuevas para registrar
                    Dim MovMer_id As Integer
                    Dim lote_id As Integer
                    If borrado_todo_item_recuperado = "si" Then
                        Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta_Enfermeria("Insumo consumido en Enfermeria", fecha_registrar, Inicio.USU_id, sucursal_id, modificar_sesiones_id)
                        MovMer_id = ds_movid.Tables(0).Rows(0).Item(0)
                    Else
                        MovMer_id = Consumo_mercaderia_id
                    End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''
                    Dim i As Integer = 0
                    'While i < Mov_DS.Tables("Mov_Enf").Rows.Count
                    While i < Ds_enfermeria.Tables("Consumo_real").Rows.Count ' esta ciclando en la grilla oculta que siempre tiene altas.
                        '''''Actualizacion de Stock''''''''''''''''''''''''
                        Dim Ds_Suc As DataSet
                        'Dim Origen As Integer
                        'Dim Destino As Integer
                        'Dim Mov As Decimal
                        'Dim j As Integer = 0
                        'While i < Mov_DS.Tables("Mov").Rows.Count
                        ds_PROD = DAprod.Producto_buscarcod(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cod_prod"))
                        Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                        Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano y el id 5 es dialisis de calle

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
                        '////////////////choco: 08-07-2020////////////////////////
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
                End If
                '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                MessageBox.Show("La información se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lbl_err.Visible = False
                lbl_err1.Visible = False
                lbl_err2.Visible = False
                lbl_err3.Visible = False
                lbl_err4.Visible = False
                lbl_err5.Visible = False
                lbl_err6.Visible = False
                lbl_err7.Visible = False
                limpiar()
            Else

            End If
        Else
            'lbl_err.Visible = True 'peso seco
            'lbl_err1.Visible = True 'talla
            lbl_err2.Visible = True 'tipo filtro
            'lbl_err3.Visible = True 'horarios
            'lbl_err4.Visible = True 'peso
            'lbl_err5.Visible = True 'tension arterial
            'lbl_err6.Visible = True 'observacion
            lbl_err7.Visible = True 'tipo acceso vascular

            MessageBox.Show("Complete los Campos Obligatorios. ", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If tipo_operacion = "modificar presente" Then
            modificar_dialisis()
        Else


            If cb_filtro.Items.Count <> 0 And tb_CantRe.Text <> "" And tb_AV.Text <> "No Tiene Acceso Vascular" And tb_PesoS.Text <> 0 And tb_talla.Text <> 0 Then


                Dim concepto As String
                concepto = "Insumo consumido en Enfermeria"
                ''''Alta en tabla Movimiento_Mercaderia''''''''''
                If Mov_DS.Tables("Mov_Enf").Rows.Count <> 0 Then
                    Dim result As Integer = MessageBox.Show("¿Esta seguro que desea consumir los insumos listados?", "Sistema de Gestión", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then

                        If tipo_operacion = "alta" Then
                            Guardar_Sesion()
                        Else
                            If tipo_operacion = "ausente" Then 'en teoria ya no se usa mas, los ausentes no pueden pasar a presentes: 05-10-2020 choco
                                'aqui voy a hacer un update del registro en la tabla sesiones, cambio estado ausente por presente
                                DAsesiones.Sesiones_modificar(ausente_sesiones_id, fecha_registrar, "Presente", "Conectado")
                                sesiones_id = ausente_sesiones_id  'este recupera el id del q acabo de insertar
                            End If
                        End If
                        Guardar_dialisis()

                        Guardar_Datos_Filtro()

                        Dim lote_id As Integer
                        Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta_Enfermeria(concepto, fecha_registrar, Inicio.USU_id, sucursal_id, sesiones_id)
                        ''''''''''''''''''''''''''''''''''''''''''''''''

                        Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
                        Dim i As Integer = 0
                        'While i < Mov_DS.Tables("Mov_Enf").Rows.Count
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
                            Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano y el id 5 es dialisis de calle

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
                            Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, sucursal_id, Int(VarB), Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Prov_id"), TotalReal_lote, AUX)  ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano y el id 5 es dialisis de calle
                            lote_id = dslote.Tables(0).Rows(0).Item("lote_id")
                            'End If
                            ''''''''''''''''''''''''''''''''''''''
                            '''''' Alta Tabla Detalle'''''' de movimiento claro está
                            'alta en tabla mercaderia_detalle_alta
                            DAMovintoMer.Consumo_mercaderia_Detalle_alta(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cantidad_real"), MovMer_id, Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cod_prod"), lote_id)
                            i = i + 1
                        End While
                        '''''''''''''''''''''''''''''''''''''''''''
                        limpiar()
                    End If
                Else
                    Dim result As Integer = MessageBox.Show("¿Esta seguro que desea Guardar la sesion sin Consumo de Insumos?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        If tipo_operacion = "alta" Then
                            Guardar_Sesion()
                        Else
                            If tipo_operacion = "ausente" Then 'en teoria no se usa mas esto, los ausentes no se cambian a presente: choco 05-10-2020
                                'aqui voy a hacer un update del registro en la tabla sesiones, cambio estado ausente por presente
                                DAsesiones.Sesiones_modificar(ausente_sesiones_id, fecha_registrar, "Presente", "Conectado")
                                sesiones_id = ausente_sesiones_id  'este recupera el id del q acabo de insertar
                            End If
                        End If

                        Guardar_Datos_Filtro()
                        Guardar_dialisis()
                        limpiar()
                    Else
                        MessageBox.Show("Si desea Puede agregar Insumos", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If



            Else
                lbl_err.Visible = True 'peso seco
                lbl_err1.Visible = True 'talla
                lbl_err2.Visible = True 'tipo filtro
                'lbl_err3.Visible = True 'horarios
                'lbl_err4.Visible = True 'peso
                'lbl_err5.Visible = True 'tension arterial
                'lbl_err6.Visible = True 'observacion
                lbl_err7.Visible = True 'tipo acceso vascular
                MessageBox.Show("Complete los Campos Obligatorios. ", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If


    End Sub

    Private Sub btn_NAV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NAV.Click
        Enfermeria_Acceso_Vascular.Close()
        Enfermeria_Acceso_Vascular.PAC_id = PAC_id

        Enfermeria_Acceso_Vascular.Show()

    End Sub


    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        'If DataGridView1.Rows.Count <> 0 Then
        '    Dim result As DialogResult
        '    result = MessageBox.Show("¿Desea quitar todos los productos del listado?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
        '    If result = DialogResult.OK Then
        '        Mov_DS.Tables("Mov_Enf").Rows.Clear() 'no uso el datagridview rows clear...x q me tira error x el dataset q esta asociado
        '        'DataGridView1.Rows.clear 
        '        'DataGridView1.Rows.Add()
        '        'DataGridView1.Focus()
        '        'DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True
        '    End If
        'Else
        '    MessageBox.Show("No hay productos en el listado.", "Sistema de Gestión.")
        'End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub


    Dim validadiones As New Validaciones

    Private Sub tb_PesoS_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_PesoS.GotFocus
        tb_PesoS.SelectAll()
    End Sub
    Private Sub tb_PesoS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_PesoS.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_PesoS)
    End Sub

    Private Sub tb_talla_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_talla.GotFocus
        tb_talla.SelectAll()
    End Sub

    Private Sub tb_talla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_talla.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_talla)
    End Sub

    Private Sub tb_PesoI_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_PesoI.GotFocus
        tb_PesoI.SelectAll()
    End Sub

    Private Sub tb_PesoI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_PesoI.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_PesoI)
    End Sub

    Private Sub tb_PesoE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_PesoE.GotFocus
        tb_PesoE.SelectAll()
    End Sub

    Private Sub tb_PesoE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_PesoE.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_PesoE)
    End Sub

    Private Sub tb_TAI_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_TAI.GotFocus
        tb_TAI.SelectAll()
    End Sub

    Private Sub tb_TAI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_TAI.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_TAI)
    End Sub

    Private Sub tb_TAE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_TAE.GotFocus
        tb_TAE.SelectAll()
    End Sub

    Private Sub tb_TAE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_TAE.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_TAE)
    End Sub

    Private Sub tb_AV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_AV.KeyPress
        e.Handled = True
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

    Private Sub tb_HI_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_HI.GotFocus
        tb_HI.SelectAll()
    End Sub

    Private Sub tb_HE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_HE.GotFocus
        tb_HE.SelectAll()
    End Sub

    Private Sub tb_tiempoHD_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_tiempoHD.GotFocus
        tb_tiempoHD.SelectAll()
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
                        If DataGridView1.Rows(i).Cells("EnBD").Value.ToString = "si" Then
                            Dim aa As Integer = 0
                            While aa < Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Count
                                If codinterno = Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cod_prod") Then
                                    Ds_enfermeria.Tables("COnsumo_real1_aux").Rows(aa).Item("eliminado") = "si" 'esto hago para saber q actualizar stock, es decir sumar.

                                End If
                                aa = aa + 1
                            End While
                        End If

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


    Private Sub btn_finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_finalizar.Click
        If tb_Filtro.Text <> "" And tb_AV.Text <> "No Tiene Acceso Vascular" Then

            'Dim concepto As String
            'concepto = "Insumo consumido en Enfermeria"
            ''''Alta en tabla Movimiento_Mercaderia''''''''''

            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea modificar la sesión?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                '///////////////////////////le doy el formado correcto a los textbox q deben ser si o si decimales con 2 digitos despues de la coma
                Dim PesoS As Decimal = (Math.Round(CDec(tb_PesoS.Text), 2).ToString("N2"))
                Dim talla As Decimal = (Math.Round(CDec(tb_talla.Text), 2).ToString("N2"))
                Dim PesoI As Decimal = (Math.Round(CDec(tb_PesoI.Text), 2).ToString("N2"))
                Dim PesoE As Decimal = (Math.Round(CDec(tb_PesoE.Text), 2).ToString("N2"))
                Dim TAI As Decimal = (Math.Round(CDec(tb_TAI.Text), 2).ToString("N2"))
                Dim TAE As Decimal = (Math.Round(CDec(tb_TAE.Text), 2).ToString("N2"))
                '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                DaEnfermeria.Dialisis_modificar(fecha_registrar, modificar_sesiones_id, PesoS, talla, tb_HI.Text, tb_HE.Text, tb_tiempoHD.Text, PesoI, PesoE, TAI, TAE, tb_Filtro.Text, tb_Obs.Text, tb_AV.Text)

                DAsesiones.Sesiones_modificar(modificar_sesiones_id, fecha_registrar, "Presente", "Finalizado")

                'registro actividad usuario///////////////////////////////////////////////////////
                Dim usuario_id As String
                usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado

                'registro actividad del usuario
                DAusuario.UsuarioActividad_registrar_sesiones_dialisis(usuario_id, sucursal_id, modificar_sesiones_id, Now, "")
                '//////////////////////////////////////////////////////////////////////////////////


                Guardar_Datos_Filtro()

                Dim borrado_todo_item_recuperado As String = "no"

                '1) si se sacaron productos de la grilla de consumos que ya estaban registrados, actualizo el stock.
                If Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Count <> 0 Then
                    'controlo si alguno dice eliminado = "si"
                    Dim aa As Integer = 0
                    Dim valido_eliminados As String = "no"
                    Dim cont_eliminados As Integer = 0
                    While aa < Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Count
                        If Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("eliminado") = "si" Then
                            valido_eliminados = "si"
                            'entonces actualizo el stock en sucursal 3, dialsis.
                            'debo sumar la cantidad en el lote que corresponda.
                            'y recalcular el total del producto en la sucursal, los parametros stock y stock_real.
                            '''''Actualizacion de Stock''''''''''''''''''''''''
                            Dim codinterno As Integer = Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cod_prod")
                            ds_PROD = DAprod.Producto_buscarcod(codinterno)
                            Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                            Dim Ds_Suc As DataSet = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano y el id 5 es dialisis de calle

                            'choco///////////////27-01-2021
                            'aqui viene el calculo siempre sobre el valor real, y dependiendo si se consumo el total del contenido se resta en stock
                            'recupero info del lote especifico.
                            Dim ds_lote As DataSet = DAlote.Lote_buscar_producto_b(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("lote_id"))

                            'TOTAL REAL = TOTAL REAL + INGRESO
                            Dim lote_stock_real As Decimal = CDec(ds_lote.Tables(0).Rows(0).Item("lote_stock_real")) + CDec(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cantidad_real"))

                            'TOTAL = (TOTAL REAL / CONTENIDO) ..ESTO REDONDEO ARRIBA
                            Dim lote_cantidad As Decimal = lote_stock_real / CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido"))
                            'ahora lo redondeo 
                            '/////////////////
                            If (lote_cantidad - Int(lote_cantidad)) <> CDec(0) Then
                                lote_cantidad = Int(lote_cantidad) + 1
                            Else
                                lote_cantidad = Int(lote_cantidad)
                            End If
                            '//////////////////////////////////////////////

                            Dim AUX As Decimal = CDec(ds_lote.Tables(0).Rows(0).Item("lote_aux"))
                            Dim VarA As Decimal = (CDec(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cantidad_real")) / CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")))
                            VarA = VarA - Int(VarA)
                            'AUX = AUX + 1 - (CDec(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Cantidad_real")) / CDec(Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")))


                            AUX = AUX - VarA

                            'ahora debo guardar en bd aux, lote_stocl_real, lote_cantidad
                            Dim nrolote As Integer = Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("lote_nro")
                            Dim proveedor_id As Integer = Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("Prov_id")
                            DAlote.Producto_x_sucursal_lote_actualizar_igualar(nrolote, prod_id, sucursal_id,
                                                                          CDec(lote_cantidad), proveedor_id, lote_stock_real, AUX)
                            '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            'ahora me falta actualizar en producto x sucursal, tanto ProdxSuc_stock, ProdxSuc_stock_real
                            recupero_y_recalculo_totales(prod_id, codinterno)

                            'ahora lo elimino de la tabla Consumo_mercaderia_detalle
                            DAMovintoMer.Consumo_Mercaderia_Detalle_eliminar(Consumo_mercaderia_id, codinterno, CInt(Ds_enfermeria.Tables("Consumo_real1_aux").Rows(aa).Item("lote_id")))
                            cont_eliminados = cont_eliminados + 1

                        End If
                        aa = aa + 1
                    End While
                    If valido_eliminados = "si" Then
                        'tenog que borrar la tabla Consumo_Mercaderia
                        If cont_eliminados = Ds_enfermeria.Tables("Consumo_real1_aux").Rows.Count Then
                            'con esta variable Consumo_mercaderia_id voy a eliminar la fila en la tabla consumo_mercaderia
                            DAMovintoMer.Consumo_Mercaderia_eliminar_Enfermeria(Consumo_mercaderia_id)
                            borrado_todo_item_recuperado = "si"
                        End If

                    End If
                End If

                'aqui voy a guardar si es necesario lo que agregué nuevo en la grilla de insumos.
                '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                If Ds_enfermeria.Tables("Consumo_real").Rows.Count <> 0 Then 'significa que hay altas nuevas para registrar

                    Dim MovMer_id As Integer
                    Dim lote_id As Integer
                    If borrado_todo_item_recuperado = "si" Then
                        Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta_Enfermeria("Insumo consumido en Enfermeria", fecha_registrar, Inicio.USU_id, sucursal_id, modificar_sesiones_id)
                        MovMer_id = ds_movid.Tables(0).Rows(0).Item(0)
                    Else
                        MovMer_id = Consumo_mercaderia_id
                    End If

                    ''''''''''''''''''''''''''''''''''''''''''''''''

                    Dim i As Integer = 0
                    'While i < Mov_DS.Tables("Mov_Enf").Rows.Count
                    While i < Ds_enfermeria.Tables("Consumo_real").Rows.Count ' esta ciclando en la grilla oculta que siempre tiene altas.
                        '''''Actualizacion de Stock''''''''''''''''''''''''
                        Dim Ds_Suc As DataSet
                        'Dim Origen As Integer
                        'Dim Destino As Integer
                        'Dim Mov As Decimal
                        'Dim j As Integer = 0
                        'While i < Mov_DS.Tables("Mov").Rows.Count
                        ds_PROD = DAprod.Producto_buscarcod(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cod_prod"))
                        Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                        Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, sucursal_id, sucursal_id) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano y el id 5 es dialisis de calle

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
                        '////////////////choco: 08-07-2020////////////////////////
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
                End If
                '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                MessageBox.Show("La información se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lbl_err.Visible = False
                lbl_err1.Visible = False
                lbl_err2.Visible = False
                lbl_err3.Visible = False
                lbl_err4.Visible = False
                lbl_err5.Visible = False
                lbl_err6.Visible = False
                lbl_err7.Visible = False
                limpiar()
            Else

            End If
        Else
            'lbl_err.Visible = True 'peso seco
            'lbl_err1.Visible = True 'talla
            lbl_err2.Visible = True 'tipo filtro
            'lbl_err3.Visible = True 'horarios
            'lbl_err4.Visible = True 'peso
            'lbl_err5.Visible = True 'tension arterial
            'lbl_err6.Visible = True 'observacion
            lbl_err7.Visible = True 'tipo acceso vascular
            MessageBox.Show("Complete los Campos Obligatorios. ", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub tb_PesoS_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_PesoS.LostFocus
        If tb_PesoS.Text = "" Then
            tb_PesoS.Text = CDec(0)
        End If
    End Sub

    Private Sub tb_talla_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_talla.LostFocus
        If tb_talla.Text = "" Then
            tb_talla.Text = CDec(0)
        End If
    End Sub

    Private Sub tb_PesoI_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_PesoI.LostFocus
        If tb_PesoI.Text = "" Then
            tb_PesoI.Text = CDec(0)
        End If
    End Sub

    Private Sub tb_PesoE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_PesoE.LostFocus
        If tb_PesoE.Text = "" Then
            tb_PesoE.Text = CDec(0)
        End If
    End Sub

    Private Sub tb_TAI_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_TAI.LostFocus
        If tb_TAI.Text = "" Then
            tb_TAI.Text = CDec(0)
        End If
    End Sub

    Private Sub tb_TAE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_TAE.LostFocus
        If tb_TAE.Text = "" Then
            tb_TAE.Text = CDec(0)
        End If
    End Sub
End Class