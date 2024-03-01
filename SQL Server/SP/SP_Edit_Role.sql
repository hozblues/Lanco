USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_Role' AND type = 'P' )
	DROP PROCEDURE SP_Edit_Role;
GO

CREATE PROCEDURE SP_Edit_Role(
	@RoleID INT,
	@RoleName VARCHAR(50),
	@IsActive BIT
)
AS
BEGIN
	UPDATE Roles
	   SET RoleName = @RoleName,
	       IsActive = @IsActive
	 WHERE RoleID = @RoleID;
END;
