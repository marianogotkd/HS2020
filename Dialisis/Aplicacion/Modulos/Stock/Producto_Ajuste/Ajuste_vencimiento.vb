Public Class Ajuste_vencimiento
    Public codinterno As Integer
    Public vence As String
    Public lote_id As Integer 'me lo manda el form producto_ajuste

    Private Sub Ajuste_vencimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vence = "si" Then
            'habilito el checkbox
            CheckBox_vto.Checked = True
            DateTimePicker_ffabricacion.Enabled = True
            DateTimePicker_fvencimiento.Enabled = True

        Else
            'lo destildo
            CheckBox_vto.Checked = False
            DateTimePicker_ffabricacion.Enabled = False
            DateTimePicker_fvencimiento.Enabled = False
        End If
    End Sub

    Private Sub CheckBox_vto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_vto.CheckedChanged
        If CheckBox_vto.Checked = True Then
            DateTimePicker_ffabricacion.Enabled = True
            DateTimePicker_fvencimiento.Enabled = True
        Else
            DateTimePicker_ffabricacion.Enabled = False
            DateTimePicker_fvencimiento.Enabled = False
        End If
    End Sub
    Dim dalote As New Datos.Lote
    Private Sub btn_agregarr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregarr.Click

        If MsgBox("¿Esta seguro que quiere confirmar los cambios?.", MsgBoxStyle.YesNo, "Sistema de Gestión.") = MsgBoxResult.Yes Then
            'aqui viene el update
            Dim vence As String
            Dim fechafab As Date
            Dim fechavto As Date
            If CheckBox_vto.Checked = True Then
                vence = "si"
                fechafab = DateTimePicker_ffabricacion.Value.Date
                fechavto = DateTimePicker_fvencimiento.Value.Date
            Else
                vence = "no"
                fechafab = Today
                fechavto = Today
            End If

            dalote.Ajuste_lote_vencimiento(lote_id, vence, fechafab, fechavto)

            'como se borro algo recupero todos los lotes nuevamente
            Producto_ajuste.recuperar_lotes()
            'ademas vuelvo a calcular el total de stock para mostrar en el textbox "TOTAL DE UNIDADES:"
            Producto_ajuste.calcular_total()
            MessageBox.Show("Datos actualizados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If


    End Sub
End Class