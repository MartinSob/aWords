/****** Object:  Table [dbo].[emblemas]    Script Date: 2020-07-07 23:22:44 ******/
CREATE TABLE [dbo].[emblemas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_emblemas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

-- Inserts
INSERT [dbo].[emblemas] ([nombre]) VALUES (N'Bronce')
INSERT [dbo].[emblemas] ([nombre]) VALUES (N'Plata')
INSERT [dbo].[emblemas] ([nombre]) VALUES (N'Oro')