Public Class Mesas_gestion_2
    Dim DAventa As New Datos.Venta
    'Dim tooltip1 As New ToolTip

    Public procedencia_turno As String = "no" 'cuando diga si es x q tengo q asignar una mesa a un turno, q recien lo hago correr
    Public idclie_procendencia_turno As Integer = 0 'cuando tenga otro valor es x q tengo q asignat una mesa
    Public PAGADO_procedencia_turno As Decimal = CDec(0)
    Public SALDO_procedencia_turno As Decimal = CDec(0)
    Public TURNO_id_procedencia_turno As Integer = 0

#Region "Metodos"
    Public Mesas_ds As New Mesas_ds
    Public Sub Deshabilitar_mesas()
        Sec1_Mesa_1.Visible = False
        Sec1_Mesa_2.Visible = False
        Sec1_Mesa_3.Visible = False
        Sec1_Mesa_4.Visible = False
        Sec1_Mesa_5.Visible = False
        Sec1_Mesa_6.Visible = False
        Sec1_Mesa_7.Visible = False
        Sec1_Mesa_8.Visible = False
        Sec1_Mesa_9.Visible = False
        Sec1_Mesa_10.Visible = False
        Sec1_Mesa_11.Visible = False
        Sec1_Mesa_12.Visible = False
        Sec1_Mesa_13.Visible = False
        Sec1_Mesa_14.Visible = False
        Sec1_Mesa_15.Visible = False
        Sec1_Mesa_16.Visible = False

        Sec1_Mesa_1.BackColor = Color.ForestGreen
        Sec1_Mesa_2.BackColor = Color.ForestGreen
        Sec1_Mesa_3.BackColor = Color.ForestGreen
        Sec1_Mesa_4.BackColor = Color.ForestGreen
        Sec1_Mesa_5.BackColor = Color.ForestGreen
        Sec1_Mesa_6.BackColor = Color.ForestGreen
        Sec1_Mesa_7.BackColor = Color.ForestGreen
        Sec1_Mesa_8.BackColor = Color.ForestGreen
        Sec1_Mesa_9.BackColor = Color.ForestGreen
        Sec1_Mesa_10.BackColor = Color.ForestGreen
        Sec1_Mesa_11.BackColor = Color.ForestGreen
        Sec1_Mesa_12.BackColor = Color.ForestGreen
        Sec1_Mesa_13.BackColor = Color.ForestGreen
        Sec1_Mesa_14.BackColor = Color.ForestGreen
        Sec1_Mesa_15.BackColor = Color.ForestGreen
        Sec1_Mesa_16.BackColor = Color.ForestGreen

        ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa libre")
        ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa libre")


        'sector 2
        Sec2_Mesa_1.Visible = False
        Sec2_Mesa_2.Visible = False
        Sec2_Mesa_3.Visible = False
        Sec2_Mesa_4.Visible = False
        Sec2_Mesa_5.Visible = False
        Sec2_Mesa_6.Visible = False
        Sec2_Mesa_7.Visible = False
        Sec2_Mesa_8.Visible = False
        Sec2_Mesa_9.Visible = False
        Sec2_Mesa_10.Visible = False
        Sec2_Mesa_11.Visible = False
        Sec2_Mesa_12.Visible = False
        Sec2_Mesa_13.Visible = False
        Sec2_Mesa_14.Visible = False
        Sec2_Mesa_15.Visible = False
        Sec2_Mesa_16.Visible = False

        Sec2_Mesa_1.BackColor = Color.ForestGreen
        Sec2_Mesa_2.BackColor = Color.ForestGreen
        Sec2_Mesa_3.BackColor = Color.ForestGreen
        Sec2_Mesa_4.BackColor = Color.ForestGreen
        Sec2_Mesa_5.BackColor = Color.ForestGreen
        Sec2_Mesa_6.BackColor = Color.ForestGreen
        Sec2_Mesa_7.BackColor = Color.ForestGreen
        Sec2_Mesa_8.BackColor = Color.ForestGreen
        Sec2_Mesa_9.BackColor = Color.ForestGreen
        Sec2_Mesa_10.BackColor = Color.ForestGreen
        Sec2_Mesa_11.BackColor = Color.ForestGreen
        Sec2_Mesa_12.BackColor = Color.ForestGreen
        Sec2_Mesa_13.BackColor = Color.ForestGreen
        Sec2_Mesa_14.BackColor = Color.ForestGreen
        Sec2_Mesa_15.BackColor = Color.ForestGreen
        Sec2_Mesa_16.BackColor = Color.ForestGreen

        ToolTip1.SetToolTip(Sec2_Mesa_1, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_2, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_3, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_4, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_5, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_6, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_7, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_8, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_9, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_10, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_11, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_12, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_13, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_14, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_15, "Mesa libre")
        ToolTip1.SetToolTip(Sec2_Mesa_16, "Mesa libre")

        'sector 3
        Sec3_Mesa_1.Visible = False
        Sec3_Mesa_2.Visible = False
        Sec3_Mesa_3.Visible = False
        Sec3_Mesa_4.Visible = False
        Sec3_Mesa_5.Visible = False
        Sec3_Mesa_6.Visible = False
        Sec3_Mesa_7.Visible = False
        Sec3_Mesa_8.Visible = False
        Sec3_Mesa_9.Visible = False
        Sec3_Mesa_10.Visible = False
        Sec3_Mesa_11.Visible = False
        Sec3_Mesa_12.Visible = False
        Sec3_Mesa_13.Visible = False
        Sec3_Mesa_14.Visible = False
        Sec3_Mesa_15.Visible = False
        Sec3_Mesa_16.Visible = False

        Sec3_Mesa_1.BackColor = Color.ForestGreen
        Sec3_Mesa_2.BackColor = Color.ForestGreen
        Sec3_Mesa_3.BackColor = Color.ForestGreen
        Sec3_Mesa_4.BackColor = Color.ForestGreen
        Sec3_Mesa_5.BackColor = Color.ForestGreen
        Sec3_Mesa_6.BackColor = Color.ForestGreen
        Sec3_Mesa_7.BackColor = Color.ForestGreen
        Sec3_Mesa_8.BackColor = Color.ForestGreen
        Sec3_Mesa_9.BackColor = Color.ForestGreen
        Sec3_Mesa_10.BackColor = Color.ForestGreen
        Sec3_Mesa_11.BackColor = Color.ForestGreen
        Sec3_Mesa_12.BackColor = Color.ForestGreen
        Sec3_Mesa_13.BackColor = Color.ForestGreen
        Sec3_Mesa_14.BackColor = Color.ForestGreen
        Sec3_Mesa_15.BackColor = Color.ForestGreen
        Sec3_Mesa_16.BackColor = Color.ForestGreen

        ToolTip1.SetToolTip(Sec3_Mesa_1, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_2, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_3, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_4, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_5, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_6, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_7, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_8, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_9, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_10, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_11, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_12, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_13, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_14, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_15, "Mesa libre")
        ToolTip1.SetToolTip(Sec3_Mesa_16, "Mesa libre")

        'sector 4
        Sec4_Mesa_1.Visible = False
        Sec4_Mesa_2.Visible = False
        Sec4_Mesa_3.Visible = False
        Sec4_Mesa_4.Visible = False
        Sec4_Mesa_5.Visible = False
        Sec4_Mesa_6.Visible = False
        Sec4_Mesa_7.Visible = False
        Sec4_Mesa_8.Visible = False
        Sec4_Mesa_9.Visible = False
        Sec4_Mesa_10.Visible = False
        Sec4_Mesa_11.Visible = False
        Sec4_Mesa_12.Visible = False
        Sec4_Mesa_13.Visible = False
        Sec4_Mesa_14.Visible = False
        Sec4_Mesa_15.Visible = False
        Sec4_Mesa_16.Visible = False

        Sec4_Mesa_1.BackColor = Color.ForestGreen
        Sec4_Mesa_2.BackColor = Color.ForestGreen
        Sec4_Mesa_3.BackColor = Color.ForestGreen
        Sec4_Mesa_4.BackColor = Color.ForestGreen
        Sec4_Mesa_5.BackColor = Color.ForestGreen
        Sec4_Mesa_6.BackColor = Color.ForestGreen
        Sec4_Mesa_7.BackColor = Color.ForestGreen
        Sec4_Mesa_8.BackColor = Color.ForestGreen
        Sec4_Mesa_9.BackColor = Color.ForestGreen
        Sec4_Mesa_10.BackColor = Color.ForestGreen
        Sec4_Mesa_11.BackColor = Color.ForestGreen
        Sec4_Mesa_12.BackColor = Color.ForestGreen
        Sec4_Mesa_13.BackColor = Color.ForestGreen
        Sec4_Mesa_14.BackColor = Color.ForestGreen
        Sec4_Mesa_15.BackColor = Color.ForestGreen
        Sec4_Mesa_16.BackColor = Color.ForestGreen

        ToolTip1.SetToolTip(Sec4_Mesa_1, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_2, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_3, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_4, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_5, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_6, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_7, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_8, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_9, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_10, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_11, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_12, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_13, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_14, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_15, "Mesa libre")
        ToolTip1.SetToolTip(Sec4_Mesa_16, "Mesa libre")
    End Sub
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
            DataGridView1.DataSource = Mesas_ds.Tables("MesasAsignadas")

            Mesas_consulta_gestion.DataGridView1.DataSource = Mesas_ds.Tables("MesasAsignadas")
            Mesas_consulta_gestion.pintar_grilla_estados()
            Mesas_consulta_gestion.DataGridView1.ClearSelection()
        End If


    End Sub
    Public Sub habilitar_mesas()
        'veo q mesas "botones" habilitar y poner en el text el nombre de la mesa.
        If Mesas_ds.Tables("MesasAsignadas").Rows.Count <> 0 Then

            Dim S1 As Integer = 0
            While S1 < Mesas_ds.Tables("MesasAsignadas").Rows.Count
                'primero para sector 1
                If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Sector_id") = "1" Then
                    Dim agregado As String = "no"
                    If Sec1_Mesa_1.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_1.Visible = True
                        Sec1_Mesa_1.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_1.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa cobrada")
                        End If
                    End If
                    If Sec1_Mesa_2.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_2.Visible = True
                        Sec1_Mesa_2.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")
                        End If

                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_2.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa cobrada")
                        End If

                    End If
                    If Sec1_Mesa_3.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_3.Visible = True
                        Sec1_Mesa_3.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")
                        End If

                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_3.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa cobrada")
                        End If

                    End If
                    If Sec1_Mesa_4.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_4.Visible = True
                        Sec1_Mesa_4.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")
                        End If

                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_4.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa cobrada")
                        End If

                    End If
                    If Sec1_Mesa_5.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_5.Visible = True
                        Sec1_Mesa_5.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")
                        End If

                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_5.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa cobrada")
                        End If

                    End If
                    If Sec1_Mesa_6.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_6.Visible = True
                        Sec1_Mesa_6.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_6.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa cobrada")
                        End If


                    End If
                    If Sec1_Mesa_7.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_7.Visible = True
                        Sec1_Mesa_7.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_7.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa cobrada")
                        End If


                    End If
                    If Sec1_Mesa_8.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_8.Visible = True
                        Sec1_Mesa_8.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_8.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa cobrada")
                        End If


                    End If
                    If Sec1_Mesa_9.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_9.Visible = True
                        Sec1_Mesa_9.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_9.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa cobrada")
                        End If


                    End If
                    If Sec1_Mesa_10.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_10.Visible = True
                        Sec1_Mesa_10.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_10.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa cobrada")
                        End If

                    End If
                    If Sec1_Mesa_11.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_11.Visible = True
                        Sec1_Mesa_11.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_11.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa cobrada")
                        End If


                    End If
                    If Sec1_Mesa_12.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_12.Visible = True
                        Sec1_Mesa_12.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_12.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa cobrada")
                        End If


                    End If
                    If Sec1_Mesa_13.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_13.Visible = True
                        Sec1_Mesa_13.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_13.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa cobrada")
                        End If


                    End If
                    If Sec1_Mesa_14.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_14.Visible = True
                        Sec1_Mesa_14.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_14.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa cobrada")
                        End If


                    End If
                    If Sec1_Mesa_15.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_15.Visible = True
                        Sec1_Mesa_15.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_15.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa cobrada")
                        End If


                    End If
                    If Sec1_Mesa_16.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec1_Mesa_16.Visible = True
                        Sec1_Mesa_16.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec1_Mesa_16.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa cobrada")
                        End If


                    End If
                End If
                S1 = S1 + 1
            End While



            'para sector 2
            S1 = 0
            While S1 < Mesas_ds.Tables("MesasAsignadas").Rows.Count
                If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Sector_id") = "2" Then
                    Dim agregado As String = "no"
                    If Sec2_Mesa_1.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_1.Visible = True
                        Sec2_Mesa_1.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_1.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_1, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_1.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_1, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_2.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_2.Visible = True
                        Sec2_Mesa_2.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_2.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_2, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_2.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_2, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_3.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_3.Visible = True
                        Sec2_Mesa_3.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_3.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_3, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_3.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_3, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_4.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_4.Visible = True
                        Sec2_Mesa_4.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_4.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_4, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_4.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_4, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_5.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_5.Visible = True
                        Sec2_Mesa_5.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_5.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_5, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_5.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_5, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_6.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_6.Visible = True
                        Sec2_Mesa_6.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_6.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_6, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_6.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_6, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_7.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_7.Visible = True
                        Sec2_Mesa_7.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_7.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_7, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_7.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_7, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_8.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_8.Visible = True
                        Sec2_Mesa_8.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_8.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_8, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_8.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_8, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_9.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_9.Visible = True
                        Sec2_Mesa_9.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_9.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_9, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_9.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_9, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_10.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_10.Visible = True
                        Sec2_Mesa_10.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_10.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_10, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_10.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_10, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_11.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_11.Visible = True
                        Sec2_Mesa_11.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_11.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_11, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_11.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_11, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_12.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_12.Visible = True
                        Sec2_Mesa_12.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_12.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_12, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_12.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_12, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_13.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_13.Visible = True
                        Sec2_Mesa_13.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_13.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_13, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_13.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_13, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_14.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_14.Visible = True
                        Sec2_Mesa_14.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_14.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_14, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_14.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_14, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_15.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_15.Visible = True
                        Sec2_Mesa_15.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_15.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_15, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_15.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_15, "Mesa cobrada")
                        End If
                    End If
                    If Sec2_Mesa_16.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec2_Mesa_16.Visible = True
                        Sec2_Mesa_16.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec2_Mesa_16.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec2_Mesa_16, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec2_Mesa_16.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec2_Mesa_16, "Mesa cobrada")
                        End If
                    End If
                End If
                S1 = S1 + 1
            End While



            'para sector 3
            S1 = 0
            While S1 < Mesas_ds.Tables("MesasAsignadas").Rows.Count
                If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Sector_id") = "3" Then
                    Dim agregado As String = "no"
                    If Sec3_Mesa_1.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_1.Visible = True
                        Sec3_Mesa_1.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_1.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_1, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_1.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_1, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_2.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_2.Visible = True
                        Sec3_Mesa_2.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_2.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_2, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_2.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_2, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_3.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_3.Visible = True
                        Sec3_Mesa_3.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_3.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_3, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_3.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_3, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_4.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_4.Visible = True
                        Sec3_Mesa_4.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_4.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_4, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_4.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_4, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_5.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_5.Visible = True
                        Sec3_Mesa_5.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_5.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_5, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_5.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_5, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_6.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_6.Visible = True
                        Sec3_Mesa_6.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_6.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_6, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_6.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_6, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_7.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_7.Visible = True
                        Sec3_Mesa_7.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_7.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_7, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_7.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_7, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_8.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_8.Visible = True
                        Sec3_Mesa_8.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_8.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_8, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_8.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_8, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_9.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_9.Visible = True
                        Sec3_Mesa_9.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_9.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_9, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_9.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_9, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_10.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_10.Visible = True
                        Sec3_Mesa_10.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_10.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_10, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_10.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_10, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_11.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_11.Visible = True
                        Sec3_Mesa_11.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_11.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_11, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_11.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_11, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_12.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_12.Visible = True
                        Sec3_Mesa_12.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_12.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_12, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_12.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_12, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_13.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_13.Visible = True
                        Sec3_Mesa_13.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_13.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_13, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_13.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_13, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_14.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_14.Visible = True
                        Sec3_Mesa_14.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_14.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_14, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_14.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_14, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_15.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_15.Visible = True
                        Sec3_Mesa_15.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_15.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_15, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_15.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_15, "Mesa cobrada")
                        End If
                    End If
                    If Sec3_Mesa_16.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec3_Mesa_16.Visible = True
                        Sec3_Mesa_16.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec3_Mesa_16.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec3_Mesa_16, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec3_Mesa_16.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec3_Mesa_16, "Mesa cobrada")
                        End If
                    End If
                End If
                S1 = S1 + 1
            End While







            'para sector 4
            S1 = 0
            While S1 < Mesas_ds.Tables("MesasAsignadas").Rows.Count
                If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Sector_id") = "4" Then
                    Dim agregado As String = "no"
                    If Sec4_Mesa_1.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_1.Visible = True
                        Sec4_Mesa_1.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_1.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_1, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_1.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_1, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_2.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_2.Visible = True
                        Sec4_Mesa_2.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_2.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_2, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_2.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_2, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_3.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_3.Visible = True
                        Sec4_Mesa_3.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_3.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_3, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_3.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_3, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_4.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_4.Visible = True
                        Sec4_Mesa_4.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_4.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_4, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_4.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_4, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_5.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_5.Visible = True
                        Sec4_Mesa_5.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_5.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_5, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_5.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_5, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_6.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_6.Visible = True
                        Sec4_Mesa_6.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_6.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_6, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_6.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_6, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_7.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_7.Visible = True
                        Sec4_Mesa_7.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_7.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_7, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_7.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_7, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_8.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_8.Visible = True
                        Sec4_Mesa_8.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_8.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_8, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_8.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_8, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_9.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_9.Visible = True
                        Sec4_Mesa_9.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_9.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_9, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_9.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_9, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_10.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_10.Visible = True
                        Sec4_Mesa_10.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_10.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_10, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_10.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_10, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_11.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_11.Visible = True
                        Sec4_Mesa_11.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_11.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_11, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_11.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_11, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_12.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_12.Visible = True
                        Sec4_Mesa_12.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_12.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_12, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_12.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_12, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_13.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_13.Visible = True
                        Sec4_Mesa_13.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_13.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_13, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_13.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_13, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_14.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_14.Visible = True
                        Sec4_Mesa_14.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_14.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_14, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_14.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_14, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_15.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_15.Visible = True
                        Sec4_Mesa_15.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_15.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_15, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_15.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_15, "Mesa cobrada")
                        End If
                    End If
                    If Sec4_Mesa_16.Visible = False And agregado = "no" Then
                        agregado = "si"
                        Sec4_Mesa_16.Visible = True
                        Sec4_Mesa_16.Text = Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("MESA_numero")
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Ocupado" Then
                            Me.Sec4_Mesa_16.BackColor = Color.IndianRed
                            ToolTip1.SetToolTip(Sec4_Mesa_16, "Mesa ocupada")
                        End If
                        If Mesas_ds.Tables("MesasAsignadas").Rows(S1).Item("Estado") = "Cobrado" Then
                            Me.Sec4_Mesa_16.BackColor = Color.CadetBlue
                            ToolTip1.SetToolTip(Sec4_Mesa_16, "Mesa cobrada")
                        End If
                    End If
                End If
                S1 = S1 + 1
            End While

        End If
    End Sub
#End Region


    Public Sub sectores_obtener_nombre()
        Dim ds_sectores As New DataSet
        ds_sectores = DAventa.Mesas_Sector_obtener()
        If ds_sectores.Tables(0).Rows.Count <> 0 Then
            Lb_sector1.Text = ds_sectores.Tables(0).Rows(0).Item("Sector_nombre_usuario")
            Lb_sector2.Text = ds_sectores.Tables(0).Rows(1).Item("Sector_nombre_usuario")
            Lb_sector3.Text = ds_sectores.Tables(0).Rows(2).Item("Sector_nombre_usuario")
            Lb_sector4.Text = ds_sectores.Tables(0).Rows(3).Item("Sector_nombre_usuario")
        End If
    End Sub

    Private Sub Mesas_gestion_2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sectores_obtener_nombre()
        recuperar_mesas()
        habilitar_mesas()
    End Sub

    Private Sub Mesa_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_1.Click
        'If Sec1_Mesa_1.BackColor = Color.ForestGreen Then
        '    Me.Sec1_Mesa_1.BackColor = Color.IndianRed
        '    ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa 1 ocupada")
        'Else
        '    Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
        '    ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa 1 libre")
        'End If

    End Sub

    Private Sub Sec1_Mesa_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_2.Click
        ''Me.Sec1_Mesa_2.BackColor = Color.IndianRed


        'If Sec1_Mesa_2.BackColor = Color.ForestGreen Then
        '    Me.Sec1_Mesa_2.BackColor = Color.IndianRed
        '    ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa 2 ocupada")
        'Else
        '    Me.Sec1_Mesa_2.BackColor = Color.ForestGreen
        '    ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa 2 libre")
        'End If

    End Sub

    Private Sub Sec1_Mesa_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_3.Click
        ''Me.Sec1_Mesa_3.BackColor = Color.IndianRed
        'If Sec1_Mesa_3.BackColor = Color.ForestGreen Then
        '    Me.Sec1_Mesa_3.BackColor = Color.IndianRed
        '    ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa 3 ocupada")
        'Else
        '    Me.Sec1_Mesa_3.BackColor = Color.ForestGreen
        '    ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa 3 libre")
        'End If

    End Sub

    Private Sub Sec1_Mesa_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_4.Click
        ''Me.Sec1_Mesa_4.BackColor = Color.IndianRed

        'If Sec1_Mesa_4.BackColor = Color.ForestGreen Then
        '    Me.Sec1_Mesa_4.BackColor = Color.IndianRed
        '    ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa 4 ocupada")
        'Else
        '    Me.Sec1_Mesa_4.BackColor = Color.ForestGreen
        '    ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa 4 libre")
        'End If
    End Sub

    Public Sub Asignar_mesa_parametros(ByVal sector_nombre As String, ByVal sector_id As Integer, ByVal mesa_nombre As Integer)
        Mesa_asignar.Show()
        Mesa_asignar.Label_sector.Text = sector_nombre
        Mesa_asignar.Label_mesa.Text = mesa_nombre


        

        'necesito LA mesa_id


        Dim I As Integer = 0
        Dim cant_mesas As Integer = Mesas_ds.Tables("MesasAsignadas").Rows.Count
        While I < Mesas_ds.Tables("MesasAsignadas").Rows.Count
            Dim sector As Integer = Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("Sector_id")

            If Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("Sector_id") = sector_id Then

                Dim mesa_idasd As Integer = Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("MESA_id")
                If Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("MESA_numero") = mesa_nombre Then
                    Mesa_asignar.MESA_id = CInt(Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("MESA_id"))
                    Mesa_asignar.Sector_id = sector_id
                    I = Mesas_ds.Tables("MesasAsignadas").Rows.Count
                End If

            End If
            I = I + 1
        End While


        'aqui paso los valores a las variables q necesito si estoy asignando una mesa a un turno
        If procedencia_turno = "si" Then
            Mesa_asignar.idclie_procendencia_mesasgestion = idclie_procendencia_turno
            Mesa_asignar.procedencia_mesasgestion = "si"
            Mesa_asignar.PAGADO_procedencia_mesasgestion = PAGADO_procedencia_turno
            Mesa_asignar.SALDO_procedencia_mesasgestion = SALDO_procedencia_turno
            Mesa_asignar.Bloquear_consumidor_selecc_cliente()
            Mesa_asignar.TURNO_id_procedencia_mesasgestion = TURNO_id_procedencia_turno

            idclie_procendencia_turno = 0
            procedencia_turno = "no"
            PAGADO_procedencia_turno = CDec(0)
            SALDO_procedencia_turno = CDec(0)
        End If


    End Sub

    Public Sub Habilitar_mesa_cobrada() 'esta se ejecuta o llama desde: MESA_cargar solo si la mesa se cobro en su totalidad
        Select Case asig_pendiente
            'MESAS DEL SECTOR - 1
            Case "Sec1_Mesa_1"
                Me.Sec1_Mesa_1.BackColor = Color.CadetBlue
                Me.ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa cobrada")

            Case "Sec1_Mesa_2"
                Me.Sec1_Mesa_2.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa cobrada")

            Case "Sec1_Mesa_3"

                Me.Sec1_Mesa_3.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa cobrada")

            Case "Sec1_Mesa_4"

                Me.Sec1_Mesa_4.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa cobrada")

            Case "Sec1_Mesa_5"

                Me.Sec1_Mesa_5.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa cobrada")

            Case "Sec1_Mesa_6"

                Me.Sec1_Mesa_6.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa cobrada")

            Case "Sec1_Mesa_7"

                Me.Sec1_Mesa_7.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa cobrada")

            Case "Sec1_Mesa_8"

                Me.Sec1_Mesa_8.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa cobrada")

            Case "Sec1_Mesa_9"

                Me.Sec1_Mesa_9.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa cobrada")

            Case "Sec1_Mesa_10"

                Me.Sec1_Mesa_10.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa cobrada")

            Case "Sec1_Mesa_11"

                Me.Sec1_Mesa_11.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa cobrada")

            Case "Sec1_Mesa_12"

                Me.Sec1_Mesa_12.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa cobrada")

            Case "Sec1_Mesa_13"

                Me.Sec1_Mesa_13.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa cobrada")

            Case "Sec1_Mesa_14"

                Me.Sec1_Mesa_14.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa cobrada")

            Case "Sec1_Mesa_15"

                Me.Sec1_Mesa_15.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa cobrada")

            Case "Sec1_Mesa_16"

                Me.Sec1_Mesa_16.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa cobrada")


                'MESAS DEL SECTOR - 2
            Case "Sec2_Mesa_1"
                Me.Sec2_Mesa_1.BackColor = Color.CadetBlue
                Me.ToolTip1.SetToolTip(Sec2_Mesa_1, "Mesa cobrada")

            Case "Sec2_Mesa_2"
                Me.Sec2_Mesa_2.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_2, "Mesa cobrada")

            Case "Sec2_Mesa_3"

                Me.Sec2_Mesa_3.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_3, "Mesa cobrada")

            Case "Sec2_Mesa_4"

                Me.Sec2_Mesa_4.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_4, "Mesa cobrada")

            Case "Sec2_Mesa_5"

                Me.Sec2_Mesa_5.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_5, "Mesa cobrada")

            Case "Sec2_Mesa_6"

                Me.Sec2_Mesa_6.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_6, "Mesa cobrada")

            Case "Sec2_Mesa_7"

                Me.Sec2_Mesa_7.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_7, "Mesa cobrada")

            Case "Sec2_Mesa_8"

                Me.Sec2_Mesa_8.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_8, "Mesa cobrada")

            Case "Sec2_Mesa_9"

                Me.Sec2_Mesa_9.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_9, "Mesa cobrada")

            Case "Sec2_Mesa_10"

                Me.Sec2_Mesa_10.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_10, "Mesa cobrada")

            Case "Sec2_Mesa_11"

                Me.Sec2_Mesa_11.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_11, "Mesa cobrada")

            Case "Sec2_Mesa_12"

                Me.Sec2_Mesa_12.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_12, "Mesa cobrada")

            Case "Sec2_Mesa_13"

                Me.Sec2_Mesa_13.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_13, "Mesa cobrada")

            Case "Sec2_Mesa_14"

                Me.Sec2_Mesa_14.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_14, "Mesa cobrada")

            Case "Sec2_Mesa_15"

                Me.Sec2_Mesa_15.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_15, "Mesa cobrada")

            Case "Sec2_Mesa_16"

                Me.Sec2_Mesa_16.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec2_Mesa_16, "Mesa cobrada")


                'MESAS DEL SECTOR - 3
            Case "Sec3_Mesa_1"
                Me.Sec3_Mesa_1.BackColor = Color.CadetBlue
                Me.ToolTip1.SetToolTip(Sec3_Mesa_1, "Mesa cobrada")

            Case "Sec3_Mesa_2"
                Me.Sec3_Mesa_2.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_2, "Mesa cobrada")

            Case "Sec3_Mesa_3"

                Me.Sec3_Mesa_3.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_3, "Mesa cobrada")

            Case "Sec3_Mesa_4"

                Me.Sec3_Mesa_4.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_4, "Mesa cobrada")

            Case "Sec3_Mesa_5"

                Me.Sec3_Mesa_5.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_5, "Mesa cobrada")

            Case "Sec3_Mesa_6"

                Me.Sec3_Mesa_6.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_6, "Mesa cobrada")

            Case "Sec3_Mesa_7"

                Me.Sec3_Mesa_7.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_7, "Mesa cobrada")

            Case "Sec3_Mesa_8"

                Me.Sec3_Mesa_8.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_8, "Mesa cobrada")

            Case "Sec3_Mesa_9"

                Me.Sec3_Mesa_9.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_9, "Mesa cobrada")

            Case "Sec3_Mesa_10"

                Me.Sec3_Mesa_10.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_10, "Mesa cobrada")

            Case "Sec3_Mesa_11"

                Me.Sec3_Mesa_11.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_11, "Mesa cobrada")

            Case "Sec3_Mesa_12"

                Me.Sec3_Mesa_12.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_12, "Mesa cobrada")

            Case "Sec3_Mesa_13"

                Me.Sec3_Mesa_13.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_13, "Mesa cobrada")

            Case "Sec3_Mesa_14"

                Me.Sec3_Mesa_14.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_14, "Mesa cobrada")

            Case "Sec3_Mesa_15"

                Me.Sec3_Mesa_15.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_15, "Mesa cobrada")

            Case "Sec3_Mesa_16"

                Me.Sec3_Mesa_16.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec3_Mesa_16, "Mesa cobrada")


                'MESAS DEL SECTOR - 4
            Case "Sec4_Mesa_1"
                Me.Sec4_Mesa_1.BackColor = Color.CadetBlue
                Me.ToolTip1.SetToolTip(Sec4_Mesa_1, "Mesa cobrada")

            Case "Sec4_Mesa_2"
                Me.Sec4_Mesa_2.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_2, "Mesa cobrada")

            Case "Sec4_Mesa_3"

                Me.Sec4_Mesa_3.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_3, "Mesa cobrada")

            Case "Sec4_Mesa_4"

                Me.Sec4_Mesa_4.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_4, "Mesa cobrada")

            Case "Sec4_Mesa_5"

                Me.Sec4_Mesa_5.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_5, "Mesa cobrada")

            Case "Sec4_Mesa_6"

                Me.Sec4_Mesa_6.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_6, "Mesa cobrada")

            Case "Sec4_Mesa_7"

                Me.Sec4_Mesa_7.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_7, "Mesa cobrada")

            Case "Sec4_Mesa_8"

                Me.Sec4_Mesa_8.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_8, "Mesa cobrada")

            Case "Sec4_Mesa_9"

                Me.Sec4_Mesa_9.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_9, "Mesa cobrada")

            Case "Sec4_Mesa_10"

                Me.Sec4_Mesa_10.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_10, "Mesa cobrada")

            Case "Sec4_Mesa_11"

                Me.Sec4_Mesa_11.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_11, "Mesa cobrada")

            Case "Sec4_Mesa_12"

                Me.Sec4_Mesa_12.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_12, "Mesa cobrada")

            Case "Sec4_Mesa_13"

                Me.Sec4_Mesa_13.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_13, "Mesa cobrada")

            Case "Sec4_Mesa_14"

                Me.Sec4_Mesa_14.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_14, "Mesa cobrada")

            Case "Sec4_Mesa_15"

                Me.Sec4_Mesa_15.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_15, "Mesa cobrada")

            Case "Sec4_Mesa_16"

                Me.Sec4_Mesa_16.BackColor = Color.CadetBlue
                ToolTip1.SetToolTip(Sec4_Mesa_16, "Mesa cobrada")

        End Select
    End Sub

    Public Sub Habilitar_asignacion_pendiente() 'esta se ejecuta o llama desde: MESA_ASIGNAR
        Select Case asig_pendiente
            'MESAS DEL SECTOR - 1
            Case "Sec1_Mesa_1"
                Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                Me.ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")

            Case "Sec1_Mesa_2"
                Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")

            Case "Sec1_Mesa_3"

                Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")

            Case "Sec1_Mesa_4"

                Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")

            Case "Sec1_Mesa_5"

                Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")

            Case "Sec1_Mesa_6"

                Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")

            Case "Sec1_Mesa_7"

                Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")

            Case "Sec1_Mesa_8"

                Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")

            Case "Sec1_Mesa_9"

                Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")

            Case "Sec1_Mesa_10"

                Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")

            Case "Sec1_Mesa_11"

                Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")

            Case "Sec1_Mesa_12"

                Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")

            Case "Sec1_Mesa_13"

                Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")

            Case "Sec1_Mesa_14"

                Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")

            Case "Sec1_Mesa_15"

                Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")

            Case "Sec1_Mesa_16"

                Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")

                'MESAS DEL SECTOR - 2
            Case "Sec2_Mesa_1"
                Me.Sec2_Mesa_1.BackColor = Color.IndianRed
                Me.ToolTip1.SetToolTip(Sec2_Mesa_1, "Mesa ocupada")

            Case "Sec2_Mesa_2"
                Me.Sec2_Mesa_2.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_2, "Mesa ocupada")

            Case "Sec2_Mesa_3"

                Me.Sec2_Mesa_3.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_3, "Mesa ocupada")

            Case "Sec2_Mesa_4"

                Me.Sec2_Mesa_4.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_4, "Mesa ocupada")

            Case "Sec2_Mesa_5"

                Me.Sec2_Mesa_5.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_5, "Mesa ocupada")

            Case "Sec2_Mesa_6"

                Me.Sec2_Mesa_6.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_6, "Mesa ocupada")

            Case "Sec2_Mesa_7"

                Me.Sec2_Mesa_7.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_7, "Mesa ocupada")

            Case "Sec2_Mesa_8"

                Me.Sec2_Mesa_8.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_8, "Mesa ocupada")

            Case "Sec2_Mesa_9"

                Me.Sec2_Mesa_9.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_9, "Mesa ocupada")

            Case "Sec2_Mesa_10"

                Me.Sec2_Mesa_10.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_10, "Mesa ocupada")

            Case "Sec2_Mesa_11"

                Me.Sec2_Mesa_11.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_11, "Mesa ocupada")

            Case "Sec2_Mesa_12"

                Me.Sec2_Mesa_12.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_12, "Mesa ocupada")

            Case "Sec2_Mesa_13"

                Me.Sec2_Mesa_13.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_13, "Mesa ocupada")

            Case "Sec2_Mesa_14"

                Me.Sec2_Mesa_14.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_14, "Mesa ocupada")

            Case "Sec2_Mesa_15"

                Me.Sec2_Mesa_15.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_15, "Mesa ocupada")

            Case "Sec2_Mesa_16"

                Me.Sec2_Mesa_16.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec2_Mesa_16, "Mesa ocupada")

                'MESAS DEL SECTOR - 3
            Case "Sec3_Mesa_1"
                Me.Sec3_Mesa_1.BackColor = Color.IndianRed
                Me.ToolTip1.SetToolTip(Sec3_Mesa_1, "Mesa ocupada")

            Case "Sec3_Mesa_2"
                Me.Sec3_Mesa_2.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_2, "Mesa ocupada")

            Case "Sec3_Mesa_3"

                Me.Sec3_Mesa_3.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_3, "Mesa ocupada")

            Case "Sec3_Mesa_4"

                Me.Sec3_Mesa_4.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_4, "Mesa ocupada")

            Case "Sec3_Mesa_5"

                Me.Sec3_Mesa_5.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_5, "Mesa ocupada")

            Case "Sec3_Mesa_6"

                Me.Sec3_Mesa_6.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_6, "Mesa ocupada")

            Case "Sec3_Mesa_7"

                Me.Sec3_Mesa_7.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_7, "Mesa ocupada")

            Case "Sec3_Mesa_8"

                Me.Sec3_Mesa_8.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_8, "Mesa ocupada")

            Case "Sec3_Mesa_9"

                Me.Sec3_Mesa_9.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_9, "Mesa ocupada")

            Case "Sec3_Mesa_10"

                Me.Sec3_Mesa_10.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_10, "Mesa ocupada")

            Case "Sec3_Mesa_11"

                Me.Sec3_Mesa_11.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_11, "Mesa ocupada")

            Case "Sec3_Mesa_12"

                Me.Sec3_Mesa_12.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_12, "Mesa ocupada")

            Case "Sec3_Mesa_13"

                Me.Sec3_Mesa_13.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_13, "Mesa ocupada")

            Case "Sec3_Mesa_14"

                Me.Sec3_Mesa_14.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_14, "Mesa ocupada")

            Case "Sec3_Mesa_15"

                Me.Sec3_Mesa_15.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_15, "Mesa ocupada")

            Case "Sec3_Mesa_16"

                Me.Sec3_Mesa_16.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec3_Mesa_16, "Mesa ocupada")




                'MESAS DEL SECTOR - 3
            Case "Sec4_Mesa_1"
                Me.Sec4_Mesa_1.BackColor = Color.IndianRed
                Me.ToolTip1.SetToolTip(Sec4_Mesa_1, "Mesa ocupada")

            Case "Sec4_Mesa_2"
                Me.Sec4_Mesa_2.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_2, "Mesa ocupada")

            Case "Sec4_Mesa_3"

                Me.Sec4_Mesa_3.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_3, "Mesa ocupada")

            Case "Sec4_Mesa_4"

                Me.Sec4_Mesa_4.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_4, "Mesa ocupada")

            Case "Sec4_Mesa_5"

                Me.Sec4_Mesa_5.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_5, "Mesa ocupada")

            Case "Sec4_Mesa_6"

                Me.Sec4_Mesa_6.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_6, "Mesa ocupada")

            Case "Sec4_Mesa_7"

                Me.Sec4_Mesa_7.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_7, "Mesa ocupada")

            Case "Sec4_Mesa_8"

                Me.Sec4_Mesa_8.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_8, "Mesa ocupada")

            Case "Sec4_Mesa_9"

                Me.Sec4_Mesa_9.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_9, "Mesa ocupada")

            Case "Sec4_Mesa_10"

                Me.Sec4_Mesa_10.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_10, "Mesa ocupada")

            Case "Sec4_Mesa_11"

                Me.Sec4_Mesa_11.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_11, "Mesa ocupada")

            Case "Sec4_Mesa_12"

                Me.Sec4_Mesa_12.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_12, "Mesa ocupada")

            Case "Sec4_Mesa_13"

                Me.Sec4_Mesa_13.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_13, "Mesa ocupada")

            Case "Sec4_Mesa_14"

                Me.Sec4_Mesa_14.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_14, "Mesa ocupada")

            Case "Sec4_Mesa_15"

                Me.Sec4_Mesa_15.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_15, "Mesa ocupada")

            Case "Sec4_Mesa_16"

                Me.Sec4_Mesa_16.BackColor = Color.IndianRed
                ToolTip1.SetToolTip(Sec4_Mesa_16, "Mesa ocupada")
        End Select
    End Sub
    Public asig_pendiente As String = ""
    Private Sub Asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asignar.Click
        asig_pendiente = mesa
        Select Case mesa
            'MESAS DEL SECTOR - 1
            Case "Sec1_Mesa_1"
                If Sec1_Mesa_1.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_1.Text)
                    'Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_2"
                If Sec1_Mesa_2.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_2.Text)
                    'Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_2.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa libre")
                End If
            Case "Sec1_Mesa_3"
                If Sec1_Mesa_3.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_3.Text)
                    'Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_3.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa libre")
                End If
            Case "Sec1_Mesa_4"
                If Sec1_Mesa_4.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_4.Text)
                    'Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_4.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa libre")
                End If
            Case "Sec1_Mesa_5"
                If Sec1_Mesa_5.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_5.Text)
                    'Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_5.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa libre")
                End If
            Case "Sec1_Mesa_6"
                If Sec1_Mesa_6.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_6.Text)
                    'Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_6.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa libre")
                End If
            Case "Sec1_Mesa_7"
                If Sec1_Mesa_7.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_7.Text)
                    'Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_7.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa libre")
                End If
            Case "Sec1_Mesa_8"
                If Sec1_Mesa_8.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_8.Text)
                    'Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_8.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa libre")
                End If
            Case "Sec1_Mesa_9"
                If Sec1_Mesa_9.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_9.Text)
                    'Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_9.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa libre")
                End If
            Case "Sec1_Mesa_10"
                If Sec1_Mesa_10.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_10.Text)
                    'Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_10.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa libre")
                End If
            Case "Sec1_Mesa_11"
                If Sec1_Mesa_11.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_11.Text)
                    'Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_11.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa libre")
                End If
            Case "Sec1_Mesa_12"
                If Sec1_Mesa_12.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_12.Text)
                    'Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_12.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa libre")
                End If
            Case "Sec1_Mesa_13"
                If Sec1_Mesa_13.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_13.Text)
                    'Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_13.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa libre")
                End If
            Case "Sec1_Mesa_14"
                If Sec1_Mesa_14.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_14.Text)
                    'Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_14.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa libre")
                End If
            Case "Sec1_Mesa_15"
                If Sec1_Mesa_15.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_15.Text)
                    'Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_15.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa libre")
                End If
            Case "Sec1_Mesa_16"
                If Sec1_Mesa_16.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_16.Text)
                    'Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_16.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa libre")
                End If


                'MESAS DEL SECTOR - 2
            Case "Sec2_Mesa_1"
                If Sec2_Mesa_1.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_1.Text)
                    'Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_2"
                If Sec2_Mesa_2.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_2.Text)
                    'Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_2.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa libre")
                End If
            Case "Sec2_Mesa_3"
                If Sec2_Mesa_3.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_3.Text)
                    'Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_3.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa libre")
                End If
            Case "Sec2_Mesa_4"
                If Sec2_Mesa_4.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_4.Text)
                    'Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_4.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa libre")
                End If
            Case "Sec2_Mesa_5"
                If Sec2_Mesa_5.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_5.Text)
                    'Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_5.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa libre")
                End If
            Case "Sec2_Mesa_6"
                If Sec2_Mesa_6.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_6.Text)
                    'Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_6.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa libre")
                End If
            Case "Sec2_Mesa_7"
                If Sec2_Mesa_7.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_7.Text)
                    'Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_7.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa libre")
                End If
            Case "Sec2_Mesa_8"
                If Sec2_Mesa_8.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_8.Text)
                    'Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_8.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa libre")
                End If
            Case "Sec2_Mesa_9"
                If Sec2_Mesa_9.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_9.Text)
                    'Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_9.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa libre")
                End If
            Case "Sec2_Mesa_10"
                If Sec2_Mesa_10.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_10.Text)
                    'Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_10.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa libre")
                End If
            Case "Sec2_Mesa_11"
                If Sec2_Mesa_11.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_11.Text)
                    'Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_11.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa libre")
                End If
            Case "Sec2_Mesa_12"
                If Sec2_Mesa_12.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_12.Text)
                    'Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_12.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa libre")
                End If
            Case "Sec2_Mesa_13"
                If Sec2_Mesa_13.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_13.Text)
                    'Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_13.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa libre")
                End If
            Case "Sec2_Mesa_14"
                If Sec2_Mesa_14.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_14.Text)
                    'Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_14.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa libre")
                End If
            Case "Sec2_Mesa_15"
                If Sec2_Mesa_15.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_15.Text)
                    'Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_15.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa libre")
                End If
            Case "Sec2_Mesa_16"
                If Sec2_Mesa_16.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_16.Text)
                    'Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_16.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa libre")
                End If

                'MESAS DEL SECTOR - 3
            Case "Sec3_Mesa_1"
                If Sec3_Mesa_1.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_1.Text)
                    'Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_2"
                If Sec3_Mesa_2.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_2.Text)
                    'Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_2.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa libre")
                End If
            Case "Sec3_Mesa_3"
                If Sec3_Mesa_3.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_3.Text)
                    'Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_3.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa libre")
                End If
            Case "Sec3_Mesa_4"
                If Sec3_Mesa_4.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_4.Text)
                    'Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_4.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa libre")
                End If
            Case "Sec3_Mesa_5"
                If Sec3_Mesa_5.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_5.Text)
                    'Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_5.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa libre")
                End If
            Case "Sec3_Mesa_6"
                If Sec3_Mesa_6.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_6.Text)
                    'Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_6.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa libre")
                End If
            Case "Sec3_Mesa_7"
                If Sec3_Mesa_7.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_7.Text)
                    'Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_7.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa libre")
                End If
            Case "Sec3_Mesa_8"
                If Sec3_Mesa_8.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_8.Text)
                    'Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_8.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa libre")
                End If
            Case "Sec3_Mesa_9"
                If Sec3_Mesa_9.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_9.Text)
                    'Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_9.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa libre")
                End If
            Case "Sec3_Mesa_10"
                If Sec3_Mesa_10.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_10.Text)
                    'Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_10.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa libre")
                End If
            Case "Sec3_Mesa_11"
                If Sec3_Mesa_11.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_11.Text)
                    'Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_11.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa libre")
                End If
            Case "Sec3_Mesa_12"
                If Sec3_Mesa_12.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_12.Text)
                    'Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_12.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa libre")
                End If
            Case "Sec3_Mesa_13"
                If Sec3_Mesa_13.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_13.Text)
                    'Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_13.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa libre")
                End If
            Case "Sec3_Mesa_14"
                If Sec3_Mesa_14.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_14.Text)
                    'Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_14.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa libre")
                End If
            Case "Sec3_Mesa_15"
                If Sec3_Mesa_15.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_15.Text)
                    'Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_15.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa libre")
                End If
            Case "Sec3_Mesa_16"
                If Sec3_Mesa_16.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_16.Text)
                    'Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_16.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa libre")
                End If






                'MESAS DEL SECTOR - 4
            Case "Sec4_Mesa_1"
                If Sec4_Mesa_1.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_1.Text)
                    'Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_2"
                If Sec4_Mesa_2.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_2.Text)
                    'Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_2.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa libre")
                End If
            Case "Sec4_Mesa_3"
                If Sec4_Mesa_3.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_3.Text)
                    'Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_3.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa libre")
                End If
            Case "Sec4_Mesa_4"
                If Sec4_Mesa_4.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_4.Text)
                    'Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_4.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa libre")
                End If
            Case "Sec4_Mesa_5"
                If Sec4_Mesa_5.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_5.Text)
                    'Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_5.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa libre")
                End If
            Case "Sec4_Mesa_6"
                If Sec4_Mesa_6.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_6.Text)
                    'Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_6.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa libre")
                End If
            Case "Sec4_Mesa_7"
                If Sec4_Mesa_7.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_7.Text)
                    'Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_7.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa libre")
                End If
            Case "Sec4_Mesa_8"
                If Sec4_Mesa_8.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_8.Text)
                    'Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_8.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa libre")
                End If
            Case "Sec4_Mesa_9"
                If Sec4_Mesa_9.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_9.Text)
                    'Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_9.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa libre")
                End If
            Case "Sec4_Mesa_10"
                If Sec4_Mesa_10.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_10.Text)
                    'Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_10.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa libre")
                End If
            Case "Sec4_Mesa_11"
                If Sec4_Mesa_11.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_11.Text)
                    'Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_11.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa libre")
                End If
            Case "Sec4_Mesa_12"
                If Sec4_Mesa_12.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_12.Text)
                    'Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_12.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa libre")
                End If
            Case "Sec4_Mesa_13"
                If Sec4_Mesa_13.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_13.Text)
                    'Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_13.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa libre")
                End If
            Case "Sec4_Mesa_14"
                If Sec4_Mesa_14.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_14.Text)
                    'Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_14.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa libre")
                End If
            Case "Sec4_Mesa_15"
                If Sec4_Mesa_15.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_15.Text)
                    'Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_15.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa libre")
                End If
            Case "Sec4_Mesa_16"
                If Sec4_Mesa_16.BackColor = Color.ForestGreen Then
                    Call Asignar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_16.Text)
                    'Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")
                Else
                    MessageBox.Show("La mesa ya ha sido asignada", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_16.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa libre")
                End If

        End Select
    End Sub
    Public Sub Cargar_mesa_parametros(ByVal sector_nombre As String, ByVal sector_id As Integer, ByVal mesa_nombre As Integer)

        Mesa_cargar.Label_sector.Text = sector_nombre
        Mesa_cargar.Label_mesa.Text = mesa_nombre

        'necesito LA mesa_id


        Dim I As Integer = 0
        Dim cant_mesas As Integer = Mesas_ds.Tables("MesasAsignadas").Rows.Count
        While I < Mesas_ds.Tables("MesasAsignadas").Rows.Count
            Dim sector As Integer = Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("Sector_id")

            If Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("Sector_id") = sector_id Then

                Dim mesa_idasd As Integer = Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("MESA_id")
                If Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("MESA_numero") = mesa_nombre Then

                    'Mesa_asignar.MESA_id = CInt(Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("MESA_id"))
                    Dim ventaprod_id As Integer = CInt(Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("Ventaprod_id"))
                    Dim pago_parcial As Decimal = CDec(Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("Pago_parcial"))
                    Mesa_cargar.Text = "Cargar productos en mesa - Cliente:" + " " + Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("Cliente")


                    Mesa_cargar.Ventaprod_id = ventaprod_id
                    Mesa_cargar.pago_parcial = pago_parcial
                    Mesa_cargar.mesa_id = CInt(Mesas_ds.Tables("MesasAsignadas").Rows(I).Item("MESA_id"))
                    Mesa_cargar.sector_id = sector_id



                    Dim ds_venta_mesa As DataSet = DAventa.VentaProducto_buscar(ventaprod_id)
                    If ds_venta_mesa.Tables(1).Rows.Count <> 0 Then

                        Mesa_cargar.cliente_id = ds_venta_mesa.Tables(1).Rows(0).Item("cliente_id")
                        Mesa_cargar.tipo_vta = "Cliente"

                    Else
                        Mesa_cargar.cliente_id = 0
                        Mesa_cargar.tipo_vta = "Consumidor Final"
                    End If
                    I = Mesas_ds.Tables("MesasAsignadas").Rows.Count
                End If


            End If


            I = I + 1
        End While
        Mesa_cargar.Show()

        Mesa_cargar.Abrir_mesa()


    End Sub
    Private Sub CargarMesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarMesa.Click
        asig_pendiente = mesa
        Select Case mesa
            'MESAS DEL SECTOR - 1
            Case "Sec1_Mesa_1"
                If Sec1_Mesa_1.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_1.Text)
                    'Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")
                Else
                    If Sec1_Mesa_1.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_2"
                If Sec1_Mesa_2.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_2.Text)
                    'Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")
                Else
                    If Sec1_Mesa_2.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_3"
                If Sec1_Mesa_3.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_3.Text)
                    'Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")
                Else
                    If Sec1_Mesa_3.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_4"
                If Sec1_Mesa_4.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_4.Text)
                    'Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")
                Else
                    If Sec1_Mesa_4.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_5"
                If Sec1_Mesa_5.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_5.Text)
                    'Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")
                Else
                    If Sec1_Mesa_5.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_6"
                If Sec1_Mesa_6.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_6.Text)
                    'Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")
                Else
                    If Sec1_Mesa_6.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_7"
                If Sec1_Mesa_7.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_7.Text)
                    'Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")
                Else
                    If Sec1_Mesa_7.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_8"
                If Sec1_Mesa_8.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_8.Text)
                    'Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")
                Else
                    If Sec1_Mesa_8.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_9"
                If Sec1_Mesa_9.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_9.Text)
                    'Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")
                Else
                    If Sec1_Mesa_9.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_10"
                If Sec1_Mesa_10.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_10.Text)
                    'Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")
                Else
                    If Sec1_Mesa_10.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_11"
                If Sec1_Mesa_11.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_11.Text)
                    'Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")
                Else
                    If Sec1_Mesa_11.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_12"
                If Sec1_Mesa_12.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_12.Text)
                    'Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")
                Else
                    If Sec1_Mesa_12.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_13"
                If Sec1_Mesa_13.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_13.Text)
                    'Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")
                Else
                    If Sec1_Mesa_13.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_14"
                If Sec1_Mesa_14.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_14.Text)
                    'Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")
                Else
                    If Sec1_Mesa_14.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_15"
                If Sec1_Mesa_15.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_15.Text)
                    'Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")
                Else
                    If Sec1_Mesa_15.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec1_Mesa_16"
                If Sec1_Mesa_16.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector1.Text, "1", Sec1_Mesa_16.Text)
                    'Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")
                Else
                    If Sec1_Mesa_16.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If



                'MESAS DEL SECTOR - 2
            Case "Sec2_Mesa_1"
                If Sec2_Mesa_1.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_1.Text)
                    'Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")
                Else
                    If Sec2_Mesa_1.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_2"
                If Sec2_Mesa_2.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_2.Text)
                    'Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")
                Else
                    If Sec2_Mesa_2.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_3"
                If Sec2_Mesa_3.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_3.Text)
                    'Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")
                Else
                    If Sec2_Mesa_3.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_4"
                If Sec2_Mesa_4.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_4.Text)
                    'Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")
                Else
                    If Sec2_Mesa_4.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_5"
                If Sec2_Mesa_5.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_5.Text)
                    'Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")
                Else
                    If Sec2_Mesa_5.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_6"
                If Sec2_Mesa_6.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_6.Text)
                    'Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")
                Else
                    If Sec2_Mesa_6.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_7"
                If Sec2_Mesa_7.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_7.Text)
                    'Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")
                Else
                    If Sec2_Mesa_7.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_8"
                If Sec2_Mesa_8.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_8.Text)
                    'Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")
                Else
                    If Sec2_Mesa_8.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_9"
                If Sec2_Mesa_9.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_9.Text)
                    'Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")
                Else
                    If Sec2_Mesa_9.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_10"
                If Sec2_Mesa_10.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_10.Text)
                    'Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")
                Else
                    If Sec2_Mesa_10.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_11"
                If Sec2_Mesa_11.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_11.Text)
                    'Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")
                Else
                    If Sec2_Mesa_11.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_12"
                If Sec2_Mesa_12.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_12.Text)
                    'Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")
                Else
                    If Sec2_Mesa_12.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_13"
                If Sec2_Mesa_13.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_13.Text)
                    'Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")
                Else
                    If Sec2_Mesa_13.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_14"
                If Sec2_Mesa_14.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_14.Text)
                    'Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")
                Else
                    If Sec2_Mesa_14.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_15"
                If Sec2_Mesa_15.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_15.Text)
                    'Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")
                Else
                    If Sec2_Mesa_15.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec2_Mesa_16"
                If Sec2_Mesa_16.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector2.Text, "2", Sec2_Mesa_16.Text)
                    'Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")
                Else
                    If Sec2_Mesa_16.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If






                'MESAS DEL SECTOR - 3
            Case "Sec3_Mesa_1"
                If Sec3_Mesa_1.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_1.Text)
                    'Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")
                Else
                    If Sec3_Mesa_1.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_2"
                If Sec3_Mesa_2.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_2.Text)
                    'Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")
                Else
                    If Sec3_Mesa_2.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_3"
                If Sec3_Mesa_3.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_3.Text)
                    'Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")
                Else
                    If Sec3_Mesa_3.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_4"
                If Sec3_Mesa_4.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_4.Text)
                    'Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")
                Else
                    If Sec3_Mesa_4.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_5"
                If Sec3_Mesa_5.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_5.Text)
                    'Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")
                Else
                    If Sec3_Mesa_5.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_6"
                If Sec3_Mesa_6.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_6.Text)
                    'Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")
                Else
                    If Sec3_Mesa_6.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_7"
                If Sec3_Mesa_7.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_7.Text)
                    'Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")
                Else
                    If Sec3_Mesa_7.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_8"
                If Sec3_Mesa_8.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_8.Text)
                    'Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")
                Else
                    If Sec3_Mesa_8.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_9"
                If Sec3_Mesa_9.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_9.Text)
                    'Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")
                Else
                    If Sec3_Mesa_9.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_10"
                If Sec3_Mesa_10.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_10.Text)
                    'Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")
                Else
                    If Sec3_Mesa_10.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_11"
                If Sec3_Mesa_11.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_11.Text)
                    'Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")
                Else
                    If Sec3_Mesa_11.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_12"
                If Sec3_Mesa_12.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_12.Text)
                    'Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")
                Else
                    If Sec3_Mesa_12.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_13"
                If Sec3_Mesa_13.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_13.Text)
                    'Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")
                Else
                    If Sec3_Mesa_13.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_14"
                If Sec3_Mesa_14.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_14.Text)
                    'Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")
                Else
                    If Sec3_Mesa_14.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_15"
                If Sec3_Mesa_15.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_15.Text)
                    'Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")
                Else
                    If Sec3_Mesa_15.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec3_Mesa_16"
                If Sec3_Mesa_16.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector3.Text, "3", Sec3_Mesa_16.Text)
                    'Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")
                Else
                    If Sec3_Mesa_16.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If




                'MESAS DEL SECTOR - 4
            Case "Sec4_Mesa_1"
                If Sec4_Mesa_1.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_1.Text)
                    'Me.Sec1_Mesa_1.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa ocupada")
                Else
                    If Sec4_Mesa_1.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_2"
                If Sec4_Mesa_2.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_2.Text)
                    'Me.Sec1_Mesa_2.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa ocupada")
                Else
                    If Sec4_Mesa_2.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_3"
                If Sec4_Mesa_3.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_3.Text)
                    'Me.Sec1_Mesa_3.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa ocupada")
                Else
                    If Sec4_Mesa_3.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_4"
                If Sec4_Mesa_4.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_4.Text)
                    'Me.Sec1_Mesa_4.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa ocupada")
                Else
                    If Sec4_Mesa_4.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_5"
                If Sec4_Mesa_5.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_5.Text)
                    'Me.Sec1_Mesa_5.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa ocupada")
                Else
                    If Sec4_Mesa_5.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_6"
                If Sec4_Mesa_6.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_6.Text)
                    'Me.Sec1_Mesa_6.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa ocupada")
                Else
                    If Sec4_Mesa_6.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_7"
                If Sec4_Mesa_7.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_7.Text)
                    'Me.Sec1_Mesa_7.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa ocupada")
                Else
                    If Sec4_Mesa_7.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_8"
                If Sec4_Mesa_8.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_8.Text)
                    'Me.Sec1_Mesa_8.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa ocupada")
                Else
                    If Sec4_Mesa_8.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_9"
                If Sec4_Mesa_9.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_9.Text)
                    'Me.Sec1_Mesa_9.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa ocupada")
                Else
                    If Sec4_Mesa_9.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_10"
                If Sec4_Mesa_10.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_10.Text)
                    'Me.Sec1_Mesa_10.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa ocupada")
                Else
                    If Sec4_Mesa_10.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_11"
                If Sec4_Mesa_11.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_11.Text)
                    'Me.Sec1_Mesa_11.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa ocupada")
                Else
                    If Sec4_Mesa_11.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_12"
                If Sec4_Mesa_12.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_12.Text)
                    'Me.Sec1_Mesa_12.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa ocupada")
                Else
                    If Sec4_Mesa_12.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_13"
                If Sec4_Mesa_13.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_13.Text)
                    'Me.Sec1_Mesa_13.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa ocupada")
                Else
                    If Sec4_Mesa_13.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_14"
                If Sec4_Mesa_14.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_14.Text)
                    'Me.Sec1_Mesa_14.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa ocupada")
                Else
                    If Sec4_Mesa_14.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_15"
                If Sec4_Mesa_15.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_15.Text)
                    'Me.Sec1_Mesa_15.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa ocupada")
                Else
                    If Sec4_Mesa_15.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
            Case "Sec4_Mesa_16"
                If Sec4_Mesa_16.BackColor = Color.IndianRed Then
                    Call Cargar_mesa_parametros(Lb_sector4.Text, "4", Sec4_Mesa_16.Text)
                    'Me.Sec1_Mesa_16.BackColor = Color.IndianRed
                    'ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa ocupada")
                Else
                    If Sec4_Mesa_16.BackColor = Color.CadetBlue Then
                        MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                    Else
                        MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                    End If
                End If
        End Select
    End Sub


#Region "FOCO MOUSE MESAS" 'CUANDO PONEMOS EL PUNTERO SOBRE LA MESA...SE ACTUALIZA EL VALOR DE LA VARIABLE MESAM necesaria para el menu contextual
    Dim mesa As String = ""
    Private Sub Sec1_Mesa_1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_1.MouseEnter
        mesa = "Sec1_Mesa_1"
    End Sub
    Private Sub Sec1_Mesa_2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_2.MouseEnter
        mesa = "Sec1_Mesa_2"
    End Sub
    Private Sub Sec1_Mesa_3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_3.MouseEnter
        mesa = "Sec1_Mesa_3"
    End Sub
    Private Sub Sec1_Mesa_4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_4.MouseEnter
        mesa = "Sec1_Mesa_4"
    End Sub
    Private Sub Sec1_Mesa_5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_5.MouseEnter
        mesa = "Sec1_Mesa_5"
    End Sub
    Private Sub Sec1_Mesa_6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_6.MouseEnter
        mesa = "Sec1_Mesa_6"
    End Sub
    Private Sub Sec1_Mesa_7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_7.MouseEnter
        mesa = "Sec1_Mesa_7"
    End Sub
    Private Sub Sec1_Mesa_8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_8.MouseEnter
        mesa = "Sec1_Mesa_8"
    End Sub
    Private Sub Sec1_Mesa_9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_9.MouseEnter
        mesa = "Sec1_Mesa_9"
    End Sub
    Private Sub Sec1_Mesa_10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_10.MouseEnter
        mesa = "Sec1_Mesa_10"
    End Sub
    Private Sub Sec1_Mesa_11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_11.MouseEnter
        mesa = "Sec1_Mesa_11"
    End Sub
    Private Sub Sec1_Mesa_12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_12.MouseEnter
        mesa = "Sec1_Mesa_12"
    End Sub
    Private Sub Sec1_Mesa_13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_13.MouseEnter
        mesa = "Sec1_Mesa_13"
    End Sub
    Private Sub Sec1_Mesa_14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_14.MouseEnter
        mesa = "Sec1_Mesa_14"
    End Sub
    Private Sub Sec1_Mesa_15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_15.MouseEnter
        mesa = "Sec1_Mesa_15"
    End Sub
    Private Sub Sec1_Mesa_16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec1_Mesa_16.MouseEnter
        mesa = "Sec1_Mesa_16"
    End Sub
    Private Sub Sec2_Mesa_1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_1.MouseEnter
        mesa = "Sec2_Mesa_1"
    End Sub
    Private Sub Sec2_Mesa_2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_2.MouseEnter
        mesa = "Sec2_Mesa_2"
    End Sub
    Private Sub Sec2_Mesa_3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_3.MouseEnter
        mesa = "Sec2_Mesa_3"
    End Sub
    Private Sub Sec2_Mesa_4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_4.MouseEnter
        mesa = "Sec2_Mesa_4"
    End Sub
    Private Sub Sec2_Mesa_5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_5.MouseEnter
        mesa = "Sec2_Mesa_5"
    End Sub
    Private Sub Sec2_Mesa_6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_6.MouseEnter
        mesa = "Sec2_Mesa_6"
    End Sub
    Private Sub Sec2_Mesa_7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_7.MouseEnter
        mesa = "Sec2_Mesa_7"
    End Sub
    Private Sub Sec2_Mesa_8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_8.MouseEnter
        mesa = "Sec2_Mesa_8"
    End Sub
    Private Sub Sec2_Mesa_9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_9.MouseEnter
        mesa = "Sec2_Mesa_9"
    End Sub
    Private Sub Sec2_Mesa_10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_10.MouseEnter
        mesa = "Sec2_Mesa_10"
    End Sub
    Private Sub Sec2_Mesa_11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_11.MouseEnter
        mesa = "Sec2_Mesa_11"
    End Sub
    Private Sub Sec2_Mesa_12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_12.MouseEnter
        mesa = "Sec2_Mesa_12"
    End Sub
    Private Sub Sec2_Mesa_13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_13.MouseEnter
        mesa = "Sec2_Mesa_13"
    End Sub
    Private Sub Sec2_Mesa_14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_14.MouseEnter
        mesa = "Sec2_Mesa_14"
    End Sub
    Private Sub Sec2_Mesa_15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_15.MouseEnter
        mesa = "Sec2_Mesa_15"
    End Sub
    Private Sub Sec2_Mesa_16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec2_Mesa_16.MouseEnter
        mesa = "Sec2_Mesa_16"
    End Sub
    Private Sub Sec3_Mesa_1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_1.MouseEnter
        mesa = "Sec3_Mesa_1"
    End Sub
    Private Sub Sec3_Mesa_2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_2.MouseEnter
        mesa = "Sec3_Mesa_2"
    End Sub
    Private Sub Sec3_Mesa_3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_3.MouseEnter
        mesa = "Sec3_Mesa_3"
    End Sub
    Private Sub Sec3_Mesa_4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_4.MouseEnter
        mesa = "Sec3_Mesa_4"
    End Sub
    Private Sub Sec3_Mesa_5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_5.MouseEnter
        mesa = "Sec3_Mesa_5"
    End Sub
    Private Sub Sec3_Mesa_6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_6.MouseEnter
        mesa = "Sec3_Mesa_6"
    End Sub
    Private Sub Sec3_Mesa_7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_7.MouseEnter
        mesa = "Sec3_Mesa_7"
    End Sub
    Private Sub Sec3_Mesa_8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_8.MouseEnter
        mesa = "Sec3_Mesa_8"
    End Sub
    Private Sub Sec3_Mesa_9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_9.MouseEnter
        mesa = "Sec3_Mesa_9"
    End Sub
    Private Sub Sec3_Mesa_10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_10.MouseEnter
        mesa = "Sec3_Mesa_10"
    End Sub
    Private Sub Sec3_Mesa_11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_11.MouseEnter
        mesa = "Sec3_Mesa_11"
    End Sub
    Private Sub Sec3_Mesa_12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_12.MouseEnter
        mesa = "Sec3_Mesa_12"
    End Sub
    Private Sub Sec3_Mesa_13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_13.MouseEnter
        mesa = "Sec3_Mesa_13"
    End Sub
    Private Sub Sec3_Mesa_14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_14.MouseEnter
        mesa = "Sec3_Mesa_14"
    End Sub
    Private Sub Sec3_Mesa_15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_15.MouseEnter
        mesa = "Sec3_Mesa_15"
    End Sub
    Private Sub Sec3_Mesa_16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec3_Mesa_16.MouseEnter
        mesa = "Sec3_Mesa_16"
    End Sub
    Private Sub Sec4_Mesa_1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_1.MouseEnter
        mesa = "Sec4_Mesa_1"
    End Sub
    Private Sub Sec4_Mesa_2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_2.MouseEnter
        mesa = "Sec4_Mesa_2"
    End Sub
    Private Sub Sec4_Mesa_3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_3.MouseEnter
        mesa = "Sec4_Mesa_3"
    End Sub
    Private Sub Sec4_Mesa_4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_4.MouseEnter
        mesa = "Sec4_Mesa_4"
    End Sub
    Private Sub Sec4_Mesa_5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_5.MouseEnter
        mesa = "Sec4_Mesa_5"
    End Sub
    Private Sub Sec4_Mesa_6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_6.MouseEnter
        mesa = "Sec4_Mesa_6"
    End Sub
    Private Sub Sec4_Mesa_7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_7.MouseEnter
        mesa = "Sec4_Mesa_7"
    End Sub
    Private Sub Sec4_Mesa_8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_8.MouseEnter
        mesa = "Sec4_Mesa_8"
    End Sub
    Private Sub Sec4_Mesa_9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_9.MouseEnter
        mesa = "Sec4_Mesa_9"
    End Sub
    Private Sub Sec4_Mesa_10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_10.MouseEnter
        mesa = "Sec4_Mesa_10"
    End Sub
    Private Sub Sec4_Mesa_11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_11.MouseEnter
        mesa = "Sec4_Mesa_11"
    End Sub
    Private Sub Sec4_Mesa_12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_12.MouseEnter
        mesa = "Sec4_Mesa_12"
    End Sub
    Private Sub Sec4_Mesa_13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_13.MouseEnter
        mesa = "Sec4_Mesa_13"
    End Sub
    Private Sub Sec4_Mesa_14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_14.MouseEnter
        mesa = "Sec4_Mesa_14"
    End Sub
    Private Sub Sec4_Mesa_15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_15.MouseEnter
        mesa = "Sec4_Mesa_15"
    End Sub
    Private Sub Sec4_Mesa_16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sec4_Mesa_16.MouseEnter
        mesa = "Sec4_Mesa_16"
    End Sub
#End Region


    Public Sub Liberar_mesa(ByVal MESA_numero As Integer, ByVal Sector_id As Integer)

        Dim i As Integer = 0

        While i < Mesas_ds.Tables("MesasAsignadas").Rows.Count
            Dim sector As Integer = Mesas_ds.Tables("MesasAsignadas").Rows(i).Item("Sector_id")
            If Mesas_ds.Tables("MesasAsignadas").Rows(i).Item("Sector_id") = Sector_id Then

                Dim mesa_idasd As Integer = Mesas_ds.Tables("MesasAsignadas").Rows(i).Item("MESA_id")
                If Mesas_ds.Tables("MesasAsignadas").Rows(i).Item("MESA_numero") = MESA_numero Then
                    Dim MESA_id = CInt(Mesas_ds.Tables("MesasAsignadas").Rows(i).Item("MESA_id"))
                    DAventa.MESAS_modificar(MESA_id, MESA_numero, "Libre", "Si", "0")
                    i = Mesas_ds.Tables("MesasAsignadas").Rows.Count
                End If

            End If
            i = i + 1
        End While

        'Deshabilitar_mesas()
        recuperar_mesas()
        'habilitar_mesas()

    End Sub

    Private Sub Liberar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Liberar.Click
        'MESAS SECTOR 1 - - - - - LIBERAR SI ESTAN COBRADAS SOLAMENTE....PONE EN VERDE LIBRE....Y LOS MONTOS SE PONEN EN 0,00...

        Select Case mesa
            Case "Sec1_Mesa_1"
                'If Sec1_Mesa_8.BackColor = Color.CadetBlue Then

                If Sec1_Mesa_1.BackColor = Color.CadetBlue Then
                    Liberar_mesa("1", "1")
                    Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")

                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_2"
                If Sec1_Mesa_2.BackColor = Color.CadetBlue Then
                    Liberar_mesa("2", "1")
                    Me.Sec1_Mesa_2.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_2, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")

                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")

                End If
            Case "Sec1_Mesa_3"
                If Sec1_Mesa_3.BackColor = Color.CadetBlue Then
                    Liberar_mesa("3", "1")
                    Me.Sec1_Mesa_3.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_3, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_4"
                If Sec1_Mesa_4.BackColor = Color.CadetBlue Then
                    Liberar_mesa("4", "1")
                    Me.Sec1_Mesa_4.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_4, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_5"
                If Sec1_Mesa_5.BackColor = Color.CadetBlue Then
                    Liberar_mesa("5", "1")
                    Me.Sec1_Mesa_5.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_5, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_6"
                If Sec1_Mesa_6.BackColor = Color.CadetBlue Then
                    Liberar_mesa("6", "1")
                    Me.Sec1_Mesa_6.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_6, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_7"
                If Sec1_Mesa_7.BackColor = Color.CadetBlue Then
                    Liberar_mesa("7", "1")
                    Me.Sec1_Mesa_7.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_7, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_8"
                If Sec1_Mesa_8.BackColor = Color.CadetBlue Then
                    Liberar_mesa("8", "1")
                    Me.Sec1_Mesa_8.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_8, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_9"
                If Sec1_Mesa_9.BackColor = Color.CadetBlue Then
                    Liberar_mesa("9", "1")
                    Me.Sec1_Mesa_9.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_9, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_10"
                If Sec1_Mesa_10.BackColor = Color.CadetBlue Then
                    Liberar_mesa("10", "1")
                    Me.Sec1_Mesa_10.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_10, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_11"
                If Sec1_Mesa_11.BackColor = Color.CadetBlue Then
                    Liberar_mesa("11", "1")
                    Me.Sec1_Mesa_11.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_11, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_12"
                If Sec1_Mesa_12.BackColor = Color.CadetBlue Then
                    Liberar_mesa("12", "1")
                    Me.Sec1_Mesa_12.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_12, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_13"
                If Sec1_Mesa_13.BackColor = Color.CadetBlue Then
                    Liberar_mesa("13", "1")
                    Me.Sec1_Mesa_13.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_13, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_14"
                If Sec1_Mesa_14.BackColor = Color.CadetBlue Then
                    Liberar_mesa("14", "1")
                    Me.Sec1_Mesa_14.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_14, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_15"
                If Sec1_Mesa_15.BackColor = Color.CadetBlue Then
                    Liberar_mesa("15", "1")
                    Me.Sec1_Mesa_15.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_15, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec1_Mesa_16"
                If Sec1_Mesa_16.BackColor = Color.CadetBlue Then
                    Liberar_mesa("16", "1")
                    Me.Sec1_Mesa_16.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec1_Mesa_16, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If

                '--SECTOR 2

            Case "Sec2_Mesa_1"
                'If Sec1_Mesa_8.BackColor = Color.CadetBlue Then

                If Sec2_Mesa_1.BackColor = Color.CadetBlue Then
                    Liberar_mesa("1", "2")
                    Me.Sec2_Mesa_1.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_1, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")

                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_2"
                If Sec2_Mesa_2.BackColor = Color.CadetBlue Then
                    Liberar_mesa("2", "2")
                    Me.Sec2_Mesa_2.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_2, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")

                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")

                End If
            Case "Sec2_Mesa_3"
                If Sec2_Mesa_3.BackColor = Color.CadetBlue Then
                    Liberar_mesa("3", "2")
                    Me.Sec2_Mesa_3.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_3, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_4"
                If Sec2_Mesa_4.BackColor = Color.CadetBlue Then
                    Liberar_mesa("4", "2")
                    Me.Sec2_Mesa_4.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_4, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_5"
                If Sec2_Mesa_5.BackColor = Color.CadetBlue Then
                    Liberar_mesa("5", "2")
                    Me.Sec2_Mesa_5.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_5, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_6"
                If Sec2_Mesa_6.BackColor = Color.CadetBlue Then
                    Liberar_mesa("6", "2")
                    Me.Sec2_Mesa_6.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_6, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_7"
                If Sec2_Mesa_7.BackColor = Color.CadetBlue Then
                    Liberar_mesa("7", "2")
                    Me.Sec2_Mesa_7.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_7, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_8"
                If Sec2_Mesa_8.BackColor = Color.CadetBlue Then
                    Liberar_mesa("8", "2")
                    Me.Sec2_Mesa_8.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_8, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_9"
                If Sec2_Mesa_9.BackColor = Color.CadetBlue Then
                    Liberar_mesa("9", "2")
                    Me.Sec2_Mesa_9.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_9, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_10"
                If Sec2_Mesa_10.BackColor = Color.CadetBlue Then
                    Liberar_mesa("10", "2")
                    Me.Sec2_Mesa_10.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_10, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_11"
                If Sec2_Mesa_11.BackColor = Color.CadetBlue Then
                    Liberar_mesa("11", "2")
                    Me.Sec2_Mesa_11.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_11, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_12"
                If Sec2_Mesa_12.BackColor = Color.CadetBlue Then
                    Liberar_mesa("12", "2")
                    Me.Sec2_Mesa_12.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_12, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_13"
                If Sec2_Mesa_13.BackColor = Color.CadetBlue Then
                    Liberar_mesa("13", "2")
                    Me.Sec2_Mesa_13.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_13, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_14"
                If Sec2_Mesa_14.BackColor = Color.CadetBlue Then
                    Liberar_mesa("14", "2")
                    Me.Sec2_Mesa_14.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_14, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_15"
                If Sec2_Mesa_15.BackColor = Color.CadetBlue Then
                    Liberar_mesa("15", "2")
                    Me.Sec2_Mesa_15.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_15, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec2_Mesa_16"
                If Sec2_Mesa_16.BackColor = Color.CadetBlue Then
                    Liberar_mesa("16", "2")
                    Me.Sec2_Mesa_16.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec2_Mesa_16, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If





                '--SECTOR 3

            Case "Sec3_Mesa_1"
                'If Sec1_Mesa_8.BackColor = Color.CadetBlue Then

                If Sec3_Mesa_1.BackColor = Color.CadetBlue Then
                    Liberar_mesa("1", "3")
                    Me.Sec3_Mesa_1.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_1, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")

                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_2"
                If Sec3_Mesa_2.BackColor = Color.CadetBlue Then
                    Liberar_mesa("2", "3")
                    Me.Sec3_Mesa_2.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_2, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")

                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")

                End If
            Case "Sec3_Mesa_3"
                If Sec3_Mesa_3.BackColor = Color.CadetBlue Then
                    Liberar_mesa("3", "3")
                    Me.Sec3_Mesa_3.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_3, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_4"
                If Sec3_Mesa_4.BackColor = Color.CadetBlue Then
                    Liberar_mesa("4", "3")
                    Me.Sec3_Mesa_4.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_4, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_5"
                If Sec3_Mesa_5.BackColor = Color.CadetBlue Then
                    Liberar_mesa("5", "3")
                    Me.Sec3_Mesa_5.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_5, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_6"
                If Sec3_Mesa_6.BackColor = Color.CadetBlue Then
                    Liberar_mesa("6", "3")
                    Me.Sec3_Mesa_6.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_6, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_7"
                If Sec3_Mesa_7.BackColor = Color.CadetBlue Then
                    Liberar_mesa("7", "3")
                    Me.Sec3_Mesa_7.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_7, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_8"
                If Sec3_Mesa_8.BackColor = Color.CadetBlue Then
                    Liberar_mesa("8", "3")
                    Me.Sec3_Mesa_8.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_8, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_9"
                If Sec3_Mesa_9.BackColor = Color.CadetBlue Then
                    Liberar_mesa("9", "3")
                    Me.Sec3_Mesa_9.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_9, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_10"
                If Sec3_Mesa_10.BackColor = Color.CadetBlue Then
                    Liberar_mesa("10", "3")
                    Me.Sec3_Mesa_10.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_10, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_11"
                If Sec3_Mesa_11.BackColor = Color.CadetBlue Then
                    Liberar_mesa("11", "3")
                    Me.Sec3_Mesa_11.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_11, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_12"
                If Sec3_Mesa_12.BackColor = Color.CadetBlue Then
                    Liberar_mesa("12", "3")
                    Me.Sec3_Mesa_12.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_12, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_13"
                If Sec3_Mesa_13.BackColor = Color.CadetBlue Then
                    Liberar_mesa("13", "3")
                    Me.Sec3_Mesa_13.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_13, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_14"
                If Sec3_Mesa_14.BackColor = Color.CadetBlue Then
                    Liberar_mesa("14", "3")
                    Me.Sec3_Mesa_14.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_14, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_15"
                If Sec3_Mesa_15.BackColor = Color.CadetBlue Then
                    Liberar_mesa("15", "3")
                    Me.Sec3_Mesa_15.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_15, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec3_Mesa_16"
                If Sec3_Mesa_16.BackColor = Color.CadetBlue Then
                    Liberar_mesa("16", "3")
                    Me.Sec3_Mesa_16.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec3_Mesa_16, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If




                '--SECTOR 4

            Case "Sec4_Mesa_1"
                'If Sec1_Mesa_8.BackColor = Color.CadetBlue Then

                If Sec4_Mesa_1.BackColor = Color.CadetBlue Then
                    Liberar_mesa("1", "4")
                    Me.Sec4_Mesa_1.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_1, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")

                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_2"
                If Sec4_Mesa_2.BackColor = Color.CadetBlue Then
                    Liberar_mesa("2", "4")
                    Me.Sec4_Mesa_2.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_2, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")

                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")

                End If
            Case "Sec4_Mesa_3"
                If Sec4_Mesa_3.BackColor = Color.CadetBlue Then
                    Liberar_mesa("3", "4")
                    Me.Sec4_Mesa_3.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_3, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_4"
                If Sec4_Mesa_4.BackColor = Color.CadetBlue Then
                    Liberar_mesa("4", "4")
                    Me.Sec4_Mesa_4.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_4, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_5"
                If Sec4_Mesa_5.BackColor = Color.CadetBlue Then
                    Liberar_mesa("5", "4")
                    Me.Sec4_Mesa_5.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_5, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_6"
                If Sec4_Mesa_6.BackColor = Color.CadetBlue Then
                    Liberar_mesa("6", "4")
                    Me.Sec4_Mesa_6.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_6, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_7"
                If Sec4_Mesa_7.BackColor = Color.CadetBlue Then
                    Liberar_mesa("7", "4")
                    Me.Sec4_Mesa_7.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_7, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_8"
                If Sec4_Mesa_8.BackColor = Color.CadetBlue Then
                    Liberar_mesa("8", "4")
                    Me.Sec4_Mesa_8.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_8, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_9"
                If Sec4_Mesa_9.BackColor = Color.CadetBlue Then
                    Liberar_mesa("9", "4")
                    Me.Sec4_Mesa_9.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_9, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_10"
                If Sec4_Mesa_10.BackColor = Color.CadetBlue Then
                    Liberar_mesa("10", "4")
                    Me.Sec4_Mesa_10.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_10, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_11"
                If Sec4_Mesa_11.BackColor = Color.CadetBlue Then
                    Liberar_mesa("11", "4")
                    Me.Sec4_Mesa_11.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_11, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_12"
                If Sec4_Mesa_12.BackColor = Color.CadetBlue Then
                    Liberar_mesa("12", "4")
                    Me.Sec4_Mesa_12.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_12, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_13"
                If Sec4_Mesa_13.BackColor = Color.CadetBlue Then
                    Liberar_mesa("13", "4")
                    Me.Sec4_Mesa_13.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_13, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_14"
                If Sec4_Mesa_14.BackColor = Color.CadetBlue Then
                    Liberar_mesa("14", "4")
                    Me.Sec4_Mesa_14.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_14, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_15"
                If Sec4_Mesa_15.BackColor = Color.CadetBlue Then
                    Liberar_mesa("15", "4")
                    Me.Sec4_Mesa_15.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_15, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If
            Case "Sec4_Mesa_16"
                If Sec4_Mesa_16.BackColor = Color.CadetBlue Then
                    Liberar_mesa("16", "4")
                    Me.Sec4_Mesa_16.BackColor = Color.ForestGreen
                    ToolTip1.SetToolTip(Sec4_Mesa_16, "Mesa libre")
                    MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa no se puede liberar. Verifique estado", "Sistema de Gestion.")
                    'Me.Sec1_Mesa_1.BackColor = Color.ForestGreen
                    'ToolTip1.SetToolTip(Sec1_Mesa_1, "Mesa libre")
                End If

        End Select
    End Sub

    Private Sub BO_Agregar_mesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Agregar_mesa.Click
        Mesas_agregar.Show()
    End Sub

    Private Sub BO_Eliminar_mesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar_mesa.Click
        Mesa_eliminar.Show()
    End Sub

    Private Sub CambiarMesaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarMesaToolStripMenuItem.Click
        If mesa = "Sec1_Mesa_1" Then
            If Sec1_Mesa_1.BackColor = Color.ForestGreen Then
                MsgBox("Error, la mesa esta libre")
            Else
                Mesas_cambiar.Show()
                'paso el estado de todas las mesas....
                Mesas_cambiar.Lb_mesa.Text = "Sector 1 - Mesa 1"
                cambio_mesa_cargar()
            End If
        End If
        If mesa = "Sec1_Mesa_2" Then
            If Sec1_Mesa_2.BackColor = Color.ForestGreen Then
                MsgBox("Error, la mesa esta libre")
            Else
                Mesas_cambiar.Show()
                'paso el estado de todas las mesas....
                Mesas_cambiar.Lb_mesa.Text = "Sector 1 - Mesa 2"
                cambio_mesa_cargar()
            End If
        End If
    End Sub

    Private Sub cambio_mesa_cargar() 'aqui cargo en el formulario mesas_cambiar el estado de asignacion de las mesas
        'sector 1

        Mesas_cambiar.Sec1_Mesa_1.BackColor = Me.Sec1_Mesa_1.BackColor
        Mesas_cambiar.Sec1_Mesa_2.BackColor = Me.Sec1_Mesa_2.BackColor
        Mesas_cambiar.Sec1_Mesa_3.BackColor = Me.Sec1_Mesa_3.BackColor
        Mesas_cambiar.Sec1_Mesa_4.BackColor = Me.Sec1_Mesa_4.BackColor
        Mesas_cambiar.Sec1_Mesa_5.BackColor = Me.Sec1_Mesa_5.BackColor
        Mesas_cambiar.Sec1_Mesa_6.BackColor = Me.Sec1_Mesa_6.BackColor
        Mesas_cambiar.Sec1_Mesa_7.BackColor = Me.Sec1_Mesa_7.BackColor
        Mesas_cambiar.Sec1_Mesa_8.BackColor = Me.Sec1_Mesa_8.BackColor
        Mesas_cambiar.Sec1_Mesa_9.BackColor = Me.Sec1_Mesa_9.BackColor
        Mesas_cambiar.Sec1_Mesa_10.BackColor = Me.Sec1_Mesa_10.BackColor
        Mesas_cambiar.Sec1_Mesa_11.BackColor = Me.Sec1_Mesa_11.BackColor
        Mesas_cambiar.Sec1_Mesa_12.BackColor = Me.Sec1_Mesa_12.BackColor
        Mesas_cambiar.Sec1_Mesa_13.BackColor = Me.Sec1_Mesa_13.BackColor
        Mesas_cambiar.Sec1_Mesa_14.BackColor = Me.Sec1_Mesa_14.BackColor
        Mesas_cambiar.Sec1_Mesa_15.BackColor = Me.Sec1_Mesa_15.BackColor
        Mesas_cambiar.Sec1_Mesa_16.BackColor = Me.Sec1_Mesa_16.BackColor

        'veo que mesas poner en visible
        If Sec1_Mesa_1.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_1.Visible = True
        End If
        If Sec1_Mesa_2.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_2.Visible = True
        End If
        If Sec1_Mesa_3.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_3.Visible = True
        End If
        If Sec1_Mesa_4.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_4.Visible = True
        End If
        If Sec1_Mesa_5.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_5.Visible = True
        End If
        If Sec1_Mesa_6.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_6.Visible = True
        End If
        If Sec1_Mesa_7.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_7.Visible = True
        End If
        If Sec1_Mesa_8.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_8.Visible = True
        End If
        If Sec1_Mesa_9.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_9.Visible = True
        End If
        If Sec1_Mesa_10.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_10.Visible = True
        End If
        If Sec1_Mesa_11.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_11.Visible = True
        End If
        If Sec1_Mesa_12.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_12.Visible = True
        End If
        If Sec1_Mesa_13.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_13.Visible = True
        End If
        If Sec1_Mesa_14.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_14.Visible = True
        End If
        If Sec1_Mesa_15.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_15.Visible = True
        End If
        If Sec1_Mesa_16.Visible = True Then
            Mesas_cambiar.Sec1_Mesa_16.Visible = True
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Mesas_consulta_gestion.Show()
    End Sub

    
    Private Sub Button_sector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_sector.Click
        Sector_modificar.tx_sector1.Text = Lb_sector1.Text
        Sector_modificar.tx_sector2.Text = Lb_sector2.Text
        Sector_modificar.tx_sector3.Text = Lb_sector3.Text
        Sector_modificar.tx_sector4.Text = Lb_sector4.Text
        Sector_modificar.Show()
    End Sub
End Class