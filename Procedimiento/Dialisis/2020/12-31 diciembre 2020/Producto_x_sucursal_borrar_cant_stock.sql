create procedure Producto_x_sucursal_borrar_cant_stock

@sucursal_id int
as

update Producto_x_sucursal set ProdxSuc_stock = 0 where sucursal_id = @sucursal_id 

go