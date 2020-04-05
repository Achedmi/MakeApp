USE [MakeApp]
GO
/****** Object:  Table [dbo].[Artist]    Script Date: 04/05/2020 15:49:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Artist](
	[Prenom] [varchar](50) NULL,
	[Nom] [varchar](50) NULL,
	[Mail] [varchar](50) NOT NULL,
	[Tel] [int] NULL,
	[Pass] [varchar](50) NULL,
	[Admin] [int] NULL,
 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[Mail] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Artist] ([Prenom], [Nom], [Mail], [Tel], [Pass], [Admin]) VALUES (N'Houda', N'Baklawa', N'houda@houda.com', 123456789, N'1', 0)
/****** Object:  Table [dbo].[Marque]    Script Date: 04/05/2020 15:49:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marque](
	[idMarque] [int] NOT NULL,
	[NomMarque] [varchar](50) NULL,
	[pourcentage] [int] NULL,
 CONSTRAINT [PK_Marque] PRIMARY KEY CLUSTERED 
(
	[idMarque] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Marque] ([idMarque], [NomMarque], [pourcentage]) VALUES (1, N'Niviea', 20)
/****** Object:  Table [dbo].[Client]    Script Date: 04/05/2020 15:49:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Client](
	[Prenom] [varchar](50) NULL,
	[Nom] [varchar](50) NULL,
	[Mail] [varchar](50) NOT NULL,
	[Tel] [int] NULL,
	[Pass] [varchar](50) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Mail] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Client] ([Prenom], [Nom], [Mail], [Tel], [Pass]) VALUES (N'manal', N'bouzrou', N'manal@manal.com', 123456789, N'1')
/****** Object:  Table [dbo].[Choisie]    Script Date: 04/05/2020 15:49:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Choisie](
	[idRdv] [int] NOT NULL,
	[MailArtist] [varchar](50) NULL,
 CONSTRAINT [PK_Choisie] PRIMARY KEY CLUSTERED 
(
	[idRdv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Choisie] ([idRdv], [MailArtist]) VALUES (1, N'houda@houda.com')
/****** Object:  Table [dbo].[RDV]    Script Date: 04/05/2020 15:49:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RDV](
	[idRdv] [int] NOT NULL,
	[DateRdv] [date] NULL,
	[HeurRdv] [time](0) NULL,
	[DescriptionRdv] [varchar](50) NULL,
	[MailFrom] [varchar](50) NULL,
	[idMarque] [int] NOT NULL,
 CONSTRAINT [PK_RDV] PRIMARY KEY CLUSTERED 
(
	[idRdv] ASC,
	[idMarque] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[RDV] ([idRdv], [DateRdv], [HeurRdv], [DescriptionRdv], [MailFrom], [idMarque]) VALUES (1, CAST(0xAD400B00 AS Date), CAST(0x00A08C0000000000 AS Time), N'je veux fair mes cheveux', N'manal@manal.com', 1)
/****** Object:  ForeignKey [FK_Choisie_Artist]    Script Date: 04/05/2020 15:49:10 ******/
ALTER TABLE [dbo].[Choisie]  WITH CHECK ADD  CONSTRAINT [FK_Choisie_Artist] FOREIGN KEY([MailArtist])
REFERENCES [dbo].[Artist] ([Mail])
GO
ALTER TABLE [dbo].[Choisie] CHECK CONSTRAINT [FK_Choisie_Artist]
GO
/****** Object:  ForeignKey [FK_RDV_Choisie]    Script Date: 04/05/2020 15:49:10 ******/
ALTER TABLE [dbo].[RDV]  WITH CHECK ADD  CONSTRAINT [FK_RDV_Choisie] FOREIGN KEY([idRdv])
REFERENCES [dbo].[Choisie] ([idRdv])
GO
ALTER TABLE [dbo].[RDV] CHECK CONSTRAINT [FK_RDV_Choisie]
GO
/****** Object:  ForeignKey [FK_RDV_Client]    Script Date: 04/05/2020 15:49:10 ******/
ALTER TABLE [dbo].[RDV]  WITH CHECK ADD  CONSTRAINT [FK_RDV_Client] FOREIGN KEY([MailFrom])
REFERENCES [dbo].[Client] ([Mail])
GO
ALTER TABLE [dbo].[RDV] CHECK CONSTRAINT [FK_RDV_Client]
GO
/****** Object:  ForeignKey [FK_RDV_Marque]    Script Date: 04/05/2020 15:49:10 ******/
ALTER TABLE [dbo].[RDV]  WITH CHECK ADD  CONSTRAINT [FK_RDV_Marque] FOREIGN KEY([idMarque])
REFERENCES [dbo].[Marque] ([idMarque])
GO
ALTER TABLE [dbo].[RDV] CHECK CONSTRAINT [FK_RDV_Marque]
GO
