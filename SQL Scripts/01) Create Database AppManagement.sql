USE [master]
GO

/****** Object:  Database [AppManagement]    Script Date: 20/07/2021 00:04:59 ******/
CREATE DATABASE [AppManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AppManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AppManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AppManagement] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AppManagement] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AppManagement] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AppManagement] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AppManagement] SET ARITHABORT OFF 
GO

ALTER DATABASE [AppManagement] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [AppManagement] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AppManagement] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AppManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AppManagement] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AppManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AppManagement] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AppManagement] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AppManagement] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AppManagement] SET  DISABLE_BROKER 
GO

ALTER DATABASE [AppManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AppManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AppManagement] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AppManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AppManagement] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AppManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AppManagement] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AppManagement] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [AppManagement] SET  MULTI_USER 
GO

ALTER DATABASE [AppManagement] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AppManagement] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AppManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AppManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [AppManagement] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [AppManagement] SET QUERY_STORE = OFF
GO

ALTER DATABASE [AppManagement] SET  READ_WRITE 
GO


