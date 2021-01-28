USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Sucursal_obtener_producto]    Script Date: 01/22/2021 14:40:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sucursal_obtener_producto]
@prod_id int,
@suc_id_Origen int,
@suc_id_destino int
as
Select ProdxSuc_stock as 'Stock_Origen', ProdxSuc_stock_real, Producto.prod_contenido, Producto.prod_unidadmedida   from Producto_x_sucursal
inner join Producto on Producto_x_sucursal.prod_id = Producto.prod_id
 where  Producto_x_sucursal.prod_id=@prod_id and sucursal_id=@suc_id_Origen

---choco 21-01-2021 recupero el campo stock_real, prod_contenido
Select ProdxSuc_stock as 'Stock_Destino', ProdxSuc_stock_real, Producto.prod_contenido, Producto.prod_unidadmedida, Producto.prod_tipo  from Producto_x_sucursal inner join Producto on Producto_x_sucursal.prod_id = Producto.prod_id
 where Producto_x_sucursal.prod_id=@prod_id and sucursal_id=@suc_id_destino