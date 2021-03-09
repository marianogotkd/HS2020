Public Class Sector_modificar


    Dim DAMesas As New Datos.Venta

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click

        If tx_sector1.Text <> "" Then
            DAMesas.Mesas_Sector_modificar("Sector 1", tx_sector1.Text)
        End If

        If tx_sector2.Text <> "" Then
            DAMesas.Mesas_Sector_modificar("Sector 2", tx_sector2.Text)
        End If

        If tx_sector3.Text <> "" Then
            DAMesas.Mesas_Sector_modificar("Sector 3", tx_sector3.Text)
        End If


        If tx_sector4.Text <> "" Then
            DAMesas.Mesas_Sector_modificar("Sector 4", tx_sector4.Text)
        End If


        MessageBox.Show("Los sectores se modificaron correctamente", "Sistema de Gestion.")
        Mesas_gestion_2_new.sectores_obtener_nombre()
        Mesas_gestion_2_new.recuperar_mesas()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class