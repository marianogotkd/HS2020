<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_Mercaderia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_Mercaderia))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cb_Movimiento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_destino = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Bo_codbarra = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cb_origen = New System.Windows.Forms.ComboBox()
        Me.btn_Agregar_Prod = New System.Windows.Forms.Button()
        Me.tb_concepto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_eliminar_seleccion = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Prov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MovBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_Movimiento
        '
        Me.cb_Movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Movimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_Movimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Movimiento.FormattingEnabled = True
        Me.cb_Movimiento.ItemHeight = 17
        Me.cb_Movimiento.Items.AddRange(New Object() {"Alta de Mercaderia", "Baja de Mercaderia", "Movimiento Entre Sucursales"})
        Me.cb_Movimiento.Location = New System.Drawing.Point(668, 19)
        Me.cb_Movimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_Movimiento.Name = "cb_Movimiento"
        Me.cb_Movimiento.Size = New System.Drawing.Size(197, 25)
        Me.cb_Movimiento.TabIndex = 0
        Me.cb_Movimiento.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(731, -3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de Movimiento"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Origen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(731, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Destino"
        '
        'cb_destino
        '
        Me.cb_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_destino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_destino.FormattingEnabled = True
        Me.cb_destino.ItemHeight = 17
        Me.cb_destino.Location = New System.Drawing.Point(803, 61)
        Me.cb_destino.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_destino.MaximumSize = New System.Drawing.Size(264, 0)
        Me.cb_destino.MinimumSize = New System.Drawing.Size(264, 0)
        Me.cb_destino.Name = "cb_destino"
        Me.cb_destino.Size = New System.Drawing.Size(264, 25)
        Me.cb_destino.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Concepto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(873, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Lbl_Titulo)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_Movimiento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Bo_codbarra)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cb_origen)
        Me.GroupBox1.Controls.Add(Me.btn_Agregar_Prod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cb_destino)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tb_concepto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 170)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MOVIMIENTOS"
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(396, 16)
        Me.Lbl_Titulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(101, 24)
        Me.Lbl_Titulo.TabIndex = 20
        Me.Lbl_Titulo.Text = "Lbl_Titulo"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button2.Location = New System.Drawing.Point(471, 105)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.MinimumSize = New System.Drawing.Size(124, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 43)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "ir a gestion insumos"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "Ver registro historico de movimientos")
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Bo_codbarra
        '
        Me.Bo_codbarra.Image = CType(resources.GetObject("Bo_codbarra.Image"), System.Drawing.Image)
        Me.Bo_codbarra.Location = New System.Drawing.Point(7, 105)
        Me.Bo_codbarra.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_codbarra.Name = "Bo_codbarra"
        Me.Bo_codbarra.Size = New System.Drawing.Size(149, 43)
        Me.Bo_codbarra.TabIndex = 17
        Me.Bo_codbarra.Text = "Ver Stock Actual"
        Me.Bo_codbarra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_codbarra, "Ver stock en sucursal")
        Me.Bo_codbarra.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(927, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 19)
        Me.DateTimePicker1.TabIndex = 16
        '
        'cb_origen
        '
        Me.cb_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_origen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_origen.FormattingEnabled = True
        Me.cb_origen.ItemHeight = 17
        Me.cb_origen.Location = New System.Drawing.Point(454, 61)
        Me.cb_origen.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_origen.MaximumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.MinimumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.Name = "cb_origen"
        Me.cb_origen.Size = New System.Drawing.Size(265, 25)
        Me.cb_origen.TabIndex = 2
        '
        'btn_Agregar_Prod
        '
        Me.btn_Agregar_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar_Prod.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_Agregar_Prod.Location = New System.Drawing.Point(164, 105)
        Me.btn_Agregar_Prod.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Agregar_Prod.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_Agregar_Prod.Name = "btn_Agregar_Prod"
        Me.btn_Agregar_Prod.Size = New System.Drawing.Size(166, 43)
        Me.btn_Agregar_Prod.TabIndex = 4
        Me.btn_Agregar_Prod.Text = "Agregar Productos"
        Me.btn_Agregar_Prod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Agregar_Prod, "Agregar productos al listado")
        Me.btn_Agregar_Prod.UseVisualStyleBackColor = True
        '
        'tb_concepto
        '
        Me.tb_concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_concepto.Location = New System.Drawing.Point(92, 63)
        Me.tb_concepto.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_concepto.MaximumSize = New System.Drawing.Size(265, 23)
        Me.tb_concepto.MinimumSize = New System.Drawing.Size(265, 23)
        Me.tb_concepto.Name = "tb_concepto"
        Me.tb_concepto.Size = New System.Drawing.Size(265, 23)
        Me.tb_concepto.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button1.Location = New System.Drawing.Point(532, 359)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.MinimumSize = New System.Drawing.Size(124, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Ver registro histórico"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Ver registro historico de movimientos")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(7, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Listado de producto:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btn_limpiar)
        Me.Panel1.Controls.Add(Me.btn_eliminar_seleccion)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Location = New System.Drawing.Point(12, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1074, 408)
        Me.Panel1.TabIndex = 17
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Image = Global.Aplicacion.My.Resources.Resources.Borrar
        Me.btn_limpiar.Location = New System.Drawing.Point(136, 359)
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
        Me.btn_eliminar_seleccion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_eliminar_seleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_seleccion.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_eliminar_seleccion.Location = New System.Drawing.Point(4, 359)
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
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDataGridViewTextBoxColumn, Me.CodprodDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.DesdeDataGridViewTextBoxColumn, Me.HaciaDataGridViewTextBoxColumn, Me.Lote, Me.FechaFabricacion, Me.FechaVencimiento, Me.Vence, Me.Prov_id, Me.Column1})
        Me.DataGridView1.DataSource = Me.MovBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MinimumSize = New System.Drawing.Size(766, 326)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1058, 326)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 16
        '
        'NDataGridViewTextBoxColumn
        '
        Me.NDataGridViewTextBoxColumn.DataPropertyName = "N°"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.NDataGridViewTextBoxColumn.FillWeight = 52.36908!
        Me.NDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.NDataGridViewTextBoxColumn.Name = "NDataGridViewTextBoxColumn"
        Me.NDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodprodDataGridViewTextBoxColumn
        '
        Me.CodprodDataGridViewTextBoxColumn.DataPropertyName = "Cod_prod"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodprodDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CodprodDataGridViewTextBoxColumn.FillWeight = 66.34649!
        Me.CodprodDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodprodDataGridViewTextBoxColumn.Name = "CodprodDataGridViewTextBoxColumn"
        Me.CodprodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DescripcionDataGridViewTextBoxColumn.FillWeight = 301.6104!
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CantidadDataGridViewTextBoxColumn.FillWeight = 69.26241!
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'DesdeDataGridViewTextBoxColumn
        '
        Me.DesdeDataGridViewTextBoxColumn.DataPropertyName = "Desde"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesdeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DesdeDataGridViewTextBoxColumn.FillWeight = 90.58579!
        Me.DesdeDataGridViewTextBoxColumn.HeaderText = "Origen"
        Me.DesdeDataGridViewTextBoxColumn.Name = "DesdeDataGridViewTextBoxColumn"
        Me.DesdeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesdeDataGridViewTextBoxColumn.Visible = False
        '
        'HaciaDataGridViewTextBoxColumn
        '
        Me.HaciaDataGridViewTextBoxColumn.DataPropertyName = "Hacia"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HaciaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.HaciaDataGridViewTextBoxColumn.FillWeight = 93.5929!
        Me.HaciaDataGridViewTextBoxColumn.HeaderText = "Destino"
        Me.HaciaDataGridViewTextBoxColumn.Name = "HaciaDataGridViewTextBoxColumn"
        Me.HaciaDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.FechaFabricacion.DataPropertyName = "FechaFabricacion"
        Me.FechaFabricacion.HeaderText = "Fabricación"
        Me.FechaFabricacion.Name = "FechaFabricacion"
        Me.FechaFabricacion.ReadOnly = True
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimiento.HeaderText = "Vencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.ReadOnly = True
        '
        'Vence
        '
        Me.Vence.DataPropertyName = "Vence"
        Me.Vence.HeaderText = "Vence"
        Me.Vence.Name = "Vence"
        Me.Vence.Visible = False
        '
        'Prov_id
        '
        Me.Prov_id.DataPropertyName = "Prov_id"
        Me.Prov_id.HeaderText = "Prov_id"
        Me.Prov_id.Name = "Prov_id"
        Me.Prov_id.Visible = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 26.23297!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.btn_cancelar.Location = New System.Drawing.Point(268, 359)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.MaximumSize = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_cancelar, "Cancelar Movimiento")
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_guardar.Location = New System.Drawing.Point(400, 359)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.MaximumSize = New System.Drawing.Size(124, 43)
        Me.btn_guardar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(124, 43)
        Me.btn_guardar.TabIndex = 1
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_guardar, "Guardar Movimiento")
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        '
        'Gestion_Mercaderia
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(1098, 602)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Gestion_Mercaderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOVIMIENTO DE STOCK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_Movimiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_destino As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar_Prod As System.Windows.Forms.Button
    Friend WithEvents MovBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Bo_codbarra As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btn_eliminar_seleccion As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents cb_origen As System.Windows.Forms.ComboBox
    Friend WithEvents tb_concepto As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Lbl_Titulo As System.Windows.Forms.Label
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
    Friend WithEvents Prov_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
