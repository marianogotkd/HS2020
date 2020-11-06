<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostoInd_alta
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_desc = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_costo_HORA = New System.Windows.Forms.TextBox()
        Me.tb_dia = New System.Windows.Forms.NumericUpDown()
        Me.tb_horas = New System.Windows.Forms.NumericUpDown()
        Me.tb_costo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tb_dia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_horas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripcion"
        '
        'tb_desc
        '
        Me.tb_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_desc.Location = New System.Drawing.Point(81, 57)
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.Size = New System.Drawing.Size(238, 26)
        Me.tb_desc.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_costo_HORA)
        Me.GroupBox1.Controls.Add(Me.tb_dia)
        Me.GroupBox1.Controls.Add(Me.tb_horas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 172)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Cantidad de Horas de Trabajo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Cantidad de Dias de Trabajo"
        '
        'tb_costo_HORA
        '
        Me.tb_costo_HORA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_costo_HORA.Location = New System.Drawing.Point(184, 133)
        Me.tb_costo_HORA.Name = "tb_costo_HORA"
        Me.tb_costo_HORA.Size = New System.Drawing.Size(165, 26)
        Me.tb_costo_HORA.TabIndex = 29
        '
        'tb_dia
        '
        Me.tb_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dia.Location = New System.Drawing.Point(184, 31)
        Me.tb_dia.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.tb_dia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tb_dia.Name = "tb_dia"
        Me.tb_dia.Size = New System.Drawing.Size(46, 26)
        Me.tb_dia.TabIndex = 27
        Me.tb_dia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tb_horas
        '
        Me.tb_horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_horas.Location = New System.Drawing.Point(184, 78)
        Me.tb_horas.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.tb_horas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tb_horas.Name = "tb_horas"
        Me.tb_horas.Size = New System.Drawing.Size(46, 26)
        Me.tb_horas.TabIndex = 23
        Me.tb_horas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tb_costo
        '
        Me.tb_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_costo.Location = New System.Drawing.Point(507, 57)
        Me.tb_costo.Name = "tb_costo"
        Me.tb_costo.Size = New System.Drawing.Size(112, 26)
        Me.tb_costo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(467, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Costo"
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.floppy_disk30x30
        Me.btn_guardar.Location = New System.Drawing.Point(503, 268)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(116, 43)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.Text = "Guardar Cambios"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'CostoInd_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 382)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tb_costo)
        Me.Controls.Add(Me.tb_desc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "CostoInd_alta"
        Me.Text = "CostoInd_alta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tb_dia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_horas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_desc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_dia As System.Windows.Forms.NumericUpDown
    Friend WithEvents tb_horas As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_costo_HORA As System.Windows.Forms.TextBox
    Friend WithEvents tb_costo As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
