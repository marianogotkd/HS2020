Public Class Sesiones_consulta_global
    Dim DAturno As New Datos.Turno
    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        lb_sesionespresentes.Text = "Sesiones presentes:"
        lb_sesionesausentes.Text = "Sesiones ausentes: "
        lb_sesionestotal.Text = "Total de sesiones: "


        Dim sesion As DataSet = DAturno.TurnoDialisis_consultar_sesiones_rangofecha(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)

        If sesion.Tables(0).Rows.Count <> 0 Then
            'voy a contar las sesiones
            Dim cant_presente As Integer = 0
            Dim cant_ausente As Integer = 0
            Dim i As Integer = 0
            While i < sesion.Tables(0).Rows.Count

                'Dim fila As DataRow = Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").NewRow
                'fila("Sesiones_id") = sesion.Tables(0).Rows(i).Item("Sesiones_id")
                'fila("PAC_id") = PAC_id
                'fila("Sesiones_fecha") = sesion.Tables(0).Rows(i).Item("Sesiones_fecha")
                ''fila("Dialisis_id") = 'para agregar esto hay q recorrer el table(1) de sesion
                'fila("Paciente") = sesion.Tables(0).Rows(i).Item("Paciente")
                'fila("PAc_dni") = sesion.Tables(0).Rows(i).Item("PAC_dni")
                'fila("PAc_dir") = sesion.Tables(0).Rows(i).Item("PAc_dir")
                'fila("PACnumafi") = sesion.Tables(0).Rows(i).Item("PACnumafi")
                'fila("Obrasocial_nombre") = sesion.Tables(0).Rows(i).Item("Obrasocial_nombre")
                'fila("Sesiones_asistencia") = sesion.Tables(0).Rows(i).Item("Sesiones_asistencia")
                If sesion.Tables(0).Rows(i).Item("Sesiones_asistencia") = "Presente" Then
                    cant_presente = cant_presente + 1
                Else
                    cant_ausente = cant_ausente + 1
                End If
                'Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").Rows.Add(fila)
                i = i + 1
            End While
            lb_sesionespresentes.Text = "Sesiones presentes: " + CStr(cant_presente)
            lb_sesionesausentes.Text = "Sesiones ausentes: " + CStr(cant_ausente)
            lb_sesionestotal.Text = "Total de sesiones: " + CStr(cant_ausente + cant_presente)
            Label4.Text = "Resultado de la búsqueda desde: " + DateTimePicker_desde.Value.Date + " hasta: " + DateTimePicker_hasta.Value.Date

            'recupero consumos
            sesiones_recuperar_consumos()
            'recuperar filtros
            recuperar_filtros_todos_rangofecha()

        Else
            Label4.Text = "Resultado de la búsqueda:"
            'Ds_consulta_bajas_b1.Tables("bajas").Rows.Clear()
            MessageBox.Show("La busqueda no arrojó resultados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If





    End Sub
    Dim DAsesiones As New Datos.Sesiones
    Private Sub sesiones_recuperar_consumos()
        Ds_enfermeria.Tables("insumos_consumidos").Rows.Clear()
        Dim total As Integer = 0
        Dim ds_consumos As DataSet = DAsesiones.Sesiones_recuperar_todos_consumos_rangofecha(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
        If ds_consumos.Tables(0).Rows.Count <> 0 Then
            Dim sumacantidad As Decimal = 0
            Dim i As Integer = 0
            Dim j As Integer
            While i < ds_consumos.Tables(0).Rows.Count
                Dim fila As DataRow = Ds_enfermeria.Tables("insumos_consumidos").NewRow
                fila("Consumo_mercaderia_id") = 0
                'fila("Fecha") = ds_mov.Tables(0).Rows(i).Item("prod_descripcion")
                'fila("Sesiones_id") = ""
                'fila("cantidad") = ""
                fila("prod_codinterno") = ds_consumos.Tables(0).Rows(i).Item("prod_codinterno")
                fila("Insumo") = ds_consumos.Tables(0).Rows(i).Item("Insumo")
                j = i
                Dim sumado = "si"
                While j < ds_consumos.Tables(0).Rows.Count
                    Dim codigo As Integer = ds_consumos.Tables(0).Rows(i).Item("prod_codinterno")
                    If ds_consumos.Tables(0).Rows(j).Item("prod_codinterno") = codigo Then
                        sumacantidad = sumacantidad + ds_consumos.Tables(0).Rows(j).Item("cantidad")
                        j = j + 1
                    Else
                        i = j
                        sumado = "no"
                        Exit While
                    End If
                End While
                fila("cantidad") = sumacantidad
                Ds_enfermeria.Tables("insumos_consumidos").Rows.Add(fila)
                sumacantidad = 0
                If sumado = "si" Then
                    i = j + 1
                End If
            End While

            'Ds_enfermeria.Tables("insumos_consumidos").Merge(ds_consumos.Tables(0))
            ''ahora cuento los insumos consumidos
            Dim k As Integer = 0
            While k < ds_consumos.Tables(0).Rows.Count
                total = total + CInt(ds_consumos.Tables(0).Rows(k).Item("cantidad"))
                k = k + 1
            End While
        End If
        lb_total_insumos.Text = "Total de insumos consumidos - sesiones presentes: " + CStr(total)



        Ds_enfermeria.Tables("insumos_consumidos_ausentes").Rows.Clear()

        Dim total_presentes As Integer = total
        total = 0

        If ds_consumos.Tables(1).Rows.Count <> 0 Then
            Dim sumacantidad As Decimal = 0
            Dim i As Integer = 0
            Dim j As Integer
            While i < ds_consumos.Tables(1).Rows.Count
                Dim fila As DataRow = Ds_enfermeria.Tables("insumos_consumidos_ausentes").NewRow
                fila("Consumo_mercaderia_id") = 0
                'fila("Fecha") = ds_mov.Tables(0).Rows(i).Item("prod_descripcion")
                'fila("Sesiones_id") = ""
                'fila("cantidad") = ""
                fila("prod_codinterno") = ds_consumos.Tables(1).Rows(i).Item("prod_codinterno")
                fila("Insumo") = ds_consumos.Tables(1).Rows(i).Item("Insumo")
                j = i
                Dim sumado = "si"
                While j < ds_consumos.Tables(1).Rows.Count
                    Dim codigo As Integer = ds_consumos.Tables(1).Rows(i).Item("prod_codinterno")
                    If ds_consumos.Tables(1).Rows(j).Item("prod_codinterno") = codigo Then
                        sumacantidad = sumacantidad + ds_consumos.Tables(1).Rows(j).Item("cantidad")
                        j = j + 1
                    Else
                        i = j
                        sumado = "no"
                        Exit While
                    End If
                End While
                fila("cantidad") = sumacantidad
                Ds_enfermeria.Tables("insumos_consumidos_ausentes").Rows.Add(fila)
                sumacantidad = 0
                If sumado = "si" Then
                    i = j + 1
                End If
            End While

            'Ds_enfermeria.Tables("insumos_consumidos").Merge(ds_consumos.Tables(0))
            ''ahora cuento los insumos consumidos
            Dim k As Integer = 0
            While k < ds_consumos.Tables(1).Rows.Count
                total = total + CInt(ds_consumos.Tables(1).Rows(k).Item("cantidad"))
                k = k + 1
            End While
        End If
        Dim total_ausentes As Integer = total
        Label8.Text = "Total de insumos consumidos - sesiones ausentes: " + CStr(total)
        Label9.Text = "Total general: " + CStr(total_presentes + total_ausentes)


        'oculto la primera columna para ambas tablas
        DataGridView1.Columns("ConsumomercaderiaidDataGridViewTextBoxColumn1").Visible = False 'sesiones ausentes
        DataGridView2.Columns("ConsumomercaderiaidDataGridViewTextBoxColumn").Visible = False 'sesiones presentes


    End Sub
    Dim daEnfermeria As New Datos.Enfermeria
    Private Sub recuperar_filtros_todos_rangofecha()
        Ln_totalreusos.Text = "Total de reusos:"
        Label1.Text = "Total de filtros:"
        Ds_enfermeria.Tables("filtros_x_paciente").Rows.Clear()
        Dim ds_filtro As DataSet = daEnfermeria.Filtro_obtener_todos_rangofecha(DateTimePicker_desde.Value.Date, DateTimePicker_hasta.Value.Date)
        If ds_filtro.Tables(0).Rows.Count <> 0 Then
            Ds_enfermeria.Tables("filtros_x_paciente").Merge(ds_filtro.Tables(0))
        Else
            Ds_enfermeria.Tables("filtros_x_paciente").Rows.Clear()
        End If
        Dim total As Integer = 0
        Dim k As Integer = 0
        Dim primero As String = "si"
        Dim cantfiltro As Integer = 0
        Dim filtro_id As Integer = 0
        While k < ds_filtro.Tables(0).Rows.Count
            total = total + CInt(ds_filtro.Tables(0).Rows(k).Item("Filtro_cant_reuso"))
            If primero = "si" Then
                cantfiltro = 1
                filtro_id = ds_filtro.Tables(0).Rows(k).Item("Filtro_id")
                primero = "no"
            Else
                If ds_filtro.Tables(0).Rows(k).Item("Filtro_id") <> filtro_id Then
                    cantfiltro = cantfiltro + 1
                    filtro_id = ds_filtro.Tables(0).Rows(k).Item("Filtro_id")
                End If
            End If
            k = k + 1
        End While
        Ln_totalreusos.Text = "Total de reusos: " + CStr(total)
        Label1.Text = "Total de filtros: " + Str(cantfiltro)
    End Sub


    Private Sub Sesiones_consulta_global_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class