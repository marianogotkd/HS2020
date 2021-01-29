<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cierre_Caja
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Ingresos = New System.Windows.Forms.Button()
        Me.Btn_Gastos = New System.Windows.Forms.Button()
        Me.Btn_Tarjetas = New System.Windows.Forms.Button()
        Me.Btn_Cheques = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_Fondos = New System.Windows.Forms.Button()
        Me.Btn_Compro = New System.Windows.Forms.Button()
        Me.Btn_Ventas = New System.Windows.Forms.Button()
        Me.Btn_CerrarCaja = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 25)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(71, 65)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Turno"
        '
        'Btn_Ingresos
        '
        Me.Btn_Ingresos.Location = New System.Drawing.Point(20, 130)
        Me.Btn_Ingresos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Ingresos.Name = "Btn_Ingresos"
        Me.Btn_Ingresos.Size = New System.Drawing.Size(184, 68)
        Me.Btn_Ingresos.TabIndex = 4
        Me.Btn_Ingresos.Text = "Ingresos"
        Me.Btn_Ingresos.UseVisualStyleBackColor = True
        '
        'Btn_Gastos
        '
        Me.Btn_Gastos.Location = New System.Drawing.Point(212, 130)
        Me.Btn_Gastos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Gastos.Name = "Btn_Gastos"
        Me.Btn_Gastos.Size = New System.Drawing.Size(184, 68)
        Me.Btn_Gastos.TabIndex = 5
        Me.Btn_Gastos.Text = "Gastos"
        Me.Btn_Gastos.UseVisualStyleBackColor = True
        '
        'Btn_Tarjetas
        '
        Me.Btn_Tarjetas.Location = New System.Drawing.Point(404, 130)
        Me.Btn_Tarjetas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Tarjetas.Name = "Btn_Tarjetas"
        Me.Btn_Tarjetas.Size = New System.Drawing.Size(184, 68)
        Me.Btn_Tarjetas.TabIndex = 6
        Me.Btn_Tarjetas.Text = "Tarjetas"
        Me.Btn_Tarjetas.UseVisualStyleBackColor = True
        '
        'Btn_Cheques
        '
        Me.Btn_Cheques.Location = New System.Drawing.Point(596, 130)
        Me.Btn_Cheques.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Cheques.Name = "Btn_Cheques"
        Me.Btn_Cheques.Size = New System.Drawing.Size(184, 68)
        Me.Btn_Cheques.TabIndex = 7
        Me.Btn_Cheques.Text = "Cheques"
        Me.Btn_Cheques.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 223)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(952, 310)
        Me.DataGridView1.TabIndex = 8
        '
        'Btn_Fondos
        '
        Me.Btn_Fondos.Location = New System.Drawing.Point(788, 130)
        Me.Btn_Fondos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Fondos.Name = "Btn_Fondos"
        Me.Btn_Fondos.Size = New System.Drawing.Size(184, 68)
        Me.Btn_Fondos.TabIndex = 9
        Me.Btn_Fondos.Text = "Fondos"
        Me.Btn_Fondos.UseVisualStyleBackColor = True
        '
        'Btn_Compro
        '
        Me.Btn_Compro.Location = New System.Drawing.Point(16, 551)
        Me.Btn_Compro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Compro.Name = "Btn_Compro"
        Me.Btn_Compro.Size = New System.Drawing.Size(165, 44)
        Me.Btn_Compro.TabIndex = 10
        Me.Btn_Compro.Text = "Ver Comprobantes"
        Me.Btn_Compro.UseVisualStyleBackColor = True
        '
        'Btn_Ventas
        '
        Me.Btn_Ventas.Location = New System.Drawing.Point(189, 551)
        Me.Btn_Ventas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Ventas.Name = "Btn_Ventas"
        Me.Btn_Ventas.Size = New System.Drawing.Size(165, 44)
        Me.Btn_Ventas.TabIndex = 11
        Me.Btn_Ventas.Text = "Ver Ventas"
        Me.Btn_Ventas.UseVisualStyleBackColor = True
        '
        'Btn_CerrarCaja
        '
        Me.Btn_CerrarCaja.Location = New System.Drawing.Point(363, 551)
        Me.Btn_CerrarCaja.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_CerrarCaja.Name = "Btn_CerrarCaja"
        Me.Btn_CerrarCaja.Size = New System.Drawing.Size(165, 44)
        Me.Btn_CerrarCaja.TabIndex = 12
        Me.Btn_CerrarCaja.Text = "Cerrar Caja"
        Me.Btn_CerrarCaja.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(807, 551)
        Me.Btn_Salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(165, 44)
        Me.Btn_Salir.TabIndex = 13
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Cierre_Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 606)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_CerrarCaja)
        Me.Controls.Add(Me.Btn_Ventas)
        Me.Controls.Add(Me.Btn_Compro)
        Me.Controls.Add(Me.Btn_Fondos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Cheques)
        Me.Controls.Add(Me.Btn_Tarjetas)
        Me.Controls.Add(Me.Btn_Gastos)
        Me.Controls.Add(Me.Btn_Ingresos)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Cierre_Caja"
        Me.Text = "Cierre de Caja"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Ingresos As System.Windows.Forms.Button
    Friend WithEvents Btn_Gastos As System.Windows.Forms.Button
    Friend WithEvents Btn_Tarjetas As System.Windows.Forms.Button
    Friend WithEvents Btn_Cheques As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Fondos As System.Windows.Forms.Button
    Friend WithEvents Btn_Compro As System.Windows.Forms.Button
    Friend WithEvents Btn_Ventas As System.Windows.Forms.Button
    Friend WithEvents Btn_CerrarCaja As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
