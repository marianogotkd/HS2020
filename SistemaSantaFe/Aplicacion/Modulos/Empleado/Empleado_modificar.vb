Imports System.IO
Imports System.Data.OleDb

Public Class Empleado_modificar

    Dim DAempleado As New Datos.Empleado
   

    Private Sub Empleado_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'BO_Buscar_dni.Enabled = False
        'TabPage2.Enabled = False

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
        Empleado_alta.Close()
        Empleado_alta.Show()
    End Sub

    Private Sub BO_cliente_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_modificar.Click
        If DG_empleados.Rows.Count <> 0 Then
            Dim empleadoselec As String = DG_empleados.SelectedCells(0).Value
            If empleadoselec <> "" Then
                Empleado_alta.Close()

                Empleado_alta.Text = "Modificar empleado"
                Empleado_alta.empleado_id = CInt(DG_empleados.CurrentRow.Cells("EmpleadoidDataGridViewTextBoxColumn").Value)
                Empleado_alta.form_procedencia = "modificar"

                'ya que estoy paso todo los datos
                Empleado_alta.tx_dni_emp.ReadOnly = True
                Empleado_alta.tx_dni_emp.Text = DG_empleados.CurrentRow.Cells("EmpleadodniDataGridViewTextBoxColumn").Value
                Dim lista() As String = CStr(DG_empleados.CurrentRow.Cells("ApellidoynombreDataGridViewTextBoxColumn").Value).Split(",")
                Dim apellido As String = lista(0)
                Dim nombre As String = lista(1)
                Empleado_alta.tx_nom_emp.Text = nombre
                Empleado_alta.tx_ape_emp.Text = apellido
                Empleado_alta.tx_dir_emp.Text = DG_empleados.CurrentRow.Cells("EmpleadodirDataGridViewTextBoxColumn").Value
                Empleado_alta.tx_mail_emp.Text = DG_empleados.CurrentRow.Cells("EmpleadomailDataGridViewTextBoxColumn").Value
                Empleado_alta.tx_tel_emp.Text = DG_empleados.CurrentRow.Cells("empleado_tel").Value
                Empleado_alta.tx_cel_emp.Text = DG_empleados.CurrentRow.Cells("empleado_cel").Value

                Empleado_alta.Show()
                'Me.Close()
            Else
                MessageBox.Show("Seleccione un empleado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un empleado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class