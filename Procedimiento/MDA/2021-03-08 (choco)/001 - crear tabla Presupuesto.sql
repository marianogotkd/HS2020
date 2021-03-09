USE [SantaFe]
GO

/****** Object:  Table [dbo].[Presupuesto]    Script Date: 03/08/2021 20:02:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Presupuesto](
	[presupuesto_id] [int] IDENTITY(1,1) NOT NULL,
	[presupuesto_fecha] [datetime] NULL,
	[presupuesto_estado] [varchar](50) NULL,
	[ventaprod_id] [int] NULL,
 CONSTRAINT [PK_Presupuesto] PRIMARY KEY CLUSTERED 
(
	[presupuesto_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


