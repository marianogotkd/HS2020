<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mesas_gestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mesas_gestion))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Mesas_ds = New Aplicacion.Mesas_ds()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BO_Agregar_mesa = New System.Windows.Forms.Button()
        Me.BO_Eliminar_mesa = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BO_abrirmesa = New System.Windows.Forms.Button()
        Me.BO_cargarmesa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VentaprodidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MESAidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MESAnumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoparcialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesasAsignadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mesas_ds1 = New Aplicacion.Mesas_ds()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BO_cancelar = New System.Windows.Forms.Button()
        Me.BO_Modificar = New System.Windows.Forms.Button()
        Me.BO_Nuevo = New System.Windows.Forms.Button()
        Me.BO_Aceptar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RB_Si = New System.Windows.Forms.RadioButton()
        Me.RB_No = New System.Windows.Forms.RadioButton()
        Me.CB_lista = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_buscar_clie = New System.Windows.Forms.TextBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfnacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds = New Aplicacion.Venta_Caja_ds()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RB_Cliente = New System.Windows.Forms.RadioButton()
        Me.RB_Consumidor = New System.Windows.Forms.RadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.RB_CodBarra = New System.Windows.Forms.RadioButton()
        Me.RB_CodInterno = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_busc_codibarra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_cantidad = New System.Windows.Forms.TextBox()
        Me.TX_busc_codinterno = New System.Windows.Forms.TextBox()
        Me.BO_promocion = New System.Windows.Forms.Button()
        Me.BO_buscar = New System.Windows.Forms.Button()
        Me.Quitar = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataG_listaTotal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataG_lista = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciounitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciosubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codbarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoagregadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Mesas_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesasAsignadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mesas_ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataG_listaTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataG_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mesas_ds
        '
        Me.Mesas_ds.DataSetName = "Mesas_ds"
        Me.Mesas_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(876, 557)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(868, 531)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mesa:gestion"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BO_Agregar_mesa)
        Me.GroupBox6.Controls.Add(Me.BO_Eliminar_mesa)
        Me.GroupBox6.Location = New System.Drawing.Point(705, 286)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(134, 152)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Mesas"
        '
        'BO_Agregar_mesa
        '
        Me.BO_Agregar_mesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Agregar_mesa.Location = New System.Drawing.Point(23, 19)
        Me.BO_Agregar_mesa.Name = "BO_Agregar_mesa"
        Me.BO_Agregar_mesa.Size = New System.Drawing.Size(87, 46)
        Me.BO_Agregar_mesa.TabIndex = 3
        Me.BO_Agregar_mesa.Text = "Agregar Mesa nueva"
        Me.BO_Agregar_mesa.UseVisualStyleBackColor = True
        '
        'BO_Eliminar_mesa
        '
        Me.BO_Eliminar_mesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Eliminar_mesa.Location = New System.Drawing.Point(23, 79)
        Me.BO_Eliminar_mesa.Name = "BO_Eliminar_mesa"
        Me.BO_Eliminar_mesa.Size = New System.Drawing.Size(87, 46)
        Me.BO_Eliminar_mesa.TabIndex = 5
        Me.BO_Eliminar_mesa.Text = "Eliminar Mesa"
        Me.BO_Eliminar_mesa.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.BO_abrirmesa)
        Me.GroupBox2.Controls.Add(Me.BO_cargarmesa)
        Me.GroupBox2.Location = New System.Drawing.Point(705, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 241)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(23, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 46)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Liberar Mesa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BO_abrirmesa
        '
        Me.BO_abrirmesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_abrirmesa.Location = New System.Drawing.Point(23, 26)
        Me.BO_abrirmesa.Name = "BO_abrirmesa"
        Me.BO_abrirmesa.Size = New System.Drawing.Size(87, 46)
        Me.BO_abrirmesa.TabIndex = 1
        Me.BO_abrirmesa.Text = "Abrir Mesa"
        Me.BO_abrirmesa.UseVisualStyleBackColor = True
        '
        'BO_cargarmesa
        '
        Me.BO_cargarmesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cargarmesa.Location = New System.Drawing.Point(23, 88)
        Me.BO_cargarmesa.Name = "BO_cargarmesa"
        Me.BO_cargarmesa.Size = New System.Drawing.Size(87, 46)
        Me.BO_cargarmesa.TabIndex = 0
        Me.BO_cargarmesa.Text = "Cargar Mesa"
        Me.BO_cargarmesa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 399)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mesas"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VentaprodidDataGridViewTextBoxColumn, Me.MESAidDataGridViewTextBoxColumn, Me.MESAnumeroDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.PagoparcialDataGridViewTextBoxColumn, Me.ImporteTotalDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MesasAsignadasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 24)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(652, 356)
        Me.DataGridView1.TabIndex = 0
        '
        'VentaprodidDataGridViewTextBoxColumn
        '
        Me.VentaprodidDataGridViewTextBoxColumn.DataPropertyName = "Ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.HeaderText = "Ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.Name = "VentaprodidDataGridViewTextBoxColumn"
        Me.VentaprodidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodidDataGridViewTextBoxColumn.Visible = False
        '
        'MESAidDataGridViewTextBoxColumn
        '
        Me.MESAidDataGridViewTextBoxColumn.DataPropertyName = "MESA_id"
        Me.MESAidDataGridViewTextBoxColumn.HeaderText = "MESA_id"
        Me.MESAidDataGridViewTextBoxColumn.Name = "MESAidDataGridViewTextBoxColumn"
        Me.MESAidDataGridViewTextBoxColumn.ReadOnly = True
        Me.MESAidDataGridViewTextBoxColumn.Visible = False
        '
        'MESAnumeroDataGridViewTextBoxColumn
        '
        Me.MESAnumeroDataGridViewTextBoxColumn.DataPropertyName = "MESA_numero"
        Me.MESAnumeroDataGridViewTextBoxColumn.HeaderText = "Nro mesa"
        Me.MESAnumeroDataGridViewTextBoxColumn.Name = "MESAnumeroDataGridViewTextBoxColumn"
        Me.MESAnumeroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 180
        '
        'PagoparcialDataGridViewTextBoxColumn
        '
        Me.PagoparcialDataGridViewTextBoxColumn.DataPropertyName = "Pago_parcial"
        Me.PagoparcialDataGridViewTextBoxColumn.HeaderText = "Pago parcial"
        Me.PagoparcialDataGridViewTextBoxColumn.Name = "PagoparcialDataGridViewTextBoxColumn"
        Me.PagoparcialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteTotalDataGridViewTextBoxColumn
        '
        Me.ImporteTotalDataGridViewTextBoxColumn.DataPropertyName = "Importe_Total"
        Me.ImporteTotalDataGridViewTextBoxColumn.HeaderText = "Importe Total"
        Me.ImporteTotalDataGridViewTextBoxColumn.Name = "ImporteTotalDataGridViewTextBoxColumn"
        Me.ImporteTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MesasAsignadasBindingSource
        '
        Me.MesasAsignadasBindingSource.DataMember = "MesasAsignadas"
        Me.MesasAsignadasBindingSource.DataSource = Me.Mesas_ds1
        '
        'Mesas_ds1
        '
        Me.Mesas_ds1.DataSetName = "Mesas_ds"
        Me.Mesas_ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BO_cancelar)
        Me.TabPage2.Controls.Add(Me.BO_Modificar)
        Me.TabPage2.Controls.Add(Me.BO_Nuevo)
        Me.TabPage2.Controls.Add(Me.BO_Aceptar)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(868, 531)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mesa:abrir"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BO_cancelar
        '
        Me.BO_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cancelar.Location = New System.Drawing.Point(614, 492)
        Me.BO_cancelar.Name = "BO_cancelar"
        Me.BO_cancelar.Size = New System.Drawing.Size(108, 35)
        Me.BO_cancelar.TabIndex = 256
        Me.BO_cancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.BO_cancelar, "Cancelar")
        Me.BO_cancelar.UseVisualStyleBackColor = True
        '
        'BO_Modificar
        '
        Me.BO_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Modificar.Location = New System.Drawing.Point(497, 492)
        Me.BO_Modificar.Name = "BO_Modificar"
        Me.BO_Modificar.Size = New System.Drawing.Size(111, 35)
        Me.BO_Modificar.TabIndex = 255
        Me.BO_Modificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.BO_Modificar, "Modificar cliente existente")
        Me.BO_Modificar.UseVisualStyleBackColor = True
        '
        'BO_Nuevo
        '
        Me.BO_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Nuevo.Location = New System.Drawing.Point(382, 492)
        Me.BO_Nuevo.Name = "BO_Nuevo"
        Me.BO_Nuevo.Size = New System.Drawing.Size(109, 35)
        Me.BO_Nuevo.TabIndex = 254
        Me.BO_Nuevo.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.BO_Nuevo, "Registrar nuevo cliente")
        Me.BO_Nuevo.UseVisualStyleBackColor = True
        '
        'BO_Aceptar
        '
        Me.BO_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Aceptar.Location = New System.Drawing.Point(268, 492)
        Me.BO_Aceptar.Name = "BO_Aceptar"
        Me.BO_Aceptar.Size = New System.Drawing.Size(108, 35)
        Me.BO_Aceptar.TabIndex = 253
        Me.BO_Aceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.BO_Aceptar, "Abrir mesa")
        Me.BO_Aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RB_Si)
        Me.GroupBox3.Controls.Add(Me.RB_No)
        Me.GroupBox3.Controls.Add(Me.CB_lista)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(217, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 74)
        Me.GroupBox3.TabIndex = 252
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Configurar Lista"
        '
        'RB_Si
        '
        Me.RB_Si.AutoSize = True
        Me.RB_Si.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_Si.Location = New System.Drawing.Point(51, 19)
        Me.RB_Si.Name = "RB_Si"
        Me.RB_Si.Size = New System.Drawing.Size(34, 17)
        Me.RB_Si.TabIndex = 224
        Me.RB_Si.Text = "Si"
        Me.RB_Si.UseVisualStyleBackColor = True
        '
        'RB_No
        '
        Me.RB_No.AutoSize = True
        Me.RB_No.Checked = True
        Me.RB_No.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_No.Location = New System.Drawing.Point(6, 19)
        Me.RB_No.Name = "RB_No"
        Me.RB_No.Size = New System.Drawing.Size(39, 17)
        Me.RB_No.TabIndex = 223
        Me.RB_No.TabStop = True
        Me.RB_No.Text = "No"
        Me.RB_No.UseVisualStyleBackColor = True
        '
        'CB_lista
        '
        Me.CB_lista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_lista.FormattingEnabled = True
        Me.CB_lista.Location = New System.Drawing.Point(6, 44)
        Me.CB_lista.Name = "CB_lista"
        Me.CB_lista.Size = New System.Drawing.Size(209, 21)
        Me.CB_lista.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_buscar_clie)
        Me.GroupBox4.Controls.Add(Me.DG_clientes)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(5, 85)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(858, 401)
        Me.GroupBox4.TabIndex = 251
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar cliente : "
        '
        'Txt_buscar_clie
        '
        Me.Txt_buscar_clie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_buscar_clie.Location = New System.Drawing.Point(9, 21)
        Me.Txt_buscar_clie.Name = "Txt_buscar_clie"
        Me.Txt_buscar_clie.Size = New System.Drawing.Size(843, 26)
        Me.Txt_buscar_clie.TabIndex = 238
        '
        'DG_clientes
        '
        Me.DG_clientes.AllowUserToAddRows = False
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.AutoGenerateColumns = False
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DG_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIidDataGridViewTextBoxColumn, Me.Column1, Me.CLIdniDataGridViewTextBoxColumn, Me.CLIapeDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.CLIfnacDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn})
        Me.DG_clientes.DataSource = Me.ClienteBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_clientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_clientes.Location = New System.Drawing.Point(9, 54)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(843, 341)
        Me.DG_clientes.TabIndex = 237
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 120.0547!
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 35
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "Documento"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIapeDataGridViewTextBoxColumn
        '
        Me.CLIapeDataGridViewTextBoxColumn.DataPropertyName = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.CLIapeDataGridViewTextBoxColumn.Name = "CLIapeDataGridViewTextBoxColumn"
        Me.CLIapeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIapeDataGridViewTextBoxColumn.Width = 150
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Width = 150
        '
        'CLIfnacDataGridViewTextBoxColumn
        '
        Me.CLIfnacDataGridViewTextBoxColumn.DataPropertyName = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento"
        Me.CLIfnacDataGridViewTextBoxColumn.Name = "CLIfnacDataGridViewTextBoxColumn"
        Me.CLIfnacDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIfnacDataGridViewTextBoxColumn.Width = 165
        '
        'CLItelDataGridViewTextBoxColumn
        '
        Me.CLItelDataGridViewTextBoxColumn.DataPropertyName = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.CLItelDataGridViewTextBoxColumn.Name = "CLItelDataGridViewTextBoxColumn"
        Me.CLItelDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLItelDataGridViewTextBoxColumn.Width = 120
        '
        'CLImailDataGridViewTextBoxColumn
        '
        Me.CLImailDataGridViewTextBoxColumn.DataPropertyName = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.CLImailDataGridViewTextBoxColumn.Name = "CLImailDataGridViewTextBoxColumn"
        Me.CLImailDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLImailDataGridViewTextBoxColumn.Width = 120
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'Venta_Caja_ds
        '
        Me.Venta_Caja_ds.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox5.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(152, 74)
        Me.GroupBox5.TabIndex = 250
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de Venta :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RB_Cliente)
        Me.Panel2.Controls.Add(Me.RB_Consumidor)
        Me.Panel2.Location = New System.Drawing.Point(6, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(138, 48)
        Me.Panel2.TabIndex = 234
        '
        'RB_Cliente
        '
        Me.RB_Cliente.AutoSize = True
        Me.RB_Cliente.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_Cliente.Location = New System.Drawing.Point(3, 26)
        Me.RB_Cliente.Name = "RB_Cliente"
        Me.RB_Cliente.Size = New System.Drawing.Size(57, 17)
        Me.RB_Cliente.TabIndex = 223
        Me.RB_Cliente.Text = "Cliente"
        Me.RB_Cliente.UseVisualStyleBackColor = True
        '
        'RB_Consumidor
        '
        Me.RB_Consumidor.AutoSize = True
        Me.RB_Consumidor.Checked = True
        Me.RB_Consumidor.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_Consumidor.Location = New System.Drawing.Point(3, 3)
        Me.RB_Consumidor.Name = "RB_Consumidor"
        Me.RB_Consumidor.Size = New System.Drawing.Size(105, 17)
        Me.RB_Consumidor.TabIndex = 222
        Me.RB_Consumidor.TabStop = True
        Me.RB_Consumidor.Text = "Consumidor Final"
        Me.RB_Consumidor.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(868, 531)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mesa:productos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.GroupBox7)
        Me.GroupBox12.Controls.Add(Me.Label1)
        Me.GroupBox12.Controls.Add(Me.TX_busc_codibarra)
        Me.GroupBox12.Controls.Add(Me.Label3)
        Me.GroupBox12.Controls.Add(Me.Label2)
        Me.GroupBox12.Controls.Add(Me.tx_cantidad)
        Me.GroupBox12.Controls.Add(Me.TX_busc_codinterno)
        Me.GroupBox12.Controls.Add(Me.BO_promocion)
        Me.GroupBox12.Controls.Add(Me.BO_buscar)
        Me.GroupBox12.Controls.Add(Me.Quitar)
        Me.GroupBox12.Controls.Add(Me.Guardar)
        Me.GroupBox12.Controls.Add(Me.Button1)
        Me.GroupBox12.Controls.Add(Me.DataG_listaTotal)
        Me.GroupBox12.Controls.Add(Me.DataG_lista)
        Me.GroupBox12.Enabled = False
        Me.GroupBox12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox12.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(853, 526)
        Me.GroupBox12.TabIndex = 238
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Productos agregados"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RB_CodBarra)
        Me.GroupBox7.Controls.Add(Me.RB_CodInterno)
        Me.GroupBox7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox7.Location = New System.Drawing.Point(621, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(226, 40)
        Me.GroupBox7.TabIndex = 257
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Tipo de búsqueda"
        '
        'RB_CodBarra
        '
        Me.RB_CodBarra.AutoSize = True
        Me.RB_CodBarra.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_CodBarra.Location = New System.Drawing.Point(94, 17)
        Me.RB_CodBarra.Name = "RB_CodBarra"
        Me.RB_CodBarra.Size = New System.Drawing.Size(75, 17)
        Me.RB_CodBarra.TabIndex = 224
        Me.RB_CodBarra.Text = "Cód. Barra"
        Me.RB_CodBarra.UseVisualStyleBackColor = True
        '
        'RB_CodInterno
        '
        Me.RB_CodInterno.AutoSize = True
        Me.RB_CodInterno.Checked = True
        Me.RB_CodInterno.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_CodInterno.Location = New System.Drawing.Point(6, 17)
        Me.RB_CodInterno.Name = "RB_CodInterno"
        Me.RB_CodInterno.Size = New System.Drawing.Size(83, 17)
        Me.RB_CodInterno.TabIndex = 223
        Me.RB_CodInterno.TabStop = True
        Me.RB_CodInterno.Text = "Cód. Interno"
        Me.RB_CodInterno.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 256
        Me.Label1.Text = "Cód. Barra :"
        '
        'TX_busc_codibarra
        '
        Me.TX_busc_codibarra.Enabled = False
        Me.TX_busc_codibarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_busc_codibarra.Location = New System.Drawing.Point(308, 23)
        Me.TX_busc_codibarra.Name = "TX_busc_codibarra"
        Me.TX_busc_codibarra.Size = New System.Drawing.Size(292, 26)
        Me.TX_busc_codibarra.TabIndex = 255
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 254
        Me.Label3.Text = "Cantidad :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 253
        Me.Label2.Text = "Cód. Interno :"
        '
        'tx_cantidad
        '
        Me.tx_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_cantidad.Location = New System.Drawing.Point(99, 60)
        Me.tx_cantidad.Name = "tx_cantidad"
        Me.tx_cantidad.Size = New System.Drawing.Size(113, 26)
        Me.tx_cantidad.TabIndex = 1
        '
        'TX_busc_codinterno
        '
        Me.TX_busc_codinterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_busc_codinterno.Location = New System.Drawing.Point(99, 23)
        Me.TX_busc_codinterno.Name = "TX_busc_codinterno"
        Me.TX_busc_codinterno.Size = New System.Drawing.Size(114, 26)
        Me.TX_busc_codinterno.TabIndex = 0
        '
        'BO_promocion
        '
        Me.BO_promocion.Location = New System.Drawing.Point(782, 206)
        Me.BO_promocion.Name = "BO_promocion"
        Me.BO_promocion.Size = New System.Drawing.Size(67, 47)
        Me.BO_promocion.TabIndex = 7
        Me.BO_promocion.Text = "Busc.promo (F2)"
        Me.ToolTip1.SetToolTip(Me.BO_promocion, "Buscar promoción")
        Me.BO_promocion.UseVisualStyleBackColor = True
        '
        'BO_buscar
        '
        Me.BO_buscar.Location = New System.Drawing.Point(782, 153)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(67, 47)
        Me.BO_buscar.TabIndex = 6
        Me.BO_buscar.Text = "Busc.prod (F1)"
        Me.ToolTip1.SetToolTip(Me.BO_buscar, "Buscar producto")
        Me.BO_buscar.UseVisualStyleBackColor = True
        '
        'Quitar
        '
        Me.Quitar.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Quitar.Location = New System.Drawing.Point(807, 379)
        Me.Quitar.Name = "Quitar"
        Me.Quitar.Size = New System.Drawing.Size(40, 40)
        Me.Quitar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Quitar, "Quitar item")
        Me.Quitar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.Location = New System.Drawing.Point(807, 470)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(40, 40)
        Me.Guardar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Guardar, "Registrar venta")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(807, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Button1, "Cancelar venta")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataG_listaTotal
        '
        Me.DataG_listaTotal.AllowUserToAddRows = False
        Me.DataG_listaTotal.AllowUserToDeleteRows = False
        Me.DataG_listaTotal.BackgroundColor = System.Drawing.Color.White
        Me.DataG_listaTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataG_listaTotal.ColumnHeadersVisible = False
        Me.DataG_listaTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataG_listaTotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataG_listaTotal.Location = New System.Drawing.Point(3, 485)
        Me.DataG_listaTotal.Name = "DataG_listaTotal"
        Me.DataG_listaTotal.ReadOnly = True
        Me.DataG_listaTotal.RowHeadersVisible = False
        Me.DataG_listaTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataG_listaTotal.Size = New System.Drawing.Size(773, 25)
        Me.DataG_listaTotal.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROD_descripcion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 640
        '
        'DataG_lista
        '
        Me.DataG_lista.AllowUserToAddRows = False
        Me.DataG_lista.AllowUserToResizeRows = False
        Me.DataG_lista.AutoGenerateColumns = False
        Me.DataG_lista.BackgroundColor = System.Drawing.Color.White
        Me.DataG_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataG_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.PRODidDataGridViewTextBoxColumn, Me.CodinternoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PreciounitarioDataGridViewTextBoxColumn, Me.PreciosubtotalDataGridViewTextBoxColumn, Me.codbarra})
        Me.DataG_lista.DataSource = Me.ProductoagregadoBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataG_lista.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataG_lista.Location = New System.Drawing.Point(3, 112)
        Me.DataG_lista.MultiSelect = False
        Me.DataG_lista.Name = "DataG_lista"
        Me.DataG_lista.ReadOnly = True
        Me.DataG_lista.RowHeadersVisible = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.DataG_lista.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataG_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataG_lista.Size = New System.Drawing.Size(773, 356)
        Me.DataG_lista.StandardTab = True
        Me.DataG_lista.TabIndex = 0
        '
        'Item
        '
        Me.Item.FillWeight = 106.599!
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 50
        '
        'PRODidDataGridViewTextBoxColumn
        '
        Me.PRODidDataGridViewTextBoxColumn.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.Name = "PRODidDataGridViewTextBoxColumn"
        Me.PRODidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn.Visible = False
        Me.PRODidDataGridViewTextBoxColumn.Width = 91
        '
        'CodinternoDataGridViewTextBoxColumn
        '
        Me.CodinternoDataGridViewTextBoxColumn.DataPropertyName = "codinterno"
        Me.CodinternoDataGridViewTextBoxColumn.HeaderText = "Cód. Interno"
        Me.CodinternoDataGridViewTextBoxColumn.Name = "CodinternoDataGridViewTextBoxColumn"
        Me.CodinternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodinternoDataGridViewTextBoxColumn.Width = 90
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 250
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleDataGridViewTextBoxColumn.Visible = False
        Me.DetalleDataGridViewTextBoxColumn.Width = 90
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciounitarioDataGridViewTextBoxColumn
        '
        Me.PreciounitarioDataGridViewTextBoxColumn.DataPropertyName = "precio_unitario"
        Me.PreciounitarioDataGridViewTextBoxColumn.HeaderText = "Precio U."
        Me.PreciounitarioDataGridViewTextBoxColumn.Name = "PreciounitarioDataGridViewTextBoxColumn"
        Me.PreciounitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciosubtotalDataGridViewTextBoxColumn
        '
        Me.PreciosubtotalDataGridViewTextBoxColumn.DataPropertyName = "precio_subtotal"
        Me.PreciosubtotalDataGridViewTextBoxColumn.HeaderText = "Precio Subtotal"
        Me.PreciosubtotalDataGridViewTextBoxColumn.Name = "PreciosubtotalDataGridViewTextBoxColumn"
        Me.PreciosubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PreciosubtotalDataGridViewTextBoxColumn.Width = 150
        '
        'codbarra
        '
        Me.codbarra.DataPropertyName = "codbarra"
        Me.codbarra.HeaderText = "codbarra"
        Me.codbarra.Name = "codbarra"
        Me.codbarra.ReadOnly = True
        Me.codbarra.Visible = False
        '
        'ProductoagregadoBindingSource
        '
        Me.ProductoagregadoBindingSource.DataMember = "Producto_agregado"
        Me.ProductoagregadoBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'Mesas_gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Mesas_gestion"
        Me.Text = "Mesas_gestion"
        CType(Me.Mesas_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesasAsignadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mesas_ds1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DataG_listaTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataG_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mesas_ds As Aplicacion.Mesas_ds
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_Agregar_mesa As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BO_abrirmesa As System.Windows.Forms.Button
    Friend WithEvents BO_cargarmesa As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MesasAsignadasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mesas_ds1 As Aplicacion.Mesas_ds
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Si As System.Windows.Forms.RadioButton
    Friend WithEvents RB_No As System.Windows.Forms.RadioButton
    Friend WithEvents CB_lista As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_buscar_clie As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RB_Cliente As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Consumidor As System.Windows.Forms.RadioButton
    Friend WithEvents BO_Modificar As System.Windows.Forms.Button
    Friend WithEvents BO_Nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_Aceptar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_Caja_ds As Aplicacion.Venta_Caja_ds
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfnacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BO_Eliminar_mesa As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents VentaprodidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MESAidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MESAnumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagoparcialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BO_cancelar As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_CodBarra As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CodInterno As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TX_busc_codibarra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tx_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents TX_busc_codinterno As System.Windows.Forms.TextBox
    Friend WithEvents BO_promocion As System.Windows.Forms.Button
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents Quitar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataG_listaTotal As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataG_lista As System.Windows.Forms.DataGridView
    Friend WithEvents ProductoagregadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreciounitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreciosubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codbarra As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
