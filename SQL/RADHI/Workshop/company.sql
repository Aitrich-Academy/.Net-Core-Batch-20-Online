
CREATE DATABASE HireMeNowDB;
CREATE TABLE Companies (
    Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    Name varchar(100) NULL,
    Email varchar(50) NOT NULL UNIQUE,
    Website varchar(50) NULL,
    Phone varchar (50) NULL,
    About varchar(300) NULL,
    Location varchar(50) NULL,
    Status varchar(50) NULL
);
EXEC sp_rename 'Companies', 'Company' ;
ALTER TABLE company ALTER COLUMN ABOUT VARCHAR(500);
EXEC sp_rename 'Company.Location', 'place', 'COLUMN';

CREATE TABLE Users( id	UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,FirstName varchar(50) Null,
LastName Varchar(50) Null,Email Varchar(50) Null,Gender Varchar(50) Null,
Location varchar(50) NULL,
Phone varchar(50) NULL,
	Password varchar(50) NULL,
	Role varchar (50) NULL,
	About varchar(50) NULL,
	Designation varchar(50) NULL,
	CompanyId uniqueidentifier NULL,
	Status varchar(50) NULL,
	Image varchar(50) NULL,
	FOREIGN KEY (CompanyId) REFERENCES Company (Id)
 );
 ALTER TABLE Users ADD CONSTRAINT email_unique UNIQUE (Email);
 select * from Users;
 ALtER TABLE company ADD Logo varchar(50),Vision varchar(50),Mission varchar(50);
 ALTER TABLE users
DROP COLUMN  logo,vision,Mission;
   INSERT INTO Company
 ( Name, Email, Website,Phone,About,place,Status,Logo,Vision, Mission)      
VALUES 
('cloud', 'cloud.academy@aitrich.com', 'https://cloud.com/', '048709800','About us','thrissur', 'A','logo','Our Vission','our mision');
select * from Company;
Update Company set Name='Abc Academy',place='kochi' where email='aitrich.academy@aitrich.com';
delete from company where id='39EC38E1-74BB-4775-9852-C5237DFFB7D4';


 
INSERT INTO users
(FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About, Designation, CompanyId, Status, Image)
VALUES
('Soudha', 'AM', 'soudha.aitrich@gmail.com', 'Female', 'Thrissur', '6586970', '123', 'Jobprovider', 'about', 'Designation', 'E6526B45-1E1C-4187-A85F-38E41272601E', 'Active', 'image');


INSERT  INTO users
(FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About,Designation, CompanyId, Status, Image)
 VALUES
 ( 'yadhu', 'krishna', 'yadhu.aitrich@gmail.com', NULL, 'Thrissur', NULL, '123', 'Jobseeker', NULL, NULL, NULL, 'Active', NULL);

 INSERT  INTO users
(FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About,Designation, CompanyId, Status, Image)
 VALUES
  ('shini', 'parameswaran', 'shini.aitrich@gmail.com', NULL, 'Thrissur', NULL, '123', 'CompanyMember', NULL, NULL, 'E6526B45-1E1C-4187-A85F-38E41272601E', 'Active', NULL);

  UPDATE Users SET  Phone = '8085499250', Location='Kochi',
About ='Experienced .NET developer with 5+ years '   WHERE Email = 'yadhu.aitrich@gmail.com';
UPDATE Users SET  Id= '7FA61784-CDDA-4414-B7E4-7D431AB4238B' WHERE email = 'soudha.aitrich@gmail.com';
select * from users;
Select * from Users where Role='Jobseeker';
Select * from Users where Role='Jobseeker' and Email='yadhu.aitrich@gmail.com';
SELECT u.FirstName, u.LastName, u.Email, u.Phone, c.Name FROM users u
INNER JOIN Company c ON u.Id = c.Id;

 select u.FirstName , u.LastName , u.Email , u.Phone , c.Name  from users u, Company c where  u.Id=c.Id and c.Name='Aitrich Academy' ;

