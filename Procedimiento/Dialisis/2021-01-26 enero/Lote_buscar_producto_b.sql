alter procedure Lote_buscar_producto_b
@lote_id int

as
select * from Producto_x_sucursal_lote where Producto_x_sucursal_lote.lote_id = @lote_id 
go