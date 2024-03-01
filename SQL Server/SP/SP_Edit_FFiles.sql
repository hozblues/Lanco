USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_FFiles' AND type = 'P' )
	DROP PROCEDURE SP_Edit_FFiles;
GO

CREATE PROCEDURE SP_Edit_FFiles(
    @Files_ID INT,
	@CustomerID INT,
	@NumberFile VARCHAR(50),
	@ConstructionSiteID INT
)
AS
BEGIN
	  UPDATE F_Files
	     SET CustomerID = @CustomerID,
			 NumberFile = @NumberFile,
			 ConstructionSiteID = @ConstructionSiteID
	   WHERE Files_ID = @Files_ID
END;