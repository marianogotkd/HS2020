<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class US_administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(US_administrador))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Separator_Arriba = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Paciente = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MenuItem_PAC_nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_PAC_Act = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_PAC_HC = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_paciente = New System.Windows.Forms.ToolStripLabel()
        Me.Separator_Paciente = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Enfermeria = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MenuItem_ENF_NSD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_ENF_Informe = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_ENF_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_ENF_RegMov = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_ENF_stock = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsumosPredefinidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_Enfermeria = New System.Windows.Forms.ToolStripLabel()
        Me.Separator_Enfermeria = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Medico = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem_servicio_nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_MEDICO_nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_MEDICO_consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_Medicos = New System.Windows.Forms.ToolStripLabel()
        Me.Separator_Medico = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_ObraSocial = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MenuItem_OBRA_nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_OBRA_actualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_OBRA_informe = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_ObraSocial = New System.Windows.Forms.ToolStripLabel()
        Me.Separator_ObraSocial = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Deposito = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MenuItem_DEP_ingreso = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_DEP_Mov = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_DEP_baja = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_DEP_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeAltasporFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeAltassoloInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeMovimientossoloInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeBajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeBajassoloInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_deposito = New System.Windows.Forms.ToolStripLabel()
        Me.Separator_deposito = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_stock = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaNuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Stock_Prov = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorAgregar_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorModificar_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Stock_Insumos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoNuevoNEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Stock_marca = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Stock_Categoria = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Stock_consumir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Stock_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeAjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_stock = New System.Windows.Forms.ToolStripLabel()
        Me.Separator_stock = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolS_Configuracion = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionYRemuneracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CONF_usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CONF_Sucursales = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CONF_empresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorNuevoToolStripMenuitem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalNuevoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalModificarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CONF_turnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_Configuraciones = New System.Windows.Forms.ToolStripLabel()
        Me.Separator_Conf = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton6 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VentaEnCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaEnMesas2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMesasNEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton8 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Caja_ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TurnoGestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoComunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoComunNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoComunEliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoFijoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoFijoNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoFijoActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoConfigurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailConfigurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailDestinoConfigurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SonidoAlarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton7 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecepciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator_Abajo = New System.Windows.Forms.ToolStripSeparator()
        Me.PN_Entrada = New System.Windows.Forms.Panel()
        Me.BO_Caja = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BO_TurnoConsulta = New System.Windows.Forms.Button()
        Me.Btn_corte_caja = New System.Windows.Forms.Button()
        Me.BO_USU_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BO_USU_contrasena = New System.Windows.Forms.Button()
        Me.BO_USU_sesion = New System.Windows.Forms.Button()
        Me.LB_UT_dep = New System.Windows.Forms.Label()
        Me.LB_USU_ape = New System.Windows.Forms.Label()
        Me.Label_Suc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Terminal = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.IngresDeMercaderiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeConsumosporConceptoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeConsumosporInsumoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Separator_Arriba, Me.Tool_Paciente, Me.Label_paciente, Me.Separator_Paciente, Me.Tool_Enfermeria, Me.Label_Enfermeria, Me.Separator_Enfermeria, Me.Tool_Medico, Me.Label_Medicos, Me.Separator_Medico, Me.Tool_ObraSocial, Me.Label_ObraSocial, Me.Separator_ObraSocial, Me.Tool_Deposito, Me.Label_deposito, Me.Separator_deposito, Me.Tool_stock, Me.Label_stock, Me.Separator_stock, Me.ToolS_Configuracion, Me.Label_Configuraciones, Me.Separator_Conf, Me.ToolStripDropDownButton6, Me.ToolStripDropDownButton8, Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton7, Me.Separator_Abajo})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(7, 65)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(95, 910)
        Me.ToolStrip1.TabIndex = 54
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Separator_Arriba
        '
        Me.Separator_Arriba.Name = "Separator_Arriba"
        Me.Separator_Arriba.Size = New System.Drawing.Size(93, 6)
        '
        'Tool_Paciente
        '
        Me.Tool_Paciente.AutoSize = False
        Me.Tool_Paciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Paciente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_PAC_nuevo, Me.MenuItem_PAC_Act, Me.MenuItem_PAC_HC})
        Me.Tool_Paciente.Image = Global.Aplicacion.My.Resources.Resources.paciente64x64
        Me.Tool_Paciente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tool_Paciente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Paciente.Name = "Tool_Paciente"
        Me.Tool_Paciente.Size = New System.Drawing.Size(80, 60)
        Me.Tool_Paciente.Text = "Pacientes"
        Me.Tool_Paciente.Visible = False
        '
        'MenuItem_PAC_nuevo
        '
        Me.MenuItem_PAC_nuevo.Name = "MenuItem_PAC_nuevo"
        Me.MenuItem_PAC_nuevo.Size = New System.Drawing.Size(174, 22)
        Me.MenuItem_PAC_nuevo.Text = "Nuevo Paciente"
        Me.MenuItem_PAC_nuevo.Visible = False
        '
        'MenuItem_PAC_Act
        '
        Me.MenuItem_PAC_Act.Name = "MenuItem_PAC_Act"
        Me.MenuItem_PAC_Act.Size = New System.Drawing.Size(174, 22)
        Me.MenuItem_PAC_Act.Text = "Actualizar Paciente"
        Me.MenuItem_PAC_Act.Visible = False
        '
        'MenuItem_PAC_HC
        '
        Me.MenuItem_PAC_HC.Name = "MenuItem_PAC_HC"
        Me.MenuItem_PAC_HC.Size = New System.Drawing.Size(174, 22)
        Me.MenuItem_PAC_HC.Text = "Historia Clínica"
        Me.MenuItem_PAC_HC.Visible = False
        '
        'Label_paciente
        '
        Me.Label_paciente.Name = "Label_paciente"
        Me.Label_paciente.Size = New System.Drawing.Size(93, 15)
        Me.Label_paciente.Text = "Pacientes"
        Me.Label_paciente.Visible = False
        '
        'Separator_Paciente
        '
        Me.Separator_Paciente.Name = "Separator_Paciente"
        Me.Separator_Paciente.Size = New System.Drawing.Size(93, 6)
        Me.Separator_Paciente.Visible = False
        '
        'Tool_Enfermeria
        '
        Me.Tool_Enfermeria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Enfermeria.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_ENF_NSD, Me.MenuItem_ENF_Informe, Me.MenuItem_ENF_Consulta, Me.MenuItem_ENF_RegMov, Me.MenuItem_ENF_stock, Me.InsumosPredefinidosToolStripMenuItem})
        Me.Tool_Enfermeria.Image = CType(resources.GetObject("Tool_Enfermeria.Image"), System.Drawing.Image)
        Me.Tool_Enfermeria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tool_Enfermeria.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Enfermeria.Name = "Tool_Enfermeria"
        Me.Tool_Enfermeria.Size = New System.Drawing.Size(93, 68)
        Me.Tool_Enfermeria.Text = "Enfermeria"
        Me.Tool_Enfermeria.Visible = False
        '
        'MenuItem_ENF_NSD
        '
        Me.MenuItem_ENF_NSD.Name = "MenuItem_ENF_NSD"
        Me.MenuItem_ENF_NSD.Size = New System.Drawing.Size(206, 22)
        Me.MenuItem_ENF_NSD.Text = "Nueva Sesion de Dialisis"
        Me.MenuItem_ENF_NSD.Visible = False
        '
        'MenuItem_ENF_Informe
        '
        Me.MenuItem_ENF_Informe.Name = "MenuItem_ENF_Informe"
        Me.MenuItem_ENF_Informe.Size = New System.Drawing.Size(206, 22)
        Me.MenuItem_ENF_Informe.Text = "Informe de Dialisis"
        Me.MenuItem_ENF_Informe.Visible = False
        '
        'MenuItem_ENF_Consulta
        '
        Me.MenuItem_ENF_Consulta.Name = "MenuItem_ENF_Consulta"
        Me.MenuItem_ENF_Consulta.Size = New System.Drawing.Size(206, 22)
        Me.MenuItem_ENF_Consulta.Text = "Consulta de Sesiones"
        Me.MenuItem_ENF_Consulta.Visible = False
        '
        'MenuItem_ENF_RegMov
        '
        Me.MenuItem_ENF_RegMov.Name = "MenuItem_ENF_RegMov"
        Me.MenuItem_ENF_RegMov.Size = New System.Drawing.Size(206, 22)
        Me.MenuItem_ENF_RegMov.Text = "Registro de Movimientos"
        Me.MenuItem_ENF_RegMov.Visible = False
        '
        'MenuItem_ENF_stock
        '
        Me.MenuItem_ENF_stock.Name = "MenuItem_ENF_stock"
        Me.MenuItem_ENF_stock.Size = New System.Drawing.Size(206, 22)
        Me.MenuItem_ENF_stock.Text = "Consulta de Stock"
        Me.MenuItem_ENF_stock.Visible = False
        '
        'InsumosPredefinidosToolStripMenuItem
        '
        Me.InsumosPredefinidosToolStripMenuItem.Name = "InsumosPredefinidosToolStripMenuItem"
        Me.InsumosPredefinidosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.InsumosPredefinidosToolStripMenuItem.Text = "Insumos Predefinidos"
        '
        'Label_Enfermeria
        '
        Me.Label_Enfermeria.Name = "Label_Enfermeria"
        Me.Label_Enfermeria.Size = New System.Drawing.Size(93, 15)
        Me.Label_Enfermeria.Text = "Enfermeria"
        Me.Label_Enfermeria.Visible = False
        '
        'Separator_Enfermeria
        '
        Me.Separator_Enfermeria.Name = "Separator_Enfermeria"
        Me.Separator_Enfermeria.Size = New System.Drawing.Size(93, 6)
        Me.Separator_Enfermeria.Visible = False
        '
        'Tool_Medico
        '
        Me.Tool_Medico.AutoSize = False
        Me.Tool_Medico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Medico.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_servicio_nuevo, Me.ToolStripMenuItem3, Me.MenuItem_MEDICO_nuevo, Me.MenuItem_MEDICO_consulta})
        Me.Tool_Medico.Image = Global.Aplicacion.My.Resources.Resources.medical_29_icon_icons_com_73943
        Me.Tool_Medico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tool_Medico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Medico.Name = "Tool_Medico"
        Me.Tool_Medico.Size = New System.Drawing.Size(80, 60)
        Me.Tool_Medico.Text = "Médicos"
        Me.Tool_Medico.Visible = False
        '
        'ToolStripMenuItem_servicio_nuevo
        '
        Me.ToolStripMenuItem_servicio_nuevo.Name = "ToolStripMenuItem_servicio_nuevo"
        Me.ToolStripMenuItem_servicio_nuevo.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem_servicio_nuevo.Text = "Nuevo Servicio"
        Me.ToolStripMenuItem_servicio_nuevo.Visible = False
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem3.Text = "Consultar Servicios"
        Me.ToolStripMenuItem3.Visible = False
        '
        'MenuItem_MEDICO_nuevo
        '
        Me.MenuItem_MEDICO_nuevo.Name = "MenuItem_MEDICO_nuevo"
        Me.MenuItem_MEDICO_nuevo.Size = New System.Drawing.Size(174, 22)
        Me.MenuItem_MEDICO_nuevo.Text = "Medico Nuevo"
        Me.MenuItem_MEDICO_nuevo.Visible = False
        '
        'MenuItem_MEDICO_consulta
        '
        Me.MenuItem_MEDICO_consulta.Name = "MenuItem_MEDICO_consulta"
        Me.MenuItem_MEDICO_consulta.Size = New System.Drawing.Size(174, 22)
        Me.MenuItem_MEDICO_consulta.Text = "Medicos Consulta"
        Me.MenuItem_MEDICO_consulta.Visible = False
        '
        'Label_Medicos
        '
        Me.Label_Medicos.Name = "Label_Medicos"
        Me.Label_Medicos.Size = New System.Drawing.Size(93, 15)
        Me.Label_Medicos.Text = "Médicos"
        Me.Label_Medicos.Visible = False
        '
        'Separator_Medico
        '
        Me.Separator_Medico.Name = "Separator_Medico"
        Me.Separator_Medico.Size = New System.Drawing.Size(93, 6)
        Me.Separator_Medico.Visible = False
        '
        'Tool_ObraSocial
        '
        Me.Tool_ObraSocial.AutoSize = False
        Me.Tool_ObraSocial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_ObraSocial.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_OBRA_nuevo, Me.MenuItem_OBRA_actualizar, Me.MenuItem_OBRA_informe})
        Me.Tool_ObraSocial.Image = CType(resources.GetObject("Tool_ObraSocial.Image"), System.Drawing.Image)
        Me.Tool_ObraSocial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tool_ObraSocial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_ObraSocial.Name = "Tool_ObraSocial"
        Me.Tool_ObraSocial.Size = New System.Drawing.Size(80, 60)
        Me.Tool_ObraSocial.Text = "Historia Clínica"
        Me.Tool_ObraSocial.Visible = False
        '
        'MenuItem_OBRA_nuevo
        '
        Me.MenuItem_OBRA_nuevo.Name = "MenuItem_OBRA_nuevo"
        Me.MenuItem_OBRA_nuevo.Size = New System.Drawing.Size(185, 22)
        Me.MenuItem_OBRA_nuevo.Text = "Nuevo"
        Me.MenuItem_OBRA_nuevo.Visible = False
        '
        'MenuItem_OBRA_actualizar
        '
        Me.MenuItem_OBRA_actualizar.Name = "MenuItem_OBRA_actualizar"
        Me.MenuItem_OBRA_actualizar.Size = New System.Drawing.Size(185, 22)
        Me.MenuItem_OBRA_actualizar.Text = "Actualizar"
        Me.MenuItem_OBRA_actualizar.Visible = False
        '
        'MenuItem_OBRA_informe
        '
        Me.MenuItem_OBRA_informe.Name = "MenuItem_OBRA_informe"
        Me.MenuItem_OBRA_informe.Size = New System.Drawing.Size(185, 22)
        Me.MenuItem_OBRA_informe.Text = "Informe de Pacientes"
        Me.MenuItem_OBRA_informe.Visible = False
        '
        'Label_ObraSocial
        '
        Me.Label_ObraSocial.Name = "Label_ObraSocial"
        Me.Label_ObraSocial.Size = New System.Drawing.Size(93, 15)
        Me.Label_ObraSocial.Text = "Obra Social"
        Me.Label_ObraSocial.Visible = False
        '
        'Separator_ObraSocial
        '
        Me.Separator_ObraSocial.Name = "Separator_ObraSocial"
        Me.Separator_ObraSocial.Size = New System.Drawing.Size(93, 6)
        Me.Separator_ObraSocial.Visible = False
        '
        'Tool_Deposito
        '
        Me.Tool_Deposito.AutoSize = False
        Me.Tool_Deposito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_Deposito.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_DEP_ingreso, Me.MenuItem_DEP_Mov, Me.MenuItem_DEP_baja, Me.MenuItem_DEP_Consulta})
        Me.Tool_Deposito.Image = CType(resources.GetObject("Tool_Deposito.Image"), System.Drawing.Image)
        Me.Tool_Deposito.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tool_Deposito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Deposito.Name = "Tool_Deposito"
        Me.Tool_Deposito.Size = New System.Drawing.Size(94, 68)
        Me.Tool_Deposito.Text = "Movimiento"
        Me.Tool_Deposito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Tool_Deposito.Visible = False
        '
        'MenuItem_DEP_ingreso
        '
        Me.MenuItem_DEP_ingreso.Name = "MenuItem_DEP_ingreso"
        Me.MenuItem_DEP_ingreso.Size = New System.Drawing.Size(187, 22)
        Me.MenuItem_DEP_ingreso.Text = "Ingreso de Stock"
        Me.MenuItem_DEP_ingreso.Visible = False
        '
        'MenuItem_DEP_Mov
        '
        Me.MenuItem_DEP_Mov.Name = "MenuItem_DEP_Mov"
        Me.MenuItem_DEP_Mov.Size = New System.Drawing.Size(187, 22)
        Me.MenuItem_DEP_Mov.Text = "Movimiento de Stock"
        Me.MenuItem_DEP_Mov.Visible = False
        '
        'MenuItem_DEP_baja
        '
        Me.MenuItem_DEP_baja.Name = "MenuItem_DEP_baja"
        Me.MenuItem_DEP_baja.Size = New System.Drawing.Size(187, 22)
        Me.MenuItem_DEP_baja.Text = "Baja de Stock"
        Me.MenuItem_DEP_baja.Visible = False
        '
        'MenuItem_DEP_Consulta
        '
        Me.MenuItem_DEP_Consulta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeAltasporFacturaToolStripMenuItem, Me.RegistroDeAltassoloInsumosToolStripMenuItem, Me.RegistroDeMovimientosToolStripMenuItem, Me.RegistroDeMovimientossoloInsumosToolStripMenuItem, Me.RegistroDeBajasToolStripMenuItem, Me.RegistroDeBajassoloInsumosToolStripMenuItem})
        Me.MenuItem_DEP_Consulta.Name = "MenuItem_DEP_Consulta"
        Me.MenuItem_DEP_Consulta.Size = New System.Drawing.Size(187, 22)
        Me.MenuItem_DEP_Consulta.Text = "Consultas"
        Me.MenuItem_DEP_Consulta.Visible = False
        '
        'RegistroDeAltasporFacturaToolStripMenuItem
        '
        Me.RegistroDeAltasporFacturaToolStripMenuItem.Name = "RegistroDeAltasporFacturaToolStripMenuItem"
        Me.RegistroDeAltasporFacturaToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.RegistroDeAltasporFacturaToolStripMenuItem.Text = "Registro de Altas (por factura)"
        '
        'RegistroDeAltassoloInsumosToolStripMenuItem
        '
        Me.RegistroDeAltassoloInsumosToolStripMenuItem.Name = "RegistroDeAltassoloInsumosToolStripMenuItem"
        Me.RegistroDeAltassoloInsumosToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.RegistroDeAltassoloInsumosToolStripMenuItem.Text = "Registro de Altas (solo insumos)"
        '
        'RegistroDeMovimientosToolStripMenuItem
        '
        Me.RegistroDeMovimientosToolStripMenuItem.Name = "RegistroDeMovimientosToolStripMenuItem"
        Me.RegistroDeMovimientosToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.RegistroDeMovimientosToolStripMenuItem.Text = "Registro de movimientos"
        '
        'RegistroDeMovimientossoloInsumosToolStripMenuItem
        '
        Me.RegistroDeMovimientossoloInsumosToolStripMenuItem.Name = "RegistroDeMovimientossoloInsumosToolStripMenuItem"
        Me.RegistroDeMovimientossoloInsumosToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.RegistroDeMovimientossoloInsumosToolStripMenuItem.Text = "Registro de movimientos (solo insumos)"
        '
        'RegistroDeBajasToolStripMenuItem
        '
        Me.RegistroDeBajasToolStripMenuItem.Name = "RegistroDeBajasToolStripMenuItem"
        Me.RegistroDeBajasToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.RegistroDeBajasToolStripMenuItem.Text = "Registro de bajas"
        '
        'RegistroDeBajassoloInsumosToolStripMenuItem
        '
        Me.RegistroDeBajassoloInsumosToolStripMenuItem.Name = "RegistroDeBajassoloInsumosToolStripMenuItem"
        Me.RegistroDeBajassoloInsumosToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.RegistroDeBajassoloInsumosToolStripMenuItem.Text = "Registro de bajas (solo insumos)"
        '
        'Label_deposito
        '
        Me.Label_deposito.Name = "Label_deposito"
        Me.Label_deposito.Size = New System.Drawing.Size(93, 15)
        Me.Label_deposito.Text = "Deposito y Mov."
        Me.Label_deposito.Visible = False
        '
        'Separator_deposito
        '
        Me.Separator_deposito.Name = "Separator_deposito"
        Me.Separator_deposito.Size = New System.Drawing.Size(93, 6)
        Me.Separator_deposito.Visible = False
        '
        'Tool_stock
        '
        Me.Tool_stock.AutoSize = False
        Me.Tool_stock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_stock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaToolStripMenuItem, Me.MenuItem_Stock_Prov, Me.MenuItem_Stock_Insumos, Me.MenuItem_Stock_marca, Me.MenuItem_Stock_Categoria, Me.MenuItem_Stock_consumir, Me.MenuItem_Stock_Consulta, Me.ConsultaDeAjustesToolStripMenuItem})
        Me.Tool_stock.Image = CType(resources.GetObject("Tool_stock.Image"), System.Drawing.Image)
        Me.Tool_stock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tool_stock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_stock.Name = "Tool_stock"
        Me.Tool_stock.Size = New System.Drawing.Size(80, 60)
        Me.Tool_stock.Text = "Gestión de Stock"
        Me.Tool_stock.Visible = False
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaNuevaToolStripMenuItem, Me.ListaActualizarToolStripMenuItem})
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ListaToolStripMenuItem.Text = "Lista"
        Me.ListaToolStripMenuItem.Visible = False
        '
        'ListaNuevaToolStripMenuItem
        '
        Me.ListaNuevaToolStripMenuItem.Name = "ListaNuevaToolStripMenuItem"
        Me.ListaNuevaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ListaNuevaToolStripMenuItem.Text = "Lista Nueva"
        '
        'ListaActualizarToolStripMenuItem
        '
        Me.ListaActualizarToolStripMenuItem.Name = "ListaActualizarToolStripMenuItem"
        Me.ListaActualizarToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ListaActualizarToolStripMenuItem.Text = "Lista Actualizar"
        '
        'MenuItem_Stock_Prov
        '
        Me.MenuItem_Stock_Prov.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedorAgregar_ToolStripMenuItem, Me.ProveedorModificar_ToolStripMenuItem})
        Me.MenuItem_Stock_Prov.Name = "MenuItem_Stock_Prov"
        Me.MenuItem_Stock_Prov.Size = New System.Drawing.Size(197, 22)
        Me.MenuItem_Stock_Prov.Text = "Proveedor"
        '
        'ProveedorAgregar_ToolStripMenuItem
        '
        Me.ProveedorAgregar_ToolStripMenuItem.Name = "ProveedorAgregar_ToolStripMenuItem"
        Me.ProveedorAgregar_ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ProveedorAgregar_ToolStripMenuItem.Text = "Nuevo"
        '
        'ProveedorModificar_ToolStripMenuItem
        '
        Me.ProveedorModificar_ToolStripMenuItem.Name = "ProveedorModificar_ToolStripMenuItem"
        Me.ProveedorModificar_ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ProveedorModificar_ToolStripMenuItem.Text = "Actualizar"
        '
        'MenuItem_Stock_Insumos
        '
        Me.MenuItem_Stock_Insumos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoNuevoNEWToolStripMenuItem, Me.ActualizarProductoToolStripMenuItem})
        Me.MenuItem_Stock_Insumos.Name = "MenuItem_Stock_Insumos"
        Me.MenuItem_Stock_Insumos.Size = New System.Drawing.Size(197, 22)
        Me.MenuItem_Stock_Insumos.Text = "Insumos"
        Me.MenuItem_Stock_Insumos.Visible = False
        '
        'ProductoNuevoNEWToolStripMenuItem
        '
        Me.ProductoNuevoNEWToolStripMenuItem.Name = "ProductoNuevoNEWToolStripMenuItem"
        Me.ProductoNuevoNEWToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ProductoNuevoNEWToolStripMenuItem.Text = "Nuevo"
        '
        'ActualizarProductoToolStripMenuItem
        '
        Me.ActualizarProductoToolStripMenuItem.Name = "ActualizarProductoToolStripMenuItem"
        Me.ActualizarProductoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ActualizarProductoToolStripMenuItem.Text = "Stock y Actualización"
        '
        'MenuItem_Stock_marca
        '
        Me.MenuItem_Stock_marca.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.ModificarToolStripMenuItem1})
        Me.MenuItem_Stock_marca.Name = "MenuItem_Stock_marca"
        Me.MenuItem_Stock_marca.Size = New System.Drawing.Size(197, 22)
        Me.MenuItem_Stock_marca.Text = "Marca"
        Me.MenuItem_Stock_marca.Visible = False
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'MenuItem_Stock_Categoria
        '
        Me.MenuItem_Stock_Categoria.Name = "MenuItem_Stock_Categoria"
        Me.MenuItem_Stock_Categoria.Size = New System.Drawing.Size(197, 22)
        Me.MenuItem_Stock_Categoria.Text = "Categorías"
        Me.MenuItem_Stock_Categoria.Visible = False
        '
        'MenuItem_Stock_consumir
        '
        Me.MenuItem_Stock_consumir.Name = "MenuItem_Stock_consumir"
        Me.MenuItem_Stock_consumir.Size = New System.Drawing.Size(197, 22)
        Me.MenuItem_Stock_consumir.Text = "Consumir Insumos"
        Me.MenuItem_Stock_consumir.Visible = False
        '
        'MenuItem_Stock_Consulta
        '
        Me.MenuItem_Stock_Consulta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeConsumosporConceptoToolStripMenuItem, Me.RegistroDeConsumosporInsumoToolStripMenuItem})
        Me.MenuItem_Stock_Consulta.Name = "MenuItem_Stock_Consulta"
        Me.MenuItem_Stock_Consulta.Size = New System.Drawing.Size(197, 22)
        Me.MenuItem_Stock_Consulta.Text = "Consulta de Consumos"
        Me.MenuItem_Stock_Consulta.Visible = False
        '
        'ConsultaDeAjustesToolStripMenuItem
        '
        Me.ConsultaDeAjustesToolStripMenuItem.Name = "ConsultaDeAjustesToolStripMenuItem"
        Me.ConsultaDeAjustesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ConsultaDeAjustesToolStripMenuItem.Text = "Consulta de Ajustes"
        '
        'Label_stock
        '
        Me.Label_stock.Name = "Label_stock"
        Me.Label_stock.Size = New System.Drawing.Size(93, 15)
        Me.Label_stock.Text = "Gestión de Ins."
        Me.Label_stock.Visible = False
        '
        'Separator_stock
        '
        Me.Separator_stock.Name = "Separator_stock"
        Me.Separator_stock.Size = New System.Drawing.Size(93, 6)
        Me.Separator_stock.Visible = False
        '
        'ToolS_Configuracion
        '
        Me.ToolS_Configuracion.AutoSize = False
        Me.ToolS_Configuracion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolS_Configuracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem, Me.MenuItem_CONF_usuario, Me.CajaConsultaToolStripMenuItem, Me.MenuItem_CONF_Sucursales, Me.MenuItem_CONF_empresa, Me.VendedorToolStripMenuItem, Me.TerminalesToolStripMenuItem, Me.MenuItem_CONF_turnos})
        Me.ToolS_Configuracion.Image = CType(resources.GetObject("ToolS_Configuracion.Image"), System.Drawing.Image)
        Me.ToolS_Configuracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolS_Configuracion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolS_Configuracion.Name = "ToolS_Configuracion"
        Me.ToolS_Configuracion.Size = New System.Drawing.Size(80, 60)
        Me.ToolS_Configuracion.Text = "Configuración"
        Me.ToolS_Configuracion.Visible = False
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoEmpleadoToolStripMenuItem, Me.ModificarEmpleadoToolStripMenuItem, Me.InformeEmpleadoToolStripMenuItem})
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        Me.EmpleadoToolStripMenuItem.Visible = False
        '
        'NuevoEmpleadoToolStripMenuItem
        '
        Me.NuevoEmpleadoToolStripMenuItem.Name = "NuevoEmpleadoToolStripMenuItem"
        Me.NuevoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NuevoEmpleadoToolStripMenuItem.Text = "Empleado Nuevo"
        '
        'ModificarEmpleadoToolStripMenuItem
        '
        Me.ModificarEmpleadoToolStripMenuItem.Name = "ModificarEmpleadoToolStripMenuItem"
        Me.ModificarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ModificarEmpleadoToolStripMenuItem.Text = "Empleado Actualizar"
        '
        'InformeEmpleadoToolStripMenuItem
        '
        Me.InformeEmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncionYRemuneracionToolStripMenuItem, Me.DatosPersonalesToolStripMenuItem})
        Me.InformeEmpleadoToolStripMenuItem.Name = "InformeEmpleadoToolStripMenuItem"
        Me.InformeEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.InformeEmpleadoToolStripMenuItem.Text = "Empleado Informe"
        '
        'FuncionYRemuneracionToolStripMenuItem
        '
        Me.FuncionYRemuneracionToolStripMenuItem.Name = "FuncionYRemuneracionToolStripMenuItem"
        Me.FuncionYRemuneracionToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.FuncionYRemuneracionToolStripMenuItem.Text = "Funcion y Remuneracion"
        '
        'DatosPersonalesToolStripMenuItem
        '
        Me.DatosPersonalesToolStripMenuItem.Name = "DatosPersonalesToolStripMenuItem"
        Me.DatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.DatosPersonalesToolStripMenuItem.Text = "Datos Personales"
        '
        'MenuItem_CONF_usuario
        '
        Me.MenuItem_CONF_usuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.UsuarioActualizarToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.MenuItem_CONF_usuario.Name = "MenuItem_CONF_usuario"
        Me.MenuItem_CONF_usuario.Size = New System.Drawing.Size(145, 22)
        Me.MenuItem_CONF_usuario.Text = "Usuario"
        Me.MenuItem_CONF_usuario.Visible = False
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo"
        '
        'UsuarioActualizarToolStripMenuItem
        '
        Me.UsuarioActualizarToolStripMenuItem.Name = "UsuarioActualizarToolStripMenuItem"
        Me.UsuarioActualizarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.UsuarioActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'CajaConsultaToolStripMenuItem
        '
        Me.CajaConsultaToolStripMenuItem.Name = "CajaConsultaToolStripMenuItem"
        Me.CajaConsultaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CajaConsultaToolStripMenuItem.Text = "Caja consulta"
        Me.CajaConsultaToolStripMenuItem.Visible = False
        '
        'MenuItem_CONF_Sucursales
        '
        Me.MenuItem_CONF_Sucursales.Name = "MenuItem_CONF_Sucursales"
        Me.MenuItem_CONF_Sucursales.Size = New System.Drawing.Size(145, 22)
        Me.MenuItem_CONF_Sucursales.Text = "Sucursales"
        Me.MenuItem_CONF_Sucursales.Visible = False
        '
        'MenuItem_CONF_empresa
        '
        Me.MenuItem_CONF_empresa.Name = "MenuItem_CONF_empresa"
        Me.MenuItem_CONF_empresa.Size = New System.Drawing.Size(145, 22)
        Me.MenuItem_CONF_empresa.Text = "Empresa"
        Me.MenuItem_CONF_empresa.Visible = False
        '
        'VendedorToolStripMenuItem
        '
        Me.VendedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendedorNuevoToolStripMenuitem, Me.VendedorActualizarToolStripMenuItem})
        Me.VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        Me.VendedorToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.VendedorToolStripMenuItem.Text = "Vendedor"
        Me.VendedorToolStripMenuItem.Visible = False
        '
        'VendedorNuevoToolStripMenuitem
        '
        Me.VendedorNuevoToolStripMenuitem.Name = "VendedorNuevoToolStripMenuitem"
        Me.VendedorNuevoToolStripMenuitem.Size = New System.Drawing.Size(126, 22)
        Me.VendedorNuevoToolStripMenuitem.Text = "Nuevo"
        '
        'VendedorActualizarToolStripMenuItem
        '
        Me.VendedorActualizarToolStripMenuItem.Name = "VendedorActualizarToolStripMenuItem"
        Me.VendedorActualizarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.VendedorActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'TerminalesToolStripMenuItem
        '
        Me.TerminalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TerminalNuevoToolStripMenuItem2, Me.TerminalModificarToolStripMenuItem2})
        Me.TerminalesToolStripMenuItem.Name = "TerminalesToolStripMenuItem"
        Me.TerminalesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.TerminalesToolStripMenuItem.Text = "Terminales"
        Me.TerminalesToolStripMenuItem.Visible = False
        '
        'TerminalNuevoToolStripMenuItem2
        '
        Me.TerminalNuevoToolStripMenuItem2.Name = "TerminalNuevoToolStripMenuItem2"
        Me.TerminalNuevoToolStripMenuItem2.Size = New System.Drawing.Size(125, 22)
        Me.TerminalNuevoToolStripMenuItem2.Text = "Nuevo"
        '
        'TerminalModificarToolStripMenuItem2
        '
        Me.TerminalModificarToolStripMenuItem2.Name = "TerminalModificarToolStripMenuItem2"
        Me.TerminalModificarToolStripMenuItem2.Size = New System.Drawing.Size(125, 22)
        Me.TerminalModificarToolStripMenuItem2.Text = "Modificar"
        '
        'MenuItem_CONF_turnos
        '
        Me.MenuItem_CONF_turnos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem2, Me.ActualizarToolStripMenuItem})
        Me.MenuItem_CONF_turnos.Name = "MenuItem_CONF_turnos"
        Me.MenuItem_CONF_turnos.Size = New System.Drawing.Size(145, 22)
        Me.MenuItem_CONF_turnos.Text = "Turnos"
        Me.MenuItem_CONF_turnos.Visible = False
        '
        'NuevoToolStripMenuItem2
        '
        Me.NuevoToolStripMenuItem2.Name = "NuevoToolStripMenuItem2"
        Me.NuevoToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
        Me.NuevoToolStripMenuItem2.Text = "Nuevo"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'Label_Configuraciones
        '
        Me.Label_Configuraciones.Name = "Label_Configuraciones"
        Me.Label_Configuraciones.Size = New System.Drawing.Size(93, 15)
        Me.Label_Configuraciones.Text = "Configuraciones"
        Me.Label_Configuraciones.Visible = False
        '
        'Separator_Conf
        '
        Me.Separator_Conf.Name = "Separator_Conf"
        Me.Separator_Conf.Size = New System.Drawing.Size(93, 6)
        Me.Separator_Conf.Visible = False
        '
        'ToolStripDropDownButton6
        '
        Me.ToolStripDropDownButton6.AutoSize = False
        Me.ToolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaEnCajaToolStripMenuItem, Me.VentaEnMesas2ToolStripMenuItem, Me.VentasConsultasToolStripMenuItem, Me.CalculadoraDelSistemaToolStripMenuItem, Me.MenuMesasNEWToolStripMenuItem, Me.CierreDeCajaToolStripMenuItem, Me.RemitoToolStripMenuItem})
        Me.ToolStripDropDownButton6.Image = CType(resources.GetObject("ToolStripDropDownButton6.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton6.Name = "ToolStripDropDownButton6"
        Me.ToolStripDropDownButton6.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton6.Text = "Venta"
        Me.ToolStripDropDownButton6.Visible = False
        '
        'VentaEnCajaToolStripMenuItem
        '
        Me.VentaEnCajaToolStripMenuItem.Name = "VentaEnCajaToolStripMenuItem"
        Me.VentaEnCajaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VentaEnCajaToolStripMenuItem.Text = "Venta en Caja"
        Me.VentaEnCajaToolStripMenuItem.Visible = False
        '
        'VentaEnMesas2ToolStripMenuItem
        '
        Me.VentaEnMesas2ToolStripMenuItem.Name = "VentaEnMesas2ToolStripMenuItem"
        Me.VentaEnMesas2ToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VentaEnMesas2ToolStripMenuItem.Text = "Venta en mesas"
        Me.VentaEnMesas2ToolStripMenuItem.Visible = False
        '
        'VentasConsultasToolStripMenuItem
        '
        Me.VentasConsultasToolStripMenuItem.Name = "VentasConsultasToolStripMenuItem"
        Me.VentasConsultasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VentasConsultasToolStripMenuItem.Text = "Ventas Consultas"
        Me.VentasConsultasToolStripMenuItem.Visible = False
        '
        'CalculadoraDelSistemaToolStripMenuItem
        '
        Me.CalculadoraDelSistemaToolStripMenuItem.Name = "CalculadoraDelSistemaToolStripMenuItem"
        Me.CalculadoraDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CalculadoraDelSistemaToolStripMenuItem.Text = "Calculadora del Sistema"
        Me.CalculadoraDelSistemaToolStripMenuItem.Visible = False
        '
        'MenuMesasNEWToolStripMenuItem
        '
        Me.MenuMesasNEWToolStripMenuItem.Name = "MenuMesasNEWToolStripMenuItem"
        Me.MenuMesasNEWToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.MenuMesasNEWToolStripMenuItem.Text = "Menu Mesas NEW"
        Me.MenuMesasNEWToolStripMenuItem.Visible = False
        '
        'CierreDeCajaToolStripMenuItem
        '
        Me.CierreDeCajaToolStripMenuItem.Name = "CierreDeCajaToolStripMenuItem"
        Me.CierreDeCajaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CierreDeCajaToolStripMenuItem.Text = "Cierre de Caja"
        Me.CierreDeCajaToolStripMenuItem.Visible = False
        '
        'RemitoToolStripMenuItem
        '
        Me.RemitoToolStripMenuItem.Name = "RemitoToolStripMenuItem"
        Me.RemitoToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RemitoToolStripMenuItem.Text = "Remito"
        Me.RemitoToolStripMenuItem.Visible = False
        '
        'ToolStripDropDownButton8
        '
        Me.ToolStripDropDownButton8.AutoSize = False
        Me.ToolStripDropDownButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Caja_ToolStripMenuItem1, Me.EgresosToolStripMenuItem, Me.ConsultarCajasToolStripMenuItem})
        Me.ToolStripDropDownButton8.Image = Global.Aplicacion.My.Resources.Resources.caja
        Me.ToolStripDropDownButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton8.Name = "ToolStripDropDownButton8"
        Me.ToolStripDropDownButton8.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton8.Text = "Caja"
        Me.ToolStripDropDownButton8.Visible = False
        '
        'Caja_ToolStripMenuItem1
        '
        Me.Caja_ToolStripMenuItem1.Name = "Caja_ToolStripMenuItem1"
        Me.Caja_ToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.Caja_ToolStripMenuItem1.Text = "Cierre de Caja"
        Me.Caja_ToolStripMenuItem1.Visible = False
        '
        'EgresosToolStripMenuItem
        '
        Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
        Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.EgresosToolStripMenuItem.Text = "Registrar Egresos/Ingresos"
        Me.EgresosToolStripMenuItem.Visible = False
        '
        'ConsultarCajasToolStripMenuItem
        '
        Me.ConsultarCajasToolStripMenuItem.Name = "ConsultarCajasToolStripMenuItem"
        Me.ConsultarCajasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ConsultarCajasToolStripMenuItem.Text = "Consultar Cajas"
        Me.ConsultarCajasToolStripMenuItem.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.AutoSize = False
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoGestionToolStripMenuItem, Me.TurnoComunToolStripMenuItem, Me.TurnoFijoToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ConfigurarToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton1.Text = "Turno"
        Me.ToolStripDropDownButton1.Visible = False
        '
        'TurnoGestionToolStripMenuItem
        '
        Me.TurnoGestionToolStripMenuItem.Name = "TurnoGestionToolStripMenuItem"
        Me.TurnoGestionToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TurnoGestionToolStripMenuItem.Text = "Turno Gestion"
        '
        'TurnoComunToolStripMenuItem
        '
        Me.TurnoComunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoComunNuevoToolStripMenuItem, Me.TurnoComunEliminarToolStripMenuItem})
        Me.TurnoComunToolStripMenuItem.Name = "TurnoComunToolStripMenuItem"
        Me.TurnoComunToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TurnoComunToolStripMenuItem.Text = "Turno Comun"
        '
        'TurnoComunNuevoToolStripMenuItem
        '
        Me.TurnoComunNuevoToolStripMenuItem.Name = "TurnoComunNuevoToolStripMenuItem"
        Me.TurnoComunNuevoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TurnoComunNuevoToolStripMenuItem.Text = "Turno Comun Nuevo"
        '
        'TurnoComunEliminarToolStripMenuItem
        '
        Me.TurnoComunEliminarToolStripMenuItem.Name = "TurnoComunEliminarToolStripMenuItem"
        Me.TurnoComunEliminarToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TurnoComunEliminarToolStripMenuItem.Text = "Turno Comun Eliminar"
        '
        'TurnoFijoToolStripMenuItem
        '
        Me.TurnoFijoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoFijoNuevoToolStripMenuItem, Me.TurnoFijoActualizarToolStripMenuItem})
        Me.TurnoFijoToolStripMenuItem.Name = "TurnoFijoToolStripMenuItem"
        Me.TurnoFijoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TurnoFijoToolStripMenuItem.Text = "Turno Fijo"
        '
        'TurnoFijoNuevoToolStripMenuItem
        '
        Me.TurnoFijoNuevoToolStripMenuItem.Name = "TurnoFijoNuevoToolStripMenuItem"
        Me.TurnoFijoNuevoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TurnoFijoNuevoToolStripMenuItem.Text = "Turno Fijo Nuevo"
        '
        'TurnoFijoActualizarToolStripMenuItem
        '
        Me.TurnoFijoActualizarToolStripMenuItem.Name = "TurnoFijoActualizarToolStripMenuItem"
        Me.TurnoFijoActualizarToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TurnoFijoActualizarToolStripMenuItem.Text = "Turno Fijo Actualizar"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoConsultaToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'TurnoConsultaToolStripMenuItem
        '
        Me.TurnoConsultaToolStripMenuItem.Name = "TurnoConsultaToolStripMenuItem"
        Me.TurnoConsultaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TurnoConsultaToolStripMenuItem.Text = "Turno Consulta"
        '
        'ConfigurarToolStripMenuItem
        '
        Me.ConfigurarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoConfigurarToolStripMenuItem, Me.MailConfigurarToolStripMenuItem, Me.EmailDestinoConfigurarToolStripMenuItem, Me.SonidoAlarmaToolStripMenuItem})
        Me.ConfigurarToolStripMenuItem.Name = "ConfigurarToolStripMenuItem"
        Me.ConfigurarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ConfigurarToolStripMenuItem.Text = "Configurar"
        '
        'TurnoConfigurarToolStripMenuItem
        '
        Me.TurnoConfigurarToolStripMenuItem.Name = "TurnoConfigurarToolStripMenuItem"
        Me.TurnoConfigurarToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TurnoConfigurarToolStripMenuItem.Text = "Turno Configurar"
        '
        'MailConfigurarToolStripMenuItem
        '
        Me.MailConfigurarToolStripMenuItem.Name = "MailConfigurarToolStripMenuItem"
        Me.MailConfigurarToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.MailConfigurarToolStripMenuItem.Text = "Email Origen Configurar"
        '
        'EmailDestinoConfigurarToolStripMenuItem
        '
        Me.EmailDestinoConfigurarToolStripMenuItem.Name = "EmailDestinoConfigurarToolStripMenuItem"
        Me.EmailDestinoConfigurarToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EmailDestinoConfigurarToolStripMenuItem.Text = "Email Destino Configurar"
        '
        'SonidoAlarmaToolStripMenuItem
        '
        Me.SonidoAlarmaToolStripMenuItem.Name = "SonidoAlarmaToolStripMenuItem"
        Me.SonidoAlarmaToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SonidoAlarmaToolStripMenuItem.Text = "Sonido Alarma"
        '
        'ToolStripDropDownButton7
        '
        Me.ToolStripDropDownButton7.AutoSize = False
        Me.ToolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultaToolStripMenuItem1, Me.RecepciónToolStripMenuItem})
        Me.ToolStripDropDownButton7.Image = CType(resources.GetObject("ToolStripDropDownButton7.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton7.Name = "ToolStripDropDownButton7"
        Me.ToolStripDropDownButton7.Size = New System.Drawing.Size(80, 60)
        Me.ToolStripDropDownButton7.Text = "Pedidos"
        Me.ToolStripDropDownButton7.Visible = False
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo pedido"
        Me.NuevoToolStripMenuItem.Visible = False
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.ConsultaToolStripMenuItem1.Text = "Consulta de pedido"
        Me.ConsultaToolStripMenuItem1.Visible = False
        '
        'RecepciónToolStripMenuItem
        '
        Me.RecepciónToolStripMenuItem.Name = "RecepciónToolStripMenuItem"
        Me.RecepciónToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RecepciónToolStripMenuItem.Text = "Recepción de pedido"
        Me.RecepciónToolStripMenuItem.Visible = False
        '
        'Separator_Abajo
        '
        Me.Separator_Abajo.Name = "Separator_Abajo"
        Me.Separator_Abajo.Size = New System.Drawing.Size(93, 6)
        Me.Separator_Abajo.Visible = False
        '
        'PN_Entrada
        '
        Me.PN_Entrada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PN_Entrada.BackColor = System.Drawing.Color.Transparent
        Me.PN_Entrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PN_Entrada.Location = New System.Drawing.Point(119, 71)
        Me.PN_Entrada.Margin = New System.Windows.Forms.Padding(4)
        Me.PN_Entrada.Name = "PN_Entrada"
        Me.PN_Entrada.Size = New System.Drawing.Size(1142, 589)
        Me.PN_Entrada.TabIndex = 53
        '
        'BO_Caja
        '
        Me.BO_Caja.Image = CType(resources.GetObject("BO_Caja.Image"), System.Drawing.Image)
        Me.BO_Caja.Location = New System.Drawing.Point(-7, 526)
        Me.BO_Caja.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Caja.Name = "BO_Caja"
        Me.BO_Caja.Size = New System.Drawing.Size(60, 55)
        Me.BO_Caja.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.BO_Caja, "Caja")
        Me.BO_Caja.UseVisualStyleBackColor = True
        Me.BO_Caja.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(61, 526)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 55)
        Me.Button1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Button1, "Alarma Turno")
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BO_TurnoConsulta
        '
        Me.BO_TurnoConsulta.Image = CType(resources.GetObject("BO_TurnoConsulta.Image"), System.Drawing.Image)
        Me.BO_TurnoConsulta.Location = New System.Drawing.Point(61, 605)
        Me.BO_TurnoConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_TurnoConsulta.Name = "BO_TurnoConsulta"
        Me.BO_TurnoConsulta.Size = New System.Drawing.Size(60, 55)
        Me.BO_TurnoConsulta.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.BO_TurnoConsulta, "Consulta de Turno")
        Me.BO_TurnoConsulta.UseVisualStyleBackColor = True
        Me.BO_TurnoConsulta.Visible = False
        '
        'Btn_corte_caja
        '
        Me.Btn_corte_caja.Image = Global.Aplicacion.My.Resources.Resources.cajas
        Me.Btn_corte_caja.Location = New System.Drawing.Point(-7, 605)
        Me.Btn_corte_caja.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_corte_caja.Name = "Btn_corte_caja"
        Me.Btn_corte_caja.Size = New System.Drawing.Size(60, 55)
        Me.Btn_corte_caja.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Btn_corte_caja, "Corte de caja")
        Me.Btn_corte_caja.UseVisualStyleBackColor = True
        Me.Btn_corte_caja.Visible = False
        '
        'BO_USU_cerrar
        '
        Me.BO_USU_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_USU_cerrar.Image = CType(resources.GetObject("BO_USU_cerrar.Image"), System.Drawing.Image)
        Me.BO_USU_cerrar.Location = New System.Drawing.Point(1167, 12)
        Me.BO_USU_cerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_USU_cerrar.Name = "BO_USU_cerrar"
        Me.BO_USU_cerrar.Size = New System.Drawing.Size(79, 30)
        Me.BO_USU_cerrar.TabIndex = 52
        Me.BO_USU_cerrar.TabStop = False
        Me.BO_USU_cerrar.Text = "Salir"
        Me.BO_USU_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_USU_cerrar, "Cerrar Sistema")
        Me.BO_USU_cerrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BO_USU_contrasena)
        Me.GroupBox2.Controls.Add(Me.BO_USU_sesion)
        Me.GroupBox2.Controls.Add(Me.LB_UT_dep)
        Me.GroupBox2.Controls.Add(Me.LB_USU_ape)
        Me.GroupBox2.Controls.Add(Me.Label_Suc)
        Me.GroupBox2.Controls.Add(Me.BO_USU_cerrar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1274, 55)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sesión de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(304, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(634, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Sucursal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Nombre:"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(954, 12)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 30)
        Me.Button2.TabIndex = 56
        Me.Button2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Button2, "Sonido")
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'BO_USU_contrasena
        '
        Me.BO_USU_contrasena.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_USU_contrasena.Image = CType(resources.GetObject("BO_USU_contrasena.Image"), System.Drawing.Image)
        Me.BO_USU_contrasena.Location = New System.Drawing.Point(994, 12)
        Me.BO_USU_contrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_USU_contrasena.Name = "BO_USU_contrasena"
        Me.BO_USU_contrasena.Size = New System.Drawing.Size(32, 30)
        Me.BO_USU_contrasena.TabIndex = 33
        Me.BO_USU_contrasena.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BO_USU_contrasena, "Cambiar Contraseña")
        Me.BO_USU_contrasena.UseVisualStyleBackColor = True
        '
        'BO_USU_sesion
        '
        Me.BO_USU_sesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_USU_sesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BO_USU_sesion.Image = CType(resources.GetObject("BO_USU_sesion.Image"), System.Drawing.Image)
        Me.BO_USU_sesion.Location = New System.Drawing.Point(1034, 12)
        Me.BO_USU_sesion.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_USU_sesion.Name = "BO_USU_sesion"
        Me.BO_USU_sesion.Size = New System.Drawing.Size(128, 30)
        Me.BO_USU_sesion.TabIndex = 33
        Me.BO_USU_sesion.TabStop = False
        Me.BO_USU_sesion.Text = "Cerrar sesión"
        Me.BO_USU_sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_USU_sesion, "Cerrar Sesion")
        Me.BO_USU_sesion.UseVisualStyleBackColor = True
        '
        'LB_UT_dep
        '
        Me.LB_UT_dep.AutoSize = True
        Me.LB_UT_dep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_UT_dep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LB_UT_dep.Location = New System.Drawing.Point(304, 33)
        Me.LB_UT_dep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_UT_dep.Name = "LB_UT_dep"
        Me.LB_UT_dep.Size = New System.Drawing.Size(124, 16)
        Me.LB_UT_dep.TabIndex = 15
        Me.LB_UT_dep.Text = "Tipo de Usuario:"
        '
        'LB_USU_ape
        '
        Me.LB_USU_ape.AutoSize = True
        Me.LB_USU_ape.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_USU_ape.Location = New System.Drawing.Point(8, 33)
        Me.LB_USU_ape.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_USU_ape.Name = "LB_USU_ape"
        Me.LB_USU_ape.Size = New System.Drawing.Size(62, 16)
        Me.LB_USU_ape.TabIndex = 13
        Me.LB_USU_ape.Text = "Usuario"
        '
        'Label_Suc
        '
        Me.Label_Suc.AutoSize = True
        Me.Label_Suc.BackColor = System.Drawing.Color.Transparent
        Me.Label_Suc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Suc.ForeColor = System.Drawing.Color.Blue
        Me.Label_Suc.Location = New System.Drawing.Point(634, 33)
        Me.Label_Suc.Name = "Label_Suc"
        Me.Label_Suc.Size = New System.Drawing.Size(81, 16)
        Me.Label_Suc.TabIndex = 58
        Me.Label_Suc.Text = "Label_Suc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label3.Location = New System.Drawing.Point(530, 664)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Terminal:"
        Me.Label3.Visible = False
        '
        'Lbl_Terminal
        '
        Me.Lbl_Terminal.AutoSize = True
        Me.Lbl_Terminal.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Terminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Terminal.ForeColor = System.Drawing.Color.OliveDrab
        Me.Lbl_Terminal.Location = New System.Drawing.Point(641, 666)
        Me.Lbl_Terminal.Name = "Lbl_Terminal"
        Me.Lbl_Terminal.Size = New System.Drawing.Size(98, 16)
        Me.Lbl_Terminal.TabIndex = 60
        Me.Lbl_Terminal.Text = "Lbl_Terminal"
        Me.Lbl_Terminal.Visible = False
        '
        'IngresDeMercaderiaToolStripMenuItem
        '
        Me.IngresDeMercaderiaToolStripMenuItem.Name = "IngresDeMercaderiaToolStripMenuItem"
        Me.IngresDeMercaderiaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.IngresDeMercaderiaToolStripMenuItem.Text = "Ingreso de Insumos"
        '
        'MovimientoToolStripMenuItem
        '
        Me.MovimientoToolStripMenuItem.Name = "MovimientoToolStripMenuItem"
        Me.MovimientoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.MovimientoToolStripMenuItem.Text = "Movimiento"
        '
        'BajaDeInsumosToolStripMenuItem
        '
        Me.BajaDeInsumosToolStripMenuItem.Name = "BajaDeInsumosToolStripMenuItem"
        Me.BajaDeInsumosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BajaDeInsumosToolStripMenuItem.Text = "Baja de Insumos"
        '
        'RegistroDeConsumosporConceptoToolStripMenuItem
        '
        Me.RegistroDeConsumosporConceptoToolStripMenuItem.Name = "RegistroDeConsumosporConceptoToolStripMenuItem"
        Me.RegistroDeConsumosporConceptoToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.RegistroDeConsumosporConceptoToolStripMenuItem.Text = "Registro de Consumos (por concepto)"
        '
        'RegistroDeConsumosporInsumoToolStripMenuItem
        '
        Me.RegistroDeConsumosporInsumoToolStripMenuItem.Name = "RegistroDeConsumosporInsumoToolStripMenuItem"
        Me.RegistroDeConsumosporInsumoToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.RegistroDeConsumosporInsumoToolStripMenuItem.Text = "Registro de Consumos (por insumo)"
        '
        'US_administrador
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BO_TurnoConsulta)
        Me.Controls.Add(Me.BO_Caja)
        Me.Controls.Add(Me.Btn_corte_caja)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_Terminal)
        Me.Controls.Add(Me.PN_Entrada)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "US_administrador"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestión - HAMERSOFT"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Separator_deposito As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Separator_Paciente As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Paciente As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Tool_ObraSocial As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Separator_Enfermeria As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_stock As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolS_Configuracion As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PN_Entrada As System.Windows.Forms.Panel
    Friend WithEvents BO_USU_cerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_USU_contrasena As System.Windows.Forms.Button
    Friend WithEvents BO_USU_sesion As System.Windows.Forms.Button
    Friend WithEvents LB_UT_dep As System.Windows.Forms.Label
    Friend WithEvents LB_USU_ape As System.Windows.Forms.Label
    Friend WithEvents ToolStripDropDownButton6 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Separator_Medico As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton7 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents EmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_CONF_usuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_PAC_nuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaNuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_Stock_Prov As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorAgregar_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorModificar_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_Stock_Categoria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_Stock_Insumos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaEnCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoConfigurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MailConfigurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailDestinoConfigurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoGestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SonidoAlarmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformeEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionYRemuneracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosPersonalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Separator_stock As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TurnoFijoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoFijoNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoFijoActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoComunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoComunNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoComunEliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents VentaEnMesas2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton8 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Caja_ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BO_Caja As System.Windows.Forms.Button
    Friend WithEvents VentasConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BO_TurnoConsulta As System.Windows.Forms.Button
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Separator_Conf As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuMesasNEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoNuevoNEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_CONF_Sucursales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_CONF_empresa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tool_Medico As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Separator_ObraSocial As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecepciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_Suc As System.Windows.Forms.Label
    Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EgresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarCajasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_Stock_marca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_corte_caja As System.Windows.Forms.Button
    Friend WithEvents Lbl_Terminal As System.Windows.Forms.Label
    Friend WithEvents VendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedorNuevoToolStripMenuitem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedorActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminalNuevoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminalModificarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_MEDICO_nuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_MEDICO_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_paciente As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label_Medicos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label_ObraSocial As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label_stock As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label_Configuraciones As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MenuItem_PAC_Act As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_servicio_nuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tool_Deposito As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents IngresDeMercaderiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDeInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_DEP_ingreso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_DEP_Mov As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_DEP_baja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_DEP_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeAltasporFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeAltassoloInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_Stock_consumir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_Stock_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeMovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeBajasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tool_Enfermeria As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Label_Enfermeria As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label_deposito As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MenuItem_PAC_HC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_OBRA_nuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_OBRA_actualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_OBRA_informe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_CONF_turnos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_ENF_NSD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_ENF_Informe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Separator_Arriba As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Separator_Abajo As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RegistroDeMovimientossoloInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeBajassoloInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_ENF_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_ENF_RegMov As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_ENF_stock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsumosPredefinidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeAjustesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeConsumosporConceptoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeConsumosporInsumoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
