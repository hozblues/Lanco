USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Edit_FRoutes' AND type = 'P' )
	DROP PROCEDURE SP_Edit_FRoutes;
GO

CREATE PROCEDURE SP_Edit_FRoutes(
    @RouteFact_ID INT,
	@RouteID INT,
	@ResponsibleID INT,
	@AdmissionDate DATETIME,
	@DepartureDate DATETIME
)
AS
BEGIN
	  UPDATE F_Routes
	     SET RouteID = @RouteID,
		     ResponsibleID = @ResponsibleID,
			 AdmissionDate = @AdmissionDate,
			 DepartureDate = @DepartureDate
	   WHERE RouteFact_ID = @RouteFact_ID
END;