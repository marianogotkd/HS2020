<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Categorias))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bo_guardar = New System.Windows.Forms.Button()
        Me.BO_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TreeView_agregadas = New System.Windows.Forms.TreeView()
        Me.bot_eliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BO_nuevo = New System.Windows.Forms.Button()
        Me.txt_categoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_rubro = New System.Windows.Forms.TextBox()
        Me.bot_agregar_cat = New System.Windows.Forms.Button()
        Me.txt_subrubro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BO_delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CatidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat1_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Categorias_DS = New Aplicacion.Categorias_DS()
        Me.BO_edit_selec = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Categoria1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(539, 591)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(531, 565)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Categorias de Productos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(506, 548)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los datos de la categoria del productos:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.bo_guardar)
        Me.GroupBox2.Controls.Add(Me.BO_cancelar)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BO_nuevo)
        Me.GroupBox2.Controls.Add(Me.txt_categoria)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_rubro)
        Me.GroupBox2.Controls.Add(Me.bot_agregar_cat)
        Me.GroupBox2.Controls.Add(Me.txt_subrubro)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(21, 27)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(475, 494)
        Me.GroupBox2.TabIndex = 267
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categoria, Rubro y Subrubro"
        '
        'bo_guardar
        '
        Me.bo_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bo_guardar.Enabled = False
        Me.bo_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_guardar.Image = Global.Aplicacion.My.Resources.Resources.Guardar
        Me.bo_guardar.Location = New System.Drawing.Point(198, 427)
        Me.bo_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.bo_guardar.Name = "bo_guardar"
        Me.bo_guardar.Size = New System.Drawing.Size(131, 49)
        Me.bo_guardar.TabIndex = 6
        Me.bo_guardar.Text = "Guardar"
        Me.bo_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.bo_guardar, "Guardar nueva categoría")
        Me.bo_guardar.UseVisualStyleBackColor = True
        '
        'BO_cancelar
        '
        Me.BO_cancelar.Enabled = False
        Me.BO_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cancelar.Image = Global.Aplicacion.My.Resources.Resources.Limpiar
        Me.BO_cancelar.Location = New System.Drawing.Point(337, 427)
        Me.BO_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cancelar.Name = "BO_cancelar"
        Me.BO_cancelar.Size = New System.Drawing.Size(115, 49)
        Me.BO_cancelar.TabIndex = 7
        Me.BO_cancelar.Text = "Cancelar"
        Me.BO_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_cancelar, "Cancelar")
        Me.BO_cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TreeView_agregadas)
        Me.GroupBox3.Controls.Add(Me.bot_eliminar)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox3.Location = New System.Drawing.Point(24, 183)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(428, 236)
        Me.GroupBox3.TabIndex = 268
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rubros y Subrubros agregados:"
        '
        'TreeView_agregadas
        '
        Me.TreeView_agregadas.Enabled = False
        Me.TreeView_agregadas.Location = New System.Drawing.Point(20, 28)
        Me.TreeView_agregadas.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeView_agregadas.Name = "TreeView_agregadas"
        Me.TreeView_agregadas.Size = New System.Drawing.Size(400, 149)
        Me.TreeView_agregadas.TabIndex = 200
        '
        'bot_eliminar
        '
        Me.bot_eliminar.Enabled = False
        Me.bot_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_eliminar.Image = CType(resources.GetObject("bot_eliminar.Image"), System.Drawing.Image)
        Me.bot_eliminar.Location = New System.Drawing.Point(314, 185)
        Me.bot_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.bot_eliminar.Name = "bot_eliminar"
        Me.bot_eliminar.Size = New System.Drawing.Size(106, 37)
        Me.bot_eliminar.TabIndex = 8
        Me.bot_eliminar.Text = "Eliminar"
        Me.bot_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.bot_eliminar, "Quitar Rubro, Subrubro")
        Me.bot_eliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(21, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 266
        Me.Label2.Text = "Categoria"
        '
        'BO_nuevo
        '
        Me.BO_nuevo.Image = CType(resources.GetObject("BO_nuevo.Image"), System.Drawing.Image)
        Me.BO_nuevo.Location = New System.Drawing.Point(24, 427)
        Me.BO_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_nuevo.Name = "BO_nuevo"
        Me.BO_nuevo.Size = New System.Drawing.Size(53, 49)
        Me.BO_nuevo.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BO_nuevo, "Nueva Categoría")
        Me.BO_nuevo.UseVisualStyleBackColor = True
        Me.BO_nuevo.Visible = False
        '
        'txt_categoria
        '
        Me.txt_categoria.Enabled = False
        Me.txt_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_categoria.Location = New System.Drawing.Point(123, 31)
        Me.txt_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_categoria.Name = "txt_categoria"
        Me.txt_categoria.Size = New System.Drawing.Size(329, 20)
        Me.txt_categoria.TabIndex = 0
        Me.txt_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(21, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Subrubro"
        '
        'txt_rubro
        '
        Me.txt_rubro.Enabled = False
        Me.txt_rubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_rubro.Location = New System.Drawing.Point(123, 68)
        Me.txt_rubro.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rubro.Name = "txt_rubro"
        Me.txt_rubro.Size = New System.Drawing.Size(329, 20)
        Me.txt_rubro.TabIndex = 1
        Me.txt_rubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bot_agregar_cat
        '
        Me.bot_agregar_cat.Enabled = False
        Me.bot_agregar_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_agregar_cat.Image = CType(resources.GetObject("bot_agregar_cat.Image"), System.Drawing.Image)
        Me.bot_agregar_cat.Location = New System.Drawing.Point(339, 134)
        Me.bot_agregar_cat.Margin = New System.Windows.Forms.Padding(4)
        Me.bot_agregar_cat.Name = "bot_agregar_cat"
        Me.bot_agregar_cat.Size = New System.Drawing.Size(113, 37)
        Me.bot_agregar_cat.TabIndex = 4
        Me.bot_agregar_cat.Text = "Agregar"
        Me.bot_agregar_cat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.bot_agregar_cat, "Agregar Rubro, Subrubro")
        Me.bot_agregar_cat.UseVisualStyleBackColor = True
        '
        'txt_subrubro
        '
        Me.txt_subrubro.Enabled = False
        Me.txt_subrubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_subrubro.Location = New System.Drawing.Point(123, 103)
        Me.txt_subrubro.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_subrubro.Name = "txt_subrubro"
        Me.txt_subrubro.Size = New System.Drawing.Size(329, 20)
        Me.txt_subrubro.TabIndex = 2
        Me.txt_subrubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(21, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Rubro"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(560, 46)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BO_delete)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BO_edit_selec)
        Me.SplitContainer1.Size = New System.Drawing.Size(1068, 262)
        Me.SplitContainer1.SplitterDistance = 356
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TreeView1.ItemHeight = 20
        Me.TreeView1.Location = New System.Drawing.Point(45, 185)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(271, 51)
        Me.TreeView1.TabIndex = 0
        Me.TreeView1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(398, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Abajo hay una grilla invisible que se usa"
        Me.Label4.Visible = False
        '
        'BO_delete
        '
        Me.BO_delete.Image = Global.Aplicacion.My.Resources.Resources.Borrar
        Me.BO_delete.Location = New System.Drawing.Point(641, 111)
        Me.BO_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_delete.Name = "BO_delete"
        Me.BO_delete.Size = New System.Drawing.Size(53, 49)
        Me.BO_delete.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BO_delete, "Borrar")
        Me.BO_delete.UseVisualStyleBackColor = True
        Me.BO_delete.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Categorias Existentes"
        Me.Label1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CatidDataGridViewTextBoxColumn, Me.cat1_nom})
        Me.DataGridView1.DataSource = Me.Categoria1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 42)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(621, 203)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'CatidDataGridViewTextBoxColumn
        '
        Me.CatidDataGridViewTextBoxColumn.DataPropertyName = "cat_id"
        Me.CatidDataGridViewTextBoxColumn.HeaderText = "cat_id"
        Me.CatidDataGridViewTextBoxColumn.Name = "CatidDataGridViewTextBoxColumn"
        Me.CatidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CatidDataGridViewTextBoxColumn.Visible = False
        '
        'cat1_nom
        '
        Me.cat1_nom.DataPropertyName = "cat1_nom"
        Me.cat1_nom.HeaderText = "Categoria"
        Me.cat1_nom.Name = "cat1_nom"
        Me.cat1_nom.ReadOnly = True
        Me.cat1_nom.Width = 550
        '
        'Categoria1BindingSource
        '
        Me.Categoria1BindingSource.DataMember = "Categoria_1"
        Me.Categoria1BindingSource.DataSource = Me.Categorias_DS
        '
        'Categorias_DS
        '
        Me.Categorias_DS.DataSetName = "Categorias_DS"
        Me.Categorias_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BO_edit_selec
        '
        Me.BO_edit_selec.Image = CType(resources.GetObject("BO_edit_selec.Image"), System.Drawing.Image)
        Me.BO_edit_selec.Location = New System.Drawing.Point(641, 54)
        Me.BO_edit_selec.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_edit_selec.Name = "BO_edit_selec"
        Me.BO_edit_selec.Size = New System.Drawing.Size(53, 49)
        Me.BO_edit_selec.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BO_edit_selec, "Editar")
        Me.BO_edit_selec.UseVisualStyleBackColor = True
        Me.BO_edit_selec.Visible = False
        '
        'Categorias
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(556, 611)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Categorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorias"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Categoria1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_subrubro As System.Windows.Forms.TextBox
    Friend WithEvents TreeView_agregadas As System.Windows.Forms.TreeView
    Friend WithEvents bo_guardar As System.Windows.Forms.Button
    Friend WithEvents bot_eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_nuevo As System.Windows.Forms.Button
    Friend WithEvents BO_cancelar As System.Windows.Forms.Button
    Friend WithEvents bot_agregar_cat As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_rubro As System.Windows.Forms.TextBox
    Friend WithEvents txt_categoria As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents BO_delete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BO_edit_selec As System.Windows.Forms.Button
    Friend WithEvents Categoria1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Categorias_DS As Aplicacion.Categorias_DS
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CatidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cat1_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
