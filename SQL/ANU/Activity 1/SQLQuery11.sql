CREATE TABLE Employee 
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName VARCHAR(100) NOT NULL,
    City VARCHAR(100),
    DepartmentID INT
);



 CREATE TABLE Department 
(
    Department_id INT IDENTITY(1,1) PRIMARY KEY,
    Department_name VARCHAR(100) NOT NULL, 
);