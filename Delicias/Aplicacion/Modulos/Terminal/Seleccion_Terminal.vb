
Public Class Seleccion_Terminal
    Dim DAterminal As New Datos.Terminal
    Dim ds_terminal As DataSet
    Dim var


    Private Sub Seleccion_Terminal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If var <> "siguiente" Then
            Inicio.Visible = True
        End If

    End Sub

    Private Sub Seleccion_Terminal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Button_siguiente.Focus()
        Dim suc_id As String
        suc_id = Inicio.suc_id  'obtengo del formulario inicio el id del usuario logueado
        ds_terminal = DAterminal.Terminal_obtener_todo(suc_id)

        If ds_terminal.Tables(0).Rows.Count <> 0 Then 'la tabla 1 trae la empresa con el inner join de la sucursal
            'primero quito las terminales que estan bloquedas.ç
            Dim i As Integer = 0
            While i < ds_terminal.Tables(0).Rows.Count
                If ds_terminal.Tables(0).Rows(i).Item("Terminales_estado") = "Bloqueado" Then
                    ds_terminal.Tables(0).Rows.RemoveAt(i)
                    i = 0 'se reinicia para recorrer nuevamente el datatable
                Else
                    i = i + 1
                End If

            End While
            Dim empresa_id As Integer = 0
            ComboBox_Terminales.DataSource = ds_terminal.Tables(0)
            ComboBox_Terminales.DisplayMember = "Terminales_desc"
            ComboBox_Terminales.ValueMember = "Terminales_id"
        End If

    End Sub
    Dim APcaja As New Aplicacion.Caja 'la uso para validar la apertura de caja entre otras cosas
    Private Sub Button_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_siguiente.Click
        var = "siguiente"
        Dim ds As DataSet = DAterminal.Usuario_x_Terminal_Validar(Inicio.USU_id, ComboBox_Terminales.SelectedValue)

        If ds.Tables(0).Rows.Count = 0 Then
            DAterminal.Usuario_x_Terminal_Registrar(Inicio.USU_id, ComboBox_Terminales.SelectedValue)
            Inicio.terminal_id = ComboBox_Terminales.SelectedValue
            US_administrador.Lbl_Terminal.Text = ComboBox_Terminales.Text
            US_administrador.Lbl_Terminal.Visible = True
            US_administrador.Show()
            APcaja.Caja_Validar()
            Me.Close()

        Else
            If Inicio.UT_id = 1 Then 'si es admin, ingreso siempre
                'entro
                Inicio.terminal_id = ComboBox_Terminales.SelectedValue
                US_administrador.Lbl_Terminal.Text = ComboBox_Terminales.Text
                US_administrador.Lbl_Terminal.Visible = True
                US_administrador.Show()
                APcaja.Caja_Validar()
                Me.Close()
            Else 'si no es admin, que valide el acceso a la terminal
                If ds.Tables(0).Rows(0).Item("USU_id") = Inicio.USU_id Then
                    'entro
                    Inicio.terminal_id = ComboBox_Terminales.SelectedValue
                    US_administrador.Lbl_Terminal.Text = ComboBox_Terminales.Text
                    US_administrador.Lbl_Terminal.Visible = True
                    US_administrador.Show()
                    APcaja.Caja_Validar()
                    Me.Close()
                Else
                    'no entro
                    Dim apellidoynombre As String = ds.Tables(0).Rows(0).Item("ApellidoyNombre")
                    MessageBox.Show("Lo sentimos la terminal se encuentra en uso por el usuario:" + apellidoynombre, "Sistema de Gestión.", MessageBoxButtons.OK)
                    Inicio.Visible = True
                    Me.Close()
                End If
            End If
            
        End If






    End Sub
End Class