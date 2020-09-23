<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enfermeria_pacientes_seleccionar
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.PACidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACtelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAcdirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrasocialidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrasocialnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACnumafiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant_sesiones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_enfermeria = New Aplicacion.Ds_enfermeria()
        Me.BO_ver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paciente1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DG_clientes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1105, 409)
        Me.GroupBox1.TabIndex = 247
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Pacientes"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1081, 20)
        Me.TextBox1.TabIndex = 240
        '
        'DG_clientes
        '
        Me.DG_clientes.AllowUserToAddRows = False
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.AutoGenerateColumns = False
        Me.DG_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PACidDataGridViewTextBoxColumn, Me.PACdniDataGridViewTextBoxColumn, Me.PacienteDataGridViewTextBoxColumn, Me.PACtelDataGridViewTextBoxColumn, Me.PACmailDataGridViewTextBoxColumn, Me.PAcdirDataGridViewTextBoxColumn, Me.ObrasocialidDataGridViewTextBoxColumn, Me.ObrasocialnombreDataGridViewTextBoxColumn, Me.PACnumafiDataGridViewTextBoxColumn, Me.cant_sesiones})
        Me.DG_clientes.DataSource = Me.Paciente1BindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(12, 51)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(1081, 350)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 239
        '
        'PACidDataGridViewTextBoxColumn
        '
        Me.PACidDataGridViewTextBoxColumn.DataPropertyName = "PAC_id"
        Me.PACidDataGridViewTextBoxColumn.HeaderText = "PAC_id"
        Me.PACidDataGridViewTextBoxColumn.Name = "PACidDataGridViewTextBoxColumn"
        Me.PACidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PACidDataGridViewTextBoxColumn.Visible = False
        '
        'PACdniDataGridViewTextBoxColumn
        '
        Me.PACdniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PACdniDataGridViewTextBoxColumn.DataPropertyName = "PAC_dni"
        Me.PACdniDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.PACdniDataGridViewTextBoxColumn.Name = "PACdniDataGridViewTextBoxColumn"
        Me.PACdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PacienteDataGridViewTextBoxColumn
        '
        Me.PacienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.HeaderText = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.Name = "PacienteDataGridViewTextBoxColumn"
        Me.PacienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PACtelDataGridViewTextBoxColumn
        '
        Me.PACtelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PACtelDataGridViewTextBoxColumn.DataPropertyName = "PAC_tel"
        Me.PACtelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.PACtelDataGridViewTextBoxColumn.Name = "PACtelDataGridViewTextBoxColumn"
        Me.PACtelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PACmailDataGridViewTextBoxColumn
        '
        Me.PACmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PACmailDataGridViewTextBoxColumn.DataPropertyName = "PAC_mail"
        Me.PACmailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.PACmailDataGridViewTextBoxColumn.Name = "PACmailDataGridViewTextBoxColumn"
        Me.PACmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PAcdirDataGridViewTextBoxColumn
        '
        Me.PAcdirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PAcdirDataGridViewTextBoxColumn.DataPropertyName = "PAc_dir"
        Me.PAcdirDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.PAcdirDataGridViewTextBoxColumn.Name = "PAcdirDataGridViewTextBoxColumn"
        Me.PAcdirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObrasocialidDataGridViewTextBoxColumn
        '
        Me.ObrasocialidDataGridViewTextBoxColumn.DataPropertyName = "Obrasocial_id"
        Me.ObrasocialidDataGridViewTextBoxColumn.HeaderText = "Obrasocial_id"
        Me.ObrasocialidDataGridViewTextBoxColumn.Name = "ObrasocialidDataGridViewTextBoxColumn"
        Me.ObrasocialidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObrasocialidDataGridViewTextBoxColumn.Visible = False
        '
        'ObrasocialnombreDataGridViewTextBoxColumn
        '
        Me.ObrasocialnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ObrasocialnombreDataGridViewTextBoxColumn.DataPropertyName = "Obrasocial_nombre"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.HeaderText = "Obra Social"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.Name = "ObrasocialnombreDataGridViewTextBoxColumn"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PACnumafiDataGridViewTextBoxColumn
        '
        Me.PACnumafiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PACnumafiDataGridViewTextBoxColumn.DataPropertyName = "PACnumafi"
        Me.PACnumafiDataGridViewTextBoxColumn.HeaderText = "Nro Afiliado"
        Me.PACnumafiDataGridViewTextBoxColumn.Name = "PACnumafiDataGridViewTextBoxColumn"
        Me.PACnumafiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cant_sesiones
        '
        Me.cant_sesiones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cant_sesiones.DataPropertyName = "cant_sesiones"
        Me.cant_sesiones.HeaderText = "Sesiones"
        Me.cant_sesiones.Name = "cant_sesiones"
        Me.cant_sesiones.ReadOnly = True
        '
        'Paciente1BindingSource
        '
        Me.Paciente1BindingSource.DataMember = "Paciente1"
        Me.Paciente1BindingSource.DataSource = Me.Ds_enfermeria
        '
        'Ds_enfermeria
        '
        Me.Ds_enfermeria.DataSetName = "Ds_enfermeria"
        Me.Ds_enfermeria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_ver
        '
        Me.BO_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_ver.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_ver.Location = New System.Drawing.Point(992, 430)
        Me.BO_ver.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_ver.Name = "BO_ver"
        Me.BO_ver.Size = New System.Drawing.Size(114, 43)
        Me.BO_ver.TabIndex = 260
        Me.BO_ver.Text = "Ver"
        Me.BO_ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_ver.UseVisualStyleBackColor = True
        '
        'Enfermeria_pacientes_seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1158, 478)
        Me.Controls.Add(Me.BO_ver)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Enfermeria_pacientes_seleccionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Dialisis - selección de paciente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paciente1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Paciente1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_enfermeria As Aplicacion.Ds_enfermeria
    Friend WithEvents PACidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACtelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAcdirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObrasocialidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObrasocialnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACnumafiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant_sesiones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BO_ver As System.Windows.Forms.Button
End Class
