Public Class Turno_Consulta

    Dim DAturno As New Datos.Turno
    Dim DAcancha As New Datos.Cancha
    Dim DAcliente As New Datos.Cliente
    Dim NEturno As New Turno

    Dim ds_CANCHA_T As DataSet = DAcancha.CanchaTipo_obtener

    Private Sub Turno_Consulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Turno_CrearTabla()

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

    '/////////////////////////////////////////////////////////////////////////////////

    Private Sub BO_buscar_Click(sender As System.Object, e As System.EventArgs) Handles BO_buscar.Click
        Turno_buscar()
    End Sub

    Dim Turnos As New DataSet

    Public Sub Turno_CrearTabla()
        Turnos.Tables.Add("TurnoDisp")
        Turnos.Tables("TurnoDisp").Columns.Add("TURNO_T")
        Turnos.Tables("TurnoDisp").Columns.Add("TURNO_fecha", GetType(DateTime))
        Turnos.Tables("TurnoDisp").Columns.Add("TURNO_cant")
        Turnos.Tables("TurnoDisp").Columns.Add("TURNO_hora")
        Turnos.Tables("TurnoDisp").Columns.Add("TURNO_fin")
    End Sub

    Public Sub Turno_LimpiarTabla()
        Turnos.Tables("TurnoDisp").Clear()
    End Sub

    Dim TURNO_CONF_desde As DateTime
    Dim TURNO_CONF_hasta As DateTime

    Public Sub Turno_buscar()
        Turno_LimpiarTabla()

        Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString
        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(DT_fecha.Value, CANCHA_T_id)
        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString

        Primero_cargar()
        Segundo_cargar()
        Tercero_cargar()
        Cuarto_cargar()
    End Sub

    'Primero ///////////////////////
    Public Sub Primero_cargar()
        Turno_LimpiarTabla()

        GP_Primero.Text = WeekdayName(Weekday(DT_fecha.Value.Date))

        If GP_Primero.Text = "domingo" Then
            GP_Primero.Text = "sábado" + " " + DT_fecha.Value.Date
        End If
        If GP_Primero.Text = "lunes" Then
            GP_Primero.Text = "domingo" + " " + DT_fecha.Value.Date
        End If
        If GP_Primero.Text = "martes" Then
            GP_Primero.Text = "lunes" + " " + DT_fecha.Value.Date
        End If
        If GP_Primero.Text = "miércoles" Then
            GP_Primero.Text = "martes" + " " + DT_fecha.Value.Date
        End If
        If GP_Primero.Text = "jueves" Then
            GP_Primero.Text = "miércoles" + " " + DT_fecha.Value.Date
        End If
        If GP_Primero.Text = "viernes" Then
            GP_Primero.Text = "jueves" + " " + DT_fecha.Value.Date
        End If
        If GP_Primero.Text = "sábado" Then
            GP_Primero.Text = "viernes" + " " + DT_fecha.Value.Date
        End If

        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Text, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))

        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_Primero.DataSource = ds_Turno.Tables(0)
            DG_Primero.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_Primero.Rows(0).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
            Dim Hora_inicio As DateTime = TURNO_CONF_desde
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.Date)

            'Turno Medio
            While B < DG_Primero.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Primero.Rows(B - 1).Cells("TURNOidDataGridViewTextBoxColumn").Value And
                       A.Item("TURNO_T") = DG_Primero.Rows(B - 1).Cells("TURNOTDataGridViewTextBoxColumn").Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Primero.Rows(B).Cells("TURNOidDataGridViewTextBoxColumn").Value And
                        A.Item("TURNO_T") = DG_Primero.Rows(B).Cells("TURNOTDataGridViewTextBoxColumn").Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_Primero.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_Primero.Rows(ultimo).Cells("TURNOfinDataGridViewTextBoxColumn").Value
            Dim Hora_fin As DateTime = TURNO_CONF_hasta
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_Primero.DataSource = ds_Turno.Tables(0)
            DG_Primero.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)
        Else
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde, TURNO_CONF_hasta, DT_fecha.Value.Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_Primero.DataSource = ds_Turno.Tables(0)
            DG_Primero.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)
        End If

        B = 0
        For Each row As DataGridViewRow In DG_Primero.Rows
            Select Case (row.Cells("TURNOTDataGridViewTextBoxColumn").Value)
                Case ("Normal")
                    DG_Primero.Rows(B).DefaultCellStyle.BackColor = Color.AliceBlue
                Case ("Fijo")
                    DG_Primero.Rows(B).DefaultCellStyle.BackColor = Color.Gainsboro
                Case ("Disp")
                    DG_Primero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_Primero.ClearSelection()
    End Sub

    'Segundo ///////////////////////
    Public Sub Segundo_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(1)

        GP_Segundo.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(1)))
        If GP_Segundo.Text = "domingo" Then
            GP_Segundo.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_Segundo.Text = "lunes" Then
            GP_Segundo.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_Segundo.Text = "martes" Then
            GP_Segundo.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_Segundo.Text = "miércoles" Then
            GP_Segundo.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_Segundo.Text = "jueves" Then
            GP_Segundo.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_Segundo.Text = "viernes" Then
            GP_Segundo.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_Segundo.Text = "sábado" Then
            GP_Segundo.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If

        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(1).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))
        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_Segundo.DataSource = ds_Turno.Tables(0)
            DG_Segundo.Sort(TURNOfechaDataGridViewTextBoxColumn1, System.ComponentModel.ListSortDirection.Ascending)

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_Segundo.Rows(0).Cells("TURNOhoraDataGridViewTextBoxColumn1").Value
            Dim Hora_inicio As DateTime = TURNO_CONF_desde
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(1).Date)

            'Turno Medio
            While B < DG_Segundo.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Segundo.Rows(B - 1).Cells("TURNOidDataGridViewTextBoxColumn1").Value And
                       A.Item("TURNO_T") = DG_Segundo.Rows(B - 1).Cells("TURNOTDataGridViewTextBoxColumn1").Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Segundo.Rows(B).Cells("TURNOidDataGridViewTextBoxColumn1").Value And
                        A.Item("TURNO_T") = DG_Segundo.Rows(B).Cells("TURNOTDataGridViewTextBoxColumn1").Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(1).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_Segundo.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_Segundo.Rows(ultimo).Cells("TURNOfinDataGridViewTextBoxColumn1").Value
            Dim Hora_fin As DateTime = TURNO_CONF_hasta
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(1).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_Segundo.DataSource = ds_Turno.Tables(0)
            DG_Segundo.Sort(TURNOfechaDataGridViewTextBoxColumn1, System.ComponentModel.ListSortDirection.Ascending)
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde, TURNO_CONF_hasta, DT_fecha.Value.AddDays(1).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_Segundo.DataSource = ds_Turno.Tables(0)
            DG_Segundo.Sort(TURNOfechaDataGridViewTextBoxColumn1, System.ComponentModel.ListSortDirection.Ascending)
        End If

        B = 0
        For Each row As DataGridViewRow In DG_Segundo.Rows
            Select Case (row.Cells("TURNOTDataGridViewTextBoxColumn1").Value)
                Case ("Normal")
                    DG_Segundo.Rows(B).DefaultCellStyle.BackColor = Color.AliceBlue
                Case ("Fijo")
                    DG_Segundo.Rows(B).DefaultCellStyle.BackColor = Color.Gainsboro
                Case ("Disp")
                    DG_Segundo.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_Segundo.ClearSelection()
    End Sub

    Dim fecha_dia2 As Date
    Dim fecha_dia3 As Date
    'Tercero ///////////////////////
    Public Sub Tercero_cargar()
        Turno_LimpiarTabla()
        'fecha_dia3 = fecha_dia2.AddDays(1) 'en realidad se suman 2, pero ya viene 1 del valor otorgado por el procedimiento segundo_cargar

        GP_Tercero.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(2)))
        If GP_Tercero.Text = "domingo" Then
            GP_Tercero.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_Tercero.Text = "lunes" Then
            GP_Tercero.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_Tercero.Text = "martes" Then
            GP_Tercero.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_Tercero.Text = "miércoles" Then
            GP_Tercero.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_Tercero.Text = "jueves" Then
            GP_Tercero.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_Tercero.Text = "viernes" Then
            GP_Tercero.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_Tercero.Text = "sábado" Then
            GP_Tercero.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If


        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(2).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))

        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_Tercero.DataSource = ds_Turno.Tables(0)
            DG_Tercero.Sort(TURNOfechaDataGridViewTextBoxColumn2, System.ComponentModel.ListSortDirection.Ascending)

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_Tercero.Rows(0).Cells("TURNOhoraDataGridViewTextBoxColumn2").Value
            Dim Hora_inicio As DateTime = TURNO_CONF_desde
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(2).Date)

            'Turno Medio
            While B < DG_Tercero.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Tercero.Rows(B - 1).Cells("TURNOidDataGridViewTextBoxColumn2").Value And
                       A.Item("TURNO_T") = DG_Tercero.Rows(B - 1).Cells("TURNOTDataGridViewTextBoxColumn2").Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Tercero.Rows(B).Cells("TURNOidDataGridViewTextBoxColumn2").Value And
                        A.Item("TURNO_T") = DG_Tercero.Rows(B).Cells("TURNOTDataGridViewTextBoxColumn2").Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(2).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_Tercero.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_Tercero.Rows(ultimo).Cells("TURNOfinDataGridViewTextBoxColumn2").Value
            Dim Hora_fin As DateTime = TURNO_CONF_hasta
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(2).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_Tercero.DataSource = ds_Turno.Tables(0)
            DG_Tercero.Sort(TURNOfechaDataGridViewTextBoxColumn2, System.ComponentModel.ListSortDirection.Ascending)
        Else
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde, TURNO_CONF_hasta, DT_fecha.Value.AddDays(2).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_Tercero.DataSource = ds_Turno.Tables(0)
            DG_Tercero.Sort(TURNOfechaDataGridViewTextBoxColumn2, System.ComponentModel.ListSortDirection.Ascending)
        End If

        B = 0
        For Each row As DataGridViewRow In DG_Tercero.Rows
            Select Case (row.Cells("TURNOTDataGridViewTextBoxColumn2").Value)
                Case ("Normal")
                    DG_Tercero.Rows(B).DefaultCellStyle.BackColor = Color.AliceBlue
                Case ("Fijo")
                    DG_Tercero.Rows(B).DefaultCellStyle.BackColor = Color.Gainsboro
                Case ("Disp")
                    DG_Tercero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_Tercero.ClearSelection()
    End Sub

    'Cuarto ///////////////////////
    Public Sub Cuarto_cargar()
        Turno_LimpiarTabla()
        'Dim fecha As Date = fecha_dia3.AddDays(1)
        GP_Cuarto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(3)))
        If GP_Cuarto.Text = "domingo" Then
            GP_Cuarto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_Cuarto.Text = "lunes" Then
            GP_Cuarto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_Cuarto.Text = "martes" Then
            GP_Cuarto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_Cuarto.Text = "miércoles" Then
            GP_Cuarto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_Cuarto.Text = "jueves" Then
            GP_Cuarto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_Cuarto.Text = "viernes" Then
            GP_Cuarto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_Cuarto.Text = "sábado" Then
            GP_Cuarto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If

        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(3).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))

        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_Cuarto.DataSource = ds_Turno.Tables(0)
            DG_Cuarto.Sort(TURNOfechaDataGridViewTextBoxColumn3, System.ComponentModel.ListSortDirection.Ascending)

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_Cuarto.Rows(0).Cells("TURNOhoraDataGridViewTextBoxColumn3").Value
            Dim Hora_inicio As DateTime = TURNO_CONF_desde
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(3).Date)

            'Turno Medio
            While B < DG_Cuarto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Cuarto.Rows(B - 1).Cells("TURNOidDataGridViewTextBoxColumn3").Value And
                       A.Item("TURNO_T") = DG_Cuarto.Rows(B - 1).Cells("TURNOTDataGridViewTextBoxColumn3").Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Cuarto.Rows(B).Cells("TURNOidDataGridViewTextBoxColumn3").Value And
                        A.Item("TURNO_T") = DG_Cuarto.Rows(B).Cells("TURNOTDataGridViewTextBoxColumn3").Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(3).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_Cuarto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_Cuarto.Rows(ultimo).Cells("TURNOfinDataGridViewTextBoxColumn3").Value
            Dim Hora_fin As DateTime = TURNO_CONF_hasta
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(3).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_Cuarto.DataSource = ds_Turno.Tables(0)
            DG_Cuarto.Sort(TURNOfechaDataGridViewTextBoxColumn3, System.ComponentModel.ListSortDirection.Ascending)
        Else
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde, TURNO_CONF_hasta, DT_fecha.Value.AddDays(3).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_Cuarto.DataSource = ds_Turno.Tables(0)
            DG_Cuarto.Sort(TURNOfechaDataGridViewTextBoxColumn3, System.ComponentModel.ListSortDirection.Ascending)
        End If

        B = 0
        For Each row As DataGridViewRow In DG_Cuarto.Rows
            Select Case (row.Cells("TURNOTDataGridViewTextBoxColumn3").Value)
                Case ("Normal")
                    DG_Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.AliceBlue
                Case ("Fijo")
                    DG_Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.Gainsboro
                Case ("Disp")
                    DG_Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_Cuarto.ClearSelection()
    End Sub

    '//////////////////////////////
    Public Sub Turno_ConfTurnoDisponible(ByVal desde_hora As DateTime, ByVal hasta_Hora As DateTime, ByVal Fecha As DateTime)

        Dim DISP_desde As DateTime = "00:00"
        DISP_desde = DISP_desde.AddHours(desde_hora.Hour)
        DISP_desde = DISP_desde.AddMinutes(desde_hora.Minute)

        Dim DISP_hasta As DateTime = "00:00"
        DISP_hasta = DISP_hasta.AddHours(hasta_Hora.Hour)
        DISP_hasta = DISP_hasta.AddMinutes(hasta_Hora.Minute)

        Dim DISP As Integer

        DISP = DateDiff(DateInterval.Minute, DISP_desde, DISP_hasta)

        If DISP < 0 Then
            DISP = (24 * 60) + DISP
        End If

        Dim newCustomers As Data.DataRow
        newCustomers = Turnos.Tables("TurnoDisp").NewRow
        newCustomers("TURNO_T") = "Disp"

        If DISP >= 15 Then
            If DISP_desde.ToString("HH:mm") < TURNO_CONF_desde Then
                Fecha = Fecha.AddDays(1)
            End If
            Fecha = Fecha.AddHours(DISP_desde.ToString("HH"))
            Fecha = Fecha.AddMinutes(DISP_desde.ToString("mm"))

            newCustomers("TURNO_fecha") = Fecha
            newCustomers("TURNO_hora") = DISP_desde.ToString("HH:mm")
            newCustomers("TURNO_fin") = DISP_hasta.ToString("HH:mm")

            Dim duracion As DateTime = "00:00"
            Dim AHora As Integer = Int(DISP / 60)
            Dim Aminuto As Integer = DISP - (AHora * 60)
            duracion = duracion.AddHours(AHora)
            duracion = duracion.AddMinutes(Aminuto)

            newCustomers("TURNO_cant") = duracion.ToString("HH:mm")
            Turnos.Tables("TurnoDisp").Rows.Add(newCustomers)
        End If
    End Sub

    
End Class