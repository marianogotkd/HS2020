<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paciente_reporte_seleccionar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combo_obrasocial = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_activo = New System.Windows.Forms.RadioButton()
        Me.rb_inactivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_hasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb_todo = New System.Windows.Forms.RadioButton()
        Me.tb_rangofechas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.combo_obrasocial)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Obra social para generar reporte:"
        '
        'combo_obrasocial
        '
        Me.combo_obrasocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_obrasocial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.combo_obrasocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_obrasocial.FormattingEnabled = True
        Me.combo_obrasocial.Location = New System.Drawing.Point(6, 27)
        Me.combo_obrasocial.Name = "combo_obrasocial"
        Me.combo_obrasocial.Size = New System.Drawing.Size(331, 28)
        Me.combo_obrasocial.TabIndex = 252
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(151, 217)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 251
        Me.Button1.Text = "Generar reporte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rb_activo)
        Me.GroupBox2.Controls.Add(Me.rb_inactivo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 88)
        Me.GroupBox2.TabIndex = 252
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pacientes:"
        '
        'rb_activo
        '
        Me.rb_activo.AutoSize = True
        Me.rb_activo.Checked = True
        Me.rb_activo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rb_activo.Location = New System.Drawing.Point(21, 23)
        Me.rb_activo.Name = "rb_activo"
        Me.rb_activo.Size = New System.Drawing.Size(78, 24)
        Me.rb_activo.TabIndex = 253
        Me.rb_activo.TabStop = True
        Me.rb_activo.Text = "Activos"
        Me.rb_activo.UseVisualStyleBackColor = True
        '
        'rb_inactivo
        '
        Me.rb_inactivo.AutoSize = True
        Me.rb_inactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rb_inactivo.Location = New System.Drawing.Point(21, 53)
        Me.rb_inactivo.Name = "rb_inactivo"
        Me.rb_inactivo.Size = New System.Drawing.Size(90, 24)
        Me.rb_inactivo.TabIndex = 0
        Me.rb_inactivo.Text = "Inactivos"
        Me.rb_inactivo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_hasta)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_desde)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.rb_todo)
        Me.GroupBox3.Controls.Add(Me.tb_rangofechas)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(361, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 278)
        Me.GroupBox3.TabIndex = 253
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione tipo de reporte"
        '
        'DateTimePicker_hasta
        '
        Me.DateTimePicker_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_hasta.Location = New System.Drawing.Point(133, 165)
        Me.DateTimePicker_hasta.Name = "DateTimePicker_hasta"
        Me.DateTimePicker_hasta.Size = New System.Drawing.Size(142, 26)
        Me.DateTimePicker_hasta.TabIndex = 316
        '
        'DateTimePicker_desde
        '
        Me.DateTimePicker_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_desde.Location = New System.Drawing.Point(133, 120)
        Me.DateTimePicker_desde.Name = "DateTimePicker_desde"
        Me.DateTimePicker_desde.Size = New System.Drawing.Size(142, 26)
        Me.DateTimePicker_desde.TabIndex = 315
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 314
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 313
        Me.Label1.Text = "Desde:"
        '
        'rb_todo
        '
        Me.rb_todo.AutoSize = True
        Me.rb_todo.Checked = True
        Me.rb_todo.Location = New System.Drawing.Point(26, 30)
        Me.rb_todo.Name = "rb_todo"
        Me.rb_todo.Size = New System.Drawing.Size(63, 24)
        Me.rb_todo.TabIndex = 3
        Me.rb_todo.TabStop = True
        Me.rb_todo.Text = "Todo"
        Me.rb_todo.UseVisualStyleBackColor = True
        '
        'tb_rangofechas
        '
        Me.tb_rangofechas.AutoSize = True
        Me.tb_rangofechas.Location = New System.Drawing.Point(26, 72)
        Me.tb_rangofechas.Name = "tb_rangofechas"
        Me.tb_rangofechas.Size = New System.Drawing.Size(149, 24)
        Me.tb_rangofechas.TabIndex = 4
        Me.tb_rangofechas.Text = "Rango de fechas"
        Me.tb_rangofechas.UseVisualStyleBackColor = True
        '
        'Paciente_reporte_seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(665, 296)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Paciente_reporte_seleccionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar reporte de pacientes por obra social"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents combo_obrasocial As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_activo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_inactivo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rb_todo As System.Windows.Forms.RadioButton
    Friend WithEvents tb_rangofechas As System.Windows.Forms.RadioButton
End Class
