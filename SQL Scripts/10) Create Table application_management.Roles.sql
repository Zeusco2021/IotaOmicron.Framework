USE [AppManagement]
GO

/****** Object:  Table [application_management].[Roles]    Script Date: 13/11/2021 08:57:46 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [application_management].[Roles](
	[RoleId] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[RoleNumber] [int] IDENTITY(1,1) NOT NULL,
	[RoleCode] [nvarchar](10) NOT NULL,
	[RoleName] [nvarchar](25) NOT NULL,
	[IsCurrent] [bit] NOT NULL,
	[CreatedBy] [nvarchar](100) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [application_management].[Roles] ADD  CONSTRAINT [DF_Roles_RoleId]  DEFAULT (newid()) FOR [RoleId]
GO

ALTER TABLE [application_management].[Roles] ADD  CONSTRAINT [DF_Roles_IsCurrent]  DEFAULT ((1)) FOR [IsCurrent]
GO

ALTER TABLE [application_management].[Roles] ADD  CONSTRAINT [DF_Roles_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO


