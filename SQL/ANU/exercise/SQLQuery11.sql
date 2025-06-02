

----Table - College

--insert 

CREATE PROCEDURE sp_InsertCollege
     
    @University INT,
    @Dean INT,
    @CName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO College (University, Dean, cName)
    VALUES ( @University, @Dean, @CName );
END;

----EXEC sp_InsertCollege  @University = 1, @Dean = 200, @CName  = 'Engineering';

---update

CREATE PROCEDURE sp_UpdateCollege
    @CID INT,
    @University INT,
    @Dean INT,
    @cName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE College
    SET University = @University,
        Dean = @Dean,
        CName  = @cName
    WHERE CID = @CID;
END;

 -----delete


 CREATE PROCEDURE sp_DeleteCollege
    @CID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM College
    WHERE CID = @CID;
END;

