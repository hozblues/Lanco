USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_Routes' AND type = 'P' )
	DROP PROCEDURE SP_Get_Routes;
GO

CREATE PROCEDURE SP_Get_Routes
AS
BEGIN
	SELECT RouteID,
	       RouteName,
		   IsActive
	  FROM Lu_Routes
END;
