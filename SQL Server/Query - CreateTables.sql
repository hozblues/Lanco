
--- Tablas Administrativos

CREATE TABLE UserProfile(
	UserID int IDENTITY(1,1) NOT NULL,
	UserFirstName varchar(100) NULL,
	UserLastName varchar(100) NULL,
	UserEmail varchar(200) NULL,
	UserPassword varchar(900) NULL,
	IsActive bit NULL,
	CreatedDate datetime NULL,
)


CREATE TABLE Roles(
	RoleID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	RoleName varchar(50) NULL,
	IsActive bit NULL,
	CreatedDate datetime NULL,
)


CREATE TABLE UserRole_Relationship(
	Relationship_ID PRIMARY KEY IDENTITY(1,1) NOT NULL,
	RoleID INT,
	UserID INT,
	CreatedDate DATETIME,
)

/********************************************************************************************************/

--- Tablas Catalogo

CREATE TABLE Lu_Routes(
 RouteID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
 RouteName VARCHAR(100),
 IsActive BIT,
 CreatedDate DATETIME
);


CREATE TABLE Lu_Responsible(
 ResponsibleID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
 ResponsibleName VARCHAR(150),
 IsActive BIT,
 CreatedDate DATETIME
);

CREATE TABLE Lu_Customers(
 CustomerID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
 CustomerName VARCHAR(150),
 IsActive BIT,
 CreatedDate DATETIME
);

CREATE TABLE Lu_Banks(
 BankID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
 BankName VARCHAR(150),
 IsActive BIT,
 CreatedDate DATETIME
);

CREATE TABLE Lu_Currency(
 CurrencyID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
 CurrencyCode CHAR(3),
 CurrencyName VARCHAR(150),
 IsActive BIT,
 CreatedDate DATETIME,
);


CREATE TABLE Lu_ConstructionSite(
 ConstructionSiteID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
 ConstructionSiteName VARCHAR(150),
 IsActive BIT,
 CreatedDate DATETIME,
);


/********************************************************************************************************/

-- Tabla de Hechos

CREATE TABLE F_Routes(
	RouteFact_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	RouteID INT,
	ResponsibleID INT,
	AdmissionDate DATETIME,
	DepartureDate DATETIME
);

CREATE TABLE F_PaymentsSAE(
	PaymentSAE_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	CustomerID INT,
	BankID INT,
	PaymentDate DATETIME,
	PaymentAmount DECIMAL(18,2),
	CurrencyID INT,
	RouteID INT,
	ResponsibleID INT
);


CREATE TABLE F_Forecasts(
	Forecasts_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Invoice VARCHAR(50),
	AgreedPaymentDate DATETIME,
	AgreedAmount DECIMAL(18,2),
	ConstructionSiteID INT,
	RouteID INT,
	ResponsibleID INT
);


CREATE TABLE F_Files(
	Files_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	CustomerID INT,
	NumberFile VARCHAR(50),
	ConstructionSiteID INT
);
