/****** Object:  Table [dbo].[patentes]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[patentes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_patentes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


-- Inserts
INSERT [dbo].[patentes] ([nombre]) VALUES (N'EditarPerfil')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'VerAdmin')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'ABMUsuarios')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'ABMFamilias')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'ABMEmblemas')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'ABMSectores')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'ABMPuestos')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'BajaReconocimientos')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'BackUp')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'Bitacora')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'DigitoVerificador')
INSERT [dbo].[patentes] ([nombre]) VALUES (N'ModificarObjetivo')