<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnoFijo_Modificar
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TurnoFijo_Modificar))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GP_Hasta = New System.Windows.Forms.GroupBox()
        Me.DT_hasta = New System.Windows.Forms.DateTimePicker()
        Me.GP_Desde = New System.Windows.Forms.GroupBox()
        Me.DT_desde = New System.Windows.Forms.DateTimePicker()
        Me.GP_Estado = New System.Windows.Forms.GroupBox()
        Me.RB_DISP_Si = New System.Windows.Forms.RadioButton()
        Me.RB_DISP_No = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DG_Turno = New System.Windows.Forms.DataGridView()
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
        Me.TURNO_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoReservadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Turno_ds = New Aplicacion.Turno_ds()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.GP_cancha = New System.Windows.Forms.GroupBox()
        Me.COM_CANCHA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.COM_CANCHA_T = New System.Windows.Forms.ComboBox()
        Me.BO_buscar = New System.Windows.Forms.Button()
        Me.GP_fecha = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.COM_dia = New System.Windows.Forms.ComboBox()
        Me.BO_Cancelar = New System.Windows.Forms.Button()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GP_Hasta.SuspendLayout()
        Me.GP_Desde.SuspendLayout()
        Me.GP_Estado.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoReservadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_cancha.SuspendLayout()
        Me.GP_fecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(866, 526)
        Me.TabControl2.TabIndex = 3
        Me.TabControl2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 500)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Turno Fijo: Actualizar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GP_Hasta)
        Me.GroupBox3.Controls.Add(Me.GP_Desde)
        Me.GroupBox3.Controls.Add(Me.GP_Estado)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(6, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(845, 396)
        Me.GroupBox3.TabIndex = 231
        Me.GroupBox3.TabStop = False
        '
        'GP_Hasta
        '
        Me.GP_Hasta.Controls.Add(Me.DT_hasta)
        Me.GP_Hasta.Enabled = False
        Me.GP_Hasta.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Hasta.Location = New System.Drawing.Point(603, 134)
        Me.GP_Hasta.Name = "GP_Hasta"
        Me.GP_Hasta.Size = New System.Drawing.Size(236, 56)
        Me.GP_Hasta.TabIndex = 251
        Me.GP_Hasta.TabStop = False
        Me.GP_Hasta.Text = "Disponible Hasta"
        '
        'DT_hasta
        '
        Me.DT_hasta.Location = New System.Drawing.Point(6, 23)
        Me.DT_hasta.Name = "DT_hasta"
        Me.DT_hasta.Size = New System.Drawing.Size(224, 20)
        Me.DT_hasta.TabIndex = 253
        '
        'GP_Desde
        '
        Me.GP_Desde.Controls.Add(Me.DT_desde)
        Me.GP_Desde.Enabled = False
        Me.GP_Desde.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Desde.Location = New System.Drawing.Point(603, 72)
        Me.GP_Desde.Name = "GP_Desde"
        Me.GP_Desde.Size = New System.Drawing.Size(236, 56)
        Me.GP_Desde.TabIndex = 250
        Me.GP_Desde.TabStop = False
        Me.GP_Desde.Text = "Disponible Desde"
        '
        'DT_desde
        '
        Me.DT_desde.Location = New System.Drawing.Point(6, 22)
        Me.DT_desde.Name = "DT_desde"
        Me.DT_desde.Size = New System.Drawing.Size(224, 20)
        Me.DT_desde.TabIndex = 252
        '
        'GP_Estado
        '
        Me.GP_Estado.Controls.Add(Me.RB_DISP_Si)
        Me.GP_Estado.Controls.Add(Me.RB_DISP_No)
        Me.GP_Estado.Enabled = False
        Me.GP_Estado.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Estado.Location = New System.Drawing.Point(603, 10)
        Me.GP_Estado.Name = "GP_Estado"
        Me.GP_Estado.Size = New System.Drawing.Size(236, 56)
        Me.GP_Estado.TabIndex = 249
        Me.GP_Estado.TabStop = False
        Me.GP_Estado.Text = "Estado del Turno"
        '
        'RB_DISP_Si
        '
        Me.RB_DISP_Si.AutoSize = True
        Me.RB_DISP_Si.Location = New System.Drawing.Point(33, 24)
        Me.RB_DISP_Si.Name = "RB_DISP_Si"
        Me.RB_DISP_Si.Size = New System.Drawing.Size(91, 17)
        Me.RB_DISP_Si.TabIndex = 1
        Me.RB_DISP_Si.TabStop = True
        Me.RB_DISP_Si.Text = "No Disponible"
        Me.RB_DISP_Si.UseVisualStyleBackColor = True
        '
        'RB_DISP_No
        '
        Me.RB_DISP_No.AutoSize = True
        Me.RB_DISP_No.Location = New System.Drawing.Point(127, 24)
        Me.RB_DISP_No.Name = "RB_DISP_No"
        Me.RB_DISP_No.Size = New System.Drawing.Size(74, 17)
        Me.RB_DISP_No.TabIndex = 0
        Me.RB_DISP_No.TabStop = True
        Me.RB_DISP_No.Text = "Disponible"
        Me.RB_DISP_No.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DG_Turno)
        Me.GroupBox6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox6.Location = New System.Drawing.Point(5, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(595, 380)
        Me.GroupBox6.TabIndex = 248
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Turno Fijo Reservado"
        '
        'DG_Turno
        '
        Me.DG_Turno.AllowUserToAddRows = False
        Me.DG_Turno.AllowUserToDeleteRows = False
        Me.DG_Turno.AutoGenerateColumns = False
        Me.DG_Turno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Turno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn, Me.TURNOTDataGridViewTextBoxColumn, Me.CANCHAidDataGridViewTextBoxColumn, Me.CANCHAnomDataGridViewTextBoxColumn, Me.TURNOfechaDataGridViewTextBoxColumn, Me.TURNOhoraDataGridViewTextBoxColumn, Me.TURNOfinDataGridViewTextBoxColumn, Me.TURNOcantDataGridViewTextBoxColumn, Me.CLIEidDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.TURNO_estado})
        Me.DG_Turno.DataSource = Me.TurnoReservadoBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Turno.DefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Turno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Turno.Location = New System.Drawing.Point(3, 16)
        Me.DG_Turno.Name = "DG_Turno"
        Me.DG_Turno.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Turno.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Turno.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Turno.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Turno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Turno.Size = New System.Drawing.Size(589, 361)
        Me.DG_Turno.TabIndex = 0
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
        Me.TURNOTDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TURNOTDataGridViewTextBoxColumn.Name = "TURNOTDataGridViewTextBoxColumn"
        Me.TURNOTDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOTDataGridViewTextBoxColumn.Width = 80
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
        Me.CANCHAnomDataGridViewTextBoxColumn.HeaderText = "Cancha"
        Me.CANCHAnomDataGridViewTextBoxColumn.Name = "CANCHAnomDataGridViewTextBoxColumn"
        Me.CANCHAnomDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.TURNOhoraDataGridViewTextBoxColumn.Width = 80
        '
        'TURNOfinDataGridViewTextBoxColumn
        '
        Me.TURNOfinDataGridViewTextBoxColumn.DataPropertyName = "TURNO_fin"
        Me.TURNOfinDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.TURNOfinDataGridViewTextBoxColumn.Name = "TURNOfinDataGridViewTextBoxColumn"
        Me.TURNOfinDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOfinDataGridViewTextBoxColumn.Width = 80
        '
        'TURNOcantDataGridViewTextBoxColumn
        '
        Me.TURNOcantDataGridViewTextBoxColumn.DataPropertyName = "TURNO_cant"
        Me.TURNOcantDataGridViewTextBoxColumn.HeaderText = "Duracion"
        Me.TURNOcantDataGridViewTextBoxColumn.Name = "TURNOcantDataGridViewTextBoxColumn"
        Me.TURNOcantDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOcantDataGridViewTextBoxColumn.Width = 80
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
        Me.CLInomDataGridViewTextBoxColumn.Width = 140
        '
        'TURNO_estado
        '
        Me.TURNO_estado.DataPropertyName = "TURNO_estado"
        Me.TURNO_estado.HeaderText = "TURNO_estado"
        Me.TURNO_estado.Name = "TURNO_estado"
        Me.TURNO_estado.ReadOnly = True
        Me.TURNO_estado.Visible = False
        '
        'TurnoReservadoBindingSource
        '
        Me.TurnoReservadoBindingSource.DataMember = "Turno Reservado"
        Me.TurnoReservadoBindingSource.DataSource = Me.Turno_ds
        '
        'Turno_ds
        '
        Me.Turno_ds.DataSetName = "Turno_ds"
        Me.Turno_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.IM_ERROR)
        Me.GroupBox4.Controls.Add(Me.GP_cancha)
        Me.GroupBox4.Controls.Add(Me.BO_buscar)
        Me.GroupBox4.Controls.Add(Me.GP_fecha)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(845, 89)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar Turno"
        '
        'IM_ERROR
        '
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(755, 42)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 249
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'GP_cancha
        '
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA)
        Me.GP_cancha.Controls.Add(Me.Label10)
        Me.GP_cancha.Controls.Add(Me.Label5)
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA_T)
        Me.GP_cancha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_cancha.Location = New System.Drawing.Point(328, 15)
        Me.GP_cancha.Name = "GP_cancha"
        Me.GP_cancha.Size = New System.Drawing.Size(385, 61)
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
        Me.COM_CANCHA.Size = New System.Drawing.Size(111, 23)
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
        Me.COM_CANCHA_T.Size = New System.Drawing.Size(155, 23)
        Me.COM_CANCHA_T.TabIndex = 7
        '
        'BO_buscar
        '
        Me.BO_buscar.Image = CType(resources.GetObject("BO_buscar.Image"), System.Drawing.Image)
        Me.BO_buscar.Location = New System.Drawing.Point(719, 35)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(30, 30)
        Me.BO_buscar.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.BO_buscar, "Buscar")
        Me.BO_buscar.UseVisualStyleBackColor = True
        '
        'GP_fecha
        '
        Me.GP_fecha.Controls.Add(Me.Label2)
        Me.GP_fecha.Controls.Add(Me.COM_dia)
        Me.GP_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_fecha.Location = New System.Drawing.Point(115, 15)
        Me.GP_fecha.Name = "GP_fecha"
        Me.GP_fecha.Size = New System.Drawing.Size(195, 61)
        Me.GP_fecha.TabIndex = 245
        Me.GP_fecha.TabStop = False
        Me.GP_fecha.Text = "Día"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(9, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 250
        Me.Label2.Text = "Día"
        '
        'COM_dia
        '
        Me.COM_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_dia.FormattingEnabled = True
        Me.COM_dia.Location = New System.Drawing.Point(41, 24)
        Me.COM_dia.Name = "COM_dia"
        Me.COM_dia.Size = New System.Drawing.Size(144, 23)
        Me.COM_dia.TabIndex = 249
        '
        'BO_Cancelar
        '
        Me.BO_Cancelar.Image = CType(resources.GetObject("BO_Cancelar.Image"), System.Drawing.Image)
        Me.BO_Cancelar.Location = New System.Drawing.Point(742, 544)
        Me.BO_Cancelar.Name = "BO_Cancelar"
        Me.BO_Cancelar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Cancelar.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.BO_Cancelar, "Cancelar")
        Me.BO_Cancelar.UseVisualStyleBackColor = True
        '
        'BO_guardar
        '
        Me.BO_guardar.Enabled = False
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(834, 544)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(40, 40)
        Me.BO_guardar.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Guardar")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Enabled = False
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(788, 544)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Eliminar.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Eliminar")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'TurnoFijo_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 591)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.BO_Cancelar)
        Me.Controls.Add(Me.BO_guardar)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "TurnoFijo_Modificar"
        Me.Text = "TurnoFijo_Modificar"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GP_Hasta.ResumeLayout(False)
        Me.GP_Desde.ResumeLayout(False)
        Me.GP_Estado.ResumeLayout(False)
        Me.GP_Estado.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoReservadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_cancha.ResumeLayout(False)
        Me.GP_cancha.PerformLayout()
        Me.GP_fecha.ResumeLayout(False)
        Me.GP_fecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Turno As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_cancha As System.Windows.Forms.GroupBox
    Friend WithEvents COM_CANCHA As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents COM_CANCHA_T As System.Windows.Forms.ComboBox
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents GP_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents COM_dia As System.Windows.Forms.ComboBox
    Friend WithEvents TurnoReservadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Turno_ds As Aplicacion.Turno_ds
    Friend WithEvents BO_Cancelar As System.Windows.Forms.Button
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents GP_Hasta As System.Windows.Forms.GroupBox
    Friend WithEvents DT_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GP_Desde As System.Windows.Forms.GroupBox
    Friend WithEvents DT_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents GP_Estado As System.Windows.Forms.GroupBox
    Friend WithEvents RB_DISP_Si As System.Windows.Forms.RadioButton
    Friend WithEvents RB_DISP_No As System.Windows.Forms.RadioButton
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
    Friend WithEvents TURNO_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
