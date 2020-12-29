Public Class Sucursales_Seleccionar
    Dim DAcliente As New Datos.Cliente
    Dim DActacte As New Datos.CuentaCorriente
    Public cliente_id As Integer 'este parametro me lo envian de otro form
    Private Sub Sucursales_Seleccionar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ds_clie_recu As DataSet = DAcliente.Cliente_obtener_info(cliente_id)
        Dim i As Integer = 0
        If ds_clie_recu.Tables(3).Rows.Count <> 0 Then
            While i < ds_clie_recu.Tables(3).Rows.Count
                Dim fila As DataRow = Cliente_ds.Tables("Sucursales").NewRow
                fila("SucxClie_id") = ds_clie_recu.Tables(3).Rows(i).Item("SucxClie_id")
                fila("SucxClie_nombre") = ds_clie_recu.Tables(3).Rows(i).Item("SucxClie_nombre")
                fila("SucxClie_Prov") = ds_clie_recu.Tables(3).Rows(i).Item("SucxClie_Prov")
                fila("SucxClie_Loc") = ds_clie_recu.Tables(3).Rows(i).Item("SucxClie_Loc")
                fila("EnBD") = "si"
                fila("Provincia") = ds_clie_recu.Tables(3).Rows(i).Item("provincia")
                fila("Localidad") = ds_clie_recu.Tables(3).Rows(i).Item("Localidad")
                fila("SucxClie_tel") = ds_clie_recu.Tables(3).Rows(i).Item("SucxClie_tel")
                fila("SucxClie_mail") = ds_clie_recu.Tables(3).Rows(i).Item("SucxClie_mail")
                fila("SucxClie_dir") = ds_clie_recu.Tables(3).Rows(i).Item("SucxClie_dir")
                fila("SucxClie_CP") = ds_clie_recu.Tables(3).Rows(i).Item("SucxClie_CP")
                Cliente_ds.Tables("Sucursales").Rows.Add(fila)
                i = i + 1
            End While
        End If
    End Sub
End Class