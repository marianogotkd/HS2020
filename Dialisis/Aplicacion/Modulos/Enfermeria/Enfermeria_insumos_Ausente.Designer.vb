<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enfermeria_insumos_Ausente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enfermeria_insumos_Ausente))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.GroupBox_insumos = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFabricacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovEnfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cambio = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tb_CantRe = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tb_Filtro = New System.Windows.Forms.TextBox()
        Me.lbl_err2 = New System.Windows.Forms.Label()
        Me.GroupBox_insumos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovEnfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.btn_cancelar.Location = New System.Drawing.Point(638, 385)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.MaximumSize = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.TabIndex = 339
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_guardar.Location = New System.Drawing.Point(770, 385)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.MaximumSize = New System.Drawing.Size(124, 43)
        Me.btn_guardar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(124, 43)
        Me.btn_guardar.TabIndex = 338
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'GroupBox_insumos
        '
        Me.GroupBox_insumos.Controls.Add(Me.btn_Buscar)
        Me.GroupBox_insumos.Controls.Add(Me.Label22)
        Me.GroupBox_insumos.Controls.Add(Me.btn_limpiar)
        Me.GroupBox_insumos.Controls.Add(Me.DataGridView1)
        Me.GroupBox_insumos.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox_insumos.Name = "GroupBox_insumos"
        Me.GroupBox_insumos.Size = New System.Drawing.Size(902, 269)
        Me.GroupBox_insumos.TabIndex = 337
        Me.GroupBox_insumos.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(9, 36)
        Me.btn_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(94, 40)
        Me.btn_Buscar.TabIndex = 335
        Me.btn_Buscar.Text = "Buscar "
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(6, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(154, 16)
        Me.Label22.TabIndex = 334
        Me.Label22.Text = "Insumos Consumidos"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Image = Global.Aplicacion.My.Resources.Resources.Borrar
        Me.btn_limpiar.Location = New System.Drawing.Point(111, 36)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(151, 39)
        Me.btn_limpiar.TabIndex = 333
        Me.btn_limpiar.Text = "Borrar Listado"
        Me.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDataGridViewTextBoxColumn, Me.CodprodDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DesdeDataGridViewTextBoxColumn, Me.HaciaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.FechaFabricacionDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.VenceDataGridViewTextBoxColumn, Me.PrecioUDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.ProvidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MovEnfBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(5, 84)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(877, 180)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 331
        '
        'NDataGridViewTextBoxColumn
        '
        Me.NDataGridViewTextBoxColumn.DataPropertyName = "N°"
        Me.NDataGridViewTextBoxColumn.HeaderText = "N°"
        Me.NDataGridViewTextBoxColumn.Name = "NDataGridViewTextBoxColumn"
        '
        'CodprodDataGridViewTextBoxColumn
        '
        Me.CodprodDataGridViewTextBoxColumn.DataPropertyName = "Cod_prod"
        Me.CodprodDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodprodDataGridViewTextBoxColumn.Name = "CodprodDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'DesdeDataGridViewTextBoxColumn
        '
        Me.DesdeDataGridViewTextBoxColumn.DataPropertyName = "Desde"
        Me.DesdeDataGridViewTextBoxColumn.HeaderText = "Desde"
        Me.DesdeDataGridViewTextBoxColumn.Name = "DesdeDataGridViewTextBoxColumn"
        Me.DesdeDataGridViewTextBoxColumn.Visible = False
        '
        'HaciaDataGridViewTextBoxColumn
        '
        Me.HaciaDataGridViewTextBoxColumn.DataPropertyName = "Hacia"
        Me.HaciaDataGridViewTextBoxColumn.HeaderText = "Hacia"
        Me.HaciaDataGridViewTextBoxColumn.Name = "HaciaDataGridViewTextBoxColumn"
        Me.HaciaDataGridViewTextBoxColumn.Visible = False
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'LoteDataGridViewTextBoxColumn
        '
        Me.LoteDataGridViewTextBoxColumn.DataPropertyName = "Lote"
        Me.LoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.LoteDataGridViewTextBoxColumn.Name = "LoteDataGridViewTextBoxColumn"
        Me.LoteDataGridViewTextBoxColumn.Visible = False
        '
        'FechaFabricacionDataGridViewTextBoxColumn
        '
        Me.FechaFabricacionDataGridViewTextBoxColumn.DataPropertyName = "FechaFabricacion"
        Me.FechaFabricacionDataGridViewTextBoxColumn.HeaderText = "FechaFabricacion"
        Me.FechaFabricacionDataGridViewTextBoxColumn.Name = "FechaFabricacionDataGridViewTextBoxColumn"
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        '
        'VenceDataGridViewTextBoxColumn
        '
        Me.VenceDataGridViewTextBoxColumn.DataPropertyName = "Vence"
        Me.VenceDataGridViewTextBoxColumn.HeaderText = "Vence"
        Me.VenceDataGridViewTextBoxColumn.Name = "VenceDataGridViewTextBoxColumn"
        Me.VenceDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioUDataGridViewTextBoxColumn
        '
        Me.PrecioUDataGridViewTextBoxColumn.DataPropertyName = "PrecioU"
        Me.PrecioUDataGridViewTextBoxColumn.HeaderText = "PrecioU"
        Me.PrecioUDataGridViewTextBoxColumn.Name = "PrecioUDataGridViewTextBoxColumn"
        Me.PrecioUDataGridViewTextBoxColumn.Visible = False
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.Visible = False
        '
        'ProvidDataGridViewTextBoxColumn
        '
        Me.ProvidDataGridViewTextBoxColumn.DataPropertyName = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.HeaderText = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.Name = "ProvidDataGridViewTextBoxColumn"
        Me.ProvidDataGridViewTextBoxColumn.Visible = False
        '
        'MovEnfBindingSource
        '
        Me.MovEnfBindingSource.DataMember = "Mov_Enf"
        Me.MovEnfBindingSource.DataSource = Me.Mov_DS
        '
        'Mov_DS
        '
        Me.Mov_DS.DataSetName = "Mov_DS"
        Me.Mov_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_cambio)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.tb_CantRe)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.tb_Filtro)
        Me.GroupBox2.Controls.Add(Me.lbl_err2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 97)
        Me.GroupBox2.TabIndex = 356
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro"
        '
        'btn_cambio
        '
        Me.btn_cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cambio.Location = New System.Drawing.Point(344, 40)
        Me.btn_cambio.Name = "btn_cambio"
        Me.btn_cambio.Size = New System.Drawing.Size(128, 23)
        Me.btn_cambio.TabIndex = 356
        Me.btn_cambio.Text = "Cambio de Filtro"
        Me.btn_cambio.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(187, 45)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 13)
        Me.Label24.TabIndex = 339
        Me.Label24.Text = "Cant. de Reusos"
        '
        'tb_CantRe
        '
        Me.tb_CantRe.Enabled = False
        Me.tb_CantRe.Location = New System.Drawing.Point(279, 42)
        Me.tb_CantRe.Multiline = True
        Me.tb_CantRe.Name = "tb_CantRe"
        Me.tb_CantRe.Size = New System.Drawing.Size(59, 20)
        Me.tb_CantRe.TabIndex = 338
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 13)
        Me.Label18.TabIndex = 332
        Me.Label18.Text = "Tipo"
        '
        'tb_Filtro
        '
        Me.tb_Filtro.Location = New System.Drawing.Point(41, 42)
        Me.tb_Filtro.Multiline = True
        Me.tb_Filtro.Name = "tb_Filtro"
        Me.tb_Filtro.Size = New System.Drawing.Size(110, 20)
        Me.tb_Filtro.TabIndex = 331
        '
        'lbl_err2
        '
        Me.lbl_err2.AutoSize = True
        Me.lbl_err2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_err2.ForeColor = System.Drawing.Color.Red
        Me.lbl_err2.Location = New System.Drawing.Point(157, 37)
        Me.lbl_err2.Name = "lbl_err2"
        Me.lbl_err2.Size = New System.Drawing.Size(20, 21)
        Me.lbl_err2.TabIndex = 337
        Me.lbl_err2.Text = "*"
        Me.lbl_err2.Visible = False
        '
        'Enfermeria_insumos_Ausente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 434)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox_insumos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Enfermeria_insumos_Ausente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paciente:. - Consumir Fitro e Insumos."
        Me.GroupBox_insumos.ResumeLayout(False)
        Me.GroupBox_insumos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovEnfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox_insumos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MovEnfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents NDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFabricacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cambio As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tb_CantRe As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tb_Filtro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_err2 As System.Windows.Forms.Label
End Class
