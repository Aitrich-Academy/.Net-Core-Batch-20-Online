
--	Create a new table temp_student with same structure as student table and write triggers 
----to insert updated/deleted data of table student to temp_student.

CREATE TABLE temp_student (
    StudentID INT,
    Department INT,
    StudentName VARCHAR(20),
    DateofEnrollment SMALLDATETIME,
    TelephoneNumber VARCHAR(20),
  );

 --- This trigger captures the data before it is updated and
 --- logs it into the temp_student table with the operation type 'UPDATE'.


 CREATE TRIGGER trg_Student_insert_new
ON Student
AFTER insert
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO temp_student (StudentID, Department, StudentName, DateofEnrollment, TelephoneNumber)
    SELECT StudentID, Department, StudentName, DateofEnrollment, TelephoneNumber from inserted  
    
END;


INSERT INTO Student ( Department, StudentName, DateofEnrollment, TelephoneNumber)
VALUES (23, 'Fiya', '2025-06-01 09:00:00', '0501234567');


select * from  Student 

select * from temp_student


select * from Department 




