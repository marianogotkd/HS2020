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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Insumos_Predefinidos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_totalinscriptos = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_ausente = New System.Windows.Forms.Button()
        Me.datagridview_Predef = New System.Windows.Forms.DataGridView()
        Me.Button_buscar = New System.Windows.Forms.Button()
        Me.Ds_enfermeria = New Aplicacion.Ds_enfermeria()
        Me.PredefinidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PredefIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdcodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PredefCantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datagridview_Predef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PredefinidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_buscar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lb_totalinscriptos)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btn_ausente)
        Me.GroupBox1.Controls.Add(Me.datagridview_Predef)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 377)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(410, 16)
        Me.Label4.TabIndex = 266
        Me.Label4.Text = "Ingrese el Codigo del Producto ó presione F1 para Buscar"
        '
        'lb_totalinscriptos
        '
        Me.lb_totalinscriptos.AutoSize = True
        Me.lb_totalinscriptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalinscriptos.ForeColor = System.Drawing.Color.Blue
        Me.lb_totalinscriptos.Location = New System.Drawing.Point(437, 331)
        Me.lb_totalinscriptos.Name = "lb_totalinscriptos"
        Me.lb_totalinscriptos.Size = New System.Drawing.Size(234, 20)
        Me.lb_totalinscriptos.TabIndex = 259
        Me.lb_totalinscriptos.Text = "Total de Insumos en la lista:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(410, 22)
        Me.TextBox1.TabIndex = 265
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.Button3.Location = New System.Drawing.Point(6, 320)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 44)
        Me.Button3.TabIndex = 264
        Me.Button3.Text = "Nueva dialisis"
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
        Me.datagridview_Predef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PredefIdDataGridViewTextBoxColumn, Me.ProdcodinternoDataGridViewTextBoxColumn, Me.PredefCantidadDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.datagridview_Predef.DataSource = Me.PredefinidosBindingSource
        Me.datagridview_Predef.Location = New System.Drawing.Point(6, 64)
        Me.datagridview_Predef.Margin = New System.Windows.Forms.Padding(4)
        Me.datagridview_Predef.MultiSelect = False
        Me.datagridview_Predef.Name = "datagridview_Predef"
        Me.datagridview_Predef.ReadOnly = True
        Me.datagridview_Predef.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.datagridview_Predef.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridview_Predef.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridview_Predef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview_Predef.Size = New System.Drawing.Size(709, 248)
        Me.datagridview_Predef.StandardTab = True
        Me.datagridview_Predef.TabIndex = 258
        '
        'Button_buscar
        '
        Me.Button_buscar.Image = CType(resources.GetObject("Button_buscar.Image"), System.Drawing.Image)
        Me.Button_buscar.Location = New System.Drawing.Point(423, 16)
        Me.Button_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(90, 40)
        Me.Button_buscar.TabIndex = 267
        Me.Button_buscar.Text = "Buscar"
        Me.Button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'Ds_enfermeria
        '
        Me.Ds_enfermeria.DataSetName = "Ds_enfermeria"
        Me.Ds_enfermeria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PredefinidosBindingSource
        '
        Me.PredefinidosBindingSource.DataMember = "Predefinidos"
        Me.PredefinidosBindingSource.DataSource = Me.Ds_enfermeria
        '
        'PredefIdDataGridViewTextBoxColumn
        '
        Me.PredefIdDataGridViewTextBoxColumn.DataPropertyName = "Predef_Id"
        Me.PredefIdDataGridViewTextBoxColumn.HeaderText = "Predef_Id"
        Me.PredefIdDataGridViewTextBoxColumn.Name = "PredefIdDataGridViewTextBoxColumn"
        Me.PredefIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdcodinternoDataGridViewTextBoxColumn
        '
        Me.ProdcodinternoDataGridViewTextBoxColumn.DataPropertyName = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.HeaderText = "prod_codinterno"
        Me.ProdcodinternoDataGridViewTextBoxColumn.Name = "ProdcodinternoDataGridViewTextBoxColumn"
        Me.ProdcodinternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PredefCantidadDataGridViewTextBoxColumn
        '
        Me.PredefCantidadDataGridViewTextBoxColumn.DataPropertyName = "Predef_Cantidad"
        Me.PredefCantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.PredefCantidadDataGridViewTextBoxColumn.Name = "PredefCantidadDataGridViewTextBoxColumn"
        Me.PredefCantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Insumos_Predefinidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Insumos_Predefinidos"
        Me.Text = "Insumos Predefinidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datagridview_Predef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_enfermeria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PredefinidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lb_totalinscriptos As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_ausente As System.Windows.Forms.Button
    Friend WithEvents datagridview_Predef As System.Windows.Forms.DataGridView
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
    Friend WithEvents PredefIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdcodinternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PredefCantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PredefinidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_enfermeria As Aplicacion.Ds_enfermeria
End Class
