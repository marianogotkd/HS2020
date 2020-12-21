Public Class Cliente_Sucursales
    Dim DAcliente As New Datos.Cliente
    Dim validaciones As New Validaciones

    Public provincia_id As Integer 'me la envian cuando modifican
    Public localidad_id As Integer 'me la envian cuando modifican
    Public nombre_sucursal As String 'me la envian cuando modifico y me sirve para q le permita cambiar el nombre (y a su vez no se pierda la referencia a la fila)


    Public operacion As String = "alta" 'si mando como parametro "modificar" hago un update del gridview

    Private Sub tx_Cp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_Cp.KeyPress
        validaciones.Restricciones_textbox(e, "Entero", tx_Cp)
    End Sub

    Dim ds_provincias As DataSet
    Dim idprov As Integer
    Private Sub Obtener_provincias()
        ds_provincias = DAcliente.Provincias_ObtenerTodo()
        'Cargar Provincias en ComboBox_prov
        combo_Prov.DataSource = ds_provincias.Tables(0)
        combo_Prov.DisplayMember = "provincia"
        combo_Prov.ValueMember = "Prov_id"
        idprov = combo_Prov.SelectedValue
        Obtener_localidades_x_provincias()
    End Sub

    Private Sub Obtener_localidades_x_provincias()
        Dim ds_localidades As DataSet = DAcliente.Obtener_localidades_x_provincias(idprov)
        'Cargar Provincias en ComboBox_prov
        Combo_Loc.DataSource = ds_localidades.Tables(0)
        Combo_Loc.DisplayMember = "Localidad"
        Combo_Loc.ValueMember = "id"
    End Sub

    Private Sub Cliente_Sucursales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_provincias()

        If operacion = "modificar" Then
            combo_Prov.SelectedValue = provincia_id
            Combo_Loc.SelectedValue = localidad_id
        End If

    End Sub

    Private Sub combo_Prov_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Prov.SelectedIndexChanged
        If idprov <> 0 Then
            idprov = combo_Prov.SelectedValue
            Obtener_localidades_x_provincias()
        End If
    End Sub

#Region "got focus - para poner colores de fondo y seleccionar todo el textbox"

    Private Sub tx_nombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_nombre.GotFocus
        tx_nombre.SelectAll()
        tx_nombre.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tx_tel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_tel.GotFocus
        tx_tel.SelectAll()
        tx_tel.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tx_mail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_mail.GotFocus
        tx_mail.SelectAll()
        tx_mail.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tx_dir_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_dir.GotFocus
        tx_dir.SelectAll()
        tx_dir.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub tx_Cp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Cp.GotFocus
        tx_Cp.SelectAll()
        tx_Cp.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub combo_Prov_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Prov.GotFocus
        combo_Prov.SelectAll()
        combo_Prov.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub Combo_Loc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Loc.GotFocus
        Combo_Loc.SelectAll()
        Combo_Loc.BackColor = Color.FromArgb(255, 255, 192)
    End Sub
#End Region

#Region "lost focus - para sacar los colores de fondo"

    Private Sub tx_nombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_nombre.LostFocus
        tx_nombre.BackColor = Color.White
    End Sub

    Private Sub tx_tel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_tel.LostFocus
        tx_tel.BackColor = Color.White
    End Sub

    Private Sub tx_mail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_mail.LostFocus
        tx_mail.BackColor = Color.White
    End Sub

    Private Sub tx_dir_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_dir.LostFocus
        tx_dir.BackColor = Color.White
    End Sub

    Private Sub tx_Cp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tx_Cp.LostFocus
        tx_Cp.BackColor = Color.White
    End Sub

    Private Sub combo_Prov_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_Prov.LostFocus
        combo_Prov.BackColor = Color.White
    End Sub


    Private Sub Combo_Loc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Loc.LostFocus
        Combo_Loc.BackColor = Color.White
    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'primero valido que al menos el cambo nombre tenga algo
        If tx_nombre.Text <> "" Then
            



            Select Case operacion
                Case "alta"
                    'ahora valido que no exista una sucursal con ese nombre en el gridview
                    Dim valido = "si"
                    Dim i As Integer = 0
                    While i < Cliente_alta_New.DG_Servicio.Rows.Count
                        If CStr(Cliente_alta_New.DG_Servicio.Rows(i).Cells("SucxClienombreDataGridViewTextBoxColumn").Value).ToUpper = tx_nombre.Text.ToUpper Then
                            valido = "no"
                            Exit While
                        End If
                        i = i + 1
                    End While
                    If valido = "si" Then
                        'If operacion = "alta" Then
                        'primero armo el row
                        Dim fila As DataRow = Cliente_alta_New.Cliente_ds.Tables("Sucursales").NewRow
                        fila("SucxClie_id") = 0 'pongo cero x que aun no lo guarde en  la bd
                        fila("SucxClie_nombre") = tx_nombre.Text
                        fila("SucxClie_Prov") = combo_Prov.SelectedValue
                        fila("SucxClie_Loc") = Combo_Loc.SelectedValue
                        fila("EnBD") = "no"
                        fila("Provincia") = combo_Prov.Text
                        fila("Localidad") = Combo_Loc.Text
                        fila("SucxClie_tel") = tx_tel.Text
                        fila("SucxClie_mail") = tx_mail.Text
                        fila("SucxClie_dir") = tx_dir.Text
                        If tx_Cp.Text = "" Then
                            tx_Cp.Text = 0
                        End If
                        fila("SucxClie_CP") = CInt(tx_Cp.Text)
                        Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows.Add(fila)
                        'aqui limpio los campos
                        limpiar_campos()
                        'End If
                    Else
                        MessageBox.Show("Error, ya existe una sucursal registrada con ese nombre.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tx_nombre.Focus()
                    End If

                Case "modificar"
                    'como es una modificacion, lo busco en cliente_ds y lo modifico.
                    Dim j As Integer = 0
                    While j < Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows.Count
                        If nombre_sucursal.ToUpper = CStr(Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("SucxClie_nombre")).ToUpper Then
                            'cuando lo encuentra ahora modifico
                            Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("SucxClie_nombre") = tx_nombre.Text
                            Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("SucxClie_Prov") = combo_Prov.SelectedValue
                            Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("SucxClie_Loc") = Combo_Loc.SelectedValue
                            'aqui viene lo interesante, si el cambo EnBD dice "si" entonces le pongo como nuevo estado "modificar en bd"
                            If Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("EnBD") = "si" Or Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("EnBD") = "modificar en bd" Then
                                Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("EnBD") = "modificar en bd"
                            Else
                                Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("EnBD") = "no"
                            End If
                            'nota: cuando diga enBD = no, entonces hago un alta de la sucursal en sql
                            'cuando diga "modificar en bd, hago un update de la info"
                            Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("Provincia") = combo_Prov.Text
                            Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("Localidad") = Combo_Loc.Text
                            Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("SucxClie_tel") = tx_tel.Text
                            Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("SucxClie_mail") = tx_mail.Text
                            Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("SucxClie_dir") = tx_dir.Text
                            If tx_Cp.Text = "" Then
                                tx_Cp.Text = 0
                            End If
                            Cliente_alta_New.Cliente_ds.Tables("Sucursales").Rows(j).Item("SucxClie_CP") = CInt(tx_Cp.Text)
                            Exit While
                        End If
                        j = j + 1
                    End While
                    limpiar_campos()
                    MessageBox.Show("Datos modificados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
            End Select
        Else
            MessageBox.Show("Error, debe completar al menos el Nombre", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tx_nombre.Focus()
        End If










    End Sub

    Private Sub limpiar_campos()
        tx_nombre.Clear()
        tx_tel.Clear()
        tx_mail.Clear()
        tx_dir.Clear()
        tx_Cp.Clear()
    End Sub


End Class