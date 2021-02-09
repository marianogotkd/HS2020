<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sesion_pacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sesion_pacientes))
        Me.lb_sesionfecha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_turno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_horario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ausente = New System.Windows.Forms.Button()
        Me.lb_totalinscriptos = New System.Windows.Forms.Label()
        Me.datagridview1 = New System.Windows.Forms.DataGridView()
        Me.SesionesidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DialisisidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAcdirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACnumafiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrasocialnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionesasistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_sesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesionactualtodospacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_enfermeria = New Aplicacion.Ds_enfermeria()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SesionactualtodospacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_sesionfecha
        '
        Me.lb_sesionfecha.AutoSize = True
        Me.lb_sesionfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sesionfecha.Location = New System.Drawing.Point(12, 25)
        Me.lb_sesionfecha.Name = "lb_sesionfecha"
        Me.lb_sesionfecha.Size = New System.Drawing.Size(127, 20)
        Me.lb_sesionfecha.TabIndex = 0
        Me.lb_sesionfecha.Text = "Sesion del dia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Turno:"
        '
        'tb_turno
        '
        Me.tb_turno.BackColor = System.Drawing.SystemColors.Info
        Me.tb_turno.Location = New System.Drawing.Point(74, 21)
        Me.tb_turno.Name = "tb_turno"
        Me.tb_turno.ReadOnly = True
        Me.tb_turno.Size = New System.Drawing.Size(224, 20)
        Me.tb_turno.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Horario:"
        '
        'tb_horario
        '
        Me.tb_horario.BackColor = System.Drawing.SystemColors.Info
        Me.tb_horario.Location = New System.Drawing.Point(74, 49)
        Me.tb_horario.Name = "tb_horario"
        Me.tb_horario.ReadOnly = True
        Me.tb_horario.Size = New System.Drawing.Size(224, 20)
        Me.tb_horario.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_ausente)
        Me.GroupBox1.Controls.Add(Me.lb_totalinscriptos)
        Me.GroupBox1.Controls.Add(Me.datagridview1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(941, 377)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inscriptos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(10, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 16)
        Me.Label4.TabIndex = 266
        Me.Label4.Text = "Buscar Paciente:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(10, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(924, 22)
        Me.TextBox1.TabIndex = 265
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.Button3.Location = New System.Drawing.Point(697, 320)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 44)
        Me.Button3.TabIndex = 264
        Me.Button3.Text = "Ir a Dialisis"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button3, "Cargar info dialisis")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.icono_reporte_medico_30x30
        Me.Button2.Location = New System.Drawing.Point(501, 320)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 44)
        Me.Button2.TabIndex = 263
        Me.Button2.Text = "Ver Todas las Sesiones"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "Ver todas las sesiones del paciente")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.Button1.Location = New System.Drawing.Point(13, 320)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 44)
        Me.Button1.TabIndex = 262
        Me.Button1.Text = "Presente"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Registrar como Presente")
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 20)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "Pacientes para la sesion del dia:"
        '
        'btn_ausente
        '
        Me.btn_ausente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_ausente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ausente.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_ausente.Location = New System.Drawing.Point(841, 320)
        Me.btn_ausente.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ausente.Name = "btn_ausente"
        Me.btn_ausente.Size = New System.Drawing.Size(93, 44)
        Me.btn_ausente.TabIndex = 20
        Me.btn_ausente.Text = "Ausente"
        Me.btn_ausente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_ausente, "Registrar como Ausente")
        Me.btn_ausente.UseVisualStyleBackColor = True
        '
        'lb_totalinscriptos
        '
        Me.lb_totalinscriptos.AutoSize = True
        Me.lb_totalinscriptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalinscriptos.ForeColor = System.Drawing.Color.Blue
        Me.lb_totalinscriptos.Location = New System.Drawing.Point(493, 28)
        Me.lb_totalinscriptos.Name = "lb_totalinscriptos"
        Me.lb_totalinscriptos.Size = New System.Drawing.Size(162, 20)
        Me.lb_totalinscriptos.TabIndex = 259
        Me.lb_totalinscriptos.Text = "Total de pacientes:"
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
        Me.datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SesionesidDataGridViewTextBoxColumn, Me.PACidDataGridViewTextBoxColumn, Me.SesionesfechaDataGridViewTextBoxColumn, Me.DialisisidDataGridViewTextBoxColumn, Me.PACdniDataGridViewTextBoxColumn, Me.PacienteDataGridViewTextBoxColumn, Me.PAcdirDataGridViewTextBoxColumn, Me.PACnumafiDataGridViewTextBoxColumn, Me.ObrasocialnombreDataGridViewTextBoxColumn, Me.SesionesasistenciaDataGridViewTextBoxColumn, Me.Estado_sesion})
        Me.datagridview1.DataSource = Me.SesionactualtodospacientesBindingSource
        Me.datagridview1.Location = New System.Drawing.Point(10, 124)
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
        Me.datagridview1.Size = New System.Drawing.Size(924, 188)
        Me.datagridview1.StandardTab = True
        Me.datagridview1.TabIndex = 258
        '
        'SesionesidDataGridViewTextBoxColumn
        '
        Me.SesionesidDataGridViewTextBoxColumn.DataPropertyName = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn.HeaderText = "Sesiones_id"
        Me.SesionesidDataGridViewTextBoxColumn.Name = "SesionesidDataGridViewTextBoxColumn"
        Me.SesionesidDataGridViewTextBoxColumn.ReadOnly = True
        Me.SesionesidDataGridViewTextBoxColumn.Visible = False
        '
        'PACidDataGridViewTextBoxColumn
        '
        Me.PACidDataGridViewTextBoxColumn.DataPropertyName = "PAC_id"
        Me.PACidDataGridViewTextBoxColumn.HeaderText = "PAC_id"
        Me.PACidDataGridViewTextBoxColumn.Name = "PACidDataGridViewTextBoxColumn"
        Me.PACidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PACidDataGridViewTextBoxColumn.Visible = False
        '
        'SesionesfechaDataGridViewTextBoxColumn
        '
        Me.SesionesfechaDataGridViewTextBoxColumn.DataPropertyName = "Sesiones_fecha"
        Me.SesionesfechaDataGridViewTextBoxColumn.HeaderText = "Sesiones_fecha"
        Me.SesionesfechaDataGridViewTextBoxColumn.Name = "SesionesfechaDataGridViewTextBoxColumn"
        Me.SesionesfechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SesionesfechaDataGridViewTextBoxColumn.Visible = False
        '
        'DialisisidDataGridViewTextBoxColumn
        '
        Me.DialisisidDataGridViewTextBoxColumn.DataPropertyName = "Dialisis_id"
        Me.DialisisidDataGridViewTextBoxColumn.HeaderText = "Dialisis_id"
        Me.DialisisidDataGridViewTextBoxColumn.Name = "DialisisidDataGridViewTextBoxColumn"
        Me.DialisisidDataGridViewTextBoxColumn.ReadOnly = True
        Me.DialisisidDataGridViewTextBoxColumn.Visible = False
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
        'PAcdirDataGridViewTextBoxColumn
        '
        Me.PAcdirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PAcdirDataGridViewTextBoxColumn.DataPropertyName = "PAc_dir"
        Me.PAcdirDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.PAcdirDataGridViewTextBoxColumn.Name = "PAcdirDataGridViewTextBoxColumn"
        Me.PAcdirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PACnumafiDataGridViewTextBoxColumn
        '
        Me.PACnumafiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PACnumafiDataGridViewTextBoxColumn.DataPropertyName = "PACnumafi"
        Me.PACnumafiDataGridViewTextBoxColumn.HeaderText = "Nº Afiliado"
        Me.PACnumafiDataGridViewTextBoxColumn.Name = "PACnumafiDataGridViewTextBoxColumn"
        Me.PACnumafiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObrasocialnombreDataGridViewTextBoxColumn
        '
        Me.ObrasocialnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ObrasocialnombreDataGridViewTextBoxColumn.DataPropertyName = "Obrasocial_nombre"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.HeaderText = "Obra Social"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.Name = "ObrasocialnombreDataGridViewTextBoxColumn"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SesionesasistenciaDataGridViewTextBoxColumn
        '
        Me.SesionesasistenciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SesionesasistenciaDataGridViewTextBoxColumn.DataPropertyName = "Sesiones_asistencia"
        Me.SesionesasistenciaDataGridViewTextBoxColumn.HeaderText = "Asistencia"
        Me.SesionesasistenciaDataGridViewTextBoxColumn.Name = "SesionesasistenciaDataGridViewTextBoxColumn"
        Me.SesionesasistenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Estado_sesion
        '
        Me.Estado_sesion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Estado_sesion.DataPropertyName = "Estado_sesion"
        Me.Estado_sesion.HeaderText = "Estado"
        Me.Estado_sesion.Name = "Estado_sesion"
        Me.Estado_sesion.ReadOnly = True
        '
        'SesionactualtodospacientesBindingSource
        '
        Me.SesionactualtodospacientesBindingSource.DataMember = "Sesion_actual_todos_pacientes"
        Me.SesionactualtodospacientesBindingSource.DataSource = Me.Ds_enfermeria
        '
        'Ds_enfermeria
        '
        Me.Ds_enfermeria.DataSetName = "Ds_enfermeria"
        Me.Ds_enfermeria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button_buscar
        '
        Me.Button_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button_buscar.Image = CType(resources.GetObject("Button_buscar.Image"), System.Drawing.Image)
        Me.Button_buscar.Location = New System.Drawing.Point(287, 15)
        Me.Button_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(112, 33)
        Me.Button_buscar.TabIndex = 260
        Me.Button_buscar.Text = "Buscar"
        Me.Button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_buscar, "Buscar sesion")
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(145, 20)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(135, 26)
        Me.fecha.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button4.Location = New System.Drawing.Point(33, 498)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 43)
        Me.Button4.TabIndex = 259
        Me.Button4.Text = "Volver"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button_buscar)
        Me.GroupBox2.Controls.Add(Me.lb_sesionfecha)
        Me.GroupBox2.Controls.Add(Me.fecha)
        Me.GroupBox2.Location = New System.Drawing.Point(334, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 60)
        Me.GroupBox2.TabIndex = 261
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda avanzada de sesiones"
        '
        'Sesion_pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 554)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tb_horario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_turno)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sesion_pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sesiones de diálisis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SesionactualtodospacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_sesionfecha As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_turno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_horario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_totalinscriptos As System.Windows.Forms.Label
    Friend WithEvents datagridview1 As System.Windows.Forms.DataGridView
    Friend WithEvents SesionactualtodospacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_enfermeria As Aplicacion.Ds_enfermeria
    Friend WithEvents btn_ausente As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SesionesidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DialisisidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAcdirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACnumafiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObrasocialnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesionesasistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado_sesion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
