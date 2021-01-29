Public Class ObraSocial_actualizar
    Dim Daobra As New Datos.ObraSocial
    'Dim ds_obrasoc As ds_obrasocial
    Private Sub ObraSocial_actualizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_obras_existentes()
    End Sub
    Private Sub recuperar_obras_existentes()
        Ds_obrasocial.Tables("Obrasocial").Rows.Clear()
        Dim ds As DataSet = Daobra.ObraSocial_Obtener()
        Ds_obrasocial.Tables("Obrasocial").Merge(ds.Tables(0))
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ObraSocial_nuevo.Close()
        ObraSocial_nuevo.form_procedencia = "alta"
        ObraSocial_nuevo.Show()
        Me.Close()
    End Sub

    Private Sub Button_Detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Detalle.Click
        If DataGridView1.Rows.Count <> 0 Then
            'If DataGridView1.CurrentRow.Cells("Column1").Value = True Then
            ObraSocial_nuevo.Close()
            ObraSocial_nuevo.form_procedencia = "modificar"
            ObraSocial_nuevo.txt_id.Text = DataGridView1.CurrentRow.Cells("ObrasocialidDataGridViewTextBoxColumn").Value
            ObraSocial_nuevo.txt_nombre.Text = DataGridView1.CurrentRow.Cells("ObrasocialnombreDataGridViewTextBoxColumn").Value
            ObraSocial_nuevo.Show()
            Me.Close()
            'Else

            'End If
        Else
            MessageBox.Show("Error, debe seleccionar una obra social.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub btn_Anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Anular.Click
        If DataGridView1.Rows.Count <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("Esta seguro de eliminar la Obra Social: " + DataGridView1.CurrentRow.Cells("ObrasocialnombreDataGridViewTextBoxColumn").Value, "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                'validamos si tiene pacientes vinculados a el

                'ahora borro

                Daobra.ObraSocial_eliminar(CInt(DataGridView1.CurrentRow.Cells("ObrasocialidDataGridViewTextBoxColumn").Value))
                MessageBox.Show("La obra social fue eliminada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ahora vuelvo a cargar la grilla.
                recuperar_obras_existentes()
            End If
        Else
            MessageBox.Show("Error, debe seleccionar una obra social para eliminar", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class