IF OBJECT_ID(N'dbo.Suppliers', N'U') IS NULL
CREATE TABLE dbo.Suppliers (
    Id             nvarchar(20)  NOT NULL CONSTRAINT PK_Suppliers PRIMARY KEY,
    Name           nvarchar(150) NOT NULL,
    ContactPerson  nvarchar(150) NOT NULL CONSTRAINT DF_Suppliers_Contact DEFAULT (N''),
    Phone          nvarchar(50)  NOT NULL CONSTRAINT DF_Suppliers_Phone   DEFAULT (N''),
    Email          nvarchar(150) NOT NULL CONSTRAINT DF_Suppliers_Email   DEFAULT (N''),
    Address        nvarchar(300) NOT NULL CONSTRAINT DF_Suppliers_Address DEFAULT (N''),
    IsActive       bit           NOT NULL CONSTRAINT DF_Suppliers_Active  DEFAULT (1)
);

IF OBJECT_ID(N'dbo.Categories', N'U') IS NULL
CREATE TABLE dbo.Categories (
    Name nvarchar(100) NOT NULL CONSTRAINT PK_Categories PRIMARY KEY
);

IF OBJECT_ID(N'dbo.Medicines', N'U') IS NULL
CREATE TABLE dbo.Medicines (
    Id            nvarchar(20)  NOT NULL CONSTRAINT PK_Medicines PRIMARY KEY,
    Name          nvarchar(150) NOT NULL,
    Dosage        nvarchar(50)  NOT NULL CONSTRAINT DF_Medicines_Dosage DEFAULT (N''),
    Category      nvarchar(100) NOT NULL,
    SupplierId    nvarchar(20)  NOT NULL CONSTRAINT FK_Medicines_Suppliers REFERENCES dbo.Suppliers (Id),
    Price         decimal(18,2) NOT NULL,
    Quantity      int           NOT NULL,
    ReorderLevel  int           NOT NULL CONSTRAINT DF_Medicines_Reorder DEFAULT (20),
    ExpiryDate    date          NULL
);

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
CREATE TABLE dbo.Users (
    UserId        int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Users PRIMARY KEY,
    Username      nvarchar(50)  NOT NULL CONSTRAINT UQ_Users_Username UNIQUE,
    FullName      nvarchar(100) NOT NULL,
    Role          nvarchar(20)  NOT NULL CONSTRAINT CK_Users_Role CHECK (Role IN (N'Owner', N'Employee')),
    PasswordHash  nvarchar(300) NOT NULL,           -- PBKDF2 hash, never the plain password
    IsActive      bit           NOT NULL CONSTRAINT DF_Users_Active  DEFAULT (1),
    CreatedAt     datetime2(0)  NOT NULL CONSTRAINT DF_Users_Created DEFAULT (SYSDATETIME()),
    LastLoginAt   datetime2(0)  NULL
);

IF OBJECT_ID(N'dbo.AppMeta', N'U') IS NULL
CREATE TABLE dbo.AppMeta (
    MetaKey    nvarchar(50)  NOT NULL CONSTRAINT PK_AppMeta PRIMARY KEY,
    MetaValue  nvarchar(200) NOT NULL
);
