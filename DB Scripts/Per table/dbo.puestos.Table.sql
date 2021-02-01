/****** Object:  Table [dbo].[puestos]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[puestos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[valoracion] [int] NULL,
 CONSTRAINT [PK_tipos_sector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


-- Inserts
INSERT [dbo].[puestos] ([nombre], [valoracion]) VALUES (N'Programador C#', 1)
INSERT [dbo].[puestos] ([nombre], [valoracion]) VALUES (N'Analista', 2)
INSERT [dbo].[puestos] ([nombre], [valoracion]) VALUES (N'Disenador', 3)
INSERT [dbo].[puestos] ([nombre], [valoracion]) VALUES (N'PM', 4)
INSERT [dbo].[puestos] ([nombre], [valoracion]) VALUES (N'Programador JS', 6)