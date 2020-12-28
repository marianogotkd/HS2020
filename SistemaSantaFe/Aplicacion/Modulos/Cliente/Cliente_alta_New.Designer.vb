<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_alta_New
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente_alta_New))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DG_Servicio = New System.Windows.Forms.DataGridView()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label_fechaalta = New System.Windows.Forms.Label()
        Me.CheckBox_estado = New System.Windows.Forms.CheckBox()
        Me.txt_limitedeuda = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ctacte = New System.Windows.Forms.TextBox()
        Me.CheckBox_habilitar_ctacte = New System.Windows.Forms.CheckBox()
        Me.error_dni = New System.Windows.Forms.Label()
        Me.error_razonsocial = New System.Windows.Forms.Label()
        Me.tb_Dni_Cuit = New System.Windows.Forms.TextBox()
        Me.tx_mail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Combo_Loc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combo_Prov = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_Cp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_Fan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Combo_Iva = New System.Windows.Forms.ComboBox()
        Me.tx_dir = New System.Windows.Forms.TextBox()
        Me.tx_tel = New System.Windows.Forms.TextBox()
        Me.lb_dni = New System.Windows.Forms.Label()
        Me.lb_mail = New System.Windows.Forms.Label()
        Me.lb_tel = New System.Windows.Forms.Label()
        Me.SucxClieidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClienombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieLocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnBDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClietelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxCliemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxCliedirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieCPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Cancelar.Location = New System.Drawing.Point(154, 444)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Cancelar.TabIndex = 11
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Cancelar, "Cancelar")
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(284, 444)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Aceptar.TabIndex = 10
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Aceptar, "Guardar")
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.add_20x20
        Me.Button1.Location = New System.Drawing.Point(483, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 43)
        Me.Button1.TabIndex = 267
        Me.Button1.Text = "Agregar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Agregar nueva sucursal")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button2.Location = New System.Drawing.Point(307, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 43)
        Me.Button2.TabIndex = 268
        Me.Button2.Text = "Quitar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "Quitar selección")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.CargarDato
        Me.Button3.Location = New System.Drawing.Point(393, 139)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 43)
        Me.Button3.TabIndex = 269
        Me.Button3.Text = "Editar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button3, "Editar selección")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.error_dni)
        Me.GroupBox1.Controls.Add(Me.error_razonsocial)
        Me.GroupBox1.Controls.Add(Me.tb_Dni_Cuit)
        Me.GroupBox1.Controls.Add(Me.btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox1.Controls.Add(Me.tx_mail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Combo_Loc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.combo_Prov)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tx_Cp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tx_Fan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Combo_Iva)
        Me.GroupBox1.Controls.Add(Me.tx_dir)
        Me.GroupBox1.Controls.Add(Me.tx_tel)
        Me.GroupBox1.Controls.Add(Me.lb_dni)
        Me.GroupBox1.Controls.Add(Me.lb_mail)
        Me.GroupBox1.Controls.Add(Me.lb_tel)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 498)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los datos personales del Cliente:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.DG_Servicio)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(583, 190)
        Me.GroupBox3.TabIndex = 266
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sucursales:"
        '
        'DG_Servicio
        '
        Me.DG_Servicio.AllowUserToAddRows = False
        Me.DG_Servicio.AllowUserToDeleteRows = False
        Me.DG_Servicio.AllowUserToResizeRows = False
        Me.DG_Servicio.AutoGenerateColumns = False
        Me.DG_Servicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Servicio.BackgroundColor = System.Drawing.Color.White
        Me.DG_Servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Servicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SucxClieidDataGridViewTextBoxColumn, Me.SucxClienombreDataGridViewTextBoxColumn, Me.SucxClieProvDataGridViewTextBoxColumn, Me.SucxClieLocDataGridViewTextBoxColumn, Me.EnBDDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.SucxClietelDataGridViewTextBoxColumn, Me.SucxCliemailDataGridViewTextBoxColumn, Me.SucxCliedirDataGridViewTextBoxColumn, Me.SucxClieCPDataGridViewTextBoxColumn, Me.item})
        Me.DG_Servicio.DataSource = Me.SucursalesBindingSource
        Me.DG_Servicio.Location = New System.Drawing.Point(17, 22)
        Me.DG_Servicio.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Servicio.MultiSelect = False
        Me.DG_Servicio.Name = "DG_Servicio"
        Me.DG_Servicio.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Servicio.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Servicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Servicio.Size = New System.Drawing.Size(550, 110)
        Me.DG_Servicio.StandardTab = True
        Me.DG_Servicio.TabIndex = 265
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.Cliente_ds
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label_fechaalta)
        Me.GroupBox2.Controls.Add(Me.CheckBox_estado)
        Me.GroupBox2.Controls.Add(Me.txt_limitedeuda)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_ctacte)
        Me.GroupBox2.Controls.Add(Me.CheckBox_habilitar_ctacte)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 337)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(583, 101)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opcional:"
        '
        'Label_fechaalta
        '
        Me.Label_fechaalta.AutoSize = True
        Me.Label_fechaalta.Location = New System.Drawing.Point(386, 28)
        Me.Label_fechaalta.Name = "Label_fechaalta"
        Me.Label_fechaalta.Size = New System.Drawing.Size(93, 16)
        Me.Label_fechaalta.TabIndex = 268
        Me.Label_fechaalta.Text = "Fecha de alta:"
        Me.Label_fechaalta.Visible = False
        '
        'CheckBox_estado
        '
        Me.CheckBox_estado.AutoSize = True
        Me.CheckBox_estado.ForeColor = System.Drawing.Color.Green
        Me.CheckBox_estado.Location = New System.Drawing.Point(292, 27)
        Me.CheckBox_estado.Name = "CheckBox_estado"
        Me.CheckBox_estado.Size = New System.Drawing.Size(64, 20)
        Me.CheckBox_estado.TabIndex = 267
        Me.CheckBox_estado.Text = "Activo"
        Me.CheckBox_estado.UseVisualStyleBackColor = True
        Me.CheckBox_estado.Visible = False
        '
        'txt_limitedeuda
        '
        Me.txt_limitedeuda.Enabled = False
        Me.txt_limitedeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_limitedeuda.Location = New System.Drawing.Point(270, 59)
        Me.txt_limitedeuda.Name = "txt_limitedeuda"
        Me.txt_limitedeuda.Size = New System.Drawing.Size(207, 26)
        Me.txt_limitedeuda.TabIndex = 2
        Me.txt_limitedeuda.Text = "0"
        Me.txt_limitedeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 16)
        Me.Label8.TabIndex = 266
        Me.Label8.Text = "Limite deuda permitida:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nro. Cta.Cte:"
        Me.Label7.Visible = False
        '
        'txt_ctacte
        '
        Me.txt_ctacte.Enabled = False
        Me.txt_ctacte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_ctacte.Location = New System.Drawing.Point(133, 116)
        Me.txt_ctacte.Name = "txt_ctacte"
        Me.txt_ctacte.Size = New System.Drawing.Size(377, 22)
        Me.txt_ctacte.TabIndex = 1
        Me.txt_ctacte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_ctacte.Visible = False
        '
        'CheckBox_habilitar_ctacte
        '
        Me.CheckBox_habilitar_ctacte.AutoSize = True
        Me.CheckBox_habilitar_ctacte.Location = New System.Drawing.Point(56, 27)
        Me.CheckBox_habilitar_ctacte.Name = "CheckBox_habilitar_ctacte"
        Me.CheckBox_habilitar_ctacte.Size = New System.Drawing.Size(182, 20)
        Me.CheckBox_habilitar_ctacte.TabIndex = 0
        Me.CheckBox_habilitar_ctacte.Text = "Habilitar Cuenta Corriente."
        Me.CheckBox_habilitar_ctacte.UseVisualStyleBackColor = True
        '
        'error_dni
        '
        Me.error_dni.AutoSize = True
        Me.error_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_dni.ForeColor = System.Drawing.Color.Red
        Me.error_dni.Location = New System.Drawing.Point(558, 62)
        Me.error_dni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_dni.Name = "error_dni"
        Me.error_dni.Size = New System.Drawing.Size(26, 31)
        Me.error_dni.TabIndex = 264
        Me.error_dni.Text = "*"
        Me.error_dni.Visible = False
        '
        'error_razonsocial
        '
        Me.error_razonsocial.AutoSize = True
        Me.error_razonsocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_razonsocial.ForeColor = System.Drawing.Color.Red
        Me.error_razonsocial.Location = New System.Drawing.Point(558, 30)
        Me.error_razonsocial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_razonsocial.Name = "error_razonsocial"
        Me.error_razonsocial.Size = New System.Drawing.Size(26, 31)
        Me.error_razonsocial.TabIndex = 263
        Me.error_razonsocial.Text = "*"
        Me.error_razonsocial.Visible = False
        '
        'tb_Dni_Cuit
        '
        Me.tb_Dni_Cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Dni_Cuit.Location = New System.Drawing.Point(143, 67)
        Me.tb_Dni_Cuit.Name = "tb_Dni_Cuit"
        Me.tb_Dni_Cuit.Size = New System.Drawing.Size(408, 26)
        Me.tb_Dni_Cuit.TabIndex = 1
        '
        'tx_mail
        '
        Me.tx_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_mail.Location = New System.Drawing.Point(897, 316)
        Me.tx_mail.Name = "tx_mail"
        Me.tx_mail.Size = New System.Drawing.Size(337, 26)
        Me.tx_mail.TabIndex = 8
        Me.tx_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(651, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 20)
        Me.Label6.TabIndex = 262
        Me.Label6.Text = "Mail / Correo eletrónico:"
        '
        'Combo_Loc
        '
        Me.Combo_Loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Loc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_Loc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Loc.FormattingEnabled = True
        Me.Combo_Loc.Location = New System.Drawing.Point(897, 277)
        Me.Combo_Loc.Name = "Combo_Loc"
        Me.Combo_Loc.Size = New System.Drawing.Size(337, 28)
        Me.Combo_Loc.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(651, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 259
        Me.Label5.Text = "Localidad:"
        '
        'combo_Prov
        '
        Me.combo_Prov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Prov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.combo_Prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_Prov.FormattingEnabled = True
        Me.combo_Prov.Location = New System.Drawing.Point(897, 238)
        Me.combo_Prov.Name = "combo_Prov"
        Me.combo_Prov.Size = New System.Drawing.Size(337, 28)
        Me.combo_Prov.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(651, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "Provincia:"
        '
        'tx_Cp
        '
        Me.tx_Cp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Cp.Location = New System.Drawing.Point(897, 201)
        Me.tx_Cp.Name = "tx_Cp"
        Me.tx_Cp.Size = New System.Drawing.Size(337, 26)
        Me.tx_Cp.TabIndex = 5
        Me.tx_Cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(651, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "Código Postal (CP):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 20)
        Me.Label4.TabIndex = 253
        Me.Label4.Text = "Fantasía / Razón Social:"
        '
        'tx_Fan
        '
        Me.tx_Fan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Fan.Location = New System.Drawing.Point(214, 27)
        Me.tx_Fan.Name = "tx_Fan"
        Me.tx_Fan.Size = New System.Drawing.Size(337, 26)
        Me.tx_Fan.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 251
        Me.Label3.Text = "Tipo de IVA:"
        '
        'Combo_Iva
        '
        Me.Combo_Iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Iva.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_Iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Iva.FormattingEnabled = True
        Me.Combo_Iva.Location = New System.Drawing.Point(129, 104)
        Me.Combo_Iva.Name = "Combo_Iva"
        Me.Combo_Iva.Size = New System.Drawing.Size(422, 28)
        Me.Combo_Iva.TabIndex = 2
        '
        'tx_dir
        '
        Me.tx_dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_dir.Location = New System.Drawing.Point(897, 164)
        Me.tx_dir.Name = "tx_dir"
        Me.tx_dir.Size = New System.Drawing.Size(337, 26)
        Me.tx_dir.TabIndex = 4
        '
        'tx_tel
        '
        Me.tx_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_tel.Location = New System.Drawing.Point(897, 127)
        Me.tx_tel.Name = "tx_tel"
        Me.tx_tel.Size = New System.Drawing.Size(337, 26)
        Me.tx_tel.TabIndex = 3
        '
        'lb_dni
        '
        Me.lb_dni.AutoSize = True
        Me.lb_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni.ForeColor = System.Drawing.Color.Black
        Me.lb_dni.Location = New System.Drawing.Point(27, 70)
        Me.lb_dni.Name = "lb_dni"
        Me.lb_dni.Size = New System.Drawing.Size(110, 20)
        Me.lb_dni.TabIndex = 237
        Me.lb_dni.Text = "DNI / N° CUIT:"
        '
        'lb_mail
        '
        Me.lb_mail.AutoSize = True
        Me.lb_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mail.ForeColor = System.Drawing.Color.Black
        Me.lb_mail.Location = New System.Drawing.Point(651, 133)
        Me.lb_mail.Name = "lb_mail"
        Me.lb_mail.Size = New System.Drawing.Size(163, 20)
        Me.lb_mail.TabIndex = 239
        Me.lb_mail.Text = "Teléfono de contacto:"
        '
        'lb_tel
        '
        Me.lb_tel.AutoSize = True
        Me.lb_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tel.ForeColor = System.Drawing.Color.Black
        Me.lb_tel.Location = New System.Drawing.Point(651, 170)
        Me.lb_tel.Name = "lb_tel"
        Me.lb_tel.Size = New System.Drawing.Size(154, 20)
        Me.lb_tel.TabIndex = 241
        Me.lb_tel.Text = "Dirección / Domicilio:"
        '
        'SucxClieidDataGridViewTextBoxColumn
        '
        Me.SucxClieidDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_id"
        Me.SucxClieidDataGridViewTextBoxColumn.HeaderText = "SucxClie_id"
        Me.SucxClieidDataGridViewTextBoxColumn.Name = "SucxClieidDataGridViewTextBoxColumn"
        Me.SucxClieidDataGridViewTextBoxColumn.Visible = False
        '
        'SucxClienombreDataGridViewTextBoxColumn
        '
        Me.SucxClienombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SucxClienombreDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_nombre"
        Me.SucxClienombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.SucxClienombreDataGridViewTextBoxColumn.Name = "SucxClienombreDataGridViewTextBoxColumn"
        Me.SucxClienombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucxClieProvDataGridViewTextBoxColumn
        '
        Me.SucxClieProvDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_Prov"
        Me.SucxClieProvDataGridViewTextBoxColumn.HeaderText = "SucxClie_Prov"
        Me.SucxClieProvDataGridViewTextBoxColumn.Name = "SucxClieProvDataGridViewTextBoxColumn"
        Me.SucxClieProvDataGridViewTextBoxColumn.Visible = False
        '
        'SucxClieLocDataGridViewTextBoxColumn
        '
        Me.SucxClieLocDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_Loc"
        Me.SucxClieLocDataGridViewTextBoxColumn.HeaderText = "SucxClie_Loc"
        Me.SucxClieLocDataGridViewTextBoxColumn.Name = "SucxClieLocDataGridViewTextBoxColumn"
        Me.SucxClieLocDataGridViewTextBoxColumn.Visible = False
        '
        'EnBDDataGridViewTextBoxColumn
        '
        Me.EnBDDataGridViewTextBoxColumn.DataPropertyName = "EnBD"
        Me.EnBDDataGridViewTextBoxColumn.HeaderText = "EnBD"
        Me.EnBDDataGridViewTextBoxColumn.Name = "EnBDDataGridViewTextBoxColumn"
        Me.EnBDDataGridViewTextBoxColumn.Visible = False
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucxClietelDataGridViewTextBoxColumn
        '
        Me.SucxClietelDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_tel"
        Me.SucxClietelDataGridViewTextBoxColumn.HeaderText = "SucxClie_tel"
        Me.SucxClietelDataGridViewTextBoxColumn.Name = "SucxClietelDataGridViewTextBoxColumn"
        Me.SucxClietelDataGridViewTextBoxColumn.Visible = False
        '
        'SucxCliemailDataGridViewTextBoxColumn
        '
        Me.SucxCliemailDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_mail"
        Me.SucxCliemailDataGridViewTextBoxColumn.HeaderText = "SucxClie_mail"
        Me.SucxCliemailDataGridViewTextBoxColumn.Name = "SucxCliemailDataGridViewTextBoxColumn"
        Me.SucxCliemailDataGridViewTextBoxColumn.Visible = False
        '
        'SucxCliedirDataGridViewTextBoxColumn
        '
        Me.SucxCliedirDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_dir"
        Me.SucxCliedirDataGridViewTextBoxColumn.HeaderText = "SucxClie_dir"
        Me.SucxCliedirDataGridViewTextBoxColumn.Name = "SucxCliedirDataGridViewTextBoxColumn"
        Me.SucxCliedirDataGridViewTextBoxColumn.Visible = False
        '
        'SucxClieCPDataGridViewTextBoxColumn
        '
        Me.SucxClieCPDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_CP"
        Me.SucxClieCPDataGridViewTextBoxColumn.HeaderText = "SucxClie_CP"
        Me.SucxClieCPDataGridViewTextBoxColumn.Name = "SucxClieCPDataGridViewTextBoxColumn"
        Me.SucxClieCPDataGridViewTextBoxColumn.Visible = False
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = "item"
        Me.item.Name = "item"
        Me.item.Width = 40
        '
        'Cliente_alta_New
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 514)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cliente_alta_New"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DG_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tx_Cp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tx_Fan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Combo_Iva As System.Windows.Forms.ComboBox
    Friend WithEvents tx_dir As System.Windows.Forms.TextBox
    Friend WithEvents tx_tel As System.Windows.Forms.TextBox
    Friend WithEvents lb_dni As System.Windows.Forms.Label
    Friend WithEvents lb_mail As System.Windows.Forms.Label
    Friend WithEvents lb_tel As System.Windows.Forms.Label
    Friend WithEvents Combo_Loc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combo_Prov As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tx_mail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents tb_Dni_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents error_dni As System.Windows.Forms.Label
    Friend WithEvents error_razonsocial As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_ctacte As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox_habilitar_ctacte As System.Windows.Forms.CheckBox
    Friend WithEvents txt_limitedeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label_fechaalta As System.Windows.Forms.Label
    Friend WithEvents CheckBox_estado As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DG_Servicio As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents SucxClieidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClienombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieProvDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieLocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnBDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClietelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxCliemailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxCliedirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieCPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
