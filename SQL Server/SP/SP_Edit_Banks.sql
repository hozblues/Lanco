USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_Banks' AND type = 'P' )
	DROP PROCEDURE SP_Edit_Banks;
GO

CREATE PROCEDURE SP_Edit_Banks(
	@BankID INT,
	@BankName VARCHAR(150),
	@IsActive BIT
)
AS
BEGIN
	UPDATE Lu_Banks
	   SET BankName = @BankName,
	       IsActive = @IsActive
	 WHERE BankID = @BankID;
END;
