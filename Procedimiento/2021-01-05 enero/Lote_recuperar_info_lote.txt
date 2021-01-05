USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Lote_recuperar_info_lote]    Script Date: 01/05/2021 13:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Lote_recuperar_info_lote]
@prod_id int,
@lote_nro varchar(max),
@sucursal_id int,
@prov_id int
---recupera toda la info de un lote especifico de un producto en una sucursal determinada.
as

select
Producto.prod_id,
Producto.prod_codinterno,
Producto.prod_descripcion,
Producto_x_sucursal.sucursal_id,     
Sucursal.sucursal_nombre,  
Producto_x_sucursal_lote.lote_id,
Producto_x_sucursal_lote.lote_nro,    
Producto_x_sucursal_lote.lote_cantidad  
from Producto inner join Producto_x_sucursal on Producto.prod_id = Producto_x_sucursal.prod_id 
inner join Producto_x_sucursal_lote on Producto_x_sucursal.ProdxSuc_ID = Producto_x_sucursal_lote.ProdxSuc_ID 
inner join Sucursal on Producto_x_sucursal.sucursal_id = sucursal.sucursal_id 
where Producto_x_sucursal_lote.lote_nro = @lote_nro and producto.prod_id = @prod_id and sucursal.sucursal_id = @sucursal_id
and Producto_x_sucursal_lote.Prov_id = @prov_id     
order by Producto_x_sucursal_lote.lote_nro asc    