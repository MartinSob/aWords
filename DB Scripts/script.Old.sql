/****** Object:  Database [aWords.old]    Script Date: 2020-09-20 13:56:34 ******/
CREATE DATABASE [aWords.old]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'aWords.old', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\aWords.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'aWords_log.old', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\aWords_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [aWords.old] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [aWords.old].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [aWords.old] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [aWords.old] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [aWords.old] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [aWords.old] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [aWords.old] SET ARITHABORT OFF 
GO
ALTER DATABASE [aWords.old] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [aWords.old] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [aWords.old] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [aWords.old] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [aWords.old] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [aWords.old] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [aWords.old] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [aWords.old] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [aWords.old] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [aWords.old] SET  DISABLE_BROKER 
GO
ALTER DATABASE [aWords.old] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [aWords.old] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [aWords.old] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [aWords.old] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [aWords.old] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [aWords.old] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [aWords.old] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [aWords.old] SET RECOVERY FULL 
GO
ALTER DATABASE [aWords.old] SET  MULTI_USER 
GO
ALTER DATABASE [aWords.old] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [aWords.old] SET DB_CHAINING OFF 
GO
ALTER DATABASE [aWords.old] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [aWords.old] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [aWords.old] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'aWords.old', N'ON'
GO
ALTER DATABASE [aWords.old] SET QUERY_STORE = OFF
GO
/****** Object:  Table [dbo].[bitacora]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bitacora](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[titulo] [varchar](250) NULL,
	[descripcion] [varchar](250) NULL,
	[tipo] [varchar](50) NULL,
	[usuario_id] [int] NULL,
 CONSTRAINT [PK_bitacora] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[controles]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[controles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idioma_id] [int] NULL,
	[tag] [varchar](50) NULL,
	[texto] [varchar](50) NULL,
 CONSTRAINT [PK_controles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dvv]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dvv](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tabla] [varchar](50) NULL,
	[dvv] [varchar](50) NULL,
 CONSTRAINT [PK_dvv] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emblemas]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emblemas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_emblemas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[familia_patente]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[familia_patente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[familia_id] [int] NULL,
	[patente_id] [int] NULL,
 CONSTRAINT [PK_familia_patente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[familias]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[familias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[dvh] [varchar](50) NULL,
 CONSTRAINT [PK_permisos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[idiomas]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[idiomas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_idiomas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notificaciones]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notificaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NULL,
	[fecha_creacion] [datetime] NULL,
	[leido] [int] NULL,
	[texto] [varchar](255) NULL,
 CONSTRAINT [PK_notificaciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[objetivos]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
	[dvh] [varchar](255) NULL,
 CONSTRAINT [PK_objetivos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[objetivos_no_cumplidos]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[objetivos_no_cumplidos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NULL,
	[objetivo_id] [int] NULL,
	[tipo] [varchar](50) NULL,
	[fecha] [date] NULL,
	[dvh] [varchar](255) NULL,
 CONSTRAINT [PK_objetivos_no_cumplidos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patentes]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patentes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_patentes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puestos]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puestos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[valoracion] [int] NULL,
 CONSTRAINT [PK_tipos_sector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reconocimientos]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reconocimientos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reconocedor_id] [int] NULL,
	[reconocido_id] [int] NULL,
	[descripcion] [varchar](50) NULL,
	[fecha] [datetime] NULL,
	[emblema_id] [int] NULL,
	[valoracion] [int] NULL,
	[dvh] [varchar](255) NULL,
 CONSTRAINT [PK_reconocimientos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sector_puesto_usuario]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sector_puesto_usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sector_id] [int] NULL,
	[puesto_id] [int] NULL,
	[usuario_id] [int] NULL,
 CONSTRAINT [PK_sector_puesto_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sectores]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sectores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[jefe_id] [int] NULL,
	[nivel] [int] NOT NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_sectores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 2020-09-20 13:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bitacora] ON 

INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1, CAST(N'2020-07-07T23:17:08.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2, CAST(N'2020-07-07T23:17:08.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 2', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (3, CAST(N'2020-07-07T23:17:08.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (4, CAST(N'2020-07-07T23:17:08.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 4', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (5, CAST(N'2020-07-07T23:17:08.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (6, CAST(N'2020-07-07T23:17:08.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 6', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (7, CAST(N'2020-07-07T23:17:08.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 7', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (8, CAST(N'2020-07-07T23:17:08.000' AS DateTime), N'Error DVV en BD', N'Error DVV en la tabla: familias', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (9, CAST(N'2020-07-07T23:17:08.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (10, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error DVV en la tabla: objetivos', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (11, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (12, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 2', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (13, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (14, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 4', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (15, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (16, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 6', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (17, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 7', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (18, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 8', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (19, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 9', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (20, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 10', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (21, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error DVV en la tabla: objetivos_no_cumplidos', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (22, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (23, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 2', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (24, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (25, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 4', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (26, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (27, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error DVV en la tabla: reconocimientos', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (28, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (29, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 2', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (30, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (31, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 4', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (32, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (33, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 6', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (34, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 7', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (35, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 8', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (36, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 9', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (37, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 10', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (38, CAST(N'2020-08-04T20:12:41.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 11', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (39, CAST(N'2020-08-04T20:45:15.000' AS DateTime), N'Restore', N'Se ha realizado un restore', N'info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1039, CAST(N'2020-08-17T20:07:56.000' AS DateTime), N'Restore', N'Se ha realizado un restore', N'info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1040, CAST(N'2020-08-17T21:31:55.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1041, CAST(N'2020-08-17T21:31:55.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 2', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1042, CAST(N'2020-08-17T21:31:55.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1043, CAST(N'2020-08-17T21:31:55.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 4', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1044, CAST(N'2020-08-17T21:31:55.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1045, CAST(N'2020-08-17T21:41:56.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1046, CAST(N'2020-08-17T21:41:56.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 2', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1047, CAST(N'2020-08-17T21:41:56.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1048, CAST(N'2020-08-17T21:41:56.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 4', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1049, CAST(N'2020-08-17T21:41:56.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1050, CAST(N'2020-08-20T21:45:42.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1051, CAST(N'2020-08-20T21:45:42.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 2', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1052, CAST(N'2020-08-20T21:45:42.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1053, CAST(N'2020-08-20T21:45:42.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 4', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (1054, CAST(N'2020-08-20T21:45:42.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2039, CAST(N'2020-08-27T22:39:27.000' AS DateTime), N'Cerrar Sesion', N'Ha cerrado sesion', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2040, CAST(N'2020-08-29T22:31:49.000' AS DateTime), N'Cambio emblema', N'{"id":1,"nombre":"asd"}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2041, CAST(N'2020-08-29T22:33:49.000' AS DateTime), N'Cambio emblema', N'{"id":1,"nombre":"asd"}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2042, CAST(N'2020-08-29T22:38:56.000' AS DateTime), N'Cambio emblema', N'{"id":1,"nombre":"pepe"}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2043, CAST(N'2020-08-29T22:40:42.000' AS DateTime), N'Nuevo emblema', N'{"id":4,"nombre":"Messi"}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2044, CAST(N'2020-08-29T22:40:51.000' AS DateTime), N'Cambio emblema', N'{"id":4,"nombre":"Meeeessi"}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2045, CAST(N'2020-08-29T22:40:55.000' AS DateTime), N'Borrado emblema', N'4', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2047, CAST(N'2020-09-05T17:51:20.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 0)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2048, CAST(N'2020-09-05T18:23:05.000' AS DateTime), N'Error DVV en BD', N'Error in row:1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2049, CAST(N'2020-09-05T18:23:05.000' AS DateTime), N'Error DVV en BD', N'Error in row:2', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2050, CAST(N'2020-09-05T18:23:05.000' AS DateTime), N'Error DVV en BD', N'Error in row:3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2051, CAST(N'2020-09-05T18:23:05.000' AS DateTime), N'Error DVV en BD', N'Error in row:4', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2052, CAST(N'2020-09-05T18:23:05.000' AS DateTime), N'Error DVV en BD', N'Error in row:5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2053, CAST(N'2020-09-05T18:23:13.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2054, CAST(N'2020-09-06T18:56:38.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 1', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2055, CAST(N'2020-09-06T18:56:38.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 2', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2056, CAST(N'2020-09-06T18:56:38.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2057, CAST(N'2020-09-06T18:56:38.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 4', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2058, CAST(N'2020-09-06T18:56:38.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2059, CAST(N'2020-09-06T18:56:40.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2060, CAST(N'2020-09-06T18:56:41.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2061, CAST(N'2020-09-06T18:56:41.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2062, CAST(N'2020-09-06T18:56:41.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2063, CAST(N'2020-09-07T10:56:00.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 0)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2064, CAST(N'2020-09-07T11:00:26.000' AS DateTime), N'Familia actualizada: ', N'{"patentes":[{"id":12,"nombre":"ModificarObjetivo"}],"id":1,"nombre":"Empleado"}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2065, CAST(N'2020-09-07T11:00:26.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2066, CAST(N'2020-09-07T11:00:38.000' AS DateTime), N'Familia creada: ', N'{"patentes":[],"id":0,"nombre":"Empleado"}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2067, CAST(N'2020-09-07T11:00:38.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2068, CAST(N'2020-09-07T11:00:46.000' AS DateTime), N'Familia borrada: ', N'{"patentes":null,"id":6,"nombre":null}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2069, CAST(N'2020-09-07T11:00:46.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2070, CAST(N'2020-09-07T11:03:19.000' AS DateTime), N'Familia actualizada: ', N'{"patentes":[{"id":12,"nombre":"ModificarObjetivo"}],"id":1,"nombre":"Empleado"}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2071, CAST(N'2020-09-07T11:03:19.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2072, CAST(N'2020-09-07T11:04:14.000' AS DateTime), N'Familia creada: ', N'{"patentes":[],"id":0,"nombre":"Empleados"}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2073, CAST(N'2020-09-07T11:04:14.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2074, CAST(N'2020-09-07T11:04:39.000' AS DateTime), N'Familia borrada: ', N'{"patentes":null,"id":7,"nombre":null}', N'Control', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2075, CAST(N'2020-09-07T11:04:39.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2076, CAST(N'2020-09-19T17:02:08.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 0)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2078, CAST(N'2020-09-20T00:27:50.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 0)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2079, CAST(N'2020-09-20T00:28:48.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 3', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2080, CAST(N'2020-09-20T00:29:13.000' AS DateTime), N'Error DVV en BD', N'Error DVV en la tabla: familias', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2081, CAST(N'2020-09-20T00:29:13.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2082, CAST(N'2020-09-20T00:29:32.000' AS DateTime), N'Error DVV en BD', N'Error DVV en la tabla: familias', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2083, CAST(N'2020-09-20T00:29:32.000' AS DateTime), N'Error DVV en BD', N'Error en la fila: 5', N'Error', 1)
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2084, CAST(N'2020-09-20T00:31:00.000' AS DateTime), N'Restore', N'Se ha realizado un restore', N'Info', 1)
GO
INSERT [dbo].[bitacora] ([id], [fecha], [titulo], [descripcion], [tipo], [usuario_id]) VALUES (2085, CAST(N'2020-09-20T00:31:13.000' AS DateTime), N'Digitos verificadores', N'Los Digitos verificadores se han actualizado', N'Info', 0)
SET IDENTITY_INSERT [dbo].[bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[controles] ON 

INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (5, 1, N'language', N'Idioma')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (6, 2, N'language', N'Language')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (9, 1, N'bitacore', N'Bitácora')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (10, 2, N'bitacore', N'Binnacle')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (11, 1, N'username', N'Nombre de usuario')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (12, 2, N'username', N'Username')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (13, 1, N'password', N'Contraseña')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (14, 2, N'password', N'Password')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (15, 1, N'login', N'Iniciar sesion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (16, 2, N'login', N'Log in')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (21, 1, N'updateDV', N'Actualizar DV')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (22, 2, N'updateDV', N'Update DV')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (25, 1, N'employees', N'Empleados')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (26, 2, N'employees', N'Employees')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (27, 1, N'rest_dv', N'Restaurar DV')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (28, 2, N'rest_dv', N'Restore DV')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (29, 1, N'restore', N'Restaurar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (30, 2, N'restore', N'Restore')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (31, 1, N'bkp_done', N'Se realizo el backup')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (32, 2, N'bkp_done', N'Backup is done')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (33, 1, N'restore_done', N'Se realizo la restauracion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (34, 2, N'restore_done', N'Restore is done')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (35, 1, N'login_failed', N'Usuario o contraseña incorrecto')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (36, 2, N'login_failed', N'User or password incorrect')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (37, 1, N'login_success', N'Has iniciado sesion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (38, 2, N'login_success', N'Login successful')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (39, 1, N'logout_success', N'Has cerrado sesion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (40, 2, N'logout_success', N'Logout successful')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (41, 1, N'notification', N'Notificacion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (42, 2, N'notification', N'Notification')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (43, 1, N'dvh_table', N'Error DVH en la tabla: ')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (44, 2, N'dvh_table', N'DVH error in table:')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (45, 1, N'error_row', N'Error en la fila: ')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (46, 2, N'error_row', N'Error in row:')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (47, 1, N'dvv_table', N'Error DVV en la tabla: ')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (48, 2, N'dvv_table', N'Error DVV in table:')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (49, 1, N'error_contact_admin', N'Ha surgido un error. Contacte al administrador.')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (50, 2, N'error_contact_admin', N'There was an error. Contact the admin.')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (51, 1, N'recognize', N'Reconocer')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (52, 2, N'recognize', N'Recognize')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (53, 1, N'see_profile', N'Ver perfil')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (54, 2, N'see_profile', N'Go to profile')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (55, 1, N'search', N'Buscar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (56, 2, N'search', N'Search')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (61, 1, N'name', N'Nombre')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (62, 2, N'name', N'Name')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (63, 1, N'lastname', N'Apellido')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (64, 2, N'lastname', N'Lastname')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (65, 1, N'save', N'Guardar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (66, 2, N'save', N'Save')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (67, 1, N'update', N'Actualizar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (68, 2, N'update', N'Update')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (69, 1, N'new_pass', N'Nueva contraseña')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (70, 2, N'new_pass', N'New password')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (71, 1, N'personal_data', N'Datos personales')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (72, 2, N'personal_data', N'Personal data')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (75, 1, N'error', N'Hubo un error')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (76, 2, N'error', N'There was an error')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (77, 1, N'add_user', N'Agregar usuario')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (78, 2, N'add_user', N'Add user')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (79, 1, N'role', N'Permiso')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (80, 2, N'role', N'Role')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (81, 1, N'delete', N'Eliminar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (82, 2, N'delete', N'Delete')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (85, 1, N'date', N'Fecha')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (86, 2, N'date', N'Date')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (87, 1, N'title', N'Titulo')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (88, 2, N'title', N'Title')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (89, 1, N'description', N'Descripcion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (90, 2, N'description', N'Description')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (91, 1, N'type', N'Tipo')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (92, 2, N'type', N'Type')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (93, 1, N'valoration', N'Valoracion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (94, 2, N'valoration', N'Valoration')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (95, 1, N'patents', N'Patentes')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (96, 2, N'patents', N'Patents')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (99, 1, N'add', N'Agregar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (100, 2, N'add', N'Add')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (101, 1, N'edit', N'Editar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (102, 2, N'edit', N'Edit')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (107, 1, N'incorrect_data', N'Datos incorrectos')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (108, 2, N'incorrect_data', N'Incorrect data')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (109, 1, N'emblem', N'Emblema')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (110, 2, N'emblem', N'Emblem')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (111, 1, N'recognized', N'Reconocido')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (112, 2, N'recognized', N'Recognized')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (117, 1, N'recognize_create_success', N'El reconocimiento fue creado con exito!')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (118, 2, N'recognize_create_success', N'The recognize was created successfuly!')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (119, 1, N'see_recognize', N'Ver reconocimiento')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (120, 2, N'see_recognize', N'See recognize')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (121, 1, N'last_recognizes', N'Los ultimos reconocimientos')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (122, 2, N'last_recognizes', N'The last recognizes')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (135, 1, N'boss', N'Jefe')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (136, 2, N'boss', N'Boss')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (137, 1, N'suggest', N'Sugerir')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (138, 2, N'suggest', N'Suggest')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (141, 1, N'experience_sent', N'Has recibido un reconocimiento!')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (142, 2, N'experience_sent', N'You have received a recognize!')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (143, 1, N'sent', N'Enviados')
GO
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (144, 2, N'sent', N'Sent')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (145, 1, N'received', N'Recibidos')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (146, 2, N'received', N'Received')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (147, 1, N'my_objectives', N'Mis objetivos')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (148, 2, N'my_objectives', N'My objectives')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (149, 1, N'sector_objectives', N'Objetivos del sector')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (150, 2, N'sector_objectives', N'Sectors objetctives')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (151, 1, N'finalize', N'Finalizar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (152, 2, N'finalize', N'Finalize')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (153, 1, N'not_finalized', N'No finalizado')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (154, 2, N'not_finalized', N'Not finalized')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (155, 1, N'assign_new', N'< Asignarse nuevo <')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (156, 2, N'assign_new', N'< Assign new <')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (157, 1, N'objective', N'Objetivo')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (158, 2, N'objective', N'Objective')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (159, 1, N'pick_valid_date', N'Elija una fecha correcta')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (160, 2, N'pick_valid_date', N'Pick a valid date')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (161, 1, N'close_before', N'Cerrar antes de')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (162, 2, N'close_before', N'Close before')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (163, 1, N'employee_assigned', N'Empleado asignado')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (164, 2, N'employee_assigned', N'Assigned employee')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (165, 1, N'level', N'Nivel')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (166, 2, N'level', N'Level')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (169, 1, N'see_detail', N'Ver detalle')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (170, 2, N'see_detail', N'View detail')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (171, 1, N'open', N'Abierto')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (172, 2, N'open', N'Open')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (173, 1, N'closed', N'Cerrado')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (174, 2, N'closed', N'Closed')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (175, 1, N'manage', N'Gestionar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (176, 2, N'manage', N'Manage')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (177, 1, N'open_objectives', N'Objetivos abiertos')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (178, 2, N'open_objectives', N'Open objectives')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (179, 1, N'closed_objectives', N'Objetivos cerrados')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (180, 2, N'closed_objectives', N'Closed objectives')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (181, 1, N'objective_taken', N'El objetivo ya tiene un usuario asignado')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (182, 2, N'objective_taken', N'The objective already has a user')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (183, 1, N'archive', N'Archivar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (184, 2, N'archive', N'Archive')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (189, 1, N'cant_recognize_myself', N'No te podes reconocer a vos mismo')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (190, 2, N'cant_recognize_myself', N'You can''t recognize yourself')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (191, 1, N'cant_delete_my_family', N'No podes eliminar tu propia familia')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (192, 2, N'cant_delete_my_family', N'You can''t delete your own family')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1191, 1, N'position', N'Puesto')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1192, 2, N'position', N'Position')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1193, 1, N'user', N'Usuario')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1194, 2, N'user', N'User')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1195, 1, N'reward', N'Reconocimiento')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1196, 2, N'reward', N'Reward')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1197, 1, N'created', N'Creado')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1198, 2, N'created', N'Created')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1199, 1, N'updated', N'Actualizado')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1200, 2, N'updated', N'Updated')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1201, 1, N'deleted', N'Eliminado')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1202, 2, N'deleted', N'Deleted')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1203, 1, N'appreciation', N'Valoracion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (1204, 2, N'appreciation', N'Appreciation')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2203, 1, N'families', N'Familias')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2204, 2, N'families', N'Families')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2205, 1, N'emblems', N'Emblemas')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2206, 2, N'emblems', N'Emblems')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2207, 1, N'sectors', N'Sectores')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2208, 2, N'sectors', N'Sectors')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2209, 1, N'positions', N'Puestos')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2210, 2, N'positions', N'Positions')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2211, 1, N'rewards', N'Reconocimientos')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2212, 2, N'rewards', N'Rewards')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2213, 1, N'old_pass', N'Antigua contraseña')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2214, 2, N'old_pass', N'Old password')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2215, 1, N'date_creation', N'Fecha creacion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2216, 2, N'date_creation', N'Date creation')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2217, 1, N'date_asignation', N'Fecha asignacion')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2218, 2, N'date_asignation', N'Date asignation')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2219, 1, N'date_close', N'Fecha cierre')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2220, 2, N'date_close', N'Date close')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2221, 1, N'manage_family', N'Gestionar familia')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2222, 2, N'manage_family', N'Manage family')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2223, 1, N'filter', N'Filtrar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2224, 2, N'filter', N'Filter')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2225, 1, N'recognizer', N'Reconocedor')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2226, 2, N'recognizer', N'Recognizer')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2227, 1, N'select', N'Seleccionar')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2228, 2, N'select', N'Select')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2229, 1, N'enter_date', N'Fecha ingreso')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (2230, 2, N'enter_date', N'Enter date')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (3229, 1, N'please_add_level', N'Por favor, ingresa un nivel')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (3230, 2, N'please_add_level', N'Please, add a level')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (3231, 1, N'please_add_position', N'Por favor, ingresa un puesto disponible')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (3232, 2, N'please_add_position', N'Please, add anavailable position')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (3233, 1, N'please_add_employee', N'Por favor, agrega un empleado')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (3234, 2, N'please_add_employee', N'Please, add an employee')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (3235, 1, N'name_already_used', N'El nombre ya esta en uso')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (3236, 2, N'name_already_used', N'Name already used')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (4235, 1, N'failed_objective', N'Objetivo fallado')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (4236, 2, N'failed_objective', N'Failed objective')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (4237, 1, N'new_objective', N'Objetivo nuevo')
INSERT [dbo].[controles] ([id], [idioma_id], [tag], [texto]) VALUES (4238, 2, N'new_objective', N'New objective')
SET IDENTITY_INSERT [dbo].[controles] OFF
GO
SET IDENTITY_INSERT [dbo].[dvv] ON 

INSERT [dbo].[dvv] ([id], [nombre_tabla], [dvv]) VALUES (1, N'usuarios', N'-629262464')
INSERT [dbo].[dvv] ([id], [nombre_tabla], [dvv]) VALUES (2, N'familias', N'-23065487')
INSERT [dbo].[dvv] ([id], [nombre_tabla], [dvv]) VALUES (3, N'objetivos', N'-905301633')
INSERT [dbo].[dvv] ([id], [nombre_tabla], [dvv]) VALUES (4, N'objetivos_no_cumplidos', N'-1387390954')
INSERT [dbo].[dvv] ([id], [nombre_tabla], [dvv]) VALUES (5, N'reconocimientos', N'1352853613')
SET IDENTITY_INSERT [dbo].[dvv] OFF
GO
SET IDENTITY_INSERT [dbo].[emblemas] ON 

INSERT [dbo].[emblemas] ([id], [nombre]) VALUES (1, N'Bronce')
INSERT [dbo].[emblemas] ([id], [nombre]) VALUES (2, N'Palta')
INSERT [dbo].[emblemas] ([id], [nombre]) VALUES (3, N'Oro')
SET IDENTITY_INSERT [dbo].[emblemas] OFF
GO
SET IDENTITY_INSERT [dbo].[familia_patente] ON 

INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (1, 4, 1)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (2, 4, 2)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (3, 4, 3)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (4, 4, 4)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (5, 4, 5)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (6, 4, 6)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (7, 4, 7)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (8, 4, 8)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (9, 4, 9)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (10, 4, 10)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (11, 4, 11)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (12, 4, 12)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (14, 5, 12)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (15, 5, 13)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (16, 2, 2)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (17, 2, 3)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (18, 2, 4)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (19, 2, 5)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (20, 2, 6)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (21, 2, 7)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (22, 2, 8)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (23, 2, 9)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (24, 2, 10)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (25, 2, 11)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (26, 3, 1)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (27, 3, 2)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (28, 3, 3)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (29, 3, 4)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (30, 3, 5)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (31, 3, 6)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (32, 3, 7)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (33, 3, 8)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (34, 3, 9)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (35, 3, 10)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (36, 3, 11)
INSERT [dbo].[familia_patente] ([id], [familia_id], [patente_id]) VALUES (38, 1, 12)
SET IDENTITY_INSERT [dbo].[familia_patente] OFF
GO
SET IDENTITY_INSERT [dbo].[familias] ON 

INSERT [dbo].[familias] ([id], [nombre], [dvh]) VALUES (1, N'Empleado', N'-2024180132')
INSERT [dbo].[familias] ([id], [nombre], [dvh]) VALUES (2, N'Tecnico', N'1980924006')
INSERT [dbo].[familias] ([id], [nombre], [dvh]) VALUES (3, N'Ejecutivo', N'1757077604')
INSERT [dbo].[familias] ([id], [nombre], [dvh]) VALUES (4, N'Admin', N'1168926920')
INSERT [dbo].[familias] ([id], [nombre], [dvh]) VALUES (5, N'Jefe', N'-449729936')
SET IDENTITY_INSERT [dbo].[familias] OFF
GO
SET IDENTITY_INSERT [dbo].[idiomas] ON 

INSERT [dbo].[idiomas] ([id], [nombre]) VALUES (1, N'Castellano')
INSERT [dbo].[idiomas] ([id], [nombre]) VALUES (2, N'English')
SET IDENTITY_INSERT [dbo].[idiomas] OFF
GO
SET IDENTITY_INSERT [dbo].[notificaciones] ON 

INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (1, 1, CAST(N'2018-10-20T20:51:44.000' AS DateTime), 0, N'experience_sent')
INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (2, 1, CAST(N'2018-10-20T20:51:44.000' AS DateTime), 0, N'experience_sent')
INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (3, 1, CAST(N'2018-10-20T20:51:44.000' AS DateTime), 0, N'experience_sent')
INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (4, 2, CAST(N'2018-10-20T20:51:44.000' AS DateTime), 0, N'experience_sent')
INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (5, 8, CAST(N'2018-10-27T20:21:26.000' AS DateTime), 0, N'experience_sent')
INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (6, 1, CAST(N'2019-02-20T19:48:54.000' AS DateTime), 0, N'experience_sent')
INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (7, 1, CAST(N'2019-02-20T19:52:26.000' AS DateTime), 0, N'experience_sent')
INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (8, 9, CAST(N'2020-03-04T21:36:59.000' AS DateTime), 0, N'experience_sent')
INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (9, 2, CAST(N'2020-06-14T15:57:34.000' AS DateTime), 0, N'experience_sent')
INSERT [dbo].[notificaciones] ([id], [usuario_id], [fecha_creacion], [leido], [texto]) VALUES (10, 5, CAST(N'2020-06-14T16:22:03.000' AS DateTime), 0, N'experience_sent')
SET IDENTITY_INSERT [dbo].[notificaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[objetivos] ON 

INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (1, N'Probar 1', 2, 1, CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2018-11-08T00:00:00.000' AS DateTime), 1, N'909439078')
INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (2, N'Probar 2', 3, 2, CAST(N'2018-11-01T13:48:33.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2018-11-08T00:00:00.000' AS DateTime), 1, N'1353350111')
INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (3, N'Probar 3', 4, 2, CAST(N'2018-11-01T13:59:15.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2018-11-16T00:00:00.000' AS DateTime), 1, N'308156273')
INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (4, N'Probar 4', 5, 3, CAST(N'2018-11-03T20:29:02.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2018-11-29T00:00:00.000' AS DateTime), 1, N'1432718316')
INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (5, N'Probar 5', 2, 3, CAST(N'2019-02-19T11:28:47.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2019-02-28T00:00:00.000' AS DateTime), 1, N'1735442367')
INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (6, N'Probar 6', 3, 4, CAST(N'2019-02-19T11:37:17.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2019-02-20T00:00:00.000' AS DateTime), 1, N'-317948135')
INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (7, N'Probar 7', 4, 4, CAST(N'2020-03-04T23:38:19.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2020-03-20T00:00:00.000' AS DateTime), 1, N'-174858776')
INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (8, N'Probar 8', 5, 4, CAST(N'2020-03-04T23:40:46.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2020-03-20T00:00:00.000' AS DateTime), 1, N'460788338')
INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (9, N'Probar 9', 3, 5, CAST(N'2020-03-04T23:41:44.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2020-03-11T00:00:00.000' AS DateTime), 1, N'791196999')
INSERT [dbo].[objetivos] ([id], [descripcion], [usuario_id], [nivel_issue], [fecha_creacion], [fecha_asignacion], [fecha_cierre], [sector_id], [fecha_cerrar_antes_de], [archivado], [dvh]) VALUES (10, N'Probar 10', 8, 5, CAST(N'2020-06-14T15:38:08.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), CAST(N'2018-11-01T13:45:14.000' AS DateTime), 1, CAST(N'2020-06-18T00:00:00.000' AS DateTime), 1, N'678872722')
SET IDENTITY_INSERT [dbo].[objetivos] OFF
GO
SET IDENTITY_INSERT [dbo].[objetivos_no_cumplidos] ON 

INSERT [dbo].[objetivos_no_cumplidos] ([id], [usuario_id], [objetivo_id], [tipo], [fecha], [dvh]) VALUES (1, 2, 1, N'not_fixed', NULL, N'685737254')
INSERT [dbo].[objetivos_no_cumplidos] ([id], [usuario_id], [objetivo_id], [tipo], [fecha], [dvh]) VALUES (2, 3, 6, N'not_fixed', NULL, N'680752421')
INSERT [dbo].[objetivos_no_cumplidos] ([id], [usuario_id], [objetivo_id], [tipo], [fecha], [dvh]) VALUES (3, 3, 9, N'not_fixed', NULL, N'687965740')
INSERT [dbo].[objetivos_no_cumplidos] ([id], [usuario_id], [objetivo_id], [tipo], [fecha], [dvh]) VALUES (4, 4, 9, N'not_fixed', NULL, N'681932331')
INSERT [dbo].[objetivos_no_cumplidos] ([id], [usuario_id], [objetivo_id], [tipo], [fecha], [dvh]) VALUES (5, 8, 6, N'not_fixed', NULL, N'681796642')
SET IDENTITY_INSERT [dbo].[objetivos_no_cumplidos] OFF
GO
SET IDENTITY_INSERT [dbo].[patentes] ON 

INSERT [dbo].[patentes] ([id], [nombre]) VALUES (1, N'EditarPerfil')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (2, N'VerAdmin')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (3, N'ABMUsuarios')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (4, N'ABMFamilias')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (5, N'ABMEmblemas')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (6, N'ABMSectores')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (7, N'ABMPuestos')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (8, N'BajaReconocimientos')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (9, N'BackUp')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (10, N'Bitacora')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (11, N'DigitoVerificador')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (12, N'ModificarObjetivo')
INSERT [dbo].[patentes] ([id], [nombre]) VALUES (13, N'VerJefes')
SET IDENTITY_INSERT [dbo].[patentes] OFF
GO
SET IDENTITY_INSERT [dbo].[puestos] ON 

INSERT [dbo].[puestos] ([id], [nombre], [valoracion]) VALUES (1, N'Delantero', 1)
INSERT [dbo].[puestos] ([id], [nombre], [valoracion]) VALUES (2, N'Mediocampista defensivo', 2)
INSERT [dbo].[puestos] ([id], [nombre], [valoracion]) VALUES (3, N'Enganche', 3)
INSERT [dbo].[puestos] ([id], [nombre], [valoracion]) VALUES (4, N'Defensor', 4)
INSERT [dbo].[puestos] ([id], [nombre], [valoracion]) VALUES (5, N'Arquero', 6)
INSERT [dbo].[puestos] ([id], [nombre], [valoracion]) VALUES (6, N'Pepe', 9)
SET IDENTITY_INSERT [dbo].[puestos] OFF
GO
SET IDENTITY_INSERT [dbo].[reconocimientos] ON 

INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (1, 1, 2, N'Recon 1', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 1, 2, N'-1745684356')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (2, 2, 3, N'Recon 2', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 2, 1, N'2081626171')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (3, 3, 4, N'Recon 3', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 3, 1, N'732507613')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (4, 4, 5, N'Recon 4', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 1, 1, N'1557599658')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (5, 5, 2, N'Recon 5', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 2, 1, N'-193210999')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (6, 1, 3, N'Recon 6', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 3, 2, N'528210583')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (7, 2, 4, N'Recon 7', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 1, 1, N'2102115898')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (10, 5, 8, N'Recon 8', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 3, 1, N'-1603566471')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (11, 1, 2, N'Recon 9', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 3, 2, N'846664301')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (12, 1, 5, N'Recon 10', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 2, 2, N'-1816149524')
INSERT [dbo].[reconocimientos] ([id], [reconocedor_id], [reconocido_id], [descripcion], [fecha], [emblema_id], [valoracion], [dvh]) VALUES (13, 1, 8, N'Recon 11', CAST(N'2020-06-14T21:01:55.000' AS DateTime), 1, 2, N'-1683488646')
SET IDENTITY_INSERT [dbo].[reconocimientos] OFF
GO
SET IDENTITY_INSERT [dbo].[sector_puesto_usuario] ON 

INSERT [dbo].[sector_puesto_usuario] ([id], [sector_id], [puesto_id], [usuario_id]) VALUES (48, 2, 1, NULL)
INSERT [dbo].[sector_puesto_usuario] ([id], [sector_id], [puesto_id], [usuario_id]) VALUES (49, 2, 1, 5)
INSERT [dbo].[sector_puesto_usuario] ([id], [sector_id], [puesto_id], [usuario_id]) VALUES (50, 2, 1, 1)
INSERT [dbo].[sector_puesto_usuario] ([id], [sector_id], [puesto_id], [usuario_id]) VALUES (51, 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[sector_puesto_usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[sectores] ON 

INSERT [dbo].[sectores] ([id], [nombre], [jefe_id], [nivel], [borrado]) VALUES (1, N'Chealse FC', 1, 1, 0)
INSERT [dbo].[sectores] ([id], [nombre], [jefe_id], [nivel], [borrado]) VALUES (2, N'FC Barcelona', NULL, 2, 0)
INSERT [dbo].[sectores] ([id], [nombre], [jefe_id], [nivel], [borrado]) VALUES (3, N'Arsenal FC', NULL, 3, 0)
INSERT [dbo].[sectores] ([id], [nombre], [jefe_id], [nivel], [borrado]) VALUES (4, N'Real Madrid', NULL, 4, 0)
SET IDENTITY_INSERT [dbo].[sectores] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id], [nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (1, N'admin', N'admin@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Admin', N'Admin', 4, 1, N'-1462707947', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([id], [nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (2, N'empleado', N'emp@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Empleado', N'Empleado', 15, 1, N'-1266244430', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([id], [nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (3, N'sector', N'sector@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Sector', N'Sector', 15, 1, N'-406846945', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([id], [nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (4, N'juanp', N'juanp@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Juan', N'Perez', 15, 1, N'-380019407', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([id], [nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (5, N'marias', N'marias@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Mariahh', N'Sanchez', 1, 1, N'1290069373', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([id], [nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (8, N'dardor', N'dardor@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Dardo', N'Rocha', 1, 1, N'-1890369018', 1, 0, CAST(N'2019-04-09' AS Date))
INSERT [dbo].[usuarios] ([id], [nombre_usuario], [mail], [password], [nombre], [apellido], [familia_id], [puesto_id], [dvh], [activo], [intentos_fallidos], [fecha_entrada]) VALUES (9, N'lponzio', N'lponzio@asd.com', N'nRy/sK5Z7ENvGsSwfcmLzw==', N'Leonardo', N'Ponzioo', 15, 1, N'-380563353', 0, 0, CAST(N'2019-04-09' AS Date))
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
ALTER TABLE [dbo].[objetivos] ADD  CONSTRAINT [DF_objetivos_archivado]  DEFAULT ((0)) FOR [archivado]
GO
ALTER TABLE [dbo].[sectores] ADD  CONSTRAINT [DF_sectores_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER DATABASE [aWords.old] SET  READ_WRITE 
GO
