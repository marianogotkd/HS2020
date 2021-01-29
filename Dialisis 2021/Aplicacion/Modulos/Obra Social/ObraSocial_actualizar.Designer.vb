<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObraSocial_actualizar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ObrasocialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_obrasocial = New Aplicacion.ds_obrasocial()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Anular = New System.Windows.Forms.Button()
        Me.Button_Detalle = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ObrasocialidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrasocialnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObrasocialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_obrasocial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(689, 271)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione la Categoría para editar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ObrasocialidDataGridViewTextBoxColumn, Me.ObrasocialnombreDataGridViewTextBoxColumn, Me.Column2})
        Me.DataGridView1.DataSource = Me.ObrasocialBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(673, 246)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 10
        '
        'ObrasocialBindingSource
        '
        Me.ObrasocialBindingSource.DataMember = "Obrasocial"
        Me.ObrasocialBindingSource.DataSource = Me.Ds_obrasocial
        '
        'Ds_obrasocial
        '
        Me.Ds_obrasocial.DataSetName = "ds_obrasocial"
        Me.Ds_obrasocial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.Button1.Location = New System.Drawing.Point(607, 289)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 44)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Nuevo"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Anular
        '
        Me.btn_Anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Anular.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Anular.Location = New System.Drawing.Point(404, 289)
        Me.btn_Anular.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Anular.Name = "btn_Anular"
        Me.btn_Anular.Size = New System.Drawing.Size(93, 44)
        Me.btn_Anular.TabIndex = 27
        Me.btn_Anular.Text = "Eliminar"
        Me.btn_Anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Anular.UseVisualStyleBackColor = True
        '
        'Button_Detalle
        '
        Me.Button_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Detalle.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_Detalle.Location = New System.Drawing.Point(507, 289)
        Me.Button_Detalle.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Detalle.Name = "Button_Detalle"
        Me.Button_Detalle.Size = New System.Drawing.Size(93, 44)
        Me.Button_Detalle.TabIndex = 26
        Me.Button_Detalle.Text = "Editar"
        Me.Button_Detalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Detalle.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 101.5228!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 50
        '
        'ObrasocialidDataGridViewTextBoxColumn
        '
        Me.ObrasocialidDataGridViewTextBoxColumn.DataPropertyName = "Obrasocial_id"
        Me.ObrasocialidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.ObrasocialidDataGridViewTextBoxColumn.Name = "ObrasocialidDataGridViewTextBoxColumn"
        Me.ObrasocialidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObrasocialnombreDataGridViewTextBoxColumn
        '
        Me.ObrasocialnombreDataGridViewTextBoxColumn.DataPropertyName = "Obrasocial_nombre"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.Name = "ObrasocialnombreDataGridViewTextBoxColumn"
        Me.ObrasocialnombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObrasocialnombreDataGridViewTextBoxColumn.Width = 500
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'ObraSocial_actualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(716, 338)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Anular)
        Me.Controls.Add(Me.Button_Detalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ObraSocial_actualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Obra Social"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObrasocialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_obrasocial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Anular As System.Windows.Forms.Button
    Friend WithEvents Button_Detalle As System.Windows.Forms.Button
    Friend WithEvents ObrasocialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_obrasocial As Aplicacion.ds_obrasocial
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ObrasocialidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObrasocialnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
