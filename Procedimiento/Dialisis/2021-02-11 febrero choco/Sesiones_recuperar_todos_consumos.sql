ALTER procedure [dbo].[Sesiones_recuperar_todos_consumos]
@PAC_id int

as

select 
Consumo_Mercaderia.Consumo_mercaderia_id,    
Consumo_Mercaderia.Consumo_mercaderia_FechaHora as 'Fecha',
sesiones.Sesiones_id,
sesiones.Sesiones_fecha as 'fecha_sesion',
Consumo_Mercaderia_detalle.Consumo_mercaderiadetalle_cantidad as 'cantidad',
Consumo_Mercaderia_detalle.prod_codinterno,
--Producto.prod_descripcion+ ', lote Nº: ' +convert(varchar(max),Producto_x_sucursal_lote.lote_nro)as 'Insumo'
Producto.prod_descripcion as 'Insumo',
Producto.prod_unidadmedida    
from Consumo_Mercaderia inner join Consumo_Mercaderia_detalle on Consumo_Mercaderia.Consumo_mercaderia_id = Consumo_Mercaderia_detalle.Consumo_mercaderia_id 
inner join Sesiones on sesiones.Sesiones_id = Consumo_Mercaderia.Sesiones_id  
inner join producto on producto.prod_codinterno = Consumo_Mercaderia_detalle.prod_codinterno   
inner join Producto_x_sucursal_lote on Consumo_Mercaderia_detalle.lote_id = Producto_x_sucursal_lote.lote_id   

where sesiones.PAC_id = @PAC_id 
order by Producto.prod_codinterno asc  
