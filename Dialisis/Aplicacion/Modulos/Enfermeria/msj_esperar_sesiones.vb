Public Class msj_esperar_sesiones

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub msj_esperar_sesiones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Public fecha As Date
    Public procedencia As String
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label2.Text = ProgressBar1.Value & (" %")
        If ProgressBar1.Value = 70 Then
            If procedencia = "sesion_pacientes" Then
                Sesion_pacientes.recuperar_pacientes_fecha_del_dia(fecha)
                Me.Close()
            End If
            If procedencia = "GM_Consultar_Stock_load" Then
                GM_Consultar_Stock.LOAD_CARGA()
                Me.Close()
            End If
            If procedencia = "Busqueda_Productos_load" Then
                Busqueda_Productos.LOAD_CARGA()
                Me.Close()
            End If
            
            If procedencia = "Gestion_Mercaderia_Alta_btn_guardad_click" Then
                Gestion_Mercaderia_Alta.GUARDAR_CLICK()
                Me.Close()
            End If
            If procedencia = "Gestion_Mercaderia_GUARDAR" Then
                Gestion_Mercaderia.GUARDAR_CLICK()
                Me.Close()
            End If

            If procedencia = "GM_Baja_Producto_load" Then
                GM_Baja_Producto.LOAD_CARGA()
                Me.Close()
            End If
            If procedencia = "Cliente_modificar_load" Then
                Cliente_modificar.LOAD_CARGA()
                Me.Close()
            End If
            If procedencia = "Cliente_alta_new_load" Then
                Cliente_alta_New.LOAD_CARGA()
                Me.Close()
            End If
            If procedencia = "Cliente_Alta_btn_acepta_click" Then
                Cliente_alta_New.ACEPTAR()
                Me.Close()
            End If

        End If
        If ProgressBar1.Value = 80 Then
            If procedencia = "Producto_modificar_load" Then
                Producto_modificar.LOAD_CARGA()
                'Me.Close()
            End If
        End If

    End Sub
End Class