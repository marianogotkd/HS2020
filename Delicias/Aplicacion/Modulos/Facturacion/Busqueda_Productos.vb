Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices
Public Module TextBoxExtensions

    Private Const ECM_FIRST As UInteger = &H1500
    Private Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1

    <DllImport("user32.dll", EntryPoint:="SendMessageW")>
    Private Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As IntPtr
    End Function

    <Extension()>
    Public Sub SetWaterMark(ByVal tb As TextBox, ByVal watermark As String)
        SendMessageW(tb.Handle, EM_SETCUEBANNER, 0, watermark)
    End Sub

End Module

Public Class Busqueda_Productos

    Dim DAlista As New Datos.Lista
    Dim DAVentas As New Datos.Venta
    Dim DAGestion_Mercaderia As New Datos.Gestion_Mercaderia
    Dim DApedidos As New Datos.Pedidos
    Dim DAmarca As New Datos.Marca
    Dim ds_PROD As DataSet
    Dim rb_no_combo As String = "no"
    Dim rb_si_combo As String = "no"
    Public form_procedencia As String = ""
    Public sucursal_id As Integer = 0
    Public sucursal_nombre As String
    Dim DAcategoria As New Datos.Categoria
    Dim ds_categoria As DataSet = DAcategoria.Categoria_obtener
    Dim cat1_id As Integer = 0
    Dim cat2_id As Integer = 0
    Dim ds_rubro As DataSet
    Dim ds_subrubro As DataSet
    Dim evento_load_completo As String = "no"

    Public Class WatermarkTextBox
        Inherits TextBox

        Private NotInheritable Class NativeMethods
            Private Sub New()
            End Sub

            Private Const ECM_FIRST As UInteger = &H1500
            Friend Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1

            <DllImport("user32.dll", EntryPoint:="SendMessageW")>
            Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As IntPtr
            End Function
        End Class

        Private _watermark As String
        Public Property Watermark() As String
            Get
                Return _watermark
            End Get
            Set(ByVal value As String)
                _watermark = value
                UpdateWatermark()
            End Set
        End Property

        Private Sub UpdateWatermark()
            If IsHandleCreated AndAlso _watermark IsNot Nothing Then
                NativeMethods.SendMessageW(Handle, NativeMethods.EM_SETCUEBANNER, CType(1, IntPtr), _watermark)
            End If
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            UpdateWatermark()
        End Sub

    End Class






    Private Sub cargar_combos_categoria()
        ds_categoria = DAcategoria.Categoria_obtener
        If ds_categoria.Tables(0).Rows.Count <> 0 Then
            'Carga la categoria
            cb_categoria.DataSource = ds_categoria.Tables(0)
            cb_categoria.DisplayMember = "cat1_nom"
            cb_categoria.ValueMember = "cat_id"
            cat1_id = cb_categoria.SelectedValue
            categoriarubro_obtener()
            rubrosubrubro_obtener()
            'Cargarcombo_marca()


        End If
    End Sub

    Public Sub Cargarcombo_marca()
        'Cargar la Marca
        Dim ds_marca As DataSet = DAmarca.Marca_obtener
        cb_marca.DataSource = ds_marca.Tables(0)
        cb_marca.DisplayMember = "Marca_nom"
        cb_marca.ValueMember = "Marca_id"
        cb_marca.SelectedValue = ds_marca.Tables(0).Rows(0).Item("Marca_id")
    End Sub


    Public Sub categoriarubro_obtener()
        If cat1_id <> 0 Then
            cat1_id = cb_categoria.SelectedValue 'se vuelve a seleccionar el actual
            ds_rubro = DAcategoria.Categoriarubro_obtener(cat1_id)
            If ds_rubro.Tables(0).Rows.Count <> 0 Then
                cb_rubro.DataSource = ds_rubro.Tables(0)
                cb_rubro.DisplayMember = "cat2_nom"
                cb_rubro.ValueMember = "cat2_id"
                cat2_id = cb_rubro.SelectedValue
                'check_rubro.Enabled = True
            Else
                cb_rubro.DataSource = Nothing
                cat2_id = 0 'asigno recurso vacio
                check_rubro.Checked = False
                check_rubro.Enabled = False
            End If
        End If
    End Sub
    Public Sub rubrosubrubro_obtener()
        If cat2_id <> 0 Then
            Dim cat2_id As Integer = cb_rubro.SelectedValue 'se vuelve a seleccionar el actual
            ds_subrubro = DAcategoria.rubrosubrubro_obtener(cat2_id)
            If ds_subrubro.Tables(0).Rows.Count <> 0 Then
                cb_subrubro.DataSource = ds_subrubro.Tables(0)
                cb_subrubro.DisplayMember = "cat3_nom"
                cb_subrubro.ValueMember = "cat3_id"
                'check_subrubro.Enabled = True
            Else
                cb_subrubro.DataSource = Nothing
                check_subrubro.Checked = False
                check_subrubro.Enabled = False
            End If
        Else
            cb_subrubro.DataSource = Nothing
            check_subrubro.Checked = False
            check_subrubro.Enabled = False

        End If
    End Sub
    Public Sub Obtener_Productos_Combos()
        'esta rutina la uso para traer todos los producos...solo la usi en el caso de que en el form: VENTA_CAHA_GESTION...se seleccione
        'configurar lista = NO
        Select Case form_procedencia
            Case "Venta_Caja_gestion" 'LISTO, ANDA CON LOS COMBOS PARA FILTRAR
                If Venta_Caja_gestion.RB_Si.Checked = False Then
                    ds_PROD = DAVentas.Venta_obtenerProducto_Combos(Inicio.USU_id)
                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With ds_PROD.Tables(2).Rows
                        If .Count > 0 Then
                            rb_no_combo = "si"
                            ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                            'DataGridView1.DataSource = ds_PROD.Tables(1) choco: 13-11-2018 la uso antes de los filtros x marca, categorias
                            'DataGridView2.DataSource = ds_PROD.Tables(3)
                            'Call Formato_combos()
                            'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                            ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                            'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_cant.Text = "1"
                            'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                        Else
                            'DataGridView1.Enabled = False
                            If ds_PROD.Tables(1).Rows.Count <> 0 Then
                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                                Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                                'DataGridView1.DataSource = ds_PROD.Tables(1) choco: 13-11-2018 la uso antes de los filtros x marca, categorias
                            Else
                                DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                Else
                    If Venta_Caja_gestion.RB_No.Checked = False Then
                        ds_PROD = DAVentas.Venta_obtenerProducto_listaregular(Venta_Caja_gestion.CB_lista.SelectedValue)

                        'junto los prod y los combos..para mostrarlos en el mismo grid
                        With ds_PROD.Tables(1).Rows
                            If .Count > 0 Then
                                rb_si_combo = "si"
                                ds_PROD.Tables(0).Merge(ds_PROD.Tables(1))
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                                'Call Formato_combos()
                                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_cant.Text = "1"
                                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                            Else

                                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                                    DataGridView1.DataSource = ds_PROD.Tables(0)
                                Else
                                    DataGridView1.Enabled = False
                                    DataGridView1.DataSource = Nothing
                                End If

                                'IM_ERROR.Visible = True
                                'LB_ERROR.Visible = True
                            End If
                        End With
                    End If
                End If
            Case "Mesas_gestion"

                If Mesas_gestion.RB_Si.Checked = False Then


                    ds_PROD = DAVentas.Venta_obtenerProducto_Combos(Inicio.USU_id)

                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With ds_PROD.Tables(2).Rows
                        If .Count > 0 Then
                            rb_no_combo = "si"
                            ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                            DataGridView1.DataSource = ds_PROD.Tables(1)
                            'DataGridView2.DataSource = ds_PROD.Tables(3)

                            'Call Formato_combos()
                            'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                            ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                            'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_cant.Text = "1"
                            'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                        Else
                            'DataGridView1.Enabled = False

                            If ds_PROD.Tables(1).Rows.Count <> 0 Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                Else
                    If Mesas_gestion.RB_No.Checked = False Then
                        ds_PROD = DAVentas.Venta_obtenerProducto_listaregular(Mesas_gestion.CB_lista.SelectedValue)

                        'junto los prod y los combos..para mostrarlos en el mismo grid
                        With ds_PROD.Tables(1).Rows
                            If .Count > 0 Then
                                rb_si_combo = "si"
                                ds_PROD.Tables(0).Merge(ds_PROD.Tables(1))
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                                'Call Formato_combos()
                                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_cant.Text = "1"
                                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                            Else

                                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                                    DataGridView1.DataSource = ds_PROD.Tables(0)
                                Else
                                    DataGridView1.Enabled = False
                                    DataGridView1.DataSource = Nothing
                                End If

                                'IM_ERROR.Visible = True
                                'LB_ERROR.Visible = True
                            End If
                        End With
                    End If
                End If

            Case "Pedido_Productos" 'listo, funciona con combos para filtrar, marca, cat, rubro y subrubro
                DataGridView1.Columns("ProdstockDataGridViewTextBoxColumn").Visible = False 'oculto la columna de stock para no confundir, ya que estra me trae el stock en 0

                ds_PROD = DApedidos.Productos_x_Proveedor_Obtener(Pedido_Productos.Prove_ID) 'choco: 11-12-2018 agregado cbarra
                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                    Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                    Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(0))
                    'DataGridView1.DataSource = ds_PROD.Tables(0)
                Else
                    DataGridView1.DataSource = Nothing
                End If

            Case "Mesa_cargar"
                If Mesa_cargar.RB_Si = False Then
                    ds_PROD = DAVentas.Venta_obtenerProducto_Combos(Inicio.USU_id)
                    'junto los prod y los combos..para mostrarlos en el mismo grid
                    With ds_PROD.Tables(2).Rows
                        If .Count > 0 Then
                            rb_no_combo = "si"
                            ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                            DataGridView1.DataSource = ds_PROD.Tables(1)
                            'DataGridView2.DataSource = ds_PROD.Tables(3)

                            'Call Formato_combos()
                            'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                            ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                            'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                            'TX_LISTA_PROD_cant.Text = "1"
                            'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                        Else
                            'DataGridView1.Enabled = False
                            If ds_PROD.Tables(1).Rows.Count <> 0 Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = Nothing
                            End If

                            'IM_ERROR.Visible = True
                            'LB_ERROR.Visible = True
                        End If
                    End With
                Else
                    If Mesa_cargar.RB_No = False Then
                        ds_PROD = DAVentas.Venta_obtenerProducto_listaregular(Mesa_cargar.CB_lista)

                        'junto los prod y los combos..para mostrarlos en el mismo grid
                        With ds_PROD.Tables(1).Rows
                            If .Count > 0 Then
                                rb_si_combo = "si"
                                ds_PROD.Tables(0).Merge(ds_PROD.Tables(1))
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                                'Call Formato_combos()
                                'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                                ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                                'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                                'TX_LISTA_PROD_cant.Text = "1"
                                'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                            Else

                                If ds_PROD.Tables(0).Rows.Count <> 0 Then
                                    DataGridView1.DataSource = ds_PROD.Tables(0)
                                Else
                                    DataGridView1.Enabled = False
                                    DataGridView1.DataSource = Nothing
                                End If
                                'IM_ERROR.Visible = True
                                'LB_ERROR.Visible = True
                            End If
                        End With
                    End If
                End If
            Case "GM_Carga_Producto"
                DataGridView1.Columns("ProdstockDataGridViewTextBoxColumn").Visible = False 'oculto la columna de stock para no confundir, ya que estra me trae el stock en 0
                'DataGridView1.Columns("prod_precio_vta_May").Visible = False 'oculto tambien la columna de precio mayorista
                ds_PROD = DAGestion_Mercaderia.Movimiento_Mercaderia_obtenerProducto_Combos()
                With ds_PROD.Tables(2).Rows
                    If .Count > 0 Then
                        rb_no_combo = "si"
                        ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                        Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))

                    Else
                        If ds_PROD.Tables(1).Rows.Count <> 0 Then
                            'DataGridView1.DataSource = ds_PROD.Tables(1)
                            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                        Else
                            DataGridView1.DataSource = Nothing
                        End If
                    End If
                End With
            Case "Gestion_Mercaderia"
                'aqui solamente muestro los productos en stock en una determinada sucursal, para ello necesito el id de sucursal.
                Me.Text = "Stock en Sucursal: " + sucursal_nombre
                BO_agregar.Visible = False
                ds_PROD = DAVentas.Venta_obtenerProducto_Combos_sucursal(sucursal_id)
                'junto los prod y los combos..para mostrarlos en el mismo grid
                With ds_PROD.Tables(2).Rows
                    If .Count > 0 Then
                        rb_no_combo = "si"
                        ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                        Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                        'DataGridView2.DataSource = ds_PROD.Tables(3)
                        'Call Formato_combos()
                        'aqui como se selecciona automaticamente el primero, q pase los datos a los box de la derecha
                        ' Label_codinterno.Text = DG_Producto.CurrentRow.Cells(1).Value
                        'Label_preciolista.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                        'TX_LISTA_PROD_precio.Text = DG_Producto.CurrentRow.Cells(4).Value ' lo paso a decima para obtener el formato 00,00
                        'TX_LISTA_PROD_cant.Text = "1"
                        'Label_preciototal.Text = DG_Producto.CurrentRow.Cells(4).Value
                    Else
                        'DataGridView1.Enabled = False
                        If ds_PROD.Tables(1).Rows.Count <> 0 Then
                            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                        Else
                            DataGridView1.DataSource = Nothing
                        End If

                        'IM_ERROR.Visible = True
                        'LB_ERROR.Visible = True
                    End If
                End With

            Case "Servicio_nuevo"
                DataGridView1.Columns("ProdstockDataGridViewTextBoxColumn").Visible = False 'oculto la columna de stock para no confundir, ya que estra me trae el stock en 0
                ds_PROD = DAGestion_Mercaderia.Movimiento_Mercaderia_obtenerProducto_Combos()
                With ds_PROD.Tables(2).Rows
                    If .Count > 0 Then
                        rb_no_combo = "si"
                        ds_PROD.Tables(1).Merge(ds_PROD.Tables(2))
                        'DataGridView1.DataSource = ds_PROD.Tables(1)
                        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                        Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                    Else
                        If ds_PROD.Tables(1).Rows.Count <> 0 Then
                            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
                            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_PROD.Tables(1))
                        Else
                            DataGridView1.DataSource = Nothing
                        End If
                    End If
                End With
        End Select



    End Sub


    Private Sub Busqueda_Productos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub Busqueda_Productos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_Productos_Combos()
        Cargarcombo_marca()
        cargar_combos_categoria()
        evento_load_completo = "si"
        'TextBox111.SetWaterMark("Descripcion o Codigo")
    End Sub

    Private Sub BO_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_salir.Click
        Me.Close()
    End Sub

    Private Sub Buscar_y_cargar_en_grilla(ByVal cod_ingresado As Integer)
        Dim existe_en_grilla As String = "no"
        Dim Encontrado = "no" 'siempre por defecto, "IMPÒRTANTISIMO"
        Dim i As Integer = 0

        Select Case Venta_Caja_gestion.tipo_vta
            Case "Minorista"
                'AQUI SOLO BUSCO EN TABLA PRODUCTOS, NO EN PROMOCIONES
                While i < Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count 'la tabla 1 es para los prod comunes, no para los de la lista regular
                    Dim cod_interno As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    Dim cod_barra As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                    If cod_ingresado = cod_interno Or CStr(cod_ingresado) = cod_barra Then
                        Venta_Caja_gestion.buscar_en_grilla_y_sumar_mas_uno(cod_interno, existe_en_grilla)
                        If existe_en_grilla = "no" Then
                            Dim index As Integer = Venta_Caja_gestion.DataGridView1.Rows.Count - 1
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_item").Value = CInt(Venta_Caja_gestion.DataGridView1.Rows.Count)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_prod_id").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codinterno").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_descripcion").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_detalle").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_cantidad").Value = CInt(1)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_unitario").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta")
                            Dim total As Decimal = 0
                            total = CDec(Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta"))
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_subtotal").Value = CDec(total)   'CDec(Math.Round(total, 2)).ToString("N2")
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codbarra").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("descuento").Value = CInt(0)
                            Venta_Caja_gestion.DataGridView1.Rows.Add() 'AGREGO UNO EXTRA PARA EL PROXIMO ITEM
                        End If
                        Encontrado = "si"
                        i = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count
                    End If
                    i = i + 1
                End While
            Case "Mayorista"
                'AQUI SOLO BUSCO EN TABLA PRODUCTOS, NO EN PROMOCIONES
                While i < Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count 'la tabla 1 es para los prod comunes, no para los de la lista regular
                    Dim cod_interno As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    Dim cod_barra As String = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                    If cod_ingresado = cod_interno Or CStr(cod_ingresado) = cod_barra Then
                        Venta_Caja_gestion.buscar_en_grilla_y_sumar_mas_uno(cod_interno, existe_en_grilla) 'aqui lo busco en gridview1 y sumo + 1 si ya existe en la grilla
                        If existe_en_grilla = "no" Then
                            Dim index As Integer = Venta_Caja_gestion.DataGridView1.Rows.Count - 1
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_item").Value = CInt(Venta_Caja_gestion.DataGridView1.Rows.Count)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_prod_id").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codinterno").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_descripcion").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_detalle").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_cantidad").Value = CInt(1)
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_unitario").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta_May")
                            Dim total As Decimal = 0
                            total = CDec(Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_precio_vta_May"))
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_precio_subtotal").Value = CDec(total)   'CDec(Math.Round(total, 2)).ToString("N2")
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("columna_codbarra").Value = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows(i).Item("prod_codbarra").ToString
                            Venta_Caja_gestion.DataGridView1.Rows(index).Cells("descuento").Value = CInt(0)
                            Venta_Caja_gestion.DataGridView1.Rows.Add() 'AGREGO UNO EXTRA PARA EL PROXIMO ITEM
                        End If
                        Encontrado = "si"
                        i = Venta_Caja_gestion.VentaGestion_DS_PROD.Tables(1).Rows.Count
                    End If
                    i = i + 1
                End While
        End Select
        'If Encontrado = "no" Then
        '    i = 0
        '    'Lo busco como promocion
        '    While i < VentaGestion_ds_PROMO.Tables(0).Rows.Count
        '        Dim cod_interno As String = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '        If cod_ingresado.ToString.ToUpper = cod_interno Then
        '            DataGridView1.CurrentRow.Cells("columna_item").Value = CInt(DataGridView1.CurrentRow.Index + 1)
        '            DataGridView1.CurrentRow.Cells("columna_prod_id").Value = " "
        '            DataGridView1.CurrentRow.Cells("columna_codinterno").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_codinterno").ToString
        '            DataGridView1.CurrentRow.Cells("columna_descripcion").Value = VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_nom").ToString
        '            DataGridView1.CurrentRow.Cells("columna_detalle").Value = " "
        '            DataGridView1.CurrentRow.Cells("columna_cantidad").Value = CInt(1)
        '            DataGridView1.CurrentRow.Cells("columna_precio_unitario").Value = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
        '            Dim total As Decimal = 0
        '            total = CDec(VentaGestion_ds_PROMO.Tables(0).Rows(i).Item("LISTA_total"))
        '            DataGridView1.CurrentRow.Cells("columna_precio_subtotal").Value = CDec(total) 'CDec(Math.Round(total, 2)).ToString("N2")
        '            DataGridView1.CurrentRow.Cells("columna_codbarra").Value = " "

        '            Encontrado = "si"
        '            i = VentaGestion_ds_PROMO.Tables(0).Rows.Count
        '        End If
        '        i = i + 1
        '    End While
        'End If
        'If Encontrado = "no" Then
        '    'buscar por codigo de barras
        '    MsgBox("No Existe el Producto")
        'Else
        '    calcular_totales()
        'End If
        Venta_Caja_gestion.calcular_totales()
        Venta_Caja_gestion.aplicar_iva()
    End Sub

    Public Sub Pedido_Buscar_y_cargar_en_grilla(ByVal cod_ingresado As Integer)
        Dim Encontrado As String = "no"
        Dim i As Integer = 0
        While i < ds_PROD.Tables(0).Rows.Count
            Dim cod_interno As String = ds_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
            If cod_ingresado = cod_interno Then
                Dim index As Integer = Pedido_Productos.DataGridView1.CurrentRow.Index
                Pedido_Productos.DataGridView1.CurrentRow.Cells("item_num").Value = CInt(Pedido_Productos.DataGridView1.CurrentRow.Index + 1)
                Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_id").Value = ds_PROD.Tables(0).Rows(i).Item("prod_id").ToString
                Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_codinterno").Value = ds_PROD.Tables(0).Rows(i).Item("prod_codinterno").ToString
                Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_descripcion").Value = ds_PROD.Tables(0).Rows(i).Item("prod_descripcion").ToString
                Pedido_Productos.DataGridView1.CurrentRow.Cells("Cantidad").Value = CInt(1)
                Encontrado = "si"
            End If
            i = i + 1
        End While
        If Encontrado = "no" Then
            'buscar por codigo de barras
            Pedido_Productos.DataGridView1.CurrentRow.Cells("item_num").Value = ""
            Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_id").Value = ""
            Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_codinterno").Value = ""
            Pedido_Productos.DataGridView1.CurrentRow.Cells("prod_descripcion").Value = ""
            Pedido_Productos.DataGridView1.CurrentRow.Cells("Cantidad").Value = ""
            MsgBox("No Existe el Producto")
        End If
        'If Pedido_Productos.DataGridView1.Rows(Pedido_Productos.DataGridView1.Rows.Count - 1).Cells(2).Value <> "" Then
        '    Pedido_Productos.DataGridView1.Rows.Add()
        'End If


    End Sub





    Private Sub BO_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_agregar.Click
        Select Case form_procedencia
            Case "Venta_Caja_gestion"
                Buscar_y_cargar_en_grilla(DataGridView1.CurrentRow.Cells(1).Value)

                'If DataGridView1.CurrentRow IsNot Nothing Then
                '    'recorro el gridview, veo cual es el ultimo item agregado y pongo el current id
                '    Dim i As Integer = 0
                '    Dim indice_row As Integer = 0
                '    Dim cant_rows_grid As Integer = Venta_Caja_gestion.DataGridView1.Rows.Count
                '    Dim agregado As String = "no"
                '    While i < Venta_Caja_gestion.DataGridView1.Rows.Count
                '        If Venta_Caja_gestion.DataGridView1.Rows(i).Cells(2).Value = "" Then
                '            Buscar_y_cargar_en_grilla(DataGridView1.CurrentRow.Cells(1).Value)
                '            i = Venta_Caja_gestion.DataGridView1.Rows.Count
                '            agregado = "si"
                '        Else
                '            i = i + 1
                '        End If
                '    End While
                '    If agregado = "no" Then
                '        Venta_Caja_gestion.DataGridView1.Rows.Add()
                '        Buscar_y_cargar_en_grilla(DataGridView1.CurrentRow.Cells(1).Value)
                '    End If
                '    'Venta_Caja_gestion.DataGridView1.Rows.Add() 'AGREGO UNO EXTRA PARA EL PROXIMO ITEM

                'End If
            Case "Mesas_gestion"
                'cuando presiono enter busco el prod o combo en el dataset...DS_PROD
                If DataGridView1.CurrentRow IsNot Nothing Then
                    Mesas_gestion.TX_busc_codinterno.Text = DataGridView1.CurrentRow.Cells(1).Value
                    Mesas_gestion.TX_busc_codinterno.Focus()
                    Mesas_gestion.TX_busc_codinterno.SelectAll()
                    Mesas_gestion.RB_CodInterno.Checked = True

                    '    Dim i As Integer = 0
                    '    Dim encontrado As String = "No"
                    '    While i < ds_PROD.Tables(1).Rows.Count
                    '        Dim cod_interno As String = ds_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    '        If Venta_Caja_gestion.TX_busc_codinterno.Text = cod_interno Then
                    '            'primero verifico que el producto q ingreso no este ya en la grilla
                    '            Dim item = 0
                    '            Dim presente = "no"
                    '            Dim fila_editar = 0
                    '            While item < Venta_Caja_gestion.DataG_lista.Rows.Count
                    '                If Venta_Caja_gestion.DataG_lista.Rows(item).Cells(2).Value = Venta_Caja_gestion.TX_busc_codinterno.Text Then
                    '                    presente = "si"
                    '                    fila_editar = item
                    '                End If
                    '                item = item + 1
                    '            End While
                    '            'ahora veo de agregar o editar
                    '            If presente = "no" Then
                    '                'agrego una nueva fila
                    '                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Producto_agregado").NewRow()
                    '                newCustomersRow("PROD_id") = ds_PROD.Tables(1).Rows(i).Item("prod_id").ToString
                    '                newCustomersRow("codinterno") = ds_PROD.Tables(1).Rows(i).Item("prod_codinterno").ToString
                    '                newCustomersRow("descripcion") = ds_PROD.Tables(1).Rows(i).Item("prod_descripcion").ToString
                    '                newCustomersRow("detalle") = ds_PROD.Tables(1).Rows(i).Item("prod_descrilarga").ToString
                    '                Dim cant As Integer = 1
                    '                newCustomersRow("cantidad") = cant
                    '                newCustomersRow("precio_unitario") = ds_PROD.Tables(1).Rows(i).Item("prod_precio_vta")

                    '                Dim total As Decimal = 0
                    '                total = cant * CDec(ds_PROD.Tables(1).Rows(i).Item("prod_precio_vta"))
                    '                newCustomersRow("precio_subtotal") = CDec(Math.Round(total, 2)).ToString("N2")
                    '                Venta_Caja_ds.Tables("Producto_agregado").Rows.Add(newCustomersRow)
                    '                Venta_Caja_gestion.DataG_lista.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                    '                Dim a As Integer = Venta_Caja_gestion.DataG_lista.Rows.Count
                    '                Venta_Caja_gestion.DataG_lista.Rows(a - 1).Cells(0).Value = a

                    '            Else
                    '                ''edito una fila existente, solo si el usuario lo desea, pregunta!!!
                    '                'Dim result As DialogResult
                    '                'result = MessageBox.Show("Ya esta agregado ¿Desea modificar?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                    '                'If result = DialogResult.OK Then

                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(0).Value = DG_Producto.CurrentRow.Cells(0).Value.ToString
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(1).Value = DG_Producto.CurrentRow.Cells(1).Value.ToString
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(2).Value = DG_Producto.CurrentRow.Cells(2).Value.ToString
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(3).Value = TX_LISTA_PROD_cant.Text
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(4).Value = Label_preciolista.Text
                    '                '    Lista_alta.DataG_lista.Rows(fila_editar).Cells(5).Value = CDec(Label_preciototal.Text)
                    '                'End If
                    '            End If

                    '            encontrado = "Si"

                    '        End If

                    '        i = i + 1
                    '    End While

                    '    If encontrado = "No" Then
                    '        MsgBox("no existe")
                    '        Venta_Caja_gestion.TX_busc_codinterno.SelectAll()
                    '    Else
                    '        Venta_Caja_gestion.tx_cantidad.Text = "1"
                    '        Venta_Caja_gestion.tx_cantidad.Focus()
                    '        Venta_Caja_gestion.tx_cantidad.SelectAll()
                    '    End If
                    'End If
                    'Venta_Caja_gestion.calcular_totales()
                End If

            Case "Mesa_cargar"
                'cuando presiono enter busco el prod o combo en el dataset...DS_PROD
                If DataGridView1.CurrentRow IsNot Nothing Then
                    Mesa_cargar.TX_busc_codinterno.Text = DataGridView1.CurrentRow.Cells(1).Value
                    Mesa_cargar.TX_busc_codinterno.Focus()
                    Mesa_cargar.TX_busc_codinterno.SelectAll()
                    Mesa_cargar.RB_CodInterno.Checked = True
                End If

            Case "GM_Carga_Producto"
                If DataGridView1.CurrentRow IsNot Nothing Then
                    GM_Carga_Producto.tb_codint.Text = DataGridView1.CurrentRow.Cells(1).Value
                    GM_Carga_Producto.tb_desc.Text = DataGridView1.CurrentRow.Cells(2).Value
                    GM_Carga_Producto.tb_codint.Focus()
                    GM_Carga_Producto.tb_codint.SelectAll()
                    GM_Carga_Producto.Buscar_Cantidades(DataGridView1.CurrentRow.Cells(0).Value, Gestion_Mercaderia.cb_origen.SelectedValue, Gestion_Mercaderia.cb_destino.SelectedValue)
                End If
            Case "Pedido_Productos"
                If DataGridView1.CurrentRow IsNot Nothing Then
                    Dim i As Integer = 0
                    Dim indice_row As Integer = 0
                    Dim cant_rows_grid As Integer = Pedido_Productos.DataGridView1.Rows.Count
                    Dim agregado As String = "no"
                    While i < Pedido_Productos.DataGridView1.Rows.Count
                        If Pedido_Productos.DataGridView1.Rows(i).Cells("prod_codinterno").Value = "" Then
                            Pedido_Buscar_y_cargar_en_grilla(DataGridView1.CurrentRow.Cells(1).Value)
                            i = Pedido_Productos.DataGridView1.Rows.Count
                            agregado = "si"
                        Else
                            i = i + 1
                        End If
                    End While
                    If agregado = "no" Then
                        Pedido_Productos.DataGridView1.Rows.Add()
                        Pedido_Buscar_y_cargar_en_grilla(DataGridView1.CurrentRow.Cells(1).Value)
                    End If
                    Pedido_Productos.DataGridView1.Rows.Add() 'AGREGO UNO EXTRA PARA EL PROXIMO ITEM
                End If


            Case "Servicio_nuevo"
                If DataGridView1.CurrentRow IsNot Nothing Then
                    Servicio_nuevo.TextBox_codprod.Text = DataGridView1.CurrentRow.Cells(1).Value
                    Servicio_nuevo.TextBox_codprod.Focus()
                    Servicio_nuevo.TextBox_codprod.SelectAll()

                End If


        End Select

        Me.Close()
    End Sub
    Private Sub tx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Buscar.KeyPress
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "Pedido_Productos" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Gestion_Mercaderia" Or form_procedencia = "Servicio_nuevo" Then
            Dim Filtro
            Filtro = String.Format("{0} LIKE '%{1}%'", "prod_descripcion", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
            ProductosCombosBindingSource1.Filter = Filtro
            If DataGridView1.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(prod_codinterno, System.String) LIKE '%{0}%'", tx_Buscar.Text)
                ProductosCombosBindingSource1.Filter = Filtro
                If DataGridView1.Rows.Count = 0 Then
                    Filtro = String.Format("CONVERT(prod_codbarra, System.String) LIKE '%{0}%'", tx_Buscar.Text) 'esto para campos strings, FUNCIONA PERFECTO
                    ProductosCombosBindingSource1.Filter = Filtro
                End If
            End If
        Else
            If e.KeyChar = ChrW(Keys.Enter) Then 'cuando presiono la tecla ENTER calcula
                DataGridView1.DataSource = Nothing
                If tx_Buscar.Text <> "" Then
                    Filtrar_datatable(tx_Buscar.Text)
                Else
                    Select Case form_procedencia
                        Case "Venta_Caja_gestion"
                            If Venta_Caja_gestion.RB_No.Checked = True Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                            End If
                        Case "Mesas_gestion"
                            If Mesas_gestion.RB_No.Checked = True Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                            End If
                        Case "Mesa_cargar"
                            If Mesa_cargar.RB_No = True Then
                                DataGridView1.DataSource = ds_PROD.Tables(1)
                            Else
                                DataGridView1.DataSource = ds_PROD.Tables(0)
                            End If
                        Case "GM_Carga_Producto"
                            DataGridView1.DataSource = ds_PROD.Tables(1)
                        Case "Pedido_Productos"
                            DataGridView1.DataSource = ds_PROD.Tables(0)
                    End Select
                End If
                tx_Buscar.SelectAll()
            End If
        End If
    End Sub
    Private Sub Filtrar_datatable(ByVal parametro As String)
        Dim T As Integer = 0
        Select Case form_procedencia
            Case "Venta_Caja_gestion"
                If Venta_Caja_gestion.RB_No.Checked = True Then
                    T = 1
                Else
                    T = 0
                End If
            Case "Mesas_gestion"
                'Dim T As Integer = 0
                If Mesas_gestion.RB_No.Checked = True Then
                    T = 1
                Else
                    T = 0
                End If
            Case "Mesa_cargar"
                'Dim T As Integer = 0
                If Mesa_cargar.RB_No = True Then
                    T = 1
                Else
                    T = 0
                End If
            Case "GM_Carga_Producto"
                T = 1
        End Select

        If ds_PROD.Tables(T).Rows.Count <> 0 Then
            'uso ds_PROD que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("prod_id")
            table_filtrada.Columns.Add("prod_codinterno")
            table_filtrada.Columns.Add("prod_descripcion")
            table_filtrada.Columns.Add("prod_descrilarga")
            table_filtrada.Columns.Add("prod_precio_vta")
            table_filtrada.Columns.Add("prod_stock")
            table_filtrada.Columns.Add("prod_ptorepo")
            table_filtrada.Columns.Add("prod_precio_vta_May")
            DataGridView1.DataSource = Nothing
            Dim table As DataTable = ds_PROD.Tables(T)
            Dim nombre As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("prod_descripcion")
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If

                a = a + 1
            End While
            If table_filtrada.Rows.Count <> 0 Then
                DataGridView1.DataSource = table_filtrada
            Else
                DataGridView1.DataSource = ds_PROD.Tables(T)
            End If
        End If
    End Sub
    Private Sub Mostrar_detalle_combo()
        Select Case form_procedencia
            Case "Venta_Caja_gestion"
                Lb_combo.Text = "- - - - - - - - - - - - - - - -"

                DataGridView2.DataSource = Nothing
                Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                If Venta_Caja_gestion.RB_No.Checked = True Then
                    If rb_no_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(2).Rows.Count
                                    If ds_PROD.Tables(2).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(2).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(3).Rows.Count
                                            If ds_PROD.Tables(3).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(3).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If

                If Venta_Caja_gestion.RB_Si.Checked = True Then
                    If rb_si_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(1).Rows.Count
                                    If ds_PROD.Tables(1).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(1).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(2).Rows.Count
                                            If ds_PROD.Tables(2).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(2).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If


                    End If
                End If



            Case "Mesa_cargar"
                Lb_combo.Text = "- - - - - - - - - - - - - - - -"

                DataGridView2.DataSource = Nothing
                Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                If Mesa_cargar.RB_No = True Then
                    If rb_no_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(2).Rows.Count
                                    If ds_PROD.Tables(2).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(2).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(3).Rows.Count
                                            If ds_PROD.Tables(3).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(3).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If

                If Mesa_cargar.RB_Si = True Then
                    If rb_si_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(1).Rows.Count
                                    If ds_PROD.Tables(1).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(1).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(2).Rows.Count
                                            If ds_PROD.Tables(2).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(2).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If





            Case "Mesas_gestion"
                Lb_combo.Text = "- - - - - - - - - - - - - - - -"

                DataGridView2.DataSource = Nothing
                Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                If Mesas_gestion.RB_No.Checked = True Then
                    If rb_no_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(2).Rows.Count
                                    If ds_PROD.Tables(2).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(2).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(3).Rows.Count
                                            If ds_PROD.Tables(3).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(3).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(3).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If

                If Mesas_gestion.RB_Si.Checked = True Then
                    If rb_si_combo = "si" Then
                        If DataGridView1.RowCount <> 0 Then
                            If DataGridView1.CurrentRow IsNot Nothing Then
                                Dim cod_interno As Integer = DataGridView1.CurrentRow.Cells(1).Value
                                Dim i As Integer = 0
                                Dim encontrado As String = "no"
                                While i < ds_PROD.Tables(1).Rows.Count
                                    If ds_PROD.Tables(1).Rows(i).Item("prod_codinterno") = cod_interno Then
                                        Dim prod_id As Integer = ds_PROD.Tables(1).Rows(i).Item("prod_id")
                                        Dim j As Integer = 0
                                        While j < ds_PROD.Tables(2).Rows.Count
                                            If ds_PROD.Tables(2).Rows(j).Item("ProdCombo_id") = prod_id Then
                                                Lb_combo.Text = DataGridView1.CurrentRow.Cells(2).Value

                                                Dim newCustomersRow As DataRow = Venta_Caja_ds.Tables("Combo_detalles").NewRow()
                                                newCustomersRow("Descripción") = ds_PROD.Tables(2).Rows(j).Item("prod_descripcion").ToString
                                                newCustomersRow("Cantidad") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_cantidad").ToString
                                                newCustomersRow("Precio U.") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_precio").ToString
                                                newCustomersRow("Precio Subtotal") = ds_PROD.Tables(2).Rows(j).Item("ProdComboDet_subtotal").ToString
                                                Venta_Caja_ds.Tables("Combo_detalles").Rows.Add(newCustomersRow)
                                                DataGridView2.DataSource = Venta_Caja_ds.Tables("Combo_detalles")
                                                encontrado = "si"
                                            End If
                                            j = j + 1
                                        End While
                                    End If
                                    i = i + 1
                                End While
                                If encontrado = "no" Then
                                    DataGridView2.DataSource = Nothing
                                    Venta_Caja_ds.Tables("Combo_detalles").Rows.Clear()
                                End If
                            Else
                            End If
                        Else
                            'aqui tendria q poner los label como estan al principio x defecto
                        End If
                    End If
                End If

        End Select
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Mostrar_detalle_combo()
    End Sub

    Private Sub DataGridView1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.GotFocus
        RectangleShape1.Visible = True
    End Sub

    Private Sub DataGridView1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.LostFocus
        RectangleShape1.Visible = False
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Mostrar_detalle_combo()
    End Sub

    Private Sub tx_Buscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Buscar.LostFocus
        'tx_Buscar.BackColor = Color.White
    End Sub
    Private Sub tx_Buscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Buscar.GotFocus
        'tx_Buscar.SelectAll()
        ' tx_Buscar.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub cb_categoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_categoria.SelectedIndexChanged
        categoriarubro_obtener()
        rubrosubrubro_obtener()
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
            If evento_load_completo = "si" Then
                If check_categoria.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_categoria("")
                    Else
                        filtrar_por_categoria("sin marca")
                    End If

                    If cb_rubro.Items.Count <> 0 Then
                        check_rubro.Enabled = True
                    Else
                        check_rubro.Enabled = False
                    End If
                Else
                    If check_marca.Checked = True Then
                        filtrar_solo_por_marca()
                    Else
                        Obtener_Productos_Combos()
                    End If
                End If
            End If
        End If
        If form_procedencia = "Pedido_Productos" Then
            If evento_load_completo = "si" Then
                If check_categoria.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_categoria_pedidos("")
                    Else
                        filtrar_por_categoria_pedidos("sin marca")
                    End If

                    If cb_rubro.Items.Count <> 0 Then
                        check_rubro.Enabled = True
                    Else
                        check_rubro.Enabled = False
                    End If
                Else
                    If check_marca.Checked = True Then
                        filtrar_solo_por_marca_pedidos()
                    Else
                        Obtener_Productos_Combos()
                    End If
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
            If evento_load_completo = "si" Then
                If check_categoria.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_categoria_GM("")
                    Else
                        filtrar_por_categoria_GM("sin marca")
                    End If

                    If cb_rubro.Items.Count <> 0 Then
                        check_rubro.Enabled = True
                    Else
                        check_rubro.Enabled = False
                    End If
                Else
                    If check_marca.Checked = True Then
                        filtrar_solo_por_marca_GM()
                    Else
                        Obtener_Productos_Combos()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub cb_rubro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_rubro.SelectedIndexChanged
        rubrosubrubro_obtener()
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
            If evento_load_completo = "si" Then
                If check_rubro.Checked = True Then

                    If check_marca.Checked = True Then
                        filtrar_por_rubro("")
                    Else
                        filtrar_por_rubro("sin marca")
                    End If

                    If cb_subrubro.Items.Count <> 0 Then
                        check_subrubro.Enabled = True
                    Else
                        check_subrubro.Enabled = False
                    End If
                Else
                    If check_categoria.Checked = True Then
                        If check_marca.Checked = True Then
                            filtrar_por_categoria("")
                        Else
                            filtrar_por_categoria("sin marca")
                        End If
                    Else
                        Obtener_Productos_Combos()
                    End If
                End If
            End If
        End If
        If form_procedencia = "Pedido_Productos" Then
            If evento_load_completo = "si" Then
                If check_rubro.Checked = True Then

                    If check_marca.Checked = True Then
                        filtrar_por_rubro_pedidos("")
                    Else
                        filtrar_por_rubro_pedidos("sin marca")
                    End If

                    If cb_subrubro.Items.Count <> 0 Then
                        check_subrubro.Enabled = True
                    Else
                        check_subrubro.Enabled = False
                    End If
                Else
                    If check_categoria.Checked = True Then
                        If check_marca.Checked = True Then
                            filtrar_por_categoria_pedidos("")
                        Else
                            filtrar_por_categoria_pedidos("sin marca")
                        End If
                    Else
                        Obtener_Productos_Combos()
                    End If
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
            If evento_load_completo = "si" Then
                If check_rubro.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_rubro_GM("")
                    Else
                        filtrar_por_rubro_GM("sin marca")
                    End If
                    If cb_subrubro.Items.Count <> 0 Then
                        check_subrubro.Enabled = True
                    Else
                        check_subrubro.Enabled = False
                    End If
                Else
                    If check_categoria.Checked = True Then
                        If check_marca.Checked = True Then
                            filtrar_por_categoria_GM("")
                        Else
                            filtrar_por_categoria_GM("sin marca")
                        End If
                    Else
                        Obtener_Productos_Combos()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub cb_subrubro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_subrubro.SelectedIndexChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
            If evento_load_completo = "si" Then
                If check_subrubro.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_subrubro("")
                    Else
                        filtrar_por_subrubro("sin marca")
                    End If
                Else
                    If check_marca.Checked = True Then
                        filtrar_por_rubro("")
                    Else
                        filtrar_por_rubro("sin marca")
                    End If
                End If
            End If
        End If
        If form_procedencia = "Pedido_Productos" Then
            If evento_load_completo = "si" Then
                If check_subrubro.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_subrubro_pedidos("")
                    Else
                        filtrar_por_subrubro_pedidos("sin marca")
                    End If
                Else
                    If check_marca.Checked = True Then
                        filtrar_por_rubro_pedidos("")
                    Else
                        filtrar_por_rubro_pedidos("sin marca")
                    End If
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
            If evento_load_completo = "si" Then
                If check_subrubro.Checked = True Then
                    If check_marca.Checked = True Then
                        filtrar_por_subrubro_GM("")
                    Else
                        filtrar_por_subrubro_GM("sin marca")
                    End If
                Else
                    If check_marca.Checked = True Then
                        filtrar_por_rubro_GM("")
                    Else
                        filtrar_por_rubro_GM("sin marca")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub cb_marca_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_marca.SelectedIndexChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
            If check_marca.Checked = True Then
                If check_categoria.Checked = True Then
                    'tengo q llamar a la rutina q filtre marcas y categorias
                Else
                    'aqui llamo a la rutina q trae filtrado por marca
                    filtrar_solo_por_marca()
                End If
            End If
            check_categoria.Checked = False
        End If
        If form_procedencia = "Pedido_Productos" Then
            If check_marca.Checked = True Then
                If check_categoria.Checked = True Then
                    'tengo q llamar a la rutina q filtre marcas y categorias
                Else
                    'aqui llamo a la rutina q trae filtrado por marca
                    filtrar_solo_por_marca_pedidos()
                End If
            End If
            check_categoria.Checked = False
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
            If check_marca.Checked = True Then
                If check_categoria.Checked = True Then
                    'tengo q llamar a la rutina q filtre marcas y categorias
                Else
                    'aqui llamo a la rutina q trae filtrado por marca
                    filtrar_solo_por_marca_GM()
                End If
            End If
            check_categoria.Checked = False
        End If
    End Sub
    Private Sub check_marca_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_marca.CheckedChanged

        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then '  "Pedido_Productos"
            If check_marca.Checked = True Then
                If cb_marca.Items.Count <> 0 Then
                    cb_marca.Enabled = True
                    check_categoria.Checked = False
                    check_rubro.Checked = False
                    check_subrubro.Checked = False
                    If check_categoria.Checked = True Then
                        'aqui filtro por categoria y marca...para ello mando lo siguiente
                        filtrar_por_categoria("")
                    Else
                        'aqui llamo a la rutina q trae filtrado por marca
                        filtrar_solo_por_marca()
                    End If
                Else
                    cb_marca.Enabled = False
                End If
            Else
                If check_subrubro.Checked = True Then
                    check_subrubro.Checked = False
                End If
                If check_rubro.Checked = True Then
                    check_rubro.Checked = False
                End If
                If check_categoria.Checked = True Then
                    check_categoria.Checked = False
                End If
                cb_marca.Enabled = False
                Obtener_Productos_Combos()
            End If
        End If

        If form_procedencia = "Pedido_Productos" Then
            If check_marca.Checked = True Then
                If cb_marca.Items.Count <> 0 Then
                    cb_marca.Enabled = True
                    check_categoria.Checked = False
                    check_rubro.Checked = False
                    check_subrubro.Checked = False
                    If check_categoria.Checked = True Then
                        'aqui filtro por categoria y marca...para ello mando lo siguiente
                        filtrar_por_categoria("")
                    Else
                        'aqui llamo a la rutina q trae filtrado por marca
                        filtrar_solo_por_marca_pedidos()
                    End If
                Else
                    cb_marca.Enabled = False
                End If
            Else
                If check_subrubro.Checked = True Then
                    check_subrubro.Checked = False
                End If
                If check_rubro.Checked = True Then
                    check_rubro.Checked = False
                End If
                If check_categoria.Checked = True Then
                    check_categoria.Checked = False
                End If
                cb_marca.Enabled = False
                Obtener_Productos_Combos()
            End If
        End If

        If form_procedencia = "Gestion_Mercaderia" Then
            If check_marca.Checked = True Then
                If cb_marca.Items.Count <> 0 Then
                    cb_marca.Enabled = True
                    check_categoria.Checked = False
                    check_rubro.Checked = False
                    check_subrubro.Checked = False
                    If check_categoria.Checked = True Then
                        'aqui filtro por categoria y marca...para ello mando lo siguiente
                        filtrar_por_categoria_GM("")
                    Else
                        'aqui llamo a la rutina q trae filtrado por marca
                        filtrar_solo_por_marca_GM()
                    End If
                Else
                    cb_marca.Enabled = False
                End If
            Else
                If check_subrubro.Checked = True Then
                    check_subrubro.Checked = False
                End If
                If check_rubro.Checked = True Then
                    check_rubro.Checked = False
                End If
                If check_categoria.Checked = True Then
                    check_categoria.Checked = False
                End If
                cb_marca.Enabled = False
                Obtener_Productos_Combos()
            End If
        End If
    End Sub
    Private Sub check_categoria_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_categoria.CheckedChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
            If check_categoria.Checked = True Then
                If cb_categoria.Items.Count <> 0 Then
                    'check_marca.Checked = False

                    If cb_rubro.Items.Count <> 0 Then
                        check_rubro.Enabled = True
                    Else
                        check_rubro.Enabled = False
                    End If


                    cb_categoria.Enabled = True
                    'una vez seleccionado, hago q filtre x la categoria actualmente seleccionada
                    If check_marca.Checked = True Then
                        filtrar_por_categoria("")
                    Else
                        filtrar_por_categoria("sin marca")
                    End If
                Else
                    cb_categoria.Enabled = False
                End If
            Else
                check_subrubro.Checked = False
                check_rubro.Checked = False
                check_subrubro.Enabled = False
                check_rubro.Enabled = False
                cb_categoria.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_solo_por_marca()
                Else
                    'voy a traer todos los productos
                    Obtener_Productos_Combos()
                End If
            End If
        End If
        If form_procedencia = "Pedido_Productos" Then
            If check_categoria.Checked = True Then
                If cb_categoria.Items.Count <> 0 Then
                    'check_marca.Checked = False

                    If cb_rubro.Items.Count <> 0 Then
                        check_rubro.Enabled = True
                    Else
                        check_rubro.Enabled = False
                    End If


                    cb_categoria.Enabled = True
                    'una vez seleccionado, hago q filtre x la categoria actualmente seleccionada
                    If check_marca.Checked = True Then
                        filtrar_por_categoria_pedidos("")
                    Else
                        filtrar_por_categoria_pedidos("sin marca")
                    End If
                Else
                    cb_categoria.Enabled = False
                End If
            Else
                check_subrubro.Checked = False
                check_rubro.Checked = False
                check_subrubro.Enabled = False
                check_rubro.Enabled = False
                cb_categoria.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_solo_por_marca_pedidos()
                Else
                    'voy a traer todos los productos
                    Obtener_Productos_Combos()
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
            If check_categoria.Checked = True Then
                If cb_categoria.Items.Count <> 0 Then
                    'check_marca.Checked = False

                    If cb_rubro.Items.Count <> 0 Then
                        check_rubro.Enabled = True
                    Else
                        check_rubro.Enabled = False
                    End If


                    cb_categoria.Enabled = True
                    'una vez seleccionado, hago q filtre x la categoria actualmente seleccionada
                    If check_marca.Checked = True Then
                        filtrar_por_categoria_GM("")
                    Else
                        filtrar_por_categoria_GM("sin marca")
                    End If
                Else
                    cb_categoria.Enabled = False
                End If
            Else
                check_subrubro.Checked = False
                check_rubro.Checked = False
                check_subrubro.Enabled = False
                check_rubro.Enabled = False
                cb_categoria.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_solo_por_marca_GM()
                Else
                    'voy a traer todos los productos
                    Obtener_Productos_Combos()
                End If
            End If
        End If

    End Sub
    Private Sub check_rubro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_rubro.CheckedChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
            If check_rubro.Checked = True Then
                If cb_rubro.Items.Count <> 0 Then
                    If cb_subrubro.Items.Count <> 0 Then
                        check_subrubro.Enabled = True
                    Else
                        check_subrubro.Enabled = False
                    End If


                    cb_rubro.Enabled = True

                    If check_marca.Checked = True Then
                        filtrar_por_rubro("")
                    Else
                        filtrar_por_rubro("sin marca")
                    End If
                End If
            Else
                check_subrubro.Checked = False
                check_subrubro.Enabled = False
                cb_rubro.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_por_categoria("")
                Else
                    filtrar_por_categoria("sin marca")
                End If

            End If
        End If
        If form_procedencia = "Pedido_Productos" Then
            If check_rubro.Checked = True Then
                If cb_rubro.Items.Count <> 0 Then
                    If cb_subrubro.Items.Count <> 0 Then
                        check_subrubro.Enabled = True
                    Else
                        check_subrubro.Enabled = False
                    End If


                    cb_rubro.Enabled = True

                    If check_marca.Checked = True Then
                        filtrar_por_rubro_pedidos("")
                    Else
                        filtrar_por_rubro_pedidos("sin marca")
                    End If
                End If
            Else
                check_subrubro.Checked = False
                check_subrubro.Enabled = False
                cb_rubro.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_por_categoria_pedidos("")
                Else
                    filtrar_por_categoria_pedidos("sin marca")
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
            If check_rubro.Checked = True Then
                If cb_rubro.Items.Count <> 0 Then
                    If cb_subrubro.Items.Count <> 0 Then
                        check_subrubro.Enabled = True
                    Else
                        check_subrubro.Enabled = False
                    End If


                    cb_rubro.Enabled = True

                    If check_marca.Checked = True Then
                        filtrar_por_rubro_GM("")
                    Else
                        filtrar_por_rubro_GM("sin marca")
                    End If
                End If
            Else
                check_subrubro.Checked = False
                check_subrubro.Enabled = False
                cb_rubro.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_por_categoria_GM("")
                Else
                    filtrar_por_categoria_GM("sin marca")
                End If
            End If
        End If
    End Sub
    Private Sub check_subrubro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_subrubro.CheckedChanged
        If form_procedencia = "Venta_Caja_gestion" Or form_procedencia = "GM_Carga_Producto" Or form_procedencia = "Servicio_nuevo" Then
            If check_subrubro.Checked = True Then
                If cb_subrubro.Items.Count <> 0 Then
                    cb_subrubro.Enabled = True

                    If check_marca.Checked = True Then
                        filtrar_por_subrubro("")
                    Else
                        filtrar_por_subrubro("sin marca")
                    End If
                End If
            Else
                cb_subrubro.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_por_rubro("")
                Else
                    filtrar_por_rubro("sin marca")
                End If
            End If
        End If
        If form_procedencia = "Pedido_Productos" Then
            If check_subrubro.Checked = True Then
                If cb_subrubro.Items.Count <> 0 Then
                    cb_subrubro.Enabled = True

                    If check_marca.Checked = True Then
                        filtrar_por_subrubro_pedidos("")
                    Else
                        filtrar_por_subrubro_pedidos("sin marca")
                    End If
                End If
            Else
                cb_subrubro.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_por_rubro_pedidos("")
                Else
                    filtrar_por_rubro_pedidos("sin marca")
                End If
            End If
        End If
        If form_procedencia = "Gestion_Mercaderia" Then
            If check_subrubro.Checked = True Then
                If cb_subrubro.Items.Count <> 0 Then
                    cb_subrubro.Enabled = True

                    If check_marca.Checked = True Then
                        filtrar_por_subrubro_GM("")
                    Else
                        filtrar_por_subrubro_GM("sin marca")
                    End If
                End If
            Else
                cb_subrubro.Enabled = False
                If check_marca.Checked = True Then
                    filtrar_por_rubro_GM("")
                Else
                    filtrar_por_rubro_GM("sin marca")
                End If
            End If
        End If
    End Sub


#Region "filtros venta gestion"
    Private Sub filtrar_por_categoria(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria(Inicio.USU_id)
        Else
            ds_productos = ds_prod_marca
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)

            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'busco en categoria
                    If id_categorias = idcat Then
                        'lo agrego
                        Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                        row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                        row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                        row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                        row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                        row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                        row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                        row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                        row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                        row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                        Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                    End If
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_categorias = ds_productos.Tables(2).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")
                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(2).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_categorias = ds_productos.Tables(3).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
    Private Sub filtrar_por_rubro(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria(Inicio.USU_id)
        Else
            ds_productos = ds_prod_marca
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)
            Dim id_rubro As Integer = CInt(cb_rubro.SelectedValue)
            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'no lo pongo
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_rubro = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(2).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_rubro = ds_productos.Tables(3).Rows(j).Item("Rubro_cat2_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
    Private Sub filtrar_por_subrubro(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria(Inicio.USU_id)
        Else
            ds_productos = ds_prod_marca
        End If
        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)
            Dim id_rubro As Integer = CInt(cb_rubro.SelectedValue)
            Dim id_subrubro As Integer = CInt(cb_subrubro.SelectedValue)
            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'no lo pongo
                End If
                If nrocat = 2 Then
                    'busco en rubro
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_subrubro = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
    Dim ds_prod_marca As DataSet
    Private Sub filtrar_solo_por_marca()
        ds_prod_marca = DAVentas.Venta_obtenerProducto_Combos_marca(Inicio.USU_id, cb_marca.SelectedValue)
        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
        If ds_prod_marca.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_prod_marca.Tables(0))
        End If
        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
    End Sub
#End Region

#Region "filtros pedido_productos"
    Dim ds_prod_marca_pedido
    Private Sub filtrar_solo_por_marca_pedidos()
        ds_prod_marca_pedido = DApedidos.Productos_x_Proveedor_Obtener_marca(Pedido_Productos.Prove_ID, cb_marca.SelectedValue)
        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
        If ds_prod_marca_pedido.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_prod_marca_pedido.Tables(0))
        End If
        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
    End Sub
    Private Sub filtrar_por_categoria_pedidos(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DApedidos.Productos_x_Proveedor_Obtener_categoria(Pedido_Productos.Prove_ID)
        Else
            ds_productos = ds_prod_marca_pedido
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)

            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'busco en categoria
                    If id_categorias = idcat Then
                        'lo agrego
                        Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                        row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                        row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                        row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                        row("prod_descrilarga") = ""
                        row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                        row("prod_stock") = 0
                        row("prod_ptorepo") = 0
                        row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                        row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                        Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                    End If
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_categorias = ds_productos.Tables(2).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(2).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_categorias = ds_productos.Tables(3).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
    Private Sub filtrar_por_rubro_pedidos(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DApedidos.Productos_x_Proveedor_Obtener_categoria(Pedido_Productos.Prove_ID)
        Else
            ds_productos = ds_prod_marca_pedido
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)
            Dim id_rubro As Integer = CInt(cb_rubro.SelectedValue)
            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'no lo pongo
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_rubro = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(2).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_rubro = ds_productos.Tables(3).Rows(j).Item("Rubro_cat2_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
    Private Sub filtrar_por_subrubro_pedidos(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DApedidos.Productos_x_Proveedor_Obtener_categoria(Pedido_Productos.Prove_ID)
        Else
            ds_productos = ds_prod_marca_pedido
        End If
        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)
            Dim id_rubro As Integer = CInt(cb_rubro.SelectedValue)
            Dim id_subrubro As Integer = CInt(cb_subrubro.SelectedValue)
            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'no lo pongo
                End If
                If nrocat = 2 Then
                    'busco en rubro
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_subrubro = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ""
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = 0
                                row("prod_ptorepo") = 0
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
#End Region

#Region "filtrar Gestion Mercaderia"
    Dim ds_prod_gestmerc
    Private Sub filtrar_solo_por_marca_GM()
        ds_prod_gestmerc = DAVentas.Venta_obtenerProducto_Combos_marca_GM(sucursal_id, cb_marca.SelectedValue)
        Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
        If ds_prod_gestmerc.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Merge(ds_prod_gestmerc.Tables(0))
        End If
    End Sub
    Private Sub filtrar_por_categoria_GM(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria_GM(sucursal_id) 'aqui tengo q pasar la sucursal_id
        Else
            ds_productos = ds_prod_gestmerc
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)

            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'busco en categoria
                    If id_categorias = idcat Then
                        'lo agrego
                        Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                        row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                        row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                        row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                        row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                        row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                        row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                        row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                        row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                        row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                        Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                    End If
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_categorias = ds_productos.Tables(2).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(2).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_categorias = ds_productos.Tables(3).Rows(j).Item("Categoria_cat_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
    Private Sub filtrar_por_rubro_GM(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria_GM(sucursal_id)
        Else
            ds_productos = ds_prod_gestmerc
        End If

        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)
            Dim id_rubro As Integer = CInt(cb_rubro.SelectedValue)
            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'no lo pongo
                End If
                If nrocat = 2 Then
                    'busco en rubro
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(2).Rows.Count
                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                            If id_rubro = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(2).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_rubro = ds_productos.Tables(3).Rows(j).Item("Rubro_cat2_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
    Private Sub filtrar_por_subrubro_GM(ByVal filtro_descrip As String)
        Dim ds_productos As DataSet
        If filtro_descrip = "sin marca" Then
            ds_productos = DAVentas.Venta_obtenerProducto_Combos_categoria_GM(sucursal_id)
        Else
            ds_productos = ds_prod_gestmerc
        End If
        If ds_productos.Tables(0).Rows.Count <> 0 Then
            'si hay productos, voy a armar un dataset con los productos q realmente quiera mostrar.
            'tabla productos_combo
            'DataGridView1.Rows.Clear()
            Venta_Caja_ds.Tables("Productos_Combos").Rows.Clear()
            Dim id_categorias As Integer = CInt(cb_categoria.SelectedValue)
            Dim id_rubro As Integer = CInt(cb_rubro.SelectedValue)
            Dim id_subrubro As Integer = CInt(cb_subrubro.SelectedValue)
            Dim i As Integer = 0
            While i < ds_productos.Tables(0).Rows.Count
                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("nrocat"))
                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("idcat"))
                If nrocat = 1 Then
                    'no lo pongo
                End If
                If nrocat = 2 Then
                    'busco en rubro
                End If
                If nrocat = 3 Then
                    'busco en subrubro then
                    Dim j As Integer = 0
                    While j < ds_productos.Tables(3).Rows.Count
                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                            If id_subrubro = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                                Dim row As DataRow = Venta_Caja_ds.Tables("Productos_Combos").NewRow()
                                row("prod_id") = ds_productos.Tables(0).Rows(i).Item("prod_id")
                                row("prod_codinterno") = ds_productos.Tables(0).Rows(i).Item("prod_codinterno")
                                row("prod_descripcion") = ds_productos.Tables(0).Rows(i).Item("prod_descripcion")
                                row("prod_descrilarga") = ds_productos.Tables(0).Rows(i).Item("prod_descrilarga")
                                row("prod_precio_vta") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta")
                                row("prod_stock") = ds_productos.Tables(0).Rows(i).Item("prod_stock")
                                row("prod_ptorepo") = ds_productos.Tables(0).Rows(i).Item("prod_ptorepo")
                                row("prod_precio_vta_May") = ds_productos.Tables(0).Rows(i).Item("prod_precio_vta_May")
                                row("prod_codbarra") = ds_productos.Tables(0).Rows(i).Item("prod_codbarra")

                                Venta_Caja_ds.Tables("Productos_Combos").Rows.Add(row)
                                j = ds_productos.Tables(3).Rows.Count
                            End If
                        End If
                        j = j + 1
                    End While
                End If
                i = i + 1
            End While
            'DataGridView1.DataSource = Venta_Caja_ds.Tables("Productos_Combos")
        End If
    End Sub
#End Region


   
End Class