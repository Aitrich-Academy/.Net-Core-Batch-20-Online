------Task 2: INSERT INTO, UPDATE, DELETE

---	Insert a new employee named 'John Doe' into the 'Sales' department with a salary of 60,000 
---and today's date as the hire date.


INSERT INTO Employee (EmpName, DepartmentID, Salary, HireDate)
VALUES ('John Doe', 1, 60000.00, GETDATE());


INSERT INTO Employee (EmpName, DepartmentID, Salary, HireDate)
VALUES ('JayaPriya', 6, 34000.00, GETDATE());


INSERT INTO Employee (EmpName, DepartmentID, Salary, HireDate)
VALUES ('Vishnu', 6, 45000.00, GETDATE());


INSERT INTO Employee (EmpName, DepartmentID, Salary, HireDate)
VALUES ('Isha', 6, 15000.00, GETDATE());






--------------------------------------------------------------------

-----Update the salary of all employees in the 'IT' department by 10%.

UPDATE e
SET e.Salary = e.Salary * 1.10
FROM Employee e
JOIN Department d ON e.DepartmentID = d.DepartmentID
WHERE d.DepartmentName = 'IT';

select* from Employee 

--------------------------------------------------------------------------------

-----	Delete all employees who were hired before the year 2010.

DELETE FROM Employee
WHERE HireDate < '2010-01-01';