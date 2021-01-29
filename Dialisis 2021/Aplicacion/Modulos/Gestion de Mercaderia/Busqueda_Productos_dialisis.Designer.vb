<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Productos_dialisis
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tx_Buscar = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cb_marca = New System.Windows.Forms.ComboBox()
        Me.check_marca = New System.Windows.Forms.CheckBox()
        Me.Categoria = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.check_subrubro = New System.Windows.Forms.CheckBox()
        Me.check_categoria = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.check_rubro = New System.Windows.Forms.CheckBox()
        Me.cb_subrubro = New System.Windows.Forms.ComboBox()
        Me.cb_categoria = New System.Windows.Forms.ComboBox()
        Me.cb_rubro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.prod_precio_vta_May = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_codbarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BO_agregar = New System.Windows.Forms.Button()
        Me.BO_salir = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tx_Buscar
        '
        Me.tx_Buscar.BackColor = System.Drawing.Color.White
        Me.tx_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Buscar.Location = New System.Drawing.Point(18, 13)
        Me.tx_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Buscar.Name = "tx_Buscar"
        Me.tx_Buscar.Size = New System.Drawing.Size(932, 22)
        Me.tx_Buscar.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(18, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(944, 108)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.cb_marca)
        Me.TabPage2.Controls.Add(Me.check_marca)
        Me.TabPage2.Controls.Add(Me.Categoria)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.check_subrubro)
        Me.TabPage2.Controls.Add(Me.check_categoria)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.check_rubro)
        Me.TabPage2.Controls.Add(Me.cb_subrubro)
        Me.TabPage2.Controls.Add(Me.cb_categoria)
        Me.TabPage2.Controls.Add(Me.cb_rubro)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(936, 82)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filtro"
        '
        'cb_marca
        '
        Me.cb_marca.BackColor = System.Drawing.SystemColors.Info
        Me.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_marca.Enabled = False
        Me.cb_marca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_marca.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cb_marca.FormattingEnabled = True
        Me.cb_marca.Location = New System.Drawing.Point(100, 6)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(162, 21)
        Me.cb_marca.TabIndex = 20
        '
        'check_marca
        '
        Me.check_marca.AutoSize = True
        Me.check_marca.Location = New System.Drawing.Point(14, 11)
        Me.check_marca.Margin = New System.Windows.Forms.Padding(4)
        Me.check_marca.Name = "check_marca"
        Me.check_marca.Size = New System.Drawing.Size(15, 14)
        Me.check_marca.TabIndex = 21
        Me.check_marca.UseVisualStyleBackColor = True
        '
        'Categoria
        '
        Me.Categoria.AutoSize = True
        Me.Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categoria.Location = New System.Drawing.Point(43, 37)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(55, 13)
        Me.Categoria.TabIndex = 11
        Me.Categoria.Text = "Categoria:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Marca:"
        '
        'check_subrubro
        '
        Me.check_subrubro.AutoSize = True
        Me.check_subrubro.Enabled = False
        Me.check_subrubro.Location = New System.Drawing.Point(631, 41)
        Me.check_subrubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_subrubro.Name = "check_subrubro"
        Me.check_subrubro.Size = New System.Drawing.Size(15, 14)
        Me.check_subrubro.TabIndex = 17
        Me.check_subrubro.UseVisualStyleBackColor = True
        '
        'check_categoria
        '
        Me.check_categoria.AutoSize = True
        Me.check_categoria.Location = New System.Drawing.Point(14, 37)
        Me.check_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.check_categoria.Name = "check_categoria"
        Me.check_categoria.Size = New System.Drawing.Size(15, 14)
        Me.check_categoria.TabIndex = 18
        Me.check_categoria.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(660, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Subrubro:"
        '
        'check_rubro
        '
        Me.check_rubro.AutoSize = True
        Me.check_rubro.Enabled = False
        Me.check_rubro.Location = New System.Drawing.Point(350, 38)
        Me.check_rubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_rubro.Name = "check_rubro"
        Me.check_rubro.Size = New System.Drawing.Size(15, 14)
        Me.check_rubro.TabIndex = 16
        Me.check_rubro.UseVisualStyleBackColor = True
        '
        'cb_subrubro
        '
        Me.cb_subrubro.BackColor = System.Drawing.SystemColors.Info
        Me.cb_subrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_subrubro.Enabled = False
        Me.cb_subrubro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_subrubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_subrubro.FormattingEnabled = True
        Me.cb_subrubro.Location = New System.Drawing.Point(760, 37)
        Me.cb_subrubro.Name = "cb_subrubro"
        Me.cb_subrubro.Size = New System.Drawing.Size(173, 21)
        Me.cb_subrubro.TabIndex = 14
        '
        'cb_categoria
        '
        Me.cb_categoria.BackColor = System.Drawing.SystemColors.Info
        Me.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_categoria.Enabled = False
        Me.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(129, 37)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(191, 21)
        Me.cb_categoria.TabIndex = 10
        '
        'cb_rubro
        '
        Me.cb_rubro.BackColor = System.Drawing.SystemColors.Info
        Me.cb_rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_rubro.Enabled = False
        Me.cb_rubro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_rubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_rubro.FormattingEnabled = True
        Me.cb_rubro.Location = New System.Drawing.Point(442, 39)
        Me.cb_rubro.Name = "cb_rubro"
        Me.cb_rubro.Size = New System.Drawing.Size(173, 21)
        Me.cb_rubro.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(379, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Rubro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(19, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Listado Productos :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod_precio_vta_May, Me.prod_codbarra})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 184)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(909, 252)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 25
        '
        'prod_precio_vta_May
        '
        Me.prod_precio_vta_May.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.prod_precio_vta_May.DataPropertyName = "prod_precio_vta_May"
        Me.prod_precio_vta_May.FillWeight = 61.54822!
        Me.prod_precio_vta_May.HeaderText = "Precio Mayorista"
        Me.prod_precio_vta_May.Name = "prod_precio_vta_May"
        Me.prod_precio_vta_May.ReadOnly = True
        Me.prod_precio_vta_May.Visible = False
        Me.prod_precio_vta_May.Width = 150
        '
        'prod_codbarra
        '
        Me.prod_codbarra.DataPropertyName = "prod_codbarra"
        Me.prod_codbarra.HeaderText = "prod_codbarra"
        Me.prod_codbarra.Name = "prod_codbarra"
        Me.prod_codbarra.ReadOnly = True
        Me.prod_codbarra.Visible = False
        '
        'BO_agregar
        '
        Me.BO_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_agregar.Location = New System.Drawing.Point(719, 444)
        Me.BO_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_agregar.Name = "BO_agregar"
        Me.BO_agregar.Size = New System.Drawing.Size(100, 28)
        Me.BO_agregar.TabIndex = 26
        Me.BO_agregar.Text = "Agregar"
        Me.BO_agregar.UseVisualStyleBackColor = True
        '
        'BO_salir
        '
        Me.BO_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_salir.Location = New System.Drawing.Point(827, 444)
        Me.BO_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_salir.Name = "BO_salir"
        Me.BO_salir.Size = New System.Drawing.Size(100, 28)
        Me.BO_salir.TabIndex = 27
        Me.BO_salir.Text = "Salir (ESC)"
        Me.BO_salir.UseVisualStyleBackColor = True
        '
        'Busqueda_Productos_dialisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(972, 475)
        Me.Controls.Add(Me.BO_salir)
        Me.Controls.Add(Me.BO_agregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tx_Buscar)
        Me.Name = "Busqueda_Productos_dialisis"
        Me.Text = "Busqueda_Productos_dialisis"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents check_marca As System.Windows.Forms.CheckBox
    Friend WithEvents Categoria As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents check_subrubro As System.Windows.Forms.CheckBox
    Friend WithEvents check_categoria As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents check_rubro As System.Windows.Forms.CheckBox
    Friend WithEvents cb_subrubro As System.Windows.Forms.ComboBox
    Friend WithEvents cb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents cb_rubro As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents prod_precio_vta_May As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_codbarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BO_agregar As System.Windows.Forms.Button
    Friend WithEvents BO_salir As System.Windows.Forms.Button
End Class
