<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnoFijo_Reservado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TurnoFijo_Reservado))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DG_Turno = New System.Windows.Forms.DataGridView()
        Me.Turno_ds = New Aplicacion.Turno_ds()
        Me.TurnoReservadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURNOfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHAnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOhoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOfinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOcantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIEidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoReservadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(703, 462)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(695, 436)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Turno Reservado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DG_Turno)
        Me.GroupBox6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(682, 424)
        Me.GroupBox6.TabIndex = 249
        Me.GroupBox6.TabStop = False
        '
        'DG_Turno
        '
        Me.DG_Turno.AllowUserToAddRows = False
        Me.DG_Turno.AllowUserToDeleteRows = False
        Me.DG_Turno.AutoGenerateColumns = False
        Me.DG_Turno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Turno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOfechaDataGridViewTextBoxColumn, Me.TURNOidDataGridViewTextBoxColumn, Me.TURNOTDataGridViewTextBoxColumn, Me.CANCHAidDataGridViewTextBoxColumn, Me.CANCHAnomDataGridViewTextBoxColumn, Me.TURNOhoraDataGridViewTextBoxColumn, Me.TURNOfinDataGridViewTextBoxColumn, Me.TURNOcantDataGridViewTextBoxColumn, Me.CLIEidDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn})
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
        Me.DG_Turno.Enabled = False
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
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Turno.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Turno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Turno.Size = New System.Drawing.Size(676, 405)
        Me.DG_Turno.TabIndex = 0
        '
        'Turno_ds
        '
        Me.Turno_ds.DataSetName = "Turno_ds"
        Me.Turno_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TurnoReservadoBindingSource
        '
        Me.TurnoReservadoBindingSource.DataMember = "Turno Reservado"
        Me.TurnoReservadoBindingSource.DataSource = Me.Turno_ds
        '
        'TURNOfechaDataGridViewTextBoxColumn
        '
        Me.TURNOfechaDataGridViewTextBoxColumn.DataPropertyName = "TURNO_fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn.Name = "TURNOfechaDataGridViewTextBoxColumn"
        Me.TURNOfechaDataGridViewTextBoxColumn.ReadOnly = True
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
        'TURNOhoraDataGridViewTextBoxColumn
        '
        Me.TURNOhoraDataGridViewTextBoxColumn.DataPropertyName = "TURNO_hora"
        Me.TURNOhoraDataGridViewTextBoxColumn.HeaderText = "Inicio"
        Me.TURNOhoraDataGridViewTextBoxColumn.Name = "TURNOhoraDataGridViewTextBoxColumn"
        Me.TURNOhoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOhoraDataGridViewTextBoxColumn.Width = 70
        '
        'TURNOfinDataGridViewTextBoxColumn
        '
        Me.TURNOfinDataGridViewTextBoxColumn.DataPropertyName = "TURNO_fin"
        Me.TURNOfinDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.TURNOfinDataGridViewTextBoxColumn.Name = "TURNOfinDataGridViewTextBoxColumn"
        Me.TURNOfinDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOfinDataGridViewTextBoxColumn.Width = 70
        '
        'TURNOcantDataGridViewTextBoxColumn
        '
        Me.TURNOcantDataGridViewTextBoxColumn.DataPropertyName = "TURNO_cant"
        Me.TURNOcantDataGridViewTextBoxColumn.HeaderText = "Duracion"
        Me.TURNOcantDataGridViewTextBoxColumn.Name = "TURNOcantDataGridViewTextBoxColumn"
        Me.TURNOcantDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOcantDataGridViewTextBoxColumn.Width = 70
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
        'TurnoFijo_Reservado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(726, 486)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(742, 524)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(742, 524)
        Me.Name = "TurnoFijo_Reservado"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoReservadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Turno As System.Windows.Forms.DataGridView
    Friend WithEvents TURNOfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHAnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOhoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOfinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOcantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIEidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurnoReservadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Turno_ds As Aplicacion.Turno_ds
End Class
