Imports System.IO
Imports System.Data.OleDb
Public Class Empresa_Modificar
    Dim DAempresa As New Datos.Empresa
    Dim DS_empresa As New Empresa_DS

    Private Sub Empresa_Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Empresa_obtener()

    End Sub
    Public Sub Empresa_obtener()
        DS_empresa.Tables("empresa").Clear()
        Dim DS As DataSet = DAempresa.empresa_obtener

        DS_empresa.Tables("empresa").Merge(DS.Tables(0))


        DG_Empresa.DataSource = DS_empresa.Tables("empresa")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Empresa.Close()
        Empresa.Show()
    End Sub

    Private Sub BO_producto_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_producto_modificar.Click
        If DG_Empresa.Rows.Count <> 0 Then
            Dim empresaselec As String = DG_Empresa.SelectedCells(0).Value
            If empresaselec <> "" Then
                Empresa.Close() 'lo cierro porque uso el mismo form para dar de alta
                Empresa.Text = "Actualizar Empresa"
                Empresa.empresa_ID = DG_Empresa.SelectedCells(0).Value
                Me.Close() 'cierro este modulo, cuando actualizo lo vuelvo a abrir
                Empresa.Show()
                'Cliente_alta_New.form_procedencia = "modificar"
            Else
                MessageBox.Show("Seleccione una empresa.", "Sistema de Gestión")
            End If
        Else
            MessageBox.Show("Seleccione una empresa.", "Sistema de Gestión")
        End If
    End Sub
End Class