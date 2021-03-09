USE [SantaFe]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Presupuesto_recuperar]

@presupuesto_id int
as
SELECT     dbo.Presupuesto.presupuesto_id, dbo.Presupuesto.presupuesto_estado, dbo.Presupuesto.ventaprod_id, dbo.Venta_Producto.ventaprod_observacion, dbo.Venta_Producto.vendedor_id,
Venta_Producto.usuario_id,Presupuesto.presupuesto_fecha, SucxClie_id  

FROM         dbo.Presupuesto INNER JOIN
                      dbo.Venta_Producto ON dbo.Presupuesto.ventaprod_id = dbo.Venta_Producto.ventaprod_id INNER JOIN
                      dbo.Vendedor ON dbo.Venta_Producto.vendedor_id = dbo.Vendedor.vendedor_id 
                      where Presupuesto.presupuesto_id = @presupuesto_id 
                      
                      
