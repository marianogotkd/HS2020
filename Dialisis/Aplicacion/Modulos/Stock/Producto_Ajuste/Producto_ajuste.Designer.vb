<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_ajuste
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BO_producto_nuevo = New System.Windows.Forms.Button()
        Me.btn_eliminar_seleccion = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LotebajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_totalreal = New System.Windows.Forms.TextBox()
        Me.LotenroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdxSucstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotecantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote_stock_real = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote_aux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotefechafabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotefechavtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotevenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotebajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_totalunidades
        '
        Me.txt_totalunidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalunidades.Location = New System.Drawing.Point(147, 74)
        Me.txt_totalunidades.Name = "txt_totalunidades"
        Me.txt_totalunidades.ReadOnly = True
        Me.txt_totalunidades.Size = New System.Drawing.Size(131, 30)
        Me.txt_totalunidades.TabIndex = 47
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(77, 46)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ReadOnly = True
        Me.txt_descripcion.Size = New System.Drawing.Size(201, 20)
        Me.txt_descripcion.TabIndex = 46
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(77, 12)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(201, 20)
        Me.txt_codigo.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(307, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 100)
        Me.GroupBox1.TabIndex = 44
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
        Me.Label_totalunidades.Location = New System.Drawing.Point(98, 82)
        Me.Label_totalunidades.Name = "Label_totalunidades"
        Me.Label_totalunidades.Size = New System.Drawing.Size(43, 13)
        Me.Label_totalunidades.TabIndex = 43
        Me.Label_totalunidades.Text = "STOCK"
        '
        'Label_codigo
        '
        Me.Label_codigo.AutoSize = True
        Me.Label_codigo.Location = New System.Drawing.Point(28, 15)
        Me.Label_codigo.Name = "Label_codigo"
        Me.Label_codigo.Size = New System.Drawing.Size(43, 13)
        Me.Label_codigo.TabIndex = 42
        Me.Label_codigo.Text = "Código:"
        '
        'Label_descripcion
        '
        Me.Label_descripcion.AutoSize = True
        Me.Label_descripcion.Location = New System.Drawing.Point(5, 49)
        Me.Label_descripcion.Name = "Label_descripcion"
        Me.Label_descripcion.Size = New System.Drawing.Size(66, 13)
        Me.Label_descripcion.TabIndex = 41
        Me.Label_descripcion.Text = "Descripción:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.BO_producto_nuevo)
        Me.GroupBox2.Controls.Add(Me.btn_eliminar_seleccion)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 302)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lotes existentes:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_editar_30x30
        Me.Button1.Location = New System.Drawing.Point(505, 251)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 261
        Me.Button1.Text = "Editar vto."
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Editar vencimiento")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.icono_editar_30x30
        Me.Button3.Location = New System.Drawing.Point(373, 251)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 43)
        Me.Button3.TabIndex = 260
        Me.Button3.Text = "Ajustar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button3, "Agregar nuevo Producto")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BO_producto_nuevo
        '
        Me.BO_producto_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_producto_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_producto_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_producto_nuevo.Location = New System.Drawing.Point(241, 251)
        Me.BO_producto_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_producto_nuevo.Name = "BO_producto_nuevo"
        Me.BO_producto_nuevo.Size = New System.Drawing.Size(124, 43)
        Me.BO_producto_nuevo.TabIndex = 31
        Me.BO_producto_nuevo.Text = "Agregar"
        Me.BO_producto_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_producto_nuevo, "Agregar nuevo Producto")
        Me.BO_producto_nuevo.UseVisualStyleBackColor = True
        '
        'btn_eliminar_seleccion
        '
        Me.btn_eliminar_seleccion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_eliminar_seleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_seleccion.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_eliminar_seleccion.Location = New System.Drawing.Point(111, 252)
        Me.btn_eliminar_seleccion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar_seleccion.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_eliminar_seleccion.Name = "btn_eliminar_seleccion"
        Me.btn_eliminar_seleccion.Size = New System.Drawing.Size(124, 43)
        Me.btn_eliminar_seleccion.TabIndex = 28
        Me.btn_eliminar_seleccion.Text = "Eliminar"
        Me.btn_eliminar_seleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_eliminar_seleccion, "Eliminar lotes seleccionados")
        Me.btn_eliminar_seleccion.UseVisualStyleBackColor = True
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LotenroDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.ProdidDataGridViewTextBoxColumn, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ProdxSucstockDataGridViewTextBoxColumn, Me.LoteidDataGridViewTextBoxColumn, Me.LotecantidadDataGridViewTextBoxColumn, Me.lote_stock_real, Me.lote_aux, Me.LotefechafabDataGridViewTextBoxColumn, Me.LotefechavtoDataGridViewTextBoxColumn, Me.LotevenceDataGridViewTextBoxColumn, Me.SucursalidDataGridViewTextBoxColumn, Me.ProvidDataGridViewTextBoxColumn, Me.Item})
        Me.DataGridView2.DataSource = Me.LotebajaBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(721, 209)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 27
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
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button4.Location = New System.Drawing.Point(12, 447)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 43)
        Me.Button4.TabIndex = 259
        Me.Button4.Text = "Volver"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "Contenido total:"
        '
        'txt_totalreal
        '
        Me.txt_totalreal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalreal.Location = New System.Drawing.Point(147, 110)
        Me.txt_totalreal.Name = "txt_totalreal"
        Me.txt_totalreal.ReadOnly = True
        Me.txt_totalreal.Size = New System.Drawing.Size(131, 22)
        Me.txt_totalreal.TabIndex = 261
        '
        'LotenroDataGridViewTextBoxColumn
        '
        Me.LotenroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LotenroDataGridViewTextBoxColumn.DataPropertyName = "lote_nro"
        Me.LotenroDataGridViewTextBoxColumn.HeaderText = "Nº/Lote"
        Me.LotenroDataGridViewTextBoxColumn.Name = "LotenroDataGridViewTextBoxColumn"
        Me.LotenroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        Me.ProveedorDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Visible = False
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.Visible = False
        '
        'ProdxSucstockDataGridViewTextBoxColumn
        '
        Me.ProdxSucstockDataGridViewTextBoxColumn.DataPropertyName = "ProdxSuc_stock"
        Me.ProdxSucstockDataGridViewTextBoxColumn.HeaderText = "ProdxSuc_stock"
        Me.ProdxSucstockDataGridViewTextBoxColumn.Name = "ProdxSucstockDataGridViewTextBoxColumn"
        Me.ProdxSucstockDataGridViewTextBoxColumn.Visible = False
        '
        'LoteidDataGridViewTextBoxColumn
        '
        Me.LoteidDataGridViewTextBoxColumn.DataPropertyName = "lote_id"
        Me.LoteidDataGridViewTextBoxColumn.HeaderText = "lote_id"
        Me.LoteidDataGridViewTextBoxColumn.Name = "LoteidDataGridViewTextBoxColumn"
        Me.LoteidDataGridViewTextBoxColumn.Visible = False
        '
        'LotecantidadDataGridViewTextBoxColumn
        '
        Me.LotecantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LotecantidadDataGridViewTextBoxColumn.DataPropertyName = "lote_cantidad"
        Me.LotecantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.LotecantidadDataGridViewTextBoxColumn.Name = "LotecantidadDataGridViewTextBoxColumn"
        Me.LotecantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'lote_stock_real
        '
        Me.lote_stock_real.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lote_stock_real.DataPropertyName = "lote_stock_real"
        Me.lote_stock_real.HeaderText = "Contenido total"
        Me.lote_stock_real.Name = "lote_stock_real"
        '
        'lote_aux
        '
        Me.lote_aux.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lote_aux.DataPropertyName = "lote_aux"
        Me.lote_aux.HeaderText = "lote_aux"
        Me.lote_aux.Name = "lote_aux"
        Me.lote_aux.Visible = False
        '
        'LotefechafabDataGridViewTextBoxColumn
        '
        Me.LotefechafabDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LotefechafabDataGridViewTextBoxColumn.DataPropertyName = "lote_fechafab"
        Me.LotefechafabDataGridViewTextBoxColumn.HeaderText = "Fecha Fab."
        Me.LotefechafabDataGridViewTextBoxColumn.Name = "LotefechafabDataGridViewTextBoxColumn"
        Me.LotefechafabDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotefechavtoDataGridViewTextBoxColumn
        '
        Me.LotefechavtoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LotefechavtoDataGridViewTextBoxColumn.DataPropertyName = "lote_fechavto"
        Me.LotefechavtoDataGridViewTextBoxColumn.HeaderText = "Fecha Vto."
        Me.LotefechavtoDataGridViewTextBoxColumn.Name = "LotefechavtoDataGridViewTextBoxColumn"
        Me.LotefechavtoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotevenceDataGridViewTextBoxColumn
        '
        Me.LotevenceDataGridViewTextBoxColumn.DataPropertyName = "lote_vence"
        Me.LotevenceDataGridViewTextBoxColumn.HeaderText = "lote_vence"
        Me.LotevenceDataGridViewTextBoxColumn.Name = "LotevenceDataGridViewTextBoxColumn"
        Me.LotevenceDataGridViewTextBoxColumn.Visible = False
        '
        'SucursalidDataGridViewTextBoxColumn
        '
        Me.SucursalidDataGridViewTextBoxColumn.DataPropertyName = "sucursal_id"
        Me.SucursalidDataGridViewTextBoxColumn.HeaderText = "sucursal_id"
        Me.SucursalidDataGridViewTextBoxColumn.Name = "SucursalidDataGridViewTextBoxColumn"
        Me.SucursalidDataGridViewTextBoxColumn.Visible = False
        '
        'ProvidDataGridViewTextBoxColumn
        '
        Me.ProvidDataGridViewTextBoxColumn.DataPropertyName = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.HeaderText = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.Name = "ProvidDataGridViewTextBoxColumn"
        Me.ProvidDataGridViewTextBoxColumn.Visible = False
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.Width = 35
        '
        'Producto_ajuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(770, 495)
        Me.Controls.Add(Me.txt_totalreal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_totalunidades)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_totalunidades)
        Me.Controls.Add(Me.Label_codigo)
        Me.Controls.Add(Me.Label_descripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Producto_ajuste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AJUSTE DE STOCK. Sucursal:"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotebajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents LotebajaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents btn_eliminar_seleccion As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BO_producto_nuevo As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_totalreal As System.Windows.Forms.TextBox
    Friend WithEvents LotenroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdxSucstockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotecantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote_stock_real As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote_aux As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotefechafabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotefechavtoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotevenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
