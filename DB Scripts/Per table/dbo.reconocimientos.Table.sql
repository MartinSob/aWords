/****** Object:  Table [dbo].[reconocimientos]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[reconocimientos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reconocedor_id] [int] NULL,
	[reconocido_id] [int] NULL,
	[descripcion] [varchar](50) NULL,
	[fecha] [datetime] NULL,
	[emblema_id] [int] NULL,
	[valoracion] [int] NULL,
	[dvh] [varchar](50) NULL,
 CONSTRAINT [PK_reconocimientos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


-- Inserts
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (1, 2, N'Recon 1', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 1, 2, '-1745684356')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (2, 3, N'Recon 2', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 2, 1, '2081626171')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (3, 4, N'Recon 3', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 3, 1, '732507613')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (4, 5, N'Recon 4', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 1, 1, '1557599658')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (5, 2, N'Recon 5', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 2, 1, '-193210999')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (1, 3, N'Recon 6', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 3, 2, '528210583')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (2, 4, N'Recon 7', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 1, 1, '2102115898')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (5, 8, N'Recon 8', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 3, 1, '-1603566471')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (1, 2, N'Recon 9', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 3, 2, '846664301')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (1, 5, N'Recon 10', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 2, 2, '-1816149524')
INSERT [dbo].[reconocimientos] ([reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (1, 8, N'Recon 11', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 1, 2, '-1683488646')