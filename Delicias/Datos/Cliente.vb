Imports System.Data.OleDb
Imports System.Data.DataRow


Public Class Cliente
    Inherits Datos.Conexion
    'Cliente_Alta_new
    Public Function Cliente_Alta_new(ByVal CLI_Fan As String,
                                ByVal CLI_dni_cuit As String,
                                ByVal CLI_tipoiva As String,
                                ByVal CLI_tel As String,
                                ByVal CLI_dir As String,
                                ByVal CLI_CP As String,
                                ByVal CLI_Id_Prov As String,
                                ByVal CLI_Id_Loc As String,
                                ByVal CLI_mail As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_alta_new", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Fan", CLI_Fan))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dni_cuit", CLI_dni_cuit))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_tipoiva", CLI_tipoiva))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_tel", CLI_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dir", CLI_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_CP", CLI_CP))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Prov", CLI_Id_Prov))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Loc", CLI_Id_Loc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_mail", CLI_mail))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function



    'Cliente_Alta
    Public Sub Cliente_Alta(ByVal clie_ape As String, ByVal clie_nom As String, ByVal clie_dni As String, ByVal CLI_fnac As DateTime,
                            ByVal clie_tel As String, ByVal clie_mail As String, ByVal clie_observaciones As String, ByVal CLI_Tipo As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_ape", clie_ape))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_nom", clie_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dni", clie_dni))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_fnac", CLI_fnac))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_tel", clie_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_mail", clie_mail))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_observaciones", clie_observaciones))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Tipo", CLI_Tipo))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub

    'Cliente_Modificar
    Public Sub Cliente_Modificar(ByVal CLI_id As Integer, ByVal CLI_Fan As String,
                                ByVal CLI_dni_cuit As String,
                                ByVal CLI_tipoiva As String,
                                ByVal CLI_tel As String,
                                ByVal CLI_dir As String,
                                ByVal CLI_CP As String,
                                ByVal CLI_Id_Prov As String,
                                ByVal CLI_Id_Loc As String,
                                ByVal CLI_mail As String
        )
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Fan", CLI_Fan))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dni_cuit", CLI_dni_cuit))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_tipoiva", CLI_tipoiva))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_tel", CLI_tel))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dir", CLI_dir))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_CP", CLI_CP))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Prov", CLI_Id_Prov))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Loc", CLI_Id_Loc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_mail", CLI_mail))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub

    'Cliente_eliminar
    Public Sub Cliente_eliminar(ByVal clie_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", clie_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub

    'Cliente_ObtenerDni
    Public Function Cliente_ObtenerDni(ByVal CLI_dni As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_ObtenerDni", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dni", CLI_dni))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Cliente_ObtenerDni_Fijo(ByVal CLI_dni As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_ObtenerDni_Fijo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dni", CLI_dni))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function


    'Cliente_ObtenerApe
    Public Function Cliente_ObtenerApe(ByVal CLI_ape As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_ObtenerApe", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_ape", CLI_ape))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    'Cliente_ObtenerApe
    Public Function Cliente_ObtenerApe_Fijo(ByVal CLI_ape As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_ObtenerApe_Fijo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_ape", CLI_ape))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function



    'Cliente_VerificarDni
    Public Function Cliente_VerificarDni(ByVal CLI_dni As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_VerificarDni", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_dni", CLI_dni))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    'Cliente_obtenertodo
    Public Function Cliente_obtenertodo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_obtenertodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function


    'Informe_Cliente
    Public Function Informe_Cliente() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Informe_Cliente", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function


    'Cliente_Alta
    Public Sub Clientes_Fijos_Pagos_Alta(ByVal CliPa_CLI_ID As Integer, ByVal CliPa_Fecha As Date, ByVal CliPa_Monto As String, ByVal CliPa_observacion As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Clientes_Fijos_Pagos_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CliPa_CLI_ID", CliPa_CLI_ID))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CliPa_Fecha", CliPa_Fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CliPa_Monto", CliPa_Monto))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CliPa_observacion", CliPa_observacion))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
    End Sub


    Public Function Clientes_Fijos_Consulta(ByVal clie_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Clientes_Fijos_Consulta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@clie_id", clie_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    'Clientes_Obtener_Provincias
    Public Function Provincias_ObtenerTodo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Provincias_ObtenerTodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    'Cliente_Obtener_localidades_x_provincias
    Public Function Obtener_localidades_x_provincias(ByVal Prov_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Obtener_localidades_x_provincias", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@Prov_id", Prov_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Obterner_Iva() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Obterner_Iva", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function

    'creado el 12-09-2018
    Public Function Cliente_obtener_info(ByVal CLI_id As Integer) As DataSet

        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Cliente_obtener_info", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Usuario")
        dbconn.Close()
        Return ds_JE
    End Function


#Region "Procedimientos para reportes"
    'choco: 27-06-2019
    'recupera todos los clientes en tabla 0 y en la 1 los datos de la empresa para mostrar en el encabezado del reporte
    Public Function Cliente_obtenertodos_reporte() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Cliente_obtenertodos_reporte", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Cliente")
        dbconn.Close()
        Return ds_JE
    End Function
#End Region

End Class
