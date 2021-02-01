/****** Object:  Table [dbo].[sectores]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[sectores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[jefe_id] [int] NULL,
	[nivel] [int] NOT NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_sectores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[sectores] ADD  CONSTRAINT [DF_sectores_borrado]  DEFAULT ((0)) FOR [borrado]


-- Inserts
INSERT [dbo].[sectores] ([nombre], [jefe_id], [nivel], [borrado]) VALUES (N'Canary', NULL, 1, 0)
INSERT [dbo].[sectores] ([nombre], [jefe_id], [nivel], [borrado]) VALUES (N'Threshold', NULL, 2, 0)
INSERT [dbo].[sectores] ([nombre], [jefe_id], [nivel], [borrado]) VALUES (N'Manhattan', NULL, 3, 0)
INSERT [dbo].[sectores] ([nombre], [jefe_id], [nivel], [borrado]) VALUES (N'Scorpio', NULL, 4, 0)