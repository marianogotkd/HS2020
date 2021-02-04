create procedure UsuarioActividad_registrar_sesiones_dialisis
@USU_id int,
@sucursal_id int,
@sesiones_id int,
@ACT_fecha datetime,
--@ACT_hora time(7),
@ACT_sesion varchar(max)


as

insert dbo.UsuarioActividad (USU_id, ACT_fecha,ACT_sesion,Sesiones_id, sucursal_id)
values( @USU_id, @ACT_fecha, @ACT_sesion, @sesiones_id, @sucursal_id)

go