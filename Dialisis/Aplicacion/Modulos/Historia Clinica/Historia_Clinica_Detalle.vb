Imports System.IO
Imports System.Data.OleDb
Public Class Historia_Clinica_Detalle
    Public PAC_id As Integer
    Dim DApaciente As New Datos.Paciente
    Dim DAmedico As New Datos.Medico
    Dim DAHistoria As New Datos.Historia_Clinica
    Public ds_historiaC As DataSet
    Dim Var_Boton = "Modificar"
    Dim var_boton_consultaclinica = "Modificar"
    Dim var_boton_consultapsicologica = "Modificar"
    Dim var_boton_asistenciasocial = "Modificar"
    Dim var_boton_consultanutricional = "Modificar"
    Dim var_boton_AccesoVascular = "Modificar"
    Dim var_boton_Trasp = "Modificar"

    Dim radio As String



    Private Sub Historia_Clinica_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Obtener_medicos()
        Obetener_Cliente()

        'tx_Fecha_cc.Text = Today
        'tx_fecha_AS.Text = Today
        'tx_fecha_CN.Text = Today
        'tx_fecha_cp.Text = Today

        Fecha_cc.Value = Today
        Fecha_AS.Value = Today
        Fecha_CN.Value = Today
        fecha_cp.Value = Today

        Obtener_grillas()
    End Sub

    Private Sub limpiar_EvaMed()
        tx_ev_AEA.Text = Nothing
        tx_ev_AF.Text = Nothing
        tx_ev_APP.Text = Nothing
        tx_ev_DN.Text = Nothing
        tx_ev_EF.Text = Nothing
        tx_ev_EP.Text = Nothing

    End Sub

    Private Sub limpiar_ConMEd()
        tx_cc_AC.Text = Nothing
        tx_cc_EST.Text = Nothing
        tx_cc_EVA.Text = Nothing
        tx_cc_MC.Text = Nothing
        tx_cc_MED.Text = Nothing
    End Sub

    Private Sub limpiar_ConPsi()
        tx_cp_EST.Text = Nothing
        tx_cp_EV.Text = Nothing
        tx_cp_MC.Text = Nothing
        tx_cp_MED.Text = Nothing
        DG_CP.Enabled = True

    End Sub

    Private Sub limpiar_AsiSoc()
        tx_as_EV.Text = Nothing
        tx_as_MC.Text = Nothing
        dgv_AS.Enabled = True
    End Sub

    Private Sub limpiar_ConNut()
        tx_cn_EST.Text = Nothing
        tx_cn_EV.Text = Nothing
        tx_cn_MC.Text = Nothing
        DG_Nutri.Enabled = True
    End Sub

    Dim grillas_listas = "no"
    Private Sub Obtener_grillas()
        ds_historiaC = DAHistoria.Consulta_Obtener_Todos_Estudios_x_PAC(PAC_id)

        If ds_historiaC.Tables("HistoriaC").Rows.Count <> 0 Then
            Historia_Clinica.Tables("Consulta_antecedentes").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Historia_Clinica.Tables("Consulta_antecedentes").Merge(ds_historiaC.Tables("HistoriaC"))

            tx_motivo_consulta.Text = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_motivo_consulta").ToString)
            tx_ev_AEA.Text = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_enferAct"))
            tx_ev_AF.Text = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_familiares"))
            tx_ev_APP.Text = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_patologico"))
            tx_ev_DN.Text = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_Diag"))
            tx_ev_EF.Text = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_fisico"))
            tx_ev_EP.Text = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_estudios"))
        Else
            'tx_ev_AEA.ReadOnly = False
            'tx_ev_AF.ReadOnly = False
            'tx_ev_APP.ReadOnly = False
            'tx_ev_DN.ReadOnly = False
            'tx_ev_EF.ReadOnly = False
            'tx_ev_EP.ReadOnly = False
        End If

        If ds_historiaC.Tables("HistoriaC2").Rows.Count <> 0 Then
            Historia_Clinica.Tables("Consulta_psicológica").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Historia_Clinica.Tables("Consulta_psicológica").Merge(ds_historiaC.Tables("HistoriaC2"))
        End If

        If ds_historiaC.Tables("HistoriaC1").Rows.Count <> 0 Then
            Historia_Clinica.Tables("Consulta_Medica").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Historia_Clinica.Tables("Consulta_Medica").Merge(ds_historiaC.Tables("HistoriaC1"))
        End If

        If ds_historiaC.Tables("HistoriaC3").Rows.Count <> 0 Then
            Historia_Clinica.Tables("Consulta_A_Social").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Historia_Clinica.Tables("Consulta_A_Social").Merge(ds_historiaC.Tables("HistoriaC3"))
        End If

        If ds_historiaC.Tables("HistoriaC4").Rows.Count <> 0 Then
            Historia_Clinica.Tables("Consulta_nutricional").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Historia_Clinica.Tables("Consulta_nutricional").Merge(ds_historiaC.Tables("HistoriaC4"))
        End If

        If ds_historiaC.Tables("HistoriaC5").Rows.Count <> 0 Then
            Historia_Clinica.Tables("Consulta_AccesoV").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Historia_Clinica.Tables("Consulta_AccesoV").Merge(ds_historiaC.Tables("HistoriaC5"))
        End If

        If ds_historiaC.Tables("HistoriaC6").Rows.Count <> 0 Then
            Historia_Clinica.Tables("Consulta_Trasplante").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Historia_Clinica.Tables("Consulta_Trasplante").Merge(ds_historiaC.Tables("HistoriaC6"))
        End If


        grillas_listas = "si"

    End Sub


    Private Sub Obetener_Cliente()
        Dim ds_clie_recu As DataSet = DApaciente.Paciente_obtener_info(PAC_id)
        If ds_clie_recu.Tables(0).Rows.Count <> 0 Then
            tb_Dni_Cuit.Text = ds_clie_recu.Tables(0).Rows(0).Item("PAC_dni")
            tb_fecnac.Text = ds_clie_recu.Tables(0).Rows(0).Item("PAC_fnac")
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





    Public Function calcularEdad(ByVal nacimiento As Date) As Integer
        Dim edad As Integer
        edad = Today.Year - nacimiento.Year
        If (nacimiento > Today.AddYears(-edad)) Then edad -= 1
        Return edad
    End Function

    Dim medicos As String = "no"
    Dim ds As DataSet
    Dim ds2 As DataSet
    Private Sub Obtener_medicos()
        ds = DAmedico.Medicos_Obtener
        cb_med_cc.DataSource = ds.Tables(0)
        cb_med_cc.DisplayMember = "medico_nombre"
        cb_med_cc.ValueMember = "medico_id"
        tx_Nmat_cc.Text = ds.Tables(0).Rows(0).Item("medico_matricula")

        cb_med_cp.DataSource = ds.Tables(0)
        cb_med_cp.DisplayMember = "medico_nombre"
        cb_med_cp.ValueMember = "medico_id"
        tx_nmat_cp.Text = ds.Tables(0).Rows(0).Item("medico_matricula")

        cb_med_AS.DataSource = ds.Tables(0)
        cb_med_AS.DisplayMember = "medico_nombre"
        cb_med_AS.ValueMember = "medico_id"
        tx_nmat_AS.Text = ds.Tables(0).Rows(0).Item("medico_matricula")

        cb_med_CN.DataSource = ds.Tables(0)
        cb_med_CN.DisplayMember = "medico_nombre"
        cb_med_CN.ValueMember = "medico_id"
        tx_nmat_CN.Text = ds.Tables(0).Rows(0).Item("medico_matricula")

        cb_ACCV_med.DataSource = ds.Tables(0)
        cb_ACCV_med.DisplayMember = "medico_nombre"
        cb_ACCV_med.ValueMember = "medico_id"
        tb_ACCV_nmat.Text = ds.Tables(0).Rows(0).Item("medico_matricula")

        cb_TRAS_med.DataSource = ds.Tables(0)
        cb_TRAS_med.DisplayMember = "medico_nombre"
        cb_TRAS_med.ValueMember = "medico_id"
        tb_TRAS_nmat.Text = ds.Tables(0).Rows(0).Item("medico_matricula")

        '///////////////////////////////////////////////////////////////////////////////////////////////////
        ds2 = DAmedico.Medicos_Obtener_activos
        cb_med_cc_activos.DataSource = ds2.Tables(0)
        cb_med_cc_activos.DisplayMember = "medico_nombre"
        cb_med_cc_activos.ValueMember = "medico_id"
        'tx_Nmat_cc.Text = ds2.Tables(0).Rows(0).Item("medico_matricula")

        cb_med_cp_activos.DataSource = ds2.Tables(0)
        cb_med_cp_activos.DisplayMember = "medico_nombre"
        cb_med_cp_activos.ValueMember = "medico_id"
        'tx_nmat_cp.Text = ds2.Tables(0).Rows(0).Item("medico_matricula")

        cb_med_AS_activos.DataSource = ds2.Tables(0)
        cb_med_AS_activos.DisplayMember = "medico_nombre"
        cb_med_AS_activos.ValueMember = "medico_id"
        'tx_nmat_AS.Text = ds2.Tables(0).Rows(0).Item("medico_matricula")

        cb_med_CN_activos.DataSource = ds2.Tables(0)
        cb_med_CN_activos.DisplayMember = "medico_nombre"
        cb_med_CN_activos.ValueMember = "medico_id"
        'tx_nmat_CN.Text = ds2.Tables(0).Rows(0).Item("medico_matricula")

        cb_ACCV_med_activos.DataSource = ds2.Tables(0)
        cb_ACCV_med_activos.DisplayMember = "medico_nombre"
        cb_ACCV_med_activos.ValueMember = "medico_id"
        'tb_ACCV_nmat.Text = ds2.Tables(0).Rows(0).Item("medico_matricula")

        cb_TRAS_med_activos.DataSource = ds2.Tables(0)
        cb_TRAS_med_activos.DisplayMember = "medico_nombre"
        cb_TRAS_med_activos.ValueMember = "medico_id"
        'tb_TRAS_nmat.Text = ds2.Tables(0).Rows(0).Item("medico_matricula")

        medicos = "si"
    End Sub



    Private Sub BO_cliente_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CC_Guardar.Click
        'var_boton_consultaclinica="Alta"

        If tx_cc_MC.Text <> "" And tx_cc_EVA.Text <> "" Then
            If var_boton_consultaclinica = "Alta" Then

                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea guardar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DAHistoria.Consulta_Medica_alta(Fecha_cc.Value, tx_desc_cc.Text, tx_cc_EVA.Text, tx_cc_MC.Text, tx_cc_MED.Text, tx_cc_EST.Text, tx_cc_AC.Text, PAC_id, CInt(cb_med_cc_activos.SelectedValue))
                    var_boton_consultaclinica = "Modificar"
                    DG_CC.Enabled = True
                    MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lbl_err_CC.Visible = False
                    lbl_err_CC2.Visible = False
                    limpiar_ConMEd()
                    Obtener_grillas()

                    '//////////////choco
                    tx_cc_MC.ReadOnly = True
                    tx_cc_EVA.ReadOnly = True
                    tx_cc_MED.ReadOnly = True
                    tx_cc_AC.ReadOnly = True
                    tx_cc_EST.ReadOnly = True

                    tx_cc_MC.BackColor = Color.Beige
                    tx_cc_EVA.BackColor = Color.Beige
                    tx_cc_MED.BackColor = Color.Beige
                    tx_cc_AC.BackColor = Color.Beige
                    tx_cc_EST.BackColor = Color.Beige

                    btn_NC_CC.Enabled = True
                    btn_modif_CC.Enabled = True
                    btn_CC_Guardar.Enabled = False
                    btn_hc.Enabled = False
                    cb_med_cc.Enabled = False
                    '/////////////////////////////


                    '////////////choco 11-09-2020 
                    cb_med_cc.Visible = True
                    cb_med_cc.Enabled = False
                    cb_med_cc_activos.Visible = False
                    cb_med_cc_activos.Enabled = False

                End If

                



            Else
                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea modificar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DAHistoria.Consulta_Medica_Modificar(Fecha_cc.Value, tx_desc_cc.Text, tx_cc_EVA.Text, tx_cc_MC.Text, tx_cc_MED.Text, tx_cc_EST.Text, tx_cc_AC.Text, PAC_id, CInt(cb_med_cc_activos.SelectedValue), DG_CC.SelectedCells(0).Value)
                    MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lbl_err_CC.Visible = False
                    lbl_err_CC2.Visible = False
                    limpiar_ConMEd()
                    Obtener_grillas()
                    DG_CC.Enabled = True

                    '//////////////choco
                    tx_cc_MC.ReadOnly = True
                    tx_cc_EVA.ReadOnly = True
                    tx_cc_MED.ReadOnly = True
                    tx_cc_AC.ReadOnly = True
                    tx_cc_EST.ReadOnly = True

                    btn_NC_CC.Enabled = True
                    btn_modif_CC.Enabled = True
                    btn_CC_Guardar.Enabled = False
                    btn_hc.Enabled = False
                    cb_med_cc.Enabled = False

                    '/////////////////////////////


                    '////////////choco 11-09-2020 
                    cb_med_cc.Visible = True
                    cb_med_cc.Enabled = False
                    cb_med_cc_activos.Visible = False
                    cb_med_cc_activos.Enabled = False


                End If
            End If


        Else
            MessageBox.Show("Debe Ingresar los campos Obligatorios *", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lbl_err_CC.Visible = True
            lbl_err_CC2.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CP_guardar.Click
        If tx_cp_MC.Text <> "" And tx_cp_EV.Text <> "" Then

            If var_boton_consultapsicologica = "Alta" Then
                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea guardar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DAHistoria.Consulta_psicológica_alta(fecha_cp.Value, tx_desc_cp.Text, tx_cp_MC.Text, tx_cp_EV.Text, tx_cp_EST.Text, tx_cp_MED.Text, PAC_id, cb_med_cp_activos.SelectedValue)
                    var_boton_consultapsicologica = "Modificar"
                    DG_CP.Enabled = True
                    MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lbl_err_CP.Visible = False
                    lbl_err_CP2.Visible = False
                    limpiar_ConPsi()
                    Obtener_grillas()

                    '//////////////choco
                    tx_cp_MC.ReadOnly = True
                    tx_cp_EV.ReadOnly = True
                    tx_cp_MED.ReadOnly = True
                    tx_cp_EST.ReadOnly = True


                    tx_cp_MC.BackColor = Color.Beige
                    tx_cp_EV.BackColor = Color.Beige
                    tx_cp_MED.BackColor = Color.Beige
                    tx_cp_EST.BackColor = Color.Beige

                    btn_NC_CP.Enabled = True
                    btn_modif_CP.Enabled = True
                    btn_CP_guardar.Enabled = False
                    Button1.Enabled = False
                    cb_med_cp.Enabled = False
                    '/////////////////////////////



                    '////////////choco 11-09-2020 
                    cb_med_cp.Visible = True
                    cb_med_cp.Enabled = False
                    cb_med_cp_activos.Visible = False
                    cb_med_cp_activos.Enabled = False


                End If

            Else
                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea modificar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DAHistoria.Consulta_psicológica_Modificar(fecha_cp.Value, tx_desc_cp.Text, tx_cp_MC.Text, tx_cp_EV.Text, tx_cp_EST.Text, tx_cp_MED.Text, PAC_id, cb_med_cp_activos.SelectedValue, DG_CP.SelectedCells(0).Value)
                    MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lbl_err_CP.Visible = False
                    lbl_err_CP2.Visible = False
                    limpiar_ConPsi()
                    Obtener_grillas()
                    DG_CP.Enabled = True

                    '//////////////choco
                    tx_cp_MC.ReadOnly = True
                    tx_cp_EV.ReadOnly = True
                    tx_cp_MED.ReadOnly = True
                    tx_cp_EST.ReadOnly = True

                    btn_NC_CP.Enabled = True
                    btn_modif_CP.Enabled = True
                    btn_CP_guardar.Enabled = False
                    Button1.Enabled = False
                    'cb_med_cp.Enabled = False

                    '/////////////////////////////

                    '////////////choco 11-09-2020 
                    cb_med_cp.Visible = True
                    cb_med_cp.Enabled = False
                    cb_med_cp_activos.Visible = False
                    cb_med_cp_activos.Enabled = False


                End If
            End If
        Else
            MessageBox.Show("Debe Ingresar los campos Obligatorios *", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lbl_err_CP.Visible = True
            lbl_err_CP2.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AS_guardar.Click
        If tx_as_EV.Text <> "" And tx_as_MC.Text <> "" Then

            If var_boton_asistenciasocial = "Alta" Then
                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea guardar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DAHistoria.Consulta_A_Social_alta(Fecha_AS.Value, tx_desc_AS.Text, tx_as_MC.Text, tx_as_EV.Text, PAC_id, cb_med_AS_activos.SelectedValue)
                    var_boton_asistenciasocial = "Modificar"
                    dgv_AS.Enabled = True
                    MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lbl_err_AS.Visible = False
                    lbl_err_AS_2.Visible = False
                    limpiar_AsiSoc()
                    Obtener_grillas()

                    '//////////////choco
                    tx_as_MC.ReadOnly = True
                    tx_as_EV.ReadOnly = True

                    tx_as_MC.BackColor = Color.Beige
                    tx_as_EV.BackColor = Color.Beige

                    btn_NC_AS.Enabled = True
                    btn_modif_AS.Enabled = True
                    btn_AS_guardar.Enabled = False
                    Button3.Enabled = False
                    'cb_med_AS.Enabled = False
                    '/////////////////////////////


                    '////////////choco 11-09-2020 
                    cb_med_AS.Visible = True
                    cb_med_AS.Enabled = False
                    cb_med_AS_activos.Visible = False
                    cb_med_AS_activos.Enabled = False


                End If


            Else
                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea modificar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DAHistoria.Consulta_A_Social_Modificar(Fecha_AS.Value, tx_desc_AS.Text, tx_as_MC.Text, tx_as_EV.Text, PAC_id, cb_med_AS_activos.SelectedValue, dgv_AS.SelectedCells(0).Value)
                    MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lbl_err_AS.Visible = False
                    lbl_err_AS_2.Visible = False
                    limpiar_AsiSoc()
                    Obtener_grillas()

                    '//////////////choco
                    tx_as_MC.ReadOnly = True
                    tx_as_EV.ReadOnly = True

                    btn_NC_AS.Enabled = True
                    btn_modif_AS.Enabled = True
                    btn_AS_guardar.Enabled = False
                    Button3.Enabled = False
                    cb_med_AS.Enabled = False
                    '/////////////////////////////


                    '////////////choco 11-09-2020 
                    cb_med_AS.Visible = True
                    cb_med_AS.Enabled = False
                    cb_med_AS.Visible = False
                    cb_med_AS.Enabled = False

                End If
            End If
        Else
            MessageBox.Show("Debe Ingresar los campos Obligatorios *", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lbl_err_AS.Visible = True
            lbl_err_AS_2.Visible = True
        End If

    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CN_guardar.Click
        If tx_cn_EV.Text <> "" And tx_cn_MC.Text <> "" Then

            If var_boton_consultanutricional = "Alta" Then
                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea guardar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DAHistoria.Consulta_nutricional_alta(Fecha_CN.Value, tx_desc_CN.Text, tx_cn_MC.Text, tx_cn_EST.Text, tx_cn_EV.Text, PAC_id, cb_med_CN_activos.SelectedValue)
                    var_boton_consultanutricional = "Modificar"
                    DG_Nutri.Enabled = True
                    MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    lbl_err_CN.Visible = False
                    lbl_err_CN_2.Visible = False
                    limpiar_ConNut()
                    Obtener_grillas()

                    '//////////////choco
                    tx_cn_MC.ReadOnly = True
                    tx_cn_EV.ReadOnly = True
                    tx_cn_EST.ReadOnly = True

                    tx_cn_MC.BackColor = Color.Beige
                    tx_cn_EV.BackColor = Color.Beige
                    tx_cn_EST.BackColor = Color.Beige

                    btn_NC_CN.Enabled = True
                    btn_modif_CN.Enabled = True
                    btn_CN_guardar.Enabled = False
                    Button5.Enabled = False
                    'cb_med_CN.Enabled = False


                    '/////////////////////////////


                    '////////////choco 11-09-2020 
                    cb_med_CN.Visible = True
                    cb_med_CN.Enabled = False
                    cb_med_CN_activos.Visible = False
                    cb_med_CN_activos.Enabled = False


                End If

            Else
                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea modificar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DAHistoria.Consulta_nutricional_Modificar(Fecha_CN.Value, tx_desc_CN.Text, tx_cn_MC.Text, tx_cn_EST.Text, tx_cn_EV.Text, PAC_id, cb_med_CN_activos.SelectedValue, DG_Nutri.CurrentRow.Cells(0).Value)
                    MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    lbl_err_CN.Visible = False
                    lbl_err_CN_2.Visible = False
                    limpiar_ConNut()
                    Obtener_grillas()

                    '//////////////choco
                    tx_cn_MC.ReadOnly = True
                    tx_cn_EV.ReadOnly = True
                    tx_cn_EST.ReadOnly = True


                    btn_NC_CN.Enabled = True
                    btn_modif_CN.Enabled = True
                    btn_CN_guardar.Enabled = False
                    Button5.Enabled = False
                    'cb_med_CN.Enabled = False
                    '/////////////////////////////


                    '////////////choco 11-09-2020 
                    cb_med_CN.Visible = True
                    cb_med_CN.Enabled = False
                    cb_med_CN_activos.Visible = False
                    cb_med_CN_activos.Enabled = False

                End If
            End If
        Else
            MessageBox.Show("Debe Ingresar los campos Obligatorios *", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lbl_err_CN.Visible = True
            lbl_err_CN_2.Visible = True
        End If

    End Sub



    Private Sub btn_hc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hc.Click
        limpiar_ConMEd()
        DG_CC.Enabled = True
        dg_cambio_seleccion()


        tx_cc_MC.ReadOnly = True
        tx_cc_EVA.ReadOnly = True
        tx_cc_MED.ReadOnly = True
        tx_cc_AC.ReadOnly = True
        tx_cc_EST.ReadOnly = True

        tx_cc_MC.BackColor = Color.Beige
        tx_cc_EVA.BackColor = Color.Beige
        tx_cc_MED.BackColor = Color.Beige
        tx_cc_AC.BackColor = Color.Beige
        tx_cc_EST.BackColor = Color.Beige

        btn_NC_CC.Enabled = True
        btn_modif_CC.Enabled = True
        btn_CC_Guardar.Enabled = False
        btn_hc.Enabled = False
        'cb_med_cc.Enabled = False

        '////////choco 11-09-2020 
        cb_med_cc.Visible = True
        cb_med_cc.Enabled = False
        cb_med_cc_activos.Enabled = False
        cb_med_cc_activos.Visible = False


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiar_ConPsi()


        'limpiar_ConMEd()
        DG_CP.Enabled = True
        DG_CP_cambio_seleccion()


        tx_cp_MC.ReadOnly = True
        tx_cp_EV.ReadOnly = True
        tx_cp_MED.ReadOnly = True
        tx_cp_EST.ReadOnly = True

        tx_cp_MC.BackColor = Color.Beige
        tx_cp_EV.BackColor = Color.Beige
        tx_cp_MED.BackColor = Color.Beige
        tx_cp_EST.BackColor = Color.Beige

        btn_NC_CP.Enabled = True
        btn_modif_CP.Enabled = True
        btn_CP_guardar.Enabled = False
        Button1.Enabled = False
        'cb_med_cp.Enabled = False

        '////////choco 11-09-2020 
        cb_med_cp.Visible = True
        cb_med_cp.Enabled = False
        cb_med_cp_activos.Enabled = False
        cb_med_cp_activos.Visible = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        limpiar_AsiSoc()


        'limpiar_ConMEd()
        dgv_AS.Enabled = True
        dgv_as_cambio_seleccion()

        tx_as_MC.ReadOnly = True
        tx_as_EV.ReadOnly = True

        tx_as_MC.BackColor = Color.Beige
        tx_as_EV.BackColor = Color.Beige

        btn_NC_AS.Enabled = True
        btn_modif_AS.Enabled = True
        btn_AS_guardar.Enabled = False
        Button3.Enabled = False
        'cb_med_AS.Enabled = False

        '////////choco 11-09-2020 
        cb_med_AS.Visible = True
        cb_med_AS.Enabled = False
        cb_med_AS_activos.Enabled = False
        cb_med_AS_activos.Visible = False


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        limpiar_ConNut()
        'DG_Nutri.ClearSelection()


        'limpiar_ConMEd()
        DG_Nutri.Enabled = True
        dg_nutri_cambio_seleccion()

        tx_cn_MC.ReadOnly = True
        tx_cn_EV.ReadOnly = True
        tx_cn_EST.ReadOnly = True

        tx_cn_MC.BackColor = Color.Beige
        tx_cn_EV.BackColor = Color.Beige
        tx_cn_EST.BackColor = Color.Beige

        btn_NC_CN.Enabled = True
        btn_modif_CN.Enabled = True
        btn_CN_guardar.Enabled = False
        Button5.Enabled = False
        cb_med_CN.Enabled = False

        '////////choco 11-09-2020 
        cb_med_CN.Visible = True
        cb_med_CN.Enabled = False
        cb_med_CN_activos.Enabled = False
        cb_med_CN_activos.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NC_CC.Click
        limpiar_ConMEd()

        tx_cc_MC.ReadOnly = False
        tx_cc_EVA.ReadOnly = False
        tx_cc_MED.ReadOnly = False
        tx_cc_AC.ReadOnly = False
        tx_cc_EST.ReadOnly = False


        tx_cc_MC.BackColor = Color.White
        tx_cc_EVA.BackColor = Color.White
        tx_cc_MED.BackColor = Color.White
        tx_cc_AC.BackColor = Color.White
        tx_cc_EST.BackColor = Color.White

        Dim cant = CInt(ds_historiaC.Tables("HistoriaC1").Rows.Count) + 1
        tx_desc_cc.Text = "Informe " + CStr(cant)
        tx_desc_cc.SelectAll()
        tx_desc_cc.Focus()
        DG_CC.Enabled = False
        'Var_Boton = "Alta"
        var_boton_consultaclinica = "Alta"
        'cb_med_cc.Enabled = True


        'choco 04-08-2020 - agrego el boton modificar: no se entiende sino la interaccion entre esos 3 botones nuevo, guardar y cancelar

        btn_NC_CC.Enabled = False
        btn_modif_CC.Enabled = False
        btn_CC_Guardar.Enabled = True
        btn_hc.Enabled = True

        '/////choco 11-09-2020 oculto todos
        cb_med_cc.Visible = False
        cb_med_cc.Enabled = False
        cb_med_cc_activos.Visible = True
        cb_med_cc_activos.Enabled = True

        'choco 07-10-2020
        Fecha_cc.Value = Today

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NC_CP.Click
        limpiar_ConPsi()

        tx_cp_MC.ReadOnly = False
        tx_cp_EV.ReadOnly = False
        tx_cp_MED.ReadOnly = False
        tx_cp_EST.ReadOnly = False

        tx_cp_MC.BackColor = Color.White
        tx_cp_EV.BackColor = Color.White
        tx_cp_MED.BackColor = Color.White
        tx_cp_EST.BackColor = Color.White


        Dim cant = CInt(ds_historiaC.Tables("HistoriaC2").Rows.Count) + 1
        tx_desc_cp.Text = "Informe " + CStr(cant)
        tx_desc_cp.SelectAll()
        tx_desc_cp.Focus()
        DG_CP.Enabled = False
        Var_Boton = "Alta"
        var_boton_consultapsicologica = "Alta"

        '        cb_med_cp.Enabled = True


        'choco 04-08-2020 - agrego el boton modificar: no se entiende sino la interaccion entre esos 3 botones nuevo, guardar y cancelar

        btn_NC_CP.Enabled = False
        btn_modif_CP.Enabled = False
        btn_CP_guardar.Enabled = True
        Button1.Enabled = True 'este es boton cancelar


        '/////choco 11-09-2020 oculto todos
        cb_med_cp.Visible = False
        cb_med_cp.Enabled = False
        cb_med_cp_activos.Visible = True
        cb_med_cp_activos.Enabled = True


        fecha_cp.Value = Today
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NC_CN.Click
        limpiar_ConNut()

        tx_cn_MC.ReadOnly = False
        tx_cn_EV.ReadOnly = False
        tx_cn_EST.ReadOnly = False

        tx_cn_MC.BackColor = Color.White
        tx_cn_EV.BackColor = Color.White
        tx_cn_EST.BackColor = Color.White

        Dim cant = CInt(ds_historiaC.Tables("HistoriaC4").Rows.Count) + 1
        tx_desc_CN.Text = "Informe " + CStr(cant)
        tx_desc_CN.SelectAll()
        tx_desc_CN.Focus()
        DG_Nutri.Enabled = False
        var_boton_consultanutricional = "Alta"
        'cb_med_CN.Enabled = True


        btn_NC_CN.Enabled = False
        btn_modif_CN.Enabled = False
        btn_CN_guardar.Enabled = True
        Button5.Enabled = True 'este es boton cancelar


        '/////choco 11-09-2020 oculto todos
        cb_med_CN.Visible = False
        cb_med_CN.Enabled = False
        cb_med_CN_activos.Visible = True
        cb_med_CN_activos.Enabled = True

        Fecha_CN.Value = Today

    End Sub

    Private Sub btn_NC_AS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NC_AS.Click
        limpiar_AsiSoc()

        tx_as_MC.ReadOnly = False
        tx_as_EV.ReadOnly = False

        tx_as_MC.BackColor = Color.White
        tx_as_EV.BackColor = Color.White

        Dim cant = CInt(ds_historiaC.Tables("HistoriaC3").Rows.Count) + 1
        tx_desc_AS.Text = "Informe " + CStr(cant)
        tx_desc_AS.SelectAll()
        tx_desc_AS.Focus()
        dgv_AS.Enabled = False
        var_boton_asistenciasocial = "Alta"
        'cb_med_AS.Enabled = True


        btn_NC_AS.Enabled = False
        btn_modif_AS.Enabled = False
        btn_AS_guardar.Enabled = True
        Button3.Enabled = True 'este es boton cancelar


        '/////choco 11-09-2020 oculto todos
        cb_med_AS.Visible = False
        cb_med_AS.Enabled = False
        cb_med_AS_activos.Visible = True
        cb_med_AS_activos.Enabled = True

        Fecha_AS.Value = Today

    End Sub

    Private Sub cb_med_cc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_med_cc.SelectedIndexChanged
        If medicos = "si" Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds.Tables(0).Rows.Count
                If ds.Tables(0).Rows(i).Item("medico_id") = cb_med_cc.SelectedValue Then
                    tx_Nmat_cc.Text = ds.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub cb_med_cp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_med_cp.SelectedIndexChanged
        If medicos = "si" Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds.Tables(0).Rows.Count
                If ds.Tables(0).Rows(i).Item("medico_id") = cb_med_cp.SelectedValue Then
                    tx_nmat_cp.Text = ds.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub cb_med_AS_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_med_AS.SelectedIndexChanged
        If medicos = "si" Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds.Tables(0).Rows.Count
                If ds.Tables(0).Rows(i).Item("medico_id") = cb_med_AS.SelectedValue Then
                    tx_nmat_AS.Text = ds.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub cb_med_CN_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_med_CN.SelectedIndexChanged
        If medicos = "si" Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds.Tables(0).Rows.Count
                If ds.Tables(0).Rows(i).Item("medico_id") = cb_med_CN.SelectedValue Then
                    tx_nmat_CN.Text = ds.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub DG_CC_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_CC.SelectionChanged
        dg_cambio_seleccion()
    End Sub
    Private Sub dg_cambio_seleccion()
        If DG_CC.Rows.Count <> 0 And grillas_listas = "si" Then
            Dim id_CC = DG_CC.CurrentRow.Cells(0).Value
            If ds_historiaC.Tables("HistoriaC1").Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < ds_historiaC.Tables("HistoriaC1").Rows.Count
                    If ds_historiaC.Tables("HistoriaC1").Rows(fila).Item("conmed_id") = id_CC Then
                        Fecha_cc.Value = ds_historiaC.Tables("HistoriaC1").Rows(fila).Item("conmed_fecha")
                        tx_desc_cc.Text = ds_historiaC.Tables("HistoriaC1").Rows(fila).Item("conmed_titulo")
                        tx_cc_AC.Text = ds_historiaC.Tables("HistoriaC1").Rows(fila).Item("conmed_acceso")
                        tx_cc_EST.Text = ds_historiaC.Tables("HistoriaC1").Rows(fila).Item("conmed_estudios")
                        tx_cc_EVA.Text = ds_historiaC.Tables("HistoriaC1").Rows(fila).Item("conmed_evaluacion")
                        tx_cc_MC.Text = ds_historiaC.Tables("HistoriaC1").Rows(fila).Item("conmed_motivo")
                        tx_cc_MED.Text = ds_historiaC.Tables("HistoriaC1").Rows(fila).Item("conmed_medicacion")
                        cb_med_cc.SelectedValue = ds_historiaC.Tables("HistoriaC1").Rows(fila).Item("medico_id")
                    End If

                    fila = fila + 1

                End While
            End If
        End If
    End Sub


    Private Sub DG_CP_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_CP.SelectionChanged
        DG_CP_cambio_seleccion()

    End Sub

    Private Sub DG_TRAS_Cambio_Seleccion()
        If DG_Tras.Rows.Count <> 0 Then
            Dim id_tras = DG_Tras.CurrentRow.Cells(0).Value
            If ds_historiaC.Tables("HistoriaC6").Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < ds_historiaC.Tables("HistoriaC6").Rows.Count
                    If ds_historiaC.Tables("HistoriaC6").Rows(fila).Item("Tras_id") = id_tras Then
                        tb_TRAS_titulo.Text = ds_historiaC.Tables("HistoriaC6").Rows(fila).Item("Tras_Titulo")
                        cb_TRAS_med.SelectedValue = ds_historiaC.Tables("HistoriaC6").Rows(fila).Item("medico_id")
                        DateTime_LE.Value = ds_historiaC.Tables("HistoriaC6").Rows(fila).Item("Tras_FechaI_LE")
                        tb_TRAS_ev.Text = ds_historiaC.Tables("HistoriaC6").Rows(fila).Item("Tras_evo")
                        tb_TRAS_est.Text = ds_historiaC.Tables("HistoriaC6").Rows(fila).Item("Tras_Estudios")
                        tb_TRAS_CT.Text = ds_historiaC.Tables("HistoriaC6").Rows(fila).Item("Tras_Centro")
                        DateTime_TRAS.Value = ds_historiaC.Tables("HistoriaC6").Rows(fila).Item("Tras_fecha")

                    End If

                    fila = fila + 1

                End While
            End If
        End If
    End Sub
    Private Sub DG_ACCV_Cambio_Seleccion()
        If DG_ACCV.Rows.Count <> 0 Then
            Dim id_ACCV = DG_ACCV.CurrentRow.Cells(0).Value
            If ds_historiaC.Tables("HistoriaC5").Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < ds_historiaC.Tables("HistoriaC5").Rows.Count
                    If ds_historiaC.Tables("HistoriaC5").Rows(fila).Item("AV_id") = id_ACCV Then
                        tb_ACCV_Titulo.Text = ds_historiaC.Tables("HistoriaC5").Rows(fila).Item("AV_titulo")
                        cb_ACCV_med.SelectedValue = ds_historiaC.Tables("HistoriaC5").Rows(fila).Item("medico_id")
                        DateTime_Confex.Value = ds_historiaC.Tables("HistoriaC5").Rows(fila).Item("AV_fechaC")
                        DateTime_PU.Value = ds_historiaC.Tables("HistoriaC5").Rows(fila).Item("AV_fechaPu")
                        tb_ACCV_ubi.Text = ds_historiaC.Tables("HistoriaC5").Rows(fila).Item("AV_ubicacion")
                        tb_ACCV_obs.Text = ds_historiaC.Tables("HistoriaC5").Rows(fila).Item("AV_obs")
                        radio = ds_historiaC.Tables("HistoriaC5").Rows(fila).Item("AV_tipo")

                        DateTime_ACCV.Value = ds_historiaC.Tables("HistoriaC5").Rows(fila).Item("AV_fecha") 'esta es la fecha de alta del registro

                        Dim c As Object
                        For Each c In GroupBox2.Controls
                            If TypeOf (c) Is RadioButton Then
                                Dim rb As RadioButton = CType(c, RadioButton)
                                If rb.Text = radio Then
                                    rb.Checked = True
                                    Exit For
                                End If
                            End If
                        Next


                    End If

                    fila = fila + 1

                End While
            End If
        End If
    End Sub

    Private Sub DG_CP_cambio_seleccion()
        If DG_CP.Rows.Count <> 0 Then
            Dim id_Cp = DG_CP.CurrentRow.Cells(0).Value
            If ds_historiaC.Tables("HistoriaC2").Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < ds_historiaC.Tables("HistoriaC2").Rows.Count
                    If ds_historiaC.Tables("HistoriaC2").Rows(fila).Item("psico_id") = id_Cp Then
                        fecha_cp.Value = ds_historiaC.Tables("HistoriaC2").Rows(fila).Item("psico_fecha")
                        tx_desc_cp.Text = ds_historiaC.Tables("HistoriaC2").Rows(fila).Item("psico_titulo")
                        tx_cp_EST.Text = ds_historiaC.Tables("HistoriaC2").Rows(fila).Item("psico_estudios")
                        tx_cp_EV.Text = ds_historiaC.Tables("HistoriaC2").Rows(fila).Item("psico_evaluacion")
                        tx_cp_MC.Text = ds_historiaC.Tables("HistoriaC2").Rows(fila).Item("psico_motivo")
                        tx_cp_MED.Text = ds_historiaC.Tables("HistoriaC2").Rows(fila).Item("psico_medicacion")
                        cb_med_cp.SelectedValue = ds_historiaC.Tables("HistoriaC2").Rows(fila).Item("medico_id")
                    End If
                    fila = fila + 1
                End While
            End If
        End If
    End Sub

    Private Sub dgv_AS_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_AS.SelectionChanged
        dgv_as_cambio_seleccion()
    End Sub

    Private Sub dgv_as_cambio_seleccion()
        If dgv_AS.Rows.Count <> 0 Then
            Dim id_AS = dgv_AS.CurrentRow.Cells(0).Value
            If ds_historiaC.Tables("HistoriaC3").Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < ds_historiaC.Tables("HistoriaC3").Rows.Count
                    If ds_historiaC.Tables("HistoriaC3").Rows(fila).Item("social_id") = id_AS Then
                        Fecha_AS.Value = ds_historiaC.Tables("HistoriaC3").Rows(fila).Item("social_fecha")
                        tx_desc_AS.Text = ds_historiaC.Tables("HistoriaC3").Rows(fila).Item("social_titulo")
                        tx_as_EV.Text = ds_historiaC.Tables("HistoriaC3").Rows(fila).Item("social_evaluacion")
                        tx_as_MC.Text = ds_historiaC.Tables("HistoriaC3").Rows(fila).Item("social_motivo")
                        cb_med_AS.SelectedValue = ds_historiaC.Tables("HistoriaC3").Rows(fila).Item("medico_id")
                    End If

                    fila = fila + 1

                End While
            End If
        End If
    End Sub

    Private Sub DG_Nutri_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Nutri.SelectionChanged
        dg_nutri_cambio_seleccion()
    End Sub
    Private Sub dg_nutri_cambio_seleccion()
        If DG_Nutri.Rows.Count <> 0 Then
            Dim id_CN = DG_Nutri.CurrentRow.Cells(0).Value
            If ds_historiaC.Tables("HistoriaC4").Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < ds_historiaC.Tables("HistoriaC4").Rows.Count
                    If ds_historiaC.Tables("HistoriaC4").Rows(fila).Item("nutri_id") = id_CN Then
                        Fecha_CN.Value = ds_historiaC.Tables("HistoriaC4").Rows(fila).Item("nutri_fecha")
                        tx_desc_CN.Text = ds_historiaC.Tables("HistoriaC4").Rows(fila).Item("nutri_titulo")
                        tx_cn_EST.Text = ds_historiaC.Tables("HistoriaC4").Rows(fila).Item("nutri_estudios")
                        tx_cn_EV.Text = ds_historiaC.Tables("HistoriaC4").Rows(fila).Item("nutri_evaluacion")
                        tx_cn_MC.Text = ds_historiaC.Tables("HistoriaC4").Rows(fila).Item("nutri_motivo")
                        cb_med_CN.SelectedValue = ds_historiaC.Tables("HistoriaC4").Rows(fila).Item("medico_id")
                    End If

                    fila = fila + 1

                End While
            End If
        End If
    End Sub

    Dim ds_reporte_historial As New Ds_reporte_historial
    Dim DAventa As New Datos.Venta

    'Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
    '    'primero recupero toda la info del cliente/paciente
    '    Dim ds_clie As DataSet = DAcliente.Cliente_obtener_info(cliente_id)
    '    If ds_clie.Tables(1).Rows.Count <> 0 Then
    '        'existe cargo en dataset para informe crystal
    '        Dim fila As DataRow = ds_reporte_historial.Tables("Cliente").NewRow
    '        fila("CLI_id") = ds_clie.Tables(1).Rows(0).Item("CLI_id")
    '        fila("CLI_ape") = ds_clie.Tables(1).Rows(0).Item("CLI_ape")
    '        fila("CLI_nom") = ds_clie.Tables(1).Rows(0).Item("CLI_nom")
    '        fila("CLI_dni") = ds_clie.Tables(1).Rows(0).Item("CLI_dni")
    '        fila("CLI_fnac") = ds_clie.Tables(1).Rows(0).Item("CLI_fnac")
    '        fila("CLI_sexo") = ds_clie.Tables(1).Rows(0).Item("CLI_sexo")
    '        fila("CLI_obrasoc") = ds_clie.Tables(1).Rows(0).Item("CLI_obsoc")
    '        fila("CLI_tel") = ds_clie.Tables(1).Rows(0).Item("CLI_tel")
    '        fila("CLI_dir") = ds_clie.Tables(1).Rows(0).Item("CLI_dir")
    '        fila("CLI_CP") = ds_clie.Tables(1).Rows(0).Item("CLI_CP")
    '        fila("provincia") = ds_clie.Tables(1).Rows(0).Item("provincia")
    '        fila("localidad") = ds_clie.Tables(1).Rows(0).Item("Localidad")
    '        fila("CLI_numafi") = ds_clie.Tables(1).Rows(0).Item("CLI_numafi")
    '        fila("CLI_mail") = ds_clie.Tables(1).Rows(0).Item("CLI_mail")

    '        ds_reporte_historial.Tables("Cliente").Rows.Add(fila)
    '    End If


    '    'carga tabla empresa
    '    Dim usuario_id As String
    '    usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
    '    Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
    '    If ds_usuario.Tables(1).Rows.Count <> 0 Then
    '        ds_reporte_historial.Tables("Empresa").Rows.Clear()
    '        ds_reporte_historial.Tables("Empresa").Merge(ds_usuario.Tables(1))
    '    End If



    '    ds_historiaC = DAHistoria.Consulta_Obtener_Todos_Estudios_x_PAC(cliente_id)

    '    If ds_historiaC.Tables("HistoriaC").Rows.Count <> 0 Then
    '        'Historia_Clinica.Tables("Consulta_antecedentes").Rows.Clear() 'borro el contenido del dataset.datatable clientes
    '        'Historia_Clinica.Tables("Consulta_antecedentes").Merge(ds_historiaC.Tables("HistoriaC"))

    '        Dim evaluacion As DataRow = ds_reporte_historial.Tables("Evaluacion_Medica").NewRow
    '        evaluacion("ConAnt_enferAct") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_enferAct"))
    '        evaluacion("ConAnt_patologico") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_patologico"))
    '        evaluacion("ConAnt_familiares") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_familiares"))
    '        evaluacion("ConAnt_fisico") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_fisico"))
    '        evaluacion("ConAnt_Diag") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_Diag"))
    '        evaluacion("ConAnt_estudios") = (ds_historiaC.Tables("HistoriaC").Rows(0).Item("ConAnt_estudios"))
    '        evaluacion("CLI_id") = cliente_id

    '        ds_reporte_historial.Tables("Evaluacion_Medica").Rows.Add(evaluacion)
    '    End If



    '    '//////////////////////////////////////////////////////////////////////////////////////////////
    '    '//////////////////////////////////////////////////////////////////////////////////////////////
    '    'CONSULTA CLINICA, SON VARIAS

    '    If ds_historiaC.Tables(1).Rows.Count <> 0 Then

    '        'ahora lo recorro y cargo el ds
    '        Dim i As Integer = 0
    '        While i < ds_historiaC.Tables(1).Rows.Count
    '            Dim consultamedica As DataRow = ds_reporte_historial.Tables("Consulta_Clinica").NewRow
    '            consultamedica("conmed_id") = ds_historiaC.Tables(1).Rows(i).Item("conmed_id")
    '            consultamedica("conmed_fecha") = ds_historiaC.Tables(1).Rows(i).Item("conmed_fecha")
    '            consultamedica("conmed_titulo") = ds_historiaC.Tables(1).Rows(i).Item("conmed_titulo")
    '            consultamedica("conmed_evaluacion") = ds_historiaC.Tables(1).Rows(i).Item("conmed_evaluacion")
    '            consultamedica("conmed_motivo") = ds_historiaC.Tables(1).Rows(i).Item("conmed_motivo")
    '            consultamedica("conmed_medicacion") = ds_historiaC.Tables(1).Rows(i).Item("conmed_medicacion")
    '            consultamedica("conmed_estudios") = ds_historiaC.Tables(1).Rows(i).Item("conmed_estudios")
    '            consultamedica("medico_id") = ds_historiaC.Tables(1).Rows(i).Item("medico_id")
    '            'tengo que recuperar el medico
    '            Dim medico_id As Integer = ds_historiaC.Tables(1).Rows(i).Item("medico_id")
    '            Dim j As Integer = 0
    '            While j < ds.Tables(0).Rows.Count
    '                If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
    '                    consultamedica("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
    '                    consultamedica("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
    '                    Exit While
    '                End If
    '                j = j + 1
    '            End While
    '            consultamedica("conmed_acceso") = ds_historiaC.Tables(1).Rows(i).Item("conmed_acceso")
    '            consultamedica("CLI_id") = cliente_id
    '            ds_reporte_historial.Tables("Consulta_Clinica").Rows.Add(consultamedica)

    '            i = i + 1
    '        End While
    '    End If

    '    '///////////////////////////////////////////////////////////////////////////////////////
    '    'CONSULTA PSICOLOGICA
    '    If ds_historiaC.Tables(2).Rows.Count <> 0 Then
    '        'ahora lo recorro y cargo el ds
    '        Dim i As Integer = 0
    '        While i < ds_historiaC.Tables(2).Rows.Count
    '            Dim consultapsicologica As DataRow = ds_reporte_historial.Tables("Consulta_Psicologica").NewRow
    '            consultapsicologica("psico_id") = ds_historiaC.Tables(2).Rows(i).Item("psico_id")
    '            consultapsicologica("psico_titulo") = ds_historiaC.Tables(2).Rows(i).Item("psico_titulo")
    '            consultapsicologica("psico_fecha") = ds_historiaC.Tables(2).Rows(i).Item("psico_fecha")
    '            consultapsicologica("psico_motivo") = ds_historiaC.Tables(2).Rows(i).Item("psico_motivo")
    '            consultapsicologica("psico_evaluacion") = ds_historiaC.Tables(2).Rows(i).Item("psico_evaluacion")
    '            consultapsicologica("psico_estudios") = ds_historiaC.Tables(2).Rows(i).Item("psico_estudios")
    '            consultapsicologica("psico_medicacion") = ds_historiaC.Tables(2).Rows(i).Item("psico_medicacion")
    '            consultapsicologica("CLI_id") = ds_historiaC.Tables(2).Rows(i).Item("CLI_id")
    '            consultapsicologica("medico_id") = ds_historiaC.Tables(2).Rows(i).Item("medico_id")
    '            'tengo que recuperar el medico
    '            Dim medico_id As Integer = ds_historiaC.Tables(2).Rows(i).Item("medico_id")
    '            Dim j As Integer = 0
    '            While j < ds.Tables(0).Rows.Count
    '                If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
    '                    consultapsicologica("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
    '                    consultapsicologica("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
    '                    Exit While
    '                End If
    '                j = j + 1
    '            End While
    '            ds_reporte_historial.Tables("Consulta_Psicologica").Rows.Add(consultapsicologica)
    '            i = i + 1
    '        End While
    '    End If

    '    '//////////////////////////////////////////////////////////////////////////////////////////////////
    '    'ASISTENCIA SOCIAL
    '    If ds_historiaC.Tables(3).Rows.Count <> 0 Then
    '        'ahora lo recorro y cargo el ds
    '        Dim i As Integer = 0
    '        While i < ds_historiaC.Tables(3).Rows.Count
    '            Dim asistenciasocial As DataRow = ds_reporte_historial.Tables("Asistencia_Social").NewRow
    '            asistenciasocial("social_id") = ds_historiaC.Tables(3).Rows(i).Item("social_id")
    '            asistenciasocial("social_titulo") = ds_historiaC.Tables(3).Rows(i).Item("social_titulo")
    '            asistenciasocial("social_fecha") = ds_historiaC.Tables(3).Rows(i).Item("social_fecha")
    '            asistenciasocial("social_motivo") = ds_historiaC.Tables(3).Rows(i).Item("social_motivo")
    '            asistenciasocial("social_evaluacion") = ds_historiaC.Tables(3).Rows(i).Item("social_evaluacion")
    '            asistenciasocial("CLI_id") = ds_historiaC.Tables(3).Rows(i).Item("CLI_id")
    '            asistenciasocial("medico_id") = ds_historiaC.Tables(3).Rows(i).Item("medico_id")

    '            'tengo que recuperar el medico
    '            Dim medico_id As Integer = ds_historiaC.Tables(3).Rows(i).Item("medico_id")
    '            Dim j As Integer = 0
    '            While j < ds.Tables(0).Rows.Count
    '                If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
    '                    asistenciasocial("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
    '                    asistenciasocial("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
    '                    Exit While
    '                End If
    '                j = j + 1
    '            End While
    '            ds_reporte_historial.Tables("Asistencia_Social").Rows.Add(asistenciasocial)
    '            i = i + 1
    '        End While
    '    End If

    '    '/////////////////////////////////////////////////////////////////////
    '    'CONSULTA NUTRICIONAL
    '    If ds_historiaC.Tables(4).Rows.Count <> 0 Then
    '        'ahora lo recorro y cargo el ds
    '        Dim i As Integer = 0
    '        While i < ds_historiaC.Tables(4).Rows.Count
    '            Dim nutricional As DataRow = ds_reporte_historial.Tables("Consulta_Nutricional").NewRow
    '            nutricional("nutri_id") = ds_historiaC.Tables(4).Rows(i).Item("nutri_id")
    '            nutricional("nutri_titulo") = ds_historiaC.Tables(4).Rows(i).Item("nutri_titulo")
    '            nutricional("nutri_fecha") = ds_historiaC.Tables(4).Rows(i).Item("nutri_fecha")
    '            nutricional("nutri_motivo") = ds_historiaC.Tables(4).Rows(i).Item("nutri_motivo")
    '            nutricional("nutri_evaluacion") = ds_historiaC.Tables(4).Rows(i).Item("nutri_evaluacion")
    '            nutricional("nutri_estudios") = ds_historiaC.Tables(4).Rows(i).Item("nutri_estudios")
    '            nutricional("CLI_id") = ds_historiaC.Tables(4).Rows(i).Item("CLI_id")
    '            nutricional("medico_id") = ds_historiaC.Tables(4).Rows(i).Item("medico_id")

    '            'tengo que recuperar el medico
    '            Dim medico_id As Integer = ds_historiaC.Tables(4).Rows(i).Item("medico_id")
    '            Dim j As Integer = 0
    '            While j < ds.Tables(0).Rows.Count
    '                If ds.Tables(0).Rows(j).Item("medico_id") = medico_id Then
    '                    nutricional("medico") = ds.Tables(0).Rows(j).Item("medico_nombre")
    '                    nutricional("medico_matricula") = ds.Tables(0).Rows(j).Item("medico_matricula")
    '                    Exit While
    '                End If
    '                j = j + 1
    '            End While
    '            ds_reporte_historial.Tables("Consulta_Nutricional").Rows.Add(nutricional)
    '            i = i + 1
    '        End While
    '    End If

    '    '/////////////////////////configuracion para mostrar los resultados/////////////////////
    '    Dim config_fila As DataRow = ds_reporte_historial.Tables("configuracion").NewRow
    '    If ds_historiaC.Tables(1).Rows.Count <> 0 Then
    '        config_fila("cons_cli") = "tengo info"
    '    Else
    '        config_fila("cons_cli") = ""
    '    End If

    '    If ds_historiaC.Tables(2).Rows.Count <> 0 Then
    '        config_fila("cons_psico") = "tengo info"
    '    Else
    '        config_fila("cons_psico") = ""
    '    End If

    '    If ds_historiaC.Tables(3).Rows.Count <> 0 Then
    '        config_fila("asis_soc") = "tengo info"
    '    Else
    '        config_fila("asis_soc") = ""
    '    End If

    '    If ds_historiaC.Tables(4).Rows.Count <> 0 Then
    '        config_fila("cons_nutr") = "tengo info"
    '    Else
    '        config_fila("cons_nutr") = ""
    '    End If
    '    ds_reporte_historial.Tables("configuracion").Rows.Add(config_fila)

    '    'ahora creo el reporte
    '    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
    '    CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\EvaluacionMedica_CR.rpt")
    '    'CrReport.Load(Application.StartupPath & "\..\..\Modulos\Reportes_Dialisis\Evaluacion_medica_detalle.rpt")
    '    CrReport.Database.Tables("Empresa").SetDataSource(ds_reporte_historial.Tables("Empresa"))
    '    CrReport.Database.Tables("Cliente").SetDataSource(ds_reporte_historial.Tables("Cliente"))
    '    'la tabla "evaluacion medica" esta en el subinforme
    '    CrReport.Database.Tables("Evaluacion_Medica").SetDataSource(ds_reporte_historial.Tables("Evaluacion_Medica"))
    '    CrReport.Database.Tables("Consulta_Clinica").SetDataSource(ds_reporte_historial.Tables("Consulta_Clinica"))
    '    CrReport.Database.Tables("Consulta_Psicologica").SetDataSource(ds_reporte_historial.Tables("Consulta_Psicologica"))
    '    CrReport.Database.Tables("Asistencia_Social").SetDataSource(ds_reporte_historial.Tables("Asistencia_Social"))
    '    CrReport.Database.Tables("Consulta_Nutricional").SetDataSource(ds_reporte_historial.Tables("Consulta_Nutricional"))
    '    CrReport.Database.Tables("configuracion").SetDataSource(ds_reporte_historial.Tables("configuracion"))

    '    EvaluacionMedica_show.CrystalReportViewer1.ReportSource = CrReport


    '    EvaluacionMedica_show.Text = "Evaluacion Médica. Paciente: " + tb_nombre.Text + " - Imprimir."
    '    EvaluacionMedica_show.Show()


    'End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Dim ev_DN As String
    Dim ev_APP As String
    Dim ev_EF As String
    Dim ev_EP As String
    Dim ev_AF As String
    Dim ev_AEA As String
    Dim motivo_consulta As String

    Private Sub Button2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("¿Desea modificar la información de la evaluación médica?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            tx_ev_DN.ReadOnly = False
            tx_ev_APP.ReadOnly = False
            tx_ev_EF.ReadOnly = False

            tx_ev_EP.ReadOnly = False
            tx_ev_AF.ReadOnly = False
            tx_ev_AEA.ReadOnly = False

            tx_motivo_consulta.ReadOnly = False

            tx_ev_DN.BackColor = Color.White
            tx_ev_APP.BackColor = Color.White
            tx_ev_EF.BackColor = Color.White

            tx_ev_EP.BackColor = Color.White
            tx_ev_AF.BackColor = Color.White
            tx_ev_AEA.BackColor = Color.White

            tx_motivo_consulta.BackColor = Color.White


            'tambien voy a guardar el estado del contenido, x si decido cancelar x que me arrepiento
            ev_DN = tx_ev_DN.Text
            ev_APP = tx_ev_APP.Text
            ev_EF = tx_ev_EF.Text
            ev_EP = tx_ev_EP.Text
            ev_AF = tx_ev_AF.Text
            ev_AEA = tx_ev_AEA.Text
            motivo_consulta = tx_motivo_consulta.Text

            btn_ev_guardar.Enabled = True
            btn_ev_cancelar.Enabled = True
            Button2.Enabled = False


        End If
    End Sub
    Private Sub btn_ev_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ev_cancelar.Click
        limpiar_EvaMed()
        tx_ev_DN.ReadOnly = True
        tx_ev_APP.ReadOnly = True
        tx_ev_EF.ReadOnly = True

        tx_ev_EP.ReadOnly = True
        tx_ev_AF.ReadOnly = True
        tx_ev_AEA.ReadOnly = True

        tx_motivo_consulta.ReadOnly = True

        tx_ev_DN.BackColor = Color.Beige
        tx_ev_APP.BackColor = Color.Beige
        tx_ev_EF.BackColor = Color.Beige

        tx_ev_EP.BackColor = Color.Beige
        tx_ev_AF.BackColor = Color.Beige
        tx_ev_AEA.BackColor = Color.Beige

        tx_motivo_consulta.BackColor = Color.Beige

        'recupero info anterior

        tx_ev_DN.Text = ev_DN
        tx_ev_APP.Text = ev_APP
        tx_ev_EF.Text = ev_EF
        tx_ev_EP.Text = ev_EP
        tx_ev_AF.Text = ev_AF
        tx_ev_AEA.Text = ev_AEA
        tx_motivo_consulta.Text = motivo_consulta

        btn_ev_guardar.Enabled = False
        Button2.Enabled = True
        btn_ev_cancelar.Enabled = False

    End Sub

    Private Sub btn_ev_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ev_guardar.Click
        'hay 2 tipos, alta y modificacion, para ello valido.
        Dim ds_hist = DAHistoria.Consulta_antecedentes_validar(PAC_id)
        If ds_hist.Tables(0).Rows.Count <> 0 Then
            'como existe lo modifico
            Dim ConAnt_id As Integer = ds_hist.Tables(0).Rows(0).Item("ConAnt_id")
            DAHistoria.Consulta_antecedentes_modificar(ConAnt_id, Today, tx_ev_AEA.Text, tx_ev_APP.Text, tx_ev_AF.Text, tx_ev_EF.Text, tx_ev_DN.Text, tx_ev_EP.Text, PAC_id, cb_med_cc.SelectedValue, tx_motivo_consulta.Text)
            MessageBox.Show("Consulta modificada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            DAHistoria.Consulta_antecedentes_alta(Today, tx_ev_AEA.Text, tx_ev_APP.Text, tx_ev_AF.Text, tx_ev_EF.Text, tx_ev_DN.Text, tx_ev_EP.Text, PAC_id, cb_med_cc.SelectedValue, tx_motivo_consulta.Text)
            MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        btn_ev_cancelar.Enabled = False
        btn_ev_guardar.Enabled = False
        Button2.Enabled = True

        tx_ev_DN.BackColor = Color.Beige
        tx_ev_APP.BackColor = Color.Beige
        tx_ev_EF.BackColor = Color.Beige

        tx_ev_EP.BackColor = Color.Beige
        tx_ev_AF.BackColor = Color.Beige
        tx_ev_AEA.BackColor = Color.Beige

        tx_motivo_consulta.BackColor = Color.Beige


    End Sub

    Private Sub btn_modif_CC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modif_CC.Click
        If DG_CC.Rows.Count <> 0 Then
            'aqui habilito la edicion de los textbox y dejo modificar solo esos q indico.


            tx_cc_MC.ReadOnly = False
            tx_cc_EVA.ReadOnly = False
            tx_cc_MED.ReadOnly = False
            tx_cc_AC.ReadOnly = False
            tx_cc_EST.ReadOnly = False


            tx_cc_MC.BackColor = Color.White
            tx_cc_EVA.BackColor = Color.White
            tx_cc_MED.BackColor = Color.White
            tx_cc_AC.BackColor = Color.White
            tx_cc_EST.BackColor = Color.White

            DG_CC.Enabled = False 'bloqueo asi no se puede cambiar
            'Var_Boton = "Alta"
            var_boton_consultaclinica = "Modificar"

            btn_NC_CC.Enabled = False
            btn_modif_CC.Enabled = False
            btn_CC_Guardar.Enabled = True
            btn_hc.Enabled = True
            'cb_med_cc.Enabled = True


            'choco 11-09-2020
            cb_med_cc.Visible = False
            cb_med_cc.Visible = False
            cb_med_cc_activos.Visible = True
            cb_med_cc_activos.Enabled = True
        End If
    End Sub

    Private Sub btn_modif_CP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modif_CP.Click
        If DG_CP.Rows.Count <> 0 Then
            'aqui habilito la edicion de los textbox y dejo modificar solo esos q indico.

            tx_cp_MC.ReadOnly = False
            tx_cp_EV.ReadOnly = False
            tx_cp_MED.ReadOnly = False
            tx_cp_EST.ReadOnly = False

            tx_cp_MC.BackColor = Color.White
            tx_cp_EV.BackColor = Color.White
            tx_cp_MED.BackColor = Color.White
            tx_cp_EST.BackColor = Color.White

            DG_CP.Enabled = False 'bloqueo asi no se puede cambiar
            'Var_Boton = "Alta"
            var_boton_consultapsicologica = "Modificar"

            btn_NC_CP.Enabled = False
            btn_modif_CP.Enabled = False
            btn_CP_guardar.Enabled = True
            Button1.Enabled = True 'este es cancelar
            cb_med_cp.Enabled = True



            'choco 11-09-2020
            cb_med_cp.Visible = False
            cb_med_cp.Enabled = False
            cb_med_cp_activos.Visible = True
            cb_med_cp_activos.Enabled = True

        End If


    End Sub

    Private Sub btn_modif_AS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modif_AS.Click
        If dgv_AS.Rows.Count <> 0 Then
            'aqui habilito la edicion de los textbox y dejo modificar solo esos q indico.

            tx_as_MC.ReadOnly = False
            tx_as_EV.ReadOnly = False


            tx_as_MC.BackColor = Color.White
            tx_as_EV.BackColor = Color.White

            dgv_AS.Enabled = False  'bloqueo asi no se puede cambiar
            'Var_Boton = "Alta"
            var_boton_asistenciasocial = "Modificar"

            btn_NC_AS.Enabled = False
            btn_modif_AS.Enabled = False
            btn_AS_guardar.Enabled = True
            Button3.Enabled = True 'este es cancelar
            cb_med_AS.Enabled = True


            'choco 11-09-2020
            cb_med_AS.Visible = False
            cb_med_AS.Enabled = False
            cb_med_AS_activos.Visible = True
            cb_med_AS_activos.Enabled = True
        End If

    End Sub

    Private Sub btn_modif_CN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modif_CN.Click
        If DG_Nutri.Rows.Count <> 0 Then


            'aqui habilito la edicion de los textbox y dejo modificar solo esos q indico.

            tx_cn_MC.ReadOnly = False
            tx_cn_EV.ReadOnly = False
            tx_cn_EST.ReadOnly = False

            tx_cn_MC.BackColor = Color.White
            tx_cn_EV.BackColor = Color.White
            tx_cn_EST.BackColor = Color.White

            DG_Nutri.Enabled = False  'bloqueo asi no se puede cambiar
            'Var_Boton = "Alta"
            var_boton_consultanutricional = "Modificar"

            btn_NC_CN.Enabled = False
            btn_modif_CN.Enabled = False
            btn_CN_guardar.Enabled = True
            Button5.Enabled = True 'este es cancelar
            'cb_med_CN.Enabled = True


            'choco 11-09-2020
            cb_med_CN.Visible = False
            cb_med_CN.Enabled = False
            cb_med_CN_activos.Visible = True
            cb_med_CN_activos.Enabled = True
        End If
    End Sub

    

    

    Private Sub RadioButton_trns_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        radio = RadioButton_trns.Text
    End Sub

    Private Sub RadioButton_CatPerma_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        radio = RadioButton_CatPerma.Text
    End Sub

    Private Sub RadioButton_FAV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        radio = RadioButton_FAV.Text
    End Sub

    Private Sub RadioButton_Prot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        radio = RadioButton_Prot.Text
    End Sub

    Private Sub RadioButton_CatPeri_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        radio = RadioButton_CatPeri.Text
    End Sub
    Private Sub limpiarAccV()
        tb_ACCV_obs.Text = Nothing
        tb_ACCV_ubi.Text = Nothing
        DG_ACCV.Enabled = True
    End Sub
    Private Sub limpiarTras()
        tb_TRAS_CT.Text = Nothing
        tb_TRAS_est.Text = Nothing
        tb_TRAS_ev.Text = Nothing
        DG_Tras.Enabled = True
    End Sub






    

    Private Sub Btn_TRAS_mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_TRAS_mod.Click
        If DG_Tras.Rows.Count <> 0 Then
            tb_TRAS_CT.ReadOnly = False
            tb_TRAS_est.ReadOnly = False
            tb_TRAS_ev.ReadOnly = False


            tb_TRAS_CT.BackColor = Color.White
            tb_TRAS_est.BackColor = Color.White
            tb_TRAS_ev.BackColor = Color.White


            DG_Tras.Enabled = False  'bloqueo asi no se puede cambiar
            'Var_Boton = "Alta"
            var_boton_Trasp = "Modificar"

            btn_TRAS_nuevo.Enabled = False
            btn_ACCV_mod.Enabled = False
            btn_TRAS_guardar.Enabled = True
            btn_TRAS_cancelar.Enabled = True 'este es cancelar
            cb_TRAS_med.Enabled = True


            'choco 11-09-2020
            cb_TRAS_med.Visible = False
            cb_TRAS_med.Enabled = False
            cb_TRAS_med_activos.Visible = True
            cb_TRAS_med_activos.Enabled = True

        End If

    End Sub

    Private Sub btn_TRAS_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TRAS_nuevo.Click
        limpiarTras()

        tb_TRAS_CT.ReadOnly = False
        tb_TRAS_est.ReadOnly = False
        tb_TRAS_ev.ReadOnly = False

        tb_TRAS_CT.BackColor = Color.White
        tb_TRAS_est.BackColor = Color.White
        tb_TRAS_ev.BackColor = Color.White


        Dim cant = CInt(ds_historiaC.Tables("HistoriaC6").Rows.Count) + 1
        tb_TRAS_titulo.Text = "Informe " + CStr(cant)
        tb_TRAS_titulo.SelectAll()
        tb_TRAS_titulo.Focus()
        DG_Tras.Enabled = False
        Var_Boton = "Alta"
        var_boton_Trasp = "Alta"

        cb_TRAS_med.Enabled = True


        'choco 04-08-2020 - agrego el boton modificar: no se entiende sino la interaccion entre esos 3 botones nuevo, guardar y cancelar

        btn_TRAS_nuevo.Enabled = False
        Btn_TRAS_mod.Enabled = False
        btn_TRAS_guardar.Enabled = True
        btn_TRAS_cancelar.Enabled = True 'este es boton cancelar


        '/////choco 11-09-2020 oculto todos
        cb_TRAS_med.Visible = False
        cb_TRAS_med.Enabled = False
        cb_TRAS_med_activos.Visible = True
        cb_TRAS_med_activos.Enabled = True

        DateTime_TRAS.Value = Today
    End Sub

    Private Sub btn_TRAS_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TRAS_guardar.Click
        If var_boton_Trasp = "Alta" Then
            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea guardar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DAHistoria.Consulta_Trasplante_alta(tb_TRAS_titulo.Text, DateTime_TRAS.Text, cb_TRAS_med_activos.SelectedValue, PAC_id, DateTime_LE.Value, tb_TRAS_ev.Text, tb_TRAS_est.Text, tb_TRAS_CT.Text)
                var_boton_Trasp = "Modificar"
                DG_Tras.Enabled = True
                MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                limpiarTras()
                Obtener_grillas()

                '//////////////choco
                tb_TRAS_CT.ReadOnly = True
                tb_TRAS_ev.ReadOnly = True
                tb_TRAS_est.ReadOnly = True

                tb_TRAS_CT.BackColor = Color.Beige
                tb_TRAS_ev.BackColor = Color.Beige
                tb_TRAS_est.BackColor = Color.Beige

                btn_TRAS_nuevo.Enabled = True
                Btn_TRAS_mod.Enabled = True
                btn_TRAS_guardar.Enabled = False
                btn_TRAS_cancelar.Enabled = False
                cb_TRAS_med.Enabled = False
                '/////////////////////////////


                '////////////choco 11-09-2020 
                cb_TRAS_med.Visible = True
                cb_TRAS_med.Enabled = False
                cb_TRAS_med_activos.Visible = False
                cb_TRAS_med_activos.Enabled = False

            End If

        Else
            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea modificar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DAHistoria.Consulta_Trasplante_Modificar(tb_TRAS_titulo.Text, DateTime_TRAS.Text, cb_TRAS_med_activos.SelectedValue, PAC_id, DateTime_LE.Value, tb_TRAS_ev.Text, tb_TRAS_est.Text, tb_TRAS_CT.Text, DG_Tras.SelectedCells(0).Value)
                MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                limpiarTras()
                Obtener_grillas()
                DG_Tras.Enabled = True

                '//////////////choco
                tb_TRAS_CT.ReadOnly = True
                tb_TRAS_ev.ReadOnly = True
                tb_TRAS_est.ReadOnly = True

                tb_TRAS_CT.BackColor = Color.Beige
                tb_TRAS_ev.BackColor = Color.Beige
                tb_TRAS_est.BackColor = Color.Beige

                btn_TRAS_nuevo.Enabled = True
                Btn_TRAS_mod.Enabled = True
                btn_TRAS_guardar.Enabled = False
                btn_TRAS_cancelar.Enabled = False
                cb_TRAS_med.Enabled = False

                '/////////////////////////////


                '////////////choco 11-09-2020 
                cb_TRAS_med.Visible = True
                cb_TRAS_med.Enabled = False
                cb_TRAS_med_activos.Visible = False
                cb_TRAS_med_activos.Enabled = False

            End If
        End If
    End Sub

    Private Sub btn_TRAS_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TRAS_cancelar.Click
        limpiarTras()



        DG_Tras.Enabled = True
        DG_TRAS_Cambio_Seleccion()

        tb_TRAS_CT.ReadOnly = True
        tb_TRAS_est.ReadOnly = True
        tb_TRAS_ev.ReadOnly = True


        tb_TRAS_CT.BackColor = Color.Beige
        tb_TRAS_ev.BackColor = Color.Beige
        tb_TRAS_est.BackColor = Color.Beige

        btn_TRAS_nuevo.Enabled = True
        Btn_TRAS_mod.Enabled = True
        btn_TRAS_guardar.Enabled = False
        btn_TRAS_cancelar.Enabled = False
        'cb_TRAS_med.Enabled = False

        '////////choco 11-09-2020 
        cb_TRAS_med.Visible = True
        cb_TRAS_med.Enabled = False
        cb_TRAS_med_activos.Enabled = False
        cb_TRAS_med_activos.Visible = False

    End Sub

    Private Sub cb_TRAS_med_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_TRAS_med.SelectedIndexChanged
        If medicos = "si" Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds.Tables(0).Rows.Count
                If ds.Tables(0).Rows(i).Item("medico_id") = cb_TRAS_med.SelectedValue Then
                    tb_TRAS_nmat.Text = ds.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub DG_Tras_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Tras.SelectionChanged
        DG_TRAS_Cambio_Seleccion()
    End Sub

    




#Region "acceso vascular"
    Private Sub btn_ACCV_guardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ACCV_guardar.Click
        If var_boton_AccesoVascular = "Alta" Then
            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea guardar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                If RadioButton_trns.Checked = True Then
                    radio = RadioButton_trns.Text
                End If
                If RadioButton_CatPerma.Checked = True Then
                    radio = RadioButton_CatPerma.Text
                End If
                If RadioButton_FAV.Checked = True Then
                    radio = RadioButton_FAV.Text
                End If
                If RadioButton_Prot.Checked = True Then
                    radio = RadioButton_Prot.Text
                End If
                If RadioButton_CatPeri.Checked = True Then
                    radio = RadioButton_CatPeri.Text
                End If
                DAHistoria.Consulta_AccesoV_alta(tb_ACCV_Titulo.Text, DateTime_ACCV.Text, cb_ACCV_med_activos.SelectedValue, PAC_id, radio, DateTime_Confex.Value, DateTime_PU.Value, tb_ACCV_ubi.Text, tb_ACCV_obs.Text)
                var_boton_AccesoVascular = "Modificar"
                DG_ACCV.Enabled = True
                MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarAccV()
                Obtener_grillas()

                '//////////////choco
                tb_ACCV_obs.ReadOnly = True
                tb_ACCV_ubi.ReadOnly = True

                tb_ACCV_obs.BackColor = Color.Beige
                tb_ACCV_ubi.BackColor = Color.Beige

                btn_ACCV_nuevo.Enabled = True
                btn_ACCV_mod.Enabled = True
                btn_ACCV_guardar.Enabled = False
                btn_ACCV_cancelar.Enabled = False
                'cb_ACCV_med.Enabled = False
                '/////////////////////////////


                '////////////choco 11-09-2020 
                cb_ACCV_med.Visible = True
                cb_ACCV_med.Enabled = False
                cb_ACCV_med_activos.Visible = False
                cb_ACCV_med_activos.Enabled = False


            End If

        Else
            Dim result As Integer = MessageBox.Show("¿Esta seguro que desea modificar la información?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If RadioButton_trns.Checked = True Then
                    radio = RadioButton_trns.Text
                End If
                If RadioButton_CatPerma.Checked = True Then
                    radio = RadioButton_CatPerma.Text
                End If
                If RadioButton_FAV.Checked = True Then
                    radio = RadioButton_FAV.Text
                End If
                If RadioButton_Prot.Checked = True Then
                    radio = RadioButton_Prot.Text
                End If
                If RadioButton_CatPeri.Checked = True Then
                    radio = RadioButton_CatPeri.Text
                End If

                DAHistoria.Consulta_AccesoV_modificar(tb_ACCV_Titulo.Text, Today, cb_ACCV_med_activos.SelectedValue, PAC_id, radio, DateTime_Confex.Value, DateTime_PU.Value, tb_ACCV_ubi.Text, tb_ACCV_obs.Text, DG_ACCV.SelectedCells(0).Value)
                MessageBox.Show("Consulta Generada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                limpiarAccV()
                Obtener_grillas()
                DG_ACCV.Enabled = True

                '//////////////choco
                tb_ACCV_obs.ReadOnly = True
                tb_ACCV_ubi.ReadOnly = True

                tb_ACCV_obs.BackColor = Color.Beige
                tb_ACCV_ubi.BackColor = Color.Beige

                btn_ACCV_nuevo.Enabled = True
                btn_ACCV_mod.Enabled = True
                btn_ACCV_guardar.Enabled = False
                btn_ACCV_cancelar.Enabled = False
                cb_ACCV_med.Enabled = False

                '/////////////////////////////


                '////////////choco 11-09-2020 
                cb_ACCV_med.Visible = True
                cb_ACCV_med.Enabled = False
                cb_ACCV_med_activos.Visible = False
                cb_ACCV_med_activos.Enabled = False


            End If
        End If






    End Sub
    Private Sub btn_ACCV_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ACCV_cancelar.Click
        limpiarAccV()
        DG_ACCV.Enabled = True
        DG_ACCV_Cambio_Seleccion()
        tb_ACCV_ubi.ReadOnly = True
        tb_ACCV_obs.ReadOnly = True
        tb_ACCV_ubi.BackColor = Color.Beige
        tb_ACCV_obs.BackColor = Color.Beige
        btn_ACCV_nuevo.Enabled = True
        btn_ACCV_mod.Enabled = True
        btn_ACCV_guardar.Enabled = False
        btn_ACCV_cancelar.Enabled = False
        'cb_ACCV_med.Enabled = False


        '////////choco 11-09-2020 
        cb_ACCV_med.Visible = True
        cb_ACCV_med.Enabled = False
        cb_ACCV_med_activos.Enabled = False
        cb_ACCV_med_activos.Visible = False
    End Sub

    Private Sub btn_ACCV_nuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ACCV_nuevo.Click
        limpiarAccV()

        tb_ACCV_obs.ReadOnly = False
        tb_ACCV_ubi.ReadOnly = False

        tb_ACCV_obs.BackColor = Color.White
        tb_ACCV_ubi.BackColor = Color.White


        Dim cant = CInt(ds_historiaC.Tables("HistoriaC5").Rows.Count) + 1
        tb_ACCV_Titulo.Text = "Informe " + CStr(cant)
        tb_ACCV_Titulo.SelectAll()
        tb_ACCV_Titulo.Focus()
        DG_ACCV.Enabled = False
        Var_Boton = "Alta"
        var_boton_AccesoVascular = "Alta"

        cb_ACCV_med.Enabled = True


        'choco 04-08-2020 - agrego el boton modificar: no se entiende sino la interaccion entre esos 3 botones nuevo, guardar y cancelar

        btn_ACCV_nuevo.Enabled = False
        btn_ACCV_mod.Enabled = False
        btn_ACCV_guardar.Enabled = True
        btn_ACCV_cancelar.Enabled = True 'este es boton cancelar


        '/////choco 11-09-2020 oculto todos
        cb_ACCV_med.Visible = False
        cb_ACCV_med.Enabled = False
        cb_ACCV_med_activos.Visible = True
        cb_ACCV_med_activos.Enabled = True


        DateTime_ACCV.Value = Today
    End Sub
    Private Sub btn_ACCV_mod_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ACCV_mod.Click
        If DG_ACCV.Rows.Count <> 0 Then
            tb_ACCV_obs.ReadOnly = False
            tb_ACCV_ubi.ReadOnly = False


            tb_ACCV_obs.BackColor = Color.White
            tb_ACCV_ubi.BackColor = Color.White


            DG_ACCV.Enabled = False  'bloqueo asi no se puede cambiar
            'Var_Boton = "Alta"
            var_boton_consultanutricional = "Modificar"

            btn_ACCV_nuevo.Enabled = False
            btn_ACCV_mod.Enabled = False
            btn_ACCV_guardar.Enabled = True
            btn_ACCV_cancelar.Enabled = True 'este es cancelar
            'cb_ACCV_med.Enabled = True


            'choco 11-09-2020
            cb_ACCV_med.Visible = False
            cb_ACCV_med.Enabled = False
            cb_ACCV_med_activos.Visible = True
            cb_ACCV_med_activos.Enabled = True

        End If
    End Sub

    Private Sub cb_ACCV_med_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_ACCV_med.SelectedIndexChanged
        If medicos = "si" Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds.Tables(0).Rows.Count
                If ds.Tables(0).Rows(i).Item("medico_id") = cb_ACCV_med.SelectedValue Then
                    tb_ACCV_nmat.Text = ds.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub
    Private Sub DG_ACCV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ACCV.SelectionChanged
        DG_ACCV_Cambio_Seleccion()
    End Sub
#End Region


   
    Private Sub cb_med_cc_activos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_med_cc_activos.SelectedIndexChanged
        If medicos = "si" And cb_med_cc_activos.Visible = True Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds2.Tables(0).Rows.Count
                If ds2.Tables(0).Rows(i).Item("medico_id") = cb_med_cc_activos.SelectedValue Then
                    tx_Nmat_cc.Text = ds2.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub cb_ACCV_med_activos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_ACCV_med_activos.SelectedIndexChanged
        If medicos = "si" And cb_ACCV_med_activos.Visible = True Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds2.Tables(0).Rows.Count
                If ds2.Tables(0).Rows(i).Item("medico_id") = cb_ACCV_med_activos.SelectedValue Then
                    tb_ACCV_nmat.Text = ds2.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub cb_med_cp_activos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_med_cp_activos.SelectedIndexChanged
        If medicos = "si" And cb_med_cp_activos.Visible = True Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds2.Tables(0).Rows.Count
                If ds2.Tables(0).Rows(i).Item("medico_id") = cb_med_cp_activos.SelectedValue Then
                    tx_nmat_cp.Text = ds2.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub cb_med_AS_activos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_med_AS_activos.SelectedValueChanged
        If medicos = "si" And cb_med_AS_activos.Visible = True Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds2.Tables(0).Rows.Count
                If ds2.Tables(0).Rows(i).Item("medico_id") = cb_med_AS_activos.SelectedValue Then
                    tx_nmat_AS.Text = ds2.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub cb_med_CN_activos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_med_CN_activos.SelectedIndexChanged
        If medicos = "si" And cb_med_CN_activos.Visible = True Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds2.Tables(0).Rows.Count
                If ds2.Tables(0).Rows(i).Item("medico_id") = cb_med_CN_activos.SelectedValue Then
                    tx_nmat_CN.Text = ds2.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub cb_TRAS_med_activos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_TRAS_med_activos.SelectedIndexChanged
        If medicos = "si" And cb_TRAS_med_activos.Visible = True Then 'si recupere medicos hago lo siguiente
            Dim i As Integer = 0
            While i < ds2.Tables(0).Rows.Count
                If ds2.Tables(0).Rows(i).Item("medico_id") = cb_TRAS_med_activos.SelectedValue Then
                    tb_TRAS_nmat.Text = ds2.Tables(0).Rows(i).Item("medico_matricula")
                    Exit While
                End If
                i = i + 1
            End While
        End If
    End Sub

   
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Cliente_modificar.Show() 'lo muestro x que esta oculto 
        Me.Close()

    End Sub
End Class