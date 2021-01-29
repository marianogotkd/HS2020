<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terminal_alta
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
        Me.error_dni = New System.Windows.Forms.Label()
        Me.error_razonsocial = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_terminal = New System.Windows.Forms.TextBox()
        Me.Combo_sucursal = New System.Windows.Forms.ComboBox()
        Me.lb_dni = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.error_dni)
        Me.GroupBox1.Controls.Add(Me.error_razonsocial)
        Me.GroupBox1.Controls.Add(Me.btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_terminal)
        Me.GroupBox1.Controls.Add(Me.Combo_sucursal)
        Me.GroupBox1.Controls.Add(Me.lb_dni)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 185)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los datos de la terminal:"
        '
        'error_dni
        '
        Me.error_dni.AutoSize = True
        Me.error_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_dni.ForeColor = System.Drawing.Color.Red
        Me.error_dni.Location = New System.Drawing.Point(449, 72)
        Me.error_dni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_dni.Name = "error_dni"
        Me.error_dni.Size = New System.Drawing.Size(31, 39)
        Me.error_dni.TabIndex = 264
        Me.error_dni.Text = "*"
        Me.error_dni.Visible = False
        '
        'error_razonsocial
        '
        Me.error_razonsocial.AutoSize = True
        Me.error_razonsocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_razonsocial.ForeColor = System.Drawing.Color.Red
        Me.error_razonsocial.Location = New System.Drawing.Point(449, 34)
        Me.error_razonsocial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_razonsocial.Name = "error_razonsocial"
        Me.error_razonsocial.Size = New System.Drawing.Size(31, 39)
        Me.error_razonsocial.TabIndex = 263
        Me.error_razonsocial.Text = "*"
        Me.error_razonsocial.Visible = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Cancelar.Location = New System.Drawing.Point(128, 130)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Cancelar.TabIndex = 11
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(258, 130)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Aceptar.TabIndex = 10
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 253
        Me.Label4.Text = "Terminal:"
        '
        'txt_terminal
        '
        Me.txt_terminal.BackColor = System.Drawing.SystemColors.Info
        Me.txt_terminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_terminal.Location = New System.Drawing.Point(105, 33)
        Me.txt_terminal.Name = "txt_terminal"
        Me.txt_terminal.Size = New System.Drawing.Size(337, 30)
        Me.txt_terminal.TabIndex = 0
        '
        'Combo_sucursal
        '
        Me.Combo_sucursal.BackColor = System.Drawing.SystemColors.Info
        Me.Combo_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_sucursal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_sucursal.FormattingEnabled = True
        Me.Combo_sucursal.Location = New System.Drawing.Point(107, 70)
        Me.Combo_sucursal.Name = "Combo_sucursal"
        Me.Combo_sucursal.Size = New System.Drawing.Size(337, 33)
        Me.Combo_sucursal.TabIndex = 2
        '
        'lb_dni
        '
        Me.lb_dni.AutoSize = True
        Me.lb_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni.ForeColor = System.Drawing.Color.Black
        Me.lb_dni.Location = New System.Drawing.Point(6, 73)
        Me.lb_dni.Name = "lb_dni"
        Me.lb_dni.Size = New System.Drawing.Size(95, 25)
        Me.lb_dni.TabIndex = 237
        Me.lb_dni.Text = "Sucursal:"
        '
        'Terminal_alta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(511, 202)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Terminal_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Terminal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents error_dni As System.Windows.Forms.Label
    Friend WithEvents error_razonsocial As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_terminal As System.Windows.Forms.TextBox
    Friend WithEvents Combo_sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lb_dni As System.Windows.Forms.Label
End Class
