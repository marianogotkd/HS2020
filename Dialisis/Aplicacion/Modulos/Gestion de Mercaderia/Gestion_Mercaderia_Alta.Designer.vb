<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_Mercaderia_Alta
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_Mercaderia_Alta))
        Me.cb_Movimiento = New System.Windows.Forms.ComboBox()
        Me.MovBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox_iva = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_eliminar_seleccion = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFabricacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cb_proveedor = New System.Windows.Forms.ComboBox()
        Me.fecha_remito = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.fecha_factura = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nro_remito = New System.Windows.Forms.TextBox()
        Me.nro_factura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cb_destino = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_origen = New System.Windows.Forms.TextBox()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.tb_cant_Or = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bo_codbarra = New System.Windows.Forms.Button()
        Me.tb_desc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_codint = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Grupo_lote = New System.Windows.Forms.GroupBox()
        Me.CheckBox_vto = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker_fvencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker_ffabricacion = New System.Windows.Forms.DateTimePicker()
        Me.txt_nrolote = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tb_precioU = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tb_Cant_Movi = New System.Windows.Forms.TextBox()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.btn_agregarr = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_Agregar_Prod = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cb_origen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_concepto = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.MovBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Grupo_lote.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.cb_Movimiento.Location = New System.Drawing.Point(770, 30)
        Me.cb_Movimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_Movimiento.Name = "cb_Movimiento"
        Me.cb_Movimiento.Size = New System.Drawing.Size(197, 25)
        Me.cb_Movimiento.TabIndex = 0
        Me.cb_Movimiento.Visible = False
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ComboBox_iva)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txt_total)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.btn_limpiar)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_eliminar_seleccion)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Location = New System.Drawing.Point(12, 424)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1074, 247)
        Me.Panel1.TabIndex = 19
        '
        'ComboBox_iva
        '
        Me.ComboBox_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_iva.FormattingEnabled = True
        Me.ComboBox_iva.Items.AddRange(New Object() {"0", "10,5", "21"})
        Me.ComboBox_iva.Location = New System.Drawing.Point(889, 168)
        Me.ComboBox_iva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox_iva.Name = "ComboBox_iva"
        Me.ComboBox_iva.Size = New System.Drawing.Size(178, 28)
        Me.ComboBox_iva.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(775, 171)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 25)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "IVA"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.White
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(889, 205)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(178, 30)
        Me.txt_total.TabIndex = 20
        Me.txt_total.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(775, 208)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 25)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "TOTAL $: "
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Image = Global.Aplicacion.My.Resources.Resources.Borrar
        Me.btn_limpiar.Location = New System.Drawing.Point(140, 193)
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button1.Location = New System.Drawing.Point(536, 193)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.MinimumSize = New System.Drawing.Size(124, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Ver registro histórico"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Ver registro historico de movimientos")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_eliminar_seleccion
        '
        Me.btn_eliminar_seleccion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_eliminar_seleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_seleccion.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_eliminar_seleccion.Location = New System.Drawing.Point(8, 193)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDataGridViewTextBoxColumn, Me.CodprodDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.DesdeDataGridViewTextBoxColumn, Me.HaciaDataGridViewTextBoxColumn, Me.Lote, Me.PrecioU, Me.Subtotal, Me.FechaFabricacion, Me.FechaVencimiento, Me.Vence, Me.Column1})
        Me.DataGridView1.DataSource = Me.MovBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1058, 137)
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
        'PrecioU
        '
        Me.PrecioU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PrecioU.DataPropertyName = "PrecioU"
        Me.PrecioU.HeaderText = "Precio U."
        Me.PrecioU.Name = "PrecioU"
        Me.PrecioU.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Subtotal.DataPropertyName = "Subtotal"
        Me.Subtotal.HeaderText = "Sub total"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
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
        'Column1
        '
        Me.Column1.FillWeight = 26.23297!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.btn_cancelar.Location = New System.Drawing.Point(272, 193)
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
        Me.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_guardar.Location = New System.Drawing.Point(404, 193)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cb_origen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tb_concepto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 412)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MOVIMIENTOS"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.cb_proveedor)
        Me.GroupBox6.Controls.Add(Me.fecha_remito)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.cb_Movimiento)
        Me.GroupBox6.Controls.Add(Me.fecha_factura)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.nro_remito)
        Me.GroupBox6.Controls.Add(Me.nro_factura)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.cb_destino)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 48)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1057, 96)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Información del Ingreso"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 25)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Proveedor"
        '
        'cb_proveedor
        '
        Me.cb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_proveedor.FormattingEnabled = True
        Me.cb_proveedor.ItemHeight = 17
        Me.cb_proveedor.Items.AddRange(New Object() {"Alta de Mercaderia", "Baja de Mercaderia", "Movimiento Entre Sucursales"})
        Me.cb_proveedor.Location = New System.Drawing.Point(71, 19)
        Me.cb_proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_proveedor.Name = "cb_proveedor"
        Me.cb_proveedor.Size = New System.Drawing.Size(341, 25)
        Me.cb_proveedor.TabIndex = 21
        '
        'fecha_remito
        '
        Me.fecha_remito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_remito.Location = New System.Drawing.Point(696, 68)
        Me.fecha_remito.Name = "fecha_remito"
        Me.fecha_remito.Size = New System.Drawing.Size(104, 19)
        Me.fecha_remito.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(598, 70)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Fecha de Remito:"
        '
        'fecha_factura
        '
        Me.fecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_factura.Location = New System.Drawing.Point(290, 68)
        Me.fecha_factura.Name = "fecha_factura"
        Me.fecha_factura.Size = New System.Drawing.Size(104, 19)
        Me.fecha_factura.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(192, 70)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Fecha de Factura:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 70)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Nro de Factura:"
        '
        'nro_remito
        '
        Me.nro_remito.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nro_remito.Location = New System.Drawing.Point(497, 68)
        Me.nro_remito.Margin = New System.Windows.Forms.Padding(4)
        Me.nro_remito.Name = "nro_remito"
        Me.nro_remito.Size = New System.Drawing.Size(93, 19)
        Me.nro_remito.TabIndex = 28
        Me.nro_remito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.nro_remito, "Ingrese codigo para buscar")
        '
        'nro_factura
        '
        Me.nro_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nro_factura.Location = New System.Drawing.Point(93, 68)
        Me.nro_factura.Margin = New System.Windows.Forms.Padding(4)
        Me.nro_factura.Name = "nro_factura"
        Me.nro_factura.Size = New System.Drawing.Size(93, 19)
        Me.nro_factura.TabIndex = 24
        Me.nro_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.nro_factura, "Ingrese codigo para buscar")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(676, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Destino"
        Me.Label3.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(411, 70)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Nro de Remito:"
        '
        'cb_destino
        '
        Me.cb_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_destino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_destino.FormattingEnabled = True
        Me.cb_destino.ItemHeight = 17
        Me.cb_destino.Location = New System.Drawing.Point(770, 13)
        Me.cb_destino.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_destino.MaximumSize = New System.Drawing.Size(264, 0)
        Me.cb_destino.MinimumSize = New System.Drawing.Size(264, 0)
        Me.cb_destino.Name = "cb_destino"
        Me.cb_destino.Size = New System.Drawing.Size(264, 25)
        Me.cb_destino.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.tb_origen)
        Me.GroupBox3.Controls.Add(Me.Button_buscar)
        Me.GroupBox3.Controls.Add(Me.tb_cant_Or)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Bo_codbarra)
        Me.GroupBox3.Controls.Add(Me.tb_desc)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.tb_codint)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1057, 85)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar producto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 62)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sucursal:"
        Me.Label9.Visible = False
        '
        'tb_origen
        '
        Me.tb_origen.BackColor = System.Drawing.Color.White
        Me.tb_origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_origen.Location = New System.Drawing.Point(101, 51)
        Me.tb_origen.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_origen.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_origen.MinimumSize = New System.Drawing.Size(250, 22)
        Me.tb_origen.Name = "tb_origen"
        Me.tb_origen.ReadOnly = True
        Me.tb_origen.Size = New System.Drawing.Size(250, 19)
        Me.tb_origen.TabIndex = 0
        Me.tb_origen.TabStop = False
        Me.tb_origen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_origen.Visible = False
        '
        'Button_buscar
        '
        Me.Button_buscar.Image = CType(resources.GetObject("Button_buscar.Image"), System.Drawing.Image)
        Me.Button_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_buscar.Location = New System.Drawing.Point(223, 15)
        Me.Button_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(131, 30)
        Me.Button_buscar.TabIndex = 258
        Me.Button_buscar.Text = "Buscar Producto"
        Me.Button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_buscar, "Busqueda avanzada")
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'tb_cant_Or
        '
        Me.tb_cant_Or.BackColor = System.Drawing.Color.White
        Me.tb_cant_Or.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cant_Or.Location = New System.Drawing.Point(489, 46)
        Me.tb_cant_Or.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_cant_Or.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_cant_Or.Name = "tb_cant_Or"
        Me.tb_cant_Or.ReadOnly = True
        Me.tb_cant_Or.Size = New System.Drawing.Size(250, 22)
        Me.tb_cant_Or.TabIndex = 1
        Me.tb_cant_Or.TabStop = False
        Me.tb_cant_Or.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Código Interno:"
        '
        'Bo_codbarra
        '
        Me.Bo_codbarra.Image = Global.Aplicacion.My.Resources.Resources.search_balance
        Me.Bo_codbarra.Location = New System.Drawing.Point(822, 9)
        Me.Bo_codbarra.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_codbarra.Name = "Bo_codbarra"
        Me.Bo_codbarra.Size = New System.Drawing.Size(181, 66)
        Me.Bo_codbarra.TabIndex = 17
        Me.Bo_codbarra.Text = "Ver Stock Actual"
        Me.Bo_codbarra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_codbarra, "Ver stock en sucursal")
        Me.Bo_codbarra.UseVisualStyleBackColor = True
        '
        'tb_desc
        '
        Me.tb_desc.BackColor = System.Drawing.Color.White
        Me.tb_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_desc.Location = New System.Drawing.Point(489, 16)
        Me.tb_desc.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.ReadOnly = True
        Me.tb_desc.Size = New System.Drawing.Size(250, 22)
        Me.tb_desc.TabIndex = 1
        Me.tb_desc.TabStop = False
        Me.tb_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(384, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Cantidad existente:"
        '
        'tb_codint
        '
        Me.tb_codint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codint.Location = New System.Drawing.Point(101, 21)
        Me.tb_codint.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_codint.Name = "tb_codint"
        Me.tb_codint.Size = New System.Drawing.Size(92, 22)
        Me.tb_codint.TabIndex = 0
        Me.tb_codint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tb_codint, "Ingrese codigo para buscar")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(384, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Descripción:"
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
        'GroupBox4
        '
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Grupo_lote)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.btn_agregarr)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.btn_Agregar_Prod)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(10, 241)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1057, 163)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingresar Informacion"
        '
        'Grupo_lote
        '
        Me.Grupo_lote.BackColor = System.Drawing.Color.Transparent
        Me.Grupo_lote.Controls.Add(Me.CheckBox_vto)
        Me.Grupo_lote.Controls.Add(Me.DateTimePicker_fvencimiento)
        Me.Grupo_lote.Controls.Add(Me.Label11)
        Me.Grupo_lote.Controls.Add(Me.DateTimePicker_ffabricacion)
        Me.Grupo_lote.Controls.Add(Me.txt_nrolote)
        Me.Grupo_lote.Controls.Add(Me.Label12)
        Me.Grupo_lote.Controls.Add(Me.Label13)
        Me.Grupo_lote.Enabled = False
        Me.Grupo_lote.Location = New System.Drawing.Point(6, 18)
        Me.Grupo_lote.Name = "Grupo_lote"
        Me.Grupo_lote.Size = New System.Drawing.Size(348, 127)
        Me.Grupo_lote.TabIndex = 20
        Me.Grupo_lote.TabStop = False
        '
        'CheckBox_vto
        '
        Me.CheckBox_vto.AutoSize = True
        Me.CheckBox_vto.Location = New System.Drawing.Point(197, 15)
        Me.CheckBox_vto.Name = "CheckBox_vto"
        Me.CheckBox_vto.Size = New System.Drawing.Size(146, 17)
        Me.CheckBox_vto.TabIndex = 240
        Me.CheckBox_vto.Text = "Habilitar Vencimiento"
        Me.CheckBox_vto.UseVisualStyleBackColor = True
        '
        'DateTimePicker_fvencimiento
        '
        Me.DateTimePicker_fvencimiento.Enabled = False
        Me.DateTimePicker_fvencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_fvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_fvencimiento.Location = New System.Drawing.Point(126, 90)
        Me.DateTimePicker_fvencimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_fvencimiento.Name = "DateTimePicker_fvencimiento"
        Me.DateTimePicker_fvencimiento.Size = New System.Drawing.Size(107, 22)
        Me.DateTimePicker_fvencimiento.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DateTimePicker_fvencimiento, "Seleccione fecha de pedido")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 65)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "F. Fabricación:"
        '
        'DateTimePicker_ffabricacion
        '
        Me.DateTimePicker_ffabricacion.Enabled = False
        Me.DateTimePicker_ffabricacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_ffabricacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_ffabricacion.Location = New System.Drawing.Point(122, 60)
        Me.DateTimePicker_ffabricacion.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_ffabricacion.Name = "DateTimePicker_ffabricacion"
        Me.DateTimePicker_ffabricacion.Size = New System.Drawing.Size(107, 22)
        Me.DateTimePicker_ffabricacion.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.DateTimePicker_ffabricacion, "Seleccione fecha de pedido")
        '
        'txt_nrolote
        '
        Me.txt_nrolote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nrolote.Location = New System.Drawing.Point(78, 13)
        Me.txt_nrolote.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nrolote.MinimumSize = New System.Drawing.Size(90, 30)
        Me.txt_nrolote.Name = "txt_nrolote"
        Me.txt_nrolote.Size = New System.Drawing.Size(112, 26)
        Me.txt_nrolote.TabIndex = 0
        Me.txt_nrolote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 20)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Lote Nº:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 94)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "F. Vencimiento:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox5.Controls.Add(Me.tb_precioU)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.tb_Cant_Movi)
        Me.GroupBox5.Controls.Add(Me.lbl_cant)
        Me.GroupBox5.Location = New System.Drawing.Point(360, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(454, 125)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        '
        'tb_precioU
        '
        Me.tb_precioU.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_precioU.Location = New System.Drawing.Point(161, 61)
        Me.tb_precioU.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_precioU.MaxLength = 50
        Me.tb_precioU.Name = "tb_precioU"
        Me.tb_precioU.Size = New System.Drawing.Size(168, 29)
        Me.tb_precioU.TabIndex = 22
        Me.tb_precioU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 74)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Precio Unitario $:"
        '
        'tb_Cant_Movi
        '
        Me.tb_Cant_Movi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Cant_Movi.Location = New System.Drawing.Point(161, 18)
        Me.tb_Cant_Movi.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Cant_Movi.MaxLength = 50
        Me.tb_Cant_Movi.Name = "tb_Cant_Movi"
        Me.tb_Cant_Movi.Size = New System.Drawing.Size(168, 29)
        Me.tb_Cant_Movi.TabIndex = 0
        Me.tb_Cant_Movi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant.Location = New System.Drawing.Point(17, 27)
        Me.lbl_cant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(137, 15)
        Me.lbl_cant.TabIndex = 13
        Me.lbl_cant.Text = "Cantidad a ingresar:"
        '
        'btn_agregarr
        '
        Me.btn_agregarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarr.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_agregarr.Location = New System.Drawing.Point(822, 40)
        Me.btn_agregarr.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregarr.Name = "btn_agregarr"
        Me.btn_agregarr.Size = New System.Drawing.Size(181, 69)
        Me.btn_agregarr.TabIndex = 249
        Me.btn_agregarr.Text = "Agregar"
        Me.btn_agregarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_agregarr, "Agregar a la lista")
        Me.btn_agregarr.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button2.Location = New System.Drawing.Point(933, 81)
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
        'btn_Agregar_Prod
        '
        Me.btn_Agregar_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar_Prod.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_Agregar_Prod.Location = New System.Drawing.Point(933, 38)
        Me.btn_Agregar_Prod.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Agregar_Prod.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_Agregar_Prod.Name = "btn_Agregar_Prod"
        Me.btn_Agregar_Prod.Size = New System.Drawing.Size(124, 43)
        Me.btn_Agregar_Prod.TabIndex = 4
        Me.btn_Agregar_Prod.Text = "Agregar Productos"
        Me.btn_Agregar_Prod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Agregar_Prod, "Agregar productos al listado")
        Me.btn_Agregar_Prod.UseVisualStyleBackColor = True
        Me.btn_Agregar_Prod.Visible = False
        '
        'DateTimePicker1
        '
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
        Me.cb_origen.Location = New System.Drawing.Point(430, 16)
        Me.cb_origen.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_origen.MaximumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.MinimumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.Name = "cb_origen"
        Me.cb_origen.Size = New System.Drawing.Size(265, 25)
        Me.cb_origen.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Destino"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Concepto"
        '
        'tb_concepto
        '
        Me.tb_concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_concepto.Location = New System.Drawing.Point(93, 18)
        Me.tb_concepto.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_concepto.MaximumSize = New System.Drawing.Size(265, 23)
        Me.tb_concepto.MinimumSize = New System.Drawing.Size(265, 23)
        Me.tb_concepto.Name = "tb_concepto"
        Me.tb_concepto.Size = New System.Drawing.Size(265, 23)
        Me.tb_concepto.TabIndex = 1
        '
        'Gestion_Mercaderia_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gestion_Mercaderia_Alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INGRESO DE STOCK EN DEPOSITO"
        CType(Me.MovBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Grupo_lote.ResumeLayout(False)
        Me.Grupo_lote.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_Movimiento As System.Windows.Forms.ComboBox
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MovBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_eliminar_seleccion As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Bo_codbarra As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_origen As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Agregar_Prod As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_destino As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_concepto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_codint As System.Windows.Forms.TextBox
    Friend WithEvents tb_desc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_origen As System.Windows.Forms.TextBox
    Friend WithEvents tb_cant_Or As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_vto As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker_fvencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_ffabricacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nrolote As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents fecha_remito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents nro_remito As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha_factura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents nro_factura As System.Windows.Forms.TextBox
    Friend WithEvents tb_precioU As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_agregarr As System.Windows.Forms.Button
    Friend WithEvents tb_Cant_Movi As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents NDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFabricacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Grupo_lote As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_iva As System.Windows.Forms.ComboBox
End Class
