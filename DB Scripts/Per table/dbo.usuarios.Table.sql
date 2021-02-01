/****** Object:  Table [dbo].[usuarios]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[familia_id] [int] NULL,
	[puesto_id] [int] NULL,
	[dvh] [varchar](50) NULL,
	[activo] [int] NULL,
	[intentos_fallidos] [int] NULL,
	[fecha_entrada] [date] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


-- Inserts
INSERT [dbo].[usuarios] ([nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (N'admin', N'admin@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Admin', N'Admin', 4, 1, N'-1462707947', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (N'empleado', N'emp@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Empleado', N'Empleado', 15, 1, N'-1266244430', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (N'jefe', N'jefe@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Jefe', N'Jefe', 15, 1, N'-406846945', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (N'ejecutivo', N'ejecutivo@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Ejecutivo', N'Ejecutivo', 15, 1, N'-380019407', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (N'tecnico', N'tecnico@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Tecnico', N'Tecnico', 15, 1, N'-267164379', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (N'hford', N'hford@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Harrison', N'Ford', 15, 1, N'-1890369018', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (N'janiston', N'janniston@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Jennifer', N'Aniston', 15, 1, N'-380563353', 0, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (N'bcranston', N'bcranston@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Bryan', N'Cranston', 15, 1, N'-380563353', 0, 0, CAST(N'2019-04-09' AS Date))