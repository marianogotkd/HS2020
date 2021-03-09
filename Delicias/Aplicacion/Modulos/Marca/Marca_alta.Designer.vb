<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marca_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marca_alta))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tx_nom_marca = New System.Windows.Forms.TextBox()
        Me.Lb_nombre_marca = New System.Windows.Forms.Label()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 14)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(481, 114)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tx_nom_marca)
        Me.TabPage1.Controls.Add(Me.Lb_nombre_marca)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(473, 83)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos de Marca"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tx_nom_marca
        '
        Me.tx_nom_marca.Location = New System.Drawing.Point(97, 31)
        Me.tx_nom_marca.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_nom_marca.Name = "tx_nom_marca"
        Me.tx_nom_marca.Size = New System.Drawing.Size(349, 24)
        Me.tx_nom_marca.TabIndex = 1
        '
        'Lb_nombre_marca
        '
        Me.Lb_nombre_marca.AutoSize = True
        Me.Lb_nombre_marca.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Lb_nombre_marca.Location = New System.Drawing.Point(31, 34)
        Me.Lb_nombre_marca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_nombre_marca.Name = "Lb_nombre_marca"
        Me.Lb_nombre_marca.Size = New System.Drawing.Size(62, 18)
        Me.Lb_nombre_marca.TabIndex = 0
        Me.Lb_nombre_marca.Text = "Nombre"
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(397, 136)
        Me.Bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(93, 37)
        Me.Bo_guardar.TabIndex = 1
        Me.Bo_guardar.Text = "Guardar"
        Me.Bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_guardar, "Guardar")
        Me.Bo_guardar.UseVisualStyleBackColor = True
        '
        'Marca_alta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(523, 188)
        Me.Controls.Add(Me.Bo_guardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(529, 217)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(529, 217)
        Me.Name = "Marca_alta"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marca"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tx_nom_marca As System.Windows.Forms.TextBox
    Friend WithEvents Lb_nombre_marca As System.Windows.Forms.Label
    Friend WithEvents Bo_guardar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
