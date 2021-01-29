<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnoDialisis_nuevo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.domingo = New System.Windows.Forms.CheckBox()
        Me.sabado = New System.Windows.Forms.CheckBox()
        Me.viernes = New System.Windows.Forms.CheckBox()
        Me.jueves = New System.Windows.Forms.CheckBox()
        Me.miercoles = New System.Windows.Forms.CheckBox()
        Me.martes = New System.Windows.Forms.CheckBox()
        Me.lunes = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hasta_min = New System.Windows.Forms.NumericUpDown()
        Me.hasta_hora = New System.Windows.Forms.NumericUpDown()
        Me.desde_min = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.desde_hora = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.hasta_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hasta_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desde_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desde_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TURNO:"
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(67, 6)
        Me.txt_desc.MaxLength = 100
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(296, 20)
        Me.txt_desc.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.domingo)
        Me.GroupBox1.Controls.Add(Me.sabado)
        Me.GroupBox1.Controls.Add(Me.viernes)
        Me.GroupBox1.Controls.Add(Me.jueves)
        Me.GroupBox1.Controls.Add(Me.miercoles)
        Me.GroupBox1.Controls.Add(Me.martes)
        Me.GroupBox1.Controls.Add(Me.lunes)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 195)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione los días"
        '
        'domingo
        '
        Me.domingo.AutoSize = True
        Me.domingo.Location = New System.Drawing.Point(26, 167)
        Me.domingo.Name = "domingo"
        Me.domingo.Size = New System.Drawing.Size(68, 17)
        Me.domingo.TabIndex = 6
        Me.domingo.Text = "Domingo"
        Me.domingo.UseVisualStyleBackColor = True
        '
        'sabado
        '
        Me.sabado.AutoSize = True
        Me.sabado.Location = New System.Drawing.Point(26, 144)
        Me.sabado.Name = "sabado"
        Me.sabado.Size = New System.Drawing.Size(63, 17)
        Me.sabado.TabIndex = 5
        Me.sabado.Text = "Sábado"
        Me.sabado.UseVisualStyleBackColor = True
        '
        'viernes
        '
        Me.viernes.AutoSize = True
        Me.viernes.Location = New System.Drawing.Point(26, 121)
        Me.viernes.Name = "viernes"
        Me.viernes.Size = New System.Drawing.Size(61, 17)
        Me.viernes.TabIndex = 4
        Me.viernes.Text = "Viernes"
        Me.viernes.UseVisualStyleBackColor = True
        '
        'jueves
        '
        Me.jueves.AutoSize = True
        Me.jueves.Location = New System.Drawing.Point(26, 98)
        Me.jueves.Name = "jueves"
        Me.jueves.Size = New System.Drawing.Size(60, 17)
        Me.jueves.TabIndex = 3
        Me.jueves.Text = "Jueves"
        Me.jueves.UseVisualStyleBackColor = True
        '
        'miercoles
        '
        Me.miercoles.AutoSize = True
        Me.miercoles.Location = New System.Drawing.Point(26, 75)
        Me.miercoles.Name = "miercoles"
        Me.miercoles.Size = New System.Drawing.Size(71, 17)
        Me.miercoles.TabIndex = 2
        Me.miercoles.Text = "Miércoles"
        Me.miercoles.UseVisualStyleBackColor = True
        '
        'martes
        '
        Me.martes.AutoSize = True
        Me.martes.Location = New System.Drawing.Point(26, 52)
        Me.martes.Name = "martes"
        Me.martes.Size = New System.Drawing.Size(58, 17)
        Me.martes.TabIndex = 1
        Me.martes.Text = "Martes"
        Me.martes.UseVisualStyleBackColor = True
        '
        'lunes
        '
        Me.lunes.AutoSize = True
        Me.lunes.Location = New System.Drawing.Point(26, 29)
        Me.lunes.Name = "lunes"
        Me.lunes.Size = New System.Drawing.Size(55, 17)
        Me.lunes.TabIndex = 0
        Me.lunes.Text = "Lunes"
        Me.lunes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.hasta_min)
        Me.GroupBox2.Controls.Add(Me.hasta_hora)
        Me.GroupBox2.Controls.Add(Me.desde_min)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.desde_hora)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(167, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 115)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione el rango horario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(139, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "min:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "hrs:"
        '
        'hasta_min
        '
        Me.hasta_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasta_min.Location = New System.Drawing.Point(171, 75)
        Me.hasta_min.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.hasta_min.Name = "hasta_min"
        Me.hasta_min.Size = New System.Drawing.Size(46, 30)
        Me.hasta_min.TabIndex = 7
        '
        'hasta_hora
        '
        Me.hasta_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasta_hora.Location = New System.Drawing.Point(87, 75)
        Me.hasta_hora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.hasta_hora.Name = "hasta_hora"
        Me.hasta_hora.Size = New System.Drawing.Size(46, 30)
        Me.hasta_hora.TabIndex = 6
        '
        'desde_min
        '
        Me.desde_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desde_min.Location = New System.Drawing.Point(171, 19)
        Me.desde_min.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.desde_min.Name = "desde_min"
        Me.desde_min.Size = New System.Drawing.Size(46, 30)
        Me.desde_min.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "min:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "hrs:"
        '
        'desde_hora
        '
        Me.desde_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desde_hora.Location = New System.Drawing.Point(87, 19)
        Me.desde_hora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.desde_hora.Name = "desde_hora"
        Me.desde_hora.Size = New System.Drawing.Size(46, 30)
        Me.desde_hora.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde:"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Cancelar.Location = New System.Drawing.Point(190, 197)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(320, 197)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Aceptar.TabIndex = 4
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'TurnoDialisis_nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(457, 251)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TurnoDialisis_nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo turno dialisis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.hasta_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hasta_hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desde_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desde_hora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents domingo As System.Windows.Forms.CheckBox
    Friend WithEvents sabado As System.Windows.Forms.CheckBox
    Friend WithEvents viernes As System.Windows.Forms.CheckBox
    Friend WithEvents jueves As System.Windows.Forms.CheckBox
    Friend WithEvents miercoles As System.Windows.Forms.CheckBox
    Friend WithEvents martes As System.Windows.Forms.CheckBox
    Friend WithEvents lunes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents hasta_min As System.Windows.Forms.NumericUpDown
    Friend WithEvents hasta_hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents desde_min As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents desde_hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
End Class
