use EvaluacionDesempeno
GO

CREATE TABLE [dbo].factores
(
    [id_factor] [int] IDENTITY NOT NULL,
    [nombre_factor] [varchar](100) NOT NULL,
    [estado] [bit] NULL DEFAULT 1,
) ON [PRIMARY]
GO

/* SP */

-- insert
use EvaluacionDesempeno
GO

ALTER PROCEDURE [dbo].[INSERTAR_FACTOR](@nombre varchar(100))
AS
INSERT INTO factores
    (nombre_factor)
VALUES(@nombre);

GO



-- Edit
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

use EvaluacionDesempeno
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
