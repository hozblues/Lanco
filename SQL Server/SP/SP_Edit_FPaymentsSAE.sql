USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_FPaymentsSAE' AND type = 'P' )
	DROP PROCEDURE SP_Edit_FPaymentsSAE;
GO

CREATE PROCEDURE SP_Edit_FPaymentsSAE(
    @PaymentSAE_ID INT,
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
	  UPDATE F_PaymentsSAE
	     SET CustomerID = @CustomerID,
			 BankID = @BankID,
			 PaymentDate = @PaymentDate,
			 PaymentAmount = @PaymentAmount,
			 CurrencyID = @CurrencyID,
			 RouteID = @RouteID,
			 ResponsibleID = @ResponsibleID
	   WHERE PaymentSAE_ID = @PaymentSAE_ID
END;