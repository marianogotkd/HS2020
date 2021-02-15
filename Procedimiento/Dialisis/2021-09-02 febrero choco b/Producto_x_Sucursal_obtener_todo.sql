USE [Dialisis]
GO
/****** Object:  StoredProcedure [dbo].[Producto_x_Sucursal_obtener_todo]    Script Date: 02/10/2021 03:00:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Producto_x_Sucursal_obtener_todo]
@sucursal_id int
as
--0) todos los productos de la sucursal y para la marca
SELECT     dbo.Producto.prod_descripcion, dbo.Producto.prod_precio_vta, dbo.Producto.prod_id, dbo.Producto.prod_codinterno, dbo.Producto.prod_ptorepo, dbo.Producto.prod_precio_vta_May, 
                      dbo.Producto_x_sucursal.ProdxSuc_stock, dbo.Producto_x_sucursal.sucursal_id,
                      Producto.prod_codbarra,convert(varchar,Producto.prod_contenido) + ' ' +Producto.prod_unidadmedida as 'Contenido', convert(varchar,Producto_x_sucursal.ProdxSuc_stock_real)+' '+Producto.prod_unidadmedida as 'Contenido_total', Producto.marca_id ,
                      Producto.prod_idcat  as 'idcat', --esta es el id q se busca en diferentes tablas: cat 1, 2 y 3
Producto.prod_nrocat as 'nrocat'
          FROM         dbo.Producto INNER JOIN
                      dbo.Producto_x_sucursal ON dbo.Producto.prod_id = dbo.Producto_x_sucursal.prod_id INNER JOIN
                      dbo.Sucursal ON dbo.Producto_x_sucursal.sucursal_id = dbo.Sucursal.sucursal_id
                      
               where Sucursal.sucursal_id = @sucursal_id 
               and
               Producto.prod_eliminado='no'
               
               order by dbo.Producto.prod_codinterno  asc
--1) todos los productos x proveedor, se pueden repetir si el prod tiene varios proveedores
SELECT     dbo.Producto.prod_descripcion, 
dbo.Producto.prod_precio_vta, 
dbo.Producto.prod_id, 
dbo.Producto.prod_codinterno, 
dbo.Producto.prod_ptorepo, 
dbo.Producto.prod_precio_vta_May, 
                      dbo.Producto_x_sucursal.ProdxSuc_stock, 
                      dbo.Producto_x_sucursal.sucursal_id,
                      Producto.prod_idcat  as 'idcat', --esta es el id q se busca en diferentes tablas: cat 1, 2 y 3
Producto.prod_nrocat as 'nrocat', Producto.prod_codbarra,
convert(varchar,Producto.prod_contenido) + ' ' +Producto.prod_unidadmedida as 'Contenido', convert(varchar,Producto_x_sucursal.ProdxSuc_stock_real)+' '+Producto.prod_unidadmedida as 'Contenido_total',
Proveedor.Prov_id   
FROM         dbo.Producto INNER JOIN
                      dbo.Producto_x_sucursal ON dbo.Producto.prod_id = dbo.Producto_x_sucursal.prod_id INNER JOIN
                      dbo.Sucursal ON dbo.Producto_x_sucursal.sucursal_id = dbo.Sucursal.sucursal_id
                      inner join Marca on Producto.marca_id=Marca.Marca_id
                      inner join ProveedorProducto on ProveedorProducto.prod_id = Producto_x_sucursal.prod_id 
                      inner join Proveedor on Proveedor.Prov_id = ProveedorProducto.Prov_id   
               where Sucursal.sucursal_id = @sucursal_id
               and Producto.prod_eliminado='no'
               order by dbo.Producto.prod_descripcion asc
               
               







---2)--aqui recupero todas categorias, rubros y subrubros
SELECT 
Categoria_1.cat_id as Categoria_cat_id,
Categoria_1.cat1_nom as Categoria_nombre
FROM Categoria_1

---3) categoria y rubro
SELECT 
Categoria_1.cat_id as Categoria_cat_id,
Categoria_1.cat1_nom as Categoria_nombre,
Categoria_2.cat2_id as Rubro_cat2_id,
Categoria_2.cat2_nom as Rubro_nombre
FROM Categoria_1 inner join Categoria_2 ON Categoria_1.cat_id = Categoria_2.cat1_id

--- 4) categoria, rubro, subrubro
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
               
               
----5) voy a traer todos los lotes de una sucursal, sin importar el producto
SELECT     dbo.Producto.prod_id, dbo.Producto.prod_codinterno, dbo.Producto.prod_descripcion, dbo.Producto_x_sucursal.ProdxSuc_stock, dbo.Producto_x_sucursal_lote.lote_id, 
                      dbo.Producto_x_sucursal_lote.lote_nro, dbo.Producto_x_sucursal_lote.lote_cantidad, dbo.Producto_x_sucursal_lote.lote_fechafab, dbo.Producto_x_sucursal_lote.lote_fechavto, 
                      dbo.Producto_x_sucursal_lote.lote_vence, dbo.Producto_x_sucursal.sucursal_id, Producto_x_sucursal_lote.Prov_id, Proveedor.Prov_nombre as 'Proveedor',
                         dbo.Producto_x_sucursal_lote.lote_stock_real, dbo.Producto_x_sucursal_lote.lote_aux, dbo.Producto.prod_tipo, Producto_x_sucursal.ProdxSuc_stock_real,
                         Producto.prod_unidadmedida, Producto.prod_contenido    
                      
FROM         dbo.Producto_x_sucursal_lote INNER JOIN
                      dbo.Producto_x_sucursal ON dbo.Producto_x_sucursal_lote.ProdxSuc_ID = dbo.Producto_x_sucursal.ProdxSuc_ID INNER JOIN
                      dbo.Producto ON dbo.Producto_x_sucursal.prod_id = dbo.Producto.prod_id
                      inner join Proveedor on Producto_x_sucursal_lote.Prov_id = Proveedor.Prov_id
                        
where Producto_x_sucursal.sucursal_id = @sucursal_id   and dbo.Producto_x_sucursal_lote.lote_cantidad> 0 
order by Producto.prod_codinterno asc
