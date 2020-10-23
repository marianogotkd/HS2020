Public Class Cuadrilla_agregar_empleado
    Dim DAempleado As New Datos.Empleado



    Private Sub Cuadrilla_agregar_empleado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_empleados()
    End Sub


    Public Sub recuperar_empleados()
        Ds_empleados.Tables("empleados").Rows.Clear()
        Dim ds_emp As DataSet = DAempleado.Empleados_obtenertodos
        If ds_emp.Tables(0).Rows.Count <> 0 Then
            Ds_empleados.Tables("empleados").Merge(ds_emp.Tables(0))
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "apellido_y_nombre", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        EmpleadosBindingSource.Filter = Filtro
        'formato_grilla()
        If DG_empleados.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(empleado_dni, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            EmpleadosBindingSource.Filter = Filtro
            'formato_grilla()
            'If DG_empleados.Rows.Count = 0 Then
            '    Filtro = String.Format("CONVERT(prod_codbarra, System.String) LIKE '%{0}%'", Tx_Buscqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
            '    ProdxSucBindingSource.Filter = Filtro
            '    formato_grilla()
            'End If
        End If
    End Sub

    Private Sub BO_cliente_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_nuevo.Click
        If DG_empleados.Rows.Count <> 0 Then
            'antes de agregar controlo si no esta agregado
            Dim id_empleado As Integer = DG_empleados.CurrentRow.Cells("EmpleadoidDataGridViewTextBoxColumn").Value

            Dim i As Integer = 0
            Dim existe = "no"
            While i < Cuadrilla_alta.DG_empleados.Rows.Count
                If Cuadrilla_alta.DG_empleados.Rows(i).Cells("EmpleadoidDataGridViewTextBoxColumn").Value = id_empleado Then
                    existe = "si"
                    Exit While
                End If
                i = i + 1
            End While
            If existe = "no" Then
                Dim fila As DataRow = Cuadrilla_alta.Ds_cuadrilla.Tables("Empleados").NewRow
                fila("empleado_id") = DG_empleados.CurrentRow.Cells("EmpleadoidDataGridViewTextBoxColumn").Value
                fila("empleado_dni") = DG_empleados.CurrentRow.Cells("EmpleadodniDataGridViewTextBoxColumn").Value
                fila("apellido_y_nombre") = DG_empleados.CurrentRow.Cells("ApellidoynombreDataGridViewTextBoxColumn").Value
                fila("salario_x_hora") = CDec(0)

                Cuadrilla_alta.Ds_cuadrilla.Tables("Empleados").Rows.Add(fila)
                Cuadrilla_alta.Label_total_empleados.Text = "Empleados asignados a cuadrilla: " + CStr(Cuadrilla_alta.DG_empleados.Rows.Count)
                Me.Close()
                Cuadrilla_alta.Focus()
            Else
                MessageBox.Show("Error, el empleado ya se encuentra agregado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error, debe seleccionar un empleado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class