USE [SavyDB]
GO
/****** Object:  Table [dbo].[Attribute_value]    Script Date: 2/26/2019 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attribute_value](
	[attributeValueId] [int] NULL,
	[attributeValueName] [varchar](50) NULL,
	[attributeValueStatus] [int] NULL,
	[attributeValueDescription] [varchar](255) NULL,
	[DATE_CREATE] [datetime] NULL,
	[LAST_UPDATE] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attributes]    Script Date: 2/26/2019 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attributes](
	[attributeId] [int] IDENTITY(1,1) NOT NULL,
	[attributeName] [varchar](50) NULL,
	[attributeStatus] [int] NULL,
	[attributeDescription] [varchar](255) NULL,
	[DATE_CREATE] [datetime] NULL,
	[LAST_UPDATE] [datetime] NULL,
 CONSTRAINT [PK_Attributes] PRIMARY KEY CLUSTERED 
(
	[attributeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 2/26/2019 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[brandId] [int] IDENTITY(1,1) NOT NULL,
	[brandName] [varchar](50) NULL,
	[brandStatus] [int] NULL,
	[brandDescription] [varchar](50) NULL,
	[CREATE_DATE] [varchar](50) NULL,
	[LAST_UPDATE] [varchar](50) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[brandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2/26/2019 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[categoryId] [int] NULL,
	[categoryName] [varchar](50) NULL,
	[categoryStatus] [int] NULL,
	[categoryDescription] [varchar](50) NULL,
	[DATE_CREATE] [datetime] NULL,
	[LAST_UPDATE] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2/26/2019 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[productId] [int] IDENTITY(1,1) NOT NULL,
	[productName] [varchar](255) NULL,
	[productStatus] [int] NULL,
	[productDescription] [varchar](255) NULL,
	[productSku] [varchar](255) NULL,
	[productPrice] [varchar](255) NULL,
	[productQty] [int] NULL,
	[productImage] [text] NULL,
	[attribute_value_id] [int] NULL,
	[brand_id] [int] NULL,
	[category_id] [int] NULL,
	[DATE_CREATE] [datetime] NULL,
	[LAST_UPDATE] [datetime] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[productId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Store]    Script Date: 2/26/2019 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[storeId] [int] IDENTITY(1,1) NOT NULL,
	[storeName] [varchar](50) NULL,
	[storeStatus] [int] NULL,
	[storeDescription] [int] NULL,
	[DATE_CREATE] [datetime] NULL,
	[LAST_UPDATE] [nchar](10) NULL,
 CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED 
(
	[storeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2/26/2019 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](255) NULL,
	[enc_password] [varchar](255) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
