select * from Employee

select * from Department 

-------------------------------------------------------------------

 update Employee set EmpName ='Nasif' where EmpID =14;

 -------------------------------------------------------------------

 ---Task 1: SELECT with DISTINCT, AND, OR, NOT
----	Write a query to fetch unique department names where the department name starts with 'S' 
----or the salary is greater than 50,000 but not in the 'HR' department.



 SELECT DISTINCT d.DepartmentName
FROM Employee e
JOIN Department d ON e.DepartmentID = d.DepartmentID
WHERE 
    (d.DepartmentName LIKE 'S%' or e.Salary > 50000)
    AND d.DepartmentName NOT LIKE 'HR';