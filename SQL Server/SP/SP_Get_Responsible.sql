USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_Responsible' AND type = 'P' )
	DROP PROCEDURE SP_Get_Responsible;
GO

CREATE PROCEDURE SP_Get_Responsible
AS
BEGIN
	SELECT ResponsibleID,
	       ResponsibleName,
		   IsActive
	  FROM Lu_Responsible
END;
