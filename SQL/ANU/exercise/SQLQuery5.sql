
---4.	Write userdefined function to list  Dean and University of various colleges


CREATE FUNCTION dbo.GetDeansAndUniversities()
RETURNS TABLE
AS
RETURN
(
    SELECT
        Dean,
        University
    FROM
        College
);


----After creating the function, you can retrieve the list of Deans and their Universities by executing:

SELECT * FROM dbo.GetDeansAndUniversities();