create procedure Ajuste_lote_vencimiento
@lote_id int,
@lote_vence varchar(2),
@lote_fechafab datetime,
@lote_fechavto datetime

as

update Producto_x_sucursal_lote set lote_vence = @lote_vence, 
									lote_fechafab = @lote_fechafab, 
									lote_fechavto=@lote_fechavto
									where Producto_x_sucursal_lote.lote_id = @lote_id     

go