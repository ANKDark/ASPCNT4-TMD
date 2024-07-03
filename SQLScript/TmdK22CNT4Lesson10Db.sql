USE [TmdK22CNT4Lesson10Db]
GO
/****** Object:  Table [dbo].[TmdAccount]    Script Date: 03/07/2024 2:08:50 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TmdAccount](
	[TmdID] [int] IDENTITY(1,1) NOT NULL,
	[TmdUserName] [nvarchar](50) NULL,
	[TmdPassword] [nvarchar](50) NULL,
	[TmdFullName] [nvarchar](50) NULL,
	[TmdEmail] [nvarchar](50) NULL,
	[TmdPhone] [nvarchar](50) NULL,
	[TmdActive] [bit] NULL,
 CONSTRAINT [PK_TmdAccount] PRIMARY KEY CLUSTERED 
(
	[TmdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TmdAccount] ON 

INSERT [dbo].[TmdAccount] ([TmdID], [TmdUserName], [TmdPassword], [TmdFullName], [TmdEmail], [TmdPhone], [TmdActive]) VALUES (1, N'TranDuc', N'123Duc', N'Trần Minh Đức', N'dikhapthegioi2@gmail.com', N'0855312279', 1)
SET IDENTITY_INSERT [dbo].[TmdAccount] OFF
GO
