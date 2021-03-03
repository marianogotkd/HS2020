ALTER procedure [dbo].[Movimiento_Mercaderia_alta]

@MovMer_Concepto varchar(max),
@MovMer_FechaHora datetime,
@USU_id int,
@sucursal_id_Origen int,
@sucursal_id_Destino int,
@MovMer_facturaNRO varchar(100),
@MovMer_facturafecha datetime,
@MovMer_remitoNRO varchar(100),
@MovMer_remitofecha datetime, 
@MovMerTipo_id int,
@Prov_id int,
@MovMer_IVA decimal(38,2),
@MovMer_TOTAL decimal(38,2)
as

insert Movimiento_Mercaderia (MovMer_Concepto,MovMer_FechaHora,USU_id,sucursal_id_Origen,sucursal_id_Destino, MovMer_facturaNRO,MovMer_facturafecha, MovMer_remitoNRO,MovMer_remitofecha,
MovMerTipo_id,  Prov_id, MovMer_IVA, MovMer_TOTAL )

values (@MovMer_Concepto,@MovMer_FechaHora,@USU_id,@sucursal_id_Origen,@sucursal_id_Destino,
@MovMer_facturaNRO,@MovMer_facturafecha, @MovMer_remitoNRO,@MovMer_remitofecha, @MovMerTipo_id, @Prov_id, @MovMer_IVA,
@MovMer_TOTAL)

select @@IDENTITY 

