Imports System.IO
Public Class Vendedor_alta
    Public form_procedencia As String = "alta"
    Dim daVendedor As New Datos.Vendedor
    Public vendedor_id As Integer = 0
    Private Sub Vendedor_alta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        Clipboard.SetDataObject(Me.PictureBox2.Image)
        TX_USU_dni.Focus()
        'usuario_inicio() 'carga en el combo los tipos de usuarios
        'Sucursales_Obtener()
        vendedor_AltaLimpiar()
        If form_procedencia = "alta" Then
            Clipboard.SetDataObject(Me.PictureBox2.Image)
        Else
            Clipboard.SetDataObject(Me.PictureBox2.Image)
            'modificar
            'dejo q modifique todo, pero ojo al guardar, tengo q validar q cuando cambie el usuario, no exista otro...y si cambio el dni, tambien q no exista otro con el mismo dato
            'no dejo q cambie la sucursal..para ello debe agregar otro usuario.
            Recuperar_datos_vendedor()
        End If
    End Sub


#Region "metodos"
    Public Sub vendedor_AltaLimpiar()
        TX_USU_dni.Text = Nothing
        TX_USU_ape.Text = Nothing
        TX_USU_nom.Text = Nothing
        TX_USU_domicilio.Text = Nothing
        TX_USU_telefono.Text = Nothing
        TX_USU_mail.Text = Nothing
        TX_USU_observacion.Text = Nothing
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox2.Image = bmap
        End If
    End Sub

    Private Sub Recuperar_datos_vendedor()
        Dim ds_usuario As DataSet = daVendedor.Vendedor_recuperar_datos_personales(vendedor_id)
        If ds_usuario.Tables(0).Rows.Count <> 0 Then 'si existe cargo en textbox
            TX_USU_dni.Text = ds_usuario.Tables(0).Rows(0).Item("dni")
            TX_USU_ape.Text = ds_usuario.Tables(0).Rows(0).Item("apellido")
            TX_USU_nom.Text = ds_usuario.Tables(0).Rows(0).Item("nombre")
            TX_USU_domicilio.Text = ds_usuario.Tables(0).Rows(0).Item("domicilio")
            TX_USU_telefono.Text = ds_usuario.Tables(0).Rows(0).Item("telefono")

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
        If TX_USU_dni.Text = "" Or TX_USU_ape.Text = "" Or TX_USU_nom.Text = "" Then
            valido = "no"
            error_dni.Visible = True
            error_apellido.Visible = True
            error_nombre.Visible = True
            TX_USU_dni.Focus()
            TX_USU_dni.SelectAll()
            MessageBox.Show("Ingrese los campos obligatorios.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'si no esta vacio valido q no sea uno q ya existe
            Dim ds_usuarios As DataSet = daVendedor.Vendedor_buscarDNI(CInt(TX_USU_dni.Text))
            If ds_usuarios.Tables(0).Rows.Count <> 0 Then 'la tabla 2 trae todos los usuarios en la BD
                error_dni.Visible = True
                TX_USU_dni.Focus()
                TX_USU_dni.SelectAll()
                MessageBox.Show("Error, el usuario ya existe, modifique los datos principales", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                alta()
            End If
        End If
    End Sub

    Private Sub alta()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea agregar el nuevo Vendedor?", "Sistema de Gestión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
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
            'Dim UT_id As String = ds_usuariotipo.Tables(0).Rows(COM_UT_dep.SelectedIndex).Item("UT_id").ToString
            daVendedor.Vendedor_alta(TX_USU_dni.Text, TX_USU_ape.Text, TX_USU_nom.Text, TX_USU_domicilio.Text, TX_USU_telefono.Text, TX_USU_mail.Text, TX_USU_observacion.Text, producto_foto)
            'dausuario.Usuario_alta(UT_id, TX_USU_ape.Text, TX_USU_nom.Text, TX_USU_usuario.Text, TX_USU_contr.Text, ComboBox_Sucursal.SelectedValue, CInt(TX_USU_dni.Text), TX_USU_domicilio.Text, TX_USU_telefono.Text, producto_foto)
            vendedor_AltaLimpiar()
            MessageBox.Show("El Vendedor fue dado de alta correctamente.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()


            'aqui debo llamar al modulo vendedor modificar.
            Venta_Caja_gestion.vendedores_obtener()

            Vendedor_modificar.Show()
        End If
    End Sub

    Private Sub validacion_modificar()
        'validamos q no esta vacio
        Dim valido As String = "si"
        If TX_USU_dni.Text = "" Or TX_USU_ape.Text = "" Or TX_USU_nom.Text = "" Then
            valido = "no"
            error_dni.Visible = True
            error_apellido.Visible = True
            error_nombre.Visible = True
            TX_USU_dni.Focus()
            TX_USU_dni.SelectAll()
            MessageBox.Show("Ingrese los campos obligatorios.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            modificar()
        End If
    End Sub

    Private Sub modificar()
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea modificar los datos del Vendedor?", "Sistema de Gestión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
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
            'Dim UT_id As String = ds_usuariotipo.Tables(0).Rows(COM_UT_dep.SelectedIndex).Item("UT_id").ToString

            daVendedor.Vendedor_modificar(vendedor_id, CInt(TX_USU_dni.Text), TX_USU_ape.Text, TX_USU_nom.Text, TX_USU_domicilio.Text, TX_USU_telefono.Text, TX_USU_mail.Text, TX_USU_observacion.Text, producto_foto)
            vendedor_AltaLimpiar()
            MessageBox.Show("El Vendedor fue modificado correctamente.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Venta_Caja_gestion.vendedores_obtener()
            Vendedor_modificar.Show()
        End If
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

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        Me.Close()
        'Usuario_modificar.Show()
    End Sub

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        If form_procedencia = "alta" Then
            validacion_alta() 'si esta todo valido, dentro de este procedimiento se llama al proc. "ALTA"
        End If

        If form_procedencia = "modificar" Then
            validacion_modificar() 'su esta tidi vakudim debtri de este procedimiento se llama al proc. "MODIFICAR"
        End If
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

    Private Sub TX_USU_mail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_mail.GotFocus
        TX_USU_mail.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_mail)
    End Sub

    Private Sub TX_USU_mail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_mail.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_mail)
    End Sub

    Private Sub TX_USU_observacion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_observacion.GotFocus
        TX_USU_observacion.SelectAll()
        validaciones.Formatos_backcolor_textbox_y_combobox("GotFocus", TX_USU_observacion)
    End Sub

    Private Sub TX_USU_observacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TX_USU_observacion.LostFocus
        validaciones.Formatos_backcolor_textbox_y_combobox("LostFocus", TX_USU_observacion)
    End Sub
#End Region

    

End Class