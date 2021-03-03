<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimientos_consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movimientos_consulta))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MovMer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMer_Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMer_FechaHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalidOrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalidDestinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosconsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker_desde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_Buscar = New System.Windows.Forms.TextBox()
        Me.BO_ver = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientosconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovMer_id, Me.MovMer_Concepto, Me.MovMer_FechaHora, Me.SucursalidOrigenDataGridViewTextBoxColumn, Me.Origen, Me.SucursalidDestinoDataGridViewTextBoxColumn, Me.Destino, Me.Usuario, Me.USUidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MovimientosconsultaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 74)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(986, 265)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 17
        '
        'MovMer_id
        '
        Me.MovMer_id.DataPropertyName = "MovMer_id"
        Me.MovMer_id.FillWeight = 152.2843!
        Me.MovMer_id.HeaderText = "ID"
        Me.MovMer_id.Name = "MovMer_id"
        Me.MovMer_id.ReadOnly = True
        Me.MovMer_id.Width = 50
        '
        'MovMer_Concepto
        '
        Me.MovMer_Concepto.DataPropertyName = "MovMer_Concepto"
        Me.MovMer_Concepto.FillWeight = 89.54314!
        Me.MovMer_Concepto.HeaderText = "Concepto"
        Me.MovMer_Concepto.Name = "MovMer_Concepto"
        Me.MovMer_Concepto.ReadOnly = True
        Me.MovMer_Concepto.Width = 200
        '
        'MovMer_FechaHora
        '
        Me.MovMer_FechaHora.DataPropertyName = "MovMer_FechaHora"
        Me.MovMer_FechaHora.FillWeight = 89.54314!
        Me.MovMer_FechaHora.HeaderText = "Fecha y Hora"
        Me.MovMer_FechaHora.Name = "MovMer_FechaHora"
        Me.MovMer_FechaHora.ReadOnly = True
        Me.MovMer_FechaHora.Width = 142
        '
        'SucursalidOrigenDataGridViewTextBoxColumn
        '
        Me.SucursalidOrigenDataGridViewTextBoxColumn.DataPropertyName = "sucursal_id_Origen"
        Me.SucursalidOrigenDataGridViewTextBoxColumn.HeaderText = "Origen_id"
        Me.SucursalidOrigenDataGridViewTextBoxColumn.Name = "SucursalidOrigenDataGridViewTextBoxColumn"
        Me.SucursalidOrigenDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucursalidOrigenDataGridViewTextBoxColumn.Visible = False
        Me.SucursalidOrigenDataGridViewTextBoxColumn.Width = 106
        '
        'Origen
        '
        Me.Origen.DataPropertyName = "Origen"
        Me.Origen.FillWeight = 89.54314!
        Me.Origen.HeaderText = "Suc. de Origen"
        Me.Origen.Name = "Origen"
        Me.Origen.ReadOnly = True
        Me.Origen.Width = 200
        '
        'SucursalidDestinoDataGridViewTextBoxColumn
        '
        Me.SucursalidDestinoDataGridViewTextBoxColumn.DataPropertyName = "sucursal_id_Destino"
        Me.SucursalidDestinoDataGridViewTextBoxColumn.HeaderText = "sucursal_id_Destino"
        Me.SucursalidDestinoDataGridViewTextBoxColumn.Name = "SucursalidDestinoDataGridViewTextBoxColumn"
        Me.SucursalidDestinoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucursalidDestinoDataGridViewTextBoxColumn.Visible = False
        Me.SucursalidDestinoDataGridViewTextBoxColumn.Width = 200
        '
        'Destino
        '
        Me.Destino.DataPropertyName = "Destino"
        Me.Destino.FillWeight = 89.54314!
        Me.Destino.HeaderText = "Suc. de Destino"
        Me.Destino.Name = "Destino"
        Me.Destino.ReadOnly = True
        Me.Destino.Width = 200
        '
        'Usuario
        '
        Me.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.FillWeight = 89.54314!
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'USUidDataGridViewTextBoxColumn
        '
        Me.USUidDataGridViewTextBoxColumn.DataPropertyName = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.HeaderText = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.Name = "USUidDataGridViewTextBoxColumn"
        Me.USUidDataGridViewTextBoxColumn.ReadOnly = True
        Me.USUidDataGridViewTextBoxColumn.Visible = False
        Me.USUidDataGridViewTextBoxColumn.Width = 105
        '
        'MovimientosconsultaBindingSource
        '
        Me.MovimientosconsultaBindingSource.DataMember = "movimientos_consulta"
        Me.MovimientosconsultaBindingSource.DataSource = Me.Mov_DS
        '
        'Mov_DS
        '
        Me.Mov_DS.DataSetName = "Mov_DS"
        Me.Mov_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tx_Buscar)
        Me.GroupBox1.Controls.Add(Me.BO_ver)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1002, 397)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro historico"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(722, 347)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 255
        Me.Button1.Text = "Generar reporte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_buscar)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_desde)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_hasta)
        Me.GroupBox2.Location = New System.Drawing.Point(376, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(619, 56)
        Me.GroupBox2.TabIndex = 254
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar por rango de fechas:"
        '
        'Button_buscar
        '
        Me.Button_buscar.Enabled = False
        Me.Button_buscar.Image = CType(resources.GetObject("Button_buscar.Image"), System.Drawing.Image)
        Me.Button_buscar.Location = New System.Drawing.Point(558, 13)
        Me.Button_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(43, 37)
        Me.Button_buscar.TabIndex = 257
        Me.Button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(16, 22)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 256
        Me.CheckBox1.Text = "Activar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(357, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 255
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(149, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 254
        Me.Label2.Text = "Desde:"
        '
        'DateTimePicker_desde
        '
        Me.DateTimePicker_desde.Enabled = False
        Me.DateTimePicker_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_desde.Location = New System.Drawing.Point(208, 21)
        Me.DateTimePicker_desde.Name = "DateTimePicker_desde"
        Me.DateTimePicker_desde.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker_desde.TabIndex = 252
        '
        'DateTimePicker_hasta
        '
        Me.DateTimePicker_hasta.Enabled = False
        Me.DateTimePicker_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_hasta.Location = New System.Drawing.Point(412, 21)
        Me.DateTimePicker_hasta.Name = "DateTimePicker_hasta"
        Me.DateTimePicker_hasta.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker_hasta.TabIndex = 253
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 253
        Me.Label1.Text = "Buscar:"
        '
        'tx_Buscar
        '
        Me.tx_Buscar.BackColor = System.Drawing.Color.White
        Me.tx_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Buscar.Location = New System.Drawing.Point(69, 28)
        Me.tx_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Buscar.Name = "tx_Buscar"
        Me.tx_Buscar.Size = New System.Drawing.Size(300, 22)
        Me.tx_Buscar.TabIndex = 252
        '
        'BO_ver
        '
        Me.BO_ver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_ver.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_ver.Location = New System.Drawing.Point(854, 347)
        Me.BO_ver.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_ver.Name = "BO_ver"
        Me.BO_ver.Size = New System.Drawing.Size(141, 43)
        Me.BO_ver.TabIndex = 248
        Me.BO_ver.Text = "Ver detalle"
        Me.BO_ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_ver.UseVisualStyleBackColor = True
        '
        'Movimientos_consulta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(1026, 404)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Movimientos_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de movimientos históricos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientosconsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MovimientosconsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_ver As System.Windows.Forms.Button
    Friend WithEvents MovMerFechaHoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMer_Concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMer_FechaHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalidOrigenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalidDestinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
