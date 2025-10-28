select*from JobApplications;
select*from AuthUser;
select *from SignUpRequests;
select*from Location;
select*from JobProviderCompany;
select*from Industry;
select*from JobPost;
select*from CompanyUser;
select*from JobCategory;
select*from JobSeekers;


ALTER TABLE JobApplications
ADD ResumeId UNIQUEIDENTIFIER NULL;

ALTER TABLE JobApplications
ADD CONSTRAINT FK_JobApplications_Resume_ResumeId
FOREIGN KEY (ResumeId) REFERENCES Resume(Id);

ALTER TABLE JobProviderCompany
ADD ProfilePictureData VARBINARY(MAX) NULL;

SELECT Id, Email FROM JobProviderCompany;

SELECT * FROM JobProviderCompany WHERE Id = '111b3857-bf4c-4015-bff6-abbb3a24ea0d';
ALTER TABLE Location
ADD City NVARCHAR(100),
    State NVARCHAR(100),
    Country NVARCHAR(100);




INSERT INTO __EFMigrationsHistory (MigrationId, ProductVersion)
VALUES ('20251022143827_project', '8.0.0');

ALTER TABLE AuthUser ADD JobProviderId UNIQUEIDENTIFIER NULL;

ALTER TABLE JobProviderCompany
ADD City NVARCHAR(100) NULL,
    State NVARCHAR(100) NULL,
    Country NVARCHAR(100) NULL;


INSERT INTO Location (Id, Name, Discription)
VALUES 

('A1B2C3D4-E5F6-7890-1234-56789ABCDEF0',  'Mumbai Branch', 'Regional office'),
('B2C3D4E5-F678-9012-3456-789ABCDEF123', 'Delhi Office', 'Headquarters'),
('C3D4E5F6-7890-1234-5678-9ABCDEF12345', 'Hyderabad Branch', 'IT hub');

ALTER TABLE Location
ALTER COLUMN Discription NVARCHAR(100);


INSERT INTO Industry (Id, Name, Description)VALUES

(NEWID(), 'Information Technology', 'Software development, IT services, and consulting'),

(NEWID(), 'Healthcare', 'Hospitals, clinics, and medical services'),

(NEWID(), 'Energy', 'Renewable and non-renewable energy companies'),

(NEWID(), 'Education', 'Schools, colleges, and training institutions');


INSERT INTO JobPost(Id, JobTitle, JobSummary, PostedDate, LocationId, IndustryId, CompanyId, PostedBy, ApplicationDeadline, Experience, JobType, Salary, JobCategoryId)VALUES 

(NEWID(), 'Software Engineer', 'Design, develop, and maintain ASP.NET Core web applications.', GETDATE(),
'A1B2C3D4-E5F6-7890-1234-56789ABCDEF0', '9F698492-E0BB-4D6E-9F4D-16270838FCD3', 'E7435F53-D542-45ED-8DB4-1A839E00BF15', '44FC0625-F8E5-4AC3-957E-8628870E2498', 
DATEADD(DAY, 30, GETDATE()), '2-4 years', 'Full-Time', 60000, 'B77931AD-3839-4D52-97B8-4F4CE5F27429'),


 (NEWID(), 'Frontend Developer', 'Build responsive web interfaces using HTML, CSS, and React.', GETDATE(),
 'B2C3D4E5-F678-9012-3456-789ABCDEF123', '54B3625C-C3B6-41D9-BE75-5116DA285D37', '3BEC95F3-0C35-40DE-8EE0-8DDE8961180E', '0D775712-54BB-418C-B285-F02642FFE51C',
 DATEADD(DAY, 45, GETDATE()), '1-3 years', 'Remote', 55000, 'B6A23135-220F-4365-BA72-F1021D7C8FA3');

 INSERT INTO JobCategory (Id, Name, Description) VALUES
 (NEWID(), 'Software Development', 'Jobs related to software design, coding, testing, and maintenance.'),

 (NEWID(), 'Digital Marketing', 'Roles focused on SEO, social media, and online advertising campaigns.');


 ALTER TABLE JobCategory ALTER COLUMN Description NVARCHAR(255);
 ALTER TABLE JobPost ALTER COLUMN JobTitle NVARCHAR(100);
 ALTER TABLE JobPost ALTER COLUMN JobSummary NVARCHAR(255);

 
INSERT INTO JobSeekers(Id, UserName, FirstName, LastName, Phone, Email, Image, Role, Title)
VALUES
(NEWID(), 'alfiya', 'Alfiya', 'Subair', '9876543210', 'alfiya@example.com', NULL, 1, 'Software Engineer'),
(NEWID(), 'radhi', 'Radhi', 'Krishna', '9876501234', 'radhi@example.com', NULL, 1, 'Full Stack Developer'),
(NEWID(), 'anood', 'Anood', 'Basheer', '9847012345', 'anood@example.com', NULL, 1, 'Frontend Developer'),
(NEWID(), 'rahul', 'Rahul', 'Menon', '9912345678', 'rahul@example.com', NULL, 1, 'Backend Developer');

-- Rename columns
EXEC sp_rename 'JobApplications.JobPost_id', 'JobPostId', 'COLUMN';
EXEC sp_rename 'JobApplications.Applicant', 'ApplicantId', 'COLUMN';
EXEC sp_rename 'JobApplications.Datesubmitted', 'DateSubmitted', 'COLUMN';

-- Add Status column (nullable)
ALTER TABLE JobApplications
ADD Status NVARCHAR(50) NULL;
