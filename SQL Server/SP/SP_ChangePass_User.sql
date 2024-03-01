USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_ChangePass_User' AND type = 'P' )
	DROP PROCEDURE SP_ChangePass_User;
GO

CREATE PROCEDURE SP_ChangePass_User(
    @UserID INT,
	@Password VARCHAR(900)

)
AS
BEGIN
	UPDATE UserProfile
	   SET UserPassword = @Password
	 WHERE UserID = @UserID;
END;
