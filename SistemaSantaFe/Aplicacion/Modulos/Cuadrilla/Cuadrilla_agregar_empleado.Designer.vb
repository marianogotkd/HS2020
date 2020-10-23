<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuadrilla_agregar_empleado
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_empleados = New System.Windows.Forms.DataGridView()
        Me.EmpleadoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadodniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoynombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadodirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadomailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadotelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadocelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_empleados = New Aplicacion.ds_empleados()
        Me.BO_cliente_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DG_empleados)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(743, 185)
        Me.GroupBox1.TabIndex = 247
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar empleado por nombre o documento: "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(724, 22)
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
        Me.DG_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpleadoidDataGridViewTextBoxColumn, Me.EmpleadodniDataGridViewTextBoxColumn, Me.ApellidoynombreDataGridViewTextBoxColumn, Me.EmpleadodirDataGridViewTextBoxColumn, Me.EmpleadomailDataGridViewTextBoxColumn, Me.EmpleadotelDataGridViewTextBoxColumn, Me.EmpleadocelDataGridViewTextBoxColumn})
        Me.DG_empleados.DataSource = Me.EmpleadosBindingSource
        Me.DG_empleados.Location = New System.Drawing.Point(12, 65)
        Me.DG_empleados.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_empleados.MultiSelect = False
        Me.DG_empleados.Name = "DG_empleados"
        Me.DG_empleados.ReadOnly = True
        Me.DG_empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_empleados.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_empleados.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_empleados.Size = New System.Drawing.Size(724, 111)
        Me.DG_empleados.StandardTab = True
        Me.DG_empleados.TabIndex = 239
        '
        'EmpleadoidDataGridViewTextBoxColumn
        '
        Me.EmpleadoidDataGridViewTextBoxColumn.DataPropertyName = "empleado_id"
        Me.EmpleadoidDataGridViewTextBoxColumn.HeaderText = "empleado_id"
        Me.EmpleadoidDataGridViewTextBoxColumn.Name = "EmpleadoidDataGridViewTextBoxColumn"
        Me.EmpleadoidDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpleadoidDataGridViewTextBoxColumn.Visible = False
        '
        'EmpleadodniDataGridViewTextBoxColumn
        '
        Me.EmpleadodniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpleadodniDataGridViewTextBoxColumn.DataPropertyName = "empleado_dni"
        Me.EmpleadodniDataGridViewTextBoxColumn.HeaderText = "Dni"
        Me.EmpleadodniDataGridViewTextBoxColumn.Name = "EmpleadodniDataGridViewTextBoxColumn"
        Me.EmpleadodniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoynombreDataGridViewTextBoxColumn
        '
        Me.ApellidoynombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ApellidoynombreDataGridViewTextBoxColumn.DataPropertyName = "apellido_y_nombre"
        Me.ApellidoynombreDataGridViewTextBoxColumn.HeaderText = "Apellido y Nombre"
        Me.ApellidoynombreDataGridViewTextBoxColumn.Name = "ApellidoynombreDataGridViewTextBoxColumn"
        Me.ApellidoynombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadodirDataGridViewTextBoxColumn
        '
        Me.EmpleadodirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpleadodirDataGridViewTextBoxColumn.DataPropertyName = "empleado_dir"
        Me.EmpleadodirDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.EmpleadodirDataGridViewTextBoxColumn.Name = "EmpleadodirDataGridViewTextBoxColumn"
        Me.EmpleadodirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadomailDataGridViewTextBoxColumn
        '
        Me.EmpleadomailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpleadomailDataGridViewTextBoxColumn.DataPropertyName = "empleado_mail"
        Me.EmpleadomailDataGridViewTextBoxColumn.HeaderText = "E mail"
        Me.EmpleadomailDataGridViewTextBoxColumn.Name = "EmpleadomailDataGridViewTextBoxColumn"
        Me.EmpleadomailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadotelDataGridViewTextBoxColumn
        '
        Me.EmpleadotelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpleadotelDataGridViewTextBoxColumn.DataPropertyName = "empleado_tel"
        Me.EmpleadotelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.EmpleadotelDataGridViewTextBoxColumn.Name = "EmpleadotelDataGridViewTextBoxColumn"
        Me.EmpleadotelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadocelDataGridViewTextBoxColumn
        '
        Me.EmpleadocelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpleadocelDataGridViewTextBoxColumn.DataPropertyName = "empleado_cel"
        Me.EmpleadocelDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.EmpleadocelDataGridViewTextBoxColumn.Name = "EmpleadocelDataGridViewTextBoxColumn"
        Me.EmpleadocelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.Ds_empleados
        '
        'Ds_empleados
        '
        Me.Ds_empleados.DataSetName = "ds_empleados"
        Me.Ds_empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_cliente_nuevo
        '
        Me.BO_cliente_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_cliente_nuevo.Location = New System.Drawing.Point(321, 206)
        Me.BO_cliente_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_nuevo.Name = "BO_cliente_nuevo"
        Me.BO_cliente_nuevo.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_nuevo.TabIndex = 249
        Me.BO_cliente_nuevo.Text = "Agregar"
        Me.BO_cliente_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_nuevo.UseVisualStyleBackColor = True
        '
        'Cuadrilla_agregar_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(765, 270)
        Me.Controls.Add(Me.BO_cliente_nuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Cuadrilla_agregar_empleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar empleado a cuadrilla"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents EmpleadoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadodniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoynombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadodirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadomailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadotelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadocelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_empleados As Aplicacion.ds_empleados
    Friend WithEvents BO_cliente_nuevo As System.Windows.Forms.Button
End Class
