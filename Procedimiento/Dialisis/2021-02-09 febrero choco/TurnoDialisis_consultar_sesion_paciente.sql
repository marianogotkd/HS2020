USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[TurnoDialisis_consultar_sesion_paciente]    Script Date: 02/09/2021 03:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[TurnoDialisis_consultar_sesion_paciente]
@PAC_id int

---este procediento me va a recuperar todas las sesiones de un paciente en especifico ordenado por fecha ASC

as
---recupero un solo registro que tiene la info de la sesion
----esta recupera ausentes y presentes
---no recupera dialisis, por que revienta el inner join
select 
Sesiones.Sesiones_id, Paciente.PAC_id, Sesiones_fecha, Sesiones_asistencia, 
---ahora los datos del paciente
PAC_ape+', '+PAC_nom as 'Paciente',
PAC_dni,
PAc_dir,
PACnumafi,
Obra_Social.Obrasocial_nombre,
Sesiones.Sesiones_estado    
from Sesiones inner join Paciente on Sesiones.PAC_id = Paciente.PAC_id 
inner join Obra_Social on Paciente.Obrasocial_id = Obra_Social.Obrasocial_id    
where Sesiones.PAC_id = @PAC_id order by Sesiones.Sesiones_fecha  ASC 


---recupero un solo registro que tiene la info de la sesion y ademas la dialisis
select 
Sesiones.Sesiones_id, Paciente.PAC_id, Sesiones_fecha, Sesiones_asistencia,Dialisis_id , 
---ahora los datos del paciente
PAC_ape+', '+PAC_nom as 'Paciente',
PAC_dni,
PAc_dir,
PACnumafi,
Obra_Social.Obrasocial_nombre   
from Sesiones inner join Paciente on Sesiones.PAC_id = Paciente.PAC_id 
inner join Obra_Social on Paciente.Obrasocial_id = Obra_Social.Obrasocial_id    
inner join Dialisis on Sesiones.Sesiones_id = Dialisis.Sesiones_id
where Sesiones.PAC_id = @PAC_id order by Sesiones.Sesiones_fecha  ASC
