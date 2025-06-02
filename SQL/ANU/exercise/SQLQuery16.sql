
---Table - Subject

-----insert

CREATE PROCEDURE sp_InsertSubject
     
    @Course INT,
    @Professor INT,
    @subjectName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Subject (  Course, Professor, SubjectName )
    VALUES (  @Course, @Professor, @subjectName);
END;

-----update

CREATE PROCEDURE sp_UpdateSubject
    @SubjectID INT,
    @Course INT,
    @Professor INT,
    @subjectName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Subject
    SET Course = @Course,
        Professor = @Professor,
        SubjectName  = @subjectName
    WHERE SubjectID = @SubjectID;
END;


---delete

CREATE PROCEDURE sp_DeleteSubject
    @SubjectID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Subject
    WHERE SubjectID = @SubjectID;
END;
