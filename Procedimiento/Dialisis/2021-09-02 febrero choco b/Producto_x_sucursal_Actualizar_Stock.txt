USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_sucursal_Actualizar_Stock]    Script Date: 02/09/2021 18:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Producto_x_sucursal_Actualizar_Stock]
@prod_id as int,
@suc_id as int,
@Cant as decimal(38,2),
@STOCK_REAL_NUEVO decimal(38,2) 
as
update Producto_x_sucursal
set ProdxSuc_stock=@Cant, ProdxSuc_stock_real=@STOCK_REAL_NUEVO  
where prod_id=@prod_id and sucursal_id=@suc_id