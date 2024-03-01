USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_ConstructionSite' AND type = 'P' )
	DROP PROCEDURE SP_Edit_ConstructionSite;
GO

CREATE PROCEDURE SP_Edit_ConstructionSite(
	@ConstructionSiteID INT,
	@ConstructionSiteName VARCHAR(150),
	@IsActive BIT
)
AS
BEGIN
	UPDATE Lu_ConstructionSite
	   SET ConstructionSiteName = @ConstructionSiteName,
	       IsActive = @IsActive
	 WHERE ConstructionSiteID = @ConstructionSiteID;
END;
