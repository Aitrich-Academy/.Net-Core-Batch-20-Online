----Task 7: ALL and ANY


----	Write a query to find employees whose salary is greater than ALL salaries in the 'HR' department.

SELECT e.EmpName, e.Salary
FROM Employee e
WHERE e.Salary > ALL (
    SELECT e2.Salary
    FROM Employee e2
    JOIN Department d ON e2.DepartmentID = d.DepartmentID
    WHERE d.DepartmentName = 'HR'
);


-----Find employees whose salary is greater than ANY salary in the 'Sales' department.

SELECT e.EmpName, e.Salary
FROM Employee e
WHERE e.Salary > ANY (
    SELECT e2.Salary
    FROM Employee e2
    JOIN Department d ON e2.DepartmentID = d.DepartmentID
    WHERE d.DepartmentName = 'Sales'
);


select * from Employee 
