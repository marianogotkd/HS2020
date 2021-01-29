<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtaCte_pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtaCte_pago))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_tarjeta = New System.Windows.Forms.RadioButton()
        Me.RadioButton_efectivo = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_total = New System.Windows.Forms.TextBox()
        Me.tx_comprobante = New System.Windows.Forms.TextBox()
        Me.tx_tarjeta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton_tarjeta)
        Me.GroupBox1.Controls.Add(Me.RadioButton_efectivo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione forma de pago:"
        '
        'RadioButton_tarjeta
        '
        Me.RadioButton_tarjeta.AutoSize = True
        Me.RadioButton_tarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_tarjeta.Location = New System.Drawing.Point(15, 57)
        Me.RadioButton_tarjeta.Name = "RadioButton_tarjeta"
        Me.RadioButton_tarjeta.Size = New System.Drawing.Size(87, 24)
        Me.RadioButton_tarjeta.TabIndex = 1
        Me.RadioButton_tarjeta.Text = "Tarjeta:"
        Me.RadioButton_tarjeta.UseVisualStyleBackColor = True
        '
        'RadioButton_efectivo
        '
        Me.RadioButton_efectivo.AutoSize = True
        Me.RadioButton_efectivo.Checked = True
        Me.RadioButton_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_efectivo.Location = New System.Drawing.Point(15, 30)
        Me.RadioButton_efectivo.Name = "RadioButton_efectivo"
        Me.RadioButton_efectivo.Size = New System.Drawing.Size(95, 24)
        Me.RadioButton_efectivo.TabIndex = 0
        Me.RadioButton_efectivo.TabStop = True
        Me.RadioButton_efectivo.Text = "Efectivo:"
        Me.RadioButton_efectivo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tx_total)
        Me.Panel1.Controls.Add(Me.tx_comprobante)
        Me.Panel1.Controls.Add(Me.tx_tarjeta)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(13, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 141)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MONTO TOTAL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nº DE TARJETA:"
        '
        'tx_total
        '
        Me.tx_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_total.Location = New System.Drawing.Point(226, 93)
        Me.tx_total.Name = "tx_total"
        Me.tx_total.Size = New System.Drawing.Size(219, 30)
        Me.tx_total.TabIndex = 2
        Me.tx_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_comprobante
        '
        Me.tx_comprobante.Enabled = False
        Me.tx_comprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_comprobante.Location = New System.Drawing.Point(226, 55)
        Me.tx_comprobante.Name = "tx_comprobante"
        Me.tx_comprobante.Size = New System.Drawing.Size(219, 30)
        Me.tx_comprobante.TabIndex = 1
        Me.tx_comprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_tarjeta
        '
        Me.tx_tarjeta.Enabled = False
        Me.tx_tarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_tarjeta.Location = New System.Drawing.Point(226, 11)
        Me.tx_tarjeta.Name = "tx_tarjeta"
        Me.tx_tarjeta.Size = New System.Drawing.Size(219, 30)
        Me.tx_tarjeta.TabIndex = 0
        Me.tx_tarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nº COMPROBANTE:"
        '
        'BO_guardar
        '
        Me.BO_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(395, 252)
        Me.BO_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(105, 39)
        Me.BO_guardar.TabIndex = 5
        Me.BO_guardar.Text = "Cobrar"
        Me.BO_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(277, 252)
        Me.BO_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(110, 39)
        Me.BO_Eliminar.TabIndex = 6
        Me.BO_Eliminar.Text = "Cancelar"
        Me.BO_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'CtaCte_pago
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(508, 296)
        Me.Controls.Add(Me.BO_guardar)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(514, 331)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(514, 331)
        Me.Name = "CtaCte_pago"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_tarjeta As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_efectivo As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tx_total As System.Windows.Forms.TextBox
    Friend WithEvents tx_comprobante As System.Windows.Forms.TextBox
    Friend WithEvents tx_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
End Class
