
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPendientes](
	[IdPendiente] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [varchar](50) NULL,
	[FechaCreacion] [datetime] NULL,
	[FechaActualizacion] [datetime] NULL,
	[IdUsuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsuarios]    Script Date: 02/10/2019 11:17:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NULL,
	[Contrasena] [varchar](100) NULL,
	[NombreCompleto] [varchar](100) NULL,
	[Email] [varchar](50) NULL,
	[FechaCreacion] [datetime] NULL,
	[FechaActualizacion] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spCrearPendiente]    Script Date: 02/10/2019 11:17:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCrearPendiente]
@Descripcion varchar(100),

@IdUsuario int
	
AS
BEGIN
	INSERT INTO [dbo].[tblPendientes]
           ([Descripcion]
           ,[Estatus]
           ,[FechaCreacion]
           ,[FechaActualizacion]
           ,[IdUsuario])
     VALUES
           (@Descripcion,
		   'Pendiente',
		   CURRENT_TIMESTAMP,
		   CURRENT_TIMESTAMP,
		   @IdUsuario)
END
GO
/****** Object:  StoredProcedure [dbo].[spEliminarPendiente]    Script Date: 02/10/2019 11:17:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spEliminarPendiente]
@IdPendiente int
	
AS
BEGIN
	DELETE FROM tblPendientes WHERE IdPendiente=@IdPendiente
END
GO
/****** Object:  StoredProcedure [dbo].[spObtenerPendientes]    Script Date: 02/10/2019 11:17:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spObtenerPendientes]

AS
BEGIN

	SELECT [IdPendiente]
      ,[Descripcion]
      ,[Estatus]
      ,[FechaCreacion]
      ,[FechaActualizacion]
      ,[IdUsuario]
  FROM [DB_A4570D_TestFamsa].[dbo].[tblPendientes]


END
GO
/****** Object:  StoredProcedure [dbo].[spObtenerPendientesUsuario]    Script Date: 02/10/2019 11:17:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spObtenerPendientesUsuario]
	-- Add the parameters for the stored procedure here
@IdUsuario int
AS
BEGIN

	SELECT [IdPendiente]
      ,[Descripcion]
      ,[Estatus]
      ,[FechaCreacion]
      ,[FechaActualizacion]
      ,[IdUsuario]
  FROM [DB_A4570D_TestFamsa].[dbo].[tblPendientes]
  WHERE IdUsuario=@IdUsuario

END
GO
USE [master]
GO
ALTER DATABASE [DB_A4570D_TestFamsa] SET  READ_WRITE 
GO
