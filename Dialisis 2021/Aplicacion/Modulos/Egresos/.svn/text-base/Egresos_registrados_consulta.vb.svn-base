Public Class Egresos_registrados_consulta

    Dim DAEgresos As New Datos.Egresos
    Dim DAUsuario As New Datos.Usuario
    Dim dataset_egresos As DataSet

    Private Sub Egresos_registrados_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        obtener_egresos()
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

        'selecciono la primera fecha de la grilla y la pongo en el boton

        If DataGridView1.Rows.Count <> 0 Then
            DT_fecha_desde.Value = DataGridView1.Rows(0).Cells(1).Value
        Else
            DT_fecha_desde.Value = Today
        End If

        DT_fecha_hasta.Value = Today
    End Sub

    Private Sub obtener_egresos()
        dataset_egresos = DAEgresos.Egresos_registrados_consulta()

        'vamos a unir las tablas del dataset....

        dataset_egresos.Tables(0).Merge(dataset_egresos.Tables(1))
        dataset_egresos.Tables(0).Merge(dataset_egresos.Tables(2))
        dataset_egresos.Tables(0).Merge(dataset_egresos.Tables(3))

        'ahora lo pongo como recurso del dataset
        dataset_egresos.Tables(0).DefaultView.Sort = "[Fecha] ASC"

        DataGridView1.DataSource = dataset_egresos.Tables(0).DefaultView.ToTable
        calcular_totales()

    End Sub

    Dim table_filtrada As New DataTable
    Private Sub tabla_filtrada()
        table_filtrada.Columns.Add("Codigo interno")
        table_filtrada.Columns.Add("Fecha", Type.GetType("System.DateTime"))
        table_filtrada.Columns.Add("Monto")
        table_filtrada.Columns.Add("Num Comprobante")
        table_filtrada.Columns.Add("Tipo de egreso")
        table_filtrada.Columns.Add("Detalle")
        table_filtrada.Columns.Add("Usuario")
        table_filtrada.Columns.Add("USU_id")

    End Sub
    Private Sub BUSCAR_RANGO()
        table_filtrada.Rows.Clear()
        Dim i As Integer = 0

        Dim USU_id_selec As Integer = CB_usuarios.SelectedValue
        Dim x As Integer = 0

        Dim admin As String = "no"
        While x < ds_usuarios.Tables(0).Rows.Count
            If (USU_id_selec = ds_usuarios.Tables(0).Rows(x).Item("USU_id")) And ds_usuarios.Tables(0).Rows(x).Item("UT_desc") = "Administrador" Then
                While i < dataset_egresos.Tables(0).Rows.Count
                    If dataset_egresos.Tables(0).Rows(i).Item("Fecha") >= DT_fecha_desde.Text And dataset_egresos.Tables(0).Rows(i).Item("Fecha") <= DT_fecha_hasta.Text Then
                        table_filtrada.ImportRow(dataset_egresos.Tables(0).Rows(i))
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
            While i < dataset_egresos.Tables(0).Rows.Count
                If dataset_egresos.Tables(0).Rows(i).Item("Fecha") >= DT_fecha_desde.Text And dataset_egresos.Tables(0).Rows(i).Item("Fecha") <= DT_fecha_hasta.Text And dataset_egresos.Tables(0).Rows(i).Item("USU_id") = CB_usuarios.SelectedValue Then
                    table_filtrada.ImportRow(dataset_egresos.Tables(0).Rows(i))
                End If
                i = i + 1
            End While
        End If
        If table_filtrada.Rows.Count <> 0 Then

            table_filtrada.DefaultView.Sort = "[Fecha] ASC"
            DataGridView1.DataSource = table_filtrada.DefaultView.ToTable

        Else
            DataGridView1.DataSource = ""
        End If

        calcular_totales()

    End Sub

    Private Sub DT_fecha_desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_fecha_desde.ValueChanged
        BUSCAR_RANGO()
    End Sub

    Private Sub DT_fecha_hasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DT_fecha_hasta.ValueChanged
        BUSCAR_RANGO()
    End Sub

    Private Sub CB_usuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_usuarios.SelectedIndexChanged
        'BUSCAR_RANGO()
    End Sub

    Dim ds_usuarios As DataSet
    Private Sub obtener_usuarios()
        ds_usuarios = DAEgresos.Egresos_Usuario_obtener
        CB_usuarios.DataSource = ds_usuarios.Tables(0)
        CB_usuarios.DisplayMember = "ApellidoyNombre" '+ " " + "USU_nom"
        CB_usuarios.ValueMember = "USU_id"
    End Sub

    Private Sub BO_ape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_buscar.Click
        BUSCAR_RANGO()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell("C:\WINDOWS\system32\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Public Sub calcular_totales()
        Label_total.Text = "0,00"
        'DataG_listaTotal.Rows.Clear()
        'DataG_listaTotal.Rows.Add()
        'sumamos los subtotales con un ciclo
        Dim sumar As Decimal = "0,00"
        Dim ii As Integer = 0
        While ii < DataGridView1.Rows.Count
            sumar = sumar + DataGridView1.Rows(ii).Cells("MontoDataGridViewTextBoxColumn").Value
            ii = ii + 1
        End While
        sumar = Math.Round(sumar, 2)
        'DataG_listaTotal.Rows(0).Cells(0).Value = "TOTAL"
        Label_total.Text = (Math.Round(sumar, 2).ToString("N2"))
    End Sub



End Class