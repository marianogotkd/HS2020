<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_alta_New
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto_alta_New))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bo_exportar = New System.Windows.Forms.Button()
        Me.Bo_cargar = New System.Windows.Forms.Button()
        Me.Bo_deshacer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Combo_tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ERROR_tx_ptorepo = New System.Windows.Forms.PictureBox()
        Me.lb_tel = New System.Windows.Forms.Label()
        Me.tx_ptorepo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_PrecMay = New System.Windows.Forms.TextBox()
        Me.ERROR_tx_stock = New System.Windows.Forms.PictureBox()
        Me.lb_mail = New System.Windows.Forms.Label()
        Me.tx_stock = New System.Windows.Forms.TextBox()
        Me.Err_PrecMay = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tb_PrecMin = New System.Windows.Forms.TextBox()
        Me.lb_dni = New System.Windows.Forms.Label()
        Me.tx_descripcion = New System.Windows.Forms.TextBox()
        Me.Err_PrecMin = New System.Windows.Forms.PictureBox()
        Me.ERROR_tx_descripcion = New System.Windows.Forms.PictureBox()
        Me.ERROR_tx_unidadmedida = New System.Windows.Forms.PictureBox()
        Me.ERROR_tx_codinterno = New System.Windows.Forms.PictureBox()
        Me.tx_unimedida = New System.Windows.Forms.TextBox()
        Me.Bo_nuevamarca = New System.Windows.Forms.Button()
        Me.cb_marca = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tx_codbarra = New System.Windows.Forms.TextBox()
        Me.tx_codinterno = New System.Windows.Forms.TextBox()
        Me.tx_descrilarga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_fechanac = New System.Windows.Forms.Label()
        Me.lb_ape = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bo_agregarcat = New System.Windows.Forms.Button()
        Me.check_subrubro = New System.Windows.Forms.CheckBox()
        Me.cb_subrubro = New System.Windows.Forms.ComboBox()
        Me.cb_rubro = New System.Windows.Forms.ComboBox()
        Me.check_rubro = New System.Windows.Forms.CheckBox()
        Me.cb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ERROR_tx_categoria = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_Prod_Prov = New System.Windows.Forms.DataGridView()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvProdComfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Producto_ds1 = New Aplicacion.Producto_ds()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_prove = New System.Windows.Forms.Button()
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ERROR_tx_ptorepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err_PrecMay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err_PrecMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_unidadmedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_codinterno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ERROR_tx_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView_Prod_Prov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bo_exportar)
        Me.GroupBox2.Controls.Add(Me.Bo_cargar)
        Me.GroupBox2.Controls.Add(Me.Bo_deshacer)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(929, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(228, 263)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Foto del Producto"
        '
        'Bo_exportar
        '
        Me.Bo_exportar.Image = CType(resources.GetObject("Bo_exportar.Image"), System.Drawing.Image)
        Me.Bo_exportar.Location = New System.Drawing.Point(141, 214)
        Me.Bo_exportar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_exportar.Name = "Bo_exportar"
        Me.Bo_exportar.Size = New System.Drawing.Size(40, 37)
        Me.Bo_exportar.TabIndex = 2
        Me.Bo_exportar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Bo_exportar, "Exportar")
        Me.Bo_exportar.UseVisualStyleBackColor = True
        '
        'Bo_cargar
        '
        Me.Bo_cargar.Image = CType(resources.GetObject("Bo_cargar.Image"), System.Drawing.Image)
        Me.Bo_cargar.Location = New System.Drawing.Point(93, 214)
        Me.Bo_cargar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_cargar.Name = "Bo_cargar"
        Me.Bo_cargar.Size = New System.Drawing.Size(40, 37)
        Me.Bo_cargar.TabIndex = 1
        Me.Bo_cargar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Bo_cargar, "Cargar")
        Me.Bo_cargar.UseVisualStyleBackColor = True
        '
        'Bo_deshacer
        '
        Me.Bo_deshacer.Image = CType(resources.GetObject("Bo_deshacer.Image"), System.Drawing.Image)
        Me.Bo_deshacer.Location = New System.Drawing.Point(45, 214)
        Me.Bo_deshacer.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_deshacer.Name = "Bo_deshacer"
        Me.Bo_deshacer.Size = New System.Drawing.Size(40, 37)
        Me.Bo_deshacer.TabIndex = 0
        Me.Bo_deshacer.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Bo_deshacer, "Deshacer")
        Me.Bo_deshacer.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Aplicacion.My.Resources.Resources.producto
        Me.PictureBox1.Location = New System.Drawing.Point(8, 36)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Combo_tipo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_ptorepo)
        Me.GroupBox1.Controls.Add(Me.lb_tel)
        Me.GroupBox1.Controls.Add(Me.tx_ptorepo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tb_PrecMay)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_stock)
        Me.GroupBox1.Controls.Add(Me.lb_mail)
        Me.GroupBox1.Controls.Add(Me.tx_stock)
        Me.GroupBox1.Controls.Add(Me.Err_PrecMay)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Tb_PrecMin)
        Me.GroupBox1.Controls.Add(Me.lb_dni)
        Me.GroupBox1.Controls.Add(Me.tx_descripcion)
        Me.GroupBox1.Controls.Add(Me.Err_PrecMin)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_descripcion)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_unidadmedida)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_codinterno)
        Me.GroupBox1.Controls.Add(Me.tx_unimedida)
        Me.GroupBox1.Controls.Add(Me.Bo_nuevamarca)
        Me.GroupBox1.Controls.Add(Me.cb_marca)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tx_codbarra)
        Me.GroupBox1.Controls.Add(Me.tx_codinterno)
        Me.GroupBox1.Controls.Add(Me.tx_descrilarga)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lb_fechanac)
        Me.GroupBox1.Controls.Add(Me.lb_ape)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(913, 263)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del producto"
        '
        'Combo_tipo
        '
        Me.Combo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_tipo.FormattingEnabled = True
        Me.Combo_tipo.Items.AddRange(New Object() {"Fraccionable", "No Fraccionable"})
        Me.Combo_tipo.Location = New System.Drawing.Point(62, 76)
        Me.Combo_tipo.Margin = New System.Windows.Forms.Padding(4)
        Me.Combo_tipo.Name = "Combo_tipo"
        Me.Combo_tipo.Size = New System.Drawing.Size(221, 28)
        Me.Combo_tipo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(213, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 314
        Me.Label1.Text = "U. medida"
        '
        'ERROR_tx_ptorepo
        '
        Me.ERROR_tx_ptorepo.Image = CType(resources.GetObject("ERROR_tx_ptorepo.Image"), System.Drawing.Image)
        Me.ERROR_tx_ptorepo.Location = New System.Drawing.Point(773, 181)
        Me.ERROR_tx_ptorepo.Margin = New System.Windows.Forms.Padding(4)
        Me.ERROR_tx_ptorepo.Name = "ERROR_tx_ptorepo"
        Me.ERROR_tx_ptorepo.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_ptorepo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_ptorepo.TabIndex = 296
        Me.ERROR_tx_ptorepo.TabStop = False
        Me.ERROR_tx_ptorepo.Visible = False
        '
        'lb_tel
        '
        Me.lb_tel.AutoSize = True
        Me.lb_tel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_tel.Location = New System.Drawing.Point(481, 181)
        Me.lb_tel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_tel.Name = "lb_tel"
        Me.lb_tel.Size = New System.Drawing.Size(157, 20)
        Me.lb_tel.TabIndex = 278
        Me.lb_tel.Text = "Punto de reposición"
        '
        'tx_ptorepo
        '
        Me.tx_ptorepo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_ptorepo.ForeColor = System.Drawing.Color.Blue
        Me.tx_ptorepo.Location = New System.Drawing.Point(646, 175)
        Me.tx_ptorepo.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_ptorepo.Name = "tx_ptorepo"
        Me.tx_ptorepo.Size = New System.Drawing.Size(119, 26)
        Me.tx_ptorepo.TabIndex = 6
        Me.tx_ptorepo.Text = "0"
        Me.tx_ptorepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(22, 181)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(183, 20)
        Me.Label12.TabIndex = 311
        Me.Label12.Text = "Precio Venta Mayorista"
        '
        'tb_PrecMay
        '
        Me.tb_PrecMay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_PrecMay.ForeColor = System.Drawing.Color.Blue
        Me.tb_PrecMay.Location = New System.Drawing.Point(214, 175)
        Me.tb_PrecMay.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_PrecMay.Name = "tb_PrecMay"
        Me.tb_PrecMay.Size = New System.Drawing.Size(123, 26)
        Me.tb_PrecMay.TabIndex = 5
        Me.tb_PrecMay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ERROR_tx_stock
        '
        Me.ERROR_tx_stock.Image = CType(resources.GetObject("ERROR_tx_stock.Image"), System.Drawing.Image)
        Me.ERROR_tx_stock.Location = New System.Drawing.Point(773, 229)
        Me.ERROR_tx_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.ERROR_tx_stock.Name = "ERROR_tx_stock"
        Me.ERROR_tx_stock.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_stock.TabIndex = 295
        Me.ERROR_tx_stock.TabStop = False
        Me.ERROR_tx_stock.Visible = False
        '
        'lb_mail
        '
        Me.lb_mail.AutoSize = True
        Me.lb_mail.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_mail.Location = New System.Drawing.Point(481, 226)
        Me.lb_mail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_mail.Name = "lb_mail"
        Me.lb_mail.Size = New System.Drawing.Size(99, 20)
        Me.lb_mail.TabIndex = 277
        Me.lb_mail.Text = "Stock inicial"
        Me.lb_mail.Visible = False
        '
        'tx_stock
        '
        Me.tx_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_stock.ForeColor = System.Drawing.Color.Blue
        Me.tx_stock.Location = New System.Drawing.Point(646, 219)
        Me.tx_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_stock.Name = "tx_stock"
        Me.tx_stock.Size = New System.Drawing.Size(119, 26)
        Me.tx_stock.TabIndex = 8
        Me.tx_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_stock.Visible = False
        '
        'Err_PrecMay
        '
        Me.Err_PrecMay.Image = CType(resources.GetObject("Err_PrecMay.Image"), System.Drawing.Image)
        Me.Err_PrecMay.Location = New System.Drawing.Point(345, 181)
        Me.Err_PrecMay.Margin = New System.Windows.Forms.Padding(4)
        Me.Err_PrecMay.Name = "Err_PrecMay"
        Me.Err_PrecMay.Size = New System.Drawing.Size(16, 16)
        Me.Err_PrecMay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Err_PrecMay.TabIndex = 312
        Me.Err_PrecMay.TabStop = False
        Me.Err_PrecMay.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(22, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 20)
        Me.Label9.TabIndex = 308
        Me.Label9.Text = "Precio Venta Minorista"
        '
        'Tb_PrecMin
        '
        Me.Tb_PrecMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_PrecMin.ForeColor = System.Drawing.Color.Blue
        Me.Tb_PrecMin.Location = New System.Drawing.Point(214, 125)
        Me.Tb_PrecMin.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_PrecMin.Name = "Tb_PrecMin"
        Me.Tb_PrecMin.Size = New System.Drawing.Size(123, 26)
        Me.Tb_PrecMin.TabIndex = 3
        Me.Tb_PrecMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_dni
        '
        Me.lb_dni.AutoSize = True
        Me.lb_dni.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_dni.Location = New System.Drawing.Point(481, 37)
        Me.lb_dni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_dni.Name = "lb_dni"
        Me.lb_dni.Size = New System.Drawing.Size(99, 20)
        Me.lb_dni.TabIndex = 250
        Me.lb_dni.Text = "Descripcion"
        '
        'tx_descripcion
        '
        Me.tx_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_descripcion.ForeColor = System.Drawing.Color.Blue
        Me.tx_descripcion.Location = New System.Drawing.Point(646, 34)
        Me.tx_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_descripcion.Name = "tx_descripcion"
        Me.tx_descripcion.Size = New System.Drawing.Size(235, 26)
        Me.tx_descripcion.TabIndex = 0
        Me.tx_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Err_PrecMin
        '
        Me.Err_PrecMin.Image = CType(resources.GetObject("Err_PrecMin.Image"), System.Drawing.Image)
        Me.Err_PrecMin.Location = New System.Drawing.Point(345, 131)
        Me.Err_PrecMin.Margin = New System.Windows.Forms.Padding(4)
        Me.Err_PrecMin.Name = "Err_PrecMin"
        Me.Err_PrecMin.Size = New System.Drawing.Size(16, 16)
        Me.Err_PrecMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Err_PrecMin.TabIndex = 309
        Me.Err_PrecMin.TabStop = False
        Me.Err_PrecMin.Visible = False
        '
        'ERROR_tx_descripcion
        '
        Me.ERROR_tx_descripcion.Image = CType(resources.GetObject("ERROR_tx_descripcion.Image"), System.Drawing.Image)
        Me.ERROR_tx_descripcion.Location = New System.Drawing.Point(889, 41)
        Me.ERROR_tx_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.ERROR_tx_descripcion.Name = "ERROR_tx_descripcion"
        Me.ERROR_tx_descripcion.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_descripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_descripcion.TabIndex = 305
        Me.ERROR_tx_descripcion.TabStop = False
        Me.ERROR_tx_descripcion.Visible = False
        '
        'ERROR_tx_unidadmedida
        '
        Me.ERROR_tx_unidadmedida.Image = CType(resources.GetObject("ERROR_tx_unidadmedida.Image"), System.Drawing.Image)
        Me.ERROR_tx_unidadmedida.Location = New System.Drawing.Point(345, 82)
        Me.ERROR_tx_unidadmedida.Margin = New System.Windows.Forms.Padding(4)
        Me.ERROR_tx_unidadmedida.Name = "ERROR_tx_unidadmedida"
        Me.ERROR_tx_unidadmedida.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_unidadmedida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_unidadmedida.TabIndex = 306
        Me.ERROR_tx_unidadmedida.TabStop = False
        Me.ERROR_tx_unidadmedida.Visible = False
        '
        'ERROR_tx_codinterno
        '
        Me.ERROR_tx_codinterno.Image = CType(resources.GetObject("ERROR_tx_codinterno.Image"), System.Drawing.Image)
        Me.ERROR_tx_codinterno.Location = New System.Drawing.Point(345, 41)
        Me.ERROR_tx_codinterno.Margin = New System.Windows.Forms.Padding(4)
        Me.ERROR_tx_codinterno.Name = "ERROR_tx_codinterno"
        Me.ERROR_tx_codinterno.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_codinterno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_codinterno.TabIndex = 304
        Me.ERROR_tx_codinterno.TabStop = False
        Me.ERROR_tx_codinterno.Visible = False
        '
        'tx_unimedida
        '
        Me.tx_unimedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_unimedida.ForeColor = System.Drawing.Color.Blue
        Me.tx_unimedida.Location = New System.Drawing.Point(291, 76)
        Me.tx_unimedida.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_unimedida.Name = "tx_unimedida"
        Me.tx_unimedida.Size = New System.Drawing.Size(46, 26)
        Me.tx_unimedida.TabIndex = 1
        Me.tx_unimedida.TabStop = False
        Me.tx_unimedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bo_nuevamarca
        '
        Me.Bo_nuevamarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bo_nuevamarca.Image = CType(resources.GetObject("Bo_nuevamarca.Image"), System.Drawing.Image)
        Me.Bo_nuevamarca.Location = New System.Drawing.Point(345, 218)
        Me.Bo_nuevamarca.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_nuevamarca.Name = "Bo_nuevamarca"
        Me.Bo_nuevamarca.Size = New System.Drawing.Size(121, 37)
        Me.Bo_nuevamarca.TabIndex = 12
        Me.Bo_nuevamarca.TabStop = False
        Me.Bo_nuevamarca.Text = "Agregar Marca"
        Me.Bo_nuevamarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_nuevamarca.UseVisualStyleBackColor = True
        '
        'cb_marca
        '
        Me.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_marca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_marca.FormattingEnabled = True
        Me.cb_marca.Location = New System.Drawing.Point(99, 223)
        Me.cb_marca.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(221, 28)
        Me.cb_marca.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(22, 226)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 282
        Me.Label10.Text = "Marca"
        '
        'tx_codbarra
        '
        Me.tx_codbarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_codbarra.ForeColor = System.Drawing.Color.Blue
        Me.tx_codbarra.Location = New System.Drawing.Point(646, 78)
        Me.tx_codbarra.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_codbarra.Name = "tx_codbarra"
        Me.tx_codbarra.Size = New System.Drawing.Size(235, 26)
        Me.tx_codbarra.TabIndex = 2
        Me.tx_codbarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_codinterno
        '
        Me.tx_codinterno.Enabled = False
        Me.tx_codinterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_codinterno.ForeColor = System.Drawing.Color.Blue
        Me.tx_codinterno.Location = New System.Drawing.Point(147, 31)
        Me.tx_codinterno.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_codinterno.Name = "tx_codinterno"
        Me.tx_codinterno.Size = New System.Drawing.Size(190, 26)
        Me.tx_codinterno.TabIndex = 0
        Me.tx_codinterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_descrilarga
        '
        Me.tx_descrilarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_descrilarga.ForeColor = System.Drawing.Color.Blue
        Me.tx_descrilarga.Location = New System.Drawing.Point(646, 125)
        Me.tx_descrilarga.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_descrilarga.Name = "tx_descrilarga"
        Me.tx_descrilarga.Size = New System.Drawing.Size(235, 26)
        Me.tx_descrilarga.TabIndex = 4
        Me.tx_descrilarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(481, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 266
        Me.Label3.Text = "Código de barras"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(22, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Código interno"
        '
        'lb_fechanac
        '
        Me.lb_fechanac.AutoSize = True
        Me.lb_fechanac.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_fechanac.Location = New System.Drawing.Point(22, 84)
        Me.lb_fechanac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_fechanac.Name = "lb_fechanac"
        Me.lb_fechanac.Size = New System.Drawing.Size(46, 20)
        Me.lb_fechanac.TabIndex = 259
        Me.lb_fechanac.Text = "Tipo "
        '
        'lb_ape
        '
        Me.lb_ape.AutoSize = True
        Me.lb_ape.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_ape.Location = New System.Drawing.Point(481, 131)
        Me.lb_ape.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_ape.Name = "lb_ape"
        Me.lb_ape.Size = New System.Drawing.Size(141, 20)
        Me.lb_ape.TabIndex = 12
        Me.lb_ape.Text = "Descripción larga"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Bo_agregarcat)
        Me.GroupBox3.Controls.Add(Me.check_subrubro)
        Me.GroupBox3.Controls.Add(Me.cb_subrubro)
        Me.GroupBox3.Controls.Add(Me.cb_rubro)
        Me.GroupBox3.Controls.Add(Me.check_rubro)
        Me.GroupBox3.Controls.Add(Me.cb_categoria)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.ERROR_tx_categoria)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(8, 275)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1149, 124)
        Me.GroupBox3.TabIndex = 269
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Categoria, Rubro y Subrubro"
        '
        'Bo_agregarcat
        '
        Me.Bo_agregarcat.Image = CType(resources.GetObject("Bo_agregarcat.Image"), System.Drawing.Image)
        Me.Bo_agregarcat.Location = New System.Drawing.Point(115, 74)
        Me.Bo_agregarcat.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_agregarcat.Name = "Bo_agregarcat"
        Me.Bo_agregarcat.Size = New System.Drawing.Size(231, 37)
        Me.Bo_agregarcat.TabIndex = 1
        Me.Bo_agregarcat.TabStop = False
        Me.Bo_agregarcat.Text = "Agregar Categoria"
        Me.Bo_agregarcat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_agregarcat.UseVisualStyleBackColor = True
        Me.Bo_agregarcat.Visible = False
        '
        'check_subrubro
        '
        Me.check_subrubro.AutoSize = True
        Me.check_subrubro.Location = New System.Drawing.Point(803, 86)
        Me.check_subrubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_subrubro.Name = "check_subrubro"
        Me.check_subrubro.Size = New System.Drawing.Size(18, 17)
        Me.check_subrubro.TabIndex = 5
        Me.check_subrubro.UseVisualStyleBackColor = True
        '
        'cb_subrubro
        '
        Me.cb_subrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_subrubro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_subrubro.FormattingEnabled = True
        Me.cb_subrubro.Location = New System.Drawing.Point(563, 81)
        Me.cb_subrubro.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_subrubro.Name = "cb_subrubro"
        Me.cb_subrubro.Size = New System.Drawing.Size(231, 28)
        Me.cb_subrubro.TabIndex = 2
        '
        'cb_rubro
        '
        Me.cb_rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_rubro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_rubro.FormattingEnabled = True
        Me.cb_rubro.Location = New System.Drawing.Point(563, 41)
        Me.cb_rubro.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_rubro.Name = "cb_rubro"
        Me.cb_rubro.Size = New System.Drawing.Size(231, 28)
        Me.cb_rubro.TabIndex = 1
        '
        'check_rubro
        '
        Me.check_rubro.AutoSize = True
        Me.check_rubro.Location = New System.Drawing.Point(803, 49)
        Me.check_rubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_rubro.Name = "check_rubro"
        Me.check_rubro.Size = New System.Drawing.Size(18, 17)
        Me.check_rubro.TabIndex = 3
        Me.check_rubro.UseVisualStyleBackColor = True
        '
        'cb_categoria
        '
        Me.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(115, 36)
        Me.cb_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(231, 28)
        Me.cb_categoria.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(477, 84)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 270
        Me.Label8.Text = "Subrubro"
        '
        'ERROR_tx_categoria
        '
        Me.ERROR_tx_categoria.Image = CType(resources.GetObject("ERROR_tx_categoria.Image"), System.Drawing.Image)
        Me.ERROR_tx_categoria.Location = New System.Drawing.Point(355, 41)
        Me.ERROR_tx_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.ERROR_tx_categoria.Name = "ERROR_tx_categoria"
        Me.ERROR_tx_categoria.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_categoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_categoria.TabIndex = 307
        Me.ERROR_tx_categoria.TabStop = False
        Me.ERROR_tx_categoria.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(481, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 272
        Me.Label7.Text = "Rubro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 271
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(26, 41)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 270
        Me.Label5.Text = "Categoría"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView_Prod_Prov)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(8, 407)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(632, 132)
        Me.GroupBox4.TabIndex = 271
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proveedores asignados al producto:"
        '
        'DataGridView_Prod_Prov
        '
        Me.DataGridView_Prod_Prov.AllowUserToAddRows = False
        Me.DataGridView_Prod_Prov.AllowUserToDeleteRows = False
        Me.DataGridView_Prod_Prov.AllowUserToResizeRows = False
        Me.DataGridView_Prod_Prov.AutoGenerateColumns = False
        Me.DataGridView_Prod_Prov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Prod_Prov.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Prod_Prov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Prod_Prov.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProvidDataGridViewTextBoxColumn, Me.ProvnombreDataGridViewTextBoxColumn, Me.ProdidDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ProvProdComfechaDataGridViewTextBoxColumn})
        Me.DataGridView_Prod_Prov.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView_Prod_Prov.DataSource = Me.ProveedorProductoBindingSource
        Me.DataGridView_Prod_Prov.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Prod_Prov.Location = New System.Drawing.Point(4, 23)
        Me.DataGridView_Prod_Prov.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView_Prod_Prov.MaximumSize = New System.Drawing.Size(616, 99)
        Me.DataGridView_Prod_Prov.MinimumSize = New System.Drawing.Size(616, 99)
        Me.DataGridView_Prod_Prov.MultiSelect = False
        Me.DataGridView_Prod_Prov.Name = "DataGridView_Prod_Prov"
        Me.DataGridView_Prod_Prov.ReadOnly = True
        Me.DataGridView_Prod_Prov.RowHeadersVisible = False
        Me.DataGridView_Prod_Prov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Prod_Prov.Size = New System.Drawing.Size(616, 99)
        Me.DataGridView_Prod_Prov.TabIndex = 272
        Me.DataGridView_Prod_Prov.TabStop = False
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
        Me.ProvnombreDataGridViewTextBoxColumn.DataPropertyName = "Prov_nombre"
        Me.ProvnombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProvnombreDataGridViewTextBoxColumn.Name = "ProvnombreDataGridViewTextBoxColumn"
        Me.ProvnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdidDataGridViewTextBoxColumn
        '
        Me.ProdidDataGridViewTextBoxColumn.DataPropertyName = "Prod_id"
        Me.ProdidDataGridViewTextBoxColumn.HeaderText = "Prod_id"
        Me.ProdidDataGridViewTextBoxColumn.Name = "ProdidDataGridViewTextBoxColumn"
        Me.ProdidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdidDataGridViewTextBoxColumn.Visible = False
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "Prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProddescripcionDataGridViewTextBoxColumn.Visible = False
        '
        'ProvProdComfechaDataGridViewTextBoxColumn
        '
        Me.ProvProdComfechaDataGridViewTextBoxColumn.DataPropertyName = "Prov_Prod_Com_fecha"
        Me.ProvProdComfechaDataGridViewTextBoxColumn.HeaderText = "Fecha de registro"
        Me.ProvProdComfechaDataGridViewTextBoxColumn.Name = "ProvProdComfechaDataGridViewTextBoxColumn"
        Me.ProvProdComfechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProveedorProductoBindingSource
        '
        Me.ProveedorProductoBindingSource.DataMember = "ProveedorProducto"
        Me.ProveedorProductoBindingSource.DataSource = Me.Producto_ds1
        '
        'Producto_ds1
        '
        Me.Producto_ds1.DataSetName = "Producto_ds"
        Me.Producto_ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 65)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 20)
        Me.Label11.TabIndex = 271
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_prove
        '
        Me.btn_prove.Image = Global.Aplicacion.My.Resources.Resources.proveedores
        Me.btn_prove.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_prove.Location = New System.Drawing.Point(663, 416)
        Me.btn_prove.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_prove.Name = "btn_prove"
        Me.btn_prove.Size = New System.Drawing.Size(153, 123)
        Me.btn_prove.TabIndex = 0
        Me.btn_prove.Text = "Cargar Proveedores"
        Me.btn_prove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_prove.UseVisualStyleBackColor = True
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(861, 487)
        Me.Bo_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(139, 52)
        Me.Bo_cancelar.TabIndex = 1
        Me.Bo_cancelar.Text = "Cancelar"
        Me.Bo_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(1008, 486)
        Me.Bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(140, 53)
        Me.Bo_guardar.TabIndex = 2
        Me.Bo_guardar.Text = "Guardar"
        Me.Bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_guardar.UseVisualStyleBackColor = True
        '
        'Producto_alta_New
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1170, 563)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_prove)
        Me.Controls.Add(Me.Bo_cancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Bo_guardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Producto_alta_New"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Producto"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ERROR_tx_ptorepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err_PrecMay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err_PrecMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_unidadmedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_codinterno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ERROR_tx_categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView_Prod_Prov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_ds1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bo_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Bo_exportar As System.Windows.Forms.Button
    Friend WithEvents Bo_cargar As System.Windows.Forms.Button
    Friend WithEvents Bo_deshacer As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ERROR_tx_unidadmedida As System.Windows.Forms.PictureBox
    Friend WithEvents Bo_agregarcat As System.Windows.Forms.Button
    Friend WithEvents ERROR_tx_descripcion As System.Windows.Forms.PictureBox
    Friend WithEvents ERROR_tx_codinterno As System.Windows.Forms.PictureBox
    Friend WithEvents tx_unimedida As System.Windows.Forms.TextBox
    Friend WithEvents Bo_nuevamarca As System.Windows.Forms.Button
    Friend WithEvents cb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tx_codbarra As System.Windows.Forms.TextBox
    Friend WithEvents tx_codinterno As System.Windows.Forms.TextBox
    Friend WithEvents tx_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents tx_descrilarga As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents check_subrubro As System.Windows.Forms.CheckBox
    Friend WithEvents cb_subrubro As System.Windows.Forms.ComboBox
    Friend WithEvents check_rubro As System.Windows.Forms.CheckBox
    Friend WithEvents cb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ERROR_tx_categoria As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_fechanac As System.Windows.Forms.Label
    Friend WithEvents lb_ape As System.Windows.Forms.Label
    Friend WithEvents lb_dni As System.Windows.Forms.Label
    Friend WithEvents Bo_guardar As System.Windows.Forms.Button
    Friend WithEvents ERROR_tx_ptorepo As System.Windows.Forms.PictureBox
    Friend WithEvents lb_tel As System.Windows.Forms.Label
    Friend WithEvents tx_ptorepo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_PrecMay As System.Windows.Forms.TextBox
    Friend WithEvents ERROR_tx_stock As System.Windows.Forms.PictureBox
    Friend WithEvents lb_mail As System.Windows.Forms.Label
    Friend WithEvents tx_stock As System.Windows.Forms.TextBox
    Friend WithEvents Err_PrecMay As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tb_PrecMin As System.Windows.Forms.TextBox
    Friend WithEvents Err_PrecMin As System.Windows.Forms.PictureBox
    Friend WithEvents btn_prove As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_Prod_Prov As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProveedorProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Producto_ds1 As Aplicacion.Producto_ds
    Friend WithEvents cb_rubro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Combo_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents ProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvProdComfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
