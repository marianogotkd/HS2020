<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccion_Terminal
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
        Me.Button_siguiente = New System.Windows.Forms.Button()
        Me.ComboBox_Terminales = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_siguiente
        '
        Me.Button_siguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_siguiente.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_siguiente.Location = New System.Drawing.Point(144, 107)
        Me.Button_siguiente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_siguiente.Name = "Button_siguiente"
        Me.Button_siguiente.Size = New System.Drawing.Size(159, 57)
        Me.Button_siguiente.TabIndex = 242
        Me.Button_siguiente.Text = "Siguiente"
        Me.Button_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_siguiente.UseVisualStyleBackColor = True
        '
        'ComboBox_Terminales
        '
        Me.ComboBox_Terminales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Terminales.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Terminales.FormattingEnabled = True
        Me.ComboBox_Terminales.Location = New System.Drawing.Point(16, 52)
        Me.ComboBox_Terminales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox_Terminales.MaximumSize = New System.Drawing.Size(435, 0)
        Me.ComboBox_Terminales.MinimumSize = New System.Drawing.Size(435, 0)
        Me.ComboBox_Terminales.Name = "ComboBox_Terminales"
        Me.ComboBox_Terminales.Size = New System.Drawing.Size(435, 47)
        Me.ComboBox_Terminales.TabIndex = 241
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button_siguiente)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Terminales)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 175)
        Me.GroupBox1.TabIndex = 243
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bienvenido!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 17)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "Para continuar, por favor seleccione la terminal donde trabajará:"
        '
        'Seleccion_Terminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 195)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Seleccion_Terminal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECCION DE TERMINAL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_siguiente As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Terminales As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
