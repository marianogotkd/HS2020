<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes_Fijos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes_Fijos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BO_Cargar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DG_cliente = New System.Windows.Forms.DataGridView()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfnacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIobservacionesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.LB_ERROR_cliente = New System.Windows.Forms.Label()
        Me.IM_ERROR_cliente = New System.Windows.Forms.PictureBox()
        Me.BO_ape = New System.Windows.Forms.Button()
        Me.TX_ape = New System.Windows.Forms.TextBox()
        Me.lb_ape_modif = New System.Windows.Forms.Label()
        Me.BO_doc = New System.Windows.Forms.Button()
        Me.TX_doc = New System.Windows.Forms.TextBox()
        Me.lb_dni_modif = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GP_Cliente = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tx_observacion = New System.Windows.Forms.TextBox()
        Me.DT_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BO_Guardar = New System.Windows.Forms.Button()
        Me.Tx_Monto = New System.Windows.Forms.TextBox()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_Pagos = New System.Windows.Forms.DataGridView()
        Me.CliPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliPaCLIIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliPaFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliPaMontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliPa_observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IM_ERROR_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GP_Cliente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_Pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(866, 454)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BO_Cargar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(858, 428)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Cliente: Buscar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BO_Cargar
        '
        Me.BO_Cargar.Image = CType(resources.GetObject("BO_Cargar.Image"), System.Drawing.Image)
        Me.BO_Cargar.Location = New System.Drawing.Point(786, 302)
        Me.BO_Cargar.Name = "BO_Cargar"
        Me.BO_Cargar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Cargar.TabIndex = 0
        Me.BO_Cargar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.LB_ERROR_cliente)
        Me.GroupBox1.Controls.Add(Me.IM_ERROR_cliente)
        Me.GroupBox1.Controls.Add(Me.BO_ape)
        Me.GroupBox1.Controls.Add(Me.TX_ape)
        Me.GroupBox1.Controls.Add(Me.lb_ape_modif)
        Me.GroupBox1.Controls.Add(Me.BO_doc)
        Me.GroupBox1.Controls.Add(Me.TX_doc)
        Me.GroupBox1.Controls.Add(Me.lb_dni_modif)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(774, 346)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DG_cliente)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(33, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(673, 255)
        Me.GroupBox3.TabIndex = 237
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'DG_cliente
        '
        Me.DG_cliente.AllowUserToAddRows = False
        Me.DG_cliente.AllowUserToDeleteRows = False
        Me.DG_cliente.AutoGenerateColumns = False
        Me.DG_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_cliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIidDataGridViewTextBoxColumn, Me.CLIapeDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.CLIfnacDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn, Me.CLIobservacionesDataGridViewTextBoxColumn1})
        Me.DG_cliente.DataSource = Me.ClienteBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_cliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_cliente.Location = New System.Drawing.Point(3, 16)
        Me.DG_cliente.Name = "DG_cliente"
        Me.DG_cliente.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_cliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_cliente.Size = New System.Drawing.Size(667, 236)
        Me.DG_cliente.TabIndex = 7
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'CLIapeDataGridViewTextBoxColumn
        '
        Me.CLIapeDataGridViewTextBoxColumn.DataPropertyName = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.CLIapeDataGridViewTextBoxColumn.Name = "CLIapeDataGridViewTextBoxColumn"
        Me.CLIapeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIfnacDataGridViewTextBoxColumn
        '
        Me.CLIfnacDataGridViewTextBoxColumn.DataPropertyName = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.HeaderText = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.Name = "CLIfnacDataGridViewTextBoxColumn"
        Me.CLIfnacDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIfnacDataGridViewTextBoxColumn.Visible = False
        '
        'CLItelDataGridViewTextBoxColumn
        '
        Me.CLItelDataGridViewTextBoxColumn.DataPropertyName = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.CLItelDataGridViewTextBoxColumn.Name = "CLItelDataGridViewTextBoxColumn"
        Me.CLItelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLImailDataGridViewTextBoxColumn
        '
        Me.CLImailDataGridViewTextBoxColumn.DataPropertyName = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.CLImailDataGridViewTextBoxColumn.Name = "CLImailDataGridViewTextBoxColumn"
        Me.CLImailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIobservacionesDataGridViewTextBoxColumn1
        '
        Me.CLIobservacionesDataGridViewTextBoxColumn1.DataPropertyName = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn1.HeaderText = "Observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn1.Name = "CLIobservacionesDataGridViewTextBoxColumn1"
        Me.CLIobservacionesDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.Cliente_ds
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LB_ERROR_cliente
        '
        Me.LB_ERROR_cliente.AutoSize = True
        Me.LB_ERROR_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR_cliente.ForeColor = System.Drawing.Color.Red
        Me.LB_ERROR_cliente.Location = New System.Drawing.Point(617, 36)
        Me.LB_ERROR_cliente.Name = "LB_ERROR_cliente"
        Me.LB_ERROR_cliente.Size = New System.Drawing.Size(59, 15)
        Me.LB_ERROR_cliente.TabIndex = 236
        Me.LB_ERROR_cliente.Text = "No Existe"
        Me.LB_ERROR_cliente.Visible = False
        '
        'IM_ERROR_cliente
        '
        Me.IM_ERROR_cliente.Image = CType(resources.GetObject("IM_ERROR_cliente.Image"), System.Drawing.Image)
        Me.IM_ERROR_cliente.Location = New System.Drawing.Point(596, 34)
        Me.IM_ERROR_cliente.Name = "IM_ERROR_cliente"
        Me.IM_ERROR_cliente.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR_cliente.TabIndex = 235
        Me.IM_ERROR_cliente.TabStop = False
        Me.IM_ERROR_cliente.Visible = False
        '
        'BO_ape
        '
        Me.BO_ape.Image = CType(resources.GetObject("BO_ape.Image"), System.Drawing.Image)
        Me.BO_ape.Location = New System.Drawing.Point(288, 29)
        Me.BO_ape.Name = "BO_ape"
        Me.BO_ape.Size = New System.Drawing.Size(30, 30)
        Me.BO_ape.TabIndex = 5
        Me.BO_ape.UseVisualStyleBackColor = True
        '
        'TX_ape
        '
        Me.TX_ape.Location = New System.Drawing.Point(145, 34)
        Me.TX_ape.Name = "TX_ape"
        Me.TX_ape.Size = New System.Drawing.Size(124, 20)
        Me.TX_ape.TabIndex = 0
        '
        'lb_ape_modif
        '
        Me.lb_ape_modif.AutoSize = True
        Me.lb_ape_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ape_modif.Location = New System.Drawing.Point(79, 37)
        Me.lb_ape_modif.Name = "lb_ape_modif"
        Me.lb_ape_modif.Size = New System.Drawing.Size(51, 15)
        Me.lb_ape_modif.TabIndex = 3
        Me.lb_ape_modif.Text = "Apellido"
        '
        'BO_doc
        '
        Me.BO_doc.Image = CType(resources.GetObject("BO_doc.Image"), System.Drawing.Image)
        Me.BO_doc.Location = New System.Drawing.Point(560, 28)
        Me.BO_doc.Name = "BO_doc"
        Me.BO_doc.Size = New System.Drawing.Size(30, 30)
        Me.BO_doc.TabIndex = 2
        Me.BO_doc.UseVisualStyleBackColor = True
        '
        'TX_doc
        '
        Me.TX_doc.Location = New System.Drawing.Point(430, 34)
        Me.TX_doc.Name = "TX_doc"
        Me.TX_doc.Size = New System.Drawing.Size(124, 20)
        Me.TX_doc.TabIndex = 1
        '
        'lb_dni_modif
        '
        Me.lb_dni_modif.AutoSize = True
        Me.lb_dni_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni_modif.Location = New System.Drawing.Point(352, 37)
        Me.lb_dni_modif.Name = "lb_dni_modif"
        Me.lb_dni_modif.Size = New System.Drawing.Size(71, 15)
        Me.lb_dni_modif.TabIndex = 0
        Me.lb_dni_modif.Text = "Documento"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GP_Cliente)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 428)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Cliente: Pagos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GP_Cliente
        '
        Me.GP_Cliente.Controls.Add(Me.GroupBox2)
        Me.GP_Cliente.Controls.Add(Me.DG_Pagos)
        Me.GP_Cliente.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Cliente.Location = New System.Drawing.Point(6, 6)
        Me.GP_Cliente.Name = "GP_Cliente"
        Me.GP_Cliente.Size = New System.Drawing.Size(814, 378)
        Me.GP_Cliente.TabIndex = 5
        Me.GP_Cliente.TabStop = False
        Me.GP_Cliente.Text = "Pagos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Tx_observacion)
        Me.GroupBox2.Controls.Add(Me.DT_fecha)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BO_Guardar)
        Me.GroupBox2.Controls.Add(Me.Tx_Monto)
        Me.GroupBox2.Controls.Add(Me.BO_Eliminar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(528, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 227)
        Me.GroupBox2.TabIndex = 244
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nuevo Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 245
        Me.Label3.Text = "Observación"
        '
        'Tx_observacion
        '
        Me.Tx_observacion.Location = New System.Drawing.Point(95, 88)
        Me.Tx_observacion.Name = "Tx_observacion"
        Me.Tx_observacion.Size = New System.Drawing.Size(179, 20)
        Me.Tx_observacion.TabIndex = 244
        '
        'DT_fecha
        '
        Me.DT_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_fecha.Location = New System.Drawing.Point(95, 28)
        Me.DT_fecha.Name = "DT_fecha"
        Me.DT_fecha.Size = New System.Drawing.Size(179, 20)
        Me.DT_fecha.TabIndex = 240
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 243
        Me.Label2.Text = "Monto"
        '
        'BO_Guardar
        '
        Me.BO_Guardar.Image = CType(resources.GetObject("BO_Guardar.Image"), System.Drawing.Image)
        Me.BO_Guardar.Location = New System.Drawing.Point(86, 127)
        Me.BO_Guardar.Name = "BO_Guardar"
        Me.BO_Guardar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Guardar.TabIndex = 4
        Me.BO_Guardar.UseVisualStyleBackColor = True
        '
        'Tx_Monto
        '
        Me.Tx_Monto.Location = New System.Drawing.Point(95, 59)
        Me.Tx_Monto.Name = "Tx_Monto"
        Me.Tx_Monto.Size = New System.Drawing.Size(100, 20)
        Me.Tx_Monto.TabIndex = 242
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(40, 127)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Eliminar.TabIndex = 3
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Fecha de Pago"
        '
        'DG_Pagos
        '
        Me.DG_Pagos.AllowUserToAddRows = False
        Me.DG_Pagos.AllowUserToDeleteRows = False
        Me.DG_Pagos.AutoGenerateColumns = False
        Me.DG_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Pagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CliPaidDataGridViewTextBoxColumn, Me.CliPaCLIIDDataGridViewTextBoxColumn, Me.CliPaFechaDataGridViewTextBoxColumn, Me.CliPaMontoDataGridViewTextBoxColumn, Me.CliPa_observacion})
        Me.DG_Pagos.DataSource = Me.PagosBindingSource
        Me.DG_Pagos.Location = New System.Drawing.Point(6, 19)
        Me.DG_Pagos.Name = "DG_Pagos"
        Me.DG_Pagos.ReadOnly = True
        Me.DG_Pagos.Size = New System.Drawing.Size(516, 341)
        Me.DG_Pagos.TabIndex = 0
        '
        'CliPaidDataGridViewTextBoxColumn
        '
        Me.CliPaidDataGridViewTextBoxColumn.DataPropertyName = "CliPa_id"
        Me.CliPaidDataGridViewTextBoxColumn.HeaderText = "CliPa_id"
        Me.CliPaidDataGridViewTextBoxColumn.Name = "CliPaidDataGridViewTextBoxColumn"
        Me.CliPaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CliPaidDataGridViewTextBoxColumn.Visible = False
        '
        'CliPaCLIIDDataGridViewTextBoxColumn
        '
        Me.CliPaCLIIDDataGridViewTextBoxColumn.DataPropertyName = "CliPa_CLI_ID"
        Me.CliPaCLIIDDataGridViewTextBoxColumn.HeaderText = "CliPa_CLI_ID"
        Me.CliPaCLIIDDataGridViewTextBoxColumn.Name = "CliPaCLIIDDataGridViewTextBoxColumn"
        Me.CliPaCLIIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CliPaCLIIDDataGridViewTextBoxColumn.Visible = False
        '
        'CliPaFechaDataGridViewTextBoxColumn
        '
        Me.CliPaFechaDataGridViewTextBoxColumn.DataPropertyName = "CliPa_Fecha"
        Me.CliPaFechaDataGridViewTextBoxColumn.HeaderText = "Fecha de Pago"
        Me.CliPaFechaDataGridViewTextBoxColumn.Name = "CliPaFechaDataGridViewTextBoxColumn"
        Me.CliPaFechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CliPaFechaDataGridViewTextBoxColumn.Width = 150
        '
        'CliPaMontoDataGridViewTextBoxColumn
        '
        Me.CliPaMontoDataGridViewTextBoxColumn.DataPropertyName = "CliPa_Monto"
        Me.CliPaMontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.CliPaMontoDataGridViewTextBoxColumn.Name = "CliPaMontoDataGridViewTextBoxColumn"
        Me.CliPaMontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CliPa_observacion
        '
        Me.CliPa_observacion.DataPropertyName = "CliPa_observacion"
        Me.CliPa_observacion.HeaderText = "Observación"
        Me.CliPa_observacion.Name = "CliPa_observacion"
        Me.CliPa_observacion.ReadOnly = True
        Me.CliPa_observacion.Width = 210
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.Cliente_ds
        '
        'Clientes_Fijos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Clientes_Fijos"
        Me.Text = "Clientes_Fijos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DG_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IM_ERROR_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GP_Cliente.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_Pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BO_Cargar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents LB_ERROR_cliente As System.Windows.Forms.Label
    Friend WithEvents IM_ERROR_cliente As System.Windows.Forms.PictureBox
    Friend WithEvents BO_ape As System.Windows.Forms.Button
    Friend WithEvents TX_ape As System.Windows.Forms.TextBox
    Friend WithEvents lb_ape_modif As System.Windows.Forms.Label
    Friend WithEvents BO_doc As System.Windows.Forms.Button
    Friend WithEvents TX_doc As System.Windows.Forms.TextBox
    Friend WithEvents lb_dni_modif As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GP_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Pagos As System.Windows.Forms.DataGridView
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_Guardar As System.Windows.Forms.Button
    Friend WithEvents DT_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tx_Monto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PagosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfnacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIobservacionesDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CliPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliPaCLIIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliPaFechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliPaMontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliPa_observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tx_observacion As System.Windows.Forms.TextBox
End Class
