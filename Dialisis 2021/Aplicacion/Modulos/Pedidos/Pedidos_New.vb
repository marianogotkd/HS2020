Public Class Pedidos_New

    Dim DAproveedores As New Datos.Proveedor
    Dim DAPedidos As New Datos.Pedidos
    Dim ds_Prove As DataSet
    Dim ds_proveedor As DataSet = DAproveedores.Proveedor_obtener

    Private Sub Pedidos_New_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Combo_Prove.DataSource = ds_proveedor.Tables(0)
        Combo_Prove.DisplayMember = "Prov_nombre"
        Combo_Prove.ValueMember = "Prov_id"

        Generar_cod_interno()
        ProveedorProducto_obtener()
    End Sub
    Public Sub ProveedorProducto_obtener()

        If ds_proveedor.Tables(0).Rows.Count > 0 Then
            ds_Prove = DAPedidos.Pedidos_Obtener_Prod_Prove(ds_proveedor.Tables(0).Rows(Combo_Prove.SelectedIndex).Item("Prov_id").ToString)
        End If
    End Sub

    Public Sub Generar_cod_interno()
        'obtenemos 1 dataset con 1 table MIXTA...los de prod y combo..
        Dim ds_generar As DataSet = DAPedidos.Pedidos_validar
        If ds_generar.Tables(0).Rows.Count <> 0 Then
            tx_codigo.Text = ds_generar.Tables(0).Rows(ds_generar.Tables(0).Rows.Count - 1).Item(0) + 1
        Else
            tx_codigo.Text = "1"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Pedido_Productos.Label_fecha.Text = DateTimePicker1.Text
        Pedido_Productos.Label_Pedido.Text = tx_codigo.Text
        Pedido_Productos.Label_prov.Text = Combo_Prove.Text
        Pedido_Productos.Prove_ID = Combo_Prove.SelectedValue
        Pedido_Productos.form_procedencia = "Pedidos_new"
        Me.Close()
        Pedido_Productos.Show()

        Pedido_Productos.DataGridView1.Focus()

        Pedido_Productos.DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True

    End Sub
End Class