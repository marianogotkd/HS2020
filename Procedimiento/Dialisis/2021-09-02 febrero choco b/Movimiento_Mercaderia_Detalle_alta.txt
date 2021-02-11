ALTER procedure [dbo].[Movimiento_Mercaderia_Detalle_alta]

@MovMerDet_Cantidad decimal(38,2),
@MovMer_id int,
@prod_codinterno int,
@lote_id int,
@MovMerDet_precioU decimal(38,2),
@MovMerDet_subtotal decimal(38,2)


as

insert dbo.Movimiento_Mercaderia_Detalle (MovMerDet_Cantidad, MovMer_id, prod_codinterno, lote_id,MovMerDet_precioU,MovMerDet_subtotal  )

values (@MovMerDet_Cantidad, @MovMer_id , @prod_codinterno, @lote_id, @MovMerDet_precioU, @MovMerDet_subtotal )


