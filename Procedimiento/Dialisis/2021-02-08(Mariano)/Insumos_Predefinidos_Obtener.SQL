USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Insumos_Predefinidos_Obtener]    Script Date: 02/08/2021 10:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Insumos_Predefinidos_Obtener]
as
select Insumos_Predefinidos.prod_unidadmedida, Predef_id, predef_cant, Predef_Desc,Insumos_Predefinidos.prod_codinterno, Producto.prod_id,
Producto.prod_descripcion 
  from Insumos_Predefinidos INNER JOIN Producto on Producto.prod_codinterno = Insumos_Predefinidos.prod_codinterno
 