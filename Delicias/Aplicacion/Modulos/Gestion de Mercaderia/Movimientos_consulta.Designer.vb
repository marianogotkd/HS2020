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
        Me.BO_ver = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientosconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovMer_id, Me.MovMer_Concepto, Me.MovMer_FechaHora, Me.SucursalidOrigenDataGridViewTextBoxColumn, Me.Origen, Me.SucursalidDestinoDataGridViewTextBoxColumn, Me.Destino, Me.Usuario, Me.USUidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MovimientosconsultaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 19)
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
        Me.DataGridView1.Size = New System.Drawing.Size(986, 320)
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
        Me.MovMer_Concepto.Width = 150
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
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BO_ver)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1002, 397)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro historico de movimientos"
        '
        'BO_ver
        '
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
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 404)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Movimientos_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de movimientos históricos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientosconsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
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
End Class
