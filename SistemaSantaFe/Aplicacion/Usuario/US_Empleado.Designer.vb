<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class US_Empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(US_Empleado))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TurnoConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoGestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoComunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoComunNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoComunToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoFijoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoFijoNuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoFijoActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton6 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VentaEnCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaEnMesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteInformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HeladeraGondolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton7 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EgresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresoNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresosRegistradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PN_Entrada = New System.Windows.Forms.Panel()
        Me.BO_USU_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BO_USU_contrasena = New System.Windows.Forms.Button()
        Me.BO_USU_sesion = New System.Windows.Forms.Button()
        Me.LB_UT_dep = New System.Windows.Forms.Label()
        Me.LB_USU_ape = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BO_Caja = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BO_TurnoConsulta = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(445, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 45)
        Me.Button1.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.Button1, "Alarma de Turno")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator2, Me.ToolStripDropDownButton6, Me.ToolStripSeparator3, Me.ToolStripDropDownButton2, Me.ToolStripSeparator7, Me.ToolStripDropDownButton3, Me.ToolStripSeparator4, Me.ToolStripDropDownButton7, Me.ToolStripSeparator5})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 56)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(81, 347)
        Me.ToolStrip1.TabIndex = 60
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(79, 6)
        Me.ToolStripSeparator1.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.AutoSize = False
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoConsultaToolStripMenuItem, Me.TurnoGestionToolStripMenuItem, Me.TurnoComunToolStripMenuItem, Me.TurnoFijoToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton1.Text = "Turno"
        '
        'TurnoConsultaToolStripMenuItem
        '
        Me.TurnoConsultaToolStripMenuItem.Name = "TurnoConsultaToolStripMenuItem"
        Me.TurnoConsultaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TurnoConsultaToolStripMenuItem.Text = "Turno Consulta"
        '
        'TurnoGestionToolStripMenuItem
        '
        Me.TurnoGestionToolStripMenuItem.Name = "TurnoGestionToolStripMenuItem"
        Me.TurnoGestionToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TurnoGestionToolStripMenuItem.Text = "Turno Gestion"
        '
        'TurnoComunToolStripMenuItem
        '
        Me.TurnoComunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoComunNuevoToolStripMenuItem, Me.TurnoComunToolStripMenuItem1})
        Me.TurnoComunToolStripMenuItem.Name = "TurnoComunToolStripMenuItem"
        Me.TurnoComunToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TurnoComunToolStripMenuItem.Text = "Turno Comun"
        '
        'TurnoComunNuevoToolStripMenuItem
        '
        Me.TurnoComunNuevoToolStripMenuItem.Name = "TurnoComunNuevoToolStripMenuItem"
        Me.TurnoComunNuevoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.TurnoComunNuevoToolStripMenuItem.Text = "Turno Comun Nuevo"
        '
        'TurnoComunToolStripMenuItem1
        '
        Me.TurnoComunToolStripMenuItem1.Name = "TurnoComunToolStripMenuItem1"
        Me.TurnoComunToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.TurnoComunToolStripMenuItem1.Text = "Turno Comun Eliminar"
        '
        'TurnoFijoToolStripMenuItem
        '
        Me.TurnoFijoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoFijoNuevoToolStripMenuItem1, Me.TurnoFijoActualizarToolStripMenuItem})
        Me.TurnoFijoToolStripMenuItem.Name = "TurnoFijoToolStripMenuItem"
        Me.TurnoFijoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TurnoFijoToolStripMenuItem.Text = "Turno Fijo"
        '
        'TurnoFijoNuevoToolStripMenuItem1
        '
        Me.TurnoFijoNuevoToolStripMenuItem1.Name = "TurnoFijoNuevoToolStripMenuItem1"
        Me.TurnoFijoNuevoToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.TurnoFijoNuevoToolStripMenuItem1.Text = "Turno Fijo Nuevo"
        '
        'TurnoFijoActualizarToolStripMenuItem
        '
        Me.TurnoFijoActualizarToolStripMenuItem.Name = "TurnoFijoActualizarToolStripMenuItem"
        Me.TurnoFijoActualizarToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TurnoFijoActualizarToolStripMenuItem.Text = "Turno Fijo Actualizar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(79, 6)
        '
        'ToolStripDropDownButton6
        '
        Me.ToolStripDropDownButton6.AutoSize = False
        Me.ToolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaEnCajaToolStripMenuItem, Me.VentaEnMesasToolStripMenuItem, Me.VentaConsultaToolStripMenuItem, Me.CalculadoraDelSistemaToolStripMenuItem})
        Me.ToolStripDropDownButton6.Image = CType(resources.GetObject("ToolStripDropDownButton6.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton6.Name = "ToolStripDropDownButton6"
        Me.ToolStripDropDownButton6.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton6.Text = "Venta"
        '
        'VentaEnCajaToolStripMenuItem
        '
        Me.VentaEnCajaToolStripMenuItem.Name = "VentaEnCajaToolStripMenuItem"
        Me.VentaEnCajaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VentaEnCajaToolStripMenuItem.Text = "Venta en Caja"
        '
        'VentaEnMesasToolStripMenuItem
        '
        Me.VentaEnMesasToolStripMenuItem.Name = "VentaEnMesasToolStripMenuItem"
        Me.VentaEnMesasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VentaEnMesasToolStripMenuItem.Text = "Venta en mesas"
        '
        'VentaConsultaToolStripMenuItem
        '
        Me.VentaConsultaToolStripMenuItem.Name = "VentaConsultaToolStripMenuItem"
        Me.VentaConsultaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VentaConsultaToolStripMenuItem.Text = "Venta Consulta"
        '
        'CalculadoraDelSistemaToolStripMenuItem
        '
        Me.CalculadoraDelSistemaToolStripMenuItem.Name = "CalculadoraDelSistemaToolStripMenuItem"
        Me.CalculadoraDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CalculadoraDelSistemaToolStripMenuItem.Text = "Calculadora del Sistema"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(79, 6)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.AutoSize = False
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem, Me.ClienteInformeToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton2.Text = "Cliente"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NuevoClienteToolStripMenuItem.Text = "Cliente Nuevo"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Cliente Actualizar"
        '
        'ClienteInformeToolStripMenuItem
        '
        Me.ClienteInformeToolStripMenuItem.Name = "ClienteInformeToolStripMenuItem"
        Me.ClienteInformeToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ClienteInformeToolStripMenuItem.Text = "Cliente Informe"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(79, 6)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.AutoSize = False
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeladeraGondolaToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton3.Text = "Bar"
        '
        'HeladeraGondolaToolStripMenuItem
        '
        Me.HeladeraGondolaToolStripMenuItem.Name = "HeladeraGondolaToolStripMenuItem"
        Me.HeladeraGondolaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.HeladeraGondolaToolStripMenuItem.Text = "Heladera / Gondola"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(79, 6)
        '
        'ToolStripDropDownButton7
        '
        Me.ToolStripDropDownButton7.AutoSize = False
        Me.ToolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EgresoToolStripMenuItem})
        Me.ToolStripDropDownButton7.Image = CType(resources.GetObject("ToolStripDropDownButton7.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton7.Name = "ToolStripDropDownButton7"
        Me.ToolStripDropDownButton7.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton7.Text = "Egreso y Pedido"
        '
        'EgresoToolStripMenuItem
        '
        Me.EgresoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EgresoNuevoToolStripMenuItem, Me.EgresosRegistradosToolStripMenuItem})
        Me.EgresoToolStripMenuItem.Name = "EgresoToolStripMenuItem"
        Me.EgresoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EgresoToolStripMenuItem.Text = "Egreso"
        '
        'EgresoNuevoToolStripMenuItem
        '
        Me.EgresoNuevoToolStripMenuItem.Name = "EgresoNuevoToolStripMenuItem"
        Me.EgresoNuevoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.EgresoNuevoToolStripMenuItem.Text = "Egreso Nuevo"
        '
        'EgresosRegistradosToolStripMenuItem
        '
        Me.EgresosRegistradosToolStripMenuItem.Name = "EgresosRegistradosToolStripMenuItem"
        Me.EgresosRegistradosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.EgresosRegistradosToolStripMenuItem.Text = "Egresos registrados"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(79, 6)
        '
        'PN_Entrada
        '
        Me.PN_Entrada.BackColor = System.Drawing.Color.Transparent
        Me.PN_Entrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PN_Entrada.Location = New System.Drawing.Point(89, 57)
        Me.PN_Entrada.Name = "PN_Entrada"
        Me.PN_Entrada.Size = New System.Drawing.Size(890, 600)
        Me.PN_Entrada.TabIndex = 59
        '
        'BO_USU_cerrar
        '
        Me.BO_USU_cerrar.Image = CType(resources.GetObject("BO_USU_cerrar.Image"), System.Drawing.Image)
        Me.BO_USU_cerrar.Location = New System.Drawing.Point(955, 19)
        Me.BO_USU_cerrar.Name = "BO_USU_cerrar"
        Me.BO_USU_cerrar.Size = New System.Drawing.Size(24, 24)
        Me.BO_USU_cerrar.TabIndex = 58
        Me.BO_USU_cerrar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_USU_cerrar, "Cerrar Sistema")
        Me.BO_USU_cerrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BO_USU_contrasena)
        Me.GroupBox2.Controls.Add(Me.BO_USU_sesion)
        Me.GroupBox2.Controls.Add(Me.LB_UT_dep)
        Me.GroupBox2.Controls.Add(Me.LB_USU_ape)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(598, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 41)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sesión de Usuario"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(320, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 62
        Me.Button2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Button2, "Sonido")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BO_USU_contrasena
        '
        Me.BO_USU_contrasena.Image = CType(resources.GetObject("BO_USU_contrasena.Image"), System.Drawing.Image)
        Me.BO_USU_contrasena.Location = New System.Drawing.Point(260, 11)
        Me.BO_USU_contrasena.Name = "BO_USU_contrasena"
        Me.BO_USU_contrasena.Size = New System.Drawing.Size(24, 24)
        Me.BO_USU_contrasena.TabIndex = 33
        Me.BO_USU_contrasena.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_USU_contrasena, "Cambiar Contraseña")
        Me.BO_USU_contrasena.UseVisualStyleBackColor = True
        '
        'BO_USU_sesion
        '
        Me.BO_USU_sesion.Image = CType(resources.GetObject("BO_USU_sesion.Image"), System.Drawing.Image)
        Me.BO_USU_sesion.Location = New System.Drawing.Point(290, 11)
        Me.BO_USU_sesion.Name = "BO_USU_sesion"
        Me.BO_USU_sesion.Size = New System.Drawing.Size(24, 24)
        Me.BO_USU_sesion.TabIndex = 33
        Me.BO_USU_sesion.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_USU_sesion, "Cerrar Sesion")
        Me.BO_USU_sesion.UseVisualStyleBackColor = True
        '
        'LB_UT_dep
        '
        Me.LB_UT_dep.AutoSize = True
        Me.LB_UT_dep.ForeColor = System.Drawing.Color.DimGray
        Me.LB_UT_dep.Location = New System.Drawing.Point(152, 19)
        Me.LB_UT_dep.Name = "LB_UT_dep"
        Me.LB_UT_dep.Size = New System.Drawing.Size(82, 13)
        Me.LB_UT_dep.TabIndex = 15
        Me.LB_UT_dep.Text = "Tipo de Usuario"
        '
        'LB_USU_ape
        '
        Me.LB_USU_ape.AutoSize = True
        Me.LB_USU_ape.Location = New System.Drawing.Point(15, 19)
        Me.LB_USU_ape.Name = "LB_USU_ape"
        Me.LB_USU_ape.Size = New System.Drawing.Size(43, 13)
        Me.LB_USU_ape.TabIndex = 13
        Me.LB_USU_ape.Text = "Usuario"
        '
        'Timer1
        '
        '
        'BO_Caja
        '
        Me.BO_Caja.Image = CType(resources.GetObject("BO_Caja.Image"), System.Drawing.Image)
        Me.BO_Caja.Location = New System.Drawing.Point(547, 4)
        Me.BO_Caja.Name = "BO_Caja"
        Me.BO_Caja.Size = New System.Drawing.Size(45, 45)
        Me.BO_Caja.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.BO_Caja, "Caja")
        Me.BO_Caja.UseVisualStyleBackColor = True
        '
        'BO_TurnoConsulta
        '
        Me.BO_TurnoConsulta.Image = CType(resources.GetObject("BO_TurnoConsulta.Image"), System.Drawing.Image)
        Me.BO_TurnoConsulta.Location = New System.Drawing.Point(496, 4)
        Me.BO_TurnoConsulta.Name = "BO_TurnoConsulta"
        Me.BO_TurnoConsulta.Size = New System.Drawing.Size(45, 45)
        Me.BO_TurnoConsulta.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.BO_TurnoConsulta, "Consulta de Turno")
        Me.BO_TurnoConsulta.UseVisualStyleBackColor = True
        '
        'US_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.BO_TurnoConsulta)
        Me.Controls.Add(Me.BO_Caja)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PN_Entrada)
        Me.Controls.Add(Me.BO_USU_cerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 700)
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "US_Empleado"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestion de Ventas - HAMERSOFT"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TurnoGestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents NuevoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteInformeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton6 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents VentaEnCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PN_Entrada As System.Windows.Forms.Panel
    Friend WithEvents BO_USU_cerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_USU_contrasena As System.Windows.Forms.Button
    Friend WithEvents BO_USU_sesion As System.Windows.Forms.Button
    Friend WithEvents LB_UT_dep As System.Windows.Forms.Label
    Friend WithEvents LB_USU_ape As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents VentaEnMesasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TurnoFijoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoFijoNuevoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoFijoActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoComunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoComunNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoComunToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BO_Caja As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BO_TurnoConsulta As System.Windows.Forms.Button
    Friend WithEvents VentaConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton7 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents EgresoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EgresoNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EgresosRegistradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents HeladeraGondolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
End Class
