USE [EvaluacionDesempeno]
GO

ALTER TABLE [dbo].[factores_descripcion] DROP CONSTRAINT [FK_factores_descripcion_factor_id]
GO

/****** Object:  Table [dbo].[factores_descripcion]    Script Date: 21/6/2019 10:01:36 p. m. ******/
DROP TABLE [dbo].[factores_descripcion]
GO

/****** Object:  Table [dbo].[factores_descripcion]    Script Date: 21/6/2019 10:01:36 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[factores_descripcion]
(
    [id_factor_descripcion] [int] IDENTITY(1,1) NOT NULL,
    [descripcion] [varchar](500) NOT NULL,
    [factor_id] [int] NOT NULL,
    CONSTRAINT [PK_factores_descripcion] PRIMARY KEY CLUSTERED
(
	[id_factor_descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[factores_descripcion]  WITH CHECK ADD  CONSTRAINT [FK_factores_descripcion_factor_id] FOREIGN KEY([factor_id])
REFERENCES [dbo].[factores] ([id_factor])
GO

ALTER TABLE [dbo].[factores_descripcion] CHECK CONSTRAINT [FK_factores_descripcion_factor_id]
GO



/*
 * SP
 */

-- insert
use EvaluacionDesempeno
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

-- Edit
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

use EvaluacionDesempeno
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
