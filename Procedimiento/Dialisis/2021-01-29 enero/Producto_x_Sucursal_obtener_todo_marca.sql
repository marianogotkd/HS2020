USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_Sucursal_obtener_todo_marca]    Script Date: 01/29/2021 15:17:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_x_Sucursal_obtener_todo_marca]
@Sucursal_id int, ---lo necesito para saber el stock en c/u de las sucursales
@marca_id int
as

SELECT     dbo.Producto.prod_descripcion, 
dbo.Producto.prod_precio_vta, 
dbo.Producto.prod_id, 
dbo.Producto.prod_codinterno, 
dbo.Producto.prod_ptorepo, 
dbo.Producto.prod_precio_vta_May, 
                      dbo.Producto_x_sucursal.ProdxSuc_stock, 
                      dbo.Producto_x_sucursal.sucursal_id,
                      Producto.prod_idcat  as 'idcat', --esta es el id q se busca en diferentes tablas: cat 1, 2 y 3
Producto.prod_nrocat as 'nrocat', Producto.prod_codbarra ,
convert(varchar,Producto.prod_contenido) + ' ' +Producto.prod_unidadmedida as 'Contenido', convert(varchar,Producto_x_sucursal.ProdxSuc_stock_real)+' '+Producto.prod_unidadmedida as 'Contenido_total' 
FROM         dbo.Producto INNER JOIN
                      dbo.Producto_x_sucursal ON dbo.Producto.prod_id = dbo.Producto_x_sucursal.prod_id INNER JOIN
                      dbo.Sucursal ON dbo.Producto_x_sucursal.sucursal_id = dbo.Sucursal.sucursal_id
                      inner join Marca on Producto.marca_id=Marca.Marca_id
               where Sucursal.sucursal_id = @sucursal_id and marca.Marca_id=@marca_id 
               and Producto.prod_eliminado='no'
               order by dbo.Producto.prod_descripcion asc



---aqui recupero todas categorias, rubros y subrubros
SELECT 
Categoria_1.cat_id as Categoria_cat_id,
Categoria_1.cat1_nom as Categoria_nombre
FROM Categoria_1

---categoria y rubro
SELECT 
Categoria_1.cat_id as Categoria_cat_id,
Categoria_1.cat1_nom as Categoria_nombre,
Categoria_2.cat2_id as Rubro_cat2_id,
Categoria_2.cat2_nom as Rubro_nombre
FROM Categoria_1 inner join Categoria_2 ON Categoria_1.cat_id = Categoria_2.cat1_id

---categoria, rubro, subrubro
SELECT 
Categoria_1.cat_id as Categoria_cat_id,
Categoria_1.cat1_nom as Categoria_nombre,
Categoria_2.cat2_id as Rubro_cat2_id,
Categoria_2.cat2_nom as Rubro_nombre,
Categoria_3.cat3_id as Subrubro_cat3_id,
Categoria_3.cat3_nom as Subrubro_cat3_nombre
FROM  dbo.Categoria_3 INNER JOIN
               dbo.Categoria_2 ON dbo.Categoria_3.cat2_id = dbo.Categoria_2.cat2_id INNER JOIN
               dbo.Categoria_1 ON dbo.Categoria_2.cat1_id = dbo.Categoria_1.cat_id