<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_modificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_modificar))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DG_LISTA = New System.Windows.Forms.DataGridView()
        Me.LISTAidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LISTAnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LISTAfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_ds = New Aplicacion.Lista_ds()
        Me.LB_LISTA_ERROR = New System.Windows.Forms.Label()
        Me.IM_LISTA_ERROR = New System.Windows.Forms.PictureBox()
        Me.BO_LISTA_buscar = New System.Windows.Forms.Button()
        Me.TX_nom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BO_LISTA_cargar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GP_LISTA_datos = New System.Windows.Forms.GroupBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GP_LISTA_producto2 = New System.Windows.Forms.GroupBox()
        Me.DG_ListaProducto = New System.Windows.Forms.DataGridView()
        Me.PRODidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GP_LISTA_productos = New System.Windows.Forms.GroupBox()
        Me.LB_ERROR = New System.Windows.Forms.Label()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.BO_Cargar = New System.Windows.Forms.Button()
        Me.GP_Producto = New System.Windows.Forms.GroupBox()
        Me.TX_LISTA_PROD_total = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TX_LISTA_PROD_cant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TX_LISTA_PROD_precio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DG_Producto = New System.Windows.Forms.DataGridView()
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
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DG_LISTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IM_LISTA_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GP_LISTA_datos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GP_dias.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GP_Fecha.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GP_LISTA_producto2.SuspendLayout()
        CType(Me.DG_ListaProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_LISTA_productos.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Producto.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(866, 492)
        Me.TabControl2.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.BO_LISTA_cargar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(858, 466)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "Lista: Buscar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.LB_LISTA_ERROR)
        Me.GroupBox3.Controls.Add(Me.IM_LISTA_ERROR)
        Me.GroupBox3.Controls.Add(Me.BO_LISTA_buscar)
        Me.GroupBox3.Controls.Add(Me.TX_nom)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(168, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(477, 399)
        Me.GroupBox3.TabIndex = 231
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar Lista de Productos"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DG_LISTA)
        Me.GroupBox6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox6.Location = New System.Drawing.Point(17, 58)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(437, 322)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Lista de Productos"
        '
        'DG_LISTA
        '
        Me.DG_LISTA.AllowUserToAddRows = False
        Me.DG_LISTA.AllowUserToDeleteRows = False
        Me.DG_LISTA.AutoGenerateColumns = False
        Me.DG_LISTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_LISTA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LISTAidDataGridViewTextBoxColumn, Me.LISTAnomDataGridViewTextBoxColumn, Me.LISTAfechaDataGridViewTextBoxColumn})
        Me.DG_LISTA.DataSource = Me.ListaBindingSource
        Me.DG_LISTA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_LISTA.Location = New System.Drawing.Point(3, 16)
        Me.DG_LISTA.Name = "DG_LISTA"
        Me.DG_LISTA.ReadOnly = True
        Me.DG_LISTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_LISTA.Size = New System.Drawing.Size(431, 303)
        Me.DG_LISTA.TabIndex = 0
        '
        'LISTAidDataGridViewTextBoxColumn
        '
        Me.LISTAidDataGridViewTextBoxColumn.DataPropertyName = "LISTA_id"
        Me.LISTAidDataGridViewTextBoxColumn.HeaderText = "LISTA_id"
        Me.LISTAidDataGridViewTextBoxColumn.Name = "LISTAidDataGridViewTextBoxColumn"
        Me.LISTAidDataGridViewTextBoxColumn.ReadOnly = True
        Me.LISTAidDataGridViewTextBoxColumn.Visible = False
        '
        'LISTAnomDataGridViewTextBoxColumn
        '
        Me.LISTAnomDataGridViewTextBoxColumn.DataPropertyName = "LISTA_nom"
        Me.LISTAnomDataGridViewTextBoxColumn.HeaderText = "Lista de Producto"
        Me.LISTAnomDataGridViewTextBoxColumn.Name = "LISTAnomDataGridViewTextBoxColumn"
        Me.LISTAnomDataGridViewTextBoxColumn.ReadOnly = True
        Me.LISTAnomDataGridViewTextBoxColumn.Width = 250
        '
        'LISTAfechaDataGridViewTextBoxColumn
        '
        Me.LISTAfechaDataGridViewTextBoxColumn.DataPropertyName = "LISTA_fecha"
        Me.LISTAfechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.LISTAfechaDataGridViewTextBoxColumn.Name = "LISTAfechaDataGridViewTextBoxColumn"
        Me.LISTAfechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListaBindingSource
        '
        Me.ListaBindingSource.DataMember = "Lista"
        Me.ListaBindingSource.DataSource = Me.Lista_ds
        '
        'Lista_ds
        '
        Me.Lista_ds.DataSetName = "Lista_ds"
        Me.Lista_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LB_LISTA_ERROR
        '
        Me.LB_LISTA_ERROR.AutoSize = True
        Me.LB_LISTA_ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_LISTA_ERROR.ForeColor = System.Drawing.Color.Red
        Me.LB_LISTA_ERROR.Location = New System.Drawing.Point(404, 28)
        Me.LB_LISTA_ERROR.Name = "LB_LISTA_ERROR"
        Me.LB_LISTA_ERROR.Size = New System.Drawing.Size(59, 15)
        Me.LB_LISTA_ERROR.TabIndex = 234
        Me.LB_LISTA_ERROR.Text = "No Existe"
        Me.LB_LISTA_ERROR.Visible = False
        '
        'IM_LISTA_ERROR
        '
        Me.IM_LISTA_ERROR.Image = CType(resources.GetObject("IM_LISTA_ERROR.Image"), System.Drawing.Image)
        Me.IM_LISTA_ERROR.Location = New System.Drawing.Point(383, 26)
        Me.IM_LISTA_ERROR.Name = "IM_LISTA_ERROR"
        Me.IM_LISTA_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_LISTA_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_LISTA_ERROR.TabIndex = 233
        Me.IM_LISTA_ERROR.TabStop = False
        Me.IM_LISTA_ERROR.Visible = False
        '
        'BO_LISTA_buscar
        '
        Me.BO_LISTA_buscar.Image = CType(resources.GetObject("BO_LISTA_buscar.Image"), System.Drawing.Image)
        Me.BO_LISTA_buscar.Location = New System.Drawing.Point(350, 22)
        Me.BO_LISTA_buscar.Name = "BO_LISTA_buscar"
        Me.BO_LISTA_buscar.Size = New System.Drawing.Size(30, 30)
        Me.BO_LISTA_buscar.TabIndex = 102
        Me.BO_LISTA_buscar.UseVisualStyleBackColor = True
        '
        'TX_nom
        '
        Me.TX_nom.Location = New System.Drawing.Point(150, 26)
        Me.TX_nom.Name = "TX_nom"
        Me.TX_nom.Size = New System.Drawing.Size(194, 20)
        Me.TX_nom.TabIndex = 100
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(88, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Nombre"
        '
        'BO_LISTA_cargar
        '
        Me.BO_LISTA_cargar.Image = CType(resources.GetObject("BO_LISTA_cargar.Image"), System.Drawing.Image)
        Me.BO_LISTA_cargar.Location = New System.Drawing.Point(667, 357)
        Me.BO_LISTA_cargar.Name = "BO_LISTA_cargar"
        Me.BO_LISTA_cargar.Size = New System.Drawing.Size(40, 40)
        Me.BO_LISTA_cargar.TabIndex = 232
        Me.ToolTip1.SetToolTip(Me.BO_LISTA_cargar, "Ir a Modificar")
        Me.BO_LISTA_cargar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GP_LISTA_datos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 466)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Lista: Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GP_LISTA_datos
        '
        Me.GP_LISTA_datos.Controls.Add(Me.GroupBox2)
        Me.GP_LISTA_datos.Controls.Add(Me.GroupBox1)
        Me.GP_LISTA_datos.Controls.Add(Me.TX_LISTA_nom)
        Me.GP_LISTA_datos.Controls.Add(Me.Label11)
        Me.GP_LISTA_datos.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_LISTA_datos.Location = New System.Drawing.Point(28, 13)
        Me.GP_LISTA_datos.Name = "GP_LISTA_datos"
        Me.GP_LISTA_datos.Size = New System.Drawing.Size(802, 260)
        Me.GP_LISTA_datos.TabIndex = 230
        Me.GP_LISTA_datos.TabStop = False
        Me.GP_LISTA_datos.Text = "Datos de la Lista"
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
        Me.CK_domingo.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.CK_sabado.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.CK_viernes.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.CK_jueves.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.CK_miecoles.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.CK_martes.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.CK_lunes.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.RB_LISTA_DIA_no.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.RB_LISTA_DIA_si.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(315, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "Hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(17, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
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
        Me.RB_LISTA_VIG_no.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.RB_LISTA_VIG_si.ForeColor = System.Drawing.Color.DarkSlateGray
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
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(47, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 232
        Me.Label11.Text = "Nombre de Lista"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.Button1)
        Me.TabPage9.Controls.Add(Me.GP_LISTA_producto2)
        Me.TabPage9.Controls.Add(Me.GP_LISTA_productos)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(858, 466)
        Me.TabPage9.TabIndex = 5
        Me.TabPage9.Text = "Lista: Productos"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(691, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 233
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GP_LISTA_producto2
        '
        Me.GP_LISTA_producto2.Controls.Add(Me.DG_ListaProducto)
        Me.GP_LISTA_producto2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_LISTA_producto2.Location = New System.Drawing.Point(164, 308)
        Me.GP_LISTA_producto2.Name = "GP_LISTA_producto2"
        Me.GP_LISTA_producto2.Size = New System.Drawing.Size(521, 145)
        Me.GP_LISTA_producto2.TabIndex = 232
        Me.GP_LISTA_producto2.TabStop = False
        Me.GP_LISTA_producto2.Text = "Productos de la Lista"
        '
        'DG_ListaProducto
        '
        Me.DG_ListaProducto.AllowUserToAddRows = False
        Me.DG_ListaProducto.AllowUserToDeleteRows = False
        Me.DG_ListaProducto.AutoGenerateColumns = False
        Me.DG_ListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ListaProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODidDataGridViewTextBoxColumn})
        Me.DG_ListaProducto.DataSource = Me.ListaProductoBindingSource
        Me.DG_ListaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_ListaProducto.Location = New System.Drawing.Point(3, 16)
        Me.DG_ListaProducto.Name = "DG_ListaProducto"
        Me.DG_ListaProducto.ReadOnly = True
        Me.DG_ListaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_ListaProducto.Size = New System.Drawing.Size(515, 126)
        Me.DG_ListaProducto.TabIndex = 0
        '
        'PRODidDataGridViewTextBoxColumn
        '
        Me.PRODidDataGridViewTextBoxColumn.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.Name = "PRODidDataGridViewTextBoxColumn"
        Me.PRODidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn.Visible = False
        '
        'ListaProductoBindingSource
        '
        Me.ListaProductoBindingSource.DataMember = "ListaProducto"
        Me.ListaProductoBindingSource.DataSource = Me.Lista_ds
        '
        'GP_LISTA_productos
        '
        Me.GP_LISTA_productos.Controls.Add(Me.LB_ERROR)
        Me.GP_LISTA_productos.Controls.Add(Me.IM_ERROR)
        Me.GP_LISTA_productos.Controls.Add(Me.BO_Cargar)
        Me.GP_LISTA_productos.Controls.Add(Me.GP_Producto)
        Me.GP_LISTA_productos.Controls.Add(Me.BO_descripcion)
        Me.GP_LISTA_productos.Controls.Add(Me.TX_descripcion)
        Me.GP_LISTA_productos.Controls.Add(Me.Label14)
        Me.GP_LISTA_productos.Controls.Add(Me.BO_codbarra)
        Me.GP_LISTA_productos.Controls.Add(Me.TX_codbarra)
        Me.GP_LISTA_productos.Controls.Add(Me.Label35)
        Me.GP_LISTA_productos.Controls.Add(Me.BO_codigo)
        Me.GP_LISTA_productos.Controls.Add(Me.TX_codigo)
        Me.GP_LISTA_productos.Controls.Add(Me.Label38)
        Me.GP_LISTA_productos.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_LISTA_productos.Location = New System.Drawing.Point(29, 10)
        Me.GP_LISTA_productos.Name = "GP_LISTA_productos"
        Me.GP_LISTA_productos.Size = New System.Drawing.Size(796, 292)
        Me.GP_LISTA_productos.TabIndex = 230
        Me.GP_LISTA_productos.TabStop = False
        Me.GP_LISTA_productos.Text = "Buscar Producto"
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
        'BO_Cargar
        '
        Me.BO_Cargar.Image = CType(resources.GetObject("BO_Cargar.Image"), System.Drawing.Image)
        Me.BO_Cargar.Location = New System.Drawing.Point(737, 98)
        Me.BO_Cargar.Name = "BO_Cargar"
        Me.BO_Cargar.Size = New System.Drawing.Size(30, 30)
        Me.BO_Cargar.TabIndex = 232
        Me.BO_Cargar.UseVisualStyleBackColor = True
        '
        'GP_Producto
        '
        Me.GP_Producto.Controls.Add(Me.TX_LISTA_PROD_total)
        Me.GP_Producto.Controls.Add(Me.Label4)
        Me.GP_Producto.Controls.Add(Me.TX_LISTA_PROD_cant)
        Me.GP_Producto.Controls.Add(Me.Label3)
        Me.GP_Producto.Controls.Add(Me.TX_LISTA_PROD_precio)
        Me.GP_Producto.Controls.Add(Me.Label2)
        Me.GP_Producto.Controls.Add(Me.GroupBox7)
        Me.GP_Producto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Producto.Location = New System.Drawing.Point(21, 58)
        Me.GP_Producto.Name = "GP_Producto"
        Me.GP_Producto.Size = New System.Drawing.Size(698, 218)
        Me.GP_Producto.TabIndex = 103
        Me.GP_Producto.TabStop = False
        Me.GP_Producto.Text = "Datos del Producto"
        '
        'TX_LISTA_PROD_total
        '
        Me.TX_LISTA_PROD_total.Enabled = False
        Me.TX_LISTA_PROD_total.Location = New System.Drawing.Point(592, 111)
        Me.TX_LISTA_PROD_total.Name = "TX_LISTA_PROD_total"
        Me.TX_LISTA_PROD_total.Size = New System.Drawing.Size(88, 20)
        Me.TX_LISTA_PROD_total.TabIndex = 100
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
        'TX_LISTA_PROD_cant
        '
        Me.TX_LISTA_PROD_cant.Location = New System.Drawing.Point(592, 78)
        Me.TX_LISTA_PROD_cant.Name = "TX_LISTA_PROD_cant"
        Me.TX_LISTA_PROD_cant.Size = New System.Drawing.Size(88, 20)
        Me.TX_LISTA_PROD_cant.TabIndex = 98
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
        'TX_LISTA_PROD_precio
        '
        Me.TX_LISTA_PROD_precio.Location = New System.Drawing.Point(592, 43)
        Me.TX_LISTA_PROD_precio.Name = "TX_LISTA_PROD_precio"
        Me.TX_LISTA_PROD_precio.Size = New System.Drawing.Size(88, 20)
        Me.TX_LISTA_PROD_precio.TabIndex = 96
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
        Me.GroupBox7.Controls.Add(Me.DG_Producto)
        Me.GroupBox7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox7.Location = New System.Drawing.Point(17, 24)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(483, 180)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Producto"
        '
        'DG_Producto
        '
        Me.DG_Producto.AllowUserToAddRows = False
        Me.DG_Producto.AllowUserToDeleteRows = False
        Me.DG_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Producto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Producto.Location = New System.Drawing.Point(3, 16)
        Me.DG_Producto.Name = "DG_Producto"
        Me.DG_Producto.ReadOnly = True
        Me.DG_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Producto.Size = New System.Drawing.Size(477, 161)
        Me.DG_Producto.TabIndex = 0
        '
        'BO_descripcion
        '
        Me.BO_descripcion.Image = CType(resources.GetObject("BO_descripcion.Image"), System.Drawing.Image)
        Me.BO_descripcion.Location = New System.Drawing.Point(661, 21)
        Me.BO_descripcion.Name = "BO_descripcion"
        Me.BO_descripcion.Size = New System.Drawing.Size(30, 30)
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
        Me.BO_codbarra.Size = New System.Drawing.Size(30, 30)
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
        Me.BO_codigo.Size = New System.Drawing.Size(30, 30)
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
        Me.BO_guardar.Location = New System.Drawing.Point(834, 506)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(40, 40)
        Me.BO_guardar.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Guardar")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'BO_limpiar
        '
        Me.BO_limpiar.Image = CType(resources.GetObject("BO_limpiar.Image"), System.Drawing.Image)
        Me.BO_limpiar.Location = New System.Drawing.Point(742, 506)
        Me.BO_limpiar.Name = "BO_limpiar"
        Me.BO_limpiar.Size = New System.Drawing.Size(40, 40)
        Me.BO_limpiar.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.BO_limpiar, "Borrar")
        Me.BO_limpiar.UseVisualStyleBackColor = True
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(788, 506)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Eliminar.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Elimanar")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'Lista_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.BO_guardar)
        Me.Controls.Add(Me.BO_limpiar)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "Lista_modificar"
        Me.Text = "Lista_modificar"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DG_LISTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IM_LISTA_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GP_LISTA_datos.ResumeLayout(False)
        Me.GP_LISTA_datos.PerformLayout()
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
        Me.GP_LISTA_producto2.ResumeLayout(False)
        CType(Me.DG_ListaProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_LISTA_productos.ResumeLayout(False)
        Me.GP_LISTA_productos.PerformLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Producto.ResumeLayout(False)
        Me.GP_Producto.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GP_LISTA_datos As System.Windows.Forms.GroupBox
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
    Friend WithEvents GP_LISTA_producto2 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_ListaProducto As System.Windows.Forms.DataGridView
    Friend WithEvents GP_LISTA_productos As System.Windows.Forms.GroupBox
    Friend WithEvents LB_ERROR As System.Windows.Forms.Label
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents BO_Cargar As System.Windows.Forms.Button
    Friend WithEvents GP_Producto As System.Windows.Forms.GroupBox
    Friend WithEvents TX_LISTA_PROD_total As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TX_LISTA_PROD_cant As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TX_LISTA_PROD_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Producto As System.Windows.Forms.DataGridView
    Friend WithEvents BO_descripcion As System.Windows.Forms.Button
    Friend WithEvents TX_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BO_codbarra As System.Windows.Forms.Button
    Friend WithEvents TX_codbarra As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents BO_codigo As System.Windows.Forms.Button
    Friend WithEvents TX_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_LISTA As System.Windows.Forms.DataGridView
    Friend WithEvents LB_LISTA_ERROR As System.Windows.Forms.Label
    Friend WithEvents IM_LISTA_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents BO_LISTA_buscar As System.Windows.Forms.Button
    Friend WithEvents TX_nom As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BO_LISTA_cargar As System.Windows.Forms.Button
    Friend WithEvents LISTAidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LISTAnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LISTAfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_ds As Aplicacion.Lista_ds
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents BO_limpiar As System.Windows.Forms.Button
    Friend WithEvents PRODidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODdescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LISTAPRODcantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LISTAPRODprecioUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LISTAPRODprecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListaProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
