Public Class Enfermeria_insumos_Ausente
    Dim DAsucursal As New Datos.Sucursal
    Public sesiones_id As Integer
    Dim DAMovintoMer As New Datos.Gestion_Mercaderia
    Dim DAprod As New Datos.Producto
    Dim DAlote As New Datos.Lote
    Dim ds_PROD As DataSet
    Dim FiltroDS As DataSet
    Dim DaEnfermeria As New Datos.Enfermeria
    Public PAC_id As Integer
    Public Filtro_var
    Public tipo_operacion As String = "alta"
    Dim DAsesiones As New Datos.Sesiones
    Public fecha_registrar
    Private Sub Enfermeria_insumos_Ausente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'recupero info del filtro
        Obtener_Filtro()


    End Sub

    Private Sub Obtener_Filtro()
        FiltroDS = DaEnfermeria.Filtro_Obtener_X_PAC(PAC_id)
        If FiltroDS.Tables(0).Rows.Count <> 0 Then
            Filtro_var = "Update"

            If tipo_operacion = "modificar presente" Then
                tb_CantRe.Text = FiltroDS.Tables(0).Rows(0).Item("Filtro_cant_reuso")
            Else
                tb_CantRe.Text = FiltroDS.Tables(0).Rows(0).Item("Filtro_cant_reuso") + 1
            End If

            Dim sesionDS As DataSet = DAsesiones.Dialisis_Obtener_Filtro_X_Pac(PAC_id)
            tb_Filtro.Text = sesionDS.Tables(0).Rows(0).Item("Dialisis_Filtro")
            tb_Filtro.Enabled = False


        Else
            tb_CantRe.Text = 0
            Filtro_var = "Nuevo"
        End If


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

    Public filtro_guardado As String = "no"
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim continuar_consumo As String = "no"
        'aqui pregunto si quiero registrar el uso del filtro
        If filtro_guardado = "no" Then
            Dim result2 As Integer = MessageBox.Show("¿Desea registrar el Filtro utilizado?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result2 = DialogResult.Yes Then
                If tb_Filtro.Text <> "" Then
                    ''''' filtros y rehusos''''''''''''''24/9/20 MAriano'''''
                    If Filtro_var = "Nuevo" Then
                        DaEnfermeria.Filtro_Nuevo(PAC_id, fecha_registrar, tb_CantRe.Text, sesiones_id, tb_Filtro.Text)
                    End If
                    If Filtro_var = "Update" Then
                        DaEnfermeria.Filtro_modificar_Cant(FiltroDS.Tables(0).Rows(0).Item("Filtro_id"), tb_CantRe.Text)
                    End If
                    '''''''''''''''''''''''''''''''
                    continuar_consumo = "si"
                    filtro_guardado = "si"
                Else
                    MessageBox.Show("Error, Debe cargar un filtro.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                continuar_consumo = "si"
            End If
        Else
            'como ya esta guardado, seguimos con los insumos
            continuar_consumo = "si"
        End If

        If continuar_consumo = "si" Then
            If DataGridView1.Rows.Count <> 0 Then
                Dim result3 As Integer = MessageBox.Show("¿Desea Consumir los insumos listados?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result3 = DialogResult.Yes Then
                    If DataGridView1.Rows.Count <> 0 Then
                        Dim lote_id As Integer
                        Dim concepto = "Consumo Ausente"
                        Dim ds_movid As DataSet = DAMovintoMer.Consumo_Mercaderia_alta_Enfermeria(concepto, fecha_registrar, Inicio.USU_id, 3, sesiones_id)
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
                        Sesion_pacientes.recuperar_pacientes_fecha_del_dia(fecha_registrar)
                        Me.Close()
                    Else
                        MessageBox.Show("No hay insumos agregados a la lista para consumir.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                Dim result As Integer = MessageBox.Show("¿Esta seguro que desea Guardar sin Consumo de Insumos?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    MessageBox.Show("La información se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else

                End If
            End If
        End If
    End Sub

    Private Sub btn_cambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cambio.Click
        tb_CantRe.Text = 0
        Filtro_var = "Nuevo"
        tb_Filtro.Enabled = True
        tb_Filtro.Focus()
        tb_Filtro.SelectAll()
    End Sub
End Class