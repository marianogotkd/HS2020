<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno_seleccionar
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
        Me.BO_ver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagridview1 = New System.Windows.Forms.DataGridView()
        Me.TurnodialisisidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnodialisisDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadinscriptosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoDialisisconsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_enfermeria1 = New Aplicacion.Ds_enfermeria()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnoDialisisconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_enfermeria1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BO_ver)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.datagridview1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Turnos disponibles"
        '
        'BO_ver
        '
        Me.BO_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_ver.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_ver.Location = New System.Drawing.Point(596, 221)
        Me.BO_ver.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_ver.Name = "BO_ver"
        Me.BO_ver.Size = New System.Drawing.Size(141, 43)
        Me.BO_ver.TabIndex = 259
        Me.BO_ver.Text = "Siguiente"
        Me.BO_ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_ver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 258
        Me.Label1.Text = "Seleccione un turno para continuar"
        '
        'datagridview1
        '
        Me.datagridview1.AllowUserToAddRows = False
        Me.datagridview1.AllowUserToDeleteRows = False
        Me.datagridview1.AllowUserToResizeRows = False
        Me.datagridview1.AutoGenerateColumns = False
        Me.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview1.BackgroundColor = System.Drawing.Color.White
        Me.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TurnodialisisidDataGridViewTextBoxColumn, Me.TurnodialisisDescDataGridViewTextBoxColumn, Me.HorarioDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn, Me.CantidadinscriptosDataGridViewTextBoxColumn})
        Me.datagridview1.DataSource = Me.TurnoDialisisconsultaBindingSource
        Me.datagridview1.Location = New System.Drawing.Point(24, 49)
        Me.datagridview1.Margin = New System.Windows.Forms.Padding(4)
        Me.datagridview1.MultiSelect = False
        Me.datagridview1.Name = "datagridview1"
        Me.datagridview1.ReadOnly = True
        Me.datagridview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.datagridview1.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridview1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview1.Size = New System.Drawing.Size(713, 164)
        Me.datagridview1.StandardTab = True
        Me.datagridview1.TabIndex = 257
        '
        'TurnodialisisidDataGridViewTextBoxColumn
        '
        Me.TurnodialisisidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TurnodialisisidDataGridViewTextBoxColumn.DataPropertyName = "Turnodialisis_id"
        Me.TurnodialisisidDataGridViewTextBoxColumn.FillWeight = 126.9036!
        Me.TurnodialisisidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.TurnodialisisidDataGridViewTextBoxColumn.Name = "TurnodialisisidDataGridViewTextBoxColumn"
        Me.TurnodialisisidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TurnodialisisidDataGridViewTextBoxColumn.Width = 50
        '
        'TurnodialisisDescDataGridViewTextBoxColumn
        '
        Me.TurnodialisisDescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TurnodialisisDescDataGridViewTextBoxColumn.DataPropertyName = "Turnodialisis_Desc"
        Me.TurnodialisisDescDataGridViewTextBoxColumn.FillWeight = 93.27411!
        Me.TurnodialisisDescDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.TurnodialisisDescDataGridViewTextBoxColumn.Name = "TurnodialisisDescDataGridViewTextBoxColumn"
        Me.TurnodialisisDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HorarioDataGridViewTextBoxColumn
        '
        Me.HorarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HorarioDataGridViewTextBoxColumn.DataPropertyName = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.FillWeight = 93.27411!
        Me.HorarioDataGridViewTextBoxColumn.HeaderText = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.Name = "HorarioDataGridViewTextBoxColumn"
        Me.HorarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "Dias"
        Me.DiasDataGridViewTextBoxColumn.FillWeight = 93.27411!
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "Dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        Me.DiasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadinscriptosDataGridViewTextBoxColumn
        '
        Me.CantidadinscriptosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantidadinscriptosDataGridViewTextBoxColumn.DataPropertyName = "cantidad_inscriptos"
        Me.CantidadinscriptosDataGridViewTextBoxColumn.FillWeight = 93.27411!
        Me.CantidadinscriptosDataGridViewTextBoxColumn.HeaderText = "Cantidad de pacientes"
        Me.CantidadinscriptosDataGridViewTextBoxColumn.Name = "CantidadinscriptosDataGridViewTextBoxColumn"
        Me.CantidadinscriptosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TurnoDialisisconsultaBindingSource
        '
        Me.TurnoDialisisconsultaBindingSource.DataMember = "TurnoDialisis_consulta"
        Me.TurnoDialisisconsultaBindingSource.DataSource = Me.Ds_enfermeria1
        '
        'Ds_enfermeria1
        '
        Me.Ds_enfermeria1.DataSetName = "Ds_enfermeria"
        Me.Ds_enfermeria1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Turno_seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(785, 296)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Turno_seleccionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnoDialisisconsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_enfermeria1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datagridview1 As System.Windows.Forms.DataGridView
    Friend WithEvents TurnoDialisisconsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_enfermeria1 As Aplicacion.Ds_enfermeria
    Friend WithEvents BO_ver As System.Windows.Forms.Button
    Friend WithEvents TurnodialisisidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurnodialisisDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadinscriptosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
