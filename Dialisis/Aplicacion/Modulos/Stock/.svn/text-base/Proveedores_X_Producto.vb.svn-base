Imports System.IO
Imports System.Data.OleDb
Public Class Proveedores_X_Producto
    Dim DAproducto As New Datos.Producto
    Dim ds_proveedor As DataSet
    Dim DAproveedores As New Datos.Proveedor
    Dim DAcategoria As New Datos.Categoria
    Dim DAmarca As New Datos.Marca
    Dim DAlista As New Datos.Lista
    Dim ds_categoria As DataSet = DAcategoria.Categoria_obtener
    Dim ds_prodcod As DataSet = DAproducto.Codinterno_obtener
    Dim ds_rubro As DataSet
    Dim ds_subrubro As DataSet
    Public prod_id As Integer
    Public ds_producto_edicion As New Producto_ds
    Public Sub Cargarcombo_proveedor()
        ds_proveedor = DAproveedores.Proveedor_obtener
        'Cargar Proveedor
        cb_proveedores.DataSource = ds_proveedor.Tables(0)
        cb_proveedores.DisplayMember = "Prov_nombre"
        cb_proveedores.ValueMember = "Prov_id"
        'selecciono el proveedor Defecto.
        cb_proveedores.SelectedValue = "21"
    End Sub

    Private Sub Bo_agregarprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_agregarprod.Click
        'validacion 
        Dim valido As String = "si"
        If cb_proveedores.Items.Count = 0 Then
            MessageBox.Show("Error, seleccione un proveedor", "Sistema de Gestión.")
            ERROR_tx_proveedor.Visible = True
            valido = "no"
        End If

        'valido que no este agregado ya en la grilla de asignados

        Dim i As Integer = 0
        While i < DG_Prov_Prod.Rows.Count
            If DG_Prov_Prod.Rows(i).Cells("Prov_idColumn").Value = cb_proveedores.SelectedValue Then
                MessageBox.Show("Error, ya esta asignado el proveedor.", "Sistema de Gestión")
                valido = "no"
                i = DG_Prov_Prod.Rows.Count
            End If
            i = i + 1
        End While

        If valido = "si" Then
            Dim ProductoRow As DataRow = ds_producto_edicion.Tables("ProveedorProducto_aux").NewRow()
            ProductoRow("Prov_id") = cb_proveedores.SelectedValue
            ProductoRow("Prov_nombre") = cb_proveedores.Text
            ProductoRow("Prod_id") = prod_id
            ProductoRow("Prod_descripcion") = ""
            ProductoRow("Prov_Prod_Com_fecha") = DT_fecha_compra.Value
            'Dim precio_compra As Decimal = 0
            'If tx_preciocompra.Text <> "" Then
            '    precio_compra = CDec(tx_preciocompra.Text)
            'Else
            '    precio_compra = CDec(0)
            'End If
            'ProductoRow("Prov_Prod_Com_precio") = precio_compra
            ds_producto_edicion.Tables("ProveedorProducto_aux").Rows.Add(ProductoRow)
            DG_Prov_Prod.DataSource = ds_producto_edicion.Tables("ProveedorProducto_aux")

            'aqui tengo q igualar los ds antes..
            'Producto_alta_New.DataGridView_Prod_Prov.DataSource = Producto_ds.Tables("ProveedorProducto")

            'Bo_guardar.Enabled = True
            'limpiar_proveedor_producto()
        End If
    End Sub

    
    Private Sub Proveedores_X_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargarcombo_proveedor()
        DG_Prov_Prod.DataSource = ds_producto_edicion.Tables("ProveedorProducto_aux")
        Dim aaaa = 1


    End Sub

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        If DG_Prov_Prod.Rows.Count <> 0 Then
            Producto_alta_New.ds_producto_recuperado.Tables("ProveedorProducto").Clear()
            Producto_alta_New.ds_producto_recuperado.Tables("ProveedorProducto").Merge(ds_producto_edicion.Tables("ProveedorProducto_aux"))
            Dim contador As Integer = ds_producto_edicion.Tables("ProveedorProducto_aux").Rows.Count
            Producto_alta_New.DataGridView_Prod_Prov.DataSource = Producto_alta_New.ds_producto_recuperado.Tables("ProveedorProducto")
            If DG_Prov_Prod.RowCount <> 0 Then
                Producto_alta_New.Bo_guardar.Enabled = True
            End If
            ds_producto_edicion.Tables("ProveedorProducto_aux").Rows.Clear()
            Close()
        Else
            MessageBox.Show("Error, debe asignar al menos un proveedor.", "Sistema de Gestión.")
        End If

        

    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        If Producto_alta_New.form_procedencia = "alta" Then
            Producto_alta_New.DataGridView_Prod_Prov.DataSource = Nothing
            DG_Prov_Prod.DataSource = Nothing
        End If
        Close()


    End Sub

    

    Private Sub DG_Prov_Prod_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Prov_Prod.DoubleClick
        cb_proveedores.SelectedValue = DG_Prov_Prod.CurrentRow.Cells("Prov_idColumn").Value
        DT_fecha_compra.Value = DG_Prov_Prod.CurrentRow.Cells("ProvProdComfechaColumn").Value
    End Sub

    Private Sub Bo_nuevoprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_nuevoprov.Click
        Proveedor_alta.form_inicio = "proveedores_x_producto"
        Proveedor_alta.Show()
    End Sub
End Class