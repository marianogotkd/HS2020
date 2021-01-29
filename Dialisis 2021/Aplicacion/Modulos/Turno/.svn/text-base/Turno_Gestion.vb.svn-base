Public Class Turno_Gestion

    Dim DAturno As New Datos.Turno
    Dim DAcancha As New Datos.Cancha
    Dim NEturno As New Aplicacion.Turno

    Dim ds_CANCHA_T As DataSet = DAcancha.CanchaTipo_obtener
    Dim ds_CANCHA As DataSet

    Private Sub Turno_Gestion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'poner previamente la propiedad del form...keypreview = true

        If e.KeyCode = Keys.F5 Then 'F5

            'este es el mismo codigo del load del form

            COM_CANCHA_T.DataSource = ds_CANCHA_T.Tables(0)
            COM_CANCHA_T.DisplayMember = "CANCHA_T_nom"
            COM_CANCHA_T.ValueMember = "CANCHA_T_id"
            Cancha_obtener()

            COM_CANCHA_T_FIN.DataSource = ds_CANCHA_T.Tables(0)
            COM_CANCHA_T_FIN.DisplayMember = "CANCHA_T_nom"
            COM_CANCHA_T_FIN.ValueMember = "CANCHA_T_id"
            COM_CANCHA_T_FIN.SelectedValue = ds_CANCHA_T.Tables(0).Rows(0).Item("CANCHA_T_id") 'SELECCIONA SINTETICO


            Cancha_obtener_Fin()

            NU_DUR_minuto.Increment = 15
            NU_DUR_minuto.Maximum = 45
            NU_DUR_minuto.Minimum = 0

            NU_DUR_hora.Increment = 1
            NU_DUR_hora.Maximum = 6
            NU_DUR_hora.Minimum = 0

            Habilitar_BO_iniciar()
            Habilitar_BO_Parar()
            Habilitar_BO_Finalizar()
            Habilitar_BO_AgregarTiempo()

            Turno_FinalizadoObtener()


            TabPage1.Parent = Nothing



        End If
    End Sub

    Private Sub Turno_Gestion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        COM_CANCHA_T.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T.ValueMember = "CANCHA_T_id"
        Cancha_obtener()

        COM_CANCHA_T_FIN.DataSource = ds_CANCHA_T.Tables(0)
        COM_CANCHA_T_FIN.DisplayMember = "CANCHA_T_nom"
        COM_CANCHA_T_FIN.ValueMember = "CANCHA_T_id"
        COM_CANCHA_T_FIN.SelectedValue = ds_CANCHA_T.Tables(0).Rows(0).Item("CANCHA_T_id") 'SELECCIONA SINTETICO


        Cancha_obtener_Fin()

        NU_DUR_minuto.Increment = 15
        NU_DUR_minuto.Maximum = 45
        NU_DUR_minuto.Minimum = 0

        NU_DUR_hora.Increment = 1
        NU_DUR_hora.Maximum = 6
        NU_DUR_hora.Minimum = 0

        Habilitar_BO_iniciar()
        Habilitar_BO_Parar()
        Habilitar_BO_Finalizar()
        Habilitar_BO_AgregarTiempo()

        Turno_FinalizadoObtener()


        TabPage1.Parent = Nothing
    End Sub

    Public Sub Cancha_obtener()
        ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString)
        COM_CANCHA.DataSource = ds_CANCHA.Tables(0)
        COM_CANCHA.DisplayMember = "CANCHA_nom"
        COM_CANCHA.ValueMember = "CANCHA_id"
    End Sub

    'TURNO RESERVADO OBTENER //////////////////////
    Dim TURNO_CONF_desde As DateTime
    Dim TURNO_CONF_hasta As DateTime
    Dim TURNO_CONF_id As String

    Private Sub COM_CANCHA_T_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA_T.SelectedIndexChanged
        Cancha_obtener()
        TurnoReservado_obtener()
    End Sub

    Private Sub COM_CANCHA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles COM_CANCHA.SelectedIndexChanged
        TurnoReservado_obtener()
    End Sub

    Public Sub TurnoReservado_obtener()
        Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString
        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(Now, CANCHA_T_id)
        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString
        Dim TURNO_CONF_precio As Decimal = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_precio").ToString
        TURNO_CONF_id = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_id").ToString

        'DG_Turno
        Dim ds_Turno As DataSet = DAturno.TurnoReservado_ObtenerSinIniciar(Now.Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString,
                                                                 TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"), TURNO_CONF_precio)

        If ds_Turno.Tables(0).Rows.Count > 0 Or ds_Turno.Tables(1).Rows.Count > 0 Then
            'Existen Turnos
            ds_Turno = NEturno.Turno_Unir(ds_Turno)
            ds_Turno = NEturno.Turno_ConfHora(ds_Turno, 1)
            DG_TurnoReservado.DataSource = ds_Turno.Tables(0)
            DG_TurnoReservado.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)

            'DG_Turno TurnoFijo de Color
            Dim B As Integer = 0
            For Each row As DataGridViewRow In DG_TurnoReservado.Rows
                Select Case (row.Cells("TURNOTDataGridViewTextBoxColumn").Value)
                    Case ("Normal")
                        DG_TurnoReservado.Rows(B).DefaultCellStyle.BackColor = Color.LightBlue
                    Case ("Fijo")
                        DG_TurnoReservado.Rows(B).DefaultCellStyle.BackColor = Color.Yellow
                End Select
                B = B + 1
            Next
            DG_TurnoReservado.ClearSelection()


            'aqui vamos a calcular el precio de cada reserva
            Dim cc As Integer = 0
            While cc < DG_TurnoReservado.Rows.Count

                Dim tiempo As String = DG_TurnoReservado.Rows(cc).Cells("TURNOcantDataGridViewTextBoxColumn").Value

                Dim horas As Integer = CInt(tiempo.Substring(0, 2))
                Dim minutos As Integer = CInt(tiempo.Substring(3, 2))

                Dim precio As Decimal = CDec(TURNO_CONF_precio * horas)
                Dim precio_minutos As Decimal = CDec(TURNO_CONF_precio / 4) 'esto es lo minito..serian 15min'


                Select Case minutos
                    Case 0
                        precio = precio + CDec(precio_minutos * 0)
                    Case 15
                        precio = precio + CDec(precio_minutos * 1)
                    Case 30
                        precio = precio + CDec(precio_minutos * 2)
                    Case 45
                        precio = precio + CDec(precio_minutos * 3)
                End Select

                'pagado  VENTATURNOmontoDataGridViewTextBoxColumn
                'saldo VENTA_TURNO_deuda
                If DG_TurnoReservado.Rows(cc).Cells("VENTATURNOmontoDataGridViewTextBoxColumn").Value >= precio Then
                    DG_TurnoReservado.Rows(cc).Cells("VENTA_TURNO_deuda").Value = Math.Round(0, 2).ToString("n2")
                Else
                    DG_TurnoReservado.Rows(cc).Cells("VENTA_TURNO_deuda").Value = CDec(precio - DG_TurnoReservado.Rows(cc).Cells("VENTATURNOmontoDataGridViewTextBoxColumn").Value)
                End If






                cc = cc + 1
            End While



        Else
            DG_TurnoReservado.DataSource = Nothing
        End If
        DG_TurnoReservado.ClearSelection()
    End Sub

    'INICIAR TURNO RESERVADO //////////////////////
    Dim ds_Turno As DataSet

    Public Sub Turno_ObtenerIniciado()
        ds_Turno = DAturno.Turno_ObtenerIniciado

        If ds_Turno.Tables(0).Rows.Count > 0 Then
            DG_Turno.DataSource = ds_Turno.Tables(0)

            For Each row As DataGridViewRow In DG_Turno.Rows
                If row.Cells("TURNO_fechahasta").Value <= Now.AddMinutes(5) Then
                    If row.Cells("TURNO_fechahasta").Value <= Now Then
                        row.DefaultCellStyle.BackColor = Color.Firebrick
                        row.DefaultCellStyle.ForeColor = Color.White
                    Else
                        row.DefaultCellStyle.BackColor = Color.Yellow
                        row.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Else
                    row.DefaultCellStyle.BackColor = Color.YellowGreen()
                    row.DefaultCellStyle.ForeColor = Color.Black
                End If
            Next

            'CAlcula el precio y seña del turno en curso segun el tipo de cancha
            Dim A As Integer = 0
            While A < DG_Turno.Rows.Count
                Dim CANCHA_T_id As Integer = 0
                If DG_Turno.Rows(A).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value.ToString = "CANCHA 1" Then
                    CANCHA_T_id = 1
                End If
                If DG_Turno.Rows(A).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value.ToString = "CANCHA 2" Then
                    CANCHA_T_id = 1
                End If
                If DG_Turno.Rows(A).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value.ToString = "CANCHA 3" Then
                    CANCHA_T_id = 2
                End If
                If DG_Turno.Rows(A).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value.ToString = "CANCHA 4" Then
                    CANCHA_T_id = 2
                End If
                Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(Now, CANCHA_T_id)
                'TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
                'TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString
                Dim TURNO_CONF_precio As Decimal = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_precio").ToString


                Dim tiempo As String = DG_Turno.Rows(A).Cells("TURNOtiempoDataGridViewTextBoxColumn").Value

                Dim horas As Integer = CInt(tiempo.Substring(0, 2))
                Dim minutos As Integer = CInt(tiempo.Substring(3, 2))

                Dim precio As Decimal = CDec(TURNO_CONF_precio * horas)
                Dim precio_minutos As Decimal = CDec(TURNO_CONF_precio / 4) 'esto es lo minito..serian 15min'


                Select Case minutos
                    Case 0
                        precio = precio + CDec(precio_minutos * 0)
                    Case 15
                        precio = precio + CDec(precio_minutos * 1)
                    Case 30
                        precio = precio + CDec(precio_minutos * 2)
                    Case 45
                        precio = precio + CDec(precio_minutos * 3)
                End Select

                'pagado  VENTATURNOmontoDataGridViewTextBoxColumn
                'saldo VENTA_TURNO_deuda
                If DG_Turno.Rows(A).Cells("TURNO_pago").Value >= precio Then
                    DG_Turno.Rows(A).Cells("TURNO_saldo").Value = Math.Round(0, 2).ToString("n2")
                Else
                    DG_Turno.Rows(A).Cells("TURNO_saldo").Value = CDec(precio - DG_Turno.Rows(A).Cells("TURNO_pago").Value)
                End If

                A = A + 1
            End While
            DG_Turno.ClearSelection()
            DG_TurnoReservado.ClearSelection()
        Else
            DG_Turno.DataSource = Nothing
        End If
    End Sub

    Private Sub DG_TurnoReservado_SelectionChanged(sender As Object, e As EventArgs) Handles DG_TurnoReservado.SelectionChanged
        Habilitar_BO_iniciar()
    End Sub

    Public Sub Habilitar_BO_iniciar()
        If ((DG_TurnoReservado.CurrentRow Is Nothing) OrElse (DG_TurnoReservado.SelectedRows.Count <> 0)) And DG_TurnoReservado.Rows.Count > 0 Then

            Dim CANCHA_nom As String = ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_nom").ToString
            Dim C As Integer = 0
            For Each row As DataGridViewRow In DG_Turno.Rows
                If row.Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = CANCHA_nom Then
                    C = 1
                End If
            Next
            If C = 0 Then
                BO_IniciarTurnoReservado.Enabled = True
            Else
                BO_IniciarTurnoReservado.Enabled = False
            End If
        Else
            BO_IniciarTurnoReservado.Enabled = False
        End If
    End Sub

    Dim DAventa As New Datos.Venta
    Public Mesas_ds As New Mesas_ds
    Public Sub recuperar_mesas()
        Mesas_ds.Tables("MesasAsignadas").Rows.Clear()
        'DataGridView1.DataSource = Nothing

        Dim ds_mesas As DataSet = DAventa.Mesas_obtener()
        If ds_mesas.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < ds_mesas.Tables(0).Rows.Count

                Dim newCustomersRow As DataRow = Mesas_ds.Tables("MesasAsignadas").NewRow()
                newCustomersRow("MESA_numero") = ds_mesas.Tables(0).Rows(i).Item("MESA_numero").ToString
                newCustomersRow("Importe_Total") = CDec("00,00")
                newCustomersRow("Pago_parcial") = CDec("00,00")
                newCustomersRow("MESA_id") = ds_mesas.Tables(0).Rows(i).Item("MESA_id").ToString
                newCustomersRow("Estado") = ds_mesas.Tables(0).Rows(i).Item("ESTADO").ToString
                newCustomersRow("Ventaprod_id") = 0
                newCustomersRow("Cliente") = ""
                newCustomersRow("Sector_id") = ds_mesas.Tables(0).Rows(i).Item("Sector_id").ToString
                newCustomersRow("Sector_nombre_usuario") = ds_mesas.Tables(0).Rows(i).Item("Sector_nombre_usuario").ToString
                newCustomersRow("Sector_nombre_fijo") = ds_mesas.Tables(0).Rows(i).Item("Sector_nombre_fijo").ToString

                If ds_mesas.Tables(0).Rows(i).Item("ESTADO").ToString <> "Libre" Then 'si no es libre..
                    'recuperar id venta, importe_total, pago parcial, cliente/consumidor final

                    'RECORRO EL TABLES 1...X Q ese trae las mesas asignas...o sea q se relacionan con venta_producto
                    Dim ii As Integer = 0
                    Dim Ventaprod_id As Integer = 0
                    While ii < ds_mesas.Tables(1).Rows.Count
                        If CInt(ds_mesas.Tables(0).Rows(i).Item("MESA_id")) = CInt(ds_mesas.Tables(1).Rows(ii).Item("MESA_id")) Then
                            Ventaprod_id = ds_mesas.Tables(1).Rows(ii).Item("Ventaprod_id")
                            ii = ds_mesas.Tables(1).Rows.Count
                        End If
                        ii = ii + 1
                    End While
                    newCustomersRow("Ventaprod_id") = Ventaprod_id.ToString
                    'Dim Ventaprod_id As Integer = ds_mesas.Tables(0).Rows(i).Item("Ventaprod_id").ToString
                    Dim ds_venta_mesa As DataSet = DAventa.VentaProducto_buscar(Ventaprod_id)
                    If ds_venta_mesa.Tables(0).Rows.Count <> 0 Then
                        newCustomersRow("Importe_Total") = CDec(Math.Round(ds_venta_mesa.Tables(0).Rows(0).Item("ventaprod_total"), 2)).ToString("N2")
                        newCustomersRow("Pago_parcial") = CDec(Math.Round(ds_venta_mesa.Tables(0).Rows(0).Item("ventaprod_pagoparcial"), 2)).ToString("N2")
                        If ds_venta_mesa.Tables(1).Rows.Count <> 0 Then
                            newCustomersRow("Cliente") = ds_venta_mesa.Tables(1).Rows(0).Item("CLI_ape").ToString + " " + ds_venta_mesa.Tables(1).Rows(0).Item("CLI_nom").ToString
                        Else
                            newCustomersRow("Cliente") = "Consumidor Final"
                        End If
                    End If
                End If

                'newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                Mesas_ds.Tables("MesasAsignadas").Rows.Add(newCustomersRow)
                i = i + 1
            End While
            'DataGridView1.DataSource = Mesas_ds.Tables("MesasAsignadas")

            Mesas_consulta_gestion.DataGridView1.DataSource = Mesas_ds.Tables("MesasAsignadas")
            Mesas_consulta_gestion.pintar_grilla_estados()
            Mesas_consulta_gestion.DataGridView1.ClearSelection()
        End If
    End Sub
    Dim Venta_Caja_ds As New Venta_Caja_ds

    Public Sub Cargar_turno(ByVal ventaprod_id As Integer, ByVal CANCHA_id As Integer, ByVal mesa_id As Integer, ByVal Label_mesa As String, ByVal cliente_ideee As Integer) 'esto lo llamo desde mesa_asignar, para q guarde en la grilla y la bd solo el precio del turno
        'obtener id de turno q esta corriendo
        Dim TURNO_id As Integer = 0
        Dim PAGADO As Decimal = 0
        Dim SALDO As Decimal = 0
        If CANCHA_id = "1" Then
            Dim i As Integer = 0
            While i < DG_Turno.Rows.Count
                If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 1" Then
                    PAGADO = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                    SALDO = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                    'Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                    'Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                    TURNO_id = DG_Turno.Rows(i).Cells(0).Value
                    i = DG_Turno.Rows.Count
                End If
                i = i + 1
            End While
        End If
        If CANCHA_id = "2" Then
            Dim i As Integer = 0
            While i < DG_Turno.Rows.Count
                If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 2" Then
                    PAGADO = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                    SALDO = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                    'Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                    'Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                    TURNO_id = DG_Turno.Rows(i).Cells(0).Value
                    i = DG_Turno.Rows.Count
                End If
                i = i + 1
            End While
        End If
        If CANCHA_id = "3" Then
            Dim i As Integer = 0
            While i < DG_Turno.Rows.Count
                If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 3" Then
                    PAGADO = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                    SALDO = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                    'Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                    'Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                    TURNO_id = DG_Turno.Rows(i).Cells(0).Value
                    i = DG_Turno.Rows.Count
                End If
                i = i + 1
            End While
        End If
        If CANCHA_id = "4" Then
            Dim i As Integer = 0
            While i < DG_Turno.Rows.Count
                If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 4" Then
                    PAGADO = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                    SALDO = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                    'Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                    'Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                    TURNO_id = DG_Turno.Rows(i).Cells(0).Value
                    i = DG_Turno.Rows.Count
                End If
                i = i + 1
            End While
        End If

        'agrego una nueva fila
        Venta_Caja_ds.Tables("Producto_agregado").Rows.Clear() 'borro x las dudas
        Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
        newCustomersRow("PROD_id") = "0" 'porque es un turno :D
        newCustomersRow("codinterno") = "0000" 'no tiene codigo interno
        newCustomersRow("descripcion") = "Turno en cancha"
        newCustomersRow("detalle") = "turno en cancha"
        newCustomersRow("cantidad") = "1"
        newCustomersRow("precio_unitario") = CDec(PAGADO + SALDO)
        newCustomersRow("precio_subtotal") = SALDO
        newCustomersRow("codbarra") = ""
        newCustomersRow("TURNO_id") = TURNO_id  'aqui va el turno_id
        Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
        'DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
        'Dim a As Integer = DataG_lista.Rows.Count
        'DataG_lista.Rows(a - 1).Cells(0).Value = a
        'calcular_totales()



        DAventa.VentaProducto_modificar_mesa(ventaprod_id, SALDO, CDec(0), "Ocupado")


        DAventa.MESAS_modificar(mesa_id, Label_mesa, "Ocupado", "Si", ventaprod_id)


        'Dim ventaprod_id As Integer = CInt(Mesas_gestion.DataGridView1.CurrentRow.Cells("VentaprodidDataGridViewTextBoxColumn").Value)

        'primero borro los item de la tabla detalle venta
        DAventa.VentaProductoDetalle_borrar(ventaprod_id)
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        'GUARDAR EN TABLA "Venta_Producto_detalle"
        DAventa.VentaProductoDetalle_alta(ventaprod_id,
                                          Venta_Caja_ds.Tables("Producto_agregado").Rows(0).Item(0),
                                          Venta_Caja_ds.Tables("Producto_agregado").Rows(0).Item(4),
                                          Venta_Caja_ds.Tables("Producto_agregado").Rows(0).Item(5),
                                          Venta_Caja_ds.Tables("Producto_agregado").Rows(0).Item(6),
                                          Venta_Caja_ds.Tables("Producto_agregado").Rows(0).Item(2),
                                          Venta_Caja_ds.Tables("Producto_agregado").Rows(0).Item(1),
                                          Venta_Caja_ds.Tables("Producto_agregado").Rows(0).Item(8))


        Mesas_gestion_2.Deshabilitar_mesas()
        Mesas_gestion_2.recuperar_mesas()
        Mesas_gestion_2.habilitar_mesas()

            MessageBox.Show("Se asigno una mesa al turno en curso", "Sistema de Gestión")



        If Inicio.tipo_usuario = "Administrador" Then
            Mesas_gestion_2.Close()
            US_administrador.llamar_Form(PN_Inicio)
        Else
            Mesas_gestion_2.Close()
            US_Empleado.llamar_Form(PN_Inicio)
        End If

        Me.Focus()

    End Sub


    Private Sub BO_IniciarTurnoReservado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_IniciarTurnoReservado.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea dar de alta el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim CANCHA_id As String = ds_CANCHA.Tables(0).Rows(COM_CANCHA.SelectedIndex).Item("CANCHA_id").ToString

            'Turno Alta
            Dim CLI_id As Integer = DG_TurnoReservado.SelectedRows(0).Cells("CLIEidDataGridViewTextBoxColumn").Value.ToString

            Dim TURNO_tiempo As String = DG_TurnoReservado.SelectedRows(0).Cells("TURNOcantDataGridViewTextBoxColumn").Value.ToString
            Dim TURNO_pago As Decimal = DG_TurnoReservado.SelectedRows(0).Cells("VENTATURNOmontoDataGridViewTextBoxColumn").Value.ToString
            Dim TURNO_saldo As Decimal = DG_TurnoReservado.SelectedRows(0).Cells("VENTA_TURNO_deuda").Value.ToString
            Dim TURNO_desde As String = Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString
            Dim FECHA_hasta As DateTime = Now
            FECHA_hasta = FECHA_hasta.AddHours(TURNO_tiempo.Substring(0, 2))
            FECHA_hasta = FECHA_hasta.AddMinutes(TURNO_tiempo.Substring(3, 2))
            Dim TURNO_hasta As String = FECHA_hasta.Hour.ToString + ":" + FECHA_hasta.Minute.ToString + ":" + FECHA_hasta.Second.ToString

            DAturno.Turno_alta(TURNO_CONF_id, CANCHA_id, Now, TURNO_desde, TURNO_hasta, TURNO_tiempo, CLI_id, FECHA_hasta, Inicio.USU_id, TURNO_pago, TURNO_saldo)

            'Turno Reservado
            Dim TURNO_id As String = DG_TurnoReservado.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn").Value.ToString
            If DG_TurnoReservado.SelectedRows(0).Cells("TURNOTDataGridViewTextBoxColumn").Value.ToString = "Fijo" Then
                DAturno.TurnoReservadoFijo_ActualizarEstado(TURNO_id, 2)
            Else
                DAturno.TurnoReservado_ActualizarEstado(TURNO_id, 2)
            End If

            TurnoReservado_obtener()
            Turno_ObtenerIniciado()

            'ASIGNAR LA PRIMERA MESA LIBRE AL TURNO EN CURSO
            recuperar_mesas()

            Dim M As Integer = 0
            Dim mesa_libre_asignada As String = "no"
            While M < Mesas_ds.Tables("MesasAsignadas").Rows.Count
                If Mesas_ds.Tables("MesasAsignadas").Rows(M).Item("Estado") = "Libre" Then
                    'asigno la mesa al turno bla bla bla....ademas cargo el primer item...q seria turno
                    '////////////////////////////////////////////////////////CREO LA ASIGNACION DE MESA//////////////////////////////////////////////////////////////////////////////////
                    Dim MESA_id As Integer = Mesas_ds.Tables("MesasAsignadas").Rows(M).Item("MESA_id")
                    Dim Label_mesa As String = Mesas_ds.Tables("MesasAsignadas").Rows(M).Item("MESA_numero")
                    Dim usuario_id As String
                    usuario_id = Inicio.USU_id 'obtengo del formulario inicio el id del usuario actual, logueado
                    Dim tipo_vta As String = ""
                    Dim cliente_id As Integer
                    Dim nombre_cliente As String = ""
                    tipo_vta = "Cliente"
                    cliente_id = CLI_id
                    'alta de venta
                    Dim ds_Venta As DataSet = DAventa.VentaProducto_alta_mesa(CDec("00,00"), CDec("00,00"), "Ocupado",
                                                        Now,
                                                        usuario_id,
                                                        tipo_vta,
                                                        cliente_id)
                    Dim ventaprod_id As Integer = CType(ds_Venta.Tables(0).Rows(0).Item("ventaprod_id"), String)
                    'actualizo estado de mesa, y relaciono con venta
                    'DAventa.MESAS_modificar(DataGridView1.CurrentRow.Cells("MESAidDataGridViewTextBoxColumn").Value, ventaprod_id, "Ocupado")
                    DAventa.MESAS_modificar(MESA_id, Label_mesa, "Ocupado", "Si", ventaprod_id)
                    'Mesas_gestion_2.Deshabilitar_mesas()
                    Mesas_gestion_2.recuperar_mesas()
                    Mesas_gestion_2.Habilitar_asignacion_pendiente()
                    mesa_libre_asignada = "si"
                    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    Call Cargar_turno(ventaprod_id, CANCHA_id, MESA_id, Label_mesa, CLI_id)
                    M = Mesas_ds.Tables("MesasAsignadas").Rows.Count
                End If



                M = M + 1
            End While



            If mesa_libre_asignada = "no" Then
                MessageBox.Show("No hay mesas disponibles, habilite y asigne mesa al turno en curso", "Sistema de Gestión La Santa Fe")
                If Inicio.tipo_usuario = "Administrador" Then
                    US_administrador.llamar_Form(Mesas_gestion_2)
                    Mesas_gestion_2.procedencia_turno = "si"
                    Mesas_gestion_2.idclie_procendencia_turno = CLI_id

                    'obtener id de turno q esta corriendo
                    If CANCHA_id = "1" Then
                        Dim i As Integer = 0
                        While i < DG_Turno.Rows.Count
                            If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 1" Then
                                Dim PAGADO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                                Dim SALDO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                                Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                                Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                                Mesas_gestion_2.TURNO_id_procedencia_turno = DG_Turno.Rows(i).Cells(0).Value
                                i = DG_Turno.Rows.Count
                            End If
                            i = i + 1
                        End While
                    End If
                    If CANCHA_id = "2" Then
                        Dim i As Integer = 0
                        While i < DG_Turno.Rows.Count
                            If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 2" Then
                                Dim PAGADO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                                Dim SALDO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                                Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                                Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                                Mesas_gestion_2.TURNO_id_procedencia_turno = DG_Turno.Rows(i).Cells(0).Value
                                i = DG_Turno.Rows.Count
                            End If
                            i = i + 1
                        End While
                    End If
                    If CANCHA_id = "3" Then
                        Dim i As Integer = 0
                        While i < DG_Turno.Rows.Count
                            If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 3" Then
                                Dim PAGADO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                                Dim SALDO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                                Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                                Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                                Mesas_gestion_2.TURNO_id_procedencia_turno = DG_Turno.Rows(i).Cells(0).Value
                                i = DG_Turno.Rows.Count
                            End If
                            i = i + 1
                        End While
                    End If
                    If CANCHA_id = "4" Then
                        Dim i As Integer = 0
                        While i < DG_Turno.Rows.Count
                            If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 4" Then
                                Dim PAGADO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                                Dim SALDO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                                Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                                Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                                Mesas_gestion_2.TURNO_id_procedencia_turno = DG_Turno.Rows(i).Cells(0).Value
                                i = DG_Turno.Rows.Count
                            End If
                            i = i + 1
                        End While
                    End If

                    US_administrador.Focus()

                Else
                    'es empleado
                    US_Empleado.llamar_Form(Mesas_gestion_2)
                    Mesas_gestion_2.procedencia_turno = "si"
                    Mesas_gestion_2.idclie_procendencia_turno = CLI_id

                    'obtener id de turno q esta corriendo
                    If CANCHA_id = "1" Then
                        Dim i As Integer = 0
                        While i < DG_Turno.Rows.Count
                            If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 1" Then
                                Dim PAGADO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                                Dim SALDO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                                Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                                Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                                Mesas_gestion_2.TURNO_id_procedencia_turno = DG_Turno.Rows(i).Cells(0).Value
                                i = DG_Turno.Rows.Count
                            End If
                            i = i + 1
                        End While
                    End If
                    If CANCHA_id = "2" Then
                        Dim i As Integer = 0
                        While i < DG_Turno.Rows.Count
                            If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 2" Then
                                Dim PAGADO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                                Dim SALDO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                                Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                                Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                                Mesas_gestion_2.TURNO_id_procedencia_turno = DG_Turno.Rows(i).Cells(0).Value
                                i = DG_Turno.Rows.Count
                            End If
                            i = i + 1
                        End While
                    End If
                    If CANCHA_id = "3" Then
                        Dim i As Integer = 0
                        While i < DG_Turno.Rows.Count
                            If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 3" Then
                                Dim PAGADO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                                Dim SALDO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                                Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                                Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                                Mesas_gestion_2.TURNO_id_procedencia_turno = DG_Turno.Rows(i).Cells(0).Value
                                i = DG_Turno.Rows.Count
                            End If
                            i = i + 1
                        End While
                    End If
                    If CANCHA_id = "4" Then
                        Dim i As Integer = 0
                        While i < DG_Turno.Rows.Count
                            If DG_Turno.Rows(i).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value = "CANCHA 4" Then
                                Dim PAGADO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_pago").Value)
                                Dim SALDO As Decimal = CDec(DG_Turno.Rows(i).Cells("TURNO_saldo").Value)
                                Mesas_gestion_2.PAGADO_procedencia_turno = PAGADO
                                Mesas_gestion_2.SALDO_procedencia_turno = SALDO
                                Mesas_gestion_2.TURNO_id_procedencia_turno = DG_Turno.Rows(i).Cells(0).Value
                                i = DG_Turno.Rows.Count
                            End If
                            i = i + 1
                        End While
                    End If

                    US_Empleado.Focus()
                End If




            End If



            




        End If
    End Sub


    'TURNO INICIADO ////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub DG_Turno_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DG_Turno.SelectionChanged
        Habilitar_BO_Finalizar()
        Habilitar_BO_AgregarTiempo()
        Habilitar_BO_Parar()
    End Sub

    Public Sub Habilitar_BO_Finalizar()
        If ((DG_Turno.CurrentRow Is Nothing) OrElse (DG_Turno.SelectedRows.Count <> 0)) And DG_Turno.Rows.Count > 0 Then
            Dim Turno_Fnalizar As DateTime = DG_Turno.SelectedRows(0).Cells("TURNO_fechahasta").Value
            If Turno_Fnalizar <= Now Then
                BO_Finalizar.Enabled = True
            Else
                BO_Finalizar.Enabled = False
            End If
        Else
            BO_Finalizar.Enabled = False
        End If
    End Sub

    Private Sub BO_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Finalizar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Finalizar el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            'Turno Alta
            Dim TURNO_id As Integer = DG_Turno.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn1").Value.ToString

            Dim TURNO_tiempo As String = DG_Turno.SelectedRows(0).Cells("TURNOtiempoDataGridViewTextBoxColumn").Value.ToString
            Dim TURNO_desde As String = DG_Turno.SelectedRows(0).Cells("TURNOdesdeDataGridViewTextBoxColumn").Value.ToString
            Dim FECHA_hasta As DateTime = DG_Turno.SelectedRows(0).Cells("TURNO_fechahasta").Value
            Dim TURNO_hasta As String = DG_Turno.SelectedRows(0).Cells("TURNOhastaDataGridViewTextBoxColumn").Value.ToString

            DAturno.Turno_modificar(TURNO_id, TURNO_desde, TURNO_hasta, TURNO_tiempo, FECHA_hasta, 2)

            Turno_ObtenerIniciado()
            Turno_FinalizadoObtener()
        End If
    End Sub

    Private Sub NU_DUR_hora_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NU_DUR_hora.ValueChanged
        Habilitar_BO_AgregarTiempo()
    End Sub

    Private Sub NU_DUR_minuto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NU_DUR_minuto.ValueChanged
        Habilitar_BO_AgregarTiempo()
    End Sub

    Public Sub Habilitar_BO_AgregarTiempo()
        If ((DG_Turno.CurrentRow Is Nothing) OrElse (DG_Turno.SelectedRows.Count <> 0)) And DG_Turno.Rows.Count > 0 Then
            If NU_DUR_hora.Value > 0 Or NU_DUR_minuto.Value >= 15 Then
                BO_AgregarTiempo.Enabled = True
            Else
                BO_AgregarTiempo.Enabled = False
            End If
        Else
            BO_AgregarTiempo.Enabled = False
        End If
    End Sub



    Private Sub BO_AgregarTiempo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_AgregarTiempo.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Agregar Tiempo al Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim TURNO_id As Integer = DG_Turno.CurrentRow.Cells("TURNOidDataGridViewTextBoxColumn1").Value.ToString

            Dim TURNO_desde As String = DG_Turno.CurrentRow.Cells("TURNOdesdeDataGridViewTextBoxColumn").Value.ToString
            Dim FECHA_hasta As DateTime = DG_Turno.CurrentRow.Cells("TURNO_fechahasta").Value.ToString

            FECHA_hasta = FECHA_hasta.AddHours(NU_DUR_hora.Value)
            FECHA_hasta = FECHA_hasta.AddMinutes(NU_DUR_minuto.Value)
            Dim TURNO_hasta As String = FECHA_hasta.Hour.ToString + ":" + FECHA_hasta.Minute.ToString

            Dim TURNO_tiempo As String = DG_Turno.CurrentRow.Cells("TURNOtiempoDataGridViewTextBoxColumn").Value.ToString
            Dim Hora As Integer = TURNO_tiempo.Substring(0, 2)
            Dim Minuto As Integer = TURNO_tiempo.Substring(3, 2)
            Hora = Hora + NU_DUR_hora.Value
            Minuto = Minuto + NU_DUR_minuto.Value
            Dim horas As String = Hora
            Dim minutos As String = Minuto
            Dim Tiempo As String = horas + ":" + minutos





            DAturno.Turno_modificar(TURNO_id, TURNO_desde, TURNO_hasta, Tiempo, FECHA_hasta, 1)

            NU_DUR_hora.Value = 0
            NU_DUR_minuto.Value = 0


            Turno_ObtenerIniciado()

            Actualizar_tiempo_en_bd(TURNO_id)

            'hay q calcular en $ cuanto tiempo se agrego...para eso debo recuperar los precios de los dos tipos de canchas





        End If



    End Sub


    Public Sub Actualizar_tiempo_en_bd(ByVal TURNO_id As Integer)
        'CAlcula el precio y seña del turno en curso segun el tipo de cancha
        Dim A As Integer = 0
        While A < DG_Turno.Rows.Count

            If TURNO_id = DG_Turno.Rows(A).Cells("TURNOidDataGridViewTextBoxColumn1").Value Then
                Dim CANCHA_T_id As Integer = 0
                If DG_Turno.Rows(A).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value.ToString = "CANCHA 1" Then
                    CANCHA_T_id = 1
                End If
                If DG_Turno.Rows(A).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value.ToString = "CANCHA 2" Then
                    CANCHA_T_id = 1
                End If
                If DG_Turno.Rows(A).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value.ToString = "CANCHA 3" Then
                    CANCHA_T_id = 2
                End If
                If DG_Turno.Rows(A).Cells("CANCHAnomDataGridViewTextBoxColumn1").Value.ToString = "CANCHA 4" Then
                    CANCHA_T_id = 2
                End If
                Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(Now, CANCHA_T_id)
                'TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
                'TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString
                Dim TURNO_CONF_precio As Decimal = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_precio").ToString


                Dim tiempo As String = DG_Turno.Rows(A).Cells("TURNOtiempoDataGridViewTextBoxColumn").Value

                Dim horas As Integer = CInt(tiempo.Substring(0, 2))
                Dim minutos As Integer = CInt(tiempo.Substring(3, 2))

                Dim precio As Decimal = CDec(TURNO_CONF_precio * horas)
                Dim precio_minutos As Decimal = CDec(TURNO_CONF_precio / 4) 'esto es lo minito..serian 15min'


                Select Case minutos
                    Case 0
                        precio = precio + CDec(precio_minutos * 0)
                    Case 15
                        precio = precio + CDec(precio_minutos * 1)
                    Case 30
                        precio = precio + CDec(precio_minutos * 2)
                    Case 45
                        precio = precio + CDec(precio_minutos * 3)
                End Select

                'pagado  VENTATURNOmontoDataGridViewTextBoxColumn
                'saldo VENTA_TURNO_deuda
                If DG_Turno.Rows(A).Cells("TURNO_pago").Value >= precio Then
                    'no actualizo en bd
                    'DG_Turno.Rows(A).Cells("TURNO_saldo").Value = Math.Round(0, 2).ToString("n2") 
                Else
                    'DG_Turno.Rows(A).Cells("TURNO_saldo").Value = CDec(precio - DG_Turno.Rows(A).Cells("TURNO_pago").Value)

                    Dim ds_ventaproducto As DataSet = DAventa.VentaProducto_registrar_monto_mastiempo_a(TURNO_id)
                    Dim monto_anterior As Decimal = ds_ventaproducto.Tables(0).Rows(0).Item("ventaprod_subtotal")

                    Dim ds_tiempo As DataSet = DAventa.VentaProducto_registrar_monto_mastiempo_b(TURNO_id, CDec(precio - DG_Turno.Rows(A).Cells("TURNO_pago").Value))
                    Dim ventaproducto_id As Integer = ds_tiempo.Tables(0).Rows(0).Item(0) 'ventaprod_id

                    'AHORA OBTENGO DE LA BD EL MONTO TOTAL REGISTRADO EN LA TABLA VentaProducto
                    Dim ds_venta As DataSet = DAventa.VentaProducto_buscar(ventaproducto_id)

                    Dim ventaprod_total As Decimal = CDec(0)
                    If ds_venta.Tables(0).Rows.Count <> 0 Then
                        ventaprod_total = CDec(ds_venta.Tables(0).Rows(0).Item("ventaprod_total"))
                    End If
                    ventaprod_total = ventaprod_total - monto_anterior
                    ventaprod_total = ventaprod_total + CDec(precio - DG_Turno.Rows(A).Cells("TURNO_pago").Value)
                    DAventa.VentaProducto_registrar_monto_mastiempo_c(ventaproducto_id, ventaprod_total, "Ocupado")


                End If

            End If
            A = A + 1
        End While


        If Inicio.tipo_usuario = "Administrador" Then
            Mesas_gestion_2.Close()
            US_administrador.llamar_Form(PN_Inicio)
        Else
            Mesas_gestion_2.Close()
            US_Empleado.llamar_Form(PN_Inicio)
        End If

        Me.Focus()


    End Sub



    Public Sub Habilitar_BO_Parar()
        If ((DG_Turno.CurrentRow Is Nothing) OrElse (DG_Turno.SelectedRows.Count <> 0)) And DG_Turno.Rows.Count > 0 Then
            BO_Parar.Enabled = True
        Else
            BO_Parar.Enabled = False
        End If
    End Sub

    Private Sub BO_Parar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Parar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Parar el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim TURNO_id As Integer = DG_Turno.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn1").Value.ToString


            'Dim FECHA_desde As DateTime = DG_Turno.SelectedRows(0).Cells(3).Value 'nico
            Dim FECHA_desde As DateTime = DG_Turno.SelectedRows(0).Cells("TURNO_fecha").Value 'choco
            'Dim FECHA_hasta As DateTime = DG_Turno.SelectedRows(0).Cells(4).Value 'choco
            Dim FECHA_hasta As DateTime = Now 'de nico
            Dim Diferencia As Integer = (DateDiff(DateInterval.Second, FECHA_desde, FECHA_hasta)).ToString

            Dim Turno_desde As String = FECHA_desde.Hour.ToString + ":" + FECHA_desde.Minute.ToString + ":" + FECHA_desde.Second.ToString
            Dim TURNO_hasta As String = FECHA_hasta.Hour.ToString + ":" + FECHA_hasta.Minute.ToString + ":" + FECHA_hasta.Second.ToString

            '----de nico
            Dim Hora As Integer = CInt(Diferencia / 3600)
            Dim minuto As Integer = CInt((Diferencia - (Hora * 3600)) / 60)
            Dim Segundo As Integer = Diferencia - ((minuto * 60) + (Hora * 3600))
            Segundo = Math.Abs(Segundo)
            Hora = Math.Abs(Hora)
            minuto = Math.Abs(minuto)
            Dim Tiempo As String = Hora.ToString + ":" + minuto.ToString + ":" + Segundo.ToString

            '----choco
            'Dim T_desde As DateTime = DG_Turno.SelectedRows(0).Cells(3).Value
            'Dim T_hasta As DateTime = DG_Turno.SelectedRows(0).Cells(4).Value

            'Dim tiempo As String = ""

            'If Now <= T_hasta Then
            '    Diferencia = (DateDiff(DateInterval.Second, T_desde, Now)).ToString()
            '    Dim Hora As Integer = CInt(Diferencia / 3600)
            '    Dim minuto As Integer = CInt((Diferencia - (Hora * 3600)) / 60)
            '    Dim Segundo As Integer = Diferencia - ((minuto * 60) + (Hora * 3600))
            '    tiempo = Hora.ToString + ":" + minuto.ToString + ":" + Segundo.ToString
            'Else
            '    Diferencia = (DateDiff(DateInterval.Second, T_desde, T_hasta)).ToString()
            '    Dim Hora As Integer = CInt(Diferencia / 3600)
            '    Dim minuto As Integer = CInt((Diferencia - (Hora * 3600)) / 60)
            '    Dim Segundo As Integer = Diferencia - ((minuto * 60) + (Hora * 3600))
            '    tiempo = Hora.ToString + ":" + minuto.ToString + ":" + Segundo.ToString
            'End If



            'Dim primercaracter As Integer = tiempo.IndexOf("-")
            'If primercaracter <> -1 Then

            '    Dim tiempo_a As DateTime = DG_Turno.SelectedRows(0).Cells(4).Value
            '    DAturno.Turno_modificar(TURNO_id, T_desde, T_hasta, tiempo_a, FECHA_hasta, 2)
            'Else
            '    DAturno.Turno_modificar(TURNO_id, T_desde, T_hasta, tiempo, FECHA_hasta, 2)
            'End If



            DAturno.Turno_modificar(TURNO_id, Turno_desde, TURNO_hasta, Tiempo, FECHA_hasta, 2) 'de nico


            Turno_ObtenerIniciado()
            Turno_FinalizadoObtener()
        End If
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Public Sub Cancha_obtener_Fin()
        ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T_FIN.SelectedIndex).Item("CANCHA_T_id").ToString)
        'ds_CANCHA = DAcancha.Cancha_obtener(ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString) 'NICO
        COM_CANCHA_FIN.DataSource = ds_CANCHA.Tables(0)
        COM_CANCHA_FIN.DisplayMember = "CANCHA_nom"
        COM_CANCHA_FIN.ValueMember = "CANCHA_id"
        COM_CANCHA_FIN.SelectedValue = ds_CANCHA.Tables(0).Rows(0).Item("CANCHA_id")

    End Sub

    Private Sub COM_CANCHA_T_FIN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM_CANCHA_T_FIN.SelectedIndexChanged
        Cancha_obtener_Fin()
    End Sub

    Private Sub COM_CANCHA_FIN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM_CANCHA_FIN.SelectedIndexChanged
        Turno_FinalizadoObtener()
    End Sub

    Public Sub Turno_FinalizadoObtener()
        Dim CANCHA_T_id As Integer = ds_CANCHA_T.Tables(0).Rows(COM_CANCHA_T.SelectedIndex).Item("CANCHA_T_id").ToString
        Dim ds_TurnoConfiguracion As DataSet = DAturno.TurnoConfiguracion_obtener(Now, CANCHA_T_id)
        TURNO_CONF_desde = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_desde").ToString
        TURNO_CONF_hasta = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_hasta").ToString
        TURNO_CONF_id = ds_TurnoConfiguracion.Tables(0).Rows(0).Item("TURNO_CONF_id").ToString

        'DG_Turno
        Dim ds_Turno As DataSet = DAturno.Turno_ObtenerFinalizado(Now.Date, ds_CANCHA.Tables(0).Rows(COM_CANCHA_FIN.SelectedIndex).Item("CANCHA_id").ToString,
                                                                 TURNO_CONF_desde.ToString("HH:mm"), TURNO_CONF_hasta.ToString("HH:mm"))

        If ds_Turno.Tables(0).Rows.Count > 0 Then
            DG_TurnoFinalziado.DataSource = ds_Turno.Tables(0)
            'DG_TurnoFinalziado.Sort(TURNOfechaDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)


        Else
            DG_TurnoFinalziado.DataSource = Nothing
        End If
        DG_TurnoFinalziado.ClearSelection()
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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


    Private Sub DG_TurnoFinalizado_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DG_TurnoFinalziado.SelectionChanged
        If ((DG_TurnoFinalziado.CurrentRow Is Nothing) OrElse (DG_TurnoFinalziado.SelectedRows.Count <> 0)) And DG_TurnoFinalziado.Rows.Count > 0 Then
            If DG_TurnoFinalziado.SelectedRows(0).Cells("DataGridViewTextBoxColumn2").Value > 0 Then
                BO_Pagar.Enabled = True
                TX_VENTA_TURNO_monto.Text = DG_TurnoFinalziado.SelectedRows(0).Cells("DataGridViewTextBoxColumn2").Value
                TX_VENTA_TURNO_monto.Enabled = True
            Else
                BO_Pagar.Enabled = False
                TX_VENTA_TURNO_monto.Text = Nothing
                TX_VENTA_TURNO_monto.Enabled = False
            End If
        Else
            BO_Pagar.Enabled = False
            TX_VENTA_TURNO_monto.Text = Nothing
            TX_VENTA_TURNO_monto.Enabled = False
        End If
    End Sub

    Dim DAcaja As New Datos.Caja

    Private Sub BO_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Pagar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Pagar el Turno?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim TURNO_id As Integer = DG_TurnoFinalziado.SelectedRows(0).Cells("TURNOidDataGridViewTextBoxColumn2").Value.ToString

            DAturno.Turno_modificarSaldo(TURNO_id, TX_VENTA_TURNO_monto.Text)
            DAturno.VentaTurno_Alta(TURNO_id, Now, TX_VENTA_TURNO_monto.Text, Inicio.USU_id, Inicio.CAJA_id)
            DAcaja.Caja_Actualizar(TX_VENTA_TURNO_monto.Text, Inicio.USU_id)
            Turno_FinalizadoObtener()
        End If
    End Sub
End Class