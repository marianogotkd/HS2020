<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta_Consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta_Consulta))
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
        Me.USUidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodetalleidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodcantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodprecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodsubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaproddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaconsultaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_consulta_ds1 = New Aplicacion.Venta_consulta_ds()
        Me.VentaconsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_consulta_ds = New Aplicacion.Venta_consulta_ds()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaconsultaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_consulta_ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_consulta_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(8, 12)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1155, 668)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1147, 639)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ventas Registradas"
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1109, 592)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta de ventas registradas"
        '
        'Label_total
        '
        Me.Label_total.AutoSize = True
        Me.Label_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total.Location = New System.Drawing.Point(769, 550)
        Me.Label_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_total.Name = "Label_total"
        Me.Label_total.Size = New System.Drawing.Size(44, 20)
        Me.Label_total.TabIndex = 15
        Me.Label_total.Text = "0,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(663, 550)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "TOTAL: $"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1048, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Button1, "Calculadora")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BO_buscar
        '
        Me.BO_buscar.Image = CType(resources.GetObject("BO_buscar.Image"), System.Drawing.Image)
        Me.BO_buscar.Location = New System.Drawing.Point(599, 542)
        Me.BO_buscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BO_buscar.Name = "BO_buscar"
        Me.BO_buscar.Size = New System.Drawing.Size(40, 37)
        Me.BO_buscar.TabIndex = 12
        Me.BO_buscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 550)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Filtro por usuario:"
        '
        'CB_usuarios
        '
        Me.CB_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_usuarios.FormattingEnabled = True
        Me.CB_usuarios.Location = New System.Drawing.Point(217, 546)
        Me.CB_usuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CB_usuarios.Name = "CB_usuarios"
        Me.CB_usuarios.Size = New System.Drawing.Size(372, 28)
        Me.CB_usuarios.TabIndex = 2
        '
        'BO_producto_modificar
        '
        Me.BO_producto_modificar.Image = CType(resources.GetObject("BO_producto_modificar.Image"), System.Drawing.Image)
        Me.BO_producto_modificar.Location = New System.Drawing.Point(1035, 535)
        Me.BO_producto_modificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BO_producto_modificar.Name = "BO_producto_modificar"
        Me.BO_producto_modificar.Size = New System.Drawing.Size(53, 49)
        Me.BO_producto_modificar.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.BO_producto_modificar, "Ver")
        Me.BO_producto_modificar.UseVisualStyleBackColor = True
        '
        'DT_fecha_hasta
        '
        Me.DT_fecha_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_fecha_hasta.Location = New System.Drawing.Point(649, 32)
        Me.DT_fecha_hasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DT_fecha_hasta.Name = "DT_fecha_hasta"
        Me.DT_fecha_hasta.Size = New System.Drawing.Size(324, 26)
        Me.DT_fecha_hasta.TabIndex = 9
        '
        'DT_fecha_desde
        '
        Me.DT_fecha_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_fecha_desde.Location = New System.Drawing.Point(163, 32)
        Me.DT_fecha_desde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DT_fecha_desde.Name = "DT_fecha_desde"
        Me.DT_fecha_desde.Size = New System.Drawing.Size(327, 26)
        Me.DT_fecha_desde.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(505, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USUidDataGridViewTextBoxColumn, Me.VentaprodfechaDataGridViewTextBoxColumn, Me.VentaprodtotalDataGridViewTextBoxColumn, Me.Usuario, Me.VentaprodidDataGridViewTextBoxColumn, Me.VentaidDataGridViewTextBoxColumn, Me.VentaprodestadoDataGridViewTextBoxColumn, Me.VentaprodetalleidDataGridViewTextBoxColumn, Me.VentaprodcantDataGridViewTextBoxColumn, Me.VentaprodprecioDataGridViewTextBoxColumn, Me.VentaprodsubtotalDataGridViewTextBoxColumn, Me.VentaproddescripcionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VentaconsultaBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(21, 97)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1067, 431)
        Me.DataGridView1.TabIndex = 3
        '
        'USUidDataGridViewTextBoxColumn
        '
        Me.USUidDataGridViewTextBoxColumn.DataPropertyName = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.HeaderText = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.Name = "USUidDataGridViewTextBoxColumn"
        Me.USUidDataGridViewTextBoxColumn.ReadOnly = True
        Me.USUidDataGridViewTextBoxColumn.Visible = False
        '
        'VentaprodfechaDataGridViewTextBoxColumn
        '
        Me.VentaprodfechaDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_fecha"
        Me.VentaprodfechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.VentaprodfechaDataGridViewTextBoxColumn.Name = "VentaprodfechaDataGridViewTextBoxColumn"
        Me.VentaprodfechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VentaprodtotalDataGridViewTextBoxColumn
        '
        Me.VentaprodtotalDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_total"
        Me.VentaprodtotalDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.VentaprodtotalDataGridViewTextBoxColumn.Name = "VentaprodtotalDataGridViewTextBoxColumn"
        Me.VentaprodtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'VentaprodidDataGridViewTextBoxColumn
        '
        Me.VentaprodidDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.HeaderText = "ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.Name = "VentaprodidDataGridViewTextBoxColumn"
        Me.VentaprodidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodidDataGridViewTextBoxColumn.Visible = False
        '
        'VentaidDataGridViewTextBoxColumn
        '
        Me.VentaidDataGridViewTextBoxColumn.DataPropertyName = "venta_id"
        Me.VentaidDataGridViewTextBoxColumn.HeaderText = "venta_id"
        Me.VentaidDataGridViewTextBoxColumn.Name = "VentaidDataGridViewTextBoxColumn"
        Me.VentaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaidDataGridViewTextBoxColumn.Visible = False
        '
        'VentaprodestadoDataGridViewTextBoxColumn
        '
        Me.VentaprodestadoDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_estado"
        Me.VentaprodestadoDataGridViewTextBoxColumn.HeaderText = "ventaprod_estado"
        Me.VentaprodestadoDataGridViewTextBoxColumn.Name = "VentaprodestadoDataGridViewTextBoxColumn"
        Me.VentaprodestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodestadoDataGridViewTextBoxColumn.Visible = False
        '
        'VentaprodetalleidDataGridViewTextBoxColumn
        '
        Me.VentaprodetalleidDataGridViewTextBoxColumn.DataPropertyName = "ventaprodetalle_id"
        Me.VentaprodetalleidDataGridViewTextBoxColumn.HeaderText = "ventaprodetalle_id"
        Me.VentaprodetalleidDataGridViewTextBoxColumn.Name = "VentaprodetalleidDataGridViewTextBoxColumn"
        Me.VentaprodetalleidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodetalleidDataGridViewTextBoxColumn.Visible = False
        '
        'VentaprodcantDataGridViewTextBoxColumn
        '
        Me.VentaprodcantDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_cant"
        Me.VentaprodcantDataGridViewTextBoxColumn.HeaderText = "ventaprod_cant"
        Me.VentaprodcantDataGridViewTextBoxColumn.Name = "VentaprodcantDataGridViewTextBoxColumn"
        Me.VentaprodcantDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodcantDataGridViewTextBoxColumn.Visible = False
        '
        'VentaprodprecioDataGridViewTextBoxColumn
        '
        Me.VentaprodprecioDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_precio"
        Me.VentaprodprecioDataGridViewTextBoxColumn.HeaderText = "ventaprod_precio"
        Me.VentaprodprecioDataGridViewTextBoxColumn.Name = "VentaprodprecioDataGridViewTextBoxColumn"
        Me.VentaprodprecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodprecioDataGridViewTextBoxColumn.Visible = False
        '
        'VentaprodsubtotalDataGridViewTextBoxColumn
        '
        Me.VentaprodsubtotalDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_subtotal"
        Me.VentaprodsubtotalDataGridViewTextBoxColumn.HeaderText = "ventaprod_subtotal"
        Me.VentaprodsubtotalDataGridViewTextBoxColumn.Name = "VentaprodsubtotalDataGridViewTextBoxColumn"
        Me.VentaprodsubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodsubtotalDataGridViewTextBoxColumn.Visible = False
        '
        'VentaproddescripcionDataGridViewTextBoxColumn
        '
        Me.VentaproddescripcionDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_descripcion"
        Me.VentaproddescripcionDataGridViewTextBoxColumn.HeaderText = "ventaprod_descripcion"
        Me.VentaproddescripcionDataGridViewTextBoxColumn.Name = "VentaproddescripcionDataGridViewTextBoxColumn"
        Me.VentaproddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaproddescripcionDataGridViewTextBoxColumn.Visible = False
        '
        'VentaconsultaBindingSource1
        '
        Me.VentaconsultaBindingSource1.DataMember = "Venta_consulta"
        Me.VentaconsultaBindingSource1.DataSource = Me.Venta_consulta_ds1
        '
        'Venta_consulta_ds1
        '
        Me.Venta_consulta_ds1.DataSetName = "Venta_consulta_ds"
        Me.Venta_consulta_ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaconsultaBindingSource
        '
        Me.VentaconsultaBindingSource.DataMember = "Venta_consulta"
        Me.VentaconsultaBindingSource.DataSource = Me.Venta_consulta_ds
        '
        'Venta_consulta_ds
        '
        Me.Venta_consulta_ds.DataSetName = "Venta_consulta_ds"
        Me.Venta_consulta_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Venta_Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1172, 692)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Venta_Consulta"
        Me.Text = "Venta_Consulta"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaconsultaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_consulta_ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaconsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_consulta_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_total As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BO_buscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents BO_producto_modificar As System.Windows.Forms.Button
    Friend WithEvents DT_fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VentaconsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_consulta_ds As Aplicacion.Venta_consulta_ds
    Friend WithEvents VentaconsultaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_consulta_ds1 As Aplicacion.Venta_consulta_ds
    Friend WithEvents USUidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodetalleidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodcantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodprecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodsubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaproddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
