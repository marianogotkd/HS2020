Public Class Turno_alta

    Dim DAturno As New Datos.Turno
    Dim DAcancha As New Datos.Cancha
    Dim DAcliente As New Datos.Cliente
    Dim NEturno As New Turno


    Dim ds_CANCHA_T As DataSet = DAcancha.CanchaTipo_obtener

    Private Sub Turno_alta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BO_guardar.Enabled = False

        NEturno.Turno_CrearTabla()

        DT_fecha.MinDate = Now
        NU_hora.TextAlign = HorizontalAlignment.Center
        NU_hora.Increment = 1
        NU_hora.Maximum = 23
        NU_hora.Minimum = 0
        NU_minuto.TextAlign = HorizontalAlignment.Center
        NU_minuto.Increment = 15
        NU_minuto.Maximum = 45
        NU_minuto.Minimum = 0
        NU_DUR_minuto.TextAlign = HorizontalAlignment.Center
        NU_DUR_minuto.Increment = 15
        NU_DUR_minuto.Maximum = 45
        NU_DUR_minuto.Minimum = 0
        NU_DUR_hora.TextAlign = HorizontalAlignment.Center
        NU_DUR_hora.Increment = 1
        NU_DUR_hora.Maximum = 10
        NU_DUR_hora.Minimum = 1

        GP_cancha.Enabled = False

        COM_CANCHA_T.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T.ValueMember = "CANCHA_T_id"
        Cancha_obtener()

        TX_ape.TextAlign = HorizontalAlignment.Center
        TX_doc.TextAlign = HorizontalAlignment.Center
        TX_doc.MaxLength = 8
        BO_doc.Enabled = False

        'BO_guardar.Enabled = False



    End Sub

    Dim ds_CANCHA As DataSet
    Private Sub COM_CANCHA_T_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA_T.SelectedIndexChanged
        Cancha_obtener()
        If GP_cancha.Enabled = True Then
            Turno_Buscar()
            GP_cancha.Enabled = True
            GP_duracion.Enabled = False
            GP_fecha.Enabled = False
        End If
    End Sub

    Private Sub COM_CANCHA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA.SelectedIndexChanged
        If GP_cancha.Enabled = True Then
            Turno_Buscar()
            GP_cancha.Enabled = True
            GP_duracion.Enabled = False
            GP_fecha.Enabled = False
        End If
    End Sub

    Public Sub Cancha_obtener()
        ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString)
        COM_CANCHA.DataSource = ds_CANCHA.Tables(0)
        COM_CANCHA.DisplayMember = "CANCHA_nom"
        COM_CANCHA.ValueMember = "CANCHA_id"
    End Sub


    'Buscar Turno //////////////////////////////////////////////////////////////////////////////////////
    Private Sub BO_buscar_Click(sender As System.Object, e As System.EventArgs) Handles BO_buscar.Click
        Turno_Buscar()
        GP_duracion.Enabled = False
        GP_fecha.Enabled = False
        GP_cancha.Enabled = True
        turno_valido_en_DG_Turno()
    End Sub

    Dim TURNO_CONF_desde As DateTime
    Dim TURNO_CONF_hasta As DateTime

    Public Sub Turno_Buscar()
        Turno_Limpiar()
        NEturno.Turno_LimpiarTabla()

        Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString

        Dim fecha_bd As Date = Format(DT_fecha.Value, "dd/MM/yyyy")


        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(DT_fecha.Value, CANCHA_T_id)

        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde") 'hora inicio de trabajo
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta") 'hora final  de trabajo

        'DG_Turno


        Dim hora_desdaae As String = TURNO_CONF_desde.ToString("HH:mm")
        Dim hora_hasaaata As String = TURNO_CONF_hasta.ToString("HH:mm")

        Dim ds_Turno As DataSet = DAturno.TurnoReservado_Obtener(DT_fecha.Value.AddDays(-1), ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString,
                                                                 TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"), DT_fecha.Value)

        Dg_prueba.DataSource = ""
        Dg_prueba.DataSource = ds_Turno.Tables(4) 'PRUEBAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        DG_prueba2.DataSource = ""



        Dim d As Integer = 0

        Dim cont_tabla0 As Integer = ds_Turno.Tables(0).Rows.Count
        Dim cont_tabla2 As Integer = ds_Turno.Tables(2).Rows.Count
        dt0.DataSource = ds_Turno.Tables(0)
        dt2.DataSource = ds_Turno.Tables(2)

        dt1.DataSource = ds_Turno.Tables(1)
        dt3.DataSource = ds_Turno.Tables(3)


        While d < ds_Turno.Tables(0).Rows.Count


            Dim fecha_A As Date = ds_Turno.Tables(0).Rows(d).Item("TURNO_fecha")
            Dim fecha_A_solodia As String = Format(fecha_A, "dd/mm/yyyy")

            Dim fecha_B As Date = ds_Turno.Tables(0).Rows(d).Item("TURNO_fechahasta")
            Dim fecha_B_solodia As String = Format(fecha_B, "dd/mm/yyyy")


            If fecha_B_solodia.ToString = fecha_A_solodia.ToString Then
                ds_Turno.Tables(0).Rows.RemoveAt(d)
                d = 0
            Else
                d = d + 1
            End If

        End While



        'ALTO PARCHE PARA QUITAR LOS TURNOS RESERVADOS DEL DIA ANTERIOR, Q NO SEAN LOS DE LA ULTIMA HORA, O SEA Q NO PASEN EL RANGO...EJEMPLO 23-00...ESE QUEDA, LOS ANTERIORES NOOOOO
        Dim bsss As Integer = 0
        Dim contador1 As Integer = ds_Turno.Tables(0).Rows.Count
        While bsss < ds_Turno.Tables(0).Rows.Count
            Dim fecha_A As Date = ds_Turno.Tables(0).Rows(bsss).Item("TURNO_fecha")
            Dim fecha_A_solodia As String = Format(fecha_A, "dd/mm/yyyy")

            Dim fecha_B_solodia As String = Format(DT_fecha.Value, "dd/mm/yyyy")
            Dim fecha_B As Date = DT_fecha.Value
            If fecha_A.Date < fecha_B.Date Then

                Dim turnoHORAinicio As String = ds_Turno.Tables(0).Rows(bsss).Item("TURNO_hora")
                Dim turnoHORAfin As String = ds_Turno.Tables(0).Rows(bsss).Item("TURNO_fin")
                'Dim tipo As String = DG_Turno.Rows(bsss).Cells("TURNOTDataGridViewTextBoxColumn").Value

                Dim TURNO_Hora_inicio As DateTime = ds_Turno.Tables(0).Rows(bsss).Item("TURNO_hora")
                Dim TURNO_Hora As DateTime = ds_Turno.Tables(0).Rows(bsss).Item("TURNO_hora")
                Dim Duracion As DateTime = ds_Turno.Tables(0).Rows(bsss).Item("TURNO_cant")
                TURNO_Hora = TURNO_Hora.AddHours(Duracion.Hour)
                TURNO_Hora = TURNO_Hora.AddMinutes(Duracion.Minute)
                TURNO_Hora = TURNO_Hora.AddMinutes(-1)

                Dim hora_dia As String = TURNO_Hora.TimeOfDay.ToString

                If TURNO_Hora.TimeOfDay.ToString > TURNO_Hora_inicio.TimeOfDay.ToString Then
                    'If TURNO_Hora.ToString > TURNO_Hora_inicio.ToString Then
                    'DG_Turno.Rows.RemoveAt(bsss1)
                    ds_Turno.Tables(0).Rows.RemoveAt(bsss)
                    bsss = 0
                Else
                    bsss = bsss + 1
                End If

            Else
                bsss = bsss + 1
            End If

        End While







        ds_Turno.Tables(0).Merge(ds_Turno.Tables(2)) 'junto las dos tablas q traen turnos reservados del anterior y del actual indicado
        'ahora quitamos los registros del dia anterior donde la reserva no supere las 12 de la noche---ejemplo: 23 a 01 am...esa queda
        'se eliminaria x ejemplo: 20-23, 18-21 etc.



        d = 0

        Dim cont_tabla1 As Integer = ds_Turno.Tables(1).Rows.Count
        Dim cont_tabla3 As Integer = ds_Turno.Tables(3).Rows.Count





        'ALTO PARCHE PARA QUITAR LOS TURNOS RESERVADOS DEL DIA ANTERIOR, Q NO SEAN LOS DE LA ULTIMA HORA, O SEA Q NO PASEN EL RANGO...EJEMPLO 23-00...ESE QUEDA, LOS ANTERIORES NOOOOO
        Dim bsss1 As Integer = 0
        Dim contador As Integer = ds_Turno.Tables(1).Rows.Count
        While bsss1 < ds_Turno.Tables(1).Rows.Count
            Dim fecha_A As Date = ds_Turno.Tables(1).Rows(bsss1).Item("TURNO_fecha")
            Dim fecha_A_solodia As String = Format(fecha_A, "dd/mm/yyyy")

            Dim fecha_B_solodia As String = Format(DT_fecha.Value, "dd/mm/yyyy")
            Dim fecha_B As Date = DT_fecha.Value
            If fecha_A.Date < fecha_B.Date Then

                Dim turnoHORAinicio As String = ds_Turno.Tables(1).Rows(bsss1).Item("TURNO_hora")
                Dim turnoHORAfin As String = ds_Turno.Tables(1).Rows(bsss1).Item("TURNO_fin")
                'Dim tipo As String = DG_Turno.Rows(bsss).Cells("TURNOTDataGridViewTextBoxColumn").Value

                Dim TURNO_Hora_inicio As DateTime = ds_Turno.Tables(1).Rows(bsss1).Item("TURNO_hora")
                Dim TURNO_Hora As DateTime = ds_Turno.Tables(1).Rows(bsss1).Item("TURNO_hora")
                Dim Duracion As DateTime = ds_Turno.Tables(1).Rows(bsss1).Item("TURNO_cant")
                TURNO_Hora = TURNO_Hora.AddHours(Duracion.Hour)
                TURNO_Hora = TURNO_Hora.AddMinutes(Duracion.Minute)
                TURNO_Hora = TURNO_Hora.AddMinutes(-1)

                Dim hora_dia As String = TURNO_Hora.TimeOfDay.ToString

                If TURNO_Hora.TimeOfDay.ToString > TURNO_Hora_inicio.TimeOfDay.ToString Then
                    'If TURNO_Hora.ToString > TURNO_Hora_inicio.ToString Then
                    'DG_Turno.Rows.RemoveAt(bsss1)
                    ds_Turno.Tables(1).Rows.RemoveAt(bsss1)
                    bsss1 = 0
                Else
                    bsss1 = bsss1 + 1
                End If

            Else
                bsss1 = bsss1 + 1
            End If

        End While











        'While d < ds_Turno.Tables(1).Rows.Count
        '    Dim fecha_A As Date = ds_Turno.Tables(0).Rows(d).Item("TURNO_fecha")
        '    Dim fecha_A_solodia As String = Format(fecha_A, "hh:mm")

        '    Dim fecha_B As Date = ds_Turno.Tables(0).Rows(d).Item("TURNO_fechahasta")
        '    Dim fecha_B_solodia As String = Format(fecha_B, "dd/mm/yyyy")


        '    If fecha_B.ToString < fecha_A.ToString Then
        '        ds_Turno.Tables(1).Rows.RemoveAt(d)
        '        d = 0
        '    Else
        '        d = d + 1
        '    End If

        'End While



        ds_Turno.Tables(1).Merge(ds_Turno.Tables(3))





        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then
            'Existen Turnos
            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_Turno.DataSource = ds_Turno.Tables(0)
            DG_Turno.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)

            Me.dt1.DataSource = ds_Turno.Tables(1) '----SOLO DE PRUEBA
            dt1.Sort(dt1.Columns(5), System.ComponentModel.ListSortDirection.Ascending) 'SOLO DE PRUEBA


            'DG_Turno TurnoFijo de Color
            Dim B As Integer = 0
            For Each row As DataGridViewRow In DG_Turno.Rows
                Select Case (row.Cells("TURNOTDataGridViewTextBoxColumn").Value)
                    Case ("Normal")
                        DG_Turno.Rows(B).DefaultCellStyle.BackColor = Color.AliceBlue
                    Case ("Fijo")
                        DG_Turno.Rows(B).DefaultCellStyle.BackColor = Color.Gainsboro
                End Select
                B = B + 1
            Next
            DG_Turno.ClearSelection()

            'Turno Disponible
            B = 1

            'Turno Primero

            Dim Primer_Hora As DateTime = DG_Turno.Rows(0).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
            Dim Hora_inicio As DateTime = TURNO_CONF_desde
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            NEturno.Turno_ConfTurnoDisponible(Hora_inicio, Primer_Hora, NU_DUR_hora.Value, NU_DUR_minuto.Value)

            'Turno Medio
            While B < DG_Turno.Rows.Count

                Dim newCustomersRow As DataRow = Turno_ds.Tables("TurnoDisponible").NewRow()
                Dim Desde_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Turno.Rows(B - 1).Cells("TURNOidDataGridViewTextBoxColumn").Value And
                       A.Item("TURNO_T") = DG_Turno.Rows(B - 1).Cells("TURNOTDataGridViewTextBoxColumn").Value Then
                        Desde_Hora = A.Item("TURNO_fin")
                    End If
                Next

                Dim hasta_Hora As DateTime
                For Each A As DataRow In ds_Turno.Tables(0).Rows
                    If A.Item("TURNO_id") = DG_Turno.Rows(B).Cells("TURNOidDataGridViewTextBoxColumn").Value And
                        A.Item("TURNO_T") = DG_Turno.Rows(B).Cells("TURNOTDataGridViewTextBoxColumn").Value Then
                        hasta_Hora = A.Item("TURNO_hora")
                    End If
                Next

                NEturno.Turno_ConfTurnoDisponible(Desde_Hora, hasta_Hora, NU_DUR_hora.Value, NU_DUR_minuto.Value)
                B = B + 1
            End While

            'Turno ultimo
            Dim ultimo As Integer = DG_Turno.Rows.Count - 1
            Dim Ultimo_Hora As DateTime = DG_Turno.Rows(ultimo).Cells("TURNOfinDataGridViewTextBoxColumn").Value
            Dim Hora_fin As DateTime = TURNO_CONF_hasta
            Primer_Hora = Primer_Hora.ToString("HH:mm")

            NEturno.Turno_ConfTurnoDisponible(Ultimo_Hora, Hora_fin, NU_DUR_hora.Value, NU_DUR_minuto.Value)
        Else
            'No Existen Turnos
            Dim newCustomersRow As DataRow = Turno_ds.Tables("TurnoDisponible").NewRow()
            Dim DISP_desde As DateTime = Now.Date
            DISP_desde = DISP_desde.AddHours(TURNO_CONF_desde.Hour)

            Dim DISP_hasta As DateTime = Now.Date
            If TURNO_CONF_hasta < TURNO_CONF_desde Then
                DISP_hasta = DISP_hasta.AddDays(1)
            End If
            DISP_hasta = DISP_hasta.AddHours(TURNO_CONF_hasta.Hour)

            NEturno.Turno_ConfTurnoDisponible(DISP_desde, DISP_hasta, NU_DUR_hora.Value, NU_DUR_minuto.Value)

        End If
        Dim Turnos As DataSet = NEturno.Turno_ObtenerTabla
        DG_TurnoDisponible.DataSource = Turnos.Tables("TurnoDisp")


        'aqui ponemos en DG_Turno los horarios disponibles....con un comentario q diga LIBRE

        'Dim j As Integer = 0
        'If DG_Turno.RowCount <> 0 Then
        '    While j < DG_Turno.RowCount
        '        If DG_Turno.Rows(j).Cells("TURNOfechaDataGridViewTextBoxColumn").Value < DT_fecha.Value Then
        '            'no hago nada
        '        Else

        '            'si es de este dia

        '            If DG_Turno.Rows(j).Cells("TURNOhoraDataGridViewTextBoxColumn").Value > "00:00" Then


        '                Dim newCustomersRow As DataRow = Turno_ds.Tables("Turno").NewRow()
        '                newCustomersRow("TURNO_id") = ""
        '                newCustomersRow("CANCHA_id") = ""
        '                newCustomersRow("TURNO_fecha") = DT_fecha.Value
        '                newCustomersRow("TURNO_cant") = DG_Turno.Rows(j).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
        '                newCustomersRow("TURNO_hora") = "00:00"
        '                newCustomersRow("TURNO_fin") = DG_Turno.Rows(j).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
        '                newCustomersRow("TURNO_T") = ""
        '                newCustomersRow("CLI_nom") = "LIBRE"
        '                Turno_ds.Tables("Turno").Rows.Add(newCustomersRow)
        '                DG_Turno.DataSource = Turno_ds.Tables("Turno")
        '            End If


        '            'If asdasd Then
        '            '    'entre dos reservas
        '            '    Dim tiempo As String = DG_Turno.Rows(j).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
        '            '    Dim horas As Integer = CInt(tiempo.Substring(0, 2))
        '            '    Dim minutos As Integer = CInt(tiempo.Substring(3, 2))
        '            '    Dim dif_horas As Integer = horas - CInt("00")
        '            'End If



        '        End If



        '        j = j + 1
        '    End While
        'Else
        '    'ponemos q todos los horarios estan disponibles
        '    Turno_ds.Tables("Turno").Rows.Clear()
        '    Dim newCustomersRow As DataRow = Turno_ds.Tables("Turno").NewRow()
        '    newCustomersRow("TURNO_id") = ""
        '    newCustomersRow("CANCHA_id") = ""
        '    newCustomersRow("TURNO_fecha") = DT_fecha.Value
        '    newCustomersRow("TURNO_cant") = "23:59"
        '    newCustomersRow("TURNO_hora") = "00:00"
        '    newCustomersRow("TURNO_fin") = "23:59"
        '    newCustomersRow("TURNO_T") = ""
        '    newCustomersRow("CLI_nom") = "LIBRE"
        '    Turno_ds.Tables("Turno").Rows.Add(newCustomersRow)
        '    DG_Turno.DataSource = Turno_ds.Tables("Turno")
        'End If




        '//////////////LLENAMOS LA TABLA DE RESERVAS CON LOS TURNOS ASIGNADOS Y ADEMAS LOS INTERVALOS Q ESTAN SIN ASIGNAR
        Dim TURNO_table_filtrada As New DataTable
        TURNO_table_filtrada.Columns.Add("TURNO_id")
        TURNO_table_filtrada.Columns.Add("CANCHA_id")
        TURNO_table_filtrada.Columns.Add("TURNO_fecha")
        TURNO_table_filtrada.Columns.Add("TURNO_cant")
        TURNO_table_filtrada.Columns.Add("TURNO_hora")
        TURNO_table_filtrada.Columns.Add("TURNO_fin")
        TURNO_table_filtrada.Columns.Add("TURNO_T")
        TURNO_table_filtrada.Columns.Add("CLI_nom")


        DG_Turno.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)

        'COMENTADO---16-07-2014----ALTO PARCHE PARA CORREGIR LAS FECHAS....
        Dim CONT As Integer = ds_Turno.Tables(1).Rows.Count
        Dim cont2 As Integer = DG_Turno.Rows.Count
        Dim ass As Integer = 0
        While ass < ds_Turno.Tables(1).Rows.Count
            Dim TURNO_hora As String = ds_Turno.Tables(1).Rows(ass).Item("TURNO_hora")
            Dim turno_fecha_as As String = ds_Turno.Tables(1).Rows(ass).Item("TURNO_Fecha") '.-prueba

            TURNO_hora = TURNO_hora.Substring(0, 5)


            Dim bss As Integer = 0
            While bss < DG_Turno.Rows.Count
                Dim turnohora As String = DG_Turno.Rows(bss).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
                Dim tipo As String = DG_Turno.Rows(bss).Cells("TURNOTDataGridViewTextBoxColumn").Value

                If TURNO_hora = DG_Turno.Rows(bss).Cells("TURNOhoraDataGridViewTextBoxColumn").Value And DG_Turno.Rows(bss).Cells("TURNOTDataGridViewTextBoxColumn").Value = "Fijo" Then

                    Dim fecha_acutal As String = DG_Turno.Rows(bss).Cells("TURNOfechaDataGridViewTextBoxColumn").Value

                    DG_Turno.Rows(bss).Cells("TURNOfechaDataGridViewTextBoxColumn").Value = ds_Turno.Tables(1).Rows(ass).Item("TURNO_Fecha")
                End If

                bss = bss + 1

            End While
            ass = ass + 1
        End While



        ''ALTO PARCHE PARA QUITAR LOS TURNOS RESERVADOS DEL DIA ANTERIOR, Q NO SEAN LOS DE LA ULTIMA HORA, O SEA Q NO PASEN EL RANGO...EJEMPLO 23-00...ESE QUEDA, LOS ANTERIORES NOOOOO
        'Dim bsss As Integer = 0
        'While bsss < DG_Turno.Rows.Count
        '    Dim fecha_A As Date = DG_Turno.Rows(bsss).Cells("TURNOfechaDataGridViewTextBoxColumn").Value
        '    Dim fecha_A_solodia As String = Format(fecha_A, "dd/mm/yyyy")

        '    Dim fecha_B_solodia As String = Format(DT_fecha.Value, "dd/mm/yyyy")
        '    If fecha_A_solodia.ToString < fecha_B_solodia.ToString Then

        '        Dim turnoHORAinicio As String = DG_Turno.Rows(bsss).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
        '        Dim turnoHORAfin As String = DG_Turno.Rows(bsss).Cells("TURNOfinDataGridViewTextBoxColumn").Value
        '        Dim tipo As String = DG_Turno.Rows(bsss).Cells("TURNOTDataGridViewTextBoxColumn").Value

        '        If turnoHORAfin > turnoHORAinicio And DG_Turno.Rows(bsss).Cells("TURNOTDataGridViewTextBoxColumn").Value = "Fijo" Then
        '            DG_Turno.Rows.RemoveAt(bsss)
        '            bsss = 0
        '        Else
        '            bsss = bsss + 1
        '        End If

        '    End If
        '    bsss = bsss + 1
        'End While







        'bsss = 0
        'While bsss < DG_Turno.Rows.Count
        '    Dim fecha_A As Date = DG_Turno.Rows(bsss).Cells("TURNOfechaDataGridViewTextBoxColumn").Value
        '    Dim fecha_A_solodia As String = Format(fecha_A, "dd/mm/yyyy")

        '    Dim fecha_B_solodia As String = Format(DT_fecha.Value, "dd/mm/yyyy")
        '    If fecha_A_solodia.ToString < fecha_B_solodia.ToString Then

        '        Dim turnoHORAinicio As String = DG_Turno.Rows(bsss).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
        '        Dim turnoHORAfin As String = DG_Turno.Rows(bsss).Cells("TURNOfinDataGridViewTextBoxColumn").Value
        '        Dim tipo As String = DG_Turno.Rows(bsss).Cells("TURNOTDataGridViewTextBoxColumn").Value

        '        If turnoHORAfin = "00:00" And DG_Turno.Rows(bsss).Cells("TURNOTDataGridViewTextBoxColumn").Value = "Normal" Then
        '            DG_Turno.Rows.RemoveAt(bsss)
        '            bsss = 0
        '        Else
        '            bsss = bsss + 1
        '        End If

        '    End If
        '    bsss = bsss + 1
        'End While



        'vamos a hacer una rutina de prueba q quite de la grilla los turnos fijos
        'Dg_prueba.DataSource = DG_Turno.DataSource






        Dg_prueba.DataSource = ds_Turno.Tables(4) 'PRUEBAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        DG_prueba2.DataSource = DG_Turno.DataSource

        Dim a1 As Integer = 0
        While a1 < ds_Turno.Tables(4).Rows.Count

            Dim a2 As Integer = 0
            While a2 < DG_Turno.Rows.Count
                If ds_Turno.Tables(4).Rows(a1).Item("TURNO_T_id") = DG_Turno.Rows(a2).Cells("TURNOidDataGridViewTextBoxColumn").Value And DG_Turno.Rows(a2).Cells("TURNOTDataGridViewTextBoxColumn").Value = "Fijo" Then
                    'quitalo
                    DG_Turno.Rows.RemoveAt(a2)
                    a2 = 0
                Else
                    a2 = a2 + 1
                End If
            End While
            a1 = a1 + 1
        End While






        Dim cant_turnos As Integer = DG_Turno.Rows.Count

        'DG_prueba2.DataSource = DG_Turno.DataSource

        'DG_prueba2.Sort(DG_prueba2.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
        'DG_prueba2.Sort(DG_prueba2.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        'DG_Turno.Sort(DG_Turno.Columns(5), System.ComponentModel.ListSortDirection.Ascending)



        Dim datatable As New DataTable
        datatable.Columns.Add("TURNO_id")
        datatable.Columns.Add("CANCHA_id")
        datatable.Columns.Add("TURNO_fecha")
        datatable.Columns.Add("TURNO_cant")
        datatable.Columns.Add("TURNO_hora")
        datatable.Columns.Add("TURNO_fin")
        datatable.Columns.Add("TURNO_T")
        datatable.Columns.Add("CLI_nom")

        Dim iq As Integer = 0
        While iq < DG_Turno.Rows.Count


            Dim newCustomersRow As DataRow = datatable.NewRow()
            newCustomersRow("TURNO_id") = DG_Turno.Rows(iq).Cells("TURNOidDataGridViewTextBoxColumn").Value
            newCustomersRow("CANCHA_id") = DG_Turno.Rows(iq).Cells("CANCHAidDataGridViewTextBoxColumn").Value
            newCustomersRow("TURNO_fecha") = FormatDateTime(DG_Turno.Rows(iq).Cells("TURNOfechaDataGridViewTextBoxColumn").Value, DateFormat.ShortDate)
            newCustomersRow("TURNO_cant") = DG_Turno.Rows(iq).Cells("TURNOcantDataGridViewTextBoxColumn").Value
            newCustomersRow("TURNO_hora") = DG_Turno.Rows(iq).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
            newCustomersRow("TURNO_fin") = DG_Turno.Rows(iq).Cells("TURNOfinDataGridViewTextBoxColumn").Value
            newCustomersRow("TURNO_T") = DG_Turno.Rows(iq).Cells("TURNOTDataGridViewTextBoxColumn").Value
            newCustomersRow("CLI_nom") = DG_Turno.Rows(iq).Cells("CLI_nom").Value
            datatable.Rows.Add(newCustomersRow)
            iq = iq + 1
        End While

        Dim view As New DataView
        view = datatable.DefaultView
        view.Sort = "TURNO_fecha ASC, TURNO_hora ASC"
        'view.Sort = "TURNO_hora ASC"
        DG_prueba2.DataSource = view
        DG_Turno.DataSource = view





















        'vamos a recorrer la grilla y agregar los intervalos libres donde corresponda...

        Dim i As Integer = 0
        If cant_turnos = 0 Then

            TURNO_table_filtrada.Rows.Clear()
            Dim newCustomersRow As DataRow = TURNO_table_filtrada.NewRow()
            newCustomersRow("TURNO_id") = ""
            newCustomersRow("CANCHA_id") = ""
            newCustomersRow("TURNO_fecha") = DT_fecha.Value
            newCustomersRow("TURNO_cant") = "23:59"
            newCustomersRow("TURNO_hora") = "00:00"
            newCustomersRow("TURNO_fin") = "23:59"
            newCustomersRow("TURNO_T") = ""
            newCustomersRow("CLI_nom") = "LIBRE"
            TURNO_table_filtrada.Rows.Add(newCustomersRow)
            DG_Turno.DataSource = TURNO_table_filtrada
        Else
            'aqui validamos los intervalos
            Dim reservas = "no"
            Dim reservas_dia_anterior = "no" 'lo uso para saber si hay una reserva anterior, necesaria para calcular los rangos libres del dia, por ejemplo si el dia anterior se reserva de 23 a 01:00 ---el horario disponible del dia actual seria a partir de las 01:00 y no de 00:00 (como es normalmente)
            Dim primer_reserva As String = "no"
            While i < DG_Turno.Rows.Count
                Dim fecha_buscada As Date = FormatDateTime(DT_fecha.Value, DateFormat.ShortDate)
                Dim fecha_tabla As Date = FormatDateTime(DG_Turno.Rows(i).Cells("TURNOfechaDataGridViewTextBoxColumn").Value, DateFormat.ShortDate)
                If fecha_tabla < fecha_buscada Then
                    'If DG_Turno.Rows(i).Cells("TURNOfechaDataGridViewTextBoxColumn").Value < DT_fecha.Value Then
                    'agregamos a la tabla filtrada los turnos de una fecha anterior
                    reservas_dia_anterior = "si"
                    TURNO_table_filtrada.Rows.Clear()
                    Dim newCustomersRow As DataRow = TURNO_table_filtrada.NewRow()
                    newCustomersRow("TURNO_id") = DG_Turno.Rows(i).Cells("TURNOidDataGridViewTextBoxColumn").Value
                    newCustomersRow("CANCHA_id") = DG_Turno.Rows(i).Cells("CANCHAidDataGridViewTextBoxColumn").Value
                    newCustomersRow("TURNO_fecha") = DG_Turno.Rows(i).Cells("TURNOfechaDataGridViewTextBoxColumn").Value
                    newCustomersRow("TURNO_cant") = DG_Turno.Rows(i).Cells("TURNOcantDataGridViewTextBoxColumn").Value
                    newCustomersRow("TURNO_hora") = DG_Turno.Rows(i).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
                    newCustomersRow("TURNO_fin") = DG_Turno.Rows(i).Cells("TURNOfinDataGridViewTextBoxColumn").Value
                    newCustomersRow("TURNO_T") = DG_Turno.Rows(i).Cells("TURNOTDataGridViewTextBoxColumn").Value
                    newCustomersRow("CLI_nom") = DG_Turno.Rows(i).Cells("CLI_nom").Value
                    TURNO_table_filtrada.Rows.Add(newCustomersRow)
                End If
                'por otro lado si es hay turnos del dia...

                If fecha_tabla = fecha_buscada Then
                    reservas = "si"

                    'veo si es la primera rserva del dia..(o sea q haya empezado a las 00:00 hs del dia
                    Dim tiempo_inicio_tabla As String = DG_Turno.Rows(i).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
                    Dim tiempo_inicio_dia As String = "00:00"

                    If reservas_dia_anterior = "si" Then
                        reservas_dia_anterior = "no"
                        Dim tiempo_fin_dia_anterior As String = TURNO_table_filtrada.Rows(0).Item("TURNO_fin")

                        If tiempo_fin_dia_anterior = tiempo_inicio_tabla Then
                            'si son iguales agregamos 
                            Dim newCustomersRow As DataRow = TURNO_table_filtrada.NewRow()
                            newCustomersRow("TURNO_id") = DG_Turno.Rows(i).Cells("TURNOidDataGridViewTextBoxColumn").Value
                            newCustomersRow("CANCHA_id") = DG_Turno.Rows(i).Cells("CANCHAidDataGridViewTextBoxColumn").Value
                            newCustomersRow("TURNO_fecha") = DG_Turno.Rows(i).Cells("TURNOfechaDataGridViewTextBoxColumn").Value
                            newCustomersRow("TURNO_cant") = DG_Turno.Rows(i).Cells("TURNOcantDataGridViewTextBoxColumn").Value
                            newCustomersRow("TURNO_hora") = DG_Turno.Rows(i).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
                            newCustomersRow("TURNO_fin") = DG_Turno.Rows(i).Cells("TURNOfinDataGridViewTextBoxColumn").Value
                            newCustomersRow("TURNO_T") = DG_Turno.Rows(i).Cells("TURNOTDataGridViewTextBoxColumn").Value
                            newCustomersRow("CLI_nom") = DG_Turno.Rows(i).Cells("CLI_nom").Value
                            TURNO_table_filtrada.Rows.Add(newCustomersRow)

                        Else
                            'como no son iguales, hay q calcular la diferencia y ver los intervalos libres generados
                            '0) tengo q descomponer

                            Dim tiempo1 As Date = tiempo_inicio_tabla
                            Dim tiempo2 As Date = tiempo_fin_dia_anterior
                            'Dim tiempo As String = Format(tiempo1) - (tiempo2), "hh:mm")
                            Dim tiempo As String = DateDiff(DateInterval.Hour, tiempo2, tiempo1)

                            '1) primero agregamos el intervalo libre....
                            Dim newCustomersRow As DataRow = TURNO_table_filtrada.NewRow()
                            newCustomersRow("TURNO_id") = ""
                            newCustomersRow("CANCHA_id") = ""
                            newCustomersRow("TURNO_fecha") = DT_fecha.Value
                            newCustomersRow("TURNO_cant") = tiempo
                            newCustomersRow("TURNO_hora") = tiempo_fin_dia_anterior
                            newCustomersRow("TURNO_fin") = tiempo_inicio_tabla
                            newCustomersRow("TURNO_T") = ""
                            newCustomersRow("CLI_nom") = "LIBRE"
                            TURNO_table_filtrada.Rows.Add(newCustomersRow)
                            '2) ahora agregamos la primera reserva del dia
                            Dim newCustomersRow2 As DataRow = TURNO_table_filtrada.NewRow()
                            newCustomersRow2("TURNO_id") = DG_Turno.Rows(i).Cells("TURNOidDataGridViewTextBoxColumn").Value
                            newCustomersRow2("CANCHA_id") = DG_Turno.Rows(i).Cells("CANCHAidDataGridViewTextBoxColumn").Value
                            newCustomersRow2("TURNO_fecha") = DG_Turno.Rows(i).Cells("TURNOfechaDataGridViewTextBoxColumn").Value
                            newCustomersRow2("TURNO_cant") = DG_Turno.Rows(i).Cells("TURNOcantDataGridViewTextBoxColumn").Value
                            newCustomersRow2("TURNO_hora") = DG_Turno.Rows(i).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
                            newCustomersRow2("TURNO_fin") = DG_Turno.Rows(i).Cells("TURNOfinDataGridViewTextBoxColumn").Value
                            newCustomersRow2("TURNO_T") = DG_Turno.Rows(i).Cells("TURNOTDataGridViewTextBoxColumn").Value
                            newCustomersRow2("CLI_nom") = DG_Turno.Rows(i).Cells("CLI_nom").Value
                            TURNO_table_filtrada.Rows.Add(newCustomersRow2)
                        End If
                        primer_reserva = "si" 'probar estooooooooooooooooooooooooooooo choco 19-06-2014
                    Else
                        'como no hay reserva del dia anterior...en teoria arranca a partir de las 00:00---pero tenemos q hacer la diferencia


                        If primer_reserva = "no" Then 'agrego primer reserva
                            primer_reserva = "si"

                            If tiempo_inicio_dia <> tiempo_inicio_tabla Then

                                'si no son iguales genero la diferencia
                                Dim tiempo1 As Date = tiempo_inicio_tabla
                                Dim tiempo2 As Date = tiempo_inicio_dia
                                'Dim tiempo As String = Format(tiempo1) - (tiempo2), "hh:mm")
                                Dim tiempo As String = DateDiff(DateInterval.Hour, tiempo2, tiempo1)

                                Dim tiempo_en_minutos As String = DateDiff(DateInterval.Minute, tiempo2, tiempo1)

                                Dim duracion As DateTime = "00:00"
                                Dim AHora As Integer = Int(tiempo_en_minutos / 60)

                                Dim dif As Decimal = CDec(tiempo_en_minutos / 60) - AHora

                                Dim Aminuto As Integer = dif * 60
                                duracion = duracion.AddHours(AHora)
                                duracion = duracion.AddMinutes(Aminuto)



                                '1) primero agregamos el intervalo libre....
                                Dim newCustomersRow As DataRow = TURNO_table_filtrada.NewRow()
                                newCustomersRow("TURNO_id") = ""
                                newCustomersRow("CANCHA_id") = ""
                                newCustomersRow("TURNO_fecha") = DT_fecha.Value
                                newCustomersRow("TURNO_cant") = duracion.ToString("HH:mm")
                                newCustomersRow("TURNO_hora") = "00:00"
                                newCustomersRow("TURNO_fin") = tiempo_inicio_tabla
                                newCustomersRow("TURNO_T") = ""
                                newCustomersRow("CLI_nom") = "LIBRE"
                                TURNO_table_filtrada.Rows.Add(newCustomersRow)
                                '2) ahora agregamos la primera reserva del dia
                                Dim newCustomersRow2 As DataRow = TURNO_table_filtrada.NewRow()
                                newCustomersRow2("TURNO_id") = DG_Turno.Rows(i).Cells("TURNOidDataGridViewTextBoxColumn").Value
                                newCustomersRow2("CANCHA_id") = DG_Turno.Rows(i).Cells("CANCHAidDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_fecha") = DG_Turno.Rows(i).Cells("TURNOfechaDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_cant") = DG_Turno.Rows(i).Cells("TURNOcantDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_hora") = DG_Turno.Rows(i).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_fin") = DG_Turno.Rows(i).Cells("TURNOfinDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_T") = DG_Turno.Rows(i).Cells("TURNOTDataGridViewTextBoxColumn").Value
                                newCustomersRow2("CLI_nom") = DG_Turno.Rows(i).Cells("CLI_nom").Value
                                TURNO_table_filtrada.Rows.Add(newCustomersRow2)
                            Else
                                '2) ahora agregamos la primera reserva del dia
                                Dim newCustomersRow2 As DataRow = TURNO_table_filtrada.NewRow()
                                newCustomersRow2("TURNO_id") = DG_Turno.Rows(i).Cells("TURNOidDataGridViewTextBoxColumn").Value
                                newCustomersRow2("CANCHA_id") = DG_Turno.Rows(i).Cells("CANCHAidDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_fecha") = DG_Turno.Rows(i).Cells("TURNOfechaDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_cant") = DG_Turno.Rows(i).Cells("TURNOcantDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_hora") = DG_Turno.Rows(i).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_fin") = DG_Turno.Rows(i).Cells("TURNOfinDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_T") = DG_Turno.Rows(i).Cells("TURNOTDataGridViewTextBoxColumn").Value
                                newCustomersRow2("CLI_nom") = DG_Turno.Rows(i).Cells("CLI_nom").Value
                                TURNO_table_filtrada.Rows.Add(newCustomersRow2)
                            End If



                        Else
                            'aqui vienen las siguiente reservas...si es necesario calculamos la diferencia
                            Dim tiempo_final_tabla_elemento_anterior As String = DG_Turno.Rows(i - 1).Cells("TURNOfinDataGridViewTextBoxColumn").Value

                            If tiempo_final_tabla_elemento_anterior = tiempo_inicio_tabla Then
                                Dim newCustomersRow2 As DataRow = TURNO_table_filtrada.NewRow()
                                newCustomersRow2("TURNO_id") = DG_Turno.Rows(i).Cells("TURNOidDataGridViewTextBoxColumn").Value
                                newCustomersRow2("CANCHA_id") = DG_Turno.Rows(i).Cells("CANCHAidDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_fecha") = DG_Turno.Rows(i).Cells("TURNOfechaDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_cant") = DG_Turno.Rows(i).Cells("TURNOcantDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_hora") = DG_Turno.Rows(i).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_fin") = DG_Turno.Rows(i).Cells("TURNOfinDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_T") = DG_Turno.Rows(i).Cells("TURNOTDataGridViewTextBoxColumn").Value
                                newCustomersRow2("CLI_nom") = DG_Turno.Rows(i).Cells("CLI_nom").Value
                                TURNO_table_filtrada.Rows.Add(newCustomersRow2)
                            Else
                                'si no son iguales genero la diferencia
                                Dim tiempo1 As Date = tiempo_inicio_tabla
                                Dim tiempo2 As Date = tiempo_final_tabla_elemento_anterior
                                'Dim tiempo As String = Format(tiempo1) - (tiempo2), "hh:mm")
                                Dim tiempo As String = DateDiff(DateInterval.Hour, tiempo2, tiempo1)
                                Dim tiempo_en_minutos As String = DateDiff(DateInterval.Minute, tiempo2, tiempo1)



                                Dim duracion As DateTime = "00:00"
                                Dim AHora As Integer = Int(tiempo_en_minutos / 60)

                                Dim dif As Decimal = CDec(tiempo_en_minutos / 60) - AHora

                                Dim Aminuto As Integer = dif * 60
                                duracion = duracion.AddHours(Math.Abs(AHora))
                                duracion = duracion.AddMinutes(Math.Abs(Aminuto))




                                '1) primero agregamos el intervalo libre....
                                Dim newCustomersRow As DataRow = TURNO_table_filtrada.NewRow()
                                newCustomersRow("TURNO_id") = ""
                                newCustomersRow("CANCHA_id") = ""
                                newCustomersRow("TURNO_fecha") = DT_fecha.Value
                                newCustomersRow("TURNO_cant") = duracion.ToString("HH:mm")
                                newCustomersRow("TURNO_hora") = tiempo_final_tabla_elemento_anterior
                                newCustomersRow("TURNO_fin") = tiempo_inicio_tabla
                                newCustomersRow("TURNO_T") = ""
                                newCustomersRow("CLI_nom") = "LIBRE"
                                TURNO_table_filtrada.Rows.Add(newCustomersRow)
                                '2) ahora agregamos la primera reserva del dia
                                Dim newCustomersRow2 As DataRow = TURNO_table_filtrada.NewRow()
                                newCustomersRow2("TURNO_id") = DG_Turno.Rows(i).Cells("TURNOidDataGridViewTextBoxColumn").Value
                                newCustomersRow2("CANCHA_id") = DG_Turno.Rows(i).Cells("CANCHAidDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_fecha") = DG_Turno.Rows(i).Cells("TURNOfechaDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_cant") = DG_Turno.Rows(i).Cells("TURNOcantDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_hora") = DG_Turno.Rows(i).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_fin") = DG_Turno.Rows(i).Cells("TURNOfinDataGridViewTextBoxColumn").Value
                                newCustomersRow2("TURNO_T") = DG_Turno.Rows(i).Cells("TURNOTDataGridViewTextBoxColumn").Value
                                newCustomersRow2("CLI_nom") = DG_Turno.Rows(i).Cells("CLI_nom").Value
                                TURNO_table_filtrada.Rows.Add(newCustomersRow2)
                            End If

                        End If

                    End If
                End If
                i = i + 1
            End While
            If reservas = "no" Then
                If reservas_dia_anterior = "no" Then
                    Dim newCustomersRow As DataRow = TURNO_table_filtrada.NewRow()
                    newCustomersRow("TURNO_id") = ""
                    newCustomersRow("CANCHA_id") = ""
                    newCustomersRow("TURNO_fecha") = DT_fecha.Value
                    newCustomersRow("TURNO_cant") = "23:59"
                    newCustomersRow("TURNO_hora") = "00:00"
                    newCustomersRow("TURNO_fin") = "23:59"
                    newCustomersRow("TURNO_T") = ""
                    newCustomersRow("CLI_nom") = "LIBRE"
                    TURNO_table_filtrada.Rows.Add(newCustomersRow)
                Else

                    Dim tiempo1 As Date = "23:59"
                    Dim tiempo2 As Date = TURNO_table_filtrada.Rows(0).Item("TURNO_fin")
                    'Dim tiempo As String = Format(tiempo1) - (tiempo2), "hh:mm")
                    Dim tiempo As String = DateDiff(DateInterval.Hour, tiempo2, tiempo1)

                    Dim tiempo_en_minutos As String = DateDiff(DateInterval.Minute, tiempo2, tiempo1)
                    Dim duracion As DateTime = "00:00"
                    Dim AHora As Integer = Int(tiempo_en_minutos / 60)
                    Dim dif As Decimal = CDec(tiempo_en_minutos / 60) - AHora
                    Dim Aminuto As Integer = dif * 60
                    duracion = duracion.AddHours(AHora)
                    duracion = duracion.AddMinutes(Aminuto)

                    Dim newCustomersRow As DataRow = TURNO_table_filtrada.NewRow()
                    newCustomersRow("TURNO_id") = ""
                    newCustomersRow("CANCHA_id") = ""
                    newCustomersRow("TURNO_fecha") = DT_fecha.Value
                    newCustomersRow("TURNO_cant") = duracion.ToString("HH:mm")
                    newCustomersRow("TURNO_hora") = TURNO_table_filtrada.Rows(0).Item("TURNO_fin")
                    newCustomersRow("TURNO_fin") = "23:59"
                    newCustomersRow("TURNO_T") = ""
                    newCustomersRow("CLI_nom") = "LIBRE"
                    TURNO_table_filtrada.Rows.Add(newCustomersRow)
                End If
            End If

            'por ultimo vemos si la ultima reserva no tiene como tiempo fin 23:59 o superior (ejmp: 01:00 del otro dia :P ), agregamos un registro con el tiempo disponible
            If TURNO_table_filtrada.Rows(TURNO_table_filtrada.Rows.Count - 1).Item("TURNO_hora") < TURNO_table_filtrada.Rows(TURNO_table_filtrada.Rows.Count - 1).Item("TURNO_fin") And TURNO_table_filtrada.Rows(TURNO_table_filtrada.Rows.Count - 1).Item("TURNO_fin") < "23:59" Then
                Dim tiempo1 As Date = "23:59"
                Dim tiempo2 As Date = TURNO_table_filtrada.Rows(TURNO_table_filtrada.Rows.Count - 1).Item("TURNO_fin")
                'Dim tiempo As String = Format(tiempo1) - (tiempo2), "hh:mm")
                Dim tiempo As String = DateDiff(DateInterval.Hour, tiempo2, tiempo1)
                Dim tiempo_en_minutos As String = DateDiff(DateInterval.Minute, tiempo2, tiempo1)
                Dim duracion As DateTime = "00:00"
                Dim AHora As Integer = Int(tiempo_en_minutos / 60)
                Dim dif As Decimal = CDec(tiempo_en_minutos / 60) - AHora
                Dim Aminuto As Integer = dif * 60
                duracion = duracion.AddHours(AHora)
                duracion = duracion.AddMinutes(Aminuto)

                Dim newCustomersRow As DataRow = TURNO_table_filtrada.NewRow()
                newCustomersRow("TURNO_id") = ""
                newCustomersRow("CANCHA_id") = ""
                newCustomersRow("TURNO_fecha") = DT_fecha.Value
                newCustomersRow("TURNO_cant") = duracion.ToString("HH:mm")
                newCustomersRow("TURNO_hora") = TURNO_table_filtrada.Rows(TURNO_table_filtrada.Rows.Count - 1).Item("TURNO_fin")
                newCustomersRow("TURNO_fin") = "23:59"
                newCustomersRow("TURNO_T") = ""
                newCustomersRow("CLI_nom") = "LIBRE"
                TURNO_table_filtrada.Rows.Add(newCustomersRow)
            End If

            DG_Turno.DataSource = TURNO_table_filtrada 'aqui mostramos la tabla filtrada en la grilla TURNO

        End If



        'llamar a rutina q pinta de verde los tiempos libres
        PINTAR_TURNOS_DISPONIBLES()
    End Sub


    Public Sub PINTAR_TURNOS_DISPONIBLES()



        Dim I As Integer = 0
        While I < DG_Turno.Rows.Count

            DG_Turno.Rows(I).Cells("TURNOfechaDataGridViewTextBoxColumn").Value = CStr(DG_Turno.Rows(I).Cells("TURNOfechaDataGridViewTextBoxColumn").Value).ToLower

            If DG_Turno.Rows(I).Cells("CLI_nom").Value = "LIBRE" Then
                DG_Turno.Rows(I).DefaultCellStyle.BackColor = Color.LightGreen

            Else
                'DG_Turno.Rows(I).DefaultCellStyle.BackColor = Color.LightCoral
                If DG_Turno.Rows(I).Cells("TURNOTDataGridViewTextBoxColumn").Value = "Fijo" Then
                    DG_Turno.Rows(I).DefaultCellStyle.BackColor = Color.Yellow
                Else
                    DG_Turno.Rows(I).DefaultCellStyle.BackColor = Color.LightBlue
                End If


            End If

            I = I + 1
        End While

        DG_Turno.ClearSelection()

    End Sub


    Public Sub Turno_Limpiar()
        DG_Turno.DataSource = Nothing
        DG_TurnoDisponible.DataSource = Nothing
        Turno_ds.Tables("TurnoDisponible").Clear()

        LB_turno.Text = ""
        LB_cancha.Text = ""
        NU_hora.Value = 0
        NU_minuto.Value = 0
    End Sub

    Private Sub DG_TurnoDisponible_SelectionChanged(sender As Object, e As EventArgs) Handles DG_TurnoDisponible.SelectionChanged
        'If ((DG_TurnoDisponible.CurrentRow Is Nothing) OrElse (DG_TurnoDisponible.SelectedRows.Count <> 0)) And DG_TurnoDisponible.Rows.Count > 0 Then
        '    GP_Horario.Enabled = True
        '    Dim hora As String = DG_TurnoDisponible.SelectedRows(0).Cells("TURNO_desde").Value
        '    NU_hora.Value = (hora.Substring(0, 2))
        '    NU_minuto.Value = (hora.Substring(3, 2))
        '    Turno_validar()
        'Else
        '    'GP_Horario.Enabled = False----choco ha deshabilita...PRUEBA
        'End If
    End Sub


    'Turno Guardar /////////////////////////////////////////////////////////////////////////////////////

    Private Sub NU_hora_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_hora.ValueChanged
        'Turno_validar()
        turno_valido_en_DG_Turno()
        Turno_habilitar()
    End Sub

    Private Sub NU_minuto_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NU_minuto.ValueChanged
        'Turno_validar()
        turno_valido_en_DG_Turno()
        Turno_habilitar()
    End Sub

    Public Sub turno_valido_en_DG_Turno()


        Dim Turno_desde As DateTime = "00:00"

        TURNO_desde = TURNO_desde.AddHours(NU_hora.Value)
        TURNO_desde = TURNO_desde.AddMinutes(NU_minuto.Value)



        Dim j As Integer = 0
        Dim valido = "si"
        Dim break = "no"
        While j < DG_Turno.Rows.Count And break = "no"
            Dim Turno_desde_grilla As DateTime = DG_Turno.Rows(j).Cells("TURNOhoraDataGridViewTextBoxColumn").Value
            Dim Turno_hasta_grilla As DateTime = DG_Turno.Rows(j).Cells("TURNOfinDataGridViewTextBoxColumn").Value
            Dim tipo As String = DG_Turno.Rows(j).Cells("TURNOTDataGridViewTextBoxColumn").Value



            If Turno_desde >= Turno_desde_grilla And Turno_desde <= Turno_hasta_grilla Then

                Dim turno_desde_mas_tiempo_enjuego As DateTime = Turno_desde
                turno_desde_mas_tiempo_enjuego = turno_desde_mas_tiempo_enjuego.AddHours(NU_DUR_hora.Value)
                turno_desde_mas_tiempo_enjuego = turno_desde_mas_tiempo_enjuego.AddMinutes(NU_DUR_minuto.Value)



                If j = DG_Turno.Rows.Count - 1 Then
                    If tipo <> "" Then
                        valido = "no"
                        break = "si"
                    Else
                        valido = "si"
                        break = "si"
                    End If
                Else


                    If turno_desde_mas_tiempo_enjuego <= Turno_hasta_grilla Then
                        If tipo <> "" Then
                            valido = "no"
                            break = "si"
                        Else
                            valido = "si"
                            break = "si"
                        End If
                    Else
                        valido = "no"
                    End If


                End If

            Else
                If j = DG_Turno.Rows.Count - 1 Then

                    If Turno_desde >= Turno_desde_grilla Then
                        If tipo <> "" Then
                            valido = "no"
                            break = "si"
                        Else
                            valido = "si"
                            break = "si"
                        End If
                    End If
                End If

            End If









            'If Turno_desde = Turno_desde_grilla And tipo <> "" Then
            '    valido = "no"
            'End If

            'If Turno_desde >= Turno_desde_grilla And Turno_desde < Turno_hasta_grilla And tipo <> "" Then
            '    valido = "no"
            'Else

            '    If Turno_desde >= Turno_desde_grilla And Turno_desde <= Turno_hasta_grilla And tipo = "" Then
            '        'valido = "no"

            '        Dim turno_desde_mas_tiempo_enjuego As DateTime = Turno_desde
            '        turno_desde_mas_tiempo_enjuego = turno_desde_mas_tiempo_enjuego.AddHours(NU_DUR_hora.Value)
            '        turno_desde_mas_tiempo_enjuego = turno_desde_mas_tiempo_enjuego.AddMinutes(NU_DUR_minuto.Value)

            '        If turno_desde_mas_tiempo_enjuego <= Turno_hasta_grilla Then
            '        Else
            '            If tipo <> "" Then
            '                valido = "no"
            '            End If

            '        End If

            '    End If

            '    If Turno_desde < Turno_desde_grilla And tipo <> "" Then
            '        Dim turno_desde_mas_tiempo_enjuego As DateTime = Turno_desde
            '        turno_desde_mas_tiempo_enjuego = turno_desde_mas_tiempo_enjuego.AddHours(NU_DUR_hora.Value)
            '        turno_desde_mas_tiempo_enjuego = turno_desde_mas_tiempo_enjuego.AddMinutes(NU_DUR_minuto.Value)

            '        If turno_desde_mas_tiempo_enjuego <= Turno_hasta_grilla Then

            '            break = "si"
            '        Else
            '            If tipo <> "" Then
            '                valido = "no"
            '            End If

            '        End If

            '    Else
            '        break = "si"
            '    End If
            'End If

            ''codigo viejo
            'If Turno_desde >= Turno_desde_grilla And Turno_desde < Turno_hasta_grilla And tipo <> "" Then
            '    valido = "no"
            'Else
            '    Dim turno_desde_mas_tiempo_enjuego As DateTime = Turno_desde
            '    turno_desde_mas_tiempo_enjuego = turno_desde_mas_tiempo_enjuego.AddHours(NU_DUR_hora.Value)
            '    turno_desde_mas_tiempo_enjuego = turno_desde_mas_tiempo_enjuego.AddMinutes(NU_DUR_minuto.Value)
            '    If turno_desde_mas_tiempo_enjuego > Turno_desde_grilla And turno_desde_mas_tiempo_enjuego <= Turno_hasta_grilla And tipo <> "" Then
            '        valido = "no"
            '    End If
            'End If


            j = j + 1
        End While

        If valido = "no" Then

            NU_hora.BackColor = Color.Red
            NU_minuto.BackColor = Color.Red
        Else

            NU_hora.BackColor = Color.White
            NU_minuto.BackColor = Color.White
        End If

    End Sub



    Dim Turno_H As Integer = 0

    Public Sub Turno_validar()
        If GP_Horario.Enabled = True Then
            Dim Turno_desde As DateTime = DT_fecha.Value.Date

            If NU_hora.Value < TURNO_CONF_desde.Hour Then
                Turno_desde = Turno_desde.AddDays(1)
            End If
            Turno_desde = Turno_desde.AddHours(NU_hora.Value)
            Turno_desde = Turno_desde.AddMinutes(NU_minuto.Value)

            Dim Turno_hasta As DateTime = Turno_desde.AddHours(NU_DUR_hora.Value)
            Turno_hasta = Turno_hasta.AddMinutes(NU_DUR_minuto.Value)

            Dim Disponible_Desde As DateTime = DT_fecha.Value.Date
            Dim Hora_Desde As DateTime = DG_TurnoDisponible.SelectedRows(0).Cells("TURNO_desde").Value.ToString
            Hora_Desde = Hora_Desde.ToString("HH:mm")
            If Hora_Desde.ToString("HH:mm") < TURNO_CONF_desde Then
                Disponible_Desde = Disponible_Desde.AddDays(1)
            End If
            Disponible_Desde = Disponible_Desde.AddHours(Hora_Desde.ToString("HH"))
            Disponible_Desde = Disponible_Desde.AddMinutes(Hora_Desde.ToString("mm"))

            Dim Disponible_hasta As DateTime = DT_fecha.Value.Date
            Dim Hora_hasta As DateTime = DG_TurnoDisponible.SelectedRows(0).Cells("TURNO_hasta").Value.ToString
            Hora_hasta = Hora_hasta.ToString("HH:mm")
            If Hora_hasta.ToString("HH:mm") < TURNO_CONF_desde Then
                Disponible_hasta = Disponible_hasta.AddDays(1)
            End If
            Disponible_hasta = Disponible_hasta.AddHours(Hora_hasta.ToString("HH"))
            Disponible_hasta = Disponible_hasta.AddMinutes(Hora_hasta.ToString("mm"))
            'If (Turno_desde >= Disponible_Desde And Turno_hasta <= Disponible_hasta) Then 'nico
            If (Turno_desde >= Disponible_Desde) Then 'choco no valido el fin asi me deja dos horas x ejemplo de 10 a 12
                IM_OK_deuda.Visible = True
                IM_ERROR_moroso.Visible = False
                LB_turno.Text = "Turno: Desde el " + Turno_desde.ToString("dddd") + " a las hs." + Turno_desde.ToString("HH:mm") +
                                " Hasta el " + Turno_hasta.ToString("dddd") + " a las hs." + Turno_hasta.ToString("HH:mm")
                LB_cancha.Text = "Cancha : " + ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_nom").ToString + ". " +
                            ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_nom").ToString
                Turno_H = 1
            Else
                IM_OK_deuda.Visible = False
                IM_ERROR_moroso.Visible = True
                LB_turno.Text = ""
                LB_cancha.Text = ""
                Turno_H = 0
            End If

            Turno_habilitar()
        End If
        Turno_H = 1 'esto pone choco para q deje guardar sin validacion
    End Sub

    'Turno Limpiar /////////////////////////////////////////////////////////////////////////////////////

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Limpiar()

    End Sub

    Public Sub Limpiar()
        Turno_Limpiar()
        GP_duracion.Enabled = True
        GP_fecha.Enabled = True
        GP_cancha.Enabled = False

        DG_Turno.DataSource = Nothing
        DG_TurnoDisponible.DataSource = Nothing
        Turno_ds.Tables("TurnoDisponible").Clear()

        'GP_Horario.Enabled = False----choco ha deshabilita PRUEBA
        IM_ERROR_moroso.Visible = False
        IM_OK_deuda.Visible = False
        LB_turno.Text = ""
        LB_cancha.Text = ""
        NU_hora.Value = 0
        NU_minuto.Value = 0

        DG_Cliente.DataSource = Nothing
        DG_Cliente.Enabled = False
        TX_ape.Text = Nothing
        TX_doc.Text = Nothing

        TX_VENTA_TURNO_monto.Text = Nothing
        RB_PAGO_no.Checked = True

        TabControl2.SelectedTab = TabPage2
        GP_Horario.Enabled = True
        NU_hora.Enabled = True
        NU_minuto.Enabled = True

    End Sub


    'CLIENTE BUSCAR ///////////////////////////////////////////////////////////////////////////////////////

    Dim ds_CLI As DataSet

    Private Sub TX_doc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_doc.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TX_ape_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_ape.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TX_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TX_doc.TextChanged
        If TX_doc.Text = Nothing Then
            BO_doc.Enabled = False
        Else
            BO_doc.Enabled = True
        End If
    End Sub

    Private Sub BO_ape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ape.Click
        Cliente_ObtenerNombre()
    End Sub

    Private Sub BO_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_doc.Click
        Cliente_ObtenerDNI()
    End Sub

    Public Sub Cliente_ObtenerDNI()
        ds_CLI = DAcliente.Cliente_ObtenerDni(TX_doc.Text)
        With ds_CLI.Tables(0).Rows
            If .Count > 0 Then
                DG_Cliente.Enabled = True
                DG_Cliente.DataSource = ds_CLI.Tables(0)
                IM_ERROR_cliente.Visible = False
                LB_ERROR_cliente.Visible = False
            Else
                DG_Cliente.Enabled = False
                DG_Cliente.DataSource = Nothing
                IM_ERROR_cliente.Visible = True
                LB_ERROR_cliente.Visible = True
            End If
        End With
        TX_ape.Text = Nothing
    End Sub

    Public Sub Cliente_ObtenerNombre()
        ds_CLI = DAcliente.Cliente_ObtenerApe(TX_ape.Text)
        With ds_CLI.Tables(0).Rows
            If .Count > 0 Then
                DG_Cliente.Enabled = True
                DG_Cliente.DataSource = ds_CLI.Tables(0)
                IM_ERROR_cliente.Visible = False
                LB_ERROR_cliente.Visible = False
            Else
                DG_Cliente.Enabled = False
                DG_Cliente.DataSource = Nothing
                IM_ERROR_cliente.Visible = True
                LB_ERROR_cliente.Visible = True
            End If
        End With
        TX_doc.Text = Nothing
    End Sub

    Private Sub DG_Cliente_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DG_Cliente.SelectionChanged
        Turno_habilitar()
    End Sub

    'TURNO ALTA //////////////////////////////////////////////////////////////////////////////////////////

    Public Sub Turno_habilitar()
        If ((DG_Cliente.CurrentRow Is Nothing) OrElse (DG_Cliente.SelectedRows.Count <> 0)) And DG_Cliente.Rows.Count > 0 And (NU_hora.BackColor <> Color.Red) Then
            BO_guardar.Enabled = True
        Else
            BO_guardar.Enabled = False
        End If
    End Sub

    Dim DAcaja As New Datos.Caja

    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click
        Dim valido As String = "si"


        If RB_PAGO_si.Checked = True And TX_VENTA_TURNO_monto.Text = "" Then
            valido = "no"
        End If

        If valido = "si" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea dar de alta el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then



                Dim CANCHA_id As String = ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString

                Dim Turno_desde As DateTime = DT_fecha.Value.Date
                If NU_hora.Value < TURNO_CONF_desde.Hour Then
                    Turno_desde = Turno_desde.AddDays(1)
                End If

                Dim TURNO_cant As String = NU_DUR_hora.Text + ":" + NU_DUR_minuto.Text
                Dim TURNO_hora As String = NU_hora.Text + ":" + NU_minuto.Text
                Dim CLI_id As String = DG_Cliente.SelectedRows(0).Cells("CLIidDataGridViewTextBoxColumn").Value.ToString

                Turno_desde = Turno_desde.AddHours(NU_hora.Value)
                Turno_desde = Turno_desde.AddMinutes(NU_minuto.Value)

                Dim TURNO_fechahasta As DateTime = Turno_desde
                TURNO_fechahasta = TURNO_fechahasta.AddHours(NU_DUR_hora.Value)
                TURNO_fechahasta = TURNO_fechahasta.AddMinutes(NU_DUR_minuto.Value)

                Dim ds_TurnoReservaado As DataSet = DAturno.TurnoReservado_alta(CANCHA_id, Turno_desde, TURNO_cant, TURNO_hora, TURNO_fechahasta, CLI_id, Inicio.USU_id)
                Dim Texto As String = LB_turno.Text + " " + LB_cancha.Text
                NEturno.Turno_EnviarEmail(Texto)

                If RB_PAGO_si.Checked = True Then
                    Dim TURNO_id As Integer = ds_TurnoReservaado.Tables(0).Rows(0).Item("TURNO_id")
                    DAturno.VentaTurnoReservado_Alta(TURNO_id, 1, Now, TX_VENTA_TURNO_monto.Text, Inicio.USU_id, Inicio.CAJA_id)
                    DAcaja.Caja_Actualizar(TX_VENTA_TURNO_monto.Text, Inicio.USU_id)
                End If


                Limpiar()
                MessageBox.Show("El Turno fue dado de alta correctamente.", "Sistema de Gestion.")
                BO_guardar.Enabled = False
            End If
        Else
            MessageBox.Show("Error, ingrese el monto del pago parcial.", "Sistema de Gestion.")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Message As New System.Net.Mail.MailMessage()
        Dim SMTP As New System.Net.Mail.SmtpClient

        'CONFIGURACIÓN DEL STMP
        'SMTP.Credentials = New System.Net.NetworkCredential("hamersoftpablo@gmail.com", "123choco")
        'SMTP.Host = "smtp.gmail.com"
        'SMTP.Port = 587
        'SMTP.EnableSsl = True

        SMTP.Credentials = New System.Net.NetworkCredential("nico_qkrch@hotmail.com", "1OTRAvezelnuevoI")
        SMTP.Host = "smtp.live.com"
        SMTP.Port = 587
        SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        Message.[To].Add("nicopaztrotta@gmail.com") 'Cuenta de Correo al que se le quiere enviar el e-mail
        'Message.From = New System.Net.Mail.MailAddress("hamersoftpablo@gmail.com", "Pablo", System.Text.Encoding.UTF8) 'Quien lo envía
        Message.From = New System.Net.Mail.MailAddress("nico_qkrch@hotmail.com", "Nico", System.Text.Encoding.UTF8) 'Quien lo envía
        Message.Subject = "Turno" 'Sujeto del e-mail
        Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        Message.Body = "Anda el mail" 'contenido del mail
        Message.BodyEncoding = System.Text.Encoding.UTF8
        Message.Priority = System.Net.Mail.MailPriority.Normal
        Message.IsBodyHtml = False

        'ENVIO
        Try
            SMTP.Send(Message)
            MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub BO_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Cliente.Click
        Cliente_alta.Turno_Cliente(2)
        Cliente_alta.Show()
    End Sub

    '///////////////////////////////////////////////

    Private Sub TX_VENTA_TURNO_monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_VENTA_TURNO_monto.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not TX_VENTA_TURNO_monto.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub RB_PAGO_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_PAGO_si.CheckedChanged
        TX_VENTA_TURNO_monto.Enabled = True
    End Sub

    Private Sub RB_PAGO_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_PAGO_no.CheckedChanged
        TX_VENTA_TURNO_monto.Enabled = False
    End Sub
End Class