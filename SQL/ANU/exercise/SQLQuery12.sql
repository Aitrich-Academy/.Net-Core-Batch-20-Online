-----Table - Dean

----insert

CREATE PROCEDURE sp_InsertDean
     
    @deanName VARCHAR(20),
    @DateOfBirth DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Dean ( DeanName , DateOfBirth)
    VALUES ( @deanName , @DateOfBirth);
END;


----update 

CREATE PROCEDURE sp_UpdateDean
    @DeanID INT,
    @deanName VARCHAR(20),
    @DateOfBirth DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Dean
    SET DeanName  = @deanName ,
        DateOfBirth = @DateOfBirth
    WHERE DeanID = @DeanID;
END;


-----delete

CREATE PROCEDURE sp_DeleteDean
    @DeanID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Dean
    WHERE DeanID = @DeanID;
END;

