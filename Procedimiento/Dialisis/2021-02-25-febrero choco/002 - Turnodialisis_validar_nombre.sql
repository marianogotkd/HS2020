create procedure Turnodialisis_validar_nombre
@Turnodialisis_desc varchar(100)

as
select * from Turnodialisis where Turnodialisis_desc = @Turnodialisis_desc  

go