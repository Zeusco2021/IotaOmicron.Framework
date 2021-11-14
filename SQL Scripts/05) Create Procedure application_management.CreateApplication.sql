USE appManagement;
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =========================================================================
-- Author:		Julio Cesar Plascencia Hernandez
-- Create date: Monday, July 19th. 2021
-- Description:	Creates an application to manage from IotaOmicron framework.
-- =========================================================================
CREATE PROCEDURE application_management.CreateApplication
	 @pApplicationCode NVARCHAR(10),
	 @pApplicationName NVARCHAR(25),
	 @pApplicationUserName NVARCHAR(100),
	 @pErrorNumber NVARCHAR(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	BEGIN TRANSACTION;

	BEGIN TRY
		INSERT INTO application_management.Applications(ApplicationCode, ApplicationName, CreatedBy)
												 VALUES(@pApplicationCode, @pApplicationName, @pApplicationUserName);
		SET @pErrorNumber ='OK - Created application name ' + @pApplicationName + ' with ID ' + CAST(@@IDENTITY AS NVARCHAR(7))  + ' successfully';
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
