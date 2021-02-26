Public Class Sesion_pacientes
    Public turno_id As Integer

    Dim DAsesiones As New Datos.Sesiones
    Dim DAturno As New Datos.Turno
    Dim fecha_registrar As Date
    Dim daenfermeria As New Datos.Enfermeria

    Public sucursal_id As Integer 'me lo envia el formulario Turno_seleccionar para saber donde restar stock

    Private Sub Sesion_pacientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'lb_sesionfecha.Text = "Sesion del dia: " + CStr(Today)

        fecha.Value = Today
        fecha.MaxDate = Today
        recuperar_pacientes_fecha_del_dia(fecha.Value)
    End Sub


    Public Sub recuperar_pacientes_fecha_del_dia(ByVal fecha As Date)

        Dim ds_inscriptos As DataSet = DAturno.TurnoDialisis_consultar_inscriptos(turno_id)
        Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").Rows.Clear() 'siempre borrar antes de cargar
        If ds_inscriptos.Tables(0).Rows.Count <> 0 Then
            'supongo que siempre hay inscriptos.
            'ahora agarro cada inscripto y lo busco en la tabla de sesion
            Dim i As Integer = 0
            While i < ds_inscriptos.Tables(0).Rows.Count
                Dim PAC_id As Integer = ds_inscriptos.Tables(0).Rows(i).Item("PAC_id")
                'ahora lo busco en tabla sesion
                Dim sesion As DataSet = DAturno.TurnoDialisis_consultar_sesion(PAC_id, fecha)
                If sesion.Tables(0).Rows.Count <> 0 Then
                    'quiere decir q registre asistencia
                    Dim fila As DataRow = Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").NewRow
                    fila("Sesiones_id") = sesion.Tables(0).Rows(0).Item("Sesiones_id")
                    fila("PAC_id") = PAC_id
                    fila("Sesiones_fecha") = sesion.Tables(0).Rows(0).Item("Sesiones_fecha")
                    'fila("Dialisis_id") = 'para agregar esto hay q recorrer el table(1) de sesion
                    fila("Paciente") = sesion.Tables(0).Rows(0).Item("Paciente")
                    fila("PAc_dni") = sesion.Tables(0).Rows(0).Item("PAC_dni")
                    fila("PAc_dir") = sesion.Tables(0).Rows(0).Item("PAc_dir")
                    fila("PACnumafi") = sesion.Tables(0).Rows(0).Item("PACnumafi")
                    fila("Obrasocial_nombre") = sesion.Tables(0).Rows(0).Item("Obrasocial_nombre")
                    fila("Sesiones_asistencia") = sesion.Tables(0).Rows(0).Item("Sesiones_asistencia")
                    fila("Estado_sesion") = sesion.Tables(0).Rows(0).Item("Sesiones_estado")
                    Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").Rows.Add(fila)
                Else
                    'quiere decir q no registre asistencia.
                    'lo cargo en la grilla con la columna asistenca en vacio.
                    Dim fila As DataRow = Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").NewRow
                    'fila("Sesiones_id") = ""
                    fila("PAC_id") = PAC_id
                    'fila("Sesiones_fecha") = ""
                    'fila("Dialisis_id") = ""
                    fila("Paciente") = ds_inscriptos.Tables(0).Rows(i).Item("PAC_ape") + ", " + ds_inscriptos.Tables(0).Rows(i).Item("PAC_nom")
                    fila("PAc_dni") = ds_inscriptos.Tables(0).Rows(i).Item("PAC_dni")
                    fila("PAc_dir") = ds_inscriptos.Tables(0).Rows(i).Item("PAC_dir")
                    fila("PACnumafi") = ds_inscriptos.Tables(0).Rows(i).Item("PACnumafi")
                    fila("Obrasocial_nombre") = ds_inscriptos.Tables(0).Rows(i).Item("Obrasocial_nombre")
                    fila("Sesiones_asistencia") = ""
                    fila("Estado_sesion") = ""
                    Ds_enfermeria.Tables("Sesion_actual_todos_pacientes").Rows.Add(fila)
                End If
                i = i + 1
            End While



        End If
        Label1.Text = "Pacientes para la sesion del dia: " + CStr(fecha)
        fecha_registrar = fecha

    End Sub


    Private Sub btn_ausente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ausente.Click

        If datagridview1.Rows.Count <> 0 Then
            Dim PAC_id As Integer = CInt(datagridview1.CurrentRow.Cells("PACidDataGridViewTextBoxColumn").Value)
            'aqui va pregunta para registrar como ausente.
            '
            'hay q hacer un alta alta en la tabla sesiones
            Dim result As Integer = MessageBox.Show("¿Desea registrar como AUSENTE al paciente: " + datagridview1.CurrentRow.Cells("PacienteDataGridViewTextBoxColumn").Value + " para la sesion del dia " + fecha_registrar + "?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If CStr(datagridview1.CurrentRow.Cells("SesionesasistenciaDataGridViewTextBoxColumn").Value) = "" Then

                    Dim ds_sesiones As DataSet = DAsesiones.sesiones_alta(PAC_id, fecha_registrar, "Ausente", "Ausente", sucursal_id) 'mando el parametro fecha_registrar porque es la que tiene el resultado de la busqueda, es decir lo que se esta mostrando en la grilla
                    Dim sesiones_id = ds_sesiones.Tables(0).Rows(0).Item(0)

                    'Dim result2 As Integer = MessageBox.Show("¿El Filtro del paciente fue utilizado?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    'If result2 = DialogResult.Yes Then

                    '    Dim cantReuso As Integer
                    '    Dim FiltroDS As DataSet = daenfermeria.Filtro_Obtener_X_PAC(PAC_id)

                    '    If FiltroDS.Tables(0).Rows.Count <> 0 Then
                    '        cantReuso = FiltroDS.Tables(0).Rows(0).Item("Filtro_cant_reuso") + 1
                    '        daenfermeria.Filtro_modificar_Cant(FiltroDS.Tables(0).Rows(0).Item("Filtro_id"), cantReuso)
                    '    End If

                    'End If
                    Dim result3 As Integer = MessageBox.Show("¿Desea registrar otros consumos?", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result3 = DialogResult.Yes Then
                        Enfermeria_insumos_Ausente.Close()
                        Enfermeria_insumos_Ausente.PAC_id = PAC_id
                        Enfermeria_insumos_Ausente.sesiones_id = sesiones_id
                        Enfermeria_insumos_Ausente.fecha_registrar = fecha_registrar
                        Enfermeria_insumos_Ausente.sucursal_id = sucursal_id
                        Enfermeria_insumos_Ausente.Text = "Paciente: " + datagridview1.CurrentRow.Cells("PacienteDataGridViewTextBoxColumn").Value + ". - Consumir Filtro e Insumos."
                        Enfermeria_insumos_Ausente.Show()
                    Else
                        Msje_OK()
                    End If
                    recuperar_pacientes_fecha_del_dia(fecha_registrar)
                Else
                    'ya esta registrado
                    MessageBox.Show("Ya se encuentra registrada la asistencia para el paciente:" + datagridview1.CurrentRow.Cells("PacienteDataGridViewTextBoxColumn").Value + ".", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If


    End Sub

    Public Sub Msje_OK()
        MessageBox.Show("La información se registró correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Turno_seleccionar.Show() 'lo muestro, x que estaba oculto
        'Turno_seleccionar.Close() 'el formulario de la carpeta enfermeria
        'Turno_seleccionar.Show() 'el formulario de la carpeta enfermeria
        Me.Close()
    End Sub

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        msj_esperar_sesiones.procedencia = "sesion_pacientes"
        msj_esperar_sesiones.fecha = fecha.Value
        msj_esperar_sesiones.Show()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If datagridview1.Rows.Count <> 0 Then
            Dim form_registro As New Sesion_registro_x_paciente
            form_registro.PAC_id = datagridview1.CurrentRow.Cells("PACidDataGridViewTextBoxColumn").Value
            form_registro.Show()
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If datagridview1.Rows.Count <> 0 Then
            'aqui va pregunta para registrar como PRESENTE.
            'hay q hacer un alta alta en la tabla sesiones

            If CStr(datagridview1.CurrentRow.Cells("SesionesasistenciaDataGridViewTextBoxColumn").Value) = "" Then
                Dim result As Integer = MessageBox.Show("¿Desea registrar como PRESENTE al paciente: " + datagridview1.CurrentRow.Cells("PacienteDataGridViewTextBoxColumn").Value + " para la sesion del dia " + fecha_registrar + "?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Nueva_Dialisis.Close()
                    Dim PAC_id As Integer = CInt(datagridview1.CurrentRow.Cells("PACidDataGridViewTextBoxColumn").Value)
                    Nueva_Dialisis.PAC_id = PAC_id
                    Nueva_Dialisis.fecha_registrar = fecha_registrar

                    Nueva_Dialisis.sucursal_id = sucursal_id 'puede ser 3 o 5, dependiendo en el turno q esté.

                    Nueva_Dialisis.Show()

                    '---Mariano 6-9-20 Esto lo hago en el form de dialisis

                    'Dim ds_sesiones As DataSet = DAsesiones.sesiones_alta(PAC_id, fecha_registrar, "Presente") 'mando el parametro fecha_registrar porque es la que tiene el resultado de la busqueda, es decir lo que se esta mostrando en la grilla
                    'Dim sesiones_id As Integer = ds_sesiones.Tables(0).Rows(0).Item(0) 'este recupera el id del q acabo de insertar
                    'recuperar_pacientes_fecha_del_dia(fecha_registrar)
                    'MessageBox.Show("La información se registró correctamente. con ID DE SESION_ID: " + CStr(sesiones_id), "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    '--------------------------------------------
                End If



            Else
                If CStr(datagridview1.CurrentRow.Cells("SesionesasistenciaDataGridViewTextBoxColumn").Value) = "Presente" Then
                    'Dim result As Integer = MessageBox.Show("Esta seguro que desea modificar los datos de la sesión de diálisis", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    'If result = DialogResult.Yes Then
                    'aqui como esta presente, lo que hago es ir a el modulo de dialisis para modificar la info.
                    'el id de sesiones_id lo tomo de la grilla
                    'MessageBox.Show("Aqui voy a modificar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sesiones_id As Integer = CInt(datagridview1.CurrentRow.Cells("SesionesidDataGridViewTextBoxColumn").Value)
                    Nueva_Dialisis.Close()
                    Dim PAC_id As Integer = CInt(datagridview1.CurrentRow.Cells("PACidDataGridViewTextBoxColumn").Value)
                    Nueva_Dialisis.PAC_id = PAC_id
                    Nueva_Dialisis.fecha_registrar = fecha_registrar
                    Nueva_Dialisis.tipo_operacion = "modificar presente" 'aviso q ya estaba cargado como ausente, y que se va a modificar dicho estado
                    'Dim sesiones_id As Integer = CInt(datagridview1.CurrentRow.Cells("SesionesidDataGridViewTextBoxColumn").Value)
                    Nueva_Dialisis.modificar_sesiones_id = sesiones_id
                    Nueva_Dialisis.Show()
                    'Else

                    'End If


                Else
                    MessageBox.Show("El paciente: " + datagridview1.CurrentRow.Cells("PacienteDataGridViewTextBoxColumn").Value + " ya se encuentra registrado como AUSENTE. NO SE PUEDE MODIFICAR SU ESTADO", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Warning)



                    'ya esta registrado como Ausente.
                    'Dim result2 As Integer = MessageBox.Show("El paciente: " + datagridview1.CurrentRow.Cells("PacienteDataGridViewTextBoxColumn").Value + " ya se encuentra registrado como AUSENTE. ¿Desea cargarlo como PRESENTE para la sesion del dia " + fecha_registrar + "?.", "Sistema de Gestión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    'If result2 = DialogResult.Yes Then
                    '    'aqui viene una especie de UPDATE para pasarlo a presente.

                    '    Nueva_Dialisis.Close()
                    '    Dim PAC_id As Integer = CInt(datagridview1.CurrentRow.Cells("PACidDataGridViewTextBoxColumn").Value)
                    '    Nueva_Dialisis.PAC_id = PAC_id
                    '    Nueva_Dialisis.fecha_registrar = fecha_registrar
                    '    Nueva_Dialisis.tipo_operacion = "ausente" 'aviso q ya estaba cargado como ausente, y que se va a modificar dicho estado
                    '    Dim sesiones_id As Integer = CInt(datagridview1.CurrentRow.Cells("SesionesidDataGridViewTextBoxColumn").Value)
                    '    Nueva_Dialisis.ausente_sesiones_id = sesiones_id
                    '    Nueva_Dialisis.Show()
                    'End If
                End If
            End If

        End If


    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "Paciente", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        SesionactualtodospacientesBindingSource.Filter = Filtro
        'Cliente1BindingSource.Filter = Filtro        
        If datagridview1.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(PAC_dni, System.String) LIKE '%{0}%'", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
            SesionactualtodospacientesBindingSource.Filter = Filtro
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub datagridview1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles datagridview1.CellFormatting

        If datagridview1.Columns(e.ColumnIndex).Name = "Estado_sesion" Then
            If e.Value.ToString <> "" Then
                If e.Value = "Conectado" Then
                    e.CellStyle.ForeColor = Color.Green
                    e.CellStyle.SelectionForeColor = Color.Green
                End If
                If e.Value = "Finalizado" Then
                    e.CellStyle.ForeColor = Color.Blue
                    e.CellStyle.SelectionForeColor = Color.Blue
                End If
                If e.Value = "Ausente" Then
                    e.CellStyle.ForeColor = Color.Red
                    e.CellStyle.SelectionForeColor = Color.Red
                End If
            End If
        End If
    End Sub
End Class