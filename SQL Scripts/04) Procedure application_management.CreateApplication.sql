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
	 @pApplicationName nvarchar(25),
	 @pErrorNumber nvarchar(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @ApplicationID uniqueidentifier = NEWID();
	DECLARE @IsCurrent bit = 1;
	DECLARE @CreatedBy nvarchar(100) = USER_NAME();
	DECLARE @CreationDate datetime = GETDATE();
	
	BEGIN TRANSACTION;

	BEGIN TRY
		INSERT INTO application_management.Applications(ApplicationId, ApplicationName, IsCurrent, CreatedBy, CreationDate)
												 VALUES(@ApplicationID, @pApplicationName, @IsCurrent, @CreatedBy, @CreationDate);
		SET @pErrorNumber ='OK';
	END TRY
	BEGIN CATCH
		SET @pErrorNumber = 'Error Number: ' + CAST(ERROR_NUMBER() AS VARCHAR(10)) + '; ' + Char(10) +
							'Error Severity: ' + CAST(ERROR_SEVERITY() AS VARCHAR(10)) + '; ' + Char(10) +
							'Error State: ' + CAST(ERROR_STATE() AS VARCHAR(10)) + '; ' + Char(10) +
							'Error Line: ' + CAST(ERROR_LINE() AS VARCHAR(10)) + '; ' + Char(10) +
							'Error Message: ' + ERROR_MESSAGE();

		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
	END CATCH

	IF @@TRANCOUNT > 0
		COMMIT TRANSACTION;
END
GO
