<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_sesion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DG_CC = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.DG_CC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_CC
        '
        Me.DG_CC.AllowUserToAddRows = False
        Me.DG_CC.AllowUserToDeleteRows = False
        Me.DG_CC.AllowUserToResizeRows = False
        Me.DG_CC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_CC.BackgroundColor = System.Drawing.Color.White
        Me.DG_CC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_CC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DG_CC.Location = New System.Drawing.Point(151, 37)
        Me.DG_CC.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_CC.MultiSelect = False
        Me.DG_CC.Name = "DG_CC"
        Me.DG_CC.ReadOnly = True
        Me.DG_CC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_CC.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_CC.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_CC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_CC.Size = New System.Drawing.Size(409, 387)
        Me.DG_CC.StandardTab = True
        Me.DG_CC.TabIndex = 256
        '
        'Column1
        '
        Me.Column1.HeaderText = "Asistencia"
        Me.Column1.Items.AddRange(New Object() {"Presente", "Ausente"})
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Nueva_sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 461)
        Me.Controls.Add(Me.DG_CC)
        Me.Name = "Nueva_sesion"
        Me.Text = "Nueva_sesion"
        CType(Me.DG_CC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG_CC As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
