----	To list all students, colleges, courses and professors

select * from student

select * from College 
select * from course 
select * from Professor 

.
----------------------------------------------------------------

SELECT
    s.StudentID,
    s.studentName AS StudentName,
    d.College  AS CollegeName,
    c.CourseID,
    c.courseName AS CourseName,
    p.ProfID AS ProfessorID,
    p.ProfName  AS ProfessorName
FROM
    Student s
JOIN
    Department d ON s.Department = d.DepID
JOIN
    Student_Registration sr ON s.StudentID = sr.StudentID
JOIN
    Subject subj ON sr.SubjectID = subj.SubjectID
JOIN
    Course c ON subj.Course = c.CourseID
JOIN
    Professor p ON subj.Professor = p.ProfID ;
