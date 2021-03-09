Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Categoria
    Inherits Datos.Conexion



#Region "VALIDACION PARA MODIFICAR RUBROS Y SUBRUBROS"
    Public Function Categoria2_validar(ByVal cat1_id As Integer, ByVal cat2_nom As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Categoria2_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat1_id", cat1_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat2_nom", cat2_nom))
        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Cat")
        dbconn.Close()
        Return ds_MT
    End Function
    Public Function Categoria3_validar(ByVal cat2_id As Integer, ByVal cat3_nom As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Categoria3_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat2_id", cat2_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat3_nom", cat3_nom))
        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Cat")
        dbconn.Close()
        Return ds_MT
    End Function

#End Region


    'Categoria_obtener_niveles uso en el form de categorias gestion para traer todo
    Public Function Categoria_obtener_niveles() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Categoria_obtener_niveles", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        'comando.Parameters.Add(New OleDb.OleDbParameter("@cat_id", cat_id))

        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Cat")
        dbconn.Close()
        Return ds_MT
    End Function


    'Categoria1_alta
    Public Function Categoria1_alta(ByVal cat1_nom As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Categoria1_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cat1_nom", cat1_nom))

        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Ctaegoria_1")
        dbconn.Close()
        Return ds_MT
    End Function

    'Categoria2_alta
    Public Function Categoria2_alta(ByVal cat2_nom As String, ByVal cat1_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Categoria2_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cat2_nom", cat2_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat1_id", cat1_id))

        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Categoria_2")
        dbconn.Close()
        Return ds_MT
    End Function

    'Categoria3_alta
    Public Function Categoria3_alta(ByVal cat3_nom As String, ByVal cat2_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Categoria3_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cat3_nom", cat3_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat2_id", cat2_id))

        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Categoria_3")
        dbconn.Close()
        Return ds_MT
    End Function



    'Borrar_categoria - lo uso en el modulo de categorias
    Public Function Categoria_borrar(ByVal cat1_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Categoria_borrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat1_id", cat1_id))
        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "categoria")
        dbconn.Close()
        Return ds_MT
    End Function


    'Borrar_rubro - lo uso en el modulo de categorias, cuando modifico
    Public Function Categoria_Rubro_borrar(ByVal cat1_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Categoria_Rubro_borrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat1_id", cat1_id))
        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "rubro")
        dbconn.Close()
        Return ds_MT
    End Function

    'elimina de la bd el rubro indicado y recupera de la categoria_3 todos los subrubros del "rubro" buscado
    Public Function Rubro_borror_y_recuperar_subrubros(ByVal cat2_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Rubro_borror_y_recuperar_subrubros", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat2_id", cat2_id))
        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "rubro")
        dbconn.Close()
        Return ds_MT
    End Function


    'Borrar_subrubro - lo uso en el modulo de categorias, cuando modifico
    Public Function Categoria_Subrubro_borrar(ByVal cat3_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Categoria_Subrubro_borrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat3_id", cat3_id))
        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "subrubro")
        dbconn.Close()
        Return ds_MT
    End Function






    'para el combo de alta de producto
    Public Function Categoria_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("categoria_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure


        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Categoria_1")
        dbconn.Close()
        Return ds_MT
    End Function

    Public Function Categoriarubro_obtener(ByVal cat_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Categoriarubro_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cat_id", cat_id))

        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Categoria_2")
        dbconn.Close()
        Return ds_MT
    End Function

    Public Function rubrosubrubro_obtener(ByVal cat2_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("rubrosubrubro_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cat2_id", cat2_id))

        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Categoria_3")
        dbconn.Close()
        Return ds_MT
    End Function

    Public Function Categoriarubro_buscar_rubro(ByVal cat_id As Integer, ByVal cat2_nom As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Categoriarubro_buscar_rubro", dbconn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add(New OleDb.OleDbParameter("@cat_id", cat_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat2_nom", cat2_nom))

        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Categoria_2")
        dbconn.Close()
        Return ds_MT
    End Function

    'esta funcion es para actualizar los productos...se pasan todos a la categoria "DEFECTO"
    Public Function Categoria_actualizar_defecto(ByVal prod_idcat As Integer, ByVal prod_nrocat As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Categoria_actualizar_defecto", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_idcat", prod_idcat))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_nrocat", prod_nrocat))
        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Categoria")
        dbconn.Close()
        Return ds_MT
    End Function

    Public Function RubroSubrubro_buscar_subrubro(ByVal cat2_id As Integer, ByVal cat3_nom As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("RubroSubrubro_buscar_subrubro", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat2_id", cat2_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@cat3_nom", cat3_nom))
        Dim ds_MT As New DataSet()
        Dim da_MT As New OleDbDataAdapter(comando)
        da_MT.Fill(ds_MT, "Categoria")
        dbconn.Close()
        Return ds_MT
    End Function


End Class
