USE [AppManagement]
GO

/****** Object:  StoredProcedure [application_management].[UpdatePermission]    Script Date: 12/11/2021 12:49:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ===========================================================================
-- Author:		Julio Cesar Plascencia Hernandez
-- Create date: Friday, Novemmber 12th. 2021
-- Description:	Updates application data to manage from IotaOmicron framework.
-- ===========================================================================
CREATE PROCEDURE [application_management].[UpdatePermission]
	 @pPermissionNumber INT,
	 @pPermissionCode NVARCHAR(10),
	 @pPermissionName NVARCHAR(25),
	 @pPermissionUserName NVARCHAR(100),
	 @pErrorNumber NVARCHAR(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @IsCurrent BIT                  = 1;
	DECLARE @IsDataChanged BIT              = 0;
	DECLARE @CreationDate DATETIME          = GETDATE();
	DECLARE @ModificationDate DATETIME      = GETDATE();
	DECLARE @PermissionID UNIQUEIDENTIFIER  = NEWID();
	DECLARE @CurrentPermissionCode NVARCHAR(10);
	DECLARE @CurrentPermissionName NVARCHAR(25);

	BEGIN TRANSACTION;

	BEGIN TRY
		-- Looks for current values of the application to update
		SELECT @CurrentPermissionCode = PermissionCode, @CurrentPermissionName = PermissionName
		  FROM application_management.[Permissions]
		 WHERE PermissionNumber = @pPermissionNumber

		-- Check if any value will change the current record data
		IF (@CurrentPermissionCode <> @pPermissionCode)
			SET @IsDataChanged = 1;

		IF (@CurrentPermissionName <> @pPermissionName)
			SET @IsDataChanged = 1;

		-- If changes were made, update application data where appropiate. Otherwise, send message that no data was changed
		IF (@IsDataChanged = 1)
		BEGIN
			-- 1: Removing the current record's relevancy
			UPDATE application_management.[Permissions]
			   SET IsCurrent         = 0,
				   ModifiedBy        = @pPermissionUserName,
				   ModificationDate  = @ModificationDate
			 WHERE PermissionNumber  = @pPermissionNumber;

			-- 2: Inserting the new current record
			INSERT INTO application_management.[Permissions](PermissionId, PermissionCode, PermissionName, IsCurrent, CreatedBy, CreationDate)
													 VALUES(@PermissionID, @pPermissionCode, @pPermissionName, @IsCurrent, @pPermissionUserName, @CreationDate);

			SET @pErrorNumber ='OK - Data for new Permission Number ' + CAST(@@IDENTITY AS NVARCHAR(7))  + ' updated successfully';
		END
		ELSE
		BEGIN
			SET @pErrorNumber ='OK - No data was changed for Permission Number ' + CAST(@pPermissionNumber AS NVARCHAR(7));		
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


