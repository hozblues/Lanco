USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Cancel_User' AND type = 'P' )
	DROP PROCEDURE SP_Cancel_User;
GO

CREATE PROCEDURE SP_Cancel_User(
    @UserID INT,
	@IsActive BIT

)
AS
BEGIN
	UPDATE UserProfile
	   SET IsActive = @IsActive
	 WHERE UserID = @UserID;
END;
