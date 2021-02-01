/****** Object:  Table [dbo].[notificaciones]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[notificaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NULL,
	[fecha_creacion] [datetime] NULL,
	[leido] [int] NULL,
	[texto] [varchar](255) NULL,
 CONSTRAINT [PK_notificaciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
