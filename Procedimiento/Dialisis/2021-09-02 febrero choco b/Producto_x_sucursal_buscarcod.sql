ALTER procedure [dbo].[Producto_x_sucursal_buscarcod]

@prod_codinterno as integer,
@sucursal_id as integer

as


select 
Producto_x_sucursal.prod_id,
Producto_x_sucursal.ProdxSuc_stock,
Producto.prod_precio_vta,
Producto.prod_descripcion,
Producto_x_sucursal.ProdxSuc_ID,
Producto_x_sucursal.ProdxSuc_stock_real 
from Producto inner join Producto_x_sucursal on Producto.prod_id = Producto_x_sucursal.prod_id
where Producto.prod_codinterno = @prod_codinterno and Producto_x_sucursal.sucursal_id= @sucursal_id    
and Producto.prod_eliminado='no'

select * from Producto_x_sucursal 

