USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Sesiones_alta]    Script Date: 02/04/2021 11:27:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sesiones_alta]

@PAC_id int, 
@Sesiones_fecha datetime, 
@Sesiones_asistencia varchar(50),
@Sesiones_estado varchar(50)

as
insert Sesiones (PAC_id, Sesiones_fecha, Sesiones_asistencia, Sesiones_estado ) values (@PAC_id, @Sesiones_fecha, @Sesiones_asistencia, @Sesiones_estado )

select @@IDENTITY 
