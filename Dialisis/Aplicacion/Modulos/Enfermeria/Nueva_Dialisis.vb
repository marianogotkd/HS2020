Public Class Nueva_Dialisis
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


    Private Sub Nueva_Dialisis_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obetener_Cliente()
        Obtener_AV()
        Obtener_Filtro()

        If tipo_operacion = "modificar presente" Then
            'recupero todo lo de dialisis
            obtener_info_sesion_dialisis()

            lb_estado.Text = "ESTADO: CONECTADO"
            btn_finalizar.Enabled = True 'lo habilito ahora si se puede finalizar.
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
                Dim Ds_Suc As DataSet = DAsucursal.Sucursal_obtener_producto(prod_id, 3, 3)
                Dim unidad_medida As String = Ds_Suc.Tables(0).Rows(0).Item("prod_unidadmedida")
                Dim contenido As Decimal = Ds_Suc.Tables(0).Rows(0).Item("prod_contenido")
                If Ds_Suc.Tables(0).Rows.Count <> 0 Then
                    'si existe el producto en suc, continuamos
                    'recupero los lotes de dicho insumo
                    Dim ds_lotes As DataSet = DAlote.Producto_x_sucursal_lote_recuperartodos(prod_codinterno, 3)
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


        Else
            tb_CantRe.Text = 0
            Filtro_var = "Nuevo"
        End If
    End Sub
    Private Sub obtener_info_sesion_dialisis()
        Mov_DS.Tables("Mov_Enf").Rows.Clear()
        Dim info_sesion As DataSet = DAsesiones.Sesiones_obtener_info_dialisis(modificar_sesiones_id)

        If info_sesion.Tables(0).Rows.Count <> 0 Then
            'aqui cargo la info

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

            'ahora si tiene consumos los coloco.
            If info_sesion.Tables(1).Rows.Count <> 0 Then
                Dim i As Integer = 0
                While i < info_sesion.Tables(1).Rows.Count
                    Dim fila As DataRow = Mov_DS.Tables("Mov_Enf").NewRow
                    fila("N°") = i + 1
                    fila("Cod_prod") = info_sesion.Tables(1).Rows(i).Item("prod_codinterno")
                    fila("Descripcion") = info_sesion.Tables(1).Rows(i).Item("prod_descripcion")
                    fila("Prov_id") = 0
                    fila("Cantidad") = info_sesion.Tables(1).Rows(i).Item("Consumo_mercaderiadetalle_cantidad")
                    fila("Cantidad_a_consumir") = info_sesion.Tables(1).Rows(i).Item("Consumo_mercaderiadetalle_cantidad").ToString + " " + info_sesion.Tables(1).Rows(i).Item("prod_unidadmedida")
                    fila("EnBD") = "si"

                    'fila("Lote") = info_sesion.Tables(1).Rows(i).Item("lote_nro")
                    'fila("Vence") = info_sesion.Tables(1).Rows(i).Item("lote_vence")
                    'If info_sesion.Tables(1).Rows(i).Item("lote_vence") = "si" Then
                    '    fila("FechaFabricacion") = info_sesion.Tables(1).Rows(i).Item("lote_fechafab")
                    '    fila("FechaVencimiento") = info_sesion.Tables(1).Rows(i).Item("lote_fechavto")
                    'End If

                    Mov_DS.Tables("Mov_Enf").Rows.Add(fila)
                    i = i + 1
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
        Sesiones_prod_agregar.sucursal_id = 3 ' el ID 3 es La Sucursal Sala de Dialisis
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
        Dim ds_sesiones As DataSet = DAsesiones.sesiones_alta(PAC_id, fecha_registrar, "Presente") 'mando el parametro fecha_registrar porque es la que tiene el resultado de la busqueda, es decir lo que se esta mostrando en la grilla
        sesiones_id = ds_sesiones.Tables(0).Rows(0).Item(0) 'este recupera el id del q acabo de insertar

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
            DaEnfermeria.Filtro_Nuevo(PAC_id, fecha_registrar, tb_CantRe.Text, sesiones_id, tb_Filtro.Text)
        End If

        If Filtro_var = "Update" Then
            DaEnfermeria.Filtro_modificar_Cant(FiltroDS.Tables(0).Rows(0).Item("Filtro_id"), tb_CantRe.Text)
        End If
        '''''''''''''''''''''''''''''''
    End Sub

    Private Sub modificar_dialisis()
        If tb_PesoE.Text <> "" And tb_PesoI.Text <> "" And tb_PesoS.Text <> "" And tb_TAE.Text <> "" And tb_TAI.Text <> "" And
                        tb_talla.Text <> "" And tb_tiempoHD.Text <> "" And tb_HI.Text <> "" And tb_HE.Text <> "" And tb_Filtro.Text <> "" And tb_AV.Text <> "" Then

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




                Guardar_Datos_Filtro()

                'aqui voy a guardar si es necesario lo que agregué nuevo en la grilla de insumos.
                '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Dim lote_id As Integer
                Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta_Enfermeria("Insumo consumido en Enfermeria", fecha_registrar, Inicio.USU_id, 3, sesiones_id)
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
                    Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, 3, 3) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano

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
                    DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, 3, TOTAL, TotalReal) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
                    ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano


                    '''''''''''
                    '////////////////choco: 08-07-2020////////////////////////
                    'actualizo la cant en el lote asociado a un producto de una sucursal.
                    'busco lote en grilla
                    Dim lote_nro As String = ds_lote.Tables(0).Rows(0).Item("lote_nro")



                    'Dim cant_a_quitar As Decimal = CDec(Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad"))
                    Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, 3, Int(VarB), Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Prov_id"), TotalReal_lote, AUX)  ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano
                    lote_id = dslote.Tables(0).Rows(0).Item("lote_id")
                    'End If
                    ''''''''''''''''''''''''''''''''''''''
                    '''''' Alta Tabla Detalle'''''' de movimiento claro está
                    'alta en tabla mercaderia_detalle_alta
                    DAMovintoMer.Consumo_mercaderia_Detalle_alta(Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cantidad_real"), MovMer_id, Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Cod_prod"), lote_id)
                    i = i + 1
                End While

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
            lbl_err.Visible = True
            lbl_err1.Visible = True
            lbl_err2.Visible = True
            lbl_err3.Visible = True
            lbl_err4.Visible = True
            lbl_err5.Visible = True
            lbl_err6.Visible = True
            lbl_err7.Visible = True
            MessageBox.Show("Complete los Campos Obligatorios. ", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If tipo_operacion = "modificar presente" Then
            modificar_dialisis()
        Else
            If tb_PesoE.Text <> "00,00" And tb_PesoI.Text <> "00,00" And tb_PesoS.Text <> "00,00" And tb_TAE.Text <> "00,00" And tb_TAI.Text <> "00,00" And
                        tb_talla.Text <> "00,00" And tb_tiempoHD.Text <> "00:00" And tb_HI.Text <> "00:00" And tb_HE.Text <> "00:00" And tb_Filtro.Text <> "" And tb_AV.Text <> "No Tiene Acceso Vascular" Then


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
                                DAsesiones.Sesiones_modificar(ausente_sesiones_id, fecha_registrar, "Presente")
                                sesiones_id = ausente_sesiones_id  'este recupera el id del q acabo de insertar
                            End If
                        End If
                        Guardar_dialisis()

                        Guardar_Datos_Filtro()

                        Dim lote_id As Integer
                        Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta_Enfermeria(concepto, fecha_registrar, Inicio.USU_id, 3, sesiones_id)
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
                            Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, 3, 3) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano

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
                            DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, 3, TOTAL, TotalReal) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
                            ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano


                            '''''''''''
                            '////////////////choco: 08-07-2020///////////////////////////////////
                            'actualizo la cant en el lote asociado a un producto de una sucursal.
                            'busco lote en grilla
                            Dim lote_nro As String = ds_lote.Tables(0).Rows(0).Item("lote_nro")



                            'Dim cant_a_quitar As Decimal = CDec(Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad"))
                            Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, 3, Int(VarB), Ds_enfermeria.Tables("Consumo_real").Rows(i).Item("Prov_id"), TotalReal_lote, AUX)  ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano
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
                                DAsesiones.Sesiones_modificar(ausente_sesiones_id, fecha_registrar, "Presente")
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
                lbl_err.Visible = True
                lbl_err1.Visible = True
                lbl_err2.Visible = True
                lbl_err3.Visible = True
                lbl_err4.Visible = True
                lbl_err5.Visible = True
                lbl_err6.Visible = True
                lbl_err7.Visible = True
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
        tb_CantRe.Text = 0
        Filtro_var = "Nuevo"
        tb_Filtro.Enabled = True
        tb_Filtro.Focus()
        tb_Filtro.SelectAll()
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