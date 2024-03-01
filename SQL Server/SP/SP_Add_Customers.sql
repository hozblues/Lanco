USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_Customers' AND type = 'P' )
	DROP PROCEDURE SP_Add_Customers;
GO

CREATE PROCEDURE SP_Add_Customers(
	@CustomerName VARCHAR(150),
	@IsActive BIT,
	@CreatedDate DATETIME
)
AS
BEGIN
	INSERT INTO Lu_Customers(CustomerName, IsActive, CreatedDate)
	VALUES(@CustomerName, @IsActive, @CreatedDate)
END;
