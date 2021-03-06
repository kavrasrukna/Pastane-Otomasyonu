USE [master]
GO
/****** Object:  Database [Pastane]    Script Date: 31.5.2022 19:04:17 ******/
CREATE DATABASE [Pastane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pastane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Pastane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pastane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Pastane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Pastane] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pastane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pastane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pastane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pastane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pastane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pastane] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pastane] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pastane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pastane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pastane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pastane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pastane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pastane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pastane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pastane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pastane] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pastane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pastane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pastane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pastane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pastane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pastane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pastane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pastane] SET RECOVERY FULL 
GO
ALTER DATABASE [Pastane] SET  MULTI_USER 
GO
ALTER DATABASE [Pastane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pastane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pastane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pastane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pastane] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pastane] SET QUERY_STORE = OFF
GO
USE [Pastane]
GO
/****** Object:  User [HP_\RÜKNA]    Script Date: 31.5.2022 19:04:17 ******/
CREATE USER [HP_\RÜKNA] FOR LOGIN [HP_\RÜKNA] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_datareader] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [HP_\RÜKNA]
GO
/****** Object:  Table [dbo].[kullanicigiris]    Script Date: 31.5.2022 19:04:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanicigiris](
	[kullanicino] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciad] [varchar](50) NOT NULL,
	[kullanicisifre] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[telefon] [varchar](50) NOT NULL,
 CONSTRAINT [PK_kullanicigiris] PRIMARY KEY CLUSTERED 
(
	[kullanicino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteriler]    Script Date: 31.5.2022 19:04:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteriler](
	[musterino] [int] IDENTITY(1,1) NOT NULL,
	[musteriadsoyad] [varchar](50) NULL,
	[musteritelefon] [varchar](50) NULL,
	[siparisno] [int] NULL,
 CONSTRAINT [PK_musteriler] PRIMARY KEY CLUSTERED 
(
	[musterino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satici]    Script Date: 31.5.2022 19:04:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satici](
	[saticino] [int] IDENTITY(1,1) NOT NULL,
	[saticiadsoyad] [varchar](50) NULL,
	[saticiadres] [varchar](50) NULL,
	[saticiil] [varchar](50) NULL,
	[saticiilce] [varchar](50) NULL,
 CONSTRAINT [PK_satici] PRIMARY KEY CLUSTERED 
(
	[saticino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[siparis]    Script Date: 31.5.2022 19:04:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[siparis](
	[siparisno] [int] IDENTITY(1,1) NOT NULL,
	[siparisadi] [varchar](50) NULL,
	[siparisadres] [varchar](50) NULL,
	[siparisadet] [int] NULL,
	[siparisfiyat] [int] NULL,
	[urunno] [int] NULL,
	[tutar] [int] NULL,
 CONSTRAINT [PK_siparis] PRIMARY KEY CLUSTERED 
(
	[siparisno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urunler]    Script Date: 31.5.2022 19:04:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urunler](
	[urunno] [int] IDENTITY(1,1) NOT NULL,
	[urunadi] [varchar](50) NULL,
	[urunfiyat] [int] NULL,
	[kullanimtarihi] [varchar](50) NULL,
	[uretimtarihi] [varchar](50) NULL,
	[saticino] [int] NULL,
 CONSTRAINT [PK_urunler] PRIMARY KEY CLUSTERED 
(
	[urunno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[kullanicigiris] ON 

INSERT [dbo].[kullanicigiris] ([kullanicino], [kullaniciad], [kullanicisifre], [email], [telefon]) VALUES (1, N'Rükna', N'1234', N'rukna@gmail.com', N'5365959659')
INSERT [dbo].[kullanicigiris] ([kullanicino], [kullaniciad], [kullanicisifre], [email], [telefon]) VALUES (2, N'Nihal öz', N'1234', N'nihoş@gmail.com', N'(055) 224-9782')
INSERT [dbo].[kullanicigiris] ([kullanicino], [kullaniciad], [kullanicisifre], [email], [telefon]) VALUES (3, N'Rabia', N'1313', N'rabia@gmail.com', N'(532) 565-6598')
SET IDENTITY_INSERT [dbo].[kullanicigiris] OFF
GO
SET IDENTITY_INSERT [dbo].[musteriler] ON 

INSERT [dbo].[musteriler] ([musterino], [musteriadsoyad], [musteritelefon], [siparisno]) VALUES (1, N'sibel sönmez', N'(562) 659-6598', 3)
INSERT [dbo].[musteriler] ([musterino], [musteriadsoyad], [musteritelefon], [siparisno]) VALUES (3, N'ayşe şener', N'(562) 659-6598', 2)
INSERT [dbo].[musteriler] ([musterino], [musteriadsoyad], [musteritelefon], [siparisno]) VALUES (9, N'sibel korkmaz', N'(562) 659-6598', 2)
INSERT [dbo].[musteriler] ([musterino], [musteriadsoyad], [musteritelefon], [siparisno]) VALUES (10, N'kübra şimşek', N'(562) 659-6598', 2)
INSERT [dbo].[musteriler] ([musterino], [musteriadsoyad], [musteritelefon], [siparisno]) VALUES (11, N'ali kaya', N'(562) 659-6598', 2)
INSERT [dbo].[musteriler] ([musterino], [musteriadsoyad], [musteritelefon], [siparisno]) VALUES (12, N'sibel kaya', N'(562) 659-6598', 2)
INSERT [dbo].[musteriler] ([musterino], [musteriadsoyad], [musteritelefon], [siparisno]) VALUES (14, N'gamze kaya', N'(562) 659-6598', 3)
SET IDENTITY_INSERT [dbo].[musteriler] OFF
GO
SET IDENTITY_INSERT [dbo].[satici] ON 

INSERT [dbo].[satici] ([saticino], [saticiadsoyad], [saticiadres], [saticiil], [saticiilce]) VALUES (1, N'ayşe şen', N'maltepe', N'istanbul', N'maltepe')
INSERT [dbo].[satici] ([saticino], [saticiadsoyad], [saticiadres], [saticiil], [saticiilce]) VALUES (2, N'kübra şimşek', N'ümraniye', N'zonguldak', N'devrek')
INSERT [dbo].[satici] ([saticino], [saticiadsoyad], [saticiadres], [saticiil], [saticiilce]) VALUES (3, N'şevval öz', N'sancaktepe', N'istanbul', N'sancaktepe')
INSERT [dbo].[satici] ([saticino], [saticiadsoyad], [saticiadres], [saticiil], [saticiilce]) VALUES (4, N'pembe gül', N'kadıköy', N'ankara', N'kadıköy')
SET IDENTITY_INSERT [dbo].[satici] OFF
GO
SET IDENTITY_INSERT [dbo].[siparis] ON 

INSERT [dbo].[siparis] ([siparisno], [siparisadi], [siparisadres], [siparisadet], [siparisfiyat], [urunno], [tutar]) VALUES (1, N'pasta', N'sancaktepe', 1, 100, 1, 100)
INSERT [dbo].[siparis] ([siparisno], [siparisadi], [siparisadres], [siparisadet], [siparisfiyat], [urunno], [tutar]) VALUES (2, N'kurabiye', N'ümraniye', 2, 75, 2, 150)
INSERT [dbo].[siparis] ([siparisno], [siparisadi], [siparisadres], [siparisadet], [siparisfiyat], [urunno], [tutar]) VALUES (3, N'makaron', N'kadıköy', 3, 150, 3, 450)
INSERT [dbo].[siparis] ([siparisno], [siparisadi], [siparisadres], [siparisadet], [siparisfiyat], [urunno], [tutar]) VALUES (4, N'ay çöreği', N'maltepe', 4, 30, 5, 150)
INSERT [dbo].[siparis] ([siparisno], [siparisadi], [siparisadres], [siparisadet], [siparisfiyat], [urunno], [tutar]) VALUES (5, N'çikolata', N'göztepe', 2, 200, 4, 800)
INSERT [dbo].[siparis] ([siparisno], [siparisadi], [siparisadres], [siparisadet], [siparisfiyat], [urunno], [tutar]) VALUES (6, N'pasta', N'göztepe', 5, 170, 1, 170)
INSERT [dbo].[siparis] ([siparisno], [siparisadi], [siparisadres], [siparisadet], [siparisfiyat], [urunno], [tutar]) VALUES (7, N'makaron', N'maltepe', 2, 50, 3, 150)
INSERT [dbo].[siparis] ([siparisno], [siparisadi], [siparisadres], [siparisadet], [siparisfiyat], [urunno], [tutar]) VALUES (8, N'çikolata', N'ümraniye', 1, 75, 1, 75)
INSERT [dbo].[siparis] ([siparisno], [siparisadi], [siparisadres], [siparisadet], [siparisfiyat], [urunno], [tutar]) VALUES (9, N'ay çöreği', N'sancaktepe', 3, 80, 1, 80)
SET IDENTITY_INSERT [dbo].[siparis] OFF
GO
SET IDENTITY_INSERT [dbo].[urunler] ON 

INSERT [dbo].[urunler] ([urunno], [urunadi], [urunfiyat], [kullanimtarihi], [uretimtarihi], [saticino]) VALUES (1, N'pasta', 200, N'02.02.2022', N'01.02.2022', 1)
INSERT [dbo].[urunler] ([urunno], [urunadi], [urunfiyat], [kullanimtarihi], [uretimtarihi], [saticino]) VALUES (2, N'kurabiye', 50, N'01.01.2022', N'31.12.2022', 2)
INSERT [dbo].[urunler] ([urunno], [urunadi], [urunfiyat], [kullanimtarihi], [uretimtarihi], [saticino]) VALUES (3, N'makaron', 15, N'02.02.2022', N'01.01.2022', 2)
INSERT [dbo].[urunler] ([urunno], [urunadi], [urunfiyat], [kullanimtarihi], [uretimtarihi], [saticino]) VALUES (4, N'çikolata', 60, N'05.06.2021', N'05.04.2021', 1)
INSERT [dbo].[urunler] ([urunno], [urunadi], [urunfiyat], [kullanimtarihi], [uretimtarihi], [saticino]) VALUES (5, N'ay çöreği', 15, N'07.08.2021', N'05.07.2021', 2)
INSERT [dbo].[urunler] ([urunno], [urunadi], [urunfiyat], [kullanimtarihi], [uretimtarihi], [saticino]) VALUES (7, N'kurabiye', 65, N'01.01.2022', N'01.01.2022', 2)
SET IDENTITY_INSERT [dbo].[urunler] OFF
GO
ALTER TABLE [dbo].[musteriler]  WITH CHECK ADD  CONSTRAINT [FK_musteriler_siparis] FOREIGN KEY([siparisno])
REFERENCES [dbo].[siparis] ([siparisno])
GO
ALTER TABLE [dbo].[musteriler] CHECK CONSTRAINT [FK_musteriler_siparis]
GO
ALTER TABLE [dbo].[siparis]  WITH CHECK ADD  CONSTRAINT [FK_siparis_urunler] FOREIGN KEY([urunno])
REFERENCES [dbo].[urunler] ([urunno])
GO
ALTER TABLE [dbo].[siparis] CHECK CONSTRAINT [FK_siparis_urunler]
GO
ALTER TABLE [dbo].[urunler]  WITH CHECK ADD  CONSTRAINT [FK_urunler_satici] FOREIGN KEY([saticino])
REFERENCES [dbo].[satici] ([saticino])
GO
ALTER TABLE [dbo].[urunler] CHECK CONSTRAINT [FK_urunler_satici]
GO
USE [master]
GO
ALTER DATABASE [Pastane] SET  READ_WRITE 
GO
