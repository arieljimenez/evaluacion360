use EvaluacionDesempeno
GO

CREATE TABLE [dbo].posiciones(
	[id_posicion] [int] IDENTITY NOT NULL,
	[nombre_posicion] [varchar](100) NOT NULL,
	[estado] [bit] NULL DEFAULT 1,
) ON [PRIMARY]
GO

/* SP */

-- insert
use EvaluacionDesempeno
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



-- Edit
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

use EvaluacionDesempeno
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

