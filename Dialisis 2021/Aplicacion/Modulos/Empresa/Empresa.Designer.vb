<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_dire = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_telefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Eslogan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_mail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bo_exportar = New System.Windows.Forms.Button()
        Me.Bo_deshacer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.TextBox_cuit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.label_ast1 = New System.Windows.Forms.Label()
        Me.Label_ast2 = New System.Windows.Forms.Label()
        Me.Label_ast3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de La Empresa"
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nombre.Location = New System.Drawing.Point(195, 33)
        Me.TextBox_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(234, 23)
        Me.TextBox_Nombre.TabIndex = 0
        Me.TextBox_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_dire
        '
        Me.TextBox_dire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_dire.Location = New System.Drawing.Point(195, 74)
        Me.TextBox_dire.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_dire.Name = "TextBox_dire"
        Me.TextBox_dire.Size = New System.Drawing.Size(234, 23)
        Me.TextBox_dire.TabIndex = 1
        Me.TextBox_dire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Direccion"
        '
        'TextBox_telefono
        '
        Me.TextBox_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_telefono.Location = New System.Drawing.Point(195, 115)
        Me.TextBox_telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_telefono.Name = "TextBox_telefono"
        Me.TextBox_telefono.Size = New System.Drawing.Size(234, 23)
        Me.TextBox_telefono.TabIndex = 2
        Me.TextBox_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telefono"
        '
        'TextBox_Eslogan
        '
        Me.TextBox_Eslogan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Eslogan.Location = New System.Drawing.Point(195, 154)
        Me.TextBox_Eslogan.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Eslogan.Name = "TextBox_Eslogan"
        Me.TextBox_Eslogan.Size = New System.Drawing.Size(234, 23)
        Me.TextBox_Eslogan.TabIndex = 3
        Me.TextBox_Eslogan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Eslogan"
        '
        'TextBox_mail
        '
        Me.TextBox_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_mail.Location = New System.Drawing.Point(195, 192)
        Me.TextBox_mail.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_mail.Name = "TextBox_mail"
        Me.TextBox_mail.Size = New System.Drawing.Size(234, 23)
        Me.TextBox_mail.TabIndex = 4
        Me.TextBox_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 195)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mail"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bo_exportar)
        Me.GroupBox2.Controls.Add(Me.Bo_deshacer)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(490, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(268, 291)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Logo de la Empresa"
        '
        'Bo_exportar
        '
        Me.Bo_exportar.Image = CType(resources.GetObject("Bo_exportar.Image"), System.Drawing.Image)
        Me.Bo_exportar.Location = New System.Drawing.Point(141, 246)
        Me.Bo_exportar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_exportar.Name = "Bo_exportar"
        Me.Bo_exportar.Size = New System.Drawing.Size(99, 37)
        Me.Bo_exportar.TabIndex = 0
        Me.Bo_exportar.Text = "Examinar"
        Me.Bo_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bo_exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_exportar, "Examinar nueva foto")
        Me.Bo_exportar.UseVisualStyleBackColor = True
        '
        'Bo_deshacer
        '
        Me.Bo_deshacer.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Bo_deshacer.Location = New System.Drawing.Point(41, 246)
        Me.Bo_deshacer.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_deshacer.Name = "Bo_deshacer"
        Me.Bo_deshacer.Size = New System.Drawing.Size(92, 37)
        Me.Bo_deshacer.TabIndex = 1
        Me.Bo_deshacer.Text = "Quitar"
        Me.Bo_deshacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bo_deshacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_deshacer, "Quitar foto cargada")
        Me.Bo_deshacer.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Aplicacion.My.Resources.Resources.Logo_empresa
        Me.PictureBox1.Location = New System.Drawing.Point(23, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(467, 16)
        Me.Bo_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(138, 48)
        Me.Bo_cancelar.TabIndex = 1
        Me.Bo_cancelar.Text = "Cancelar"
        Me.Bo_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bo_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_cancelar, "Cancelar")
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(608, 16)
        Me.Bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(128, 49)
        Me.Bo_guardar.TabIndex = 0
        Me.Bo_guardar.Text = "Guardar"
        Me.Bo_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_guardar, "Guardar")
        Me.Bo_guardar.UseVisualStyleBackColor = True
        '
        'TextBox_cuit
        '
        Me.TextBox_cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_cuit.Location = New System.Drawing.Point(195, 232)
        Me.TextBox_cuit.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_cuit.Name = "TextBox_cuit"
        Me.TextBox_cuit.Size = New System.Drawing.Size(234, 23)
        Me.TextBox_cuit.TabIndex = 5
        Me.TextBox_cuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 232)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cuit"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'label_ast1
        '
        Me.label_ast1.AutoSize = True
        Me.label_ast1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ast1.ForeColor = System.Drawing.Color.Red
        Me.label_ast1.Location = New System.Drawing.Point(437, 33)
        Me.label_ast1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_ast1.Name = "label_ast1"
        Me.label_ast1.Size = New System.Drawing.Size(26, 31)
        Me.label_ast1.TabIndex = 15
        Me.label_ast1.Text = "*"
        Me.label_ast1.Visible = False
        '
        'Label_ast2
        '
        Me.Label_ast2.AutoSize = True
        Me.Label_ast2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ast2.ForeColor = System.Drawing.Color.Red
        Me.Label_ast2.Location = New System.Drawing.Point(437, 66)
        Me.Label_ast2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_ast2.Name = "Label_ast2"
        Me.Label_ast2.Size = New System.Drawing.Size(26, 31)
        Me.Label_ast2.TabIndex = 16
        Me.Label_ast2.Text = "*"
        Me.Label_ast2.Visible = False
        '
        'Label_ast3
        '
        Me.Label_ast3.AutoSize = True
        Me.Label_ast3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ast3.ForeColor = System.Drawing.Color.Red
        Me.Label_ast3.Location = New System.Drawing.Point(437, 102)
        Me.Label_ast3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_ast3.Name = "Label_ast3"
        Me.Label_ast3.Size = New System.Drawing.Size(26, 31)
        Me.Label_ast3.TabIndex = 17
        Me.Label_ast3.Text = "*"
        Me.Label_ast3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_cuit)
        Me.GroupBox1.Controls.Add(Me.Label_ast3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label_ast2)
        Me.GroupBox1.Controls.Add(Me.label_ast1)
        Me.GroupBox1.Controls.Add(Me.TextBox_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_mail)
        Me.GroupBox1.Controls.Add(Me.TextBox_dire)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_Eslogan)
        Me.GroupBox1.Controls.Add(Me.TextBox_telefono)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 292)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Empresa:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Bo_guardar)
        Me.GroupBox3.Controls.Add(Me.Bo_cancelar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 310)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(746, 71)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'Empresa
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(765, 384)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Empresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Empresa"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_dire As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Eslogan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_mail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Bo_exportar As System.Windows.Forms.Button
    Friend WithEvents Bo_deshacer As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Bo_cancelar As System.Windows.Forms.Button
    Friend WithEvents Bo_guardar As System.Windows.Forms.Button
    Friend WithEvents TextBox_cuit As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents label_ast1 As System.Windows.Forms.Label
    Friend WithEvents Label_ast2 As System.Windows.Forms.Label
    Friend WithEvents Label_ast3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
