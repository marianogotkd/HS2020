create procedure [dbo].[Producto_x_Sucursal_obtener_lotes]
@sucursal_id int
as
  
               
----0) voy a traer todos los lotes de una sucursal, sin importar el producto
SELECT     dbo.Producto.prod_id, dbo.Producto.prod_codinterno, dbo.Producto.prod_descripcion, dbo.Producto_x_sucursal.ProdxSuc_stock, dbo.Producto_x_sucursal_lote.lote_id, 
                      dbo.Producto_x_sucursal_lote.lote_nro, dbo.Producto_x_sucursal_lote.lote_cantidad, dbo.Producto_x_sucursal_lote.lote_fechafab, dbo.Producto_x_sucursal_lote.lote_fechavto, 
                      dbo.Producto_x_sucursal_lote.lote_vence, dbo.Producto_x_sucursal.sucursal_id, Producto_x_sucursal_lote.Prov_id, Proveedor.Prov_nombre as 'Proveedor',
                         dbo.Producto_x_sucursal_lote.lote_stock_real, dbo.Producto_x_sucursal_lote.lote_aux, dbo.Producto.prod_tipo, Producto_x_sucursal.ProdxSuc_stock_real,
                         Producto.prod_unidadmedida, Producto.prod_contenido    
                      
FROM         dbo.Producto_x_sucursal_lote INNER JOIN
                      dbo.Producto_x_sucursal ON dbo.Producto_x_sucursal_lote.ProdxSuc_ID = dbo.Producto_x_sucursal.ProdxSuc_ID INNER JOIN
                      dbo.Producto ON dbo.Producto_x_sucursal.prod_id = dbo.Producto.prod_id
                      inner join Proveedor on Producto_x_sucursal_lote.Prov_id = Proveedor.Prov_id
                        
where Producto_x_sucursal.sucursal_id = @sucursal_id   and dbo.Producto_x_sucursal_lote.lote_cantidad> 0 
order by Producto.prod_codinterno asc
