<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class US_Pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(US_Pedidos))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BO_USU_cerrar = New System.Windows.Forms.Button()
        Me.PN_Entrada = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BO_USU_contrasena = New System.Windows.Forms.Button()
        Me.BO_USU_sesion = New System.Windows.Forms.Button()
        Me.LB_UT_dep = New System.Windows.Forms.Label()
        Me.LB_USU_ape = New System.Windows.Forms.Label()
        Me.ToolStripDropDownButton7 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BO_Caja = New System.Windows.Forms.Button()
        Me.BO_TurnoConsulta = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(445, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 45)
        Me.Button1.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.Button1, "Alarma de Turno")
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BO_USU_cerrar
        '
        Me.BO_USU_cerrar.Image = CType(resources.GetObject("BO_USU_cerrar.Image"), System.Drawing.Image)
        Me.BO_USU_cerrar.Location = New System.Drawing.Point(955, 20)
        Me.BO_USU_cerrar.Name = "BO_USU_cerrar"
        Me.BO_USU_cerrar.Size = New System.Drawing.Size(24, 24)
        Me.BO_USU_cerrar.TabIndex = 66
        Me.BO_USU_cerrar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_USU_cerrar, "Cerrar Sistema")
        Me.BO_USU_cerrar.UseVisualStyleBackColor = True
        '
        'PN_Entrada
        '
        Me.PN_Entrada.BackColor = System.Drawing.Color.Transparent
        Me.PN_Entrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PN_Entrada.Location = New System.Drawing.Point(89, 58)
        Me.PN_Entrada.Name = "PN_Entrada"
        Me.PN_Entrada.Size = New System.Drawing.Size(890, 600)
        Me.PN_Entrada.TabIndex = 67
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
        Me.GroupBox2.Location = New System.Drawing.Point(598, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 41)
        Me.GroupBox2.TabIndex = 65
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
        'ToolStripDropDownButton7
        '
        Me.ToolStripDropDownButton7.AutoSize = False
        Me.ToolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosToolStripMenuItem})
        Me.ToolStripDropDownButton7.Image = CType(resources.GetObject("ToolStripDropDownButton7.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton7.Name = "ToolStripDropDownButton7"
        Me.ToolStripDropDownButton7.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton7.Text = "Egreso y Pedido"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'BO_Caja
        '
        Me.BO_Caja.Image = CType(resources.GetObject("BO_Caja.Image"), System.Drawing.Image)
        Me.BO_Caja.Location = New System.Drawing.Point(547, 5)
        Me.BO_Caja.Name = "BO_Caja"
        Me.BO_Caja.Size = New System.Drawing.Size(45, 45)
        Me.BO_Caja.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.BO_Caja, "Caja")
        Me.BO_Caja.UseVisualStyleBackColor = True
        Me.BO_Caja.Visible = False
        '
        'BO_TurnoConsulta
        '
        Me.BO_TurnoConsulta.Image = CType(resources.GetObject("BO_TurnoConsulta.Image"), System.Drawing.Image)
        Me.BO_TurnoConsulta.Location = New System.Drawing.Point(496, 5)
        Me.BO_TurnoConsulta.Name = "BO_TurnoConsulta"
        Me.BO_TurnoConsulta.Size = New System.Drawing.Size(45, 45)
        Me.BO_TurnoConsulta.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.BO_TurnoConsulta, "Consulta de Turno")
        Me.BO_TurnoConsulta.UseVisualStyleBackColor = True
        Me.BO_TurnoConsulta.Visible = False
        '
        'Timer1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripDropDownButton7})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 57)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(81, 71)
        Me.ToolStrip1.TabIndex = 68
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(79, 6)
        '
        'US_Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BO_USU_cerrar)
        Me.Controls.Add(Me.PN_Entrada)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BO_Caja)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BO_TurnoConsulta)
        Me.Name = "US_Pedidos"
        Me.Text = "Sistema de Gestion de Ventas - HAMERSOFT"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BO_USU_cerrar As System.Windows.Forms.Button
    Friend WithEvents PN_Entrada As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BO_USU_contrasena As System.Windows.Forms.Button
    Friend WithEvents BO_USU_sesion As System.Windows.Forms.Button
    Friend WithEvents LB_UT_dep As System.Windows.Forms.Label
    Friend WithEvents LB_USU_ape As System.Windows.Forms.Label
    Friend WithEvents ToolStripDropDownButton7 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BO_Caja As System.Windows.Forms.Button
    Friend WithEvents BO_TurnoConsulta As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
