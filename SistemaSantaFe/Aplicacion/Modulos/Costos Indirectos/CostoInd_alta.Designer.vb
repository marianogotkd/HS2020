<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostoInd_alta
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_desc = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel_dia = New System.Windows.Forms.Panel()
        Me.btn_Dia = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_costo_Total_Dia = New System.Windows.Forms.TextBox()
        Me.tb_dia_dia = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton_dia = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_horas_hora = New System.Windows.Forms.NumericUpDown()
        Me.tb_costo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel_hora = New System.Windows.Forms.Panel()
        Me.tb_hora_dia = New System.Windows.Forms.NumericUpDown()
        Me.btn_hora = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton_HORA = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel_fijo = New System.Windows.Forms.Panel()
        Me.btn_fijo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_fijo = New System.Windows.Forms.TextBox()
        Me.RadioButton_Fijo = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmpleadoapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadonomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadodniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoRemuneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoremuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_empleados = New Aplicacion.ds_empleados()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tb_multi = New System.Windows.Forms.NumericUpDown()
        Me.tb_totalEmp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_empCost = New System.Windows.Forms.TextBox()
        Me.btn_emp = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Total_Grilla = New System.Windows.Forms.TextBox()
        Me.tb_titulo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel_dia.SuspendLayout()
        CType(Me.tb_dia_dia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_horas_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel_hora.SuspendLayout()
        CType(Me.tb_hora_dia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel_fijo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoremuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.tb_multi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1032, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripcion"
        '
        'tb_desc
        '
        Me.tb_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_desc.Location = New System.Drawing.Point(88, 82)
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.Size = New System.Drawing.Size(238, 26)
        Me.tb_desc.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel_dia)
        Me.GroupBox1.Controls.Add(Me.RadioButton_dia)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 270)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costo Por Dia"
        '
        'Panel_dia
        '
        Me.Panel_dia.Controls.Add(Me.btn_Dia)
        Me.Panel_dia.Controls.Add(Me.Label5)
        Me.Panel_dia.Controls.Add(Me.Label2)
        Me.Panel_dia.Controls.Add(Me.tb_costo_Total_Dia)
        Me.Panel_dia.Controls.Add(Me.tb_dia_dia)
        Me.Panel_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_dia.Location = New System.Drawing.Point(9, 46)
        Me.Panel_dia.Name = "Panel_dia"
        Me.Panel_dia.Size = New System.Drawing.Size(234, 214)
        Me.Panel_dia.TabIndex = 36
        '
        'btn_Dia
        '
        Me.btn_Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Dia.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_Dia.Location = New System.Drawing.Point(60, 156)
        Me.btn_Dia.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Dia.Name = "btn_Dia"
        Me.btn_Dia.Size = New System.Drawing.Size(116, 43)
        Me.btn_Dia.TabIndex = 34
        Me.btn_Dia.Text = "Agregar"
        Me.btn_Dia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Dia.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Cantidad de Dias de Trabajo"
        '
        'tb_costo_Total_Dia
        '
        Me.tb_costo_Total_Dia.BackColor = System.Drawing.SystemColors.Info
        Me.tb_costo_Total_Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_costo_Total_Dia.Location = New System.Drawing.Point(44, 121)
        Me.tb_costo_Total_Dia.Name = "tb_costo_Total_Dia"
        Me.tb_costo_Total_Dia.ReadOnly = True
        Me.tb_costo_Total_Dia.Size = New System.Drawing.Size(165, 26)
        Me.tb_costo_Total_Dia.TabIndex = 29
        '
        'tb_dia_dia
        '
        Me.tb_dia_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dia_dia.Location = New System.Drawing.Point(149, 14)
        Me.tb_dia_dia.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.tb_dia_dia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tb_dia_dia.Name = "tb_dia_dia"
        Me.tb_dia_dia.Size = New System.Drawing.Size(46, 26)
        Me.tb_dia_dia.TabIndex = 27
        Me.tb_dia_dia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RadioButton_dia
        '
        Me.RadioButton_dia.AutoSize = True
        Me.RadioButton_dia.Checked = True
        Me.RadioButton_dia.Location = New System.Drawing.Point(9, 20)
        Me.RadioButton_dia.Name = "RadioButton_dia"
        Me.RadioButton_dia.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton_dia.TabIndex = 35
        Me.RadioButton_dia.TabStop = True
        Me.RadioButton_dia.Text = "Seleccionar"
        Me.RadioButton_dia.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Cantidad de Horas de Trabajo"
        '
        'tb_horas_hora
        '
        Me.tb_horas_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_horas_hora.Location = New System.Drawing.Point(167, 61)
        Me.tb_horas_hora.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.tb_horas_hora.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tb_horas_hora.Name = "tb_horas_hora"
        Me.tb_horas_hora.Size = New System.Drawing.Size(46, 26)
        Me.tb_horas_hora.TabIndex = 24
        Me.tb_horas_hora.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tb_costo
        '
        Me.tb_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_costo.Location = New System.Drawing.Point(379, 80)
        Me.tb_costo.Name = "tb_costo"
        Me.tb_costo.Size = New System.Drawing.Size(112, 26)
        Me.tb_costo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Costo"
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.floppy_disk30x30
        Me.btn_guardar.Location = New System.Drawing.Point(13, 549)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(116, 43)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.Text = "Guardar Cambios"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel_hora)
        Me.GroupBox2.Controls.Add(Me.RadioButton_HORA)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 270)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Costo Por Hora"
        '
        'Panel_hora
        '
        Me.Panel_hora.Controls.Add(Me.tb_hora_dia)
        Me.Panel_hora.Controls.Add(Me.btn_hora)
        Me.Panel_hora.Controls.Add(Me.Label7)
        Me.Panel_hora.Controls.Add(Me.Label6)
        Me.Panel_hora.Controls.Add(Me.Label3)
        Me.Panel_hora.Controls.Add(Me.tb_horas_hora)
        Me.Panel_hora.Enabled = False
        Me.Panel_hora.Location = New System.Drawing.Point(11, 45)
        Me.Panel_hora.Name = "Panel_hora"
        Me.Panel_hora.Size = New System.Drawing.Size(275, 215)
        Me.Panel_hora.TabIndex = 37
        '
        'tb_hora_dia
        '
        Me.tb_hora_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_hora_dia.Location = New System.Drawing.Point(167, 16)
        Me.tb_hora_dia.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.tb_hora_dia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tb_hora_dia.Name = "tb_hora_dia"
        Me.tb_hora_dia.Size = New System.Drawing.Size(46, 26)
        Me.tb_hora_dia.TabIndex = 35
        Me.tb_hora_dia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_hora
        '
        Me.btn_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hora.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_hora.Location = New System.Drawing.Point(80, 157)
        Me.btn_hora.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_hora.Name = "btn_hora"
        Me.btn_hora.Size = New System.Drawing.Size(116, 43)
        Me.btn_hora.TabIndex = 35
        Me.btn_hora.Text = "Agregar"
        Me.btn_hora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_hora.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Cantidad de Dias de Trabajo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Total"
        '
        'RadioButton_HORA
        '
        Me.RadioButton_HORA.AutoSize = True
        Me.RadioButton_HORA.Location = New System.Drawing.Point(17, 20)
        Me.RadioButton_HORA.Name = "RadioButton_HORA"
        Me.RadioButton_HORA.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton_HORA.TabIndex = 36
        Me.RadioButton_HORA.TabStop = True
        Me.RadioButton_HORA.Text = "Seleccionar"
        Me.RadioButton_HORA.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel_fijo)
        Me.GroupBox3.Controls.Add(Me.RadioButton_Fijo)
        Me.GroupBox3.Location = New System.Drawing.Point(579, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(247, 278)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Costo Fijo"
        '
        'Panel_fijo
        '
        Me.Panel_fijo.Controls.Add(Me.btn_fijo)
        Me.Panel_fijo.Controls.Add(Me.Label8)
        Me.Panel_fijo.Controls.Add(Me.tb_fijo)
        Me.Panel_fijo.Enabled = False
        Me.Panel_fijo.Location = New System.Drawing.Point(9, 47)
        Me.Panel_fijo.Name = "Panel_fijo"
        Me.Panel_fijo.Size = New System.Drawing.Size(232, 223)
        Me.Panel_fijo.TabIndex = 38
        '
        'btn_fijo
        '
        Me.btn_fijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fijo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_fijo.Location = New System.Drawing.Point(48, 155)
        Me.btn_fijo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_fijo.Name = "btn_fijo"
        Me.btn_fijo.Size = New System.Drawing.Size(116, 43)
        Me.btn_fijo.TabIndex = 36
        Me.btn_fijo.Text = "Agregar"
        Me.btn_fijo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_fijo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Total"
        '
        'tb_fijo
        '
        Me.tb_fijo.BackColor = System.Drawing.SystemColors.Info
        Me.tb_fijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fijo.Location = New System.Drawing.Point(39, 13)
        Me.tb_fijo.Name = "tb_fijo"
        Me.tb_fijo.ReadOnly = True
        Me.tb_fijo.Size = New System.Drawing.Size(165, 26)
        Me.tb_fijo.TabIndex = 29
        '
        'RadioButton_Fijo
        '
        Me.RadioButton_Fijo.AutoSize = True
        Me.RadioButton_Fijo.Location = New System.Drawing.Point(6, 20)
        Me.RadioButton_Fijo.Name = "RadioButton_Fijo"
        Me.RadioButton_Fijo.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton_Fijo.TabIndex = 37
        Me.RadioButton_Fijo.TabStop = True
        Me.RadioButton_Fijo.Text = "Seleccionar"
        Me.RadioButton_Fijo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpleadoapeDataGridViewTextBoxColumn, Me.EmpleadonomDataGridViewTextBoxColumn, Me.EmpleadodniDataGridViewTextBoxColumn, Me.EmpleadoidDataGridViewTextBoxColumn, Me.EmpleadoRemuneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpleadoremuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(395, 173)
        Me.DataGridView1.TabIndex = 34
        '
        'EmpleadoapeDataGridViewTextBoxColumn
        '
        Me.EmpleadoapeDataGridViewTextBoxColumn.DataPropertyName = "empleado_ape"
        Me.EmpleadoapeDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.EmpleadoapeDataGridViewTextBoxColumn.Name = "EmpleadoapeDataGridViewTextBoxColumn"
        Me.EmpleadoapeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadonomDataGridViewTextBoxColumn
        '
        Me.EmpleadonomDataGridViewTextBoxColumn.DataPropertyName = "empleado_nom"
        Me.EmpleadonomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.EmpleadonomDataGridViewTextBoxColumn.Name = "EmpleadonomDataGridViewTextBoxColumn"
        Me.EmpleadonomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadodniDataGridViewTextBoxColumn
        '
        Me.EmpleadodniDataGridViewTextBoxColumn.DataPropertyName = "empleado_dni"
        Me.EmpleadodniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.EmpleadodniDataGridViewTextBoxColumn.Name = "EmpleadodniDataGridViewTextBoxColumn"
        Me.EmpleadodniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadoidDataGridViewTextBoxColumn
        '
        Me.EmpleadoidDataGridViewTextBoxColumn.DataPropertyName = "empleado_id"
        Me.EmpleadoidDataGridViewTextBoxColumn.HeaderText = "empleado_id"
        Me.EmpleadoidDataGridViewTextBoxColumn.Name = "EmpleadoidDataGridViewTextBoxColumn"
        Me.EmpleadoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpleadoidDataGridViewTextBoxColumn.Visible = False
        '
        'EmpleadoRemuneDataGridViewTextBoxColumn
        '
        Me.EmpleadoRemuneDataGridViewTextBoxColumn.DataPropertyName = "empleado_Remune"
        Me.EmpleadoRemuneDataGridViewTextBoxColumn.HeaderText = "Remuneracion"
        Me.EmpleadoRemuneDataGridViewTextBoxColumn.Name = "EmpleadoRemuneDataGridViewTextBoxColumn"
        Me.EmpleadoRemuneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadoremuBindingSource
        '
        Me.EmpleadoremuBindingSource.DataMember = "Empleado_remu"
        Me.EmpleadoremuBindingSource.DataSource = Me.Ds_empleados
        '
        'Ds_empleados
        '
        Me.Ds_empleados.DataSetName = "ds_empleados"
        Me.Ds_empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tb_multi)
        Me.GroupBox4.Controls.Add(Me.tb_totalEmp)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.tb_empCost)
        Me.GroupBox4.Controls.Add(Me.btn_emp)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(832, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 319)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Costo Empleados"
        '
        'tb_multi
        '
        Me.tb_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_multi.Location = New System.Drawing.Point(141, 219)
        Me.tb_multi.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.tb_multi.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tb_multi.Name = "tb_multi"
        Me.tb_multi.Size = New System.Drawing.Size(46, 26)
        Me.tb_multi.TabIndex = 43
        Me.tb_multi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tb_totalEmp
        '
        Me.tb_totalEmp.BackColor = System.Drawing.SystemColors.Info
        Me.tb_totalEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_totalEmp.Location = New System.Drawing.Point(221, 218)
        Me.tb_totalEmp.Name = "tb_totalEmp"
        Me.tb_totalEmp.ReadOnly = True
        Me.tb_totalEmp.Size = New System.Drawing.Size(165, 26)
        Me.tb_totalEmp.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(193, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 24)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(110, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 24)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "X"
        '
        'tb_empCost
        '
        Me.tb_empCost.BackColor = System.Drawing.SystemColors.Info
        Me.tb_empCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_empCost.Location = New System.Drawing.Point(6, 219)
        Me.tb_empCost.Name = "tb_empCost"
        Me.tb_empCost.ReadOnly = True
        Me.tb_empCost.Size = New System.Drawing.Size(98, 26)
        Me.tb_empCost.TabIndex = 38
        '
        'btn_emp
        '
        Me.btn_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emp.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_emp.Location = New System.Drawing.Point(141, 264)
        Me.btn_emp.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_emp.Name = "btn_emp"
        Me.btn_emp.Size = New System.Drawing.Size(116, 43)
        Me.btn_emp.TabIndex = 37
        Me.btn_emp.Text = "Agregar"
        Me.btn_emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_emp.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView2.Location = New System.Drawing.Point(13, 388)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(779, 159)
        Me.DataGridView2.TabIndex = 36
        '
        'Column1
        '
        Me.Column1.HeaderText = "Descripcion"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Costo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(562, 559)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Total"
        '
        'Total_Grilla
        '
        Me.Total_Grilla.BackColor = System.Drawing.SystemColors.Info
        Me.Total_Grilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Grilla.Location = New System.Drawing.Point(627, 553)
        Me.Total_Grilla.Name = "Total_Grilla"
        Me.Total_Grilla.ReadOnly = True
        Me.Total_Grilla.Size = New System.Drawing.Size(165, 26)
        Me.Total_Grilla.TabIndex = 37
        Me.Total_Grilla.Text = "0"
        '
        'tb_titulo
        '
        Me.tb_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_titulo.Location = New System.Drawing.Point(72, 34)
        Me.tb_titulo.Name = "tb_titulo"
        Me.tb_titulo.Size = New System.Drawing.Size(560, 26)
        Me.tb_titulo.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Titulo"
        '
        'CostoInd_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 642)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_titulo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Total_Grilla)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tb_costo)
        Me.Controls.Add(Me.tb_desc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "CostoInd_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Costos Indirectos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel_dia.ResumeLayout(False)
        Me.Panel_dia.PerformLayout()
        CType(Me.tb_dia_dia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_horas_hora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel_hora.ResumeLayout(False)
        Me.Panel_hora.PerformLayout()
        CType(Me.tb_hora_dia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel_fijo.ResumeLayout(False)
        Me.Panel_fijo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoremuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.tb_multi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_desc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_dia_dia As System.Windows.Forms.NumericUpDown
    Friend WithEvents tb_horas_hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_costo_Total_Dia As System.Windows.Forms.TextBox
    Friend WithEvents tb_costo As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_Dia As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_hora As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_fijo As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_fijo As System.Windows.Forms.TextBox
    Friend WithEvents tb_hora_dia As System.Windows.Forms.NumericUpDown
    Friend WithEvents RadioButton_dia As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_HORA As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Fijo As System.Windows.Forms.RadioButton
    Friend WithEvents Panel_dia As System.Windows.Forms.Panel
    Friend WithEvents Panel_hora As System.Windows.Forms.Panel
    Friend WithEvents Panel_fijo As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_totalEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_empCost As System.Windows.Forms.TextBox
    Friend WithEvents btn_emp As System.Windows.Forms.Button
    Friend WithEvents tb_multi As System.Windows.Forms.NumericUpDown
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadonomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadodniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoRemuneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoremuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_empleados As Aplicacion.ds_empleados
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Total_Grilla As System.Windows.Forms.TextBox
    Friend WithEvents tb_titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
