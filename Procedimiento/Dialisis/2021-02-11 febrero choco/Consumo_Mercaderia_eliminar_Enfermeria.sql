alter procedure [dbo].[Consumo_Mercaderia_eliminar_Enfermeria]
@Consumo_mercaderia_id int
as

delete from Consumo_Mercaderia where Consumo_mercaderia_id = @Consumo_mercaderia_id 


