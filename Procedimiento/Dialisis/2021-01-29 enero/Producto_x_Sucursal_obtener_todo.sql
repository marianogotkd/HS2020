USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_Sucursal_obtener_todo]    Script Date: 01/29/2021 14:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_x_Sucursal_obtener_todo]
@sucursal_id int
as

SELECT     dbo.Producto.prod_descripcion, dbo.Producto.prod_precio_vta, dbo.Producto.prod_id, dbo.Producto.prod_codinterno, dbo.Producto.prod_ptorepo, dbo.Producto.prod_precio_vta_May, 
                      dbo.Producto_x_sucursal.ProdxSuc_stock, dbo.Producto_x_sucursal.sucursal_id,
                      Producto.prod_codbarra,convert(varchar,Producto.prod_contenido) + ' ' +Producto.prod_unidadmedida as 'Contenido', convert(varchar,Producto_x_sucursal.ProdxSuc_stock_real)+' '+Producto.prod_unidadmedida as 'Contenido_total' 
FROM         dbo.Producto INNER JOIN
                      dbo.Producto_x_sucursal ON dbo.Producto.prod_id = dbo.Producto_x_sucursal.prod_id INNER JOIN
                      dbo.Sucursal ON dbo.Producto_x_sucursal.sucursal_id = dbo.Sucursal.sucursal_id
                      
               where Sucursal.sucursal_id = @sucursal_id 
               and
               Producto.prod_eliminado='no'
               
               order by dbo.Producto.prod_codinterno  asc

