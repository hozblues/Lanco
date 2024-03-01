USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_Routes' AND type = 'P' )
	DROP PROCEDURE SP_Add_Routes;
GO

CREATE PROCEDURE SP_Add_Routes(
	@RouteName VARCHAR(100),
	@IsActive BIT,
	@CreatedDate DATETIME
)
AS
BEGIN
	INSERT INTO Lu_Routes(RouteName, IsActive, CreatedDate)
	VALUES(@RouteName, @IsActive, @CreatedDate)
END;
