<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnoDialisis_seleccionar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TurnodialisisidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnodialisisDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoDialisisconsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_turnodialisis = New Aplicacion.Ds_turnodialisis()
        Me.BO_agregar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoDialisisconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_turnodialisis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 272)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un turno para asignarlo al paciente actual"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.TurnodialisisidDataGridViewTextBoxColumn, Me.TurnodialisisDescDataGridViewTextBoxColumn, Me.HorarioDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn, Me.Column2})
        Me.DataGridView1.DataSource = Me.TurnoDialisisconsultaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 20)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(673, 246)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.FillWeight = 101.5228!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 50
        '
        'TurnodialisisidDataGridViewTextBoxColumn
        '
        Me.TurnodialisisidDataGridViewTextBoxColumn.DataPropertyName = "Turnodialisis_id"
        Me.TurnodialisisidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.TurnodialisisidDataGridViewTextBoxColumn.Name = "TurnodialisisidDataGridViewTextBoxColumn"
        Me.TurnodialisisidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TurnodialisisDescDataGridViewTextBoxColumn
        '
        Me.TurnodialisisDescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TurnodialisisDescDataGridViewTextBoxColumn.DataPropertyName = "Turnodialisis_Desc"
        Me.TurnodialisisDescDataGridViewTextBoxColumn.HeaderText = "Turno"
        Me.TurnodialisisDescDataGridViewTextBoxColumn.Name = "TurnodialisisDescDataGridViewTextBoxColumn"
        Me.TurnodialisisDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HorarioDataGridViewTextBoxColumn
        '
        Me.HorarioDataGridViewTextBoxColumn.DataPropertyName = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.HeaderText = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.Name = "HorarioDataGridViewTextBoxColumn"
        Me.HorarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "Dias"
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "Dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        Me.DiasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'TurnoDialisisconsultaBindingSource
        '
        Me.TurnoDialisisconsultaBindingSource.DataMember = "TurnoDialisis_consulta"
        Me.TurnoDialisisconsultaBindingSource.DataSource = Me.Ds_turnodialisis
        '
        'Ds_turnodialisis
        '
        Me.Ds_turnodialisis.DataSetName = "Ds_turnodialisis"
        Me.Ds_turnodialisis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_agregar
        '
        Me.BO_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_agregar.Location = New System.Drawing.Point(592, 291)
        Me.BO_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_agregar.Name = "BO_agregar"
        Me.BO_agregar.Size = New System.Drawing.Size(100, 28)
        Me.BO_agregar.TabIndex = 3
        Me.BO_agregar.Text = "Asignar"
        Me.BO_agregar.UseVisualStyleBackColor = True
        '
        'TurnoDialisis_seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(713, 327)
        Me.Controls.Add(Me.BO_agregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TurnoDialisis_seleccionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turnos disponibles"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoDialisisconsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_turnodialisis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TurnodialisisidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurnodialisisDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurnoDialisisconsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_turnodialisis As Aplicacion.Ds_turnodialisis
    Friend WithEvents BO_agregar As System.Windows.Forms.Button
End Class
