USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Cancel_Role' AND type = 'P' )
	DROP PROCEDURE SP_Cancel_Role;
GO

CREATE PROCEDURE SP_Cancel_Role(
	@RoleID INT,
	@IsActive BIT
)
AS
BEGIN
	UPDATE Roles
	   SET IsActive = @IsActive
	 WHERE RoleID = @RoleID;
END;