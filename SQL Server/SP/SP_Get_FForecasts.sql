USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_FForecasts' AND type = 'P' )
	DROP PROCEDURE SP_Get_FForecasts;
GO

CREATE PROCEDURE SP_Get_FForecasts
AS
BEGIN
    SELECT ff.Forecasts_ID,
	       ff.Invoice,
		   ff.AgreedPaymentDate,
		   ff.AgreedAmount,
		   ff.ConstructionSiteID,
		   lcs.ConstructionSiteName,
		   ff.RouteID,
		   lr.RouteName,
		   ff.ResponsibleID,
		   lre.ResponsibleName
	  FROM F_Forecasts ff
 LEFT JOIN Lu_ConstructionSite lcs
        ON lcs.ConstructionSiteID = ff.ConstructionSiteID
 LEFT JOIN Lu_Routes lr
        ON lr.RouteID = ff.RouteID
 LEFT JOIN Lu_Responsible lre
        ON lre.ResponsibleID = ff.ResponsibleID
END;
