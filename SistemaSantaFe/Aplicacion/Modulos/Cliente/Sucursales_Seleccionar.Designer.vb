<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sucursales_Seleccionar
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DG_Servicio = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.item = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SucxClieidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClienombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieLocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnBDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClietelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxCliemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxCliedirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucxClieCPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.DG_Servicio)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(707, 300)
        Me.GroupBox3.TabIndex = 267
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sucursales:"
        '
        'DG_Servicio
        '
        Me.DG_Servicio.AllowUserToAddRows = False
        Me.DG_Servicio.AllowUserToDeleteRows = False
        Me.DG_Servicio.AllowUserToResizeRows = False
        Me.DG_Servicio.AutoGenerateColumns = False
        Me.DG_Servicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Servicio.BackgroundColor = System.Drawing.Color.White
        Me.DG_Servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Servicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.SucxClieidDataGridViewTextBoxColumn, Me.SucxClienombreDataGridViewTextBoxColumn, Me.SucxClieProvDataGridViewTextBoxColumn, Me.SucxClieLocDataGridViewTextBoxColumn, Me.EnBDDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.SucxClietelDataGridViewTextBoxColumn, Me.SucxCliemailDataGridViewTextBoxColumn, Me.SucxCliedirDataGridViewTextBoxColumn, Me.SucxClieCPDataGridViewTextBoxColumn})
        Me.DG_Servicio.DataSource = Me.SucursalesBindingSource
        Me.DG_Servicio.Location = New System.Drawing.Point(17, 22)
        Me.DG_Servicio.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Servicio.MultiSelect = False
        Me.DG_Servicio.Name = "DG_Servicio"
        Me.DG_Servicio.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Servicio.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Servicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Servicio.Size = New System.Drawing.Size(683, 222)
        Me.DG_Servicio.StandardTab = True
        Me.DG_Servicio.TabIndex = 265
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.CargarDato
        Me.Button3.Location = New System.Drawing.Point(577, 251)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 43)
        Me.Button3.TabIndex = 269
        Me.Button3.Text = "Seleccionar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.Cliente_ds
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.HeaderText = "item"
        Me.item.Name = "item"
        Me.item.Width = 40
        '
        'SucxClieidDataGridViewTextBoxColumn
        '
        Me.SucxClieidDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_id"
        Me.SucxClieidDataGridViewTextBoxColumn.HeaderText = "SucxClie_id"
        Me.SucxClieidDataGridViewTextBoxColumn.Name = "SucxClieidDataGridViewTextBoxColumn"
        Me.SucxClieidDataGridViewTextBoxColumn.Visible = False
        '
        'SucxClienombreDataGridViewTextBoxColumn
        '
        Me.SucxClienombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.SucxClienombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.SucxClienombreDataGridViewTextBoxColumn.Name = "SucxClienombreDataGridViewTextBoxColumn"
        Me.SucxClienombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucxClieProvDataGridViewTextBoxColumn
        '
        Me.SucxClieProvDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_Prov"
        Me.SucxClieProvDataGridViewTextBoxColumn.HeaderText = "SucxClie_Prov"
        Me.SucxClieProvDataGridViewTextBoxColumn.Name = "SucxClieProvDataGridViewTextBoxColumn"
        Me.SucxClieProvDataGridViewTextBoxColumn.Visible = False
        '
        'SucxClieLocDataGridViewTextBoxColumn
        '
        Me.SucxClieLocDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_Loc"
        Me.SucxClieLocDataGridViewTextBoxColumn.HeaderText = "SucxClie_Loc"
        Me.SucxClieLocDataGridViewTextBoxColumn.Name = "SucxClieLocDataGridViewTextBoxColumn"
        Me.SucxClieLocDataGridViewTextBoxColumn.Visible = False
        '
        'EnBDDataGridViewTextBoxColumn
        '
        Me.EnBDDataGridViewTextBoxColumn.DataPropertyName = "EnBD"
        Me.EnBDDataGridViewTextBoxColumn.HeaderText = "EnBD"
        Me.EnBDDataGridViewTextBoxColumn.Name = "EnBDDataGridViewTextBoxColumn"
        Me.EnBDDataGridViewTextBoxColumn.Visible = False
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucxClietelDataGridViewTextBoxColumn
        '
        Me.SucxClietelDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_tel"
        Me.SucxClietelDataGridViewTextBoxColumn.HeaderText = "SucxClie_tel"
        Me.SucxClietelDataGridViewTextBoxColumn.Name = "SucxClietelDataGridViewTextBoxColumn"
        Me.SucxClietelDataGridViewTextBoxColumn.Visible = False
        '
        'SucxCliemailDataGridViewTextBoxColumn
        '
        Me.SucxCliemailDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_mail"
        Me.SucxCliemailDataGridViewTextBoxColumn.HeaderText = "SucxClie_mail"
        Me.SucxCliemailDataGridViewTextBoxColumn.Name = "SucxCliemailDataGridViewTextBoxColumn"
        Me.SucxCliemailDataGridViewTextBoxColumn.Visible = False
        '
        'SucxCliedirDataGridViewTextBoxColumn
        '
        Me.SucxCliedirDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_dir"
        Me.SucxCliedirDataGridViewTextBoxColumn.HeaderText = "SucxClie_dir"
        Me.SucxCliedirDataGridViewTextBoxColumn.Name = "SucxCliedirDataGridViewTextBoxColumn"
        Me.SucxCliedirDataGridViewTextBoxColumn.Visible = False
        '
        'SucxClieCPDataGridViewTextBoxColumn
        '
        Me.SucxClieCPDataGridViewTextBoxColumn.DataPropertyName = "SucxClie_CP"
        Me.SucxClieCPDataGridViewTextBoxColumn.HeaderText = "SucxClie_CP"
        Me.SucxClieCPDataGridViewTextBoxColumn.Name = "SucxClieCPDataGridViewTextBoxColumn"
        Me.SucxClieCPDataGridViewTextBoxColumn.Visible = False
        '
        'Sucursales_Seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 345)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Sucursales_Seleccionar"
        Me.Text = "Seleccionar Sucursal"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DG_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Servicio As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents item As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SucxClieidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClienombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieProvDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieLocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnBDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClietelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxCliemailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxCliedirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucxClieCPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
