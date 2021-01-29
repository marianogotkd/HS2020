<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno_Consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turno_Consulta))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GP_cancha = New System.Windows.Forms.GroupBox()
        Me.COM_CANCHA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.COM_CANCHA_T = New System.Windows.Forms.ComboBox()
        Me.GP_fecha = New System.Windows.Forms.GroupBox()
        Me.DT_fecha = New System.Windows.Forms.DateTimePicker()
        Me.BO_buscar = New System.Windows.Forms.Button()
        Me.GP_Cuarto = New System.Windows.Forms.GroupBox()
        Me.DG_Cuarto = New System.Windows.Forms.DataGridView()
        Me.GP_Tercero = New System.Windows.Forms.GroupBox()
        Me.DG_Tercero = New System.Windows.Forms.DataGridView()
        Me.GP_Segundo = New System.Windows.Forms.GroupBox()
        Me.DG_Segundo = New System.Windows.Forms.DataGridView()
        Me.GP_Primero = New System.Windows.Forms.GroupBox()
        Me.DG_Primero = New System.Windows.Forms.DataGridView()
        Me.TURNOidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAnomDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhoraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfinDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOcantDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIEidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOestadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurnoConsulta_ds = New Aplicacion.TurnoConsulta_ds()
        Me.TURNOidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOcantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIEidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimeroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TerceroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuartoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURNOidDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOTDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAidDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAnomDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfechaDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhoraDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfinDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOcantDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIEidDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOestadoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOTDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAnomDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfechaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhoraDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfinDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOcantDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIEidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOestadoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GP_cancha.SuspendLayout()
        Me.GP_fecha.SuspendLayout()
        Me.GP_Cuarto.SuspendLayout()
        CType(Me.DG_Cuarto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Tercero.SuspendLayout()
        CType(Me.DG_Tercero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Segundo.SuspendLayout()
        CType(Me.DG_Segundo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Primero.SuspendLayout()
        CType(Me.DG_Primero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegundoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoConsulta_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimeroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TerceroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuartoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1182, 597)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GP_cancha)
        Me.TabPage1.Controls.Add(Me.GP_fecha)
        Me.TabPage1.Controls.Add(Me.BO_buscar)
        Me.TabPage1.Controls.Add(Me.GP_Cuarto)
        Me.TabPage1.Controls.Add(Me.GP_Tercero)
        Me.TabPage1.Controls.Add(Me.GP_Segundo)
        Me.TabPage1.Controls.Add(Me.GP_Primero)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1174, 571)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Turno: Consulta"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GP_cancha
        '
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA)
        Me.GP_cancha.Controls.Add(Me.Label10)
        Me.GP_cancha.Controls.Add(Me.Label5)
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA_T)
        Me.GP_cancha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_cancha.Location = New System.Drawing.Point(496, 6)
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
        Me.COM_CANCHA.Location = New System.Drawing.Point(266, 24)
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
        'GP_fecha
        '
        Me.GP_fecha.Controls.Add(Me.DT_fecha)
        Me.GP_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_fecha.Location = New System.Drawing.Point(265, 6)
        Me.GP_fecha.Name = "GP_fecha"
        Me.GP_fecha.Size = New System.Drawing.Size(225, 61)
        Me.GP_fecha.TabIndex = 245
        Me.GP_fecha.TabStop = False
        Me.GP_fecha.Text = "Fecha"
        '
        'DT_fecha
        '
        Me.DT_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_fecha.Location = New System.Drawing.Point(8, 23)
        Me.DT_fecha.Name = "DT_fecha"
        Me.DT_fecha.Size = New System.Drawing.Size(210, 20)
        Me.DT_fecha.TabIndex = 11
        '
        'BO_buscar
        '
        Me.BO_buscar.Image = CType(resources.GetObject("BO_buscar.Image"), System.Drawing.Image)
        Me.BO_buscar.Location = New System.Drawing.Point(901, 26)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(30, 30)
        Me.BO_buscar.TabIndex = 16
        Me.BO_buscar.UseVisualStyleBackColor = True
        '
        'GP_Cuarto
        '
        Me.GP_Cuarto.Controls.Add(Me.DG_Cuarto)
        Me.GP_Cuarto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Cuarto.Location = New System.Drawing.Point(882, 73)
        Me.GP_Cuarto.Name = "GP_Cuarto"
        Me.GP_Cuarto.Size = New System.Drawing.Size(290, 492)
        Me.GP_Cuarto.TabIndex = 3
        Me.GP_Cuarto.TabStop = False
        '
        'DG_Cuarto
        '
        Me.DG_Cuarto.AllowUserToAddRows = False
        Me.DG_Cuarto.AllowUserToDeleteRows = False
        Me.DG_Cuarto.AutoGenerateColumns = False
        Me.DG_Cuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Cuarto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn3, Me.TURNOTDataGridViewTextBoxColumn3, Me.CANCHAidDataGridViewTextBoxColumn3, Me.CANCHAnomDataGridViewTextBoxColumn3, Me.TURNOfechaDataGridViewTextBoxColumn3, Me.TURNOhoraDataGridViewTextBoxColumn3, Me.TURNOfinDataGridViewTextBoxColumn3, Me.TURNOcantDataGridViewTextBoxColumn3, Me.CLIEidDataGridViewTextBoxColumn3, Me.CLInomDataGridViewTextBoxColumn3, Me.TURNOestadoDataGridViewTextBoxColumn3})
        Me.DG_Cuarto.DataSource = Me.CuartoBindingSource
        Me.DG_Cuarto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Cuarto.Enabled = False
        Me.DG_Cuarto.Location = New System.Drawing.Point(3, 16)
        Me.DG_Cuarto.Name = "DG_Cuarto"
        Me.DG_Cuarto.ReadOnly = True
        Me.DG_Cuarto.RowHeadersVisible = False
        Me.DG_Cuarto.Size = New System.Drawing.Size(284, 473)
        Me.DG_Cuarto.TabIndex = 0
        '
        'GP_Tercero
        '
        Me.GP_Tercero.Controls.Add(Me.DG_Tercero)
        Me.GP_Tercero.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Tercero.Location = New System.Drawing.Point(588, 73)
        Me.GP_Tercero.Name = "GP_Tercero"
        Me.GP_Tercero.Size = New System.Drawing.Size(290, 492)
        Me.GP_Tercero.TabIndex = 2
        Me.GP_Tercero.TabStop = False
        '
        'DG_Tercero
        '
        Me.DG_Tercero.AllowUserToAddRows = False
        Me.DG_Tercero.AllowUserToDeleteRows = False
        Me.DG_Tercero.AutoGenerateColumns = False
        Me.DG_Tercero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Tercero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn2, Me.TURNOTDataGridViewTextBoxColumn2, Me.CANCHAidDataGridViewTextBoxColumn2, Me.CANCHAnomDataGridViewTextBoxColumn2, Me.TURNOfechaDataGridViewTextBoxColumn2, Me.TURNOhoraDataGridViewTextBoxColumn2, Me.TURNOfinDataGridViewTextBoxColumn2, Me.TURNOcantDataGridViewTextBoxColumn2, Me.CLIEidDataGridViewTextBoxColumn2, Me.CLInomDataGridViewTextBoxColumn2, Me.TURNOestadoDataGridViewTextBoxColumn2})
        Me.DG_Tercero.DataSource = Me.TerceroBindingSource
        Me.DG_Tercero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Tercero.Enabled = False
        Me.DG_Tercero.Location = New System.Drawing.Point(3, 16)
        Me.DG_Tercero.Name = "DG_Tercero"
        Me.DG_Tercero.ReadOnly = True
        Me.DG_Tercero.RowHeadersVisible = False
        Me.DG_Tercero.Size = New System.Drawing.Size(284, 473)
        Me.DG_Tercero.TabIndex = 0
        '
        'GP_Segundo
        '
        Me.GP_Segundo.Controls.Add(Me.DG_Segundo)
        Me.GP_Segundo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Segundo.Location = New System.Drawing.Point(295, 73)
        Me.GP_Segundo.Name = "GP_Segundo"
        Me.GP_Segundo.Size = New System.Drawing.Size(290, 492)
        Me.GP_Segundo.TabIndex = 1
        Me.GP_Segundo.TabStop = False
        '
        'DG_Segundo
        '
        Me.DG_Segundo.AllowUserToAddRows = False
        Me.DG_Segundo.AllowUserToDeleteRows = False
        Me.DG_Segundo.AutoGenerateColumns = False
        Me.DG_Segundo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Segundo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn1, Me.TURNOTDataGridViewTextBoxColumn1, Me.CANCHAidDataGridViewTextBoxColumn1, Me.CANCHAnomDataGridViewTextBoxColumn1, Me.TURNOfechaDataGridViewTextBoxColumn1, Me.TURNOhoraDataGridViewTextBoxColumn1, Me.TURNOfinDataGridViewTextBoxColumn1, Me.TURNOcantDataGridViewTextBoxColumn1, Me.CLIEidDataGridViewTextBoxColumn1, Me.CLInomDataGridViewTextBoxColumn1, Me.TURNOestadoDataGridViewTextBoxColumn1})
        Me.DG_Segundo.DataSource = Me.SegundoBindingSource
        Me.DG_Segundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Segundo.Enabled = False
        Me.DG_Segundo.Location = New System.Drawing.Point(3, 16)
        Me.DG_Segundo.Name = "DG_Segundo"
        Me.DG_Segundo.ReadOnly = True
        Me.DG_Segundo.RowHeadersVisible = False
        Me.DG_Segundo.Size = New System.Drawing.Size(284, 473)
        Me.DG_Segundo.TabIndex = 0
        '
        'GP_Primero
        '
        Me.GP_Primero.Controls.Add(Me.DG_Primero)
        Me.GP_Primero.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Primero.Location = New System.Drawing.Point(1, 73)
        Me.GP_Primero.Name = "GP_Primero"
        Me.GP_Primero.Size = New System.Drawing.Size(290, 492)
        Me.GP_Primero.TabIndex = 0
        Me.GP_Primero.TabStop = False
        '
        'DG_Primero
        '
        Me.DG_Primero.AllowUserToAddRows = False
        Me.DG_Primero.AllowUserToDeleteRows = False
        Me.DG_Primero.AutoGenerateColumns = False
        Me.DG_Primero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Primero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn, Me.TURNOTDataGridViewTextBoxColumn, Me.CANCHAidDataGridViewTextBoxColumn, Me.CANCHAnomDataGridViewTextBoxColumn, Me.TURNOfechaDataGridViewTextBoxColumn, Me.TURNOhoraDataGridViewTextBoxColumn, Me.TURNOfinDataGridViewTextBoxColumn, Me.TURNOcantDataGridViewTextBoxColumn, Me.CLIEidDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.TURNOestadoDataGridViewTextBoxColumn})
        Me.DG_Primero.DataSource = Me.PrimeroBindingSource
        Me.DG_Primero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Primero.Enabled = False
        Me.DG_Primero.Location = New System.Drawing.Point(3, 16)
        Me.DG_Primero.Name = "DG_Primero"
        Me.DG_Primero.ReadOnly = True
        Me.DG_Primero.RowHeadersVisible = False
        Me.DG_Primero.Size = New System.Drawing.Size(284, 473)
        Me.DG_Primero.TabIndex = 0
        '
        'TURNOidDataGridViewTextBoxColumn1
        '
        Me.TURNOidDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn1.HeaderText = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn1.Name = "TURNOidDataGridViewTextBoxColumn1"
        Me.TURNOidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOidDataGridViewTextBoxColumn1.Visible = False
        '
        'TURNOTDataGridViewTextBoxColumn1
        '
        Me.TURNOTDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_T"
        Me.TURNOTDataGridViewTextBoxColumn1.HeaderText = "TURNO_T"
        Me.TURNOTDataGridViewTextBoxColumn1.Name = "TURNOTDataGridViewTextBoxColumn1"
        Me.TURNOTDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOTDataGridViewTextBoxColumn1.Visible = False
        '
        'CANCHAidDataGridViewTextBoxColumn1
        '
        Me.CANCHAidDataGridViewTextBoxColumn1.DataPropertyName = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn1.HeaderText = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn1.Name = "CANCHAidDataGridViewTextBoxColumn1"
        Me.CANCHAidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CANCHAidDataGridViewTextBoxColumn1.Visible = False
        '
        'CANCHAnomDataGridViewTextBoxColumn1
        '
        Me.CANCHAnomDataGridViewTextBoxColumn1.DataPropertyName = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn1.HeaderText = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn1.Name = "CANCHAnomDataGridViewTextBoxColumn1"
        Me.CANCHAnomDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CANCHAnomDataGridViewTextBoxColumn1.Visible = False
        '
        'TURNOfechaDataGridViewTextBoxColumn1
        '
        Me.TURNOfechaDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn1.HeaderText = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn1.Name = "TURNOfechaDataGridViewTextBoxColumn1"
        Me.TURNOfechaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOfechaDataGridViewTextBoxColumn1.Visible = False
        '
        'TURNOhoraDataGridViewTextBoxColumn1
        '
        Me.TURNOhoraDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_hora"
        Me.TURNOhoraDataGridViewTextBoxColumn1.HeaderText = "Inicio"
        Me.TURNOhoraDataGridViewTextBoxColumn1.Name = "TURNOhoraDataGridViewTextBoxColumn1"
        Me.TURNOhoraDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOhoraDataGridViewTextBoxColumn1.Width = 50
        '
        'TURNOfinDataGridViewTextBoxColumn1
        '
        Me.TURNOfinDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_fin"
        Me.TURNOfinDataGridViewTextBoxColumn1.HeaderText = "Fin"
        Me.TURNOfinDataGridViewTextBoxColumn1.Name = "TURNOfinDataGridViewTextBoxColumn1"
        Me.TURNOfinDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOfinDataGridViewTextBoxColumn1.Width = 50
        '
        'TURNOcantDataGridViewTextBoxColumn1
        '
        Me.TURNOcantDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_cant"
        Me.TURNOcantDataGridViewTextBoxColumn1.HeaderText = "Duracion"
        Me.TURNOcantDataGridViewTextBoxColumn1.Name = "TURNOcantDataGridViewTextBoxColumn1"
        Me.TURNOcantDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOcantDataGridViewTextBoxColumn1.Width = 60
        '
        'CLIEidDataGridViewTextBoxColumn1
        '
        Me.CLIEidDataGridViewTextBoxColumn1.DataPropertyName = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn1.HeaderText = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn1.Name = "CLIEidDataGridViewTextBoxColumn1"
        Me.CLIEidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CLIEidDataGridViewTextBoxColumn1.Visible = False
        '
        'CLInomDataGridViewTextBoxColumn1
        '
        Me.CLInomDataGridViewTextBoxColumn1.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.CLInomDataGridViewTextBoxColumn1.Name = "CLInomDataGridViewTextBoxColumn1"
        Me.CLInomDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn1.Width = 120
        '
        'TURNOestadoDataGridViewTextBoxColumn1
        '
        Me.TURNOestadoDataGridViewTextBoxColumn1.DataPropertyName = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn1.HeaderText = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn1.Name = "TURNOestadoDataGridViewTextBoxColumn1"
        Me.TURNOestadoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TURNOestadoDataGridViewTextBoxColumn1.Visible = False
        '
        'SegundoBindingSource
        '
        Me.SegundoBindingSource.DataMember = "Segundo"
        Me.SegundoBindingSource.DataSource = Me.TurnoConsulta_ds
        '
        'TurnoConsulta_ds
        '
        Me.TurnoConsulta_ds.DataSetName = "TurnoConsulta_ds"
        Me.TurnoConsulta_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TURNOcantDataGridViewTextBoxColumn.HeaderText = "Duracion"
        Me.TURNOcantDataGridViewTextBoxColumn.Name = "TURNOcantDataGridViewTextBoxColumn"
        Me.TURNOcantDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOcantDataGridViewTextBoxColumn.Width = 60
        '
        'CLIEidDataGridViewTextBoxColumn
        '
        Me.CLIEidDataGridViewTextBoxColumn.DataPropertyName = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn.HeaderText = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn.Name = "CLIEidDataGridViewTextBoxColumn"
        Me.CLIEidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIEidDataGridViewTextBoxColumn.Visible = False
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Width = 120
        '
        'TURNOestadoDataGridViewTextBoxColumn
        '
        Me.TURNOestadoDataGridViewTextBoxColumn.DataPropertyName = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn.HeaderText = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn.Name = "TURNOestadoDataGridViewTextBoxColumn"
        Me.TURNOestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOestadoDataGridViewTextBoxColumn.Visible = False
        '
        'PrimeroBindingSource
        '
        Me.PrimeroBindingSource.DataMember = "Primero"
        Me.PrimeroBindingSource.DataSource = Me.TurnoConsulta_ds
        '
        'TerceroBindingSource
        '
        Me.TerceroBindingSource.DataMember = "Tercero"
        Me.TerceroBindingSource.DataSource = Me.TurnoConsulta_ds
        '
        'CuartoBindingSource
        '
        Me.CuartoBindingSource.DataMember = "Cuarto"
        Me.CuartoBindingSource.DataSource = Me.TurnoConsulta_ds
        '
        'TURNOidDataGridViewTextBoxColumn3
        '
        Me.TURNOidDataGridViewTextBoxColumn3.DataPropertyName = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn3.HeaderText = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn3.Name = "TURNOidDataGridViewTextBoxColumn3"
        Me.TURNOidDataGridViewTextBoxColumn3.ReadOnly = True
        Me.TURNOidDataGridViewTextBoxColumn3.Visible = False
        '
        'TURNOTDataGridViewTextBoxColumn3
        '
        Me.TURNOTDataGridViewTextBoxColumn3.DataPropertyName = "TURNO_T"
        Me.TURNOTDataGridViewTextBoxColumn3.HeaderText = "TURNO_T"
        Me.TURNOTDataGridViewTextBoxColumn3.Name = "TURNOTDataGridViewTextBoxColumn3"
        Me.TURNOTDataGridViewTextBoxColumn3.ReadOnly = True
        Me.TURNOTDataGridViewTextBoxColumn3.Visible = False
        '
        'CANCHAidDataGridViewTextBoxColumn3
        '
        Me.CANCHAidDataGridViewTextBoxColumn3.DataPropertyName = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn3.HeaderText = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn3.Name = "CANCHAidDataGridViewTextBoxColumn3"
        Me.CANCHAidDataGridViewTextBoxColumn3.ReadOnly = True
        Me.CANCHAidDataGridViewTextBoxColumn3.Visible = False
        '
        'CANCHAnomDataGridViewTextBoxColumn3
        '
        Me.CANCHAnomDataGridViewTextBoxColumn3.DataPropertyName = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn3.HeaderText = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn3.Name = "CANCHAnomDataGridViewTextBoxColumn3"
        Me.CANCHAnomDataGridViewTextBoxColumn3.ReadOnly = True
        Me.CANCHAnomDataGridViewTextBoxColumn3.Visible = False
        '
        'TURNOfechaDataGridViewTextBoxColumn3
        '
        Me.TURNOfechaDataGridViewTextBoxColumn3.DataPropertyName = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn3.HeaderText = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn3.Name = "TURNOfechaDataGridViewTextBoxColumn3"
        Me.TURNOfechaDataGridViewTextBoxColumn3.ReadOnly = True
        Me.TURNOfechaDataGridViewTextBoxColumn3.Visible = False
        '
        'TURNOhoraDataGridViewTextBoxColumn3
        '
        Me.TURNOhoraDataGridViewTextBoxColumn3.DataPropertyName = "TURNO_hora"
        Me.TURNOhoraDataGridViewTextBoxColumn3.HeaderText = "Inicio"
        Me.TURNOhoraDataGridViewTextBoxColumn3.Name = "TURNOhoraDataGridViewTextBoxColumn3"
        Me.TURNOhoraDataGridViewTextBoxColumn3.ReadOnly = True
        Me.TURNOhoraDataGridViewTextBoxColumn3.Width = 50
        '
        'TURNOfinDataGridViewTextBoxColumn3
        '
        Me.TURNOfinDataGridViewTextBoxColumn3.DataPropertyName = "TURNO_fin"
        Me.TURNOfinDataGridViewTextBoxColumn3.HeaderText = "Fin"
        Me.TURNOfinDataGridViewTextBoxColumn3.Name = "TURNOfinDataGridViewTextBoxColumn3"
        Me.TURNOfinDataGridViewTextBoxColumn3.ReadOnly = True
        Me.TURNOfinDataGridViewTextBoxColumn3.Width = 50
        '
        'TURNOcantDataGridViewTextBoxColumn3
        '
        Me.TURNOcantDataGridViewTextBoxColumn3.DataPropertyName = "TURNO_cant"
        Me.TURNOcantDataGridViewTextBoxColumn3.HeaderText = "Duracion"
        Me.TURNOcantDataGridViewTextBoxColumn3.Name = "TURNOcantDataGridViewTextBoxColumn3"
        Me.TURNOcantDataGridViewTextBoxColumn3.ReadOnly = True
        Me.TURNOcantDataGridViewTextBoxColumn3.Width = 60
        '
        'CLIEidDataGridViewTextBoxColumn3
        '
        Me.CLIEidDataGridViewTextBoxColumn3.DataPropertyName = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn3.HeaderText = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn3.Name = "CLIEidDataGridViewTextBoxColumn3"
        Me.CLIEidDataGridViewTextBoxColumn3.ReadOnly = True
        Me.CLIEidDataGridViewTextBoxColumn3.Visible = False
        '
        'CLInomDataGridViewTextBoxColumn3
        '
        Me.CLInomDataGridViewTextBoxColumn3.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.CLInomDataGridViewTextBoxColumn3.Name = "CLInomDataGridViewTextBoxColumn3"
        Me.CLInomDataGridViewTextBoxColumn3.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn3.Width = 120
        '
        'TURNOestadoDataGridViewTextBoxColumn3
        '
        Me.TURNOestadoDataGridViewTextBoxColumn3.DataPropertyName = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn3.HeaderText = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn3.Name = "TURNOestadoDataGridViewTextBoxColumn3"
        Me.TURNOestadoDataGridViewTextBoxColumn3.ReadOnly = True
        Me.TURNOestadoDataGridViewTextBoxColumn3.Visible = False
        '
        'TURNOidDataGridViewTextBoxColumn2
        '
        Me.TURNOidDataGridViewTextBoxColumn2.DataPropertyName = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn2.HeaderText = "TURNO_id"
        Me.TURNOidDataGridViewTextBoxColumn2.Name = "TURNOidDataGridViewTextBoxColumn2"
        Me.TURNOidDataGridViewTextBoxColumn2.ReadOnly = True
        Me.TURNOidDataGridViewTextBoxColumn2.Visible = False
        '
        'TURNOTDataGridViewTextBoxColumn2
        '
        Me.TURNOTDataGridViewTextBoxColumn2.DataPropertyName = "TURNO_T"
        Me.TURNOTDataGridViewTextBoxColumn2.HeaderText = "TURNO_T"
        Me.TURNOTDataGridViewTextBoxColumn2.Name = "TURNOTDataGridViewTextBoxColumn2"
        Me.TURNOTDataGridViewTextBoxColumn2.ReadOnly = True
        Me.TURNOTDataGridViewTextBoxColumn2.Visible = False
        '
        'CANCHAidDataGridViewTextBoxColumn2
        '
        Me.CANCHAidDataGridViewTextBoxColumn2.DataPropertyName = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn2.HeaderText = "CANCHA_id"
        Me.CANCHAidDataGridViewTextBoxColumn2.Name = "CANCHAidDataGridViewTextBoxColumn2"
        Me.CANCHAidDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CANCHAidDataGridViewTextBoxColumn2.Visible = False
        '
        'CANCHAnomDataGridViewTextBoxColumn2
        '
        Me.CANCHAnomDataGridViewTextBoxColumn2.DataPropertyName = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn2.HeaderText = "CANCHA_nom"
        Me.CANCHAnomDataGridViewTextBoxColumn2.Name = "CANCHAnomDataGridViewTextBoxColumn2"
        Me.CANCHAnomDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CANCHAnomDataGridViewTextBoxColumn2.Visible = False
        '
        'TURNOfechaDataGridViewTextBoxColumn2
        '
        Me.TURNOfechaDataGridViewTextBoxColumn2.DataPropertyName = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn2.HeaderText = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn2.Name = "TURNOfechaDataGridViewTextBoxColumn2"
        Me.TURNOfechaDataGridViewTextBoxColumn2.ReadOnly = True
        Me.TURNOfechaDataGridViewTextBoxColumn2.Visible = False
        '
        'TURNOhoraDataGridViewTextBoxColumn2
        '
        Me.TURNOhoraDataGridViewTextBoxColumn2.DataPropertyName = "TURNO_hora"
        Me.TURNOhoraDataGridViewTextBoxColumn2.HeaderText = "Inicio"
        Me.TURNOhoraDataGridViewTextBoxColumn2.Name = "TURNOhoraDataGridViewTextBoxColumn2"
        Me.TURNOhoraDataGridViewTextBoxColumn2.ReadOnly = True
        Me.TURNOhoraDataGridViewTextBoxColumn2.Width = 50
        '
        'TURNOfinDataGridViewTextBoxColumn2
        '
        Me.TURNOfinDataGridViewTextBoxColumn2.DataPropertyName = "TURNO_fin"
        Me.TURNOfinDataGridViewTextBoxColumn2.HeaderText = "Fin"
        Me.TURNOfinDataGridViewTextBoxColumn2.Name = "TURNOfinDataGridViewTextBoxColumn2"
        Me.TURNOfinDataGridViewTextBoxColumn2.ReadOnly = True
        Me.TURNOfinDataGridViewTextBoxColumn2.Width = 50
        '
        'TURNOcantDataGridViewTextBoxColumn2
        '
        Me.TURNOcantDataGridViewTextBoxColumn2.DataPropertyName = "TURNO_cant"
        Me.TURNOcantDataGridViewTextBoxColumn2.HeaderText = "Duracion"
        Me.TURNOcantDataGridViewTextBoxColumn2.Name = "TURNOcantDataGridViewTextBoxColumn2"
        Me.TURNOcantDataGridViewTextBoxColumn2.ReadOnly = True
        Me.TURNOcantDataGridViewTextBoxColumn2.Width = 60
        '
        'CLIEidDataGridViewTextBoxColumn2
        '
        Me.CLIEidDataGridViewTextBoxColumn2.DataPropertyName = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn2.HeaderText = "CLIE_id"
        Me.CLIEidDataGridViewTextBoxColumn2.Name = "CLIEidDataGridViewTextBoxColumn2"
        Me.CLIEidDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CLIEidDataGridViewTextBoxColumn2.Visible = False
        '
        'CLInomDataGridViewTextBoxColumn2
        '
        Me.CLInomDataGridViewTextBoxColumn2.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.CLInomDataGridViewTextBoxColumn2.Name = "CLInomDataGridViewTextBoxColumn2"
        Me.CLInomDataGridViewTextBoxColumn2.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn2.Width = 120
        '
        'TURNOestadoDataGridViewTextBoxColumn2
        '
        Me.TURNOestadoDataGridViewTextBoxColumn2.DataPropertyName = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn2.HeaderText = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn2.Name = "TURNOestadoDataGridViewTextBoxColumn2"
        Me.TURNOestadoDataGridViewTextBoxColumn2.ReadOnly = True
        Me.TURNOestadoDataGridViewTextBoxColumn2.Visible = False
        '
        'Turno_Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1205, 621)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Turno_Consulta"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GP_cancha.ResumeLayout(False)
        Me.GP_cancha.PerformLayout()
        Me.GP_fecha.ResumeLayout(False)
        Me.GP_Cuarto.ResumeLayout(False)
        CType(Me.DG_Cuarto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Tercero.ResumeLayout(False)
        CType(Me.DG_Tercero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Segundo.ResumeLayout(False)
        CType(Me.DG_Segundo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Primero.ResumeLayout(False)
        CType(Me.DG_Primero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegundoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoConsulta_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimeroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TerceroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuartoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GP_Primero As System.Windows.Forms.GroupBox
    Friend WithEvents TurnoConsulta_ds As Aplicacion.TurnoConsulta_ds
    Friend WithEvents DG_Primero As System.Windows.Forms.DataGridView
    Friend WithEvents GP_Cuarto As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Cuarto As System.Windows.Forms.DataGridView
    Friend WithEvents GP_Tercero As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Tercero As System.Windows.Forms.DataGridView
    Friend WithEvents GP_Segundo As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Segundo As System.Windows.Forms.DataGridView
    Friend WithEvents GP_cancha As System.Windows.Forms.GroupBox
    Friend WithEvents COM_CANCHA As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents COM_CANCHA_T As System.Windows.Forms.ComboBox
    Friend WithEvents GP_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents DT_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents PrimeroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TURNOidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOcantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIEidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAnomDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhoraDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfinDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOcantDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIEidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOestadoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegundoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TURNOidDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOTDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAidDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAnomDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfechaDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhoraDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfinDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOcantDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIEidDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOestadoDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuartoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TerceroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TURNOidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOTDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAnomDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfechaDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhoraDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfinDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOcantDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIEidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOestadoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
