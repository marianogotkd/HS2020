USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_sucursal_lote_recuperartodos]    Script Date: 01/26/2021 16:07:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_x_sucursal_lote_recuperartodos]

---recupero todos los lotes cuya cantidad sea distinta de 0, ya que la mostrare en el detalle del producto.
---si elimino a travez del form de movimientos bajas, en realidad lo que hago es restar y poner en 0 el registro de la tabla producto_x_sucursal_lote

@prod_codinterno int,
@sucursal_id int

as
declare @prod_id int
select @prod_id = prod_id from Producto where Producto.prod_codinterno = @prod_codinterno 


SELECT     dbo.Producto.prod_id, dbo.Producto.prod_codinterno, dbo.Producto.prod_descripcion, dbo.Producto_x_sucursal.ProdxSuc_stock, dbo.Producto_x_sucursal_lote.lote_id, 
                      dbo.Producto_x_sucursal_lote.lote_nro, dbo.Producto_x_sucursal_lote.lote_cantidad, dbo.Producto_x_sucursal_lote.lote_fechafab, dbo.Producto_x_sucursal_lote.lote_fechavto, 
                      dbo.Producto_x_sucursal_lote.lote_vence, dbo.Producto_x_sucursal.sucursal_id, Producto_x_sucursal_lote.Prov_id, Proveedor.Prov_nombre as 'Proveedor',
                         dbo.Producto_x_sucursal_lote.lote_stock_real, dbo.Producto_x_sucursal_lote.lote_aux, dbo.Producto.prod_tipo, Producto_x_sucursal.ProdxSuc_stock_real,
                         Producto.prod_unidadmedida   
                      
FROM         dbo.Producto_x_sucursal_lote INNER JOIN
                      dbo.Producto_x_sucursal ON dbo.Producto_x_sucursal_lote.ProdxSuc_ID = dbo.Producto_x_sucursal.ProdxSuc_ID INNER JOIN
                      dbo.Producto ON dbo.Producto_x_sucursal.prod_id = dbo.Producto.prod_id
                      inner join Proveedor on Producto_x_sucursal_lote.Prov_id = Proveedor.Prov_id
                        
where Producto_x_sucursal.prod_id = @prod_id and Producto_x_sucursal.sucursal_id = @sucursal_id   and dbo.Producto_x_sucursal_lote.lote_cantidad> 0 
order by lote_nro asc
