-----To list all colleges in descending order of their names

SELECT *
FROM Department
ORDER BY DepName  DESC;


-------------------------------------------------------------------------
------	To list all Subjects under  course “B.Tech Computer Science”

SELECT subj.SubjectID, subj.subjectName AS SubjectName
FROM Subject subj
JOIN Course c ON subj.Course = c.CourseID
WHERE c.courseName = 'B.Sc Physics';


select * from course


----------------------------------------------------------

----To count the number of courses has physics subject. 

select * from subject 


SELECT COUNT(DISTINCT c.CourseID) AS NumberOfCoursesWithComputerSubject
FROM Course c
JOIN Subject s ON c.CourseID = s.Course
WHERE s.subjectname LIKE '%mechanics%';

SELECT COUNT(DISTINCT c.CourseID) AS NumberOfCoursesWithComputerSubject
FROM Course c
JOIN Subject s ON c.CourseID = s.Course
WHERE c.coursename LIKE '%physics%';