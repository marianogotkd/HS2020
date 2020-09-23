<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta_consulta_seleccionar_sucursal
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button_siguiente = New System.Windows.Forms.Button()
        Me.ComboBox_sucursales = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(373, 139)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button_siguiente)
        Me.TabPage1.Controls.Add(Me.ComboBox_sucursales)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(365, 113)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sucursales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button_siguiente
        '
        Me.Button_siguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_siguiente.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_siguiente.Location = New System.Drawing.Point(230, 54)
        Me.Button_siguiente.Name = "Button_siguiente"
        Me.Button_siguiente.Size = New System.Drawing.Size(119, 46)
        Me.Button_siguiente.TabIndex = 242
        Me.Button_siguiente.Text = "Siguiente"
        Me.Button_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_siguiente.UseVisualStyleBackColor = True
        '
        'ComboBox_sucursales
        '
        Me.ComboBox_sucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_sucursales.FormattingEnabled = True
        Me.ComboBox_sucursales.Location = New System.Drawing.Point(22, 24)
        Me.ComboBox_sucursales.MaximumSize = New System.Drawing.Size(327, 0)
        Me.ComboBox_sucursales.MinimumSize = New System.Drawing.Size(327, 0)
        Me.ComboBox_sucursales.Name = "ComboBox_sucursales"
        Me.ComboBox_sucursales.Size = New System.Drawing.Size(327, 21)
        Me.ComboBox_sucursales.TabIndex = 241
        '
        'Venta_consulta_seleccionar_sucursal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(391, 156)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Venta_consulta_seleccionar_sucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione la Sucursal"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button_siguiente As System.Windows.Forms.Button
    Friend WithEvents ComboBox_sucursales As System.Windows.Forms.ComboBox
End Class
