<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enfermeria_Acceso_Vascular
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btn_ACCV_nuevo = New System.Windows.Forms.Button()
        Me.btn_ACCV_cancelar = New System.Windows.Forms.Button()
        Me.btn_ACCV_guardar = New System.Windows.Forms.Button()
        Me.tb_ACCV_obs = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.tb_ACCV_ubi = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.DateTime_PU = New System.Windows.Forms.DateTimePicker()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.DateTime_Confex = New System.Windows.Forms.DateTimePicker()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_CatPeri = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Prot = New System.Windows.Forms.RadioButton()
        Me.RadioButton_FAV = New System.Windows.Forms.RadioButton()
        Me.RadioButton_CatPerma = New System.Windows.Forms.RadioButton()
        Me.RadioButton_trns = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DateTime_ACCV = New System.Windows.Forms.DateTimePicker()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.tb_ACCV_nmat = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cb_ACCV_med = New System.Windows.Forms.ComboBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.tb_ACCV_Titulo = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1129, 538)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage7
        '
        Me.TabPage7.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.TabPage7.Controls.Add(Me.btn_ACCV_nuevo)
        Me.TabPage7.Controls.Add(Me.btn_ACCV_cancelar)
        Me.TabPage7.Controls.Add(Me.btn_ACCV_guardar)
        Me.TabPage7.Controls.Add(Me.tb_ACCV_obs)
        Me.TabPage7.Controls.Add(Me.Label66)
        Me.TabPage7.Controls.Add(Me.tb_ACCV_ubi)
        Me.TabPage7.Controls.Add(Me.Label65)
        Me.TabPage7.Controls.Add(Me.DateTime_PU)
        Me.TabPage7.Controls.Add(Me.Label64)
        Me.TabPage7.Controls.Add(Me.DateTime_Confex)
        Me.TabPage7.Controls.Add(Me.Label63)
        Me.TabPage7.Controls.Add(Me.GroupBox2)
        Me.TabPage7.Controls.Add(Me.Panel6)
        Me.TabPage7.ImageIndex = 7
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1121, 509)
        Me.TabPage7.TabIndex = 7
        Me.TabPage7.Text = "Acceso Vascular"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'btn_ACCV_nuevo
        '
        Me.btn_ACCV_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ACCV_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_ACCV_nuevo.Location = New System.Drawing.Point(218, 459)
        Me.btn_ACCV_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ACCV_nuevo.Name = "btn_ACCV_nuevo"
        Me.btn_ACCV_nuevo.Size = New System.Drawing.Size(113, 43)
        Me.btn_ACCV_nuevo.TabIndex = 333
        Me.btn_ACCV_nuevo.Text = "Nuevo"
        Me.btn_ACCV_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ACCV_nuevo.UseVisualStyleBackColor = True
        '
        'btn_ACCV_cancelar
        '
        Me.btn_ACCV_cancelar.Enabled = False
        Me.btn_ACCV_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ACCV_cancelar.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_ACCV_cancelar.Location = New System.Drawing.Point(460, 459)
        Me.btn_ACCV_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ACCV_cancelar.Name = "btn_ACCV_cancelar"
        Me.btn_ACCV_cancelar.Size = New System.Drawing.Size(110, 43)
        Me.btn_ACCV_cancelar.TabIndex = 334
        Me.btn_ACCV_cancelar.Text = "Cancelar"
        Me.btn_ACCV_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ACCV_cancelar.UseVisualStyleBackColor = True
        '
        'btn_ACCV_guardar
        '
        Me.btn_ACCV_guardar.Enabled = False
        Me.btn_ACCV_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ACCV_guardar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.btn_ACCV_guardar.Location = New System.Drawing.Point(339, 459)
        Me.btn_ACCV_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ACCV_guardar.Name = "btn_ACCV_guardar"
        Me.btn_ACCV_guardar.Size = New System.Drawing.Size(113, 43)
        Me.btn_ACCV_guardar.TabIndex = 331
        Me.btn_ACCV_guardar.Text = "Guardar"
        Me.btn_ACCV_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ACCV_guardar.UseVisualStyleBackColor = True
        '
        'tb_ACCV_obs
        '
        Me.tb_ACCV_obs.BackColor = System.Drawing.Color.Beige
        Me.tb_ACCV_obs.Location = New System.Drawing.Point(36, 386)
        Me.tb_ACCV_obs.Multiline = True
        Me.tb_ACCV_obs.Name = "tb_ACCV_obs"
        Me.tb_ACCV_obs.ReadOnly = True
        Me.tb_ACCV_obs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_ACCV_obs.Size = New System.Drawing.Size(644, 66)
        Me.tb_ACCV_obs.TabIndex = 329
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(36, 367)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(113, 16)
        Me.Label66.TabIndex = 330
        Me.Label66.Text = "Observaciones"
        '
        'tb_ACCV_ubi
        '
        Me.tb_ACCV_ubi.BackColor = System.Drawing.Color.Beige
        Me.tb_ACCV_ubi.Location = New System.Drawing.Point(36, 280)
        Me.tb_ACCV_ubi.Multiline = True
        Me.tb_ACCV_ubi.Name = "tb_ACCV_ubi"
        Me.tb_ACCV_ubi.ReadOnly = True
        Me.tb_ACCV_ubi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_ACCV_ubi.Size = New System.Drawing.Size(644, 66)
        Me.tb_ACCV_ubi.TabIndex = 327
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(36, 261)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(78, 16)
        Me.Label65.TabIndex = 328
        Me.Label65.Text = "Ubicacion"
        '
        'DateTime_PU
        '
        Me.DateTime_PU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_PU.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime_PU.Location = New System.Drawing.Point(339, 215)
        Me.DateTime_PU.Name = "DateTime_PU"
        Me.DateTime_PU.Size = New System.Drawing.Size(112, 26)
        Me.DateTime_PU.TabIndex = 326
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label64.Location = New System.Drawing.Point(336, 196)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(154, 16)
        Me.Label64.TabIndex = 325
        Me.Label64.Text = "Fecha de Primer Uso"
        '
        'DateTime_Confex
        '
        Me.DateTime_Confex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_Confex.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime_Confex.Location = New System.Drawing.Point(39, 215)
        Me.DateTime_Confex.Name = "DateTime_Confex"
        Me.DateTime_Confex.Size = New System.Drawing.Size(112, 26)
        Me.DateTime_Confex.TabIndex = 324
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label63.Location = New System.Drawing.Point(36, 196)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(154, 16)
        Me.Label63.TabIndex = 323
        Me.Label63.Text = "Fecha de Confección"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton_CatPeri)
        Me.GroupBox2.Controls.Add(Me.RadioButton_Prot)
        Me.GroupBox2.Controls.Add(Me.RadioButton_FAV)
        Me.GroupBox2.Controls.Add(Me.RadioButton_CatPerma)
        Me.GroupBox2.Controls.Add(Me.RadioButton_trns)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 99)
        Me.GroupBox2.TabIndex = 320
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'RadioButton_CatPeri
        '
        Me.RadioButton_CatPeri.AutoSize = True
        Me.RadioButton_CatPeri.Location = New System.Drawing.Point(406, 39)
        Me.RadioButton_CatPeri.Name = "RadioButton_CatPeri"
        Me.RadioButton_CatPeri.Size = New System.Drawing.Size(133, 20)
        Me.RadioButton_CatPeri.TabIndex = 4
        Me.RadioButton_CatPeri.TabStop = True
        Me.RadioButton_CatPeri.Text = "Catéter Peritoneal"
        Me.RadioButton_CatPeri.UseVisualStyleBackColor = True
        '
        'RadioButton_Prot
        '
        Me.RadioButton_Prot.AutoSize = True
        Me.RadioButton_Prot.Location = New System.Drawing.Point(325, 39)
        Me.RadioButton_Prot.Name = "RadioButton_Prot"
        Me.RadioButton_Prot.Size = New System.Drawing.Size(75, 20)
        Me.RadioButton_Prot.TabIndex = 3
        Me.RadioButton_Prot.TabStop = True
        Me.RadioButton_Prot.Text = "Prótesis"
        Me.RadioButton_Prot.UseVisualStyleBackColor = True
        '
        'RadioButton_FAV
        '
        Me.RadioButton_FAV.AutoSize = True
        Me.RadioButton_FAV.Location = New System.Drawing.Point(267, 39)
        Me.RadioButton_FAV.Name = "RadioButton_FAV"
        Me.RadioButton_FAV.Size = New System.Drawing.Size(52, 20)
        Me.RadioButton_FAV.TabIndex = 2
        Me.RadioButton_FAV.TabStop = True
        Me.RadioButton_FAV.Text = "FAV"
        Me.RadioButton_FAV.UseVisualStyleBackColor = True
        '
        'RadioButton_CatPerma
        '
        Me.RadioButton_CatPerma.AutoSize = True
        Me.RadioButton_CatPerma.Location = New System.Drawing.Point(116, 39)
        Me.RadioButton_CatPerma.Name = "RadioButton_CatPerma"
        Me.RadioButton_CatPerma.Size = New System.Drawing.Size(145, 20)
        Me.RadioButton_CatPerma.TabIndex = 1
        Me.RadioButton_CatPerma.TabStop = True
        Me.RadioButton_CatPerma.Text = "Catéter Permanente"
        Me.RadioButton_CatPerma.UseVisualStyleBackColor = True
        '
        'RadioButton_trns
        '
        Me.RadioButton_trns.AutoSize = True
        Me.RadioButton_trns.Checked = True
        Me.RadioButton_trns.Location = New System.Drawing.Point(20, 39)
        Me.RadioButton_trns.Name = "RadioButton_trns"
        Me.RadioButton_trns.Size = New System.Drawing.Size(90, 20)
        Me.RadioButton_trns.TabIndex = 0
        Me.RadioButton_trns.TabStop = True
        Me.RadioButton_trns.Text = "Transitorio"
        Me.RadioButton_trns.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DateTime_ACCV)
        Me.Panel6.Controls.Add(Me.Label58)
        Me.Panel6.Controls.Add(Me.tb_ACCV_nmat)
        Me.Panel6.Controls.Add(Me.Label59)
        Me.Panel6.Controls.Add(Me.cb_ACCV_med)
        Me.Panel6.Controls.Add(Me.Label60)
        Me.Panel6.Controls.Add(Me.Label61)
        Me.Panel6.Controls.Add(Me.tb_ACCV_Titulo)
        Me.Panel6.Location = New System.Drawing.Point(6, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1094, 49)
        Me.Panel6.TabIndex = 319
        '
        'DateTime_ACCV
        '
        Me.DateTime_ACCV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_ACCV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime_ACCV.Location = New System.Drawing.Point(967, 12)
        Me.DateTime_ACCV.Name = "DateTime_ACCV"
        Me.DateTime_ACCV.Size = New System.Drawing.Size(110, 26)
        Me.DateTime_ACCV.TabIndex = 320
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(728, 15)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(60, 20)
        Me.Label58.TabIndex = 288
        Me.Label58.Text = "N° Mat."
        '
        'tb_ACCV_nmat
        '
        Me.tb_ACCV_nmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ACCV_nmat.Location = New System.Drawing.Point(794, 13)
        Me.tb_ACCV_nmat.Name = "tb_ACCV_nmat"
        Me.tb_ACCV_nmat.ReadOnly = True
        Me.tb_ACCV_nmat.Size = New System.Drawing.Size(100, 26)
        Me.tb_ACCV_nmat.TabIndex = 289
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(305, 15)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(162, 20)
        Me.Label59.TabIndex = 263
        Me.Label59.Text = "Medico Responsable:"
        '
        'cb_ACCV_med
        '
        Me.cb_ACCV_med.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ACCV_med.Enabled = False
        Me.cb_ACCV_med.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_ACCV_med.FormattingEnabled = True
        Me.cb_ACCV_med.Location = New System.Drawing.Point(473, 9)
        Me.cb_ACCV_med.Name = "cb_ACCV_med"
        Me.cb_ACCV_med.Size = New System.Drawing.Size(249, 28)
        Me.cb_ACCV_med.TabIndex = 1
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(905, 13)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(54, 20)
        Me.Label60.TabIndex = 286
        Me.Label60.Text = "Fecha"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label61.Location = New System.Drawing.Point(15, 15)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(51, 20)
        Me.Label61.TabIndex = 266
        Me.Label61.Text = "Título:"
        '
        'tb_ACCV_Titulo
        '
        Me.tb_ACCV_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_ACCV_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tb_ACCV_Titulo.Location = New System.Drawing.Point(72, 12)
        Me.tb_ACCV_Titulo.Name = "tb_ACCV_Titulo"
        Me.tb_ACCV_Titulo.Size = New System.Drawing.Size(230, 26)
        Me.tb_ACCV_Titulo.TabIndex = 0
        '
        'Enfermeria_Acceso_Vascular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1149, 557)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Enfermeria_Acceso_Vascular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Acceso Vascular"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents btn_ACCV_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_ACCV_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_ACCV_guardar As System.Windows.Forms.Button
    Friend WithEvents tb_ACCV_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents tb_ACCV_ubi As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents DateTime_PU As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents DateTime_Confex As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_CatPeri As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Prot As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_FAV As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_CatPerma As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_trns As System.Windows.Forms.RadioButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents DateTime_ACCV As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents tb_ACCV_nmat As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents cb_ACCV_med As System.Windows.Forms.ComboBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents tb_ACCV_Titulo As System.Windows.Forms.TextBox
End Class
