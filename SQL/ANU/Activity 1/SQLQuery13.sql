 SELECT DepartmentID, COUNT(*) AS EmployeeCount
FROM Employee
GROUP BY DepartmentID;


SELECT 
    D.Department_id,
    D.Department_name,
    COUNT(E.EmployeeID) AS EmployeeCount
FROM 
    Employee E
INNER JOIN 
    Department D ON E.DepartmentID = D.Department_id
GROUP BY 
   D.Department_id,
    D.Department_name
 