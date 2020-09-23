<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Productos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tx_Buscar = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_ds = New Aplicacion.Lista_ds()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductosCombosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds = New Aplicacion.Venta_Caja_ds()
        Me.BO_agregar = New System.Windows.Forms.Button()
        Me.BO_salir = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioSubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CombodetallesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds3 = New Aplicacion.Venta_Caja_ds()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lb_combo = New System.Windows.Forms.Label()
        Me.cb_categoria = New System.Windows.Forms.ComboBox()
        Me.Categoria = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_rubro = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_subrubro = New System.Windows.Forms.ComboBox()
        Me.check_subrubro = New System.Windows.Forms.CheckBox()
        Me.check_rubro = New System.Windows.Forms.CheckBox()
        Me.check_categoria = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_marca = New System.Windows.Forms.ComboBox()
        Me.check_marca = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ProductosCombosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoagregadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaCajadsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds1 = New Aplicacion.Venta_Caja_ds()
        Me.CombodetallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds2 = New Aplicacion.Venta_Caja_ds()
        Me.CombodetallesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CombodetallesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescrilargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdpreciovtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_precio_vta_May = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdptorepoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_codbarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosCombosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombodetallesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ProductosCombosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaCajadsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombodetallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombodetallesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombodetallesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tx_Buscar
        '
        Me.tx_Buscar.BackColor = System.Drawing.Color.White
        Me.tx_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Buscar.Location = New System.Drawing.Point(18, 13)
        Me.tx_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Buscar.Name = "tx_Buscar"
        Me.tx_Buscar.Size = New System.Drawing.Size(932, 30)
        Me.tx_Buscar.TabIndex = 0
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Lista_ds
        '
        'Lista_ds
        '
        Me.Lista_ds.DataSetName = "Lista_ds"
        Me.Lista_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdidDataGridViewTextBoxColumn, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ProddescrilargaDataGridViewTextBoxColumn, Me.ProdpreciovtaDataGridViewTextBoxColumn, Me.prod_precio_vta_May, Me.ProdstockDataGridViewTextBoxColumn, Me.ProdptorepoDataGridViewTextBoxColumn, Me.prod_codbarra})
        Me.DataGridView1.DataSource = Me.ProductosCombosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(30, 203)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(909, 252)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 1
        '
        'ProductosCombosBindingSource1
        '
        Me.ProductosCombosBindingSource1.DataMember = "Productos_Combos"
        Me.ProductosCombosBindingSource1.DataSource = Me.Venta_Caja_ds
        '
        'Venta_Caja_ds
        '
        Me.Venta_Caja_ds.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_agregar
        '
        Me.BO_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_agregar.Location = New System.Drawing.Point(740, 478)
        Me.BO_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_agregar.Name = "BO_agregar"
        Me.BO_agregar.Size = New System.Drawing.Size(100, 28)
        Me.BO_agregar.TabIndex = 2
        Me.BO_agregar.Text = "Agregar"
        Me.BO_agregar.UseVisualStyleBackColor = True
        '
        'BO_salir
        '
        Me.BO_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_salir.Location = New System.Drawing.Point(850, 478)
        Me.BO_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_salir.Name = "BO_salir"
        Me.BO_salir.Size = New System.Drawing.Size(100, 28)
        Me.BO_salir.TabIndex = 3
        Me.BO_salir.Text = "Salir (ESC)"
        Me.BO_salir.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripciónDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioUDataGridViewTextBoxColumn, Me.PrecioSubtotalDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CombodetallesBindingSource3
        Me.DataGridView2.Location = New System.Drawing.Point(23, 768)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(583, 139)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 4
        Me.DataGridView2.TabStop = False
        Me.DataGridView2.Visible = False
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripciónDataGridViewTextBoxColumn.Width = 200
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 70
        '
        'PrecioUDataGridViewTextBoxColumn
        '
        Me.PrecioUDataGridViewTextBoxColumn.DataPropertyName = "Precio U."
        Me.PrecioUDataGridViewTextBoxColumn.HeaderText = "Precio Unit."
        Me.PrecioUDataGridViewTextBoxColumn.Name = "PrecioUDataGridViewTextBoxColumn"
        Me.PrecioUDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioUDataGridViewTextBoxColumn.Width = 120
        '
        'PrecioSubtotalDataGridViewTextBoxColumn
        '
        Me.PrecioSubtotalDataGridViewTextBoxColumn.DataPropertyName = "Precio Subtotal"
        Me.PrecioSubtotalDataGridViewTextBoxColumn.HeaderText = "Precio Subtotal"
        Me.PrecioSubtotalDataGridViewTextBoxColumn.Name = "PrecioSubtotalDataGridViewTextBoxColumn"
        Me.PrecioSubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioSubtotalDataGridViewTextBoxColumn.Width = 170
        '
        'CombodetallesBindingSource3
        '
        Me.CombodetallesBindingSource3.DataMember = "Combo_detalles"
        Me.CombodetallesBindingSource3.DataSource = Me.Venta_Caja_ds3
        '
        'Venta_Caja_ds3
        '
        Me.Venta_Caja_ds3.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(19, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Listado Productos :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(25, 744)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Detalla de combos seleccionado:"
        Me.Label3.Visible = False
        '
        'Lb_combo
        '
        Me.Lb_combo.AutoSize = True
        Me.Lb_combo.BackColor = System.Drawing.Color.Transparent
        Me.Lb_combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_combo.Location = New System.Drawing.Point(252, 744)
        Me.Lb_combo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_combo.Name = "Lb_combo"
        Me.Lb_combo.Size = New System.Drawing.Size(211, 20)
        Me.Lb_combo.TabIndex = 6
        Me.Lb_combo.Text = "- - - - - - - - - - - - - - - -"
        Me.Lb_combo.Visible = False
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
        Me.cb_categoria.Size = New System.Drawing.Size(191, 28)
        Me.cb_categoria.TabIndex = 10
        '
        'Categoria
        '
        Me.Categoria.AutoSize = True
        Me.Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categoria.Location = New System.Drawing.Point(43, 37)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(82, 20)
        Me.Categoria.TabIndex = 11
        Me.Categoria.Text = "Categoria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(379, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Rubro:"
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
        Me.cb_rubro.Size = New System.Drawing.Size(173, 28)
        Me.cb_rubro.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(660, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Subrubro:"
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
        Me.cb_subrubro.Size = New System.Drawing.Size(173, 28)
        Me.cb_subrubro.TabIndex = 14
        '
        'check_subrubro
        '
        Me.check_subrubro.AutoSize = True
        Me.check_subrubro.Enabled = False
        Me.check_subrubro.Location = New System.Drawing.Point(631, 41)
        Me.check_subrubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_subrubro.Name = "check_subrubro"
        Me.check_subrubro.Size = New System.Drawing.Size(22, 21)
        Me.check_subrubro.TabIndex = 17
        Me.check_subrubro.UseVisualStyleBackColor = True
        '
        'check_rubro
        '
        Me.check_rubro.AutoSize = True
        Me.check_rubro.Enabled = False
        Me.check_rubro.Location = New System.Drawing.Point(350, 38)
        Me.check_rubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_rubro.Name = "check_rubro"
        Me.check_rubro.Size = New System.Drawing.Size(22, 21)
        Me.check_rubro.TabIndex = 16
        Me.check_rubro.UseVisualStyleBackColor = True
        '
        'check_categoria
        '
        Me.check_categoria.AutoSize = True
        Me.check_categoria.Location = New System.Drawing.Point(14, 37)
        Me.check_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.check_categoria.Name = "check_categoria"
        Me.check_categoria.Size = New System.Drawing.Size(22, 21)
        Me.check_categoria.TabIndex = 18
        Me.check_categoria.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Marca:"
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
        Me.cb_marca.Size = New System.Drawing.Size(162, 28)
        Me.cb_marca.TabIndex = 20
        '
        'check_marca
        '
        Me.check_marca.AutoSize = True
        Me.check_marca.Location = New System.Drawing.Point(14, 11)
        Me.check_marca.Margin = New System.Windows.Forms.Padding(4)
        Me.check_marca.Name = "check_marca"
        Me.check_marca.Size = New System.Drawing.Size(22, 21)
        Me.check_marca.TabIndex = 21
        Me.check_marca.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(944, 108)
        Me.TabControl1.TabIndex = 22
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(936, 75)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filtro"
        '
        'ProductosCombosBindingSource
        '
        Me.ProductosCombosBindingSource.DataMember = "Productos_Combos"
        Me.ProductosCombosBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'ProductoagregadoBindingSource
        '
        Me.ProductoagregadoBindingSource.DataMember = "Producto_agregado"
        Me.ProductoagregadoBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'VentaCajadsBindingSource
        '
        Me.VentaCajadsBindingSource.DataSource = Me.Venta_Caja_ds
        Me.VentaCajadsBindingSource.Position = 0
        '
        'Venta_Caja_ds1
        '
        Me.Venta_Caja_ds1.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CombodetallesBindingSource
        '
        Me.CombodetallesBindingSource.DataMember = "Combo_detalles"
        Me.CombodetallesBindingSource.DataSource = Me.Venta_Caja_ds1
        '
        'Venta_Caja_ds2
        '
        Me.Venta_Caja_ds2.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CombodetallesBindingSource1
        '
        Me.CombodetallesBindingSource1.DataMember = "Combo_detalles"
        Me.CombodetallesBindingSource1.DataSource = Me.Venta_Caja_ds2
        '
        'CombodetallesBindingSource2
        '
        Me.CombodetallesBindingSource2.DataMember = "Combo_detalles"
        Me.CombodetallesBindingSource2.DataSource = Me.Venta_Caja_ds2
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(965, 512)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(24, 198)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(925, 265)
        Me.RectangleShape1.Visible = False
        '
        'ProdidDataGridViewTextBoxColumn
        '
        Me.ProdidDataGridViewTextBoxColumn.DataPropertyName = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.HeaderText = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.Name = "ProdidDataGridViewTextBoxColumn"
        Me.ProdidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdidDataGridViewTextBoxColumn.Visible = False
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.FillWeight = 253.8071!
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Cód."
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.FillWeight = 61.54822!
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProddescrilargaDataGridViewTextBoxColumn
        '
        Me.ProddescrilargaDataGridViewTextBoxColumn.DataPropertyName = "prod_descrilarga"
        Me.ProddescrilargaDataGridViewTextBoxColumn.HeaderText = "prod_descrilarga"
        Me.ProddescrilargaDataGridViewTextBoxColumn.Name = "ProddescrilargaDataGridViewTextBoxColumn"
        Me.ProddescrilargaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescrilargaDataGridViewTextBoxColumn.Visible = False
        '
        'ProdpreciovtaDataGridViewTextBoxColumn
        '
        Me.ProdpreciovtaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProdpreciovtaDataGridViewTextBoxColumn.DataPropertyName = "prod_precio_vta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.FillWeight = 61.54822!
        Me.ProdpreciovtaDataGridViewTextBoxColumn.HeaderText = "Precio Minorista"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Name = "ProdpreciovtaDataGridViewTextBoxColumn"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Width = 150
        '
        'prod_precio_vta_May
        '
        Me.prod_precio_vta_May.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.prod_precio_vta_May.DataPropertyName = "prod_precio_vta_May"
        Me.prod_precio_vta_May.FillWeight = 61.54822!
        Me.prod_precio_vta_May.HeaderText = "Precio Mayorista"
        Me.prod_precio_vta_May.Name = "prod_precio_vta_May"
        Me.prod_precio_vta_May.ReadOnly = True
        Me.prod_precio_vta_May.Width = 150
        '
        'ProdstockDataGridViewTextBoxColumn
        '
        Me.ProdstockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProdstockDataGridViewTextBoxColumn.DataPropertyName = "prod_stock"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ProdstockDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProdstockDataGridViewTextBoxColumn.FillWeight = 61.54822!
        Me.ProdstockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.ProdstockDataGridViewTextBoxColumn.Name = "ProdstockDataGridViewTextBoxColumn"
        Me.ProdstockDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdstockDataGridViewTextBoxColumn.Width = 120
        '
        'ProdptorepoDataGridViewTextBoxColumn
        '
        Me.ProdptorepoDataGridViewTextBoxColumn.DataPropertyName = "prod_ptorepo"
        Me.ProdptorepoDataGridViewTextBoxColumn.HeaderText = "prod_ptorepo"
        Me.ProdptorepoDataGridViewTextBoxColumn.Name = "ProdptorepoDataGridViewTextBoxColumn"
        Me.ProdptorepoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdptorepoDataGridViewTextBoxColumn.Visible = False
        '
        'prod_codbarra
        '
        Me.prod_codbarra.DataPropertyName = "prod_codbarra"
        Me.prod_codbarra.HeaderText = "prod_codbarra"
        Me.prod_codbarra.Name = "prod_codbarra"
        Me.prod_codbarra.ReadOnly = True
        Me.prod_codbarra.Visible = False
        '
        'Busqueda_Productos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(965, 512)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Lb_combo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BO_salir)
        Me.Controls.Add(Me.BO_agregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tx_Buscar)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(741, 552)
        Me.Name = "Busqueda_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de productos"
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosCombosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombodetallesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ProductosCombosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaCajadsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombodetallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombodetallesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombodetallesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents ProductoagregadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_Caja_ds As Aplicacion.Venta_Caja_ds
    Friend WithEvents VentaCajadsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_ds As Aplicacion.Lista_ds
    Friend WithEvents ProductosCombosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductosCombosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BO_agregar As System.Windows.Forms.Button
    Friend WithEvents BO_salir As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents CombodetallesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_Caja_ds1 As Aplicacion.Venta_Caja_ds
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lb_combo As System.Windows.Forms.Label
    Friend WithEvents CombodetallesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_Caja_ds2 As Aplicacion.Venta_Caja_ds
    Friend WithEvents CombodetallesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CombodetallesBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_Caja_ds3 As Aplicacion.Venta_Caja_ds
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioSubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Categoria As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_rubro As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_subrubro As System.Windows.Forms.ComboBox
    Friend WithEvents check_subrubro As System.Windows.Forms.CheckBox
    Friend WithEvents check_rubro As System.Windows.Forms.CheckBox
    Friend WithEvents check_categoria As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents check_marca As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescrilargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdpreciovtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_precio_vta_May As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdstockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdptorepoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_codbarra As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
