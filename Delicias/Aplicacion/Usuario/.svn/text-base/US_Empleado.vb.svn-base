Public Class US_Empleado

    Dim _enabledCerrar As Boolean = False

    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")> _
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property

    Public Sub Configuracion(ByVal ds_usu As DataSet)
        LB_USU_ape.Text = (CType(ds_usu.Tables(0).Rows(0).Item("USU_ape"), String)) + " " + (CType(ds_usu.Tables(0).Rows(0).Item("USU_nom"), String))
        LB_UT_dep.Text = (CType(ds_usu.Tables(0).Rows(0).Item("UT_desc"), String))
        USU_id = (CType(ds_usu.Tables(0).Rows(0).Item("USU_id"), String))
        USU_contr = (CType(ds_usu.Tables(0).Rows(0).Item("USU_cont"), String))
        Inicio.Visible = False
    End Sub

    'BOTONES ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Public USU_id As String
    Dim USU_contr As String

    Private Sub BO_USU_contrasena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_contrasena.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cambiar la Contraseña de Usuario?", "Sistema de Gestion La Santa Fe.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            USU_contrasena.Usuario_Datos(USU_id, USU_contr)
            USU_contrasena.Show()
        End If
    End Sub

    Private Sub BO_USU_sesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_sesion.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cerrar la Sesion de Usuario?", "Sistema de Gestion La Santa Fe.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Me.Close()
            Inicio.Visible = True
        End If
    End Sub

    Private Sub BO_USU_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_cerrar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cerrar el Sistema?", "Sistema de Gestion La Santa Fe.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Me.Close()
            Inicio.Close()
        End If
    End Sub

    'Tiempo ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Public Sub Iniciar_Tiempo()
        Dim Tiempo As Integer = 60
        Call TiempoEjecutar(Tiempo)
    End Sub

    Private TiempoRestante As Integer

    Public Function TiempoEjecutar(ByVal Tiempo As Integer)
        TiempoEjecutar = ""
        TiempoRestante = Tiempo  ' 1 minutos=60 segundos 
        Timer1.Interval = 1000

        Call TimerOn(1000) ' Hechanos a andar el timer
    End Function

    Public Sub TimerOn(ByRef Interval As Short)
        If Interval > 0 Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If

    End Sub

    Dim APturno As New Aplicacion.Turno

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TiempoRestante >= 0 Then
            TiempoRestante = TiempoRestante - 1
        Else
            APturno.TurnoIniciado_control(2)
        End If
    End Sub

    'BOTON TURNO GESTION
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'llamar_Form(Turno_Gestion)
        Turno_Gestion.Show()
        Turno_Gestion.Turno_ObtenerIniciado()
        Button1.Visible = False
    End Sub

    'MENU ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Dim form_anterior

    Public Sub llamar_Form(ByVal var)
        If (Me.PN_Entrada.Controls.Count > 0) Then
            Me.PN_Entrada.Controls.RemoveAt(0)
            If form_anterior.ToString <> var.ToString Then
                form_anterior.close()
            End If
            var.TopLevel = False
            var.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            var.Dock = DockStyle.Fill
            Me.PN_Entrada.Controls.Add(var)
            Me.PN_Entrada.Tag = var
            form_anterior = var
            var.Show()
        Else
            var.TopLevel = False
            var.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            var.Dock = DockStyle.Fill
            Me.PN_Entrada.Controls.Add(var)
            Me.PN_Entrada.Tag = var
            form_anterior = var
            var.Show()
        End If
    End Sub

    'Turno
    Private Sub TurnoGestionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TurnoGestionToolStripMenuItem.Click
        'llamar_Form(Turno_Gestion)
        Turno_Gestion.Show()
        Turno_Gestion.Turno_ObtenerIniciado()
    End Sub

    Private Sub TurnoNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        llamar_Form(Turno_alta)
    End Sub

    Private Sub TurnoFijoNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        llamar_Form(TurnoFijo_alta)
    End Sub

    Private Sub US_Empleado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        llamar_Form(PN_Inicio)
    End Sub

    Private Sub VentaEnMesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaEnMesasToolStripMenuItem.Click
        llamar_Form(Mesas_gestion_2)
    End Sub

    Private Sub VentaEnCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaEnCajaToolStripMenuItem.Click
        llamar_Form(Venta_Caja_gestion)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Turno_Alarma.Show()
    End Sub

    Private Sub TurnoFijoNuevoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles TurnoFijoNuevoToolStripMenuItem1.Click
        llamar_Form(TurnoFijo_alta)
    End Sub

    Private Sub TurnoFijoActualizarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TurnoFijoActualizarToolStripMenuItem.Click
        llamar_Form(TurnoFijo_Modificar)
    End Sub

    Private Sub TurnoComunNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TurnoComunNuevoToolStripMenuItem.Click
        llamar_Form(Turno_alta)
    End Sub

    Private Sub TurnoComunToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles TurnoComunToolStripMenuItem1.Click
        llamar_Form(Turno_Eliminar)
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Egresos_Alta)
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llamar_Form(Egresos_registrados_consulta_usuario)
    End Sub

    Private Sub TurnoConsultaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TurnoConsultaToolStripMenuItem.Click
        'Turno_Consulta.Show()
        Turno_Consulta_ampliada.Show()
    End Sub

    Private Sub CajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Registro_inicio_cierre.Show()
    End Sub

    Private Sub BO_Caja_Click(sender As System.Object, e As System.EventArgs) Handles BO_Caja.Click
        Registro_inicio_cierre.Show()
        Registro_inicio_cierre.Habilitar()
    End Sub

    Private Sub BO_TurnoConsulta_Click(sender As System.Object, e As System.EventArgs) Handles BO_TurnoConsulta.Click
        'Turno_Consulta.Show()
        Turno_Consulta_ampliada.Show()
    End Sub

    Private Sub VentaConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaConsultaToolStripMenuItem.Click

        llamar_Form(Venta_consulta_emple)
    End Sub

    Private Sub EgresoNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresoNuevoToolStripMenuItem.Click
        llamar_Form(Egresos_Alta)
    End Sub

    Private Sub EgresosRegistradosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresosRegistradosToolStripMenuItem.Click
        llamar_Form(Egresos_registrados_consulta_usuario)
    End Sub

    Private Sub CalculadoraDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraDelSistemaToolStripMenuItem.Click
        Shell("C:\WINDOWS\system32\calc.exe", AppWinStyle.NormalFocus)
    End Sub
    Dim DAcliente As New Datos.Cliente
    Private Sub ClienteInformeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteInformeToolStripMenuItem.Click
        Dim ds_cliente As DataSet = DAcliente.Informe_Cliente
        If ds_cliente.Tables(0).Rows.Count > 0 Then
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            CrReport.Load(Application.StartupPath & "\..\..\Informe\CR_InformeCliente.rpt")
            CrReport.Database.Tables("Cliente").SetDataSource(ds_cliente.Tables(0))
            Informe_Mostrar.CrystalReportViewer1.ReportSource = CrReport
            Informe_Mostrar.Show()
        End If
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        llamar_Form(Cliente_alta)
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        llamar_Form(Cliente_modificar)
    End Sub

  
    
    Private Sub HeladeraGondolaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeladeraGondolaToolStripMenuItem.Click
        llamar_Form(Gondola)
    End Sub
End Class