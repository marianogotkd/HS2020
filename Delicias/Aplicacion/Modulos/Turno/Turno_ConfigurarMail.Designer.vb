<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno_ConfigurarMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turno_ConfigurarMail))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TX_EMAIL_OR_contr = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.COM_EMAIL_T = New System.Windows.Forms.ComboBox()
        Me.GP_duracion = New System.Windows.Forms.GroupBox()
        Me.TX_EMAIL_OR_nom = New System.Windows.Forms.TextBox()
        Me.GP_fecha = New System.Windows.Forms.GroupBox()
        Me.TX_EMAIL_OR_email = New System.Windows.Forms.TextBox()
        Me.BO_eliminar = New System.Windows.Forms.Button()
        Me.BO_modificar = New System.Windows.Forms.Button()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.BO_limpiar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GP_duracion.SuspendLayout()
        Me.GP_fecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(866, 127)
        Me.TabControl2.TabIndex = 26
        Me.TabControl2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 101)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Turno Email Origen: Configurar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GP_duracion)
        Me.GroupBox4.Controls.Add(Me.GP_fecha)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(845, 84)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Email Origen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TX_EMAIL_OR_contr)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(632, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 49)
        Me.GroupBox2.TabIndex = 255
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contraseña"
        '
        'TX_EMAIL_OR_contr
        '
        Me.TX_EMAIL_OR_contr.Location = New System.Drawing.Point(6, 22)
        Me.TX_EMAIL_OR_contr.Name = "TX_EMAIL_OR_contr"
        Me.TX_EMAIL_OR_contr.Size = New System.Drawing.Size(183, 20)
        Me.TX_EMAIL_OR_contr.TabIndex = 253
        Me.TX_EMAIL_OR_contr.UseSystemPasswordChar = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.COM_EMAIL_T)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(18, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 49)
        Me.GroupBox1.TabIndex = 254
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Host"
        '
        'COM_EMAIL_T
        '
        Me.COM_EMAIL_T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_EMAIL_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_EMAIL_T.FormattingEnabled = True
        Me.COM_EMAIL_T.Location = New System.Drawing.Point(6, 19)
        Me.COM_EMAIL_T.Name = "COM_EMAIL_T"
        Me.COM_EMAIL_T.Size = New System.Drawing.Size(183, 23)
        Me.COM_EMAIL_T.TabIndex = 253
        '
        'GP_duracion
        '
        Me.GP_duracion.Controls.Add(Me.TX_EMAIL_OR_nom)
        Me.GP_duracion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_duracion.Location = New System.Drawing.Point(431, 19)
        Me.GP_duracion.Name = "GP_duracion"
        Me.GP_duracion.Size = New System.Drawing.Size(195, 49)
        Me.GP_duracion.TabIndex = 246
        Me.GP_duracion.TabStop = False
        Me.GP_duracion.Text = "Nombre"
        '
        'TX_EMAIL_OR_nom
        '
        Me.TX_EMAIL_OR_nom.Location = New System.Drawing.Point(6, 22)
        Me.TX_EMAIL_OR_nom.Name = "TX_EMAIL_OR_nom"
        Me.TX_EMAIL_OR_nom.Size = New System.Drawing.Size(183, 20)
        Me.TX_EMAIL_OR_nom.TabIndex = 253
        '
        'GP_fecha
        '
        Me.GP_fecha.Controls.Add(Me.TX_EMAIL_OR_email)
        Me.GP_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_fecha.Location = New System.Drawing.Point(219, 19)
        Me.GP_fecha.Name = "GP_fecha"
        Me.GP_fecha.Size = New System.Drawing.Size(206, 49)
        Me.GP_fecha.TabIndex = 245
        Me.GP_fecha.TabStop = False
        Me.GP_fecha.Text = "Email"
        '
        'TX_EMAIL_OR_email
        '
        Me.TX_EMAIL_OR_email.Location = New System.Drawing.Point(8, 19)
        Me.TX_EMAIL_OR_email.Name = "TX_EMAIL_OR_email"
        Me.TX_EMAIL_OR_email.Size = New System.Drawing.Size(190, 20)
        Me.TX_EMAIL_OR_email.TabIndex = 231
        '
        'BO_eliminar
        '
        Me.BO_eliminar.Image = CType(resources.GetObject("BO_eliminar.Image"), System.Drawing.Image)
        Me.BO_eliminar.Location = New System.Drawing.Point(746, 141)
        Me.BO_eliminar.Name = "BO_eliminar"
        Me.BO_eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_eliminar.TabIndex = 239
        Me.BO_eliminar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_eliminar, "Eliminar")
        Me.BO_eliminar.UseVisualStyleBackColor = True
        '
        'BO_modificar
        '
        Me.BO_modificar.Image = CType(resources.GetObject("BO_modificar.Image"), System.Drawing.Image)
        Me.BO_modificar.Location = New System.Drawing.Point(792, 141)
        Me.BO_modificar.Name = "BO_modificar"
        Me.BO_modificar.Size = New System.Drawing.Size(40, 40)
        Me.BO_modificar.TabIndex = 238
        Me.BO_modificar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_modificar, "Modificar")
        Me.BO_modificar.UseVisualStyleBackColor = True
        '
        'BO_guardar
        '
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(838, 141)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(40, 40)
        Me.BO_guardar.TabIndex = 236
        Me.BO_guardar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Guardar")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'BO_limpiar
        '
        Me.BO_limpiar.Image = CType(resources.GetObject("BO_limpiar.Image"), System.Drawing.Image)
        Me.BO_limpiar.Location = New System.Drawing.Point(700, 141)
        Me.BO_limpiar.Name = "BO_limpiar"
        Me.BO_limpiar.Size = New System.Drawing.Size(40, 40)
        Me.BO_limpiar.TabIndex = 237
        Me.BO_limpiar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_limpiar, "Cancelar")
        Me.BO_limpiar.UseVisualStyleBackColor = True
        '
        'Turno_ConfigurarMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.BO_eliminar)
        Me.Controls.Add(Me.BO_modificar)
        Me.Controls.Add(Me.BO_limpiar)
        Me.Controls.Add(Me.BO_guardar)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "Turno_ConfigurarMail"
        Me.Text = "Turno_ConfigurarMail"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GP_duracion.ResumeLayout(False)
        Me.GP_duracion.PerformLayout()
        Me.GP_fecha.ResumeLayout(False)
        Me.GP_fecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_duracion As System.Windows.Forms.GroupBox
    Friend WithEvents TX_EMAIL_OR_nom As System.Windows.Forms.TextBox
    Friend WithEvents GP_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents TX_EMAIL_OR_email As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents COM_EMAIL_T As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TX_EMAIL_OR_contr As System.Windows.Forms.TextBox
    Friend WithEvents BO_eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_modificar As System.Windows.Forms.Button
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents BO_limpiar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
