Public Class Mesa_asignar
    Dim DAcliente As New Datos.Cliente
    Dim DAlista As New Datos.Lista
    Dim DAventa As New Datos.Venta

    Public procedencia_mesasgestion As String = "no" 'cuando diga si es x q tengo q asignar una mesa a un turno, q recien lo hago correr
    Public idclie_procendencia_mesasgestion As Integer = 0 'cuando tenga otro valor es x q tengo q asignat una mesa
    Public PAGADO_procedencia_mesasgestion As Decimal = CDec(0)
    Public SALDO_procedencia_mesasgestion As Decimal = CDec(0)
    Public TURNO_id_procedencia_mesasgestion As Integer = 0


#Region "Metodo para asignar mesa a turno"

    Public Sub Bloquear_consumidor_selecc_cliente()

        If procedencia_mesasgestion = "si" Then
            GroupBox5.Enabled = False
            RB_Cliente.Checked = True
            RB_Consumidor.Checked = False

            'selecciono de la grilla de clientes, el clie cuyo id corresponda
            Dim i As Integer = 0
            While i < DG_clientes.Rows.Count
                If DG_clientes.Rows(i).Cells("CLIidDataGridViewTextBoxColumn").Value = idclie_procendencia_mesasgestion Then
                    Txt_buscar_clie.Text = DG_clientes.Rows(i).Cells("CLIapeDataGridViewTextBoxColumn").Value
                    DG_clientes.Rows(i).Cells(1).Value = True
                    DG_clientes.Rows(i).Selected = True
                    i = DG_clientes.Rows.Count
                End If
                i = i + 1
            End While

        End If

    End Sub



#End Region







#Region "metodos"
    Dim ds_clie As DataSet
    'recupero todos los clientes
    Public Sub Obtener_Clientes()
        ds_clie = DAcliente.Cliente_obtenertodo()
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            Venta_Caja_ds.Tables("Cliente").Rows.Clear()
            Venta_Caja_ds.Tables("Cliente").Merge(ds_clie.Tables(0))

            ' DG_clientes.DataSource = Venta_Caja_ds.Tables("Cliente") 'esta instruccion ya no uso. Ahora al asociar la tabla Cliente desde el bindingsource, no debo cambiarla por codigo desde el datasource.
        End If
    End Sub
    Private Sub Obtener_combo()
        Dim ds_listas As DataSet = DAlista.Lista_Regular_obtener()
        'Cargar Proveedor
        CB_lista.DataSource = ds_listas.Tables(0)
        CB_lista.DisplayMember = "LISTA_nom"
        CB_lista.ValueMember = "LISTA_id"
    End Sub
    Public Sub Filtrar_datatable(ByVal parametro As String)
        If ds_clie.Tables.Count <> 0 Then
            ''uso ds_CLIE que trae los productos buscados en sql
            Dim table_filtrada As New DataTable
            table_filtrada.Columns.Add("CLI_id")
            table_filtrada.Columns.Add("CLI_ape")
            table_filtrada.Columns.Add("CLI_nom")
            table_filtrada.Columns.Add("CLI_dni")
            table_filtrada.Columns.Add("CLI_fnac")
            table_filtrada.Columns.Add("CLI_tel")
            table_filtrada.Columns.Add("CLI_mail")
            table_filtrada.Columns.Add("CLI_Fan")

            table_filtrada.Rows.Clear()
            DG_clientes.DataSource = Nothing
            Dim table As DataTable = ds_clie.Tables(0)
            Dim apellido As String = parametro
            Dim a = 0
            While a < table.Rows.Count
                Dim fila As String = table.Rows(a).Item("CLI_Fan")
                fila = fila.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter As Integer = fila.IndexOf(parametro)
                If primercaracter <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If
                Dim fila2 As String = table.Rows(a).Item("CLI_dni")
                fila2 = fila2.ToLower()
                parametro = parametro.ToLower()
                Dim primercaracter2 As Integer = fila2.IndexOf(parametro)
                If primercaracter2 <> -1 Then
                    table_filtrada.ImportRow(table.Rows(a))
                End If

                'Dim fila3 As String = table.Rows(a).Item("CLI_nom")
                'fila3 = fila3.ToLower()
                'parametro = parametro.ToLower()
                'Dim primercaracter3 As Integer = fila3.IndexOf(parametro)
                'If primercaracter3 <> -1 Then
                '    table_filtrada.ImportRow(table.Rows(a))
                'End If


                'If apellido = table.Rows(a).Item("CLI_ape") Then
                '    table_filtrada.ImportRow(table.Rows(a))
                'End If
                a = a + 1
            End While
            If table_filtrada.Rows.Count <> 0 Then
                DG_clientes.DataSource = table_filtrada
            Else
                DG_clientes.DataSource = ds_clie.Tables(0)
            End If
        End If
    End Sub
#End Region
    Public form_procedencia As String

    Private Sub Mesa_asignar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAceptar()

        End If
    End Sub

    Private Sub Mesa_asignar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_Clientes()
        Me.Focus()
        BO_Aceptar.Focus()


    End Sub

    Private Sub RB_Consumidor_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Consumidor.CheckedChanged
        If RB_Consumidor.Checked = True Then
            GroupBox4.Enabled = False
            DG_clientes.Enabled = False
            Dim i = 0
            While i < DG_clientes.Rows.Count
                DG_clientes.Rows(i).Cells(1).Value = False
                i = i + 1
            End While
        End If
    End Sub

    Private Sub RB_Cliente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Cliente.CheckedChanged
        If RB_Cliente.Checked = True Then
            DG_clientes.Enabled = True
            GroupBox4.Enabled = True
            Txt_buscar_clie.Focus()
            Txt_buscar_clie.SelectAll()
        End If

    End Sub

    Private Sub RB_No_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_No.CheckedChanged
        If RB_No.Checked = True Then
            CB_lista.DataSource = Nothing
            CB_lista.Items.Add("Defecto")
            CB_lista.SelectedIndex = 0
        End If
    End Sub

    Private Sub RB_Si_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Si.CheckedChanged
        If RB_Si.Checked = True Then
            Call Obtener_combo()
        End If
    End Sub

    Private Sub Txt_buscar_clie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_buscar_clie.KeyPress
        ''If e.KeyChar = ChrW(Keys.Enter) Then 'aqui se bloque el ingresodo de letras
        'DG_clientes.DataSource = Nothing
        'If Txt_buscar_clie.Text <> "" Then
        '    Filtrar_datatable(Me.Txt_buscar_clie.Text)
        'Else
        '    DG_clientes.DataSource = ds_clie.Tables(0)
        'End If
        ''End If

        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "CLI_Fan", Txt_buscar_clie.Text) 'esto para campos strings, FUNCIONA PERFECTO
        ClienteBindingSource.Filter = Filtro


    End Sub

    Public Sub Seleccionar_cliente_nuevo(ByVal apellido As String, ByVal nombre As String)

        Dim i As Integer = 0
        While i < DG_clientes.Rows.Count
            If DG_clientes.Rows(i).Cells(3).Value = apellido And DG_clientes.Rows(i).Cells(4).Value = nombre Then
                DG_clientes.Rows(i).Selected = True
                i = DG_clientes.Rows.Count
            End If
            i = i + 1
        End While


    End Sub

    Private Sub DG_clientes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_clientes.CellClick
        'If e.ColumnIndex <> 1 Then Exit Sub
        ''primero quito la seleccion de los demas
        'Dim i = 0
        'While i < DG_clientes.Rows.Count
        '    DG_clientes.Rows(i).Cells(1).Value = False
        '    i = i + 1
        'End While
        'If DG_clientes.Rows(e.RowIndex).Cells(1).Value = True Then
        '    DG_clientes.Rows(e.RowIndex).Cells(1).Value = False
        'Else
        '    DG_clientes.Rows(e.RowIndex).Cells(1).Value = True
        'End If
    End Sub

    Public MESA_id As Integer = 0
    Public Sector_id As Integer = 0
    Private Sub BtnAceptar()

        If MsgBox("Esta Seguro que quiere asignar la mesa" & Label_mesa.Text & "?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            Dim usuario_id As String
            usuario_id = Inicio.USU_id 'obtengo del formulario inicio el id del usuario actual, logueado
            Dim tipo_vta As String = ""
            Dim cliente_id As Integer
            Dim nombre_cliente As String = ""
            If RB_Consumidor.Checked = True Then
                tipo_vta = "Consumidor Final"
                cliente_id = 0
            Else
                tipo_vta = "Cliente"
                If DG_clientes.CurrentRow.Selected = True Then
                    cliente_id = DG_clientes.CurrentRow.Cells("CLI_id_columna").Value 'modif 14-12-2017
                    nombre_cliente = DG_clientes.CurrentRow.Cells("CLI_Fan_columna").Value 'modif 14-12-2017

                End If



            End If
            'alta de venta
            Dim ds_Venta As DataSet = DAventa.VentaProducto_alta_mesa(CDec("00,00"), CDec("00,00"), "Ocupado",
                                                Now,
                                                usuario_id,
                                                tipo_vta,
                                                cliente_id)

            Dim ventaprod_id As Integer = CType(ds_Venta.Tables(0).Rows(0).Item("ventaprod_id"), String)
            'actualizo estado de mesa, y relaciono con venta
            'DAventa.MESAS_modificar(DataGridView1.CurrentRow.Cells("MESAidDataGridViewTextBoxColumn").Value, ventaprod_id, "Ocupado")
            DAventa.MESAS_modificar(MESA_id, Label_mesa.Text, "Ocupado", "Si", ventaprod_id)
            If RB_No.Checked = False Then
                DAventa.VentaConfig_alta(ventaprod_id, CB_lista.SelectedValue)
            End If

            'Mesas_gestion_2_new.Deshabilitar_mesas()
            Mesas_gestion_2_new.recuperar_mesas()
            Mesas_gestion_2_new.Habilitar_asignacion_pendiente(form_procedencia)




            If form_procedencia = "Mesas_gestion_2_new" Then

                Asignar_mesas(Sector_id, Label_mesa.Text) 'aqui ejecuto esta rutina ya q se pierde el valor para hacer la asig pendiente


            End If


            'MessageBox.Show("La mesa se asigno correctamente", "Sistema de Gestión La Santa Fe")
            'If MsgBox("La mesa se asigno correctamente. ¿Quiere cargar productos?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
            'aqui va la llamada al form de carga de productos.

            Mesa_cargar.Show()
            Mesa_cargar.Ventaprod_id = ventaprod_id
            Mesa_cargar.Label_sector.Text = Label_sector.Text
            Mesa_cargar.Label_mesa.Text = Label_mesa.Text
            Mesa_cargar.pago_parcial = CDec(0)
            Mesa_cargar.cliente_id = cliente_id
            Mesa_cargar.tipo_vta = tipo_vta
            Mesa_cargar.mesa_id = MESA_id
            Mesa_cargar.sector_id = Sector_id
            Mesa_cargar.form_procedencia = form_procedencia
            Mesa_cargar.Abrir_mesa()

            If procedencia_mesasgestion = "si" Then
                Mesa_cargar.PAGADO_procedencia_mesa_asignar = PAGADO_procedencia_mesasgestion
                Mesa_cargar.SALDO_procedencia_mesa_asignar = SALDO_procedencia_mesasgestion
                Mesa_cargar.TURNO_id_procedencia_mesa_asignar = TURNO_id_procedencia_mesasgestion
                Mesa_cargar.Cargar_turno()
                procedencia_mesasgestion = "no"
                PAGADO_procedencia_mesasgestion = CDec(0)
                SALDO_procedencia_mesasgestion = CDec(0)
            End If



            If RB_Consumidor.Checked = True Then
                Mesa_cargar.Text = "Cargar productos en mesa - Cliente: Consumidor Final"
            Else
                Mesa_cargar.Text = "Cargar productos en mesa - Cliente:" + " " + nombre_cliente
            End If

            'If Me.RB_No.Checked = True Then
            '    Mesa_cargar.RB_No = True
            'Else
            '    Mesa_cargar.RB_No = False
            'End If
            'If Me.RB_Si.Checked = True Then
            '    Mesa_cargar.RB_Si = True
            '    Mesa_cargar.CB_lista = CB_lista.SelectedValue
            'Else
            '    Mesa_cargar.RB_Si = False
            'End If





            Me.Close()




            'kashkdjhkajsdhkajshdkuwhkjashdkuwjashd

        End If
    End Sub

    Private Sub BO_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Aceptar.Click
        BtnAceptar()


    End Sub


    Private Sub Asignar_mesas(ByVal sector_id, ByVal mesa_nombre) 'esta rutina se ejecuta cuando el form de procedencia es: mesas_consulta_getion
        Dim esta = "no"
        If sector_id = "1" Then
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_1.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_1.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_1, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_2.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_2.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_2, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_3.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_3.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_3, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_4.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_4.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_4, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_5.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_5.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_5, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_6.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_6.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_6, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_7.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_7.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_7, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_8.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_8.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_8, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_9.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_9.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_9, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_10.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_10.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_10, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_11.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_11.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_11, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_12.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_12.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_12, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_13.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_13.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_13, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_14.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_14.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_14, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_15.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_15.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_15, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec1_Mesa_16.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec1_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec1_Mesa_16.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec1_Mesa_16, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If


        End If

        If sector_id = "2" Then
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_1.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_1.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_1, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_2.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_2.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_2, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_3.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_3.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_3, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_4.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_4.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_4, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_5.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_5.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_5, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_6.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_6.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_6, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_7.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_7.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_7, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_8.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_8.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_8, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_9.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_9.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_9, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_10.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_10.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_10, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_11.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_11.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_11, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_12.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_12.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_12, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_13.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_13.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_13, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_14.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_14.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_14, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_15.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_15.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_15, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec2_Mesa_16.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec2_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec2_Mesa_16.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec2_Mesa_16, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If



        End If


        If sector_id = "3" Then
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_1.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_1.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_1, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_2.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_2.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_2, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_3.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_3.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_3, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_4.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_4.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_4, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_5.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_5.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_5, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_6.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_6.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_6, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_7.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_7.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_7, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_8.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_8.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_8, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_9.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_9.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_9, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_10.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_10.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_10, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_11.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_11.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_11, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_12.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_12.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_12, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_13.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_13.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_13, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_14.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_14.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_14, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_15.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_15.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_15, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec3_Mesa_16.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec3_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec3_Mesa_16.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec3_Mesa_16, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If

        End If


        If sector_id = "4" Then
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_1.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_1.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_1.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_1, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_2.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_2.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_2.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_2, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_3.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_3.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_3.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_3, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_4.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_4.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_4.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_4, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_5.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_5.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_5.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_5, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_6.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_6.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_6.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_6, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_7.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_7.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_7.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_7, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_8.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_8.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_8.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_8, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_9.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_9.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_9.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_9, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_10.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_10.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_10.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_10, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_11.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_11.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_11.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_11, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_12.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_12.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_12.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_12, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_13.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_13.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_13.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_13, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_14.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_14.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_14.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_14, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_15.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_15.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_15.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_15, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If
            If esta = "no" And Mesas_gestion_2_new.Sec4_Mesa_16.BackColor = Color.ForestGreen Then
                Dim nro As Integer = 1
                While nro <= 16
                    If Mesas_gestion_2_new.Sec4_Mesa_16.Text = mesa_nombre Then
                        Mesas_gestion_2_new.Sec4_Mesa_16.BackColor = Color.IndianRed
                        Mesas_gestion_2_new.ToolTip1.SetToolTip(Mesas_gestion_2_new.Sec4_Mesa_16, "Mesa ocupada")
                        esta = "si"
                        nro = 17
                    End If
                    nro = nro + 1
                End While
            End If

        End If
    End Sub

    Private Sub BO_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cancelar.Click
        Me.Close()
    End Sub

    Private Sub BO_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Nuevo.Click
        Cliente_alta_New.FormProc = "Mesas_Asignar"
        Cliente_alta_New.Show()


    End Sub

    Private Sub BO_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Modificar.Click

    End Sub

    
   
    
End Class