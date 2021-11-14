USE [AppManagement]
GO

/****** Object:  Table [application_management].[Permissions]    Script Date: 13/11/2021 08:56:11 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [application_management].[Permissions](
	[PermissionId] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[PermissionNumber] [int] IDENTITY(1,1) NOT NULL,
	[PermissionCode] [nvarchar](10) NOT NULL,
	[PermissionName] [nvarchar](25) NOT NULL,
	[IsCurrent] [bit] NOT NULL,
	[CreatedBy] [nvarchar](100) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[PermissionNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [application_management].[Permissions] ADD  CONSTRAINT [DF_Permissions_PermissionId]  DEFAULT (newid()) FOR [PermissionId]
GO

ALTER TABLE [application_management].[Permissions] ADD  CONSTRAINT [DF_Permissions_IsCurrent]  DEFAULT ((1)) FOR [IsCurrent]
GO

ALTER TABLE [application_management].[Permissions] ADD  CONSTRAINT [DF_Permissions_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO


