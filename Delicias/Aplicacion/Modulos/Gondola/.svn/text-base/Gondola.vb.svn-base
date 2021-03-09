Public Class Gondola
    Dim DAmarca As New Datos.Marca
    Dim DAproveedores As New Datos.Proveedor
    Dim ds_proveedor As DataSet = DAproveedores.Proveedor_obtener
    Dim DAproducto As New Datos.Producto
   

    Private Sub Bo_codbarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_codbarra.Click
        If tx_codbarra_modif.Text <> "" Then
            Me.DG_Producto.Rows.Clear()
            Dim DS As New DataSet
            DS = DAproducto.producto_buscarcodbarra(Me.tx_codbarra_modif.Text)
            If DS.Tables(1).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(1).Rows.Count
                    Me.DG_Producto.Rows().Add()
                    DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(1).Rows(fila).Item(0) 'ID
                    DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(1).Rows(fila).Item(6) 'COD interno
                    DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(1).Rows(fila).Item(1) 'producto
                    DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(1).Rows(fila).Item(5) 'marca
                    DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(1).Rows(fila).Item(3) 'Stock
                    DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(1).Rows(fila).Item(4) 'ptoreposicion

                    If Convert.ToString(DS.Tables(1).Rows(fila).Item(7)) = "" Then
                        DG_Producto.Rows(fila).Cells(6).Value = CInt(0) 'gondola
                    Else
                        DG_Producto.Rows(fila).Cells(6).Value = DS.Tables(1).Rows(fila).Item(7) 'GONDOLA
                    End If


                    DG_Producto.Rows(fila).Cells(7).Value = CInt(DG_Producto.Rows(fila).Cells(4).Value) - CInt(DG_Producto.Rows(fila).Cells(6).Value) 'DEPOSITO (STOCK - GONDOLA)
                    If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                        DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
                        DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                    End If
                    fila = fila + 1
                End While
                DG_Producto.ClearSelection()
            End If
            Me.tx_codbarra_modif.Select()
        Else
            Prod_obtenertodo()
        End If
    End Sub

    Private Sub BO_Buscar_codinterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Buscar_codinterno.Click
        If Tx_Codinterno.Text <> "" Then
            Me.DG_Producto.Rows.Clear()
            Dim DS As New DataSet
            DS = DAproducto.Producto_buscarcod(Me.Tx_Codinterno.Text)
            If DS.Tables(1).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(0).Rows.Count
                    Me.DG_Producto.Rows().Add()
                    DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(1).Rows(fila).Item(0) 'ID
                    DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(1).Rows(fila).Item(6) 'COD interno
                    DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(1).Rows(fila).Item(1) 'producto
                    DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(1).Rows(fila).Item(5) 'marca
                    DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(1).Rows(fila).Item(3) 'Stock
                    DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(1).Rows(fila).Item(4) 'ptoreposicion


                    If Convert.ToString(DS.Tables(1).Rows(fila).Item(7)) = "" Then
                        DG_Producto.Rows(fila).Cells(6).Value = CInt(0) 'gondola
                    Else
                        DG_Producto.Rows(fila).Cells(6).Value = DS.Tables(1).Rows(fila).Item(7) 'GONDOLA
                    End If



                    DG_Producto.Rows(fila).Cells(7).Value = CInt(DG_Producto.Rows(fila).Cells(4).Value) - CInt(DG_Producto.Rows(fila).Cells(6).Value) 'DEPOSITO (STOCK - GONDOLA)
                    If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                        DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
                        DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                    End If
                    fila = fila + 1
                End While
            End If
            Me.Tx_Codinterno.Select()
        Else
            Prod_obtenertodo()
        End If
    End Sub

    Private Sub Bo_buscar_nombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_buscar_nombre.Click
        If Tx_nomprod_modif.Text <> "" Then
            Me.DG_Producto.Rows.Clear()
            Dim DS As New DataSet
            DS = DAproducto.producto_buscarnom(Me.Tx_nomprod_modif.Text)
            If DS.Tables(1).Rows.Count <> 0 Then
                Dim fila As Integer = 0
                While fila < DS.Tables(1).Rows.Count
                    Me.DG_Producto.Rows().Add()
                    DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(1).Rows(fila).Item(0) 'ID
                    DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(1).Rows(fila).Item(6) 'COD interno
                    DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(1).Rows(fila).Item(1) 'producto
                    DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(1).Rows(fila).Item(5) 'marca
                    DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(1).Rows(fila).Item(3) 'Stock
                    DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(1).Rows(fila).Item(4) 'ptoreposicion
                    If Convert.ToString(DS.Tables(1).Rows(fila).Item(7)) = "" Then
                        DG_Producto.Rows(fila).Cells(6).Value = CInt(0) 'gondola
                    Else
                        DG_Producto.Rows(fila).Cells(6).Value = DS.Tables(1).Rows(fila).Item(7) 'GONDOLA
                    End If

                    DG_Producto.Rows(fila).Cells(7).Value = CInt(DG_Producto.Rows(fila).Cells(4).Value) - CInt(DG_Producto.Rows(fila).Cells(6).Value) 'DEPOSITO (STOCK - GONDOLA)
                    If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                        DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
                        DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                    End If
                    fila = fila + 1
                End While
                DG_Producto.ClearSelection()
            End If
            Me.Tx_nomprod_modif.Select()
        Else
            Prod_obtenertodo()
        End If
    End Sub


    Public Sub Prod_obtenertodo()
        Me.DG_Producto.Rows.Clear()
        Dim DS As New DataSet
        DS = DAproducto.prod_obtener()
        If DS.Tables(1).Rows.Count <> 0 Then
            Dim fila As Integer = 0
            While fila < DS.Tables(1).Rows.Count
                Me.DG_Producto.Rows().Add()
                DG_Producto.Rows(fila).Cells(0).Value = DS.Tables(1).Rows(fila).Item(0) 'ID
                DG_Producto.Rows(fila).Cells(1).Value = DS.Tables(1).Rows(fila).Item(6) 'COD interno
                DG_Producto.Rows(fila).Cells(2).Value = DS.Tables(1).Rows(fila).Item(1) 'producto
                DG_Producto.Rows(fila).Cells(3).Value = DS.Tables(1).Rows(fila).Item(5) 'marca
                DG_Producto.Rows(fila).Cells(4).Value = DS.Tables(1).Rows(fila).Item(3) 'Stock
                DG_Producto.Rows(fila).Cells(5).Value = DS.Tables(1).Rows(fila).Item(4) 'ptoreposicion

                If Convert.ToString(DS.Tables(1).Rows(fila).Item(7)) = "" Then
                    DG_Producto.Rows(fila).Cells(6).Value = CInt(0) 'gondola
                Else
                    DG_Producto.Rows(fila).Cells(6).Value = DS.Tables(1).Rows(fila).Item(7) 'GONDOLA
                End If


                DG_Producto.Rows(fila).Cells(7).Value = CInt(DG_Producto.Rows(fila).Cells(4).Value) - CInt(DG_Producto.Rows(fila).Cells(6).Value) 'DEPOSITO (STOCK - GONDOLA)


                If DG_Producto.Rows(fila).Cells(4).Value <= DG_Producto.Rows(fila).Cells(5).Value Then
                    DG_Producto.Rows(fila).DefaultCellStyle.BackColor = Color.Firebrick
                    DG_Producto.Rows(fila).DefaultCellStyle.ForeColor = Color.White
                End If

                fila = fila + 1
            End While
            DG_Producto.ClearSelection()
        End If
    End Sub
    Public Sub Buscar_Gon()
        If DG_Producto.Rows.Count <> 0 Then
            'Dim DS_Gon As New DataSet


            'Dim id As Integer = DG_Producto.CurrentRow.Cells(0).Value

            'DS_Gon = DAproducto.Gondola_obtener(id)
            'TX_Cant.Text = DS_Gon.Tables(0).Rows(0).Item("prod_gondola").ToString
            TX_Cant.Text = CInt(0)

            Txt_cantheladera.Text = CInt(DG_Producto.CurrentRow.Cells("Heladeragondola").Value)


        End If
    End Sub


    Private Sub DG_Producto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Producto.Click
        Buscar_Gon()
    End Sub


    Private Sub Bo_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bo_guardar.Click
        If DG_Producto.Rows.Count <> 0 Then

            If TX_Cant.Text <= DG_Producto.CurrentRow.Cells("Deposito").Value Then
                Dim DS_Alta As New DataSet


                Dim id As Integer = DG_Producto.CurrentRow.Cells(0).Value
                DS_Alta = DAproducto.Gondola_Alta(id, (CInt(TX_Cant.Text) + CInt(DG_Producto.CurrentRow.Cells("Heladeragondola").Value)))
                Prod_obtenertodo()
                MsgBox("Se Actualizaron los Datos Correctamente", MsgBoxStyle.Information)
            Else
                MsgBox("Error!, la cantidad no debe ser mayor al stock disponible", MsgBoxStyle.Information)
            End If
            
        End If

    End Sub

    Private Sub btn_vaciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vaciar.Click
        If DG_Producto.Rows.Count <> 0 Then

            If Txt_cantheladera.Text <= DG_Producto.CurrentRow.Cells("Deposito").Value Then
                Dim DS_Alta As New DataSet


                Dim id As Integer = DG_Producto.CurrentRow.Cells(0).Value
                DS_Alta = DAproducto.Gondola_Alta(id, (CInt(Txt_cantheladera.Text)))
                Prod_obtenertodo()
                MsgBox("Se Actualizaron los Datos Correctamente", MsgBoxStyle.Information)
            Else
                MsgBox("Error!, la cantidad no debe ser mayor al stock disponible", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub TX_Cant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TX_Cant.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                    e.Handled = True
                End If
            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txt_cantheladera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_cantheladera.KeyPress
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," Then   'aqui se bloquea el ingreso de comas y puntos
                    e.Handled = True
                End If
            End If
            If Char.IsLetter(e.KeyChar) Then 'aqui se bloque el ingresodo de letras
                e.Handled = True
            End If
        End If
    End Sub
End Class