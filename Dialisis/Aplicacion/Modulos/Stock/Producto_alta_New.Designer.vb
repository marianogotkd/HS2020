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
        Me.btn_prove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_lote = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.tx_codbarra = New System.Windows.Forms.TextBox()
        Me.tx_codinterno = New System.Windows.Forms.TextBox()
        Me.tx_descrilarga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_ape = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RB_filtro_si = New System.Windows.Forms.RadioButton()
        Me.RB_filtro_no = New System.Windows.Forms.RadioButton()
        Me.lb_fechanac = New System.Windows.Forms.Label()
        Me.Combo_unidmedida = New System.Windows.Forms.ComboBox()
        Me.Combo_tipo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ERROR_tx_ptorepo = New System.Windows.Forms.PictureBox()
        Me.txt_contenido = New System.Windows.Forms.TextBox()
        Me.tx_ptorepo = New System.Windows.Forms.TextBox()
        Me.lb_tel = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bo_codbarra = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView_Prod_Prov = New System.Windows.Forms.DataGridView()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvProdComfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Producto_ds1 = New Aplicacion.Producto_ds()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Bo_nuevamarca = New System.Windows.Forms.Button()
        Me.cb_marca = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
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
        Me.Bo_agregarcat = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ERROR_tx_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err_PrecMay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err_PrecMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_unidadmedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_codinterno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ERROR_tx_ptorepo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Prod_Prov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ERROR_tx_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bo_exportar)
        Me.GroupBox2.Controls.Add(Me.Bo_cargar)
        Me.GroupBox2.Controls.Add(Me.Bo_deshacer)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(630, 22)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(228, 263)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Foto del Producto"
        Me.GroupBox2.Visible = False
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
        'btn_prove
        '
        Me.btn_prove.Image = Global.Aplicacion.My.Resources.Resources.proveedores
        Me.btn_prove.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_prove.Location = New System.Drawing.Point(894, 107)
        Me.btn_prove.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_prove.Name = "btn_prove"
        Me.btn_prove.Size = New System.Drawing.Size(141, 45)
        Me.btn_prove.TabIndex = 0
        Me.btn_prove.Text = "Cargar Proveedores"
        Me.btn_prove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_prove.UseVisualStyleBackColor = True
        Me.btn_prove.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox_lote)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
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
        Me.GroupBox1.Controls.Add(Me.tx_codbarra)
        Me.GroupBox1.Controls.Add(Me.tx_codinterno)
        Me.GroupBox1.Controls.Add(Me.tx_descrilarga)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lb_ape)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(621, 291)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos del producto"
        '
        'CheckBox_lote
        '
        Me.CheckBox_lote.AutoCheck = False
        Me.CheckBox_lote.AutoSize = True
        Me.CheckBox_lote.Checked = True
        Me.CheckBox_lote.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_lote.Location = New System.Drawing.Point(298, 4)
        Me.CheckBox_lote.Name = "CheckBox_lote"
        Me.CheckBox_lote.Size = New System.Drawing.Size(39, 20)
        Me.CheckBox_lote.TabIndex = 0
        Me.CheckBox_lote.Text = "Si"
        Me.ToolTip1.SetToolTip(Me.CheckBox_lote, "Podrá colocar el código manualmente")
        Me.CheckBox_lote.UseVisualStyleBackColor = True
        Me.CheckBox_lote.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(179, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 315
        Me.Label4.Text = "Lote manual:"
        Me.Label4.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(214, 338)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 314
        Me.Label1.Text = "U. medida"
        Me.Label1.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(23, 419)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 16)
        Me.Label12.TabIndex = 311
        Me.Label12.Text = "Precio Venta Mayorista"
        Me.Label12.Visible = False
        '
        'tb_PrecMay
        '
        Me.tb_PrecMay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_PrecMay.ForeColor = System.Drawing.Color.Blue
        Me.tb_PrecMay.Location = New System.Drawing.Point(215, 413)
        Me.tb_PrecMay.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_PrecMay.Name = "tb_PrecMay"
        Me.tb_PrecMay.Size = New System.Drawing.Size(123, 22)
        Me.tb_PrecMay.TabIndex = 5
        Me.tb_PrecMay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_PrecMay.Visible = False
        '
        'ERROR_tx_stock
        '
        Me.ERROR_tx_stock.Image = CType(resources.GetObject("ERROR_tx_stock.Image"), System.Drawing.Image)
        Me.ERROR_tx_stock.Location = New System.Drawing.Point(692, 366)
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
        Me.lb_mail.Location = New System.Drawing.Point(400, 363)
        Me.lb_mail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_mail.Name = "lb_mail"
        Me.lb_mail.Size = New System.Drawing.Size(79, 16)
        Me.lb_mail.TabIndex = 277
        Me.lb_mail.Text = "Stock inicial"
        Me.lb_mail.Visible = False
        '
        'tx_stock
        '
        Me.tx_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_stock.ForeColor = System.Drawing.Color.Blue
        Me.tx_stock.Location = New System.Drawing.Point(565, 356)
        Me.tx_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_stock.Name = "tx_stock"
        Me.tx_stock.Size = New System.Drawing.Size(119, 22)
        Me.tx_stock.TabIndex = 8
        Me.tx_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_stock.Visible = False
        '
        'Err_PrecMay
        '
        Me.Err_PrecMay.Image = CType(resources.GetObject("Err_PrecMay.Image"), System.Drawing.Image)
        Me.Err_PrecMay.Location = New System.Drawing.Point(346, 419)
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
        Me.Label9.Location = New System.Drawing.Point(23, 369)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 16)
        Me.Label9.TabIndex = 308
        Me.Label9.Text = "Precio Venta Minorista"
        Me.Label9.Visible = False
        '
        'Tb_PrecMin
        '
        Me.Tb_PrecMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_PrecMin.ForeColor = System.Drawing.Color.Blue
        Me.Tb_PrecMin.Location = New System.Drawing.Point(215, 363)
        Me.Tb_PrecMin.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_PrecMin.Name = "Tb_PrecMin"
        Me.Tb_PrecMin.Size = New System.Drawing.Size(123, 22)
        Me.Tb_PrecMin.TabIndex = 3
        Me.Tb_PrecMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tb_PrecMin.Visible = False
        '
        'lb_dni
        '
        Me.lb_dni.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lb_dni.AutoSize = True
        Me.lb_dni.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_dni.Location = New System.Drawing.Point(25, 109)
        Me.lb_dni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_dni.Name = "lb_dni"
        Me.lb_dni.Size = New System.Drawing.Size(80, 16)
        Me.lb_dni.TabIndex = 250
        Me.lb_dni.Text = "Descripcion"
        '
        'tx_descripcion
        '
        Me.tx_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tx_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_descripcion.ForeColor = System.Drawing.Color.Blue
        Me.tx_descripcion.Location = New System.Drawing.Point(163, 103)
        Me.tx_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_descripcion.Name = "tx_descripcion"
        Me.tx_descripcion.Size = New System.Drawing.Size(402, 22)
        Me.tx_descripcion.TabIndex = 1
        Me.tx_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tx_descripcion, "Ingrese descripción del producto")
        '
        'Err_PrecMin
        '
        Me.Err_PrecMin.Image = CType(resources.GetObject("Err_PrecMin.Image"), System.Drawing.Image)
        Me.Err_PrecMin.Location = New System.Drawing.Point(346, 369)
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
        Me.ERROR_tx_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ERROR_tx_descripcion.Image = CType(resources.GetObject("ERROR_tx_descripcion.Image"), System.Drawing.Image)
        Me.ERROR_tx_descripcion.Location = New System.Drawing.Point(575, 109)
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
        Me.ERROR_tx_unidadmedida.Location = New System.Drawing.Point(346, 336)
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
        Me.ERROR_tx_codinterno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ERROR_tx_codinterno.Image = CType(resources.GetObject("ERROR_tx_codinterno.Image"), System.Drawing.Image)
        Me.ERROR_tx_codinterno.Location = New System.Drawing.Point(575, 51)
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
        Me.tx_unimedida.Location = New System.Drawing.Point(292, 330)
        Me.tx_unimedida.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_unimedida.Name = "tx_unimedida"
        Me.tx_unimedida.Size = New System.Drawing.Size(46, 22)
        Me.tx_unimedida.TabIndex = 1
        Me.tx_unimedida.TabStop = False
        Me.tx_unimedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_unimedida.Visible = False
        '
        'tx_codbarra
        '
        Me.tx_codbarra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tx_codbarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_codbarra.ForeColor = System.Drawing.Color.Blue
        Me.tx_codbarra.Location = New System.Drawing.Point(163, 162)
        Me.tx_codbarra.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_codbarra.Name = "tx_codbarra"
        Me.tx_codbarra.Size = New System.Drawing.Size(402, 22)
        Me.tx_codbarra.TabIndex = 2
        Me.tx_codbarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tx_codbarra, "Ingrese un código que le facilitará la busqueda")
        '
        'tx_codinterno
        '
        Me.tx_codinterno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tx_codinterno.Enabled = False
        Me.tx_codinterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_codinterno.ForeColor = System.Drawing.Color.Blue
        Me.tx_codinterno.Location = New System.Drawing.Point(163, 48)
        Me.tx_codinterno.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_codinterno.Name = "tx_codinterno"
        Me.tx_codinterno.Size = New System.Drawing.Size(402, 22)
        Me.tx_codinterno.TabIndex = 0
        Me.tx_codinterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_descrilarga
        '
        Me.tx_descrilarga.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tx_descrilarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_descrilarga.ForeColor = System.Drawing.Color.Blue
        Me.tx_descrilarga.Location = New System.Drawing.Point(163, 221)
        Me.tx_descrilarga.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_descrilarga.Name = "tx_descrilarga"
        Me.tx_descrilarga.Size = New System.Drawing.Size(402, 22)
        Me.tx_descrilarga.TabIndex = 3
        Me.tx_descrilarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(22, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 266
        Me.Label3.Text = "Código de barras:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(22, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Código interno:"
        '
        'lb_ape
        '
        Me.lb_ape.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lb_ape.AutoSize = True
        Me.lb_ape.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_ape.Location = New System.Drawing.Point(23, 224)
        Me.lb_ape.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_ape.Name = "lb_ape"
        Me.lb_ape.Size = New System.Drawing.Size(99, 16)
        Me.lb_ape.TabIndex = 12
        Me.lb_ape.Text = "Descrip. Larga:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.lb_fechanac)
        Me.GroupBox5.Controls.Add(Me.Combo_unidmedida)
        Me.GroupBox5.Controls.Add(Me.Combo_tipo)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.ERROR_tx_ptorepo)
        Me.GroupBox5.Controls.Add(Me.txt_contenido)
        Me.GroupBox5.Controls.Add(Me.tx_ptorepo)
        Me.GroupBox5.Controls.Add(Me.lb_tel)
        Me.GroupBox5.Location = New System.Drawing.Point(636, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(479, 291)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Configure Atributos del producto"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RB_filtro_si)
        Me.GroupBox6.Controls.Add(Me.RB_filtro_no)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(303, 61)
        Me.GroupBox6.TabIndex = 319
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo de producto:"
        '
        'RB_filtro_si
        '
        Me.RB_filtro_si.AutoSize = True
        Me.RB_filtro_si.Location = New System.Drawing.Point(159, 30)
        Me.RB_filtro_si.Name = "RB_filtro_si"
        Me.RB_filtro_si.Size = New System.Drawing.Size(55, 20)
        Me.RB_filtro_si.TabIndex = 1
        Me.RB_filtro_si.Text = "Filtro"
        Me.RB_filtro_si.UseVisualStyleBackColor = True
        '
        'RB_filtro_no
        '
        Me.RB_filtro_no.AutoSize = True
        Me.RB_filtro_no.Checked = True
        Me.RB_filtro_no.Location = New System.Drawing.Point(11, 26)
        Me.RB_filtro_no.Name = "RB_filtro_no"
        Me.RB_filtro_no.Size = New System.Drawing.Size(74, 20)
        Me.RB_filtro_no.TabIndex = 0
        Me.RB_filtro_no.TabStop = True
        Me.RB_filtro_no.Text = "Regular"
        Me.RB_filtro_no.UseVisualStyleBackColor = True
        '
        'lb_fechanac
        '
        Me.lb_fechanac.AutoSize = True
        Me.lb_fechanac.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_fechanac.Location = New System.Drawing.Point(14, 157)
        Me.lb_fechanac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_fechanac.Name = "lb_fechanac"
        Me.lb_fechanac.Size = New System.Drawing.Size(102, 16)
        Me.lb_fechanac.TabIndex = 259
        Me.lb_fechanac.Text = "Tipo de unidad:"
        '
        'Combo_unidmedida
        '
        Me.Combo_unidmedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_unidmedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_unidmedida.FormattingEnabled = True
        Me.Combo_unidmedida.Location = New System.Drawing.Point(165, 242)
        Me.Combo_unidmedida.Margin = New System.Windows.Forms.Padding(4)
        Me.Combo_unidmedida.Name = "Combo_unidmedida"
        Me.Combo_unidmedida.Size = New System.Drawing.Size(145, 24)
        Me.Combo_unidmedida.TabIndex = 3
        '
        'Combo_tipo
        '
        Me.Combo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_tipo.FormattingEnabled = True
        Me.Combo_tipo.Items.AddRange(New Object() {"Fraccionable", "No Fraccionable"})
        Me.Combo_tipo.Location = New System.Drawing.Point(165, 157)
        Me.Combo_tipo.Margin = New System.Windows.Forms.Padding(4)
        Me.Combo_tipo.Name = "Combo_tipo"
        Me.Combo_tipo.Size = New System.Drawing.Size(145, 24)
        Me.Combo_tipo.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(14, 250)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 16)
        Me.Label14.TabIndex = 318
        Me.Label14.Text = "Unidad Medida BASE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Location = New System.Drawing.Point(14, 203)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 316
        Me.Label13.Text = "Contenido:"
        '
        'ERROR_tx_ptorepo
        '
        Me.ERROR_tx_ptorepo.Image = CType(resources.GetObject("ERROR_tx_ptorepo.Image"), System.Drawing.Image)
        Me.ERROR_tx_ptorepo.Location = New System.Drawing.Point(317, 103)
        Me.ERROR_tx_ptorepo.Margin = New System.Windows.Forms.Padding(4)
        Me.ERROR_tx_ptorepo.Name = "ERROR_tx_ptorepo"
        Me.ERROR_tx_ptorepo.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_ptorepo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_ptorepo.TabIndex = 296
        Me.ERROR_tx_ptorepo.TabStop = False
        Me.ERROR_tx_ptorepo.Visible = False
        '
        'txt_contenido
        '
        Me.txt_contenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contenido.ForeColor = System.Drawing.Color.Blue
        Me.txt_contenido.Location = New System.Drawing.Point(165, 197)
        Me.txt_contenido.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_contenido.Name = "txt_contenido"
        Me.txt_contenido.Size = New System.Drawing.Size(145, 22)
        Me.txt_contenido.TabIndex = 2
        Me.txt_contenido.Text = "0"
        Me.txt_contenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt_contenido, "Ingrese un nro que le servirá para el control de stock")
        '
        'tx_ptorepo
        '
        Me.tx_ptorepo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_ptorepo.ForeColor = System.Drawing.Color.Blue
        Me.tx_ptorepo.Location = New System.Drawing.Point(165, 100)
        Me.tx_ptorepo.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_ptorepo.Name = "tx_ptorepo"
        Me.tx_ptorepo.Size = New System.Drawing.Size(144, 22)
        Me.tx_ptorepo.TabIndex = 0
        Me.tx_ptorepo.Text = "0"
        Me.tx_ptorepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tx_ptorepo, "Ingrese un nro que le servirá para el control de stock")
        '
        'lb_tel
        '
        Me.lb_tel.AutoSize = True
        Me.lb_tel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lb_tel.Location = New System.Drawing.Point(14, 103)
        Me.lb_tel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_tel.Name = "lb_tel"
        Me.lb_tel.Size = New System.Drawing.Size(116, 16)
        Me.lb_tel.TabIndex = 278
        Me.lb_tel.Text = "Pto de reposición:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Bo_codbarra)
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(635, 302)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(479, 187)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Asignar proveedor:"
        '
        'Bo_codbarra
        '
        Me.Bo_codbarra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bo_codbarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bo_codbarra.Image = CType(resources.GetObject("Bo_codbarra.Image"), System.Drawing.Image)
        Me.Bo_codbarra.Location = New System.Drawing.Point(8, 18)
        Me.Bo_codbarra.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_codbarra.Name = "Bo_codbarra"
        Me.Bo_codbarra.Size = New System.Drawing.Size(463, 43)
        Me.Bo_codbarra.TabIndex = 0
        Me.Bo_codbarra.Text = "Buscar Proveedores"
        Me.Bo_codbarra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bo_codbarra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_codbarra, "Ver proveedores disponibles para asignar")
        Me.Bo_codbarra.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.DataGridView_Prod_Prov)
        Me.Panel1.Location = New System.Drawing.Point(8, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 116)
        Me.Panel1.TabIndex = 273
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
        Me.DataGridView_Prod_Prov.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Prod_Prov.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView_Prod_Prov.MultiSelect = False
        Me.DataGridView_Prod_Prov.Name = "DataGridView_Prod_Prov"
        Me.DataGridView_Prod_Prov.ReadOnly = True
        Me.DataGridView_Prod_Prov.RowHeadersVisible = False
        Me.DataGridView_Prod_Prov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Prod_Prov.Size = New System.Drawing.Size(463, 116)
        Me.DataGridView_Prod_Prov.TabIndex = 0
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
        Me.Label11.Size = New System.Drawing.Size(0, 16)
        Me.Label11.TabIndex = 271
        '
        'Bo_nuevamarca
        '
        Me.Bo_nuevamarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bo_nuevamarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bo_nuevamarca.Image = CType(resources.GetObject("Bo_nuevamarca.Image"), System.Drawing.Image)
        Me.Bo_nuevamarca.Location = New System.Drawing.Point(516, 30)
        Me.Bo_nuevamarca.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_nuevamarca.Name = "Bo_nuevamarca"
        Me.Bo_nuevamarca.Size = New System.Drawing.Size(44, 37)
        Me.Bo_nuevamarca.TabIndex = 12
        Me.Bo_nuevamarca.TabStop = False
        Me.Bo_nuevamarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_nuevamarca, "Agregar marca")
        Me.Bo_nuevamarca.UseVisualStyleBackColor = True
        '
        'cb_marca
        '
        Me.cb_marca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_marca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_marca.FormattingEnabled = True
        Me.cb_marca.Location = New System.Drawing.Point(109, 35)
        Me.cb_marca.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(398, 24)
        Me.cb_marca.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(17, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 282
        Me.Label10.Text = "Marca:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btn_prove)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
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
        Me.GroupBox3.Controls.Add(Me.cb_marca)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Bo_nuevamarca)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(15, 302)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(621, 187)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Indique Marca, Categoria, Rubro y Subrubro"
        '
        'check_subrubro
        '
        Me.check_subrubro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.check_subrubro.AutoSize = True
        Me.check_subrubro.Location = New System.Drawing.Point(516, 161)
        Me.check_subrubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_subrubro.Name = "check_subrubro"
        Me.check_subrubro.Size = New System.Drawing.Size(15, 14)
        Me.check_subrubro.TabIndex = 5
        Me.check_subrubro.UseVisualStyleBackColor = True
        '
        'cb_subrubro
        '
        Me.cb_subrubro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_subrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_subrubro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_subrubro.FormattingEnabled = True
        Me.cb_subrubro.Location = New System.Drawing.Point(109, 156)
        Me.cb_subrubro.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_subrubro.Name = "cb_subrubro"
        Me.cb_subrubro.Size = New System.Drawing.Size(398, 24)
        Me.cb_subrubro.TabIndex = 3
        '
        'cb_rubro
        '
        Me.cb_rubro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_rubro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_rubro.FormattingEnabled = True
        Me.cb_rubro.Location = New System.Drawing.Point(109, 114)
        Me.cb_rubro.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_rubro.Name = "cb_rubro"
        Me.cb_rubro.Size = New System.Drawing.Size(398, 24)
        Me.cb_rubro.TabIndex = 2
        '
        'check_rubro
        '
        Me.check_rubro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.check_rubro.AutoSize = True
        Me.check_rubro.Location = New System.Drawing.Point(516, 122)
        Me.check_rubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_rubro.Name = "check_rubro"
        Me.check_rubro.Size = New System.Drawing.Size(15, 14)
        Me.check_rubro.TabIndex = 3
        Me.check_rubro.UseVisualStyleBackColor = True
        '
        'cb_categoria
        '
        Me.cb_categoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(109, 75)
        Me.cb_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(398, 24)
        Me.cb_categoria.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(16, 159)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 270
        Me.Label8.Text = "Subrubro:"
        '
        'ERROR_tx_categoria
        '
        Me.ERROR_tx_categoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ERROR_tx_categoria.Image = CType(resources.GetObject("ERROR_tx_categoria.Image"), System.Drawing.Image)
        Me.ERROR_tx_categoria.Location = New System.Drawing.Point(516, 80)
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
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(16, 119)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 272
        Me.Label7.Text = "Rubro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 271
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(17, 80)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 270
        Me.Label5.Text = "Categoría:"
        '
        'Bo_agregarcat
        '
        Me.Bo_agregarcat.Image = CType(resources.GetObject("Bo_agregarcat.Image"), System.Drawing.Image)
        Me.Bo_agregarcat.Location = New System.Drawing.Point(63, 485)
        Me.Bo_agregarcat.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_agregarcat.Name = "Bo_agregarcat"
        Me.Bo_agregarcat.Size = New System.Drawing.Size(198, 37)
        Me.Bo_agregarcat.TabIndex = 1
        Me.Bo_agregarcat.TabStop = False
        Me.Bo_agregarcat.Text = "Agregar Categoria"
        Me.Bo_agregarcat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bo_agregarcat.UseVisualStyleBackColor = True
        Me.Bo_agregarcat.Visible = False
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(827, 491)
        Me.Bo_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(139, 52)
        Me.Bo_cancelar.TabIndex = 6
        Me.Bo_cancelar.Text = "Cancelar"
        Me.Bo_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_cancelar, "Cancelar")
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(974, 491)
        Me.Bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(140, 53)
        Me.Bo_guardar.TabIndex = 5
        Me.Bo_guardar.Text = "Guardar"
        Me.Bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Bo_guardar, "Guardar")
        Me.Bo_guardar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Producto_alta_New
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(1128, 556)
        Me.Controls.Add(Me.Bo_agregarcat)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Bo_cancelar)
        Me.Controls.Add(Me.Bo_guardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
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
        CType(Me.ERROR_tx_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err_PrecMay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err_PrecMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_unidadmedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_codinterno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ERROR_tx_ptorepo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView_Prod_Prov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_ds1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ERROR_tx_categoria, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CheckBox_lote As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Bo_codbarra As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Combo_unidmedida As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_contenido As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_filtro_si As System.Windows.Forms.RadioButton
    Friend WithEvents RB_filtro_no As System.Windows.Forms.RadioButton
End Class
