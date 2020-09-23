<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Egresos_Alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Egresos_Alta))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GP_otro = New System.Windows.Forms.GroupBox()
        Me.tx_DetOtro = New System.Windows.Forms.TextBox()
        Me.BO_Servicio = New System.Windows.Forms.Button()
        Me.GP_Detalle = New System.Windows.Forms.GroupBox()
        Me.Combo_Detalle = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Combo_Gasto = New System.Windows.Forms.ComboBox()
        Me.ERROR_tx_NumComp = New System.Windows.Forms.PictureBox()
        Me.ERROR_tx_Monto = New System.Windows.Forms.PictureBox()
        Me.DT_EG_fechaComp = New System.Windows.Forms.DateTimePicker()
        Me.DT_EG_fecha = New System.Windows.Forms.DateTimePicker()
        Me.tx_NumComp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_Monto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bt_Cancelar = New System.Windows.Forms.Button()
        Me.Bt_Guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GP_otro.SuspendLayout()
        Me.GP_Detalle.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ERROR_tx_NumComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ERROR_tx_Monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(866, 225)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(858, 199)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Egreso: Nuevo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GP_otro)
        Me.GroupBox1.Controls.Add(Me.BO_Servicio)
        Me.GroupBox1.Controls.Add(Me.GP_Detalle)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_NumComp)
        Me.GroupBox1.Controls.Add(Me.ERROR_tx_Monto)
        Me.GroupBox1.Controls.Add(Me.DT_EG_fechaComp)
        Me.GroupBox1.Controls.Add(Me.DT_EG_fecha)
        Me.GroupBox1.Controls.Add(Me.tx_NumComp)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tx_Monto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GP_otro
        '
        Me.GP_otro.Controls.Add(Me.tx_DetOtro)
        Me.GP_otro.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_otro.Location = New System.Drawing.Point(591, 25)
        Me.GP_otro.Name = "GP_otro"
        Me.GP_otro.Size = New System.Drawing.Size(222, 61)
        Me.GP_otro.TabIndex = 298
        Me.GP_otro.TabStop = False
        Me.GP_otro.Text = "Otro Egreso"
        Me.GP_otro.Visible = False
        '
        'tx_DetOtro
        '
        Me.tx_DetOtro.Location = New System.Drawing.Point(6, 25)
        Me.tx_DetOtro.Name = "tx_DetOtro"
        Me.tx_DetOtro.Size = New System.Drawing.Size(210, 20)
        Me.tx_DetOtro.TabIndex = 293
        '
        'BO_Servicio
        '
        Me.BO_Servicio.Image = CType(resources.GetObject("BO_Servicio.Image"), System.Drawing.Image)
        Me.BO_Servicio.Location = New System.Drawing.Point(553, 46)
        Me.BO_Servicio.Name = "BO_Servicio"
        Me.BO_Servicio.Size = New System.Drawing.Size(30, 30)
        Me.BO_Servicio.TabIndex = 297
        Me.ToolTip1.SetToolTip(Me.BO_Servicio, "Agregar")
        Me.BO_Servicio.UseVisualStyleBackColor = True
        Me.BO_Servicio.Visible = False
        '
        'GP_Detalle
        '
        Me.GP_Detalle.Controls.Add(Me.Combo_Detalle)
        Me.GP_Detalle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_Detalle.Location = New System.Drawing.Point(270, 25)
        Me.GP_Detalle.Name = "GP_Detalle"
        Me.GP_Detalle.Size = New System.Drawing.Size(277, 61)
        Me.GP_Detalle.TabIndex = 296
        Me.GP_Detalle.TabStop = False
        '
        'Combo_Detalle
        '
        Me.Combo_Detalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Detalle.FormattingEnabled = True
        Me.Combo_Detalle.Location = New System.Drawing.Point(6, 25)
        Me.Combo_Detalle.Name = "Combo_Detalle"
        Me.Combo_Detalle.Size = New System.Drawing.Size(261, 21)
        Me.Combo_Detalle.TabIndex = 290
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Combo_Gasto)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(23, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 61)
        Me.GroupBox2.TabIndex = 295
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Egreso"
        '
        'Combo_Gasto
        '
        Me.Combo_Gasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Gasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Combo_Gasto.FormattingEnabled = True
        Me.Combo_Gasto.Location = New System.Drawing.Point(15, 25)
        Me.Combo_Gasto.Name = "Combo_Gasto"
        Me.Combo_Gasto.Size = New System.Drawing.Size(196, 23)
        Me.Combo_Gasto.TabIndex = 289
        '
        'ERROR_tx_NumComp
        '
        Me.ERROR_tx_NumComp.Image = CType(resources.GetObject("ERROR_tx_NumComp.Image"), System.Drawing.Image)
        Me.ERROR_tx_NumComp.Location = New System.Drawing.Point(698, 146)
        Me.ERROR_tx_NumComp.Name = "ERROR_tx_NumComp"
        Me.ERROR_tx_NumComp.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_NumComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_NumComp.TabIndex = 292
        Me.ERROR_tx_NumComp.TabStop = False
        Me.ERROR_tx_NumComp.Visible = False
        '
        'ERROR_tx_Monto
        '
        Me.ERROR_tx_Monto.Image = CType(resources.GetObject("ERROR_tx_Monto.Image"), System.Drawing.Image)
        Me.ERROR_tx_Monto.Location = New System.Drawing.Point(265, 144)
        Me.ERROR_tx_Monto.Name = "ERROR_tx_Monto"
        Me.ERROR_tx_Monto.Size = New System.Drawing.Size(16, 16)
        Me.ERROR_tx_Monto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ERROR_tx_Monto.TabIndex = 273
        Me.ERROR_tx_Monto.TabStop = False
        Me.ERROR_tx_Monto.Visible = False
        '
        'DT_EG_fechaComp
        '
        Me.DT_EG_fechaComp.Location = New System.Drawing.Point(553, 106)
        Me.DT_EG_fechaComp.Name = "DT_EG_fechaComp"
        Me.DT_EG_fechaComp.Size = New System.Drawing.Size(220, 20)
        Me.DT_EG_fechaComp.TabIndex = 291
        '
        'DT_EG_fecha
        '
        Me.DT_EG_fecha.Location = New System.Drawing.Point(150, 102)
        Me.DT_EG_fecha.Name = "DT_EG_fecha"
        Me.DT_EG_fecha.Size = New System.Drawing.Size(220, 20)
        Me.DT_EG_fecha.TabIndex = 239
        '
        'tx_NumComp
        '
        Me.tx_NumComp.Location = New System.Drawing.Point(553, 142)
        Me.tx_NumComp.Name = "tx_NumComp"
        Me.tx_NumComp.Size = New System.Drawing.Size(139, 20)
        Me.tx_NumComp.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(401, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 15)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Fecha de Comprobante"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(398, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 15)
        Me.Label5.TabIndex = 278
        Me.Label5.Text = "Numero De Comprobante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(35, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 277
        Me.Label4.Text = "Fecha de Egreso"
        '
        'tx_Monto
        '
        Me.tx_Monto.Location = New System.Drawing.Point(147, 142)
        Me.tx_Monto.Name = "tx_Monto"
        Me.tx_Monto.Size = New System.Drawing.Size(112, 20)
        Me.tx_Monto.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(32, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 275
        Me.Label3.Text = "Monto de Egreso"
        '
        'Bt_Cancelar
        '
        Me.Bt_Cancelar.Image = CType(resources.GetObject("Bt_Cancelar.Image"), System.Drawing.Image)
        Me.Bt_Cancelar.Location = New System.Drawing.Point(788, 239)
        Me.Bt_Cancelar.Name = "Bt_Cancelar"
        Me.Bt_Cancelar.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Cancelar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Bt_Cancelar, "Cancelar")
        Me.Bt_Cancelar.UseVisualStyleBackColor = True
        '
        'Bt_Guardar
        '
        Me.Bt_Guardar.Image = CType(resources.GetObject("Bt_Guardar.Image"), System.Drawing.Image)
        Me.Bt_Guardar.Location = New System.Drawing.Point(834, 239)
        Me.Bt_Guardar.Name = "Bt_Guardar"
        Me.Bt_Guardar.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Guardar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Bt_Guardar, "Guardar")
        Me.Bt_Guardar.UseVisualStyleBackColor = True
        '
        'Egresos_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.Bt_Cancelar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Bt_Guardar)
        Me.Name = "Egresos_Alta"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GP_otro.ResumeLayout(False)
        Me.GP_otro.PerformLayout()
        Me.GP_Detalle.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ERROR_tx_NumComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ERROR_tx_Monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Bt_Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Combo_Detalle As System.Windows.Forms.ComboBox
    Friend WithEvents Combo_Gasto As System.Windows.Forms.ComboBox
    Friend WithEvents tx_NumComp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tx_Monto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DT_EG_fechaComp As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_EG_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ERROR_tx_NumComp As System.Windows.Forms.PictureBox
    Friend WithEvents ERROR_tx_Monto As System.Windows.Forms.PictureBox
    Friend WithEvents tx_DetOtro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents GP_otro As System.Windows.Forms.GroupBox
    Friend WithEvents BO_Servicio As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
