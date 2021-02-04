<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajuste_alta
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btn_agregarr = New System.Windows.Forms.Button()
        Me.cb_proveedor = New System.Windows.Forms.ComboBox()
        Me.tb_Cant_Movi = New System.Windows.Forms.TextBox()
        Me.CheckBox_vto = New System.Windows.Forms.CheckBox()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.DateTimePicker_fvencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker_ffabricacion = New System.Windows.Forms.DateTimePicker()
        Me.txt_nrolote = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_contenido = New System.Windows.Forms.TextBox()
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
        Me.GroupBox4.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(591, 230)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Complete la información:"
        '
        'Grupo_lote
        '
        Me.Grupo_lote.BackColor = System.Drawing.Color.Transparent
        Me.Grupo_lote.Controls.Add(Me.txt_contenido)
        Me.Grupo_lote.Controls.Add(Me.Label1)
        Me.Grupo_lote.Controls.Add(Me.Label20)
        Me.Grupo_lote.Controls.Add(Me.btn_agregarr)
        Me.Grupo_lote.Controls.Add(Me.cb_proveedor)
        Me.Grupo_lote.Controls.Add(Me.tb_Cant_Movi)
        Me.Grupo_lote.Controls.Add(Me.CheckBox_vto)
        Me.Grupo_lote.Controls.Add(Me.lbl_cant)
        Me.Grupo_lote.Controls.Add(Me.DateTimePicker_fvencimiento)
        Me.Grupo_lote.Controls.Add(Me.Label11)
        Me.Grupo_lote.Controls.Add(Me.DateTimePicker_ffabricacion)
        Me.Grupo_lote.Controls.Add(Me.txt_nrolote)
        Me.Grupo_lote.Controls.Add(Me.Label12)
        Me.Grupo_lote.Controls.Add(Me.Label13)
        Me.Grupo_lote.Location = New System.Drawing.Point(6, 18)
        Me.Grupo_lote.Name = "Grupo_lote"
        Me.Grupo_lote.Size = New System.Drawing.Size(575, 204)
        Me.Grupo_lote.TabIndex = 20
        Me.Grupo_lote.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 23)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 15)
        Me.Label20.TabIndex = 242
        Me.Label20.Text = "Proveedor"
        '
        'btn_agregarr
        '
        Me.btn_agregarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarr.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_agregarr.Location = New System.Drawing.Point(458, 156)
        Me.btn_agregarr.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregarr.Name = "btn_agregarr"
        Me.btn_agregarr.Size = New System.Drawing.Size(99, 41)
        Me.btn_agregarr.TabIndex = 249
        Me.btn_agregarr.Text = "Confirmar"
        Me.btn_agregarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_agregarr.UseVisualStyleBackColor = True
        '
        'cb_proveedor
        '
        Me.cb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_proveedor.FormattingEnabled = True
        Me.cb_proveedor.ItemHeight = 17
        Me.cb_proveedor.Items.AddRange(New Object() {"Alta de Mercaderia", "Baja de Mercaderia", "Movimiento Entre Sucursales"})
        Me.cb_proveedor.Location = New System.Drawing.Point(92, 19)
        Me.cb_proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_proveedor.Name = "cb_proveedor"
        Me.cb_proveedor.Size = New System.Drawing.Size(465, 25)
        Me.cb_proveedor.TabIndex = 241
        '
        'tb_Cant_Movi
        '
        Me.tb_Cant_Movi.BackColor = System.Drawing.SystemColors.Info
        Me.tb_Cant_Movi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.tb_Cant_Movi.Location = New System.Drawing.Point(419, 104)
        Me.tb_Cant_Movi.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Cant_Movi.MaxLength = 50
        Me.tb_Cant_Movi.Name = "tb_Cant_Movi"
        Me.tb_Cant_Movi.Size = New System.Drawing.Size(138, 32)
        Me.tb_Cant_Movi.TabIndex = 0
        Me.tb_Cant_Movi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox_vto
        '
        Me.CheckBox_vto.AutoSize = True
        Me.CheckBox_vto.Checked = True
        Me.CheckBox_vto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_vto.Location = New System.Drawing.Point(197, 64)
        Me.CheckBox_vto.Name = "CheckBox_vto"
        Me.CheckBox_vto.Size = New System.Drawing.Size(146, 17)
        Me.CheckBox_vto.TabIndex = 240
        Me.CheckBox_vto.Text = "Habilitar Vencimiento"
        Me.CheckBox_vto.UseVisualStyleBackColor = True
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant.Location = New System.Drawing.Point(275, 113)
        Me.lbl_cant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(137, 15)
        Me.lbl_cant.TabIndex = 13
        Me.lbl_cant.Text = "Cantidad a ingresar:"
        '
        'DateTimePicker_fvencimiento
        '
        Me.DateTimePicker_fvencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_fvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_fvencimiento.Location = New System.Drawing.Point(122, 134)
        Me.DateTimePicker_fvencimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_fvencimiento.Name = "DateTimePicker_fvencimiento"
        Me.DateTimePicker_fvencimiento.Size = New System.Drawing.Size(107, 22)
        Me.DateTimePicker_fvencimiento.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 114)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "F. Fabricación:"
        '
        'DateTimePicker_ffabricacion
        '
        Me.DateTimePicker_ffabricacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_ffabricacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_ffabricacion.Location = New System.Drawing.Point(122, 109)
        Me.DateTimePicker_ffabricacion.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_ffabricacion.Name = "DateTimePicker_ffabricacion"
        Me.DateTimePicker_ffabricacion.Size = New System.Drawing.Size(107, 22)
        Me.DateTimePicker_ffabricacion.TabIndex = 1
        '
        'txt_nrolote
        '
        Me.txt_nrolote.BackColor = System.Drawing.SystemColors.Info
        Me.txt_nrolote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nrolote.Location = New System.Drawing.Point(78, 62)
        Me.txt_nrolote.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nrolote.MinimumSize = New System.Drawing.Size(90, 30)
        Me.txt_nrolote.Name = "txt_nrolote"
        Me.txt_nrolote.ReadOnly = True
        Me.txt_nrolote.Size = New System.Drawing.Size(112, 26)
        Me.txt_nrolote.TabIndex = 0
        Me.txt_nrolote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 69)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Lote Nº:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 139)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "F. Vencimiento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 250
        Me.Label1.Text = "Contenido:"
        '
        'txt_contenido
        '
        Me.txt_contenido.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_contenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contenido.Location = New System.Drawing.Point(434, 58)
        Me.txt_contenido.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_contenido.MinimumSize = New System.Drawing.Size(90, 30)
        Me.txt_contenido.Name = "txt_contenido"
        Me.txt_contenido.ReadOnly = True
        Me.txt_contenido.Size = New System.Drawing.Size(123, 30)
        Me.txt_contenido.TabIndex = 251
        Me.txt_contenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ajuste_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 245)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ajuste_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste de Stock - Alta"
        Me.GroupBox4.ResumeLayout(False)
        Me.Grupo_lote.ResumeLayout(False)
        Me.Grupo_lote.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Grupo_lote As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_vto As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker_fvencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_ffabricacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nrolote As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_Cant_Movi As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents btn_agregarr As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txt_contenido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
