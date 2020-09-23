Imports System.IO
Imports System.Data.OleDb

Public Class Empresa
    Dim daempresa As New Datos.Empresa
    Public empresa_ID = 0


    Private Sub Empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show() 'esto uso para q me ponga el foco en el textbox, sino no lo hace
        TextBox_Nombre.Focus() 'pongo el foco en textbox inicial, para modificar los datos

        Clipboard.SetDataObject(Me.PictureBox1.Image)
        '------esta seccion originalmente no iva, ya que estos parametros se pasaban desde el form empresa_modificar. Como tenemos solamente 1 empresa de momento...lo mando ahora a los parametros de esta manera
        Me.Text = "Actualizar Empresa"
        Me.empresa_ID = "1"
        '---------------------------------------------------------
        If empresa_ID <> 0 Then
            Cargar_Datos_Empresa()
        End If
        TextBox_Nombre.Focus()
    End Sub

    Private Sub Cargar_Datos_Empresa()
        Dim DS_Empresa As DataSet = daempresa.empresa_obtener_porID(empresa_ID)
        TextBox_Nombre.Text = DS_Empresa.Tables(0).Rows(0).Item("empresa_Nombre")
        TextBox_dire.Text = DS_Empresa.Tables(0).Rows(0).Item("empresa_dir")
        TextBox_telefono.Text = DS_Empresa.Tables(0).Rows(0).Item("empresa_telefono")
        TextBox_Eslogan.Text = DS_Empresa.Tables(0).Rows(0).Item("empresa_eslogan")
        TextBox_mail.Text = DS_Empresa.Tables(0).Rows(0).Item("empresa_mail")
        TextBox_cuit.Text = DS_Empresa.Tables(0).Rows(0).Item("empresa_cuit")
        'recupero foto
        Dim arrImg As Byte() = DirectCast(DS_Empresa.Tables(0).Rows(0).Item("empresa_foto"), Byte())
        Dim ms As New MemoryStream(arrImg)
        Dim img As Image = Image.FromStream(ms)
        PictureBox1.Image = img
    End Sub

    Private Sub Bo_deshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_deshacer.Click
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox1.Image = bmap
        End If
    End Sub

    Private Sub Bo_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_exportar.Click
        'OpenFileDialog1.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        OpenFileDialog1.Filter = "Imagen JPG (*.jpg)|*.jpg|Imagen BMP (*.bmp)|*.bmp|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        OpenFileDialog1.FileName = "" 'para q cuando abra el dialogo en el nombre no salga "openfiledialog"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click

        If TextBox_Nombre.Text <> "" And TextBox_dire.Text <> "" And TextBox_telefono.Text <> "" Then
           
            'FOTO  //////////////////////////////////////////////////////////////////////////////////////////////////
            Dim producto_foto As Byte()
            producto_foto = Nothing
            If PictureBox1.ImageLocation <> Nothing Then  'si tengo seleccionado una foto, la mando como parametro
                Dim ms = New MemoryStream
                Dim fs = New FileStream(PictureBox1.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                ms.SetLength(fs.Length)
                fs.Read(ms.GetBuffer(), 0, fs.Length)
                producto_foto = ms.GetBuffer
                ms.Flush()
                fs.Close()
            Else
                'si no tiene foto, le pongo x defecto la q esta en picture.image
                Dim ms = New MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                producto_foto = ms.GetBuffer
                ms.Flush()
            End If
            If empresa_ID <> 0 Then
                Dim result As DialogResult
                result = MessageBox.Show("¿Desea modificar los datos de la empresa?", "Sistema de Gestión", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    daempresa.Empresa_Actualizar(TextBox_Nombre.Text, TextBox_dire.Text, TextBox_telefono.Text, TextBox_Eslogan.Text, TextBox_mail.Text, TextBox_cuit.Text, producto_foto, empresa_ID)
                    Empresa_Modificar.Empresa_obtener()
                    MessageBox.Show("Datos Registrados Correctamente", "Sistema de Gestión.", MessageBoxButtons.OK)
                    Me.Close()
                    'Empresa_Modificar.Show() no lo uso ahora, ya que tengo oculto el modulo de empresa_modificar...el cliente tiene una sola empresa
                End If
            Else
                Dim result As DialogResult
                result = MessageBox.Show("¿Desea registrar la nueva empresa?", "Sistema de Gestión", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    daempresa.Empresa_Alta(TextBox_Nombre.Text, TextBox_dire.Text, TextBox_telefono.Text, TextBox_Eslogan.Text, TextBox_mail.Text, TextBox_cuit.Text, producto_foto)
                    Empresa_Modificar.Empresa_obtener()
                    MessageBox.Show("Datos Registrados Correctamente", "Sistema de Gestión.", MessageBoxButtons.OK)
                    Me.Close()
                    'Empresa_Modificar.Show() no lo uso ahora, ya que tengo oculto el modulo de empresa_modificar...el cliente tiene una sola empresa
                End If
            End If
            label_ast1.Visible = False
            Label_ast2.Visible = False
            Label_ast3.Visible = False
            Limpiar()
        Else
            MessageBox.Show("Complete los campos obligatorios", "Sistema de Gestión.", MessageBoxButtons.OK)
            label_ast1.Visible = True
            Label_ast2.Visible = True
            Label_ast3.Visible = True
        End If
    End Sub
    Private Sub Limpiar()
        TextBox_Nombre.Text = ""
        TextBox_dire.Text = ""
        TextBox_telefono.Text = ""
        TextBox_Eslogan.Text = ""
        TextBox_mail.Text = ""
        TextBox_cuit.Text = ""
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox1.Image = bmap
        End If
    End Sub


    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        'Empresa_Modificar.Show() lo quite ya q el cliente solo tiene 1 empresa...no lo uso de momento
        Me.Close()
    End Sub

    
#Region "Foco y color de fondo en textbox"
    Private Sub TextBox_Nombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Nombre.GotFocus
        TextBox_Nombre.SelectAll()
        TextBox_Nombre.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_Nombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Nombre.LostFocus
        TextBox_Nombre.BackColor = Color.White
    End Sub

    Private Sub TextBox_dire_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_dire.GotFocus
        TextBox_dire.SelectAll()
        TextBox_dire.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_dire_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_dire.LostFocus
        TextBox_dire.BackColor = Color.White
    End Sub

    Private Sub TextBox_telefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_telefono.GotFocus
        TextBox_telefono.SelectAll()
        TextBox_telefono.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_telefono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_telefono.LostFocus
        TextBox_telefono.BackColor = Color.White
    End Sub

    Private Sub TextBox_Eslogan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Eslogan.GotFocus
        TextBox_Eslogan.SelectAll()
        TextBox_Eslogan.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_Eslogan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Eslogan.LostFocus
        TextBox_Eslogan.BackColor = Color.White
    End Sub

    Private Sub TextBox_mail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_mail.GotFocus
        TextBox_mail.SelectAll()
        TextBox_mail.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_mail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_mail.LostFocus
        TextBox_mail.BackColor = Color.White
    End Sub

    Private Sub TextBox_cuit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_cuit.GotFocus
        TextBox_cuit.SelectAll()
        TextBox_cuit.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox_cuit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_cuit.LostFocus
        TextBox_cuit.BackColor = Color.White
    End Sub
#End Region
End Class