ALTER procedure [dbo].[Unidad_medida_obtener_todo]
as

select
unid_medida_id, unid_medida_desc
from dbo.Unidad_medida order by unid_medida_desc asc

