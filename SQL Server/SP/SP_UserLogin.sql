USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_UserLogin' AND type = 'P' )
	DROP PROCEDURE SP_UserLogin;
GO

CREATE PROCEDURE SP_UserLogin(
	@UserID INT
)
AS
BEGIN
    SELECT up.UserID,
	       up.UserFirstName,
		   up.UserLastName,
		   up.UserEmail,
		   up.IsActive,
		   ur.RoleID,
		   r.RoleName
      FROM UserProfile up
INNER JOIN UserRole_Relationship ur
        ON ur.UserID = up.UserID
INNER JOIN Roles r
        ON r.RoleID = ur.RoleID
	 WHERE up.UserID = @UserID
END;