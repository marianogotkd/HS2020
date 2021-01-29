<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GM_Carga_Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GM_Carga_Producto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_codint = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_desc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_origen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_destino = New System.Windows.Forms.TextBox()
        Me.lbl_destino = New System.Windows.Forms.Label()
        Me.tb_cant_Or = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_cant_dest = New System.Windows.Forms.TextBox()
        Me.lbl_cant_dest = New System.Windows.Forms.Label()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.tb_Cant_Movi = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DateTimePicker_ffabricacion = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_fvencimiento = New System.Windows.Forms.DateTimePicker()
        Me.btn_agregarr = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nrolote = New System.Windows.Forms.TextBox()
        Me.Grupo_lote = New System.Windows.Forms.GroupBox()
        Me.CheckBox_vto = New System.Windows.Forms.CheckBox()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Grupo_lote.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Interno:"
        '
        'tb_codint
        '
        Me.tb_codint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codint.Location = New System.Drawing.Point(133, 25)
        Me.tb_codint.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_codint.Name = "tb_codint"
        Me.tb_codint.Size = New System.Drawing.Size(240, 19)
        Me.tb_codint.TabIndex = 0
        Me.tb_codint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tb_codint, "Ingrese codigo para buscar")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 392)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'tb_desc
        '
        Me.tb_desc.BackColor = System.Drawing.Color.White
        Me.tb_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_desc.Location = New System.Drawing.Point(133, 54)
        Me.tb_desc.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.ReadOnly = True
        Me.tb_desc.Size = New System.Drawing.Size(240, 19)
        Me.tb_desc.TabIndex = 1
        Me.tb_desc.TabStop = False
        Me.tb_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción:"
        '
        'tb_origen
        '
        Me.tb_origen.BackColor = System.Drawing.Color.White
        Me.tb_origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_origen.Location = New System.Drawing.Point(123, 23)
        Me.tb_origen.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_origen.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_origen.MinimumSize = New System.Drawing.Size(250, 22)
        Me.tb_origen.Name = "tb_origen"
        Me.tb_origen.ReadOnly = True
        Me.tb_origen.Size = New System.Drawing.Size(250, 22)
        Me.tb_origen.TabIndex = 0
        Me.tb_origen.TabStop = False
        Me.tb_origen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre:"
        '
        'tb_destino
        '
        Me.tb_destino.BackColor = System.Drawing.Color.White
        Me.tb_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_destino.Location = New System.Drawing.Point(119, 25)
        Me.tb_destino.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_destino.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_destino.MinimumSize = New System.Drawing.Size(250, 22)
        Me.tb_destino.Name = "tb_destino"
        Me.tb_destino.ReadOnly = True
        Me.tb_destino.Size = New System.Drawing.Size(250, 22)
        Me.tb_destino.TabIndex = 0
        Me.tb_destino.TabStop = False
        Me.tb_destino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_destino
        '
        Me.lbl_destino.AutoSize = True
        Me.lbl_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_destino.Location = New System.Drawing.Point(11, 28)
        Me.lbl_destino.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_destino.Name = "lbl_destino"
        Me.lbl_destino.Size = New System.Drawing.Size(47, 13)
        Me.lbl_destino.TabIndex = 7
        Me.lbl_destino.Text = "Nombre:"
        '
        'tb_cant_Or
        '
        Me.tb_cant_Or.BackColor = System.Drawing.Color.White
        Me.tb_cant_Or.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cant_Or.Location = New System.Drawing.Point(144, 54)
        Me.tb_cant_Or.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_cant_Or.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_cant_Or.Name = "tb_cant_Or"
        Me.tb_cant_Or.ReadOnly = True
        Me.tb_cant_Or.Size = New System.Drawing.Size(229, 19)
        Me.tb_cant_Or.TabIndex = 1
        Me.tb_cant_Or.TabStop = False
        Me.tb_cant_Or.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 57)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cantidad existente:"
        '
        'tb_cant_dest
        '
        Me.tb_cant_dest.BackColor = System.Drawing.Color.White
        Me.tb_cant_dest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cant_dest.Location = New System.Drawing.Point(140, 54)
        Me.tb_cant_dest.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_cant_dest.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_cant_dest.Name = "tb_cant_dest"
        Me.tb_cant_dest.ReadOnly = True
        Me.tb_cant_dest.Size = New System.Drawing.Size(229, 19)
        Me.tb_cant_dest.TabIndex = 1
        Me.tb_cant_dest.TabStop = False
        Me.tb_cant_dest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_cant_dest
        '
        Me.lbl_cant_dest.AutoSize = True
        Me.lbl_cant_dest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant_dest.Location = New System.Drawing.Point(11, 57)
        Me.lbl_cant_dest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cant_dest.Name = "lbl_cant_dest"
        Me.lbl_cant_dest.Size = New System.Drawing.Size(97, 13)
        Me.lbl_cant_dest.TabIndex = 11
        Me.lbl_cant_dest.Text = "Cantidad existente:"
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant.Location = New System.Drawing.Point(17, 28)
        Me.lbl_cant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(142, 15)
        Me.lbl_cant.TabIndex = 13
        Me.lbl_cant.Text = "Cantidad a Transferir"
        '
        'tb_Cant_Movi
        '
        Me.tb_Cant_Movi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Cant_Movi.Location = New System.Drawing.Point(225, 25)
        Me.tb_Cant_Movi.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Cant_Movi.Name = "tb_Cant_Movi"
        Me.tb_Cant_Movi.Size = New System.Drawing.Size(131, 21)
        Me.tb_Cant_Movi.TabIndex = 0
        Me.tb_Cant_Movi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button_buscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tb_codint)
        Me.GroupBox1.Controls.Add(Me.tb_desc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(764, 98)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(764, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 98)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese codigo interno para buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tb_origen)
        Me.GroupBox2.Controls.Add(Me.tb_cant_Or)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox2.MaximumSize = New System.Drawing.Size(380, 98)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(380, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 98)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sucursal de origen"
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lbl_destino)
        Me.GroupBox3.Controls.Add(Me.tb_cant_dest)
        Me.GroupBox3.Controls.Add(Me.tb_destino)
        Me.GroupBox3.Controls.Add(Me.lbl_cant_dest)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(400, 115)
        Me.GroupBox3.MaximumSize = New System.Drawing.Size(376, 98)
        Me.GroupBox3.MinimumSize = New System.Drawing.Size(376, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(376, 98)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sucursal de destino"
        '
        'DateTimePicker_ffabricacion
        '
        Me.DateTimePicker_ffabricacion.Enabled = False
        Me.DateTimePicker_ffabricacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_ffabricacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_ffabricacion.Location = New System.Drawing.Point(229, 82)
        Me.DateTimePicker_ffabricacion.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_ffabricacion.Name = "DateTimePicker_ffabricacion"
        Me.DateTimePicker_ffabricacion.Size = New System.Drawing.Size(107, 22)
        Me.DateTimePicker_ffabricacion.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.DateTimePicker_ffabricacion, "Seleccione fecha de pedido")
        '
        'DateTimePicker_fvencimiento
        '
        Me.DateTimePicker_fvencimiento.Enabled = False
        Me.DateTimePicker_fvencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_fvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_fvencimiento.Location = New System.Drawing.Point(228, 111)
        Me.DateTimePicker_fvencimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_fvencimiento.Name = "DateTimePicker_fvencimiento"
        Me.DateTimePicker_fvencimiento.Size = New System.Drawing.Size(107, 22)
        Me.DateTimePicker_fvencimiento.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DateTimePicker_fvencimiento, "Seleccione fecha de pedido")
        '
        'btn_agregarr
        '
        Me.btn_agregarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarr.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.btn_agregarr.Location = New System.Drawing.Point(232, 78)
        Me.btn_agregarr.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregarr.Name = "btn_agregarr"
        Me.btn_agregarr.Size = New System.Drawing.Size(124, 43)
        Me.btn_agregarr.TabIndex = 249
        Me.btn_agregarr.Text = "Agregar"
        Me.btn_agregarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_agregarr, "Agregar a la lista")
        Me.btn_agregarr.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "F. Fabricación:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.btn_agregarr)
        Me.GroupBox4.Controls.Add(Me.tb_Cant_Movi)
        Me.GroupBox4.Controls.Add(Me.lbl_cant)
        Me.GroupBox4.Location = New System.Drawing.Point(400, 219)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(376, 146)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(100, 119)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "F. Vencimiento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 23)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Lote Nº:"
        '
        'txt_nrolote
        '
        Me.txt_nrolote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nrolote.Location = New System.Drawing.Point(113, 15)
        Me.txt_nrolote.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nrolote.MinimumSize = New System.Drawing.Size(90, 30)
        Me.txt_nrolote.Name = "txt_nrolote"
        Me.txt_nrolote.Size = New System.Drawing.Size(112, 30)
        Me.txt_nrolote.TabIndex = 0
        Me.txt_nrolote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Grupo_lote
        '
        Me.Grupo_lote.BackColor = System.Drawing.Color.Transparent
        Me.Grupo_lote.Controls.Add(Me.CheckBox_vto)
        Me.Grupo_lote.Controls.Add(Me.DateTimePicker_fvencimiento)
        Me.Grupo_lote.Controls.Add(Me.Label5)
        Me.Grupo_lote.Controls.Add(Me.DateTimePicker_ffabricacion)
        Me.Grupo_lote.Controls.Add(Me.txt_nrolote)
        Me.Grupo_lote.Controls.Add(Me.Label8)
        Me.Grupo_lote.Controls.Add(Me.Label7)
        Me.Grupo_lote.Enabled = False
        Me.Grupo_lote.Location = New System.Drawing.Point(12, 220)
        Me.Grupo_lote.Name = "Grupo_lote"
        Me.Grupo_lote.Size = New System.Drawing.Size(380, 148)
        Me.Grupo_lote.TabIndex = 19
        Me.Grupo_lote.TabStop = False
        '
        'CheckBox_vto
        '
        Me.CheckBox_vto.AutoSize = True
        Me.CheckBox_vto.Location = New System.Drawing.Point(12, 62)
        Me.CheckBox_vto.Name = "CheckBox_vto"
        Me.CheckBox_vto.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox_vto.TabIndex = 240
        Me.CheckBox_vto.Text = "Habilitar Vencimiento"
        Me.CheckBox_vto.UseVisualStyleBackColor = True
        '
        'Button_buscar
        '
        Me.Button_buscar.Image = CType(resources.GetObject("Button_buscar.Image"), System.Drawing.Image)
        Me.Button_buscar.Location = New System.Drawing.Point(379, 22)
        Me.Button_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(43, 25)
        Me.Button_buscar.TabIndex = 258
        Me.Button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_buscar, "Busqueda avanzada")
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'GM_Carga_Producto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(794, 370)
        Me.Controls.Add(Me.Grupo_lote)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 300)
        Me.Name = "GM_Carga_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Productos . Gestión de Mercaderia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Grupo_lote.ResumeLayout(False)
        Me.Grupo_lote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_codint As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_desc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_origen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_destino As System.Windows.Forms.TextBox
    Friend WithEvents lbl_destino As System.Windows.Forms.Label
    Friend WithEvents tb_cant_Or As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_cant_dest As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cant_dest As System.Windows.Forms.Label
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents tb_Cant_Movi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nrolote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_fvencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_ffabricacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Grupo_lote As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_vto As System.Windows.Forms.CheckBox
    Friend WithEvents btn_agregarr As System.Windows.Forms.Button
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
End Class
