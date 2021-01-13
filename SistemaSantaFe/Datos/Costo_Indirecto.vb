Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class Costo_Indirecto
    Inherits Datos.Conexion
    Public Function Costo_Indirecto_alta(ByVal CostoI_Desc As String,
                                    ByVal CostoI_Total As Decimal,
                                ByVal CostoI_fecha As Date,
                                 ByVal CostoI_Estado As String
                                    ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Costo_Indirecto_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_Desc", CostoI_Desc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_Total", CostoI_Total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_fecha", CostoI_fecha))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_Estado", CostoI_Estado))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_CP", CLI_CP))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Prov", CLI_Id_Prov))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Loc", CLI_Id_Loc))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_mail", CLI_mail))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Costo_Indirecto")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Costo_Indirecto_Detalle_Alta(ByVal CostoInDet_desc As String,
                                ByVal CostoInDet_costo As Decimal,
                                ByVal CostoI_id As Integer
                                    ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Costo_Indirecto_Detalle_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoInDet_desc", CostoInDet_desc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoInDet_costo", CostoInDet_costo))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_id", CostoI_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_CP", CLI_CP))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Prov", CLI_Id_Prov))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Loc", CLI_Id_Loc))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_mail", CLI_mail))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Costo_Indirecto_DET")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Costo_Indirecto_Obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Costo_Indirecto_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Costo_Indirecto_Obtener")
        dbconn.Close()
        Return ds_JE
    End Function


    Public Function Costo_Indirecto_Obtener_Todo_X_ID(
                               ByVal CostoI_id As Integer
                                   ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Costo_Indirecto_Obtener_Todo_X_ID", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_id", CostoI_id))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_CP", CLI_CP))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Prov", CLI_Id_Prov))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_Id_Loc", CLI_Id_Loc))
        'comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_mail", CLI_mail))


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Costo_Indirecto_DET")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Costo_Indirecto_modificar(ByVal CostoI_id As Integer,
                                   ByVal CostoI_Desc As String,
                               ByVal CostoI_Total As Decimal,
                                ByVal CostoI_fecha As Date
                                   ) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Costo_Indirecto_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_id", CostoI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_Desc", CostoI_Desc))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_Total", CostoI_Total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CostoI_fecha", CostoI_fecha))
      


        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Costo_Indirecto")
        dbconn.Close()
        Return ds_JE
    End Function

End Class
