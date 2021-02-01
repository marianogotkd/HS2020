<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Alta_a_detalle
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_subtotal = New System.Windows.Forms.TextBox()
        Me.tb_iva = New System.Windows.Forms.TextBox()
        Me.TextBox_proveedor = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.remito_fecha = New System.Windows.Forms.TextBox()
        Me.remito_nro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.factura_fecha = New System.Windows.Forms.TextBox()
        Me.factura_nro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MovMerDet_precioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerDet_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox_destino = New System.Windows.Forms.TextBox()
        Me.TextBox_origen = New System.Windows.Forms.TextBox()
        Me.TextBox_usuario = New System.Windows.Forms.TextBox()
        Me.TextBox_fecha = New System.Windows.Forms.TextBox()
        Me.TextBox_concepto = New System.Windows.Forms.TextBox()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Lb_destino = New System.Windows.Forms.Label()
        Me.Lb_origen = New System.Windows.Forms.Label()
        Me.Lb_id = New System.Windows.Forms.Label()
        Me.Lb_concepto = New System.Windows.Forms.Label()
        Me.Lb_fecha = New System.Windows.Forms.Label()
        Me.Lb_usuario = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerDetCantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.D_consulta_mov_alta = New Aplicacion.D_consulta_mov_alta()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D_consulta_mov_alta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tb_total)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tb_subtotal)
        Me.GroupBox2.Controls.Add(Me.tb_iva)
        Me.GroupBox2.Controls.Add(Me.TextBox_proveedor)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.TextBox_destino)
        Me.GroupBox2.Controls.Add(Me.TextBox_origen)
        Me.GroupBox2.Controls.Add(Me.TextBox_usuario)
        Me.GroupBox2.Controls.Add(Me.TextBox_fecha)
        Me.GroupBox2.Controls.Add(Me.TextBox_concepto)
        Me.GroupBox2.Controls.Add(Me.TextBox_ID)
        Me.GroupBox2.Controls.Add(Me.Lb_destino)
        Me.GroupBox2.Controls.Add(Me.Lb_origen)
        Me.GroupBox2.Controls.Add(Me.Lb_id)
        Me.GroupBox2.Controls.Add(Me.Lb_concepto)
        Me.GroupBox2.Controls.Add(Me.Lb_fecha)
        Me.GroupBox2.Controls.Add(Me.Lb_usuario)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(855, 519)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Movimiento seleccionado:"
        '
        'tb_total
        '
        Me.tb_total.BackColor = System.Drawing.SystemColors.Info
        Me.tb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total.Location = New System.Drawing.Point(438, 461)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.ReadOnly = True
        Me.tb_total.Size = New System.Drawing.Size(130, 22)
        Me.tb_total.TabIndex = 260
        Me.tb_total.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(257, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 258
        Me.Label8.Text = "IVA: %"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(359, 465)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 259
        Me.Label9.Text = "TOTAL: $"
        '
        'tb_subtotal
        '
        Me.tb_subtotal.BackColor = System.Drawing.SystemColors.Info
        Me.tb_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_subtotal.Location = New System.Drawing.Point(121, 461)
        Me.tb_subtotal.Name = "tb_subtotal"
        Me.tb_subtotal.ReadOnly = True
        Me.tb_subtotal.Size = New System.Drawing.Size(130, 22)
        Me.tb_subtotal.TabIndex = 258
        Me.tb_subtotal.Text = "0"
        '
        'tb_iva
        '
        Me.tb_iva.BackColor = System.Drawing.SystemColors.Info
        Me.tb_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_iva.Location = New System.Drawing.Point(310, 461)
        Me.tb_iva.Name = "tb_iva"
        Me.tb_iva.ReadOnly = True
        Me.tb_iva.Size = New System.Drawing.Size(43, 22)
        Me.tb_iva.TabIndex = 259
        Me.tb_iva.Text = "0"
        '
        'TextBox_proveedor
        '
        Me.TextBox_proveedor.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_proveedor.Location = New System.Drawing.Point(80, 197)
        Me.TextBox_proveedor.Name = "TextBox_proveedor"
        Me.TextBox_proveedor.ReadOnly = True
        Me.TextBox_proveedor.Size = New System.Drawing.Size(254, 20)
        Me.TextBox_proveedor.TabIndex = 261
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.remito_fecha)
        Me.GroupBox3.Controls.Add(Me.remito_nro)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(391, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 69)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle Remito"
        '
        'remito_fecha
        '
        Me.remito_fecha.BackColor = System.Drawing.SystemColors.Info
        Me.remito_fecha.Location = New System.Drawing.Point(82, 45)
        Me.remito_fecha.Name = "remito_fecha"
        Me.remito_fecha.ReadOnly = True
        Me.remito_fecha.Size = New System.Drawing.Size(130, 20)
        Me.remito_fecha.TabIndex = 31
        '
        'remito_nro
        '
        Me.remito_nro.BackColor = System.Drawing.SystemColors.Info
        Me.remito_nro.Location = New System.Drawing.Point(82, 19)
        Me.remito_nro.Name = "remito_nro"
        Me.remito_nro.ReadOnly = True
        Me.remito_nro.Size = New System.Drawing.Size(130, 20)
        Me.remito_nro.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 260
        Me.Label7.Text = "Proveedor:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.factura_fecha)
        Me.GroupBox1.Controls.Add(Me.factura_nro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 69)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Factura"
        '
        'factura_fecha
        '
        Me.factura_fecha.BackColor = System.Drawing.SystemColors.Info
        Me.factura_fecha.Location = New System.Drawing.Point(102, 45)
        Me.factura_fecha.Name = "factura_fecha"
        Me.factura_fecha.ReadOnly = True
        Me.factura_fecha.Size = New System.Drawing.Size(130, 20)
        Me.factura_fecha.TabIndex = 30
        '
        'factura_nro
        '
        Me.factura_nro.BackColor = System.Drawing.SystemColors.Info
        Me.factura_nro.Location = New System.Drawing.Point(102, 19)
        Me.factura_nro.Name = "factura_nro"
        Me.factura_nro.ReadOnly = True
        Me.factura_nro.Size = New System.Drawing.Size(130, 20)
        Me.factura_nro.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nro:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(591, 465)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 259
        Me.Button1.Text = "Generar reporte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Listado de productos:"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button4.Location = New System.Drawing.Point(723, 465)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 43)
        Me.Button4.TabIndex = 256
        Me.Button4.Text = "Volver"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.MovMerDetCantidadDataGridViewTextBoxColumn, Me.MovMerDet_precioU, Me.MovMerDet_subtotal})
        Me.DataGridView2.DataSource = Me.MovimientosdetalleBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(18, 252)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(779, 202)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 34
        '
        'MovMerDet_precioU
        '
        Me.MovMerDet_precioU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MovMerDet_precioU.DataPropertyName = "MovMerDet_precioU"
        Me.MovMerDet_precioU.HeaderText = "Precio U."
        Me.MovMerDet_precioU.Name = "MovMerDet_precioU"
        Me.MovMerDet_precioU.ReadOnly = True
        '
        'MovMerDet_subtotal
        '
        Me.MovMerDet_subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MovMerDet_subtotal.DataPropertyName = "MovMerDet_subtotal"
        Me.MovMerDet_subtotal.HeaderText = "Subtotal"
        Me.MovMerDet_subtotal.Name = "MovMerDet_subtotal"
        Me.MovMerDet_subtotal.ReadOnly = True
        '
        'TextBox_destino
        '
        Me.TextBox_destino.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_destino.Location = New System.Drawing.Point(536, 76)
        Me.TextBox_destino.Name = "TextBox_destino"
        Me.TextBox_destino.ReadOnly = True
        Me.TextBox_destino.Size = New System.Drawing.Size(254, 20)
        Me.TextBox_destino.TabIndex = 33
        Me.TextBox_destino.Visible = False
        '
        'TextBox_origen
        '
        Me.TextBox_origen.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_origen.Location = New System.Drawing.Point(536, 54)
        Me.TextBox_origen.Name = "TextBox_origen"
        Me.TextBox_origen.ReadOnly = True
        Me.TextBox_origen.Size = New System.Drawing.Size(254, 20)
        Me.TextBox_origen.TabIndex = 32
        '
        'TextBox_usuario
        '
        Me.TextBox_usuario.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_usuario.Location = New System.Drawing.Point(536, 32)
        Me.TextBox_usuario.Name = "TextBox_usuario"
        Me.TextBox_usuario.ReadOnly = True
        Me.TextBox_usuario.Size = New System.Drawing.Size(254, 20)
        Me.TextBox_usuario.TabIndex = 31
        '
        'TextBox_fecha
        '
        Me.TextBox_fecha.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_fecha.Location = New System.Drawing.Point(120, 76)
        Me.TextBox_fecha.Name = "TextBox_fecha"
        Me.TextBox_fecha.ReadOnly = True
        Me.TextBox_fecha.Size = New System.Drawing.Size(265, 20)
        Me.TextBox_fecha.TabIndex = 30
        '
        'TextBox_concepto
        '
        Me.TextBox_concepto.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_concepto.Location = New System.Drawing.Point(120, 54)
        Me.TextBox_concepto.Name = "TextBox_concepto"
        Me.TextBox_concepto.ReadOnly = True
        Me.TextBox_concepto.Size = New System.Drawing.Size(265, 20)
        Me.TextBox_concepto.TabIndex = 29
        '
        'TextBox_ID
        '
        Me.TextBox_ID.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_ID.Location = New System.Drawing.Point(120, 32)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(130, 20)
        Me.TextBox_ID.TabIndex = 28
        '
        'Lb_destino
        '
        Me.Lb_destino.AutoSize = True
        Me.Lb_destino.Location = New System.Drawing.Point(396, 82)
        Me.Lb_destino.Name = "Lb_destino"
        Me.Lb_destino.Size = New System.Drawing.Size(105, 13)
        Me.Lb_destino.TabIndex = 27
        Me.Lb_destino.Text = "Sucursal de Destino:"
        Me.Lb_destino.Visible = False
        '
        'Lb_origen
        '
        Me.Lb_origen.AutoSize = True
        Me.Lb_origen.Location = New System.Drawing.Point(396, 58)
        Me.Lb_origen.Name = "Lb_origen"
        Me.Lb_origen.Size = New System.Drawing.Size(100, 13)
        Me.Lb_origen.TabIndex = 26
        Me.Lb_origen.Text = "Sucursal de Origen:"
        '
        'Lb_id
        '
        Me.Lb_id.AutoSize = True
        Me.Lb_id.Location = New System.Drawing.Point(25, 36)
        Me.Lb_id.Name = "Lb_id"
        Me.Lb_id.Size = New System.Drawing.Size(21, 13)
        Me.Lb_id.TabIndex = 22
        Me.Lb_id.Text = "ID:"
        '
        'Lb_concepto
        '
        Me.Lb_concepto.AutoSize = True
        Me.Lb_concepto.Location = New System.Drawing.Point(25, 58)
        Me.Lb_concepto.Name = "Lb_concepto"
        Me.Lb_concepto.Size = New System.Drawing.Size(56, 13)
        Me.Lb_concepto.TabIndex = 23
        Me.Lb_concepto.Text = "Concepto:"
        '
        'Lb_fecha
        '
        Me.Lb_fecha.AutoSize = True
        Me.Lb_fecha.Location = New System.Drawing.Point(25, 80)
        Me.Lb_fecha.Name = "Lb_fecha"
        Me.Lb_fecha.Size = New System.Drawing.Size(74, 13)
        Me.Lb_fecha.TabIndex = 24
        Me.Lb_fecha.Text = "Fecha y Hora:"
        '
        'Lb_usuario
        '
        Me.Lb_usuario.AutoSize = True
        Me.Lb_usuario.Location = New System.Drawing.Point(396, 36)
        Me.Lb_usuario.Name = "Lb_usuario"
        Me.Lb_usuario.Size = New System.Drawing.Size(46, 13)
        Me.Lb_usuario.TabIndex = 25
        Me.Lb_usuario.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 476)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "SUBTOTAL: $"
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovMerDetCantidadDataGridViewTextBoxColumn
        '
        Me.MovMerDetCantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MovMerDetCantidadDataGridViewTextBoxColumn.DataPropertyName = "MovMerDet_Cantidad"
        Me.MovMerDetCantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.MovMerDetCantidadDataGridViewTextBoxColumn.Name = "MovMerDetCantidadDataGridViewTextBoxColumn"
        Me.MovMerDetCantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovimientosdetalleBindingSource
        '
        Me.MovimientosdetalleBindingSource.DataMember = "movimientos_detalle"
        Me.MovimientosdetalleBindingSource.DataSource = Me.D_consulta_mov_alta
        '
        'D_consulta_mov_alta
        '
        Me.D_consulta_mov_alta.DataSetName = "D_consulta_mov_alta"
        Me.D_consulta_mov_alta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Consulta_Alta_a_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(892, 578)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consulta_Alta_a_detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de ingreso registrado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D_consulta_mov_alta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox_destino As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_origen As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_usuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_fecha As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_concepto As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lb_destino As System.Windows.Forms.Label
    Friend WithEvents Lb_origen As System.Windows.Forms.Label
    Friend WithEvents Lb_id As System.Windows.Forms.Label
    Friend WithEvents Lb_concepto As System.Windows.Forms.Label
    Friend WithEvents Lb_fecha As System.Windows.Forms.Label
    Friend WithEvents Lb_usuario As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents remito_fecha As System.Windows.Forms.TextBox
    Friend WithEvents remito_nro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents factura_fecha As System.Windows.Forms.TextBox
    Friend WithEvents factura_nro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MovimientosdetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents D_consulta_mov_alta As Aplicacion.D_consulta_mov_alta
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerDetCantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerDet_precioU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerDet_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_iva As System.Windows.Forms.TextBox
    Friend WithEvents tb_total As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
