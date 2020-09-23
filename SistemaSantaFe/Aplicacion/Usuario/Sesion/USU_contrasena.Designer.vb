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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USU_contrasena))
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
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IM_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IM_ERROR
        '
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(164, 198)
        Me.IM_ERROR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 238
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'LB_ERROR
        '
        Me.LB_ERROR.AutoSize = True
        Me.LB_ERROR.BackColor = System.Drawing.Color.Transparent
        Me.LB_ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR.ForeColor = System.Drawing.Color.DarkRed
        Me.LB_ERROR.Location = New System.Drawing.Point(197, 202)
        Me.LB_ERROR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_ERROR.Name = "LB_ERROR"
        Me.LB_ERROR.Size = New System.Drawing.Size(181, 18)
        Me.LB_ERROR.TabIndex = 237
        Me.LB_ERROR.Text = "Contraseña Actual Invalida"
        '
        'BOT_ingresar
        '
        Me.BOT_ingresar.Image = CType(resources.GetObject("BOT_ingresar.Image"), System.Drawing.Image)
        Me.BOT_ingresar.Location = New System.Drawing.Point(468, 194)
        Me.BOT_ingresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BOT_ingresar.Name = "BOT_ingresar"
        Me.BOT_ingresar.Size = New System.Drawing.Size(43, 39)
        Me.BOT_ingresar.TabIndex = 236
        Me.BOT_ingresar.Tag = "3"
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
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(152, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(376, 178)
        Me.GroupBox1.TabIndex = 235
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sesión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(52, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "(Repetir)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(7, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Contraseña Nueva"
        '
        'TX_USU_cont_rnue
        '
        Me.TX_USU_cont_rnue.Location = New System.Drawing.Point(176, 128)
        Me.TX_USU_cont_rnue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TX_USU_cont_rnue.Name = "TX_USU_cont_rnue"
        Me.TX_USU_cont_rnue.Size = New System.Drawing.Size(181, 22)
        Me.TX_USU_cont_rnue.TabIndex = 75
        Me.TX_USU_cont_rnue.Tag = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(8, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Contraseña Actual"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(7, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Contraseña Nueva"
        '
        'TX_USU_cont_nue
        '
        Me.TX_USU_cont_nue.Location = New System.Drawing.Point(176, 78)
        Me.TX_USU_cont_nue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TX_USU_cont_nue.Name = "TX_USU_cont_nue"
        Me.TX_USU_cont_nue.Size = New System.Drawing.Size(181, 22)
        Me.TX_USU_cont_nue.TabIndex = 72
        Me.TX_USU_cont_nue.Tag = "2"
        '
        'TX_USU_cont
        '
        Me.TX_USU_cont.Location = New System.Drawing.Point(176, 30)
        Me.TX_USU_cont.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TX_USU_cont.Name = "TX_USU_cont"
        Me.TX_USU_cont.Size = New System.Drawing.Size(181, 22)
        Me.TX_USU_cont.TabIndex = 70
        Me.TX_USU_cont.Tag = "1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 44)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 234
        Me.PictureBox1.TabStop = False
        '
        'IM_OK
        '
        Me.IM_OK.Image = CType(resources.GetObject("IM_OK.Image"), System.Drawing.Image)
        Me.IM_OK.Location = New System.Drawing.Point(164, 198)
        Me.IM_OK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IM_OK.Name = "IM_OK"
        Me.IM_OK.Size = New System.Drawing.Size(20, 20)
        Me.IM_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_OK.TabIndex = 239
        Me.IM_OK.TabStop = False
        Me.IM_OK.Visible = False
        '
        'USU_contrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(544, 250)
        Me.Controls.Add(Me.IM_ERROR)
        Me.Controls.Add(Me.LB_ERROR)
        Me.Controls.Add(Me.BOT_ingresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.IM_OK)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "USU_contrasena"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de contraseña"
        Me.TopMost = True
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IM_OK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
End Class
