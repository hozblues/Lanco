USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_ConstructionSite' AND type = 'P' )
	DROP PROCEDURE SP_Add_ConstructionSite;
GO

CREATE PROCEDURE SP_Add_ConstructionSite(
	@ConstructionSiteName VARCHAR(150),
	@IsActive BIT,
	@CreatedDate DATETIME
)
AS
BEGIN
	INSERT INTO Lu_ConstructionSite(ConstructionSiteName, IsActive, CreatedDate)
	VALUES(@ConstructionSiteName, @IsActive, @CreatedDate)
END;
