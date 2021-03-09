<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos_New
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
        Me.GP_Proveedor = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Combo_Prove = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tx_codigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GP_Proveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'GP_Proveedor
        '
        Me.GP_Proveedor.Controls.Add(Me.Button1)
        Me.GP_Proveedor.Controls.Add(Me.Combo_Prove)
        Me.GP_Proveedor.Controls.Add(Me.Label3)
        Me.GP_Proveedor.Controls.Add(Me.Label1)
        Me.GP_Proveedor.Controls.Add(Me.DateTimePicker1)
        Me.GP_Proveedor.Controls.Add(Me.tx_codigo)
        Me.GP_Proveedor.Controls.Add(Me.Label2)
        Me.GP_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP_Proveedor.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Proveedor.Location = New System.Drawing.Point(8, 2)
        Me.GP_Proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.GP_Proveedor.Name = "GP_Proveedor"
        Me.GP_Proveedor.Padding = New System.Windows.Forms.Padding(4)
        Me.GP_Proveedor.Size = New System.Drawing.Size(392, 208)
        Me.GP_Proveedor.TabIndex = 244
        Me.GP_Proveedor.TabStop = False
        Me.GP_Proveedor.Text = "Pedido"
        '
        'Button1
        '
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button1.Location = New System.Drawing.Point(238, 137)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 43)
        Me.Button1.TabIndex = 245
        Me.Button1.Text = "Continuar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Continuar con la carga del pedido")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Combo_Prove
        '
        Me.Combo_Prove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Prove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_Prove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Prove.FormattingEnabled = True
        Me.Combo_Prove.Location = New System.Drawing.Point(119, 101)
        Me.Combo_Prove.Margin = New System.Windows.Forms.Padding(4)
        Me.Combo_Prove.Name = "Combo_Prove"
        Me.Combo_Prove.Size = New System.Drawing.Size(243, 28)
        Me.Combo_Prove.TabIndex = 243
        Me.ToolTip1.SetToolTip(Me.Combo_Prove, "Seleccione proveedor")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(19, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "N° Pedido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(15, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proveedor:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 33)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(243, 26)
        Me.DateTimePicker1.TabIndex = 237
        Me.ToolTip1.SetToolTip(Me.DateTimePicker1, "Seleccione fecha de pedido")
        '
        'tx_codigo
        '
        Me.tx_codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tx_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_codigo.Location = New System.Drawing.Point(119, 67)
        Me.tx_codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_codigo.Name = "tx_codigo"
        Me.tx_codigo.ReadOnly = True
        Me.tx_codigo.Size = New System.Drawing.Size(88, 26)
        Me.tx_codigo.TabIndex = 241
        Me.tx_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tx_codigo, "Numero de pedido")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(18, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "Fecha:"
        '
        'Pedidos_New
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(405, 187)
        Me.Controls.Add(Me.GP_Proveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pedidos_New"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar nuevo pedido"
        Me.GP_Proveedor.ResumeLayout(False)
        Me.GP_Proveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GP_Proveedor As System.Windows.Forms.GroupBox
    Friend WithEvents Combo_Prove As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tx_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
