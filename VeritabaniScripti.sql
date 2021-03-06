USE [master]
GO
/****** Object:  Database [cafeDB]    Script Date: 3.03.2019 22:04:40 ******/
CREATE DATABASE [cafeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cafeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\cafeDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cafeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\cafeDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [cafeDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cafeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cafeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cafeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cafeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cafeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cafeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [cafeDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cafeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cafeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cafeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cafeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cafeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cafeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cafeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cafeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cafeDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cafeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cafeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cafeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cafeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cafeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cafeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cafeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cafeDB] SET RECOVERY FULL 
GO
ALTER DATABASE [cafeDB] SET  MULTI_USER 
GO
ALTER DATABASE [cafeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cafeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cafeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cafeDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cafeDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'cafeDB', N'ON'
GO
ALTER DATABASE [cafeDB] SET QUERY_STORE = OFF
GO
USE [cafeDB]
GO
/****** Object:  Table [dbo].[Bilgisayarlar]    Script Date: 3.03.2019 22:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilgisayarlar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PC_Adi] [nvarchar](20) NULL,
	[IP_Adresi] [char](15) NULL,
	[Baglanti_Saati] [char](5) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oturumlar]    Script Date: 3.03.2019 22:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oturumlar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Bilgisayar_ID] [int] NULL,
	[Kapanma_Saati] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_BilgisayarBaglan]    Script Date: 3.03.2019 22:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_BilgisayarBaglan](
@PC_Adi nvarchar(20),
@IP_Adresi char(15)
)
as
begin
if not exists (select PC_Adi from Bilgisayarlar where PC_Adi = @PC_Adi) begin
	declare @Baglanti_Saati char(5)
	set @Baglanti_Saati = (SELECT CONVERT(VARCHAR(5),GETDATE(),108))

	insert into Bilgisayarlar(PC_Adi,IP_Adresi,Baglanti_Saati,Durum)
	values(@PC_Adi,@IP_Adresi,@Baglanti_Saati,'0') 
end
else begin
	declare @Baglanti_Saati2 char(5)
	set @Baglanti_Saati2 = (SELECT CONVERT(VARCHAR(5),GETDATE(),108))
	update Bilgisayarlar set IP_Adresi = @IP_Adresi, Baglanti_Saati = @Baglanti_Saati2 where PC_Adi = @PC_Adi
end

select 1 as Durum
end
GO
/****** Object:  StoredProcedure [dbo].[sp_KapanmaSaati]    Script Date: 3.03.2019 22:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_KapanmaSaati](
@PC_Adi nvarchar(20)
)
as
begin
declare @Bilgisayar_ID int
set @Bilgisayar_ID = (Select ID from Bilgisayarlar where PC_Adi = @PC_Adi)
declare @Kapanma_Saati char(5)
set @Kapanma_Saati = (Select Kapanma_Saati from Oturumlar where Bilgisayar_ID = @Bilgisayar_ID)
	if(@Kapanma_Saati is not null)
		select @Kapanma_Saati as Durum
	else begin
		select 1 as Durum
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_MasaDegistir]    Script Date: 3.03.2019 22:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_MasaDegistir](
@PC_Adi nvarchar(20),
@AktarilacakMasaAdi nvarchar(20)
)
as
begin
	declare @Bilgisayar_ID int
	set @Bilgisayar_ID = (select ID from Bilgisayarlar where PC_Adi = @PC_Adi)

	declare @kapanma_Saati char(5)
	set @kapanma_Saati = (select Kapanma_Saati from Oturumlar where Bilgisayar_ID = @Bilgisayar_ID)

	update Bilgisayarlar set Durum = 0 where ID = @Bilgisayar_ID
	delete Oturumlar where Bilgisayar_ID = @Bilgisayar_ID

	declare @Masa_ID int
	set @Masa_ID = (select ID from Bilgisayarlar where PC_Adi = @AktarilacakMasaAdi)

	insert into Oturumlar(Bilgisayar_ID,Kapanma_Saati) values(@Masa_ID,@kapanma_Saati)
	update Bilgisayarlar set Durum = 1 where PC_Adi =  @AktarilacakMasaAdi

	select 1 as Durum

end
GO
/****** Object:  StoredProcedure [dbo].[sp_OnlinePCler]    Script Date: 3.03.2019 22:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_OnlinePCler]
as
begin
	select PC_Adi, Durum from Bilgisayarlar
end
GO
/****** Object:  StoredProcedure [dbo].[sp_OturumAc]    Script Date: 3.03.2019 22:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_OturumAc](
@PC_Adi nvarchar(20),
@SureDK smallint
)
as
begin
	declare @Bilgisayar_ID int
	set @Bilgisayar_ID = (select ID from Bilgisayarlar where PC_Adi = @PC_Adi)

	declare @Baglanti_Saati char(5)
	set @Baglanti_Saati = (select Baglanti_Saati from Bilgisayarlar where ID = @Bilgisayar_ID)

	declare @Kapanma_Saati time
	set @Kapanma_Saati = (Select DATEADD(MINUTE,@SureDK,(SELECT CONVERT(VARCHAR(5),GETDATE(),108))))

	insert into Oturumlar(Bilgisayar_ID,Kapanma_Saati)
	values(@Bilgisayar_ID,@Kapanma_Saati)

	update Bilgisayarlar set Durum = 1 where ID = @Bilgisayar_ID
	select 1 as Durum
end
GO
/****** Object:  StoredProcedure [dbo].[sp_OturumBilgileri]    Script Date: 3.03.2019 22:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_OturumBilgileri](
@PC_Adi nvarchar(20)
)
as
begin
	select B.IP_Adresi,B.Baglanti_Saati,O.Kapanma_Saati from Oturumlar O inner join Bilgisayarlar B on O.Bilgisayar_ID = B.ID Where PC_Adi = @PC_Adi
end
GO
USE [master]
GO
ALTER DATABASE [cafeDB] SET  READ_WRITE 
GO
