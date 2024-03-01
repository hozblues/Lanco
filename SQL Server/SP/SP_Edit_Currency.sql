USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_Currency' AND type = 'P' )
	DROP PROCEDURE SP_Edit_Currency;
GO

CREATE PROCEDURE SP_Edit_Currency(
	@CurrencyID INT,
	@CurrencyCode CHAR(3),
	@CurrencyName VARCHAR(150),
	@IsActive BIT
)
AS
BEGIN
	UPDATE Lu_Currency
	   SET CurrencyCode = @CurrencyCode,
	       CurrencyName = @CurrencyName,
	       IsActive = @IsActive
	 WHERE CurrencyID = @CurrencyID;
END;
