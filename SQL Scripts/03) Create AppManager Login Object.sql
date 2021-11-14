USE [master]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [AppManager]    Script Date: 05/10/2021 03:54:04 a. m. ******/
CREATE LOGIN [AppManager] WITH PASSWORD=N'caY2+zscHG031EWYfjh896IFUuyZZ96e3KeORt1a+EQ=', DEFAULT_DATABASE=[AppManagement], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

ALTER LOGIN [AppManager] DISABLE
GO


