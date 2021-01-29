Public Class Enfermeria_pacientes_seleccionar
    Dim DAsesiones As New Datos.Sesiones
    Private Sub obtener_pacientes()
        Ds_enfermeria.Tables("Paciente1").Rows.Clear()
        Dim ds As DataSet = DAsesiones.Sesiones_obtener_activos_pacientes()
        If ds.Tables(0).Rows.Count <> 0 Then

            Ds_enfermeria.Tables("Paciente1").Merge(ds.Tables(0))
            'ahora recorro la tabla 1 para ver la cantidad de sesiones
            Dim i As Integer = 0
            While i < Ds_enfermeria.Tables("Paciente1").Rows.Count
                Dim PAC_id As Integer = Ds_enfermeria.Tables("Paciente1").Rows(i).Item("PAC_id")
                Dim cant As Integer = 0
                Dim j As Integer = 0
                While j < ds.Tables(1).Rows.Count
                    If PAC_id = ds.Tables(1).Rows(j).Item("PAC_id") Then
                        cant = cant + 1
                    End If
                    j = j + 1
                End While
                Ds_enfermeria.Tables("Paciente1").Rows(i).Item("cant_sesiones") = cant
                i = i + 1
            End While

        End If


    End Sub

    Private Sub Enfermeria_pacientes_seleccionar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        obtener_pacientes()
    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Filtro
        Filtro = String.Format("CONVERT(PAC_dni, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        Paciente1BindingSource.Filter = Filtro
        'Cliente1BindingSource.Filter = Filtro
        If DG_clientes.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(Paciente, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            Paciente1BindingSource.Filter = Filtro
            'Cliente1BindingSource.Filter = Filtro
            If DG_clientes.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(Obrasocial_nombre, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
                Paciente1BindingSource.Filter = Filtro
                'Cliente1BindingSource.Filter = Filtro
                If DG_clientes.Rows.Count = 0 Then
                    Filtro = String.Format("CONVERT(PACnumafi, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
                    Paciente1BindingSource.Filter = Filtro
                End If

            End If
        End If
    End Sub

    Private Sub BO_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_ver.Click
        If DG_clientes.Rows.Count <> 0 Then
            If DG_clientes.CurrentRow.Cells("cant_sesiones").Value <> 0 Then
                Dim form_registro As New Sesion_registro_x_paciente
                form_registro.PAC_id = DG_clientes.CurrentRow.Cells("PACidDataGridViewTextBoxColumn").Value
                form_registro.Show()
            Else
                MessageBox.Show("Error, el Paciente no posee sesiones realizadas.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            
        End If
    End Sub
End Class