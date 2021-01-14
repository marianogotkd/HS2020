Public Class Sucursales_Seleccionar
    Dim DAcliente As New Datos.Cliente
    Dim DActacte As New Datos.CuentaCorriente
    Public cliente_id As Integer 'este parametro me lo envian de otro form
    Public procedencia As String = "venta_caja_gestion"
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
    Dim APcaja As New Aplicacion.Caja 'la uso para validar la apertura de caja entre otras cosas
    Public facturar As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If procedencia = "venta_caja_gestion" Then
            If DG_Servicio.Rows.Count <> 0 Then
                Venta_Caja_gestion.SucxClie_id = CInt(DG_Servicio.CurrentRow.Cells("SucxClieidDataGridViewTextBoxColumn").Value)
                Venta_Caja_gestion.venta_clienta_pasar_pestaña()
                Me.Close()

            End If
        End If
        If procedencia = "servicio_nuevo" Then
            'valido que la caja este abierta
            If Inicio.UT_id = 1 Then
                APcaja.Caja_Validar_admin()
            Else
                APcaja.Caja_Validar()
            End If

            'APcaja.Caja_Validar()
            If APcaja.SESION_CAJA = 1 And US_administrador.no_caja <> "deshabilitar" Then '1 = caja nueva, lista para iniciar
                MessageBox.Show("Error!,primero debe abrir la caja diaria para registrar la venta", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Caja_abrir_turno.Close()
                'Caja_abrir_turno.Show()
            Else
                If APcaja.SESION_CAJA = 2 And US_administrador.no_caja <> "deshabilitar" Then
                    'por aqui continuo con el registro de la factura
                    facturar = "si" 'valido esto en el form de caja pago, caja tarjeta y forma de pago seleccion.
                    'aqui mando parametros a seleccionar forma de pago
                    Forma_de_pago_seleccion.Close()
                    'tengo que indicarle que vengo de servicio_nuevo
                    Forma_de_pago_seleccion.procedencia = "Servicio_Nuevo"
                    'mandar como parametro la id_de la sucursal que seleccioné
                    Dim SucxClie_id As Integer = CInt(DG_Servicio.CurrentRow.Cells("SucxClieidDataGridViewTextBoxColumn").Value)
                    Forma_de_pago_seleccion.SucxClie_id = SucxClie_id
                    Forma_de_pago_seleccion.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Error!, No puede registrar la venta, la caja actual esta siendo utilizada por el usuario: " + US_administrador.apellidoynombre, "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class