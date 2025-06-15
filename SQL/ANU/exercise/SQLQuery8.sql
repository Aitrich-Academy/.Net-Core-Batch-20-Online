CREATE FUNCTION dbo.GetCollegesByUniversity (@UniversityName VARCHAR(100))
RETURNS TABLE
AS
RETURN
(
    SELECT CID, CName
    FROM College
    WHERE University = @UniversityName
);


