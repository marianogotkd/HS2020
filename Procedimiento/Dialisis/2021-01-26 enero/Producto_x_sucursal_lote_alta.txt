USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_sucursal_lote_alta]    Script Date: 01/26/2021 15:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_x_sucursal_lote_alta]
@lote_nro varchar(max),
@lote_cantidad decimal(38,2),
@lote_fechafab datetime,
@lote_fechavto datetime,
@prod_id int,
@sucursal_id int,
@lote_vence varchar(2),
@Prov_id int,
@lote_stock_real decimal(38,2),
@lote_aux decimal(38,2)


as
declare @ProdxSuc_ID int
select @ProdxSuc_ID = Producto_x_sucursal.ProdxSuc_ID from Producto_x_sucursal 
where prod_id = @prod_id and sucursal_id=@sucursal_id  


insert Producto_x_sucursal_lote (lote_nro, lote_cantidad, lote_fechafab, lote_fechavto, ProdxSuc_ID, lote_vence, Producto_x_sucursal_lote.Prov_id, lote_stock_real, lote_aux) 
values
(@lote_nro , @lote_cantidad, @lote_fechafab, @lote_fechavto, @ProdxSuc_ID, @lote_vence, @Prov_id, @lote_stock_real , @lote_aux)

select lote_id   from Producto_x_sucursal_lote where lote_nro = @lote_nro and ProdxSuc_ID =@ProdxSuc_ID and Producto_x_sucursal_lote.Prov_id=@Prov_id 

