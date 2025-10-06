create database WebAdminApi

Declare @SystemUserId UNIQUEIDENTIFIER = NEWID();
INSERT INTO dbo.AuthUser(Id, FirstName, LastName,Email,Role,Phone) VALUES 
(@SystemUserId, 'Alfiya', 'Subair', 'alfiyasubair5@gmail.com', 1, '123456789');


select * from AuthUser

UPDATE AuthUser
SET Password = 'admin@123'

select * from Skill


INSERT INTO JobSeekers (Id, UserName, FirstName, LastName, Phone, Email, Image, Role) VALUES

(NEWID(), 'radhi123', 'Radhi', 'Krishna', '9876543210', 'radhi@example.com', NULL, 1),
(NEWID(), 'anoop99', 'Anoop', 'Kumar', '9123456789', 'anoop@example.com', NULL, 1),
(NEWID(), 'alfiya07', 'Alfiya', 'Subair', '9012345678', 'alfiya@example.com', NULL, 1),
(NEWID(), 'arun88', 'Arun', 'Menon', '9098765432', 'arun@example.com', NULL, 2);

select * from JobSeekers

INSERT INTO JobProviderCompany (Id, LegalName, Summary, IndustryId, Email, Phone, Address, Website, Location)
VALUES
(NEWID(), 'ABC Tech', 'IT Company', '6BB53AA8-04E1-49FF-990F-087D7F9F7843', 'abc@tech.com', '9876543210', 'Bangalore', 'www.abctech.com', '5095CD43-81BA-465F-936E-12D01AE4589D'),
(NEWID(), 'MediCare', 'Hospital Group', '87CBAF33-343F-4C42-BFCE-3B7C374468F2', 'info@medicare.com', '9123456789', 'Chennai', 'www.medicare.com', 'E298C1E1-A14F-4697-B51B-395F157C47F2'),
(NEWID(), 'Green Energy', 'Renewable Energy Company', '3B789560-508A-4A47-A433-50C99038124B', 'support@green.com', '9012345678', 'Kochi', 'www.green.com', '32C544B6-AD05-45B7-B895-E5EB7A4317BA');

SELECT * FROM JobProviderCompany where Location = '5095CD43-81BA-465F-936E-12D01AE4589D'


INSERT INTO Industry (Id, Name, Description) VALUES

(NEWID(), 'Information Technology', 'Software development, IT services, and consulting'),
(NEWID(), 'Healthcare', 'Hospitals, clinics, and medical services'),
(NEWID(), 'Energy', 'Renewable and non-renewable energy companies'),
(NEWID(), 'Education', 'Schools, colleges, and training institutions');

 select * from Industry

 select * from Location

INSERT INTO JobCategory (Id, Name, Description) VALUES

(NEWID(), 'Software Development', 'Software engineering jobs'),
(NEWID(), 'Nursing', 'Healthcare jobs'),
(NEWID(), 'Marketing', 'Marketing jobs'),
(NEWID(), 'Finance', 'Finance jobs');

select * from JobCategory

SELECT Id, LegalName FROM JobProviderCompany;

INSERT INTO CompanyUser (Id, FirstName, LastName, Role, UserName, Email, Phone, Company)
VALUES
(NEWID(), 'Radhi', 'Krishna', 1, 'radhi_admin', 'radhi@abc.com', '9876543210', '004CF481-19ED-4968-AF82-13F3BBC9BE4A'),
(NEWID(), 'Alfiya', 'Subair', 2, 'alfiya_hr', 'alfiya@abc.com', '9012345678',  '084EA023-79FD-4419-AF2B-4BA22E52342C'),
(NEWID(), 'Anood', 'Nazeer', 1, 'anood_user', 'anood@abc.com', '9123456789','847D00B0-B991-4CD8-89F7-7212900052DA');

select *from CompanyUser where Company = '004CF481-19ED-4968-AF82-13F3BBC9BE4A'

 INSERT INTO JobPost (Id, JobTitle, JobSummary, LocationId, CompanyId, CategoryId, IndustryId, PostedBy, PostedDate) VALUES

 (NEWID(), 'Developer', 'Passionate Worker', '5095CD43-81BA-465F-936E-12D01AE4589D', '004CF481-19ED-4968-AF82-13F3BBC9BE4A',
 'A25DFFA5-E553-4634-ACE1-119BE377806D', '6BB53AA8-04E1-49FF-990F-087D7F9F7843' ,'FEF7A50D-AE6A-464D-807A-5BFFF327B320' , '2025-09-23 20:45:00')
 
Delete from JobPost
 select * from JobPost