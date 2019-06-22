USE [master]
GO
/****** Object:  Database [EvaluacionDesempeno]    Script Date: 21/6/2019 11:34:17 p. m. ******/
CREATE DATABASE [EvaluacionDesempeno]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EvaluacionDesempeno', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EvaluacionDesempeno.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EvaluacionDesempeno_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EvaluacionDesempeno_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EvaluacionDesempeno] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EvaluacionDesempeno].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EvaluacionDesempeno] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET ARITHABORT OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EvaluacionDesempeno] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EvaluacionDesempeno] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EvaluacionDesempeno] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EvaluacionDesempeno] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EvaluacionDesempeno] SET  MULTI_USER 
GO
ALTER DATABASE [EvaluacionDesempeno] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EvaluacionDesempeno] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EvaluacionDesempeno] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EvaluacionDesempeno] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EvaluacionDesempeno] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EvaluacionDesempeno] SET QUERY_STORE = OFF
GO
USE [EvaluacionDesempeno]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[codigo_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empleado] [varchar](80) NOT NULL,
	[apellido_empleado] [varchar](80) NOT NULL,
	[cedula_empleado] [varchar](12) NULL,
	[estadus_empleado] [varchar](2) NULL,
	[fecha_empleado] [datetime] NULL,
	[usuario] [varchar](50) NOT NULL,
	[passwor] [varchar](35) NOT NULL,
	[encargado_empleado] [bit] NULL,
	[codigo_Departamento] [int] NULL,
	[ManejarDepartamento] [bit] NULL,
	[ManejarEmpleado] [bit] NULL,
	[ManejarPerfil] [bit] NULL,
	[ManejarClasificacion] [bit] NULL,
	[ManejarCompetencia] [bit] NULL,
	[ManejarEvaluacion] [bit] NULL,
	[ManejarFrecuencia] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factores]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factores](
	[id_factor] [int] IDENTITY(1,1) NOT NULL,
	[nombre_factor] [varchar](100) NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_factores] PRIMARY KEY CLUSTERED 
(
	[id_factor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factores_descripcion]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factores_descripcion](
	[id_factor_descripcion] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](500) NOT NULL,
	[factor_id] [int] NOT NULL,
 CONSTRAINT [PK_factores_descripcion] PRIMARY KEY CLUSTERED 
(
	[id_factor_descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[posiciones]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posiciones](
	[id_posicion] [int] IDENTITY(1,1) NOT NULL,
	[nombre_posicion] [varchar](100) NOT NULL,
	[estado] [bit] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[factores] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[posiciones] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[factores_descripcion]  WITH CHECK ADD  CONSTRAINT [FK_factores_descripcion_factor_id] FOREIGN KEY([factor_id])
REFERENCES [dbo].[factores] ([id_factor])
GO
ALTER TABLE [dbo].[factores_descripcion] CHECK CONSTRAINT [FK_factores_descripcion_factor_id]
GO
/****** Object:  StoredProcedure [dbo].[EDITAR_FACTOR]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EDITAR_FACTOR](
    @id int,
    @nombre varchar(100)
)
as
UPDATE factores
	SET nombre_factor = @nombre
WHERE
  id_factor = @id;
GO
/****** Object:  StoredProcedure [dbo].[EDITAR_FACTOR_DESCRIPCION]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EDITAR_FACTOR_DESCRIPCION](
    @id int,
    @descripcion varchar(500),
    @factor int
)
as
UPDATE factores_descripcion
SET 
    descripcion = @descripcion,
    factor_id = @factor  
WHERE
  id_factor_descripcion = @id;
GO
/****** Object:  StoredProcedure [dbo].[EDITAR_POSICION]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EDITAR_POSICION](
  @id int,
  @nombre varchar(100)
) as
UPDATE posiciones
	SET nombre_posicion = @nombre
WHERE
  id_posicion = @id;
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_FACTOR]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERTAR_FACTOR](@nombre varchar(100))
AS
INSERT INTO factores (nombre_factor)
VALUES(@nombre);

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_FACTOR_DESCRIPCION]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_FACTOR_DESCRIPCION](
    @descripcion varchar(500),
    @factor int
)
AS
INSERT INTO factores_descripcion(
    descripcion,
    factor_id
)
VALUES(
    @descripcion,
    @factor
);

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_POSICION]    Script Date: 21/6/2019 11:34:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERTAR_POSICION](
  @nombre varchar(100),
  @estado bit
) as
INSERT INTO posiciones(nombre_posicion, estado)
VALUES(
  @nombre,
  @estado
);

GO
USE [master]
GO
ALTER DATABASE [EvaluacionDesempeno] SET  READ_WRITE 
GO
