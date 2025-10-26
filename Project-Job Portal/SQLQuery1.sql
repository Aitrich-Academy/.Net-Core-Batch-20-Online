select* from EmailVerifications;
select *from JobProviderCompany;
select*from Location;
select*from CompanyUser;



INSERT INTO Location (Id, City, State, Country, Name, Discription)
VALUES 

('A1B2C3D4-E5F6-7890-1234-56789ABCDEF0', 'Mumbai', 'Maharashtra', 'India', 'Mumbai Branch', 'Regional office'),
('B2C3D4E5-F678-9012-3456-789ABCDEF123', 'Delhi', 'Delhi', 'India', 'Delhi Office', 'Headquarters'),
('C3D4E5F6-7890-1234-5678-9ABCDEF12345', 'Hyderabad', 'Telangana', 'India', 'Hyderabad Branch', 'IT hub');

INSERT INTO Industry (Id, Name, Description)VALUES

(NEWID(), 'Information Technology', 'Software development, IT services, and consulting'),

(NEWID(), 'Healthcare', 'Hospitals, clinics, and medical services'),

(NEWID(), 'Energy', 'Renewable and non-renewable energy companies'),

(NEWID(), 'Education', 'Schools, colleges, and training institutions');

select * from Industry
select*from JobSeekers;
select *from JobPost;

ALTER TABLE JobPost
ALTER COLUMN JobTitle VARCHAR(100); -- or any length that fits your use case

INSERT INTO JobSeekers(Id, UserName, FirstName, LastName, Phone, Email, Image, Role, Title)
VALUES
(NEWID(), 'alfiya', 'Alfiya', 'Subair', '9876543210', 'alfiya@example.com', NULL, 1, 'Software Engineer'),
(NEWID(), 'radhi', 'Radhi', 'Krishna', '9876501234', 'radhi@example.com', NULL, 1, 'Full Stack Developer'),
(NEWID(), 'anood', 'Anood', 'Basheer', '9847012345', 'anood@example.com', NULL, 1, 'Frontend Developer'),
(NEWID(), 'rahul', 'Rahul', 'Menon', '9912345678', 'rahul@example.com', NULL, 1, 'Backend Developer');


SELECT * FROM JobApplications WHERE JobPostId = '473E1E44-83F8-401C-A8A3-26DECACE7D51';
