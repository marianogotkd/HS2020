USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Sesiones_modificar]    Script Date: 02/04/2021 11:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sesiones_modificar]
@Sesiones_id int,
@Sesiones_fecha datetime,
@Sesiones_asistencia varchar(50),
@Sesiones_estado varchar(50)
as
update Sesiones set Sesiones_fecha=@Sesiones_fecha , Sesiones_asistencia = @Sesiones_asistencia, Sesiones_estado = @Sesiones_estado 
where sesiones.Sesiones_id = @Sesiones_id 
