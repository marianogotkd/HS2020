Public Class Egresos_Ingresos
    Dim DAcaja As New Datos.Caja
    Dim DAsucursal As New Datos.Sucursal
    Private Sub Egresos_Ingresos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar_detalle()
        Sucursales_Obtener()
    End Sub

    Private Sub Sucursales_Obtener()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "sucursal_nombre"
        ComboBox1.ValueMember = "sucursal_id"
    End Sub


    'cargar datos en grilla
    Dim ds_caja As DataSet
    Public Sub cargar_detalle()
        Dim sucursal_id As Integer = Inicio.suc_id 'yo se q esta sucursal tiene la caja abierta...x la validacion del form del q vengo
        Dim usuario_id As Integer = Inicio.USU_id
        ds_caja = DAcaja.Caja_obtener_detalle(usuario_id, sucursal_id, US_administrador.TurnoUsuario_id)

        If ds_caja.Tables(0).Rows.Count <> 0 Then
            'agrego info a los label
            Label_sucursal.Text = "Sucursal: " + ds_caja.Tables(0).Rows(0).Item("sucursal")
            Label_apertura.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_apertura")
            Label_usuario.Text = ds_caja.Tables(0).Rows(0).Item("Usuario")
            ds_caja.Tables(2).Merge(ds_caja.Tables(3))
            DG_caja.DataSource = ds_caja.Tables(2)
        Else
            BO_agregar.Enabled = False
            '            BO_modificar.Enabled = False
            btn_eliminar_seleccion.Enabled = False

            GroupBox1.Enabled = False
            Label_sucursal.ForeColor = Color.Red
            Label_sucursal.Text = "NO SE ABRIO CAJA PARA LA SUCURSAL ACTUAL."

            MessageBox.Show("No hay una caja abierta para esta sucursal. Consulte al Administrador.", "Sistema de Gestión.")
        End If





    End Sub

    Private Sub Bo_busqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_busqueda.Click
        Dim ds_egresos_ingresos As DataSet = DAcaja.Caja_obtener_ingresos_egresos(ComboBox1.SelectedValue)
        DataGridView1.DataSource = ""
        ds_egresos_ingresos.Tables(0).Merge(ds_egresos_ingresos.Tables(1))
        DataGridView1.DataSource = ds_egresos_ingresos.Tables(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton_si.Checked = True Then
            Dim ds_a As DataSet = DAcaja.Caja_obtener_ingresos_egresos_x_fecha(DT_FECHA_desde.Value, DT_FECHA_hasta.Value, ComboBox1.SelectedValue)
            If ds_a.Tables(0).Rows.Count = 0 And ds_a.Tables(1).Rows.Count = 0 Then
                MessageBox.Show("Error, no hay registros para el rango de fecha.", "Sistema de Gestión.")
            Else
                DataGridView1.DataSource = ""
                ds_a.Tables(0).Merge(ds_a.Tables(1))
                DataGridView1.DataSource = ds_a.Tables(0)
            End If
        Else
            MessageBox.Show("Error, debe activar el filtro!.", "Sistema de Gestión.")
        End If

        
    End Sub

    Private Sub btn_eliminar_seleccion_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_seleccion.Click
        ''aqui elemino el producto seleccionado de la tabla "DG_ListaProducto" y recalculo el valor q va a ir en la grilla "DG_TOTALES"
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        If DG_caja.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DG_caja.Rows.Count
                If DG_caja.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    If pregunta = "no" Then
                        If MsgBox("Esta seguro que quiere borrar la informacion del item seleccionado?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                            pregunta = "si"
                        Else
                            'aqui corto el ciclo, ya que se cancelo la eliminacion
                            i = DG_caja.Rows.Count
                        End If
                    End If
                    If pregunta = "si" Then
                        'llamo a la rutina de la capa de datos, para actualizar la bd
                        Dim CAJAdetalle_id As Integer = CInt(DG_caja.Rows(i).Cells("CAJAdetalleidDataGridViewTextBoxColumn").Value)
                        If DG_caja.Rows(i).Cells("CajaTipoMovdescripcionDataGridViewTextBoxColumn").Value = "Ingreso" Then
                            Dim ingreso As Decimal = CDec(DG_caja.Rows(i).Cells("CAJAdetalleingresoDataGridViewTextBoxColumn").Value)
                            DAcaja.Caja_ingreso_eliminar(Inicio.USU_id, ingreso, CAJAdetalle_id, US_administrador.Terminal_id)
                        Else
                            Dim egreso As Decimal = CDec(DG_caja.Rows(i).Cells("CAJAdetalleegresoDataGridViewTextBoxColumn").Value)
                            DAcaja.Caja_egreso_eliminar(Inicio.USU_id, egreso, CAJAdetalle_id, US_administrador.Terminal_id)
                        End If
                        'primero guardo el nro de item q contiene
                        Dim item As Decimal = DG_caja.CurrentRow.Index
                        DG_caja.Rows.RemoveAt(i)
                        i = 0 'lo reinicio, x q al quitar un ite, se reordenan los indices

                        'If item <= Venta_Caja_ds.Tables("Producto_agregado").Rows.Count Then 'esta validacion es x q el ds tiene menos celdas 
                        '    Venta_Caja_ds.Tables("Producto_agregado").Rows(item).Delete()
                        'End If

                        'DataGridView1.DataSource = Venta_Caja_ds.Tables("Producto_agregado")
                        'cuando borro reordeno los item..o sea el nro q esta mas a la izquierda
                        'Dim a As Integer = 0
                        'While a < DG_caja.Rows.Count
                        '    If DG_caja.Rows(a).Cells(1).Value <> 0 Then
                        '        DG_caja.Rows(a).Cells(0).Value = a + 1
                        '    End If

                        '    a = a + 1
                        'End While
                        'calcular_totales()
                        'aplicar_iva()
                    End If
                Else
                    i = i + 1
                End If
            End While
            'ahora si me queda la grilla vacia..agrero un row para q pueda escribir
            'If DataGridView1.Rows.Count = 0 Then
            '    DataGridView1.Rows.Add()
            '    DataGridView1.Focus()
            '    DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True
            'End If
        End If
    End Sub

    Private Sub BO_agregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_agregar.Click
        Egresos_Ingresos_alta.Close()
        Egresos_Ingresos_alta.Show()
    End Sub
End Class