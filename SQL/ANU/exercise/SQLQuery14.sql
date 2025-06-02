
----Table - Professor

----insert

CREATE PROCEDURE sp_InsertProfessor
    
    @Department INT,
    @ProfName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Professor ( Department, ProfName )
    VALUES ( @Department, @ProfName);
END;


----update

CREATE PROCEDURE sp_UpdateProfessor
    @ProfID INT,
    @Department INT,
    @profName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Professor
    SET Department = @Department,
        ProfName  = @profName
    WHERE ProfID  = @ProfID;
END;

----delete

CREATE PROCEDURE sp_DeleteProfessor
    @ProfID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Professor
    WHERE ProfID  = @ProfID;
END;

