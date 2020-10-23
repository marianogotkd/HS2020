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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lb_dir = New System.Windows.Forms.Label()
        Me.lb_tel = New System.Windows.Forms.Label()
        Me.lb_mail = New System.Windows.Forms.Label()
        Me.tx_mail_emp = New System.Windows.Forms.TextBox()
        Me.tx_tel_emp = New System.Windows.Forms.TextBox()
        Me.tx_dir_emp = New System.Windows.Forms.TextBox()
        Me.tx_cel_emp = New System.Windows.Forms.TextBox()
        Me.lb_cel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bo_exportar = New System.Windows.Forms.Button()
        Me.Bo_cargar = New System.Windows.Forms.Button()
        Me.Bo_deshacer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ERROR_tx_dni_emp = New System.Windows.Forms.PictureBox()
        Me.ERROR_tx_nom_emp = New System.Windows.Forms.PictureBox()
        Me.ERROR_tx_ape_emp = New System.Windows.Forms.PictureBox()
        Me.lb_ape = New System.Windows.Forms.Label()
        Me.tx_dni_emp = New System.Windows.Forms.TextBox()
        Me.lb_nom = New System.Windows.Forms.Label()
        Me.tx_nom_emp = New System.Windows.Forms.TextBox()
        Me.lb_dni = New System.Windows.Forms.Label()
        Me.tx_ape_emp = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(427, 291)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(419, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del Empleado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lb_dir)
        Me.GroupBox3.Controls.Add(Me.lb_tel)
        Me.GroupBox3.Controls.Add(Me.lb_mail)
        Me.GroupBox3.Controls.Add(Me.tx_mail_emp)
        Me.GroupBox3.Controls.Add(Me.tx_tel_emp)
        Me.GroupBox3.Controls.Add(Me.tx_dir_emp)
        Me.GroupBox3.Controls.Add(Me.tx_cel_emp)
        Me.GroupBox3.Controls.Add(Me.lb_cel)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(390, 129)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contacto"
        '
        'lb_dir
        '
        Me.lb_dir.AutoSize = True
        Me.lb_dir.Location = New System.Drawing.Point(57, 22)
        Me.lb_dir.Name = "lb_dir"
        Me.lb_dir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lb_dir.Size = New System.Drawing.Size(49, 13)
        Me.lb_dir.TabIndex = 260
        Me.lb_dir.Text = "Domicilio"
        '
        'lb_tel
        '
        Me.lb_tel.AutoSize = True
        Me.lb_tel.Location = New System.Drawing.Point(57, 74)
        Me.lb_tel.Name = "lb_tel"
        Me.lb_tel.Size = New System.Drawing.Size(49, 13)
        Me.lb_tel.TabIndex = 254
        Me.lb_tel.Text = "Telefono"
        '
        'lb_mail
        '
        Me.lb_mail.AutoSize = True
        Me.lb_mail.Location = New System.Drawing.Point(71, 48)
        Me.lb_mail.Name = "lb_mail"
        Me.lb_mail.Size = New System.Drawing.Size(35, 13)
        Me.lb_mail.TabIndex = 252
        Me.lb_mail.Text = "E-mail"
        '
        'tx_mail_emp
        '
        Me.tx_mail_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_mail_emp.Location = New System.Drawing.Point(112, 45)
        Me.tx_mail_emp.MaxLength = 50
        Me.tx_mail_emp.Name = "tx_mail_emp"
        Me.tx_mail_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_mail_emp.TabIndex = 1
        Me.tx_mail_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_tel_emp
        '
        Me.tx_tel_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_tel_emp.Location = New System.Drawing.Point(112, 71)
        Me.tx_tel_emp.MaxLength = 50
        Me.tx_tel_emp.Name = "tx_tel_emp"
        Me.tx_tel_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_tel_emp.TabIndex = 2
        Me.tx_tel_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_dir_emp
        '
        Me.tx_dir_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_dir_emp.Location = New System.Drawing.Point(112, 19)
        Me.tx_dir_emp.MaxLength = 50
        Me.tx_dir_emp.Name = "tx_dir_emp"
        Me.tx_dir_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_dir_emp.TabIndex = 0
        Me.tx_dir_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_cel_emp
        '
        Me.tx_cel_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_cel_emp.Location = New System.Drawing.Point(112, 97)
        Me.tx_cel_emp.MaxLength = 50
        Me.tx_cel_emp.Name = "tx_cel_emp"
        Me.tx_cel_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_cel_emp.TabIndex = 3
        Me.tx_cel_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_cel
        '
        Me.lb_cel.AutoSize = True
        Me.lb_cel.Location = New System.Drawing.Point(67, 100)
        Me.lb_cel.Name = "lb_cel"
        Me.lb_cel.Size = New System.Drawing.Size(39, 13)
        Me.lb_cel.TabIndex = 261
        Me.lb_cel.Text = "Celular"
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
        Me.GroupBox2.Visible = False
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
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_dni_emp)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_nom_emp)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_ape_emp)
        Me.GroupBox1.Controls.Add(Me.lb_ape)
        Me.GroupBox1.Controls.Add(Me.tx_dni_emp)
        Me.GroupBox1.Controls.Add(Me.lb_nom)
        Me.GroupBox1.Controls.Add(Me.tx_nom_emp)
        Me.GroupBox1.Controls.Add(Me.lb_dni)
        Me.GroupBox1.Controls.Add(Me.tx_ape_emp)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'ERROR_tx_dni_emp
        '
        Me.ERROR_tx_dni_emp.Image = CType(resources.GetObject("ERROR_tx_dni_emp.Image"), System.Drawing.Image)
        Me.ERROR_tx_dni_emp.Location = New System.Drawing.Point(343, 34)
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
        Me.ERROR_tx_nom_emp.Location = New System.Drawing.Point(343, 58)
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
        Me.ERROR_tx_ape_emp.Location = New System.Drawing.Point(343, 84)
        Me.ERROR_tx_ape_emp.Name = "ERROR_tx_ape_emp"
        Me.ERROR_tx_ape_emp.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_ape_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_ape_emp.TabIndex = 256
        Me.ERROR_tx_ape_emp.TabStop = False
        Me.ERROR_tx_ape_emp.Visible = False
        '
        'lb_ape
        '
        Me.lb_ape.AutoSize = True
        Me.lb_ape.Location = New System.Drawing.Point(70, 87)
        Me.lb_ape.Name = "lb_ape"
        Me.lb_ape.Size = New System.Drawing.Size(44, 13)
        Me.lb_ape.TabIndex = 246
        Me.lb_ape.Text = "Apellido"
        '
        'tx_dni_emp
        '
        Me.tx_dni_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_dni_emp.Location = New System.Drawing.Point(120, 32)
        Me.tx_dni_emp.MaxLength = 10
        Me.tx_dni_emp.Name = "tx_dni_emp"
        Me.tx_dni_emp.Size = New System.Drawing.Size(217, 20)
        Me.tx_dni_emp.TabIndex = 0
        Me.tx_dni_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_nom
        '
        Me.lb_nom.AutoSize = True
        Me.lb_nom.Location = New System.Drawing.Point(70, 61)
        Me.lb_nom.Name = "lb_nom"
        Me.lb_nom.Size = New System.Drawing.Size(44, 13)
        Me.lb_nom.TabIndex = 247
        Me.lb_nom.Text = "Nombre"
        '
        'tx_nom_emp
        '
        Me.tx_nom_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_nom_emp.Location = New System.Drawing.Point(120, 58)
        Me.tx_nom_emp.MaxLength = 50
        Me.tx_nom_emp.Name = "tx_nom_emp"
        Me.tx_nom_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_nom_emp.TabIndex = 1
        Me.tx_nom_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_dni
        '
        Me.lb_dni.AutoSize = True
        Me.lb_dni.Location = New System.Drawing.Point(52, 34)
        Me.lb_dni.Name = "lb_dni"
        Me.lb_dni.Size = New System.Drawing.Size(62, 13)
        Me.lb_dni.TabIndex = 250
        Me.lb_dni.Text = "Documento"
        '
        'tx_ape_emp
        '
        Me.tx_ape_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_ape_emp.Location = New System.Drawing.Point(120, 84)
        Me.tx_ape_emp.MaxLength = 50
        Me.tx_ape_emp.Name = "tx_ape_emp"
        Me.tx_ape_emp.Size = New System.Drawing.Size(216, 20)
        Me.tx_ape_emp.TabIndex = 2
        Me.tx_ape_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Cancelar.Location = New System.Drawing.Point(105, 318)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Cancelar.TabIndex = 1
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Cancelar, "Cancelar")
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(235, 318)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Aceptar.TabIndex = 0
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Aceptar, "Guardar")
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Empleado_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(447, 367)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Empleado_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Empleado"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents lb_cel As System.Windows.Forms.Label
    Friend WithEvents lb_dir As System.Windows.Forms.Label
    Friend WithEvents tx_cel_emp As System.Windows.Forms.TextBox
    Friend WithEvents Bo_exportar As System.Windows.Forms.Button
    Friend WithEvents Bo_cargar As System.Windows.Forms.Button
    Friend WithEvents Bo_deshacer As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
