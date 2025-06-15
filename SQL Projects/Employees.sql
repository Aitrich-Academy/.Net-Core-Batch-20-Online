create table Department(DepartmentId int PRIMARY KEY, DepartmentName varchar(100));


create table Employee
        (
		  EmpId int PRIMARY KEY,
          EmpName varchar(100),
		  DepartmentId int REFERENCES Department(DepartmentId),
		  Salary Decimal(10,2),
		  HireDate Date  
		);
Insert into Department (DepartmentID, DepartmentName) values
        (1, 'Human Resources'),
        (2, 'Finance'),
        (3, 'IT'),
        (4, 'Marketing');

Insert into Employee (EmpID, EmpName, DepartmentID, Salary, HireDate) values
        (101, 'Alfiya Subair', 1, 50000.00, '2024-01-15'),
        (102, 'Ajmal Abdul Raheem', 3, 75000.00, '2019-03-22'),
        (103, 'Anzal A S', 2, 62000.00, '2025-07-10'),
        (104, 'Anood Nazeer', 4, 58000.00, '2022-11-01'),
        (105, 'Radhi Krishna', 3, 80000.00, '2020-06-30');

Insert into Department (DepartmentID, DepartmentName) values (5, 'Sales');

-- Insert John Doe
Insert into Employee (EmpID, EmpName, DepartmentID, Salary, HireDate) values (106, 'John Doe', 5, 60000, '2025-05-26');

Update Employee set Salary = Salary * 1.10 Where DepartmentID = (Select DepartmentID From Department Where DepartmentName = 'IT');

Delete from Employee where HireDate < '2010-01-01';

Select DepartmentID, Avg(Salary) As AverageSalary
From Employee
Group by DepartmentID
Having Avg(Salary) > 50000;

select *from Employee;
select *from Department;