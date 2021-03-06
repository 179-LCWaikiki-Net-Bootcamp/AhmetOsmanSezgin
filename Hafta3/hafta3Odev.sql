USE [master]
GO
/****** Object:  Database [Bootcamp_Hafta3]    Script Date: 5/4/2022 4:13:22 AM ******/
CREATE DATABASE [Bootcamp_Hafta3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bootcamp_Hafta3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.AHMETSDBSERVER\MSSQL\DATA\Bootcamp_Hafta3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bootcamp_Hafta3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.AHMETSDBSERVER\MSSQL\DATA\Bootcamp_Hafta3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bootcamp_Hafta3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bootcamp_Hafta3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bootcamp_Hafta3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET RECOVERY FULL 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET  MULTI_USER 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bootcamp_Hafta3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bootcamp_Hafta3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bootcamp_Hafta3', N'ON'
GO
ALTER DATABASE [Bootcamp_Hafta3] SET QUERY_STORE = OFF
GO
USE [Bootcamp_Hafta3]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/4/2022 4:13:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [smallint] NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/4/2022 4:13:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[ProductId] [smallint] NOT NULL,
	[UserId] [smallint] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 5/4/2022 4:13:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [smallint] NOT NULL,
	[Name] [varchar](50) NULL,
	[Stock] [smallint] NULL,
	[Price] [smallint] NULL,
	[CategoryId] [smallint] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/4/2022 4:13:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Password] [varchar](15) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [User_Mail]    Script Date: 5/4/2022 4:13:22 AM ******/
CREATE NONCLUSTERED INDEX [User_Mail] ON [dbo].[Users]
(
	[Mail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_CreatedDate]  DEFAULT ('11.1.2022') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
/****** Object:  Trigger [dbo].[trg_azalt]    Script Date: 5/4/2022 4:13:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_azalt]
on [dbo].[Orders]
after insert 
as
	declare @urunId INT
	select @urunId=Id from Orders
	update Products set Stock=Stock-1
	where Id=@urunId
GO
ALTER TABLE [dbo].[Orders] ENABLE TRIGGER [trg_azalt]
GO
/****** Object:  Trigger [dbo].[DeleteOrder]    Script Date: 5/4/2022 4:13:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[DeleteOrder]
   ON  [dbo].[Products]
   AFTER DELETE
AS 
BEGIN

	DECLARE @id int
	SELECT @id = Id from Products
	UPDATE Orders SET IsActive = 0 where ProductId = @id
END
GO
ALTER TABLE [dbo].[Products] ENABLE TRIGGER [DeleteOrder]
GO
USE [master]
GO
ALTER DATABASE [Bootcamp_Hafta3] SET  READ_WRITE 
GO
