USE [master]
GO
/****** Object:  Database [veritabani2]    Script Date: 6/2/2022 11:28:41 AM ******/
CREATE DATABASE [veritabani2]
 CONTAINMENT = NONE
GO
ALTER DATABASE [veritabani2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [veritabani2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [veritabani2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [veritabani2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [veritabani2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [veritabani2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [veritabani2] SET ARITHABORT OFF 
GO
ALTER DATABASE [veritabani2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [veritabani2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [veritabani2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [veritabani2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [veritabani2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [veritabani2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [veritabani2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [veritabani2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [veritabani2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [veritabani2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [veritabani2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [veritabani2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [veritabani2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [veritabani2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [veritabani2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [veritabani2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [veritabani2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [veritabani2] SET RECOVERY FULL 
GO
ALTER DATABASE [veritabani2] SET  MULTI_USER 
GO
ALTER DATABASE [veritabani2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [veritabani2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [veritabani2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [veritabani2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [veritabani2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [veritabani2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'veritabani2', N'ON'
GO
ALTER DATABASE [veritabani2] SET QUERY_STORE = OFF
GO
USE [veritabani2]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 6/2/2022 11:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[Dr_id] [int] NULL,
	[Dr_tc] [nvarchar](50) NULL,
	[Dr_name] [nvarchar](50) NOT NULL,
	[Dr_lastname] [nvarchar](50) NULL,
	[Dr_phone] [nvarchar](50) NULL,
	[Dr_tarih] [nvarchar](50) NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ilac]    Script Date: 6/2/2022 11:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ilac](
	[pt_name] [nvarchar](50) NULL,
	[pt_lastname] [nvarchar](50) NULL,
	[ilac_id] [int] NULL,
	[ilac_name] [nvarchar](50) NULL,
	[ilac_doz] [nvarchar](50) NULL,
	[ilc_fiyat] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 6/2/2022 11:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[PT_id] [int] NULL,
	[PT_tc] [nvarchar](50) NULL,
	[PT_name] [nvarchar](50) NOT NULL,
	[PT_lastname] [nvarchar](50) NULL,
	[PT_phone] [nvarchar](50) NULL,
	[PT_tarih] [nvarchar](50) NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [veritabani2] SET  READ_WRITE 
GO
