----Table - Course

----insert 

CREATE PROCEDURE sp_InsertCourse
    @CourseID INT,
    @Department INT,
    @CourseName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Course (CourseID, Department, CourseName)
    VALUES (@CourseID, @Department, @CourseName);
END;

---update

CREATE PROCEDURE sp_UpdateCourse
    @CourseID INT,
    @Department INT,
    @CourseName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Course
    SET Department = @Department,
        CourseName  = @CourseName
    WHERE CourseID = @CourseID;
END;

---delete

CREATE PROCEDURE sp_DeleteCourse
    @CourseID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Course
    WHERE CourseID = @CourseID;
END;

