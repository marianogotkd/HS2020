<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sesion_registro_x_paciente
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagridview1 = New System.Windows.Forms.DataGridView()
        Me.SesionactualtodospacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_enfermeria = New Aplicacion.Ds_enfermeria()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_Dni_Cuit = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tb_numafi = New System.Windows.Forms.TextBox()
        Me.tb_obsoc = New System.Windows.Forms.TextBox()
        Me.tb_sexo = New System.Windows.Forms.TextBox()
        Me.tb_edad = New System.Windows.Forms.TextBox()
        Me.tb_fecnac = New System.Windows.Forms.TextBox()
        Me.tb_nombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lb_total_insumos = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasesionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant_y_unid_medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumosconsumidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Ln_totalreusos = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Dialisis_Filtro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltroidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltrofechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltrocantreusoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltrosxpacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DialisisidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAcdirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACnumafiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrasocialnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesasistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_sesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sucursal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SesionactualtodospacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsumosconsumidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltrosxpacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.datagridview1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(795, 224)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "REGISTRO DE SESIONES DEL PACIENTE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 20)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "Total de sesiones del paciente:"
        '
        'datagridview1
        '
        Me.datagridview1.AllowUserToAddRows = False
        Me.datagridview1.AllowUserToDeleteRows = False
        Me.datagridview1.AllowUserToResizeRows = False
        Me.datagridview1.AutoGenerateColumns = False
        Me.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview1.BackgroundColor = System.Drawing.Color.White
        Me.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.SesionesidDataGridViewTextBoxColumn, Me.PACidDataGridViewTextBoxColumn, Me.SesionesfechaDataGridViewTextBoxColumn, Me.DialisisidDataGridViewTextBoxColumn, Me.PACdniDataGridViewTextBoxColumn, Me.PacienteDataGridViewTextBoxColumn, Me.PAcdirDataGridViewTextBoxColumn, Me.PACnumafiDataGridViewTextBoxColumn, Me.ObrasocialnombreDataGridViewTextBoxColumn, Me.SesionesasistenciaDataGridViewTextBoxColumn, Me.Estado_sesion, Me.sucursal_id})
        Me.datagridview1.DataSource = Me.SesionactualtodospacientesBindingSource
        Me.datagridview1.Location = New System.Drawing.Point(7, 51)
        Me.datagridview1.Margin = New System.Windows.Forms.Padding(4)
        Me.datagridview1.MultiSelect = False
        Me.datagridview1.Name = "datagridview1"
        Me.datagridview1.ReadOnly = True
        Me.datagridview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.datagridview1.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridview1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview1.Size = New System.Drawing.Size(772, 164)
        Me.datagridview1.StandardTab = True
        Me.datagridview1.TabIndex = 258
        '
        'SesionactualtodospacientesBindingSource
        '
        Me.SesionactualtodospacientesBindingSource.DataMember = "Sesion_actual_todos_pacientes"
        Me.SesionactualtodospacientesBindingSource.DataSource = Me.Ds_enfermeria
        '
        'Ds_enfermeria
        '
        Me.Ds_enfermeria.DataSetName = "Ds_enfermeria"
        Me.Ds_enfermeria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button1.Location = New System.Drawing.Point(342, 429)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 44)
        Me.Button1.TabIndex = 265
        Me.Button1.Text = "Protocolo de Dialisis"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.icono_editar_30x30
        Me.Button3.Location = New System.Drawing.Point(519, 429)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 44)
        Me.Button3.TabIndex = 264
        Me.Button3.Text = "Ver Sesion"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.tb_Dni_Cuit)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.tb_numafi)
        Me.GroupBox1.Controls.Add(Me.tb_obsoc)
        Me.GroupBox1.Controls.Add(Me.tb_sexo)
        Me.GroupBox1.Controls.Add(Me.tb_edad)
        Me.GroupBox1.Controls.Add(Me.tb_fecnac)
        Me.GroupBox1.Controls.Add(Me.tb_nombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 128)
        Me.GroupBox1.TabIndex = 252
        Me.GroupBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(6, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(161, 20)
        Me.Label17.TabIndex = 268
        Me.Label17.Text = "Datos del Paciente"
        '
        'tb_Dni_Cuit
        '
        Me.tb_Dni_Cuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_Dni_Cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Dni_Cuit.Location = New System.Drawing.Point(59, 65)
        Me.tb_Dni_Cuit.Name = "tb_Dni_Cuit"
        Me.tb_Dni_Cuit.ReadOnly = True
        Me.tb_Dni_Cuit.Size = New System.Drawing.Size(219, 20)
        Me.tb_Dni_Cuit.TabIndex = 267
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 266
        Me.Label21.Text = "DNI:"
        '
        'tb_numafi
        '
        Me.tb_numafi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_numafi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_numafi.Location = New System.Drawing.Point(626, 91)
        Me.tb_numafi.Name = "tb_numafi"
        Me.tb_numafi.ReadOnly = True
        Me.tb_numafi.Size = New System.Drawing.Size(153, 20)
        Me.tb_numafi.TabIndex = 265
        '
        'tb_obsoc
        '
        Me.tb_obsoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_obsoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_obsoc.Location = New System.Drawing.Point(626, 65)
        Me.tb_obsoc.Name = "tb_obsoc"
        Me.tb_obsoc.ReadOnly = True
        Me.tb_obsoc.Size = New System.Drawing.Size(153, 20)
        Me.tb_obsoc.TabIndex = 264
        '
        'tb_sexo
        '
        Me.tb_sexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_sexo.Location = New System.Drawing.Point(626, 39)
        Me.tb_sexo.Name = "tb_sexo"
        Me.tb_sexo.ReadOnly = True
        Me.tb_sexo.Size = New System.Drawing.Size(153, 20)
        Me.tb_sexo.TabIndex = 263
        '
        'tb_edad
        '
        Me.tb_edad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_edad.Location = New System.Drawing.Point(401, 39)
        Me.tb_edad.Name = "tb_edad"
        Me.tb_edad.ReadOnly = True
        Me.tb_edad.Size = New System.Drawing.Size(150, 20)
        Me.tb_edad.TabIndex = 262
        '
        'tb_fecnac
        '
        Me.tb_fecnac.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_fecnac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fecnac.Location = New System.Drawing.Point(401, 65)
        Me.tb_fecnac.Name = "tb_fecnac"
        Me.tb_fecnac.ReadOnly = True
        Me.tb_fecnac.Size = New System.Drawing.Size(150, 20)
        Me.tb_fecnac.TabIndex = 261
        '
        'tb_nombre
        '
        Me.tb_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(59, 39)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.ReadOnly = True
        Me.tb_nombre.Size = New System.Drawing.Size(219, 20)
        Me.tb_nombre.TabIndex = 255
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 254
        Me.Label6.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(284, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 260
        Me.Label10.Text = "Fecha de Nacimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Edad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(557, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 257
        Me.Label7.Text = "Sexo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(557, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 252
        Me.Label4.Text = "Obra social:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(553, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 259
        Me.Label8.Text = "Nro. Afiliado:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lb_total_insumos)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(795, 222)
        Me.GroupBox3.TabIndex = 267
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESUMEN DE INSUMOS CONSUMIDOS"
        '
        'lb_total_insumos
        '
        Me.lb_total_insumos.AutoSize = True
        Me.lb_total_insumos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total_insumos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lb_total_insumos.Location = New System.Drawing.Point(7, 19)
        Me.lb_total_insumos.Name = "lb_total_insumos"
        Me.lb_total_insumos.Size = New System.Drawing.Size(250, 20)
        Me.lb_total_insumos.TabIndex = 261
        Me.lb_total_insumos.Text = "Total de insumos consumidos:"
        Me.lb_total_insumos.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ConsumomercaderiaidDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.SesionesidDataGridViewTextBoxColumn1, Me.FechasesionDataGridViewTextBoxColumn, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.InsumoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.cant_y_unid_medida})
        Me.DataGridView2.DataSource = Me.InsumosconsumidosBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(11, 48)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(772, 164)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 259
        '
        'ConsumomercaderiaidDataGridViewTextBoxColumn
        '
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn.DataPropertyName = "Consumo_mercaderia_id"
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn.HeaderText = "Consumo_mercaderia_id"
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn.Name = "ConsumomercaderiaidDataGridViewTextBoxColumn"
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Visible = False
        '
        'SesionesidDataGridViewTextBoxColumn1
        '
        Me.SesionesidDataGridViewTextBoxColumn1.DataPropertyName = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn1.HeaderText = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn1.Name = "SesionesidDataGridViewTextBoxColumn1"
        Me.SesionesidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SesionesidDataGridViewTextBoxColumn1.Visible = False
        '
        'FechasesionDataGridViewTextBoxColumn
        '
        Me.FechasesionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechasesionDataGridViewTextBoxColumn.DataPropertyName = "fecha_sesion"
        Me.FechasesionDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechasesionDataGridViewTextBoxColumn.Name = "FechasesionDataGridViewTextBoxColumn"
        Me.FechasesionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechasesionDataGridViewTextBoxColumn.Visible = False
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InsumoDataGridViewTextBoxColumn
        '
        Me.InsumoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InsumoDataGridViewTextBoxColumn.DataPropertyName = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn.HeaderText = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn.Name = "InsumoDataGridViewTextBoxColumn"
        Me.InsumoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Visible = False
        '
        'cant_y_unid_medida
        '
        Me.cant_y_unid_medida.DataPropertyName = "cant_y_unid_medida"
        Me.cant_y_unid_medida.HeaderText = "Cantidad"
        Me.cant_y_unid_medida.Name = "cant_y_unid_medida"
        Me.cant_y_unid_medida.ReadOnly = True
        '
        'InsumosconsumidosBindingSource
        '
        Me.InsumosconsumidosBindingSource.DataMember = "insumos_consumidos"
        Me.InsumosconsumidosBindingSource.DataSource = Me.Ds_enfermeria
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button2.Location = New System.Drawing.Point(166, 429)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 44)
        Me.Button2.TabIndex = 268
        Me.Button2.Text = "Dialisis y consumos"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(11, 146)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 274)
        Me.TabControl1.TabIndex = 269
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro de sesiones del paciente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resumen de insumos consumidos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Ln_totalreusos)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(810, 248)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Resumen de filtros utilizados"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Ln_totalreusos
        '
        Me.Ln_totalreusos.AutoSize = True
        Me.Ln_totalreusos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ln_totalreusos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Ln_totalreusos.Location = New System.Drawing.Point(15, 9)
        Me.Ln_totalreusos.Name = "Ln_totalreusos"
        Me.Ln_totalreusos.Size = New System.Drawing.Size(138, 20)
        Me.Ln_totalreusos.TabIndex = 262
        Me.Ln_totalreusos.Text = "Total de reusos:"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dialisis_Filtro, Me.FiltroidDataGridViewTextBoxColumn, Me.FiltrofechaDataGridViewTextBoxColumn, Me.FiltrocantreusoDataGridViewTextBoxColumn, Me.SesionesidDataGridViewTextBoxColumn2})
        Me.DataGridView3.DataSource = Me.FiltrosxpacienteBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(19, 42)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView3.RowHeadersVisible = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(772, 164)
        Me.DataGridView3.StandardTab = True
        Me.DataGridView3.TabIndex = 260
        '
        'Dialisis_Filtro
        '
        Me.Dialisis_Filtro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Dialisis_Filtro.DataPropertyName = "Dialisis_Filtro"
        Me.Dialisis_Filtro.HeaderText = "Filtro"
        Me.Dialisis_Filtro.Name = "Dialisis_Filtro"
        Me.Dialisis_Filtro.ReadOnly = True
        '
        'FiltroidDataGridViewTextBoxColumn
        '
        Me.FiltroidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FiltroidDataGridViewTextBoxColumn.DataPropertyName = "Filtro_id"
        Me.FiltroidDataGridViewTextBoxColumn.HeaderText = "Filtro_id"
        Me.FiltroidDataGridViewTextBoxColumn.Name = "FiltroidDataGridViewTextBoxColumn"
        Me.FiltroidDataGridViewTextBoxColumn.ReadOnly = True
        Me.FiltroidDataGridViewTextBoxColumn.Visible = False
        '
        'FiltrofechaDataGridViewTextBoxColumn
        '
        Me.FiltrofechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FiltrofechaDataGridViewTextBoxColumn.DataPropertyName = "Filtro_fecha"
        Me.FiltrofechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FiltrofechaDataGridViewTextBoxColumn.Name = "FiltrofechaDataGridViewTextBoxColumn"
        Me.FiltrofechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FiltrocantreusoDataGridViewTextBoxColumn
        '
        Me.FiltrocantreusoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FiltrocantreusoDataGridViewTextBoxColumn.DataPropertyName = "Filtro_cant_reuso"
        Me.FiltrocantreusoDataGridViewTextBoxColumn.HeaderText = "Reusos"
        Me.FiltrocantreusoDataGridViewTextBoxColumn.Name = "FiltrocantreusoDataGridViewTextBoxColumn"
        Me.FiltrocantreusoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SesionesidDataGridViewTextBoxColumn2
        '
        Me.SesionesidDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SesionesidDataGridViewTextBoxColumn2.DataPropertyName = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn2.HeaderText = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn2.Name = "SesionesidDataGridViewTextBoxColumn2"
        Me.SesionesidDataGridViewTextBoxColumn2.ReadOnly = True
        Me.SesionesidDataGridViewTextBoxColumn2.Visible = False
        '
        'FiltrosxpacienteBindingSource
        '
        Me.FiltrosxpacienteBindingSource.DataMember = "filtros_x_paciente"
        Me.FiltrosxpacienteBindingSource.DataSource = Me.Ds_enfermeria
        '
        'item
        '
        Me.item.HeaderText = "Nº"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SesionesidDataGridViewTextBoxColumn
        '
        Me.SesionesidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SesionesidDataGridViewTextBoxColumn.DataPropertyName = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.SesionesidDataGridViewTextBoxColumn.Name = "SesionesidDataGridViewTextBoxColumn"
        Me.SesionesidDataGridViewTextBoxColumn.ReadOnly = True
        Me.SesionesidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SesionesidDataGridViewTextBoxColumn.Visible = False
        '
        'PACidDataGridViewTextBoxColumn
        '
        Me.PACidDataGridViewTextBoxColumn.DataPropertyName = "PAC_id"
        Me.PACidDataGridViewTextBoxColumn.HeaderText = "PAC_id"
        Me.PACidDataGridViewTextBoxColumn.Name = "PACidDataGridViewTextBoxColumn"
        Me.PACidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PACidDataGridViewTextBoxColumn.Visible = False
        '
        'SesionesfechaDataGridViewTextBoxColumn
        '
        Me.SesionesfechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SesionesfechaDataGridViewTextBoxColumn.DataPropertyName = "Sesiones_fecha"
        Me.SesionesfechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.SesionesfechaDataGridViewTextBoxColumn.Name = "SesionesfechaDataGridViewTextBoxColumn"
        Me.SesionesfechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SesionesfechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DialisisidDataGridViewTextBoxColumn
        '
        Me.DialisisidDataGridViewTextBoxColumn.DataPropertyName = "Dialisis_id"
        Me.DialisisidDataGridViewTextBoxColumn.HeaderText = "Dialisis_id"
        Me.DialisisidDataGridViewTextBoxColumn.Name = "DialisisidDataGridViewTextBoxColumn"
        Me.DialisisidDataGridViewTextBoxColumn.ReadOnly = True
        Me.DialisisidDataGridViewTextBoxColumn.Visible = False
        '
        'PACdniDataGridViewTextBoxColumn
        '
        Me.PACdniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PACdniDataGridViewTextBoxColumn.DataPropertyName = "PAC_dni"
        Me.PACdniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.PACdniDataGridViewTextBoxColumn.Name = "PACdniDataGridViewTextBoxColumn"
        Me.PACdniDataGridViewTextBoxColumn.ReadOnly = True
        Me.PACdniDataGridViewTextBoxColumn.Visible = False
        '
        'PacienteDataGridViewTextBoxColumn
        '
        Me.PacienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.HeaderText = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.Name = "PacienteDataGridViewTextBoxColumn"
        Me.PacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.PacienteDataGridViewTextBoxColumn.Visible = False
        '
        'PAcdirDataGridViewTextBoxColumn
        '
        Me.PAcdirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PAcdirDataGridViewTextBoxColumn.DataPropertyName = "PAc_dir"
        Me.PAcdirDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.PAcdirDataGridViewTextBoxColumn.Name = "PAcdirDataGridViewTextBoxColumn"
        Me.PAcdirDataGridViewTextBoxColumn.ReadOnly = True
        Me.PAcdirDataGridViewTextBoxColumn.Visible = False
        '
        'PACnumafiDataGridViewTextBoxColumn
        '
        Me.PACnumafiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PACnumafiDataGridViewTextBoxColumn.DataPropertyName = "PACnumafi"
        Me.PACnumafiDataGridViewTextBoxColumn.HeaderText = "N Afiliado"
        Me.PACnumafiDataGridViewTextBoxColumn.Name = "PACnumafiDataGridViewTextBoxColumn"
        Me.PACnumafiDataGridViewTextBoxColumn.ReadOnly = True
        Me.PACnumafiDataGridViewTextBoxColumn.Visible = False
        '
        'ObrasocialnombreDataGridViewTextBoxColumn
        '
        Me.ObrasocialnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ObrasocialnombreDataGridViewTextBoxColumn.DataPropertyName = "Obrasocial_nombre"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.HeaderText = "Obra Social"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.Name = "ObrasocialnombreDataGridViewTextBoxColumn"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObrasocialnombreDataGridViewTextBoxColumn.Visible = False
        '
        'SesionesasistenciaDataGridViewTextBoxColumn
        '
        Me.SesionesasistenciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SesionesasistenciaDataGridViewTextBoxColumn.DataPropertyName = "Sesiones_asistencia"
        Me.SesionesasistenciaDataGridViewTextBoxColumn.HeaderText = "Asistencia"
        Me.SesionesasistenciaDataGridViewTextBoxColumn.Name = "SesionesasistenciaDataGridViewTextBoxColumn"
        Me.SesionesasistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SesionesasistenciaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Estado_sesion
        '
        Me.Estado_sesion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Estado_sesion.DataPropertyName = "Estado_sesion"
        Me.Estado_sesion.HeaderText = "Estado"
        Me.Estado_sesion.Name = "Estado_sesion"
        Me.Estado_sesion.ReadOnly = True
        '
        'sucursal_id
        '
        Me.sucursal_id.DataPropertyName = "sucursal_id"
        Me.sucursal_id.HeaderText = "sucursal_id"
        Me.sucursal_id.Name = "sucursal_id"
        Me.sucursal_id.ReadOnly = True
        Me.sucursal_id.Visible = False
        '
        'Sesion_registro_x_paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 486)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sesion_registro_x_paciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Sesiones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SesionactualtodospacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsumosconsumidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltrosxpacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datagridview1 As System.Windows.Forms.DataGridView
    Friend WithEvents SesionactualtodospacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_enfermeria As Aplicacion.Ds_enfermeria
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tb_Dni_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tb_numafi As System.Windows.Forms.TextBox
    Friend WithEvents tb_obsoc As System.Windows.Forms.TextBox
    Friend WithEvents tb_sexo As System.Windows.Forms.TextBox
    Friend WithEvents tb_edad As System.Windows.Forms.TextBox
    Friend WithEvents tb_fecnac As System.Windows.Forms.TextBox
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents InsumosconsumidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lb_total_insumos As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents FiltrosxpacienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dialisis_Filtro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FiltroidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FiltrofechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FiltrocantreusoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ln_totalreusos As System.Windows.Forms.Label
    Friend WithEvents ConsumomercaderiaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechasesionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsumoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant_y_unid_medida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DialisisidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAcdirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACnumafiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObrasocialnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesasistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado_sesion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sucursal_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
