USE [EvaluacionDesempeno]
GO

/****** Object:  Table [dbo].[empleado]    Script Date: 6/17/2019 10:09:11 PM ******/
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

INSERT INTO [dbo].[empleado](
  nombre_empleado,
  apellido_empleado,
  cedula_empleado,
  estadus_empleado,
  usuario,
  passwor,
  ManejarDepartamento,
  ManejarEmpleado,
  ManejarPerfil,
  ManejarClasificacion,
  ManejarCompetencia,
  ManejarEvaluacion,
  ManejarFrecuencia)

VALUES(
  ariel,
  Jimenez,
  1,
  1,
  ariel,
  1,
  1,
  1,
  1,
  1,
  1,
  1,
  1
)

GO
