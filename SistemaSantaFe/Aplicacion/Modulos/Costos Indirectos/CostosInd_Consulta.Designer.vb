<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostosInd_Consulta
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BO_cliente_nuevo = New System.Windows.Forms.Button()
        Me.BO_cliente_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_CostoI = New System.Windows.Forms.DataGridView()
        Me.CostoIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoIDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoITotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoIfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoIEstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoIndirectoObtenerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Costo_Ind = New Aplicacion.Costo_Ind()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_CostoI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostoIndirectoObtenerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Costo_Ind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(557, 452)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.BO_cliente_nuevo)
        Me.TabPage1.Controls.Add(Me.BO_cliente_modificar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(549, 423)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Costos Indirectos Consulta"
        '
        'BO_cliente_nuevo
        '
        Me.BO_cliente_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_cliente_nuevo.Location = New System.Drawing.Point(8, 338)
        Me.BO_cliente_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_nuevo.Name = "BO_cliente_nuevo"
        Me.BO_cliente_nuevo.Size = New System.Drawing.Size(124, 55)
        Me.BO_cliente_nuevo.TabIndex = 248
        Me.BO_cliente_nuevo.Text = "Nuevo"
        Me.BO_cliente_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_nuevo.UseVisualStyleBackColor = True
        '
        'BO_cliente_modificar
        '
        Me.BO_cliente_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_modificar.Image = Global.Aplicacion.My.Resources.Resources.cargaContratos
        Me.BO_cliente_modificar.Location = New System.Drawing.Point(362, 339)
        Me.BO_cliente_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_modificar.Name = "BO_cliente_modificar"
        Me.BO_cliente_modificar.Size = New System.Drawing.Size(179, 54)
        Me.BO_cliente_modificar.TabIndex = 247
        Me.BO_cliente_modificar.Text = "Ver / Modificar"
        Me.BO_cliente_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DG_CostoI)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(533, 321)
        Me.GroupBox1.TabIndex = 246
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(513, 22)
        Me.TextBox1.TabIndex = 240
        '
        'DG_CostoI
        '
        Me.DG_CostoI.AllowUserToAddRows = False
        Me.DG_CostoI.AllowUserToDeleteRows = False
        Me.DG_CostoI.AllowUserToResizeRows = False
        Me.DG_CostoI.AutoGenerateColumns = False
        Me.DG_CostoI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_CostoI.BackgroundColor = System.Drawing.Color.White
        Me.DG_CostoI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_CostoI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CostoI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CostoIidDataGridViewTextBoxColumn, Me.CostoIDescDataGridViewTextBoxColumn, Me.CostoITotalDataGridViewTextBoxColumn, Me.CostoIfechaDataGridViewTextBoxColumn, Me.CostoIEstadoDataGridViewTextBoxColumn})
        Me.DG_CostoI.DataSource = Me.CostoIndirectoObtenerBindingSource
        Me.DG_CostoI.Location = New System.Drawing.Point(12, 65)
        Me.DG_CostoI.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_CostoI.MultiSelect = False
        Me.DG_CostoI.Name = "DG_CostoI"
        Me.DG_CostoI.ReadOnly = True
        Me.DG_CostoI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_CostoI.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_CostoI.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_CostoI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_CostoI.Size = New System.Drawing.Size(513, 246)
        Me.DG_CostoI.StandardTab = True
        Me.DG_CostoI.TabIndex = 239
        '
        'CostoIidDataGridViewTextBoxColumn
        '
        Me.CostoIidDataGridViewTextBoxColumn.DataPropertyName = "CostoI_id"
        Me.CostoIidDataGridViewTextBoxColumn.FillWeight = 101.5228!
        Me.CostoIidDataGridViewTextBoxColumn.HeaderText = "N°"
        Me.CostoIidDataGridViewTextBoxColumn.Name = "CostoIidDataGridViewTextBoxColumn"
        Me.CostoIidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoIDescDataGridViewTextBoxColumn
        '
        Me.CostoIDescDataGridViewTextBoxColumn.DataPropertyName = "CostoI_Desc"
        Me.CostoIDescDataGridViewTextBoxColumn.FillWeight = 99.49239!
        Me.CostoIDescDataGridViewTextBoxColumn.HeaderText = "Titulo"
        Me.CostoIDescDataGridViewTextBoxColumn.Name = "CostoIDescDataGridViewTextBoxColumn"
        Me.CostoIDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoITotalDataGridViewTextBoxColumn
        '
        Me.CostoITotalDataGridViewTextBoxColumn.DataPropertyName = "CostoI_Total"
        Me.CostoITotalDataGridViewTextBoxColumn.FillWeight = 99.49239!
        Me.CostoITotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.CostoITotalDataGridViewTextBoxColumn.Name = "CostoITotalDataGridViewTextBoxColumn"
        Me.CostoITotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoIfechaDataGridViewTextBoxColumn
        '
        Me.CostoIfechaDataGridViewTextBoxColumn.DataPropertyName = "CostoI_fecha"
        Me.CostoIfechaDataGridViewTextBoxColumn.FillWeight = 99.49239!
        Me.CostoIfechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.CostoIfechaDataGridViewTextBoxColumn.Name = "CostoIfechaDataGridViewTextBoxColumn"
        Me.CostoIfechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoIEstadoDataGridViewTextBoxColumn
        '
        Me.CostoIEstadoDataGridViewTextBoxColumn.DataPropertyName = "CostoI_Estado"
        Me.CostoIEstadoDataGridViewTextBoxColumn.HeaderText = "CostoI_Estado"
        Me.CostoIEstadoDataGridViewTextBoxColumn.Name = "CostoIEstadoDataGridViewTextBoxColumn"
        Me.CostoIEstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoIEstadoDataGridViewTextBoxColumn.Visible = False
        '
        'CostoIndirectoObtenerBindingSource
        '
        Me.CostoIndirectoObtenerBindingSource.DataMember = "Costo_Indirecto_Obtener"
        Me.CostoIndirectoObtenerBindingSource.DataSource = Me.Costo_Ind
        '
        'Costo_Ind
        '
        Me.Costo_Ind.DataSetName = "Costo_Ind"
        Me.Costo_Ind.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CostosInd_Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 478)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CostosInd_Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Costos Indirectos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_CostoI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostoIndirectoObtenerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Costo_Ind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BO_cliente_nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_cliente_modificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_CostoI As System.Windows.Forms.DataGridView
    Friend WithEvents CostoIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoIDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoITotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoIfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoIEstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoIndirectoObtenerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Costo_Ind As Aplicacion.Costo_Ind
End Class
