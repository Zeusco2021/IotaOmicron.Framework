USE [AppManagement]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ===========================================================================
-- Author:		Julio Cesar Plascencia Hernandez
-- Create date: Friday, Novemmber 12th. 2021
-- Description:	Updates application data to manage from IotaOmicron framework.
-- ===========================================================================
CREATE PROCEDURE [application_management].[UpdateApplication]
	 @pApplicationNumber INT,
	 @pApplicationCode NVARCHAR(10),
	 @pApplicationName NVARCHAR(25),
	 @pApplicationUserName NVARCHAR(100),
	 @pErrorNumber NVARCHAR(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @IsDataChanged BIT         = 0;
	DECLARE @ModificationDate DATETIME = GETDATE();
	DECLARE @CurrentApplicationCode NVARCHAR(10);
	DECLARE @CurrentApplicationName NVARCHAR(25);

	BEGIN TRANSACTION;

	BEGIN TRY
		-- Looks for current values of the application to update
		SELECT @CurrentApplicationCode = ApplicationCode, @CurrentApplicationName = ApplicationName
		  FROM application_management.Applications
		 WHERE ApplicationNumber = @pApplicationNumber

		-- Check if any value will change the current record data
		IF (@CurrentApplicationCode <> @pApplicationCode)
			SET @IsDataChanged = 1;

		IF (@CurrentApplicationName <> @pApplicationName)
			SET @IsDataChanged = 1;

		-- If changes were made, update application data where appropiate. Otherwise, send message that no data was changed
		IF (@IsDataChanged = 1)
		BEGIN
			-- 1: Removing the current record's relevancy
			UPDATE application_management.Applications
			   SET IsCurrent         = 0,
				   ModifiedBy        = @pApplicationUserName,
				   ModificationDate  = @ModificationDate
			 WHERE ApplicationNumber = @pApplicationNumber;

			-- 2: Inserting the new current record
			INSERT INTO application_management.Applications(ApplicationCode, ApplicationName, CreatedBy)
													 VALUES(@pApplicationCode, @pApplicationName,  @pApplicationUserName);

			SET @pErrorNumber ='OK - Data for new Application Number ' + CAST(@@IDENTITY AS NVARCHAR(7))  + ' updated successfully';
		END
		ELSE
		BEGIN
			SET @pErrorNumber ='OK - No data was changed for Application Number ' + CAST(@pApplicationNumber AS NVARCHAR(7));		
		END

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


