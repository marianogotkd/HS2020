<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informe_seleccionar
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
        Me.CheckBox_accesovascular = New System.Windows.Forms.CheckBox()
        Me.CheckBox_trasplante = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox_consultanutricional = New System.Windows.Forms.CheckBox()
        Me.CheckBox_asistenciasocial = New System.Windows.Forms.CheckBox()
        Me.CheckBox_consultapsicologica = New System.Windows.Forms.CheckBox()
        Me.CheckBox_consultaclinica = New System.Windows.Forms.CheckBox()
        Me.CheckBox_evaluacionmedica = New System.Windows.Forms.CheckBox()
        Me.CheckBox_todo = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_todo = New System.Windows.Forms.RadioButton()
        Me.tb_rangofechas = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker_desde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_hasta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.CheckBox_accesovascular)
        Me.GroupBox1.Controls.Add(Me.CheckBox_trasplante)
        Me.GroupBox1.Controls.Add(Me.CheckBox_consultanutricional)
        Me.GroupBox1.Controls.Add(Me.CheckBox_asistenciasocial)
        Me.GroupBox1.Controls.Add(Me.CheckBox_consultapsicologica)
        Me.GroupBox1.Controls.Add(Me.CheckBox_consultaclinica)
        Me.GroupBox1.Controls.Add(Me.CheckBox_evaluacionmedica)
        Me.GroupBox1.Controls.Add(Me.CheckBox_todo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 278)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione información para el reporte"
        '
        'CheckBox_accesovascular
        '
        Me.CheckBox_accesovascular.AutoSize = True
        Me.CheckBox_accesovascular.Checked = True
        Me.CheckBox_accesovascular.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_accesovascular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_accesovascular.Location = New System.Drawing.Point(55, 91)
        Me.CheckBox_accesovascular.Name = "CheckBox_accesovascular"
        Me.CheckBox_accesovascular.Size = New System.Drawing.Size(147, 24)
        Me.CheckBox_accesovascular.TabIndex = 314
        Me.CheckBox_accesovascular.Text = "Acceso Vascular"
        Me.CheckBox_accesovascular.UseVisualStyleBackColor = True
        '
        'CheckBox_trasplante
        '
        Me.CheckBox_trasplante.AutoSize = True
        Me.CheckBox_trasplante.Checked = True
        Me.CheckBox_trasplante.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_trasplante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_trasplante.Location = New System.Drawing.Point(55, 241)
        Me.CheckBox_trasplante.Name = "CheckBox_trasplante"
        Me.CheckBox_trasplante.Size = New System.Drawing.Size(103, 24)
        Me.CheckBox_trasplante.TabIndex = 313
        Me.CheckBox_trasplante.Text = "Trasplante"
        Me.CheckBox_trasplante.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button2.Location = New System.Drawing.Point(168, 222)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 43)
        Me.Button2.TabIndex = 312
        Me.Button2.Text = "Ir al reporte"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CheckBox_consultanutricional
        '
        Me.CheckBox_consultanutricional.AutoSize = True
        Me.CheckBox_consultanutricional.Checked = True
        Me.CheckBox_consultanutricional.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_consultanutricional.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_consultanutricional.Location = New System.Drawing.Point(55, 211)
        Me.CheckBox_consultanutricional.Name = "CheckBox_consultanutricional"
        Me.CheckBox_consultanutricional.Size = New System.Drawing.Size(169, 24)
        Me.CheckBox_consultanutricional.TabIndex = 5
        Me.CheckBox_consultanutricional.Text = "Consulta Nutricional"
        Me.CheckBox_consultanutricional.UseVisualStyleBackColor = True
        '
        'CheckBox_asistenciasocial
        '
        Me.CheckBox_asistenciasocial.AutoSize = True
        Me.CheckBox_asistenciasocial.Checked = True
        Me.CheckBox_asistenciasocial.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_asistenciasocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_asistenciasocial.Location = New System.Drawing.Point(55, 181)
        Me.CheckBox_asistenciasocial.Name = "CheckBox_asistenciasocial"
        Me.CheckBox_asistenciasocial.Size = New System.Drawing.Size(148, 24)
        Me.CheckBox_asistenciasocial.TabIndex = 4
        Me.CheckBox_asistenciasocial.Text = "Asistencia Social"
        Me.CheckBox_asistenciasocial.UseVisualStyleBackColor = True
        '
        'CheckBox_consultapsicologica
        '
        Me.CheckBox_consultapsicologica.AutoSize = True
        Me.CheckBox_consultapsicologica.Checked = True
        Me.CheckBox_consultapsicologica.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_consultapsicologica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_consultapsicologica.Location = New System.Drawing.Point(55, 151)
        Me.CheckBox_consultapsicologica.Name = "CheckBox_consultapsicologica"
        Me.CheckBox_consultapsicologica.Size = New System.Drawing.Size(174, 24)
        Me.CheckBox_consultapsicologica.TabIndex = 3
        Me.CheckBox_consultapsicologica.Text = "Consulta Psicológica"
        Me.CheckBox_consultapsicologica.UseVisualStyleBackColor = True
        '
        'CheckBox_consultaclinica
        '
        Me.CheckBox_consultaclinica.AutoSize = True
        Me.CheckBox_consultaclinica.Checked = True
        Me.CheckBox_consultaclinica.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_consultaclinica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_consultaclinica.Location = New System.Drawing.Point(55, 121)
        Me.CheckBox_consultaclinica.Name = "CheckBox_consultaclinica"
        Me.CheckBox_consultaclinica.Size = New System.Drawing.Size(96, 24)
        Me.CheckBox_consultaclinica.TabIndex = 2
        Me.CheckBox_consultaclinica.Text = "Evolución"
        Me.CheckBox_consultaclinica.UseVisualStyleBackColor = True
        '
        'CheckBox_evaluacionmedica
        '
        Me.CheckBox_evaluacionmedica.AutoSize = True
        Me.CheckBox_evaluacionmedica.Checked = True
        Me.CheckBox_evaluacionmedica.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_evaluacionmedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_evaluacionmedica.Location = New System.Drawing.Point(55, 61)
        Me.CheckBox_evaluacionmedica.Name = "CheckBox_evaluacionmedica"
        Me.CheckBox_evaluacionmedica.Size = New System.Drawing.Size(132, 24)
        Me.CheckBox_evaluacionmedica.TabIndex = 1
        Me.CheckBox_evaluacionmedica.Text = "Historia Clínica"
        Me.CheckBox_evaluacionmedica.UseVisualStyleBackColor = True
        '
        'CheckBox_todo
        '
        Me.CheckBox_todo.AutoSize = True
        Me.CheckBox_todo.Checked = True
        Me.CheckBox_todo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_todo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_todo.Location = New System.Drawing.Point(19, 30)
        Me.CheckBox_todo.Name = "CheckBox_todo"
        Me.CheckBox_todo.Size = New System.Drawing.Size(77, 24)
        Me.CheckBox_todo.TabIndex = 0
        Me.CheckBox_todo.Text = "TODO"
        Me.CheckBox_todo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(761, 118)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del paciente:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(104, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(225, 26)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(161, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(593, 26)
        Me.TextBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DNI/Cuit:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido y Nombre:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_hasta)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_desde)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.rb_todo)
        Me.GroupBox3.Controls.Add(Me.tb_rangofechas)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(486, 145)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 278)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione tipo de reporte"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 313
        Me.Label1.Text = "Desde:"
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
        'DateTimePicker_desde
        '
        Me.DateTimePicker_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_desde.Location = New System.Drawing.Point(133, 120)
        Me.DateTimePicker_desde.Name = "DateTimePicker_desde"
        Me.DateTimePicker_desde.Size = New System.Drawing.Size(142, 26)
        Me.DateTimePicker_desde.TabIndex = 315
        '
        'DateTimePicker_hasta
        '
        Me.DateTimePicker_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_hasta.Location = New System.Drawing.Point(133, 165)
        Me.DateTimePicker_hasta.Name = "DateTimePicker_hasta"
        Me.DateTimePicker_hasta.Size = New System.Drawing.Size(142, 26)
        Me.DateTimePicker_hasta.TabIndex = 316
        '
        'Informe_seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(788, 429)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(499, 468)
        Me.Name = "Informe_seleccionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar reporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_consultapsicologica As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_consultaclinica As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_evaluacionmedica As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_todo As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_consultanutricional As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_asistenciasocial As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_trasplante As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_accesovascular As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rb_todo As System.Windows.Forms.RadioButton
    Friend WithEvents tb_rangofechas As System.Windows.Forms.RadioButton
End Class
