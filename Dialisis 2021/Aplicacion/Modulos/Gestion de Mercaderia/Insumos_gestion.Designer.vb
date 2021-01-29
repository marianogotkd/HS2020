<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insumos_gestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Insumos_gestion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_eliminar_seleccion = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MovBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Bo_codbarra = New System.Windows.Forms.Button()
        Me.btn_Agregar_Prod = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_concepto = New System.Windows.Forms.TextBox()
        Me.cb_origen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFabricacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Prov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Bo_codbarra)
        Me.GroupBox1.Controls.Add(Me.btn_Agregar_Prod)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tb_concepto)
        Me.GroupBox1.Controls.Add(Me.cb_origen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1112, 599)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar productos consumidos"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button1.Location = New System.Drawing.Point(300, 122)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.MinimumSize = New System.Drawing.Size(124, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 43)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Ver registro histórico"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Ver registro histórico de consumos")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_limpiar)
        Me.Panel1.Controls.Add(Me.btn_eliminar_seleccion)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Location = New System.Drawing.Point(17, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1074, 408)
        Me.Panel1.TabIndex = 25
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Image = Global.Aplicacion.My.Resources.Resources.Borrar
        Me.btn_limpiar.Location = New System.Drawing.Point(412, 359)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_limpiar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(124, 43)
        Me.btn_limpiar.TabIndex = 18
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_limpiar, "Limpiar listado de productos")
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_eliminar_seleccion
        '
        Me.btn_eliminar_seleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_seleccion.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_eliminar_seleccion.Location = New System.Drawing.Point(280, 359)
        Me.btn_eliminar_seleccion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar_seleccion.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_eliminar_seleccion.Name = "btn_eliminar_seleccion"
        Me.btn_eliminar_seleccion.Size = New System.Drawing.Size(124, 43)
        Me.btn_eliminar_seleccion.TabIndex = 17
        Me.btn_eliminar_seleccion.Text = "Eliminar"
        Me.btn_eliminar_seleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_eliminar_seleccion, "Eliminar productos seleccionados")
        Me.btn_eliminar_seleccion.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDataGridViewTextBoxColumn, Me.CodprodDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.DesdeDataGridViewTextBoxColumn, Me.HaciaDataGridViewTextBoxColumn, Me.Lote, Me.FechaFabricacion, Me.FechaVencimiento, Me.Vence, Me.Column1, Me.Prov_id})
        Me.DataGridView1.DataSource = Me.MovBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MinimumSize = New System.Drawing.Size(766, 326)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1058, 326)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 16
        '
        'MovBindingSource
        '
        Me.MovBindingSource.DataMember = "Mov"
        Me.MovBindingSource.DataSource = Me.Mov_DS
        '
        'Mov_DS
        '
        Me.Mov_DS.DataSetName = "Mov_DS"
        Me.Mov_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(7, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Listado de producto que se consumirán:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.btn_cancelar.Location = New System.Drawing.Point(544, 359)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.MaximumSize = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_cancelar, "Cancelar consumos")
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_guardar.Location = New System.Drawing.Point(676, 359)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.MaximumSize = New System.Drawing.Size(124, 43)
        Me.btn_guardar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(124, 43)
        Me.btn_guardar.TabIndex = 1
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_guardar, "Registrar consumos")
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Bo_codbarra
        '
        Me.Bo_codbarra.Image = CType(resources.GetObject("Bo_codbarra.Image"), System.Drawing.Image)
        Me.Bo_codbarra.Location = New System.Drawing.Point(17, 122)
        Me.Bo_codbarra.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_codbarra.Name = "Bo_codbarra"
        Me.Bo_codbarra.Size = New System.Drawing.Size(94, 43)
        Me.Bo_codbarra.TabIndex = 24
        Me.Bo_codbarra.Text = "Ver Stock"
        Me.Bo_codbarra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_codbarra, "Ver stock en sucursal")
        Me.Bo_codbarra.UseVisualStyleBackColor = True
        '
        'btn_Agregar_Prod
        '
        Me.btn_Agregar_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar_Prod.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_Agregar_Prod.Location = New System.Drawing.Point(123, 122)
        Me.btn_Agregar_Prod.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Agregar_Prod.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_Agregar_Prod.Name = "btn_Agregar_Prod"
        Me.btn_Agregar_Prod.Size = New System.Drawing.Size(169, 43)
        Me.btn_Agregar_Prod.TabIndex = 23
        Me.btn_Agregar_Prod.Text = "Agregar Productos"
        Me.btn_Agregar_Prod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Agregar_Prod, "Agregar productos al listado")
        Me.btn_Agregar_Prod.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Concepto:"
        '
        'tb_concepto
        '
        Me.tb_concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_concepto.Location = New System.Drawing.Point(115, 80)
        Me.tb_concepto.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_concepto.MaximumSize = New System.Drawing.Size(265, 23)
        Me.tb_concepto.MinimumSize = New System.Drawing.Size(265, 23)
        Me.tb_concepto.Name = "tb_concepto"
        Me.tb_concepto.Size = New System.Drawing.Size(265, 23)
        Me.tb_concepto.TabIndex = 21
        '
        'cb_origen
        '
        Me.cb_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_origen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_origen.FormattingEnabled = True
        Me.cb_origen.ItemHeight = 17
        Me.cb_origen.Location = New System.Drawing.Point(115, 30)
        Me.cb_origen.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_origen.MaximumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.MinimumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.Name = "cb_origen"
        Me.cb_origen.Size = New System.Drawing.Size(265, 25)
        Me.cb_origen.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Sucursal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(890, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(944, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'NDataGridViewTextBoxColumn
        '
        Me.NDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NDataGridViewTextBoxColumn.DataPropertyName = "N°"
        Me.NDataGridViewTextBoxColumn.FillWeight = 79.84757!
        Me.NDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.NDataGridViewTextBoxColumn.Name = "NDataGridViewTextBoxColumn"
        Me.NDataGridViewTextBoxColumn.ReadOnly = True
        Me.NDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NDataGridViewTextBoxColumn.Width = 50
        '
        'CodprodDataGridViewTextBoxColumn
        '
        Me.CodprodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodprodDataGridViewTextBoxColumn.DataPropertyName = "Cod_prod"
        Me.CodprodDataGridViewTextBoxColumn.FillWeight = 191.2844!
        Me.CodprodDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodprodDataGridViewTextBoxColumn.Name = "CodprodDataGridViewTextBoxColumn"
        Me.CodprodDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodprodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CodprodDataGridViewTextBoxColumn.Width = 98
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.FillWeight = 852.7611!
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.FillWeight = 11.04902!
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CantidadDataGridViewTextBoxColumn.Width = 103
        '
        'DesdeDataGridViewTextBoxColumn
        '
        Me.DesdeDataGridViewTextBoxColumn.DataPropertyName = "Desde"
        Me.DesdeDataGridViewTextBoxColumn.FillWeight = 11.04902!
        Me.DesdeDataGridViewTextBoxColumn.HeaderText = "Origen"
        Me.DesdeDataGridViewTextBoxColumn.Name = "DesdeDataGridViewTextBoxColumn"
        Me.DesdeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DesdeDataGridViewTextBoxColumn.Visible = False
        '
        'HaciaDataGridViewTextBoxColumn
        '
        Me.HaciaDataGridViewTextBoxColumn.DataPropertyName = "Hacia"
        Me.HaciaDataGridViewTextBoxColumn.FillWeight = 11.04902!
        Me.HaciaDataGridViewTextBoxColumn.HeaderText = "Destino"
        Me.HaciaDataGridViewTextBoxColumn.Name = "HaciaDataGridViewTextBoxColumn"
        Me.HaciaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HaciaDataGridViewTextBoxColumn.Visible = False
        '
        'Lote
        '
        Me.Lote.DataPropertyName = "Lote"
        Me.Lote.HeaderText = "Lote"
        Me.Lote.Name = "Lote"
        Me.Lote.ReadOnly = True
        Me.Lote.Visible = False
        '
        'FechaFabricacion
        '
        Me.FechaFabricacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FechaFabricacion.DataPropertyName = "FechaFabricacion"
        Me.FechaFabricacion.FillWeight = 11.04902!
        Me.FechaFabricacion.HeaderText = "Fabricación"
        Me.FechaFabricacion.Name = "FechaFabricacion"
        Me.FechaFabricacion.ReadOnly = True
        Me.FechaFabricacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FechaFabricacion.Width = 147
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FechaVencimiento.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimiento.FillWeight = 11.04902!
        Me.FechaVencimiento.HeaderText = "Vencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.ReadOnly = True
        Me.FechaVencimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FechaVencimiento.Width = 147
        '
        'Vence
        '
        Me.Vence.DataPropertyName = "Vence"
        Me.Vence.HeaderText = "Vence"
        Me.Vence.Name = "Vence"
        Me.Vence.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.FillWeight = 2.898487!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 50
        '
        'Prov_id
        '
        Me.Prov_id.DataPropertyName = "Prov_id"
        Me.Prov_id.HeaderText = "Prov_id"
        Me.Prov_id.Name = "Prov_id"
        Me.Prov_id.Visible = False
        '
        'Insumos_gestion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(1119, 611)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Insumos_gestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Insumos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_origen As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_concepto As System.Windows.Forms.TextBox
    Friend WithEvents Bo_codbarra As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar_Prod As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar_seleccion As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents MovBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFabricacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Prov_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
