create procedure Consumo_Mercaderia_Detalle_eliminar
@Consumo_mercaderia_id int,
@prod_codinterno int,
@lote_id int
as
delete from Consumo_Mercaderia_detalle where Consumo_mercaderia_id = @Consumo_mercaderia_id and prod_codinterno = @prod_codinterno and lote_id = @lote_id 

go