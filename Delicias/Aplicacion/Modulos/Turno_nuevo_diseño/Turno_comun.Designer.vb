<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno_comun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turno_comun))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BO_Cliente = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TurnoDisponibleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Turno_ds = New Aplicacion.Turno_ds()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DG_Turno = New System.Windows.Forms.DataGridView()
        Me.TurnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BO_buscar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GP_cancha = New System.Windows.Forms.GroupBox()
        Me.COM_CANCHA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.COM_CANCHA_T = New System.Windows.Forms.ComboBox()
        Me.GP_duracion = New System.Windows.Forms.GroupBox()
        Me.NU_DUR_hora = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NU_DUR_minuto = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GP_fecha = New System.Windows.Forms.GroupBox()
        Me.DT_fecha = New System.Windows.Forms.DateTimePicker()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.LB_cancha = New System.Windows.Forms.Label()
        Me.LB_turno = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TX_VENTA_TURNO_monto = New System.Windows.Forms.TextBox()
        Me.RB_PAGO_no = New System.Windows.Forms.RadioButton()
        Me.RB_PAGO_si = New System.Windows.Forms.RadioButton()
        Me.GP_cliente = New System.Windows.Forms.GroupBox()
        Me.LB_ERROR_cliente = New System.Windows.Forms.Label()
        Me.IM_ERROR_cliente = New System.Windows.Forms.PictureBox()
        Me.GP_Producto = New System.Windows.Forms.GroupBox()
        Me.DG_Cliente = New System.Windows.Forms.DataGridView()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfnacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.BO_doc = New System.Windows.Forms.Button()
        Me.TX_doc = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.BO_ape = New System.Windows.Forms.Button()
        Me.TX_ape = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Selec = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TurnoDisponibleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GP_cancha.SuspendLayout()
        Me.GP_duracion.SuspendLayout()
        CType(Me.NU_DUR_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_DUR_minuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_fecha.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GP_cliente.SuspendLayout()
        CType(Me.IM_ERROR_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Producto.SuspendLayout()
        CType(Me.DG_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BO_Cliente
        '
        Me.BO_Cliente.Image = CType(resources.GetObject("BO_Cliente.Image"), System.Drawing.Image)
        Me.BO_Cliente.Location = New System.Drawing.Point(772, 317)
        Me.BO_Cliente.Name = "BO_Cliente"
        Me.BO_Cliente.Size = New System.Drawing.Size(40, 40)
        Me.BO_Cliente.TabIndex = 232
        Me.ToolTip1.SetToolTip(Me.BO_Cliente, "Agregar Cliente")
        Me.BO_Cliente.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(866, 534)
        Me.TabControl2.TabIndex = 25
        Me.TabControl2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.BO_buscar)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 508)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Turno: Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(6, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(634, 401)
        Me.GroupBox3.TabIndex = 231
        Me.GroupBox3.TabStop = False
        '
        'TurnoDisponibleBindingSource
        '
        Me.TurnoDisponibleBindingSource.DataMember = "TurnoDisponible"
        Me.TurnoDisponibleBindingSource.DataSource = Me.Turno_ds
        '
        'Turno_ds
        '
        Me.Turno_ds.DataSetName = "Turno_ds"
        Me.Turno_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DG_Turno)
        Me.GroupBox6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox6.Location = New System.Drawing.Point(23, 13)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(418, 382)
        Me.GroupBox6.TabIndex = 248
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Turno Reservado"
        '
        'DG_Turno
        '
        Me.DG_Turno.AllowUserToAddRows = False
        Me.DG_Turno.AllowUserToDeleteRows = False
        Me.DG_Turno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Turno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selec, Me.Turno, Me.Cliente})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Turno.DefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Turno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Turno.Enabled = False
        Me.DG_Turno.Location = New System.Drawing.Point(3, 16)
        Me.DG_Turno.Name = "DG_Turno"
        Me.DG_Turno.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Turno.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Turno.RowHeadersVisible = False
        Me.DG_Turno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Turno.Size = New System.Drawing.Size(412, 363)
        Me.DG_Turno.TabIndex = 0
        '
        'TurnoBindingSource
        '
        Me.TurnoBindingSource.DataMember = "Turno"
        Me.TurnoBindingSource.DataSource = Me.Turno_ds
        '
        'BO_buscar
        '
        Me.BO_buscar.Image = CType(resources.GetObject("BO_buscar.Image"), System.Drawing.Image)
        Me.BO_buscar.Location = New System.Drawing.Point(818, 48)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(30, 30)
        Me.BO_buscar.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.BO_buscar, "Buscar")
        Me.BO_buscar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GP_cancha)
        Me.GroupBox4.Controls.Add(Me.GP_duracion)
        Me.GroupBox4.Controls.Add(Me.GP_fecha)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(806, 93)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar Turno"
        '
        'GP_cancha
        '
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA)
        Me.GP_cancha.Controls.Add(Me.Label10)
        Me.GP_cancha.Controls.Add(Me.Label5)
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA_T)
        Me.GP_cancha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_cancha.Location = New System.Drawing.Point(417, 22)
        Me.GP_cancha.Name = "GP_cancha"
        Me.GP_cancha.Size = New System.Drawing.Size(380, 61)
        Me.GP_cancha.TabIndex = 248
        Me.GP_cancha.TabStop = False
        Me.GP_cancha.Text = "Cancha"
        '
        'COM_CANCHA
        '
        Me.COM_CANCHA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_CANCHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_CANCHA.FormattingEnabled = True
        Me.COM_CANCHA.Location = New System.Drawing.Point(244, 24)
        Me.COM_CANCHA.Name = "COM_CANCHA"
        Me.COM_CANCHA.Size = New System.Drawing.Size(124, 23)
        Me.COM_CANCHA.TabIndex = 246
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(192, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 245
        Me.Label10.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 244
        Me.Label5.Text = "Tipo"
        '
        'COM_CANCHA_T
        '
        Me.COM_CANCHA_T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_CANCHA_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_CANCHA_T.FormattingEnabled = True
        Me.COM_CANCHA_T.Location = New System.Drawing.Point(37, 24)
        Me.COM_CANCHA_T.Name = "COM_CANCHA_T"
        Me.COM_CANCHA_T.Size = New System.Drawing.Size(146, 23)
        Me.COM_CANCHA_T.TabIndex = 7
        '
        'GP_duracion
        '
        Me.GP_duracion.Controls.Add(Me.NU_DUR_hora)
        Me.GP_duracion.Controls.Add(Me.Label1)
        Me.GP_duracion.Controls.Add(Me.NU_DUR_minuto)
        Me.GP_duracion.Controls.Add(Me.Label6)
        Me.GP_duracion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_duracion.Location = New System.Drawing.Point(232, 22)
        Me.GP_duracion.Name = "GP_duracion"
        Me.GP_duracion.Size = New System.Drawing.Size(181, 61)
        Me.GP_duracion.TabIndex = 246
        Me.GP_duracion.TabStop = False
        Me.GP_duracion.Text = "Duración"
        '
        'NU_DUR_hora
        '
        Me.NU_DUR_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_DUR_hora.Location = New System.Drawing.Point(49, 25)
        Me.NU_DUR_hora.Name = "NU_DUR_hora"
        Me.NU_DUR_hora.Size = New System.Drawing.Size(40, 22)
        Me.NU_DUR_hora.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 247
        Me.Label1.Text = "(Hora)"
        '
        'NU_DUR_minuto
        '
        Me.NU_DUR_minuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_DUR_minuto.Location = New System.Drawing.Point(133, 25)
        Me.NU_DUR_minuto.Name = "NU_DUR_minuto"
        Me.NU_DUR_minuto.Size = New System.Drawing.Size(40, 22)
        Me.NU_DUR_minuto.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(95, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 243
        Me.Label6.Text = "(Min)"
        '
        'GP_fecha
        '
        Me.GP_fecha.Controls.Add(Me.DT_fecha)
        Me.GP_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_fecha.Location = New System.Drawing.Point(8, 22)
        Me.GP_fecha.Name = "GP_fecha"
        Me.GP_fecha.Size = New System.Drawing.Size(220, 61)
        Me.GP_fecha.TabIndex = 245
        Me.GP_fecha.TabStop = False
        Me.GP_fecha.Text = "Fecha"
        '
        'DT_fecha
        '
        Me.DT_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_fecha.Location = New System.Drawing.Point(5, 23)
        Me.DT_fecha.Name = "DT_fecha"
        Me.DT_fecha.Size = New System.Drawing.Size(211, 20)
        Me.DT_fecha.TabIndex = 11
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.LB_cancha)
        Me.TabPage9.Controls.Add(Me.LB_turno)
        Me.TabPage9.Controls.Add(Me.GroupBox1)
        Me.TabPage9.Controls.Add(Me.BO_Cliente)
        Me.TabPage9.Controls.Add(Me.GP_cliente)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(858, 508)
        Me.TabPage9.TabIndex = 5
        Me.TabPage9.Text = "Cliente: Buscar"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'LB_cancha
        '
        Me.LB_cancha.AutoSize = True
        Me.LB_cancha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_cancha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_cancha.Location = New System.Drawing.Point(101, 478)
        Me.LB_cancha.Name = "LB_cancha"
        Me.LB_cancha.Size = New System.Drawing.Size(54, 16)
        Me.LB_cancha.TabIndex = 252
        Me.LB_cancha.Text = "Cancha"
        '
        'LB_turno
        '
        Me.LB_turno.AutoSize = True
        Me.LB_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_turno.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_turno.Location = New System.Drawing.Point(101, 451)
        Me.LB_turno.Name = "LB_turno"
        Me.LB_turno.Size = New System.Drawing.Size(43, 16)
        Me.LB_turno.TabIndex = 251
        Me.LB_turno.Text = "Turno"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.RB_PAGO_no)
        Me.GroupBox1.Controls.Add(Me.RB_PAGO_si)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(243, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 66)
        Me.GroupBox1.TabIndex = 233
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pago Parcial del Turno"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TX_VENTA_TURNO_monto)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(252, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(111, 46)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monto"
        '
        'TX_VENTA_TURNO_monto
        '
        Me.TX_VENTA_TURNO_monto.Location = New System.Drawing.Point(6, 16)
        Me.TX_VENTA_TURNO_monto.Name = "TX_VENTA_TURNO_monto"
        Me.TX_VENTA_TURNO_monto.Size = New System.Drawing.Size(97, 20)
        Me.TX_VENTA_TURNO_monto.TabIndex = 95
        Me.TX_VENTA_TURNO_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RB_PAGO_no
        '
        Me.RB_PAGO_no.AutoSize = True
        Me.RB_PAGO_no.Checked = True
        Me.RB_PAGO_no.Location = New System.Drawing.Point(143, 28)
        Me.RB_PAGO_no.Name = "RB_PAGO_no"
        Me.RB_PAGO_no.Size = New System.Drawing.Size(103, 17)
        Me.RB_PAGO_no.TabIndex = 1
        Me.RB_PAGO_no.TabStop = True
        Me.RB_PAGO_no.Text = "Sin Pago Parcial"
        Me.RB_PAGO_no.UseVisualStyleBackColor = True
        '
        'RB_PAGO_si
        '
        Me.RB_PAGO_si.AutoSize = True
        Me.RB_PAGO_si.Location = New System.Drawing.Point(19, 28)
        Me.RB_PAGO_si.Name = "RB_PAGO_si"
        Me.RB_PAGO_si.Size = New System.Drawing.Size(107, 17)
        Me.RB_PAGO_si.TabIndex = 0
        Me.RB_PAGO_si.Text = "Con Pago Parcial"
        Me.RB_PAGO_si.UseVisualStyleBackColor = True
        '
        'GP_cliente
        '
        Me.GP_cliente.Controls.Add(Me.LB_ERROR_cliente)
        Me.GP_cliente.Controls.Add(Me.IM_ERROR_cliente)
        Me.GP_cliente.Controls.Add(Me.GP_Producto)
        Me.GP_cliente.Controls.Add(Me.BO_doc)
        Me.GP_cliente.Controls.Add(Me.TX_doc)
        Me.GP_cliente.Controls.Add(Me.Label35)
        Me.GP_cliente.Controls.Add(Me.BO_ape)
        Me.GP_cliente.Controls.Add(Me.TX_ape)
        Me.GP_cliente.Controls.Add(Me.Label38)
        Me.GP_cliente.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_cliente.Location = New System.Drawing.Point(80, 17)
        Me.GP_cliente.Name = "GP_cliente"
        Me.GP_cliente.Size = New System.Drawing.Size(672, 353)
        Me.GP_cliente.TabIndex = 230
        Me.GP_cliente.TabStop = False
        Me.GP_cliente.Text = "Buscar Cliente"
        '
        'LB_ERROR_cliente
        '
        Me.LB_ERROR_cliente.AutoSize = True
        Me.LB_ERROR_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR_cliente.ForeColor = System.Drawing.Color.Red
        Me.LB_ERROR_cliente.Location = New System.Drawing.Point(598, 29)
        Me.LB_ERROR_cliente.Name = "LB_ERROR_cliente"
        Me.LB_ERROR_cliente.Size = New System.Drawing.Size(59, 15)
        Me.LB_ERROR_cliente.TabIndex = 234
        Me.LB_ERROR_cliente.Text = "No Existe"
        Me.LB_ERROR_cliente.Visible = False
        '
        'IM_ERROR_cliente
        '
        Me.IM_ERROR_cliente.Image = CType(resources.GetObject("IM_ERROR_cliente.Image"), System.Drawing.Image)
        Me.IM_ERROR_cliente.Location = New System.Drawing.Point(577, 27)
        Me.IM_ERROR_cliente.Name = "IM_ERROR_cliente"
        Me.IM_ERROR_cliente.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR_cliente.TabIndex = 233
        Me.IM_ERROR_cliente.TabStop = False
        Me.IM_ERROR_cliente.Visible = False
        '
        'GP_Producto
        '
        Me.GP_Producto.Controls.Add(Me.DG_Cliente)
        Me.GP_Producto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Producto.Location = New System.Drawing.Point(21, 58)
        Me.GP_Producto.Name = "GP_Producto"
        Me.GP_Producto.Size = New System.Drawing.Size(622, 285)
        Me.GP_Producto.TabIndex = 103
        Me.GP_Producto.TabStop = False
        Me.GP_Producto.Text = "Cliente"
        '
        'DG_Cliente
        '
        Me.DG_Cliente.AllowUserToAddRows = False
        Me.DG_Cliente.AllowUserToDeleteRows = False
        Me.DG_Cliente.AutoGenerateColumns = False
        Me.DG_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIidDataGridViewTextBoxColumn, Me.CLIapeDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.CLIfnacDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn})
        Me.DG_Cliente.DataSource = Me.ClienteBindingSource
        Me.DG_Cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Cliente.Location = New System.Drawing.Point(3, 16)
        Me.DG_Cliente.Name = "DG_Cliente"
        Me.DG_Cliente.ReadOnly = True
        Me.DG_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Cliente.Size = New System.Drawing.Size(616, 266)
        Me.DG_Cliente.TabIndex = 0
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
        Me.CLIapeDataGridViewTextBoxColumn.Width = 110
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Width = 110
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "Documento"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIdniDataGridViewTextBoxColumn.Width = 90
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
        Me.ClienteBindingSource.DataSource = Me.Cliente_ds
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_doc
        '
        Me.BO_doc.Image = CType(resources.GetObject("BO_doc.Image"), System.Drawing.Image)
        Me.BO_doc.Location = New System.Drawing.Point(527, 21)
        Me.BO_doc.Name = "BO_doc"
        Me.BO_doc.Size = New System.Drawing.Size(30, 30)
        Me.BO_doc.TabIndex = 99
        Me.BO_doc.UseVisualStyleBackColor = True
        '
        'TX_doc
        '
        Me.TX_doc.Location = New System.Drawing.Point(393, 27)
        Me.TX_doc.Name = "TX_doc"
        Me.TX_doc.Size = New System.Drawing.Size(128, 20)
        Me.TX_doc.TabIndex = 97
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label35.Location = New System.Drawing.Point(316, 28)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(71, 15)
        Me.Label35.TabIndex = 98
        Me.Label35.Text = "Documento"
        '
        'BO_ape
        '
        Me.BO_ape.Image = CType(resources.GetObject("BO_ape.Image"), System.Drawing.Image)
        Me.BO_ape.Location = New System.Drawing.Point(264, 21)
        Me.BO_ape.Name = "BO_ape"
        Me.BO_ape.Size = New System.Drawing.Size(30, 30)
        Me.BO_ape.TabIndex = 96
        Me.BO_ape.UseVisualStyleBackColor = True
        '
        'TX_ape
        '
        Me.TX_ape.Location = New System.Drawing.Point(170, 27)
        Me.TX_ape.Name = "TX_ape"
        Me.TX_ape.Size = New System.Drawing.Size(88, 20)
        Me.TX_ape.TabIndex = 94
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label38.Location = New System.Drawing.Point(111, 29)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(51, 15)
        Me.Label38.TabIndex = 95
        Me.Label38.Text = "Apellido"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(22, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.Button1, "Guardar")
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(548, 552)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Eliminar.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Cancelar")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'BO_guardar
        '
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(594, 552)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(40, 40)
        Me.BO_guardar.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Guardar")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(445, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "Intervalo de turno"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"30 minutos", "1 hora"})
        Me.ComboBox1.Location = New System.Drawing.Point(548, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(74, 23)
        Me.ComboBox1.TabIndex = 251
        '
        'Selec
        '
        Me.Selec.HeaderText = "Selec"
        Me.Selec.Name = "Selec"
        Me.Selec.ReadOnly = True
        Me.Selec.Width = 50
        '
        'Turno
        '
        Me.Turno.HeaderText = "Turno"
        Me.Turno.Name = "Turno"
        Me.Turno.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 250
        '
        'Turno_comun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 601)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.BO_guardar)
        Me.Name = "Turno_comun"
        Me.Text = "Turno_comun"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TurnoDisponibleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GP_cancha.ResumeLayout(False)
        Me.GP_cancha.PerformLayout()
        Me.GP_duracion.ResumeLayout(False)
        Me.GP_duracion.PerformLayout()
        CType(Me.NU_DUR_hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_DUR_minuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_fecha.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GP_cliente.ResumeLayout(False)
        Me.GP_cliente.PerformLayout()
        CType(Me.IM_ERROR_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Producto.ResumeLayout(False)
        CType(Me.DG_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BO_Cliente As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TurnoDisponibleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Turno_ds As Aplicacion.Turno_ds
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Turno As System.Windows.Forms.DataGridView
    Friend WithEvents TurnoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_cancha As System.Windows.Forms.GroupBox
    Friend WithEvents COM_CANCHA As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents COM_CANCHA_T As System.Windows.Forms.ComboBox
    Friend WithEvents GP_duracion As System.Windows.Forms.GroupBox
    Friend WithEvents NU_DUR_hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NU_DUR_minuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GP_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents DT_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents LB_cancha As System.Windows.Forms.Label
    Friend WithEvents LB_turno As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TX_VENTA_TURNO_monto As System.Windows.Forms.TextBox
    Friend WithEvents RB_PAGO_no As System.Windows.Forms.RadioButton
    Friend WithEvents RB_PAGO_si As System.Windows.Forms.RadioButton
    Friend WithEvents GP_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents LB_ERROR_cliente As System.Windows.Forms.Label
    Friend WithEvents IM_ERROR_cliente As System.Windows.Forms.PictureBox
    Friend WithEvents GP_Producto As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Cliente As System.Windows.Forms.DataGridView
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfnacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents BO_doc As System.Windows.Forms.Button
    Friend WithEvents TX_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents BO_ape As System.Windows.Forms.Button
    Friend WithEvents TX_ape As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Selec As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
