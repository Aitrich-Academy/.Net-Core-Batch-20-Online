

----Table - Student

---insert

CREATE PROCEDURE InsertStudent
     
    @Department INT,
    @studentName VARCHAR(20),
    @DateofEnrollment SMALLDATETIME,
    @TelephoneNumber VARCHAR(20)
AS
BEGIN
    INSERT INTO Student (  Department, StudentName , DateofEnrollment, TelephoneNumber)
    VALUES ( @Department, @studentName, @DateofEnrollment, @TelephoneNumber);
END;


---update 

CREATE PROCEDURE UpdateStudent
    @StudentID INT,
    @Department INT,
    @studentName VARCHAR(20),
    @DateofEnrollment SMALLDATETIME,
    @TelephoneNumber VARCHAR(20)
AS
BEGIN
    UPDATE Student
    SET Department = @Department,
        StudentName  = @studentName,
        DateofEnrollment = @DateofEnrollment,
        TelephoneNumber = @TelephoneNumber
    WHERE StudentID = @StudentID;
END;

---delete

CREATE PROCEDURE DeleteStudent
    @StudentID INT
AS
BEGIN
    DELETE FROM Student WHERE StudentID = @StudentID;
END;

