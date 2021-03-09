USE [SantaFe]
GO
/****** Object:  StoredProcedure [dbo].[Remito_alta]    Script Date: 03/08/2021 19:59:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Presupuesto_alta]

@ventaprod_id int,
@presupuesto_fecha datetime,
@presupuesto_estado varchar(50)
as

insert Presupuesto (presupuesto_fecha, presupuesto_estado, ventaprod_id) values (@presupuesto_fecha, @presupuesto_estado, @ventaprod_id )

select presupuesto_id from Presupuesto where Presupuesto.ventaprod_id = @ventaprod_id 
