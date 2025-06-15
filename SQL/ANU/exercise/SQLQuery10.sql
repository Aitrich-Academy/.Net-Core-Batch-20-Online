-----Table - University


----insert
CREATE PROCEDURE sp_InsertUniversity
     
    @Name VARCHAR(20),
    @Chancellor VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO University ( Name, Chancellor)
    VALUES ( @Name, @Chancellor);
END;


----update

CREATE PROCEDURE sp_UpdateUniversity
    @UID INT,
    @Name VARCHAR(20),
    @Chancellor VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE University
    SET Name = @Name,
        Chancellor = @Chancellor
    WHERE UID = @UID;
END;



-----delete

CREATE PROCEDURE sp_DeleteUniversity
    @UID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM University
    WHERE UID = @UID;
END;



EXEC sp_InsertUniversity  @Name = 'Oxford', @Chancellor = 'Dr. Smith';


select * from University 
