
insert into Department (DepartmentName ) values ('Finance'  )

select * from  Department 

INSERT INTO Employee (EmpName, DepartmentID, Salary, HireDate)
VALUES ('Emin', 8, 55000.00, '2020-05-01');

select * from Employee 

----Task 6: UNION and EXISTS

---	List all employees from the 'Sales' and 'Marketing' departments using a UNION.


SELECT e.EmpName, d.DepartmentName
FROM Employee e
JOIN Department d ON e.DepartmentID = d.DepartmentID
WHERE d.DepartmentName = 'Sales'

UNION

SELECT e.EmpName, d.DepartmentName
FROM Employee e
JOIN Department d ON e.DepartmentID = d.DepartmentID
WHERE d.DepartmentName = 'Marketing';

----------------------------------------------------------------------------------

