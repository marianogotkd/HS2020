<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedor_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendedor_alta))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bo_exportar = New System.Windows.Forms.Button()
        Me.Bo_deshacer = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TX_USU_observacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TX_USU_mail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.error_nombre = New System.Windows.Forms.Label()
        Me.error_apellido = New System.Windows.Forms.Label()
        Me.error_dni = New System.Windows.Forms.Label()
        Me.TX_USU_telefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TX_USU_domicilio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TX_USU_dni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TX_USU_nom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TX_USU_ape = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Bo_exportar)
        Me.GroupBox3.Controls.Add(Me.Bo_deshacer)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(386, 1)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(268, 318)
        Me.GroupBox3.TabIndex = 132
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Foto de perfil:"
        '
        'Bo_exportar
        '
        Me.Bo_exportar.Image = CType(resources.GetObject("Bo_exportar.Image"), System.Drawing.Image)
        Me.Bo_exportar.Location = New System.Drawing.Point(141, 272)
        Me.Bo_exportar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_exportar.Name = "Bo_exportar"
        Me.Bo_exportar.Size = New System.Drawing.Size(99, 37)
        Me.Bo_exportar.TabIndex = 0
        Me.Bo_exportar.Text = "Examinar"
        Me.Bo_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bo_exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_exportar.UseVisualStyleBackColor = True
        '
        'Bo_deshacer
        '
        Me.Bo_deshacer.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Bo_deshacer.Location = New System.Drawing.Point(41, 272)
        Me.Bo_deshacer.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_deshacer.Name = "Bo_deshacer"
        Me.Bo_deshacer.Size = New System.Drawing.Size(92, 37)
        Me.Bo_deshacer.TabIndex = 1
        Me.Bo_deshacer.Text = "Quitar"
        Me.Bo_deshacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bo_deshacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_deshacer.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.Aplicacion.My.Resources.Resources.persona
        Me.PictureBox2.Location = New System.Drawing.Point(17, 35)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(235, 215)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.TX_USU_observacion)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.TX_USU_mail)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Controls.Add(Me.error_nombre)
        Me.GroupBox9.Controls.Add(Me.error_apellido)
        Me.GroupBox9.Controls.Add(Me.error_dni)
        Me.GroupBox9.Controls.Add(Me.TX_USU_telefono)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.TX_USU_domicilio)
        Me.GroupBox9.Controls.Add(Me.Label3)
        Me.GroupBox9.Controls.Add(Me.TX_USU_dni)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.TX_USU_nom)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.TX_USU_ape)
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox9.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(375, 318)
        Me.GroupBox9.TabIndex = 129
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Ingrese los datos personales:"
        '
        'TX_USU_observacion
        '
        Me.TX_USU_observacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_observacion.Location = New System.Drawing.Point(137, 259)
        Me.TX_USU_observacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_USU_observacion.Name = "TX_USU_observacion"
        Me.TX_USU_observacion.Size = New System.Drawing.Size(206, 22)
        Me.TX_USU_observacion.TabIndex = 6
        Me.TX_USU_observacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(25, 261)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Observación:"
        '
        'TX_USU_mail
        '
        Me.TX_USU_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_mail.Location = New System.Drawing.Point(137, 223)
        Me.TX_USU_mail.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_USU_mail.Name = "TX_USU_mail"
        Me.TX_USU_mail.Size = New System.Drawing.Size(206, 22)
        Me.TX_USU_mail.TabIndex = 5
        Me.TX_USU_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(25, 225)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Mail:"
        '
        'error_nombre
        '
        Me.error_nombre.AutoSize = True
        Me.error_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_nombre.ForeColor = System.Drawing.Color.Red
        Me.error_nombre.Location = New System.Drawing.Point(344, 115)
        Me.error_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_nombre.Name = "error_nombre"
        Me.error_nombre.Size = New System.Drawing.Size(31, 39)
        Me.error_nombre.TabIndex = 123
        Me.error_nombre.Text = "*"
        Me.error_nombre.Visible = False
        '
        'error_apellido
        '
        Me.error_apellido.AutoSize = True
        Me.error_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_apellido.ForeColor = System.Drawing.Color.Red
        Me.error_apellido.Location = New System.Drawing.Point(344, 81)
        Me.error_apellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_apellido.Name = "error_apellido"
        Me.error_apellido.Size = New System.Drawing.Size(31, 39)
        Me.error_apellido.TabIndex = 123
        Me.error_apellido.Text = "*"
        Me.error_apellido.Visible = False
        '
        'error_dni
        '
        Me.error_dni.AutoSize = True
        Me.error_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_dni.ForeColor = System.Drawing.Color.Red
        Me.error_dni.Location = New System.Drawing.Point(344, 50)
        Me.error_dni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_dni.Name = "error_dni"
        Me.error_dni.Size = New System.Drawing.Size(31, 39)
        Me.error_dni.TabIndex = 123
        Me.error_dni.Text = "*"
        Me.error_dni.Visible = False
        '
        'TX_USU_telefono
        '
        Me.TX_USU_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_telefono.Location = New System.Drawing.Point(137, 187)
        Me.TX_USU_telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_USU_telefono.Name = "TX_USU_telefono"
        Me.TX_USU_telefono.Size = New System.Drawing.Size(206, 22)
        Me.TX_USU_telefono.TabIndex = 4
        Me.TX_USU_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(25, 189)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Teléfono:"
        '
        'TX_USU_domicilio
        '
        Me.TX_USU_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_domicilio.Location = New System.Drawing.Point(137, 152)
        Me.TX_USU_domicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_USU_domicilio.Name = "TX_USU_domicilio"
        Me.TX_USU_domicilio.Size = New System.Drawing.Size(206, 22)
        Me.TX_USU_domicilio.TabIndex = 3
        Me.TX_USU_domicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(25, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Domicilio:"
        '
        'TX_USU_dni
        '
        Me.TX_USU_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_dni.Location = New System.Drawing.Point(137, 50)
        Me.TX_USU_dni.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_USU_dni.Name = "TX_USU_dni"
        Me.TX_USU_dni.Size = New System.Drawing.Size(206, 22)
        Me.TX_USU_dni.TabIndex = 0
        Me.TX_USU_dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(25, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "DNI:"
        '
        'TX_USU_nom
        '
        Me.TX_USU_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_nom.Location = New System.Drawing.Point(137, 116)
        Me.TX_USU_nom.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_USU_nom.Name = "TX_USU_nom"
        Me.TX_USU_nom.Size = New System.Drawing.Size(206, 22)
        Me.TX_USU_nom.TabIndex = 2
        Me.TX_USU_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(25, 117)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Nombre"
        '
        'TX_USU_ape
        '
        Me.TX_USU_ape.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_ape.Location = New System.Drawing.Point(137, 82)
        Me.TX_USU_ape.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_USU_ape.Name = "TX_USU_ape"
        Me.TX_USU_ape.Size = New System.Drawing.Size(206, 22)
        Me.TX_USU_ape.TabIndex = 1
        Me.TX_USU_ape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label20.Location = New System.Drawing.Point(25, 83)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 20)
        Me.Label20.TabIndex = 77
        Me.Label20.Text = "Apellido"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Bo_cancelar)
        Me.GroupBox4.Controls.Add(Me.Bo_guardar)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 326)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(651, 72)
        Me.GroupBox4.TabIndex = 133
        Me.GroupBox4.TabStop = False
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(192, 17)
        Me.Bo_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(138, 49)
        Me.Bo_cancelar.TabIndex = 1
        Me.Bo_cancelar.Text = "Cancelar"
        Me.Bo_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bo_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(333, 17)
        Me.Bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(128, 49)
        Me.Bo_guardar.TabIndex = 0
        Me.Bo_guardar.Text = "Guardar"
        Me.Bo_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_guardar.UseVisualStyleBackColor = True
        '
        'Vendedor_alta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 406)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Vendedor_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Vendedor"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Bo_exportar As System.Windows.Forms.Button
    Friend WithEvents Bo_deshacer As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TX_USU_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TX_USU_mail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents error_nombre As System.Windows.Forms.Label
    Friend WithEvents error_apellido As System.Windows.Forms.Label
    Friend WithEvents error_dni As System.Windows.Forms.Label
    Friend WithEvents TX_USU_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TX_USU_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TX_USU_dni As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TX_USU_nom As System.Windows.Forms.TextBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TX_USU_ape As System.Windows.Forms.TextBox
    Private WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents Bo_cancelar As System.Windows.Forms.Button
    Public WithEvents Bo_guardar As System.Windows.Forms.Button
End Class
