

CREATE TABLE [dbo].[Users](
	 Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NULL,
	[Location] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Role] [varchar](50) NULL,
	[About] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[CompanyId] [uniqueidentifier] NULL,
	[Status] [varchar](50) NULL,
	[Image] [varchar](50) NULL,
	FOREIGN KEY (CompanyId) REFERENCES Companies (Id)
 )


 ALTER TABLE Users ADD CONSTRAINT email_unique UNIQUE (Email);



