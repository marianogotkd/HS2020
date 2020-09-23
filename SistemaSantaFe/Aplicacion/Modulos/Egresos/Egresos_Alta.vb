Public Class Egresos_Alta
    Dim DAEgresos As New Datos.Egresos
    Dim DAproveedores As New Datos.Proveedor

    Dim ds_EgresoTipo As DataSet = DAEgresos.EgresoTipo_obtener

    Private Sub Egresos_Alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Combo_Gasto.DataSource = ds_EgresoTipo.Tables(0)
        Combo_Gasto.DisplayMember = "EGRESO_T_nom"
        Combo_Gasto.ValueMember = "EGRESO_T_id"


        Limpiar()

    End Sub

    Dim ds_egresos_Gasto As DataSet
    Dim ds_egresos_Det As DataSet
    Dim ds_Egreso_servicios As DataSet

    Private Sub Combo_Gasto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_Gasto.SelectedIndexChanged
        EgresoTipo_Limpiar()
        Limpiar()

        Select Case (ds_EgresoTipo.Tables(0).Rows(Combo_Gasto.SelectedIndex).Item("EGRESO_T_id").ToString)
            Case (1)
                GP_Detalle.Text = "Proveedor"
                GP_Detalle.Enabled = True

                Dim ds_proveedor As DataSet = DAproveedores.Proveedor_obtener
                Combo_Detalle.DataSource = ds_proveedor.Tables(0)
                Combo_Detalle.DisplayMember = "Prov_nombre"
                Combo_Detalle.ValueMember = "Prov_id"

            Case (2)
                GP_Detalle.Text = "Empleado"
                GP_Detalle.Enabled = True

                ds_egresos_Det = DAEgresos.Egreso_Obtener_Empleados
                Combo_Detalle.DataSource = ds_egresos_Det.Tables(0)
                Combo_Detalle.DisplayMember = "nombre"
                Combo_Detalle.ValueMember = "empleado_id"

            Case (3)
                GP_Detalle.Text = "Servicio"
                GP_Detalle.Enabled = True

                Cargo_servicios()

                BO_Servicio.Visible = True

            Case (4)
                GP_Detalle.Text = Nothing
                GP_Detalle.Enabled = False
                GP_otro.Visible = True

                tx_Monto.Enabled = True
        End Select

    End Sub

    Public Sub EgresoTipo_Limpiar()
        BO_Servicio.Visible = False
        GP_otro.Visible = False
        'Combo_Detalle.DataSource = Nothing
    End Sub

    Public Sub Cargo_servicios()
        ds_Egreso_servicios = DAEgresos.Egresos_Obtener_Servicios
        Combo_Detalle.DataSource = ds_Egreso_servicios.Tables(0)
        Combo_Detalle.DisplayMember = "Serv_Descripcion"
        Combo_Detalle.ValueMember = "Serv_Cod"
    End Sub



    Private Sub Bt_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Guardar.Click

        If tx_Monto.Text <> "" Then
            Pago.tx_total.Text = (Math.Round(CDec(tx_Monto.Text), 2).ToString("N2")) 'total 
            Pago.tx_parcial.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Pago.Show()
        Else
            MessageBox.Show("Ingrese un monto para el egreso", "La Santa Fe")
        End If


    End Sub


    Public Sub cargar_combos()
        If Combo_Gasto.SelectedIndex = 0 Then
            'Habilito los textbox
            tx_Monto.Text = ""
            tx_Monto.Enabled = True

            Dim ds_proveedor As DataSet = DAproveedores.Proveedor_obtener
            'Cargar Proveedor
            Combo_Detalle.DataSource = ds_proveedor.Tables(0)
            Combo_Detalle.DisplayMember = "Prov_nombre"
            Combo_Detalle.ValueMember = "Prov_id"
        End If
    End Sub

    Public Sub Cargo_Empleados()

        ds_egresos_Det = DAEgresos.Egreso_Obtener_Empleados
        'Cargar empleado
        Combo_Detalle.DataSource = ds_egresos_Det.Tables(0)
        Combo_Detalle.DisplayMember = "nombre"
        Combo_Detalle.ValueMember = "empleado_id"
    End Sub

    Private Sub tx_Monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Monto.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

            If Me.tx_Monto.Text <> "" Then
                If Me.tx_Monto.Text > 99999999 Then
                    e.Handled = True
                End If
            End If
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.tx_Monto.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub




    Private Sub Combo_Detalle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Detalle.SelectedIndexChanged
        Dim fijo As String = "Fijo"

        'ds_egresos_Det = DAEgresos.Egreso_Obtener_Empleados


        Select Case (ds_EgresoTipo.Tables(0).Rows(Combo_Gasto.SelectedIndex).Item("EGRESO_T_id").ToString)
            Case (2)


                Dim var2 As String = ds_egresos_Det.Tables(0).Rows(Combo_Detalle.SelectedIndex).Item("empleado_Tipo_Mto").ToString
                If var2 = fijo Then
                    tx_Monto.Enabled = False
                    tx_Monto.Text = ds_egresos_Det.Tables(0).Rows(Combo_Detalle.SelectedIndex).Item("empleado_Remune").ToString
                Else
                    tx_Monto.Enabled = True
                    tx_Monto.Text = ""
                End If



            Case (3)
                Dim var2 As String = ds_Egreso_servicios.Tables(0).Rows(Combo_Detalle.SelectedIndex).Item("Serv_Monto_Tpo")
                If var2 = fijo Then
                    tx_Monto.Enabled = False
                    tx_Monto.Text = ds_Egreso_servicios.Tables(0).Rows(Combo_Detalle.SelectedIndex).Item("Serv_Monto")
                Else
                    tx_Monto.Enabled = True
                    tx_Monto.Text = ""
                End If
        End Select
    End Sub


    Private Sub BO_Servicio_Click(sender As System.Object, e As System.EventArgs) Handles BO_Servicio.Click
        Combo_Gasto.Enabled = False
        Servicios_Alta.Show()
    End Sub

    Private Sub Bt_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Cancelar.Click
        Limpiar()
    End Sub

    Public Sub Limpiar()
        DT_EG_fecha.Value = Now
        DT_EG_fechaComp.Value = Now

        tx_Monto.Text = Nothing
        tx_NumComp.Text = Nothing
        tx_DetOtro.Text = Nothing
    End Sub

    Private Sub tx_NumComp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_NumComp.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                    e.Handled = True
                End If
            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If
    End Sub
End Class