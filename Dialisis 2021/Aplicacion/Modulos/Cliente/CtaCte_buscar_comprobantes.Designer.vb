<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtaCte_buscar_comprobantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtaCte_buscar_comprobantes))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lb_ctacte_nro = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnaEditar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FacturaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturafechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FantasiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCteidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComprobantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtaCte_ds = New Aplicacion.CtaCte_ds()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Busqueda = New System.Windows.Forms.TextBox()
        Me.Button_imprimir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ReciboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.busqueda_recibo = New System.Windows.Forms.TextBox()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReciboidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecibofechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontototalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLI_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprobantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtaCte_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReciboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_ctacte_nro
        '
        Me.lb_ctacte_nro.AutoSize = True
        Me.lb_ctacte_nro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ctacte_nro.Location = New System.Drawing.Point(12, 9)
        Me.lb_ctacte_nro.Name = "lb_ctacte_nro"
        Me.lb_ctacte_nro.Size = New System.Drawing.Size(184, 20)
        Me.lb_ctacte_nro.TabIndex = 0
        Me.lb_ctacte_nro.Text = "Nº Cuenta Corriente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 325)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado disponible:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaEditar, Me.FacturaidDataGridViewTextBoxColumn, Me.FacturafechaDataGridViewTextBoxColumn, Me.VentaprodidDataGridViewTextBoxColumn, Me.FantasiaDataGridViewTextBoxColumn, Me.CLIidDataGridViewTextBoxColumn, Me.CtaCteidDataGridViewTextBoxColumn, Me.VentaprodtotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ComprobantesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 22)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(648, 277)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 12
        '
        'ColumnaEditar
        '
        Me.ColumnaEditar.HeaderText = ""
        Me.ColumnaEditar.Name = "ColumnaEditar"
        Me.ColumnaEditar.ReadOnly = True
        Me.ColumnaEditar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColumnaEditar.Width = 50
        '
        'FacturaidDataGridViewTextBoxColumn
        '
        Me.FacturaidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FacturaidDataGridViewTextBoxColumn.DataPropertyName = "factura_id"
        Me.FacturaidDataGridViewTextBoxColumn.HeaderText = "Comprobante"
        Me.FacturaidDataGridViewTextBoxColumn.Name = "FacturaidDataGridViewTextBoxColumn"
        Me.FacturaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturafechaDataGridViewTextBoxColumn
        '
        Me.FacturafechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FacturafechaDataGridViewTextBoxColumn.DataPropertyName = "factura_fecha"
        Me.FacturafechaDataGridViewTextBoxColumn.HeaderText = "Fecha de emisión"
        Me.FacturafechaDataGridViewTextBoxColumn.Name = "FacturafechaDataGridViewTextBoxColumn"
        Me.FacturafechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VentaprodidDataGridViewTextBoxColumn
        '
        Me.VentaprodidDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.HeaderText = "ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.Name = "VentaprodidDataGridViewTextBoxColumn"
        Me.VentaprodidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodidDataGridViewTextBoxColumn.Visible = False
        '
        'FantasiaDataGridViewTextBoxColumn
        '
        Me.FantasiaDataGridViewTextBoxColumn.DataPropertyName = "Fantasia"
        Me.FantasiaDataGridViewTextBoxColumn.HeaderText = "Fantasia"
        Me.FantasiaDataGridViewTextBoxColumn.Name = "FantasiaDataGridViewTextBoxColumn"
        Me.FantasiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FantasiaDataGridViewTextBoxColumn.Visible = False
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'CtaCteidDataGridViewTextBoxColumn
        '
        Me.CtaCteidDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_id"
        Me.CtaCteidDataGridViewTextBoxColumn.HeaderText = "CtaCte_id"
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
        'ComprobantesBindingSource
        '
        Me.ComprobantesBindingSource.DataMember = "Comprobantes"
        Me.ComprobantesBindingSource.DataSource = Me.CtaCte_ds
        '
        'CtaCte_ds
        '
        Me.CtaCte_ds.DataSetName = "CtaCte_ds"
        Me.CtaCte_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Busqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(663, 55)
        Me.GroupBox2.TabIndex = 250
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por Nº de comprobante:"
        '
        'Busqueda
        '
        Me.Busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.Location = New System.Drawing.Point(7, 22)
        Me.Busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(648, 23)
        Me.Busqueda.TabIndex = 241
        '
        'Button_imprimir
        '
        Me.Button_imprimir.Image = CType(resources.GetObject("Button_imprimir.Image"), System.Drawing.Image)
        Me.Button_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_imprimir.Location = New System.Drawing.Point(19, 414)
        Me.Button_imprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_imprimir.Name = "Button_imprimir"
        Me.Button_imprimir.Size = New System.Drawing.Size(50, 44)
        Me.Button_imprimir.TabIndex = 251
        Me.Button_imprimir.TabStop = False
        Me.Button_imprimir.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(705, 505)
        Me.TabControl1.TabIndex = 252
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Button_imprimir)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(697, 476)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Facturación"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(697, 476)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Recibos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(19, 414)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 44)
        Me.Button1.TabIndex = 253
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 82)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(663, 325)
        Me.GroupBox4.TabIndex = 252
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Listado disponible:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.ReciboidDataGridViewTextBoxColumn, Me.RecibofechaDataGridViewTextBoxColumn, Me.MontototalDataGridViewTextBoxColumn, Me.CLI_id})
        Me.DataGridView2.DataSource = Me.ReciboBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(7, 22)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(648, 277)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 12
        '
        'ReciboBindingSource
        '
        Me.ReciboBindingSource.DataMember = "Recibo"
        Me.ReciboBindingSource.DataSource = Me.CtaCte_ds
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.busqueda_recibo)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(663, 55)
        Me.GroupBox3.TabIndex = 251
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar por Nº de Recibo:"
        '
        'busqueda_recibo
        '
        Me.busqueda_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busqueda_recibo.Location = New System.Drawing.Point(7, 22)
        Me.busqueda_recibo.Margin = New System.Windows.Forms.Padding(4)
        Me.busqueda_recibo.Name = "busqueda_recibo"
        Me.busqueda_recibo.Size = New System.Drawing.Size(648, 23)
        Me.busqueda_recibo.TabIndex = 241
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'ReciboidDataGridViewTextBoxColumn
        '
        Me.ReciboidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReciboidDataGridViewTextBoxColumn.DataPropertyName = "recibo_id"
        Me.ReciboidDataGridViewTextBoxColumn.HeaderText = "Recibo"
        Me.ReciboidDataGridViewTextBoxColumn.Name = "ReciboidDataGridViewTextBoxColumn"
        Me.ReciboidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecibofechaDataGridViewTextBoxColumn
        '
        Me.RecibofechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RecibofechaDataGridViewTextBoxColumn.DataPropertyName = "recibo_fecha"
        Me.RecibofechaDataGridViewTextBoxColumn.HeaderText = "Fecha de emisión"
        Me.RecibofechaDataGridViewTextBoxColumn.Name = "RecibofechaDataGridViewTextBoxColumn"
        Me.RecibofechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontototalDataGridViewTextBoxColumn
        '
        Me.MontototalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MontototalDataGridViewTextBoxColumn.DataPropertyName = "monto_total"
        Me.MontototalDataGridViewTextBoxColumn.HeaderText = "Total ($)"
        Me.MontototalDataGridViewTextBoxColumn.Name = "MontototalDataGridViewTextBoxColumn"
        Me.MontototalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLI_id
        '
        Me.CLI_id.DataPropertyName = "CLI_id"
        Me.CLI_id.HeaderText = "CLI_id"
        Me.CLI_id.Name = "CLI_id"
        Me.CLI_id.ReadOnly = True
        Me.CLI_id.Visible = False
        '
        'CtaCte_buscar_comprobantes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 556)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lb_ctacte_nro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(699, 518)
        Me.Name = "CtaCte_buscar_comprobantes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobantes emitidos - imprimir"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprobantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtaCte_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReciboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_ctacte_nro As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComprobantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtaCte_ds As Aplicacion.CtaCte_ds
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Button_imprimir As System.Windows.Forms.Button
    Friend WithEvents ColumnaEditar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FacturaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacturafechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FantasiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCteidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents busqueda_recibo As System.Windows.Forms.TextBox
    Friend WithEvents ReciboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReciboidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecibofechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontototalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLI_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
