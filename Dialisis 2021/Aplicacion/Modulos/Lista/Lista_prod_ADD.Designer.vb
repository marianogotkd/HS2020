<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_prod_ADD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_prod_ADD))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TX_busqueda = New System.Windows.Forms.TextBox()
        Me.Cbox_busqueda = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbox_proveedor = New System.Windows.Forms.ComboBox()
        Me.RB_filtro_NO = New System.Windows.Forms.RadioButton()
        Me.RB_filtro_SI = New System.Windows.Forms.RadioButton()
        Me.LB_ERROR = New System.Windows.Forms.Label()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.GP_Producto = New System.Windows.Forms.GroupBox()
        Me.DG_Producto = New System.Windows.Forms.DataGridView()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescrilargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdpreciovtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdnrocatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdidcatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcanomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_ds = New Aplicacion.Lista_ds()
        Me.BO_busqueda = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label_preciototal = New System.Windows.Forms.Label()
        Me.Label_codinterno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_preciolista = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TX_LISTA_PROD_cant = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BO_Cargar = New System.Windows.Forms.Button()
        Me.ListaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Producto.SuspendLayout()
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ListaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(897, 555)
        Me.TabControl2.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(889, 529)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Producto: Agregar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.TX_busqueda)
        Me.GroupBox9.Controls.Add(Me.Cbox_busqueda)
        Me.GroupBox9.Controls.Add(Me.Panel2)
        Me.GroupBox9.Controls.Add(Me.LB_ERROR)
        Me.GroupBox9.Controls.Add(Me.IM_ERROR)
        Me.GroupBox9.Controls.Add(Me.GP_Producto)
        Me.GroupBox9.Controls.Add(Me.BO_busqueda)
        Me.GroupBox9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox9.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(877, 460)
        Me.GroupBox9.TabIndex = 230
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Buscar Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "Nombre producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(438, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 242
        Me.Label2.Text = "Aplicar filtro"
        '
        'TX_busqueda
        '
        Me.TX_busqueda.Location = New System.Drawing.Point(125, 22)
        Me.TX_busqueda.Name = "TX_busqueda"
        Me.TX_busqueda.Size = New System.Drawing.Size(179, 20)
        Me.TX_busqueda.TabIndex = 241
        '
        'Cbox_busqueda
        '
        Me.Cbox_busqueda.Enabled = False
        Me.Cbox_busqueda.FormattingEnabled = True
        Me.Cbox_busqueda.Items.AddRange(New Object() {"Código Interno", "Código Barras", "Nombre"})
        Me.Cbox_busqueda.Location = New System.Drawing.Point(14, 23)
        Me.Cbox_busqueda.Name = "Cbox_busqueda"
        Me.Cbox_busqueda.Size = New System.Drawing.Size(167, 21)
        Me.Cbox_busqueda.TabIndex = 240
        Me.Cbox_busqueda.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Cbox_proveedor)
        Me.Panel2.Controls.Add(Me.RB_filtro_NO)
        Me.Panel2.Controls.Add(Me.RB_filtro_SI)
        Me.Panel2.Location = New System.Drawing.Point(505, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 33)
        Me.Panel2.TabIndex = 234
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 243
        Me.Label1.Text = "Proveedor:"
        '
        'Cbox_proveedor
        '
        Me.Cbox_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_proveedor.Enabled = False
        Me.Cbox_proveedor.FormattingEnabled = True
        Me.Cbox_proveedor.Items.AddRange(New Object() {"Código Interno", "Código Barras", "Nombre"})
        Me.Cbox_proveedor.Location = New System.Drawing.Point(167, 6)
        Me.Cbox_proveedor.Name = "Cbox_proveedor"
        Me.Cbox_proveedor.Size = New System.Drawing.Size(184, 21)
        Me.Cbox_proveedor.TabIndex = 242
        '
        'RB_filtro_NO
        '
        Me.RB_filtro_NO.AutoSize = True
        Me.RB_filtro_NO.Checked = True
        Me.RB_filtro_NO.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_filtro_NO.Location = New System.Drawing.Point(43, 6)
        Me.RB_filtro_NO.Name = "RB_filtro_NO"
        Me.RB_filtro_NO.Size = New System.Drawing.Size(39, 17)
        Me.RB_filtro_NO.TabIndex = 223
        Me.RB_filtro_NO.TabStop = True
        Me.RB_filtro_NO.Text = "No"
        Me.RB_filtro_NO.UseVisualStyleBackColor = True
        '
        'RB_filtro_SI
        '
        Me.RB_filtro_SI.AutoSize = True
        Me.RB_filtro_SI.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_filtro_SI.Location = New System.Drawing.Point(3, 6)
        Me.RB_filtro_SI.Name = "RB_filtro_SI"
        Me.RB_filtro_SI.Size = New System.Drawing.Size(34, 17)
        Me.RB_filtro_SI.TabIndex = 222
        Me.RB_filtro_SI.Text = "Si"
        Me.RB_filtro_SI.UseVisualStyleBackColor = True
        '
        'LB_ERROR
        '
        Me.LB_ERROR.AutoSize = True
        Me.LB_ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR.ForeColor = System.Drawing.Color.Red
        Me.LB_ERROR.Location = New System.Drawing.Point(367, 25)
        Me.LB_ERROR.Name = "LB_ERROR"
        Me.LB_ERROR.Size = New System.Drawing.Size(59, 15)
        Me.LB_ERROR.TabIndex = 234
        Me.LB_ERROR.Text = "No Existe"
        Me.LB_ERROR.Visible = False
        '
        'IM_ERROR
        '
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(346, 23)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 233
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'GP_Producto
        '
        Me.GP_Producto.Controls.Add(Me.DG_Producto)
        Me.GP_Producto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Producto.Location = New System.Drawing.Point(7, 58)
        Me.GP_Producto.Name = "GP_Producto"
        Me.GP_Producto.Size = New System.Drawing.Size(864, 391)
        Me.GP_Producto.TabIndex = 103
        Me.GP_Producto.TabStop = False
        Me.GP_Producto.Text = "Datos del Producto"
        '
        'DG_Producto
        '
        Me.DG_Producto.AllowUserToAddRows = False
        Me.DG_Producto.AllowUserToDeleteRows = False
        Me.DG_Producto.AllowUserToResizeRows = False
        Me.DG_Producto.AutoGenerateColumns = False
        Me.DG_Producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Producto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdidDataGridViewTextBoxColumn, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ProddescrilargaDataGridViewTextBoxColumn, Me.ProdpreciovtaDataGridViewTextBoxColumn, Me.ProdnrocatDataGridViewTextBoxColumn, Me.ProdidcatDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.MarcanomDataGridViewTextBoxColumn, Me.ProvidDataGridViewTextBoxColumn, Me.ProvnombreDataGridViewTextBoxColumn})
        Me.DG_Producto.DataSource = Me.ProductoBindingSource1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Producto.DefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Producto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Producto.Location = New System.Drawing.Point(3, 16)
        Me.DG_Producto.MultiSelect = False
        Me.DG_Producto.Name = "DG_Producto"
        Me.DG_Producto.ReadOnly = True
        Me.DG_Producto.RowHeadersVisible = False
        Me.DG_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Producto.Size = New System.Drawing.Size(858, 372)
        Me.DG_Producto.TabIndex = 1
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
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.FillWeight = 152.2843!
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Cód. Interno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdcodinternoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.FillWeight = 89.54314!
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ProddescrilargaDataGridViewTextBoxColumn
        '
        Me.ProddescrilargaDataGridViewTextBoxColumn.DataPropertyName = "prod_descrilarga"
        Me.ProddescrilargaDataGridViewTextBoxColumn.FillWeight = 89.54314!
        Me.ProddescrilargaDataGridViewTextBoxColumn.HeaderText = "Detalle"
        Me.ProddescrilargaDataGridViewTextBoxColumn.Name = "ProddescrilargaDataGridViewTextBoxColumn"
        Me.ProddescrilargaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescrilargaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ProdpreciovtaDataGridViewTextBoxColumn
        '
        Me.ProdpreciovtaDataGridViewTextBoxColumn.DataPropertyName = "prod_precio_vta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.FillWeight = 89.54314!
        Me.ProdpreciovtaDataGridViewTextBoxColumn.HeaderText = "Precio Vta."
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Name = "ProdpreciovtaDataGridViewTextBoxColumn"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdpreciovtaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ProdnrocatDataGridViewTextBoxColumn
        '
        Me.ProdnrocatDataGridViewTextBoxColumn.DataPropertyName = "prod_nrocat"
        Me.ProdnrocatDataGridViewTextBoxColumn.HeaderText = "prod_nrocat"
        Me.ProdnrocatDataGridViewTextBoxColumn.Name = "ProdnrocatDataGridViewTextBoxColumn"
        Me.ProdnrocatDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdnrocatDataGridViewTextBoxColumn.Visible = False
        '
        'ProdidcatDataGridViewTextBoxColumn
        '
        Me.ProdidcatDataGridViewTextBoxColumn.DataPropertyName = "prod_idcat"
        Me.ProdidcatDataGridViewTextBoxColumn.HeaderText = "prod_idcat"
        Me.ProdidcatDataGridViewTextBoxColumn.Name = "ProdidcatDataGridViewTextBoxColumn"
        Me.ProdidcatDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdidcatDataGridViewTextBoxColumn.Visible = False
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.FillWeight = 89.54314!
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CategoriaDataGridViewTextBoxColumn.Visible = False
        '
        'MarcanomDataGridViewTextBoxColumn
        '
        Me.MarcanomDataGridViewTextBoxColumn.DataPropertyName = "Marca_nom"
        Me.MarcanomDataGridViewTextBoxColumn.FillWeight = 89.54314!
        Me.MarcanomDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcanomDataGridViewTextBoxColumn.Name = "MarcanomDataGridViewTextBoxColumn"
        Me.MarcanomDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcanomDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ProvidDataGridViewTextBoxColumn
        '
        Me.ProvidDataGridViewTextBoxColumn.DataPropertyName = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.HeaderText = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.Name = "ProvidDataGridViewTextBoxColumn"
        Me.ProvidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ProvidDataGridViewTextBoxColumn.Visible = False
        '
        'ProvnombreDataGridViewTextBoxColumn
        '
        Me.ProvnombreDataGridViewTextBoxColumn.DataPropertyName = "Prov_nombre"
        Me.ProvnombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProvnombreDataGridViewTextBoxColumn.Name = "ProvnombreDataGridViewTextBoxColumn"
        Me.ProvnombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvnombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "Producto"
        Me.ProductoBindingSource1.DataSource = Me.Lista_ds
        '
        'Lista_ds
        '
        Me.Lista_ds.DataSetName = "Lista_ds"
        Me.Lista_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_busqueda
        '
        Me.BO_busqueda.Image = CType(resources.GetObject("BO_busqueda.Image"), System.Drawing.Image)
        Me.BO_busqueda.Location = New System.Drawing.Point(310, 17)
        Me.BO_busqueda.Name = "BO_busqueda"
        Me.BO_busqueda.Size = New System.Drawing.Size(30, 30)
        Me.BO_busqueda.TabIndex = 96
        Me.BO_busqueda.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label_preciototal)
        Me.GroupBox5.Controls.Add(Me.Label_codinterno)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label_preciolista)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.TX_LISTA_PROD_cant)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox5.Location = New System.Drawing.Point(6, 476)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(590, 47)
        Me.GroupBox5.TabIndex = 233
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Producto seleccionado"
        '
        'Label_preciototal
        '
        Me.Label_preciototal.AutoSize = True
        Me.Label_preciototal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_preciototal.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_preciototal.Location = New System.Drawing.Point(511, 20)
        Me.Label_preciototal.Name = "Label_preciototal"
        Me.Label_preciototal.Size = New System.Drawing.Size(38, 15)
        Me.Label_preciototal.TabIndex = 235
        Me.Label_preciototal.Text = "00,00"
        '
        'Label_codinterno
        '
        Me.Label_codinterno.AutoSize = True
        Me.Label_codinterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_codinterno.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_codinterno.Location = New System.Drawing.Point(84, 20)
        Me.Label_codinterno.Name = "Label_codinterno"
        Me.Label_codinterno.Size = New System.Drawing.Size(21, 15)
        Me.Label_codinterno.TabIndex = 234
        Me.Label_codinterno.Text = """  """
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(11, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 233
        Me.Label3.Text = "Cód. Interno:"
        '
        'Label_preciolista
        '
        Me.Label_preciolista.AutoSize = True
        Me.Label_preciolista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_preciolista.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_preciolista.Location = New System.Drawing.Point(216, 20)
        Me.Label_preciolista.Name = "Label_preciolista"
        Me.Label_preciolista.Size = New System.Drawing.Size(38, 15)
        Me.Label_preciolista.TabIndex = 103
        Me.Label_preciolista.Text = "00,00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(158, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 15)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "Precio :  $"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Location = New System.Drawing.Point(422, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 15)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Precio Total :   $"
        '
        'TX_LISTA_PROD_cant
        '
        Me.TX_LISTA_PROD_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_LISTA_PROD_cant.ForeColor = System.Drawing.Color.DarkGreen
        Me.TX_LISTA_PROD_cant.Location = New System.Drawing.Point(364, 19)
        Me.TX_LISTA_PROD_cant.Name = "TX_LISTA_PROD_cant"
        Me.TX_LISTA_PROD_cant.Size = New System.Drawing.Size(42, 20)
        Me.TX_LISTA_PROD_cant.TabIndex = 98
        Me.TX_LISTA_PROD_cant.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label15.Location = New System.Drawing.Point(296, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 15)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Cantidad :"
        '
        'BO_Cargar
        '
        Me.BO_Cargar.Image = CType(resources.GetObject("BO_Cargar.Image"), System.Drawing.Image)
        Me.BO_Cargar.Location = New System.Drawing.Point(865, 573)
        Me.BO_Cargar.Name = "BO_Cargar"
        Me.BO_Cargar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Cargar.TabIndex = 232
        Me.ToolTip1.SetToolTip(Me.BO_Cargar, "Cargar")
        Me.BO_Cargar.UseVisualStyleBackColor = True
        '
        'ListaProductoBindingSource
        '
        Me.ListaProductoBindingSource.DataMember = "ListaProducto"
        Me.ListaProductoBindingSource.DataSource = Me.Lista_ds
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Lista_ds
        '
        'Lista_prod_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(929, 625)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.BO_Cargar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(937, 659)
        Me.MinimumSize = New System.Drawing.Size(937, 659)
        Me.Name = "Lista_prod_ADD"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista: Productos - Sistema de Gestion."
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Producto.ResumeLayout(False)
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ListaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_codinterno As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BO_Cargar As System.Windows.Forms.Button
    Friend WithEvents Label_preciolista As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TX_LISTA_PROD_cant As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LB_ERROR As System.Windows.Forms.Label
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents GP_Producto As System.Windows.Forms.GroupBox
    Friend WithEvents BO_busqueda As System.Windows.Forms.Button
    Friend WithEvents Cbox_busqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cbox_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents TX_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents DG_Producto As System.Windows.Forms.DataGridView
    Friend WithEvents ListaProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_ds As Aplicacion.Lista_ds
    Friend WithEvents ProductoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RB_filtro_NO As System.Windows.Forms.RadioButton
    Friend WithEvents RB_filtro_SI As System.Windows.Forms.RadioButton
    Friend WithEvents Label_preciototal As System.Windows.Forms.Label
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescrilargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdpreciovtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdnrocatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdidcatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcanomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
