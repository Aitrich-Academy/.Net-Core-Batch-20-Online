
select*from EmailVerifications;
SELECT * FROM EmailVerifications ;
select *from Location;
select* from CompanyUser;
select*from JobProviderCompany;



INSERT INTO JobProviderCompany (Id, LegalName, Email, Address, Summary, Website, Location)
VALUES 
(NEWID(), 'TechNovsa', 'contact@technovsa.com', 'Trivandrum', 'IT Company', 'www.technova.com', 'F85521E0-EAAE-44FE-A5F9-C7BF66087589');

INSERT INTO JobProviderCompany (Id, LegalName, Email, Address, Summary, Website, Location)
VALUES 
(NEWID(), 'Trivandrum', 'Kerala', 'India', 'Trivandrum', 'Default location'),
  (NEWID(), 'Bangalore', 'Karnataka', 'India', 'Bangalore', 'IT hub location'),
  (NEWID(), 'Chennai', 'Tamil Nadu', 'India', 'Chennai', 'Business city location');

ALTER TABLE Location
ALTER COLUMN Name NVARCHAR(100); 




		ALTER TABLE Location
ALTER COLUMN Discription NVARCHAR(200); 

INSERT INTO Location (Id, City, State, Country, Name, Discription)
VALUES ('F85521E0-EAAE-44FE-A5F9-C7BF66087589',
        'Trivandrum', 
        'Kerala', 
        'India', 
        'Trivandrum', 
        'Default location');  -- now fits

		SELECT * FROM Location;
