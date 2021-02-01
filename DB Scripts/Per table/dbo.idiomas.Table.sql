/****** Object:  Table [dbo].[idiomas]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[idiomas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_idiomas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

-- Inserts
INSERT [dbo].[idiomas] ([nombre]) VALUES (N'Castellano')
INSERT [dbo].[idiomas] ([nombre]) VALUES (N'English')

