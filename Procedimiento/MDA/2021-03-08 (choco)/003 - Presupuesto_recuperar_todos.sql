USE [SantaFe]
GO
/****** Object:  StoredProcedure [dbo].[Remito_recuperar_todos]    Script Date: 03/08/2021 20:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[Presupuesto_recuperar_todos]


as

--0) trae los clientes en la bd
select  presupuesto_id, 
presupuesto_fecha, 
presupuesto_estado, 
Venta_Producto.ventaprod_id,
Cliente.CLI_Fan as 'Fantasia',
Cliente.CLI_id ,
Venta_Producto.ventaprod_total   
FROM         dbo.Venta_Producto INNER JOIN
                      dbo.Presupuesto ON dbo.Venta_Producto.ventaprod_id = dbo.Presupuesto.ventaprod_id INNER JOIN
                      dbo.Cliente ON dbo.Venta_Producto.cliente_id = dbo.Cliente.CLI_id                   
                      where Presupuesto.presupuesto_estado = 'pendiente entrega'
                      order by Presupuesto.presupuesto_id asc 
                      
--1) trae los consumidores finales                      
select  presupuesto_id, 
presupuesto_fecha, 
presupuesto_estado, 
Venta_Producto.ventaprod_id,
'Consumidor Final' as 'Fantasia',
Venta_Producto.cliente_id,
Venta_Producto.ventaprod_total   

FROM         dbo.Venta_Producto INNER JOIN
                      dbo.Presupuesto ON dbo.Venta_Producto.ventaprod_id = dbo.Presupuesto.ventaprod_id                  
                      where Presupuesto.presupuesto_estado = 'pendiente entrega' and presupuesto_id = 0
                      order by Presupuesto.presupuesto_id asc 
                      