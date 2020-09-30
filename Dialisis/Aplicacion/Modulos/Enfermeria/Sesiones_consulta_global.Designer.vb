<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sesiones_consulta_global
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sesiones_consulta_global))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lb_sesionesausentes = New System.Windows.Forms.Label()
        Me.lb_sesionespresentes = New System.Windows.Forms.Label()
        Me.lb_sesionestotal = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasesionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumosconsumidosausentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_enfermeria = New Aplicacion.Ds_enfermeria()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb_total_insumos = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasesionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumosconsumidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ln_totalreusos = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DialisisFiltroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltroidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltrofechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltrocantreusoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiltrosxpacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker_desde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsumosconsumidosausentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsumosconsumidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltrosxpacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(7, 150)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 301)
        Me.TabControl1.TabIndex = 274
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro de sesiones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lb_sesionesausentes)
        Me.GroupBox2.Controls.Add(Me.lb_sesionespresentes)
        Me.GroupBox2.Controls.Add(Me.lb_sesionestotal)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(795, 224)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'lb_sesionesausentes
        '
        Me.lb_sesionesausentes.AutoSize = True
        Me.lb_sesionesausentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lb_sesionesausentes.ForeColor = System.Drawing.Color.Brown
        Me.lb_sesionesausentes.Location = New System.Drawing.Point(21, 94)
        Me.lb_sesionesausentes.Name = "lb_sesionesausentes"
        Me.lb_sesionesausentes.Size = New System.Drawing.Size(270, 31)
        Me.lb_sesionesausentes.TabIndex = 263
        Me.lb_sesionesausentes.Text = "Sesiones ausentes:"
        '
        'lb_sesionespresentes
        '
        Me.lb_sesionespresentes.AutoSize = True
        Me.lb_sesionespresentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lb_sesionespresentes.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lb_sesionespresentes.Location = New System.Drawing.Point(21, 29)
        Me.lb_sesionespresentes.Name = "lb_sesionespresentes"
        Me.lb_sesionespresentes.Size = New System.Drawing.Size(280, 31)
        Me.lb_sesionespresentes.TabIndex = 262
        Me.lb_sesionespresentes.Text = "Sesiones presentes:"
        '
        'lb_sesionestotal
        '
        Me.lb_sesionestotal.AutoSize = True
        Me.lb_sesionestotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lb_sesionestotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lb_sesionestotal.Location = New System.Drawing.Point(21, 160)
        Me.lb_sesionestotal.Name = "lb_sesionestotal"
        Me.lb_sesionestotal.Size = New System.Drawing.Size(253, 31)
        Me.lb_sesionestotal.TabIndex = 260
        Me.lb_sesionestotal.Text = "Total de sesiones:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 275)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resumen de insumos consumidos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lb_total_insumos)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(795, 263)
        Me.GroupBox3.TabIndex = 267
        Me.GroupBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(13, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 20)
        Me.Label9.TabIndex = 264
        Me.Label9.Text = "Total general:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ConsumomercaderiaidDataGridViewTextBoxColumn1, Me.FechaDataGridViewTextBoxColumn1, Me.SesionesidDataGridViewTextBoxColumn2, Me.FechasesionDataGridViewTextBoxColumn1, Me.ProdcodinternoDataGridViewTextBoxColumn1, Me.InsumoDataGridViewTextBoxColumn1, Me.CantidadDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.InsumosconsumidosausentesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 153)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(772, 79)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 263
        '
        'ConsumomercaderiaidDataGridViewTextBoxColumn1
        '
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn1.DataPropertyName = "Consumo_mercaderia_id"
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn1.HeaderText = "Consumo_mercaderia_id"
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn1.Name = "ConsumomercaderiaidDataGridViewTextBoxColumn1"
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ConsumomercaderiaidDataGridViewTextBoxColumn1.Visible = False
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn1.Visible = False
        '
        'SesionesidDataGridViewTextBoxColumn2
        '
        Me.SesionesidDataGridViewTextBoxColumn2.DataPropertyName = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn2.HeaderText = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn2.Name = "SesionesidDataGridViewTextBoxColumn2"
        Me.SesionesidDataGridViewTextBoxColumn2.ReadOnly = True
        Me.SesionesidDataGridViewTextBoxColumn2.Visible = False
        '
        'FechasesionDataGridViewTextBoxColumn1
        '
        Me.FechasesionDataGridViewTextBoxColumn1.DataPropertyName = "fecha_sesion"
        Me.FechasesionDataGridViewTextBoxColumn1.HeaderText = "fecha_sesion"
        Me.FechasesionDataGridViewTextBoxColumn1.Name = "FechasesionDataGridViewTextBoxColumn1"
        Me.FechasesionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechasesionDataGridViewTextBoxColumn1.Visible = False
        '
        'ProdcodinternoDataGridViewTextBoxColumn1
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdcodinternoDataGridViewTextBoxColumn1.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.ProdcodinternoDataGridViewTextBoxColumn1.Name = "ProdcodinternoDataGridViewTextBoxColumn1"
        Me.ProdcodinternoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'InsumoDataGridViewTextBoxColumn1
        '
        Me.InsumoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InsumoDataGridViewTextBoxColumn1.DataPropertyName = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn1.HeaderText = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn1.Name = "InsumoDataGridViewTextBoxColumn1"
        Me.InsumoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn1
        '
        Me.CantidadDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantidadDataGridViewTextBoxColumn1.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.Name = "CantidadDataGridViewTextBoxColumn1"
        Me.CantidadDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'InsumosconsumidosausentesBindingSource
        '
        Me.InsumosconsumidosausentesBindingSource.DataMember = "insumos_consumidos_ausentes"
        Me.InsumosconsumidosausentesBindingSource.DataSource = Me.Ds_enfermeria
        '
        'Ds_enfermeria
        '
        Me.Ds_enfermeria.DataSetName = "Ds_enfermeria"
        Me.Ds_enfermeria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Brown
        Me.Label8.Location = New System.Drawing.Point(7, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(416, 20)
        Me.Label8.TabIndex = 262
        Me.Label8.Text = "Total de insumos consumidos - sesiones ausentes:"
        '
        'lb_total_insumos
        '
        Me.lb_total_insumos.AutoSize = True
        Me.lb_total_insumos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total_insumos.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lb_total_insumos.Location = New System.Drawing.Point(7, 19)
        Me.lb_total_insumos.Name = "lb_total_insumos"
        Me.lb_total_insumos.Size = New System.Drawing.Size(422, 20)
        Me.lb_total_insumos.TabIndex = 261
        Me.lb_total_insumos.Text = "Total de insumos consumidos - sesiones presentes:"
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ConsumomercaderiaidDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.SesionesidDataGridViewTextBoxColumn, Me.FechasesionDataGridViewTextBoxColumn, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.InsumoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn})
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
        Me.DataGridView2.Size = New System.Drawing.Size(772, 79)
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
        'SesionesidDataGridViewTextBoxColumn
        '
        Me.SesionesidDataGridViewTextBoxColumn.DataPropertyName = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn.HeaderText = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn.Name = "SesionesidDataGridViewTextBoxColumn"
        Me.SesionesidDataGridViewTextBoxColumn.ReadOnly = True
        Me.SesionesidDataGridViewTextBoxColumn.Visible = False
        '
        'FechasesionDataGridViewTextBoxColumn
        '
        Me.FechasesionDataGridViewTextBoxColumn.DataPropertyName = "fecha_sesion"
        Me.FechasesionDataGridViewTextBoxColumn.HeaderText = "fecha_sesion"
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
        '
        'InsumosconsumidosBindingSource
        '
        Me.InsumosconsumidosBindingSource.DataMember = "insumos_consumidos"
        Me.InsumosconsumidosBindingSource.DataSource = Me.Ds_enfermeria
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Ln_totalreusos)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(810, 275)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Resumen de filtros utilizados"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(355, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = "Total de filtros:"
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
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DialisisFiltroDataGridViewTextBoxColumn, Me.FiltroidDataGridViewTextBoxColumn, Me.FiltrofechaDataGridViewTextBoxColumn, Me.FiltrocantreusoDataGridViewTextBoxColumn, Me.SesionesidDataGridViewTextBoxColumn1})
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
        'DialisisFiltroDataGridViewTextBoxColumn
        '
        Me.DialisisFiltroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DialisisFiltroDataGridViewTextBoxColumn.DataPropertyName = "Dialisis_Filtro"
        Me.DialisisFiltroDataGridViewTextBoxColumn.HeaderText = "Filtro"
        Me.DialisisFiltroDataGridViewTextBoxColumn.Name = "DialisisFiltroDataGridViewTextBoxColumn"
        Me.DialisisFiltroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FiltroidDataGridViewTextBoxColumn
        '
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
        'SesionesidDataGridViewTextBoxColumn1
        '
        Me.SesionesidDataGridViewTextBoxColumn1.DataPropertyName = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn1.HeaderText = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn1.Name = "SesionesidDataGridViewTextBoxColumn1"
        Me.SesionesidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SesionesidDataGridViewTextBoxColumn1.Visible = False
        '
        'FiltrosxpacienteBindingSource
        '
        Me.FiltrosxpacienteBindingSource.DataMember = "filtros_x_paciente"
        Me.FiltrosxpacienteBindingSource.DataSource = Me.Ds_enfermeria
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button_buscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_desde)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_hasta)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 99)
        Me.GroupBox1.TabIndex = 270
        Me.GroupBox1.TabStop = False
        '
        'Button_buscar
        '
        Me.Button_buscar.Image = CType(resources.GetObject("Button_buscar.Image"), System.Drawing.Image)
        Me.Button_buscar.Location = New System.Drawing.Point(560, 45)
        Me.Button_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(43, 37)
        Me.Button_buscar.TabIndex = 273
        Me.Button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(359, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 272
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(151, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "Desde:"
        '
        'DateTimePicker_desde
        '
        Me.DateTimePicker_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_desde.Location = New System.Drawing.Point(210, 53)
        Me.DateTimePicker_desde.Name = "DateTimePicker_desde"
        Me.DateTimePicker_desde.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker_desde.TabIndex = 269
        '
        'DateTimePicker_hasta
        '
        Me.DateTimePicker_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_hasta.Location = New System.Drawing.Point(414, 53)
        Me.DateTimePicker_hasta.Name = "DateTimePicker_hasta"
        Me.DateTimePicker_hasta.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker_hasta.TabIndex = 270
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(6, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(356, 20)
        Me.Label17.TabIndex = 268
        Me.Label17.Text = "Seleccione rango de fecha para la consulta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(3, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 17)
        Me.Label4.TabIndex = 275
        Me.Label4.Text = "Resultados de la búsqueda:"
        '
        'Sesiones_consulta_global
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(829, 464)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Sesiones_consulta_global"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sesiones - Consultas globales"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsumosconsumidosausentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsumosconsumidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltrosxpacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_sesionestotal As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_total_insumos As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Ln_totalreusos As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lb_sesionesausentes As System.Windows.Forms.Label
    Friend WithEvents lb_sesionespresentes As System.Windows.Forms.Label
    Friend WithEvents InsumosconsumidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_enfermeria As Aplicacion.Ds_enfermeria
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FiltrosxpacienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InsumosconsumidosausentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsumomercaderiaidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesidDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechasesionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsumoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DialisisFiltroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FiltroidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FiltrofechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FiltrocantreusoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsumomercaderiaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechasesionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsumoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
