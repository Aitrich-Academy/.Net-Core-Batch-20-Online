CREATE DATABASE Employees ;

-----------------------------------------------------------
CREATE TABLE Department (
    DepartmentID INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


--------------------------------------------------------

CREATE TABLE Employee (
    EmpID INT  IDENTITY(1,1) PRIMARY KEY,
    EmpName VARCHAR(100),
    DepartmentID INT,
    Salary DECIMAL(10, 2),
    HireDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
);

------------------------------------------------------------

SELECT * FROM Employee 
SELECT * FROM Department 