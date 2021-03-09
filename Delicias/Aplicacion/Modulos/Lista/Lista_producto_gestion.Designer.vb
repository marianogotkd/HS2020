<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_producto_gestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_producto_gestion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RB_codigo = New System.Windows.Forms.RadioButton()
        Me.RB_nomb = New System.Windows.Forms.RadioButton()
        Me.BO_empleado_modificar = New System.Windows.Forms.Button()
        Me.BO_Buscar_promociones = New System.Windows.Forms.Button()
        Me.tx_busc_promociones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGrid_busqueda = New System.Windows.Forms.DataGridView()
        Me.CodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusquedaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_ds2 = New Aplicacion.Lista_ds()
        Me.BO_Buscar_regulares = New System.Windows.Forms.Button()
        Me.tx_busc_regulares = New System.Windows.Forms.TextBox()
        Me.lb_ape = New System.Windows.Forms.Label()
        Me.BO_Buscar_combos = New System.Windows.Forms.Button()
        Me.tx_busc_combos = New System.Windows.Forms.TextBox()
        Me.lb_dni_emp = New System.Windows.Forms.Label()
        Me.TabPage0 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Labe_genero_cod = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PicBox_error_nomlista = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RB_combo_prod = New System.Windows.Forms.RadioButton()
        Me.RB_list_prom = New System.Windows.Forms.RadioButton()
        Me.RB_list_regular = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GP_dias = New System.Windows.Forms.GroupBox()
        Me.CK_domingo = New System.Windows.Forms.CheckBox()
        Me.CK_sabado = New System.Windows.Forms.CheckBox()
        Me.CK_viernes = New System.Windows.Forms.CheckBox()
        Me.CK_jueves = New System.Windows.Forms.CheckBox()
        Me.CK_miecoles = New System.Windows.Forms.CheckBox()
        Me.CK_martes = New System.Windows.Forms.CheckBox()
        Me.CK_lunes = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RB_LISTA_DIA_no = New System.Windows.Forms.RadioButton()
        Me.RB_LISTA_DIA_si = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GP_Fecha = New System.Windows.Forms.GroupBox()
        Me.DT_LISTA_fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DT_LISTA_fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.RB_LISTA_VIG_no = New System.Windows.Forms.RadioButton()
        Me.RB_LISTA_VIG_si = New System.Windows.Forms.RadioButton()
        Me.TX_LISTA_nom = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.CBox_tipocalculo_2 = New System.Windows.Forms.ComboBox()
        Me.CBox_aplicar_2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_result2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RB_pesos_2 = New System.Windows.Forms.RadioButton()
        Me.RB_porcent_2 = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TX_LISTA_PROD_calculo2 = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Label_codinterno2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label_preciolista2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TX_LISTA_PROD_total2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TX_LISTA_PROD_cant2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TX_LISTA_PROD_precio2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DataG_listaTotal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataG_lista = New System.Windows.Forms.DataGridView()
        Me.PRODidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProddescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaProdcantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaProdprecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaProdsubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListProdModifBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Lista_ds = New Aplicacion.Lista_ds()
        Me.Lista_ds1 = New Aplicacion.Lista_ds()
        Me.Tab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGrid_busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusquedaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_ds2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage0.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PicBox_error_nomlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GP_dias.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GP_Fecha.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.DataG_listaTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataG_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListProdModifBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.TabPage1)
        Me.Tab1.Controls.Add(Me.TabPage0)
        Me.Tab1.Controls.Add(Me.TabPage2)
        Me.Tab1.Location = New System.Drawing.Point(4, 5)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(874, 536)
        Me.Tab1.TabIndex = 238
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(866, 510)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "Lista Actualizar: busqueda"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Panel4)
        Me.GroupBox5.Controls.Add(Me.BO_empleado_modificar)
        Me.GroupBox5.Controls.Add(Me.BO_Buscar_promociones)
        Me.GroupBox5.Controls.Add(Me.tx_busc_promociones)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.DataGrid_busqueda)
        Me.GroupBox5.Controls.Add(Me.BO_Buscar_regulares)
        Me.GroupBox5.Controls.Add(Me.tx_busc_regulares)
        Me.GroupBox5.Controls.Add(Me.lb_ape)
        Me.GroupBox5.Controls.Add(Me.BO_Buscar_combos)
        Me.GroupBox5.Controls.Add(Me.tx_busc_combos)
        Me.GroupBox5.Controls.Add(Me.lb_dni_emp)
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox5.Location = New System.Drawing.Point(38, 33)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(764, 413)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Busqueda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 236
        Me.Label3.Text = "Tipo de búsqueda:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RB_codigo)
        Me.Panel4.Controls.Add(Me.RB_nomb)
        Me.Panel4.Location = New System.Drawing.Point(117, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(192, 27)
        Me.Panel4.TabIndex = 235
        '
        'RB_codigo
        '
        Me.RB_codigo.AutoSize = True
        Me.RB_codigo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_codigo.Location = New System.Drawing.Point(90, 3)
        Me.RB_codigo.Name = "RB_codigo"
        Me.RB_codigo.Size = New System.Drawing.Size(93, 17)
        Me.RB_codigo.TabIndex = 223
        Me.RB_codigo.Text = "Código interno"
        Me.RB_codigo.UseVisualStyleBackColor = True
        '
        'RB_nomb
        '
        Me.RB_nomb.AutoSize = True
        Me.RB_nomb.Checked = True
        Me.RB_nomb.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_nomb.Location = New System.Drawing.Point(3, 3)
        Me.RB_nomb.Name = "RB_nomb"
        Me.RB_nomb.Size = New System.Drawing.Size(81, 17)
        Me.RB_nomb.TabIndex = 222
        Me.RB_nomb.TabStop = True
        Me.RB_nomb.Text = "Descripción"
        Me.RB_nomb.UseVisualStyleBackColor = True
        '
        'BO_empleado_modificar
        '
        Me.BO_empleado_modificar.Image = CType(resources.GetObject("BO_empleado_modificar.Image"), System.Drawing.Image)
        Me.BO_empleado_modificar.Location = New System.Drawing.Point(695, 350)
        Me.BO_empleado_modificar.Name = "BO_empleado_modificar"
        Me.BO_empleado_modificar.Size = New System.Drawing.Size(40, 40)
        Me.BO_empleado_modificar.TabIndex = 3
        Me.BO_empleado_modificar.UseVisualStyleBackColor = True
        '
        'BO_Buscar_promociones
        '
        Me.BO_Buscar_promociones.Image = CType(resources.GetObject("BO_Buscar_promociones.Image"), System.Drawing.Image)
        Me.BO_Buscar_promociones.Location = New System.Drawing.Point(719, 56)
        Me.BO_Buscar_promociones.Name = "BO_Buscar_promociones"
        Me.BO_Buscar_promociones.Size = New System.Drawing.Size(30, 30)
        Me.BO_Buscar_promociones.TabIndex = 10
        Me.BO_Buscar_promociones.UseVisualStyleBackColor = True
        '
        'tx_busc_promociones
        '
        Me.tx_busc_promociones.Location = New System.Drawing.Point(589, 62)
        Me.tx_busc_promociones.Name = "tx_busc_promociones"
        Me.tx_busc_promociones.Size = New System.Drawing.Size(124, 20)
        Me.tx_busc_promociones.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(482, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Listas promocionales"
        '
        'DataGrid_busqueda
        '
        Me.DataGrid_busqueda.AllowUserToAddRows = False
        Me.DataGrid_busqueda.AllowUserToDeleteRows = False
        Me.DataGrid_busqueda.AutoGenerateColumns = False
        Me.DataGrid_busqueda.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGrid_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_busqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodinternoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn})
        Me.DataGrid_busqueda.DataSource = Me.BusquedaBindingSource1
        Me.DataGrid_busqueda.Location = New System.Drawing.Point(41, 105)
        Me.DataGrid_busqueda.Name = "DataGrid_busqueda"
        Me.DataGrid_busqueda.ReadOnly = True
        Me.DataGrid_busqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_busqueda.Size = New System.Drawing.Size(648, 285)
        Me.DataGrid_busqueda.TabIndex = 7
        '
        'CodinternoDataGridViewTextBoxColumn
        '
        Me.CodinternoDataGridViewTextBoxColumn.DataPropertyName = "cod_interno"
        Me.CodinternoDataGridViewTextBoxColumn.HeaderText = "Cod. Interno"
        Me.CodinternoDataGridViewTextBoxColumn.Name = "CodinternoDataGridViewTextBoxColumn"
        Me.CodinternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "fecha alta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "Fecha de Alta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAltaDataGridViewTextBoxColumn.Width = 150
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 150
        '
        'BusquedaBindingSource1
        '
        Me.BusquedaBindingSource1.DataMember = "Busqueda"
        Me.BusquedaBindingSource1.DataSource = Me.Lista_ds2
        '
        'Lista_ds2
        '
        Me.Lista_ds2.DataSetName = "Lista_ds"
        Me.Lista_ds2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_Buscar_regulares
        '
        Me.BO_Buscar_regulares.Image = CType(resources.GetObject("BO_Buscar_regulares.Image"), System.Drawing.Image)
        Me.BO_Buscar_regulares.Location = New System.Drawing.Point(446, 57)
        Me.BO_Buscar_regulares.Name = "BO_Buscar_regulares"
        Me.BO_Buscar_regulares.Size = New System.Drawing.Size(30, 30)
        Me.BO_Buscar_regulares.TabIndex = 6
        Me.BO_Buscar_regulares.UseVisualStyleBackColor = True
        '
        'tx_busc_regulares
        '
        Me.tx_busc_regulares.Location = New System.Drawing.Point(316, 63)
        Me.tx_busc_regulares.Name = "tx_busc_regulares"
        Me.tx_busc_regulares.Size = New System.Drawing.Size(124, 20)
        Me.tx_busc_regulares.TabIndex = 5
        '
        'lb_ape
        '
        Me.lb_ape.AutoSize = True
        Me.lb_ape.Location = New System.Drawing.Point(237, 66)
        Me.lb_ape.Name = "lb_ape"
        Me.lb_ape.Size = New System.Drawing.Size(80, 13)
        Me.lb_ape.TabIndex = 4
        Me.lb_ape.Text = "Listas regulares"
        '
        'BO_Buscar_combos
        '
        Me.BO_Buscar_combos.Image = CType(resources.GetObject("BO_Buscar_combos.Image"), System.Drawing.Image)
        Me.BO_Buscar_combos.Location = New System.Drawing.Point(200, 57)
        Me.BO_Buscar_combos.Name = "BO_Buscar_combos"
        Me.BO_Buscar_combos.Size = New System.Drawing.Size(30, 30)
        Me.BO_Buscar_combos.TabIndex = 3
        Me.BO_Buscar_combos.UseVisualStyleBackColor = True
        '
        'tx_busc_combos
        '
        Me.tx_busc_combos.Location = New System.Drawing.Point(70, 63)
        Me.tx_busc_combos.Name = "tx_busc_combos"
        Me.tx_busc_combos.Size = New System.Drawing.Size(124, 20)
        Me.tx_busc_combos.TabIndex = 1
        '
        'lb_dni_emp
        '
        Me.lb_dni_emp.AutoSize = True
        Me.lb_dni_emp.Location = New System.Drawing.Point(22, 66)
        Me.lb_dni_emp.Name = "lb_dni_emp"
        Me.lb_dni_emp.Size = New System.Drawing.Size(45, 13)
        Me.lb_dni_emp.TabIndex = 0
        Me.lb_dni_emp.Text = "Combos"
        '
        'TabPage0
        '
        Me.TabPage0.Controls.Add(Me.DataGridView1)
        Me.TabPage0.Controls.Add(Me.GroupBox4)
        Me.TabPage0.Location = New System.Drawing.Point(4, 22)
        Me.TabPage0.Name = "TabPage0"
        Me.TabPage0.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage0.Size = New System.Drawing.Size(866, 510)
        Me.TabPage0.TabIndex = 4
        Me.TabPage0.Text = "Lista Actualizar: Datos"
        Me.TabPage0.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(63, 397)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(138, 112)
        Me.DataGridView1.TabIndex = 231
        Me.DataGridView1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Labe_genero_cod)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.PicBox_error_nomlista)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.TX_LISTA_nom)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(28, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(802, 349)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de la Lista"
        '
        'Labe_genero_cod
        '
        Me.Labe_genero_cod.AutoSize = True
        Me.Labe_genero_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labe_genero_cod.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Labe_genero_cod.Location = New System.Drawing.Point(106, 76)
        Me.Labe_genero_cod.Name = "Labe_genero_cod"
        Me.Labe_genero_cod.Size = New System.Drawing.Size(37, 15)
        Me.Labe_genero_cod.TabIndex = 238
        Me.Labe_genero_cod.Text = ".........."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(32, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 237
        Me.Label7.Text = "Cód. Interno:"
        '
        'PicBox_error_nomlista
        '
        Me.PicBox_error_nomlista.Image = CType(resources.GetObject("PicBox_error_nomlista.Image"), System.Drawing.Image)
        Me.PicBox_error_nomlista.Location = New System.Drawing.Point(429, 42)
        Me.PicBox_error_nomlista.Name = "PicBox_error_nomlista"
        Me.PicBox_error_nomlista.Size = New System.Drawing.Size(20, 20)
        Me.PicBox_error_nomlista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicBox_error_nomlista.TabIndex = 236
        Me.PicBox_error_nomlista.TabStop = False
        Me.PicBox_error_nomlista.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(600, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 102)
        Me.GroupBox3.TabIndex = 235
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de lista"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RB_combo_prod)
        Me.Panel2.Controls.Add(Me.RB_list_prom)
        Me.Panel2.Controls.Add(Me.RB_list_regular)
        Me.Panel2.Location = New System.Drawing.Point(6, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(138, 74)
        Me.Panel2.TabIndex = 234
        '
        'RB_combo_prod
        '
        Me.RB_combo_prod.AutoSize = True
        Me.RB_combo_prod.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_combo_prod.Location = New System.Drawing.Point(3, 49)
        Me.RB_combo_prod.Name = "RB_combo_prod"
        Me.RB_combo_prod.Size = New System.Drawing.Size(123, 17)
        Me.RB_combo_prod.TabIndex = 224
        Me.RB_combo_prod.Text = "Combo de productos"
        Me.RB_combo_prod.UseVisualStyleBackColor = True
        '
        'RB_list_prom
        '
        Me.RB_list_prom.AutoSize = True
        Me.RB_list_prom.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_list_prom.Location = New System.Drawing.Point(3, 26)
        Me.RB_list_prom.Name = "RB_list_prom"
        Me.RB_list_prom.Size = New System.Drawing.Size(99, 17)
        Me.RB_list_prom.TabIndex = 223
        Me.RB_list_prom.Text = "Lista promoción"
        Me.RB_list_prom.UseVisualStyleBackColor = True
        '
        'RB_list_regular
        '
        Me.RB_list_regular.AutoSize = True
        Me.RB_list_regular.Checked = True
        Me.RB_list_regular.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_list_regular.Location = New System.Drawing.Point(3, 3)
        Me.RB_list_regular.Name = "RB_list_regular"
        Me.RB_list_regular.Size = New System.Drawing.Size(82, 17)
        Me.RB_list_regular.TabIndex = 222
        Me.RB_list_regular.TabStop = True
        Me.RB_list_regular.Text = "Lista regular"
        Me.RB_list_regular.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GP_dias)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(35, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 88)
        Me.GroupBox2.TabIndex = 234
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dias Especiales"
        '
        'GP_dias
        '
        Me.GP_dias.Controls.Add(Me.CK_domingo)
        Me.GP_dias.Controls.Add(Me.CK_sabado)
        Me.GP_dias.Controls.Add(Me.CK_viernes)
        Me.GP_dias.Controls.Add(Me.CK_jueves)
        Me.GP_dias.Controls.Add(Me.CK_miecoles)
        Me.GP_dias.Controls.Add(Me.CK_martes)
        Me.GP_dias.Controls.Add(Me.CK_lunes)
        Me.GP_dias.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GP_dias.Location = New System.Drawing.Point(117, 19)
        Me.GP_dias.Name = "GP_dias"
        Me.GP_dias.Size = New System.Drawing.Size(602, 48)
        Me.GP_dias.TabIndex = 235
        Me.GP_dias.TabStop = False
        Me.GP_dias.Text = "Dias"
        '
        'CK_domingo
        '
        Me.CK_domingo.AutoSize = True
        Me.CK_domingo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CK_domingo.Location = New System.Drawing.Point(517, 19)
        Me.CK_domingo.Name = "CK_domingo"
        Me.CK_domingo.Size = New System.Drawing.Size(68, 17)
        Me.CK_domingo.TabIndex = 6
        Me.CK_domingo.Text = "Domingo"
        Me.CK_domingo.UseVisualStyleBackColor = True
        '
        'CK_sabado
        '
        Me.CK_sabado.AutoSize = True
        Me.CK_sabado.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CK_sabado.Location = New System.Drawing.Point(428, 20)
        Me.CK_sabado.Name = "CK_sabado"
        Me.CK_sabado.Size = New System.Drawing.Size(63, 17)
        Me.CK_sabado.TabIndex = 5
        Me.CK_sabado.Text = "Sabado"
        Me.CK_sabado.UseVisualStyleBackColor = True
        '
        'CK_viernes
        '
        Me.CK_viernes.AutoSize = True
        Me.CK_viernes.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CK_viernes.Location = New System.Drawing.Point(344, 20)
        Me.CK_viernes.Name = "CK_viernes"
        Me.CK_viernes.Size = New System.Drawing.Size(61, 17)
        Me.CK_viernes.TabIndex = 4
        Me.CK_viernes.Text = "Viernes"
        Me.CK_viernes.UseVisualStyleBackColor = True
        '
        'CK_jueves
        '
        Me.CK_jueves.AutoSize = True
        Me.CK_jueves.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CK_jueves.Location = New System.Drawing.Point(260, 20)
        Me.CK_jueves.Name = "CK_jueves"
        Me.CK_jueves.Size = New System.Drawing.Size(60, 17)
        Me.CK_jueves.TabIndex = 3
        Me.CK_jueves.Text = "Jueves"
        Me.CK_jueves.UseVisualStyleBackColor = True
        '
        'CK_miecoles
        '
        Me.CK_miecoles.AutoSize = True
        Me.CK_miecoles.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CK_miecoles.Location = New System.Drawing.Point(168, 20)
        Me.CK_miecoles.Name = "CK_miecoles"
        Me.CK_miecoles.Size = New System.Drawing.Size(71, 17)
        Me.CK_miecoles.TabIndex = 2
        Me.CK_miecoles.Text = "Miercoles"
        Me.CK_miecoles.UseVisualStyleBackColor = True
        '
        'CK_martes
        '
        Me.CK_martes.AutoSize = True
        Me.CK_martes.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CK_martes.Location = New System.Drawing.Point(92, 20)
        Me.CK_martes.Name = "CK_martes"
        Me.CK_martes.Size = New System.Drawing.Size(58, 17)
        Me.CK_martes.TabIndex = 1
        Me.CK_martes.Text = "Martes"
        Me.CK_martes.UseVisualStyleBackColor = True
        '
        'CK_lunes
        '
        Me.CK_lunes.AutoSize = True
        Me.CK_lunes.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CK_lunes.Location = New System.Drawing.Point(20, 19)
        Me.CK_lunes.Name = "CK_lunes"
        Me.CK_lunes.Size = New System.Drawing.Size(55, 17)
        Me.CK_lunes.TabIndex = 0
        Me.CK_lunes.Text = "Lunes"
        Me.CK_lunes.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RB_LISTA_DIA_no)
        Me.Panel1.Controls.Add(Me.RB_LISTA_DIA_si)
        Me.Panel1.Location = New System.Drawing.Point(15, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(93, 21)
        Me.Panel1.TabIndex = 234
        '
        'RB_LISTA_DIA_no
        '
        Me.RB_LISTA_DIA_no.AutoSize = True
        Me.RB_LISTA_DIA_no.Checked = True
        Me.RB_LISTA_DIA_no.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_LISTA_DIA_no.Location = New System.Drawing.Point(49, 3)
        Me.RB_LISTA_DIA_no.Name = "RB_LISTA_DIA_no"
        Me.RB_LISTA_DIA_no.Size = New System.Drawing.Size(39, 17)
        Me.RB_LISTA_DIA_no.TabIndex = 223
        Me.RB_LISTA_DIA_no.TabStop = True
        Me.RB_LISTA_DIA_no.Text = "No"
        Me.RB_LISTA_DIA_no.UseVisualStyleBackColor = True
        '
        'RB_LISTA_DIA_si
        '
        Me.RB_LISTA_DIA_si.AutoSize = True
        Me.RB_LISTA_DIA_si.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_LISTA_DIA_si.Location = New System.Drawing.Point(0, 3)
        Me.RB_LISTA_DIA_si.Name = "RB_LISTA_DIA_si"
        Me.RB_LISTA_DIA_si.Size = New System.Drawing.Size(34, 17)
        Me.RB_LISTA_DIA_si.TabIndex = 222
        Me.RB_LISTA_DIA_si.Text = "Si"
        Me.RB_LISTA_DIA_si.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GP_Fecha)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(35, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 90)
        Me.GroupBox1.TabIndex = 233
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha de Vigencia"
        '
        'GP_Fecha
        '
        Me.GP_Fecha.Controls.Add(Me.DT_LISTA_fecha_hasta)
        Me.GP_Fecha.Controls.Add(Me.Label1)
        Me.GP_Fecha.Controls.Add(Me.Label5)
        Me.GP_Fecha.Controls.Add(Me.DT_LISTA_fecha_desde)
        Me.GP_Fecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GP_Fecha.Location = New System.Drawing.Point(117, 19)
        Me.GP_Fecha.Name = "GP_Fecha"
        Me.GP_Fecha.Size = New System.Drawing.Size(602, 56)
        Me.GP_Fecha.TabIndex = 236
        Me.GP_Fecha.TabStop = False
        Me.GP_Fecha.Text = "Fecha"
        '
        'DT_LISTA_fecha_hasta
        '
        Me.DT_LISTA_fecha_hasta.Location = New System.Drawing.Point(365, 23)
        Me.DT_LISTA_fecha_hasta.Name = "DT_LISTA_fecha_hasta"
        Me.DT_LISTA_fecha_hasta.Size = New System.Drawing.Size(220, 20)
        Me.DT_LISTA_fecha_hasta.TabIndex = 241
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(315, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "Hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(17, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 239
        Me.Label5.Text = "Desde"
        '
        'DT_LISTA_fecha_desde
        '
        Me.DT_LISTA_fecha_desde.Location = New System.Drawing.Point(72, 23)
        Me.DT_LISTA_fecha_desde.Name = "DT_LISTA_fecha_desde"
        Me.DT_LISTA_fecha_desde.Size = New System.Drawing.Size(220, 20)
        Me.DT_LISTA_fecha_desde.TabIndex = 238
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.RB_LISTA_VIG_no)
        Me.Panel7.Controls.Add(Me.RB_LISTA_VIG_si)
        Me.Panel7.Location = New System.Drawing.Point(15, 39)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(93, 21)
        Me.Panel7.TabIndex = 234
        '
        'RB_LISTA_VIG_no
        '
        Me.RB_LISTA_VIG_no.AutoSize = True
        Me.RB_LISTA_VIG_no.Checked = True
        Me.RB_LISTA_VIG_no.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_LISTA_VIG_no.Location = New System.Drawing.Point(49, 3)
        Me.RB_LISTA_VIG_no.Name = "RB_LISTA_VIG_no"
        Me.RB_LISTA_VIG_no.Size = New System.Drawing.Size(39, 17)
        Me.RB_LISTA_VIG_no.TabIndex = 223
        Me.RB_LISTA_VIG_no.TabStop = True
        Me.RB_LISTA_VIG_no.Text = "No"
        Me.RB_LISTA_VIG_no.UseVisualStyleBackColor = True
        '
        'RB_LISTA_VIG_si
        '
        Me.RB_LISTA_VIG_si.AutoSize = True
        Me.RB_LISTA_VIG_si.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_LISTA_VIG_si.Location = New System.Drawing.Point(0, 3)
        Me.RB_LISTA_VIG_si.Name = "RB_LISTA_VIG_si"
        Me.RB_LISTA_VIG_si.Size = New System.Drawing.Size(34, 17)
        Me.RB_LISTA_VIG_si.TabIndex = 222
        Me.RB_LISTA_VIG_si.Text = "Si"
        Me.RB_LISTA_VIG_si.UseVisualStyleBackColor = True
        '
        'TX_LISTA_nom
        '
        Me.TX_LISTA_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_LISTA_nom.Location = New System.Drawing.Point(142, 42)
        Me.TX_LISTA_nom.Name = "TX_LISTA_nom"
        Me.TX_LISTA_nom.Size = New System.Drawing.Size(281, 20)
        Me.TX_LISTA_nom.TabIndex = 231
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(32, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 232
        Me.Label11.Text = "Nombre de Lista"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(866, 510)
        Me.TabPage2.TabIndex = 6
        Me.TabPage2.Text = "Lista Actualizar: Productos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Button5)
        Me.GroupBox12.Controls.Add(Me.Button1)
        Me.GroupBox12.Controls.Add(Me.Button4)
        Me.GroupBox12.Controls.Add(Me.GroupBox11)
        Me.GroupBox12.Controls.Add(Me.GroupBox13)
        Me.GroupBox12.Controls.Add(Me.DataG_listaTotal)
        Me.GroupBox12.Controls.Add(Me.DataG_lista)
        Me.GroupBox12.Enabled = False
        Me.GroupBox12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox12.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(853, 500)
        Me.GroupBox12.TabIndex = 236
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Productos agregados"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(695, 34)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 40)
        Me.Button5.TabIndex = 241
        Me.ToolTip1.SetToolTip(Me.Button5, "Agregar producto")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(649, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 239
        Me.ToolTip1.SetToolTip(Me.Button1, "Eliminar selección")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(792, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 30)
        Me.Button4.TabIndex = 232
        Me.ToolTip1.SetToolTip(Me.Button4, "Aplicar cambios")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.CBox_tipocalculo_2)
        Me.GroupBox11.Controls.Add(Me.CBox_aplicar_2)
        Me.GroupBox11.Controls.Add(Me.Label6)
        Me.GroupBox11.Controls.Add(Me.Label_result2)
        Me.GroupBox11.Controls.Add(Me.Label8)
        Me.GroupBox11.Controls.Add(Me.Label10)
        Me.GroupBox11.Controls.Add(Me.Panel3)
        Me.GroupBox11.Controls.Add(Me.Label18)
        Me.GroupBox11.Controls.Add(Me.TX_LISTA_PROD_calculo2)
        Me.GroupBox11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox11.Location = New System.Drawing.Point(649, 284)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(198, 195)
        Me.GroupBox11.TabIndex = 240
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Calculo auxiliar para Precio"
        '
        'CBox_tipocalculo_2
        '
        Me.CBox_tipocalculo_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBox_tipocalculo_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBox_tipocalculo_2.FormattingEnabled = True
        Me.CBox_tipocalculo_2.Items.AddRange(New Object() {"Aumento", "Descuento"})
        Me.CBox_tipocalculo_2.Location = New System.Drawing.Point(62, 63)
        Me.CBox_tipocalculo_2.Name = "CBox_tipocalculo_2"
        Me.CBox_tipocalculo_2.Size = New System.Drawing.Size(130, 23)
        Me.CBox_tipocalculo_2.TabIndex = 242
        '
        'CBox_aplicar_2
        '
        Me.CBox_aplicar_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBox_aplicar_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBox_aplicar_2.FormattingEnabled = True
        Me.CBox_aplicar_2.Items.AddRange(New Object() {"Prod. seleccionado", "Total lista"})
        Me.CBox_aplicar_2.Location = New System.Drawing.Point(63, 32)
        Me.CBox_aplicar_2.Name = "CBox_aplicar_2"
        Me.CBox_aplicar_2.Size = New System.Drawing.Size(129, 23)
        Me.CBox_aplicar_2.TabIndex = 243
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(8, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "Calcular:"
        '
        'Label_result2
        '
        Me.Label_result2.AutoSize = True
        Me.Label_result2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_result2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_result2.Location = New System.Drawing.Point(87, 166)
        Me.Label_result2.Name = "Label_result2"
        Me.Label_result2.Size = New System.Drawing.Size(38, 15)
        Me.Label_result2.TabIndex = 239
        Me.Label_result2.Text = "00,00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(6, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Aplicar a:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(8, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 238
        Me.Label10.Text = "Resultado : "
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RB_pesos_2)
        Me.Panel3.Controls.Add(Me.RB_porcent_2)
        Me.Panel3.Location = New System.Drawing.Point(63, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 46)
        Me.Panel3.TabIndex = 235
        '
        'RB_pesos_2
        '
        Me.RB_pesos_2.AutoSize = True
        Me.RB_pesos_2.Checked = True
        Me.RB_pesos_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pesos_2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_pesos_2.Location = New System.Drawing.Point(3, 26)
        Me.RB_pesos_2.Name = "RB_pesos_2"
        Me.RB_pesos_2.Size = New System.Drawing.Size(118, 17)
        Me.RB_pesos_2.TabIndex = 223
        Me.RB_pesos_2.TabStop = True
        Me.RB_pesos_2.Text = "$ sobre % asignado"
        Me.RB_pesos_2.UseVisualStyleBackColor = True
        '
        'RB_porcent_2
        '
        Me.RB_porcent_2.AutoSize = True
        Me.RB_porcent_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_porcent_2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_porcent_2.Location = New System.Drawing.Point(3, 3)
        Me.RB_porcent_2.Name = "RB_porcent_2"
        Me.RB_porcent_2.Size = New System.Drawing.Size(118, 17)
        Me.RB_porcent_2.TabIndex = 222
        Me.RB_porcent_2.Text = "% sobre $ asignado"
        Me.RB_porcent_2.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label18.Location = New System.Drawing.Point(8, 143)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 15)
        Me.Label18.TabIndex = 237
        Me.Label18.Text = "Calculo :"
        '
        'TX_LISTA_PROD_calculo2
        '
        Me.TX_LISTA_PROD_calculo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_LISTA_PROD_calculo2.ForeColor = System.Drawing.Color.DarkGreen
        Me.TX_LISTA_PROD_calculo2.Location = New System.Drawing.Point(87, 142)
        Me.TX_LISTA_PROD_calculo2.Name = "TX_LISTA_PROD_calculo2"
        Me.TX_LISTA_PROD_calculo2.Size = New System.Drawing.Size(88, 20)
        Me.TX_LISTA_PROD_calculo2.TabIndex = 236
        Me.TX_LISTA_PROD_calculo2.Text = "00,00"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Label_codinterno2)
        Me.GroupBox13.Controls.Add(Me.Label20)
        Me.GroupBox13.Controls.Add(Me.Label_preciolista2)
        Me.GroupBox13.Controls.Add(Me.Label22)
        Me.GroupBox13.Controls.Add(Me.TX_LISTA_PROD_total2)
        Me.GroupBox13.Controls.Add(Me.Label23)
        Me.GroupBox13.Controls.Add(Me.TX_LISTA_PROD_cant2)
        Me.GroupBox13.Controls.Add(Me.Label24)
        Me.GroupBox13.Controls.Add(Me.TX_LISTA_PROD_precio2)
        Me.GroupBox13.Controls.Add(Me.Label25)
        Me.GroupBox13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox13.Location = New System.Drawing.Point(649, 80)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(198, 162)
        Me.GroupBox13.TabIndex = 239
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Producto seleccionado"
        '
        'Label_codinterno2
        '
        Me.Label_codinterno2.AutoSize = True
        Me.Label_codinterno2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_codinterno2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_codinterno2.Location = New System.Drawing.Point(83, 24)
        Me.Label_codinterno2.Name = "Label_codinterno2"
        Me.Label_codinterno2.Size = New System.Drawing.Size(21, 15)
        Me.Label_codinterno2.TabIndex = 234
        Me.Label_codinterno2.Text = """  """
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label20.Location = New System.Drawing.Point(7, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 15)
        Me.Label20.TabIndex = 233
        Me.Label20.Text = "Cód. Interno:"
        '
        'Label_preciolista2
        '
        Me.Label_preciolista2.AutoSize = True
        Me.Label_preciolista2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_preciolista2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_preciolista2.Location = New System.Drawing.Point(82, 48)
        Me.Label_preciolista2.Name = "Label_preciolista2"
        Me.Label_preciolista2.Size = New System.Drawing.Size(38, 15)
        Me.Label_preciolista2.TabIndex = 103
        Me.Label_preciolista2.Text = "00,00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label22.Location = New System.Drawing.Point(6, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 15)
        Me.Label22.TabIndex = 102
        Me.Label22.Text = "Precio :       $"
        '
        'TX_LISTA_PROD_total2
        '
        Me.TX_LISTA_PROD_total2.Enabled = False
        Me.TX_LISTA_PROD_total2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_LISTA_PROD_total2.ForeColor = System.Drawing.Color.DarkGreen
        Me.TX_LISTA_PROD_total2.Location = New System.Drawing.Point(85, 125)
        Me.TX_LISTA_PROD_total2.Name = "TX_LISTA_PROD_total2"
        Me.TX_LISTA_PROD_total2.Size = New System.Drawing.Size(88, 20)
        Me.TX_LISTA_PROD_total2.TabIndex = 100
        Me.TX_LISTA_PROD_total2.Text = "00,00"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label23.Location = New System.Drawing.Point(6, 126)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 15)
        Me.Label23.TabIndex = 101
        Me.Label23.Text = "Precio T. :   $"
        '
        'TX_LISTA_PROD_cant2
        '
        Me.TX_LISTA_PROD_cant2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_LISTA_PROD_cant2.ForeColor = System.Drawing.Color.DarkGreen
        Me.TX_LISTA_PROD_cant2.Location = New System.Drawing.Point(85, 99)
        Me.TX_LISTA_PROD_cant2.Name = "TX_LISTA_PROD_cant2"
        Me.TX_LISTA_PROD_cant2.Size = New System.Drawing.Size(88, 20)
        Me.TX_LISTA_PROD_cant2.TabIndex = 98
        Me.TX_LISTA_PROD_cant2.Text = "1"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label24.Location = New System.Drawing.Point(6, 100)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 15)
        Me.Label24.TabIndex = 99
        Me.Label24.Text = "Cantidad :"
        '
        'TX_LISTA_PROD_precio2
        '
        Me.TX_LISTA_PROD_precio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_LISTA_PROD_precio2.ForeColor = System.Drawing.Color.DarkGreen
        Me.TX_LISTA_PROD_precio2.Location = New System.Drawing.Point(85, 74)
        Me.TX_LISTA_PROD_precio2.Name = "TX_LISTA_PROD_precio2"
        Me.TX_LISTA_PROD_precio2.Size = New System.Drawing.Size(88, 20)
        Me.TX_LISTA_PROD_precio2.TabIndex = 96
        Me.TX_LISTA_PROD_precio2.Text = "00,00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label25.Location = New System.Drawing.Point(6, 74)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 15)
        Me.Label25.TabIndex = 97
        Me.Label25.Text = "Precio U. :  $"
        '
        'DataG_listaTotal
        '
        Me.DataG_listaTotal.AllowUserToAddRows = False
        Me.DataG_listaTotal.AllowUserToDeleteRows = False
        Me.DataG_listaTotal.BackgroundColor = System.Drawing.Color.White
        Me.DataG_listaTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataG_listaTotal.ColumnHeadersVisible = False
        Me.DataG_listaTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataG_listaTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataG_listaTotal.Location = New System.Drawing.Point(3, 467)
        Me.DataG_listaTotal.Name = "DataG_listaTotal"
        Me.DataG_listaTotal.ReadOnly = True
        Me.DataG_listaTotal.RowHeadersVisible = False
        Me.DataG_listaTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataG_listaTotal.Size = New System.Drawing.Size(640, 25)
        Me.DataG_listaTotal.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROD_descripcion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 500
        '
        'DataG_lista
        '
        Me.DataG_lista.AllowUserToAddRows = False
        Me.DataG_lista.AllowUserToDeleteRows = False
        Me.DataG_lista.AllowUserToResizeRows = False
        Me.DataG_lista.AutoGenerateColumns = False
        Me.DataG_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataG_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataG_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODidDataGridViewTextBoxColumn, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.ProddescripcionDataGridViewTextBoxColumn, Me.ListaProdcantidadDataGridViewTextBoxColumn, Me.ListaProdprecioDataGridViewTextBoxColumn, Me.ListaProdsubtotalDataGridViewTextBoxColumn, Me.TipoproductoDataGridViewTextBoxColumn})
        Me.DataG_lista.DataSource = Me.ListProdModifBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataG_lista.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataG_lista.Location = New System.Drawing.Point(3, 16)
        Me.DataG_lista.Name = "DataG_lista"
        Me.DataG_lista.ReadOnly = True
        Me.DataG_lista.RowHeadersVisible = False
        Me.DataG_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataG_lista.Size = New System.Drawing.Size(640, 450)
        Me.DataG_lista.TabIndex = 0
        '
        'PRODidDataGridViewTextBoxColumn
        '
        Me.PRODidDataGridViewTextBoxColumn.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.Name = "PRODidDataGridViewTextBoxColumn"
        Me.PRODidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn.Visible = False
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Cód. Interno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProddescripcionDataGridViewTextBoxColumn
        '
        Me.ProddescripcionDataGridViewTextBoxColumn.DataPropertyName = "prod_descripcion"
        Me.ProddescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.ProddescripcionDataGridViewTextBoxColumn.Name = "ProddescripcionDataGridViewTextBoxColumn"
        Me.ProddescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListaProdcantidadDataGridViewTextBoxColumn
        '
        Me.ListaProdcantidadDataGridViewTextBoxColumn.DataPropertyName = "Lista_Prod_cantidad"
        Me.ListaProdcantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.ListaProdcantidadDataGridViewTextBoxColumn.Name = "ListaProdcantidadDataGridViewTextBoxColumn"
        Me.ListaProdcantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListaProdprecioDataGridViewTextBoxColumn
        '
        Me.ListaProdprecioDataGridViewTextBoxColumn.DataPropertyName = "Lista_Prod_precio"
        Me.ListaProdprecioDataGridViewTextBoxColumn.HeaderText = "Precio U."
        Me.ListaProdprecioDataGridViewTextBoxColumn.Name = "ListaProdprecioDataGridViewTextBoxColumn"
        Me.ListaProdprecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListaProdsubtotalDataGridViewTextBoxColumn
        '
        Me.ListaProdsubtotalDataGridViewTextBoxColumn.DataPropertyName = "Lista_Prod_subtotal"
        Me.ListaProdsubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.ListaProdsubtotalDataGridViewTextBoxColumn.Name = "ListaProdsubtotalDataGridViewTextBoxColumn"
        Me.ListaProdsubtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoproductoDataGridViewTextBoxColumn
        '
        Me.TipoproductoDataGridViewTextBoxColumn.DataPropertyName = "tipo_producto"
        Me.TipoproductoDataGridViewTextBoxColumn.HeaderText = "tipo_producto"
        Me.TipoproductoDataGridViewTextBoxColumn.Name = "TipoproductoDataGridViewTextBoxColumn"
        Me.TipoproductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListProdModifBindingSource
        '
        Me.ListProdModifBindingSource.DataMember = "ListProdModif"
        Me.ListProdModifBindingSource.DataSource = Me.Lista_ds2
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(792, 547)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 40)
        Me.Button3.TabIndex = 240
        Me.ToolTip1.SetToolTip(Me.Button3, "Cancelar")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(838, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 239
        Me.ToolTip1.SetToolTip(Me.Button2, "Guardar")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lista_ds
        '
        Me.Lista_ds.DataSetName = "Lista_ds"
        Me.Lista_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lista_ds1
        '
        Me.Lista_ds1.DataSetName = "Lista_ds"
        Me.Lista_ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lista_producto_gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(882, 603)
        Me.Controls.Add(Me.Tab1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Lista_producto_gestion"
        Me.Text = "Lista_producto_gestion"
        Me.Tab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGrid_busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusquedaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_ds2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage0.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PicBox_error_nomlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GP_dias.ResumeLayout(False)
        Me.GP_dias.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GP_Fecha.ResumeLayout(False)
        Me.GP_Fecha.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.DataG_listaTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataG_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListProdModifBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_ds1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage0 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Labe_genero_cod As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PicBox_error_nomlista As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RB_combo_prod As System.Windows.Forms.RadioButton
    Friend WithEvents RB_list_prom As System.Windows.Forms.RadioButton
    Friend WithEvents RB_list_regular As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_dias As System.Windows.Forms.GroupBox
    Friend WithEvents CK_domingo As System.Windows.Forms.CheckBox
    Friend WithEvents CK_sabado As System.Windows.Forms.CheckBox
    Friend WithEvents CK_viernes As System.Windows.Forms.CheckBox
    Friend WithEvents CK_jueves As System.Windows.Forms.CheckBox
    Friend WithEvents CK_miecoles As System.Windows.Forms.CheckBox
    Friend WithEvents CK_martes As System.Windows.Forms.CheckBox
    Friend WithEvents CK_lunes As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RB_LISTA_DIA_no As System.Windows.Forms.RadioButton
    Friend WithEvents RB_LISTA_DIA_si As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GP_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents DT_LISTA_fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DT_LISTA_fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents RB_LISTA_VIG_no As System.Windows.Forms.RadioButton
    Friend WithEvents RB_LISTA_VIG_si As System.Windows.Forms.RadioButton
    Friend WithEvents TX_LISTA_nom As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents CBox_tipocalculo_2 As System.Windows.Forms.ComboBox
    Friend WithEvents CBox_aplicar_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_result2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RB_pesos_2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_porcent_2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TX_LISTA_PROD_calculo2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_codinterno2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label_preciolista2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TX_LISTA_PROD_total2 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TX_LISTA_PROD_cant2 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TX_LISTA_PROD_precio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DataG_listaTotal As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataG_lista As System.Windows.Forms.DataGridView
    Friend WithEvents Lista_ds2 As Aplicacion.Lista_ds
    Friend WithEvents Lista_ds As Aplicacion.Lista_ds
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Lista_ds1 As Aplicacion.Lista_ds
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid_busqueda As System.Windows.Forms.DataGridView
    Friend WithEvents BO_Buscar_regulares As System.Windows.Forms.Button
    Friend WithEvents tx_busc_regulares As System.Windows.Forms.TextBox
    Friend WithEvents lb_ape As System.Windows.Forms.Label
    Friend WithEvents BO_Buscar_combos As System.Windows.Forms.Button
    Friend WithEvents tx_busc_combos As System.Windows.Forms.TextBox
    Friend WithEvents lb_dni_emp As System.Windows.Forms.Label
    Friend WithEvents BO_Buscar_promociones As System.Windows.Forms.Button
    Friend WithEvents tx_busc_promociones As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BO_empleado_modificar As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RB_codigo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_nomb As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BusquedaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ListProdModifBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProddescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListaProdcantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListaProdprecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListaProdsubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoproductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
