Public Class Corte_caja
    Dim DAcaja As New Datos.Caja
    Dim sucursal_id As Integer = Inicio.suc_id 'yo se q esta sucursal tiene la caja abierta...x la validacion del form del q vengo
    Dim usuario_id As Integer = Inicio.USU_id
    Public caja_id As Integer
    Dim APcaja As New Aplicacion.Caja
    Private Sub Corte_caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Formato de los Text Box
        txt_efectivo_esperado.BackColor = Color.White
        txt_diferencia.BackColor = Color.White
        txt_efectivo_actual.BackColor = Color.FromArgb(255, 255, 192)



        'voy a cargar en la grilla el detalle de la caja
        Dim ds_caja As DataSet = DAcaja.Caja_obtener_detalle(usuario_id, sucursal_id, US_administrador.TurnoUsuario_id, Inicio.CAJA_id)
        If ds_caja.Tables(0).Rows.Count <> 0 Then
            txt_usuario.Text = ds_caja.Tables(0).Rows(0).Item("Usuario").ToString
            txt_efectivo_esperado.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoneto")
            txt_efectivo_actual.Text = txt_efectivo_esperado.Text
            txt_diferencia.Text = "00,00"
            caja_id = ds_caja.Tables(0).Rows(0).Item("CAJA_id")
            Calcular()
        Else
            Me.Close()
            MessageBox.Show("la caja esta abierta por otro usuario", "Sistema de Gestión")
        End If


    End Sub

    Private Sub BO_Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cerrarturno.Click
        If MessageBox.Show("¿Está seguro de cerrar el turno actual?", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Cerrar_turno()
            'MessageBox.Show("Turno Cerrado Correctamente", "Sistema de Gestión")
            'elimino la vinculacion de usuario con terminal
            DAterminal.Usuario_x_Terminal_eliminar(Inicio.terminal_id)

            APcaja.Caja_Validar()
            MessageBox.Show("Turno cerrado correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If



    End Sub
    Private Sub Cerrar_turno()

        'If MessageBox.Show("¿Está seguro de cerrar el turno actual?", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
        'Dim ds_caja As DataSet = DAcaja.TurnoUsuario_Validar(usuario_id, sucursal_id)
        Dim observacion As String
        'If ds_caja.Tables(0).Rows.Count <> 0 Then

        If txt_diferencia.Text = 0 Then
            observacion = "Sin Diferencia de Caja"
        Else
            If txt_diferencia.Text > 0 Then
                observacion = "Sobrante de Caja"
            Else
                observacion = "Faltante de Caja"
            End If
        End If

        Dim ds_cerrarTurno As DataSet = DAcaja.TurnoUsuario_CerrarTurno(caja_id, Now, txt_diferencia.Text, observacion, txt_efectivo_esperado.Text, Inicio.terminal_id)
        'End If

        'End If



    End Sub
    Public Sub Calcular()
        txt_diferencia.Text = CDec(txt_efectivo_actual.Text) - CDec(txt_efectivo_esperado.Text)

        If txt_diferencia.Text < 0 Then
            txt_diferencia.ForeColor = Color.Red
        Else
            txt_diferencia.ForeColor = Color.Black
        End If

        If txt_diferencia.Text = 0 Then
            Img_ok.Visible = True
        Else
            Img_ok.Visible = False
        End If
    End Sub
    Private Sub txt_efectivo_actual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_efectivo_actual.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.txt_efectivo_actual.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER le doy el formato
            If txt_efectivo_actual.Text = "" Then
                txt_efectivo_actual.Text = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                txt_efectivo_actual.Text = (Math.Round(CDec(txt_efectivo_actual.Text), 2).ToString("N2"))
            End If

            Calcular()

        End If


    End Sub

    Dim DAterminal As New Datos.Terminal
    Private Sub btn_cerrar_caja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar_caja.Click
        If MessageBox.Show("¿Está seguro de cerrar la caja actual?", "Sistema de Gestión.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Cerrar_turno()
            DAcaja.Caja_cierre(Now, caja_id, Inicio.terminal_id)
            'MessageBox.Show("Caja Cerrada Correctamente", "Sistema de Gestión")
            'aqui elimino la vinculacion de usuario con terminal
            DAterminal.Usuario_x_Terminal_eliminar(Inicio.terminal_id)
            APcaja.Caja_Validar()

            MessageBox.Show("Caja cerrada correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class