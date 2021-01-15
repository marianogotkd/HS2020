Public Class Cuadrilla_alta
    Public procedencia As String = "alta"
    Dim DAcuadrilla As New Datos.Cuadrilla
    Public Cuadrilla_id As Integer 'este parametro me lo envia el formulario cuadrilla_consultar

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
            recuperar_cuadrilla()
        End If

    End Sub

    Private Sub recuperar_cuadrilla()
        Dim ds_cuad As DataSet = DAcuadrilla.Cuadrilla_recuperar_info(Cuadrilla_id)
        If ds_cuad.Tables(0).Rows.Count <> 0 Then
            txt_codigo.Text = CInt(ds_cuad.Tables(0).Rows(0).Item("Cuadrilla_id"))
            txt_codigo.ReadOnly = True
            txt_descripcion.Text = CStr(ds_cuad.Tables(0).Rows(0).Item("Cuadrilla_descripcion"))
            Label_total_salario.Text = "Salario total por hora de la cuadrilla: $ " + CStr(ds_cuad.Tables(0).Rows(0).Item("Cuadrilla_salario_x_hora"))
            Label_total_empleados.Text = "Empleados asignados a cuadrilla: " + CStr(ds_cuad.Tables(1).Rows.Count)

            'ahora cargo el gridview con los empleados

            Ds_cuadrilla.Tables("Empleados").Rows.Clear()

            Ds_cuadrilla.Tables("Empleados").Merge(ds_cuad.Tables(1))

            'ahora falta calcular

        End If

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If procedencia = "alta" Then
            Alta()
        End If
        If procedencia = "modificar" Then
            modificar()
        End If
    End Sub

    Private Sub modificar()
        If txt_descripcion.Text <> "" Then
            If DG_empleados.Rows.Count <> 0 Then
                'valido que no exista una cuadrilla con ese mismo nombre
                Dim ds_validar As DataSet = DAcuadrilla.Cuadrilla_validar(txt_descripcion.Text)
                Dim valido As String = "si"
                If ds_validar.Tables(0).Rows.Count <> 0 Then
                    'veo si es el mismo id
                    Dim cuadrilla_id As Integer = CInt(txt_codigo.Text)
                    If cuadrilla_id = ds_validar.Tables(0).Rows(0).Item("Cuadrilla_id") Then
                        'es el mismo
                        valido = "si"
                    Else
                        'no es el mismo, error
                        valido = "no"
                    End If
                End If


                If valido = "si" Then

                    'calculo el salario total para guardar en tabla cuadrilla
                    Dim salario As Decimal = 0
                    Dim i As Integer = 0
                    While i < DG_empleados.Rows.Count
                        salario = salario + DG_empleados.Rows(i).Cells("SalarioxhoraDataGridViewTextBoxColumn").Value
                        i = i + 1
                    End While
                    Dim ds_cuadrilla As DataSet = DAcuadrilla.Cuadrilla_modificar(cuadrilla_id, txt_descripcion.Text, salario)

                    'Dim cuadrilla_id As Integer = ds_cuadrilla.Tables(0).Rows(0).Item("Cuadrilla_id")

                    'ahora borro los empleados
                    DAcuadrilla.Empleado_x_Cuadrilla_eliminar(Cuadrilla_id)


                    i = 0
                    While i < DG_empleados.Rows.Count
                        Dim empleado_id As Integer = DG_empleados.Rows(i).Cells("EmpleadoidDataGridViewTextBoxColumn").Value
                        salario = DG_empleados.Rows(i).Cells("SalarioxhoraDataGridViewTextBoxColumn").Value
                        DAcuadrilla.Empleado_x_Cuadrilla_alta(empleado_id, cuadrilla_id, salario)
                        i = i + 1
                    End While
                    MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()


                    Cuadrilla_consultar.Close()
                    Cuadrilla_consultar.Show()
                    Me.Close()

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
        If procedencia = "modificar" Then
            Cuadrilla_consultar.Close()
            Cuadrilla_consultar.Show()
            Me.Close()
            limpiar()
        End If
        If procedencia = "alta" Then
            limpiar()
        End If

    End Sub

    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Cuadrilla_consultar.Close()
        Cuadrilla_consultar.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Cuadrilla_agregar_empleado.Close()
        Cuadrilla_agregar_empleado.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'para quitar tengo 2 opciones.
        '1) si la columna del gridview que se llama EnBD esta con "no", entonces solo quito del data set. no actualizo en bd.
        '3) si la columna EnBD dice "si" entonces si la quito de la bd, actualizo el registro en la tabla y la pongo SucxClie_estado = "eliminado", es decir q es un borrado lógico. para no perder las facturas q puedan estar ligadas a la base de datos

        'entonce recorro el gridview.
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        Dim valido_seleccion As String = "no"
        If DG_empleados.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DG_empleados.Rows.Count
                If DG_empleados.Rows(i).Cells("Item").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        valido_seleccion = "si" 'la uso solamente para indicar q si tengo algo seleccionado en el gridview
                        If MsgBox("¿Esta seguro que quiere quitar el empleado seleccionado?.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
                            pregunta = "si"
                        Else
                            'aqui corto el ciclo, ya que se cancelo la eliminacion
                            i = DG_empleados.Rows.Count
                        End If
                    End If
                    If pregunta = "si" Then
                        'primero guardo el nro de item q contiene
                        Dim item As Decimal = DG_empleados.CurrentRow.Index
                        'valido eso de las 2 opciones que detalle arriba
                        'Dim estado As String = DG_empleados.Rows(i).Cells("EnBDDataGridViewTextBoxColumn").Value
                        'If estado = "no" Then
                        'no esta guardado en bd, asi que solo quito
                        'Else
                        'si esta en bd, entonces actualizo en bd, el estado del campo SucxClie_estado = "eliminado"
                        'DAcliente.Cliente_Sucursales_eliminar(CInt(DG_Servicio.Rows(i).Cells("SucxClieidDataGridViewTextBoxColumn").Value), "ELIMINADO")
                        DG_empleados.Rows.RemoveAt(i)
                        i = 0 'lo reinicio, x q al quitar un ite, se reordenan los indices
                    End If
                    
                    'End If
                Else
                    i = i + 1
                End If
            End While

            'If pregunta = "si" Then
            '    MessageBox.Show("Eliminación correcta, los datos fueron actualizados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
            If valido_seleccion = "no" Then
                MessageBox.Show("Error, seleccione un empleado para eliminar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("No hay empleados asignadas a la cuadrilla.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        recalcular_grilla_y_empleados()

    End Sub

    Private Sub recalcular_grilla_y_empleados()

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
        Label_total_empleados.Text = "Empleados asignados a cuadrilla: " + CStr(DG_empleados.Rows.Count)
    End Sub

End Class