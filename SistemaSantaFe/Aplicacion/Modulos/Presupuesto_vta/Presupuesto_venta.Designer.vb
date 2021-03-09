<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presupuesto_venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presupuesto_venta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button_editar = New System.Windows.Forms.Button()
        Me.Button_imprimir = New System.Windows.Forms.Button()
        Me.Button_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Busqueda = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_presupuesto_vta = New Aplicacion.DS_presupuesto_vta()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PresupuestoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FantasiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCteidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestofechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_presupuesto_vta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.menos
        Me.Button2.Location = New System.Drawing.Point(186, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 49)
        Me.Button2.TabIndex = 273
        Me.Button2.Text = "Anular"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button_editar
        '
        Me.Button_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_editar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.Button_editar.Location = New System.Drawing.Point(298, 12)
        Me.Button_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_editar.Name = "Button_editar"
        Me.Button_editar.Size = New System.Drawing.Size(105, 49)
        Me.Button_editar.TabIndex = 272
        Me.Button_editar.Text = "Editar"
        Me.Button_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_editar.UseVisualStyleBackColor = True
        Me.Button_editar.Visible = False
        '
        'Button_imprimir
        '
        Me.Button_imprimir.Image = CType(resources.GetObject("Button_imprimir.Image"), System.Drawing.Image)
        Me.Button_imprimir.Location = New System.Drawing.Point(126, 13)
        Me.Button_imprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_imprimir.Name = "Button_imprimir"
        Me.Button_imprimir.Size = New System.Drawing.Size(53, 49)
        Me.Button_imprimir.TabIndex = 271
        Me.Button_imprimir.TabStop = False
        Me.Button_imprimir.UseVisualStyleBackColor = True
        '
        'Button_nuevo
        '
        Me.Button_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_nuevo.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.Button_nuevo.Location = New System.Drawing.Point(13, 13)
        Me.Button_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_nuevo.Name = "Button_nuevo"
        Me.Button_nuevo.Size = New System.Drawing.Size(105, 49)
        Me.Button_nuevo.TabIndex = 270
        Me.Button_nuevo.Text = "Nuevo"
        Me.Button_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_nuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Busqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(934, 72)
        Me.GroupBox2.TabIndex = 274
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por Nº presupuesto /  Razon Social / Fecha:"
        '
        'Busqueda
        '
        Me.Busqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.Location = New System.Drawing.Point(16, 26)
        Me.Busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(893, 26)
        Me.Busqueda.TabIndex = 241
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 350)
        Me.GroupBox1.TabIndex = 275
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Presupuestos generados:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.PresupuestoidDataGridViewTextBoxColumn, Me.FantasiaDataGridViewTextBoxColumn, Me.CtaCteidDataGridViewTextBoxColumn, Me.VentaprodtotalDataGridViewTextBoxColumn, Me.PresupuestofechaDataGridViewTextBoxColumn, Me.PresupuestoestadoDataGridViewTextBoxColumn, Me.VentaprodidDataGridViewTextBoxColumn, Me.CLIidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PresupuestoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 22)
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
        Me.DataGridView1.Size = New System.Drawing.Size(893, 318)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 11
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DS_presupuesto_vta
        '
        'DS_presupuesto_vta
        '
        Me.DS_presupuesto_vta.DataSetName = "DS_presupuesto_vta"
        Me.DS_presupuesto_vta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 30
        '
        'PresupuestoidDataGridViewTextBoxColumn
        '
        Me.PresupuestoidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PresupuestoidDataGridViewTextBoxColumn.DataPropertyName = "presupuesto_id"
        Me.PresupuestoidDataGridViewTextBoxColumn.HeaderText = "Nº Presupuesto"
        Me.PresupuestoidDataGridViewTextBoxColumn.Name = "PresupuestoidDataGridViewTextBoxColumn"
        Me.PresupuestoidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FantasiaDataGridViewTextBoxColumn
        '
        Me.FantasiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FantasiaDataGridViewTextBoxColumn.DataPropertyName = "Fantasia"
        Me.FantasiaDataGridViewTextBoxColumn.HeaderText = "Fantasía o Razon Social"
        Me.FantasiaDataGridViewTextBoxColumn.Name = "FantasiaDataGridViewTextBoxColumn"
        Me.FantasiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CtaCteidDataGridViewTextBoxColumn
        '
        Me.CtaCteidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CtaCteidDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_id"
        Me.CtaCteidDataGridViewTextBoxColumn.HeaderText = "Nº Cta.Cte."
        Me.CtaCteidDataGridViewTextBoxColumn.Name = "CtaCteidDataGridViewTextBoxColumn"
        Me.CtaCteidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtaCteidDataGridViewTextBoxColumn.Visible = False
        '
        'VentaprodtotalDataGridViewTextBoxColumn
        '
        Me.VentaprodtotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VentaprodtotalDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_total"
        Me.VentaprodtotalDataGridViewTextBoxColumn.HeaderText = "Total ($)"
        Me.VentaprodtotalDataGridViewTextBoxColumn.Name = "VentaprodtotalDataGridViewTextBoxColumn"
        Me.VentaprodtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PresupuestofechaDataGridViewTextBoxColumn
        '
        Me.PresupuestofechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PresupuestofechaDataGridViewTextBoxColumn.DataPropertyName = "presupuesto_fecha"
        Me.PresupuestofechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.PresupuestofechaDataGridViewTextBoxColumn.Name = "PresupuestofechaDataGridViewTextBoxColumn"
        Me.PresupuestofechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PresupuestoestadoDataGridViewTextBoxColumn
        '
        Me.PresupuestoestadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PresupuestoestadoDataGridViewTextBoxColumn.DataPropertyName = "presupuesto_estado"
        Me.PresupuestoestadoDataGridViewTextBoxColumn.HeaderText = "presupuesto_estado"
        Me.PresupuestoestadoDataGridViewTextBoxColumn.Name = "PresupuestoestadoDataGridViewTextBoxColumn"
        Me.PresupuestoestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PresupuestoestadoDataGridViewTextBoxColumn.Visible = False
        '
        'VentaprodidDataGridViewTextBoxColumn
        '
        Me.VentaprodidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VentaprodidDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.HeaderText = "ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.Name = "VentaprodidDataGridViewTextBoxColumn"
        Me.VentaprodidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodidDataGridViewTextBoxColumn.Visible = False
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'Presupuesto_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(955, 509)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button_editar)
        Me.Controls.Add(Me.Button_imprimir)
        Me.Controls.Add(Me.Button_nuevo)
        Me.MinimumSize = New System.Drawing.Size(971, 548)
        Me.Name = "Presupuesto_venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_presupuesto_vta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button_editar As System.Windows.Forms.Button
    Friend WithEvents Button_imprimir As System.Windows.Forms.Button
    Friend WithEvents Button_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_presupuesto_vta As Aplicacion.DS_presupuesto_vta
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PresupuestoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FantasiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCteidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PresupuestofechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PresupuestoestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
