USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_Routes' AND type = 'P' )
	DROP PROCEDURE SP_Edit_Routes;
GO

CREATE PROCEDURE SP_Edit_Routes(
	@RouteID INT,
	@RouteName VARCHAR(100),
	@IsActive BIT
)
AS
BEGIN
	UPDATE Lu_Routes
	   SET RouteName = @RouteName,
	       IsActive = @IsActive
	 WHERE RouteID = @RouteID;
END;
