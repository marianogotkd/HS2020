create procedure [dbo].[Movimiento_Mercaderia_Alta_obtener_detalle_Ajustes]
---choco 31-08-2020 este procedimiento lo utilizo para consultar en el formulario: Consulta_alta_b

as
select Producto.prod_codinterno,
Producto.prod_descripcion as 'prod_descripcion',
Movimiento_Mercaderia_Detalle.MovMerDet_Cantidad,
Movimiento_Mercaderia.MovMer_FechaHora,
Movimiento_Mercaderia.MovMer_id, ---este me sirve para agrupar por factura 
Movimiento_Mercaderia.MovMer_Concepto,  
sucursal_id_Origen, 
Sucursal.sucursal_nombre as 'Origen',
Usuario.USU_ape+', '+Usuario.USU_nom as 'Usuario', 
usuario.USU_id,
Proveedor.Prov_id ,
Proveedor.Prov_nombre   
--MovMerDet_precioU, 
--MovMerDet_subtotal
from Movimiento_Mercaderia_Detalle inner join Producto 
on Movimiento_Mercaderia_Detalle.prod_codinterno = Producto.prod_codinterno 
inner join Producto_x_sucursal_lote on Movimiento_Mercaderia_Detalle.lote_id = Producto_x_sucursal_lote.lote_id   
inner join Movimiento_Mercaderia on Movimiento_Mercaderia.MovMer_id= Movimiento_Mercaderia_Detalle.MovMer_id    
inner join Sucursal on Movimiento_Mercaderia.sucursal_id_Origen = Sucursal.sucursal_id
inner join Usuario on Movimiento_Mercaderia.USU_id= Usuario.USU_id
inner join Proveedor on Movimiento_Mercaderia.Prov_id = Proveedor.Prov_id
where   MovMerTipo_id=4 ---esto solo me trae los ingresos
order by Movimiento_Mercaderia_Detalle.prod_codinterno asc  