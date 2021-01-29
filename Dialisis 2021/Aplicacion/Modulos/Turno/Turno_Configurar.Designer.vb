<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno_Configurar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turno_Configurar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DG_CanchaPrecio = New System.Windows.Forms.DataGridView()
        Me.CANCHATidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCHATnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TURNOCONFprecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanchaPrecioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Turno_ds = New Aplicacion.Turno_ds()
        Me.BO_Agregar = New System.Windows.Forms.Button()
        Me.GP_cancha = New System.Windows.Forms.GroupBox()
        Me.COM_CANCHA_T = New System.Windows.Forms.ComboBox()
        Me.LB_ERROR = New System.Windows.Forms.Label()
        Me.IM_ERROR = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TX_CONF_precio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NU_fin_hora = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NU_fin_minuto = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GP_duracion = New System.Windows.Forms.GroupBox()
        Me.NU_Inicio_hora = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NU_Inicio_minuto = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GP_fecha = New System.Windows.Forms.GroupBox()
        Me.DT_fecha = New System.Windows.Forms.DateTimePicker()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_CanchaPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CanchaPrecioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_cancha.SuspendLayout()
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NU_fin_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_fin_minuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_duracion.SuspendLayout()
        CType(Me.NU_Inicio_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_Inicio_minuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_fecha.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(866, 406)
        Me.TabControl2.TabIndex = 2
        Me.TabControl2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 380)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Turno: Configurar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.BO_Agregar)
        Me.GroupBox4.Controls.Add(Me.GP_cancha)
        Me.GroupBox4.Controls.Add(Me.LB_ERROR)
        Me.GroupBox4.Controls.Add(Me.IM_ERROR)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GP_duracion)
        Me.GroupBox4.Controls.Add(Me.GP_fecha)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(845, 368)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Turno Configurar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DG_CanchaPrecio)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(241, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 162)
        Me.GroupBox3.TabIndex = 255
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cancha Precio por Hora"
        '
        'DG_CanchaPrecio
        '
        Me.DG_CanchaPrecio.AllowUserToAddRows = False
        Me.DG_CanchaPrecio.AllowUserToDeleteRows = False
        Me.DG_CanchaPrecio.AutoGenerateColumns = False
        Me.DG_CanchaPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CanchaPrecio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CANCHATidDataGridViewTextBoxColumn, Me.CANCHATnomDataGridViewTextBoxColumn, Me.TURNOCONFprecioDataGridViewTextBoxColumn})
        Me.DG_CanchaPrecio.DataSource = Me.CanchaPrecioBindingSource
        Me.DG_CanchaPrecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_CanchaPrecio.Enabled = False
        Me.DG_CanchaPrecio.Location = New System.Drawing.Point(3, 16)
        Me.DG_CanchaPrecio.Name = "DG_CanchaPrecio"
        Me.DG_CanchaPrecio.ReadOnly = True
        Me.DG_CanchaPrecio.Size = New System.Drawing.Size(305, 143)
        Me.DG_CanchaPrecio.TabIndex = 0
        '
        'CANCHATidDataGridViewTextBoxColumn
        '
        Me.CANCHATidDataGridViewTextBoxColumn.DataPropertyName = "CANCHA_T_id"
        Me.CANCHATidDataGridViewTextBoxColumn.HeaderText = "CANCHA_T_id"
        Me.CANCHATidDataGridViewTextBoxColumn.Name = "CANCHATidDataGridViewTextBoxColumn"
        Me.CANCHATidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CANCHATidDataGridViewTextBoxColumn.Visible = False
        '
        'CANCHATnomDataGridViewTextBoxColumn
        '
        Me.CANCHATnomDataGridViewTextBoxColumn.DataPropertyName = "CANCHA_T_nom"
        Me.CANCHATnomDataGridViewTextBoxColumn.HeaderText = "Cancha"
        Me.CANCHATnomDataGridViewTextBoxColumn.Name = "CANCHATnomDataGridViewTextBoxColumn"
        Me.CANCHATnomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CANCHATnomDataGridViewTextBoxColumn.Width = 160
        '
        'TURNOCONFprecioDataGridViewTextBoxColumn
        '
        Me.TURNOCONFprecioDataGridViewTextBoxColumn.DataPropertyName = "TURNO_CONF_precio"
        Me.TURNOCONFprecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.TURNOCONFprecioDataGridViewTextBoxColumn.Name = "TURNOCONFprecioDataGridViewTextBoxColumn"
        Me.TURNOCONFprecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CanchaPrecioBindingSource
        '
        Me.CanchaPrecioBindingSource.DataMember = "CanchaPrecio"
        Me.CanchaPrecioBindingSource.DataSource = Me.Turno_ds
        '
        'Turno_ds
        '
        Me.Turno_ds.DataSetName = "Turno_ds"
        Me.Turno_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_Agregar
        '
        Me.BO_Agregar.Image = CType(resources.GetObject("BO_Agregar.Image"), System.Drawing.Image)
        Me.BO_Agregar.Location = New System.Drawing.Point(641, 144)
        Me.BO_Agregar.Name = "BO_Agregar"
        Me.BO_Agregar.Size = New System.Drawing.Size(30, 30)
        Me.BO_Agregar.TabIndex = 254
        Me.ToolTip1.SetToolTip(Me.BO_Agregar, "Agregar")
        Me.BO_Agregar.UseVisualStyleBackColor = True
        '
        'GP_cancha
        '
        Me.GP_cancha.Controls.Add(Me.COM_CANCHA_T)
        Me.GP_cancha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_cancha.Location = New System.Drawing.Point(241, 123)
        Me.GP_cancha.Name = "GP_cancha"
        Me.GP_cancha.Size = New System.Drawing.Size(195, 61)
        Me.GP_cancha.TabIndex = 253
        Me.GP_cancha.TabStop = False
        Me.GP_cancha.Text = "Cancha"
        '
        'COM_CANCHA_T
        '
        Me.COM_CANCHA_T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COM_CANCHA_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_CANCHA_T.FormattingEnabled = True
        Me.COM_CANCHA_T.Location = New System.Drawing.Point(13, 24)
        Me.COM_CANCHA_T.Name = "COM_CANCHA_T"
        Me.COM_CANCHA_T.Size = New System.Drawing.Size(172, 23)
        Me.COM_CANCHA_T.TabIndex = 7
        '
        'LB_ERROR
        '
        Me.LB_ERROR.AutoSize = True
        Me.LB_ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ERROR.ForeColor = System.Drawing.Color.Red
        Me.LB_ERROR.Location = New System.Drawing.Point(145, 92)
        Me.LB_ERROR.Name = "LB_ERROR"
        Me.LB_ERROR.Size = New System.Drawing.Size(176, 16)
        Me.LB_ERROR.TabIndex = 252
        Me.LB_ERROR.Text = "Ya existe una Configuracion."
        Me.LB_ERROR.Visible = False
        '
        'IM_ERROR
        '
        Me.IM_ERROR.Image = CType(resources.GetObject("IM_ERROR.Image"), System.Drawing.Image)
        Me.IM_ERROR.Location = New System.Drawing.Point(122, 90)
        Me.IM_ERROR.Name = "IM_ERROR"
        Me.IM_ERROR.Size = New System.Drawing.Size(20, 20)
        Me.IM_ERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IM_ERROR.TabIndex = 249
        Me.IM_ERROR.TabStop = False
        Me.IM_ERROR.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TX_CONF_precio)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(442, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 61)
        Me.GroupBox2.TabIndex = 248
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precio por Hora"
        '
        'TX_CONF_precio
        '
        Me.TX_CONF_precio.Location = New System.Drawing.Point(77, 27)
        Me.TX_CONF_precio.Name = "TX_CONF_precio"
        Me.TX_CONF_precio.Size = New System.Drawing.Size(100, 20)
        Me.TX_CONF_precio.TabIndex = 231
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(21, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 247
        Me.Label4.Text = "(Precio)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NU_fin_hora)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NU_fin_minuto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(546, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 61)
        Me.GroupBox1.TabIndex = 247
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horario de Fin"
        '
        'NU_fin_hora
        '
        Me.NU_fin_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_fin_hora.Location = New System.Drawing.Point(55, 25)
        Me.NU_fin_hora.Name = "NU_fin_hora"
        Me.NU_fin_hora.Size = New System.Drawing.Size(40, 22)
        Me.NU_fin_hora.TabIndex = 14
        Me.NU_fin_hora.Value = New Decimal(New Integer() {23, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(8, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 247
        Me.Label2.Text = "(Hora)"
        '
        'NU_fin_minuto
        '
        Me.NU_fin_minuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_fin_minuto.Location = New System.Drawing.Point(143, 25)
        Me.NU_fin_minuto.Name = "NU_fin_minuto"
        Me.NU_fin_minuto.Size = New System.Drawing.Size(40, 22)
        Me.NU_fin_minuto.TabIndex = 15
        Me.NU_fin_minuto.Value = New Decimal(New Integer() {59, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(104, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 243
        Me.Label3.Text = "(Min)"
        '
        'GP_duracion
        '
        Me.GP_duracion.Controls.Add(Me.NU_Inicio_hora)
        Me.GP_duracion.Controls.Add(Me.Label1)
        Me.GP_duracion.Controls.Add(Me.NU_Inicio_minuto)
        Me.GP_duracion.Controls.Add(Me.Label6)
        Me.GP_duracion.Enabled = False
        Me.GP_duracion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_duracion.Location = New System.Drawing.Point(345, 23)
        Me.GP_duracion.Name = "GP_duracion"
        Me.GP_duracion.Size = New System.Drawing.Size(195, 61)
        Me.GP_duracion.TabIndex = 246
        Me.GP_duracion.TabStop = False
        Me.GP_duracion.Text = "Horario de Inicio"
        '
        'NU_Inicio_hora
        '
        Me.NU_Inicio_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_Inicio_hora.Location = New System.Drawing.Point(55, 25)
        Me.NU_Inicio_hora.Name = "NU_Inicio_hora"
        Me.NU_Inicio_hora.Size = New System.Drawing.Size(40, 22)
        Me.NU_Inicio_hora.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 247
        Me.Label1.Text = "(Hora)"
        '
        'NU_Inicio_minuto
        '
        Me.NU_Inicio_minuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NU_Inicio_minuto.Location = New System.Drawing.Point(143, 25)
        Me.NU_Inicio_minuto.Name = "NU_Inicio_minuto"
        Me.NU_Inicio_minuto.Size = New System.Drawing.Size(40, 22)
        Me.NU_Inicio_minuto.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(104, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 243
        Me.Label6.Text = "(Min)"
        '
        'GP_fecha
        '
        Me.GP_fecha.Controls.Add(Me.DT_fecha)
        Me.GP_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GP_fecha.Location = New System.Drawing.Point(114, 23)
        Me.GP_fecha.Name = "GP_fecha"
        Me.GP_fecha.Size = New System.Drawing.Size(225, 61)
        Me.GP_fecha.TabIndex = 245
        Me.GP_fecha.TabStop = False
        Me.GP_fecha.Text = "Fecha"
        '
        'DT_fecha
        '
        Me.DT_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_fecha.CustomFormat = ""
        Me.DT_fecha.Location = New System.Drawing.Point(8, 23)
        Me.DT_fecha.Name = "DT_fecha"
        Me.DT_fecha.Size = New System.Drawing.Size(210, 20)
        Me.DT_fecha.TabIndex = 11
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(788, 420)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Eliminar.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Cancelar")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'BO_guardar
        '
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(834, 420)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(40, 40)
        Me.BO_guardar.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Guardar")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 424)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(572, 126)
        Me.GroupBox5.TabIndex = 256
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle del día actual configurado:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(10, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(549, 101)
        Me.DataGridView1.TabIndex = 232
        '
        'Turno_Configurar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.Controls.Add(Me.BO_guardar)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "Turno_Configurar"
        Me.Text = "Turno_Configurar"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DG_CanchaPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CanchaPrecioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turno_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_cancha.ResumeLayout(False)
        CType(Me.IM_ERROR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NU_fin_hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_fin_minuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_duracion.ResumeLayout(False)
        Me.GP_duracion.PerformLayout()
        CType(Me.NU_Inicio_hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_Inicio_minuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_fecha.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_duracion As System.Windows.Forms.GroupBox
    Friend WithEvents NU_Inicio_hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NU_Inicio_minuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GP_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents DT_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TX_CONF_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NU_fin_hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NU_fin_minuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IM_ERROR As System.Windows.Forms.PictureBox
    Friend WithEvents LB_ERROR As System.Windows.Forms.Label
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents GP_cancha As System.Windows.Forms.GroupBox
    Friend WithEvents COM_CANCHA_T As System.Windows.Forms.ComboBox
    Friend WithEvents BO_Agregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_CanchaPrecio As System.Windows.Forms.DataGridView
    Friend WithEvents CanchaPrecioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Turno_ds As Aplicacion.Turno_ds
    Friend WithEvents CANCHATidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCHATnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TURNOCONFprecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
