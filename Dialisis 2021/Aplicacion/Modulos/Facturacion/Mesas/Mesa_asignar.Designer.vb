<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mesa_asignar
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RB_Si = New System.Windows.Forms.RadioButton()
        Me.RB_No = New System.Windows.Forms.RadioButton()
        Me.CB_lista = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RB_Cliente = New System.Windows.Forms.RadioButton()
        Me.RB_Consumidor = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_buscar_clie = New System.Windows.Forms.TextBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_Caja_ds = New Aplicacion.Venta_Caja_ds()
        Me.BO_Modificar = New System.Windows.Forms.Button()
        Me.BO_Nuevo = New System.Windows.Forms.Button()
        Me.BO_cancelar = New System.Windows.Forms.Button()
        Me.BO_Aceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_sector = New System.Windows.Forms.Label()
        Me.Label_mesa = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.CLI_id_columna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLI_Fan_columna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIobservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfnacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RB_Si)
        Me.GroupBox3.Controls.Add(Me.RB_No)
        Me.GroupBox3.Controls.Add(Me.CB_lista)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(434, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(314, 115)
        Me.GroupBox3.TabIndex = 254
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Configurar Lista"
        Me.GroupBox3.Visible = False
        '
        'RB_Si
        '
        Me.RB_Si.AutoSize = True
        Me.RB_Si.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_Si.Location = New System.Drawing.Point(51, 19)
        Me.RB_Si.Name = "RB_Si"
        Me.RB_Si.Size = New System.Drawing.Size(41, 24)
        Me.RB_Si.TabIndex = 224
        Me.RB_Si.Text = "Si"
        Me.RB_Si.UseVisualStyleBackColor = True
        '
        'RB_No
        '
        Me.RB_No.AutoSize = True
        Me.RB_No.Checked = True
        Me.RB_No.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_No.Location = New System.Drawing.Point(6, 19)
        Me.RB_No.Name = "RB_No"
        Me.RB_No.Size = New System.Drawing.Size(47, 24)
        Me.RB_No.TabIndex = 223
        Me.RB_No.TabStop = True
        Me.RB_No.Text = "No"
        Me.RB_No.UseVisualStyleBackColor = True
        '
        'CB_lista
        '
        Me.CB_lista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_lista.FormattingEnabled = True
        Me.CB_lista.Location = New System.Drawing.Point(6, 54)
        Me.CB_lista.Name = "CB_lista"
        Me.CB_lista.Size = New System.Drawing.Size(296, 28)
        Me.CB_lista.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox5.Location = New System.Drawing.Point(9, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(297, 115)
        Me.GroupBox5.TabIndex = 253
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de Venta :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RB_Cliente)
        Me.Panel2.Controls.Add(Me.RB_Consumidor)
        Me.Panel2.Location = New System.Drawing.Point(9, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(268, 73)
        Me.Panel2.TabIndex = 234
        '
        'RB_Cliente
        '
        Me.RB_Cliente.AutoSize = True
        Me.RB_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Cliente.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_Cliente.Location = New System.Drawing.Point(3, 29)
        Me.RB_Cliente.Name = "RB_Cliente"
        Me.RB_Cliente.Size = New System.Drawing.Size(86, 28)
        Me.RB_Cliente.TabIndex = 223
        Me.RB_Cliente.Text = "Cliente"
        Me.RB_Cliente.UseVisualStyleBackColor = True
        '
        'RB_Consumidor
        '
        Me.RB_Consumidor.AutoSize = True
        Me.RB_Consumidor.Checked = True
        Me.RB_Consumidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Consumidor.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RB_Consumidor.Location = New System.Drawing.Point(3, 3)
        Me.RB_Consumidor.Name = "RB_Consumidor"
        Me.RB_Consumidor.Size = New System.Drawing.Size(177, 28)
        Me.RB_Consumidor.TabIndex = 222
        Me.RB_Consumidor.TabStop = True
        Me.RB_Consumidor.Text = "Consumidor Final"
        Me.RB_Consumidor.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.Txt_buscar_clie)
        Me.GroupBox4.Controls.Add(Me.DG_clientes)
        Me.GroupBox4.Controls.Add(Me.BO_Modificar)
        Me.GroupBox4.Controls.Add(Me.BO_Nuevo)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox4.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(862, 346)
        Me.GroupBox4.TabIndex = 255
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar cliente : "
        '
        'Txt_buscar_clie
        '
        Me.Txt_buscar_clie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_buscar_clie.Location = New System.Drawing.Point(6, 19)
        Me.Txt_buscar_clie.Name = "Txt_buscar_clie"
        Me.Txt_buscar_clie.Size = New System.Drawing.Size(832, 26)
        Me.Txt_buscar_clie.TabIndex = 238
        '
        'DG_clientes
        '
        Me.DG_clientes.AllowUserToAddRows = False
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.AutoGenerateColumns = False
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DG_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLI_id_columna, Me.CLI_Fan_columna, Me.CLIapeDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn, Me.CLIobservacionesDataGridViewTextBoxColumn, Me.CLIfnacDataGridViewTextBoxColumn})
        Me.DG_clientes.DataSource = Me.ClienteBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(6, 53)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(832, 245)
        Me.DG_clientes.TabIndex = 237
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.Venta_Caja_ds
        '
        'Venta_Caja_ds
        '
        Me.Venta_Caja_ds.DataSetName = "Venta_Caja_ds"
        Me.Venta_Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_Modificar
        '
        Me.BO_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Modificar.Location = New System.Drawing.Point(120, 304)
        Me.BO_Modificar.Name = "BO_Modificar"
        Me.BO_Modificar.Size = New System.Drawing.Size(133, 30)
        Me.BO_Modificar.TabIndex = 259
        Me.BO_Modificar.Text = "Modificar Datos"
        Me.BO_Modificar.UseVisualStyleBackColor = True
        Me.BO_Modificar.Visible = False
        '
        'BO_Nuevo
        '
        Me.BO_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Nuevo.Location = New System.Drawing.Point(9, 304)
        Me.BO_Nuevo.Name = "BO_Nuevo"
        Me.BO_Nuevo.Size = New System.Drawing.Size(105, 30)
        Me.BO_Nuevo.TabIndex = 258
        Me.BO_Nuevo.Text = "Nuevo Cliente"
        Me.ToolTip1.SetToolTip(Me.BO_Nuevo, "Nuevo cliente")
        Me.BO_Nuevo.UseVisualStyleBackColor = True
        '
        'BO_cancelar
        '
        Me.BO_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cancelar.Location = New System.Drawing.Point(102, 539)
        Me.BO_cancelar.Name = "BO_cancelar"
        Me.BO_cancelar.Size = New System.Drawing.Size(82, 35)
        Me.BO_cancelar.TabIndex = 260
        Me.BO_cancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.BO_cancelar, "Cancelar")
        Me.BO_cancelar.UseVisualStyleBackColor = True
        '
        'BO_Aceptar
        '
        Me.BO_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_Aceptar.Location = New System.Drawing.Point(14, 539)
        Me.BO_Aceptar.Name = "BO_Aceptar"
        Me.BO_Aceptar.Size = New System.Drawing.Size(82, 35)
        Me.BO_Aceptar.TabIndex = 257
        Me.BO_Aceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.BO_Aceptar, "Aceptar asignación")
        Me.BO_Aceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 29)
        Me.Label2.TabIndex = 262
        Me.Label2.Text = "Nro. Mesa :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 29)
        Me.Label1.TabIndex = 261
        Me.Label1.Text = "Sector :"
        '
        'Label_sector
        '
        Me.Label_sector.AutoSize = True
        Me.Label_sector.BackColor = System.Drawing.Color.Transparent
        Me.Label_sector.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_sector.Location = New System.Drawing.Point(123, 9)
        Me.Label_sector.Name = "Label_sector"
        Me.Label_sector.Size = New System.Drawing.Size(181, 29)
        Me.Label_sector.TabIndex = 263
        Me.Label_sector.Text = "nombre sector"
        '
        'Label_mesa
        '
        Me.Label_mesa.AutoSize = True
        Me.Label_mesa.BackColor = System.Drawing.Color.Transparent
        Me.Label_mesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_mesa.Location = New System.Drawing.Point(556, 9)
        Me.Label_mesa.Name = "Label_mesa"
        Me.Label_mesa.Size = New System.Drawing.Size(171, 29)
        Me.Label_mesa.TabIndex = 264
        Me.Label_mesa.Text = "numero mesa"
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLI_id_columna
        '
        Me.CLI_id_columna.DataPropertyName = "CLI_id"
        Me.CLI_id_columna.HeaderText = "CLI_id"
        Me.CLI_id_columna.Name = "CLI_id_columna"
        Me.CLI_id_columna.ReadOnly = True
        Me.CLI_id_columna.Visible = False
        '
        'CLI_Fan_columna
        '
        Me.CLI_Fan_columna.DataPropertyName = "CLI_Fan"
        Me.CLI_Fan_columna.HeaderText = "Fantasia / Razón Social"
        Me.CLI_Fan_columna.Name = "CLI_Fan_columna"
        Me.CLI_Fan_columna.ReadOnly = True
        Me.CLI_Fan_columna.Width = 200
        '
        'CLIapeDataGridViewTextBoxColumn
        '
        Me.CLIapeDataGridViewTextBoxColumn.DataPropertyName = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.HeaderText = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.Name = "CLIapeDataGridViewTextBoxColumn"
        Me.CLIapeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIapeDataGridViewTextBoxColumn.Visible = False
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Visible = False
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "DNI/CUIT"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIdniDataGridViewTextBoxColumn.Width = 150
        '
        'CLItelDataGridViewTextBoxColumn
        '
        Me.CLItelDataGridViewTextBoxColumn.DataPropertyName = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.CLItelDataGridViewTextBoxColumn.Name = "CLItelDataGridViewTextBoxColumn"
        Me.CLItelDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLItelDataGridViewTextBoxColumn.Width = 150
        '
        'CLImailDataGridViewTextBoxColumn
        '
        Me.CLImailDataGridViewTextBoxColumn.DataPropertyName = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.CLImailDataGridViewTextBoxColumn.Name = "CLImailDataGridViewTextBoxColumn"
        Me.CLImailDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLImailDataGridViewTextBoxColumn.Width = 150
        '
        'CLIobservacionesDataGridViewTextBoxColumn
        '
        Me.CLIobservacionesDataGridViewTextBoxColumn.DataPropertyName = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.HeaderText = "observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.Name = "CLIobservacionesDataGridViewTextBoxColumn"
        Me.CLIobservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIobservacionesDataGridViewTextBoxColumn.Width = 130
        '
        'CLIfnacDataGridViewTextBoxColumn
        '
        Me.CLIfnacDataGridViewTextBoxColumn.DataPropertyName = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.HeaderText = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.Name = "CLIfnacDataGridViewTextBoxColumn"
        Me.CLIfnacDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIfnacDataGridViewTextBoxColumn.Visible = False
        '
        'Mesa_asignar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(916, 607)
        Me.Controls.Add(Me.Label_mesa)
        Me.Controls.Add(Me.Label_sector)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BO_cancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BO_Aceptar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.KeyPreview = True
        Me.Name = "Mesa_asignar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de mesas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Si As System.Windows.Forms.RadioButton
    Friend WithEvents RB_No As System.Windows.Forms.RadioButton
    Friend WithEvents CB_lista As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RB_Cliente As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Consumidor As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_buscar_clie As System.Windows.Forms.TextBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Venta_Caja_ds As Aplicacion.Venta_Caja_ds
    Friend WithEvents BO_cancelar As System.Windows.Forms.Button
    Friend WithEvents BO_Nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_sector As System.Windows.Forms.Label
    Friend WithEvents Label_mesa As System.Windows.Forms.Label
    Friend WithEvents BO_Modificar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents CLIFanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLI_id_columna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLI_Fan_columna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIobservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfnacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
