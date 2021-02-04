USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Lote_buscar_producto]    Script Date: 02/04/2021 15:57:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Lote_buscar_producto]
---recupero todos los lotes de un producto especifico. buscar por prod_codinterno
@prod_codinterno int,
@sucursal_id int
as

select 
Producto.prod_descripcion,
Producto_x_sucursal_lote.lote_id, Producto_x_sucursal_lote.lote_nro  
from Producto inner join dbo.Producto_x_sucursal on Producto.prod_id = Producto_x_sucursal.prod_id
inner join Producto_x_sucursal_lote on Producto_x_sucursal.ProdxSuc_ID =  Producto_x_sucursal_lote.ProdxSuc_ID
where Producto.prod_codinterno = @prod_codinterno and   Producto_x_sucursal.sucursal_id = @sucursal_id  
order by Producto_x_sucursal_lote.lote_id asc 

---choco ahora uso, porque tengo q controlar el total de lotes, no importa en q sucursal este
select 
Producto.prod_descripcion,
Producto_x_sucursal_lote.lote_id, Producto_x_sucursal_lote.lote_nro  
from Producto inner join dbo.Producto_x_sucursal on Producto.prod_id = Producto_x_sucursal.prod_id
inner join Producto_x_sucursal_lote on Producto_x_sucursal.ProdxSuc_ID =  Producto_x_sucursal_lote.ProdxSuc_ID
where Producto.prod_codinterno = @prod_codinterno   
order by Producto_x_sucursal_lote.lote_id  asc 


