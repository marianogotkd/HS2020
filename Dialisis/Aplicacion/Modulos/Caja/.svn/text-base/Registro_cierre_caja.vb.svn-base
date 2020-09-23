Public Class Registro_cierre_caja
    Dim DAcaja As New Datos.Caja
    Dim APcaja As New Aplicacion.Caja
    Public Caja_id As Integer
    Private Sub Registro_cierre_caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sucursal_id As Integer = Inicio.suc_id 'yo se q esta sucursal tiene la caja abierta...x la validacion del form del q vengo
        Dim usuario_id As Integer = Inicio.USU_id
        'voy a cargar en la grilla el detalle de la caja
        Dim ds_caja As DataSet = DAcaja.Caja_obtener_detalle(usuario_id, sucursal_id, US_administrador.TurnoUsuario_id)
        If ds_caja.Tables(0).Rows.Count <> 0 Then
            TextBox_montoinicial.Text = CDec(ds_caja.Tables(0).Rows(0).Item("CAJA_montoinicial"))
            Label_usuario.Text = "Usuario: " + ds_caja.Tables(0).Rows(0).Item("Usuario")
            Label_sucursal.Text = "Sucursal: " + ds_caja.Tables(0).Rows(0).Item("Sucursal")
            TextBox_ingresos_efectivo.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoingresosefectivo")
            TextBox_ingresos_tarjeta.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoingresostarjeta")
            TextBox_egresos_subtotal.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoegresos")
            TextBox_TOTAL.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoneto")
            LB_fecha.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_apertura")
            Caja_id = ds_caja.Tables(0).Rows(0).Item("Caja_id")
            If ds_caja.Tables(1).Rows.Count <> 0 Then
                DG_caja.DataSource = ds_caja.Tables(1)
                ''sumamos los ingresos
                'Dim i As Integer = 0
                'Dim ingresos As Decimal = 0
                'Dim egresos As Decimal = 0
                'While i < DG_caja.Rows.Count
                '    If DG_caja.Rows(i).Cells("CajaTipoMovdescripcionDataGridViewTextBoxColumn").Value = "Ingreso" Then
                '        ingresos = ingresos + CDec(DG_caja.Rows(i).Cells("CAJAdetalleingreso").Value)
                '    End If
                '    If DG_caja.Rows(i).Cells("CajaTipoMovdescripcionDataGridViewTextBoxColumn").Value = "Egreso" Then
                '        egresos = egresos + CDec(DG_caja.Rows(i).Cells("CAJAdetalleegreso").Value)
                '    End If
                '    i = i + 1
                'End While
                ''ahora saco la diferencia
                'Dim total As Decimal = CDec(TextBox_montoinicial.Text) + ingresos - egresos
                'TextBox_ingresos_subtotal.Text = ingresos
                'TextBox_egresos_subtotal.Text = egresos
            End If
        Else
            Me.Close()
            MessageBox.Show("No puede ingresar con este usuario", "Sistema de Gestión")
        End If
        
    End Sub


    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click
        'tx_parcial.Text = CDec(tx_parcial.Text)
        'DAcaja.Caja_cierre(Inicio.USU_id, Now, Caja_id)
        'MessageBox.Show("Caja Cerrada correctamente", "Sistema de Gestion.")
        'APcaja.Caja_Validar()
        Me.Close()
        Corte_caja.Show()

    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Registro_inicio_cierre.Show()
        Me.Close()
    End Sub

  
End Class