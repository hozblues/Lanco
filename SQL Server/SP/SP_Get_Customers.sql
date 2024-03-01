USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_Customers' AND type = 'P' )
	DROP PROCEDURE SP_Get_Customers;
GO

CREATE PROCEDURE SP_Get_Customers
AS
BEGIN
	SELECT CustomerID,
	       CustomerName,
		   IsActive
	  FROM Lu_Customers
END;
