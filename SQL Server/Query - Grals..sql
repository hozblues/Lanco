


SELECT *
  FROM UserProfile;

SELECT *
  FROM Roles;

SELECT *
  FROM UserRole_Relationship;


--DELETE FROM UserRole_Relationship WHERE Relationship_ID = 3;

EXEC SP_GetAllUsers;


--DELETE FROM UserProfile WHERE UserID = 4;

-- UPDATE UserRole_Relationship SET CreatedDate = GETDATE();


EXEC SP_GetRoles;


SELECT *
  FROM F_Routes


