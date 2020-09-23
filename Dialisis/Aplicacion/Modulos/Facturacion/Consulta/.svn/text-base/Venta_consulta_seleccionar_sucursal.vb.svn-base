Public Class Venta_consulta_seleccionar_sucursal
    Dim DAventa As New Datos.Venta
    Dim DAsucursal As New Datos.Sucursal
    Public Procedencia As String


    Private Sub Venta_consulta_seleccionar_sucursal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim usuario_id As String
        usuario_id = Inicio.USU_id  'obtengo del formulario inicio el id del usuario logueado
        Dim ds_empresa As DataSet = DAventa.Obtener_usuario_y_sucursal(usuario_id)

        If ds_empresa.Tables(1).Rows.Count <> 0 Then 'la tabla 1 trae la empresa con el inner join de la sucursal
            Dim empresa_id As Integer = 0
            empresa_id = CInt(ds_empresa.Tables(1).Rows(0).Item("empresa_id"))
            'ahora llamo a la rutina q recupere todas las sucursales de dicha empresa
            Dim ds_sucursales As DataSet = DAsucursal.Sucursal_obtener_todas(empresa_id)
            Dim contador As Integer = ds_sucursales.Tables(0).Rows.Count
            'ahora cargo todas las sucursales en el combobox sucursales
            ComboBox_sucursales.DataSource = ds_sucursales.Tables(0)
            ComboBox_sucursales.DisplayMember = "sucursal_nombre"
            ComboBox_sucursales.ValueMember = "sucursal_id"
        End If

    End Sub

    Private Sub Button_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_siguiente.Click
        If Procedencia = "Venta_consulta_sucursal" Then
            'enviar id de sucursal al siguiente modulo para recuperar las ventas
            'ComboBox_sucursales.SelectedValue 
            Venta_consulta_sucursal.sucursal_id = ComboBox_sucursales.SelectedValue
            Venta_consulta_sucursal.sucursal_nombre = ComboBox_sucursales.Text
            Me.Close()
            Venta_consulta_sucursal.Show()
        End If
        If Procedencia = "Caja_consulta" Then
            Caja_consulta.sucursal_id = ComboBox_sucursales.SelectedValue
            Caja_consulta.sucursal_nombre = ComboBox_sucursales.Text
            Me.Close()
            Caja_consulta.Show()
        End If

    End Sub
End Class