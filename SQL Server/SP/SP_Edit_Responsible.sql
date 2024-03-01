USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_Responsible' AND type = 'P' )
	DROP PROCEDURE SP_Edit_Responsible;
GO

CREATE PROCEDURE SP_Edit_Responsible(
	@ResponsibleID INT,
	@ResponsibleName VARCHAR(100),
	@IsActive BIT
)
AS
BEGIN
	UPDATE Lu_Responsible
	   SET ResponsibleName = @ResponsibleName,
	       IsActive = @IsActive
	 WHERE ResponsibleID = @ResponsibleID;
END;
