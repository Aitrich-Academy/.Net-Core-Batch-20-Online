---Table - Professor

CREATE TABLE Professor (
    ProfID INT identity(1,1) PRIMARY KEY,
    Department INT,
    ProfName VARCHAR(20),
    FOREIGN KEY (Department) REFERENCES Department(DepID)
);


---Table - Course

CREATE TABLE Course (
    CourseID INT PRIMARY KEY,
    Department INT,
    CourseName VARCHAR(20),
    FOREIGN KEY (Department) REFERENCES Department(DepID)
);

 
 

---Table - Subject

CREATE TABLE Subject (
    SubjectID INT identity(1,1) PRIMARY KEY,
    Course INT,
    Professor INT,
    SubjectName VARCHAR(20),
    FOREIGN KEY (Course) REFERENCES Course(CourseID),
    FOREIGN KEY (Professor) REFERENCES Professor(ProfID)
);

---Table - Student

CREATE TABLE Student (
    StudentID INT identity(1,1) PRIMARY KEY,
    Department INT,
    StudentName VARCHAR(20),
    DateOfEnrollment SMALLDATETIME,
    TelephoneNumber VARCHAR(20),
    FOREIGN KEY (Department) REFERENCES Department(DepID)
);