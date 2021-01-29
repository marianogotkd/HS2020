<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicios_Alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servicios_Alta))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Combo_tpoMonto = New System.Windows.Forms.ComboBox()
        Me.tx_descrip = New System.Windows.Forms.TextBox()
        Me.tx_Monto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_cancelar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(313, 190)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(305, 164)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Servicio: Nuevo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Combo_tpoMonto)
        Me.GroupBox1.Controls.Add(Me.tx_descrip)
        Me.GroupBox1.Controls.Add(Me.tx_Monto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Combo_tpoMonto
        '
        Me.Combo_tpoMonto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_tpoMonto.FormattingEnabled = True
        Me.Combo_tpoMonto.Items.AddRange(New Object() {"Fijo", "Variable"})
        Me.Combo_tpoMonto.Location = New System.Drawing.Point(124, 63)
        Me.Combo_tpoMonto.Name = "Combo_tpoMonto"
        Me.Combo_tpoMonto.Size = New System.Drawing.Size(139, 21)
        Me.Combo_tpoMonto.TabIndex = 290
        '
        'tx_descrip
        '
        Me.tx_descrip.Location = New System.Drawing.Point(124, 30)
        Me.tx_descrip.Name = "tx_descrip"
        Me.tx_descrip.Size = New System.Drawing.Size(139, 20)
        Me.tx_descrip.TabIndex = 4
        '
        'tx_Monto
        '
        Me.tx_Monto.Location = New System.Drawing.Point(124, 99)
        Me.tx_Monto.Name = "tx_Monto"
        Me.tx_Monto.Size = New System.Drawing.Size(139, 20)
        Me.tx_Monto.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(19, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 275
        Me.Label3.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(19, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 273
        Me.Label1.Text = "Tipo de Monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(19, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Descripcion"
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.Image = CType(resources.GetObject("Btn_cancelar.Image"), System.Drawing.Image)
        Me.Btn_cancelar.Location = New System.Drawing.Point(331, 120)
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(30, 30)
        Me.Btn_cancelar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Btn_cancelar, "Cancelar")
        Me.Btn_cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Location = New System.Drawing.Point(331, 156)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(30, 30)
        Me.Btn_Guardar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Btn_Guardar, "Guardar")
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Servicios_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(370, 213)
        Me.Controls.Add(Me.Btn_cancelar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(386, 251)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(386, 251)
        Me.Name = "Servicios_Alta"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Combo_tpoMonto As System.Windows.Forms.ComboBox
    Friend WithEvents tx_descrip As System.Windows.Forms.TextBox
    Friend WithEvents tx_Monto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
