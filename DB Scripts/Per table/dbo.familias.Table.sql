/****** Object:  Table [dbo].[familias]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[familias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[dvh] [varchar](50) NULL,
 CONSTRAINT [PK_permisos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

-- Inserts
INSERT [dbo].[familias] ([nombre], [dvh]) VALUES (N'Empleado', N'-2024180132')
INSERT [dbo].[familias] ([nombre], [dvh]) VALUES (N'Tecnico', N'1980924006')
INSERT [dbo].[familias] ([nombre], [dvh]) VALUES (N'Ejecutivo', N'1757077604')
INSERT [dbo].[familias] ([nombre], [dvh]) VALUES (N'Admin', N'1168926920')
INSERT [dbo].[familias] ([nombre], [dvh]) VALUES (N'Jefe', N'-449729936')
