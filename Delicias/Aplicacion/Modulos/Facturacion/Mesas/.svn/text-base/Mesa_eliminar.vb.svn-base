Public Class Mesa_eliminar
    Dim DAMesas As New Datos.Venta
    Public MESA_id As Integer = 0
    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click

        If tx_NROMESA.Text <> "" Then
            DS_mesas = DAMesas.Mesas_obtener_todas()
            'obtenemos un id para mesa...
            Dim i As Integer = 0
            Dim esta As String = "no"
            While i < DS_mesas.Tables(0).Rows.Count
                If DS_mesas.Tables(0).Rows(i).Item("Sector_id") = ComboBox1.SelectedValue Then
                    If DS_mesas.Tables(0).Rows(i).Item("Activo") = "Si" And (DS_mesas.Tables(0).Rows(i).Item("MESA_numero") = CInt(tx_NROMESA.Text)) Then
                        esta = "si"
                        MESA_id = DS_mesas.Tables(0).Rows(i).Item("MESA_id")
                        'antes de borrar debo validar q la mesa solo este como Libre y no otro estado como OCUPADO O COBRADO
                        If DS_mesas.Tables(0).Rows(i).Item("Estado") = "Libre" Then


                            'ahora lo BORROR, es decir cambio su estado de Libre o lo que sea a estado="" , activo="no"
                            DAMesas.MESAS_modificar(MESA_id, CInt(tx_NROMESA.Text), "", "no", CInt(0))
                            Mesas_gestion_2_new.Deshabilitar_mesas()
                            Mesas_gestion_2_new.recuperar_mesas()
                            Mesas_gestion_2_new.habilitar_mesas()
                            MessageBox.Show("La mesa se elimino correctamente", "Sistema de Gestion.")

                            tx_NROMESA.Focus()
                            tx_NROMESA.SelectAll()

                        Else
                            MessageBox.Show("La mesa no se puede eliminar, no esta libre", "Sistema de Gestion.")
                        End If
                        i = DS_mesas.Tables(0).Rows.Count

                    End If

                    'If DS_mesas.Tables(0).Rows(i).Item("Activo") = "no" Then
                    '    MESA_id = DS_mesas.Tables(0).Rows(i).Item("MESA_id")
                    '    i = DS_mesas.Tables(0).Rows.Count
                    'End If
                End If
                i = i + 1
            End While

            If esta = "no" Then
                MessageBox.Show("La mesa no existe", "Sistema de Gestion.")
            End If
        Else
            MessageBox.Show("Ingrese el número de mesa", "Sistema de Gestion.")
        End If
    End Sub

    Dim ds_sectores As DataSet
    Dim DS_mesas As DataSet
    Private Sub Mesa_eliminar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ds_sectores = DAMesas.Sector_obtener()
        ComboBox1.DataSource = ds_sectores.Tables(0)
        ComboBox1.DisplayMember = "Sector_nombre_usuario"
        ComboBox1.ValueMember = "Sector_id"

        DS_mesas = DAMesas.Mesas_obtener_todas()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub tx_NROMESA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_NROMESA.KeyPress
        'solo numeros enteros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class