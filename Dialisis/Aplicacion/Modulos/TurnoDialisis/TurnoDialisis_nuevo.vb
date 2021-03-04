Public Class TurnoDialisis_nuevo
    Dim DAturno As New Datos.Turno
    Public turno_procedencia As String = "alta"
    Public turnodialisis_id As Integer

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click

        If turno_procedencia = "alta" Then
            alta()
        Else
            modificar()
        End If



        
        
    End Sub

    Private Sub modificar()
        If txt_desc.Text <> "" Then
            If lunes.Checked = False And martes.Checked = False And miercoles.Checked = False And jueves.Checked = False And viernes.Checked = False And sabado.Checked = False And domingo.Checked = False Then
                MessageBox.Show("Error, debe seleccionar al menos un dia de la semana.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult
                result = MessageBox.Show("¿Desea modificar el turno actual?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    'primero guardo el turno
                    'Dim desde_hora As String = CStr(desde_hora.Value) + ":" + CStr(desde_min.Value)
                    'Dim hasta As String = CStr(hasta_hora.Value) + ":" + CStr(hasta_min.Value)
                    DAturno.Turnodialisis_modificar(turnodialisis_id, txt_desc.Text, CStr(desde_hora.Value), CStr(desde_min.Value), CStr(hasta_hora.Value), CStr(hasta_min.Value))
                    'primero elimino todos los dias
                    DAturno.Turnodialisis_eliminar_dias(turnodialisis_id)

                    'ahora guardo los dias
                    If lunes.Checked = True Then
                        DAturno.Dias_dialisis_alta("Lunes", turnodialisis_id)
                    End If
                    If martes.Checked = True Then
                        DAturno.Dias_dialisis_alta("Martes", turnodialisis_id)
                    End If
                    If miercoles.Checked = True Then
                        DAturno.Dias_dialisis_alta("Miércoles", turnodialisis_id)
                    End If
                    If jueves.Checked = True Then
                        DAturno.Dias_dialisis_alta("Jueves", turnodialisis_id)
                    End If
                    If viernes.Checked = True Then
                        DAturno.Dias_dialisis_alta("Viernes", turnodialisis_id)
                    End If
                    If sabado.Checked = True Then
                        DAturno.Dias_dialisis_alta("Sábado", turnodialisis_id)
                    End If
                    If domingo.Checked = True Then
                        DAturno.Dias_dialisis_alta("Domingo", turnodialisis_id)
                    End If
                    MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión", MessageBoxButtons.OK)

                    'aqui abro turnodialisis_modificar
                    TurnoDialisis_modificar.Close()
                    TurnoDialisis_modificar.Show()
                    Me.Close()
                End If

            End If

        Else
            MessageBox.Show("Error, debe ingresar descripción del turno.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub alta()
        If txt_desc.Text <> "" Then
            If lunes.Checked = False And martes.Checked = False And miercoles.Checked = False And jueves.Checked = False And viernes.Checked = False And sabado.Checked = False And domingo.Checked = False Then
                MessageBox.Show("Error, debe seleccionar al menos un dia de la semana.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult
                result = MessageBox.Show("¿Desea generar este turno?.", "Sistema de Gestión.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    'valido que no exista un turno con ese nombre

                    Dim ds_validar As DataSet = DAturno.Turnodialisis_validar_nombre(txt_desc.Text)
                    If ds_validar.Tables(0).Rows.Count = 0 Then

                        'Dim desde_hora As String = CStr(desde_hora.Value) + ":" + CStr(desde_min.Value)
                        'Dim hasta As String = CStr(hasta_hora.Value) + ":" + CStr(hasta_min.Value)

                        Dim ds_turno As DataSet = DAturno.Turnodialisis_alta(txt_desc.Text, CStr(desde_hora.Value), CStr(desde_min.Value), CStr(hasta_hora.Value), CStr(hasta_min.Value))
                        Dim turnodialisis_id As Integer = ds_turno.Tables(0).Rows(0).Item(0)
                        'ahora guardo los dias
                        If lunes.Checked = True Then
                            DAturno.Dias_dialisis_alta("Lunes", turnodialisis_id)
                        End If
                        If martes.Checked = True Then
                            DAturno.Dias_dialisis_alta("Martes", turnodialisis_id)
                        End If
                        If miercoles.Checked = True Then
                            DAturno.Dias_dialisis_alta("Miércoles", turnodialisis_id)
                        End If
                        If jueves.Checked = True Then
                            DAturno.Dias_dialisis_alta("Jueves", turnodialisis_id)
                        End If
                        If viernes.Checked = True Then
                            DAturno.Dias_dialisis_alta("Viernes", turnodialisis_id)
                        End If
                        If sabado.Checked = True Then
                            DAturno.Dias_dialisis_alta("Sábado", turnodialisis_id)
                        End If
                        If domingo.Checked = True Then
                            DAturno.Dias_dialisis_alta("Domingo", turnodialisis_id)
                        End If
                        MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión", MessageBoxButtons.OK)
                        Me.Close()
                    Else
                        MessageBox.Show("Ya existe un turno con ese nombre, modifique por favor.", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If

        Else
                MessageBox.Show("Error, debe ingresar descripción del turno.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub TurnoDialisis_nuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If turno_procedencia = "modificar" Then
            recuperar_info()
        End If
    End Sub

    Private Sub limpiar_check()
        lunes.Checked = False
        martes.Checked = False
        miercoles.Checked = False
        jueves.Checked = False
        viernes.Checked = False
        sabado.Checked = False
        domingo.Checked = False
    End Sub


    Private Sub recuperar_info()
        Dim ds_turno As DataSet = DAturno.Turnodialisis_obtener_info(turnodialisis_id)
        If ds_turno.Tables(0).Rows.Count <> 0 Then
            txt_desc.Text = ds_turno.Tables(0).Rows(0).Item("Turnodialisis_desc")
            If txt_desc.Text = "Dialisis de Calle" Then
                txt_desc.ReadOnly = True
            End If

            desde_hora.Value = CInt(ds_turno.Tables(0).Rows(0).Item("Turnodialisis_desde_hora"))
            desde_min.Value = CInt(ds_turno.Tables(0).Rows(0).Item("Turnodialisis_desde_minutos"))
            hasta_hora.Value = CInt(ds_turno.Tables(0).Rows(0).Item("Turnodialisis_hasta_hora"))
            hasta_min.Value = CInt(ds_turno.Tables(0).Rows(0).Item("Turnodialisis_hasta_minutos"))
            'ahora los dias chequeados
            limpiar_check()
            Dim i As Integer = 0
            While i < ds_turno.Tables(1).Rows.Count
                Select Case ds_turno.Tables(1).Rows(i).Item("Dias_desc")
                    Case "Lunes"
                        lunes.Checked = True
                    Case "Martes"
                        martes.Checked = True
                    Case "Miércoles"
                        miercoles.Checked = True
                    Case "Jueves"
                        jueves.Checked = True
                    Case "Viernes"
                        viernes.Checked = True
                    Case "Sábado"
                        sabado.Checked = True
                    Case "Domingo"
                        domingo.Checked = True
                End Select
                i = i + 1
            End While

        Else
            MessageBox.Show("Error inesperado, no se encuentra el ID del turno.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If


    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        limpiar_check()
        txt_desc.Clear()
        desde_hora.Value = 0
        desde_min.Value = 0
        hasta_hora.Value = 0
        hasta_min.Value = 0
        If turno_procedencia = "modificar" Then
            TurnoDialisis_modificar.Close()
            TurnoDialisis_modificar.Show()
            Me.Close()
        End If

    End Sub
End Class