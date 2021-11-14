USE [AppManagement]
GO

/****** Object:  Table [application_management].[LoginMethods]    Script Date: 13/11/2021 08:46:52 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [application_management].[LoginMethods](
	[LoginMethodId] [uniqueidentifier] NOT NULL,
	[LoginMethodNumber] [int] IDENTITY(1,1) NOT NULL,
	[LoginMethodCode] [nvarchar](10) NOT NULL,
	[LoginMethodName] [nvarchar](25) NOT NULL,
	[IsCurrent] [bit] NOT NULL,
	[CreatedBy] [nvarchar](100) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_LoginMethods] PRIMARY KEY CLUSTERED 
(
	[LoginMethodNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [application_management].[LoginMethods] ADD  CONSTRAINT [DF_LoginMethods_LoginMethodId]  DEFAULT (newid()) FOR [LoginMethodId]
GO

ALTER TABLE [application_management].[LoginMethods] ADD  CONSTRAINT [DF_LoginMethods_IsCurrent]  DEFAULT ((1)) FOR [IsCurrent]
GO

ALTER TABLE [application_management].[LoginMethods] ADD  CONSTRAINT [DF_LoginMethods_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO



