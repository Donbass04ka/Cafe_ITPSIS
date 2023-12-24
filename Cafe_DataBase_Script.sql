USE [master]
GO

/****** Object:  Database [Cafe_DataBase]    Script Date: 24.12.2023 10:29:07 ******/
CREATE DATABASE [Cafe_DataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cafe_DataBase', FILENAME = N'C:\Users\KaLbIch\Cafe_DataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cafe_DataBase_log', FILENAME = N'C:\Users\KaLbIch\Cafe_DataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cafe_DataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Cafe_DataBase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET ARITHABORT OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [Cafe_DataBase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Cafe_DataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Cafe_DataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Cafe_DataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Cafe_DataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Cafe_DataBase] SET  MULTI_USER 
GO

ALTER DATABASE [Cafe_DataBase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Cafe_DataBase] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Cafe_DataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Cafe_DataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Cafe_DataBase] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Cafe_DataBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Cafe_DataBase] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Cafe_DataBase] SET  READ_WRITE 
GO

