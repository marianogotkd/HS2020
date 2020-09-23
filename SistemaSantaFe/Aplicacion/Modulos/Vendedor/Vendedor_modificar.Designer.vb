<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedor_modificar
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BO_usuario_nuevo = New System.Windows.Forms.Button()
        Me.BO_usuario_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_usuario = New System.Windows.Forms.DataGridView()
        Me.VendedoridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedordniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorapenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorobservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedoragregadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_vendedor = New Aplicacion.DS_vendedor()
        Me.Caja_ds = New Aplicacion.Caja_ds()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedoragregadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_vendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(855, 300)
        Me.TabControl1.TabIndex = 136
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BO_usuario_nuevo)
        Me.TabPage1.Controls.Add(Me.BO_usuario_modificar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(847, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vendedores registrados:"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BO_usuario_nuevo
        '
        Me.BO_usuario_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_usuario_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.BO_usuario_nuevo.Location = New System.Drawing.Point(562, 212)
        Me.BO_usuario_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_usuario_nuevo.Name = "BO_usuario_nuevo"
        Me.BO_usuario_nuevo.Size = New System.Drawing.Size(124, 43)
        Me.BO_usuario_nuevo.TabIndex = 134
        Me.BO_usuario_nuevo.Text = "Agregar"
        Me.BO_usuario_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_usuario_nuevo.UseVisualStyleBackColor = True
        '
        'BO_usuario_modificar
        '
        Me.BO_usuario_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_usuario_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_usuario_modificar.Location = New System.Drawing.Point(694, 212)
        Me.BO_usuario_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_usuario_modificar.Name = "BO_usuario_modificar"
        Me.BO_usuario_modificar.Size = New System.Drawing.Size(124, 43)
        Me.BO_usuario_modificar.TabIndex = 133
        Me.BO_usuario_modificar.Text = "Editar"
        Me.BO_usuario_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_usuario_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DG_usuario)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(810, 196)
        Me.GroupBox1.TabIndex = 127
        Me.GroupBox1.TabStop = False
        '
        'DG_usuario
        '
        Me.DG_usuario.AllowUserToAddRows = False
        Me.DG_usuario.AllowUserToDeleteRows = False
        Me.DG_usuario.AllowUserToResizeRows = False
        Me.DG_usuario.AutoGenerateColumns = False
        Me.DG_usuario.BackgroundColor = System.Drawing.Color.White
        Me.DG_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_usuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VendedoridDataGridViewTextBoxColumn, Me.VendedordniDataGridViewTextBoxColumn, Me.VendedorapenomDataGridViewTextBoxColumn, Me.VendedorobservacionDataGridViewTextBoxColumn})
        Me.DG_usuario.DataSource = Me.VendedoragregadoBindingSource
        Me.DG_usuario.GridColor = System.Drawing.Color.DarkSlateGray
        Me.DG_usuario.Location = New System.Drawing.Point(8, 23)
        Me.DG_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_usuario.MultiSelect = False
        Me.DG_usuario.Name = "DG_usuario"
        Me.DG_usuario.ReadOnly = True
        Me.DG_usuario.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_usuario.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_usuario.Size = New System.Drawing.Size(794, 165)
        Me.DG_usuario.StandardTab = True
        Me.DG_usuario.TabIndex = 0
        '
        'VendedoridDataGridViewTextBoxColumn
        '
        Me.VendedoridDataGridViewTextBoxColumn.DataPropertyName = "vendedor_id"
        Me.VendedoridDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.VendedoridDataGridViewTextBoxColumn.Name = "VendedoridDataGridViewTextBoxColumn"
        Me.VendedoridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendedordniDataGridViewTextBoxColumn
        '
        Me.VendedordniDataGridViewTextBoxColumn.DataPropertyName = "vendedor_dni"
        Me.VendedordniDataGridViewTextBoxColumn.HeaderText = "Dni"
        Me.VendedordniDataGridViewTextBoxColumn.Name = "VendedordniDataGridViewTextBoxColumn"
        Me.VendedordniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendedorapenomDataGridViewTextBoxColumn
        '
        Me.VendedorapenomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VendedorapenomDataGridViewTextBoxColumn.DataPropertyName = "vendedor_apenom"
        Me.VendedorapenomDataGridViewTextBoxColumn.HeaderText = "Apellido y Nombre"
        Me.VendedorapenomDataGridViewTextBoxColumn.Name = "VendedorapenomDataGridViewTextBoxColumn"
        Me.VendedorapenomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendedorobservacionDataGridViewTextBoxColumn
        '
        Me.VendedorobservacionDataGridViewTextBoxColumn.DataPropertyName = "vendedor_observacion"
        Me.VendedorobservacionDataGridViewTextBoxColumn.HeaderText = "Observacion"
        Me.VendedorobservacionDataGridViewTextBoxColumn.Name = "VendedorobservacionDataGridViewTextBoxColumn"
        Me.VendedorobservacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendedorobservacionDataGridViewTextBoxColumn.Width = 200
        '
        'VendedoragregadoBindingSource
        '
        Me.VendedoragregadoBindingSource.DataMember = "Vendedor_agregado"
        Me.VendedoragregadoBindingSource.DataSource = Me.DS_vendedor
        '
        'DS_vendedor
        '
        Me.DS_vendedor.DataSetName = "DS_vendedor"
        Me.DS_vendedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Caja_ds
        '
        Me.Caja_ds.DataSetName = "Caja_ds"
        Me.Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vendedor_modificar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 327)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Vendedor_modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Vendedores"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedoragregadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_vendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BO_usuario_nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_usuario_modificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_usuario As System.Windows.Forms.DataGridView
    Friend WithEvents VendedoridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendedordniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendedorapenomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendedorobservacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendedoragregadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_vendedor As Aplicacion.DS_vendedor
    Friend WithEvents Caja_ds As Aplicacion.Caja_ds
End Class
