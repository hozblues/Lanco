USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_FFiles' AND type = 'P' )
	DROP PROCEDURE SP_Add_FFiles;
GO

CREATE PROCEDURE SP_Add_FFiles(
	@CustomerID INT,
	@NumberFile VARCHAR(50),
	@ConstructionSiteID INT
)
AS
BEGIN
	 INSERT INTO F_Files(CustomerID, NumberFile, ConstructionSiteID)
	 VALUES(@CustomerID, @NumberFile, @ConstructionSiteID)
END;