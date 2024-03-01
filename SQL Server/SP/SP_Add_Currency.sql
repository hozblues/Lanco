USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_Currency' AND type = 'P' )
	DROP PROCEDURE SP_Add_Currency;
GO

CREATE PROCEDURE SP_Add_Currency(
    @CurrencyCode CHAR(3),
	@CurrencyName VARCHAR(150),
	@IsActive BIT,
	@CreatedDate DATETIME
)
AS
BEGIN
	INSERT INTO Lu_Currency(CurrencyCode, CurrencyName, IsActive, CreatedDate)
	VALUES(@CurrencyCode, @CurrencyName, @IsActive, @CreatedDate)
END;
