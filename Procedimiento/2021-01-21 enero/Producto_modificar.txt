USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_modificar]    Script Date: 01/21/2021 17:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_modificar]
@prod_descripcion varchar(max),
@prod_descrilarga varchar (max),
@prod_precio_vta decimal(8,2),
@prod_codinterno int,
@prod_codbarra varchar (max),
@prod_idcat int,
@prod_nrocat int,
@marca_id int,
@prod_unidadmedida varchar(max), 
@prod_foto varbinary(max),
@prod_precio_vta_May decimal(8,2),
--@prod_id int,
--@prod_precio_vta decimal(8,2),
--@prod_stock int,
@prod_ptorepo int,
@prod_tipo varchar(50),
@prod_lote varchar(2),
@prod_contenido decimal(38,2)

as

update Producto set 
prod_descripcion =@prod_descripcion , 
prod_descrilarga=@prod_descrilarga , 
prod_precio_vta=@prod_precio_vta , 
prod_codbarra=@prod_codbarra , 
prod_idcat=@prod_idcat , 
prod_nrocat=@prod_nrocat , 
marca_id=@marca_id , 
prod_unidadmedida=@prod_unidadmedida , 
prod_foto=@prod_foto , 
prod_precio_vta_May=@prod_precio_vta_May,
prod_ptorepo=@prod_ptorepo,
prod_tipo=@prod_tipo,
prod_lote=@prod_lote,
prod_contenido = @prod_contenido      
where Producto.prod_codinterno=@prod_codinterno

select prod_id from Producto where prod_codinterno=@prod_codinterno


--update Producto set 

--prod_precio_vta=@prod_precio_vta,
--prod_stock=@prod_stock,
--prod_ptorepo=@prod_ptorepo

--where prod_id=@prod_id