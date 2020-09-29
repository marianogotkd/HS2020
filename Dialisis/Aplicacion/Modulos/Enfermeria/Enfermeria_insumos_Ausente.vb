Public Class Enfermeria_insumos_Ausente
    Dim DAsucursal As New Datos.Sucursal
    Public sesiones_id As Integer
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Dim DAprod As New Datos.Producto
    Dim DAlote As New Datos.Lote
    Dim ds_PROD As DataSet

    Private Sub Enfermeria_insumos_Ausente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'es lo mismo que baja de mercaderia
        GM_Baja_Producto.Close() 'hay q tener la precaucion de cerrarlo antes, ya que este modulo se lo usa para diversos fines
        GM_Baja_Producto.sucursal_id = 3 ' el ID 3 es La Sucursal Sala de Dialisis
        GM_Baja_Producto.form_procedencia = "Gestion_Mercaderia"
        GM_Baja_Producto.Text = "Enfermeria"
        GM_Baja_Producto.tipo_movimiento = "consumir Ausente"
        GM_Baja_Producto.Show()
    End Sub



    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        If DataGridView1.Rows.Count <> 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea quitar todos los productos del listado?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Mov_DS.Tables("Mov_Enf").Rows.Clear() 'no uso el datagridview rows clear...x q me tira error x el dataset q esta asociado
                'DataGridView1.Rows.clear 
                'DataGridView1.Rows.Add()
                'DataGridView1.Focus()
                'DataGridView1.Rows(0).Cells("prod_codinterno").Selected = True
            End If
        Else
            MessageBox.Show("No hay productos en el listado.", "Sistema de Gestión.")
        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim lote_id As Integer
        Dim concepto = "Consumo Austente"
        Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta_Enfermeria(concepto, Today, Inicio.USU_id, 3, sesiones_id)
        ''''''''''''''''''''''''''''''''''''''''''''''''

        Dim MovMer_id As Integer = ds_movid.Tables(0).Rows(0).Item(0)
        Dim i As Integer = 0
        While i < Mov_DS.Tables("Mov_Enf").Rows.Count
            '''''Actualizacion de Stock''''''''''''''''''''''''
            Dim Ds_Suc As DataSet
            'Dim Origen As Integer
            'Dim Destino As Integer
            Dim Mov As Decimal
            'Dim j As Integer = 0
            'While i < Mov_DS.Tables("Mov").Rows.Count
            ds_PROD = DAprod.Producto_buscarcod(Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cod_prod"))
            Dim prod_id = ds_PROD.Tables(0).Rows(0).Item("prod_id")
            Ds_Suc = DAsucursal.Sucursal_obtener_producto(prod_id, 3, 3) ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano


            'If cb_Movimiento.SelectedItem = "Baja de Mercaderia" Then
            'Calculo Stock''''''''
            Mov = Ds_Suc.Tables(0).Rows(0).Item("Stock_Origen") - Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad")
            '''''''
            ''''''''''
            'Actualizo stock''''' no quito el registro del producto en la sucursal, en realidad lo que hago es actualizar su cantidad a 0. OJO No tiene que hacerse negativo.
            DAprod.Producto_x_sucursal_Actualizar_Stock(prod_id, 3, Mov) 'mov envia la diferencia entre el stock en la sucursal y la cant a quitar.
            ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano


            '''''''''''
            '////////////////choco: 08-07-2020///////////////////////////////////
            'actualizo la cant en el lote asociado a un producto de una sucursal.
            Dim lote_nro As String = Mov_DS.Tables("Mov_Enf").Rows(i).Item("Lote")
            Dim cant_a_quitar As Decimal = CDec(Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad"))
            Dim dslote As DataSet = DAlote.Producto_x_sucursal_lote_actualizar_resto(lote_nro, prod_id, 3, cant_a_quitar, Mov_DS.Tables("Mov_Enf").Rows(i).Item("Prov_id"))  ' el ID 3 es La Sucursal Sala de Dialisis 7/9/20 Mariano
            lote_id = dslote.Tables(0).Rows(0).Item("lote_id")
            'End If
            ''''''''''''''''''''''''''''''''''''''
            '''''' Alta Tabla Detalle'''''' de movimiento claro está
            'alta en tabla mercaderia_detalle_alta
            DAMovintoMer.Consumo_mercaderia_Detalle_alta(Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cantidad"), MovMer_id, Mov_DS.Tables("Mov_Enf").Rows(i).Item("Cod_prod"), lote_id)
            i = i + 1
        End While
        '''''''''''''''''''''''''''''''''''''''''''
        MessageBox.Show("Operacion realizada con Exito.", "Sistema de Gestión.")
        Sesion_pacientes.recuperar_pacientes_fecha_del_dia(Sesion_pacientes.fecha.Value)
        Me.Close()



    End Sub
End Class