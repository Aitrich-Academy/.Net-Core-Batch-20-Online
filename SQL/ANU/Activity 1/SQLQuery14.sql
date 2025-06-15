SELECT City, COUNT(*) AS CustomerCount
FROM Employee 
GROUP BY City
HAVING COUNT(*) > 3;

select * from Employee 