USE [master]
GO
/****** Object:  Database [Condomínio]    Script Date: 25/10/2018 11:00:13 ******/
CREATE DATABASE [Condomínio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Condomínio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Condomínio.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Condomínio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Condomínio_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Condomínio] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Condomínio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Condomínio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Condomínio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Condomínio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Condomínio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Condomínio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Condomínio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Condomínio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Condomínio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Condomínio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Condomínio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Condomínio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Condomínio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Condomínio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Condomínio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Condomínio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Condomínio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Condomínio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Condomínio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Condomínio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Condomínio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Condomínio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Condomínio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Condomínio] SET RECOVERY FULL 
GO
ALTER DATABASE [Condomínio] SET  MULTI_USER 
GO
ALTER DATABASE [Condomínio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Condomínio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Condomínio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Condomínio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Condomínio] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Condomínio', N'ON'
GO
USE [Condomínio]
GO
/****** Object:  Table [dbo].[Administração]    Script Date: 25/10/2018 11:00:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administração](
	[Id] [int] NOT NULL,
	[Id_Condomínio] [int] NOT NULL,
	[Id_Login] [int] NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[CNPJ] [nchar](14) NOT NULL,
 CONSTRAINT [PK_Administração] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Id_Condomínio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Condomínio]    Script Date: 25/10/2018 11:00:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Condomínio](
	[Id] [int] NOT NULL,
	[Nome] [nvarchar](30) NOT NULL,
	[Rua] [nvarchar](20) NOT NULL,
	[Bairro] [nvarchar](20) NOT NULL,
	[Número] [nvarchar](5) NOT NULL,
	[Complemento] [nvarchar](50) NOT NULL,
	[CEP] [nchar](8) NOT NULL,
	[Qtd_Apartamentos] [int] NOT NULL,
	[Valor] [float] NOT NULL,
 CONSTRAINT [PK_Multa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 25/10/2018 11:00:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Id_Login] [int] NOT NULL,
	[Usuário] [nvarchar](16) NOT NULL,
	[Senha] [nvarchar](16) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[Id_Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Multa/Adicional]    Script Date: 25/10/2018 11:00:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Multa/Adicional](
	[Id_Multa_Adicional] [int] NOT NULL,
	[Id_Condomínio] [int] NOT NULL,
	[Valor] [float] NOT NULL,
 CONSTRAINT [PK_Condomínio] PRIMARY KEY CLUSTERED 
(
	[Id_Multa_Adicional] ASC,
	[Id_Condomínio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Síndico]    Script Date: 25/10/2018 11:00:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Síndico](
	[Id] [int] NOT NULL,
	[Id_Condomínio] [int] NOT NULL,
	[Id_Login] [int] NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[CPF] [nchar](11) NOT NULL,
 CONSTRAINT [PK_Síndico] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Id_Condomínio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Administração]  WITH CHECK ADD  CONSTRAINT [FK_Administração_Condomínio] FOREIGN KEY([Id_Condomínio])
REFERENCES [dbo].[Condomínio] ([Id])
GO
ALTER TABLE [dbo].[Administração] CHECK CONSTRAINT [FK_Administração_Condomínio]
GO
ALTER TABLE [dbo].[Administração]  WITH CHECK ADD  CONSTRAINT [FK_Administração_Login] FOREIGN KEY([Id_Login])
REFERENCES [dbo].[Login] ([Id_Login])
GO
ALTER TABLE [dbo].[Administração] CHECK CONSTRAINT [FK_Administração_Login]
GO
ALTER TABLE [dbo].[Multa/Adicional]  WITH CHECK ADD  CONSTRAINT [FK_Multa_Condomínio] FOREIGN KEY([Id_Condomínio])
REFERENCES [dbo].[Condomínio] ([Id])
GO
ALTER TABLE [dbo].[Multa/Adicional] CHECK CONSTRAINT [FK_Multa_Condomínio]
GO
ALTER TABLE [dbo].[Síndico]  WITH CHECK ADD  CONSTRAINT [FK_Síndico_Condomínio] FOREIGN KEY([Id_Condomínio])
REFERENCES [dbo].[Condomínio] ([Id])
GO
ALTER TABLE [dbo].[Síndico] CHECK CONSTRAINT [FK_Síndico_Condomínio]
GO
ALTER TABLE [dbo].[Síndico]  WITH CHECK ADD  CONSTRAINT [FK_Síndico_Login] FOREIGN KEY([Id_Login])
REFERENCES [dbo].[Login] ([Id_Login])
GO
ALTER TABLE [dbo].[Síndico] CHECK CONSTRAINT [FK_Síndico_Login]
GO
USE [master]
GO
ALTER DATABASE [Condomínio] SET  READ_WRITE 
GO
