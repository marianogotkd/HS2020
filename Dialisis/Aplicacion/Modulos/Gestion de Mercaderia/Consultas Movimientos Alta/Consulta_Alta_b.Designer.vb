<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Alta_b
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_Alta_b))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker_desde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_hasta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tx_Buscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BO_ver = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerDetCantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerDetprecioUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerDetsubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerFechaHoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerfacturaNRODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerfacturafechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerremitoNRODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMerremitofechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovMeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalidOrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosconsultabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DconsultamovaltaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.D_consulta_mov_alta = New Aplicacion.D_consulta_mov_alta()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_buscar_proveedor = New System.Windows.Forms.Button()
        Me.combo_proveedor = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientosconsultabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DconsultamovaltaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D_consulta_mov_alta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button_buscar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_desde)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_hasta)
        Me.GroupBox3.Location = New System.Drawing.Point(349, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(619, 56)
        Me.GroupBox3.TabIndex = 252
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrar por rango de fechas:"
        '
        'Button_buscar
        '
        Me.Button_buscar.Image = CType(resources.GetObject("Button_buscar.Image"), System.Drawing.Image)
        Me.Button_buscar.Location = New System.Drawing.Point(494, 13)
        Me.Button_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(43, 37)
        Me.Button_buscar.TabIndex = 257
        Me.Button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_buscar, "Buscar")
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(293, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 255
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(85, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 254
        Me.Label2.Text = "Desde:"
        '
        'DateTimePicker_desde
        '
        Me.DateTimePicker_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_desde.Location = New System.Drawing.Point(144, 21)
        Me.DateTimePicker_desde.Name = "DateTimePicker_desde"
        Me.DateTimePicker_desde.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker_desde.TabIndex = 252
        '
        'DateTimePicker_hasta
        '
        Me.DateTimePicker_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_hasta.Location = New System.Drawing.Point(348, 21)
        Me.DateTimePicker_hasta.Name = "DateTimePicker_hasta"
        Me.DateTimePicker_hasta.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker_hasta.TabIndex = 253
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(975, 524)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro historico de ingresos de stock"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.tx_Buscar)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.BO_ver)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(962, 441)
        Me.GroupBox4.TabIndex = 258
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultado de la busqueda:"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button2.Location = New System.Drawing.Point(696, 368)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 43)
        Me.Button2.TabIndex = 261
        Me.Button2.Text = "Reporte detallado"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(831, 368)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 260
        Me.Button1.Text = "Generar reporte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tx_Buscar
        '
        Me.tx_Buscar.BackColor = System.Drawing.Color.White
        Me.tx_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Buscar.Location = New System.Drawing.Point(99, 20)
        Me.tx_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Buscar.Name = "tx_Buscar"
        Me.tx_Buscar.Size = New System.Drawing.Size(300, 22)
        Me.tx_Buscar.TabIndex = 255
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 254
        Me.Label1.Text = "Filtrar resultados:"
        '
        'BO_ver
        '
        Me.BO_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_ver.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_ver.Location = New System.Drawing.Point(343, 368)
        Me.BO_ver.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_ver.Name = "BO_ver"
        Me.BO_ver.Size = New System.Drawing.Size(141, 43)
        Me.BO_ver.TabIndex = 249
        Me.BO_ver.Text = "Ver detalle"
        Me.BO_ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_ver.UseVisualStyleBackColor = True
        Me.BO_ver.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.MovMerDetCantidadDataGridViewTextBoxColumn, Me.MovMerDetprecioUDataGridViewTextBoxColumn, Me.MovMerDetsubtotalDataGridViewTextBoxColumn, Me.MovMerFechaHoraDataGridViewTextBoxColumn, Me.MovMerfacturaNRODataGridViewTextBoxColumn, Me.MovMerfacturafechaDataGridViewTextBoxColumn, Me.MovMerremitoNRODataGridViewTextBoxColumn, Me.MovMerremitofechaDataGridViewTextBoxColumn, Me.MovMeridDataGridViewTextBoxColumn, Me.SucursalidOrigenDataGridViewTextBoxColumn, Me.OrigenDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.USUidDataGridViewTextBoxColumn, Me.ProvidDataGridViewTextBoxColumn, Me.ProvnombreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MovimientosconsultabBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 50)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(948, 310)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 18
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
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Insumo"
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
        'MovMerDetprecioUDataGridViewTextBoxColumn
        '
        Me.MovMerDetprecioUDataGridViewTextBoxColumn.DataPropertyName = "MovMerDet_precioU"
        Me.MovMerDetprecioUDataGridViewTextBoxColumn.HeaderText = "MovMerDet_precioU"
        Me.MovMerDetprecioUDataGridViewTextBoxColumn.Name = "MovMerDetprecioUDataGridViewTextBoxColumn"
        Me.MovMerDetprecioUDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovMerDetprecioUDataGridViewTextBoxColumn.Visible = False
        '
        'MovMerDetsubtotalDataGridViewTextBoxColumn
        '
        Me.MovMerDetsubtotalDataGridViewTextBoxColumn.DataPropertyName = "MovMerDet_subtotal"
        Me.MovMerDetsubtotalDataGridViewTextBoxColumn.HeaderText = "MovMerDet_subtotal"
        Me.MovMerDetsubtotalDataGridViewTextBoxColumn.Name = "MovMerDetsubtotalDataGridViewTextBoxColumn"
        Me.MovMerDetsubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovMerDetsubtotalDataGridViewTextBoxColumn.Visible = False
        '
        'MovMerFechaHoraDataGridViewTextBoxColumn
        '
        Me.MovMerFechaHoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MovMerFechaHoraDataGridViewTextBoxColumn.DataPropertyName = "MovMer_FechaHora"
        Me.MovMerFechaHoraDataGridViewTextBoxColumn.HeaderText = "Fecha de registro"
        Me.MovMerFechaHoraDataGridViewTextBoxColumn.Name = "MovMerFechaHoraDataGridViewTextBoxColumn"
        Me.MovMerFechaHoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovMerFechaHoraDataGridViewTextBoxColumn.Visible = False
        '
        'MovMerfacturaNRODataGridViewTextBoxColumn
        '
        Me.MovMerfacturaNRODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MovMerfacturaNRODataGridViewTextBoxColumn.DataPropertyName = "MovMer_facturaNRO"
        Me.MovMerfacturaNRODataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.MovMerfacturaNRODataGridViewTextBoxColumn.Name = "MovMerfacturaNRODataGridViewTextBoxColumn"
        Me.MovMerfacturaNRODataGridViewTextBoxColumn.ReadOnly = True
        Me.MovMerfacturaNRODataGridViewTextBoxColumn.Visible = False
        '
        'MovMerfacturafechaDataGridViewTextBoxColumn
        '
        Me.MovMerfacturafechaDataGridViewTextBoxColumn.DataPropertyName = "MovMer_facturafecha"
        Me.MovMerfacturafechaDataGridViewTextBoxColumn.HeaderText = "MovMer_facturafecha"
        Me.MovMerfacturafechaDataGridViewTextBoxColumn.Name = "MovMerfacturafechaDataGridViewTextBoxColumn"
        Me.MovMerfacturafechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovMerfacturafechaDataGridViewTextBoxColumn.Visible = False
        '
        'MovMerremitoNRODataGridViewTextBoxColumn
        '
        Me.MovMerremitoNRODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MovMerremitoNRODataGridViewTextBoxColumn.DataPropertyName = "MovMer_remitoNRO"
        Me.MovMerremitoNRODataGridViewTextBoxColumn.HeaderText = "Remito"
        Me.MovMerremitoNRODataGridViewTextBoxColumn.Name = "MovMerremitoNRODataGridViewTextBoxColumn"
        Me.MovMerremitoNRODataGridViewTextBoxColumn.ReadOnly = True
        Me.MovMerremitoNRODataGridViewTextBoxColumn.Visible = False
        '
        'MovMerremitofechaDataGridViewTextBoxColumn
        '
        Me.MovMerremitofechaDataGridViewTextBoxColumn.DataPropertyName = "MovMer_remitofecha"
        Me.MovMerremitofechaDataGridViewTextBoxColumn.HeaderText = "MovMer_remitofecha"
        Me.MovMerremitofechaDataGridViewTextBoxColumn.Name = "MovMerremitofechaDataGridViewTextBoxColumn"
        Me.MovMerremitofechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovMerremitofechaDataGridViewTextBoxColumn.Visible = False
        '
        'MovMeridDataGridViewTextBoxColumn
        '
        Me.MovMeridDataGridViewTextBoxColumn.DataPropertyName = "MovMer_id"
        Me.MovMeridDataGridViewTextBoxColumn.HeaderText = "MovMer_id"
        Me.MovMeridDataGridViewTextBoxColumn.Name = "MovMeridDataGridViewTextBoxColumn"
        Me.MovMeridDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovMeridDataGridViewTextBoxColumn.Visible = False
        '
        'SucursalidOrigenDataGridViewTextBoxColumn
        '
        Me.SucursalidOrigenDataGridViewTextBoxColumn.DataPropertyName = "sucursal_id_Origen"
        Me.SucursalidOrigenDataGridViewTextBoxColumn.HeaderText = "sucursal_id_Origen"
        Me.SucursalidOrigenDataGridViewTextBoxColumn.Name = "SucursalidOrigenDataGridViewTextBoxColumn"
        Me.SucursalidOrigenDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucursalidOrigenDataGridViewTextBoxColumn.Visible = False
        '
        'OrigenDataGridViewTextBoxColumn
        '
        Me.OrigenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrigenDataGridViewTextBoxColumn.DataPropertyName = "Origen"
        Me.OrigenDataGridViewTextBoxColumn.HeaderText = "Sucursal Origen"
        Me.OrigenDataGridViewTextBoxColumn.Name = "OrigenDataGridViewTextBoxColumn"
        Me.OrigenDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrigenDataGridViewTextBoxColumn.Visible = False
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'USUidDataGridViewTextBoxColumn
        '
        Me.USUidDataGridViewTextBoxColumn.DataPropertyName = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.HeaderText = "USU_id"
        Me.USUidDataGridViewTextBoxColumn.Name = "USUidDataGridViewTextBoxColumn"
        Me.USUidDataGridViewTextBoxColumn.ReadOnly = True
        Me.USUidDataGridViewTextBoxColumn.Visible = False
        '
        'ProvidDataGridViewTextBoxColumn
        '
        Me.ProvidDataGridViewTextBoxColumn.DataPropertyName = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.HeaderText = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.Name = "ProvidDataGridViewTextBoxColumn"
        Me.ProvidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvidDataGridViewTextBoxColumn.Visible = False
        '
        'ProvnombreDataGridViewTextBoxColumn
        '
        Me.ProvnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProvnombreDataGridViewTextBoxColumn.DataPropertyName = "Prov_nombre"
        Me.ProvnombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProvnombreDataGridViewTextBoxColumn.Name = "ProvnombreDataGridViewTextBoxColumn"
        Me.ProvnombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvnombreDataGridViewTextBoxColumn.Visible = False
        '
        'MovimientosconsultabBindingSource
        '
        Me.MovimientosconsultabBindingSource.DataMember = "movimientos_consulta_b"
        Me.MovimientosconsultabBindingSource.DataSource = Me.DconsultamovaltaBindingSource
        '
        'DconsultamovaltaBindingSource
        '
        Me.DconsultamovaltaBindingSource.DataSource = Me.D_consulta_mov_alta
        Me.DconsultamovaltaBindingSource.Position = 0
        '
        'D_consulta_mov_alta
        '
        Me.D_consulta_mov_alta.DataSetName = "D_consulta_mov_alta"
        Me.D_consulta_mov_alta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button_buscar_proveedor)
        Me.GroupBox2.Controls.Add(Me.combo_proveedor)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 56)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione proveedor:"
        '
        'Button_buscar_proveedor
        '
        Me.Button_buscar_proveedor.Image = CType(resources.GetObject("Button_buscar_proveedor.Image"), System.Drawing.Image)
        Me.Button_buscar_proveedor.Location = New System.Drawing.Point(283, 10)
        Me.Button_buscar_proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar_proveedor.Name = "Button_buscar_proveedor"
        Me.Button_buscar_proveedor.Size = New System.Drawing.Size(43, 37)
        Me.Button_buscar_proveedor.TabIndex = 258
        Me.Button_buscar_proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_buscar_proveedor, "Obtener")
        Me.Button_buscar_proveedor.UseVisualStyleBackColor = True
        Me.Button_buscar_proveedor.Visible = False
        '
        'combo_proveedor
        '
        Me.combo_proveedor.BackColor = System.Drawing.SystemColors.Info
        Me.combo_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.combo_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.combo_proveedor.FormattingEnabled = True
        Me.combo_proveedor.Location = New System.Drawing.Point(6, 19)
        Me.combo_proveedor.Name = "combo_proveedor"
        Me.combo_proveedor.Size = New System.Drawing.Size(270, 21)
        Me.combo_proveedor.TabIndex = 30
        '
        'Consulta_Alta_b
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(993, 538)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Consulta_Alta_b"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Alta (solo insumos)"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientosconsultabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DconsultamovaltaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D_consulta_mov_alta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DconsultamovaltaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents D_consulta_mov_alta As Aplicacion.D_consulta_mov_alta
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_buscar_proveedor As System.Windows.Forms.Button
    Friend WithEvents combo_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents MovimientosconsultabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerDetCantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerDetprecioUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerDetsubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerFechaHoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerfacturaNRODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerfacturafechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerremitoNRODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMerremitofechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovMeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalidOrigenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrigenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BO_ver As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
