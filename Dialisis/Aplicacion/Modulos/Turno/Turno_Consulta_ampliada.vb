Public Class Turno_Consulta_ampliada
    Dim DAturno As New Datos.Turno
    Dim DAcancha As New Datos.Cancha
    Dim DAcliente As New Datos.Cliente
    Dim NEturno As New Turno

    Dim ds_CANCHA_T As DataSet = DAcancha.CanchaTipo_obtener

    Private Sub Turno_Consulta_ampliada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'poner previamente la propiedad del form...keypreview = true

        If e.KeyCode = Keys.F5 Then 'F5

            DT_fecha.Value = Now
            Turno_buscar()

        End If

    End Sub


    Private Sub Turno_Consulta_ampliada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Turno_CrearTabla()

        DT_fecha.MinDate = Now

        COM_CANCHA_T.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T.ValueMember = "CANCHA_T_id"
        Cancha_obtener()



        COM_CANCHA_T.SelectedValue = ds_CANCHA_T.Tables(0).Rows(0).Item("CANCHA_T_id")


    End Sub

    Dim ds_CANCHA As DataSet

    Private Sub COM_CANCHA_T_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles COM_CANCHA_T.SelectedIndexChanged
        Cancha_obtener()
    End Sub

    Public Sub Cancha_obtener()
        ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString)
        COM_CANCHA.DataSource = ds_CANCHA.Tables(0)
        COM_CANCHA.DisplayMember = "CANCHA_nom"
        COM_CANCHA.ValueMember = "CANCHA_id"
    End Sub

    '/////////////////////////////////////////////////////////////////////////////////

    Private Sub BO_buscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BO_buscar.Click
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
    Dim TURNO_CONF_desde2 As DateTime
    Dim TURNO_CONF_hasta2 As DateTime
    Dim TURNO_CONF_desde3 As DateTime
    Dim TURNO_CONF_hasta3 As DateTime
    Dim TURNO_CONF_desde4 As DateTime
    Dim TURNO_CONF_hasta4 As DateTime

    Public Sub Turno_buscar()
        Turno_LimpiarTabla()

        If COM_CANCHA_T.SelectedValue = "1" Then
            Me.TabControl1.SelectedTab = TabPage1

            Dim CANCHA_T_id As Integer = 1 'choco
            ' Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString   'nico
            Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(DT_fecha.Value, CANCHA_T_id)
            TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
            TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString
            'para la cancha 1
            Primero_cargar()
            Segundo_cargar()
            Tercero_cargar()
            Cuarto_cargar()
            Quinto_cargar()
            sexto_cargar()
            septimo_cargar()


            'para la CANCHA 2

            Dim CANCHA_T_id2 As Integer = 1 'choco
            ' Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString   'nico
            Dim ds_TurnoConfiguracion2 As DataSet = DAturno.TurnoConfiguracion_obtener(DT_fecha.Value, CANCHA_T_id2)
            TURNO_CONF_desde2 = ds_TurnoConfiguracion2.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
            TURNO_CONF_hasta2 = ds_TurnoConfiguracion2.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString

            Cancha2_Primero_cargar()
            Cancha2_Segundo_cargar()
            Cancha2_Tercero_cargar()
            Cancha2_Cuarto_cargar()
            Cancha2_Quinto_cargar()
            Cancha2_Sexto_cargar()
            Cancha2_Septimo_cargar()
        Else

            'para la CANCHA 3
            Me.TabControl1.SelectedTab = TabPage2
            Dim CANCHA_T_id3 As Integer = 2 'choco
            ' Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString   'nico
            Dim ds_TurnoConfiguracion3 As DataSet = DAturno.TurnoConfiguracion_obtener(DT_fecha.Value, CANCHA_T_id3)
            TURNO_CONF_desde3 = ds_TurnoConfiguracion3.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
            TURNO_CONF_hasta3 = ds_TurnoConfiguracion3.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString

            Cancha3_Primero_cargar()
            Cancha3_Segundo_cargar()
            Cancha3_Tercero_cargar()
            Cancha3_Cuarto_cargar()
            Cancha3_Quinto_cargar()
            Cancha3_Sexto_cargar()
            Cancha3_Septimo_cargar()


            'para la CANCHA 4

            Dim CANCHA_T_id4 As Integer = 2 'choco
            ' Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString   'nico
            Dim ds_TurnoConfiguracion4 As DataSet = DAturno.TurnoConfiguracion_obtener(DT_fecha.Value, CANCHA_T_id4)
            TURNO_CONF_desde4 = ds_TurnoConfiguracion4.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
            TURNO_CONF_hasta4 = ds_TurnoConfiguracion4.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString

            Cancha4_Primero_cargar()
            Cancha4_Segundo_cargar()
            Cancha4_Tercero_cargar()
            Cancha4_Cuarto_cargar()
            Cancha4_Quinto_cargar()
            Cancha4_Sexto_cargar()
            Cancha4_Septimo_cargar()

        End If


    End Sub

#Region "CANCHA 1"
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
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Text, "1", TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))  'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Text, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))  'nico


        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim contador As Integer = ds_Turno.Tables(1).Rows.Count '----prueba



        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_Primero.DataSource = ds_Turno.Tables(0)
            Dim contador2 As Integer = DG_Primero.Rows.Count 'prueba 2----trae los turnos sin intervalos libres
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
                    DG_Primero.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_Primero.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_Primero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_Primero.ClearSelection()


        Dim indice = 1
        While indice < DG_Primero.Rows.Count

            Dim cliente As String = DG_Primero.Rows(indice).Cells(1).Value

            If CStr(DG_Primero.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_Primero.Rows(indice).Cells(5).Value) = CStr(DG_Primero.Rows(indice - 1).Cells(5).Value) Then

                DG_Primero.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While







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
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(1).Date, "1", TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'choco



        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While


        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(1).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico
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
                    DG_Segundo.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_Segundo.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_Segundo.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_Segundo.ClearSelection()




        Dim indice = 1
        While indice < DG_Segundo.Rows.Count

            Dim cliente As String = DG_Segundo.Rows(indice).Cells(1).Value

            If CStr(DG_Segundo.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_Segundo.Rows(indice).Cells(5).Value) = CStr(DG_Segundo.Rows(indice - 1).Cells(5).Value) Then

                DG_Segundo.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While






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

        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(2).Date, "1", TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(2).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While


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
                    DG_Tercero.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue 
                Case ("Fijo")
                    DG_Tercero.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_Tercero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_Tercero.ClearSelection()


        Dim indice = 1
        While indice < DG_Tercero.Rows.Count

            Dim cliente As String = DG_Tercero.Rows(indice).Cells(1).Value

            If CStr(DG_Tercero.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_Tercero.Rows(indice).Cells(5).Value) = CStr(DG_Tercero.Rows(indice - 1).Cells(5).Value) Then

                DG_Tercero.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While


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
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(3).Date, "1", TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(3).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico


        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

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
                    DG_Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_Cuarto.ClearSelection()

        Dim indice = 1
        While indice < DG_Cuarto.Rows.Count

            Dim cliente As String = DG_Cuarto.Rows(indice).Cells(1).Value

            If CStr(DG_Cuarto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_Cuarto.Rows(indice).Cells(5).Value) = CStr(DG_Cuarto.Rows(indice - 1).Cells(5).Value) Then

                DG_Cuarto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
    'Quinto //////////////////////
    Public Sub Quinto_cargar()
        Turno_LimpiarTabla()
        'Dim fecha As Date = fecha_dia3.AddDays(1)
        GP_quinto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(4)))
        If GP_quinto.Text = "domingo" Then
            GP_quinto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_quinto.Text = "lunes" Then
            GP_quinto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_quinto.Text = "martes" Then
            GP_quinto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_quinto.Text = "miércoles" Then
            GP_quinto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_quinto.Text = "jueves" Then
            GP_quinto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_quinto.Text = "viernes" Then
            GP_quinto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_quinto.Text = "sábado" Then
            GP_quinto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(4).Date, "1", TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(4).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_quinto.DataSource = ds_Turno.Tables(0)
            'DG_quinto.Sort(TURNOfechaDataGridViewTextBoxColumn3, System.ComponentModel.ListSortDirection.Ascending)
            DG_quinto.Sort(DataGridViewTextBoxColumn16, System.ComponentModel.ListSortDirection.Ascending)

            B = 1

            'Turno Primero
            'Dim Primer_Hora As DateTime = DG_quinto.Rows(0).Cells("TURNOhoraDataGridViewTextBoxColumn3").Value
            Dim Primer_Hora As DateTime = DG_quinto.Rows(0).Cells(5).Value
            Dim Hora_inicio As DateTime = TURNO_CONF_desde
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(4).Date)

            'Turno Medio
            While B < DG_quinto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    'If A.Item("TURNO_id") = DG_quinto.Rows(B - 1).Cells("TURNOidDataGridViewTextBoxColumn3").Value And
                    If A.Item("TURNO_id") = DG_quinto.Rows(B - 1).Cells(0).Value And
                                                A.Item("TURNO_T") = DG_quinto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_quinto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_quinto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(4).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_quinto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_quinto.Rows(ultimo).Cells(6).Value
            Dim Hora_fin As DateTime = TURNO_CONF_hasta
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(4).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_quinto.DataSource = ds_Turno.Tables(0)
            DG_quinto.Sort(DataGridViewTextBoxColumn16, System.ComponentModel.ListSortDirection.Ascending)
        Else
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde, TURNO_CONF_hasta, DT_fecha.Value.AddDays(4).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_quinto.DataSource = ds_Turno.Tables(0)
            DG_quinto.Sort(DataGridViewTextBoxColumn16, System.ComponentModel.ListSortDirection.Ascending)
        End If

        B = 0
        For Each row As DataGridViewRow In DG_quinto.Rows
            Select Case (row.Cells(1).Value)
                Case ("Normal")
                    DG_quinto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_quinto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_quinto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_quinto.ClearSelection()

        Dim indice = 1
        While indice < DG_quinto.Rows.Count

            Dim cliente As String = DG_quinto.Rows(indice).Cells(1).Value

            If CStr(DG_quinto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_quinto.Rows(indice).Cells(5).Value) = CStr(DG_quinto.Rows(indice - 1).Cells(5).Value) Then

                DG_quinto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While


    End Sub
    'Sexto //////////////////////
    Public Sub sexto_cargar()
        Turno_LimpiarTabla()
        'Dim fecha As Date = fecha_dia3.AddDays(1)
        GP_sexto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(5)))
        If GP_sexto.Text = "domingo" Then
            GP_sexto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_sexto.Text = "lunes" Then
            GP_sexto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_sexto.Text = "martes" Then
            GP_sexto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_sexto.Text = "miércoles" Then
            GP_sexto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_sexto.Text = "jueves" Then
            GP_sexto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_sexto.Text = "viernes" Then
            GP_sexto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_sexto.Text = "sábado" Then
            GP_sexto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(5).Date, "1", TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(5).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_sexto.DataSource = ds_Turno.Tables(0)
            'DG_sexto.Sort(TURNOfechaDataGridViewTextBoxColumn3, System.ComponentModel.ListSortDirection.Ascending)
            DG_sexto.Sort(DataGridViewTextBoxColumn27, System.ComponentModel.ListSortDirection.Ascending)

            B = 1

            'Turno Primero
            'Dim Primer_Hora As DateTime = DG_sexto.Rows(0).Cells("TURNOhoraDataGridViewTextBoxColumn3").Value
            Dim Primer_Hora As DateTime = DG_sexto.Rows(0).Cells(5).Value
            Dim Hora_inicio As DateTime = TURNO_CONF_desde
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(5).Date)

            'Turno Medio
            While B < DG_sexto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    'If A.Item("TURNO_id") = DG_sexto.Rows(B - 1).Cells("TURNOidDataGridViewTextBoxColumn3").Value And
                    If A.Item("TURNO_id") = DG_sexto.Rows(B - 1).Cells(0).Value And
                                                A.Item("TURNO_T") = DG_sexto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_sexto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_sexto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(5).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_sexto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_sexto.Rows(ultimo).Cells(6).Value
            Dim Hora_fin As DateTime = TURNO_CONF_hasta
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(5).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_sexto.DataSource = ds_Turno.Tables(0)
            DG_sexto.Sort(DataGridViewTextBoxColumn27, System.ComponentModel.ListSortDirection.Ascending) 'turno_fecha
        Else
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde, TURNO_CONF_hasta, DT_fecha.Value.AddDays(5).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_sexto.DataSource = ds_Turno.Tables(0)
            DG_sexto.Sort(DataGridViewTextBoxColumn27, System.ComponentModel.ListSortDirection.Ascending) 'turno_fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_sexto.Rows
            Select Case (row.Cells(1).Value)
                Case ("Normal")
                    DG_sexto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_sexto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_sexto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_sexto.ClearSelection()

        Dim indice = 1
        While indice < DG_sexto.Rows.Count
            Dim cliente As String = DG_sexto.Rows(indice).Cells(1).Value
            If CStr(DG_sexto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_sexto.Rows(indice).Cells(5).Value) = CStr(DG_sexto.Rows(indice - 1).Cells(5).Value) Then
                DG_sexto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
    'Septimo //////////////////////
    Public Sub septimo_cargar()
        Turno_LimpiarTabla()
        'Dim fecha As Date = fecha_dia3.AddDays(1)
        GP_septimo.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(6)))
        If GP_septimo.Text = "domingo" Then
            GP_septimo.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_septimo.Text = "lunes" Then
            GP_septimo.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_septimo.Text = "martes" Then
            GP_septimo.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_septimo.Text = "miércoles" Then
            GP_septimo.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_septimo.Text = "jueves" Then
            GP_septimo.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_septimo.Text = "viernes" Then
            GP_septimo.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_septimo.Text = "sábado" Then
            GP_septimo.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(6).Date, "1", TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.AddDays(6).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_septimo.DataSource = ds_Turno.Tables(0)
            'DG_septimo.Sort(TURNOfechaDataGridViewTextBoxColumn3, System.ComponentModel.ListSortDirection.Ascending)
            DG_septimo.Sort(DataGridViewTextBoxColumn38, System.ComponentModel.ListSortDirection.Ascending) 'turno_fecha

            B = 1

            'Turno Primero
            'Dim Primer_Hora As DateTime = DG_septimo.Rows(0).Cells("TURNOhoraDataGridViewTextBoxColumn3").Value
            Dim Primer_Hora As DateTime = DG_septimo.Rows(0).Cells(5).Value
            Dim Hora_inicio As DateTime = TURNO_CONF_desde
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(6).Date)

            'Turno Medio
            While B < DG_septimo.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    'If A.Item("TURNO_id") = DG_septimo.Rows(B - 1).Cells("TURNOidDataGridViewTextBoxColumn3").Value And
                    If A.Item("TURNO_id") = DG_septimo.Rows(B - 1).Cells(0).Value And
                                                A.Item("TURNO_T") = DG_septimo.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_septimo.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_septimo.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(6).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_septimo.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_septimo.Rows(ultimo).Cells(6).Value
            Dim Hora_fin As DateTime = TURNO_CONF_hasta
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(6).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_septimo.DataSource = ds_Turno.Tables(0)
            DG_septimo.Sort(DataGridViewTextBoxColumn38, System.ComponentModel.ListSortDirection.Ascending) 'turno_fecha
        Else
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde, TURNO_CONF_hasta, DT_fecha.Value.AddDays(6).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_septimo.DataSource = ds_Turno.Tables(0)
            DG_septimo.Sort(DataGridViewTextBoxColumn38, System.ComponentModel.ListSortDirection.Ascending) 'turno_fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_septimo.Rows
            Select Case (row.Cells(1).Value)
                Case ("Normal")
                    DG_septimo.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_septimo.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_septimo.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_septimo.ClearSelection()

        Dim indice = 1
        While indice < DG_septimo.Rows.Count
            Dim cliente As String = DG_septimo.Rows(indice).Cells(1).Value
            If CStr(DG_septimo.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_septimo.Rows(indice).Cells(5).Value) = CStr(DG_septimo.Rows(indice - 1).Cells(5).Value) Then
                DG_septimo.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While


    End Sub
#End Region

#Region "CANCHA 2"
    'CANCHA 2 - PRIMERO /////////////////////
    Public Sub Cancha2_Primero_cargar()
        Turno_LimpiarTabla()

        GP_C2Primero.Text = WeekdayName(Weekday(DT_fecha.Value.Date))

        If GP_C2Primero.Text = "domingo" Then
            GP_C2Primero.Text = "sábado" + " " + DT_fecha.Value.Date
        End If
        If GP_C2Primero.Text = "lunes" Then
            GP_C2Primero.Text = "domingo" + " " + DT_fecha.Value.Date
        End If
        If GP_C2Primero.Text = "martes" Then
            GP_C2Primero.Text = "lunes" + " " + DT_fecha.Value.Date
        End If
        If GP_C2Primero.Text = "miércoles" Then
            GP_C2Primero.Text = "martes" + " " + DT_fecha.Value.Date
        End If
        If GP_C2Primero.Text = "jueves" Then
            GP_C2Primero.Text = "miércoles" + " " + DT_fecha.Value.Date
        End If
        If GP_C2Primero.Text = "viernes" Then
            GP_C2Primero.Text = "jueves" + " " + DT_fecha.Value.Date
        End If
        If GP_C2Primero.Text = "sábado" Then
            GP_C2Primero.Text = "viernes" + " " + DT_fecha.Value.Date
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Text, "2", TURNO_CONF_desde2.ToString("HH:mm"), TURNO_CONF_hasta2.ToString("HH:mm"))  'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Text, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))  'nico


        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While
        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C2Primero.DataSource = ds_Turno.Tables(0)
            DG_C2Primero.Sort(DataGridViewTextBoxColumn104, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C2Primero.Rows(0).Cells(5).Value 'TURNO HORA
            Dim Hora_inicio As DateTime = TURNO_CONF_desde2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.Date)

            'Turno Medio
            While B < DG_C2Primero.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Primero.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C2Primero.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Primero.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C2Primero.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C2Primero.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C2Primero.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Primero.DataSource = ds_Turno.Tables(0)
            DG_C2Primero.Sort(DataGridViewTextBoxColumn104, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde2, TURNO_CONF_hasta2, DT_fecha.Value.Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Primero.DataSource = ds_Turno.Tables(0)
            DG_C2Primero.Sort(DataGridViewTextBoxColumn104, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C2Primero.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C2Primero.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C2Primero.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C2Primero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C2Primero.ClearSelection()



        Dim indice = 1
        While indice < DG_C2Primero.Rows.Count
            Dim cliente As String = DG_C2Primero.Rows(indice).Cells(1).Value
            If CStr(DG_C2Primero.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C2Primero.Rows(indice).Cells(5).Value) = CStr(DG_C2Primero.Rows(indice - 1).Cells(5).Value) Then
                DG_C2Primero.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
    'CANCHA 2 - SEGUNDO /////////////////////
    Public Sub Cancha2_Segundo_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(1)

        GP_C2Segundo.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(1)))
        If GP_C2Segundo.Text = "domingo" Then
            GP_C2Segundo.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C2Segundo.Text = "lunes" Then
            GP_C2Segundo.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C2Segundo.Text = "martes" Then
            GP_C2Segundo.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C2Segundo.Text = "miércoles" Then
            GP_C2Segundo.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C2Segundo.Text = "jueves" Then
            GP_C2Segundo.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C2Segundo.Text = "viernes" Then
            GP_C2Segundo.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C2Segundo.Text = "sábado" Then
            GP_C2Segundo.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(1).Date, "2", TURNO_CONF_desde2.ToString("HH:mm"), TURNO_CONF_hasta2.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(1).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C2Segundo.DataSource = ds_Turno.Tables(0)
            DG_C2Segundo.Sort(DataGridViewTextBoxColumn93, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C2Segundo.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(1).Date)

            'Turno Medio
            While B < DG_C2Segundo.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Segundo.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C2Segundo.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Segundo.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C2Segundo.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(1).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C2Segundo.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C2Segundo.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(1).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Segundo.DataSource = ds_Turno.Tables(0)
            DG_C2Segundo.Sort(DataGridViewTextBoxColumn93, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde2, TURNO_CONF_hasta2, DT_fecha.Value.AddDays(1).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Segundo.DataSource = ds_Turno.Tables(0)
            DG_C2Segundo.Sort(DataGridViewTextBoxColumn93, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C2Segundo.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C2Segundo.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C2Segundo.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C2Segundo.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C2Segundo.ClearSelection()

        Dim indice = 1
        While indice < DG_C2Segundo.Rows.Count
            Dim cliente As String = DG_C2Segundo.Rows(indice).Cells(1).Value
            If CStr(DG_C2Segundo.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C2Segundo.Rows(indice).Cells(5).Value) = CStr(DG_C2Segundo.Rows(indice - 1).Cells(5).Value) Then
                DG_C2Segundo.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
    'CANCHA 2 - TERCERO /////////////////////
    Public Sub Cancha2_Tercero_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(2)

        GP_C2Tercero.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(2)))
        If GP_C2Tercero.Text = "domingo" Then
            GP_C2Tercero.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C2Tercero.Text = "lunes" Then
            GP_C2Tercero.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C2Tercero.Text = "martes" Then
            GP_C2Tercero.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C2Tercero.Text = "miércoles" Then
            GP_C2Tercero.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C2Tercero.Text = "jueves" Then
            GP_C2Tercero.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C2Tercero.Text = "viernes" Then
            GP_C2Tercero.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C2Tercero.Text = "sábado" Then
            GP_C2Tercero.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(2).Date, "2", TURNO_CONF_desde2.ToString("HH:mm"), TURNO_CONF_hasta2.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(2).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico
        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C2Tercero.DataSource = ds_Turno.Tables(0)
            DG_C2Tercero.Sort(DataGridViewTextBoxColumn82, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C2Tercero.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(2).Date)

            'Turno Medio
            While B < DG_C2Tercero.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Tercero.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C2Tercero.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Tercero.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C2Tercero.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(2).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C2Tercero.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C2Tercero.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(2).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Tercero.DataSource = ds_Turno.Tables(0)
            DG_C2Tercero.Sort(DataGridViewTextBoxColumn82, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(2)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde2, TURNO_CONF_hasta2, DT_fecha.Value.AddDays(2).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Tercero.DataSource = ds_Turno.Tables(0)
            DG_C2Tercero.Sort(DataGridViewTextBoxColumn82, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C2Tercero.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C2Tercero.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C2Tercero.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C2Tercero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C2Tercero.ClearSelection()

        Dim indice = 1
        While indice < DG_C2Tercero.Rows.Count
            Dim cliente As String = DG_C2Tercero.Rows(indice).Cells(1).Value
            If CStr(DG_C2Tercero.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C2Tercero.Rows(indice).Cells(5).Value) = CStr(DG_C2Tercero.Rows(indice - 1).Cells(5).Value) Then
                DG_C2Tercero.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 2 - CUARTO /////////////////////
    Public Sub Cancha2_Cuarto_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(3)

        GP_C2Cuarto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(3)))
        If GP_C2Cuarto.Text = "domingo" Then
            GP_C2Cuarto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C2Cuarto.Text = "lunes" Then
            GP_C2Cuarto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C2Cuarto.Text = "martes" Then
            GP_C2Cuarto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C2Cuarto.Text = "miércoles" Then
            GP_C2Cuarto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C2Cuarto.Text = "jueves" Then
            GP_C2Cuarto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C2Cuarto.Text = "viernes" Then
            GP_C2Cuarto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C2Cuarto.Text = "sábado" Then
            GP_C2Cuarto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(3).Date, "2", TURNO_CONF_desde2.ToString("HH:mm"), TURNO_CONF_hasta2.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(3).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico
        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C2Cuarto.DataSource = ds_Turno.Tables(0)
            DG_C2Cuarto.Sort(DataGridViewTextBoxColumn71, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C2Cuarto.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(3).Date)

            'Turno Medio
            While B < DG_C2Cuarto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Cuarto.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C2Cuarto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Cuarto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C2Cuarto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(3).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C2Cuarto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C2Cuarto.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(3).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Cuarto.DataSource = ds_Turno.Tables(0)
            DG_C2Cuarto.Sort(DataGridViewTextBoxColumn71, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(3)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde2, TURNO_CONF_hasta2, DT_fecha.Value.AddDays(3).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Cuarto.DataSource = ds_Turno.Tables(0)
            DG_C2Cuarto.Sort(DataGridViewTextBoxColumn71, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C2Cuarto.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C2Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C2Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C2Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C2Cuarto.ClearSelection()


        Dim indice = 1
        While indice < DG_C2Cuarto.Rows.Count
            Dim cliente As String = DG_C2Cuarto.Rows(indice).Cells(1).Value
            If CStr(DG_C2Cuarto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C2Cuarto.Rows(indice).Cells(5).Value) = CStr(DG_C2Cuarto.Rows(indice - 1).Cells(5).Value) Then
                DG_C2Cuarto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 2 - QUINTO /////////////////////
    Public Sub Cancha2_Quinto_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(4)

        GP_C2Quinto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(4)))
        If GP_C2Quinto.Text = "domingo" Then
            GP_C2Quinto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C2Quinto.Text = "lunes" Then
            GP_C2Quinto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C2Quinto.Text = "martes" Then
            GP_C2Quinto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C2Quinto.Text = "miércoles" Then
            GP_C2Quinto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C2Quinto.Text = "jueves" Then
            GP_C2Quinto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C2Quinto.Text = "viernes" Then
            GP_C2Quinto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C2Quinto.Text = "sábado" Then
            GP_C2Quinto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(4).Date, "2", TURNO_CONF_desde2.ToString("HH:mm"), TURNO_CONF_hasta2.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(4).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C2Quinto.DataSource = ds_Turno.Tables(0)
            DG_C2Quinto.Sort(DataGridViewTextBoxColumn60, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha


            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C2Quinto.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(4).Date)

            'Turno Medio
            While B < DG_C2Quinto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Quinto.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C2Quinto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Quinto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C2Quinto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(4).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C2Quinto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C2Quinto.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(4).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Quinto.DataSource = ds_Turno.Tables(0)
            DG_C2Quinto.Sort(DataGridViewTextBoxColumn60, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(4)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde2, TURNO_CONF_hasta2, DT_fecha.Value.AddDays(4).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Quinto.DataSource = ds_Turno.Tables(0)
            DG_C2Quinto.Sort(DataGridViewTextBoxColumn60, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C2Quinto.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C2Quinto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C2Quinto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C2Quinto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C2Quinto.ClearSelection()

        Dim indice = 1
        While indice < DG_C2Quinto.Rows.Count
            Dim cliente As String = DG_C2Quinto.Rows(indice).Cells(1).Value
            If CStr(DG_C2Quinto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C2Quinto.Rows(indice).Cells(5).Value) = CStr(DG_C2Quinto.Rows(indice - 1).Cells(5).Value) Then
                DG_C2Quinto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 2 - SEXTO /////////////////////
    Public Sub Cancha2_Sexto_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(5)

        GP_C2Sexto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(5)))
        If GP_C2Sexto.Text = "domingo" Then
            GP_C2Sexto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C2Sexto.Text = "lunes" Then
            GP_C2Sexto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C2Sexto.Text = "martes" Then
            GP_C2Sexto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C2Sexto.Text = "miércoles" Then
            GP_C2Sexto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C2Sexto.Text = "jueves" Then
            GP_C2Sexto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C2Sexto.Text = "viernes" Then
            GP_C2Sexto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C2Sexto.Text = "sábado" Then
            GP_C2Sexto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(5).Date, "2", TURNO_CONF_desde2.ToString("HH:mm"), TURNO_CONF_hasta2.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(5).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico
        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While


        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C2Sexto.DataSource = ds_Turno.Tables(0)
            DG_C2Sexto.Sort(DataGridViewTextBoxColumn49, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha



            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C2Sexto.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(5).Date)

            'Turno Medio
            While B < DG_C2Sexto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Sexto.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C2Sexto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Sexto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C2Sexto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(5).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C2Sexto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C2Sexto.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(5).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Sexto.DataSource = ds_Turno.Tables(0)
            DG_C2Sexto.Sort(DataGridViewTextBoxColumn49, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(5)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde2, TURNO_CONF_hasta2, DT_fecha.Value.AddDays(5).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Sexto.DataSource = ds_Turno.Tables(0)
            DG_C2Sexto.Sort(DataGridViewTextBoxColumn49, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C2Sexto.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C2Sexto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C2Sexto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C2Sexto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C2Sexto.ClearSelection()

        Dim indice = 1
        While indice < DG_C2Sexto.Rows.Count
            Dim cliente As String = DG_C2Sexto.Rows(indice).Cells(1).Value
            If CStr(DG_C2Sexto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C2Sexto.Rows(indice).Cells(5).Value) = CStr(DG_C2Sexto.Rows(indice - 1).Cells(5).Value) Then
                DG_C2Sexto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 2 - SEPTIMO /////////////////////
    Public Sub Cancha2_Septimo_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(6)

        GP_C2Septimo.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(6)))
        If GP_C2Septimo.Text = "domingo" Then
            GP_C2Septimo.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C2Septimo.Text = "lunes" Then
            GP_C2Septimo.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C2Septimo.Text = "martes" Then
            GP_C2Septimo.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C2Septimo.Text = "miércoles" Then
            GP_C2Septimo.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C2Septimo.Text = "jueves" Then
            GP_C2Septimo.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C2Septimo.Text = "viernes" Then
            GP_C2Septimo.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C2Septimo.Text = "sábado" Then
            GP_C2Septimo.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(6).Date, "2", TURNO_CONF_desde2.ToString("HH:mm"), TURNO_CONF_hasta2.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(6).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico
        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While


        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C2Septimo.DataSource = ds_Turno.Tables(0)
            DG_C2Septimo.Sort(DataGridViewTextBoxColumn5, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha

            

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C2Septimo.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(6).Date)

            'Turno Medio
            While B < DG_C2Septimo.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Septimo.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C2Septimo.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C2Septimo.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C2Septimo.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(6).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C2Septimo.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C2Septimo.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta2
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(6).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Septimo.DataSource = ds_Turno.Tables(0)
            DG_C2Septimo.Sort(DataGridViewTextBoxColumn5, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(6)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde2, TURNO_CONF_hasta2, DT_fecha.Value.AddDays(6).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C2Septimo.DataSource = ds_Turno.Tables(0)
            DG_C2Septimo.Sort(DataGridViewTextBoxColumn5, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C2Septimo.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C2Septimo.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C2Septimo.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C2Septimo.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C2Septimo.ClearSelection()

        Dim indice = 1
        While indice < DG_C2Septimo.Rows.Count
            Dim cliente As String = DG_C2Septimo.Rows(indice).Cells(1).Value
            If CStr(DG_C2Septimo.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C2Septimo.Rows(indice).Cells(5).Value) = CStr(DG_C2Septimo.Rows(indice - 1).Cells(5).Value) Then
                DG_C2Septimo.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
#End Region

#Region "CANCHA 3"
    'CANCHA 3 - PRIMERO /////////////////////
    Public Sub Cancha3_Primero_cargar()
        Turno_LimpiarTabla()

        GP_C3Primero.Text = WeekdayName(Weekday(DT_fecha.Value.Date))

        If GP_C3Primero.Text = "domingo" Then
            GP_C3Primero.Text = "sábado" + " " + DT_fecha.Value.Date
        End If
        If GP_C3Primero.Text = "lunes" Then
            GP_C3Primero.Text = "domingo" + " " + DT_fecha.Value.Date
        End If
        If GP_C3Primero.Text = "martes" Then
            GP_C3Primero.Text = "lunes" + " " + DT_fecha.Value.Date
        End If
        If GP_C3Primero.Text = "miércoles" Then
            GP_C3Primero.Text = "martes" + " " + DT_fecha.Value.Date
        End If
        If GP_C3Primero.Text = "jueves" Then
            GP_C3Primero.Text = "miércoles" + " " + DT_fecha.Value.Date
        End If
        If GP_C3Primero.Text = "viernes" Then
            GP_C3Primero.Text = "jueves" + " " + DT_fecha.Value.Date
        End If
        If GP_C3Primero.Text = "sábado" Then
            GP_C3Primero.Text = "viernes" + " " + DT_fecha.Value.Date
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Text, "3", TURNO_CONF_desde3.ToString("HH:mm"), TURNO_CONF_hasta3.ToString("HH:mm"))  'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Text, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))  'nico
        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While
        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C3Primero.DataSource = ds_Turno.Tables(0)
            DG_C3Primero.Sort(TURNOfechaDataGridViewTextBoxColumn4, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha



            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C3Primero.Rows(0).Cells(5).Value 'TURNO HORA
            Dim Hora_inicio As DateTime = TURNO_CONF_desde3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.Date)

            'Turno Medio
            While B < DG_C3Primero.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Primero.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C3Primero.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Primero.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C3Primero.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C3Primero.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C3Primero.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Primero.DataSource = ds_Turno.Tables(0)
            DG_C3Primero.Sort(TURNOfechaDataGridViewTextBoxColumn4, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde3, TURNO_CONF_hasta3, DT_fecha.Value.Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Primero.DataSource = ds_Turno.Tables(0)
            DG_C3Primero.Sort(TURNOfechaDataGridViewTextBoxColumn4, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C3Primero.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C3Primero.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C3Primero.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C3Primero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C3Primero.ClearSelection()

        Dim indice = 1
        While indice < DG_C3Primero.Rows.Count
            Dim cliente As String = DG_C3Primero.Rows(indice).Cells(1).Value
            If CStr(DG_C3Primero.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C3Primero.Rows(indice).Cells(5).Value) = CStr(DG_C3Primero.Rows(indice - 1).Cells(5).Value) Then
                DG_C3Primero.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
    'CANCHA 3 - SEGUNDO /////////////////////
    Public Sub Cancha3_Segundo_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(1)

        GP_C3Segundo.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(1)))
        If GP_C3Segundo.Text = "domingo" Then
            GP_C3Segundo.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C3Segundo.Text = "lunes" Then
            GP_C3Segundo.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C3Segundo.Text = "martes" Then
            GP_C3Segundo.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C3Segundo.Text = "miércoles" Then
            GP_C3Segundo.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C3Segundo.Text = "jueves" Then
            GP_C3Segundo.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C3Segundo.Text = "viernes" Then
            GP_C3Segundo.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C3Segundo.Text = "sábado" Then
            GP_C3Segundo.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(1).Date, "3", TURNO_CONF_desde3.ToString("HH:mm"), TURNO_CONF_hasta3.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(1).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico
        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C3Segundo.DataSource = ds_Turno.Tables(0)
            DG_C3Segundo.Sort(DataGridViewTextBoxColumn137, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha




            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C3Segundo.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(1).Date)

            'Turno Medio
            While B < DG_C3Segundo.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Segundo.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C3Segundo.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Segundo.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C3Segundo.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(1).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C3Segundo.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C3Segundo.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(1).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Segundo.DataSource = ds_Turno.Tables(0)
            DG_C3Segundo.Sort(DataGridViewTextBoxColumn137, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde3, TURNO_CONF_hasta3, DT_fecha.Value.AddDays(1).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Segundo.DataSource = ds_Turno.Tables(0)
            DG_C3Segundo.Sort(DataGridViewTextBoxColumn137, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C3Segundo.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C3Segundo.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C3Segundo.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C3Segundo.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C3Segundo.ClearSelection()


        Dim indice = 1
        While indice < DG_C3Segundo.Rows.Count
            Dim cliente As String = DG_C3Segundo.Rows(indice).Cells(1).Value
            If CStr(DG_C3Segundo.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C3Segundo.Rows(indice).Cells(5).Value) = CStr(DG_C3Segundo.Rows(indice - 1).Cells(5).Value) Then
                DG_C3Segundo.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
    'CANCHA 3 - TERCERO /////////////////////
    Public Sub Cancha3_Tercero_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(2)

        GP_C3Tercero.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(2)))
        If GP_C3Tercero.Text = "domingo" Then
            GP_C3Tercero.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C3Tercero.Text = "lunes" Then
            GP_C3Tercero.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C3Tercero.Text = "martes" Then
            GP_C3Tercero.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C3Tercero.Text = "miércoles" Then
            GP_C3Tercero.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C3Tercero.Text = "jueves" Then
            GP_C3Tercero.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C3Tercero.Text = "viernes" Then
            GP_C3Tercero.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C3Tercero.Text = "sábado" Then
            GP_C3Tercero.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(2).Date, "3", TURNO_CONF_desde3.ToString("HH:mm"), TURNO_CONF_hasta3.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(2).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C3Tercero.DataSource = ds_Turno.Tables(0)
            DG_C3Tercero.Sort(DataGridViewTextBoxColumn126, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha




            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C3Tercero.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(2).Date)

            'Turno Medio
            While B < DG_C3Tercero.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Tercero.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C3Tercero.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Tercero.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C3Tercero.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(2).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C3Tercero.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C3Tercero.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(2).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Tercero.DataSource = ds_Turno.Tables(0)
            DG_C3Tercero.Sort(DataGridViewTextBoxColumn126, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(2)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde3, TURNO_CONF_hasta3, DT_fecha.Value.AddDays(2).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Tercero.DataSource = ds_Turno.Tables(0)
            DG_C3Tercero.Sort(DataGridViewTextBoxColumn126, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C3Tercero.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C3Tercero.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C3Tercero.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C3Tercero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C3Tercero.ClearSelection()
        Dim indice = 1
        While indice < DG_C3Tercero.Rows.Count
            Dim cliente As String = DG_C3Tercero.Rows(indice).Cells(1).Value
            If CStr(DG_C3Tercero.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C3Tercero.Rows(indice).Cells(5).Value) = CStr(DG_C3Tercero.Rows(indice - 1).Cells(5).Value) Then
                DG_C3Tercero.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 3 - CUARTO /////////////////////
    Public Sub Cancha3_Cuarto_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(3)

        GP_C3Cuarto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(3)))
        If GP_C3Cuarto.Text = "domingo" Then
            GP_C3Cuarto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C3Cuarto.Text = "lunes" Then
            GP_C3Cuarto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C3Cuarto.Text = "martes" Then
            GP_C3Cuarto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C3Cuarto.Text = "miércoles" Then
            GP_C3Cuarto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C3Cuarto.Text = "jueves" Then
            GP_C3Cuarto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C3Cuarto.Text = "viernes" Then
            GP_C3Cuarto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C3Cuarto.Text = "sábado" Then
            GP_C3Cuarto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(3).Date, "3", TURNO_CONF_desde3.ToString("HH:mm"), TURNO_CONF_hasta3.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(3).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico
        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While


        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C3Cuarto.DataSource = ds_Turno.Tables(0)
            DG_C3Cuarto.Sort(DataGridViewTextBoxColumn115, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha




            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C3Cuarto.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(3).Date)

            'Turno Medio
            While B < DG_C3Cuarto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Cuarto.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C3Cuarto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Cuarto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C3Cuarto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(3).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C3Cuarto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C3Cuarto.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(3).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Cuarto.DataSource = ds_Turno.Tables(0)
            DG_C3Cuarto.Sort(DataGridViewTextBoxColumn115, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(3)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde3, TURNO_CONF_hasta3, DT_fecha.Value.AddDays(3).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Cuarto.DataSource = ds_Turno.Tables(0)
            DG_C3Cuarto.Sort(DataGridViewTextBoxColumn115, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C3Cuarto.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C3Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C3Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C3Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C3Cuarto.ClearSelection()
        Dim indice = 1
        While indice < DG_C3Cuarto.Rows.Count
            Dim cliente As String = DG_C3Cuarto.Rows(indice).Cells(1).Value
            If CStr(DG_C3Cuarto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C3Cuarto.Rows(indice).Cells(5).Value) = CStr(DG_C3Cuarto.Rows(indice - 1).Cells(5).Value) Then
                DG_C3Cuarto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 3 - QUINTO /////////////////////
    Public Sub Cancha3_Quinto_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(4)

        GP_C3Quinto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(4)))
        If GP_C3Quinto.Text = "domingo" Then
            GP_C3Quinto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C3Quinto.Text = "lunes" Then
            GP_C3Quinto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C3Quinto.Text = "martes" Then
            GP_C3Quinto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C3Quinto.Text = "miércoles" Then
            GP_C3Quinto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C3Quinto.Text = "jueves" Then
            GP_C3Quinto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C3Quinto.Text = "viernes" Then
            GP_C3Quinto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C3Quinto.Text = "sábado" Then
            GP_C3Quinto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(4).Date, "3", TURNO_CONF_desde3.ToString("HH:mm"), TURNO_CONF_hasta3.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(4).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico
        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C3Quinto.DataSource = ds_Turno.Tables(0)
            DG_C3Quinto.Sort(DataGridViewTextBoxColumn159, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha



            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C3Quinto.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(4).Date)

            'Turno Medio
            While B < DG_C3Quinto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Quinto.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C3Quinto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Quinto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C3Quinto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(4).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C3Quinto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C3Quinto.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(4).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Quinto.DataSource = ds_Turno.Tables(0)
            DG_C3Quinto.Sort(DataGridViewTextBoxColumn159, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(4)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde3, TURNO_CONF_hasta3, DT_fecha.Value.AddDays(4).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Quinto.DataSource = ds_Turno.Tables(0)
            DG_C3Quinto.Sort(DataGridViewTextBoxColumn159, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C3Quinto.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C3Quinto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C3Quinto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C3Quinto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C3Quinto.ClearSelection()

        Dim indice = 1
        While indice < DG_C3Quinto.Rows.Count
            Dim cliente As String = DG_C3Quinto.Rows(indice).Cells(1).Value
            If CStr(DG_C3Quinto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C3Quinto.Rows(indice).Cells(5).Value) = CStr(DG_C3Quinto.Rows(indice - 1).Cells(5).Value) Then
                DG_C3Quinto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
    'CANCHA 3 - SEXTO /////////////////////
    Public Sub Cancha3_Sexto_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(5)

        GP_C3Sexto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(5)))
        If GP_C3Sexto.Text = "domingo" Then
            GP_C3Sexto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C3Sexto.Text = "lunes" Then
            GP_C3Sexto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C3Sexto.Text = "martes" Then
            GP_C3Sexto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C3Sexto.Text = "miércoles" Then
            GP_C3Sexto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C3Sexto.Text = "jueves" Then
            GP_C3Sexto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C3Sexto.Text = "viernes" Then
            GP_C3Sexto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C3Sexto.Text = "sábado" Then
            GP_C3Sexto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(5).Date, "3", TURNO_CONF_desde3.ToString("HH:mm"), TURNO_CONF_hasta3.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(5).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While


        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C3Sexto.DataSource = ds_Turno.Tables(0)
            DG_C3Sexto.Sort(DataGridViewTextBoxColumn170, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha



            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C3Sexto.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(5).Date)

            'Turno Medio
            While B < DG_C3Sexto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Sexto.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C3Sexto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Sexto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C3Sexto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(5).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C3Sexto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C3Sexto.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(5).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Sexto.DataSource = ds_Turno.Tables(0)
            DG_C3Sexto.Sort(DataGridViewTextBoxColumn170, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(5)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde3, TURNO_CONF_hasta3, DT_fecha.Value.AddDays(5).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Sexto.DataSource = ds_Turno.Tables(0)
            DG_C3Sexto.Sort(DataGridViewTextBoxColumn170, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C3Sexto.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C3Sexto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C3Sexto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C3Sexto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C3Sexto.ClearSelection()

        Dim indice = 1
        While indice < DG_C3Sexto.Rows.Count
            Dim cliente As String = DG_C3Sexto.Rows(indice).Cells(1).Value
            If CStr(DG_C3Sexto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C3Sexto.Rows(indice).Cells(5).Value) = CStr(DG_C3Sexto.Rows(indice - 1).Cells(5).Value) Then
                DG_C3Sexto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
    'CANCHA 3 - SEPTIMO /////////////////////
    Public Sub Cancha3_Septimo_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(6)

        GP_C3Septimo.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(6)))
        If GP_C3Septimo.Text = "domingo" Then
            GP_C3Septimo.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C3Septimo.Text = "lunes" Then
            GP_C3Septimo.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C3Septimo.Text = "martes" Then
            GP_C3Septimo.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C3Septimo.Text = "miércoles" Then
            GP_C3Septimo.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C3Septimo.Text = "jueves" Then
            GP_C3Septimo.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C3Septimo.Text = "viernes" Then
            GP_C3Septimo.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C3Septimo.Text = "sábado" Then
            GP_C3Septimo.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(6).Date, "3", TURNO_CONF_desde3.ToString("HH:mm"), TURNO_CONF_hasta3.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(6).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico
        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While


        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C3Septimo.DataSource = ds_Turno.Tables(0)
            DG_C3Septimo.Sort(DataGridViewTextBoxColumn181, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C3Septimo.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(6).Date)

            'Turno Medio
            While B < DG_C3Septimo.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Septimo.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C3Septimo.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C3Septimo.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C3Septimo.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(6).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C3Septimo.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C3Septimo.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta3
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(6).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Septimo.DataSource = ds_Turno.Tables(0)
            DG_C3Septimo.Sort(DataGridViewTextBoxColumn181, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(6)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde3, TURNO_CONF_hasta3, DT_fecha.Value.AddDays(6).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C3Septimo.DataSource = ds_Turno.Tables(0)
            DG_C3Septimo.Sort(DataGridViewTextBoxColumn181, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C3Septimo.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C3Septimo.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C3Septimo.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C3Septimo.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C3Septimo.ClearSelection()

        Dim indice = 1
        While indice < DG_C3Septimo.Rows.Count
            Dim cliente As String = DG_C3Septimo.Rows(indice).Cells(1).Value
            If CStr(DG_C3Septimo.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C3Septimo.Rows(indice).Cells(5).Value) = CStr(DG_C3Septimo.Rows(indice - 1).Cells(5).Value) Then
                DG_C3Septimo.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
#End Region

#Region "CANCHA 4"
    'CANCHA 4 - PRIMERO /////////////////////
    Public Sub Cancha4_Primero_cargar()
        Turno_LimpiarTabla()

        GP_C4Primero.Text = WeekdayName(Weekday(DT_fecha.Value.Date))

        If GP_C4Primero.Text = "domingo" Then
            GP_C4Primero.Text = "sábado" + " " + DT_fecha.Value.Date
        End If
        If GP_C4Primero.Text = "lunes" Then
            GP_C4Primero.Text = "domingo" + " " + DT_fecha.Value.Date
        End If
        If GP_C4Primero.Text = "martes" Then
            GP_C4Primero.Text = "lunes" + " " + DT_fecha.Value.Date
        End If
        If GP_C4Primero.Text = "miércoles" Then
            GP_C4Primero.Text = "martes" + " " + DT_fecha.Value.Date
        End If
        If GP_C4Primero.Text = "jueves" Then
            GP_C4Primero.Text = "miércoles" + " " + DT_fecha.Value.Date
        End If
        If GP_C4Primero.Text = "viernes" Then
            GP_C4Primero.Text = "jueves" + " " + DT_fecha.Value.Date
        End If
        If GP_C4Primero.Text = "sábado" Then
            GP_C4Primero.Text = "viernes" + " " + DT_fecha.Value.Date
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Text, "4", TURNO_CONF_desde4.ToString("HH:mm"), TURNO_CONF_hasta4.ToString("HH:mm"))  'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Text, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))  'nico


        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C4Primero.DataSource = ds_Turno.Tables(0)
            DG_C4Primero.Sort(DataGridViewTextBoxColumn225, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C4Primero.Rows(0).Cells(5).Value 'TURNO HORA
            Dim Hora_inicio As DateTime = TURNO_CONF_desde4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.Date)

            'Turno Medio
            While B < DG_C4Primero.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Primero.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C4Primero.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Primero.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C4Primero.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C4Primero.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C4Primero.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Primero.DataSource = ds_Turno.Tables(0)
            DG_C4Primero.Sort(DataGridViewTextBoxColumn225, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde4, TURNO_CONF_hasta4, DT_fecha.Value.Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Primero.DataSource = ds_Turno.Tables(0)
            DG_C4Primero.Sort(DataGridViewTextBoxColumn225, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C4Primero.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C4Primero.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C4Primero.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C4Primero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C4Primero.ClearSelection()

        Dim indice = 1
        While indice < DG_C4Primero.Rows.Count
            Dim cliente As String = DG_C4Primero.Rows(indice).Cells(1).Value
            If CStr(DG_C4Primero.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C4Primero.Rows(indice).Cells(5).Value) = CStr(DG_C4Primero.Rows(indice - 1).Cells(5).Value) Then
                DG_C4Primero.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 4 - SEGUNDO /////////////////////
    Public Sub Cancha4_Segundo_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(1)

        GP_C4Segundo.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(1)))
        If GP_C4Segundo.Text = "domingo" Then
            GP_C4Segundo.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C4Segundo.Text = "lunes" Then
            GP_C4Segundo.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C4Segundo.Text = "martes" Then
            GP_C4Segundo.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C4Segundo.Text = "miércoles" Then
            GP_C4Segundo.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C4Segundo.Text = "jueves" Then
            GP_C4Segundo.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C4Segundo.Text = "viernes" Then
            GP_C4Segundo.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        If GP_C4Segundo.Text = "sábado" Then
            GP_C4Segundo.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(1)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(1).Date, "4", TURNO_CONF_desde4.ToString("HH:mm"), TURNO_CONF_hasta4.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(1).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C4Segundo.DataSource = ds_Turno.Tables(0)
            DG_C4Segundo.Sort(DataGridViewTextBoxColumn214, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha

            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C4Segundo.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(1).Date)

            'Turno Medio
            While B < DG_C4Segundo.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Segundo.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C4Segundo.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Segundo.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C4Segundo.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(1).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C4Segundo.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C4Segundo.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(1).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Segundo.DataSource = ds_Turno.Tables(0)
            DG_C4Segundo.Sort(DataGridViewTextBoxColumn214, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(1)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde4, TURNO_CONF_hasta4, DT_fecha.Value.AddDays(1).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Segundo.DataSource = ds_Turno.Tables(0)
            DG_C4Segundo.Sort(DataGridViewTextBoxColumn214, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C4Segundo.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C4Segundo.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C4Segundo.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C4Segundo.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C4Segundo.ClearSelection()

        Dim indice = 1
        While indice < DG_C4Segundo.Rows.Count
            Dim cliente As String = DG_C4Segundo.Rows(indice).Cells(1).Value
            If CStr(DG_C4Segundo.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C4Segundo.Rows(indice).Cells(5).Value) = CStr(DG_C4Segundo.Rows(indice - 1).Cells(5).Value) Then
                DG_C4Segundo.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 4 - TERCERO /////////////////////
    Public Sub Cancha4_Tercero_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(2)

        GP_C4Tercero.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(2)))
        If GP_C4Tercero.Text = "domingo" Then
            GP_C4Tercero.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C4Tercero.Text = "lunes" Then
            GP_C4Tercero.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C4Tercero.Text = "martes" Then
            GP_C4Tercero.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C4Tercero.Text = "miércoles" Then
            GP_C4Tercero.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C4Tercero.Text = "jueves" Then
            GP_C4Tercero.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C4Tercero.Text = "viernes" Then
            GP_C4Tercero.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        If GP_C4Tercero.Text = "sábado" Then
            GP_C4Tercero.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(2)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(2).Date, "4", TURNO_CONF_desde4.ToString("HH:mm"), TURNO_CONF_hasta4.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(2).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C4Tercero.DataSource = ds_Turno.Tables(0)
            DG_C4Tercero.Sort(DataGridViewTextBoxColumn203, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha




            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C4Tercero.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(2).Date)

            'Turno Medio
            While B < DG_C4Tercero.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Tercero.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C4Tercero.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Tercero.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C4Tercero.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(2).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C4Tercero.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C4Tercero.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(2).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Tercero.DataSource = ds_Turno.Tables(0)
            DG_C4Tercero.Sort(DataGridViewTextBoxColumn203, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(2)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde4, TURNO_CONF_hasta4, DT_fecha.Value.AddDays(2).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Tercero.DataSource = ds_Turno.Tables(0)
            DG_C4Tercero.Sort(DataGridViewTextBoxColumn203, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C4Tercero.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C4Tercero.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C4Tercero.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C4Tercero.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C4Tercero.ClearSelection()

        Dim indice = 1
        While indice < DG_C4Tercero.Rows.Count
            Dim cliente As String = DG_C4Tercero.Rows(indice).Cells(1).Value
            If CStr(DG_C4Tercero.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C4Tercero.Rows(indice).Cells(5).Value) = CStr(DG_C4Tercero.Rows(indice - 1).Cells(5).Value) Then
                DG_C4Tercero.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 4 - CUARTO /////////////////////
    Public Sub Cancha4_Cuarto_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(3)

        GP_C4Cuarto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(3)))
        If GP_C4Cuarto.Text = "domingo" Then
            GP_C4Cuarto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C4Cuarto.Text = "lunes" Then
            GP_C4Cuarto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C4Cuarto.Text = "martes" Then
            GP_C4Cuarto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C4Cuarto.Text = "miércoles" Then
            GP_C4Cuarto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C4Cuarto.Text = "jueves" Then
            GP_C4Cuarto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C4Cuarto.Text = "viernes" Then
            GP_C4Cuarto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        If GP_C4Cuarto.Text = "sábado" Then
            GP_C4Cuarto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(3)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(3).Date, "4", TURNO_CONF_desde4.ToString("HH:mm"), TURNO_CONF_hasta4.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(3).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C4Cuarto.DataSource = ds_Turno.Tables(0)
            DG_C4Cuarto.Sort(DataGridViewTextBoxColumn192, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha




            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C4Cuarto.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(3).Date)

            'Turno Medio
            While B < DG_C4Cuarto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Cuarto.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C4Cuarto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Cuarto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C4Cuarto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(3).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C4Cuarto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C4Cuarto.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(3).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Cuarto.DataSource = ds_Turno.Tables(0)
            DG_C4Cuarto.Sort(DataGridViewTextBoxColumn192, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(3)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde4, TURNO_CONF_hasta4, DT_fecha.Value.AddDays(3).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Cuarto.DataSource = ds_Turno.Tables(0)
            DG_C4Cuarto.Sort(DataGridViewTextBoxColumn192, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C4Cuarto.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C4Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C4Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C4Cuarto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C4Cuarto.ClearSelection()

        Dim indice = 1
        While indice < DG_C4Cuarto.Rows.Count
            Dim cliente As String = DG_C4Cuarto.Rows(indice).Cells(1).Value
            If CStr(DG_C4Cuarto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C4Cuarto.Rows(indice).Cells(5).Value) = CStr(DG_C4Cuarto.Rows(indice - 1).Cells(5).Value) Then
                DG_C4Cuarto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While

    End Sub
    'CANCHA 4 - QUINTO /////////////////////
    Public Sub Cancha4_Quinto_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(4)

        GP_C4Quinto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(4)))
        If GP_C4Quinto.Text = "domingo" Then
            GP_C4Quinto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C4Quinto.Text = "lunes" Then
            GP_C4Quinto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C4Quinto.Text = "martes" Then
            GP_C4Quinto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C4Quinto.Text = "miércoles" Then
            GP_C4Quinto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C4Quinto.Text = "jueves" Then
            GP_C4Quinto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C4Quinto.Text = "viernes" Then
            GP_C4Quinto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        If GP_C4Quinto.Text = "sábado" Then
            GP_C4Quinto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(4)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(4).Date, "4", TURNO_CONF_desde4.ToString("HH:mm"), TURNO_CONF_hasta4.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(4).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C4Quinto.DataSource = ds_Turno.Tables(0)
            DG_C4Quinto.Sort(DataGridViewTextBoxColumn258, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha



            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C4Quinto.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(4).Date)

            'Turno Medio
            While B < DG_C4Quinto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Quinto.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C4Quinto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Quinto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C4Quinto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(4).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C4Quinto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C4Quinto.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(4).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Quinto.DataSource = ds_Turno.Tables(0)
            DG_C4Quinto.Sort(DataGridViewTextBoxColumn258, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(4)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde4, TURNO_CONF_hasta4, DT_fecha.Value.AddDays(4).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Quinto.DataSource = ds_Turno.Tables(0)
            DG_C4Quinto.Sort(DataGridViewTextBoxColumn258, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C4Quinto.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C4Quinto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C4Quinto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C4Quinto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C4Quinto.ClearSelection()

        Dim indice = 1
        While indice < DG_C4Quinto.Rows.Count
            Dim cliente As String = DG_C4Quinto.Rows(indice).Cells(1).Value
            If CStr(DG_C4Quinto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C4Quinto.Rows(indice).Cells(5).Value) = CStr(DG_C4Quinto.Rows(indice - 1).Cells(5).Value) Then
                DG_C4Quinto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 4 - SEXTO /////////////////////
    Public Sub Cancha4_Sexto_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(5)

        GP_C4Sexto.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(5)))
        If GP_C4Sexto.Text = "domingo" Then
            GP_C4Sexto.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C4Sexto.Text = "lunes" Then
            GP_C4Sexto.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C4Sexto.Text = "martes" Then
            GP_C4Sexto.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C4Sexto.Text = "miércoles" Then
            GP_C4Sexto.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C4Sexto.Text = "jueves" Then
            GP_C4Sexto.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C4Sexto.Text = "viernes" Then
            GP_C4Sexto.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        If GP_C4Sexto.Text = "sábado" Then
            GP_C4Sexto.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(5)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(5).Date, "4", TURNO_CONF_desde4.ToString("HH:mm"), TURNO_CONF_hasta4.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(5).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While


        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C4Sexto.DataSource = ds_Turno.Tables(0)
            DG_C4Sexto.Sort(DataGridViewTextBoxColumn247, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha




            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C4Sexto.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(5).Date)

            'Turno Medio
            While B < DG_C4Sexto.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Sexto.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C4Sexto.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Sexto.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C4Sexto.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(5).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C4Sexto.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C4Sexto.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(5).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Sexto.DataSource = ds_Turno.Tables(0)
            DG_C4Sexto.Sort(DataGridViewTextBoxColumn247, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(5)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde4, TURNO_CONF_hasta4, DT_fecha.Value.AddDays(5).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Sexto.DataSource = ds_Turno.Tables(0)
            DG_C4Sexto.Sort(DataGridViewTextBoxColumn247, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C4Sexto.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C4Sexto.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C4Sexto.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C4Sexto.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C4Sexto.ClearSelection()
        Dim indice = 1
        While indice < DG_C4Sexto.Rows.Count
            Dim cliente As String = DG_C4Sexto.Rows(indice).Cells(1).Value
            If CStr(DG_C4Sexto.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C4Sexto.Rows(indice).Cells(5).Value) = CStr(DG_C4Sexto.Rows(indice - 1).Cells(5).Value) Then
                DG_C4Sexto.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub
    'CANCHA 4 - SEPTIMO /////////////////////
    Public Sub Cancha4_Septimo_cargar()
        Turno_LimpiarTabla()

        'fecha_dia2 = DT_fecha.Value.AddDays(6)

        GP_C4Septimo.Text = WeekdayName(Weekday(DT_fecha.Value.AddDays(6)))
        If GP_C4Septimo.Text = "domingo" Then
            GP_C4Septimo.Text = "sábado" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C4Septimo.Text = "lunes" Then
            GP_C4Septimo.Text = "domingo" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C4Septimo.Text = "martes" Then
            GP_C4Septimo.Text = "lunes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C4Septimo.Text = "miércoles" Then
            GP_C4Septimo.Text = "martes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C4Septimo.Text = "jueves" Then
            GP_C4Septimo.Text = "miércoles" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C4Septimo.Text = "viernes" Then
            GP_C4Septimo.Text = "jueves" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        If GP_C4Septimo.Text = "sábado" Then
            GP_C4Septimo.Text = "viernes" + " " + DT_fecha.Value.Date.AddDays(6)
        End If
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(6).Date, "4", TURNO_CONF_desde4.ToString("HH:mm"), TURNO_CONF_hasta4.ToString("HH:mm")) 'choco
        'Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerConsulta(DT_fecha.Value.Date.AddDays(6).Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString, TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm")) 'nico

        'ds_Turno.Tables(0) 'esta trae los comunes
        'ds_Turno.Tables(1) 'esta tabla me traes los fijos
        'ds_Turno.Tables(2) 'esta trae las conf de los fijos, si hay algo significa q debo borrarlo de la tabla 1.

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(2).Rows.Count 'recorro la tabla 2---q tiene las conf de turnos fijos

            Dim a2 As Integer = 0
            While a2 < ds_Turno.Tables(1).Rows.Count 'recorro los turnos fijos de la tabla 1
                If ds_Turno.Tables(2).Rows(a1).Item("TURNO_T_id") = ds_Turno.Tables(1).Rows(a2).Item("TURNO_id") Then
                    'quitalo
                    ds_Turno.Tables(1).Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While

        Dim B As Integer
        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then

            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_C4Septimo.DataSource = ds_Turno.Tables(0)
            DG_C4Septimo.Sort(DataGridViewTextBoxColumn236, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha




            B = 1

            'Turno Primero
            Dim Primer_Hora As DateTime = DG_C4Septimo.Rows(0).Cells(5).Value 'turno hora
            Dim Hora_inicio As DateTime = TURNO_CONF_desde4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, DT_fecha.Value.AddDays(6).Date)

            'Turno Medio
            While B < DG_C4Septimo.Rows.Count

                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Septimo.Rows(B - 1).Cells(0).Value And
                       A.Item("TURNO_T") = DG_C4Septimo.Rows(B - 1).Cells(1).Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_C4Septimo.Rows(B).Cells(0).Value And
                        A.Item("TURNO_T") = DG_C4Septimo.Rows(B).Cells(1).Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, DT_fecha.Value.AddDays(6).Date)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_C4Septimo.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_C4Septimo.Rows(ultimo).Cells(6).Value 'turno fin
            Dim Hora_fin As DateTime = TURNO_CONF_hasta4
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, DT_fecha.Value.AddDays(6).Date)

            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Septimo.DataSource = ds_Turno.Tables(0)
            DG_C4Septimo.Sort(DataGridViewTextBoxColumn236, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        Else
            ''No Existen Turnos
            'Dim DISP_desde As DateTime = Now.Date
            'DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            'Dim DISP_hasta As DateTime = Now.Date
            'If TURNO_CONF_hasta < TURNO_CONF_desde Then
            '    DISP_hasta = DISP_hasta.AddDays(6)
            'End If
            'DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            Turno_ConfTurnoDisponible(TURNO_CONF_desde4, TURNO_CONF_hasta4, DT_fecha.Value.AddDays(6).Date)


            ds_Turno.Tables(0).Merge(Turnos.Tables("TurnoDisp"))
            DG_C4Septimo.DataSource = ds_Turno.Tables(0)
            DG_C4Septimo.Sort(DataGridViewTextBoxColumn236, System.ComponentModel.ListSortDirection.Ascending) 'turno fecha
        End If

        B = 0
        For Each row As DataGridViewRow In DG_C4Septimo.Rows
            Select Case (row.Cells(1).Value) 'turno t
                Case ("Normal")
                    DG_C4Septimo.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                Case ("Fijo")
                    DG_C4Septimo.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                Case ("Disp")
                    DG_C4Septimo.Rows(B).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
            B = B + 1
        Next
        DG_C4Septimo.ClearSelection()

        Dim indice = 1
        While indice < DG_C4Septimo.Rows.Count
            Dim cliente As String = DG_C4Septimo.Rows(indice).Cells(1).Value
            If CStr(DG_C4Septimo.Rows(indice).Cells(1).Value) = "Disp" And CStr(DG_C4Septimo.Rows(indice).Cells(5).Value) = CStr(DG_C4Septimo.Rows(indice - 1).Cells(5).Value) Then
                DG_C4Septimo.Rows.RemoveAt(indice)
                indice = 1
            Else
                indice = indice + 1
            End If
        End While
    End Sub


#End Region




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


    Private Sub DG_Primero_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Primero.CellContentClick

    End Sub
End Class