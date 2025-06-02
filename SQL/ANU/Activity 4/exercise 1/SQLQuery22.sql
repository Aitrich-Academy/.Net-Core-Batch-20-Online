-----	To list all professors of physics department.


 SELECT p.ProfID, p.ProfName 
FROM Professor p
JOIN Department d ON p.Department = d.DepID 
WHERE d.DepName  = 'Physics';



-----	To list all courses taught by Professor ‘vishnu’.


SELECT DISTINCT c.CourseID, c.coursename AS CourseName
FROM Professor p
JOIN Subject s ON p.ProfID = s.Professor
JOIN Course c ON s.Course = c.CourseID
WHERE p.ProfName  = 'dias';


-------------------------------------------------------------

-----	To list all students group by department


SELECT
    d.DepName  AS DepartmentName,
    COUNT(s.StudentID) AS NumberOfStudents
FROM
    Student s
JOIN
    Department d ON s.Department = d.DepID
GROUP BY
    d.DepName 
ORDER BY
    d.DepName ;