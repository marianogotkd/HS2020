<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_Reporte_Global
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto_Reporte_Global))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Tx_Buscqueda = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BO_producto_modificar = New System.Windows.Forms.Button()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_origen = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_Producto = New System.Windows.Forms.DataGridView()
        Me.prod_codbarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Producto_ds = New Aplicacion.Producto_ds()
        Me.ProdxSucGLOBALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdpreciovtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdxSucstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdxSucptorepoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcanomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdxSucGLOBALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 6)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1291, 607)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Tx_Buscqueda)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cb_origen)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1283, 578)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Busqueda de Productos"
        '
        'Tx_Buscqueda
        '
        Me.Tx_Buscqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Buscqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx_Buscqueda.Location = New System.Drawing.Point(8, 71)
        Me.Tx_Buscqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Tx_Buscqueda.Name = "Tx_Buscqueda"
        Me.Tx_Buscqueda.Size = New System.Drawing.Size(1202, 22)
        Me.Tx_Buscqueda.TabIndex = 1
        Me.Tx_Buscqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.BO_producto_modificar)
        Me.Panel1.Controls.Add(Me.Bo_guardar)
        Me.Panel1.Controls.Add(Me.Bo_cancelar)
        Me.Panel1.Location = New System.Drawing.Point(6, 512)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 63)
        Me.Panel1.TabIndex = 24
        '
        'BO_producto_modificar
        '
        Me.BO_producto_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_producto_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_producto_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_producto_modificar.Location = New System.Drawing.Point(1060, 9)
        Me.BO_producto_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_producto_modificar.Name = "BO_producto_modificar"
        Me.BO_producto_modificar.Size = New System.Drawing.Size(124, 43)
        Me.BO_producto_modificar.TabIndex = 0
        Me.BO_producto_modificar.Text = "Editar"
        Me.BO_producto_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_producto_modificar.UseVisualStyleBackColor = True
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(261, 13)
        Me.Bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(53, 49)
        Me.Bo_guardar.TabIndex = 1
        Me.Bo_guardar.UseVisualStyleBackColor = True
        Me.Bo_guardar.Visible = False
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(346, 6)
        Me.Bo_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(53, 49)
        Me.Bo_cancelar.TabIndex = 0
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        Me.Bo_cancelar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Seleccione la Sucursal"
        '
        'cb_origen
        '
        Me.cb_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_origen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_origen.FormattingEnabled = True
        Me.cb_origen.ItemHeight = 16
        Me.cb_origen.Location = New System.Drawing.Point(232, 8)
        Me.cb_origen.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_origen.MaximumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.MinimumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.Name = "cb_origen"
        Me.cb_origen.Size = New System.Drawing.Size(265, 24)
        Me.cb_origen.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DG_Producto)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 115)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1267, 390)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos:"
        '
        'DG_Producto
        '
        Me.DG_Producto.AllowUserToAddRows = False
        Me.DG_Producto.AllowUserToDeleteRows = False
        Me.DG_Producto.AllowUserToResizeRows = False
        Me.DG_Producto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Producto.AutoGenerateColumns = False
        Me.DG_Producto.BackgroundColor = System.Drawing.Color.White
        Me.DG_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Producto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod_codbarra, Me.Column1, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ProdpreciovtaDataGridViewTextBoxColumn, Me.ProdidDataGridViewTextBoxColumn, Me.ProdxSucstockDataGridViewTextBoxColumn, Me.ProdxSucptorepoDataGridViewTextBoxColumn, Me.SucursalidDataGridViewTextBoxColumn, Me.MarcanomDataGridViewTextBoxColumn, Me.ProvnombreDataGridViewTextBoxColumn, Me.ProvidDataGridViewTextBoxColumn})
        Me.DG_Producto.DataSource = Me.ProdxSucGLOBALBindingSource
        Me.DG_Producto.Location = New System.Drawing.Point(0, 23)
        Me.DG_Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Producto.MultiSelect = False
        Me.DG_Producto.Name = "DG_Producto"
        Me.DG_Producto.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Producto.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Producto.Size = New System.Drawing.Size(1240, 359)
        Me.DG_Producto.StandardTab = True
        Me.DG_Producto.TabIndex = 0
        '
        'prod_codbarra
        '
        Me.prod_codbarra.DataPropertyName = "prod_codbarra"
        Me.prod_codbarra.HeaderText = "prod_codbarra"
        Me.prod_codbarra.Name = "prod_codbarra"
        Me.prod_codbarra.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.FillWeight = 177.665!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Visible = False
        '
        'Producto_ds
        '
        Me.Producto_ds.DataSetName = "Producto_ds"
        Me.Producto_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdxSucGLOBALBindingSource
        '
        Me.ProdxSucGLOBALBindingSource.DataMember = "ProdxSuc_GLOBAL"
        Me.ProdxSucGLOBALBindingSource.DataSource = Me.Producto_ds
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        '
        'ProdpreciovtaDataGridViewTextBoxColumn
        '
        Me.ProdpreciovtaDataGridViewTextBoxColumn.DataPropertyName = "prod_precio_vta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.HeaderText = "prod_precio_vta"
        Me.ProdpreciovtaDataGridViewTextBoxColumn.Name = "ProdpreciovtaDataGridViewTextBoxColumn"
        '
        'ProdidDataGridViewTextBoxColumn
        '
        Me.ProdidDataGridViewTextBoxColumn.DataPropertyName = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.HeaderText = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.Name = "ProdidDataGridViewTextBoxColumn"
        '
        'ProdxSucstockDataGridViewTextBoxColumn
        '
        Me.ProdxSucstockDataGridViewTextBoxColumn.DataPropertyName = "ProdxSuc_stock"
        Me.ProdxSucstockDataGridViewTextBoxColumn.HeaderText = "ProdxSuc_stock"
        Me.ProdxSucstockDataGridViewTextBoxColumn.Name = "ProdxSucstockDataGridViewTextBoxColumn"
        '
        'ProdxSucptorepoDataGridViewTextBoxColumn
        '
        Me.ProdxSucptorepoDataGridViewTextBoxColumn.DataPropertyName = "ProdxSuc_ptorepo"
        Me.ProdxSucptorepoDataGridViewTextBoxColumn.HeaderText = "ProdxSuc_ptorepo"
        Me.ProdxSucptorepoDataGridViewTextBoxColumn.Name = "ProdxSucptorepoDataGridViewTextBoxColumn"
        '
        'SucursalidDataGridViewTextBoxColumn
        '
        Me.SucursalidDataGridViewTextBoxColumn.DataPropertyName = "sucursal_id"
        Me.SucursalidDataGridViewTextBoxColumn.HeaderText = "sucursal_id"
        Me.SucursalidDataGridViewTextBoxColumn.Name = "SucursalidDataGridViewTextBoxColumn"
        '
        'MarcanomDataGridViewTextBoxColumn
        '
        Me.MarcanomDataGridViewTextBoxColumn.DataPropertyName = "Marca_nom"
        Me.MarcanomDataGridViewTextBoxColumn.HeaderText = "Marca_nom"
        Me.MarcanomDataGridViewTextBoxColumn.Name = "MarcanomDataGridViewTextBoxColumn"
        '
        'ProvnombreDataGridViewTextBoxColumn
        '
        Me.ProvnombreDataGridViewTextBoxColumn.DataPropertyName = "Prov_nombre"
        Me.ProvnombreDataGridViewTextBoxColumn.HeaderText = "Prov_nombre"
        Me.ProvnombreDataGridViewTextBoxColumn.Name = "ProvnombreDataGridViewTextBoxColumn"
        '
        'ProvidDataGridViewTextBoxColumn
        '
        Me.ProvidDataGridViewTextBoxColumn.DataPropertyName = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.HeaderText = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.Name = "ProvidDataGridViewTextBoxColumn"
        '
        'Producto_Reporte_Global
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 626)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximumSize = New System.Drawing.Size(1290, 665)
        Me.MinimumSize = New System.Drawing.Size(1290, 665)
        Me.Name = "Producto_Reporte_Global"
        Me.Text = "Producto_Reporte_Global"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdxSucGLOBALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BO_producto_modificar As System.Windows.Forms.Button
    Friend WithEvents Bo_guardar As System.Windows.Forms.Button
    Friend WithEvents Bo_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_origen As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Producto As System.Windows.Forms.DataGridView
    Friend WithEvents prod_codbarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Tx_Buscqueda As System.Windows.Forms.TextBox
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdpreciovtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdxSucstockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdxSucptorepoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcanomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdxSucGLOBALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Producto_ds As Aplicacion.Producto_ds
End Class
