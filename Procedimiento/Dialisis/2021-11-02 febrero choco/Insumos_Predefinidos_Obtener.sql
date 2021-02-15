create procedure [dbo].[Insumos_Predefinidos_Obtener]
as
select Insumos_Predefinidos.prod_unidadmedida, Predef_id, predef_cant, Predef_Desc,Insumos_Predefinidos.prod_codinterno, Producto.prod_id,
Producto.prod_descripcion 
  from Insumos_Predefinidos INNER JOIN Producto on Producto.prod_codinterno = Insumos_Predefinidos.prod_codinterno
