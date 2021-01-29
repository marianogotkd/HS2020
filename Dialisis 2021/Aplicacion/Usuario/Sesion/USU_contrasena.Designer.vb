<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USU_contrasena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USU_contrasena))
        Me.Panelcabecera = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.Panelcontenido = New System.Windows.Forms.Panel()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.LB_ERROR = New System.Windows.Forms.Label()
        Me.BOT_ingresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TX_USU_cont_rnue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_USU_cont_nue = New System.Windows.Forms.TextBox()
        Me.TX_USU_cont = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IM_OK = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panelcabecera.SuspendLayout()
        Me.Panelcontenido.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IM_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelcabecera
        '
        Me.Panelcabecera.BackColor = System.Drawing.Color.Goldenrod
        Me.Panelcabecera.Controls.Add(Me.Label5)
        Me.Panelcabecera.Controls.Add(Me.btn_minimizar)
        Me.Panelcabecera.Controls.Add(Me.btn_cerrar)
        Me.Panelcabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelcabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panelcabecera.Name = "Panelcabecera"
        Me.Panelcabecera.Size = New System.Drawing.Size(590, 40)
        Me.Panelcabecera.TabIndex = 240
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
        Me.btn_cerrar.Location = New System.Drawing.Point(547, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cerrar.TabIndex = 97
        Me.btn_cerrar.UseVisualStyleBackColor = True
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
        Me.btn_minimizar.Location = New System.Drawing.Point(501, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_minimizar.TabIndex = 98
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'Panelcontenido
        '
        Me.Panelcontenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panelcontenido.Controls.Add(Me.IM_ERROR)
        Me.Panelcontenido.Controls.Add(Me.LB_ERROR)
        Me.Panelcontenido.Controls.Add(Me.BOT_ingresar)
        Me.Panelcontenido.Controls.Add(Me.GroupBox1)
        Me.Panelcontenido.Controls.Add(Me.PictureBox1)
        Me.Panelcontenido.Controls.Add(Me.IM_OK)
        Me.Panelcontenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelcontenido.Location = New System.Drawing.Point(0, 40)
        Me.Panelcontenido.Name = "Panelcontenido"
        Me.Panelcontenido.Size = New System.Drawing.Size(590, 239)
        Me.Panelcontenido.TabIndex = 241
        '
        'IM_ERROR
        '
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(303, 188)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 244
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'LB_ERROR
        '
        Me.LB_ERROR.AutoSize = True
        Me.LB_ERROR.BackColor = System.Drawing.Color.Transparent
        Me.LB_ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR.ForeColor = System.Drawing.Color.Yellow
        Me.LB_ERROR.Location = New System.Drawing.Point(328, 191)
        Me.LB_ERROR.Name = "LB_ERROR"
        Me.LB_ERROR.Size = New System.Drawing.Size(199, 20)
        Me.LB_ERROR.TabIndex = 243
        Me.LB_ERROR.Text = "Contraseña Actual Inválida"
        '
        'BOT_ingresar
        '
        Me.BOT_ingresar.Image = CType(resources.GetObject("BOT_ingresar.Image"), System.Drawing.Image)
        Me.BOT_ingresar.Location = New System.Drawing.Point(531, 185)
        Me.BOT_ingresar.Name = "BOT_ingresar"
        Me.BOT_ingresar.Size = New System.Drawing.Size(32, 32)
        Me.BOT_ingresar.TabIndex = 242
        Me.BOT_ingresar.Tag = "3"
        Me.ToolTip1.SetToolTip(Me.BOT_ingresar, "Confirmar cambios")
        Me.BOT_ingresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TX_USU_cont_rnue)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TX_USU_cont_nue)
        Me.GroupBox1.Controls.Add(Me.TX_USU_cont)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(125, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 161)
        Me.GroupBox1.TabIndex = 241
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sesión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "(Repetir)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Contraseña Nueva"
        '
        'TX_USU_cont_rnue
        '
        Me.TX_USU_cont_rnue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_cont_rnue.Location = New System.Drawing.Point(163, 104)
        Me.TX_USU_cont_rnue.Name = "TX_USU_cont_rnue"
        Me.TX_USU_cont_rnue.Size = New System.Drawing.Size(224, 26)
        Me.TX_USU_cont_rnue.TabIndex = 75
        Me.TX_USU_cont_rnue.Tag = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Contraseña Actual"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Contraseña Nueva"
        '
        'TX_USU_cont_nue
        '
        Me.TX_USU_cont_nue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_cont_nue.Location = New System.Drawing.Point(163, 60)
        Me.TX_USU_cont_nue.Name = "TX_USU_cont_nue"
        Me.TX_USU_cont_nue.Size = New System.Drawing.Size(224, 26)
        Me.TX_USU_cont_nue.TabIndex = 72
        Me.TX_USU_cont_nue.Tag = "2"
        '
        'TX_USU_cont
        '
        Me.TX_USU_cont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_USU_cont.Location = New System.Drawing.Point(163, 21)
        Me.TX_USU_cont.Name = "TX_USU_cont"
        Me.TX_USU_cont.Size = New System.Drawing.Size(224, 26)
        Me.TX_USU_cont.TabIndex = 70
        Me.TX_USU_cont.Tag = "1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 240
        Me.PictureBox1.TabStop = False
        '
        'IM_OK
        '
        Me.IM_OK.Image = CType(resources.GetObject("IM_OK.Image"), System.Drawing.Image)
        Me.IM_OK.Location = New System.Drawing.Point(303, 188)
        Me.IM_OK.Name = "IM_OK"
        Me.IM_OK.Size = New System.Drawing.Size(20, 20)
        Me.IM_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_OK.TabIndex = 245
        Me.IM_OK.TabStop = False
        Me.IM_OK.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 15)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "CAMBIO DE CONTRASEÑA - HAMERSOFT"
        '
        'USU_contrasena
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(590, 279)
        Me.Controls.Add(Me.Panelcontenido)
        Me.Controls.Add(Me.Panelcabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "USU_contrasena"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de contraseña"
        Me.TopMost = True
        Me.Panelcabecera.ResumeLayout(False)
        Me.Panelcabecera.PerformLayout()
        Me.Panelcontenido.ResumeLayout(False)
        Me.Panelcontenido.PerformLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IM_OK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panelcabecera As System.Windows.Forms.Panel
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_minimizar As System.Windows.Forms.Button
    Friend WithEvents Panelcontenido As System.Windows.Forms.Panel
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents LB_ERROR As System.Windows.Forms.Label
    Friend WithEvents BOT_ingresar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TX_USU_cont_rnue As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TX_USU_cont_nue As System.Windows.Forms.TextBox
    Friend WithEvents TX_USU_cont As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents IM_OK As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
