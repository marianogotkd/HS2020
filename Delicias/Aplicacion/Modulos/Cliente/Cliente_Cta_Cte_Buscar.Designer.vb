<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_Cta_Cte_Buscar
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.ClienteCtaCteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.error_razonsocial = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_ctacte = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_limitedeuda = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBox_estado = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_fechaalta = New System.Windows.Forms.Label()
        Me.error_dni = New System.Windows.Forms.Label()
        Me.tb_Dni_Cuit = New System.Windows.Forms.TextBox()
        Me.tx_mail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Combo_Loc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combo_Prov = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_Cp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_Fan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Combo_Iva = New System.Windows.Forms.ComboBox()
        Me.tx_dir = New System.Windows.Forms.TextBox()
        Me.tx_tel = New System.Windows.Forms.TextBox()
        Me.lb_dni = New System.Windows.Forms.Label()
        Me.lb_mail = New System.Windows.Forms.Label()
        Me.lb_tel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DG_Detalle = New System.Windows.Forms.DataGridView()
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCtaCteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtaCteidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIFanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfnacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIobservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCteestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCtetotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BO_cliente_modificar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_comprobante = New System.Windows.Forms.Button()
        Me.Button_ajustarsaldo = New System.Windows.Forms.Button()
        Me.Button_volver = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.txt_total_deuda = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteCtaCteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleCtaCteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG_clientes)
        Me.GroupBox1.Controls.Add(Me.BO_cliente_modificar)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(1052, 535)
        Me.GroupBox1.TabIndex = 248
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por Fantasia / Nº Cta. Cte. / Dni-Cuit: "
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
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CtaCteidDataGridViewTextBoxColumn, Me.CLIFanDataGridViewTextBoxColumn, Me.CLIidDataGridViewTextBoxColumn, Me.CLIapeDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.CLIfnacDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn, Me.CLIobservacionesDataGridViewTextBoxColumn, Me.CtaCteestadoDataGridViewTextBoxColumn, Me.CtaCtefechaaltaDataGridViewTextBoxColumn, Me.CtaCtelimitedeudaDataGridViewTextBoxColumn, Me.CtaCtetotalDataGridViewTextBoxColumn})
        Me.DG_clientes.DataSource = Me.ClienteCtaCteBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(16, 60)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(5)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(1024, 406)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 241
        '
        'ClienteCtaCteBindingSource
        '
        Me.ClienteCtaCteBindingSource.DataMember = "Cliente_CtaCte"
        Me.ClienteCtaCteBindingSource.DataSource = Me.Cliente_ds
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 27)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1024, 26)
        Me.TextBox1.TabIndex = 240
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1078, 582)
        Me.TabControl1.TabIndex = 250
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1070, 553)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Selección de cuenta corriente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_total_deuda)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button_comprobante)
        Me.TabPage2.Controls.Add(Me.Button_ajustarsaldo)
        Me.TabPage2.Controls.Add(Me.Button_volver)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1070, 553)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resumen cuenta corriente"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.error_razonsocial)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_ctacte)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox3.Controls.Add(Me.txt_limitedeuda)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.CheckBox_estado)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label_fechaalta)
        Me.GroupBox3.Controls.Add(Me.error_dni)
        Me.GroupBox3.Controls.Add(Me.tb_Dni_Cuit)
        Me.GroupBox3.Controls.Add(Me.tx_mail)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Combo_Loc)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.combo_Prov)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tx_Cp)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.tx_Fan)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Combo_Iva)
        Me.GroupBox3.Controls.Add(Me.tx_dir)
        Me.GroupBox3.Controls.Add(Me.tx_tel)
        Me.GroupBox3.Controls.Add(Me.lb_dni)
        Me.GroupBox3.Controls.Add(Me.lb_mail)
        Me.GroupBox3.Controls.Add(Me.lb_tel)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 421)
        Me.GroupBox3.TabIndex = 252
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(66, 372)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 17)
        Me.Label12.TabIndex = 291
        Me.Label12.Text = "* 0: sin limite."
        '
        'error_razonsocial
        '
        Me.error_razonsocial.AutoSize = True
        Me.error_razonsocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_razonsocial.ForeColor = System.Drawing.Color.Red
        Me.error_razonsocial.Location = New System.Drawing.Point(385, 53)
        Me.error_razonsocial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_razonsocial.Name = "error_razonsocial"
        Me.error_razonsocial.Size = New System.Drawing.Size(31, 39)
        Me.error_razonsocial.TabIndex = 283
        Me.error_razonsocial.Text = "*"
        Me.error_razonsocial.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(385, 23)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 39)
        Me.Label11.TabIndex = 284
        Me.Label11.Text = "*"
        Me.Label11.Visible = False
        '
        'txt_ctacte
        '
        Me.txt_ctacte.Enabled = False
        Me.txt_ctacte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ctacte.Location = New System.Drawing.Point(173, 24)
        Me.txt_ctacte.Name = "txt_ctacte"
        Me.txt_ctacte.Size = New System.Drawing.Size(209, 23)
        Me.txt_ctacte.TabIndex = 0
        Me.txt_ctacte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(9, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 17)
        Me.Label10.TabIndex = 290
        Me.Label10.Text = "Nº Cuenta Corriente:"
        '
        'txt_limitedeuda
        '
        Me.txt_limitedeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txt_limitedeuda.Location = New System.Drawing.Point(173, 343)
        Me.txt_limitedeuda.Name = "txt_limitedeuda"
        Me.txt_limitedeuda.Size = New System.Drawing.Size(207, 23)
        Me.txt_limitedeuda.TabIndex = 11
        Me.txt_limitedeuda.Text = "0"
        Me.txt_limitedeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Limite deuda permitida:"
        '
        'CheckBox_estado
        '
        Me.CheckBox_estado.AutoSize = True
        Me.CheckBox_estado.ForeColor = System.Drawing.Color.Green
        Me.CheckBox_estado.Location = New System.Drawing.Point(69, 322)
        Me.CheckBox_estado.Name = "CheckBox_estado"
        Me.CheckBox_estado.Size = New System.Drawing.Size(68, 21)
        Me.CheckBox_estado.TabIndex = 287
        Me.CheckBox_estado.Text = "Activo"
        Me.CheckBox_estado.UseVisualStyleBackColor = True
        Me.CheckBox_estado.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 286
        Me.Label8.Text = "Estado:"
        Me.Label8.Visible = False
        '
        'Label_fechaalta
        '
        Me.Label_fechaalta.AutoSize = True
        Me.Label_fechaalta.Location = New System.Drawing.Point(6, 298)
        Me.Label_fechaalta.Name = "Label_fechaalta"
        Me.Label_fechaalta.Size = New System.Drawing.Size(98, 17)
        Me.Label_fechaalta.TabIndex = 285
        Me.Label_fechaalta.Text = "Fecha de alta:"
        Me.Label_fechaalta.Visible = False
        '
        'error_dni
        '
        Me.error_dni.AutoSize = True
        Me.error_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_dni.ForeColor = System.Drawing.Color.Red
        Me.error_dni.Location = New System.Drawing.Point(385, 84)
        Me.error_dni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_dni.Name = "error_dni"
        Me.error_dni.Size = New System.Drawing.Size(31, 39)
        Me.error_dni.TabIndex = 284
        Me.error_dni.Text = "*"
        Me.error_dni.Visible = False
        '
        'tb_Dni_Cuit
        '
        Me.tb_Dni_Cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Dni_Cuit.Location = New System.Drawing.Point(173, 84)
        Me.tb_Dni_Cuit.Name = "tb_Dni_Cuit"
        Me.tb_Dni_Cuit.Size = New System.Drawing.Size(209, 23)
        Me.tb_Dni_Cuit.TabIndex = 2
        '
        'tx_mail
        '
        Me.tx_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_mail.Location = New System.Drawing.Point(173, 271)
        Me.tx_mail.Name = "tx_mail"
        Me.tx_mail.Size = New System.Drawing.Size(209, 23)
        Me.tx_mail.TabIndex = 9
        Me.tx_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 17)
        Me.Label6.TabIndex = 282
        Me.Label6.Text = "Mail / Correo eletrónico:"
        '
        'Combo_Loc
        '
        Me.Combo_Loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Loc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_Loc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Loc.FormattingEnabled = True
        Me.Combo_Loc.Location = New System.Drawing.Point(173, 245)
        Me.Combo_Loc.Name = "Combo_Loc"
        Me.Combo_Loc.Size = New System.Drawing.Size(209, 24)
        Me.Combo_Loc.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 281
        Me.Label5.Text = "Localidad:"
        '
        'combo_Prov
        '
        Me.combo_Prov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Prov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.combo_Prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_Prov.FormattingEnabled = True
        Me.combo_Prov.Location = New System.Drawing.Point(173, 219)
        Me.combo_Prov.Name = "combo_Prov"
        Me.combo_Prov.Size = New System.Drawing.Size(209, 24)
        Me.combo_Prov.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 280
        Me.Label2.Text = "Provincia:"
        '
        'tx_Cp
        '
        Me.tx_Cp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Cp.Location = New System.Drawing.Point(173, 191)
        Me.tx_Cp.Name = "tx_Cp"
        Me.tx_Cp.Size = New System.Drawing.Size(209, 23)
        Me.tx_Cp.TabIndex = 6
        Me.tx_Cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "Código Postal (CP):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 17)
        Me.Label4.TabIndex = 278
        Me.Label4.Text = "Fantasía / Razón Social:"
        '
        'tx_Fan
        '
        Me.tx_Fan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Fan.Location = New System.Drawing.Point(173, 53)
        Me.tx_Fan.Name = "tx_Fan"
        Me.tx_Fan.Size = New System.Drawing.Size(209, 23)
        Me.tx_Fan.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 277
        Me.Label7.Text = "Tipo de IVA:"
        '
        'Combo_Iva
        '
        Me.Combo_Iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Iva.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_Iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Iva.FormattingEnabled = True
        Me.Combo_Iva.Location = New System.Drawing.Point(173, 110)
        Me.Combo_Iva.Name = "Combo_Iva"
        Me.Combo_Iva.Size = New System.Drawing.Size(209, 24)
        Me.Combo_Iva.TabIndex = 3
        '
        'tx_dir
        '
        Me.tx_dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_dir.Location = New System.Drawing.Point(173, 164)
        Me.tx_dir.Name = "tx_dir"
        Me.tx_dir.Size = New System.Drawing.Size(209, 23)
        Me.tx_dir.TabIndex = 5
        '
        'tx_tel
        '
        Me.tx_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_tel.Location = New System.Drawing.Point(173, 136)
        Me.tx_tel.Name = "tx_tel"
        Me.tx_tel.Size = New System.Drawing.Size(209, 23)
        Me.tx_tel.TabIndex = 4
        '
        'lb_dni
        '
        Me.lb_dni.AutoSize = True
        Me.lb_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni.ForeColor = System.Drawing.Color.Black
        Me.lb_dni.Location = New System.Drawing.Point(6, 87)
        Me.lb_dni.Name = "lb_dni"
        Me.lb_dni.Size = New System.Drawing.Size(98, 17)
        Me.lb_dni.TabIndex = 274
        Me.lb_dni.Text = "DNI / N° CUIT:"
        '
        'lb_mail
        '
        Me.lb_mail.AutoSize = True
        Me.lb_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mail.ForeColor = System.Drawing.Color.Black
        Me.lb_mail.Location = New System.Drawing.Point(6, 139)
        Me.lb_mail.Name = "lb_mail"
        Me.lb_mail.Size = New System.Drawing.Size(146, 17)
        Me.lb_mail.TabIndex = 275
        Me.lb_mail.Text = "Teléfono de contacto:"
        '
        'lb_tel
        '
        Me.lb_tel.AutoSize = True
        Me.lb_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tel.ForeColor = System.Drawing.Color.Black
        Me.lb_tel.Location = New System.Drawing.Point(6, 167)
        Me.lb_tel.Name = "lb_tel"
        Me.lb_tel.Size = New System.Drawing.Size(139, 17)
        Me.lb_tel.TabIndex = 276
        Me.lb_tel.Text = "Dirección / Domicilio:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DG_Detalle)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 421)
        Me.GroupBox2.TabIndex = 251
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de movimientos:"
        '
        'DG_Detalle
        '
        Me.DG_Detalle.AllowUserToAddRows = False
        Me.DG_Detalle.AllowUserToDeleteRows = False
        Me.DG_Detalle.AllowUserToResizeRows = False
        Me.DG_Detalle.AutoGenerateColumns = False
        Me.DG_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Detalle.BackgroundColor = System.Drawing.Color.White
        Me.DG_Detalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn, Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn, Me.DebeDataGridViewTextBoxColumn, Me.HaberDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn})
        Me.DG_Detalle.DataSource = Me.DetalleCtaCteBindingSource
        Me.DG_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Detalle.Location = New System.Drawing.Point(3, 18)
        Me.DG_Detalle.Margin = New System.Windows.Forms.Padding(5)
        Me.DG_Detalle.MultiSelect = False
        Me.DG_Detalle.Name = "DG_Detalle"
        Me.DG_Detalle.ReadOnly = True
        Me.DG_Detalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Detalle.RowHeadersVisible = False
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Detalle.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DG_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Detalle.Size = New System.Drawing.Size(599, 400)
        Me.DG_Detalle.StandardTab = True
        Me.DG_Detalle.TabIndex = 243
        '
        'MovimientosCtaCtefechaDataGridViewTextBoxColumn
        '
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn.DataPropertyName = "MovimientosCtaCte_fecha"
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn.Name = "MovimientosCtaCtefechaDataGridViewTextBoxColumn"
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovimientosCtaCteconceptoDataGridViewTextBoxColumn
        '
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn.DataPropertyName = "MovimientosCtaCte_concepto"
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn.HeaderText = "CONCEPTO"
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn.Name = "MovimientosCtaCteconceptoDataGridViewTextBoxColumn"
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DebeDataGridViewTextBoxColumn
        '
        Me.DebeDataGridViewTextBoxColumn.DataPropertyName = "Debe"
        Me.DebeDataGridViewTextBoxColumn.HeaderText = "DEBE"
        Me.DebeDataGridViewTextBoxColumn.Name = "DebeDataGridViewTextBoxColumn"
        Me.DebeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HaberDataGridViewTextBoxColumn
        '
        Me.HaberDataGridViewTextBoxColumn.DataPropertyName = "Haber"
        Me.HaberDataGridViewTextBoxColumn.HeaderText = "HABER"
        Me.HaberDataGridViewTextBoxColumn.Name = "HaberDataGridViewTextBoxColumn"
        Me.HaberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetalleCtaCteBindingSource
        '
        Me.DetalleCtaCteBindingSource.DataMember = "Detalle_CtaCte"
        Me.DetalleCtaCteBindingSource.DataSource = Me.Cliente_ds
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(726, 485)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total de la deuda:"
        '
        'CtaCteidDataGridViewTextBoxColumn
        '
        Me.CtaCteidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CtaCteidDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_id"
        Me.CtaCteidDataGridViewTextBoxColumn.HeaderText = "Nº Cuenta"
        Me.CtaCteidDataGridViewTextBoxColumn.Name = "CtaCteidDataGridViewTextBoxColumn"
        Me.CtaCteidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIFanDataGridViewTextBoxColumn
        '
        Me.CLIFanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIFanDataGridViewTextBoxColumn.DataPropertyName = "CLI_Fan"
        Me.CLIFanDataGridViewTextBoxColumn.HeaderText = "Fantasia/Razón Social"
        Me.CLIFanDataGridViewTextBoxColumn.Name = "CLIFanDataGridViewTextBoxColumn"
        Me.CLIFanDataGridViewTextBoxColumn.ReadOnly = True
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
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "Dni/Cuit"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.CLItelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLItelDataGridViewTextBoxColumn.DataPropertyName = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.CLItelDataGridViewTextBoxColumn.Name = "CLItelDataGridViewTextBoxColumn"
        Me.CLItelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLImailDataGridViewTextBoxColumn
        '
        Me.CLImailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLImailDataGridViewTextBoxColumn.DataPropertyName = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.CLImailDataGridViewTextBoxColumn.Name = "CLImailDataGridViewTextBoxColumn"
        Me.CLImailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIobservacionesDataGridViewTextBoxColumn
        '
        Me.CLIobservacionesDataGridViewTextBoxColumn.DataPropertyName = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.HeaderText = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.Name = "CLIobservacionesDataGridViewTextBoxColumn"
        Me.CLIobservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIobservacionesDataGridViewTextBoxColumn.Visible = False
        '
        'CtaCteestadoDataGridViewTextBoxColumn
        '
        Me.CtaCteestadoDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_estado"
        Me.CtaCteestadoDataGridViewTextBoxColumn.HeaderText = "CtaCte_estado"
        Me.CtaCteestadoDataGridViewTextBoxColumn.Name = "CtaCteestadoDataGridViewTextBoxColumn"
        Me.CtaCteestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtaCteestadoDataGridViewTextBoxColumn.Visible = False
        '
        'CtaCtefechaaltaDataGridViewTextBoxColumn
        '
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_fechaalta"
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.HeaderText = "CtaCte_fechaalta"
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.Name = "CtaCtefechaaltaDataGridViewTextBoxColumn"
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.Visible = False
        '
        'CtaCtelimitedeudaDataGridViewTextBoxColumn
        '
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_limitedeuda"
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn.HeaderText = "Limite"
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn.Name = "CtaCtelimitedeudaDataGridViewTextBoxColumn"
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CtaCtetotalDataGridViewTextBoxColumn
        '
        Me.CtaCtetotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CtaCtetotalDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_total"
        Me.CtaCtetotalDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.CtaCtetotalDataGridViewTextBoxColumn.Name = "CtaCtetotalDataGridViewTextBoxColumn"
        Me.CtaCtetotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BO_cliente_modificar
        '
        Me.BO_cliente_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_cliente_modificar.Location = New System.Drawing.Point(875, 476)
        Me.BO_cliente_modificar.Margin = New System.Windows.Forms.Padding(5)
        Me.BO_cliente_modificar.Name = "BO_cliente_modificar"
        Me.BO_cliente_modificar.Size = New System.Drawing.Size(165, 53)
        Me.BO_cliente_modificar.TabIndex = 249
        Me.BO_cliente_modificar.Text = "Ver"
        Me.BO_cliente_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_modificar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.pay_wallet
        Me.Button1.Location = New System.Drawing.Point(548, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 74)
        Me.Button1.TabIndex = 256
        Me.Button1.Text = "Registrar pago"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button_comprobante
        '
        Me.Button_comprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_comprobante.Image = Global.Aplicacion.My.Resources.Resources.search_balance
        Me.Button_comprobante.Location = New System.Drawing.Point(200, 461)
        Me.Button_comprobante.Name = "Button_comprobante"
        Me.Button_comprobante.Size = New System.Drawing.Size(168, 74)
        Me.Button_comprobante.TabIndex = 255
        Me.Button_comprobante.Text = "Consultar"
        Me.Button_comprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_comprobante.UseVisualStyleBackColor = True
        '
        'Button_ajustarsaldo
        '
        Me.Button_ajustarsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ajustarsaldo.Image = Global.Aplicacion.My.Resources.Resources.configure
        Me.Button_ajustarsaldo.Location = New System.Drawing.Point(374, 461)
        Me.Button_ajustarsaldo.Name = "Button_ajustarsaldo"
        Me.Button_ajustarsaldo.Size = New System.Drawing.Size(168, 74)
        Me.Button_ajustarsaldo.TabIndex = 254
        Me.Button_ajustarsaldo.Text = "Ajustar Saldo"
        Me.Button_ajustarsaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_ajustarsaldo.UseVisualStyleBackColor = True
        '
        'Button_volver
        '
        Me.Button_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_volver.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button_volver.Location = New System.Drawing.Point(23, 461)
        Me.Button_volver.Name = "Button_volver"
        Me.Button_volver.Size = New System.Drawing.Size(168, 74)
        Me.Button_volver.TabIndex = 253
        Me.Button_volver.Text = "Volver"
        Me.Button_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_volver.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(258, 372)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Aceptar.TabIndex = 12
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'txt_total_deuda
        '
        Me.txt_total_deuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_deuda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_total_deuda.Location = New System.Drawing.Point(909, 480)
        Me.txt_total_deuda.Name = "txt_total_deuda"
        Me.txt_total_deuda.Size = New System.Drawing.Size(143, 30)
        Me.txt_total_deuda.TabIndex = 251
        '
        'Cliente_Cta_Cte_Buscar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1097, 600)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Cliente_Cta_Cte_Buscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Cuentas Corrientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteCtaCteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleCtaCteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BO_cliente_modificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents ClienteCtaCteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DetalleCtaCteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Detalle As System.Windows.Forms.DataGridView
    Friend WithEvents MovimientosCtaCtefechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientosCtaCteconceptoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents error_dni As System.Windows.Forms.Label
    Friend WithEvents error_razonsocial As System.Windows.Forms.Label
    Friend WithEvents tb_Dni_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents tx_mail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Combo_Loc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combo_Prov As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tx_Cp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tx_Fan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Combo_Iva As System.Windows.Forms.ComboBox
    Friend WithEvents tx_dir As System.Windows.Forms.TextBox
    Friend WithEvents tx_tel As System.Windows.Forms.TextBox
    Friend WithEvents lb_dni As System.Windows.Forms.Label
    Friend WithEvents lb_mail As System.Windows.Forms.Label
    Friend WithEvents lb_tel As System.Windows.Forms.Label
    Friend WithEvents Label_fechaalta As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_estado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_limitedeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_ctacte As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button_volver As System.Windows.Forms.Button
    Friend WithEvents Button_ajustarsaldo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button_comprobante As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CtaCteidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIFanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfnacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIobservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCteestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCtefechaaltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCtelimitedeudaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCtetotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_total_deuda As System.Windows.Forms.TextBox
End Class
