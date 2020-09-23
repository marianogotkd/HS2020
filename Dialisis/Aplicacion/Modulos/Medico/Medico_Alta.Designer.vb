<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medico_Alta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_mat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.err_mat = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.err_esp = New System.Windows.Forms.Label()
        Me.Tb_esp = New System.Windows.Forms.TextBox()
        Me.error_dni = New System.Windows.Forms.Label()
        Me.err_nom = New System.Windows.Forms.Label()
        Me.tb_Dni_Cuit = New System.Windows.Forms.TextBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_nom_ape = New System.Windows.Forms.TextBox()
        Me.lb_dni = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tb_mat)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.err_mat)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.err_esp)
        Me.GroupBox1.Controls.Add(Me.Tb_esp)
        Me.GroupBox1.Controls.Add(Me.error_dni)
        Me.GroupBox1.Controls.Add(Me.err_nom)
        Me.GroupBox1.Controls.Add(Me.tb_Dni_Cuit)
        Me.GroupBox1.Controls.Add(Me.btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tx_nom_ape)
        Me.GroupBox1.Controls.Add(Me.lb_dni)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 271)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los datos personales del Medico"
        '
        'tb_mat
        '
        Me.tb_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_mat.Location = New System.Drawing.Point(183, 149)
        Me.tb_mat.Name = "tb_mat"
        Me.tb_mat.Size = New System.Drawing.Size(337, 26)
        Me.tb_mat.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 20)
        Me.Label12.TabIndex = 270
        Me.Label12.Text = "N° de Matricula"
        '
        'err_mat
        '
        Me.err_mat.AutoSize = True
        Me.err_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_mat.ForeColor = System.Drawing.Color.Red
        Me.err_mat.Location = New System.Drawing.Point(528, 149)
        Me.err_mat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.err_mat.Name = "err_mat"
        Me.err_mat.Size = New System.Drawing.Size(26, 31)
        Me.err_mat.TabIndex = 269
        Me.err_mat.Text = "*"
        Me.err_mat.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 267
        Me.Label10.Text = "Especialidad"
        '
        'err_esp
        '
        Me.err_esp.AutoSize = True
        Me.err_esp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_esp.ForeColor = System.Drawing.Color.Red
        Me.err_esp.Location = New System.Drawing.Point(529, 114)
        Me.err_esp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.err_esp.Name = "err_esp"
        Me.err_esp.Size = New System.Drawing.Size(26, 31)
        Me.err_esp.TabIndex = 266
        Me.err_esp.Text = "*"
        Me.err_esp.Visible = False
        '
        'Tb_esp
        '
        Me.Tb_esp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_esp.Location = New System.Drawing.Point(183, 117)
        Me.Tb_esp.Name = "Tb_esp"
        Me.Tb_esp.Size = New System.Drawing.Size(337, 26)
        Me.Tb_esp.TabIndex = 2
        '
        'error_dni
        '
        Me.error_dni.AutoSize = True
        Me.error_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_dni.ForeColor = System.Drawing.Color.Red
        Me.error_dni.Location = New System.Drawing.Point(528, 80)
        Me.error_dni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_dni.Name = "error_dni"
        Me.error_dni.Size = New System.Drawing.Size(26, 31)
        Me.error_dni.TabIndex = 264
        Me.error_dni.Text = "*"
        Me.error_dni.Visible = False
        '
        'err_nom
        '
        Me.err_nom.AutoSize = True
        Me.err_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_nom.ForeColor = System.Drawing.Color.Red
        Me.err_nom.Location = New System.Drawing.Point(529, 53)
        Me.err_nom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.err_nom.Name = "err_nom"
        Me.err_nom.Size = New System.Drawing.Size(26, 31)
        Me.err_nom.TabIndex = 263
        Me.err_nom.Text = "*"
        Me.err_nom.Visible = False
        '
        'tb_Dni_Cuit
        '
        Me.tb_Dni_Cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Dni_Cuit.Location = New System.Drawing.Point(183, 85)
        Me.tb_Dni_Cuit.Name = "tb_Dni_Cuit"
        Me.tb_Dni_Cuit.Size = New System.Drawing.Size(337, 26)
        Me.tb_Dni_Cuit.TabIndex = 1
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Cancelar.Location = New System.Drawing.Point(362, 203)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(492, 203)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Aceptar.TabIndex = 4
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 253
        Me.Label4.Text = "Nombre y Apellido"
        '
        'tx_nom_ape
        '
        Me.tx_nom_ape.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_nom_ape.Location = New System.Drawing.Point(183, 53)
        Me.tx_nom_ape.Name = "tx_nom_ape"
        Me.tx_nom_ape.Size = New System.Drawing.Size(337, 26)
        Me.tx_nom_ape.TabIndex = 0
        '
        'lb_dni
        '
        Me.lb_dni.AutoSize = True
        Me.lb_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni.ForeColor = System.Drawing.Color.Black
        Me.lb_dni.Location = New System.Drawing.Point(6, 85)
        Me.lb_dni.Name = "lb_dni"
        Me.lb_dni.Size = New System.Drawing.Size(110, 20)
        Me.lb_dni.TabIndex = 237
        Me.lb_dni.Text = "DNI / N° CUIT:"
        '
        'Medico_Alta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(645, 287)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Medico_Alta"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Medico "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_mat As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents err_mat As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents err_esp As System.Windows.Forms.Label
    Friend WithEvents Tb_esp As System.Windows.Forms.TextBox
    Friend WithEvents error_dni As System.Windows.Forms.Label
    Friend WithEvents err_nom As System.Windows.Forms.Label
    Friend WithEvents tb_Dni_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tx_nom_ape As System.Windows.Forms.TextBox
    Friend WithEvents lb_dni As System.Windows.Forms.Label
End Class
