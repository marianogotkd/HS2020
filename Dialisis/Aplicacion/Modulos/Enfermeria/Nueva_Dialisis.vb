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

    Private Sub Nueva_Dialisis_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obetener_Cliente()
        Obtener_AV()
        Obtener_Filtro()


        If tipo_operacion = "modificar presente" Then
            'recupero todo lo de dialisis
            obtener_info_sesion_dialisis()
        Else
            'hago el alta normal o bien si es ausente
            Dim ds_Dialisis As DataSet = DaEnfermeria.Dialisis_Obtener
            If ds_Dialisis.Tables(0).Rows.Count <> 0 Then
                tb_numHemo.Text = ds_Dialisis.Tables(0).Rows.Count + 1
            Else
                tb_numHemo.Text = 1
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
                    fila("Descripcion") = info_sesion.Tables(1).Rows(i).Item("prod_descripcion") + " (Lote Nº: " + info_sesion.Tables(1).Rows(i).Item("lote_nro") + ")"
                    fila("Cantidad") = info_sesion.Tables(1).Rows(i).Item("Consumo_mercaderiadetalle_cantidad")
                    fila("Lote") = info_sesion.Tables(1).Rows(i).Item("lote_nro")
                    fila("Vence") = info_sesion.Tables(1).Rows(i).Item("lote_vence")
                    If info_sesion.Tables(1).Rows(i).Item("lote_vence") = "si" Then
                        fila("FechaFabricacion") = info_sesion.Tables(1).Rows(i).Item("lote_fechafab")
                        fila("FechaVencimiento") = info_sesion.Tables(1).Rows(i).Item("lote_fechavto")
                    End If

                    Mov_DS.Tables("Mov_Enf").Rows.Add(fila)
                    i = i + 1
                End While

                'y luego bloqueo los consumos.

            End If
            GroupBox_insumos.Enabled = False
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

    Public Function calcularEdad(ByVal nacimiento As Date) As Integer
        Dim edad As Integer
        edad = Today.Year - nacimiento.Year
        If (nacimiento > Today.AddYears(-edad)) Then edad -= 1
        Return edad
    End Function

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

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'es lo mismo que baja de mercaderia
        GM_Baja_Producto.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
        GM_Baja_Producto.sucursal_id = 3 ' el ID 3 es La Sucursal Sala de Dialisis
        GM_Baja_Producto.form_procedencia = "Gestion_Mercaderia"
        GM_Baja_Producto.Text = "Enfermeria"
        GM_Baja_Producto.tipo_movimiento = "consumir producto en enfermeria"
        GM_Baja_Producto.Show()
    End Sub

    Private Sub limpiar()
        Sesion_pacientes.recuperar_pacientes_fecha_del_dia(Sesion_pacientes.fecha.Value)

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
            DaEnfermeria.Filtro_Nuevo(PAC_id, Now, tb_CantRe.Text, tb_numHemo.Text)
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
                        tb_talla.Text <> "00,00" And tb_tiempoHD.Text <> "00:00" And tb_HI.Text <> "00:00" And tb_HE.Text <> "00:00" And tb_Filtro.Text <> "" And tb_AV.Text <> "" Then


                Dim concepto As String
                concepto = "Insumo consumido en Enfermeria"
                ''''Alta en tabla Movimiento_Mercaderia''''''''''
                If Mov_DS.Tables("Mov_Enf").Rows.Count <> 0 Then
                    Dim result As Integer = MessageBox.Show("¿Esta seguro que desea consumir los insumos listados?", "Sistema de Gestión", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then

                        If tipo_operacion = "alta" Then
                            Guardar_Sesion()
                        Else
                            If tipo_operacion = "ausente" Then
                                'aqui voy a hacer un update del registro en la tabla sesiones, cambio estado ausente por presente
                                DAsesiones.Sesiones_modificar(ausente_sesiones_id, fecha_registrar, "Presente")
                                sesiones_id = ausente_sesiones_id  'este recupera el id del q acabo de insertar
                            End If
                        End If
                        Guardar_dialisis()

                        Dim lote_id As Integer
                        Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta_Enfermeria(concepto, Today, Inicio.USU_id, 3, sesiones_id)
                        ''''''''''''''''''''''''''''''''''''''''''''''''

                        Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
                        Dim i As Integer = 0
                        While i < Mov_DS.Tables("Mov_Enf").Rows.Count
                            '''''Actualizacion de Stock''''''''''''''''''''''''
                            Dim Ds_Suc As DataSet
                            'Dim Origen As Integer
                            'Dim Destino As Integer
                            Dim Mov As Decimal
                            'Dim j As Integer = 0
                            'While i < Mov_DS.Tables("Mov").Rows.Count
                            ds_PROD = DAprod.Producto_buscarcod(Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cod_prod"))
                            Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
                            Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, 3, 3) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano


                            'If cb_Movimiento.SelectedItem = "Baja de Mercaderia" Then
                            'Calculo Stock''''''''
                            Mov = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad")
                            '''''''
                            ''''''''''
                            'Actualizo stock''''' no quito el registro del producto en la sucursal, en realidad lo que hago es actualizar su cantidad a 0. OJO No tiene que hacerse negativo.
                            DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, 3, Mov) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
                            ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano


                            '''''''''''
                            '////////////////choco: 08-07-2020///////////////////////////////////
                            'actualizo la cant en el lote asociado a un producto de una sucursal.
                            Dim lote_nro As String = Mov_DS.Tables("Mov_Enf").Rows(i).Item("Lote")
                            Dim cant_a_quitar As Decimal = CDec(Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad"))
                            Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, 3, cant_a_quitar, Mov_DS.Tables("Mov_Enf").Rows(i).Item("Prov_id"))  ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano
                            lote_id = dslote.Tables(0).Rows(0).Item("lote_id")
                            'End If
                            ''''''''''''''''''''''''''''''''''''''
                            '''''' Alta Tabla Detalle'''''' de movimiento claro está
                            'alta en tabla mercaderia_detalle_alta
                            DAMovintoMer.Consumo_mercaderia_Detalle_alta(Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad"), MovMer_id, Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cod_prod"), lote_id)
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
                            If tipo_operacion = "ausente" Then
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

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    
    Dim validadiones As New Validaciones
    Private Sub tb_PesoS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_PesoS.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_PesoS)
    End Sub

    Private Sub tb_talla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_talla.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_talla)
    End Sub

    Private Sub tb_PesoI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_PesoI.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_PesoI)
    End Sub

    Private Sub tb_PesoE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_PesoE.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_PesoE)
    End Sub

    Private Sub tb_TAI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_TAI.KeyPress
        validadiones.Restricciones_maskedtextbox(e, "Decimal", tb_TAI)
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
End Class