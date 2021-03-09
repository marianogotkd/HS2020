<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos_Nuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos_Nuevo))
        Me.DG_Pedido = New System.Windows.Forms.DataGridView()
        Me.ProdcodinternoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescrilargaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_precio_vta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvProdComidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPedidos = New Aplicacion.dsPedidos()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tx_nomprod = New System.Windows.Forms.TextBox()
        Me.Lb_nomprod_modif = New System.Windows.Forms.Label()
        Me.Tx_Codinterno = New System.Windows.Forms.TextBox()
        Me.Lb_codinterno_modif = New System.Windows.Forms.Label()
        Me.DG_Producto = New System.Windows.Forms.DataGridView()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescrilargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdpreciovtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdptorepoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvProdComidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObtenerPedidosBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LB_ERROR = New System.Windows.Forms.Label()
        Me.Bo_buscar_nombre = New System.Windows.Forms.Button()
        Me.BO_Buscar_codinterno = New System.Windows.Forms.Button()
        Me.BO_mas = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TX_Cantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BO_menos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tx_codigo = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TX_TOTAL = New System.Windows.Forms.TextBox()
        Me.GP_Proveedor = New System.Windows.Forms.GroupBox()
        Me.Combo_Prove = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DG_Pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObtenerPedidosBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GP_Proveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_Pedido
        '
        Me.DG_Pedido.AllowUserToAddRows = False
        Me.DG_Pedido.AllowUserToDeleteRows = False
        Me.DG_Pedido.AutoGenerateColumns = False
        Me.DG_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdcodinternoDataGridViewTextBoxColumn1, Me.ProddescripcionDataGridViewTextBoxColumn1, Me.ProddescrilargaDataGridViewTextBoxColumn1, Me.CantidadDataGridViewTextBoxColumn, Me.prod_precio_vta, Me.ProvProdComidDataGridViewTextBoxColumn1, Me.ProdidDataGridViewTextBoxColumn1, Me.ProvidDataGridViewTextBoxColumn1, Me.Total})
        Me.DG_Pedido.DataSource = Me.PedidosBindingSource4
        Me.DG_Pedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Pedido.Location = New System.Drawing.Point(3, 16)
        Me.DG_Pedido.MultiSelect = False
        Me.DG_Pedido.Name = "DG_Pedido"
        Me.DG_Pedido.ReadOnly = True
        Me.DG_Pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Pedido.Size = New System.Drawing.Size(692, 154)
        Me.DG_Pedido.TabIndex = 0
        '
        'ProdcodinternoDataGridViewTextBoxColumn1
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn1.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn1.HeaderText = "Codigo "
        Me.ProdcodinternoDataGridViewTextBoxColumn1.Name = "ProdcodinternoDataGridViewTextBoxColumn1"
        Me.ProdcodinternoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProddescripcionDataGridViewTextBoxColumn1
        '
        Me.ProddescripcionDataGridViewTextBoxColumn1.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn1.HeaderText = "Producto"
        Me.ProddescripcionDataGridViewTextBoxColumn1.Name = "ProddescripcionDataGridViewTextBoxColumn1"
        Me.ProddescripcionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn1.Width = 160
        '
        'ProddescrilargaDataGridViewTextBoxColumn1
        '
        Me.ProddescrilargaDataGridViewTextBoxColumn1.DataPropertyName = "prod_descrilarga"
        Me.ProddescrilargaDataGridViewTextBoxColumn1.HeaderText = "Producto"
        Me.ProddescrilargaDataGridViewTextBoxColumn1.Name = "ProddescrilargaDataGridViewTextBoxColumn1"
        Me.ProddescrilargaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProddescrilargaDataGridViewTextBoxColumn1.Visible = False
        Me.ProddescrilargaDataGridViewTextBoxColumn1.Width = 160
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'prod_precio_vta
        '
        Me.prod_precio_vta.DataPropertyName = "prod_precio_vta"
        Me.prod_precio_vta.HeaderText = "Precio de Venta"
        Me.prod_precio_vta.Name = "prod_precio_vta"
        Me.prod_precio_vta.ReadOnly = True
        Me.prod_precio_vta.Width = 115
        '
        'ProvProdComidDataGridViewTextBoxColumn1
        '
        Me.ProvProdComidDataGridViewTextBoxColumn1.DataPropertyName = "Prov_Prod_Com_id"
        Me.ProvProdComidDataGridViewTextBoxColumn1.HeaderText = "Prov_Prod_Com_id"
        Me.ProvProdComidDataGridViewTextBoxColumn1.Name = "ProvProdComidDataGridViewTextBoxColumn1"
        Me.ProvProdComidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProvProdComidDataGridViewTextBoxColumn1.Visible = False
        '
        'ProdidDataGridViewTextBoxColumn1
        '
        Me.ProdidDataGridViewTextBoxColumn1.DataPropertyName = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn1.HeaderText = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn1.Name = "ProdidDataGridViewTextBoxColumn1"
        Me.ProdidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProdidDataGridViewTextBoxColumn1.Visible = False
        '
        'ProvidDataGridViewTextBoxColumn1
        '
        Me.ProvidDataGridViewTextBoxColumn1.DataPropertyName = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn1.HeaderText = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn1.Name = "ProvidDataGridViewTextBoxColumn1"
        Me.ProvidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProvidDataGridViewTextBoxColumn1.Visible = False
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Sub Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'PedidosBindingSource4
        '
        Me.PedidosBindingSource4.DataMember = "Pedidos"
        Me.PedidosBindingSource4.DataSource = Me.DsPedidos
        '
        'DsPedidos
        '
        Me.DsPedidos.DataSetName = "dsPedidos"
        Me.DsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proveedor"
        '
        'Tx_nomprod
        '
        Me.Tx_nomprod.Location = New System.Drawing.Point(381, 20)
        Me.Tx_nomprod.Name = "Tx_nomprod"
        Me.Tx_nomprod.Size = New System.Drawing.Size(193, 20)
        Me.Tx_nomprod.TabIndex = 13
        Me.Tx_nomprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_nomprod_modif
        '
        Me.Lb_nomprod_modif.AutoSize = True
        Me.Lb_nomprod_modif.Location = New System.Drawing.Point(331, 23)
        Me.Lb_nomprod_modif.Name = "Lb_nomprod_modif"
        Me.Lb_nomprod_modif.Size = New System.Drawing.Size(44, 13)
        Me.Lb_nomprod_modif.TabIndex = 12
        Me.Lb_nomprod_modif.Text = "Nombre"
        '
        'Tx_Codinterno
        '
        Me.Tx_Codinterno.Location = New System.Drawing.Point(164, 19)
        Me.Tx_Codinterno.Name = "Tx_Codinterno"
        Me.Tx_Codinterno.Size = New System.Drawing.Size(100, 20)
        Me.Tx_Codinterno.TabIndex = 10
        Me.Tx_Codinterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_codinterno_modif
        '
        Me.Lb_codinterno_modif.AutoSize = True
        Me.Lb_codinterno_modif.Location = New System.Drawing.Point(82, 23)
        Me.Lb_codinterno_modif.Name = "Lb_codinterno_modif"
        Me.Lb_codinterno_modif.Size = New System.Drawing.Size(76, 13)
        Me.Lb_codinterno_modif.TabIndex = 9
        Me.Lb_codinterno_modif.Text = "Codigo Interno"
        '
        'DG_Producto
        '
        Me.DG_Producto.AllowUserToAddRows = False
        Me.DG_Producto.AllowUserToDeleteRows = False
        Me.DG_Producto.AutoGenerateColumns = False
        Me.DG_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Producto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ProddescrilargaDataGridViewTextBoxColumn, Me.ProdpreciovtaDataGridViewTextBoxColumn, Me.ProdstockDataGridViewTextBoxColumn, Me.ProdidDataGridViewTextBoxColumn, Me.ProvidDataGridViewTextBoxColumn, Me.ProdptorepoDataGridViewTextBoxColumn, Me.ProvProdComidDataGridViewTextBoxColumn})
        Me.DG_Producto.DataSource = Me.ObtenerPedidosBindingSource6
        Me.DG_Producto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Producto.Location = New System.Drawing.Point(3, 16)
        Me.DG_Producto.MultiSelect = False
        Me.DG_Producto.Name = "DG_Producto"
        Me.DG_Producto.ReadOnly = True
        Me.DG_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Producto.Size = New System.Drawing.Size(690, 185)
        Me.DG_Producto.TabIndex = 8
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn.Width = 160
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
        Me.ProdpreciovtaDataGridViewTextBoxColumn.HeaderText = "Precio Venta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Name = "ProdpreciovtaDataGridViewTextBoxColumn"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Width = 115
        '
        'ProdstockDataGridViewTextBoxColumn
        '
        Me.ProdstockDataGridViewTextBoxColumn.DataPropertyName = "prod_stock"
        Me.ProdstockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.ProdstockDataGridViewTextBoxColumn.Name = "ProdstockDataGridViewTextBoxColumn"
        Me.ProdstockDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdstockDataGridViewTextBoxColumn.Width = 115
        '
        'ProdidDataGridViewTextBoxColumn
        '
        Me.ProdidDataGridViewTextBoxColumn.DataPropertyName = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.HeaderText = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.Name = "ProdidDataGridViewTextBoxColumn"
        Me.ProdidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdidDataGridViewTextBoxColumn.Visible = False
        '
        'ProvidDataGridViewTextBoxColumn
        '
        Me.ProvidDataGridViewTextBoxColumn.DataPropertyName = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.HeaderText = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.Name = "ProvidDataGridViewTextBoxColumn"
        Me.ProvidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvidDataGridViewTextBoxColumn.Visible = False
        '
        'ProdptorepoDataGridViewTextBoxColumn
        '
        Me.ProdptorepoDataGridViewTextBoxColumn.DataPropertyName = "prod_ptorepo"
        Me.ProdptorepoDataGridViewTextBoxColumn.HeaderText = "Pto. Reposicion"
        Me.ProdptorepoDataGridViewTextBoxColumn.Name = "ProdptorepoDataGridViewTextBoxColumn"
        Me.ProdptorepoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdptorepoDataGridViewTextBoxColumn.Width = 115
        '
        'ProvProdComidDataGridViewTextBoxColumn
        '
        Me.ProvProdComidDataGridViewTextBoxColumn.DataPropertyName = "Prov_Prod_Com_id"
        Me.ProvProdComidDataGridViewTextBoxColumn.HeaderText = "Prov_Prod_Com_id"
        Me.ProvProdComidDataGridViewTextBoxColumn.Name = "ProvProdComidDataGridViewTextBoxColumn"
        Me.ProvProdComidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvProdComidDataGridViewTextBoxColumn.Visible = False
        '
        'ObtenerPedidosBindingSource6
        '
        Me.ObtenerPedidosBindingSource6.DataMember = "Obtener_Pedidos"
        Me.ObtenerPedidosBindingSource6.DataSource = Me.DsPedidos
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IM_ERROR)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.LB_ERROR)
        Me.GroupBox1.Controls.Add(Me.Bo_buscar_nombre)
        Me.GroupBox1.Controls.Add(Me.Tx_nomprod)
        Me.GroupBox1.Controls.Add(Me.Lb_nomprod_modif)
        Me.GroupBox1.Controls.Add(Me.BO_Buscar_codinterno)
        Me.GroupBox1.Controls.Add(Me.Tx_Codinterno)
        Me.GroupBox1.Controls.Add(Me.Lb_codinterno_modif)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 257)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedor Productos"
        '
        'IM_ERROR
        '
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(616, 20)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 235
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DG_Producto)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(696, 204)
        Me.GroupBox4.TabIndex = 237
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Producto"
        '
        'LB_ERROR
        '
        Me.LB_ERROR.AutoSize = True
        Me.LB_ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR.ForeColor = System.Drawing.Color.Red
        Me.LB_ERROR.Location = New System.Drawing.Point(633, 23)
        Me.LB_ERROR.Name = "LB_ERROR"
        Me.LB_ERROR.Size = New System.Drawing.Size(59, 15)
        Me.LB_ERROR.TabIndex = 236
        Me.LB_ERROR.Text = "No Existe"
        Me.LB_ERROR.Visible = False
        '
        'Bo_buscar_nombre
        '
        Me.Bo_buscar_nombre.Image = CType(resources.GetObject("Bo_buscar_nombre.Image"), System.Drawing.Image)
        Me.Bo_buscar_nombre.Location = New System.Drawing.Point(580, 14)
        Me.Bo_buscar_nombre.Name = "Bo_buscar_nombre"
        Me.Bo_buscar_nombre.Size = New System.Drawing.Size(30, 30)
        Me.Bo_buscar_nombre.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Bo_buscar_nombre, "Buscar")
        Me.Bo_buscar_nombre.UseVisualStyleBackColor = True
        '
        'BO_Buscar_codinterno
        '
        Me.BO_Buscar_codinterno.Image = CType(resources.GetObject("BO_Buscar_codinterno.Image"), System.Drawing.Image)
        Me.BO_Buscar_codinterno.Location = New System.Drawing.Point(270, 14)
        Me.BO_Buscar_codinterno.Name = "BO_Buscar_codinterno"
        Me.BO_Buscar_codinterno.Size = New System.Drawing.Size(30, 30)
        Me.BO_Buscar_codinterno.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.BO_Buscar_codinterno, "Buscar")
        Me.BO_Buscar_codinterno.UseVisualStyleBackColor = True
        '
        'BO_mas
        '
        Me.BO_mas.Enabled = False
        Me.BO_mas.Image = CType(resources.GetObject("BO_mas.Image"), System.Drawing.Image)
        Me.BO_mas.Location = New System.Drawing.Point(747, 183)
        Me.BO_mas.Name = "BO_mas"
        Me.BO_mas.Size = New System.Drawing.Size(30, 30)
        Me.BO_mas.TabIndex = 232
        Me.ToolTip1.SetToolTip(Me.BO_mas, "Agregar Producto")
        Me.BO_mas.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TX_Cantidad)
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox5.Location = New System.Drawing.Point(732, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(119, 65)
        Me.GroupBox5.TabIndex = 234
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cantidad"
        '
        'TX_Cantidad
        '
        Me.TX_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_Cantidad.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TX_Cantidad.Location = New System.Drawing.Point(15, 28)
        Me.TX_Cantidad.Name = "TX_Cantidad"
        Me.TX_Cantidad.Size = New System.Drawing.Size(88, 20)
        Me.TX_Cantidad.TabIndex = 98
        Me.TX_Cantidad.Text = "1"
        Me.TX_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DG_Pedido)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(17, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(698, 173)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pedido"
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Enabled = False
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(833, 551)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(40, 40)
        Me.Bo_guardar.TabIndex = 236
        Me.ToolTip1.SetToolTip(Me.Bo_guardar, "Guardar")
        Me.Bo_guardar.UseVisualStyleBackColor = True
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(787, 551)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.Bo_cancelar.TabIndex = 235
        Me.ToolTip1.SetToolTip(Me.Bo_cancelar, "Cancelar")
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(564, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(221, 20)
        Me.DateTimePicker1.TabIndex = 237
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(521, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "Fecha"
        '
        'BO_menos
        '
        Me.BO_menos.Image = CType(resources.GetObject("BO_menos.Image"), System.Drawing.Image)
        Me.BO_menos.Location = New System.Drawing.Point(721, 458)
        Me.BO_menos.Name = "BO_menos"
        Me.BO_menos.Size = New System.Drawing.Size(30, 30)
        Me.BO_menos.TabIndex = 239
        Me.ToolTip1.SetToolTip(Me.BO_menos, "Quitar Producto")
        Me.BO_menos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "N° Pedido"
        '
        'tx_codigo
        '
        Me.tx_codigo.Enabled = False
        Me.tx_codigo.Location = New System.Drawing.Point(114, 21)
        Me.tx_codigo.Name = "tx_codigo"
        Me.tx_codigo.Size = New System.Drawing.Size(67, 20)
        Me.tx_codigo.TabIndex = 241
        Me.tx_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(865, 533)
        Me.TabControl1.TabIndex = 243
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.BO_mas)
        Me.TabPage1.Controls.Add(Me.GP_Proveedor)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BO_menos)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(857, 507)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pedido: Nuevo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TX_TOTAL)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(721, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(130, 65)
        Me.GroupBox3.TabIndex = 244
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total del Pedido"
        '
        'TX_TOTAL
        '
        Me.TX_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_TOTAL.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TX_TOTAL.Location = New System.Drawing.Point(15, 28)
        Me.TX_TOTAL.Name = "TX_TOTAL"
        Me.TX_TOTAL.Size = New System.Drawing.Size(88, 20)
        Me.TX_TOTAL.TabIndex = 98
        Me.TX_TOTAL.Text = "1"
        Me.TX_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GP_Proveedor
        '
        Me.GP_Proveedor.Controls.Add(Me.Combo_Prove)
        Me.GP_Proveedor.Controls.Add(Me.Label3)
        Me.GP_Proveedor.Controls.Add(Me.Label1)
        Me.GP_Proveedor.Controls.Add(Me.DateTimePicker1)
        Me.GP_Proveedor.Controls.Add(Me.tx_codigo)
        Me.GP_Proveedor.Controls.Add(Me.Label2)
        Me.GP_Proveedor.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Proveedor.Location = New System.Drawing.Point(6, 6)
        Me.GP_Proveedor.Name = "GP_Proveedor"
        Me.GP_Proveedor.Size = New System.Drawing.Size(845, 53)
        Me.GP_Proveedor.TabIndex = 243
        Me.GP_Proveedor.TabStop = False
        Me.GP_Proveedor.Text = "Proveedor"
        '
        'Combo_Prove
        '
        Me.Combo_Prove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Prove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Prove.FormattingEnabled = True
        Me.Combo_Prove.Location = New System.Drawing.Point(270, 19)
        Me.Combo_Prove.Name = "Combo_Prove"
        Me.Combo_Prove.Size = New System.Drawing.Size(183, 23)
        Me.Combo_Prove.TabIndex = 243
        '
        'Pedidos_Nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 603)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Bo_guardar)
        Me.Controls.Add(Me.Bo_cancelar)
        Me.Name = "Pedidos_Nuevo"
        Me.Text = "Pedidos"
        CType(Me.DG_Pedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObtenerPedidosBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GP_Proveedor.ResumeLayout(False)
        Me.GP_Proveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG_Pedido As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bo_buscar_nombre As System.Windows.Forms.Button
    Friend WithEvents Tx_nomprod As System.Windows.Forms.TextBox
    Friend WithEvents Lb_nomprod_modif As System.Windows.Forms.Label
    Friend WithEvents BO_Buscar_codinterno As System.Windows.Forms.Button
    Friend WithEvents Tx_Codinterno As System.Windows.Forms.TextBox
    Friend WithEvents Lb_codinterno_modif As System.Windows.Forms.Label
    Friend WithEvents DG_Producto As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_mas As System.Windows.Forms.Button
    Friend WithEvents TX_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Bo_guardar As System.Windows.Forms.Button
    Friend WithEvents Bo_cancelar As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LB_ERROR As System.Windows.Forms.Label
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents BO_menos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tx_codigo As System.Windows.Forms.TextBox
    Friend WithEvents DsPedidos As Aplicacion.dsPedidos
    Friend WithEvents ObtenerPedidosBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents PedidosBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GP_Proveedor As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Combo_Prove As System.Windows.Forms.ComboBox
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescrilargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdpreciovtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdstockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdptorepoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvProdComidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TX_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescrilargaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_precio_vta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvProdComidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
