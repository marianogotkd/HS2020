Public Class TurnoFijo_Modificar

    Dim DAturno As New Datos.Turno
    Dim DAcancha As New Datos.Cancha
    Dim DAcliente As New Datos.Cliente
    Dim NEturno As New Turno

    Dim ds_CANCHA_T As DataSet = DAcancha.CanchaTipo_obtener
    Dim ds_DIA As DataSet = DAturno.Dia_obtener

    Private Sub TurnoFijo_Modificar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        NEturno.Turno_CrearTabla()

        COM_dia.DataSource = ds_DIA.Tables(0)
        COM_dia.DisplayMember = "DIA_nom"
        COM_dia.ValueMember = "DIA_id"

        COM_CANCHA_T.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T.ValueMember = "CANCHA_T_id"

        Cancha_obtener()
    End Sub

    Private Sub COM_dia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_dia.SelectedIndexChanged
        'Cancha_obtener()
    End Sub

    'CANCHA ////////////////////////////////
    Dim ds_CANCHA As DataSet

    Private Sub COM_CANCHA_T_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA_T.SelectedIndexChanged
        Cancha_obtener()
    End Sub

    Private Sub COM_CANCHA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA.SelectedIndexChanged
        'Turno_buscar()
    End Sub

    Public Sub Cancha_obtener()
        ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString)
        COM_CANCHA.DataSource = ds_CANCHA.Tables(0)
        COM_CANCHA.DisplayMember = "CANCHA_nom"
        COM_CANCHA.ValueMember = "CANCHA_id"
    End Sub

    'BUSCAR /////////////////////////////

    Dim TURNO_CONF_desde As DateTime
    Dim TURNO_CONF_hasta As DateTime

    'Turno_Buscar
    Public Sub Turno_buscar()
        Turno_Limpiar()
        NEturno.Turno_LimpiarTabla()

        Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString
        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(Now, CANCHA_T_id)
        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString

        Dim ds_Turno As DataSet = DAturno.TurnoReservadoFijo_Obtener(ds_DIA.Tables(0).Rows(COM_dia.SelectedIndex).Item("DIA_id").ToString, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))

        If ds_Turno.Tables(0).Rows.Count > 0 Then
            NEturno.Turno_ConfHora(ds_Turno, 2)

            DG_Turno.DataSource = ds_Turno.Tables(0)
            DG_Turno.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)

            Dim B As Integer = 0
            For Each row As DataGridViewRow In DG_Turno.Rows
                If row.Cells("TURNOTDataGridViewTextBoxColumn").Value = "Fijo" Then
                    DG_Turno.Rows(B).DefaultCellStyle.BackColor = Color.Gainsboro
                End If
                B = B + 1
            Next
            IM_ERROR.Visible = False
        Else
            IM_ERROR.Visible = True
        End If

                DG_Turno.ClearSelection()
    End Sub

    'Turno_limpiar
    Public Sub Turno_Limpiar()
        DG_Turno.DataSource = Nothing

        Turno_ds.Tables("TurnoDisponible").Clear()

        DT_desde.Value = Now
        DT_hasta.Value = Now
    End Sub

    Private Sub BO_buscar_Click(sender As System.Object, e As System.EventArgs) Handles BO_buscar.Click
        Turno_buscar()
    End Sub

    Private Sub RB_DISP_Si_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_DISP_Si.CheckedChanged
        GP_Desde.Enabled = False
        GP_Hasta.Enabled = False
    End Sub

    Private Sub RB_DISP_No_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_DISP_No.CheckedChanged
        GP_Desde.Enabled = True
        GP_Hasta.Enabled = True
    End Sub

    Private Sub DG_Turno_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Turno.SelectionChanged
        If ((DG_Turno.CurrentRow Is Nothing) OrElse (DG_Turno.SelectedRows.Count <> 0)) And DG_Turno.Rows.Count > 0 Then
            BO_Eliminar.Enabled = True
            BO_guardar.Enabled = True

            GP_Estado.Enabled = True
            If DG_Turno.SelectedRows(0).Cells("TURNO_estado").Value = 1 Then
                RB_DISP_Si.Checked = True
                GP_Desde.Enabled = False
                GP_Hasta.Enabled = False
            Else
                Dim TURNO_F_id As String = DG_Turno.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn").Value.ToString
                Dim ds_Turno As DataSet = DAturno.TurnoReservadoFijoDisp_Obtener(TURNO_F_id)

                If ds_Turno.Tables(0).Rows.Count Then
                    DT_desde.Value = ds_Turno.Tables(0).Rows(0).Item("TURNO_T_NO_desde").ToString
                    DT_hasta.Value = ds_Turno.Tables(0).Rows(0).Item("TURNO_T_NO_hasta").ToString
                End If

                RB_DISP_No.Checked = True
                GP_Desde.Enabled = True
                GP_Hasta.Enabled = True
            End If


        Else
            BO_guardar.Enabled = False
            BO_Eliminar.Enabled = False

            GP_Estado.Enabled = False
            GP_Desde.Enabled = False
            GP_Hasta.Enabled = False
        End If
    End Sub


    Private Sub BO_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Eliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Eliminar el Turno Fijo?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim TURNO_F_id As String = DG_Turno.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn").Value.ToString

            DAturno.TurnoReservadoFijo_Eliminar(TURNO_F_id)

            Turno_buscar()
            MessageBox.Show("El Turno fue Eliminado correctamente.", "Sistema de Gestion.")
        End If
    End Sub

    Private Sub BO_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BO_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Actualizar el Turno Fijo?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim TURNO_F_id As String = DG_Turno.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn").Value.ToString

            If RB_DISP_Si.Checked = True Then
                DAturno.TurnoReservadoFijoDisp_Eliminar(TURNO_F_id)
                DAturno.TurnoReservadoFijo_ActualizarEstado(TURNO_F_id, 1)
            Else
                DAturno.TurnoReservadoFijoDisp_Eliminar(TURNO_F_id)
                DAturno.TurnoReservadoFijoDisp_Alta(TURNO_F_id, DT_desde.Value, DT_hasta.Value)
                DAturno.TurnoReservadoFijo_ActualizarEstado(TURNO_F_id, 5)
            End If

            Turno_Limpiar()
            Turno_buscar()
            MessageBox.Show("El Turno fue Actualizado correctamente.", "Sistema de Gestion.")
        End If
    End Sub

    Private Sub BO_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Cancelar.Click
        Turno_Limpiar()
    End Sub




End Class