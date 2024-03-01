USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_GetRoles' AND type = 'P' )
	DROP PROCEDURE SP_GetRoles;
GO

CREATE PROCEDURE SP_GetRoles
AS
SELECT RoleID,
       RoleName,
	   IsActive
  FROM Roles;
