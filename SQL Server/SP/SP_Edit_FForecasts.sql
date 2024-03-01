USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_FForecasts' AND type = 'P' )
	DROP PROCEDURE SP_Edit_FForecasts;
GO

CREATE PROCEDURE SP_Edit_FForecasts(
    @Forecasts_ID INT,
	@Invoice VARCHAR(50),
	@AgreedPaymentDate DATETIME,
	@AgreedAmount DECIMAL(18,2),
	@ConstructionSiteID INT,
	@RouteID INT,
	@ResponsibleID INT
)
AS
BEGIN
	  UPDATE F_Forecasts
	     SET Invoice = @Invoice,
			 AgreedPaymentDate = @AgreedPaymentDate,
			 AgreedAmount = @AgreedAmount,
			 ConstructionSiteID = @ConstructionSiteID,
			 RouteID = @RouteID,
			 ResponsibleID = @ResponsibleID
	   WHERE Forecasts_ID = @Forecasts_ID
END;