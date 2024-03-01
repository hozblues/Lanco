USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_Banks' AND type = 'P' )
	DROP PROCEDURE SP_Get_Banks;
GO

CREATE PROCEDURE SP_Get_Banks
AS
BEGIN
	SELECT BankID,
	       BankName,
		   IsActive
	  FROM Lu_Banks
END;
