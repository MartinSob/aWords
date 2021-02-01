/****** Object:  Table [dbo].[bitacora]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[bitacora](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[titulo] [varchar](250) NULL,
	[descripcion] [varchar](250) NULL,
	[tipo] [varchar](50) NULL,
	[usuario_id] [int] NULL,
 CONSTRAINT [PK_bitacora] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]