﻿Public Class Medico_Actualizar
    Dim daMedico As New Datos.Medico

    Dim busqueda As String = ""
    Dim busqueda_parametro As String = ""


   
    Private Sub Medico_Actualizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Obtener_Medicos()

    
    End Sub
    Dim ds_Med As DataSet
    Public Sub Obtener_Medicos()
        Medico_ds.Tables("Medicos").Rows.Clear() 'borro el contenido del dataset.datatable clientes
        ds_Med = daMedico.Medicos_Obtener_activos
        If ds_Med.Tables(0).Rows.Count <> 0 Then
            Medico_ds.Tables("Medicos").Merge(ds_Med.Tables(0)) '' al combinarla con el dataset "cliente" ya puedo filtrar
            'DG_clientes.DataSource = ds_clie.Tables(0)
            'DG_clientes_old.DataSource = ds_clie.Tables(0)
        End If
    End Sub

    Private Sub BO_cliente_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_modificar.Click
        If DG_Medico.Rows.Count <> 0 Then
            Dim productoselec As String = DG_Medico.SelectedCells(1).Value
            If productoselec <> "" Then
                Medico_Alta.Close() 'lo cierro porque uso el mismo form para dar de alta

                Medico_Alta.Text = "Modificar Medico"
                'Proveedor_alta.Text = "Modificar proveedor"
                Medico_Alta.Med_id = CInt(productoselec)
                'Proveedor_alta.proveedor_id = CInt(productoselec)
                Medico_Alta.form_procedencia = "modificar"
                'Cliente_alta_New.tx_ape.Text = DG_clientes.SelectedCells(1).Value
                'Proveedor_alta.tx_nombre.Text = DataGrid_proveedor.SelectedCells(2).Value
                Me.Close()
                Medico_Alta.apertura = "formulario modificar" 'para q valide el boton cancelar del form alta
                Medico_Alta.Show()
            Else
                MsgBox("Seleccione un Medico", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un Medico", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BO_cliente_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_cliente_nuevo.Click
        Me.Close()
        Medico_Alta.Close() 'lo cierro antes, porque uso el mismo form para editar
        Medico_Alta.apertura = "formulario modificar"
        Medico_Alta.Show()
    End Sub

    Private Sub btn_Anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Anular.Click
        Dim pregunta As String = "no" 'esta variable la uso para preg 1 sola vez si estoy seguro de eliminar los elementos seleccionados en la grilla.
        If DG_Medico.Rows.Count <> 0 Then
            Dim i As Integer = 0
            Dim valido As String = "si"


            If valido = "si" Then
                i = 0 'reinicio
                While i < DG_Medico.Rows.Count
                    If DG_Medico.Rows(i).Cells("Item").Value = True Then 'el value en true significa que esta checkeado para eliminar
                        If pregunta = "no" Then
                            If MsgBox("Esta seguro que quiere eliminar los medicos seleccionados?.", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                                pregunta = "si"
                            Else
                                'aqui corto el ciclo, ya que se cancelo la eliminacion
                                i = DG_Medico.Rows.Count
                            End If
                        End If
                        If pregunta = "si" Then
                            Dim medico_id As Integer = DG_Medico.CurrentRow.Cells("MedicoidDataGridViewTextBoxColumn").Value
                            daMedico.medico_eliminar_logico(medico_id)
                        End If
                    End If
                    i = i + 1
                End While



                Obtener_Medicos()


            End If
        End If
        If pregunta = "si" Then
            MessageBox.Show("La operación se realizó correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class
