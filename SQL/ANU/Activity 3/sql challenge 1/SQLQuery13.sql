
--Task 5: BETWEEN and Joins
--	Fetch all employees who were hired between '2015-01-01' and '2020-12-31' 
---along with their department name using a join.

SELECT e.EmpName, e.HireDate, d.DepartmentName
FROM Employee e
JOIN Department d ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate BETWEEN '2015-01-01' AND '2020-12-31';

select * from Employee 

update Employee set HireDate ='2019-01-01' where EmpID =22


