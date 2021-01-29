'Imports System.IO
'Imports System.Data.OleDb
'Public Class Producto_Reporte_Global
'    Dim evento_load_completo As String = "no"
'    Public paso = 0
'    Dim DAsucursal As New Datos.Sucursal
'    Dim ds_PROD As DataSet
'    Dim DAVentas As New Datos.Venta
'    Private Sub Producto_Reporte_Global_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        paso = 0
'        'Clipboard.SetDataObject(Me.PictureBox1.Image)

'        Tx_Buscqueda.Focus()

'        Sucursales_Obtener()
'        Cargar_grilla()

'        evento_load_completo = "si"

'    End Sub

'    Private Sub Sucursales_Obtener()
'        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
'        'Cargar Provincias en ComboBox_prov
'        cb_origen.DataSource = ds.Tables(0)
'        cb_origen.DisplayMember = "sucursal_nombre"
'        cb_origen.ValueMember = "sucursal_id"
'        paso = 1
'    End Sub

'    Public Sub Cargar_grilla()
'        If paso = 1 Then
'            ds_PROD = DAVentas.Producto_x_Sucursal_obtener_todo_GLOBAL(cb_origen.SelectedValue)
'            If ds_PROD.Tables(0).Rows.Count <> 0 Then
'                Producto_ds.Tables("ProdxSuc_GLOBAL").Rows.Clear()
'                Producto_ds.Tables("ProdxSuc_GLOBAL").Merge(ds_PROD.Tables(0))
'            Else
'                Producto_ds.Tables("ProdxSuc_GLOBAL").Rows.Clear()
'            End If
'            formato_grilla()
'        End If
'    End Sub

'    Private Sub formato_grilla()
'        Dim style As New DataGridViewCellStyle
'        style.Font = New Font(DG_Producto.Font, FontStyle.Bold)
'        Dim i = 0
'        While i < DG_Producto.RowCount
'            If DG_Producto.Rows(i).Cells("ProdxSuc_stock").Value <= DG_Producto.Rows(i).Cells("ProdxSuc_ptorepo").Value Then
'                DG_Producto.Rows(i).Cells("ProdxSuc_stock").Style.ForeColor = Color.Red
'                DG_Producto.Rows(i).Cells("ProdxSuc_ptorepo").Style.ForeColor = Color.Red
'                DG_Producto.Rows(i).DefaultCellStyle = style
'            End If
'            i = i + 1
'        End While
'    End Sub
'End Class