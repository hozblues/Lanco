USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_GetAllUsers' AND type = 'P' )
	DROP PROCEDURE SP_GetAllUsers;
GO

CREATE PROCEDURE SP_GetAllUsers
AS
	SELECT up.UserID,
	       up.UserFirstName,
		   up.UserLastName,
		   up.UserEmail,
		   up.IsActive,
		   ISNULL(ur.RoleID,0) AS RoleID,
		   ISNULL(r.RoleName,'') AS RoleName,
		   ur.Relationship_ID
      FROM UserProfile up
 LEFT JOIN UserRole_Relationship ur
        ON ur.UserID = up.UserID
 LEFT JOIN Roles r
        ON r.RoleID = ur.RoleID;
