USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_FPaymentsSAE' AND type = 'P' )
	DROP PROCEDURE SP_Get_FPaymentsSAE;
GO

CREATE PROCEDURE SP_Get_FPaymentsSAE
AS
BEGIN
    SELECT fps.PaymentSAE_ID,
	       fps.CustomerID,
		   lc.CustomerName,
		   fps.BankID,
		   lb.BankName,
		   fps.PaymentDate,
		   fps.PaymentAmount,
		   fps.CurrencyID,
		   lcu.CurrencyCode,
		   lcu.CurrencyName,
		   fps.RouteID,
		   lr.RouteName,
		   fps.ResponsibleID,
		   lres.ResponsibleName
      FROM F_PaymentsSAE fps
 LEFT JOIN Lu_Customers lc
        ON lc.CustomerID = fps.CustomerID
 LEFT JOIN Lu_Banks lb
        ON lb.BankID = fps.BankID
 LEFT JOIN Lu_Currency lcu
        ON lcu.CurrencyID = fps.CurrencyID
 LEFT JOIN Lu_Routes lr
        ON lr.RouteID = fps.RouteID
 LEFT JOIN Lu_Responsible lres
        ON lres.ResponsibleID = fps.ResponsibleID
END;
