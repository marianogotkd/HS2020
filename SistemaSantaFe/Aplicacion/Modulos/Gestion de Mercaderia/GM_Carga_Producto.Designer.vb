<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GM_Carga_Producto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_codint = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_desc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_origen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_destino = New System.Windows.Forms.TextBox()
        Me.lbl_destino = New System.Windows.Forms.Label()
        Me.tb_cant_Or = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_cant_dest = New System.Windows.Forms.TextBox()
        Me.lbl_cant_dest = New System.Windows.Forms.Label()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.tb_Cant_Movi = New System.Windows.Forms.TextBox()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_transferir = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Interno:"
        '
        'tb_codint
        '
        Me.tb_codint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_codint.Location = New System.Drawing.Point(133, 25)
        Me.tb_codint.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_codint.MaximumSize = New System.Drawing.Size(284, 22)
        Me.tb_codint.MinimumSize = New System.Drawing.Size(284, 22)
        Me.tb_codint.Name = "tb_codint"
        Me.tb_codint.Size = New System.Drawing.Size(284, 22)
        Me.tb_codint.TabIndex = 0
        Me.tb_codint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tb_codint, "Ingrese codigo para buscar")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 320)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 2
        '
        'tb_desc
        '
        Me.tb_desc.BackColor = System.Drawing.Color.White
        Me.tb_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_desc.Location = New System.Drawing.Point(133, 54)
        Me.tb_desc.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.ReadOnly = True
        Me.tb_desc.Size = New System.Drawing.Size(284, 22)
        Me.tb_desc.TabIndex = 1
        Me.tb_desc.TabStop = False
        Me.tb_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción:"
        '
        'tb_origen
        '
        Me.tb_origen.BackColor = System.Drawing.Color.White
        Me.tb_origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_origen.Location = New System.Drawing.Point(123, 23)
        Me.tb_origen.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_origen.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_origen.MinimumSize = New System.Drawing.Size(250, 22)
        Me.tb_origen.Name = "tb_origen"
        Me.tb_origen.ReadOnly = True
        Me.tb_origen.Size = New System.Drawing.Size(250, 22)
        Me.tb_origen.TabIndex = 0
        Me.tb_origen.TabStop = False
        Me.tb_origen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre:"
        '
        'tb_destino
        '
        Me.tb_destino.BackColor = System.Drawing.Color.White
        Me.tb_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_destino.Location = New System.Drawing.Point(119, 25)
        Me.tb_destino.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_destino.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_destino.MinimumSize = New System.Drawing.Size(250, 22)
        Me.tb_destino.Name = "tb_destino"
        Me.tb_destino.ReadOnly = True
        Me.tb_destino.Size = New System.Drawing.Size(250, 22)
        Me.tb_destino.TabIndex = 0
        Me.tb_destino.TabStop = False
        Me.tb_destino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_destino
        '
        Me.lbl_destino.AutoSize = True
        Me.lbl_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_destino.Location = New System.Drawing.Point(17, 28)
        Me.lbl_destino.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_destino.Name = "lbl_destino"
        Me.lbl_destino.Size = New System.Drawing.Size(62, 17)
        Me.lbl_destino.TabIndex = 7
        Me.lbl_destino.Text = "Nombre:"
        '
        'tb_cant_Or
        '
        Me.tb_cant_Or.BackColor = System.Drawing.Color.White
        Me.tb_cant_Or.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cant_Or.Location = New System.Drawing.Point(123, 54)
        Me.tb_cant_Or.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_cant_Or.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_cant_Or.MinimumSize = New System.Drawing.Size(250, 22)
        Me.tb_cant_Or.Name = "tb_cant_Or"
        Me.tb_cant_Or.ReadOnly = True
        Me.tb_cant_Or.Size = New System.Drawing.Size(250, 22)
        Me.tb_cant_Or.TabIndex = 1
        Me.tb_cant_Or.TabStop = False
        Me.tb_cant_Or.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 57)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cantidad:"
        '
        'tb_cant_dest
        '
        Me.tb_cant_dest.BackColor = System.Drawing.Color.White
        Me.tb_cant_dest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cant_dest.Location = New System.Drawing.Point(119, 54)
        Me.tb_cant_dest.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_cant_dest.MaximumSize = New System.Drawing.Size(250, 22)
        Me.tb_cant_dest.MinimumSize = New System.Drawing.Size(250, 22)
        Me.tb_cant_dest.Name = "tb_cant_dest"
        Me.tb_cant_dest.ReadOnly = True
        Me.tb_cant_dest.Size = New System.Drawing.Size(250, 22)
        Me.tb_cant_dest.TabIndex = 1
        Me.tb_cant_dest.TabStop = False
        Me.tb_cant_dest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_cant_dest
        '
        Me.lbl_cant_dest.AutoSize = True
        Me.lbl_cant_dest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant_dest.Location = New System.Drawing.Point(17, 57)
        Me.lbl_cant_dest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cant_dest.Name = "lbl_cant_dest"
        Me.lbl_cant_dest.Size = New System.Drawing.Size(68, 17)
        Me.lbl_cant_dest.TabIndex = 11
        Me.lbl_cant_dest.Text = "Cantidad:"
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant.Location = New System.Drawing.Point(219, 12)
        Me.lbl_cant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(216, 25)
        Me.lbl_cant.TabIndex = 13
        Me.lbl_cant.Text = "Cantidad a Transferir"
        '
        'tb_Cant_Movi
        '
        Me.tb_Cant_Movi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Cant_Movi.Location = New System.Drawing.Point(439, 7)
        Me.tb_Cant_Movi.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Cant_Movi.MaximumSize = New System.Drawing.Size(90, 30)
        Me.tb_Cant_Movi.MinimumSize = New System.Drawing.Size(90, 30)
        Me.tb_Cant_Movi.Name = "tb_Cant_Movi"
        Me.tb_Cant_Movi.Size = New System.Drawing.Size(90, 30)
        Me.tb_Cant_Movi.TabIndex = 0
        Me.tb_Cant_Movi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Aplicacion.My.Resources.Resources.GuardarChico
        Me.btn_Agregar.Location = New System.Drawing.Point(547, 5)
        Me.btn_Agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Agregar.MaximumSize = New System.Drawing.Size(131, 33)
        Me.btn_Agregar.MinimumSize = New System.Drawing.Size(131, 33)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(131, 33)
        Me.btn_Agregar.TabIndex = 1
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btn_Agregar, "Agregar producto al listado")
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tb_codint)
        Me.GroupBox1.Controls.Add(Me.tb_desc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(764, 98)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(764, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 98)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese codigo interno para buscar (F1 busqueda avanzada)"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btn_Agregar)
        Me.Panel1.Controls.Add(Me.tb_Cant_Movi)
        Me.Panel1.Controls.Add(Me.lbl_cant)
        Me.Panel1.Controls.Add(Me.ShapeContainer3)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(12, 213)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 42)
        Me.Panel1.TabIndex = 17
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_transferir})
        Me.ShapeContainer3.Size = New System.Drawing.Size(682, 42)
        Me.ShapeContainer3.TabIndex = 14
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape_transferir
        '
        Me.RectangleShape_transferir.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape_transferir.BorderWidth = 2
        Me.RectangleShape_transferir.Location = New System.Drawing.Point(436, 5)
        Me.RectangleShape_transferir.Name = "RectangleShape_transferir"
        Me.RectangleShape_transferir.Size = New System.Drawing.Size(96, 35)
        Me.RectangleShape_transferir.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tb_origen)
        Me.GroupBox2.Controls.Add(Me.tb_cant_Or)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox2.MaximumSize = New System.Drawing.Size(380, 98)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(380, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 98)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sucursal de origen"
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.lbl_destino)
        Me.GroupBox3.Controls.Add(Me.tb_cant_dest)
        Me.GroupBox3.Controls.Add(Me.tb_destino)
        Me.GroupBox3.Controls.Add(Me.lbl_cant_dest)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(400, 107)
        Me.GroupBox3.MaximumSize = New System.Drawing.Size(376, 98)
        Me.GroupBox3.MinimumSize = New System.Drawing.Size(376, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(376, 98)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sucursal de destino"
        '
        'GM_Carga_Producto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(794, 265)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 300)
        Me.MinimumSize = New System.Drawing.Size(800, 300)
        Me.Name = "GM_Carga_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Productos . Gestión de Mercaderia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_codint As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_desc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_origen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_destino As System.Windows.Forms.TextBox
    Friend WithEvents lbl_destino As System.Windows.Forms.Label
    Friend WithEvents tb_cant_Or As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_cant_dest As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cant_dest As System.Windows.Forms.Label
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents tb_Cant_Movi As System.Windows.Forms.TextBox
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RectangleShape_transferir As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
