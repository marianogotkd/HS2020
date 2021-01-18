Public Class CostoInd_alta
    Dim validaciones As New Validaciones
    Dim DAemp As New Datos.Empleado
    Dim DACosto As New Datos.Costo_Indirecto
    Public Costo_Id As Integer = 0

    Private Sub CostoInd_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds_emp As DataSet = DAemp.Empleados_remuneracion_Obtener

        Ds_empleados.Tables("Empleado_remu").Clear()
        DataGridView1.DataSource = Nothing
        Ds_empleados.Tables("Empleado_remu").Merge(ds_emp.Tables(0))
        DataGridView1.DataSource = ds_emp.Tables(0)
        If Costo_Id <> 0 Then
            Cargar_Datos()
        End If
    End Sub
    Private Sub Cargar_Datos()
        Dim Ds As DataSet = DACosto.Costo_Indirecto_Obtener_Todo_X_ID(Costo_Id)

        If Ds.Tables(0).Rows.Count <> 0 Then
            tb_titulo.Text = Ds.Tables(0).Rows(0).Item("CostoI_Desc")
            Total_Grilla.Text = Ds.Tables(0).Rows(0).Item("CostoI_Total")
           


            'choco 17-12-2020 ahora cargo en el gridview las sucursales que tiene asignado el cliente
            Dim e As Integer = 0
            If Ds.Tables(1).Rows.Count <> 0 Then
                While e < Ds.Tables(1).Rows.Count
                    Dim fila As DataRow = Costo_Ind.Tables("Detalle").NewRow
                    fila("CostoInDet_id") = Ds.Tables(1).Rows(e).Item("CostoInDet_id")
                    fila("CostoInDet_desc") = Ds.Tables(1).Rows(e).Item("CostoInDet_desc")
                    fila("CostoInDet_costo") = Ds.Tables(1).Rows(e).Item("CostoInDet_costo")
                    fila("CostoInDet_info") = Ds.Tables(1).Rows(e).Item("CostoInDet_info")
                    Costo_Ind.Tables("Detalle").Rows.Add(fila)
                    e = e + 1
                End While
            End If
        End If



    End Sub

    Private Sub tb_sem_costo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        tb_costo.SelectAll()
    End Sub

    

    Private Sub tb_sem_costo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        tb_costo.SelectAll()
    End Sub

    Private Sub tb_sem_costo_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_costo.GotFocus
        tb_costo.SelectAll()
        tb_costo.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tb_sem_costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_costo.KeyPress
        validaciones.Restricciones_textbox(e, "Decimal", tb_costo)
        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER calcula
            If tb_costo.Text = "" Then
                tb_costo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                tb_costo.Text = (Math.Round(CDec(tb_costo.Text), 2).ToString("N2"))
                If RadioButton_dia.Checked = True Then
                    Calcular_Costo_Dia()
                End If
                If RadioButton_HORA.Checked = True Then
                    Calcular_Costo_Hora()
                End If
                If RadioButton_Fijo.Checked = True Then
                    tb_fijo.Text = tb_costo.Text
                End If
            End If
        End If

    End Sub

    Private Sub tb_sem_costo_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_costo.LostFocus
        If tb_costo.Text = "" Then
            tb_costo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tb_costo.Text = (Math.Round(CDec(tb_costo.Text), 2).ToString("N2"))
            Calcular_Costo_Dia()
        End If

    End Sub

    Private Sub tb_sem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_dia_dia.LostFocus
        If tb_costo.Text = "" Then
            tb_costo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tb_costo.Text = (Math.Round(CDec(tb_costo.Text), 2).ToString("N2"))
        End If

        'Calcular_Costo_Hora()

    End Sub

    Private Sub Calcular_Costo_Hora()
        If tb_costo.Text <> "" And tb_costo.Text <> "0,00" Then
            tb_costo_total_Hora.Text = CDec(tb_costo.Text) / (tb_hora_dia.Value * tb_horas_hora.Value)
            tb_costo_total_Hora.Text = (Math.Round(CDec(tb_costo_total_Hora.Text), 2).ToString("N2"))
        End If


    End Sub
    Private Sub tb_horas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_horas_hora.LostFocus
        If tb_costo.Text = "" Then
            tb_costo.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            tb_costo.Text = (Math.Round(CDec(tb_costo.Text), 2).ToString("N2"))
        End If

        Calcular_Costo_Dia()
    End Sub

    Private Sub Calcular_Costo_Dia()
        If tb_costo.Text <> "" And tb_costo.Text <> "0,00" Then

            tb_costo_Total_Dia.Text = CDec(tb_costo.Text) / tb_dia_dia.Value
            tb_costo_Total_Dia.Text = (Math.Round(CDec(tb_costo_Total_Dia.Text), 2).ToString("N2"))
        End If


    End Sub


    

    



    
    
   
    

    
    Private Sub tb_costo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_costo.TextChanged

    End Sub

    Private Sub tb_dia_dia_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tb_dia_dia.Paint

    End Sub

    Private Sub tb_dia_dia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_dia_dia.ValueChanged
        Calcular_Costo_Dia()
    End Sub

   
    

    Private Sub tb_hora_dia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_hora_dia.ValueChanged
        Calcular_Costo_Hora()

    End Sub

    Private Sub tb_horas_hora_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_horas_hora.ValueChanged
        Calcular_Costo_Hora()

    End Sub

    Private Sub RadioButton_dia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_dia.CheckedChanged
        If RadioButton_dia.Checked = True Then
            Panel_dia.Enabled = True
            RadioButton_Fijo.Checked = False
            RadioButton_HORA.Checked = False

            Panel_fijo.Enabled = False
            Panel_hora.Enabled = False

        End If
    End Sub

    Private Sub RadioButton_HORA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_HORA.CheckedChanged
        If RadioButton_HORA.Checked = True Then

            Panel_hora.Enabled = True
            RadioButton_Fijo.Checked = False
            RadioButton_dia.Checked = False

            Panel_dia.Enabled = False
            Panel_fijo.Enabled = False

            If tb_costo.Text <> "" Then
                Calcular_Costo_Hora()
            End If

        End If
    End Sub

    Private Sub RadioButton_Fijo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Fijo.CheckedChanged
        If RadioButton_Fijo.Checked = True Then
            Panel_fijo.Enabled = True
            RadioButton_dia.Checked = False
            RadioButton_HORA.Checked = False

            Panel_dia.Enabled = False
            Panel_hora.Enabled = False

            If tb_costo.Text <> "" Then
                tb_fijo.Text = tb_costo.Text
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dia.Click
        If tb_desc.Text <> "" And tb_costo_Total_Dia.Text <> "" Then

            Dim fila As DataRow = Costo_Ind.Tables("Detalle").NewRow
            fila("CostoInDet_desc") = tb_desc.Text
            fila("CostoInDet_costo") = tb_costo_Total_Dia.Text
            fila("CostoInDet_info") = "Costo por Dia - Dias trabajados: " + CStr(tb_dia_dia.Value)

            Costo_Ind.Tables("Detalle").Rows.Add(fila)

            Total_Grilla.Text = CDec(Total_Grilla.Text) + CDec(tb_costo_Total_Dia.Text)



        Else
            MessageBox.Show("Complete Los Campos Obligatorios", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbl_err.Visible = True
            lbl_err2.Visible = True
            lbl_err3.Visible = True
        End If

    End Sub

    Private Sub btn_hora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hora.Click
        If tb_desc.Text <> "" And tb_costo_total_Hora.Text <> "" Then
           
            Dim fila As DataRow = Costo_Ind.Tables("Detalle").NewRow
            fila("CostoInDet_desc") = tb_desc.Text
            fila("CostoInDet_costo") = tb_costo_total_Hora.Text
            fila("CostoInDet_info") = "Costo por Hora - Dias trab.: " + CStr(tb_hora_dia.Value) + " - Horas Trab.: " + CStr(tb_hora_dia.Value)
            Costo_Ind.Tables("Detalle").Rows.Add(fila)


            Total_Grilla.Text = CDec(Total_Grilla.Text) + CDec(tb_costo_total_Hora.Text)
        Else
            MessageBox.Show("Complete Los Campos Obligatorios", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbl_err.Visible = True
            lbl_err2.Visible = True
            lbl_err3.Visible = True
        End If
    End Sub

    Private Sub btn_fijo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fijo.Click
        If tb_desc.Text <> "" And tb_fijo.Text <> "" Then



            Dim fila As DataRow = Costo_Ind.Tables("Detalle").NewRow
            fila("CostoInDet_desc") = tb_desc.Text
            fila("CostoInDet_costo") = tb_fijo.Text
            fila("CostoInDet_info") = "Costo Fijo"
            Costo_Ind.Tables("Detalle").Rows.Add(fila)


            Total_Grilla.Text = CDec(Total_Grilla.Text) + CDec(tb_fijo.Text)
        Else
            MessageBox.Show("Complete Los Campos Obligatorios", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbl_err.Visible = True
            lbl_err2.Visible = True
            lbl_err3.Visible = True
        End If
    End Sub

    Private Sub btn_emp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_emp.Click

        If tb_totalEmp.Text <> "" Then
            Dim Nombre = DataGridView1.SelectedCells.Item(0).Value.ToString + " " + DataGridView1.SelectedCells.Item(1).Value.ToString


            Dim fila As DataRow = Costo_Ind.Tables("Detalle").NewRow
            fila("CostoInDet_desc") = Nombre
            fila("CostoInDet_costo") = tb_totalEmp.Text
            fila("CostoInDet_info") = "Salario por Hora de Trabajo - Horas: " + CStr(tb_multi.Value)
            Costo_Ind.Tables("Detalle").Rows.Add(fila)




            Total_Grilla.Text = CDec(Total_Grilla.Text) + CDec(tb_totalEmp.Text)
            tb_totalEmp.Text = 0
            tb_empCost.Text = 0

        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        tb_empCost.Text = DataGridView1.SelectedCells.Item(3).Value.ToString
        If tb_empCost.Text <> "" Then
            tb_totalEmp.Text = CDec(tb_empCost.Text) * CDec(tb_multi.Value)
        End If
    End Sub


    Private Sub tb_multi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_multi.ValueChanged
        If tb_empCost.Text <> "" Then
            tb_totalEmp.Text = CDec(tb_empCost.Text) * CDec(tb_multi.Value)
        End If
    End Sub

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
        Dim li_index As Integer

        If e.KeyCode = Keys.Delete Then

            e.Handled = True

            li_index = CType(sender, DataGridView).CurrentRow.Index
            DataGridView2.Rows.RemoveAt(li_index)

        End If
    End Sub

    Private Sub DataGridView2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView2.KeyPress
        
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If tb_titulo.Text <> "" Then
            If DataGridView2.RowCount <> 0 Then
                'SI EL COSOTO_ID ES <> DE 0 ENTONCES QUIERE DECIR QUE ES UNA MODIFICACION 
                If Costo_Id = 0 Then
                    Dim ds As DataSet = DACosto.Costo_Indirecto_alta(tb_titulo.Text, Total_Grilla.Text, DateTimePicker1.Value, "Activo")


                    Dim i As Integer = 0
                    While i < DataGridView2.RowCount
                        'Dim EnBD As String = DG_Servicio.Rows(e).Cells("EnBDDataGridViewTextBoxColumn").Value.ToString
                        Dim costoI_id = CInt(ds.Tables(0).Rows(0).Item("CostI_Id"))
                        DACosto.Costo_Indirecto_Detalle_Alta(DataGridView2.Rows(i).Cells("CostoInDetdescDataGridViewTextBoxColumn").Value,
                                                             DataGridView2.Rows(i).Cells("CostoInDetcostoDataGridViewTextBoxColumn").Value,
                                                            costoI_id, DataGridView2.Rows(i).Cells("CostoInDetinfoDataGridViewTextBoxColumn").Value)
                        i = i + 1
                    End While
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Else
                    'ESTA ES PARA MODIFICAR
                    DACosto.Costo_Indirecto_modificar(Costo_Id, tb_titulo.Text, Total_Grilla.Text, DateTimePicker1.Value)

                    Dim i As Integer = 0
                    While i < DataGridView2.RowCount

                        DACosto.Costo_Indirecto_Detalle_Alta(DataGridView2.Rows(i).Cells("CostoInDetdescDataGridViewTextBoxColumn").Value,
                                                             DataGridView2.Rows(i).Cells("CostoInDetcostoDataGridViewTextBoxColumn").Value,
                                                            Costo_Id, DataGridView2.Rows(i).Cells("CostoInDetinfoDataGridViewTextBoxColumn").Value)
                        i = i + 1
                    End While
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)





                End If
                limpiar()
                CostosInd_Consulta.Obtener_Costos_indirectos()

            Else
                MessageBox.Show("Se debe tener al menos un Costo", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            


        Else
        MessageBox.Show("Debe Colocar un Titulo", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        lbl_err.Visible = True
        tb_titulo.Focus()
        End If
    End Sub
    Private Sub limpiar()
        Total_Grilla.Text = ""
        tb_totalEmp.Text = ""
        tb_costo_total_Hora.Text = ""
        tb_costo_Total_Dia.Text = ""
        tb_fijo.Text = ""

        tb_costo.Text = ""
        tb_desc.Text = ""
        tb_titulo.Text = ""

        DataGridView2.DataSource = Nothing
        DataGridView2.DataSource = ""


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DataGridView2.RowCount <> 0 Then
            DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
            Dim i = 0
            Dim total As Decimal = 0

            While i < DataGridView2.RowCount
                total = total + CDec(DataGridView2.Rows(i).Cells("CostoInDetcostoDataGridViewTextBoxColumn").Value)
                i = i + 1

            End While

            Total_Grilla.Text = total
        End If
    End Sub
End Class