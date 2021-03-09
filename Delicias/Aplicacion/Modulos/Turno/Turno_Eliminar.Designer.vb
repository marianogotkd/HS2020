<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno_Eliminar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turno_Eliminar))
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.BO_Cancelar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
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
        Me.TURNOestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoReservadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Turno_ds = New Aplicacion.Turno_ds()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GP_cancha = New System.Windows.Forms.GroupBox()
        Me.COM_CANCHA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.COM_CANCHA_T = New System.Windows.Forms.ComboBox()
        Me.BO_buscar = New System.Windows.Forms.Button()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.GP_fecha = New System.Windows.Forms.GroupBox()
        Me.DT_fecha = New System.Windows.Forms.DateTimePicker()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoReservadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GP_cancha.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_fecha.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Enabled = False
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(834, 510)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Eliminar.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Eliminar")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'BO_Cancelar
        '
        Me.BO_Cancelar.Image = CType(resources.GetObject("BO_Cancelar.Image"), System.Drawing.Image)
        Me.BO_Cancelar.Location = New System.Drawing.Point(788, 510)
        Me.BO_Cancelar.Name = "BO_Cancelar"
        Me.BO_Cancelar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Cancelar.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.BO_Cancelar, "Cancelar")
        Me.BO_Cancelar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 466)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Turno Comun: Eliminar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(6, 108)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(845, 352)
        Me.GroupBox3.TabIndex = 231
        Me.GroupBox3.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DG_Turno)
        Me.GroupBox6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox6.Location = New System.Drawing.Point(49, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(751, 332)
        Me.GroupBox6.TabIndex = 248
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Turno Comun Reservado"
        '
        'DG_Turno
        '
        Me.DG_Turno.AllowUserToAddRows = False
        Me.DG_Turno.AllowUserToDeleteRows = False
        Me.DG_Turno.AutoGenerateColumns = False
        Me.DG_Turno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Turno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TURNOidDataGridViewTextBoxColumn, Me.TURNOTDataGridViewTextBoxColumn, Me.CANCHAidDataGridViewTextBoxColumn, Me.CANCHAnomDataGridViewTextBoxColumn, Me.TURNOfechaDataGridViewTextBoxColumn, Me.TURNOhoraDataGridViewTextBoxColumn, Me.TURNOfinDataGridViewTextBoxColumn, Me.TURNOcantDataGridViewTextBoxColumn, Me.CLIEidDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.TURNOestadoDataGridViewTextBoxColumn})
        Me.DG_Turno.DataSource = Me.TurnoReservadoBindingSource
        Me.DG_Turno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Turno.Location = New System.Drawing.Point(3, 16)
        Me.DG_Turno.Name = "DG_Turno"
        Me.DG_Turno.ReadOnly = True
        Me.DG_Turno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Turno.Size = New System.Drawing.Size(745, 313)
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
        Me.TURNOfechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.TURNOfechaDataGridViewTextBoxColumn.Name = "TURNOfechaDataGridViewTextBoxColumn"
        Me.TURNOfechaDataGridViewTextBoxColumn.ReadOnly = True
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
        'TURNOestadoDataGridViewTextBoxColumn
        '
        Me.TURNOestadoDataGridViewTextBoxColumn.DataPropertyName = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn.HeaderText = "TURNO_estado"
        Me.TURNOestadoDataGridViewTextBoxColumn.Name = "TURNOestadoDataGridViewTextBoxColumn"
        Me.TURNOestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TURNOestadoDataGridViewTextBoxColumn.Visible = False
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
        Me.GroupBox4.Controls.Add(Me.GP_cancha)
        Me.GroupBox4.Controls.Add(Me.BO_buscar)
        Me.GroupBox4.Controls.Add(Me.IM_ERROR)
        Me.GroupBox4.Controls.Add(Me.GP_fecha)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(845, 96)
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
        Me.GP_cancha.Location = New System.Drawing.Point(353, 22)
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
        Me.COM_CANCHA.Location = New System.Drawing.Point(252, 24)
        Me.COM_CANCHA.Name = "COM_CANCHA"
        Me.COM_CANCHA.Size = New System.Drawing.Size(124, 23)
        Me.COM_CANCHA.TabIndex = 246
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(198, 27)
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
        Me.COM_CANCHA_T.Size = New System.Drawing.Size(140, 23)
        Me.COM_CANCHA_T.TabIndex = 7
        '
        'BO_buscar
        '
        Me.BO_buscar.Image = CType(resources.GetObject("BO_buscar.Image"), System.Drawing.Image)
        Me.BO_buscar.Location = New System.Drawing.Point(744, 42)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(30, 30)
        Me.BO_buscar.TabIndex = 16
        Me.BO_buscar.UseVisualStyleBackColor = True
        '
        'IM_ERROR
        '
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(780, 49)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 248
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'GP_fecha
        '
        Me.GP_fecha.Controls.Add(Me.DT_fecha)
        Me.GP_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_fecha.Location = New System.Drawing.Point(105, 22)
        Me.GP_fecha.Name = "GP_fecha"
        Me.GP_fecha.Size = New System.Drawing.Size(241, 61)
        Me.GP_fecha.TabIndex = 245
        Me.GP_fecha.TabStop = False
        Me.GP_fecha.Text = "Fecha"
        '
        'DT_fecha
        '
        Me.DT_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_fecha.Location = New System.Drawing.Point(5, 25)
        Me.DT_fecha.Name = "DT_fecha"
        Me.DT_fecha.Size = New System.Drawing.Size(230, 20)
        Me.DT_fecha.TabIndex = 11
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(866, 492)
        Me.TabControl2.TabIndex = 2
        Me.TabControl2.TabStop = False
        '
        'Turno_Eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.BO_Cancelar)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "Turno_Eliminar"
        Me.Text = "Turno_Eliminar"
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DG_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoReservadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GP_cancha.ResumeLayout(False)
        Me.GP_cancha.PerformLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_fecha.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TurnoReservadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Turno_ds As Aplicacion.Turno_ds
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_Cancelar As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_cancha As System.Windows.Forms.GroupBox
    Friend WithEvents COM_CANCHA As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents COM_CANCHA_T As System.Windows.Forms.ComboBox
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents GP_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents DT_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents DG_Turno As System.Windows.Forms.DataGridView
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
