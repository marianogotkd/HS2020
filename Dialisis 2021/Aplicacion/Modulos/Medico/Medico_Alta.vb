Imports System.IO
Imports System.Data.OleDb

Public Class Medico_Alta
    Dim DAmedico As New Datos.Medico

    Public Med_id As Integer
    Public form_procedencia As String = "alta"

    Public apertura As String = "menu_alta" 'esta variable me sirve para saber desde donde lo abro, si lo abro a la "Alta" desde el menu...el boton cancelar...solo borra lo q se escribe en los textbox.


 

    Private Sub Medico_Alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        tx_nom_ape.Focus()
        tx_nom_ape.TextAlign = HorizontalAlignment.Center
        tb_Dni_Cuit.TextAlign = HorizontalAlignment.Center
        ' tb_Dni_Cuit.MaxLength = 8
        Tb_esp.TextAlign = HorizontalAlignment.Center
        tb_mat.TextAlign = HorizontalAlignment.Center
        'Habilitar()
        If form_procedencia = "modificar" Then
            recuperar_datos_medico()
            tb_Dni_Cuit.ReadOnly = True
        End If
    End Sub
    Public Sub recuperar_datos_medico()
        Dim ds_med As DataSet = DAmedico.Medicos_Obtener_X_id(Med_id)
        If ds_med.Tables(0).Rows.Count <> 0 Then
            tx_nom_ape.Text = ds_med.Tables(0).Rows(0).Item("medico_nombre")
            tb_Dni_Cuit.Text = ds_med.Tables(0).Rows(0).Item("medico_dni")
            tb_Dni_Cuit.ReadOnly = True
            Tb_esp.Text = ds_med.Tables(0).Rows(0).Item("medico_esp")
            tb_mat.Text = ds_med.Tables(0).Rows(0).Item("medico_matricula")
        End If


    End Sub

    Private Sub alta()
        If tb_Dni_Cuit.Text <> "" And Tb_esp.Text <> "" And tb_mat.Text <> "" And tx_nom_ape.Text <> "" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea dar de alta al Medico?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then


                Dim ds_CLI_dni As DataSet = DAmedico.Medico_VerificarDni(tb_Dni_Cuit.Text)
                With ds_CLI_dni.Tables(0).Rows
                    If .Count = 0 Then

                        Dim ds_cliente_alta As DataSet = DAmedico.medico_alta(tx_nom_ape.Text, tb_Dni_Cuit.Text, Tb_esp.Text, tb_mat.Text, "activo")
                        MessageBox.Show("El Medico fue dado de alta correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        limpiar()

                    Else
                        MessageBox.Show("Error, el Medico ya existe.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tb_Dni_Cuit.Focus()
                        tb_Dni_Cuit.SelectAll()
                    End If
                End With
            End If
        Else
            MessageBox.Show("Error, Ingrese los campos obligatorios", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            err_nom.Visible = True
            error_dni.Visible = True
            err_esp.Visible = True
            err_mat.Visible = True
        End If
    End Sub
    Private Sub limpiar_deshabilitar()

    End Sub
    Private Sub modificar()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar el Medico?", "Sistema de Gestión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            DAmedico.medico_Modificar(Med_id, tx_nom_ape.Text, Tb_esp.Text, tb_mat.Text)


            MessageBox.Show("El Medico se modificó correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Medico_Actualizar.Obtener_Medicos()
            Me.Close()
            Medico_Actualizar.Close()
            Medico_Actualizar.Show()
        End If
        limpiar_deshabilitar()
    End Sub
    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If form_procedencia = "alta" Then
            alta()
        End If
        If form_procedencia = "modificar" Then
            Modificar()
        End If


    
    End Sub
    Public Sub limpiar()
        tx_nom_ape.Text = ""
        tb_Dni_Cuit.Text = ""
        Tb_esp.Text = ""
        tb_mat.Text = ""
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        limpiar()
    End Sub
    Dim validacion As New Validaciones

    Private Sub tb_Dni_Cuit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Dni_Cuit.GotFocus
        validacion.Formatos_backcolor_textbox_y_combobox("GotFocus", tb_Dni_Cuit)
    End Sub
    Private Sub tb_Dni_Cuit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Dni_Cuit.KeyPress
        validacion.Restricciones_textbox(e, "Entero", tb_Dni_Cuit)
    End Sub

    Private Sub tb_mat_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_mat.GotFocus
        validacion.Formatos_backcolor_textbox_y_combobox("GotFocus", tb_mat)
    End Sub

    Private Sub tb_mat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_mat.KeyPress
        validacion.Restricciones_textbox(e, "Entero", tb_mat)
    End Sub

    Private Sub tx_nom_ape_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_nom_ape.GotFocus
        validacion.Formatos_backcolor_textbox_y_combobox("GotFocus", tx_nom_ape)
    End Sub

    Private Sub tx_nom_ape_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_nom_ape.LostFocus
        validacion.Formatos_backcolor_textbox_y_combobox("LostFocus", tx_nom_ape)
    End Sub

    Private Sub Tb_esp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tb_esp.GotFocus
        validacion.Formatos_backcolor_textbox_y_combobox("GotFocus", Tb_esp)
    End Sub

    Private Sub Tb_esp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tb_esp.LostFocus
        validacion.Formatos_backcolor_textbox_y_combobox("LostFocus", Tb_esp)
    End Sub

    Private Sub tb_Dni_Cuit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_Dni_Cuit.LostFocus
        validacion.Formatos_backcolor_textbox_y_combobox("LostFocus", tb_Dni_Cuit)
    End Sub

    Private Sub tb_mat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb_mat.LostFocus
        validacion.Formatos_backcolor_textbox_y_combobox("LostFocus", tb_mat)
    End Sub
End Class