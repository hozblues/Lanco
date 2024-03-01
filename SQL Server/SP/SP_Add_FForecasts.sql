USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_FForecasts' AND type = 'P' )
	DROP PROCEDURE SP_Add_FForecasts;
GO

CREATE PROCEDURE SP_Add_FForecasts(
	@Invoice VARCHAR(50),
	@AgreedPaymentDate DATETIME,
	@AgreedAmount DECIMAL(18,2),
	@ConstructionSiteID INT,
	@RouteID INT,
	@ResponsibleID INT
)
AS
BEGIN
	  INSERT INTO F_Forecasts(Invoice, AgreedPaymentDate, AgreedAmount, ConstructionSiteID, RouteID, ResponsibleID)
	  VALUES(@Invoice, @AgreedPaymentDate, @AgreedAmount, @ConstructionSiteID, @RouteID, @ResponsibleID)
END;