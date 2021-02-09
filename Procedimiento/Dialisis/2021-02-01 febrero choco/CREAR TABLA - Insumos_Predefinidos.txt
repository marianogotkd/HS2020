CREATE TABLE [dbo].[Insumos_Predefinidos](
	[Predef_id] [int] IDENTITY(1,1) NOT NULL,
	[predef_cant] [decimal](38, 2) NULL,
	[Predef_Desc] [varchar](50) NULL,
	[prod_codinterno] [int] NULL,
	[prod_unidadmedida] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
