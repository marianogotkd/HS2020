Public Class Proveedor_alta
    Dim DAproveedor As New Datos.Proveedor
    Public proveedor_id As Integer = 0
    Public form_procedencia As String = "alta"
    Public apertura As String = "menu_alta" 'esta variable me sirve para saber desde donde lo abro, si lo abro a la "Alta" desde el menu...el boton cancelar...solo borra lo q se escribe en los textbox.
    Private Sub validar_guardar(ByRef valido As String)
        'valido esta inicializado en SI
        Select Case form_procedencia
            Case "alta"
                If tx_nombre.Text <> "" Then
                    'aqui voy a traer todos los proveedores
                    Dim ds_proveedor As DataSet = DAproveedor.Proveedor_obtener_todo()
                    If ds_proveedor.Tables(0).Rows.Count <> 0 Then
                        Dim i As Integer = 0
                        While i < ds_proveedor.Tables(0).Rows.Count
                            If tx_nombre.Text = ds_proveedor.Tables(0).Rows(i).Item("Prov_nombre") Then
                                valido = "NO" 'ya existe, es otro proveedor
                            End If
                            i = i + 1
                        End While
                        If valido = "NO" Then
                            MessageBox.Show("Error, ya existe el Proveedor. Modifique el nombre.", "Sistema de Gestión.")
                            ERROR_tx_nombre.Visible = True
                            tx_nombre.Focus()
                        End If
                    End If
                Else
                    valido = "NO"
                    MessageBox.Show("Complete la información.", "Sistema de Gestión.")
                    ERROR_tx_nombre.Visible = True
                    tx_nombre.Focus()
                End If

            Case "modificar"
                'If tx_codinterno.Text <> "" Then
                If tx_nombre.Text <> "" Then
                    'aqui voy a traer todos los proveedores
                    Dim ds_proveedor As DataSet = DAproveedor.Proveedor_obtener_todo()
                    If ds_proveedor.Tables(0).Rows.Count <> 0 Then
                        Dim i As Integer = 0
                        While i < ds_proveedor.Tables(0).Rows.Count
                            Dim proveedor As String = ds_proveedor.Tables(0).Rows(i).Item("Prov_nombre")
                            Dim proveedor_id_bd As Integer = ds_proveedor.Tables(0).Rows(i).Item("Prov_id")
                            If tx_nombre.Text = ds_proveedor.Tables(0).Rows(i).Item("Prov_nombre") And (proveedor_id <> ds_proveedor.Tables(0).Rows(i).Item("Prov_id")) Then
                                valido = "NO" 'ya existe, es otro proveedor
                            End If
                            i = i + 1
                        End While
                        If valido = "NO" Then
                            MessageBox.Show("Error, ya existe el Proveedor. Modifique el nombre.", "Sistema de Gestión.")
                            ERROR_tx_nombre.Visible = True
                            tx_nombre.Focus()
                        End If
                    End If
                Else
                    valido = "NO"
                    MessageBox.Show("Complete la información", "Sistema de Gestion.")
                    ERROR_tx_nombre.Visible = True
                    tx_nombre.Focus()
                End If
        End Select


        
        'Else

        'MessageBox.Show("Complete la información", "Sistema de Gestion.")
        'ERROR_tx_codinterno.Visible = True
        'tx_nombre.Focus()
        'End If

    End Sub
    Private Sub Alta()
        Dim valido As String = "SI"
        validar_guardar(valido)

        If valido = "SI" Then
            'aqui pregunto
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea agregar el nuevo Proveedor?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Dim buscar_proveedor As New DataSet
                buscar_proveedor = DAproveedor.Proveedor_buscar(tx_nombre.Text)
                If buscar_proveedor.Tables(0).Rows.Count = 0 Then
                    'si no existe guardo

                    DAproveedor.Proveedor_Alta(tx_nombre.Text, tx_responsable.Text, tx_direccion.Text, tx_telefono.Text, tx_celular.Text, tx_mail.Text, tx_obs.Text)

                    MessageBox.Show("El Proveedor fue agregado correctamente.", "Sistema de Gestión.")
                    ' Proveedor_modificar.actualizar_todo()
                    'aqui veo si cierro el form y abro modificar, o blanqueo todo y sigo agregando
                    If apertura = "menu_alta" Then
                        'borrar textbox y ocultar los botones de error
                        Limpiar_box_btn()
                    End If
                    If apertura = "formulario modificar" Then
                        Me.Close()
                        Proveedor_modificar.Close()
                        Proveedor_modificar.Show()
                    End If
                Else
                    MessageBox.Show("Ya se encuentra agregado, corrija la información.", "Sistema de Gestión.")
                    ERROR_tx_nombre.Visible = True
                    tx_nombre.Focus()
                End If
            End If
        End If
        If form_inicio = "proveedores_x_producto" Then
            Proveedores_X_Producto.Cargarcombo_proveedor()
            Me.Close()
        End If
    End Sub
    Private Sub Modificar()
        Dim valido As String = "SI"
        validar_guardar(valido)
        If valido = "SI" Then
            'aqui pregunto
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea modificar los datos del Proveedor?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                'Dim buscar_proveedor As New DataSet
                'buscar_proveedor = DAproveedor.Proveedor_buscar(tx_nombre.Text)
                'If buscar_proveedor.Tables(0).Rows.Count <> 0 Then 'si lo encuentro edito
                'si existe guardo
                'Dim prov_cod As String = DataGrid_proveedor.CurrentRow.Cells(1).Value
                'Dim prov_nombre As String = DataGrid_proveedor.CurrentRow.Cells(2).Value
                DAproveedor.Proveedor_modificar(proveedor_id, tx_nombre.Text, tx_responsable.Text, tx_direccion.Text, tx_telefono.Text, tx_celular.Text, tx_mail.Text, tx_obs.Text)
                MessageBox.Show("El proveedor se modificó correctamente.", "Sistema de Gestion.")
                ' Proveedor_modificar.actualizar_todo()
                Me.Close()
                Proveedor_modificar.Close()
                Proveedor_modificar.Show()
                'End If
            End If
        End If
    End Sub

    Private Sub Limpiar_box_btn()
        'tx_codinterno.Clear()
        tx_nombre.Clear()
        tx_responsable.Clear()
        tx_direccion.Clear()
        tx_telefono.Clear()
        tx_celular.Clear()
        tx_mail.Clear()
        tx_obs.Clear()
        'ERROR_tx_codinterno.Visible = False
        ERROR_tx_nombre.Visible = False
        'Me.tx_codinterno.Focus()
    End Sub

    Public form_inicio As String = ""
    Public Sub Origen_alta(ByRef inicio As String)
        form_inicio = inicio
    End Sub

    Private Sub Proveedor_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If form_procedencia = "modificar" Then
            recuperar_datos_proveedor()
        End If
    End Sub

    Public Sub recuperar_datos_proveedor()
        'PESTAÑA proveedor//////////////////////////////////////////////////////////////////////////////////
        Dim ds_proveedor As New DataSet
        ds_proveedor = DAproveedor.Proveedor_obtenerDatos(proveedor_id, tx_nombre.Text)

        'cargo en los textbox los datos recuperados
        'NOMBRE
        tx_nombre.Text = ds_proveedor.Tables(0).Rows(0).Item("Prov_nombre")
        'tx_nombre.ReadOnly = True
        'responsable
        tx_responsable.Text = ds_proveedor.Tables(0).Rows(0).Item(3)
        'direccion
        tx_direccion.Text = ds_proveedor.Tables(0).Rows(0).Item(4)
        'telefono
        tx_telefono.Text = ds_proveedor.Tables(0).Rows(0).Item(5)
        'celular
        tx_celular.Text = ds_proveedor.Tables(0).Rows(0).Item(6)
        'correo electronico
        tx_mail.Text = ds_proveedor.Tables(0).Rows(0).Item(7)
        'observaciones
        tx_obs.Text = ds_proveedor.Tables(0).Rows(0).Item(8)

    End Sub

#Region "focos en textbox y cambia de color"
    Private Sub tx_nombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_nombre.GotFocus
        tx_nombre.SelectAll()
        tx_nombre.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_nombre.Visible = True
    End Sub

    Private Sub tx_nombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_nombre.LostFocus
        tx_nombre.BackColor = Color.White
        'RectangleShape_nombre.Visible = False
    End Sub

    Private Sub tx_responsable_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_responsable.GotFocus
        tx_responsable.SelectAll()
        tx_responsable.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_responsable.Visible = True
    End Sub

    Private Sub tx_responsable_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_responsable.LostFocus
        tx_responsable.BackColor = Color.White
        'RectangleShape_responsable.Visible = False
    End Sub

    Private Sub tx_direccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_direccion.GotFocus
        tx_direccion.SelectAll()
        tx_direccion.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_direccion.Visible = True
    End Sub

    Private Sub tx_direccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_direccion.LostFocus
        tx_direccion.BackColor = Color.White
        'RectangleShape_direccion.Visible = False
    End Sub

    Private Sub tx_telefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_telefono.GotFocus
        tx_telefono.SelectAll()
        tx_telefono.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_telefono.Visible = True
    End Sub

    Private Sub tx_telefono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_telefono.LostFocus
        tx_telefono.BackColor = Color.White
        'RectangleShape_telefono.Visible = False
    End Sub

    Private Sub tx_celular_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_celular.GotFocus
        tx_celular.SelectAll()
        tx_celular.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_celular.Visible = True
    End Sub

    Private Sub tx_celular_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_celular.LostFocus
        tx_celular.BackColor = Color.White
        'RectangleShape_celular.Visible = False
    End Sub

    Private Sub tx_mail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_mail.GotFocus
        tx_mail.SelectAll()
        tx_mail.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_email.Visible = True
    End Sub

    Private Sub tx_mail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_mail.LostFocus
        tx_mail.BackColor = Color.White
        'RectangleShape_email.Visible = False
    End Sub

    Private Sub tx_obs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_obs.GotFocus
        tx_obs.SelectAll()
        tx_obs.BackColor = Color.FromArgb(255, 255, 192)
        'RectangleShape_observaciones.Visible = True
    End Sub

    Private Sub tx_obs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_obs.LostFocus
        tx_obs.BackColor = Color.White
        'RectangleShape_observaciones.Visible = False
    End Sub
#End Region

    
    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If form_procedencia = "alta" Then
            Alta()
        End If
        If form_procedencia = "modificar" Then
            Modificar()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        If apertura = "menu_alta" Then
            Limpiar_box_btn()
        End If
        If apertura = "formulario modificar" Then
            Me.Close()
            Proveedor_modificar.Close()
            Proveedor_modificar.Show()
        End If
    End Sub
End Class