USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_User' AND type = 'P' )
	DROP PROCEDURE SP_Edit_User;
GO

CREATE PROCEDURE SP_Edit_User(
    @UserID INT,
	@UserFirstName VARCHAR(100),
	@UserLastName VARCHAR(100),
	@UserEmail VARCHAR(200),
	@IsActive BIT,
	@CreatedDate DATETIME,
	@RoleID INT,
	@RelationshipID INT
)
AS
BEGIN
	UPDATE UserProfile
	   SET UserFirstName = @UserFirstName,
	       UserLastName = @UserLastName,
		   UserEmail = @UserEmail,
		   IsActive = @IsActive,
		   CreatedDate = @CreatedDate
	 WHERE UserID = @UserID;

	 UPDATE UserRole_Relationship
	    SET RoleID = @RoleID
	  WHERE Relationship_ID = @RelationshipID
	    AND UserID = @UserID;
END;
