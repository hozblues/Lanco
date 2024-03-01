USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_FFiles' AND type = 'P' )
	DROP PROCEDURE SP_Get_FFiles;
GO

CREATE PROCEDURE SP_Get_FFiles
AS
BEGIN
    SELECT ff.Files_ID,
	       ff.CustomerID,
		   lc.CustomerName,
		   ff.NumberFile,
		   ff.ConstructionSiteID,
		   lcs.ConstructionSiteName
	  FROM F_Files ff
 LEFT JOIN Lu_Customers lc
        ON lc.CustomerID = ff.CustomerID
 LEFT JOIN Lu_ConstructionSite lcs
        ON lcs.ConstructionSiteID = ff.ConstructionSiteID
END;
