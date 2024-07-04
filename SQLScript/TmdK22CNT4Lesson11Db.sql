USE [TmdK22CNT4Lesson11Db]
GO
/****** Object:  Table [dbo].[TmdCategory]    Script Date: 04/07/2024 10:14:49 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TmdCategory](
	[TmdID] [int] IDENTITY(1,1) NOT NULL,
	[TmdCateName] [nvarchar](50) NULL,
	[TmdStatus] [bit] NULL,
 CONSTRAINT [PK_TmdCategory] PRIMARY KEY CLUSTERED 
(
	[TmdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TmdProduct]    Script Date: 04/07/2024 10:14:49 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TmdProduct](
	[TmdId2210900014] [nvarchar](50) NOT NULL,
	[TmdProName] [nvarchar](50) NULL,
	[TmdQty] [int] NULL,
	[TmdPrice] [float] NULL,
	[TmdCateId] [int] NULL,
	[TmdActive] [bit] NULL,
 CONSTRAINT [PK_TmdProduct] PRIMARY KEY CLUSTERED 
(
	[TmdId2210900014] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TmdCategory] ON 

INSERT [dbo].[TmdCategory] ([TmdID], [TmdCateName], [TmdStatus]) VALUES (1, N'2210900014', 1)
INSERT [dbo].[TmdCategory] ([TmdID], [TmdCateName], [TmdStatus]) VALUES (2, N'Realme', 0)
SET IDENTITY_INSERT [dbo].[TmdCategory] OFF
GO
INSERT [dbo].[TmdProduct] ([TmdId2210900014], [TmdProName], [TmdQty], [TmdPrice], [TmdCateId], [TmdActive]) VALUES (N'2210900014', N'Trần Minh Đức', 10, 1000, 1, 1)
INSERT [dbo].[TmdProduct] ([TmdId2210900014], [TmdProName], [TmdQty], [TmdPrice], [TmdCateId], [TmdActive]) VALUES (N'P001', N'Realme Gt Neo 3', 1, 2000000, 1, 1)
GO
ALTER TABLE [dbo].[TmdProduct]  WITH CHECK ADD  CONSTRAINT [FK_TmdProduct_TmdCategory] FOREIGN KEY([TmdCateId])
REFERENCES [dbo].[TmdCategory] ([TmdID])
GO
ALTER TABLE [dbo].[TmdProduct] CHECK CONSTRAINT [FK_TmdProduct_TmdCategory]
GO
