Public Class Sucursales_Seleccionar
    Dim DAcliente As New Datos.Cliente
    Dim DActacte As New Datos.CuentaCorriente
    Public cliente_id As Integer 'este parametro me lo envian de otro form
    Private Sub Sucursales_Seleccionar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ds_clie_recu As DataSet = DAcliente.Cliente_obtener_info(cliente_id)
        Dim a As Integer = 0
        If ds_clie_recu.Tables(3).Rows.Count <> 0 Then
            While a < ds_clie_recu.Tables(3).Rows.Count
                Dim fila As DataRow = Cliente_ds.Tables("Sucursales").NewRow
                fila("SucxClie_id") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_id")
                fila("SucxClie_nombre") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_nombre")
                fila("SucxClie_Prov") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_Prov")
                fila("SucxClie_Loc") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_Loc")
                fila("EnBD") = "si"
                fila("Provincia") = ds_clie_recu.Tables(3).Rows(a).Item("provincia")
                fila("Localidad") = ds_clie_recu.Tables(3).Rows(a).Item("Localidad")
                fila("SucxClie_tel") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_tel")
                fila("SucxClie_mail") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_mail")
                fila("SucxClie_dir") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_dir")
                fila("SucxClie_CP") = ds_clie_recu.Tables(3).Rows(a).Item("SucxClie_CP")
                Cliente_ds.Tables("Sucursales").Rows.Add(fila)
                a = a + 1
            End While
        Else
            MessageBox.Show("El cliente no posee sucursal, por favor asigne uno en la sección correspondiente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DG_Servicio.Rows.Count <> 0 Then
            Venta_Caja_gestion.SucxClie_id = CInt(DG_Servicio.CurrentRow.Cells("SucxClieidDataGridViewTextBoxColumn").Value)
            Venta_Caja_gestion.venta_clienta_pasar_pestaña()
            Me.Close()

        End If
    End Sub
End Class