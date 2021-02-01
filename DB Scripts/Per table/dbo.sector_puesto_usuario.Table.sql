/****** Object:  Table [dbo].[sector_puesto_usuario]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[sector_puesto_usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sector_id] [int] NULL,
	[puesto_id] [int] NULL,
	[usuario_id] [int] NULL,
 CONSTRAINT [PK_sector_puesto_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


-- Inserts
INSERT [dbo].[sector_puesto_usuario] ([sector_id], [puesto_id], [usuario_id]) VALUES (1, 1, NULL)
INSERT [dbo].[sector_puesto_usuario] ([sector_id], [puesto_id], [usuario_id]) VALUES (1, 1, 8)
INSERT [dbo].[sector_puesto_usuario] ([sector_id], [puesto_id], [usuario_id]) VALUES (2, 1, NULL)
INSERT [dbo].[sector_puesto_usuario] ([sector_id], [puesto_id], [usuario_id]) VALUES (2, 1, 5)
INSERT [dbo].[sector_puesto_usuario] ([sector_id], [puesto_id], [usuario_id]) VALUES (2, 1, 1)