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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combo_obrasocial)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 56)
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
        Me.combo_obrasocial.Location = New System.Drawing.Point(6, 19)
        Me.combo_obrasocial.Name = "combo_obrasocial"
        Me.combo_obrasocial.Size = New System.Drawing.Size(331, 28)
        Me.combo_obrasocial.TabIndex = 252
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(231, 155)
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
        Me.GroupBox2.Controls.Add(Me.rb_activo)
        Me.GroupBox2.Controls.Add(Me.rb_inactivo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 74)
        Me.GroupBox2.TabIndex = 252
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pacientes:"
        '
        'rb_activo
        '
        Me.rb_activo.AutoSize = True
        Me.rb_activo.Checked = True
        Me.rb_activo.Location = New System.Drawing.Point(21, 19)
        Me.rb_activo.Name = "rb_activo"
        Me.rb_activo.Size = New System.Drawing.Size(60, 17)
        Me.rb_activo.TabIndex = 253
        Me.rb_activo.TabStop = True
        Me.rb_activo.Text = "Activos"
        Me.rb_activo.UseVisualStyleBackColor = True
        '
        'rb_inactivo
        '
        Me.rb_inactivo.AutoSize = True
        Me.rb_inactivo.Location = New System.Drawing.Point(21, 42)
        Me.rb_inactivo.Name = "rb_inactivo"
        Me.rb_inactivo.Size = New System.Drawing.Size(68, 17)
        Me.rb_inactivo.TabIndex = 0
        Me.rb_inactivo.Text = "Inactivos"
        Me.rb_inactivo.UseVisualStyleBackColor = True
        '
        'Paciente_reporte_seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(368, 209)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents combo_obrasocial As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_activo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_inactivo As System.Windows.Forms.RadioButton
End Class
