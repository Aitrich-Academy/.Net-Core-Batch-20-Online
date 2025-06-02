----Table - Student_Registration

---insert 

CREATE PROCEDURE InsertStudentRegistration
    @StudentID INT,
    @SubjectID INT
AS
BEGIN
    INSERT INTO Student_Registration (StudentID , SubjectID )
    VALUES (@StudentID, @SubjectID);
END;


---update 

CREATE PROCEDURE UpdateStudentRegistration
    @StudentID INT,
    @OldSubjectID INT,
    @NewSubjectID INT
AS
BEGIN
    UPDATE Student_Registration
    SET Subject = @NewSubjectID
    WHERE Student = @StudentID AND Subject = @OldSubjectID;
END;


---update

CREATE PROCEDURE UpdateStudentRegistration
    @StudentID INT,
    @SubjectID INT,
    @regid INT
AS
BEGIN
    UPDATE Student_Registration
    SET SubjectID  = @SubjectID ,StudentID =@StudentID 
    WHERE @regid = @regid ;
End ;


---delete

CREATE PROCEDURE DeleteStudentRegistration
    @regid INT
    
AS
BEGIN
    DELETE FROM Student_Registration
    WHERE RegistrationId  = @regid   
END;
