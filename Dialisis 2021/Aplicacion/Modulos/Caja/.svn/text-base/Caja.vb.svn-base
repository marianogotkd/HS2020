Public Class Caja

    Dim DAcaja As New Datos.Caja

    Dim DAusuario As New Datos.Usuario

    Public SESION_CAJA As Integer

    Public Sub Caja_Validar()
        US_administrador.no_caja = ""
        'Dim ds_caja As DataSet = DAcaja.Caja_validad_AperturayCierre(Inicio.suc_id)
        Dim ds_caja As DataSet = DAcaja.Caja_validad_Apertura(Inicio.suc_id, Inicio.USU_id, Inicio.terminal_id)

        '--------------------------------------------------------------------------------------
        'guardo en una variable la ID del turno, esto es necesario cuando hago las ventas, ingresos, egresos y servicios. para ello cuando se encuentre un turno activo en la terminal se recupera dicho ID
        If ds_caja.Tables(0).Rows.Count <> 0 Then
            US_administrador.TurnoUsuario_id = ds_caja.Tables(0).Rows(0).Item("TurnoUsuario_id")
        End If
        '-------------------------------------------------------------------------------------------

        If ds_caja.Tables(0).Rows.Count = 0 Then
            'No Existe turno abierto para ese usuario, OJO LA CAJA PUEDE ESTAR ABIERTA PERO CON OTRA TERMINAL   
            SESION_CAJA = 1
            US_administrador.Btn_corte_caja.Visible = False
        Else
            If ds_caja.Tables(0).Rows(0).Item("USU_id") = Inicio.USU_id Then
                Dim S As Integer = 0
                Dim B As Integer = 0
                While B < ds_caja.Tables(0).Rows.Count
                    Dim suc_id As Integer = ds_caja.Tables(0).Rows(B).Item("suc_id").ToString
                    If suc_id = Inicio.suc_id Then
                        Inicio.CAJA_id = ds_caja.Tables(0).Rows(B).Item("CAJA_id").ToString
                        S = 1
                    End If
                    B = B + 1
                End While
                If S = 1 Then
                    SESION_CAJA = 2
                    US_administrador.Btn_corte_caja.Visible = True
                Else
                    SESION_CAJA = 3
                End If
            Else
                US_administrador.no_caja = "deshabilitar" 'pongo en deshabilitar para q el usuario actual no pueda abrir una caja, ni cerrarla ni vender etc.
                US_administrador.apellidoynombre = ds_caja.Tables(0).Rows(0).Item("ApellidoyNombre")
            End If



        End If

        Select Case (SESION_CAJA)
            Case (1)
                Dim Ruta As String = Application.StartupPath & "\..\..\\Resources\Caja.png"
                US_administrador.BO_Caja.Image = Image.FromFile(Ruta)
                US_Empleado.BO_Caja.Image = Image.FromFile(Ruta)

                US_administrador.ToolStripDropDownButton6.Enabled = True   'boton de ventas  ADMINISTRADOR
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = False   'venta en caja
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnMesas2ToolStripMenuItem").Enabled = False  'venta en mesas
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentasConsultasToolStripMenuItem").Enabled = True  'venta consulta
                'boton Servicios desabilitado por caja cerrada
                US_administrador.ToolStripDropDownButtonServicios.DropDownItems("ToolStripMenuItem_servicio_nuevo").Enabled = False 'servicio alta
                US_administrador.ToolStripDropDownButtonServicios.DropDownItems("ToolStripMenuItem3").Enabled = False
                US_Empleado.ToolStripDropDownButton6.Enabled = True   'boton de ventas  EMPLEADO
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = False   'venta en caja
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnMesasToolStripMenuItem").Enabled = False  'venta en mesas
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaConsultaToolStripMenuItem").Enabled = True  'venta consulta
                US_administrador.ToolStripDropDownButtonServicios.DropDownItems("ToolStripMenuItem_servicio_nuevo").Enabled = False
                US_administrador.TurnoGestionToolStripMenuItem.Enabled = False
                US_administrador.TurnoFijoNuevoToolStripMenuItem.Enabled = False
                US_administrador.TurnoComunNuevoToolStripMenuItem.Enabled = False
                US_Empleado.TurnoGestionToolStripMenuItem.Enabled = False
                US_Empleado.TurnoFijoNuevoToolStripMenuItem1.Enabled = False
                US_Empleado.TurnoComunNuevoToolStripMenuItem.Enabled = False
            Case (2)
                Dim Ruta As String = Application.StartupPath & "\..\..\\Resources\CajaAbierta.png"
                US_administrador.BO_Caja.Image = Image.FromFile(Ruta)
                US_Empleado.BO_Caja.Image = Image.FromFile(Ruta)

                US_administrador.ToolStripDropDownButton6.Enabled = True
                US_Empleado.ToolStripDropDownButton6.Enabled = True



                US_administrador.ToolStripDropDownButton6.Enabled = True   'boton de ventas  ADMINISTRADOR
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = True    'venta en caja
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnMesas2ToolStripMenuItem").Enabled = True   'venta en mesas
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentasConsultasToolStripMenuItem").Enabled = True   'venta consulta

                US_administrador.ToolStripDropDownButtonServicios.DropDownItems("ToolStripMenuItem_servicio_nuevo").Enabled = True 'servicio alta
                US_administrador.ToolStripDropDownButtonServicios.DropDownItems("ToolStripMenuItem3").Enabled = True


                US_Empleado.ToolStripDropDownButton6.Enabled = True   'boton de ventas EMPLEADO
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = True    'venta en caja
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnMesasToolStripMenuItem").Enabled = True   'venta en mesas
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaConsultaToolStripMenuItem").Enabled = True   'venta consulta

                US_administrador.TurnoGestionToolStripMenuItem.Enabled = True
                US_administrador.TurnoFijoNuevoToolStripMenuItem.Enabled = True
                US_administrador.TurnoComunNuevoToolStripMenuItem.Enabled = True

                US_Empleado.TurnoGestionToolStripMenuItem.Enabled = True
                US_Empleado.TurnoFijoNuevoToolStripMenuItem1.Enabled = True
                US_Empleado.TurnoComunNuevoToolStripMenuItem.Enabled = True
            Case (3)
                Dim Ruta As String = Application.StartupPath & "\..\..\\Resources\CajaCerrada.png"
                US_administrador.BO_Caja.Image = Image.FromFile(Ruta)
                US_Empleado.BO_Caja.Image = Image.FromFile(Ruta)

                US_administrador.ToolStripDropDownButton6.Enabled = False
                US_Empleado.ToolStripDropDownButton6.Enabled = False


                US_administrador.ToolStripDropDownButton6.Enabled = True   'boton de ventas  ADMINISTRADOR
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = False   'venta en caja
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentaEnMesas2ToolStripMenuItem").Enabled = False  'venta en mesas
                US_administrador.ToolStripDropDownButton6.DropDownItems("VentasConsultasToolStripMenuItem").Enabled = True  'venta consulta

                US_administrador.ToolStripDropDownButtonServicios.DropDownItems("ToolStripMenuItem_servicio_nuevo").Enabled = False 'servicio alta
                US_administrador.ToolStripDropDownButtonServicios.DropDownItems("ToolStripMenuItem3").Enabled = False

                US_Empleado.ToolStripDropDownButton6.Enabled = True  'boton de ventas EMPLEADO
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnCajaToolStripMenuItem").Enabled = False   'venta en caja
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaEnMesasToolStripMenuItem").Enabled = False  'venta en mesas
                US_Empleado.ToolStripDropDownButton6.DropDownItems("VentaConsultaToolStripMenuItem").Enabled = True  'venta consulta

                US_administrador.TurnoGestionToolStripMenuItem.Enabled = False
                US_administrador.TurnoFijoNuevoToolStripMenuItem.Enabled = False
                US_administrador.TurnoComunNuevoToolStripMenuItem.Enabled = False

                US_Empleado.TurnoGestionToolStripMenuItem.Enabled = False
                US_Empleado.TurnoFijoNuevoToolStripMenuItem1.Enabled = False
                US_Empleado.TurnoComunNuevoToolStripMenuItem.Enabled = False
        End Select
    End Sub
End Class
