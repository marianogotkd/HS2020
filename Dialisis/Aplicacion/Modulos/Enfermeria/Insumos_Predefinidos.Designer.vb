<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insumos_Predefinidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Insumos_Predefinidos))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.lb_totalinscriptos = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_ausente = New System.Windows.Forms.Button()
        Me.datagridview_Predef = New System.Windows.Forms.DataGridView()
        Me.PredefinidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_enfermeria = New Aplicacion.Ds_enfermeria()
        Me.PredefIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PredefCantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod_unidadmedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datagridview_Predef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PredefinidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_cant)
        Me.GroupBox1.Controls.Add(Me.Button_buscar)
        Me.GroupBox1.Controls.Add(Me.lb_totalinscriptos)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btn_ausente)
        Me.GroupBox1.Controls.Add(Me.datagridview_Predef)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 377)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant.ForeColor = System.Drawing.Color.Blue
        Me.lbl_cant.Location = New System.Drawing.Point(641, 331)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(27, 20)
        Me.lbl_cant.TabIndex = 268
        Me.lbl_cant.Text = "N°"
        '
        'Button_buscar
        '
        Me.Button_buscar.Image = CType(resources.GetObject("Button_buscar.Image"), System.Drawing.Image)
        Me.Button_buscar.Location = New System.Drawing.Point(6, 20)
        Me.Button_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(145, 40)
        Me.Button_buscar.TabIndex = 267
        Me.Button_buscar.Text = "Buscar Productos"
        Me.Button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'lb_totalinscriptos
        '
        Me.lb_totalinscriptos.AutoSize = True
        Me.lb_totalinscriptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalinscriptos.ForeColor = System.Drawing.Color.Blue
        Me.lb_totalinscriptos.Location = New System.Drawing.Point(401, 331)
        Me.lb_totalinscriptos.Name = "lb_totalinscriptos"
        Me.lb_totalinscriptos.Size = New System.Drawing.Size(234, 20)
        Me.lb_totalinscriptos.TabIndex = 259
        Me.lb_totalinscriptos.Text = "Total de Insumos en la lista:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.floppy_disk30x30
        Me.Button3.Location = New System.Drawing.Point(6, 320)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 44)
        Me.Button3.TabIndex = 264
        Me.Button3.Text = "Guardar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_ausente
        '
        Me.btn_ausente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ausente.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.btn_ausente.Location = New System.Drawing.Point(150, 320)
        Me.btn_ausente.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ausente.Name = "btn_ausente"
        Me.btn_ausente.Size = New System.Drawing.Size(93, 44)
        Me.btn_ausente.TabIndex = 20
        Me.btn_ausente.Text = "Quitar"
        Me.btn_ausente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ausente.UseVisualStyleBackColor = True
        '
        'datagridview_Predef
        '
        Me.datagridview_Predef.AllowUserToAddRows = False
        Me.datagridview_Predef.AllowUserToDeleteRows = False
        Me.datagridview_Predef.AllowUserToResizeRows = False
        Me.datagridview_Predef.AutoGenerateColumns = False
        Me.datagridview_Predef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview_Predef.BackgroundColor = System.Drawing.Color.White
        Me.datagridview_Predef.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridview_Predef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview_Predef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PredefIdDataGridViewTextBoxColumn, Me.prod_id, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PredefCantidadDataGridViewTextBoxColumn, Me.prod_unidadmedida})
        Me.datagridview_Predef.DataSource = Me.PredefinidosBindingSource
        Me.datagridview_Predef.Location = New System.Drawing.Point(6, 64)
        Me.datagridview_Predef.Margin = New System.Windows.Forms.Padding(4)
        Me.datagridview_Predef.MultiSelect = False
        Me.datagridview_Predef.Name = "datagridview_Predef"
        Me.datagridview_Predef.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.datagridview_Predef.RowHeadersVisible = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridview_Predef.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridview_Predef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridview_Predef.Size = New System.Drawing.Size(709, 248)
        Me.datagridview_Predef.StandardTab = True
        Me.datagridview_Predef.TabIndex = 258
        '
        'PredefinidosBindingSource
        '
        Me.PredefinidosBindingSource.DataMember = "Predefinidos"
        Me.PredefinidosBindingSource.DataSource = Me.Ds_enfermeria
        '
        'Ds_enfermeria
        '
        Me.Ds_enfermeria.DataSetName = "Ds_enfermeria"
        Me.Ds_enfermeria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PredefIdDataGridViewTextBoxColumn
        '
        Me.PredefIdDataGridViewTextBoxColumn.DataPropertyName = "Predef_Id"
        DataGridViewCellStyle1.NullValue = "0"
        Me.PredefIdDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PredefIdDataGridViewTextBoxColumn.HeaderText = "Predef_Id"
        Me.PredefIdDataGridViewTextBoxColumn.Name = "PredefIdDataGridViewTextBoxColumn"
        Me.PredefIdDataGridViewTextBoxColumn.Visible = False
        '
        'prod_id
        '
        Me.prod_id.DataPropertyName = "prod_id"
        Me.prod_id.HeaderText = "prod_id"
        Me.prod_id.Name = "prod_id"
        Me.prod_id.Visible = False
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'PredefCantidadDataGridViewTextBoxColumn
        '
        Me.PredefCantidadDataGridViewTextBoxColumn.DataPropertyName = "Predef_Cantidad"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PredefCantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PredefCantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.PredefCantidadDataGridViewTextBoxColumn.Name = "PredefCantidadDataGridViewTextBoxColumn"
        '
        'prod_unidadmedida
        '
        Me.prod_unidadmedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prod_unidadmedida.DataPropertyName = "prod_unidadmedida"
        Me.prod_unidadmedida.HeaderText = "Unidad de Medida"
        Me.prod_unidadmedida.Name = "prod_unidadmedida"
        '
        'Insumos_Predefinidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Insumos_Predefinidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insumos Predefinidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datagridview_Predef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PredefinidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_totalinscriptos As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_ausente As System.Windows.Forms.Button
    Friend WithEvents datagridview_Predef As System.Windows.Forms.DataGridView
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
    Friend WithEvents PredefinidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_enfermeria As Aplicacion.Ds_enfermeria
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents PredefIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PredefCantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod_unidadmedida As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
