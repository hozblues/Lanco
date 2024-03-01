USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_FPaymentsSAE' AND type = 'P' )
	DROP PROCEDURE SP_Add_FPaymentsSAE;
GO

CREATE PROCEDURE SP_Add_FPaymentsSAE(
	@CustomerID INT,
	@BankID INT,
	@PaymentDate DATETIME,
	@PaymentAmount DECIMAL(18,2),
	@CurrencyID INT,
	@RouteID INT,
	@ResponsibleID INT
)
AS
BEGIN
	  INSERT INTO F_PaymentsSAE(CustomerID, BankID, PaymentDate, PaymentAmount, CurrencyID, RouteID, ResponsibleID)
	  VALUES(@CustomerID, @BankID, @PaymentDate, @PaymentAmount, @CurrencyID, @RouteID, @ResponsibleID)
END;