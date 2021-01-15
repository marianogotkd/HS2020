Public Class Cuadrilla_consultar
    Dim DAcuadrilla As New Datos.Cuadrilla
    Private Sub Cuadrilla_consultar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_cuadrillas()
    End Sub



    Public Sub recuperar_cuadrillas()

        ds_cuadrilla.Tables("Cuadrillas").Rows.Clear()


        Dim ds_cuad As DataSet = DAcuadrilla.Cuadrilla_obtener_todo
        If ds_cuad.Tables(0).Rows.Count <> 0 Then

            Dim i As Integer = 0
            While i < ds_cuad.Tables(0).Rows.Count
                Dim fila As DataRow = Ds_cuadrilla.Tables("Cuadrillas").NewRow
                fila("Cuadrilla_id") = ds_cuad.Tables(0).Rows(i).Item("Cuadrilla_id")
                fila("Cuadrilla_descripcion") = ds_cuad.Tables(0).Rows(i).Item("Cuadrilla_descripcion")
                fila("Salario") = ds_cuad.Tables(0).Rows(i).Item("Cuadrilla_salario_x_hora")
                'ahora los miembros en una cadena
                Dim miembros As String = ""
                Dim j As Integer = 0
                Dim cuadrilla_id As Integer = ds_cuad.Tables(0).Rows(i).Item("Cuadrilla_id")
                While j < ds_cuad.Tables(1).Rows.Count
                    If cuadrilla_id = ds_cuad.Tables(1).Rows(j).Item("Cuadrilla_id") Then
                        If miembros = "" Then
                            miembros = ds_cuad.Tables(1).Rows(j).Item("apellidoynombre")
                        Else
                            miembros = miembros + "/ " + ds_cuad.Tables(1).Rows(j).Item("apellidoynombre")
                        End If
                    End If
                    j = j + 1
                End While
                fila("Miembros") = miembros
                Ds_cuadrilla.Tables("Cuadrillas").Rows.Add(fila)
                i = i + 1
            End While
            '    ds_empleados.Tables("empleados").Merge(ds_emp.Tables(0))
        End If

    End Sub

    Private Sub BO_cliente_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_nuevo.Click
        Cuadrilla_alta.Close()
        Cuadrilla_alta.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "Cuadrilla_descripcion", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        CuadrillasBindingSource.Filter = Filtro
        'formato_grilla()
        If DG_empleados.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(Miembros, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            CuadrillasBindingSource.Filter = Filtro
            'formato_grilla()
            'If DG_empleados.Rows.Count = 0 Then
            '    Filtro = String.Format("CONVERT(prod_codbarra, System.String) LIKE '%{0}%'", Tx_Buscqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
            '    ProdxSucBindingSource.Filter = Filtro
            '    formato_grilla()
            'End If
        End If
    End Sub

    Private Sub BO_cliente_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_modificar.Click
        If DG_empleados.Rows.Count <> 0 Then

            Cuadrilla_alta.Close()
            Cuadrilla_alta.procedencia = "modificar"
            Cuadrilla_alta.Cuadrilla_id = CInt(DG_empleados.CurrentRow.Cells("CuadrillaidDataGridViewTextBoxColumn").Value)

            Cuadrilla_alta.Show()

            Me.Close()

        Else
            MessageBox.Show("Error, debe seleccionar una cuadrilla para editar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class