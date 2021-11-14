USE [AppManagement]
GO

/****** Object:  StoredProcedure [application_management].[UpdateRole]    Script Date: 13/11/2021 12:49:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ===========================================================================
-- Author:		Julio Cesar Plascencia Hernandez
-- Create date: Saturday, Novemmber 13th. 2021
-- Description:	Updates application data to manage from IotaOmicron framework.
-- ===========================================================================
CREATE PROCEDURE [application_management].[UpdateRole]
	 @pRoleNumber INT,
	 @pRoleCode NVARCHAR(10),
	 @pRoleName NVARCHAR(25),
	 @pRoleUserName NVARCHAR(100),
	 @pErrorNumber NVARCHAR(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @IsCurrent BIT             = 1;
	DECLARE @IsDataChanged BIT         = 0;
	DECLARE @CreationDate DATETIME     = GETDATE();
	DECLARE @ModificationDate DATETIME = GETDATE();
	DECLARE @RoleID UNIQUEIDENTIFIER   = NEWID();
	DECLARE @CurrentRoleCode NVARCHAR(10);
	DECLARE @CurrentRoleName NVARCHAR(25);

	BEGIN TRANSACTION;

	BEGIN TRY
		-- Looks for current values of the application to update
		SELECT @CurrentRoleCode = RoleCode, @CurrentRoleName = RoleName
		  FROM application_management.[Roles]
		 WHERE RoleNumber = @pRoleNumber

		-- Check if any value will change the current record data
		IF (@CurrentRoleCode <> @pRoleCode)
			SET @IsDataChanged = 1;

		IF (@CurrentRoleName <> @pRoleName)
			SET @IsDataChanged = 1;

		-- If changes were made, update application data where appropiate. Otherwise, send message that no data was changed
		IF (@IsDataChanged = 1)
		BEGIN
			-- 1: Removing the current record's relevancy
			UPDATE application_management.[Roles]
			   SET IsCurrent         = 0,
				   ModifiedBy        = @pRoleUserName,
				   ModificationDate  = @ModificationDate
			 WHERE RoleNumber        = @pRoleNumber;

			-- 2: Inserting the new current record
			INSERT INTO application_management.[Roles](RoleId, RoleCode, RoleName, IsCurrent, CreatedBy, CreationDate)
													 VALUES(@RoleID, @pRoleCode, @pRoleName, @IsCurrent, @pRoleUserName, @CreationDate);

			SET @pErrorNumber ='OK - Data for new Role Number ' + CAST(@@IDENTITY AS NVARCHAR(7))  + ' updated successfully';
		END
		ELSE
		BEGIN
			SET @pErrorNumber ='OK - No data was changed for Role Number ' + CAST(@pRoleNumber AS NVARCHAR(7));		
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


