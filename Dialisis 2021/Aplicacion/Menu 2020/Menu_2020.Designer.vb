<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_2020
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_2020))
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Label_Suc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_restaurar = New System.Windows.Forms.Button()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_maximizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.menu_paciente = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevoPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriaClínicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_stock = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CategoríasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockYActualizacionDeInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarConsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_medicos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevoMédicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_reportes = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menu_usuarios = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label_leyenda = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_menu = New System.Windows.Forms.PictureBox()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BO_USU_contrasena = New System.Windows.Forms.Button()
        Me.BO_USU_sesion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LB_UT_dep = New System.Windows.Forms.Label()
        Me.LB_USU_ape = New System.Windows.Forms.Label()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelCabecera.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelCabecera.Controls.Add(Me.Label_Suc)
        Me.PanelCabecera.Controls.Add(Me.Label2)
        Me.PanelCabecera.Controls.Add(Me.btn_restaurar)
        Me.PanelCabecera.Controls.Add(Me.btn_minimizar)
        Me.PanelCabecera.Controls.Add(Me.btn_maximizar)
        Me.PanelCabecera.Controls.Add(Me.btn_cerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1280, 40)
        Me.PanelCabecera.TabIndex = 0
        '
        'Label_Suc
        '
        Me.Label_Suc.AutoSize = True
        Me.Label_Suc.BackColor = System.Drawing.Color.Transparent
        Me.Label_Suc.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Suc.ForeColor = System.Drawing.Color.Black
        Me.Label_Suc.Location = New System.Drawing.Point(176, 13)
        Me.Label_Suc.Name = "Label_Suc"
        Me.Label_Suc.Size = New System.Drawing.Size(124, 15)
        Me.Label_Suc.TabIndex = 5
        Me.Label_Suc.Text = "SUCURSAL Y TERMINAL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MENU PRINCIPAL - HAMERSOFT"
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restaurar.BackgroundImage = Global.Aplicacion.My.Resources.Resources.Icono_Restaurar
        Me.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_restaurar.FlatAppearance.BorderSize = 0
        Me.btn_restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_restaurar.Location = New System.Drawing.Point(1194, 0)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(40, 40)
        Me.btn_restaurar.TabIndex = 3
        Me.btn_restaurar.UseVisualStyleBackColor = True
        Me.btn_restaurar.Visible = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimizar.BackgroundImage = Global.Aplicacion.My.Resources.Resources.Icono_Minimizar
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Location = New System.Drawing.Point(1148, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_minimizar.TabIndex = 2
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'btn_maximizar
        '
        Me.btn_maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maximizar.BackgroundImage = Global.Aplicacion.My.Resources.Resources.Icono_Maximizar
        Me.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maximizar.FlatAppearance.BorderSize = 0
        Me.btn_maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maximizar.Location = New System.Drawing.Point(1194, 0)
        Me.btn_maximizar.Name = "btn_maximizar"
        Me.btn_maximizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_maximizar.TabIndex = 1
        Me.btn_maximizar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.BackgroundImage = Global.Aplicacion.My.Resources.Resources.Icono_cerrar_FN
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Location = New System.Drawing.Point(1240, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cerrar.TabIndex = 0
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.ToolStrip2)
        Me.PanelMenu.Controls.Add(Me.Label_leyenda)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.btn_menu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 680)
        Me.PanelMenu.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_paciente, Me.menu_stock, Me.menu_medicos, Me.menu_reportes, Me.menu_usuarios})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(6, 84)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(201, 336)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'menu_paciente
        '
        Me.menu_paciente.AutoSize = False
        Me.menu_paciente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPacienteToolStripMenuItem, Me.HistoriaClínicaToolStripMenuItem})
        Me.menu_paciente.ForeColor = System.Drawing.Color.White
        Me.menu_paciente.Image = Global.Aplicacion.My.Resources.Resources.clientes
        Me.menu_paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_paciente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_paciente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menu_paciente.Name = "menu_paciente"
        Me.menu_paciente.Size = New System.Drawing.Size(200, 60)
        Me.menu_paciente.Text = "Pacientes"
        Me.menu_paciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NuevoPacienteToolStripMenuItem
        '
        Me.NuevoPacienteToolStripMenuItem.Name = "NuevoPacienteToolStripMenuItem"
        Me.NuevoPacienteToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NuevoPacienteToolStripMenuItem.Text = "Nuevo paciente"
        '
        'HistoriaClínicaToolStripMenuItem
        '
        Me.HistoriaClínicaToolStripMenuItem.Name = "HistoriaClínicaToolStripMenuItem"
        Me.HistoriaClínicaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.HistoriaClínicaToolStripMenuItem.Text = "Historia Clínica"
        '
        'menu_stock
        '
        Me.menu_stock.AutoSize = False
        Me.menu_stock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoríasToolStripMenuItem, Me.MarcasToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ConsumosToolStripMenuItem})
        Me.menu_stock.ForeColor = System.Drawing.Color.White
        Me.menu_stock.Image = Global.Aplicacion.My.Resources.Resources.producto1
        Me.menu_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_stock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_stock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menu_stock.Name = "menu_stock"
        Me.menu_stock.Size = New System.Drawing.Size(200, 60)
        Me.menu_stock.Text = "Stock"
        Me.menu_stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CategoríasToolStripMenuItem
        '
        Me.CategoríasToolStripMenuItem.Name = "CategoríasToolStripMenuItem"
        Me.CategoríasToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CategoríasToolStripMenuItem.Text = "Categorías"
        '
        'MarcasToolStripMenuItem
        '
        Me.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem"
        Me.MarcasToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.MarcasToolStripMenuItem.Text = "Marcas"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.StockYActualizacionDeInfoToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'StockYActualizacionDeInfoToolStripMenuItem
        '
        Me.StockYActualizacionDeInfoToolStripMenuItem.Name = "StockYActualizacionDeInfoToolStripMenuItem"
        Me.StockYActualizacionDeInfoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.StockYActualizacionDeInfoToolStripMenuItem.Text = "Stock y actualizacion de info."
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem, Me.ConsultarToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'GestionarToolStripMenuItem
        '
        Me.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        Me.GestionarToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.GestionarToolStripMenuItem.Text = "Gestionar movimientos"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar movimientos históricos"
        '
        'ConsumosToolStripMenuItem
        '
        Me.ConsumosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarMovimientosToolStripMenuItem, Me.ConsultarConsumosToolStripMenuItem})
        Me.ConsumosToolStripMenuItem.Name = "ConsumosToolStripMenuItem"
        Me.ConsumosToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ConsumosToolStripMenuItem.Text = "Consumos"
        '
        'GestionarMovimientosToolStripMenuItem
        '
        Me.GestionarMovimientosToolStripMenuItem.Name = "GestionarMovimientosToolStripMenuItem"
        Me.GestionarMovimientosToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.GestionarMovimientosToolStripMenuItem.Text = "Gestionar consumos"
        '
        'ConsultarConsumosToolStripMenuItem
        '
        Me.ConsultarConsumosToolStripMenuItem.Name = "ConsultarConsumosToolStripMenuItem"
        Me.ConsultarConsumosToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ConsultarConsumosToolStripMenuItem.Text = "Consultar consumos históricos"
        '
        'menu_medicos
        '
        Me.menu_medicos.AutoSize = False
        Me.menu_medicos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoMédicoToolStripMenuItem})
        Me.menu_medicos.ForeColor = System.Drawing.Color.White
        Me.menu_medicos.Image = Global.Aplicacion.My.Resources.Resources.empleados
        Me.menu_medicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_medicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_medicos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menu_medicos.Name = "menu_medicos"
        Me.menu_medicos.Size = New System.Drawing.Size(200, 60)
        Me.menu_medicos.Text = "Médicos"
        Me.menu_medicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NuevoMédicoToolStripMenuItem
        '
        Me.NuevoMédicoToolStripMenuItem.Name = "NuevoMédicoToolStripMenuItem"
        Me.NuevoMédicoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoMédicoToolStripMenuItem.Text = "Nuevo médico"
        '
        'menu_reportes
        '
        Me.menu_reportes.AutoSize = False
        Me.menu_reportes.ForeColor = System.Drawing.Color.White
        Me.menu_reportes.Image = Global.Aplicacion.My.Resources.Resources.reportes
        Me.menu_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_reportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menu_reportes.Name = "menu_reportes"
        Me.menu_reportes.Size = New System.Drawing.Size(200, 60)
        Me.menu_reportes.Text = "Reportes"
        Me.menu_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'menu_usuarios
        '
        Me.menu_usuarios.AutoSize = False
        Me.menu_usuarios.ForeColor = System.Drawing.Color.White
        Me.menu_usuarios.Image = Global.Aplicacion.My.Resources.Resources.clientes
        Me.menu_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_usuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menu_usuarios.Name = "menu_usuarios"
        Me.menu_usuarios.Size = New System.Drawing.Size(200, 60)
        Me.menu_usuarios.Text = "Usuarios"
        Me.menu_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_leyenda
        '
        Me.Label_leyenda.AutoSize = True
        Me.Label_leyenda.BackColor = System.Drawing.Color.Transparent
        Me.Label_leyenda.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_leyenda.ForeColor = System.Drawing.Color.White
        Me.Label_leyenda.Location = New System.Drawing.Point(72, 59)
        Me.Label_leyenda.Name = "Label_leyenda"
        Me.Label_leyenda.Size = New System.Drawing.Size(120, 15)
        Me.Label_leyenda.TabIndex = 3
        Me.Label_leyenda.Text = "SOFTWARE DE GESTIÓN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplicacion.My.Resources.Resources.logo_hs_hamer
        Me.PictureBox1.Location = New System.Drawing.Point(6, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btn_menu
        '
        Me.btn_menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_menu.Image = Global.Aplicacion.My.Resources.Resources.Mobile_Menu_Icon
        Me.btn_menu.Location = New System.Drawing.Point(168, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(50, 41)
        Me.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_menu.TabIndex = 1
        Me.btn_menu.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btn_menu, "Contraer/Expandir menú")
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(824, 14)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 30)
        Me.Button2.TabIndex = 56
        Me.Button2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Button2, "Sonido")
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'BO_USU_contrasena
        '
        Me.BO_USU_contrasena.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_USU_contrasena.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BO_USU_contrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BO_USU_contrasena.Image = CType(resources.GetObject("BO_USU_contrasena.Image"), System.Drawing.Image)
        Me.BO_USU_contrasena.Location = New System.Drawing.Point(864, 14)
        Me.BO_USU_contrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_USU_contrasena.Name = "BO_USU_contrasena"
        Me.BO_USU_contrasena.Size = New System.Drawing.Size(32, 30)
        Me.BO_USU_contrasena.TabIndex = 33
        Me.BO_USU_contrasena.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_USU_contrasena, "Cambiar Contraseña")
        Me.BO_USU_contrasena.UseVisualStyleBackColor = True
        '
        'BO_USU_sesion
        '
        Me.BO_USU_sesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_USU_sesion.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BO_USU_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BO_USU_sesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BO_USU_sesion.Image = CType(resources.GetObject("BO_USU_sesion.Image"), System.Drawing.Image)
        Me.BO_USU_sesion.Location = New System.Drawing.Point(904, 14)
        Me.BO_USU_sesion.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_USU_sesion.Name = "BO_USU_sesion"
        Me.BO_USU_sesion.Size = New System.Drawing.Size(128, 30)
        Me.BO_USU_sesion.TabIndex = 33
        Me.BO_USU_sesion.TabStop = False
        Me.BO_USU_sesion.Text = "Cerrar sesión"
        Me.BO_USU_sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_USU_sesion, "Cerrar Sesion")
        Me.BO_USU_sesion.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(220, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1060, 59)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BO_USU_contrasena)
        Me.GroupBox2.Controls.Add(Me.BO_USU_sesion)
        Me.GroupBox2.Controls.Add(Me.LB_UT_dep)
        Me.GroupBox2.Controls.Add(Me.LB_USU_ape)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1040, 50)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sesión de Usuario"
        '
        'LB_UT_dep
        '
        Me.LB_UT_dep.AutoSize = True
        Me.LB_UT_dep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_UT_dep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LB_UT_dep.Location = New System.Drawing.Point(268, 23)
        Me.LB_UT_dep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_UT_dep.Name = "LB_UT_dep"
        Me.LB_UT_dep.Size = New System.Drawing.Size(97, 13)
        Me.LB_UT_dep.TabIndex = 15
        Me.LB_UT_dep.Text = "Tipo de Usuario"
        '
        'LB_USU_ape
        '
        Me.LB_USU_ape.AutoSize = True
        Me.LB_USU_ape.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_USU_ape.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LB_USU_ape.Location = New System.Drawing.Point(6, 23)
        Me.LB_USU_ape.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_USU_ape.Name = "LB_USU_ape"
        Me.LB_USU_ape.Size = New System.Drawing.Size(50, 13)
        Me.LB_USU_ape.TabIndex = 13
        Me.LB_USU_ape.Text = "Usuario"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.LightGray
        Me.PanelContenedor.BackgroundImage = Global.Aplicacion.My.Resources.Resources.FONDO_MENU_HS
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.ForeColor = System.Drawing.Color.CadetBlue
        Me.PanelContenedor.Location = New System.Drawing.Point(220, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1060, 680)
        Me.PanelContenedor.TabIndex = 0
        '
        'Menu_2020
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu_2020"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelCabecera As System.Windows.Forms.Panel
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents btn_maximizar As System.Windows.Forms.Button
    Friend WithEvents btn_minimizar As System.Windows.Forms.Button
    Friend WithEvents btn_restaurar As System.Windows.Forms.Button
    Friend WithEvents btn_menu As System.Windows.Forms.PictureBox
    Friend WithEvents tmOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_leyenda As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents menu_paciente As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menu_stock As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menu_medicos As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menu_reportes As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menu_usuarios As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents NuevoPacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BO_USU_contrasena As System.Windows.Forms.Button
    Friend WithEvents BO_USU_sesion As System.Windows.Forms.Button
    Friend WithEvents LB_UT_dep As System.Windows.Forms.Label
    Friend WithEvents LB_USU_ape As System.Windows.Forms.Label
    Friend WithEvents HistoriaClínicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoMédicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoríasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockYActualizacionDeInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarMovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarConsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_Suc As System.Windows.Forms.Label
End Class
