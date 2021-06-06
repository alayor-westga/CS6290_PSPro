USE [master]
--- Close all connections ---
DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('pspro')
EXEC(@kill);
GO
DROP DATABASE IF EXISTS [pspro];
GO
GO
/****** Object:  Database [pspro]    Script Date: 6/6/2021 9:32:02 AM ******/
CREATE DATABASE [pspro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pspro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pspro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pspro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\pspro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [pspro] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pspro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pspro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pspro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pspro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pspro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pspro] SET ARITHABORT OFF 
GO
ALTER DATABASE [pspro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pspro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pspro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pspro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pspro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pspro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pspro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pspro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pspro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pspro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pspro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pspro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pspro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pspro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pspro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pspro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pspro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pspro] SET RECOVERY FULL 
GO
ALTER DATABASE [pspro] SET  MULTI_USER 
GO
ALTER DATABASE [pspro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pspro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pspro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pspro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pspro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pspro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'pspro', N'ON'
GO
ALTER DATABASE [pspro] SET QUERY_STORE = OFF
GO
USE [pspro]
GO
/****** Object:  Table [dbo].[Administrators]    Script Date: 6/6/2021 9:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrators](
	[personnel_id] [int] NOT NULL,
	[username] [varchar](45) NOT NULL,
	[password] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Administrators] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Administrators_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citizens]    Script Date: 6/6/2021 9:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citizens](
	[citizen_id] [int] IDENTITY(5000,1) NOT NULL,
	[first_name] [varchar](45) NOT NULL,
	[last_name] [varchar](45) NULL,
	[address1] [varchar](45) NULL,
	[address2] [varchar](45) NULL,
	[city] [varchar](45) NULL,
	[state] [char](2) NULL,
	[zipcode] [varchar](10) NULL,
	[phone] [varchar](12) NULL,
	[email] [varchar](45) NULL,
 CONSTRAINT [PK_Citizens] PRIMARY KEY CLUSTERED 
(
	[citizen_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Complaints]    Script Date: 6/6/2021 9:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Complaints](
	[complaint_id] [int] IDENTITY(1,1) NOT NULL,
	[citizen_id] [int] NOT NULL,
	[officers_personnel_id] [int] NOT NULL,
	[supervisors_personnel_id] [int] NOT NULL,
	[investigators_personnel_id] [int] NULL,
	[administrators_personnel_id] [int] NULL,
	[date_created] [datetime] NOT NULL,
	[allegation_type] [varchar](45) NOT NULL,
	[complaint_notes] [text] NOT NULL,
	[disposition] [varchar](25) NULL,
	[disposition_date] [date] NULL,
	[discipline] [varchar](45) NULL,
 CONSTRAINT [PK_Complaints] PRIMARY KEY CLUSTERED 
(
	[complaint_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Investigators]    Script Date: 6/6/2021 9:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Investigators](
	[personnel_id] [int] NOT NULL,
	[username] [varchar](45) NOT NULL,
	[password] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Investigators] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Investigators_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Officers]    Script Date: 6/6/2021 9:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Officers](
	[personnel_id] [int] NOT NULL,
 CONSTRAINT [PK_Officers] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personnel]    Script Date: 6/6/2021 9:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personnel](
	[personnel_id] [int] IDENTITY(1000,1) NOT NULL,
	[first_name] [varchar](45) NOT NULL,
	[last_name] [varchar](45) NOT NULL,
	[gender] [char](1) NOT NULL,
	[hire_date] [date] NOT NULL,
	[birthdate] [date] NOT NULL,
	[assignment] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Personnel] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supervisors]    Script Date: 6/6/2021 9:32:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supervisors](
	[personnel_id] [int] NOT NULL,
	[username] [varchar](45) NOT NULL,
	[password] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Supervisors] PRIMARY KEY CLUSTERED 
(
	[personnel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Supervisors_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [FK_Administrators_Personnel] FOREIGN KEY([personnel_id])
REFERENCES [dbo].[Personnel] ([personnel_id])
GO
ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [FK_Administrators_Personnel]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Administrators] FOREIGN KEY([administrators_personnel_id])
REFERENCES [dbo].[Administrators] ([personnel_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Administrators]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Citizens] FOREIGN KEY([citizen_id])
REFERENCES [dbo].[Citizens] ([citizen_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Citizens]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Investigators] FOREIGN KEY([investigators_personnel_id])
REFERENCES [dbo].[Investigators] ([personnel_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Investigators]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Officers] FOREIGN KEY([officers_personnel_id])
REFERENCES [dbo].[Officers] ([personnel_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Officers]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Supervisors] FOREIGN KEY([supervisors_personnel_id])
REFERENCES [dbo].[Supervisors] ([personnel_id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Supervisors]
GO
ALTER TABLE [dbo].[Investigators]  WITH CHECK ADD  CONSTRAINT [FK_Investigators_Personnel] FOREIGN KEY([personnel_id])
REFERENCES [dbo].[Personnel] ([personnel_id])
GO
ALTER TABLE [dbo].[Investigators] CHECK CONSTRAINT [FK_Investigators_Personnel]
GO
ALTER TABLE [dbo].[Officers]  WITH CHECK ADD  CONSTRAINT [FK_Officers_Personnel] FOREIGN KEY([personnel_id])
REFERENCES [dbo].[Personnel] ([personnel_id])
GO
ALTER TABLE [dbo].[Officers] CHECK CONSTRAINT [FK_Officers_Personnel]
GO
ALTER TABLE [dbo].[Supervisors]  WITH CHECK ADD  CONSTRAINT [FK_Supervisors_Personnel] FOREIGN KEY([personnel_id])
REFERENCES [dbo].[Personnel] ([personnel_id])
GO
ALTER TABLE [dbo].[Supervisors] CHECK CONSTRAINT [FK_Supervisors_Personnel]
GO
USE [master]
GO
ALTER DATABASE [pspro] SET  READ_WRITE 
GO
