USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_ConstructionSite' AND type = 'P' )
	DROP PROCEDURE SP_Get_ConstructionSite;
GO

CREATE PROCEDURE SP_Get_ConstructionSite
AS
BEGIN
	SELECT ConstructionSiteID,
		   ConstructionSiteName,
		   IsActive
	  FROM Lu_ConstructionSite
END;
