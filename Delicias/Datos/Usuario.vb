Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Usuario

    Inherits Datos.Conexion

    'USUARIO
    Public Function Usuario_Sesion(ByVal USU_usuario As String, ByVal USU_contr As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_sesion", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_usuario", USU_usuario))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_cont ", USU_contr))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Sub Usuario_alta(ByVal UT_id As Integer, ByVal USU_ape As String, ByVal USU_nom As String, ByVal USU_usuario As String,
                            ByVal USU_contr As String, ByVal suc_id As Integer,
                            ByVal USU_dni As Integer, ByVal USU_domicilio As String, ByVal USU_telefono As String, ByVal USU_foto() As Byte)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_id", UT_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_ape", USU_ape))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_nom", USU_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_usuario", USU_usuario))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_contr", USU_contr))
        comando.Parameters.Add(New OleDb.OleDbParameter("@suc_id", suc_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_dni", USU_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_domicilio", USU_domicilio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_telefono", USU_telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_USU_foto", USU_foto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

    Public Sub Usuario_modificar(ByVal USU_id As Integer, ByVal UT_id As Integer, ByVal USU_ape As String, ByVal USU_nom As String, ByVal USU_usuario As String,
                            ByVal USU_contr As String, ByVal suc_id As Integer,
                            ByVal USU_dni As Integer, ByVal USU_domicilio As String, ByVal USU_telefono As String, ByVal USU_foto() As Byte)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_id", UT_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_ape", USU_ape))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_nom", USU_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_usuario", USU_usuario))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_contr", USU_contr))
        comando.Parameters.Add(New OleDb.OleDbParameter("@suc_id", suc_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_dni", USU_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_domicilio", USU_domicilio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_telefono", USU_telefono))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_USU_foto", USU_foto))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub


    Public Function UsuarioTipo_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand(" UsuarioTipo_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function UsuarioEstado_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("UsuarioEstado_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "UsuarioEstado")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub Usuario_Cont(ByVal USU_id As String, ByVal USU_contr As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_Cont", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_contr", USU_contr))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

    'Usuario Bloquear
    Public Sub Usuario_bloquear(ByVal USU_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_bloquear", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

    'Usuario Desbloquear
    Public Sub Usuario_Desbloquear(ByVal USU_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_desbloquear", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

    'Usuario Obtener
    Public Function Usuario_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function

    'Usuario_recuperar_datos_personales --LO USO EN EL MODULO DE MODIFICAR USUARIO
    Public Function Usuario_recuperar_datos_personales(ByVal USU_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_recuperar_datos_personales", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function
   

    'Usuario Cambiar
    Public Sub Usuario_cambiar(ByVal USU_id As String, ByVal UT_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_cambiar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_id", UT_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
    End Sub

    'procedmiento usado en el modulo de consulta de ventas, es necesario para poder filtrar por usuario las ventas..es para el control del administrador
    Public Function Usuario_obtener_x_sucursal(ByVal sucursal_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Usuario_obtener_x_sucursal", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@sucursal_id", sucursal_id))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function



#Region "Configuracion de Tipos de Usuario"
    Public Function UsuarioModulos_alta(ByVal UT_id As Integer, ByVal USUModulos_descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("UsuarioModulos_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_id", UT_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@USUModulos_descripcion", USUModulos_descripcion))

        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function UsuarioModulos_eliminar(ByVal UT_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("UsuarioModulos_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_id", UT_id))
        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function UsuarioModulos_obtener(ByVal UT_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("UsuarioModulos_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_id", UT_id))
        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function UsuarioTipo_Alta(ByVal UT_desc As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("UsuarioTipo_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_desc", UT_desc))
        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function


    Public Function Usuario_Bloquear_cambiarTipo(ByVal USU_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Usuario_Bloquear_cambiarTipo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@USU_id", USU_id))
        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function

    Public Function UsuarioTipo_eliminar(ByVal UT_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("UsuarioTipo_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@UT_id", UT_id))
        Dim ds_usu As New DataSet()
        Dim da_usu As New OleDbDataAdapter(comando)
        da_usu.Fill(ds_usu, "Usuario")
        dbconn.Close()
        Return ds_usu
    End Function

#End Region



End Class
