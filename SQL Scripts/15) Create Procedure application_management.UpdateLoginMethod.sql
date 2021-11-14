USE [AppManagement]
GO

/****** Object:  StoredProcedure [application_management].[UpdateLoginMethod]    Script Date: 13/11/2021 12:49:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ============================================================================
-- Author:		Julio Cesar Plascencia Hernandez
-- Create date: Saturday, Novemmber 13th. 2021
-- Description:	Updates login method data to manage from IotaOmicron framework.
-- ============================================================================
CREATE PROCEDURE [application_management].[UpdateLoginMethod]
	 @pLoginMethodNumber INT,
	 @pLoginMethodCode NVARCHAR(10),
	 @pLoginMethodName NVARCHAR(25),
	 @pLoginMethodUserName NVARCHAR(100),
	 @pErrorNumber NVARCHAR(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @IsDataChanged BIT         = 0;
	DECLARE @ModificationDate DATETIME = GETDATE();
	DECLARE @CurrentLoginMethodCode NVARCHAR(10);
	DECLARE @CurrentLoginMethodName NVARCHAR(25);

	BEGIN TRANSACTION;

	BEGIN TRY
		-- Looks for current values of the application to update
		SELECT @CurrentLoginMethodCode = LoginMethodCode, @CurrentLoginMethodName = LoginMethodName
		  FROM application_management.[LoginMethods]
		 WHERE LoginMethodNumber = @pLoginMethodNumber

		-- Check if any value will change the current record data
		IF (@CurrentLoginMethodCode <> @pLoginMethodCode)
			SET @IsDataChanged = 1;

		IF (@CurrentLoginMethodName <> @pLoginMethodName)
			SET @IsDataChanged = 1;

		-- If changes were made, update application data where appropiate. Otherwise, send message that no data was changed
		IF (@IsDataChanged = 1)
		BEGIN
			-- 1: Removing the current record's relevancy
			UPDATE application_management.[LoginMethods]
			   SET IsCurrent         = 0,
				   ModifiedBy        = @pLoginMethodUserName,
				   ModificationDate  = @ModificationDate
			 WHERE LoginMethodNumber        = @pLoginMethodNumber;

			-- 2: Inserting the new current record
			INSERT INTO application_management.[LoginMethods](LoginMethodCode, LoginMethodName, CreatedBy)
											    VALUES(@pLoginMethodCode, @pLoginMethodName, @pLoginMethodUserName);

			SET @pErrorNumber ='OK - Data for new LoginMethod Number ' + CAST(@@IDENTITY AS NVARCHAR(7))  + ' updated successfully';
		END
		ELSE
		BEGIN
			SET @pErrorNumber ='OK - No data was changed for LoginMethod Number ' + CAST(@pLoginMethodNumber AS NVARCHAR(7));		
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


