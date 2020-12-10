<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajuste_suma_resta_igual
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Grupo_lote = New System.Windows.Forms.GroupBox()
        Me.tb_resultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_cant_actual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btn_agregarr = New System.Windows.Forms.Button()
        Me.cb_operacion = New System.Windows.Forms.ComboBox()
        Me.tb_nueva_cant = New System.Windows.Forms.TextBox()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.txt_nrolote = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.Grupo_lote.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Grupo_lote)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(591, 271)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Complete la información:"
        '
        'Grupo_lote
        '
        Me.Grupo_lote.BackColor = System.Drawing.Color.Transparent
        Me.Grupo_lote.Controls.Add(Me.tb_resultado)
        Me.Grupo_lote.Controls.Add(Me.Label2)
        Me.Grupo_lote.Controls.Add(Me.tb_cant_actual)
        Me.Grupo_lote.Controls.Add(Me.Label1)
        Me.Grupo_lote.Controls.Add(Me.Label20)
        Me.Grupo_lote.Controls.Add(Me.btn_agregarr)
        Me.Grupo_lote.Controls.Add(Me.cb_operacion)
        Me.Grupo_lote.Controls.Add(Me.tb_nueva_cant)
        Me.Grupo_lote.Controls.Add(Me.lbl_cant)
        Me.Grupo_lote.Controls.Add(Me.txt_nrolote)
        Me.Grupo_lote.Controls.Add(Me.Label12)
        Me.Grupo_lote.Location = New System.Drawing.Point(6, 18)
        Me.Grupo_lote.Name = "Grupo_lote"
        Me.Grupo_lote.Size = New System.Drawing.Size(575, 243)
        Me.Grupo_lote.TabIndex = 20
        Me.Grupo_lote.TabStop = False
        '
        'tb_resultado
        '
        Me.tb_resultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tb_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.tb_resultado.Location = New System.Drawing.Point(157, 193)
        Me.tb_resultado.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_resultado.MaxLength = 50
        Me.tb_resultado.Name = "tb_resultado"
        Me.tb_resultado.ReadOnly = True
        Me.tb_resultado.Size = New System.Drawing.Size(138, 32)
        Me.tb_resultado.TabIndex = 4
        Me.tb_resultado.Text = "0,00"
        Me.tb_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 203)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 253
        Me.Label2.Text = "Resultado:"
        '
        'tb_cant_actual
        '
        Me.tb_cant_actual.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tb_cant_actual.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.tb_cant_actual.Location = New System.Drawing.Point(156, 104)
        Me.tb_cant_actual.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_cant_actual.MaxLength = 50
        Me.tb_cant_actual.Name = "tb_cant_actual"
        Me.tb_cant_actual.ReadOnly = True
        Me.tb_cant_actual.Size = New System.Drawing.Size(138, 32)
        Me.tb_cant_actual.TabIndex = 2
        Me.tb_cant_actual.Text = "0,00"
        Me.tb_cant_actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 251
        Me.Label1.Text = "Cantidad actual:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 23)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(152, 15)
        Me.Label20.TabIndex = 242
        Me.Label20.Text = "Seleccione Operación:"
        '
        'btn_agregarr
        '
        Me.btn_agregarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarr.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_agregarr.Location = New System.Drawing.Point(458, 191)
        Me.btn_agregarr.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregarr.Name = "btn_agregarr"
        Me.btn_agregarr.Size = New System.Drawing.Size(99, 41)
        Me.btn_agregarr.TabIndex = 5
        Me.btn_agregarr.Text = "Confirmar"
        Me.btn_agregarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_agregarr.UseVisualStyleBackColor = True
        '
        'cb_operacion
        '
        Me.cb_operacion.BackColor = System.Drawing.SystemColors.Info
        Me.cb_operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_operacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_operacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_operacion.FormattingEnabled = True
        Me.cb_operacion.ItemHeight = 17
        Me.cb_operacion.Items.AddRange(New Object() {"SUMAR", "RESTAR", "IGUALAR"})
        Me.cb_operacion.Location = New System.Drawing.Point(172, 19)
        Me.cb_operacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_operacion.Name = "cb_operacion"
        Me.cb_operacion.Size = New System.Drawing.Size(385, 25)
        Me.cb_operacion.TabIndex = 0
        '
        'tb_nueva_cant
        '
        Me.tb_nueva_cant.BackColor = System.Drawing.SystemColors.Info
        Me.tb_nueva_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.tb_nueva_cant.Location = New System.Drawing.Point(156, 147)
        Me.tb_nueva_cant.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_nueva_cant.MaxLength = 50
        Me.tb_nueva_cant.Name = "tb_nueva_cant"
        Me.tb_nueva_cant.Size = New System.Drawing.Size(138, 32)
        Me.tb_nueva_cant.TabIndex = 3
        Me.tb_nueva_cant.Text = "0,00"
        Me.tb_nueva_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant.Location = New System.Drawing.Point(38, 157)
        Me.lbl_cant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(110, 15)
        Me.lbl_cant.TabIndex = 13
        Me.lbl_cant.Text = "Nueva cantidad:"
        '
        'txt_nrolote
        '
        Me.txt_nrolote.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_nrolote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nrolote.Location = New System.Drawing.Point(156, 63)
        Me.txt_nrolote.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nrolote.MinimumSize = New System.Drawing.Size(90, 30)
        Me.txt_nrolote.Name = "txt_nrolote"
        Me.txt_nrolote.ReadOnly = True
        Me.txt_nrolote.Size = New System.Drawing.Size(401, 26)
        Me.txt_nrolote.TabIndex = 1
        Me.txt_nrolote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(90, 69)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Lote Nº:"
        '
        'Ajuste_suma_resta_igual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(611, 291)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ajuste_suma_resta_igual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste de Stock - Sumar, Restar e Igualar"
        Me.GroupBox4.ResumeLayout(False)
        Me.Grupo_lote.ResumeLayout(False)
        Me.Grupo_lote.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Grupo_lote As System.Windows.Forms.GroupBox
    Friend WithEvents tb_resultado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_cant_actual As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btn_agregarr As System.Windows.Forms.Button
    Friend WithEvents cb_operacion As System.Windows.Forms.ComboBox
    Friend WithEvents tb_nueva_cant As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents txt_nrolote As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
