USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_sucursal_ALTA]    Script Date: 01/21/2021 20:06:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_x_sucursal_ALTA]
@prod_id int, 
@sucursal_id int, 
@ProdxSuc_stock int, 
@ProdxSuc_ptorepo int,
@ProdxSuc_stock_real decimal(38,2)
as

insert Producto_x_sucursal
(prod_id, 
sucursal_id, 
ProdxSuc_stock, 
ProdxSuc_ptorepo,
ProdxSuc_stock_real) 
values 
(@prod_id, 
@sucursal_id, 
@ProdxSuc_stock, 
@ProdxSuc_ptorepo,
@ProdxSuc_stock_real)

