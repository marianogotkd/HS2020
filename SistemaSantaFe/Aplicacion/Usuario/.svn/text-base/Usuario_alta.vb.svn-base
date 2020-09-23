Imports System.IO
Public Class Usuario_alta

    Dim dausuario As New Datos.Usuario
    Dim ds_usuariotipo As DataSet
    Dim DAsucursal As New Datos.Sucursal
    Public form_procedencia As String = "alta"
    Public usu_id As Integer = 0
    Private Sub Sucursales_Obtener()
        Dim ds As DataSet = DAsucursal.Sucursal_obtener()
        'Cargar Provincias en ComboBox_prov
        ComboBox_Sucursal.DataSource = ds.Tables(0)
        ComboBox_Sucursal.DisplayMember = "sucursal_nombre"
        ComboBox_Sucursal.ValueMember = "sucursal_id"


    End Sub
    Public Sub usuario_inicio()
        ds_usuariotipo = dausuario.UsuarioTipo_obtener
        COM_UT_dep.DataSource = ds_usuariotipo.Tables(0)
        COM_UT_dep.DisplayMember = "UT_desc"
        COM_UT_dep.ValueMember = "UT_id"
    End Sub
    Public Sub Usuario_AltaLimpiar()
        TX_USU_dni.Text = Nothing
        TX_USU_ape.Text = Nothing
        TX_USU_nom.Text = Nothing
        TX_USU_domicilio.Text = Nothing
        TX_USU_telefono.Text = Nothing
        TX_USU_usuario.Text = Nothing
        TX_USU_contr.Text = Nothing
        TX_USU_contr2.Text = Nothing
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox2.Image = bmap
        End If
    End Sub

    Private Sub Usuario_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        Clipboard.SetDataObject(Me.PictureBox2.Image)
        TX_USU_dni.Focus()
        usuario_inicio() 'carga en el combo los tipos de usuarios
        Sucursales_Obtener()
        Usuario_AltaLimpiar()
        If form_procedencia = "alta" Then
            Clipboard.SetDataObject(Me.PictureBox2.Image)
        Else
            Clipboard.SetDataObject(Me.PictureBox2.Image)
            'modificar
            'dejo q modifique todo, pero ojo al guardar, tengo q validar q cuando cambie el usuario, no exista otro...y si cambio el dni, tambien q no exista otro con el mismo dato
            'no dejo q cambie la sucursal..para ello debe agregar otro usuario.
            Recuperar_datos_usuario()
        End If
    End Sub

    Private Sub Recuperar_datos_usuario()
        Dim ds_usuario As DataSet = dausuario.Usuario_recuperar_datos_personales(usu_id)
        If ds_usuario.Tables(0).Rows.Count <> 0 Then 'si existe cargo en textbox
            TX_USU_dni.Text = ds_usuario.Tables(0).Rows(0).Item("dni")
            TX_USU_ape.Text = ds_usuario.Tables(0).Rows(0).Item("apellido")
            TX_USU_nom.Text = ds_usuario.Tables(0).Rows(0).Item("nombre")
            TX_USU_domicilio.Text = ds_usuario.Tables(0).Rows(0).Item("domicilio")
            TX_USU_telefono.Text = ds_usuario.Tables(0).Rows(0).Item("telefono")
            TX_USU_usuario.Text = ds_usuario.Tables(0).Rows(0).Item("usuario")
            TX_USU_contr.Text = ds_usuario.Tables(0).Rows(0).Item("contraseña")
            TX_USU_contr2.Text = ds_usuario.Tables(0).Rows(0).Item("contraseña")
            COM_UT_dep.SelectedValue = ds_usuario.Tables(0).Rows(0).Item("UT_id")
            ComboBox_Sucursal.SelectedValue = ds_usuario.Tables(0).Rows(0).Item("sucursal_id")
            ComboBox_Sucursal.Enabled = False 'no quiero q se cambie la sucursal
            'ahora la imagen
            'recupero foto
            Dim arrImg As Byte() = DirectCast(ds_usuario.Tables(0).Rows(0).Item("foto"), Byte())
            Dim ms As New MemoryStream(arrImg)
            Dim img As Image = Image.FromStream(ms)
            PictureBox2.Image = img
        End If
    End Sub



    Private Sub validacion_alta()
        'validamos q no esta vacio
        Dim valido As String = "si"
        If TX_USU_dni.Text = "" Or TX_USU_ape.Text = "" Or TX_USU_nom.Text = "" Or TX_USU_usuario.Text = "" Or TX_USU_contr.Text = "" Then
            valido = "no"
            error_dni.Visible = True
            error_apellido.Visible = True
            error_nombre.Visible = True
            error_usuario.Visible = True
            error_contraseña.Visible = True
            TX_USU_dni.Focus()
            TX_USU_dni.SelectAll()
            MessageBox.Show("Ingrese los campos obligatorios.", "Sistema de Gestión.")
        Else
            'si no esta vacio valido q no sea uno q ya existe
            Dim ds_usuarios As DataSet = dausuario.Usuario_obtener()
            If ds_usuarios.Tables(2).Rows.Count <> 0 Then 'la tabla 2 trae todos los usuarios en la BD
                'ciclo para buscar el dni q ingreso
                Dim dni As Integer = CInt(TX_USU_dni.Text)
                Dim i As Integer = 0
                Dim existe = "no"
                While i < ds_usuarios.Tables(2).Rows.Count
                    If ds_usuarios.Tables(2).Rows(i).Item("dni") = dni Then
                        existe = "si"
                        i = ds_usuarios.Tables(2).Rows.Count
                    End If
                    i = i + 1
                End While
                If existe = "si" Then
                    valido = "no"
                    'aqui va el mensaje de q cambie el dni
                    error_dni.Visible = True
                    TX_USU_dni.Focus()
                    TX_USU_dni.SelectAll()
                    MessageBox.Show("Error, el usuario ya existe, modifique el DNI", "Sistema de Gestión.")
                Else
                    'ahora valido el usuario
                    i = 0
                    Dim usuario As String = TX_USU_usuario.Text
                    While i < ds_usuarios.Tables(2).Rows.Count
                        If CStr(ds_usuarios.Tables(2).Rows(i).Item("usuario")).ToUpper = usuario.ToUpper Then
                            existe = "si"
                            i = ds_usuarios.Tables(2).Rows.Count
                        End If
                        i = i + 1
                    End While
                    If existe = "si" Then
                        valido = "no"
                        'aqui va el mensaje de q cambie el nombre de usuario
                        error_usuario.Visible = True
                        TX_USU_usuario.Focus()
                        TX_USU_usuario.SelectAll()
                        MessageBox.Show("Error, el usuario ya existe, modifique el nombre de Usuario", "Sistema de Gestión.")
                    Else
                        'ahora valido que las contraseñas sean iguales
                        If TX_USU_contr.Text <> TX_USU_contr2.Text Then
                            valido = "no"
                            error_contraseña.Visible = True
                            TX_USU_contr.Focus()
                            TX_USU_contr2.SelectAll()
                            MessageBox.Show("Error, la contraseña es incorrecta", "Sistema de Gestión.")
                        Else
                            'como todo esta bien, ahora puedo llamar al procedimiento de alta de usuario
                            alta()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub alta()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea agregar el nuevo Usuario?", "Sistema de Gestión", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'FOTO  //////////////////////////////////////////////////////////////////////////////////////////////////
            Dim producto_foto As Byte()
            producto_foto = Nothing
            If PictureBox2.ImageLocation <> Nothing Then  'si tengo seleccionado una foto, la mando como parametro
                Dim ms = New MemoryStream
                Dim fs = New FileStream(PictureBox2.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                ms.SetLength(fs.Length)
                fs.Read(ms.GetBuffer(), 0, fs.Length)
                producto_foto = ms.GetBuffer
                ms.Flush()
                fs.Close()
            Else
                'si no tiene foto, le pongo x defecto la q esta en picture.image
                Dim ms = New MemoryStream
                PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
                producto_foto = ms.GetBuffer
                ms.Flush()
            End If
            Dim UT_id As String = ds_usuariotipo.Tables(0).Rows(COM_UT_dep.SelectedIndex).Item("UT_id").ToString
            dausuario.Usuario_alta(UT_id, TX_USU_ape.Text, TX_USU_nom.Text, TX_USU_usuario.Text, TX_USU_contr.Text, ComboBox_Sucursal.SelectedValue, CInt(TX_USU_dni.Text), TX_USU_domicilio.Text, TX_USU_telefono.Text, producto_foto)
            Usuario_AltaLimpiar()
            MessageBox.Show("El Usuario fue dado de alta correctamente.", "Sistema de Gestión")
            Me.Close()
            Usuario_modificar.Show()
        End If
    End Sub
    Private Sub validacion_modificar()
        'validamos q no esta vacio
        Dim valido As String = "si"
        If TX_USU_dni.Text = "" Or TX_USU_ape.Text = "" Or TX_USU_nom.Text = "" Or TX_USU_usuario.Text = "" Or TX_USU_contr.Text = "" Then
            valido = "no"
            error_dni.Visible = True
            error_apellido.Visible = True
            error_nombre.Visible = True
            error_usuario.Visible = True
            error_contraseña.Visible = True
            TX_USU_dni.Focus()
            TX_USU_dni.SelectAll()
            MessageBox.Show("Ingrese los campos obligatorios.", "Sistema de Gestión.")
        Else
            'si no esta vacio valido q no sea uno q ya existe
            Dim ds_usuarios As DataSet = dausuario.Usuario_obtener()
            If ds_usuarios.Tables(2).Rows.Count <> 0 Then 'la tabla 2 trae todos los usuarios en la BD
                'ciclo para buscar el dni q ingreso
                Dim dni As Integer = CInt(TX_USU_dni.Text)
                Dim i As Integer = 0
                Dim existe = "no"
                While i < ds_usuarios.Tables(2).Rows.Count
                    If ds_usuarios.Tables(2).Rows(i).Item("dni") = dni And usu_id <> ds_usuarios.Tables(2).Rows(i).Item("USU_id") Then
                        existe = "si"
                        i = ds_usuarios.Tables(2).Rows.Count
                    End If
                    i = i + 1
                End While
                If existe = "si" Then
                    valido = "no"
                    'aqui va el mensaje de q cambie el dni
                    error_dni.Visible = True
                    TX_USU_dni.Focus()
                    TX_USU_dni.SelectAll()
                    MessageBox.Show("Error, el usuario ya existe, modifique el DNI", "Sistema de Gestión.")
                Else
                    'ahora valido el usuario
                    i = 0
                    Dim usuario As String = TX_USU_usuario.Text
                    While i < ds_usuarios.Tables(2).Rows.Count
                        If CStr(ds_usuarios.Tables(2).Rows(i).Item("usuario")).ToUpper = usuario.ToUpper And usu_id <> ds_usuarios.Tables(2).Rows(i).Item("USU_id") Then
                            existe = "si"
                            i = ds_usuarios.Tables(2).Rows.Count
                        End If
                        i = i + 1
                    End While
                    If existe = "si" Then
                        valido = "no"
                        'aqui va el mensaje de q cambie el nombre de usuario
                        error_usuario.Visible = True
                        TX_USU_usuario.Focus()
                        TX_USU_usuario.SelectAll()
                        MessageBox.Show("Error, el usuario ya existe, modifique el nombre de Usuario", "Sistema de Gestión.")
                    Else
                        'ahora valido que las contraseñas sean iguales
                        If TX_USU_contr.Text <> TX_USU_contr2.Text Then
                            valido = "no"
                            error_contraseña.Visible = True
                            TX_USU_contr.Focus()
                            TX_USU_contr2.SelectAll()
                            MessageBox.Show("Error, la contraseña es incorrecta", "Sistema de Gestión.")
                        Else
                            'como todo esta bien, ahora puedo llamar al procedimiento de modificar de usuario
                            modificar()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub modificar()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar los datos del Usuario?", "Sistema de Gestión", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'FOTO  //////////////////////////////////////////////////////////////////////////////////////////////////
            Dim producto_foto As Byte()
            producto_foto = Nothing
            If PictureBox2.ImageLocation <> Nothing Then  'si tengo seleccionado una foto, la mando como parametro
                Dim ms = New MemoryStream
                Dim fs = New FileStream(PictureBox2.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                ms.SetLength(fs.Length)
                fs.Read(ms.GetBuffer(), 0, fs.Length)
                producto_foto = ms.GetBuffer
                ms.Flush()
                fs.Close()
            Else
                'si no tiene foto, le pongo x defecto la q esta en picture.image
                Dim ms = New MemoryStream
                PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
                producto_foto = ms.GetBuffer
                ms.Flush()
            End If
            Dim UT_id As String = ds_usuariotipo.Tables(0).Rows(COM_UT_dep.SelectedIndex).Item("UT_id").ToString
            dausuario.Usuario_modificar(usu_id, UT_id, TX_USU_ape.Text, TX_USU_nom.Text, TX_USU_usuario.Text, TX_USU_contr.Text, ComboBox_Sucursal.SelectedValue, CInt(TX_USU_dni.Text), TX_USU_domicilio.Text, TX_USU_telefono.Text, producto_foto)
            Usuario_AltaLimpiar()
            MessageBox.Show("El Usuario fue modificado correctamente.", "Sistema de Gestión")
            Me.Close()
            Usuario_modificar.Show()
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        If form_procedencia = "alta" Then
            validacion_alta() 'si esta todo valido, dentro de este procedimiento se llama al proc. "ALTA"
        End If

        If form_procedencia = "modificar" Then
            validacion_modificar() 'su esta tidi vakudim debtri de este procedimiento se llama al proc. "MODIFICAR"
        End If
    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        Me.Close()
        Usuario_modificar.Show()
    End Sub

#Region "Formato_textbox_back_color"
    Dim validaciones As New Validaciones
    Private Sub TX_USU_dni_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_dni.GotFocus
        TX_USU_dni.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_dni)
    End Sub

    Private Sub TX_USU_dni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_USU_dni.KeyPress
        validaciones.Restricciones_textbox(e, "Entero", TX_USU_dni)
    End Sub

    Private Sub TX_USU_dni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_dni.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_dni)
    End Sub

    Private Sub TX_USU_ape_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_ape.GotFocus
        TX_USU_ape.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_ape)
    End Sub

    Private Sub TX_USU_ape_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_ape.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_ape)
    End Sub

    Private Sub TX_USU_nom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_nom.GotFocus
        TX_USU_nom.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_nom)
    End Sub

    Private Sub TX_USU_nom_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_nom.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_nom)
    End Sub

    Private Sub TX_USU_domicilio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_domicilio.GotFocus
        TX_USU_domicilio.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_domicilio)
    End Sub

    Private Sub TX_USU_domicilio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_domicilio.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_domicilio)
    End Sub

    Private Sub TX_USU_telefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_telefono.GotFocus
        TX_USU_telefono.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_telefono)
    End Sub

    Private Sub TX_USU_telefono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_telefono.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_telefono)
    End Sub

    Private Sub TX_USU_usuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_usuario.GotFocus
        TX_USU_usuario.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_usuario)
    End Sub

    Private Sub TX_USU_usuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_usuario.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_usuario)
    End Sub

    Private Sub TX_USU_contr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_contr.GotFocus
        TX_USU_contr.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_contr)
    End Sub

    Private Sub TX_USU_contr_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_contr.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_contr)
    End Sub
    Private Sub TX_USU_contr2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_contr2.GotFocus
        TX_USU_contr2.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_contr2)
    End Sub

    Private Sub TX_USU_contr2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_contr2.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_contr2)
    End Sub

#End Region

    Private Sub Bo_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_exportar.Click
        'OpenFileDialog1.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        OpenFileDialog1.Filter = "Imagen JPG (*.jpg)|*.jpg|Imagen BMP (*.bmp)|*.bmp|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        OpenFileDialog1.FileName = "" 'para q cuando abra el dialogo en el nombre no salga "openfiledialog"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox2.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Bo_deshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_deshacer.Click
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox2.Image = bmap
        End If
    End Sub

End Class