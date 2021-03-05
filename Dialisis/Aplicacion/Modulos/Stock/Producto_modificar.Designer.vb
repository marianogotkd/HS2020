<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_modificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto_modificar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Bo_cancelar = New System.Windows.Forms.Button()
        Me.BO_producto_modificar = New System.Windows.Forms.Button()
        Me.Bo_guardar = New System.Windows.Forms.Button()
        Me.BO_producto_nuevo = New System.Windows.Forms.Button()
        Me.btn_Anular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.check_proveedor = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.check_rubro = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.check_categoria = New System.Windows.Forms.CheckBox()
        Me.cb_proveedor = New System.Windows.Forms.ComboBox()
        Me.cb_categoria = New System.Windows.Forms.ComboBox()
        Me.cb_subrubro = New System.Windows.Forms.ComboBox()
        Me.lb_proveedor = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.check_marca = New System.Windows.Forms.CheckBox()
        Me.cb_rubro = New System.Windows.Forms.ComboBox()
        Me.check_subrubro = New System.Windows.Forms.CheckBox()
        Me.cb_marca = New System.Windows.Forms.ComboBox()
        Me.Categoria = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tx_Buscqueda = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_origen = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_Producto = New System.Windows.Forms.DataGridView()
        Me.prod_codinterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdxSuc_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_ptorepo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_precio_vta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_precio_vta_May = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sucursal_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_codbarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contenido_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant_vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Prov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nrocat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdxSucBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Producto_ds = New Aplicacion.Producto_ds()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdxSucBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Bo_cancelar
        '
        Me.Bo_cancelar.Image = CType(resources.GetObject("Bo_cancelar.Image"), System.Drawing.Image)
        Me.Bo_cancelar.Location = New System.Drawing.Point(489, 7)
        Me.Bo_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_cancelar.Name = "Bo_cancelar"
        Me.Bo_cancelar.Size = New System.Drawing.Size(53, 49)
        Me.Bo_cancelar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Bo_cancelar, "Cancelar")
        Me.Bo_cancelar.UseVisualStyleBackColor = True
        Me.Bo_cancelar.Visible = False
        '
        'BO_producto_modificar
        '
        Me.BO_producto_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_producto_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_producto_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_producto_modificar.Location = New System.Drawing.Point(970, 10)
        Me.BO_producto_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_producto_modificar.Name = "BO_producto_modificar"
        Me.BO_producto_modificar.Size = New System.Drawing.Size(124, 43)
        Me.BO_producto_modificar.TabIndex = 0
        Me.BO_producto_modificar.Text = "Editar"
        Me.BO_producto_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_producto_modificar, "Editar Producto seleccionado")
        Me.BO_producto_modificar.UseVisualStyleBackColor = True
        '
        'Bo_guardar
        '
        Me.Bo_guardar.Image = CType(resources.GetObject("Bo_guardar.Image"), System.Drawing.Image)
        Me.Bo_guardar.Location = New System.Drawing.Point(370, 9)
        Me.Bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_guardar.Name = "Bo_guardar"
        Me.Bo_guardar.Size = New System.Drawing.Size(53, 49)
        Me.Bo_guardar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Bo_guardar, "Guardar")
        Me.Bo_guardar.UseVisualStyleBackColor = True
        Me.Bo_guardar.Visible = False
        '
        'BO_producto_nuevo
        '
        Me.BO_producto_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_producto_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_producto_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_producto_nuevo.Location = New System.Drawing.Point(1102, 10)
        Me.BO_producto_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_producto_nuevo.Name = "BO_producto_nuevo"
        Me.BO_producto_nuevo.Size = New System.Drawing.Size(124, 43)
        Me.BO_producto_nuevo.TabIndex = 2
        Me.BO_producto_nuevo.Text = "Agregar"
        Me.BO_producto_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_producto_nuevo, "Agregar nuevo Producto")
        Me.BO_producto_nuevo.UseVisualStyleBackColor = True
        '
        'btn_Anular
        '
        Me.btn_Anular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Anular.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Anular.Location = New System.Drawing.Point(837, 10)
        Me.btn_Anular.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Anular.Name = "btn_Anular"
        Me.btn_Anular.Size = New System.Drawing.Size(124, 43)
        Me.btn_Anular.TabIndex = 16
        Me.btn_Anular.Text = "Eliminar"
        Me.btn_Anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Anular, "Eliminar producto seleccionado")
        Me.btn_Anular.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button1.Location = New System.Drawing.Point(178, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 43)
        Me.Button1.TabIndex = 251
        Me.Button1.Text = "Generar reporte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Generar reporte")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.icono_editar_30x30
        Me.Button2.Location = New System.Drawing.Point(14, 10)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 43)
        Me.Button2.TabIndex = 252
        Me.Button2.Text = "Ajuste de Insumo"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "Ajuste de stock")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkRed
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button3.Location = New System.Drawing.Point(697, 10)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 43)
        Me.Button3.TabIndex = 253
        Me.Button3.Text = "Mantenimiento"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button3, "Generar reporte")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cb_origen)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1283, 605)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Busqueda de Productos"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.PictureBox7)
        Me.GroupBox5.Controls.Add(Me.PictureBox8)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 463)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(307, 62)
        Me.GroupBox5.TabIndex = 250
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Referencias para control de productos:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(234, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Vencido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Stock bajo"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Red
        Me.PictureBox7.Location = New System.Drawing.Point(200, 21)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Blue
        Me.PictureBox8.Location = New System.Drawing.Point(10, 21)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.check_proveedor)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.check_rubro)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.check_categoria)
        Me.GroupBox3.Controls.Add(Me.cb_proveedor)
        Me.GroupBox3.Controls.Add(Me.cb_categoria)
        Me.GroupBox3.Controls.Add(Me.cb_subrubro)
        Me.GroupBox3.Controls.Add(Me.lb_proveedor)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.check_marca)
        Me.GroupBox3.Controls.Add(Me.cb_rubro)
        Me.GroupBox3.Controls.Add(Me.check_subrubro)
        Me.GroupBox3.Controls.Add(Me.cb_marca)
        Me.GroupBox3.Controls.Add(Me.Categoria)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1217, 109)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrar Por:"
        '
        'check_proveedor
        '
        Me.check_proveedor.AutoSize = True
        Me.check_proveedor.Location = New System.Drawing.Point(16, 70)
        Me.check_proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.check_proveedor.Name = "check_proveedor"
        Me.check_proveedor.Size = New System.Drawing.Size(15, 14)
        Me.check_proveedor.TabIndex = 24
        Me.check_proveedor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(473, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Marca:"
        '
        'check_rubro
        '
        Me.check_rubro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_rubro.AutoSize = True
        Me.check_rubro.Enabled = False
        Me.check_rubro.Location = New System.Drawing.Point(348, 21)
        Me.check_rubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_rubro.Name = "check_rubro"
        Me.check_rubro.Size = New System.Drawing.Size(15, 14)
        Me.check_rubro.TabIndex = 16
        Me.check_rubro.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(373, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Rubro:"
        '
        'check_categoria
        '
        Me.check_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_categoria.AutoSize = True
        Me.check_categoria.Location = New System.Drawing.Point(16, 22)
        Me.check_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.check_categoria.Name = "check_categoria"
        Me.check_categoria.Size = New System.Drawing.Size(15, 14)
        Me.check_categoria.TabIndex = 18
        Me.check_categoria.UseVisualStyleBackColor = True
        '
        'cb_proveedor
        '
        Me.cb_proveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_proveedor.BackColor = System.Drawing.SystemColors.Info
        Me.cb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_proveedor.Enabled = False
        Me.cb_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_proveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cb_proveedor.FormattingEnabled = True
        Me.cb_proveedor.Location = New System.Drawing.Point(119, 65)
        Me.cb_proveedor.Name = "cb_proveedor"
        Me.cb_proveedor.Size = New System.Drawing.Size(278, 24)
        Me.cb_proveedor.TabIndex = 22
        '
        'cb_categoria
        '
        Me.cb_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_categoria.BackColor = System.Drawing.SystemColors.Info
        Me.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_categoria.Enabled = False
        Me.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(133, 14)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(205, 24)
        Me.cb_categoria.TabIndex = 10
        '
        'cb_subrubro
        '
        Me.cb_subrubro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_subrubro.BackColor = System.Drawing.SystemColors.Info
        Me.cb_subrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_subrubro.Enabled = False
        Me.cb_subrubro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_subrubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_subrubro.FormattingEnabled = True
        Me.cb_subrubro.Location = New System.Drawing.Point(767, 15)
        Me.cb_subrubro.Name = "cb_subrubro"
        Me.cb_subrubro.Size = New System.Drawing.Size(205, 24)
        Me.cb_subrubro.TabIndex = 14
        '
        'lb_proveedor
        '
        Me.lb_proveedor.AutoSize = True
        Me.lb_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_proveedor.Location = New System.Drawing.Point(38, 68)
        Me.lb_proveedor.Name = "lb_proveedor"
        Me.lb_proveedor.Size = New System.Drawing.Size(75, 16)
        Me.lb_proveedor.TabIndex = 23
        Me.lb_proveedor.Text = "Proveedor:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(679, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Subrubro:"
        '
        'check_marca
        '
        Me.check_marca.AutoSize = True
        Me.check_marca.Location = New System.Drawing.Point(451, 70)
        Me.check_marca.Margin = New System.Windows.Forms.Padding(4)
        Me.check_marca.Name = "check_marca"
        Me.check_marca.Size = New System.Drawing.Size(15, 14)
        Me.check_marca.TabIndex = 21
        Me.check_marca.UseVisualStyleBackColor = True
        '
        'cb_rubro
        '
        Me.cb_rubro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_rubro.BackColor = System.Drawing.SystemColors.Info
        Me.cb_rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_rubro.Enabled = False
        Me.cb_rubro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_rubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_rubro.FormattingEnabled = True
        Me.cb_rubro.Location = New System.Drawing.Point(438, 14)
        Me.cb_rubro.Name = "cb_rubro"
        Me.cb_rubro.Size = New System.Drawing.Size(205, 24)
        Me.cb_rubro.TabIndex = 12
        '
        'check_subrubro
        '
        Me.check_subrubro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_subrubro.AutoSize = True
        Me.check_subrubro.Enabled = False
        Me.check_subrubro.Location = New System.Drawing.Point(654, 21)
        Me.check_subrubro.Margin = New System.Windows.Forms.Padding(4)
        Me.check_subrubro.Name = "check_subrubro"
        Me.check_subrubro.Size = New System.Drawing.Size(15, 14)
        Me.check_subrubro.TabIndex = 17
        Me.check_subrubro.UseVisualStyleBackColor = True
        '
        'cb_marca
        '
        Me.cb_marca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_marca.BackColor = System.Drawing.SystemColors.Info
        Me.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_marca.Enabled = False
        Me.cb_marca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_marca.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cb_marca.FormattingEnabled = True
        Me.cb_marca.Location = New System.Drawing.Point(528, 65)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(132, 24)
        Me.cb_marca.TabIndex = 20
        '
        'Categoria
        '
        Me.Categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Categoria.AutoSize = True
        Me.Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categoria.Location = New System.Drawing.Point(41, 18)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(70, 16)
        Me.Categoria.TabIndex = 11
        Me.Categoria.Text = "Categoria:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tx_Buscqueda)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1225, 65)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSCAR PRODUCTO"
        '
        'Tx_Buscqueda
        '
        Me.Tx_Buscqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Buscqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx_Buscqueda.Location = New System.Drawing.Point(16, 31)
        Me.Tx_Buscqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Tx_Buscqueda.Name = "Tx_Buscqueda"
        Me.Tx_Buscqueda.Size = New System.Drawing.Size(1202, 22)
        Me.Tx_Buscqueda.TabIndex = 1
        Me.Tx_Buscqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_Anular)
        Me.Panel1.Controls.Add(Me.BO_producto_nuevo)
        Me.Panel1.Controls.Add(Me.BO_producto_modificar)
        Me.Panel1.Controls.Add(Me.Bo_guardar)
        Me.Panel1.Controls.Add(Me.Bo_cancelar)
        Me.Panel1.Location = New System.Drawing.Point(6, 532)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 63)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Seleccione la Sucursal"
        '
        'cb_origen
        '
        Me.cb_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_origen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_origen.FormattingEnabled = True
        Me.cb_origen.ItemHeight = 16
        Me.cb_origen.Location = New System.Drawing.Point(232, 8)
        Me.cb_origen.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_origen.MaximumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.MinimumSize = New System.Drawing.Size(265, 0)
        Me.cb_origen.Name = "cb_origen"
        Me.cb_origen.Size = New System.Drawing.Size(265, 24)
        Me.cb_origen.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DG_Producto)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 226)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1267, 238)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos:"
        '
        'DG_Producto
        '
        Me.DG_Producto.AllowUserToAddRows = False
        Me.DG_Producto.AllowUserToDeleteRows = False
        Me.DG_Producto.AllowUserToResizeRows = False
        Me.DG_Producto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Producto.AutoGenerateColumns = False
        Me.DG_Producto.BackgroundColor = System.Drawing.Color.White
        Me.DG_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Producto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod_codinterno, Me.prod_descripcion, Me.ProdxSuc_stock, Me.prod_ptorepo, Me.prod_precio_vta, Me.prod_precio_vta_May, Me.prod_id, Me.sucursal_id, Me.prod_codbarra, Me.Contenido, Me.Contenido_total, Me.cant_vencimiento, Me.Column1, Me.Prov_id, Me.marca_id, Me.nrocat, Me.idcat})
        Me.DG_Producto.DataSource = Me.ProdxSucBindingSource
        Me.DG_Producto.Location = New System.Drawing.Point(5, 23)
        Me.DG_Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Producto.MultiSelect = False
        Me.DG_Producto.Name = "DG_Producto"
        Me.DG_Producto.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Producto.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Producto.Size = New System.Drawing.Size(1240, 207)
        Me.DG_Producto.StandardTab = True
        Me.DG_Producto.TabIndex = 0
        '
        'prod_codinterno
        '
        Me.prod_codinterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prod_codinterno.DataPropertyName = "prod_codinterno"
        Me.prod_codinterno.FillWeight = 87.05584!
        Me.prod_codinterno.HeaderText = "Codigo"
        Me.prod_codinterno.Name = "prod_codinterno"
        Me.prod_codinterno.ReadOnly = True
        '
        'prod_descripcion
        '
        Me.prod_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prod_descripcion.DataPropertyName = "prod_descripcion"
        Me.prod_descripcion.FillWeight = 87.05584!
        Me.prod_descripcion.HeaderText = "Descripcion"
        Me.prod_descripcion.Name = "prod_descripcion"
        Me.prod_descripcion.ReadOnly = True
        '
        'ProdxSuc_stock
        '
        Me.ProdxSuc_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdxSuc_stock.DataPropertyName = "ProdxSuc_stock"
        Me.ProdxSuc_stock.FillWeight = 87.05584!
        Me.ProdxSuc_stock.HeaderText = "Stock"
        Me.ProdxSuc_stock.Name = "ProdxSuc_stock"
        Me.ProdxSuc_stock.ReadOnly = True
        '
        'prod_ptorepo
        '
        Me.prod_ptorepo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.prod_ptorepo.DataPropertyName = "prod_ptorepo"
        Me.prod_ptorepo.FillWeight = 87.05584!
        Me.prod_ptorepo.HeaderText = "Punto de Reposición"
        Me.prod_ptorepo.Name = "prod_ptorepo"
        Me.prod_ptorepo.ReadOnly = True
        Me.prod_ptorepo.Width = 190
        '
        'prod_precio_vta
        '
        Me.prod_precio_vta.DataPropertyName = "prod_precio_vta"
        Me.prod_precio_vta.FillWeight = 87.05584!
        Me.prod_precio_vta.HeaderText = "Precio Minorista"
        Me.prod_precio_vta.Name = "prod_precio_vta"
        Me.prod_precio_vta.ReadOnly = True
        Me.prod_precio_vta.Visible = False
        Me.prod_precio_vta.Width = 200
        '
        'prod_precio_vta_May
        '
        Me.prod_precio_vta_May.DataPropertyName = "prod_precio_vta_May"
        Me.prod_precio_vta_May.FillWeight = 87.05584!
        Me.prod_precio_vta_May.HeaderText = "Precio Mayorista"
        Me.prod_precio_vta_May.Name = "prod_precio_vta_May"
        Me.prod_precio_vta_May.ReadOnly = True
        Me.prod_precio_vta_May.Visible = False
        Me.prod_precio_vta_May.Width = 200
        '
        'prod_id
        '
        Me.prod_id.DataPropertyName = "prod_id"
        Me.prod_id.HeaderText = "prod_id"
        Me.prod_id.Name = "prod_id"
        Me.prod_id.Visible = False
        '
        'sucursal_id
        '
        Me.sucursal_id.DataPropertyName = "sucursal_id"
        Me.sucursal_id.HeaderText = "sucursal_id"
        Me.sucursal_id.Name = "sucursal_id"
        Me.sucursal_id.Visible = False
        '
        'prod_codbarra
        '
        Me.prod_codbarra.DataPropertyName = "prod_codbarra"
        Me.prod_codbarra.HeaderText = "prod_codbarra"
        Me.prod_codbarra.Name = "prod_codbarra"
        Me.prod_codbarra.Visible = False
        '
        'Contenido
        '
        Me.Contenido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Contenido.DataPropertyName = "Contenido"
        Me.Contenido.HeaderText = "Contenido por unidad"
        Me.Contenido.Name = "Contenido"
        Me.Contenido.ReadOnly = True
        '
        'Contenido_total
        '
        Me.Contenido_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Contenido_total.DataPropertyName = "Contenido_total"
        Me.Contenido_total.HeaderText = "Contenido total"
        Me.Contenido_total.Name = "Contenido_total"
        Me.Contenido_total.ReadOnly = True
        '
        'cant_vencimiento
        '
        Me.cant_vencimiento.DataPropertyName = "cant_vencimiento"
        Me.cant_vencimiento.HeaderText = "Vencidos"
        Me.cant_vencimiento.Name = "cant_vencimiento"
        Me.cant_vencimiento.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.FillWeight = 177.665!
        Me.Column1.HeaderText = "Seleccionar"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Visible = False
        '
        'Prov_id
        '
        Me.Prov_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Prov_id.DataPropertyName = "Prov_id"
        Me.Prov_id.HeaderText = "Prov_id"
        Me.Prov_id.Name = "Prov_id"
        Me.Prov_id.ReadOnly = True
        Me.Prov_id.Visible = False
        '
        'marca_id
        '
        Me.marca_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.marca_id.DataPropertyName = "marca_id"
        Me.marca_id.HeaderText = "marca_id"
        Me.marca_id.Name = "marca_id"
        Me.marca_id.ReadOnly = True
        Me.marca_id.Visible = False
        '
        'nrocat
        '
        Me.nrocat.DataPropertyName = "nrocat"
        Me.nrocat.HeaderText = "nrocat"
        Me.nrocat.Name = "nrocat"
        Me.nrocat.ReadOnly = True
        Me.nrocat.Visible = False
        '
        'idcat
        '
        Me.idcat.DataPropertyName = "idcat"
        Me.idcat.HeaderText = "idcat"
        Me.idcat.Name = "idcat"
        Me.idcat.ReadOnly = True
        Me.idcat.Visible = False
        '
        'ProdxSucBindingSource
        '
        Me.ProdxSucBindingSource.DataMember = "ProdxSuc"
        Me.ProdxSucBindingSource.DataSource = Me.Producto_ds
        '
        'Producto_ds
        '
        Me.Producto_ds.DataSetName = "Producto_ds"
        Me.Producto_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 6)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1291, 634)
        Me.TabControl1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Producto_modificar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1274, 645)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1024, 665)
        Me.Name = "Producto_modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock y Actualización de Productos"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdxSucBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Producto_ds As Aplicacion.Producto_ds
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BO_producto_nuevo As System.Windows.Forms.Button
    Friend WithEvents Bo_guardar As System.Windows.Forms.Button
    Friend WithEvents BO_producto_modificar As System.Windows.Forms.Button
    Friend WithEvents Bo_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tx_Buscqueda As System.Windows.Forms.TextBox
    Friend WithEvents DG_Producto As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ProdxSucBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_origen As System.Windows.Forms.ComboBox
    Friend WithEvents cb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents check_marca As System.Windows.Forms.CheckBox
    Friend WithEvents Categoria As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents check_subrubro As System.Windows.Forms.CheckBox
    Friend WithEvents check_categoria As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents check_rubro As System.Windows.Forms.CheckBox
    Friend WithEvents cb_subrubro As System.Windows.Forms.ComboBox
    Friend WithEvents cb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents cb_rubro As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Anular As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents check_proveedor As System.Windows.Forms.CheckBox
    Friend WithEvents lb_proveedor As System.Windows.Forms.Label
    Friend WithEvents cb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents prod_codinterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdxSuc_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_ptorepo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_precio_vta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_precio_vta_May As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sucursal_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_codbarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contenido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contenido_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant_vencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Prov_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nrocat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idcat As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
