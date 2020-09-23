<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja_consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caja_consulta))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_Terminales = New System.Windows.Forms.ComboBox()
        Me.Button_siguiente = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DG_caja = New System.Windows.Forms.DataGridView()
        Me.CajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_consulta_ds = New Aplicacion.Venta_consulta_ds()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker_caja_hasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_caja_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label_suc_2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Caja_ds = New Aplicacion.Caja_ds()
        Me.CajaconsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caja_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaaperturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAcierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAmontoinicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAmontoingresosefectivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAmontoegresosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAmontoingresostarjetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAmontonetoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_consulta_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1134, 673)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Button_siguiente)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Label_suc_2)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1126, 644)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Caja"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Terminales)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 34)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1105, 66)
        Me.GroupBox2.TabIndex = 258
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccionar Terminal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 257
        Me.Label4.Text = "Terminal:"
        '
        'ComboBox_Terminales
        '
        Me.ComboBox_Terminales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Terminales.FormattingEnabled = True
        Me.ComboBox_Terminales.Location = New System.Drawing.Point(83, 23)
        Me.ComboBox_Terminales.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_Terminales.Name = "ComboBox_Terminales"
        Me.ComboBox_Terminales.Size = New System.Drawing.Size(340, 24)
        Me.ComboBox_Terminales.TabIndex = 255
        '
        'Button_siguiente
        '
        Me.Button_siguiente.Image = Global.Aplicacion.My.Resources.Resources.Informe
        Me.Button_siguiente.Location = New System.Drawing.Point(965, 590)
        Me.Button_siguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_siguiente.Name = "Button_siguiente"
        Me.Button_siguiente.Size = New System.Drawing.Size(149, 46)
        Me.Button_siguiente.TabIndex = 256
        Me.Button_siguiente.Text = "Ver detalle"
        Me.Button_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_siguiente.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DG_caja)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 195)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1106, 387)
        Me.GroupBox4.TabIndex = 254
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Estado de CAJA desde 00/00/0000 hasta 00/00/0000"
        '
        'DG_caja
        '
        Me.DG_caja.AllowUserToAddRows = False
        Me.DG_caja.AllowUserToDeleteRows = False
        Me.DG_caja.AllowUserToResizeRows = False
        Me.DG_caja.AutoGenerateColumns = False
        Me.DG_caja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_caja.BackgroundColor = System.Drawing.Color.White
        Me.DG_caja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_caja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Caja_id, Me.Usuario_nombre, Me.CajaaperturaDataGridViewTextBoxColumn, Me.CAJAcierreDataGridViewTextBoxColumn, Me.CAJAmontoinicialDataGridViewTextBoxColumn, Me.CAJAmontoingresosefectivoDataGridViewTextBoxColumn, Me.CAJAmontoegresosDataGridViewTextBoxColumn, Me.CAJAmontoingresostarjetaDataGridViewTextBoxColumn, Me.CAJAmontonetoDataGridViewTextBoxColumn})
        Me.DG_caja.DataSource = Me.CajaBindingSource
        Me.DG_caja.Location = New System.Drawing.Point(9, 24)
        Me.DG_caja.Margin = New System.Windows.Forms.Padding(5)
        Me.DG_caja.MultiSelect = False
        Me.DG_caja.Name = "DG_caja"
        Me.DG_caja.ReadOnly = True
        Me.DG_caja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_caja.RowHeadersVisible = False
        Me.DG_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_caja.Size = New System.Drawing.Size(1088, 354)
        Me.DG_caja.TabIndex = 240
        '
        'CajaBindingSource
        '
        Me.CajaBindingSource.DataMember = "Caja"
        Me.CajaBindingSource.DataSource = Me.Venta_consulta_ds
        '
        'Venta_consulta_ds
        '
        Me.Venta_consulta_ds.DataSetName = "Venta_consulta_ds"
        Me.Venta_consulta_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_caja_hasta)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_caja_desde)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 108)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1106, 79)
        Me.GroupBox3.TabIndex = 253
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione rango de fechas:"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1007, 21)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 46)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(555, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha hasta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha desde:"
        '
        'DateTimePicker_caja_hasta
        '
        Me.DateTimePicker_caja_hasta.Location = New System.Drawing.Point(675, 33)
        Me.DateTimePicker_caja_hasta.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_caja_hasta.Name = "DateTimePicker_caja_hasta"
        Me.DateTimePicker_caja_hasta.Size = New System.Drawing.Size(321, 22)
        Me.DateTimePicker_caja_hasta.TabIndex = 1
        '
        'DateTimePicker_caja_desde
        '
        Me.DateTimePicker_caja_desde.Location = New System.Drawing.Point(141, 33)
        Me.DateTimePicker_caja_desde.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_caja_desde.Name = "DateTimePicker_caja_desde"
        Me.DateTimePicker_caja_desde.Size = New System.Drawing.Size(321, 22)
        Me.DateTimePicker_caja_desde.TabIndex = 0
        '
        'Label_suc_2
        '
        Me.Label_suc_2.AutoSize = True
        Me.Label_suc_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_suc_2.ForeColor = System.Drawing.Color.Blue
        Me.Label_suc_2.Location = New System.Drawing.Point(181, 5)
        Me.Label_suc_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_suc_2.Name = "Label_suc_2"
        Me.Label_suc_2.Size = New System.Drawing.Size(79, 20)
        Me.Label_suc_2.TabIndex = 252
        Me.Label_suc_2.Text = "              "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 5)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 251
        Me.Label6.Text = "Sucursal:"
        '
        'Caja_ds
        '
        Me.Caja_ds.DataSetName = "Caja_ds"
        Me.Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CajaconsultaBindingSource
        '
        Me.CajaconsultaBindingSource.DataMember = "Caja_consulta"
        Me.CajaconsultaBindingSource.DataSource = Me.Caja_ds
        '
        'Caja_id
        '
        Me.Caja_id.DataPropertyName = "Caja_id"
        Me.Caja_id.HeaderText = "Caja_id"
        Me.Caja_id.Name = "Caja_id"
        Me.Caja_id.ReadOnly = True
        '
        'Usuario_nombre
        '
        Me.Usuario_nombre.DataPropertyName = "Usuario_nombre"
        Me.Usuario_nombre.HeaderText = "Usuario"
        Me.Usuario_nombre.Name = "Usuario_nombre"
        Me.Usuario_nombre.ReadOnly = True
        Me.Usuario_nombre.Visible = False
        '
        'CajaaperturaDataGridViewTextBoxColumn
        '
        Me.CajaaperturaDataGridViewTextBoxColumn.DataPropertyName = "caja_apertura"
        Me.CajaaperturaDataGridViewTextBoxColumn.HeaderText = "Fecha de Apertura"
        Me.CajaaperturaDataGridViewTextBoxColumn.Name = "CajaaperturaDataGridViewTextBoxColumn"
        Me.CajaaperturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAcierreDataGridViewTextBoxColumn
        '
        Me.CAJAcierreDataGridViewTextBoxColumn.DataPropertyName = "CAJA_cierre"
        Me.CAJAcierreDataGridViewTextBoxColumn.HeaderText = "Fecha de Cierre"
        Me.CAJAcierreDataGridViewTextBoxColumn.Name = "CAJAcierreDataGridViewTextBoxColumn"
        Me.CAJAcierreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAmontoinicialDataGridViewTextBoxColumn
        '
        Me.CAJAmontoinicialDataGridViewTextBoxColumn.DataPropertyName = "CAJA_montoinicial"
        Me.CAJAmontoinicialDataGridViewTextBoxColumn.HeaderText = "Monto Inicial"
        Me.CAJAmontoinicialDataGridViewTextBoxColumn.Name = "CAJAmontoinicialDataGridViewTextBoxColumn"
        Me.CAJAmontoinicialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAmontoingresosefectivoDataGridViewTextBoxColumn
        '
        Me.CAJAmontoingresosefectivoDataGridViewTextBoxColumn.DataPropertyName = "CAJA_montoingresosefectivo"
        Me.CAJAmontoingresosefectivoDataGridViewTextBoxColumn.HeaderText = "Total Efectivo"
        Me.CAJAmontoingresosefectivoDataGridViewTextBoxColumn.Name = "CAJAmontoingresosefectivoDataGridViewTextBoxColumn"
        Me.CAJAmontoingresosefectivoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAmontoegresosDataGridViewTextBoxColumn
        '
        Me.CAJAmontoegresosDataGridViewTextBoxColumn.DataPropertyName = "CAJA_montoegresos"
        Me.CAJAmontoegresosDataGridViewTextBoxColumn.HeaderText = "Total Egresos"
        Me.CAJAmontoegresosDataGridViewTextBoxColumn.Name = "CAJAmontoegresosDataGridViewTextBoxColumn"
        Me.CAJAmontoegresosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAmontoingresostarjetaDataGridViewTextBoxColumn
        '
        Me.CAJAmontoingresostarjetaDataGridViewTextBoxColumn.DataPropertyName = "CAJA_montoingresostarjeta"
        Me.CAJAmontoingresostarjetaDataGridViewTextBoxColumn.HeaderText = "Total Tarjetas"
        Me.CAJAmontoingresostarjetaDataGridViewTextBoxColumn.Name = "CAJAmontoingresostarjetaDataGridViewTextBoxColumn"
        Me.CAJAmontoingresostarjetaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAmontonetoDataGridViewTextBoxColumn
        '
        Me.CAJAmontonetoDataGridViewTextBoxColumn.DataPropertyName = "CAJA_montoneto"
        Me.CAJAmontonetoDataGridViewTextBoxColumn.HeaderText = "Total Neto"
        Me.CAJAmontonetoDataGridViewTextBoxColumn.Name = "CAJAmontonetoDataGridViewTextBoxColumn"
        Me.CAJAmontonetoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Caja_consulta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1170, 707)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1176, 742)
        Me.MinimumSize = New System.Drawing.Size(1176, 726)
        Me.Name = "Caja_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cajas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_consulta_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaconsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Caja_ds As Aplicacion.Caja_ds
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_caja As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_caja_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_caja_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_suc_2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button_siguiente As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Terminales As System.Windows.Forms.ComboBox
    Friend WithEvents CajaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Venta_consulta_ds As Aplicacion.Venta_consulta_ds
    Friend WithEvents CajaconsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caja_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaaperturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAcierreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAmontoinicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAmontoingresosefectivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAmontoegresosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAmontoingresostarjetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAmontonetoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
