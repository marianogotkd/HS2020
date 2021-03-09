Public Class US_Pedidos

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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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


    

    
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        llamar_Form(Pedidos_Nuevo)
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        llamar_Form(Pedidos_Consulta)
    End Sub


    Private Sub US_Pedidos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llamar_Form(PN_Inicio)
    End Sub
End Class