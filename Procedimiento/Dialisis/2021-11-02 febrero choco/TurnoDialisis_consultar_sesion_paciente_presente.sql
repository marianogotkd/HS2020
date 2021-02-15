create procedure [dbo].[TurnoDialisis_consultar_sesion_paciente_presente]
@PAC_id int

---este procediento me va a recuperar todas las sesiones de un paciente en especifico ordenado por fecha ASC

as
---recupero un solo registro que tiene la info de la sesion
----esta recupera solo presentes
select 
Sesiones.Sesiones_id, Paciente.PAC_id, Sesiones_fecha, Sesiones_asistencia, 
---ahora los datos del paciente
PAC_ape+', '+PAC_nom as 'Paciente',
PAC_dni,
PAc_dir,
PACnumafi,
Obra_Social.Obrasocial_nombre   
from Sesiones inner join Paciente on Sesiones.PAC_id = Paciente.PAC_id 
inner join Obra_Social on Paciente.Obrasocial_id = Obra_Social.Obrasocial_id    
where Sesiones.PAC_id = @PAC_id and Sesiones.Sesiones_asistencia = 'Presente' order by Sesiones.Sesiones_fecha  ASC 