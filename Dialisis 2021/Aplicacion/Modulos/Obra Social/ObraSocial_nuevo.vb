Public Class ObraSocial_nuevo
    Dim DAobra As New Datos.ObraSocial
    Public form_procedencia = "alta"


    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'guardamos solamente nombre

        If form_procedencia = "alta" Then
            alta()
        End If
        If form_procedencia = "modificar" Then
            modificar()
        End If



        




    End Sub

    Private Sub alta()
        If txt_nombre.Text <> "" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea aguardar nueva Obra Social?", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                DAobra.ObraSocial_alta(txt_nombre.Text)
                MessageBox.Show("Los datos se guardaron correctamente", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'aqui viene el limpiar
                limpiar_alta()
                'luego recupero el proximo id para agregar a la bd
            End If
        Else
            MessageBox.Show("Error, complete la información para guardar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub modificar()
        If txt_nombre.Text <> "" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea modificar Obra Social?", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                DAobra.ObraSocial_actualizar(CInt(txt_id.Text), txt_nombre.Text)
                MessageBox.Show("Los datos se guardaron correctamente", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'aqui viene el limpiar
                ObraSocial_actualizar.Close()
                ObraSocial_actualizar.Show()
                Me.Close()
                'luego recupero el proximo id para agregar a la bd
            End If
        Else
            MessageBox.Show("Error, complete la información para guardar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub limpiar_alta()
        txt_id.Clear()
        txt_nombre.Clear()
        txt_nombre.Focus()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        If form_procedencia = "alta" Then
            limpiar_alta()
        Else
            ObraSocial_actualizar.Close()
            ObraSocial_actualizar.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ObraSocial_nuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ds As DataSet = DAobra.ObraSocial_Obtener()
        If ds.Tables(0).Rows.Count <> 0 Then
            txt_id.Text = ds.Tables(0).Rows.Count + 1
        Else
            txt_id.Text = 1

        End If
    End Sub
End Class