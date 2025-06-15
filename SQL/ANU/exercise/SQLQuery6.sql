
-----Write userdefined function to generate automatic code for college eg:For college,CID will start from COL 00001 


----First, create a sequence object to generate sequential numbers:

CREATE SEQUENCE dbo.CollegeCodeSequence
    START WITH 1
    INCREMENT BY 1;

----Next, create a scalar-valued function that retrieves the next value from the sequence and formats it as COL 00001:
 
 CREATE FUNCTION dbo.GenerateCollegeCode()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    SET @NextID = NEXT VALUE FOR dbo.CollegeCodeSequence;
    RETURN 'COL ' + RIGHT('00000' + CAST(@NextID AS VARCHAR(5)), 5);
END;


----You can now use this function to generate a college code:

 SELECT dbo.GenerateCollegeCode() AS CollegeCode;
