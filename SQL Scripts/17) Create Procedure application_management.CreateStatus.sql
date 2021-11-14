USE [AppManagement]
GO

/****** Object:  StoredProcedure [application_management].[CreateStatus]    Script Date: 15/11/2021 21:26:56 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =========================================================================
-- Author:		Julio Cesar Plascencia Hernandez
-- Create date: Friday, November 12th. 2021
-- Description:	Creates a Status to manage from IotaOmicron framework.
-- =========================================================================
CREATE PROCEDURE [application_management].[CreateStatus]
	 @pStatusCode NVARCHAR(10),
	 @pStatusName NVARCHAR(25),
	 @pStatusUserName NVARCHAR(100),
	 @pErrorNumber NVARCHAR(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	BEGIN TRANSACTION;

	BEGIN TRY
		INSERT INTO application_management.[Status](StatusCode, StatusName, CreatedBy)
									        VALUES(@pStatusCode, @pStatusName, @pStatusUserName);
		SET @pErrorNumber ='OK - Created application name ' + @pStatusName + ' with ID ' + CAST(@@IDENTITY AS NVARCHAR(7))  + ' successfully';
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