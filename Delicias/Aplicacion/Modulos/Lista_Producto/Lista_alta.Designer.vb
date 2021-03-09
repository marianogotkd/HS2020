<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_alta))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GP_dias = New System.Windows.Forms.GroupBox()
        Me.CK_domingo = New System.Windows.Forms.CheckBox()
        Me.CK_sabado = New System.Windows.Forms.CheckBox()
        Me.CK_viernes = New System.Windows.Forms.CheckBox()
        Me.CK_jueves = New System.Windows.Forms.CheckBox()
        Me.CK_miecoles = New System.Windows.Forms.CheckBox()
        Me.CK_martes = New System.Windows.Forms.CheckBox()
        Me.CK_lunes = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RB_LISTA_DIA_no = New System.Windows.Forms.RadioButton()
        Me.RB_LISTA_DIA_si = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GP_Fecha = New System.Windows.Forms.GroupBox()
        Me.DT_LISTA_fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DT_LISTA_fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.RB_LISTA_VIG_no = New System.Windows.Forms.RadioButton()
        Me.RB_LISTA_VIG_si = New System.Windows.Forms.RadioButton()
        Me.TX_LISTA_nom = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PRODidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODdescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LISTAPRODcantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LISTAPRODprecioUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LISTAPRODprecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_ds = New Aplicacion.Lista_ds()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.LB_ERROR = New System.Windows.Forms.Label()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.BO_Socio_Cargar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCAnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BO_descripcion = New System.Windows.Forms.Button()
        Me.TX_descripcion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BO_codbarra = New System.Windows.Forms.Button()
        Me.TX_codbarra = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.BO_codigo = New System.Windows.Forms.Button()
        Me.TX_codigo = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.BO_limpiar = New System.Windows.Forms.Button()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GP_dias.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GP_Fecha.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(866, 492)
        Me.TabControl2.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 466)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Lista: Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.TX_LISTA_nom)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox4.Location = New System.Drawing.Point(28, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(802, 260)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de la Lista"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GP_dias)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(35, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 88)
        Me.GroupBox2.TabIndex = 234
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dias Especiales"
        '
        'GP_dias
        '
        Me.GP_dias.Controls.Add(Me.CK_domingo)
        Me.GP_dias.Controls.Add(Me.CK_sabado)
        Me.GP_dias.Controls.Add(Me.CK_viernes)
        Me.GP_dias.Controls.Add(Me.CK_jueves)
        Me.GP_dias.Controls.Add(Me.CK_miecoles)
        Me.GP_dias.Controls.Add(Me.CK_martes)
        Me.GP_dias.Controls.Add(Me.CK_lunes)
        Me.GP_dias.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GP_dias.Location = New System.Drawing.Point(117, 19)
        Me.GP_dias.Name = "GP_dias"
        Me.GP_dias.Size = New System.Drawing.Size(602, 48)
        Me.GP_dias.TabIndex = 235
        Me.GP_dias.TabStop = False
        Me.GP_dias.Text = "Dias"
        '
        'CK_domingo
        '
        Me.CK_domingo.AutoSize = True
        Me.CK_domingo.Location = New System.Drawing.Point(517, 19)
        Me.CK_domingo.Name = "CK_domingo"
        Me.CK_domingo.Size = New System.Drawing.Size(68, 17)
        Me.CK_domingo.TabIndex = 6
        Me.CK_domingo.Text = "Domingo"
        Me.CK_domingo.UseVisualStyleBackColor = True
        '
        'CK_sabado
        '
        Me.CK_sabado.AutoSize = True
        Me.CK_sabado.Location = New System.Drawing.Point(428, 20)
        Me.CK_sabado.Name = "CK_sabado"
        Me.CK_sabado.Size = New System.Drawing.Size(63, 17)
        Me.CK_sabado.TabIndex = 5
        Me.CK_sabado.Text = "Sabado"
        Me.CK_sabado.UseVisualStyleBackColor = True
        '
        'CK_viernes
        '
        Me.CK_viernes.AutoSize = True
        Me.CK_viernes.Location = New System.Drawing.Point(344, 20)
        Me.CK_viernes.Name = "CK_viernes"
        Me.CK_viernes.Size = New System.Drawing.Size(61, 17)
        Me.CK_viernes.TabIndex = 4
        Me.CK_viernes.Text = "Viernes"
        Me.CK_viernes.UseVisualStyleBackColor = True
        '
        'CK_jueves
        '
        Me.CK_jueves.AutoSize = True
        Me.CK_jueves.Location = New System.Drawing.Point(260, 20)
        Me.CK_jueves.Name = "CK_jueves"
        Me.CK_jueves.Size = New System.Drawing.Size(60, 17)
        Me.CK_jueves.TabIndex = 3
        Me.CK_jueves.Text = "Jueves"
        Me.CK_jueves.UseVisualStyleBackColor = True
        '
        'CK_miecoles
        '
        Me.CK_miecoles.AutoSize = True
        Me.CK_miecoles.Location = New System.Drawing.Point(168, 20)
        Me.CK_miecoles.Name = "CK_miecoles"
        Me.CK_miecoles.Size = New System.Drawing.Size(71, 17)
        Me.CK_miecoles.TabIndex = 2
        Me.CK_miecoles.Text = "Miercoles"
        Me.CK_miecoles.UseVisualStyleBackColor = True
        '
        'CK_martes
        '
        Me.CK_martes.AutoSize = True
        Me.CK_martes.Location = New System.Drawing.Point(92, 20)
        Me.CK_martes.Name = "CK_martes"
        Me.CK_martes.Size = New System.Drawing.Size(58, 17)
        Me.CK_martes.TabIndex = 1
        Me.CK_martes.Text = "Martes"
        Me.CK_martes.UseVisualStyleBackColor = True
        '
        'CK_lunes
        '
        Me.CK_lunes.AutoSize = True
        Me.CK_lunes.Location = New System.Drawing.Point(20, 19)
        Me.CK_lunes.Name = "CK_lunes"
        Me.CK_lunes.Size = New System.Drawing.Size(55, 17)
        Me.CK_lunes.TabIndex = 0
        Me.CK_lunes.Text = "Lunes"
        Me.CK_lunes.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RB_LISTA_DIA_no)
        Me.Panel1.Controls.Add(Me.RB_LISTA_DIA_si)
        Me.Panel1.Location = New System.Drawing.Point(15, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(93, 21)
        Me.Panel1.TabIndex = 234
        '
        'RB_LISTA_DIA_no
        '
        Me.RB_LISTA_DIA_no.AutoSize = True
        Me.RB_LISTA_DIA_no.Location = New System.Drawing.Point(49, 3)
        Me.RB_LISTA_DIA_no.Name = "RB_LISTA_DIA_no"
        Me.RB_LISTA_DIA_no.Size = New System.Drawing.Size(39, 17)
        Me.RB_LISTA_DIA_no.TabIndex = 223
        Me.RB_LISTA_DIA_no.TabStop = True
        Me.RB_LISTA_DIA_no.Text = "No"
        Me.RB_LISTA_DIA_no.UseVisualStyleBackColor = True
        '
        'RB_LISTA_DIA_si
        '
        Me.RB_LISTA_DIA_si.AutoSize = True
        Me.RB_LISTA_DIA_si.Location = New System.Drawing.Point(0, 3)
        Me.RB_LISTA_DIA_si.Name = "RB_LISTA_DIA_si"
        Me.RB_LISTA_DIA_si.Size = New System.Drawing.Size(34, 17)
        Me.RB_LISTA_DIA_si.TabIndex = 222
        Me.RB_LISTA_DIA_si.TabStop = True
        Me.RB_LISTA_DIA_si.Text = "Si"
        Me.RB_LISTA_DIA_si.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GP_Fecha)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(35, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 90)
        Me.GroupBox1.TabIndex = 233
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha de Vigencia"
        '
        'GP_Fecha
        '
        Me.GP_Fecha.Controls.Add(Me.DT_LISTA_fecha_hasta)
        Me.GP_Fecha.Controls.Add(Me.Label1)
        Me.GP_Fecha.Controls.Add(Me.Label5)
        Me.GP_Fecha.Controls.Add(Me.DT_LISTA_fecha_desde)
        Me.GP_Fecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GP_Fecha.Location = New System.Drawing.Point(117, 19)
        Me.GP_Fecha.Name = "GP_Fecha"
        Me.GP_Fecha.Size = New System.Drawing.Size(602, 56)
        Me.GP_Fecha.TabIndex = 236
        Me.GP_Fecha.TabStop = False
        Me.GP_Fecha.Text = "Fecha"
        '
        'DT_LISTA_fecha_hasta
        '
        Me.DT_LISTA_fecha_hasta.Location = New System.Drawing.Point(365, 23)
        Me.DT_LISTA_fecha_hasta.Name = "DT_LISTA_fecha_hasta"
        Me.DT_LISTA_fecha_hasta.Size = New System.Drawing.Size(220, 20)
        Me.DT_LISTA_fecha_hasta.TabIndex = 241
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(315, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "Hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(17, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 239
        Me.Label5.Text = "Desde"
        '
        'DT_LISTA_fecha_desde
        '
        Me.DT_LISTA_fecha_desde.Location = New System.Drawing.Point(72, 23)
        Me.DT_LISTA_fecha_desde.Name = "DT_LISTA_fecha_desde"
        Me.DT_LISTA_fecha_desde.Size = New System.Drawing.Size(220, 20)
        Me.DT_LISTA_fecha_desde.TabIndex = 238
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.RB_LISTA_VIG_no)
        Me.Panel7.Controls.Add(Me.RB_LISTA_VIG_si)
        Me.Panel7.Location = New System.Drawing.Point(15, 39)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(93, 21)
        Me.Panel7.TabIndex = 234
        '
        'RB_LISTA_VIG_no
        '
        Me.RB_LISTA_VIG_no.AutoSize = True
        Me.RB_LISTA_VIG_no.Location = New System.Drawing.Point(49, 3)
        Me.RB_LISTA_VIG_no.Name = "RB_LISTA_VIG_no"
        Me.RB_LISTA_VIG_no.Size = New System.Drawing.Size(39, 17)
        Me.RB_LISTA_VIG_no.TabIndex = 223
        Me.RB_LISTA_VIG_no.TabStop = True
        Me.RB_LISTA_VIG_no.Text = "No"
        Me.RB_LISTA_VIG_no.UseVisualStyleBackColor = True
        '
        'RB_LISTA_VIG_si
        '
        Me.RB_LISTA_VIG_si.AutoSize = True
        Me.RB_LISTA_VIG_si.Location = New System.Drawing.Point(0, 3)
        Me.RB_LISTA_VIG_si.Name = "RB_LISTA_VIG_si"
        Me.RB_LISTA_VIG_si.Size = New System.Drawing.Size(34, 17)
        Me.RB_LISTA_VIG_si.TabIndex = 222
        Me.RB_LISTA_VIG_si.TabStop = True
        Me.RB_LISTA_VIG_si.Text = "Si"
        Me.RB_LISTA_VIG_si.UseVisualStyleBackColor = True
        '
        'TX_LISTA_nom
        '
        Me.TX_LISTA_nom.Location = New System.Drawing.Point(157, 30)
        Me.TX_LISTA_nom.Name = "TX_LISTA_nom"
        Me.TX_LISTA_nom.Size = New System.Drawing.Size(281, 20)
        Me.TX_LISTA_nom.TabIndex = 231
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(47, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 232
        Me.Label11.Text = "Nombre de Lista"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.GroupBox10)
        Me.TabPage9.Controls.Add(Me.GroupBox9)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(858, 466)
        Me.TabPage9.TabIndex = 5
        Me.TabPage9.Text = "Lista: Productos"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.DataGridView2)
        Me.GroupBox10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox10.Location = New System.Drawing.Point(164, 308)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(521, 145)
        Me.GroupBox10.TabIndex = 232
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Productos de la Lista"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODidDataGridViewTextBoxColumn1, Me.PRODdescripcionDataGridViewTextBoxColumn1, Me.LISTAPRODcantDataGridViewTextBoxColumn, Me.LISTAPRODprecioUDataGridViewTextBoxColumn, Me.LISTAPRODprecioDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ListaProductoBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(515, 126)
        Me.DataGridView2.TabIndex = 0
        '
        'PRODidDataGridViewTextBoxColumn1
        '
        Me.PRODidDataGridViewTextBoxColumn1.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn1.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn1.Name = "PRODidDataGridViewTextBoxColumn1"
        Me.PRODidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn1.Visible = False
        '
        'PRODdescripcionDataGridViewTextBoxColumn1
        '
        Me.PRODdescripcionDataGridViewTextBoxColumn1.DataPropertyName = "PROD_id"
        Me.PRODdescripcionDataGridViewTextBoxColumn1.HeaderText = "Producto"
        Me.PRODdescripcionDataGridViewTextBoxColumn1.Name = "PRODdescripcionDataGridViewTextBoxColumn1"
        Me.PRODdescripcionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PRODdescripcionDataGridViewTextBoxColumn1.Width = 150
        '
        'LISTAPRODcantDataGridViewTextBoxColumn
        '
        Me.LISTAPRODcantDataGridViewTextBoxColumn.DataPropertyName = "LISTA_PROD_cant"
        Me.LISTAPRODcantDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.LISTAPRODcantDataGridViewTextBoxColumn.Name = "LISTAPRODcantDataGridViewTextBoxColumn"
        Me.LISTAPRODcantDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LISTAPRODprecioUDataGridViewTextBoxColumn
        '
        Me.LISTAPRODprecioUDataGridViewTextBoxColumn.DataPropertyName = "LISTA_PROD_precioU"
        Me.LISTAPRODprecioUDataGridViewTextBoxColumn.HeaderText = "Precio Unitario"
        Me.LISTAPRODprecioUDataGridViewTextBoxColumn.Name = "LISTAPRODprecioUDataGridViewTextBoxColumn"
        Me.LISTAPRODprecioUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LISTAPRODprecioDataGridViewTextBoxColumn
        '
        Me.LISTAPRODprecioDataGridViewTextBoxColumn.DataPropertyName = "LISTA_PROD_precio"
        Me.LISTAPRODprecioDataGridViewTextBoxColumn.HeaderText = "Precio Total"
        Me.LISTAPRODprecioDataGridViewTextBoxColumn.Name = "LISTAPRODprecioDataGridViewTextBoxColumn"
        Me.LISTAPRODprecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListaProductoBindingSource
        '
        Me.ListaProductoBindingSource.DataMember = "ListaProducto"
        Me.ListaProductoBindingSource.DataSource = Me.Lista_ds
        '
        'Lista_ds
        '
        Me.Lista_ds.DataSetName = "Lista_ds"
        Me.Lista_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.LB_ERROR)
        Me.GroupBox9.Controls.Add(Me.IM_ERROR)
        Me.GroupBox9.Controls.Add(Me.BO_Socio_Cargar)
        Me.GroupBox9.Controls.Add(Me.GroupBox6)
        Me.GroupBox9.Controls.Add(Me.BO_descripcion)
        Me.GroupBox9.Controls.Add(Me.TX_descripcion)
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.BO_codbarra)
        Me.GroupBox9.Controls.Add(Me.TX_codbarra)
        Me.GroupBox9.Controls.Add(Me.Label35)
        Me.GroupBox9.Controls.Add(Me.BO_codigo)
        Me.GroupBox9.Controls.Add(Me.TX_codigo)
        Me.GroupBox9.Controls.Add(Me.Label38)
        Me.GroupBox9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox9.Location = New System.Drawing.Point(29, 10)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(796, 292)
        Me.GroupBox9.TabIndex = 230
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Buscar Producto"
        '
        'LB_ERROR
        '
        Me.LB_ERROR.AutoSize = True
        Me.LB_ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR.ForeColor = System.Drawing.Color.Red
        Me.LB_ERROR.Location = New System.Drawing.Point(724, 29)
        Me.LB_ERROR.Name = "LB_ERROR"
        Me.LB_ERROR.Size = New System.Drawing.Size(59, 15)
        Me.LB_ERROR.TabIndex = 234
        Me.LB_ERROR.Text = "No Existe"
        Me.LB_ERROR.Visible = False
        '
        'IM_ERROR
        '
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(703, 27)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 233
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'BO_Socio_Cargar
        '
        Me.BO_Socio_Cargar.Image = CType(resources.GetObject("BO_Socio_Cargar.Image"), System.Drawing.Image)
        Me.BO_Socio_Cargar.Location = New System.Drawing.Point(737, 98)
        Me.BO_Socio_Cargar.Name = "BO_Socio_Cargar"
        Me.BO_Socio_Cargar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Socio_Cargar.TabIndex = 232
        Me.BO_Socio_Cargar.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(21, 58)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(698, 218)
        Me.GroupBox6.TabIndex = 103
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos del Producto"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(592, 111)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 20)
        Me.TextBox3.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(519, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Precio T."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(592, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(88, 20)
        Me.TextBox2.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(519, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Cantidad"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(592, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 20)
        Me.TextBox1.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(519, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Precio U."
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DataGridView1)
        Me.GroupBox7.Location = New System.Drawing.Point(17, 24)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(483, 180)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Producto"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdidDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.CATnomDataGridViewTextBoxColumn, Me.MARCAnomDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(477, 161)
        Me.DataGridView1.TabIndex = 0
        '
        'ProdidDataGridViewTextBoxColumn
        '
        Me.ProdidDataGridViewTextBoxColumn.DataPropertyName = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.HeaderText = "prod_id"
        Me.ProdidDataGridViewTextBoxColumn.Name = "ProdidDataGridViewTextBoxColumn"
        Me.ProdidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdidDataGridViewTextBoxColumn.Visible = False
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn.Width = 150
        '
        'CATnomDataGridViewTextBoxColumn
        '
        Me.CATnomDataGridViewTextBoxColumn.DataPropertyName = "CAT_nom"
        Me.CATnomDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CATnomDataGridViewTextBoxColumn.Name = "CATnomDataGridViewTextBoxColumn"
        Me.CATnomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CATnomDataGridViewTextBoxColumn.Width = 130
        '
        'MARCAnomDataGridViewTextBoxColumn
        '
        Me.MARCAnomDataGridViewTextBoxColumn.DataPropertyName = "MARCA_nom"
        Me.MARCAnomDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MARCAnomDataGridViewTextBoxColumn.Name = "MARCAnomDataGridViewTextBoxColumn"
        Me.MARCAnomDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCAnomDataGridViewTextBoxColumn.Width = 130
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Lista_ds
        '
        'BO_descripcion
        '
        Me.BO_descripcion.Image = CType(resources.GetObject("BO_descripcion.Image"), System.Drawing.Image)
        Me.BO_descripcion.Location = New System.Drawing.Point(661, 21)
        Me.BO_descripcion.Name = "BO_descripcion"
        Me.BO_descripcion.Size = New System.Drawing.Size(27, 30)
        Me.BO_descripcion.TabIndex = 102
        Me.BO_descripcion.UseVisualStyleBackColor = True
        '
        'TX_descripcion
        '
        Me.TX_descripcion.Location = New System.Drawing.Point(567, 27)
        Me.TX_descripcion.Name = "TX_descripcion"
        Me.TX_descripcion.Size = New System.Drawing.Size(88, 20)
        Me.TX_descripcion.TabIndex = 100
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(505, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Nombre"
        '
        'BO_codbarra
        '
        Me.BO_codbarra.Image = CType(resources.GetObject("BO_codbarra.Image"), System.Drawing.Image)
        Me.BO_codbarra.Location = New System.Drawing.Point(451, 21)
        Me.BO_codbarra.Name = "BO_codbarra"
        Me.BO_codbarra.Size = New System.Drawing.Size(28, 30)
        Me.BO_codbarra.TabIndex = 99
        Me.BO_codbarra.UseVisualStyleBackColor = True
        '
        'TX_codbarra
        '
        Me.TX_codbarra.Location = New System.Drawing.Point(317, 27)
        Me.TX_codbarra.Name = "TX_codbarra"
        Me.TX_codbarra.Size = New System.Drawing.Size(128, 20)
        Me.TX_codbarra.TabIndex = 97
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label35.Location = New System.Drawing.Point(240, 28)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(71, 15)
        Me.Label35.TabIndex = 98
        Me.Label35.Text = "Cod. Barras"
        '
        'BO_codigo
        '
        Me.BO_codigo.Image = CType(resources.GetObject("BO_codigo.Image"), System.Drawing.Image)
        Me.BO_codigo.Location = New System.Drawing.Point(188, 21)
        Me.BO_codigo.Name = "BO_codigo"
        Me.BO_codigo.Size = New System.Drawing.Size(31, 30)
        Me.BO_codigo.TabIndex = 96
        Me.BO_codigo.UseVisualStyleBackColor = True
        '
        'TX_codigo
        '
        Me.TX_codigo.Location = New System.Drawing.Point(94, 27)
        Me.TX_codigo.Name = "TX_codigo"
        Me.TX_codigo.Size = New System.Drawing.Size(88, 20)
        Me.TX_codigo.TabIndex = 94
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label38.Location = New System.Drawing.Point(42, 28)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(46, 15)
        Me.Label38.TabIndex = 95
        Me.Label38.Text = "Codigo"
        '
        'BO_guardar
        '
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(834, 510)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(40, 40)
        Me.BO_guardar.TabIndex = 17
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'BO_limpiar
        '
        Me.BO_limpiar.Image = CType(resources.GetObject("BO_limpiar.Image"), System.Drawing.Image)
        Me.BO_limpiar.Location = New System.Drawing.Point(788, 510)
        Me.BO_limpiar.Name = "BO_limpiar"
        Me.BO_limpiar.Size = New System.Drawing.Size(40, 40)
        Me.BO_limpiar.TabIndex = 18
        Me.BO_limpiar.UseVisualStyleBackColor = True
        '
        'Lista_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.BO_guardar)
        Me.Controls.Add(Me.BO_limpiar)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "Lista_alta"
        Me.Text = "Lista_alta"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GP_dias.ResumeLayout(False)
        Me.GP_dias.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GP_Fecha.ResumeLayout(False)
        Me.GP_Fecha.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_dias As System.Windows.Forms.GroupBox
    Friend WithEvents CK_domingo As System.Windows.Forms.CheckBox
    Friend WithEvents CK_sabado As System.Windows.Forms.CheckBox
    Friend WithEvents CK_viernes As System.Windows.Forms.CheckBox
    Friend WithEvents CK_jueves As System.Windows.Forms.CheckBox
    Friend WithEvents CK_miecoles As System.Windows.Forms.CheckBox
    Friend WithEvents CK_martes As System.Windows.Forms.CheckBox
    Friend WithEvents CK_lunes As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RB_LISTA_DIA_no As System.Windows.Forms.RadioButton
    Friend WithEvents RB_LISTA_DIA_si As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents DT_LISTA_fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DT_LISTA_fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents RB_LISTA_VIG_no As System.Windows.Forms.RadioButton
    Friend WithEvents RB_LISTA_VIG_si As System.Windows.Forms.RadioButton
    Friend WithEvents TX_LISTA_nom As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents BO_Socio_Cargar As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_descripcion As System.Windows.Forms.Button
    Friend WithEvents TX_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BO_codbarra As System.Windows.Forms.Button
    Friend WithEvents TX_codbarra As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents BO_codigo As System.Windows.Forms.Button
    Friend WithEvents TX_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CATnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCAnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_ds As Aplicacion.Lista_ds
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents BO_limpiar As System.Windows.Forms.Button
    Friend WithEvents PRODidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODdescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LISTAPRODcantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LISTAPRODprecioUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LISTAPRODprecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListaProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents LB_ERROR As System.Windows.Forms.Label
End Class
