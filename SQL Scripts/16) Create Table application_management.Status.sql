USE [AppManagement]
GO

/****** Object:  Table [dbo].[application_management.Status]    Script Date: 13/11/2021 09:19:41 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [application_management].[Status](
	[StatusId] [uniqueidentifier] NOT NULL,
	[StatusNumber] [int] IDENTITY(1,1) NOT NULL,
	[StatusCode] [nvarchar](10) NOT NULL,
	[StatusName] [nvarchar](25) NOT NULL,
	[IsCurrent] [bit] NOT NULL,
	[CreatedBy] [nvarchar](100) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [application_management].[Status] ADD  CONSTRAINT [DF_application_management.Status_StatusId]  DEFAULT (newid()) FOR [StatusId]
GO

ALTER TABLE [application_management].[Status] ADD  CONSTRAINT [DF_application_management.Status_IsCurrent]  DEFAULT ((1)) FOR [IsCurrent]
GO

ALTER TABLE [application_management].[Status] ADD  CONSTRAINT [DF_Status_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO


