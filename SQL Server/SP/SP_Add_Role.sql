USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_Role' AND type = 'P' )
	DROP PROCEDURE SP_Add_Role;
GO

CREATE PROCEDURE SP_Add_Role(
	@RoleName VARCHAR(50),
	@IsActive BIT,
	@CreatedDate DATETIME
)
AS
BEGIN
	INSERT INTO Roles(RoleName, IsActive, CreatedDate)
	VALUES(@RoleName, @IsActive, @CreatedDate)
END;
