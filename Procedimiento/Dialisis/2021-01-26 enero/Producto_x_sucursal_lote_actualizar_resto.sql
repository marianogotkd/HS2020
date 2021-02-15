USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_sucursal_lote_actualizar_resto]    Script Date: 01/26/2021 15:42:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_x_sucursal_lote_actualizar_resto]
@lote_nro varchar(max),
@prod_id int,
@sucursal_id int,
@lote_cantidad decimal(38,2), ----este parametro es lo que quiero quitar
@Prov_id int,
@lote_stock_real_a decimal (38,2),
@lote_aux decimal(38,2)
as
declare @ProdxSuc_ID int
select @ProdxSuc_ID = Producto_x_sucursal.ProdxSuc_ID from Producto_x_sucursal where prod_id = @prod_id and sucursal_id=@sucursal_id 

declare @stock_lote decimal(38,2)

select @stock_lote = lote_cantidad from Producto_x_sucursal_lote where lote_nro = @lote_nro and ProdxSuc_ID=@ProdxSuc_ID  and Producto_x_sucursal_lote.Prov_id = @Prov_id   

declare @diferencia decimal(38,2)
select @diferencia = @stock_lote - @lote_cantidad  

declare @lote_stock_real decimal (38,2) 
select @lote_stock_real = lote_stock_real from Producto_x_sucursal_lote where lote_nro = @lote_nro and ProdxSuc_ID=@ProdxSuc_ID  and Producto_x_sucursal_lote.Prov_id = @Prov_id   

declare @diferencia_real decimal(38,2)
select @diferencia_real = @lote_stock_real - @lote_stock_real_a 


update Producto_x_sucursal_lote set lote_cantidad = @diferencia, lote_stock_real = @diferencia_real, lote_aux = @lote_aux where lote_nro = @lote_nro and ProdxSuc_ID = @ProdxSuc_ID and Producto_x_sucursal_lote.Prov_id = @Prov_id   



select lote_id   from Producto_x_sucursal_lote where lote_nro = @lote_nro and ProdxSuc_ID = @ProdxSuc_ID  and Producto_x_sucursal_lote.Prov_id = @Prov_id 
