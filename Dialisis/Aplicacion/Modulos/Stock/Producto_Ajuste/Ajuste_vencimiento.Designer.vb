<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajuste_vencimiento
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_agregarr = New System.Windows.Forms.Button()
        Me.Grupo_lote = New System.Windows.Forms.GroupBox()
        Me.CheckBox_vto = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker_fvencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker_ffabricacion = New System.Windows.Forms.DateTimePicker()
        Me.txt_nrolote = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.Grupo_lote.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_agregarr)
        Me.GroupBox4.Controls.Add(Me.Grupo_lote)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(562, 179)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Complete la información:"
        '
        'btn_agregarr
        '
        Me.btn_agregarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarr.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_agregarr.Location = New System.Drawing.Point(456, 130)
        Me.btn_agregarr.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregarr.Name = "btn_agregarr"
        Me.btn_agregarr.Size = New System.Drawing.Size(99, 41)
        Me.btn_agregarr.TabIndex = 249
        Me.btn_agregarr.Text = "Confirmar"
        Me.btn_agregarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_agregarr.UseVisualStyleBackColor = True
        '
        'Grupo_lote
        '
        Me.Grupo_lote.BackColor = System.Drawing.Color.Transparent
        Me.Grupo_lote.Controls.Add(Me.CheckBox_vto)
        Me.Grupo_lote.Controls.Add(Me.DateTimePicker_fvencimiento)
        Me.Grupo_lote.Controls.Add(Me.Label11)
        Me.Grupo_lote.Controls.Add(Me.DateTimePicker_ffabricacion)
        Me.Grupo_lote.Controls.Add(Me.txt_nrolote)
        Me.Grupo_lote.Controls.Add(Me.Label12)
        Me.Grupo_lote.Controls.Add(Me.Label13)
        Me.Grupo_lote.Location = New System.Drawing.Point(6, 18)
        Me.Grupo_lote.Name = "Grupo_lote"
        Me.Grupo_lote.Size = New System.Drawing.Size(550, 105)
        Me.Grupo_lote.TabIndex = 20
        Me.Grupo_lote.TabStop = False
        '
        'CheckBox_vto
        '
        Me.CheckBox_vto.AutoSize = True
        Me.CheckBox_vto.Checked = True
        Me.CheckBox_vto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_vto.Location = New System.Drawing.Point(210, 26)
        Me.CheckBox_vto.Name = "CheckBox_vto"
        Me.CheckBox_vto.Size = New System.Drawing.Size(146, 17)
        Me.CheckBox_vto.TabIndex = 240
        Me.CheckBox_vto.Text = "Habilitar Vencimiento"
        Me.CheckBox_vto.UseVisualStyleBackColor = True
        '
        'DateTimePicker_fvencimiento
        '
        Me.DateTimePicker_fvencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_fvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_fvencimiento.Location = New System.Drawing.Point(404, 65)
        Me.DateTimePicker_fvencimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_fvencimiento.Name = "DateTimePicker_fvencimiento"
        Me.DateTimePicker_fvencimiento.Size = New System.Drawing.Size(139, 29)
        Me.DateTimePicker_fvencimiento.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 70)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "F. Fabricación:"
        '
        'DateTimePicker_ffabricacion
        '
        Me.DateTimePicker_ffabricacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_ffabricacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_ffabricacion.Location = New System.Drawing.Point(122, 65)
        Me.DateTimePicker_ffabricacion.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_ffabricacion.Name = "DateTimePicker_ffabricacion"
        Me.DateTimePicker_ffabricacion.Size = New System.Drawing.Size(138, 29)
        Me.DateTimePicker_ffabricacion.TabIndex = 1
        '
        'txt_nrolote
        '
        Me.txt_nrolote.BackColor = System.Drawing.SystemColors.Info
        Me.txt_nrolote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nrolote.Location = New System.Drawing.Point(78, 18)
        Me.txt_nrolote.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nrolote.MinimumSize = New System.Drawing.Size(90, 30)
        Me.txt_nrolote.Name = "txt_nrolote"
        Me.txt_nrolote.ReadOnly = True
        Me.txt_nrolote.Size = New System.Drawing.Size(112, 26)
        Me.txt_nrolote.TabIndex = 0
        Me.txt_nrolote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 25)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Lote Nº:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(290, 70)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "F. Vencimiento:"
        '
        'Ajuste_vencimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(582, 194)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ajuste_vencimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar vencimiento"
        Me.GroupBox4.ResumeLayout(False)
        Me.Grupo_lote.ResumeLayout(False)
        Me.Grupo_lote.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Grupo_lote As System.Windows.Forms.GroupBox
    Friend WithEvents btn_agregarr As System.Windows.Forms.Button
    Friend WithEvents CheckBox_vto As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker_fvencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_ffabricacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nrolote As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
