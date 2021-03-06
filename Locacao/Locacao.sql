USE [master]
GO
/****** Object:  Database [LOCACAO]    Script Date: 15/05/2017 20:40:47 ******/
CREATE DATABASE [LOCACAO]
GO
USE [LOCACAO]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/05/2017 20:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](35) NULL,
	[endereco] [varchar](35) NULL,
	[cidade] [varchar](25) NULL,
	[estado] [varchar](2) NULL,
	[fone] [varchar](14) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemLocacao]    Script Date: 15/05/2017 20:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemLocacao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[locacao] [int] NULL,
	[produto] [int] NOT NULL,
	[entrega] [datetime] NULL,
	[valor] [float] NULL,
	[dias] [int] NOT NULL,
 CONSTRAINT [PK_ItemLocacao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Locacao]    Script Date: 15/05/2017 20:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locacao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data] [datetime] NULL,
	[cliente] [int] NULL,
 CONSTRAINT [PK_Locacao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Produto]    Script Date: 15/05/2017 20:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](35) NULL,
	[valor] [float] NULL,
	[status] [char](1) NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id], [nome], [endereco], [cidade], [estado], [fone]) VALUES (1, N'Almir', N'Rua X', N'Assis', N'SP', N'(18)99765-3454')
INSERT [dbo].[Cliente] ([id], [nome], [endereco], [cidade], [estado], [fone]) VALUES (2, N'Alex', N'Rua Y', N'Rio de Janeiro', N'RJ', N'(21) 323333234')
INSERT [dbo].[Cliente] ([id], [nome], [endereco], [cidade], [estado], [fone]) VALUES (3, N'Begosso', N'Rua Z', N'Candido Mota', N'SP', N'(18) 334''-2342')
INSERT [dbo].[Cliente] ([id], [nome], [endereco], [cidade], [estado], [fone]) VALUES (4, N'Joao', N'Rua dos Corinthianos', N'São Paulo', N'SP', N'(11) 3323-5354')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[ItemLocacao] ON 

INSERT [dbo].[ItemLocacao] ([id], [locacao], [produto], [entrega], [valor], [dias]) VALUES (1, 1, 1, CAST(N'2017-05-18 00:00:00.000' AS DateTime), 100, 3)
INSERT [dbo].[ItemLocacao] ([id], [locacao], [produto], [entrega], [valor], [dias]) VALUES (2, 2, 3, CAST(N'2017-05-16 00:00:00.000' AS DateTime), 80, 2)
SET IDENTITY_INSERT [dbo].[ItemLocacao] OFF
SET IDENTITY_INSERT [dbo].[Locacao] ON 

INSERT [dbo].[Locacao] ([id], [data], [cliente]) VALUES (1, CAST(N'2017-05-15 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Locacao] ([id], [data], [cliente]) VALUES (2, CAST(N'2017-05-14 00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Locacao] OFF
SET IDENTITY_INSERT [dbo].[Produto] ON 

INSERT [dbo].[Produto] ([id], [descricao], [valor], [status]) VALUES (1, N'Andaime', 100, N'L')
INSERT [dbo].[Produto] ([id], [descricao], [valor], [status]) VALUES (2, N'Betoneira', 80, N'L')
INSERT [dbo].[Produto] ([id], [descricao], [valor], [status]) VALUES (3, N'Socador de Terra', 100, N'L')
INSERT [dbo].[Produto] ([id], [descricao], [valor], [status]) VALUES (4, N'Bate Estaca', 50, N'L')
SET IDENTITY_INSERT [dbo].[Produto] OFF
ALTER TABLE [dbo].[ItemLocacao]  WITH CHECK ADD  CONSTRAINT [FK_ItemLocacao_Locacao] FOREIGN KEY([locacao])
REFERENCES [dbo].[Locacao] ([id])
GO
ALTER TABLE [dbo].[ItemLocacao] CHECK CONSTRAINT [FK_ItemLocacao_Locacao]
GO
ALTER TABLE [dbo].[ItemLocacao]  WITH CHECK ADD  CONSTRAINT [FK_ItemLocacao_Produto1] FOREIGN KEY([produto])
REFERENCES [dbo].[Produto] ([id])
GO
ALTER TABLE [dbo].[ItemLocacao] CHECK CONSTRAINT [FK_ItemLocacao_Produto1]
GO
ALTER TABLE [dbo].[Locacao]  WITH CHECK ADD  CONSTRAINT [FK_Locacao_Cliente1] FOREIGN KEY([cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Locacao] CHECK CONSTRAINT [FK_Locacao_Cliente1]
GO
USE [master]
GO
ALTER DATABASE [LOCACAO] SET  READ_WRITE 
GO
