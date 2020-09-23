<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Corte_caja
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
        Me.btn_cerrar_caja = New System.Windows.Forms.Button()
        Me.Img_ok = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BO_cerrarturno = New System.Windows.Forms.Button()
        Me.txt_diferencia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_efectivo_actual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_efectivo_esperado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Img_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_cerrar_caja)
        Me.GroupBox1.Controls.Add(Me.Img_ok)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_usuario)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BO_cerrarturno)
        Me.GroupBox1.Controls.Add(Me.txt_diferencia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_efectivo_actual)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_efectivo_esperado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 386)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese la siguiente información:"
        '
        'btn_cerrar_caja
        '
        Me.btn_cerrar_caja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar_caja.ForeColor = System.Drawing.Color.Green
        Me.btn_cerrar_caja.Location = New System.Drawing.Point(436, 288)
        Me.btn_cerrar_caja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cerrar_caja.Name = "btn_cerrar_caja"
        Me.btn_cerrar_caja.Size = New System.Drawing.Size(192, 69)
        Me.btn_cerrar_caja.TabIndex = 306
        Me.btn_cerrar_caja.Text = "Cerrar Caja"
        Me.btn_cerrar_caja.UseVisualStyleBackColor = True
        '
        'Img_ok
        '
        Me.Img_ok.Image = Global.Aplicacion.My.Resources.Resources.GuardarChico
        Me.Img_ok.Location = New System.Drawing.Point(576, 195)
        Me.Img_ok.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Img_ok.Name = "Img_ok"
        Me.Img_ok.Size = New System.Drawing.Size(20, 20)
        Me.Img_ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Img_ok.TabIndex = 305
        Me.Img_ok.TabStop = False
        Me.Img_ok.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(54, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(429, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "* La diferencia se reflejará en el informe como corte de caja."
        '
        'txt_usuario
        '
        Me.txt_usuario.AutoSize = True
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(120, 35)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(197, 29)
        Me.txt_usuario.TabIndex = 9
        Me.txt_usuario.Text = "-----------------------"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(34, 288)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 69)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BO_cerrarturno
        '
        Me.BO_cerrarturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cerrarturno.ForeColor = System.Drawing.Color.SteelBlue
        Me.BO_cerrarturno.Location = New System.Drawing.Point(236, 288)
        Me.BO_cerrarturno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BO_cerrarturno.Name = "BO_cerrarturno"
        Me.BO_cerrarturno.Size = New System.Drawing.Size(192, 69)
        Me.BO_cerrarturno.TabIndex = 7
        Me.BO_cerrarturno.Text = "Cerrar turno"
        Me.BO_cerrarturno.UseVisualStyleBackColor = True
        '
        'txt_diferencia
        '
        Me.txt_diferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_diferencia.Location = New System.Drawing.Point(170, 189)
        Me.txt_diferencia.Name = "txt_diferencia"
        Me.txt_diferencia.ReadOnly = True
        Me.txt_diferencia.Size = New System.Drawing.Size(396, 35)
        Me.txt_diferencia.TabIndex = 6
        Me.txt_diferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Diferencia: $"
        '
        'txt_efectivo_actual
        '
        Me.txt_efectivo_actual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_efectivo_actual.Location = New System.Drawing.Point(300, 143)
        Me.txt_efectivo_actual.Name = "txt_efectivo_actual"
        Me.txt_efectivo_actual.Size = New System.Drawing.Size(265, 35)
        Me.txt_efectivo_actual.TabIndex = 4
        Me.txt_efectivo_actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Efectivo actual en caja: $"
        '
        'txt_efectivo_esperado
        '
        Me.txt_efectivo_esperado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_efectivo_esperado.Location = New System.Drawing.Point(336, 86)
        Me.txt_efectivo_esperado.Name = "txt_efectivo_esperado"
        Me.txt_efectivo_esperado.ReadOnly = True
        Me.txt_efectivo_esperado.Size = New System.Drawing.Size(229, 35)
        Me.txt_efectivo_esperado.TabIndex = 2
        Me.txt_efectivo_esperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Efectivo esperado en caja: $"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Corte_caja
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(687, 409)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Corte_caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corte de Caja (Cierre de turno del usuario)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Img_ok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_efectivo_esperado As System.Windows.Forms.TextBox
    Friend WithEvents txt_efectivo_actual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_diferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BO_cerrarturno As System.Windows.Forms.Button
    Friend WithEvents txt_usuario As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Img_ok As System.Windows.Forms.PictureBox
    Friend WithEvents btn_cerrar_caja As System.Windows.Forms.Button
End Class
