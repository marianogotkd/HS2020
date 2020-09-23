<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccion_Terminal_2020
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
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_siguiente = New System.Windows.Forms.Button()
        Me.ComboBox_Terminales = New System.Windows.Forms.ComboBox()
        Me.PanelCabecera.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelCabecera.Controls.Add(Me.btn_minimizar)
        Me.PanelCabecera.Controls.Add(Me.btn_cerrar)
        Me.PanelCabecera.Controls.Add(Me.Label3)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(757, 40)
        Me.PanelCabecera.TabIndex = 0
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimizar.BackgroundImage = Global.Aplicacion.My.Resources.Resources.Icono_Minimizar
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Location = New System.Drawing.Point(668, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_minimizar.TabIndex = 245
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.BackgroundImage = Global.Aplicacion.My.Resources.Resources.Icono_cerrar_FN
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Location = New System.Drawing.Point(714, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cerrar.TabIndex = 245
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 15)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "HAMERSOFT - SELECCION DE TERMINAL"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(757, 228)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button_siguiente)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Terminales)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(153, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(445, 166)
        Me.GroupBox1.TabIndex = 244
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bienvenido!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 17)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "Para continuar, por favor seleccione la terminal donde trabajará:"
        '
        'Button_siguiente
        '
        Me.Button_siguiente.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.Button_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_siguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_siguiente.ForeColor = System.Drawing.Color.Black
        Me.Button_siguiente.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_siguiente.Location = New System.Drawing.Point(312, 104)
        Me.Button_siguiente.Name = "Button_siguiente"
        Me.Button_siguiente.Size = New System.Drawing.Size(119, 46)
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
        Me.ComboBox_Terminales.Location = New System.Drawing.Point(19, 45)
        Me.ComboBox_Terminales.MaximumSize = New System.Drawing.Size(327, 0)
        Me.ComboBox_Terminales.MinimumSize = New System.Drawing.Size(327, 0)
        Me.ComboBox_Terminales.Name = "ComboBox_Terminales"
        Me.ComboBox_Terminales.Size = New System.Drawing.Size(327, 39)
        Me.ComboBox_Terminales.TabIndex = 241
        '
        'Seleccion_Terminal_2020
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(757, 268)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Seleccion_Terminal_2020"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion_Terminal_2020"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelCabecera As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_siguiente As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Terminales As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_minimizar As System.Windows.Forms.Button
End Class
