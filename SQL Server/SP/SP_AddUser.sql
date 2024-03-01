USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_User' AND type = 'P' )
	DROP PROCEDURE SP_Add_User;
GO

CREATE PROCEDURE SP_Add_User(
	@UserFirstName VARCHAR(100),
	@UserLastName VARCHAR(100),
	@UserEmail VARCHAR(200),
	@UserPassword VARCHAR(900),
	@IsActive BIT,
	@CreatedDate DATETIME,
	@Response INT OUTPUT
)
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM UserProfile WHERE UserEmail = @UserEmail))
	BEGIN
		INSERT INTO UserProfile(UserFirstName, UserLastName, UserEmail, UserPassword, IsActive, CreatedDate)
		VALUES(@UserFirstName, @UserLastName, @UserEmail, @UserPassword, @IsActive, @CreatedDate)
		
		SET @Response = @@IDENTITY
	END
	ELSE
	BEGIN
		SET @Response = 0
	END
END;
