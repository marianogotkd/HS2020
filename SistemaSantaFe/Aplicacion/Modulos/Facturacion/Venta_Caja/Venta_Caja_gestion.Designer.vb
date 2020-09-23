<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta_Caja_gestion
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
        Dim DataGridViewCellStyle100 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle102 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle101 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta_Caja_gestion))
        Dim DataGridViewCellStyle109 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle110 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle103 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle104 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle105 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle106 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle107 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle108 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Venta_ds = New Aplicacion.Venta_ds()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.label_hora = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label_fecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_Si = New System.Windows.Forms.RadioButton()
        Me.RB_No = New System.Windows.Forms.RadioButton()
        Me.CB_lista = New System.Windows.Forms.ComboBox()
        Me.BO_Modificar = New System.Windows.Forms.Button()
        Me.BO_Nuevo = New System.Windows.Forms.Button()
        Me.BO_Aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Busqueda = New System.Windows.Forms.TextBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIFanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfnacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIobservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds = New Aplicacion.Venta_Caja_ds()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RB_Cliente = New System.Windows.Forms.RadioButton()
        Me.RB_Consumidor = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_impuesto_aplicado = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_iva = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox_pagar = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.DataG_listaTotal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt_desc_pesos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_desc_porc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label_remito = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ComboBox_vendedor = New System.Windows.Forms.ComboBox()
        Me.Btn_Vendedor_buscar = New System.Windows.Forms.Button()
        Me.txt_vendedor_codigo = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Btn_facturacion = New System.Windows.Forms.Button()
        Me.lb_tipo_vta = New System.Windows.Forms.Label()
        Me.lb_vendedor_vta = New System.Windows.Forms.Label()
        Me.lb_fecha_vta = New System.Windows.Forms.Label()
        Me.lb_factura_vta = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.label_limite = New System.Windows.Forms.Label()
        Me.Label_saldo = New System.Windows.Forms.Label()
        Me.Label_ctacte = New System.Windows.Forms.Label()
        Me.lb_tipoIVA_clie = New System.Windows.Forms.Label()
        Me.lb_mail_clie = New System.Windows.Forms.Label()
        Me.lb_telef_clie = New System.Windows.Forms.Label()
        Me.lb_dni_clie = New System.Windows.Forms.Label()
        Me.lb_fantasia = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lb_mail_sucursal = New System.Windows.Forms.Label()
        Me.lb_telefono_sucursal = New System.Windows.Forms.Label()
        Me.lb_direccion_sucursal = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_nombre_sucursal = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_tipo_vta = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Quitar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.columna_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna_prod_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna_codinterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna_detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna_precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna_precio_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna_codbarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductoagregadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProductosCombosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Venta_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox_pagar.SuspendLayout()
        CType(Me.DataG_listaTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosCombosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Venta_ds
        '
        Me.Venta_ds.DataSetName = "Venta_ds"
        Me.Venta_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Venta_ds
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1261, 672)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.label_hora)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.label_fecha)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.BO_Modificar)
        Me.TabPage1.Controls.Add(Me.BO_Nuevo)
        Me.TabPage1.Controls.Add(Me.BO_Aceptar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPage1.Size = New System.Drawing.Size(1253, 634)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Venta en Caja: Cliente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button4.Location = New System.Drawing.Point(1134, 16)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 43)
        Me.Button4.TabIndex = 254
        Me.Button4.Text = "Volver"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button4, "Volver a seleccion de tipo")
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'label_hora
        '
        Me.label_hora.AutoSize = True
        Me.label_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_hora.Location = New System.Drawing.Point(744, 59)
        Me.label_hora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_hora.Name = "label_hora"
        Me.label_hora.Size = New System.Drawing.Size(78, 36)
        Me.label_hora.TabIndex = 253
        Me.label_hora.Text = "label"
        Me.label_hora.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(650, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 36)
        Me.Label3.TabIndex = 252
        Me.Label3.Text = "Hora:"
        Me.Label3.Visible = False
        '
        'label_fecha
        '
        Me.label_fecha.AutoSize = True
        Me.label_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_fecha.Location = New System.Drawing.Point(744, 23)
        Me.label_fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_fecha.Name = "label_fecha"
        Me.label_fecha.Size = New System.Drawing.Size(78, 36)
        Me.label_fecha.TabIndex = 251
        Me.label_fecha.Text = "label"
        Me.label_fecha.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(650, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 36)
        Me.Label1.TabIndex = 250
        Me.Label1.Text = "Fecha:"
        Me.Label1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_Si)
        Me.GroupBox2.Controls.Add(Me.RB_No)
        Me.GroupBox2.Controls.Add(Me.CB_lista)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(293, 5)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(301, 91)
        Me.GroupBox2.TabIndex = 249
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configurar Lista"
        Me.GroupBox2.Visible = False
        '
        'RB_Si
        '
        Me.RB_Si.AutoSize = True
        Me.RB_Si.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_Si.Location = New System.Drawing.Point(68, 23)
        Me.RB_Si.Margin = New System.Windows.Forms.Padding(4)
        Me.RB_Si.Name = "RB_Si"
        Me.RB_Si.Size = New System.Drawing.Size(55, 29)
        Me.RB_Si.TabIndex = 224
        Me.RB_Si.Text = "Si"
        Me.RB_Si.UseVisualStyleBackColor = True
        '
        'RB_No
        '
        Me.RB_No.AutoSize = True
        Me.RB_No.Checked = True
        Me.RB_No.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_No.Location = New System.Drawing.Point(8, 23)
        Me.RB_No.Margin = New System.Windows.Forms.Padding(4)
        Me.RB_No.Name = "RB_No"
        Me.RB_No.Size = New System.Drawing.Size(62, 29)
        Me.RB_No.TabIndex = 223
        Me.RB_No.TabStop = True
        Me.RB_No.Text = "No"
        Me.RB_No.UseVisualStyleBackColor = True
        '
        'CB_lista
        '
        Me.CB_lista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_lista.FormattingEnabled = True
        Me.CB_lista.Location = New System.Drawing.Point(8, 54)
        Me.CB_lista.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_lista.Name = "CB_lista"
        Me.CB_lista.Size = New System.Drawing.Size(277, 33)
        Me.CB_lista.TabIndex = 0
        '
        'BO_Modificar
        '
        Me.BO_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Modificar.Location = New System.Drawing.Point(668, 582)
        Me.BO_Modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Modificar.Name = "BO_Modificar"
        Me.BO_Modificar.Size = New System.Drawing.Size(148, 43)
        Me.BO_Modificar.TabIndex = 248
        Me.BO_Modificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.BO_Modificar, "Modificar cliente existente")
        Me.BO_Modificar.UseVisualStyleBackColor = True
        Me.BO_Modificar.Visible = False
        '
        'BO_Nuevo
        '
        Me.BO_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Nuevo.Location = New System.Drawing.Point(515, 582)
        Me.BO_Nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Nuevo.Name = "BO_Nuevo"
        Me.BO_Nuevo.Size = New System.Drawing.Size(145, 43)
        Me.BO_Nuevo.TabIndex = 247
        Me.BO_Nuevo.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.BO_Nuevo, "Registrar nuevo cliente")
        Me.BO_Nuevo.UseVisualStyleBackColor = True
        Me.BO_Nuevo.Visible = False
        '
        'BO_Aceptar
        '
        Me.BO_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_Aceptar.Location = New System.Drawing.Point(1094, 586)
        Me.BO_Aceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Aceptar.Name = "BO_Aceptar"
        Me.BO_Aceptar.Size = New System.Drawing.Size(138, 43)
        Me.BO_Aceptar.TabIndex = 246
        Me.BO_Aceptar.Text = "Continuar"
        Me.BO_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_Aceptar, "ir a carga de productos")
        Me.BO_Aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Busqueda)
        Me.GroupBox1.Controls.Add(Me.DG_clientes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(11, 103)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1221, 471)
        Me.GroupBox1.TabIndex = 245
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar cliente por nombre (Fantasía o Razón Social): "
        '
        'Busqueda
        '
        Me.Busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.Location = New System.Drawing.Point(12, 26)
        Me.Busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(1201, 35)
        Me.Busqueda.TabIndex = 240
        '
        'DG_clientes
        '
        Me.DG_clientes.AllowUserToAddRows = False
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.AutoGenerateColumns = False
        Me.DG_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIidDataGridViewTextBoxColumn, Me.CLIFanDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn, Me.direccion, Me.CLIfnacDataGridViewTextBoxColumn, Me.CLIapeDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.CLIobservacionesDataGridViewTextBoxColumn})
        Me.DG_clientes.DataSource = Me.ClienteBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(12, 65)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle100.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle100.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle100.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle100
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(1201, 398)
        Me.DG_clientes.TabIndex = 239
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'CLIFanDataGridViewTextBoxColumn
        '
        Me.CLIFanDataGridViewTextBoxColumn.DataPropertyName = "CLI_Fan"
        Me.CLIFanDataGridViewTextBoxColumn.HeaderText = "Fantasía o Razón Social"
        Me.CLIFanDataGridViewTextBoxColumn.Name = "CLIFanDataGridViewTextBoxColumn"
        Me.CLIFanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "DNI/CUIT"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLItelDataGridViewTextBoxColumn
        '
        Me.CLItelDataGridViewTextBoxColumn.DataPropertyName = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
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
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'CLIfnacDataGridViewTextBoxColumn
        '
        Me.CLIfnacDataGridViewTextBoxColumn.DataPropertyName = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.HeaderText = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.Name = "CLIfnacDataGridViewTextBoxColumn"
        Me.CLIfnacDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIfnacDataGridViewTextBoxColumn.Visible = False
        '
        'CLIapeDataGridViewTextBoxColumn
        '
        Me.CLIapeDataGridViewTextBoxColumn.DataPropertyName = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.HeaderText = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.Name = "CLIapeDataGridViewTextBoxColumn"
        Me.CLIapeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIapeDataGridViewTextBoxColumn.Visible = False
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Visible = False
        '
        'CLIobservacionesDataGridViewTextBoxColumn
        '
        Me.CLIobservacionesDataGridViewTextBoxColumn.DataPropertyName = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.HeaderText = "observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.Name = "CLIobservacionesDataGridViewTextBoxColumn"
        Me.CLIobservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIobservacionesDataGridViewTextBoxColumn.Visible = False
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(11, 5)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(238, 91)
        Me.GroupBox3.TabIndex = 244
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione el tipo de venta :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RB_Cliente)
        Me.Panel2.Controls.Add(Me.RB_Consumidor)
        Me.Panel2.Location = New System.Drawing.Point(8, 23)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 59)
        Me.Panel2.TabIndex = 234
        '
        'RB_Cliente
        '
        Me.RB_Cliente.AutoSize = True
        Me.RB_Cliente.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_Cliente.Location = New System.Drawing.Point(4, 32)
        Me.RB_Cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.RB_Cliente.Name = "RB_Cliente"
        Me.RB_Cliente.Size = New System.Drawing.Size(98, 29)
        Me.RB_Cliente.TabIndex = 223
        Me.RB_Cliente.Text = "Cliente"
        Me.RB_Cliente.UseVisualStyleBackColor = True
        '
        'RB_Consumidor
        '
        Me.RB_Consumidor.AutoSize = True
        Me.RB_Consumidor.Checked = True
        Me.RB_Consumidor.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_Consumidor.Location = New System.Drawing.Point(4, 4)
        Me.RB_Consumidor.Margin = New System.Windows.Forms.Padding(4)
        Me.RB_Consumidor.Name = "RB_Consumidor"
        Me.RB_Consumidor.Size = New System.Drawing.Size(190, 29)
        Me.RB_Consumidor.TabIndex = 222
        Me.RB_Consumidor.TabStop = True
        Me.RB_Consumidor.Text = "Consumidor Final"
        Me.RB_Consumidor.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1253, 634)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Venta en Caja: Productos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Panel1)
        Me.GroupBox8.Controls.Add(Me.GroupBox15)
        Me.GroupBox8.Controls.Add(Me.GroupBox_pagar)
        Me.GroupBox8.Controls.Add(Me.DataG_listaTotal)
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Location = New System.Drawing.Point(16, 459)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(1216, 108)
        Me.GroupBox8.TabIndex = 262
        Me.GroupBox8.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.txt_impuesto_aplicado)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txt_subtotal)
        Me.Panel1.Controls.Add(Me.txt_descuento)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(462, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 91)
        Me.Panel1.TabIndex = 259
        '
        'txt_impuesto_aplicado
        '
        Me.txt_impuesto_aplicado.BackColor = System.Drawing.SystemColors.Info
        Me.txt_impuesto_aplicado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_impuesto_aplicado.Location = New System.Drawing.Point(208, 57)
        Me.txt_impuesto_aplicado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_impuesto_aplicado.Name = "txt_impuesto_aplicado"
        Me.txt_impuesto_aplicado.ReadOnly = True
        Me.txt_impuesto_aplicado.Size = New System.Drawing.Size(112, 25)
        Me.txt_impuesto_aplicado.TabIndex = 274
        Me.txt_impuesto_aplicado.Text = "0"
        Me.txt_impuesto_aplicado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(17, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(181, 20)
        Me.Label24.TabIndex = 273
        Me.Label24.Text = "IMPUESTO APLICADO:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(220, 20)
        Me.Label20.TabIndex = 269
        Me.Label20.Text = "SUBTOTAL DE ARTICULOS:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(208, 7)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(112, 25)
        Me.txt_subtotal.TabIndex = 270
        Me.txt_subtotal.Text = "0"
        Me.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_descuento
        '
        Me.txt_descuento.BackColor = System.Drawing.SystemColors.Info
        Me.txt_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descuento.Location = New System.Drawing.Point(208, 32)
        Me.txt_descuento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.ReadOnly = True
        Me.txt_descuento.Size = New System.Drawing.Size(112, 25)
        Me.txt_descuento.TabIndex = 272
        Me.txt_descuento.Text = "0"
        Me.txt_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(17, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(113, 20)
        Me.Label23.TabIndex = 271
        Me.Label23.Text = "DESCUENTO:"
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox15.Controls.Add(Me.ComboBox_iva)
        Me.GroupBox15.Controls.Add(Me.Label19)
        Me.GroupBox15.Location = New System.Drawing.Point(280, 14)
        Me.GroupBox15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox15.Size = New System.Drawing.Size(143, 79)
        Me.GroupBox15.TabIndex = 16
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "IVA aplicado"
        '
        'ComboBox_iva
        '
        Me.ComboBox_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_iva.FormattingEnabled = True
        Me.ComboBox_iva.Items.AddRange(New Object() {"0", "10,5", "21"})
        Me.ComboBox_iva.Location = New System.Drawing.Point(72, 34)
        Me.ComboBox_iva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox_iva.Name = "ComboBox_iva"
        Me.ComboBox_iva.Size = New System.Drawing.Size(64, 33)
        Me.ComboBox_iva.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 20)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "IVA (%):"
        '
        'GroupBox_pagar
        '
        Me.GroupBox_pagar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox_pagar.Controls.Add(Me.Label9)
        Me.GroupBox_pagar.Controls.Add(Me.txt_total)
        Me.GroupBox_pagar.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox_pagar.Location = New System.Drawing.Point(893, 17)
        Me.GroupBox_pagar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox_pagar.Name = "GroupBox_pagar"
        Me.GroupBox_pagar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox_pagar.Size = New System.Drawing.Size(277, 79)
        Me.GroupBox_pagar.TabIndex = 15
        Me.GroupBox_pagar.TabStop = False
        Me.GroupBox_pagar.Text = "Monto a pagar (0% descuento)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 36)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "TOTAL:"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.SystemColors.Info
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(111, 25)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(159, 41)
        Me.txt_total.TabIndex = 8
        Me.txt_total.Text = "0"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataG_listaTotal
        '
        Me.DataG_listaTotal.AllowUserToAddRows = False
        Me.DataG_listaTotal.AllowUserToDeleteRows = False
        Me.DataG_listaTotal.BackgroundColor = System.Drawing.Color.White
        Me.DataG_listaTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataG_listaTotal.ColumnHeadersVisible = False
        Me.DataG_listaTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle102.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle102.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle102.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle102.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle102.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle102.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataG_listaTotal.DefaultCellStyle = DataGridViewCellStyle102
        Me.DataG_listaTotal.Location = New System.Drawing.Point(8, 100)
        Me.DataG_listaTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.DataG_listaTotal.Name = "DataG_listaTotal"
        Me.DataG_listaTotal.ReadOnly = True
        Me.DataG_listaTotal.RowHeadersVisible = False
        Me.DataG_listaTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataG_listaTotal.Size = New System.Drawing.Size(1001, 37)
        Me.DataG_listaTotal.TabIndex = 13
        Me.DataG_listaTotal.Visible = False
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
        DataGridViewCellStyle101.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle101.Format = "N2"
        DataGridViewCellStyle101.NullValue = "0"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle101
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 640
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox9.Controls.Add(Me.txt_desc_pesos)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.txt_desc_porc)
        Me.GroupBox9.Controls.Add(Me.Label11)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(24, 14)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Size = New System.Drawing.Size(202, 79)
        Me.GroupBox9.TabIndex = 12
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Aplicar descuento"
        '
        'txt_desc_pesos
        '
        Me.txt_desc_pesos.BackColor = System.Drawing.SystemColors.Info
        Me.txt_desc_pesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc_pesos.Location = New System.Drawing.Point(117, 46)
        Me.txt_desc_pesos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_desc_pesos.Name = "txt_desc_pesos"
        Me.txt_desc_pesos.Size = New System.Drawing.Size(65, 25)
        Me.txt_desc_pesos.TabIndex = 14
        Me.txt_desc_pesos.Text = "0"
        Me.txt_desc_pesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Descuento (%):"
        '
        'txt_desc_porc
        '
        Me.txt_desc_porc.BackColor = System.Drawing.SystemColors.Info
        Me.txt_desc_porc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc_porc.Location = New System.Drawing.Point(117, 20)
        Me.txt_desc_porc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_desc_porc.Name = "txt_desc_porc"
        Me.txt_desc_porc.Size = New System.Drawing.Size(65, 25)
        Me.txt_desc_porc.TabIndex = 13
        Me.txt_desc_porc.Text = "0"
        Me.txt_desc_porc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Descuento ($):"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.Label_remito)
        Me.GroupBox7.Controls.Add(Me.Panel3)
        Me.GroupBox7.Controls.Add(Me.GroupBox13)
        Me.GroupBox7.Controls.Add(Me.GroupBox11)
        Me.GroupBox7.Controls.Add(Me.GroupBox10)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.Label_tipo_vta)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 4)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(1216, 188)
        Me.GroupBox7.TabIndex = 261
        Me.GroupBox7.TabStop = False
        '
        'Label_remito
        '
        Me.Label_remito.AutoSize = True
        Me.Label_remito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_remito.ForeColor = System.Drawing.Color.Blue
        Me.Label_remito.Location = New System.Drawing.Point(275, 12)
        Me.Label_remito.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_remito.Name = "Label_remito"
        Me.Label_remito.Size = New System.Drawing.Size(138, 29)
        Me.Label_remito.TabIndex = 276
        Me.Label_remito.Text = "Remito Nº:"
        Me.Label_remito.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.ComboBox_vendedor)
        Me.Panel3.Controls.Add(Me.Btn_Vendedor_buscar)
        Me.Panel3.Controls.Add(Me.txt_vendedor_codigo)
        Me.Panel3.Location = New System.Drawing.Point(13, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1196, 37)
        Me.Panel3.TabIndex = 275
        Me.ToolTip1.SetToolTip(Me.Panel3, "ingrese cód. vendedor")
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(16, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 25)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Vendedor:"
        '
        'ComboBox_vendedor
        '
        Me.ComboBox_vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_vendedor.FormattingEnabled = True
        Me.ComboBox_vendedor.Location = New System.Drawing.Point(239, 7)
        Me.ComboBox_vendedor.Name = "ComboBox_vendedor"
        Me.ComboBox_vendedor.Size = New System.Drawing.Size(203, 33)
        Me.ComboBox_vendedor.TabIndex = 2
        '
        'Btn_Vendedor_buscar
        '
        Me.Btn_Vendedor_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Vendedor_buscar.Location = New System.Drawing.Point(193, 6)
        Me.Btn_Vendedor_buscar.Name = "Btn_Vendedor_buscar"
        Me.Btn_Vendedor_buscar.Size = New System.Drawing.Size(40, 28)
        Me.Btn_Vendedor_buscar.TabIndex = 3
        Me.Btn_Vendedor_buscar.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Btn_Vendedor_buscar, "ver detalle")
        Me.Btn_Vendedor_buscar.UseVisualStyleBackColor = True
        '
        'txt_vendedor_codigo
        '
        Me.txt_vendedor_codigo.BackColor = System.Drawing.SystemColors.Info
        Me.txt_vendedor_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vendedor_codigo.Location = New System.Drawing.Point(122, 7)
        Me.txt_vendedor_codigo.Name = "txt_vendedor_codigo"
        Me.txt_vendedor_codigo.Size = New System.Drawing.Size(65, 30)
        Me.txt_vendedor_codigo.TabIndex = 1
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox13.Controls.Add(Me.Btn_facturacion)
        Me.GroupBox13.Controls.Add(Me.lb_tipo_vta)
        Me.GroupBox13.Controls.Add(Me.lb_vendedor_vta)
        Me.GroupBox13.Controls.Add(Me.lb_fecha_vta)
        Me.GroupBox13.Controls.Add(Me.lb_factura_vta)
        Me.GroupBox13.Controls.Add(Me.Label15)
        Me.GroupBox13.Controls.Add(Me.Label14)
        Me.GroupBox13.Controls.Add(Me.Label13)
        Me.GroupBox13.Controls.Add(Me.Label12)
        Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(842, 43)
        Me.GroupBox13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox13.Size = New System.Drawing.Size(367, 96)
        Me.GroupBox13.TabIndex = 274
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Venta"
        '
        'Btn_facturacion
        '
        Me.Btn_facturacion.BackgroundImage = Global.Aplicacion.My.Resources.Resources.factura
        Me.Btn_facturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_facturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_facturacion.Location = New System.Drawing.Point(287, 14)
        Me.Btn_facturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_facturacion.Name = "Btn_facturacion"
        Me.Btn_facturacion.Size = New System.Drawing.Size(68, 71)
        Me.Btn_facturacion.TabIndex = 276
        Me.Btn_facturacion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_facturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.Btn_facturacion, "iniciar facturación")
        Me.Btn_facturacion.UseVisualStyleBackColor = True
        Me.Btn_facturacion.Visible = False
        '
        'lb_tipo_vta
        '
        Me.lb_tipo_vta.AutoSize = True
        Me.lb_tipo_vta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tipo_vta.Location = New System.Drawing.Point(87, 68)
        Me.lb_tipo_vta.Name = "lb_tipo_vta"
        Me.lb_tipo_vta.Size = New System.Drawing.Size(153, 25)
        Me.lb_tipo_vta.TabIndex = 272
        Me.lb_tipo_vta.Text = "consumidor final"
        Me.lb_tipo_vta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_vendedor_vta
        '
        Me.lb_vendedor_vta.AutoSize = True
        Me.lb_vendedor_vta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_vendedor_vta.Location = New System.Drawing.Point(83, 178)
        Me.lb_vendedor_vta.Name = "lb_vendedor_vta"
        Me.lb_vendedor_vta.Size = New System.Drawing.Size(66, 20)
        Me.lb_vendedor_vta.TabIndex = 271
        Me.lb_vendedor_vta.Text = "Label21"
        Me.lb_vendedor_vta.Visible = False
        '
        'lb_fecha_vta
        '
        Me.lb_fecha_vta.AutoSize = True
        Me.lb_fecha_vta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fecha_vta.Location = New System.Drawing.Point(103, 48)
        Me.lb_fecha_vta.Name = "lb_fecha_vta"
        Me.lb_fecha_vta.Size = New System.Drawing.Size(112, 25)
        Me.lb_fecha_vta.TabIndex = 270
        Me.lb_fecha_vta.Text = "00/00/0000"
        Me.lb_fecha_vta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_factura_vta
        '
        Me.lb_factura_vta.AutoSize = True
        Me.lb_factura_vta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_factura_vta.Location = New System.Drawing.Point(140, 25)
        Me.lb_factura_vta.Name = "lb_factura_vta"
        Me.lb_factura_vta.Size = New System.Drawing.Size(56, 25)
        Me.lb_factura_vta.TabIndex = 269
        Me.lb_factura_vta.Text = "0000"
        Me.lb_factura_vta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 68)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 25)
        Me.Label15.TabIndex = 268
        Me.Label15.Text = "Tipo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 177)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 267
        Me.Label14.Text = "Vendedor:"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 48)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 25)
        Me.Label13.TabIndex = 266
        Me.Label13.Text = "Fecha:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 25)
        Me.Label12.TabIndex = 265
        Me.Label12.Text = "Nº Factura:"
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox11.Controls.Add(Me.label_limite)
        Me.GroupBox11.Controls.Add(Me.Label_saldo)
        Me.GroupBox11.Controls.Add(Me.Label_ctacte)
        Me.GroupBox11.Controls.Add(Me.lb_tipoIVA_clie)
        Me.GroupBox11.Controls.Add(Me.lb_mail_clie)
        Me.GroupBox11.Controls.Add(Me.lb_telef_clie)
        Me.GroupBox11.Controls.Add(Me.lb_dni_clie)
        Me.GroupBox11.Controls.Add(Me.lb_fantasia)
        Me.GroupBox11.Controls.Add(Me.Label18)
        Me.GroupBox11.Controls.Add(Me.Label2)
        Me.GroupBox11.Controls.Add(Me.Label17)
        Me.GroupBox11.Controls.Add(Me.Label16)
        Me.GroupBox11.Controls.Add(Me.Label4)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(404, 43)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox11.Size = New System.Drawing.Size(432, 96)
        Me.GroupBox11.TabIndex = 273
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Cliente"
        '
        'label_limite
        '
        Me.label_limite.AutoSize = True
        Me.label_limite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_limite.Location = New System.Drawing.Point(279, 68)
        Me.label_limite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_limite.Name = "label_limite"
        Me.label_limite.Size = New System.Drawing.Size(85, 25)
        Me.label_limite.TabIndex = 275
        Me.label_limite.Text = "Limite $:"
        '
        'Label_saldo
        '
        Me.Label_saldo.AutoSize = True
        Me.Label_saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_saldo.Location = New System.Drawing.Point(279, 48)
        Me.Label_saldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_saldo.Name = "Label_saldo"
        Me.Label_saldo.Size = New System.Drawing.Size(85, 25)
        Me.Label_saldo.TabIndex = 274
        Me.Label_saldo.Text = "Saldo $:"
        '
        'Label_ctacte
        '
        Me.Label_ctacte.AutoSize = True
        Me.Label_ctacte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ctacte.Location = New System.Drawing.Point(27, 68)
        Me.Label_ctacte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_ctacte.Name = "Label_ctacte"
        Me.Label_ctacte.Size = New System.Drawing.Size(167, 25)
        Me.Label_ctacte.TabIndex = 273
        Me.Label_ctacte.Text = "Cuenta Corriente:"
        '
        'lb_tipoIVA_clie
        '
        Me.lb_tipoIVA_clie.AutoSize = True
        Me.lb_tipoIVA_clie.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tipoIVA_clie.Location = New System.Drawing.Point(180, 151)
        Me.lb_tipoIVA_clie.Name = "lb_tipoIVA_clie"
        Me.lb_tipoIVA_clie.Size = New System.Drawing.Size(41, 20)
        Me.lb_tipoIVA_clie.TabIndex = 272
        Me.lb_tipoIVA_clie.Text = "- - - -"
        Me.lb_tipoIVA_clie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lb_tipoIVA_clie.Visible = False
        '
        'lb_mail_clie
        '
        Me.lb_mail_clie.AutoSize = True
        Me.lb_mail_clie.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mail_clie.Location = New System.Drawing.Point(131, 131)
        Me.lb_mail_clie.Name = "lb_mail_clie"
        Me.lb_mail_clie.Size = New System.Drawing.Size(41, 20)
        Me.lb_mail_clie.TabIndex = 271
        Me.lb_mail_clie.Text = "- - - -"
        Me.lb_mail_clie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lb_mail_clie.Visible = False
        '
        'lb_telef_clie
        '
        Me.lb_telef_clie.AutoSize = True
        Me.lb_telef_clie.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_telef_clie.Location = New System.Drawing.Point(163, 174)
        Me.lb_telef_clie.Name = "lb_telef_clie"
        Me.lb_telef_clie.Size = New System.Drawing.Size(41, 20)
        Me.lb_telef_clie.TabIndex = 270
        Me.lb_telef_clie.Text = "- - - -"
        Me.lb_telef_clie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lb_telef_clie.Visible = False
        '
        'lb_dni_clie
        '
        Me.lb_dni_clie.AutoSize = True
        Me.lb_dni_clie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni_clie.Location = New System.Drawing.Point(174, 48)
        Me.lb_dni_clie.Name = "lb_dni_clie"
        Me.lb_dni_clie.Size = New System.Drawing.Size(55, 25)
        Me.lb_dni_clie.TabIndex = 269
        Me.lb_dni_clie.Text = "- - - -"
        Me.lb_dni_clie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_fantasia
        '
        Me.lb_fantasia.AutoSize = True
        Me.lb_fantasia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fantasia.Location = New System.Drawing.Point(126, 25)
        Me.lb_fantasia.Name = "lb_fantasia"
        Me.lb_fantasia.Size = New System.Drawing.Size(55, 25)
        Me.lb_fantasia.TabIndex = 268
        Me.lb_fantasia.Text = "- - - -"
        Me.lb_fantasia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(88, 151)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 20)
        Me.Label18.TabIndex = 267
        Me.Label18.Text = "Tipo de IVA:"
        Me.Label18.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 263
        Me.Label2.Text = "Fantasía:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(87, 131)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 20)
        Me.Label17.TabIndex = 266
        Me.Label17.Text = "Mail:"
        Me.Label17.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(88, 173)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 20)
        Me.Label16.TabIndex = 265
        Me.Label16.Text = "Teléfono:"
        Me.Label16.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "DNI / Nº CUIT:"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox10.Controls.Add(Me.lb_mail_sucursal)
        Me.GroupBox10.Controls.Add(Me.lb_telefono_sucursal)
        Me.GroupBox10.Controls.Add(Me.lb_direccion_sucursal)
        Me.GroupBox10.Controls.Add(Me.Label22)
        Me.GroupBox10.Controls.Add(Me.Label21)
        Me.GroupBox10.Controls.Add(Me.Label7)
        Me.GroupBox10.Controls.Add(Me.lb_nombre_sucursal)
        Me.GroupBox10.Controls.Add(Me.lb)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(15, 43)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox10.Size = New System.Drawing.Size(385, 96)
        Me.GroupBox10.TabIndex = 272
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Datos comerciales"
        '
        'lb_mail_sucursal
        '
        Me.lb_mail_sucursal.AutoSize = True
        Me.lb_mail_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mail_sucursal.Location = New System.Drawing.Point(73, 88)
        Me.lb_mail_sucursal.Name = "lb_mail_sucursal"
        Me.lb_mail_sucursal.Size = New System.Drawing.Size(41, 20)
        Me.lb_mail_sucursal.TabIndex = 274
        Me.lb_mail_sucursal.Text = "- - - -"
        Me.lb_mail_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lb_mail_sucursal.Visible = False
        '
        'lb_telefono_sucursal
        '
        Me.lb_telefono_sucursal.AutoSize = True
        Me.lb_telefono_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_telefono_sucursal.Location = New System.Drawing.Point(131, 68)
        Me.lb_telefono_sucursal.Name = "lb_telefono_sucursal"
        Me.lb_telefono_sucursal.Size = New System.Drawing.Size(55, 25)
        Me.lb_telefono_sucursal.TabIndex = 273
        Me.lb_telefono_sucursal.Text = "- - - -"
        Me.lb_telefono_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_direccion_sucursal
        '
        Me.lb_direccion_sucursal.AutoSize = True
        Me.lb_direccion_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_direccion_sucursal.Location = New System.Drawing.Point(135, 48)
        Me.lb_direccion_sucursal.Name = "lb_direccion_sucursal"
        Me.lb_direccion_sucursal.Size = New System.Drawing.Size(55, 25)
        Me.lb_direccion_sucursal.TabIndex = 272
        Me.lb_direccion_sucursal.Text = "- - - -"
        Me.lb_direccion_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(30, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 20)
        Me.Label22.TabIndex = 271
        Me.Label22.Text = "Mail:"
        Me.Label22.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(30, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 25)
        Me.Label21.TabIndex = 270
        Me.Label21.Text = "Teléfono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 269
        Me.Label7.Text = "Dirección:"
        '
        'lb_nombre_sucursal
        '
        Me.lb_nombre_sucursal.AutoSize = True
        Me.lb_nombre_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nombre_sucursal.Location = New System.Drawing.Point(132, 25)
        Me.lb_nombre_sucursal.Name = "lb_nombre_sucursal"
        Me.lb_nombre_sucursal.Size = New System.Drawing.Size(55, 25)
        Me.lb_nombre_sucursal.TabIndex = 268
        Me.lb_nombre_sucursal.Text = "- - - -"
        Me.lb_nombre_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb.Location = New System.Drawing.Point(30, 26)
        Me.lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(95, 25)
        Me.lb.TabIndex = 267
        Me.lb.Text = "Sucursal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1039, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(199, 25)
        Me.Label8.TabIndex = 271
        Me.Label8.Text = "00/00/0000 00:00 hrs"
        Me.Label8.Visible = False
        '
        'Label_tipo_vta
        '
        Me.Label_tipo_vta.AutoSize = True
        Me.Label_tipo_vta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tipo_vta.ForeColor = System.Drawing.Color.Blue
        Me.Label_tipo_vta.Location = New System.Drawing.Point(8, 12)
        Me.Label_tipo_vta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_tipo_vta.Name = "Label_tipo_vta"
        Me.Label_tipo_vta.Size = New System.Drawing.Size(193, 29)
        Me.Label_tipo_vta.TabIndex = 266
        Me.Label_tipo_vta.Text = "Venta Minorista"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(932, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 265
        Me.Label5.Text = "Fecha y hora:"
        Me.Label5.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Guardar)
        Me.GroupBox4.Controls.Add(Me.Quitar)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 570)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1216, 60)
        Me.GroupBox4.TabIndex = 238
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(453, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "F1(busqueda avanzada), F5 (busqueda cod barra)"
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.Location = New System.Drawing.Point(1073, 14)
        Me.Guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(124, 43)
        Me.Guardar.TabIndex = 0
        Me.Guardar.Text = "Confirmar"
        Me.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Guardar, "Confirmar venta")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Quitar
        '
        Me.Quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitar.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Quitar.Location = New System.Drawing.Point(809, 14)
        Me.Quitar.Margin = New System.Windows.Forms.Padding(4)
        Me.Quitar.Name = "Quitar"
        Me.Quitar.Size = New System.Drawing.Size(124, 43)
        Me.Quitar.TabIndex = 1
        Me.Quitar.Text = "Eliminar"
        Me.Quitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Quitar, "Eliminar producto seleccionado")
        Me.Quitar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.Button3.Location = New System.Drawing.Point(941, 14)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 43)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button3, "Cancelar venta")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox12.Controls.Add(Me.DataGridView1)
        Me.GroupBox12.Enabled = False
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox12.Location = New System.Drawing.Point(16, 198)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox12.Size = New System.Drawing.Size(1216, 260)
        Me.GroupBox12.TabIndex = 237
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Productos agregados"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columna_item, Me.columna_prod_id, Me.columna_codinterno, Me.columna_descripcion, Me.columna_detalle, Me.columna_cantidad, Me.descuento, Me.columna_precio_unitario, Me.columna_precio_subtotal, Me.columna_codbarra, Me.Column1})
        Me.DataGridView1.DataSource = Me.ProductoagregadoBindingSource
        DataGridViewCellStyle109.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle109.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle109.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle109.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle109.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle109.SelectionForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle109.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle109
        Me.DataGridView1.Location = New System.Drawing.Point(4, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle110.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle110.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle110.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle110.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle110
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1193, 230)
        Me.DataGridView1.TabIndex = 0
        '
        'columna_item
        '
        DataGridViewCellStyle103.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.columna_item.DefaultCellStyle = DataGridViewCellStyle103
        Me.columna_item.FillWeight = 106.599!
        Me.columna_item.HeaderText = "Item"
        Me.columna_item.Name = "columna_item"
        Me.columna_item.ReadOnly = True
        Me.columna_item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columna_item.Width = 70
        '
        'columna_prod_id
        '
        Me.columna_prod_id.DataPropertyName = "PROD_id"
        Me.columna_prod_id.HeaderText = "PROD_id"
        Me.columna_prod_id.Name = "columna_prod_id"
        Me.columna_prod_id.Visible = False
        Me.columna_prod_id.Width = 91
        '
        'columna_codinterno
        '
        Me.columna_codinterno.DataPropertyName = "codinterno"
        Me.columna_codinterno.FillWeight = 98.90017!
        Me.columna_codinterno.HeaderText = "Cód. Interno"
        Me.columna_codinterno.Name = "columna_codinterno"
        Me.columna_codinterno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columna_codinterno.Width = 168
        '
        'columna_descripcion
        '
        Me.columna_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columna_descripcion.DataPropertyName = "descripcion"
        DataGridViewCellStyle104.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.columna_descripcion.DefaultCellStyle = DataGridViewCellStyle104
        Me.columna_descripcion.FillWeight = 98.90017!
        Me.columna_descripcion.HeaderText = "Descripción"
        Me.columna_descripcion.Name = "columna_descripcion"
        Me.columna_descripcion.ReadOnly = True
        Me.columna_descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'columna_detalle
        '
        Me.columna_detalle.DataPropertyName = "detalle"
        Me.columna_detalle.FillWeight = 98.90017!
        Me.columna_detalle.HeaderText = "Detalle"
        Me.columna_detalle.Name = "columna_detalle"
        Me.columna_detalle.Visible = False
        Me.columna_detalle.Width = 90
        '
        'columna_cantidad
        '
        Me.columna_cantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle105.Format = "N2"
        DataGridViewCellStyle105.NullValue = Nothing
        Me.columna_cantidad.DefaultCellStyle = DataGridViewCellStyle105
        Me.columna_cantidad.FillWeight = 98.90017!
        Me.columna_cantidad.HeaderText = "Cantidad"
        Me.columna_cantidad.Name = "columna_cantidad"
        Me.columna_cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columna_cantidad.Width = 80
        '
        'descuento
        '
        Me.descuento.DataPropertyName = "descuento"
        DataGridViewCellStyle106.Format = "N2"
        Me.descuento.DefaultCellStyle = DataGridViewCellStyle106
        Me.descuento.HeaderText = "Descuento(%)"
        Me.descuento.Name = "descuento"
        Me.descuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'columna_precio_unitario
        '
        Me.columna_precio_unitario.DataPropertyName = "precio_unitario"
        DataGridViewCellStyle107.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle107.Format = "N2"
        Me.columna_precio_unitario.DefaultCellStyle = DataGridViewCellStyle107
        Me.columna_precio_unitario.FillWeight = 98.90017!
        Me.columna_precio_unitario.HeaderText = "Precio U."
        Me.columna_precio_unitario.Name = "columna_precio_unitario"
        Me.columna_precio_unitario.ReadOnly = True
        Me.columna_precio_unitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columna_precio_unitario.Width = 120
        '
        'columna_precio_subtotal
        '
        Me.columna_precio_subtotal.DataPropertyName = "precio_subtotal"
        DataGridViewCellStyle108.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle108.Format = "N2"
        Me.columna_precio_subtotal.DefaultCellStyle = DataGridViewCellStyle108
        Me.columna_precio_subtotal.FillWeight = 98.90017!
        Me.columna_precio_subtotal.HeaderText = "Subtotal"
        Me.columna_precio_subtotal.Name = "columna_precio_subtotal"
        Me.columna_precio_subtotal.ReadOnly = True
        Me.columna_precio_subtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columna_precio_subtotal.Width = 120
        '
        'columna_codbarra
        '
        Me.columna_codbarra.DataPropertyName = "codbarra"
        Me.columna_codbarra.HeaderText = "codbarra"
        Me.columna_codbarra.Name = "columna_codbarra"
        Me.columna_codbarra.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Quitar"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'ProductoagregadoBindingSource
        '
        Me.ProductoagregadoBindingSource.DataMember = "Producto_agregado"
        Me.ProductoagregadoBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'ProductosCombosBindingSource
        '
        Me.ProductosCombosBindingSource.DataMember = "Productos_Combos"
        Me.ProductosCombosBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'Venta_Caja_gestion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1274, 680)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1278, 670)
        Me.Name = "Venta_Caja_gestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Ventas en Caja"
        CType(Me.Venta_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox_pagar.ResumeLayout(False)
        Me.GroupBox_pagar.PerformLayout()
        CType(Me.DataG_listaTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoagregadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosCombosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Venta_Caja_ds As Aplicacion.Venta_Caja_ds
    Friend WithEvents Venta_ds As Aplicacion.Venta_ds
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Si As System.Windows.Forms.RadioButton
    Friend WithEvents RB_No As System.Windows.Forms.RadioButton
    Friend WithEvents CB_lista As System.Windows.Forms.ComboBox
    Friend WithEvents BO_Modificar As System.Windows.Forms.Button
    Friend WithEvents BO_Nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_Aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RB_Cliente As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Consumidor As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Quitar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ProductoagregadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosCombosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents label_fecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label_hora As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label_tipo_vta As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_desc_pesos As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_desc_porc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataG_listaTotal As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_pagar As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_iva As System.Windows.Forms.ComboBox
    Friend WithEvents lb_tipo_vta As System.Windows.Forms.Label
    Friend WithEvents lb_vendedor_vta As System.Windows.Forms.Label
    Friend WithEvents lb_fecha_vta As System.Windows.Forms.Label
    Friend WithEvents lb_factura_vta As System.Windows.Forms.Label
    Friend WithEvents lb_tipoIVA_clie As System.Windows.Forms.Label
    Friend WithEvents lb_mail_clie As System.Windows.Forms.Label
    Friend WithEvents lb_telef_clie As System.Windows.Forms.Label
    Friend WithEvents lb_dni_clie As System.Windows.Forms.Label
    Friend WithEvents lb_fantasia As System.Windows.Forms.Label
    Friend WithEvents lb_mail_sucursal As System.Windows.Forms.Label
    Friend WithEvents lb_telefono_sucursal As System.Windows.Forms.Label
    Friend WithEvents lb_direccion_sucursal As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lb_nombre_sucursal As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIFanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfnacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIobservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_impuesto_aplicado As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents txt_descuento As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_ctacte As System.Windows.Forms.Label
    Friend WithEvents Label_saldo As System.Windows.Forms.Label
    Friend WithEvents Btn_Vendedor_buscar As System.Windows.Forms.Button
    Friend WithEvents ComboBox_vendedor As System.Windows.Forms.ComboBox
    Friend WithEvents txt_vendedor_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label_remito As System.Windows.Forms.Label
    Friend WithEvents label_limite As System.Windows.Forms.Label
    Friend WithEvents Btn_facturacion As System.Windows.Forms.Button
    Friend WithEvents columna_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columna_prod_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columna_codinterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columna_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columna_detalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columna_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columna_precio_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columna_precio_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columna_codbarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
