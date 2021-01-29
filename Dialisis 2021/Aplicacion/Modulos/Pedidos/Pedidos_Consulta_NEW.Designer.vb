<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos_Consulta_NEW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos_Consulta_NEW))
        Me.ComboBox_prove = New System.Windows.Forms.ComboBox()
        Me.DG_Pedido = New System.Windows.Forms.DataGridView()
        Me.PedidosIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosCodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosCodProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosEstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEDIDOESTnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPedidos = New Aplicacion.dsPedidos()
        Me.Button_editar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Todos_prov = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Prov = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_ver = New System.Windows.Forms.Button()
        Me.Bo_busqueda = New System.Windows.Forms.Button()
        Me.Button_recepcion = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DT_FECHA_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DT_FECHA_desde = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_busqueda = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_finalizados = New System.Windows.Forms.RadioButton()
        Me.RadioButton_pendientes = New System.Windows.Forms.RadioButton()
        Me.RadioButton_todos = New System.Windows.Forms.RadioButton()
        CType(Me.DG_Pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox_prove
        '
        Me.ComboBox_prove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_prove.Enabled = False
        Me.ComboBox_prove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_prove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_prove.FormattingEnabled = True
        Me.ComboBox_prove.Location = New System.Drawing.Point(93, 19)
        Me.ComboBox_prove.Name = "ComboBox_prove"
        Me.ComboBox_prove.Size = New System.Drawing.Size(253, 24)
        Me.ComboBox_prove.TabIndex = 5
        '
        'DG_Pedido
        '
        Me.DG_Pedido.AllowUserToAddRows = False
        Me.DG_Pedido.AllowUserToDeleteRows = False
        Me.DG_Pedido.AllowUserToResizeColumns = False
        Me.DG_Pedido.AllowUserToResizeRows = False
        Me.DG_Pedido.AutoGenerateColumns = False
        Me.DG_Pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Pedido.BackgroundColor = System.Drawing.Color.White
        Me.DG_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PedidosIDDataGridViewTextBoxColumn, Me.PedidosCodDataGridViewTextBoxColumn, Me.PedidosFechaDataGridViewTextBoxColumn, Me.PedidosCodProvDataGridViewTextBoxColumn, Me.PedidosTotalDataGridViewTextBoxColumn, Me.PedidosEstadoDataGridViewTextBoxColumn, Me.PEDIDOESTnomDataGridViewTextBoxColumn})
        Me.DG_Pedido.DataSource = Me.PedidosConsultaBindingSource
        Me.DG_Pedido.Location = New System.Drawing.Point(12, 168)
        Me.DG_Pedido.MaximumSize = New System.Drawing.Size(382, 266)
        Me.DG_Pedido.MultiSelect = False
        Me.DG_Pedido.Name = "DG_Pedido"
        Me.DG_Pedido.ReadOnly = True
        Me.DG_Pedido.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Pedido.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Pedido.Size = New System.Drawing.Size(382, 242)
        Me.DG_Pedido.TabIndex = 4
        '
        'PedidosIDDataGridViewTextBoxColumn
        '
        Me.PedidosIDDataGridViewTextBoxColumn.DataPropertyName = "Pedidos_ID"
        Me.PedidosIDDataGridViewTextBoxColumn.HeaderText = "Pedidos_ID"
        Me.PedidosIDDataGridViewTextBoxColumn.Name = "PedidosIDDataGridViewTextBoxColumn"
        Me.PedidosIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PedidosIDDataGridViewTextBoxColumn.Visible = False
        '
        'PedidosCodDataGridViewTextBoxColumn
        '
        Me.PedidosCodDataGridViewTextBoxColumn.DataPropertyName = "Pedidos_Cod"
        Me.PedidosCodDataGridViewTextBoxColumn.HeaderText = "N° de Pedido"
        Me.PedidosCodDataGridViewTextBoxColumn.Name = "PedidosCodDataGridViewTextBoxColumn"
        Me.PedidosCodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PedidosFechaDataGridViewTextBoxColumn
        '
        Me.PedidosFechaDataGridViewTextBoxColumn.DataPropertyName = "Pedidos_Fecha"
        Me.PedidosFechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.PedidosFechaDataGridViewTextBoxColumn.Name = "PedidosFechaDataGridViewTextBoxColumn"
        Me.PedidosFechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PedidosCodProvDataGridViewTextBoxColumn
        '
        Me.PedidosCodProvDataGridViewTextBoxColumn.DataPropertyName = "Pedidos_Cod_Prov"
        Me.PedidosCodProvDataGridViewTextBoxColumn.HeaderText = "Pedidos_Cod_Prov"
        Me.PedidosCodProvDataGridViewTextBoxColumn.Name = "PedidosCodProvDataGridViewTextBoxColumn"
        Me.PedidosCodProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.PedidosCodProvDataGridViewTextBoxColumn.Visible = False
        '
        'PedidosTotalDataGridViewTextBoxColumn
        '
        Me.PedidosTotalDataGridViewTextBoxColumn.DataPropertyName = "Pedidos_Total"
        Me.PedidosTotalDataGridViewTextBoxColumn.HeaderText = "Pedidos_Total"
        Me.PedidosTotalDataGridViewTextBoxColumn.Name = "PedidosTotalDataGridViewTextBoxColumn"
        Me.PedidosTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PedidosTotalDataGridViewTextBoxColumn.Visible = False
        '
        'PedidosEstadoDataGridViewTextBoxColumn
        '
        Me.PedidosEstadoDataGridViewTextBoxColumn.DataPropertyName = "Pedidos_Estado"
        Me.PedidosEstadoDataGridViewTextBoxColumn.HeaderText = "Pedidos_Estado"
        Me.PedidosEstadoDataGridViewTextBoxColumn.Name = "PedidosEstadoDataGridViewTextBoxColumn"
        Me.PedidosEstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PedidosEstadoDataGridViewTextBoxColumn.Visible = False
        '
        'PEDIDOESTnomDataGridViewTextBoxColumn
        '
        Me.PEDIDOESTnomDataGridViewTextBoxColumn.DataPropertyName = "PEDIDO_EST_nom"
        Me.PEDIDOESTnomDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.PEDIDOESTnomDataGridViewTextBoxColumn.Name = "PEDIDOESTnomDataGridViewTextBoxColumn"
        Me.PEDIDOESTnomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PedidosConsultaBindingSource
        '
        Me.PedidosConsultaBindingSource.DataMember = "PedidosConsulta"
        Me.PedidosConsultaBindingSource.DataSource = Me.DsPedidos
        '
        'DsPedidos
        '
        Me.DsPedidos.DataSetName = "dsPedidos"
        Me.DsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button_editar
        '
        Me.Button_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_editar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_editar.Location = New System.Drawing.Point(270, 466)
        Me.Button_editar.Name = "Button_editar"
        Me.Button_editar.Size = New System.Drawing.Size(118, 48)
        Me.Button_editar.TabIndex = 8
        Me.Button_editar.Text = "Editar"
        Me.Button_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_editar, "Editar pedido pendiente seleccionado")
        Me.Button_editar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_Todos_prov)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Prov)
        Me.GroupBox1.Controls.Add(Me.ComboBox_prove)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 95)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'RadioButton_Todos_prov
        '
        Me.RadioButton_Todos_prov.AutoSize = True
        Me.RadioButton_Todos_prov.Checked = True
        Me.RadioButton_Todos_prov.Location = New System.Drawing.Point(10, 64)
        Me.RadioButton_Todos_prov.Name = "RadioButton_Todos_prov"
        Me.RadioButton_Todos_prov.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton_Todos_prov.TabIndex = 6
        Me.RadioButton_Todos_prov.TabStop = True
        Me.RadioButton_Todos_prov.Text = "Todos"
        Me.RadioButton_Todos_prov.UseVisualStyleBackColor = True
        '
        'RadioButton_Prov
        '
        Me.RadioButton_Prov.AutoSize = True
        Me.RadioButton_Prov.Location = New System.Drawing.Point(10, 22)
        Me.RadioButton_Prov.Name = "RadioButton_Prov"
        Me.RadioButton_Prov.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton_Prov.TabIndex = 3
        Me.RadioButton_Prov.Text = "Proveedor"
        Me.RadioButton_Prov.UseVisualStyleBackColor = True
        '
        'Button_ver
        '
        Me.Button_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ver.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button_ver.Location = New System.Drawing.Point(172, 466)
        Me.Button_ver.Name = "Button_ver"
        Me.Button_ver.Size = New System.Drawing.Size(92, 48)
        Me.Button_ver.TabIndex = 10
        Me.Button_ver.Text = "Ver"
        Me.Button_ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_ver, "Ver detalle del pedido seleccionado")
        Me.Button_ver.UseVisualStyleBackColor = True
        '
        'Bo_busqueda
        '
        Me.Bo_busqueda.Image = CType(resources.GetObject("Bo_busqueda.Image"), System.Drawing.Image)
        Me.Bo_busqueda.Location = New System.Drawing.Point(152, 83)
        Me.Bo_busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Bo_busqueda.Name = "Bo_busqueda"
        Me.Bo_busqueda.Size = New System.Drawing.Size(40, 37)
        Me.Bo_busqueda.TabIndex = 206
        Me.ToolTip1.SetToolTip(Me.Bo_busqueda, "Buscar por rango de fechas")
        Me.Bo_busqueda.UseVisualStyleBackColor = True
        '
        'Button_recepcion
        '
        Me.Button_recepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_recepcion.Image = Global.Aplicacion.My.Resources.Resources.CargarDato
        Me.Button_recepcion.Location = New System.Drawing.Point(18, 466)
        Me.Button_recepcion.Name = "Button_recepcion"
        Me.Button_recepcion.Size = New System.Drawing.Size(148, 48)
        Me.Button_recepcion.TabIndex = 7
        Me.Button_recepcion.Text = "Recepción"
        Me.Button_recepcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_recepcion, "Registrar recepción de pedido")
        Me.Button_recepcion.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox8)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(407, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 395)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda avanzada"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Bo_busqueda)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.DT_FECHA_hasta)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.DT_FECHA_desde)
        Me.GroupBox8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox8.Location = New System.Drawing.Point(13, 107)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(206, 141)
        Me.GroupBox8.TabIndex = 204
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Por Fecha"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(20, 58)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "Hasta"
        '
        'DT_FECHA_hasta
        '
        Me.DT_FECHA_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA_hasta.Location = New System.Drawing.Point(80, 53)
        Me.DT_FECHA_hasta.Margin = New System.Windows.Forms.Padding(4)
        Me.DT_FECHA_hasta.Name = "DT_FECHA_hasta"
        Me.DT_FECHA_hasta.Size = New System.Drawing.Size(112, 20)
        Me.DT_FECHA_hasta.TabIndex = 182
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(20, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 181
        Me.Label9.Text = "Desde"
        '
        'DT_FECHA_desde
        '
        Me.DT_FECHA_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA_desde.Location = New System.Drawing.Point(80, 23)
        Me.DT_FECHA_desde.Margin = New System.Windows.Forms.Padding(4)
        Me.DT_FECHA_desde.Name = "DT_FECHA_desde"
        Me.DT_FECHA_desde.Size = New System.Drawing.Size(113, 20)
        Me.DT_FECHA_desde.TabIndex = 180
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_busqueda)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 57)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese Nº de Pedido:"
        '
        'Txt_busqueda
        '
        Me.Txt_busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_busqueda.Location = New System.Drawing.Point(23, 24)
        Me.Txt_busqueda.Name = "Txt_busqueda"
        Me.Txt_busqueda.Size = New System.Drawing.Size(169, 19)
        Me.Txt_busqueda.TabIndex = 0
        Me.Txt_busqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton_finalizados)
        Me.GroupBox4.Controls.Add(Me.RadioButton_pendientes)
        Me.GroupBox4.Controls.Add(Me.RadioButton_todos)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(389, 60)
        Me.GroupBox4.TabIndex = 205
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mostrar:"
        '
        'RadioButton_finalizados
        '
        Me.RadioButton_finalizados.AutoSize = True
        Me.RadioButton_finalizados.Location = New System.Drawing.Point(178, 19)
        Me.RadioButton_finalizados.Name = "RadioButton_finalizados"
        Me.RadioButton_finalizados.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton_finalizados.TabIndex = 2
        Me.RadioButton_finalizados.Text = "Finalizados"
        Me.RadioButton_finalizados.UseVisualStyleBackColor = True
        '
        'RadioButton_pendientes
        '
        Me.RadioButton_pendientes.AutoSize = True
        Me.RadioButton_pendientes.Location = New System.Drawing.Point(84, 19)
        Me.RadioButton_pendientes.Name = "RadioButton_pendientes"
        Me.RadioButton_pendientes.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton_pendientes.TabIndex = 1
        Me.RadioButton_pendientes.Text = "Pendientes"
        Me.RadioButton_pendientes.UseVisualStyleBackColor = True
        '
        'RadioButton_todos
        '
        Me.RadioButton_todos.AutoSize = True
        Me.RadioButton_todos.Checked = True
        Me.RadioButton_todos.Location = New System.Drawing.Point(14, 19)
        Me.RadioButton_todos.Name = "RadioButton_todos"
        Me.RadioButton_todos.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton_todos.TabIndex = 0
        Me.RadioButton_todos.TabStop = True
        Me.RadioButton_todos.Text = "Todos"
        Me.RadioButton_todos.UseVisualStyleBackColor = True
        '
        'Pedidos_Consulta_NEW
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(664, 526)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button_ver)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_editar)
        Me.Controls.Add(Me.Button_recepcion)
        Me.Controls.Add(Me.DG_Pedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pedidos_Consulta_NEW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de pedidos (F1 busqueda avanzada)"
        CType(Me.DG_Pedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox_prove As System.Windows.Forms.ComboBox
    Friend WithEvents DG_Pedido As System.Windows.Forms.DataGridView
    Friend WithEvents PedidosConsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPedidos As Aplicacion.dsPedidos
    Friend WithEvents Button_recepcion As System.Windows.Forms.Button
    Friend WithEvents Button_editar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PedidosIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PedidosCodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PedidosFechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PedidosCodProvDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PedidosTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PedidosEstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PEDIDOESTnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_finalizados As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_pendientes As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_todos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DT_FECHA_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DT_FECHA_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Bo_busqueda As System.Windows.Forms.Button
    Friend WithEvents Button_ver As System.Windows.Forms.Button
    Friend WithEvents RadioButton_Todos_prov As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Prov As System.Windows.Forms.RadioButton
End Class
