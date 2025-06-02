
---	Write userdefined function to list colleges under ‘cambridge university’


CREATE FUNCTION dbo.GetCollegesByUniversityname (@UniversityName VARCHAR(100))
RETURNS TABLE
AS
RETURN
(
    SELECT c.CID , c.CName
    FROM College c
    INNER JOIN University u ON c.University = u.UID
    WHERE u.Name = @UniversityName
);

select * from University 


select * from College 

SELECT * FROM dbo.GetCollegesByUniversityname('University Calicut');
