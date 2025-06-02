
---	Write stored procedures for retrieve details of students of computer science department.

CREATE PROCEDURE GetphysicsStudents
AS
BEGIN
    SELECT 
        s.StudentID,
        s.StudentName ,
        s.DateofEnrollment,
        s.TelephoneNumber
    FROM 
        Student s
    INNER JOIN 
        Department d ON s.Department = d.DepID 
    WHERE 
        d.DepName  = 'Physics';
END;


select * from Department 

 
