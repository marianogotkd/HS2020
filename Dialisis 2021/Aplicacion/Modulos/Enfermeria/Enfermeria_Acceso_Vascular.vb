Public Class Enfermeria_Acceso_Vascular
    Dim DAmedico As New Datos.Medico
    Dim DAHistoria As New Datos.Historia_Clinica
    Public PAC_id As Integer
    Dim Var_Boton = "Alta"
    Dim var_boton_AccesoVascular = "Alta"
    Private Sub Enfermeria_Acceso_Vascular_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_medicos()
        DateTime_ACCV.Value = Today
        DateTime_Confex.Value = Today
        DateTime_PU.Value = Today
    End Sub
    Dim ds As DataSet
    Dim medicos As String = "no"
    Private Sub Obtener_medicos()
        ds = DAmedico.Medicos_Obtener_activos

        cb_ACCV_med.DataSource = ds.Tables(0)
        cb_ACCV_med.DisplayMember = "medico_nombre"
        cb_ACCV_med.ValueMember = "medico_id"
        tb_ACCV_nmat.Text = ds.Tables(0).Rows(0).Item("medico_matricula")


        If ds.Tables(0).Rows.Count <> 0 Then
            medicos = "si"
        End If

    End Sub
    Public ds_historiaC As DataSet
    Dim Historia_Clinica As New Historia_Clinica
    Private Sub Obtener_grillas()
        ds_historiaC = DAHistoria.Consulta_Obtener_Todos_Estudios_x_PAC(PAC_id)

        If ds_historiaC.Tables("HistoriaC5").Rows.Count <> 0 Then
            Historia_Clinica.Tables("Consulta_AccesoV").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Historia_Clinica.Tables("Consulta_AccesoV").Merge(ds_historiaC.Tables("HistoriaC5"))
        End If
        'grillas_listas = "si"

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

    Private Sub btn_ACCV_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ACCV_nuevo.Click
        limpiarAccV()

        tb_ACCV_obs.ReadOnly = False
        tb_ACCV_ubi.ReadOnly = False

        tb_ACCV_obs.BackColor = Color.White
        tb_ACCV_ubi.BackColor = Color.White


        'Dim cant = CInt(ds_historiaC.Tables("HistoriaC5").Rows.Count) + 1
        tb_ACCV_Titulo.Text = "Cambio de AV en Enfermeria"
        tb_ACCV_Titulo.SelectAll()
        tb_ACCV_Titulo.Focus()
        'DG_ACCV.Enabled = False


        Var_Boton = "Alta"
        var_boton_AccesoVascular = "Alta"
        cb_ACCV_med.Enabled = True


        'choco 04-08-2020 - agrego el boton modificar: no se entiende sino la interaccion entre esos 3 botones nuevo, guardar y cancelar

        btn_ACCV_nuevo.Enabled = False
        'btn_ACCV_mod.Enabled = False
        btn_ACCV_guardar.Enabled = True
        btn_ACCV_cancelar.Enabled = True 'este es boton cancelar
    End Sub

    Private Sub limpiarAccV()
        tb_ACCV_obs.Text = Nothing
        tb_ACCV_ubi.Text = Nothing
        DateTime_ACCV.Value = Today
        DateTime_Confex.Value = Today
        DateTime_PU.Value = Today

        'DG_ACCV.Enabled = True
    End Sub

    Private Sub btn_ACCV_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ACCV_guardar.Click
        Dim radio As String = ""
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
                DAHistoria.Consulta_AccesoV_alta(tb_ACCV_Titulo.Text, DateTime_ACCV.Text, cb_ACCV_med.SelectedValue, PAC_id, radio, DateTime_Confex.Value, DateTime_PU.Value, tb_ACCV_ubi.Text, tb_ACCV_obs.Text)
                var_boton_AccesoVascular = "Modificar"
                'DG_ACCV.Enabled = True
                MessageBox.Show("Datos guardados correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarAccV()
                Obtener_grillas()

                '//////////////choco
                tb_ACCV_obs.ReadOnly = True
                tb_ACCV_ubi.ReadOnly = True

                tb_ACCV_obs.BackColor = Color.Beige
                tb_ACCV_ubi.BackColor = Color.Beige

                btn_ACCV_nuevo.Enabled = True
                'btn_ACCV_mod.Enabled = True
                btn_ACCV_guardar.Enabled = False
                btn_ACCV_cancelar.Enabled = False
                cb_ACCV_med.Enabled = False
                '/////////////////////////////
                Nueva_Dialisis.Obtener_AV()

                Me.Close()




            End If
        End If





    End Sub

    Private Sub btn_ACCV_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ACCV_cancelar.Click
        limpiarAccV()
        'DG_ACCV.Enabled = True
        'DG_ACCV_Cambio_Seleccion()
        tb_ACCV_ubi.ReadOnly = True
        tb_ACCV_obs.ReadOnly = True
        tb_ACCV_ubi.BackColor = Color.Beige
        tb_ACCV_obs.BackColor = Color.Beige
        btn_ACCV_nuevo.Enabled = True
        'btn_ACCV_mod.Enabled = True
        btn_ACCV_guardar.Enabled = False
        btn_ACCV_cancelar.Enabled = False
        cb_ACCV_med.Enabled = False
    End Sub
End Class