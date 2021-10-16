USE [AppManagement]
GO

/****** Object:  Table [application_management].[Applications]    Script Date: 20/07/2021 00:01:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [application_management].[Applications](
	[ApplicationId] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[ApplicationNumber] [int] IDENTITY(1, 1) NOT NULL,
	[ApplicationCode] [nvarchar](10) NOT NULL, 
	[ApplicationName] [nvarchar](25) NOT NULL,
	[IsCurrent] [bit] NOT NULL,
	[CreatedBy] [nvarchar](100) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_Applications] PRIMARY KEY CLUSTERED 
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [application_management].[Applications] ADD  CONSTRAINT [DF_Applications_ApplicationId]  DEFAULT (newid()) FOR [ApplicationId]
GO

ALTER TABLE [application_management].[Applications] ADD  CONSTRAINT [DF_Applications_IsCurrent]  DEFAULT ((1)) FOR [IsCurrent]
GO

ALTER TABLE [application_management].[Applications] ADD  CONSTRAINT [DF_Applications_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO


