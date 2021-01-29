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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DG_Servicio = New System.Windows.Forms.DataGridView()
        Me.ServicioObtenerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Servicio_DS = New Aplicacion.Servicio_DS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_suc = New System.Windows.Forms.ComboBox()
        Me.Button_Detalle = New System.Windows.Forms.Button()
        Me.btn_Anular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_buscar = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DG_OrdenTrabajo = New System.Windows.Forms.DataGridView()
        Me.OrdentrabajoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIFanDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioFechaRepDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciofechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioimeiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioMarcaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioModeloDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioColorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciobatDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioObsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioManoObraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioAnticipoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioNombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciodniDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciodirDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciotelDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioSucursalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioEquipoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioFechaRevDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdentrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ServicioidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio_Desc_peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio_Desc_porc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio_IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIFanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioFechaRevDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ServicioSucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioEquipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioFechaRepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DG_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioObtenerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servicio_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DG_OrdenTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdentrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DG_Servicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServicioidDataGridViewTextBoxColumn, Me.Servicio_Desc_peso, Me.Servicio_Desc_porc, Me.Servicio_IVA, Me.CLIidDataGridViewTextBoxColumn, Me.CLIFanDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.ServicioFechaRevDataGridViewTextBoxColumn, Me.ServiciofechaDataGridViewTextBoxColumn, Me.ServicioimeiDataGridViewTextBoxColumn, Me.ServicioMarcaDataGridViewTextBoxColumn, Me.ServicioModeloDataGridViewTextBoxColumn, Me.ServicioColorDataGridViewTextBoxColumn, Me.ServiciobatDataGridViewTextBoxColumn, Me.ServicioObsDataGridViewTextBoxColumn, Me.ServicioManoObraDataGridViewTextBoxColumn, Me.ServicioAnticipoDataGridViewTextBoxColumn, Me.ServicioNombreDataGridViewTextBoxColumn, Me.ServiciodniDataGridViewTextBoxColumn, Me.ServiciodirDataGridViewTextBoxColumn, Me.ServiciotelDataGridViewTextBoxColumn, Me.Servicio_Estado, Me.USUidDataGridViewTextBoxColumn, Me.ServicioDiagnosticoDataGridViewTextBoxColumn, Me.ServicioSucursalDataGridViewTextBoxColumn, Me.ServicioEquipoDataGridViewTextBoxColumn, Me.ServicioFechaRepDataGridViewTextBoxColumn})
        Me.DG_Servicio.DataSource = Me.ServicioObtenerBindingSource
        Me.DG_Servicio.Location = New System.Drawing.Point(14, 39)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
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
        Me.ComboBox_suc.Location = New System.Drawing.Point(87, 13)
        Me.ComboBox_suc.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_suc.Name = "ComboBox_suc"
        Me.ComboBox_suc.Size = New System.Drawing.Size(313, 24)
        Me.ComboBox_suc.TabIndex = 12
        '
        'Button_Detalle
        '
        Me.Button_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Detalle.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_Detalle.Location = New System.Drawing.Point(746, 515)
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
        Me.btn_Anular.Location = New System.Drawing.Point(614, 515)
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
        Me.Label2.Location = New System.Drawing.Point(414, 15)
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
        Me.ComboBox_buscar.Items.AddRange(New Object() {"Nº de Revisión", "Cliente"})
        Me.ComboBox_buscar.Location = New System.Drawing.Point(496, 7)
        Me.ComboBox_buscar.Name = "ComboBox_buscar"
        Me.ComboBox_buscar.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_buscar.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(623, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 22)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(893, 593)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.btn_Anular)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button_Detalle)
        Me.TabPage1.Controls.Add(Me.ComboBox_buscar)
        Me.TabPage1.Controls.Add(Me.DG_Servicio)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(885, 564)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ordenes de revisión"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.DG_OrdenTrabajo)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(885, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ordenes de trabajo"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.Button1.Location = New System.Drawing.Point(614, 515)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Anular"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button2.Location = New System.Drawing.Point(746, 515)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 43)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Ver"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DG_OrdenTrabajo
        '
        Me.DG_OrdenTrabajo.AllowUserToAddRows = False
        Me.DG_OrdenTrabajo.AllowUserToDeleteRows = False
        Me.DG_OrdenTrabajo.AllowUserToResizeRows = False
        Me.DG_OrdenTrabajo.AutoGenerateColumns = False
        Me.DG_OrdenTrabajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_OrdenTrabajo.BackgroundColor = System.Drawing.Color.White
        Me.DG_OrdenTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_OrdenTrabajo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrdentrabajoidDataGridViewTextBoxColumn, Me.CLIFanDataGridViewTextBoxColumn1, Me.CLIdniDataGridViewTextBoxColumn1, Me.ServicioFechaRepDataGridViewTextBoxColumn1, Me.ServicioEstado, Me.ServiciofechaDataGridViewTextBoxColumn1, Me.ServicioimeiDataGridViewTextBoxColumn1, Me.ServicioMarcaDataGridViewTextBoxColumn1, Me.ServicioModeloDataGridViewTextBoxColumn1, Me.ServicioColorDataGridViewTextBoxColumn1, Me.ServiciobatDataGridViewTextBoxColumn1, Me.ServicioObsDataGridViewTextBoxColumn1, Me.ServicioManoObraDataGridViewTextBoxColumn1, Me.ServicioAnticipoDataGridViewTextBoxColumn1, Me.ServicioNombreDataGridViewTextBoxColumn1, Me.ServiciodniDataGridViewTextBoxColumn1, Me.ServiciodirDataGridViewTextBoxColumn1, Me.ServiciotelDataGridViewTextBoxColumn1, Me.USUidDataGridViewTextBoxColumn1, Me.ServicioDiagnosticoDataGridViewTextBoxColumn1, Me.ServicioSucursalDataGridViewTextBoxColumn1, Me.ServicioEquipoDataGridViewTextBoxColumn1, Me.ServicioFechaRevDataGridViewTextBoxColumn1, Me.ServicioidDataGridViewTextBoxColumn1, Me.CLIidDataGridViewTextBoxColumn1})
        Me.DG_OrdenTrabajo.DataSource = Me.OrdentrabajoBindingSource
        Me.DG_OrdenTrabajo.Location = New System.Drawing.Point(14, 39)
        Me.DG_OrdenTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_OrdenTrabajo.MultiSelect = False
        Me.DG_OrdenTrabajo.Name = "DG_OrdenTrabajo"
        Me.DG_OrdenTrabajo.ReadOnly = True
        Me.DG_OrdenTrabajo.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_OrdenTrabajo.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_OrdenTrabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_OrdenTrabajo.Size = New System.Drawing.Size(856, 468)
        Me.DG_OrdenTrabajo.StandardTab = True
        Me.DG_OrdenTrabajo.TabIndex = 20
        '
        'OrdentrabajoidDataGridViewTextBoxColumn
        '
        Me.OrdentrabajoidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrdentrabajoidDataGridViewTextBoxColumn.DataPropertyName = "Orden_trabajo_id"
        Me.OrdentrabajoidDataGridViewTextBoxColumn.HeaderText = "Nº Orden de Trabajo"
        Me.OrdentrabajoidDataGridViewTextBoxColumn.Name = "OrdentrabajoidDataGridViewTextBoxColumn"
        Me.OrdentrabajoidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIFanDataGridViewTextBoxColumn1
        '
        Me.CLIFanDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIFanDataGridViewTextBoxColumn1.DataPropertyName = "CLI_Fan"
        Me.CLIFanDataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.CLIFanDataGridViewTextBoxColumn1.Name = "CLIFanDataGridViewTextBoxColumn1"
        Me.CLIFanDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CLIdniDataGridViewTextBoxColumn1
        '
        Me.CLIdniDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIdniDataGridViewTextBoxColumn1.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn1.HeaderText = "DNI"
        Me.CLIdniDataGridViewTextBoxColumn1.Name = "CLIdniDataGridViewTextBoxColumn1"
        Me.CLIdniDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ServicioFechaRepDataGridViewTextBoxColumn1
        '
        Me.ServicioFechaRepDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServicioFechaRepDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_FechaRep"
        Me.ServicioFechaRepDataGridViewTextBoxColumn1.HeaderText = "Fecha Reparación"
        Me.ServicioFechaRepDataGridViewTextBoxColumn1.Name = "ServicioFechaRepDataGridViewTextBoxColumn1"
        Me.ServicioFechaRepDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ServicioEstado
        '
        Me.ServicioEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServicioEstado.DataPropertyName = "Servicio_Estado"
        Me.ServicioEstado.HeaderText = "Estado"
        Me.ServicioEstado.Name = "ServicioEstado"
        Me.ServicioEstado.ReadOnly = True
        '
        'ServiciofechaDataGridViewTextBoxColumn1
        '
        Me.ServiciofechaDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_fecha"
        Me.ServiciofechaDataGridViewTextBoxColumn1.HeaderText = "Servicio_fecha"
        Me.ServiciofechaDataGridViewTextBoxColumn1.Name = "ServiciofechaDataGridViewTextBoxColumn1"
        Me.ServiciofechaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServiciofechaDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioimeiDataGridViewTextBoxColumn1
        '
        Me.ServicioimeiDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_imei"
        Me.ServicioimeiDataGridViewTextBoxColumn1.HeaderText = "Servicio_imei"
        Me.ServicioimeiDataGridViewTextBoxColumn1.Name = "ServicioimeiDataGridViewTextBoxColumn1"
        Me.ServicioimeiDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioimeiDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioMarcaDataGridViewTextBoxColumn1
        '
        Me.ServicioMarcaDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_Marca"
        Me.ServicioMarcaDataGridViewTextBoxColumn1.HeaderText = "Servicio_Marca"
        Me.ServicioMarcaDataGridViewTextBoxColumn1.Name = "ServicioMarcaDataGridViewTextBoxColumn1"
        Me.ServicioMarcaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioMarcaDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioModeloDataGridViewTextBoxColumn1
        '
        Me.ServicioModeloDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_Modelo"
        Me.ServicioModeloDataGridViewTextBoxColumn1.HeaderText = "Servicio_Modelo"
        Me.ServicioModeloDataGridViewTextBoxColumn1.Name = "ServicioModeloDataGridViewTextBoxColumn1"
        Me.ServicioModeloDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioModeloDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioColorDataGridViewTextBoxColumn1
        '
        Me.ServicioColorDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_Color"
        Me.ServicioColorDataGridViewTextBoxColumn1.HeaderText = "Servicio_Color"
        Me.ServicioColorDataGridViewTextBoxColumn1.Name = "ServicioColorDataGridViewTextBoxColumn1"
        Me.ServicioColorDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioColorDataGridViewTextBoxColumn1.Visible = False
        '
        'ServiciobatDataGridViewTextBoxColumn1
        '
        Me.ServiciobatDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_bat"
        Me.ServiciobatDataGridViewTextBoxColumn1.HeaderText = "Servicio_bat"
        Me.ServiciobatDataGridViewTextBoxColumn1.Name = "ServiciobatDataGridViewTextBoxColumn1"
        Me.ServiciobatDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServiciobatDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioObsDataGridViewTextBoxColumn1
        '
        Me.ServicioObsDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_Obs"
        Me.ServicioObsDataGridViewTextBoxColumn1.HeaderText = "Servicio_Obs"
        Me.ServicioObsDataGridViewTextBoxColumn1.Name = "ServicioObsDataGridViewTextBoxColumn1"
        Me.ServicioObsDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioObsDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioManoObraDataGridViewTextBoxColumn1
        '
        Me.ServicioManoObraDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_ManoObra"
        Me.ServicioManoObraDataGridViewTextBoxColumn1.HeaderText = "Servicio_ManoObra"
        Me.ServicioManoObraDataGridViewTextBoxColumn1.Name = "ServicioManoObraDataGridViewTextBoxColumn1"
        Me.ServicioManoObraDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioManoObraDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioAnticipoDataGridViewTextBoxColumn1
        '
        Me.ServicioAnticipoDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_Anticipo"
        Me.ServicioAnticipoDataGridViewTextBoxColumn1.HeaderText = "Servicio_Anticipo"
        Me.ServicioAnticipoDataGridViewTextBoxColumn1.Name = "ServicioAnticipoDataGridViewTextBoxColumn1"
        Me.ServicioAnticipoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioAnticipoDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioNombreDataGridViewTextBoxColumn1
        '
        Me.ServicioNombreDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_Nombre"
        Me.ServicioNombreDataGridViewTextBoxColumn1.HeaderText = "Servicio_Nombre"
        Me.ServicioNombreDataGridViewTextBoxColumn1.Name = "ServicioNombreDataGridViewTextBoxColumn1"
        Me.ServicioNombreDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioNombreDataGridViewTextBoxColumn1.Visible = False
        '
        'ServiciodniDataGridViewTextBoxColumn1
        '
        Me.ServiciodniDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_dni"
        Me.ServiciodniDataGridViewTextBoxColumn1.HeaderText = "Servicio_dni"
        Me.ServiciodniDataGridViewTextBoxColumn1.Name = "ServiciodniDataGridViewTextBoxColumn1"
        Me.ServiciodniDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServiciodniDataGridViewTextBoxColumn1.Visible = False
        '
        'ServiciodirDataGridViewTextBoxColumn1
        '
        Me.ServiciodirDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_dir"
        Me.ServiciodirDataGridViewTextBoxColumn1.HeaderText = "Servicio_dir"
        Me.ServiciodirDataGridViewTextBoxColumn1.Name = "ServiciodirDataGridViewTextBoxColumn1"
        Me.ServiciodirDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServiciodirDataGridViewTextBoxColumn1.Visible = False
        '
        'ServiciotelDataGridViewTextBoxColumn1
        '
        Me.ServiciotelDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_tel"
        Me.ServiciotelDataGridViewTextBoxColumn1.HeaderText = "Servicio_tel"
        Me.ServiciotelDataGridViewTextBoxColumn1.Name = "ServiciotelDataGridViewTextBoxColumn1"
        Me.ServiciotelDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServiciotelDataGridViewTextBoxColumn1.Visible = False
        '
        'USUidDataGridViewTextBoxColumn1
        '
        Me.USUidDataGridViewTextBoxColumn1.DataPropertyName = "USU_id"
        Me.USUidDataGridViewTextBoxColumn1.HeaderText = "USU_id"
        Me.USUidDataGridViewTextBoxColumn1.Name = "USUidDataGridViewTextBoxColumn1"
        Me.USUidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.USUidDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioDiagnosticoDataGridViewTextBoxColumn1
        '
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_Diagnostico"
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn1.HeaderText = "Servicio_Diagnostico"
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn1.Name = "ServicioDiagnosticoDataGridViewTextBoxColumn1"
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioDiagnosticoDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioSucursalDataGridViewTextBoxColumn1
        '
        Me.ServicioSucursalDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_Sucursal"
        Me.ServicioSucursalDataGridViewTextBoxColumn1.HeaderText = "Servicio_Sucursal"
        Me.ServicioSucursalDataGridViewTextBoxColumn1.Name = "ServicioSucursalDataGridViewTextBoxColumn1"
        Me.ServicioSucursalDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioSucursalDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioEquipoDataGridViewTextBoxColumn1
        '
        Me.ServicioEquipoDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_Equipo"
        Me.ServicioEquipoDataGridViewTextBoxColumn1.HeaderText = "Servicio_Equipo"
        Me.ServicioEquipoDataGridViewTextBoxColumn1.Name = "ServicioEquipoDataGridViewTextBoxColumn1"
        Me.ServicioEquipoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioEquipoDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioFechaRevDataGridViewTextBoxColumn1
        '
        Me.ServicioFechaRevDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_FechaRev"
        Me.ServicioFechaRevDataGridViewTextBoxColumn1.HeaderText = "Servicio_FechaRev"
        Me.ServicioFechaRevDataGridViewTextBoxColumn1.Name = "ServicioFechaRevDataGridViewTextBoxColumn1"
        Me.ServicioFechaRevDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioFechaRevDataGridViewTextBoxColumn1.Visible = False
        '
        'ServicioidDataGridViewTextBoxColumn1
        '
        Me.ServicioidDataGridViewTextBoxColumn1.DataPropertyName = "Servicio_id"
        Me.ServicioidDataGridViewTextBoxColumn1.HeaderText = "Servicio_id"
        Me.ServicioidDataGridViewTextBoxColumn1.Name = "ServicioidDataGridViewTextBoxColumn1"
        Me.ServicioidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ServicioidDataGridViewTextBoxColumn1.Visible = False
        '
        'CLIidDataGridViewTextBoxColumn1
        '
        Me.CLIidDataGridViewTextBoxColumn1.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn1.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn1.Name = "CLIidDataGridViewTextBoxColumn1"
        Me.CLIidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn1.Visible = False
        '
        'OrdentrabajoBindingSource
        '
        Me.OrdentrabajoBindingSource.DataMember = "ordentrabajo"
        Me.OrdentrabajoBindingSource.DataSource = Me.Servicio_DS
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nº de Trabajo", "Cliente"})
        Me.ComboBox1.Location = New System.Drawing.Point(496, 7)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(623, 9)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 22)
        Me.TextBox2.TabIndex = 18
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Buscar por:"
        '
        'ServicioidDataGridViewTextBoxColumn
        '
        Me.ServicioidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServicioidDataGridViewTextBoxColumn.DataPropertyName = "Servicio_id"
        Me.ServicioidDataGridViewTextBoxColumn.HeaderText = "Nº Orden de Revisión"
        Me.ServicioidDataGridViewTextBoxColumn.Name = "ServicioidDataGridViewTextBoxColumn"
        Me.ServicioidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Servicio_Desc_peso
        '
        Me.Servicio_Desc_peso.DataPropertyName = "Servicio_Desc_peso"
        Me.Servicio_Desc_peso.HeaderText = "Servicio_Desc_peso"
        Me.Servicio_Desc_peso.Name = "Servicio_Desc_peso"
        Me.Servicio_Desc_peso.ReadOnly = True
        Me.Servicio_Desc_peso.Visible = False
        '
        'Servicio_Desc_porc
        '
        Me.Servicio_Desc_porc.DataPropertyName = "Servicio_Desc_porc"
        Me.Servicio_Desc_porc.HeaderText = "Servicio_Desc_porc"
        Me.Servicio_Desc_porc.Name = "Servicio_Desc_porc"
        Me.Servicio_Desc_porc.ReadOnly = True
        Me.Servicio_Desc_porc.Visible = False
        '
        'Servicio_IVA
        '
        Me.Servicio_IVA.DataPropertyName = "Servicio_IVA"
        Me.Servicio_IVA.HeaderText = "Servicio_IVA"
        Me.Servicio_IVA.Name = "Servicio_IVA"
        Me.Servicio_IVA.ReadOnly = True
        Me.Servicio_IVA.Visible = False
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'CLIFanDataGridViewTextBoxColumn
        '
        Me.CLIFanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIFanDataGridViewTextBoxColumn.DataPropertyName = "CLI_Fan"
        Me.CLIFanDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.CLIFanDataGridViewTextBoxColumn.Name = "CLIFanDataGridViewTextBoxColumn"
        Me.CLIFanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServicioFechaRevDataGridViewTextBoxColumn
        '
        Me.ServicioFechaRevDataGridViewTextBoxColumn.DataPropertyName = "Servicio_FechaRev"
        Me.ServicioFechaRevDataGridViewTextBoxColumn.HeaderText = "Fecha Revisión"
        Me.ServicioFechaRevDataGridViewTextBoxColumn.Name = "ServicioFechaRevDataGridViewTextBoxColumn"
        Me.ServicioFechaRevDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiciofechaDataGridViewTextBoxColumn
        '
        Me.ServiciofechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ServiciofechaDataGridViewTextBoxColumn.DataPropertyName = "Servicio_fecha"
        Me.ServiciofechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.ServiciofechaDataGridViewTextBoxColumn.Name = "ServiciofechaDataGridViewTextBoxColumn"
        Me.ServiciofechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiciofechaDataGridViewTextBoxColumn.Visible = False
        Me.ServiciofechaDataGridViewTextBoxColumn.Width = 70
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
        Me.ServicioAnticipoDataGridViewTextBoxColumn.Visible = False
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
        Me.Servicio_Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        'ServicioFechaRepDataGridViewTextBoxColumn
        '
        Me.ServicioFechaRepDataGridViewTextBoxColumn.DataPropertyName = "Servicio_FechaRep"
        Me.ServicioFechaRepDataGridViewTextBoxColumn.HeaderText = "Servicio_FechaRep"
        Me.ServicioFechaRepDataGridViewTextBoxColumn.Name = "ServicioFechaRepDataGridViewTextBoxColumn"
        Me.ServicioFechaRepDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioFechaRepDataGridViewTextBoxColumn.Visible = False
        '
        'Servicio_Consulta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(914, 639)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ComboBox_suc)
        Me.Controls.Add(Me.Label1)
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DG_OrdenTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdentrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ServicioObtenerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Servicio_DS As Aplicacion.Servicio_DS
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DG_OrdenTrabajo As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OrdentrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OrdentrabajoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIFanDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioFechaRepDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciofechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioimeiDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioMarcaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioModeloDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioColorDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciobatDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioObsDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioManoObraDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioAnticipoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioNombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciodniDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciodirDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiciotelDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioDiagnosticoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioSucursalDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioEquipoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioFechaRevDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio_Desc_peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio_Desc_porc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio_IVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIFanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioFechaRevDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents ServicioSucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioEquipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioFechaRepDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
