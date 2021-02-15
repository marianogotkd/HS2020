USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Venta_obtenerProducto_Combos_categoria_GM]    Script Date: 02/04/2021 18:18:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Venta_obtenerProducto_Combos_categoria_GM]
@sucursal_id int --paso este id, y traigo todo los productos de una sucursal
as
select
---trae todos los productos de una sucursal, filtrados SOLO por marca
dbo.Producto.prod_id, 
dbo.Producto.prod_codinterno, 
dbo.Producto.prod_descripcion, 
dbo.Producto.prod_descrilarga, 
dbo.Producto.prod_precio_vta, 
dbo.Producto_x_sucursal.ProdxSuc_stock as prod_stock,
dbo.Producto_x_sucursal.ProdxSuc_ptorepo as prod_ptorepo, 
Producto.prod_codbarra,
Producto.prod_precio_vta_May,
--Marca.marca_id, 
--Marca.Marca_nom
Producto.prod_idcat  as 'idcat', --esta es el id q se busca en diferentes tablas: cat 1, 2 y 3
Producto.prod_nrocat as 'nrocat',
convert(varchar,Producto.prod_contenido) + ' ' +Producto.prod_unidadmedida as 'Contenido',
convert(varchar,Producto_x_sucursal.ProdxSuc_stock_real)+' '+Producto.prod_unidadmedida as 'Contenido_total' 
from Producto inner join Producto_x_sucursal on Producto.prod_id = Producto_x_sucursal.prod_id 
inner join Sucursal  on Producto_x_sucursal.sucursal_id = Sucursal.sucursal_id
where Producto_x_sucursal.sucursal_id=@sucursal_id and Producto.prod_eliminado='no'




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
