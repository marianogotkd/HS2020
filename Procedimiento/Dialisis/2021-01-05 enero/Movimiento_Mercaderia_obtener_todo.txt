USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Movimiento_Mercaderia_obtener_todo]    Script Date: 01/05/2021 17:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Movimiento_Mercaderia_obtener_todo]
as
select
MovMer_id, 
MovMer_Concepto, 
MovMer_FechaHora, 
sucursal_id_Origen, 
Sucursal.sucursal_nombre as 'Origen',
sucursal_id_Destino,
' ' as 'Destino',
Usuario.USU_ape+', '+Usuario.USU_nom as 'Usuario', 
usuario.USU_id,
MovMerTipo_id  
from dbo.Movimiento_Mercaderia inner join Sucursal on Movimiento_Mercaderia.sucursal_id_Origen = Sucursal.sucursal_id
inner join Usuario on Movimiento_Mercaderia.USU_id= Usuario.USU_id   order by Movimiento_Mercaderia.MovMer_id desc

---necesito sucursal para cargar en visual la sucursal de destino, ya q no puedo hacer un inner join
select * from Sucursal order by Sucursal.sucursal_id asc

