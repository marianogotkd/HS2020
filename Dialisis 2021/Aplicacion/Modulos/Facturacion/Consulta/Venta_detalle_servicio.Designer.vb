<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta_detalle_servicio
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Lb_fecha = New System.Windows.Forms.Label()
        Me.lb_servicionro = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_total = New System.Windows.Forms.TextBox()
        Me.TextBox_totalrepuesto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_manoobra = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdxSucIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioProdDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Servicio_DS = New Aplicacion.Servicio_DS()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox_bateria = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_Modelo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Marca = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_color = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox_direccion = New System.Windows.Forms.TextBox()
        Me.TextBox_telefono = New System.Windows.Forms.TextBox()
        Me.TextBox_dni = New System.Windows.Forms.TextBox()
        Me.TextBox_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioProdDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servicio_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(886, 490)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Lb_fecha)
        Me.TabPage1.Controls.Add(Me.lb_servicionro)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(878, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalle de Servicio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Lb_fecha
        '
        Me.Lb_fecha.AutoSize = True
        Me.Lb_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_fecha.Location = New System.Drawing.Point(458, 12)
        Me.Lb_fecha.Name = "Lb_fecha"
        Me.Lb_fecha.Size = New System.Drawing.Size(60, 20)
        Me.Lb_fecha.TabIndex = 246
        Me.Lb_fecha.Text = "Fecha:"
        '
        'lb_servicionro
        '
        Me.lb_servicionro.AutoSize = True
        Me.lb_servicionro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_servicionro.Location = New System.Drawing.Point(21, 12)
        Me.lb_servicionro.Name = "lb_servicionro"
        Me.lb_servicionro.Size = New System.Drawing.Size(97, 20)
        Me.lb_servicionro.TabIndex = 245
        Me.lb_servicionro.Text = "Servicio Nº:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_total)
        Me.GroupBox1.Controls.Add(Me.TextBox_totalrepuesto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_manoobra)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(852, 237)
        Me.GroupBox1.TabIndex = 244
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Repuestos agregados:"
        '
        'TextBox_total
        '
        Me.TextBox_total.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_total.Location = New System.Drawing.Point(714, 202)
        Me.TextBox_total.Name = "TextBox_total"
        Me.TextBox_total.ReadOnly = True
        Me.TextBox_total.Size = New System.Drawing.Size(112, 27)
        Me.TextBox_total.TabIndex = 255
        '
        'TextBox_totalrepuesto
        '
        Me.TextBox_totalrepuesto.BackColor = System.Drawing.Color.White
        Me.TextBox_totalrepuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_totalrepuesto.Location = New System.Drawing.Point(714, 129)
        Me.TextBox_totalrepuesto.Name = "TextBox_totalrepuesto"
        Me.TextBox_totalrepuesto.ReadOnly = True
        Me.TextBox_totalrepuesto.Size = New System.Drawing.Size(112, 27)
        Me.TextBox_totalrepuesto.TabIndex = 251
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(633, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 20)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "TOTAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(593, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 250
        Me.Label5.Text = "Total repuesto:"
        '
        'TextBox_manoobra
        '
        Me.TextBox_manoobra.BackColor = System.Drawing.Color.White
        Me.TextBox_manoobra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_manoobra.Location = New System.Drawing.Point(712, 165)
        Me.TextBox_manoobra.Name = "TextBox_manoobra"
        Me.TextBox_manoobra.ReadOnly = True
        Me.TextBox_manoobra.Size = New System.Drawing.Size(112, 27)
        Me.TextBox_manoobra.TabIndex = 253
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumDataGridViewTextBoxColumn, Me.Cod_prod, Me.DescripcionDataGridViewTextBoxColumn, Me.Cantidad, Me.Costo, Me.StockDataGridViewTextBoxColumn, Me.ProdxSucIDDataGridViewTextBoxColumn, Me.subtotal})
        Me.DataGridView1.DataSource = Me.ServicioProdDSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 21)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Size = New System.Drawing.Size(807, 103)
        Me.DataGridView1.TabIndex = 2
        '
        'NumDataGridViewTextBoxColumn
        '
        Me.NumDataGridViewTextBoxColumn.DataPropertyName = "Num"
        Me.NumDataGridViewTextBoxColumn.HeaderText = "Num"
        Me.NumDataGridViewTextBoxColumn.Name = "NumDataGridViewTextBoxColumn"
        Me.NumDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumDataGridViewTextBoxColumn.Visible = False
        '
        'Cod_prod
        '
        Me.Cod_prod.DataPropertyName = "Cod_prod"
        Me.Cod_prod.HeaderText = "Código"
        Me.Cod_prod.Name = "Cod_prod"
        Me.Cod_prod.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 300
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Costo
        '
        Me.Costo.DataPropertyName = "Costo"
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Visible = False
        '
        'ProdxSucIDDataGridViewTextBoxColumn
        '
        Me.ProdxSucIDDataGridViewTextBoxColumn.DataPropertyName = "ProdxSuc_ID"
        Me.ProdxSucIDDataGridViewTextBoxColumn.HeaderText = "ProdxSuc_ID"
        Me.ProdxSucIDDataGridViewTextBoxColumn.Name = "ProdxSucIDDataGridViewTextBoxColumn"
        Me.ProdxSucIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdxSucIDDataGridViewTextBoxColumn.Visible = False
        '
        'subtotal
        '
        Me.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subtotal.DataPropertyName = "subtotal"
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'ServicioProdDSBindingSource
        '
        Me.ServicioProdDSBindingSource.DataMember = "Servicio_Prod_DS"
        Me.ServicioProdDSBindingSource.DataSource = Me.Servicio_DS
        '
        'Servicio_DS
        '
        Me.Servicio_DS.DataSetName = "Servicio_DS"
        Me.Servicio_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(591, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 252
        Me.Label6.Text = "Mano de obra:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox_bateria)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox_Modelo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox_Marca)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox_color)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox_id)
        Me.GroupBox3.Location = New System.Drawing.Point(449, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 173)
        Me.GroupBox3.TabIndex = 243
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Equipo"
        '
        'TextBox_bateria
        '
        Me.TextBox_bateria.BackColor = System.Drawing.Color.White
        Me.TextBox_bateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_bateria.Location = New System.Drawing.Point(326, 26)
        Me.TextBox_bateria.Name = "TextBox_bateria"
        Me.TextBox_bateria.ReadOnly = True
        Me.TextBox_bateria.Size = New System.Drawing.Size(57, 27)
        Me.TextBox_bateria.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(254, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Bateria:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Color:"
        '
        'TextBox_Modelo
        '
        Me.TextBox_Modelo.BackColor = System.Drawing.Color.White
        Me.TextBox_Modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Modelo.Location = New System.Drawing.Point(85, 60)
        Me.TextBox_Modelo.Name = "TextBox_Modelo"
        Me.TextBox_Modelo.ReadOnly = True
        Me.TextBox_Modelo.Size = New System.Drawing.Size(162, 27)
        Me.TextBox_Modelo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Marca:"
        '
        'TextBox_Marca
        '
        Me.TextBox_Marca.BackColor = System.Drawing.Color.White
        Me.TextBox_Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Marca.Location = New System.Drawing.Point(85, 27)
        Me.TextBox_Marca.Name = "TextBox_Marca"
        Me.TextBox_Marca.ReadOnly = True
        Me.TextBox_Marca.Size = New System.Drawing.Size(162, 27)
        Me.TextBox_Marca.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Modelo"
        '
        'TextBox_color
        '
        Me.TextBox_color.BackColor = System.Drawing.Color.White
        Me.TextBox_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_color.Location = New System.Drawing.Point(85, 96)
        Me.TextBox_color.Name = "TextBox_color"
        Me.TextBox_color.ReadOnly = True
        Me.TextBox_color.Size = New System.Drawing.Size(164, 27)
        Me.TextBox_color.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Imei / Id."
        '
        'TextBox_id
        '
        Me.TextBox_id.BackColor = System.Drawing.Color.White
        Me.TextBox_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_id.Location = New System.Drawing.Point(85, 132)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.ReadOnly = True
        Me.TextBox_id.Size = New System.Drawing.Size(164, 27)
        Me.TextBox_id.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox_direccion)
        Me.GroupBox2.Controls.Add(Me.TextBox_telefono)
        Me.GroupBox2.Controls.Add(Me.TextBox_dni)
        Me.GroupBox2.Controls.Add(Me.TextBox_nombre)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 173)
        Me.GroupBox2.TabIndex = 242
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente:"
        '
        'TextBox_direccion
        '
        Me.TextBox_direccion.BackColor = System.Drawing.Color.White
        Me.TextBox_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_direccion.Location = New System.Drawing.Point(99, 136)
        Me.TextBox_direccion.Name = "TextBox_direccion"
        Me.TextBox_direccion.ReadOnly = True
        Me.TextBox_direccion.Size = New System.Drawing.Size(319, 27)
        Me.TextBox_direccion.TabIndex = 7
        '
        'TextBox_telefono
        '
        Me.TextBox_telefono.BackColor = System.Drawing.Color.White
        Me.TextBox_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_telefono.Location = New System.Drawing.Point(99, 98)
        Me.TextBox_telefono.Name = "TextBox_telefono"
        Me.TextBox_telefono.ReadOnly = True
        Me.TextBox_telefono.Size = New System.Drawing.Size(319, 27)
        Me.TextBox_telefono.TabIndex = 6
        '
        'TextBox_dni
        '
        Me.TextBox_dni.BackColor = System.Drawing.Color.White
        Me.TextBox_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_dni.Location = New System.Drawing.Point(99, 62)
        Me.TextBox_dni.Name = "TextBox_dni"
        Me.TextBox_dni.ReadOnly = True
        Me.TextBox_dni.Size = New System.Drawing.Size(319, 27)
        Me.TextBox_dni.TabIndex = 5
        '
        'TextBox_nombre
        '
        Me.TextBox_nombre.BackColor = System.Drawing.Color.White
        Me.TextBox_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nombre.Location = New System.Drawing.Point(99, 30)
        Me.TextBox_nombre.Name = "TextBox_nombre"
        Me.TextBox_nombre.ReadOnly = True
        Me.TextBox_nombre.Size = New System.Drawing.Size(319, 27)
        Me.TextBox_nombre.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Venta_detalle_servicio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(907, 503)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Venta_detalle_servicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de servicio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioProdDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servicio_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_direccion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_telefono As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_dni As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Modelo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Marca As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox_color As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox_id As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_bateria As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ServicioProdDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Servicio_DS As Aplicacion.Servicio_DS
    Friend WithEvents TextBox_totalrepuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_manoobra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_total As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lb_servicionro As System.Windows.Forms.Label
    Friend WithEvents Lb_fecha As System.Windows.Forms.Label
    Friend WithEvents NumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod_prod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdxSucIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
