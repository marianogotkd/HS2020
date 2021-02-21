<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_Dialisis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nueva_Dialisis))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_numHemo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_estado = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_Dni_Cuit = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tb_numafi = New System.Windows.Forms.TextBox()
        Me.tb_obsoc = New System.Windows.Forms.TextBox()
        Me.tb_sexo = New System.Windows.Forms.TextBox()
        Me.tb_edad = New System.Windows.Forms.TextBox()
        Me.tb_fecnac = New System.Windows.Forms.TextBox()
        Me.tb_nombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tb_tiempoHD = New System.Windows.Forms.MaskedTextBox()
        Me.tb_HE = New System.Windows.Forms.MaskedTextBox()
        Me.tb_HI = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_err3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tb_PesoE = New System.Windows.Forms.MaskedTextBox()
        Me.tb_PesoI = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_err4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tb_TAE = New System.Windows.Forms.MaskedTextBox()
        Me.tb_TAI = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_err5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox_insumos = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar_seleccion = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CodprodDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesdeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaciaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadrealDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ConsumorealBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_enfermeria = New Aplicacion.Ds_enfermeria()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_a_consumir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFabricacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EnBD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovEnfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mov_DS = New Aplicacion.Mov_DS()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tb_Filtro = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tb_Obs = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_filtro = New System.Windows.Forms.ComboBox()
        Me.btn_cambio = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tb_CantRe = New System.Windows.Forms.TextBox()
        Me.lbl_err2 = New System.Windows.Forms.Label()
        Me.lbl_err7 = New System.Windows.Forms.Label()
        Me.tb_talla = New System.Windows.Forms.MaskedTextBox()
        Me.tb_PesoS = New System.Windows.Forms.MaskedTextBox()
        Me.btn_NAV = New System.Windows.Forms.Button()
        Me.tb_AV = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_err6 = New System.Windows.Forms.Label()
        Me.lbl_err1 = New System.Windows.Forms.Label()
        Me.lbl_err = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox_insumos.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumorealBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovEnfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hemodialisis N°"
        '
        'tb_numHemo
        '
        Me.tb_numHemo.Location = New System.Drawing.Point(138, 36)
        Me.tb_numHemo.Name = "tb_numHemo"
        Me.tb_numHemo.ReadOnly = True
        Me.tb_numHemo.Size = New System.Drawing.Size(42, 20)
        Me.tb_numHemo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lb_estado)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.tb_Dni_Cuit)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.tb_numafi)
        Me.GroupBox1.Controls.Add(Me.tb_obsoc)
        Me.GroupBox1.Controls.Add(Me.tb_sexo)
        Me.GroupBox1.Controls.Add(Me.tb_edad)
        Me.GroupBox1.Controls.Add(Me.tb_fecnac)
        Me.GroupBox1.Controls.Add(Me.tb_nombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1212, 108)
        Me.GroupBox1.TabIndex = 251
        Me.GroupBox1.TabStop = False
        '
        'lb_estado
        '
        Me.lb_estado.AutoSize = True
        Me.lb_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_estado.ForeColor = System.Drawing.Color.Green
        Me.lb_estado.Location = New System.Drawing.Point(909, 16)
        Me.lb_estado.Name = "lb_estado"
        Me.lb_estado.Size = New System.Drawing.Size(179, 24)
        Me.lb_estado.TabIndex = 269
        Me.lb_estado.Text = "ESTADO: NUEVO"
        Me.lb_estado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(8, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(140, 16)
        Me.Label17.TabIndex = 268
        Me.Label17.Text = "Datos del Paciente"
        '
        'tb_Dni_Cuit
        '
        Me.tb_Dni_Cuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_Dni_Cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Dni_Cuit.Location = New System.Drawing.Point(59, 65)
        Me.tb_Dni_Cuit.Name = "tb_Dni_Cuit"
        Me.tb_Dni_Cuit.ReadOnly = True
        Me.tb_Dni_Cuit.Size = New System.Drawing.Size(219, 20)
        Me.tb_Dni_Cuit.TabIndex = 267
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 266
        Me.Label21.Text = "DNI:"
        '
        'tb_numafi
        '
        Me.tb_numafi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_numafi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_numafi.Location = New System.Drawing.Point(867, 65)
        Me.tb_numafi.Name = "tb_numafi"
        Me.tb_numafi.ReadOnly = True
        Me.tb_numafi.Size = New System.Drawing.Size(134, 20)
        Me.tb_numafi.TabIndex = 265
        '
        'tb_obsoc
        '
        Me.tb_obsoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_obsoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_obsoc.Location = New System.Drawing.Point(626, 65)
        Me.tb_obsoc.Name = "tb_obsoc"
        Me.tb_obsoc.ReadOnly = True
        Me.tb_obsoc.Size = New System.Drawing.Size(153, 20)
        Me.tb_obsoc.TabIndex = 264
        '
        'tb_sexo
        '
        Me.tb_sexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_sexo.Location = New System.Drawing.Point(626, 39)
        Me.tb_sexo.Name = "tb_sexo"
        Me.tb_sexo.ReadOnly = True
        Me.tb_sexo.Size = New System.Drawing.Size(153, 20)
        Me.tb_sexo.TabIndex = 263
        '
        'tb_edad
        '
        Me.tb_edad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_edad.Location = New System.Drawing.Point(401, 39)
        Me.tb_edad.Name = "tb_edad"
        Me.tb_edad.ReadOnly = True
        Me.tb_edad.Size = New System.Drawing.Size(150, 20)
        Me.tb_edad.TabIndex = 262
        '
        'tb_fecnac
        '
        Me.tb_fecnac.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_fecnac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fecnac.Location = New System.Drawing.Point(401, 65)
        Me.tb_fecnac.Name = "tb_fecnac"
        Me.tb_fecnac.ReadOnly = True
        Me.tb_fecnac.Size = New System.Drawing.Size(150, 20)
        Me.tb_fecnac.TabIndex = 261
        '
        'tb_nombre
        '
        Me.tb_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(59, 39)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.ReadOnly = True
        Me.tb_nombre.Size = New System.Drawing.Size(219, 20)
        Me.tb_nombre.TabIndex = 255
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 254
        Me.Label6.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(284, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 260
        Me.Label10.Text = "Fecha de Nacimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Edad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(557, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 257
        Me.Label7.Text = "Sexo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(557, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 252
        Me.Label4.Text = "Obra social:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(794, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 259
        Me.Label8.Text = "Nro. Afiliado:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tb_tiempoHD)
        Me.GroupBox3.Controls.Add(Me.tb_HE)
        Me.GroupBox3.Controls.Add(Me.tb_HI)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lbl_err3)
        Me.GroupBox3.Location = New System.Drawing.Point(527, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 106)
        Me.GroupBox3.TabIndex = 322
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Horario"
        '
        'tb_tiempoHD
        '
        Me.tb_tiempoHD.Location = New System.Drawing.Point(88, 77)
        Me.tb_tiempoHD.Mask = "00:00"
        Me.tb_tiempoHD.Name = "tb_tiempoHD"
        Me.tb_tiempoHD.Size = New System.Drawing.Size(79, 20)
        Me.tb_tiempoHD.TabIndex = 2
        Me.tb_tiempoHD.Text = "0000"
        Me.tb_tiempoHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_tiempoHD.ValidatingType = GetType(Date)
        '
        'tb_HE
        '
        Me.tb_HE.Location = New System.Drawing.Point(88, 48)
        Me.tb_HE.Mask = "00:00"
        Me.tb_HE.Name = "tb_HE"
        Me.tb_HE.Size = New System.Drawing.Size(79, 20)
        Me.tb_HE.TabIndex = 1
        Me.tb_HE.Text = "0000"
        Me.tb_HE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_HE.ValidatingType = GetType(Date)
        '
        'tb_HI
        '
        Me.tb_HI.Location = New System.Drawing.Point(88, 22)
        Me.tb_HI.Mask = "00:00"
        Me.tb_HI.Name = "tb_HI"
        Me.tb_HI.Size = New System.Drawing.Size(79, 20)
        Me.tb_HI.TabIndex = 0
        Me.tb_HI.Text = "0000"
        Me.tb_HI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_HI.ValidatingType = GetType(Date)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 330
        Me.Label16.Text = "Tiempo de HD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 269
        Me.Label3.Text = "Egreso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 268
        Me.Label2.Text = "Ingreso:"
        '
        'lbl_err3
        '
        Me.lbl_err3.AutoSize = True
        Me.lbl_err3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_err3.ForeColor = System.Drawing.Color.Red
        Me.lbl_err3.Location = New System.Drawing.Point(214, 5)
        Me.lbl_err3.Name = "lbl_err3"
        Me.lbl_err3.Size = New System.Drawing.Size(20, 21)
        Me.lbl_err3.TabIndex = 339
        Me.lbl_err3.Text = "*"
        Me.lbl_err3.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tb_PesoE)
        Me.GroupBox4.Controls.Add(Me.tb_PesoI)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lbl_err4)
        Me.GroupBox4.Location = New System.Drawing.Point(797, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 106)
        Me.GroupBox4.TabIndex = 323
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Peso"
        '
        'tb_PesoE
        '
        Me.tb_PesoE.Location = New System.Drawing.Point(70, 55)
        Me.tb_PesoE.Name = "tb_PesoE"
        Me.tb_PesoE.Size = New System.Drawing.Size(79, 20)
        Me.tb_PesoE.TabIndex = 1
        Me.tb_PesoE.Text = "0,00"
        Me.tb_PesoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_PesoI
        '
        Me.tb_PesoI.Location = New System.Drawing.Point(70, 22)
        Me.tb_PesoI.Name = "tb_PesoI"
        Me.tb_PesoI.Size = New System.Drawing.Size(79, 20)
        Me.tb_PesoI.TabIndex = 0
        Me.tb_PesoI.Text = "0,00"
        Me.tb_PesoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 269
        Me.Label9.Text = "Egreso"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 268
        Me.Label11.Text = "Ingreso:"
        '
        'lbl_err4
        '
        Me.lbl_err4.AutoSize = True
        Me.lbl_err4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_err4.ForeColor = System.Drawing.Color.Red
        Me.lbl_err4.Location = New System.Drawing.Point(150, 5)
        Me.lbl_err4.Name = "lbl_err4"
        Me.lbl_err4.Size = New System.Drawing.Size(20, 21)
        Me.lbl_err4.TabIndex = 340
        Me.lbl_err4.Text = "*"
        Me.lbl_err4.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tb_TAE)
        Me.GroupBox5.Controls.Add(Me.tb_TAI)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.lbl_err5)
        Me.GroupBox5.Location = New System.Drawing.Point(1023, 36)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(176, 93)
        Me.GroupBox5.TabIndex = 324
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tension Arterial"
        '
        'tb_TAE
        '
        Me.tb_TAE.Location = New System.Drawing.Point(70, 52)
        Me.tb_TAE.Name = "tb_TAE"
        Me.tb_TAE.Size = New System.Drawing.Size(79, 20)
        Me.tb_TAE.TabIndex = 1
        Me.tb_TAE.Text = "0,00"
        Me.tb_TAE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_TAI
        '
        Me.tb_TAI.Location = New System.Drawing.Point(70, 26)
        Me.tb_TAI.Name = "tb_TAI"
        Me.tb_TAI.Size = New System.Drawing.Size(79, 20)
        Me.tb_TAI.TabIndex = 0
        Me.tb_TAI.Text = "0,00"
        Me.tb_TAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 269
        Me.Label12.Text = "Egreso"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 268
        Me.Label13.Text = "Ingreso:"
        '
        'lbl_err5
        '
        Me.lbl_err5.AutoSize = True
        Me.lbl_err5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_err5.ForeColor = System.Drawing.Color.Red
        Me.lbl_err5.Location = New System.Drawing.Point(155, 5)
        Me.lbl_err5.Name = "lbl_err5"
        Me.lbl_err5.Size = New System.Drawing.Size(20, 21)
        Me.lbl_err5.TabIndex = 341
        Me.lbl_err5.Text = "*"
        Me.lbl_err5.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(381, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 328
        Me.Label14.Text = "Talla"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(186, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 327
        Me.Label15.Text = "Peso Seco"
        '
        'GroupBox_insumos
        '
        Me.GroupBox_insumos.Controls.Add(Me.btn_eliminar_seleccion)
        Me.GroupBox_insumos.Controls.Add(Me.DataGridView2)
        Me.GroupBox_insumos.Controls.Add(Me.btn_Buscar)
        Me.GroupBox_insumos.Controls.Add(Me.Label22)
        Me.GroupBox_insumos.Controls.Add(Me.btn_limpiar)
        Me.GroupBox_insumos.Controls.Add(Me.DataGridView1)
        Me.GroupBox_insumos.Location = New System.Drawing.Point(12, 337)
        Me.GroupBox_insumos.Name = "GroupBox_insumos"
        Me.GroupBox_insumos.Size = New System.Drawing.Size(1212, 269)
        Me.GroupBox_insumos.TabIndex = 330
        Me.GroupBox_insumos.TabStop = False
        '
        'btn_eliminar_seleccion
        '
        Me.btn_eliminar_seleccion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_eliminar_seleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_seleccion.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_eliminar_seleccion.Location = New System.Drawing.Point(111, 36)
        Me.btn_eliminar_seleccion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar_seleccion.Name = "btn_eliminar_seleccion"
        Me.btn_eliminar_seleccion.Size = New System.Drawing.Size(94, 40)
        Me.btn_eliminar_seleccion.TabIndex = 337
        Me.btn_eliminar_seleccion.Text = "Quitar"
        Me.btn_eliminar_seleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_eliminar_seleccion, "Quitar insumos seleccionados")
        Me.btn_eliminar_seleccion.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodprodDataGridViewTextBoxColumn1, Me.DescripcionDataGridViewTextBoxColumn1, Me.DesdeDataGridViewTextBoxColumn1, Me.HaciaDataGridViewTextBoxColumn1, Me.CantidadrealDataGridViewTextBoxColumn, Me.LoteidDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn13, Me.ProvidDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridView2.DataSource = Me.ConsumorealBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(719, 20)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(350, 156)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 336
        Me.DataGridView2.Visible = False
        '
        'CodprodDataGridViewTextBoxColumn1
        '
        Me.CodprodDataGridViewTextBoxColumn1.DataPropertyName = "Cod_prod"
        Me.CodprodDataGridViewTextBoxColumn1.HeaderText = "Cod_prod"
        Me.CodprodDataGridViewTextBoxColumn1.Name = "CodprodDataGridViewTextBoxColumn1"
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        '
        'DesdeDataGridViewTextBoxColumn1
        '
        Me.DesdeDataGridViewTextBoxColumn1.DataPropertyName = "Desde"
        Me.DesdeDataGridViewTextBoxColumn1.HeaderText = "Desde"
        Me.DesdeDataGridViewTextBoxColumn1.Name = "DesdeDataGridViewTextBoxColumn1"
        '
        'HaciaDataGridViewTextBoxColumn1
        '
        Me.HaciaDataGridViewTextBoxColumn1.DataPropertyName = "Hacia"
        Me.HaciaDataGridViewTextBoxColumn1.HeaderText = "Hacia"
        Me.HaciaDataGridViewTextBoxColumn1.Name = "HaciaDataGridViewTextBoxColumn1"
        '
        'CantidadrealDataGridViewTextBoxColumn
        '
        Me.CantidadrealDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_real"
        Me.CantidadrealDataGridViewTextBoxColumn.HeaderText = "Cantidad_real"
        Me.CantidadrealDataGridViewTextBoxColumn.Name = "CantidadrealDataGridViewTextBoxColumn"
        '
        'LoteidDataGridViewTextBoxColumn
        '
        Me.LoteidDataGridViewTextBoxColumn.DataPropertyName = "lote_id"
        Me.LoteidDataGridViewTextBoxColumn.HeaderText = "lote_id"
        Me.LoteidDataGridViewTextBoxColumn.Name = "LoteidDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Prov_id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Prov_id"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'ProvidDataGridViewTextBoxColumn
        '
        Me.ProvidDataGridViewTextBoxColumn.DataPropertyName = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.HeaderText = "Prov_id"
        Me.ProvidDataGridViewTextBoxColumn.Name = "ProvidDataGridViewTextBoxColumn"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'ConsumorealBindingSource
        '
        Me.ConsumorealBindingSource.DataMember = "Consumo_real"
        Me.ConsumorealBindingSource.DataSource = Me.Ds_enfermeria
        '
        'Ds_enfermeria
        '
        Me.Ds_enfermeria.DataSetName = "Ds_enfermeria"
        Me.Ds_enfermeria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(9, 36)
        Me.btn_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(94, 40)
        Me.btn_Buscar.TabIndex = 335
        Me.btn_Buscar.Text = "Buscar "
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(6, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(154, 16)
        Me.Label22.TabIndex = 334
        Me.Label22.Text = "Insumos Consumidos"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Image = Global.Aplicacion.My.Resources.Resources.Borrar
        Me.btn_limpiar.Location = New System.Drawing.Point(213, 36)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(94, 40)
        Me.btn_limpiar.TabIndex = 333
        Me.btn_limpiar.Text = "Quitar Listado"
        Me.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_limpiar, "Quitar todos los insumos listados")
        Me.btn_limpiar.UseVisualStyleBackColor = True
        Me.btn_limpiar.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDataGridViewTextBoxColumn, Me.CodprodDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DesdeDataGridViewTextBoxColumn, Me.HaciaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.Cantidad_a_consumir, Me.Lote, Me.FechaFabricacionDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.VenceDataGridViewTextBoxColumn, Me.PrecioUDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.Prov_id, Me.Column2, Me.EnBD})
        Me.DataGridView1.DataSource = Me.MovEnfBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(5, 84)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1193, 156)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 331
        '
        'NDataGridViewTextBoxColumn
        '
        Me.NDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NDataGridViewTextBoxColumn.DataPropertyName = "N°"
        Me.NDataGridViewTextBoxColumn.FillWeight = 35.53299!
        Me.NDataGridViewTextBoxColumn.HeaderText = "N°"
        Me.NDataGridViewTextBoxColumn.Name = "NDataGridViewTextBoxColumn"
        Me.NDataGridViewTextBoxColumn.ReadOnly = True
        Me.NDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NDataGridViewTextBoxColumn.Width = 71
        '
        'CodprodDataGridViewTextBoxColumn
        '
        Me.CodprodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodprodDataGridViewTextBoxColumn.DataPropertyName = "Cod_prod"
        Me.CodprodDataGridViewTextBoxColumn.FillWeight = 110.7445!
        Me.CodprodDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodprodDataGridViewTextBoxColumn.Name = "CodprodDataGridViewTextBoxColumn"
        Me.CodprodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.FillWeight = 110.7445!
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DesdeDataGridViewTextBoxColumn
        '
        Me.DesdeDataGridViewTextBoxColumn.DataPropertyName = "Desde"
        Me.DesdeDataGridViewTextBoxColumn.HeaderText = "Desde"
        Me.DesdeDataGridViewTextBoxColumn.Name = "DesdeDataGridViewTextBoxColumn"
        Me.DesdeDataGridViewTextBoxColumn.Visible = False
        '
        'HaciaDataGridViewTextBoxColumn
        '
        Me.HaciaDataGridViewTextBoxColumn.DataPropertyName = "Hacia"
        Me.HaciaDataGridViewTextBoxColumn.HeaderText = "Hacia"
        Me.HaciaDataGridViewTextBoxColumn.Name = "HaciaDataGridViewTextBoxColumn"
        Me.HaciaDataGridViewTextBoxColumn.Visible = False
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.FillWeight = 110.7445!
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Visible = False
        '
        'Cantidad_a_consumir
        '
        Me.Cantidad_a_consumir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cantidad_a_consumir.DataPropertyName = "Cantidad_a_consumir"
        Me.Cantidad_a_consumir.HeaderText = "Cantidad a consumir"
        Me.Cantidad_a_consumir.Name = "Cantidad_a_consumir"
        Me.Cantidad_a_consumir.ReadOnly = True
        '
        'Lote
        '
        Me.Lote.DataPropertyName = "Lote"
        Me.Lote.FillWeight = 110.7445!
        Me.Lote.HeaderText = "Lote"
        Me.Lote.Name = "Lote"
        Me.Lote.Visible = False
        '
        'FechaFabricacionDataGridViewTextBoxColumn
        '
        Me.FechaFabricacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaFabricacionDataGridViewTextBoxColumn.DataPropertyName = "FechaFabricacion"
        Me.FechaFabricacionDataGridViewTextBoxColumn.FillWeight = 110.7445!
        Me.FechaFabricacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Fabricacion"
        Me.FechaFabricacionDataGridViewTextBoxColumn.Name = "FechaFabricacionDataGridViewTextBoxColumn"
        Me.FechaFabricacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaFabricacionDataGridViewTextBoxColumn.Visible = False
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.FillWeight = 110.7445!
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Vencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaVencimientoDataGridViewTextBoxColumn.Visible = False
        '
        'VenceDataGridViewTextBoxColumn
        '
        Me.VenceDataGridViewTextBoxColumn.DataPropertyName = "Vence"
        Me.VenceDataGridViewTextBoxColumn.HeaderText = "Vence"
        Me.VenceDataGridViewTextBoxColumn.Name = "VenceDataGridViewTextBoxColumn"
        Me.VenceDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioUDataGridViewTextBoxColumn
        '
        Me.PrecioUDataGridViewTextBoxColumn.DataPropertyName = "PrecioU"
        Me.PrecioUDataGridViewTextBoxColumn.HeaderText = "PrecioU"
        Me.PrecioUDataGridViewTextBoxColumn.Name = "PrecioUDataGridViewTextBoxColumn"
        Me.PrecioUDataGridViewTextBoxColumn.Visible = False
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.Visible = False
        '
        'Prov_id
        '
        Me.Prov_id.DataPropertyName = "Prov_id"
        Me.Prov_id.HeaderText = "Prov_id"
        Me.Prov_id.Name = "Prov_id"
        Me.Prov_id.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "Item"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 40
        '
        'EnBD
        '
        Me.EnBD.DataPropertyName = "EnBD"
        Me.EnBD.HeaderText = "EnBD"
        Me.EnBD.Name = "EnBD"
        Me.EnBD.Visible = False
        '
        'MovEnfBindingSource
        '
        Me.MovEnfBindingSource.DataMember = "Mov_Enf"
        Me.MovEnfBindingSource.DataSource = Me.Mov_DS
        '
        'Mov_DS
        '
        Me.Mov_DS.DataSetName = "Mov_DS"
        Me.Mov_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 13)
        Me.Label18.TabIndex = 332
        Me.Label18.Text = "Tipo"
        '
        'tb_Filtro
        '
        Me.tb_Filtro.Location = New System.Drawing.Point(228, 68)
        Me.tb_Filtro.Multiline = True
        Me.tb_Filtro.Name = "tb_Filtro"
        Me.tb_Filtro.Size = New System.Drawing.Size(110, 20)
        Me.tb_Filtro.TabIndex = 331
        Me.tb_Filtro.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(524, 183)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 334
        Me.Label19.Text = "Observaciones"
        '
        'tb_Obs
        '
        Me.tb_Obs.Location = New System.Drawing.Point(608, 158)
        Me.tb_Obs.Multiline = True
        Me.tb_Obs.Name = "tb_Obs"
        Me.tb_Obs.Size = New System.Drawing.Size(559, 38)
        Me.tb_Obs.TabIndex = 333
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.GroupBox2)
        Me.GroupBox7.Controls.Add(Me.lbl_err7)
        Me.GroupBox7.Controls.Add(Me.tb_talla)
        Me.GroupBox7.Controls.Add(Me.tb_PesoS)
        Me.GroupBox7.Controls.Add(Me.btn_NAV)
        Me.GroupBox7.Controls.Add(Me.tb_AV)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Controls.Add(Me.lbl_err6)
        Me.GroupBox7.Controls.Add(Me.lbl_err1)
        Me.GroupBox7.Controls.Add(Me.lbl_err)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.tb_numHemo)
        Me.GroupBox7.Controls.Add(Me.tb_Obs)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.GroupBox4)
        Me.GroupBox7.Controls.Add(Me.GroupBox5)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1212, 205)
        Me.GroupBox7.TabIndex = 335
        Me.GroupBox7.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_filtro)
        Me.GroupBox2.Controls.Add(Me.btn_cambio)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.tb_CantRe)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.tb_Filtro)
        Me.GroupBox2.Controls.Add(Me.lbl_err2)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 97)
        Me.GroupBox2.TabIndex = 355
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro"
        '
        'cb_filtro
        '
        Me.cb_filtro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_filtro.Enabled = False
        Me.cb_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_filtro.FormattingEnabled = True
        Me.cb_filtro.Location = New System.Drawing.Point(41, 41)
        Me.cb_filtro.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_filtro.Name = "cb_filtro"
        Me.cb_filtro.Size = New System.Drawing.Size(134, 21)
        Me.cb_filtro.TabIndex = 357
        '
        'btn_cambio
        '
        Me.btn_cambio.Enabled = False
        Me.btn_cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cambio.Location = New System.Drawing.Point(344, 40)
        Me.btn_cambio.Name = "btn_cambio"
        Me.btn_cambio.Size = New System.Drawing.Size(128, 23)
        Me.btn_cambio.TabIndex = 356
        Me.btn_cambio.Text = "Cambio de Filtro"
        Me.btn_cambio.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(187, 45)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 13)
        Me.Label24.TabIndex = 339
        Me.Label24.Text = "Cant. de Reusos"
        '
        'tb_CantRe
        '
        Me.tb_CantRe.Enabled = False
        Me.tb_CantRe.Location = New System.Drawing.Point(279, 42)
        Me.tb_CantRe.Multiline = True
        Me.tb_CantRe.Name = "tb_CantRe"
        Me.tb_CantRe.Size = New System.Drawing.Size(59, 20)
        Me.tb_CantRe.TabIndex = 338
        '
        'lbl_err2
        '
        Me.lbl_err2.AutoSize = True
        Me.lbl_err2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_err2.ForeColor = System.Drawing.Color.Red
        Me.lbl_err2.Location = New System.Drawing.Point(157, 37)
        Me.lbl_err2.Name = "lbl_err2"
        Me.lbl_err2.Size = New System.Drawing.Size(20, 21)
        Me.lbl_err2.TabIndex = 337
        Me.lbl_err2.Text = "*"
        Me.lbl_err2.Visible = False
        '
        'lbl_err7
        '
        Me.lbl_err7.AutoSize = True
        Me.lbl_err7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_err7.ForeColor = System.Drawing.Color.Red
        Me.lbl_err7.Location = New System.Drawing.Point(283, 72)
        Me.lbl_err7.Name = "lbl_err7"
        Me.lbl_err7.Size = New System.Drawing.Size(20, 21)
        Me.lbl_err7.TabIndex = 354
        Me.lbl_err7.Text = "*"
        Me.lbl_err7.Visible = False
        '
        'tb_talla
        '
        Me.tb_talla.Location = New System.Drawing.Point(417, 34)
        Me.tb_talla.Name = "tb_talla"
        Me.tb_talla.Size = New System.Drawing.Size(79, 20)
        Me.tb_talla.TabIndex = 1
        Me.tb_talla.Text = "0,00"
        Me.tb_talla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_PesoS
        '
        Me.tb_PesoS.Location = New System.Drawing.Point(254, 34)
        Me.tb_PesoS.Name = "tb_PesoS"
        Me.tb_PesoS.Size = New System.Drawing.Size(79, 20)
        Me.tb_PesoS.TabIndex = 0
        Me.tb_PesoS.Text = "0,00"
        Me.tb_PesoS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_NAV
        '
        Me.btn_NAV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NAV.Location = New System.Drawing.Point(307, 69)
        Me.btn_NAV.Name = "btn_NAV"
        Me.btn_NAV.Size = New System.Drawing.Size(189, 23)
        Me.btn_NAV.TabIndex = 344
        Me.btn_NAV.Text = "Nuevo Acceso Vascular"
        Me.btn_NAV.UseVisualStyleBackColor = True
        '
        'tb_AV
        '
        Me.tb_AV.Location = New System.Drawing.Point(138, 72)
        Me.tb_AV.Name = "tb_AV"
        Me.tb_AV.Size = New System.Drawing.Size(140, 20)
        Me.tb_AV.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 79)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 13)
        Me.Label23.TabIndex = 343
        Me.Label23.Text = "Tipo de Acceso Vascular"
        '
        'lbl_err6
        '
        Me.lbl_err6.AutoSize = True
        Me.lbl_err6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_err6.ForeColor = System.Drawing.Color.Red
        Me.lbl_err6.Location = New System.Drawing.Point(1173, 158)
        Me.lbl_err6.Name = "lbl_err6"
        Me.lbl_err6.Size = New System.Drawing.Size(20, 21)
        Me.lbl_err6.TabIndex = 338
        Me.lbl_err6.Text = "*"
        Me.lbl_err6.Visible = False
        '
        'lbl_err1
        '
        Me.lbl_err1.AutoSize = True
        Me.lbl_err1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_err1.ForeColor = System.Drawing.Color.Red
        Me.lbl_err1.Location = New System.Drawing.Point(501, 36)
        Me.lbl_err1.Name = "lbl_err1"
        Me.lbl_err1.Size = New System.Drawing.Size(20, 21)
        Me.lbl_err1.TabIndex = 336
        Me.lbl_err1.Text = "*"
        Me.lbl_err1.Visible = False
        '
        'lbl_err
        '
        Me.lbl_err.AutoSize = True
        Me.lbl_err.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_err.ForeColor = System.Drawing.Color.Red
        Me.lbl_err.Location = New System.Drawing.Point(339, 36)
        Me.lbl_err.Name = "lbl_err"
        Me.lbl_err.Size = New System.Drawing.Size(20, 21)
        Me.lbl_err.TabIndex = 335
        Me.lbl_err.Text = "*"
        Me.lbl_err.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label20.Location = New System.Drawing.Point(6, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 16)
        Me.Label20.TabIndex = 269
        Me.Label20.Text = "Datos Hemodiálisis"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.btn_cancelar.Location = New System.Drawing.Point(832, 613)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.MaximumSize = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_cancelar.TabIndex = 336
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = Global.Aplicacion.My.Resources.Resources.conectar
        Me.btn_guardar.Location = New System.Drawing.Point(964, 613)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.MaximumSize = New System.Drawing.Size(124, 43)
        Me.btn_guardar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(124, 43)
        Me.btn_guardar.TabIndex = 335
        Me.btn_guardar.Text = "Conectar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_finalizar
        '
        Me.btn_finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_finalizar.Location = New System.Drawing.Point(1096, 613)
        Me.btn_finalizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_finalizar.MaximumSize = New System.Drawing.Size(124, 43)
        Me.btn_finalizar.MinimumSize = New System.Drawing.Size(124, 43)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(124, 43)
        Me.btn_finalizar.TabIndex = 337
        Me.btn_finalizar.Text = "Finalizar"
        Me.btn_finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_finalizar.UseVisualStyleBackColor = True
        '
        'Nueva_Dialisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox_insumos)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Nueva_Dialisis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Dialisis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox_insumos.ResumeLayout(False)
        Me.GroupBox_insumos.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumorealBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovEnfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mov_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_numHemo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_Dni_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tb_numafi As System.Windows.Forms.TextBox
    Friend WithEvents tb_obsoc As System.Windows.Forms.TextBox
    Friend WithEvents tb_sexo As System.Windows.Forms.TextBox
    Friend WithEvents tb_edad As System.Windows.Forms.TextBox
    Friend WithEvents tb_fecnac As System.Windows.Forms.TextBox
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox_insumos As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tb_Filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tb_Obs As System.Windows.Forms.TextBox
    Friend WithEvents MovEnfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mov_DS As Aplicacion.Mov_DS
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_err5 As System.Windows.Forms.Label
    Friend WithEvents lbl_err3 As System.Windows.Forms.Label
    Friend WithEvents lbl_err4 As System.Windows.Forms.Label
    Friend WithEvents lbl_err6 As System.Windows.Forms.Label
    Friend WithEvents lbl_err2 As System.Windows.Forms.Label
    Friend WithEvents lbl_err1 As System.Windows.Forms.Label
    Friend WithEvents lbl_err As System.Windows.Forms.Label
    Friend WithEvents btn_NAV As System.Windows.Forms.Button
    Friend WithEvents tb_AV As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tb_tiempoHD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_HE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_HI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_PesoI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_PesoE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_TAE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_TAI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_talla As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_PesoS As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_err7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cambio As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tb_CantRe As System.Windows.Forms.TextBox
    Public WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents CodprodDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesdeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaciaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadrealDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ConsumorealBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_enfermeria As Aplicacion.Ds_enfermeria
    Friend WithEvents btn_eliminar_seleccion As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_a_consumir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFabricacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prov_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EnBD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_estado As System.Windows.Forms.Label
    Friend WithEvents btn_finalizar As System.Windows.Forms.Button
    Friend WithEvents cb_filtro As System.Windows.Forms.ComboBox
End Class
