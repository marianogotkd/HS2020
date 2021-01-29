<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terminal_modificar
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BO_usuario_bloquead = New System.Windows.Forms.Button()
        Me.BO_usuario_nuevo = New System.Windows.Forms.Button()
        Me.BO_usuario_modificar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnaEditar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TerminalesidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerminalesdescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerminalesestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerminalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Terminales_ds = New Aplicacion.Terminales_ds()
        Me.Bo_desbloq = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TerminalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Terminales_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bo_desbloq)
        Me.GroupBox1.Controls.Add(Me.BO_usuario_bloquead)
        Me.GroupBox1.Controls.Add(Me.BO_usuario_nuevo)
        Me.GroupBox1.Controls.Add(Me.BO_usuario_modificar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 322)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Terminales existentes:"
        '
        'BO_usuario_bloquead
        '
        Me.BO_usuario_bloquead.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_usuario_bloquead.Image = Global.Aplicacion.My.Resources.Resources.lock30x30
        Me.BO_usuario_bloquead.Location = New System.Drawing.Point(232, 269)
        Me.BO_usuario_bloquead.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_usuario_bloquead.Name = "BO_usuario_bloquead"
        Me.BO_usuario_bloquead.Size = New System.Drawing.Size(130, 43)
        Me.BO_usuario_bloquead.TabIndex = 140
        Me.BO_usuario_bloquead.Text = "Bloquear"
        Me.BO_usuario_bloquead.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_usuario_bloquead.UseVisualStyleBackColor = True
        '
        'BO_usuario_nuevo
        '
        Me.BO_usuario_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_usuario_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_usuario_nuevo.Location = New System.Drawing.Point(370, 269)
        Me.BO_usuario_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_usuario_nuevo.Name = "BO_usuario_nuevo"
        Me.BO_usuario_nuevo.Size = New System.Drawing.Size(124, 43)
        Me.BO_usuario_nuevo.TabIndex = 139
        Me.BO_usuario_nuevo.Text = "Agregar"
        Me.BO_usuario_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_usuario_nuevo.UseVisualStyleBackColor = True
        '
        'BO_usuario_modificar
        '
        Me.BO_usuario_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_usuario_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_usuario_modificar.Location = New System.Drawing.Point(502, 269)
        Me.BO_usuario_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_usuario_modificar.Name = "BO_usuario_modificar"
        Me.BO_usuario_modificar.Size = New System.Drawing.Size(124, 43)
        Me.BO_usuario_modificar.TabIndex = 138
        Me.BO_usuario_modificar.Text = "Editar"
        Me.BO_usuario_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_usuario_modificar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaEditar, Me.TerminalesidDataGridViewTextBoxColumn, Me.TerminalesdescDataGridViewTextBoxColumn, Me.TerminalesestadoDataGridViewTextBoxColumn, Me.SucursalidDataGridViewTextBoxColumn, Me.SucursalnombreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TerminalesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 22)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(619, 239)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 12
        '
        'ColumnaEditar
        '
        Me.ColumnaEditar.HeaderText = ""
        Me.ColumnaEditar.Name = "ColumnaEditar"
        Me.ColumnaEditar.ReadOnly = True
        Me.ColumnaEditar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColumnaEditar.Width = 50
        '
        'TerminalesidDataGridViewTextBoxColumn
        '
        Me.TerminalesidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TerminalesidDataGridViewTextBoxColumn.DataPropertyName = "Terminales_id"
        Me.TerminalesidDataGridViewTextBoxColumn.HeaderText = "Terminales_id"
        Me.TerminalesidDataGridViewTextBoxColumn.Name = "TerminalesidDataGridViewTextBoxColumn"
        Me.TerminalesidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TerminalesidDataGridViewTextBoxColumn.Visible = False
        '
        'TerminalesdescDataGridViewTextBoxColumn
        '
        Me.TerminalesdescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TerminalesdescDataGridViewTextBoxColumn.DataPropertyName = "Terminales_desc"
        Me.TerminalesdescDataGridViewTextBoxColumn.HeaderText = "Terminal"
        Me.TerminalesdescDataGridViewTextBoxColumn.Name = "TerminalesdescDataGridViewTextBoxColumn"
        Me.TerminalesdescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TerminalesestadoDataGridViewTextBoxColumn
        '
        Me.TerminalesestadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TerminalesestadoDataGridViewTextBoxColumn.DataPropertyName = "Terminales_estado"
        Me.TerminalesestadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.TerminalesestadoDataGridViewTextBoxColumn.Name = "TerminalesestadoDataGridViewTextBoxColumn"
        Me.TerminalesestadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucursalidDataGridViewTextBoxColumn
        '
        Me.SucursalidDataGridViewTextBoxColumn.DataPropertyName = "sucursal_id"
        Me.SucursalidDataGridViewTextBoxColumn.HeaderText = "sucursal_id"
        Me.SucursalidDataGridViewTextBoxColumn.Name = "SucursalidDataGridViewTextBoxColumn"
        Me.SucursalidDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucursalidDataGridViewTextBoxColumn.Visible = False
        '
        'SucursalnombreDataGridViewTextBoxColumn
        '
        Me.SucursalnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SucursalnombreDataGridViewTextBoxColumn.DataPropertyName = "sucursal_nombre"
        Me.SucursalnombreDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucursalnombreDataGridViewTextBoxColumn.Name = "SucursalnombreDataGridViewTextBoxColumn"
        Me.SucursalnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TerminalesBindingSource
        '
        Me.TerminalesBindingSource.DataMember = "Terminales"
        Me.TerminalesBindingSource.DataSource = Me.Terminales_ds
        '
        'Terminales_ds
        '
        Me.Terminales_ds.DataSetName = "Terminales_ds"
        Me.Terminales_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bo_desbloq
        '
        Me.Bo_desbloq.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bo_desbloq.Image = Global.Aplicacion.My.Resources.Resources.unLock30x30
        Me.Bo_desbloq.Location = New System.Drawing.Point(85, 269)
        Me.Bo_desbloq.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_desbloq.Name = "Bo_desbloq"
        Me.Bo_desbloq.Size = New System.Drawing.Size(139, 43)
        Me.Bo_desbloq.TabIndex = 141
        Me.Bo_desbloq.Text = "Desbloquear"
        Me.Bo_desbloq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_desbloq.UseVisualStyleBackColor = True
        '
        'Terminal_modificar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(654, 339)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Terminal_modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar terminales"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TerminalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Terminales_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnaEditar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TerminalesidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TerminalesdescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TerminalesestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TerminalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Terminales_ds As Aplicacion.Terminales_ds
    Friend WithEvents BO_usuario_bloquead As System.Windows.Forms.Button
    Friend WithEvents BO_usuario_nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_usuario_modificar As System.Windows.Forms.Button
    Friend WithEvents Bo_desbloq As System.Windows.Forms.Button
End Class
