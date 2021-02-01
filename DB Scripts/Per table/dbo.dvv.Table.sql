/****** Object:  Table [dbo].[dvv]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[dvv](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tabla] [varchar](50) NULL,
	[dvv] [varchar](50) NULL,
 CONSTRAINT [PK_dvv] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

-- Inserts
INSERT [dbo].[dvv] ([nombre_tabla], [dvv]) VALUES (N'usuarios', N'-298024289')
INSERT [dbo].[dvv] ([nombre_tabla], [dvv]) VALUES (N'familias', N'-23065487')
INSERT [dbo].[dvv] ([nombre_tabla], [dvv]) VALUES (N'objetivos', N'-905301633')
INSERT [dbo].[dvv] ([nombre_tabla], [dvv]) VALUES (N'objetivos_no_cumplidos', N'-2012266556')
INSERT [dbo].[dvv] ([nombre_tabla], [dvv]) VALUES (N'reconocimientos', N'1352853613')