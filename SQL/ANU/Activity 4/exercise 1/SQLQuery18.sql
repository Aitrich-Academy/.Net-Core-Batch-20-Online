    -----	Create a view for listing the students and their courses.
	
	CREATE VIEW StudentCourseView AS
SELECT
    s.StudentID,
    s.studentName AS StudentName,
    c.CourseID,
    c.CourseName
FROM
    Student s
JOIN
    Student_Registration sr ON s.StudentID = sr.StudentID
JOIN
    Subject subj ON sr.SubjectID = subj.SubjectID
JOIN
    Course c ON subj.Course = c.CourseID;




