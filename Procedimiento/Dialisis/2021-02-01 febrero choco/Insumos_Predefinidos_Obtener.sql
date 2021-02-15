USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Insumos_Predefinidos_Obtener]    Script Date: 02/01/2021 12:14:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Insumos_Predefinidos_Obtener]
as
select Predef_id, predef_cant, Predef_Desc,Insumos_Predefinidos.prod_codinterno, Producto.prod_id,
Producto.prod_descripcion 
  from Insumos_Predefinidos INNER JOIN Producto on Producto.prod_codinterno = Insumos_Predefinidos.prod_codinterno
 