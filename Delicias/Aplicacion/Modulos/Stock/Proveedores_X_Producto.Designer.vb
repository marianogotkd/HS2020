<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores_X_Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores_X_Producto))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Bo_agregarprod = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DG_Prov_Prod = New System.Windows.Forms.DataGridView()
        Me.ProveedorProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Producto_ds = New Aplicacion.Producto_ds()
        Me.Bo_nuevoprov = New System.Windows.Forms.Button()
        Me.ERROR_tx_proveedor = New System.Windows.Forms.PictureBox()
        Me.cb_proveedores = New System.Windows.Forms.ComboBox()
        Me.DT_fecha_compra = New System.Windows.Forms.DateTimePicker()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.Prov_idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvProdComfechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DG_Prov_Prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Bo_agregarprod)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.DG_Prov_Prod)
        Me.GroupBox4.Controls.Add(Me.Bo_nuevoprov)
        Me.GroupBox4.Controls.Add(Me.ERROR_tx_proveedor)
        Me.GroupBox4.Controls.Add(Me.cb_proveedores)
        Me.GroupBox4.Controls.Add(Me.DT_fecha_compra)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(610, 301)
        Me.GroupBox4.TabIndex = 305
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proveedor del Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 17)
        Me.Label1.TabIndex = 304
        Me.Label1.Text = "Listado de proveedores asignados al producto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 28)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 281
        Me.Label11.Text = "Proveedor"
        '
        'Bo_agregarprod
        '
        Me.Bo_agregarprod.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bo_agregarprod.Location = New System.Drawing.Point(139, 95)
        Me.Bo_agregarprod.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_agregarprod.Name = "Bo_agregarprod"
        Me.Bo_agregarprod.Size = New System.Drawing.Size(164, 27)
        Me.Bo_agregarprod.TabIndex = 3
        Me.Bo_agregarprod.Text = "Asignar"
        Me.Bo_agregarprod.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 303
        Me.Label4.Text = "Fecha de registro:"
        '
        'DG_Prov_Prod
        '
        Me.DG_Prov_Prod.AllowUserToAddRows = False
        Me.DG_Prov_Prod.AllowUserToResizeRows = False
        Me.DG_Prov_Prod.AutoGenerateColumns = False
        Me.DG_Prov_Prod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Prov_Prod.BackgroundColor = System.Drawing.Color.White
        Me.DG_Prov_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Prov_Prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Prov_idColumn, Me.ProvnombreDataGridViewTextBoxColumn, Me.ProdidDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ProvProdComfechaColumn})
        Me.DG_Prov_Prod.DataSource = Me.ProveedorProductoBindingSource
        Me.DG_Prov_Prod.Location = New System.Drawing.Point(13, 155)
        Me.DG_Prov_Prod.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Prov_Prod.MultiSelect = False
        Me.DG_Prov_Prod.Name = "DG_Prov_Prod"
        Me.DG_Prov_Prod.ReadOnly = True
        Me.DG_Prov_Prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Prov_Prod.RowHeadersVisible = False
        Me.DG_Prov_Prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Prov_Prod.Size = New System.Drawing.Size(578, 135)
        Me.DG_Prov_Prod.TabIndex = 288
        '
        'ProveedorProductoBindingSource
        '
        Me.ProveedorProductoBindingSource.DataMember = "ProveedorProducto"
        Me.ProveedorProductoBindingSource.DataSource = Me.Producto_ds
        '
        'Producto_ds
        '
        Me.Producto_ds.DataSetName = "Producto_ds"
        Me.Producto_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bo_nuevoprov
        '
        Me.Bo_nuevoprov.Image = CType(resources.GetObject("Bo_nuevoprov.Image"), System.Drawing.Image)
        Me.Bo_nuevoprov.Location = New System.Drawing.Point(367, 18)
        Me.Bo_nuevoprov.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_nuevoprov.Name = "Bo_nuevoprov"
        Me.Bo_nuevoprov.Size = New System.Drawing.Size(40, 37)
        Me.Bo_nuevoprov.TabIndex = 301
        Me.Bo_nuevoprov.UseVisualStyleBackColor = True
        '
        'ERROR_tx_proveedor
        '
        Me.ERROR_tx_proveedor.Image = CType(resources.GetObject("ERROR_tx_proveedor.Image"), System.Drawing.Image)
        Me.ERROR_tx_proveedor.Location = New System.Drawing.Point(414, 28)
        Me.ERROR_tx_proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.ERROR_tx_proveedor.Name = "ERROR_tx_proveedor"
        Me.ERROR_tx_proveedor.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_proveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_proveedor.TabIndex = 297
        Me.ERROR_tx_proveedor.TabStop = False
        Me.ERROR_tx_proveedor.Visible = False
        '
        'cb_proveedores
        '
        Me.cb_proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_proveedores.FormattingEnabled = True
        Me.cb_proveedores.Location = New System.Drawing.Point(139, 26)
        Me.cb_proveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_proveedores.Name = "cb_proveedores"
        Me.cb_proveedores.Size = New System.Drawing.Size(219, 24)
        Me.cb_proveedores.TabIndex = 0
        '
        'DT_fecha_compra
        '
        Me.DT_fecha_compra.Location = New System.Drawing.Point(139, 65)
        Me.DT_fecha_compra.Margin = New System.Windows.Forms.Padding(4)
        Me.DT_fecha_compra.Name = "DT_fecha_compra"
        Me.DT_fecha_compra.Size = New System.Drawing.Size(288, 22)
        Me.DT_fecha_compra.TabIndex = 2
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(496, 310)
        Me.Bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(99, 65)
        Me.Bo_guardar.TabIndex = 4
        Me.Bo_guardar.Text = "Aceptar"
        Me.Bo_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bo_guardar.UseVisualStyleBackColor = True
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(391, 310)
        Me.Bo_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(97, 65)
        Me.Bo_cancelar.TabIndex = 5
        Me.Bo_cancelar.Text = "Cancelar"
        Me.Bo_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        '
        'Prov_idColumn
        '
        Me.Prov_idColumn.DataPropertyName = "Prov_id"
        Me.Prov_idColumn.HeaderText = "Prov_id"
        Me.Prov_idColumn.Name = "Prov_idColumn"
        Me.Prov_idColumn.ReadOnly = True
        Me.Prov_idColumn.Visible = False
        '
        'ProvnombreDataGridViewTextBoxColumn
        '
        Me.ProvnombreDataGridViewTextBoxColumn.DataPropertyName = "Prov_nombre"
        Me.ProvnombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProvnombreDataGridViewTextBoxColumn.Name = "ProvnombreDataGridViewTextBoxColumn"
        Me.ProvnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdidDataGridViewTextBoxColumn
        '
        Me.ProdidDataGridViewTextBoxColumn.DataPropertyName = "Prod_id"
        Me.ProdidDataGridViewTextBoxColumn.HeaderText = "Prod_id"
        Me.ProdidDataGridViewTextBoxColumn.Name = "ProdidDataGridViewTextBoxColumn"
        Me.ProdidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdidDataGridViewTextBoxColumn.Visible = False
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "Prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn.Visible = False
        '
        'ProvProdComfechaColumn
        '
        Me.ProvProdComfechaColumn.DataPropertyName = "Prov_Prod_Com_fecha"
        Me.ProvProdComfechaColumn.HeaderText = "Fecha de registro"
        Me.ProvProdComfechaColumn.Name = "ProvProdComfechaColumn"
        Me.ProvProdComfechaColumn.ReadOnly = True
        '
        'Proveedores_X_Producto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(628, 380)
        Me.Controls.Add(Me.Bo_cancelar)
        Me.Controls.Add(Me.Bo_guardar)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Proveedores_X_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Proveedores"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DG_Prov_Prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Bo_nuevoprov As System.Windows.Forms.Button
    Friend WithEvents ERROR_tx_proveedor As System.Windows.Forms.PictureBox
    Friend WithEvents cb_proveedores As System.Windows.Forms.ComboBox
    Friend WithEvents DT_fecha_compra As System.Windows.Forms.DateTimePicker
    Friend WithEvents DG_Prov_Prod As System.Windows.Forms.DataGridView
    Friend WithEvents Bo_agregarprod As System.Windows.Forms.Button
    Friend WithEvents Bo_guardar As System.Windows.Forms.Button
    Friend WithEvents Bo_cancelar As System.Windows.Forms.Button
    Friend WithEvents ProveedorProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Producto_ds As Aplicacion.Producto_ds
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Prov_idColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvProdComfechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
