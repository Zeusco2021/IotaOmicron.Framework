USE [AppManagement]
GO

/****** Object:  StoredProcedure [application_management].[CreateLoginMethod]    Script Date: 12/11/2021 12:53:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =========================================================================
-- Author:		Julio Cesar Plascencia Hernandez
-- Create date: Friday, November 12th. 2021
-- Description:	Creates a LoginMethod to manage from IotaOmicron framework.
-- =========================================================================
CREATE PROCEDURE [application_management].[CreateLoginMethod]
	 @pLoginMethodCode NVARCHAR(10),
	 @pLoginMethodName NVARCHAR(25),
	 @pLoginMethodUserName NVARCHAR(100),
	 @pErrorNumber NVARCHAR(MAX) OUT
AS
BEGIN
	SET NOCOUNT ON;
	
	BEGIN TRANSACTION;

	BEGIN TRY
		INSERT INTO application_management.[LoginMethods](LoginMethodCode, LoginMethodName, CreatedBy)
									        VALUES(@pLoginMethodCode, @pLoginMethodName, @pLoginMethodUserName);
		SET @pErrorNumber ='OK - Created application name ' + @pLoginMethodName + ' with ID ' + CAST(@@IDENTITY AS NVARCHAR(7))  + ' successfully';
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