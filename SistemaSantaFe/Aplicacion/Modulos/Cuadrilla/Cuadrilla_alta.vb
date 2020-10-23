Public Class Cuadrilla_alta
    Public procedencia As String = "alta"
    Dim DAcuadrilla As New Datos.Cuadrilla

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cuadrilla_agregar_empleado.Close()
        Cuadrilla_agregar_empleado.Show()

    End Sub

    Private Sub DG_empleados_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_empleados.CellEndEdit
        'aqui calculo el salario total
        If DG_empleados.Rows.Count <> 0 Then
            Dim salario As Decimal = 0
            Dim i As Integer = 0
            While i < DG_empleados.Rows.Count
                salario = salario + DG_empleados.Rows(i).Cells("SalarioxhoraDataGridViewTextBoxColumn").Value
                i = i + 1
            End While

            Label_total_salario.Text = "Salario total por hora de la cuadrilla: $" + CStr(salario)

        End If


    End Sub

    Private Sub DG_empleados_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG_empleados.EditingControlShowing
        'valido_fraccionable(DataGridView1.CurrentRow.Cells("columna_codinterno").Value)

        'referencia a la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregar el controlador de eventos para el keypress
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub

    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        Dim columna As Integer = DG_empleados.CurrentCell.ColumnIndex
        'If columna = 6 Then 'la columna 6 es descuento, que acepta decimales
        Dim caracter As Char = e.KeyChar
        '        'referencia a la celda
        Dim txt As TextBox = CType(sender, TextBox)
        'aqui pongo el codigo para remplazar el punto por una coma
        If txt.ToString() = "." Then
            txt.Text = ","
        End If
        If caracter.ToString() = "." Then
            caracter = ","
        End If
        'comprobar si el caracter es un número o el retroceso, si el caracter es un separador decimal y que no contiene ya el separador
        If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then
            e.KeyChar = caracter
            e.Handled = False
        Else
            e.Handled = True
        End If
        'End If


    End Sub

    Private Sub Cuadrilla_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If procedencia = "alta" Then
            txt_codigo.Text = ""
            txt_codigo.Enabled = False
        End If

        If procedencia = "modificar" Then
            'recupero toda la info de la cuadrilla
        End If

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If procedencia = "alta" Then
            Alta()
        End If
    End Sub

    Private Sub Alta()
        If txt_descripcion.Text <> "" Then
            If DG_empleados.Rows.Count <> 0 Then
                'valido que no exista una cuadrilla con ese mismo nombre
                Dim ds_validar As DataSet = DAcuadrilla.Cuadrilla_validar(txt_descripcion.Text)
                If ds_validar.Tables(0).Rows.Count = 0 Then

                    'calculo el salario total para guardar en tabla cuadrilla
                    Dim salario As Decimal = 0
                    Dim i As Integer = 0
                    While i < DG_empleados.Rows.Count
                        salario = salario + DG_empleados.Rows(i).Cells("SalarioxhoraDataGridViewTextBoxColumn").Value
                        i = i + 1
                    End While
                    Dim ds_cuadrilla As DataSet = DAcuadrilla.Cuadrilla_alta(txt_descripcion.Text, salario)
                    Dim cuadrilla_id As Integer = ds_cuadrilla.Tables(0).Rows(0).Item("Cuadrilla_id")

                    i = 0
                    While i < DG_empleados.Rows.Count
                        Dim empleado_id As Integer = DG_empleados.Rows(i).Cells("EmpleadoidDataGridViewTextBoxColumn").Value
                        salario = DG_empleados.Rows(i).Cells("SalarioxhoraDataGridViewTextBoxColumn").Value
                        DAcuadrilla.Empleado_x_Cuadrilla_alta(empleado_id, cuadrilla_id, salario)
                        i = i + 1
                    End While
                    MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                Else
                    MessageBox.Show("Error, ya existe una cuadrilla con ese nombre. Modifique la descripción.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'aqui pongo el label ese rojito
                    lbl_err_cuadrilla.Visible = True
                    txt_descripcion.SelectAll()
                End If
            Else
                MessageBox.Show("Error, debe asignar al menos un empleado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error, complete la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'aqui pongo el label ese rojito
            lbl_err_cuadrilla.Visible = True
        End If
    End Sub

    Private Sub limpiar()

        lbl_err_cuadrilla.Visible = False
        txt_codigo.Text = ""
        txt_descripcion.Text = ""

        'borro contenido de la grilla
        Ds_cuadrilla.Tables("Empleados").Rows.Clear()

        'label
        Label_total_empleados.Text = "Empleados asignados a cuadrilla: 0"
        Label_total_salario.Text = "Salario total por hora de la cuadrilla: $ 0,00"
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        limpiar()
    End Sub

    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Cuadrilla_consultar.Close()
        Cuadrilla_consultar.Show()
        Me.Close()
    End Sub
End Class