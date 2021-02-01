/****** Object:  Table [dbo].[objetivos_no_cumplidos]    Script Date: 2020-07-07 23:22:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[objetivos_no_cumplidos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NULL,
	[objetivo_id] [int] NULL,
	[tipo] [varchar](50) NULL,
	[dvh] [varchar](50) NULL,
 CONSTRAINT [PK_objetivos_no_cumplidos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

-- Inserts
INSERT [dbo].[objetivos_no_cumplidos] ([usuario_id], [objetivo_id], [tipo], [dvh]) VALUES (2, 1, N'not_fixed', '-184846762')
INSERT [dbo].[objetivos_no_cumplidos] ([usuario_id], [objetivo_id], [tipo], [dvh]) VALUES (3, 6, N'not_fixed', '-181705129')
INSERT [dbo].[objetivos_no_cumplidos] ([usuario_id], [objetivo_id], [tipo], [dvh]) VALUES (3, 9, N'not_fixed', '-191269028')
INSERT [dbo].[objetivos_no_cumplidos] ([usuario_id], [objetivo_id], [tipo], [dvh]) VALUES (4, 9, N'not_fixed', '-179738787')
INSERT [dbo].[objetivos_no_cumplidos] ([usuario_id], [objetivo_id], [tipo], [dvh]) VALUES (8, 6, N'not_fixed', '-180660910')