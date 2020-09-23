<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta_sucursal_resumen
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DG_usuario = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DG_vendedor = New System.Windows.Forms.DataGridView()
        Me.label_fecha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResumenusuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_consulta_ds1 = New Aplicacion.Venta_consulta_ds()
        Me.ResumenvendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_consulta_ds = New Aplicacion.Venta_consulta_ds()
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantventasDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalventaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantventasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedoridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DG_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DG_vendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenusuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_consulta_ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenvendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_consulta_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESUMEN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.label_fecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 333)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sucursal: Principal"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(25, 85)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(608, 237)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DG_usuario)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(600, 208)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado por Usuario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DG_usuario
        '
        Me.DG_usuario.AllowUserToAddRows = False
        Me.DG_usuario.AllowUserToDeleteRows = False
        Me.DG_usuario.AllowUserToResizeRows = False
        Me.DG_usuario.AutoGenerateColumns = False
        Me.DG_usuario.BackgroundColor = System.Drawing.Color.White
        Me.DG_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_usuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionDataGridViewTextBoxColumn1, Me.CantventasDataGridViewTextBoxColumn1, Me.TotalventaDataGridViewTextBoxColumn1, Me.UsuarioidDataGridViewTextBoxColumn})
        Me.DG_usuario.DataSource = Me.ResumenusuariosBindingSource
        Me.DG_usuario.Location = New System.Drawing.Point(7, 7)
        Me.DG_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_usuario.MultiSelect = False
        Me.DG_usuario.Name = "DG_usuario"
        Me.DG_usuario.ReadOnly = True
        Me.DG_usuario.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_usuario.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_usuario.Size = New System.Drawing.Size(586, 194)
        Me.DG_usuario.StandardTab = True
        Me.DG_usuario.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DG_vendedor)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(600, 208)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listado por vendedor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DG_vendedor
        '
        Me.DG_vendedor.AllowUserToAddRows = False
        Me.DG_vendedor.AllowUserToDeleteRows = False
        Me.DG_vendedor.AllowUserToResizeRows = False
        Me.DG_vendedor.AutoGenerateColumns = False
        Me.DG_vendedor.BackgroundColor = System.Drawing.Color.White
        Me.DG_vendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_vendedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionDataGridViewTextBoxColumn, Me.CantventasDataGridViewTextBoxColumn, Me.TotalventaDataGridViewTextBoxColumn, Me.VendedoridDataGridViewTextBoxColumn})
        Me.DG_vendedor.DataSource = Me.ResumenvendedoresBindingSource
        Me.DG_vendedor.Location = New System.Drawing.Point(7, 7)
        Me.DG_vendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_vendedor.MultiSelect = False
        Me.DG_vendedor.Name = "DG_vendedor"
        Me.DG_vendedor.ReadOnly = True
        Me.DG_vendedor.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_vendedor.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_vendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_vendedor.Size = New System.Drawing.Size(586, 194)
        Me.DG_vendedor.StandardTab = True
        Me.DG_vendedor.TabIndex = 13
        '
        'label_fecha
        '
        Me.label_fecha.AutoSize = True
        Me.label_fecha.Location = New System.Drawing.Point(22, 55)
        Me.label_fecha.Name = "label_fecha"
        Me.label_fecha.Size = New System.Drawing.Size(248, 17)
        Me.label_fecha.TabIndex = 3
        Me.label_fecha.Text = "Desde 00-00-2019 hasta 00-00-2019:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'ResumenusuariosBindingSource
        '
        Me.ResumenusuariosBindingSource.DataMember = "Resumen_usuarios"
        Me.ResumenusuariosBindingSource.DataSource = Me.Venta_consulta_ds1
        '
        'Venta_consulta_ds1
        '
        Me.Venta_consulta_ds1.DataSetName = "Venta_consulta_ds"
        Me.Venta_consulta_ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResumenvendedoresBindingSource
        '
        Me.ResumenvendedoresBindingSource.DataMember = "Resumen_vendedores"
        Me.ResumenvendedoresBindingSource.DataSource = Me.Venta_consulta_ds1
        '
        'Venta_consulta_ds
        '
        Me.Venta_consulta_ds.DataSetName = "Venta_consulta_ds"
        Me.Venta_consulta_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        Me.DescripcionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CantventasDataGridViewTextBoxColumn1
        '
        Me.CantventasDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantventasDataGridViewTextBoxColumn1.DataPropertyName = "cant_ventas"
        Me.CantventasDataGridViewTextBoxColumn1.HeaderText = "Cantidad de ventas"
        Me.CantventasDataGridViewTextBoxColumn1.Name = "CantventasDataGridViewTextBoxColumn1"
        Me.CantventasDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotalventaDataGridViewTextBoxColumn1
        '
        Me.TotalventaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalventaDataGridViewTextBoxColumn1.DataPropertyName = "total_venta"
        Me.TotalventaDataGridViewTextBoxColumn1.HeaderText = "Total ($)"
        Me.TotalventaDataGridViewTextBoxColumn1.Name = "TotalventaDataGridViewTextBoxColumn1"
        Me.TotalventaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UsuarioidDataGridViewTextBoxColumn
        '
        Me.UsuarioidDataGridViewTextBoxColumn.DataPropertyName = "usuario_id"
        Me.UsuarioidDataGridViewTextBoxColumn.HeaderText = "usuario_id"
        Me.UsuarioidDataGridViewTextBoxColumn.Name = "UsuarioidDataGridViewTextBoxColumn"
        Me.UsuarioidDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioidDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantventasDataGridViewTextBoxColumn
        '
        Me.CantventasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantventasDataGridViewTextBoxColumn.DataPropertyName = "cant_ventas"
        Me.CantventasDataGridViewTextBoxColumn.HeaderText = "Cantidad de ventas"
        Me.CantventasDataGridViewTextBoxColumn.Name = "CantventasDataGridViewTextBoxColumn"
        Me.CantventasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalventaDataGridViewTextBoxColumn
        '
        Me.TotalventaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalventaDataGridViewTextBoxColumn.DataPropertyName = "total_venta"
        Me.TotalventaDataGridViewTextBoxColumn.HeaderText = "Total ($)"
        Me.TotalventaDataGridViewTextBoxColumn.Name = "TotalventaDataGridViewTextBoxColumn"
        Me.TotalventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendedoridDataGridViewTextBoxColumn
        '
        Me.VendedoridDataGridViewTextBoxColumn.DataPropertyName = "vendedor_id"
        Me.VendedoridDataGridViewTextBoxColumn.HeaderText = "vendedor_id"
        Me.VendedoridDataGridViewTextBoxColumn.Name = "VendedoridDataGridViewTextBoxColumn"
        Me.VendedoridDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendedoridDataGridViewTextBoxColumn.Visible = False
        '
        'Venta_sucursal_resumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(678, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Venta_sucursal_resumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DG_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DG_vendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenusuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_consulta_ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenvendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_consulta_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents label_fecha As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents DG_usuario As System.Windows.Forms.DataGridView
    Public WithEvents DG_vendedor As System.Windows.Forms.DataGridView
    Friend WithEvents Venta_consulta_ds As Aplicacion.Venta_consulta_ds
    Friend WithEvents ResumenusuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_consulta_ds1 As Aplicacion.Venta_consulta_ds
    Friend WithEvents ResumenvendedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantventasDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalventaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantventasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalventaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendedoridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
