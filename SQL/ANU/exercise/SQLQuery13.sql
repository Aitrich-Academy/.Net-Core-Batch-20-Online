

----Table - Department

-----insert 

CREATE PROCEDURE sp_InsertDepartment
    
    @College INT,
    @depName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Department ( College, DepName )
    VALUES ( @College, @depName );
END;

----update

CREATE PROCEDURE sp_UpdateDepartment
    @DepID INT,
    @College INT,
    @depName VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Department
    SET College = @College,
        DepName  = @depName
    WHERE DepID  = @DepID;
END;


---delete

CREATE PROCEDURE sp_DeleteDepartment
    @DepID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Department
    WHERE DepID = @DepID;
END;


