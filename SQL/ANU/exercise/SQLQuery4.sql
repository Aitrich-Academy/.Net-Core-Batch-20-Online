
----Write user defined function to implement auto increment of id fields of all the tables.

---method 1

CREATE TABLE SampleTable (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    -- Other columns
);


---------------------------------------------
---method 2
-- Create a sequence
CREATE SEQUENCE dbo.SampleSequence
    START WITH 1
    INCREMENT BY 1;

-- Use the sequence in a table
CREATE TABLE SampleTable (
    ID INT PRIMARY KEY DEFAULT NEXT VALUE FOR dbo.SampleSequence,
    -- Other columns
);

-----method 3
-----First, create a SEQUENCE object that will generate sequential numbers:
CREATE SEQUENCE dbo.GlobalSequence
    START WITH 1
    INCREMENT BY 1;
GO
----Next, create a scalar UDF that retrieves the next value from the sequence:

CREATE FUNCTION dbo.GetNextID()
RETURNS BIGINT
AS
BEGIN
    RETURN NEXT VALUE FOR dbo.GlobalSequence;
END;
GO
