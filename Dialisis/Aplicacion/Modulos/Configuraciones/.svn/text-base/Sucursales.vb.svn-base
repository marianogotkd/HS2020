Public Class Sucursales
    Dim DAsucursal As New Datos.Sucursal
    Dim DAcliente As New Datos.Cliente
    Private Sub Sucursales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_sucursales()
        Obtener_provincias()
    End Sub


    Private Sub Btn_nuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_nuevo.Click
        '1) consultar la bd y asignar un id nuevo a la sucursal q voy a crear
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        If ds.Tables(0).Rows.Count <> 0 Then
            Dim i As Integer = ds.Tables(0).Rows.Count - 1
            txt_ID.Text = ds.Tables(0).Rows(i).Item("sucursal_id") + 1
        Else
            txt_ID.Text = 1
        End If

        '2) poner el foco en el txt del nombre de sucursal
        txt_suc_nombre.Focus()

    End Sub

    Private Sub txt_suc_nombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_suc_nombre.GotFocus
        txt_suc_nombre.SelectAll()
        txt_suc_nombre.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub txt_suc_nombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_suc_nombre.LostFocus
        txt_suc_nombre.BackColor = Color.White
    End Sub

    Private Sub txt_suc_direccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_suc_direccion.GotFocus
        txt_suc_direccion.SelectAll()
        txt_suc_direccion.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub txt_suc_direccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_suc_direccion.LostFocus
        txt_suc_direccion.BackColor = Color.White
    End Sub

    Private Sub txt_suc_telefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_suc_telefono.GotFocus
        txt_suc_telefono.SelectAll()
        txt_suc_telefono.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub txt_suc_telefono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_suc_telefono.LostFocus
        txt_suc_telefono.BackColor = Color.White
    End Sub

    Private Sub txt_suc_mail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_suc_mail.GotFocus
        txt_suc_mail.SelectAll()
        txt_suc_mail.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub txt_suc_mail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_suc_mail.LostFocus
        txt_suc_mail.BackColor = Color.White
    End Sub

    Private Sub CBox_provincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBox_provincia.SelectedIndexChanged
        If idprov <> 0 Then
            idprov = CBox_provincia.SelectedValue
            Obtener_localidades_x_provincias()
        End If
    End Sub

#Region "procedimientos"
    'Dim DS_config As New DS_configuraciones
    Private Sub recuperar_sucursales()

        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        If ds.Tables(0).Rows.Count <> 0 Then
            'DS_config.Tables("Sucursal").Merge(ds.Tables(0)) 'ds_configuraciones es un data set q esta en la carpeta "Configuraciones" de la capa Aplicacion
            DG_sucursales.DataSource = ds.Tables(0)
        End If
    End Sub
    Dim ds_provincias As DataSet
    Dim idprov As Integer
    Private Sub Obtener_provincias()
        ds_provincias = DAcliente.Provincias_ObtenerTodo()
        'Cargar Provincias en ComboBox_prov
        CBox_provincia.DataSource = ds_provincias.Tables(0)
        CBox_provincia.DisplayMember = "provincia"
        CBox_provincia.ValueMember = "Prov_id"
        idprov = CBox_provincia.SelectedValue
        Obtener_localidades_x_provincias()
    End Sub
    Private Sub Obtener_localidades_x_provincias()
        Dim ds_localidades As DataSet = DAcliente.Obtener_localidades_x_provincias(idprov)
        'Cargar Provincias en ComboBox_prov
        CBox_localidad.DataSource = ds_localidades.Tables(0)
        CBox_localidad.DisplayMember = "Localidad"
        CBox_localidad.ValueMember = "id"
    End Sub
    'validar ingreso de datos
    Private Sub validar_alta(ByRef valido As String, ByRef mayorista As String, ByRef minorista As String)
        If txt_suc_nombre.Text = "" Then
            txt_suc_nombre.Focus()
            MsgBox("Ingrese nombre para guardar")
            valido = "no"
        Else
            If txt_suc_direccion.Text = "" Then
                txt_suc_direccion.Focus()
                MsgBox("Ingrese Dirección para guardar")
                valido = "no"
            Else
                If txt_suc_telefono.Text = "" Then
                    txt_suc_telefono.Focus()
                    MsgBox("Ingrese Teléfono para guardar")
                    valido = "no"
                Else
                    If txt_suc_mail.Text = "" Then
                        txt_suc_mail.Focus()
                        MsgBox("Ingrese Mail para guardar")
                        valido = "no"
                    Else
                        'If check_mayorista.Checked = False And check_minorist.Checked = False Then
                        '    MsgBox("Seleccione un tipo de venta")
                        '    valido = "no"
                        'End If
                    End If
                End If
            End If
        End If
        If valido = "si" Then
            'ahora valido si no existe una sucursal con ese nombre
            Dim i As Integer = 0
            While i < DG_sucursales.Rows.Count
                If DG_sucursales.Rows(i).Cells(1).Value.ToString = txt_suc_nombre.Text Then
                    valido = "no"
                    MsgBox("Ya existe una sucursal con ese Nombre")
                    txt_suc_nombre.SelectAll()
                    txt_suc_nombre.Focus()
                End If
                i = i + 1
            End While
        End If

        'aqui asigno el valor a los check
        If check_mayorista.Checked = True Then
            mayorista = "si"
        Else
            mayorista = "no"
        End If
        If check_minorist.Checked = True Then
            minorista = "si"
        Else
            minorista = "no"
        End If
    End Sub
    Private Sub validar_modificar(ByRef valido As String, ByRef mayorista As String, ByRef minorista As String)
        If txt_suc_nombre.Text = "" Then
            txt_suc_nombre.Focus()
            MsgBox("Ingrese nombre para guardar")
            valido = "no"
        Else
            If txt_suc_direccion.Text = "" Then
                txt_suc_direccion.Focus()
                MsgBox("Ingrese Dirección para guardar")
                valido = "no"
            Else
                If txt_suc_telefono.Text = "" Then
                    txt_suc_telefono.Focus()
                    MsgBox("Ingrese Teléfono para guardar")
                    valido = "no"
                Else
                    If txt_suc_mail.Text = "" Then
                        txt_suc_mail.Focus()
                        MsgBox("Ingrese Mail para guardar")
                        valido = "no"
                    Else
                        'If check_mayorista.Checked = False And check_minorist.Checked = False Then
                        '    MsgBox("Seleccione un tipo de venta")
                        '    valido = "no"
                        'End If
                    End If
                End If
            End If
        End If
        If valido = "si" Then
            'ahora valido si no existe una sucursal con ese nombre e id distinto
            Dim i As Integer = 0
            While i < DG_sucursales.Rows.Count
                If (DG_sucursales.Rows(i).Cells(1).Value.ToString = txt_suc_nombre.Text) And (DG_sucursales.Rows(i).Cells(0).Value.ToString <> txt_ID.Text) Then
                    valido = "no"
                    MsgBox("Ya existe una sucursal con ese Nombre")
                    txt_suc_nombre.SelectAll()
                    txt_suc_nombre.Focus()
                End If
                i = i + 1
            End While
        End If

        'aqui asigno el valor a los check
        If check_mayorista.Checked = True Then
            mayorista = "si"
        Else
            mayorista = "no"
        End If
        If check_minorist.Checked = True Then
            minorista = "si"
        Else
            minorista = "no"
        End If

    End Sub
    Private Sub Limpiar_controles()
        txt_ID.Clear()
        txt_suc_nombre.Clear()
        txt_suc_direccion.Clear()
        txt_suc_telefono.Clear()
        txt_suc_mail.Clear()
        check_mayorista.Checked = False
        check_minorist.Checked = False
        Btn_nuevo.Enabled = True
    End Sub
#End Region






    Private Sub Btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_guardar.Click
        Dim valido = "si"
        Dim mayorista As String = "no"
        Dim minorista As String = "no"
        If Btn_nuevo.Enabled = True Then
            validar_alta(valido, mayorista, minorista)
            If valido = "si" Then
                DAsucursal.Sucursal_alta(txt_suc_nombre.Text, txt_suc_direccion.Text, txt_suc_telefono.Text, txt_suc_mail.Text, CBox_provincia.SelectedValue, CBox_localidad.SelectedValue, minorista, mayorista)
                recuperar_sucursales()
                Limpiar_controles()
                MsgBox("Sucursal registrada")
            End If
        Else
            'si esta el boton deshabilidado, edito
            validar_modificar(valido, mayorista, minorista)
            If valido = "si" Then
                DAsucursal.Sucursal_modificar(txt_ID.Text, txt_suc_nombre.Text, txt_suc_direccion.Text, txt_suc_telefono.Text, txt_suc_mail.Text, CBox_provincia.SelectedValue, CBox_localidad.SelectedValue, minorista, mayorista)
                recuperar_sucursales()
                Limpiar_controles()
                MsgBox("Sucursal modificada")
            End If
        End If


        
    End Sub

    Private Sub Btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_editar.Click
        'cargo en los textbox la indo de la grilla.
        If DG_sucursales.Rows.Count <> 0 Then
            txt_ID.Text = DG_sucursales.CurrentRow.Cells("SucursalidDataGridViewTextBoxColumn").Value
            txt_suc_nombre.Text = DG_sucursales.CurrentRow.Cells("SucursalnombreDataGridViewTextBoxColumn").Value
            txt_suc_direccion.Text = DG_sucursales.CurrentRow.Cells("SucursaldireccionDataGridViewTextBoxColumn").Value
            txt_suc_telefono.Text = DG_sucursales.CurrentRow.Cells("SucursaltelefonoDataGridViewTextBoxColumn").Value
            txt_suc_mail.Text = DG_sucursales.CurrentRow.Cells("SucursalmailDataGridViewTextBoxColumn").Value
            If DG_sucursales.CurrentRow.Cells("mayorista").Value.ToString = "si" Then
                check_mayorista.Checked = True
            Else
                check_mayorista.Checked = False
            End If
            If DG_sucursales.CurrentRow.Cells("minorista").Value.ToString = "si" Then
                check_minorist.Checked = True
            Else
                check_minorist.Checked = False
            End If
            CBox_provincia.SelectedValue = CInt(DG_sucursales.CurrentRow.Cells("prov_id").Value)
            CBox_localidad.SelectedValue = CInt(DG_sucursales.CurrentRow.Cells("localidad_id").Value)
            Btn_nuevo.Enabled = False
            txt_suc_nombre.Focus()
        End If
    End Sub

    Private Sub Btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancelar.Click
        Limpiar_controles()
    End Sub
End Class