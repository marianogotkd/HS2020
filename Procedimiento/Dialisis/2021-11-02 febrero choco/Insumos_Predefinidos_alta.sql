create procedure [dbo].[Insumos_Predefinidos_alta]

@predef_cant decimal(38,2),
@Predef_Desc varchar(max),
@prod_codinterno int,
@prod_unidadmedida varchar(50)

as


insert Insumos_Predefinidos (predef_cant,Predef_Desc,prod_codinterno,prod_unidadmedida)

values (@predef_cant,@Predef_Desc,@prod_codinterno,@prod_unidadmedida)
