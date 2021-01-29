<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria_Actualizar
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
        Me.Categorias_DS = New Aplicacion.Categorias_DS()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cat_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat1_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subrubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatrubrosubrubroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Anular = New System.Windows.Forms.Button()
        Me.Button_Detalle = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatrubrosubrubroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Categorias_DS
        '
        Me.Categorias_DS.DataSetName = "Categorias_DS"
        Me.Categorias_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.cat_id, Me.cat1_nom, Me.rubro, Me.subrubro, Me.Column2})
        Me.DataGridView1.DataSource = Me.CatrubrosubrubroBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(673, 246)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.FillWeight = 101.5228!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'cat_id
        '
        Me.cat_id.DataPropertyName = "cat_id"
        Me.cat_id.HeaderText = "cat_id"
        Me.cat_id.Name = "cat_id"
        Me.cat_id.ReadOnly = True
        Me.cat_id.Visible = False
        '
        'cat1_nom
        '
        Me.cat1_nom.DataPropertyName = "cat1_nom"
        Me.cat1_nom.FillWeight = 99.49239!
        Me.cat1_nom.HeaderText = "Categoria"
        Me.cat1_nom.Name = "cat1_nom"
        Me.cat1_nom.ReadOnly = True
        Me.cat1_nom.Width = 150
        '
        'rubro
        '
        Me.rubro.DataPropertyName = "rubro"
        Me.rubro.FillWeight = 99.49239!
        Me.rubro.HeaderText = "Rubros"
        Me.rubro.Name = "rubro"
        Me.rubro.ReadOnly = True
        Me.rubro.Width = 150
        '
        'subrubro
        '
        Me.subrubro.DataPropertyName = "subrubro"
        Me.subrubro.FillWeight = 99.49239!
        Me.subrubro.HeaderText = "Subrubros"
        Me.subrubro.Name = "subrubro"
        Me.subrubro.ReadOnly = True
        Me.subrubro.Width = 150
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'CatrubrosubrubroBindingSource
        '
        Me.CatrubrosubrubroBindingSource.DataMember = "Cat_rubro_subrubro"
        Me.CatrubrosubrubroBindingSource.DataSource = Me.Categorias_DS
        '
        'btn_Anular
        '
        Me.btn_Anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Anular.Image = Global.Aplicacion.My.Resources.Resources.Limpiar1
        Me.btn_Anular.Location = New System.Drawing.Point(404, 288)
        Me.btn_Anular.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Anular.Name = "btn_Anular"
        Me.btn_Anular.Size = New System.Drawing.Size(93, 44)
        Me.btn_Anular.TabIndex = 15
        Me.btn_Anular.Text = "Eliminar"
        Me.btn_Anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Anular, "Eliminar categoría seleccionada")
        Me.btn_Anular.UseVisualStyleBackColor = True
        '
        'Button_Detalle
        '
        Me.Button_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Detalle.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_Detalle.Location = New System.Drawing.Point(505, 288)
        Me.Button_Detalle.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Detalle.Name = "Button_Detalle"
        Me.Button_Detalle.Size = New System.Drawing.Size(93, 44)
        Me.Button_Detalle.TabIndex = 14
        Me.Button_Detalle.Text = "Editar"
        Me.Button_Detalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_Detalle, "Editar categoría seleccionada")
        Me.Button_Detalle.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.Button1.Location = New System.Drawing.Point(605, 288)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 44)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Nuevo"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Nueva Categoría")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(689, 271)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione la Categoría para editar"
        '
        'Categoria_Actualizar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.ClientSize = New System.Drawing.Size(725, 345)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Anular)
        Me.Controls.Add(Me.Button_Detalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Categoria_Actualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorías"
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatrubrosubrubroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RubrosubrubroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categorias_DS As Aplicacion.Categorias_DS
    Friend WithEvents CatrubrosubrubroBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Anular As System.Windows.Forms.Button
    Friend WithEvents Button_Detalle As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cat_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cat1_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rubro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subrubro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
