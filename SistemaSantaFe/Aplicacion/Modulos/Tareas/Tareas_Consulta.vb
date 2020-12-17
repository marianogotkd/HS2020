Public Class Tareas_Consulta
    Dim Daservicio As New Datos.Servicio
    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Dim DAventa As New Datos.Venta
    Public sucursal_id As Integer
    Private Sub frmDisplayAppointment_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'primero me fijo en que sucursal estoy
        Dim usuario_id As Integer = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        sucursal_id = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
        Me.Text = "Calendario de Servicios - Sucursal: " + CStr(ds_usuario.Tables(0).Rows(0).Item("sucursal_nombre"))
        GenerateDayPanel(42)
        DisplayCurrentDate()
    End Sub

    Public choco_day As Integer
    Private Sub click_derecho(ByVal sender As Object, ByVal e As System.EventArgs)
        choco_day = CType(sender, FlowLayoutPanel).Tag
        If choco_day <> 0 Then

        End If
    End Sub

    Private Sub AddNewAppointment(ByVal sender As Object, ByVal e As EventArgs)
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea generar una nueva orden de Revisión?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                'Orden_Revision_nueva.Close()
                'Orden_Revision_nueva.DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, day)
                'Orden_Revision_nueva.Show()

                With Orden_Revision_nueva
                    .appID = 0
                    .DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, day)
                    .ShowDialog()
                End With


                'With frmManageAppointment
                '    .AppID = 0
                '    .txtName.Text = ""
                '    .txtAddress.Text = ""
                '    .txtComment.Text = ""
                '    .dtpDate.Value = New Date(currentDate.Year, currentDate.Month, day)
                '    .ShowDialog()
                'End With
                'DisplayCurrentDate()
            End If

            DisplayCurrentDate()


        End If
    End Sub

    Private Sub ShowAppointmentDetail(ByVal sender As Object, ByVal e As EventArgs)
        Dim appID As Integer = CType(sender, LinkLabel).Tag
        Dim estado As String = CType(sender, LinkLabel).Name
        'Dim sql As String = $"select * from appointment where ID = {appID}"
        'Dim dt As DataTable = QueryAsDataTable(Sql)
        'If dt.Rows.Count > 0 Then
        '    Dim row As DataRow = dt.Rows(0)
        '    With frmManageAppointment
        '        .AppID = appID
        '        .txtName.Text = row("ContactName")
        '        .txtAddress.Text = row("Address")
        '        .txtComment.Text = row("Comment")
        '        .dtpDate.Value = row("AppDate")
        '        .ShowDialog()
        '    End With
        '    DisplayCurrentDate()
        'End If


        'Orden_Revision_nueva.Close()
        'Orden_Revision_nueva.appID = appID
        'Orden_Revision_nueva.Show()
        If estado = "PENDIENTE" Then
            With Orden_Revision_nueva
                .appID = appID
                '        .txtName.Text = row("ContactName")
                '        .txtAddress.Text = row("Address")
                '        .txtComment.Text = row("Comment")
                '        .dtpDate.Value = row("AppDate")
                .ShowDialog()
            End With
            DisplayCurrentDate()
        Else
            'como es una orden, independientemente del estado vamos a abrir el form
            With Servicio_nuevo
                .serv_id = appID
                '        .txtName.Text = row("ContactName")
                '        .txtAddress.Text = row("Address")
                '        .txtComment.Text = row("Comment")
                '        .dtpDate.Value = row("AppDate")
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
        

        'Orden_Revision_nueva.Focus()
    End Sub


    Private Sub AddAppointmentToFlDay(ByVal startDayAtFlNumber As Integer)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        'Dim sql As String = $"select * from appointment where AppDate between #{startDate.ToShortDateString()}# and #{endDate.ToShortDateString()}#"

        Dim dt_choco As DataSet = Daservicio.Servicio_calendario_consulta(startDate.ToShortDateString, endDate.ToShortDateString, sucursal_id)

        'Dim dt As DataTable = QueryAsDataTable(Sql)
        Dim dt As DataTable = dt_choco.Tables(0)
        Dim i As Integer = 0
        For Each row As DataRow In dt.Rows
            'Dim appDay As DateTime = DateTime.Parse(row("AppDate"))
            Dim appDay As DateTime = DateTime.Parse(row("Servicio_fecha"))
            Dim link As New LinkLabel
            'link.Tag = row("ID")
            link.Tag = row("Servicio_id")
            'link.Name = $"link{row("ID")}"
            'link.Name = row("Servicio_Diagnostico")
            link.Name = row("Servicio_Estado")
            'link.Text = row("ContactName")
            If CStr(row("Servicio_Estado")) = "PENDIENTE" Then
                link.Text = "Rev: " + CStr(row("Servicio_id"))
                link.LinkColor = Color.Orange
            Else
                Select Case (CStr(row("Servicio_Estado")))
                    Case "ASIGNADO"
                        link.Text = "OdT: " + CStr(row("Orden_trabajo_id"))
                        link.LinkColor = Color.Blue
                    Case "REPARADO"
                        link.Text = "OdT: " + CStr(row("Orden_trabajo_id"))
                        link.LinkColor = Color.Black
                    Case "FINALIZADO"
                        link.Text = "OdT: " + CStr(row("Orden_trabajo_id"))
                        link.LinkColor = Color.Green
                End Select
            End If

            'AddHandler link.Click, AddressOf ShowAppointmentDetail 'este ya no uso, no quiero hacer clic en los item q me muestra el gridview

            listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
            i = i + 1
            'If dt.Rows.Count > 2 And i = 2 Then
            '    'si hay mas de 2 entonces agrego un item mas de esos "link" que diga "ver ..."
            '    Dim link2 As New LinkLabel
            '    link2.Text = "Ver mas..."
            '    link2.LinkColor = Color.Black
            '    listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link2)
            '    Exit For
            'End If
        Next
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        'Dim firstDayAtFlNumber As Integer = 1
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub


    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()
        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            'fl.Name = $"flDay{i}"
            'fl.Name = "choco"
            If i = 1 Then
                fl.BackColor = Color.Red
            Else
                fl.BackColor = Color.White
            End If
            fl.Size = New Size(128, 99)
            'fl.Size = New Size(50, 50)

            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            'AddHandler fl.Click, AddressOf AddNewAppointment 'choco 16-12-2020 con esto activo el evento click. 
            AddHandler fl.MouseMove, AddressOf click_derecho
            flDays.ContextMenuStrip = ContextMenuStrip1 'agrego menu contextual con 2 item "Nuevo" y "Ver"
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub



    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.WhiteSmoke

        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            'lbl.Name = $"lblDay{i}"
            'lbl.Name = "choco"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(110, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.NavajoWhite

            End If

        Next
    End Sub

    Private Sub btnPrevMonth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevMonth.Click
        PrevMonth()
    End Sub

    Private Sub btnNextMonth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNextMonth.Click
        NextMonth()
    End Sub

    Private Sub btnToday_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnToday.Click
        Today()
    End Sub

    'este uso con el menu contextua, es decir el que se abre cuando le doy boton derecho
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        'Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If choco_day <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea generar una nueva orden de Revisión?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                'Orden_Revision_nueva.Close()
                'Orden_Revision_nueva.DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, day)
                'Orden_Revision_nueva.Show()

                With Orden_Revision_nueva
                    .appID = 0
                    .DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, choco_day)
                    .ShowDialog()
                End With


                'With frmManageAppointment
                '    .AppID = 0
                '    .txtName.Text = ""
                '    .txtAddress.Text = ""
                '    .txtComment.Text = ""
                '    .dtpDate.Value = New Date(currentDate.Year, currentDate.Month, day)
                '    .ShowDialog()
                'End With
                'DisplayCurrentDate()
            End If

            DisplayCurrentDate()


        End If
    End Sub

    Private Sub VerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem.Click
        If choco_day <> 0 Then
            Dim fecha As Date = New Date(currentDate.Year, currentDate.Month, choco_day)
            'con la fecha del dia busco los servicios.
            Dim dt_choco As DataSet = Daservicio.Servicio_calendario_consulta(New Date(currentDate.Year, currentDate.Month, choco_day), New Date(currentDate.Year, currentDate.Month, choco_day), sucursal_id)
            If dt_choco.Tables(0).Rows.Count <> 0 Then
                'lo muestro en otro formulario, en un gridview bien detallado
                'MessageBox.Show("SE REGISTRARON:" + CStr(dt_choco.Tables(0).Rows.Count))
                Servicio_Consulta_b.Close()
                Servicio_Consulta_b.fecha = New Date(currentDate.Year, currentDate.Month, choco_day)
                Servicio_Consulta_b.Show()
                Me.Close()
            Else
                'no hay citas registradas
                MessageBox.Show("No hay citas registradas.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
End Class