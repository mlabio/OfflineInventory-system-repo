USE [SavyPOS_DB]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 3/10/2019 7:57:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Brands](
	[brandId] [int] IDENTITY(1,1) NOT NULL,
	[brandName] [varchar](255) NULL,
	[brandDescription] [varchar](255) NULL,
	[brandStatus] [int] NULL,
	[CREATE_DATE] [datetime] NULL,
	[LAST_UPDATE_DATE] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/10/2019 7:57:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[productId] [int] IDENTITY(1,1) NOT NULL,
	[productName] [varchar](255) NULL,
	[productDescription] [varchar](255) NULL,
	[productStatus] [int] NULL,
	[productSKU] [varchar](255) NULL,
	[productPrice] [varchar](255) NULL,
	[productQty] [int] NULL,
	[productImage] [text] NULL,
	[brandId] [int] NULL,
	[supplierId] [int] NULL,
	[CREATE_DATE] [datetime] NULL,
	[LAST_UPDATE_DATE] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 3/10/2019 7:57:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suppliers](
	[supplierId] [int] IDENTITY(1,1) NOT NULL,
	[supplierName] [varchar](255) NULL,
	[supplierDescription] [varchar](255) NULL,
	[supplierStatus] [int] NULL,
	[supplierAddress] [varchar](255) NULL,
	[supplierType] [int] NULL,
	[supplierPhone] [varchar](255) NULL,
	[supplierContactPerson] [varchar](255) NULL,
	[CREATE_DATE] [datetime] NULL,
	[LAST_UPDATE_DATE] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransactionProducts]    Script Date: 3/10/2019 7:57:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionProducts](
	[transProdId] [int] IDENTITY(1,1) NOT NULL,
	[productQtySold] [int] NULL,
	[productId] [int] NULL,
	[CREATE_DATE] [datetime] NULL,
	[LAST_UPDATE_DATE] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 3/10/2019 7:57:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[transactionId] [int] IDENTITY(1,1) NOT NULL,
	[transactionDate] [datetime] NULL,
	[isDeleted] [int] NULL,
	[transactionNumber] [int] NULL,
	[CREATE_DATE] [datetime] NULL,
	[LAST_UPDATE_DATE] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/10/2019 7:57:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](255) NULL,
	[userPassword] [varchar](12) NULL,
	[CREATE_DATE] [datetime] NULL,
	[LAST_UPDATE_DATE] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([brandId], [brandName], [brandDescription], [brandStatus], [CREATE_DATE], [LAST_UPDATE_DATE]) VALUES (1, N'rqerqqw`', N'fassssaaaa', 1, CAST(N'2019-03-10 00:00:00.000' AS DateTime), CAST(N'2019-03-10 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Brands] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([productId], [productName], [productDescription], [productStatus], [productSKU], [productPrice], [productQty], [productImage], [brandId], [supplierId], [CREATE_DATE], [LAST_UPDATE_DATE]) VALUES (1, N's', N's', 1, N'w', N'f', 4, NULL, 0, 0, CAST(N'2019-03-10 00:00:00.000' AS DateTime), CAST(N'2019-03-10 00:00:00.000' AS DateTime))
INSERT [dbo].[Products] ([productId], [productName], [productDescription], [productStatus], [productSKU], [productPrice], [productQty], [productImage], [brandId], [supplierId], [CREATE_DATE], [LAST_UPDATE_DATE]) VALUES (2, N'aaaaaaaa', N'rrrrrr', 1, N'eddddddd', N'vvvvvvv', 1213, NULL, 1, 1, CAST(N'2019-03-10 00:00:00.000' AS DateTime), CAST(N'2019-03-10 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([supplierId], [supplierName], [supplierDescription], [supplierStatus], [supplierAddress], [supplierType], [supplierPhone], [supplierContactPerson], [CREATE_DATE], [LAST_UPDATE_DATE]) VALUES (1, N'dasdasd', N'fasfasd', 1, N'dafsa', 1, N'316464', N'wqrqwrdsaf', CAST(N'2019-03-10 00:00:00.000' AS DateTime), CAST(N'2019-03-10 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
