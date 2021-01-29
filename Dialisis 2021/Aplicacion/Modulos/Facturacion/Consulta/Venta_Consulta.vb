Public Class Venta_Consulta

    Dim DAVentas As New Datos.Venta
    Dim DAUsuario As New Datos.Usuario
    Dim dataset_ventas As DataSet

    Private Sub Venta_Consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        tablas_suma()
        obtener_ventas()
        obtener_usuarios()
        tabla_filtrada()
        'seleccionar el usuario administrador
        If ds_usuarios.Tables(0).Rows.Count <> 0 Then
            'selecciono el administrador
            Dim i As Integer = 0
            While i < ds_usuarios.Tables(0).Rows.Count
                If ds_usuarios.Tables(0).Rows(i).Item("UT_desc") = "Administrador" Then
                    CB_usuarios.SelectedValue = ds_usuarios.Tables(0).Rows(i).Item("USU_id")
                    i = ds_usuarios.Tables(0).Rows.Count
                End If
                i = i + 1
            End While
        End If

        If DataGridView1.Rows.Count <> 0 Then
            Dim fecha_desde As Date = DataGridView1.Rows(0).Cells(1).Value
            DT_fecha_desde.Value = fecha_desde
        Else
            DT_fecha_desde.Value = Today
        End If

        DT_fecha_hasta.Value = Today

    End Sub

    Dim table_filtrada As New DataTable
    Private Sub tabla_filtrada()
        table_filtrada.Columns.Add("ventaprod_fecha", Type.GetType("System.DateTime"))
        table_filtrada.Columns.Add("ventaprod_total")
        table_filtrada.Columns.Add("Usuario")
        table_filtrada.Columns.Add("USU_id")
    End Sub

    Private Sub BUSCAR_RANGO()
        table_filtrada.Rows.Clear()
        Dim i As Integer = 0

        Dim USU_id_selec As Integer = CB_usuarios.SelectedValue
        Dim x As Integer = 0

        'Dim fecha_desde As Date = DT_fecha_desde.Text

        'Dim fecha_hasta As Date = DT_fecha_hasta.Text

        Dim admin As String = "no"
        While x < Tabla_suma.Rows.Count  'ds_usuarios.Tables(0).Rows.Count

            If (USU_id_selec = ds_usuarios.Tables(0).Rows(x).Item("USU_id")) And ds_usuarios.Tables(0).Rows(x).Item("UT_desc") = "Administrador" Then
                While i < Tabla_suma.Rows.Count
                    Dim fecha_bd As Date = Format(Tabla_suma.Rows(i).Item("ventaprod_fecha"), "dd/MM/yyyy")
                    If fecha_bd >= DT_fecha_desde.Text And fecha_bd <= DT_fecha_hasta.Text Then
                        table_filtrada.ImportRow(Tabla_suma.Rows(i))
                    End If
                    i = i + 1
                End While
                x = ds_usuarios.Tables(0).Rows.Count
                admin = "si"
            End If
            x = x + 1
        End While

        If admin = "no" Then
            i = 0
            While i < Tabla_suma.Rows.Count

                Dim fecha_bd As Date = Format(Tabla_suma.Rows(i).Item("ventaprod_fecha"), "dd/MM/yyyy")
                If fecha_bd >= DT_fecha_desde.Text And fecha_bd <= DT_fecha_hasta.Text And Tabla_suma.Rows(i).Item("USU_id") = CB_usuarios.SelectedValue Then
                    table_filtrada.ImportRow(Tabla_suma.Rows(i))
                End If
                i = i + 1
            End While
        End If
        If table_filtrada.Rows.Count <> 0 Then

            'table_filtrada.DefaultView.Sort = "[ventaprod_fecha] ASC"
            DataGridView1.DataSource = table_filtrada.DefaultView.ToTable

        Else
            DataGridView1.DataSource = ""
        End If

        calcular_totales()

    End Sub

    Dim Tabla_suma As New DataTable
    Private Sub tablas_suma()
        Tabla_suma.Columns.Add("ventaprod_fecha", Type.GetType("System.DateTime"))
        Tabla_suma.Columns.Add("ventaprod_total")
        Tabla_suma.Columns.Add("Usuario")
        Tabla_suma.Columns.Add("USU_id")
    End Sub

    Private Sub Sumar(ByVal dataset_ventas As DataSet)
        Dim i As Integer = 0

        Dim contados As Integer = dataset_ventas.Tables(0).Rows.Count
        While i < dataset_ventas.Tables(0).Rows.Count
            Dim Usuario As Integer = dataset_ventas.Tables(0).Rows(i).Item("USU_id")
            Dim fecha As Date = Format(dataset_ventas.Tables(0).Rows(i).Item("ventaprod_fecha"), "dd/MM/yyyy")
            Dim suma As Decimal = 0
            Dim j As Integer = 0
            Dim existe As String = "no"
            While j < Tabla_suma.Rows.Count
                Dim fecha_suma As Date = Format(Tabla_suma.Rows(j).Item("ventaprod_fecha"), "dd/MM/yyyy")
                If Usuario = Tabla_suma.Rows(j).Item("USU_id") And fecha = fecha_suma Then
                    existe = "si"
                End If
                j = j + 1
            End While
            j = 0
            If existe = "no" Then
                While j < dataset_ventas.Tables(0).Rows.Count
                    Dim fecha2 As Date = Format(dataset_ventas.Tables(0).Rows(j).Item("ventaprod_fecha"), "dd/MM/yyyy")
                    If fecha = fecha2 And Usuario = dataset_ventas.Tables(0).Rows(j).Item("USU_id") Then
                        suma = suma + dataset_ventas.Tables(0).Rows(j).Item("ventaprod_total")
                    End If
                    j = j + 1
                End While
                Dim VentaRow As DataRow = Tabla_suma.NewRow()
                VentaRow("ventaprod_fecha") = fecha
                VentaRow("ventaprod_total") = Math.Round(suma, 2).ToString("N2")
                VentaRow("Usuario") = dataset_ventas.Tables(0).Rows(i).Item("Usuario")
                VentaRow("USU_id") = Usuario

                Tabla_suma.Rows.Add(VentaRow)
            End If
            i = i + 1
        End While
        DataGridView1.DataSource = Tabla_suma

    End Sub

    Private Sub obtener_ventas()
        dataset_ventas = DAVentas.VentaProducto_consultausuario
        dataset_ventas.Tables(0).Merge(dataset_ventas.Tables(1))
        Sumar(dataset_ventas)
        ''vamos a unir las tablas del dataset....

        ''ahora lo pongo como recurso del dataset
        dataset_ventas.Tables(0).DefaultView.Sort = "[ventaprod_fecha] ASC"
        DataGridView1.DataSource = Tabla_suma.DefaultView.Sort = "[ventaprod_fecha] ASC"
        'DataGridView1.DataSource = dataset_ventas.Tables(0).DefaultView.ToTable
        calcular_totales()
    End Sub

    Public Sub calcular_totales()
        Label_total.Text = "0,00"
        'DataG_listaTotal.Rows.Clear()
        'DataG_listaTotal.Rows.Add()
        'sumamos los subtotales con un ciclo
        Dim sumar As Decimal = "0,00"
        Dim ii As Integer = 0
        While ii < DataGridView1.Rows.Count
            sumar = sumar + DataGridView1.Rows(ii).Cells("VentaprodtotalDataGridViewTextBoxColumn").Value
            ii = ii + 1
        End While
        sumar = Math.Round(sumar, 2)
        'DataG_listaTotal.Rows(0).Cells(0).Value = "TOTAL"
        Label_total.Text = (Math.Round(sumar, 2).ToString("N2"))
    End Sub


    Dim ds_usuarios As DataSet
    Private Sub obtener_usuarios()
        ds_usuarios = DAVentas.Venta_Usuario_obtener
        CB_usuarios.DataSource = ds_usuarios.Tables(0)
        CB_usuarios.DisplayMember = "ApellidoyNombre" '+ " " + "USU_nom"
        CB_usuarios.ValueMember = "USU_id"
    End Sub

    Private Sub BO_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_buscar.Click
        BUSCAR_RANGO()
    End Sub

    Private Sub DT_fecha_desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_fecha_desde.ValueChanged
        BUSCAR_RANGO()
    End Sub

    Private Sub DT_fecha_hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_fecha_hasta.ValueChanged
        BUSCAR_RANGO()
    End Sub

    Dim DS_detalles As DataSet
    Public Sub BO_producto_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_producto_modificar.Click
        Venta_detalle.Show()
        If Me.DataGridView1.CurrentRow IsNot Nothing Then

            Dim detalles As String = DataGridView1.SelectedCells(1).Value
            If detalles <> "" Then
                DS_detalles = DAVentas.VentaProducto_consulta(DataGridView1.CurrentRow.Cells("USUidDataGridViewTextBoxColumn").Value, Me.DataGridView1.CurrentRow.Cells("VentaprodfechaDataGridViewTextBoxColumn").Value)

                DS_detalles.Tables(0).Merge(DS_detalles.Tables(1))

                'Venta_detalle.DG_detalle.DataSource = DS_detalles.Tables(0)
                Venta_detalle.Venta_consulta = DS_detalles
            Else
                MsgBox("Seleccione un Producto", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un Producto", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class