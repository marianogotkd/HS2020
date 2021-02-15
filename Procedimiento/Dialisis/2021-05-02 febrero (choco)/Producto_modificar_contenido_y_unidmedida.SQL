create procedure [dbo].[Producto_modificar_contenido_y_unidmedida]
@prod_codinterno int,
@prod_unidadmedida varchar(max), 
@prod_contenido decimal(38,2)

as
update Producto set 
prod_unidadmedida=@prod_unidadmedida , 
prod_contenido = @prod_contenido      
where Producto.prod_codinterno=@prod_codinterno

select prod_id from Producto where prod_codinterno=@prod_codinterno

go