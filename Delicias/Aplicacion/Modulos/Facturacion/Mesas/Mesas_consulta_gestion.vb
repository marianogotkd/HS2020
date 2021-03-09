Public Class Mesas_consulta_gestion

    Dim DAventa As New Datos.Venta

    Private Sub Mesas_consulta_gestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.DataGridView1.DataSource = Mesas_gestion_2_new.DataGridView1.DataSource
        Me.pintar_grilla_estados()

        If DataGridView1.Rows.Count <> 0 Then
            DataGridView1.Rows(0).Selected = True
            fondo_seleccion()
        End If

        Me.tx_buscar.Focus()


        Me.Left += 400
        Me.Top += 200


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If DataGridView1.Rows.Count <> 0 Then 'valido q no este vacia la grilla

            If DataGridView1.SelectedRows.Count <> 0 Then 'esto es para validar q se seleccione una mesa
                If Me.DataGridView1.CurrentRow IsNot Nothing Then

                    Dim estado As String = DataGridView1.SelectedCells(3).Value
                    If estado = "Libre" Then
                        Mesas_gestion_2_new.asig_pendiente = ""
                        Dim Lb_sector As String = DataGridView1.CurrentRow.Cells("SectornombreusuarioDataGridViewTextBoxColumn").Value 'nombre del sector dado x el usuario
                        Dim sector_id As Integer = DataGridView1.CurrentRow.Cells("SectoridDataGridViewTextBoxColumn").Value 'id del sector (puede ser 1, 2, 3 o 4 max)
                        Dim sec_mesa As String = DataGridView1.CurrentRow.Cells("MESAnumeroDataGridViewTextBoxColumn").Value

                        Call Mesas_gestion_2_new.Asignar_mesa_parametros(Lb_sector, sector_id, sec_mesa)
                        Mesa_asignar.form_procedencia = "Mesas_consulta_gestion"

                    Else
                        MsgBox("Seleccione una mesa libre", MsgBoxStyle.Information)
                    End If
                Else
                    MessageBox.Show("Seleccione una mesa", "Sistema de Gestion.")
                End If
            Else
                MessageBox.Show("Seleccione una mesa", "Sistema de Gestion.")
            End If

        End If






    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DataGridView1.Rows.Count <> 0 Then

            If DataGridView1.SelectedRows.Count <> 0 Then 'esto es para validar q se seleccione una mesa

                If Me.DataGridView1.CurrentRow IsNot Nothing Then

                    Dim estado As String = DataGridView1.SelectedCells(3).Value
                    If estado = "Ocupado" Then


                        Mesas_gestion_2_new.asig_pendiente = ""
                        Dim Lb_sector As String = DataGridView1.CurrentRow.Cells("SectornombreusuarioDataGridViewTextBoxColumn").Value 'nombre del sector dado x el usuario
                        Dim sector_id As Integer = DataGridView1.CurrentRow.Cells("SectoridDataGridViewTextBoxColumn").Value 'id del sector (puede ser 1, 2, 3 o 4 max)
                        Dim sec_mesa As String = DataGridView1.CurrentRow.Cells("MESAnumeroDataGridViewTextBoxColumn").Value

                        Mesa_cargar.form_procedencia = "Mesas_consulta_gestion"
                        Call Mesas_gestion_2_new.Cargar_mesa_parametros(Lb_sector, sector_id, sec_mesa)



                    Else
                        If estado = "Libre" Then
                            MessageBox.Show("La mesa no ha sido asignada", "Sistema de Gestion.")
                        Else
                            MessageBox.Show("La mesa ya ha sido cobrada", "Sistema de Gestion.")
                        End If

                    End If
                Else
                    MessageBox.Show("Seleccione una mesa", "Sistema de Gestion.")
                End If
            Else
                MessageBox.Show("Seleccione una mesa", "Sistema de Gestion.")
            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DataGridView1.Rows.Count <> 0 Then
            If DataGridView1.SelectedRows.Count <> 0 Then 'esto es para validar q se seleccione una mesa
                If Me.DataGridView1.CurrentRow IsNot Nothing Then

                    Dim estado As String = DataGridView1.SelectedCells(3).Value
                    If estado = "Cobrado" Or DataGridView1.CurrentRow.Cells("ImporteTotalDataGridViewTextBoxColumn").Value = "0,00" Then
                        Mesas_gestion_2_new.asig_pendiente = ""
                        Dim Lb_sector As String = DataGridView1.CurrentRow.Cells("SectornombreusuarioDataGridViewTextBoxColumn").Value 'nombre del sector dado x el usuario
                        Dim sector_id As Integer = DataGridView1.CurrentRow.Cells("SectoridDataGridViewTextBoxColumn").Value 'id del sector (puede ser 1, 2, 3 o 4 max)
                        Dim sec_mesa As String = DataGridView1.CurrentRow.Cells("MESAnumeroDataGridViewTextBoxColumn").Value




                        If DataGridView1.CurrentRow.Cells("ImporteTotalDataGridViewTextBoxColumn").Value = "0,00" Then

                            Dim ventaprod_id As Integer = DataGridView1.CurrentRow.Cells("VentaprodidDataGridViewTextBoxColumn").Value
                            DAventa.VentaProducto_modificar_mesa(ventaprod_id, "0,00", "0,00", "Cobrado")
                            Dim mesa_id As Integer = DataGridView1.CurrentRow.Cells("MESAidDataGridViewTextBoxColumn").Value
                            Dim Label_mesa As String = DataGridView1.CurrentRow.Cells("MESAnumeroDataGridViewTextBoxColumn").Value
                            DAventa.MESAS_modificar(mesa_id, Label_mesa, "Cobrado", "Si", ventaprod_id)

                            Mesas_gestion_2_new.Deshabilitar_mesas()

                            Mesas_gestion_2_new.sectores_obtener_nombre()
                            Mesas_gestion_2_new.recuperar_mesas()
                            Mesas_gestion_2_new.habilitar_mesas()

                        End If




                        'Mesa_cargar.form_procedencia = "Mesas_consulta_gestion"
                        Mesas_gestion_2_new.Liberar_mesa(sec_mesa, sector_id)
                        Habilitar_mesas_libres(sector_id, sec_mesa)
                        MessageBox.Show("La mesa ha sido liberada correctamente.", "Sistema de Gestion.")
                        'Call Mesas_gestion_2_new.Cargar_mesa_parametros(Lb_sector, sector_id, sec_mesa)



                    Else
                        MsgBox("Seleccione una mesa cobrada", MsgBoxStyle.Information)
                    End If
                Else
                    MessageBox.Show("Seleccione una mesa", "Sistema de Gestion.")
                End If
            Else
                MessageBox.Show("Seleccione una mesa", "Sistema de Gestion.")
            End If
        End If






    End Sub


    Private Sub Habilitar_mesas_libres(ByVal sector_id As Integer, ByVal mesa_nombre As Integer) 'esta rutina se ejecuta para liberar las mesas
        Dim esta = "no"
        If sector_id = "1" Then
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_1.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_1.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_1, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_2.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_2.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_2, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_3.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_3.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_3, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_4.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_4.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_4, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_5.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_5.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_5, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_6.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_6.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_6, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_7.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_7.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_7, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_8.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_8.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_8, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_9.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_9.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_9, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_10.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_10.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_10, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_11.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_11.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_11, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_12.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_12.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_12, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_13.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_13.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_13, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_14.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_14.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_14, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_15.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_15.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_15, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_16.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_16.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_16, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If


        End If

        If sector_id = "2" Then
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_1.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_1.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_1, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_2.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_2.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_2, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_3.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_3.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_3, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_4.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_4.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_4, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_5.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_5.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_5, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_6.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_6.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_6, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_7.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_7.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_7, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_8.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_8.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_8, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_9.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_9.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_9, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_10.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_10.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_10, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_11.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_11.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_11, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_12.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_12.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_12, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_13.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_13.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_13, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_14.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_14.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_14, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_15.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_15.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_15, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_16.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_16.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_16, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If



        End If


        If sector_id = "3" Then
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_1.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_1.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_1, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_2.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_2.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_2, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_3.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_3.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_3, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_4.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_4.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_4, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_5.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_5.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_5, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_6.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_6.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_6, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_7.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_7.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_7, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_8.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_8.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_8, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_9.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_9.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_9, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_10.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_10.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_10, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_11.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_11.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_11, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_12.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_12.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_12, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_13.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_13.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_13, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_14.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_14.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_14, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_15.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_15.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_15, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_16.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_16.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_16, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If

        End If


        If sector_id = "4" Then
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_1.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_1.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_1, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_2.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_2.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_2, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_3.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_3.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_3, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_4.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_4.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_4, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_5.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_5.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_5, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_6.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_6.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_6, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_7.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_7.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_7, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_8.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_8.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_8, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_9.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_9.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_9, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_10.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_10.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_10, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_11.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_11.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_11, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_12.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_12.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_12, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_13.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_13.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_13, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_14.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_14.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_14, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_15.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_15.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_15, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_16.BackColor = Color.CadetBlue Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_16.BackColor = Color.ForestGreen
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_16, "Mesa libre")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If

        End If
    End Sub

    Public Sub pintar_grilla_estados()

        If DataGridView1.Rows.Count <> 0 Then
            Dim i As Integer = 0

            While i < DataGridView1.Rows.Count
                If DataGridView1.Rows(i).Cells("EstadoDataGridViewTextBoxColumn").Value = "Libre" Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.ForestGreen
                End If
                If DataGridView1.Rows(i).Cells("EstadoDataGridViewTextBoxColumn").Value = "Ocupado" Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
                End If
                If DataGridView1.Rows(i).Cells("EstadoDataGridViewTextBoxColumn").Value = "Cobrado" Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.CadetBlue
                End If

                i = i + 1
            End While

            'DataGridView1.Rows(0).Selected = True

        End If


    End Sub

    Private Sub fondo_seleccion()
        If DataGridView1.Rows.Count <> 0 Then
            If DataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.ForestGreen Then
                DataGridView1.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.ForestGreen
            End If
            If DataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.IndianRed Then
                DataGridView1.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.IndianRed
            End If
            If DataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.CadetBlue Then
                DataGridView1.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.CadetBlue
            End If
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        fondo_seleccion()
    End Sub

    Private Sub tx_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_buscar.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
        DataGridView1.DataSource = Nothing
        If tx_buscar.Text <> "" Then
            Filtrar_datatable(Me.tx_buscar.Text)
        Else
            DataGridView1.DataSource = Mesas_gestion_2_new.DataGridView1.DataSource
            pintar_grilla_estados()

            If DataGridView1.Rows.Count <> 0 Then
                DataGridView1.Rows(0).Selected = True
                fondo_seleccion()
            End If

        End If
        'End If
    End Sub
    Public Sub Filtrar_datatable(ByVal parametro As String)
        If Mesas_gestion_2_new.Mesas_ds.Tables("MesasAsignadas").Rows.Count <> 0 Then
            ''uso ds_CLIE que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("MESA_numero")
            table_filtrada.Columns.Add("Importe_Total")
            table_filtrada.Columns.Add("Pago_parcial")
            table_filtrada.Columns.Add("MESA_id")
            table_filtrada.Columns.Add("Estado")
            table_filtrada.Columns.Add("Ventaprod_id")
            table_filtrada.Columns.Add("Cliente")
            table_filtrada.Columns.Add("Sector_id")
            table_filtrada.Columns.Add("Sector_nombre_usuario")
            table_filtrada.Columns.Add("Sector_nombre_fijo")
            table_filtrada.Rows.Clear()
            DataGridView1.DataSource = Nothing
            Dim table As DataTable = Mesas_gestion_2_new.Mesas_ds.Tables("MesasAsignadas")
            Dim apellido As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("Cliente")   'cliente --apellido + nombre
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If

                Dim fila2 As String = table.Rows(a).Item("Estado")
                fila2 = fila2.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter2 As Integer = fila2.IndexOf(parametro)
                If primercaracter2 <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If


                Dim fila3 As String = table.Rows(a).Item("Sector_nombre_usuario")
                fila3 = fila3.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter3 As Integer = fila3.IndexOf(parametro)
                If primercaracter3 <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If

                'If apellido = table.Rows(a).Item("CLI_ape") Then
                '    table_filtrada.ImportRow(table.Rows(a))
                'End If
                a = a + 1
            End While
            If table_filtrada.Rows.Count <> 0 Then
                DataGridView1.DataSource = table_filtrada
                pintar_grilla_estados()

                If DataGridView1.Rows.Count <> 0 Then
                    DataGridView1.Rows(0).Selected = True
                    fondo_seleccion()
                End If

            Else
                DataGridView1.DataSource = Mesas_gestion_2_new.DataGridView1
                pintar_grilla_estados()

                If DataGridView1.Rows.Count <> 0 Then
                    DataGridView1.Rows(0).Selected = True
                    fondo_seleccion()
                End If

            End If
        End If
    End Sub
End Class