USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_Currency' AND type = 'P' )
	DROP PROCEDURE SP_Get_Currency;
GO

CREATE PROCEDURE SP_Get_Currency
AS
BEGIN
	SELECT CurrencyID,
	       CurrencyCode,
		   CurrencyName,
		   IsActive
	  FROM Lu_Currency
END;
