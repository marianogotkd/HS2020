USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Dialisis_modificar]    Script Date: 02/01/2021 17:18:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Dialisis_modificar]
@fecha datetime,
@Sesiones_id int,
@Dialisis_PesoS decimal(18,2),
@Dialisis_Talla decimal(18,2),
@Dialisis_HI varchar(50),
@Dialisis_HE varchar(50),
@Dialisis_TiempoHD varchar(50),
@Dialisis_PesoI decimal(18,2),
@Dialisis_PesoE decimal(18,2),
@Dialisis_TAI decimal(18,2),
@Dialisis_TAE decimal(18,2),
@Dialisis_Filtro varchar(50),
@Dialisis_Obs varchar(50), 
@AccesoVascular varchar(max)
as

declare @dialisis_id int
select @dialisis_id = Dialisis.Dialisis_id from Sesiones inner join Dialisis on sesiones.Sesiones_id = Dialisis.Sesiones_id where Sesiones.Sesiones_id = @Sesiones_id 

update Dialisis set Dialisis_PesoS = @Dialisis_PesoS , 
Dialisis_Talla = @Dialisis_Talla ,
Dialisis_HI = @Dialisis_HI ,
Dialisis_HE= @Dialisis_HE ,
Dialisis_TiempoHD = @Dialisis_TiempoHD,
Dialisis_PesoI = @Dialisis_PesoI ,
Dialisis_PesoE = @Dialisis_PesoE,
Dialisis_TAE = @Dialisis_TAE ,
Dialisis_TAI = @Dialisis_TAI,
Dialisis_Filtro = @Dialisis_Filtro,
Dialisis_Obs = @Dialisis_Obs,
AccesoVascular = @AccesoVascular      
where dialisis.Dialisis_id=@dialisis_id 
