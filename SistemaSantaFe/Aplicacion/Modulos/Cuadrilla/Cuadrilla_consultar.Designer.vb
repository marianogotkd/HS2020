<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuadrilla_consultar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuadrilla_consultar))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BO_cliente_nuevo = New System.Windows.Forms.Button()
        Me.BO_cliente_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_empleados = New System.Windows.Forms.DataGridView()
        Me.CuadrillaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuadrilladescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiembrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuadrillasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_cuadrilla = New Aplicacion.Ds_cuadrilla()
        Me.BO_Cargar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuadrillasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cuadrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 4)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1129, 575)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
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
        Me.TabPage1.Text = "Cuadrillas registradas"
        '
        'BO_cliente_nuevo
        '
        Me.BO_cliente_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_cliente_nuevo.Location = New System.Drawing.Point(845, 489)
        Me.BO_cliente_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_nuevo.Name = "BO_cliente_nuevo"
        Me.BO_cliente_nuevo.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_nuevo.TabIndex = 248
        Me.BO_cliente_nuevo.Text = "Agregar"
        Me.BO_cliente_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_nuevo.UseVisualStyleBackColor = True
        '
        'BO_cliente_modificar
        '
        Me.BO_cliente_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_cliente_modificar.Location = New System.Drawing.Point(977, 489)
        Me.BO_cliente_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_modificar.Name = "BO_cliente_modificar"
        Me.BO_cliente_modificar.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_modificar.TabIndex = 247
        Me.BO_cliente_modificar.Text = "Editar"
        Me.BO_cliente_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DG_empleados)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1105, 471)
        Me.GroupBox1.TabIndex = 246
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda avanzada: "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1064, 22)
        Me.TextBox1.TabIndex = 240
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DG_empleados
        '
        Me.DG_empleados.AllowUserToAddRows = False
        Me.DG_empleados.AllowUserToDeleteRows = False
        Me.DG_empleados.AllowUserToResizeRows = False
        Me.DG_empleados.AutoGenerateColumns = False
        Me.DG_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_empleados.BackgroundColor = System.Drawing.Color.White
        Me.DG_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CuadrillaidDataGridViewTextBoxColumn, Me.CuadrilladescripcionDataGridViewTextBoxColumn, Me.MiembrosDataGridViewTextBoxColumn, Me.SalarioDataGridViewTextBoxColumn})
        Me.DG_empleados.DataSource = Me.CuadrillasBindingSource
        Me.DG_empleados.Location = New System.Drawing.Point(12, 65)
        Me.DG_empleados.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_empleados.MultiSelect = False
        Me.DG_empleados.Name = "DG_empleados"
        Me.DG_empleados.ReadOnly = True
        Me.DG_empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_empleados.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_empleados.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_empleados.Size = New System.Drawing.Size(1081, 389)
        Me.DG_empleados.StandardTab = True
        Me.DG_empleados.TabIndex = 239
        '
        'CuadrillaidDataGridViewTextBoxColumn
        '
        Me.CuadrillaidDataGridViewTextBoxColumn.DataPropertyName = "Cuadrilla_id"
        Me.CuadrillaidDataGridViewTextBoxColumn.HeaderText = "Cuadrilla_id"
        Me.CuadrillaidDataGridViewTextBoxColumn.Name = "CuadrillaidDataGridViewTextBoxColumn"
        Me.CuadrillaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuadrillaidDataGridViewTextBoxColumn.Visible = False
        '
        'CuadrilladescripcionDataGridViewTextBoxColumn
        '
        Me.CuadrilladescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CuadrilladescripcionDataGridViewTextBoxColumn.DataPropertyName = "Cuadrilla_descripcion"
        Me.CuadrilladescripcionDataGridViewTextBoxColumn.HeaderText = "Cuadrilla"
        Me.CuadrilladescripcionDataGridViewTextBoxColumn.Name = "CuadrilladescripcionDataGridViewTextBoxColumn"
        Me.CuadrilladescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiembrosDataGridViewTextBoxColumn
        '
        Me.MiembrosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MiembrosDataGridViewTextBoxColumn.DataPropertyName = "Miembros"
        Me.MiembrosDataGridViewTextBoxColumn.HeaderText = "Miembros"
        Me.MiembrosDataGridViewTextBoxColumn.Name = "MiembrosDataGridViewTextBoxColumn"
        Me.MiembrosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalarioDataGridViewTextBoxColumn
        '
        Me.SalarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SalarioDataGridViewTextBoxColumn.DataPropertyName = "Salario"
        Me.SalarioDataGridViewTextBoxColumn.HeaderText = "Salario por Hora"
        Me.SalarioDataGridViewTextBoxColumn.Name = "SalarioDataGridViewTextBoxColumn"
        Me.SalarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuadrillasBindingSource
        '
        Me.CuadrillasBindingSource.DataMember = "Cuadrillas"
        Me.CuadrillasBindingSource.DataSource = Me.Ds_cuadrilla
        '
        'Ds_cuadrilla
        '
        Me.Ds_cuadrilla.DataSetName = "Ds_cuadrilla"
        Me.Ds_cuadrilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Cuadrilla_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1134, 581)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Cuadrilla_consultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Cuadrillas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuadrillasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cuadrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BO_cliente_nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_cliente_modificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents BO_Cargar As System.Windows.Forms.Button
    Friend WithEvents CuadrillasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_cuadrilla As Aplicacion.Ds_cuadrilla
    Friend WithEvents CuadrillaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuadrilladescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiembrosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
