Public Class Inicio

    Public USU_id As Integer
    Public suc_id As Integer
    Public suc_nom As String
    Public terminal_id As Integer
    Dim _enabledCerrar As Boolean = False
    Dim DAusuario As New Datos.Usuario


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

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        TB_USU_usu.Focus()

        InitializeMyControl()

        IM_ERROR.Visible = False
        LB_USU_inv.Visible = False

        TB_USU_usu.TextAlign = HorizontalAlignment.Center
        TB_USU_cont.TextAlign = HorizontalAlignment.Center

    End Sub

    Private Sub InitializeMyControl()
        TB_USU_cont.PasswordChar = "*"
        TB_USU_cont.MaxLength = 15
    End Sub

    Private Sub BO_USU_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_cerrar.Click
        Me.Close()
    End Sub

    Private Sub BO_USU_sesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_sesion.Click
        sesion()
    End Sub

    Dim APturno As New Aplicacion.Turno
    Public ALARMA As Integer = 1

    Dim APcaja As New Aplicacion.Caja
    Public CAJA_id As Integer


    Public UT_id As String 'Para los Permisos de usuario
    Public tipo_usuario As String = "" 'necesario para el modulo gestion turno, en el boton de play, te pide asignar mesa, entonces se habre dicho formulario en su correspondiente menu

    Public Sub sesion()
        Dim ds_usu As DataSet = DAusuario.Usuario_Sesion(TB_USU_usu.Text, TB_USU_cont.Text)
        With ds_usu.Tables(0).Rows
            If .Count > 0 Then
                UT_id = (CType(ds_usu.Tables(0).Rows(0).Item("UT_id"), String))
                TB_USU_cont.Text = Nothing
                TB_USU_usu.Text = Nothing
                USU_id = ds_usu.Tables(0).Rows(0).Item("USU_id")
                suc_id = ds_usu.Tables(0).Rows(0).Item("sucursal_id")
                suc_nom = ds_usu.Tables(0).Rows(0).Item("sucursal_nombre")

                '_directamente abre modulo administrador
                'US_administrador.Show()
                If USU_id = 3 Then
                    'US_administrador.Show() choco: 07-12-2019, antes si eras admin entrabas sin seleccionar terminal, pero eso da error en la validacion de la caja
                    Seleccion_Terminal.Show()
                Else
                    Seleccion_Terminal.Show()
                End If

                US_administrador.Configuracion(ds_usu)
                US_administrador.Label_Suc.Text = suc_nom
                APturno.TurnoIniciado_control(1)
                APcaja.Caja_Validar()

                '_____Case viejo de usarios_____________________

                'Select Case (UT_id)
                '    Case (1)
                '        tipo_usuario = "Administrador"
                '        US_administrador.Show()
                '        US_administrador.Configuracion(ds_usu)
                '        US_administrador.Label_Suc.Text = suc_nom
                '        APturno.TurnoIniciado_control(1)
                '        APcaja.Caja_Validar()
                '    Case (2)
                '        tipo_usuario = "Empleado"
                '        US_administrador.Show()
                '        US_administrador.Configuracion(ds_usu)
                '        US_administrador.Label_Suc.Text = suc_nom
                '        US_administrador.ToolStripDropDownButton4.Visible = False
                '        US_administrador.ToolStripDropDownButton7.Visible = False
                '        US_administrador.ToolStripDropDownButtonConfiguracion.Visible = False
                '        APturno.TurnoIniciado_control(2)
                '        APcaja.Caja_Validar()
                '    Case (3)
                '        US_Empleado_stock.Show()
                '        US_Empleado_stock.Configuracion(ds_usu)

                '        '    US_Deportes_admi.Show()
                '        '    US_Deportes_admi.Configuracion(ds_usu)
                '    Case (4)
                '        tipo_usuario = "Pedidos"
                '        US_Pedidos.Show()
                '        US_Pedidos.Configuracion(ds_usu)

                '        '        Entrada.Show()
                '        '        Entrada.Configuracion(ds_usu)
                '        '    Case (5)
                '        '        JuntaAdmin.Show()
                '        '        JuntaAdmin.Configuracion(ds_usu)
                '        '    Case (6)
                '        '        Salida.Show()
                '        '        Salida.Configuracion(ds_usu)
                '        '    Case Else
                '        '        '(accion en caso de que no se cumpla ningun anterior caso)
                'End Select
                LB_USU_inv.Visible = False
                IM_ERROR.Visible = False
            Else
                IM_ERROR.Visible = True
                LB_USU_inv.Visible = True
            End If
        End With
    End Sub

    Private Sub TB_USU_cont_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_USU_cont.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            sesion()
        End If
    End Sub



End Class