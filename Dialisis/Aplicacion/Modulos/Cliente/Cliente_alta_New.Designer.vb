<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_alta_New
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_ape = New System.Windows.Forms.TextBox()
        Me.ComboBox_estadocivil = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Tb_nombre = New System.Windows.Forms.TextBox()
        Me.lb_dni = New System.Windows.Forms.Label()
        Me.tb_Dni_Cuit = New System.Windows.Forms.TextBox()
        Me.FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.error_razonsocial = New System.Windows.Forms.Label()
        Me.error_dni = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox_Sexo = New System.Windows.Forms.ComboBox()
        Me.tb_edad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txt_chofer = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.estado_inactivo = New System.Windows.Forms.RadioButton()
        Me.estado_activo = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_HDF = New System.Windows.Forms.RadioButton()
        Me.RadioButton_EMODIALISIS = New System.Windows.Forms.RadioButton()
        Me.RadioButton_DPA = New System.Windows.Forms.RadioButton()
        Me.RadioButton_DPCA = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_turno = New System.Windows.Forms.CheckBox()
        Me.cb_turnos = New System.Windows.Forms.ComboBox()
        Me.txt_horario = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_dias = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tipopaciente_cronico = New System.Windows.Forms.RadioButton()
        Me.tipopaciente_agudo = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DateTimePicker_fechaingreso = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_mail = New System.Windows.Forms.Label()
        Me.tx_tel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tx_mail = New System.Windows.Forms.TextBox()
        Me.lb_tel = New System.Windows.Forms.Label()
        Me.tx_dir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_Cp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_Prov = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Combo_Loc = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.error_afiliado = New System.Windows.Forms.Label()
        Me.ComboBox_obrasocial = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tx_NumAfi = New System.Windows.Forms.TextBox()
        Me.UpR = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label_fechaalta = New System.Windows.Forms.Label()
        Me.CheckBox_estado = New System.Windows.Forms.CheckBox()
        Me.txt_limitedeuda = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ctacte = New System.Windows.Forms.TextBox()
        Me.CheckBox_habilitar_ctacte = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Combo_Iva = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UpR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Cancelar.Location = New System.Drawing.Point(975, 484)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Cancelar.TabIndex = 1
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Cancelar, "Cancelar")
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(1105, 484)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(124, 43)
        Me.btn_Aceptar.TabIndex = 0
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Aceptar, "Guardar")
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1244, 533)
        Me.Panel3.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.UpR)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Combo_Iva)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(610, 620)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1244, 620)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Complete la siguiente información:"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.tx_ape)
        Me.Panel5.Controls.Add(Me.ComboBox_estadocivil)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Tb_nombre)
        Me.Panel5.Controls.Add(Me.lb_dni)
        Me.Panel5.Controls.Add(Me.tb_Dni_Cuit)
        Me.Panel5.Controls.Add(Me.FechaNac)
        Me.Panel5.Controls.Add(Me.error_razonsocial)
        Me.Panel5.Controls.Add(Me.error_dni)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.ComboBox_Sexo)
        Me.Panel5.Controls.Add(Me.tb_edad)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Location = New System.Drawing.Point(16, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(556, 207)
        Me.Panel5.TabIndex = 285
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 253
        Me.Label4.Text = "Apellido"
        '
        'tx_ape
        '
        Me.tx_ape.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_ape.Location = New System.Drawing.Point(125, 5)
        Me.tx_ape.Name = "tx_ape"
        Me.tx_ape.Size = New System.Drawing.Size(354, 26)
        Me.tx_ape.TabIndex = 0
        '
        'ComboBox_estadocivil
        '
        Me.ComboBox_estadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_estadocivil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_estadocivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_estadocivil.FormattingEnabled = True
        Me.ComboBox_estadocivil.Location = New System.Drawing.Point(125, 166)
        Me.ComboBox_estadocivil.Name = "ComboBox_estadocivil"
        Me.ComboBox_estadocivil.Size = New System.Drawing.Size(354, 28)
        Me.ComboBox_estadocivil.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 267
        Me.Label10.Text = "Nombre"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(10, 169)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 20)
        Me.Label18.TabIndex = 282
        Me.Label18.Text = "Estado civil:"
        '
        'Tb_nombre
        '
        Me.Tb_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_nombre.Location = New System.Drawing.Point(126, 35)
        Me.Tb_nombre.Name = "Tb_nombre"
        Me.Tb_nombre.Size = New System.Drawing.Size(354, 26)
        Me.Tb_nombre.TabIndex = 1
        '
        'lb_dni
        '
        Me.lb_dni.AutoSize = True
        Me.lb_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dni.ForeColor = System.Drawing.Color.Black
        Me.lb_dni.Location = New System.Drawing.Point(10, 66)
        Me.lb_dni.Name = "lb_dni"
        Me.lb_dni.Size = New System.Drawing.Size(110, 20)
        Me.lb_dni.TabIndex = 237
        Me.lb_dni.Text = "DNI / N° CUIT:"
        '
        'tb_Dni_Cuit
        '
        Me.tb_Dni_Cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Dni_Cuit.Location = New System.Drawing.Point(126, 64)
        Me.tb_Dni_Cuit.Name = "tb_Dni_Cuit"
        Me.tb_Dni_Cuit.Size = New System.Drawing.Size(354, 26)
        Me.tb_Dni_Cuit.TabIndex = 2
        '
        'FechaNac
        '
        Me.FechaNac.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNac.Location = New System.Drawing.Point(126, 96)
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.Size = New System.Drawing.Size(136, 26)
        Me.FechaNac.TabIndex = 3
        '
        'error_razonsocial
        '
        Me.error_razonsocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.error_razonsocial.AutoSize = True
        Me.error_razonsocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_razonsocial.ForeColor = System.Drawing.Color.Red
        Me.error_razonsocial.Location = New System.Drawing.Point(524, 5)
        Me.error_razonsocial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_razonsocial.Name = "error_razonsocial"
        Me.error_razonsocial.Size = New System.Drawing.Size(26, 31)
        Me.error_razonsocial.TabIndex = 263
        Me.error_razonsocial.Text = "*"
        Me.error_razonsocial.Visible = False
        '
        'error_dni
        '
        Me.error_dni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.error_dni.AutoSize = True
        Me.error_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_dni.ForeColor = System.Drawing.Color.Red
        Me.error_dni.Location = New System.Drawing.Point(524, 66)
        Me.error_dni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_dni.Name = "error_dni"
        Me.error_dni.Size = New System.Drawing.Size(26, 31)
        Me.error_dni.TabIndex = 264
        Me.error_dni.Text = "*"
        Me.error_dni.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 20)
        Me.Label12.TabIndex = 270
        Me.Label12.Text = "Fecha de Nac:"
        '
        'ComboBox_Sexo
        '
        Me.ComboBox_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Sexo.FormattingEnabled = True
        Me.ComboBox_Sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.ComboBox_Sexo.Location = New System.Drawing.Point(125, 131)
        Me.ComboBox_Sexo.Name = "ComboBox_Sexo"
        Me.ComboBox_Sexo.Size = New System.Drawing.Size(144, 28)
        Me.ComboBox_Sexo.TabIndex = 4
        '
        'tb_edad
        '
        Me.tb_edad.Enabled = False
        Me.tb_edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_edad.Location = New System.Drawing.Point(325, 98)
        Me.tb_edad.Name = "tb_edad"
        Me.tb_edad.Size = New System.Drawing.Size(154, 26)
        Me.tb_edad.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(10, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 20)
        Me.Label14.TabIndex = 273
        Me.Label14.Text = "Sexo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(268, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 20)
        Me.Label13.TabIndex = 272
        Me.Label13.Text = "Edad:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox7)
        Me.Panel4.Controls.Add(Me.GroupBox6)
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Controls.Add(Me.GroupBox5)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.DateTimePicker_fechaingreso)
        Me.Panel4.Location = New System.Drawing.Point(597, 115)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(633, 356)
        Me.Panel4.TabIndex = 288
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txt_chofer)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 255)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(610, 85)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ingrese Chofer designado:"
        '
        'txt_chofer
        '
        Me.txt_chofer.Location = New System.Drawing.Point(11, 35)
        Me.txt_chofer.Name = "txt_chofer"
        Me.txt_chofer.Size = New System.Drawing.Size(321, 22)
        Me.txt_chofer.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.estado_inactivo)
        Me.GroupBox6.Controls.Add(Me.estado_activo)
        Me.GroupBox6.Location = New System.Drawing.Point(300, 166)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(317, 88)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Estado en el sistema:"
        '
        'estado_inactivo
        '
        Me.estado_inactivo.AutoSize = True
        Me.estado_inactivo.Location = New System.Drawing.Point(30, 53)
        Me.estado_inactivo.Name = "estado_inactivo"
        Me.estado_inactivo.Size = New System.Drawing.Size(72, 20)
        Me.estado_inactivo.TabIndex = 1
        Me.estado_inactivo.Text = "Inactivo"
        Me.estado_inactivo.UseVisualStyleBackColor = True
        '
        'estado_activo
        '
        Me.estado_activo.AutoSize = True
        Me.estado_activo.Checked = True
        Me.estado_activo.Location = New System.Drawing.Point(30, 27)
        Me.estado_activo.Name = "estado_activo"
        Me.estado_activo.Size = New System.Drawing.Size(63, 20)
        Me.estado_activo.TabIndex = 0
        Me.estado_activo.TabStop = True
        Me.estado_activo.Text = "Activo"
        Me.estado_activo.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton_HDF)
        Me.GroupBox4.Controls.Add(Me.RadioButton_EMODIALISIS)
        Me.GroupBox4.Controls.Add(Me.RadioButton_DPA)
        Me.GroupBox4.Controls.Add(Me.RadioButton_DPCA)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 124)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(274, 130)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de diálisis"
        '
        'RadioButton_HDF
        '
        Me.RadioButton_HDF.AutoSize = True
        Me.RadioButton_HDF.Location = New System.Drawing.Point(51, 102)
        Me.RadioButton_HDF.Name = "RadioButton_HDF"
        Me.RadioButton_HDF.Size = New System.Drawing.Size(54, 20)
        Me.RadioButton_HDF.TabIndex = 3
        Me.RadioButton_HDF.Text = "HDF"
        Me.RadioButton_HDF.UseVisualStyleBackColor = True
        '
        'RadioButton_EMODIALISIS
        '
        Me.RadioButton_EMODIALISIS.AutoSize = True
        Me.RadioButton_EMODIALISIS.Location = New System.Drawing.Point(51, 76)
        Me.RadioButton_EMODIALISIS.Name = "RadioButton_EMODIALISIS"
        Me.RadioButton_EMODIALISIS.Size = New System.Drawing.Size(119, 20)
        Me.RadioButton_EMODIALISIS.TabIndex = 2
        Me.RadioButton_EMODIALISIS.Text = "HEMODIALISIS"
        Me.RadioButton_EMODIALISIS.UseVisualStyleBackColor = True
        '
        'RadioButton_DPA
        '
        Me.RadioButton_DPA.AutoSize = True
        Me.RadioButton_DPA.Location = New System.Drawing.Point(51, 49)
        Me.RadioButton_DPA.Name = "RadioButton_DPA"
        Me.RadioButton_DPA.Size = New System.Drawing.Size(54, 20)
        Me.RadioButton_DPA.TabIndex = 1
        Me.RadioButton_DPA.Text = "DPA"
        Me.RadioButton_DPA.UseVisualStyleBackColor = True
        '
        'RadioButton_DPCA
        '
        Me.RadioButton_DPCA.AutoSize = True
        Me.RadioButton_DPCA.Checked = True
        Me.RadioButton_DPCA.Location = New System.Drawing.Point(51, 23)
        Me.RadioButton_DPCA.Name = "RadioButton_DPCA"
        Me.RadioButton_DPCA.Size = New System.Drawing.Size(63, 20)
        Me.RadioButton_DPCA.TabIndex = 0
        Me.RadioButton_DPCA.TabStop = True
        Me.RadioButton_DPCA.Text = "DPCA"
        Me.RadioButton_DPCA.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckBox_turno)
        Me.GroupBox5.Controls.Add(Me.cb_turnos)
        Me.GroupBox5.Controls.Add(Me.txt_horario)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.txt_dias)
        Me.GroupBox5.Location = New System.Drawing.Point(300, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(317, 155)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Asignar turno"
        '
        'CheckBox_turno
        '
        Me.CheckBox_turno.AutoSize = True
        Me.CheckBox_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_turno.Location = New System.Drawing.Point(214, 119)
        Me.CheckBox_turno.Name = "CheckBox_turno"
        Me.CheckBox_turno.Size = New System.Drawing.Size(86, 20)
        Me.CheckBox_turno.TabIndex = 4
        Me.CheckBox_turno.Text = "Habilitar"
        Me.CheckBox_turno.UseVisualStyleBackColor = True
        '
        'cb_turnos
        '
        Me.cb_turnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_turnos.Enabled = False
        Me.cb_turnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_turnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_turnos.FormattingEnabled = True
        Me.cb_turnos.Location = New System.Drawing.Point(10, 21)
        Me.cb_turnos.Name = "cb_turnos"
        Me.cb_turnos.Size = New System.Drawing.Size(290, 28)
        Me.cb_turnos.TabIndex = 289
        '
        'txt_horario
        '
        Me.txt_horario.Location = New System.Drawing.Point(65, 81)
        Me.txt_horario.Name = "txt_horario"
        Me.txt_horario.ReadOnly = True
        Me.txt_horario.Size = New System.Drawing.Size(235, 22)
        Me.txt_horario.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 16)
        Me.Label20.TabIndex = 286
        Me.Label20.Text = "Dia:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 16)
        Me.Label21.TabIndex = 287
        Me.Label21.Text = "Horario:"
        '
        'txt_dias
        '
        Me.txt_dias.Location = New System.Drawing.Point(65, 56)
        Me.txt_dias.Name = "txt_dias"
        Me.txt_dias.ReadOnly = True
        Me.txt_dias.Size = New System.Drawing.Size(235, 22)
        Me.txt_dias.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tipopaciente_cronico)
        Me.GroupBox3.Controls.Add(Me.tipopaciente_agudo)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 77)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de paciente"
        '
        'tipopaciente_cronico
        '
        Me.tipopaciente_cronico.AutoSize = True
        Me.tipopaciente_cronico.Location = New System.Drawing.Point(42, 47)
        Me.tipopaciente_cronico.Name = "tipopaciente_cronico"
        Me.tipopaciente_cronico.Size = New System.Drawing.Size(72, 20)
        Me.tipopaciente_cronico.TabIndex = 1
        Me.tipopaciente_cronico.Text = "Crónico"
        Me.tipopaciente_cronico.UseVisualStyleBackColor = True
        '
        'tipopaciente_agudo
        '
        Me.tipopaciente_agudo.AutoSize = True
        Me.tipopaciente_agudo.Checked = True
        Me.tipopaciente_agudo.Location = New System.Drawing.Point(42, 21)
        Me.tipopaciente_agudo.Name = "tipopaciente_agudo"
        Me.tipopaciente_agudo.Size = New System.Drawing.Size(66, 20)
        Me.tipopaciente_agudo.TabIndex = 0
        Me.tipopaciente_agudo.TabStop = True
        Me.tipopaciente_agudo.Text = "Agudo"
        Me.tipopaciente_agudo.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(3, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(136, 20)
        Me.Label19.TabIndex = 260
        Me.Label19.Text = "Fecha de ingreso:"
        '
        'DateTimePicker_fechaingreso
        '
        Me.DateTimePicker_fechaingreso.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_fechaingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_fechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_fechaingreso.Location = New System.Drawing.Point(145, 9)
        Me.DateTimePicker_fechaingreso.Name = "DateTimePicker_fechaingreso"
        Me.DateTimePicker_fechaingreso.Size = New System.Drawing.Size(136, 26)
        Me.DateTimePicker_fechaingreso.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lb_mail)
        Me.Panel2.Controls.Add(Me.tx_tel)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.tx_mail)
        Me.Panel2.Controls.Add(Me.lb_tel)
        Me.Panel2.Controls.Add(Me.tx_dir)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tx_Cp)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.combo_Prov)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Combo_Loc)
        Me.Panel2.Location = New System.Drawing.Point(16, 237)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(556, 234)
        Me.Panel2.TabIndex = 286
        '
        'lb_mail
        '
        Me.lb_mail.AutoSize = True
        Me.lb_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mail.ForeColor = System.Drawing.Color.Black
        Me.lb_mail.Location = New System.Drawing.Point(3, 12)
        Me.lb_mail.Name = "lb_mail"
        Me.lb_mail.Size = New System.Drawing.Size(163, 20)
        Me.lb_mail.TabIndex = 239
        Me.lb_mail.Text = "Teléfono de contacto:"
        '
        'tx_tel
        '
        Me.tx_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_tel.Location = New System.Drawing.Point(180, 12)
        Me.tx_tel.Name = "tx_tel"
        Me.tx_tel.Size = New System.Drawing.Size(354, 26)
        Me.tx_tel.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 20)
        Me.Label6.TabIndex = 262
        Me.Label6.Text = "Mail / Correo eletrónico:"
        '
        'tx_mail
        '
        Me.tx_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_mail.Location = New System.Drawing.Point(180, 48)
        Me.tx_mail.Name = "tx_mail"
        Me.tx_mail.Size = New System.Drawing.Size(354, 26)
        Me.tx_mail.TabIndex = 1
        Me.tx_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_tel
        '
        Me.lb_tel.AutoSize = True
        Me.lb_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tel.ForeColor = System.Drawing.Color.Black
        Me.lb_tel.Location = New System.Drawing.Point(3, 90)
        Me.lb_tel.Name = "lb_tel"
        Me.lb_tel.Size = New System.Drawing.Size(154, 20)
        Me.lb_tel.TabIndex = 241
        Me.lb_tel.Text = "Dirección / Domicilio:"
        '
        'tx_dir
        '
        Me.tx_dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_dir.Location = New System.Drawing.Point(180, 87)
        Me.tx_dir.Name = "tx_dir"
        Me.tx_dir.Size = New System.Drawing.Size(354, 26)
        Me.tx_dir.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "Código Postal (CP):"
        '
        'tx_Cp
        '
        Me.tx_Cp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Cp.Location = New System.Drawing.Point(180, 118)
        Me.tx_Cp.Name = "tx_Cp"
        Me.tx_Cp.Size = New System.Drawing.Size(354, 26)
        Me.tx_Cp.TabIndex = 3
        Me.tx_Cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "Provincia:"
        '
        'combo_Prov
        '
        Me.combo_Prov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Prov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.combo_Prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_Prov.FormattingEnabled = True
        Me.combo_Prov.Location = New System.Drawing.Point(180, 151)
        Me.combo_Prov.Name = "combo_Prov"
        Me.combo_Prov.Size = New System.Drawing.Size(354, 28)
        Me.combo_Prov.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 259
        Me.Label5.Text = "Localidad:"
        '
        'Combo_Loc
        '
        Me.Combo_Loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Loc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_Loc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Loc.FormattingEnabled = True
        Me.Combo_Loc.Location = New System.Drawing.Point(180, 190)
        Me.Combo_Loc.Name = "Combo_Loc"
        Me.Combo_Loc.Size = New System.Drawing.Size(354, 28)
        Me.Combo_Loc.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.error_afiliado)
        Me.Panel1.Controls.Add(Me.ComboBox_obrasocial)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.tx_NumAfi)
        Me.Panel1.Location = New System.Drawing.Point(597, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 85)
        Me.Panel1.TabIndex = 287
        '
        'error_afiliado
        '
        Me.error_afiliado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.error_afiliado.AutoSize = True
        Me.error_afiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_afiliado.ForeColor = System.Drawing.Color.Red
        Me.error_afiliado.Location = New System.Drawing.Point(472, 44)
        Me.error_afiliado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_afiliado.Name = "error_afiliado"
        Me.error_afiliado.Size = New System.Drawing.Size(26, 31)
        Me.error_afiliado.TabIndex = 283
        Me.error_afiliado.Text = "*"
        Me.error_afiliado.Visible = False
        '
        'ComboBox_obrasocial
        '
        Me.ComboBox_obrasocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_obrasocial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_obrasocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_obrasocial.FormattingEnabled = True
        Me.ComboBox_obrasocial.Location = New System.Drawing.Point(111, 11)
        Me.ComboBox_obrasocial.Name = "ComboBox_obrasocial"
        Me.ComboBox_obrasocial.Size = New System.Drawing.Size(354, 28)
        Me.ComboBox_obrasocial.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(3, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 20)
        Me.Label16.TabIndex = 277
        Me.Label16.Text = "Obra Social"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(3, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 20)
        Me.Label17.TabIndex = 279
        Me.Label17.Text = "N° de Afiliado"
        '
        'tx_NumAfi
        '
        Me.tx_NumAfi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_NumAfi.Location = New System.Drawing.Point(111, 44)
        Me.tx_NumAfi.Name = "tx_NumAfi"
        Me.tx_NumAfi.Size = New System.Drawing.Size(354, 26)
        Me.tx_NumAfi.TabIndex = 1
        '
        'UpR
        '
        Me.UpR.BackColor = System.Drawing.Color.Black
        Me.UpR.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.UpR.Location = New System.Drawing.Point(0, -40)
        Me.UpR.Name = "UpR"
        Me.UpR.Size = New System.Drawing.Size(610, 2)
        Me.UpR.TabIndex = 8
        Me.UpR.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label_fechaalta)
        Me.GroupBox2.Controls.Add(Me.CheckBox_estado)
        Me.GroupBox2.Controls.Add(Me.txt_limitedeuda)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_ctacte)
        Me.GroupBox2.Controls.Add(Me.CheckBox_habilitar_ctacte)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 604)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 50)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opcional:"
        Me.GroupBox2.Visible = False
        '
        'Label_fechaalta
        '
        Me.Label_fechaalta.AutoSize = True
        Me.Label_fechaalta.Location = New System.Drawing.Point(356, 36)
        Me.Label_fechaalta.Name = "Label_fechaalta"
        Me.Label_fechaalta.Size = New System.Drawing.Size(93, 16)
        Me.Label_fechaalta.TabIndex = 268
        Me.Label_fechaalta.Text = "Fecha de alta:"
        Me.Label_fechaalta.Visible = False
        '
        'CheckBox_estado
        '
        Me.CheckBox_estado.AutoSize = True
        Me.CheckBox_estado.ForeColor = System.Drawing.Color.Green
        Me.CheckBox_estado.Location = New System.Drawing.Point(262, 35)
        Me.CheckBox_estado.Name = "CheckBox_estado"
        Me.CheckBox_estado.Size = New System.Drawing.Size(64, 20)
        Me.CheckBox_estado.TabIndex = 267
        Me.CheckBox_estado.Text = "Activo"
        Me.CheckBox_estado.UseVisualStyleBackColor = True
        Me.CheckBox_estado.Visible = False
        '
        'txt_limitedeuda
        '
        Me.txt_limitedeuda.Enabled = False
        Me.txt_limitedeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_limitedeuda.Location = New System.Drawing.Point(240, 67)
        Me.txt_limitedeuda.Name = "txt_limitedeuda"
        Me.txt_limitedeuda.Size = New System.Drawing.Size(207, 26)
        Me.txt_limitedeuda.TabIndex = 2
        Me.txt_limitedeuda.Text = "0"
        Me.txt_limitedeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 16)
        Me.Label8.TabIndex = 266
        Me.Label8.Text = "Limite deuda permitida:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nro. Cta.Cte:"
        Me.Label7.Visible = False
        '
        'txt_ctacte
        '
        Me.txt_ctacte.Enabled = False
        Me.txt_ctacte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_ctacte.Location = New System.Drawing.Point(133, 116)
        Me.txt_ctacte.Name = "txt_ctacte"
        Me.txt_ctacte.Size = New System.Drawing.Size(377, 22)
        Me.txt_ctacte.TabIndex = 1
        Me.txt_ctacte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_ctacte.Visible = False
        '
        'CheckBox_habilitar_ctacte
        '
        Me.CheckBox_habilitar_ctacte.AutoSize = True
        Me.CheckBox_habilitar_ctacte.Location = New System.Drawing.Point(26, 35)
        Me.CheckBox_habilitar_ctacte.Name = "CheckBox_habilitar_ctacte"
        Me.CheckBox_habilitar_ctacte.Size = New System.Drawing.Size(182, 20)
        Me.CheckBox_habilitar_ctacte.TabIndex = 0
        Me.CheckBox_habilitar_ctacte.Text = "Habilitar Cuenta Corriente."
        Me.CheckBox_habilitar_ctacte.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(189, 604)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 251
        Me.Label3.Text = "Tipo de IVA:"
        Me.Label3.Visible = False
        '
        'Combo_Iva
        '
        Me.Combo_Iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Iva.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_Iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Iva.FormattingEnabled = True
        Me.Combo_Iva.Location = New System.Drawing.Point(25, 560)
        Me.Combo_Iva.Name = "Combo_Iva"
        Me.Combo_Iva.Size = New System.Drawing.Size(337, 28)
        Me.Combo_Iva.TabIndex = 2
        Me.Combo_Iva.Visible = False
        '
        'Cliente_alta_New
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1244, 533)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Name = "Cliente_alta_New"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Paciente"
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UpR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tx_NumAfi As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_edad As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Tb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_fechaalta As System.Windows.Forms.Label
    Friend WithEvents CheckBox_estado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_limitedeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_ctacte As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox_habilitar_ctacte As System.Windows.Forms.CheckBox
    Friend WithEvents error_dni As System.Windows.Forms.Label
    Friend WithEvents error_razonsocial As System.Windows.Forms.Label
    Friend WithEvents tb_Dni_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents tx_mail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Combo_Loc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combo_Prov As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tx_Cp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tx_ape As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Combo_Iva As System.Windows.Forms.ComboBox
    Friend WithEvents tx_dir As System.Windows.Forms.TextBox
    Friend WithEvents tx_tel As System.Windows.Forms.TextBox
    Friend WithEvents lb_dni As System.Windows.Forms.Label
    Friend WithEvents lb_mail As System.Windows.Forms.Label
    Friend WithEvents lb_tel As System.Windows.Forms.Label
    Friend WithEvents UpR As System.Windows.Forms.PictureBox
    Friend WithEvents FechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox_obrasocial As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_estadocivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_HDF As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_EMODIALISIS As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_DPA As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_DPCA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tipopaciente_cronico As System.Windows.Forms.RadioButton
    Friend WithEvents tipopaciente_agudo As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_fechaingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_horario As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_dias As System.Windows.Forms.TextBox
    Friend WithEvents estado_inactivo As System.Windows.Forms.RadioButton
    Friend WithEvents estado_activo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_chofer As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox_turno As System.Windows.Forms.CheckBox
    Friend WithEvents cb_turnos As System.Windows.Forms.ComboBox
    Friend WithEvents error_afiliado As System.Windows.Forms.Label
End Class
