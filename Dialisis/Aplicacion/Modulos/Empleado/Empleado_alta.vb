Imports System.IO
Imports System.Data.OleDb

Public Class Empleado_alta

    Dim DAempleado As New Datos.Empleado

    Private Sub Empleado_alta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'guardo en portapapeles la imagen por defecto para los empleados
        Clipboard.SetDataObject(Me.PictureBox1.Image)

        Combo_tpoMonto.SelectedIndex = 0


    End Sub


    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        'validamos x lo menos q tenga apellido nombre y dni
        If Tx_Remu.Text <> "" Then
            ERROR_tx_Remu.Visible = False
            If tx_ape_emp.Text <> "" Then
                ERROR_tx_ape_emp.Visible = False
                If tx_nom_emp.Text <> "" Then
                    ERROR_tx_nom_emp.Visible = False
                    If tx_dni_emp.Text <> "" Then
                        ERROR_tx_dni_emp.Visible = False

                        Dim result As DialogResult
                        result = MessageBox.Show("¿Desea dar de alta al Empleado?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                        If result = DialogResult.OK Then
                            Dim valido_empleado As New DataSet
                            valido_empleado = DAempleado.Empleado_buscardni(Me.tx_dni_emp.Text)
                            If valido_empleado.Tables(0).Rows.Count = 0 Then

                                'FOTO  //////////////////////////////////////////////////////////////////////////////////////////////////
                                Dim empleado_foto As Byte()
                                empleado_foto = Nothing
                                If PictureBox1.ImageLocation <> Nothing Then  'si tengo seleccionado una foto, la mando como parametro
                                    Dim ms = New MemoryStream
                                    Dim fs = New FileStream(PictureBox1.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                                    ms.SetLength(fs.Length)
                                    fs.Read(ms.GetBuffer(), 0, fs.Length)
                                    empleado_foto = ms.GetBuffer
                                    ms.Flush()
                                    fs.Close()
                                Else
                                    'si no tiene foto, le pongo x defecto la q esta en picture.image
                                    Dim ms = New MemoryStream
                                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                                    empleado_foto = ms.GetBuffer
                                    ms.Flush()
                                End If
                                'Empleado ALTA  //////////////////////////////////////////////////////////////////////////////////////////

                                DAempleado.Empleado_Alta(tx_dni_emp.Text, tx_nom_emp.Text, tx_ape_emp.Text, DT_fechanac_emp.Value, tx_dir_emp.Text, tx_tel_emp.Text, tx_cel_emp.Text, tx_mail_emp.Text, empleado_foto, tx_Funcion.Text, Combo_tpoMonto.Text, Tx_Remu.Text)
                                MessageBox.Show("Se Cargo Correctamente el Nuevo Empleado.", "Sistema de Gestion.")
                                limpiar_deshabilitar()
                            Else
                                MessageBox.Show("El Empleado ya existe", "Sistema de Gestion.")
                                ERROR_tx_dni_emp.Visible = True
                                tx_dni_emp.Focus()
                                Me.TabControl1.SelectedTab = TabPage1
                            End If
                        End If
                    Else
                        MessageBox.Show("Complete la información", "Sistema de Gestion.")
                        ERROR_tx_dni_emp.Visible = True
                        tx_dni_emp.Focus()
                        Me.TabControl1.SelectedTab = TabPage1
                    End If
                Else
                    MessageBox.Show("Complete la información", "Sistema de Gestion.")
                    ERROR_tx_nom_emp.Visible = True
                    tx_nom_emp.Focus()
                    Me.TabControl1.SelectedTab = TabPage1
                End If
            Else
                MessageBox.Show("Complete la información", "Sistema de Gestion.")
                ERROR_tx_ape_emp.Visible = True
                tx_ape_emp.Focus()
                Me.TabControl1.SelectedTab = TabPage1
            End If
        Else
            ERROR_tx_Remu.Visible = True
            Tx_Remu.Focus()
            MessageBox.Show("Complete la información", "Sistema de Gestion.", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub Bo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cancelar.Click
        limpiar_deshabilitar()
        Me.TabControl1.SelectedTab = TabPage1
        Bo_guardar.Enabled = True
        Bo_cancelar.Enabled = True
    End Sub

    Public Sub limpiar_deshabilitar()
        'datos personales///////////////////////////////////////////////////////////////////////////////////////////////////
        'botones de error
        ERROR_tx_ape_emp.Visible = False
        ERROR_tx_nom_emp.Visible = False
        ERROR_tx_dni_emp.Visible = False

        'datos personales
        tx_ape_emp.Text = ""
        tx_nom_emp.Text = ""
        tx_dni_emp.Text = ""
        tx_tel_emp.Text = ""
        tx_mail_emp.Text = ""
        tx_cel_emp.Text = ""
        tx_dir_emp.Text = ""
        DT_fechanac_emp.Text = ""
        tx_Funcion.Text = ""
        Tx_Remu.Text = ""
        'recupero del portapapeles la imagen por defecto
        Dim data As IDataObject
        data = Clipboard.GetDataObject
        Dim bmap As Bitmap
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
            Me.PictureBox1.Image = bmap
        End If


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
        Dim saveImage As New SaveFileDialog 'Este es el SaveFileDialog
        Dim ruta As String = "" 'Para tener la ruta de la imagen
        saveImage.Title = "Guardar imagen como..." 'Título de la ventana
        saveImage.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen
        If saveImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Recuperar la ruta de la imagen si no está vacía
            If Not String.IsNullOrEmpty(saveImage.FileName) Then ruta = saveImage.FileName
            Dim myImg As Image = PictureBox1.Image 'Objeto Image para guardar la imagen del Picture

            Dim extension As String = ruta.Substring(ruta.Length - 3, 3) 'Recuperar los ultimos 3 caracteres de la extensió

            'ESTO SOLO FUNCIONA EN VISUAL BASIC 2008
            Select Case extension
                Case "bmp"
                    myImg.Save(ruta, System.Drawing.Imaging.ImageFormat.Bmp) 'Guardar en formato BMP
                Case "jpg"
                    PictureBox1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg) 'Guardar en formato JPG
                Case "png"
                    PictureBox1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Png) 'Guardar en formato PNG
            End Select
        End If
    End Sub

    Private Sub Bo_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cargar.Click

        OpenFileDialog1.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub tx_dni_emp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_dni_emp.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

            If Me.tx_dni_emp.Text <> "" Then
                If Me.tx_dni_emp.Text > 99999999 Then
                    e.Handled = True
                End If
            End If

        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                    e.Handled = True
                End If


            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If
    End Sub

   
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_tpoMonto.SelectedIndexChanged
        If Combo_tpoMonto.Text = "Variable" Then
            Tx_Remu.Text = 1
            Tx_Remu.Enabled = False
        Else
            Tx_Remu.Text = ""
            Tx_Remu.Enabled = True
        End If
    End Sub

    Private Sub Tx_Remu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tx_Remu.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

            If Me.Tx_Remu.Text <> "" Then
                If Me.Tx_Remu.Text > 99999999 Then
                    e.Handled = True
                End If
            End If

        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                'If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                '    e.Handled = True
                'End If


            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If
    End Sub

 
End Class