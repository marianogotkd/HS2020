USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Sesiones_recuperar_reporte_rangofechas]    Script Date: 02/05/2021 14:53:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[Sesiones_recuperar_reporte_rangofechas]
@fecha_desde datetime,
@fecha_hasta datetime,
@PAC_id int

as
select Sesiones.Sesiones_id, PAC_id, Sesiones_fecha, Sesiones_asistencia,
Dialisis_id, 
Dialisis_PesoS, 
Dialisis_Talla, 
Dialisis_HI, 
Dialisis_HE, 
Dialisis_TiempoHD, 
Dialisis_PesoI, 
Dialisis_PesoE, 
Dialisis_TAI, 
Dialisis_TAE, 
Dialisis_Filtro, 
Dialisis_Obs,
Dialisis.AccesoVascular
from Sesiones 
inner join Dialisis on Sesiones.Sesiones_id = Dialisis.Sesiones_id 
where (sesiones.Sesiones_fecha  between @fecha_desde  and @fecha_hasta) and Sesiones.PAC_id = @PAC_id and Sesiones.Sesiones_asistencia = 'Presente' 
--where (sesiones.Sesiones_fecha  between @fecha_desde  and DATEADD(day, 1, @fecha_hasta)) and Sesiones.PAC_id = @PAC_id and Sesiones.Sesiones_asistencia = 'Presente' 
order by Sesiones.Sesiones_fecha asc   

select
Paciente.PAC_id, Turnodialisis.Turnodialisis_id , Turnodialisis_desc, Turnodialisis_desde_hora, Turnodialisis_hasta_hora, Turnodialisis_desde_minutos, Turnodialisis_hasta_minutos
from Paciente inner join Turnodialisis on Paciente.Turnodialisis_id = Turnodialisis.Turnodialisis_id    where paciente.PAC_id = @PAC_id 

declare @turnodialisis_id int
select @turnodialisis_id = Turnodialisis.Turnodialisis_id from Paciente inner join Turnodialisis on Paciente.Turnodialisis_id = Turnodialisis.Turnodialisis_id where    paciente.PAC_id = @PAC_id 

select  Dias_id, Dias_desc, Turnodialisis_id  from Dias_dialisis where Dias_dialisis.Turnodialisis_id = @turnodialisis_id  

----aqui recupero la info del ultimo acceso vascular
select
AV_id, AV_titulo, AV_fecha, medico_id, paciente.PAC_id, AV_tipo, AV_fechaC, AV_fechaPu, AV_ubicacion, AV_obs
from Consulta_AccesoV inner join paciente on Consulta_AccesoV.PAC_id = paciente.PAC_id where paciente.PAC_id = @PAC_id order by Consulta_AccesoV.AV_id desc 


---aqui vienen los consumis si es que existen.
select 
Consumo_Mercaderia.Consumo_mercaderia_id,    
Consumo_Mercaderia.Consumo_mercaderia_FechaHora as 'Fecha',
sesiones.Sesiones_id,
sesiones.Sesiones_fecha as 'fecha_sesion',
Consumo_Mercaderia_detalle.Consumo_mercaderiadetalle_cantidad as 'cantidad',
Consumo_Mercaderia_detalle.prod_codinterno,
--Producto.prod_descripcion+ ', lote Nº: ' +convert(varchar(max),Producto_x_sucursal_lote.lote_nro)as 'Insumo',
Producto.prod_descripcion as 'Insumo',
Producto.prod_unidadmedida   
from Consumo_Mercaderia inner join Consumo_Mercaderia_detalle on Consumo_Mercaderia.Consumo_mercaderia_id = Consumo_Mercaderia_detalle.Consumo_mercaderia_id 
inner join Sesiones on sesiones.Sesiones_id = Consumo_Mercaderia.Sesiones_id  
inner join producto on producto.prod_codinterno = Consumo_Mercaderia_detalle.prod_codinterno   
inner join Producto_x_sucursal_lote on Consumo_Mercaderia_detalle.lote_id = Producto_x_sucursal_lote.lote_id   

where sesiones.PAC_id = @PAC_id and (sesiones.Sesiones_fecha  between @fecha_desde  and @fecha_hasta) 
--where sesiones.PAC_id = @PAC_id and (sesiones.Sesiones_fecha  between @fecha_desde  and DATEADD(day, 1, @fecha_hasta)) 
order by Sesiones.Sesiones_fecha asc
