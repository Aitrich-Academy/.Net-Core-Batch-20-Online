SELECT City, SUM(Salary) AS TotalSalary
FROM Employee
GROUP BY City
HAVING SUM(Salary) > 50000;

--------------------------------------------------------------------------
SELECT City, designation, SUM(Salary) AS TotalSalary
FROM Employee
GROUP BY City, designation 
HAVING SUM(Salary) > 50000;