----Task 4: LIKE and Wildcards
	----Retrieve the names of employees whose names contain 'son' anywhere in their name.

SELECT EmpName
FROM Employee
WHERE EmpName LIKE '%son%';




INSERT INTO Employee (EmpName, DepartmentID, Salary, HireDate)
VALUES ('Jackson', 2, 67000.00, '2023-05-01');

 