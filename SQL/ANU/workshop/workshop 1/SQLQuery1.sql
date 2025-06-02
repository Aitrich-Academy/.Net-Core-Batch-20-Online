
 CREATE DATABASE HireMeNowDB;

 CREATE TABLE Company (
	 Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	[Name] [varchar](100) NULL,
	[Email] [varchar](50) NOT NULL UNIQUE,
	[Website] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Logo] [varchar](50) NULL,
	[About] [varchar](100) NULL,
	[Vision] [varchar](100) NULL,
	[Mission] [varchar](100) NULL,
	[Place] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
) 



EXEC sp_rename 'Company', 'Companies' ;
ALTER TABLE Companies ALTER COLUMN About varchar(300);

EXEC sp_rename 'Companies.Place', 'Location', 'COLUMN';