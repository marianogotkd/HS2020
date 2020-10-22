<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicio_Consulta
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
        Me.DG_Servicio = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_suc = New System.Windows.Forms.ComboBox()
        Me.Button_Detalle = New System.Windows.Forms.Button()
        Me.btn_Anular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_buscar = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ServicioidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIFanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciofechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioimeiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioMarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciobatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioObsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioManoObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioAnticipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciodniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciodirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciotelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio_Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioSucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioEquipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioFechaRevDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioFechaRepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioObtenerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Servicio_DS = New Aplicacion.Servicio_DS()
        CType(Me.DG_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioObtenerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servicio_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_Servicio
        '
        Me.DG_Servicio.AllowUserToAddRows = False
        Me.DG_Servicio.AllowUserToDeleteRows = False
        Me.DG_Servicio.AllowUserToResizeRows = False
        Me.DG_Servicio.AutoGenerateColumns = False
        Me.DG_Servicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Servicio.BackgroundColor = System.Drawing.Color.White
        Me.DG_Servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Servicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServicioidDataGridViewTextBoxColumn, Me.CLIFanDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.ServiciofechaDataGridViewTextBoxColumn, Me.ServicioimeiDataGridViewTextBoxColumn, Me.ServicioMarcaDataGridViewTextBoxColumn, Me.ServicioModeloDataGridViewTextBoxColumn, Me.ServicioColorDataGridViewTextBoxColumn, Me.ServiciobatDataGridViewTextBoxColumn, Me.ServicioObsDataGridViewTextBoxColumn, Me.ServicioManoObraDataGridViewTextBoxColumn, Me.ServicioAnticipoDataGridViewTextBoxColumn, Me.ServicioNombreDataGridViewTextBoxColumn, Me.ServiciodniDataGridViewTextBoxColumn, Me.ServiciodirDataGridViewTextBoxColumn, Me.ServiciotelDataGridViewTextBoxColumn, Me.Servicio_Estado, Me.USUidDataGridViewTextBoxColumn, Me.ServicioDiagnosticoDataGridViewTextBoxColumn, Me.CLIidDataGridViewTextBoxColumn, Me.ServicioSucursalDataGridViewTextBoxColumn, Me.ServicioEquipoDataGridViewTextBoxColumn, Me.ServicioFechaRevDataGridViewTextBoxColumn, Me.ServicioFechaRepDataGridViewTextBoxColumn})
        Me.DG_Servicio.DataSource = Me.ServicioObtenerBindingSource
        Me.DG_Servicio.Location = New System.Drawing.Point(16, 81)
        Me.DG_Servicio.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Servicio.MultiSelect = False
        Me.DG_Servicio.Name = "DG_Servicio"
        Me.DG_Servicio.ReadOnly = True
        Me.DG_Servicio.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Servicio.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Servicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Servicio.Size = New System.Drawing.Size(856, 468)
        Me.DG_Servicio.StandardTab = True
        Me.DG_Servicio.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Sucursal:"
        '
        'ComboBox_suc
        '
        Me.ComboBox_suc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_suc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_suc.FormattingEnabled = True
        Me.ComboBox_suc.Location = New System.Drawing.Point(88, 23)
        Me.ComboBox_suc.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_suc.Name = "ComboBox_suc"
        Me.ComboBox_suc.Size = New System.Drawing.Size(313, 24)
        Me.ComboBox_suc.TabIndex = 12
        '
        'Button_Detalle
        '
        Me.Button_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Detalle.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_Detalle.Location = New System.Drawing.Point(748, 567)
        Me.Button_Detalle.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Detalle.Name = "Button_Detalle"
        Me.Button_Detalle.Size = New System.Drawing.Size(124, 43)
        Me.Button_Detalle.TabIndex = 10
        Me.Button_Detalle.Text = "Ver"
        Me.Button_Detalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Detalle.UseVisualStyleBackColor = True
        '
        'btn_Anular
        '
        Me.btn_Anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Anular.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Anular.Location = New System.Drawing.Point(616, 567)
        Me.btn_Anular.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Anular.Name = "btn_Anular"
        Me.btn_Anular.Size = New System.Drawing.Size(124, 43)
        Me.btn_Anular.TabIndex = 13
        Me.btn_Anular.Text = "Anular"
        Me.btn_Anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Anular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Buscar por:"
        '
        'ComboBox_buscar
        '
        Me.ComboBox_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_buscar.FormattingEnabled = True
        Me.ComboBox_buscar.Items.AddRange(New Object() {"Nº de Servicio", "Cliente"})
        Me.ComboBox_buscar.Location = New System.Drawing.Point(490, 20)
        Me.ComboBox_buscar.Name = "ComboBox_buscar"
        Me.ComboBox_buscar.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_buscar.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(617, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 22)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ServicioidDataGridViewTextBoxColumn
        '
        Me.ServicioidDataGridViewTextBoxColumn.DataPropertyName = "Servicio_id"
        Me.ServicioidDataGridViewTextBoxColumn.HeaderText = "N° de Servicio"
        Me.ServicioidDataGridViewTextBoxColumn.Name = "ServicioidDataGridViewTextBoxColumn"
        Me.ServicioidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIFanDataGridViewTextBoxColumn
        '
        Me.CLIFanDataGridViewTextBoxColumn.DataPropertyName = "CLI_Fan"
        Me.CLIFanDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.CLIFanDataGridViewTextBoxColumn.Name = "CLIFanDataGridViewTextBoxColumn"
        Me.CLIFanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiciofechaDataGridViewTextBoxColumn
        '
        Me.ServiciofechaDataGridViewTextBoxColumn.DataPropertyName = "Servicio_fecha"
        Me.ServiciofechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.ServiciofechaDataGridViewTextBoxColumn.Name = "ServiciofechaDataGridViewTextBoxColumn"
        Me.ServiciofechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServicioimeiDataGridViewTextBoxColumn
        '
        Me.ServicioimeiDataGridViewTextBoxColumn.DataPropertyName = "Servicio_imei"
        Me.ServicioimeiDataGridViewTextBoxColumn.HeaderText = "Servicio_imei"
        Me.ServicioimeiDataGridViewTextBoxColumn.Name = "ServicioimeiDataGridViewTextBoxColumn"
        Me.ServicioimeiDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioimeiDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioMarcaDataGridViewTextBoxColumn
        '
        Me.ServicioMarcaDataGridViewTextBoxColumn.DataPropertyName = "Servicio_Marca"
        Me.ServicioMarcaDataGridViewTextBoxColumn.HeaderText = "Servicio_Marca"
        Me.ServicioMarcaDataGridViewTextBoxColumn.Name = "ServicioMarcaDataGridViewTextBoxColumn"
        Me.ServicioMarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioMarcaDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioModeloDataGridViewTextBoxColumn
        '
        Me.ServicioModeloDataGridViewTextBoxColumn.DataPropertyName = "Servicio_Modelo"
        Me.ServicioModeloDataGridViewTextBoxColumn.HeaderText = "Servicio_Modelo"
        Me.ServicioModeloDataGridViewTextBoxColumn.Name = "ServicioModeloDataGridViewTextBoxColumn"
        Me.ServicioModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioModeloDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioColorDataGridViewTextBoxColumn
        '
        Me.ServicioColorDataGridViewTextBoxColumn.DataPropertyName = "Servicio_Color"
        Me.ServicioColorDataGridViewTextBoxColumn.HeaderText = "Servicio_Color"
        Me.ServicioColorDataGridViewTextBoxColumn.Name = "ServicioColorDataGridViewTextBoxColumn"
        Me.ServicioColorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioColorDataGridViewTextBoxColumn.Visible = False
        '
        'ServiciobatDataGridViewTextBoxColumn
        '
        Me.ServiciobatDataGridViewTextBoxColumn.DataPropertyName = "Servicio_bat"
        Me.ServiciobatDataGridViewTextBoxColumn.HeaderText = "Servicio_bat"
        Me.ServiciobatDataGridViewTextBoxColumn.Name = "ServiciobatDataGridViewTextBoxColumn"
        Me.ServiciobatDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiciobatDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioObsDataGridViewTextBoxColumn
        '
        Me.ServicioObsDataGridViewTextBoxColumn.DataPropertyName = "Servicio_Obs"
        Me.ServicioObsDataGridViewTextBoxColumn.HeaderText = "Servicio_Obs"
        Me.ServicioObsDataGridViewTextBoxColumn.Name = "ServicioObsDataGridViewTextBoxColumn"
        Me.ServicioObsDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioObsDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioManoObraDataGridViewTextBoxColumn
        '
        Me.ServicioManoObraDataGridViewTextBoxColumn.DataPropertyName = "Servicio_ManoObra"
        Me.ServicioManoObraDataGridViewTextBoxColumn.HeaderText = "Servicio_ManoObra"
        Me.ServicioManoObraDataGridViewTextBoxColumn.Name = "ServicioManoObraDataGridViewTextBoxColumn"
        Me.ServicioManoObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioManoObraDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioAnticipoDataGridViewTextBoxColumn
        '
        Me.ServicioAnticipoDataGridViewTextBoxColumn.DataPropertyName = "Servicio_Anticipo"
        Me.ServicioAnticipoDataGridViewTextBoxColumn.HeaderText = "Anticipo"
        Me.ServicioAnticipoDataGridViewTextBoxColumn.Name = "ServicioAnticipoDataGridViewTextBoxColumn"
        Me.ServicioAnticipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServicioNombreDataGridViewTextBoxColumn
        '
        Me.ServicioNombreDataGridViewTextBoxColumn.DataPropertyName = "Servicio_Nombre"
        Me.ServicioNombreDataGridViewTextBoxColumn.HeaderText = "Servicio_Nombre"
        Me.ServicioNombreDataGridViewTextBoxColumn.Name = "ServicioNombreDataGridViewTextBoxColumn"
        Me.ServicioNombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioNombreDataGridViewTextBoxColumn.Visible = False
        '
        'ServiciodniDataGridViewTextBoxColumn
        '
        Me.ServiciodniDataGridViewTextBoxColumn.DataPropertyName = "Servicio_dni"
        Me.ServiciodniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.ServiciodniDataGridViewTextBoxColumn.Name = "ServiciodniDataGridViewTextBoxColumn"
        Me.ServiciodniDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiciodniDataGridViewTextBoxColumn.Visible = False
        '
        'ServiciodirDataGridViewTextBoxColumn
        '
        Me.ServiciodirDataGridViewTextBoxColumn.DataPropertyName = "Servicio_dir"
        Me.ServiciodirDataGridViewTextBoxColumn.HeaderText = "Servicio_dir"
        Me.ServiciodirDataGridViewTextBoxColumn.Name = "ServiciodirDataGridViewTextBoxColumn"
        Me.ServiciodirDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiciodirDataGridViewTextBoxColumn.Visible = False
        '
        'ServiciotelDataGridViewTextBoxColumn
        '
        Me.ServiciotelDataGridViewTextBoxColumn.DataPropertyName = "Servicio_tel"
        Me.ServiciotelDataGridViewTextBoxColumn.HeaderText = "Servicio_tel"
        Me.ServiciotelDataGridViewTextBoxColumn.Name = "ServiciotelDataGridViewTextBoxColumn"
        Me.ServiciotelDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiciotelDataGridViewTextBoxColumn.Visible = False
        '
        'Servicio_Estado
        '
        Me.Servicio_Estado.DataPropertyName = "Servicio_Estado"
        Me.Servicio_Estado.HeaderText = "Estado"
        Me.Servicio_Estado.Name = "Servicio_Estado"
        Me.Servicio_Estado.ReadOnly = True
        '
        'USUidDataGridViewTextBoxColumn
        '
        Me.USUidDataGridViewTextBoxColumn.DataPropertyName = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.HeaderText = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.Name = "USUidDataGridViewTextBoxColumn"
        Me.USUidDataGridViewTextBoxColumn.ReadOnly = True
        Me.USUidDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioDiagnosticoDataGridViewTextBoxColumn
        '
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "Servicio_Diagnostico"
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn.HeaderText = "Servicio_Diagnostico"
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn.Name = "ServicioDiagnosticoDataGridViewTextBoxColumn"
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn.Visible = False
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioSucursalDataGridViewTextBoxColumn
        '
        Me.ServicioSucursalDataGridViewTextBoxColumn.DataPropertyName = "Servicio_Sucursal"
        Me.ServicioSucursalDataGridViewTextBoxColumn.HeaderText = "Servicio_Sucursal"
        Me.ServicioSucursalDataGridViewTextBoxColumn.Name = "ServicioSucursalDataGridViewTextBoxColumn"
        Me.ServicioSucursalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioSucursalDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioEquipoDataGridViewTextBoxColumn
        '
        Me.ServicioEquipoDataGridViewTextBoxColumn.DataPropertyName = "Servicio_Equipo"
        Me.ServicioEquipoDataGridViewTextBoxColumn.HeaderText = "Servicio_Equipo"
        Me.ServicioEquipoDataGridViewTextBoxColumn.Name = "ServicioEquipoDataGridViewTextBoxColumn"
        Me.ServicioEquipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioEquipoDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioFechaRevDataGridViewTextBoxColumn
        '
        Me.ServicioFechaRevDataGridViewTextBoxColumn.DataPropertyName = "Servicio_FechaRev"
        Me.ServicioFechaRevDataGridViewTextBoxColumn.HeaderText = "Servicio_FechaRev"
        Me.ServicioFechaRevDataGridViewTextBoxColumn.Name = "ServicioFechaRevDataGridViewTextBoxColumn"
        Me.ServicioFechaRevDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioFechaRevDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioFechaRepDataGridViewTextBoxColumn
        '
        Me.ServicioFechaRepDataGridViewTextBoxColumn.DataPropertyName = "Servicio_FechaRep"
        Me.ServicioFechaRepDataGridViewTextBoxColumn.HeaderText = "Servicio_FechaRep"
        Me.ServicioFechaRepDataGridViewTextBoxColumn.Name = "ServicioFechaRepDataGridViewTextBoxColumn"
        Me.ServicioFechaRepDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioFechaRepDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioObtenerBindingSource
        '
        Me.ServicioObtenerBindingSource.DataMember = "Servicio_Obtener"
        Me.ServicioObtenerBindingSource.DataSource = Me.Servicio_DS
        '
        'Servicio_DS
        '
        Me.Servicio_DS.DataSetName = "Servicio_DS"
        Me.Servicio_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Servicio_Consulta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(913, 623)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox_buscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Anular)
        Me.Controls.Add(Me.ComboBox_suc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Detalle)
        Me.Controls.Add(Me.DG_Servicio)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Servicio_Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Servicio"
        CType(Me.DG_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioObtenerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servicio_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Detalle As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_suc As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Anular As System.Windows.Forms.Button
    Friend WithEvents DG_Servicio As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_buscar As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ServicioidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIFanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciofechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioimeiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioMarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciobatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioObsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioManoObraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioAnticipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciodniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciodirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciotelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio_Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioDiagnosticoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioSucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioEquipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioFechaRevDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioFechaRepDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioObtenerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Servicio_DS As Aplicacion.Servicio_DS
End Class
