USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_ValidateAccess' AND type = 'P' )
	DROP PROCEDURE SP_ValidateAccess;
GO

CREATE PROCEDURE SP_ValidateAccess(
	@UserEmail VARCHAR(100),
	@UserPassword VARCHAR(500)
)
AS
BEGIN
	IF(EXISTS(SELECT * FROM UserProfile WHERE UserEmail = @UserEmail AND UserPassword = @UserPassword AND IsActive = 1))
		SELECT UserID FROM UserProfile WHERE UserEmail = @UserEmail AND UserPassword = @UserPassword
	ELSE
		SELECT 0
END;