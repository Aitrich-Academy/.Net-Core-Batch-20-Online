----Table - Student_Registration


CREATE TABLE Student_Registration (
   RegistrationId int identity(1,1) PRIMARY KEY ,
    StudentID INT,
    SubjectID INT
    
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID)
);




CREATE LOGIN user_login WITH PASSWORD = 'user123';
use University_System ;
go
CREATE USER my_user FOR LOGIN user_login;