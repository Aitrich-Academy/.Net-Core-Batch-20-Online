----Task 3: Aggregate Functions, GROUP BY, HAVING


--	Write a query to calculate the average salary of employees in each department,
---but only include departments where the average salary exceeds 50,000.

SELECT d.DepartmentName, AVG(e.Salary) AS AvgSalary
FROM Employee e
JOIN Department d ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentName
HAVING AVG(e.Salary) > 50000;
