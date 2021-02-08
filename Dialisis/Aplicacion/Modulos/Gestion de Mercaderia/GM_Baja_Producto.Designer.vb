<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GM_Baja_Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GM_Baja_Producto))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Btn_Predef = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txt_totalunidades = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_agregar1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_lote = New System.Windows.Forms.TextBox()
        Me.txt_fechafab = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_fechvto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_cantlote = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotecantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotefechafabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotefechavtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotevenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotebajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS1 = New Aplicacion.Mov_DS()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_totalunidades_mov = New System.Windows.Forms.TextBox()
        Me.txt_descripcion_mov = New System.Windows.Forms.TextBox()
        Me.txt_codigo_mov = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel_cant_mover = New System.Windows.Forms.Panel()
        Me.txt_cant_mov = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotebajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel_cant_mover.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(998, 628)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Btn_Predef)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.btn_siguiente)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Controls.Add(Me.tx_Buscar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(990, 602)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Productos en stock"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Btn_Predef
        '
        Me.Btn_Predef.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Predef.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Btn_Predef.Location = New System.Drawing.Point(815, 477)
        Me.Btn_Predef.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Predef.Name = "Btn_Predef"
        Me.Btn_Predef.Size = New System.Drawing.Size(136, 43)
        Me.Btn_Predef.TabIndex = 250
        Me.Btn_Predef.Text = "Seleccionar"
        Me.Btn_Predef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Predef.UseVisualStyleBackColor = True
        Me.Btn_Predef.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.PictureBox7)
        Me.GroupBox5.Controls.Add(Me.PictureBox8)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 472)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(307, 62)
        Me.GroupBox5.TabIndex = 249
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Referencias para control de productos:"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Stock bajo"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Red
        Me.PictureBox7.Location = New System.Drawing.Point(200, 21)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Blue
        Me.PictureBox8.Location = New System.Drawing.Point(10, 21)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_siguiente.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.btn_siguiente.Location = New System.Drawing.Point(815, 477)
        Me.btn_siguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(136, 43)
        Me.btn_siguiente.TabIndex = 248
        Me.btn_siguiente.Text = "Siguiente"
        Me.btn_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Seleccione un producto para ver su detalle."
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
        Me.DataGridView1.Location = New System.Drawing.Point(8, 217)
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
        Me.DataGridView1.Size = New System.Drawing.Size(943, 252)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 25
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
        Me.ProdcodinternoDataGridViewTextBoxColumn.FillWeight = 449.2386!
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Cód."
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.FillWeight = 12.69035!
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn.Width = 350
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
        Me.ProdpreciovtaDataGridViewTextBoxColumn.DataPropertyName = "prod_precio_vta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.HeaderText = "prod_precio_vta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Name = "ProdpreciovtaDataGridViewTextBoxColumn"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Visible = False
        '
        'ProdstockDataGridViewTextBoxColumn
        '
        Me.ProdstockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProdstockDataGridViewTextBoxColumn.DataPropertyName = "prod_stock"
        Me.ProdstockDataGridViewTextBoxColumn.FillWeight = 12.69035!
        Me.ProdstockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.ProdstockDataGridViewTextBoxColumn.Name = "ProdstockDataGridViewTextBoxColumn"
        Me.ProdstockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdptorepoDataGridViewTextBoxColumn
        '
        Me.ProdptorepoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProdptorepoDataGridViewTextBoxColumn.DataPropertyName = "prod_ptorepo"
        Me.ProdptorepoDataGridViewTextBoxColumn.FillWeight = 12.69035!
        Me.ProdptorepoDataGridViewTextBoxColumn.HeaderText = "Pto.Reposición"
        Me.ProdptorepoDataGridViewTextBoxColumn.Name = "ProdptorepoDataGridViewTextBoxColumn"
        Me.ProdptorepoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdptorepoDataGridViewTextBoxColumn.Width = 120
        '
        'ProdpreciovtaMayDataGridViewTextBoxColumn
        '
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn.DataPropertyName = "prod_precio_vta_May"
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn.HeaderText = "prod_precio_vta_May"
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn.Name = "ProdpreciovtaMayDataGridViewTextBoxColumn"
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdpreciovtaMayDataGridViewTextBoxColumn.Visible = False
        '
        'ProdcodbarraDataGridViewTextBoxColumn
        '
        Me.ProdcodbarraDataGridViewTextBoxColumn.DataPropertyName = "prod_codbarra"
        Me.ProdcodbarraDataGridViewTextBoxColumn.HeaderText = "prod_codbarra"
        Me.ProdcodbarraDataGridViewTextBoxColumn.Name = "ProdcodbarraDataGridViewTextBoxColumn"
        Me.ProdcodbarraDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdcodbarraDataGridViewTextBoxColumn.Visible = False
        '
        'CantvencimientoDataGridViewTextBoxColumn
        '
        Me.CantvencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantvencimientoDataGridViewTextBoxColumn.DataPropertyName = "cant_vencimiento"
        Me.CantvencimientoDataGridViewTextBoxColumn.FillWeight = 12.69035!
        Me.CantvencimientoDataGridViewTextBoxColumn.HeaderText = "Vencidos"
        Me.CantvencimientoDataGridViewTextBoxColumn.Name = "CantvencimientoDataGridViewTextBoxColumn"
        Me.CantvencimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.FillWeight = 5.497368!
        Me.Column1.HeaderText = "item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(8, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Listado Productos :"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(7, 40)
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
        Me.tx_Buscar.Location = New System.Drawing.Point(7, 7)
        Me.tx_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Buscar.Name = "tx_Buscar"
        Me.tx_Buscar.Size = New System.Drawing.Size(944, 22)
        Me.tx_Buscar.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.txt_totalunidades)
        Me.TabPage2.Controls.Add(Me.txt_descripcion)
        Me.TabPage2.Controls.Add(Me.txt_codigo)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label_totalunidades)
        Me.TabPage2.Controls.Add(Me.Label_codigo)
        Me.TabPage2.Controls.Add(Me.Label_descripcion)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(990, 602)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lotes del producto seleccionado"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button5.Location = New System.Drawing.Point(16, 552)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 43)
        Me.Button5.TabIndex = 261
        Me.Button5.Text = "Volver"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(720, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 127)
        Me.GroupBox1.TabIndex = 260
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Referencias para controlar lotes con vencimiento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(143, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Vencido"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(143, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Próximo a vencer"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(143, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Estable"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(109, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Orange
        Me.PictureBox2.Location = New System.Drawing.Point(109, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(109, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button4.Location = New System.Drawing.Point(10, 7)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 43)
        Me.Button4.TabIndex = 259
        Me.Button4.Text = "Volver"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txt_totalunidades
        '
        Me.txt_totalunidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalunidades.Location = New System.Drawing.Point(407, 91)
        Me.txt_totalunidades.Name = "txt_totalunidades"
        Me.txt_totalunidades.ReadOnly = True
        Me.txt_totalunidades.Size = New System.Drawing.Size(92, 22)
        Me.txt_totalunidades.TabIndex = 39
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.Location = New System.Drawing.Point(120, 94)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ReadOnly = True
        Me.txt_descripcion.Size = New System.Drawing.Size(220, 22)
        Me.txt_descripcion.TabIndex = 38
        '
        'txt_codigo
        '
        Me.txt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(120, 63)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(121, 22)
        Me.txt_codigo.TabIndex = 37
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_agregar1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_lote)
        Me.GroupBox2.Controls.Add(Me.txt_fechafab)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txt_fechvto)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_cantlote)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 419)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(967, 109)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lote seleccionado para eliminar:"
        '
        'btn_agregar1
        '
        Me.btn_agregar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar1.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_agregar1.Location = New System.Drawing.Point(566, 20)
        Me.btn_agregar1.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregar1.Name = "btn_agregar1"
        Me.btn_agregar1.Size = New System.Drawing.Size(124, 67)
        Me.btn_agregar1.TabIndex = 249
        Me.btn_agregar1.Text = "Agregar"
        Me.btn_agregar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_agregar1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Lote N°:"
        '
        'txt_lote
        '
        Me.txt_lote.Location = New System.Drawing.Point(98, 23)
        Me.txt_lote.Name = "txt_lote"
        Me.txt_lote.ReadOnly = True
        Me.txt_lote.Size = New System.Drawing.Size(171, 22)
        Me.txt_lote.TabIndex = 35
        '
        'txt_fechafab
        '
        Me.txt_fechafab.Location = New System.Drawing.Point(98, 65)
        Me.txt_fechafab.Name = "txt_fechafab"
        Me.txt_fechafab.ReadOnly = True
        Me.txt_fechafab.Size = New System.Drawing.Size(171, 22)
        Me.txt_fechafab.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 16)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Fecha Fab:"
        '
        'txt_fechvto
        '
        Me.txt_fechvto.Location = New System.Drawing.Point(391, 65)
        Me.txt_fechvto.Name = "txt_fechvto"
        Me.txt_fechvto.ReadOnly = True
        Me.txt_fechvto.Size = New System.Drawing.Size(143, 22)
        Me.txt_fechvto.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(301, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 16)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Cantidad:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(301, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 16)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Fecha Vto:"
        '
        'txt_cantlote
        '
        Me.txt_cantlote.BackColor = System.Drawing.SystemColors.Info
        Me.txt_cantlote.ForeColor = System.Drawing.Color.Red
        Me.txt_cantlote.Location = New System.Drawing.Point(391, 20)
        Me.txt_cantlote.Name = "txt_cantlote"
        Me.txt_cantlote.Size = New System.Drawing.Size(143, 22)
        Me.txt_cantlote.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(576, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 57)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Configurar plazo vencimiento"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label_totalunidades
        '
        Me.Label_totalunidades.AutoSize = True
        Me.Label_totalunidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_totalunidades.Location = New System.Drawing.Point(388, 67)
        Me.Label_totalunidades.Name = "Label_totalunidades"
        Me.Label_totalunidades.Size = New System.Drawing.Size(138, 16)
        Me.Label_totalunidades.TabIndex = 30
        Me.Label_totalunidades.Text = "Total de unidades:"
        '
        'Label_codigo
        '
        Me.Label_codigo.AutoSize = True
        Me.Label_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_codigo.Location = New System.Drawing.Point(19, 67)
        Me.Label_codigo.Name = "Label_codigo"
        Me.Label_codigo.Size = New System.Drawing.Size(62, 16)
        Me.Label_codigo.TabIndex = 29
        Me.Label_codigo.Text = "Código:"
        '
        'Label_descripcion
        '
        Me.Label_descripcion.AutoSize = True
        Me.Label_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_descripcion.Location = New System.Drawing.Point(19, 101)
        Me.Label_descripcion.Name = "Label_descripcion"
        Me.Label_descripcion.Size = New System.Drawing.Size(95, 16)
        Me.Label_descripcion.TabIndex = 28
        Me.Label_descripcion.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 16)
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdidDataGridViewTextBoxColumn1, Me.ProdcodinternoDataGridViewTextBoxColumn1, Me.ProddescripcionDataGridViewTextBoxColumn1, Me.ProdxSucstockDataGridViewTextBoxColumn, Me.LoteidDataGridViewTextBoxColumn, Me.LotenroDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn12, Me.LotecantidadDataGridViewTextBoxColumn, Me.LotefechafabDataGridViewTextBoxColumn, Me.LotefechavtoDataGridViewTextBoxColumn, Me.LotevenceDataGridViewTextBoxColumn, Me.SucursalidDataGridViewTextBoxColumn, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn13})
        Me.DataGridView2.DataSource = Me.LotebajaBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(16, 160)
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
        Me.DataGridView2.Size = New System.Drawing.Size(967, 252)
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
        Me.LotenroDataGridViewTextBoxColumn.DataPropertyName = "lote_nro"
        Me.LotenroDataGridViewTextBoxColumn.HeaderText = "Nº/Lote"
        Me.LotenroDataGridViewTextBoxColumn.Name = "LotenroDataGridViewTextBoxColumn"
        Me.LotenroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Proveedor"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'LotecantidadDataGridViewTextBoxColumn
        '
        Me.LotecantidadDataGridViewTextBoxColumn.DataPropertyName = "lote_cantidad"
        Me.LotecantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.LotecantidadDataGridViewTextBoxColumn.Name = "LotecantidadDataGridViewTextBoxColumn"
        Me.LotecantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotefechafabDataGridViewTextBoxColumn
        '
        Me.LotefechafabDataGridViewTextBoxColumn.DataPropertyName = "lote_fechafab"
        Me.LotefechafabDataGridViewTextBoxColumn.HeaderText = "Fecha Fab."
        Me.LotefechafabDataGridViewTextBoxColumn.Name = "LotefechafabDataGridViewTextBoxColumn"
        Me.LotefechafabDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotefechavtoDataGridViewTextBoxColumn
        '
        Me.LotefechavtoDataGridViewTextBoxColumn.DataPropertyName = "lote_fechavto"
        Me.LotefechavtoDataGridViewTextBoxColumn.HeaderText = "Fecha Vto."
        Me.LotefechavtoDataGridViewTextBoxColumn.Name = "LotefechavtoDataGridViewTextBoxColumn"
        Me.LotefechavtoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotevenceDataGridViewTextBoxColumn
        '
        Me.LotevenceDataGridViewTextBoxColumn.DataPropertyName = "lote_vence"
        Me.LotevenceDataGridViewTextBoxColumn.HeaderText = "Vence"
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
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Prov_id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Prov_id"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'LotebajaBindingSource
        '
        Me.LotebajaBindingSource.DataMember = "lote_baja"
        Me.LotebajaBindingSource.DataSource = Me.Mov_DS1
        '
        'Mov_DS1
        '
        Me.Mov_DS1.DataSetName = "Mov_DS"
        Me.Mov_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.btn_quitar)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.txt_totalunidades_mov)
        Me.TabPage4.Controls.Add(Me.txt_descripcion_mov)
        Me.TabPage4.Controls.Add(Me.txt_codigo_mov)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.DataGridView3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(990, 602)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "Lotes del producto seleccionado"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button7.Location = New System.Drawing.Point(29, 555)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 43)
        Me.Button7.TabIndex = 261
        Me.Button7.Text = "Volver"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar.Image = CType(resources.GetObject("btn_quitar.Image"), System.Drawing.Image)
        Me.btn_quitar.Location = New System.Drawing.Point(766, 355)
        Me.btn_quitar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(168, 34)
        Me.btn_quitar.TabIndex = 52
        Me.btn_quitar.Text = "Quirar selección"
        Me.btn_quitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button2.Location = New System.Drawing.Point(11, 6)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 43)
        Me.Button2.TabIndex = 260
        Me.Button2.Text = "Volver"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_totalunidades_mov
        '
        Me.txt_totalunidades_mov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalunidades_mov.Location = New System.Drawing.Point(452, 97)
        Me.txt_totalunidades_mov.Name = "txt_totalunidades_mov"
        Me.txt_totalunidades_mov.ReadOnly = True
        Me.txt_totalunidades_mov.Size = New System.Drawing.Size(78, 22)
        Me.txt_totalunidades_mov.TabIndex = 51
        '
        'txt_descripcion_mov
        '
        Me.txt_descripcion_mov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion_mov.Location = New System.Drawing.Point(140, 93)
        Me.txt_descripcion_mov.Name = "txt_descripcion_mov"
        Me.txt_descripcion_mov.ReadOnly = True
        Me.txt_descripcion_mov.Size = New System.Drawing.Size(248, 22)
        Me.txt_descripcion_mov.TabIndex = 50
        '
        'txt_codigo_mov
        '
        Me.txt_codigo_mov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_mov.Location = New System.Drawing.Point(140, 65)
        Me.txt_codigo_mov.Name = "txt_codigo_mov"
        Me.txt_codigo_mov.ReadOnly = True
        Me.txt_codigo_mov.Size = New System.Drawing.Size(84, 22)
        Me.txt_codigo_mov.TabIndex = 49
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Panel_cant_mover)
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(28, 392)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(906, 156)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese la cantidad a mover:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.Button3.Location = New System.Drawing.Point(243, 25)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 56)
        Me.Button3.TabIndex = 250
        Me.Button3.Text = "Agregar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel_cant_mover
        '
        Me.Panel_cant_mover.BackColor = System.Drawing.Color.Red
        Me.Panel_cant_mover.Controls.Add(Me.txt_cant_mov)
        Me.Panel_cant_mover.Location = New System.Drawing.Point(86, 25)
        Me.Panel_cant_mover.Name = "Panel_cant_mover"
        Me.Panel_cant_mover.Size = New System.Drawing.Size(150, 60)
        Me.Panel_cant_mover.TabIndex = 52
        '
        'txt_cant_mov
        '
        Me.txt_cant_mov.BackColor = System.Drawing.SystemColors.Info
        Me.txt_cant_mov.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cant_mov.Location = New System.Drawing.Point(4, 12)
        Me.txt_cant_mov.Name = "txt_cant_mov"
        Me.txt_cant_mov.Size = New System.Drawing.Size(143, 30)
        Me.txt_cant_mov.TabIndex = 39
        Me.txt_cant_mov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Blue
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 94)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(882, 37)
        Me.RichTextBox1.TabIndex = 40
        Me.RichTextBox1.Text = "Nota: los lotes se asignarán por defecto. Puede seleccionarlos a gusto con una tí" & _
            "lde."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Cantidad:"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(804, 426)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(130, 57)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "Configurar plazo vencimiento"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Controls.Add(Me.PictureBox5)
        Me.GroupBox4.Controls.Add(Me.PictureBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(671, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(263, 127)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Referencias para controlar lotes con vencimiento:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(143, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Vencido"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(143, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Próximo a vencer"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(143, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Estable"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Red
        Me.PictureBox4.Location = New System.Drawing.Point(109, 87)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Orange
        Me.PictureBox5.Location = New System.Drawing.Point(109, 53)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox6.Location = New System.Drawing.Point(109, 19)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(419, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(138, 16)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Total de unidades:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(26, 71)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 16)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Código:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(26, 99)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(95, 16)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Descripción:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(26, 131)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(177, 16)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Información de los lotes:"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Proveedor, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn2, Me.tope, Me.Prov_id})
        Me.DataGridView3.DataSource = Me.LotebajaBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(28, 151)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(906, 196)
        Me.DataGridView3.StandardTab = True
        Me.DataGridView3.TabIndex = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "prod_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "prod_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "prod_codinterno"
        Me.DataGridViewTextBoxColumn2.HeaderText = "prod_codinterno"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "prod_descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "prod_descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProdxSuc_stock"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProdxSuc_stock"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "lote_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "lote_id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "lote_nro"
        Me.DataGridViewTextBoxColumn6.FillWeight = 65.35609!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nº/Lote"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Proveedor
        '
        Me.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "lote_cantidad"
        Me.DataGridViewTextBoxColumn7.FillWeight = 205.8362!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "lote_fechafab"
        Me.DataGridViewTextBoxColumn8.FillWeight = 65.35609!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Fab."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "lote_fechavto"
        Me.DataGridViewTextBoxColumn9.FillWeight = 65.35609!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha Vto."
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 120
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "lote_vence"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Vence"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "sucursal_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "sucursal_id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn2.FillWeight = 3.592865!
        Me.DataGridViewCheckBoxColumn2.HeaderText = "item"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 50
        '
        'tope
        '
        Me.tope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tope.HeaderText = "Column2"
        Me.tope.Name = "tope"
        Me.tope.Visible = False
        '
        'Prov_id
        '
        Me.Prov_id.DataPropertyName = "Prov_id"
        Me.Prov_id.HeaderText = "Prov_id"
        Me.Prov_id.Name = "Prov_id"
        Me.Prov_id.Visible = False
        '
        'Mov_DS
        '
        Me.Mov_DS.DataSetName = "Mov_DS"
        Me.Mov_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GM_Baja_Producto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1008, 660)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "GM_Baja_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar baja de productos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotebajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel_cant_mover.ResumeLayout(False)
        Me.Panel_cant_mover.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tx_Buscar As System.Windows.Forms.TextBox
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Venta_Caja_ds As Aplicacion.Venta_Caja_ds
    Friend WithEvents Label_totalunidades As System.Windows.Forms.Label
    Friend WithEvents Label_codigo As System.Windows.Forms.Label
    Friend WithEvents Label_descripcion As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_fechafab As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_fechvto As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_cantlote As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_lote As System.Windows.Forms.TextBox
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents txt_totalunidades As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Mov_DS1 As Aplicacion.Mov_DS
    Friend WithEvents LotebajaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txt_totalunidades_mov As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion_mov As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo_mov As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cant_mov As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel_cant_mover As System.Windows.Forms.Panel
    Friend WithEvents btn_agregar1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents ProdconsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ProdidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdxSucstockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotenroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotecantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotefechafabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotefechavtoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotevenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tope As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prov_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_Predef As System.Windows.Forms.Button
End Class
