Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Enfermeria
    Inherits Datos.Conexion
    Public Function Dialisis_alta(
                                         ByVal Sesiones_id As Integer,
                                         ByVal Dialisis_PesoS As Decimal,
                                         ByVal Dialisis_Talla As Decimal,
                             ByVal Dialisis_HI As String,
                             ByVal Dialisis_HE As String,
                             ByVal Dialisis_TiempoHD As String,
                             ByVal Dialisis_PesoI As Decimal,
                             ByVal Dialisis_PesoE As Decimal,
                             ByVal Dialisis_TAI As Decimal,
                             ByVal Dialisis_TAE As Decimal,
                             ByVal Dialisis_Filtro As String,
                             ByVal Dialisis_Obs As String, ByVal AccesoVascular As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Dialisis_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_id", Sesiones_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_PesoS", Dialisis_PesoS))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_Talla", Dialisis_Talla))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_HI", Dialisis_HI))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_HE", Dialisis_HE))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_TiempoHD", Dialisis_TiempoHD))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_PesoI", Dialisis_PesoI))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_PesoE", Dialisis_PesoE))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_TAI", Dialisis_TAI))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_TAE", Dialisis_TAE))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_Filtro", Dialisis_Filtro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_Obs", Dialisis_Obs))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AccesoVascular", AccesoVascular))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Dialisis_modificar(ByVal fecha As Date,
                                         ByVal Sesiones_id As Integer,
                                         ByVal Dialisis_PesoS As Decimal,
                                         ByVal Dialisis_Talla As Decimal,
                             ByVal Dialisis_HI As String,
                             ByVal Dialisis_HE As String,
                             ByVal Dialisis_TiempoHD As String,
                             ByVal Dialisis_PesoI As Decimal,
                             ByVal Dialisis_PesoE As Decimal,
                             ByVal Dialisis_TAI As Decimal,
                             ByVal Dialisis_TAE As Decimal,
                             ByVal Dialisis_Filtro As String,
                             ByVal Dialisis_Obs As String, ByVal AccesoVascular As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Dialisis_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@fecha", fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_id", Sesiones_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_PesoS", Dialisis_PesoS))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_Talla", Dialisis_Talla))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_HI", Dialisis_HI))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_HE", Dialisis_HE))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_TiempoHD", Dialisis_TiempoHD))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_PesoI", Dialisis_PesoI))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_PesoE", Dialisis_PesoE))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_TAI", Dialisis_TAI))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_TAE", Dialisis_TAE))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_Filtro", Dialisis_Filtro))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Dialisis_Obs", Dialisis_Obs))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AccesoVascular", AccesoVascular))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Consulta_AccesoV_Modificar_soloTipo(
                              ByVal PAC_id As Integer,
                              ByVal AV_tipo As String
                            ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Consulta_AccesoV_Modificar_soloTipo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@AV_tipo", AV_tipo))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Recuperar_Tipo_AccesoV(
                             ByVal PAC_id As Integer
                           ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Recuperar_Tipo_AccesoV", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))




        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Dialisis_Obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Dialisis_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Filtro_Obtener_X_PAC(
                              ByVal PAC_id As Integer
                            ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Filtro_Obtener_X_PAC", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))




        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Filtro_Nuevo(
                              ByVal PAC_id As Integer,
                              ByVal Filtro_fecha As Date,
                               ByVal Filtro_cant_reuso As Integer,
                                ByVal Sesiones_id As Integer, ByVal Filtro_nombre As String, ByVal ProdxSuc_ID As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Filtro_Nuevo", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Filtro_fecha", Filtro_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Filtro_cant_reuso", Filtro_cant_reuso))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Sesiones_id", Sesiones_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Filtro_nombre", Filtro_nombre))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdxSuc_ID", ProdxSuc_ID))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Filtro_modificar_Cant(
                              ByVal Filtro_id As Integer,
                              ByVal Filtro_cant_reuso As Integer
                            ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Filtro_modificar_Cant", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@Filtro_id", Filtro_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Filtro_cant_reuso", Filtro_cant_reuso))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Filtro_obtener_x_PAC_todos(ByVal PAC_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Filtro_obtener_x_PAC_todos", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@PAC_id", PAC_id))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Filtro")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Filtro_obtener_todos_rangofecha(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Filtro_obtener_todos_rangofecha", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@desde", desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("@hasta", hasta))

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Filtro")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Insumos_Predefinidos_alta(
                              ByVal predef_cant As Decimal,
                              ByVal Predef_Desc As String,
                               ByVal prod_codinterno As Integer,
                               ByVal prod_unidadmedida As String
                            ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Insumos_Predefinidos_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@predef_cant", predef_cant))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Predef_Desc", Predef_Desc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_codinterno", prod_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_unidadmedida", prod_unidadmedida))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Insumos_Predefinidos")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Insumos_Predefinidos_Obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Insumos_Predefinidos_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function



    Public Function Insumos_Predefinidos_Eliminar() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Insumos_Predefinidos_Eliminar", dbconn)
        comando.CommandType = CommandType.StoredProcedure



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Dialisis")
        dbconn.Close()
        Return ds_JE
    End Function
End Class
