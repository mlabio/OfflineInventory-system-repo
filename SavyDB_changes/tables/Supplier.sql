USE [SavyDB]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 3/1/2019 8:35:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[supplierId] [int] IDENTITY(1,1) NOT NULL,
	[supplierName] [varchar](255) NULL,
	[supplierAddress] [varchar](255) NULL,
	[supplierPhoneNumber] [varchar](255) NULL,
	[supplierContactPerson] [varchar](255) NULL,
	[supplierStatus] [int] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[supplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
