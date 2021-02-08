<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GM_Consultar_Stock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BO_ver = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescrilargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdpreciovtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdptorepoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodbarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantvencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdconsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds = New Aplicacion.Venta_Caja_ds()
        Me.cb_sucursal = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
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
        Me.tx_Buscar = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txt_totalunidades = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_totalunidades = New System.Windows.Forms.Label()
        Me.Label_codigo = New System.Windows.Forms.Label()
        Me.Label_descripcion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ProdidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdxSucstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotenroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotecantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotefechafabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotefechavtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotevenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Prov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotebajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotebajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(998, 603)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.BO_ver)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.cb_sucursal)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Controls.Add(Me.tx_Buscar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(990, 577)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Productos en stock"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(682, 523)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 251
        Me.Button1.Text = "Generar reporte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BO_ver
        '
        Me.BO_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_ver.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_ver.Location = New System.Drawing.Point(814, 524)
        Me.BO_ver.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_ver.Name = "BO_ver"
        Me.BO_ver.Size = New System.Drawing.Size(141, 43)
        Me.BO_ver.TabIndex = 249
        Me.BO_ver.Text = "Siguiente"
        Me.BO_ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_ver.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 506)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 62)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Referencias para control de productos:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(234, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Vencido"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Stock bajo"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Red
        Me.PictureBox4.Location = New System.Drawing.Point(200, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Blue
        Me.PictureBox5.Location = New System.Drawing.Point(10, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdidDataGridViewTextBoxColumn, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ProddescrilargaDataGridViewTextBoxColumn, Me.ProdpreciovtaDataGridViewTextBoxColumn, Me.ProdstockDataGridViewTextBoxColumn, Me.ProdptorepoDataGridViewTextBoxColumn, Me.ProdpreciovtaMayDataGridViewTextBoxColumn, Me.ProdcodbarraDataGridViewTextBoxColumn, Me.CantvencimientoDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridView1.DataSource = Me.ProdconsultaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 247)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(943, 252)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 30
        '
        'ProdidDataGridViewTextBoxColumn
        '
        Me.ProdidDataGridViewTextBoxColumn.DataPropertyName = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.HeaderText = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.Name = "ProdidDataGridViewTextBoxColumn"
        Me.ProdidDataGridViewTextBoxColumn.Visible = False
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.FillWeight = 304.5685!
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdcodinternoDataGridViewTextBoxColumn.Width = 120
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.FillWeight = 48.85786!
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn.Width = 300
        '
        'ProddescrilargaDataGridViewTextBoxColumn
        '
        Me.ProddescrilargaDataGridViewTextBoxColumn.DataPropertyName = "prod_descrilarga"
        Me.ProddescrilargaDataGridViewTextBoxColumn.HeaderText = "prod_descrilarga"
        Me.ProddescrilargaDataGridViewTextBoxColumn.Name = "ProddescrilargaDataGridViewTextBoxColumn"
        Me.ProddescrilargaDataGridViewTextBoxColumn.Visible = False
        '
        'ProdpreciovtaDataGridViewTextBoxColumn
        '
        Me.ProdpreciovtaDataGridViewTextBoxColumn.DataPropertyName = "prod_precio_vta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.HeaderText = "prod_precio_vta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Name = "ProdpreciovtaDataGridViewTextBoxColumn"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Visible = False
        '
        'ProdstockDataGridViewTextBoxColumn
        '
        Me.ProdstockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProdstockDataGridViewTextBoxColumn.DataPropertyName = "prod_stock"
        Me.ProdstockDataGridViewTextBoxColumn.FillWeight = 48.85786!
        Me.ProdstockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.ProdstockDataGridViewTextBoxColumn.Name = "ProdstockDataGridViewTextBoxColumn"
        Me.ProdstockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdptorepoDataGridViewTextBoxColumn
        '
        Me.ProdptorepoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProdptorepoDataGridViewTextBoxColumn.DataPropertyName = "prod_ptorepo"
        Me.ProdptorepoDataGridViewTextBoxColumn.FillWeight = 48.85786!
        Me.ProdptorepoDataGridViewTextBoxColumn.HeaderText = "Pto.Reposición"
        Me.ProdptorepoDataGridViewTextBoxColumn.Name = "ProdptorepoDataGridViewTextBoxColumn"
        Me.ProdptorepoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdptorepoDataGridViewTextBoxColumn.Width = 130
        '
        'ProdpreciovtaMayDataGridViewTextBoxColumn
        '
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn.DataPropertyName = "prod_precio_vta_May"
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn.HeaderText = "prod_precio_vta_May"
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn.Name = "ProdpreciovtaMayDataGridViewTextBoxColumn"
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn.Visible = False
        '
        'ProdcodbarraDataGridViewTextBoxColumn
        '
        Me.ProdcodbarraDataGridViewTextBoxColumn.DataPropertyName = "prod_codbarra"
        Me.ProdcodbarraDataGridViewTextBoxColumn.HeaderText = "prod_codbarra"
        Me.ProdcodbarraDataGridViewTextBoxColumn.Name = "ProdcodbarraDataGridViewTextBoxColumn"
        Me.ProdcodbarraDataGridViewTextBoxColumn.Visible = False
        '
        'CantvencimientoDataGridViewTextBoxColumn
        '
        Me.CantvencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantvencimientoDataGridViewTextBoxColumn.DataPropertyName = "cant_vencimiento"
        Me.CantvencimientoDataGridViewTextBoxColumn.FillWeight = 48.85786!
        Me.CantvencimientoDataGridViewTextBoxColumn.HeaderText = "Vencido"
        Me.CantvencimientoDataGridViewTextBoxColumn.Name = "CantvencimientoDataGridViewTextBoxColumn"
        Me.CantvencimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.FillWeight = 5.497368!
        Me.Column1.HeaderText = "item"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'ProdconsultaBindingSource
        '
        Me.ProdconsultaBindingSource.DataMember = "Prod_consulta"
        Me.ProdconsultaBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'Venta_Caja_ds
        '
        Me.Venta_Caja_ds.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cb_sucursal
        '
        Me.cb_sucursal.BackColor = System.Drawing.SystemColors.Info
        Me.cb_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sucursal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sucursal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cb_sucursal.FormattingEnabled = True
        Me.cb_sucursal.Location = New System.Drawing.Point(153, 11)
        Me.cb_sucursal.Name = "cb_sucursal"
        Me.cb_sucursal.Size = New System.Drawing.Size(270, 21)
        Me.cb_sucursal.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Seleccione sucursal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Seleccione un producto para ver su detalle."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(8, 195)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Listado Productos :"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(7, 84)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(944, 108)
        Me.TabControl2.TabIndex = 23
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightGray
        Me.TabPage3.Controls.Add(Me.cb_marca)
        Me.TabPage3.Controls.Add(Me.check_marca)
        Me.TabPage3.Controls.Add(Me.Categoria)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.check_subrubro)
        Me.TabPage3.Controls.Add(Me.check_categoria)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.check_rubro)
        Me.TabPage3.Controls.Add(Me.cb_subrubro)
        Me.TabPage3.Controls.Add(Me.cb_categoria)
        Me.TabPage3.Controls.Add(Me.cb_rubro)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(936, 82)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Filtro"
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
        'tx_Buscar
        '
        Me.tx_Buscar.BackColor = System.Drawing.Color.White
        Me.tx_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Buscar.Location = New System.Drawing.Point(7, 51)
        Me.tx_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Buscar.Name = "tx_Buscar"
        Me.tx_Buscar.Size = New System.Drawing.Size(944, 22)
        Me.tx_Buscar.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.txt_totalunidades)
        Me.TabPage2.Controls.Add(Me.txt_descripcion)
        Me.TabPage2.Controls.Add(Me.txt_codigo)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label_totalunidades)
        Me.TabPage2.Controls.Add(Me.Label_codigo)
        Me.TabPage2.Controls.Add(Me.Label_descripcion)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(990, 577)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lotes del producto seleccionado"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button4.Location = New System.Drawing.Point(11, 507)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 43)
        Me.Button4.TabIndex = 258
        Me.Button4.Text = "Volver"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txt_totalunidades
        '
        Me.txt_totalunidades.Location = New System.Drawing.Point(140, 78)
        Me.txt_totalunidades.Name = "txt_totalunidades"
        Me.txt_totalunidades.ReadOnly = True
        Me.txt_totalunidades.Size = New System.Drawing.Size(131, 20)
        Me.txt_totalunidades.TabIndex = 39
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(100, 50)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ReadOnly = True
        Me.txt_descripcion.Size = New System.Drawing.Size(171, 20)
        Me.txt_descripcion.TabIndex = 38
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(70, 16)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(201, 20)
        Me.txt_codigo.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(496, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 100)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Referencias para controlar lotes con vencimiento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(386, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Vencido"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(196, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Próximo a vencer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Estable"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Red
        Me.PictureBox3.Location = New System.Drawing.Point(352, 43)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Orange
        Me.PictureBox2.Location = New System.Drawing.Point(162, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(15, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label_totalunidades
        '
        Me.Label_totalunidades.AutoSize = True
        Me.Label_totalunidades.Location = New System.Drawing.Point(8, 83)
        Me.Label_totalunidades.Name = "Label_totalunidades"
        Me.Label_totalunidades.Size = New System.Drawing.Size(95, 13)
        Me.Label_totalunidades.TabIndex = 30
        Me.Label_totalunidades.Text = "Total de unidades:"
        '
        'Label_codigo
        '
        Me.Label_codigo.AutoSize = True
        Me.Label_codigo.Location = New System.Drawing.Point(8, 21)
        Me.Label_codigo.Name = "Label_codigo"
        Me.Label_codigo.Size = New System.Drawing.Size(43, 13)
        Me.Label_codigo.TabIndex = 29
        Me.Label_codigo.Text = "Código:"
        '
        'Label_descripcion
        '
        Me.Label_descripcion.AutoSize = True
        Me.Label_descripcion.Location = New System.Drawing.Point(8, 55)
        Me.Label_descripcion.Name = "Label_descripcion"
        Me.Label_descripcion.Size = New System.Drawing.Size(66, 13)
        Me.Label_descripcion.TabIndex = 28
        Me.Label_descripcion.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Información de los lotes:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdidDataGridViewTextBoxColumn1, Me.ProdcodinternoDataGridViewTextBoxColumn1, Me.ProddescripcionDataGridViewTextBoxColumn1, Me.ProdxSucstockDataGridViewTextBoxColumn, Me.LoteidDataGridViewTextBoxColumn, Me.LotenroDataGridViewTextBoxColumn, Me.Proveedor, Me.LotecantidadDataGridViewTextBoxColumn, Me.LotefechafabDataGridViewTextBoxColumn, Me.LotefechavtoDataGridViewTextBoxColumn, Me.LotevenceDataGridViewTextBoxColumn, Me.SucursalidDataGridViewTextBoxColumn, Me.DataGridViewCheckBoxColumn1, Me.Prov_id})
        Me.DataGridView2.DataSource = Me.LotebajaBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(11, 147)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(941, 352)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 26
        '
        'ProdidDataGridViewTextBoxColumn1
        '
        Me.ProdidDataGridViewTextBoxColumn1.DataPropertyName = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn1.HeaderText = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn1.Name = "ProdidDataGridViewTextBoxColumn1"
        Me.ProdidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProdidDataGridViewTextBoxColumn1.Visible = False
        '
        'ProdcodinternoDataGridViewTextBoxColumn1
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn1.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn1.HeaderText = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn1.Name = "ProdcodinternoDataGridViewTextBoxColumn1"
        Me.ProdcodinternoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProdcodinternoDataGridViewTextBoxColumn1.Visible = False
        '
        'ProddescripcionDataGridViewTextBoxColumn1
        '
        Me.ProddescripcionDataGridViewTextBoxColumn1.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn1.HeaderText = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn1.Name = "ProddescripcionDataGridViewTextBoxColumn1"
        Me.ProddescripcionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn1.Visible = False
        '
        'ProdxSucstockDataGridViewTextBoxColumn
        '
        Me.ProdxSucstockDataGridViewTextBoxColumn.DataPropertyName = "ProdxSuc_stock"
        Me.ProdxSucstockDataGridViewTextBoxColumn.HeaderText = "ProdxSuc_stock"
        Me.ProdxSucstockDataGridViewTextBoxColumn.Name = "ProdxSucstockDataGridViewTextBoxColumn"
        Me.ProdxSucstockDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdxSucstockDataGridViewTextBoxColumn.Visible = False
        '
        'LoteidDataGridViewTextBoxColumn
        '
        Me.LoteidDataGridViewTextBoxColumn.DataPropertyName = "lote_id"
        Me.LoteidDataGridViewTextBoxColumn.HeaderText = "lote_id"
        Me.LoteidDataGridViewTextBoxColumn.Name = "LoteidDataGridViewTextBoxColumn"
        Me.LoteidDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoteidDataGridViewTextBoxColumn.Visible = False
        '
        'LotenroDataGridViewTextBoxColumn
        '
        Me.LotenroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LotenroDataGridViewTextBoxColumn.DataPropertyName = "lote_nro"
        Me.LotenroDataGridViewTextBoxColumn.HeaderText = "Nº/Lote"
        Me.LotenroDataGridViewTextBoxColumn.Name = "LotenroDataGridViewTextBoxColumn"
        Me.LotenroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Proveedor
        '
        Me.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        '
        'LotecantidadDataGridViewTextBoxColumn
        '
        Me.LotecantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LotecantidadDataGridViewTextBoxColumn.DataPropertyName = "lote_cantidad"
        Me.LotecantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.LotecantidadDataGridViewTextBoxColumn.Name = "LotecantidadDataGridViewTextBoxColumn"
        Me.LotecantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotefechafabDataGridViewTextBoxColumn
        '
        Me.LotefechafabDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LotefechafabDataGridViewTextBoxColumn.DataPropertyName = "lote_fechafab"
        Me.LotefechafabDataGridViewTextBoxColumn.HeaderText = "Fecha Fab."
        Me.LotefechafabDataGridViewTextBoxColumn.Name = "LotefechafabDataGridViewTextBoxColumn"
        Me.LotefechafabDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotefechafabDataGridViewTextBoxColumn.Width = 120
        '
        'LotefechavtoDataGridViewTextBoxColumn
        '
        Me.LotefechavtoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LotefechavtoDataGridViewTextBoxColumn.DataPropertyName = "lote_fechavto"
        Me.LotefechavtoDataGridViewTextBoxColumn.HeaderText = "Fecha Vto."
        Me.LotefechavtoDataGridViewTextBoxColumn.Name = "LotefechavtoDataGridViewTextBoxColumn"
        Me.LotefechavtoDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotefechavtoDataGridViewTextBoxColumn.Width = 120
        '
        'LotevenceDataGridViewTextBoxColumn
        '
        Me.LotevenceDataGridViewTextBoxColumn.DataPropertyName = "lote_vence"
        Me.LotevenceDataGridViewTextBoxColumn.HeaderText = "lote_vence"
        Me.LotevenceDataGridViewTextBoxColumn.Name = "LotevenceDataGridViewTextBoxColumn"
        Me.LotevenceDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotevenceDataGridViewTextBoxColumn.Visible = False
        '
        'SucursalidDataGridViewTextBoxColumn
        '
        Me.SucursalidDataGridViewTextBoxColumn.DataPropertyName = "sucursal_id"
        Me.SucursalidDataGridViewTextBoxColumn.HeaderText = "sucursal_id"
        Me.SucursalidDataGridViewTextBoxColumn.Name = "SucursalidDataGridViewTextBoxColumn"
        Me.SucursalidDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucursalidDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn1.FillWeight = 5.497368!
        Me.DataGridViewCheckBoxColumn1.HeaderText = "item"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'Prov_id
        '
        Me.Prov_id.DataPropertyName = "Prov_id"
        Me.Prov_id.HeaderText = "Prov_id"
        Me.Prov_id.Name = "Prov_id"
        Me.Prov_id.ReadOnly = True
        Me.Prov_id.Visible = False
        '
        'LotebajaBindingSource
        '
        Me.LotebajaBindingSource.DataMember = "lote_baja"
        Me.LotebajaBindingSource.DataSource = Me.Mov_DS
        '
        'Mov_DS
        '
        Me.Mov_DS.DataSetName = "Mov_DS"
        Me.Mov_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GM_Consultar_Stock
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(1017, 619)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "GM_Consultar_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock disponible"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdconsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotebajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
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
    Friend WithEvents tx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_totalunidades As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_totalunidades As System.Windows.Forms.Label
    Friend WithEvents Label_codigo As System.Windows.Forms.Label
    Friend WithEvents Label_descripcion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents cb_sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Venta_Caja_ds As Aplicacion.Venta_Caja_ds
    Friend WithEvents LotebajaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescrilargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdpreciovtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdstockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdptorepoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdpreciovtaMayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodbarraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantvencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProdconsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BO_ver As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProdidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdxSucstockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotenroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotecantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotefechafabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotefechavtoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotevenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Prov_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
