Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Menu_2020
    Dim DAterminal As New Datos.Terminal
    'Cambiar contraseña
    Public USU_id As String
    Dim USU_contr As String

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub


    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cerrar el Sistema?", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Me.Close()
            Seleccion_menu.Close()
        End If
    End Sub

    Private Sub btn_maximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_maximizar.Click
        btn_maximizar.Visible = False
        btn_restaurar.Visible = True
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
    End Sub

    Private Sub btn_restaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_restaurar.Click
        btn_restaurar.Visible = False
        btn_maximizar.Visible = True
        Me.WindowState = Windows.Forms.FormWindowState.Normal
    End Sub

    Private Sub btn_minimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimizar.Click
        Me.WindowState = Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub PanelCabecera_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOcultarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 80 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 35
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 35
        End If
    End Sub

    Private Sub btn_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        If PanelMenu.Width = 220 Then
            tmOcultarMenu.Enabled = True
            'REDIMENSIONO TOOPTRIP ITEMS
            'achico
            Label_leyenda.Visible = False
            menu_paciente.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            menu_paciente.Width = 70
            menu_stock.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            menu_stock.Width = 70
            menu_medicos.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            menu_medicos.Width = 70
            menu_reportes.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            menu_reportes.Width = 70
            menu_usuarios.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            menu_usuarios.Width = 70
            ToolStrip2.Width = 70
        ElseIf PanelMenu.Width = 80 Then
            tmMostrarMenu.Enabled = True
            'REDIMENSIONO TOOLTRIP ITEMS
            'agrando
            Label_leyenda.Visible = True
            menu_paciente.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            menu_paciente.Width = 200
            menu_stock.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            menu_stock.Width = 200
            menu_medicos.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            menu_medicos.Width = 200
            menu_reportes.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            menu_reportes.Width = 200
            menu_usuarios.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            menu_usuarios.Width = 200
            ToolStrip2.Width = 200
        End If
    End Sub

    Private Sub AbrirFormEnPanel(ByVal FormHijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(FormHijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub NuevoPacienteToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoPacienteToolStripMenuItem.Click
        'AbrirFormEnPanel(Cliente_alta_New)
        Cliente_alta_New.Show()
    End Sub

    Public Sub Configuracion(ByVal ds_usu As DataSet)
        LB_USU_ape.Text = (CType(ds_usu.Tables(0).Rows(0).Item("USU_ape"), String)) + " " + (CType(ds_usu.Tables(0).Rows(0).Item("USU_nom"), String))
        LB_UT_dep.Text = (CType(ds_usu.Tables(0).Rows(0).Item("UT_desc"), String))
        USU_id = (CType(ds_usu.Tables(0).Rows(0).Item("USU_id"), String))
        USU_contr = (CType(ds_usu.Tables(0).Rows(0).Item("USU_cont"), String))
        Seleccion_menu.Visible = False 'que era Inicio.vb anteriormente
    End Sub

    Private Sub BO_USU_sesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_sesion.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea Cerrar la Sesion de Usuario?", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            'cierro todos los form que quedaron abiertos.
            For i = System.Windows.Forms.Application.OpenForms.Count - 1 To 1 Step -1
                Dim form As Form = System.Windows.Forms.Application.OpenForms(i)
                If form.Name <> "Seleccion_menu" Then
                    form.Close()
                End If
            Next i
            'elimino la relacion de usuario con terminal
            DAterminal.Usuario_x_Terminal_eliminar(Seleccion_menu.terminal_id)
            Me.Close()
            Seleccion_menu.Visible = True
        End If
    End Sub

    Private Sub BO_USU_contrasena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_USU_contrasena.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea cambiar la Contraseña de Usuario?", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            USU_contrasena.Usuario_Datos(USU_id, USU_contr)
            USU_contrasena.Show()
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Producto_alta_New.Show()
        Producto_alta_New.tx_descripcion.Focus()
    End Sub

    Private Sub StockYActualizacionDeInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockYActualizacionDeInfoToolStripMenuItem.Click
        Producto_modificar.Show()
    End Sub

    Private Sub GestionarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarToolStripMenuItem.Click
        Gestion_Mercaderia.Close()
        Gestion_Mercaderia.Show()
    End Sub
End Class