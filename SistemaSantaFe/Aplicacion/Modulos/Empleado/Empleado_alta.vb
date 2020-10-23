Imports System.IO
Imports System.Data.OleDb

Public Class Empleado_alta
    Public empleado_id As Integer
    Public form_procedencia As String = "alta"
    Dim DAempleado As New Datos.Empleado
    Dim Validaciones As New Validaciones
    Private Sub Empleado_alta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'guardo en portapapeles la imagen por defecto para los empleados
        'Clipboard.SetDataObject(Me.PictureBox1.Image)

        'Combo_tpoMonto.SelectedIndex = 0


    End Sub


    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''validamos x lo menos q tenga apellido nombre y dni
        'If Tx_Remu.Text <> "" Then
        '    ERROR_tx_Remu.Visible = False
        '    If tx_ape_emp.Text <> "" Then
        '        ERROR_tx_ape_emp.Visible = False
        '        If tx_nom_emp.Text <> "" Then
        '            ERROR_tx_nom_emp.Visible = False
        '            If tx_dni_emp.Text <> "" Then
        '                ERROR_tx_dni_emp.Visible = False

        '                Dim result As DialogResult
        '                result = MessageBox.Show("¿Desea dar de alta al Empleado?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        '                If result = DialogResult.OK Then
        '                    Dim valido_empleado As New DataSet
        '                    valido_empleado = DAempleado.Empleado_buscardni(Me.tx_dni_emp.Text)
        '                    If valido_empleado.Tables(0).Rows.Count = 0 Then

        '                        'FOTO  //////////////////////////////////////////////////////////////////////////////////////////////////
        '                        Dim empleado_foto As Byte()
        '                        empleado_foto = Nothing
        '                        If PictureBox1.ImageLocation <> Nothing Then  'si tengo seleccionado una foto, la mando como parametro
        '                            Dim ms = New MemoryStream
        '                            Dim fs = New FileStream(PictureBox1.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        '                            ms.SetLength(fs.Length)
        '                            fs.Read(ms.GetBuffer(), 0, fs.Length)
        '                            empleado_foto = ms.GetBuffer
        '                            ms.Flush()
        '                            fs.Close()
        '                        Else
        '                            'si no tiene foto, le pongo x defecto la q esta en picture.image
        '                            Dim ms = New MemoryStream
        '                            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        '                            empleado_foto = ms.GetBuffer
        '                            ms.Flush()
        '                        End If
        '                        'Empleado ALTA  //////////////////////////////////////////////////////////////////////////////////////////

        '                        DAempleado.Empleado_Alta(tx_dni_emp.Text, tx_nom_emp.Text, tx_ape_emp.Text, DT_fechanac_emp.Value, tx_dir_emp.Text, tx_tel_emp.Text, tx_cel_emp.Text, tx_mail_emp.Text, empleado_foto, tx_Funcion.Text, Combo_tpoMonto.Text, Tx_Remu.Text)
        '                        MessageBox.Show("Se Cargo Correctamente el Nuevo Empleado.", "Sistema de Gestion.")
        '                        limpiar_deshabilitar()
        '                    Else
        '                        MessageBox.Show("El Empleado ya existe", "Sistema de Gestion.")
        '                        ERROR_tx_dni_emp.Visible = True
        '                        tx_dni_emp.Focus()
        '                        Me.TabControl1.SelectedTab = TabPage1
        '                    End If
        '                End If
        '            Else
        '                MessageBox.Show("Complete la información", "Sistema de Gestion.")
        '                ERROR_tx_dni_emp.Visible = True
        '                tx_dni_emp.Focus()
        '                Me.TabControl1.SelectedTab = TabPage1
        '            End If
        '        Else
        '            MessageBox.Show("Complete la información", "Sistema de Gestion.")
        '            ERROR_tx_nom_emp.Visible = True
        '            tx_nom_emp.Focus()
        '            Me.TabControl1.SelectedTab = TabPage1
        '        End If
        '    Else
        '        MessageBox.Show("Complete la información", "Sistema de Gestion.")
        '        ERROR_tx_ape_emp.Visible = True
        '        tx_ape_emp.Focus()
        '        Me.TabControl1.SelectedTab = TabPage1
        '    End If
        'Else
        '    ERROR_tx_Remu.Visible = True
        '    Tx_Remu.Focus()
        '    MessageBox.Show("Complete la información", "Sistema de Gestion.", MessageBoxButtons.OK)
        'End If

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

        ''recupero del portapapeles la imagen por defecto
        'Dim data As IDataObject
        'data = Clipboard.GetDataObject
        'Dim bmap As Bitmap
        'If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
        '    bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
        '    Me.PictureBox1.Image = bmap
        'End If


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
        Validaciones.Restricciones_textbox(e, "Entero", tx_dni_emp)
    End Sub


 
    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If form_procedencia = "alta" Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea dar de alta al Empleado?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Dim valido As String = "si"
                validar_vacio(valido)
                If valido = "si" Then
                    DAempleado.Empleado_Alta(tx_dni_emp.Text, tx_nom_emp.Text, tx_ape_emp.Text, tx_dir_emp.Text, tx_tel_emp.Text, tx_cel_emp.Text, tx_mail_emp.Text)
                    MessageBox.Show("Lo datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Empleado_modificar.recuperar_empleados()
                    limpiar_deshabilitar()
                End If
            End If
        Else
            'aqui modifico
            Dim result As DialogResult
            result = MessageBox.Show("¿Desea modificar el Empleado?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                DAempleado.Empleado_Modificar(empleado_id, tx_dni_emp.Text, tx_nom_emp.Text, tx_ape_emp.Text, tx_dir_emp.Text, tx_tel_emp.Text, tx_cel_emp.Text, tx_mail_emp.Text)
                MessageBox.Show("Lo datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Empleado_modificar.recuperar_empleados()
                Me.Close()
            End If
        End If
    End Sub


    Private Function validar_vacio(ByRef valido As String)
        'Dim valido = "si"
        If tx_nom_emp.Text <> "" Then
            If tx_ape_emp.Text <> "" Then
                If tx_dni_emp.Text <> "" Then
                    'valido que no exista
                    Dim valido_empleado As New DataSet
                    valido_empleado = DAempleado.Empleado_buscardni(Me.tx_dni_emp.Text)
                    If valido_empleado.Tables(0).Rows.Count = 0 Then
                        valido = "si"
                    Else
                        valido = "no"
                        ERROR_tx_dni_emp.Visible = True
                        MessageBox.Show("Error, el empleado ya existe, modifique Documento.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    valido = "no"
                    ERROR_tx_dni_emp.Visible = True
                    MessageBox.Show("Error, Complete la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                valido = "no"
                ERROR_tx_ape_emp.Visible = True
                MessageBox.Show("Error, Complete la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            valido = "no"
            ERROR_tx_nom_emp.Visible = True
            MessageBox.Show("Error, Complete la información solicitada.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return (valido)
    End Function

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        If form_procedencia = "modificar" Then
            Me.Close()
        Else
            limpiar_deshabilitar()
            Me.TabControl1.SelectedTab = TabPage1
            'B.Enabled = True
            'Bo_cancelar.Enabled = True
        End If
        
    End Sub
End Class