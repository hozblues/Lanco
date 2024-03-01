USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_Customers' AND type = 'P' )
	DROP PROCEDURE SP_Edit_Customers;
GO

CREATE PROCEDURE SP_Edit_Customers(
	@CustomerID INT,
	@CustomerName VARCHAR(150),
	@IsActive BIT
)
AS
BEGIN
	UPDATE Lu_Customers
	   SET CustomerName = @CustomerName,
	       IsActive = @IsActive
	 WHERE CustomerID = @CustomerID;
END;
