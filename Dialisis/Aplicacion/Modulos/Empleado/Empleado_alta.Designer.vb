<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado_alta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleado_alta))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bo_exportar = New System.Windows.Forms.Button()
        Me.Bo_cargar = New System.Windows.Forms.Button()
        Me.Bo_deshacer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ERROR_tx_Remu = New System.Windows.Forms.PictureBox()
        Me.Combo_tpoMonto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tx_Remu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_Funcion = New System.Windows.Forms.TextBox()
        Me.tx_cel_emp = New System.Windows.Forms.TextBox()
        Me.tx_dir_emp = New System.Windows.Forms.TextBox()
        Me.DT_fechanac_emp = New System.Windows.Forms.DateTimePicker()
        Me.lb_cel = New System.Windows.Forms.Label()
        Me.lb_dir = New System.Windows.Forms.Label()
        Me.lb_fechanac = New System.Windows.Forms.Label()
        Me.ERROR_tx_dni_emp = New System.Windows.Forms.PictureBox()
        Me.ERROR_tx_nom_emp = New System.Windows.Forms.PictureBox()
        Me.ERROR_tx_ape_emp = New System.Windows.Forms.PictureBox()
        Me.tx_tel_emp = New System.Windows.Forms.TextBox()
        Me.tx_mail_emp = New System.Windows.Forms.TextBox()
        Me.lb_ape = New System.Windows.Forms.Label()
        Me.tx_dni_emp = New System.Windows.Forms.TextBox()
        Me.lb_nom = New System.Windows.Forms.Label()
        Me.tx_nom_emp = New System.Windows.Forms.TextBox()
        Me.lb_dni = New System.Windows.Forms.Label()
        Me.tx_ape_emp = New System.Windows.Forms.TextBox()
        Me.lb_mail = New System.Windows.Forms.Label()
        Me.lb_tel = New System.Windows.Forms.Label()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ERROR_tx_Remu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_dni_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_nom_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_ape_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(865, 326)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(857, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del Empleado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bo_exportar)
        Me.GroupBox2.Controls.Add(Me.Bo_cargar)
        Me.GroupBox2.Controls.Add(Me.Bo_deshacer)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(644, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 279)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Foto del Empleado"
        '
        'Bo_exportar
        '
        Me.Bo_exportar.Image = CType(resources.GetObject("Bo_exportar.Image"), System.Drawing.Image)
        Me.Bo_exportar.Location = New System.Drawing.Point(171, 237)
        Me.Bo_exportar.Name = "Bo_exportar"
        Me.Bo_exportar.Size = New System.Drawing.Size(30, 30)
        Me.Bo_exportar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Bo_exportar, "Buscar Foto")
        Me.Bo_exportar.UseVisualStyleBackColor = True
        '
        'Bo_cargar
        '
        Me.Bo_cargar.Image = CType(resources.GetObject("Bo_cargar.Image"), System.Drawing.Image)
        Me.Bo_cargar.Location = New System.Drawing.Point(135, 237)
        Me.Bo_cargar.Name = "Bo_cargar"
        Me.Bo_cargar.Size = New System.Drawing.Size(30, 30)
        Me.Bo_cargar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Bo_cargar, "Tomar Foto")
        Me.Bo_cargar.UseVisualStyleBackColor = True
        '
        'Bo_deshacer
        '
        Me.Bo_deshacer.Image = CType(resources.GetObject("Bo_deshacer.Image"), System.Drawing.Image)
        Me.Bo_deshacer.Location = New System.Drawing.Point(99, 237)
        Me.Bo_deshacer.Name = "Bo_deshacer"
        Me.Bo_deshacer.Size = New System.Drawing.Size(30, 30)
        Me.Bo_deshacer.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Bo_deshacer, "Deshacer Foto")
        Me.Bo_deshacer.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_Remu)
        Me.GroupBox1.Controls.Add(Me.Combo_tpoMonto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Tx_Remu)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tx_Funcion)
        Me.GroupBox1.Controls.Add(Me.tx_cel_emp)
        Me.GroupBox1.Controls.Add(Me.tx_dir_emp)
        Me.GroupBox1.Controls.Add(Me.DT_fechanac_emp)
        Me.GroupBox1.Controls.Add(Me.lb_cel)
        Me.GroupBox1.Controls.Add(Me.lb_dir)
        Me.GroupBox1.Controls.Add(Me.lb_fechanac)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_dni_emp)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_nom_emp)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_ape_emp)
        Me.GroupBox1.Controls.Add(Me.tx_tel_emp)
        Me.GroupBox1.Controls.Add(Me.tx_mail_emp)
        Me.GroupBox1.Controls.Add(Me.lb_ape)
        Me.GroupBox1.Controls.Add(Me.tx_dni_emp)
        Me.GroupBox1.Controls.Add(Me.lb_nom)
        Me.GroupBox1.Controls.Add(Me.tx_nom_emp)
        Me.GroupBox1.Controls.Add(Me.lb_dni)
        Me.GroupBox1.Controls.Add(Me.tx_ape_emp)
        Me.GroupBox1.Controls.Add(Me.lb_mail)
        Me.GroupBox1.Controls.Add(Me.lb_tel)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'ERROR_tx_Remu
        '
        Me.ERROR_tx_Remu.Image = CType(resources.GetObject("ERROR_tx_Remu.Image"), System.Drawing.Image)
        Me.ERROR_tx_Remu.Location = New System.Drawing.Point(564, 153)
        Me.ERROR_tx_Remu.Name = "ERROR_tx_Remu"
        Me.ERROR_tx_Remu.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_Remu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_Remu.TabIndex = 272
        Me.ERROR_tx_Remu.TabStop = False
        Me.ERROR_tx_Remu.Visible = False
        '
        'Combo_tpoMonto
        '
        Me.Combo_tpoMonto.FormattingEnabled = True
        Me.Combo_tpoMonto.Items.AddRange(New Object() {"Fijo", "Variable"})
        Me.Combo_tpoMonto.Location = New System.Drawing.Point(440, 107)
        Me.Combo_tpoMonto.Name = "Combo_tpoMonto"
        Me.Combo_tpoMonto.Size = New System.Drawing.Size(121, 21)
        Me.Combo_tpoMonto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "Tipo de Monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 268
        Me.Label2.Text = "Remuneracion"
        '
        'Tx_Remu
        '
        Me.Tx_Remu.Location = New System.Drawing.Point(440, 150)
        Me.Tx_Remu.Name = "Tx_Remu"
        Me.Tx_Remu.Size = New System.Drawing.Size(118, 20)
        Me.Tx_Remu.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(358, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 266
        Me.Label1.Text = "Funcion"
        '
        'tx_Funcion
        '
        Me.tx_Funcion.Location = New System.Drawing.Point(408, 64)
        Me.tx_Funcion.Name = "tx_Funcion"
        Me.tx_Funcion.Size = New System.Drawing.Size(190, 20)
        Me.tx_Funcion.TabIndex = 3
        '
        'tx_cel_emp
        '
        Me.tx_cel_emp.Location = New System.Drawing.Point(403, 223)
        Me.tx_cel_emp.Name = "tx_cel_emp"
        Me.tx_cel_emp.Size = New System.Drawing.Size(195, 20)
        Me.tx_cel_emp.TabIndex = 10
        '
        'tx_dir_emp
        '
        Me.tx_dir_emp.Location = New System.Drawing.Point(98, 150)
        Me.tx_dir_emp.Name = "tx_dir_emp"
        Me.tx_dir_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_dir_emp.TabIndex = 6
        '
        'DT_fechanac_emp
        '
        Me.DT_fechanac_emp.Location = New System.Drawing.Point(98, 107)
        Me.DT_fechanac_emp.Name = "DT_fechanac_emp"
        Me.DT_fechanac_emp.Size = New System.Drawing.Size(216, 20)
        Me.DT_fechanac_emp.TabIndex = 4
        '
        'lb_cel
        '
        Me.lb_cel.AutoSize = True
        Me.lb_cel.Location = New System.Drawing.Point(358, 226)
        Me.lb_cel.Name = "lb_cel"
        Me.lb_cel.Size = New System.Drawing.Size(39, 13)
        Me.lb_cel.TabIndex = 261
        Me.lb_cel.Text = "Celular"
        '
        'lb_dir
        '
        Me.lb_dir.AutoSize = True
        Me.lb_dir.Location = New System.Drawing.Point(13, 153)
        Me.lb_dir.Name = "lb_dir"
        Me.lb_dir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lb_dir.Size = New System.Drawing.Size(49, 13)
        Me.lb_dir.TabIndex = 260
        Me.lb_dir.Text = "Domicilio"
        '
        'lb_fechanac
        '
        Me.lb_fechanac.AutoSize = True
        Me.lb_fechanac.Location = New System.Drawing.Point(13, 110)
        Me.lb_fechanac.Name = "lb_fechanac"
        Me.lb_fechanac.Size = New System.Drawing.Size(78, 13)
        Me.lb_fechanac.TabIndex = 259
        Me.lb_fechanac.Text = "Fecha de Nac."
        '
        'ERROR_tx_dni_emp
        '
        Me.ERROR_tx_dni_emp.Image = CType(resources.GetObject("ERROR_tx_dni_emp.Image"), System.Drawing.Image)
        Me.ERROR_tx_dni_emp.Location = New System.Drawing.Point(321, 68)
        Me.ERROR_tx_dni_emp.Name = "ERROR_tx_dni_emp"
        Me.ERROR_tx_dni_emp.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_dni_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_dni_emp.TabIndex = 258
        Me.ERROR_tx_dni_emp.TabStop = False
        Me.ERROR_tx_dni_emp.Visible = False
        '
        'ERROR_tx_nom_emp
        '
        Me.ERROR_tx_nom_emp.Image = CType(resources.GetObject("ERROR_tx_nom_emp.Image"), System.Drawing.Image)
        Me.ERROR_tx_nom_emp.Location = New System.Drawing.Point(604, 27)
        Me.ERROR_tx_nom_emp.Name = "ERROR_tx_nom_emp"
        Me.ERROR_tx_nom_emp.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_nom_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_nom_emp.TabIndex = 257
        Me.ERROR_tx_nom_emp.TabStop = False
        Me.ERROR_tx_nom_emp.Visible = False
        '
        'ERROR_tx_ape_emp
        '
        Me.ERROR_tx_ape_emp.Image = CType(resources.GetObject("ERROR_tx_ape_emp.Image"), System.Drawing.Image)
        Me.ERROR_tx_ape_emp.Location = New System.Drawing.Point(321, 27)
        Me.ERROR_tx_ape_emp.Name = "ERROR_tx_ape_emp"
        Me.ERROR_tx_ape_emp.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_ape_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_ape_emp.TabIndex = 256
        Me.ERROR_tx_ape_emp.TabStop = False
        Me.ERROR_tx_ape_emp.Visible = False
        '
        'tx_tel_emp
        '
        Me.tx_tel_emp.Location = New System.Drawing.Point(98, 223)
        Me.tx_tel_emp.Name = "tx_tel_emp"
        Me.tx_tel_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_tel_emp.TabIndex = 9
        '
        'tx_mail_emp
        '
        Me.tx_mail_emp.Location = New System.Drawing.Point(98, 185)
        Me.tx_mail_emp.Name = "tx_mail_emp"
        Me.tx_mail_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_mail_emp.TabIndex = 8
        '
        'lb_ape
        '
        Me.lb_ape.AutoSize = True
        Me.lb_ape.Location = New System.Drawing.Point(13, 27)
        Me.lb_ape.Name = "lb_ape"
        Me.lb_ape.Size = New System.Drawing.Size(44, 13)
        Me.lb_ape.TabIndex = 246
        Me.lb_ape.Text = "Apellido"
        '
        'tx_dni_emp
        '
        Me.tx_dni_emp.Location = New System.Drawing.Point(98, 66)
        Me.tx_dni_emp.Name = "tx_dni_emp"
        Me.tx_dni_emp.Size = New System.Drawing.Size(217, 20)
        Me.tx_dni_emp.TabIndex = 2
        '
        'lb_nom
        '
        Me.lb_nom.AutoSize = True
        Me.lb_nom.Location = New System.Drawing.Point(358, 30)
        Me.lb_nom.Name = "lb_nom"
        Me.lb_nom.Size = New System.Drawing.Size(44, 13)
        Me.lb_nom.TabIndex = 247
        Me.lb_nom.Text = "Nombre"
        '
        'tx_nom_emp
        '
        Me.tx_nom_emp.Location = New System.Drawing.Point(408, 27)
        Me.tx_nom_emp.Name = "tx_nom_emp"
        Me.tx_nom_emp.Size = New System.Drawing.Size(190, 20)
        Me.tx_nom_emp.TabIndex = 1
        '
        'lb_dni
        '
        Me.lb_dni.AutoSize = True
        Me.lb_dni.Location = New System.Drawing.Point(13, 67)
        Me.lb_dni.Name = "lb_dni"
        Me.lb_dni.Size = New System.Drawing.Size(62, 13)
        Me.lb_dni.TabIndex = 250
        Me.lb_dni.Text = "Documento"
        '
        'tx_ape_emp
        '
        Me.tx_ape_emp.Location = New System.Drawing.Point(98, 27)
        Me.tx_ape_emp.Name = "tx_ape_emp"
        Me.tx_ape_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_ape_emp.TabIndex = 0
        '
        'lb_mail
        '
        Me.lb_mail.AutoSize = True
        Me.lb_mail.Location = New System.Drawing.Point(13, 188)
        Me.lb_mail.Name = "lb_mail"
        Me.lb_mail.Size = New System.Drawing.Size(35, 13)
        Me.lb_mail.TabIndex = 252
        Me.lb_mail.Text = "E-mail"
        '
        'lb_tel
        '
        Me.lb_tel.AutoSize = True
        Me.lb_tel.Location = New System.Drawing.Point(13, 226)
        Me.lb_tel.Name = "lb_tel"
        Me.lb_tel.Size = New System.Drawing.Size(49, 13)
        Me.lb_tel.TabIndex = 254
        Me.lb_tel.Text = "Telefono"
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(837, 341)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(40, 40)
        Me.Bo_guardar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Bo_guardar, "Guardar")
        Me.Bo_guardar.UseVisualStyleBackColor = True
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(791, 341)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.Bo_cancelar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Bo_cancelar, "Cancelar")
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Empleado_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.Bo_cancelar)
        Me.Controls.Add(Me.Bo_guardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Empleado_alta"
        Me.Text = "Empleado_alta"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ERROR_tx_Remu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_dni_emp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_nom_emp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_ape_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ERROR_tx_dni_emp As System.Windows.Forms.PictureBox
    Friend WithEvents ERROR_tx_nom_emp As System.Windows.Forms.PictureBox
    Friend WithEvents ERROR_tx_ape_emp As System.Windows.Forms.PictureBox
    Friend WithEvents tx_tel_emp As System.Windows.Forms.TextBox
    Friend WithEvents tx_mail_emp As System.Windows.Forms.TextBox
    Friend WithEvents lb_ape As System.Windows.Forms.Label
    Friend WithEvents tx_dni_emp As System.Windows.Forms.TextBox
    Friend WithEvents lb_nom As System.Windows.Forms.Label
    Friend WithEvents tx_nom_emp As System.Windows.Forms.TextBox
    Friend WithEvents lb_dni As System.Windows.Forms.Label
    Friend WithEvents tx_ape_emp As System.Windows.Forms.TextBox
    Friend WithEvents lb_mail As System.Windows.Forms.Label
    Friend WithEvents lb_tel As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tx_dir_emp As System.Windows.Forms.TextBox
    Friend WithEvents DT_fechanac_emp As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_cel As System.Windows.Forms.Label
    Friend WithEvents lb_dir As System.Windows.Forms.Label
    Friend WithEvents lb_fechanac As System.Windows.Forms.Label
    Friend WithEvents tx_cel_emp As System.Windows.Forms.TextBox
    Friend WithEvents Bo_guardar As System.Windows.Forms.Button
    Friend WithEvents Bo_cancelar As System.Windows.Forms.Button
    Friend WithEvents Bo_exportar As System.Windows.Forms.Button
    Friend WithEvents Bo_cargar As System.Windows.Forms.Button
    Friend WithEvents Bo_deshacer As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Combo_tpoMonto As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tx_Remu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tx_Funcion As System.Windows.Forms.TextBox
    Friend WithEvents ERROR_tx_Remu As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
