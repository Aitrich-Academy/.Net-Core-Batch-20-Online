SELECT City, SUM(Salary) AS TotalSalary
FROM Employee 
WHERE designation  = 'Developer'
GROUP BY City;

--------------------------------------------------------------------

SELECT *
FROM Employee 
WHERE Salary > 30000;