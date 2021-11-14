USE [AppManagement]
GO

/****** Object:  StoredProcedure [application_management].[UpdateStatus]    Script Date: 13/11/2021 21:28:23 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ============================================================================
-- Author:		Julio Cesar Plascencia Hernandez
-- Create date: Saturday, Novemmber 13th. 2021
-- Description:	Updates status data to manage from IotaOmicron framework.
-- ============================================================================
CREATE PROCEDURE [application_management].[UpdateStatus]
	 @pStatusNumber INT,
	 @pStatusCode NVARCHAR(10),
	 @pStatusName NVARCHAR(25),
	 @pStatusUserName NVARCHAR(100),
	 @pErrorNumber NVARCHAR(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @IsDataChanged BIT         = 0;
	DECLARE @ModificationDate DATETIME = GETDATE();
	DECLARE @CurrentStatusCode NVARCHAR(10);
	DECLARE @CurrentStatusName NVARCHAR(25);

	BEGIN TRANSACTION;

	BEGIN TRY
		-- Looks for current values of the application to update
		SELECT @CurrentStatusCode = StatusCode, @CurrentStatusName = StatusName
		  FROM application_management.[Statuss]
		 WHERE StatusNumber = @pStatusNumber

		-- Check if any value will change the current record data
		IF (@CurrentStatusCode <> @pStatusCode)
			SET @IsDataChanged = 1;

		IF (@CurrentStatusName <> @pStatusName)
			SET @IsDataChanged = 1;

		-- If changes were made, update application data where appropiate. Otherwise, send message that no data was changed
		IF (@IsDataChanged = 1)
		BEGIN
			-- 1: Removing the current record's relevancy
			UPDATE application_management.[Status]
			   SET IsCurrent         = 0,
				   ModifiedBy        = @pStatusUserName,
				   ModificationDate  = @ModificationDate
			 WHERE StatusNumber      = @pStatusNumber;

			-- 2: Inserting the new current record
			INSERT INTO application_management.[Statuss](StatusCode, StatusName, CreatedBy)
											    VALUES(@pStatusCode, @pStatusName, @pStatusUserName);

			SET @pErrorNumber ='OK - Data for new Status Number ' + CAST(@@IDENTITY AS NVARCHAR(7))  + ' updated successfully';
		END
		ELSE
		BEGIN
			SET @pErrorNumber ='OK - No data was changed for Status Number ' + CAST(@pStatusNumber AS NVARCHAR(7));		
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


