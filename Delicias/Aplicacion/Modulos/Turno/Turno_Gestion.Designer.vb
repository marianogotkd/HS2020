<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno_Gestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turno_Gestion))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BO_Finalizar = New System.Windows.Forms.Button()
        Me.GP_duracion = New System.Windows.Forms.GroupBox()
        Me.NU_DUR_hora = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NU_DUR_minuto = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BO_AgregarTiempo = New System.Windows.Forms.Button()
        Me.BO_Parar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_Turno = New System.Windows.Forms.DataGridView()
        Me.TURNOidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOCONFidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAnomDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOdesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhastaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOtiempoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNO_fechahasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNO_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNO_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNO_saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoIniciadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Turno_ds = New Aplicacion.Turno_ds()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BO_IniciarTurnoReservado = New System.Windows.Forms.Button()
        Me.GP_cancha = New System.Windows.Forms.GroupBox()
        Me.COM_CANCHA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.COM_CANCHA_T = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DG_TurnoReservado = New System.Windows.Forms.DataGridView()
        Me.TURNOidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOcantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIEidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENTATURNOmontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENTA_TURNO_deuda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoReservadoGestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BO_Pagar = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TX_VENTA_TURNO_monto = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.COM_CANCHA_FIN = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.COM_CANCHA_T_FIN = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DG_TurnoFinalziado = New System.Windows.Forms.DataGridView()
        Me.TURNOidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOCONFidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAnomDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOdesdeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhastaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOtiempoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfechahastaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoFinalizadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GP_duracion.SuspendLayout()
        CType(Me.NU_DUR_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_DUR_minuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoIniciadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GP_cancha.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DG_TurnoReservado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoReservadoGestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_TurnoFinalziado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoFinalizadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(890, 638)
        Me.TabControl2.TabIndex = 3
        Me.TabControl2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(882, 612)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Turno: Control de Tiempo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BO_Finalizar)
        Me.GroupBox6.Controls.Add(Me.GP_duracion)
        Me.GroupBox6.Controls.Add(Me.BO_AgregarTiempo)
        Me.GroupBox6.Controls.Add(Me.BO_Parar)
        Me.GroupBox6.Controls.Add(Me.GroupBox1)
        Me.GroupBox6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox6.Location = New System.Drawing.Point(423, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(453, 555)
        Me.GroupBox6.TabIndex = 250
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Turno Iniciado"
        '
        'BO_Finalizar
        '
        Me.BO_Finalizar.Image = CType(resources.GetObject("BO_Finalizar.Image"), System.Drawing.Image)
        Me.BO_Finalizar.Location = New System.Drawing.Point(404, 499)
        Me.BO_Finalizar.Name = "BO_Finalizar"
        Me.BO_Finalizar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Finalizar.TabIndex = 255
        Me.ToolTip1.SetToolTip(Me.BO_Finalizar, "Finalizar")
        Me.BO_Finalizar.UseVisualStyleBackColor = True
        '
        'GP_duracion
        '
        Me.GP_duracion.Controls.Add(Me.NU_DUR_hora)
        Me.GP_duracion.Controls.Add(Me.Label1)
        Me.GP_duracion.Controls.Add(Me.NU_DUR_minuto)
        Me.GP_duracion.Controls.Add(Me.Label6)
        Me.GP_duracion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_duracion.Location = New System.Drawing.Point(9, 496)
        Me.GP_duracion.Name = "GP_duracion"
        Me.GP_duracion.Size = New System.Drawing.Size(195, 45)
        Me.GP_duracion.TabIndex = 254
        Me.GP_duracion.TabStop = False
        '
        'NU_DUR_hora
        '
        Me.NU_DUR_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_DUR_hora.Location = New System.Drawing.Point(55, 16)
        Me.NU_DUR_hora.Name = "NU_DUR_hora"
        Me.NU_DUR_hora.Size = New System.Drawing.Size(40, 22)
        Me.NU_DUR_hora.TabIndex = 14
        Me.NU_DUR_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 247
        Me.Label1.Text = "(Hora)"
        '
        'NU_DUR_minuto
        '
        Me.NU_DUR_minuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_DUR_minuto.Location = New System.Drawing.Point(143, 16)
        Me.NU_DUR_minuto.Name = "NU_DUR_minuto"
        Me.NU_DUR_minuto.Size = New System.Drawing.Size(40, 22)
        Me.NU_DUR_minuto.TabIndex = 15
        Me.NU_DUR_minuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(104, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 243
        Me.Label6.Text = "(Min)"
        '
        'BO_AgregarTiempo
        '
        Me.BO_AgregarTiempo.Image = CType(resources.GetObject("BO_AgregarTiempo.Image"), System.Drawing.Image)
        Me.BO_AgregarTiempo.Location = New System.Drawing.Point(210, 499)
        Me.BO_AgregarTiempo.Name = "BO_AgregarTiempo"
        Me.BO_AgregarTiempo.Size = New System.Drawing.Size(40, 40)
        Me.BO_AgregarTiempo.TabIndex = 253
        Me.ToolTip1.SetToolTip(Me.BO_AgregarTiempo, "Agregar Tiempo")
        Me.BO_AgregarTiempo.UseVisualStyleBackColor = True
        '
        'BO_Parar
        '
        Me.BO_Parar.Image = CType(resources.GetObject("BO_Parar.Image"), System.Drawing.Image)
        Me.BO_Parar.Location = New System.Drawing.Point(256, 499)
        Me.BO_Parar.Name = "BO_Parar"
        Me.BO_Parar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Parar.TabIndex = 252
        Me.ToolTip1.SetToolTip(Me.BO_Parar, "Parar")
        Me.BO_Parar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG_Turno)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 474)
        Me.GroupBox1.TabIndex = 249
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Turno en Tiempo Real"
        '
        'DG_Turno
        '
        Me.DG_Turno.AllowUserToAddRows = False
        Me.DG_Turno.AllowUserToDeleteRows = False
        Me.DG_Turno.AutoGenerateColumns = False
        Me.DG_Turno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Turno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn1, Me.TURNOCONFidDataGridViewTextBoxColumn, Me.CANCHAnomDataGridViewTextBoxColumn1, Me.TURNOdesdeDataGridViewTextBoxColumn, Me.TURNOhastaDataGridViewTextBoxColumn, Me.TURNOtiempoDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.TURNO_fechahasta, Me.TURNO_fecha, Me.TURNO_pago, Me.TURNO_saldo})
        Me.DG_Turno.DataSource = Me.TurnoIniciadoBindingSource
        Me.DG_Turno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Turno.Location = New System.Drawing.Point(3, 16)
        Me.DG_Turno.Name = "DG_Turno"
        Me.DG_Turno.ReadOnly = True
        Me.DG_Turno.RowHeadersVisible = False
        Me.DG_Turno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Turno.Size = New System.Drawing.Size(433, 455)
        Me.DG_Turno.TabIndex = 0
        '
        'TURNOidDataGridViewTextBoxColumn1
        '
        Me.TURNOidDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn1.HeaderText = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn1.Name = "TURNOidDataGridViewTextBoxColumn1"
        Me.TURNOidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOidDataGridViewTextBoxColumn1.Visible = False
        '
        'TURNOCONFidDataGridViewTextBoxColumn
        '
        Me.TURNOCONFidDataGridViewTextBoxColumn.DataPropertyName = "TURNO_CONF_id"
        Me.TURNOCONFidDataGridViewTextBoxColumn.HeaderText = "TURNO_CONF_id"
        Me.TURNOCONFidDataGridViewTextBoxColumn.Name = "TURNOCONFidDataGridViewTextBoxColumn"
        Me.TURNOCONFidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOCONFidDataGridViewTextBoxColumn.Visible = False
        '
        'CANCHAnomDataGridViewTextBoxColumn1
        '
        Me.CANCHAnomDataGridViewTextBoxColumn1.DataPropertyName = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn1.HeaderText = "Cancha"
        Me.CANCHAnomDataGridViewTextBoxColumn1.Name = "CANCHAnomDataGridViewTextBoxColumn1"
        Me.CANCHAnomDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CANCHAnomDataGridViewTextBoxColumn1.Width = 75
        '
        'TURNOdesdeDataGridViewTextBoxColumn
        '
        Me.TURNOdesdeDataGridViewTextBoxColumn.DataPropertyName = "TURNO_desde"
        Me.TURNOdesdeDataGridViewTextBoxColumn.HeaderText = "Inicio"
        Me.TURNOdesdeDataGridViewTextBoxColumn.Name = "TURNOdesdeDataGridViewTextBoxColumn"
        Me.TURNOdesdeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOdesdeDataGridViewTextBoxColumn.Width = 50
        '
        'TURNOhastaDataGridViewTextBoxColumn
        '
        Me.TURNOhastaDataGridViewTextBoxColumn.DataPropertyName = "TURNO_hasta"
        Me.TURNOhastaDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.TURNOhastaDataGridViewTextBoxColumn.Name = "TURNOhastaDataGridViewTextBoxColumn"
        Me.TURNOhastaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOhastaDataGridViewTextBoxColumn.Width = 50
        '
        'TURNOtiempoDataGridViewTextBoxColumn
        '
        Me.TURNOtiempoDataGridViewTextBoxColumn.DataPropertyName = "TURNO_tiempo"
        Me.TURNOtiempoDataGridViewTextBoxColumn.HeaderText = "Tiempo"
        Me.TURNOtiempoDataGridViewTextBoxColumn.Name = "TURNOtiempoDataGridViewTextBoxColumn"
        Me.TURNOtiempoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOtiempoDataGridViewTextBoxColumn.Width = 50
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TURNO_fechahasta
        '
        Me.TURNO_fechahasta.DataPropertyName = "TURNO_fechahasta"
        Me.TURNO_fechahasta.HeaderText = "TURNO_fechahasta"
        Me.TURNO_fechahasta.Name = "TURNO_fechahasta"
        Me.TURNO_fechahasta.ReadOnly = True
        Me.TURNO_fechahasta.Visible = False
        '
        'TURNO_fecha
        '
        Me.TURNO_fecha.DataPropertyName = "TURNO_fecha"
        Me.TURNO_fecha.HeaderText = "TURNO_fecha"
        Me.TURNO_fecha.Name = "TURNO_fecha"
        Me.TURNO_fecha.ReadOnly = True
        Me.TURNO_fecha.Visible = False
        '
        'TURNO_pago
        '
        Me.TURNO_pago.DataPropertyName = "TURNO_pago"
        Me.TURNO_pago.HeaderText = "Pagado"
        Me.TURNO_pago.Name = "TURNO_pago"
        Me.TURNO_pago.ReadOnly = True
        Me.TURNO_pago.Width = 50
        '
        'TURNO_saldo
        '
        Me.TURNO_saldo.DataPropertyName = "TURNO_saldo"
        Me.TURNO_saldo.HeaderText = "Saldo"
        Me.TURNO_saldo.Name = "TURNO_saldo"
        Me.TURNO_saldo.ReadOnly = True
        Me.TURNO_saldo.Width = 50
        '
        'TurnoIniciadoBindingSource
        '
        Me.TurnoIniciadoBindingSource.DataMember = "TurnoIniciado"
        Me.TurnoIniciadoBindingSource.DataSource = Me.Turno_ds
        '
        'Turno_ds
        '
        Me.Turno_ds.DataSetName = "Turno_ds"
        Me.Turno_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BO_IniciarTurnoReservado)
        Me.GroupBox4.Controls.Add(Me.GP_cancha)
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 603)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar Turno Reservado"
        '
        'BO_IniciarTurnoReservado
        '
        Me.BO_IniciarTurnoReservado.Image = CType(resources.GetObject("BO_IniciarTurnoReservado.Image"), System.Drawing.Image)
        Me.BO_IniciarTurnoReservado.Location = New System.Drawing.Point(172, 560)
        Me.BO_IniciarTurnoReservado.Name = "BO_IniciarTurnoReservado"
        Me.BO_IniciarTurnoReservado.Size = New System.Drawing.Size(40, 40)
        Me.BO_IniciarTurnoReservado.TabIndex = 251
        Me.ToolTip1.SetToolTip(Me.BO_IniciarTurnoReservado, "Iniciar")
        Me.BO_IniciarTurnoReservado.UseVisualStyleBackColor = True
        '
        'GP_cancha
        '
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA)
        Me.GP_cancha.Controls.Add(Me.Label10)
        Me.GP_cancha.Controls.Add(Me.Label5)
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA_T)
        Me.GP_cancha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_cancha.Location = New System.Drawing.Point(6, 19)
        Me.GP_cancha.Name = "GP_cancha"
        Me.GP_cancha.Size = New System.Drawing.Size(399, 61)
        Me.GP_cancha.TabIndex = 248
        Me.GP_cancha.TabStop = False
        Me.GP_cancha.Text = "Cancha"
        '
        'COM_CANCHA
        '
        Me.COM_CANCHA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_CANCHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_CANCHA.FormattingEnabled = True
        Me.COM_CANCHA.Location = New System.Drawing.Point(269, 24)
        Me.COM_CANCHA.Name = "COM_CANCHA"
        Me.COM_CANCHA.Size = New System.Drawing.Size(124, 23)
        Me.COM_CANCHA.TabIndex = 246
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(212, 27)
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
        Me.Label5.Location = New System.Drawing.Point(10, 27)
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
        Me.COM_CANCHA_T.Location = New System.Drawing.Point(47, 24)
        Me.COM_CANCHA_T.Name = "COM_CANCHA_T"
        Me.COM_CANCHA_T.Size = New System.Drawing.Size(159, 23)
        Me.COM_CANCHA_T.TabIndex = 7
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DG_TurnoReservado)
        Me.GroupBox8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox8.Location = New System.Drawing.Point(6, 86)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(399, 472)
        Me.GroupBox8.TabIndex = 249
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Turno Reservado"
        '
        'DG_TurnoReservado
        '
        Me.DG_TurnoReservado.AllowUserToAddRows = False
        Me.DG_TurnoReservado.AllowUserToDeleteRows = False
        Me.DG_TurnoReservado.AllowUserToResizeRows = False
        Me.DG_TurnoReservado.AutoGenerateColumns = False
        Me.DG_TurnoReservado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TurnoReservado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn, Me.TURNOTDataGridViewTextBoxColumn, Me.CANCHAidDataGridViewTextBoxColumn, Me.CANCHAnomDataGridViewTextBoxColumn, Me.TURNOfechaDataGridViewTextBoxColumn, Me.TURNOhoraDataGridViewTextBoxColumn, Me.TURNOfinDataGridViewTextBoxColumn, Me.TURNOcantDataGridViewTextBoxColumn, Me.CLIEidDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn2, Me.TURNOestadoDataGridViewTextBoxColumn, Me.VENTATURNOmontoDataGridViewTextBoxColumn, Me.VENTA_TURNO_deuda})
        Me.DG_TurnoReservado.DataSource = Me.TurnoReservadoGestionBindingSource
        Me.DG_TurnoReservado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_TurnoReservado.Location = New System.Drawing.Point(3, 16)
        Me.DG_TurnoReservado.Name = "DG_TurnoReservado"
        Me.DG_TurnoReservado.ReadOnly = True
        Me.DG_TurnoReservado.RowHeadersVisible = False
        Me.DG_TurnoReservado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_TurnoReservado.Size = New System.Drawing.Size(393, 453)
        Me.DG_TurnoReservado.TabIndex = 0
        '
        'TURNOidDataGridViewTextBoxColumn
        '
        Me.TURNOidDataGridViewTextBoxColumn.DataPropertyName = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn.HeaderText = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn.Name = "TURNOidDataGridViewTextBoxColumn"
        Me.TURNOidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOidDataGridViewTextBoxColumn.Visible = False
        '
        'TURNOTDataGridViewTextBoxColumn
        '
        Me.TURNOTDataGridViewTextBoxColumn.DataPropertyName = "TURNO_T"
        Me.TURNOTDataGridViewTextBoxColumn.HeaderText = "TURNO_T"
        Me.TURNOTDataGridViewTextBoxColumn.Name = "TURNOTDataGridViewTextBoxColumn"
        Me.TURNOTDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOTDataGridViewTextBoxColumn.Visible = False
        '
        'CANCHAidDataGridViewTextBoxColumn
        '
        Me.CANCHAidDataGridViewTextBoxColumn.DataPropertyName = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn.HeaderText = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn.Name = "CANCHAidDataGridViewTextBoxColumn"
        Me.CANCHAidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CANCHAidDataGridViewTextBoxColumn.Visible = False
        '
        'CANCHAnomDataGridViewTextBoxColumn
        '
        Me.CANCHAnomDataGridViewTextBoxColumn.DataPropertyName = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn.HeaderText = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn.Name = "CANCHAnomDataGridViewTextBoxColumn"
        Me.CANCHAnomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CANCHAnomDataGridViewTextBoxColumn.Visible = False
        '
        'TURNOfechaDataGridViewTextBoxColumn
        '
        Me.TURNOfechaDataGridViewTextBoxColumn.DataPropertyName = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn.HeaderText = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn.Name = "TURNOfechaDataGridViewTextBoxColumn"
        Me.TURNOfechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOfechaDataGridViewTextBoxColumn.Visible = False
        '
        'TURNOhoraDataGridViewTextBoxColumn
        '
        Me.TURNOhoraDataGridViewTextBoxColumn.DataPropertyName = "TURNO_hora"
        Me.TURNOhoraDataGridViewTextBoxColumn.HeaderText = "Inicio"
        Me.TURNOhoraDataGridViewTextBoxColumn.Name = "TURNOhoraDataGridViewTextBoxColumn"
        Me.TURNOhoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOhoraDataGridViewTextBoxColumn.Width = 50
        '
        'TURNOfinDataGridViewTextBoxColumn
        '
        Me.TURNOfinDataGridViewTextBoxColumn.DataPropertyName = "TURNO_fin"
        Me.TURNOfinDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.TURNOfinDataGridViewTextBoxColumn.Name = "TURNOfinDataGridViewTextBoxColumn"
        Me.TURNOfinDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOfinDataGridViewTextBoxColumn.Width = 50
        '
        'TURNOcantDataGridViewTextBoxColumn
        '
        Me.TURNOcantDataGridViewTextBoxColumn.DataPropertyName = "TURNO_cant"
        Me.TURNOcantDataGridViewTextBoxColumn.HeaderText = "Tiempo"
        Me.TURNOcantDataGridViewTextBoxColumn.Name = "TURNOcantDataGridViewTextBoxColumn"
        Me.TURNOcantDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOcantDataGridViewTextBoxColumn.Width = 50
        '
        'CLIEidDataGridViewTextBoxColumn
        '
        Me.CLIEidDataGridViewTextBoxColumn.DataPropertyName = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn.HeaderText = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn.Name = "CLIEidDataGridViewTextBoxColumn"
        Me.CLIEidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIEidDataGridViewTextBoxColumn.Visible = False
        '
        'CLInomDataGridViewTextBoxColumn2
        '
        Me.CLInomDataGridViewTextBoxColumn2.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.CLInomDataGridViewTextBoxColumn2.Name = "CLInomDataGridViewTextBoxColumn2"
        Me.CLInomDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn2.Width = 140
        '
        'TURNOestadoDataGridViewTextBoxColumn
        '
        Me.TURNOestadoDataGridViewTextBoxColumn.DataPropertyName = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn.HeaderText = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn.Name = "TURNOestadoDataGridViewTextBoxColumn"
        Me.TURNOestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOestadoDataGridViewTextBoxColumn.Visible = False
        '
        'VENTATURNOmontoDataGridViewTextBoxColumn
        '
        Me.VENTATURNOmontoDataGridViewTextBoxColumn.DataPropertyName = "VENTA_TURNO_monto"
        Me.VENTATURNOmontoDataGridViewTextBoxColumn.HeaderText = "Pagado"
        Me.VENTATURNOmontoDataGridViewTextBoxColumn.Name = "VENTATURNOmontoDataGridViewTextBoxColumn"
        Me.VENTATURNOmontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.VENTATURNOmontoDataGridViewTextBoxColumn.Width = 50
        '
        'VENTA_TURNO_deuda
        '
        Me.VENTA_TURNO_deuda.DataPropertyName = "VENTA_TURNO_deuda"
        Me.VENTA_TURNO_deuda.HeaderText = "Saldo"
        Me.VENTA_TURNO_deuda.Name = "VENTA_TURNO_deuda"
        Me.VENTA_TURNO_deuda.ReadOnly = True
        Me.VENTA_TURNO_deuda.Width = 50
        '
        'TurnoReservadoGestionBindingSource
        '
        Me.TurnoReservadoGestionBindingSource.DataMember = "Turno ReservadoGestion"
        Me.TurnoReservadoGestionBindingSource.DataSource = Me.Turno_ds
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(882, 612)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Turno: Finalizado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BO_Pagar)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(845, 562)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'BO_Pagar
        '
        Me.BO_Pagar.Image = CType(resources.GetObject("BO_Pagar.Image"), System.Drawing.Image)
        Me.BO_Pagar.Location = New System.Drawing.Point(787, 497)
        Me.BO_Pagar.Name = "BO_Pagar"
        Me.BO_Pagar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Pagar.TabIndex = 256
        Me.BO_Pagar.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox7.Location = New System.Drawing.Point(640, 473)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(141, 76)
        Me.GroupBox7.TabIndex = 250
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Pago Final del Turno"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TX_VENTA_TURNO_monto)
        Me.GroupBox9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox9.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(111, 46)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Monto"
        '
        'TX_VENTA_TURNO_monto
        '
        Me.TX_VENTA_TURNO_monto.Location = New System.Drawing.Point(6, 16)
        Me.TX_VENTA_TURNO_monto.Name = "TX_VENTA_TURNO_monto"
        Me.TX_VENTA_TURNO_monto.Size = New System.Drawing.Size(97, 20)
        Me.TX_VENTA_TURNO_monto.TabIndex = 95
        Me.TX_VENTA_TURNO_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.COM_CANCHA_FIN)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.COM_CANCHA_T_FIN)
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox5.Location = New System.Drawing.Point(20, 58)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(236, 106)
        Me.GroupBox5.TabIndex = 249
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cancha"
        '
        'COM_CANCHA_FIN
        '
        Me.COM_CANCHA_FIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_CANCHA_FIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_CANCHA_FIN.FormattingEnabled = True
        Me.COM_CANCHA_FIN.Location = New System.Drawing.Point(82, 62)
        Me.COM_CANCHA_FIN.Name = "COM_CANCHA_FIN"
        Me.COM_CANCHA_FIN.Size = New System.Drawing.Size(124, 23)
        Me.COM_CANCHA_FIN.TabIndex = 246
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(10, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 245
        Me.Label2.Text = "Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(10, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 244
        Me.Label3.Text = "Tipo"
        '
        'COM_CANCHA_T_FIN
        '
        Me.COM_CANCHA_T_FIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_CANCHA_T_FIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_CANCHA_T_FIN.FormattingEnabled = True
        Me.COM_CANCHA_T_FIN.Location = New System.Drawing.Point(47, 24)
        Me.COM_CANCHA_T_FIN.Name = "COM_CANCHA_T_FIN"
        Me.COM_CANCHA_T_FIN.Size = New System.Drawing.Size(159, 23)
        Me.COM_CANCHA_T_FIN.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DG_TurnoFinalziado)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(271, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 448)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Turno Finalizado"
        '
        'DG_TurnoFinalziado
        '
        Me.DG_TurnoFinalziado.AllowUserToAddRows = False
        Me.DG_TurnoFinalziado.AllowUserToDeleteRows = False
        Me.DG_TurnoFinalziado.AutoGenerateColumns = False
        Me.DG_TurnoFinalziado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_TurnoFinalziado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn2, Me.TURNOCONFidDataGridViewTextBoxColumn1, Me.CANCHAnomDataGridViewTextBoxColumn2, Me.TURNOdesdeDataGridViewTextBoxColumn1, Me.TURNOhastaDataGridViewTextBoxColumn1, Me.TURNOtiempoDataGridViewTextBoxColumn1, Me.CLInomDataGridViewTextBoxColumn1, Me.TURNOfechahastaDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DG_TurnoFinalziado.DataSource = Me.TurnoFinalizadoBindingSource
        Me.DG_TurnoFinalziado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_TurnoFinalziado.Location = New System.Drawing.Point(3, 16)
        Me.DG_TurnoFinalziado.Name = "DG_TurnoFinalziado"
        Me.DG_TurnoFinalziado.ReadOnly = True
        Me.DG_TurnoFinalziado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_TurnoFinalziado.Size = New System.Drawing.Size(553, 429)
        Me.DG_TurnoFinalziado.TabIndex = 0
        '
        'TURNOidDataGridViewTextBoxColumn2
        '
        Me.TURNOidDataGridViewTextBoxColumn2.DataPropertyName = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn2.HeaderText = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn2.Name = "TURNOidDataGridViewTextBoxColumn2"
        Me.TURNOidDataGridViewTextBoxColumn2.ReadOnly = True
        Me.TURNOidDataGridViewTextBoxColumn2.Visible = False
        '
        'TURNOCONFidDataGridViewTextBoxColumn1
        '
        Me.TURNOCONFidDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_CONF_id"
        Me.TURNOCONFidDataGridViewTextBoxColumn1.HeaderText = "TURNO_CONF_id"
        Me.TURNOCONFidDataGridViewTextBoxColumn1.Name = "TURNOCONFidDataGridViewTextBoxColumn1"
        Me.TURNOCONFidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOCONFidDataGridViewTextBoxColumn1.Visible = False
        '
        'CANCHAnomDataGridViewTextBoxColumn2
        '
        Me.CANCHAnomDataGridViewTextBoxColumn2.DataPropertyName = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn2.HeaderText = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn2.Name = "CANCHAnomDataGridViewTextBoxColumn2"
        Me.CANCHAnomDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CANCHAnomDataGridViewTextBoxColumn2.Visible = False
        '
        'TURNOdesdeDataGridViewTextBoxColumn1
        '
        Me.TURNOdesdeDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_desde"
        Me.TURNOdesdeDataGridViewTextBoxColumn1.HeaderText = "Inicio"
        Me.TURNOdesdeDataGridViewTextBoxColumn1.Name = "TURNOdesdeDataGridViewTextBoxColumn1"
        Me.TURNOdesdeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOdesdeDataGridViewTextBoxColumn1.Width = 70
        '
        'TURNOhastaDataGridViewTextBoxColumn1
        '
        Me.TURNOhastaDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_hasta"
        Me.TURNOhastaDataGridViewTextBoxColumn1.HeaderText = "Fin"
        Me.TURNOhastaDataGridViewTextBoxColumn1.Name = "TURNOhastaDataGridViewTextBoxColumn1"
        Me.TURNOhastaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOhastaDataGridViewTextBoxColumn1.Width = 70
        '
        'TURNOtiempoDataGridViewTextBoxColumn1
        '
        Me.TURNOtiempoDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_tiempo"
        Me.TURNOtiempoDataGridViewTextBoxColumn1.HeaderText = "Tiempo"
        Me.TURNOtiempoDataGridViewTextBoxColumn1.Name = "TURNOtiempoDataGridViewTextBoxColumn1"
        Me.TURNOtiempoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOtiempoDataGridViewTextBoxColumn1.Width = 70
        '
        'CLInomDataGridViewTextBoxColumn1
        '
        Me.CLInomDataGridViewTextBoxColumn1.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.CLInomDataGridViewTextBoxColumn1.Name = "CLInomDataGridViewTextBoxColumn1"
        Me.CLInomDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn1.Width = 160
        '
        'TURNOfechahastaDataGridViewTextBoxColumn
        '
        Me.TURNOfechahastaDataGridViewTextBoxColumn.DataPropertyName = "TURNO_fechahasta"
        Me.TURNOfechahastaDataGridViewTextBoxColumn.HeaderText = "TURNO_fechahasta"
        Me.TURNOfechahastaDataGridViewTextBoxColumn.Name = "TURNOfechahastaDataGridViewTextBoxColumn"
        Me.TURNOfechahastaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOfechahastaDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TURNO_pago"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Pagado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TURNO_saldo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Saldo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'TurnoFinalizadoBindingSource
        '
        Me.TurnoFinalizadoBindingSource.DataMember = "TurnoFinalizado"
        Me.TurnoFinalizadoBindingSource.DataSource = Me.Turno_ds
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(828, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 256
        Me.Label9.Text = "F5 : Actualizar"
        '
        'Turno_Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(922, 666)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TabControl2)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(930, 700)
        Me.MinimumSize = New System.Drawing.Size(930, 700)
        Me.Name = "Turno_Gestion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestion "
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GP_duracion.ResumeLayout(False)
        Me.GP_duracion.PerformLayout()
        CType(Me.NU_DUR_hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_DUR_minuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoIniciadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GP_cancha.ResumeLayout(False)
        Me.GP_cancha.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DG_TurnoReservado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoReservadoGestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DG_TurnoFinalziado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoFinalizadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_cancha As System.Windows.Forms.GroupBox
    Friend WithEvents COM_CANCHA As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents COM_CANCHA_T As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_TurnoReservado As System.Windows.Forms.DataGridView
    Friend WithEvents Turno_ds As Aplicacion.Turno_ds
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Turno As System.Windows.Forms.DataGridView
    Friend WithEvents BO_IniciarTurnoReservado As System.Windows.Forms.Button
    Friend WithEvents BO_AgregarTiempo As System.Windows.Forms.Button
    Friend WithEvents BO_Parar As System.Windows.Forms.Button
    Friend WithEvents GP_duracion As System.Windows.Forms.GroupBox
    Friend WithEvents NU_DUR_hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NU_DUR_minuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TurnoIniciadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BO_Finalizar As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents COM_CANCHA_FIN As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents COM_CANCHA_T_FIN As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_TurnoFinalziado As System.Windows.Forms.DataGridView
    Friend WithEvents TurnoFinalizadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TurnoReservadoGestionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TURNOidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOcantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIEidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VENTATURNOmontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VENTA_TURNO_deuda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOCONFidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAnomDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOdesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhastaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOtiempoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNO_fechahasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNO_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNO_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNO_saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOCONFidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAnomDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOdesdeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhastaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOtiempoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfechahastaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TX_VENTA_TURNO_monto As System.Windows.Forms.TextBox
    Friend WithEvents BO_Pagar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
