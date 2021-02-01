/****** Object:  Table [dbo].[objetivos]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[objetivos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[usuario_id] [int] NULL,
	[nivel_issue] [int] NULL,
	[fecha_creacion] [datetime] NULL,
	[fecha_asignacion] [datetime] NULL,
	[fecha_cierre] [datetime] NULL,
	[sector_id] [int] NULL,
	[fecha_cerrar_antes_de] [datetime] NULL,
	[archivado] [int] NULL,
	[dvh] [varchar](50) NULL,
 CONSTRAINT [PK_objetivos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[objetivos] ADD  CONSTRAINT [DF_objetivos_archivado]  DEFAULT ((0)) FOR [archivado]


-- Inserts
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 1', 2, 1, CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2018-11-08T00:00:00.000' AS DateTime), 1, '909439078')
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 2', 3, 2, CAST(N'2018-11-01T13:48:33.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2018-11-08T00:00:00.000' AS DateTime), 1, '1353350111')
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 3', 4, 2, CAST(N'2018-11-01T13:59:15.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2018-11-16T00:00:00.000' AS DateTime), 1, '308156273')
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 4', 5, 3, CAST(N'2018-11-03T20:29:02.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2018-11-29T00:00:00.000' AS DateTime), 1, '1432718316')
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 5', 2, 3, CAST(N'2019-02-19T11:28:47.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2019-02-28T00:00:00.000' AS DateTime), 1, '1735442367')
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 6', 3, 4, CAST(N'2019-02-19T11:37:17.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2019-02-20T00:00:00.000' AS DateTime), 1, '-317948135')
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 7', 4, 4, CAST(N'2020-03-04T23:38:19.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2020-03-20T00:00:00.000' AS DateTime), 1, '-174858776')
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 8', 5, 4, CAST(N'2020-03-04T23:40:46.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2020-03-20T00:00:00.000' AS DateTime), 1, '460788338')
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 9', 3, 5, CAST(N'2020-03-04T23:41:44.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2020-03-11T00:00:00.000' AS DateTime), 1, '791196999')
INSERT [dbo].[objetivos] ([descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (N'Probar 10', 8, 5, CAST(N'2020-06-14T15:38:08.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2020-06-18T00:00:00.000' AS DateTime), 1, '678872722')