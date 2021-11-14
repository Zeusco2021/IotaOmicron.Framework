USE [AppManagement]
GO

/****** Object:  StoredProcedure [application_management].[CreateLinkAppLoginMethod] Script Date: 13/11/2021 22:30:01 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =========================================================================
-- Author:		Julio Cesar Plascencia Hernandez
-- Create date: Saturday, November 13th. 2021
-- Description:	Creates a link between applications and login methods to 
--              manage from IotaOmicron framework.
-- =========================================================================
CREATE PROCEDURE [application_management].[CreateLinkAppLoginMethod]
	 @pLinkAppLoginMethodApplicationNumber int,
	 @pLinkAppLoginMethodLoginMethodNumber int,
	 @pLinkAppLoginMethodUserName nvarchar(100),
	 @pErrorNumber NVARCHAR(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	BEGIN TRANSACTION;

	BEGIN TRY
		INSERT INTO application_management.LinkAppLoginMethods(LinkAppLoginMethodApplicationNumber, LinkAppLoginMethodLoginMethodNumber, CreatedBy)
												        VALUES(@pLinkAppLoginMethodApplicationNumber, @pLinkAppLoginMethodLoginMethodNumber, 
															   @pLinkAppLoginMethodUserName);
		SET @pErrorNumber ='OK - Created link between application and Login method with ID ' + CAST(@@IDENTITY AS NVARCHAR(7))  + ' successfully';
	END TRY
	BEGIN CATCH
		SET @pErrorNumber = 'Error Number: ' + CAST(ERROR_NUMBER() AS NVARCHAR(10)) + '; ' + NCHAR(10) +
							'Error Severity: ' + CAST(ERROR_SEVERITY() AS NVARCHAR(10)) + '; ' + NCHAR(10) +
							'Error State: ' + CAST(ERROR_STATE() AS NVARCHAR(10)) + '; ' + NCHAR(10) +
							'Error Line: ' + CAST(ERROR_LINE() AS NVARCHAR(10)) + '; ' + NCHAR(10) +
							'Error Message: ' + ERROR_MESSAGE();

		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
	END CATCH

	IF @@TRANCOUNT > 0
		COMMIT TRANSACTION;
END
GO


