USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Get_FRoutes' AND type = 'P' )
	DROP PROCEDURE SP_Get_FRoutes;
GO

CREATE PROCEDURE SP_Get_FRoutes
AS
BEGIN
	SELECT fr.RouteFact_ID,
	       fr.RouteID,
		   lr.RouteName,
		   fr.ResponsibleID,
		   lre.ResponsibleName,
		   fr.AdmissionDate,
		   fr.DepartureDate
      FROM F_Routes fr
 LEFT JOIN Lu_Routes lr
        ON lr.RouteID = fr.RouteID
 LEFT JOIN Lu_Responsible lre
        ON lre.ResponsibleID = fr.ResponsibleID
END;
