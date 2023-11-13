USE [Market]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 04/22/2023 21:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 04/22/2023 21:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] NOT NULL,
	[Category_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProoductCategory]    Script Date: 04/22/2023 21:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProoductCategory](
	[IdProduct] [int] NULL,
	[IdCategory] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_ProoductCategory_Category]    Script Date: 04/22/2023 21:21:49 ******/
ALTER TABLE [dbo].[ProoductCategory]  WITH CHECK ADD  CONSTRAINT [FK_ProoductCategory_Category] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[ProoductCategory] CHECK CONSTRAINT [FK_ProoductCategory_Category]
GO
/****** Object:  ForeignKey [FK_ProoductCategory_Product]    Script Date: 04/22/2023 21:21:49 ******/
ALTER TABLE [dbo].[ProoductCategory]  WITH CHECK ADD  CONSTRAINT [FK_ProoductCategory_Product] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[ProoductCategory] CHECK CONSTRAINT [FK_ProoductCategory_Product]
GO
