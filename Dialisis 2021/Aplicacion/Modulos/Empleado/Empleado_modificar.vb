Imports System.IO
Imports System.Data.OleDb

Public Class Empleado_modificar

    Dim DAempleado As New Datos.Empleado
    Private Sub BO_Buscar_dni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Buscar_dni.Click
        buscar_empdni()
    End Sub

    Private Sub buscar_empdni()
        If tx_dni_modif.Text <> "" Then
            Me.DataGrid_empleado.Rows.Clear()
            Dim DS As New DataSet
            DS = DAempleado.Empleado_buscardni(Me.tx_dni_modif.Text)
            If DS.Tables(0).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DataGrid_empleado.Rows().Add()
                    DataGrid_empleado.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                    DataGrid_empleado.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(1) 'documento
                    DataGrid_empleado.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(3) 'apellido
                    DataGrid_empleado.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(2) 'nombre
                    DataGrid_empleado.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(5) 'domicilio
                    DataGrid_empleado.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(6) 'tel
                    fila = fila + 1
                End While
            Else
                IM_ERROR_cliente.Visible = True
                LB_ERROR_cliente.Visible = True
            End If
            Me.tx_dni_modif.Select()
        End If
    End Sub

    Private Sub Bo_buscar_ape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_buscar_ape.Click
        buscar_empape()
    End Sub

    Private Sub buscar_empape()
        Me.DataGrid_empleado.Rows.Clear()
        Dim DS As New DataSet
        DS = DAempleado.Empleado_buscarape(Me.tx_ape_modif.Text)
        If tx_ape_modif.Text <> "" Then

            If DS.Tables(0).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DataGrid_empleado.Rows().Add()
                    DataGrid_empleado.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                    DataGrid_empleado.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(1) 'documento
                    DataGrid_empleado.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(3) 'apellido
                    DataGrid_empleado.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(2) 'nombre
                    DataGrid_empleado.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(5) 'mail
                    DataGrid_empleado.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(6) 'tel
                    fila = fila + 1
                End While
            End If

        Else
            If DS.Tables(1).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DataGrid_empleado.Rows().Add()
                    DataGrid_empleado.Rows(fila).Cells(0).Value = DS.Tables(0).Rows(fila).Item(0) 'ID
                    DataGrid_empleado.Rows(fila).Cells(1).Value = DS.Tables(0).Rows(fila).Item(1) 'documento
                    DataGrid_empleado.Rows(fila).Cells(2).Value = DS.Tables(0).Rows(fila).Item(3) 'apellido
                    DataGrid_empleado.Rows(fila).Cells(3).Value = DS.Tables(0).Rows(fila).Item(2) 'nombre
                    DataGrid_empleado.Rows(fila).Cells(4).Value = DS.Tables(0).Rows(fila).Item(5) 'mail
                    DataGrid_empleado.Rows(fila).Cells(5).Value = DS.Tables(0).Rows(fila).Item(6) 'tel
                    fila = fila + 1
                End While
            End If
        End If
            Me.tx_ape_modif.Focus()
            Me.tx_ape_modif.SelectAll()
    End Sub

    Private Sub BO_empleado_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_empleado_modificar.Click

        If Me.DataGrid_empleado.CurrentRow IsNot Nothing Then

            Dim documentoselec As Integer = DataGrid_empleado.SelectedCells(1).Value
            If documentoselec <> 0 Then
                tx_dni_emp.Text = DataGrid_empleado.SelectedCells(1).Value
                TabPage2.Enabled = True
                Me.TabControl1.SelectedTab = TabPage2
                GroupBox1.Enabled = True 'datos personales
                recuperar_datos_empleado()
                Bo_guardar.Enabled = True
                Bo_cancelar.Enabled = True
            Else
                MsgBox("Seleccione un empleado", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un empleado", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub recuperar_datos_empleado()
        'PESTAÑA empleados//////////////////////////////////////////////////////////////////////////////////
        Dim ds_empleado As New DataSet
        ds_empleado = DAempleado.Empleado_obtenerDatos(tx_dni_emp.Text)

        'cargo en los textbox los datos recuperados
        tx_nom_emp.Text = ds_empleado.Tables(0).Rows(0).Item(2) 'nombre
        tx_ape_emp.Text = ds_empleado.Tables(0).Rows(0).Item(3) 'apellido
        Dim fecha_alta As Date = ds_empleado.Tables(0).Rows(0).Item(4)
        DT_fechanac_emp.Text = fecha_alta.ToString("dd/MM/yyyy")
        tx_dir_emp.Text = ds_empleado.Tables(0).Rows(0).Item(5) 'dir
        tx_tel_emp.Text = ds_empleado.Tables(0).Rows(0).Item(6) 'tel
        tx_cel_emp.Text = ds_empleado.Tables(0).Rows(0).Item(7) 'cel
        tx_mail_emp.Text = ds_empleado.Tables(0).Rows(0).Item(8) 'mail
        Dim emp_remu As Decimal = ds_empleado.Tables(0).Rows(0).Item(10)
        Tx_Remu.Text = emp_remu.ToString
        'recupero foto

        Dim arrImg As Byte() = DirectCast(ds_empleado.Tables(0).Rows(0).Item(9), Byte())
        Dim ms As New MemoryStream(arrImg)
        Dim img As Image = Image.FromStream(ms)
        PictureBox1.Image = img

    End Sub

    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        'validamos x lo menos q tenga apellido nombre y dni
        If tx_ape_emp.Text <> "" Then
            ERROR_tx_ape_emp.Visible = False
            If tx_nom_emp.Text <> "" Then
                ERROR_tx_nom_emp.Visible = False
                If tx_dni_emp.Text <> "" Then
                    ERROR_tx_dni_emp.Visible = False
                    Dim result As DialogResult
                    result = MessageBox.Show("¿Desea modificar al Empleado?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
                    If result = DialogResult.OK Then
                        Dim valido_cliente As New DataSet
                        valido_cliente = DAempleado.Empleado_buscardni(Me.tx_dni_emp.Text)
                        If valido_cliente.Tables(0).Rows.Count <> 0 Then 'si lo encuentro recien puedo editar
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
                            Dim empleado_id As Integer = DataGrid_empleado.CurrentRow.Cells(0).Value
                            DAempleado.Empleado_Modificar(empleado_id, tx_dni_emp.Text, tx_nom_emp.Text, tx_ape_emp.Text, DT_fechanac_emp.Value, tx_dir_emp.Text, tx_tel_emp.Text, tx_cel_emp.Text, tx_mail_emp.Text, empleado_foto, Tx_Remu.Text)
                            MessageBox.Show("El empleado se modifico correctamente", "Sistema de Gestion")
                            limpiar_deshabilitar()
                            Me.TabControl1.SelectedTab = TabPage1
                            TabPage2.Enabled = False
                            tx_ape_modif.Text = Nothing
                            tx_dni_modif.Text = Nothing
                        Else
                            MessageBox.Show("El empleado no existe", "Sistema de Gestion.")
                            ERROR_tx_dni_emp.Visible = True
                            tx_dni_emp.Focus()
                            Me.TabControl1.SelectedTab = TabPage2
                        End If
                    End If
                Else
                    MessageBox.Show("Complete la información", "Sistema de Gestion.")
                    ERROR_tx_dni_emp.Visible = True
                    tx_dni_emp.Focus()
                    Me.TabControl1.SelectedTab = TabPage2
                End If
            Else
                MessageBox.Show("Complete la información", "Sistema de Gestion.")
                ERROR_tx_nom_emp.Visible = True
                tx_nom_emp.Focus()
                Me.TabControl1.SelectedTab = TabPage2
            End If
        Else
            MessageBox.Show("Complete la información", "Sistema de Gestion.")
            ERROR_tx_ape_emp.Visible = True
            tx_ape_emp.Focus()
            Me.TabControl1.SelectedTab = TabPage2
        End If

    End Sub

    Public Sub limpiar_deshabilitar()
        'datos personales///////////////////////////////////////////////////////////////////////////////////////////////////
        'botones de error
        ERROR_tx_ape_emp.Visible = False
        ERROR_tx_nom_emp.Visible = False
        ERROR_tx_dni_emp.Visible = False
        Bo_guardar.Enabled = False
        Bo_cancelar.Enabled = False
        tx_ape_modif.Text = Nothing
        tx_dni_modif.Text = Nothing
        'datos personales
        tx_ape_emp.Text = ""
        tx_nom_emp.Text = ""
        tx_dni_emp.Text = ""
        tx_tel_emp.Text = ""
        tx_mail_emp.Text = ""
        tx_cel_emp.Text = ""
        tx_dir_emp.Text = ""
        DT_fechanac_emp.Text = ""

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
        limpiar_deshabilitar()
        Me.TabControl1.SelectedTab = TabPage1
        TabPage2.Enabled = False
    End Sub

    Private Sub Bo_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_cargar.Click

        OpenFileDialog1.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
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

   
    Private Sub Empleado_modificar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BO_Buscar_dni.Enabled = False
        TabPage2.Enabled = False
    End Sub

    Private Sub tx_dni_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_dni_modif.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            buscar_empdni()
        End If
    End Sub

    Private Sub tx_ape_modif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_ape_modif.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'aqui valido el ENTER
            Buscar_empape()
        End If
    End Sub

    
    Private Sub tx_dni_modif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx_dni_modif.TextChanged
        If tx_dni_modif.Text = Nothing Then
            BO_Buscar_dni.Enabled = False
        Else
            BO_Buscar_dni.Enabled = True
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

   
End Class