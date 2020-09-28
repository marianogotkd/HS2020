<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medico_Actualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medico_Actualizar))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGrid_cliente = New System.Windows.Forms.DataGridView()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.BO_Guardar = New System.Windows.Forms.Button()
        Me.BO_Cancelar = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_Anular = New System.Windows.Forms.Button()
        Me.BO_cliente_nuevo = New System.Windows.Forms.Button()
        Me.BO_cliente_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_Medico = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MedicoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediconombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicodniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoespDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicomatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medico_ds = New Aplicacion.Medico_ds()
        Me.BO_Cargar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGrid_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medico_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid_cliente
        '
        Me.DataGrid_cliente.AllowUserToAddRows = False
        Me.DataGrid_cliente.AllowUserToDeleteRows = False
        Me.DataGrid_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_cliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid_cliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid_cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid_cliente.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid_cliente.Name = "DataGrid_cliente"
        Me.DataGrid_cliente.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_cliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_cliente.Size = New System.Drawing.Size(1148, 607)
        Me.DataGrid_cliente.TabIndex = 12
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Enabled = False
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(200, 579)
        Me.BO_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Eliminar.TabIndex = 10
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        Me.BO_Eliminar.Visible = False
        '
        'BO_Guardar
        '
        Me.BO_Guardar.Enabled = False
        Me.BO_Guardar.Image = CType(resources.GetObject("BO_Guardar.Image"), System.Drawing.Image)
        Me.BO_Guardar.Location = New System.Drawing.Point(261, 579)
        Me.BO_Guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Guardar.Name = "BO_Guardar"
        Me.BO_Guardar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Guardar.TabIndex = 11
        Me.BO_Guardar.UseVisualStyleBackColor = True
        Me.BO_Guardar.Visible = False
        '
        'BO_Cancelar
        '
        Me.BO_Cancelar.Enabled = False
        Me.BO_Cancelar.Image = CType(resources.GetObject("BO_Cancelar.Image"), System.Drawing.Image)
        Me.BO_Cancelar.Location = New System.Drawing.Point(138, 579)
        Me.BO_Cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Cancelar.Name = "BO_Cancelar"
        Me.BO_Cancelar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Cancelar.TabIndex = 8
        Me.BO_Cancelar.UseVisualStyleBackColor = True
        Me.BO_Cancelar.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btn_Anular)
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
        Me.TabPage1.Text = "Medicos Registrados"
        '
        'btn_Anular
        '
        Me.btn_Anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Anular.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Anular.Location = New System.Drawing.Point(756, 489)
        Me.btn_Anular.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Anular.Name = "btn_Anular"
        Me.btn_Anular.Size = New System.Drawing.Size(93, 44)
        Me.btn_Anular.TabIndex = 250
        Me.btn_Anular.Text = "Eliminar"
        Me.btn_Anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Anular.UseVisualStyleBackColor = True
        '
        'BO_cliente_nuevo
        '
        Me.BO_cliente_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_cliente_nuevo.Location = New System.Drawing.Point(857, 489)
        Me.BO_cliente_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_nuevo.Name = "BO_cliente_nuevo"
        Me.BO_cliente_nuevo.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_nuevo.TabIndex = 249
        Me.BO_cliente_nuevo.Text = "Agregar"
        Me.BO_cliente_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_nuevo.UseVisualStyleBackColor = True
        '
        'BO_cliente_modificar
        '
        Me.BO_cliente_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_cliente_modificar.Location = New System.Drawing.Point(989, 489)
        Me.BO_cliente_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_modificar.Name = "BO_cliente_modificar"
        Me.BO_cliente_modificar.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_modificar.TabIndex = 247
        Me.BO_cliente_modificar.Text = "Editar Datos Personales"
        Me.BO_cliente_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DG_Medico)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1105, 471)
        Me.GroupBox1.TabIndex = 246
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Medico"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1064, 22)
        Me.TextBox1.TabIndex = 240
        '
        'DG_Medico
        '
        Me.DG_Medico.AllowUserToAddRows = False
        Me.DG_Medico.AllowUserToDeleteRows = False
        Me.DG_Medico.AllowUserToResizeRows = False
        Me.DG_Medico.AutoGenerateColumns = False
        Me.DG_Medico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Medico.BackgroundColor = System.Drawing.Color.White
        Me.DG_Medico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Medico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.MedicoidDataGridViewTextBoxColumn, Me.MediconombreDataGridViewTextBoxColumn, Me.MedicodniDataGridViewTextBoxColumn, Me.MedicoespDataGridViewTextBoxColumn, Me.MedicomatriculaDataGridViewTextBoxColumn})
        Me.DG_Medico.DataSource = Me.MedicosBindingSource
        Me.DG_Medico.Location = New System.Drawing.Point(12, 65)
        Me.DG_Medico.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Medico.MultiSelect = False
        Me.DG_Medico.Name = "DG_Medico"
        Me.DG_Medico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Medico.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Medico.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_Medico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Medico.Size = New System.Drawing.Size(1081, 389)
        Me.DG_Medico.StandardTab = True
        Me.DG_Medico.TabIndex = 239
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Item.HeaderText = ""
        Me.Item.Name = "Item"
        Me.Item.Width = 50
        '
        'MedicoidDataGridViewTextBoxColumn
        '
        Me.MedicoidDataGridViewTextBoxColumn.DataPropertyName = "medico_id"
        Me.MedicoidDataGridViewTextBoxColumn.HeaderText = "medico_id"
        Me.MedicoidDataGridViewTextBoxColumn.Name = "MedicoidDataGridViewTextBoxColumn"
        Me.MedicoidDataGridViewTextBoxColumn.Visible = False
        '
        'MediconombreDataGridViewTextBoxColumn
        '
        Me.MediconombreDataGridViewTextBoxColumn.DataPropertyName = "medico_nombre"
        Me.MediconombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.MediconombreDataGridViewTextBoxColumn.Name = "MediconombreDataGridViewTextBoxColumn"
        Me.MediconombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicodniDataGridViewTextBoxColumn
        '
        Me.MedicodniDataGridViewTextBoxColumn.DataPropertyName = "medico_dni"
        Me.MedicodniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.MedicodniDataGridViewTextBoxColumn.Name = "MedicodniDataGridViewTextBoxColumn"
        Me.MedicodniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicoespDataGridViewTextBoxColumn
        '
        Me.MedicoespDataGridViewTextBoxColumn.DataPropertyName = "medico_esp"
        Me.MedicoespDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.MedicoespDataGridViewTextBoxColumn.Name = "MedicoespDataGridViewTextBoxColumn"
        Me.MedicoespDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicomatriculaDataGridViewTextBoxColumn
        '
        Me.MedicomatriculaDataGridViewTextBoxColumn.DataPropertyName = "medico_matricula"
        Me.MedicomatriculaDataGridViewTextBoxColumn.HeaderText = "N° de Matricula"
        Me.MedicomatriculaDataGridViewTextBoxColumn.Name = "MedicomatriculaDataGridViewTextBoxColumn"
        Me.MedicomatriculaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicosBindingSource
        '
        Me.MedicosBindingSource.DataMember = "Medicos"
        Me.MedicosBindingSource.DataSource = Me.Medico_ds
        '
        'Medico_ds
        '
        Me.Medico_ds.DataSetName = "Medico_ds"
        Me.Medico_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_Cargar
        '
        Me.BO_Cargar.Image = CType(resources.GetObject("BO_Cargar.Image"), System.Drawing.Image)
        Me.BO_Cargar.Location = New System.Drawing.Point(1048, 375)
        Me.BO_Cargar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Cargar.Name = "BO_Cargar"
        Me.BO_Cargar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Cargar.TabIndex = 0
        Me.BO_Cargar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1129, 575)
        Me.TabControl1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(624, 490)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 252
        Me.Button1.Text = "Generar reporte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Medico_Actualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 607)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataGrid_cliente)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.BO_Guardar)
        Me.Controls.Add(Me.BO_Cancelar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1164, 646)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1164, 646)
        Me.Name = "Medico_Actualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Medicos"
        CType(Me.DataGrid_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medico_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGrid_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_Guardar As System.Windows.Forms.Button
    Friend WithEvents BO_Cancelar As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BO_cliente_modificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_Medico As System.Windows.Forms.DataGridView
    Friend WithEvents BO_Cargar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents BO_cliente_nuevo As System.Windows.Forms.Button
    Friend WithEvents MedicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Medico_ds As Aplicacion.Medico_ds
    Friend WithEvents btn_Anular As System.Windows.Forms.Button
    Friend WithEvents Item As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MedicoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MediconombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicodniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicoespDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicomatriculaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
