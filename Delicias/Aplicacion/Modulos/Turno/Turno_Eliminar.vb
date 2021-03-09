Public Class Turno_Eliminar

    Dim DAturno As New Datos.Turno
    Dim DAcancha As New Datos.Cancha
    Dim DAcliente As New Datos.Cliente
    Dim NEturno As New Turno

    Dim ds_CANCHA_T As DataSet = DAcancha.CanchaTipo_obtener

    Private Sub Turno_Eliminar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NEturno.Turno_CrearTabla()

        DT_fecha.MinDate = Now

        COM_CANCHA_T.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T.ValueMember = "CANCHA_T_id"
        Cancha_obtener()

    End Sub

    Dim ds_CANCHA As DataSet
    Private Sub COM_CANCHA_T_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA_T.SelectedIndexChanged
        Cancha_obtener()
    End Sub

    Private Sub COM_CANCHA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA.SelectedIndexChanged
       
    End Sub

    Public Sub Cancha_obtener()
        ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString)
        COM_CANCHA.DataSource = ds_CANCHA.Tables(0)
        COM_CANCHA.DisplayMember = "CANCHA_nom"
        COM_CANCHA.ValueMember = "CANCHA_id"
    End Sub

    Dim TURNO_CONF_desde As String
    Dim TURNO_CONF_hasta As String

    

    Private Sub BO_buscar_Click(sender As System.Object, e As System.EventArgs) Handles BO_buscar.Click
        Turno_Buscar()
    End Sub

    Public Sub Turno_Buscar()
        Turno_Limpiar()
        NEturno.Turno_LimpiarTabla()

        Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString
        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(DT_fecha.Value, CANCHA_T_id)
        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString

        'DG_Turno
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_Obtener(DT_fecha.Text, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString,
                                                                 TURNO_CONF_desde, TURNO_CONF_hasta, DT_fecha.Text)

        If ds_Turno.Tables(0).Rows.Count > 0 Then
            'ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_Turno.DataSource = ds_Turno.Tables(0)
            DG_Turno.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)

            'DG_Turno TurnoFijo de Color
            Dim B As Integer = 0
            For Each row As DataGridViewRow In DG_Turno.Rows
                If row.Cells("TURNOTDataGridViewTextBoxColumn").Value = "Fijo" Then
                    DG_Turno.Rows(B).DefaultCellStyle.BackColor = Color.Gainsboro
                End If
                B = B + 1
            Next
            DG_Turno.ClearSelection()
            IM_ERROR.Visible = False
        Else
            IM_ERROR.Visible = True
        End If
    End Sub

    Private Sub DG_Turno_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Turno.SelectionChanged
        If ((DG_Turno.CurrentRow Is Nothing) OrElse (DG_Turno.SelectedRows.Count <> 0)) And DG_Turno.Rows.Count > 0 Then
            BO_Eliminar.Enabled = True

        Else

            BO_Eliminar.Enabled = False

        End If
    End Sub

    Public Sub Turno_Limpiar()
        DG_Turno.DataSource = Nothing
        'DT_fecha.Value = Now
        Turno_ds.Tables("TurnoDisponible").Clear()
    End Sub

    Private Sub BO_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Cancelar.Click
        Turno_Limpiar()
    End Sub

    Private Sub BO_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Eliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Eliminar el Turno Fijo?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim TURNO_F_id As String = DG_Turno.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn").Value.ToString

            DAturno.TurnoReservado_Eliminar(TURNO_F_id)

            Turno_Buscar()
            MessageBox.Show("El Turno fue Eliminado correctamente.", "Sistema de Gestion.")
        End If
    End Sub
End Class