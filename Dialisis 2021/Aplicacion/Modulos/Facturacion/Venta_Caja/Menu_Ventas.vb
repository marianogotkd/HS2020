Public Class Menu_Ventas
    Dim DAcliente As New Datos.Cliente
    Dim DAlista As New Datos.Lista
    Dim DAventa As New Datos.Venta
    Dim DAproducto As New Datos.Producto


    Public Sub llamar_Form(ByVal var, ByVal form_anterior)
        If (US_administrador.PN_Entrada.Controls.Count > 0) Then
            US_administrador.PN_Entrada.Controls.RemoveAt(0)
            If form_anterior.ToString <> var.ToString Then
                form_anterior.close()
            End If
            var.TopLevel = False
            var.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            var.Dock = DockStyle.Fill
            US_administrador.PN_Entrada.Controls.Add(var)
            US_administrador.PN_Entrada.Tag = var
            form_anterior = var
            var.Show()
        Else
            var.TopLevel = False
            var.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            var.Dock = DockStyle.Fill
            US_administrador.PN_Entrada.Controls.Add(var)
            US_administrador.PN_Entrada.Tag = var
            form_anterior = var
            var.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        llamar_Form(Cliente_alta, Me)
    End Sub

    Private Sub Menu_Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()

        'recupero todos los clientes de la bd
        Call Obtener_Clientes()
    End Sub

    Dim ds_clie As DataSet
    'recupero todos los clientes
    Public Sub Obtener_Clientes()
        ds_clie = DAcliente.Cliente_obtenertodo()
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            DG_clientes.DataSource = ds_clie.Tables(0)
        End If
    End Sub


End Class