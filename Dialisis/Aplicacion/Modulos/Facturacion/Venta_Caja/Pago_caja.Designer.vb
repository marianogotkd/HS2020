<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pago_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pago_caja))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tx_total = New System.Windows.Forms.TextBox()
        Me.tx_parcial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "VUELTO:"
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(224, 172)
        Me.BO_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(110, 39)
        Me.BO_Eliminar.TabIndex = 41
        Me.BO_Eliminar.Text = "Cancelar"
        Me.BO_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Cancelar")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'BO_guardar
        '
        Me.BO_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(342, 172)
        Me.BO_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(105, 39)
        Me.BO_guardar.TabIndex = 40
        Me.BO_guardar.Text = "Cobrar"
        Me.BO_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Confirmar")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "PAGO:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(244, 128)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(203, 36)
        Me.TextBox1.TabIndex = 43
        '
        'tx_total
        '
        Me.tx_total.Enabled = False
        Me.tx_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_total.Location = New System.Drawing.Point(244, 81)
        Me.tx_total.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_total.Name = "tx_total"
        Me.tx_total.Size = New System.Drawing.Size(203, 36)
        Me.tx_total.TabIndex = 42
        '
        'tx_parcial
        '
        Me.tx_parcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_parcial.Location = New System.Drawing.Point(244, 36)
        Me.tx_parcial.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_parcial.Name = "tx_parcial"
        Me.tx_parcial.Size = New System.Drawing.Size(203, 36)
        Me.tx_parcial.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 29)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "MONTO TOTAL:"
        '
        'Pago_caja
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(469, 238)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.BO_guardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tx_total)
        Me.Controls.Add(Me.tx_parcial)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(475, 273)
        Me.MinimumSize = New System.Drawing.Size(475, 273)
        Me.Name = "Pago_caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago en caja - efectivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tx_total As System.Windows.Forms.TextBox
    Friend WithEvents tx_parcial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
