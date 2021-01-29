<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno_Informe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turno_Informe))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BO_Informe_TurnoReservado = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BO_eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.LB_ERROR = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DT_FECHA_hasta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DT_FECHA_desde = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(868, 204)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(860, 178)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Turno: Informe"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.Button3)
        Me.GroupBox7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox7.Location = New System.Drawing.Point(468, 94)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(90, 71)
        Me.GroupBox7.TabIndex = 248
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Vendido"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(25, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 40)
        Me.Button3.TabIndex = 238
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.BO_Informe_TurnoReservado)
        Me.GroupBox6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox6.Location = New System.Drawing.Point(564, 94)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(90, 71)
        Me.GroupBox6.TabIndex = 247
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Reservado"
        '
        'BO_Informe_TurnoReservado
        '
        Me.BO_Informe_TurnoReservado.Image = CType(resources.GetObject("BO_Informe_TurnoReservado.Image"), System.Drawing.Image)
        Me.BO_Informe_TurnoReservado.Location = New System.Drawing.Point(25, 19)
        Me.BO_Informe_TurnoReservado.Name = "BO_Informe_TurnoReservado"
        Me.BO_Informe_TurnoReservado.Size = New System.Drawing.Size(40, 40)
        Me.BO_Informe_TurnoReservado.TabIndex = 238
        Me.BO_Informe_TurnoReservado.TabStop = False
        Me.BO_Informe_TurnoReservado.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox5.Location = New System.Drawing.Point(665, 94)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(90, 71)
        Me.GroupBox5.TabIndex = 244
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Resrv. Fijo"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(22, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 238
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.BO_eliminar)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(761, 94)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(90, 71)
        Me.GroupBox4.TabIndex = 243
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resrv. Comun"
        '
        'BO_eliminar
        '
        Me.BO_eliminar.Image = CType(resources.GetObject("BO_eliminar.Image"), System.Drawing.Image)
        Me.BO_eliminar.Location = New System.Drawing.Point(22, 19)
        Me.BO_eliminar.Name = "BO_eliminar"
        Me.BO_eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_eliminar.TabIndex = 238
        Me.BO_eliminar.TabStop = False
        Me.BO_eliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IM_ERROR)
        Me.GroupBox1.Controls.Add(Me.LB_ERROR)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'IM_ERROR
        '
        Me.IM_ERROR.BackColor = System.Drawing.Color.Transparent
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(662, 38)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 249
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'LB_ERROR
        '
        Me.LB_ERROR.AutoSize = True
        Me.LB_ERROR.BackColor = System.Drawing.Color.Transparent
        Me.LB_ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR.ForeColor = System.Drawing.Color.DarkRed
        Me.LB_ERROR.Location = New System.Drawing.Point(681, 40)
        Me.LB_ERROR.Name = "LB_ERROR"
        Me.LB_ERROR.Size = New System.Drawing.Size(59, 15)
        Me.LB_ERROR.TabIndex = 250
        Me.LB_ERROR.Text = "No Existe"
        Me.LB_ERROR.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DT_FECHA_hasta)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(422, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 52)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha Hasta"
        '
        'DT_FECHA_hasta
        '
        Me.DT_FECHA_hasta.Location = New System.Drawing.Point(6, 19)
        Me.DT_FECHA_hasta.Name = "DT_FECHA_hasta"
        Me.DT_FECHA_hasta.Size = New System.Drawing.Size(220, 20)
        Me.DT_FECHA_hasta.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DT_FECHA_desde)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(182, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 52)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha Desde"
        '
        'DT_FECHA_desde
        '
        Me.DT_FECHA_desde.Location = New System.Drawing.Point(6, 19)
        Me.DT_FECHA_desde.Name = "DT_FECHA_desde"
        Me.DT_FECHA_desde.Size = New System.Drawing.Size(220, 20)
        Me.DT_FECHA_desde.TabIndex = 2
        '
        'Turno_Informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 592)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Turno_Informe"
        Me.Text = "Turno_Informe"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_eliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DT_FECHA_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DT_FECHA_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_Informe_TurnoReservado As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents LB_ERROR As System.Windows.Forms.Label
End Class
