<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno_ConfigurarMailDestino
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turno_ConfigurarMailDestino))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GP_duracion = New System.Windows.Forms.GroupBox()
        Me.TX_EMAIL_DE_nom = New System.Windows.Forms.TextBox()
        Me.GP_fecha = New System.Windows.Forms.GroupBox()
        Me.TX_EMAIL_DE_email = New System.Windows.Forms.TextBox()
        Me.Turno_ds = New Aplicacion.Turno_ds()
        Me.EmailDestinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GP_EmailDestino_modf = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TX_EMAIL_DE_nom_modf = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TX_EMAIL_DE_email_modf = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DG_EmailDestino = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BO_limpiar = New System.Windows.Forms.Button()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.BO_eliminar = New System.Windows.Forms.Button()
        Me.BO_modificar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GP_duracion.SuspendLayout()
        Me.GP_fecha.SuspendLayout()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDestinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GP_EmailDestino_modf.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_EmailDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(866, 138)
        Me.TabControl2.TabIndex = 27
        Me.TabControl2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 112)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Turno Email Destino: Configurar nuevo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GP_duracion)
        Me.GroupBox4.Controls.Add(Me.GP_fecha)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(211, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(436, 84)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Email Destino (Nuevo)"
        '
        'GP_duracion
        '
        Me.GP_duracion.Controls.Add(Me.TX_EMAIL_DE_nom)
        Me.GP_duracion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_duracion.Location = New System.Drawing.Point(227, 19)
        Me.GP_duracion.Name = "GP_duracion"
        Me.GP_duracion.Size = New System.Drawing.Size(195, 49)
        Me.GP_duracion.TabIndex = 246
        Me.GP_duracion.TabStop = False
        Me.GP_duracion.Text = "Nombre"
        '
        'TX_EMAIL_DE_nom
        '
        Me.TX_EMAIL_DE_nom.Location = New System.Drawing.Point(6, 22)
        Me.TX_EMAIL_DE_nom.Name = "TX_EMAIL_DE_nom"
        Me.TX_EMAIL_DE_nom.Size = New System.Drawing.Size(183, 20)
        Me.TX_EMAIL_DE_nom.TabIndex = 253
        '
        'GP_fecha
        '
        Me.GP_fecha.Controls.Add(Me.TX_EMAIL_DE_email)
        Me.GP_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_fecha.Location = New System.Drawing.Point(15, 19)
        Me.GP_fecha.Name = "GP_fecha"
        Me.GP_fecha.Size = New System.Drawing.Size(206, 49)
        Me.GP_fecha.TabIndex = 245
        Me.GP_fecha.TabStop = False
        Me.GP_fecha.Text = "Email"
        '
        'TX_EMAIL_DE_email
        '
        Me.TX_EMAIL_DE_email.Location = New System.Drawing.Point(8, 19)
        Me.TX_EMAIL_DE_email.Name = "TX_EMAIL_DE_email"
        Me.TX_EMAIL_DE_email.Size = New System.Drawing.Size(190, 20)
        Me.TX_EMAIL_DE_email.TabIndex = 231
        '
        'Turno_ds
        '
        Me.Turno_ds.DataSetName = "Turno_ds"
        Me.Turno_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmailDestinoBindingSource
        '
        Me.EmailDestinoBindingSource.DataMember = "EmailDestino"
        Me.EmailDestinoBindingSource.DataSource = Me.Turno_ds
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(16, 198)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(866, 282)
        Me.TabControl1.TabIndex = 28
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GP_EmailDestino_modf)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(858, 256)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Turno Email Destino: Actualizar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GP_EmailDestino_modf
        '
        Me.GP_EmailDestino_modf.Controls.Add(Me.GroupBox3)
        Me.GP_EmailDestino_modf.Controls.Add(Me.GroupBox5)
        Me.GP_EmailDestino_modf.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_EmailDestino_modf.Location = New System.Drawing.Point(523, 18)
        Me.GP_EmailDestino_modf.Name = "GP_EmailDestino_modf"
        Me.GP_EmailDestino_modf.Size = New System.Drawing.Size(239, 152)
        Me.GP_EmailDestino_modf.TabIndex = 247
        Me.GP_EmailDestino_modf.TabStop = False
        Me.GP_EmailDestino_modf.Text = "Email Destino (Modificar)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TX_EMAIL_DE_nom_modf)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(15, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 49)
        Me.GroupBox3.TabIndex = 246
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nombre"
        '
        'TX_EMAIL_DE_nom_modf
        '
        Me.TX_EMAIL_DE_nom_modf.Location = New System.Drawing.Point(6, 22)
        Me.TX_EMAIL_DE_nom_modf.Name = "TX_EMAIL_DE_nom_modf"
        Me.TX_EMAIL_DE_nom_modf.Size = New System.Drawing.Size(192, 20)
        Me.TX_EMAIL_DE_nom_modf.TabIndex = 253
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TX_EMAIL_DE_email_modf)
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox5.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(206, 49)
        Me.GroupBox5.TabIndex = 245
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Email"
        '
        'TX_EMAIL_DE_email_modf
        '
        Me.TX_EMAIL_DE_email_modf.Location = New System.Drawing.Point(8, 19)
        Me.TX_EMAIL_DE_email_modf.Name = "TX_EMAIL_DE_email_modf"
        Me.TX_EMAIL_DE_email_modf.Size = New System.Drawing.Size(190, 20)
        Me.TX_EMAIL_DE_email_modf.TabIndex = 231
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DG_EmailDestino)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(81, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 219)
        Me.GroupBox2.TabIndex = 246
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Email"
        '
        'DG_EmailDestino
        '
        Me.DG_EmailDestino.AllowUserToAddRows = False
        Me.DG_EmailDestino.AllowUserToDeleteRows = False
        Me.DG_EmailDestino.AutoGenerateColumns = False
        Me.DG_EmailDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_EmailDestino.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DG_EmailDestino.DataSource = Me.EmailDestinoBindingSource
        Me.DG_EmailDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_EmailDestino.Location = New System.Drawing.Point(3, 16)
        Me.DG_EmailDestino.Name = "DG_EmailDestino"
        Me.DG_EmailDestino.ReadOnly = True
        Me.DG_EmailDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_EmailDestino.Size = New System.Drawing.Size(430, 200)
        Me.DG_EmailDestino.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EMAIL_DE_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EMAIL_DE_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EMAIL_DE_email"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 175
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EMAIL_DE_nom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 175
        '
        'BO_limpiar
        '
        Me.BO_limpiar.Image = CType(resources.GetObject("BO_limpiar.Image"), System.Drawing.Image)
        Me.BO_limpiar.Location = New System.Drawing.Point(792, 152)
        Me.BO_limpiar.Name = "BO_limpiar"
        Me.BO_limpiar.Size = New System.Drawing.Size(40, 40)
        Me.BO_limpiar.TabIndex = 239
        Me.BO_limpiar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_limpiar, "Cancelar")
        Me.BO_limpiar.UseVisualStyleBackColor = True
        '
        'BO_guardar
        '
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(838, 152)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(40, 40)
        Me.BO_guardar.TabIndex = 238
        Me.BO_guardar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Guardar")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'BO_eliminar
        '
        Me.BO_eliminar.Image = CType(resources.GetObject("BO_eliminar.Image"), System.Drawing.Image)
        Me.BO_eliminar.Location = New System.Drawing.Point(792, 482)
        Me.BO_eliminar.Name = "BO_eliminar"
        Me.BO_eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_eliminar.TabIndex = 242
        Me.BO_eliminar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_eliminar, "Eliminar")
        Me.BO_eliminar.UseVisualStyleBackColor = True
        '
        'BO_modificar
        '
        Me.BO_modificar.Image = CType(resources.GetObject("BO_modificar.Image"), System.Drawing.Image)
        Me.BO_modificar.Location = New System.Drawing.Point(838, 482)
        Me.BO_modificar.Name = "BO_modificar"
        Me.BO_modificar.Size = New System.Drawing.Size(40, 40)
        Me.BO_modificar.TabIndex = 241
        Me.BO_modificar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_modificar, "Editar")
        Me.BO_modificar.UseVisualStyleBackColor = True
        '
        'Turno_ConfigurarMailDestino
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
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "Turno_ConfigurarMailDestino"
        Me.Text = "Turno_ConfigurarMailDestino"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GP_duracion.ResumeLayout(False)
        Me.GP_duracion.PerformLayout()
        Me.GP_fecha.ResumeLayout(False)
        Me.GP_fecha.PerformLayout()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailDestinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GP_EmailDestino_modf.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_EmailDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_duracion As System.Windows.Forms.GroupBox
    Friend WithEvents TX_EMAIL_DE_nom As System.Windows.Forms.TextBox
    Friend WithEvents GP_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents TX_EMAIL_DE_email As System.Windows.Forms.TextBox
    Friend WithEvents EmailDestinoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Turno_ds As Aplicacion.Turno_ds
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_EmailDestino As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GP_EmailDestino_modf As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TX_EMAIL_DE_nom_modf As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TX_EMAIL_DE_email_modf As System.Windows.Forms.TextBox
    Friend WithEvents BO_limpiar As System.Windows.Forms.Button
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents BO_eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_modificar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
