<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicio_nuevo
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_impuesto_aplicado = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_iva = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt_desc_pesos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_desc_porc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Rev = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_REP = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DG_empleados = New System.Windows.Forms.DataGridView()
        Me.EmpleadoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuadrillaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoynombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoxCuadrillaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosxcuadrillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Servicio_DS = New Aplicacion.Servicio_DS()
        Me.Combo_cuadrilla = New System.Windows.Forms.ComboBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Button_finalizar = New System.Windows.Forms.Button()
        Me.Label_Estado = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label_Cod = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_imprimir = New System.Windows.Forms.Button()
        Me.lbl_errNOM = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_sucursal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_tel = New System.Windows.Forms.TextBox()
        Me.TextBox_dir = New System.Windows.Forms.TextBox()
        Me.lb_error_marca = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_dni = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_diag = New System.Windows.Forms.TextBox()
        Me.lb_error_modelo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_equipo = New System.Windows.Forms.TextBox()
        Me.lb_error_nombre = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label_error_grilla = New System.Windows.Forms.Label()
        Me.btn_eliminar_seleccion = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cod_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdxSuc_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ServicioProdDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_codprod = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox_Repuesto = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DG_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosxcuadrillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servicio_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioProdDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.GroupBox15)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Rev)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_REP)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.Button_finalizar)
        Me.GroupBox1.Controls.Add(Me.Label_Estado)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label_Cod)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 610)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servicios de Ventas"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.txt_impuesto_aplicado)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txt_subtotal)
        Me.Panel1.Controls.Add(Me.txt_descuento)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(400, 517)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 91)
        Me.Panel1.TabIndex = 261
        '
        'txt_impuesto_aplicado
        '
        Me.txt_impuesto_aplicado.BackColor = System.Drawing.SystemColors.Info
        Me.txt_impuesto_aplicado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_impuesto_aplicado.Location = New System.Drawing.Point(208, 57)
        Me.txt_impuesto_aplicado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_impuesto_aplicado.Name = "txt_impuesto_aplicado"
        Me.txt_impuesto_aplicado.ReadOnly = True
        Me.txt_impuesto_aplicado.Size = New System.Drawing.Size(112, 19)
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
        Me.Label24.Size = New System.Drawing.Size(122, 13)
        Me.Label24.TabIndex = 273
        Me.Label24.Text = "IMPUESTO APLICADO:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(149, 13)
        Me.Label15.TabIndex = 269
        Me.Label15.Text = "SUBTOTAL DE ARTICULOS:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(208, 7)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(112, 19)
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
        Me.txt_descuento.Size = New System.Drawing.Size(112, 19)
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
        Me.Label23.Size = New System.Drawing.Size(77, 13)
        Me.Label23.TabIndex = 271
        Me.Label23.Text = "DESCUENTO:"
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox15.Controls.Add(Me.ComboBox_iva)
        Me.GroupBox15.Controls.Add(Me.Label19)
        Me.GroupBox15.Location = New System.Drawing.Point(218, 521)
        Me.GroupBox15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox15.Size = New System.Drawing.Size(143, 79)
        Me.GroupBox15.TabIndex = 260
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
        Me.ComboBox_iva.Size = New System.Drawing.Size(64, 28)
        Me.ComboBox_iva.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "IVA (%):"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox9.Controls.Add(Me.txt_desc_pesos)
        Me.GroupBox9.Controls.Add(Me.Label11)
        Me.GroupBox9.Controls.Add(Me.txt_desc_porc)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(10, 521)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Size = New System.Drawing.Size(202, 79)
        Me.GroupBox9.TabIndex = 22
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
        Me.txt_desc_pesos.Size = New System.Drawing.Size(65, 19)
        Me.txt_desc_pesos.TabIndex = 14
        Me.txt_desc_pesos.Text = "0"
        Me.txt_desc_pesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Descuento (%):"
        '
        'txt_desc_porc
        '
        Me.txt_desc_porc.BackColor = System.Drawing.SystemColors.Info
        Me.txt_desc_porc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc_porc.Location = New System.Drawing.Point(117, 20)
        Me.txt_desc_porc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_desc_porc.Name = "txt_desc_porc"
        Me.txt_desc_porc.Size = New System.Drawing.Size(65, 19)
        Me.txt_desc_porc.TabIndex = 13
        Me.txt_desc_porc.Text = "0"
        Me.txt_desc_porc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Descuento ($):"
        '
        'DateTimePicker_Rev
        '
        Me.DateTimePicker_Rev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Rev.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Rev.Location = New System.Drawing.Point(178, 484)
        Me.DateTimePicker_Rev.Name = "DateTimePicker_Rev"
        Me.DateTimePicker_Rev.Size = New System.Drawing.Size(121, 22)
        Me.DateTimePicker_Rev.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.floppy_disk30x30
        Me.Button2.Location = New System.Drawing.Point(880, 548)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 43)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Reparado"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "Generar orden de trabajo")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txt_total)
        Me.GroupBox5.Location = New System.Drawing.Point(773, 476)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(347, 64)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Totales"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 29)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 25)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "TOTAL:"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.SystemColors.Info
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(157, 24)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(185, 30)
        Me.txt_total.TabIndex = 275
        Me.txt_total.TabStop = False
        Me.txt_total.Text = "0"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker_REP
        '
        Me.DateTimePicker_REP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_REP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_REP.Location = New System.Drawing.Point(545, 484)
        Me.DateTimePicker_REP.Name = "DateTimePicker_REP"
        Me.DateTimePicker_REP.Size = New System.Drawing.Size(121, 22)
        Me.DateTimePicker_REP.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(358, 484)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fecha de Reparacion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 484)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Fecha de Revisión"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DG_empleados)
        Me.GroupBox7.Controls.Add(Me.Combo_cuadrilla)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(774, 212)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(347, 258)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Seleccionar cuadrilla:"
        '
        'DG_empleados
        '
        Me.DG_empleados.AllowUserToAddRows = False
        Me.DG_empleados.AllowUserToDeleteRows = False
        Me.DG_empleados.AllowUserToResizeRows = False
        Me.DG_empleados.AutoGenerateColumns = False
        Me.DG_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_empleados.BackgroundColor = System.Drawing.Color.White
        Me.DG_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpleadoidDataGridViewTextBoxColumn, Me.CuadrillaidDataGridViewTextBoxColumn, Me.ApellidoynombreDataGridViewTextBoxColumn, Me.EmpleadoxCuadrillaidDataGridViewTextBoxColumn})
        Me.DG_empleados.DataSource = Me.EmpleadosxcuadrillaBindingSource
        Me.DG_empleados.Location = New System.Drawing.Point(10, 59)
        Me.DG_empleados.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_empleados.MultiSelect = False
        Me.DG_empleados.Name = "DG_empleados"
        Me.DG_empleados.ReadOnly = True
        Me.DG_empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_empleados.RowHeadersVisible = False
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_empleados.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DG_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DG_empleados.Size = New System.Drawing.Size(330, 190)
        Me.DG_empleados.StandardTab = True
        Me.DG_empleados.TabIndex = 241
        '
        'EmpleadoidDataGridViewTextBoxColumn
        '
        Me.EmpleadoidDataGridViewTextBoxColumn.DataPropertyName = "empleado_id"
        Me.EmpleadoidDataGridViewTextBoxColumn.HeaderText = "empleado_id"
        Me.EmpleadoidDataGridViewTextBoxColumn.Name = "EmpleadoidDataGridViewTextBoxColumn"
        Me.EmpleadoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpleadoidDataGridViewTextBoxColumn.Visible = False
        '
        'CuadrillaidDataGridViewTextBoxColumn
        '
        Me.CuadrillaidDataGridViewTextBoxColumn.DataPropertyName = "Cuadrilla_id"
        Me.CuadrillaidDataGridViewTextBoxColumn.HeaderText = "Cuadrilla_id"
        Me.CuadrillaidDataGridViewTextBoxColumn.Name = "CuadrillaidDataGridViewTextBoxColumn"
        Me.CuadrillaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuadrillaidDataGridViewTextBoxColumn.Visible = False
        '
        'ApellidoynombreDataGridViewTextBoxColumn
        '
        Me.ApellidoynombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ApellidoynombreDataGridViewTextBoxColumn.DataPropertyName = "apellidoynombre"
        Me.ApellidoynombreDataGridViewTextBoxColumn.HeaderText = "Empleados"
        Me.ApellidoynombreDataGridViewTextBoxColumn.Name = "ApellidoynombreDataGridViewTextBoxColumn"
        Me.ApellidoynombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadoxCuadrillaidDataGridViewTextBoxColumn
        '
        Me.EmpleadoxCuadrillaidDataGridViewTextBoxColumn.DataPropertyName = "Empleado_x_Cuadrilla_id"
        Me.EmpleadoxCuadrillaidDataGridViewTextBoxColumn.HeaderText = "Empleado_x_Cuadrilla_id"
        Me.EmpleadoxCuadrillaidDataGridViewTextBoxColumn.Name = "EmpleadoxCuadrillaidDataGridViewTextBoxColumn"
        Me.EmpleadoxCuadrillaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpleadoxCuadrillaidDataGridViewTextBoxColumn.Visible = False
        '
        'EmpleadosxcuadrillaBindingSource
        '
        Me.EmpleadosxcuadrillaBindingSource.DataMember = "Empleados_x_cuadrilla"
        Me.EmpleadosxcuadrillaBindingSource.DataSource = Me.Servicio_DS
        '
        'Servicio_DS
        '
        Me.Servicio_DS.DataSetName = "Servicio_DS"
        Me.Servicio_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Combo_cuadrilla
        '
        Me.Combo_cuadrilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_cuadrilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_cuadrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Combo_cuadrilla.FormattingEnabled = True
        Me.Combo_cuadrilla.Location = New System.Drawing.Point(10, 21)
        Me.Combo_cuadrilla.Name = "Combo_cuadrilla"
        Me.Combo_cuadrilla.Size = New System.Drawing.Size(330, 24)
        Me.Combo_cuadrilla.TabIndex = 244
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.floppy_disk30x30
        Me.btn_guardar.Location = New System.Drawing.Point(1004, 548)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(116, 43)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Generar Orden"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_guardar, "Generar orden de trabajo")
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_cancelar.Location = New System.Drawing.Point(841, 13)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 43)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_cancelar, "Cancelar")
        Me.btn_cancelar.UseVisualStyleBackColor = True
        Me.btn_cancelar.Visible = False
        '
        'Button_finalizar
        '
        Me.Button_finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_finalizar.Image = Global.Aplicacion.My.Resources.Resources.Guardar2
        Me.Button_finalizar.Location = New System.Drawing.Point(777, 548)
        Me.Button_finalizar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_finalizar.Name = "Button_finalizar"
        Me.Button_finalizar.Size = New System.Drawing.Size(95, 43)
        Me.Button_finalizar.TabIndex = 6
        Me.Button_finalizar.Text = "Finalizar y cobrar"
        Me.Button_finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_finalizar, "Finalizar Servicio realizado")
        Me.Button_finalizar.UseVisualStyleBackColor = True
        '
        'Label_Estado
        '
        Me.Label_Estado.AutoSize = True
        Me.Label_Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label_Estado.ForeColor = System.Drawing.Color.Red
        Me.Label_Estado.Location = New System.Drawing.Point(14, 21)
        Me.Label_Estado.Name = "Label_Estado"
        Me.Label_Estado.Size = New System.Drawing.Size(51, 17)
        Me.Label_Estado.TabIndex = 6
        Me.Label_Estado.Text = "estado"
        Me.Label_Estado.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(980, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 5
        Me.DateTimePicker1.Visible = False
        '
        'Label_Cod
        '
        Me.Label_Cod.AutoSize = True
        Me.Label_Cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Cod.Location = New System.Drawing.Point(211, 21)
        Me.Label_Cod.Name = "Label_Cod"
        Me.Label_Cod.Size = New System.Drawing.Size(39, 13)
        Me.Label_Cod.TabIndex = 4
        Me.Label_Cod.Text = "Label2"
        Me.Label_Cod.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Revisión Número:"
        Me.Label1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_imprimir)
        Me.GroupBox2.Controls.Add(Me.lbl_errNOM)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_sucursal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox_tel)
        Me.GroupBox2.Controls.Add(Me.TextBox_dir)
        Me.GroupBox2.Controls.Add(Me.lb_error_marca)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox_dni)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox_Nombre)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1113, 86)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente "
        '
        'Button_imprimir
        '
        Me.Button_imprimir.BackColor = System.Drawing.SystemColors.Info
        Me.Button_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_imprimir.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button_imprimir.Location = New System.Drawing.Point(942, 26)
        Me.Button_imprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_imprimir.Name = "Button_imprimir"
        Me.Button_imprimir.Size = New System.Drawing.Size(116, 43)
        Me.Button_imprimir.TabIndex = 315
        Me.Button_imprimir.Text = "Imprimir orden"
        Me.Button_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_imprimir.UseVisualStyleBackColor = False
        Me.Button_imprimir.Visible = False
        '
        'lbl_errNOM
        '
        Me.lbl_errNOM.AutoSize = True
        Me.lbl_errNOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_errNOM.ForeColor = System.Drawing.Color.Red
        Me.lbl_errNOM.Location = New System.Drawing.Point(1067, 14)
        Me.lbl_errNOM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_errNOM.Name = "lbl_errNOM"
        Me.lbl_errNOM.Size = New System.Drawing.Size(26, 31)
        Me.lbl_errNOM.TabIndex = 22
        Me.lbl_errNOM.Text = "*"
        Me.lbl_errNOM.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Buscar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(915, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 53)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Buscar Cliente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txt_sucursal
        '
        Me.txt_sucursal.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txt_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sucursal.Location = New System.Drawing.Point(699, 55)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Size = New System.Drawing.Size(166, 22)
        Me.txt_sucursal.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Dirección:"
        '
        'TextBox_tel
        '
        Me.TextBox_tel.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TextBox_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_tel.Location = New System.Drawing.Point(490, 56)
        Me.TextBox_tel.Name = "TextBox_tel"
        Me.TextBox_tel.ReadOnly = True
        Me.TextBox_tel.Size = New System.Drawing.Size(137, 22)
        Me.TextBox_tel.TabIndex = 3
        '
        'TextBox_dir
        '
        Me.TextBox_dir.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TextBox_dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_dir.Location = New System.Drawing.Point(93, 56)
        Me.TextBox_dir.Name = "TextBox_dir"
        Me.TextBox_dir.ReadOnly = True
        Me.TextBox_dir.Size = New System.Drawing.Size(241, 22)
        Me.TextBox_dir.TabIndex = 2
        '
        'lb_error_marca
        '
        Me.lb_error_marca.AutoSize = True
        Me.lb_error_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error_marca.ForeColor = System.Drawing.Color.Red
        Me.lb_error_marca.Location = New System.Drawing.Point(872, 55)
        Me.lb_error_marca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_error_marca.Name = "lb_error_marca"
        Me.lb_error_marca.Size = New System.Drawing.Size(26, 31)
        Me.lb_error_marca.TabIndex = 19
        Me.lb_error_marca.Text = "*"
        Me.lb_error_marca.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(419, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Teléfono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(633, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Sucursal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DNI / CUIT:"
        '
        'TextBox_dni
        '
        Me.TextBox_dni.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TextBox_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_dni.Location = New System.Drawing.Point(93, 23)
        Me.TextBox_dni.Name = "TextBox_dni"
        Me.TextBox_dni.ReadOnly = True
        Me.TextBox_dni.Size = New System.Drawing.Size(241, 22)
        Me.TextBox_dni.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre / R. Social:"
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TextBox_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nombre.Location = New System.Drawing.Point(490, 23)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.ReadOnly = True
        Me.TextBox_Nombre.Size = New System.Drawing.Size(375, 22)
        Me.TextBox_Nombre.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txt_diag)
        Me.GroupBox3.Controls.Add(Me.lb_error_modelo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_equipo)
        Me.GroupBox3.Controls.Add(Me.lb_error_nombre)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1114, 68)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Equipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Diagnostico"
        '
        'txt_diag
        '
        Me.txt_diag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_diag.Location = New System.Drawing.Point(400, 14)
        Me.txt_diag.Multiline = True
        Me.txt_diag.Name = "txt_diag"
        Me.txt_diag.Size = New System.Drawing.Size(674, 48)
        Me.txt_diag.TabIndex = 0
        '
        'lb_error_modelo
        '
        Me.lb_error_modelo.AutoSize = True
        Me.lb_error_modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error_modelo.ForeColor = System.Drawing.Color.Red
        Me.lb_error_modelo.Location = New System.Drawing.Point(1081, 10)
        Me.lb_error_modelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_error_modelo.Name = "lb_error_modelo"
        Me.lb_error_modelo.Size = New System.Drawing.Size(26, 31)
        Me.lb_error_modelo.TabIndex = 18
        Me.lb_error_modelo.Text = "*"
        Me.lb_error_modelo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Equipo"
        '
        'txt_equipo
        '
        Me.txt_equipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_equipo.Location = New System.Drawing.Point(63, 25)
        Me.txt_equipo.Name = "txt_equipo"
        Me.txt_equipo.Size = New System.Drawing.Size(210, 22)
        Me.txt_equipo.TabIndex = 0
        '
        'lb_error_nombre
        '
        Me.lb_error_nombre.AutoSize = True
        Me.lb_error_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error_nombre.ForeColor = System.Drawing.Color.Red
        Me.lb_error_nombre.Location = New System.Drawing.Point(280, 15)
        Me.lb_error_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_error_nombre.Name = "lb_error_nombre"
        Me.lb_error_nombre.Size = New System.Drawing.Size(26, 31)
        Me.lb_error_nombre.TabIndex = 18
        Me.lb_error_nombre.Text = "*"
        Me.lb_error_nombre.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label_error_grilla)
        Me.GroupBox4.Controls.Add(Me.btn_eliminar_seleccion)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TextBox_codprod)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.TextBox_Repuesto)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 215)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(760, 258)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "REPUESTOS / Ingrese codigo interno para buscar (F1 busqueda avanzada)"
        '
        'Label_error_grilla
        '
        Me.Label_error_grilla.AutoSize = True
        Me.Label_error_grilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_error_grilla.ForeColor = System.Drawing.Color.Red
        Me.Label_error_grilla.Location = New System.Drawing.Point(162, 25)
        Me.Label_error_grilla.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_error_grilla.Name = "Label_error_grilla"
        Me.Label_error_grilla.Size = New System.Drawing.Size(26, 31)
        Me.Label_error_grilla.TabIndex = 272
        Me.Label_error_grilla.Text = "*"
        Me.Label_error_grilla.Visible = False
        '
        'btn_eliminar_seleccion
        '
        Me.btn_eliminar_seleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_seleccion.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_eliminar_seleccion.Location = New System.Drawing.Point(120, 209)
        Me.btn_eliminar_seleccion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar_seleccion.Name = "btn_eliminar_seleccion"
        Me.btn_eliminar_seleccion.Size = New System.Drawing.Size(104, 41)
        Me.btn_eliminar_seleccion.TabIndex = 271
        Me.btn_eliminar_seleccion.Text = "Eliminar"
        Me.btn_eliminar_seleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_eliminar_seleccion, "Eliminar productos seleccionados")
        Me.btn_eliminar_seleccion.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.Borrar
        Me.Button3.Location = New System.Drawing.Point(9, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 41)
        Me.Button3.TabIndex = 5
        Me.Button3.TabStop = False
        Me.Button3.Text = "Limpiar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button3, "Limpiar listado de Repuestos")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod_prod, Me.ProdxSuc_ID, Me.Descripcion, Me.Stock, Me.Cantidad, Me.Costo, Me.subtotal, Me.prod_id, Me.Column1})
        Me.DataGridView1.DataSource = Me.ServicioProdDSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 59)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.Size = New System.Drawing.Size(736, 143)
        Me.DataGridView1.TabIndex = 1
        '
        'Cod_prod
        '
        Me.Cod_prod.DataPropertyName = "Cod_prod"
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info
        Me.Cod_prod.DefaultCellStyle = DataGridViewCellStyle8
        Me.Cod_prod.FillWeight = 76.39836!
        Me.Cod_prod.HeaderText = "Codigo"
        Me.Cod_prod.Name = "Cod_prod"
        Me.Cod_prod.ReadOnly = True
        Me.Cod_prod.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cod_prod.Width = 80
        '
        'ProdxSuc_ID
        '
        Me.ProdxSuc_ID.DataPropertyName = "ProdxSuc_ID"
        Me.ProdxSuc_ID.HeaderText = "ProdxSuc_ID"
        Me.ProdxSuc_ID.Name = "ProdxSuc_ID"
        Me.ProdxSuc_ID.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Info
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle9
        Me.Descripcion.FillWeight = 194.224!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 203
        '
        'Stock
        '
        Me.Stock.DataPropertyName = "Stock"
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Info
        Me.Stock.DefaultCellStyle = DataGridViewCellStyle10
        Me.Stock.FillWeight = 83.94859!
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        Me.Stock.Width = 70
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.FillWeight = 78.17754!
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 50
        '
        'Costo
        '
        Me.Costo.DataPropertyName = "Costo"
        Me.Costo.FillWeight = 104.2252!
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.Width = 109
        '
        'subtotal
        '
        Me.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subtotal.DataPropertyName = "subtotal"
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Info
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle11
        Me.subtotal.FillWeight = 139.8219!
        Me.subtotal.HeaderText = "SubTotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'prod_id
        '
        Me.prod_id.DataPropertyName = "prod_id"
        Me.prod_id.HeaderText = "prod_id"
        Me.prod_id.Name = "prod_id"
        Me.prod_id.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.FillWeight = 23.20432!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'ServicioProdDSBindingSource
        '
        Me.ServicioProdDSBindingSource.DataMember = "Servicio_Prod_DS"
        Me.ServicioProdDSBindingSource.DataSource = Me.Servicio_DS
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Codigo:"
        '
        'TextBox_codprod
        '
        Me.TextBox_codprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_codprod.Location = New System.Drawing.Point(55, 25)
        Me.TextBox_codprod.Name = "TextBox_codprod"
        Me.TextBox_codprod.Size = New System.Drawing.Size(100, 19)
        Me.TextBox_codprod.TabIndex = 0
        Me.TextBox_codprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(360, 206)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(153, 17)
        Me.Label20.TabIndex = 269
        Me.Label20.Text = "TOTAL REPUESTO:"
        '
        'TextBox_Repuesto
        '
        Me.TextBox_Repuesto.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_Repuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Repuesto.Location = New System.Drawing.Point(547, 207)
        Me.TextBox_Repuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Repuesto.Name = "TextBox_Repuesto"
        Me.TextBox_Repuesto.ReadOnly = True
        Me.TextBox_Repuesto.Size = New System.Drawing.Size(198, 23)
        Me.TextBox_Repuesto.TabIndex = 270
        Me.TextBox_Repuesto.TabStop = False
        Me.TextBox_Repuesto.Text = "0"
        Me.TextBox_Repuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Servicio_nuevo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1160, 625)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "Servicio_nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Servicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DG_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosxcuadrillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servicio_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioProdDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Cod As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_dni As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_dir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_diag As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_equipo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox_codprod As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Repuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioProdDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Servicio_DS As Aplicacion.Servicio_DS
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label_Estado As System.Windows.Forms.Label
    Friend WithEvents Button_finalizar As System.Windows.Forms.Button
    Friend WithEvents lb_error_nombre As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btn_eliminar_seleccion As System.Windows.Forms.Button
    Friend WithEvents lb_error_modelo As System.Windows.Forms.Label
    Friend WithEvents lb_error_marca As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker_Rev As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_REP As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_errNOM As System.Windows.Forms.Label
    Friend WithEvents Combo_cuadrilla As System.Windows.Forms.ComboBox
    Friend WithEvents DG_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents EmpleadoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuadrillaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoynombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoxCuadrillaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadosxcuadrillaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Cod_prod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdxSuc_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents prod_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button_imprimir As System.Windows.Forms.Button
    Friend WithEvents Label_error_grilla As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_desc_pesos As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_desc_porc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_impuesto_aplicado As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents txt_descuento As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox_iva As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
