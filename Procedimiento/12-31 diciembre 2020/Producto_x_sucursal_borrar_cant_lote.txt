create procedure Producto_x_sucursal_borrar_cant_lote

@sucursal_id int,
@prod_id int
as
declare @ProdxSuc_ID int
select @ProdxSuc_ID = ProdxSuc_ID from dbo.Producto_x_sucursal where sucursal_id = @sucursal_id and prod_id = @prod_id  

update dbo.Producto_x_sucursal_lote set lote_cantidad = 0 where ProdxSuc_ID= @ProdxSuc_ID   

go