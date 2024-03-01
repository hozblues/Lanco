USE LancoDB;

IF EXISTS(SELECT 1 FROM SYS.sysobjects WHERE NAME = 'SP_Add_FRoutes' AND type = 'P' )
	DROP PROCEDURE SP_Add_FRoutes;
GO

CREATE PROCEDURE SP_Add_FRoutes(
	@RouteID INT,
	@ResponsibleID INT,
	@AdmissionDate DATETIME,
	@DepartureDate DATETIME
)
AS
BEGIN
	 INSERT INTO F_Routes(RouteID, ResponsibleID, AdmissionDate, DepartureDate)
	 VALUES(@RouteID, @ResponsibleID, @AdmissionDate, @DepartureDate)
END;