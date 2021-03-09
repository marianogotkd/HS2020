Imports System.Data.OleDb
Imports System.Data.DataRow

Public Class Lista

    Inherits Datos.Conexion

    'Lista_obtenerProductoCodigo
    Public Function Lista_obtenerProductoCodigo(ByVal prod_codinterno As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_obtenerProductoCodigo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("prod_codinterno", prod_codinterno))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_obtenerProductoCodigoBarra
    Public Function Lista_obtenerProductoCodigoBarra(ByVal prod_codbarra As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_obtenerProductoCodigoBarra", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("prod_codbarra", prod_codbarra))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE

    End Function

    'Lista_obtenerProductoDescripcion
    Public Function Lista_obtenerProductoDescripcion(ByVal prod_descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_obtenerProductoDescripcion", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("prod_descripcion", prod_descripcion))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_obtenerCategorias
    Public Function Lista_obtenerCategorias(ByVal prod_idcat As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_obtenerCategorias", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_idcat", prod_idcat))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Categorias")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_Promocion_Alta
    Public Function Lista_Promocion_Alta(ByVal LISTA_nom As String, ByVal LISTA_total As Decimal, ByVal LISTA_codinterno As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Promocion_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_nom", LISTA_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_total", LISTA_total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_codinterno", LISTA_codinterno))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_Promocion_Dia_Alta
    Public Sub Lista_Promocion_Dia_Alta(ByVal LISTA_id As String, ByVal DIA_id As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Promocion_Dia_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_id", LISTA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("DIA_id", DIA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaDia")
        dbconn.Close()
    End Sub

    'Lista_Promocion_Vigencia_Alta
    Public Sub Lista_Promocion_Vigencia_Alta(ByVal LISTA_id As String, ByVal LISTA_VIG_desde As Date, ByVal LISTA_VIG_hasta As Date)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Promocion_Vigencia_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_id", LISTA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_VIG_desde", LISTA_VIG_desde))
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_VIG_hasta", LISTA_VIG_hasta))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaVigencia")
        dbconn.Close()
    End Sub

    'Lista_Promocion_Producto_Alta
    Public Sub Lista_Promocion_Producto_Alta(ByVal LISTA_id As String, ByVal prod_id As String, ByVal Lista_Prod_cantidad As Decimal,
                                  ByVal Lista_Prod_precio As Decimal, ByVal Lista_Prod_subtotal As Decimal, ByVal Lista_Prod_tipo As String)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Promocion_Producto_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_id", LISTA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Lista_Prod_cantidad int", Lista_Prod_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Lista_Prod_precio", Lista_Prod_precio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Lista_Prod_subtotal", Lista_Prod_subtotal))
        comando.Parameters.Add(New OleDb.OleDbParameter("@Lista_Prod_tipo", Lista_Prod_tipo))



        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaProducto_Alta")
        dbconn.Close()
    End Sub

    'Lista_Promocion_validar
    Public Function Lista_Promocion_validar(ByVal LISTA_nom As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Promocion_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_nom", LISTA_nom))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lista_validacion")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_Obtener
    Public Function Lista_Obtener(ByVal LISTA_nom As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_nom", LISTA_nom))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lista")
        dbconn.Close()
        Return ds_JE
    End Function

    'ListaDia_Obtener
    Public Function ListaDia_Obtener(ByVal LISTA_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ListaDia_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_id", LISTA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaDia")
        dbconn.Close()
        Return ds_JE
    End Function

    'ListaVigencia_Obtener
    Public Function ListaVigencia_Obtener(ByVal LISTA_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ListaVigencia_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_id", LISTA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaVigencia")
        dbconn.Close()
        Return ds_JE
    End Function

    'ListaProducto_Obtener
    Public Function ListaProducto_Obtener(ByVal LISTA_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ListaProducto_Obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_id", LISTA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaProducto")
        dbconn.Close()
        Return ds_JE
    End Function


    'Lista_obtenerProductoCodigo
    Public Function Lista_Promocion_obtener_items(ByVal LISTA_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Promocion_obtener_items", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_id", LISTA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function



#Region "PROCEDIMIENTOS PARA COMBOS"
    'Alta_COMBO....aqui cargo el total del combo...y recupero el id del combo para cargar los detalles
    Public Function ProductoCombo_alta(ByVal ProdCombo_codinterno As String, ByVal ProdCombo_descripcion As String, ByVal ProdCombo_total As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("ProductoCombo_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_codinterno", ProdCombo_codinterno))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_descripcion", ProdCombo_descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_total", ProdCombo_total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function

    'ProductoComboDetalle_alta
    Public Sub ProductoComboDetalle_alta(ByVal ProdCombo_id As String, ByVal prod_id As String, ByVal ProdComboDet_cantidad As String, ByVal ProdComboDet_precio As Decimal, ByVal ProdComboDet_subtotal As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("ProductoComboDetalle_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_id", ProdCombo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@prod_id", prod_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdComboDet_cantidad", ProdComboDet_cantidad))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdComboDet_precio", ProdComboDet_precio))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdComboDet_subtotal", ProdComboDet_subtotal))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoComboDetalle")
        dbconn.Close()
    End Sub


    'ProductoCombo_modifDatos
    Public Sub ProductoCombo_modifDatos(ByVal ProdCombo_id As Integer, ByVal ProdCombo_descripcion As String, ByVal ProdCombo_total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("ProductoCombo_modifDatos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_id", ProdCombo_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_descripcion", ProdCombo_descripcion))
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_total", ProdCombo_total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoComboDetalle")
        dbconn.Close()
    End Sub




    'ProductoComboDetalle_borrar, lo uso para borrar los item del combo antes de guardar una modificacion
    Public Sub ProductoComboDetalle_borrar(ByVal ProdCombo_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("ProductoComboDetalle_borrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_id", ProdCombo_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoComboDetalle")
        dbconn.Close()
    End Sub




    'ProductoCombo_validar
    Public Function ProductoCombo_validar() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("ProductoCombo_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function

    'ProductoCombo_buscar ...me sirve para validar q no exista el combo nuevo
    Public Function ProductoCombo_buscar(ByVal descripcion As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ProductoCombo_buscar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_descripcion", descripcion))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function
    'ProductoCombo_buscar_ID ...me sirve para obtener el ID del combo para modificarlo posteriormente
    Public Function ProductoCombo_buscar_ID(ByVal ProdCombo_codinterno As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("ProductoCombo_buscar_ID", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@ProdCombo_codinterno", ProdCombo_codinterno))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ProductoCombo")
        dbconn.Close()
        Return ds_JE
    End Function

#End Region

#Region "PROCEDIMIENTOS PARA LISTAS REGULARES"

    'Lista_Regular_validar
    Public Function Lista_Regular_validar(ByVal LISTA_nom As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Regular_validar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_nom", LISTA_nom))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Lista_validacion")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_Regular_Alta
    Public Function Lista_Regular_Alta(ByVal LISTA_nom As String, ByVal LISTA_total As Decimal) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Regular_Alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_nom", LISTA_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_total", LISTA_total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "Producto")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_Regular_obtener
    Public Function Lista_Regular_obtener() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Regular_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaRegular")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_Regular_modifDatos
    Public Sub Lista_Regular_modifDatos(ByVal LISTA_id As Integer, ByVal LISTA_nom As String, ByVal LISTA_total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Lista_Regular_modifDatos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_id", LISTA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_nom", LISTA_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_total", LISTA_total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaRegular")
        dbconn.Close()
    End Sub

    'Lista_Regular_detalle_borrar
    Public Sub Lista_Regular_detalle_borrar(ByVal LISTA_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Lista_Regular_detalle_borrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_id", LISTA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaRegular")
        dbconn.Close()
    End Sub


#End Region
#Region "PROCEDIMIENTOS PARA LISTAS PROMOCION"

    'Lista_Promocion_validar2
    Public Function Lista_Promocion_validar2() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Promocion_validar2", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "LisraPromocion")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_Promocion_obtener
    Public Function Lista_Promocion_obtener() As DataSet
        'obtengo todas las listas promocionales, en visual valido cual mostrar si tiene vigencia
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Promocion_obtener", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "LisraPromocion")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function Lista_Promocion_recuperar_items(ByVal LISTA_id As String) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("Lista_Promocion_recuperar_items", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("LISTA_id", LISTA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaProducto")
        dbconn.Close()
        Return ds_JE
    End Function

    'Lista_Promocion_modifDatos
    Public Sub Lista_Promocion_modifDatos(ByVal LISTA_id As Integer, ByVal LISTA_nom As String, ByVal LISTA_total As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Lista_Promocion_modifDatos", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_id", LISTA_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_nom", LISTA_nom))
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_total", LISTA_total))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaPromocion")
        dbconn.Close()
    End Sub

    'Lista_Promocion_detalle_borrar
    Public Sub Lista_Promocion_detalle_borrar(ByVal LISTA_id As Integer)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("Lista_Promocion_detalle_borrar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@LISTA_id", LISTA_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "ListaPromocion")
        dbconn.Close()
    End Sub
#End Region








End Class
