USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_Responsible' AND type = 'P' )
	DROP PROCEDURE SP_Add_Responsible;
GO

CREATE PROCEDURE SP_Add_Responsible(
	@ResponsibleName VARCHAR(150),
	@IsActive BIT,
	@CreatedDate DATETIME
)
AS
BEGIN
	INSERT INTO Lu_Responsible(ResponsibleName, IsActive, CreatedDate)
	VALUES(@ResponsibleName, @IsActive, @CreatedDate)
END;
