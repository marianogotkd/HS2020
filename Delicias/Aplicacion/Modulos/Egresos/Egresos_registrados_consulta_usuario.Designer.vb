<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Egresos_registrados_consulta_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Egresos_registrados_consulta_usuario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_total = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BO_buscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_usuarios = New System.Windows.Forms.ComboBox()
        Me.BO_producto_modificar = New System.Windows.Forms.Button()
        Me.DT_fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.DT_fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoInternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDeEgresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USU_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EgresosconsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Egresos_DS = New Aplicacion.Egresos_DS()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EgresosconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Egresos_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(6, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(866, 543)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(858, 517)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Egresos registrados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_total)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BO_buscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CB_usuarios)
        Me.GroupBox1.Controls.Add(Me.BO_producto_modificar)
        Me.GroupBox1.Controls.Add(Me.DT_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.DT_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(832, 481)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta de egresos registrados"
        '
        'Label_total
        '
        Me.Label_total.AutoSize = True
        Me.Label_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total.Location = New System.Drawing.Point(577, 447)
        Me.Label_total.Name = "Label_total"
        Me.Label_total.Size = New System.Drawing.Size(40, 17)
        Me.Label_total.TabIndex = 15
        Me.Label_total.Text = "0,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(497, 447)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "TOTAL: $"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(786, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Button1, "Calculadora")
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BO_buscar
        '
        Me.BO_buscar.Image = CType(resources.GetObject("BO_buscar.Image"), System.Drawing.Image)
        Me.BO_buscar.Location = New System.Drawing.Point(449, 440)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(30, 30)
        Me.BO_buscar.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.BO_buscar, "Buscar egresos")
        Me.BO_buscar.UseVisualStyleBackColor = True
        Me.BO_buscar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 447)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Filtro por usuario:"
        Me.Label3.Visible = False
        '
        'CB_usuarios
        '
        Me.CB_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_usuarios.FormattingEnabled = True
        Me.CB_usuarios.Location = New System.Drawing.Point(163, 444)
        Me.CB_usuarios.Name = "CB_usuarios"
        Me.CB_usuarios.Size = New System.Drawing.Size(280, 24)
        Me.CB_usuarios.TabIndex = 2
        Me.CB_usuarios.Visible = False
        '
        'BO_producto_modificar
        '
        Me.BO_producto_modificar.Image = CType(resources.GetObject("BO_producto_modificar.Image"), System.Drawing.Image)
        Me.BO_producto_modificar.Location = New System.Drawing.Point(776, 435)
        Me.BO_producto_modificar.Name = "BO_producto_modificar"
        Me.BO_producto_modificar.Size = New System.Drawing.Size(40, 40)
        Me.BO_producto_modificar.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.BO_producto_modificar, "Ver como informe")
        Me.BO_producto_modificar.UseVisualStyleBackColor = True
        Me.BO_producto_modificar.Visible = False
        '
        'DT_fecha_hasta
        '
        Me.DT_fecha_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_fecha_hasta.Location = New System.Drawing.Point(487, 26)
        Me.DT_fecha_hasta.Name = "DT_fecha_hasta"
        Me.DT_fecha_hasta.Size = New System.Drawing.Size(244, 23)
        Me.DT_fecha_hasta.TabIndex = 9
        '
        'DT_fecha_desde
        '
        Me.DT_fecha_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_fecha_desde.Location = New System.Drawing.Point(122, 26)
        Me.DT_fecha_desde.Name = "DT_fecha_desde"
        Me.DT_fecha_desde.Size = New System.Drawing.Size(246, 23)
        Me.DT_fecha_desde.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha desde:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoInternoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.NumComprobanteDataGridViewTextBoxColumn, Me.TipoDeEgresoDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.Usuario, Me.USU_id})
        Me.DataGridView1.DataSource = Me.EgresosconsultaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 79)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(800, 350)
        Me.DataGridView1.TabIndex = 3
        '
        'CodigoInternoDataGridViewTextBoxColumn
        '
        Me.CodigoInternoDataGridViewTextBoxColumn.DataPropertyName = "Codigo interno"
        Me.CodigoInternoDataGridViewTextBoxColumn.HeaderText = "Codigo interno"
        Me.CodigoInternoDataGridViewTextBoxColumn.Name = "CodigoInternoDataGridViewTextBoxColumn"
        Me.CodigoInternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoInternoDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumComprobanteDataGridViewTextBoxColumn
        '
        Me.NumComprobanteDataGridViewTextBoxColumn.DataPropertyName = "Num Comprobante"
        Me.NumComprobanteDataGridViewTextBoxColumn.HeaderText = "Num Comprobante"
        Me.NumComprobanteDataGridViewTextBoxColumn.Name = "NumComprobanteDataGridViewTextBoxColumn"
        Me.NumComprobanteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumComprobanteDataGridViewTextBoxColumn.Width = 150
        '
        'TipoDeEgresoDataGridViewTextBoxColumn
        '
        Me.TipoDeEgresoDataGridViewTextBoxColumn.DataPropertyName = "Tipo de egreso"
        Me.TipoDeEgresoDataGridViewTextBoxColumn.HeaderText = "Tipo de egreso"
        Me.TipoDeEgresoDataGridViewTextBoxColumn.Name = "TipoDeEgresoDataGridViewTextBoxColumn"
        Me.TipoDeEgresoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDeEgresoDataGridViewTextBoxColumn.Width = 150
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleDataGridViewTextBoxColumn.Width = 150
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 120
        '
        'USU_id
        '
        Me.USU_id.DataPropertyName = "USU_id"
        Me.USU_id.HeaderText = "USU_id"
        Me.USU_id.Name = "USU_id"
        Me.USU_id.ReadOnly = True
        Me.USU_id.Visible = False
        '
        'EgresosconsultaBindingSource
        '
        Me.EgresosconsultaBindingSource.DataMember = "Egresos_consulta"
        Me.EgresosconsultaBindingSource.DataSource = Me.Egresos_DS
        '
        'Egresos_DS
        '
        Me.Egresos_DS.DataSetName = "Egresos_DS"
        Me.Egresos_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Egresos_registrados_consulta_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Egresos_registrados_consulta_usuario"
        Me.Text = "Egresos_registrados_consulta_usuario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EgresosconsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Egresos_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_total As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents BO_producto_modificar As System.Windows.Forms.Button
    Friend WithEvents DT_fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoInternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDeEgresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USU_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EgresosconsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Egresos_DS As Aplicacion.Egresos_DS
End Class
