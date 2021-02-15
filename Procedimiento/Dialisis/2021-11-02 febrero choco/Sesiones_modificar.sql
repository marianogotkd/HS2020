ALTER procedure [dbo].[Sesiones_modificar]
@Sesiones_id int,
@Sesiones_fecha datetime,
@Sesiones_asistencia varchar(50),
@Sesiones_estado varchar(50)
as
update Sesiones set Sesiones_fecha=@Sesiones_fecha , Sesiones_asistencia = @Sesiones_asistencia, Sesiones_estado = @Sesiones_estado 
where sesiones.Sesiones_id = @Sesiones_id 

