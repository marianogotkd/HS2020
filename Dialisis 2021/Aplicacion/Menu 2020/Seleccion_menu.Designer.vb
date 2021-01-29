<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccion_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seleccion_menu))
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BO_USU_sesion = New System.Windows.Forms.Button()
        Me.BO_USU_cerrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panelcentral = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.LB_USU_inv = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_USU_cont = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_USU_usu = New System.Windows.Forms.TextBox()
        Me.PanelCabecera.SuspendLayout()
        Me.Panelcentral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelCabecera.Controls.Add(Me.Label3)
        Me.PanelCabecera.Controls.Add(Me.btn_minimizar)
        Me.PanelCabecera.Controls.Add(Me.btn_cerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(745, 40)
        Me.PanelCabecera.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 15)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "BIENVENIDO A HAMERSOFT SISTEMA DE GESTION"
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
        Me.btn_minimizar.Location = New System.Drawing.Point(655, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_minimizar.TabIndex = 96
        Me.ToolTip1.SetToolTip(Me.btn_minimizar, "Minimizar")
        Me.btn_minimizar.UseVisualStyleBackColor = True
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
        Me.btn_cerrar.Location = New System.Drawing.Point(701, 1)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cerrar.TabIndex = 96
        Me.ToolTip1.SetToolTip(Me.btn_cerrar, "Cerrar")
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'BO_USU_sesion
        '
        Me.BO_USU_sesion.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BO_USU_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BO_USU_sesion.Image = Global.Aplicacion.My.Resources.Resources.CargarDato
        Me.BO_USU_sesion.Location = New System.Drawing.Point(642, 55)
        Me.BO_USU_sesion.Margin = New System.Windows.Forms.Padding(6)
        Me.BO_USU_sesion.Name = "BO_USU_sesion"
        Me.BO_USU_sesion.Size = New System.Drawing.Size(55, 55)
        Me.BO_USU_sesion.TabIndex = 97
        Me.BO_USU_sesion.Tag = ""
        Me.ToolTip1.SetToolTip(Me.BO_USU_sesion, "Ingresar")
        Me.BO_USU_sesion.UseVisualStyleBackColor = True
        '
        'BO_USU_cerrar
        '
        Me.BO_USU_cerrar.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BO_USU_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BO_USU_cerrar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.BO_USU_cerrar.Location = New System.Drawing.Point(642, 121)
        Me.BO_USU_cerrar.Margin = New System.Windows.Forms.Padding(6)
        Me.BO_USU_cerrar.Name = "BO_USU_cerrar"
        Me.BO_USU_cerrar.Size = New System.Drawing.Size(55, 55)
        Me.BO_USU_cerrar.TabIndex = 98
        Me.ToolTip1.SetToolTip(Me.BO_USU_cerrar, "Cancelar")
        Me.BO_USU_cerrar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(15, 249)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(730, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(15, 249)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(15, 274)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(715, 15)
        Me.Panel4.TabIndex = 2
        '
        'Panelcentral
        '
        Me.Panelcentral.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panelcentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panelcentral.Controls.Add(Me.BO_USU_sesion)
        Me.Panelcentral.Controls.Add(Me.BO_USU_cerrar)
        Me.Panelcentral.Controls.Add(Me.PictureBox1)
        Me.Panelcentral.Controls.Add(Me.GroupBox1)
        Me.Panelcentral.Location = New System.Drawing.Point(15, 40)
        Me.Panelcentral.Name = "Panelcentral"
        Me.Panelcentral.Size = New System.Drawing.Size(715, 234)
        Me.Panelcentral.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 96
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.IM_ERROR)
        Me.GroupBox1.Controls.Add(Me.LB_USU_inv)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TB_USU_cont)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TB_USU_usu)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(204, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(426, 185)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sesion de usuario:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Santa Fe", "Dialisis"})
        Me.ComboBox1.Location = New System.Drawing.Point(119, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(298, 28)
        Me.ComboBox1.TabIndex = 239
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "Software:"
        '
        'IM_ERROR
        '
        Me.IM_ERROR.BackColor = System.Drawing.Color.Transparent
        Me.IM_ERROR.Image = Global.Aplicacion.My.Resources.Resources.Borrar2
        Me.IM_ERROR.Location = New System.Drawing.Point(188, 135)
        Me.IM_ERROR.Margin = New System.Windows.Forms.Padding(6)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(30, 30)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 237
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'LB_USU_inv
        '
        Me.LB_USU_inv.AutoSize = True
        Me.LB_USU_inv.BackColor = System.Drawing.Color.Transparent
        Me.LB_USU_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_USU_inv.ForeColor = System.Drawing.Color.Yellow
        Me.LB_USU_inv.Location = New System.Drawing.Point(219, 142)
        Me.LB_USU_inv.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LB_USU_inv.Name = "LB_USU_inv"
        Me.LB_USU_inv.Size = New System.Drawing.Size(198, 17)
        Me.LB_USU_inv.TabIndex = 236
        Me.LB_USU_inv.Text = "Usuario o Contraseña Inválida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Contraseña:"
        '
        'TB_USU_cont
        '
        Me.TB_USU_cont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USU_cont.Location = New System.Drawing.Point(119, 91)
        Me.TB_USU_cont.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_USU_cont.Name = "TB_USU_cont"
        Me.TB_USU_cont.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_USU_cont.Size = New System.Drawing.Size(298, 26)
        Me.TB_USU_cont.TabIndex = 2
        Me.TB_USU_cont.Tag = ""
        Me.TB_USU_cont.UseSystemPasswordChar = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(15, 65)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 20)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Usuario:"
        '
        'TB_USU_usu
        '
        Me.TB_USU_usu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USU_usu.Location = New System.Drawing.Point(119, 59)
        Me.TB_USU_usu.Margin = New System.Windows.Forms.Padding(6)
        Me.TB_USU_usu.Name = "TB_USU_usu"
        Me.TB_USU_usu.Size = New System.Drawing.Size(298, 26)
        Me.TB_USU_usu.TabIndex = 0
        Me.TB_USU_usu.Tag = ""
        '
        'Seleccion_menu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(745, 289)
        Me.Controls.Add(Me.Panelcentral)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Seleccion_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion_menu"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panelcentral.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelCabecera As System.Windows.Forms.Panel
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_minimizar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panelcentral As System.Windows.Forms.Panel
    Friend WithEvents BO_USU_sesion As System.Windows.Forms.Button
    Friend WithEvents BO_USU_cerrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents LB_USU_inv As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_USU_cont As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TB_USU_usu As System.Windows.Forms.TextBox
End Class
