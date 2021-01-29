<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_modificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente_modificar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_inactivo = New System.Windows.Forms.RadioButton()
        Me.RadioButton_activo = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_hc = New System.Windows.Forms.Button()
        Me.BO_cliente_nuevo = New System.Windows.Forms.Button()
        Me.BO_cliente_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.PACidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACtelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAcdirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrasocialidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrasocialnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACnumafiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.BO_Cargar = New System.Windows.Forms.Button()
        Me.BO_Cancelar = New System.Windows.Forms.Button()
        Me.BO_Guardar = New System.Windows.Forms.Button()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.DataGrid_cliente = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paciente1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1129, 575)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btn_hc)
        Me.TabPage1.Controls.Add(Me.BO_cliente_nuevo)
        Me.TabPage1.Controls.Add(Me.BO_cliente_modificar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BO_Cargar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1121, 546)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Pacientes Registrados"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton_inactivo)
        Me.GroupBox2.Controls.Add(Me.RadioButton_activo)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 58)
        Me.GroupBox2.TabIndex = 251
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ver Pacientes:"
        '
        'RadioButton_inactivo
        '
        Me.RadioButton_inactivo.AutoSize = True
        Me.RadioButton_inactivo.Location = New System.Drawing.Point(144, 21)
        Me.RadioButton_inactivo.Name = "RadioButton_inactivo"
        Me.RadioButton_inactivo.Size = New System.Drawing.Size(79, 20)
        Me.RadioButton_inactivo.TabIndex = 1
        Me.RadioButton_inactivo.Text = "Inactivos"
        Me.RadioButton_inactivo.UseVisualStyleBackColor = True
        '
        'RadioButton_activo
        '
        Me.RadioButton_activo.AutoSize = True
        Me.RadioButton_activo.Checked = True
        Me.RadioButton_activo.Location = New System.Drawing.Point(34, 21)
        Me.RadioButton_activo.Name = "RadioButton_activo"
        Me.RadioButton_activo.Size = New System.Drawing.Size(70, 20)
        Me.RadioButton_activo.TabIndex = 0
        Me.RadioButton_activo.TabStop = True
        Me.RadioButton_activo.Text = "Activos"
        Me.RadioButton_activo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(968, 489)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 43)
        Me.Button1.TabIndex = 250
        Me.Button1.Text = "Informe de Historia Clinica"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Generar reporte")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_hc
        '
        Me.btn_hc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hc.Image = CType(resources.GetObject("btn_hc.Image"), System.Drawing.Image)
        Me.btn_hc.Location = New System.Drawing.Point(836, 489)
        Me.btn_hc.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_hc.Name = "btn_hc"
        Me.btn_hc.Size = New System.Drawing.Size(124, 43)
        Me.btn_hc.TabIndex = 249
        Me.btn_hc.Text = "Historia Clinica"
        Me.btn_hc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_hc, "editar historia clínica")
        Me.btn_hc.UseVisualStyleBackColor = True
        '
        'BO_cliente_nuevo
        '
        Me.BO_cliente_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_cliente_nuevo.Location = New System.Drawing.Point(572, 489)
        Me.BO_cliente_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_nuevo.Name = "BO_cliente_nuevo"
        Me.BO_cliente_nuevo.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_nuevo.TabIndex = 248
        Me.BO_cliente_nuevo.Text = "Agregar Paciente"
        Me.BO_cliente_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_cliente_nuevo, "Agregar nuevo paciente")
        Me.BO_cliente_nuevo.UseVisualStyleBackColor = True
        '
        'BO_cliente_modificar
        '
        Me.BO_cliente_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_cliente_modificar.Location = New System.Drawing.Point(704, 489)
        Me.BO_cliente_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_modificar.Name = "BO_cliente_modificar"
        Me.BO_cliente_modificar.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_modificar.TabIndex = 247
        Me.BO_cliente_modificar.Text = "Editar Datos Personales"
        Me.BO_cliente_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_cliente_modificar, "editar datos personales")
        Me.BO_cliente_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DG_clientes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1105, 409)
        Me.GroupBox1.TabIndex = 246
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Pacientes"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1081, 22)
        Me.TextBox1.TabIndex = 240
        '
        'DG_clientes
        '
        Me.DG_clientes.AllowUserToAddRows = False
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.AutoGenerateColumns = False
        Me.DG_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PACidDataGridViewTextBoxColumn, Me.PACdniDataGridViewTextBoxColumn, Me.PacienteDataGridViewTextBoxColumn, Me.PACtelDataGridViewTextBoxColumn, Me.PACmailDataGridViewTextBoxColumn, Me.PAcdirDataGridViewTextBoxColumn, Me.ObrasocialidDataGridViewTextBoxColumn, Me.ObrasocialnombreDataGridViewTextBoxColumn, Me.PACnumafiDataGridViewTextBoxColumn})
        Me.DG_clientes.DataSource = Me.Paciente1BindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(12, 51)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(1081, 350)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 239
        '
        'PACidDataGridViewTextBoxColumn
        '
        Me.PACidDataGridViewTextBoxColumn.DataPropertyName = "PAC_id"
        Me.PACidDataGridViewTextBoxColumn.HeaderText = "PAC_id"
        Me.PACidDataGridViewTextBoxColumn.Name = "PACidDataGridViewTextBoxColumn"
        Me.PACidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PACidDataGridViewTextBoxColumn.Visible = False
        '
        'PACdniDataGridViewTextBoxColumn
        '
        Me.PACdniDataGridViewTextBoxColumn.DataPropertyName = "PAC_dni"
        Me.PACdniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.PACdniDataGridViewTextBoxColumn.Name = "PACdniDataGridViewTextBoxColumn"
        Me.PACdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PacienteDataGridViewTextBoxColumn
        '
        Me.PacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.HeaderText = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.Name = "PacienteDataGridViewTextBoxColumn"
        Me.PacienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PACtelDataGridViewTextBoxColumn
        '
        Me.PACtelDataGridViewTextBoxColumn.DataPropertyName = "PAC_tel"
        Me.PACtelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.PACtelDataGridViewTextBoxColumn.Name = "PACtelDataGridViewTextBoxColumn"
        Me.PACtelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PACmailDataGridViewTextBoxColumn
        '
        Me.PACmailDataGridViewTextBoxColumn.DataPropertyName = "PAC_mail"
        Me.PACmailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.PACmailDataGridViewTextBoxColumn.Name = "PACmailDataGridViewTextBoxColumn"
        Me.PACmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PAcdirDataGridViewTextBoxColumn
        '
        Me.PAcdirDataGridViewTextBoxColumn.DataPropertyName = "PAc_dir"
        Me.PAcdirDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.PAcdirDataGridViewTextBoxColumn.Name = "PAcdirDataGridViewTextBoxColumn"
        Me.PAcdirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObrasocialidDataGridViewTextBoxColumn
        '
        Me.ObrasocialidDataGridViewTextBoxColumn.DataPropertyName = "Obrasocial_id"
        Me.ObrasocialidDataGridViewTextBoxColumn.HeaderText = "Obrasocial_id"
        Me.ObrasocialidDataGridViewTextBoxColumn.Name = "ObrasocialidDataGridViewTextBoxColumn"
        Me.ObrasocialidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObrasocialidDataGridViewTextBoxColumn.Visible = False
        '
        'ObrasocialnombreDataGridViewTextBoxColumn
        '
        Me.ObrasocialnombreDataGridViewTextBoxColumn.DataPropertyName = "Obrasocial_nombre"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.HeaderText = "Obra Social"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.Name = "ObrasocialnombreDataGridViewTextBoxColumn"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PACnumafiDataGridViewTextBoxColumn
        '
        Me.PACnumafiDataGridViewTextBoxColumn.DataPropertyName = "PACnumafi"
        Me.PACnumafiDataGridViewTextBoxColumn.HeaderText = "Nro Afiliado"
        Me.PACnumafiDataGridViewTextBoxColumn.Name = "PACnumafiDataGridViewTextBoxColumn"
        Me.PACnumafiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Paciente1BindingSource
        '
        Me.Paciente1BindingSource.DataMember = "Paciente1"
        Me.Paciente1BindingSource.DataSource = Me.Cliente_ds
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_Cargar
        '
        Me.BO_Cargar.Image = CType(resources.GetObject("BO_Cargar.Image"), System.Drawing.Image)
        Me.BO_Cargar.Location = New System.Drawing.Point(1048, 375)
        Me.BO_Cargar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Cargar.Name = "BO_Cargar"
        Me.BO_Cargar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Cargar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BO_Cargar, "Ir a Modificar")
        Me.BO_Cargar.UseVisualStyleBackColor = True
        '
        'BO_Cancelar
        '
        Me.BO_Cancelar.Enabled = False
        Me.BO_Cancelar.Image = CType(resources.GetObject("BO_Cancelar.Image"), System.Drawing.Image)
        Me.BO_Cancelar.Location = New System.Drawing.Point(148, 581)
        Me.BO_Cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Cancelar.Name = "BO_Cancelar"
        Me.BO_Cancelar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Cancelar.TabIndex = 0
        Me.BO_Cancelar.UseVisualStyleBackColor = True
        Me.BO_Cancelar.Visible = False
        '
        'BO_Guardar
        '
        Me.BO_Guardar.Enabled = False
        Me.BO_Guardar.Image = CType(resources.GetObject("BO_Guardar.Image"), System.Drawing.Image)
        Me.BO_Guardar.Location = New System.Drawing.Point(271, 581)
        Me.BO_Guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Guardar.Name = "BO_Guardar"
        Me.BO_Guardar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Guardar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BO_Guardar, "Guardar")
        Me.BO_Guardar.UseVisualStyleBackColor = True
        Me.BO_Guardar.Visible = False
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Enabled = False
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(210, 581)
        Me.BO_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Eliminar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Eliminar")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        Me.BO_Eliminar.Visible = False
        '
        'DataGrid_cliente
        '
        Me.DataGrid_cliente.AllowUserToAddRows = False
        Me.DataGrid_cliente.AllowUserToDeleteRows = False
        Me.DataGrid_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_cliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_cliente.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid_cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid_cliente.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid_cliente.Name = "DataGrid_cliente"
        Me.DataGrid_cliente.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_cliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGrid_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_cliente.Size = New System.Drawing.Size(623, 236)
        Me.DataGrid_cliente.TabIndex = 7
        '
        'Cliente_modificar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1158, 617)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.BO_Guardar)
        Me.Controls.Add(Me.BO_Cancelar)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cliente_modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Pacientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paciente1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BO_Cargar As System.Windows.Forms.Button
    Friend WithEvents BO_Cancelar As System.Windows.Forms.Button
    Friend WithEvents BO_Guardar As System.Windows.Forms.Button
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents DataGrid_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents BO_cliente_nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_cliente_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_hc As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_inactivo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_activo As System.Windows.Forms.RadioButton
    Friend WithEvents PACidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACtelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAcdirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObrasocialidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObrasocialnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACnumafiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paciente1BindingSource As System.Windows.Forms.BindingSource
End Class
