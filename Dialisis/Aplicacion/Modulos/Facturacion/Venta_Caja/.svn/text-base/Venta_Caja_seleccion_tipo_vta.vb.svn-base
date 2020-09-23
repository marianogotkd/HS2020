Public Class Venta_Caja_seleccion_tipo_vta
    Dim DAventa As New Datos.Venta
    Dim DAsucursal As New Datos.Sucursal
    Dim Venta_Caja_ds As New Venta_Caja_ds

    Private Sub Venta_Caja_seleccion_tipo_vta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        'veo que sucursal esta cargada, eso depende del usuario logueado
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_usuario As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)
        If ds_usuario.Tables(0).Rows.Count <> 0 Then
            Dim sucursal_id As Integer = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
            'aqui llamo a la rutina q me trae las configuraciones de la sucursal, o sea si tiene habilitado mayorista y minorista
            Dim ds_sucursal As DataSet = DAsucursal.Sucursal_consultar_configuracion(sucursal_id)
            If ds_sucursal.Tables(0).Rows(0).Item("sucursal_config_minorista") = "si" Then
                'agrego al ds.table.. el row de minorista
                Dim row As DataRow = Venta_Caja_ds.Tables("Tipo_vta").NewRow()
                row("Descripcion") = "Minorista"
                row("id") = "1"
                Venta_Caja_ds.Tables("Tipo_vta").Rows.Add(row)
            End If
            If ds_sucursal.Tables(0).Rows(0).Item("sucursal_config_mayorista") = "si" Then
                'agrego al ds.table.. el row de mayorista
                Dim row As DataRow = Venta_Caja_ds.Tables("Tipo_vta").NewRow()
                row("Descripcion") = "Mayorista"
                row("id") = "2"
                Venta_Caja_ds.Tables("Tipo_vta").Rows.Add(row)
            End If
            ComboBox1.DataSource = Venta_Caja_ds.Tables("Tipo_vta")
            ComboBox1.DisplayMember = "Descripcion"
            ComboBox1.ValueMember = "id"
        End If
        ComboBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Venta_Caja_gestion.Show()
        Venta_Caja_gestion.tipo_vta = ComboBox1.Text
        Me.Close()
    End Sub
End Class