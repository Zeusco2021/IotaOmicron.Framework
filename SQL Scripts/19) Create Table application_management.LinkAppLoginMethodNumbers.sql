USE [AppManagement]
GO

/****** Object:  Table [application_management].[LinkAppLoginMethods]    Script Date: 13/11/2021 09:52:49 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [application_management].[LinkAppLoginMethods](
	[LinkAppLoginMethodId] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[LinkAppLoginMethodNumber] [int] IDENTITY(1,1) NOT NULL,
	[LinkAppLoginMethodApplicationNumber] [int] NOT NULL,
	[LinkAppLoginMethodLoginMethodNumber] [int] NOT NULL,
	[IsCurrent] [bit] NOT NULL,
	[CreatedBy] [nvarchar](100) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_LinkAppLoginMethods] PRIMARY KEY CLUSTERED 
(
	[LinkAppLoginMethodNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [application_management].[LinkAppLoginMethods] ADD  CONSTRAINT [DF_LinkAppLoginMethods_LinkAppLoginMethodNumber]  DEFAULT (newid()) FOR [LinkAppLoginMethodId]
GO

ALTER TABLE [application_management].[LinkAppLoginMethods] ADD  CONSTRAINT [DF_LinkAppLoginMethodNumber_IsCurrent]  DEFAULT ((1)) FOR [IsCurrent]
GO

ALTER TABLE [application_management].[LinkAppLoginMethods] ADD  CONSTRAINT [DF_LinkAppLoginMethodNumber_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO

ALTER TABLE [application_management].[LinkAppLoginMethods]  WITH CHECK ADD  CONSTRAINT [FK_LinkAppLoginMethods_Applications] FOREIGN KEY([LinkAppLoginMethodApplicationNumber])
REFERENCES [application_management].[Applications] ([ApplicationNumber])
GO

ALTER TABLE [application_management].[LinkAppLoginMethods] CHECK CONSTRAINT [FK_LinkAppLoginMethods_Applications]
GO

ALTER TABLE [application_management].[LinkAppLoginMethods]  WITH CHECK ADD  CONSTRAINT [FK_LinkAppLoginMethods_LoginMethods] FOREIGN KEY([LinkAppLoginMethodLoginMethodNumber])
REFERENCES [application_management].[LoginMethods] ([LoginMethodNumber])
GO

ALTER TABLE [application_management].[LinkAppLoginMethods] CHECK CONSTRAINT [FK_LinkAppLoginMethods_LoginMethods]
GO

