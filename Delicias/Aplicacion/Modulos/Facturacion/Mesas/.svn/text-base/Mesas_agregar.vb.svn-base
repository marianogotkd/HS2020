Public Class Mesas_agregar
    Dim DAMesas As New Datos.Venta

    Public MESA_id As Integer = 0
    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If tx_NROMESA.Text <> "" Then

            MESA_id = 0
            DS_mesas = DAMesas.Mesas_obtener_todas()
            'obtenemos un id para mesa...
            Dim i As Integer = 0
            While i < DS_mesas.Tables(0).Rows.Count
                If DS_mesas.Tables(0).Rows(i).Item("Sector_id") = ComboBox1.SelectedValue Then
                    If DS_mesas.Tables(0).Rows(i).Item("Activo") = "no" And DS_mesas.Tables(0).Rows(i).Item("MESA_numero") = CInt(tx_NROMESA.Text) Then
                        MESA_id = DS_mesas.Tables(0).Rows(i).Item("MESA_id")
                        i = DS_mesas.Tables(0).Rows.Count
                    End If
                End If
                i = i + 1
            End While

            If MESA_id <> 0 Then
                'antes de guardar tengo q verificar el nro de mesa ya no exista....
                Dim j As Integer = 0
                Dim existe As String = "no"
                While j < DS_mesas.Tables(0).Rows.Count
                    If DS_mesas.Tables(0).Rows(j).Item("Sector_id") = ComboBox1.SelectedValue Then
                        If tx_NROMESA.Text = DS_mesas.Tables(0).Rows(j).Item("MESA_numero") And DS_mesas.Tables(0).Rows(j).Item("Activo") = "Si" Then
                            existe = "si"
                            j = DS_mesas.Tables(0).Rows.Count
                        End If
                    End If
                    j = j + 1
                End While
                If existe = "no" Then
                    DAMesas.MESAS_modificar(MESA_id, CInt(tx_NROMESA.Text), "Libre", "Si", CInt(0))
                    Mesas_gestion_2_new.Deshabilitar_mesas()
                    Mesas_gestion_2_new.recuperar_mesas()
                    Mesas_gestion_2_new.habilitar_mesas()
                    MessageBox.Show("La mesa se agrego correctamente", "Sistema de Gestion.")
                Else
                    MessageBox.Show("La mesa ya existe", "Sistema de Gestion.")
                End If
            Else
                MessageBox.Show("Se ha superado el máximo de mesas por sector", "Sistema de Gestion.")
            End If
        Else
            MessageBox.Show("Ingrese el número de mesa", "Sistema de Gestion.")
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Dim ds_sectores As DataSet
    Dim DS_mesas As DataSet
    Private Sub Mesas_agregar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ds_sectores = DAMesas.Sector_obtener()
        ComboBox1.DataSource = ds_sectores.Tables(0)
        ComboBox1.DisplayMember = "Sector_nombre_usuario"
        ComboBox1.ValueMember = "Sector_id"

        DS_mesas = DAMesas.Mesas_obtener_todas()


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