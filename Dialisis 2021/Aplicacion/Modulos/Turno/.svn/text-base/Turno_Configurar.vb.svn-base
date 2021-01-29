Public Class Turno_Configurar

    Dim DAturno As New Datos.Turno
    Dim DAcancha As New Datos.Cancha

    Dim ds_CANCHA_T As DataSet = DAcancha.CanchaTipo_obtener

    Private Sub Turno_Configurar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        DT_fecha.Focus()

        NU_Inicio_hora.TextAlign = HorizontalAlignment.Center
        NU_Inicio_hora.Maximum = 23
        NU_Inicio_hora.Minimum = 0
        NU_Inicio_minuto.TextAlign = HorizontalAlignment.Center
        NU_Inicio_minuto.Maximum = 59
        NU_Inicio_minuto.Minimum = 0

        NU_fin_hora.TextAlign = HorizontalAlignment.Center
        NU_fin_hora.Maximum = 23
        NU_fin_hora.Minimum = 0
        NU_fin_minuto.TextAlign = HorizontalAlignment.Center
        NU_fin_minuto.Maximum = 59
        NU_fin_minuto.Minimum = 0

        COM_CANCHA_T.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T.ValueMember = "CANCHA_T_id"

        TX_CONF_precio.TextAlign = HorizontalAlignment.Center
        Verificar()
    End Sub

    Private Sub DT_fecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DT_fecha.ValueChanged
        Verificar()
    End Sub

    Private Sub NU_Inicio_hora_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_Inicio_hora.ValueChanged
        Verificar()
    End Sub

    Private Sub NU_Inicio_minuto_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_Inicio_minuto.ValueChanged
        Verificar()
    End Sub

    Private Sub NU_fin_hora_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_fin_hora.ValueChanged
        Verificar()
    End Sub

    Private Sub NU_fin_minuto_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_fin_minuto.ValueChanged
        Verificar()
    End Sub

    Public Sub Verificar()
        Dim CONF_fecha As DateTime = DT_fecha.Value.Date
        CONF_fecha = CONF_fecha.AddHours(NU_Inicio_hora.Value)
        CONF_fecha = CONF_fecha.AddMinutes(NU_fin_minuto.Value)
        Dim ds_CONF As DataSet = DAturno.TurnoConfiguracion_verificar(CONF_fecha)

        With ds_CONF.Tables(0).Rows
            If .Count > 0 Then
                LB_ERROR.Visible = True
                IM_ERROR.Visible = True
                BO_guardar.Enabled = False
                DataGridView1.DataSource = ds_CONF.Tables(1)
            Else
                If ds_CANCHA_T.Tables(0).Rows.Count = DG_CanchaPrecio.Rows.Count Then
                    LB_ERROR.Visible = False
                    IM_ERROR.Visible = False
                    BO_guardar.Enabled = True
                Else
                    LB_ERROR.Visible = False
                    IM_ERROR.Visible = False
                    BO_guardar.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub BO_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BO_guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta la Configuracion del Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim CONF_inicio As String = NU_Inicio_hora.Text + ":" + NU_Inicio_minuto.Text
            Dim CONF_fin As String = NU_fin_hora.Text + ":" + NU_fin_minuto.Text

            Dim CONF_fecha As DateTime = DT_fecha.Value.Date
            CONF_fecha = CONF_fecha.AddHours(NU_Inicio_hora.Value)
            CONF_fecha = CONF_fecha.AddMinutes(NU_fin_minuto.Value)

            Dim ds_Configuracion As DataSet = DAturno.TurnoConfiguracion_alta(CONF_fecha, CONF_inicio, CONF_fin)

            For Each row As DataGridViewRow In DG_CanchaPrecio.Rows
                DAturno.TurnoConfiguracionCancha_alta(ds_Configuracion.Tables(0).Rows(0).Item("TURNO_CONF_id").ToString,
                                                      row.Cells("CANCHATidDataGridViewTextBoxColumn").Value, row.Cells("TURNOCONFprecioDataGridViewTextBoxColumn").Value)
            Next

            Limpiar()
            MessageBox.Show("La Configuracion del Turno fue dada de alta correctamente.", "Sistema de Gestion.")
        End If
    End Sub

    Public Sub Limpiar()
        DT_fecha.Value = Now
        NU_Inicio_hora.Value = 0
        NU_Inicio_minuto.Value = 0
        NU_fin_hora.Value = 0
        NU_fin_minuto.Value = 0
        TX_CONF_precio.Text = Nothing

        DG_CanchaPrecio.DataSource = Nothing
        Turno_ds.Tables("CanchaPrecio").Clear()
        TX_CONF_precio.Text = Nothing

        Verificar()
        Me.Show()
        DT_fecha.Focus()
    End Sub

    Private Sub BO_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Eliminar.Click
        Limpiar()
    End Sub

    '/////////////////////////////////

    Private Sub TX_CONF_precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_CONF_precio.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not TX_CONF_precio.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TX_CONF_precio_TextChanged(sender As System.Object, e As System.EventArgs) Handles TX_CONF_precio.TextChanged
        Verificar_Cancha()
    End Sub

    Private Sub COM_CANCHA_T_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA_T.SelectedIndexChanged
        Verificar_Cancha()
    End Sub

    Private Sub BO_Agregar_Click(sender As System.Object, e As System.EventArgs) Handles BO_Agregar.Click

        Dim newCustomers As Data.DataRow
        newCustomers = Turno_ds.Tables("CanchaPrecio").NewRow
        newCustomers("CANCHA_T_id") = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString
        newCustomers("CANCHA_T_nom") = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_nom").ToString
        newCustomers("TURNO_CONF_precio") = TX_CONF_precio.Text
        Turno_ds.Tables("CanchaPrecio").Rows.Add(newCustomers)

        TX_CONF_precio.Text = Nothing

        DG_CanchaPrecio.DataSource = Turno_ds.Tables("CanchaPrecio")
        DG_CanchaPrecio.ClearSelection()
    End Sub

    Public Sub Verificar_Cancha()
        Dim B As Integer = 0

        For Each row As DataGridViewRow In DG_CanchaPrecio.Rows
            If row.Cells("CANCHATidDataGridViewTextBoxColumn").Value = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString Then
                B = 1
            End If
        Next

        If B = 0 And TX_CONF_precio.Text <> Nothing Then
            BO_Agregar.Enabled = True
        Else
            BO_Agregar.Enabled = False
        End If

        Verificar()
    End Sub


End Class