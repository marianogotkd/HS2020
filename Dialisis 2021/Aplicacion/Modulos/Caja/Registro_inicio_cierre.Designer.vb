<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_inicio_cierre
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_inicio_cierre))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BO_Abrir = New System.Windows.Forms.Button()
        Me.BO_cierre = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.LB_Error = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BO_Abrir
        '
        Me.BO_Abrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Abrir.Image = CType(resources.GetObject("BO_Abrir.Image"), System.Drawing.Image)
        Me.BO_Abrir.Location = New System.Drawing.Point(6, 28)
        Me.BO_Abrir.Name = "BO_Abrir"
        Me.BO_Abrir.Size = New System.Drawing.Size(105, 45)
        Me.BO_Abrir.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BO_Abrir, "Inicio Caja")
        Me.BO_Abrir.UseVisualStyleBackColor = True
        '
        'BO_cierre
        '
        Me.BO_cierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cierre.Image = CType(resources.GetObject("BO_cierre.Image"), System.Drawing.Image)
        Me.BO_cierre.Location = New System.Drawing.Point(120, 28)
        Me.BO_cierre.Name = "BO_cierre"
        Me.BO_cierre.Size = New System.Drawing.Size(105, 45)
        Me.BO_cierre.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BO_cierre, "Cierre caja")
        Me.BO_cierre.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IM_ERROR)
        Me.GroupBox1.Controls.Add(Me.LB_Error)
        Me.GroupBox1.Controls.Add(Me.BO_Abrir)
        Me.GroupBox1.Controls.Add(Me.BO_cierre)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 105)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(261, 144)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(253, 118)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Caja: Registro de Inicio y Cierre"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'IM_ERROR
        '
        Me.IM_ERROR.BackColor = System.Drawing.Color.Transparent
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(6, 79)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 239
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'LB_Error
        '
        Me.LB_Error.AutoSize = True
        Me.LB_Error.BackColor = System.Drawing.Color.Transparent
        Me.LB_Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Error.ForeColor = System.Drawing.Color.Red
        Me.LB_Error.Location = New System.Drawing.Point(25, 81)
        Me.LB_Error.Name = "LB_Error"
        Me.LB_Error.Size = New System.Drawing.Size(204, 15)
        Me.LB_Error.TabIndex = 238
        Me.LB_Error.Text = "Existe CAJA de otro Usuario Iniciada"
        Me.LB_Error.Visible = False
        '
        'Registro_inicio_cierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(282, 170)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(298, 208)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(298, 208)
        Me.Name = "Registro_inicio_cierre"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BO_Abrir As System.Windows.Forms.Button
    Friend WithEvents BO_cierre As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents LB_Error As System.Windows.Forms.Label
End Class
