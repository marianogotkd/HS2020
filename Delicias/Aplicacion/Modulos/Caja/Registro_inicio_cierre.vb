Public Class Registro_inicio_cierre
    Dim DAcaja As New Datos.Caja
    Dim DAusuario As New Datos.Usuario

    Dim APcaja As New Aplicacion.Caja

    Private Sub Registro_inicio_cierre_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Habilitar()
    End Sub

    Public Sub Habilitar()
        APcaja.Caja_Validar()
        Select Case (APcaja.SESION_CAJA)
            Case (1)
                BO_Abrir.Enabled = True
                BO_cierre.Enabled = False
                LB_Error.Visible = False
                IM_ERROR.Visible = False
            Case (2)
                BO_Abrir.Enabled = False
                BO_cierre.Enabled = True
                LB_Error.Visible = False
                IM_ERROR.Visible = False
            Case (3)
                BO_Abrir.Enabled = False
                BO_cierre.Enabled = False
                LB_Error.Visible = True
                IM_ERROR.Visible = True
        End Select

    End Sub

    Private Sub BO_Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Abrir.Click
        obtener_usuario_caja()
    End Sub


    Private Sub obtener_usuario_caja()
        'aqui valido q no haya una caja abierta....
        Dim ds_caja As DataSet = DAcaja.Caja_validad_AperturayCierre(Inicio.suc_id)

        If ds_caja.Tables(0).Rows.Count = 0 Then
            'entonces estoy x abrir la primera caja.
            Registro_monto_inicial.Show()
            Dim ds_usuario As DataSet = DAusuario.Usuario_obtener()
            Dim i As Integer = 0
            Dim nombre_usu As String = ""
            While i < ds_usuario.Tables(0).Rows.Count
                If Inicio.USU_id = ds_usuario.Tables(0).Rows(i).Item("USU_id") Then
                    nombre_usu = ds_usuario.Tables(0).Rows(i).Item("USU_ape") + " " + ds_usuario.Tables(0).Rows(i).Item("USU_nom")
                End If
                i = i + 1
            End While

            Registro_monto_inicial.LB_nombre_usu.Text = nombre_usu
            Registro_monto_inicial.LB_fecha.Text = Today

            Me.Close()
        Else
            'recorro la tabla y me fijo si hay un abierta.
            Dim ultimo_row As Integer = ds_caja.Tables(0).Rows.Count - 1
            If ds_caja.Tables(0).Rows(ultimo_row).Item("CAJA_estado") = "1" Then
                Dim usuario As String = ds_caja.Tables(0).Rows(ultimo_row).Item("USU_ape") + " " + ds_caja.Tables(0).Rows(ultimo_row).Item("USU_nom")
                MessageBox.Show("Error! La caja ya ha sido abierta por el usuario:" & usuario, "Sistema de Gestion.")
            Else
                Registro_monto_inicial.Show()
                Dim usuario As String = ds_caja.Tables(0).Rows(ultimo_row).Item("USU_ape") + " " + ds_caja.Tables(0).Rows(ultimo_row).Item("USU_nom")
                Registro_monto_inicial.LB_nombre_usu.Text = usuario
                Registro_monto_inicial.LB_fecha.Text = Today
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BO_cierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cierre.Click
        'aqui valido q haya una caja abierta por ESTE usuario....
        Dim ds_caja As DataSet = DAcaja.Caja_validad_AperturayCierre(Inicio.suc_id)

        If ds_caja.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Error! La caja no ha sido abierta", "Sistema de Gestion.")
        Else
            'recorro la tabla y me fijo si hay un abierta.
            Dim ultimo_row As Integer = ds_caja.Tables(0).Rows.Count - 1
            If ds_caja.Tables(0).Rows(ultimo_row).Item("CAJA_estado") = 1 And ds_caja.Tables(0).Rows(ultimo_row).Item("USU_id") = Inicio.USU_id Then
                Me.Close()
                Registro_cierre_caja.Show()
                'Dim usuario As String = ds_caja.Tables(0).Rows(ultimo_row).Item("USU_ape") + " " + ds_caja.Tables(0).Rows(ultimo_row).Item("USU_nom")
                'Registro_cierre_caja.LB_nombre_usu.Text = usuario
                'Registro_cierre_caja.LB_fecha.Text = Today
                'Registro_cierre_caja.tx_parcial.Text = Math.Round(ds_caja.Tables(0).Rows(ultimo_row).Item("CAJA_montoinicial"), 2).ToString
                'Registro_cierre_caja.tx_total.Text = Math.Round(ds_caja.Tables(0).Rows(ultimo_row).Item("CAJA_montoingresos"), 2).ToString
                'Registro_cierre_caja.tx_neto.Text = Math.Round(ds_caja.Tables(0).Rows(ultimo_row).Item("CAJA_montoneto"), 2).ToString

            Else
                Dim usuario As String = ds_caja.Tables(0).Rows(ultimo_row).Item("USU_ape") + " " + ds_caja.Tables(0).Rows(ultimo_row).Item("USU_nom")
                MessageBox.Show("Error! La caja ha sido abierta por el usuario:" & usuario, "Sistema de Gestion.")
            End If

        End If

    End Sub


    Private Sub LB_Error_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LB_Error.Click

        'aqui valido q no haya una caja abierta....
        Dim ds_caja As DataSet = DAcaja.Caja_validad_AperturayCierre(Inicio.suc_id)

        If ds_caja.Tables(0).Rows.Count = 0 Then
            ''entonces estoy x abrir la primera caja.
            'Registro_monto_inicial.Show()
            'Dim ds_usuario As DataSet = DAusuario.Usuario_obtener()
            'Dim i As Integer = 0
            'Dim nombre_usu As String = ""
            'While i < ds_usuario.Tables(0).Rows.Count
            '    If Inicio.USU_id = ds_usuario.Tables(0).Rows(i).Item("USU_id") Then
            '        nombre_usu = ds_usuario.Tables(0).Rows(i).Item("USU_ape") + " " + ds_usuario.Tables(0).Rows(i).Item("USU_nom")
            '    End If
            '    i = i + 1
            'End While

            'Registro_monto_inicial.LB_nombre_usu.Text = nombre_usu
            'Registro_monto_inicial.LB_fecha.Text = Today

            'Me.Close()
        Else
            'recorro la tabla y me fijo si hay un abierta.
            Dim ultimo_row As Integer = ds_caja.Tables(0).Rows.Count - 1
            If ds_caja.Tables(0).Rows(ultimo_row).Item("CAJA_estado") = "1" Then
                Dim usuario As String = ds_caja.Tables(0).Rows(ultimo_row).Item("USU_ape") + " " + ds_caja.Tables(0).Rows(ultimo_row).Item("USU_nom")
                MessageBox.Show("Error! La caja ya ha sido abierta por el usuario:" & usuario, "Sistema de Gestion.")
            Else
                'Registro_monto_inicial.Show()
                'Dim usuario As String = ds_caja.Tables(0).Rows(ultimo_row).Item("USU_ape") + " " + ds_caja.Tables(0).Rows(ultimo_row).Item("USU_nom")
                'Registro_monto_inicial.LB_nombre_usu.Text = usuario
                'Registro_monto_inicial.LB_fecha.Text = Today
                'Me.Close()
            End If
        End If


    End Sub
End Class