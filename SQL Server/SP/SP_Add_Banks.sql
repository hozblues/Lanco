USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_Banks' AND type = 'P' )
	DROP PROCEDURE SP_Add_Banks;
GO

CREATE PROCEDURE SP_Add_Banks(
	@BankName VARCHAR(150),
	@IsActive BIT,
	@CreatedDate DATETIME
)
AS
BEGIN
	INSERT INTO Lu_Banks(BankName, IsActive, CreatedDate)
	VALUES(@BankName, @IsActive, @CreatedDate)
END;
