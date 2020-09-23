<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Egresos_Ingresos
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Egresos_Ingresos))
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar_seleccion = New System.Windows.Forms.Button()
        Me.BO_agregar = New System.Windows.Forms.Button()
        Me.Label_apertura = New System.Windows.Forms.Label()
        Me.Label_usuario = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DG_caja = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_sucursal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Bo_busqueda = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DT_FECHA_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DT_FECHA_desde = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_si = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CajasoloingresosegresosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Egresos_DS = New Aplicacion.Egresos_DS()
        Me.Categorias_DS = New Aplicacion.Categorias_DS()
        Me.ConsultasoloingresosegresosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAJAdetalle_fechahora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CAJAdetalleidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetallefechahoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovintDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoloingresosegresosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Egresos_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultasoloingresosegresosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1065, 605)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1057, 576)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Caja abierta actualmente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1057, 576)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta registro historico"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_eliminar_seleccion)
        Me.GroupBox1.Controls.Add(Me.BO_agregar)
        Me.GroupBox1.Controls.Add(Me.Label_apertura)
        Me.GroupBox1.Controls.Add(Me.Label_usuario)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label_sucursal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(120, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 561)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'btn_eliminar_seleccion
        '
        Me.btn_eliminar_seleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_seleccion.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_eliminar_seleccion.Location = New System.Drawing.Point(17, 499)
        Me.btn_eliminar_seleccion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar_seleccion.Name = "btn_eliminar_seleccion"
        Me.btn_eliminar_seleccion.Size = New System.Drawing.Size(124, 43)
        Me.btn_eliminar_seleccion.TabIndex = 251
        Me.btn_eliminar_seleccion.Text = "Eliminar"
        Me.btn_eliminar_seleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_eliminar_seleccion, "Eliminar selección")
        Me.btn_eliminar_seleccion.UseVisualStyleBackColor = True
        '
        'BO_agregar
        '
        Me.BO_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_agregar.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_agregar.Location = New System.Drawing.Point(149, 499)
        Me.BO_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_agregar.Name = "BO_agregar"
        Me.BO_agregar.Size = New System.Drawing.Size(124, 43)
        Me.BO_agregar.TabIndex = 250
        Me.BO_agregar.Text = "Agregar"
        Me.BO_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_agregar, "Agregar ingreso/egreso")
        Me.BO_agregar.UseVisualStyleBackColor = True
        '
        'Label_apertura
        '
        Me.Label_apertura.AutoSize = True
        Me.Label_apertura.Location = New System.Drawing.Point(227, 108)
        Me.Label_apertura.Name = "Label_apertura"
        Me.Label_apertura.Size = New System.Drawing.Size(90, 17)
        Me.Label_apertura.TabIndex = 6
        Me.Label_apertura.Text = "00/00/0000"
        '
        'Label_usuario
        '
        Me.Label_usuario.AutoSize = True
        Me.Label_usuario.Location = New System.Drawing.Point(187, 145)
        Me.Label_usuario.Name = "Label_usuario"
        Me.Label_usuario.Size = New System.Drawing.Size(0, 17)
        Me.Label_usuario.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DG_caja)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(820, 315)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de caja actual:"
        '
        'DG_caja
        '
        Me.DG_caja.AllowUserToAddRows = False
        Me.DG_caja.AllowUserToDeleteRows = False
        Me.DG_caja.AllowUserToResizeRows = False
        Me.DG_caja.AutoGenerateColumns = False
        Me.DG_caja.BackgroundColor = System.Drawing.Color.White
        Me.DG_caja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_caja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DG_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_caja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CAJAdetalle_fechahora, Me.CAJAdetalleidDataGridViewTextBoxColumn, Me.CAJAIDDataGridViewTextBoxColumn, Me.CAJAdetalledescripcionDataGridViewTextBoxColumn, Me.CAJAdetalleingresoDataGridViewTextBoxColumn, Me.CAJAdetalleegresoDataGridViewTextBoxColumn, Me.CajaTipoMovintDataGridViewTextBoxColumn, Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn, Me.Column1})
        Me.DG_caja.DataSource = Me.CajasoloingresosegresosBindingSource
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_caja.DefaultCellStyle = DataGridViewCellStyle17
        Me.DG_caja.Location = New System.Drawing.Point(12, 22)
        Me.DG_caja.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_caja.MultiSelect = False
        Me.DG_caja.Name = "DG_caja"
        Me.DG_caja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_caja.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DG_caja.RowHeadersVisible = False
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_caja.RowsDefaultCellStyle = DataGridViewCellStyle19
        Me.DG_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_caja.Size = New System.Drawing.Size(792, 276)
        Me.DG_caja.StandardTab = True
        Me.DG_caja.TabIndex = 241
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de apertura:"
        '
        'Label_sucursal
        '
        Me.Label_sucursal.AutoSize = True
        Me.Label_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_sucursal.ForeColor = System.Drawing.Color.Blue
        Me.Label_sucursal.Location = New System.Drawing.Point(10, 22)
        Me.Label_sucursal.Name = "Label_sucursal"
        Me.Label_sucursal.Size = New System.Drawing.Size(128, 29)
        Me.Label_sucursal.TabIndex = 3
        Me.Label_sucursal.Text = "Sucursal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja (ingresos y egresos)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Responsable:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Bo_busqueda)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(810, 66)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione sucursal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sucursal:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Info
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(91, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(353, 33)
        Me.ComboBox1.TabIndex = 3
        '
        'Bo_busqueda
        '
        Me.Bo_busqueda.Image = CType(resources.GetObject("Bo_busqueda.Image"), System.Drawing.Image)
        Me.Bo_busqueda.Location = New System.Drawing.Point(451, 19)
        Me.Bo_busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_busqueda.Name = "Bo_busqueda"
        Me.Bo_busqueda.Size = New System.Drawing.Size(40, 37)
        Me.Bo_busqueda.TabIndex = 207
        Me.ToolTip1.SetToolTip(Me.Bo_busqueda, "Buscar registros")
        Me.Bo_busqueda.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.DT_FECHA_hasta)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.DT_FECHA_desde)
        Me.GroupBox8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox8.Location = New System.Drawing.Point(6, 109)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(206, 141)
        Me.GroupBox8.TabIndex = 205
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Por Fecha"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(152, 83)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 206
        Me.ToolTip1.SetToolTip(Me.Button1, "Buscar por rango de fechas")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(20, 58)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "Hasta"
        '
        'DT_FECHA_hasta
        '
        Me.DT_FECHA_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA_hasta.Location = New System.Drawing.Point(80, 53)
        Me.DT_FECHA_hasta.Margin = New System.Windows.Forms.Padding(4)
        Me.DT_FECHA_hasta.Name = "DT_FECHA_hasta"
        Me.DT_FECHA_hasta.Size = New System.Drawing.Size(112, 22)
        Me.DT_FECHA_hasta.TabIndex = 182
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(20, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 181
        Me.Label9.Text = "Desde"
        '
        'DT_FECHA_desde
        '
        Me.DT_FECHA_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA_desde.Location = New System.Drawing.Point(80, 23)
        Me.DT_FECHA_desde.Margin = New System.Windows.Forms.Padding(4)
        Me.DT_FECHA_desde.Name = "DT_FECHA_desde"
        Me.DT_FECHA_desde.Size = New System.Drawing.Size(113, 22)
        Me.DT_FECHA_desde.TabIndex = 180
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton_si)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 81)
        Me.GroupBox4.TabIndex = 206
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Aplicar Filtro:"
        '
        'RadioButton_si
        '
        Me.RadioButton_si.AutoSize = True
        Me.RadioButton_si.Location = New System.Drawing.Point(25, 21)
        Me.RadioButton_si.Name = "RadioButton_si"
        Me.RadioButton_si.Size = New System.Drawing.Size(43, 21)
        Me.RadioButton_si.TabIndex = 0
        Me.RadioButton_si.Text = "Si"
        Me.RadioButton_si.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(25, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(49, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Location = New System.Drawing.Point(836, 99)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(217, 259)
        Me.GroupBox5.TabIndex = 207
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridView1)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(20, 88)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(810, 470)
        Me.GroupBox6.TabIndex = 208
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Registro de Ingresos / Egresos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CAJAdetalleidDataGridViewTextBoxColumn1, Me.CAJAdetallefechahoraDataGridViewTextBoxColumn, Me.CAJAIDDataGridViewTextBoxColumn1, Me.CAJAdetalledescripcionDataGridViewTextBoxColumn1, Me.CAJAdetalleingresoDataGridViewTextBoxColumn1, Me.CAJAdetalleegresoDataGridViewTextBoxColumn1, Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn1, Me.CajaTipoMovintDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.ConsultasoloingresosegresosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 37)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(792, 426)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 242
        '
        'CajasoloingresosegresosBindingSource
        '
        Me.CajasoloingresosegresosBindingSource.DataMember = "Caja_solo_ingresos_egresos"
        Me.CajasoloingresosegresosBindingSource.DataSource = Me.Egresos_DS
        '
        'Egresos_DS
        '
        Me.Egresos_DS.DataSetName = "Egresos_DS"
        Me.Egresos_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Categorias_DS
        '
        Me.Categorias_DS.DataSetName = "Categorias_DS"
        Me.Categorias_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsultasoloingresosegresosBindingSource
        '
        Me.ConsultasoloingresosegresosBindingSource.DataMember = "Consulta_solo_ingresos_egresos"
        Me.ConsultasoloingresosegresosBindingSource.DataSource = Me.Egresos_DS
        '
        'CAJAdetalle_fechahora
        '
        Me.CAJAdetalle_fechahora.DataPropertyName = "CAJAdetalle_fechahora"
        Me.CAJAdetalle_fechahora.HeaderText = "Fecha y hora"
        Me.CAJAdetalle_fechahora.Name = "CAJAdetalle_fechahora"
        Me.CAJAdetalle_fechahora.Width = 120
        '
        'CAJAdetalleidDataGridViewTextBoxColumn
        '
        Me.CAJAdetalleidDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_id"
        Me.CAJAdetalleidDataGridViewTextBoxColumn.HeaderText = "CAJAdetalle_id"
        Me.CAJAdetalleidDataGridViewTextBoxColumn.Name = "CAJAdetalleidDataGridViewTextBoxColumn"
        Me.CAJAdetalleidDataGridViewTextBoxColumn.Visible = False
        '
        'CAJAIDDataGridViewTextBoxColumn
        '
        Me.CAJAIDDataGridViewTextBoxColumn.DataPropertyName = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.HeaderText = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.Name = "CAJAIDDataGridViewTextBoxColumn"
        Me.CAJAIDDataGridViewTextBoxColumn.Visible = False
        '
        'CAJAdetalledescripcionDataGridViewTextBoxColumn
        '
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_descripcion"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.Name = "CAJAdetalledescripcionDataGridViewTextBoxColumn"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.Width = 270
        '
        'CAJAdetalleingresoDataGridViewTextBoxColumn
        '
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_ingreso"
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn.HeaderText = "ingresos"
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn.Name = "CAJAdetalleingresoDataGridViewTextBoxColumn"
        '
        'CAJAdetalleegresoDataGridViewTextBoxColumn
        '
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_egreso"
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn.HeaderText = "egresos"
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn.Name = "CAJAdetalleegresoDataGridViewTextBoxColumn"
        '
        'CajaTipoMovintDataGridViewTextBoxColumn
        '
        Me.CajaTipoMovintDataGridViewTextBoxColumn.DataPropertyName = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.HeaderText = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Name = "CajaTipoMovintDataGridViewTextBoxColumn"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Visible = False
        '
        'CajaTipoMovdescripcionDataGridViewTextBoxColumn
        '
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.DataPropertyName = "CajaTipoMov_descripcion"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.HeaderText = "Tipo de movimiento"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.Name = "CajaTipoMovdescripcionDataGridViewTextBoxColumn"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.Width = 150
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        '
        'CAJAdetalleidDataGridViewTextBoxColumn1
        '
        Me.CAJAdetalleidDataGridViewTextBoxColumn1.DataPropertyName = "CAJAdetalle_id"
        Me.CAJAdetalleidDataGridViewTextBoxColumn1.HeaderText = "CAJAdetalle_id"
        Me.CAJAdetalleidDataGridViewTextBoxColumn1.Name = "CAJAdetalleidDataGridViewTextBoxColumn1"
        Me.CAJAdetalleidDataGridViewTextBoxColumn1.Visible = False
        '
        'CAJAdetallefechahoraDataGridViewTextBoxColumn
        '
        Me.CAJAdetallefechahoraDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_fechahora"
        Me.CAJAdetallefechahoraDataGridViewTextBoxColumn.HeaderText = "Fecha y Hora"
        Me.CAJAdetallefechahoraDataGridViewTextBoxColumn.Name = "CAJAdetallefechahoraDataGridViewTextBoxColumn"
        Me.CAJAdetallefechahoraDataGridViewTextBoxColumn.Width = 125
        '
        'CAJAIDDataGridViewTextBoxColumn1
        '
        Me.CAJAIDDataGridViewTextBoxColumn1.DataPropertyName = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn1.HeaderText = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn1.Name = "CAJAIDDataGridViewTextBoxColumn1"
        Me.CAJAIDDataGridViewTextBoxColumn1.Visible = False
        '
        'CAJAdetalledescripcionDataGridViewTextBoxColumn1
        '
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn1.DataPropertyName = "CAJAdetalle_descripcion"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn1.Name = "CAJAdetalledescripcionDataGridViewTextBoxColumn1"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn1.Width = 280
        '
        'CAJAdetalleingresoDataGridViewTextBoxColumn1
        '
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn1.DataPropertyName = "CAJAdetalle_ingreso"
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn1.HeaderText = "Ingresos"
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn1.Name = "CAJAdetalleingresoDataGridViewTextBoxColumn1"
        '
        'CAJAdetalleegresoDataGridViewTextBoxColumn1
        '
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn1.DataPropertyName = "CAJAdetalle_egreso"
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn1.HeaderText = "Egresos"
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn1.Name = "CAJAdetalleegresoDataGridViewTextBoxColumn1"
        '
        'CajaTipoMovdescripcionDataGridViewTextBoxColumn1
        '
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn1.DataPropertyName = "CajaTipoMov_descripcion"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn1.HeaderText = "Tipo de movimiento"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn1.Name = "CajaTipoMovdescripcionDataGridViewTextBoxColumn1"
        '
        'CajaTipoMovintDataGridViewTextBoxColumn1
        '
        Me.CajaTipoMovintDataGridViewTextBoxColumn1.DataPropertyName = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn1.HeaderText = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn1.Name = "CajaTipoMovintDataGridViewTextBoxColumn1"
        Me.CajaTipoMovintDataGridViewTextBoxColumn1.Visible = False
        '
        'Egresos_Ingresos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1079, 622)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Egresos_Ingresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Ingresos/Egresos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoloingresosegresosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Egresos_DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultasoloingresosegresosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CajasoloingresosegresosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Egresos_DS As Aplicacion.Egresos_DS
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar_seleccion As System.Windows.Forms.Button
    Friend WithEvents BO_agregar As System.Windows.Forms.Button
    Friend WithEvents Label_apertura As System.Windows.Forms.Label
    Friend WithEvents Label_usuario As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_caja As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_sucursal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Bo_busqueda As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DT_FECHA_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DT_FECHA_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_si As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CAJAdetalle_fechahora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalledescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleingresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleegresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovintDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovdescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ConsultasoloingresosegresosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Categorias_DS As Aplicacion.Categorias_DS
    Friend WithEvents CAJAdetalleidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetallefechahoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalledescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleingresoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleegresoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovdescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovintDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
