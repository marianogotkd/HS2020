USE [SantaFe]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Presupuesto_recuperar_productos]
@presupuesto_id int
as
SELECT     dbo.Presupuesto.*, dbo.Venta_Producto.ventaprod_tipovta, 
dbo.Venta_Producto.ventaprod_total, 
dbo.Venta_Producto.ventaprod_fecha, 
dbo.Venta_Producto.ventaprod_estado, 
dbo.Venta_Producto.ventaprod_subtotal, 
                      dbo.Venta_Producto.ventaprod_descuento_pesos, 
                      dbo.Venta_Producto.ventaprod_descuento_porcentaje, 
                      dbo.Venta_Producto.ventaprod_iva_porcentaje,
                      dbo.Venta_Producto.ventaprod_iva_pesos, 
                      dbo.Venta_Producto.ventaprod_observacion, 
                      dbo.Venta_Producto_detalle.ventaprodetalle_id, 
                      dbo.Venta_Producto_detalle.ventaprod_cant, 
                      dbo.Venta_Producto_detalle.ventaprod_precio, 
                      dbo.Venta_Producto_detalle.ventaprod_subtotal AS producto_subtotal, 
                      dbo.Venta_Producto_detalle.ventaprod_descripcion, 
                      dbo.Producto.prod_descrilarga, 
                      dbo.Venta_Producto_detalle.ventaprod_descuento_porc, 
                      dbo.Venta_Producto_detalle.codigointerno,
                      dbo.Venta_Producto_detalle.prod_id,
                      dbo.Producto.prod_codbarra ,
                      dbo.Usuario.sucursal_id  
FROM         dbo.Venta_Producto INNER JOIN
                      dbo.Venta_Producto_detalle ON dbo.Venta_Producto.ventaprod_id = dbo.Venta_Producto_detalle.ventaprod_id 
                      INNER JOIN dbo.Presupuesto ON dbo.Venta_Producto.ventaprod_id = dbo.Presupuesto.ventaprod_id
                      inner join Producto on Venta_Producto_detalle.prod_id  = Producto.prod_id   
                      inner join Usuario on Venta_Producto.usuario_id = Usuario.USU_id  
                      where Presupuesto.presupuesto_id = @presupuesto_id order by Venta_Producto_detalle.codigointerno asc

