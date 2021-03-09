USE [SantaFe]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Presupuesto_modificar_estado]
@presupuesto_id int,
@presupuesto_estado varchar(50)
as
update Presupuesto set Presupuesto.presupuesto_estado = @presupuesto_estado where presupuesto_id = @presupuesto_id  
